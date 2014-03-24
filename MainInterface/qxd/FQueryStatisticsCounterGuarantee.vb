

Public Class FQueryStatisticsCounterGuarantee
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbEndMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEndYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbStartYear As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbYear As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMonth As System.Windows.Forms.RadioButton
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbEndMonth = New System.Windows.Forms.ComboBox()
        Me.cmbEndYear = New System.Windows.Forms.ComboBox()
        Me.cmbStartYear = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.rdbYear = New System.Windows.Forms.RadioButton()
        Me.rdbMonth = New System.Windows.Forms.RadioButton()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExport
        '
        Me.btnExport.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.grdTable.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.rdbMonth, Me.rdbYear, Me.Label5, Me.Label4, Me.Label3, Me.cmbEndMonth, Me.cmbEndYear, Me.cmbStartYear, Me.Label2, Me.Label1})
        Me.grpCondition.Visible = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(520, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(16, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "月"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(432, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "年"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(192, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 23)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "年"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbEndMonth
        '
        Me.cmbEndMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEndMonth.Location = New System.Drawing.Point(456, 24)
        Me.cmbEndMonth.Name = "cmbEndMonth"
        Me.cmbEndMonth.Size = New System.Drawing.Size(56, 20)
        Me.cmbEndMonth.TabIndex = 12
        '
        'cmbEndYear
        '
        Me.cmbEndYear.Location = New System.Drawing.Point(336, 24)
        Me.cmbEndYear.MaxLength = 4
        Me.cmbEndYear.Name = "cmbEndYear"
        Me.cmbEndYear.Size = New System.Drawing.Size(88, 20)
        Me.cmbEndYear.TabIndex = 11
        '
        'cmbStartYear
        '
        Me.cmbStartYear.Location = New System.Drawing.Point(96, 24)
        Me.cmbStartYear.MaxLength = 4
        Me.cmbStartYear.Name = "cmbStartYear"
        Me.cmbStartYear.Size = New System.Drawing.Size(88, 20)
        Me.cmbStartYear.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(264, 24)
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
        'rdbYear
        '
        Me.rdbYear.Checked = True
        Me.rdbYear.Location = New System.Drawing.Point(24, 56)
        Me.rdbYear.Name = "rdbYear"
        Me.rdbYear.Size = New System.Drawing.Size(88, 24)
        Me.rdbYear.TabIndex = 16
        Me.rdbYear.TabStop = True
        Me.rdbYear.Text = "按年统计"
        '
        'rdbMonth
        '
        Me.rdbMonth.Location = New System.Drawing.Point(144, 56)
        Me.rdbMonth.Name = "rdbMonth"
        Me.rdbMonth.Size = New System.Drawing.Size(88, 24)
        Me.rdbMonth.TabIndex = 17
        Me.rdbMonth.Text = "按月统计"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "年月"
        Me.DataGridTextBoxColumn1.MappingName = "YearMonth"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "类别"
        Me.DataGridTextBoxColumn2.MappingName = "Type"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "数量"
        Me.DataGridTextBoxColumn3.MappingName = "TypeCount"
        Me.DataGridTextBoxColumn3.NullText = "0"
        Me.DataGridTextBoxColumn3.Width = 120
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = "n"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "金额(元)"
        Me.DataGridTextBoxColumn4.MappingName = "TypeSum"
        Me.DataGridTextBoxColumn4.NullText = "0.00"
        Me.DataGridTextBoxColumn4.Width = 200
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "单数"
        Me.DataGridTextBoxColumn5.MappingName = "ProjectCount"
        Me.DataGridTextBoxColumn5.NullText = String.Empty
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'FQueryStatisticsCounterGuarantee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryStatisticsCounterGuarantee"
        Me.Text = "反担保情况统计表"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FQueryStatisticsCounterGuarantee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setYear()
        setMonth()
        MyBase.ReportFile = Application.StartupPath & "\Reports\QueryStatisticsCounterGuarantee.rpt"
        MyBase.ReportTitle = "反担保情况统计表"
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
    '获得查询条件
    Private Overloads Sub GetCondition(ByRef startYear As String, ByRef endYear As String, ByRef endMonth As String)
        startYear = Me.cmbStartYear.Text.Trim
        endYear = Me.cmbEndYear.Text.Trim
        endMonth = Me.cmbEndMonth.Text.Trim
    End Sub
    '查询
    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim startYear, endYear, endMonth As String
        GetCondition(startYear, endYear, endMonth)
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
        If rdbYear.Checked Then
            dsResult = gWs.FQueryStatisticsCounterguaranteeByYear(startYear, endYear + endMonth)
        End If
        If rdbMonth.Checked Then
            dsResult = gWs.FQueryStatisticsCounterguaranteeByMonth(startYear, endYear + endMonth)
        End If
        If Not dsResult Is Nothing Then
            MyBase.DataSource = dsResult.Tables(0)
            Me.grdTable.DataSource = dsResult.Tables(0)
            recordCount = dsResult.Tables(0).Rows.Count
            Me.Text = "反担保情况统计表" & "(" & recordCount & ")"
        End If

    End Sub
    '覆盖Clear()方法
    Protected Overrides Sub Clear()
        Dim control As Control

        For Each control In grpCondition.Controls
            If control.GetType() Is GetType(ComboBox) Then
                CType(control, ComboBox).SelectedItem = Date.Now.Year
                CType(control, ComboBox).SelectedItem = Date.Now.Month
            End If
        Next
    End Sub
    '判断起始年份和截止年份的大小
    '判断起始和截止日期
    Private Function determineDate(ByVal dateStart As String, ByVal dateEnd As String)
        If dateStart > dateEnd Then
            'MsgBox("截止年份必须大于或等于起始年份", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1008", "起始年份", "截止年份")
            Me.cmbStartYear.Text = dateEnd
        End If
    End Function

End Class
