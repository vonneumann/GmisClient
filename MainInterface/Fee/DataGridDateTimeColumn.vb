Public Class DataGridDateTimeColumn
    Inherits DataGridColumnStyle


    Public ColumnDateTimePicker As DateTimePicker
    Public Shared _RowCount As Integer

    Private _source As System.Windows.Forms.CurrencyManager
    Private _rowNum As Integer = -1
    Private _isEditing As Boolean
    Private _xMargin As Integer = 2
    Private _yMargin As Integer = 1
    Private RaiseDateTimePickedValueChangedEvent As Boolean = True
    Public Sub New(ByVal DateFormat As System.Windows.Forms.DateTimePickerFormat, ByVal dataGrid As DataGrid, Optional ByVal CustomFormat As String = Nothing)
        _source = Nothing
        _isEditing = False
        _RowCount = -1

        ColumnDateTimePicker = New DateTimePicker()
        ColumnDateTimePicker.Format = DateFormat
        If Not CustomFormat Is Nothing Then
            ColumnDateTimePicker.CustomFormat = CustomFormat
        End If
        ColumnDateTimePicker.Visible = False
        dataGrid.Controls.Add(ColumnDateTimePicker)

        AddHandler dataGrid.Leave, AddressOf LeaveColumnDateTimePicker
        AddHandler dataGrid.Scroll, New EventHandler(AddressOf HandleScroll)
        AddHandler ColumnDateTimePicker.Leave, AddressOf LeaveColumnDateTimePicker
        'AddHandler ColumnDateTimePicker.ValueChanged, AddressOf ColumnDateTimePickerValueChanged
    End Sub

    Private Sub LeaveColumnDateTimePicker(ByVal sender As Object, ByVal e As EventArgs)
        If RaiseDateTimePickedValueChangedEvent And _isEditing Then
            SetColumnValueAtRow(_source, _rowNum, ColumnDateTimePicker.Value.Date)
        End If
        ColumnDateTimePicker.Visible = False
        ColumnDateTimePicker.Hide()
    End Sub

    Private Sub HandleScroll(ByVal sender As Object, ByVal e As EventArgs)
        If ColumnDateTimePicker.Visible Then
            ColumnDateTimePicker.Hide()
        End If
    End Sub 'HandleScroll

    Private Sub ColumnDateTimePickerValueChanged(ByVal sender As Object, ByVal e As EventArgs)

        'If RaiseDateTimePickedValueChangedEvent And _isEditing Then
        '    SetColumnValueAtRow(_source, _rowNum, ColumnDateTimePicker.Value.Date)
        'End If

    End Sub

    Protected Overrides Function Commit(ByVal dataSource As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer) As Boolean
        If Not _isEditing Then
            Return True
        End If
        Try
            If _rowNum <> -1 Then
                SetColumnValueAtRow(_source, _rowNum, ColumnDateTimePicker.Value.Date)
            End If
        Catch
            Return False
        Finally
            _isEditing = False
            ColumnDateTimePicker.Hide()
        End Try

        Return True
    End Function 'Commit

    'Protected Overrides Sub ConcedeFocus()
    '    Console.WriteLine("ConcedeFocus")
    '    MyBase.ConcedeFocus()
    'End Sub 'ConcedeFocus

    Protected Overrides Function GetColumnValueAtRow(ByVal source As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer) As Object

        Dim dv As DataView = CType(source.List, DataView)
        dv.RowStateFilter = DataViewRowState.CurrentRows
        If rowNum < dv.Count Then
            Return dv(rowNum)(Me.MappingName)
        End If

    End Function 'GetColumnValueAtRow

    Protected Overrides Sub SetColumnValueAtRow(ByVal [source] As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer, ByVal value As Object)

        If Not _isEditing Then
            Return
        End If
        Dim dv As DataView = CType([source].List, DataView)
        dv.RowStateFilter = DataViewRowState.CurrentRows
        If _rowNum > -1 And _rowNum < dv.Count Then
            dv(_rowNum).Row(Me.MappingName) = value
            dv(_rowNum).Row.EndEdit()
        End If
        _isEditing = False

    End Sub 'SetColumnValueAtRow 

    Private i As Integer = 1
    Protected Overloads Overrides Sub Edit(ByVal [source] As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer, _
            ByVal bounds As System.Drawing.Rectangle, ByVal [readOnly] As Boolean, ByVal instantText As String, ByVal cellIsVisible As Boolean)

        If Not cellIsVisible Then
            Return
        End If
        _isEditing = True
        bounds.Offset(_xMargin, _yMargin)

        RaiseDateTimePickedValueChangedEvent = False

        _rowNum = Me.DataGridTableStyle.DataGrid.CurrentRowIndex
        _source = [source]

        ColumnDateTimePicker.Location = New Point(bounds.Left, bounds.Top)
        ColumnDateTimePicker.Size = New Size(bounds.Width, bounds.Height)

        Dim dv As DataView = CType([source].List, DataView)
        dv.RowStateFilter = DataViewRowState.CurrentRows

        If IsDBNull(dv(_rowNum).Row(Me.MappingName)) Then
            dv(_rowNum).Row(Me.MappingName) = DateTime.Today '由于字段没值，并且DateTimePicker的Value值可能并不改变，所以赋值给字段值为当前日期
            ColumnDateTimePicker.Value = DateTime.Today
        Else
            ColumnDateTimePicker.Value = Convert.ToDateTime(dv(_rowNum).Row(Me.MappingName))
        End If

        ColumnDateTimePicker.Visible = True
        RaiseDateTimePickedValueChangedEvent = True

    End Sub

    Protected Overloads Overrides Function GetPreferredHeight(ByVal g As Graphics, ByVal value As Object) As Integer
        Return FontHeight + _yMargin
    End Function

    Protected Overrides Function GetMinimumHeight() As Integer
        Return ColumnDateTimePicker.Height + _yMargin
    End Function

    Protected Overloads Overrides Function GetPreferredSize(ByVal g As Graphics, ByVal value As Object) As Size
        Dim _extents As Size = Size.Ceiling(g.MeasureString(Me.ColumnDateTimePicker.Text, Me.DataGridTableStyle.DataGrid.Font))
        _extents.Width += _xMargin * 2
        _extents.Height += _yMargin
        Return _extents
    End Function
    Protected Overloads Overrides Sub Abort(ByVal rowNum As Integer)
        _isEditing = False
        ColumnDateTimePicker.Hide()
    End Sub

    Protected Overloads Overrides Sub Edit(ByVal source As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer, _
                    ByVal bounds As System.Drawing.Rectangle, ByVal [readOnly] As Boolean)
        Edit(source, rowNum, bounds, [readOnly], "", True)
    End Sub 'Edit


    Protected Overloads Overrides Sub Paint(ByVal g As System.Drawing.Graphics, ByVal bounds As System.Drawing.Rectangle, _
                                     ByVal source As System.Windows.Forms.CurrencyManager, ByVal rowNum As Integer)
        Dim text As String = GetText(GetColumnValueAtRow(source, rowNum))
        Me.PaintText(g, bounds, text, False)
    End Sub

    Protected Overloads Overrides Sub Paint(ByVal g As Graphics, ByVal bounds As Rectangle, ByVal [source] As CurrencyManager, _
                        ByVal rowNum As Int32, ByVal alignToRight As Boolean)
        Dim text As String = GetText(GetColumnValueAtRow(source, rowNum))
        Me.PaintText(g, bounds, text, False)
    End Sub

    Protected Overloads Overrides Sub Paint(ByVal g As Graphics, ByVal bounds As Rectangle, ByVal source As CurrencyManager, ByVal rowNum As Integer, _
                        ByVal backBrush As Brush, ByVal foreBrush As Brush, ByVal alighToRight As Boolean)
        Dim text As String = GetText(GetColumnValueAtRow(source, rowNum))
        Me.PaintText(g, bounds, text, alighToRight, backBrush, foreBrush)
    End Sub

    Private Sub PaintText(ByVal g As Graphics, ByVal bounds As Rectangle, ByVal text As String, ByVal alignToRight As Boolean, _
                        Optional ByVal _backBrush As SolidBrush = Nothing, Optional ByVal _foreBrush As SolidBrush = Nothing)
        If _backBrush Is Nothing Then
            _backBrush = New SolidBrush(Me.DataGridTableStyle.BackColor)
        End If
        If _foreBrush Is Nothing Then
            _foreBrush = New SolidBrush(Me.DataGridTableStyle.ForeColor)
        End If
        Dim _rectF As RectangleF = New RectangleF(bounds.Left, bounds.Top, bounds.Width, bounds.Height)
        Dim _format As StringFormat = New StringFormat()
        If alignToRight Then
            _format.FormatFlags = StringFormatFlags.DirectionRightToLeft
        Else
            _format.FormatFlags = StringFormatFlags.NoWrap
        End If
        Select Case Me.Alignment
            Case HorizontalAlignment.Left
                _format.Alignment = StringAlignment.Near
                Exit Select
            Case HorizontalAlignment.Center
                _format.Alignment = StringAlignment.Center
                Exit Select
            Case HorizontalAlignment.Right
                _format.Alignment = StringAlignment.Far
                Exit Select
        End Select
        g.FillRectangle(_backBrush, bounds)
        bounds.Offset(0, _yMargin)
        g.DrawString(text, Me.DataGridTableStyle.DataGrid.Font, _foreBrush, _rectF, _format)
        _format.Dispose()
    End Sub

    Private Function GetText(ByVal value As Object) As String
        If IsDBNull(value) Or value Is Nothing Then
            Return NullText
        End If
        Dim Val As DateTime = Convert.ToDateTime(value)
        Try
            Select Case ColumnDateTimePicker.Format
                Case DateTimePickerFormat.Custom
                    Return Val.ToString(ColumnDateTimePicker.CustomFormat)
                Case DateTimePickerFormat.Long
                    Return Val.ToLongDateString()
                Case DateTimePickerFormat.Short
                    Return Val.ToShortDateString
            End Select
        Catch
            Return Val.ToString("yyyy-MM-dd")
        End Try
    End Function

    Public Overrides Property [readonly]() As Boolean
        Get
            Return MyBase.ReadOnly
        End Get
        Set(ByVal Value As Boolean)
            MyBase.ReadOnly = Value
            ColumnDateTimePicker.Enabled = Not Value
        End Set
    End Property


    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'Private Sub cbo_Enter(ByVal sender As Object, ByVal e As EventArgs)
    '    TextBox.Visible = True
    '    TextBox.BringToFront()
    '    ColumnDateTimePicker.Visible = False
    '    ColumnDateTimePicker.Hide()
    'End Sub

    'Public WriteOnly Property ForbidComboBoxShow() As Boolean
    '    Set(ByVal Value As Boolean)
    '        If Value Then
    '            AddHandler ColumnDateTimePicker.Enter, AddressOf cbo_Enter
    '            AddHandler TextBox.Enter, AddressOf cbo_Enter
    '        Else
    '            RemoveHandler ColumnDateTimePicker.Enter, AddressOf cbo_Enter
    '            RemoveHandler TextBox.Enter, AddressOf cbo_Enter
    '        End If
    '    End Set
    'End Property

End Class
