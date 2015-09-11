Module Module1
    'This is a comment
    Sub Main()
        Console.WriteLine("Hello")
        writeHello()

    End Sub

    Sub writeHello()
        Console.WriteLine("Hello there")
        'call method below
        fillArray()

    End Sub

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
    'now to add in a 2D array
    'now to add in enums
    'now to add in a switch case menu



End Module
