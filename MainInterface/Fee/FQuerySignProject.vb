

Public Class FQuerySignProject
    Inherits FQueryBase

    Protected Overloads Sub GetCondition(ByRef ProjectCode As String, ByRef CorName As String, _
         ByRef CorType As String, ByRef ServiceType As String, ByRef MA As String, ByRef BankName As String, _
         ByRef SubBank As String, ByRef Area As String, ByRef IndustrT As String)
        ProjectCode = txtProjectCode.Text.Trim
        CorName = cboCorName.Text.Trim
        CorType = cboCorType.Text.Trim
        ServiceType = cboServiceType.Text.Trim
        MA = cboMA.Text.Trim
        BankName = cboBank.Text.Trim
        SubBank = cboSubBank.Text.Trim
        Area = cboArea.Text.Trim
        IndustrT = cboIndustryType.Text.Trim
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
        Dim PC, CorName, CorType, SerT, MA, BankName, SubBank, Area, IndustrT As String  'IndustrT 所属行业，CorType 所有制类型
        GetCondition(PC, CorName, CorType, SerT, MA, BankName, SubBank, Area, IndustrT)
        Dim ds As DataSet = gWs.FQuerySignProject(PC, CorName, SerT, StartDate, EndDate, Area, IndustrT, CorType, MA, BankName, SubBank)
        ds.Tables(0).TableName = "TQuerySignProject"
        grdTable.DataMember = ds.Tables(0).TableName
        grdTable.DataSource = ds
    End Sub

    Private Sub chkStartDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        dtpStartDate.Enabled = chkDate.Checked
        dtpEndDate.Enabled = chkDate.Checked
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ReportFile = Application.StartupPath & ".\Reports\QuerySignProject.rpt"
        ReportTitle = "签约项目一览表"
        'ReportTable = New String() {"TQuerySignProject"}

        '''''''''''''''''企业名称'''''''''''''''''''''''''
        Dim ds As DataSet = gWs.GetcorporationInfo("%", "null")
        cboCorName.DataSource = ds.Tables("corporation")
        cboCorName.DisplayMember = "corporation_name"
        cboCorName.ValueMember = "corporation_name"
        '''''''业务品种''''''''''''''''
        Dim dsST As DataSet = gWs.GetServiceType("%")
        cboServiceType.DataSource = dsST.Tables(0)
        cboServiceType.DisplayMember = "service_type"
        cboServiceType.ValueMember = "service_type"
        '''''''''''''''所属区域''''''''''''''''''
        Dim dsArea As DataSet = gWs.GetDistrict("%")
        cboArea.DataSource = dsArea.Tables(0)
        cboArea.DisplayMember = "district_name"
        cboArea.ValueMember = "district_name"
        '''''''''''''贷款银行 贷款支行'''''''''''''''
        Dim dsBank As DataSet = gWs.GetBankInfo("%", "%")
        cboBank.DataSource = dsBank.Tables("bank")
        cboBank.DisplayMember = "bank_name"
        cboBank.ValueMember = "bank_name"
        cboSubBank.DataSource = dsBank.Tables("bank_branch")
        cboSubBank.DisplayMember = "branch_bank_name"
        cboSubBank.ValueMember = "branch_bank_name"
        ''''''''''''''所有制类型''''''''''''''''''
        Dim dsCorType As DataSet = gWs.GetProprietorshipType("%")
        cboCorType.DataSource = dsCorType.Tables(0)
        cboCorType.DisplayMember = "proprietorship_type"
        cboCorType.ValueMember = "proprietorship_type"
        ''''''''''''''所属行业'''''''''''''''''''
        Dim dsIT As DataSet = gWs.GetIndustryType("%")
        cboIndustryType.DataSource = dsIT.Tables(0)
        cboIndustryType.DisplayMember = "industry_type"
        cboIndustryType.ValueMember = "industry_type"
        '''''''''''''项目经理A'''''''''''
        Dim dsMA As DataSet = gWs.GetStaff("%")
        cboMA.DataSource = dsMA.Tables(0)
        cboMA.DisplayMember = "staff_name"
        cboMA.ValueMember = "staff_name"
        AddTableStyle()
        Clear()
        Dim SystemDate As Date = gWs.GetSysTime
        dtpStartDate.Value = SystemDate.Date : dtpEndDate.Value = SystemDate.Date
    End Sub

    Private Sub AddTableStyle()
        grdTable.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "TQuerySignProject"
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
        col3.MappingName = "manager_a"
        col3.HeaderText = "项目经理A角"
        col3.Width = 70
        col3.NullText = ""
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.MappingName = "manager_b"
        col4.HeaderText = "项目经理B角"
        col4.Width = 70
        col4.NullText = ""
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "service_type"
        col5.HeaderText = "业务品种"
        col5.Width = 90
        col5.NullText = ""
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col6.MappingName = "guarantee_sum"
        col6.HeaderText = "签约金额(万元)"
        col6.Format = "c" : col6.FormatInfo = CGFormatInfo
        col6.Width = 85
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col7.MappingName = "sign_date"
        col7.HeaderText = "签约日期"
        col7.Format = "yyyy-MM-dd"
        col7.NullText = ""
        col7.Width = 70
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col8.MappingName = "reply_date"
        col8.HeaderText = "银行通过日期"
        col8.Width = 90
        col8.Format = "yyyy-MM-dd"
        col8.NullText = ""
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col9.MappingName = "bank"
        col9.HeaderText = "贷款银行"
        col9.Width = 85
        col9.NullText = ""
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col10.MappingName = "branch_bank"
        col10.HeaderText = "支行"
        col10.Width = 85
        col10.NullText = ""
        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col11.MappingName = "district_name"
        col11.HeaderText = "所属区域"
        col11.NullText = ""
        col11.Width = 80
        Dim col12 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col12.MappingName = "industry_type"
        col12.HeaderText = "所属行业"
        col12.Width = 110
        col12.NullText = ""
        Dim col13 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col13.MappingName = "proprietorship_type"
        col13.HeaderText = "所有制类型"
        col13.Width = 110
        col13.NullText = ""
        Dim col14 As DataGridBoolColumn = New DataGridBoolColumn()
        col14.MappingName = "is_first_loan"
        col14.HeaderText = "是否首次贷款"
        col14.Width = 75
        col14.NullValue = False
        Dim col15 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col15.MappingName = "recommend_person"
        col15.HeaderText = "推荐人"
        col15.Width = 90
        col15.NullText = ""
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13, col14, col15})
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboSubBank As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboCorType As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboArea As System.Windows.Forms.ComboBox
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboIndustryType As System.Windows.Forms.ComboBox
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cboMA As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.cboIndustryType = New System.Windows.Forms.ComboBox()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.cboCorName = New System.Windows.Forms.ComboBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSubBank = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboCorType = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cboMA = New System.Windows.Forms.ComboBox()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboMA, Me.cboArea, Me.Label9, Me.cboCorType, Me.Label8, Me.cboSubBank, Me.Label4, Me.cboBank, Me.cboIndustryType, Me.cboServiceType, Me.cboCorName, Me.txtProjectCode, Me.Label7, Me.Label6, Me.Label5, Me.Label3, Me.Label2, Me.Label1, Me.chkDate, Me.Label11, Me.dtpStartDate, Me.dtpEndDate, Me.Label10})
        Me.grpCondition.Size = New System.Drawing.Size(696, 136)
        Me.grpCondition.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(608, 152)
        Me.btnExit.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(400, 152)
        Me.btnRefresh.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(504, 152)
        Me.btnPrint.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 184)
        Me.grdTable.Size = New System.Drawing.Size(696, 304)
        Me.grdTable.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 152)
        Me.btnClear.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 152)
        Me.chkVisible.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(296, 152)
        Me.btnExport.Visible = True
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(8, 48)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(16, 18)
        Me.chkDate.TabIndex = 28
        '
        'cboBank
        '
        Me.cboBank.Location = New System.Drawing.Point(264, 75)
        Me.cboBank.MaxLength = 20
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(224, 20)
        Me.cboBank.TabIndex = 27
        '
        'cboIndustryType
        '
        Me.cboIndustryType.Location = New System.Drawing.Point(400, 104)
        Me.cboIndustryType.MaxLength = 20
        Me.cboIndustryType.Name = "cboIndustryType"
        Me.cboIndustryType.Size = New System.Drawing.Size(288, 20)
        Me.cboIndustryType.TabIndex = 25
        '
        'cboServiceType
        '
        Me.cboServiceType.Location = New System.Drawing.Point(464, 46)
        Me.cboServiceType.MaxLength = 20
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(224, 20)
        Me.cboServiceType.TabIndex = 24
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Location = New System.Drawing.Point(88, 46)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpStartDate.TabIndex = 23
        '
        'cboCorName
        '
        Me.cboCorName.Location = New System.Drawing.Point(264, 16)
        Me.cboCorName.MaxLength = 50
        Me.cboCorName.Name = "cboCorName"
        Me.cboCorName.Size = New System.Drawing.Size(224, 20)
        Me.cboCorName.TabIndex = 22
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(88, 16)
        Me.txtProjectCode.MaxLength = 11
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 21
        Me.txtProjectCode.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(336, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "所属行业"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(496, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "项目经理A角"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(200, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "贷款银行"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(400, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "业务品种"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(200, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "项目编号" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(496, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "贷款支行"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboSubBank
        '
        Me.cboSubBank.Location = New System.Drawing.Point(552, 75)
        Me.cboSubBank.MaxLength = 20
        Me.cboSubBank.Name = "cboSubBank"
        Me.cboSubBank.Size = New System.Drawing.Size(136, 20)
        Me.cboSubBank.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(24, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "所有制类型"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboCorType
        '
        Me.cboCorType.Location = New System.Drawing.Point(88, 106)
        Me.cboCorType.MaxLength = 20
        Me.cboCorType.Name = "cboCorType"
        Me.cboCorType.Size = New System.Drawing.Size(240, 20)
        Me.cboCorType.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(24, 77)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "所属区域"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboArea
        '
        Me.cboArea.Location = New System.Drawing.Point(88, 75)
        Me.cboArea.MaxLength = 20
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(112, 20)
        Me.cboArea.TabIndex = 34
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Location = New System.Drawing.Point(264, 46)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpEndDate.TabIndex = 36
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(208, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 16)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "到"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(24, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "签约日期"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboMA
        '
        Me.cboMA.Location = New System.Drawing.Point(576, 17)
        Me.cboMA.MaxLength = 10
        Me.cboMA.Name = "cboMA"
        Me.cboMA.Size = New System.Drawing.Size(112, 20)
        Me.cboMA.TabIndex = 37
        '
        'FQuerySignProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQuerySignProject"
        Me.Text = "签约项目一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class
