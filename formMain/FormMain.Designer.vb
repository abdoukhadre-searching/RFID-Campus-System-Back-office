<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormMain))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelProfil = New System.Windows.Forms.Label()
        Me.LabelNomUser = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Timer_Date_Heure = New System.Windows.Forms.Timer(Me.components)
        Me.TimerSerialIn = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelHeure = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBoxConnectionStatus = New System.Windows.Forms.PictureBox()
        Me.ButtonConnect_electronik = New System.Windows.Forms.Button()
        Me.ButtonRevue = New System.Windows.Forms.Button()
        Me.ButtonAchat = New System.Windows.Forms.Button()
        Me.ButtonLogout = New System.Windows.Forms.Button()
        Me.ButtonUsers = New System.Windows.Forms.Button()
        Me.ButtonPersonnel = New System.Windows.Forms.Button()
        Me.ButtonEtudiant = New System.Windows.Forms.Button()
        Me.ButtonAcceuil = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBoxConnectionStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LabelHeure)
        Me.Panel1.Controls.Add(Me.LabelDate)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.PictureBoxConnectionStatus)
        Me.Panel1.Controls.Add(Me.ButtonConnect_electronik)
        Me.Panel1.Controls.Add(Me.ButtonRevue)
        Me.Panel1.Controls.Add(Me.ButtonAchat)
        Me.Panel1.Controls.Add(Me.ButtonLogout)
        Me.Panel1.Controls.Add(Me.ButtonUsers)
        Me.Panel1.Controls.Add(Me.ButtonPersonnel)
        Me.Panel1.Controls.Add(Me.ButtonEtudiant)
        Me.Panel1.Controls.Add(Me.ButtonAcceuil)
        Me.Panel1.Controls.Add(Me.LabelProfil)
        Me.Panel1.Controls.Add(Me.LabelNomUser)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(249, 708)
        Me.Panel1.TabIndex = 0
        '
        'LabelProfil
        '
        Me.LabelProfil.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.LabelProfil.ForeColor = System.Drawing.Color.Cyan
        Me.LabelProfil.Location = New System.Drawing.Point(23, 163)
        Me.LabelProfil.Name = "LabelProfil"
        Me.LabelProfil.Size = New System.Drawing.Size(197, 23)
        Me.LabelProfil.TabIndex = 2
        Me.LabelProfil.Text = "Admin"
        Me.LabelProfil.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelNomUser
        '
        Me.LabelNomUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelNomUser.ForeColor = System.Drawing.Color.White
        Me.LabelNomUser.Location = New System.Drawing.Point(21, 141)
        Me.LabelNomUser.Name = "LabelNomUser"
        Me.LabelNomUser.Size = New System.Drawing.Size(197, 23)
        Me.LabelNomUser.TabIndex = 1
        Me.LabelNomUser.Text = "Modou  Nar Nongo"
        Me.LabelNomUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(249, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(907, 708)
        Me.Panel2.TabIndex = 1
        '
        'Timer_Date_Heure
        '
        '
        'TimerSerialIn
        '
        Me.TimerSerialIn.Interval = 1000
        '
        'LabelDate
        '
        Me.LabelDate.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.LabelDate.Location = New System.Drawing.Point(22, 196)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(197, 23)
        Me.LabelDate.TabIndex = 40
        Me.LabelDate.Text = "Date"
        Me.LabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelHeure
        '
        Me.LabelHeure.ForeColor = System.Drawing.Color.PaleTurquoise
        Me.LabelHeure.Location = New System.Drawing.Point(23, 217)
        Me.LabelHeure.Name = "LabelHeure"
        Me.LabelHeure.Size = New System.Drawing.Size(197, 23)
        Me.LabelHeure.TabIndex = 41
        Me.LabelHeure.Text = "Heure"
        Me.LabelHeure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.formMain.My.Resources.Resources.wifi_signal_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(19, 452)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(200, 38)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "  RFID passage carte"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBoxConnectionStatus
        '
        Me.PictureBoxConnectionStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBoxConnectionStatus.Image = Global.formMain.My.Resources.Resources.Disconnect
        Me.PictureBoxConnectionStatus.Location = New System.Drawing.Point(12, 12)
        Me.PictureBoxConnectionStatus.Name = "PictureBoxConnectionStatus"
        Me.PictureBoxConnectionStatus.Size = New System.Drawing.Size(18, 17)
        Me.PictureBoxConnectionStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxConnectionStatus.TabIndex = 38
        Me.PictureBoxConnectionStatus.TabStop = False
        '
        'ButtonConnect_electronik
        '
        Me.ButtonConnect_electronik.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonConnect_electronik.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.ButtonConnect_electronik.FlatAppearance.BorderSize = 0
        Me.ButtonConnect_electronik.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonConnect_electronik.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.ButtonConnect_electronik.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonConnect_electronik.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonConnect_electronik.ForeColor = System.Drawing.Color.White
        Me.ButtonConnect_electronik.Image = Global.formMain.My.Resources.Resources.usb_port__1_
        Me.ButtonConnect_electronik.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonConnect_electronik.Location = New System.Drawing.Point(19, 574)
        Me.ButtonConnect_electronik.Name = "ButtonConnect_electronik"
        Me.ButtonConnect_electronik.Size = New System.Drawing.Size(200, 34)
        Me.ButtonConnect_electronik.TabIndex = 11
        Me.ButtonConnect_electronik.Text = "  Connexion du matériel"
        Me.ButtonConnect_electronik.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonConnect_electronik.UseVisualStyleBackColor = True
        '
        'ButtonRevue
        '
        Me.ButtonRevue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonRevue.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.ButtonRevue.FlatAppearance.BorderSize = 0
        Me.ButtonRevue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonRevue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.ButtonRevue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonRevue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonRevue.ForeColor = System.Drawing.Color.White
        Me.ButtonRevue.Image = Global.formMain.My.Resources.Resources.folder
        Me.ButtonRevue.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonRevue.Location = New System.Drawing.Point(19, 535)
        Me.ButtonRevue.Name = "ButtonRevue"
        Me.ButtonRevue.Size = New System.Drawing.Size(200, 34)
        Me.ButtonRevue.TabIndex = 10
        Me.ButtonRevue.Text = "  Revue"
        Me.ButtonRevue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonRevue.UseVisualStyleBackColor = True
        '
        'ButtonAchat
        '
        Me.ButtonAchat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAchat.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.ButtonAchat.FlatAppearance.BorderSize = 0
        Me.ButtonAchat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonAchat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.ButtonAchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAchat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAchat.ForeColor = System.Drawing.Color.White
        Me.ButtonAchat.Image = Global.formMain.My.Resources.Resources.shopping_cart
        Me.ButtonAchat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAchat.Location = New System.Drawing.Point(19, 413)
        Me.ButtonAchat.Name = "ButtonAchat"
        Me.ButtonAchat.Size = New System.Drawing.Size(200, 34)
        Me.ButtonAchat.TabIndex = 9
        Me.ButtonAchat.Text = "     Achat"
        Me.ButtonAchat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAchat.UseVisualStyleBackColor = True
        '
        'ButtonLogout
        '
        Me.ButtonLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonLogout.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ButtonLogout.FlatAppearance.BorderSize = 0
        Me.ButtonLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red
        Me.ButtonLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed
        Me.ButtonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonLogout.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonLogout.ForeColor = System.Drawing.Color.White
        Me.ButtonLogout.Image = Global.formMain.My.Resources.Resources.logout__1_
        Me.ButtonLogout.Location = New System.Drawing.Point(0, 674)
        Me.ButtonLogout.Name = "ButtonLogout"
        Me.ButtonLogout.Size = New System.Drawing.Size(249, 34)
        Me.ButtonLogout.TabIndex = 8
        Me.ButtonLogout.Text = "          DECONNECTION"
        Me.ButtonLogout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonLogout.UseVisualStyleBackColor = True
        '
        'ButtonUsers
        '
        Me.ButtonUsers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonUsers.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.ButtonUsers.FlatAppearance.BorderSize = 0
        Me.ButtonUsers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.ButtonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonUsers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonUsers.ForeColor = System.Drawing.Color.White
        Me.ButtonUsers.Image = Global.formMain.My.Resources.Resources.programmer
        Me.ButtonUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonUsers.Location = New System.Drawing.Point(19, 496)
        Me.ButtonUsers.Name = "ButtonUsers"
        Me.ButtonUsers.Size = New System.Drawing.Size(200, 34)
        Me.ButtonUsers.TabIndex = 6
        Me.ButtonUsers.Text = "   Gestion des utilisateurs"
        Me.ButtonUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonUsers.UseVisualStyleBackColor = True
        '
        'ButtonPersonnel
        '
        Me.ButtonPersonnel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonPersonnel.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.ButtonPersonnel.FlatAppearance.BorderSize = 0
        Me.ButtonPersonnel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonPersonnel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.ButtonPersonnel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonPersonnel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonPersonnel.ForeColor = System.Drawing.Color.White
        Me.ButtonPersonnel.Image = Global.formMain.My.Resources.Resources.profile__1_
        Me.ButtonPersonnel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonPersonnel.Location = New System.Drawing.Point(19, 371)
        Me.ButtonPersonnel.Name = "ButtonPersonnel"
        Me.ButtonPersonnel.Size = New System.Drawing.Size(200, 34)
        Me.ButtonPersonnel.TabIndex = 5
        Me.ButtonPersonnel.Text = "   Gestion du Personnel"
        Me.ButtonPersonnel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonPersonnel.UseVisualStyleBackColor = True
        '
        'ButtonEtudiant
        '
        Me.ButtonEtudiant.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonEtudiant.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.ButtonEtudiant.FlatAppearance.BorderSize = 0
        Me.ButtonEtudiant.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonEtudiant.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.ButtonEtudiant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonEtudiant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEtudiant.ForeColor = System.Drawing.Color.White
        Me.ButtonEtudiant.Image = Global.formMain.My.Resources.Resources.profile__1_
        Me.ButtonEtudiant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonEtudiant.Location = New System.Drawing.Point(18, 331)
        Me.ButtonEtudiant.Name = "ButtonEtudiant"
        Me.ButtonEtudiant.Size = New System.Drawing.Size(200, 34)
        Me.ButtonEtudiant.TabIndex = 4
        Me.ButtonEtudiant.Text = "   Gestion de l'étudiant"
        Me.ButtonEtudiant.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonEtudiant.UseVisualStyleBackColor = True
        '
        'ButtonAcceuil
        '
        Me.ButtonAcceuil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAcceuil.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan
        Me.ButtonAcceuil.FlatAppearance.BorderSize = 0
        Me.ButtonAcceuil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.ButtonAcceuil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.ButtonAcceuil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAcceuil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAcceuil.ForeColor = System.Drawing.Color.White
        Me.ButtonAcceuil.Image = Global.formMain.My.Resources.Resources.dashboard
        Me.ButtonAcceuil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonAcceuil.Location = New System.Drawing.Point(18, 292)
        Me.ButtonAcceuil.Name = "ButtonAcceuil"
        Me.ButtonAcceuil.Size = New System.Drawing.Size(200, 34)
        Me.ButtonAcceuil.TabIndex = 3
        Me.ButtonAcceuil.Text = "     Acceuil"
        Me.ButtonAcceuil.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonAcceuil.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.formMain.My.Resources.Resources.businessman
        Me.PictureBox1.Location = New System.Drawing.Point(71, 48)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 90)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FormMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1156, 708)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormMain"
        Me.Text = "RFID Campus System"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBoxConnectionStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonAcceuil As Button
    Friend WithEvents LabelProfil As Label
    Friend WithEvents LabelNomUser As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonUsers As Button
    Friend WithEvents ButtonPersonnel As Button
    Friend WithEvents ButtonEtudiant As Button
    Friend WithEvents ButtonLogout As Button
    Friend WithEvents ButtonAchat As Button
    Friend WithEvents ButtonRevue As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Timer_Date_Heure As Timer
    Friend WithEvents ButtonConnect_electronik As Button
    Friend WithEvents TimerSerialIn As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents PictureBoxConnectionStatus As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelHeure As Label
    Friend WithEvents LabelDate As Label
End Class
