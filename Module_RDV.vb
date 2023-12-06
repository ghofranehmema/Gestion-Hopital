Module Module_RDV
    Public Structure RendezVous
        Dim code As Integer
        Dim dateetheure As Date
    End Structure

    Public RDVS(100) As RendezVous
    Dim nb As Integer = 0

    Function AjouterRDV(R As RendezVous) As Boolean
        If nb < RDVS.Length Then
            RDVS(nb) = R
            nb += 1
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub AfficherRDVsDuJour(dgv As DataGridView)
        Dim r As RendezVous
        For Each r In RDVS
            If r.code <> 0 Then
                dgv.Rows.Add(r.code, r.dateetheure)
            End If
        Next
    End Sub

    Public Function existeRDV(r As RendezVous) As Boolean
        Dim i As Integer = 0
        While ((i < nb) And (RDVS(i).code <> r.code))
            i = i + 1
        End While
        Return i < nb
    End Function
End Module
