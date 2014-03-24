
'作者：罗庆锋 日期： 2003-04-08
Public Class frmValidateProjectPlan
    Inherits frmBasic


    Private strStatus As String = String.Empty
    Private TaskID As String
    Private ProjectCode As String
    Private WorkFlowID As String
    Private CorporationName As String
    Private dsAccountDetail As DataSet
    Private item_type As String
    Private item_code As String
    Private SystemDate As DateTime
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
    Friend WithEvents dgShow As System.Windows.Forms.DataGrid
    Public WithEvents txtCorName As System.Windows.Forms.TextBox
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents rbtnNotAgree As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnAgree As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgShow = New System.Windows.Forms.DataGrid()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.rbtnNotAgree = New System.Windows.Forms.RadioButton()
        Me.rbtnAgree = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Location = New System.Drawing.Point(456, 400)
        Me.btnExit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgShow})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 360)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'dgShow
        '
        Me.dgShow.BackgroundColor = System.Drawing.SystemColors.AppWorkspace
        Me.dgShow.CaptionVisible = False
        Me.dgShow.DataMember = ""
        Me.dgShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgShow.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgShow.Location = New System.Drawing.Point(3, 17)
        Me.dgShow.Name = "dgShow"
        Me.dgShow.ReadOnly = True
        Me.dgShow.Size = New System.Drawing.Size(522, 340)
        Me.dgShow.TabIndex = 0
        '
        'txtCorName
        '
        Me.txtCorName.Enabled = False
        Me.txtCorName.Location = New System.Drawing.Point(248, 8)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.Size = New System.Drawing.Size(240, 21)
        Me.txtCorName.TabIndex = 39
        Me.txtCorName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Enabled = False
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 8)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 38
        Me.txtProjectCode.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(184, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "企业名称"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(16, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "项目编码"
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Location = New System.Drawing.Point(376, 400)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.TabIndex = 40
        Me.btnCommit.Text = "提交(&C)"
        '
        'rbtnNotAgree
        '
        Me.rbtnNotAgree.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.rbtnNotAgree.Location = New System.Drawing.Point(304, 400)
        Me.rbtnNotAgree.Name = "rbtnNotAgree"
        Me.rbtnNotAgree.Size = New System.Drawing.Size(64, 24)
        Me.rbtnNotAgree.TabIndex = 42
        Me.rbtnNotAgree.Text = "不同意"
        '
        'rbtnAgree
        '
        Me.rbtnAgree.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.rbtnAgree.Checked = True
        Me.rbtnAgree.Location = New System.Drawing.Point(248, 400)
        Me.rbtnAgree.Name = "rbtnAgree"
        Me.rbtnAgree.Size = New System.Drawing.Size(48, 24)
        Me.rbtnAgree.TabIndex = 41
        Me.rbtnAgree.TabStop = True
        Me.rbtnAgree.Text = "同意"
        '
        'frmValidateProjectPlan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(546, 431)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.rbtnNotAgree, Me.rbtnAgree, Me.btnCommit, Me.txtCorName, Me.txtProjectCode, Me.Label8, Me.Label9, Me.GroupBox1, Me.btnExit})
        Me.Name = "frmValidateProjectPlan"
        Me.Text = "确认还款计划"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    '样式表
    Private Sub addTableStyleForPlan()
        dgShow.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "project_account_detail"
        dgts.AllowSorting = False
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1
        col3.MappingName = "date"
        col3.HeaderText = "   日期"
        col3.Width = 80
        col3.Format = "yyyy-MM-dd"
        col3.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col3)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  2
        col4.MappingName = "payout"
        col4.HeaderText = "应收金额"
        col4.Alignment = HorizontalAlignment.Right
        col4.Width = 100
        col4.Format = "c"
        col4.FormatInfo = CGFormatInfo
        col4.NullText = "0.00"
        dgts.GridColumnStyles.Add(col4)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  3
        col5.MappingName = "remark"
        col5.HeaderText = "摘要"
        col5.Alignment = HorizontalAlignment.Left
        col5.Width = 320
        col5.NullText = String.Empty
        dgts.GridColumnStyles.Add(col5)
        dgShow.TableStyles.Add(dgts)
    End Sub

    Private Sub frmValidateProjectPlan_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ProjectCode = MyBase.getProjectCode
        TaskID = MyBase.getTaskID
        CorporationName = MyBase.getCorporationName
        WorkFlowID = MyBase.getWorkFlowID
        Try
            Me.Cursor = Cursors.WaitCursor
            item_type = "34" : item_code = "002"

            dsAccountDetail = gWs.GetProjectAccountDetailInfo("{project_code='" & ProjectCode & "' and item_type='" & item_type & "' and  item_code='" & item_code & "'}")
            dgShow.DataMember = "project_account_detail"
            dgShow.DataSource = dsAccountDetail
            addTableStyleForPlan()
            txtProjectCode.Text = ProjectCode : txtCorName.Text = CorporationName
            If dsAccountDetail.Tables(0).Rows.Count = 0 Then
                MessageBox.Show("该项目没有还款计划，无法确认", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim obj As Control
                For Each obj In Controls
                    obj.Enabled = False
                Next
                btnExit.Enabled = True
            End If
            SystemDate = gWs.GetSysTime
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function Affirm() As Boolean
        Dim dsOpinion As DataSet = gWs.GetProjectOpinionByProjectNo("null")
        Dim dr As DataRow = dsOpinion.Tables(0).NewRow
        With dr
            .Item("project_code") = ProjectCode
            .Item("item_type") = "53"
            .Item("item_code") = "003"
            .Item("conclusion") = IIf(rbtnAgree.Checked, "同意", "不同意")
            .Item("create_date") = SystemDate.Date
            .Item("create_person") = UserName
        End With
        dsOpinion.Tables(0).Rows.Add(dr)
        Return (gWs.UpdateProjectOpinion(dsOpinion.GetChanges) = "1")
    End Function

    Private Sub btnCommit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交")
            If answer = DialogResult.No Then
                Return
            End If
        End If
        If Not Affirm() Then
            MessageBox.Show("保存意见失败,无法提交", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim strSubmit As String = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, IIf(rbtnAgree.Checked, "同意", "不同意"), UserName)
        If strSubmit = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            MyBase.raiseCommitSucceed()
            Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "提交失败", strSubmit, "")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

End Class
