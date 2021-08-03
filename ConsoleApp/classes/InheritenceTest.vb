Imports System.Text

Public Class TestStat
    Dim Test As String = ""

End Class

Public MustInherit Class Person
    Public Name As String = ""
    Public Address As String
End Class

Public Class Employee
    Inherits Person

    Public EmpId As String = ""
    Public Property Department As String

    Public Property Salary As Double
    Function ReturnEmpDetails() As String
        Dim sb As StringBuilder = New StringBuilder()
        sb.Append("Name:" & Name)
        sb.Append("Departmet:" & Department)
        sb.Append("Address:" & Address)

        Return sb.ToString
    End Function

    Sub SalaryUpdate()
        UpdateSalary(1000)
    End Sub
End Class
