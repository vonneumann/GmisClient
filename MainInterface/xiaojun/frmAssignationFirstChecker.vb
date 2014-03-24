
'分配项目初审人员
Public Class frmAssignationFirstChecker
    Inherits MainInterface.frmBusinessBaseWin

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
    Public WithEvents btnSearch As System.Windows.Forms.Button
    Public WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtApplyGuaranteeTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtApplyGuaranteeSum As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIndustryType As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEnterpriseType As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents cmbAssignInfo As System.Windows.Forms.ComboBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents cmbAssignPerson As System.Windows.Forms.ComboBox
    Friend WithEvents dtpConsultateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtConsultatePerson As System.Windows.Forms.TextBox
    Friend WithEvents txtRecommandPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRecommandType As System.Windows.Forms.TextBox
    Friend WithEvents label111 As System.Windows.Forms.Label
    Friend WithEvents txtFeeReview As System.Windows.Forms.TextBox
    Friend WithEvents lblFeeValue As System.Windows.Forms.Label
    Friend WithEvents cboEvalFee As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAssignationFirstChecker))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRecommandPerson = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRecommandType = New System.Windows.Forms.TextBox()
        Me.label111 = New System.Windows.Forms.Label()
        Me.dtpConsultateDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConsultatePerson = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIndustryType = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEnterpriseType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApplyGuaranteeTerm = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtApplyGuaranteeSum = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbAssignInfo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbAssignPerson = New System.Windows.Forms.ComboBox()
        Me.txtFeeReview = New System.Windows.Forms.TextBox()
        Me.lblFeeValue = New System.Windows.Forms.Label()
        Me.cboEvalFee = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Location = New System.Drawing.Point(232, 8)
        Me.txtEnterpriseName.Size = New System.Drawing.Size(264, 21)
        Me.txtEnterpriseName.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 10)
        Me.Label1.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(72, 8)
        Me.txtProjectCode.Visible = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(176, 10)
        Me.Label2.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(301, 216)
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.Visible = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Bitmap)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.ImageIndex = 27
        Me.btnSearch.ImageList = Me.ImageListBasic
        Me.btnSearch.Location = New System.Drawing.Point(125, 216)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 23)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "查 询(&S)"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(213, 216)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 8
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtRecommandPerson, Me.Label9, Me.txtRecommandType, Me.label111, Me.dtpConsultateDate, Me.Label3, Me.txtConsultatePerson, Me.Label6, Me.txtIndustryType, Me.Label5, Me.txtEnterpriseType, Me.Label4, Me.txtApplyGuaranteeTerm, Me.Label11, Me.txtApplyGuaranteeSum, Me.Label10})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(488, 128)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "项目基本信息"
        '
        'txtRecommandPerson
        '
        Me.txtRecommandPerson.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRecommandPerson.Location = New System.Drawing.Point(328, 70)
        Me.txtRecommandPerson.Name = "txtRecommandPerson"
        Me.txtRecommandPerson.ReadOnly = True
        Me.txtRecommandPerson.Size = New System.Drawing.Size(144, 21)
        Me.txtRecommandPerson.TabIndex = 46
        Me.txtRecommandPerson.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(240, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "推荐人员"
        '
        'txtRecommandType
        '
        Me.txtRecommandType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRecommandType.Location = New System.Drawing.Point(80, 70)
        Me.txtRecommandType.Name = "txtRecommandType"
        Me.txtRecommandType.ReadOnly = True
        Me.txtRecommandType.Size = New System.Drawing.Size(152, 21)
        Me.txtRecommandType.TabIndex = 44
        Me.txtRecommandType.Text = ""
        '
        'label111
        '
        Me.label111.Location = New System.Drawing.Point(8, 72)
        Me.label111.Name = "label111"
        Me.label111.Size = New System.Drawing.Size(56, 16)
        Me.label111.TabIndex = 43
        Me.label111.Text = "推荐类型"
        '
        'dtpConsultateDate
        '
        Me.dtpConsultateDate.Enabled = False
        Me.dtpConsultateDate.Location = New System.Drawing.Point(328, 94)
        Me.dtpConsultateDate.Name = "dtpConsultateDate"
        Me.dtpConsultateDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpConsultateDate.TabIndex = 42
        Me.dtpConsultateDate.Value = New Date(2003, 7, 24, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(240, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "咨询日期"
        '
        'txtConsultatePerson
        '
        Me.txtConsultatePerson.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConsultatePerson.Location = New System.Drawing.Point(80, 94)
        Me.txtConsultatePerson.Name = "txtConsultatePerson"
        Me.txtConsultatePerson.ReadOnly = True
        Me.txtConsultatePerson.Size = New System.Drawing.Size(152, 21)
        Me.txtConsultatePerson.TabIndex = 40
        Me.txtConsultatePerson.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "咨询人员"
        '
        'txtIndustryType
        '
        Me.txtIndustryType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtIndustryType.Location = New System.Drawing.Point(80, 46)
        Me.txtIndustryType.Name = "txtIndustryType"
        Me.txtIndustryType.ReadOnly = True
        Me.txtIndustryType.Size = New System.Drawing.Size(152, 21)
        Me.txtIndustryType.TabIndex = 38
        Me.txtIndustryType.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "行业类型"
        '
        'txtEnterpriseType
        '
        Me.txtEnterpriseType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEnterpriseType.Location = New System.Drawing.Point(80, 22)
        Me.txtEnterpriseType.Name = "txtEnterpriseType"
        Me.txtEnterpriseType.ReadOnly = True
        Me.txtEnterpriseType.Size = New System.Drawing.Size(152, 21)
        Me.txtEnterpriseType.TabIndex = 36
        Me.txtEnterpriseType.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "企业类型"
        '
        'txtApplyGuaranteeTerm
        '
        Me.txtApplyGuaranteeTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyGuaranteeTerm.Location = New System.Drawing.Point(328, 46)
        Me.txtApplyGuaranteeTerm.Name = "txtApplyGuaranteeTerm"
        Me.txtApplyGuaranteeTerm.ReadOnly = True
        Me.txtApplyGuaranteeTerm.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyGuaranteeTerm.TabIndex = 32
        Me.txtApplyGuaranteeTerm.Text = ""
        Me.txtApplyGuaranteeTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(240, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "申请期限(月)"
        '
        'txtApplyGuaranteeSum
        '
        Me.txtApplyGuaranteeSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyGuaranteeSum.Location = New System.Drawing.Point(328, 22)
        Me.txtApplyGuaranteeSum.Name = "txtApplyGuaranteeSum"
        Me.txtApplyGuaranteeSum.ReadOnly = True
        Me.txtApplyGuaranteeSum.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyGuaranteeSum.TabIndex = 30
        Me.txtApplyGuaranteeSum.Text = ""
        Me.txtApplyGuaranteeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(240, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "申请金额(万元)"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(248, 168)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "分配人员"
        '
        'cmbAssignInfo
        '
        Me.cmbAssignInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAssignInfo.Location = New System.Drawing.Point(88, 166)
        Me.cmbAssignInfo.Name = "cmbAssignInfo"
        Me.cmbAssignInfo.Size = New System.Drawing.Size(152, 20)
        Me.cmbAssignInfo.TabIndex = 12
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 168)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "分配信息"
        '
        'cmbAssignPerson
        '
        Me.cmbAssignPerson.Location = New System.Drawing.Point(336, 166)
        Me.cmbAssignPerson.Name = "cmbAssignPerson"
        Me.cmbAssignPerson.Size = New System.Drawing.Size(144, 20)
        Me.cmbAssignPerson.TabIndex = 14
        '
        'txtFeeReview
        '
        Me.txtFeeReview.BackColor = System.Drawing.SystemColors.Window
        Me.txtFeeReview.Location = New System.Drawing.Point(336, 190)
        Me.txtFeeReview.MaxLength = 8
        Me.txtFeeReview.Name = "txtFeeReview"
        Me.txtFeeReview.ReadOnly = True
        Me.txtFeeReview.Size = New System.Drawing.Size(144, 21)
        Me.txtFeeReview.TabIndex = 19
        Me.txtFeeReview.Text = "0"
        Me.txtFeeReview.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFeeValue
        '
        Me.lblFeeValue.Location = New System.Drawing.Point(248, 192)
        Me.lblFeeValue.Name = "lblFeeValue"
        Me.lblFeeValue.Size = New System.Drawing.Size(80, 16)
        Me.lblFeeValue.TabIndex = 17
        Me.lblFeeValue.Text = "收取金额(元)"
        '
        'cboEvalFee
        '
        Me.cboEvalFee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboEvalFee.Items.AddRange(New Object() {"免收", "预收", "不预收"})
        Me.cboEvalFee.Location = New System.Drawing.Point(88, 190)
        Me.cboEvalFee.Name = "cboEvalFee"
        Me.cboEvalFee.Size = New System.Drawing.Size(152, 20)
        Me.cboEvalFee.TabIndex = 33
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(16, 192)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "评审费收取"
        '
        'frmAssignationFirstChecker
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(506, 247)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.Label13, Me.cboEvalFee, Me.lblFeeValue, Me.Label8, Me.Label7, Me.txtFeeReview, Me.cmbAssignPerson, Me.cmbAssignInfo, Me.GroupBox1, Me.btnSearch, Me.btnCommit})
        Me.MinimizeBox = False
        Me.Name = "frmAssignationFirstChecker"
        Me.Text = "项目初审分配"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private bIsFormLoad As Boolean = False
    Private bIsTextChanaged As Boolean = False
    Private ds As New DataSet()
    Private RoleID As String = "13"
    Private intAssignType As Integer
    Private CorporationCode As String
    Private UpdateResult As String

    Private Sub frmAssignationBasic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Call Me.ShowIniData(Me.strProjectCode, Me.strEnterpriseName)
            Call Me.IniAssignInfo()
            Call Me.IniAssignPersonInfo()
            Me.bIsFormLoad = True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ShowIniData(ByVal ProjectCode As String, ByVal EnterpriseName As String)
        ds = gWs.GetcorporationInfo("{corporation_name='" & EnterpriseName & "'}", "null")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With Me.ds.Tables(0).Rows(0)
                If Not .Item("industry_type") Is System.DBNull.Value Then
                    Me.txtIndustryType.Text = .Item("industry_type")
                End If
                If Not .Item("proprietorship_type") Is System.DBNull.Value Then
                    Me.txtEnterpriseType.Text = .Item("proprietorship_type")
                End If
            End With
        End If
        ds = gWs.GetProjectInfo("{project_code='" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                If Not .Item("corporation_code") Is System.DBNull.Value Then
                    Me.CorporationCode = .Item("corporation_code")
                End If
                '加入推荐人，推荐类型。
                If Not .Item("recommend_type") Is System.DBNull.Value Then
                    Me.txtRecommandType.Text = .Item("recommend_type")
                End If
                If Not .Item("recommend_person") Is System.DBNull.Value Then
                    Me.txtRecommandPerson.Text = .Item("recommend_person")
                End If
                Me.strAcceptPerson = IIf(IsDBNull(.Item("create_person")), "", .Item("create_person"))
            End With
        End If

        ds = gWs.GetProjectInfoEx("{projectcode like '" & Me.strProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtApplyGuaranteeSum.Text = IIf(.Item("applysum") Is System.DBNull.Value, "", .Item("applysum"))
                Me.txtApplyGuaranteeTerm.Text = IIf(.Item("applyterm") Is System.DBNull.Value, "", .Item("applyterm"))
            End With
        End If

        ds = gWs.GetcorporationInfo("null", "{corporation_name='" & EnterpriseName & "' order by consult_date desc}")
        If Not ds.Tables(1).Rows.Count = 0 Then
            With ds.Tables(1).Rows(0)
                Me.txtConsultatePerson.Text = IIf(.Item("consult_person") Is System.DBNull.Value, "", .Item("consult_person"))
                Me.dtpConsultateDate.Text = IIf(.Item("consult_date") Is System.DBNull.Value, "", .Item("consult_date"))
            End With
        End If

        ds = gWs.GetProjectAccountDetailInfo("{project_code='" & Me.getProjectCode() & "' and item_type='31' and item_code='001'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.cboEvalFee.Enabled = True
                Me.cboEvalFee.SelectedItem = "预收评审费"
                If Not IsDBNull(.Item("payout")) Then
                    Me.txtFeeReview.Text = CGModule.Numeric2Currency(.Item("payout"))
                End If
            End With
        End If
        AddHandler txtFeeReview.Enter, AddressOf Money.Money_Enter
        AddHandler txtFeeReview.KeyPress, AddressOf Money.Money_KeyPress
        AddHandler txtFeeReview.Leave, AddressOf Money.Money_Leave
    End Sub

    Private Sub IniAssignInfo()
        ds = gWs.GetTransCondition(Me.strWorkFlowID, Me.strProjectCode, Me.strTaskID)
        If Not ds.Tables(0).Rows.Count = 0 Then
            Me.cmbAssignInfo.DataSource = ds.Tables(0).DefaultView
            Me.cmbAssignInfo.DisplayMember = "transfer_condition"
            Me.cmbAssignInfo.SelectedIndex = 0
        End If

        Me.cmbAssignInfo_SelectedIndexChanged(Nothing, Nothing)
        Me.cboEvalFee_SelectedIndexChanged(Nothing, Nothing)
    End Sub

    Private strAcceptPerson As String '用以保存受理人员，当分部负责人代理资评部长时，初审任务仍然应该分配给中心资评部的初审分配人员
    Private Sub IniAssignPersonInfo()
        Dim dtTemp As DataTable
        Dim arylist As ArrayList
        arylist = MdlGlobal.GetPersnList(MdlGlobal.GetConsigner(Me.getProjectCode(), Me.getTaskID()), RoleID) '取得初审人员
        For i = 0 To arylist.Count - 1
            Me.cmbAssignPerson.Items.Add(arylist(i))
        Next
        'get the default peson
        dtTemp = gWs.GetDefaultPerson(Me.getProjectCode(), RoleID).Tables(0)
        If Not dtTemp.Rows.Count = 0 Then
            Me.cmbAssignPerson.SelectedItem = dtTemp.Rows(0).Item("Person")
        End If
    End Sub

    Private Sub cmbAssignInfo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAssignInfo.TextChanged
        If Me.bIsFormLoad Then Me.bIsTextChanaged = True
    End Sub

    Private Sub cmbAssignInfo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAssignInfo.SelectedIndexChanged
        Dim strAssignType As String
        strAssignType = Me.cmbAssignInfo.Text.Trim()
        If strAssignType = "快速通道" Then  '如果走快速通道则可以设置是否预收评审费
            Me.cboEvalFee.SelectedIndex = 0
            Me.cboEvalFee.Enabled = True
            If Not Me.cboEvalFee.Text.IndexOf("预收") = -1 Then
                Me.lblFeeValue.Visible = True
                Me.txtFeeReview.Visible = True
            Else
                Me.lblFeeValue.Visible = False
                Me.txtFeeReview.Visible = False
            End If
        Else
            Me.cboEvalFee.SelectedIndex = -1
            Me.cboEvalFee.Enabled = False
            Me.lblFeeValue.Visible = False
            Me.txtFeeReview.Visible = False
            Me.txtFeeReview.Text = "0"
        End If
        If strAssignType = "快速通道" Or strAssignType = "再次申请" Then
            Me.intAssignType = 1
            Me.cmbAssignPerson.Enabled = False
        Else
            Me.intAssignType = 2
            Me.cmbAssignPerson.Enabled = True
        End If
        If Me.bIsFormLoad Then Me.bIsTextChanaged = True

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If SWDialogBox.MessageBox.Show("?1000", "确认提交") = DialogResult.Yes Then
                If Me.SaveData() = 0 Then Return
                Dim finishedFlag As String
                finishedFlag = IIf(Me.cmbAssignInfo.Text = "快速通道", Me.cboEvalFee.Text, Me.cmbAssignInfo.Text)
                Dim strResult As String = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), finishedFlag, Me.strUserID)
                If strResult = "1" Then
                    SWDialogBox.MessageBox.Show("$SubmitSucceed")
                    Me.raiseCommitSucceed()
                Else
                    SWDialogBox.MessageBox.Show("*999", "提交失败：" + strResult, "", "")
                End If
                Me.Close()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function SaveData() As Integer
        If Me.cmbAssignInfo.Text.Trim() = "" Then
            'MessageBox.Show("请选择相应的分配方式进行操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1007", "分配方式")
            Return 0
        End If
        Dim strAssignType As String
        strAssignType = Me.cmbAssignInfo.Text.Trim()
        'added begin         by hute 2004-02-26
        If strAssignType = "快速通道" AndAlso Me.cboEvalFee.Text = "预收" Then
            ds = gWs.GetProjectAccountDetailInfo("{project_code='" & Me.getProjectCode() & "' and item_type='31' and item_code='001'}")
            If Not ds.Tables(0).Rows.Count = 0 Then
                With ds.Tables(0).Rows(0)
                    .Item("project_code") = Me.getProjectCode()
                    .Item("date") = gWs.GetSysTime()
                    Try
                        .Item("payout") = Currency2Numeric(Me.txtFeeReview.Text)
                    Catch
                        .Item("payout") = 0
                    End Try
                    .Item("create_person") = UserName
                    .Item("create_date") = gWs.GetSysTime()
                End With
            Else
                Dim dr As DataRow = ds.Tables(0).NewRow
                With dr
                    .Item("project_code") = Me.getProjectCode()
                    .Item("item_type") = "31"
                    .Item("item_code") = "001"
                    .Item("date") = gWs.GetSysTime()
                    .Item("phase") = "初审"
                    Try
                        .Item("payout") = Currency2Numeric(Me.txtFeeReview.Text)
                    Catch
                        .Item("payout") = 0
                    End Try
                    .Item("create_person") = UserName
                    .Item("create_date") = gWs.GetSysTime()
                End With
                ds.Tables(0).Rows.Add(dr)
            End If
            Dim strResult = gWs.UpdateProjectAccountDetail(ds)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "预收评审费失败", strResult, "")
                Return 0
            End If
        End If

        If strAssignType = "快速通道" Or strAssignType = "再次申请" Then
            Me.intAssignType = 1
        Else
            Me.intAssignType = 2
        End If
        If Me.intAssignType = 2 And cmbAssignPerson.Text.Trim() = "" Then
            'MessageBox.Show("请选择相应的分配人员进行操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1007", "分配人员")
            Return 0
        End If

        ds = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.strProjectCode & "' and item_type='51' and item_code='005'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                .Item("project_code") = Me.strProjectCode
                .Item("item_type") = "51"
                .Item("item_code") = "005"
                .Item("conclusion") = Me.cmbAssignInfo.Text.Trim()
                .Item("create_person") = Me.strUserID
                .Item("create_date") = gWs.GetSysTime()
            End With
        Else
            ds = gWs.GetProjectOpinionByProjectNo("null")
            Dim NewRow As DataRow = ds.Tables(0).NewRow()
            With NewRow
                .Item("project_code") = Me.strProjectCode
                .Item("item_type") = "51"
                .Item("item_code") = "005"
                .Item("conclusion") = Me.cmbAssignInfo.Text.Trim()
                .Item("create_person") = Me.strUserID
                .Item("create_date") = gWs.GetSysTime()
            End With
            ds.Tables(0).Rows.Add(NewRow)
        End If
        Me.UpdateResult = gWs.UpdateProjectOpinion(ds)
        If Me.UpdateResult <> "1" Then
            'MessageBox.Show("初审类型分配失败：" + Me.UpdateResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("*999", "初审类型分配失败", Me.UpdateResult, "")
            Return 0
        End If

        '如果用户选择了分配类型“初审分配”执行。
        ds = gWs.GetProjectTaskAttendeeInfo("{project_code='" & Me.strProjectCode & "' and role_id='" & Me.RoleID & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                If Me.intAssignType = 2 Then
                    ds.Tables(0).Rows(i).Item("attend_person") = Workflow.GetRealTaskAttendee(Me.RoleID, Me.cmbAssignPerson.Text)
                Else
                    ds.Tables(0).Rows(i).Item("attend_person") = ""
                End If
            Next
        End If
        '若数据集ds发生了更改，则保存该更改。
        Me.UpdateResult = gWs.UpdateProjectTaskAttendee(ds)
        If Me.UpdateResult = "1" Then
            Me.bIsTextChanaged = False : Me.bIsFormLoad = False : Return 1
        Else
            'michael
            ' MessageBox.Show("记录更新失败：" + Me.UpdateResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("*999", "记录更新失败", Me.UpdateResult, "")
            Return 0
        End If
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim frm As New frmQueryCurrentTask(Me.RoleID)
            frm.AllowTransparency = False
            frm.ProjectCode = Me.getProjectCode()
            frm.TaskID = Me.getTaskID()
            frm.ShowDialog()
        Catch ex As Exception
            'michael
            'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    '根据是否预收评审费的ComboBox状态设置控件状态
    Private Sub cboEvalFee_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEvalFee.SelectedIndexChanged
        If Me.cboEvalFee.Text = "预收" Then
            Me.txtFeeReview.ReadOnly = False
            Me.lblFeeValue.Visible = True
            Me.txtFeeReview.Visible = True
        Else
            Me.txtFeeReview.ReadOnly = True
            Me.lblFeeValue.Visible = False
            Me.txtFeeReview.Visible = False
        End If
    End Sub

End Class
