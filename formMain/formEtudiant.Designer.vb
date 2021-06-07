<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formEtudiant
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formEtudiant))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxRFID = New System.Windows.Forms.TextBox()
        Me.TextBoxNom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxPrenom = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBoxUfr = New System.Windows.Forms.ComboBox()
        Me.ComboBoxFilière = New System.Windows.Forms.ComboBox()
        Me.TextBoxLieuN = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonModifier = New System.Windows.Forms.Button()
        Me.ButtonAnnuler = New System.Windows.Forms.Button()
        Me.ButtonAddImage = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxAdresse = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxCodeP = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBoxNiveau = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(886, 35)
        Me.Panel1.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 16)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Ajouter un nouveau étudiant"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "RFID n°"
        '
        'TextBoxRFID
        '
        Me.TextBoxRFID.Enabled = False
        Me.TextBoxRFID.Location = New System.Drawing.Point(186, 87)
        Me.TextBoxRFID.Name = "TextBoxRFID"
        Me.TextBoxRFID.Size = New System.Drawing.Size(276, 21)
        Me.TextBoxRFID.TabIndex = 3
        '
        'TextBoxNom
        '
        Me.TextBoxNom.Location = New System.Drawing.Point(186, 115)
        Me.TextBoxNom.Name = "TextBoxNom"
        Me.TextBoxNom.Size = New System.Drawing.Size(276, 21)
        Me.TextBoxNom.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 19)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "NOM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 322)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "FILIERE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(79, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "UFR"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(36, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 19)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "DATE DE NAISSANCE"
        '
        'TextBoxPrenom
        '
        Me.TextBoxPrenom.Location = New System.Drawing.Point(186, 145)
        Me.TextBoxPrenom.Name = "TextBoxPrenom"
        Me.TextBoxPrenom.Size = New System.Drawing.Size(276, 21)
        Me.TextBoxPrenom.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(65, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "PRENOM"
        '
        'ComboBoxUfr
        '
        Me.ComboBoxUfr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUfr.FormattingEnabled = True
        Me.ComboBoxUfr.Items.AddRange(New Object() {"SATIC", "ECOMIJ", "SDD", "ISFAR"})
        Me.ComboBoxUfr.Location = New System.Drawing.Point(186, 290)
        Me.ComboBoxUfr.Name = "ComboBoxUfr"
        Me.ComboBoxUfr.Size = New System.Drawing.Size(276, 23)
        Me.ComboBoxUfr.TabIndex = 16
        '
        'ComboBoxFilière
        '
        Me.ComboBoxFilière.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxFilière.FormattingEnabled = True
        Me.ComboBoxFilière.Items.AddRange(New Object() {"Mathématiques", "Mathématiques et Applications", "Administration et Développement d’Applications", "Licence Professionnelle Création Multimédia", "Système Réseaux Télécoms", "Systèmes et Réseaux", "Systèmes d’Information", "Physique Chimie", "Chimie Appliquée", "Chimie Inorganique", "Chimie Organique", "Chimie Physique", "Statistique et Informatique Décisonnelle", "Economie Appliquée", "Finance Comptabilité", "Management Responsable des Organisations", "Administration Publique", "Juriste d’Affaires", "Commerce Electronique et Cyber-sécurité", "Management Juridique Environnemental et Foncier", "Santé Communautaire", "Agriculture et Développement Durable", "Environnement", "Responsabilité Sociétale des Entreprise/Santé", "Médecine", "Nutrition", "Promotion de la Santé", "Suivi-évaluation"})
        Me.ComboBoxFilière.Location = New System.Drawing.Point(186, 319)
        Me.ComboBoxFilière.Name = "ComboBoxFilière"
        Me.ComboBoxFilière.Size = New System.Drawing.Size(276, 23)
        Me.ComboBoxFilière.TabIndex = 17
        '
        'TextBoxLieuN
        '
        Me.TextBoxLieuN.Location = New System.Drawing.Point(186, 204)
        Me.TextBoxLieuN.Name = "TextBoxLieuN"
        Me.TextBoxLieuN.Size = New System.Drawing.Size(276, 21)
        Me.TextBoxLieuN.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(36, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 19)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "LIEU DE NAISSANCE"
        '
        'ButtonSave
        '
        Me.ButtonSave.BackColor = System.Drawing.Color.Green
        Me.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSave.ForeColor = System.Drawing.Color.White
        Me.ButtonSave.Location = New System.Drawing.Point(186, 388)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(88, 33)
        Me.ButtonSave.TabIndex = 26
        Me.ButtonSave.Text = "Enregistrer"
        Me.ButtonSave.UseVisualStyleBackColor = False
        '
        'ButtonModifier
        '
        Me.ButtonModifier.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.ButtonModifier.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonModifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonModifier.ForeColor = System.Drawing.Color.White
        Me.ButtonModifier.Location = New System.Drawing.Point(280, 388)
        Me.ButtonModifier.Name = "ButtonModifier"
        Me.ButtonModifier.Size = New System.Drawing.Size(88, 33)
        Me.ButtonModifier.TabIndex = 27
        Me.ButtonModifier.Text = "Modifier"
        Me.ButtonModifier.UseVisualStyleBackColor = False
        '
        'ButtonAnnuler
        '
        Me.ButtonAnnuler.BackColor = System.Drawing.Color.Gray
        Me.ButtonAnnuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAnnuler.ForeColor = System.Drawing.Color.White
        Me.ButtonAnnuler.Location = New System.Drawing.Point(374, 388)
        Me.ButtonAnnuler.Name = "ButtonAnnuler"
        Me.ButtonAnnuler.Size = New System.Drawing.Size(88, 33)
        Me.ButtonAnnuler.TabIndex = 28
        Me.ButtonAnnuler.Text = "Annuler"
        Me.ButtonAnnuler.UseVisualStyleBackColor = False
        '
        'ButtonAddImage
        '
        Me.ButtonAddImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.ButtonAddImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonAddImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonAddImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAddImage.ForeColor = System.Drawing.Color.White
        Me.ButtonAddImage.Location = New System.Drawing.Point(537, 388)
        Me.ButtonAddImage.Name = "ButtonAddImage"
        Me.ButtonAddImage.Size = New System.Drawing.Size(289, 33)
        Me.ButtonAddImage.TabIndex = 30
        Me.ButtonAddImage.Text = "Sélectionner une image"
        Me.ButtonAddImage.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(324, 47)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(198, 26)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Informations Etudiant"
        '
        'TextBoxAdresse
        '
        Me.TextBoxAdresse.Location = New System.Drawing.Point(186, 233)
        Me.TextBoxAdresse.Name = "TextBoxAdresse"
        Me.TextBoxAdresse.Size = New System.Drawing.Size(276, 21)
        Me.TextBoxAdresse.TabIndex = 34
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(65, 235)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 19)
        Me.Label11.TabIndex = 33
        Me.Label11.Text = "ADRESSE"
        '
        'TextBoxCodeP
        '
        Me.TextBoxCodeP.Location = New System.Drawing.Point(186, 261)
        Me.TextBoxCodeP.Name = "TextBoxCodeP"
        Me.TextBoxCodeP.Size = New System.Drawing.Size(276, 21)
        Me.TextBoxCodeP.TabIndex = 36
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(33, 264)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(134, 19)
        Me.Label12.TabIndex = 35
        Me.Label12.Text = "CODE PERMANENT"
        '
        'ComboBoxNiveau
        '
        Me.ComboBoxNiveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxNiveau.FormattingEnabled = True
        Me.ComboBoxNiveau.Items.AddRange(New Object() {"Licence 1 ", "Licence 2 ", "Licence 3 ", "Master 1 ", "Master 2", "Doctorat 1", "Doctorat 2"})
        Me.ComboBoxNiveau.Location = New System.Drawing.Point(186, 350)
        Me.ComboBoxNiveau.Name = "ComboBoxNiveau"
        Me.ComboBoxNiveau.Size = New System.Drawing.Size(276, 23)
        Me.ComboBoxNiveau.TabIndex = 38
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(67, 353)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 19)
        Me.Label13.TabIndex = 37
        Me.Label13.Text = "NIVEAU"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "0000-00-00"
        Me.DateTimePicker1.Location = New System.Drawing.Point(186, 175)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(226, 21)
        Me.DateTimePicker1.TabIndex = 41
        Me.DateTimePicker1.Value = New Date(2021, 5, 17, 0, 0, 0, 0)
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.formMain.My.Resources.Resources.cancel
        Me.PictureBox2.Location = New System.Drawing.Point(852, 41)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(22, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 31
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.Control
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.formMain.My.Resources.Resources.profil_avatar_homme_icone_ronde_24640_14044jpg
        Me.PictureBox1.Location = New System.Drawing.Point(537, 87)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(289, 286)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 29
        Me.PictureBox1.TabStop = False
        '
        'formEtudiant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(886, 454)
        Me.ControlBox = False
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ComboBoxNiveau)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TextBoxCodeP)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBoxAdresse)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ButtonAddImage)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonAnnuler)
        Me.Controls.Add(Me.ButtonModifier)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.TextBoxLieuN)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBoxFilière)
        Me.Controls.Add(Me.ComboBoxUfr)
        Me.Controls.Add(Me.TextBoxPrenom)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxNom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxRFID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formEtudiant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxRFID As TextBox
    Friend WithEvents TextBoxNom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxPrenom As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBoxFilière As ComboBox
    Friend WithEvents TextBoxLieuN As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonSave As Button
    Friend WithEvents ButtonModifier As Button
    Friend WithEvents ButtonAnnuler As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonAddImage As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBoxAdresse As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBoxCodeP As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents ComboBoxNiveau As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents ComboBoxUfr As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
