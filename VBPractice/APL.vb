Imports System.IO
Imports Newtonsoft.Json
Public Class APL
    Private Sub ApprovedPodList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim lstProd As List(Of prods) = GetData()
        DataGridView1.DataSource = lstProd

        'DataGridView1.Columns.Remove(columnName:="ItemDescription")
        'AddComboBoxColumns()
        'DataGridView1.Columns.Add(CreateComboBoxColumn())
        DataGridView1.Refresh()

        For Each prod In lstProd
            ComboDesc.Items.Add(prod.ItemDescription)
        Next

        'ComboDesc.DataBindings.Add("ItemDescription", , "ItemDescription")
    End Sub

    Function GetDescTable() As DataTable
        Dim dt As New DataTable("ItemDesc")
        dt.Columns.Add("ItemDescription", GetType(String))
        Dim _ProductList As String = File.ReadAllText("D:\Working-SDG\VBPractice\VBPractice\APL-Data\products.ny.json")
        dt = JsonConvert.DeserializeObject(Of DataTable)(_ProductList)
        Return dt
    End Function

    Private Function GetData() As List(Of prods)
        Dim _ProductList As String = File.ReadAllText("D:\Working-SDG\VBPractice\VBPractice\APL-Data\products.ny.json")
        'Dim dt As DataTable = 
        'DataTable DataTable = (DataTable)JsonConvert.DeserializeObject(jsonString, (TypeOf (DataTable)))
        'DataGridView_APL.DataError += New 
        '    DataGridViewDataErrorEventHandler(DataGridView1_DataError)
        Dim lstProd As List(Of prods) = JsonConvert.DeserializeObject(Of List(Of prods))(_ProductList)
        'DataGridView.DataSource = DataTable;

        Return lstProd
        'dtProds.Columns.Remove()
    End Function

    Private Sub AddComboBoxColumns()
        Dim comboboxColumn As DataGridViewComboBoxColumn
        comboboxColumn = CreateComboBoxColumn()
        SetAlternateChoicesUsingDataSource(comboboxColumn)
        comboboxColumn.HeaderText = "Desc"
        DataGridView1.Columns.Insert(0, comboboxColumn)
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
    Private Sub DataGridView1_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DataGridView1.DataError
        '
    End Sub

    Private Sub ComboDesc_TextChanged(sender As Object, e As EventArgs) Handles ComboDesc.TextChanged
        Dim cb As ComboBox = CType(sender, ComboBox)
        Dim txt = cb.Text
        If txt.Length >= 3 Then
            Dim ind = cb.FindString(txt)
            'cb.SelectedIndex = ind
            If ind > -1 Then cb.SelectedItem = cb.Items.Item(ind)
        End If
    End Sub
End Class

Class prods
    Public Property ItemDescription As String
    Public Property UPC_PLU As String
End Class

