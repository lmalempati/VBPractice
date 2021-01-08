Module Module1

    Sub Main()
        Console.WriteLine("Hello Cardnox")

        Dim ut As New Utility()
        Console.WriteLine(ut.SumOfTwoNumbers(10, 20))

        Console.WriteLine(" Max of 10, 11 is: " + ut.Findmax(10, 11))

        Console.ReadLine()

    End Sub

End Module
