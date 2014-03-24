

Public Class FQueryRecantProject
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
    Friend WithEvents dateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBank As System.Windows.Forms.ComboBox
    Friend WithEvents cmbServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents chbDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbManagerA As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents project_code As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents enterprise_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents service_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_a As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_b As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents guarantee_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents start_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents end_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents refund_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents bank As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents branch_bank As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents branch_name As System.Windows.Forms.DataGridTextBoxColumn
    '2005-1-4 by 9sky
    Friend WithEvents status As MainInterface.DataGridColoredTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryRecantProject))
        Me.dateEnd = New System.Windows.Forms.DateTimePicker()
        Me.dateStart = New System.Windows.Forms.DateTimePicker()
        Me.cmbBranch = New System.Windows.Forms.ComboBox()
        Me.cmbBank = New System.Windows.Forms.ComboBox()
        Me.cmbServiceType = New System.Windows.Forms.ComboBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.chbDate = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbManagerA = New System.Windows.Forms.ComboBox()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.project_code = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.enterprise_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.service_type = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.manager_a = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.manager_b = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.guarantee_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.start_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.end_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.refund_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.bank = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.branch_bank = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.branch_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.status = New MainInterface.DataGridColoredTextBoxColumn()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCorpName, Me.cmbManagerA, Me.dateEnd, Me.dateStart, Me.cmbBranch, Me.cmbBank, Me.cmbServiceType, Me.txtProjectCode, Me.chbDate, Me.Label8, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
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
        Me.btnPrint.Location = New System.Drawing.Point(520, 184)
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
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
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
        'dateEnd
        '
        Me.dateEnd.Location = New System.Drawing.Point(280, 72)
        Me.dateEnd.Name = "dateEnd"
        Me.dateEnd.Size = New System.Drawing.Size(120, 21)
        Me.dateEnd.TabIndex = 7
        '
        'dateStart
        '
        Me.dateStart.Location = New System.Drawing.Point(80, 72)
        Me.dateStart.Name = "dateStart"
        Me.dateStart.Size = New System.Drawing.Size(120, 21)
        Me.dateStart.TabIndex = 6
        '
        'cmbBranch
        '
        Me.cmbBranch.Location = New System.Drawing.Point(480, 48)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(136, 20)
        Me.cmbBranch.TabIndex = 5
        '
        'cmbBank
        '
        Me.cmbBank.Location = New System.Drawing.Point(280, 48)
        Me.cmbBank.Name = "cmbBank"
        Me.cmbBank.Size = New System.Drawing.Size(120, 20)
        Me.cmbBank.TabIndex = 4
        '
        'cmbServiceType
        '
        Me.cmbServiceType.Location = New System.Drawing.Point(480, 24)
        Me.cmbServiceType.Name = "cmbServiceType"
        Me.cmbServiceType.Size = New System.Drawing.Size(136, 20)
        Me.cmbServiceType.TabIndex = 3
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 24)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectCode.TabIndex = 0
        Me.txtProjectCode.Text = ""
        '
        'chbDate
        '
        Me.chbDate.Location = New System.Drawing.Point(8, 70)
        Me.chbDate.Name = "chbDate"
        Me.chbDate.Size = New System.Drawing.Size(80, 24)
        Me.chbDate.TabIndex = 25
        Me.chbDate.Text = "撤保日期"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(256, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 23)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "到"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(424, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 23)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "贷款支行"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(224, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "贷款银行"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(424, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "业务品种"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "项目经理A"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(224, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbManagerA
        '
        Me.cmbManagerA.Location = New System.Drawing.Point(80, 48)
        Me.cmbManagerA.Name = "cmbManagerA"
        Me.cmbManagerA.Size = New System.Drawing.Size(121, 20)
        Me.cmbManagerA.TabIndex = 2
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.project_code, Me.enterprise_name, Me.service_type, Me.manager_a, Me.manager_b, Me.guarantee_sum, Me.start_date, Me.end_date, Me.refund_date, Me.bank, Me.branch_bank, Me.branch_name, Me.status})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'project_code
        '
        Me.project_code.Format = ""
        Me.project_code.FormatInfo = Nothing
        Me.project_code.HeaderText = "项目编号"
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
        Me.service_type.Width = 110
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
        'guarantee_sum
        '
        Me.guarantee_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.guarantee_sum.Format = ""
        Me.guarantee_sum.FormatInfo = Nothing
        Me.guarantee_sum.HeaderText = "担保金额"
        Me.guarantee_sum.MappingName = "guarantee_sum"
        Me.guarantee_sum.NullText = ""
        Me.guarantee_sum.Width = 85
        '
        'start_date
        '
        Me.start_date.Format = "yyyy-MM-dd"
        Me.start_date.FormatInfo = Nothing
        Me.start_date.HeaderText = "承保期起"
        Me.start_date.MappingName = "start_date"
        Me.start_date.NullText = ""
        Me.start_date.Width = 80
        '
        'end_date
        '
        Me.end_date.Format = "yyyy-MM-dd"
        Me.end_date.FormatInfo = Nothing
        Me.end_date.HeaderText = "承保期止"
        Me.end_date.MappingName = "end_date"
        Me.end_date.NullText = ""
        Me.end_date.Width = 80
        '
        'refund_date
        '
        Me.refund_date.Format = "yyyy-MM-dd"
        Me.refund_date.FormatInfo = Nothing
        Me.refund_date.HeaderText = "撤保日期"
        Me.refund_date.MappingName = "refund_date"
        Me.refund_date.NullText = ""
        Me.refund_date.Width = 80
        '
        'bank
        '
        Me.bank.Format = ""
        Me.bank.FormatInfo = Nothing
        Me.bank.HeaderText = "贷款银行"
        Me.bank.MappingName = "bank"
        Me.bank.NullText = ""
        Me.bank.Width = 200
        '
        'branch_bank
        '
        Me.branch_bank.Format = ""
        Me.branch_bank.FormatInfo = Nothing
        Me.branch_bank.HeaderText = "贷款支行"
        Me.branch_bank.MappingName = "branch_bank"
        Me.branch_bank.NullText = ""
        Me.branch_bank.Width = 150
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
        'status
        '
        Me.status.Format = ""
        Me.status.FormatInfo = Nothing
        Me.status.HeaderText = "项目状态"
        Me.status.MappingName = "status"
        Me.status.NullText = ""
        Me.status.Width = 75
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(280, 24)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(120, 21)
        Me.txtCorpName.TabIndex = 26
        Me.txtCorpName.Text = ""
        '
        'FQueryRecantProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 501)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryRecantProject"
        Me.Text = "撤保项目一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FQueryRecantProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isLoad = True
        Me.dateStart.Enabled = False
        Me.dateEnd.Enabled = False
        'bindingCorporationName()
        bindingServiceType()
        bindingManager()
        bindingBank()
        MyBase.Clear()
        MyBase.ReportFile = Application.StartupPath & "\Reports\QueryRecantProject.rpt"
        MyBase.ReportTitle = "撤保项目一览表"
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
            ByRef dateStart As object, ByRef dateEnd As object, _
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
        'Dim dsResult As DataSet
        Dim recordCount As Integer
        Dim i As Integer
        Dim iTotalSum As Decimal
        Dim dtResult As DataTable

        GetCondition(projectCode, corporationName, dateStart, dateEnd, managerA, serviceType, bank, branch)
        Try
            dtResult = gWs.FQueryRecantProject(projectCode, corporationName, serviceType, dateStart, dateEnd, managerA, bank, branch, UserName).Tables(0)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        For i = 0 To dtResult.Rows.Count - 1
            If Not dtResult.Rows(i).Item("guarantee_sum") Is System.DBNull.Value Then
                iTotalSum = iTotalSum + CDec(dtResult.Rows(i).Item("guarantee_sum"))
            End If
        Next
        Dim drRow As DataRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "合计："
            .Item("guarantee_sum") = iTotalSum
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
            Me.Text = "撤保项目一览表" ' & "(" & recordCount & ")"
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
