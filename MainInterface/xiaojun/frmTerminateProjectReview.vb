

Public Class frmTerminateProjectReview
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
    Friend WithEvents lblServiceType As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tTerminateProjectReview As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents ProjectCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents EnterpriseName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ServiceType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents StartTime As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents EndTime As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents certificate_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents RefundType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents refund_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents BankName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents chbDate As System.Windows.Forms.CheckBox
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents loan_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents detail_reason As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents appraisement As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents terminate_time As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ManagerA As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.tTerminateProjectReview = New System.Windows.Forms.DataGridTableStyle()
        Me.ProjectCode = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.EnterpriseName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ServiceType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.loan_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.StartTime = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.EndTime = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.certificate_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.RefundType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.refund_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.BankName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ManagerA = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.detail_reason = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.appraisement = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.terminate_time = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.chbDate = New System.Windows.Forms.CheckBox()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 96)
        Me.chkVisible.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(408, 96)
        Me.btnExport.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(512, 96)
        Me.btnPrint.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboServiceType, Me.chbDate, Me.lblServiceType, Me.Label2, Me.Label1, Me.dtpEndDate, Me.dtpStartDate})
        Me.grpCondition.Size = New System.Drawing.Size(696, 72)
        Me.grpCondition.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(304, 96)
        Me.btnRefresh.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 136)
        Me.grdTable.Size = New System.Drawing.Size(696, 336)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tTerminateProjectReview})
        Me.grdTable.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(616, 96)
        Me.btnExit.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 96)
        Me.btnClear.Visible = True
        '
        'lblServiceType
        '
        Me.lblServiceType.Location = New System.Drawing.Point(400, 40)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.TabIndex = 15
        Me.lblServiceType.Text = "业务品种："
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(232, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "到"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "查询时间段："
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(264, 32)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpEndDate.TabIndex = 12
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(112, 32)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpStartDate.TabIndex = 11
        '
        'tTerminateProjectReview
        '
        Me.tTerminateProjectReview.DataGrid = Me.grdTable
        Me.tTerminateProjectReview.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.ProjectCode, Me.EnterpriseName, Me.ServiceType, Me.loan_sum, Me.StartTime, Me.EndTime, Me.certificate_date, Me.RefundType, Me.refund_sum, Me.BankName, Me.ManagerA, Me.detail_reason, Me.appraisement, Me.terminate_time})
        Me.tTerminateProjectReview.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tTerminateProjectReview.MappingName = "Table"
        '
        'ProjectCode
        '
        Me.ProjectCode.Format = ""
        Me.ProjectCode.FormatInfo = Nothing
        Me.ProjectCode.HeaderText = "项目编号"
        Me.ProjectCode.MappingName = "ProjectCode"
        Me.ProjectCode.Width = 75
        '
        'EnterpriseName
        '
        Me.EnterpriseName.Format = ""
        Me.EnterpriseName.FormatInfo = Nothing
        Me.EnterpriseName.HeaderText = "企业名称"
        Me.EnterpriseName.MappingName = "EnterpriseName"
        Me.EnterpriseName.Width = 75
        '
        'ServiceType
        '
        Me.ServiceType.Format = ""
        Me.ServiceType.FormatInfo = Nothing
        Me.ServiceType.HeaderText = "业务品种"
        Me.ServiceType.MappingName = "ServiceType"
        Me.ServiceType.Width = 75
        '
        'loan_sum
        '
        Me.loan_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.loan_sum.Format = "c"
        Me.loan_sum.FormatInfo = Nothing
        Me.loan_sum.HeaderText = "贷款金额"
        Me.loan_sum.MappingName = "loan_sum"
        Me.loan_sum.Width = 75
        '
        'StartTime
        '
        Me.StartTime.Format = ""
        Me.StartTime.FormatInfo = Nothing
        Me.StartTime.HeaderText = "贷款日期"
        Me.StartTime.MappingName = "StartTime"
        Me.StartTime.Width = 75
        '
        'EndTime
        '
        Me.EndTime.Format = ""
        Me.EndTime.FormatInfo = Nothing
        Me.EndTime.HeaderText = "截止日期"
        Me.EndTime.MappingName = "EndTime"
        Me.EndTime.Width = 75
        '
        'certificate_date
        '
        Me.certificate_date.Format = ""
        Me.certificate_date.FormatInfo = Nothing
        Me.certificate_date.HeaderText = "还款日期"
        Me.certificate_date.MappingName = "certificate_date"
        Me.certificate_date.Width = 75
        '
        'RefundType
        '
        Me.RefundType.Format = ""
        Me.RefundType.FormatInfo = Nothing
        Me.RefundType.HeaderText = "还款方式"
        Me.RefundType.MappingName = "RefundType"
        Me.RefundType.Width = 75
        '
        'refund_sum
        '
        Me.refund_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.refund_sum.Format = "c"
        Me.refund_sum.FormatInfo = Nothing
        Me.refund_sum.HeaderText = "撤保金额"
        Me.refund_sum.MappingName = "refund_sum"
        Me.refund_sum.Width = 75
        '
        'BankName
        '
        Me.BankName.Format = ""
        Me.BankName.FormatInfo = Nothing
        Me.BankName.HeaderText = "贷款银行"
        Me.BankName.MappingName = "BankName"
        Me.BankName.Width = 75
        '
        'ManagerA
        '
        Me.ManagerA.Format = ""
        Me.ManagerA.FormatInfo = Nothing
        Me.ManagerA.HeaderText = "项目A角"
        Me.ManagerA.MappingName = "ManagerA"
        Me.ManagerA.Width = 75
        '
        'detail_reason
        '
        Me.detail_reason.Format = ""
        Me.detail_reason.FormatInfo = Nothing
        Me.detail_reason.HeaderText = "终止原因"
        Me.detail_reason.MappingName = "detail_reason"
        Me.detail_reason.Width = 75
        '
        'appraisement
        '
        Me.appraisement.Format = ""
        Me.appraisement.FormatInfo = Nothing
        Me.appraisement.HeaderText = "项目评价"
        Me.appraisement.MappingName = "appraisement"
        Me.appraisement.Width = 75
        '
        'terminate_time
        '
        Me.terminate_time.Format = ""
        Me.terminate_time.FormatInfo = Nothing
        Me.terminate_time.HeaderText = "终止时间"
        Me.terminate_time.MappingName = "terminate_time"
        Me.terminate_time.Width = 75
        '
        'chbDate
        '
        Me.chbDate.Checked = True
        Me.chbDate.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbDate.Location = New System.Drawing.Point(16, 32)
        Me.chbDate.Name = "chbDate"
        Me.chbDate.Size = New System.Drawing.Size(16, 24)
        Me.chbDate.TabIndex = 16
        '
        'cboServiceType
        '
        Me.cboServiceType.DisplayMember = "service_type"
        Me.cboServiceType.Location = New System.Drawing.Point(464, 32)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(168, 20)
        Me.cboServiceType.TabIndex = 17
        Me.cboServiceType.ValueMember = "service_type"
        '
        'frmTerminateProjectReview
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "frmTerminateProjectReview"
        Me.Text = "项目终止一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMaturityProjectReview_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboServiceType.DataSource = gWs.GetServiceType("%").Tables(0)
        MyBase.ReportFile = Application.StartupPath & "\Reports\rptTerminateProject.rpt"
        MyBase.ReportTitle = "终止项目一览表"
    End Sub

    Private Overloads Sub GetCondition(ByRef strServiceType As String, ByRef dtpStartDate As Object, ByRef dtpEndDate As Object)
        dtpStartDate = IIf(Me.chbDate.Checked, Me.dtpStartDate.Value, "1900-01-01")
        dtpEndDate = IIf(Me.chbDate.Checked, Me.dtpEndDate.Value, "9998-12-31")
        determineDate(dtpStartDate, dtpEndDate)
        strServiceType = cboServiceType.Text.Trim()
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim strServiceType As String
        Dim dtpStartDate, dtpEndDate As Object
        Dim dsResult As DataSet
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            GetCondition(strServiceType, dtpStartDate, dtpEndDate)
            dsResult = gWs.GetTerminateProjectReview(strServiceType, dtpStartDate, dtpEndDate)
            If Not dsResult Is Nothing Then
                'Me.grdTable.DataSource = gWs.GetTerminateProjectReview(strServiceType, dtpStartDate, dtpEndDate).Tables(0)
                Me.grdTable.DataSource = dsResult.Tables(0)
                MyBase.DataSource = dsResult.Tables(0)
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Exit Sub
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    '判断起始和截止日期
    Private Sub determineDate(ByVal dateStart As Date, ByVal dateEnd As Date)
        If dateStart.Date > dateEnd.Date Then
            'MsgBox("截止日期必须大于或等于起始日期", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1008", "起始日期", "截止日期")
            dtpEndDate.Value = dtpStartDate.Value
        End If
    End Sub

    Private Sub chbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbDate.CheckedChanged
        If Not Me.chbDate.Checked Then
            Me.dtpStartDate.Enabled = False
            Me.dtpEndDate.Enabled = False
        Else
            Me.dtpStartDate.Enabled = True
            Me.dtpEndDate.Enabled = True
        End If
    End Sub

End Class
