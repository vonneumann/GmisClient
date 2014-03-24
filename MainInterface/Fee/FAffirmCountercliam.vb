Public Class FAffirmCountercliam
    Inherits frmBasic

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
    Public WithEvents txtCorName As System.Windows.Forms.TextBox
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPaySubBank As System.Windows.Forms.TextBox
    Friend WithEvents txtPayBank As System.Windows.Forms.TextBox
    Friend WithEvents chkPayDate As System.Windows.Forms.CheckBox
    Friend WithEvents txtPayReason As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPayAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProfiteer As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpAskForPayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkAskForPayDate As System.Windows.Forms.CheckBox
    Friend WithEvents dtpPayDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAuditOpinion As System.Windows.Forms.TextBox
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cboConclusion As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FAffirmCountercliam))
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPaySubBank = New System.Windows.Forms.TextBox()
        Me.txtPayBank = New System.Windows.Forms.TextBox()
        Me.chkPayDate = New System.Windows.Forms.CheckBox()
        Me.txtPayReason = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPayAccount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProfiteer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpAskForPayDate = New System.Windows.Forms.DateTimePicker()
        Me.chkAskForPayDate = New System.Windows.Forms.CheckBox()
        Me.dtpPayDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAuditOpinion = New System.Windows.Forms.TextBox()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboConclusion = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(528, 400)
        Me.btnExit.Visible = True
        '
        'txtCorName
        '
        Me.txtCorName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(216, 8)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(376, 21)
        Me.txtCorName.TabIndex = 36
        Me.txtCorName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(64, 8)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(88, 21)
        Me.txtProjectCode.TabIndex = 35
        Me.txtProjectCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(160, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "企业名称"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "项目编码"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtPaySubBank, Me.txtPayBank, Me.chkPayDate, Me.txtPayReason, Me.Label6, Me.txtPayAccount, Me.Label5, Me.Label4, Me.Label3, Me.txtProfiteer, Me.Label2, Me.dtpAskForPayDate, Me.chkAskForPayDate, Me.dtpPayDate})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 240)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "索赔信息"
        '
        'txtPaySubBank
        '
        Me.txtPaySubBank.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtPaySubBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPaySubBank.Location = New System.Drawing.Point(368, 42)
        Me.txtPaySubBank.MaxLength = 50
        Me.txtPaySubBank.Name = "txtPaySubBank"
        Me.txtPaySubBank.ReadOnly = True
        Me.txtPaySubBank.Size = New System.Drawing.Size(256, 21)
        Me.txtPaySubBank.TabIndex = 16
        Me.txtPaySubBank.Text = ""
        '
        'txtPayBank
        '
        Me.txtPayBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPayBank.Location = New System.Drawing.Point(88, 42)
        Me.txtPayBank.MaxLength = 20
        Me.txtPayBank.Name = "txtPayBank"
        Me.txtPayBank.ReadOnly = True
        Me.txtPayBank.Size = New System.Drawing.Size(160, 21)
        Me.txtPayBank.TabIndex = 15
        Me.txtPayBank.Text = ""
        '
        'chkPayDate
        '
        Me.chkPayDate.Location = New System.Drawing.Point(8, 16)
        Me.chkPayDate.Name = "chkPayDate"
        Me.chkPayDate.Size = New System.Drawing.Size(80, 24)
        Me.chkPayDate.TabIndex = 14
        Me.chkPayDate.Text = "索赔日期"
        '
        'txtPayReason
        '
        Me.txtPayReason.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtPayReason.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPayReason.Location = New System.Drawing.Point(88, 119)
        Me.txtPayReason.MaxLength = 500
        Me.txtPayReason.Multiline = True
        Me.txtPayReason.Name = "txtPayReason"
        Me.txtPayReason.ReadOnly = True
        Me.txtPayReason.Size = New System.Drawing.Size(536, 112)
        Me.txtPayReason.TabIndex = 13
        Me.txtPayReason.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 14)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "索 赔 理 由"
        '
        'txtPayAccount
        '
        Me.txtPayAccount.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPayAccount.Location = New System.Drawing.Point(88, 67)
        Me.txtPayAccount.MaxLength = 10
        Me.txtPayAccount.Name = "txtPayAccount"
        Me.txtPayAccount.ReadOnly = True
        Me.txtPayAccount.Size = New System.Drawing.Size(160, 21)
        Me.txtPayAccount.TabIndex = 11
        Me.txtPayAccount.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "付 款 帐 号"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "付  款  支  行"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "付 款 银 行"
        '
        'txtProfiteer
        '
        Me.txtProfiteer.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtProfiteer.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProfiteer.Location = New System.Drawing.Point(88, 93)
        Me.txtProfiteer.MaxLength = 50
        Me.txtProfiteer.Name = "txtProfiteer"
        Me.txtProfiteer.ReadOnly = True
        Me.txtProfiteer.Size = New System.Drawing.Size(536, 21)
        Me.txtProfiteer.TabIndex = 5
        Me.txtProfiteer.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "收  益  人"
        '
        'dtpAskForPayDate
        '
        Me.dtpAskForPayDate.Enabled = False
        Me.dtpAskForPayDate.Location = New System.Drawing.Point(368, 16)
        Me.dtpAskForPayDate.Name = "dtpAskForPayDate"
        Me.dtpAskForPayDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpAskForPayDate.TabIndex = 3
        '
        'chkAskForPayDate
        '
        Me.chkAskForPayDate.Location = New System.Drawing.Point(264, 14)
        Me.chkAskForPayDate.Name = "chkAskForPayDate"
        Me.chkAskForPayDate.TabIndex = 2
        Me.chkAskForPayDate.Text = "要求赔付日期"
        '
        'dtpPayDate
        '
        Me.dtpPayDate.Enabled = False
        Me.dtpPayDate.Location = New System.Drawing.Point(88, 16)
        Me.dtpPayDate.Name = "dtpPayDate"
        Me.dtpPayDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpPayDate.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtAuditOpinion})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 112)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "索赔意见"
        '
        'txtAuditOpinion
        '
        Me.txtAuditOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAuditOpinion.Location = New System.Drawing.Point(3, 17)
        Me.txtAuditOpinion.MaxLength = 1000
        Me.txtAuditOpinion.Multiline = True
        Me.txtAuditOpinion.Name = "txtAuditOpinion"
        Me.txtAuditOpinion.Size = New System.Drawing.Size(626, 92)
        Me.txtAuditOpinion.TabIndex = 0
        Me.txtAuditOpinion.Text = ""
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(440, 400)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 38
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 404)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(60, 14)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "结     论"
        '
        'cboConclusion
        '
        Me.cboConclusion.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.cboConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConclusion.Location = New System.Drawing.Point(80, 401)
        Me.cboConclusion.Name = "cboConclusion"
        Me.cboConclusion.Size = New System.Drawing.Size(176, 20)
        Me.cboConclusion.TabIndex = 40
        '
        'FAffirmCountercliam
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(650, 431)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboConclusion, Me.Label8, Me.btnCommit, Me.GroupBox2, Me.txtCorName, Me.txtProjectCode, Me.Label1, Me.Label7, Me.GroupBox1, Me.btnExit})
        Me.Name = "FAffirmCountercliam"
        Me.Text = "确认索赔"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private WorkFlowID As String
    Private CorporationName As String
    Private ProjectCode As String
    Private TaskID As String
    Private SystemDate As DateTime
    Private dsCounterClaim, dsConclusion As DataSet
    Private cmCounterClaim As CurrencyManager

    Private Sub SetDataBinding()
        txtPayBank.DataBindings.Add("Text", dsCounterClaim, "Project_counterclaim.bank")
        txtPaySubBank.DataBindings.Add("Text", dsCounterClaim, "Project_counterclaim.bank_branch")
        txtProfiteer.DataBindings.Add("Text", dsCounterClaim, "Project_counterclaim.beneficiary")
        txtPayReason.DataBindings.Add("Text", dsCounterClaim, "Project_counterclaim.counterclaim_reson")
        txtPayAccount.DataBindings.Add("Text", dsCounterClaim, "Project_counterclaim.account")
        If cmCounterClaim.Count > 0 Then
            chkPayDate.Checked = Not IsDBNull(CType(cmCounterClaim.Current, DataRowView)("counterclaim_date"))
            chkAskForPayDate.Checked = Not IsDBNull(CType(cmCounterClaim.Current, DataRowView)("required_pay_date"))
        End If
        If chkPayDate.Checked Then
            dtpPayDate.DataBindings.Add("Value", dsCounterClaim, "Project_counterclaim.counterclaim_date")
        End If
        If chkAskForPayDate.Checked Then
            dtpAskForPayDate.DataBindings.Add("Value", dsCounterClaim, "Project_counterclaim.required_pay_date")
        End If
    End Sub

    Private Sub FAffirmCountercliam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            WorkFlowID = MyBase.getWorkFlowID
            CorporationName = MyBase.getCorporationName
            ProjectCode = MyBase.getProjectCode
            TaskID = MyBase.getTaskID
            txtProjectCode.Text = ProjectCode : txtCorName.Text = CorporationName
            SystemDate = gWs.GetSysTime

            dsCounterClaim = gWs.GetProjectCounterClaimInfo("{project_code LIKE '" & ProjectCode & "'}")
            cmCounterClaim = Me.BindingContext(dsCounterClaim, "Project_counterclaim")
            '绑定结论ComboBox
            dsConclusion = gWs.GetTransCondition(WorkFlowID, ProjectCode, TaskID)
            cboConclusion.DataSource = dsConclusion.Tables(0)
            cboConclusion.DisplayMember = "transfer_condition"
            cboConclusion.ValueMember = "transfer_condition"
            '添加绑定
            SetDataBinding()
            chkAskForPayDate_CheckedChanged(chkAskForPayDate, Nothing)
            chkPayDate_CheckedChanged(chkPayDate, Nothing)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If cboConclusion.SelectedItem Is Nothing Then
            SWDialogBox.MessageBox.Show("$1001", "结论")
            cboConclusion.Focus()
            Return
        End If
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交")
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If
        Dim result As String
        Dim dsOpinion As DataSet = gWs.GetProjectOpinionByProjectNo("null")
        Dim dr As DataRow = dsOpinion.Tables(0).NewRow
        dr("project_code") = ProjectCode
        dr("item_type") = "54"
        dr("item_code") = "002"
        dr("content") = txtAuditOpinion.Text
        dr("conclusion") = cboConclusion.SelectedValue
        dr("create_person") = UserName
        dr("create_date") = SystemDate
        dsOpinion.Tables(0).Rows.Add(dr)
        result = gWs.UpdateProjectOpinion(dsOpinion.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "插入意见失败", result, "")
            Return
        End If
        result = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, cboConclusion.SelectedValue, UserName)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "提交失败", result, "")
        Else
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            MyBase.raiseCommitSucceed()
            Close()
        End If
    End Sub
    Private Sub chkAskForPayDate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAskForPayDate.CheckedChanged
        dtpAskForPayDate.Enabled = CType(sender, CheckBox).Checked
    End Sub

    Private Sub chkPayDate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPayDate.CheckedChanged
        dtpPayDate.Enabled = CType(sender, CheckBox).Checked
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
