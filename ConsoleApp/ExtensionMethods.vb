Imports System.Text.RegularExpressions
Imports System.Runtime.CompilerServices
Imports System.Text

Public Class ExtensionMethods
    ' <Extension()>, in VB.Net extension methods are allowed in modules only

End Class

Public Module ExtMethods
    <Extension> Public Function GetWordCount(s As String, seperator As Char) As Integer
        Dim arrWords As String()
        arrWords = s.Split(seperator)
        'arrWords = s.Split(New Char() {seperator})
        Return arrWords.Count
    End Function

    <Extension> Public Function GetEnumNameFromVal(Of T)(Value As String) As String
        Try
            Return [Enum].GetName(GetType(T), Integer.Parse(Value))
        Catch
            Throw New Exception($"Unable to get name from Enum value: {Value}")
        End Try
    End Function
End Module

