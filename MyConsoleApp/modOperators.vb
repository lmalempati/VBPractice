Public Module modOperators

    Public Sub CountSheep()
        Dim i As Integer = 1 ' Sheep do not count from 0.
        Do While (True) ' Endless loop.
            Console.WriteLine("Sheep " & i & " Baah")
            i = i + 1
            System.Threading.Thread.Sleep(1000) 'Wait 1 second.
        Loop
    End Sub

    Sub CoutNumbers()
        Dim i As Integer = 1
        Do While (True)
            Console.WriteLine($"number: {i}")
            i += 1
            System.Threading.Thread.Sleep(1000) 'Wait 1 second.
        Loop
    End Sub

    Public Sub UseThread()
        Dim t As New System.Threading.Thread(AddressOf CoutNumbers)
        t.Start()
    End Sub
End Module
