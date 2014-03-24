

Public Class frmSubmitTrialOpinion
    Inherits frmBasic
    Private ProjectCode As String
    Private CorporationName As String
    Private TaskID As String
    Private WorkFlowID As String
    Private SystemDate As Date
    Private dsProject As DataSet
    Private dsOpinion As DataSet
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsProject Is Nothing Then
            dsProject.Dispose()
        End If
        If Not dsOpinion Is Nothing Then
            dsOpinion.Dispose()
        End If
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
    Friend WithEvents txtOpinion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Protected WithEvents txtCorName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMoney As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMA As System.Windows.Forms.TextBox
    Friend WithEvents txtMB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtApplyServiceType As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSubmitTrialOpinion))
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtOpinion = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtApplyServiceType = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMoney = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBank = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMA = New System.Windows.Forms.TextBox()
        Me.txtMB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(480, 216)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(392, 216)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 1
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtOpinion})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 104)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "意见"
        '
        'txtOpinion
        '
        Me.txtOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOpinion.Location = New System.Drawing.Point(3, 17)
        Me.txtOpinion.MaxLength = 250
        Me.txtOpinion.Multiline = True
        Me.txtOpinion.Name = "txtOpinion"
        Me.txtOpinion.Size = New System.Drawing.Size(594, 84)
        Me.txtOpinion.TabIndex = 0
        Me.txtOpinion.Text = ""
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtApplyServiceType, Me.Label11, Me.txtCorName, Me.Label5, Me.Label6, Me.txtProjectCode, Me.Label10, Me.txtMoney, Me.Label9, Me.txtTerm, Me.Label8, Me.txtBank, Me.Label7, Me.Label4, Me.txtMA, Me.txtMB, Me.Label3, Me.Label12})
        Me.GroupBox4.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(600, 104)
        Me.GroupBox4.TabIndex = 40
        Me.GroupBox4.TabStop = False
        '
        'txtApplyServiceType
        '
        Me.txtApplyServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyServiceType.Location = New System.Drawing.Point(416, 44)
        Me.txtApplyServiceType.Name = "txtApplyServiceType"
        Me.txtApplyServiceType.ReadOnly = True
        Me.txtApplyServiceType.Size = New System.Drawing.Size(176, 21)
        Me.txtApplyServiceType.TabIndex = 35
        Me.txtApplyServiceType.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(336, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 14)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "申请业务品种"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(248, 16)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(344, 21)
        Me.txtCorName.TabIndex = 33
        Me.txtCorName.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 14)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "企 业 名 称"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 14)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "项 目 编 码"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(88, 16)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(72, 21)
        Me.txtProjectCode.TabIndex = 32
        Me.txtProjectCode.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(480, 74)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 14)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "万元"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMoney
        '
        Me.txtMoney.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMoney.Location = New System.Drawing.Point(416, 72)
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.ReadOnly = True
        Me.txtMoney.Size = New System.Drawing.Size(64, 21)
        Me.txtMoney.TabIndex = 29
        Me.txtMoney.Text = ""
        Me.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(336, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 14)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "申请贷款金额"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTerm
        '
        Me.txtTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerm.Location = New System.Drawing.Point(544, 72)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.ReadOnly = True
        Me.txtTerm.Size = New System.Drawing.Size(32, 21)
        Me.txtTerm.TabIndex = 28
        Me.txtTerm.Text = ""
        Me.txtTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(576, 74)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "月"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBank
        '
        Me.txtBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBank.Location = New System.Drawing.Point(88, 72)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.ReadOnly = True
        Me.txtBank.Size = New System.Drawing.Size(240, 21)
        Me.txtBank.TabIndex = 26
        Me.txtBank.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(512, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 14)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "期限"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "申请贷款银行"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMA
        '
        Me.txtMA.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMA.Location = New System.Drawing.Point(88, 44)
        Me.txtMA.Name = "txtMA"
        Me.txtMA.ReadOnly = True
        Me.txtMA.Size = New System.Drawing.Size(72, 21)
        Me.txtMA.TabIndex = 25
        Me.txtMA.Text = ""
        '
        'txtMB
        '
        Me.txtMB.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMB.Location = New System.Drawing.Point(248, 44)
        Me.txtMB.Name = "txtMB"
        Me.txtMB.ReadOnly = True
        Me.txtMB.Size = New System.Drawing.Size(80, 21)
        Me.txtMB.TabIndex = 27
        Me.txtMB.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "项目经理B角"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(8, 46)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 14)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "项目经理A角"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmSubmitTrialOpinion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(618, 247)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox4, Me.GroupBox1, Me.btnExit, Me.btnCommit})
        Me.Name = "frmSubmitTrialOpinion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "提交项目评审意见"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmSubmitTrialOpinion_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            SystemDate = gWs.GetSysTime
            ProjectCode = MyBase.getProjectCode : CorporationName = MyBase.getCorporationName
            TaskID = MyBase.getTaskID : WorkFlowID = MyBase.getWorkFlowID
            txtProjectCode.Text = ProjectCode : txtCorName.Text = CorporationName
            dsOpinion = gWs.GetProjectOpinionByProjectNo(ProjectCode)

            '返回项目基本信息
            'Dim dsMB As DataSet = gWs.GetCommonQueryInfo("SELECT attend_person FROM project_task_attendee WHERE (project_code LIKE '" & ProjectCode & "') AND (role_id = '25')")
            dsProject = New DataSet()
            dsProject = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
            txtMA.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.manager_A"))
            txtMB.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.manager_B"))
            txtMoney.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.ApplySum"))
            txtBank.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.ApplyBank"))
            txtTerm.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.ApplyTerm"))
            txtApplyServiceType.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.ApplyServiceType"))
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCommit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交") 'MessageBox.Show("确定提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If
        Dim result As String
        Dim newDr As DataRow = dsOpinion.Tables("TProjectOpinion").NewRow
        With newDr
            .Item("project_code") = ProjectCode
            .Item("item_type") = "52"
            .Item("item_code") = "005"
            .Item("content") = txtOpinion.Text
            .Item("conclusion") = DBNull.Value
            .Item("create_person") = UserName
            .Item("create_date") = SystemDate.Date
        End With
        dsOpinion.Tables("TProjectOpinion").Rows.Add(newDr)
        result = gWs.UpdateProjectOpinion(dsOpinion.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存项目评审意见失败", result, "")
            'MessageBox.Show("保存项目评审意见失败，不能提交" & vbCr & result, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        result = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, "", UserName)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "提交失败", result, "")
            'MessageBox.Show("提交失败" & vbCr & result, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            'MessageBox.Show("提交成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MyBase.raiseCommitSucceed()
            Close()
        End If
    End Sub
End Class
