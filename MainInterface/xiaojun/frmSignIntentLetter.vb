Public Class frmSignIntentLetter
    Inherits frmEnterPriseIntent

    Private ds, TempDS As New DataSet()
    '记录当前窗口操作状态，1 表示当前执行新增操作，2 表示当前执行修改操作。
    'Private intOperateStatus As Integer = 0
    'Private arrIntentCode As New ArrayList()
    'Private intSearchIndex As Integer
    'Private intTrialTimes, intIntentAccount As Integer
    Private strConferenceTrial As String = "同意"
    Private strUpdateResult As String
    Private strBankCode, strBranchBankCode As String

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
    Friend WithEvents btnSearchTrial As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnSearchTrial = New System.Windows.Forms.Button()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Text = "签发(&S)"
        Me.btnSave.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Visible = True
        '
        'Label19
        '
        Me.Label19.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Visible = True
        '
        'dtpSignDate
        '
        Me.dtpSignDate.TabIndex = 0
        Me.dtpSignDate.Value = New Date(2003, 4, 8, 10, 21, 43, 344)
        Me.dtpSignDate.Visible = True
        '
        'Label15
        '
        Me.Label15.Visible = True
        '
        'Label14
        '
        Me.Label14.Visible = True
        '
        'txtBankReplyTerms
        '
        Me.txtBankReplyTerms.Visible = True
        '
        'txtBankReplyAverageSum
        '
        Me.txtBankReplyAverageSum.Visible = True
        '
        'cmbBankReplyRefundType
        '
        Me.cmbBankReplyRefundType.Visible = True
        '
        'Label85
        '
        Me.Label85.Visible = True
        '
        'btnEdit
        '
        Me.btnEdit.TabIndex = 3
        Me.btnEdit.Text = "修改(&E)"
        Me.btnEdit.Visible = True
        '
        'cmbBankRelapseOpinion
        '
        Me.cmbBankRelapseOpinion.Visible = True
        '
        'dtpBankRelapseDate
        '
        Me.dtpBankRelapseDate.Visible = True
        '
        'TabControl1
        '
        Me.TabControl1.ItemSize = New System.Drawing.Size(72, 17)
        Me.TabControl1.Visible = True
        '
        'txtBankVouchAccount
        '
        Me.txtBankVouchAccount.Visible = True
        '
        'cmbSignOpinion
        '
        Me.cmbSignOpinion.ItemHeight = 12
        Me.cmbSignOpinion.TabIndex = 1
        Me.cmbSignOpinion.Visible = True
        '
        'btnAdd
        '
        Me.btnAdd.TabIndex = 2
        Me.btnAdd.Visible = True
        '
        'TabPage1
        '
        Me.TabPage1.Text = "签发信息"
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'btnSearchTrial
        '
        Me.btnSearchTrial.Location = New System.Drawing.Point(272, 488)
        Me.btnSearchTrial.Name = "btnSearchTrial"
        Me.btnSearchTrial.Size = New System.Drawing.Size(120, 24)
        Me.btnSearchTrial.TabIndex = 13
        Me.btnSearchTrial.Text = "查看评审会信息(&R)"
        '
        'frmSignIntentLetter
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(578, 519)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabControl1, Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.btnSearchTrial})
        Me.Name = "frmSignIntentLetter"
        Me.Text = "签发意向书"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected Overrides Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ds = gWs.GetIntentLetterInfo("{intent_code=" & Me.intSearchIndex & "}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            If Not ds.Tables(0).Rows(0).Item("bank_reply") Is System.DBNull.Value Or ds.Tables(0).Rows(0).Item("bank_reply") <> "" Then
                MessageBox.Show("该担保意向书已经存在银行回复，无法进行删除操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If
        End If
        If Me.cmbSignPerson.Text = "" Then
            MessageBox.Show("该担保意向书没有签发，不能执行签发信息删除操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            If MessageBox.Show("是否确认删除该签发信息？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                TempDS = gWs.GetIntentLetterInfo("{intent_code=" & Me.intSearchIndex & "}")
                If Not TempDS.Tables(0).Rows.Count = 0 Then
                    With TempDS.Tables(0).Rows(0)
                        .Item("sign_date") = gWs.GetSysTime()
                        .Item("sign_person") = System.DBNull.Value
                        .Item("sign_opinion") = System.DBNull.Value
                    End With
                    Me.strUpdateResult = gWs.UpdateIntentLetter(TempDS, Nothing)
                    If Me.strUpdateResult = "1" Then
                        MessageBox.Show("签发信息已经删除成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("签发信息已经删除失败：" + Me.strUpdateResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    Call Me.GetIniData(Me.strProjectCode, Me.strConferenceTrial)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Protected Overrides Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Call Me.btnSaveClickEvent()
        If Me.isCommitConfirm = True Then
            If MessageBox.Show("是否确认提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If
        End If
        If Me.cmbSignOpinion.Text = "" Then
            MessageBox.Show("没有对应的签发意见。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbSignOpinion.Focus()
            Return
        End If
        Try
            If Me.bIsTextChange Then
                Call Me.SaveData()
                'Me.bIsFormLoad = False : Me.bIsTextChange = False
            End If
            Dim Opinion As String
            ds = gWs.GetIntentLetterInfo("{project_code ='" & Me.strProjectCode & "' order by intent_code desc}")
            If Not ds.Tables(0).Rows.Count = 0 Then
                If Not ds.Tables(0).Rows(0).Item("sign_opinion") Is System.DBNull.Value Then
                    Opinion = ds.Tables(0).Rows(0).Item("sign_opinion")
                Else
                    Opinion = ""
                End If
            End If
            Call Me.CommitWorkFlow(Opinion, Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub frmSignIntentLetter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Call Me.GetSignOpinion()
            Me.btnAdd.Enabled = False
            Me.btnEdit.Enabled = False
            Me.btnSave.Enabled = True
            'Me.GroupBox3.Enabled = False
            Me.dtpSignDate.Enabled = True
            Me.cmbSignOpinion.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Protected Overrides Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If Me.dgIntentLetter.CurrentRowIndex <> CType(Me.dgIntentLetter.DataSource, DataView).Count - 1 Then
        If Not Me.IsLastIntentLetter(Me.intSearchIndex) Then
            MessageBox.Show("您只能对最后一条签发意见进行修改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        Call Me.btnSaveClickEvent()
        Me.dtpSignDate.Enabled = True
        Me.cmbSignOpinion.Enabled = True
        Me.btnAdd.Enabled = False
        Me.btnEdit.Enabled = False
        Me.btnSave.Enabled = True
    End Sub

    Private Sub btnSaveClickEvent()
        If Me.intSearchIndex = 0 Then
            MessageBox.Show("请选择相应的担保意向书进行操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.dgIntentLetter.Focus()
            Return
        End If
        If Not Me.IsLastIntentLetter(Me.intSearchIndex) Then
            MessageBox.Show("您只能对最后一条签发意见进行修改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        If Me.cmbSignOpinion.Text = "" Then
            MessageBox.Show("请选择签发意见进行操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbSignOpinion.Focus()
            Return
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Call Me.SaveData()
            Call Me.LockContral(GroupBox3)
            Me.intOperateStatus = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    '根据相应任务保存相应数据，此函数需要重载。
    Private Sub SaveData()
        '获得选定的intent_code的数据记录进行修改操作。
        ds = gWs.GetIntentLetterInfo("{intent_code=" & Me.intSearchIndex & "}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                .Item("sign_date") = Me.dtpSignDate.Value
                .Item("sign_person") = Me.strUserID
                .Item("sign_opinion") = Me.cmbSignOpinion.Text.Trim()
            End With
            Me.strUpdateResult = gWs.UpdateIntentLetter(ds, Nothing)
            If Me.strUpdateResult = "1" Then
                MessageBox.Show("签发操作成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("签发操作失败：" + Me.strUpdateResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            Call Me.GetIniData(Me.strProjectCode, Me.intSearchIndex)
            '显示当前intent_code为最大的记录信息。
            Call Me.ShowSpecialData(Me.intSearchIndex)
        End If
        Me.bIsFormLoad = False : Me.bIsTextChange = False
    End Sub

    Private Sub GetSignOpinion()
        ds = Me.GetFinishedFlag(Me.strWorkFlowID, Me.strProjectCode, Me.strTaskID)
        If Not ds.Tables(0).Rows.Count = 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Me.cmbSignOpinion.Items.Add(ds.Tables(0).Rows(i).Item("transfer_condition"))
            Next
        End If
    End Sub

    Protected Overrides Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MsgResult As MsgBoxResult
        Try
            If Me.bIsTextChange Then
                MsgResult = MessageBox.Show("是否保存对数据进行的修改？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            Else
                Me.Close()
                Me.bIsFormLoad = False : Me.bIsTextChange = False
            End If
            If MsgResult = MsgBoxResult.Yes Then
                Call Me.SaveData()
                Me.bIsFormLoad = False : Me.bIsTextChange = False
            End If
            If MsgResult = MsgBoxResult.No Then Me.Close() : Me.bIsFormLoad = False : Me.bIsTextChange = False
            If MsgResult = MsgBoxResult.Cancel Then Return
        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub btnSearchTrial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchTrial.Click
        Dim frm As New frmMeetRecordQuery(Me.strProjectCode, Me.strEnterpriseName)
        frm.AllowTransparency = False
        frm.ShowDialog()
    End Sub
End Class
