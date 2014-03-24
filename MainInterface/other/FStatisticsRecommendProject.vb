Imports System
Imports System.Data
Imports System.Data.SqlClient
'项目来源情况统计
Public Class FStatisticsRecommendProject
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
    Friend WithEvents cboMonthEnd As System.Windows.Forms.ComboBox
    Friend WithEvents cboYearEnd As System.Windows.Forms.ComboBox
    Friend WithEvents cboYearStart As System.Windows.Forms.ComboBox
    Friend WithEvents lblStaff As System.Windows.Forms.Label
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents cboMonthStart As System.Windows.Forms.ComboBox
    Friend WithEvents radStatisticsByYear As System.Windows.Forms.RadioButton
    Friend WithEvents radStatisticsByMonth As System.Windows.Forms.RadioButton
    Friend WithEvents radStatisticsByTime As System.Windows.Forms.RadioButton
    Friend WithEvents tsRecommendProject As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csYearMonth As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csRecommendPerson As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csApplySum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csApplyCount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csSignSum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csSignCount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csLoanSum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csLoanCount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboRecommendType As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboRecommendType = New System.Windows.Forms.ComboBox()
        Me.lblStaff = New System.Windows.Forms.Label()
        Me.cboMonthEnd = New System.Windows.Forms.ComboBox()
        Me.cboYearEnd = New System.Windows.Forms.ComboBox()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.cboYearStart = New System.Windows.Forms.ComboBox()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.cboMonthStart = New System.Windows.Forms.ComboBox()
        Me.radStatisticsByYear = New System.Windows.Forms.RadioButton()
        Me.radStatisticsByMonth = New System.Windows.Forms.RadioButton()
        Me.radStatisticsByTime = New System.Windows.Forms.RadioButton()
        Me.tsRecommendProject = New System.Windows.Forms.DataGridTableStyle()
        Me.csYearMonth = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csRecommendPerson = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csApplySum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csApplyCount = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSignSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSignCount = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csLoanSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csLoanCount = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(520, 72)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(616, 104)
        Me.btnExit.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(520, 104)
        Me.btnExport.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(424, 104)
        Me.btnRefresh.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 104)
        Me.btnClear.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 104)
        Me.chkVisible.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 136)
        Me.grdTable.Size = New System.Drawing.Size(696, 352)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsRecommendProject})
        Me.grdTable.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.radStatisticsByTime, Me.radStatisticsByMonth, Me.radStatisticsByYear, Me.cboMonthStart, Me.cboRecommendType, Me.lblStaff, Me.cboMonthEnd, Me.cboYearEnd, Me.lblEndDate, Me.cboYearStart, Me.lblStartDate})
        Me.grpCondition.Size = New System.Drawing.Size(696, 88)
        Me.grpCondition.Visible = True
        '
        'cboRecommendType
        '
        Me.cboRecommendType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboRecommendType.Location = New System.Drawing.Point(464, 24)
        Me.cboRecommendType.MaxLength = 4
        Me.cboRecommendType.Name = "cboRecommendType"
        Me.cboRecommendType.Size = New System.Drawing.Size(176, 22)
        Me.cboRecommendType.TabIndex = 13
        '
        'lblStaff
        '
        Me.lblStaff.Location = New System.Drawing.Point(400, 32)
        Me.lblStaff.Name = "lblStaff"
        Me.lblStaff.Size = New System.Drawing.Size(64, 16)
        Me.lblStaff.TabIndex = 12
        Me.lblStaff.Text = "推荐类型"
        '
        'cboMonthEnd
        '
        Me.cboMonthEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonthEnd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonthEnd.Location = New System.Drawing.Point(304, 24)
        Me.cboMonthEnd.MaxLength = 2
        Me.cboMonthEnd.Name = "cboMonthEnd"
        Me.cboMonthEnd.Size = New System.Drawing.Size(40, 22)
        Me.cboMonthEnd.TabIndex = 11
        '
        'cboYearEnd
        '
        Me.cboYearEnd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearEnd.Location = New System.Drawing.Point(248, 24)
        Me.cboYearEnd.MaxLength = 4
        Me.cboYearEnd.Name = "cboYearEnd"
        Me.cboYearEnd.Size = New System.Drawing.Size(56, 22)
        Me.cboYearEnd.TabIndex = 10
        '
        'lblEndDate
        '
        Me.lblEndDate.Location = New System.Drawing.Point(184, 32)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(64, 16)
        Me.lblEndDate.TabIndex = 9
        Me.lblEndDate.Text = "截止年月"
        '
        'cboYearStart
        '
        Me.cboYearStart.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearStart.Location = New System.Drawing.Point(80, 24)
        Me.cboYearStart.MaxLength = 4
        Me.cboYearStart.Name = "cboYearStart"
        Me.cboYearStart.Size = New System.Drawing.Size(56, 22)
        Me.cboYearStart.TabIndex = 8
        '
        'lblStartDate
        '
        Me.lblStartDate.Location = New System.Drawing.Point(16, 32)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(64, 16)
        Me.lblStartDate.TabIndex = 7
        Me.lblStartDate.Text = "起始年月"
        '
        'cboMonthStart
        '
        Me.cboMonthStart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonthStart.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonthStart.Location = New System.Drawing.Point(136, 24)
        Me.cboMonthStart.MaxLength = 2
        Me.cboMonthStart.Name = "cboMonthStart"
        Me.cboMonthStart.Size = New System.Drawing.Size(40, 22)
        Me.cboMonthStart.TabIndex = 14
        '
        'radStatisticsByYear
        '
        Me.radStatisticsByYear.Location = New System.Drawing.Point(256, 56)
        Me.radStatisticsByYear.Name = "radStatisticsByYear"
        Me.radStatisticsByYear.Size = New System.Drawing.Size(120, 24)
        Me.radStatisticsByYear.TabIndex = 15
        Me.radStatisticsByYear.Text = "按年份统计(&1)"
        '
        'radStatisticsByMonth
        '
        Me.radStatisticsByMonth.Location = New System.Drawing.Point(400, 56)
        Me.radStatisticsByMonth.Name = "radStatisticsByMonth"
        Me.radStatisticsByMonth.Size = New System.Drawing.Size(120, 24)
        Me.radStatisticsByMonth.TabIndex = 16
        Me.radStatisticsByMonth.Text = "按月份统计(&2)"
        '
        'radStatisticsByTime
        '
        Me.radStatisticsByTime.Location = New System.Drawing.Point(544, 56)
        Me.radStatisticsByTime.Name = "radStatisticsByTime"
        Me.radStatisticsByTime.Size = New System.Drawing.Size(120, 24)
        Me.radStatisticsByTime.TabIndex = 17
        Me.radStatisticsByTime.Text = "按期间统计(&3)"
        '
        'tsRecommendProject
        '
        Me.tsRecommendProject.DataGrid = Me.grdTable
        Me.tsRecommendProject.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csYearMonth, Me.csRecommendPerson, Me.csApplySum, Me.csApplyCount, Me.csSignSum, Me.csSignCount, Me.csLoanSum, Me.csLoanCount})
        Me.tsRecommendProject.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsRecommendProject.MappingName = "TQueryStatisticsRecommendProject"
        Me.tsRecommendProject.ReadOnly = True
        '
        'csYearMonth
        '
        Me.csYearMonth.Format = ""
        Me.csYearMonth.FormatInfo = Nothing
        Me.csYearMonth.HeaderText = "年月"
        Me.csYearMonth.MappingName = "YearMonth"
        Me.csYearMonth.NullText = ""
        Me.csYearMonth.Width = 60
        '
        'csRecommendPerson
        '
        Me.csRecommendPerson.Format = ""
        Me.csRecommendPerson.FormatInfo = Nothing
        Me.csRecommendPerson.HeaderText = "推荐类型"
        Me.csRecommendPerson.MappingName = "RecommendPerson"
        Me.csRecommendPerson.NullText = ""
        Me.csRecommendPerson.Width = 80
        '
        'csApplySum
        '
        Me.csApplySum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csApplySum.Format = "n"
        Me.csApplySum.FormatInfo = Nothing
        Me.csApplySum.HeaderText = "推荐申请金额"
        Me.csApplySum.MappingName = "ApplySum"
        Me.csApplySum.NullText = ""
        Me.csApplySum.Width = 75
        '
        'csApplyCount
        '
        Me.csApplyCount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csApplyCount.Format = ""
        Me.csApplyCount.FormatInfo = Nothing
        Me.csApplyCount.HeaderText = "推荐项目数"
        Me.csApplyCount.MappingName = "ApplyCount"
        Me.csApplyCount.NullText = ""
        Me.csApplyCount.Width = 75
        '
        'csSignSum
        '
        Me.csSignSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csSignSum.Format = "n"
        Me.csSignSum.FormatInfo = Nothing
        Me.csSignSum.HeaderText = "签约金额"
        Me.csSignSum.MappingName = "SignSum"
        Me.csSignSum.NullText = ""
        Me.csSignSum.Width = 75
        '
        'csSignCount
        '
        Me.csSignCount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csSignCount.Format = ""
        Me.csSignCount.FormatInfo = Nothing
        Me.csSignCount.HeaderText = "签约项目数"
        Me.csSignCount.MappingName = "SignCount"
        Me.csSignCount.NullText = ""
        Me.csSignCount.Width = 75
        '
        'csLoanSum
        '
        Me.csLoanSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csLoanSum.Format = "n"
        Me.csLoanSum.FormatInfo = Nothing
        Me.csLoanSum.HeaderText = "承保金额"
        Me.csLoanSum.MappingName = "LoanSum"
        Me.csLoanSum.NullText = ""
        Me.csLoanSum.Width = 75
        '
        'csLoanCount
        '
        Me.csLoanCount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csLoanCount.Format = ""
        Me.csLoanCount.FormatInfo = Nothing
        Me.csLoanCount.HeaderText = "承保项目数"
        Me.csLoanCount.MappingName = "LoanCount"
        Me.csLoanCount.NullText = ""
        Me.csLoanCount.Width = 75
        '
        'FStatisticsRecommendProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FStatisticsRecommendProject"
        Me.Text = "项目来源情况统计"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected Overrides Sub Clear()
        If Not Me.IsHandleCreated Then
            Return
        End If

        cboRecommendType.Text = String.Empty
        cboYearEnd.Text = System.DateTime.Today.Year.ToString()
        cboYearStart.Text = System.DateTime.Today.Year.ToString()
        cboMonthStart.SelectedIndex = 0
        If cboMonthEnd.Items.Count > 0 Then
            cboMonthEnd.SelectedIndex = System.DateTime.Today.Month - 1
        End If
    End Sub

    Protected Overloads Sub GetCondition(ByRef dateStart As DateTime, ByRef dateEnd As DateTime, ByRef strRecommendType As String)
        Dim yearStart, monthStart, yearEnd, monthEnd As Int32

        Try
            yearStart = Int32.Parse(cboYearStart.Text)
        Catch
            cboYearStart.Text = System.DateTime.Today.Year.ToString()
            yearStart = System.DateTime.Today.Year
        End Try

        Try
            If cboMonthStart.Enabled Then
                monthStart = Int32.Parse(cboMonthStart.Text)
            Else
                monthStart = 1
            End If
        Catch
            cboMonthStart.Text = "01"
            monthStart = 1
        End Try

        dateStart = New System.DateTime(yearStart, monthStart, 1)

        Try
            yearEnd = Int32.Parse(cboYearEnd.Text)
        Catch
            cboYearEnd.Text = System.DateTime.Today.Year.ToString()
            yearEnd = System.DateTime.Today.Year
        End Try

        Try
            If cboMonthEnd.Enabled Then
                monthEnd = Int32.Parse(cboMonthEnd.Text)
            Else
                monthEnd = 12
            End If
        Catch
            cboMonthEnd.Text = System.DateTime.Today.Month.ToString()
            monthEnd = System.DateTime.Today.Month
        End Try

        dateEnd = New System.DateTime(yearEnd, monthEnd, DateTime.DaysInMonth(yearEnd, monthEnd))

        strRecommendType = cboRecommendType.Text.Trim()
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim dateStart, dateEnd As System.DateTime
        Dim strRecommendType As String

        GetCondition(dateStart, dateEnd, strRecommendType)

        Dim dsResult As DataSet

        If radStatisticsByYear.Checked Then
            dsResult = gWs.PQueryStatisticsRecommendProjectByYear(dateStart, dateEnd, strRecommendType, UserName)
        End If

        If radStatisticsByMonth.Checked Then
            dsResult = gWs.PQueryStatisticsRecommendProjectByMonth(dateStart, dateEnd, strRecommendType, UserName)
        End If

        If radStatisticsByTime.Checked Then
            dsResult = gWs.PQueryStatisticsRecommendProject(dateStart, dateEnd, strRecommendType, UserName)
        End If

        If dsResult Is Nothing Then
            grdTable.DataSource = Nothing
            Return
        End If

        dsResult.Tables("Table").TableName = "TQueryStatisticsRecommendProject"

        Dim applySum, signSum, loanSum As Double
        Dim applyCount, signCount, loanCount As Double
        Dim row As DataRow
        For Each row In dsResult.Tables("TQueryStatisticsRecommendProject").Rows
            If Not row.IsNull("ApplySum") Then
                applySum += row("ApplySum")
            End If
            If Not row.IsNull("SignSum") Then
                signSum += row("SignSum")
            End If
            If Not row.IsNull("LoanSum") Then
                loanSum += row("LoanSum")
            End If

            If Not row.IsNull("ApplyCount") Then
                applyCount += row("ApplyCount")
            End If
            If Not row.IsNull("SignCount") Then
                signCount += row("SignCount")
            End If
            If Not row.IsNull("LoanCount") Then
                loanCount += row("LoanCount")
            End If
        Next

        Dim newRow As DataRow = dsResult.Tables("TQueryStatisticsRecommendProject").NewRow()
        newRow("RecommendPerson") = "合计："
        newRow("ApplySum") = applySum
        newRow("SignSum") = signSum
        newRow("LoanSum") = loanSum
        newRow("ApplyCount") = applyCount
        newRow("SignCount") = signCount
        newRow("LoanCount") = loanCount
        dsResult.Tables("TQueryStatisticsRecommendProject").Rows.Add(newRow)

        If dsResult.Tables("TQueryStatisticsRecommendProject").Columns.Contains("YearPart") And dsResult.Tables("TQueryStatisticsRecommendProject").Columns.Contains("MonthPart") Then
            dsResult.Tables("TQueryStatisticsRecommendProject").Columns.Add("YearMonth", GetType(String), "yearPart + IIF(LEN(ISNULL(monthPart, '')) = 1, '0', '') + ISNULL(monthPart, '')")
        ElseIf dsResult.Tables("TQueryStatisticsRecommendProject").Columns.Contains("YearPart") Then
            dsResult.Tables("TQueryStatisticsRecommendProject").Columns.Add("YearMonth", GetType(String), "yearPart")
        End If

        If Trim(cboRecommendType.Text) = "" Then
            grdTable.TableStyles(0).GridColumnStyles(1).HeaderText = "推荐类型"
        Else
            grdTable.TableStyles(0).GridColumnStyles(1).HeaderText = Trim(cboRecommendType.Text)
        End If

        MyBase.DataSource = dsResult
        grdTable.DataSource = dsResult
        grdTable.SetDataBinding(dsResult, "TQueryStatisticsRecommendProject")
        Me.Text = "项目来源情况统计表" '(" + dsResult.Tables("TQueryStatisticsRecommendProject").Rows.Count.ToString + ")"
    End Sub

    Private Sub ComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboYearStart.KeyPress, cboMonthEnd.KeyPress, cboYearEnd.KeyPress
        e.Handled = True

        If (Not Char.IsDigit(e.KeyChar)) And Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

    Private Sub FStatisticsRecommendProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Int32 = 0

        For i = 1990 To 2050
            cboYearEnd.Items.Add(i.ToString())
            cboYearStart.Items.Add(i.ToString())
        Next
        For i = 1 To 12
            cboMonthEnd.Items.Add(i.ToString("00"))
            cboMonthStart.Items.Add(i.ToString("00"))
        Next

        cboYearEnd.SelectedIndex = System.DateTime.Today.Year - 1990
        cboYearStart.SelectedIndex = System.DateTime.Today.Year - 1990
        cboMonthEnd.SelectedIndex = System.DateTime.Today.Month - 1
        cboMonthStart.SelectedIndex = 0

        cboRecommendType.DataSource = gWs.GetRecommendType("%").Tables(0)
        cboRecommendType.DisplayMember = "recommend_type"
        cboRecommendType.ValueMember = "type_code"

        '设置默认的统计类型（按年统计）
        radStatisticsByYear.Checked = True

        MyBase.chkVisible.Visible = False
        MyBase.btnClear.Visible = False

        MyBase.ReportTitle = "项目来源情况统计表"
        MyBase.ReportFile = Application.StartupPath + "\Reports\QueryStatisticsRecommendProject.rpt"
    End Sub

    Private Sub radStatisticsByYear_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radStatisticsByYear.CheckedChanged
        cboMonthEnd.Enabled = False
        cboMonthStart.Enabled = False
    End Sub

    Private Sub radStatisticsByMonth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radStatisticsByMonth.CheckedChanged
        cboMonthEnd.Enabled = True
        cboMonthStart.Enabled = True
    End Sub

    Private Sub radStatisticsByTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radStatisticsByTime.CheckedChanged
        cboMonthEnd.Enabled = True
        cboMonthStart.Enabled = True
    End Sub

End Class
