Public Class frm_afficherpatient
    Private Sub frm_afficherpatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        afficher(dgv_patient)
    End Sub

    Private Sub btn_supp_Click(sender As Object, e As EventArgs) Handles btn_supp.Click
        Dim Index As Integer = Me.dgv_patient.CurrentRow.Index
        Me.dgv_patient.Rows.RemoveAt(Index)
    End Sub

    Private Sub btn_rechercher_Click(sender As Object, e As EventArgs) Handles btn_rechercher.Click
        For Each row As DataGridViewRow In dgv_patient.Rows
            Dim code As String = row.Cells(0).Value
            Dim nom As String = row.Cells(1).Value
            Dim prenom As String = row.Cells(2).Value
            If txt_rechercher.Text = code Or txt_rechercher.Text = nom Or txt_rechercher.Text = prenom Then
                row.Selected = True
                Exit For
            End If
        Next
    End Sub

End Class