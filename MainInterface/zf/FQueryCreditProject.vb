Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FQueryCreditProject
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
	Friend WithEvents cboBank As System.Windows.Forms.ComboBox
	Friend WithEvents lblBank As System.Windows.Forms.Label
	Friend WithEvents cboBranch As System.Windows.Forms.ComboBox
	Friend WithEvents lblBranch As System.Windows.Forms.Label
	Friend WithEvents cboPMA As System.Windows.Forms.ComboBox
	Friend WithEvents lblPMA As System.Windows.Forms.Label
	Friend WithEvents tsTable As System.Windows.Forms.DataGridTableStyle
	Friend WithEvents csProjectNo As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csCorporationName As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csServiceType As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csPMA As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csPMB As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csGuaranteeSum As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csStartDate As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csEndDate As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csBank As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csBankBranch As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csRefundType As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csPaymentTotal As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csSurplusTotal As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csClass As System.Windows.Forms.DataGridTextBoxColumn
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.lblProjectNo = New System.Windows.Forms.Label()
		Me.txtProjectNo = New System.Windows.Forms.TextBox()
		Me.lblCorporationName = New System.Windows.Forms.Label()
		Me.cboCorporationName = New System.Windows.Forms.ComboBox()
		Me.cboServiceType = New System.Windows.Forms.ComboBox()
		Me.lblServiceType = New System.Windows.Forms.Label()
		Me.cboBank = New System.Windows.Forms.ComboBox()
		Me.lblBank = New System.Windows.Forms.Label()
		Me.cboPMA = New System.Windows.Forms.ComboBox()
		Me.lblPMA = New System.Windows.Forms.Label()
		Me.cboBranch = New System.Windows.Forms.ComboBox()
		Me.lblBranch = New System.Windows.Forms.Label()
		Me.tsTable = New System.Windows.Forms.DataGridTableStyle()
		Me.csProjectNo = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csCorporationName = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csServiceType = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csPMA = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csPMB = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csGuaranteeSum = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csStartDate = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csEndDate = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csBank = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csBankBranch = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csRefundType = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csPaymentTotal = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csSurplusTotal = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csClass = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.grpCondition.SuspendLayout()
		CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'chkVisible
		'
		Me.chkVisible.Location = New System.Drawing.Point(8, 88)
		Me.chkVisible.Visible = True
		'
		'btnPrint
		'
		Me.btnPrint.Location = New System.Drawing.Point(512, 88)
		Me.btnPrint.Visible = True
		'
		'grpCondition
		'
		Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboBranch, Me.lblBranch, Me.cboPMA, Me.lblPMA, Me.cboBank, Me.lblBank, Me.cboServiceType, Me.lblServiceType, Me.cboCorporationName, Me.lblCorporationName, Me.txtProjectNo, Me.lblProjectNo})
		Me.grpCondition.Size = New System.Drawing.Size(696, 72)
		Me.grpCondition.Visible = True
		'
		'btnRefresh
		'
		Me.btnRefresh.Location = New System.Drawing.Point(304, 88)
		Me.btnRefresh.Visible = True
		'
		'btnExit
		'
		Me.btnExit.Location = New System.Drawing.Point(616, 88)
		Me.btnExit.Visible = True
		'
		'grdTable
		'
		Me.grdTable.AccessibleName = "DataGrid"
		Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
		Me.grdTable.Location = New System.Drawing.Point(8, 120)
		Me.grdTable.Size = New System.Drawing.Size(696, 368)
		Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsTable})
		Me.grdTable.Visible = True
		'
		'btnClear
		'
		Me.btnClear.Location = New System.Drawing.Point(192, 88)
		Me.btnClear.Visible = True
		'
		'btnExport
		'
		Me.btnExport.Location = New System.Drawing.Point(408, 88)
		Me.btnExport.Visible = True
		'
		'lblProjectNo
		'
		Me.lblProjectNo.Location = New System.Drawing.Point(16, 24)
		Me.lblProjectNo.Name = "lblProjectNo"
		Me.lblProjectNo.Size = New System.Drawing.Size(64, 16)
		Me.lblProjectNo.TabIndex = 0
		Me.lblProjectNo.Text = "项目编号"
		'
		'txtProjectNo
		'
		Me.txtProjectNo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtProjectNo.Location = New System.Drawing.Point(80, 16)
		Me.txtProjectNo.Name = "txtProjectNo"
		Me.txtProjectNo.Size = New System.Drawing.Size(120, 22)
		Me.txtProjectNo.TabIndex = 1
		Me.txtProjectNo.Text = ""
		'
		'lblCorporationName
		'
		Me.lblCorporationName.Location = New System.Drawing.Point(256, 24)
		Me.lblCorporationName.Name = "lblCorporationName"
		Me.lblCorporationName.Size = New System.Drawing.Size(64, 16)
		Me.lblCorporationName.TabIndex = 2
		Me.lblCorporationName.Text = "企业名称"
		'
		'cboCorporationName
		'
		Me.cboCorporationName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboCorporationName.Location = New System.Drawing.Point(320, 16)
		Me.cboCorporationName.Name = "cboCorporationName"
		Me.cboCorporationName.Size = New System.Drawing.Size(120, 22)
		Me.cboCorporationName.TabIndex = 3
		'
		'cboServiceType
		'
		Me.cboServiceType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboServiceType.Location = New System.Drawing.Point(560, 16)
		Me.cboServiceType.Name = "cboServiceType"
		Me.cboServiceType.Size = New System.Drawing.Size(120, 22)
		Me.cboServiceType.TabIndex = 5
		'
		'lblServiceType
		'
		Me.lblServiceType.Location = New System.Drawing.Point(496, 24)
		Me.lblServiceType.Name = "lblServiceType"
		Me.lblServiceType.Size = New System.Drawing.Size(64, 16)
		Me.lblServiceType.TabIndex = 4
		Me.lblServiceType.Text = "业务品种"
		'
		'cboBank
		'
		Me.cboBank.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboBank.Location = New System.Drawing.Point(80, 40)
		Me.cboBank.Name = "cboBank"
		Me.cboBank.Size = New System.Drawing.Size(120, 22)
		Me.cboBank.TabIndex = 11
		'
		'lblBank
		'
		Me.lblBank.Location = New System.Drawing.Point(16, 48)
		Me.lblBank.Name = "lblBank"
		Me.lblBank.Size = New System.Drawing.Size(64, 16)
		Me.lblBank.TabIndex = 10
		Me.lblBank.Text = "贷款银行"
		'
		'cboPMA
		'
		Me.cboPMA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboPMA.Location = New System.Drawing.Point(560, 40)
		Me.cboPMA.Name = "cboPMA"
		Me.cboPMA.Size = New System.Drawing.Size(120, 22)
		Me.cboPMA.TabIndex = 13
		'
		'lblPMA
		'
		Me.lblPMA.Location = New System.Drawing.Point(496, 48)
		Me.lblPMA.Name = "lblPMA"
		Me.lblPMA.Size = New System.Drawing.Size(64, 16)
		Me.lblPMA.TabIndex = 12
		Me.lblPMA.Text = "项目经理A"
		'
		'cboBranch
		'
		Me.cboBranch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboBranch.Location = New System.Drawing.Point(320, 40)
		Me.cboBranch.Name = "cboBranch"
		Me.cboBranch.Size = New System.Drawing.Size(120, 22)
		Me.cboBranch.TabIndex = 20
		'
		'lblBranch
		'
		Me.lblBranch.Location = New System.Drawing.Point(256, 48)
		Me.lblBranch.Name = "lblBranch"
		Me.lblBranch.Size = New System.Drawing.Size(64, 16)
		Me.lblBranch.TabIndex = 19
		Me.lblBranch.Text = "贷款支行"
		'
		'tsTable
		'
		Me.tsTable.DataGrid = Me.grdTable
		Me.tsTable.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csProjectNo, Me.csCorporationName, Me.csServiceType, Me.csPMA, Me.csPMB, Me.csGuaranteeSum, Me.csStartDate, Me.csEndDate, Me.csBank, Me.csBankBranch, Me.csRefundType, Me.csPaymentTotal, Me.csSurplusTotal, Me.csClass})
		Me.tsTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.tsTable.MappingName = "TQueryCreditProject"
		'
		'csProjectNo
		'
		Me.csProjectNo.Format = ""
		Me.csProjectNo.FormatInfo = Nothing
		Me.csProjectNo.HeaderText = "项目编号"
		Me.csProjectNo.MappingName = "project_code"
		Me.csProjectNo.Width = 80
		'
		'csCorporationName
		'
		Me.csCorporationName.Format = ""
		Me.csCorporationName.FormatInfo = Nothing
		Me.csCorporationName.HeaderText = "企业名称"
		Me.csCorporationName.MappingName = "enterprise_name"
		Me.csCorporationName.Width = 200
		'
		'csServiceType
		'
		Me.csServiceType.Format = ""
		Me.csServiceType.FormatInfo = Nothing
		Me.csServiceType.HeaderText = "业务品种"
		Me.csServiceType.MappingName = "service_type"
		Me.csServiceType.Width = 120
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
		'csGuaranteeSum
		'
		Me.csGuaranteeSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.csGuaranteeSum.Format = ""
		Me.csGuaranteeSum.FormatInfo = Nothing
		Me.csGuaranteeSum.HeaderText = "担保金额"
		Me.csGuaranteeSum.MappingName = "guarantee_sum"
		Me.csGuaranteeSum.Width = 80
		'
		'csStartDate
		'
		Me.csStartDate.Format = "D"
		Me.csStartDate.FormatInfo = Nothing
		Me.csStartDate.HeaderText = "承保期起"
		Me.csStartDate.MappingName = "start_date"
		Me.csStartDate.Width = 90
		'
		'csEndDate
		'
		Me.csEndDate.Format = "D"
		Me.csEndDate.FormatInfo = Nothing
		Me.csEndDate.HeaderText = "承保期止"
		Me.csEndDate.MappingName = "end_date"
		Me.csEndDate.Width = 90
		'
		'csBank
		'
		Me.csBank.Format = ""
		Me.csBank.FormatInfo = Nothing
		Me.csBank.HeaderText = "贷款银行"
		Me.csBank.MappingName = "bank"
		Me.csBank.Width = 100
		'
		'csBankBranch
		'
		Me.csBankBranch.Format = ""
		Me.csBankBranch.FormatInfo = Nothing
		Me.csBankBranch.HeaderText = "贷款支行"
		Me.csBankBranch.MappingName = "branch_bank"
		Me.csBankBranch.Width = 120
		'
		'csRefundType
		'
		Me.csRefundType.Format = ""
		Me.csRefundType.FormatInfo = Nothing
		Me.csRefundType.HeaderText = "还款方式"
		Me.csRefundType.MappingName = "refund_type"
		Me.csRefundType.Width = 80
		'
		'csPaymentTotal
		'
		Me.csPaymentTotal.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.csPaymentTotal.Format = ""
		Me.csPaymentTotal.FormatInfo = Nothing
		Me.csPaymentTotal.HeaderText = "累计还款金额"
		Me.csPaymentTotal.MappingName = "payment_total"
		Me.csPaymentTotal.Width = 80
		'
		'csSurplusTotal
		'
		Me.csSurplusTotal.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.csSurplusTotal.Format = ""
		Me.csSurplusTotal.FormatInfo = Nothing
		Me.csSurplusTotal.HeaderText = "在保余额"
		Me.csSurplusTotal.MappingName = "surplus_total"
		Me.csSurplusTotal.Width = 80
		'
		'csClass
		'
		Me.csClass.Format = ""
		Me.csClass.FormatInfo = Nothing
		Me.csClass.HeaderText = "项目评价"
		Me.csClass.MappingName = "class"
		Me.csClass.Width = 150
		'
		'FQueryCreditProject
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.ClientSize = New System.Drawing.Size(712, 493)
		Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
		Me.Name = "FQueryCreditProject"
		Me.Text = "在保项目一览表"
		Me.grpCondition.ResumeLayout(False)
		CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

#End Region

	Protected Overloads Sub GetCondition(ByRef projectNo As String, ByRef corporationName As String, ByRef serviceType As String, ByRef bankName As String, ByRef branchName As String, ByRef PMA As String)
		projectNo = IIf(txtProjectNo.Text.Trim() = "", "", txtProjectNo.Text)
		corporationName = IIf(cboCorporationName.Text.Trim() = "", "", cboCorporationName.Text)
		serviceType = IIf(cboServiceType.Text.Trim() = "", "", cboServiceType.Text)
		PMA = IIf(cboPMA.Text.Trim() = "", "", cboPMA.Text)
		bankName = IIf(cboBank.Text.Trim() = "", "", cboBank.Text)
		branchName = IIf(cboBranch.Text.Trim() = "", "", cboBranch.Text)
	End Sub

	Protected Overloads Overrides Sub Refresh(ByVal condition As String)
		Dim projectNo, corporationName, serviceType, bankName, branchName, PMA As String

		GetCondition(projectNo, corporationName, serviceType, bankName, branchName, PMA)

		Dim dsResult As DataSet = gWs.FQueryCreditProject(projectNo, corporationName, serviceType, gWs.GetSysTime(), PMA, bankName, branchName)

		dsResult.Tables("Table").TableName = "TQueryCreditProject"

		MyBase.DataSource = dsResult
		grdTable.DataSource = dsResult
		grdTable.SetDataBinding(dsResult, "TQueryCreditProject")
		Me.Text = "在保项目一览表(" + dsResult.Tables("TQueryCreditProject").Rows.Count.ToString + ")"
	End Sub

	Private Sub TextEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProjectNo.Enter, cboCorporationName.Enter, cboBank.Enter, cboServiceType.Enter, cboPMA.Enter
		If (Not sender Is Nothing) AndAlso sender.GetType() Is GetType(TextBox) Then
			CType(sender, TextBox).SelectAll()
		End If
	End Sub

	Private Sub FQueryCreditProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		cboCorporationName.DataSource = gWs.GetcorporationInfo("%", "%").Tables(0)
		cboCorporationName.DisplayMember = "corporation_name"
		cboCorporationName.ValueMember = "corporation_name"

		cboServiceType.DataSource = gWs.GetServiceType("%").Tables(0)
		cboServiceType.DisplayMember = "service_type"
		cboServiceType.ValueMember = "service_type"

		cboPMA.DataSource = gWs.GetStaff("%").Tables(0)
		cboPMA.DisplayMember = "staff_name"
		cboPMA.ValueMember = "staff_name"

		cboBank.DataSource = gWs.GetBankInfo("%", "%").Tables(0)
		cboBank.DisplayMember = "bank_name"
		cboBank.ValueMember = "bank_name"

		cboBranch.DataSource = gWs.GetBankInfo("NULL", "%").Tables("bank_branch")
		cboBranch.DisplayMember = "branch_bank_name"
		cboBranch.ValueMember = "branch_bank_name"

		cboPMA.SelectedItem = Nothing
		cboBank.SelectedItem = Nothing
		cboBranch.SelectedItem = Nothing
		cboServiceType.SelectedItem = Nothing
		cboCorporationName.SelectedItem = Nothing

		MyBase.ReportTitle = "在保项目一览表"
		MyBase.ReportFile = Application.StartupPath + "\Reports\QueryCreditProject.rpt"
	End Sub
End Class
