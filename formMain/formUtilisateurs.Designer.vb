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
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAnnulerUserCreation = New System.Windows.Forms.Button()
        Me.btnSaveUser = New System.Windows.Forms.Button()
        Me.cboPosition = New System.Windows.Forms.ComboBox()
        Me.cboProfil = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPassword2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPrenomAg = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmailAg = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPassword1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNomAg = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.formMain.My.Resources.Resources.cancel
        Me.PictureBox2.Location = New System.Drawing.Point(895, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(929, 35)
        Me.Panel1.TabIndex = 33
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
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(26, 68)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(891, 361)
        Me.TabControl1.TabIndex = 34
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(883, 333)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Créer un utilisateur"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAnnulerUserCreation)
        Me.Panel2.Controls.Add(Me.btnSaveUser)
        Me.Panel2.Controls.Add(Me.cboPosition)
        Me.Panel2.Controls.Add(Me.cboProfil)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtPassword2)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtPrenomAg)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtEmailAg)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.txtPassword1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtNomAg)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(877, 327)
        Me.Panel2.TabIndex = 0
        '
        'btnAnnulerUserCreation
        '
        Me.btnAnnulerUserCreation.BackColor = System.Drawing.Color.Gray
        Me.btnAnnulerUserCreation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnulerUserCreation.FlatAppearance.BorderSize = 0
        Me.btnAnnulerUserCreation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnulerUserCreation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnulerUserCreation.ForeColor = System.Drawing.Color.White
        Me.btnAnnulerUserCreation.Location = New System.Drawing.Point(721, 269)
        Me.btnAnnulerUserCreation.Name = "btnAnnulerUserCreation"
        Me.btnAnnulerUserCreation.Size = New System.Drawing.Size(87, 31)
        Me.btnAnnulerUserCreation.TabIndex = 47
        Me.btnAnnulerUserCreation.Text = "Annuler "
        Me.btnAnnulerUserCreation.UseVisualStyleBackColor = False
        '
        'btnSaveUser
        '
        Me.btnSaveUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnSaveUser.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveUser.FlatAppearance.BorderSize = 0
        Me.btnSaveUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveUser.ForeColor = System.Drawing.Color.White
        Me.btnSaveUser.Location = New System.Drawing.Point(629, 269)
        Me.btnSaveUser.Name = "btnSaveUser"
        Me.btnSaveUser.Size = New System.Drawing.Size(86, 31)
        Me.btnSaveUser.TabIndex = 45
        Me.btnSaveUser.Text = "Enregistrer"
        Me.btnSaveUser.UseVisualStyleBackColor = False
        '
        'cboPosition
        '
        Me.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPosition.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPosition.FormattingEnabled = True
        Me.cboPosition.Items.AddRange(New Object() {"CAMPUS 1 ( Pavillon A à Entrée Est)", "CAMPUS 2 ( Porte Restaurant Europe ) ", "CAMPUS 2 ( Pavillon C à l'entrée Ouest )", "CAMPUS 2 ( Pavillon D à l'entrée Ouest )"})
        Me.cboPosition.Location = New System.Drawing.Point(226, 159)
        Me.cboPosition.Name = "cboPosition"
        Me.cboPosition.Size = New System.Drawing.Size(582, 27)
        Me.cboPosition.TabIndex = 13
        '
        'cboProfil
        '
        Me.cboProfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProfil.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.cboProfil.FormattingEnabled = True
        Me.cboProfil.Items.AddRange(New Object() {"Admin", "Gérant Ticket", "Gérant Restaurant"})
        Me.cboProfil.Location = New System.Drawing.Point(226, 124)
        Me.cboProfil.Name = "cboProfil"
        Me.cboProfil.Size = New System.Drawing.Size(582, 27)
        Me.cboProfil.TabIndex = 12
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(152, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 19)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Position"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(166, 130)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Profil"
        '
        'txtPassword2
        '
        Me.txtPassword2.Location = New System.Drawing.Point(226, 226)
        Me.txtPassword2.Name = "txtPassword2"
        Me.txtPassword2.Size = New System.Drawing.Size(582, 23)
        Me.txtPassword2.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(37, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ré-ecrire le mot de passe"
        '
        'txtPrenomAg
        '
        Me.txtPrenomAg.Location = New System.Drawing.Point(227, 62)
        Me.txtPrenomAg.Name = "txtPrenomAg"
        Me.txtPrenomAg.Size = New System.Drawing.Size(581, 23)
        Me.txtPrenomAg.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(154, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Prénom"
        '
        'txtEmailAg
        '
        Me.txtEmailAg.Location = New System.Drawing.Point(227, 93)
        Me.txtEmailAg.Name = "txtEmailAg"
        Me.txtEmailAg.Size = New System.Drawing.Size(581, 23)
        Me.txtEmailAg.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(166, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 19)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Email"
        '
        'txtPassword1
        '
        Me.txtPassword1.Location = New System.Drawing.Point(226, 194)
        Me.txtPassword1.Name = "txtPassword1"
        Me.txtPassword1.Size = New System.Drawing.Size(582, 23)
        Me.txtPassword1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(115, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mot de passe"
        '
        'txtNomAg
        '
        Me.txtNomAg.Location = New System.Drawing.Point(226, 31)
        Me.txtNomAg.Name = "txtNomAg"
        Me.txtNomAg.Size = New System.Drawing.Size(582, 23)
        Me.txtNomAg.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom"
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(883, 333)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Changer de mot de passe"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'formUtilisateurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(929, 460)
        Me.ControlBox = False
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formUtilisateurs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents txtPassword1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNomAg As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents cboPosition As ComboBox
    Friend WithEvents cboProfil As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPassword2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSaveUser As Button
    Friend WithEvents btnAnnulerUserCreation As Button
End Class
