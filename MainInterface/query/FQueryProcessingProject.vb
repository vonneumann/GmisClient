Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FQueryProcessingProject
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
	Friend WithEvents cboPMA As System.Windows.Forms.ComboBox
	Friend WithEvents lblPMA As System.Windows.Forms.Label
	Friend WithEvents cboPMB As System.Windows.Forms.ComboBox
	Friend WithEvents lblPMB As System.Windows.Forms.Label
	Friend WithEvents cboPhase As System.Windows.Forms.ComboBox
	Friend WithEvents lblPhase As System.Windows.Forms.Label
	Friend WithEvents tsTable As System.Windows.Forms.DataGridTableStyle
	Friend WithEvents csTeam As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csPMA As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csPMB As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csProjectNo As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csCorporationName As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csServiceType As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csCreateDate As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csPhase As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csStatus As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents branch_name As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblProjectNo = New System.Windows.Forms.Label()
        Me.txtProjectNo = New System.Windows.Forms.TextBox()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.cboPMA = New System.Windows.Forms.ComboBox()
        Me.lblPMA = New System.Windows.Forms.Label()
        Me.cboPMB = New System.Windows.Forms.ComboBox()
        Me.lblPMB = New System.Windows.Forms.Label()
        Me.cboPhase = New System.Windows.Forms.ComboBox()
        Me.lblPhase = New System.Windows.Forms.Label()
        Me.tsTable = New System.Windows.Forms.DataGridTableStyle()
        Me.csProjectNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCorporationName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csServiceType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTeam = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csPMA = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csPMB = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCreateDate = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csPhase = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csStatus = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.branch_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(616, 96)
        Me.btnExit.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(512, 96)
        Me.btnPrint.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(424, 96)
        Me.btnRefresh.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(520, 96)
        Me.btnExport.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCorpName, Me.cboPhase, Me.lblPhase, Me.cboPMB, Me.lblPMB, Me.cboPMA, Me.lblPMA, Me.cboServiceType, Me.lblServiceType, Me.lblCorporationName, Me.txtProjectNo, Me.lblProjectNo})
        Me.grpCondition.Size = New System.Drawing.Size(696, 72)
        Me.grpCondition.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 96)
        Me.btnClear.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 136)
        Me.grdTable.Size = New System.Drawing.Size(696, 352)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsTable})
        Me.grdTable.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 96)
        Me.chkVisible.Visible = True
        '
        'lblProjectNo
        '
        Me.lblProjectNo.Location = New System.Drawing.Point(24, 24)
        Me.lblProjectNo.Name = "lblProjectNo"
        Me.lblProjectNo.Size = New System.Drawing.Size(56, 16)
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
        Me.lblCorporationName.Location = New System.Drawing.Point(232, 24)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(56, 16)
        Me.lblCorporationName.TabIndex = 2
        Me.lblCorporationName.Text = "企业名称"
        '
        'cboServiceType
        '
        Me.cboServiceType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboServiceType.Location = New System.Drawing.Point(488, 16)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(120, 22)
        Me.cboServiceType.TabIndex = 5
        '
        'lblServiceType
        '
        Me.lblServiceType.Location = New System.Drawing.Point(432, 24)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(64, 16)
        Me.lblServiceType.TabIndex = 4
        Me.lblServiceType.Text = "业务品种"
        '
        'cboPMA
        '
        Me.cboPMA.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPMA.Location = New System.Drawing.Point(80, 40)
        Me.cboPMA.Name = "cboPMA"
        Me.cboPMA.Size = New System.Drawing.Size(120, 22)
        Me.cboPMA.TabIndex = 7
        '
        'lblPMA
        '
        Me.lblPMA.Location = New System.Drawing.Point(16, 48)
        Me.lblPMA.Name = "lblPMA"
        Me.lblPMA.Size = New System.Drawing.Size(64, 16)
        Me.lblPMA.TabIndex = 6
        Me.lblPMA.Text = "项目经理A"
        '
        'cboPMB
        '
        Me.cboPMB.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPMB.Location = New System.Drawing.Point(288, 40)
        Me.cboPMB.Name = "cboPMB"
        Me.cboPMB.Size = New System.Drawing.Size(120, 22)
        Me.cboPMB.TabIndex = 9
        '
        'lblPMB
        '
        Me.lblPMB.Location = New System.Drawing.Point(224, 48)
        Me.lblPMB.Name = "lblPMB"
        Me.lblPMB.Size = New System.Drawing.Size(64, 16)
        Me.lblPMB.TabIndex = 8
        Me.lblPMB.Text = "项目经理B"
        '
        'cboPhase
        '
        Me.cboPhase.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPhase.Location = New System.Drawing.Point(488, 40)
        Me.cboPhase.Name = "cboPhase"
        Me.cboPhase.Size = New System.Drawing.Size(120, 22)
        Me.cboPhase.TabIndex = 11
        '
        'lblPhase
        '
        Me.lblPhase.Location = New System.Drawing.Point(432, 48)
        Me.lblPhase.Name = "lblPhase"
        Me.lblPhase.Size = New System.Drawing.Size(64, 16)
        Me.lblPhase.TabIndex = 10
        Me.lblPhase.Text = "项目阶段"
        '
        'tsTable
        '
        Me.tsTable.DataGrid = Me.grdTable
        Me.tsTable.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csProjectNo, Me.csCorporationName, Me.csServiceType, Me.csTeam, Me.csPMA, Me.csPMB, Me.csCreateDate, Me.csPhase, Me.csStatus, Me.branch_name})
        Me.tsTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsTable.MappingName = "Table"
        '
        'csProjectNo
        '
        Me.csProjectNo.Format = ""
        Me.csProjectNo.FormatInfo = Nothing
        Me.csProjectNo.HeaderText = "项目编码"
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
        Me.csCorporationName.Width = 200
        '
        'csServiceType
        '
        Me.csServiceType.Format = ""
        Me.csServiceType.FormatInfo = Nothing
        Me.csServiceType.HeaderText = "业务品种"
        Me.csServiceType.MappingName = "service_type"
        Me.csServiceType.NullText = ""
        Me.csServiceType.Width = 120
        '
        'csTeam
        '
        Me.csTeam.Format = ""
        Me.csTeam.FormatInfo = Nothing
        Me.csTeam.HeaderText = "项目组"
        Me.csTeam.MappingName = "team"
        Me.csTeam.NullText = ""
        Me.csTeam.Width = 80
        '
        'csPMA
        '
        Me.csPMA.Format = ""
        Me.csPMA.FormatInfo = Nothing
        Me.csPMA.HeaderText = "项目经理A"
        Me.csPMA.MappingName = "manager_a"
        Me.csPMA.NullText = ""
        Me.csPMA.Width = 80
        '
        'csPMB
        '
        Me.csPMB.Format = ""
        Me.csPMB.FormatInfo = Nothing
        Me.csPMB.HeaderText = "项目经理B"
        Me.csPMB.MappingName = "manager_b"
        Me.csPMB.NullText = ""
        Me.csPMB.Width = 80
        '
        'csCreateDate
        '
        Me.csCreateDate.Format = "yyyy-MM-dd"
        Me.csCreateDate.FormatInfo = Nothing
        Me.csCreateDate.HeaderText = "分配时间"
        Me.csCreateDate.MappingName = "create_date"
        Me.csCreateDate.NullText = ""
        Me.csCreateDate.Width = 75
        '
        'csPhase
        '
        Me.csPhase.Format = ""
        Me.csPhase.FormatInfo = Nothing
        Me.csPhase.HeaderText = "项目阶段"
        Me.csPhase.MappingName = "phase"
        Me.csPhase.NullText = ""
        Me.csPhase.Width = 80
        '
        'csStatus
        '
        Me.csStatus.Format = ""
        Me.csStatus.FormatInfo = Nothing
        Me.csStatus.HeaderText = "项目状态"
        Me.csStatus.MappingName = "status"
        Me.csStatus.NullText = ""
        Me.csStatus.Width = 75
        '
        'branch_name
        '
        Me.branch_name.Format = ""
        Me.branch_name.FormatInfo = Nothing
        Me.branch_name.HeaderText = "受理分部"
        Me.branch_name.MappingName = "branch_name"
        Me.branch_name.NullText = ""
        Me.branch_name.Width = 75
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(288, 16)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(120, 21)
        Me.txtCorpName.TabIndex = 12
        Me.txtCorpName.Text = ""
        '
        'FQueryProcessingProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryProcessingProject"
        Me.Text = "各项目经理正在进行项目一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

	Protected Overloads Sub GetCondition(ByRef projectNo As String, ByRef corporationName As String, ByRef serviceType As String, ByRef PMA As String, ByRef PMB As String, ByRef phase As String)
		projectNo = IIf(txtProjectNo.Text.Trim() = "", "", txtProjectNo.Text)
        corporationName = IIf(txtCorpName.Text.Trim() = "", "", txtCorpName.Text)
		serviceType = IIf(cboServiceType.Text.Trim() = "", "", cboServiceType.Text)
		PMA = IIf(cboPMA.Text.Trim() = "", "", cboPMA.Text)
		PMB = IIf(cboPMB.Text.Trim() = "", "", cboPMB.Text)
		phase = IIf(cboPhase.Text.Trim() = "", "", cboPhase.Text)
	End Sub

	Protected Overloads Overrides Sub Refresh(ByVal condition As String)
		Dim projectNo, corporationName, serviceType, PMA, PMB, phase As String

		GetCondition(projectNo, corporationName, serviceType, PMA, PMB, phase)

        Dim dsResult As DataSet = gWs.FQueryProcessingProject(projectNo, corporationName, serviceType, gWs.GetSysTime().Date.ToString(), PMA, PMB, phase, UserName)

        Dim drRow As DataRow = dsResult.Tables(0).NewRow
        With drRow
            .Item("enterprise_name") = "单数：" & dsResult.Tables(0).Rows.Count.ToString
        End With
        dsResult.Tables(0).Rows.Add(drRow)

        'dsResult.Tables("Table").TableName = "TQueryProcessingProject"

        MyBase.DataSource = dsResult.Tables(0)
        grdTable.DataSource = dsResult.Tables(0)
        ' grdTable.SetDataBinding(dsResult, "TQueryProcessingProject")
        Me.Text = "各项目经理正在进行项目一览表" '(" + dsResult.Tables("TQueryProcessingProject").Rows.Count.ToString + ")"
	End Sub

    Private Sub TextEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtProjectNo.Enter, cboServiceType.Enter, cboPMA.Enter, cboPMB.Enter, cboPhase.Enter
        If (Not sender Is Nothing) AndAlso sender.GetType() Is GetType(TextBox) Then
            CType(sender, TextBox).SelectAll()
        End If
    End Sub

    Private Sub FQueryProcessingProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        cboPMB.DataSource = gWs.GetStaff(strSql).Tables(0)
        cboPMB.DisplayMember = "staff_name"
        cboPMB.ValueMember = "staff_name"

        cboPhase.DataSource = gWs.GetPhase("%").Tables(0)
        cboPhase.DisplayMember = "phase_name"
        cboPhase.ValueMember = "phase_name"

        cboPMA.SelectedItem = Nothing
        cboPMB.SelectedItem = Nothing
        cboPhase.SelectedItem = Nothing
        cboServiceType.SelectedItem = Nothing
        'cboCorporationName.SelectedItem = Nothing

        MyBase.ReportTitle = "各项目经理正在进行项目一览表"
        MyBase.ReportFile = Application.StartupPath + "\Reports\QueryProcessingProject.rpt"
    End Sub

   
End Class
