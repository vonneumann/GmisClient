

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
    Friend WithEvents cmbCorporationName As System.Windows.Forms.ComboBox
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents chbDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbManagerA As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.dateEnd = New System.Windows.Forms.DateTimePicker()
        Me.dateStart = New System.Windows.Forms.DateTimePicker()
        Me.cmbServiceType = New System.Windows.Forms.ComboBox()
        Me.cmbCorporationName = New System.Windows.Forms.ComboBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.chbDate = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.cmbManagerA = New System.Windows.Forms.ComboBox()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 224)
        Me.grdTable.Size = New System.Drawing.Size(696, 272)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.grdTable.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(328, 184)
        Me.btnRefresh.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(520, 184)
        Me.btnPrint.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(424, 184)
        Me.btnExport.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 184)
        Me.chkVisible.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(616, 184)
        Me.btnExit.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 184)
        Me.btnClear.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbManagerA, Me.cmbType, Me.Label5, Me.dateEnd, Me.dateStart, Me.cmbServiceType, Me.cmbCorporationName, Me.txtProjectCode, Me.chbDate, Me.Label8, Me.Label7, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.grpCondition.Size = New System.Drawing.Size(696, 160)
        Me.grpCondition.Visible = True
        '
        'dateEnd
        '
        Me.dateEnd.Location = New System.Drawing.Point(388, 88)
        Me.dateEnd.Name = "dateEnd"
        Me.dateEnd.Size = New System.Drawing.Size(112, 21)
        Me.dateEnd.TabIndex = 5
        '
        'dateStart
        '
        Me.dateStart.Location = New System.Drawing.Point(132, 88)
        Me.dateStart.Name = "dateStart"
        Me.dateStart.Size = New System.Drawing.Size(120, 21)
        Me.dateStart.TabIndex = 4
        '
        'cmbServiceType
        '
        Me.cmbServiceType.Location = New System.Drawing.Point(388, 55)
        Me.cmbServiceType.Name = "cmbServiceType"
        Me.cmbServiceType.Size = New System.Drawing.Size(240, 20)
        Me.cmbServiceType.TabIndex = 3
        '
        'cmbCorporationName
        '
        Me.cmbCorporationName.Location = New System.Drawing.Point(388, 22)
        Me.cmbCorporationName.Name = "cmbCorporationName"
        Me.cmbCorporationName.Size = New System.Drawing.Size(288, 20)
        Me.cmbCorporationName.TabIndex = 1
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(132, 22)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectCode.TabIndex = 0
        Me.txtProjectCode.Text = ""
        '
        'chbDate
        '
        Me.chbDate.Location = New System.Drawing.Point(20, 86)
        Me.chbDate.Name = "chbDate"
        Me.chbDate.Size = New System.Drawing.Size(16, 24)
        Me.chbDate.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(292, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 23)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "到"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(36, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 23)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "放款日期"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(292, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "业务品种"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(36, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "项目经理A"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(292, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(36, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(36, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "类型"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbType
        '
        Me.cmbType.Location = New System.Drawing.Point(132, 121)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 20)
        Me.cmbType.TabIndex = 6
        '
        'cmbManagerA
        '
        Me.cmbManagerA.Location = New System.Drawing.Point(132, 55)
        Me.cmbManagerA.Name = "cmbManagerA"
        Me.cmbManagerA.Size = New System.Drawing.Size(121, 20)
        Me.cmbManagerA.TabIndex = 2
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "项目编号"
        Me.DataGridTextBoxColumn1.MappingName = "project_code"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "企业名称"
        Me.DataGridTextBoxColumn2.MappingName = "enterprise_name"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "业务品种"
        Me.DataGridTextBoxColumn3.MappingName = "service_type"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "放款时间"
        Me.DataGridTextBoxColumn4.MappingName = "start_date"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "放款金额"
        Me.DataGridTextBoxColumn5.MappingName = "sum"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "摘要"
        Me.DataGridTextBoxColumn6.MappingName = "remark"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 150
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "类型"
        Me.DataGridTextBoxColumn7.MappingName = "item_name"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "金额"
        Me.DataGridTextBoxColumn8.MappingName = "income"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 75
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
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "项目经理A角"
        Me.DataGridTextBoxColumn9.MappingName = "manager_a"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "收费方式"
        Me.DataGridTextBoxColumn11.MappingName = "type"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 75
        '
        'FQueryChargeStatistics
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 501)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryChargeStatistics"
        Me.Text = "项目收费查询"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub FQueryChargeStatistics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dateStart.Enabled = False
        Me.dateEnd.Enabled = False
        bindingCorporationName()
        bindingServiceType()
        bindingType()
        bindingManager()
        MyBase.Clear()
        MyBase.ReportFile = Application.StartupPath & "\Reports\QueryChargeStatistics.rpt"
        MyBase.ReportTitle = "项目收费查询"
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
        corporationName = Me.cmbCorporationName.Text.Trim()
        dateStart = IIf(Me.chbDate.Checked, Me.dateStart.Value, Nothing)
        dateEnd = IIf(Me.chbDate.Checked, Me.dateEnd.Value, Nothing)
        determineDate(dateStart, dateEnd)
        managerA = Me.cmbManagerA.Text.Trim()
        serviceType = Me.cmbServiceType.Text.Trim()
        type = Me.cmbType.Text.Trim()
    End Sub
    '查询
    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim projectCode, corporationName, managerA, serviceType, type As String
        Dim dateStart, dateEnd As Object
        Dim dsResult As DataSet
        Dim recordCount As Integer
        GetCondition(projectCode, corporationName, dateStart, dateEnd, managerA, serviceType, type)
        dsResult = gWs.FQueryChargeStatistics(projectCode, corporationName, serviceType, dateStart, dateEnd, managerA, type)
        If Not dsResult Is Nothing Then
            MyBase.DataSource = dsResult.Tables(0)
            Me.grdTable.DataSource = dsResult.Tables(0)
            recordCount = dsResult.Tables(0).Rows.Count
            Me.Text = "项目收费查询" & "(" & recordCount & ")"
        End If
    End Sub
    '绑定企业名称
    Private Sub bindingCorporationName()
        Dim ds As DataSet
        Dim strSql As String
        strSql = "%"
        Try
            ds = gWs.GetcorporationInfo(strSql, "null")
            If Not ds Is Nothing Then
                Me.cmbCorporationName.DataSource = ds.Tables("corporation")
                Me.cmbCorporationName.DisplayMember = "corporation_name"
            End If
        Catch ex As Exception
        End Try
    End Sub
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
End Class
