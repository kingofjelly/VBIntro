Module Module1
    'This is a comment
    Sub Main()
        Console.WriteLine("Hello")
        writeHello()
        fill2DArray()


    End Sub
    'code stepping: step into = look into function calls. step over= avoid function calls.

    'console.writeline
    Sub writeHello()
        Console.WriteLine("Hello there")
        'call method below
        fillArray()

    End Sub

    'array interacton
    Sub fillArray()
        'method which generaes random numbers, fills array, prints array. move to list?
        Dim numberArray(6) As Integer 'this is an array
        Dim value As Integer
        Randomize()

        'array is int
        For index As Integer = 1 To 5 'this is a VB way of handling a for loop

            numberArray(index) = CInt(Int((6 * Rnd()) + 1))
        Next

        For index As Integer = 1 To 5
            Console.WriteLine(numberArray(index))

        Next

    End Sub

    '2darray interaction
    Sub fill2DArray()
        Dim numberArray(10, 10) As Integer
        Randomize()
        Dim arrayNumberCount As Integer


        For i As Integer = 0 To 9 'change to under 10
            For j As Integer = 0 To 9
                numberArray(i, j) = arrayNumberCount
                arrayNumberCount = arrayNumberCount + 1
            Next
        Next

        For i As Integer = 0 To 9
            For j As Integer = 0 To 9
                'Console.Write(numberArray(i - 1, j - 1))
                padding(numberArray(i, j))

            Next
            Console.WriteLine()

        Next

    End Sub

    'padding method for above 2darray
    Sub padding(ByVal numberToPad As Integer)

        If numberToPad < 10 Then
            Console.Write("  ")
            Console.Write(numberToPad)
        End If
        If numberToPad >= 10 And numberToPad < 100 Then
            Console.Write(" ")
            Console.Write(numberToPad)
        End If
        If numberToPad = 100 Then
            Console.WriteLine(numberToPad)
        End If

    End Sub

    'now to add in enums
    'now to add in a switch case menu



End Module
