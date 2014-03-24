Public Class FRegisterCounterclaim
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents txtPayReason As System.Windows.Forms.TextBox
    Friend WithEvents btnDetail As System.Windows.Forms.Button
    Friend WithEvents chkPayDate As System.Windows.Forms.CheckBox
    Public WithEvents txtCorName As System.Windows.Forms.TextBox
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPayBank As System.Windows.Forms.TextBox
    Friend WithEvents txtPaySubBank As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRegisterCounterclaim))
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnDetail = New System.Windows.Forms.Button()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
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
        Me.btnExit.Location = New System.Drawing.Point(439, 280)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtPaySubBank, Me.txtPayBank, Me.chkPayDate, Me.txtPayReason, Me.Label6, Me.txtPayAccount, Me.Label5, Me.Label4, Me.Label3, Me.txtProfiteer, Me.Label2, Me.dtpAskForPayDate, Me.chkAskForPayDate, Me.dtpPayDate})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 240)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'txtPaySubBank
        '
        Me.txtPaySubBank.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtPaySubBank.Location = New System.Drawing.Point(368, 42)
        Me.txtPaySubBank.MaxLength = 50
        Me.txtPaySubBank.Name = "txtPaySubBank"
        Me.txtPaySubBank.Size = New System.Drawing.Size(256, 21)
        Me.txtPaySubBank.TabIndex = 5
        Me.txtPaySubBank.Text = ""
        '
        'txtPayBank
        '
        Me.txtPayBank.Location = New System.Drawing.Point(88, 42)
        Me.txtPayBank.MaxLength = 20
        Me.txtPayBank.Name = "txtPayBank"
        Me.txtPayBank.Size = New System.Drawing.Size(160, 21)
        Me.txtPayBank.TabIndex = 4
        Me.txtPayBank.Text = ""
        '
        'chkPayDate
        '
        Me.chkPayDate.Location = New System.Drawing.Point(8, 16)
        Me.chkPayDate.Name = "chkPayDate"
        Me.chkPayDate.Size = New System.Drawing.Size(80, 24)
        Me.chkPayDate.TabIndex = 0
        Me.chkPayDate.Text = "索赔日期"
        '
        'txtPayReason
        '
        Me.txtPayReason.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtPayReason.Location = New System.Drawing.Point(88, 119)
        Me.txtPayReason.MaxLength = 500
        Me.txtPayReason.Multiline = True
        Me.txtPayReason.Name = "txtPayReason"
        Me.txtPayReason.Size = New System.Drawing.Size(536, 112)
        Me.txtPayReason.TabIndex = 8
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
        Me.txtPayAccount.Location = New System.Drawing.Point(88, 67)
        Me.txtPayAccount.MaxLength = 10
        Me.txtPayAccount.Name = "txtPayAccount"
        Me.txtPayAccount.Size = New System.Drawing.Size(160, 21)
        Me.txtPayAccount.TabIndex = 6
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
        Me.txtProfiteer.Location = New System.Drawing.Point(88, 93)
        Me.txtProfiteer.MaxLength = 50
        Me.txtProfiteer.Name = "txtProfiteer"
        Me.txtProfiteer.Size = New System.Drawing.Size(536, 21)
        Me.txtProfiteer.TabIndex = 7
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
        Me.dtpPayDate.Location = New System.Drawing.Point(88, 16)
        Me.dtpPayDate.Name = "dtpPayDate"
        Me.dtpPayDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpPayDate.TabIndex = 1
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(261, 280)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(350, 280)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 11
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDetail
        '
        Me.btnDetail.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDetail.Image = CType(resources.GetObject("btnDetail.Image"), System.Drawing.Bitmap)
        Me.btnDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetail.ImageIndex = 3
        Me.btnDetail.ImageList = Me.ImageListBasic
        Me.btnDetail.Location = New System.Drawing.Point(129, 280)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(120, 23)
        Me.btnDetail.TabIndex = 9
        Me.btnDetail.Text = "项目详细信息(&L)"
        Me.btnDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCorName
        '
        Me.txtCorName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(232, 8)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(376, 21)
        Me.txtCorName.TabIndex = 31
        Me.txtCorName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(64, 8)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(88, 21)
        Me.txtProjectCode.TabIndex = 30
        Me.txtProjectCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(176, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "企业名称"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "项目编码"
        '
        'FRegisterCounterclaim
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(650, 311)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCorName, Me.txtProjectCode, Me.Label1, Me.Label7, Me.btnDetail, Me.btnCommit, Me.btnSave, Me.GroupBox1, Me.btnExit})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FRegisterCounterclaim"
        Me.Text = "登记索赔信息"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private WorkFlowID As String
    Private CorporationName As String
    Private ProjectCode As String
    Private TaskID As String
    Private SystemDate As DateTime
    Private dsCounterClaim As DataSet
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
            dtpPayDate.Value = DateTime.Parse(CType(cmCounterClaim.Current, DataRowView)("counterclaim_date").ToString)
        End If
        If chkAskForPayDate.Checked Then
            dtpAskForPayDate.Value = DateTime.Parse(CType(cmCounterClaim.Current, DataRowView)("required_pay_date").ToString)
        End If
    End Sub

    Private Sub FRegisterCounterclaim_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
            If cmCounterClaim.Count = 0 Then
                Dim dr As DataRow = dsCounterClaim.Tables("Project_counterclaim").NewRow
                dr("project_code") = ProjectCode
                dr("create_person") = UserName
                dr("create_date") = SystemDate
                dsCounterClaim.Tables("Project_counterclaim").Rows.Add(dr)
            End If

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


    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnSave.Click
        dsCounterClaim.Tables("Project_counterclaim").Rows(0)("counterclaim_date") = IIf(chkPayDate.Checked, dtpPayDate.Value.Date, DBNull.Value)
        dsCounterClaim.Tables("Project_counterclaim").Rows(0)("required_pay_date") = IIf(chkAskForPayDate.Checked, dtpAskForPayDate.Value.Date, DBNull.Value)
        cmCounterClaim.EndCurrentEdit()
        Dim result As String = gWs.UpdateProjectCounterClaim(dsCounterClaim.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保证索赔信息失败", result, "")
        Else
            SWDialogBox.MessageBox.Show("$SaveSucceed")
            dsCounterClaim.AcceptChanges()
        End If
    End Sub

    Private Sub btnCommit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交")
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If
        cmCounterClaim.EndCurrentEdit()
        If dsCounterClaim.HasChanges Then
            btnSave_Click(Nothing, Nothing)
        End If
        Dim result As String = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, "", UserName)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "提交失败", result, "")
        Else
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            MyBase.raiseCommitSucceed()
            Close()
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetail.Click
        Dim ofrmShowProjectInfo As frmShowProjectInfo = New frmShowProjectInfo(ProjectCode, CorporationName)
        ofrmShowProjectInfo.Show()
    End Sub

    Private Sub chkAskForPayDate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAskForPayDate.CheckedChanged
        dtpAskForPayDate.Enabled = CType(sender, CheckBox).Checked
    End Sub

    Private Sub chkPayDate_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkPayDate.CheckedChanged
        dtpPayDate.Enabled = CType(sender, CheckBox).Checked
    End Sub
End Class
