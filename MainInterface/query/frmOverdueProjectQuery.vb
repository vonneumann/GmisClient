Public Class frmOverdueProjectQuery
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
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents tOverDueInfo As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents ProjectCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents EnterpriseName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ServiceType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_A As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents overdue_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents overdue_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents StartTime As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents EndTime As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents loan_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iIncomingSumOfOverDue As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iRemainSumOfOverDue As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents corpus As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents interest As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents status As DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOverdueProjectQuery))
        Me.cboPMA = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.tOverDueInfo = New System.Windows.Forms.DataGridTableStyle()
        Me.ProjectCode = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.EnterpriseName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ServiceType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.manager_A = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.overdue_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.corpus = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.interest = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.overdue_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.StartTime = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.EndTime = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.loan_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iIncomingSumOfOverDue = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iRemainSumOfOverDue = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.status = New DataGridTextBoxColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Size = New System.Drawing.Size(704, 344)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tOverDueInfo})
        Me.grdTable.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboPMA, Me.Label8, Me.cboServiceType, Me.Label3, Me.txtProjectCode, Me.Label2, Me.dtpEndDate, Me.Label1, Me.dtpStartDate, Me.chkDate})
        Me.grpCondition.Size = New System.Drawing.Size(704, 96)
        Me.grpCondition.Visible = True
        '
        'cboPMA
        '
        Me.cboPMA.DisplayMember = "staff_name"
        Me.cboPMA.Location = New System.Drawing.Point(525, 26)
        Me.cboPMA.MaxLength = 10
        Me.cboPMA.Name = "cboPMA"
        Me.cboPMA.Size = New System.Drawing.Size(142, 20)
        Me.cboPMA.TabIndex = 131
        Me.cboPMA.ValueMember = "staff_name"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(461, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 130
        Me.Label8.Text = "项目经理A"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboServiceType
        '
        Me.cboServiceType.Location = New System.Drawing.Point(293, 26)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(144, 20)
        Me.cboServiceType.TabIndex = 129
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 128
        Me.Label3.Text = "业务品种"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(101, 26)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(112, 21)
        Me.txtProjectCode.TabIndex = 127
        Me.txtProjectCode.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 126
        Me.Label2.Text = "项目编码"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Location = New System.Drawing.Point(293, 56)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpEndDate.TabIndex = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 14)
        Me.Label1.TabIndex = 124
        Me.Label1.Text = "到"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Location = New System.Drawing.Point(101, 56)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpStartDate.TabIndex = 123
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(29, 56)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(80, 20)
        Me.chkDate.TabIndex = 122
        Me.chkDate.Text = "逾期日期"
        '
        'tOverDueInfo
        '
        Me.tOverDueInfo.DataGrid = Me.grdTable
        Me.tOverDueInfo.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.ProjectCode, Me.EnterpriseName, Me.ServiceType, Me.manager_A, Me.overdue_date, Me.corpus, Me.interest, Me.overdue_sum, Me.StartTime, Me.EndTime, Me.loan_sum, Me.iIncomingSumOfOverDue, Me.iRemainSumOfOverDue, Me.status})
        Me.tOverDueInfo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tOverDueInfo.MappingName = "Table"
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
        'EnterpriseName
        '
        Me.EnterpriseName.Format = ""
        Me.EnterpriseName.FormatInfo = Nothing
        Me.EnterpriseName.HeaderText = "企业名称"
        Me.EnterpriseName.MappingName = "EnterpriseName"
        Me.EnterpriseName.NullText = ""
        Me.EnterpriseName.Width = 200
        '
        'ServiceType
        '
        Me.ServiceType.Format = ""
        Me.ServiceType.FormatInfo = Nothing
        Me.ServiceType.HeaderText = "业务品种"
        Me.ServiceType.MappingName = "ServiceType"
        Me.ServiceType.NullText = ""
        Me.ServiceType.Width = 120
        '
        'manager_A
        '
        Me.manager_A.Format = ""
        Me.manager_A.FormatInfo = Nothing
        Me.manager_A.HeaderText = "项目经理A"
        Me.manager_A.MappingName = "manager_A"
        Me.manager_A.NullText = ""
        Me.manager_A.Width = 75
        '
        'overdue_date
        '
        Me.overdue_date.Format = "yyyy-MM-dd"
        Me.overdue_date.FormatInfo = Nothing
        Me.overdue_date.HeaderText = "逾期日期"
        Me.overdue_date.MappingName = "overdue_date"
        Me.overdue_date.NullText = ""
        Me.overdue_date.Width = 75
        '
        'corpus
        '
        Me.corpus.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.corpus.Format = "n"
        Me.corpus.FormatInfo = Nothing
        Me.corpus.HeaderText = "未偿还本金(元)"
        Me.corpus.MappingName = "corpus"
        Me.corpus.Width = 75
        '
        'interest
        '
        Me.interest.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.interest.Format = "n"
        Me.interest.FormatInfo = Nothing
        Me.interest.HeaderText = "未偿还利息(元)"
        Me.interest.MappingName = "interest"
        Me.interest.Width = 75
        '
        'overdue_sum
        '
        Me.overdue_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.overdue_sum.Format = "n"
        Me.overdue_sum.FormatInfo = Nothing
        Me.overdue_sum.HeaderText = "逾期金额(元)"
        Me.overdue_sum.MappingName = "overdue_sum"
        Me.overdue_sum.NullText = ""
        Me.overdue_sum.Width = 120
        '
        'StartTime
        '
        Me.StartTime.Format = "yyyy-MM-dd"
        Me.StartTime.FormatInfo = Nothing
        Me.StartTime.HeaderText = "起始日期"
        Me.StartTime.MappingName = "StartTime"
        Me.StartTime.NullText = ""
        Me.StartTime.Width = 75
        '
        'EndTime
        '
        Me.EndTime.Format = "yyyy-MM-dd"
        Me.EndTime.FormatInfo = Nothing
        Me.EndTime.HeaderText = "截止日期"
        Me.EndTime.MappingName = "EndTime"
        Me.EndTime.NullText = ""
        Me.EndTime.Width = 75
        '
        'loan_sum
        '
        Me.loan_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.loan_sum.Format = ""
        Me.loan_sum.FormatInfo = Nothing
        Me.loan_sum.HeaderText = "承保金额(万元)"
        Me.loan_sum.MappingName = "loan_sum"
        Me.loan_sum.NullText = ""
        Me.loan_sum.Width = 75
        '
        'iIncomingSumOfOverDue
        '
        Me.iIncomingSumOfOverDue.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.iIncomingSumOfOverDue.Format = "n"
        Me.iIncomingSumOfOverDue.FormatInfo = Nothing
        Me.iIncomingSumOfOverDue.HeaderText = "逾期后追回金额(元)"
        Me.iIncomingSumOfOverDue.MappingName = "iIncomingSumOfOverDue"
        Me.iIncomingSumOfOverDue.NullText = ""
        Me.iIncomingSumOfOverDue.Width = 120
        '
        'iRemainSumOfOverDue
        '
        Me.iRemainSumOfOverDue.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.iRemainSumOfOverDue.Format = "n"
        Me.iRemainSumOfOverDue.FormatInfo = Nothing
        Me.iRemainSumOfOverDue.HeaderText = "应追偿金额(元)"
        Me.iRemainSumOfOverDue.MappingName = "iRemainSumOfOverDue"
        Me.iRemainSumOfOverDue.NullText = ""
        Me.iRemainSumOfOverDue.Width = 120
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
        'frmOverdueProjectQuery
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(722, 495)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOverdueProjectQuery"
        Me.Text = "逾期项目一览表"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmOverdueProjectQuery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsST As DataSet = gWs.GetServiceType("%")
        cboServiceType.DataSource = dsST.Tables(0)
        cboServiceType.DisplayMember = "service_type"
        cboServiceType.ValueMember = "service_type"

        cboPMA.DataSource = gWs.GetStaff("{not team_name is null}").Tables(0)

    End Sub

    Protected Overrides Sub Export()
        ReportToExcel.ToExcel(Me.grdTable, "逾期项目一览表", "逾期项目一览表")
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal strCondition As String)
        Dim StartTime, EndTime As Object
        Dim i As Integer
        Dim iTotalLoanSum, iTotalOverDueSum, iTotalIncomingSumOfOverDue, iTotalRemainSumOfOverDue As Decimal
        Dim dtResult As DataTable

        StartTime = IIf(chkDate.Checked, dtpStartDate.Value.Date, Nothing)
        EndTime = IIf(chkDate.Checked, dtpEndDate.Value.Date, Nothing)
        If chkDate.Checked AndAlso DateTime.Parse(StartTime).Date > DateTime.Parse(EndTime).Date Then
            SWDialogBox.MessageBox.Show("$1008", "起始日期", "截止日期")
            dtpEndDate.Value = dtpStartDate.Value.Date
            Return
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            dtResult = gWs.GetOverdueProjectList(txtProjectCode.Text.Trim, cboServiceType.Text.Trim, StartTime, EndTime, cboPMA.Text.Trim, UserName).Tables(0)

            For i = 0 To dtResult.Rows.Count - 1
                If Not IsDBNull(dtResult.Rows(i).Item("loan_sum")) Then
                    iTotalLoanSum = iTotalLoanSum + CDec(dtResult.Rows(i).Item("loan_sum"))
                End If
                If Not IsDBNull(dtResult.Rows(i).Item("overdue_sum")) Then
                    iTotalOverDueSum = iTotalOverDueSum + CDec(dtResult.Rows(i).Item("overdue_sum"))
                End If
                If Not IsDBNull(dtResult.Rows(i).Item("iIncomingSumOfOverDue")) Then
                    iTotalIncomingSumOfOverDue = iTotalIncomingSumOfOverDue + CDec(dtResult.Rows(i).Item("iIncomingSumOfOverDue"))
                End If
                If Not IsDBNull(dtResult.Rows(i).Item("iRemainSumOfOverDue")) Then
                    iTotalRemainSumOfOverDue = iTotalRemainSumOfOverDue + CDec(dtResult.Rows(i).Item("iRemainSumOfOverDue"))
                End If
            Next
            Dim drRow As DataRow = dtResult.NewRow
            With drRow
                .Item("EnterpriseName") = "合计："
                .Item("loan_sum") = iTotalLoanSum
                .Item("overdue_sum") = iTotalOverDueSum
                .Item("iIncomingSumOfOverDue") = iTotalIncomingSumOfOverDue
                .Item("iRemainSumOfOverDue") = iTotalRemainSumOfOverDue
            End With
            dtResult.Rows.Add(drRow)

            drRow = dtResult.NewRow
            With drRow
                .Item("EnterpriseName") = "单数：" & i
            End With
            dtResult.Rows.Add(drRow)

            'dgList.DataMember = "Table"
            Me.grdTable.DataSource = dtResult
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        dtpEndDate.Enabled = chkDate.Checked
        dtpStartDate.Enabled = chkDate.Checked
    End Sub

End Class
