

Public Class FQueryGuaranteeForm
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
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkLoanDate As System.Windows.Forms.CheckBox
    Friend WithEvents dtpLoanToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpLoanFromDate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpLoanToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpLoanFromDate = New System.Windows.Forms.DateTimePicker()
        Me.chkLoanDate = New System.Windows.Forms.CheckBox()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.SuspendLayout()
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
        Me.grdTable.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label1, Me.dtpLoanToDate, Me.dtpLoanFromDate, Me.chkLoanDate})
        Me.grpCondition.Size = New System.Drawing.Size(696, 104)
        Me.grpCondition.Visible = True
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(256, 64)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(17, 14)
        Me.lblToDate.TabIndex = 113
        Me.lblToDate.Text = "到"
        '
        'dtpToDate
        '
        Me.dtpToDate.Enabled = False
        Me.dtpToDate.Location = New System.Drawing.Point(280, 56)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(128, 21)
        Me.dtpToDate.TabIndex = 114
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CalendarFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Enabled = False
        Me.dtpFromDate.Location = New System.Drawing.Point(88, 56)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpFromDate.TabIndex = 112
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(16, 56)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(88, 24)
        Me.chkDate.TabIndex = 115
        Me.chkDate.Text = "签约日期"
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(280, 32)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(128, 21)
        Me.txtCorpName.TabIndex = 111
        Me.txtCorpName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(88, 32)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectCode.TabIndex = 108
        Me.txtProjectCode.Text = ""
        '
        'lbl2
        '
        Me.lbl2.Location = New System.Drawing.Point(224, 32)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(56, 23)
        Me.lbl2.TabIndex = 110
        Me.lbl2.Text = "企业名称"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl1
        '
        Me.lbl1.Location = New System.Drawing.Point(32, 32)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(64, 23)
        Me.lbl1.TabIndex = 109
        Me.lbl1.Text = "项目编码"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 14)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "到"
        '
        'dtpLoanToDate
        '
        Me.dtpLoanToDate.Enabled = False
        Me.dtpLoanToDate.Location = New System.Drawing.Point(272, 72)
        Me.dtpLoanToDate.Name = "dtpLoanToDate"
        Me.dtpLoanToDate.Size = New System.Drawing.Size(128, 21)
        Me.dtpLoanToDate.TabIndex = 118
        '
        'dtpLoanFromDate
        '
        Me.dtpLoanFromDate.CalendarFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpLoanFromDate.Enabled = False
        Me.dtpLoanFromDate.Location = New System.Drawing.Point(80, 72)
        Me.dtpLoanFromDate.Name = "dtpLoanFromDate"
        Me.dtpLoanFromDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpLoanFromDate.TabIndex = 116
        '
        'chkLoanDate
        '
        Me.chkLoanDate.Location = New System.Drawing.Point(8, 72)
        Me.chkLoanDate.Name = "chkLoanDate"
        Me.chkLoanDate.Size = New System.Drawing.Size(88, 24)
        Me.chkLoanDate.TabIndex = 119
        Me.chkLoanDate.Text = "承保日期"
        '
        'FQueryGuaranteeForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblToDate, Me.dtpToDate, Me.dtpFromDate, Me.chkDate, Me.txtCorpName, Me.txtProjectCode, Me.lbl2, Me.lbl1, Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryGuaranteeForm"
        Me.Text = "反担保措施查询"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub chkDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDate.CheckedChanged
        dtpFromDate.Enabled = chkDate.Checked
        dtpToDate.Enabled = chkDate.Checked
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal Condition As String)
        Dim strProjectCode, strCorpName As String
        Dim dtDateFrom, dtDateTo, dtLoanDateFrom, dtLoanDateTo As Object
        Dim i, j As Integer
        Dim iTotalSum As Decimal
        Dim dtResult As DataTable

        strProjectCode = txtProjectCode.Text.Trim
        strCorpName = txtCorpName.Text.Trim
        dtDateFrom = IIf(chkDate.Checked, dtpFromDate.Value.Date, Nothing)
        dtDateTo = IIf(chkDate.Checked, dtpToDate.Value.Date, Nothing)
        dtLoanDateFrom = IIf(chkLoanDate.Checked, dtpLoanFromDate.Value.Date, Nothing)
        dtLoanDateTo = IIf(chkLoanDate.Checked, dtpLoanToDate.Value.Date, Nothing)

        dtResult = gWs.Usp_ListGuaranteeForm(strProjectCode, strCorpName, dtDateFrom, dtDateTo, dtLoanDateFrom, dtLoanDateTo, UserName).Tables(0)

        Dim drRow As DataRow = dtResult.NewRow
        With drRow
            .Item(0) = "合计："
            For j = 3 To dtResult.Columns.Count - 1
                If j <> 4 Then
                    For i = 0 To dtResult.Rows.Count - 1
                        If Not IsDBNull(dtResult.Rows(i).Item(j)) Then
                            iTotalSum = iTotalSum + CDec(dtResult.Rows(i).Item(j))
                        End If
                    Next
                    .Item(j) = iTotalSum
                End If
                iTotalSum = 0
            Next
        End With
        dtResult.Rows.Add(drRow)

        Me.grdTable.DataSource = dtResult
        If grdTable.TableStyles.Count = 0 Then
            Me.AddTableStyle()
        End If

        For j = 3 To dtResult.Columns.Count - 1
            If j <> 4 Then
                If j <> 3 And j <> 5 Then
                    CType(grdTable.TableStyles(0).GridColumnStyles(j), DataGridTextBoxColumn).Format = "n"
                End If
                CType(grdTable.TableStyles(0).GridColumnStyles(j), DataGridTextBoxColumn).Alignment = HorizontalAlignment.Right
            End If
        Next

    End Sub
    Private Sub AddTableStyle()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        Dim dt As DataTable = CType(grdTable.DataSource, DataTable)
        dgts.MappingName = dt.TableName
        Dim Column As DataColumn
        Dim col As DataGridTextBoxColumn
        For Each Column In dt.Columns
            col = New DataGridTextBoxColumn()
            col.MappingName = Column.ColumnName
            col.HeaderText = Column.ColumnName
            dgts.GridColumnStyles.Add(col)
        Next
        grdTable.TableStyles.Clear()
        grdTable.TableStyles.Add(dgts)
    End Sub

    Protected Overrides Sub Export()
        ReportToExcel.ToExcel(Me.grdTable, "反担保措施查询", "反担保措施查询")
    End Sub

    Private Sub FQueryUnSignProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        WindowState = FormWindowState.Maximized
        MyBase.chkVisible.Visible = False
        MyBase.btnClear.Visible = False
    End Sub

    Private Sub chkLoanDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkLoanDate.CheckedChanged
        dtpLoanFromDate.Enabled = chkLoanDate.Checked
        dtpLoanToDate.Enabled = chkLoanDate.Checked
    End Sub
End Class
