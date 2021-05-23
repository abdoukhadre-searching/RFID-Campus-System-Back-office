<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formAchat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formAchat))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCP = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPrenom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRFID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNiveau = New System.Windows.Forms.TextBox()
        Me.txtFiliere = New System.Windows.Forms.TextBox()
        Me.txtUfr = New System.Windows.Forms.TextBox()
        Me.LabelSolde = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelScan = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAnnulerAchat = New System.Windows.Forms.Button()
        Me.btnConfirmAchat = New System.Windows.Forms.Button()
        Me.btnCheckCode = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboAchat = New System.Windows.Forms.ComboBox()
        Me.txtCodeAchat = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMontantAchat = New System.Windows.Forms.TextBox()
        Me.PictureBoxCarte = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBoxCarte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Rechargement Carte / Achat"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1034, 35)
        Me.Panel1.TabIndex = 32
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.formMain.My.Resources.Resources.cancel
        Me.PictureBox2.Location = New System.Drawing.Point(1000, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(117, 483)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 19)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "NIVEAU"
        '
        'txtCP
        '
        Me.txtCP.Enabled = False
        Me.txtCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCP.Location = New System.Drawing.Point(236, 389)
        Me.txtCP.Name = "txtCP"
        Me.txtCP.Size = New System.Drawing.Size(276, 26)
        Me.txtCP.TabIndex = 52
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(83, 394)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 19)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "CODE PERMANENT"
        '
        'txtPrenom
        '
        Me.txtPrenom.Enabled = False
        Me.txtPrenom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrenom.Location = New System.Drawing.Point(236, 359)
        Me.txtPrenom.Name = "txtPrenom"
        Me.txtPrenom.Size = New System.Drawing.Size(276, 26)
        Me.txtPrenom.TabIndex = 46
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(116, 365)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 19)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "PRENOM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(127, 424)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 19)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "UFR"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(118, 454)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "FILIERE"
        '
        'txtNom
        '
        Me.txtNom.Enabled = False
        Me.txtNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.Location = New System.Drawing.Point(236, 329)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(276, 26)
        Me.txtNom.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(126, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "NOM"
        '
        'txtRFID
        '
        Me.txtRFID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRFID.ForeColor = System.Drawing.Color.RoyalBlue
        Me.txtRFID.Location = New System.Drawing.Point(236, 301)
        Me.txtRFID.MaxLength = 8
        Me.txtRFID.Name = "txtRFID"
        Me.txtRFID.Size = New System.Drawing.Size(276, 24)
        Me.txtRFID.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(82, 304)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 19)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Identifiant  n° RFID"
        '
        'txtNiveau
        '
        Me.txtNiveau.Enabled = False
        Me.txtNiveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNiveau.Location = New System.Drawing.Point(236, 479)
        Me.txtNiveau.Name = "txtNiveau"
        Me.txtNiveau.Size = New System.Drawing.Size(276, 26)
        Me.txtNiveau.TabIndex = 56
        '
        'txtFiliere
        '
        Me.txtFiliere.Enabled = False
        Me.txtFiliere.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFiliere.Location = New System.Drawing.Point(236, 449)
        Me.txtFiliere.Name = "txtFiliere"
        Me.txtFiliere.Size = New System.Drawing.Size(276, 26)
        Me.txtFiliere.TabIndex = 55
        '
        'txtUfr
        '
        Me.txtUfr.Enabled = False
        Me.txtUfr.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUfr.Location = New System.Drawing.Point(236, 419)
        Me.txtUfr.Name = "txtUfr"
        Me.txtUfr.Size = New System.Drawing.Size(276, 26)
        Me.txtUfr.TabIndex = 54
        '
        'LabelSolde
        '
        Me.LabelSolde.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LabelSolde.Font = New System.Drawing.Font("Calibri", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSolde.ForeColor = System.Drawing.Color.Green
        Me.LabelSolde.Location = New System.Drawing.Point(662, 121)
        Me.LabelSolde.Name = "LabelSolde"
        Me.LabelSolde.Size = New System.Drawing.Size(249, 92)
        Me.LabelSolde.TabIndex = 58
        Me.LabelSolde.Text = "_____"
        Me.LabelSolde.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(719, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 29)
        Me.Label6.TabIndex = 59
        Me.Label6.Text = "Votre solde:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Green
        Me.Label8.Location = New System.Drawing.Point(870, 150)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 60)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Fcfa"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelScan
        '
        Me.LabelScan.AutoSize = True
        Me.LabelScan.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelScan.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LabelScan.Location = New System.Drawing.Point(34, 121)
        Me.LabelScan.Name = "LabelScan"
        Me.LabelScan.Size = New System.Drawing.Size(195, 29)
        Me.LabelScan.TabIndex = 61
        Me.LabelScan.Text = "Scanner la carte ..."
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(52, 276)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(493, 237)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informations de l'étudiant"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btnAnnulerAchat)
        Me.GroupBox2.Controls.Add(Me.btnConfirmAchat)
        Me.GroupBox2.Controls.Add(Me.btnCheckCode)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cboAchat)
        Me.GroupBox2.Controls.Add(Me.txtCodeAchat)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtMontantAchat)
        Me.GroupBox2.Location = New System.Drawing.Point(579, 276)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(440, 237)
        Me.GroupBox2.TabIndex = 64
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opération d'achat - Chargement carte"
        '
        'btnAnnulerAchat
        '
        Me.btnAnnulerAchat.BackColor = System.Drawing.Color.Gray
        Me.btnAnnulerAchat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnulerAchat.FlatAppearance.BorderSize = 0
        Me.btnAnnulerAchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnulerAchat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnulerAchat.ForeColor = System.Drawing.Color.White
        Me.btnAnnulerAchat.Location = New System.Drawing.Point(245, 183)
        Me.btnAnnulerAchat.Name = "btnAnnulerAchat"
        Me.btnAnnulerAchat.Size = New System.Drawing.Size(134, 40)
        Me.btnAnnulerAchat.TabIndex = 46
        Me.btnAnnulerAchat.Text = "Annuler l'achat"
        Me.btnAnnulerAchat.UseVisualStyleBackColor = False
        '
        'btnConfirmAchat
        '
        Me.btnConfirmAchat.BackColor = System.Drawing.Color.Green
        Me.btnConfirmAchat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfirmAchat.FlatAppearance.BorderSize = 0
        Me.btnConfirmAchat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime
        Me.btnConfirmAchat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfirmAchat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmAchat.ForeColor = System.Drawing.Color.White
        Me.btnConfirmAchat.Location = New System.Drawing.Point(88, 184)
        Me.btnConfirmAchat.Name = "btnConfirmAchat"
        Me.btnConfirmAchat.Size = New System.Drawing.Size(135, 40)
        Me.btnConfirmAchat.TabIndex = 45
        Me.btnConfirmAchat.Text = "Confirmer l'achat"
        Me.btnConfirmAchat.UseVisualStyleBackColor = False
        '
        'btnCheckCode
        '
        Me.btnCheckCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnCheckCode.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCheckCode.FlatAppearance.BorderSize = 0
        Me.btnCheckCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCheckCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckCode.ForeColor = System.Drawing.Color.White
        Me.btnCheckCode.Location = New System.Drawing.Point(282, 110)
        Me.btnCheckCode.Name = "btnCheckCode"
        Me.btnCheckCode.Size = New System.Drawing.Size(115, 26)
        Me.btnCheckCode.TabIndex = 44
        Me.btnCheckCode.Text = "Vérifier le code"
        Me.btnCheckCode.UseVisualStyleBackColor = False
        Me.btnCheckCode.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 33)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 19)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "Autres actions"
        '
        'cboAchat
        '
        Me.cboAchat.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAchat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAchat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAchat.FormattingEnabled = True
        Me.cboAchat.Items.AddRange(New Object() {"Acheter via un code pré-généré"})
        Me.cboAchat.Location = New System.Drawing.Point(129, 29)
        Me.cboAchat.Name = "cboAchat"
        Me.cboAchat.Size = New System.Drawing.Size(268, 28)
        Me.cboAchat.TabIndex = 42
        '
        'txtCodeAchat
        '
        Me.txtCodeAchat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodeAchat.ForeColor = System.Drawing.Color.Green
        Me.txtCodeAchat.Location = New System.Drawing.Point(129, 110)
        Me.txtCodeAchat.Name = "txtCodeAchat"
        Me.txtCodeAchat.Size = New System.Drawing.Size(147, 26)
        Me.txtCodeAchat.TabIndex = 41
        Me.txtCodeAchat.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 113)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 19)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Code d'achat"
        Me.Label10.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 19)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Montant"
        '
        'txtMontantAchat
        '
        Me.txtMontantAchat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontantAchat.Location = New System.Drawing.Point(129, 70)
        Me.txtMontantAchat.Name = "txtMontantAchat"
        Me.txtMontantAchat.Size = New System.Drawing.Size(268, 26)
        Me.txtMontantAchat.TabIndex = 0
        '
        'PictureBoxCarte
        '
        Me.PictureBoxCarte.Image = Global.formMain.My.Resources.Resources.credit_card
        Me.PictureBoxCarte.Location = New System.Drawing.Point(62, 153)
        Me.PictureBoxCarte.Name = "PictureBoxCarte"
        Me.PictureBoxCarte.Size = New System.Drawing.Size(121, 72)
        Me.PictureBoxCarte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBoxCarte.TabIndex = 62
        Me.PictureBoxCarte.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.formMain.My.Resources.Resources.businessman
        Me.PictureBox1.Location = New System.Drawing.Point(293, 54)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(241, 205)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'formAchat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1034, 544)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBoxCarte)
        Me.Controls.Add(Me.LabelScan)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelSolde)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtNiveau)
        Me.Controls.Add(Me.txtFiliere)
        Me.Controls.Add(Me.txtUfr)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtCP)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtPrenom)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtRFID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formAchat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBoxCarte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents txtCP As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRFID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNiveau As TextBox
    Friend WithEvents txtFiliere As TextBox
    Friend WithEvents txtUfr As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LabelSolde As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents LabelScan As Label
    Friend WithEvents PictureBoxCarte As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMontantAchat As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cboAchat As ComboBox
    Friend WithEvents txtCodeAchat As TextBox
    Friend WithEvents btnCheckCode As Button
    Friend WithEvents btnAnnulerAchat As Button
    Friend WithEvents btnConfirmAchat As Button
End Class
