<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AjoutPatient
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
        Me.lbl_code = New System.Windows.Forms.Label()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.lbl_prenom = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_nom = New System.Windows.Forms.TextBox()
        Me.txt_prenom = New System.Windows.Forms.TextBox()
        Me.btn_ajouter = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_code
        '
        Me.lbl_code.AutoSize = True
        Me.lbl_code.Location = New System.Drawing.Point(75, 128)
        Me.lbl_code.Name = "lbl_code"
        Me.lbl_code.Size = New System.Drawing.Size(41, 17)
        Me.lbl_code.TabIndex = 0
        Me.lbl_code.Text = "Code"
        '
        'lbl_nom
        '
        Me.lbl_nom.AutoSize = True
        Me.lbl_nom.Location = New System.Drawing.Point(75, 209)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Size = New System.Drawing.Size(37, 17)
        Me.lbl_nom.TabIndex = 1
        Me.lbl_nom.Text = "Nom"
        '
        'lbl_prenom
        '
        Me.lbl_prenom.AutoSize = True
        Me.lbl_prenom.Location = New System.Drawing.Point(75, 294)
        Me.lbl_prenom.Name = "lbl_prenom"
        Me.lbl_prenom.Size = New System.Drawing.Size(57, 17)
        Me.lbl_prenom.TabIndex = 2
        Me.lbl_prenom.Text = "Prénom"
        '
        'txt_code
        '
        Me.txt_code.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(4, Byte), Integer))
        Me.txt_code.Location = New System.Drawing.Point(23, 14)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(262, 22)
        Me.txt_code.TabIndex = 3
        '
        'txt_nom
        '
        Me.txt_nom.Location = New System.Drawing.Point(23, 13)
        Me.txt_nom.Name = "txt_nom"
        Me.txt_nom.Size = New System.Drawing.Size(262, 22)
        Me.txt_nom.TabIndex = 4
        '
        'txt_prenom
        '
        Me.txt_prenom.Location = New System.Drawing.Point(23, 14)
        Me.txt_prenom.Name = "txt_prenom"
        Me.txt_prenom.Size = New System.Drawing.Size(262, 22)
        Me.txt_prenom.TabIndex = 5
        '
        'btn_ajouter
        '
        Me.btn_ajouter.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.btn_ajouter.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajouter.Location = New System.Drawing.Point(98, 351)
        Me.btn_ajouter.Name = "btn_ajouter"
        Me.btn_ajouter.Size = New System.Drawing.Size(132, 48)
        Me.btn_ajouter.TabIndex = 6
        Me.btn_ajouter.Text = "Ajouter"
        Me.btn_ajouter.UseVisualStyleBackColor = False
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(98, 418)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(132, 48)
        Me.btn_annuler.TabIndex = 7
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.txt_code)
        Me.Panel1.Location = New System.Drawing.Point(168, 116)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(310, 48)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.txt_nom)
        Me.Panel2.Location = New System.Drawing.Point(168, 197)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(310, 48)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel3.Controls.Add(Me.txt_prenom)
        Me.Panel3.Location = New System.Drawing.Point(168, 279)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(310, 48)
        Me.Panel3.TabIndex = 10
        '
        'frm_AjoutPatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gestion_Hopital.My.Resources.Resources.安全用藥_扁平化_醫療促銷_簡約展板背景圖桌布手機桌布圖片免費下載___Pngtree
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(549, 530)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_ajouter)
        Me.Controls.Add(Me.lbl_prenom)
        Me.Controls.Add(Me.lbl_nom)
        Me.Controls.Add(Me.lbl_code)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_AjoutPatient"
        Me.Text = "frm_AjoutPatient"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_code As Label
    Friend WithEvents lbl_nom As Label
    Friend WithEvents lbl_prenom As Label
    Friend WithEvents txt_code As TextBox
    Friend WithEvents txt_nom As TextBox
    Friend WithEvents txt_prenom As TextBox
    Friend WithEvents btn_ajouter As Button
    Friend WithEvents btn_annuler As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
