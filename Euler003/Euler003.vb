Module Euler003

    Sub Main()
        ' Creating collection
        Dim arrayPrimes As New List(Of Integer)
        ' Test imput is 13195
        Dim nInput As Integer = 13195
        Dim nResult As Integer = 0
        Dim iMax As Integer

        iMax = Math.Round(Math.Sqrt(nInput))

        ' Prime factorization
        For j As Integer = 1 To iMax Step 1
            If sieveOfEratosthenes(j) Then
                arrayPrimes.Add(j)
                'Debug.WriteLine(j.ToString & ", ")
            End If
        Next

        arrayPrimes.ForEach(
            Sub(arrayPrime) Debug.WriteLine(arrayPrime & ", "))
        ' Output: 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109, 113

        ' Display the index (test numbers is 5, 7, 13 and 29).
        For index As Integer = arrayPrimes.Count - 1 To 0 Step -1
            nResult = arrayPrimes(index)
            Debug.WriteLine("Result: " & nResult)
        Next

        Debug.WriteLine("Result: " & nResult.ToString)
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
