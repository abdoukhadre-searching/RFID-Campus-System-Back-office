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

    Private Sub btnConnecterLogin_Click(sender As Object, e As EventArgs) Handles btnConnecterLogin.Click
        Try
            Dim trouvé As Boolean
            If estVide(txtPasswordUser) = True Then Return
            If estVide(txtUserNom) = True Then Return
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM agents WHERE nom=@nom AND password=@password ", con)
            cmd.Parameters.AddWithValue("@nom", txtUserNom.Text)
            cmd.Parameters.AddWithValue("@password", txtPasswordUser.Text)
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then
                trouvé = True
                role_User = dr.Item("profil").ToString
                nom_User = dr.Item("prenom").ToString 'dr.Item("nom").ToString  
                motdepasse_User = dr.Item("password").ToString
            Else
                trouvé = False
            End If

            If trouvé = True Then
                With FormMain
                    If role_User <> "Admin" Then
                        .ButtonUsers.Enabled = False
                        formEtudiantList.ButtonNewEtu.Enabled = False
                    End If
                    .LabelNomUser.Text = nom_User
                    .LabelProfil.Text = role_User
                    txtPasswordUser.Clear()
                    txtUserNom.Clear()
                    Me.Hide()
                    .Show()
                End With
            Else
                MsgBox("Mot de passe ou le nom d'utilisateur saisi est incorrect ! ", vbExclamation)
            End If
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
            con.Close()
        End Try
    End Sub
End Class