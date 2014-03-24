
'确认项目终止报告
Public Class frmCenCheckProjectTerminate
    Inherits frmDepCheckProjectTerminate

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
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtAffirmTerminateOpinion As System.Windows.Forms.TextBox
    Friend WithEvents txtAffirmTerminatePerson As System.Windows.Forms.TextBox
    Friend WithEvents dtpAffirmTerminateTime As System.Windows.Forms.DateTimePicker

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCenCheckProjectTerminate))
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtAffirmTerminateOpinion = New System.Windows.Forms.TextBox()
        Me.txtAffirmTerminatePerson = New System.Windows.Forms.TextBox()
        Me.dtpAffirmTerminateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.grpSignUp.SuspendLayout()
        Me.pg3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.pg2.SuspendLayout()
        Me.pg1.SuspendLayout()
        Me.tab.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpDepProjectTerminateTime
        '
        Me.dtpDepProjectTerminateTime.Value = New Date(2004, 2, 9, 13, 30, 38, 265)
        Me.dtpDepProjectTerminateTime.Visible = True
        '
        'grpSignUp
        '
        Me.grpSignUp.Visible = True
        '
        'cboDepCheckConclusion
        '
        Me.cboDepCheckConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cboDepCheckConclusion.Enabled = False
        Me.cboDepCheckConclusion.ItemHeight = 12
        Me.cboDepCheckConclusion.Location = New System.Drawing.Point(80, 46)
        Me.cboDepCheckConclusion.Size = New System.Drawing.Size(144, 20)
        Me.cboDepCheckConclusion.Visible = True
        '
        'Label13
        '
        Me.Label13.Visible = True
        '
        'txtLoanContract_num1
        '
        Me.txtLoanContract_num1.Visible = True
        '
        'txtDepCheckPerson
        '
        Me.txtDepCheckPerson.Visible = True
        '
        'pg3
        '
        Me.pg3.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox5})
        '
        'Label16
        '
        Me.Label16.Visible = True
        '
        'lblLoanContract_num1
        '
        Me.lblLoanContract_num1.Visible = True
        '
        'Label15
        '
        Me.Label15.Visible = True
        '
        'txtAssureContract_num1
        '
        Me.txtAssureContract_num1.Visible = True
        '
        'Label14
        '
        Me.Label14.Visible = True
        '
        'lblAssureContract_num1
        '
        Me.lblAssureContract_num1.Visible = True
        '
        'txtDepCheckOpinion
        '
        Me.txtDepCheckOpinion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDepCheckOpinion.ReadOnly = True
        Me.txtDepCheckOpinion.Visible = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Size = New System.Drawing.Size(504, 176)
        Me.GroupBox4.Visible = True
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
        Me.txtAssureContract_num.Visible = True
        '
        'btnDocTerminate
        '
        Me.btnDocTerminate.ImageIndex = 18
        Me.btnDocTerminate.ImageList = Me.ImageListBasic
        Me.btnDocTerminate.Visible = True
        '
        'cboTerminate_type
        '
        Me.cboTerminate_type.DropDownWidth = 152
        Me.cboTerminate_type.Size = New System.Drawing.Size(152, 20)
        Me.cboTerminate_type.Visible = True
        '
        'cboRefundBank
        '
        Me.cboRefundBank.DropDownWidth = 128
        Me.cboRefundBank.Size = New System.Drawing.Size(144, 20)
        Me.cboRefundBank.Visible = True
        '
        'dtpTerminate_date
        '
        Me.dtpTerminate_date.Visible = True
        '
        'cboRefundSubBank
        '
        Me.cboRefundSubBank.Size = New System.Drawing.Size(144, 20)
        Me.cboRefundSubBank.Visible = True
        '
        'lblAssureContract_num
        '
        Me.lblAssureContract_num.Visible = True
        '
        'chkIs_continue_support
        '
        Me.chkIs_continue_support.Visible = True
        '
        'chkIs_high_risk
        '
        Me.chkIs_high_risk.Visible = True
        '
        'txtDetail_reason
        '
        Me.txtDetail_reason.Visible = True
        '
        'txtAppraisement
        '
        Me.txtAppraisement.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(233, 424)
        Me.btnCommit.Visible = True
        '
        'cboSignSubBank
        '
        Me.cboSignSubBank.Size = New System.Drawing.Size(144, 20)
        Me.cboSignSubBank.Visible = True
        '
        'dtpRefundDate
        '
        Me.dtpRefundDate.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(145, 424)
        Me.btnSave.Visible = True
        '
        'cboSignBank
        '
        Me.cboSignBank.DropDownWidth = 128
        Me.cboSignBank.Size = New System.Drawing.Size(144, 20)
        Me.cboSignBank.Visible = True
        '
        'btnDocRefund
        '
        Me.btnDocRefund.Image = CType(resources.GetObject("btnDocRefund.Image"), System.Drawing.Bitmap)
        Me.btnDocRefund.ImageList = Me.ImageListBasic
        Me.btnDocRefund.Visible = True
        '
        'tab
        '
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
        Me.btnExit.Location = New System.Drawing.Point(321, 424)
        Me.btnExit.Visible = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtAffirmTerminateOpinion, Me.txtAffirmTerminatePerson, Me.dtpAffirmTerminateTime, Me.Label19, Me.Label18, Me.Label17})
        Me.GroupBox5.Location = New System.Drawing.Point(8, 192)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(504, 160)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "确认项目终止意见"
        '
        'txtAffirmTerminateOpinion
        '
        Me.txtAffirmTerminateOpinion.Location = New System.Drawing.Point(80, 48)
        Me.txtAffirmTerminateOpinion.MaxLength = 1000
        Me.txtAffirmTerminateOpinion.Multiline = True
        Me.txtAffirmTerminateOpinion.Name = "txtAffirmTerminateOpinion"
        Me.txtAffirmTerminateOpinion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAffirmTerminateOpinion.Size = New System.Drawing.Size(408, 104)
        Me.txtAffirmTerminateOpinion.TabIndex = 5
        Me.txtAffirmTerminateOpinion.Text = ""
        '
        'txtAffirmTerminatePerson
        '
        Me.txtAffirmTerminatePerson.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAffirmTerminatePerson.Location = New System.Drawing.Point(328, 22)
        Me.txtAffirmTerminatePerson.Name = "txtAffirmTerminatePerson"
        Me.txtAffirmTerminatePerson.ReadOnly = True
        Me.txtAffirmTerminatePerson.Size = New System.Drawing.Size(160, 21)
        Me.txtAffirmTerminatePerson.TabIndex = 4
        Me.txtAffirmTerminatePerson.Text = ""
        '
        'dtpAffirmTerminateTime
        '
        Me.dtpAffirmTerminateTime.Enabled = False
        Me.dtpAffirmTerminateTime.Location = New System.Drawing.Point(80, 22)
        Me.dtpAffirmTerminateTime.Name = "dtpAffirmTerminateTime"
        Me.dtpAffirmTerminateTime.Size = New System.Drawing.Size(144, 21)
        Me.dtpAffirmTerminateTime.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 56)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 16)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "意见"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(248, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(64, 16)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "确认人"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(8, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 16)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "时间"
        '
        'frmCenCheckProjectTerminate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(546, 455)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.tab, Me.lblCorporationName, Me.lblProjectCode, Me.btnSave, Me.txtCorporationName, Me.txtProjectCode, Me.btnCommit, Me.btnExit})
        Me.Name = "frmCenCheckProjectTerminate"
        Me.Text = "确认项目终止报告"
        Me.grpSignUp.ResumeLayout(False)
        Me.pg3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.pg2.ResumeLayout(False)
        Me.pg1.ResumeLayout(False)
        Me.tab.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCenCheckProjectTerminate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.bFormLoad = False
            Me.GetOpinion()
            Me.bFormLoad = True
            Me.bIsChanged = False
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '先获取审核项目终止意见，然后获取部长确认意见
    Protected Overrides Sub GetOpinion()
        dsTemp = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "' and item_type='56' and item_code='001'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dstemp.Tables(0).Rows(0)
                Me.dtpDepProjectTerminateTime.Value = IIf(.Item("create_date") Is DBNull.Value, gWs.GetSysTime(), .Item("create_date"))
                Me.txtDepCheckPerson.Text = IIf(.Item("create_person") Is DBNull.Value, UserName, .Item("create_person"))
                Me.txtDepCheckOpinion.Text = IIf(.Item("content") Is DBNull.Value, "", .Item("content"))
                Me.cboDepCheckConclusion.Text = IIf(.Item("conclusion") Is DBNull.Value, "", .Item("conclusion"))
            End With
        End If

        dsTemp = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "' and item_type='56' and item_code='002'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dstemp.Tables(0).Rows(0)
                Me.dtpAffirmTerminateTime.Value = IIf(.Item("create_date") Is DBNull.Value, gWs.GetSysTime(), .Item("create_date"))
                Me.txtAffirmTerminatePerson.Text = IIf(.Item("create_person") Is DBNull.Value, UserName, .Item("create_person"))
                Me.txtAffirmTerminateOpinion.Text = IIf(.Item("content") Is DBNull.Value, "", .Item("content"))
            End With
        Else
            Me.dtpAffirmTerminateTime.Value = gWs.GetSysTime()
            Me.txtAffirmTerminatePerson.Text = UserName
        End If

        AddHandler dtpAffirmTerminateTime.TextChanged, AddressOf DataChanged
        AddHandler txtAffirmTerminateOpinion.TextChanged, AddressOf DataChanged
        '避免bIsChanged由于TabPage切换时ComboBox不必要的初始化而改变
        RemoveHandler cboTerminate_type.SelectedIndexChanged, AddressOf DataChanged
        RemoveHandler cboDepCheckConclusion.SelectedIndexChanged, AddressOf DataChanged
    End Sub

    Protected Overrides Function SaveData() As Boolean
        Try
            DStemp = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "' and item_type='56' and item_code='002'}")
            If Not DStemp.Tables(0).Rows.Count = 0 Then
                With DStemp.Tables(0).Rows(0)
                    .Item("content") = Me.txtAffirmTerminateOpinion.Text.Trim()
                End With
            Else
                Dim dr As DataRow = DStemp.Tables(0).NewRow()
                With dr
                    .Item("project_code") = Me.getProjectCode()
                    .Item("item_type") = "56"
                    .Item("item_code") = "002"
                    .Item("content") = Me.txtAffirmTerminateOpinion.Text.Trim()
                    .Item("create_date") = Me.dtpAffirmTerminateTime.Value
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
            strResult = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), "", UserName)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "确认项目终止报告")
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


End Class
