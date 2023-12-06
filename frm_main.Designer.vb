<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PatientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AjouterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AfficherLeRDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PendreRDVToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PatientToolStripMenuItem, Me.RDVToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(744, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PatientToolStripMenuItem
        '
        Me.PatientToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterToolStripMenuItem, Me.AfficherToolStripMenuItem})
        Me.PatientToolStripMenuItem.Image = Global.Gestion_Hopital.My.Resources.Resources._53223bf7b3558866bf3ef9326290ea21
        Me.PatientToolStripMenuItem.Name = "PatientToolStripMenuItem"
        Me.PatientToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.PatientToolStripMenuItem.Text = "Patient"
        '
        'AjouterToolStripMenuItem
        '
        Me.AjouterToolStripMenuItem.Image = Global.Gestion_Hopital.My.Resources.Resources.Blue_Cross_Circle_Stethoscope_Logo_Stock_Vector___Illustration_of_company__activities__171160300
        Me.AjouterToolStripMenuItem.Name = "AjouterToolStripMenuItem"
        Me.AjouterToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AjouterToolStripMenuItem.Text = "Ajouter"
        '
        'AfficherToolStripMenuItem
        '
        Me.AfficherToolStripMenuItem.Image = Global.Gestion_Hopital.My.Resources.Resources.f4add2fcd72e98912488403311240c9d
        Me.AfficherToolStripMenuItem.Name = "AfficherToolStripMenuItem"
        Me.AfficherToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AfficherToolStripMenuItem.Text = "Afficher"
        '
        'RDVToolStripMenuItem
        '
        Me.RDVToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PendreRDVToolStripMenuItem, Me.AfficherLeRDVToolStripMenuItem})
        Me.RDVToolStripMenuItem.Image = Global.Gestion_Hopital.My.Resources.Resources.patient_forms_drib_lrg_jpg_by_Josh_Warren__1_
        Me.RDVToolStripMenuItem.Name = "RDVToolStripMenuItem"
        Me.RDVToolStripMenuItem.Size = New System.Drawing.Size(72, 24)
        Me.RDVToolStripMenuItem.Text = "RDV"
        '
        'AfficherLeRDVToolStripMenuItem
        '
        Me.AfficherLeRDVToolStripMenuItem.Image = Global.Gestion_Hopital.My.Resources.Resources.c001e6ca5a1b7c4670689c25673a83b41
        Me.AfficherLeRDVToolStripMenuItem.Name = "AfficherLeRDVToolStripMenuItem"
        Me.AfficherLeRDVToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.AfficherLeRDVToolStripMenuItem.Text = "Afficher le RDV du jour"
        '
        'PendreRDVToolStripMenuItem
        '
        Me.PendreRDVToolStripMenuItem.Image = Global.Gestion_Hopital.My.Resources.Resources._38de84798b46b16808db55498b7796c2
        Me.PendreRDVToolStripMenuItem.Name = "PendreRDVToolStripMenuItem"
        Me.PendreRDVToolStripMenuItem.Size = New System.Drawing.Size(244, 26)
        Me.PendreRDVToolStripMenuItem.Text = "Pendre RDV"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Gestion_Hopital.My.Resources.Resources.Medical_Icons___Micro_Animations
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(744, 758)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frm_main"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PatientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AjouterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AfficherLeRDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PendreRDVToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
End Class
