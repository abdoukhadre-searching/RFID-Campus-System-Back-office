Imports MySql.Data.MySqlClient
Imports System.IO

Public Class formEtudiant
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Dispose()
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        'Try
        If estVide(TextBoxRFID) = True Then Return
        If estVide(TextBoxNom) = True Then Return
        If estVide(TextBoxPrenom) = True Then Return
        If estVide(TextBoxLieuN) = True Then Return
        If estVide(TextBoxAdresse) = True Then Return
        If estVide(ComboBoxUfr) = True Then Return
        If estVide(ComboBoxFilière) = True Then Return
        If estVide(ComboBoxNiveau) = True Then Return
        If estVide(TextBoxRFID) = True Then Return

        Try
                con.Open()
                cmd = New MySqlCommand("INSERT INTO etudiant (codePermanent, nom, prenom, dateNaissance, lieuNaissance, adresse, idCarte, etatCarte, solde, image, ufr, filiere, niveau) VALUES (?,?,?,?,?,?,?,?,?,?,?,?,?)", con)
                Dim mstream As New MemoryStream
                PictureBox1.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim tabImage() As Byte = mstream.GetBuffer
                With cmd
                .Parameters.AddWithValue("@codePermanent", TextBoxCodeP.Text)
                .Parameters.AddWithValue("@nom", TextBoxNom.Text)
                .Parameters.AddWithValue("@prenom", TextBoxPrenom.Text)
                .Parameters.AddWithValue("@dateNaissance", DateTimePicker1.Value.ToShortDateString)
                .Parameters.AddWithValue("@lieuNaissance", TextBoxLieuN.Text)
                .Parameters.AddWithValue("@adresse", TextBoxAdresse.Text)
                .Parameters.AddWithValue("@idCarte", TextBoxRFID.Text)
                .Parameters.AddWithValue("@etatCarte", True)
                .Parameters.AddWithValue("@solde", 0)
                .Parameters.AddWithValue("@image", tabImage)
                .Parameters.AddWithValue("@ufr", ComboBoxUfr.Text)
                .Parameters.AddWithValue("@filiere", ComboBoxFilière.Text)
                .Parameters.AddWithValue("@niveau", ComboBoxNiveau.Text)
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
            MsgBox(ex.Message, vbCritical)
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

            If MsgBox("Souhaitez-vous modifier ces informations ? Cliquez sur 'Oui' pour confirmer", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                If OpenFileDialog1.FileName <> "OpenFileDialog1" Then
                    cmd = New MySqlCommand("UPDATE  etudiant SET codePermanent=@codePermanent, nom=@nom, prenom=@prenom , dateNaissance=@dateNaissance, lieuNaissance=@lieuNaissance, adresse=@adresse, idCarte=@idCarte, image=@image, ufr=@ufr, filiere=@filiere, niveau=@niveau WHERE codePermanent=@codePermanent", con)
                Else
                    cmd = New MySqlCommand("UPDATE  etudiant SET codePermanent=@codePermanent, nom=@nom, prenom=@prenom , dateNaissance=@dateNaissance, lieuNaissance=@lieuNaissance, adresse=@adresse, idCarte=@idCarte , ufr=@ufr, filiere=@filiere, niveau=@niveau  WHERE codePermanent=@codePermanent", con)
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

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        EffacerChamps()
    End Sub
End Class