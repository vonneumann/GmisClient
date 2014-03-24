

Public Class FQueryGuarantingCorporation
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents style As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_code As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_manager_A As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_last_check_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_last_trial_time As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboTerms As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryGuarantingCorporation))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.style = New System.Windows.Forms.DataGridTableStyle()
        Me.col_code = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col_manager_A = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col_last_check_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col_last_trial_time = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cboTerms = New System.Windows.Forms.ComboBox()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageIndex = -1
        Me.btnRefresh.ImageList = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(448, 80)
        Me.btnRefresh.Visible = True
        '
        'ImageListQuery
        '
        Me.ImageListQuery.ImageStream = CType(resources.GetObject("ImageListQuery.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(536, 80)
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 112)
        Me.grdTable.Size = New System.Drawing.Size(696, 368)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.style})
        Me.grdTable.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Bitmap)
        Me.btnExport.ImageIndex = -1
        Me.btnExport.ImageList = Nothing
        Me.btnExport.Location = New System.Drawing.Point(536, 80)
        Me.btnExport.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Bitmap)
        Me.btnClear.ImageIndex = -1
        Me.btnClear.ImageList = Nothing
        Me.btnClear.Location = New System.Drawing.Point(192, 80)
        Me.btnClear.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 80)
        Me.chkVisible.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboTerms, Me.dtpEndDate, Me.Label2, Me.Label1})
        Me.grpCondition.Size = New System.Drawing.Size(696, 56)
        Me.grpCondition.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(624, 80)
        Me.btnExit.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(296, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "个月"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "截止日期"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(88, 21)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpEndDate.TabIndex = 3
        '
        'style
        '
        Me.style.DataGrid = Me.grdTable
        Me.style.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_code, Me.col_name, Me.col_manager_A, Me.col_last_check_date, Me.col_last_trial_time})
        Me.style.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.style.MappingName = "Table"
        '
        'col_code
        '
        Me.col_code.Format = ""
        Me.col_code.FormatInfo = Nothing
        Me.col_code.HeaderText = "项目编码"
        Me.col_code.MappingName = "project_code"
        Me.col_code.NullText = ""
        Me.col_code.Width = 85
        '
        'col_name
        '
        Me.col_name.Format = ""
        Me.col_name.FormatInfo = Nothing
        Me.col_name.HeaderText = "企业名称"
        Me.col_name.MappingName = "corporation_name"
        Me.col_name.NullText = ""
        Me.col_name.Width = 130
        '
        'col_manager_A
        '
        Me.col_manager_A.Format = ""
        Me.col_manager_A.FormatInfo = Nothing
        Me.col_manager_A.HeaderText = "项目经理A角"
        Me.col_manager_A.MappingName = "manager_A"
        Me.col_manager_A.NullText = ""
        Me.col_manager_A.Width = 85
        '
        'col_last_check_date
        '
        Me.col_last_check_date.Format = ""
        Me.col_last_check_date.FormatInfo = Nothing
        Me.col_last_check_date.HeaderText = "最近一次跟踪日期"
        Me.col_last_check_date.MappingName = "last_check_date"
        Me.col_last_check_date.NullText = ""
        Me.col_last_check_date.Width = 140
        '
        'col_last_trial_time
        '
        Me.col_last_trial_time.Format = ""
        Me.col_last_trial_time.FormatInfo = Nothing
        Me.col_last_trial_time.HeaderText = "最近一次评审日期"
        Me.col_last_trial_time.MappingName = "last_trial_time"
        Me.col_last_trial_time.NullText = ""
        Me.col_last_trial_time.Width = 140
        '
        'cboTerms
        '
        Me.cboTerms.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboTerms.Location = New System.Drawing.Point(216, 21)
        Me.cboTerms.Name = "cboTerms"
        Me.cboTerms.Size = New System.Drawing.Size(72, 20)
        Me.cboTerms.TabIndex = 4
        '
        'FQueryGuarantingCorporation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 486)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpCondition, Me.btnExport, Me.btnClear, Me.grdTable, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.btnPrint})
        Me.Name = "FQueryGuarantingCorporation"
        Me.Text = "未保后跟踪项目一览表"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private start_date, end_date As DateTime
    Private endYear, endMonth, endDay, startYear, startMonth, startDay, Term As Integer
    Private TempYear, TempMonth, TempM As Integer


    Private Function GetEndDate() As Boolean
        '2006- 6- 2 liutao add
        end_date = New DateTime(dtpEndDate.Value.Year, dtpEndDate.Value.Month, dtpEndDate.Value.Day, 23, 59, 59)

        endYear = end_date.Year
        endMonth = end_date.Month
        endDay = end_date.Day

        If Me.cboTerms.Text = "" Then
            ' start_date = New DateTime(1999, 1, 1, 23, 59, 59)
            start_date = end_date
        Else
            Try
                Term = Convert.ToInt16(Me.cboTerms.Text)
                TempM = (endYear * 12 + endMonth - Term) Mod 12
                TempMonth = (endYear * 12 + endMonth - Term) - TempM
                TempYear = TempMonth / 12
                If TempM = 0 Then
                    TempYear = TempYear - 1
                    TempM = 12
                End If
                start_date = New DateTime(TempYear, TempM, endDay, 23, 59, 59)
            Catch
                SWDialogBox.MessageBox.Show("输入的月必须为数字，请重新输入或选择！", "提示！", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
                Me.cboTerms.Focus()
                Return False
            End Try
        End If
        Return True
    End Function
    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        'If dtpStartDate.Value.Date > dtpEndDate.Value.Date Then
        '    SWDialogBox.MessageBox.Show("开始日期不能大于截止日期", "系统提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Warning)
        '    Return
        'End If
        'Dim start_date As DateTime = dtpStartDate.Value.Date
        If GetEndDate() = False Then
            Return
        End If
        grdTable.TableStyles.Clear()
        grdTable.DataSource = Nothing
        grdTable.DataMember = String.Empty

        Dim dsResult As DataSet = gWs.GetGuarantingCorporationList(start_date, end_date)
        grdTable.SetDataBinding(dsResult, "Table")
        grdTable.TableStyles.Add(Me.style)
    End Sub

    Private Sub FQueryGuarantingCorporation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
