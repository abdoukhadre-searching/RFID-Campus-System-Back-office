<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formFilieres
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formFilieres))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBoxUfr = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxFiliere = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSaveFiliere = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = Global.formMain.My.Resources.Resources.cancel
        Me.PictureBox2.Location = New System.Drawing.Point(559, 5)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(34, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 32
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
        Me.Panel1.Size = New System.Drawing.Size(605, 40)
        Me.Panel1.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 10)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(183, 15)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Ajouter une filière de formation"
        '
        'ComboBoxUfr
        '
        Me.ComboBoxUfr.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBoxUfr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxUfr.FormattingEnabled = True
        Me.ComboBoxUfr.Location = New System.Drawing.Point(277, 61)
        Me.ComboBoxUfr.Name = "ComboBoxUfr"
        Me.ComboBoxUfr.Size = New System.Drawing.Size(283, 22)
        Me.ComboBoxUfr.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 17)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Choisir l'UFR associée à cette formation"
        '
        'TextBoxFiliere
        '
        Me.TextBoxFiliere.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBoxFiliere.Font = New System.Drawing.Font("Calibri", 12.0!)
        Me.TextBoxFiliere.Location = New System.Drawing.Point(277, 101)
        Me.TextBoxFiliere.Name = "TextBoxFiliere"
        Me.TextBoxFiliere.Size = New System.Drawing.Size(283, 27)
        Me.TextBoxFiliere.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(23, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(183, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Entrer le nom de la Formation"
        '
        'btnSaveFiliere
        '
        Me.btnSaveFiliere.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(122, Byte), Integer))
        Me.btnSaveFiliere.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSaveFiliere.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveFiliere.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveFiliere.ForeColor = System.Drawing.Color.White
        Me.btnSaveFiliere.Location = New System.Drawing.Point(277, 150)
        Me.btnSaveFiliere.Name = "btnSaveFiliere"
        Me.btnSaveFiliere.Size = New System.Drawing.Size(139, 33)
        Me.btnSaveFiliere.TabIndex = 30
        Me.btnSaveFiliere.Text = "Enregistrer"
        Me.btnSaveFiliere.UseVisualStyleBackColor = False
        '
        'formFilieres
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 210)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSaveFiliere)
        Me.Controls.Add(Me.TextBoxFiliere)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxUfr)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "formFilieres"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBoxUfr As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxFiliere As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnSaveFiliere As Button
End Class
