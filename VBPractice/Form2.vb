Imports System.ComponentModel

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles startAsyncButton.Click
        '


        If WorkerBee.IsBusy <> True Then
            WorkerBee.RunWorkerAsync()
        End If
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles WorkerBee.DoWork
        Dim worker As BackgroundWorker = TryCast(sender, BackgroundWorker)

        For i As Integer = 1 To 100

            If worker.CancellationPending = True Then
                e.Cancel = True
                Exit For
            Else
                System.Threading.Thread.Sleep(100)
                worker.ReportProgress(i * 1)
            End If
        Next

        'Dim j = 51
        'While j > 50 And j <= 100
        '    If worker.CancellationPending = True Then
        '        e.Cancel = True
        '    End If

        '    System.Threading.Thread.Sleep(100)
        '    worker.ReportProgress(j * 1)
        '    j += 1

        'End While
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles cancelAsyncButton.Click
        'If WorkerBee.IsBusy = True Then Exit Sub

        If WorkerBee.WorkerSupportsCancellation = True Then
            WorkerBee.CancelAsync()
        End If
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles WorkerBee.ProgressChanged
        '
        resultLabel.Text = (e.ProgressPercentage.ToString() & "%")
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles WorkerBee.RunWorkerCompleted
        '
        If e.Cancelled = True Then
            resultLabel.Text = "Canceled!"
        ElseIf e.[Error] IsNot Nothing Then
            resultLabel.Text = "Error: " & e.[Error].Message
        Else
            resultLabel.Text = "Done!"
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim emp As Employee = New Employee()
        emp.sal = 10002
        emp.ValidateSal(emp)

        'Dim s As String = "Hi there fdsfsdfsdfsdfsdf"
        'MessageBox.Show(s.GetWordCount())

        'MessageBox.Show(Factorial(15))
        'MessageBox.Show(Trim("fads   "))
        Dim s As String = New String("ABCD0014AF11") 'test data
        Dim b(-1) As Byte
        s.TryHexToBytes(b)

        Dim BackToHex As String = ""

        For Each bt As Byte In b
            'b.ToHe
            BackToHex += bt.ToHex()
        Next
        ShowMessage(BackToHex)

        Dim str As String = "test teh test we want to be tested"
        str.GetWordCount()
    End Sub
End Class