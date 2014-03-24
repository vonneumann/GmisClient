Public Class frmIsFirstLoanStat
    Inherits System.Windows.Forms.Form
    '首次贷款企业情况统计
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblToDate As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents btnToExcel As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents grdTable As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents IsFirstLoan As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents iCorpCount As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmIsFirstLoanStat))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.btnToExcel = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.grdTable = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.IsFirstLoan = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.iCorpCount = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblToDate, Me.dtpToDate, Me.dtpFromDate, Me.chkDate})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 96)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询条件"
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(240, 32)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(17, 14)
        Me.lblToDate.TabIndex = 26
        Me.lblToDate.Text = "到"
        '
        'dtpToDate
        '
        Me.dtpToDate.Enabled = False
        Me.dtpToDate.Location = New System.Drawing.Point(264, 24)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpToDate.TabIndex = 27
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CalendarFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Enabled = False
        Me.dtpFromDate.Location = New System.Drawing.Point(112, 24)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpFromDate.TabIndex = 25
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(16, 24)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.TabIndex = 28
        Me.chkDate.Text = "查询时间段："
        '
        'btnToExcel
        '
        Me.btnToExcel.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnToExcel.Image = CType(resources.GetObject("btnToExcel.Image"), System.Drawing.Bitmap)
        Me.btnToExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnToExcel.ImageIndex = 1
        Me.btnToExcel.ImageList = Me.ImageList1
        Me.btnToExcel.Location = New System.Drawing.Point(568, 128)
        Me.btnToExcel.Name = "btnToExcel"
        Me.btnToExcel.Size = New System.Drawing.Size(77, 24)
        Me.btnToExcel.TabIndex = 28
        Me.btnToExcel.Text = "导 出(&E)"
        Me.btnToExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 2
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(656, 128)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 27
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.ImageIndex = 0
        Me.btnRefresh.ImageList = Me.ImageList1
        Me.btnRefresh.Location = New System.Drawing.Point(480, 128)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(77, 24)
        Me.btnRefresh.TabIndex = 26
        Me.btnRefresh.Text = "查 询(&S)"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdTable
        '
        Me.grdTable.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grdTable.CaptionVisible = False
        Me.grdTable.DataMember = ""
        Me.grdTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTable.Location = New System.Drawing.Point(8, 168)
        Me.grdTable.Name = "grdTable"
        Me.grdTable.ReadOnly = True
        Me.grdTable.Size = New System.Drawing.Size(736, 320)
        Me.grdTable.TabIndex = 29
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.IsFirstLoan, Me.iCorpCount})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'IsFirstLoan
        '
        Me.IsFirstLoan.Format = ""
        Me.IsFirstLoan.FormatInfo = Nothing
        Me.IsFirstLoan.HeaderText = "统计范围"
        Me.IsFirstLoan.MappingName = "IsFirstLoan"
        Me.IsFirstLoan.NullText = ""
        Me.IsFirstLoan.Width = 75
        '
        'iCorpCount
        '
        Me.iCorpCount.Format = ""
        Me.iCorpCount.FormatInfo = Nothing
        Me.iCorpCount.HeaderText = "家数"
        Me.iCorpCount.MappingName = "iCorpCount"
        Me.iCorpCount.NullText = ""
        Me.iCorpCount.Width = 75
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmIsFirstLoanStat
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(752, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.grdTable, Me.btnToExcel, Me.btnExit, Me.btnRefresh, Me.GroupBox1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmIsFirstLoanStat"
        Me.ShowInTaskbar = False
        Me.Text = "首次贷款企业统计"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnToExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToExcel.Click

        'Dim strFlag As String

        'Select Case Trim(cboChartStyle.Text)
        '    Case "柱状图"
        '        strFlag = "0"
        '    Case "折线图"
        '        strFlag = "1"
        '    Case "饼图"
        '        strFlag = "2"
        '    Case "三维柱形图"
        '        strFlag = "3"
        '    Case "三维折线图"
        '        strFlag = "4"
        '    Case "三维饼图"
        '        strFlag = "5"
        '    Case Else
        '        strFlag = "0"
        'End Select

        '  If Me.chkChart.Checked Then

        'Dim arrChart1 As New ArrayList()
        'Dim arrChartList As New ArrayList()

        'arrChart1.Add(strFlag)
        'arrChart1.Add("统计范围")
        'arrChart1.Add("家数")

        'arrChartList.Add(arrChart1)

        'ReportToExcel.ToExcel(grdTable, "首次贷款企业统计一览表", "首次贷款企业统计一览表", arrChartList)
            ' Else
            ReportToExcel.ToExcel(Me.grdTable, "首次贷款企业统计一览表", "首次贷款企业统计一览表")
            'End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            Dim dtResult As DataTable

            Me.Cursor = Cursors.WaitCursor

            Dim FromDate, ToDate As DateTime
            FromDate = IIf(Me.chkDate.Checked, Me.dtpFromDate.Value, New DateTime(1900, 1, 1))
            ToDate = IIf(Me.chkDate.Checked, Me.dtpToDate.Value, New DateTime(2049, 12, 31))

            If FromDate.Date > ToDate.Date Then
                SWDialogBox.MessageBox.Show("$1008", "起始日期", "截止日期")
                Return
            End If

            dtResult = gWs.Usp_ListIsFirstLoanStat(FromDate, ToDate, UserName).Tables(0)

            grdTable.DataSource = dtResult

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        Me.dtpFromDate.Enabled = Me.chkDate.Checked
        Me.dtpToDate.Enabled = Me.chkDate.Checked
    End Sub

    Private Sub frmIsFirstLoanStat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cboChartStyle.SelectedIndex = 0
    End Sub

    'Private Sub chkChart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    ' IIf(chkChart.Checked, cboChartStyle.Enabled = True, cboChartStyle.Enabled = False)
    '    If chkChart.Checked Then
    '        cboChartStyle.Enabled = True
    '    Else
    '        cboChartStyle.Enabled = False
    '    End If
    'End Sub

End Class
