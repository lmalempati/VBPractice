Public Class CarVersion2
    Inherits CarBase
    Implements ICar_Model_Make

    Public Property Model As String Implements ICar_Model_Make.Model
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Overrides ReadOnly Property CarVersion As String
        Get
            Return "version2"
        End Get
    End Property

    Public Sub Build() Implements ICar_Model_Make.Build
        '
        Console.WriteLine("Version 2 Car built.")
    End Sub
End Class
