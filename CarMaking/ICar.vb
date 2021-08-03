Imports System.Runtime.CompilerServices

Public Class Class1
    Function MyFunc() As Integer
        ' ToDo
        Return 0
    End Function

End Class

Interface ICar_Model_Make
    Property Model As String
    Sub Build()
End Interface
Interface ICar_Engine
    Property Engine_Capacity As Decimal
    Property FuelType
    Sub SetEngineProps()
End Interface

Interface ICar_seating
    Property NoOfSeats As Integer
    Property IsPremium As Boolean

    Sub Arrange()
End Interface

Module ICar
    <System.Diagnostics.DebuggerStepThrough()> <Extension> Public Function GetCarMake(Car As CarBase) As ICar_Model_Make
        Return TryCast(Car, ICar_Model_Make)
    End Function
End Module
