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
    Friend WithEvents cboPMA As System.Windows.Forms.ComboBox
    Friend WithEvents lblPMA As System.Windows.Forms.Label
    Friend WithEvents cboConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents lblConclusion As System.Windows.Forms.Label
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents dsPresentingProject As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents project_code As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents enterprise_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents district_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents industry_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents proprietorship_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents recommend_person As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents apply_service_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents trial_times As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents team As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_a As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_b As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_recommend_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents conference_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents prime_committeeman As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents service_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents guarantee_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents terms As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents loan_provide_form As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents refund_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents trial_conclusion As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents apply_times As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TechType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents is_first_loan As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents refund_sum_average As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Remark As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents branch_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents status As DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryPresentingProject))
        Me.lblProjectNo = New System.Windows.Forms.Label()
        Me.txtProjectNo = New System.Windows.Forms.TextBox()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.cboRegion = New System.Windows.Forms.ComboBox()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.cboIndustry = New System.Windows.Forms.ComboBox()
        Me.lblIndustry = New System.Windows.Forms.Label()
        Me.cboProprietorship = New System.Windows.Forms.ComboBox()
        Me.lblProprietorship = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.dtpDateStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.cboPMA = New System.Windows.Forms.ComboBox()
        Me.lblPMA = New System.Windows.Forms.Label()
        Me.cboConclusion = New System.Windows.Forms.ComboBox()
        Me.lblConclusion = New System.Windows.Forms.Label()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.dsPresentingProject = New System.Windows.Forms.DataGridTableStyle()
        Me.project_code = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.enterprise_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.district_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.industry_type = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.proprietorship_type = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.recommend_person = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.apply_service_type = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.trial_times = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.team = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.manager_a = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.manager_b = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.manager_recommend_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.conference_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.prime_committeeman = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.service_type = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.guarantee_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.terms = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.loan_provide_form = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.refund_type = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.refund_sum_average = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Remark = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.trial_conclusion = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.is_first_loan = New System.Windows.Forms.DataGridBoolColumn()
        Me.apply_times = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.TechType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.branch_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageIndex = -1
        Me.btnRefresh.ImageList = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(424, 152)
        Me.btnRefresh.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Bitmap)
        Me.btnExport.ImageIndex = -1
        Me.btnExport.ImageList = Nothing
        Me.btnExport.Location = New System.Drawing.Point(520, 152)
        Me.btnExport.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Bitmap)
        Me.btnClear.ImageIndex = -1
        Me.btnClear.ImageList = Nothing
        Me.btnClear.Location = New System.Drawing.Point(192, 152)
        Me.btnClear.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(616, 152)
        Me.btnExit.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 152)
        Me.chkVisible.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCorpName, Me.cboConclusion, Me.lblConclusion, Me.cboPMA, Me.lblPMA, Me.dtpDateEnd, Me.dtpDateStart, Me.chkDate, Me.lblDate, Me.cboProprietorship, Me.lblProprietorship, Me.cboIndustry, Me.lblIndustry, Me.cboRegion, Me.lblRegion, Me.cboServiceType, Me.lblServiceType, Me.lblCorporationName, Me.txtProjectNo, Me.lblProjectNo})
        Me.grpCondition.Size = New System.Drawing.Size(696, 128)
        Me.grpCondition.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 192)
        Me.grdTable.Size = New System.Drawing.Size(696, 296)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dsPresentingProject})
        Me.grdTable.Visible = True
        '
        'ImageListQuery
        '
        Me.ImageListQuery.ImageStream = CType(resources.GetObject("ImageListQuery.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(512, 144)
        Me.btnPrint.Visible = True
        '
        'lblProjectNo
        '
        Me.lblProjectNo.Location = New System.Drawing.Point(32, 18)
        Me.lblProjectNo.Name = "lblProjectNo"
        Me.lblProjectNo.Size = New System.Drawing.Size(64, 16)
        Me.lblProjectNo.TabIndex = 1
        Me.lblProjectNo.Text = "项目编号"
        '
        'txtProjectNo
        '
        Me.txtProjectNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectNo.Location = New System.Drawing.Point(88, 15)
        Me.txtProjectNo.Name = "txtProjectNo"
        Me.txtProjectNo.Size = New System.Drawing.Size(120, 22)
        Me.txtProjectNo.TabIndex = 2
        Me.txtProjectNo.Text = ""
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Location = New System.Drawing.Point(232, 18)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(64, 16)
        Me.lblCorporationName.TabIndex = 3
        Me.lblCorporationName.Text = "企业名称"
        '
        'cboServiceType
        '
        Me.cboServiceType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServiceType.Location = New System.Drawing.Point(488, 15)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(120, 22)
        Me.cboServiceType.TabIndex = 6
        '
        'lblServiceType
        '
        Me.lblServiceType.Location = New System.Drawing.Point(432, 18)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(64, 16)
        Me.lblServiceType.TabIndex = 5
        Me.lblServiceType.Text = "业务品种"
        '
        'cboRegion
        '
        Me.cboRegion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegion.Location = New System.Drawing.Point(88, 40)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.Size = New System.Drawing.Size(120, 22)
        Me.cboRegion.TabIndex = 8
        '
        'lblRegion
        '
        Me.lblRegion.Location = New System.Drawing.Point(32, 43)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(64, 16)
        Me.lblRegion.TabIndex = 7
        Me.lblRegion.Text = "所属区域"
        '
        'cboIndustry
        '
        Me.cboIndustry.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIndustry.Location = New System.Drawing.Point(288, 40)
        Me.cboIndustry.Name = "cboIndustry"
        Me.cboIndustry.Size = New System.Drawing.Size(120, 22)
        Me.cboIndustry.TabIndex = 10
        '
        'lblIndustry
        '
        Me.lblIndustry.Location = New System.Drawing.Point(232, 43)
        Me.lblIndustry.Name = "lblIndustry"
        Me.lblIndustry.Size = New System.Drawing.Size(64, 16)
        Me.lblIndustry.TabIndex = 9
        Me.lblIndustry.Text = "所属行业"
        '
        'cboProprietorship
        '
        Me.cboProprietorship.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProprietorship.Location = New System.Drawing.Point(488, 40)
        Me.cboProprietorship.Name = "cboProprietorship"
        Me.cboProprietorship.Size = New System.Drawing.Size(120, 22)
        Me.cboProprietorship.TabIndex = 12
        '
        'lblProprietorship
        '
        Me.lblProprietorship.Location = New System.Drawing.Point(432, 43)
        Me.lblProprietorship.Name = "lblProprietorship"
        Me.lblProprietorship.Size = New System.Drawing.Size(64, 16)
        Me.lblProprietorship.TabIndex = 11
        Me.lblProprietorship.Text = "所有制类"
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(264, 90)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(32, 16)
        Me.lblDate.TabIndex = 21
        Me.lblDate.Text = "到"
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(16, 88)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(80, 20)
        Me.chkDate.TabIndex = 19
        Me.chkDate.Text = "评审日期"
        '
        'dtpDateStart
        '
        Me.dtpDateStart.Enabled = False
        Me.dtpDateStart.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateStart.Location = New System.Drawing.Point(88, 88)
        Me.dtpDateStart.Name = "dtpDateStart"
        Me.dtpDateStart.Size = New System.Drawing.Size(120, 21)
        Me.dtpDateStart.TabIndex = 20
        '
        'dtpDateEnd
        '
        Me.dtpDateEnd.Enabled = False
        Me.dtpDateEnd.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateEnd.Location = New System.Drawing.Point(288, 88)
        Me.dtpDateEnd.Name = "dtpDateEnd"
        Me.dtpDateEnd.Size = New System.Drawing.Size(120, 21)
        Me.dtpDateEnd.TabIndex = 22
        '
        'cboPMA
        '
        Me.cboPMA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPMA.Location = New System.Drawing.Point(88, 64)
        Me.cboPMA.Name = "cboPMA"
        Me.cboPMA.Size = New System.Drawing.Size(120, 22)
        Me.cboPMA.TabIndex = 16
        '
        'lblPMA
        '
        Me.lblPMA.Location = New System.Drawing.Point(24, 67)
        Me.lblPMA.Name = "lblPMA"
        Me.lblPMA.Size = New System.Drawing.Size(64, 16)
        Me.lblPMA.TabIndex = 15
        Me.lblPMA.Text = "项目经理A"
        '
        'cboConclusion
        '
        Me.cboConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConclusion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConclusion.Items.AddRange(New Object() {"<全部>", "通过", "暂缓", "补充调查"})
        Me.cboConclusion.Location = New System.Drawing.Point(288, 64)
        Me.cboConclusion.Name = "cboConclusion"
        Me.cboConclusion.Size = New System.Drawing.Size(120, 22)
        Me.cboConclusion.TabIndex = 18
        '
        'lblConclusion
        '
        Me.lblConclusion.Location = New System.Drawing.Point(232, 67)
        Me.lblConclusion.Name = "lblConclusion"
        Me.lblConclusion.Size = New System.Drawing.Size(64, 16)
        Me.lblConclusion.TabIndex = 17
        Me.lblConclusion.Text = "评审结论"
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(288, 16)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(120, 21)
        Me.txtCorpName.TabIndex = 23
        Me.txtCorpName.Text = ""
        '
        'dsPresentingProject
        '
        Me.dsPresentingProject.DataGrid = Me.grdTable
        Me.dsPresentingProject.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.project_code, Me.enterprise_name, Me.district_name, Me.industry_type, Me.proprietorship_type, Me.recommend_person, Me.apply_service_type, Me.trial_times, Me.team, Me.manager_a, Me.manager_b, Me.manager_recommend_sum, Me.conference_date, Me.prime_committeeman, Me.service_type, Me.guarantee_sum, Me.terms, Me.loan_provide_form, Me.refund_type, Me.refund_sum_average, Me.Remark, Me.trial_conclusion, Me.is_first_loan, Me.apply_times, Me.TechType, Me.branch_name, Me.status})
        Me.dsPresentingProject.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dsPresentingProject.MappingName = "Table"
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
        Me.enterprise_name.Width = 200
        '
        'district_name
        '
        Me.district_name.Format = ""
        Me.district_name.FormatInfo = Nothing
        Me.district_name.HeaderText = "所属区"
        Me.district_name.MappingName = "district_name"
        Me.district_name.NullText = ""
        Me.district_name.Width = 90
        '
        'industry_type
        '
        Me.industry_type.Format = ""
        Me.industry_type.FormatInfo = Nothing
        Me.industry_type.HeaderText = "行业"
        Me.industry_type.MappingName = "industry_type"
        Me.industry_type.NullText = ""
        Me.industry_type.Width = 75
        '
        'proprietorship_type
        '
        Me.proprietorship_type.Format = ""
        Me.proprietorship_type.FormatInfo = Nothing
        Me.proprietorship_type.HeaderText = "所有制"
        Me.proprietorship_type.MappingName = "proprietorship_type"
        Me.proprietorship_type.NullText = ""
        Me.proprietorship_type.Width = 75
        '
        'recommend_person
        '
        Me.recommend_person.Format = ""
        Me.recommend_person.FormatInfo = Nothing
        Me.recommend_person.HeaderText = "推荐人"
        Me.recommend_person.MappingName = "recommend_person"
        Me.recommend_person.NullText = ""
        Me.recommend_person.Width = 75
        '
        'apply_service_type
        '
        Me.apply_service_type.Format = ""
        Me.apply_service_type.FormatInfo = Nothing
        Me.apply_service_type.HeaderText = "业务品种"
        Me.apply_service_type.MappingName = "apply_service_type"
        Me.apply_service_type.NullText = ""
        Me.apply_service_type.Width = 120
        '
        'trial_times
        '
        Me.trial_times.Format = ""
        Me.trial_times.FormatInfo = Nothing
        Me.trial_times.HeaderText = "上会次数"
        Me.trial_times.MappingName = "trial_times"
        Me.trial_times.NullText = ""
        Me.trial_times.Width = 75
        '
        'team
        '
        Me.team.Format = ""
        Me.team.FormatInfo = Nothing
        Me.team.HeaderText = "项目组"
        Me.team.MappingName = "team"
        Me.team.NullText = ""
        Me.team.Width = 75
        '
        'manager_a
        '
        Me.manager_a.Format = ""
        Me.manager_a.FormatInfo = Nothing
        Me.manager_a.HeaderText = "项目经理A"
        Me.manager_a.MappingName = "manager_a"
        Me.manager_a.NullText = ""
        Me.manager_a.Width = 75
        '
        'manager_b
        '
        Me.manager_b.Format = ""
        Me.manager_b.FormatInfo = Nothing
        Me.manager_b.HeaderText = "项目经理B"
        Me.manager_b.MappingName = "manager_b"
        Me.manager_b.NullText = ""
        Me.manager_b.Width = 75
        '
        'manager_recommend_sum
        '
        Me.manager_recommend_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.manager_recommend_sum.Format = ""
        Me.manager_recommend_sum.FormatInfo = Nothing
        Me.manager_recommend_sum.HeaderText = "拟同意金额"
        Me.manager_recommend_sum.MappingName = "manager_recommend_sum"
        Me.manager_recommend_sum.NullText = ""
        Me.manager_recommend_sum.Width = 90
        '
        'conference_date
        '
        Me.conference_date.Format = "yyyy-MM-dd"
        Me.conference_date.FormatInfo = Nothing
        Me.conference_date.HeaderText = "评审日期"
        Me.conference_date.MappingName = "conference_date"
        Me.conference_date.NullText = ""
        Me.conference_date.Width = 80
        '
        'prime_committeeman
        '
        Me.prime_committeeman.Format = ""
        Me.prime_committeeman.FormatInfo = Nothing
        Me.prime_committeeman.HeaderText = "主审人员"
        Me.prime_committeeman.MappingName = "prime_committeeman"
        Me.prime_committeeman.NullText = ""
        Me.prime_committeeman.Width = 75
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
        'guarantee_sum
        '
        Me.guarantee_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.guarantee_sum.Format = ""
        Me.guarantee_sum.FormatInfo = Nothing
        Me.guarantee_sum.HeaderText = "通过金额(万元)"
        Me.guarantee_sum.MappingName = "guarantee_sum"
        Me.guarantee_sum.NullText = ""
        '
        'terms
        '
        Me.terms.Format = ""
        Me.terms.FormatInfo = Nothing
        Me.terms.HeaderText = "期限(月)"
        Me.terms.MappingName = "terms"
        Me.terms.NullText = ""
        Me.terms.Width = 75
        '
        'loan_provide_form
        '
        Me.loan_provide_form.Format = ""
        Me.loan_provide_form.FormatInfo = Nothing
        Me.loan_provide_form.HeaderText = "放款方式"
        Me.loan_provide_form.MappingName = "loan_provide_form"
        Me.loan_provide_form.NullText = ""
        Me.loan_provide_form.Width = 80
        '
        'refund_type
        '
        Me.refund_type.Format = ""
        Me.refund_type.FormatInfo = Nothing
        Me.refund_type.HeaderText = "还款方式"
        Me.refund_type.MappingName = "refund_type"
        Me.refund_type.NullText = ""
        Me.refund_type.Width = 90
        '
        'refund_sum_average
        '
        Me.refund_sum_average.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.refund_sum_average.Format = "n"
        Me.refund_sum_average.FormatInfo = Nothing
        Me.refund_sum_average.HeaderText = "每次还款金额(元)"
        Me.refund_sum_average.MappingName = "refund_sum_average"
        Me.refund_sum_average.NullText = ""
        Me.refund_sum_average.Width = 120
        '
        'Remark
        '
        Me.Remark.Format = ""
        Me.Remark.FormatInfo = Nothing
        Me.Remark.HeaderText = "备注"
        Me.Remark.MappingName = "Remark"
        Me.Remark.NullText = ""
        Me.Remark.Width = 75
        '
        'trial_conclusion
        '
        Me.trial_conclusion.Format = ""
        Me.trial_conclusion.FormatInfo = Nothing
        Me.trial_conclusion.HeaderText = "结论"
        Me.trial_conclusion.MappingName = "trial_conclusion"
        Me.trial_conclusion.NullText = ""
        Me.trial_conclusion.Width = 75
        '
        'is_first_loan
        '
        Me.is_first_loan.FalseValue = False
        Me.is_first_loan.HeaderText = "首次贷款"
        Me.is_first_loan.MappingName = "is_first_loan"
        Me.is_first_loan.NullText = ""
        Me.is_first_loan.NullValue = CType(resources.GetObject("is_first_loan.NullValue"), System.DBNull)
        Me.is_first_loan.TrueValue = True
        Me.is_first_loan.Width = 75
        '
        'apply_times
        '
        Me.apply_times.Format = ""
        Me.apply_times.FormatInfo = Nothing
        Me.apply_times.HeaderText = "申请次数"
        Me.apply_times.MappingName = "apply_times"
        Me.apply_times.NullText = ""
        Me.apply_times.Width = 75
        '
        'TechType
        '
        Me.TechType.Format = ""
        Me.TechType.FormatInfo = Nothing
        Me.TechType.HeaderText = "科技类型"
        Me.TechType.MappingName = "TechType"
        Me.TechType.NullText = ""
        Me.TechType.Width = 150
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
        'FQueryPresentingProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryPresentingProject"
        Me.Text = "提交上会项目一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

	Protected Overloads Sub GetCondition(ByRef projectNo As String, ByRef corporationName As String, ByRef serviceType As String, ByRef regionName As String, ByRef industryName As String, ByRef proprietorshipType As String, ByRef teamName As String, ByRef PMA As String, ByRef startDate As Object, ByRef endDate As Object, ByRef conclusion As String)
		projectNo = IIf(txtProjectNo.Text.Trim() = "", "", txtProjectNo.Text)
        corporationName = IIf(txtCorpName.Text.Trim() = "", "", txtCorpName.Text)
		serviceType = IIf(cboServiceType.Text.Trim() = "", "", cboServiceType.Text)
		regionName = IIf(cboRegion.Text.Trim() = "", "", cboRegion.Text)
		industryName = IIf(cboIndustry.Text.Trim() = "", "", cboIndustry.Text)
        'teamName = IIf(cboTeam.Text.Trim() = "", "", cboTeam.Text)
		PMA = IIf(cboPMA.Text.Trim() = "", "", cboPMA.Text)
		proprietorshipType = IIf(cboProprietorship.Text.Trim() = "", "", cboProprietorship.Text)
		conclusion = IIf(cboConclusion.SelectedIndex < 1, "", cboConclusion.Text)

        startDate = IIf(chkDate.Checked, dtpDateStart.Value.Date, Nothing)
        endDate = IIf(chkDate.Checked, dtpDateEnd.Value.Date, Nothing)
	End Sub

	Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim projectNo, corporationName, serviceType, regionName, industryName, proprietorshipType, teamName, PMA, conclusion As String
        Dim startDate, endDate As Object
        Dim i As Integer
        Dim iTotalManagerRecommendSum, iTotalGuaranteeSum, iTotalRefundAverageSum As Decimal
        Dim dtResult As DataTable

        GetCondition(projectNo, corporationName, serviceType, regionName, industryName, proprietorshipType, teamName, PMA, startDate, endDate, conclusion)

        dtResult = gWs.FQueryPresentingProject(projectNo, corporationName, serviceType, startDate, endDate, regionName, industryName, proprietorshipType, "", PMA, conclusion, UserName).Tables(0)

        For i = 0 To dtResult.Rows.Count - 1
            If Not IsDBNull(dtResult.Rows(i).Item("manager_recommend_sum")) Then
                iTotalManagerRecommendSum = iTotalManagerRecommendSum + CDec(dtResult.Rows(i).Item("manager_recommend_sum"))
            End If
            If Not IsDBNull(dtResult.Rows(i).Item("guarantee_sum")) Then
                iTotalGuaranteeSum = iTotalGuaranteeSum + CDec(dtResult.Rows(i).Item("guarantee_sum"))
            End If
            If Not IsDBNull(dtResult.Rows(i).Item("refund_sum_average")) Then
                iTotalRefundAverageSum = iTotalRefundAverageSum + CDec(dtResult.Rows(i).Item("refund_sum_average"))
            End If
        Next
        Dim drRow As DataRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "合计："
            .Item("manager_recommend_sum") = iTotalManagerRecommendSum
            .Item("guarantee_sum") = iTotalGuaranteeSum
            .Item("refund_sum_average") = iTotalRefundAverageSum
        End With
        dtResult.Rows.Add(drRow)

        drRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "单数：" & i
        End With
        dtResult.Rows.Add(drRow)

        'dsResult.Tables("Table").TableName = "TQueryPresentingProject"

        MyBase.DataSource = dtResult
        grdTable.DataSource = dtResult
        'grdTable.SetDataBinding(dsResult, "TQueryPresentingProject")
        Me.Text = "提交上会项目一览表" '(" + dsResult.Tables("TQueryPresentingProject").Rows.Count.ToString + ")"
	End Sub

    Private Sub TextEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProjectNo.Enter, cboRegion.Enter, cboIndustry.Enter, cboServiceType.Enter, cboProprietorship.Enter
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

        'cboCorporationName.DataSource = gWs.GetcorporationInfo("%", "%").Tables(0)
        'cboCorporationName.DisplayMember = "corporation_name"
        'cboCorporationName.ValueMember = "corporation_name"

        cboServiceType.DataSource = gWs.GetServiceType("%").Tables(0)
        cboServiceType.DisplayMember = "service_type"
        cboServiceType.ValueMember = "service_type"

        cboRegion.DataSource = gWs.GetDistrict("%").Tables(0)
        cboRegion.DisplayMember = "district_name"
        cboRegion.ValueMember = "district_name"

        cboIndustry.DataSource = gWs.GetIndustryType("%").Tables(0)
        cboIndustry.DisplayMember = "industry_type"
        cboIndustry.ValueMember = "industry_type"

        'cboTeam.DataSource = gWs.GetTeam("%").Tables(0)
        'cboTeam.DisplayMember = "team_name"
        'cboTeam.ValueMember = "team_name"

        Dim strSql As String = "{not team_name is null}"
        cboPMA.DataSource = gWs.GetStaff(strSql).Tables(0)
        cboPMA.DisplayMember = "staff_name"
        cboPMA.ValueMember = "staff_name"

        cboProprietorship.DataSource = gWs.GetProprietorshipType("%").Tables(0)
        cboProprietorship.DisplayMember = "proprietorship_type"
        cboProprietorship.ValueMember = "proprietorship_type"

        cboPMA.SelectedItem = Nothing
        'cboTeam.SelectedItem = Nothing
        cboRegion.SelectedItem = Nothing
        cboIndustry.SelectedItem = Nothing
        cboServiceType.SelectedItem = Nothing
        cboProprietorship.SelectedItem = Nothing
        'cboCorporationName.SelectedItem = Nothing

        MyBase.ReportTitle = "提交上会项目一览表"
        MyBase.ReportFile = Application.StartupPath + "\Reports\QueryPresentingProject.rpt"
    End Sub

End Class
