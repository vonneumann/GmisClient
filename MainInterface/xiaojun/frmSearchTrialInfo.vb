

Public Class frmSearchTrialInfo
    Inherits frmBusinessBaseWin

    Public str As String
    Public strEnterprise As String

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        Me.str = Me.strProjectCode
    End Sub

    Public Sub New(ByVal projectcode As String, ByVal enterprise As String)
        Me.New()
        Me.str = projectcode
        Me.strEnterprise = enterprise
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtServiceType As System.Windows.Forms.TextBox
    Friend WithEvents txtGuaranteeSum As System.Windows.Forms.TextBox
    Friend WithEvents txtPrimaryCommitee As System.Windows.Forms.TextBox
    Friend WithEvents txtConclusion As System.Windows.Forms.TextBox
    Friend WithEvents txtRefundType As System.Windows.Forms.TextBox
    Friend WithEvents txtLoanType As System.Windows.Forms.TextBox
    Friend WithEvents txtAverageRefund As System.Windows.Forms.TextBox
    Friend WithEvents chkIsFinalConclusion As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtTerms As System.Windows.Forms.TextBox
    Friend WithEvents dtpApplyTrialTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtTerms = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chkIsFinalConclusion = New System.Windows.Forms.CheckBox()
        Me.txtAverageRefund = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRefundType = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLoanType = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtPrimaryCommitee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtConclusion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGuaranteeSum = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtServiceType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpApplyTrialTime = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Location = New System.Drawing.Point(256, 8)
        Me.txtEnterpriseName.Size = New System.Drawing.Size(280, 21)
        Me.txtEnterpriseName.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 8)
        Me.txtProjectCode.Size = New System.Drawing.Size(104, 21)
        Me.txtProjectCode.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(448, 232)
        Me.btnExit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label14, Me.Label13, Me.txtTerms, Me.Label11, Me.chkIsFinalConclusion, Me.txtAverageRefund, Me.Label12, Me.txtRefundType, Me.Label9, Me.txtLoanType, Me.Label10, Me.txtPrimaryCommitee, Me.Label7, Me.txtConclusion, Me.Label8, Me.Label6, Me.txtGuaranteeSum, Me.Label5, Me.txtServiceType, Me.Label4, Me.dtpApplyTrialTime, Me.Label3})
        Me.GroupBox1.Location = New System.Drawing.Point(16, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 184)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(208, 152)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 16)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "万元"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(456, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 16)
        Me.Label13.TabIndex = 21
        Me.Label13.Text = "个月"
        '
        'txtTerms
        '
        Me.txtTerms.Location = New System.Drawing.Point(344, 48)
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.ReadOnly = True
        Me.txtTerms.Size = New System.Drawing.Size(104, 21)
        Me.txtTerms.TabIndex = 20
        Me.txtTerms.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(208, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 16)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "万元"
        '
        'chkIsFinalConclusion
        '
        Me.chkIsFinalConclusion.Enabled = False
        Me.chkIsFinalConclusion.Location = New System.Drawing.Point(344, 80)
        Me.chkIsFinalConclusion.Name = "chkIsFinalConclusion"
        Me.chkIsFinalConclusion.TabIndex = 18
        Me.chkIsFinalConclusion.Text = "是否最终结论"
        '
        'txtAverageRefund
        '
        Me.txtAverageRefund.Location = New System.Drawing.Point(96, 144)
        Me.txtAverageRefund.Name = "txtAverageRefund"
        Me.txtAverageRefund.ReadOnly = True
        Me.txtAverageRefund.Size = New System.Drawing.Size(104, 21)
        Me.txtAverageRefund.TabIndex = 17
        Me.txtAverageRefund.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 16)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "每次还款额"
        '
        'txtRefundType
        '
        Me.txtRefundType.Location = New System.Drawing.Point(344, 112)
        Me.txtRefundType.Name = "txtRefundType"
        Me.txtRefundType.ReadOnly = True
        Me.txtRefundType.Size = New System.Drawing.Size(136, 21)
        Me.txtRefundType.TabIndex = 15
        Me.txtRefundType.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(256, 120)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "还款方式"
        '
        'txtLoanType
        '
        Me.txtLoanType.Location = New System.Drawing.Point(96, 112)
        Me.txtLoanType.Name = "txtLoanType"
        Me.txtLoanType.ReadOnly = True
        Me.txtLoanType.Size = New System.Drawing.Size(136, 21)
        Me.txtLoanType.TabIndex = 13
        Me.txtLoanType.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 16)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "贷款方式"
        '
        'txtPrimaryCommitee
        '
        Me.txtPrimaryCommitee.Location = New System.Drawing.Point(344, 144)
        Me.txtPrimaryCommitee.Name = "txtPrimaryCommitee"
        Me.txtPrimaryCommitee.ReadOnly = True
        Me.txtPrimaryCommitee.Size = New System.Drawing.Size(136, 21)
        Me.txtPrimaryCommitee.TabIndex = 11
        Me.txtPrimaryCommitee.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(256, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "主评"
        '
        'txtConclusion
        '
        Me.txtConclusion.Location = New System.Drawing.Point(96, 80)
        Me.txtConclusion.Name = "txtConclusion"
        Me.txtConclusion.ReadOnly = True
        Me.txtConclusion.Size = New System.Drawing.Size(136, 21)
        Me.txtConclusion.TabIndex = 9
        Me.txtConclusion.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 88)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(88, 16)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "评审结论"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(256, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "担保期限"
        '
        'txtGuaranteeSum
        '
        Me.txtGuaranteeSum.Location = New System.Drawing.Point(96, 48)
        Me.txtGuaranteeSum.Name = "txtGuaranteeSum"
        Me.txtGuaranteeSum.ReadOnly = True
        Me.txtGuaranteeSum.Size = New System.Drawing.Size(104, 21)
        Me.txtGuaranteeSum.TabIndex = 5
        Me.txtGuaranteeSum.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "担保金额"
        '
        'txtServiceType
        '
        Me.txtServiceType.Location = New System.Drawing.Point(344, 16)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(136, 21)
        Me.txtServiceType.TabIndex = 3
        Me.txtServiceType.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(256, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "业务品种"
        '
        'dtpApplyTrialTime
        '
        Me.dtpApplyTrialTime.Enabled = False
        Me.dtpApplyTrialTime.Location = New System.Drawing.Point(96, 16)
        Me.dtpApplyTrialTime.Name = "dtpApplyTrialTime"
        Me.dtpApplyTrialTime.Size = New System.Drawing.Size(136, 21)
        Me.dtpApplyTrialTime.TabIndex = 1
        Me.dtpApplyTrialTime.Value = New Date(2003, 6, 13, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "申请评审时间："
        '
        'frmSearchTrialInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(554, 271)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.GroupBox1})
        Me.Name = "frmSearchTrialInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "会议评审信息"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub GetTrialInfo(ByVal ProjectCode As String)
        Dim ds As New DataSet()
        ds = gWs.GetConfTrialInfo("{project_code like '" & ProjectCode & "'}", "null")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.dtpApplyTrialTime.Value = IIf(.Item("apply_trial_date") Is System.DBNull.Value, gWs.GetSysTime(), .Item("apply_trial_date"))
                Me.txtServiceType.Text = IIf(.Item("service_type") Is System.DBNull.Value, "", .Item("service_type"))
                Me.txtGuaranteeSum.Text = IIf(.Item("guarantee_sum") Is System.DBNull.Value, "", .Item("guarantee_sum"))
                Me.txtTerms.Text = IIf(.Item("terms") Is System.DBNull.Value, "", .Item("terms"))
                Me.txtConclusion.Text = IIf(.Item("trial_conclusion") Is System.DBNull.Value, "", .Item("trial_conclusion"))
                Me.chkIsFinalConclusion.Checked = IIf(.Item("is_final_conclusion") Is System.DBNull.Value, False, .Item("is_final_conclusion"))
                Me.txtPrimaryCommitee.Text = IIf(.Item("prime_committeeman") Is System.DBNull.Value, "", .Item("prime_committeeman"))
                Me.txtLoanType.Text = IIf(.Item("loan_provide_form") Is System.DBNull.Value, "", .Item("loan_provide_form"))
                Me.txtRefundType.Text = IIf(.Item("refund_type") Is System.DBNull.Value, "", .Item("refund_type"))
                Me.txtAverageRefund.Text = IIf(.Item("refund_sum_average") Is System.DBNull.Value, "", .Item("refund_sum_average"))
            End With
        End If
    End Sub

    Private Sub frmSearchTrialInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call Me.GetTrialInfo(Me.str)
            Me.txtProjectCode.Text = Me.str : Me.txtEnterpriseName.Text = Me.strEnterprise
        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
End Class
