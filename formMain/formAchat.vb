Imports MySql.Data.MySqlClient
Public Class formAchat

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Dispose()
    End Sub

    Private Sub txtRFID_TextChanged(sender As Object, e As EventArgs) Handles txtRFID.TextChanged
        If txtRFID.TextLength = 8 Then
            ACHAT_ETUDIANT()
        End If
    End Sub
    Sub ACHAT_ETUDIANT()
        con.Open()
        cmd = New MySqlCommand("SELECT codePermanent, nom, prenom, filiere, ufr, niveau, dateNaissance, lieuNaissance, adresse, idCarte, etatCarte, solde, image  FROM etudiant WHERE idCarte LIKE '" & txtRFID.Text & "'", con)
        dr = cmd.ExecuteReader
        dr.Read()
        If dr.HasRows Then
            Dim ImgArray() As Byte = dr.Item("image")
            Dim ImgStr As New System.IO.MemoryStream(ImgArray)
            PictureBox1.Image = Image.FromStream(ImgStr)
            ImgStr.Close()
            txtRFID.Text = dr.Item("idCarte").ToString
            txtCP.Text = dr.Item("codePermanent").ToString
            txtNom.Text = dr.Item("nom").ToString
            txtPrenom.Text = dr.Item("prenom").ToString
            txtFiliere.Text = dr.Item("filiere").ToString
            txtUfr.Text = dr.Item("ufr").ToString
            txtNiveau.Text = dr.Item("niveau").ToString
            LabelSolde.Text = CInt(dr.Item("solde").ToString)
        End If
        dr.Close() 'add
        con.Close() 'add
    End Sub

    Private Sub btnConfirmAchat_Click(sender As Object, e As EventArgs) Handles btnConfirmAchat.Click
        Try
            If txtCodeAchat.Visible = True Then
                If estVide(txtCodeAchat) = True Then Return
            End If
            If estVide(txtMontantAchat) = True Then Return
            If MsgBox("Vous confirmez la transaction ?  ", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New MySqlCommand("INSERT INTO ", con)
                'cmd.Parameters.AddWithValue("",)
                'cmd.Parameters.AddWithValue("",)
                'cmd.Parameters.AddWithValue("",)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Achat effectué ! ", vbInformation)
                ACHAT_ETUDIANT()
                txtMontantAchat.Clear()
            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cboAchat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAchat.SelectedIndexChanged
        If cboAchat.Text = "Acheter via un code pré-généré" Then
            Label10.Visible = True
            btnCheckCode.Visible = True
            txtCodeAchat.Visible = True
        End If
    End Sub

    Private Sub btnAnnulerAchat_Click(sender As Object, e As EventArgs) Handles btnAnnulerAchat.Click
        txtRFID.Clear()
        txtCP.Clear()
        txtNom.Clear()
        txtPrenom.Clear()
        txtFiliere.Clear()
        txtUfr.Clear()
        txtNiveau.Clear()
        txtMontantAchat.Clear()
        txtCodeAchat.Clear()
        cboAchat.Text = ""
        LabelSolde.Text = "_____"
        PictureBox1.Image = My.Resources.businessman
    End Sub

    Private Sub txtMontantAchat_TextChanged(sender As Object, e As EventArgs) Handles txtMontantAchat.TextChanged

    End Sub

    Private Sub txtMontantAchat_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMontantAchat.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' nombre entre 0 et 9 ici leur code en ASCII
                'Case &HC 'Valeur de la touche effacer (vbKeyClear)
            Case Else
                e.Handled = True
        End Select
    End Sub
End Class