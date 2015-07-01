Public Class MyForm

    Private Sub butMyButton_Click(sender As Object, e As EventArgs) Handles butMyButton.Click
        Dim list As New List(Of String)

        list.Add("Annu")
        list.Add("Suwarna")
        list.Add("Suban")
        list.Add("Amma")
        list.Add("Maami")

        Dim returnedList As List(Of String) = Sort(list, "A")

        For i = 0 To returnedList.Count - 1
            MsgBox(returnedList.Item(i))
        Next
    End Sub

    Public Function Sort(ByVal theList As List(Of String), ByVal theChar As Char) As List(Of String)
        Dim returnList As New List(Of String)

        For i = 0 To theList.Count - 1
            If theList(i).Substring(0, 1) = theChar Then
                returnList.Add(theList(i))
            End If
        Next

        Return returnList
    End Function
End Class
