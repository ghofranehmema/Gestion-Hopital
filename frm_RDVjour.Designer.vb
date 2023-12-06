<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RDVjour
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
        Me.dgv_RDVjour = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_supprdv = New System.Windows.Forms.Button()
        Me.btn_rechercherRDV = New System.Windows.Forms.Button()
        Me.txt_rechercherRDV = New System.Windows.Forms.TextBox()
        CType(Me.dgv_RDVjour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv_RDVjour
        '
        Me.dgv_RDVjour.BackgroundColor = System.Drawing.Color.Azure
        Me.dgv_RDVjour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_RDVjour.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgv_RDVjour.Location = New System.Drawing.Point(12, 12)
        Me.dgv_RDVjour.Name = "dgv_RDVjour"
        Me.dgv_RDVjour.RowHeadersWidth = 51
        Me.dgv_RDVjour.RowTemplate.Height = 24
        Me.dgv_RDVjour.Size = New System.Drawing.Size(606, 474)
        Me.dgv_RDVjour.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "Code du patient"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 125
        '
        'Column2
        '
        Me.Column2.HeaderText = "Date et heure du RDV"
        Me.Column2.MinimumWidth = 6
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 125
        '
        'btn_supprdv
        '
        Me.btn_supprdv.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btn_supprdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supprdv.Location = New System.Drawing.Point(12, 492)
        Me.btn_supprdv.Name = "btn_supprdv"
        Me.btn_supprdv.Size = New System.Drawing.Size(187, 51)
        Me.btn_supprdv.TabIndex = 2
        Me.btn_supprdv.Text = "Supprimer"
        Me.btn_supprdv.UseVisualStyleBackColor = False
        '
        'btn_rechercherRDV
        '
        Me.btn_rechercherRDV.BackColor = System.Drawing.Color.PaleTurquoise
        Me.btn_rechercherRDV.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_rechercherRDV.Location = New System.Drawing.Point(421, 492)
        Me.btn_rechercherRDV.Name = "btn_rechercherRDV"
        Me.btn_rechercherRDV.Size = New System.Drawing.Size(187, 51)
        Me.btn_rechercherRDV.TabIndex = 5
        Me.btn_rechercherRDV.Text = "Rechercher"
        Me.btn_rechercherRDV.UseVisualStyleBackColor = False
        '
        'txt_rechercherRDV
        '
        Me.txt_rechercherRDV.BackColor = System.Drawing.SystemColors.MenuBar
        Me.txt_rechercherRDV.Location = New System.Drawing.Point(216, 507)
        Me.txt_rechercherRDV.Name = "txt_rechercherRDV"
        Me.txt_rechercherRDV.Size = New System.Drawing.Size(199, 22)
        Me.txt_rechercherRDV.TabIndex = 4
        '
        'frm_RDVjour
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(630, 569)
        Me.Controls.Add(Me.btn_rechercherRDV)
        Me.Controls.Add(Me.txt_rechercherRDV)
        Me.Controls.Add(Me.btn_supprdv)
        Me.Controls.Add(Me.dgv_RDVjour)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frm_RDVjour"
        Me.Text = "frm_RDVjour"
        CType(Me.dgv_RDVjour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv_RDVjour As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btn_supprdv As Button
    Friend WithEvents btn_rechercherRDV As Button
    Friend WithEvents txt_rechercherRDV As TextBox
End Class
