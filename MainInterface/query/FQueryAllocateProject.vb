

Public Class FQueryAllocateProject
    Inherits MainInterface.FQueryBase

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents cmbServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents chbDate As System.Windows.Forms.CheckBox
    Friend WithEvents cmbManagerB As System.Windows.Forms.ComboBox
    Friend WithEvents cmbManagerA As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents project_code As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents enterprise_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents apply_service_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents apply_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_a As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_b As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents finish_time As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents branch_name As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryAllocateProject))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.cmbServiceType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dateStart = New System.Windows.Forms.DateTimePicker()
        Me.dateEnd = New System.Windows.Forms.DateTimePicker()
        Me.chbDate = New System.Windows.Forms.CheckBox()
        Me.cmbManagerB = New System.Windows.Forms.ComboBox()
        Me.cmbManagerA = New System.Windows.Forms.ComboBox()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.project_code = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.enterprise_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.apply_service_type = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.apply_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.manager_a = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.manager_b = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.finish_time = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.branch_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCorpName, Me.cmbManagerA, Me.cmbManagerB, Me.chbDate, Me.dateEnd, Me.dateStart, Me.Label7, Me.Label6, Me.Label5, Me.cmbServiceType, Me.txtProjectCode, Me.Label3, Me.Label2, Me.Label1})
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
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(232, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(432, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "业务品种"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 24)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectCode.TabIndex = 0
        Me.txtProjectCode.Text = ""
        '
        'cmbServiceType
        '
        Me.cmbServiceType.Location = New System.Drawing.Point(488, 24)
        Me.cmbServiceType.Name = "cmbServiceType"
        Me.cmbServiceType.Size = New System.Drawing.Size(121, 20)
        Me.cmbServiceType.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(264, 71)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "到"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "项目经理A"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(224, 47)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 23)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "项目经理B"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dateStart
        '
        Me.dateStart.Location = New System.Drawing.Point(80, 72)
        Me.dateStart.Name = "dateStart"
        Me.dateStart.Size = New System.Drawing.Size(120, 21)
        Me.dateStart.TabIndex = 2
        '
        'dateEnd
        '
        Me.dateEnd.Location = New System.Drawing.Point(288, 72)
        Me.dateEnd.Name = "dateEnd"
        Me.dateEnd.Size = New System.Drawing.Size(120, 21)
        Me.dateEnd.TabIndex = 3
        '
        'chbDate
        '
        Me.chbDate.Location = New System.Drawing.Point(4, 70)
        Me.chbDate.Name = "chbDate"
        Me.chbDate.Size = New System.Drawing.Size(76, 24)
        Me.chbDate.TabIndex = 14
        Me.chbDate.Text = "分配日期"
        '
        'cmbManagerB
        '
        Me.cmbManagerB.Location = New System.Drawing.Point(288, 48)
        Me.cmbManagerB.Name = "cmbManagerB"
        Me.cmbManagerB.Size = New System.Drawing.Size(121, 20)
        Me.cmbManagerB.TabIndex = 6
        '
        'cmbManagerA
        '
        Me.cmbManagerA.Location = New System.Drawing.Point(80, 48)
        Me.cmbManagerA.Name = "cmbManagerA"
        Me.cmbManagerA.Size = New System.Drawing.Size(121, 20)
        Me.cmbManagerA.TabIndex = 5
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.project_code, Me.enterprise_name, Me.apply_service_type, Me.apply_sum, Me.manager_a, Me.manager_b, Me.finish_time, Me.status, Me.branch_name})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
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
        Me.enterprise_name.Width = 200
        '
        'apply_service_type
        '
        Me.apply_service_type.Format = ""
        Me.apply_service_type.FormatInfo = Nothing
        Me.apply_service_type.HeaderText = "业务品种"
        Me.apply_service_type.MappingName = "apply_service_type"
        Me.apply_service_type.NullText = ""
        Me.apply_service_type.Width = 150
        '
        'apply_sum
        '
        Me.apply_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.apply_sum.Format = ""
        Me.apply_sum.FormatInfo = Nothing
        Me.apply_sum.HeaderText = "申请金额(万元)"
        Me.apply_sum.MappingName = "apply_sum"
        Me.apply_sum.NullText = ""
        Me.apply_sum.Width = 75
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
        'finish_time
        '
        Me.finish_time.Format = "yyyy-MM-dd"
        Me.finish_time.FormatInfo = Nothing
        Me.finish_time.HeaderText = "分配日期"
        Me.finish_time.MappingName = "finish_time"
        Me.finish_time.NullText = ""
        Me.finish_time.Width = 75
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
        Me.txtCorpName.Location = New System.Drawing.Point(288, 24)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(120, 21)
        Me.txtCorpName.TabIndex = 15
        Me.txtCorpName.Text = ""
        '
        'FQueryAllocateProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 501)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryAllocateProject"
        Me.Text = "项目分配一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FQueryAllocateProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dateStart.Enabled = False
        Me.dateEnd.Enabled = False
        'bindingCorporationName()
        bindingServiceType()
        bindingManager()
        bindingManager_B()
        MyBase.Clear()
        MyBase.ReportFile = Application.StartupPath & "\Reports\QueryAllocateProject.rpt"
        MyBase.ReportTitle = "项目分配一览表"
    End Sub
    '获得查询条件
    Private Overloads Sub GetCondition(ByRef projectCode As String, ByRef corporationName As String, _
            ByRef dateStart As Object, ByRef dateEnd As Object, _
            ByRef managerA As String, ByRef managerB As String, _
            ByRef serviceType As String)
        projectCode = Me.txtProjectCode.Text.Trim()
        corporationName = Me.txtCorpName.Text.Trim()
        dateStart = IIf(Me.chbDate.Checked, Me.dateStart.Value, Nothing)
        dateEnd = IIf(Me.chbDate.Checked, Me.dateEnd.Value, Nothing)
        If Me.chbDate.Checked Then
            determineDate(dateStart, dateEnd)
        End If
        managerA = Me.cmbManagerA.Text.Trim()
        managerB = Me.cmbManagerB.Text.Trim()
        serviceType = Me.cmbServiceType.Text.Trim()
    End Sub
    '查询
    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim projectCode, corporationName, managerA, managerB, serviceType As String
        Dim dateStart, dateEnd As Object
        Dim i As Integer
        Dim iTotalSum As Decimal
        Dim dtResult As DataTable
        Dim recordCount As Integer

        GetCondition(projectCode, corporationName, dateStart, dateEnd, managerA, managerB, serviceType)
        dtResult = gWs.FQueryAllocateProject(projectCode, corporationName, serviceType, dateStart, dateEnd, managerA, managerB, UserName).Tables(0)

        For i = 0 To dtResult.Rows.Count - 1
            If Not dtResult.Rows(i).Item("apply_sum") Is System.DBNull.Value Then
                iTotalSum = iTotalSum + CDec(dtResult.Rows(i).Item("apply_sum"))
            End If
        Next
        Dim drRow As DataRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "合计："
            .Item("apply_sum") = iTotalSum
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
            Me.Text = "项目分配一览表" '& "(" & recordCount & ")"
        End If
    End Sub

    '设置日期是否作为查询条件
    Private Sub chbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbDate.CheckedChanged
        If Not Me.chbDate.Checked Then
            Me.dateStart.Enabled = False
            Me.dateEnd.Enabled = False
        Else
            Me.dateStart.Enabled = True
            Me.dateEnd.Enabled = True
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
    Private Sub bindingManager_B()
        Dim ds As DataSet
        Dim strSql As String
        strSql = "{not team_name is null}"
        Try
            ds = gWs.GetStaff(strSql)
            If Not ds Is Nothing Then
                Me.cmbManagerB.DataSource = ds.Tables(0)
                Me.cmbManagerB.DisplayMember = "staff_name"
            End If
        Catch
        End Try
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
