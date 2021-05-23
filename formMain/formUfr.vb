Imports MySql.Data.MySqlClient
Public Class formUfr

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Dispose()
    End Sub

    Private Sub ButtonSaveUfr_Click(sender As Object, e As EventArgs) Handles ButtonSaveUfr.Click
        Try
            con.Open()
            cmd = New MySqlCommand("insert into ufr (nomUfr) value (@nom_ufr)", con)
            cmd.Parameters.AddWithValue("@nom_ufr", TextBoxUfr.Text)
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("UFR crée avec succés !", vbInformation)
            Me.Dispose()
            With formEtudiant
                .GetUFR()
            End With
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

End Class