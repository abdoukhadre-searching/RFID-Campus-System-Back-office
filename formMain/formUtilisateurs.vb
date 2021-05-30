Imports MySql.Data.MySqlClient

Public Class formUtilisateurs
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Dispose()
    End Sub

    '    Private Sub formUtilisateurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '        txtPassword1.PasswordChar = Chr(149)
    '        txtPassword2.PasswordChar = Chr(149)
    '    End Sub

    Sub clear()
        txtEmailAg.Clear()
        txtNomAg.Clear()
        txtPrenomAg.Clear()
        '      txtPassword1.Clear()
        '      txtPassword2.Clear()
        cboPosition.SelectedIndex = -1
        cboProfil.SelectedIndex = -1
    End Sub
    Private Sub btnAnnulerUserCreation_Click(sender As Object, e As EventArgs)
        clear()
        txtNomAg.Focus()
    End Sub




    Private Sub btnSaveUser_Click_1(sender As Object, e As EventArgs) Handles btnSaveUser.Click
        Try

            If estVide(txtNomAg) = True Then Return
            If estVide(txtPrenomAg) = True Then Return
            If estVide(txtEmailAg) = True Then Return
            'If estVide(txtPassword1) = True Then Return
            'If estVide(txtPassword2) = True Then Return
            If estVide(cboPosition) = True Then Return
            If estVide(cboProfil) = True Then Return

            '           If txtPassword1.Text <> txtPassword2.Text Then
            '           MsgBox("Le mot de passe de confirmation ne correspond pas au précédent ", vbExclamation)
            '          Return
            '         End If

            If MsgBox("Ajout des informations personnelles d'un nouvel utilisateur ? Cliquer sur 'Oui' pour confirmer", vbQuestion + vbYesNo) = vbYes Then
                con.Open()
                cmd = New MySqlCommand("INSERT INTO agents (nom, prenom, position, profil, email, password, etatCompte) VALUES (@nom, @prenom, @position, @profil, @email, @password, @etatCompte)", con)
                With cmd
                    .Parameters.AddWithValue("@nom", txtNomAg.Text)
                    .Parameters.AddWithValue("@prenom", txtPrenomAg.Text)
                    .Parameters.AddWithValue("@position", cboPosition.Text)
                    .Parameters.AddWithValue("@profil", cboProfil.Text)
                    .Parameters.AddWithValue("@email", txtEmailAg.Text)
                    .Parameters.AddWithValue("@password", "defaultpassword")
                    .Parameters.AddWithValue("@etatCompte", "non-actif")
                    .ExecuteNonQuery()
                End With
                con.Close()
                MsgBox("C'est bon ! Maintenant vous pouvez gérer ses informations d'authentification plutard. ", vbInformation)
                clear()
            End If

        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
            '           clear()
            txtNomAg.Focus()
        End Try
    End Sub



End Class