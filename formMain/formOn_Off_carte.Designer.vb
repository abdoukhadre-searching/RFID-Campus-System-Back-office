<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formOn_Off_carte
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formOn_Off_carte))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_on_off_carte = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConfirmAchat = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(0, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(430, 77)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Espace d'Activation et de Désactivation de carte"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(565, 29)
        Me.Panel1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 18)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Identifiant Carte RFID :"
        '
        'Label_on_off_carte
        '
        Me.Label_on_off_carte.AutoSize = True
        Me.Label_on_off_carte.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_on_off_carte.ForeColor = System.Drawing.Color.Green
        Me.Label_on_off_carte.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label_on_off_carte.Location = New System.Drawing.Point(33, 162)
        Me.Label_on_off_carte.Name = "Label_on_off_carte"
        Me.Label_on_off_carte.Size = New System.Drawing.Size(143, 17)
        Me.Label_on_off_carte.TabIndex = 48
        Me.Label_on_off_carte.Text = "_______________"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(211, 162)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(135, 41)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "ACTIVER"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Image = Global.formMain.My.Resources.Resources.Disconnect
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label4.Location = New System.Drawing.Point(208, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 18)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Statut carte :"
        '
        'btnConfirmAchat
        '
        Me.btnConfirmAchat.BackColor = System.Drawing.Color.Green
        Me.btnConfirmAchat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmAchat.FlatAppearance.BorderSize = 0
        Me.btnConfirmAchat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen
        Me.btnConfirmAchat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal
        Me.btnConfirmAchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmAchat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmAchat.ForeColor = System.Drawing.Color.White
        Me.btnConfirmAchat.Image = Global.formMain.My.Resources.Resources.wifi_signal_
        Me.btnConfirmAchat.Location = New System.Drawing.Point(36, 274)
        Me.btnConfirmAchat.Name = "btnConfirmAchat"
        Me.btnConfirmAchat.Size = New System.Drawing.Size(229, 41)
        Me.btnConfirmAchat.TabIndex = 46
        Me.btnConfirmAchat.Text = "     Scanner la carte"
        Me.btnConfirmAchat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmAchat.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.formMain.My.Resources.Resources.cancel
        Me.PictureBox2.Location = New System.Drawing.Point(526, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(27, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.formMain.My.Resources.Resources.carte_rfid
        Me.PictureBox3.Location = New System.Drawing.Point(436, 29)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(117, 80)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.formMain.My.Resources.Resources.loading_icon_animated_gif_191
        Me.PictureBox1.Location = New System.Drawing.Point(373, 133)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 182)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 18)
        Me.Label3.TabIndex = 51
        Me.Label3.Text = "Nom du bénéficier(e) :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label5.Location = New System.Drawing.Point(33, 231)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 17)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "_______________"
        '
        'btncancel
        '
        Me.btncancel.BackColor = System.Drawing.Color.Gray
        Me.btncancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancel.FlatAppearance.BorderSize = 0
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancel.ForeColor = System.Drawing.Color.White
        Me.btncancel.Location = New System.Drawing.Point(271, 274)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(84, 41)
        Me.btncancel.TabIndex = 53
        Me.btncancel.Text = "Annuler"
        Me.btncancel.UseVisualStyleBackColor = False
        '
        'formOn_Off_carte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(565, 338)
        Me.ControlBox = False
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label_on_off_carte)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnConfirmAchat)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formOn_Off_carte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents btnConfirmAchat As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_on_off_carte As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btncancel As Button
End Class
