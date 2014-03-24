
'会签确认
Public Class frmSignJointlyAffirm
    Inherits frmBasic
    Private Const MessageTitle As String = "担保业务系统"
    Private ProjectCode As String
    Private CorporationName As String
    Private WorkFlowID As String
    Private TaskID As String
    Private ws As htfServer.Service1
    Private item_type As String
    Private item_code As String
    Private dsConferenceTrial As DataSet
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
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents txtCorName As System.Windows.Forms.TextBox
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgOpinion As System.Windows.Forms.DataGrid
    Friend WithEvents cmbxConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgOpinion = New System.Windows.Forms.DataGrid()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbxConclusion = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgOpinion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(416, 248)
        Me.btnExit.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(336, 248)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.TabIndex = 1
        Me.btnCommit.Text = "提交(&C)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgOpinion})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 208)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'dgOpinion
        '
        Me.dgOpinion.CaptionVisible = False
        Me.dgOpinion.DataMember = ""
        Me.dgOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOpinion.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgOpinion.Location = New System.Drawing.Point(3, 17)
        Me.dgOpinion.Name = "dgOpinion"
        Me.dgOpinion.ReadOnly = True
        Me.dgOpinion.Size = New System.Drawing.Size(482, 188)
        Me.dgOpinion.TabIndex = 0
        '
        'txtCorName
        '
        Me.txtCorName.Enabled = False
        Me.txtCorName.Location = New System.Drawing.Point(240, 8)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.Size = New System.Drawing.Size(240, 21)
        Me.txtCorName.TabIndex = 43
        Me.txtCorName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Enabled = False
        Me.txtProjectCode.Location = New System.Drawing.Point(72, 8)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 42
        Me.txtProjectCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(176, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "企业名称"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "项目编码"
        '
        'cmbxConclusion
        '
        Me.cmbxConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxConclusion.Location = New System.Drawing.Point(256, 248)
        Me.cmbxConclusion.Name = "cmbxConclusion"
        Me.cmbxConclusion.Size = New System.Drawing.Size(72, 20)
        Me.cmbxConclusion.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(208, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "结论"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSignJointlyAffirm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(506, 279)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label3, Me.cmbxConclusion, Me.txtCorName, Me.txtProjectCode, Me.Label1, Me.Label2, Me.btnExit, Me.GroupBox1, Me.btnCommit})
        Me.Name = "frmSignJointlyAffirm"
        Me.Text = "确认会签"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgOpinion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GetDataSource()
        Dim TrialTimes As Integer = -1
        dsConferenceTrial = New DataSet()
        dsConferenceTrial = ws.GetConfTrialInfo("{project_code='" & ProjectCode & "' order by trial_times DESC}", "{project_code='" & ProjectCode & "'}")
        With dsConferenceTrial.Tables("conference_trial")
            If .Rows.Count = 0 Then
                MessageBox.Show("评委人数为零，无法会签", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Dim obj As Control
                For Each obj In Me.Controls
                    obj.Enabled = False
                Next
                Me.btnExit.Enabled = True
                Return
            End If
            TrialTimes = CInt(.Rows(0).Item("trial_times")) '取得最近一次评审次数
        End With
        With dsConferenceTrial.Tables("committeeman_opinion")
            Dim drs() As DataRow = .Select("trial_times<>" & TrialTimes)
            Dim delDR As DataRow
            For Each delDR In drs
                delDR.Delete()
            Next
            .AcceptChanges()
        End With
        dsConferenceTrial.Tables("committeeman_opinion").Columns.Add("RoleName", GetType(String), "IIF(role_id='28', '主评', '普通评委')")
    End Sub
    '评委意见样式表
    Private Sub addTableStyleForOpinion()
        Me.dgOpinion.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "committeeman_opinion"
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 0
        col1.MappingName = "project_code"
        col1.HeaderText = "项目编码"
        col1.Width = 0
        col1.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col1)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4 
        col6.MappingName = "trial_times"
        col6.HeaderText = "上会次数"
        col6.Width = 60
        col6.NullText = String.Empty
        col6.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col6)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1
        col3.MappingName = "committeeman"
        col3.HeaderText = " 会议评委"
        col3.Width = 60
        col3.NullText = String.Empty
        col3.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col3)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1
        col4.MappingName = "RoleName"
        col4.HeaderText = " 评委角色"
        col4.Width = 60
        col4.NullText = String.Empty
        col4.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col4)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2 
        col2.MappingName = "opinion"
        col2.HeaderText = "评委意见"
        col2.Alignment = HorizontalAlignment.Left
        col2.NullText = String.Empty
        col2.Width = 250
        dgts.GridColumnStyles.Add(col2)
        Me.dgOpinion.TableStyles.Add(dgts)
    End Sub
    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ProjectCode = MyBase.getProjectCode
        TaskID = MyBase.getTaskID
        CorporationName = MyBase.getCorporationName
        WorkFlowID = MyBase.getWorkFlowID

        txtProjectCode.Text = ProjectCode : txtCorName.Text = CorporationName
        ws = gWs
        SystemDate = ws.GetSysTime
        Me.GetDataSource()
        Me.dgOpinion.DataMember = "committeeman_opinion"
        Me.dgOpinion.DataSource = dsConferenceTrial
        Me.addTableStyleForOpinion()
        item_type = "46" : item_code = "001"
        Dim dsConclusion As DataSet  '绑定结论意见
        dsConclusion = ws.GetTransCondition(WorkFlowID, ProjectCode, TaskID)
        cmbxConclusion.DataSource = dsConclusion.Tables("project_task_transfer")
        cmbxConclusion.DisplayMember = "transfer_condition"
        cmbxConclusion.ValueMember = "transfer_condition"
    End Sub
    Private Function AffirmPlan() As String
        Dim dsProDoc As DataSet
        Dim curPhrase As String = MyBase.getPhase(ProjectCode)
        dsProDoc = ws.GetProjectDocumentByCondition("{project_code='" & Me.ProjectCode & "' and  item_type='" & item_type & "'}")
        Dim dr As DataRow = dsProDoc.Tables(0).NewRow
        With dr
            .Item("project_code") = ProjectCode
            .Item("phase") = curPhrase
            .Item("item_type") = item_type
            .Item("item_code") = item_code
            .Item("check_person") = UserName
            .Item("check_date") = SystemDate.Date
            .Item("create_person") = UserName
            .Item("create_date") = SystemDate.Date
        End With
        dsProDoc.Tables(0).Rows.Add(dr)
        Return ws.UpdateProjectDocument(dsProDoc)
    End Function
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If Me.isCommitConfirm Then
            Dim answer As DialogResult = MessageBox.Show("确定提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If answer = DialogResult.No Then
                Return
            End If
        End If

        Dim conclusion As String = String.Empty
        If Me.AffirmPlan() <> "1" Then
            MessageBox.Show("确认会签失败,没法提交", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.btnCommit.Enabled = False
            Return
        End If
        conclusion = Me.cmbxConclusion.SelectedValue
        Dim strSubmit As String = ws.finishedTask(WorkFlowID, ProjectCode, TaskID, conclusion, UserName)
        If strSubmit = "1" Then
            MessageBox.Show("提交成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("提交失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub frmSignJointlyAffirm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Me.Close()
    End Sub
End Class
