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

        'Console.WriteLine("Hello Cardnox")

        'Dim ut As New Utility()
        'Console.WriteLine(ut.SumOfTwoNumbers(10, 20))


        ''Console.WriteLine(" Max of 10, 11 is: " + ut.Findmax(10, 11))
        ''Console.WriteLine(ut.FindMaxOfGivenNumbers({1001, 1, 5, 6, 100, 101, 300}))

        'Console.WriteLine(If(ut.isHex("AP"), "true - valid Hex string", "False - invalid Hex string"))
        'Dim b() As Byte = Encoding.UTF8.GetBytes("abcd")
        'Console.WriteLine(b.ToString())
        'Console.WriteLine(Encoding.UTF8.GetString(b))
        'Console.WriteLine(GetType(Integer))
        'Console.WriteLine(GetType(Int16))
        'Console.WriteLine(GetType(Double))
        'Console.WriteLine(GetType(Object))

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

    Enum EggSizeEnum
        Jumbo
        ExtraLarge
        Large
        Medium
        Small
    End Enum
    Public Enum EnumPinCapability
        Unspecified = 0
        PinCapable = 1
        NotPinCapable = 2
    End Enum

    Public Sub Iterate()
        Dim names = [Enum].GetNames(GetType(EggSizeEnum))
        For Each name In names
            Console.Write(name & " ")
        Next
        Console.WriteLine()
        ' Output: Jumbo ExtraLarge Large Medium Small 

        Dim values = [Enum].GetValues(GetType(EggSizeEnum))
        For Each value In values
            Console.Write(value & " ")
        Next
        Console.WriteLine()
        ' Output: 0 1 2 3 4 
    End Sub

    'Sub TestHehToBytes()
    '    Dim xTag9F33 As String = "6028C8"
    '    VBPracticeForm.RegExpres.HexToBytes(xTag9F33)
    'End Sub

    Class EMVTags
        Public Function Tag9F33ToPinCapability() As EnumPinCapability
            Dim xTag9F33 As String = "6028C8"
            Return EnumPinCapability.Unspecified
            'Try
            '    If xTag9F33 = "" Then Return EnumPinCapability.Unspecified
            '    If (xTag9F33.HexToBytes(1) And 128) = 128 Then Return EnumPinCapability.PinCapable '128 = 10000000 - Plaintext PIN for offline ICC verification
            '    If (xTag9F33.HexToBytes(1) And 64) = 64 Then Return EnumPinCapability.PinCapable '64 =    01000000 - Enciphered PIN for online verification
            '    If (xTag9F33.HexToBytes(1) And 16) = 16 Then Return EnumPinCapability.PinCapable '16 =    00010000 - Enciphered PIN for offline verification
            '    Return EnumPinCapability.NotPinCapable
            'Catch ex As Exception
            '    Return EnumPinCapability.Unspecified
            'End Try
        End Function
    End Class

End Module
