Imports MySql.Data.MySqlClient
Public Class formLoginPage
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Voudriez-vous quitter la page de connection ", vbQuestion + vbYesNo) = vbYes Then
            Me.Dispose()
        End If
    End Sub

    Private Sub formLoginPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPasswordUser.PasswordChar = Chr(149)
    End Sub

    Private Sub btnCheckCode_Click(sender As Object, e As EventArgs) Handles btnCheckCode.Click
        Try
            Dim trouvé As Boolean
            If estVide(txtPasswordUser) = True Then Return
            If estVide(txtUser) = True Then Return
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM WHERE  ", con)
            dr = cmd.ExecuteReader()
            dr.Read()

            If dr.HasRows Then
                trouvé = True
            Else

            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub
End Class