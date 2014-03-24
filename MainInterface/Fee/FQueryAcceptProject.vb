

Public Class FQueryAcceptProject
    Inherits FQueryBase


    Protected Overloads Sub GetCondition(ByRef ProjectCode As String, ByRef CorName As String, _
                ByRef ServiceType As String, ByRef BankName As String, ByRef Area As String)
        ProjectCode = txtProjectCode.Text.Trim
        CorName = cboCorName.Text.Trim
        ServiceType = cboServiceType.Text.Trim
        BankName = cboBank.Text.Trim
        Area = cboArea.Text.Trim
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
        Dim ProjectCode, CorName, ServiceType, BankName, Area As String
        GetCondition(ProjectCode, CorName, ServiceType, BankName, Area)
        Dim ds As DataSet = gWs.FQueryAcceptProject(ProjectCode, CorName, ServiceType, StartDate, EndDate, BankName, Area)
        ds.Tables(0).TableName = "TQueryAcceptProject"
        grdTable.DataMember = "TQueryAcceptProject"
        grdTable.DataSource = ds
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        dtpStartDate.Enabled = chkDate.Checked
        dtpEndDate.Enabled = chkDate.Checked
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ReportFile = Application.StartupPath & "\Reports\QueryAcceptProject.rpt"
        ReportTitle = "正式受理项目一览表"

        '''''''''''''''''企业名称'''''''''''''''''''''''''
        Dim ds As DataSet = gWs.GetcorporationInfo("%", "null")
        cboCorName.DataSource = ds.Tables("corporation")
        cboCorName.DisplayMember = "corporation_name"
        cboCorName.ValueMember = "corporation_name"
        ''''''''''''''''业务品种''''''''''''''''
        Dim dsST As DataSet = gWs.GetServiceType("%")
        cboServiceType.DataSource = dsST.Tables(0)
        cboServiceType.DisplayMember = "service_type"
        cboServiceType.ValueMember = "service_type"
        '''''''''''''''所属区域''''''''''''''''''
        Dim dsArea As DataSet = gWs.GetDistrict("%")
        cboArea.DataSource = dsArea.Tables(0)
        cboArea.DisplayMember = "district_name"
        cboArea.ValueMember = "district_name"
        '''''''''''''贷款银行'''''''''''''''
        Dim dsBank As DataSet = gWs.GetBankInfo("%", "null")
        cboBank.DataSource = dsBank.Tables("bank")
        cboBank.DisplayMember = "bank_name"
        cboBank.ValueMember = "bank_name"
        AddTableStyle()
        clear()
        Dim SystemDate As Date = gWs.GetSysTime
        dtpStartDate.Value = SystemDate.Date : dtpEndDate.Value = SystemDate.Date
    End Sub
    Private Sub AddTableStyle()
        grdTable.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "TQueryAcceptProject"
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
        col3.MappingName = "district_name"
        col3.HeaderText = "所属区域"
        col3.NullText = ""
        col3.Width = 85
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
		col4.MappingName = "accept_time"
        col4.HeaderText = "受理日期"
        col4.Width = 70
        col4.Format = "yyyy-MM-dd"
        col4.NullText = ""
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "apply_service_type"
        col5.HeaderText = "申请业务品种"
        col5.NullText = ""
        col5.Width = 110
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col6.MappingName = "apply_sum"
        col6.HeaderText = "申请担保金额(万元)"
        col6.Width = 120
        col6.Format = "c" : col6.FormatInfo = CGFormatInfo
        col6.NullText = ""
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col7.MappingName = "apply_term"
        col7.HeaderText = "申请担保期限(月)"
        col7.Width = 100
        col7.NullText = ""
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col8.MappingName = "apply_bank"
        col8.HeaderText = "申请贷款银行"
        col8.NullText = ""
        col8.Width = 130
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col9.MappingName = "recommend_person"
        col9.HeaderText = "推荐人"
        col9.Width = 85
        col9.NullText = ""
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col10.MappingName = "accept_person"
        col10.HeaderText = "受理申请人员"
        col10.Width = 70
        col10.NullText = ""
        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col11.MappingName = "review_person"
        col11.HeaderText = "初审人员"
        col11.Width = 70
        col11.NullText = ""
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11})
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
    Friend WithEvents cboBank As System.Windows.Forms.ComboBox
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents cboCorName As System.Windows.Forms.ComboBox
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboArea As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.cboCorName = New System.Windows.Forms.ComboBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label6, Me.Label4, Me.dtpEndDate, Me.chkDate, Me.cboBank, Me.cboArea, Me.cboServiceType, Me.dtpStartDate, Me.cboCorName, Me.txtProjectCode, Me.Label7, Me.Label5, Me.Label3, Me.Label2, Me.Label1})
        Me.grpCondition.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Visible = True
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(296, 40)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(16, 20)
        Me.chkDate.TabIndex = 28
        '
        'cboBank
        '
        Me.cboBank.Location = New System.Drawing.Point(420, 67)
        Me.cboBank.MaxLength = 20
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(248, 20)
        Me.cboBank.TabIndex = 27
        '
        'cboArea
        '
        Me.cboArea.Location = New System.Drawing.Point(100, 40)
        Me.cboArea.MaxLength = 20
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(120, 20)
        Me.cboArea.TabIndex = 25
        '
        'cboServiceType
        '
        Me.cboServiceType.Location = New System.Drawing.Point(100, 67)
        Me.cboServiceType.MaxLength = 20
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(184, 20)
        Me.cboServiceType.TabIndex = 24
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Location = New System.Drawing.Point(396, 40)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpStartDate.TabIndex = 23
        '
        'cboCorName
        '
        Me.cboCorName.Location = New System.Drawing.Point(356, 13)
        Me.cboCorName.MaxLength = 50
        Me.cboCorName.Name = "cboCorName"
        Me.cboCorName.Size = New System.Drawing.Size(312, 20)
        Me.cboCorName.TabIndex = 22
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(100, 13)
        Me.txtProjectCode.MaxLength = 11
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectCode.TabIndex = 21
        Me.txtProjectCode.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(32, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "所属区域"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(356, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "贷款银行"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "业务品种"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(292, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "项目编号" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Location = New System.Drawing.Point(556, 40)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpEndDate.TabIndex = 30
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(516, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 16)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "到"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(312, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 14)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "正式受理日期"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FQueryAcceptProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryAcceptProject"
        Me.Text = "正式受理项目一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


End Class
