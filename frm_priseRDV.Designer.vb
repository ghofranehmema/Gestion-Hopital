<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_priseRDV
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
        Me.txt_codepatient = New System.Windows.Forms.TextBox()
        Me.img_rdv = New System.Windows.Forms.PictureBox()
        Me.lbl_code = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.date_RDV = New System.Windows.Forms.DateTimePicker()
        Me.btn_prendreRDV = New System.Windows.Forms.Button()
        Me.btn_annuler = New System.Windows.Forms.Button()
        CType(Me.img_rdv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_codepatient
        '
        Me.txt_codepatient.Location = New System.Drawing.Point(41, 233)
        Me.txt_codepatient.Name = "txt_codepatient"
        Me.txt_codepatient.Size = New System.Drawing.Size(223, 22)
        Me.txt_codepatient.TabIndex = 0
        '
        'img_rdv
        '
        Me.img_rdv.Image = Global.Gestion_Hopital.My.Resources.Resources.prendre_rdv_creation_site_web
        Me.img_rdv.Location = New System.Drawing.Point(12, 12)
        Me.img_rdv.Name = "img_rdv"
        Me.img_rdv.Size = New System.Drawing.Size(295, 77)
        Me.img_rdv.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_rdv.TabIndex = 3
        Me.img_rdv.TabStop = False
        '
        'lbl_code
        '
        Me.lbl_code.AutoSize = True
        Me.lbl_code.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_code.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_code.Location = New System.Drawing.Point(37, 206)
        Me.lbl_code.Name = "lbl_code"
        Me.lbl_code.Size = New System.Drawing.Size(112, 20)
        Me.lbl_code.TabIndex = 4
        Me.lbl_code.Text = "Votre code :"
        '
        'lbl_date
        '
        Me.lbl_date.AutoSize = True
        Me.lbl_date.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbl_date.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(37, 297)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(275, 20)
        Me.lbl_date.TabIndex = 5
        Me.lbl_date.Text = "Date et Heure du rendez-vous :"
        '
        'date_RDV
        '
        Me.date_RDV.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.date_RDV.Location = New System.Drawing.Point(41, 329)
        Me.date_RDV.Name = "date_RDV"
        Me.date_RDV.Size = New System.Drawing.Size(223, 22)
        Me.date_RDV.TabIndex = 7
        '
        'btn_prendreRDV
        '
        Me.btn_prendreRDV.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btn_prendreRDV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_prendreRDV.Location = New System.Drawing.Point(70, 404)
        Me.btn_prendreRDV.Name = "btn_prendreRDV"
        Me.btn_prendreRDV.Size = New System.Drawing.Size(153, 78)
        Me.btn_prendreRDV.TabIndex = 8
        Me.btn_prendreRDV.Text = "Prendre le Rendez-vous"
        Me.btn_prendreRDV.UseVisualStyleBackColor = False
        '
        'btn_annuler
        '
        Me.btn_annuler.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.btn_annuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_annuler.Location = New System.Drawing.Point(70, 488)
        Me.btn_annuler.Name = "btn_annuler"
        Me.btn_annuler.Size = New System.Drawing.Size(153, 78)
        Me.btn_annuler.TabIndex = 9
        Me.btn_annuler.Text = "Annuler"
        Me.btn_annuler.UseVisualStyleBackColor = False
        '
        'frm_priseRDV
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gestion_Hopital.My.Resources.Resources.caab6ce7f4e69d448e2430927e494049
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(689, 674)
        Me.Controls.Add(Me.btn_annuler)
        Me.Controls.Add(Me.btn_prendreRDV)
        Me.Controls.Add(Me.date_RDV)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_code)
        Me.Controls.Add(Me.img_rdv)
        Me.Controls.Add(Me.txt_codepatient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frm_priseRDV"
        Me.Text = "frm_priseRDV"
        CType(Me.img_rdv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_codepatient As TextBox
    Friend WithEvents img_rdv As PictureBox
    Friend WithEvents lbl_code As Label
    Friend WithEvents lbl_date As Label
    Friend WithEvents date_RDV As DateTimePicker
    Friend WithEvents btn_prendreRDV As Button
    Friend WithEvents btn_annuler As Button
End Class
