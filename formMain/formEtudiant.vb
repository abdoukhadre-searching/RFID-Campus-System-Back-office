Imports MySql.Data.MySqlClient
Imports System.IO

Public Class formEtudiant
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Dispose()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            If estVide(TextBoxRFID) = True Then Return
            If estVide(TextBoxNom) = True Then Return
            If estVide(TextBoxPrenom) = True Then Return
            If estVide(TextBoxLieuN) = True Then Return
            If estVide(TextBoxAdresse) = True Then Return
            If estVide(ComboBoxUfr) = True Then Return
            If estVide(ComboBoxFilière) = True Then Return
            If estVide(ComboBoxNiveau) = True Then Return
            If estVide(TextBoxRFID) = True Then Return

            con.Open()
            cmd = New MySqlCommand("INSERT INTO etudiant (codePermanent, nom, prenom, filiere, ufr, niveau, dateNaissance, lieuNaissance, adresse, idCarte, etatCarte, solde, image) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?)", con)
            Dim mstream As New MemoryStream
            PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim tabImage() As Byte = mstream.GetBuffer
            'TextBoxDateN.Text = Format(TextBoxDateN.Text, "dd-mm-yyyy")
            With cmd
                .Parameters.AddWithValue("@codePermanent", TextBoxCodeP.Text)
                .Parameters.AddWithValue("@nom", TextBoxNom.Text)
                .Parameters.AddWithValue("@prenom", TextBoxPrenom.Text)
                .Parameters.AddWithValue("@ufr", ComboBoxUfr.Text)
                .Parameters.AddWithValue("@filiere", ComboBoxFilière.Text)
                .Parameters.AddWithValue("@niveau", ComboBoxNiveau.Text)
                .Parameters.AddWithValue("@dateNaissance", DateTimePicker1.Value.ToShortDateString)
                .Parameters.AddWithValue("@lieuNaissance", TextBoxLieuN.Text)
                .Parameters.AddWithValue("@adresse", TextBoxAdresse.Text)
                .Parameters.AddWithValue("@idCarte", TextBoxRFID.Text)
                .Parameters.AddWithValue("@etatCarte", True)
                .Parameters.AddWithValue("@solde", 0)
                .Parameters.AddWithValue("@image", tabImage)
                .ExecuteNonQuery()
            End With
            con.Close()
            MsgBox("OK ! Un nouvau etudiant enregistré. ", vbInformation)
            EffacerChamps()
            With formEtudiantList
                .Enregistrements()
            End With
        Catch ex As Exception
            con.Close()
            MsgBox("Votre serveur n'est pas connecté ", vbCritical)
        End Try
    End Sub
    Sub EffacerChamps()
        PictureBox1.Image = Image.FromFile(Application.StartupPath & "\profil_avatar_homme_icone_ronde_24640_14044jpg.jpg")
        TextBoxAdresse.Clear()
        TextBoxCodeP.Clear()
        TextBoxLieuN.Clear()
        TextBoxNom.Clear()
        TextBoxPrenom.Clear()
        TextBoxRFID.Clear()
        ComboBoxFilière.SelectedIndex = -1
        ComboBoxNiveau.SelectedIndex = -1
        ComboBoxUfr.SelectedIndex = -1
        ButtonSave.Enabled = True
        ButtonModifier.Enabled = False
        TextBoxRFID.Focus()
    End Sub

    Sub GetUFR()
        ComboBoxUfr.SelectedIndex = -1
        ComboBoxUfr.Items.Clear()
        Try
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM ufr", con)
            dr = cmd.ExecuteReader
            While dr.Read
                ComboBoxUfr.Items.Add(dr.Item("nomUfr").ToString)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox("Vérifer l'état de votre serveur", vbCritical)
            'Return 'add
        End Try
    End Sub
    Sub GetNiveau()
        ComboBoxNiveau.SelectedIndex = -1
        ComboBoxNiveau.Items.Clear()
        Try
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM niveaux", con)
            dr = cmd.ExecuteReader
            While dr.Read
                ComboBoxNiveau.Items.Add(dr.Item("libelle").ToString)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox("Vérifer l'état de votre serveur", vbCritical)
            ' Return 'add
        End Try

    End Sub
    Sub GetFiliere()
        ComboBoxFilière.SelectedIndex = -1
        ComboBoxFilière.Items.Clear()
        Try
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM filieres INNER JOIN  ufr  WHERE filieres.ufr_idUfr = ( SELECT (idUfr) FROM ufr WHERE nomUfr = '" & ComboBoxUfr.Text & "'  )", con)
            dr = cmd.ExecuteReader
            While dr.Read
                ComboBoxFilière.Items.Add(dr.Item("nomfiliere").ToString)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox("Vérifer l'état de votre serveur", vbCritical)
            'Return 'add
        End Try

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        With formUfr
            .ShowDialog()
        End With
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Try
            If ComboBoxUfr.Text = String.Empty Then
                MsgBox("S'il vous plait sélectionner depuis la liste ! ", vbExclamation)
                Return
            End If
            If MsgBox("Souhaitez-vous vraiment supprimer cet élément ", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New MySqlCommand("delete from ufr where nomUfr=@nom_ufr", con)
                cmd.Parameters.AddWithValue("@nom_ufr", ComboBoxUfr.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("UFR supprimé avec succées ! ", vbInformation)
                GetUFR()
            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        With formFilieres
            .Charger_les_ufrs()
            .ShowDialog()
        End With
    End Sub

    Private Sub ComboBoxUfr_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxUfr.SelectedIndexChanged
        GetFiliere()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Try
            'validation champs vides
            If ComboBoxFilière.Text = String.Empty Then
                MsgBox("S'il vous plait sélectionner une filière depuis la liste déroulante", vbExclamation)
                Return
            End If
            If (MsgBox("Souhaitez-vous vraiment supprimer cet élément ", vbQuestion + vbYesNo)) = vbYes Then
                Try

                Catch ex As Exception

                End Try
                con.Open()
                cmd = New MySqlCommand("DELETE FROM filieres WHERE nomfiliere = '" & ComboBoxFilière.Text & "' and  ufr_idUfr = (SELECT (idUfr) FROM ufr WHERE nomUfr = '" & ComboBoxUfr.Text & "')", con)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Filière supprimé avec succées ! ", vbInformation)
                GetFiliere()
                ComboBoxUfr.SelectedItem = -1
            End If
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub LinkLabel5_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel5.LinkClicked
        With formNiveau
            .ShowDialog()
        End With
    End Sub

    Private Sub formEtudiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetNiveau()
    End Sub

    Private Sub ButtonAddImage_Click(sender As Object, e As EventArgs) Handles ButtonAddImage.Click
        Using o As New OpenFileDialog With {.Filter = "(Image Files)|*.jpg;*.png*.gif;|Jpg, *.jpg|Png, *.png|Gif,|*.gif", .Multiselect = False, .Title = "Select Image"}
            If o.ShowDialog = 1 Then
                PictureBox1.Image = Image.FromFile(o.FileName)
                OpenFileDialog1.FileName = o.FileName
            End If
        End Using
    End Sub

    Private Sub ButtonModifier_Click(sender As Object, e As EventArgs) Handles ButtonModifier.Click
        Try
            If estVide(TextBoxRFID) = True Then Return
            If estVide(TextBoxNom) = True Then Return
            If estVide(TextBoxPrenom) = True Then Return
            If estVide(TextBoxLieuN) = True Then Return
            If estVide(TextBoxAdresse) = True Then Return
            If estVide(ComboBoxUfr) = True Then Return
            If estVide(ComboBoxFilière) = True Then Return
            If estVide(ComboBoxNiveau) = True Then Return
            If estVide(TextBoxRFID) = True Then Return

            If MsgBox("Souhaitez-vous modifier ces information ? Cliquez sur 'Oui' pour confirmer", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                If OpenFileDialog1.FileName <> "OpenFileDialog1" Then
                    cmd = New MySqlCommand("UPDATE  etudiant SET codePermanent=@codePermanent, nom=@nom, prenom=@prenom , filiere=@filiere, ufr=@ufr, niveau=@niveau, dateNaissance=@dateNaissance, lieuNaissance=@lieuNaissance, adresse=@adresse, idCarte=@idCarte, image=@image  WHERE codePermanent=@codePermanent", con)
                Else
                    cmd = New MySqlCommand("UPDATE  etudiant SET codePermanent=@codePermanent, nom=@nom, prenom=@prenom , filiere=@filiere, ufr=@ufr, niveau=@niveau, dateNaissance=@dateNaissance, lieuNaissance=@lieuNaissance, adresse=@adresse, idCarte=@idCarte  WHERE codePermanent=@codePermanent", con)
                End If
                Dim mstream As New MemoryStream
                PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim tabImage() As Byte = mstream.GetBuffer
                'TextBoxDateN.Text = Format(TextBoxDateN.Text, "dd-mm-yyyy")
                With cmd
                    .Parameters.AddWithValue("@nom", TextBoxNom.Text)
                    .Parameters.AddWithValue("@prenom", TextBoxPrenom.Text)
                    .Parameters.AddWithValue("@ufr", ComboBoxUfr.Text)
                    .Parameters.AddWithValue("@filiere", ComboBoxFilière.Text)
                    .Parameters.AddWithValue("@niveau", ComboBoxNiveau.Text)
                    .Parameters.AddWithValue("@dateNaissance", DateTimePicker1.Value.ToShortDateString)
                    .Parameters.AddWithValue("@lieuNaissance", TextBoxLieuN.Text)
                    .Parameters.AddWithValue("@adresse", TextBoxAdresse.Text)
                    .Parameters.AddWithValue("@idCarte", TextBoxRFID.Text)
                    If OpenFileDialog1.FileName <> "OpenFileDialog1" Then .Parameters.AddWithValue("@image", tabImage)
                    .Parameters.AddWithValue("@codePermanent", TextBoxCodeP.Text)
                    .ExecuteNonQuery()
                End With
                con.Close()
                MsgBox("Données etudiant modifiées avec succés !! . ", vbInformation)
                EffacerChamps()
                With formEtudiantList
                    .Enregistrements()
                End With
                Me.Dispose()
            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub ComboBoxFilière_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFilière.SelectedIndexChanged
        'GetUFR()
    End Sub
End Class