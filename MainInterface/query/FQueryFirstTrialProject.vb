Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FQueryFirstTrialProject
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
	Friend WithEvents cboBank As System.Windows.Forms.ComboBox
	Friend WithEvents lblBank As System.Windows.Forms.Label
	Friend WithEvents cboProprietorship As System.Windows.Forms.ComboBox
	Friend WithEvents lblProprietorship As System.Windows.Forms.Label
	Friend WithEvents lblDate As System.Windows.Forms.Label
	Friend WithEvents chkDate As System.Windows.Forms.CheckBox
	Friend WithEvents dtpDateStart As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpDateEnd As System.Windows.Forms.DateTimePicker
	Friend WithEvents tsTable As System.Windows.Forms.DataGridTableStyle
	Friend WithEvents csProjectNo As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csCorporationName As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csApplyServiceType As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csApplySum As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csApplyTerm As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csApplyBank As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csDistrict As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csIndustry As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csProprietorship As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csIsFirst As System.Windows.Forms.DataGridBoolColumn
	Friend WithEvents csRecommendPerson As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csAcceptPerson As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csAcceptDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents iApplyTimes As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboAcceptBranch As System.Windows.Forms.ComboBox
    Friend WithEvents lblAcceptBranch As System.Windows.Forms.Label
    Friend WithEvents branch_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents recommend_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboPMA As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryFirstTrialProject))
        Me.lblProjectNo = New System.Windows.Forms.Label()
        Me.txtProjectNo = New System.Windows.Forms.TextBox()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.cboRegion = New System.Windows.Forms.ComboBox()
        Me.lblRegion = New System.Windows.Forms.Label()
        Me.cboIndustry = New System.Windows.Forms.ComboBox()
        Me.lblIndustry = New System.Windows.Forms.Label()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.cboProprietorship = New System.Windows.Forms.ComboBox()
        Me.lblProprietorship = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.dtpDateStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateEnd = New System.Windows.Forms.DateTimePicker()
        Me.tsTable = New System.Windows.Forms.DataGridTableStyle()
        Me.csProjectNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCorporationName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csApplyServiceType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csApplySum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csApplyTerm = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csApplyBank = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csDistrict = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIndustry = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csProprietorship = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIsFirst = New System.Windows.Forms.DataGridBoolColumn()
        Me.recommend_type = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csRecommendPerson = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csAcceptPerson = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csAcceptDate = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iApplyTimes = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.branch_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.cboAcceptBranch = New System.Windows.Forms.ComboBox()
        Me.lblAcceptBranch = New System.Windows.Forms.Label()
        Me.cboPMA = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboAcceptBranch, Me.lblAcceptBranch, Me.txtCorpName, Me.dtpDateEnd, Me.dtpDateStart, Me.chkDate, Me.lblDate, Me.cboProprietorship, Me.lblProprietorship, Me.cboBank, Me.lblBank, Me.cboIndustry, Me.lblIndustry, Me.cboRegion, Me.lblRegion, Me.cboServiceType, Me.lblServiceType, Me.lblCorporationName, Me.txtProjectNo, Me.lblProjectNo, Me.cboPMA})
        Me.grpCondition.Size = New System.Drawing.Size(696, 120)
        Me.grpCondition.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(616, 144)
        Me.btnExit.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 144)
        Me.chkVisible.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.Location = New System.Drawing.Point(424, 144)
        Me.btnRefresh.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Bitmap)
        Me.btnClear.Location = New System.Drawing.Point(192, 144)
        Me.btnClear.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 184)
        Me.grdTable.Size = New System.Drawing.Size(696, 304)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsTable})
        Me.grdTable.Visible = True
        '
        'ImageListQuery
        '
        Me.ImageListQuery.ImageStream = CType(resources.GetObject("ImageListQuery.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Bitmap)
        Me.btnExport.Location = New System.Drawing.Point(520, 144)
        Me.btnExport.Visible = True
        '
        'lblProjectNo
        '
        Me.lblProjectNo.Location = New System.Drawing.Point(16, 19)
        Me.lblProjectNo.Name = "lblProjectNo"
        Me.lblProjectNo.Size = New System.Drawing.Size(64, 16)
        Me.lblProjectNo.TabIndex = 0
        Me.lblProjectNo.Text = "项目编号"
        '
        'txtProjectNo
        '
        Me.txtProjectNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectNo.Location = New System.Drawing.Point(72, 16)
        Me.txtProjectNo.Name = "txtProjectNo"
        Me.txtProjectNo.Size = New System.Drawing.Size(120, 22)
        Me.txtProjectNo.TabIndex = 1
        Me.txtProjectNo.Text = ""
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Location = New System.Drawing.Point(240, 19)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(64, 16)
        Me.lblCorporationName.TabIndex = 2
        Me.lblCorporationName.Text = "企业名称"
        '
        'cboServiceType
        '
        Me.cboServiceType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServiceType.Location = New System.Drawing.Point(496, 16)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(120, 22)
        Me.cboServiceType.TabIndex = 5
        '
        'lblServiceType
        '
        Me.lblServiceType.Location = New System.Drawing.Point(440, 19)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(64, 16)
        Me.lblServiceType.TabIndex = 4
        Me.lblServiceType.Text = "业务品种"
        '
        'cboRegion
        '
        Me.cboRegion.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRegion.Location = New System.Drawing.Point(72, 40)
        Me.cboRegion.Name = "cboRegion"
        Me.cboRegion.Size = New System.Drawing.Size(120, 22)
        Me.cboRegion.TabIndex = 7
        '
        'lblRegion
        '
        Me.lblRegion.Location = New System.Drawing.Point(16, 43)
        Me.lblRegion.Name = "lblRegion"
        Me.lblRegion.Size = New System.Drawing.Size(64, 16)
        Me.lblRegion.TabIndex = 6
        Me.lblRegion.Text = "所属区域"
        '
        'cboIndustry
        '
        Me.cboIndustry.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIndustry.Location = New System.Drawing.Point(296, 40)
        Me.cboIndustry.Name = "cboIndustry"
        Me.cboIndustry.Size = New System.Drawing.Size(120, 22)
        Me.cboIndustry.TabIndex = 9
        '
        'lblIndustry
        '
        Me.lblIndustry.Location = New System.Drawing.Point(240, 43)
        Me.lblIndustry.Name = "lblIndustry"
        Me.lblIndustry.Size = New System.Drawing.Size(64, 16)
        Me.lblIndustry.TabIndex = 8
        Me.lblIndustry.Text = "所属行业"
        '
        'cboBank
        '
        Me.cboBank.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBank.Location = New System.Drawing.Point(496, 40)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(120, 22)
        Me.cboBank.TabIndex = 11
        '
        'lblBank
        '
        Me.lblBank.Location = New System.Drawing.Point(440, 43)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(64, 16)
        Me.lblBank.TabIndex = 10
        Me.lblBank.Text = "贷款银行"
        '
        'cboProprietorship
        '
        Me.cboProprietorship.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProprietorship.Location = New System.Drawing.Point(72, 63)
        Me.cboProprietorship.Name = "cboProprietorship"
        Me.cboProprietorship.Size = New System.Drawing.Size(120, 22)
        Me.cboProprietorship.TabIndex = 13
        '
        'lblProprietorship
        '
        Me.lblProprietorship.Location = New System.Drawing.Point(8, 66)
        Me.lblProprietorship.Name = "lblProprietorship"
        Me.lblProprietorship.Size = New System.Drawing.Size(72, 16)
        Me.lblProprietorship.TabIndex = 12
        Me.lblProprietorship.Text = "所有制类型"
        '
        'lblDate
        '
        Me.lblDate.Location = New System.Drawing.Point(472, 66)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(16, 16)
        Me.lblDate.TabIndex = 15
        Me.lblDate.Text = "到"
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(224, 64)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(80, 20)
        Me.chkDate.TabIndex = 16
        Me.chkDate.Text = "申请日期"
        '
        'dtpDateStart
        '
        Me.dtpDateStart.Enabled = False
        Me.dtpDateStart.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateStart.Location = New System.Drawing.Point(296, 64)
        Me.dtpDateStart.Name = "dtpDateStart"
        Me.dtpDateStart.Size = New System.Drawing.Size(120, 21)
        Me.dtpDateStart.TabIndex = 17
        '
        'dtpDateEnd
        '
        Me.dtpDateEnd.Enabled = False
        Me.dtpDateEnd.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDateEnd.Location = New System.Drawing.Point(496, 64)
        Me.dtpDateEnd.Name = "dtpDateEnd"
        Me.dtpDateEnd.Size = New System.Drawing.Size(120, 21)
        Me.dtpDateEnd.TabIndex = 18
        '
        'tsTable
        '
        Me.tsTable.DataGrid = Me.grdTable
        Me.tsTable.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csProjectNo, Me.csCorporationName, Me.csApplyServiceType, Me.csApplySum, Me.csApplyTerm, Me.csApplyBank, Me.csDistrict, Me.csIndustry, Me.csProprietorship, Me.csIsFirst, Me.recommend_type, Me.csRecommendPerson, Me.csAcceptPerson, Me.csAcceptDate, Me.iApplyTimes, Me.branch_name})
        Me.tsTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsTable.MappingName = "Table"
        '
        'csProjectNo
        '
        Me.csProjectNo.Format = ""
        Me.csProjectNo.FormatInfo = Nothing
        Me.csProjectNo.HeaderText = "项目编号"
        Me.csProjectNo.MappingName = "project_code"
        Me.csProjectNo.NullText = ""
        Me.csProjectNo.Width = 80
        '
        'csCorporationName
        '
        Me.csCorporationName.Format = ""
        Me.csCorporationName.FormatInfo = Nothing
        Me.csCorporationName.HeaderText = "企业名称"
        Me.csCorporationName.MappingName = "enterprise_name"
        Me.csCorporationName.NullText = ""
        Me.csCorporationName.Width = 150
        '
        'csApplyServiceType
        '
        Me.csApplyServiceType.Format = ""
        Me.csApplyServiceType.FormatInfo = Nothing
        Me.csApplyServiceType.HeaderText = "申请业务品种"
        Me.csApplyServiceType.MappingName = "apply_service_type"
        Me.csApplyServiceType.NullText = ""
        Me.csApplyServiceType.Width = 75
        '
        'csApplySum
        '
        Me.csApplySum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csApplySum.Format = ""
        Me.csApplySum.FormatInfo = Nothing
        Me.csApplySum.HeaderText = "申请担保金额(万元)"
        Me.csApplySum.MappingName = "apply_sum"
        Me.csApplySum.NullText = ""
        Me.csApplySum.Width = 120
        '
        'csApplyTerm
        '
        Me.csApplyTerm.Format = ""
        Me.csApplyTerm.FormatInfo = Nothing
        Me.csApplyTerm.HeaderText = "申请担保期限"
        Me.csApplyTerm.MappingName = "apply_term"
        Me.csApplyTerm.NullText = ""
        Me.csApplyTerm.Width = 80
        '
        'csApplyBank
        '
        Me.csApplyBank.Format = ""
        Me.csApplyBank.FormatInfo = Nothing
        Me.csApplyBank.HeaderText = "申请贷款银行"
        Me.csApplyBank.MappingName = "apply_bank"
        Me.csApplyBank.NullText = ""
        Me.csApplyBank.Width = 75
        '
        'csDistrict
        '
        Me.csDistrict.Format = ""
        Me.csDistrict.FormatInfo = Nothing
        Me.csDistrict.HeaderText = "所属区"
        Me.csDistrict.MappingName = "district_name"
        Me.csDistrict.NullText = ""
        Me.csDistrict.Width = 80
        '
        'csIndustry
        '
        Me.csIndustry.Format = ""
        Me.csIndustry.FormatInfo = Nothing
        Me.csIndustry.HeaderText = "所属行业"
        Me.csIndustry.MappingName = "industry_type"
        Me.csIndustry.NullText = ""
        Me.csIndustry.Width = 80
        '
        'csProprietorship
        '
        Me.csProprietorship.Format = ""
        Me.csProprietorship.FormatInfo = Nothing
        Me.csProprietorship.HeaderText = "所有制类型"
        Me.csProprietorship.MappingName = "proprietorship_type"
        Me.csProprietorship.NullText = ""
        Me.csProprietorship.Width = 120
        '
        'csIsFirst
        '
        Me.csIsFirst.FalseValue = False
        Me.csIsFirst.HeaderText = "首次贷款"
        Me.csIsFirst.MappingName = "is_first_loan"
        Me.csIsFirst.NullText = ""
        Me.csIsFirst.NullValue = CType(resources.GetObject("csIsFirst.NullValue"), System.DBNull)
        Me.csIsFirst.TrueValue = True
        Me.csIsFirst.Width = 60
        '
        'recommend_type
        '
        Me.recommend_type.Format = ""
        Me.recommend_type.FormatInfo = Nothing
        Me.recommend_type.HeaderText = "推荐类型"
        Me.recommend_type.MappingName = "recommend_type"
        Me.recommend_type.NullText = ""
        Me.recommend_type.Width = 75
        '
        'csRecommendPerson
        '
        Me.csRecommendPerson.Format = ""
        Me.csRecommendPerson.FormatInfo = Nothing
        Me.csRecommendPerson.HeaderText = "推荐人"
        Me.csRecommendPerson.MappingName = "recommend_person"
        Me.csRecommendPerson.NullText = ""
        Me.csRecommendPerson.Width = 75
        '
        'csAcceptPerson
        '
        Me.csAcceptPerson.Format = ""
        Me.csAcceptPerson.FormatInfo = Nothing
        Me.csAcceptPerson.HeaderText = "受理人员"
        Me.csAcceptPerson.MappingName = "accept_person"
        Me.csAcceptPerson.NullText = ""
        Me.csAcceptPerson.Width = 80
        '
        'csAcceptDate
        '
        Me.csAcceptDate.Format = "yyyy-MM-dd"
        Me.csAcceptDate.FormatInfo = Nothing
        Me.csAcceptDate.HeaderText = "申请日期"
        Me.csAcceptDate.MappingName = "accept_date"
        Me.csAcceptDate.NullText = ""
        Me.csAcceptDate.Width = 75
        '
        'iApplyTimes
        '
        Me.iApplyTimes.Format = ""
        Me.iApplyTimes.FormatInfo = Nothing
        Me.iApplyTimes.HeaderText = "申请次数"
        Me.iApplyTimes.MappingName = "iApplyTimes"
        Me.iApplyTimes.NullText = ""
        Me.iApplyTimes.Width = 75
        '
        'branch_name
        '
        Me.branch_name.Format = ""
        Me.branch_name.FormatInfo = Nothing
        Me.branch_name.HeaderText = "受理部门"
        Me.branch_name.MappingName = "branch_name"
        Me.branch_name.NullText = ""
        Me.branch_name.Width = 75
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(296, 17)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(120, 21)
        Me.txtCorpName.TabIndex = 19
        Me.txtCorpName.Text = ""
        '
        'cboAcceptBranch
        '
        Me.cboAcceptBranch.DisplayMember = "branch_name"
        Me.cboAcceptBranch.Location = New System.Drawing.Point(72, 88)
        Me.cboAcceptBranch.MaxLength = 20
        Me.cboAcceptBranch.Name = "cboAcceptBranch"
        Me.cboAcceptBranch.Size = New System.Drawing.Size(120, 20)
        Me.cboAcceptBranch.TabIndex = 37
        Me.cboAcceptBranch.ValueMember = "branch_name"
        '
        'lblAcceptBranch
        '
        Me.lblAcceptBranch.Location = New System.Drawing.Point(16, 90)
        Me.lblAcceptBranch.Name = "lblAcceptBranch"
        Me.lblAcceptBranch.Size = New System.Drawing.Size(64, 16)
        Me.lblAcceptBranch.TabIndex = 36
        Me.lblAcceptBranch.Text = "受理分部"
        '
        'cboPMA
        '
        Me.cboPMA.DisplayMember = "staff_name"
        Me.cboPMA.Location = New System.Drawing.Point(296, 88)
        Me.cboPMA.MaxLength = 10
        Me.cboPMA.Name = "cboPMA"
        Me.cboPMA.Size = New System.Drawing.Size(120, 20)
        Me.cboPMA.TabIndex = 111
        Me.cboPMA.ValueMember = "staff_name"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(248, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "受理人员"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FQueryFirstTrialProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label8, Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryFirstTrialProject"
        Me.Text = "申请项目一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dtStaff As DataTable

    Protected Overloads Sub GetCondition(ByRef projectNo As String, ByRef corporationName As String, ByRef serviceType As String, ByRef regionName As String, ByRef industryName As String, ByRef bankName As String, ByRef proprietorshipType As String, ByRef startDate As Object, ByRef endDate As Object, ByRef strAcceptBranch As String, ByRef strPMA As String)
        projectNo = IIf(txtProjectNo.Text.Trim() = "", "", txtProjectNo.Text)
        corporationName = IIf(txtCorpName.Text.Trim() = "", "", txtCorpName.Text)
        serviceType = IIf(cboServiceType.Text.Trim() = "", "", cboServiceType.Text)
        regionName = IIf(cboRegion.Text.Trim() = "", "", cboRegion.Text)
        industryName = IIf(cboIndustry.Text.Trim() = "", "", cboIndustry.Text)
        bankName = IIf(cboBank.Text.Trim() = "", "", cboBank.Text)
        proprietorshipType = IIf(cboProprietorship.Text.Trim() = "", "", cboProprietorship.Text)
        startDate = IIf(chkDate.Checked, dtpDateStart.Value.Date, Nothing)
        endDate = IIf(chkDate.Checked, dtpDateEnd.Value.Date, Nothing)
        strPMA = cboPMA.Text.Trim

        If cboAcceptBranch.Visible = True Then
            strAcceptBranch = Trim(cboAcceptBranch.Text)
        Else
            strAcceptBranch = ""
        End If

    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim projectNo, corporationName, serviceType, regionName, industryName, bankName, proprietorshipType, strAcceptBranch, strPMA As String
        Dim startDate, endDate As Object
        Dim i As Integer
        Dim iTotalSum As Decimal
        Dim dtResult As DataTable

        GetCondition(projectNo, corporationName, serviceType, regionName, industryName, bankName, proprietorshipType, startDate, endDate, strAcceptBranch, strPMA)

        dtResult = gWs.PQueryFirstTrialProject(projectNo, corporationName, serviceType, startDate, endDate, bankName, regionName, industryName, proprietorshipType, strAcceptBranch, strPMA, UserName).Tables(0)

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

        'dsResult.Tables("Table").TableName = "TQueryFirstTrialProject"

        MyBase.DataSource = dtResult
        grdTable.DataSource = dtResult
        'grdTable.SetDataBinding(dsResult, "TQueryFirstTrialProject")
        Me.Text = "申请项目一览表" '(" + dsResult.Tables("TQueryFirstTrialProject").Rows.Count.ToString + ")"
    End Sub

    Private Sub TextEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProjectNo.Enter, cboBank.Enter, cboRegion.Enter, cboIndustry.Enter, cboServiceType.Enter, cboProprietorship.Enter
        If (Not sender Is Nothing) AndAlso sender.GetType() Is GetType(TextBox) Then
            CType(sender, TextBox).SelectAll()
        End If
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        dtpDateStart.Enabled = chkDate.Checked
        dtpDateEnd.Enabled = chkDate.Checked
    End Sub

    Private Sub FQueryFirstTrialProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        'cboBank.DataSource = gWs.GetBankInfo("{0=0 order by bank_name}", "%").Tables(0)
        'qxd modify 2005-10-21 通过存储实现了按名称升序排序
        cboBank.DataSource = gWs.GetBankInfo("%", "%").Tables(0)
        cboBank.DisplayMember = "bank_name"
        cboBank.ValueMember = "bank_name"

        cboProprietorship.DataSource = gWs.GetProprietorshipType("%").Tables(0)
        cboProprietorship.DisplayMember = "proprietorship_type"
        cboProprietorship.ValueMember = "proprietorship_type"

        cboPMA.DataSource = gWs.GetStaff("%").Tables(0)

        ' Added by Andy on 12/3/2003,to list the accepted part
        Dim dtAcceptBranch As DataTable = gWs.GetBranch("{is_island=1}").Tables(0)
        If dtAcceptBranch.Rows.Count > 1 Then
            lblAcceptBranch.Visible = True
            cboAcceptBranch.Visible = True
            cboAcceptBranch.DataSource = dtAcceptBranch
            grdTable.TableStyles(0).GridColumnStyles("branch_name").Width = 75
        Else
            lblAcceptBranch.Visible = False
            cboAcceptBranch.Visible = False
            grdTable.TableStyles(0).GridColumnStyles("branch_name").Width = 0
        End If
        ' Ended by Andy

        cboBank.SelectedItem = Nothing
        cboRegion.SelectedItem = Nothing
        cboIndustry.SelectedItem = Nothing
        cboServiceType.SelectedItem = Nothing
        cboProprietorship.SelectedItem = Nothing
        cboPMA.SelectedItem = Nothing

        MyBase.ReportTitle = "申请项目一览表"
        MyBase.ReportFile = Application.StartupPath + "\Reports\QueryFirstTrialProject.rpt"

        AddHandler cboPMA.SelectedValueChanged, AddressOf cmbStaffSelectedValueChanged
    End Sub

    Protected Overrides Sub Export()
        ReportToExcel.ToExcel(grdTable, "申请项目一览表", "申请项目一览表")
    End Sub

    Private Sub cmbStaffSelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If dtStaff Is Nothing Then
            Try
                dtStaff = gWs.GetStaff("%").Tables(0)
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If

        Try
            Dim strFilter As String = "staff_name='" & Me.cboPMA.Text.Trim & "'"
            Dim dr() As DataRow = dtStaff.Select(strFilter)
            If dr.Length > 0 Then
                Me.cboAcceptBranch.Text = dr(0).Item("branch_name")
            Else
                Me.cboAcceptBranch.Text = ""
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
End Class
