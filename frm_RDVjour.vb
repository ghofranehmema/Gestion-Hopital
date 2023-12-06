Public Class frm_RDVjour
    Private Sub frm_RDVjour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AfficherRDVsDuJour(dgv_RDVjour)
    End Sub

    Private Sub btn_supprdv_Click(sender As Object, e As EventArgs) Handles btn_supprdv.Click
        Dim Index As Integer = Me.dgv_RDVjour.CurrentRow.Index
        Me.dgv_RDVjour.Rows.RemoveAt(Index)
    End Sub

    Private Sub btn_rechercherRDV_Click(sender As Object, e As EventArgs) Handles btn_rechercherRDV.Click
        For Each row As DataGridViewRow In dgv_RDVjour.Rows
            Dim code As String = row.Cells(0).Value
            Dim daterdv As String = row.Cells(1).Value
            If txt_rechercherRDV.Text = code Or txt_rechercherRDV.Text = daterdv Then
                row.Selected = True
                Exit For
            End If
        Next
    End Sub
End Class