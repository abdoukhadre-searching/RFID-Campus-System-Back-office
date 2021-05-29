<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formUtilisateurs
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formUtilisateurs))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAnnulerUserCreation = New System.Windows.Forms.Button()
        Me.btnSaveUser = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboProfil = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNomAg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmailAg = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPrenomAg = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1116, 35)
        Me.Panel1.TabIndex = 33
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.formMain.My.Resources.Resources.cancel
        Me.PictureBox2.Location = New System.Drawing.Point(1082, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Gestion des utilisateurs"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(27, 70)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(882, 465)
        Me.TabControl1.TabIndex = 34
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(874, 437)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Créer un utilisateur"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Control
        Me.Panel2.Controls.Add(Me.btnAnnulerUserCreation)
        Me.Panel2.Controls.Add(Me.btnSaveUser)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(868, 431)
        Me.Panel2.TabIndex = 0
        '
        'btnAnnulerUserCreation
        '
        Me.btnAnnulerUserCreation.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAnnulerUserCreation.BackColor = System.Drawing.Color.Gray
        Me.btnAnnulerUserCreation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnulerUserCreation.FlatAppearance.BorderSize = 0
        Me.btnAnnulerUserCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnulerUserCreation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnulerUserCreation.ForeColor = System.Drawing.Color.White
        Me.btnAnnulerUserCreation.Location = New System.Drawing.Point(737, 384)
        Me.btnAnnulerUserCreation.Name = "btnAnnulerUserCreation"
        Me.btnAnnulerUserCreation.Size = New System.Drawing.Size(97, 31)
        Me.btnAnnulerUserCreation.TabIndex = 51
        Me.btnAnnulerUserCreation.Text = "Annuler "
        Me.btnAnnulerUserCreation.UseVisualStyleBackColor = False
        '
        'btnSaveUser
        '
        Me.btnSaveUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveUser.BackColor = System.Drawing.Color.GreenYellow
        Me.btnSaveUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveUser.FlatAppearance.BorderSize = 0
        Me.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnSaveUser.Location = New System.Drawing.Point(625, 384)
        Me.btnSaveUser.Name = "btnSaveUser"
        Me.btnSaveUser.Size = New System.Drawing.Size(99, 31)
        Me.btnSaveUser.TabIndex = 50
        Me.btnSaveUser.Text = "Enregistrer"
        Me.btnSaveUser.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboProfil)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboPosition)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtNomAg)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtEmailAg)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtPrenomAg)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(41, 20)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(793, 252)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations personnelles"
        '
        'cboProfil
        '
        Me.cboProfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfil.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cboProfil.FormattingEnabled = True
        Me.cboProfil.Items.AddRange(New Object() {"Admin", "Gérant Ticket", "Gérant Restaurant"})
        Me.cboProfil.Location = New System.Drawing.Point(89, 126)
        Me.cboProfil.Name = "cboProfil"
        Me.cboProfil.Size = New System.Drawing.Size(667, 27)
        Me.cboProfil.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom"
        '
        'cboPosition
        '
        Me.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosition.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Items.AddRange(New Object() {"CAMPUS 1 ( Pavillon A à Entrée Est)", "CAMPUS 2 ( Porte Restaurant Europe ) ", "CAMPUS 2 ( Pavillon C à l'entrée Ouest )", "CAMPUS 2 ( Pavillon D à l'entrée Ouest )", "Restaurant Campus 1", "Restaurant Campus 2"})
        Me.cboPosition.Location = New System.Drawing.Point(89, 161)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(667, 27)
        Me.cboPosition.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(19, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email"
        '
        'txtNomAg
        '
        Me.txtNomAg.Location = New System.Drawing.Point(89, 24)
        Me.txtNomAg.Name = "txtNomAg"
        Me.txtNomAg.Size = New System.Drawing.Size(667, 23)
        Me.txtNomAg.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(19, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Prénom"
        '
        'txtEmailAg
        '
        Me.txtEmailAg.Location = New System.Drawing.Point(89, 95)
        Me.txtEmailAg.Name = "txtEmailAg"
        Me.txtEmailAg.Size = New System.Drawing.Size(667, 23)
        Me.txtEmailAg.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(19, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Position"
        '
        'txtPrenomAg
        '
        Me.txtPrenomAg.Location = New System.Drawing.Point(89, 58)
        Me.txtPrenomAg.Name = "txtPrenomAg"
        Me.txtPrenomAg.Size = New System.Drawing.Size(667, 23)
        Me.txtPrenomAg.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(19, 134)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Profil"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(874, 437)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Changer de mot de passe"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(424, 52)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 27)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "AUTHENTIFICATION"
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Right
        Me.PictureBox3.Image = Global.formMain.My.Resources.Resources.reseaux
        Me.PictureBox3.Location = New System.Drawing.Point(937, 35)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(179, 525)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 38
        Me.PictureBox3.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.formMain.My.Resources.Resources.logo_uadb_i
        Me.PictureBox1.Location = New System.Drawing.Point(27, 41)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(62, 53)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'formUtilisateurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1116, 560)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formUtilisateurs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtPrenomAg As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmailAg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNomAg As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents cboProfil As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAnnulerUserCreation As Button
    Friend WithEvents btnSaveUser As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox3 As PictureBox
End Class
