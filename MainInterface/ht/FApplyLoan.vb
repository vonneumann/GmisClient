

Public Class FApplyLoan
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
    Public WithEvents btnConferenceTrial As System.Windows.Forms.Button
    Public WithEvents btnUploadReport As System.Windows.Forms.Button
    Public WithEvents btnCommit As System.Windows.Forms.Button
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents dgDatum As System.Windows.Forms.DataGrid
    Public WithEvents txtEnterpriseName As System.Windows.Forms.TextBox
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents cmbVouchTerms As System.Windows.Forms.TextBox
    Public WithEvents cmbVouchAccount As System.Windows.Forms.TextBox
    Public WithEvents Label100 As System.Windows.Forms.Label
    Public WithEvents cmbRefundType As System.Windows.Forms.ComboBox
    Public WithEvents cmbVouchBranchBank As System.Windows.Forms.ComboBox
    Public WithEvents cmbVouchBank As System.Windows.Forms.ComboBox
    Public WithEvents dtpVouchDate As System.Windows.Forms.DateTimePicker
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnConferenceTrial = New System.Windows.Forms.Button()
        Me.btnUploadReport = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgDatum = New System.Windows.Forms.DataGrid()
        Me.txtEnterpriseName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(432, 496)
        Me.btnExit.Size = New System.Drawing.Size(112, 23)
        Me.btnExit.Visible = True
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnConferenceTrial.Location = New System.Drawing.Point(184, 496)
        Me.btnConferenceTrial.Name = "btnConferenceTrial"
        Me.btnConferenceTrial.Size = New System.Drawing.Size(96, 24)
        Me.btnConferenceTrial.TabIndex = 11
        Me.btnConferenceTrial.Text = "评审会结论(&R)"
        '
        'btnUploadReport
        '
        Me.btnUploadReport.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnUploadReport.Enabled = False
        Me.btnUploadReport.Location = New System.Drawing.Point(64, 496)
        Me.btnUploadReport.Name = "btnUploadReport"
        Me.btnUploadReport.Size = New System.Drawing.Size(104, 24)
        Me.btnUploadReport.TabIndex = 10
        Me.btnUploadReport.Text = "制作放款申请书"
        Me.btnUploadReport.Visible = False
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Location = New System.Drawing.Point(312, 496)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(96, 24)
        Me.btnCommit.TabIndex = 9
        Me.btnCommit.Text = "提交(&C)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgDatum})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 192)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        '
        'dgDatum
        '
        Me.dgDatum.CaptionVisible = False
        Me.dgDatum.DataMember = ""
        Me.dgDatum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDatum.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDatum.Location = New System.Drawing.Point(3, 17)
        Me.dgDatum.Name = "dgDatum"
        Me.dgDatum.ReadOnly = True
        Me.dgDatum.Size = New System.Drawing.Size(546, 172)
        Me.dgDatum.TabIndex = 8
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Location = New System.Drawing.Point(240, 8)
        Me.txtEnterpriseName.Name = "txtEnterpriseName"
        Me.txtEnterpriseName.ReadOnly = True
        Me.txtEnterpriseName.Size = New System.Drawing.Size(240, 21)
        Me.txtEnterpriseName.TabIndex = 16
        Me.txtEnterpriseName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(72, 8)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 15
        Me.txtProjectCode.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(176, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "企业名称"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "项目编码"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbVouchTerms, Me.cmbVouchAccount, Me.Label100, Me.cmbRefundType, Me.cmbVouchBranchBank, Me.cmbVouchBank, Me.dtpVouchDate, Me.Label9, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3})
        Me.GroupBox2.Location = New System.Drawing.Point(24, 336)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(544, 120)
        Me.GroupBox2.TabIndex = 17
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
        'FApplyLoan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(610, 543)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.GroupBox1, Me.btnConferenceTrial, Me.btnUploadReport, Me.btnCommit, Me.btnExit})
        Me.Name = "FApplyLoan"
        Me.Text = "呈放放款申请书"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
