
'项目逾期后分配法务经理
Public Class FAssignLawer_ProjectDelay
    Inherits MainInterface.frmBasic

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
    Friend WithEvents btnConclusion As System.Windows.Forms.Button
    Protected WithEvents lblLawer As System.Windows.Forms.Label
    Public WithEvents lblCorporationName As System.Windows.Forms.Label
    Public WithEvents lblProjectCode As System.Windows.Forms.Label
    Protected WithEvents btnSearch As System.Windows.Forms.Button
    Protected WithEvents grpBaseInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lbPmB As System.Windows.Forms.Label
    Friend WithEvents lblPmA As System.Windows.Forms.Label
    Protected WithEvents lblSubBank As System.Windows.Forms.Label
    Protected WithEvents lblApplyDate As System.Windows.Forms.Label
    Protected WithEvents lblApplyGuaranteeTerm As System.Windows.Forms.Label
    Protected WithEvents lblApplyGuaranteeSum As System.Windows.Forms.Label
    Protected WithEvents lblBank As System.Windows.Forms.Label
    Protected WithEvents lblApplyServiceType As System.Windows.Forms.Label
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Protected WithEvents cboLawer As System.Windows.Forms.ComboBox
    Public WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Protected WithEvents btnCommit As System.Windows.Forms.Button
    Protected WithEvents txtOverdue_sum As System.Windows.Forms.TextBox
    Protected WithEvents lblOverdue_sum As System.Windows.Forms.Label
    Protected WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSign_bank_name As System.Windows.Forms.TextBox
    Protected WithEvents txtSign_bank_branch_name As System.Windows.Forms.TextBox
    Protected WithEvents dtpSign_date As System.Windows.Forms.DateTimePicker
    Protected WithEvents txtTerms As System.Windows.Forms.TextBox
    Protected WithEvents txtSign_sum As System.Windows.Forms.TextBox
    Protected WithEvents txtServiceType As System.Windows.Forms.TextBox
    Friend WithEvents txtManager_B As System.Windows.Forms.TextBox
    Friend WithEvents txtManager_A As System.Windows.Forms.TextBox
    Protected WithEvents dtpStartTime As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FAssignLawer_ProjectDelay))
        Me.btnConclusion = New System.Windows.Forms.Button()
        Me.lblLawer = New System.Windows.Forms.Label()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.lblProjectCode = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.grpBaseInfo = New System.Windows.Forms.GroupBox()
        Me.txtSign_bank_branch_name = New System.Windows.Forms.TextBox()
        Me.txtSign_bank_name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.txtOverdue_sum = New System.Windows.Forms.TextBox()
        Me.lblOverdue_sum = New System.Windows.Forms.Label()
        Me.txtManager_B = New System.Windows.Forms.TextBox()
        Me.lbPmB = New System.Windows.Forms.Label()
        Me.txtManager_A = New System.Windows.Forms.TextBox()
        Me.lblPmA = New System.Windows.Forms.Label()
        Me.lblSubBank = New System.Windows.Forms.Label()
        Me.lblApplyDate = New System.Windows.Forms.Label()
        Me.dtpSign_date = New System.Windows.Forms.DateTimePicker()
        Me.txtTerms = New System.Windows.Forms.TextBox()
        Me.lblApplyGuaranteeTerm = New System.Windows.Forms.Label()
        Me.txtSign_sum = New System.Windows.Forms.TextBox()
        Me.lblApplyGuaranteeSum = New System.Windows.Forms.Label()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.txtServiceType = New System.Windows.Forms.TextBox()
        Me.lblApplyServiceType = New System.Windows.Forms.Label()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.cboLawer = New System.Windows.Forms.ComboBox()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.grpBaseInfo.SuspendLayout()
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
        Me.btnExit.Location = New System.Drawing.Point(317, 216)
        Me.btnExit.Visible = True
        '
        'btnConclusion
        '
        Me.btnConclusion.Location = New System.Drawing.Point(177, 408)
        Me.btnConclusion.Name = "btnConclusion"
        Me.btnConclusion.Size = New System.Drawing.Size(96, 23)
        Me.btnConclusion.TabIndex = 54
        Me.btnConclusion.Text = "评审会结论(&R)"
        '
        'lblLawer
        '
        Me.lblLawer.Location = New System.Drawing.Point(16, 194)
        Me.lblLawer.Name = "lblLawer"
        Me.lblLawer.Size = New System.Drawing.Size(54, 16)
        Me.lblLawer.TabIndex = 53
        Me.lblLawer.Text = "分配人员"
        '
        'lblCorporationName
        '
        Me.lblCorporationName.AutoSize = True
        Me.lblCorporationName.Location = New System.Drawing.Point(184, 8)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(54, 14)
        Me.lblCorporationName.TabIndex = 49
        Me.lblCorporationName.Text = "企业名称"
        '
        'lblProjectCode
        '
        Me.lblProjectCode.AutoSize = True
        Me.lblProjectCode.Location = New System.Drawing.Point(16, 8)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(54, 14)
        Me.lblProjectCode.TabIndex = 48
        Me.lblProjectCode.Text = "项目编码"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Bitmap)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.ImageIndex = 3
        Me.btnSearch.ImageList = Me.ImageListBasic
        Me.btnSearch.Location = New System.Drawing.Point(141, 216)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 23)
        Me.btnSearch.TabIndex = 46
        Me.btnSearch.Text = "查 询(&S)"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpBaseInfo
        '
        Me.grpBaseInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtSign_bank_branch_name, Me.txtSign_bank_name, Me.Label1, Me.dtpStartTime, Me.txtOverdue_sum, Me.lblOverdue_sum, Me.txtManager_B, Me.lbPmB, Me.txtManager_A, Me.lblPmA, Me.lblSubBank, Me.lblApplyDate, Me.dtpSign_date, Me.txtTerms, Me.lblApplyGuaranteeTerm, Me.txtSign_sum, Me.lblApplyGuaranteeSum, Me.lblBank, Me.txtServiceType, Me.lblApplyServiceType})
        Me.grpBaseInfo.Location = New System.Drawing.Point(8, 32)
        Me.grpBaseInfo.Name = "grpBaseInfo"
        Me.grpBaseInfo.Size = New System.Drawing.Size(520, 152)
        Me.grpBaseInfo.TabIndex = 52
        Me.grpBaseInfo.TabStop = False
        Me.grpBaseInfo.Text = "项目基本信息"
        '
        'txtSign_bank_branch_name
        '
        Me.txtSign_bank_branch_name.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSign_bank_branch_name.Location = New System.Drawing.Point(360, 46)
        Me.txtSign_bank_branch_name.Name = "txtSign_bank_branch_name"
        Me.txtSign_bank_branch_name.ReadOnly = True
        Me.txtSign_bank_branch_name.Size = New System.Drawing.Size(144, 21)
        Me.txtSign_bank_branch_name.TabIndex = 61
        Me.txtSign_bank_branch_name.TabStop = False
        Me.txtSign_bank_branch_name.Text = ""
        '
        'txtSign_bank_name
        '
        Me.txtSign_bank_name.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSign_bank_name.Location = New System.Drawing.Point(104, 46)
        Me.txtSign_bank_name.Name = "txtSign_bank_name"
        Me.txtSign_bank_name.ReadOnly = True
        Me.txtSign_bank_name.Size = New System.Drawing.Size(152, 21)
        Me.txtSign_bank_name.TabIndex = 60
        Me.txtSign_bank_name.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 16)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "放款日期"
        '
        'dtpStartTime
        '
        Me.dtpStartTime.Enabled = False
        Me.dtpStartTime.Location = New System.Drawing.Point(104, 118)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.Size = New System.Drawing.Size(152, 21)
        Me.dtpStartTime.TabIndex = 58
        Me.dtpStartTime.TabStop = False
        Me.dtpStartTime.Value = New Date(2003, 6, 27, 0, 0, 0, 0)
        '
        'txtOverdue_sum
        '
        Me.txtOverdue_sum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOverdue_sum.Location = New System.Drawing.Point(360, 118)
        Me.txtOverdue_sum.Name = "txtOverdue_sum"
        Me.txtOverdue_sum.ReadOnly = True
        Me.txtOverdue_sum.Size = New System.Drawing.Size(144, 21)
        Me.txtOverdue_sum.TabIndex = 54
        Me.txtOverdue_sum.TabStop = False
        Me.txtOverdue_sum.Text = ""
        Me.txtOverdue_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOverdue_sum
        '
        Me.lblOverdue_sum.Location = New System.Drawing.Point(272, 120)
        Me.lblOverdue_sum.Name = "lblOverdue_sum"
        Me.lblOverdue_sum.Size = New System.Drawing.Size(80, 16)
        Me.lblOverdue_sum.TabIndex = 53
        Me.lblOverdue_sum.Text = "逾期金额(元)"
        '
        'txtManager_B
        '
        Me.txtManager_B.BackColor = System.Drawing.Color.Gainsboro
        Me.txtManager_B.Location = New System.Drawing.Point(360, 94)
        Me.txtManager_B.Name = "txtManager_B"
        Me.txtManager_B.ReadOnly = True
        Me.txtManager_B.Size = New System.Drawing.Size(144, 21)
        Me.txtManager_B.TabIndex = 52
        Me.txtManager_B.Text = ""
        '
        'lbPmB
        '
        Me.lbPmB.Location = New System.Drawing.Point(272, 96)
        Me.lbPmB.Name = "lbPmB"
        Me.lbPmB.Size = New System.Drawing.Size(60, 16)
        Me.lbPmB.TabIndex = 51
        Me.lbPmB.Text = "项目经理B"
        '
        'txtManager_A
        '
        Me.txtManager_A.BackColor = System.Drawing.Color.Gainsboro
        Me.txtManager_A.Location = New System.Drawing.Point(104, 94)
        Me.txtManager_A.Name = "txtManager_A"
        Me.txtManager_A.ReadOnly = True
        Me.txtManager_A.Size = New System.Drawing.Size(152, 21)
        Me.txtManager_A.TabIndex = 50
        Me.txtManager_A.Text = ""
        '
        'lblPmA
        '
        Me.lblPmA.Location = New System.Drawing.Point(8, 96)
        Me.lblPmA.Name = "lblPmA"
        Me.lblPmA.Size = New System.Drawing.Size(60, 16)
        Me.lblPmA.TabIndex = 49
        Me.lblPmA.Text = "项目经理A"
        '
        'lblSubBank
        '
        Me.lblSubBank.Location = New System.Drawing.Point(272, 48)
        Me.lblSubBank.Name = "lblSubBank"
        Me.lblSubBank.Size = New System.Drawing.Size(54, 16)
        Me.lblSubBank.TabIndex = 29
        Me.lblSubBank.Text = "签约支行"
        '
        'lblApplyDate
        '
        Me.lblApplyDate.Location = New System.Drawing.Point(8, 24)
        Me.lblApplyDate.Name = "lblApplyDate"
        Me.lblApplyDate.Size = New System.Drawing.Size(54, 16)
        Me.lblApplyDate.TabIndex = 26
        Me.lblApplyDate.Text = "签约日期"
        '
        'dtpSign_date
        '
        Me.dtpSign_date.Enabled = False
        Me.dtpSign_date.Location = New System.Drawing.Point(104, 22)
        Me.dtpSign_date.Name = "dtpSign_date"
        Me.dtpSign_date.Size = New System.Drawing.Size(152, 21)
        Me.dtpSign_date.TabIndex = 25
        Me.dtpSign_date.TabStop = False
        Me.dtpSign_date.Value = New Date(2003, 6, 27, 0, 0, 0, 0)
        '
        'txtTerms
        '
        Me.txtTerms.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerms.Location = New System.Drawing.Point(360, 70)
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.ReadOnly = True
        Me.txtTerms.Size = New System.Drawing.Size(144, 21)
        Me.txtTerms.TabIndex = 22
        Me.txtTerms.TabStop = False
        Me.txtTerms.Text = ""
        Me.txtTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblApplyGuaranteeTerm
        '
        Me.lblApplyGuaranteeTerm.Location = New System.Drawing.Point(272, 72)
        Me.lblApplyGuaranteeTerm.Name = "lblApplyGuaranteeTerm"
        Me.lblApplyGuaranteeTerm.Size = New System.Drawing.Size(80, 16)
        Me.lblApplyGuaranteeTerm.TabIndex = 21
        Me.lblApplyGuaranteeTerm.Text = "申请期限(月)"
        '
        'txtSign_sum
        '
        Me.txtSign_sum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSign_sum.Location = New System.Drawing.Point(104, 70)
        Me.txtSign_sum.Name = "txtSign_sum"
        Me.txtSign_sum.ReadOnly = True
        Me.txtSign_sum.Size = New System.Drawing.Size(152, 21)
        Me.txtSign_sum.TabIndex = 20
        Me.txtSign_sum.TabStop = False
        Me.txtSign_sum.Text = ""
        Me.txtSign_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblApplyGuaranteeSum
        '
        Me.lblApplyGuaranteeSum.Location = New System.Drawing.Point(8, 72)
        Me.lblApplyGuaranteeSum.Name = "lblApplyGuaranteeSum"
        Me.lblApplyGuaranteeSum.Size = New System.Drawing.Size(96, 16)
        Me.lblApplyGuaranteeSum.TabIndex = 19
        Me.lblApplyGuaranteeSum.Text = "签约金额(万元)"
        '
        'lblBank
        '
        Me.lblBank.Location = New System.Drawing.Point(8, 48)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(54, 16)
        Me.lblBank.TabIndex = 17
        Me.lblBank.Text = "签约银行"
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
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 5)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 50
        Me.txtProjectCode.TabStop = False
        Me.txtProjectCode.Text = ""
        '
        'cboLawer
        '
        Me.cboLawer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLawer.Location = New System.Drawing.Point(112, 192)
        Me.cboLawer.Name = "cboLawer"
        Me.cboLawer.Size = New System.Drawing.Size(152, 20)
        Me.cboLawer.TabIndex = 45
        '
        'txtCorporationName
        '
        Me.txtCorporationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorporationName.Location = New System.Drawing.Point(248, 5)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.ReadOnly = True
        Me.txtCorporationName.Size = New System.Drawing.Size(280, 21)
        Me.txtCorporationName.TabIndex = 51
        Me.txtCorporationName.TabStop = False
        Me.txtCorporationName.Text = ""
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(229, 216)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 47
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FAssignLawer_ProjectDelay
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(538, 247)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnConclusion, Me.lblLawer, Me.lblCorporationName, Me.lblProjectCode, Me.btnSearch, Me.grpBaseInfo, Me.txtProjectCode, Me.cboLawer, Me.txtCorporationName, Me.btnCommit, Me.btnExit})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FAssignLawer_ProjectDelay"
        Me.Text = "分配法务经理"
        Me.grpBaseInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsTemp As DataSet
    Private Sub FAssignLawer_ProjectDelay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.GetData()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub GetData()
        Me.txtProjectCode.Text = Me.getProjectCode()
        Me.txtCorporationName.Text = Me.getCorporationName()
        Dim dtTemp As DataTable
        dtTemp = MdlGlobal.GetPerson(Me.getProjectCode(), "35") '取得法务经理名，其它分配法务经理均为33
        Dim i As Integer
        For i = 0 To dtTemp.Rows.Count - 1
            Me.cboLawer.Items.Add(dtTemp.Rows(i).Item("staff_name"))
        Next

        'get the default peson
        dtTemp = gWs.GetDefaultPerson(Me.getProjectCode(), "35").Tables(0)
        If Not dtTemp.Rows.Count = 0 Then
            Me.cboLawer.SelectedItem = dtTemp.Rows(0).Item("Person")
        End If

        dsTemp = gWs.GetProjectInfoEx("{ProjectCode = '" & Me.getProjectCode() & "'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                Me.dtpSign_date.Value = IIf(IsDBNull(.Item("sign_date")), Date.Now, .Item("sign_date"))   '签约日期
                Me.txtServiceType.Text = IIf(IsDBNull(.Item("ServiceType")), "", .Item("ServiceType"))    '业务品种
                Me.txtSign_bank_name.Text = IIf(IsDBNull(.Item("sign_bank_name")), "", .Item("sign_bank_name"))  '签约银行
                Me.txtSign_bank_branch_name.Text = IIf(IsDBNull(.Item("sign_bank_branch_name")), "", .Item("sign_bank_branch_name")) '签约支行
                Me.txtSign_sum.Text = IIf(IsDBNull(.Item("sign_sum")), "", .Item("sign_sum"))   '签约金额
                Me.txtTerms.Text = IIf(IsDBNull(.Item("terms")), "", .Item("terms"))         '放款期限
                Me.txtManager_A.Text = IIf(IsDBNull(.Item("manager_A")), "", .Item("manager_A")) '项目经理A
                Me.txtManager_B.Text = IIf(IsDBNull(.Item("manager_B")), "", .Item("manager_B")) '项目经理B
                Me.dtpStartTime.Value = IIf(IsDBNull(.Item("StartTime")), Date.Now, .Item("StartTime")) '放款日期
                Me.txtOverdue_sum.Text = IIf(IsDBNull(.Item("overdue_sum")), "", .Item("overdue_sum")) '逾期金额
            End With
        End If
    End Sub

    Private Function SaveData() As Boolean
        If Me.cboLawer.Text = "" Then
            SWDialogBox.MessageBox.Show("$1007", "分配人员")
            Return False
        End If
        Dim i As Integer
        Try
            dsTemp = gWs.GetProjectTaskAttendeeInfo("{project_code='" & Me.getProjectCode() & "' and role_id='35'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                For i = 0 To dsTemp.Tables(0).Rows.Count - 1
                    dsTemp.Tables(0).Rows(i).Item("attend_person") = Workflow.GetRealTaskAttendee("35", Me.cboLawer.Text)
                Next
            End If
            Dim strResult As String = gWs.UpdateProjectTaskAttendee(dsTemp)
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
    '查询工作任务
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim frm As New frmQueryCurrentTask("33")
        frm.AllowTransparency = False
        frm.ProjectCode = Me.getProjectCode()
        frm.TaskID = Me.getTaskID()
        frm.ShowDialog()
    End Sub
    '提交按钮
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
    '退出按钮
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
