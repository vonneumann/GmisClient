'作者 罗庆锋 日期：20030407

'代偿费用
Public Class frmRefundDebtInfo
    Inherits frmChargeFeeBase

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意：以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents txtAccountType As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtAccountType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gpbxResult.SuspendLayout()
        Me.gpbxDetail.SuspendLayout()
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnModify
        '
        Me.btnModify.Visible = True
        '
        'gpbxResult
        '
        Me.gpbxResult.Location = New System.Drawing.Point(8, 56)
        Me.gpbxResult.Size = New System.Drawing.Size(576, 200)
        Me.gpbxResult.Visible = True
        '
        'btnNew
        '
        Me.btnNew.Visible = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(376, 16)
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.Text = "金   额(元)"
        Me.Label1.Visible = True
        '
        'dtpDate
        '
        Me.dtpDate.Value = New Date(2003, 4, 7, 20, 4, 51, 983)
        Me.dtpDate.Visible = True
        '
        'txtSummary
        '
        Me.txtSummary.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Visible = True
        '
        'lblFeeType
        '
        Me.lblFeeType.AutoSize = True
        Me.lblFeeType.Size = New System.Drawing.Size(48, 14)
        Me.lblFeeType.Text = "科   目"
        Me.lblFeeType.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Visible = True
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(448, 13)
        Me.txtIncome.Size = New System.Drawing.Size(120, 21)
        Me.txtIncome.Visible = True
        '
        'gpbxDetail
        '
        Me.gpbxDetail.Visible = True
        '
        'Label6
        '
        Me.Label6.Visible = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Size = New System.Drawing.Size(48, 14)
        Me.Label2.Visible = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.Text = "代偿日期"
        Me.Label3.Visible = True
        '
        'Label5
        '
        Me.Label5.Visible = True
        '
        'txtCorName
        '
        Me.txtCorName.Visible = True
        '
        'dgMoney
        '
        Me.dgMoney.AccessibleName = "DataGrid"
        Me.dgMoney.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgMoney.Size = New System.Drawing.Size(570, 180)
        Me.dgMoney.Visible = True
        '
        'cmbxType
        '
        Me.cmbxType.DropDownWidth = 136
        Me.cmbxType.ItemHeight = 12
        Me.cmbxType.Location = New System.Drawing.Point(232, 13)
        Me.cmbxType.Size = New System.Drawing.Size(136, 20)
        Me.cmbxType.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 8)
        Me.txtProjectCode.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'txtAccountType
        '
        Me.txtAccountType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAccountType.Location = New System.Drawing.Point(80, 32)
        Me.txtAccountType.Name = "txtAccountType"
        Me.txtAccountType.ReadOnly = True
        Me.txtAccountType.Size = New System.Drawing.Size(96, 21)
        Me.txtAccountType.TabIndex = 34
        Me.txtAccountType.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 14)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "科   目"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmRefundDebtInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 383)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label5, Me.Label6, Me.gpbxDetail, Me.btnExit, Me.btnCommit, Me.btnNew, Me.btnModify, Me.btnDelete, Me.btnSave, Me.txtCorName, Me.txtProjectCode, Me.gpbxResult, Me.Label4, Me.txtAccountType})
        Me.Name = "frmRefundDebtInfo"
        Me.Text = "登记代偿项目信息"
        Me.gpbxResult.ResumeLayout(False)
        Me.gpbxDetail.ResumeLayout(False)
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private firstItemCode As String() = {"001", "002", "003"} '计算的一级编码，供二级用
    Private secondItemCode As String() = {"004"} '计算的二级代码，供三级用
    Private thirdItemCode As String() = {"005"} '三级代码
    '根据Item表自动产生每个科目的记录
    Private Sub CreateDataRow(ByVal inputCode As String, ByVal payout As Double)
        Dim ndr As DataRow = dsAccountDetail.Tables(0).NewRow
        With ndr
            .Item("project_code") = ProjectCode
            .Item("date") = MyBase.SystemDate.Date
            .Item("phase") = ReturnProjectPhase()
            .Item("item_type") = item_type
            .Item("item_code") = inputCode
            .Item("payout") = payout
            .Item("remark") = MyBase.TypeDescription()
            .Item("type") = dsitem.Tables(0).Select("item_code='" & inputCode & "'")(0)("item_name") & ""
            .Item("create_person") = UserName
            .Item("create_date") = SystemDate
        End With
        dsAccountDetail.Tables(0).Rows.Add(ndr)
    End Sub

    Private Sub Calculate(ByVal fromCode() As String, ByVal toCode() As String, Optional ByVal operation As String = "+", Optional ByVal otherArg As Object = Nothing)
        Dim fromStr, toStr As String
        Dim result As Double
        Dim drs() As DataRow

        If operation.Trim = "+" Then    '加操作
            result = 0
        ElseIf operation.Trim = "*" Then    '乘操作
            result = 1
        End If

        For Each toStr In toCode
            For Each fromStr In fromCode
                drs = dsAccountDetail.Tables(0).Select("item_code='" & fromStr & "'")
                If drs.Length > 0 AndAlso Not IsDBNull(drs(0)("payout")) Then
                    If operation.Trim = "+" Then    '加操作
                        result += CDbl(drs(0)("payout"))
                    ElseIf operation.Trim = "*" Then    '乘操作
                        result = result * CDbl(drs(0)("payout")) * CDbl(otherArg)
                    End If
                End If
            Next

            If dsAccountDetail.Tables(0).Select("item_code='" & toStr & "'").Length = 0 Then
                CreateDataRow(toStr, result) '如果没有计算科目的信息记录，则新增
            Else
                dsAccountDetail.Tables(0).Select("item_code='" & toStr & "'")(0)("payout") = result
            End If
        Next
    End Sub

    Protected Overrides Sub AdditionalOperation()
        Calculate(firstItemCode, secondItemCode)
        Calculate(secondItemCode, thirdItemCode, "*", 1.25)
    End Sub
    'Protected Overrides Sub SetObjEnabled(ByVal IsEnabled As Boolean)
    'MyBase.SetObjEnabled(IsEnabled)
    'cmbxType.Enabled = False
    'End Sub
    '初始化帐目处理
    Private Sub initializeAccountHandle()
        dsAccountDetail = New DataSet()
        GetDataSource()
        'IniBindingForAccount()
        bmAccount = BindingContext(dsAccountDetail, "project_account_detail")
        dgMoney.DataMember = "project_account_detail"
        dgMoney.DataSource = dsAccountDetail
        dgMoney.TableStyles.Add(addTableStyle)
        '供用户选择的科目必须是非计算科目，所以需加过滤
        Dim strCode, range As String
        For Each strCode In firstItemCode
            range += "'" & strCode & "',"
        Next
        range = range.Remove(range.Length - 1, 1)
        dsItem.Tables("TItem").DefaultView.RowFilter = "item_code IN (" & range & ")"
        cmbxType.DataSource = dsItem.Tables("TItem").DefaultView
        cmbxType.DisplayMember = "item_name"
        cmbxType.ValueMember = "item_code"
        'If dgMoney.CurrentRowIndex >= 0 Then
        '    cmbxType.SelectedValue = CStr(dgMoney.Item(dgMoney.CurrentRowIndex, 4)).Trim
        'End If
        'txtAccountType.DataBindings.Add("Text", cmbxType.DataSource, "item_name")
        'CreateDataRows() '创建特定的行
    End Sub
    Private Sub frmGuarantFee_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        txtCorName.Text = CorporationName : txtProjectCode.Text = ProjectCode
        IsRefundDebt = True
        item_type = "33"

        SystemDate = gWs.GetSysTime
        initializeAccountHandle()
        btnNew.Focus()
    End Sub

    Protected Overrides Sub IniBindingForAccount()
        Dim moneybind As Binding = New Binding("Text", dsAccountDetail, "project_account_detail.payout")
        txtIncome.DataBindings.Add(moneybind)
        AddHandler moneybind.Format, AddressOf money_format
        dtpDate.DataBindings.Add(New Binding("Value", dsAccountDetail, "project_account_detail.date"))
        txtSummary.DataBindings.Add(New Binding("Text", dsAccountDetail, "project_account_detail.remark"))
        cmbxType.DataBindings.Add(New Binding("SelectedValue", dsAccountDetail, "project_account_detail.item_code"))
        HasBinded = True
    End Sub

    Protected Overrides Function addTableStyle() As DataGridTableStyle
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "project_account_detail"
        dgts.AllowSorting = False
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 0
        col7.MappingName = "serial_num"
        col7.Width = 0
        dgts.GridColumnStyles.Add(col7)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1
        col3.MappingName = "date"
        col3.HeaderText = "代偿日期"
        col3.Width = 80
        col3.Format = "yyyy-MM-dd"
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  3
        col4.MappingName = "payout"
        col4.HeaderText = " 金  额 "
        col4.Alignment = HorizontalAlignment.Right
        col4.Width = 100
        col4.NullText = String.Empty
        col4.Format = "n"
        dgts.GridColumnStyles.Add(col4)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col5.MappingName = "remark"
        col5.HeaderText = " 摘  要 "
        col5.Alignment = HorizontalAlignment.Left
        col5.Width = 360
        col5.NullText = String.Empty
        dgts.GridColumnStyles.Add(col5)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col6.MappingName = "item_code"
        col6.Width = 0
        dgts.GridColumnStyles.Add(col6)
        Return dgts
    End Function

    Private Sub DataGridMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgMoney.MouseUp
        If MyBase.bmAccount.Position >= 0 Then
            Me.Cursor = Cursors.WaitCursor
            txtAccountType.Text = dsitem.Tables(0).Select("item_code='" & CType(bmaccount.Current, DataRowView)("item_code").ToString & "'")(0)("item_name") & ""
            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class
