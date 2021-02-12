Imports System.Text.RegularExpressions
Public Class RegExPractice
    Function RegEx1() As Boolean
        Dim reg As Regex = New Regex("\b(?<word>\w+)\s+(\k<word>)\b", RegexOptions.IgnoreCase Or RegexOptions.Compiled)
        Dim text As String = "The the quick brown fox  fox jumps over the lazy dog dog."
        Dim matches As MatchCollection = reg.Matches(text)

        Console.WriteLine("{0} matches found in: \n {1}", matches.Count, text)

        For Each item As Match In matches
            Dim groups As GroupCollection = item.Groups
            Console.WriteLine("'{0}' repleated at positions {1} and {2}", groups("quick").Value, groups(0).Index, groups(1).Index)
        Next

        Return True
        End
    End Function
End Class
