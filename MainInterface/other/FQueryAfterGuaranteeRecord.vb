Public Class FQueryAfterGuaranteeRecord
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
    Friend WithEvents cboMA As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtAfterGuaranteeRecord As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents project_code As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents serial_num As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents check_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents EnterpriseName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents manager_A As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents loan_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ServiceType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents RefundType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iTotalRefund As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents guaranting_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents alarm_type_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents explanation As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents status As DataGridTextBoxColumn
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents file_load_date As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.cboMA = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtAfterGuaranteeRecord = New System.Windows.Forms.DataGridTableStyle()
        Me.project_code = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.serial_num = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.check_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.EnterpriseName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.manager_A = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.loan_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ServiceType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.RefundType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iTotalRefund = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.guaranting_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.alarm_type_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.file_load_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.explanation = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.status = New DataGridTextBoxColumn()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkVisible
        '
        Me.chkVisible.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCorpName, Me.Label2, Me.Label1, Me.cboServiceType, Me.cboMA, Me.Label6, Me.lblToDate, Me.dtpToDate, Me.dtpFromDate, Me.chkDate})
        Me.grpCondition.Size = New System.Drawing.Size(696, 88)
        Me.grpCondition.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Visible = True
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
        Me.grdTable.Location = New System.Drawing.Point(8, 152)
        Me.grdTable.Size = New System.Drawing.Size(696, 336)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dtAfterGuaranteeRecord})
        Me.grdTable.Visible = True
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(280, 56)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(17, 14)
        Me.lblToDate.TabIndex = 26
        Me.lblToDate.Text = "到"
        '
        'dtpToDate
        '
        Me.dtpToDate.Enabled = False
        Me.dtpToDate.Location = New System.Drawing.Point(304, 48)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(128, 21)
        Me.dtpToDate.TabIndex = 27
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CalendarFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Enabled = False
        Me.dtpFromDate.Location = New System.Drawing.Point(88, 48)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(128, 21)
        Me.dtpFromDate.TabIndex = 25
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(16, 48)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(80, 24)
        Me.chkDate.TabIndex = 28
        Me.chkDate.Text = "跟踪日期"
        '
        'cboMA
        '
        Me.cboMA.DisplayMember = "staff_name"
        Me.cboMA.Location = New System.Drawing.Point(504, 24)
        Me.cboMA.MaxLength = 10
        Me.cboMA.Name = "cboMA"
        Me.cboMA.Size = New System.Drawing.Size(128, 20)
        Me.cboMA.TabIndex = 39
        Me.cboMA.ValueMember = "staff_name"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(448, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 24)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "项目经理"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtAfterGuaranteeRecord
        '
        Me.dtAfterGuaranteeRecord.DataGrid = Me.grdTable
        Me.dtAfterGuaranteeRecord.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.project_code, Me.serial_num, Me.check_date, Me.EnterpriseName, Me.manager_A, Me.loan_sum, Me.ServiceType, Me.RefundType, Me.iTotalRefund, Me.guaranting_sum, Me.alarm_type_name, Me.file_load_date, Me.status, Me.explanation})
        Me.dtAfterGuaranteeRecord.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dtAfterGuaranteeRecord.MappingName = "Table"
        '
        'project_code
        '
        Me.project_code.Format = ""
        Me.project_code.FormatInfo = Nothing
        Me.project_code.HeaderText = "项目编码"
        Me.project_code.MappingName = "project_code"
        Me.project_code.NullText = ""
        Me.project_code.Width = 75
        '
        'serial_num
        '
        Me.serial_num.Format = ""
        Me.serial_num.FormatInfo = Nothing
        Me.serial_num.HeaderText = "序号"
        Me.serial_num.MappingName = "serial_num"
        Me.serial_num.NullText = ""
        Me.serial_num.Width = 60
        '
        'check_date
        '
        Me.check_date.Format = "yyyy-MM-dd"
        Me.check_date.FormatInfo = Nothing
        Me.check_date.HeaderText = "跟踪日期"
        Me.check_date.MappingName = "check_date"
        Me.check_date.NullText = ""
        Me.check_date.Width = 80
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
        'manager_A
        '
        Me.manager_A.Format = ""
        Me.manager_A.FormatInfo = Nothing
        Me.manager_A.HeaderText = "项目经理"
        Me.manager_A.MappingName = "manager_A"
        Me.manager_A.NullText = ""
        Me.manager_A.Width = 75
        '
        'loan_sum
        '
        Me.loan_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.loan_sum.Format = ""
        Me.loan_sum.FormatInfo = Nothing
        Me.loan_sum.HeaderText = "承保金额"
        Me.loan_sum.MappingName = "loan_sum"
        Me.loan_sum.NullText = ""
        Me.loan_sum.Width = 75
        '
        'ServiceType
        '
        Me.ServiceType.Format = ""
        Me.ServiceType.FormatInfo = Nothing
        Me.ServiceType.HeaderText = "业务品种"
        Me.ServiceType.MappingName = "ServiceType"
        Me.ServiceType.NullText = ""
        Me.ServiceType.Width = 75
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
        'iTotalRefund
        '
        Me.iTotalRefund.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.iTotalRefund.Format = "n"
        Me.iTotalRefund.FormatInfo = Nothing
        Me.iTotalRefund.HeaderText = "累计还款"
        Me.iTotalRefund.MappingName = "iTotalRefund"
        Me.iTotalRefund.NullText = ""
        Me.iTotalRefund.Width = 120
        '
        'guaranting_sum
        '
        Me.guaranting_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.guaranting_sum.Format = "n"
        Me.guaranting_sum.FormatInfo = Nothing
        Me.guaranting_sum.HeaderText = "在保余额"
        Me.guaranting_sum.MappingName = "guaranting_sum"
        Me.guaranting_sum.NullText = ""
        Me.guaranting_sum.Width = 120
        '
        'alarm_type_name
        '
        Me.alarm_type_name.Format = ""
        Me.alarm_type_name.FormatInfo = Nothing
        Me.alarm_type_name.HeaderText = "项目评价"
        Me.alarm_type_name.MappingName = "alarm_type_name"
        Me.alarm_type_name.NullText = ""
        Me.alarm_type_name.Width = 80
        '
        'file_load_date
        '
        Me.file_load_date.Format = "yyyy-MM-dd"
        Me.file_load_date.FormatInfo = Nothing
        Me.file_load_date.HeaderText = "文档上载时间"
        Me.file_load_date.MappingName = "file_load_date"
        Me.file_load_date.Width = 90
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
        'explanation
        '
        Me.explanation.Format = ""
        Me.explanation.FormatInfo = Nothing
        Me.explanation.HeaderText = "备注"
        Me.explanation.MappingName = "explanation"
        Me.explanation.NullText = ""
        Me.explanation.Width = 120
        '
        'cboServiceType
        '
        Me.cboServiceType.DisplayMember = "service_type"
        Me.cboServiceType.Location = New System.Drawing.Point(304, 24)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(128, 20)
        Me.cboServiceType.TabIndex = 40
        Me.cboServiceType.ValueMember = "service_type"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(248, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "业务品种"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "企业名称"
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(88, 24)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(128, 21)
        Me.txtCorpName.TabIndex = 43
        Me.txtCorpName.Text = ""
        '
        'FQueryAfterGuaranteeRecord
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryAfterGuaranteeRecord"
        Me.Text = "保后检查一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FQueryAfterGuaranteeRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboMA.DataSource = gWs.GetStaff("{not team_name is null}").Tables(0)
        cboServiceType.DataSource = gWs.GetServiceType("%").Tables(0)
        Clear()
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        dtpFromDate.Enabled = chkDate.Checked
        dtpToDate.Enabled = chkDate.Checked
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal Condition As String)
        Dim strCorpName, strServiceType, strMA As String
        Dim dtDateFrom, dtDateTo As Object
        Dim i As Integer
        Dim iTotalLoanSum, iTotalGuarantingSum, iTotalRefundSum As Decimal
        Dim dtResult As DataTable

        strCorpName = txtCorpName.Text.Trim
        strServiceType = cboServiceType.Text.Trim
        strMA = cboMA.Text.Trim()
        dtDateFrom = IIf(chkDate.Checked, dtpFromDate.Value.Date, Nothing)
        dtDateTo = IIf(chkDate.Checked, dtpToDate.Value.Date, Nothing)

        dtResult = gWs.Usp_GetAfterGuaranteeRecord(strCorpName, strServiceType, strMA, dtDateFrom, dtDateTo, UserName).Tables(0)

        For i = 0 To dtResult.Rows.Count - 1
            If Not IsDBNull(dtResult.Rows(i).Item("loan_sum")) Then
                iTotalLoanSum = iTotalLoanSum + CDec(dtResult.Rows(i).Item("loan_sum"))
            End If
            If Not IsDBNull(dtResult.Rows(i).Item("guaranting_sum")) Then
                iTotalGuarantingSum = iTotalGuarantingSum + CDec(dtResult.Rows(i).Item("guaranting_sum"))
            End If
            If Not IsDBNull(dtResult.Rows(i).Item("iTotalRefund")) Then
                iTotalRefundSum = iTotalRefundSum + CDec(dtResult.Rows(i).Item("iTotalRefund"))
            End If
        Next
        Dim drRow As DataRow = dtResult.NewRow
        With drRow
            .Item("EnterpriseName") = "合计："
            .Item("loan_sum") = iTotalLoanSum
            .Item("guaranting_sum") = iTotalGuarantingSum
            .Item("iTotalRefund") = iTotalRefundSum
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
        ReportToExcel.ToExcel(Me.grdTable, "保后检查一览表", "保后检查一览表")
    End Sub

End Class
