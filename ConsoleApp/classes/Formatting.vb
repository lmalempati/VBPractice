Imports System.Globalization

Public Class Formatting
    Public Sub SurroundingSub()
        ' Display string representations of numbers for en-us culture
        Dim ci As CultureInfo = New CultureInfo("en-us")

        ' Output floating point values
        Dim floating As Double = 10761.937554
        Console.WriteLine("C: {0}", floating.ToString("C", ci))           ' Displays "C: $10,761.94"
        Console.WriteLine("E: {0}", floating.ToString("E03", ci))         ' Displays "E: 1.076E+004"
        Console.WriteLine("F: {0}", floating.ToString("F04", ci))         ' Displays "F: 10761.9376"
        Console.WriteLine("G: {0}", floating.ToString("G", ci))           ' Displays "G: 10761.937554"
        Console.WriteLine("N: {0}", floating.ToString("N03", ci))         ' Displays "N: 10,761.938"
        Console.WriteLine("P: {0}", (floating / 10000).ToString("P02", ci)) ' Displays "P: 107.62 %"
        Console.WriteLine("R: {0}", floating.ToString("R", ci))           ' Displays "R: 10761.937554"
        Console.WriteLine()

        ' Output integral values
        Dim integral As Integer = 8395
        Console.WriteLine("C: {0}", integral.ToString("C", ci))           ' Displays "C: $8,395.00"
        Console.WriteLine("D: {0}", integral.ToString("D6", ci))          ' Displays "D: 008395"
        Console.WriteLine("E: {0}", integral.ToString("E03", ci))         ' Displays "E: 8.395E+003"
        Console.WriteLine("F: {0}", integral.ToString("F01", ci))         ' Displays "F: 8395.0"
        Console.WriteLine("G: {0}", integral.ToString("G", ci))           ' Displays "G: 8395"
        Console.WriteLine("N: {0}", integral.ToString("N01", ci))         ' Displays "N: 8,395.0"
        Console.WriteLine("P: {0}", (integral / 10000.0).ToString("P02", ci)) ' Displays "P: 83.95 %"
        Console.WriteLine("X: 0x{0}", integral.ToString("X", ci))           ' Displays "X: 0x20CB"
        Console.WriteLine()
    End Sub

End Class
