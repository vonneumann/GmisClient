Public Class FQueryGetGuaranteeProject
    Inherits MainInterface.FQueryBase

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
    Friend WithEvents lblToDate As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents dtGuarnateeProject As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents ProjectCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents EnterPriseName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents workflow As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents StartTime As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents EndTime As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents income As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents certificate_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents loan_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_A As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_B As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GuaranteeSum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents guarantee_letter_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents terms As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents conference_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents beneficiary As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents status As DataGridTextBoxColumn
    Friend WithEvents cboPMA As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.dtGuarnateeProject = New System.Windows.Forms.DataGridTableStyle()
        Me.ProjectCode = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.EnterPriseName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.workflow = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.loan_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.StartTime = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.EndTime = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.income = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.certificate_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.guarantee_letter_type = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.manager_A = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.manager_B = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GuaranteeSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.terms = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.conference_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.beneficiary = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.status = New DataGridTextBoxColumn()
        Me.cboPMA = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(616, 96)
        Me.btnExit.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboPMA, Me.Label8, Me.lblToDate, Me.dtpToDate, Me.dtpFromDate, Me.chkDate})
        Me.grpCondition.Size = New System.Drawing.Size(696, 72)
        Me.grpCondition.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 96)
        Me.chkVisible.Visible = True
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
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dtGuarnateeProject})
        Me.grdTable.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(512, 96)
        Me.btnExport.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(408, 96)
        Me.btnRefresh.Visible = True
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(224, 40)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(17, 14)
        Me.lblToDate.TabIndex = 26
        Me.lblToDate.Text = "到"
        '
        'dtpToDate
        '
        Me.dtpToDate.Enabled = False
        Me.dtpToDate.Location = New System.Drawing.Point(256, 32)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(128, 21)
        Me.dtpToDate.TabIndex = 27
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CalendarFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Enabled = False
        Me.dtpFromDate.Location = New System.Drawing.Point(88, 32)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpFromDate.TabIndex = 25
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(8, 32)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(80, 24)
        Me.chkDate.TabIndex = 28
        Me.chkDate.Text = "开具日期"
        '
        'dtGuarnateeProject
        '
        Me.dtGuarnateeProject.DataGrid = Me.grdTable
        Me.dtGuarnateeProject.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.ProjectCode, Me.EnterPriseName, Me.workflow, Me.loan_sum, Me.StartTime, Me.EndTime, Me.income, Me.certificate_date, Me.guarantee_letter_type, Me.manager_A, Me.manager_B, Me.GuaranteeSum, Me.terms, Me.conference_date, Me.beneficiary, Me.status})
        Me.dtGuarnateeProject.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtGuarnateeProject.MappingName = "Table"
        '
        'ProjectCode
        '
        Me.ProjectCode.Format = ""
        Me.ProjectCode.FormatInfo = Nothing
        Me.ProjectCode.HeaderText = "项目编码"
        Me.ProjectCode.MappingName = "ProjectCode"
        Me.ProjectCode.NullText = ""
        Me.ProjectCode.Width = 75
        '
        'EnterPriseName
        '
        Me.EnterPriseName.Format = ""
        Me.EnterPriseName.FormatInfo = Nothing
        Me.EnterPriseName.HeaderText = "企业名称"
        Me.EnterPriseName.MappingName = "EnterPriseName"
        Me.EnterPriseName.NullText = ""
        Me.EnterPriseName.Width = 150
        '
        'workflow
        '
        Me.workflow.Format = ""
        Me.workflow.FormatInfo = Nothing
        Me.workflow.HeaderText = "运作方式"
        Me.workflow.MappingName = "workflow"
        Me.workflow.NullText = ""
        Me.workflow.Width = 85
        '
        'loan_sum
        '
        Me.loan_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.loan_sum.Format = ""
        Me.loan_sum.FormatInfo = Nothing
        Me.loan_sum.HeaderText = "承保金额(万元)"
        Me.loan_sum.MappingName = "loan_sum"
        Me.loan_sum.NullText = ""
        Me.loan_sum.Width = 85
        '
        'StartTime
        '
        Me.StartTime.Format = "yyyy-MM-dd"
        Me.StartTime.FormatInfo = Nothing
        Me.StartTime.HeaderText = "开具日期"
        Me.StartTime.MappingName = "StartTime"
        Me.StartTime.NullText = ""
        Me.StartTime.Width = 80
        '
        'EndTime
        '
        Me.EndTime.Format = "yyyy-MM-dd"
        Me.EndTime.FormatInfo = Nothing
        Me.EndTime.HeaderText = "到期日期"
        Me.EndTime.MappingName = "EndTime"
        Me.EndTime.NullText = ""
        Me.EndTime.Width = 80
        '
        'income
        '
        Me.income.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.income.Format = "n"
        Me.income.FormatInfo = Nothing
        Me.income.HeaderText = "保证金(元)"
        Me.income.MappingName = "income"
        Me.income.NullText = ""
        Me.income.Width = 100
        '
        'certificate_date
        '
        Me.certificate_date.Format = "yyyy-MM-dd"
        Me.certificate_date.FormatInfo = Nothing
        Me.certificate_date.HeaderText = "撤保日期"
        Me.certificate_date.MappingName = "certificate_date"
        Me.certificate_date.NullText = ""
        Me.certificate_date.Width = 80
        '
        'guarantee_letter_type
        '
        Me.guarantee_letter_type.Format = ""
        Me.guarantee_letter_type.FormatInfo = Nothing
        Me.guarantee_letter_type.HeaderText = "保函种类"
        Me.guarantee_letter_type.MappingName = "guarantee_letter_type"
        Me.guarantee_letter_type.NullText = ""
        Me.guarantee_letter_type.Width = 75
        '
        'manager_A
        '
        Me.manager_A.Format = ""
        Me.manager_A.FormatInfo = Nothing
        Me.manager_A.HeaderText = "项目经理A角"
        Me.manager_A.MappingName = "manager_A"
        Me.manager_A.NullText = ""
        Me.manager_A.Width = 80
        '
        'manager_B
        '
        Me.manager_B.Format = ""
        Me.manager_B.FormatInfo = Nothing
        Me.manager_B.HeaderText = "项目经理B角"
        Me.manager_B.MappingName = "manager_B"
        Me.manager_B.NullText = ""
        Me.manager_B.Width = 80
        '
        'GuaranteeSum
        '
        Me.GuaranteeSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.GuaranteeSum.Format = ""
        Me.GuaranteeSum.FormatInfo = Nothing
        Me.GuaranteeSum.HeaderText = "评审会通过金额(万元)"
        Me.GuaranteeSum.MappingName = "GuaranteeSum"
        Me.GuaranteeSum.NullText = ""
        Me.GuaranteeSum.Width = 100
        '
        'terms
        '
        Me.terms.Format = ""
        Me.terms.FormatInfo = Nothing
        Me.terms.HeaderText = "通过期限(月)"
        Me.terms.MappingName = "terms"
        Me.terms.NullText = ""
        Me.terms.Width = 75
        '
        'conference_date
        '
        Me.conference_date.Format = "yyyy-MM-dd"
        Me.conference_date.FormatInfo = Nothing
        Me.conference_date.HeaderText = "通过日期"
        Me.conference_date.MappingName = "conference_date"
        Me.conference_date.NullText = ""
        Me.conference_date.Width = 80
        '
        'beneficiary
        '
        Me.beneficiary.Format = ""
        Me.beneficiary.FormatInfo = Nothing
        Me.beneficiary.HeaderText = "受益人"
        Me.beneficiary.MappingName = "beneficiary"
        Me.beneficiary.NullText = ""
        Me.beneficiary.Width = 120
        '
        'status             2005-1-4 by 9sky
        '
        Me.status.Format = ""
        Me.status.FormatInfo = Nothing
        Me.status.HeaderText = "项目状态"
        Me.status.MappingName = "status"
        Me.status.NullText = ""
        Me.status.Width = 75
        '
        'cboPMA
        '
        Me.cboPMA.DisplayMember = "staff_name"
        Me.cboPMA.Location = New System.Drawing.Point(472, 32)
        Me.cboPMA.MaxLength = 10
        Me.cboPMA.Name = "cboPMA"
        Me.cboPMA.Size = New System.Drawing.Size(142, 20)
        Me.cboPMA.TabIndex = 111
        Me.cboPMA.ValueMember = "staff_name"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(408, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "项目经理A"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FQueryGetGuaranteeProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryGetGuaranteeProject"
        Me.Text = "保函项目一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        dtpFromDate.Enabled = chkDate.Checked
        dtpToDate.Enabled = chkDate.Checked
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal Condition As String)
        'Dim strProjectCode, strCorpName, strServiceType, strPhase As String
        Dim dtDateFrom, dtDateTo As Object
        Dim strPMA As String
        Dim i As Integer
        Dim iTotalLoanSum, iTotalGuaranteeSum, iTotalIncomeSum As Decimal
        Dim dtResult As DataTable

        dtDateFrom = IIf(chkDate.Checked, dtpFromDate.Value.Date, Nothing)
        dtDateTo = IIf(chkDate.Checked, dtpToDate.Value.Date, Nothing)
        strPMA = cboPMA.Text.Trim

        dtResult = gWs.Usp_GetGuaranteeProject(dtDateFrom, dtDateTo, strPMA, UserName).Tables(0)

        For i = 0 To dtResult.Rows.Count - 1
            If Not IsDBNull(dtResult.Rows(i).Item("loan_sum")) Then
                iTotalLoanSum = iTotalLoanSum + CDec(dtResult.Rows(i).Item("loan_sum"))
            End If
            If Not IsDBNull(dtResult.Rows(i).Item("GuaranteeSum")) Then
                iTotalGuaranteeSum = iTotalGuaranteeSum + CDec(dtResult.Rows(i).Item("GuaranteeSum"))
            End If
            If Not IsDBNull(dtResult.Rows(i).Item("income")) Then
                iTotalIncomeSum = iTotalIncomeSum + CDec(dtResult.Rows(i).Item("income"))
            End If
        Next
        Dim drRow As DataRow = dtResult.NewRow
        With drRow
            .Item("EnterpriseName") = "合计："
            .Item("loan_sum") = iTotalLoanSum
            .Item("GuaranteeSum") = iTotalGuaranteeSum
            .Item("income") = iTotalIncomeSum
        End With
        dtResult.Rows.Add(drRow)

        drRow = dtResult.NewRow
        With drRow
            .Item("EnterpriseName") = "单数：" & i
        End With
        dtResult.Rows.Add(drRow)
        Me.grdTable.DataSource = dtResult

    End Sub

    Protected Overrides Sub Export()
        ReportToExcel.ToExcel(Me.grdTable, "保函项目一览表", "保函项目一览表")
    End Sub

    Private Sub FQueryGetGuaranteeProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboPMA.DataSource = gWs.GetStaff("{not team_name is null}").Tables(0)
    End Sub
End Class
