Public Class DataGridComboBoxColumn
	Inherits DataGridTextBoxColumn

	Public ColumnComboBox As ComboBox
    Public Shared _RowCount As Integer

    Private _source As System.Windows.Forms.CurrencyManager
	Private _rowNum As Integer
	Private _isEditing As Boolean

	Public Sub New()
		_source = Nothing
		_isEditing = False
		_RowCount = -1

		ColumnComboBox = New ComboBox()
		ColumnComboBox.DropDownStyle = ComboBoxStyle.DropDownList

		AddHandler ColumnComboBox.Leave, AddressOf LeaveComboBox
		AddHandler ColumnComboBox.SelectionChangeCommitted, AddressOf ComboStartEditing
	End Sub	'New

    Private Sub HandleScroll(ByVal sender As Object, ByVal e As EventArgs)
        If ColumnComboBox.Visible Then
            ColumnComboBox.Hide()
        End If
    End Sub 'HandleScroll

    Private Sub ComboStartEditing(ByVal sender As Object, ByVal e As EventArgs)
        _isEditing = True
        MyBase.ColumnStartedEditing(sender)
    End Sub 'ComboMadeCurrent

    Private Sub LeaveComboBox(ByVal sender As Object, ByVal e As EventArgs)
        If _isEditing Then
            SetColumnValueAtRow(_source, _rowNum, ColumnComboBox.Text)
            _isEditing = False
            Invalidate()
        End If

        ColumnComboBox.Hide()
        AddHandler Me.DataGridTableStyle.DataGrid.Scroll, New EventHandler(AddressOf HandleScroll)
    End Sub 'LeaveComboBox

    Protected Overloads Overrides Sub Edit(ByVal [source] As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer, ByVal bounds As System.Drawing.Rectangle, ByVal [readOnly] As Boolean, ByVal instantText As String, ByVal cellIsVisible As Boolean)
        MyBase.Edit([source], rowNum, bounds, [readOnly], instantText, cellIsVisible)

        _rowNum = rowNum
        _source = [source]

        ColumnComboBox.Parent = Me.TextBox.Parent
        ColumnComboBox.Location = Me.TextBox.Location
        ColumnComboBox.Size = New Size(Me.TextBox.Size.Width, ColumnComboBox.Size.Height)
        ColumnComboBox.SelectedIndex = ColumnComboBox.FindStringExact(Me.TextBox.Text)
        ColumnComboBox.Text = Me.TextBox.Text
        Me.TextBox.Visible = False
        ColumnComboBox.Visible = True
        AddHandler Me.DataGridTableStyle.DataGrid.Scroll, AddressOf HandleScroll

        ColumnComboBox.BringToFront()
        ColumnComboBox.Focus()
    End Sub 'Edit

    Protected Overrides Function Commit(ByVal dataSource As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer) As Boolean
        If _isEditing Then
            _isEditing = False
            SetColumnValueAtRow(dataSource, rowNum, ColumnComboBox.Text)
        End If

        Return True
    End Function 'Commit

    Protected Overrides Sub ConcedeFocus()
        Console.WriteLine("ConcedeFocus")
        MyBase.ConcedeFocus()
    End Sub 'ConcedeFocus

    Protected Overrides Function GetColumnValueAtRow(ByVal [source] As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer) As Object
        Dim s As Object = MyBase.GetColumnValueAtRow([source], rowNum)
        Dim dv As DataView = CType(Me.ColumnComboBox.DataSource, DataView)
        Dim rowCount As Integer = dv.Count
        Dim i As Integer = 0
        Dim s1 As Object

        'if things are slow, you could order your dataview
        '& use binary search instead of this linear one
        While i < rowCount
            s1 = dv(i)(Me.ColumnComboBox.ValueMember)
            If (Not s1 Is DBNull.Value) AndAlso (Not s Is DBNull.Value) AndAlso s = s1 Then
                Exit While
            End If
            i += 1
        End While

        If i < rowCount Then
            Return dv(i)(Me.ColumnComboBox.DisplayMember)
        End If
        Return DBNull.Value
    End Function 'GetColumnValueAtRow

    Protected Overrides Sub SetColumnValueAtRow(ByVal [source] As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer, ByVal value As Object)
        Dim s As Object = value
        Dim dv As DataView = CType(Me.ColumnComboBox.DataSource, DataView)
        Dim rowCount As Integer = dv.Count
        Dim i As Integer = 0
        Dim s1 As Object

        'if things are slow, you could order your dataview
        '& use binary search instead of this linear one
        While i < rowCount
            s1 = dv(i)(Me.ColumnComboBox.DisplayMember)
            If (Not s1 Is DBNull.Value) AndAlso s = s1 Then
                Exit While
            End If
            i += 1
        End While

        If i < rowCount Then
            s = dv(i)(Me.ColumnComboBox.ValueMember)
        Else
            s = DBNull.Value
        End If

        MyBase.SetColumnValueAtRow([source], rowNum, s)
    End Sub 'SetColumnValueAtRow 
    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    Private Sub cbo_Enter(ByVal sender As Object, ByVal e As EventArgs)
        TextBox.Visible = True
        TextBox.BringToFront()
        ColumnComboBox.Visible = False
        ColumnComboBox.Hide()
    End Sub

    Public WriteOnly Property ForbidComboBoxShow() As Boolean
        Set(ByVal Value As Boolean)
            If Value Then
                AddHandler ColumnComboBox.Enter, AddressOf cbo_Enter
                AddHandler TextBox.Enter, AddressOf cbo_Enter
            Else
                RemoveHandler ColumnComboBox.Enter, AddressOf cbo_Enter
                RemoveHandler TextBox.Enter, AddressOf cbo_Enter
            End If
        End Set
    End Property

End Class
