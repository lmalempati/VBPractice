Imports System.IO
Imports Newtonsoft.Json
Class prod
    Public Property ItemDescription As String
    Public Property UPC_PLU As String
End Class

Public Class ApprovedPodList
    Private Sub ApprovedPodList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView_APL.DataSource = GetData()

        'DataGridView_APL.Columns.Remove(columnName:="ItemDescription")
        'DataGridView_APL.Columns.Add(CreateComboBoxColumn())
        DataGridView_APL.Refresh()
    End Sub

    Private Function GetData() As List(Of prod)
        Dim _ProductList As String = File.ReadAllText("D:\Working-SDG\VBPractice\VBPractice\APL-Data\products.ny.json")
        'Dim dt As DataTable = 
        'DataTable DataTable = (DataTable)JsonConvert.DeserializeObject(jsonString, (TypeOf (DataTable)))
        'DataGridView_APL.DataError += New 
        '    DataGridViewDataErrorEventHandler(DataGridView1_DataError)
        Dim lstProd As List(Of prod) = JsonConvert.DeserializeObject(Of List(Of prod))(_ProductList)
        'DataGridView.DataSource = DataTable;
        Return lstProd
        'dtProds.Columns.Remove()
    End Function

    Private Sub AddComboBoxColumns()
        Dim comboboxColumn As DataGridViewComboBoxColumn
        comboboxColumn = CreateComboBoxColumn()
        SetAlternateChoicesUsingDataSource(comboboxColumn)
        comboboxColumn.HeaderText = "Desc"
        DataGridView_APL.Columns.Insert(0, comboboxColumn)
        comboboxColumn = CreateComboBoxColumn()
        SetAlternateChoicesUsingDataSource(comboboxColumn)
        comboboxColumn.HeaderText = "Desc"
        DataGridView_APL.Columns.Add(comboboxColumn)
    End Sub


    Private Function CreateComboBoxColumn() As DataGridViewComboBoxColumn
        Dim column As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn()

        If True Then
            column.DataPropertyName = "ItemDescription"
            column.HeaderText = "Item Description"
            column.DropDownWidth = 160
            column.Width = 90
            column.MaxDropDownItems = 3
            column.FlatStyle = FlatStyle.Flat
        End If

        Return column
    End Function

    Private Sub SetAlternateChoicesUsingDataSource(ByVal comboboxColumn As DataGridViewComboBoxColumn)
        If True Then
            comboboxColumn.DataSource = GetData()
            comboboxColumn.ValueMember = "ItemDescription"
            comboboxColumn.DisplayMember = comboboxColumn.ValueMember
        End If
    End Sub
End Class