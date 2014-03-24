Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FQueryStatisticsMarketingB
    Inherits FQueryBase
    '担保金额分段统计
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
	Friend WithEvents lblDateStart As System.Windows.Forms.Label
	Friend WithEvents cboYearStart As System.Windows.Forms.ComboBox
	Friend WithEvents cboYearEnd As System.Windows.Forms.ComboBox
	Friend WithEvents lblDateEnd As System.Windows.Forms.Label
	Friend WithEvents cboMonthEnd As System.Windows.Forms.ComboBox
	Friend WithEvents tsTable As System.Windows.Forms.DataGridTableStyle
	Friend WithEvents csYear As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csMonth As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csSum01 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csCount01 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csSum02 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csCount02 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csSum03 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csCount03 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csSum04 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csCount04 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csSum05 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csCount05 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csYearMonth As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboChartStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkChart As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPhase As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblDateStart = New System.Windows.Forms.Label()
        Me.cboYearStart = New System.Windows.Forms.ComboBox()
        Me.cboYearEnd = New System.Windows.Forms.ComboBox()
        Me.lblDateEnd = New System.Windows.Forms.Label()
        Me.cboMonthEnd = New System.Windows.Forms.ComboBox()
        Me.tsTable = New System.Windows.Forms.DataGridTableStyle()
        Me.csYearMonth = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csYear = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csMonth = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSum01 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCount01 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSum02 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCount02 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSum03 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCount03 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSum04 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCount04 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSum05 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCount05 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboChartStyle = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkChart = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPhase = New System.Windows.Forms.ComboBox()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(512, 80)
        Me.btnPrint.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(616, 128)
        Me.btnExit.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(520, 128)
        Me.btnExport.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(424, 128)
        Me.btnRefresh.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 128)
        Me.btnClear.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 128)
        Me.chkVisible.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 168)
        Me.grdTable.Size = New System.Drawing.Size(696, 320)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsTable})
        Me.grdTable.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboPhase, Me.Label1, Me.cboMonthEnd, Me.cboYearEnd, Me.lblDateEnd, Me.cboYearStart, Me.lblDateStart})
        Me.grpCondition.Size = New System.Drawing.Size(408, 96)
        Me.grpCondition.Visible = True
        '
        'lblDateStart
        '
        Me.lblDateStart.Location = New System.Drawing.Point(16, 32)
        Me.lblDateStart.Name = "lblDateStart"
        Me.lblDateStart.Size = New System.Drawing.Size(64, 16)
        Me.lblDateStart.TabIndex = 0
        Me.lblDateStart.Text = "起始年份"
        '
        'cboYearStart
        '
        Me.cboYearStart.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearStart.Location = New System.Drawing.Point(72, 24)
        Me.cboYearStart.MaxLength = 4
        Me.cboYearStart.Name = "cboYearStart"
        Me.cboYearStart.Size = New System.Drawing.Size(72, 22)
        Me.cboYearStart.TabIndex = 1
        '
        'cboYearEnd
        '
        Me.cboYearEnd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearEnd.Location = New System.Drawing.Point(216, 24)
        Me.cboYearEnd.MaxLength = 4
        Me.cboYearEnd.Name = "cboYearEnd"
        Me.cboYearEnd.Size = New System.Drawing.Size(64, 22)
        Me.cboYearEnd.TabIndex = 3
        '
        'lblDateEnd
        '
        Me.lblDateEnd.Location = New System.Drawing.Point(160, 32)
        Me.lblDateEnd.Name = "lblDateEnd"
        Me.lblDateEnd.Size = New System.Drawing.Size(64, 16)
        Me.lblDateEnd.TabIndex = 2
        Me.lblDateEnd.Text = "截止年月"
        '
        'cboMonthEnd
        '
        Me.cboMonthEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonthEnd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonthEnd.Location = New System.Drawing.Point(280, 24)
        Me.cboMonthEnd.MaxLength = 2
        Me.cboMonthEnd.Name = "cboMonthEnd"
        Me.cboMonthEnd.Size = New System.Drawing.Size(40, 22)
        Me.cboMonthEnd.TabIndex = 4
        '
        'tsTable
        '
        Me.tsTable.DataGrid = Me.grdTable
        Me.tsTable.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csYearMonth, Me.csYear, Me.csMonth, Me.csSum01, Me.csCount01, Me.csSum02, Me.csCount02, Me.csSum03, Me.csCount03, Me.csSum04, Me.csCount04, Me.csSum05, Me.csCount05})
        Me.tsTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsTable.MappingName = "TQueryStatisticsMarketingB"
        '
        'csYearMonth
        '
        Me.csYearMonth.Format = ""
        Me.csYearMonth.FormatInfo = Nothing
        Me.csYearMonth.HeaderText = "年月"
        Me.csYearMonth.MappingName = "YearMonth"
        Me.csYearMonth.NullText = ""
        Me.csYearMonth.Width = 80
        '
        'csYear
        '
        Me.csYear.Format = ""
        Me.csYear.FormatInfo = Nothing
        Me.csYear.HeaderText = "年"
        Me.csYear.MappingName = "yearPart"
        Me.csYear.NullText = ""
        Me.csYear.Width = 0
        '
        'csMonth
        '
        Me.csMonth.Format = ""
        Me.csMonth.FormatInfo = Nothing
        Me.csMonth.HeaderText = "月"
        Me.csMonth.MappingName = "monthPart"
        Me.csMonth.NullText = ""
        Me.csMonth.Width = 0
        '
        'csSum01
        '
        Me.csSum01.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csSum01.Format = "N"
        Me.csSum01.FormatInfo = Nothing
        Me.csSum01.HeaderText = "金额[<10万]"
        Me.csSum01.MappingName = "Sum01"
        Me.csSum01.NullText = ""
        Me.csSum01.Width = 75
        '
        'csCount01
        '
        Me.csCount01.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCount01.Format = ""
        Me.csCount01.FormatInfo = Nothing
        Me.csCount01.HeaderText = "单数[<10万]"
        Me.csCount01.MappingName = "Count01"
        Me.csCount01.NullText = ""
        Me.csCount01.Width = 75
        '
        'csSum02
        '
        Me.csSum02.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csSum02.Format = "N"
        Me.csSum02.FormatInfo = Nothing
        Me.csSum02.HeaderText = "金额[>=10-<100万]"
        Me.csSum02.MappingName = "Sum02"
        Me.csSum02.NullText = ""
        Me.csSum02.Width = 100
        '
        'csCount02
        '
        Me.csCount02.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCount02.Format = ""
        Me.csCount02.FormatInfo = Nothing
        Me.csCount02.HeaderText = "单数[>=10-<100万]"
        Me.csCount02.MappingName = "Count02"
        Me.csCount02.NullText = ""
        Me.csCount02.Width = 100
        '
        'csSum03
        '
        Me.csSum03.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csSum03.Format = "N"
        Me.csSum03.FormatInfo = Nothing
        Me.csSum03.HeaderText = "金额[>=100-<500万]"
        Me.csSum03.MappingName = "Sum03"
        Me.csSum03.NullText = ""
        Me.csSum03.Width = 100
        '
        'csCount03
        '
        Me.csCount03.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCount03.Format = ""
        Me.csCount03.FormatInfo = Nothing
        Me.csCount03.HeaderText = "单数[>=100-<500万]"
        Me.csCount03.MappingName = "Count03"
        Me.csCount03.NullText = ""
        Me.csCount03.Width = 100
        '
        'csSum04
        '
        Me.csSum04.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csSum04.Format = "N"
        Me.csSum04.FormatInfo = Nothing
        Me.csSum04.HeaderText = "金额[>=500-<1000万]"
        Me.csSum04.MappingName = "Sum04"
        Me.csSum04.NullText = ""
        Me.csSum04.Width = 100
        '
        'csCount04
        '
        Me.csCount04.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCount04.Format = ""
        Me.csCount04.FormatInfo = Nothing
        Me.csCount04.HeaderText = "单数[>=500-<1000万]"
        Me.csCount04.MappingName = "Count04"
        Me.csCount04.NullText = ""
        Me.csCount04.Width = 100
        '
        'csSum05
        '
        Me.csSum05.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csSum05.Format = "N"
        Me.csSum05.FormatInfo = Nothing
        Me.csSum05.HeaderText = "金额[>=1000万]"
        Me.csSum05.MappingName = "Sum05"
        Me.csSum05.NullText = ""
        Me.csSum05.Width = 100
        '
        'csCount05
        '
        Me.csCount05.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCount05.Format = ""
        Me.csCount05.FormatInfo = Nothing
        Me.csCount05.HeaderText = "单数[>=1000万]"
        Me.csCount05.MappingName = "Count05"
        Me.csCount05.NullText = ""
        Me.csCount05.Width = 100
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboChartStyle, Me.Label4, Me.chkChart})
        Me.GroupBox1.Location = New System.Drawing.Point(424, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 96)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "图表样式"
        '
        'cboChartStyle
        '
        Me.cboChartStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChartStyle.Items.AddRange(New Object() {"饼图", "三维饼图"})
        Me.cboChartStyle.Location = New System.Drawing.Point(144, 56)
        Me.cboChartStyle.Name = "cboChartStyle"
        Me.cboChartStyle.Size = New System.Drawing.Size(121, 20)
        Me.cboChartStyle.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "请选择一种图表样式："
        '
        'chkChart
        '
        Me.chkChart.Checked = True
        Me.chkChart.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkChart.Location = New System.Drawing.Point(16, 24)
        Me.chkChart.Name = "chkChart"
        Me.chkChart.TabIndex = 8
        Me.chkChart.Text = "生成图表"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "统计内容"
        '
        'cboPhase
        '
        Me.cboPhase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPhase.Items.AddRange(New Object() {"签约", "承保"})
        Me.cboPhase.Location = New System.Drawing.Point(72, 64)
        Me.cboPhase.Name = "cboPhase"
        Me.cboPhase.Size = New System.Drawing.Size(72, 20)
        Me.cboPhase.TabIndex = 6
        '
        'FQueryStatisticsMarketingB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition, Me.GroupBox1})
        Me.Name = "FQueryStatisticsMarketingB"
        Me.Text = "担保金额分段统计"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected Overloads Sub GetCondition(ByRef dateStart As DateTime, ByRef dateEnd As DateTime, ByRef strPhase As String)
        'yearStart = MyBase.ToNumeric(cboYearStart.Text)
        'yearEnd = MyBase.ToNumeric(cboYearEnd.Text)
        'monthEnd = MyBase.ToNumeric(cboMonthEnd.Text)
        'cboYearStart.Text = yearStart.ToString()
        'cboYearEnd.Text = yearEnd.ToString()
        'cboMonthEnd.Text = monthEnd.ToString()

        Dim yearStart, yearEnd, monthEnd As Int32

        Try
            yearStart = Int32.Parse(cboYearStart.Text)
        Catch
            cboYearStart.Text = System.DateTime.Today.Year.ToString()
            yearStart = System.DateTime.Today.Year
        End Try
        dateStart = New System.DateTime(yearStart, 1, 1)

        Try
            yearEnd = Int32.Parse(cboYearEnd.Text)
        Catch
            cboYearEnd.Text = System.DateTime.Today.Year.ToString()
            yearEnd = System.DateTime.Today.Year
        End Try

        Try
            monthEnd = Int32.Parse(cboMonthEnd.Text)
        Catch
            cboMonthEnd.Text = System.DateTime.Today.Month.ToString()
            monthEnd = System.DateTime.Today.Month
        End Try

        dateEnd = New System.DateTime(yearEnd, monthEnd, 1)

        Select Case Trim(cboPhase.Text)
            Case "签约"
                strPhase = "Vise"
            Case "承保"
                strPhase = "Loan"
        End Select
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim dateStart, dateEnd As System.DateTime
        Dim strPhase As String

        GetCondition(dateStart, dateEnd, strPhase)

        Dim dsResult As DataSet = gWs.PQueryStatisticsMarketingB(dateStart, dateEnd, strPhase, UserName)

        dsResult.Tables("Table").TableName = "TQueryStatisticsMarketingB"

        Dim sum01, sum02, sum03, sum04, sum05 As Double
        Dim count01, count02, count03, count04, count05 As Double
        Dim row As DataRow
        For Each row In dsResult.Tables("TQueryStatisticsMarketingB").Rows
            If Not row.IsNull("Sum01") Then
                sum01 += row("Sum01")
            End If
            If Not row.IsNull("Sum02") Then
                sum02 += row("Sum02")
            End If
            If Not row.IsNull("Sum03") Then
                sum03 += row("Sum03")
            End If
            If Not row.IsNull("Sum04") Then
                sum04 += row("Sum04")
            End If
            If Not row.IsNull("Sum05") Then
                sum05 += row("Sum05")
            End If

            If Not row.IsNull("Count01") Then
                count01 += row("Count01")
            End If
            If Not row.IsNull("Count02") Then
                count02 += row("Count02")
            End If
            If Not row.IsNull("Count03") Then
                count03 += row("Count03")
            End If
            If Not row.IsNull("Count04") Then
                count04 += row("Count04")
            End If
            If Not row.IsNull("Count05") Then
                count05 += row("Count05")
            End If
        Next

        Dim newRow As DataRow = dsResult.Tables("TQueryStatisticsMarketingB").NewRow()
        newRow("yearPart") = "合计："
        newRow("Sum01") = sum01
        newRow("Sum02") = sum02
        newRow("Sum03") = sum03
        newRow("Sum04") = sum04
        newRow("Sum05") = sum05
        newRow("Count01") = count01
        newRow("Count02") = count02
        newRow("Count03") = count03
        newRow("Count04") = count04
        newRow("Count05") = count05
        dsResult.Tables("TQueryStatisticsMarketingB").Rows.Add(newRow)

        dsResult.Tables("TQueryStatisticsMarketingB").Columns.Add("YearMonth", GetType(String), "yearPart + IIF(LEN(ISNULL(monthPart, '')) = 1, '0', '') + ISNULL(monthPart, '')")

        MyBase.DataSource = dsResult
        grdTable.DataSource = dsResult
        grdTable.SetDataBinding(dsResult, "TQueryStatisticsMarketingB")
        Me.Text = "担保金额分段统计" '(" + dsResult.Tables("TQueryStatisticsMarketingB").Rows.Count.ToString + ")"
    End Sub

    Private Sub FQueryStatisticsMarketingB_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim i As Int32 = 0

        For i = 1990 To 2050
            cboYearEnd.Items.Add(i.ToString())
            cboYearStart.Items.Add(i.ToString())
        Next
        For i = 1 To 12
            cboMonthEnd.Items.Add(i.ToString("00"))
        Next

        cboYearEnd.SelectedIndex = System.DateTime.Today.Year - 1990
        cboYearStart.SelectedIndex = System.DateTime.Today.Year - 1990
        cboMonthEnd.SelectedIndex = System.DateTime.Today.Month - 1

        ' Added by Andy on 2/10/2004
        cboChartStyle.SelectedIndex = 0
        cboPhase.SelectedIndex = 0
        MyBase.chkVisible.Visible = False
        MyBase.btnClear.Visible = False
        ' Ended by Andy

        MyBase.ReportTitle = "担保金额分段统计"
        MyBase.ReportFile = Application.StartupPath + "\Reports\QueryStatisticsMarketingB.rpt"
    End Sub

    Protected Overrides Sub Clear()
        If Not Me.IsHandleCreated Then
            Return
        End If

        cboYearEnd.Text = System.DateTime.Today.Year.ToString()
        cboYearStart.Text = System.DateTime.Today.Year.ToString()
        If cboMonthEnd.Items.Count > 0 Then
            cboMonthEnd.SelectedIndex = System.DateTime.Today.Month - 1
        End If
    End Sub

    Private Sub ComboBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cboYearStart.KeyPress, cboMonthEnd.KeyPress, cboYearEnd.KeyPress
        e.Handled = True

        If (Not Char.IsDigit(e.KeyChar)) And Asc(e.KeyChar) <> Keys.Back Then
            e.Handled = True
        End If
    End Sub

    ' Modified by Andy on 2/10/2004
    Protected Overrides Sub Export()

        Dim strFlag As String
        Select Case Trim(cboChartStyle.Text)
            Case "柱状图"
                strFlag = "0"
            Case "折线图"
                strFlag = "1"
            Case "饼图"
                strFlag = "2"
            Case "三维柱形图"
                strFlag = "3"
            Case "三维折线图"
                strFlag = "4"
            Case "三维饼图"
                strFlag = "5"
            Case Else
                strFlag = "0"
        End Select

        If Me.chkChart.Checked Then
            Dim arrChart1 As New ArrayList()
            Dim arrChart2 As New ArrayList()
            Dim arrChart3 As New ArrayList()
            Dim arrChart4 As New ArrayList()
            Dim arrChart5 As New ArrayList()
            Dim arrChartList As New ArrayList()

            arrChart1.Add(strFlag)
            arrChart1.Add("年月")
            arrChart1.Add("单数[<10万]")

            arrChart2.Add(strFlag)
            arrChart2.Add("年月")
            arrChart2.Add("单数[>=10-<100万]")

            arrChart3.Add(strFlag)
            arrChart3.Add("年月")
            arrChart3.Add("单数[>=100-<500万]")

            arrChart4.Add(strFlag)
            arrChart4.Add("年月")
            arrChart4.Add("单数[>=500-<1000万]")

            arrChart5.Add(strFlag)
            arrChart5.Add("年月")
            arrChart5.Add("单数[>=1000万]")

            arrChartList.Add(arrChart1)
            arrChartList.Add(arrChart2)
            arrChartList.Add(arrChart3)
            arrChartList.Add(arrChart4)
            arrChartList.Add(arrChart5)

            ReportToExcel.ToExcel(grdTable, ReportTitle, ReportTitle, arrChartList)
        Else
            ReportToExcel.ToExcel(grdTable, ReportTitle, ReportTitle)
        End If
    End Sub
    ' Ended by Andy

    Private Sub chkChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChart.CheckedChanged
        ' IIf(chkChart.Checked, cboChartStyle.Enabled = True, cboChartStyle.Enabled = False)
        If chkChart.Checked Then
            cboChartStyle.Enabled = True
        Else
            cboChartStyle.Enabled = False
        End If
    End Sub

End Class
