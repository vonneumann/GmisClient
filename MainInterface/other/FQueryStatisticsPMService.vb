

Public Class FQueryStatisticsPMService
    Inherits MainInterface.FQueryBase
    '项目经理业务情况统计
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
    Friend WithEvents cmbEndMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEndYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStartYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbManager As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents YearMonth As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents StaffName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ServiceType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents RecordCount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TotalSum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SigCount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents SigSum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents VouchCount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents VouchSum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents StaffType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iReviewFee As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iGuaranteeFee As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbEndMonth = New System.Windows.Forms.ComboBox()
        Me.cmbEndYear = New System.Windows.Forms.ComboBox()
        Me.cmbStartYear = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbManager = New System.Windows.Forms.ComboBox()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.YearMonth = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.StaffName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ServiceType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.RecordCount = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.TotalSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SigCount = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SigSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.VouchCount = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.VouchSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iReviewFee = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iGuaranteeFee = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.StaffType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 96)
        Me.chkVisible.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(408, 96)
        Me.btnRefresh.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbManager, Me.Label6, Me.cmbEndMonth, Me.cmbEndYear, Me.cmbStartYear, Me.Label2, Me.Label1})
        Me.grpCondition.Size = New System.Drawing.Size(696, 72)
        Me.grpCondition.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 136)
        Me.grdTable.Size = New System.Drawing.Size(696, 352)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.grdTable.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 96)
        Me.btnClear.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(512, 96)
        Me.btnExport.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(616, 96)
        Me.btnExit.Visible = True
        '
        'cmbEndMonth
        '
        Me.cmbEndMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEndMonth.Location = New System.Drawing.Point(272, 24)
        Me.cmbEndMonth.Name = "cmbEndMonth"
        Me.cmbEndMonth.Size = New System.Drawing.Size(44, 20)
        Me.cmbEndMonth.TabIndex = 12
        '
        'cmbEndYear
        '
        Me.cmbEndYear.Location = New System.Drawing.Point(208, 24)
        Me.cmbEndYear.MaxLength = 4
        Me.cmbEndYear.Name = "cmbEndYear"
        Me.cmbEndYear.Size = New System.Drawing.Size(64, 20)
        Me.cmbEndYear.TabIndex = 11
        '
        'cmbStartYear
        '
        Me.cmbStartYear.Location = New System.Drawing.Point(80, 24)
        Me.cmbStartYear.MaxLength = 4
        Me.cmbStartYear.Name = "cmbStartYear"
        Me.cmbStartYear.Size = New System.Drawing.Size(64, 20)
        Me.cmbStartYear.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(152, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "截止年月"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "起始年份"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(336, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 23)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "项目经理"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbManager
        '
        Me.cmbManager.Location = New System.Drawing.Point(392, 24)
        Me.cmbManager.Name = "cmbManager"
        Me.cmbManager.Size = New System.Drawing.Size(121, 20)
        Me.cmbManager.TabIndex = 17
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.YearMonth, Me.StaffName, Me.ServiceType, Me.RecordCount, Me.TotalSum, Me.SigCount, Me.SigSum, Me.VouchCount, Me.VouchSum, Me.iReviewFee, Me.iGuaranteeFee, Me.StaffType})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'YearMonth
        '
        Me.YearMonth.Format = ""
        Me.YearMonth.FormatInfo = Nothing
        Me.YearMonth.HeaderText = "年月"
        Me.YearMonth.MappingName = "YearMonth"
        Me.YearMonth.NullText = ""
        Me.YearMonth.Width = 75
        '
        'StaffName
        '
        Me.StaffName.Format = ""
        Me.StaffName.FormatInfo = Nothing
        Me.StaffName.HeaderText = "项目经理"
        Me.StaffName.MappingName = "StaffName"
        Me.StaffName.NullText = ""
        Me.StaffName.Width = 75
        '
        'ServiceType
        '
        Me.ServiceType.Format = ""
        Me.ServiceType.FormatInfo = Nothing
        Me.ServiceType.HeaderText = "业务品种"
        Me.ServiceType.MappingName = "ServiceType"
        Me.ServiceType.NullText = ""
        Me.ServiceType.Width = 170
        '
        'RecordCount
        '
        Me.RecordCount.Format = ""
        Me.RecordCount.FormatInfo = Nothing
        Me.RecordCount.HeaderText = "单数"
        Me.RecordCount.MappingName = "RecordCount"
        Me.RecordCount.NullText = "0"
        Me.RecordCount.Width = 0
        '
        'TotalSum
        '
        Me.TotalSum.Format = "n"
        Me.TotalSum.FormatInfo = Nothing
        Me.TotalSum.HeaderText = " 评审通过金额(万元)"
        Me.TotalSum.MappingName = "TotalSum"
        Me.TotalSum.NullText = "0.00"
        Me.TotalSum.Width = 0
        '
        'SigCount
        '
        Me.SigCount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.SigCount.Format = ""
        Me.SigCount.FormatInfo = Nothing
        Me.SigCount.HeaderText = "签约单数"
        Me.SigCount.MappingName = "SigCount"
        Me.SigCount.NullText = "0"
        Me.SigCount.Width = 80
        '
        'SigSum
        '
        Me.SigSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.SigSum.Format = "n"
        Me.SigSum.FormatInfo = Nothing
        Me.SigSum.HeaderText = "签约金额(万元)"
        Me.SigSum.MappingName = "SigSum"
        Me.SigSum.NullText = "0.00"
        Me.SigSum.Width = 120
        '
        'VouchCount
        '
        Me.VouchCount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.VouchCount.Format = ""
        Me.VouchCount.FormatInfo = Nothing
        Me.VouchCount.HeaderText = "承保单数"
        Me.VouchCount.MappingName = "VouchCount"
        Me.VouchCount.NullText = "0"
        Me.VouchCount.Width = 80
        '
        'VouchSum
        '
        Me.VouchSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.VouchSum.Format = "n"
        Me.VouchSum.FormatInfo = Nothing
        Me.VouchSum.HeaderText = "承保金额(万元)"
        Me.VouchSum.MappingName = "VouchSum"
        Me.VouchSum.NullText = "0.00"
        Me.VouchSum.Width = 120
        '
        'iReviewFee
        '
        Me.iReviewFee.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.iReviewFee.Format = "n"
        Me.iReviewFee.FormatInfo = Nothing
        Me.iReviewFee.HeaderText = "评审费"
        Me.iReviewFee.MappingName = "iReviewFee"
        Me.iReviewFee.NullText = ""
        Me.iReviewFee.Width = 120
        '
        'iGuaranteeFee
        '
        Me.iGuaranteeFee.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.iGuaranteeFee.Format = "n"
        Me.iGuaranteeFee.FormatInfo = Nothing
        Me.iGuaranteeFee.HeaderText = "担保费"
        Me.iGuaranteeFee.MappingName = "iGuaranteeFee"
        Me.iGuaranteeFee.NullText = ""
        Me.iGuaranteeFee.Width = 120
        '
        'StaffType
        '
        Me.StaffType.Format = ""
        Me.StaffType.FormatInfo = Nothing
        Me.StaffType.HeaderText = "类别"
        Me.StaffType.MappingName = "StaffType"
        Me.StaffType.NullText = ""
        Me.StaffType.Width = 75
        '
        'FQueryStatisticsPMService
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryStatisticsPMService"
        Me.Text = "项目经理业务情况统计表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FQueryStatisticsPMService_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setYear()
        setMonth()
        setManager()
        MyBase.chkVisible.Visible = False
        MyBase.btnClear.Visible = False
        MyBase.ReportFile = Application.StartupPath & "\Reports\QueryStatisticsPMService.rpt"
        MyBase.ReportTitle = "项目经理业务情况统计表"
    End Sub
    '设置(起始,截止)年份的初始值
    Private Sub setYear()
        Dim i As Integer
        For i = 1950 To 2050
            Me.cmbStartYear.Items.Add(i)
            Me.cmbEndYear.Items.Add(i)
        Next
        Me.cmbStartYear.SelectedItem = Date.Now.Year
        Me.cmbEndYear.SelectedItem = Date.Now.Year
    End Sub
    '设置月份的初始值
    Private Sub setMonth()
        Dim i As Integer
        For i = 1 To 12
            Me.cmbEndMonth.Items.Add(i)
        Next
        Me.cmbEndMonth.SelectedItem = Date.Now.Month
    End Sub
    '设置项目经理
    Private Sub setManager()
        Dim ds As DataSet
        Dim strSql As String
        strSql = "{not team_name is null}"
        Try
            ds = gWs.GetStaff(strSql)
            If Not ds Is Nothing Then
                Me.cmbManager.DataSource = ds.Tables(0)
                Me.cmbManager.DisplayMember = "staff_name"
                Me.cmbManager.ValueMember = "staff_name"
                Me.cmbManager.SelectedValue = ""
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '获得查询条件
    Private Overloads Sub GetCondition(ByRef startYear As String, ByRef endYear As String, ByRef endMonth As String, ByRef manager As String)
        startYear = Me.cmbStartYear.Text.Trim
        endYear = Me.cmbEndYear.Text.Trim
        endMonth = Me.cmbEndMonth.Text.Trim
        manager = Me.cmbManager.Text.Trim
    End Sub
    '查询
    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim startYear, endYear, endMonth, manager As String
        GetCondition(startYear, endYear, endMonth, manager)
        If startYear.Trim = "" Then
            'MsgBox("日期不能为空!", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1001", "年份")
            Me.cmbStartYear.Focus()
            Exit Sub
        End If
        If endYear.Trim = "" Then
            'MsgBox("日期不能为空!", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1001", "年份")
            Me.cmbEndYear.Focus()
            Exit Sub
        End If
        If determineDate(startYear, endYear) Then
            Exit Sub
        End If
        Dim dsResult As DataSet
        Dim recordCount As Integer

        dsResult = gWs.FQueryStatisticsPMService(startYear, endYear + endMonth, manager, UserName)
        If Not dsResult Is Nothing Then
            MyBase.DataSource = dsResult.Tables(0)
            Me.grdTable.DataSource = dsResult.Tables(0)
            recordCount = dsResult.Tables(0).Rows.Count
            Me.Text = "项目经理业务情况统计表" & "(" & recordCount & ")"
        End If
    End Sub
    '覆盖Clear()方法
    Protected Overrides Sub Clear()
        Dim control As Control
        Try
            For Each control In grpCondition.Controls
                If control.GetType() Is GetType(ComboBox) Then
                    CType(control, ComboBox).SelectedItem = Date.Now.Year
                    CType(control, ComboBox).SelectedItem = Date.Now.Month
                End If
            Next
            If Not Me.cmbManager Is Nothing Then
                Me.cmbManager.SelectedIndex = -1
                Me.cmbManager.SelectedItem = Nothing
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '判断起始年份和截止年份的大小
    '判断起始和截止日期
    Private Function determineDate(ByVal dateStart As String, ByVal dateEnd As String)
        If dateStart > dateEnd Then
            'MsgBox("截止年份必须大于或等于起始年份", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1008", "起始年份", "截止年份")
            Me.cmbStartYear.Text = dateEnd
            Return True
        End If
    End Function
    'Protected Overrides Sub Export()

    '    Dim export As ReportToExcel = New ReportToExcel()
    '    Dim array As New ArrayList()
    '    Dim array2 As New ArrayList()
    '    Dim array3 As New ArrayList()
    '    Dim array4 As New ArrayList()
    '    Dim array5 As New ArrayList()

    '    array.Add("0")
    '    array.Add("贷款担保")
    '    array.Add("评审通过金额(万元)")
    '    array.Add("签约金额(万元)")
    '    array.Add("在保金额(万元)")

    '    array5.Add("0")
    '    array5.Add("年月")
    '    array5.Add("评审通过金额(万元)")
    '    array5.Add("签约金额(万元)")
    '    array5.Add("在保金额(万元)")

    '    array2.Add("2")
    '    array2.Add("年月")
    '    array2.Add("评审通过金额(万元)")
    '    array2.Add("签约金额(万元)")
    '    array2.Add("在保金额(万元)")

    '    array3.Add("1")
    '    array3.Add("年月")
    '    array3.Add("评审通过金额(万元)")
    '    array3.Add("签约金额(万元)")
    '    array3.Add("在保金额(万元)")

    '    array4.Add("3")
    '    array4.Add("年月")
    '    array4.Add("签约金额(万元)")
    '    array4.Add("在保金额(万元)")

    '    Dim arrayList As New ArrayList()
    '    arrayList.Add(array)
    '    arrayList.Add(array2)
    '    arrayList.Add(array3)
    '    arrayList.Add(array4)
    '    arrayList.Add(array5)


    '    export.ToExcel(grdTable, ReportTitle, ReportTitle, arrayList)
    'End Sub
End Class
