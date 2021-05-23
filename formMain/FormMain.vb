Public Class FormMain
    Public Shared StrSerialIn As String

    Private Sub ButtonEtudiant_Click(sender As Object, e As EventArgs) Handles ButtonEtudiant.Click
        With formEtudiantList
            .TopLevel = False
            Panel2.Controls.Add(formEtudiantList)
            .BringToFront()
            .Enregistrements()
            .Show()
        End With
    End Sub

    Private Sub FormMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer_Date_Heure.Start()
        Me.CenterToScreen()
        With formConnexionArduino
            .cboBaudRate.SelectedIndex = 3
        End With
        Connection()
    End Sub

    Private Sub ButtonConnect_electronik_Click(sender As Object, e As EventArgs) Handles ButtonConnect_electronik.Click
        With formConnexionArduino
            .ShowDialog()
        End With
    End Sub

    Private Sub TimerSerialIn_Tick(sender As Object, e As EventArgs) Handles TimerSerialIn.Tick
        Try
            StrSerialIn = SerialPort1.ReadExisting
            If StrSerialIn <> "" Then
                With formEtudiant
                    .TextBoxRFID.Text = StrSerialIn
                End With
                With formAchat
                    .txtRFID.Text = StrSerialIn
                End With
            End If
        Catch ex As Exception
            TimerSerialIn.Stop()
            SerialPort1.Close()
            PictureBoxConnectionStatus.Image = My.Resources.Disconnect
        End Try
        If PictureBoxConnectionStatus.Visible = True Then 'pour faire clignoter le button vert 
            PictureBoxConnectionStatus.Visible = False
        ElseIf PictureBoxConnectionStatus.Visible = False Then
            PictureBoxConnectionStatus.Visible = True
        End If

    End Sub

    Private Sub Timer_Date_Heure_Tick(sender As Object, e As EventArgs) Handles Timer_Date_Heure.Tick
        LabelHeure.Text = "Heure actuelle : " & DateTime.Now.ToString("HH:mm:ss")
        LabelDate.Text = "Aujourd'hui  " & DateTime.Now.ToString("dd MMM, yyyy")

        With formAchat
            If .txtRFID.Text = "" Then 'pas d'identifiant d'une carte sur le champs de text 
                If .LabelScan.Visible = True Then
                    .LabelScan.Visible = False
                ElseIf .LabelScan.Visible = False Then
                    .LabelScan.Visible = True
                End If

                If .PictureBoxCarte.Visible = True Then
                    .PictureBoxCarte.Visible = False
                ElseIf .PictureBoxCarte.Visible = False Then
                    .PictureBoxCarte.Visible = True
                End If
            Else
                .LabelScan.Visible = False
                .PictureBoxCarte.Visible = False
            End If
        End With
    End Sub

    Private Sub ButtonAchat_Click(sender As Object, e As EventArgs) Handles ButtonAchat.Click
        With formAchat
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonUsers_Click(sender As Object, e As EventArgs) Handles ButtonUsers.Click
        With formUtilisateurs
            .ShowDialog()
        End With
    End Sub

    Private Sub ButtonLogout_Click(sender As Object, e As EventArgs) Handles ButtonLogout.Click
        If MsgBox("Vous-voudriez vous déconnecter ?", vbYesNo + vbQuestion) = vbYes Then
            Me.Hide()
        End If
    End Sub
End Class