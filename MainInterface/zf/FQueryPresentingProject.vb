Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FQueryPresentingProject
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
	Friend WithEvents lblProjectNo As System.Windows.Forms.Label
	Friend WithEvents txtProjectNo As System.Windows.Forms.TextBox
	Friend WithEvents lblCorporationName As System.Windows.Forms.Label
	Friend WithEvents cboCorporationName As System.Windows.Forms.ComboBox
	Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
	Friend WithEvents lblServiceType As System.Windows.Forms.Label
	Friend WithEvents cboRegion As System.Windows.Forms.ComboBox
	Friend WithEvents lblRegion As System.Windows.Forms.Label
	Friend WithEvents cboIndustry As System.Windows.Forms.ComboBox
	Friend WithEvents lblIndustry As System.Windows.Forms.Label
	Friend WithEvents cboProprietorship As System.Windows.Forms.ComboBox
	Friend WithEvents lblProprietorship As System.Windows.Forms.Label
	Friend WithEvents lblDate As System.Windows.Forms.Label
	Friend WithEvents chkDate As System.Windows.Forms.CheckBox
	Friend WithEvents dtpDateStart As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpDateEnd As System.Windows.Forms.DateTimePicker
	Friend WithEvents cboTeam As System.Windows.Forms.ComboBox
	Friend WithEvents lblTeam As System.Windows.Forms.Label
	Friend WithEvents cboPMA As System.Windows.Forms.ComboBox
	Friend WithEvents lblPMA As System.Windows.Forms.Label
	Friend WithEvents tsTable As System.Windows.Forms.DataGridTableStyle
	Friend WithEvents csProjectNo As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csCorporationName As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csRegion As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csIndustry As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csProprietorship As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csRecommend As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csTrialTimes As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csTeam As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csPMA As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csPMB As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csManagerRecommendSum As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csPrimeCommit As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csConclusion As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csApplyServiceType As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csServiceType As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csGuaranteeSum As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csTerms As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csLoanProvideForm As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csRefundType As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents cboConclusion As System.Windows.Forms.ComboBox
	Friend WithEvents lblConclusion As System.Windows.Forms.Label
    Friend WithEvents csConferenceDate As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblProjectNo = New System.Windows.Forms.Label()
        Me.txtProjectNo = New System.Windows.Forms.TextBox()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.cboCorporationName = New System.Windows.Forms.ComboBox()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.cboRegion = New System.Windows.Forms.ComboBox()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.cboIndustry = New System.Windows.Forms.ComboBox()
        Me.lblIndustry = New System.Windows.Forms.Label()
        Me.cboTeam = New System.Windows.Forms.ComboBox()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.cboProprietorship = New System.Windows.Forms.ComboBox()
        Me.lblProprietorship = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.dtpDateStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.cboPMA = New System.Windows.Forms.ComboBox()
        Me.lblPMA = New System.Windows.Forms.Label()
        Me.tsTable = New System.Windows.Forms.DataGridTableStyle()
        Me.csProjectNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCorporationName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csRegion = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIndustry = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csProprietorship = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csRecommend = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csApplyServiceType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTrialTimes = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTeam = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csPMA = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csPMB = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csManagerRecommendSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csPrimeCommit = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csServiceType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csGuaranteeSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTerms = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csLoanProvideForm = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csRefundType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csConclusion = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cboConclusion = New System.Windows.Forms.ComboBox()
        Me.lblConclusion = New System.Windows.Forms.Label()
        Me.csConferenceDate = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(616, 136)
        Me.btnExit.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 168)
        Me.grdTable.Size = New System.Drawing.Size(696, 320)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsTable})
        Me.grdTable.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(296, 136)
        Me.btnRefresh.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboConclusion, Me.lblConclusion, Me.cboPMA, Me.lblPMA, Me.dtpDateEnd, Me.dtpDateStart, Me.chkDate, Me.lblDate, Me.cboProprietorship, Me.lblProprietorship, Me.cboTeam, Me.lblTeam, Me.cboIndustry, Me.lblIndustry, Me.cboRegion, Me.lblRegion, Me.cboServiceType, Me.lblServiceType, Me.cboCorporationName, Me.lblCorporationName, Me.txtProjectNo, Me.lblProjectNo})
        Me.grpCondition.Size = New System.Drawing.Size(696, 120)
        Me.grpCondition.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 136)
        Me.btnClear.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 136)
        Me.chkVisible.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(512, 136)
        Me.btnPrint.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(408, 136)
        Me.btnExport.Visible = True
        '
        'lblProjectNo
        '
        Me.lblProjectNo.Location = New System.Drawing.Point(16, 24)
        Me.lblProjectNo.Name = "lblProjectNo"
        Me.lblProjectNo.Size = New System.Drawing.Size(64, 16)
        Me.lblProjectNo.TabIndex = 1
        Me.lblProjectNo.Text = "项目编号"
        '
        'txtProjectNo
        '
        Me.txtProjectNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectNo.Location = New System.Drawing.Point(80, 16)
        Me.txtProjectNo.Name = "txtProjectNo"
        Me.txtProjectNo.Size = New System.Drawing.Size(120, 22)
        Me.txtProjectNo.TabIndex = 2
        Me.txtProjectNo.Text = ""
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Location = New System.Drawing.Point(256, 24)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(64, 16)
        Me.lblCorporationName.TabIndex = 3
        Me.lblCorporationName.Text = "企业名称"
        '
        'cboCorporationName
        '
        Me.cboCorporationName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCorporationName.Location = New System.Drawing.Point(320, 16)
        Me.cboCorporationName.Name = "cboCorporationName"
        Me.cboCorporationName.Size = New System.Drawing.Size(120, 22)
        Me.cboCorporationName.TabIndex = 4
        '
        'cboServiceType
        '
        Me.cboServiceType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServiceType.Location = New System.Drawing.Point(560, 16)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(120, 22)
        Me.cboServiceType.TabIndex = 6
        '
        'lblServiceType
        '
        Me.lblServiceType.Location = New System.Drawing.Point(496, 24)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(64, 16)
        Me.lblServiceType.TabIndex = 5
        Me.lblServiceType.Text = "业务品种"
        '
        'cboRegion
        '
        Me.cboRegion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegion.Location = New System.Drawing.Point(80, 40)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.Size = New System.Drawing.Size(120, 22)
        Me.cboRegion.TabIndex = 8
        '
        'lblRegion
        '
        Me.lblRegion.Location = New System.Drawing.Point(16, 48)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(64, 16)
        Me.lblRegion.TabIndex = 7
        Me.lblRegion.Text = "所属区域"
        '
        'cboIndustry
        '
        Me.cboIndustry.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIndustry.Location = New System.Drawing.Point(320, 40)
        Me.cboIndustry.Name = "cboIndustry"
        Me.cboIndustry.Size = New System.Drawing.Size(120, 22)
        Me.cboIndustry.TabIndex = 10
        '
        'lblIndustry
        '
        Me.lblIndustry.Location = New System.Drawing.Point(256, 48)
        Me.lblIndustry.Name = "lblIndustry"
        Me.lblIndustry.Size = New System.Drawing.Size(64, 16)
        Me.lblIndustry.TabIndex = 9
        Me.lblIndustry.Text = "所属行业"
        '
        'cboTeam
        '
        Me.cboTeam.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTeam.Location = New System.Drawing.Point(80, 64)
        Me.cboTeam.Name = "cboTeam"
        Me.cboTeam.Size = New System.Drawing.Size(120, 22)
        Me.cboTeam.TabIndex = 14
        '
        'lblTeam
        '
        Me.lblTeam.Location = New System.Drawing.Point(16, 72)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(64, 16)
        Me.lblTeam.TabIndex = 13
        Me.lblTeam.Text = "项 目 组"
        '
        'cboProprietorship
        '
        Me.cboProprietorship.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProprietorship.Location = New System.Drawing.Point(560, 40)
        Me.cboProprietorship.Name = "cboProprietorship"
        Me.cboProprietorship.Size = New System.Drawing.Size(120, 22)
        Me.cboProprietorship.TabIndex = 12
        '
        'lblProprietorship
        '
        Me.lblProprietorship.Location = New System.Drawing.Point(496, 48)
        Me.lblProprietorship.Name = "lblProprietorship"
        Me.lblProprietorship.Size = New System.Drawing.Size(64, 16)
        Me.lblProprietorship.TabIndex = 11
        Me.lblProprietorship.Text = "所有制类"
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(496, 96)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(64, 16)
        Me.lblDate.TabIndex = 21
        Me.lblDate.Text = "到："
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(240, 96)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(80, 20)
        Me.chkDate.TabIndex = 19
        Me.chkDate.Text = "评审日期"
        '
        'dtpDateStart
        '
        Me.dtpDateStart.Enabled = False
        Me.dtpDateStart.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateStart.Location = New System.Drawing.Point(320, 88)
        Me.dtpDateStart.Name = "dtpDateStart"
        Me.dtpDateStart.Size = New System.Drawing.Size(120, 21)
        Me.dtpDateStart.TabIndex = 20
        '
        'dtpDateEnd
        '
        Me.dtpDateEnd.Enabled = False
        Me.dtpDateEnd.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateEnd.Location = New System.Drawing.Point(560, 88)
        Me.dtpDateEnd.Name = "dtpDateEnd"
        Me.dtpDateEnd.Size = New System.Drawing.Size(120, 21)
        Me.dtpDateEnd.TabIndex = 22
        '
        'cboPMA
        '
        Me.cboPMA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPMA.Location = New System.Drawing.Point(320, 64)
        Me.cboPMA.Name = "cboPMA"
        Me.cboPMA.Size = New System.Drawing.Size(120, 22)
        Me.cboPMA.TabIndex = 16
        '
        'lblPMA
        '
        Me.lblPMA.Location = New System.Drawing.Point(256, 72)
        Me.lblPMA.Name = "lblPMA"
        Me.lblPMA.Size = New System.Drawing.Size(64, 16)
        Me.lblPMA.TabIndex = 15
        Me.lblPMA.Text = "项目经理A"
        '
        'tsTable
        '
        Me.tsTable.DataGrid = Me.grdTable
        Me.tsTable.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csProjectNo, Me.csCorporationName, Me.csRegion, Me.csIndustry, Me.csProprietorship, Me.csRecommend, Me.csApplyServiceType, Me.csTrialTimes, Me.csTeam, Me.csPMA, Me.csPMB, Me.csManagerRecommendSum, Me.csConferenceDate, Me.csPrimeCommit, Me.csServiceType, Me.csGuaranteeSum, Me.csTerms, Me.csLoanProvideForm, Me.csRefundType, Me.csConclusion})
        Me.tsTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsTable.MappingName = "TQueryPresentingProject"
        '
        'csProjectNo
        '
        Me.csProjectNo.Format = ""
        Me.csProjectNo.FormatInfo = Nothing
        Me.csProjectNo.HeaderText = "项目编号"
        Me.csProjectNo.MappingName = "project_code"
        Me.csProjectNo.Width = 60
        '
        'csCorporationName
        '
        Me.csCorporationName.Format = ""
        Me.csCorporationName.FormatInfo = Nothing
        Me.csCorporationName.HeaderText = "企业名称"
        Me.csCorporationName.MappingName = "enterprise_name"
        Me.csCorporationName.Width = 200
        '
        'csRegion
        '
        Me.csRegion.Format = ""
        Me.csRegion.FormatInfo = Nothing
        Me.csRegion.HeaderText = "所属区"
        Me.csRegion.MappingName = "district_name"
        Me.csRegion.Width = 80
        '
        'csIndustry
        '
        Me.csIndustry.Format = ""
        Me.csIndustry.FormatInfo = Nothing
        Me.csIndustry.HeaderText = "行业"
        Me.csIndustry.MappingName = "industry_type"
        Me.csIndustry.Width = 80
        '
        'csProprietorship
        '
        Me.csProprietorship.Format = ""
        Me.csProprietorship.FormatInfo = Nothing
        Me.csProprietorship.HeaderText = "所有制"
        Me.csProprietorship.MappingName = "proprietorship_type"
        Me.csProprietorship.Width = 80
        '
        'csRecommend
        '
        Me.csRecommend.Format = ""
        Me.csRecommend.FormatInfo = Nothing
        Me.csRecommend.HeaderText = "推荐人"
        Me.csRecommend.MappingName = "recommend_person"
        Me.csRecommend.Width = 80
        '
        'csApplyServiceType
        '
        Me.csApplyServiceType.Format = ""
        Me.csApplyServiceType.FormatInfo = Nothing
        Me.csApplyServiceType.HeaderText = "业务品种"
        Me.csApplyServiceType.MappingName = "apply_service_type"
        Me.csApplyServiceType.Width = 120
        '
        'csTrialTimes
        '
        Me.csTrialTimes.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csTrialTimes.Format = ""
        Me.csTrialTimes.FormatInfo = Nothing
        Me.csTrialTimes.HeaderText = "上会次数"
        Me.csTrialTimes.MappingName = "trial_times"
        Me.csTrialTimes.Width = 60
        '
        'csTeam
        '
        Me.csTeam.Format = ""
        Me.csTeam.FormatInfo = Nothing
        Me.csTeam.HeaderText = "项目组"
        Me.csTeam.MappingName = "team"
        Me.csTeam.Width = 80
        '
        'csPMA
        '
        Me.csPMA.Format = ""
        Me.csPMA.FormatInfo = Nothing
        Me.csPMA.HeaderText = "项目经理A"
        Me.csPMA.MappingName = "manager_a"
        Me.csPMA.Width = 60
        '
        'csPMB
        '
        Me.csPMB.Format = ""
        Me.csPMB.FormatInfo = Nothing
        Me.csPMB.HeaderText = "项目经理B"
        Me.csPMB.MappingName = "manager_b"
        Me.csPMB.Width = 60
        '
        'csManagerRecommendSum
        '
        Me.csManagerRecommendSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csManagerRecommendSum.Format = ""
        Me.csManagerRecommendSum.FormatInfo = Nothing
        Me.csManagerRecommendSum.HeaderText = "拟同意金额"
        Me.csManagerRecommendSum.MappingName = "manager_recommend_sum"
        Me.csManagerRecommendSum.Width = 80
        '
        'csPrimeCommit
        '
        Me.csPrimeCommit.Format = ""
        Me.csPrimeCommit.FormatInfo = Nothing
        Me.csPrimeCommit.HeaderText = "主审人员"
        Me.csPrimeCommit.MappingName = "prime_committeeman"
        Me.csPrimeCommit.Width = 60
        '
        'csServiceType
        '
        Me.csServiceType.Format = ""
        Me.csServiceType.FormatInfo = Nothing
        Me.csServiceType.HeaderText = "业务品种"
        Me.csServiceType.MappingName = "service_type"
        Me.csServiceType.Width = 80
        '
        'csGuaranteeSum
        '
        Me.csGuaranteeSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csGuaranteeSum.Format = ""
        Me.csGuaranteeSum.FormatInfo = Nothing
        Me.csGuaranteeSum.HeaderText = "通过金额"
        Me.csGuaranteeSum.MappingName = "guarantee_sum"
        Me.csGuaranteeSum.Width = 80
        '
        'csTerms
        '
        Me.csTerms.Format = ""
        Me.csTerms.FormatInfo = Nothing
        Me.csTerms.HeaderText = "期限"
        Me.csTerms.MappingName = "terms"
        Me.csTerms.Width = 80
        '
        'csLoanProvideForm
        '
        Me.csLoanProvideForm.Format = ""
        Me.csLoanProvideForm.FormatInfo = Nothing
        Me.csLoanProvideForm.HeaderText = "放款方式"
        Me.csLoanProvideForm.MappingName = "loan_provide_form"
        Me.csLoanProvideForm.Width = 80
        '
        'csRefundType
        '
        Me.csRefundType.Format = ""
        Me.csRefundType.FormatInfo = Nothing
        Me.csRefundType.HeaderText = "还款方式"
        Me.csRefundType.MappingName = "refund_type"
        Me.csRefundType.Width = 80
        '
        'csConclusion
        '
        Me.csConclusion.Format = ""
        Me.csConclusion.FormatInfo = Nothing
        Me.csConclusion.HeaderText = "结  论"
        Me.csConclusion.MappingName = "trial_conclusion"
        Me.csConclusion.Width = 75
        '
        'cboConclusion
        '
        Me.cboConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConclusion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConclusion.Items.AddRange(New Object() {"<全部>", "通过", "暂缓", "补充调查"})
        Me.cboConclusion.Location = New System.Drawing.Point(560, 64)
        Me.cboConclusion.Name = "cboConclusion"
        Me.cboConclusion.Size = New System.Drawing.Size(120, 22)
        Me.cboConclusion.TabIndex = 18
        '
        'lblConclusion
        '
        Me.lblConclusion.Location = New System.Drawing.Point(496, 72)
        Me.lblConclusion.Name = "lblConclusion"
        Me.lblConclusion.Size = New System.Drawing.Size(64, 16)
        Me.lblConclusion.TabIndex = 17
        Me.lblConclusion.Text = "评审结论"
        '
        'csConferenceDate
        '
        Me.csConferenceDate.Format = "D"
        Me.csConferenceDate.FormatInfo = Nothing
        Me.csConferenceDate.HeaderText = "评审日期"
        Me.csConferenceDate.MappingName = "conference_date"
        '
        'FQueryPresentingProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryPresentingProject"
        Me.Text = "提交评审会讨论项目一览表"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

	Protected Overloads Sub GetCondition(ByRef projectNo As String, ByRef corporationName As String, ByRef serviceType As String, ByRef regionName As String, ByRef industryName As String, ByRef proprietorshipType As String, ByRef teamName As String, ByRef PMA As String, ByRef startDate As Object, ByRef endDate As Object, ByRef conclusion As String)
		projectNo = IIf(txtProjectNo.Text.Trim() = "", "", txtProjectNo.Text)
		corporationName = IIf(cboCorporationName.Text.Trim() = "", "", cboCorporationName.Text)
		serviceType = IIf(cboServiceType.Text.Trim() = "", "", cboServiceType.Text)
		regionName = IIf(cboRegion.Text.Trim() = "", "", cboRegion.Text)
		industryName = IIf(cboIndustry.Text.Trim() = "", "", cboIndustry.Text)
		teamName = IIf(cboTeam.Text.Trim() = "", "", cboTeam.Text)
		PMA = IIf(cboPMA.Text.Trim() = "", "", cboPMA.Text)
		proprietorshipType = IIf(cboProprietorship.Text.Trim() = "", "", cboProprietorship.Text)
		conclusion = IIf(cboConclusion.SelectedIndex < 1, "", cboConclusion.Text)

		startDate = IIf(chkDate.Checked, dtpDateStart.Value, Nothing)
		endDate = IIf(chkDate.Checked, dtpDateEnd.Value, Nothing)
	End Sub

	Protected Overloads Overrides Sub Refresh(ByVal condition As String)
		Dim projectNo, corporationName, serviceType, regionName, industryName, proprietorshipType, teamName, PMA, conclusion As String
		Dim startDate, endDate As Object

		GetCondition(projectNo, corporationName, serviceType, regionName, industryName, proprietorshipType, teamName, PMA, startDate, endDate, conclusion)

		Dim dsResult As DataSet = gWs.FQueryPresentingProject(projectNo, corporationName, serviceType, startDate, endDate, regionName, industryName, proprietorshipType, "", "", conclusion)

		dsResult.Tables("Table").TableName = "TQueryPresentingProject"

		MyBase.DataSource = dsResult
		grdTable.DataSource = dsResult
		grdTable.SetDataBinding(dsResult, "TQueryPresentingProject")
		Me.Text = "提交评审会讨论项目一览表(" + dsResult.Tables("TQueryPresentingProject").Rows.Count.ToString + ")"
	End Sub

	Private Sub TextEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProjectNo.Enter, cboCorporationName.Enter, cboRegion.Enter, cboIndustry.Enter, cboServiceType.Enter, cboProprietorship.Enter, cboTeam.Enter
		If (Not sender Is Nothing) AndAlso sender.GetType() Is GetType(TextBox) Then
			CType(sender, TextBox).SelectAll()
		End If
	End Sub

	Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
		dtpDateStart.Enabled = chkDate.Checked
		dtpDateEnd.Enabled = chkDate.Checked
	End Sub

	Private Sub FQueryPresentingProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		dtpDateStart.Value = DateTime.Today
		dtpDateEnd.Value = DateTime.Today

		cboCorporationName.DataSource = gWs.GetcorporationInfo("%", "%").Tables(0)
		cboCorporationName.DisplayMember = "corporation_name"
		cboCorporationName.ValueMember = "corporation_name"

		cboServiceType.DataSource = gWs.GetServiceType("%").Tables(0)
		cboServiceType.DisplayMember = "service_type"
		cboServiceType.ValueMember = "service_type"

		cboRegion.DataSource = gWs.GetDistrict("%").Tables(0)
		cboRegion.DisplayMember = "district_name"
		cboRegion.ValueMember = "district_name"

		cboIndustry.DataSource = gWs.GetIndustryType("%").Tables(0)
		cboIndustry.DisplayMember = "industry_type"
		cboIndustry.ValueMember = "industry_type"

		cboTeam.DataSource = gWs.GetTeam("%").Tables(0)
		cboTeam.DisplayMember = "team_name"
		cboTeam.ValueMember = "team_name"

		cboPMA.DataSource = gWs.GetStaff("%").Tables(0)
		cboPMA.DisplayMember = "staff_name"
		cboPMA.ValueMember = "staff_name"

		cboProprietorship.DataSource = gWs.GetProprietorshipType("%").Tables(0)
		cboProprietorship.DisplayMember = "proprietorship_type"
		cboProprietorship.ValueMember = "proprietorship_type"

		cboPMA.SelectedItem = Nothing
		cboTeam.SelectedItem = Nothing
		cboRegion.SelectedItem = Nothing
		cboIndustry.SelectedItem = Nothing
		cboServiceType.SelectedItem = Nothing
		cboProprietorship.SelectedItem = Nothing
		cboCorporationName.SelectedItem = Nothing

		MyBase.ReportTitle = "提交评审会讨论项目一览表"
		MyBase.ReportFile = Application.StartupPath + "\Reports\QueryPresentingProject.rpt"
	End Sub
End Class
