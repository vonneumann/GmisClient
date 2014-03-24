

Public Class FQueryStatisticsCompensation
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStartYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboEndYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboEndMonth As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStartYear = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboEndYear = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboEndMonth = New System.Windows.Forms.ComboBox()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 64)
        Me.chkVisible.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 96)
        Me.grdTable.Size = New System.Drawing.Size(696, 392)
        Me.grdTable.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(408, 64)
        Me.btnExport.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(304, 64)
        Me.btnRefresh.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(616, 64)
        Me.btnExit.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 64)
        Me.btnClear.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboEndMonth, Me.Label3, Me.cboEndYear, Me.Label2, Me.cboStartYear, Me.Label1})
        Me.grpCondition.Size = New System.Drawing.Size(696, 48)
        Me.grpCondition.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(512, 64)
        Me.btnPrint.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "起始年份"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboStartYear
        '
        Me.cboStartYear.Location = New System.Drawing.Point(72, 16)
        Me.cboStartYear.MaxLength = 4
        Me.cboStartYear.Name = "cboStartYear"
        Me.cboStartYear.Size = New System.Drawing.Size(88, 20)
        Me.cboStartYear.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(176, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "截止年"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboEndYear
        '
        Me.cboEndYear.Location = New System.Drawing.Point(224, 16)
        Me.cboEndYear.MaxLength = 4
        Me.cboEndYear.Name = "cboEndYear"
        Me.cboEndYear.Size = New System.Drawing.Size(88, 20)
        Me.cboEndYear.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(320, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "月"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboEndMonth
        '
        Me.cboEndMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEndMonth.Location = New System.Drawing.Point(344, 16)
        Me.cboEndMonth.Name = "cboEndMonth"
        Me.cboEndMonth.Size = New System.Drawing.Size(56, 20)
        Me.cboEndMonth.TabIndex = 5
        '
        'FQueryStatisticsCompensation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryStatisticsCompensation"
        Me.Text = "代偿情况统计表"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FQueryStatisticsCompensation_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ReportFile = Application.StartupPath & "\Reports\QueryStatisticsCompensation.rpt"
        ReportTitle = "代偿情况统计表"

        Dim SystemDate As Date = gWs.GetSysTime
        Dim i As Integer
        For i = 1990 To 2050
            cboStartYear.Items.Add(i)
            cboEndYear.Items.Add(i)
        Next
        For i = 1 To 12
            cboEndMonth.Items.Add(i)
        Next
        cboStartYear.Text = SystemDate.Year : cboEndYear.Text = SystemDate.Year
        cboEndMonth.Text = SystemDate.Month
        AddTableStyle()
    End Sub
    Protected Overloads Sub GetCondition(ByRef StartYear As String, ByRef EndYearMonth As String)
        StartYear = cboStartYear.Text
        EndYearMonth = cboEndYear.Text & cboEndMonth.Text
    End Sub
    Protected Overloads Overrides Sub Refresh(ByVal Condition As String)
        If cboStartYear.Text.Trim = "" Then
            SWDialogBox.MessageBox.Show("$1001", "起始年份")
            'MessageBox.Show("起始年份不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboStartYear.Focus()
            Return
        ElseIf cboEndYear.Text.Trim = "" Then
            SWDialogBox.MessageBox.Show("$1001", "截止年份")
            'MessageBox.Show("截止年份不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboEndYear.Focus()
            Return
        Else
            Try
                If CInt(cboStartYear.Text) > CInt(cboEndYear.Text) Then
                    SWDialogBox.MessageBox.Show("$1008", "起始年份", "截至年份")
                    'MessageBox.Show("起始年份应小或等于截止年份", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            Catch
                Return
            End Try
        End If
        Dim StartYear, EndYearMonth As String
        GetCondition(StartYear, EndYearMonth)
        Dim ds As DataSet = gWs.FQueryStatisticsCompensation(StartYear, EndYearMonth)
        ds.Tables(0).TableName = "TQueryStatisticsCompensation"
        grdTable.DataMember = ds.Tables(0).TableName
        grdTable.DataSource = ds
        MyBase.DataSource = ds
    End Sub

    Protected Overrides Sub Export()
        Dim array As New ArrayList()

        array.Add("0")
        array.Add("年月")
        array.Add("代偿金额(元)")
        array.Add("追回金额(元)")
        array.Add("代偿余额(元)")

        Dim arrayList As New ArrayList()
        arrayList.Add(array)


        ReportToExcel.ToExcel(grdTable, ReportTitle, ReportTitle, arrayList)
    End Sub

    Private Sub AddTableStyle()
        grdTable.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "TQueryStatisticsCompensation"
        dgts.AllowSorting = False
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "YearMonth"
        col1.HeaderText = "年月"
        col1.Width = 50
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.MappingName = "RefundCount"
        col2.HeaderText = "代偿单数"
        col2.Width = 60
        col2.NullText = ""
        col2.Alignment = HorizontalAlignment.Center
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.MappingName = "RefundSum"
        col3.HeaderText = "代偿金额(元)"
        col3.Width = 100
        col3.NullText = ""
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.MappingName = "Returned"
        col4.HeaderText = "追回金额(元)"
        col4.Width = 100
        col4.NullText = ""
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "Balance"
        col5.HeaderText = "代偿余额(元)"
        col5.Width = 100
        col5.NullText = ""
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col4, col5})
        grdTable.TableStyles.Add(dgts)
    End Sub
End Class
