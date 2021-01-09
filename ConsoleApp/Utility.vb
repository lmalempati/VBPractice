Public Class Utility


    'added to return  the sum on two given numbers
    Function SumOfTwoNumbers(a As Integer, b As Integer) As Integer

        Return a + b
    End Function

    'Find max of given numbers
    Function Findmax(first As Integer, second As Integer) As Integer
        If first > second Then
            Return first
        Else
            Return second
        End If
    End Function

    Function FinaMaxOfGivenNumbers(Nums() As Integer) As Integer
        Dim max As Integer
        max = Nums(0)
    
        For Each item As String In Nums
            If item > max Then
                max = item
            End If
        Next
        Return max
    End Function
End Class
