

Public Class FQueryProjectExpandDate
    Inherits MainInterface.FQueryBase

    Private count As Integer = 0
    Private nCurrentCount As Integer = 0
    Private isLoad As Boolean = False
    Private flag As Boolean = False '选择子类型
    Private dsBank As DataSet

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
    Friend WithEvents chbDate As System.Windows.Forms.CheckBox
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents cmbServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBank As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents dateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbManagerA As System.Windows.Forms.ComboBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents lbl6 As System.Windows.Forms.Label
    Friend WithEvents lbl8 As System.Windows.Forms.Label
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents dsLoanProject As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents project_code As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents enterprise_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents service_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_a As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_b As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents bank As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents branch_bank As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents start_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents end_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents phase As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents branch_name As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryProjectExpandDate))
        Me.lbl1 = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.lbl3 = New System.Windows.Forms.Label
        Me.lbl4 = New System.Windows.Forms.Label
        Me.lbl5 = New System.Windows.Forms.Label
        Me.lbl6 = New System.Windows.Forms.Label
        Me.lbl8 = New System.Windows.Forms.Label
        Me.chbDate = New System.Windows.Forms.CheckBox
        Me.txtProjectCode = New System.Windows.Forms.TextBox
        Me.cmbServiceType = New System.Windows.Forms.ComboBox
        Me.cmbBank = New System.Windows.Forms.ComboBox
        Me.cmbBranch = New System.Windows.Forms.ComboBox
        Me.dateStart = New System.Windows.Forms.DateTimePicker
        Me.dateEnd = New System.Windows.Forms.DateTimePicker
        Me.cmbManagerA = New System.Windows.Forms.ComboBox
        Me.dsLoanProject = New System.Windows.Forms.DataGridTableStyle
        Me.project_code = New System.Windows.Forms.DataGridTextBoxColumn
        Me.enterprise_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.service_type = New System.Windows.Forms.DataGridTextBoxColumn
        Me.manager_a = New System.Windows.Forms.DataGridTextBoxColumn
        Me.manager_b = New System.Windows.Forms.DataGridTextBoxColumn
        Me.bank = New System.Windows.Forms.DataGridTextBoxColumn
        Me.branch_bank = New System.Windows.Forms.DataGridTextBoxColumn
        Me.sum = New System.Windows.Forms.DataGridTextBoxColumn
        Me.start_date = New System.Windows.Forms.DataGridTextBoxColumn
        Me.end_date = New System.Windows.Forms.DataGridTextBoxColumn
        Me.phase = New System.Windows.Forms.DataGridTextBoxColumn
        Me.status = New System.Windows.Forms.DataGridTextBoxColumn
        Me.branch_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtCorpName = New System.Windows.Forms.TextBox
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCorpName, Me.cmbManagerA, Me.dateEnd, Me.dateStart, Me.cmbBranch, Me.cmbBank, Me.cmbServiceType, Me.txtProjectCode, Me.chbDate, Me.lbl8, Me.lbl6, Me.lbl5, Me.lbl4, Me.lbl3, Me.lbl2, Me.lbl1})
        Me.grpCondition.Size = New System.Drawing.Size(696, 112)
        Me.grpCondition.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(616, 136)
        Me.btnExit.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 136)
        Me.chkVisible.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.Location = New System.Drawing.Point(424, 136)
        Me.btnRefresh.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(520, 160)
        Me.btnPrint.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Bitmap)
        Me.btnClear.Location = New System.Drawing.Point(192, 136)
        Me.btnClear.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 176)
        Me.grdTable.Size = New System.Drawing.Size(696, 320)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dsLoanProject})
        Me.grdTable.Visible = True
        '
        'ImageListQuery
        '
        Me.ImageListQuery.ImageStream = CType(resources.GetObject("ImageListQuery.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Bitmap)
        Me.btnExport.Location = New System.Drawing.Point(520, 136)
        Me.btnExport.Visible = True
        '
        'lbl1
        '
        Me.lbl1.Location = New System.Drawing.Point(32, 23)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(64, 23)
        Me.lbl1.TabIndex = 0
        Me.lbl1.Text = "项目编码"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl2
        '
        Me.lbl2.Location = New System.Drawing.Point(240, 23)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(56, 23)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "企业名称"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl3
        '
        Me.lbl3.Location = New System.Drawing.Point(32, 47)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(64, 23)
        Me.lbl3.TabIndex = 2
        Me.lbl3.Text = "项目经理A"
        Me.lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl4
        '
        Me.lbl4.Location = New System.Drawing.Point(448, 23)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(56, 23)
        Me.lbl4.TabIndex = 3
        Me.lbl4.Text = "业务品种"
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl5
        '
        Me.lbl5.Location = New System.Drawing.Point(240, 47)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(56, 23)
        Me.lbl5.TabIndex = 4
        Me.lbl5.Text = "合作银行"
        Me.lbl5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl6
        '
        Me.lbl6.Location = New System.Drawing.Point(448, 47)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(56, 23)
        Me.lbl6.TabIndex = 5
        Me.lbl6.Text = "合作支行"
        Me.lbl6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl8
        '
        Me.lbl8.Location = New System.Drawing.Point(272, 71)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(16, 23)
        Me.lbl8.TabIndex = 7
        Me.lbl8.Text = "到"
        Me.lbl8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chbDate
        '
        Me.chbDate.Location = New System.Drawing.Point(24, 70)
        Me.chbDate.Name = "chbDate"
        Me.chbDate.Size = New System.Drawing.Size(80, 24)
        Me.chbDate.TabIndex = 8
        Me.chbDate.Text = "展期日期"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(96, 24)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectCode.TabIndex = 0
        Me.txtProjectCode.Text = ""
        '
        'cmbServiceType
        '
        Me.cmbServiceType.Location = New System.Drawing.Point(504, 24)
        Me.cmbServiceType.Name = "cmbServiceType"
        Me.cmbServiceType.Size = New System.Drawing.Size(128, 20)
        Me.cmbServiceType.TabIndex = 3
        '
        'cmbBank
        '
        Me.cmbBank.Location = New System.Drawing.Point(296, 48)
        Me.cmbBank.Name = "cmbBank"
        Me.cmbBank.Size = New System.Drawing.Size(128, 20)
        Me.cmbBank.TabIndex = 4
        '
        'cmbBranch
        '
        Me.cmbBranch.Location = New System.Drawing.Point(504, 48)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(128, 20)
        Me.cmbBranch.TabIndex = 5
        '
        'dateStart
        '
        Me.dateStart.Location = New System.Drawing.Point(96, 72)
        Me.dateStart.Name = "dateStart"
        Me.dateStart.Size = New System.Drawing.Size(120, 21)
        Me.dateStart.TabIndex = 6
        '
        'dateEnd
        '
        Me.dateEnd.Location = New System.Drawing.Point(296, 72)
        Me.dateEnd.Name = "dateEnd"
        Me.dateEnd.Size = New System.Drawing.Size(128, 21)
        Me.dateEnd.TabIndex = 7
        '
        'cmbManagerA
        '
        Me.cmbManagerA.Location = New System.Drawing.Point(96, 48)
        Me.cmbManagerA.Name = "cmbManagerA"
        Me.cmbManagerA.Size = New System.Drawing.Size(121, 20)
        Me.cmbManagerA.TabIndex = 2
        '
        'dsLoanProject
        '
        Me.dsLoanProject.DataGrid = Me.grdTable
        Me.dsLoanProject.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.project_code, Me.enterprise_name, Me.service_type, Me.manager_a, Me.manager_b, Me.bank, Me.branch_bank, Me.sum, Me.start_date, Me.end_date, Me.phase, Me.status, Me.branch_name})
        Me.dsLoanProject.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dsLoanProject.MappingName = "Table"
        '
        'project_code
        '
        Me.project_code.Format = ""
        Me.project_code.FormatInfo = Nothing
        Me.project_code.HeaderText = "项目编码"
        Me.project_code.MappingName = "project_code"
        Me.project_code.NullText = ""
        Me.project_code.Width = 75
        '
        'enterprise_name
        '
        Me.enterprise_name.Format = ""
        Me.enterprise_name.FormatInfo = Nothing
        Me.enterprise_name.HeaderText = "企业名称"
        Me.enterprise_name.MappingName = "enterprise_name"
        Me.enterprise_name.NullText = ""
        Me.enterprise_name.Width = 150
        '
        'service_type
        '
        Me.service_type.Format = ""
        Me.service_type.FormatInfo = Nothing
        Me.service_type.HeaderText = "业务品种"
        Me.service_type.MappingName = "service_type"
        Me.service_type.NullText = ""
        Me.service_type.Width = 120
        '
        'manager_a
        '
        Me.manager_a.Format = ""
        Me.manager_a.FormatInfo = Nothing
        Me.manager_a.HeaderText = "项目经理A角"
        Me.manager_a.MappingName = "manager_a"
        Me.manager_a.NullText = ""
        Me.manager_a.Width = 75
        '
        'manager_b
        '
        Me.manager_b.Format = ""
        Me.manager_b.FormatInfo = Nothing
        Me.manager_b.HeaderText = "项目经理B角"
        Me.manager_b.MappingName = "manager_b"
        Me.manager_b.NullText = ""
        Me.manager_b.Width = 75
        '
        'bank
        '
        Me.bank.Format = ""
        Me.bank.FormatInfo = Nothing
        Me.bank.HeaderText = "合作银行"
        Me.bank.MappingName = "bank"
        Me.bank.NullText = ""
        Me.bank.Width = 120
        '
        'branch_bank
        '
        Me.branch_bank.Format = ""
        Me.branch_bank.FormatInfo = Nothing
        Me.branch_bank.HeaderText = "合作支行"
        Me.branch_bank.MappingName = "branch_bank"
        Me.branch_bank.NullText = ""
        Me.branch_bank.Width = 120
        '
        'sum
        '
        Me.sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.sum.Format = ""
        Me.sum.FormatInfo = Nothing
        Me.sum.HeaderText = "展期金额(万元)"
        Me.sum.MappingName = "sum"
        Me.sum.NullText = ""
        Me.sum.Width = 75
        '
        'start_date
        '
        Me.start_date.Format = "yyyy-MM-dd"
        Me.start_date.FormatInfo = Nothing
        Me.start_date.HeaderText = "展期期起"
        Me.start_date.MappingName = "start_date"
        Me.start_date.NullText = ""
        Me.start_date.Width = 85
        '
        'end_date
        '
        Me.end_date.Format = "yyyy-MM-dd"
        Me.end_date.FormatInfo = Nothing
        Me.end_date.HeaderText = "展期期止"
        Me.end_date.MappingName = "end_date"
        Me.end_date.NullText = ""
        Me.end_date.Width = 85
        '
        'phase
        '
        Me.phase.Format = ""
        Me.phase.FormatInfo = Nothing
        Me.phase.HeaderText = "项目阶段"
        Me.phase.MappingName = "phase"
        Me.phase.NullText = ""
        Me.phase.Width = 75
        '
        'status
        '
        Me.status.Format = ""
        Me.status.FormatInfo = Nothing
        Me.status.HeaderText = "项目状态"
        Me.status.MappingName = "status"
        Me.status.NullText = ""
        Me.status.Width = 75
        '
        'branch_name
        '
        Me.branch_name.Format = ""
        Me.branch_name.FormatInfo = Nothing
        Me.branch_name.HeaderText = "责任部门"
        Me.branch_name.MappingName = "branch_name"
        Me.branch_name.NullText = ""
        Me.branch_name.Width = 75
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(296, 24)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(128, 21)
        Me.txtCorpName.TabIndex = 9
        Me.txtCorpName.Text = ""
        '
        'FQueryProjectExpandDate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 501)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryProjectExpandDate"
        Me.Text = "展期项目一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FQueryProjectExpandDate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isLoad = True
        Me.dateStart.Enabled = False
        Me.dateEnd.Enabled = False
        'bindingCorporationName()
        bindingServiceType()
        bindingManager()
        bindingBank()
        MyBase.Clear()
        MyBase.ReportFile = Application.StartupPath & "\Reports\QueryLoanProject.rpt"
        MyBase.ReportTitle = "展期项目一览表"
    End Sub

    Private Sub chbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbDate.CheckedChanged
        If Not Me.chbDate.Checked Then
            Me.dateStart.Enabled = False
            Me.dateEnd.Enabled = False
        Else
            Me.dateStart.Enabled = True
            Me.dateEnd.Enabled = True
        End If
    End Sub
    '获得查询条件
    Private Overloads Sub GetCondition(ByRef projectCode As String, ByRef corporationName As String, _
            ByRef dateStart As Object, ByRef dateEnd As Object, _
            ByRef managerA As String, ByRef serviceType As String, _
            ByRef bank As String, ByRef branch As String)
        projectCode = Me.txtProjectCode.Text.Trim()
        corporationName = Me.txtCorpName.Text.Trim()
        dateStart = IIf(Me.chbDate.Checked, Me.dateStart.Value.Date, Nothing)
        dateEnd = IIf(Me.chbDate.Checked, Me.dateEnd.Value.Date, Nothing)
        determineDate(dateStart, dateEnd)
        managerA = Me.cmbManagerA.Text.Trim()
        serviceType = Me.cmbServiceType.Text.Trim()
        bank = Me.cmbBank.Text.Trim()
        branch = Me.cmbBranch.Text.Trim()
    End Sub
    '查询
    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim projectCode, corporationName, managerA, serviceType, bank, branch As String
        Dim dateStart, dateEnd As Object
        Dim i As Integer
        Dim iTotalSum As Decimal
        Dim dtResult As DataTable
        Dim recordCount As Integer

        GetCondition(projectCode, corporationName, dateStart, dateEnd, managerA, serviceType, bank, branch)
        dtResult = gWs.FQueryProjectExpandDate(projectCode, corporationName, serviceType, dateStart, dateEnd, managerA, bank, branch, UserName).Tables(0)

        For i = 0 To dtResult.Rows.Count - 1
            If Not IsDBNull(dtResult.Rows(i).Item("sum")) Then
                iTotalSum = iTotalSum + CDec(dtResult.Rows(i).Item("sum"))
            End If
        Next
        Dim drRow As DataRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "合计："
            .Item("sum") = iTotalSum
        End With
        dtResult.Rows.Add(drRow)

        drRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "单数：" & i
        End With
        dtResult.Rows.Add(drRow)

        If Not dtResult Is Nothing Then
            MyBase.DataSource = dtResult
            Me.grdTable.DataSource = dtResult
            'recordCount = dsResult.Tables(0).Rows.Count
            Me.Text = "展期项目一览表" '& "(" & recordCount & ")"
        End If
    End Sub
    '绑定企业名称
    'Private Sub bindingCorporationName()
    '    Dim ds As DataSet
    '    Dim strSql As String
    '    strSql = "%"
    '    Try
    '        ds = gWs.GetcorporationInfo(strSql, "null")
    '        If Not ds Is Nothing Then
    '            Me.cmbCorporationName.DataSource = ds.Tables("corporation")
    '            Me.cmbCorporationName.DisplayMember = "corporation_name"
    '        End If
    '    Catch ex As Exception
    '    End Try
    'End Sub
    '绑定业务品种
    Private Sub bindingServiceType()
        Dim ds As DataSet
        Dim strSql As String
        strSql = "%"
        Try
            ds = gWs.GetServiceType(strSql)
            If Not ds Is Nothing Then
                Me.cmbServiceType.DataSource = ds.Tables(0)
                Me.cmbServiceType.DisplayMember = "service_type"
            End If
        Catch
        End Try
    End Sub
    '绑定项目经理
    Private Sub bindingManager()
        Dim ds As DataSet
        Dim strSql As String
        strSql = "{not team_name is null}"
        Try
            ds = gWs.GetStaff(strSql)
            If Not ds Is Nothing Then
                Me.cmbManagerA.DataSource = ds.Tables(0)
                Me.cmbManagerA.DisplayMember = "staff_name"
            End If
        Catch
        End Try
    End Sub
    '绑定银行
    Private Sub bindingBank()
        '''''''''''''贷款银行 贷款支行'''''''''''''''
        'dsBank = gWs.GetBankInfo("{0=0 order by bank_name}", "%")
        'qxd modify 2005-10-21 通过存储实现了按名称升序排序
        dsBank = gWs.GetBankInfo("%", "%")
        cmbBank.DataSource = dsBank.Tables("bank")
        cmbBank.DisplayMember = "bank_name"
        cmbBank.ValueMember = "bank_code"
        cmbBranch.DataSource = dsBank.Tables("bank_branch").DefaultView
        cmbBranch.DisplayMember = "branch_bank_name"
        cmbBranch.ValueMember = "branch_bank_name"
    End Sub

    Private Sub BankChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cmbBank.SelectedValueChanged
        If Me.cmbBranch.DataSource Is Nothing Then Return
        dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code LIKE '" & cmbBank.SelectedValue & "'"
        dsBank.Tables("bank_branch").DefaultView.Sort = "branch_bank_name"
    End Sub
    '绑定支行
    'Private Sub bindingBranch()
    '    Dim ds As DataSet
    '    Dim strSql As String
    '    Me.cmbBranch.DataSource = Nothing
    '    Me.cmbBranch.Items.Clear()
    '    strSql = "{bank_code='" & Me.cmbBank.SelectedValue & "' order by branch_bank_name}"
    '    Try
    '        ds = gWs.GetBankInfo("null", strSql)
    '        If Not ds Is Nothing Then
    '            If ds.Tables("bank_branch").Rows.Count > 0 Then
    '                Me.cmbBranch.DataSource = ds.Tables("bank_branch")
    '                Me.cmbBranch.DisplayMember = "branch_bank_name"
    '            Else
    '                Me.cmbBranch.Text = ""
    '            End If
    '        End If
    '    Catch
    '    End Try
    'End Sub

    'Private Sub cmbBank_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBank.SelectedValueChanged
    '    flag = False
    '    If isLoad Then
    '        count = count + 1
    '    End If
    '    If nCurrentCount < count Then
    '    Else
    '        bindingBranch()
    '        flag = True
    '    End If
    '    nCurrentCount = nCurrentCount + 1
    'End Sub

    Private Sub cmbBank_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBank.DropDown
        isLoad = False
    End Sub

    Private Sub cmbBank_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbBank.Enter
        isLoad = False
    End Sub
    '判断起始和截止日期
    Private Sub determineDate(ByVal dateStart As Date, ByVal dateEnd As Date)
        If dateStart.Date > dateEnd.Date Then
            'MsgBox("截止日期必须大于或等于起始日期", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1008", "起始日期", "截止日期")
            Me.dateEnd.Value = Me.dateStart.Value
        End If
    End Sub
End Class
