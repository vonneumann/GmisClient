Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FQueryFirstProject
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
    Friend WithEvents cboPMA As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboAcceptBranch As System.Windows.Forms.ComboBox
    Friend WithEvents lblAcceptBranch As System.Windows.Forms.Label
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents cboPhase As System.Windows.Forms.ComboBox
    Friend WithEvents lblToDate As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtProjectNo As System.Windows.Forms.TextBox
    Friend WithEvents lblProjectNo As System.Windows.Forms.Label
    Friend WithEvents lblServiceType As System.Windows.Forms.Label
    Friend WithEvents lblPhase As System.Windows.Forms.Label
    Friend WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Friend WithEvents lblCorporationName As System.Windows.Forms.Label
    Friend WithEvents txtCorporationNo As System.Windows.Forms.TextBox
    Friend WithEvents lblCorporationNo As System.Windows.Forms.Label
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
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
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents branch_name As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryFirstProject))
        Me.cboPMA = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboAcceptBranch = New System.Windows.Forms.ComboBox()
        Me.lblAcceptBranch = New System.Windows.Forms.Label()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.cboPhase = New System.Windows.Forms.ComboBox()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.txtProjectNo = New System.Windows.Forms.TextBox()
        Me.lblProjectNo = New System.Windows.Forms.Label()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.lblPhase = New System.Windows.Forms.Label()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.txtCorporationNo = New System.Windows.Forms.TextBox()
        Me.lblCorporationNo = New System.Windows.Forms.Label()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.branch_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboPMA, Me.Label8, Me.cboAcceptBranch, Me.lblAcceptBranch, Me.cboServiceType, Me.cboPhase, Me.lblToDate, Me.lblProjectNo, Me.lblServiceType, Me.lblPhase, Me.lblCorporationName, Me.lblCorporationNo, Me.dtpToDate, Me.dtpFromDate, Me.txtProjectNo, Me.txtCorporationName, Me.txtCorporationNo, Me.chkDate})
        Me.grpCondition.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCondition.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(616, 112)
        Me.btnExit.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.Location = New System.Drawing.Point(440, 112)
        Me.btnRefresh.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(504, 112)
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Bitmap)
        Me.btnClear.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.CaptionFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grdTable.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTable.HeaderFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTable.Size = New System.Drawing.Size(696, 360)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.grdTable.Visible = True
        '
        'ImageListQuery
        '
        Me.ImageListQuery.ImageStream = CType(resources.GetObject("ImageListQuery.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Bitmap)
        Me.btnExport.Location = New System.Drawing.Point(528, 112)
        Me.btnExport.Visible = True
        '
        'cboPMA
        '
        Me.cboPMA.DisplayMember = "staff_name"
        Me.cboPMA.Location = New System.Drawing.Point(488, 64)
        Me.cboPMA.MaxLength = 10
        Me.cboPMA.Name = "cboPMA"
        Me.cboPMA.Size = New System.Drawing.Size(120, 22)
        Me.cboPMA.TabIndex = 147
        Me.cboPMA.ValueMember = "staff_name"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(432, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "初审人员"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAcceptBranch
        '
        Me.cboAcceptBranch.DisplayMember = "branch_name"
        Me.cboAcceptBranch.Location = New System.Drawing.Point(488, 40)
        Me.cboAcceptBranch.MaxLength = 20
        Me.cboAcceptBranch.Name = "cboAcceptBranch"
        Me.cboAcceptBranch.Size = New System.Drawing.Size(120, 22)
        Me.cboAcceptBranch.TabIndex = 145
        Me.cboAcceptBranch.ValueMember = "branch_name"
        '
        'lblAcceptBranch
        '
        Me.lblAcceptBranch.Location = New System.Drawing.Point(432, 43)
        Me.lblAcceptBranch.Name = "lblAcceptBranch"
        Me.lblAcceptBranch.Size = New System.Drawing.Size(64, 16)
        Me.lblAcceptBranch.TabIndex = 144
        Me.lblAcceptBranch.Text = "受理分部"
        '
        'cboServiceType
        '
        Me.cboServiceType.Location = New System.Drawing.Point(488, 16)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(120, 22)
        Me.cboServiceType.TabIndex = 137
        '
        'cboPhase
        '
        Me.cboPhase.Location = New System.Drawing.Point(88, 40)
        Me.cboPhase.Name = "cboPhase"
        Me.cboPhase.Size = New System.Drawing.Size(120, 22)
        Me.cboPhase.TabIndex = 135
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(264, 68)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(18, 15)
        Me.lblToDate.TabIndex = 141
        Me.lblToDate.Text = "到"
        '
        'dtpToDate
        '
        Me.dtpToDate.Enabled = False
        Me.dtpToDate.Location = New System.Drawing.Point(288, 64)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(120, 22)
        Me.dtpToDate.TabIndex = 142
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CalendarFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Enabled = False
        Me.dtpFromDate.Location = New System.Drawing.Point(88, 64)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(120, 22)
        Me.dtpFromDate.TabIndex = 140
        '
        'txtProjectNo
        '
        Me.txtProjectNo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectNo.Location = New System.Drawing.Point(288, 41)
        Me.txtProjectNo.Name = "txtProjectNo"
        Me.txtProjectNo.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectNo.TabIndex = 139
        Me.txtProjectNo.Text = ""
        '
        'lblProjectNo
        '
        Me.lblProjectNo.AutoSize = True
        Me.lblProjectNo.Location = New System.Drawing.Point(224, 44)
        Me.lblProjectNo.Name = "lblProjectNo"
        Me.lblProjectNo.Size = New System.Drawing.Size(59, 15)
        Me.lblProjectNo.TabIndex = 138
        Me.lblProjectNo.Text = "项目编号"
        '
        'lblServiceType
        '
        Me.lblServiceType.AutoSize = True
        Me.lblServiceType.Location = New System.Drawing.Point(432, 20)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(59, 15)
        Me.lblServiceType.TabIndex = 136
        Me.lblServiceType.Text = "业务品种"
        '
        'lblPhase
        '
        Me.lblPhase.AutoSize = True
        Me.lblPhase.Location = New System.Drawing.Point(24, 44)
        Me.lblPhase.Name = "lblPhase"
        Me.lblPhase.Size = New System.Drawing.Size(59, 15)
        Me.lblPhase.TabIndex = 134
        Me.lblPhase.Text = "项目阶段"
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorporationName.Location = New System.Drawing.Point(288, 17)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.Size = New System.Drawing.Size(120, 21)
        Me.txtCorporationName.TabIndex = 133
        Me.txtCorporationName.Text = ""
        '
        'lblCorporationName
        '
        Me.lblCorporationName.AutoSize = True
        Me.lblCorporationName.Location = New System.Drawing.Point(224, 20)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(59, 15)
        Me.lblCorporationName.TabIndex = 132
        Me.lblCorporationName.Text = "企业名称"
        '
        'txtCorporationNo
        '
        Me.txtCorporationNo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorporationNo.Location = New System.Drawing.Point(88, 17)
        Me.txtCorporationNo.Name = "txtCorporationNo"
        Me.txtCorporationNo.Size = New System.Drawing.Size(120, 21)
        Me.txtCorporationNo.TabIndex = 131
        Me.txtCorporationNo.Text = ""
        '
        'lblCorporationNo
        '
        Me.lblCorporationNo.AutoSize = True
        Me.lblCorporationNo.Location = New System.Drawing.Point(24, 20)
        Me.lblCorporationNo.Name = "lblCorporationNo"
        Me.lblCorporationNo.Size = New System.Drawing.Size(59, 15)
        Me.lblCorporationNo.TabIndex = 130
        Me.lblCorporationNo.Text = "企业编号"
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(16, 63)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(80, 24)
        Me.chkDate.TabIndex = 143
        Me.chkDate.Text = "初审日期"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.branch_name})
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
        Me.DataGridTextBoxColumn1.Width = 80
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "企业编号"
        Me.DataGridTextBoxColumn2.MappingName = "corporation_code"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 80
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "企业名称"
        Me.DataGridTextBoxColumn3.MappingName = "corporation_name"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 150
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "阶 段"
        Me.DataGridTextBoxColumn4.MappingName = "phase"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "业务品种"
        Me.DataGridTextBoxColumn5.MappingName = "apply_service_Type"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "申请日期"
        Me.DataGridTextBoxColumn6.MappingName = "apply_date"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 80
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "申请金额(万元)"
        Me.DataGridTextBoxColumn7.MappingName = "apply_sum"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "申请期限"
        Me.DataGridTextBoxColumn8.MappingName = "apply_term"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 60
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "申请银行"
        Me.DataGridTextBoxColumn9.MappingName = "bank_name"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 150
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "初审人员"
        Me.DataGridTextBoxColumn10.MappingName = "attend_person"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "分配日期"
        Me.DataGridTextBoxColumn11.MappingName = "start_time"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 80
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "完成日期"
        Me.DataGridTextBoxColumn12.MappingName = "end_time"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 80
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "结 论"
        Me.DataGridTextBoxColumn13.MappingName = "conclusion"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 120
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "评审费意见"
        Me.DataGridTextBoxColumn14.MappingName = "ReviewFeeConclusion"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 120
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
        'FQueryFirstProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(712, 509)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "FQueryFirstProject"
        Me.Text = "初审项目一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dtStaff As DataTable

    Private Sub FFirstProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFromDate.Value = DateTime.Today
        dtpToDate.Value = DateTime.Today

        cboPhase.DataSource = gWs.GetPhase("%").Tables(0)
        cboPhase.DisplayMember = "phase_name"
        cboPhase.ValueMember = "phase_name"

        cboServiceType.DataSource = gWs.GetServiceType("%").Tables(0)
        cboServiceType.DisplayMember = "service_type"
        cboServiceType.ValueMember = "service_type"

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

        Me.cboPMA.DataSource = gWs.GetStaffByRoleID("13").Tables(0)
        Me.cboPMA.DisplayMember = "staff_name"
        Me.cboPMA.ValueMember = "staff_name"

        AddHandler cboPMA.SelectedValueChanged, AddressOf cmbStaffSelectedValueChanged

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
        Try
            Dim i As Integer
            Dim iTotalSum As Decimal
            Dim dtResult As DataTable

            Me.Cursor = Cursors.WaitCursor

            Dim FromDate, ToDate As Object
            FromDate = IIf(Me.chkDate.Checked, Me.dtpFromDate.Value.Date, Nothing)
            ToDate = IIf(Me.chkDate.Checked, Me.dtpToDate.Value.Date, Nothing)

            If Not FromDate Is Nothing And Not ToDate Is Nothing AndAlso FromDate.Date > ToDate.Date Then
                SWDialogBox.MessageBox.Show("$1008", "起始日期", "截止日期")
                Return
            End If

            Dim projectNo, corporationNo, corporationName, phase, serviceType, strAcceptBranch, strPMA As String

            Me.GetCondition(projectNo, corporationNo, corporationName, phase, serviceType, strAcceptBranch, strPMA)

            dtResult = gWs.GetQueryFirstProject(projectNo, corporationNo, corporationName, phase, serviceType, FromDate, ToDate, strAcceptBranch, strPMA, UserName).Tables(0)

            For i = 0 To dtResult.Rows.Count - 1
                If Not IsDBNull(dtResult.Rows(i).Item("apply_sum")) Then
                    If Not dtResult.Rows(i).Item("apply_sum") Is System.DBNull.Value Then
                        iTotalSum = iTotalSum + CDec(dtResult.Rows(i).Item("apply_sum"))
                    End If
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
            'grdTable.SetDataBinding(rsResult, "Table")
            Me.Text = "初审项目一览表" '(" + rsResult.Tables("Table").Rows.Count.ToString + ")"
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Overloads Function GetCondition(ByRef projectNo As String, ByRef corporationNo As String, ByRef corporationName As String, ByRef phase As String, ByRef serviceType As String, ByRef strAcceptBranch As String, ByRef strPMA As String) As String
        projectNo = txtProjectNo.Text.Trim()
        corporationNo = txtCorporationNo.Text.Trim()
        corporationName = txtCorporationName.Text.Trim()
        phase = cboPhase.Text.Trim()
        serviceType = cboServiceType.Text.Trim()
        strPMA = cboPMA.Text.Trim

        If cboAcceptBranch.Visible = True Then
            strAcceptBranch = Trim(cboAcceptBranch.Text)
        Else
            strAcceptBranch = ""
        End If

    End Function

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        Me.dtpFromDate.Enabled = Me.chkDate.Checked
        Me.dtpToDate.Enabled = Me.chkDate.Checked
    End Sub

    Protected Overrides Sub Export()
        Dim export As New ReportToExcel()
        export.ToExcel(Me.grdTable, "初审一览表", "初审项目一览表")
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
