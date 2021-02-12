Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Imports Org.BouncyCastle.Crypto
Imports Org.BouncyCastle.Crypto.Parameters
Imports Org.BouncyCastle.OpenSsl

Module Module1

    Sub Main()

        'Dim regPra As RegExPractice = New RegExPractice()
        'regPra.RegEx1()
        'Console.ReadLine()
        'Return

        Console.WriteLine("Hello Cardnox")

        Dim ut As New Utility()
        Console.WriteLine(ut.SumOfTwoNumbers(10, 20))


        'Console.WriteLine(" Max of 10, 11 is: " + ut.Findmax(10, 11))
        'Console.WriteLine(ut.FindMaxOfGivenNumbers({1001, 1, 5, 6, 100, 101, 300}))

        Console.WriteLine(If(ut.isHex("AP"), "true - valid Hex string", "False - invalid Hex string"))
        Dim b() As Byte = Encoding.UTF8.GetBytes("abcd")
        Console.WriteLine(b.ToString())
        Console.WriteLine(Encoding.UTF8.GetString(b))
        Console.ReadLine()

    End Sub

    Public Class Employee
        Dim sal As Double = 0.0

        Sub SetSal()
            Me.sal = 10001.0
        End Sub

    End Class

End Module
