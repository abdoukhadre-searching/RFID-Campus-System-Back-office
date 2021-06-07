Imports MySql.Data.MySqlClient

Public Class LoginForm
    Public id_agent_var As Integer
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.


    Private Sub btnConnecterLogin_Click(sender As Object, e As EventArgs) Handles btnConnecterLogin.Click
        Dim trouvé As Boolean
        If estVide(txtPasswordUser) = True Then Return
        If estVide(txtUserNom) = True Then Return
        Try
            con.Open()
            cmd = New MySqlCommand("SELECT * FROM agents WHERE nom=@nom AND password=@password ", con)
            cmd.Parameters.AddWithValue("@nom", txtUserNom.Text)
            cmd.Parameters.AddWithValue("@password", txtPasswordUser.Text)
            dr = cmd.ExecuteReader()
            dr.Read()
            If dr.HasRows Then
                trouvé = True
                id_agent_var = CInt(dr.Item("idAgents").ToString)
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

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPasswordUser.PasswordChar = Chr(149)
        Connection()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Voudriez-vous quitter la page de connection ", vbQuestion + vbYesNo) = vbYes Then
            Me.Dispose()
        End If
    End Sub
End Class
