

Public Class frmSignVouchApplication
    Inherits MainInterface.frmVouchApplication

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
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents dtpSignVouchDate As System.Windows.Forms.DateTimePicker
    Public WithEvents txtSignVouchPeople As System.Windows.Forms.TextBox
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents cmbSignVouchOpinion As System.Windows.Forms.ComboBox
    Public WithEvents Label110 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSignVouchApplication))
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmbSignVouchOpinion = New System.Windows.Forms.ComboBox()
        Me.txtSignVouchPeople = New System.Windows.Forms.TextBox()
        Me.dtpSignVouchDate = New System.Windows.Forms.DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label110 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.grpLoanNotice.SuspendLayout()
        CType(Me.dgLoanNotice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(488, 72)
        '
        'btnViewAffirmContent
        '
        Me.btnViewAffirmContent.Image = CType(resources.GetObject("btnViewAffirmContent.Image"), System.Drawing.Bitmap)
        Me.btnViewAffirmContent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewAffirmContent.ImageIndex = 27
        Me.btnViewAffirmContent.ImageList = Me.ImageListBasic
        Me.btnViewAffirmContent.Location = New System.Drawing.Point(65, 496)
        Me.btnViewAffirmContent.Size = New System.Drawing.Size(96, 23)
        Me.btnViewAffirmContent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnViewAffirmContent.Visible = True
        '
        'Label6
        '
        Me.Label6.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(8, 312)
        Me.GroupBox2.Size = New System.Drawing.Size(640, 96)
        Me.GroupBox2.Visible = True
        '
        'grpLoanNotice
        '
        Me.grpLoanNotice.Location = New System.Drawing.Point(8, 184)
        Me.grpLoanNotice.Size = New System.Drawing.Size(640, 120)
        Me.grpLoanNotice.Visible = True
        '
        'Label7
        '
        Me.Label7.Visible = True
        '
        'dgLoanNotice
        '
        Me.dgLoanNotice.AccessibleName = "DataGrid"
        Me.dgLoanNotice.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgLoanNotice.Size = New System.Drawing.Size(634, 100)
        Me.dgLoanNotice.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(145, 496)
        Me.btnSave.Size = New System.Drawing.Size(0, 0)
        Me.btnSave.TabIndex = 2
        Me.btnSave.TabStop = False
        Me.btnSave.Visible = True
        '
        'Label8
        '
        Me.Label8.Visible = True
        '
        'cmbVouchTerms
        '
        Me.cmbVouchTerms.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbVouchTerms.ReadOnly = True
        Me.cmbVouchTerms.Visible = True
        '
        'cmbVouchAccount
        '
        Me.cmbVouchAccount.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbVouchAccount.ReadOnly = True
        Me.cmbVouchAccount.Visible = True
        '
        'cmbRefundType
        '
        Me.cmbRefundType.ItemHeight = 12
        Me.cmbRefundType.Location = New System.Drawing.Point(112, 70)
        Me.cmbRefundType.Visible = True
        '
        'cmbVouchBranchBank
        '
        Me.cmbVouchBranchBank.DropDownWidth = 160
        Me.cmbVouchBranchBank.Enabled = False
        Me.cmbVouchBranchBank.ItemHeight = 12
        Me.cmbVouchBranchBank.Visible = True
        '
        'cmbVouchBank
        '
        Me.cmbVouchBank.Enabled = False
        Me.cmbVouchBank.ItemHeight = 12
        Me.cmbVouchBank.Visible = True
        '
        'dtpVouchDate
        '
        Me.dtpVouchDate.Location = New System.Drawing.Point(464, 64)
        Me.dtpVouchDate.Value = New Date(2003, 4, 12, 15, 30, 56, 502)
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(8, 496)
        Me.btnAdd.Size = New System.Drawing.Size(16, 0)
        '
        'Label5
        '
        Me.Label5.Visible = True
        '
        'Label4
        '
        Me.Label4.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Size = New System.Drawing.Size(640, 152)
        Me.GroupBox1.Visible = True
        '
        'btnUploadReport
        '
        Me.btnUploadReport.Image = CType(resources.GetObject("btnUploadReport.Image"), System.Drawing.Bitmap)
        Me.btnUploadReport.Location = New System.Drawing.Point(171, 496)
        Me.btnUploadReport.Size = New System.Drawing.Size(128, 23)
        Me.btnUploadReport.TabIndex = 0
        Me.btnUploadReport.Text = "查看放款申请书(&M)"
        Me.btnUploadReport.Visible = True
        '
        'dgDatum
        '
        Me.dgDatum.Size = New System.Drawing.Size(634, 132)
        Me.dgDatum.Visible = True
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Image = CType(resources.GetObject("btnConferenceTrial.Image"), System.Drawing.Bitmap)
        Me.btnConferenceTrial.Location = New System.Drawing.Point(309, 496)
        Me.btnConferenceTrial.TabIndex = 1
        Me.btnConferenceTrial.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.Location = New System.Drawing.Point(431, 496)
        Me.btnCommit.TabIndex = 3
        Me.btnCommit.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Size = New System.Drawing.Size(384, 21)
        Me.txtEnterpriseName.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(518, 496)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Visible = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbSignVouchOpinion, Me.txtSignVouchPeople, Me.dtpSignVouchDate, Me.Label11, Me.Label10, Me.Label110})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 416)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(640, 72)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "签发放款通知书"
        '
        'cmbSignVouchOpinion
        '
        Me.cmbSignVouchOpinion.Location = New System.Drawing.Point(112, 46)
        Me.cmbSignVouchOpinion.Name = "cmbSignVouchOpinion"
        Me.cmbSignVouchOpinion.Size = New System.Drawing.Size(176, 20)
        Me.cmbSignVouchOpinion.TabIndex = 12
        '
        'txtSignVouchPeople
        '
        Me.txtSignVouchPeople.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSignVouchPeople.Location = New System.Drawing.Point(424, 22)
        Me.txtSignVouchPeople.Name = "txtSignVouchPeople"
        Me.txtSignVouchPeople.ReadOnly = True
        Me.txtSignVouchPeople.Size = New System.Drawing.Size(176, 21)
        Me.txtSignVouchPeople.TabIndex = 11
        Me.txtSignVouchPeople.Text = ""
        '
        'dtpSignVouchDate
        '
        Me.dtpSignVouchDate.Location = New System.Drawing.Point(112, 22)
        Me.dtpSignVouchDate.Name = "dtpSignVouchDate"
        Me.dtpSignVouchDate.Size = New System.Drawing.Size(176, 21)
        Me.dtpSignVouchDate.TabIndex = 10
        Me.dtpSignVouchDate.Value = New Date(2003, 10, 28, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(24, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 16)
        Me.Label11.TabIndex = 9
        Me.Label11.Text = "签发意见"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(320, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 16)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "签发人"
        '
        'Label110
        '
        Me.Label110.Location = New System.Drawing.Point(24, 24)
        Me.Label110.Name = "Label110"
        Me.Label110.Size = New System.Drawing.Size(56, 16)
        Me.Label110.TabIndex = 5
        Me.Label110.Text = "签发日期"
        '
        'frmSignVouchApplication
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(660, 527)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnAdd, Me.btnViewAffirmContent, Me.btnSave, Me.grpLoanNotice, Me.btnConferenceTrial, Me.btnUploadReport, Me.GroupBox2, Me.btnCommit, Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.GroupBox1, Me.GroupBox3})
        Me.Name = "frmSignVouchApplication"
        Me.Text = "签发放款通知书"
        Me.GroupBox2.ResumeLayout(False)
        Me.grpLoanNotice.ResumeLayout(False)
        CType(Me.dgLoanNotice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ds As DataSet
    Private strUpdateResult As String

    Protected bIsFormLoad As Boolean = False
    Protected bIsTextChange As Boolean = False

    Private BankCode, BranchBankCode As String

    Private Sub frmSignVouchApplication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Call Me.GetSignVouchApplicationData()
            Call Me.GetSignVouchApplicationOpinion()
            Me.cmbVouchBank.Enabled = False : Me.cmbVouchBranchBank.Enabled = False
            Me.cmbVouchTerms.Enabled = False
            Me.bIsFormLoad = True
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub GetSignVouchApplicationData()
        ds = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.strProjectCode & "' and item_type='54' and item_code='001'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            ds.Tables(0).DefaultView.Sort = "serial_num DESC"
            With ds.Tables(0).DefaultView.Item(0)
                If Not .Item("create_date") Is System.DBNull.Value Then
                    Me.dtpSignVouchDate.Value = .Item("create_date")
                Else
                    Me.dtpSignVouchDate.Value = gWs.GetSysTime()
                End If
                If Not .Item("create_person") Is System.DBNull.Value Then
                    Me.txtSignVouchPeople.Text = .Item("create_person")
                Else
                    Me.txtSignVouchPeople.Text = ""
                End If
                If Not .Item("conclusion") Is System.DBNull.Value Then
                    Me.cmbSignVouchOpinion.Text = .Item("conclusion")
                Else
                    Me.cmbSignVouchOpinion.Text = ""
                End If
            End With
        Else
            Me.dtpSignVouchDate.Value = gWs.GetSysTime()
            Me.txtSignVouchPeople.Text = Me.strUserID
            Me.cmbSignVouchOpinion.Text = ""
        End If
    End Sub

    Private Function GetBankName(ByVal BankCode As String, ByVal BranchBankCode As String) As String
        Dim TempDS As DataSet
        If BranchBankCode = Nothing Then    '取得银行名称。
            TempDS = gWs.GetBankInfo("{bank_code='" & BankCode & "'}", "null")
            If Not TempDS.Tables(0).Rows(0).Item("bank_name") Is System.DBNull.Value Then
                Return TempDS.Tables(0).Rows(0).Item("bank_name")
            End If
        Else    '取得银行支行名称
            TempDS = gWs.GetBankInfo("null", "{bank_code='" & BankCode & "' and branch_bank_code='" & BranchBankCode & "'}")
            If Not TempDS.Tables(1).Rows(0).Item("branch_bank_name") Is System.DBNull.Value Then
                Return TempDS.Tables(1).Rows(0).Item("branch_bank_name")
            End If
        End If
    End Function

    Private Sub GetSignVouchApplicationOpinion()
        Dim TempDs As DataSet
        Me.cmbSignVouchOpinion.Items.Clear()
        TempDs = Me.GetFinishedFlag(Me.strWorkFlowID, Me.strProjectCode, Me.strTaskID)
        If Not TempDs Is Nothing Then
            For i = 0 To TempDs.Tables(0).Rows.Count - 1
                Me.cmbSignVouchOpinion.Items.Add(TempDs.Tables(0).Rows(i).Item("transfer_condition"))
            Next
        End If
    End Sub

    Protected Sub SignVouchApplicationLockContral()
        Me.dtpSignVouchDate.Enabled = False
        Me.cmbSignVouchOpinion.Enabled = False
        Me.txtSignVouchPeople.Enabled = False
    End Sub

    Protected Overrides Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.isCommitConfirm = True Then
            'If MessageBox.Show("是否确认提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            If SWDialogBox.MessageBox.Show("?1000", "提交") = DialogResult.No Then
                Return
            End If
        End If
        If Me.cmbSignVouchOpinion.Text = "" Then
            'MessageBox.Show("请选择签发意见。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1001", "签发意见")
            Me.cmbSignVouchOpinion.Focus()
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        Try
            Dim notice_code As Object = Me.dgLoanNotice.Item(Me.dsLoanNotice.Tables(0).Rows.Count - 1, 0)
            ds = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.strProjectCode & "' AND item_type='54' AND item_code='001' AND file_relation_num=" & notice_code & "}")
            If ds.Tables(0).Rows.Count = 0 Then
                Dim dr As DataRow = ds.Tables(0).NewRow
                With dr
                    .Item("project_code") = Me.strProjectCode
                    .Item("item_type") = "54"
                    .Item("item_code") = "001"
                    .Item("conclusion") = Me.cmbSignVouchOpinion.Text.Trim()
                    .Item("create_date") = Me.dtpSignVouchDate.Value
                    .Item("create_person") = Me.txtSignVouchPeople.Text
                    .Item("file_relation_num") = notice_code
                End With
                ds.Tables(0).Rows.Add(dr)
            Else
                With ds.Tables(0).Rows(0)
                    .Item("project_code") = Me.strProjectCode
                    .Item("item_type") = "54"
                    .Item("item_code") = "001"
                    .Item("conclusion") = Me.cmbSignVouchOpinion.Text.Trim()
                    .Item("create_date") = Me.dtpSignVouchDate.Value
                    .Item("create_person") = Me.txtSignVouchPeople.Text
                End With
            End If

            Me.strUpdateResult = gWs.UpdateProjectOpinion(ds)
            If Me.strUpdateResult = "1" Then
                '''MessageBox.Show("保存放款通知书成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ds.Dispose()
                Me.bIsTextChange = False : Me.bIsFormLoad = False
            Else
                'MessageBox.Show("保存放款通知书失败：" + Me.strUpdateResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SWDialogBox.MessageBox.Show("*999", "frmSignVouchApplication.btnCommit_Click", Me.strUpdateResult, "gWs.UpdateProject(ds)")
                Return
            End If

            '修改放款信息loan_notice表中的记录
            ds = gWs.GetLoanNoticeInfo("{project_code='" & Me.strProjectCode & "' and affirm_date is null }")
            If Not ds.Tables(0).Rows.Count = 0 Then
                With ds.Tables(0).Rows(0)
                    .Item("affirm_date") = gWs.GetSysTime().Date
                    .Item("affirm_person") = UserName
                End With
                Me.strUpdateResult = gWs.UpdateLoanNotice(ds)
                If Me.strUpdateResult = "1" Then
                    ds.Dispose()
                Else
                    SWDialogBox.MessageBox.Show("*999", "修改失败", Me.strUpdateResult, "")
                    Return
                End If
            End If

            Call Me.CommitWorkFlow(Me.cmbSignVouchOpinion.Text.Trim(), Me)
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub dtpSignVouchDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpSignVouchDate.TextChanged
        If Me.bIsFormLoad Then Me.bIsTextChange = True
    End Sub

    Private Sub cmbSignVouchOpinion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSignVouchOpinion.TextChanged
        If Me.bIsFormLoad Then Me.bIsTextChange = True
    End Sub

    Protected Overrides Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dlgResult As MsgBoxResult
        If Me.bIsTextChange Then
            'dlgResult = MessageBox.Show("是否保存对数据的修改？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            dlgResult = SWDialogBox.MessageBox.Show("?1003")
            If dlgResult = MsgBoxResult.Yes Then
                If Me.cmbSignVouchOpinion.Text = "" Then
                    'MessageBox.Show("请选择签发意见。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    SWDialogBox.MessageBox.Show("$1001", "签发意见")
                    Me.cmbSignVouchOpinion.Focus()
                    Return
                End If
                Try
                    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                    ds = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.strProjectCode & "' and item_type='54' and item_code='001'}")
                    If ds.Tables(0).Rows.Count = 0 Then
                        ds = gWs.GetProjectOpinionByProjectNo("null")
                        Dim NewRow As DataRow = ds.Tables(0).NewRow
                        With NewRow
                            .Item("project_code") = Me.strProjectCode
                            .Item("item_type") = "54"
                            .Item("item_code") = "001"
                            .Item("conclusion") = Me.cmbSignVouchOpinion.Text.Trim()
                            .Item("create_date") = Me.dtpSignVouchDate.Value
                            .Item("create_person") = Me.txtSignVouchPeople.Text
                        End With
                        ds.Tables(0).Rows.Add(NewRow)
                    Else
                        With ds.Tables(0).Rows(0)
                            .Item("project_code") = Me.strProjectCode
                            .Item("item_type") = "54"
                            .Item("item_code") = "001"
                            .Item("conclusion") = Me.cmbSignVouchOpinion.Text.Trim()
                            .Item("create_date") = Me.dtpSignVouchDate.Value
                            .Item("create_person") = Me.txtSignVouchPeople.Text
                        End With
                    End If

                    Me.strUpdateResult = gWs.UpdateProjectOpinion(ds)
                    If Me.strUpdateResult = "1" Then
                        ds.Dispose()
                        SWDialogBox.MessageBox.Show("$OperateSucceed")
                        'MessageBox.Show("保存放款通知书成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.Close()
                        Me.bIsTextChange = False : Me.bIsFormLoad = False
                    Else
                        'MessageBox.Show("保存放款通知书失败：" + Me.strUpdateResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SWDialogBox.MessageBox.Show("*999", "frmSignVouchApplication", Me.strUpdateResult, "gWs.UpdateProjectOpinion(ds)")
                    End If

                Catch ex As Exception
                    SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
                Finally
                    Me.Cursor = System.Windows.Forms.Cursors.Default
                End Try
            ElseIf dlgResult = MsgBoxResult.No Then
                Me.Close() : Me.bIsFormLoad = False : Me.bIsTextChange = False
            ElseIf dlgResult = MsgBoxResult.Cancel Then
                Return
            End If
        Else
            Me.Close()
            Me.bIsFormLoad = False : Me.bIsTextChange = False
        End If
    End Sub

    '鼠标选中datagrid中的项，设置下面的控件
    Protected Overrides Sub dgLoanNotice_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim currentRow As Integer = Me.dgLoanNotice.CurrentRowIndex
        Me.dgLoanNotice.Select(currentRow)

        Me.cmbVouchBank.Text = Me.dgLoanNotice.Item(currentRow, 1)
        Me.cmbVouchBranchBank.Text = Me.dgLoanNotice.Item(currentRow, 2)
        Me.cmbVouchAccount.Text = Me.dgLoanNotice.Item(currentRow, 3)
        Me.cmbVouchTerms.Text = Me.dgLoanNotice.Item(currentRow, 4)

        If currentRow = Me.dsLoanNotice.Tables(0).Rows.Count - 1 Then
            Me.GroupBox2.Text = "当前的放款信息"
        Else
            Me.GroupBox2.Text = "已有的放款信息"
        End If
    End Sub

    Private Sub cmbSignVouchOpinion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSignVouchOpinion.SelectedIndexChanged
        Me.dgLoanNotice(Me.dsLoanNotice.Tables(0).Rows.Count - 1, 9) = cmbSignVouchOpinion.Text
    End Sub
End Class
