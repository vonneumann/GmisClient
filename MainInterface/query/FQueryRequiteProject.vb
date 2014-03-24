

Public Class FQueryRequiteProject
    Inherits MainInterface.FQueryBase

    Protected Overloads Sub GetCondition(ByRef ProjectCode As String, ByRef CorName As String, _
    ByRef ServiceType As String, ByRef MA As String, ByRef BankName As String, ByRef RefundType As String)
        ProjectCode = txtProjectCode.Text.Trim
        CorName = txtCorpName.Text.Trim
        ServiceType = cboServiceType.Text.Trim
        MA = cboMA.Text.Trim
        BankName = cboBank.Text.Trim
        RefundType = cboRefundType.Text.Trim
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal Condition As String)
        Dim StartDate, EndDate As Object
        Dim i As Integer
        Dim iTotalGuaranteeSum, iTotalDateSum, iTotalDateSums, iTotalRefundAverageSum, iTotalSurplusSum As Decimal
        Dim dtResult As DataTable

        StartDate = IIf(chkDate.Checked, dtpStartDate.Value.Date, Nothing)
        EndDate = IIf(chkDate.Checked, dtpEndDate.Value.Date, Nothing)
        If chkDate.Checked AndAlso DateTime.Parse(StartDate).Date > DateTime.Parse(EndDate).Date Then
            SWDialogBox.MessageBox.Show("$1008", "起始日期", "截止日期")
            'MessageBox.Show("截止日期应大于起始日期", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            dtpEndDate.Value = dtpStartDate.Value.Date
            Return
        End If
        Dim PC, CorName, SerT, MA, BankName, RefundType As String
        GetCondition(PC, CorName, SerT, MA, BankName, RefundType)
        dtResult = gWs.FQueryRequiteProject(PC, CorName, SerT, StartDate, EndDate, MA, BankName, RefundType, UserName).Tables(0)

        For i = 0 To dtResult.Rows.Count - 1
            'If Not IsDBNull(dtResult.Rows(i).Item("GuaranteeSum")) Then
            '    iTotalGuaranteeSum = iTotalGuaranteeSum + CDec(dtResult.Rows(i).Item("GuaranteeSum"))
            'End If
            If Not IsDBNull(dtResult.Rows(i).Item("DateSum")) Then
                iTotalDateSum = iTotalDateSum + CDec(dtResult.Rows(i).Item("DateSum"))
            End If
            'If Not IsDBNull(dtResult.Rows(i).Item("DateSums")) Then
            '    iTotalDateSums = iTotalDateSums + CDec(dtResult.Rows(i).Item("DateSums"))
            'End If
            If Not IsDBNull(dtResult.Rows(i).Item("refund_sum_average")) Then
                iTotalRefundAverageSum = iTotalRefundAverageSum + CDec(dtResult.Rows(i).Item("refund_sum_average"))
            End If
            'If Not IsDBNull(dtResult.Rows(i).Item("SurplusTotal")) Then
            '    iTotalSurplusSum = iTotalSurplusSum + CDec(dtResult.Rows(i).Item("SurplusTotal"))
            'End If
        Next
        Dim drRow As DataRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "合计："
            '.Item("GuaranteeSum") = iTotalGuaranteeSum
            .Item("DateSum") = iTotalDateSum
            '.Item("DateSums") = iTotalDateSums
            .Item("refund_sum_average") = iTotalRefundAverageSum
            ' .Item("SurplusTotal") = iTotalSurplusSum
        End With
        dtResult.Rows.Add(drRow)

        drRow = dtResult.NewRow
        With drRow
            .Item("enterprise_name") = "单数：" & i
        End With
        dtResult.Rows.Add(drRow)

        'ds.Tables(0).TableName = "TQueryRequiteProject"
        'grdTable.DataMember = "TQueryRequiteProject"
        grdTable.DataSource = dtResult
        MyBase.DataSource = dtResult
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        dtpStartDate.Enabled = chkDate.Checked
        dtpEndDate.Enabled = chkDate.Checked
    End Sub
    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ReportFile = Application.StartupPath & ".\Reports\QueryRequiteProject.rpt"
        ReportTitle = "还款项目一览表"
        '''''''''''''''''企业名称'''''''''''''''''''''''''
        'Dim ds As DataSet = gWs.GetcorporationInfo("%", "null")
        'cboCorName.DataSource = ds.Tables("corporation")
        'cboCorName.DisplayMember = "corporation_name"
        'cboCorName.ValueMember = "corporation_name"
        '''''''业务品种''''''''''''''''
        Dim dsST As DataSet = gWs.GetServiceType("%")
        cboServiceType.DataSource = dsST.Tables(0)
        cboServiceType.DisplayMember = "service_type"
        cboServiceType.ValueMember = "service_type"
        '''''''''''''贷款银行'''''''''''''''
        Dim dsBank As DataSet '= gWs.GetBankInfo("{0=0 order by bank_name}", "null")
        'qxd modify 2005-10-21 通过存储实现了按名称升序排序
        dsBank = gWs.GetBankInfo("%", "%")

        cboBank.DataSource = dsBank.Tables("bank")
        cboBank.DisplayMember = "bank_name"
        cboBank.ValueMember = "bank_code"
        ''''''''''''''还款方式'''''''''''''
        Dim dsFT As DataSet = gWs.GetRefundType("%")
        cboRefundType.DataSource = dsFT.Tables(0)
        cboRefundType.DisplayMember = "refund_type"
        cboRefundType.ValueMember = "refund_type"
        '''''''''''''项目经理A'''''''''''
        Dim strSql As String = "{not team_name is null}"
        Dim dsMA As DataSet = gWs.GetStaff(strSql)
        cboMA.DataSource = dsMA.Tables(0)
        cboMA.DisplayMember = "staff_name"
        cboMA.ValueMember = "staff_name"
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
        col3.MappingName = "service_type"
        col3.HeaderText = "业务品种"
        col3.Width = 110
        col3.NullText = ""
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.MappingName = "bank"
        col4.HeaderText = "贷款银行"
        col4.Width = 100
        col4.NullText = ""
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "manager_a"
        col5.HeaderText = "项目经理A角"
        col5.Width = 75
        col5.NullText = ""
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col6.MappingName = "manager_b"
        col6.HeaderText = "项目经理B角"
        col6.Width = 75
        col6.NullText = ""
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col7.MappingName = "GuaranteeSum"
        col7.Alignment = HorizontalAlignment.Right
        col7.HeaderText = "担保金额(万元)"
        'col7.Format = "n" : col7.FormatInfo = CGFormatInfo
        col7.Width = 75
        col7.NullText = ""
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col8.MappingName = "RefundType"
        col8.HeaderText = "还款方式"
        col8.Width = 100
        col8.NullText = ""
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col9.MappingName = "ReturnDate"
        col9.HeaderText = "还款日期"
        col9.Format = "yyyy-MM-dd"
        col9.Width = 75
        col9.NullText = ""
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col10.MappingName = "DateSum"
        col10.Alignment = HorizontalAlignment.Right
        col10.HeaderText = "还款金额(万元)"
        'col10.Format = "n"
        col10.NullText = "" : col10.Width = 100

        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col11.MappingName = "refund_sum_average"
        col11.Alignment = HorizontalAlignment.Right
        col11.HeaderText = "每期应还款额"
        col11.Width = 100 : col11.NullText = "" : col11.Format = "n" ': col11.FormatInfo = CGFormatInfo

        Dim col12 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col12.MappingName = "DateSums"
        col12.Alignment = HorizontalAlignment.Right
        col12.HeaderText = "累计还款金额(万元)"
        col12.NullText = ""
        ' col12.Format = "n"
        col12.Width = 110
        Dim col13 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col13.MappingName = "SurplusTotal"
        col13.Alignment = HorizontalAlignment.Right
        col13.HeaderText = "在保余额(万元)"
        col13.NullText = ""
        'col13.Format = "n"
        col13.Width = 100
        Dim col14 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col14.MappingName = "Remark"
        col14.HeaderText = "备注"
        col14.NullText = ""
        col14.Width = 100
        Dim col15 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col15.MappingName = "branch_name"
        col15.HeaderText = "责任部门"
        col15.NullText = ""
        col15.Width = 75
        Dim col16 As DataGridTextBoxColumn = New DataGridTextBoxColumn() 'status             2005-1-4 by 9sky
        col16.Format = ""
        col16.FormatInfo = Nothing
        col16.HeaderText = "项目状态"
        col16.MappingName = "status"
        col16.NullText = ""
        col16.Width = 75
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13, col14, col15, col16})
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents cboRefundType As System.Windows.Forms.ComboBox
    Friend WithEvents cboBank As System.Windows.Forms.ComboBox
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents cboMA As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.cboRefundType = New System.Windows.Forms.ComboBox()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.cboMA = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCorpName, Me.dtpEndDate, Me.Label8, Me.cboMA, Me.cboBank, Me.cboRefundType, Me.cboServiceType, Me.txtProjectCode, Me.Label7, Me.Label6, Me.Label5, Me.Label3, Me.Label2, Me.Label1, Me.chkDate, Me.dtpStartDate})
        Me.grpCondition.Size = New System.Drawing.Size(744, 104)
        Me.grpCondition.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 128)
        Me.chkVisible.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 128)
        Me.btnClear.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(568, 128)
        Me.btnExport.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(560, 120)
        Me.btnPrint.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 168)
        Me.grdTable.Size = New System.Drawing.Size(744, 320)
        Me.grdTable.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(664, 128)
        Me.btnExit.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(472, 128)
        Me.btnRefresh.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "项目编号" & Microsoft.VisualBasic.ChrW(13) & Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(232, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(480, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "业务品种"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "贷款银行"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(464, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "项目经理A角"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(232, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 16)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "还款方式"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(88, 16)
        Me.txtProjectCode.MaxLength = 11
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectCode.TabIndex = 7
        Me.txtProjectCode.Text = ""
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Location = New System.Drawing.Point(88, 64)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpStartDate.TabIndex = 9
        '
        'cboServiceType
        '
        Me.cboServiceType.Location = New System.Drawing.Point(544, 16)
        Me.cboServiceType.MaxLength = 20
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(168, 20)
        Me.cboServiceType.TabIndex = 10
        '
        'cboRefundType
        '
        Me.cboRefundType.Location = New System.Drawing.Point(288, 40)
        Me.cboRefundType.MaxLength = 10
        Me.cboRefundType.Name = "cboRefundType"
        Me.cboRefundType.Size = New System.Drawing.Size(152, 20)
        Me.cboRefundType.TabIndex = 11
        '
        'cboBank
        '
        Me.cboBank.Location = New System.Drawing.Point(88, 40)
        Me.cboBank.MaxLength = 20
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(120, 20)
        Me.cboBank.TabIndex = 13
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(8, 62)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(80, 24)
        Me.chkDate.TabIndex = 14
        Me.chkDate.Text = "还款日期"
        '
        'cboMA
        '
        Me.cboMA.Location = New System.Drawing.Point(544, 40)
        Me.cboMA.MaxLength = 10
        Me.cboMA.Name = "cboMA"
        Me.cboMA.Size = New System.Drawing.Size(168, 20)
        Me.cboMA.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(264, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "到"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Location = New System.Drawing.Point(288, 64)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(152, 21)
        Me.dtpEndDate.TabIndex = 17
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(288, 16)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(152, 21)
        Me.txtCorpName.TabIndex = 18
        Me.txtCorpName.Text = ""
        '
        'FQueryRequiteProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(760, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryRequiteProject"
        Me.Text = "还款项目一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
End Class
