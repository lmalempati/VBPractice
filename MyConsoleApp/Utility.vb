﻿Imports System.Text.RegularExpressions
Imports System.Runtime.CompilerServices

Public Module Utility

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

    <Extension> Public Function ToHex(value As Byte) As String
        Return BitConverter.ToString(New Byte() {value})
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
