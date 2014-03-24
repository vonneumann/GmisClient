
Public Class frmMaturityProjectReview
    'Inherits MainInterface.frmSearchBaseClass
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblServiceType As System.Windows.Forms.Label
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents tMaturityProject As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents ProjectCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents EnterpriseName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ServiceType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents loan_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents StartTime As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents EndTime As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents certificate_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents RefundType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents refund_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ProjectBalance As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents BankName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_A As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents chbDate As System.Windows.Forms.CheckBox
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents branch_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents status As DataGridTextBoxColumn   '2005-1-4 by 9sky
    Friend WithEvents cboPMA As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMaturityProjectReview))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.tMaturityProject = New System.Windows.Forms.DataGridTableStyle()
        Me.ProjectCode = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.EnterpriseName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ServiceType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.loan_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.StartTime = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.EndTime = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.certificate_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.RefundType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.refund_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ProjectBalance = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.BankName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.manager_A = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.branch_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.chbDate = New System.Windows.Forms.CheckBox()
        Me.cboPMA = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboPMA, Me.Label8, Me.chbDate, Me.cboServiceType, Me.lblServiceType, Me.Label2, Me.dtpEndDate, Me.dtpStartDate})
        Me.grpCondition.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(608, 120)
        Me.btnExit.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 120)
        Me.chkVisible.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.Location = New System.Drawing.Point(416, 120)
        Me.btnRefresh.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(504, 96)
        Me.btnPrint.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Bitmap)
        Me.btnClear.Location = New System.Drawing.Point(192, 120)
        Me.btnClear.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = ""
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 160)
        Me.grdTable.Size = New System.Drawing.Size(696, 328)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tMaturityProject})
        Me.grdTable.Visible = True
        '
        'ImageListQuery
        '
        Me.ImageListQuery.ImageStream = CType(resources.GetObject("ImageListQuery.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Bitmap)
        Me.btnExport.Location = New System.Drawing.Point(512, 120)
        Me.btnExport.Visible = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(248, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "到"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(272, 36)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpEndDate.TabIndex = 5
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(120, 36)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpStartDate.TabIndex = 4
        '
        'lblServiceType
        '
        Me.lblServiceType.Location = New System.Drawing.Point(416, 35)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.TabIndex = 8
        Me.lblServiceType.Text = "业务品种"
        '
        'cboServiceType
        '
        Me.cboServiceType.DisplayMember = "service_type"
        Me.cboServiceType.Location = New System.Drawing.Point(472, 36)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(168, 20)
        Me.cboServiceType.TabIndex = 9
        Me.cboServiceType.ValueMember = "service_type"
        '
        'tMaturityProject
        '
        Me.tMaturityProject.DataGrid = Me.grdTable
        Me.tMaturityProject.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.ProjectCode, Me.EnterpriseName, Me.ServiceType, Me.loan_sum, Me.StartTime, Me.EndTime, Me.certificate_date, Me.RefundType, Me.refund_sum, Me.ProjectBalance, Me.BankName, Me.manager_A, Me.branch_name, Me.status})
        Me.tMaturityProject.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tMaturityProject.MappingName = "Table"
        '
        'ProjectCode
        '
        Me.ProjectCode.Format = ""
        Me.ProjectCode.FormatInfo = Nothing
        Me.ProjectCode.HeaderText = "项目编号"
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
        Me.EnterpriseName.Width = 150
        '
        'ServiceType
        '
        Me.ServiceType.Format = ""
        Me.ServiceType.FormatInfo = Nothing
        Me.ServiceType.HeaderText = "业务品种"
        Me.ServiceType.MappingName = "ServiceType"
        Me.ServiceType.NullText = ""
        Me.ServiceType.Width = 110
        '
        'loan_sum
        '
        Me.loan_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.loan_sum.Format = "n"
        Me.loan_sum.FormatInfo = Nothing
        Me.loan_sum.HeaderText = "承保金额(万元)"
        Me.loan_sum.MappingName = "loan_sum"
        Me.loan_sum.NullText = ""
        Me.loan_sum.Width = 75
        '
        'StartTime
        '
        Me.StartTime.Format = "yyyy-MM-dd"
        Me.StartTime.FormatInfo = Nothing
        Me.StartTime.HeaderText = "承保期起"
        Me.StartTime.MappingName = "StartTime"
        Me.StartTime.NullText = ""
        Me.StartTime.Width = 75
        '
        'EndTime
        '
        Me.EndTime.Format = "yyyy-MM-dd"
        Me.EndTime.FormatInfo = Nothing
        Me.EndTime.HeaderText = "承保期止"
        Me.EndTime.MappingName = "EndTime"
        Me.EndTime.NullText = ""
        Me.EndTime.Width = 75
        '
        'certificate_date
        '
        Me.certificate_date.Format = "yyyy-MM-dd"
        Me.certificate_date.FormatInfo = Nothing
        Me.certificate_date.HeaderText = "撤保日期"
        Me.certificate_date.MappingName = "certificate_date"
        Me.certificate_date.NullText = ""
        Me.certificate_date.Width = 75
        '
        'RefundType
        '
        Me.RefundType.Format = ""
        Me.RefundType.FormatInfo = Nothing
        Me.RefundType.HeaderText = "还款方式"
        Me.RefundType.MappingName = "RefundType"
        Me.RefundType.NullText = ""
        Me.RefundType.Width = 75
        '
        'refund_sum
        '
        Me.refund_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.refund_sum.Format = "n"
        Me.refund_sum.FormatInfo = Nothing
        Me.refund_sum.HeaderText = "撤保金额(万元)"
        Me.refund_sum.MappingName = "refund_sum"
        Me.refund_sum.NullText = ""
        Me.refund_sum.Width = 90
        '
        'ProjectBalance
        '
        Me.ProjectBalance.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.ProjectBalance.Format = "n"
        Me.ProjectBalance.FormatInfo = Nothing
        Me.ProjectBalance.HeaderText = "项目余额(万元)"
        Me.ProjectBalance.MappingName = "ProjectBalance"
        Me.ProjectBalance.NullText = ""
        Me.ProjectBalance.Width = 90
        '
        'BankName
        '
        Me.BankName.Format = ""
        Me.BankName.FormatInfo = Nothing
        Me.BankName.HeaderText = "合作银行"
        Me.BankName.MappingName = "BankName"
        Me.BankName.NullText = ""
        Me.BankName.Width = 90
        '
        'manager_A
        '
        Me.manager_A.Format = ""
        Me.manager_A.FormatInfo = Nothing
        Me.manager_A.HeaderText = "项目A角"
        Me.manager_A.MappingName = "manager_A"
        Me.manager_A.NullText = ""
        Me.manager_A.Width = 75
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
        'status
        '
        Me.status.Format = ""
        Me.status.FormatInfo = Nothing
        Me.status.HeaderText = "项目状态"
        Me.status.MappingName = "status"
        Me.status.NullText = ""
        Me.status.Width = 75
        '
        'chbDate
        '
        Me.chbDate.Checked = True
        Me.chbDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbDate.Location = New System.Drawing.Point(16, 34)
        Me.chbDate.Name = "chbDate"
        Me.chbDate.TabIndex = 10
        Me.chbDate.Text = "承保截至日期"
        '
        'cboPMA
        '
        Me.cboPMA.DisplayMember = "staff_name"
        Me.cboPMA.Location = New System.Drawing.Point(120, 64)
        Me.cboPMA.MaxLength = 10
        Me.cboPMA.Name = "cboPMA"
        Me.cboPMA.Size = New System.Drawing.Size(112, 20)
        Me.cboPMA.TabIndex = 111
        Me.cboPMA.ValueMember = "staff_name"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(48, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "项目经理A"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMaturityProjectReview
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "frmMaturityProjectReview"
        Me.Text = "项目到期一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMaturityProjectReview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboServiceType.DataSource = gWs.GetServiceType("%").Tables(0)
        cboPMA.DataSource = gWs.GetStaff("{not team_name is null}").Tables(0)
        'MyBase.Clear()
        MyBase.ReportFile = Application.StartupPath & "\Reports\TMaturityProjectReview.rpt"
        MyBase.ReportTitle = "到期项目一览表"
    End Sub

    Private Overloads Sub GetCondition(ByRef strServiceType As String, ByRef dtpStartDate As Object, ByRef dtpEndDate As Object, ByRef strPMA As String)
        dtpStartDate = IIf(Me.chbDate.Checked, Me.dtpStartDate.Value.Date, Nothing)
        dtpEndDate = IIf(Me.chbDate.Checked, Me.dtpEndDate.Value.Date, Nothing)
        determineDate(dtpStartDate, dtpEndDate)
        strServiceType = cboServiceType.Text.Trim()
        strPMA = cboPMA.Text.Trim()
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim strServiceType, strPMA As String
        Dim dtpStartDate, dtpEndDate As Object
        Dim i As Integer
        Dim iTotalLoanSum, iTotalRefundSum, iTotalProjectBalance As Decimal
        Dim dtResult As DataTable

        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            GetCondition(strServiceType, dtpStartDate, dtpEndDate, strPMA)
            dtResult = gWs.GetMaturityProjectReview(strServiceType, dtpStartDate, dtpEndDate, strPMA, UserName).Tables(0)

            For i = 0 To dtResult.Rows.Count - 1
                If Not IsDBNull(dtResult.Rows(i).Item("loan_sum")) Then
                    iTotalLoanSum = iTotalLoanSum + CDec(dtResult.Rows(i).Item("loan_sum"))
                End If
                If Not IsDBNull(dtResult.Rows(i).Item("refund_sum")) Then
                    iTotalRefundSum = iTotalRefundSum + CDec(dtResult.Rows(i).Item("refund_sum"))
                End If
                If Not IsDBNull(dtResult.Rows(i).Item("ProjectBalance")) Then
                    iTotalProjectBalance = iTotalProjectBalance + CDec(dtResult.Rows(i).Item("ProjectBalance"))
                End If
            Next
            Dim drRow As DataRow = dtResult.NewRow
            With drRow
                .Item("EnterpriseName") = "合计："
                .Item("loan_sum") = iTotalLoanSum
                .Item("refund_sum") = iTotalRefundSum
                .Item("ProjectBalance") = iTotalProjectBalance
            End With
            dtResult.Rows.Add(drRow)

            drRow = dtResult.NewRow
            With drRow
                .Item("EnterpriseName") = "单数：" & i
            End With
            dtResult.Rows.Add(drRow)

            If Not dtResult Is Nothing Then
                Me.grdTable.DataSource = dtResult
                MyBase.DataSource = dtResult
            End If

        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Exit Sub
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub chbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbDate.CheckedChanged
        'IIf(chbDate.Checked, dtpStartDate.Enabled = False, dtpStartDate.Enabled = True)
        'IIf(chbDate.Checked, dtpEndDate.Enabled = False, dtpEndDate.Enabled = True)
        If Not Me.chbDate.Checked Then
            Me.dtpStartDate.Enabled = False
            Me.dtpEndDate.Enabled = False
        Else
            Me.dtpStartDate.Enabled = True
            Me.dtpEndDate.Enabled = True
        End If
    End Sub

    '判断起始和截止日期
    Private Sub determineDate(ByVal dateStart As Date, ByVal dateEnd As Date)
        If dateStart.Date > dateEnd.Date Then
            'MsgBox("截止日期必须大于或等于起始日期", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1008", "起始日期", "截止日期")
            dtpEndDate.Value = dtpStartDate.Value
        End If
    End Sub

End Class
