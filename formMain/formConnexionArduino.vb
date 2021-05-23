Public Class formConnexionArduino
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
    End Sub

    Private Sub btnScanPort_Click(sender As Object, e As EventArgs) Handles btnScanPort.Click
        cboScanPort.Items.Clear()
        Dim myPort As Array
        Dim i As Integer
        myPort = IO.Ports.SerialPort.GetPortNames()
        cboScanPort.Items.AddRange(myPort)
        i = cboScanPort.Items.Count
        i = i - i
        Try
            cboScanPort.SelectedIndex = i
        Catch ex As Exception
            MsgBox("Port COM non détecté", MsgBoxStyle.Critical, "Message d'erreur")
            cboScanPort.Text = ""
            cboScanPort.Items.Clear()
            Return
        End Try
        cboScanPort.DroppedDown = True
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        If btnConnect.Text = "Connecter" Then
            With FormMain
                Try
                    .SerialPort1.BaudRate = cboBaudRate.SelectedItem
                    .SerialPort1.PortName = cboScanPort.SelectedItem
                    .SerialPort1.Open()
                    .TimerSerialIn.Start()
                    btnConnect.Text = "Déconnecté"
                    btnConnect.BackColor = Color.Red
                    '.ButtonConnect_electronik.Enabled = False
                    .PictureBoxConnectionStatus.Image = My.Resources.icone_connected
                Catch ex As Exception
                    MsgBox("Echec de la connection !" & vbCr & "L'Arduino n'est pas détecté.", vbExclamation, "Message d'erreur")
                    .PictureBoxConnectionStatus.Image = My.Resources.Disconnect
                End Try
            End With
        ElseIf btnConnect.Text = "Déconnecté" Then
            FormMain.PictureBoxConnectionStatus.Image = My.Resources.Disconnect
            btnConnect.BackColor = Color.Red
            FormMain.TimerSerialIn.Stop()
            FormMain.SerialPort1.Close()
        End If

    End Sub
End Class