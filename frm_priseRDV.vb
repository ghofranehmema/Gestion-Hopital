Public Class frm_priseRDV
    Private Sub btn_prendreRDV_Click(sender As Object, e As EventArgs) Handles btn_prendreRDV.Click
        Dim R As RendezVous
        Dim code As Integer = txt_codepatient.Text
        R.code = txt_codepatient.Text
        R.dateetheure = date_RDV.Text

        If Not existeRDV(R) Then
            If AjouterRDV(R) Then
                MessageBox.Show("Ajout du RDV avec succes")
            Else
                MessageBox.Show("Le tableau RDV est saturé")
            End If
        Else
            MessageBox.Show("Cette heure avec cette date est réservé déjà.")
        End If
        txt_codepatient.Clear()

    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Close()
    End Sub

End Class