Imports System.Text.RegularExpressions

Module Money

    Public Enum OperationType
        NewItem
        ModifyItem
        DeleteItem
        Empty
    End Enum

    '
    '通用全字符串匹配
    '
    Function MoneyCheck(ByVal vc As String, ByVal format As String) As Boolean
        Dim r As New Regex(format)
        Dim mt As Match = r.Match(vc)
        Return mt.Length = vc.Length
    End Function

    '
    '货币格式2000000.00格式
    '
    Function MoneyValid(ByVal currency As String) As Boolean
        Return MoneyCheck(currency, "(\d)*(\.\d{2})?")
    End Function
    '
    '将数字串转化为货币格式的
    '
    Function NumbericTransfer(ByVal num As String) As String
        Return CType(num, Decimal).ToString("c", CGFormatInfo)
    End Function

    Public Sub Money_Enter(ByVal sender As Object, ByVal e As EventArgs)
        If CType(sender, TextBox).Text.StartsWith("0") Then
            CType(sender, TextBox).Text = String.Empty
            Return
        End If
        If CType(sender, TextBox).Text <> String.Empty Then
            CType(sender, TextBox).Text = CType(sender, TextBox).Text.Replace(",", "")
            CType(sender, TextBox).Text = CType(sender, TextBox).Text.Replace(".00", "")
        End If
    End Sub

    Public Sub KillComma(ByVal sender As Object)
        While CType(sender, TextBox).Text.StartsWith(",")
            CType(sender, TextBox).Text = CType(sender, TextBox).Text.Substring(1, CType(sender, TextBox).Text.Length - 1)
        End While
    End Sub
    '
    'txtMoney的leave事件
    '
    Public Sub Money_Leave(ByVal sender As Object, ByVal e As EventArgs)
        If CType(sender, TextBox).Text = String.Empty Then
            CType(sender, TextBox).Text = "0"
            Return
        ElseIf CType(sender, TextBox).Text.StartsWith("0") Then
            Return
        End If
        Try
            KillComma(sender)
            If CType(sender, TextBox).Text <> String.Empty Then
                CType(sender, TextBox).Text = NumbericTransfer(CType(sender, TextBox).Text)
            End If
        Catch
            CType(sender, TextBox).Text = 0
        End Try
    End Sub
    '
    'txtMoney的KeyPress事件
    '
    Public Sub Money_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If e.KeyChar = "," Then ' Or e.KeyChar = "-"
            Return
        End If
        If Not (IsNumeric(e.KeyChar) Or e.KeyChar = ChrW(8) Or e.KeyChar = ChrW(46)) Then
            e.Handled = True
        ElseIf e.KeyChar = ChrW(46) And CType(sender, TextBox).Text.IndexOf(".") > 0 Then
            e.Handled = True
        End If
    End Sub

    Public Sub money_format(ByVal sender As Object, ByVal e As ConvertEventArgs)
        ' The method converts only to string type. Test this using the DesiredType.
        If (Not e.DesiredType Is GetType(String)) Then
            Return
        End If
        ' Use the ToString method to format the value as currency ("c").
        If (e.Value Is System.DBNull.Value) Then
            Return
        End If
        Dim x As Decimal = CType(e.Value, Decimal)
        e.Value = x.ToString("n")
    End Sub
    Public Sub SetObjTag(ByVal sender As Object)
        Dim str As String = sender.GetType.ToString
        Select Case str.Substring(str.LastIndexOf(".") + 1, str.Length - str.LastIndexOf(".") - 1)
            Case "ComboBox"
                CType(sender, ComboBox).Tag = CType(sender, ComboBox).SelectedValue
            Case "TextBox"
                CType(sender, TextBox).Tag = CType(sender, TextBox).Text
            Case "CheckBox"
                CType(sender, CheckBox).Tag = CType(sender, CheckBox).Checked
            Case "NumericUpDown"
                CType(sender, NumericUpDown).Tag = CType(sender, NumericUpDown).Value
            Case "RichTextBox"
                CType(sender, RichTextBox).Tag = CType(sender, RichTextBox).Text
            Case "DateTimePicker"
                CType(sender, DateTimePicker).Tag = CType(sender, DateTimePicker).Value.Date
            Case Else
        End Select
    End Sub
    Public Function IsChanged(ByVal sender As Object) As Boolean
        Dim str As String = sender.GetType.ToString
        Select Case str.Substring(str.LastIndexOf(".") + 1, str.Length - str.LastIndexOf(".") - 1)
            Case "ComboBox"
                Return Not System.Object.Equals(CType(sender, ComboBox).Tag, CType(sender, ComboBox).SelectedValue)
            Case "TextBox"
                Return Not System.Object.Equals(CType(sender, TextBox).Tag, CType(sender, TextBox).Text)
            Case "CheckBox"
                Return Not System.Object.Equals(CType(sender, CheckBox).Tag, CType(sender, CheckBox).Checked)
            Case "NumericUpDown"
                Return Not System.Object.Equals(CType(sender, NumericUpDown).Tag, CType(sender, NumericUpDown).Value)
            Case "RichTextBox"
                Return Not System.Object.Equals(CType(sender, RichTextBox).Tag, CType(sender, RichTextBox).Text)
            Case "DateTimePicker"
                Return Not System.Object.Equals(CType(sender, DateTimePicker).Tag, CType(sender, DateTimePicker).Value.Date)
            Case Else
                Return False
        End Select
    End Function

    Public Function MyIIf(ByVal Expression As Boolean, ByVal TruePart As Object, ByVal FalsePart As Object) As Object
        If Expression Then
            Return TruePart
        Else
            Return FalsePart
        End If
    End Function

    Public Function MyIIf(ByVal Expression As Object, ByVal type As Type, ByVal NullValue As Object) As Object
        If IsDBNull(Expression) Then
            Return NullValue
        ElseIf Expression Is Nothing Then
            Return NullValue
        ElseIf Expression.ToString.Trim = String.Empty Then
            Return NullValue
        ElseIf type Is GetType(String) Then
            Return CStr(Expression)
        ElseIf type Is GetType(Double) Then
            Return CDbl(Expression)
        ElseIf type Is GetType(Integer) Then
            Return CInt(Expression)
        ElseIf type Is GetType(Long) Then
            Return CLng(Expression)
        End If
    End Function

    Public Function GetApplyDate(ByVal project_code As String) As DateTime
        Dim result As DateTime
        Dim dsQuery As DataSet = gWs.GetCommonQueryInfo("SELECT apply_date FROM project WHERE project_code='" & project_code & "'")
        If dsQuery.Tables(0).Rows.Count > 0 Then
            If dsQuery.Tables(0).Rows(0).IsNull(0) Then
                result = gWs.GetSysTime.Date
            Else
                result = DateTime.Parse(dsQuery.Tables(0).Rows(0)(0))
            End If
        Else
            result = gWs.GetSysTime.Date
        End If
        dsQuery.Dispose()
        Return result
    End Function

    Public Sub LockControls(ByVal parentContainer As Control)
        Dim obj As Control
        For Each obj In parentContainer.Controls
            If obj.GetType Is GetType(TextBox) Then
                CType(obj, TextBox).ReadOnly = True
                CType(obj, TextBox).BackColor = Color.Gainsboro
            ElseIf obj.GetType Is GetType(DataGrid) Then
                CType(obj, DataGrid).ReadOnly = True
            ElseIf obj.Controls.Count > 0 Then
                LockControls(obj)
            Else
                obj.Enabled = obj.GetType Is GetType(Label) OrElse obj.GetType Is GetType(Splitter)
            End If
        Next
    End Sub
    '
    '根据项目编码来获取业务品种
    '
    Public Function GetServiceType(ByVal projectcode As String) As String
        Dim sv As String = String.Empty
        Dim dsST As DataSet = gWs.GetCommonQueryInfo("SELECT ApplyServiceType,ServiceType FROM viewProjectInfo WHERE ProjectCode='" & projectcode & "'")
        If dsST.Tables(0).Rows.Count > 0 Then
            If dsST.Tables(0).Rows(0)(1) Is DBNull.Value Then
                sv = dsST.Tables(0).Rows(0)(0) & ""
            Else
                sv = dsST.Tables(0).Rows(0)(1) & ""
            End If
        End If
        Return sv
    End Function

    Public Class DataChangedMonitor

        Private ownerForm As Form
        Private hasChanged As Boolean = False
        Private _controlName As String

        Public Sub New(ByVal owner As Form)
            ownerForm = owner
        End Sub

        Public Sub AddMonitor(ByVal aimControls() As System.Windows.Forms.Control)
            Dim con As Control
            For Each con In aimControls
                AddMonitor(con)
            Next
        End Sub

        Public Sub AddMonitor(ByVal aimControl As System.Windows.Forms.Control)
            If aimControl.GetType Is GetType(TextBox) Then
                AddHandler CType(aimControl, TextBox).TextChanged, AddressOf TextBoxChangedMonitor
            ElseIf aimControl.GetType Is GetType(DateTimePicker) Then
                AddHandler CType(aimControl, DateTimePicker).ValueChanged, AddressOf DateTimeChangedMonitor
            ElseIf aimControl.GetType Is GetType(ComboBox) Then
                AddHandler CType(aimControl, ComboBox).SelectedIndexChanged, AddressOf ComboBoxChangedMonitor
            End If
        End Sub

        Private Sub TextBoxChangedMonitor(ByVal sender As Object, ByVal e As EventArgs)
            If hasChanged Then
                Return
            End If
            If ownerForm.ActiveControl.Name = CType(sender, TextBox).Name Then
                hasChanged = True
                _controlName = CType(sender, TextBox).Name
            End If
        End Sub

        Private Sub DateTimeChangedMonitor(ByVal sender As Object, ByVal e As EventArgs)
            If hasChanged Then
                Return
            End If
            If ownerForm.ActiveControl.Name = CType(sender, DateTimePicker).Name Then
                hasChanged = True
                _controlName = CType(sender, Control).Name
            End If
        End Sub

        Private Sub ComboBoxChangedMonitor(ByVal sender As Object, ByVal e As EventArgs)
            If hasChanged Then
                Return
            End If
            If ownerForm.ActiveControl.Name = CType(sender, ComboBox).Name Then
                hasChanged = True
                _controlName = CType(sender, Control).Name
            End If
        End Sub

        Public Property Dirty() As Boolean
            Get
                Return hasChanged
            End Get
            Set(ByVal Value As Boolean)
                If Not Value Then
                    _controlName = String.Empty
                End If
                hasChanged = Value
            End Set
        End Property

        Public ReadOnly Property ControlName()
            Get
                Return _controlName
            End Get
        End Property

    End Class
End Module
