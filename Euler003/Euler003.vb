Module Euler003

    Sub Main()
        ' Creating collection
        Dim arrayPrimes As New List(Of Integer)
        ' Test imput is 13195
        Dim inputMax As Integer = 13195
        Dim Result As Integer = 0
        Dim iMax As Integer

        arrayPrimes.Add(2)
        iMax = Math.Round(Math.Sqrt(inputMax))

        ' Display the index (test numbers is 5, 7, 13 and 29).
        For j As Integer = 1 To iMax Step 1
            If sieveOfEratosthenes(j) Then
                arrayPrimes.Add(j)
                Debug.WriteLine(j.ToString & ", ")
            End If
        Next

        arrayPrimes.ForEach(
            Sub(arrayPrime) Debug.WriteLine(arrayPrime & ", "))
        ' Output: 0 2 4 6 8

        Debug.WriteLine("Result: " & Result.ToString)
        ' Output 29

    End Sub

    Public Function sieveOfEratosthenes(ByRef number As Integer)
        If (number < 2) Then Return False
        If (number = 2) Then Return True
        If (number Mod 2 = 0) Then Return False
        Dim iMax As Integer

        iMax = Math.Round(Math.Sqrt(number))
        For i As Integer = 3 To iMax Step 2
            If (number Mod i = 0) Then
                Return False
            End If
        Next

        Return True

    End Function

End Module
