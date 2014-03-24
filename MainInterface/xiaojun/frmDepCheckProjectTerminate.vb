
'审核项目终止报告
Public Class frmDepCheckProjectTerminate
    Inherits frmProjectTerminate

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
    Protected WithEvents pg3 As System.Windows.Forms.TabPage
    Protected WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Protected WithEvents Label13 As System.Windows.Forms.Label
    Protected WithEvents Label14 As System.Windows.Forms.Label
    Protected WithEvents Label15 As System.Windows.Forms.Label
    Protected WithEvents Label16 As System.Windows.Forms.Label
    Protected WithEvents txtDepCheckPerson As System.Windows.Forms.TextBox
    Protected WithEvents cboDepCheckConclusion As System.Windows.Forms.ComboBox
    Protected WithEvents dtpDepProjectTerminateTime As System.Windows.Forms.DateTimePicker
    Protected WithEvents txtDepCheckOpinion As System.Windows.Forms.TextBox
    Protected WithEvents grpSignUp As System.Windows.Forms.GroupBox
    Protected WithEvents txtLoanContract_num1 As System.Windows.Forms.TextBox
    Protected WithEvents lblLoanContract_num1 As System.Windows.Forms.Label
    Protected WithEvents txtAssureContract_num1 As System.Windows.Forms.TextBox
    Protected WithEvents lblAssureContract_num1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDepCheckProjectTerminate))
        Me.pg3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dtpDepProjectTerminateTime = New System.Windows.Forms.DateTimePicker()
        Me.cboDepCheckConclusion = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDepCheckOpinion = New System.Windows.Forms.TextBox()
        Me.txtDepCheckPerson = New System.Windows.Forms.TextBox()
        Me.grpSignUp = New System.Windows.Forms.GroupBox()
        Me.txtAssureContract_num1 = New System.Windows.Forms.TextBox()
        Me.lblAssureContract_num1 = New System.Windows.Forms.Label()
        Me.txtLoanContract_num1 = New System.Windows.Forms.TextBox()
        Me.lblLoanContract_num1 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pg2.SuspendLayout()
        Me.pg1.SuspendLayout()
        Me.tab.SuspendLayout()
        Me.pg3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpSignUp.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.Visible = True
        '
        'Label11
        '
        Me.Label11.Visible = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Visible = True
        '
        'Label8
        '
        Me.Label8.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Visible = True
        '
        'Label4
        '
        Me.Label4.Visible = True
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Visible = True
        '
        'Label6
        '
        Me.Label6.Visible = True
        '
        'Label7
        '
        Me.Label7.Visible = True
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Visible = True
        '
        'Label5
        '
        Me.Label5.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Visible = True
        '
        'txtSum
        '
        Me.txtSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSum.ReadOnly = True
        Me.txtSum.Visible = True
        '
        'Label3
        '
        Me.Label3.Visible = True
        '
        'txtGuaranteesum
        '
        Me.txtGuaranteesum.Visible = True
        '
        'Label9
        '
        Me.Label9.Visible = True
        '
        'txtLoanContract_num
        '
        Me.txtLoanContract_num.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanContract_num.ReadOnly = True
        Me.txtLoanContract_num.Visible = True
        '
        'Label12
        '
        Me.Label12.Visible = True
        '
        'lblLoanContract_num
        '
        Me.lblLoanContract_num.Visible = True
        '
        'txtAssureContract_num
        '
        Me.txtAssureContract_num.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAssureContract_num.ReadOnly = True
        Me.txtAssureContract_num.Visible = True
        '
        'btnDocTerminate
        '
        Me.btnDocTerminate.Image = CType(resources.GetObject("btnDocTerminate.Image"), System.Drawing.Bitmap)
        Me.btnDocTerminate.ImageIndex = 18
        Me.btnDocTerminate.Text = "查看项目终止报告(&V)"
        Me.btnDocTerminate.Visible = True
        '
        'cboTerminate_type
        '
        Me.cboTerminate_type.Enabled = False
        Me.cboTerminate_type.ItemHeight = 12
        Me.cboTerminate_type.Size = New System.Drawing.Size(160, 20)
        Me.cboTerminate_type.Visible = True
        '
        'cboRefundBank
        '
        Me.cboRefundBank.ItemHeight = 12
        Me.cboRefundBank.Size = New System.Drawing.Size(144, 20)
        Me.cboRefundBank.Visible = True
        '
        'dtpTerminate_date
        '
        Me.dtpTerminate_date.Enabled = False
        Me.dtpTerminate_date.Value = New Date(2004, 2, 9, 12, 44, 34, 406)
        Me.dtpTerminate_date.Visible = True
        '
        'cboRefundSubBank
        '
        Me.cboRefundSubBank.ItemHeight = 12
        Me.cboRefundSubBank.Size = New System.Drawing.Size(144, 20)
        Me.cboRefundSubBank.Visible = True
        '
        'lblAssureContract_num
        '
        Me.lblAssureContract_num.Visible = True
        '
        'chkIs_continue_support
        '
        Me.chkIs_continue_support.Enabled = False
        Me.chkIs_continue_support.Visible = True
        '
        'chkIs_high_risk
        '
        Me.chkIs_high_risk.Enabled = False
        Me.chkIs_high_risk.Visible = True
        '
        'txtDetail_reason
        '
        Me.txtDetail_reason.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDetail_reason.ReadOnly = True
        Me.txtDetail_reason.Visible = True
        '
        'txtAppraisement
        '
        Me.txtAppraisement.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAppraisement.ReadOnly = True
        Me.txtAppraisement.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.Location = New System.Drawing.Point(235, 424)
        Me.btnCommit.Visible = True
        '
        'cboSignSubBank
        '
        Me.cboSignSubBank.ItemHeight = 12
        Me.cboSignSubBank.Size = New System.Drawing.Size(144, 20)
        Me.cboSignSubBank.Visible = True
        '
        'dtpRefundDate
        '
        Me.dtpRefundDate.Enabled = False
        Me.dtpRefundDate.Value = New Date(2004, 2, 9, 12, 44, 34, 0)
        Me.dtpRefundDate.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageIndex = -1
        Me.btnSave.ImageList = Nothing
        Me.btnSave.Location = New System.Drawing.Point(151, 424)
        Me.btnSave.Visible = True
        '
        'cboSignBank
        '
        Me.cboSignBank.ItemHeight = 12
        Me.cboSignBank.Size = New System.Drawing.Size(144, 20)
        Me.cboSignBank.Visible = True
        '
        'btnDocRefund
        '
        Me.btnDocRefund.ImageIndex = 18
        Me.btnDocRefund.ImageList = Me.ImageListBasic
        Me.btnDocRefund.Text = "查看还款证明书(&V)"
        Me.btnDocRefund.Visible = True
        '
        'pg1
        '
        Me.pg1.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpSignUp})
        '
        'tab
        '
        Me.tab.Controls.AddRange(New System.Windows.Forms.Control() {Me.pg3})
        Me.tab.ItemSize = New System.Drawing.Size(84, 17)
        Me.tab.Visible = True
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Visible = True
        '
        'txtTerm
        '
        Me.txtTerm.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(319, 424)
        Me.btnExit.Visible = True
        '
        'pg3
        '
        Me.pg3.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox4})
        Me.pg3.Location = New System.Drawing.Point(4, 21)
        Me.pg3.Name = "pg3"
        Me.pg3.Size = New System.Drawing.Size(520, 359)
        Me.pg3.TabIndex = 2
        Me.pg3.Text = " 意见 "
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label14, Me.dtpDepProjectTerminateTime, Me.cboDepCheckConclusion, Me.Label13, Me.Label15, Me.Label16, Me.txtDepCheckOpinion, Me.txtDepCheckPerson})
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(504, 168)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "审核项目终止意见"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(248, 24)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 16)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "审核人"
        '
        'dtpDepProjectTerminateTime
        '
        Me.dtpDepProjectTerminateTime.Enabled = False
        Me.dtpDepProjectTerminateTime.Location = New System.Drawing.Point(80, 22)
        Me.dtpDepProjectTerminateTime.Name = "dtpDepProjectTerminateTime"
        Me.dtpDepProjectTerminateTime.Size = New System.Drawing.Size(144, 21)
        Me.dtpDepProjectTerminateTime.TabIndex = 1
        '
        'cboDepCheckConclusion
        '
        Me.cboDepCheckConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDepCheckConclusion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboDepCheckConclusion.Location = New System.Drawing.Point(80, 48)
        Me.cboDepCheckConclusion.Name = "cboDepCheckConclusion"
        Me.cboDepCheckConclusion.Size = New System.Drawing.Size(144, 20)
        Me.cboDepCheckConclusion.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 16)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "时间"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 6
        Me.Label15.Text = "审核结论"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(32, 16)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "意见"
        '
        'txtDepCheckOpinion
        '
        Me.txtDepCheckOpinion.Location = New System.Drawing.Point(80, 72)
        Me.txtDepCheckOpinion.MaxLength = 1000
        Me.txtDepCheckOpinion.Multiline = True
        Me.txtDepCheckOpinion.Name = "txtDepCheckOpinion"
        Me.txtDepCheckOpinion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDepCheckOpinion.Size = New System.Drawing.Size(408, 88)
        Me.txtDepCheckOpinion.TabIndex = 3
        Me.txtDepCheckOpinion.Text = ""
        '
        'txtDepCheckPerson
        '
        Me.txtDepCheckPerson.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDepCheckPerson.Location = New System.Drawing.Point(328, 22)
        Me.txtDepCheckPerson.Name = "txtDepCheckPerson"
        Me.txtDepCheckPerson.ReadOnly = True
        Me.txtDepCheckPerson.Size = New System.Drawing.Size(160, 21)
        Me.txtDepCheckPerson.TabIndex = 0
        Me.txtDepCheckPerson.Text = ""
        '
        'grpSignUp
        '
        Me.grpSignUp.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtAssureContract_num1, Me.lblAssureContract_num1, Me.txtLoanContract_num1, Me.lblLoanContract_num1})
        Me.grpSignUp.Location = New System.Drawing.Point(8, 208)
        Me.grpSignUp.Name = "grpSignUp"
        Me.grpSignUp.Size = New System.Drawing.Size(504, 56)
        Me.grpSignUp.TabIndex = 56
        Me.grpSignUp.TabStop = False
        Me.grpSignUp.Text = "签约信息"
        '
        'txtAssureContract_num1
        '
        Me.txtAssureContract_num1.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAssureContract_num1.Location = New System.Drawing.Point(344, 22)
        Me.txtAssureContract_num1.Name = "txtAssureContract_num1"
        Me.txtAssureContract_num1.ReadOnly = True
        Me.txtAssureContract_num1.Size = New System.Drawing.Size(144, 21)
        Me.txtAssureContract_num1.TabIndex = 3
        Me.txtAssureContract_num1.Text = ""
        '
        'lblAssureContract_num1
        '
        Me.lblAssureContract_num1.Location = New System.Drawing.Point(256, 24)
        Me.lblAssureContract_num1.Name = "lblAssureContract_num1"
        Me.lblAssureContract_num1.Size = New System.Drawing.Size(100, 16)
        Me.lblAssureContract_num1.TabIndex = 4
        Me.lblAssureContract_num1.Text = "借款合同号"
        '
        'txtLoanContract_num1
        '
        Me.txtLoanContract_num1.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanContract_num1.Location = New System.Drawing.Point(96, 22)
        Me.txtLoanContract_num1.Name = "txtLoanContract_num1"
        Me.txtLoanContract_num1.ReadOnly = True
        Me.txtLoanContract_num1.Size = New System.Drawing.Size(144, 21)
        Me.txtLoanContract_num1.TabIndex = 0
        Me.txtLoanContract_num1.Text = ""
        '
        'lblLoanContract_num1
        '
        Me.lblLoanContract_num1.Location = New System.Drawing.Point(8, 24)
        Me.lblLoanContract_num1.Name = "lblLoanContract_num1"
        Me.lblLoanContract_num1.Size = New System.Drawing.Size(100, 16)
        Me.lblLoanContract_num1.TabIndex = 2
        Me.lblLoanContract_num1.Text = "借款合同号"
        '
        'frmDepCheckProjectTerminate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(546, 455)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.tab, Me.lblCorporationName, Me.lblProjectCode, Me.btnSave, Me.txtCorporationName, Me.txtProjectCode, Me.btnCommit, Me.btnExit})
        Me.Name = "frmDepCheckProjectTerminate"
        Me.Text = "审核项目终止报告"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.pg2.ResumeLayout(False)
        Me.pg1.ResumeLayout(False)
        Me.tab.ResumeLayout(False)
        Me.pg3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.grpSignUp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmDepCheckProjectTerminate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.bFormLoad = False
            Me.GetSignUp()
            Me.GetConclusion()
            Me.GetOpinion()
            Me.bFormLoad = True
            Me.bIsChanged = False
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '获得签约信息
    Private Sub GetSignUp()
        Dim dsTemp As DataSet = gWs.GetProjectSignatureInfo("{project_code LIKE '" & Me.getProjectCode() & "'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                Me.txtLoanContract_num1.Text = IIf(IsDBNull(.Item("loanContract_num")), "", .Item("loanContract_num"))   '借款合同号　
                Me.txtAssureContract_num1.Text = IIf(IsDBNull(.Item("assureContract_num")), "", .Item("assureContract_num")) '保证合同号                
            End With
        End If
    End Sub
    '审核项目终止结论(是否同意)
    Private Sub GetConclusion()
        dsTemp = gWs.GetTransCondition(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID())
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            Me.cboDepCheckConclusion.DataSource = dsTemp.Tables(0).DefaultView
            Me.cboDepCheckConclusion.DisplayMember = "transfer_condition"
            Me.cboDepCheckConclusion.ValueMember = "transfer_condition"
            Me.cboDepCheckConclusion.SelectedIndex = 0
        End If
    End Sub
    '获取审核项目终止意见
    Protected Overridable Sub GetOpinion()
        dsTemp = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "' and item_type='56' and item_code='001'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dstemp.Tables(0).Rows(0)
                Me.dtpDepProjectTerminateTime.Value = IIf(.Item("create_date") Is DBNull.Value, gWs.GetSysTime(), .Item("create_date"))
                Me.txtDepCheckPerson.Text = IIf(.Item("create_person") Is DBNull.Value, UserName, .Item("create_person"))
                Me.txtDepCheckOpinion.Text = IIf(.Item("content") Is DBNull.Value, "", .Item("content"))
                If Not .Item("conclusion") Is System.DBNull.Value Then
                    Me.cboDepCheckConclusion.SelectedValue = .Item("conclusion")
                End If
            End With
        Else
            Me.dtpDepProjectTerminateTime.Value = gWs.GetSysTime()
            Me.txtDepCheckPerson.Text = UserName
        End If

        AddHandler txtDepCheckOpinion.TextChanged, AddressOf DataChanged
        '避免bIsChanged由于TabPage切换时ComboBox不必要的初始化而改变
        RemoveHandler cboTerminate_type.SelectedIndexChanged, AddressOf DataChanged
    End Sub

    Protected Overrides Sub SetControlState()
        If Me.bIsReguarantee Then
            Me.btnDocRefund.Text = "查看再担保保证责任终止通知书(&V)"
        End If
    End Sub

    Protected Overrides Function SaveData() As Boolean
        Try
            DStemp = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "' and item_type='56' and item_code='001'}")
            If Not DStemp.Tables(0).Rows.Count = 0 Then
                With DStemp.Tables(0).Rows(0)
                    .Item("content") = Me.txtDepCheckOpinion.Text.Trim()
                    .Item("conclusion") = Me.cboDepCheckConclusion.Text
                End With
            Else
                Dim dr As DataRow = DStemp.Tables(0).NewRow()
                With dr
                    .Item("project_code") = Me.getProjectCode()
                    .Item("item_type") = "56"
                    .Item("item_code") = "001"
                    .Item("content") = Me.txtDepCheckOpinion.Text.Trim()
                    .Item("conclusion") = Me.cboDepCheckConclusion.Text
                    .Item("create_date") = Me.dtpDepProjectTerminateTime.Value
                    .Item("create_person") = UserName
                End With
                DStemp.Tables(0).Rows.Add(dr)
            End If
            strResult = gWs.UpdateProjectOpinion(DStemp)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "项目终止报告审核失败", strResult, "")
                Return False
            End If
            Return True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    Protected Overrides Sub btnDocRefund_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If Me.bIsReguarantee Then
                Dim frm As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "45", "212", UserName)
                frm.AllowTransparency = False
                frm.Text = "查看再担保保证责任终止通知书"
                frm.setIsButtonEnable(True)
                frm.ShowDialog()
            Else
                Dim frm As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "45", "012", UserName)
                frm.AllowTransparency = False
                frm.Text = "查看还款证明书"
                frm.setIsButtonEnable(True)
                frm.ShowDialog()
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    '提交按钮
    Protected Overrides Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If SWDialogBox.MessageBox.Show("?1000", "提交") <> MsgBoxResult.Yes Then
            Return
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not Me.SaveData() Then
                Return
            End If
            Dim strResult As String = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), Me.cboDepCheckConclusion.Text, UserName)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "审核项目终止报告")
            Else
                MyBase.raiseCommitSucceed()
                SWDialogBox.MessageBox.Show("$SubmitSucceed")
                Close()
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '避免bIsChanged由于TabPage切换时ComboBox不必要的初始化而改变
    Protected Overrides Sub tab_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Not cboDepCheckConclusion Is Nothing Then
            If Not TAB.SelectedIndex = 2 Then
                RemoveHandler cboDepCheckConclusion.SelectedIndexChanged, AddressOf DataChanged
            Else
                AddHandler cboDepCheckConclusion.SelectedIndexChanged, AddressOf DataChanged
            End If
        End If
    End Sub

End Class
