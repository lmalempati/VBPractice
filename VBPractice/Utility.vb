Imports System.Text.RegularExpressions
Imports System.Runtime.CompilerServices

Module Utility

    Interface IMyInterface
        Sub Run()
        Sub Play()
        Function GetDate()
    End Interface

    Function TrimString(str As String) As String
        'Dim reg As Regex
        'reg.Match(str, "")
        Return str.Trim()
    End Function

    Class Employee
        Implements IDisposable
        Implements IMyInterface

        Private disposedValue As Boolean

        Function MyFunc() As Employee

            Return Me
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
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="message"></param>
    <Extension()>
    Public Sub ShowMessage(message As String)

        MessageBox.Show(message)
    End Sub

    <Extension()>
    Function GetWordCount(s As String) As Integer
        '
        Dim arrWords As String()
        arrWords = s.Split(New String({" ", ",", "."}))
        Return arrWords.Count
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
