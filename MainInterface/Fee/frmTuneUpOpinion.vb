

Public Class frmTuneUpOpinion
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
        If Not dsOpinion Is Nothing Then
            dsOpinion.Dispose()
        End If
        If Not dsProject Is Nothing Then
            dsProject.Dispose()
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
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbxConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents btnReport As System.Windows.Forms.Button
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtRecommendMoney As System.Windows.Forms.TextBox
    Friend WithEvents btnDetailInfo As System.Windows.Forms.Button
    Friend WithEvents txtApplyServiceType As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTuneUpOpinion))
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRecommendMoney = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtOpinion = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.cbxConclusion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
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
        Me.btnDetailInfo = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
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
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(487, 336)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(398, 336)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 4
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtRecommendMoney, Me.Label13, Me.txtOpinion, Me.dtpDate, Me.lblDate, Me.cbxConclusion, Me.Label1})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 112)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 216)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "意见"
        '
        'txtRecommendMoney
        '
        Me.txtRecommendMoney.Enabled = False
        Me.txtRecommendMoney.Location = New System.Drawing.Point(488, 184)
        Me.txtRecommendMoney.Name = "txtRecommendMoney"
        Me.txtRecommendMoney.Size = New System.Drawing.Size(104, 21)
        Me.txtRecommendMoney.TabIndex = 14
        Me.txtRecommendMoney.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(392, 187)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 14)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "推荐金额(万元)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOpinion
        '
        Me.txtOpinion.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtOpinion.Location = New System.Drawing.Point(3, 17)
        Me.txtOpinion.MaxLength = 250
        Me.txtOpinion.Multiline = True
        Me.txtOpinion.Name = "txtOpinion"
        Me.txtOpinion.Size = New System.Drawing.Size(594, 160)
        Me.txtOpinion.TabIndex = 2
        Me.txtOpinion.Text = ""
        '
        'dtpDate
        '
        Me.dtpDate.Enabled = False
        Me.dtpDate.Location = New System.Drawing.Point(248, 184)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpDate.TabIndex = 1
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(192, 187)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(54, 14)
        Me.lblDate.TabIndex = 12
        Me.lblDate.Text = "上会日期"
        '
        'cbxConclusion
        '
        Me.cbxConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxConclusion.Location = New System.Drawing.Point(48, 184)
        Me.cbxConclusion.Name = "cbxConclusion"
        Me.cbxConclusion.Size = New System.Drawing.Size(121, 20)
        Me.cbxConclusion.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 187)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 14)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "结论"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnReport
        '
        Me.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnReport.Enabled = False
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Bitmap)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.ImageIndex = 18
        Me.btnReport.ImageList = Me.ImageListBasic
        Me.btnReport.Location = New System.Drawing.Point(204, 336)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(93, 23)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "暂缓报告(&M)"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtApplyServiceType, Me.Label11, Me.txtCorName, Me.Label5, Me.Label6, Me.txtProjectCode, Me.Label10, Me.txtMoney, Me.Label9, Me.txtTerm, Me.Label8, Me.txtBank, Me.Label7, Me.Label4, Me.txtMA, Me.txtMB, Me.Label3, Me.Label12})
        Me.GroupBox4.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(600, 104)
        Me.GroupBox4.TabIndex = 39
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
        'btnDetailInfo
        '
        Me.btnDetailInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDetailInfo.Image = CType(resources.GetObject("btnDetailInfo.Image"), System.Drawing.Bitmap)
        Me.btnDetailInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetailInfo.ImageIndex = 3
        Me.btnDetailInfo.ImageList = Me.ImageListBasic
        Me.btnDetailInfo.Location = New System.Drawing.Point(72, 336)
        Me.btnDetailInfo.Name = "btnDetailInfo"
        Me.btnDetailInfo.Size = New System.Drawing.Size(120, 23)
        Me.btnDetailInfo.TabIndex = 40
        Me.btnDetailInfo.Text = "项目详细信息(&D)"
        Me.btnDetailInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(309, 336)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 41
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.Visible = False
        '
        'frmTuneUpOpinion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(618, 367)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnSave, Me.btnDetailInfo, Me.GroupBox4, Me.btnReport, Me.GroupBox1, Me.btnCommit, Me.btnExit})
        Me.MaximizeBox = False
        Me.Name = "frmTuneUpOpinion"
        Me.Text = "提交项目调研结论"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    '
    '系统日期
    '
    Private SystemDate As Date
    Private dsOpinion As DataSet
    Private tuneType As String = "52"
    Private tuneCode As String = "002"
    Private Const MaxMoney As Double = 1000000000
    Private ProjectCode As String
    Private CorporationName As String
    Private TaskID, WorkFlowID As String
    Private dsProject As DataSet
    Private htOpinion As Hashtable
    Private fileType As String = "45"
    Private fileCode As String = "005"
    Private GuarantyFeeStandard As Double = 0.0015 '0.018
    Private ReviewFeeStandard As Double = 0.0012

    Private Sub frmTuneUpOpinion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            SystemDate = gWs.GetSysTime
            dtpDate.Value = SystemDate.Date
            ProjectCode = MyBase.getProjectCode : CorporationName = MyBase.getCorporationName
            TaskID = MyBase.getTaskID : WorkFlowID = MyBase.getWorkFlowID
            txtProjectCode.Text = ProjectCode : txtCorName.Text = CorporationName
            dsOpinion = gWs.GetProjectOpinionByProjectNo(ProjectCode)
            'cbxConclusion.SelectedIndex = 0
            Dim dsConclusion As DataSet  '绑定评审会议意见
            dsConclusion = gWs.GetTransCondition(WorkFlowID, ProjectCode, TaskID)
            cbxConclusion.DataSource = dsConclusion.Tables(0)
            cbxConclusion.DisplayMember = "transfer_condition"
            cbxConclusion.ValueMember = "transfer_condition"
            AddHandler cbxConclusion.SelectedIndexChanged, AddressOf cbxConclusion_IndexChanged

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

            cbxConclusion.SelectedValue = DBNull.Value
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub CopyValueToDatarow(ByVal dr As DataRow, ByVal times As Integer)
        dr("project_code") = ProjectCode
        dr("trial_times") = times
        dr("apply_trial_date") = dtpDate.Value.Date
        dr("status") = False
        dr("service_type") = DBNull.Value 'txtApplyServiceType.Text
        dr("manager_recommend_sum") = MyIIf(txtRecommendMoney.Text, GetType(Double), DBNull.Value)
        dr("guarantee_sum") = DBNull.Value ' MyIIf(txtMoney.Text, GetType(Double), DBNull.Value)
        dr("terms") = DBNull.Value 'MyIIf(txtTerm.Text, GetType(Integer), 12)
        'dr("guarantee_rate") = GuarantyFeeStandard * 100
        'dr("trial_rate") = ReviewFeeStandard * 100
        dr("create_person") = UserName
        dr("create_date") = SystemDate.Date

        '2007-12-3 yjf edit 如果为展期上会，则标记为展期的上会记录，改记录在记录评审会时需要删除，因为该记录并非真实评审会通过
        '记录（该记录将影响当前项目的评审会通过金额）
        If Me.TaskID = "SubmissionProbeResultExp" Then
            dr("is_exp") = 1
        Else
            dr("is_exp") = 0
        End If
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If cbxConclusion.Text = String.Empty Then
            SWDialogBox.MessageBox.Show("$1001", "调研结论")
            cbxConclusion.Focus()
            Return
        End If
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交") 'MessageBox.Show("确定提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If
        If cbxConclusion.Text.IndexOf("暂缓") >= 0 Then
            Try
                Dim dsFile As DataSet = gWs.GetProjectFileByCondition("{(project_code LIKE '" & ProjectCode & "' AND item_type='" & fileType & "' AND item_code='" & fileCode & "')}")
                If dsFile.Tables(0).Rows.Count = 0 Then
                    SWDialogBox.MessageBox.Show("$X026")
                    Return
                ElseIf IsDBNull(dsFile.Tables(0).Rows(0)("relation_num")) Then
                    SWDialogBox.MessageBox.Show("$X026")
                    Return
                End If
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
                Return
            End Try
        End If
        Dim result As String

        If cbxConclusion.Tag Is Nothing AndAlso cbxConclusion.Text.IndexOf("会") >= 0 Then
            If dtpDate.Value.Date < SystemDate.Date Then
                SWDialogBox.MessageBox.Show("$1003", "申请上会日期")
                Return
            End If
            '插入一条新纪录到会议评审表  conference_trial
            Dim dsConTrial As DataSet = gWs.GetConfTrialInfo("{project_code LIKE '" & ProjectCode & "'}", "null")
            Dim times As Integer = dsConTrial.Tables("conference_trial").Rows.Count + 1

            With dsConTrial.Tables("conference_trial")
                If times > 1 Then '已经有会议评审记录
                    If CBool(.Rows(times - 2)("status")) Then
                        '上一条记录已提交过，就新增一条
                        Dim dr As DataRow = dsConTrial.Tables("conference_trial").NewRow
                        CopyValueToDatarow(dr, CInt(.Rows(times - 2)("trial_times")) + 1)
                        dsConTrial.Tables("conference_trial").Rows.Add(dr)
                    Else '否则修改
                        .Rows(times - 2)("apply_trial_date") = dtpDate.Value.Date
                        .Rows(times - 2)("manager_recommend_sum") = MyIIf(txtRecommendMoney.Text, GetType(Double), DBNull.Value)
                    End If
                Else '没有会议评审记录
                    Dim dr As DataRow = dsConTrial.Tables("conference_trial").NewRow
                    CopyValueToDatarow(dr, 1)
                    dsConTrial.Tables("conference_trial").Rows.Add(dr)
                End If
            End With

            result = gWs.UpdateConfTrial(dsConTrial.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存项目调研结论失败", result, "")
                Return
            End If
            cbxConclusion.Tag = cbxConclusion.Text
        End If

        Dim newDr As DataRow = dsOpinion.Tables("TProjectOpinion").NewRow
        With newDr
            .Item("project_code") = ProjectCode
            .Item("item_type") = tuneType
            .Item("item_code") = tuneCode
            .Item("content") = txtOpinion.Text
            .Item("conclusion") = cbxConclusion.Text
            .Item("create_person") = UserName
            .Item("create_date") = SystemDate
        End With
        dsOpinion.Tables("TProjectOpinion").Rows.Add(newDr)
        result = gWs.UpdateProjectOpinion(dsOpinion.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存项目调研结论失败", result, "")
            Return
        End If

        result = gWs.finishedTask(WorkFlowID, ProjectCode, getTaskID(), cbxConclusion.SelectedValue & "", UserName)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "提交失败", result, "")
        Else
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            MyBase.raiseCommitSucceed()
            Close()
        End If
    End Sub


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub


    Private Sub cbxConclusion_IndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        btnReport.Enabled = (cbxConclusion.Text.IndexOf("会") < 0)
        dtpDate.Enabled = Not btnReport.Enabled
        txtRecommendMoney.Enabled = dtpDate.Enabled
    End Sub

    Private Sub btnReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReport.Click
        '''''''生成哈希表'''''''''
        If htOpinion Is Nothing Then
            htOpinion = New Hashtable()
            htOpinion.Add("&#ProjectCode", ProjectCode)
            htOpinion.Add("&#Date", String.Format("{0,10:yyyy年M月d日}", SystemDate.Date))
            htOpinion.Add("&#Corporation", txtCorName.Text)
            htOpinion.Add("&#ApplySum", IIf(txtMoney.Text <> String.Empty, txtMoney.Text, "0") & "万元")
            htOpinion.Add("&#Term", txtTerm.Text)
            htOpinion.Add("&#Bank", txtBank.Text)
            htOpinion.Add("&#ManagerA", txtMA.Text)
            htOpinion.Add("&#ManagerB", txtMB.Text)
            htOpinion.Add("&#ConclusionA", "项目暂缓")
            htOpinion.Add("&#ConclusionB", "该项目暂缓")
            '''''''''''''''反担保措施'''''''''''''''
            Dim dsConTrial As DataSet = gWs.GetConfTrialInfo("{project_code LIKE '" & ProjectCode & "' AND status=1}", "null")
            Dim hasMeetingRecorded As Boolean = dsConTrial.Tables("conference_trial").Rows.Count > 0
            dsConTrial.Dispose()
            Dim strGuaranty As String = String.Empty
            Dim dsGuaForm As DataSet = gWs.GetProjectGuaranteeForm("{project_code LIKE '" & ProjectCode & "'}")
            Dim dr As DataRow
            For Each dr In dsGuaForm.Tables("TProjectGuaranteeForm").Rows
                If hasMeetingRecorded Then
                    If Not IsDBNull(dr("is_used")) AndAlso CBool(dr("is_used")) Then
                        strGuaranty += dr("description").ToString & Chr(13)
                    End If
                Else
                    strGuaranty += dr("description").ToString & Chr(13)
                End If
            Next
            htOpinion.Add("&#Guaranty", strGuaranty)
            '''''''''''''''反担保措施'''''''''''''''
        End If
        htOpinion.Item("&#Remark") = txtOpinion.Text
        htOpinion.Item("&#VouchOpinion") = ""
        '''''''生成哈希表'''''''''

        Dim key() As String
        Dim value As ArrayList = New ArrayList()
        Dim i As Integer = 0
        ReDim key(htOpinion.Count - 1)
        Dim ItemList As IDictionaryEnumerator = htOpinion.GetEnumerator
        While ItemList.MoveNext
            key(i) = ItemList.Key
            value.Add(ItemList.Value)
            i += 1
        End While
        Try
            Dim ofrmDocumentManageBusiness As frmDocumentManageBusiness
            ofrmDocumentManageBusiness = New frmDocumentManageBusiness(ProjectCode, TaskID, CorporationName, fileType, fileCode, UserName, key, value)
            ofrmDocumentManageBusiness.AllowTransparency = False
            ofrmDocumentManageBusiness.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub frmTuneUpOpinion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        MyBase.setEnterKeyPress(sender, e)
    End Sub

    Private Sub txtRecommendMoney_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtRecommendMoney.Enter
        Money.Money_Enter(sender, e)
    End Sub

    Private Sub txtRecommendMoney_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtRecommendMoney.KeyPress
        Money.Money_KeyPress(sender, e)
    End Sub

    Private Sub txtRecommendMoney_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtRecommendMoney.Leave
        Money.Money_Leave(sender, e)
        If txtRecommendMoney.Text <> "" Then
            If CDbl(txtRecommendMoney.Text) * 10000 > MaxMoney Then
                SWDialogBox.MessageBox.Show("$X047", (MaxMoney / 10000).ToString("n"))
                txtRecommendMoney.Text = ""
            End If
        End If
    End Sub

    Private Sub btnDetailInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetailInfo.Click
        Dim ofrmShowProjectInfo As frmShowProjectInfo = New frmShowProjectInfo(ProjectCode, CorporationName)
        ofrmShowProjectInfo.Show()
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click

    End Sub
End Class

