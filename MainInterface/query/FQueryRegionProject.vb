

'合作区项目管理一览表
Public Class FQueryRegionProject
    Inherits FQueryBase

    Protected Overloads Sub GetCondition(ByRef ServiceType As String, ByRef Area As String, ByRef phase As String, ByRef strPMA As String, ByRef recommend_type As String, ByRef opinion As String, ByRef exempt As String, ByRef trial_conclusion As String)
        ServiceType = cboServiceType.Text.Trim
        Area = cboArea.Text.Trim
        phase = cboPhase.Text.Trim
        strPMA = cboPMA.Text.Trim
        recommend_type = cboRecommendType.Text.Trim
        opinion = cboOpinion.Text.Trim
        Select Case chkExempt.CheckState
            Case CheckState.Checked
                exempt = "1"
            Case CheckState.Unchecked
                exempt = "0"
            Case CheckState.Indeterminate
                exempt = Nothing
        End Select
        trial_conclusion = cboTrialConclusion.Text.Trim
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal Condition As String)
        Dim StartDate, EndDate As Object
        Dim i As Integer
        Dim iTotalRecommendSum, iTotalLoanSum As Decimal
        Dim dtResult As DataTable

        StartDate = IIf(chkDate.Checked, dtpStartDate.Value.Date, Nothing)
        EndDate = IIf(chkDate.Checked, dtpEndDate.Value.Date, Nothing)
        If chkDate.Checked AndAlso DateTime.Parse(StartDate).Date > DateTime.Parse(EndDate).Date Then
            SWDialogBox.MessageBox.Show("$1008", "起始日期", "截止日期")
            'MessageBox.Show("截止日期应大于起始日期", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpEndDate.Value = dtpStartDate.Value.Date
            Return
        End If
        Dim ServiceType, Area, Phase, strPMA, recommendType, opinion, trialConclusion As String
        Dim exempt As String
        GetCondition(ServiceType, Area, Phase, strPMA, recommendType, opinion, exempt, trialConclusion)
        dtResult = gWs.FQueryRegionProject("", "", ServiceType, StartDate, EndDate, Area, Phase, strPMA, UserName, recommendType, opinion, exempt, trialConclusion).Tables(0)

        For i = 0 To dtResult.Rows.Count - 1
            If Not IsDBNull(dtResult.Rows(i).Item("recommend_sum")) Then
                iTotalRecommendSum = iTotalRecommendSum + CDec(dtResult.Rows(i).Item("recommend_sum"))
            End If
            If Not IsDBNull(dtResult.Rows(i).Item("loan_money")) Then
                iTotalLoanSum = iTotalLoanSum + CDec(dtResult.Rows(i).Item("loan_money"))
            End If

        Next
        Dim drRow As DataRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "合计："
            .Item("recommend_sum") = iTotalRecommendSum
            .Item("loan_money") = iTotalLoanSum
        End With
        dtResult.Rows.Add(drRow)

        drRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "单数：" & i
        End With
        dtResult.Rows.Add(drRow)

        'ds.Tables(0).TableName = "TQueryRegionProject"
        'grdTable.DataMember = "TQueryRegionProject"
        grdTable.DataSource = dtResult
        MyBase.DataSource = dtResult
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        dtpEndDate.Enabled = chkDate.Checked
        dtpStartDate.Enabled = chkDate.Checked
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ReportFile = Application.StartupPath & ".\Reports\QueryRegionProject.rpt"
        ReportTitle = "合作区项目管理一览表"
        '''''''''''''业务品种''''''''''''''''
        Dim dsST As DataSet = gWs.GetServiceType("%")
        cboServiceType.DataSource = dsST.Tables(0)
        cboServiceType.DisplayMember = "service_type"
        cboServiceType.ValueMember = "service_type"
        '''''''''''''所属区域''''''''''''''''''
        Dim dsArea As DataSet = gWs.GetCooperateOrganization("%")
        cboArea.DataSource = dsArea.Tables(0)
        cboArea.DisplayMember = "cooperate_organization"
        cboArea.ValueMember = "cooperate_organization"
        '''''''''''''阶段''''''''''''
        Dim dsPhase As DataSet = gWs.GetPhase("%")
        cboPhase.DataSource = dsPhase.Tables(0)
        cboPhase.DisplayMember = "phase_name"
        cboPhase.ValueMember = "phase_name"

        ''''''''''''评审结论
        '2005-03-23 yjf add
        Dim strSql As String
        strSql = "SELECT DISTINCT trial_conclusion FROM conference_trial"
        Dim dsConclusion As DataSet = gWs.GetCommonQueryInfo(strSql)
        cboTrialConclusion.DataSource = dsConclusion.Tables(0)
        cboTrialConclusion.DisplayMember = "trial_conclusion"
        cboTrialConclusion.ValueMember = "trial_conclusion"


        cboPMA.DataSource = gWs.GetStaff("{not team_name is null}").Tables(0)

        AddTableStyle()
        Clear()
    End Sub

    Private Sub AddTableStyle()
        grdTable.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "Table"
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "project_code"
        col1.HeaderText = "项目编号"
        col1.Width = 75
        col1.NullText = ""
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.MappingName = "enterprise_name"
        col2.HeaderText = "企业名称"
        col2.Width = 150
        col2.NullText = ""
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.MappingName = "cooperate_organization"
        col3.HeaderText = "合作区"
        col3.Width = 100
        col3.NullText = ""
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.MappingName = "recommend_date"
        col4.HeaderText = "合作区推荐日期"
        col4.Format = "yyyy-MM-dd"
        col4.Width = 100
        col4.NullText = ""
        Dim col20 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col20.MappingName = "recommend_type"
        col20.HeaderText = "推荐类别"
        col20.Width = 100
        col20.NullText = ""
        Dim col21 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col21.MappingName = "opinion"
        col21.HeaderText = "合作区意见"
        col21.Width = 100
        col21.NullText = ""
        Dim col23 As DataGridBoolColumn = New DataGridBoolColumn()
        col23.MappingName = "exempt"
        col23.HeaderText = "豁免"
        col23.Width = 50
        col23.NullText = ""
        col23.AllowNull = False
        col23.FalseValue = 0
        col23.TrueValue = 1
        Dim colExempt As DataGridBoolColumn = New DataGridBoolColumn()
        colExempt.MappingName = "exempt"
        colExempt.HeaderText = "豁免"
        colExempt.Width = 50
        colExempt.AllowNull = False
        Dim col24 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col24.MappingName = "trial_conclusion"
        col24.HeaderText = "评审结论"
        col24.Width = 50
        col24.NullText = ""
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "recommend_sum"
        col5.HeaderText = "推荐金额(万元)"
        col5.Alignment = HorizontalAlignment.Right
        col5.Format = "n" ' : col5.FormatInfo = CGFormatInfo
        col5.Width = 100
        col5.NullText = ""
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col6.MappingName = "service_type"
        col6.HeaderText = "业务品种"
        col6.Width = 110
        col6.NullText = ""
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col7.MappingName = "team"
        col7.HeaderText = "项目组"
        col7.Width = 80
        col7.NullText = ""
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col8.MappingName = "manager_a"
        col8.HeaderText = "项目经理A角"
        col8.NullText = ""
        col8.Width = 75
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col9.MappingName = "manager_b"
        col9.HeaderText = "项目经理B角"
        col9.NullText = ""
        col9.Width = 75
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col10.MappingName = "phase"
        col10.HeaderText = "项目阶段"
        col10.NullText = ""
        col10.Width = 75
        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col11.MappingName = "status"
        col11.HeaderText = "项目状态"
        col11.NullText = ""
        col11.Width = 75
        Dim col12 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col12.MappingName = "conference_date"
        col12.HeaderText = "评审会通过日期"
        col12.Format = "yyyy-MM-dd"
        col12.Width = 100
        Dim col13 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col13.MappingName = "guaranteesum"
        col13.HeaderText = "评审会通过金额(万元)"
        col13.Format = "n"
        col13.Alignment = HorizontalAlignment.Right
        Dim col14 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col14.MappingName = "sign_date"
        col14.HeaderText = "签约日期"
        col14.Format = "yyyy-MM-dd"
        col14.Width = 100
        Dim col15 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col15.MappingName = "sign_sum"
        col15.HeaderText = "签约金额(万元)"
        col15.Format = "n"
        col15.Alignment = HorizontalAlignment.Right
        Dim col16 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col16.MappingName = "starttime"
        col16.HeaderText = "放款起始日期"
        col16.Format = "yyyy-MM-dd"
        col16.Width = 100
        Dim col17 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col17.MappingName = "endtime"
        col17.HeaderText = "放款截至日期"
        col17.Format = "yyyy-MM-dd"
        col17.Width = 100
        Dim col18 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col18.MappingName = "loan_money"
        col18.HeaderText = "放款金额(万元)"
        col18.Width = 100
        col18.Format = "n" ' : col12.FormatInfo = CGFormatInfo
        col18.Alignment = HorizontalAlignment.Right
        col18.NullText = ""

        Dim col19 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col19.MappingName = "branch_name"
        col19.HeaderText = "责任部门"
        col19.NullText = ""
        col19.Width = 75

        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col4, col20, col21, col23, col24, col5, col6, col7, col8, col9, col10, col11, col12, col13, col14, col15, col16, col17, col18, col19})
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
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboArea As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboPhase As System.Windows.Forms.ComboBox
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cboPMA As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboOpinion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboRecommendType As System.Windows.Forms.ComboBox
    Friend WithEvents cboTrialConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents chkExempt As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryRegionProject))
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboArea = New System.Windows.Forms.ComboBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboPhase = New System.Windows.Forms.ComboBox()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPMA = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboOpinion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chkExempt = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboRecommendType = New System.Windows.Forms.ComboBox()
        Me.cboTrialConclusion = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboTrialConclusion, Me.Label9, Me.cboRecommendType, Me.Label7, Me.Label6, Me.chkExempt, Me.Label3, Me.cboPMA, Me.Label8, Me.Label5, Me.dtpEndDate, Me.chkDate, Me.cboPhase, Me.Label4, Me.dtpStartDate, Me.cboArea, Me.Label2, Me.Label1, Me.cboServiceType, Me.cboOpinion})
        Me.grpCondition.Size = New System.Drawing.Size(696, 144)
        Me.grpCondition.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(624, 160)
        Me.btnExit.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(520, 168)
        Me.btnPrint.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageIndex = -1
        Me.btnRefresh.ImageList = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(432, 160)
        Me.btnRefresh.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 160)
        Me.chkVisible.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Bitmap)
        Me.btnClear.ImageIndex = -1
        Me.btnClear.ImageList = Nothing
        Me.btnClear.Location = New System.Drawing.Point(192, 160)
        Me.btnClear.Visible = True
        '
        'ImageListQuery
        '
        Me.ImageListQuery.ImageStream = CType(resources.GetObject("ImageListQuery.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 192)
        Me.grdTable.Size = New System.Drawing.Size(696, 296)
        Me.grdTable.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Bitmap)
        Me.btnExport.ImageIndex = -1
        Me.btnExport.ImageList = Nothing
        Me.btnExport.Location = New System.Drawing.Point(528, 160)
        Me.btnExport.Visible = True
        '
        'cboServiceType
        '
        Me.cboServiceType.Location = New System.Drawing.Point(88, 20)
        Me.cboServiceType.MaxLength = 20
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(152, 20)
        Me.cboServiceType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "业务品种"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(280, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "合作区"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboArea
        '
        Me.cboArea.Location = New System.Drawing.Point(328, 20)
        Me.cboArea.MaxLength = 20
        Me.cboArea.Name = "cboArea"
        Me.cboArea.Size = New System.Drawing.Size(128, 20)
        Me.cboArea.TabIndex = 3
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Location = New System.Drawing.Point(88, 48)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(152, 21)
        Me.dtpStartDate.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(480, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 18)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "项目阶段"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPhase
        '
        Me.cboPhase.Location = New System.Drawing.Point(536, 20)
        Me.cboPhase.MaxLength = 4
        Me.cboPhase.Name = "cboPhase"
        Me.cboPhase.Size = New System.Drawing.Size(121, 20)
        Me.cboPhase.TabIndex = 7
        '
        'chkDate
        '
        Me.chkDate.BackColor = System.Drawing.SystemColors.Control
        Me.chkDate.Location = New System.Drawing.Point(8, 48)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(80, 20)
        Me.chkDate.TabIndex = 8
        Me.chkDate.Text = "推荐日期"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Location = New System.Drawing.Point(328, 48)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(128, 21)
        Me.dtpEndDate.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(304, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "到"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPMA
        '
        Me.cboPMA.DisplayMember = "staff_name"
        Me.cboPMA.Location = New System.Drawing.Point(536, 48)
        Me.cboPMA.MaxLength = 10
        Me.cboPMA.Name = "cboPMA"
        Me.cboPMA.Size = New System.Drawing.Size(120, 20)
        Me.cboPMA.TabIndex = 111
        Me.cboPMA.ValueMember = "staff_name"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(472, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "项目经理A"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboOpinion
        '
        Me.cboOpinion.Items.AddRange(New Object() {"同意", "不同意"})
        Me.cboOpinion.Location = New System.Drawing.Point(328, 80)
        Me.cboOpinion.Name = "cboOpinion"
        Me.cboOpinion.Size = New System.Drawing.Size(128, 20)
        Me.cboOpinion.TabIndex = 112
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(256, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 18)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "合作区意见"
        '
        'chkExempt
        '
        Me.chkExempt.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkExempt.Checked = True
        Me.chkExempt.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.chkExempt.Location = New System.Drawing.Point(536, 82)
        Me.chkExempt.Name = "chkExempt"
        Me.chkExempt.Size = New System.Drawing.Size(24, 16)
        Me.chkExempt.TabIndex = 114
        Me.chkExempt.ThreeState = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(488, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 23)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "豁 免"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(24, 80)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 23)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "推荐类型"
        '
        'cboRecommendType
        '
        Me.cboRecommendType.Items.AddRange(New Object() {"合作区推荐", "中心要求推荐"})
        Me.cboRecommendType.Location = New System.Drawing.Point(88, 80)
        Me.cboRecommendType.Name = "cboRecommendType"
        Me.cboRecommendType.Size = New System.Drawing.Size(152, 20)
        Me.cboRecommendType.TabIndex = 117
        '
        'cboTrialConclusion
        '
        Me.cboTrialConclusion.Location = New System.Drawing.Point(88, 112)
        Me.cboTrialConclusion.Name = "cboTrialConclusion"
        Me.cboTrialConclusion.Size = New System.Drawing.Size(152, 20)
        Me.cboTrialConclusion.TabIndex = 119
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(24, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 23)
        Me.Label9.TabIndex = 118
        Me.Label9.Text = "评审结论"
        '
        'FQueryRegionProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryRegionProject"
        Me.Text = "合作区项目管理一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class
