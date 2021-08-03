Public MustInherit Class CarBase
    Public MustOverride ReadOnly Property CarVersion As String
    Public Overrides Function ToString() As String
        Return "Car Version: " + CarVersion.ToString()
    End Function

End Class

Public Class CarBaseTest
    Dim Car As CarBase
    Public Function SetCar(Version As Int16) As Integer
        Select Case Version
            Case 1
                Car = New CarVersion1
                Car.GetCarMake.Build()
                Car.GetCarMake.Model = "Model1"
            Case 2
                Car = New CarVersion2
            Case Else

        End Select
        Return 0
    End Function

    Public Sub ValidateCar()
        Car.GetCarMake().Build()
        Console.WriteLine(Car.CarVersion)
    End Sub
End Class

