

'合作区项目管理一览表
Public Class FQueryRegionProject
    Inherits FQueryBase

    Protected Overloads Sub GetCondition(ByRef ServiceType As String, ByRef Area As String, ByRef phase As String)
        ServiceType = cboServiceType.Text.Trim
        Area = cboArea.Text.Trim
        phase = cboPhase.Text.Trim
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal Condition As String)
        Dim StartDate, EndDate As Object
        StartDate = IIf(chkDate.Checked, dtpStartDate.Value.Date, Nothing)
        EndDate = IIf(chkDate.Checked, dtpEndDate.Value.Date, Nothing)
        If chkDate.Checked AndAlso DateTime.Parse(StartDate).Date > DateTime.Parse(EndDate).Date Then
            SWDialogBox.MessageBox.Show("$1008", "起始日期", "截止日期")
            'MessageBox.Show("截止日期应大于起始日期", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpEndDate.Value = dtpStartDate.Value.Date
            Return
        End If
        Dim ServiceType, Area, Phase As String
        GetCondition(ServiceType, Area, Phase)
        Dim ds As DataSet = gWs.FQueryRegionProject("", "", ServiceType, StartDate, EndDate, Area, Phase)
        ds.Tables(0).TableName = "TQueryRegionProject"
        grdTable.DataMember = "TQueryRegionProject"
        grdTable.DataSource = ds
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        dtpEndDate.Enabled = chkDate.Checked
        dtpStartDate.Enabled = chkDate.Checked
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ReportFile = Application.StartupPath & ".\Reports\QueryRegionProject.rpt"
        ReportTitle = "合作区项目管理一览表"
        '''''''''''''业务品种''''''''''''''''
        Dim dsST As DataSet = gWs.GetServiceType("%")
        cboServiceType.DataSource = dsST.Tables(0)
        cboServiceType.DisplayMember = "service_type"
        cboServiceType.ValueMember = "service_type"
        '''''''''''''所属区域''''''''''''''''''
        Dim dsArea As DataSet = gWs.GetCooperateOrganization("%")
        cboArea.DataSource = dsArea.Tables(0)
        cboArea.DisplayMember = "cooperate_organization"
        cboArea.ValueMember = "cooperate_organization"
        '''''''''''''阶段''''''''''''
        Dim dsPhase As DataSet = gWs.GetPhase("%")
        cboPhase.DataSource = dsPhase.Tables(0)
        cboPhase.DisplayMember = "phase_name"
        cboPhase.ValueMember = "phase_name"
        AddTableStyle()
        Clear()
    End Sub

    Private Sub AddTableStyle()
        grdTable.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "TQueryRegionProject"
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "project_code"
        col1.HeaderText = "项目编号"
        col1.Width = 65
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.MappingName = "enterprise_name"
        col2.HeaderText = "企业名称"
        col2.Width = 140
        col2.NullText = ""
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.MappingName = "cooperate_organization"
        col3.HeaderText = "合作区"
        col3.Width = 90
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.MappingName = "create_date"
        col4.HeaderText = "申请日期"
        col4.Format = "yyyy-MM-dd"
        col4.Width = 70
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "recommend_sum"
        col5.HeaderText = "推荐金额(万元)"
        col5.Format = "c" : col5.FormatInfo = CGFormatInfo
        col5.Width = 90
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col6.MappingName = "service_type"
        col6.HeaderText = "业务品种"
        col6.Width = 90
        col6.NullText = ""
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col7.MappingName = "team"
        col7.HeaderText = "项目组"
        col7.Width = 80
        col7.NullText = ""
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col8.MappingName = "manager_a"
        col8.HeaderText = "项目经理A角"
        col8.NullText = ""
        col8.Width = 70
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col9.MappingName = "manager_b"
        col9.HeaderText = "项目经理B角"
        col9.NullText = ""
        col9.Width = 70
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col10.MappingName = "phase"
        col10.HeaderText = "项目阶段"
        col10.NullText = ""
        col10.Width = 65
        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col11.MappingName = "status"
        col11.HeaderText = "项目状态"
        col11.NullText = ""
        col11.Width = 65
        Dim col12 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col12.MappingName = "loan_money"
        col12.HeaderText = "放款金额(万元)"
        col12.Width = 100
        col12.Format = "c" : col12.FormatInfo = CGFormatInfo
        col12.NullText = ""
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12})
        grdTable.TableStyles.Add(dgts)
    End Sub
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
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboArea As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboPhase As System.Windows.Forms.ComboBox
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboPhase = New System.Windows.Forms.ComboBox()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label5, Me.Label3, Me.dtpEndDate, Me.chkDate, Me.cboPhase, Me.Label4, Me.dtpStartDate, Me.cboArea, Me.Label2, Me.Label1, Me.cboServiceType})
        Me.grpCondition.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(607, 112)
        Me.btnExit.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(506, 112)
        Me.btnPrint.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(405, 112)
        Me.btnExport.Visible = True
        '
        'cboServiceType
        '
        Me.cboServiceType.Location = New System.Drawing.Point(96, 20)
        Me.cboServiceType.MaxLength = 20
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(208, 20)
        Me.cboServiceType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "业务品种"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(312, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "合作区"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboArea
        '
        Me.cboArea.Location = New System.Drawing.Point(384, 20)
        Me.cboArea.MaxLength = 20
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(168, 20)
        Me.cboArea.TabIndex = 3
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Location = New System.Drawing.Point(96, 56)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpStartDate.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(472, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "项目阶段"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPhase
        '
        Me.cboPhase.Location = New System.Drawing.Point(544, 56)
        Me.cboPhase.MaxLength = 4
        Me.cboPhase.Name = "cboPhase"
        Me.cboPhase.Size = New System.Drawing.Size(121, 20)
        Me.cboPhase.TabIndex = 7
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(16, 56)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(16, 20)
        Me.chkDate.TabIndex = 8
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Location = New System.Drawing.Point(312, 56)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpEndDate.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "起始日期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(248, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "截止日期"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FQueryRegionProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryRegionProject"
        Me.Text = "合作区项目管理一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class
