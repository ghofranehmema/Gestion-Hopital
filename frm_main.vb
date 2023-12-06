Public Class frm_main
    Private Sub AjouterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem.Click
        frm_AjoutPatient.MdiParent = Me
        frm_AjoutPatient.Show()
    End Sub

    Private Sub AfficherToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherToolStripMenuItem.Click
        frm_AjoutPatient.MdiParent = Me
        frm_afficherpatient.Show()
        'une autre méthode:
        'for each p in patients
        'if p.nom isnot nothing then
        'dgv.rows.add(p.code , p.nom ,p.prenom)
        'end if
        'next
    End Sub

    Private Sub PendreRDVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PendreRDVToolStripMenuItem.Click
        frm_priseRDV.MdiParent = Me
        frm_priseRDV.Show()
    End Sub

    Private Sub AfficherLeRDVToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AfficherLeRDVToolStripMenuItem.Click
        frm_RDVjour.MdiParent = Me
        frm_RDVjour.Show()
    End Sub
End Class
