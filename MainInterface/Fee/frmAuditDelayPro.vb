

Public Class frmAuditDelayPro
    Inherits frmBasic
    Private ProjectCode As String
    Private CorporationName As String
    Private WorkFlowID As String
    Private TaskID As String

    Private dsOpinion As DataSet
    Private SystemDate As Date
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not htOpinion Is Nothing Then
            htOpinion = Nothing
        End If
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbxConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents btnDetailInfo As System.Windows.Forms.Button
    Friend WithEvents txtAuditOpinion As System.Windows.Forms.TextBox
    Friend WithEvents txtOpinion As System.Windows.Forms.TextBox
    Friend WithEvents txtApplyServiceType As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Protected WithEvents txtCorName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMoney As System.Windows.Forms.TextBox
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMA As System.Windows.Forms.TextBox
    Friend WithEvents txtMB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAuditDelayPro))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtOpinion = New System.Windows.Forms.TextBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtAuditOpinion = New System.Windows.Forms.TextBox()
        Me.cmbxConclusion = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDetailInfo = New System.Windows.Forms.Button()
        Me.txtApplyServiceType = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMoney = New System.Windows.Forms.TextBox()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBank = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMA = New System.Windows.Forms.TextBox()
        Me.txtMB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
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
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(525, 360)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtOpinion})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(606, 128)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "调研意见"
        '
        'txtOpinion
        '
        Me.txtOpinion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOpinion.Location = New System.Drawing.Point(3, 17)
        Me.txtOpinion.Multiline = True
        Me.txtOpinion.Name = "txtOpinion"
        Me.txtOpinion.ReadOnly = True
        Me.txtOpinion.Size = New System.Drawing.Size(600, 108)
        Me.txtOpinion.TabIndex = 12
        Me.txtOpinion.Text = ""
        '
        'btnReport
        '
        Me.btnReport.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Bitmap)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.ImageIndex = 18
        Me.btnReport.ImageList = Me.ImageListBasic
        Me.btnReport.Location = New System.Drawing.Point(353, 360)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(77, 23)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "报 告(&R)"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(439, 360)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 4
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtAuditOpinion})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 216)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(606, 136)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "审核意见"
        '
        'txtAuditOpinion
        '
        Me.txtAuditOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAuditOpinion.Location = New System.Drawing.Point(3, 17)
        Me.txtAuditOpinion.MaxLength = 250
        Me.txtAuditOpinion.Multiline = True
        Me.txtAuditOpinion.Name = "txtAuditOpinion"
        Me.txtAuditOpinion.Size = New System.Drawing.Size(600, 116)
        Me.txtAuditOpinion.TabIndex = 0
        Me.txtAuditOpinion.Text = ""
        '
        'cmbxConclusion
        '
        Me.cmbxConclusion.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.cmbxConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxConclusion.Location = New System.Drawing.Point(72, 360)
        Me.cmbxConclusion.Name = "cmbxConclusion"
        Me.cmbxConclusion.Size = New System.Drawing.Size(121, 20)
        Me.cmbxConclusion.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "审核结论"
        '
        'btnDetailInfo
        '
        Me.btnDetailInfo.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnDetailInfo.Image = CType(resources.GetObject("btnDetailInfo.Image"), System.Drawing.Bitmap)
        Me.btnDetailInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetailInfo.ImageIndex = 3
        Me.btnDetailInfo.ImageList = Me.ImageListBasic
        Me.btnDetailInfo.Location = New System.Drawing.Point(224, 360)
        Me.btnDetailInfo.Name = "btnDetailInfo"
        Me.btnDetailInfo.Size = New System.Drawing.Size(120, 23)
        Me.btnDetailInfo.TabIndex = 2
        Me.btnDetailInfo.Text = "项目详细信息(&L)"
        Me.btnDetailInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtApplyServiceType
        '
        Me.txtApplyServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyServiceType.Enabled = False
        Me.txtApplyServiceType.Location = New System.Drawing.Point(408, 32)
        Me.txtApplyServiceType.Name = "txtApplyServiceType"
        Me.txtApplyServiceType.ReadOnly = True
        Me.txtApplyServiceType.Size = New System.Drawing.Size(176, 21)
        Me.txtApplyServiceType.TabIndex = 35
        Me.txtApplyServiceType.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(328, 35)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 14)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "申请业务品种"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorName
        '
        Me.txtCorName.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Enabled = False
        Me.txtCorName.Location = New System.Drawing.Point(240, 8)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(344, 21)
        Me.txtCorName.TabIndex = 33
        Me.txtCorName.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 14)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "企 业 名 称"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 14)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "项 目 编 码"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Enabled = False
        Me.txtProjectCode.Location = New System.Drawing.Point(88, 8)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(72, 21)
        Me.txtProjectCode.TabIndex = 32
        Me.txtProjectCode.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(472, 59)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 14)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "万元"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMoney
        '
        Me.txtMoney.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMoney.Enabled = False
        Me.txtMoney.Location = New System.Drawing.Point(408, 56)
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.ReadOnly = True
        Me.txtMoney.Size = New System.Drawing.Size(64, 21)
        Me.txtMoney.TabIndex = 29
        Me.txtMoney.Text = ""
        Me.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTerm
        '
        Me.txtTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerm.Enabled = False
        Me.txtTerm.Location = New System.Drawing.Point(536, 56)
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
        Me.Label8.Location = New System.Drawing.Point(568, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 14)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "月"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBank
        '
        Me.txtBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBank.Enabled = False
        Me.txtBank.Location = New System.Drawing.Point(88, 56)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.ReadOnly = True
        Me.txtBank.Size = New System.Drawing.Size(232, 21)
        Me.txtBank.TabIndex = 26
        Me.txtBank.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(504, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 14)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "期限"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 14)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "申请贷款银行"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMA
        '
        Me.txtMA.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMA.Enabled = False
        Me.txtMA.Location = New System.Drawing.Point(88, 32)
        Me.txtMA.Name = "txtMA"
        Me.txtMA.ReadOnly = True
        Me.txtMA.Size = New System.Drawing.Size(72, 21)
        Me.txtMA.TabIndex = 25
        Me.txtMA.Text = ""
        '
        'txtMB
        '
        Me.txtMB.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMB.Enabled = False
        Me.txtMB.Location = New System.Drawing.Point(240, 32)
        Me.txtMB.Name = "txtMB"
        Me.txtMB.ReadOnly = True
        Me.txtMB.Size = New System.Drawing.Size(80, 21)
        Me.txtMB.TabIndex = 27
        Me.txtMB.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(168, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "项目经理B角"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "项目经理A角"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(328, 59)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 14)
        Me.Label12.TabIndex = 9
        Me.Label12.Text = "申请贷款金额"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmAuditDelayPro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(626, 391)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnDetailInfo, Me.GroupBox2, Me.btnCommit, Me.btnReport, Me.btnExit, Me.GroupBox1, Me.cmbxConclusion, Me.Label1, Me.txtBank, Me.Label3, Me.txtProjectCode, Me.txtCorName, Me.Label2, Me.Label11, Me.txtApplyServiceType, Me.Label7, Me.Label5, Me.Label8, Me.txtMoney, Me.Label4, Me.txtTerm, Me.txtMB, Me.Label6, Me.txtMA, Me.Label10, Me.Label12})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAuditDelayPro"
        Me.Text = "审核暂缓项目"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private AuditItemType As String = "52"
    Private AuditItemCode As String = "003"
    Private htOpinion As Hashtable
    Private dsProject As DataSet
    Private strGuaranty As String = String.Empty
    Private fileType As String = "45"
    Private fileCode As String = "005"
    Private GuarantyFeeStandard As Double = 0.018
    Private ReviewFeeStandard As Double = 0.0012
    Private Sub form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            ProjectCode = MyBase.getProjectCode
            CorporationName = MyBase.getCorporationName
            WorkFlowID = MyBase.getWorkFlowID
            TaskID = MyBase.getTaskID
            txtCorName.Text = CorporationName : txtProjectCode.Text = ProjectCode

            SystemDate = gWs.GetSysTime
            dsOpinion = gWs.GetProjectOpinionByProjectNo(ProjectCode)
            Dim drs As DataRow() = dsOpinion.Tables("TProjectOpinion").Select("item_type='52' and item_code='002'", "serial_num DESC")
            If drs.Length > 0 Then
                txtOpinion.Text = drs(0)("content").ToString
            End If

            Dim dsConclusion As DataSet = New DataSet() '绑定评审会议意见
            dsConclusion = gWs.GetTransCondition(WorkFlowID, ProjectCode, TaskID)
            cmbxConclusion.DataSource = dsConclusion.Tables(0)
            cmbxConclusion.DisplayMember = "transfer_condition"
            cmbxConclusion.ValueMember = "transfer_condition"
            '返回项目基本信息
            'Dim dsMB As DataSet = gWs.GetCommonQueryInfo("SELECT attend_person FROM project_task_attendee WHERE (project_code LIKE '" & ProjectCode & "') AND (role_id = '25')")
            dsProject = New DataSet()
            dsProject = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
            txtMA.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.manager_A"))
            txtMB.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.manager_B"))
            txtMoney.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.ApplySum"))
            txtBank.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.ApplyBank"))
            txtTerm.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.ApplyTerm"))
            txtApplyServiceType.DataBindings.Add("Text", dsProject, "ViewProject.ApplyServiceType")
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub CopyValueToDatarow(ByVal dr As DataRow, ByVal times As Integer)
        dr("project_code") = ProjectCode
        dr("trial_times") = times
        dr("apply_trial_date") = SystemDate.Date
        dr("status") = False
        dr("service_type") = DBNull.Value 'txtApplyServiceType.Text
        dr("guarantee_sum") = DBNull.Value 'MyIIf(txtMoney.Text, GetType(Double), DBNull.Value)
        dr("terms") = DBNull.Value 'MyIIf(txtTerm.Text, GetType(Integer), 12)
        'dr("guarantee_rate") = GuarantyFeeStandard * 100
        'dr("trial_rate") = ReviewFeeStandard * 100
        dr("create_person") = UserName
        dr("create_date") = SystemDate.Date
    End Sub

    Private Sub btnCommit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交") 'MessageBox.Show("确定提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If
        Dim result As String

        If cmbxConclusion.Tag Is Nothing AndAlso cmbxConclusion.Text.IndexOf("会") >= 0 Then
            '插入一条新纪录到会议评审表  conference_trial
            Dim dsConTrial As DataSet = gWs.GetConfTrialInfo("{project_code LIKE '" & ProjectCode & "'}", "null")
            Dim times As Integer = dsConTrial.Tables("conference_trial").Rows.Count + 1
            With dsConTrial.Tables("conference_trial")
                If times > 1 Then '已经有会议评审记录
                    If CBool(.Rows(times - 2)("status")) Then
                        '上一条记录已提交过，就新增一条
                        Dim dr As DataRow = dsConTrial.Tables("conference_trial").NewRow
                        CopyValueToDatarow(dr, times)
                        dsConTrial.Tables("conference_trial").Rows.Add(dr)
                    Else '否则修改
                        .Rows(times - 2)("apply_trial_date") = SystemDate.Date
                    End If
                Else '没有会议评审记录
                    Dim dr As DataRow = dsConTrial.Tables("conference_trial").NewRow
                    CopyValueToDatarow(dr, times)
                    dsConTrial.Tables("conference_trial").Rows.Add(dr)
                End If
            End With

            result = gWs.UpdateConfTrial(dsConTrial.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存审核意见失败", result, "")
                Return
            End If
            cmbxConclusion.Tag = cmbxConclusion.Text
        End If
        Dim rows() As DataRow = dsOpinion.Tables("TProjectOpinion").Select("item_type='" & AuditItemType & "' and item_code='" & AuditItemCode & "'")
        If rows.Length = 0 Then
            Dim newDr As DataRow = dsOpinion.Tables("TProjectOpinion").NewRow
            With newDr
                .Item("project_code") = ProjectCode
                .Item("item_type") = AuditItemType
                .Item("item_code") = AuditItemCode
                .Item("content") = txtAuditOpinion.Text
                .Item("conclusion") = cmbxConclusion.Text
                .Item("create_person") = UserName
                .Item("create_date") = SystemDate
            End With
            dsOpinion.Tables("TProjectOpinion").Rows.Add(newDr)
        Else
            rows(0).Item("content") = txtAuditOpinion.Text
            rows(0).Item("conclusion") = cmbxConclusion.Text
        End If

        result = gWs.UpdateProjectOpinion(dsOpinion.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存审核意见失败", result, "")
            Return
        End If

        result = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, cmbxConclusion.SelectedValue & "", UserName)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "提交失败", result, "")
        Else
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            MyBase.raiseCommitSucceed()
            Close()
        End If
    End Sub

    Private Sub btnReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReport.Click
        '''''''生成哈希表'''''''''
        If htOpinion Is Nothing Then
            htOpinion = New Hashtable()
            htOpinion.Add("&#ProjectCode", ProjectCode)
            htOpinion.Add("&#Date", SystemDate.Date.ToString("yyyy/M/d"))
            htOpinion.Add("&#Corporation", txtCorName.Text)
            htOpinion.Add("&#ApplySum", IIf(txtMoney.Text <> String.Empty, txtMoney.Text, "0") & "万元")
            htOpinion.Add("&#Term", txtTerm.Text)
            htOpinion.Add("&#Bank", txtBank.Text)
            htOpinion.Add("&#ManagerA", txtMA.Text)
            htOpinion.Add("&#ManagerB", txtMB.Text)
            htOpinion.Add("&#ConclusionA", "项目暂缓")
            htOpinion.Add("&#ConclusionB", "该项目暂缓")
            htOpinion.Add("&#Remark", txtOpinion.Text)
            '''''''''''''''反担保措施'''''''''''''''
            Dim strGuaranty As String = String.Empty
            Dim dsGuaForm As DataSet = gWs.GetProjectGuaranteeForm("{project_code LIKE '" & ProjectCode & "'}")
            Dim dr As DataRow
            For Each dr In dsGuaForm.Tables("TProjectGuaranteeForm").Rows
                strGuaranty += dr("description").ToString & Chr(13)
            Next
            htOpinion.Add("&#Guaranty", strGuaranty)
            '''''''''''''''反担保措施'''''''''''''''
        End If

        htOpinion.Item("&#VouchOpinion") = txtAuditOpinion.Text
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
            ofrmDocumentManageBusiness.setIsButtonEnable(True)
            ofrmDocumentManageBusiness.Show()
            'ofrmDocumentManageBusiness.btnMakeDoc_Click(sender, e)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmAuditDelayPro_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        MyBase.setEnterKeyPress(sender, e)
    End Sub

    Private Sub btnDetailInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetailInfo.Click
        Dim ofrmShowProjectInfo As frmShowProjectInfo = New frmShowProjectInfo(ProjectCode, CorporationName)
        ofrmShowProjectInfo.ShowDialog()
    End Sub
End Class
