Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FQueryCreditProject
    Inherits FQueryBase
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
	Friend WithEvents lblProjectNo As System.Windows.Forms.Label
	Friend WithEvents txtProjectNo As System.Windows.Forms.TextBox
	Friend WithEvents lblCorporationName As System.Windows.Forms.Label
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents lblServiceType As System.Windows.Forms.Label
	Friend WithEvents cboBank As System.Windows.Forms.ComboBox
	Friend WithEvents lblBank As System.Windows.Forms.Label
	Friend WithEvents cboBranch As System.Windows.Forms.ComboBox
	Friend WithEvents lblBranch As System.Windows.Forms.Label
	Friend WithEvents cboPMA As System.Windows.Forms.ComboBox
	Friend WithEvents lblPMA As System.Windows.Forms.Label
	Friend WithEvents tsTable As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csClass As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents alarm_type_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents hasAppraised As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents project_code As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents enterprise_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents service_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_a As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_b As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents guarantee_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents start_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents end_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents bank As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents branch_bank As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents refund_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents payment_total As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents surplus_total As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents branch_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents status As DataGridTextBoxColumn       '2005-1-4 by 9sky
    Friend WithEvents industry_type As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryCreditProject))
        Me.lblProjectNo = New System.Windows.Forms.Label
        Me.txtProjectNo = New System.Windows.Forms.TextBox
        Me.lblCorporationName = New System.Windows.Forms.Label
        Me.cboServiceType = New System.Windows.Forms.ComboBox
        Me.lblServiceType = New System.Windows.Forms.Label
        Me.cboBank = New System.Windows.Forms.ComboBox
        Me.lblBank = New System.Windows.Forms.Label
        Me.cboPMA = New System.Windows.Forms.ComboBox
        Me.lblPMA = New System.Windows.Forms.Label
        Me.cboBranch = New System.Windows.Forms.ComboBox
        Me.lblBranch = New System.Windows.Forms.Label
        Me.tsTable = New System.Windows.Forms.DataGridTableStyle
        Me.project_code = New System.Windows.Forms.DataGridTextBoxColumn
        Me.enterprise_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.service_type = New System.Windows.Forms.DataGridTextBoxColumn
        Me.manager_a = New System.Windows.Forms.DataGridTextBoxColumn
        Me.manager_b = New System.Windows.Forms.DataGridTextBoxColumn
        Me.guarantee_sum = New System.Windows.Forms.DataGridTextBoxColumn
        Me.start_date = New System.Windows.Forms.DataGridTextBoxColumn
        Me.end_date = New System.Windows.Forms.DataGridTextBoxColumn
        Me.bank = New System.Windows.Forms.DataGridTextBoxColumn
        Me.branch_bank = New System.Windows.Forms.DataGridTextBoxColumn
        Me.refund_type = New System.Windows.Forms.DataGridTextBoxColumn
        Me.payment_total = New System.Windows.Forms.DataGridTextBoxColumn
        Me.surplus_total = New System.Windows.Forms.DataGridTextBoxColumn
        Me.status = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csClass = New System.Windows.Forms.DataGridTextBoxColumn
        Me.alarm_type_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.hasAppraised = New System.Windows.Forms.DataGridBoolColumn
        Me.branch_name = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtCorpName = New System.Windows.Forms.TextBox
        Me.industry_type = New System.Windows.Forms.DataGridTextBoxColumn
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Image)
        Me.btnClear.ImageIndex = -1
        Me.btnClear.ImageList = Nothing
        Me.btnClear.Location = New System.Drawing.Point(192, 104)
        Me.btnClear.Name = "btnClear"
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(512, 88)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(616, 104)
        Me.btnExit.Name = "btnExit"
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Image)
        Me.btnExport.ImageIndex = -1
        Me.btnExport.ImageList = Nothing
        Me.btnExport.Location = New System.Drawing.Point(520, 104)
        Me.btnExport.Name = "btnExport"
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Name = "grdTable"
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsTable})
        '
        'ImageListQuery
        '
        Me.ImageListQuery.ImageStream = CType(resources.GetObject("ImageListQuery.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'grpCondition
        '
        Me.grpCondition.Controls.Add(Me.txtCorpName)
        Me.grpCondition.Controls.Add(Me.txtProjectNo)
        Me.grpCondition.Controls.Add(Me.cboBranch)
        Me.grpCondition.Controls.Add(Me.lblBranch)
        Me.grpCondition.Controls.Add(Me.cboPMA)
        Me.grpCondition.Controls.Add(Me.lblPMA)
        Me.grpCondition.Controls.Add(Me.cboBank)
        Me.grpCondition.Controls.Add(Me.lblBank)
        Me.grpCondition.Controls.Add(Me.cboServiceType)
        Me.grpCondition.Controls.Add(Me.lblServiceType)
        Me.grpCondition.Controls.Add(Me.lblCorporationName)
        Me.grpCondition.Controls.Add(Me.lblProjectNo)
        Me.grpCondition.Name = "grpCondition"
        Me.grpCondition.Size = New System.Drawing.Size(696, 80)
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 104)
        Me.chkVisible.Name = "chkVisible"
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Image)
        Me.btnRefresh.ImageIndex = -1
        Me.btnRefresh.ImageList = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(424, 104)
        Me.btnRefresh.Name = "btnRefresh"
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
        Me.txtProjectNo.Location = New System.Drawing.Point(72, 16)
        Me.txtProjectNo.Name = "txtProjectNo"
        Me.txtProjectNo.Size = New System.Drawing.Size(120, 22)
        Me.txtProjectNo.TabIndex = 1
        Me.txtProjectNo.Text = ""
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Location = New System.Drawing.Point(216, 24)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(64, 16)
        Me.lblCorporationName.TabIndex = 2
        Me.lblCorporationName.Text = "企业名称"
        '
        'cboServiceType
        '
        Me.cboServiceType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServiceType.Location = New System.Drawing.Point(480, 16)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(120, 22)
        Me.cboServiceType.TabIndex = 5
        '
        'lblServiceType
        '
        Me.lblServiceType.Location = New System.Drawing.Point(424, 24)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(56, 16)
        Me.lblServiceType.TabIndex = 4
        Me.lblServiceType.Text = "业务品种"
        '
        'cboBank
        '
        Me.cboBank.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBank.Location = New System.Drawing.Point(72, 40)
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
        Me.cboPMA.Location = New System.Drawing.Point(480, 40)
        Me.cboPMA.Name = "cboPMA"
        Me.cboPMA.Size = New System.Drawing.Size(120, 22)
        Me.cboPMA.TabIndex = 13
        '
        'lblPMA
        '
        Me.lblPMA.Location = New System.Drawing.Point(416, 48)
        Me.lblPMA.Name = "lblPMA"
        Me.lblPMA.Size = New System.Drawing.Size(64, 16)
        Me.lblPMA.TabIndex = 12
        Me.lblPMA.Text = "项目经理A"
        '
        'cboBranch
        '
        Me.cboBranch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBranch.Location = New System.Drawing.Point(272, 40)
        Me.cboBranch.Name = "cboBranch"
        Me.cboBranch.Size = New System.Drawing.Size(120, 22)
        Me.cboBranch.TabIndex = 20
        '
        'lblBranch
        '
        Me.lblBranch.Location = New System.Drawing.Point(216, 48)
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Size = New System.Drawing.Size(64, 16)
        Me.lblBranch.TabIndex = 19
        Me.lblBranch.Text = "贷款支行"
        '
        'tsTable
        '
        Me.tsTable.DataGrid = Me.grdTable
        Me.tsTable.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.project_code, Me.enterprise_name, Me.industry_type, Me.service_type, Me.manager_a, Me.manager_b, Me.guarantee_sum, Me.start_date, Me.end_date, Me.bank, Me.branch_bank, Me.refund_type, Me.payment_total, Me.surplus_total, Me.status, Me.csClass, Me.alarm_type_name, Me.hasAppraised, Me.branch_name})
        Me.tsTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsTable.MappingName = "Table"
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
        Me.service_type.Width = 120
        '
        'manager_a
        '
        Me.manager_a.Format = ""
        Me.manager_a.FormatInfo = Nothing
        Me.manager_a.HeaderText = "项目经理A"
        Me.manager_a.MappingName = "manager_a"
        Me.manager_a.NullText = ""
        Me.manager_a.Width = 80
        '
        'manager_b
        '
        Me.manager_b.Format = ""
        Me.manager_b.FormatInfo = Nothing
        Me.manager_b.HeaderText = "项目经理B"
        Me.manager_b.MappingName = "manager_b"
        Me.manager_b.NullText = ""
        Me.manager_b.Width = 80
        '
        'guarantee_sum
        '
        Me.guarantee_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.guarantee_sum.Format = ""
        Me.guarantee_sum.FormatInfo = Nothing
        Me.guarantee_sum.HeaderText = "担保金额"
        Me.guarantee_sum.MappingName = "guarantee_sum"
        Me.guarantee_sum.NullText = ""
        Me.guarantee_sum.Width = 75
        '
        'start_date
        '
        Me.start_date.Format = "yyyy-MM-dd"
        Me.start_date.FormatInfo = Nothing
        Me.start_date.HeaderText = "承保期起"
        Me.start_date.MappingName = "start_date"
        Me.start_date.NullText = ""
        Me.start_date.Width = 75
        '
        'end_date
        '
        Me.end_date.Format = "yyyy-MM-dd"
        Me.end_date.FormatInfo = Nothing
        Me.end_date.HeaderText = "承保期止"
        Me.end_date.MappingName = "end_date"
        Me.end_date.NullText = ""
        Me.end_date.Width = 75
        '
        'bank
        '
        Me.bank.Format = ""
        Me.bank.FormatInfo = Nothing
        Me.bank.HeaderText = "贷款银行"
        Me.bank.MappingName = "bank"
        Me.bank.NullText = ""
        Me.bank.Width = 75
        '
        'branch_bank
        '
        Me.branch_bank.Format = ""
        Me.branch_bank.FormatInfo = Nothing
        Me.branch_bank.HeaderText = "贷款支行"
        Me.branch_bank.MappingName = "branch_bank"
        Me.branch_bank.NullText = ""
        Me.branch_bank.Width = 120
        '
        'refund_type
        '
        Me.refund_type.Format = ""
        Me.refund_type.FormatInfo = Nothing
        Me.refund_type.HeaderText = "还款方式"
        Me.refund_type.MappingName = "refund_type"
        Me.refund_type.NullText = ""
        Me.refund_type.Width = 80
        '
        'payment_total
        '
        Me.payment_total.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.payment_total.Format = ""
        Me.payment_total.FormatInfo = Nothing
        Me.payment_total.HeaderText = "累计还款金额"
        Me.payment_total.MappingName = "payment_total"
        Me.payment_total.NullText = ""
        Me.payment_total.Width = 120
        '
        'surplus_total
        '
        Me.surplus_total.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.surplus_total.Format = ""
        Me.surplus_total.FormatInfo = Nothing
        Me.surplus_total.HeaderText = "在保余额"
        Me.surplus_total.MappingName = "surplus_total"
        Me.surplus_total.NullText = ""
        Me.surplus_total.Width = 75
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
        'csClass
        '
        Me.csClass.Format = ""
        Me.csClass.FormatInfo = Nothing
        Me.csClass.HeaderText = "项目评价"
        Me.csClass.MappingName = "class"
        Me.csClass.NullText = ""
        Me.csClass.Width = 150
        '
        'alarm_type_name
        '
        Me.alarm_type_name.Format = ""
        Me.alarm_type_name.FormatInfo = Nothing
        Me.alarm_type_name.HeaderText = "风险等级"
        Me.alarm_type_name.MappingName = "alarm_type_name"
        Me.alarm_type_name.NullText = ""
        Me.alarm_type_name.Width = 120
        '
        'hasAppraised
        '
        Me.hasAppraised.FalseValue = False
        Me.hasAppraised.HeaderText = "是否评价"
        Me.hasAppraised.MappingName = "hasAppraised"
        Me.hasAppraised.NullText = ""
        Me.hasAppraised.NullValue = CType(resources.GetObject("hasAppraised.NullValue"), Object)
        Me.hasAppraised.TrueValue = True
        Me.hasAppraised.Width = 75
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
        Me.txtCorpName.Location = New System.Drawing.Point(272, 16)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(120, 21)
        Me.txtCorpName.TabIndex = 21
        Me.txtCorpName.Text = ""
        '
        'industry_type
        '
        Me.industry_type.Format = ""
        Me.industry_type.FormatInfo = Nothing
        Me.industry_type.HeaderText = "行业类型"
        Me.industry_type.MappingName = "industry_type"
        Me.industry_type.NullText = ""
        Me.industry_type.Width = 75
        '
        'FQueryCreditProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Name = "FQueryCreditProject"
        Me.Text = "在保项目一览表"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

	Protected Overloads Sub GetCondition(ByRef projectNo As String, ByRef corporationName As String, ByRef serviceType As String, ByRef bankName As String, ByRef branchName As String, ByRef PMA As String)
		projectNo = IIf(txtProjectNo.Text.Trim() = "", "", txtProjectNo.Text)
        corporationName = IIf(txtCorpName.Text.Trim() = "", "", txtCorpName.Text)
		serviceType = IIf(cboServiceType.Text.Trim() = "", "", cboServiceType.Text)
		PMA = IIf(cboPMA.Text.Trim() = "", "", cboPMA.Text)
		bankName = IIf(cboBank.Text.Trim() = "", "", cboBank.Text)
		branchName = IIf(cboBranch.Text.Trim() = "", "", cboBranch.Text)
	End Sub

	Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim projectNo, corporationName, serviceType, bankName, branchName, PMA As String
        Dim i As Integer
        Dim iTotalGuaranteeSum, iTotalPaymentSum, iTotalSurplusSum As Decimal
        Dim dtResult As DataTable

		GetCondition(projectNo, corporationName, serviceType, bankName, branchName, PMA)

        'Dim dsResult As DataSet = gWs.FQueryCreditProject(projectNo, corporationName, serviceType, gWs.GetSysTime(), PMA, bankName, branchName)
        dtResult = gWs.FQueryCreditProject(projectNo, corporationName, serviceType, gWs.GetSysTime().Date.ToString(), PMA, bankName, branchName, UserName).Tables(0)

        For i = 0 To dtResult.Rows.Count - 1
            If Not dtResult.Rows(i).Item("guarantee_sum") Is System.DBNull.Value Then
                iTotalGuaranteeSum = iTotalGuaranteeSum + CDec(dtResult.Rows(i).Item("guarantee_sum"))
            End If
            If Not dtResult.Rows(i).Item("payment_total") Is System.DBNull.Value Then
                iTotalPaymentSum = iTotalPaymentSum + CDec(dtResult.Rows(i).Item("payment_total"))
            End If
            If Not dtResult.Rows(i).Item("surplus_total") Is System.DBNull.Value Then
                iTotalSurplusSum = iTotalSurplusSum + CDec(dtResult.Rows(i).Item("surplus_total"))
            End If
        Next
        Dim drRow As DataRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "合计："
            .Item("guarantee_sum") = iTotalGuaranteeSum
            .Item("payment_total") = iTotalPaymentSum
            .Item("surplus_total") = iTotalSurplusSum
        End With
        dtResult.Rows.Add(drRow)

        drRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "单数：" & i
        End With
        dtResult.Rows.Add(drRow)

        'dsResult.Tables("Table").TableName = "TQueryCreditProject"
        'dtResult.TableName = "TQueryCreditProject"

        MyBase.DataSource = dtResult
        grdTable.DataSource = dtResult
        'grdTable.SetDataBinding(dtResult, "TQueryCreditProject")
        Me.Text = "在保项目一览表" '(" + dsResult.Tables("TQueryCreditProject").Rows.Count.ToString + ")"
	End Sub

    Private Sub TextEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProjectNo.Enter, cboBank.Enter, cboServiceType.Enter, cboPMA.Enter
        If (Not sender Is Nothing) AndAlso sender.GetType() Is GetType(TextBox) Then
            CType(sender, TextBox).SelectAll()
        End If
    End Sub

    Private Sub FQueryCreditProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cboCorporationName.DataSource = gWs.GetcorporationInfo("%", "%").Tables(0)
        'cboCorporationName.DisplayMember = "corporation_name"
        'cboCorporationName.ValueMember = "corporation_name"

        cboServiceType.DataSource = gWs.GetServiceType("%").Tables(0)
        cboServiceType.DisplayMember = "service_type"
        cboServiceType.ValueMember = "service_type"

        Dim strSql As String = "{not team_name is null}"
        cboPMA.DataSource = gWs.GetStaff(strSql).Tables(0)
        cboPMA.DisplayMember = "staff_name"
        cboPMA.ValueMember = "staff_name"

        '''''''''''''贷款银行 贷款支行'''''''''''''''
        'dsBank = gWs.GetBankInfo("{0=0 order by bank_name}", "%")
        'qxd modify 2005-10-21 通过存储实现了按名称升序排序
        dsBank = gWs.GetBankInfo("%", "%")
        cboBank.DataSource = dsBank.Tables("bank")
        cboBank.DisplayMember = "bank_name"
        cboBank.ValueMember = "bank_code"
        cboBranch.DataSource = dsBank.Tables("bank_branch").DefaultView
        cboBranch.DisplayMember = "branch_bank_name"
        cboBranch.ValueMember = "branch_bank_name"

        cboPMA.SelectedItem = Nothing
        cboBank.SelectedItem = Nothing
        cboBranch.SelectedItem = Nothing
        cboServiceType.SelectedItem = Nothing
        'cboCorporationName.SelectedItem = Nothing

        MyBase.ReportTitle = "在保项目一览表"
        MyBase.ReportFile = Application.StartupPath + "\Reports\QueryCreditProject.rpt"
    End Sub

    Private Sub BankChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboBank.SelectedValueChanged
        If cboBranch.DataSource Is Nothing Then Return
        dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code LIKE '" & cboBank.SelectedValue & "'"
        dsBank.Tables("bank_branch").DefaultView.Sort = "branch_bank_name"
    End Sub

End Class
