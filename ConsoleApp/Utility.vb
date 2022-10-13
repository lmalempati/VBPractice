Imports System.Text.RegularExpressions
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Linq

Friend Class Test
    Shared name As String
End Class
Public Class CreditCard
    Shared Function LuhanCheck(ByVal CardNum As String) As Boolean
        Dim result As String = ""
        Dim myEnum As CharEnumerator = Nothing
        ' if any bit shifted left number gets doubled
        ' << bitwise shift left iperator
        ' AND operator on numbers acts as bitwise AND.
        If CardNum.Select(Function(c, i) (AscW(c) - 48) << ((CardNum.Length - i - 1) And 1)).Sum(Function(n) (If(n > 9, n - 9, n))) Mod 10 = 0 Then Return True
        ' CardNum.Select(Function(c, i) (AscW(c) - 48) << ((CardNum.Length - i - 1) And 1)) converts as 
        'result - 70816812900162128014265
        Return False
    End Function
End Class
Public Module Utility
    Function GetRandom(max As Integer)
        Return New Random(max)
    End Function
    Function TrimString(str As String) As String
        'Dim reg As Regex
        'reg.Match(str, "")
        Return str.Trim()
    End Function

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="message"></param>
    <Extension()>
    Public Sub ShowMessage(message As String)

        'MessageBox.Show(message)
    End Sub

    <Extension()>
    Function GetWordCount(s As String) As Integer
        '
        Dim arrWords As String()
        arrWords = s.Split(New String({" ", ",", "."}))
        Return arrWords.Count
    End Function

    <Extension> Public Function TryHexToBytes(value As String, ByRef Result As Byte()) As Boolean
        ' If value.TryRemoveHexWhitespace = False Then Return False
        If value = "" Then Result = New Byte() {}
        Dim MyLength As Integer = value.Length \ 2
        ReDim Result(MyLength - 1)
        For I As Integer = 0 To MyLength - 1
            If Byte.TryParse(value.Substring(I * 2, 2), Globalization.NumberStyles.HexNumber, Nothing, Result(I)) = False Then Return False
        Next
        Return True
    End Function

    <Extension> Public Function ToHex(value As Byte()) As String
        Dim Hex As StringBuilder = New StringBuilder
        For Each b As Byte In value
            Hex.AppendFormat("{0:x2}", b)
        Next
        Return Hex.ToString
    End Function

    '<Extension()> Public Function EmpValidateSal(emp As Object) As Employee
    '    Dim MyEmp As Employee = TryCast(emp, Employee)
    '    If MyEmp.sal > 10000 Then
    '        MyEmp.sal = 10000
    '    End If
    '    Return MyEmp
    'End Function
    <Extension> Public Function HexToBytes(value As String) As Byte()
        Dim MyValue As String = value.RemoveHexWhitespace
        If MyValue = "" Then Return New Byte() {}
        Dim MyLength As Integer = MyValue.Length \ 2
        Dim MyResult(MyLength - 1) As Byte
        For I As Integer = 0 To MyLength - 1
            MyResult(I) = Convert.ToByte(MyValue.Substring(I * 2, 2), 16)
        Next
        Return MyResult
    End Function

    <Extension> Public Function RemoveHexWhitespace(Text As String) As String
        Dim MyText As String = _RemoveHexWhitespace(Text)
        If MyText.Length Mod 2 <> 0 Then Throw New ArgumentException("Hexadecimal value length must be even.", "Text")
        Return MyText
    End Function

    <Extension> Function UpdateSalary(e As Employee, increment As Double) As Double
        e.Salary += increment
        Return e.Salary
    End Function
    Private Function _RemoveHexWhitespace(Text As String) As String
        Dim MyText As String = Text.Replace("-", "").Replace(" ", "").Replace("<", "").Replace(">", "")
        Return MyText
    End Function

    ''' <summary>
    ''' Gives factorial of a given number..
    ''' </summary>
    ''' <param name="n"></param>
    ''' <returns></returns>
    Function Factorial(n As ULong) As ULong
        If n > 1 Then
            Return n * Factorial(n - 1)
        Else
            Return n
        End If
    End Function
End Module

Public Module RegExpres
    Function IsFleet() As Boolean
        Dim PANs As List(Of String) = New List(Of String)
        PANs.Add("5568432211445331")

        For Each item In PANs

            Dim First6Dig As String = Left(item, 6)
            '553[2-3][3-8][0-1]|5560[8-9][3-9] 556[1-5][0-9][0-9]|
            Dim reg As Regex = New Regex("553[2-3][3-8][0-1]|5560[8-9][3-9] 556[1-5][0-9][0-9]")
            If reg.IsMatch(First6Dig.ToString()) Then
                Return True
            End If
        Next

        Return False
    End Function

    Function Is10didgitNumber(input As String) As Boolean
        Dim s As String = "^[0-9]{10}"
        'If Regex.IsMatch(input, "^[0-9]{10}$") Then
        If Regex.IsMatch(input, "^\d{10}$") Then
            Console.WriteLine("a valid number...")
            Return True
        End If
        Console.WriteLine("input has non-numeric characters.")
        Return False
    End Function

End Module
Public Module FunctionParameters
    Sub TestFunctionAsParameter()
        Dim st As String = "fasdfsd "
        FunctionAsParameter(st, AddressOf TrimString)
        Dim srBytes As String = "01"
        'FunctionAsParameter(srBytes, AddressOf ToHex)
    End Sub

    Function FunctionAsParameter(s As String, Method As Func(Of String, String)) As String
        Console.WriteLine(Method(s))
        Return ""
    End Function
End Module

Public Module LinqTest
    <Extension> Public Function EvenLengthNames(data As IEnumerable(Of String)) As IEnumerable
        ' this also works
        Return Enumerable.Where(data, Function(S) S.Length Mod 2 = 0)
        Return data.Where(Function(s) s.Length Mod 2 = 0)
    End Function

    <Extension> Function Reshuflle(data As IEnumerable(Of String)) As IEnumerable
        Dim r As New Random()
        Return data.Append("---")
    End Function

End Module