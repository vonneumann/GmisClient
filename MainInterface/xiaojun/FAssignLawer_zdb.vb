
'分配法务经理　－－再担保
Public Class FAssignLawer_zdb
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
    Public WithEvents lblCorporationName As System.Windows.Forms.Label
    Public WithEvents lblProjectCode As System.Windows.Forms.Label
    Protected WithEvents grpBaseInfo As System.Windows.Forms.GroupBox
    Protected WithEvents lblApplyServiceType As System.Windows.Forms.Label
    Public WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents btnSearch As System.Windows.Forms.Button
    Public WithEvents btnCommit As System.Windows.Forms.Button
    Protected WithEvents lblOrganizationName As System.Windows.Forms.Label
    Protected WithEvents lblBranchBankName As System.Windows.Forms.Label
    Protected WithEvents txtRefundType As System.Windows.Forms.TextBox
    Protected WithEvents lblRefundType As System.Windows.Forms.Label
    Protected WithEvents txtReguaranteeTerm As System.Windows.Forms.TextBox
    Protected WithEvents lblReguaranteeTerm As System.Windows.Forms.Label
    Protected WithEvents lblBankName As System.Windows.Forms.Label
    Protected WithEvents txtOrganizationName As System.Windows.Forms.TextBox
    Protected WithEvents txtReguaranteeCondition As System.Windows.Forms.TextBox
    Protected WithEvents lblReguaranteeCondition As System.Windows.Forms.Label
    Protected WithEvents txtRefund_sum_average As System.Windows.Forms.TextBox
    Protected WithEvents lblRefund_sum_average As System.Windows.Forms.Label
    Protected WithEvents txtBankName As System.Windows.Forms.TextBox
    Protected WithEvents txtBranchBankName As System.Windows.Forms.TextBox
    Public WithEvents cboLawer As System.Windows.Forms.ComboBox
    Friend WithEvents btnConclusion As System.Windows.Forms.Button
    Protected WithEvents txtServiceType As System.Windows.Forms.TextBox
    Protected WithEvents txtGuaranteeSum As System.Windows.Forms.TextBox
    Protected WithEvents lblGuaranteeSum As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FAssignLawer_zdb))
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.lblProjectCode = New System.Windows.Forms.Label()
        Me.grpBaseInfo = New System.Windows.Forms.GroupBox()
        Me.txtBranchBankName = New System.Windows.Forms.TextBox()
        Me.txtBankName = New System.Windows.Forms.TextBox()
        Me.txtRefund_sum_average = New System.Windows.Forms.TextBox()
        Me.lblRefund_sum_average = New System.Windows.Forms.Label()
        Me.lblBranchBankName = New System.Windows.Forms.Label()
        Me.txtRefundType = New System.Windows.Forms.TextBox()
        Me.lblRefundType = New System.Windows.Forms.Label()
        Me.txtReguaranteeTerm = New System.Windows.Forms.TextBox()
        Me.lblReguaranteeTerm = New System.Windows.Forms.Label()
        Me.txtGuaranteeSum = New System.Windows.Forms.TextBox()
        Me.lblGuaranteeSum = New System.Windows.Forms.Label()
        Me.lblBankName = New System.Windows.Forms.Label()
        Me.txtServiceType = New System.Windows.Forms.TextBox()
        Me.lblApplyServiceType = New System.Windows.Forms.Label()
        Me.txtOrganizationName = New System.Windows.Forms.TextBox()
        Me.lblOrganizationName = New System.Windows.Forms.Label()
        Me.txtReguaranteeCondition = New System.Windows.Forms.TextBox()
        Me.lblReguaranteeCondition = New System.Windows.Forms.Label()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboLawer = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnConclusion = New System.Windows.Forms.Button()
        Me.grpBaseInfo.SuspendLayout()
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
        Me.btnExit.Location = New System.Drawing.Point(368, 272)
        Me.btnExit.Visible = True
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Location = New System.Drawing.Point(192, 8)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(54, 16)
        Me.lblCorporationName.TabIndex = 13
        Me.lblCorporationName.Text = "企业名称"
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Location = New System.Drawing.Point(16, 8)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(54, 16)
        Me.lblProjectCode.TabIndex = 12
        Me.lblProjectCode.Text = "项目编码"
        '
        'grpBaseInfo
        '
        Me.grpBaseInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtBranchBankName, Me.txtBankName, Me.txtRefund_sum_average, Me.lblRefund_sum_average, Me.lblBranchBankName, Me.txtRefundType, Me.lblRefundType, Me.txtReguaranteeTerm, Me.lblReguaranteeTerm, Me.txtGuaranteeSum, Me.lblGuaranteeSum, Me.lblBankName, Me.txtServiceType, Me.lblApplyServiceType, Me.txtOrganizationName, Me.lblOrganizationName, Me.txtReguaranteeCondition, Me.lblReguaranteeCondition})
        Me.grpBaseInfo.Location = New System.Drawing.Point(8, 32)
        Me.grpBaseInfo.Name = "grpBaseInfo"
        Me.grpBaseInfo.Size = New System.Drawing.Size(520, 208)
        Me.grpBaseInfo.TabIndex = 16
        Me.grpBaseInfo.TabStop = False
        Me.grpBaseInfo.Text = "项目基本信息"
        '
        'txtBranchBankName
        '
        Me.txtBranchBankName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBranchBankName.Location = New System.Drawing.Point(360, 70)
        Me.txtBranchBankName.Name = "txtBranchBankName"
        Me.txtBranchBankName.ReadOnly = True
        Me.txtBranchBankName.Size = New System.Drawing.Size(144, 21)
        Me.txtBranchBankName.TabIndex = 37
        Me.txtBranchBankName.TabStop = False
        Me.txtBranchBankName.Text = ""
        Me.txtBranchBankName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtBankName
        '
        Me.txtBankName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBankName.Location = New System.Drawing.Point(112, 70)
        Me.txtBankName.Name = "txtBankName"
        Me.txtBankName.ReadOnly = True
        Me.txtBankName.Size = New System.Drawing.Size(152, 21)
        Me.txtBankName.TabIndex = 36
        Me.txtBankName.TabStop = False
        Me.txtBankName.Text = ""
        Me.txtBankName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRefund_sum_average
        '
        Me.txtRefund_sum_average.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRefund_sum_average.Location = New System.Drawing.Point(360, 94)
        Me.txtRefund_sum_average.Name = "txtRefund_sum_average"
        Me.txtRefund_sum_average.ReadOnly = True
        Me.txtRefund_sum_average.Size = New System.Drawing.Size(144, 21)
        Me.txtRefund_sum_average.TabIndex = 34
        Me.txtRefund_sum_average.TabStop = False
        Me.txtRefund_sum_average.Text = ""
        '
        'lblRefund_sum_average
        '
        Me.lblRefund_sum_average.Location = New System.Drawing.Point(272, 96)
        Me.lblRefund_sum_average.Name = "lblRefund_sum_average"
        Me.lblRefund_sum_average.Size = New System.Drawing.Size(96, 16)
        Me.lblRefund_sum_average.TabIndex = 33
        Me.lblRefund_sum_average.Text = "每次还款额(元)"
        '
        'lblBranchBankName
        '
        Me.lblBranchBankName.Location = New System.Drawing.Point(280, 72)
        Me.lblBranchBankName.Name = "lblBranchBankName"
        Me.lblBranchBankName.Size = New System.Drawing.Size(54, 16)
        Me.lblBranchBankName.TabIndex = 29
        Me.lblBranchBankName.Text = "申请支行"
        '
        'txtRefundType
        '
        Me.txtRefundType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRefundType.Location = New System.Drawing.Point(112, 94)
        Me.txtRefundType.Name = "txtRefundType"
        Me.txtRefundType.ReadOnly = True
        Me.txtRefundType.Size = New System.Drawing.Size(152, 21)
        Me.txtRefundType.TabIndex = 24
        Me.txtRefundType.TabStop = False
        Me.txtRefundType.Text = ""
        '
        'lblRefundType
        '
        Me.lblRefundType.Location = New System.Drawing.Point(8, 96)
        Me.lblRefundType.Name = "lblRefundType"
        Me.lblRefundType.Size = New System.Drawing.Size(54, 16)
        Me.lblRefundType.TabIndex = 23
        Me.lblRefundType.Text = "还款方式"
        '
        'txtReguaranteeTerm
        '
        Me.txtReguaranteeTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtReguaranteeTerm.Location = New System.Drawing.Point(360, 46)
        Me.txtReguaranteeTerm.Name = "txtReguaranteeTerm"
        Me.txtReguaranteeTerm.ReadOnly = True
        Me.txtReguaranteeTerm.Size = New System.Drawing.Size(144, 21)
        Me.txtReguaranteeTerm.TabIndex = 22
        Me.txtReguaranteeTerm.TabStop = False
        Me.txtReguaranteeTerm.Text = ""
        Me.txtReguaranteeTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblReguaranteeTerm
        '
        Me.lblReguaranteeTerm.Location = New System.Drawing.Point(272, 48)
        Me.lblReguaranteeTerm.Name = "lblReguaranteeTerm"
        Me.lblReguaranteeTerm.Size = New System.Drawing.Size(96, 16)
        Me.lblReguaranteeTerm.TabIndex = 21
        Me.lblReguaranteeTerm.Text = "再担保期限(月)"
        '
        'txtGuaranteeSum
        '
        Me.txtGuaranteeSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuaranteeSum.Location = New System.Drawing.Point(112, 46)
        Me.txtGuaranteeSum.Name = "txtGuaranteeSum"
        Me.txtGuaranteeSum.ReadOnly = True
        Me.txtGuaranteeSum.Size = New System.Drawing.Size(152, 21)
        Me.txtGuaranteeSum.TabIndex = 20
        Me.txtGuaranteeSum.TabStop = False
        Me.txtGuaranteeSum.Text = ""
        Me.txtGuaranteeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblGuaranteeSum
        '
        Me.lblGuaranteeSum.Location = New System.Drawing.Point(8, 48)
        Me.lblGuaranteeSum.Name = "lblGuaranteeSum"
        Me.lblGuaranteeSum.Size = New System.Drawing.Size(104, 16)
        Me.lblGuaranteeSum.TabIndex = 19
        Me.lblGuaranteeSum.Text = "再担保额度(万元)"
        '
        'lblBankName
        '
        Me.lblBankName.Location = New System.Drawing.Point(8, 72)
        Me.lblBankName.Name = "lblBankName"
        Me.lblBankName.Size = New System.Drawing.Size(54, 16)
        Me.lblBankName.TabIndex = 17
        Me.lblBankName.Text = "申请银行"
        '
        'txtServiceType
        '
        Me.txtServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtServiceType.Location = New System.Drawing.Point(360, 22)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(144, 21)
        Me.txtServiceType.TabIndex = 16
        Me.txtServiceType.TabStop = False
        Me.txtServiceType.Text = ""
        '
        'lblApplyServiceType
        '
        Me.lblApplyServiceType.Location = New System.Drawing.Point(272, 24)
        Me.lblApplyServiceType.Name = "lblApplyServiceType"
        Me.lblApplyServiceType.Size = New System.Drawing.Size(79, 16)
        Me.lblApplyServiceType.TabIndex = 15
        Me.lblApplyServiceType.Text = "申请业务品种"
        '
        'txtOrganizationName
        '
        Me.txtOrganizationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOrganizationName.Location = New System.Drawing.Point(112, 22)
        Me.txtOrganizationName.Name = "txtOrganizationName"
        Me.txtOrganizationName.ReadOnly = True
        Me.txtOrganizationName.Size = New System.Drawing.Size(152, 21)
        Me.txtOrganizationName.TabIndex = 3
        Me.txtOrganizationName.TabStop = False
        Me.txtOrganizationName.Text = ""
        '
        'lblOrganizationName
        '
        Me.lblOrganizationName.Location = New System.Drawing.Point(8, 24)
        Me.lblOrganizationName.Name = "lblOrganizationName"
        Me.lblOrganizationName.Size = New System.Drawing.Size(54, 16)
        Me.lblOrganizationName.TabIndex = 2
        Me.lblOrganizationName.Text = "机构名称"
        '
        'txtReguaranteeCondition
        '
        Me.txtReguaranteeCondition.BackColor = System.Drawing.Color.Gainsboro
        Me.txtReguaranteeCondition.Location = New System.Drawing.Point(112, 120)
        Me.txtReguaranteeCondition.Multiline = True
        Me.txtReguaranteeCondition.Name = "txtReguaranteeCondition"
        Me.txtReguaranteeCondition.ReadOnly = True
        Me.txtReguaranteeCondition.Size = New System.Drawing.Size(392, 72)
        Me.txtReguaranteeCondition.TabIndex = 12
        Me.txtReguaranteeCondition.TabStop = False
        Me.txtReguaranteeCondition.Text = ""
        '
        'lblReguaranteeCondition
        '
        Me.lblReguaranteeCondition.Location = New System.Drawing.Point(8, 128)
        Me.lblReguaranteeCondition.Name = "lblReguaranteeCondition"
        Me.lblReguaranteeCondition.Size = New System.Drawing.Size(66, 16)
        Me.lblReguaranteeCondition.TabIndex = 11
        Me.lblReguaranteeCondition.Text = "再担保条件"
        '
        'txtCorporationName
        '
        Me.txtCorporationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorporationName.Location = New System.Drawing.Point(256, 5)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.ReadOnly = True
        Me.txtCorporationName.Size = New System.Drawing.Size(272, 21)
        Me.txtCorporationName.TabIndex = 15
        Me.txtCorporationName.TabStop = False
        Me.txtCorporationName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 6)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 14
        Me.txtProjectCode.TabStop = False
        Me.txtProjectCode.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 250)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "分配信息"
        '
        'cboLawer
        '
        Me.cboLawer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLawer.Location = New System.Drawing.Point(120, 248)
        Me.cboLawer.Name = "cboLawer"
        Me.cboLawer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cboLawer.Size = New System.Drawing.Size(152, 20)
        Me.cboLawer.TabIndex = 19
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Bitmap)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.ImageIndex = 27
        Me.btnSearch.ImageList = Me.ImageListBasic
        Me.btnSearch.Location = New System.Drawing.Point(194, 272)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 23)
        Me.btnSearch.TabIndex = 18
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
        Me.btnCommit.Location = New System.Drawing.Point(281, 272)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 17
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnConclusion
        '
        Me.btnConclusion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConclusion.Image = CType(resources.GetObject("btnConclusion.Image"), System.Drawing.Bitmap)
        Me.btnConclusion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConclusion.ImageIndex = 26
        Me.btnConclusion.ImageList = Me.ImageListBasic
        Me.btnConclusion.Location = New System.Drawing.Point(72, 272)
        Me.btnConclusion.Name = "btnConclusion"
        Me.btnConclusion.Size = New System.Drawing.Size(112, 23)
        Me.btnConclusion.TabIndex = 45
        Me.btnConclusion.Text = "评审会结论(&R)"
        Me.btnConclusion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FAssignLawer_zdb
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(538, 303)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label3, Me.lblCorporationName, Me.lblProjectCode, Me.btnExit, Me.btnConclusion, Me.cboLawer, Me.btnSearch, Me.btnCommit, Me.grpBaseInfo, Me.txtCorporationName, Me.txtProjectCode})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FAssignLawer_zdb"
        Me.Text = "分配法务经理"
        Me.grpBaseInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsTemp As DataSet

    Private Sub FAssignLawer_zdb_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.GetData()
            Me.GetLawerData()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '获取再担保数据
    Private Sub GetData()
        Me.txtProjectCode.Text = Me.getProjectCode()
        Me.txtCorporationName.Text = Me.getCorporationName()
        dsTemp = gWs.GetReGuaranteeProjectInfo("{ProjectCode = '" & Me.getProjectCode() & "'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                Me.txtOrganizationName.Text = IIf(IsDBNull(.Item("OrganizationName")), "", .Item("OrganizationName"))             '担保机构名称
                Me.txtServiceType.Text = IIf(IsDBNull(.Item("ServiceType")), "", .Item("ServiceType"))                            '业务品种
                Me.txtGuaranteeSum.Text = IIf(IsDBNull(.Item("GuaranteeSum")), "", .Item("GuaranteeSum"))                       '再担保额度
                Me.txtReguaranteeTerm.Text = IIf(IsDBNull(.Item("terms")), "", .Item("terms"))                                    '再担保期限、
                Me.txtBankName.Text = IIf(IsDBNull(.Item("BankName")), "", .Item("BankName"))                                     '贷款银行、
                Me.txtBranchBankName.Text = IIf(IsDBNull(.Item("BranchBankName")), "", .Item("BranchBankName"))                   '贷款支行
                Me.txtRefundType.Text = IIf(IsDBNull(.Item("RefundType")), "", .Item("RefundType"))                               '还款方式
                Me.txtReguaranteeCondition.Text = IIf(IsDBNull(.Item("ReguaranteeCondition")), "", .Item("ReguaranteeCondition")) '再担保条件 
            End With
        End If
        dsTemp = gWs.GetConfTrialInfo("{project_code = '" & Me.getProjectCode() & "' ORDER BY trial_times DESC }", "null")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                If Not IsDBNull(.Item("refund_sum_average")) Then
                    Me.txtRefund_sum_average.Text = CGModule.Numeric2Currency(.Item("refund_sum_average"))                        '每次还款金额
                End If
            End With
        End If
    End Sub
    '初始化分配人员的ComboBox
    Private Sub GetLawerData()
        Dim dtTemp As DataTable
        dtTemp = MdlGlobal.GetPerson(Me.getProjectCode(), "33")
        Dim i As Integer
        For i = 0 To dtTemp.Rows.Count - 1
            Me.cboLawer.Items.Add(dtTemp.Rows(i).Item("staff_name"))
        Next

        'get the default peson
        dtTemp = gWs.GetDefaultPerson(Me.getProjectCode(), "33").Tables(0)
        If Not dtTemp.Rows.Count = 0 Then
            Me.cboLawer.SelectedItem = dtTemp.Rows(0).Item("Person")
        End If
    End Sub

    Private Function SaveData() As Boolean
        If Me.cboLawer.Text = "" Then
            SWDialogBox.MessageBox.Show("$1007", "分配人员")
            Return False
        End If
        Dim tempDS As DataSet
        Dim i As Integer
        Try
            tempDS = gWs.GetProjectTaskAttendeeInfo("{project_code='" & Me.getProjectCode() & "' and role_id='33'}")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                For i = 0 To tempDS.Tables(0).Rows.Count - 1
                    tempDS.Tables(0).Rows(i).Item("attend_person") = Workflow.GetRealTaskAttendee("33", Me.cboLawer.Text)
                Next
            End If
            Dim strResult As String = gWs.UpdateProjectTaskAttendee(tempDS)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "分配法务经理失败", strResult, "")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '评审会结论
    Private Sub btnConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConclusion.Click
        Dim frm As New frmMeetRecordQuery(Me.getProjectCode(), Me.getCorporationName())
        frm.AllowTransparency = False
        frm.ShowDialog()
    End Sub
    '工作任务
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim frm As New frmQueryCurrentTask("33")
        frm.AllowTransparency = False
        frm.ProjectCode = Me.getProjectCode()
        frm.TaskID = Me.getTaskID()
        frm.ShowDialog()
    End Sub
    '提交
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If SWDialogBox.MessageBox.Show("?1000", "提交") <> MsgBoxResult.Yes Then
            Return
        End If
        Try
            If Not Me.SaveData() Then
                Return
            End If
            Dim strResult As String
            strResult = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), Me.cboLawer.Text, UserName)
            If Not gWs.finishedTask(getWorkFlowID(), getProjectCode(), getTaskID(), Me.cboLawer.Text, UserName) = "1" Then
                SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "")
            Else
                MyBase.raiseCommitSucceed()
                SWDialogBox.MessageBox.Show("$SubmitSucceed")
                Close()
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


End Class
