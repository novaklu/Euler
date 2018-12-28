Module Euler001

    Sub Main()
        Dim Result As Integer = 0

        For index As Integer = 1 To 1000
            ' If index is modulo 3 and 5, continue
            ' with the next iteration.
            If index Mod 3 AndAlso index Mod 5 Then
                Continue For
            End If

            Result = Result + index

            ' Display the index.
            Debug.Write(index.ToString & " ")

            ' If index is below 999, exit the loop.
            If index = 999 Then
                Exit For
            End If
        Next
        Debug.WriteLine("")
        ' Output: 1 2 3 4 9 10

        Debug.WriteLine("Result: " & Result)

        ' Only console view
        Console.ReadLine()

    End Sub

End Module
