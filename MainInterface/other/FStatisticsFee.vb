

Public Class FStatisticsFee
    Inherits MainInterface.FQueryBase
    '收费情况统计
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
    Friend WithEvents cboSubType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboMonthTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboYearTo As System.Windows.Forms.ComboBox
    Friend WithEvents cboMonthFrom As System.Windows.Forms.ComboBox
    Friend WithEvents cboYearFrom As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tCharge As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents vchAccountYM As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iSum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboChartStyle As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkChart As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboSubType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboMonthTo = New System.Windows.Forms.ComboBox()
        Me.cboYearTo = New System.Windows.Forms.ComboBox()
        Me.cboMonthFrom = New System.Windows.Forms.ComboBox()
        Me.cboYearFrom = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tCharge = New System.Windows.Forms.DataGridTableStyle()
        Me.vchAccountYM = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboChartStyle = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chkChart = New System.Windows.Forms.CheckBox()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tCharge})
        Me.grdTable.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboSubType, Me.Label3, Me.cboMonthTo, Me.cboYearTo, Me.cboMonthFrom, Me.cboYearFrom, Me.Label2, Me.Label1})
        Me.grpCondition.Size = New System.Drawing.Size(392, 96)
        Me.grpCondition.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Visible = True
        '
        'cboSubType
        '
        Me.cboSubType.DisplayMember = "item_name"
        Me.cboSubType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubType.Location = New System.Drawing.Point(144, 56)
        Me.cboSubType.Name = "cboSubType"
        Me.cboSubType.Size = New System.Drawing.Size(136, 20)
        Me.cboSubType.TabIndex = 15
        Me.cboSubType.ValueMember = "item_code"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(128, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "请选择一种统计类别："
        '
        'cboMonthTo
        '
        Me.cboMonthTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonthTo.Location = New System.Drawing.Point(344, 24)
        Me.cboMonthTo.Name = "cboMonthTo"
        Me.cboMonthTo.Size = New System.Drawing.Size(40, 20)
        Me.cboMonthTo.TabIndex = 13
        '
        'cboYearTo
        '
        Me.cboYearTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearTo.Location = New System.Drawing.Point(280, 24)
        Me.cboYearTo.Name = "cboYearTo"
        Me.cboYearTo.Size = New System.Drawing.Size(64, 20)
        Me.cboYearTo.TabIndex = 12
        '
        'cboMonthFrom
        '
        Me.cboMonthFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonthFrom.Location = New System.Drawing.Point(208, 24)
        Me.cboMonthFrom.Name = "cboMonthFrom"
        Me.cboMonthFrom.Size = New System.Drawing.Size(40, 20)
        Me.cboMonthFrom.TabIndex = 11
        '
        'cboYearFrom
        '
        Me.cboYearFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboYearFrom.Location = New System.Drawing.Point(144, 24)
        Me.cboYearFrom.Name = "cboYearFrom"
        Me.cboYearFrom.Size = New System.Drawing.Size(64, 20)
        Me.cboYearFrom.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(256, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "至"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "请选择年月统计区间："
        '
        'tCharge
        '
        Me.tCharge.DataGrid = Me.grdTable
        Me.tCharge.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.vchAccountYM, Me.iSum})
        Me.tCharge.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tCharge.MappingName = "Table"
        '
        'vchAccountYM
        '
        Me.vchAccountYM.Format = ""
        Me.vchAccountYM.FormatInfo = Nothing
        Me.vchAccountYM.HeaderText = "统计年月"
        Me.vchAccountYM.MappingName = "vchAccountYM"
        Me.vchAccountYM.NullText = ""
        Me.vchAccountYM.Width = 120
        '
        'iSum
        '
        Me.iSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.iSum.Format = "n"
        Me.iSum.FormatInfo = Nothing
        Me.iSum.HeaderText = "金额"
        Me.iSum.MappingName = "iSum"
        Me.iSum.NullText = ""
        Me.iSum.Width = 120
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboChartStyle, Me.Label4, Me.chkChart})
        Me.GroupBox1.Location = New System.Drawing.Point(408, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 96)
        Me.GroupBox1.TabIndex = 109
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "图表样式"
        '
        'cboChartStyle
        '
        Me.cboChartStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboChartStyle.Items.AddRange(New Object() {"柱状图", "三维柱形图"})
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
        'FStatisticsFee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition, Me.GroupBox1})
        Me.Name = "FStatisticsFee"
        Me.Text = "收费情况统计"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Shadows ReportTitle As String

    Private Sub FQueryStatisticsAssurance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        BindDate(Now(), -50, 50, cboYearFrom, "Year")
        BindDate(Now(), 1, 12, cboMonthFrom, "Month")
        BindDate(Now(), -50, 50, cboYearTo, "Year")
        BindDate(Now(), 1, 12, cboMonthTo, "Month")

        Dim dtSubType As DataTable = gWs.GetItem("%", "31").Tables(0)

        Dim drRow As DataRow = dtSubType.NewRow
        With drRow
            .Item("item_code") = ""
            .Item("item_name") = "全部"
        End With
        dtSubType.Rows.InsertAt(drRow, 0)

        cboSubType.DataSource = dtSubType

        ' Added by Andy on 2/11/2004
        cboChartStyle.SelectedIndex = 0
        MyBase.chkVisible.Visible = False
        MyBase.btnClear.Visible = False
        ' Ended by Andy

        MyBase.ReportFile = Application.StartupPath & "\Reports\rptChargeStat.rpt"
        MyBase.ReportTitle = Trim(cboSubType.Text) & "收费统计"

        Me.RemoveClearControl() '不清除界面控件的初始值
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim strDateFrom, strDateTo, strSubType As String
        Dim i As Integer
        Dim iTotalSum As Decimal
        Dim dtResult As DataTable

        Dim strYearFrom As String = Trim(cboYearFrom.Text)
        Dim strMonthFrom As String = Trim(cboMonthFrom.Text)
        If Len(strMonthFrom) = 1 Then
            strMonthFrom = "0" & strMonthFrom
        End If
        strDateFrom = strYearFrom & strMonthFrom

        Dim strYearTo As String = Trim(cboYearTo.Text)
        Dim strMonthTo As String = Trim(cboMonthTo.Text)
        If Len(strMonthTo) = 1 Then
            strMonthTo = "0" & strMonthTo
        End If
        strDateTo = strYearTo & strMonthTo

        strSubType = Trim(cboSubType.SelectedValue)

        If strDateFrom > strDateTo Then
            SWDialogBox.MessageBox.Show("$1008", "起始年月", "截止年月")
            Exit Sub
        End If

        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            dtResult = gWs.FStatisticsFee(strDateFrom, strDateTo, "31", strSubType, UserName).Tables(0)
            MyBase.ReportTitle = Trim(cboSubType.Text) & "收费统计"
            ReportTitle = Trim(cboSubType.Text) & "收费统计"

            For i = 0 To dtResult.Rows.Count - 1
                iTotalSum = iTotalSum + CDec(dtResult.Rows(i).Item("iSum"))
            Next
            Dim drRow As DataRow = dtResult.NewRow
            With drRow
                .Item("vchAccountYM") = "合计："
                .Item("iSum") = iTotalSum
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

    Protected Overrides Sub Print()
        'Dim i As Integer
        'Dim reportViewerForm As FReportViewer = New FReportViewer()
        'Dim _dataSource As Object = grdTable.DataSource

        'Dim ReportFile As String = Application.StartupPath & "\Reports\rptChargeStat.rpt"

        'Try
        '    reportViewerForm.ShowDialog(ReportFile, _dataSource, ReportTitle)
        'Finally
        '    If Not reportViewerForm Is Nothing Then
        '        reportViewerForm.Dispose()
        '    End If
        'End Try
    End Sub

    Function BindDate(ByVal CurrentDate As Date, ByVal iBegin As Integer, ByVal iEnd As Integer, ByVal ControlName As ComboBox, ByVal sType As String)
        Dim i As Integer

        Select Case sType
            Case "Month"
                For i = iBegin To iEnd
                    ControlName.Items.Add(i)
                    If i = CurrentDate.Month Then
                        ControlName.SelectedIndex = i - 1
                    End If
                Next
            Case "Year"
                Dim j As Integer = 0
                For i = iBegin To iEnd
                    ControlName.Items.Add(i + CurrentDate.Year)
                    If i + CurrentDate.Year = CurrentDate.Year Then
                        ControlName.SelectedIndex = j
                    End If
                    j += 1
                Next
        End Select
    End Function

    Private Sub chkChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkChart.CheckedChanged
        ' IIf(chkChart.Checked, cboChartStyle.Enabled = True, cboChartStyle.Enabled = False)
        If chkChart.Checked Then
            cboChartStyle.Enabled = True
        Else
            cboChartStyle.Enabled = False
        End If
    End Sub

    ' Modified by Andy on 2/11/2004
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
            Dim arrChartList As New ArrayList()

            arrChart1.Add(strFlag)
            arrChart1.Add("统计年月")
            arrChart1.Add("金额")

            arrChartList.Add(arrChart1)

            ReportToExcel.ToExcel(grdTable, ReportTitle, ReportTitle, arrChartList)
        Else
            ReportToExcel.ToExcel(grdTable, ReportTitle, ReportTitle)
        End If
    End Sub
    ' Ended by Andy

End Class
