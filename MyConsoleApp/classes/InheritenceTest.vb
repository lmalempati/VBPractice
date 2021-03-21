Imports System.Text

Public MustInherit Class Person
    Public Name As String = ""
    Public Address As String
End Class

Public Class Employee
    Inherits Person

    Public EmpId As String = ""
    Public Property Department As String

    Function ReturnEmpDetails() As String
        Dim sb As StringBuilder = New StringBuilder()
        sb.Append("Name:" & Name)
        sb.Append("Departmet:" & Department)
        sb.Append("Address:" & Address)

        Return sb.ToString
    End Function
End Class
