Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FQueryStatisticsMarketingA
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
    Friend WithEvents cboBranch As System.Windows.Forms.ComboBox
    Friend WithEvents lblBranch As System.Windows.Forms.Label
    Friend WithEvents csYearMonth As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csSum06 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csCount06 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csSum07 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csCount07 As System.Windows.Forms.DataGridTextBoxColumn
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
        Me.csSum06 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCount06 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSum07 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCount07 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSum03 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCount03 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSum04 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCount04 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSum05 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCount05 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cboBranch = New System.Windows.Forms.ComboBox()
        Me.lblBranch = New System.Windows.Forms.Label()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 72)
        Me.chkVisible.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(520, 72)
        Me.btnExport.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(616, 72)
        Me.btnExit.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(424, 72)
        Me.btnRefresh.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboBranch, Me.lblBranch, Me.cboMonthEnd, Me.cboYearEnd, Me.lblDateEnd, Me.cboYearStart, Me.lblDateStart})
        Me.grpCondition.Size = New System.Drawing.Size(696, 56)
        Me.grpCondition.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 104)
        Me.grdTable.Size = New System.Drawing.Size(696, 384)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsTable})
        Me.grdTable.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(512, 72)
        Me.btnPrint.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(200, 72)
        Me.btnClear.Visible = True
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
        Me.cboYearStart.Location = New System.Drawing.Point(80, 24)
        Me.cboYearStart.MaxLength = 4
        Me.cboYearStart.Name = "cboYearStart"
        Me.cboYearStart.Size = New System.Drawing.Size(56, 22)
        Me.cboYearStart.TabIndex = 1
        '
        'cboYearEnd
        '
        Me.cboYearEnd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboYearEnd.Location = New System.Drawing.Point(248, 24)
        Me.cboYearEnd.MaxLength = 4
        Me.cboYearEnd.Name = "cboYearEnd"
        Me.cboYearEnd.Size = New System.Drawing.Size(56, 22)
        Me.cboYearEnd.TabIndex = 3
        '
        'lblDateEnd
        '
        Me.lblDateEnd.Location = New System.Drawing.Point(184, 32)
        Me.lblDateEnd.Name = "lblDateEnd"
        Me.lblDateEnd.Size = New System.Drawing.Size(64, 16)
        Me.lblDateEnd.TabIndex = 2
        Me.lblDateEnd.Text = "截止年月"
        '
        'cboMonthEnd
        '
        Me.cboMonthEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonthEnd.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMonthEnd.Location = New System.Drawing.Point(312, 24)
        Me.cboMonthEnd.MaxLength = 2
        Me.cboMonthEnd.Name = "cboMonthEnd"
        Me.cboMonthEnd.Size = New System.Drawing.Size(40, 22)
        Me.cboMonthEnd.TabIndex = 4
        '
        'tsTable
        '
        Me.tsTable.DataGrid = Me.grdTable
        Me.tsTable.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csYearMonth, Me.csYear, Me.csMonth, Me.csSum01, Me.csCount01, Me.csSum02, Me.csCount02, Me.csSum06, Me.csCount06, Me.csSum07, Me.csCount07, Me.csSum03, Me.csCount03, Me.csSum04, Me.csCount04, Me.csSum05, Me.csCount05})
        Me.tsTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsTable.MappingName = "TQueryStatisticsMarketingA"
        '
        'csYearMonth
        '
        Me.csYearMonth.Format = ""
        Me.csYearMonth.FormatInfo = Nothing
        Me.csYearMonth.HeaderText = "年月"
        Me.csYearMonth.MappingName = "YearMonth"
        Me.csYearMonth.Width = 80
        '
        'csYear
        '
        Me.csYear.Format = ""
        Me.csYear.FormatInfo = Nothing
        Me.csYear.HeaderText = "年"
        Me.csYear.MappingName = "yearPart"
        Me.csYear.Width = 0
        '
        'csMonth
        '
        Me.csMonth.Format = ""
        Me.csMonth.FormatInfo = Nothing
        Me.csMonth.HeaderText = "月"
        Me.csMonth.MappingName = "monthPart"
        Me.csMonth.Width = 0
        '
        'csSum01
        '
        Me.csSum01.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csSum01.Format = "N"
        Me.csSum01.FormatInfo = Nothing
        Me.csSum01.HeaderText = "咨询金额"
        Me.csSum01.MappingName = "Sum01"
        Me.csSum01.Width = 90
        '
        'csCount01
        '
        Me.csCount01.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCount01.Format = ""
        Me.csCount01.FormatInfo = Nothing
        Me.csCount01.HeaderText = "咨询单数"
        Me.csCount01.MappingName = "Count01"
        Me.csCount01.Width = 90
        '
        'csSum02
        '
        Me.csSum02.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csSum02.Format = "N"
        Me.csSum02.FormatInfo = Nothing
        Me.csSum02.HeaderText = "受理金额"
        Me.csSum02.MappingName = "Sum02"
        Me.csSum02.Width = 90
        '
        'csCount02
        '
        Me.csCount02.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCount02.Format = ""
        Me.csCount02.FormatInfo = Nothing
        Me.csCount02.HeaderText = "受理单数"
        Me.csCount02.MappingName = "Count02"
        Me.csCount02.Width = 90
        '
        'csSum06
        '
        Me.csSum06.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csSum06.Format = "N"
        Me.csSum06.FormatInfo = Nothing
        Me.csSum06.HeaderText = "初审金额"
        Me.csSum06.MappingName = "Sum06"
        Me.csSum06.Width = 90
        '
        'csCount06
        '
        Me.csCount06.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCount06.Format = ""
        Me.csCount06.FormatInfo = Nothing
        Me.csCount06.HeaderText = "初审单数"
        Me.csCount06.MappingName = "Count06"
        Me.csCount06.Width = 90
        '
        'csSum07
        '
        Me.csSum07.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csSum07.Format = "N"
        Me.csSum07.FormatInfo = Nothing
        Me.csSum07.HeaderText = "正式受理金额"
        Me.csSum07.MappingName = "Sum07"
        Me.csSum07.Width = 90
        '
        'csCount07
        '
        Me.csCount07.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCount07.Format = ""
        Me.csCount07.FormatInfo = Nothing
        Me.csCount07.HeaderText = "正式受理单数"
        Me.csCount07.MappingName = "Count07"
        Me.csCount07.Width = 90
        '
        'csSum03
        '
        Me.csSum03.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csSum03.Format = "N"
        Me.csSum03.FormatInfo = Nothing
        Me.csSum03.HeaderText = "发出担保意向书金额"
        Me.csSum03.MappingName = "Sum03"
        Me.csSum03.Width = 120
        '
        'csCount03
        '
        Me.csCount03.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCount03.Format = ""
        Me.csCount03.FormatInfo = Nothing
        Me.csCount03.HeaderText = "发出担保意向书单数"
        Me.csCount03.MappingName = "Count03"
        Me.csCount03.Width = 120
        '
        'csSum04
        '
        Me.csSum04.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csSum04.Format = "N"
        Me.csSum04.FormatInfo = Nothing
        Me.csSum04.HeaderText = "签约金额"
        Me.csSum04.MappingName = "Sum04"
        Me.csSum04.Width = 90
        '
        'csCount04
        '
        Me.csCount04.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCount04.Format = ""
        Me.csCount04.FormatInfo = Nothing
        Me.csCount04.HeaderText = "签约单数"
        Me.csCount04.MappingName = "Count04"
        Me.csCount04.Width = 90
        '
        'csSum05
        '
        Me.csSum05.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csSum05.Format = "N"
        Me.csSum05.FormatInfo = Nothing
        Me.csSum05.HeaderText = "放款金额"
        Me.csSum05.MappingName = "Sum05"
        Me.csSum05.Width = 90
        '
        'csCount05
        '
        Me.csCount05.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCount05.Format = ""
        Me.csCount05.FormatInfo = Nothing
        Me.csCount05.HeaderText = "放款单数"
        Me.csCount05.MappingName = "Count05"
        Me.csCount05.Width = 90
        '
        'cboBranch
        '
        Me.cboBranch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboBranch.Location = New System.Drawing.Point(464, 24)
        Me.cboBranch.MaxLength = 4
        Me.cboBranch.Name = "cboBranch"
        Me.cboBranch.Size = New System.Drawing.Size(200, 22)
        Me.cboBranch.TabIndex = 6
        '
        'lblBranch
        '
        Me.lblBranch.Location = New System.Drawing.Point(400, 32)
        Me.lblBranch.Name = "lblBranch"
        Me.lblBranch.Size = New System.Drawing.Size(64, 16)
        Me.lblBranch.TabIndex = 5
        Me.lblBranch.Text = "部　　门"
        '
        'FQueryStatisticsMarketingA
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryStatisticsMarketingA"
        Me.Text = "担保业务完成情况统计"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected Overloads Sub GetCondition(ByRef dateStart As DateTime, ByRef dateEnd As DateTime, ByRef Branch As String)
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

        '如果只有一个部门则不显示部门分支选择框
        If CType(cboBranch.DataSource, DataTable).Rows.Count <= 1 Then
            Branch = ""
        Else
            Branch = cboBranch.Text
        End If
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim dateStart, dateEnd As System.DateTime
        Dim branch As String

        GetCondition(dateStart, dateEnd, branch)

        Dim dsResult As DataSet = gWs.PQueryStatisticsMarketingA(dateStart, dateEnd, branch)

        dsResult.Tables("Table").TableName = "TQueryStatisticsMarketingA"

        Dim sum01, sum02, sum03, sum04, sum05, sum06, sum07 As Double
        Dim count01, count02, count03, count04, count05, count06, count07 As Double
        Dim row As DataRow
        For Each row In dsResult.Tables("TQueryStatisticsMarketingA").Rows
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
            If Not row.IsNull("Sum06") Then
                sum06 += row("Sum06")
            End If
            If Not row.IsNull("Sum07") Then
                sum07 += row("Sum07")
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
            If Not row.IsNull("Count06") Then
                count06 += row("Count06")
            End If
            If Not row.IsNull("Count07") Then
                count07 += row("Count07")
            End If
        Next

        Dim newRow As DataRow = dsResult.Tables("TQueryStatisticsMarketingA").NewRow()
        newRow("yearPart") = "合计："
        newRow("Sum01") = sum01
        newRow("Sum02") = sum02
        newRow("Sum03") = sum03
        newRow("Sum04") = sum04
        newRow("Sum05") = sum05
        newRow("Sum06") = sum06
        newRow("Sum07") = sum07
        newRow("Count01") = count01
        newRow("Count02") = count02
        newRow("Count03") = count03
        newRow("Count04") = count04
        newRow("Count05") = count05
        newRow("Count06") = count06
        newRow("Count07") = count07
        dsResult.Tables("TQueryStatisticsMarketingA").Rows.Add(newRow)

        dsResult.Tables("TQueryStatisticsMarketingA").Columns.Add("YearMonth", GetType(String), "yearPart + IIF(LEN(ISNULL(monthPart, '')) = 1, '0', '') + ISNULL(monthPart, '')")

        MyBase.DataSource = dsResult
        grdTable.DataSource = dsResult
        grdTable.SetDataBinding(dsResult, "TQueryStatisticsMarketingA")
        Me.Text = "担保业务完成情况统计(" + dsResult.Tables("TQueryStatisticsMarketingA").Rows.Count.ToString + ")"
    End Sub

    Private Sub FQueryStatisticsMarketingA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        cboBranch.DataSource = gWs.GetBranch("{is_island=1}").Tables(0)
        cboBranch.DisplayMember = "branch_name"
        cboBranch.ValueMember = "branch_name"

        '如果只有一个部门则不显示部门分支选择框
        If CType(cboBranch.DataSource, DataTable).Rows.Count <= 1 Then
            lblBranch.Visible = False
            cboBranch.Visible = False
        End If

        MyBase.ReportTitle = "担保业务完成情况统计"
        MyBase.ReportFile = Application.StartupPath + "\Reports\QueryStatisticsMarketingA.rpt"
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
End Class
