<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class APL
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ComboDesc = New System.Windows.Forms.ComboBox()
        Me.UPC_PLU = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ItemDescription = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UPC_PLU, Me.ItemDescription})
        Me.DataGridView1.Location = New System.Drawing.Point(-3, 95)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(791, 353)
        Me.DataGridView1.TabIndex = 0
        '
        'ComboDesc
        '
        Me.ComboDesc.FormattingEnabled = True
        Me.ComboDesc.Location = New System.Drawing.Point(214, 12)
        Me.ComboDesc.Name = "ComboDesc"
        Me.ComboDesc.Size = New System.Drawing.Size(405, 21)
        Me.ComboDesc.TabIndex = 1
        '
        'UPC_PLU
        '
        Me.UPC_PLU.DataPropertyName = "UPC PLU"
        Me.UPC_PLU.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.UPC_PLU.HeaderText = "UPC PLU"
        Me.UPC_PLU.Name = "UPC_PLU"
        '
        'ItemDescription
        '
        Me.ItemDescription.DataPropertyName = "ItemDescription"
        Me.ItemDescription.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.ItemDescription.HeaderText = "Item Description"
        Me.ItemDescription.Name = "ItemDescription"
        '
        'APL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ComboDesc)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "APL"
        Me.Text = "APL"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ComboDesc As ComboBox
    Friend WithEvents UPC_PLU As DataGridViewComboBoxColumn
    Friend WithEvents ItemDescription As DataGridViewComboBoxColumn
End Class
