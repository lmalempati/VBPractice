Module Module1

    Sub Main()
        Console.WriteLine("Hello Cardnox")

        Dim ut As New Utility()
        Console.WriteLine(ut.SumOfTwoNumbers(10, 20))

        Console.WriteLine(" Max of 10, 11 is: " + ut.Findmax(10, 11))
        Console.WriteLine(ut.FinaMaxOfGivenNumbers({1001, 1, 5, 6, 100, 101, 300}))
        Console.ReadLine()

    End Sub

End Module
