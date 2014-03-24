
'人员：罗庆锋；日期2003-04-05
Public Class frmChargeOverdueRecord
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmChargeOverdueRecord))
        Me.txtAccountType = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.gpbxResult.SuspendLayout()
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbxDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbxType
        '
        Me.cmbxType.DropDownWidth = 136
        Me.cmbxType.ItemHeight = 12
        Me.cmbxType.Name = "cmbxType"
        Me.cmbxType.Size = New System.Drawing.Size(136, 20)
        '
        'Label5
        '
        Me.Label5.Name = "Label5"
        '
        'gpbxResult
        '
        Me.gpbxResult.Location = New System.Drawing.Point(8, 56)
        Me.gpbxResult.Name = "gpbxResult"
        Me.gpbxResult.Size = New System.Drawing.Size(576, 216)
        '
        'txtCorName
        '
        Me.txtCorName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCorName.Name = "txtCorName"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 8)
        Me.txtProjectCode.Name = "txtProjectCode"
        '
        'Label6
        '
        Me.Label6.Name = "Label6"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.Text = "逾期日期"
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(64, 368)
        Me.btnNew.Name = "btnNew"
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(416, 368)
        Me.btnCommit.Name = "btnCommit"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(240, 368)
        Me.btnDelete.Name = "btnDelete"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(152, 368)
        Me.btnModify.Name = "btnModify"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(384, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.Text = "金    额(元)"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(328, 368)
        Me.btnSave.Name = "btnSave"
        '
        'dgMoney
        '
        Me.dgMoney.AccessibleName = "DataGrid"
        Me.dgMoney.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgMoney.Name = "dgMoney"
        Me.dgMoney.Size = New System.Drawing.Size(570, 196)
        '
        'gpbxDetail
        '
        Me.gpbxDetail.Location = New System.Drawing.Point(8, 272)
        Me.gpbxDetail.Name = "gpbxDetail"
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(464, 13)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(104, 21)
        '
        'txtSummary
        '
        Me.txtSummary.Name = "txtSummary"
        '
        'lblFeeType
        '
        Me.lblFeeType.AutoSize = True
        Me.lblFeeType.Name = "lblFeeType"
        Me.lblFeeType.Size = New System.Drawing.Size(54, 17)
        Me.lblFeeType.Text = "科    目"
        '
        'dtpDate
        '
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Value = New Date(2003, 4, 7, 20, 45, 20, 983)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(504, 368)
        Me.btnExit.Name = "btnExit"
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'txtAccountType
        '
        Me.txtAccountType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAccountType.Location = New System.Drawing.Point(80, 32)
        Me.txtAccountType.Name = "txtAccountType"
        Me.txtAccountType.ReadOnly = True
        Me.txtAccountType.Size = New System.Drawing.Size(96, 21)
        Me.txtAccountType.TabIndex = 32
        Me.txtAccountType.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "科    目"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmChargeOverdueRecord
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(592, 399)
        Me.Controls.Add(Me.txtAccountType)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChargeOverdueRecord"
        Me.Text = "登记逾期项目信息"
        Me.Controls.SetChildIndex(Me.Label4, 0)
        Me.Controls.SetChildIndex(Me.txtAccountType, 0)
        Me.Controls.SetChildIndex(Me.gpbxResult, 0)
        Me.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.Controls.SetChildIndex(Me.txtCorName, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.btnModify, 0)
        Me.Controls.SetChildIndex(Me.btnNew, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.gpbxDetail, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.gpbxResult.ResumeLayout(False)
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbxDetail.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private firstItemCode As String() = {"001", "002"}  '计算的一级编码，供二级用
    Private secondItemCode As String() = {"003"} '计算的二级代码，供三级用
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

    '2007 yjf add 保存逾期记录时保存失信记录
    Private Sub SaveDefectRecord()
        Dim dsTempDefectRecord As DataSet = gWs.GetCorpDefectInfo("{project_code='" & Me.ProjectCode & "' and isnull(is_overdue,0)=1}")
        Dim dr, drAccountDetail As DataRow

        Dim i As Integer
        For i = 0 To dsTempDefectRecord.Tables(0).Rows.Count - 1
            dsTempDefectRecord.Tables(0).Rows(i).Delete()
        Next
        gWs.UpdateCorpDefect(dsTempDefectRecord)
        dsTempDefectRecord.AcceptChanges()

        '记录逾期本金
        If dsAccountDetail.Tables(0).Select("item_type='32' and item_code='001'").Length <> 0 Then
            drAccountDetail = dsAccountDetail.Tables(0).Select("item_type='32' and item_code='001'")(0)
            dr = dsTempDefectRecord.Tables(0).NewRow()
            With dr
                .Item("guid") = Guid.NewGuid()
                .Item("corporation_code") = MyBase.getProjectCode.Substring(0, 5)
                .Item("corporation_name") = MyBase.getCorporationName
                .Item("DiscreditableDate") = drAccountDetail.Item("date")
                .Item("description") = "逾期本金:" & drAccountDetail.Item("payout")
                .Item("source") = "中心"
                .Item("create_person") = UserName
                .Item("create_date") = Now
                .Item("project_code") = Me.ProjectCode
                .Item("is_overdue") = 1
            End With
            dsTempDefectRecord.Tables(0).Rows.Add(dr)
            gWs.UpdateCorpDefect(dsTempDefectRecord)
            dsTempDefectRecord.AcceptChanges()
        End If

        '记录逾期利息
        If dsAccountDetail.Tables(0).Select("item_type='32' and item_code='002'").Length <> 0 Then
            drAccountDetail = dsAccountDetail.Tables(0).Select("item_type='32' and item_code='002'")(0)
            dr = dsTempDefectRecord.Tables(0).NewRow()
            With dr
                .Item("guid") = Guid.NewGuid()
                .Item("corporation_code") = MyBase.getProjectCode.Substring(0, 5)
                .Item("corporation_name") = MyBase.getCorporationName
                .Item("DiscreditableDate") = drAccountDetail.Item("date")
                .Item("description") = "逾期利息:" & drAccountDetail.Item("payout")
                .Item("source") = "中心"
                .Item("create_person") = UserName
                .Item("create_date") = Now
                .Item("project_code") = Me.ProjectCode
                .Item("is_overdue") = 1
            End With
            dsTempDefectRecord.Tables(0).Rows.Add(dr)
            gWs.UpdateCorpDefect(dsTempDefectRecord)
            dsTempDefectRecord.AcceptChanges()
        End If
    End Sub

    Protected Overrides Sub AdditionalOperation()
        Calculate(firstItemCode, secondItemCode)
        SaveDefectRecord()
    End Sub

    'Protected Overrides Sub SetObjEnabled(ByVal IsEnabled As Boolean)
    '    MyBase.SetObjEnabled(IsEnabled)
    '    cmbxType.Enabled = False
    'End Sub

    '初始化帐目处理
    Private Sub initializeAccountHandle()
        dsAccountDetail = New DataSet
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
        IsOverDueFee = True

        systemdate = gWs.GetSysTime
        item_type = "32"
        initializeAccountHandle()
        'CreateDataRows() '根据Item表产生纪录
        'btnNew.Visible = False
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
        Dim dgts As DataGridTableStyle = New DataGridTableStyle
        dgts.MappingName = "project_account_detail"
        dgts.AllowSorting = False
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index 0
        col7.MappingName = "serial_num"
        col7.Width = 0
        dgts.GridColumnStyles.Add(col7)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index 1
        col3.MappingName = "date"
        col3.HeaderText = "逾期日期 "
        col3.Width = 80
        col3.Format = "yyyy-MM-dd"
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index  2
        col4.MappingName = "payout"
        col4.HeaderText = " 金  额  "
        col4.Alignment = HorizontalAlignment.Right
        col4.Width = 90
        col4.NullText = "0"
        col4.Format = "n"
        dgts.GridColumnStyles.Add(col4)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index  3
        col5.MappingName = "remark"
        col5.HeaderText = " 摘  要 "
        col5.Alignment = HorizontalAlignment.Left
        col5.Width = 360
        col5.NullText = String.Empty
        dgts.GridColumnStyles.Add(col5)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index  4
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
