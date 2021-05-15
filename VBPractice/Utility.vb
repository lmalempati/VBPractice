Imports System.Text.RegularExpressions
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

        MessageBox.Show(message)
    End Sub

    <Extension()>
    Public Function GetWordCount(s As String) As Integer
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

    <Extension()> Public Function EmpValidateSal(emp As Object) As Employee
        Dim MyEmp As Employee = TryCast(emp, Employee)
        If MyEmp.sal > 10000 Then
            MyEmp.sal = 10000
        End If
        Return MyEmp
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
