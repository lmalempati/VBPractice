Imports System.Reflection
Imports VBPractice
Imports System.Linq
Imports CarMaking
Imports Newtonsoft.Json
Module Module1


    Sub Main()
        'LinqTest()
        'Exit Sub
        Dim json As String = "[
    {
      'xNACSProductCode': '001',
      'xUnitOfMeasure': 'G',
      'xQuantity': '01',
	  'xUnitPrice': '21023',
	  'xProductAmount':'1023'
    },
	{
      'xNACSProductCode': '101',
      'xUnitOfMeasure': 'G',
      'xQuantity': '02',
	  'xUnitPrice': '21023',
	  'xProductAmount':'1023'
    },
		{
      'xNACSProductCode': '400',
      'xUnitOfMeasure': 'G',
      'xQuantity': '03',
	  'xUnitPrice': '21023',
	  'xProductAmount':'1023'
    }
	]"

        modSerialize.DeserializeJSONToNACSProducts(json)
        'Dim list As List(Of NACSProductdtls) = modSerialize.DeserializeJSONToNACSProducts(json)
        modSerialize.SerializeNACSProducts()
        Exit Sub
        Dim wd As String = "01"
        Console.WriteLine(wd.GetEnumNameFromVal(Of Weekdays))
        Exit Sub

        Dim cbt As CarBaseTest = New CarBaseTest()
        cbt.SetCar(2)
        cbt.SetCar(1)
        cbt.ValidateCar()
        Console.ReadLine()
        Exit Sub

        Dim s1 As String = "fad safs a afd, ,afds ,afds,"
        'Console.WriteLine(" ".ToCharArray()(0))
        Dim i As Int16 = s1.GetWordCount(" ".ToCharArray()(0))
        'Dim j As Int16 = s1.GetWordCount(' ')
        Dim xTag9F33 As String = "6028C8"
        xTag9F33.HexToBytes()
        Dim input As String = ""
        'Tag9F33ToPinCapability()
        'While Input.ToLower <> "exit"
        '    input = Console.ReadLine.Trim
        '    If input <> "" AndAlso input.ToLower <> "exit" Then
        '        'Console.WriteLine("Invalid inppu, try agaian.")
        '        Is10didgitNumber(input)
        '        'Continue While
        '        input = ""
        '    ElseIf input.ToLower = "exit" Then
        '        Exit Sub
        '    End If
        'End While
        'Dim per As Person = 
        Dim emp As New Employee
        Dim emp1 As New Employee
        emp.Name = "TestName"
        emp.EmpId = "1"

        'emp1.Name = "TestName"
        'emp1.EmpId = "2"

        'Static Dim per As Person = emp
        'per = emp1
        'Console.WriteLine(TryCast(per, Employee).EmpId)
        '' reflection method
        'GetEmpMetaData()
        emp.Salary = 1000
        emp.UpdateSalary(1000)
        Console.WriteLine("now employee salary:" & emp.Salary.ToString)

        FunctionParameters.TestFunctionAsParameter()
        Dim s As String = "Agsdfgf"
        Dim res = New List(Of Byte)
        For Each ch As Char In s
            res.Add(Convert.ToByte(ch))
        Next

        'BitArray ba = New BitArray(res)
        ToHex(res.ToArray)
        Console.WriteLine(Convert.ToByte(150))
        'Dim f As Formatting = New Formatting
        'f.SurroundingSub()
        Console.ReadLine()
    End Sub

    Private Sub LinqTest()
        Dim names() = {"lakshmi", "narayana", "Vivek", "Sathvik", "Santhi"}
        names.EvenLengthNames
        Dim rpt = Enumerable.Repeat("2", 20)
        PrintCollection(rpt, "Print 2s")
        Dim n = From i In names
                Where i.Length <= 7
                Order By i Descending
                Select i
        PrintCollection(n, "5 char names")
        Dim newnames = names.Reshuflle
        PrintCollection(newnames, "reshuffled names")
        Dim cc = New CreditCard
        If cc.LuhanCheck("7088869008268012235") Then Console.WriteLine("valid card")

        Console.ReadLine()
    End Sub

    Private Sub PrintCollection(names As IEnumerable, heading As String)
        Console.WriteLine("+++++++" + heading + "+++++++++")

        For Each item In names
            Console.WriteLine(item)
        Next
    End Sub

    Sub GetEmpMetaData()
        Dim ti As TypeInfo = GetType(Employee)
        Dim PropInfo As PropertyInfo() = ti.GetProperties
        For Each pi As PropertyInfo In PropInfo
            Console.WriteLine("Property name:" & pi.Name)
        Next

        Dim FldInfo As FieldInfo() = ti.GetFields()
        For Each fi As FieldInfo In FldInfo
            Console.WriteLine("Field name:" & fi.Name)
        Next
    End Sub

    Public Function Tag9F33ToPinCapability() As EnumPinCapability
        Dim xTag9F33 As String = "6028C8"
        Try
            If xTag9F33 = "" Then Return EnumPinCapability.Unspecified
            If (xTag9F33.HexToBytes(1) And 128) = 128 Then Return EnumPinCapability.PinCapable '128 = 10000000 - Plaintext PIN for offline ICC verification
            If (xTag9F33.HexToBytes(1) And 64) = 64 Then Return EnumPinCapability.PinCapable '64 =    01000000 - Enciphered PIN for online verification
            If (xTag9F33.HexToBytes(1) And 16) = 16 Then Return EnumPinCapability.PinCapable '16 =    00010000 - Enciphered PIN for offline verification
            Return EnumPinCapability.NotPinCapable
        Catch ex As Exception
            Return EnumPinCapability.Unspecified
        End Try
    End Function
End Module
