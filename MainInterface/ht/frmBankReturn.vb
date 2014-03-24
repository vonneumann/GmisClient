Public Class frmBankReturn
    Inherits frmEnterPriseIntent

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBankReturn))
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgIntentLetter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpSignDate
        '
        Me.dtpSignDate.Value = New Date(2003, 4, 7, 10, 7, 15, 374)
        Me.dtpSignDate.Visible = True
        '
        'txtReturnType
        '
        Me.txtReturnType.Visible = True
        '
        'Label18
        '
        Me.Label18.Visible = True
        '
        'Label20
        '
        Me.Label20.Visible = True
        '
        'Label21
        '
        Me.Label21.Visible = True
        '
        'Label3
        '
        Me.Label3.Visible = True
        '
        'Label4
        '
        Me.Label4.Visible = True
        '
        'Label6
        '
        Me.Label6.Visible = True
        '
        'Label5
        '
        Me.Label5.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageIndex = -1
        Me.btnSave.ImageList = Nothing
        Me.btnSave.Location = New System.Drawing.Point(460, 368)
        Me.btnSave.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageIndex = -1
        Me.btnCommit.ImageList = Nothing
        Me.btnCommit.Location = New System.Drawing.Point(207, 461)
        Me.btnCommit.Visible = True
        '
        'Label7
        '
        Me.Label7.Visible = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Visible = True
        '
        'Label16
        '
        Me.Label16.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageIndex = -1
        Me.btnDelete.ImageList = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(377, 368)
        Me.btnDelete.Visible = True
        '
        'Label13
        '
        Me.Label13.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Visible = True
        '
        'TabControl1
        '
        Me.TabControl1.ItemSize = New System.Drawing.Size(72, 17)
        Me.TabControl1.Visible = True
        '
        'Label11
        '
        Me.Label11.Visible = True
        '
        'Label10
        '
        Me.Label10.Visible = True
        '
        'txtBankReplyTerms
        '
        Me.txtBankReplyTerms.ReadOnly = False
        Me.txtBankReplyTerms.Visible = True
        '
        'txtBankReplyAverageSum
        '
        Me.txtBankReplyAverageSum.ReadOnly = False
        Me.txtBankReplyAverageSum.Visible = True
        '
        'cmbBankReplyRefundType
        '
        Me.cmbBankReplyRefundType.Enabled = True
        Me.cmbBankReplyRefundType.Visible = True
        '
        'txtAverageRefundSum
        '
        Me.txtAverageRefundSum.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Image = CType(resources.GetObject("btnPrint.Image"), System.Drawing.Bitmap)
        Me.btnPrint.ImageIndex = -1
        Me.btnPrint.ImageList = Nothing
        Me.btnPrint.Location = New System.Drawing.Point(192, 368)
        Me.btnPrint.Text = "查看文档(&P)"
        Me.btnPrint.Visible = True
        '
        'cmbBankRelapseOpinion
        '
        Me.cmbBankRelapseOpinion.Visible = True
        '
        'dtpBankRelapseDate
        '
        Me.dtpBankRelapseDate.Visible = True
        '
        'txtBankVouchAccount
        '
        Me.txtBankVouchAccount.Visible = True
        '
        'cmbSignOpinion
        '
        Me.cmbSignOpinion.ItemHeight = 12
        Me.cmbSignOpinion.Visible = True
        '
        'TabPage1
        '
        Me.TabPage1.Text = "银行回复意见"
        '
        'dgIntentLetter
        '
        Me.dgIntentLetter.AccessibleName = "DataGrid"
        Me.dgIntentLetter.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgIntentLetter.Visible = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(48, 368)
        Me.btnPrevious.Size = New System.Drawing.Size(0, 0)
        Me.btnPrevious.TabStop = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(80, 368)
        Me.btnNext.Size = New System.Drawing.Size(0, 0)
        Me.btnNext.TabStop = False
        '
        'cmbSignPerson
        '
        Me.cmbSignPerson.ItemHeight = 12
        '
        'btnAdd
        '
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Bitmap)
        Me.btnAdd.ImageIndex = -1
        Me.btnAdd.ImageList = Nothing
        Me.btnAdd.Location = New System.Drawing.Point(120, 368)
        Me.btnAdd.Size = New System.Drawing.Size(0, 0)
        Me.btnAdd.TabStop = False
        Me.btnAdd.Visible = True
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Bitmap)
        Me.btnEdit.ImageIndex = -1
        Me.btnEdit.ImageList = Nothing
        Me.btnEdit.Location = New System.Drawing.Point(294, 368)
        Me.btnEdit.Visible = True
        '
        'cmbLoanVouchBank
        '
        Me.cmbLoanVouchBank.ItemHeight = 12
        Me.cmbLoanVouchBank.Visible = True
        '
        'txtVouchAccount
        '
        Me.txtVouchAccount.Visible = True
        '
        'Label9
        '
        Me.Label9.Visible = True
        '
        'cmbLoanVouchBranchBank
        '
        Me.cmbLoanVouchBranchBank.ItemHeight = 12
        Me.cmbLoanVouchBranchBank.Size = New System.Drawing.Size(152, 20)
        Me.cmbLoanVouchBranchBank.Visible = True
        '
        'Label8
        '
        Me.Label8.Visible = True
        '
        'txtVouchDeadline
        '
        Me.txtVouchDeadline.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(291, 461)
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'frmBankReturn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(578, 490)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCommit, Me.TabControl1, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.btnExit})
        Me.MinimizeBox = False
        Me.Name = "frmBankReturn"
        Me.Text = "银行回复"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgIntentLetter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ds, TempDS As DataSet
    '记录当前窗口操作状态，1 表示当前执行新增操作，2 表示当前执行修改操作。
    'Private intOperateStatus As Integer = 0
    'Private arrIntentCode As New ArrayList()
    'Private intSearchIndex As Integer = 0
    'Private intTrialTimes, intIntentAccount As Integer
    Private strConferenceTrial As String = "通过"
    Private strUpdateResult As String
    Private strBankCode, strBranchBankCode As String

    Private Sub frmBankReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnAdd.Enabled = False
    End Sub

    Protected Overrides Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not Me.IsLastIntentLetter(Me.intSearchIndex) Then
            'MessageBox.Show("只能对最后一条担保意向进行操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$X001")
            Return
        End If
        If Me.cmbBankRelapseOpinion.Text.Trim() = "" Then
            'MessageBox.Show("该担保意向书没有对应银行回复，不能执行银行回复删除操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1001", "担保意向书")
            Return
        End If
        Try
            'If MessageBox.Show("是否确认删除该银行回复？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If SWDialogBox.MessageBox.Show("?1004", "银行回复") = DialogResult.Yes Then
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                TempDS = gWs.GetIntentLetterInfo("{intent_code=" & Me.intSearchIndex & "}")
                If Not TempDS.Tables(0).Rows.Count = 0 Then
                    With TempDS.Tables(0).Rows(0)
                        .Item("reply_date") = gWs.GetSysTime()
                        .Item("bank_reply") = System.DBNull.Value
                        .Item("reply_sum") = System.DBNull.Value
                        .Item("reply_term") = System.DBNull.Value
                        .Item("reply_refund_type") = System.DBNull.Value
                        .Item("reply_refund_sum_average") = System.DBNull.Value
                    End With
                    Me.strUpdateResult = gWs.UpdateIntentLetter(TempDS, Nothing)
                    If Me.strUpdateResult = "1" Then
                        'MessageBox.Show("银行回复已经删除成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        SWDialogBox.MessageBox.Show("$SaveSucceed")
                        Me.btnDelete.Enabled = False
                    Else
                        'MessageBox.Show("银行回复已经删除失败：" + Me.strUpdateResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        SWDialogBox.MessageBox.Show("*999", "frmBankReturn.btnDelete_Click.", Me.strUpdateResult, "gWs.UpdateIntentLetter(TempDS, Nothing)")
                    End If
                    Call Me.GetIniData(Me.strProjectCode, Me.strConferenceTrial)
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Protected Overrides Sub GetIntentReturnInfo()
        Call Me.LockContral(Me.GroupBox1)
        Call Me.LockContral(Me.GroupBox2)
        Call Me.LockContral(Me.GroupBox3)
        Call Me.GetBankReturnOpinion()
        Call Me.GetIniData(Me.strProjectCode, Me.strConferenceTrial)
        Call Me.GetRefundType()
    End Sub

    Private Sub GetRefundType()
        ds = gWs.GetRefundType("%")
        If Not ds.Tables(0).Rows.Count = 0 Then
            Me.cmbBankReplyRefundType.Items.Clear()
            For i = 0 To ds.Tables(0).Rows.Count - 1
                With ds.Tables(0).Rows(i)
                    Me.cmbBankReplyRefundType.Items.Add(.Item("refund_type"))
                End With
            Next
        End If
    End Sub

    '获得银行回复的意见。
    Private Sub GetBankReturnOpinion()
        Me.cmbBankRelapseOpinion.Items.Clear()
        TempDS = Me.GetFinishedFlag(Me.strWorkFlowID, Me.strProjectCode, Me.strTaskID)
        If Not TempDS Is Nothing Then
            For i = 0 To TempDS.Tables(0).Rows.Count - 1
                Me.cmbBankRelapseOpinion.Items.Add(TempDS.Tables(0).Rows(i).Item("transfer_condition"))
            Next
        End If
    End Sub

    Protected Overrides Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.dgIntentLetter.CurrentRowIndex <> CType(Me.dgIntentLetter.DataSource, DataView).Count - 1 Then
            'MessageBox.Show("您只能对最后一条银行回复记录进行修改。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$X002")
            Return
        End If
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call Me.btnEditClickEvent()
            Call Me.GetBankReturnOpinion()
            Me.btnAdd.Enabled = False
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnEditClickEvent()
        If Me.intOperateStatus = 0 Then
            Me.intOperateStatus = 1
            Call Me.FreeContral(Me.GroupBox1)
        ElseIf Me.intOperateStatus = 1 Then
            Me.intOperateStatus = 0
            Call Me.LockContral(Me.GroupBox1)
            Call Me.GetIniData(Me.strProjectCode, Me.strConferenceTrial)
        End If
    End Sub

    Protected Overrides Sub FreeContral(ByVal GroupBox As System.Windows.Forms.GroupBox)
        GroupBox.Enabled = True
        If GroupBox Is Me.GroupBox1 Then
            Me.dtpBankRelapseDate.Enabled = True
            Me.txtBankVouchAccount.Enabled = True
            Me.cmbBankRelapseOpinion.Enabled = True
            Me.txtBankReplyAverageSum.Enabled = True
            Me.txtBankReplyTerms.Enabled = True
            Me.cmbBankReplyRefundType.Enabled = True
        End If
        Me.btnDelete.Enabled = False
        Me.btnSave.Enabled = True : Me.btnPrevious.Enabled = False : Me.btnNext.Enabled = False
        If Me.intOperateStatus = 1 Then
            Me.btnEdit.Enabled = True
            Me.btnEdit.Text = "取 消(&N)"
        End If
        Me.dgIntentLetter.Enabled = False
    End Sub

    '调用了SendKeys(2, Me.txtBankVouchAccount.Text.Trim(), e)基类成员函数，主要用来限制用户在金额框输入时候只能输入数字，而不能输入其余的非数字字符。
    Private Sub txtBankVouchAccount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBankVouchAccount.KeyPress
        Call Me.SendKeys(2, Me.txtBankVouchAccount.Text.Trim(), e)
    End Sub

    'Private Function GetExistData() As String
    '    ds = gWs.GetIntentLetterInfo("{project_code='" & Me.strProjectCode & "'}")
    '    If ds.Tables(0).Rows.Count = 0 Then
    '        'MessageBox.Show("没有可供修改的担保意向书", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        SWDialogBox.MessageBox.Show("$1001", "担保意向书")
    '        Return "1"
    '    End If
    'End Function

    Protected Overrides Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Call Me.btnSaveClickEvent()
        Me.btnAdd.Enabled = False
    End Sub

    Private Sub btnSaveClickEvent()
        If Me.intSearchIndex = 0 Then
            'MessageBox.Show("请选择相应的担保意向书进行操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1001", "担保意向书")
            Me.dgIntentLetter.Focus()
            Return
        End If
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If Me.SaveData() = 1 Then
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Return
            End If
            Call Me.LockContral(GroupBox1)
            Me.intOperateStatus = 0
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private _isDisplayDialog As Boolean = True   '用于判断调用SaveData方法的按钮
    '根据相应任务保存相应数据，此函数需要重载。
    Private Function SaveData() As Integer
        If Me.cmbBankRelapseOpinion.Text = "" Then
            'MessageBox.Show("没有选择银行回复意见进行操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("$1001", "银行回复意见")
            Me.cmbBankRelapseOpinion.Focus()
            Return 1
        End If
        If Me.txtBankVouchAccount.Text = "" Then
            'MessageBox.Show("没有选择银行回复担保金额进行操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("$1001", "银行回复担保金额")
            Me.txtBankVouchAccount.Focus()
            Return 1
        End If
        If Me.txtBankReplyTerms.Text = "" Then
            'MessageBox.Show("没有填写银行回复担保期限。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("$1001", "银行回复担保期限")
            Me.txtBankReplyTerms.Focus()
            Return 1
        End If
        If Me.cmbBankReplyRefundType.Text = "" And Me.cmbBankRelapseOpinion.Text.Trim() = "同意" Then
            'MessageBox.Show("没有填写银行回复还款方式。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("$1001", "银行回复还款方式")
            Me.txtBankReplyTerms.Focus()
            Return 1
        End If
        If Me.txtBankReplyAverageSum.Text = "" Then
            'MessageBox.Show("没有填写银行同意每次担保金额。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("$1001", "银行同意每次担保金额")
            Me.txtBankReplyAverageSum.Focus()
            Return 1
        End If
        '获得选定的intent_code的数据记录进行修改操作。
        ds = gWs.GetIntentLetterInfo("{intent_code=" & Me.intSearchIndex & "}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                .Item("bank_reply") = Me.cmbBankRelapseOpinion.Text.Trim()
                .Item("reply_sum") = Convert.ToDecimal(Me.txtBankVouchAccount.Text)
                .Item("reply_date") = Me.dtpBankRelapseDate.Value
                .Item("reply_term") = Convert.ToDecimal(Me.txtBankReplyTerms.Text.Trim())
                .Item("reply_refund_sum_average") = Convert.ToDecimal(Me.txtBankReplyAverageSum.Text.Trim())
                If Me.cmbBankRelapseOpinion.Text.Trim() = "不同意" Then
                    .Item("reply_refund_type") = System.DBNull.Value
                Else
                    .Item("reply_refund_type") = Me.cmbBankReplyRefundType.Text.Trim()
                End If
            End With
            Me.strUpdateResult = gWs.UpdateIntentLetter(ds, Nothing)
            If Me.strUpdateResult = "1" Then
                If _isDisplayDialog Then
                    SWDialogBox.MessageBox.Show("$SaveSucceed")
                End If
            Else
                'MessageBox.Show("保存失败：" + Me.strUpdateResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SWDialogBox.MessageBox.Show("*999", "frmBankReturn.SaveData", Me.strUpdateResult, "gWs.UpdateIntentLetter(ds, Nothing)")
            End If
            Call Me.GetIniData(Me.strProjectCode, Me.intSearchIndex)
            '显示当前intent_code为最大的记录信息。
            Call Me.ShowSpecialData(Me.intSearchIndex)
        End If
        Me.bIsFormLoad = False : Me.bIsTextChange = False
        Return 2
    End Function

    Protected Overrides Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Call Me.btnSaveClickEvent()
        If Not Me.IsLastIntentLetter(Me.intSearchIndex) Then
            'MessageBox.Show("您只能对最后一条担保意向书进行提交。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$X003")
            Return
        End If
        If Me.isCommitConfirm = True Then
            'If MessageBox.Show("是否确认提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            If SWDialogBox.MessageBox.Show("?1000", "提交") = DialogResult.No Then
                Return
            End If
        End If
        Me.btnAdd.Enabled = False
        If Me.cmbBankRelapseOpinion.Text = "" Then
            'MessageBox.Show("没有对应的银行回复意见。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1001", "银行回复意见")
            Me.cmbBankRelapseOpinion.Focus()
            Return
        End If
        Try
            If Me.bIsTextChange Then
                Me._isDisplayDialog = False
                If Me.SaveData() = 1 Then
                    Return 'Me.bIsFormLoad = False : Me.bIsTextChange = False
                    Me._isDisplayDialog = True
                End If
                Me._isDisplayDialog = True
            End If
            Dim Opinion As String
            Opinion = Me.dgIntentLetter.Item(CType(Me.dgIntentLetter.DataSource, DataView).Count - 1, 6)
            Call Me.CommitWorkFlow(Opinion, Me)
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        End Try
    End Sub

    Protected Overrides Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim MsgResult As MsgBoxResult
        If Me.btnSave.Enabled = True Then
            If Me.bIsTextChange Then
                'MsgResult = MessageBox.Show("是否保存对数据进行的修改？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
                MsgResult = SWDialogBox.MessageBox.Show("?1003")
            Else
                Me.Close()
                Me.bIsFormLoad = False : Me.bIsTextChange = False
            End If
            If MsgResult = MsgBoxResult.Yes Then
                If Me.SaveData() = 2 Then Me.bIsFormLoad = False : Me.bIsTextChange = False
            End If
            If MsgResult = MsgBoxResult.No Then Me.Close() : Me.bIsFormLoad = False : Me.bIsTextChange = False
            If MsgResult = MsgBoxResult.Cancel Then Exit Sub
        Else
            Me.Close() : Me.bIsFormLoad = False : Me.bIsTextChange = False
        End If
    End Sub

    Protected Overrides Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim doc As New frmDocumentManageBusiness(strProjectCode, strTaskID, strEnterpriseName, "45", "008", UserName)
        doc.setIsButtonEnable(True)
        doc.AllowTransparency = False
        doc.ShowDialog()
        doc.Text = "查看担保意向书"
    End Sub
End Class
