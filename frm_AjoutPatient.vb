Public Class frm_AjoutPatient
    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim P As Patient
        Dim code As Integer = txt_code.Text
        P.code = txt_code.Text
        P.nom = txt_nom.Text
        P.penom = txt_prenom.Text
        If Not existe(P) Then
            If AjouterPatient(P) Then
                MessageBox.Show("Ajout du patient avec succes")
            Else
                MessageBox.Show("Le tableau est plein")
            End If
        Else
            MessageBox.Show("Le patient existe déjà.")
        End If
        txt_code.Clear()
        txt_nom.Clear()
        txt_prenom.Clear()
    End Sub

    Private Sub btn_annuler_Click(sender As Object, e As EventArgs) Handles btn_annuler.Click
        Close()
    End Sub

End Class