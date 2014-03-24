

Public Class frmTrackPlan
    Inherits frmBasic
    Private ProjectCode As String
    Private CorporationName As String
    Private WorkFlowID As String
    Private TaskID As String

    Private SystemDate As Date
    Private dsTracePlan As DataSet
    Private bmTracePlan As BindingManagerBase
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
    Public WithEvents btnCommit As System.Windows.Forms.Button
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Public WithEvents txtCorName As System.Windows.Forms.TextBox
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgPlan As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rtxtContent As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtManagerA As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtReturnType As System.Windows.Forms.TextBox
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtGuarantySum As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtStartDate As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgPlan = New System.Windows.Forms.DataGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rtxtContent = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtBank = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtStartDate = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtManagerA = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtReturnType = New System.Windows.Forms.TextBox()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtGuarantySum = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Location = New System.Drawing.Point(454, 378)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Location = New System.Drawing.Point(374, 378)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.TabIndex = 6
        Me.btnCommit.Text = "提交(&C)"
        '
        'btnNew
        '
        Me.btnNew.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnNew.Location = New System.Drawing.Point(134, 378)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.TabIndex = 3
        Me.btnNew.Text = "新增(&N)"
        '
        'btnSave
        '
        Me.btnSave.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(294, 378)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "保存(&S)"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnDelete.Enabled = False
        Me.btnDelete.Location = New System.Drawing.Point(214, 378)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Text = "删除(&D)"
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCorName.Enabled = False
        Me.txtCorName.Location = New System.Drawing.Point(232, 16)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(304, 21)
        Me.txtCorName.TabIndex = 31
        Me.txtCorName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtProjectCode.Enabled = False
        Me.txtProjectCode.Location = New System.Drawing.Point(96, 16)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(72, 21)
        Me.txtProjectCode.TabIndex = 30
        Me.txtProjectCode.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(176, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "企业名称"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "项目编码"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgPlan})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(542, 184)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'dgPlan
        '
        Me.dgPlan.CaptionVisible = False
        Me.dgPlan.DataMember = ""
        Me.dgPlan.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgPlan.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgPlan.Location = New System.Drawing.Point(3, 17)
        Me.dgPlan.Name = "dgPlan"
        Me.dgPlan.ReadOnly = True
        Me.dgPlan.Size = New System.Drawing.Size(536, 164)
        Me.dgPlan.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.rtxtContent, Me.Label2, Me.dtpDate, Me.Label1})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(542, 88)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        '
        'rtxtContent
        '
        Me.rtxtContent.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.rtxtContent.BackColor = System.Drawing.SystemColors.Window
        Me.rtxtContent.Enabled = False
        Me.rtxtContent.Location = New System.Drawing.Point(64, 40)
        Me.rtxtContent.MaxLength = 100
        Me.rtxtContent.Name = "rtxtContent"
        Me.rtxtContent.Size = New System.Drawing.Size(470, 42)
        Me.rtxtContent.TabIndex = 2
        Me.rtxtContent.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "备  注"
        '
        'dtpDate
        '
        Me.dtpDate.Enabled = False
        Me.dtpDate.Location = New System.Drawing.Point(64, 16)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpDate.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "时间"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtBank, Me.Label14, Me.txtStartDate, Me.Label13, Me.txtManagerA, Me.Label12, Me.txtReturnType, Me.txtEndDate, Me.Label11, Me.Label10, Me.txtGuarantySum, Me.Label9, Me.Label5, Me.txtProjectCode, Me.txtCorName, Me.Label6})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(544, 96)
        Me.GroupBox3.TabIndex = 34
        Me.GroupBox3.TabStop = False
        '
        'txtBank
        '
        Me.txtBank.Enabled = False
        Me.txtBank.Location = New System.Drawing.Point(376, 64)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.Size = New System.Drawing.Size(160, 21)
        Me.txtBank.TabIndex = 80
        Me.txtBank.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(320, 64)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 16)
        Me.Label14.TabIndex = 79
        Me.Label14.Text = "贷款银行"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStartDate
        '
        Me.txtStartDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtStartDate.Enabled = False
        Me.txtStartDate.Location = New System.Drawing.Point(96, 64)
        Me.txtStartDate.Name = "txtStartDate"
        Me.txtStartDate.Size = New System.Drawing.Size(72, 21)
        Me.txtStartDate.TabIndex = 78
        Me.txtStartDate.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 64)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(80, 16)
        Me.Label13.TabIndex = 77
        Me.Label13.Text = "放款开始日期"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtManagerA
        '
        Me.txtManagerA.BackColor = System.Drawing.SystemColors.Window
        Me.txtManagerA.Enabled = False
        Me.txtManagerA.Location = New System.Drawing.Point(232, 40)
        Me.txtManagerA.Name = "txtManagerA"
        Me.txtManagerA.Size = New System.Drawing.Size(80, 21)
        Me.txtManagerA.TabIndex = 76
        Me.txtManagerA.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(176, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 16)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "经理A角"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReturnType
        '
        Me.txtReturnType.BackColor = System.Drawing.SystemColors.Window
        Me.txtReturnType.Enabled = False
        Me.txtReturnType.Location = New System.Drawing.Point(376, 40)
        Me.txtReturnType.Name = "txtReturnType"
        Me.txtReturnType.Size = New System.Drawing.Size(160, 21)
        Me.txtReturnType.TabIndex = 74
        Me.txtReturnType.Text = ""
        '
        'txtEndDate
        '
        Me.txtEndDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtEndDate.Enabled = False
        Me.txtEndDate.Location = New System.Drawing.Point(232, 64)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.Size = New System.Drawing.Size(80, 21)
        Me.txtEndDate.TabIndex = 73
        Me.txtEndDate.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(320, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 72
        Me.Label11.Text = "还款方式"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(176, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "截止日期"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGuarantySum
        '
        Me.txtGuarantySum.BackColor = System.Drawing.SystemColors.Window
        Me.txtGuarantySum.Enabled = False
        Me.txtGuarantySum.Location = New System.Drawing.Point(96, 40)
        Me.txtGuarantySum.Name = "txtGuarantySum"
        Me.txtGuarantySum.Size = New System.Drawing.Size(72, 21)
        Me.txtGuarantySum.TabIndex = 70
        Me.txtGuarantySum.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 16)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "贷款金额(万元)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmTrackPlan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(562, 407)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.GroupBox2, Me.GroupBox1, Me.btnCommit, Me.btnNew, Me.btnSave, Me.btnDelete, Me.btnExit})
        Me.Name = "frmTrackPlan"
        Me.Text = "保后跟踪计划"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgPlan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub CreatePlan(ByVal StartDate As Date, ByVal EndDate As Date)
        Dim EachDate As Date
        EachDate = StartDate.AddMonths(1)
        While EachDate.Date <= EndDate.Date
            Dim dr As DataRow = dsTracePlan.Tables("trace_plan").NewRow
            With dr
                .Item("project_code") = ProjectCode
                .Item("trace_date") = EachDate.Date
                .Item("remark") = CorporationName & "的保后跟踪计划"
                .Item("create_person") = UserName
                .Item("create_date") = SystemDate.Date
            End With
            dsTracePlan.Tables("trace_plan").Rows.Add(dr)
            EachDate = EachDate.AddMonths(2)
        End While
    End Sub
    Private Sub GetLoanNotice()
        Dim dsLN As DataSet = New DataSet()
        dsLN = gWs.GetLoanNoticeInfo("{project_code LIKE '" & ProjectCode & "'}")
        Dim dr As DataRow
        For Each dr In dsLN.Tables(0).Rows
            If Not (IsDBNull(dr("start_date")) Or IsDBNull(dr("end_date"))) Then
                CreatePlan(CDate(dr("start_date")), CDate(dr("end_date")))
            End If
        Next
        If dsTracePlan.HasChanges Then
            Dim result As String = gWs.UpdateTracePlan(dsTracePlan.GetChanges)
            If result = "1" Then
                dsTracePlan = gWs.GetTracePlanInfo("{project_code LIKE '" & ProjectCode & "'}")
                bmTracePlan = BindingContext(dsTracePlan, "trace_plan")
                dgPlan.DataMember = "trace_plan"
                dgPlan.DataSource = dsTracePlan
            Else
                SWDialogBox.MessageBox.Show("*999", "新增记录失败", result, "")
                'MessageBox.Show("新增记录失败" & vbCr & result, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        End If
    End Sub
    Private Sub frmTrackPlan_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            ProjectCode = MyBase.getProjectCode
            CorporationName = MyBase.getCorporationName
            WorkFlowID = MyBase.getWorkFlowID
            TaskID = MyBase.getTaskID
            txtCorName.Text = CorporationName : txtProjectCode.Text = ProjectCode


            SystemDate = gWs.GetSysTime
            dtpDate.Value = SystemDate.Date
            dsTracePlan = gWs.GetTracePlanInfo("{project_code LIKE '" & ProjectCode & "'}")
            bmTracePlan = BindingContext(dsTracePlan, "trace_plan")
            dgPlan.DataMember = "trace_plan"
            dgPlan.DataSource = dsTracePlan
            AddTableStyle()
            '''''''''获取项目信息'''''''''''''''''''
            Dim dsInfo As DataSet = New DataSet()
            dsInfo = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
            txtGuarantySum.DataBindings.Add(New Binding("Text", dsInfo, "ViewProject.GuaranteeSum"))
            txtReturnType.DataBindings.Add(New Binding("Text", dsInfo, "ViewProject.RefundType"))
            txtEndDate.DataBindings.Add(New Binding("Text", dsInfo, "ViewProject.EndTime"))
            txtManagerA.DataBindings.Add(New Binding("Text", dsInfo, "ViewProject.24"))
            txtStartDate.DataBindings.Add(New Binding("Text", dsInfo, "ViewProject.StartTime"))
            txtBank.DataBindings.Add(New Binding("Text", dsInfo, "ViewProject.BankName"))
            Dim str As String
            If txtStartDate.Text.Trim <> String.Empty Then
                str = txtStartDate.Text
                txtStartDate.DataBindings.Clear()
                txtStartDate.Text = DateTime.Parse(str).ToString("yyyy-MM-dd")
            End If
            If txtEndDate.Text.Trim <> String.Empty Then
                str = txtEndDate.Text
                txtEndDate.DataBindings.Clear()
                txtEndDate.Text = DateTime.Parse(str).ToString("yyyy-MM-dd")
            End If
            ''''''''''''''''''''''''''''''''''''''''
            GetLoanNotice() '产生新的跟踪计划
            AddHandler btnNew.Click, AddressOf NewEvent
            btnDelete.Enabled = bmTracePlan.Count > 0
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub AddTableStyle()
        dgPlan.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.AllowSorting = False
        dgts.MappingName = "trace_plan"
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 0
        col1.MappingName = "trace_date"
        col1.HeaderText = "保后跟踪日期"
        col1.Width = 100
        col1.NullText = String.Empty
        col1.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col1)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1
        col3.MappingName = "remark"
        col3.HeaderText = " 备注"
        col3.Width = 400
        col3.NullText = String.Empty
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        dgPlan.TableStyles.Add(dgts)
    End Sub
    Private HasBinded As Boolean = False
    Private Sub IniBinding()
        dtpDate.DataBindings.Add(New Binding("Value", dsTracePlan, "trace_plan.trace_date"))
        rtxtContent.DataBindings.Add(New Binding("Text", dsTracePlan, "trace_plan.remark"))
        HasBinded = True
    End Sub
    Private Sub Quitbinding()
        dtpDate.DataBindings.Clear()
        rtxtContent.DataBindings.Clear()
        HasBinded = False
    End Sub
    Private Sub SetObjsEnabled(ByVal IsEnable As Boolean)
        dtpDate.Enabled = IsEnable : rtxtContent.Enabled = IsEnable : btnSave.Enabled = IsEnable
        dgPlan.Enabled = Not IsEnable
    End Sub
    Private Sub Cancel(ByVal sender As Object, ByVal e As EventArgs)
        If Not sender.GetType Is GetType(Button) Then Return

        If CType(sender, Button) Is btnNew And bmTracePlan.Count = 1 Then
            Quitbinding()
        End If
        If dsTracePlan.HasChanges Then
            dsTracePlan.RejectChanges()
        End If
        SetObjsEnabled(False)
        btnNew.Text = "新增(&N)"
        RemoveHandler btnNew.Click, AddressOf Cancel
        AddHandler btnNew.Click, AddressOf NewEvent
        btnDelete.Enabled = (dgPlan.CurrentRowIndex >= 0)
    End Sub

    Private Sub NewEvent(ByVal sender As Object, ByVal e As EventArgs)
        Dim dr As DataRow = dsTracePlan.Tables("trace_plan").NewRow
        With dr
            .Item("project_code") = ProjectCode
            .Item("trace_date") = dtpDate.Value.Date
            .Item("create_person") = UserName
            .Item("create_date") = SystemDate.Date
        End With
        dsTracePlan.Tables("trace_plan").Rows.Add(dr)
        bmTracePlan.Position = bmTracePlan.Count - 1
        btnNew.Text = "取消(&N)"
        RemoveHandler btnNew.Click, AddressOf NewEvent
        AddHandler btnNew.Click, AddressOf Cancel
        SetObjsEnabled(True)
        If Not HasBinded Then
            IniBinding()
        End If
        btnDelete.Enabled = False
        rtxtContent.Focus()
    End Sub
    Private Sub DeleteEvent(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        'MessageBox.Show("您将删除该记录？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If SWDialogBox.MessageBox.Show("?1004", "") = DialogResult.Yes Then
            If HasBinded And bmTracePlan.Count = 1 Then
                Quitbinding()
            End If
            CType(bmTracePlan.Current, DataRowView).Delete()
            Dim strResult As String = gWs.UpdateTracePlan(dsTracePlan.GetChanges)
            If (strResult = "1") Then
                SWDialogBox.MessageBox.Show("$DeleteSucceed")
                'MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dsTracePlan.AcceptChanges()
            Else
                SWDialogBox.MessageBox.Show("*999", "删除失败", strResult, "")
                'MessageBox.Show("删除失败" & vbCr & strResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If Not HasBinded Then
                rtxtContent.Text = String.Empty
                IniBinding()
            End If
        End If
        btnDelete.Enabled = (dgPlan.CurrentRowIndex >= 0)
    End Sub
    Private IsWrong As Boolean = False
    Private Sub SaveEvent(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        IsWrong = True
        If dtpDate.Value.Date < SystemDate.Date Then
            SWDialogBox.MessageBox.Show("$1003", "跟踪日期")
            'MessageBox.Show("跟踪日期不能小于当前日期", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dtpDate.Focus()
            Return
        End If
        bmTracePlan.Position = bmTracePlan.Count - 1
        Dim strResult As String = gWs.UpdateTracePlan(dsTracePlan.GetChanges)
        If (strResult = "1") Then
            IsWrong = False
            If sender Is Nothing Then Return

            SWDialogBox.MessageBox.Show("$SaveSucceed")
            'MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Quitbinding()
            dsTracePlan = gWs.GetTracePlanInfo("{project_code LIKE '" & ProjectCode & "'}")
            bmTracePlan = BindingContext(dsTracePlan, "trace_plan")
            dgPlan.DataMember = "trace_plan"
            dgPlan.DataSource = dsTracePlan
        Else
            SWDialogBox.MessageBox.Show("*999", "保存失败", strResult, "")
            'MessageBox.Show("保存失败" & vbCr & strResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            IsWrong = True
        End If
        Cancel(sender, e)
        bmTracePlan.Position = bmTracePlan.Count - 1
    End Sub

    Private Sub btnCommit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交") 'MessageBox.Show("确定提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If
        If dsTracePlan.HasChanges Then
            SaveEvent(Nothing, Nothing)
            If IsWrong Then Return
        End If
        Dim strSuccess As String = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, "", UserName)
        If strSuccess = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            'MessageBox.Show("提交成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            raiseCommitSucceed()
            RemoveHandler MyBase.Closing, AddressOf frmTrackPlan_Closing
            Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "提交失败", strSuccess, "")
            'MessageBox.Show("提交失败" & vbCr & strSuccess, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        ConfirmClose(sender, e)
    End Sub
    Protected Function ConfirmClose(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        If dsTracePlan.HasChanges Then
            Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003") 'MessageBox.Show("数据已修改，是否保存？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If QueryResult = DialogResult.Yes Then
                SaveEvent(Nothing, Nothing)
                If IsWrong Then Return False
            ElseIf QueryResult = DialogResult.Cancel Then
                Return False
            End If
        End If
        RemoveHandler MyBase.Closing, AddressOf frmTrackPlan_Closing
        Close()
        Return True
    End Function

    Private Sub frmTrackPlan_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, e)
    End Sub

    Private Sub dgPlan_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgPlan.MouseUp
        With dgPlan
            If .CurrentRowIndex < 0 Then Return
            .Select(.CurrentRowIndex)
            If Not HasBinded Then
                IniBinding()
            End If
        End With
    End Sub
End Class
