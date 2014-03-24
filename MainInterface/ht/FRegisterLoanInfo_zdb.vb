
'登记放款信息－－再担保　
Public Class FRegisterLoanInfo_zdb
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
    Protected WithEvents lblBranchBankName As System.Windows.Forms.Label
    Protected WithEvents txtRefundType As System.Windows.Forms.TextBox
    Protected WithEvents lblRefundType As System.Windows.Forms.Label
    Protected WithEvents txtServiceType As System.Windows.Forms.TextBox
    Protected WithEvents txtOrganizationName As System.Windows.Forms.TextBox
    Protected WithEvents lblOrganizationName As System.Windows.Forms.Label
    Public WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Protected WithEvents lblServiceType As System.Windows.Forms.Label
    Friend WithEvents btnConferenceTrial As System.Windows.Forms.Button
    Friend WithEvents cboBank As System.Windows.Forms.ComboBox
    Protected WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents cboBranch_bank As System.Windows.Forms.ComboBox
    Protected WithEvents lblFee As System.Windows.Forms.Label
    Protected WithEvents lblGuarantee_rate As System.Windows.Forms.Label
    Protected WithEvents txtFee As System.Windows.Forms.TextBox
    Protected WithEvents txtGuarantee_rate As System.Windows.Forms.TextBox
    Protected WithEvents txtCounterguarantee As System.Windows.Forms.TextBox
    Protected WithEvents txtServiceCondition As System.Windows.Forms.TextBox
    Protected WithEvents lblCounterguarantee As System.Windows.Forms.Label
    Protected WithEvents lblServiceCondition As System.Windows.Forms.Label
    Protected WithEvents lblTerm As System.Windows.Forms.Label
    Protected WithEvents txtTerm As System.Windows.Forms.TextBox
    Protected WithEvents lblSum As System.Windows.Forms.Label
    Protected WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents dtpEnd_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStart_date As System.Windows.Forms.Label
    Friend WithEvents dtpStart_Date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEnd_date As System.Windows.Forms.Label
    Protected WithEvents txtLoanType As System.Windows.Forms.TextBox
    Friend WithEvents lblLoanType As System.Windows.Forms.Label
    Protected WithEvents txtSourceServiceType As System.Windows.Forms.TextBox
    Protected WithEvents lblSourceServiceType As System.Windows.Forms.Label
    Protected WithEvents txtSourceLoanSum As System.Windows.Forms.TextBox
    Protected WithEvents lblSourceLoanSum As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRegisterLoanInfo_zdb))
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.lblProjectCode = New System.Windows.Forms.Label()
        Me.grpBaseInfo = New System.Windows.Forms.GroupBox()
        Me.txtSourceServiceType = New System.Windows.Forms.TextBox()
        Me.lblSourceServiceType = New System.Windows.Forms.Label()
        Me.txtSourceLoanSum = New System.Windows.Forms.TextBox()
        Me.txtCounterguarantee = New System.Windows.Forms.TextBox()
        Me.txtServiceCondition = New System.Windows.Forms.TextBox()
        Me.cboBranch_bank = New System.Windows.Forms.ComboBox()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.txtLoanType = New System.Windows.Forms.TextBox()
        Me.lblFee = New System.Windows.Forms.Label()
        Me.lblSourceLoanSum = New System.Windows.Forms.Label()
        Me.lblGuarantee_rate = New System.Windows.Forms.Label()
        Me.lblCounterguarantee = New System.Windows.Forms.Label()
        Me.lblServiceCondition = New System.Windows.Forms.Label()
        Me.lblLoanType = New System.Windows.Forms.Label()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.txtGuarantee_rate = New System.Windows.Forms.TextBox()
        Me.lblBranchBankName = New System.Windows.Forms.Label()
        Me.txtRefundType = New System.Windows.Forms.TextBox()
        Me.lblRefundType = New System.Windows.Forms.Label()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.txtServiceType = New System.Windows.Forms.TextBox()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.txtOrganizationName = New System.Windows.Forms.TextBox()
        Me.lblOrganizationName = New System.Windows.Forms.Label()
        Me.lblTerm = New System.Windows.Forms.Label()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.dtpEnd_Date = New System.Windows.Forms.DateTimePicker()
        Me.lblStart_date = New System.Windows.Forms.Label()
        Me.dtpStart_Date = New System.Windows.Forms.DateTimePicker()
        Me.lblEnd_date = New System.Windows.Forms.Label()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnConferenceTrial = New System.Windows.Forms.Button()
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
        Me.btnExit.Location = New System.Drawing.Point(385, 408)
        Me.btnExit.Visible = True
        '
        'lblCorporationName
        '
        Me.lblCorporationName.AutoSize = True
        Me.lblCorporationName.Location = New System.Drawing.Point(192, 8)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(54, 14)
        Me.lblCorporationName.TabIndex = 18
        Me.lblCorporationName.Text = "企业名称"
        '
        'lblProjectCode
        '
        Me.lblProjectCode.AutoSize = True
        Me.lblProjectCode.Location = New System.Drawing.Point(16, 8)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(54, 14)
        Me.lblProjectCode.TabIndex = 17
        Me.lblProjectCode.Text = "项目编码"
        '
        'grpBaseInfo
        '
        Me.grpBaseInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtSourceServiceType, Me.lblSourceServiceType, Me.txtSourceLoanSum, Me.txtCounterguarantee, Me.txtServiceCondition, Me.cboBranch_bank, Me.cboBank, Me.txtLoanType, Me.lblFee, Me.lblSourceLoanSum, Me.lblGuarantee_rate, Me.lblCounterguarantee, Me.lblServiceCondition, Me.lblLoanType, Me.txtFee, Me.txtGuarantee_rate, Me.lblBranchBankName, Me.txtRefundType, Me.lblRefundType, Me.lblBank, Me.txtServiceType, Me.lblServiceType, Me.txtOrganizationName, Me.lblOrganizationName, Me.lblTerm, Me.txtTerm, Me.lblSum, Me.txtSum, Me.dtpEnd_Date, Me.lblStart_date, Me.dtpStart_Date, Me.lblEnd_date})
        Me.grpBaseInfo.Location = New System.Drawing.Point(8, 32)
        Me.grpBaseInfo.Name = "grpBaseInfo"
        Me.grpBaseInfo.Size = New System.Drawing.Size(528, 368)
        Me.grpBaseInfo.TabIndex = 21
        Me.grpBaseInfo.TabStop = False
        Me.grpBaseInfo.Text = "项目基本信息"
        '
        'txtSourceServiceType
        '
        Me.txtSourceServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSourceServiceType.Location = New System.Drawing.Point(360, 70)
        Me.txtSourceServiceType.MaxLength = 20
        Me.txtSourceServiceType.Name = "txtSourceServiceType"
        Me.txtSourceServiceType.ReadOnly = True
        Me.txtSourceServiceType.Size = New System.Drawing.Size(152, 21)
        Me.txtSourceServiceType.TabIndex = 58
        Me.txtSourceServiceType.TabStop = False
        Me.txtSourceServiceType.Text = ""
        '
        'lblSourceServiceType
        '
        Me.lblSourceServiceType.Location = New System.Drawing.Point(272, 72)
        Me.lblSourceServiceType.Name = "lblSourceServiceType"
        Me.lblSourceServiceType.Size = New System.Drawing.Size(79, 16)
        Me.lblSourceServiceType.TabIndex = 59
        Me.lblSourceServiceType.Text = "贷款业务品种"
        '
        'txtSourceLoanSum
        '
        Me.txtSourceLoanSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSourceLoanSum.Location = New System.Drawing.Point(360, 94)
        Me.txtSourceLoanSum.MaxLength = 11
        Me.txtSourceLoanSum.Name = "txtSourceLoanSum"
        Me.txtSourceLoanSum.ReadOnly = True
        Me.txtSourceLoanSum.Size = New System.Drawing.Size(152, 21)
        Me.txtSourceLoanSum.TabIndex = 53
        Me.txtSourceLoanSum.TabStop = False
        Me.txtSourceLoanSum.Text = ""
        Me.txtSourceLoanSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCounterguarantee
        '
        Me.txtCounterguarantee.Location = New System.Drawing.Point(104, 280)
        Me.txtCounterguarantee.MaxLength = 1000
        Me.txtCounterguarantee.Multiline = True
        Me.txtCounterguarantee.Name = "txtCounterguarantee"
        Me.txtCounterguarantee.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCounterguarantee.Size = New System.Drawing.Size(408, 80)
        Me.txtCounterguarantee.TabIndex = 52
        Me.txtCounterguarantee.TabStop = False
        Me.txtCounterguarantee.Text = ""
        '
        'txtServiceCondition
        '
        Me.txtServiceCondition.Location = New System.Drawing.Point(104, 192)
        Me.txtServiceCondition.MaxLength = 1000
        Me.txtServiceCondition.Multiline = True
        Me.txtServiceCondition.Name = "txtServiceCondition"
        Me.txtServiceCondition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtServiceCondition.Size = New System.Drawing.Size(408, 80)
        Me.txtServiceCondition.TabIndex = 51
        Me.txtServiceCondition.TabStop = False
        Me.txtServiceCondition.Text = ""
        '
        'cboBranch_bank
        '
        Me.cboBranch_bank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBranch_bank.Location = New System.Drawing.Point(360, 118)
        Me.cboBranch_bank.Name = "cboBranch_bank"
        Me.cboBranch_bank.Size = New System.Drawing.Size(152, 20)
        Me.cboBranch_bank.TabIndex = 50
        '
        'cboBank
        '
        Me.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBank.Location = New System.Drawing.Point(104, 118)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(152, 20)
        Me.cboBank.TabIndex = 49
        '
        'txtLoanType
        '
        Me.txtLoanType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanType.Location = New System.Drawing.Point(104, 46)
        Me.txtLoanType.Name = "txtLoanType"
        Me.txtLoanType.ReadOnly = True
        Me.txtLoanType.Size = New System.Drawing.Size(152, 21)
        Me.txtLoanType.TabIndex = 48
        Me.txtLoanType.TabStop = False
        Me.txtLoanType.Text = ""
        '
        'lblFee
        '
        Me.lblFee.Location = New System.Drawing.Point(8, 96)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(80, 16)
        Me.lblFee.TabIndex = 45
        Me.lblFee.Text = "应收保费(元)"
        '
        'lblSourceLoanSum
        '
        Me.lblSourceLoanSum.Location = New System.Drawing.Point(272, 96)
        Me.lblSourceLoanSum.Name = "lblSourceLoanSum"
        Me.lblSourceLoanSum.Size = New System.Drawing.Size(80, 16)
        Me.lblSourceLoanSum.TabIndex = 44
        Me.lblSourceLoanSum.Text = "保费总额(元)"
        '
        'lblGuarantee_rate
        '
        Me.lblGuarantee_rate.Location = New System.Drawing.Point(8, 72)
        Me.lblGuarantee_rate.Name = "lblGuarantee_rate"
        Me.lblGuarantee_rate.Size = New System.Drawing.Size(54, 16)
        Me.lblGuarantee_rate.TabIndex = 43
        Me.lblGuarantee_rate.Text = "保费利率"
        '
        'lblCounterguarantee
        '
        Me.lblCounterguarantee.Location = New System.Drawing.Point(8, 280)
        Me.lblCounterguarantee.Name = "lblCounterguarantee"
        Me.lblCounterguarantee.Size = New System.Drawing.Size(66, 16)
        Me.lblCounterguarantee.TabIndex = 42
        Me.lblCounterguarantee.Text = "反担保措施"
        '
        'lblServiceCondition
        '
        Me.lblServiceCondition.Location = New System.Drawing.Point(8, 192)
        Me.lblServiceCondition.Name = "lblServiceCondition"
        Me.lblServiceCondition.Size = New System.Drawing.Size(79, 16)
        Me.lblServiceCondition.TabIndex = 41
        Me.lblServiceCondition.Text = "贷款使用条件"
        '
        'lblLoanType
        '
        Me.lblLoanType.Location = New System.Drawing.Point(8, 48)
        Me.lblLoanType.Name = "lblLoanType"
        Me.lblLoanType.Size = New System.Drawing.Size(54, 16)
        Me.lblLoanType.TabIndex = 40
        Me.lblLoanType.Text = "放款方式"
        '
        'txtFee
        '
        Me.txtFee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFee.Location = New System.Drawing.Point(104, 94)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.ReadOnly = True
        Me.txtFee.Size = New System.Drawing.Size(152, 21)
        Me.txtFee.TabIndex = 37
        Me.txtFee.TabStop = False
        Me.txtFee.Text = ""
        Me.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGuarantee_rate
        '
        Me.txtGuarantee_rate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuarantee_rate.Location = New System.Drawing.Point(104, 70)
        Me.txtGuarantee_rate.Name = "txtGuarantee_rate"
        Me.txtGuarantee_rate.ReadOnly = True
        Me.txtGuarantee_rate.Size = New System.Drawing.Size(152, 21)
        Me.txtGuarantee_rate.TabIndex = 36
        Me.txtGuarantee_rate.TabStop = False
        Me.txtGuarantee_rate.Text = ""
        Me.txtGuarantee_rate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBranchBankName
        '
        Me.lblBranchBankName.Location = New System.Drawing.Point(272, 120)
        Me.lblBranchBankName.Name = "lblBranchBankName"
        Me.lblBranchBankName.Size = New System.Drawing.Size(54, 16)
        Me.lblBranchBankName.TabIndex = 29
        Me.lblBranchBankName.Text = "贷款支行"
        '
        'txtRefundType
        '
        Me.txtRefundType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRefundType.Location = New System.Drawing.Point(360, 46)
        Me.txtRefundType.Name = "txtRefundType"
        Me.txtRefundType.ReadOnly = True
        Me.txtRefundType.Size = New System.Drawing.Size(152, 21)
        Me.txtRefundType.TabIndex = 24
        Me.txtRefundType.TabStop = False
        Me.txtRefundType.Text = ""
        '
        'lblRefundType
        '
        Me.lblRefundType.Location = New System.Drawing.Point(272, 48)
        Me.lblRefundType.Name = "lblRefundType"
        Me.lblRefundType.Size = New System.Drawing.Size(54, 16)
        Me.lblRefundType.TabIndex = 23
        Me.lblRefundType.Text = "还款方式"
        '
        'lblBank
        '
        Me.lblBank.Location = New System.Drawing.Point(8, 120)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(54, 16)
        Me.lblBank.TabIndex = 17
        Me.lblBank.Text = "贷款银行"
        '
        'txtServiceType
        '
        Me.txtServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtServiceType.Location = New System.Drawing.Point(360, 22)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(152, 21)
        Me.txtServiceType.TabIndex = 16
        Me.txtServiceType.TabStop = False
        Me.txtServiceType.Text = ""
        '
        'lblServiceType
        '
        Me.lblServiceType.Location = New System.Drawing.Point(272, 24)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(79, 16)
        Me.lblServiceType.TabIndex = 15
        Me.lblServiceType.Text = "申请业务品种"
        '
        'txtOrganizationName
        '
        Me.txtOrganizationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOrganizationName.Location = New System.Drawing.Point(104, 22)
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
        'lblTerm
        '
        Me.lblTerm.Location = New System.Drawing.Point(272, 144)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(80, 16)
        Me.lblTerm.TabIndex = 21
        Me.lblTerm.Text = "贷款期限(月)"
        '
        'txtTerm
        '
        Me.txtTerm.Location = New System.Drawing.Point(360, 142)
        Me.txtTerm.MaxLength = 4
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.Size = New System.Drawing.Size(152, 21)
        Me.txtTerm.TabIndex = 22
        Me.txtTerm.TabStop = False
        Me.txtTerm.Text = ""
        Me.txtTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSum
        '
        Me.lblSum.Location = New System.Drawing.Point(8, 144)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(96, 16)
        Me.lblSum.TabIndex = 19
        Me.lblSum.Text = "贷款金额(万元)"
        '
        'txtSum
        '
        Me.txtSum.Location = New System.Drawing.Point(104, 142)
        Me.txtSum.MaxLength = 10
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(152, 21)
        Me.txtSum.TabIndex = 20
        Me.txtSum.TabStop = False
        Me.txtSum.Text = ""
        Me.txtSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpEnd_Date
        '
        Me.dtpEnd_Date.Enabled = False
        Me.dtpEnd_Date.Location = New System.Drawing.Point(360, 166)
        Me.dtpEnd_Date.Name = "dtpEnd_Date"
        Me.dtpEnd_Date.Size = New System.Drawing.Size(152, 21)
        Me.dtpEnd_Date.TabIndex = 47
        '
        'lblStart_date
        '
        Me.lblStart_date.Location = New System.Drawing.Point(8, 168)
        Me.lblStart_date.Name = "lblStart_date"
        Me.lblStart_date.Size = New System.Drawing.Size(66, 16)
        Me.lblStart_date.TabIndex = 38
        Me.lblStart_date.Text = "贷款起始日"
        '
        'dtpStart_Date
        '
        Me.dtpStart_Date.Location = New System.Drawing.Point(104, 166)
        Me.dtpStart_Date.Name = "dtpStart_Date"
        Me.dtpStart_Date.Size = New System.Drawing.Size(152, 21)
        Me.dtpStart_Date.TabIndex = 46
        '
        'lblEnd_date
        '
        Me.lblEnd_date.Location = New System.Drawing.Point(272, 168)
        Me.lblEnd_date.Name = "lblEnd_date"
        Me.lblEnd_date.Size = New System.Drawing.Size(66, 16)
        Me.lblEnd_date.TabIndex = 39
        Me.lblEnd_date.Text = "贷款终止日"
        '
        'txtCorporationName
        '
        Me.txtCorporationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorporationName.Location = New System.Drawing.Point(256, 5)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.ReadOnly = True
        Me.txtCorporationName.Size = New System.Drawing.Size(280, 21)
        Me.txtCorporationName.TabIndex = 20
        Me.txtCorporationName.TabStop = False
        Me.txtCorporationName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 5)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 19
        Me.txtProjectCode.TabStop = False
        Me.txtProjectCode.Text = ""
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(297, 408)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 22
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(209, 408)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 23
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConferenceTrial.Image = CType(resources.GetObject("btnConferenceTrial.Image"), System.Drawing.Bitmap)
        Me.btnConferenceTrial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConferenceTrial.ImageIndex = 26
        Me.btnConferenceTrial.ImageList = Me.ImageListBasic
        Me.btnConferenceTrial.Location = New System.Drawing.Point(64, 408)
        Me.btnConferenceTrial.Name = "btnConferenceTrial"
        Me.btnConferenceTrial.Size = New System.Drawing.Size(136, 23)
        Me.btnConferenceTrial.TabIndex = 24
        Me.btnConferenceTrial.Text = "查看评审会结论(&V)"
        Me.btnConferenceTrial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRegisterLoanInfo_zdb
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(546, 439)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblCorporationName, Me.lblProjectCode, Me.btnExit, Me.btnConferenceTrial, Me.btnSave, Me.btnCommit, Me.grpBaseInfo, Me.txtCorporationName, Me.txtProjectCode})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRegisterLoanInfo_zdb"
        Me.Text = "登记放款信息"
        Me.grpBaseInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsTemp As DataSet
    Private dsBank As DataSet
    Protected bFormLoad As Boolean = False  '窗体是否load完毕
    Protected bIsChanged As Boolean = False '数据是否改变
    
    Private Sub FRegisterLoanInfo_zdb_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.InitCombo()
            Me.GetData()
            Me.bFormLoad = True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '初始化ComboBox
    Private Sub InitCombo()
        dsBank = gWs.GetBankInfo("%", "%")
        If Not dsBank.Tables("bank").Rows.Count = 0 Then
            dsBank.Tables("bank").DefaultView.Sort = "bank_name"
            Me.cboBank.DataSource = dsBank.Tables("bank").DefaultView
            Me.cboBank.DisplayMember = "bank_name"
            Me.cboBank.ValueMember = "bank_code"
            Me.cboBank.SelectedIndex = 0
        End If
        dsBank.Tables("bank_branch").DefaultView.Sort = "branch_bank_name"
        Me.cboBranch_bank.DataSource = dsBank.Tables("bank_branch").DefaultView
        Me.cboBranch_bank.DisplayMember = "branch_bank_name"
        Me.cboBranch_bank.ValueMember = "branch_bank_code"
        BankChanged(Nothing, Nothing)
        AddHandler cboBank.SelectedIndexChanged, AddressOf BankChanged
    End Sub

    Private Sub GetData()
        Me.txtProjectCode.Text = Me.getProjectCode()
        Me.txtCorporationName.Text = Me.getCorporationName()
        dsTemp = gWs.GetProjectOrganization("{project_code = '" & Me.getProjectCode() & "'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                Me.txtCounterguarantee.Text = IIf(IsDBNull(.Item("Counterguarantee")), "", .Item("Counterguarantee")) '反担保措施
                Me.txtServiceCondition.Text = IIf(IsDBNull(.Item("ServiceCondition")), "", .Item("ServiceCondition")) '贷款使用条件
                If Not IsDBNull(.Item("ReguaranteeSum")) Then
                    Me.txtSourceLoanSum.Text = CGModule.Numeric2Currency(.Item("SourceLoanSum")) '保费总额
                End If
            End With
        End If
        AddHandler txtCounterguarantee.TextChanged, AddressOf DataChanged
        AddHandler txtServiceCondition.TextChanged, AddressOf DataChanged

        dsTemp = gWs.GetReGuaranteeProjectInfo("{ProjectCode = '" & Me.getProjectCode() & "'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                Me.txtOrganizationName.Text = IIf(IsDBNull(.Item("OrganizationName")), "", .Item("OrganizationName")) '再担保机构名
                Me.txtServiceType.Text = IIf(IsDBNull(.Item("ServiceType")), "", .Item("ServiceType"))  '申请业务品种
                Me.txtSourceServiceType.Text = IIf(IsDBNull(.Item("SourceServiceType")), "", .Item("SourceServiceType")) '贷款业务品种
                Me.txtRefundType.Text = IIf(IsDBNull(.Item("RefundType")), "", .Item("RefundType"))     '还款类型
                Me.txtLoanType.Text = IIf(IsDBNull(.Item("LoanType")), "", .Item("LoanType"))           '放款类型    
            End With
        End If
        Dim guarantee_rate As Double = 0
        Dim guarantee_sum As Double = 0
        dsTemp = gWs.GetConfTrialInfo("{project_code = '" & Me.getProjectCode() & "' ORDER BY trial_times DESC}", "NULL")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                Me.dtpStart_Date.Value = gWs.GetSysTime()
                If Not IsDBNull(.Item("terms")) Then
                    Me.dtpEnd_Date.Value = Me.dtpStart_Date.Value.AddMonths(.Item("terms"))        '终止日期
                    Me.txtTerm.Text = IIf(IsDBNull(.Item("terms")), "", .Item("terms")) '贷款期限
                End If
                If Not IsDBNull(.Item("guarantee_rate")) Then
                    guarantee_rate = .Item("guarantee_rate")
                    Me.txtGuarantee_rate.Text = .Item("guarantee_rate").ToString() + "%"          '保费利率
                End If
                If Not IsDBNull(.Item("guarantee_sum")) Then
                    guarantee_sum = .Item("guarantee_sum")
                    Me.txtSum.Text = CGModule.Numeric2Currency(.Item("guarantee_sum"))    '贷款金额
                End If
                Me.txtFee.Text = (guarantee_sum * 10000 * guarantee_rate * 0.01 * 0.2).ToString("N")     '中心应收保费金额（再担保额度*保费利率*20%)
            End With
        End If
        dsTemp = gWs.GetLoanNoticeInfo("{project_code = '" & Me.getProjectCode() & "'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                If Not IsDBNull(.Item("sum")) Then
                    Me.txtSum.Text = CGModule.Numeric2Currency(.Item("sum"))    '贷款金额
                End If
                Me.txtTerm.Text = IIf(IsDBNull(.Item("term")), "", .Item("term")) '贷款期限
                If Not IsDBNull(.Item("bank")) Then
                    Me.cboBank.SelectedValue = .Item("bank")                    '贷款银行  
                End If
                If Not IsDBNull(.Item("branch_bank")) Then
                    Me.cboBranch_bank.SelectedValue = .Item("branch_bank")   '贷款支行　　　　　　
                End If
                Me.dtpStart_Date.Value = IIf(IsDBNull(.Item("start_date")), gWs.GetSysTime(), .Item("start_date")) '贷款起始日

                Me.dtpEnd_Date.Value = IIf(IsDBNull(.Item("end_date")), gWs.GetSysTime(), .Item("end_date"))       '贷款终止日　　　　
            End With
        End If

        AddHandler txtSum.Enter, AddressOf Money.Money_Enter
        AddHandler txtSum.KeyPress, AddressOf Money.Money_KeyPress
        AddHandler txtSum.Leave, AddressOf Money.Money_Leave
        AddHandler txtSum.TextChanged, AddressOf DataChanged
        AddHandler dtpStart_Date.TextChanged, AddressOf txtTerm_TextChanged
    End Sub

    Private Sub BankChanged(ByVal sender As Object, ByVal e As EventArgs)
        dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code = '" & Me.cboBank.SelectedValue & "'"
        dsBank.Tables("bank_branch").DefaultView.Sort = "branch_bank_name"
        Me.DataChanged(Nothing, Nothing)
    End Sub

    Protected Sub DataChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Me.bFormLoad Then
            Me.bIsChanged = True
        End If
    End Sub

    Private Function SaveLoanNotice() As Boolean
        Try
            dsTemp = gWs.GetLoanNoticeInfo("{project_code = '" & Me.getProjectCode() & "'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                With dsTemp.Tables(0).Rows(0)
                    .Item("sum") = CGModule.Currency2Numeric(Me.txtSum.Text)
                    If Not Me.txtTerm.Text = "" Then
                        .Item("term") = CInt(Me.txtTerm.Text)
                    Else
                        .Item("term") = 0
                    End If
                    .Item("bank") = Me.cboBank.SelectedValue
                    .Item("branch_bank") = Me.cboBranch_bank.SelectedValue
                    .Item("start_date") = Me.dtpStart_Date.Value
                    .Item("end_date") = Me.dtpEnd_Date.Value
                End With
            Else
                Dim dr As DataRow = dsTemp.Tables(0).NewRow
                With dr
                    .Item("project_code") = Me.getProjectCode()
                    .Item("sum") = CGModule.Currency2Numeric(Me.txtSum.Text)
                    If Not Me.txtTerm.Text = "" Then
                        .Item("term") = CInt(Me.txtTerm.Text)
                    Else
                        .Item("term") = 0
                    End If
                    .Item("bank") = Me.cboBank.SelectedValue
                    .Item("branch_bank") = Me.cboBranch_bank.SelectedValue
                    .Item("start_date") = Me.dtpStart_Date.Value
                    .Item("end_date") = Me.dtpEnd_Date.Value
                    .Item("create_person") = UserName
                    .Item("create_date") = gWs.GetSysTime()
                End With
                dsTemp.Tables(0).Rows.Add(dr)
            End If
            Dim strResult As String = gWs.UpdateLoanNotice(dsTemp)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存LoanNotice失败", strResult, "登记放款")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    Private Function SaveProjectOrganization() As Boolean
        Try
            dsTemp = gWs.GetProjectOrganization("{project_code = '" & Me.getProjectCode() & "'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                With dsTemp.Tables(0).Rows(0)
                    .Item("Counterguarantee") = Me.txtCounterguarantee.Text
                    .Item("ServiceCondition") = Me.txtServiceCondition.Text
                End With
            End If
            Dim strResult As String = gWs.UpdateProjectOrganization(dsTemp)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存ProjectOrganization失败", strResult, "登记放款")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    Private Function SaveData() As Boolean
        If Me.cboBranch_bank.Text.Trim() = "" Then
            SWDialogBox.MessageBox.Show("$1001", "银行")
            Return False
        End If

        If Not Me.SaveLoanNotice() Then
            Return False
        End If
        If Not Me.SaveProjectOrganization() Then
            Return False
        End If
        Me.bIsChanged = False
        Return True
    End Function

    '查看评审会结论按钮
    Private Sub btnConferenceTrial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConferenceTrial.Click
        Dim meet As New frmMeetRecordQuery(Me.getProjectCode(), Me.getCorporationName())
        meet.AllowTransparency = False
        meet.ShowDialog()
    End Sub
    '保存按钮
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not Me.SaveData() Then
                Return
            End If
            SWDialogBox.MessageBox.Show("$SaveSucceed")
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '提交按钮
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If SWDialogBox.MessageBox.Show("?1000", "提交") <> MsgBoxResult.Yes Then
            Return
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not Me.SaveData() Then
                Return
            End If
            Dim strResult As String = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), "", UserName)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "登记放款")
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
    '退出按钮
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If Not Me.bIsChanged Then
            Me.Close()
            Return
        End If
        Select Case SWDialogBox.MessageBox.Show("?1003")
            Case DialogResult.Yes
                If Not Me.SaveData() Then
                    Return
                End If
                SWDialogBox.MessageBox.Show("$SaveSucceed")
            Case DialogResult.Cancel
                Return
        End Select
        Me.Close()
    End Sub

    '贷款期限只能输入数字
    Private Sub txtTerm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTerm.KeyPress
        e.Handled = Not (((e.KeyChar) >= Convert.ToChar(48) And (e.KeyChar) <= Convert.ToChar(57) Or (e.KeyChar) = Convert.ToChar(8) Or (e.KeyChar) = Convert.ToChar(45)))
    End Sub
    '贷款期限变化，截止日期变化　
    Private Sub txtTerm_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtTerm.TextChanged
        Me.DataChanged(Nothing, Nothing)
        Try
            Me.dtpEnd_Date.Value = Me.dtpStart_Date.Value.AddMonths(CInt(Me.txtTerm.Text))
        Catch
        End Try
    End Sub

End Class
