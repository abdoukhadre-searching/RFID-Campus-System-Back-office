Imports MySql.Data.MySqlClient

Public Class formNiveau
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Dispose()
    End Sub

    Private Sub ButtonSaveUfr_Click(sender As Object, e As EventArgs) Handles ButtonSaveNiveau.Click
        Try
            con.Open()
            cmd = New MySqlCommand("insert into niveaux (libelle) value (@libelle)", con)
            cmd.Parameters.AddWithValue("@libelle", TextBoxNiveau.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("Un niveau a été ajouté !", vbInformation)
            Me.Dispose()
            With formEtudiant
                .GetNiveau()
            End With
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class