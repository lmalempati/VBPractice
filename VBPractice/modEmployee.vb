Public Module modEmployee
    Interface IMyInterface
        Sub Run()
        Sub Play()
        Function GetDate()
    End Interface


    Public Class Employee
        Implements IDisposable
        Implements IMyInterface

        Private disposedValue As Boolean
        Public sal As Double = 0.0

        Function MyFunc() As Employee

            Return Me
        End Function

        Sub SetSal()
            Me.sal = 10001.0
        End Sub

        Function ValidateSal(ByVal emp As Employee) As Boolean
            ' Me.EmpValidateSal()
            emp.sal = 1000

            Return True
        End Function

        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not disposedValue Then
                If disposing Then
                    ' TODO: dispose managed state (managed objects)
                End If

                ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
                ' TODO: set large fields to null
                disposedValue = True
            End If
        End Sub

        ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
        ' Protected Overrides Sub Finalize()
        '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        '     Dispose(disposing:=False)
        '     MyBase.Finalize()
        ' End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
            Dispose(disposing:=True)
            GC.SuppressFinalize(Me)
        End Sub

        Public Sub Run() Implements IMyInterface.Run
            Throw New NotImplementedException()
        End Sub

        Public Sub Play() Implements IMyInterface.Play
            Throw New NotImplementedException()
        End Sub

        Public Function GetDate() As Object Implements IMyInterface.GetDate
            Throw New NotImplementedException()
        End Function
    End Class

End Module