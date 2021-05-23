Imports MySql.Data.MySqlClient
Module Module1_connection
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public dr As MySqlDataReader

    Public Sub Connection()
        con = New MySqlConnection
        With con
            .ConnectionString = "server=localhost;user id=root;password=;database=db_rfid"
        End With
    End Sub
    Function estVide(ByVal pText As Object) As Boolean
        If pText.text = String.Empty Then
            pText.BackColor = Color.LemonChiffon
            pText.focus
            MsgBox("Attention ! Un champ obligatoire est vide ", vbCritical)
            estVide = True
        Else
            pText.BackColor = Color.White
            estVide = False
        End If
    End Function


End Module
