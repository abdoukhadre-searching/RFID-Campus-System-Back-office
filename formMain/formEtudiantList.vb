Imports MySql.Data.MySqlClient

Public Class formEtudiantList
    Private Sub ButtonNewEtu_Click(sender As Object, e As EventArgs) Handles ButtonNewEtu.Click
        With formEtudiant
            .ButtonSave.Enabled = True
            .TextBoxRFID.Text = ""
            .GetUFR()
            .ShowDialog()
        End With
    End Sub

    Sub Enregistrements()
        DataGridView1.Rows.Clear()
        Dim i As Integer
        Try
            con.Open()
            cmd = New MySqlCommand("select * from etudiant", con)
            dr = cmd.ExecuteReader
            While dr.Read
                i += 1
                DataGridView1.Rows.Add(i, dr.Item("codePermanent").ToString, dr.Item("nom").ToString, dr.Item("prenom").ToString, dr.Item("filiere").ToString, dr.Item("ufr").ToString, dr.Item("niveau").ToString, dr.Item("dateNaissance").ToString, dr.Item("lieuNaissance").ToString, dr.Item("adresse").ToString, dr.Item("idCarte").ToString, dr.Item("etatCarte").ToString, dr.Item("solde").ToString)
            End While
            dr.Close()
            con.Close()
        Catch ex As Exception
            MsgBox("Vérifier que votre serveur est bien connecté  !" & vbCr & ex.Message, MsgBoxStyle.Critical, "Message d'erreur")
            con.Close()
            ' Return 'adddddd
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        Dim _filiere As String = ""
        Dim _ufr As String = ""
        Dim _niveau As String = ""

        If colName = "colEdit" Then
            With formEtudiant
                Try
                    con.Open()
                    cmd = New MySqlCommand("SELECT codePermanent, nom, prenom, filiere, ufr, niveau, dateNaissance, lieuNaissance, adresse, idCarte, etatCarte, solde, image  FROM etudiant WHERE codePermanent = '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", con)
                    dr = cmd.ExecuteReader
                    dr.Read()
                    If dr.HasRows Then
                        Dim ImgArray() As Byte = dr.Item("image")
                        Dim ImgStr As New System.IO.MemoryStream(ImgArray)
                        .PictureBox1.Image = Image.FromStream(ImgStr)
                        ImgStr.Close()
                        .TextBoxRFID.Text = dr.Item("idCarte").ToString
                        .TextBoxCodeP.Text = dr.Item("codePermanent").ToString
                        .TextBoxNom.Text = dr.Item("nom").ToString
                        .TextBoxPrenom.Text = dr.Item("prenom").ToString
                        .TextBoxLieuN.Text = dr.Item("lieuNaissance").ToString
                        .TextBoxAdresse.Text = dr.Item("adresse").ToString
                        .DateTimePicker1.Text = dr.Item("dateNaissance").ToString
                        _filiere = dr.Item("filiere").ToString
                        _ufr = dr.Item("ufr").ToString
                        _niveau = dr.Item("niveau").ToString
                        .TextBoxRFID.Text = dr.Item("idCarte").ToString
                        .TextBoxCodeP.Enabled = False
                        .ButtonSave.Enabled = False
                        .ButtonModifier.Enabled = True
                    End If
                    dr.Close()
                    con.Close()
                    .GetFiliere()
                    .GetUFR()
                    .GetNiveau()
                    .ComboBoxFilière.Text = _filiere
                    .ComboBoxNiveau.Text = _niveau
                    .ComboBoxUfr.Text = _ufr
                    .Show()
                Catch ex As Exception
                    con.Close()
                    MsgBox(ex.Message, vbCritical)
                End Try

            End With
        ElseIf colName = "colDelete" Then
            If MsgBox("Souhaitez-vous vraiment le supprimé cet enregistrement ? ", vbYesNo + vbQuestion = vbYes) Then
                Try
                    con.Open()
                    cmd = New MySqlCommand("DELETE FROM etudiant WHERE codePermanent LIKE '" & DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString & "'", con)
                    cmd.ExecuteNonQuery()
                    con.Close()
                    MsgBox("Suppression effectuée ! ", vbInformation)
                    Enregistrements()
                Catch ex As Exception
                    con.Close()
                    MsgBox(ex.Message, vbCritical)
                End Try
            End If
        End If
    End Sub


End Class