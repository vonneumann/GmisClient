Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FQueryPauseProject
    Inherits FQueryBase

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
    Friend WithEvents cboPhase As System.Windows.Forms.ComboBox
    Friend WithEvents lblToDate As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtProjectNo As System.Windows.Forms.TextBox
    Friend WithEvents lblProjectNo As System.Windows.Forms.Label
    Friend WithEvents lblPhase As System.Windows.Forms.Label
    Friend WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Friend WithEvents lblCorporationName As System.Windows.Forms.Label
    Friend WithEvents txtCorporationNo As System.Windows.Forms.TextBox
    Friend WithEvents lblCorporationNo As System.Windows.Forms.Label
    Friend WithEvents cboPMA As System.Windows.Forms.ComboBox
    Friend WithEvents lblServiceType As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents project_code As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents corporation_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents service_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents apply_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents apply_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PMA As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents PMB As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents pause_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents branch_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents conference_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents intent_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents sign_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents trial_conclusion As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents first_review_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents status As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents project_phase As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents first_review_conclusion As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents bankopinion As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents signsum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents unCompletePause As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents trial_sum As System.Windows.Forms.DataGridTextBoxColumn

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryPauseProject))
        Me.chbDate = New System.Windows.Forms.CheckBox()
        Me.cboPhase = New System.Windows.Forms.ComboBox()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.txtProjectNo = New System.Windows.Forms.TextBox()
        Me.lblProjectNo = New System.Windows.Forms.Label()
        Me.lblPhase = New System.Windows.Forms.Label()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.txtCorporationNo = New System.Windows.Forms.TextBox()
        Me.lblCorporationNo = New System.Windows.Forms.Label()
        Me.cboPMA = New System.Windows.Forms.ComboBox()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.project_code = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.corporation_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.service_type = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.apply_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.apply_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.PMA = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.PMB = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.first_review_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.conference_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.trial_conclusion = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.intent_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.sign_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.pause_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.branch_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.trial_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.unCompletePause = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(656, 120)
        Me.btnExit.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageIndex = -1
        Me.btnRefresh.ImageList = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(480, 120)
        Me.btnRefresh.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Bitmap)
        Me.btnExport.ImageIndex = -1
        Me.btnExport.ImageList = Nothing
        Me.btnExport.Location = New System.Drawing.Point(568, 120)
        Me.btnExport.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.CaptionFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTable.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTable.HeaderFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTable.Location = New System.Drawing.Point(8, 152)
        Me.grdTable.Size = New System.Drawing.Size(752, 424)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.grdTable.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Bitmap)
        Me.btnClear.ImageIndex = -1
        Me.btnClear.ImageList = Nothing
        Me.btnClear.Location = New System.Drawing.Point(192, 120)
        Me.btnClear.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(568, 112)
        '
        'chkVisible
        '
        Me.chkVisible.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chkVisible.Location = New System.Drawing.Point(8, 120)
        Me.chkVisible.Visible = True
        '
        'ImageListQuery
        '
        Me.ImageListQuery.ImageStream = CType(resources.GetObject("ImageListQuery.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.chbDate, Me.cboServiceType, Me.cboPhase, Me.lblToDate, Me.lblProjectNo, Me.lblServiceType, Me.lblPhase, Me.lblCorporationName, Me.lblCorporationNo, Me.Label8, Me.dtpToDate, Me.dtpFromDate, Me.txtProjectNo, Me.txtCorporationName, Me.txtCorporationNo, Me.cboPMA})
        Me.grpCondition.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCondition.Size = New System.Drawing.Size(752, 104)
        Me.grpCondition.Visible = True
        '
        'chbDate
        '
        Me.chbDate.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.chbDate.Location = New System.Drawing.Point(14, 70)
        Me.chbDate.Name = "chbDate"
        Me.chbDate.Size = New System.Drawing.Size(80, 24)
        Me.chbDate.TabIndex = 143
        Me.chbDate.Text = "暂缓日期"
        '
        'cboPhase
        '
        Me.cboPhase.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cboPhase.Location = New System.Drawing.Point(96, 43)
        Me.cboPhase.Name = "cboPhase"
        Me.cboPhase.Size = New System.Drawing.Size(120, 20)
        Me.cboPhase.TabIndex = 134
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblToDate.Location = New System.Drawing.Point(277, 75)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(17, 14)
        Me.lblToDate.TabIndex = 141
        Me.lblToDate.Text = "到"
        '
        'dtpToDate
        '
        Me.dtpToDate.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dtpToDate.Location = New System.Drawing.Point(296, 71)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpToDate.TabIndex = 142
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CalendarFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.dtpFromDate.Location = New System.Drawing.Point(96, 71)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpFromDate.TabIndex = 140
        '
        'txtProjectNo
        '
        Me.txtProjectNo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtProjectNo.Location = New System.Drawing.Point(496, 16)
        Me.txtProjectNo.Name = "txtProjectNo"
        Me.txtProjectNo.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectNo.TabIndex = 138
        Me.txtProjectNo.Text = ""
        '
        'lblProjectNo
        '
        Me.lblProjectNo.AutoSize = True
        Me.lblProjectNo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblProjectNo.Location = New System.Drawing.Point(437, 19)
        Me.lblProjectNo.Name = "lblProjectNo"
        Me.lblProjectNo.Size = New System.Drawing.Size(54, 14)
        Me.lblProjectNo.TabIndex = 137
        Me.lblProjectNo.Text = "项目编号"
        '
        'lblPhase
        '
        Me.lblPhase.AutoSize = True
        Me.lblPhase.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblPhase.Location = New System.Drawing.Point(40, 47)
        Me.lblPhase.Name = "lblPhase"
        Me.lblPhase.Size = New System.Drawing.Size(54, 14)
        Me.lblPhase.TabIndex = 133
        Me.lblPhase.Text = "项目阶段"
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtCorporationName.Location = New System.Drawing.Point(296, 16)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.Size = New System.Drawing.Size(120, 21)
        Me.txtCorporationName.TabIndex = 132
        Me.txtCorporationName.Text = ""
        '
        'lblCorporationName
        '
        Me.lblCorporationName.AutoSize = True
        Me.lblCorporationName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblCorporationName.Location = New System.Drawing.Point(240, 19)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(54, 14)
        Me.lblCorporationName.TabIndex = 131
        Me.lblCorporationName.Text = "企业名称"
        '
        'txtCorporationNo
        '
        Me.txtCorporationNo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtCorporationNo.Location = New System.Drawing.Point(96, 16)
        Me.txtCorporationNo.Name = "txtCorporationNo"
        Me.txtCorporationNo.Size = New System.Drawing.Size(120, 21)
        Me.txtCorporationNo.TabIndex = 130
        Me.txtCorporationNo.Text = ""
        '
        'lblCorporationNo
        '
        Me.lblCorporationNo.AutoSize = True
        Me.lblCorporationNo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblCorporationNo.Location = New System.Drawing.Point(40, 19)
        Me.lblCorporationNo.Name = "lblCorporationNo"
        Me.lblCorporationNo.Size = New System.Drawing.Size(54, 14)
        Me.lblCorporationNo.TabIndex = 129
        Me.lblCorporationNo.Text = "企业编号"
        '
        'cboPMA
        '
        Me.cboPMA.DisplayMember = "staff_name"
        Me.cboPMA.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cboPMA.Location = New System.Drawing.Point(496, 43)
        Me.cboPMA.MaxLength = 10
        Me.cboPMA.Name = "cboPMA"
        Me.cboPMA.Size = New System.Drawing.Size(120, 20)
        Me.cboPMA.TabIndex = 145
        Me.cboPMA.ValueMember = "staff_name"
        '
        'lblServiceType
        '
        Me.lblServiceType.AutoSize = True
        Me.lblServiceType.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblServiceType.Location = New System.Drawing.Point(240, 47)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(54, 14)
        Me.lblServiceType.TabIndex = 135
        Me.lblServiceType.Text = "业务品种"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(431, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 14)
        Me.Label8.TabIndex = 144
        Me.Label8.Text = "项目经理A"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboServiceType
        '
        Me.cboServiceType.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.cboServiceType.ItemHeight = 12
        Me.cboServiceType.Location = New System.Drawing.Point(296, 43)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(120, 20)
        Me.cboServiceType.TabIndex = 136
        '
        'project_code
        '
        Me.project_code.Format = ""
        Me.project_code.FormatInfo = Nothing
        Me.project_code.HeaderText = "项目编号"
        Me.project_code.MappingName = "project_code"
        Me.project_code.NullText = ""
        Me.project_code.Width = 80
        '
        'corporation_name
        '
        Me.corporation_name.Format = ""
        Me.corporation_name.FormatInfo = Nothing
        Me.corporation_name.HeaderText = "企业名称"
        Me.corporation_name.MappingName = "corporation_name"
        Me.corporation_name.NullText = ""
        Me.corporation_name.Width = 150
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
        'apply_date
        '
        Me.apply_date.Format = "yyyy-MM-dd"
        Me.apply_date.FormatInfo = Nothing
        Me.apply_date.HeaderText = "申请日期"
        Me.apply_date.MappingName = "apply_date"
        Me.apply_date.NullText = ""
        Me.apply_date.Width = 75
        '
        'apply_sum
        '
        Me.apply_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.apply_sum.Format = ""
        Me.apply_sum.FormatInfo = Nothing
        Me.apply_sum.HeaderText = "申请金额(万元)"
        Me.apply_sum.MappingName = "apply_sum"
        Me.apply_sum.NullText = ""
        Me.apply_sum.Width = 90
        '
        'PMA
        '
        Me.PMA.Format = ""
        Me.PMA.FormatInfo = Nothing
        Me.PMA.HeaderText = "项目经理A角"
        Me.PMA.MappingName = "PMA"
        Me.PMA.NullText = ""
        Me.PMA.Width = 75
        '
        'PMB
        '
        Me.PMB.Format = ""
        Me.PMB.FormatInfo = Nothing
        Me.PMB.HeaderText = "项目经理B角"
        Me.PMB.MappingName = "PMB"
        Me.PMB.NullText = ""
        Me.PMB.Width = 75
        '
        'first_review_date
        '
        Me.first_review_date.Format = ""
        Me.first_review_date.FormatInfo = Nothing
        Me.first_review_date.HeaderText = "初审日期"
        Me.first_review_date.MappingName = "first_review_time"
        Me.first_review_date.NullText = ""
        Me.first_review_date.Width = 75
        '
        'conference_date
        '
        Me.conference_date.Format = "yyyy-MM-dd"
        Me.conference_date.FormatInfo = Nothing
        Me.conference_date.HeaderText = "评审会日期"
        Me.conference_date.MappingName = "conference_date"
        Me.conference_date.NullText = ""
        Me.conference_date.Width = 80
        '
        'trial_conclusion
        '
        Me.trial_conclusion.Format = ""
        Me.trial_conclusion.FormatInfo = Nothing
        Me.trial_conclusion.HeaderText = "评审会结论"
        Me.trial_conclusion.MappingName = "trial_conclusion"
        Me.trial_conclusion.NullText = ""
        Me.trial_conclusion.Width = 75
        '
        'intent_date
        '
        Me.intent_date.Format = "yyyy-MM-dd"
        Me.intent_date.FormatInfo = Nothing
        Me.intent_date.HeaderText = "签发意向书日期"
        Me.intent_date.MappingName = "intent_date"
        Me.intent_date.NullText = ""
        Me.intent_date.Width = 90
        '
        'sign_date
        '
        Me.sign_date.Format = "yyyy-MM-dd"
        Me.sign_date.FormatInfo = Nothing
        Me.sign_date.HeaderText = "签约日期"
        Me.sign_date.MappingName = "sign_date"
        Me.sign_date.NullText = ""
        Me.sign_date.Width = 80
        '
        'pause_date
        '
        Me.pause_date.Format = "yyyy-MM-dd"
        Me.pause_date.FormatInfo = Nothing
        Me.pause_date.HeaderText = "暂缓日期"
        Me.pause_date.MappingName = "pause_date"
        Me.pause_date.NullText = ""
        Me.pause_date.Width = 75
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
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.project_code, Me.corporation_name, Me.service_type, Me.trial_sum, Me.pause_date, Me.unCompletePause, Me.apply_date, Me.apply_sum, Me.PMA, Me.PMB, Me.first_review_date, Me.conference_date, Me.trial_conclusion, Me.intent_date, Me.sign_date, Me.branch_name, Me.status})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'trial_sum
        '
        Me.trial_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.trial_sum.Format = ""
        Me.trial_sum.FormatInfo = Nothing
        Me.trial_sum.HeaderText = "评审会通过金额(万元)"
        Me.trial_sum.MappingName = "trial_sum"
        Me.trial_sum.NullText = ""
        Me.trial_sum.Width = 125
        '
        'unCompletePause
        '
        Me.unCompletePause.Format = ""
        Me.unCompletePause.FormatInfo = Nothing
        Me.unCompletePause.HeaderText = "未彻底暂缓"
        Me.unCompletePause.MappingName = "unCompletePause"
        Me.unCompletePause.NullText = ""
        Me.unCompletePause.Width = 80
        '
        'FQueryPauseProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(768, 581)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "FQueryPauseProject"
        Me.Text = "暂缓项目一览表"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FFirstProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.dtpFromDate.Enabled = False
        Me.dtpToDate.Enabled = False

        dtpFromDate.Value = DateTime.Today
        dtpToDate.Value = DateTime.Today

        cboPhase.DataSource = gWs.GetPhase("%").Tables(0)
        cboPhase.DisplayMember = "phase_name"
        cboPhase.ValueMember = "phase_name"

        cboServiceType.DataSource = gWs.GetServiceType("%").Tables(0)
        cboServiceType.DisplayMember = "service_type"
        cboServiceType.ValueMember = "service_type"

        cboPMA.DataSource = gWs.GetStaff("{not team_name is null}").Tables(0)

    End Sub

    Private Sub FFirstProject_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Refresh("")
        End If
    End Sub

    Private Sub TextEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Not sender Is Nothing) AndAlso sender.GetType() Is GetType(TextBox) Then
            CType(sender, TextBox).SelectAll()
        End If
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal Condition As String)
        Dim i As Integer
        Dim iTotalSum As Decimal
        Dim dtResult As DataTable

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim projectNo, corporationNo, corporationName, phase, serviceType, strPMA As String

            Me.GetCondition(projectNo, corporationNo, corporationName, phase, serviceType, strPMA)

            Dim dateStart, dateEnd As Object
            If Me.chbDate.Checked Then
                dateStart = Me.dtpFromDate.Value.Date()
                dateEnd = Me.dtpToDate.Value.Date()
            Else
                dateStart = Nothing
                dateEnd = Nothing
            End If

            'Dim rsResult As DataSet = gWs.GetQueryPauseProject(projectNo, corporationNo, corporationName, phase, serviceType, dtpFromDate.Value, dtpToDate.Value)
            Try
                grdTable.TableStyles.Clear()
                grdTable.DataSource = Nothing
                grdTable.DataMember = String.Empty

                dtResult = gWs.GetQueryPauseProject(projectNo, corporationNo, corporationName, phase, serviceType, dateStart, dateEnd, strPMA, UserName).Tables(0)
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
                Exit Sub
            End Try

            For i = 0 To dtResult.Rows.Count - 1
                If Not IsDBNull(dtResult.Rows(i).Item("apply_sum")) Then
                    iTotalSum = iTotalSum + CDec(dtResult.Rows(i).Item("apply_sum"))
                End If
            Next
            Dim drRow As DataRow = dtResult.NewRow
            With drRow
                .Item("corporation_name") = "合计："
                .Item("apply_sum") = iTotalSum
            End With
            dtResult.Rows.Add(drRow)

            drRow = dtResult.NewRow
            With drRow
                .Item("corporation_name") = "单数：" & i
            End With
            dtResult.Rows.Add(drRow)

            grdTable.DataSource = dtResult
            grdTable.TableStyles.Add(DataGridTableStyle1)
            Me.Text = "暂缓项目一览表" '(" + rsResult.Tables("Table").Rows.Count.ToString + ")"
        Finally
                Me.Cursor = Cursors.Default
            End Try
    End Sub

    Private Overloads Sub GetCondition(ByRef projectNo As String, ByRef corporationNo As String, ByRef corporationName As String, ByRef phase As String, ByRef serviceType As String, ByRef strPMA As String)
        projectNo = IIf(txtProjectNo.Text.Trim() = "", "", txtProjectNo.Text)
        corporationNo = IIf(txtCorporationNo.Text.Trim() = "", "", txtCorporationNo.Text)
        corporationName = IIf(txtCorporationName.Text.Trim() = "", "", txtCorporationName.Text)
        phase = IIf(cboPhase.Text.Trim() = "", "", cboPhase.Text)
        serviceType = IIf(cboServiceType.Text.Trim() = "", "", cboServiceType.Text)
        'strPMA = cboPMA.Text.Trim
        strPMA = IIf(cboPMA.Text.Trim = "", "", Me.cboPMA.Text)
    End Sub

    Private Sub chbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbDate.CheckedChanged

        Me.dtpFromDate.Enabled = Me.chbDate.Checked
        Me.dtpToDate.Enabled = Me.chbDate.Checked

    End Sub

    Protected Overrides Sub Export()
        Dim export As New ReportToExcel()
        export.ToExcel(Me.grdTable, "暂缓项目一览表", "暂缓项目一览表")
    End Sub
End Class
