<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_afficherpatient
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
        Me.dgv_patient = New System.Windows.Forms.DataGridView()
        Me.column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_supp = New System.Windows.Forms.Button()
        Me.txt_rechercher = New System.Windows.Forms.TextBox()
        Me.btn_rechercher = New System.Windows.Forms.Button()
        CType(Me.dgv_patient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_patient
        '
        Me.dgv_patient.BackgroundColor = System.Drawing.Color.Azure
        Me.dgv_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_patient.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.column, Me.Column2, Me.Column3})
        Me.dgv_patient.GridColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgv_patient.Location = New System.Drawing.Point(39, 35)
        Me.dgv_patient.Name = "dgv_patient"
        Me.dgv_patient.RowHeadersWidth = 51
        Me.dgv_patient.RowTemplate.Height = 24
        Me.dgv_patient.Size = New System.Drawing.Size(720, 373)
        Me.dgv_patient.TabIndex = 0
        '
        'column
        '
        Me.column.HeaderText = "code "
        Me.column.MinimumWidth = 6
        Me.column.Name = "column"
        Me.column.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Nom"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'Column3
        '
        Me.Column3.HeaderText = "Prénom"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 125
        '
        'btn_supp
        '
        Me.btn_supp.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btn_supp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supp.Location = New System.Drawing.Point(39, 414)
        Me.btn_supp.Name = "btn_supp"
        Me.btn_supp.Size = New System.Drawing.Size(187, 51)
        Me.btn_supp.TabIndex = 1
        Me.btn_supp.Text = "Supprimer"
        Me.btn_supp.UseVisualStyleBackColor = False
        '
        'txt_rechercher
        '
        Me.txt_rechercher.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_rechercher.Location = New System.Drawing.Point(290, 429)
        Me.txt_rechercher.Name = "txt_rechercher"
        Me.txt_rechercher.Size = New System.Drawing.Size(235, 22)
        Me.txt_rechercher.TabIndex = 2
        '
        'btn_rechercher
        '
        Me.btn_rechercher.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btn_rechercher.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rechercher.Location = New System.Drawing.Point(572, 414)
        Me.btn_rechercher.Name = "btn_rechercher"
        Me.btn_rechercher.Size = New System.Drawing.Size(187, 51)
        Me.btn_rechercher.TabIndex = 3
        Me.btn_rechercher.Text = "Rechercher"
        Me.btn_rechercher.UseVisualStyleBackColor = False
        '
        'frm_afficherpatient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gestion_Hopital.My.Resources.Resources.b6a057a29ef49baa98b592b17a9edde5
        Me.ClientSize = New System.Drawing.Size(861, 540)
        Me.Controls.Add(Me.btn_rechercher)
        Me.Controls.Add(Me.txt_rechercher)
        Me.Controls.Add(Me.btn_supp)
        Me.Controls.Add(Me.dgv_patient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frm_afficherpatient"
        Me.Text = "liste des patients"
        CType(Me.dgv_patient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_patient As DataGridView
    Friend WithEvents btn_supp As Button
    Friend WithEvents column As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents txt_rechercher As TextBox
    Friend WithEvents btn_rechercher As Button
End Class
