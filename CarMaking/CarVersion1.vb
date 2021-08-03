Public Class CarVersion1
    Inherits CarBase
    Implements ICar_Model_Make
    Implements ICar_Engine

    Dim _model As String
    Private _Engine_Capacity As Decimal
    Private _FuelType As String
    Property Model As String Implements ICar_Model_Make.Model
        Get
            Return _model
        End Get
        Set(value As String)
            _model = value
        End Set
    End Property

    Public Property Engine_Capacity As Decimal Implements ICar_Engine.Engine_Capacity
        Get
            Return _Engine_Capacity
        End Get
        Set(value As Decimal)
            _Engine_Capacity = value
        End Set
    End Property

    Public Property FuelType As Object Implements ICar_Engine.FuelType
        Get
            Return _FuelType
        End Get
        Set(value As Object)
            _FuelType = value
        End Set
    End Property
    Public Overrides ReadOnly Property CarVersion As String
        Get
            Return "version1"
        End Get
    End Property

    Public Sub Build() Implements ICar_Model_Make.Build
        '
    End Sub

    Public Sub SetEngineProps() Implements ICar_Engine.SetEngineProps
        Console.WriteLine("Version 1 Car built.")
    End Sub
End Class
