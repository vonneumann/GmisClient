Public Class frmVouchApplication
    Inherits MainInterface.frmRequestVouchApplication

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
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents dtpVouchDate As System.Windows.Forms.DateTimePicker
    Public WithEvents cmbVouchBank As System.Windows.Forms.ComboBox
    Public WithEvents cmbVouchBranchBank As System.Windows.Forms.ComboBox
    Public WithEvents cmbRefundType As System.Windows.Forms.ComboBox
    Public WithEvents Label100 As System.Windows.Forms.Label
    Public WithEvents btnPrint As System.Windows.Forms.Button
    Public WithEvents cmbVouchAccount As System.Windows.Forms.TextBox
    Public WithEvents cmbVouchTerms As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbVouchTerms = New System.Windows.Forms.TextBox()
        Me.cmbVouchAccount = New System.Windows.Forms.TextBox()
        Me.Label100 = New System.Windows.Forms.Label()
        Me.cmbRefundType = New System.Windows.Forms.ComboBox()
        Me.cmbVouchBranchBank = New System.Windows.Forms.ComboBox()
        Me.cmbVouchBank = New System.Windows.Forms.ComboBox()
        Me.dtpVouchDate = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Location = New System.Drawing.Point(128, 328)
        Me.btnConferenceTrial.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(312, 328)
        Me.btnCommit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Size = New System.Drawing.Size(464, 160)
        Me.GroupBox1.Visible = True
        '
        'btnUploadReport
        '
        Me.btnUploadReport.Enabled = True
        Me.btnUploadReport.Location = New System.Drawing.Point(8, 328)
        Me.btnUploadReport.Size = New System.Drawing.Size(112, 24)
        Me.btnUploadReport.Text = "制作放款申请(&M)"
        Me.btnUploadReport.Visible = True
        '
        'dgDatum
        '
        Me.dgDatum.AccessibleName = "DataGrid"
        Me.dgDatum.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgDatum.Size = New System.Drawing.Size(458, 140)
        Me.dgDatum.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Size = New System.Drawing.Size(232, 21)
        Me.txtEnterpriseName.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(400, 328)
        Me.btnExit.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbVouchTerms, Me.cmbVouchAccount, Me.Label100, Me.cmbRefundType, Me.cmbVouchBranchBank, Me.cmbVouchBank, Me.dtpVouchDate, Me.Label9, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(464, 120)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "放款信息"
        '
        'cmbVouchTerms
        '
        Me.cmbVouchTerms.Enabled = False
        Me.cmbVouchTerms.Location = New System.Drawing.Point(88, 56)
        Me.cmbVouchTerms.Name = "cmbVouchTerms"
        Me.cmbVouchTerms.Size = New System.Drawing.Size(96, 21)
        Me.cmbVouchTerms.TabIndex = 22
        Me.cmbVouchTerms.Text = "0"
        Me.cmbVouchTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbVouchAccount
        '
        Me.cmbVouchAccount.Location = New System.Drawing.Point(296, 56)
        Me.cmbVouchAccount.MaxLength = 15
        Me.cmbVouchAccount.Name = "cmbVouchAccount"
        Me.cmbVouchAccount.Size = New System.Drawing.Size(120, 21)
        Me.cmbVouchAccount.TabIndex = 21
        Me.cmbVouchAccount.Text = ""
        Me.cmbVouchAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label100
        '
        Me.Label100.Location = New System.Drawing.Point(416, 64)
        Me.Label100.Name = "Label100"
        Me.Label100.Size = New System.Drawing.Size(32, 16)
        Me.Label100.TabIndex = 20
        Me.Label100.Text = "万元"
        Me.Label100.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmbRefundType
        '
        Me.cmbRefundType.Location = New System.Drawing.Point(88, 88)
        Me.cmbRefundType.Name = "cmbRefundType"
        Me.cmbRefundType.Size = New System.Drawing.Size(120, 20)
        Me.cmbRefundType.TabIndex = 19
        '
        'cmbVouchBranchBank
        '
        Me.cmbVouchBranchBank.Location = New System.Drawing.Point(296, 24)
        Me.cmbVouchBranchBank.Name = "cmbVouchBranchBank"
        Me.cmbVouchBranchBank.Size = New System.Drawing.Size(152, 20)
        Me.cmbVouchBranchBank.TabIndex = 16
        '
        'cmbVouchBank
        '
        Me.cmbVouchBank.Location = New System.Drawing.Point(88, 24)
        Me.cmbVouchBank.Name = "cmbVouchBank"
        Me.cmbVouchBank.Size = New System.Drawing.Size(120, 20)
        Me.cmbVouchBank.TabIndex = 15
        '
        'dtpVouchDate
        '
        Me.dtpVouchDate.Location = New System.Drawing.Point(400, 88)
        Me.dtpVouchDate.Name = "dtpVouchDate"
        Me.dtpVouchDate.Size = New System.Drawing.Size(8, 21)
        Me.dtpVouchDate.TabIndex = 14
        Me.dtpVouchDate.Value = New Date(2003, 7, 26, 0, 0, 0, 0)
        Me.dtpVouchDate.Visible = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(184, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "个月"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(24, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "还款方式"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(232, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "放款金额"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "担保期限"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(232, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "贷款支行"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "贷款银行"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(360, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 16)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "个月"
        Me.Label3.Visible = False
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnPrint.Location = New System.Drawing.Point(232, 328)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(72, 24)
        Me.btnPrint.TabIndex = 8
        Me.btnPrint.Text = "打印(&P)"
        '
        'frmVouchApplication
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(490, 367)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnConferenceTrial, Me.btnUploadReport, Me.btnCommit, Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.GroupBox1, Me.btnPrint, Me.GroupBox2})
        Me.Name = "frmVouchApplication"
        Me.Text = "呈请放款"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private strTrialConclusion As String = "通过"
    Private intTrialTimes As Integer
    Private ds As New DataSet()
    Private BankCode, BranchBankCode As String
    Private strUpdateResult As String

    Private Sub GetVouchApplicationData()
        '获得TrialTimes。
        ds = gWs.GetConfTrialInfo("{project_code='" & Me.strProjectCode & "' and trial_conclusion='" & Me.strTrialConclusion & "'}", "null")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                If Not .Item("trial_times") Is System.DBNull.Value Then
                    intTrialTimes = ds.Tables(0).Rows(0).Item("trial_times")
                Else
                    intTrialTimes = 0
                End If
                If Not .Item("terms") Is System.DBNull.Value Then
                    Me.cmbVouchTerms.Text = .Item("terms")
                Else
                    Me.cmbVouchTerms.Text = ""
                End If
                If Not .Item("refund_type") Is System.DBNull.Value Then
                    Me.cmbRefundType.Text = .Item("refund_type")
                Else
                    Me.cmbRefundType.Text = ""
                End If
            End With
        End If
        '根据ProjectCode和TrialTimes
        ds = gWs.GetIntentLetterInfo("{project_code='" & Me.strProjectCode & "' and trial_times='" & Me.intTrialTimes & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            ds.Tables(0).DefaultView.Sort = "intent_code DESC"
            With ds.Tables(0).DefaultView.Item(0)
                If Not .Item("sign_date") Is System.DBNull.Value Then
                    Me.dtpVouchDate.Value = .Item("sign_date")
                Else
                    Me.dtpVouchDate.Value = gWs.GetSysTime()
                End If
                If Not .Item("guarantee_sum") Is System.DBNull.Value Then
                    Me.cmbVouchAccount.Text = .Item("guarantee_sum")
                Else
                    Me.cmbVouchAccount.Text = ""
                End If
                If Not .Item("loan_bank") Is System.DBNull.Value Then
                    Me.BankCode = .Item("loan_bank")
                    Me.cmbVouchBank.Text = Me.GetBankName(Me.BankCode, Nothing)
                Else
                    Me.cmbVouchBank.Text = ""
                End If
                If Not .Item("loan_bank") Is System.DBNull.Value And Not .Item("loan_branch_bank") Is System.DBNull.Value Then
                    Me.BranchBankCode = .Item("loan_branch_bank")
                    Me.cmbVouchBranchBank.Text = Me.GetBankName(Me.BankCode, Me.BranchBankCode)
                Else
                    Me.cmbVouchBranchBank.Text = ""
                End If
            End With
        End If
        ds = gWs.GetBankInfo("%", "null")
        Call Me.GetBankNameList(Me.cmbVouchBank, ds, "bank", "bank_name")
    End Sub

    Private Sub GetBankNameList(ByVal cmb As ComboBox, ByVal x As DataSet, ByVal TableName As String, ByVal FieldName As String)
        cmb.Items.Clear()
        If Not x.Tables(TableName).Rows.Count = 0 Then
            For i = 0 To x.Tables(TableName).Rows.Count - 1
                cmb.Items.Add(x.Tables(TableName).Rows(i).Item(FieldName))
            Next
        End If
    End Sub

    Private Function GetBankName(ByVal BankCode As String, ByVal BranchBankCode As String) As String
        Dim TempDS As New DataSet()
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

    Private Sub VouchApplicationLockContral()
        Me.dtpVouchDate.Enabled = False
        Me.cmbVouchBank.Enabled = True
        Me.cmbVouchBranchBank.Enabled = True
        Me.cmbVouchTerms.Enabled = True
        'Me.cmbVouchAccount.Enabled = True
        Me.cmbRefundType.Enabled = False
    End Sub

    Private Sub frmVouchApplication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Call Me.VouchApplicationLockContral()
            Call Me.GetVouchApplicationData()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Function SaveDataToLoanNotice() As Integer
        If Me.cmbVouchBank.Text.Trim() = "" Then
            MessageBox.Show("银行输入不能为空，请确认。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbVouchBank.Focus()
            Return -1
        End If
        If Me.cmbVouchBranchBank.Text.Trim() = "" Then
            MessageBox.Show("银行支行输入不能为空，请确认。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbVouchBranchBank.Focus()
            Return -1
        End If
        If Me.cmbVouchAccount.Text.Trim() = "" Then
            MessageBox.Show("贷款金额输入不能为空，请确认。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.cmbVouchAccount.Focus()
            Return -1
        End If

        ds = gWs.GetLoanNoticeInfo("{project_code='" & Me.strProjectCode & "'}")
        If ds.Tables(0).Rows.Count = 0 Then
            ds = gWs.GetLoanNoticeInfo("null")
            Dim NewRow As DataRow = ds.Tables(0).NewRow
            With NewRow
                .Item("project_code") = Me.strProjectCode
                .Item("bank") = Me.BankCode
                .Item("branch_bank") = Me.BranchBankCode
                .Item("sum") = Convert.ToDecimal(Me.cmbVouchAccount.Text.Trim())
                .Item("term") = Convert.ToDecimal(Me.cmbVouchTerms.Text)
                .Item("create_date") = gWs.GetSysTime()
                .Item("create_person") = Me.strUserID
            End With
            ds.Tables(0).Rows.Add(NewRow)
        Else
            With ds.Tables(0).Rows(0)
                .Item("project_code") = Me.strProjectCode
                .Item("bank") = Me.BankCode
                .Item("branch_bank") = Me.BranchBankCode
                .Item("sum") = Convert.ToDecimal(Me.cmbVouchAccount.Text.Trim())
                .Item("term") = Convert.ToDecimal(Me.cmbVouchTerms.Text)
                .Item("create_date") = gWs.GetSysTime()
                .Item("create_person") = Me.strUserID
            End With
        End If
        Me.strUpdateResult = gWs.UpdateLoanNotice(ds)
        If Me.strUpdateResult = "1" Then
            Return 1
        Else
            Return -1
        End If
    End Function

    Protected Overrides Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.isCommitConfirm = True Then
            If MessageBox.Show("是否确认提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            If Me.SaveDataToLoanNotice() < 0 Then
                MessageBox.Show("更新操作失败。" + Me.strUpdateResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Cursor = System.Windows.Forms.Cursors.Default
                Return
            End If
            Me.CommitWorkFlow("", Me)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            ds = gWs.GetServiceType("{service_type=(select top 1 service_type from conference_trial where project_code like '" & Me.strProjectCode & "')}")
            If Not ds.Tables(0).Rows.Count = 0 Then
                If ((((((((((ds.Tables(0).Rows(0).Item("service_type_code") = "01" Or ds.Tables(0).Rows(0).Item("service_type_code") = "03") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "04") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "05") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "06") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "07") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "08") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "09") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "10") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "11") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "12") Then      '担保放款通知书
                    Call Me.PrintDocumentVouch01(Me.strProjectCode, "45", "010")
                ElseIf ds.Tables(0).Rows(0).Item("service_type_code") = "02" Then   '委托放款通知书
                    Call Me.PrintDocumentVouch01(Me.strProjectCode, "45", "009")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    '
    '打印Service_Type_Code='01' 放款通知书。担保放款通知书。
    '
    Private Sub PrintDocumentVouch01(ByVal ProjectCode As String, ByVal ItemType As String, ByVal ItemCode As String)
        Dim strReplaceFrom(15) As String, strReplaceTo(15) As String
        Dim Sum As Double
        strReplaceFrom(0) = "&#CorporationName"
        strReplaceFrom(1) = "&#BankName"
        strReplaceFrom(2) = "&#BranchBankName"
        strReplaceFrom(3) = "&#RefundAverage"
        strReplaceFrom(4) = "&#GuaranteeSum"
        strReplaceFrom(5) = "&#VouchTerminate"

        strReplaceFrom(6) = "&#ACorporationName"
        strReplaceFrom(7) = "&#BCorporationName"
        strReplaceFrom(8) = "&#ABankName"
        strReplaceFrom(9) = "&#BBankName"
        strReplaceFrom(10) = "&#ABranchBankName"
        strReplaceFrom(11) = "&#BBranchBankName"
        strReplaceFrom(12) = "&#AGuaranteeSum"
        strReplaceFrom(13) = "&#AVouchTerminate"
        strReplaceFrom(14) = "&#ARefundAverage"

        ds = gWs.FetchProjectCorporation("{project_code='" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(0) = IIf(.Item("corporation_name") Is System.DBNull.Value, "", .Item("corporation_name"))
                strReplaceTo(6) = strReplaceTo(0) : strReplaceTo(7) = strReplaceTo(0)
            End With
        End If
        ds = gWs.GetLoanNoticeInfo("{project_code='" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(1) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), Nothing)
                strReplaceTo(2) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), IIf(.Item("branch_bank") Is System.DBNull.Value, "", .Item("branch_bank")))
                strReplaceTo(8) = strReplaceTo(1) : strReplaceTo(9) = strReplaceTo(1)
                strReplaceTo(10) = strReplaceTo(2) : strReplaceTo(11) = strReplaceTo(2)
                Sum = IIf(.Item("sum") Is System.DBNull.Value, 0, .Item("sum"))
                strReplaceTo(4) = Money2String.Money2String.GetCnString(Convert.ToString(Sum * 10000)) + "(" + Money2String.Money2String.GetScienceString(Convert.ToString(Sum * 10000)) + ")"
                strReplaceTo(5) = Convert.ToString(IIf(.Item("term") Is System.DBNull.Value, 0, .Item("term"))) + "个月"
                strReplaceTo(12) = strReplaceTo(4) : strReplaceTo(13) = strReplaceTo(5)
            End With
        End If
        ds = gWs.GetConfTrialInfo("{project_code='" & ProjectCode & "' and trial_conclusion='通过'}", "null")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Dim Temp As String
                Temp = IIf(.Item("refund_type") Is System.DBNull.Value, "", .Item("refund_type"))
                Sum = IIf(.Item("refund_sum_average") Is System.DBNull.Value, 0, .Item("refund_sum_average"))
                strReplaceTo(3) = Temp + Money2String.Money2String.GetCnString(Convert.ToString(Sum))
                strReplaceTo(14) = strReplaceTo(3)
            End With
        End If
        Dim Doc As New Word.ApplicationClass()
        Doc = Me.GetWordTemplate(ItemType, ItemCode, strEnterpriseName + "担保放款通知书.DOC")
        If Doc Is Nothing Then
            MessageBox.Show("暂不存在该文档模版，请制作放款通知书。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        For i = 0 To 14
            Me.replaceText(Doc, strReplaceFrom(i), strReplaceTo(i))
        Next
    End Sub
    '
    '打印Service_Type_Code='02' 放款通知书。委托放款通知书。
    '
    Private Sub PrintDocumentVouch02(ByVal ProjectCode As String, ByVal ItemType As String, ByVal ItemCode As String)
        Dim strReplaceFrom(14) As String, strReplaceTo(14) As String
        Dim Sum As Double
        strReplaceFrom(0) = "&#CorporationName"
        strReplaceFrom(1) = "&#BankName"
        strReplaceFrom(2) = "&#BranchBankName"
        strReplaceFrom(3) = "&#BankCreditNo"
        strReplaceFrom(4) = "&#GuaranteeSum"
        strReplaceFrom(5) = "&#VouchTerminate"

        strReplaceFrom(6) = "&#ACorporationName"
        strReplaceFrom(7) = "&#BCorporationName"
        strReplaceFrom(8) = "&#ABankName"
        strReplaceFrom(9) = "&#BBankName"
        strReplaceFrom(10) = "&#ABranchBankName"
        strReplaceFrom(11) = "&#BBranchBankName"
        strReplaceFrom(12) = "&#AGuaranteeSum"
        strReplaceFrom(13) = "&#AVouchTerminate"

        ds = gWs.FetchProjectCorporation("{project_code='" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(0) = IIf(.Item("corporation_name") Is System.DBNull.Value, "", .Item("corporation_name"))
                strReplaceTo(6) = strReplaceTo(0)
                strReplaceTo(7) = strReplaceTo(0)
            End With
        End If
        ds = gWs.GetLoanNoticeInfo("{project_code='" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(1) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), Nothing)
                strReplaceTo(2) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), IIf(.Item("branch_bank") Is System.DBNull.Value, "", .Item("branch_bank")))
                strReplaceTo(8) = strReplaceTo(1) : strReplaceTo(9) = strReplaceTo(1)
                strReplaceTo(10) = strReplaceTo(2) : strReplaceTo(11) = strReplaceTo(2)
                Sum = IIf(.Item("sum") Is System.DBNull.Value, 0, .Item("sum"))
                strReplaceTo(4) = Money2String.Money2String.GetCnString(Convert.ToString(Sum * 10000)) + "(" + Money2String.Money2String.GetScienceString(Convert.ToString(Sum * 10000)) + ")"
                strReplaceTo(5) = Convert.ToString(IIf(.Item("term") Is System.DBNull.Value, 0, .Item("term"))) + "个月"
                strReplaceTo(12) = strReplaceTo(4)
                strReplaceTo(13) = strReplaceTo(5)
            End With
        End If
        strReplaceTo(3) = "                    "
        Dim Doc As New Word.ApplicationClass()
        Doc = Me.GetWordTemplate(ItemType, ItemCode, Me.strEnterpriseName + "委托放款通知书.DOC")
        If Doc Is Nothing Then
            MessageBox.Show("暂不存在该文档模版，请制作放款通知书。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        End If
        For i = 0 To 13
            Me.replaceText(Doc, strReplaceFrom(i), strReplaceTo(i))
        Next
    End Sub

    Private Sub cmbVouchAccount_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVouchAccount.KeyPress
        Call Me.SendKeys(2, Me.cmbVouchAccount.Text.Trim(), e)
    End Sub

    Private Sub cmbVouchBank_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVouchBank.TextChanged
        Dim TempDS As New DataSet()
        TempDS = gWs.GetBankInfo("{bank_name='" & Me.cmbVouchBank.Text & "'}", "null")
        If Not TempDS.Tables(0).Rows.Count = 0 Then
            Me.BankCode = TempDS.Tables(0).Rows(0).Item("bank_code")
        End If
        TempDS = gWs.GetBankInfo("null", "{bank_code='" & Me.BankCode & "'}")
        Call Me.GetBankNameList(Me.cmbVouchBranchBank, TempDS, "bank_branch", "branch_bank_name")
        Me.cmbVouchBranchBank.Text = ""
    End Sub

    Private Sub cmbVouchBranchBank_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbVouchBranchBank.TextChanged
        Dim TempDS As New DataSet()
        TempDS = gWs.GetBankInfo("null", "{bank_code='" & Me.BankCode & "' and branch_bank_name='" & Me.cmbVouchBranchBank.Text.Trim() & "'}")
        If Not TempDS.Tables(1).Rows.Count = 0 Then
            Me.BranchBankCode = TempDS.Tables(1).Rows(0).Item("branch_bank_code")
        End If
    End Sub

    Private Sub cmbVouchTerms_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVouchTerms.KeyPress
        Call Me.SendKeys(1, Me.cmbVouchTerms.Text.Trim(), e)
    End Sub

End Class
