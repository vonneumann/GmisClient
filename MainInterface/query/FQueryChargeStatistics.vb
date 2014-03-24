

Public Class FQueryChargeStatistics
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
    Friend WithEvents dateEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents chbDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbManagerA As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents project_code As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents enterprise_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents service_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents item_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents income As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents remark As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_a As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents applysum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents guaranteesum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents sign_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents branch_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents status As DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryChargeStatistics))
        Me.dateEnd = New System.Windows.Forms.DateTimePicker()
        Me.dateStart = New System.Windows.Forms.DateTimePicker()
        Me.cmbServiceType = New System.Windows.Forms.ComboBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.chbDate = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.cmbManagerA = New System.Windows.Forms.ComboBox()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.project_code = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.enterprise_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.service_type = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.manager_a = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.income = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.item_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.applysum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.guaranteesum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.sign_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.type = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.remark = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.branch_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCorpName, Me.cmbManagerA, Me.cmbType, Me.Label5, Me.dateEnd, Me.dateStart, Me.cmbServiceType, Me.txtProjectCode, Me.chbDate, Me.Label8, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
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
        Me.dateEnd.Size = New System.Drawing.Size(112, 21)
        Me.dateEnd.TabIndex = 5
        '
        'dateStart
        '
        Me.dateStart.Location = New System.Drawing.Point(80, 72)
        Me.dateStart.Name = "dateStart"
        Me.dateStart.Size = New System.Drawing.Size(120, 21)
        Me.dateStart.TabIndex = 4
        '
        'cmbServiceType
        '
        Me.cmbServiceType.Location = New System.Drawing.Point(280, 48)
        Me.cmbServiceType.Name = "cmbServiceType"
        Me.cmbServiceType.Size = New System.Drawing.Size(112, 20)
        Me.cmbServiceType.TabIndex = 3
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 22)
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
        Me.chbDate.Text = "收取日期"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(256, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 23)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "到"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(224, 47)
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
        Me.Label2.Location = New System.Drawing.Point(224, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(416, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "类型"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbType
        '
        Me.cmbType.Location = New System.Drawing.Point(448, 22)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 20)
        Me.cmbType.TabIndex = 6
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
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.project_code, Me.enterprise_name, Me.service_type, Me.manager_a, Me.DataGridTextBoxColumn10, Me.income, Me.item_name, Me.applysum, Me.guaranteesum, Me.sign_sum, Me.type, Me.remark, Me.branch_name, Me.status})
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
        Me.service_type.Width = 80
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
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "收取日期"
        Me.DataGridTextBoxColumn10.MappingName = "date"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'income
        '
        Me.income.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.income.Format = "n"
        Me.income.FormatInfo = Nothing
        Me.income.HeaderText = "收取金额(元)"
        Me.income.MappingName = "income"
        Me.income.NullText = ""
        Me.income.Width = 120
        '
        'item_name
        '
        Me.item_name.Format = ""
        Me.item_name.FormatInfo = Nothing
        Me.item_name.HeaderText = "类型"
        Me.item_name.MappingName = "item_name"
        Me.item_name.NullText = ""
        Me.item_name.Width = 75
        '
        'applysum
        '
        Me.applysum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.applysum.Format = ""
        Me.applysum.FormatInfo = Nothing
        Me.applysum.HeaderText = "申请金额(万元)"
        Me.applysum.MappingName = "applysum"
        Me.applysum.NullText = ""
        Me.applysum.Width = 120
        '
        'guaranteesum
        '
        Me.guaranteesum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.guaranteesum.Format = ""
        Me.guaranteesum.FormatInfo = Nothing
        Me.guaranteesum.HeaderText = "评审会通过金额(万元)"
        Me.guaranteesum.MappingName = "guaranteesum"
        Me.guaranteesum.NullText = ""
        Me.guaranteesum.Width = 150
        '
        'sign_sum
        '
        Me.sign_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.sign_sum.Format = ""
        Me.sign_sum.FormatInfo = Nothing
        Me.sign_sum.HeaderText = "签约金额(万元)"
        Me.sign_sum.MappingName = "sign_sum"
        Me.sign_sum.NullText = ""
        Me.sign_sum.Width = 120
        '
        'type
        '
        Me.type.Format = ""
        Me.type.FormatInfo = Nothing
        Me.type.HeaderText = "收费方式"
        Me.type.MappingName = "type"
        Me.type.NullText = ""
        Me.type.Width = 75
        '
        'remark
        '
        Me.remark.Format = ""
        Me.remark.FormatInfo = Nothing
        Me.remark.HeaderText = "摘要"
        Me.remark.MappingName = "remark"
        Me.remark.NullText = ""
        Me.remark.Width = 150
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
        Me.txtCorpName.Location = New System.Drawing.Point(280, 22)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(112, 21)
        Me.txtCorpName.TabIndex = 35
        Me.txtCorpName.Text = ""
        '
        'FQueryChargeStatistics
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 501)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnPrint, Me.btnExport, Me.btnClear, Me.grdTable, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryChargeStatistics"
        Me.Text = "项目收费一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub FQueryChargeStatistics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dateStart.Enabled = False
        Me.dateEnd.Enabled = False
        'bindingCorporationName()
        bindingServiceType()
        bindingType()
        bindingManager()
        MyBase.ReportFile = Application.StartupPath & "\Reports\QueryChargeStatistics.rpt"
        MyBase.ReportTitle = "项目收费一览表"
        MyBase.Clear()
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
            ByRef type As String)
        projectCode = Me.txtProjectCode.Text.Trim()
        corporationName = Me.txtCorpName.Text.Trim()
        dateStart = IIf(Me.chbDate.Checked, Me.dateStart.Value.Date, Nothing)
        dateEnd = IIf(Me.chbDate.Checked, Me.dateEnd.Value.Date, Nothing)
        determineDate(dateStart, dateEnd)
        managerA = Me.cmbManagerA.Text.Trim()
        serviceType = Me.cmbServiceType.Text.Trim()
        type = Me.cmbType.Text.Trim()
    End Sub
    '查询
    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim projectCode, corporationName, managerA, serviceType, type As String
        Dim dateStart, dateEnd As Object
        Dim i As Integer
        Dim iTotalSum As Decimal
        Dim dtResult As DataTable
        Dim recordCount As Integer
        GetCondition(projectCode, corporationName, dateStart, dateEnd, managerA, serviceType, type)
        dtResult = gWs.FQueryChargeStatistics(projectCode, corporationName, serviceType, dateStart, dateEnd, managerA, type, UserName).Tables(0)

        For i = 0 To dtResult.Rows.Count - 1
            If Not dtResult.Rows(i).Item("income") Is System.DBNull.Value Then
                iTotalSum = iTotalSum + CDec(dtResult.Rows(i).Item("income"))
            End If
        Next
        Dim drRow As DataRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "合计："
            .Item("income") = iTotalSum
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
            ' recordCount = dtResult.Rows.Count - 1
            Me.Text = "项目收费一览表" '& "(记录数：" & recordCount & ")"
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
    '绑定类型
    Private Sub bindingType()
        Dim ds As DataSet
        Dim strSql As String
        strSql = "{item_type='31'}"
        Try
            ds = gWs.GetItemEx(strSql)
            If Not ds Is Nothing Then
                Me.cmbType.DataSource = ds.Tables(0)
                Me.cmbType.DisplayMember = "item_name"
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

    Protected Overrides Sub Export()
        ReportToExcel.ToExcel(grdTable, "项目收费一览表", "项目收费一览表")
    End Sub

End Class
