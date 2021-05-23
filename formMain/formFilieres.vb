Imports MySql.Data.MySqlClient

Public Class formFilieres

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Dispose()
    End Sub

    Private Sub btnSaveFiliere_Click(sender As Object, e As EventArgs) Handles btnSaveFiliere.Click
        Try
            'valider les champs vides
            con.Open()
            cmd = New MySqlCommand("INSERT INTO filieres (nomfiliere, ufr_idUfr) VALUES (@nomfiliere, (SELECT (idUfr) FROM ufr WHERE nomUfr = '" & ComboBoxUfr.Text & "'))", con)
            With cmd
                .Parameters.AddWithValue("@nomfiliere", TextBoxFiliere.Text)
                .ExecuteNonQuery()
            End With
            con.Close()
            MsgBox("Nouvelle filière ajoutée", vbInformation)
            Me.Dispose()
            With formEtudiant
                .GetFiliere()
            End With
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Sub Charger_les_ufrs()
        ComboBoxUfr.Items.Clear()
        ComboBoxUfr.SelectedIndex = -1
        con.Open()
        cmd = New MySqlCommand("select * from ufr", con)
        dr = cmd.ExecuteReader
        While dr.Read
            ComboBoxUfr.Items.Add(dr.Item("nomUfr").ToString)
        End While
        dr.Close()
        con.Close()
    End Sub
End Class