Module Module_Patient
    Public Structure Patient
        Dim code As Integer
        Dim nom As String
        Dim penom As String
    End Structure

    Public Patients(100) As Patient
    Dim nb As Integer = 0

    Function AjouterPatient(P As Patient) As Boolean
        Dim i As Integer = 0
        If nb < Patients.Length Then
            Patients(nb) = P
            nb += 1
            Return True
        Else
            Return False
        End If
    End Function

    Public Sub afficher(dgv As DataGridView)
        Dim p As Patient
        For Each p In Patients
            If p.nom IsNot Nothing Then
                dgv.Rows.Add(p.code, p.nom, p.penom)
            End If
        Next
    End Sub

    Public Function existe(p As Patient) As Boolean
        Dim i As Integer = 0
        While ((i < nb) And (Patients(i).code <> p.code))
            i = i + 1
        End While
        Return i < nb
    End Function


End Module
