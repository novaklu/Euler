﻿Imports System.Numerics

Module Euler002

    Sub Main()
        Dim Result As BigInteger = 0
        Dim Temp As BigInteger = 0
        Dim iLast As BigInteger = 1
        Dim iNext As BigInteger = 1

        For index As Integer = 1 To 4000000
            ' The Fibonacci sequence is generated by adding the previous two terms.
            Temp = iNext
            iNext = iNext + iLast
            iLast = Temp

            Result = Result + Temp

            ' Display the index.
            Debug.Write(Temp.ToString & " ")

            ' If iNext bigger than 4000000, exit the loop.
            If iNext > 4000000 Then
                Exit For
            End If
        Next
        Debug.WriteLine("")
        ' Output: 1 2 3 5 8 13 21 34 55 89 

        Debug.WriteLine("Result: " & Result.ToString)
        ' Output 231

        Console.ReadLine()
        ' Only for console view.
    End Sub

End Module