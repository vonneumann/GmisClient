
'登记保证责任终止通知书
Public Class FGuaranteeLetterTerminate
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
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents dtpRefundDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents txtProjectEvaluate As System.Windows.Forms.TextBox
    Public WithEvents txtTerminateReason As System.Windows.Forms.TextBox
    Public WithEvents chkHighRisk As System.Windows.Forms.CheckBox
    Public WithEvents chkContinueSupport As System.Windows.Forms.CheckBox
    Public WithEvents dtpProjectEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents cboBank As System.Windows.Forms.ComboBox
    Friend WithEvents cboSubBank As System.Windows.Forms.ComboBox
    Protected WithEvents lblProjectCode As System.Windows.Forms.Label
    Protected WithEvents lblCorporationName As System.Windows.Forms.Label
    Protected WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Public WithEvents cboRefundSubBank As System.Windows.Forms.ComboBox
    Public WithEvents cboRefundBank As System.Windows.Forms.ComboBox
    Friend WithEvents lblRefundSubBank As System.Windows.Forms.Label
    Friend WithEvents lblRefundBank As System.Windows.Forms.Label
    Friend WithEvents txtGuaranteeSum As System.Windows.Forms.TextBox
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents txtTerms As System.Windows.Forms.TextBox
    Friend WithEvents lblSubBank As System.Windows.Forms.Label
    Friend WithEvents lblTerms As System.Windows.Forms.Label
    Friend WithEvents lblGuaranteeSum As System.Windows.Forms.Label
    Friend WithEvents grpRefundInfo As System.Windows.Forms.GroupBox
    Friend WithEvents grpBaseInfo As System.Windows.Forms.GroupBox
    Public WithEvents grpTerminateInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblProjectEvaluate As System.Windows.Forms.Label
    Friend WithEvents lblTerminateReason As System.Windows.Forms.Label
    Friend WithEvents lblProjectEndDate As System.Windows.Forms.Label
    Public WithEvents cboTerminateType As System.Windows.Forms.ComboBox
    Friend WithEvents lblTerminateType As System.Windows.Forms.Label
    Public WithEvents pgRefundAttest As System.Windows.Forms.TabPage
    Public WithEvents pgProjectTerminate As System.Windows.Forms.TabPage
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents btnRefundReport As System.Windows.Forms.Button
    Public WithEvents btnTerminateReport As System.Windows.Forms.Button
    Protected WithEvents txtAssureContract_num As System.Windows.Forms.TextBox
    Protected WithEvents lblAssureContract_num As System.Windows.Forms.Label
    Protected WithEvents txtLoanContract_num As System.Windows.Forms.TextBox
    Protected WithEvents lblLoanContract_num As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FGuaranteeLetterTerminate))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.pgRefundAttest = New System.Windows.Forms.TabPage
        Me.btnRefundReport = New System.Windows.Forms.Button
        Me.grpRefundInfo = New System.Windows.Forms.GroupBox
        Me.txtAssureContract_num = New System.Windows.Forms.TextBox
        Me.lblAssureContract_num = New System.Windows.Forms.Label
        Me.txtLoanContract_num = New System.Windows.Forms.TextBox
        Me.lblLoanContract_num = New System.Windows.Forms.Label
        Me.dtpRefundDate = New System.Windows.Forms.DateTimePicker
        Me.cboRefundSubBank = New System.Windows.Forms.ComboBox
        Me.cboRefundBank = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblRefundSubBank = New System.Windows.Forms.Label
        Me.lblRefundBank = New System.Windows.Forms.Label
        Me.grpBaseInfo = New System.Windows.Forms.GroupBox
        Me.txtGuaranteeSum = New System.Windows.Forms.TextBox
        Me.lblBank = New System.Windows.Forms.Label
        Me.cboBank = New System.Windows.Forms.ComboBox
        Me.cboSubBank = New System.Windows.Forms.ComboBox
        Me.txtTerms = New System.Windows.Forms.TextBox
        Me.lblSubBank = New System.Windows.Forms.Label
        Me.lblTerms = New System.Windows.Forms.Label
        Me.lblGuaranteeSum = New System.Windows.Forms.Label
        Me.pgProjectTerminate = New System.Windows.Forms.TabPage
        Me.grpTerminateInfo = New System.Windows.Forms.GroupBox
        Me.txtProjectEvaluate = New System.Windows.Forms.TextBox
        Me.txtTerminateReason = New System.Windows.Forms.TextBox
        Me.lblProjectEvaluate = New System.Windows.Forms.Label
        Me.chkHighRisk = New System.Windows.Forms.CheckBox
        Me.chkContinueSupport = New System.Windows.Forms.CheckBox
        Me.lblTerminateReason = New System.Windows.Forms.Label
        Me.dtpProjectEndDate = New System.Windows.Forms.DateTimePicker
        Me.lblProjectEndDate = New System.Windows.Forms.Label
        Me.cboTerminateType = New System.Windows.Forms.ComboBox
        Me.lblTerminateType = New System.Windows.Forms.Label
        Me.btnTerminateReport = New System.Windows.Forms.Button
        Me.btnCommit = New System.Windows.Forms.Button
        Me.lblProjectCode = New System.Windows.Forms.Label
        Me.lblCorporationName = New System.Windows.Forms.Label
        Me.txtCorporationName = New System.Windows.Forms.TextBox
        Me.txtProjectCode = New System.Windows.Forms.TextBox
        Me.btnSave = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.pgRefundAttest.SuspendLayout()
        Me.grpRefundInfo.SuspendLayout()
        Me.grpBaseInfo.SuspendLayout()
        Me.pgProjectTerminate.SuspendLayout()
        Me.grpTerminateInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(317, 432)
        Me.btnExit.Name = "btnExit"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.pgRefundAttest)
        Me.TabControl1.Controls.Add(Me.pgProjectTerminate)
        Me.TabControl1.Location = New System.Drawing.Point(9, 35)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(519, 392)
        Me.TabControl1.TabIndex = 10
        '
        'pgRefundAttest
        '
        Me.pgRefundAttest.Controls.Add(Me.btnRefundReport)
        Me.pgRefundAttest.Controls.Add(Me.grpRefundInfo)
        Me.pgRefundAttest.Controls.Add(Me.grpBaseInfo)
        Me.pgRefundAttest.Location = New System.Drawing.Point(4, 21)
        Me.pgRefundAttest.Name = "pgRefundAttest"
        Me.pgRefundAttest.Size = New System.Drawing.Size(511, 367)
        Me.pgRefundAttest.TabIndex = 0
        Me.pgRefundAttest.Text = "管理还款证明"
        '
        'btnRefundReport
        '
        Me.btnRefundReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefundReport.ImageIndex = 25
        Me.btnRefundReport.ImageList = Me.ImageListBasic
        Me.btnRefundReport.Location = New System.Drawing.Point(312, 328)
        Me.btnRefundReport.Name = "btnRefundReport"
        Me.btnRefundReport.Size = New System.Drawing.Size(184, 23)
        Me.btnRefundReport.TabIndex = 55
        Me.btnRefundReport.Text = "上载保证责任终止通知书(&U)"
        Me.btnRefundReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpRefundInfo
        '
        Me.grpRefundInfo.Controls.Add(Me.txtAssureContract_num)
        Me.grpRefundInfo.Controls.Add(Me.lblAssureContract_num)
        Me.grpRefundInfo.Controls.Add(Me.txtLoanContract_num)
        Me.grpRefundInfo.Controls.Add(Me.lblLoanContract_num)
        Me.grpRefundInfo.Controls.Add(Me.dtpRefundDate)
        Me.grpRefundInfo.Controls.Add(Me.cboRefundSubBank)
        Me.grpRefundInfo.Controls.Add(Me.cboRefundBank)
        Me.grpRefundInfo.Controls.Add(Me.Label13)
        Me.grpRefundInfo.Controls.Add(Me.lblRefundSubBank)
        Me.grpRefundInfo.Controls.Add(Me.lblRefundBank)
        Me.grpRefundInfo.Location = New System.Drawing.Point(8, 96)
        Me.grpRefundInfo.Name = "grpRefundInfo"
        Me.grpRefundInfo.Size = New System.Drawing.Size(496, 104)
        Me.grpRefundInfo.TabIndex = 50
        Me.grpRefundInfo.TabStop = False
        Me.grpRefundInfo.Text = "项目还款信息"
        '
        'txtAssureContract_num
        '
        Me.txtAssureContract_num.Location = New System.Drawing.Point(336, 72)
        Me.txtAssureContract_num.MaxLength = 30
        Me.txtAssureContract_num.Name = "txtAssureContract_num"
        Me.txtAssureContract_num.Size = New System.Drawing.Size(144, 21)
        Me.txtAssureContract_num.TabIndex = 57
        Me.txtAssureContract_num.Text = ""
        '
        'lblAssureContract_num
        '
        Me.lblAssureContract_num.Location = New System.Drawing.Point(256, 72)
        Me.lblAssureContract_num.Name = "lblAssureContract_num"
        Me.lblAssureContract_num.Size = New System.Drawing.Size(100, 16)
        Me.lblAssureContract_num.TabIndex = 56
        Me.lblAssureContract_num.Text = "保证合同号"
        '
        'txtLoanContract_num
        '
        Me.txtLoanContract_num.Location = New System.Drawing.Point(96, 72)
        Me.txtLoanContract_num.MaxLength = 30
        Me.txtLoanContract_num.Name = "txtLoanContract_num"
        Me.txtLoanContract_num.Size = New System.Drawing.Size(144, 21)
        Me.txtLoanContract_num.TabIndex = 55
        Me.txtLoanContract_num.Text = ""
        '
        'lblLoanContract_num
        '
        Me.lblLoanContract_num.Location = New System.Drawing.Point(8, 72)
        Me.lblLoanContract_num.Name = "lblLoanContract_num"
        Me.lblLoanContract_num.Size = New System.Drawing.Size(100, 16)
        Me.lblLoanContract_num.TabIndex = 54
        Me.lblLoanContract_num.Text = "借款合同号"
        '
        'dtpRefundDate
        '
        Me.dtpRefundDate.Location = New System.Drawing.Point(96, 46)
        Me.dtpRefundDate.Name = "dtpRefundDate"
        Me.dtpRefundDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpRefundDate.TabIndex = 3
        '
        'cboRefundSubBank
        '
        Me.cboRefundSubBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRefundSubBank.Location = New System.Drawing.Point(336, 22)
        Me.cboRefundSubBank.Name = "cboRefundSubBank"
        Me.cboRefundSubBank.Size = New System.Drawing.Size(144, 20)
        Me.cboRefundSubBank.TabIndex = 2
        '
        'cboRefundBank
        '
        Me.cboRefundBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRefundBank.Location = New System.Drawing.Point(96, 22)
        Me.cboRefundBank.Name = "cboRefundBank"
        Me.cboRefundBank.Size = New System.Drawing.Size(144, 20)
        Me.cboRefundBank.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 16)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "解除日期"
        '
        'lblRefundSubBank
        '
        Me.lblRefundSubBank.Location = New System.Drawing.Point(256, 24)
        Me.lblRefundSubBank.Name = "lblRefundSubBank"
        Me.lblRefundSubBank.Size = New System.Drawing.Size(64, 16)
        Me.lblRefundSubBank.TabIndex = 46
        Me.lblRefundSubBank.Text = "还款支行"
        '
        'lblRefundBank
        '
        Me.lblRefundBank.Location = New System.Drawing.Point(8, 24)
        Me.lblRefundBank.Name = "lblRefundBank"
        Me.lblRefundBank.Size = New System.Drawing.Size(64, 16)
        Me.lblRefundBank.TabIndex = 45
        Me.lblRefundBank.Text = "还款银行 "
        '
        'grpBaseInfo
        '
        Me.grpBaseInfo.Controls.Add(Me.txtGuaranteeSum)
        Me.grpBaseInfo.Controls.Add(Me.lblBank)
        Me.grpBaseInfo.Controls.Add(Me.cboBank)
        Me.grpBaseInfo.Controls.Add(Me.cboSubBank)
        Me.grpBaseInfo.Controls.Add(Me.txtTerms)
        Me.grpBaseInfo.Controls.Add(Me.lblSubBank)
        Me.grpBaseInfo.Controls.Add(Me.lblTerms)
        Me.grpBaseInfo.Controls.Add(Me.lblGuaranteeSum)
        Me.grpBaseInfo.Location = New System.Drawing.Point(8, 8)
        Me.grpBaseInfo.Name = "grpBaseInfo"
        Me.grpBaseInfo.Size = New System.Drawing.Size(496, 80)
        Me.grpBaseInfo.TabIndex = 49
        Me.grpBaseInfo.TabStop = False
        Me.grpBaseInfo.Text = "项目基本信息"
        '
        'txtGuaranteeSum
        '
        Me.txtGuaranteeSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuaranteeSum.Location = New System.Drawing.Point(96, 22)
        Me.txtGuaranteeSum.Name = "txtGuaranteeSum"
        Me.txtGuaranteeSum.ReadOnly = True
        Me.txtGuaranteeSum.Size = New System.Drawing.Size(144, 21)
        Me.txtGuaranteeSum.TabIndex = 1
        Me.txtGuaranteeSum.Text = "0"
        Me.txtGuaranteeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblBank
        '
        Me.lblBank.Location = New System.Drawing.Point(8, 48)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(56, 16)
        Me.lblBank.TabIndex = 52
        Me.lblBank.Text = "出函银行"
        '
        'cboBank
        '
        Me.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBank.Enabled = False
        Me.cboBank.Location = New System.Drawing.Point(96, 46)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(144, 20)
        Me.cboBank.TabIndex = 5
        '
        'cboSubBank
        '
        Me.cboSubBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubBank.Enabled = False
        Me.cboSubBank.Location = New System.Drawing.Point(336, 46)
        Me.cboSubBank.Name = "cboSubBank"
        Me.cboSubBank.Size = New System.Drawing.Size(144, 20)
        Me.cboSubBank.TabIndex = 6
        '
        'txtTerms
        '
        Me.txtTerms.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerms.Location = New System.Drawing.Point(336, 22)
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.ReadOnly = True
        Me.txtTerms.Size = New System.Drawing.Size(144, 21)
        Me.txtTerms.TabIndex = 2
        Me.txtTerms.Text = ""
        Me.txtTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSubBank
        '
        Me.lblSubBank.Location = New System.Drawing.Point(256, 48)
        Me.lblSubBank.Name = "lblSubBank"
        Me.lblSubBank.Size = New System.Drawing.Size(54, 16)
        Me.lblSubBank.TabIndex = 53
        Me.lblSubBank.Text = "出函支行"
        '
        'lblTerms
        '
        Me.lblTerms.Location = New System.Drawing.Point(256, 24)
        Me.lblTerms.Name = "lblTerms"
        Me.lblTerms.Size = New System.Drawing.Size(88, 16)
        Me.lblTerms.TabIndex = 57
        Me.lblTerms.Text = "保函期限(月)"
        '
        'lblGuaranteeSum
        '
        Me.lblGuaranteeSum.Location = New System.Drawing.Point(8, 24)
        Me.lblGuaranteeSum.Name = "lblGuaranteeSum"
        Me.lblGuaranteeSum.Size = New System.Drawing.Size(96, 16)
        Me.lblGuaranteeSum.TabIndex = 56
        Me.lblGuaranteeSum.Text = "保函额度(万元)"
        '
        'pgProjectTerminate
        '
        Me.pgProjectTerminate.Controls.Add(Me.grpTerminateInfo)
        Me.pgProjectTerminate.Controls.Add(Me.btnTerminateReport)
        Me.pgProjectTerminate.Location = New System.Drawing.Point(4, 21)
        Me.pgProjectTerminate.Name = "pgProjectTerminate"
        Me.pgProjectTerminate.Size = New System.Drawing.Size(511, 367)
        Me.pgProjectTerminate.TabIndex = 1
        Me.pgProjectTerminate.Text = "管理项目终止报告"
        Me.pgProjectTerminate.Visible = False
        '
        'grpTerminateInfo
        '
        Me.grpTerminateInfo.Controls.Add(Me.txtProjectEvaluate)
        Me.grpTerminateInfo.Controls.Add(Me.txtTerminateReason)
        Me.grpTerminateInfo.Controls.Add(Me.lblProjectEvaluate)
        Me.grpTerminateInfo.Controls.Add(Me.chkHighRisk)
        Me.grpTerminateInfo.Controls.Add(Me.chkContinueSupport)
        Me.grpTerminateInfo.Controls.Add(Me.lblTerminateReason)
        Me.grpTerminateInfo.Controls.Add(Me.dtpProjectEndDate)
        Me.grpTerminateInfo.Controls.Add(Me.lblProjectEndDate)
        Me.grpTerminateInfo.Controls.Add(Me.cboTerminateType)
        Me.grpTerminateInfo.Controls.Add(Me.lblTerminateType)
        Me.grpTerminateInfo.Location = New System.Drawing.Point(8, 8)
        Me.grpTerminateInfo.Name = "grpTerminateInfo"
        Me.grpTerminateInfo.Size = New System.Drawing.Size(496, 304)
        Me.grpTerminateInfo.TabIndex = 2
        Me.grpTerminateInfo.TabStop = False
        '
        'txtProjectEvaluate
        '
        Me.txtProjectEvaluate.Location = New System.Drawing.Point(88, 184)
        Me.txtProjectEvaluate.Multiline = True
        Me.txtProjectEvaluate.Name = "txtProjectEvaluate"
        Me.txtProjectEvaluate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProjectEvaluate.Size = New System.Drawing.Size(392, 112)
        Me.txtProjectEvaluate.TabIndex = 24
        Me.txtProjectEvaluate.Text = ""
        '
        'txtTerminateReason
        '
        Me.txtTerminateReason.Location = New System.Drawing.Point(88, 80)
        Me.txtTerminateReason.Multiline = True
        Me.txtTerminateReason.Name = "txtTerminateReason"
        Me.txtTerminateReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTerminateReason.Size = New System.Drawing.Size(392, 96)
        Me.txtTerminateReason.TabIndex = 23
        Me.txtTerminateReason.Text = ""
        '
        'lblProjectEvaluate
        '
        Me.lblProjectEvaluate.Location = New System.Drawing.Point(8, 192)
        Me.lblProjectEvaluate.Name = "lblProjectEvaluate"
        Me.lblProjectEvaluate.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectEvaluate.TabIndex = 22
        Me.lblProjectEvaluate.Text = "项目评价"
        '
        'chkHighRisk
        '
        Me.chkHighRisk.Location = New System.Drawing.Point(88, 48)
        Me.chkHighRisk.Name = "chkHighRisk"
        Me.chkHighRisk.Size = New System.Drawing.Size(120, 24)
        Me.chkHighRisk.TabIndex = 13
        Me.chkHighRisk.Text = "是否高风险"
        '
        'chkContinueSupport
        '
        Me.chkContinueSupport.Location = New System.Drawing.Point(240, 48)
        Me.chkContinueSupport.Name = "chkContinueSupport"
        Me.chkContinueSupport.Size = New System.Drawing.Size(144, 24)
        Me.chkContinueSupport.TabIndex = 14
        Me.chkContinueSupport.Text = "是否继续支持该企业"
        '
        'lblTerminateReason
        '
        Me.lblTerminateReason.Location = New System.Drawing.Point(8, 88)
        Me.lblTerminateReason.Name = "lblTerminateReason"
        Me.lblTerminateReason.Size = New System.Drawing.Size(80, 16)
        Me.lblTerminateReason.TabIndex = 19
        Me.lblTerminateReason.Text = "终止原因说明"
        '
        'dtpProjectEndDate
        '
        Me.dtpProjectEndDate.Location = New System.Drawing.Point(88, 22)
        Me.dtpProjectEndDate.Name = "dtpProjectEndDate"
        Me.dtpProjectEndDate.Size = New System.Drawing.Size(136, 21)
        Me.dtpProjectEndDate.TabIndex = 11
        '
        'lblProjectEndDate
        '
        Me.lblProjectEndDate.Location = New System.Drawing.Point(8, 24)
        Me.lblProjectEndDate.Name = "lblProjectEndDate"
        Me.lblProjectEndDate.Size = New System.Drawing.Size(80, 16)
        Me.lblProjectEndDate.TabIndex = 17
        Me.lblProjectEndDate.Text = "项目终止日期"
        '
        'cboTerminateType
        '
        Me.cboTerminateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTerminateType.Location = New System.Drawing.Point(320, 22)
        Me.cboTerminateType.Name = "cboTerminateType"
        Me.cboTerminateType.Size = New System.Drawing.Size(160, 20)
        Me.cboTerminateType.TabIndex = 12
        '
        'lblTerminateType
        '
        Me.lblTerminateType.Location = New System.Drawing.Point(240, 24)
        Me.lblTerminateType.Name = "lblTerminateType"
        Me.lblTerminateType.Size = New System.Drawing.Size(80, 16)
        Me.lblTerminateType.TabIndex = 15
        Me.lblTerminateType.Text = "项目终止类型"
        '
        'btnTerminateReport
        '
        Me.btnTerminateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTerminateReport.ImageIndex = 19
        Me.btnTerminateReport.ImageList = Me.ImageListBasic
        Me.btnTerminateReport.Location = New System.Drawing.Point(352, 328)
        Me.btnTerminateReport.Name = "btnTerminateReport"
        Me.btnTerminateReport.Size = New System.Drawing.Size(144, 23)
        Me.btnTerminateReport.TabIndex = 17
        Me.btnTerminateReport.Text = "制作项目终止报告(&M)"
        Me.btnTerminateReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(229, 432)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 12
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Location = New System.Drawing.Point(16, 8)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(54, 16)
        Me.lblProjectCode.TabIndex = 114
        Me.lblProjectCode.Text = "项目编码"
        Me.lblProjectCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Location = New System.Drawing.Point(168, 8)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(54, 16)
        Me.lblCorporationName.TabIndex = 113
        Me.lblCorporationName.Text = "企业名称"
        Me.lblCorporationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorporationName
        '
        Me.txtCorporationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorporationName.Location = New System.Drawing.Point(224, 6)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.ReadOnly = True
        Me.txtCorporationName.Size = New System.Drawing.Size(304, 21)
        Me.txtCorporationName.TabIndex = 115
        Me.txtCorporationName.TabStop = False
        Me.txtCorporationName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 6)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(80, 21)
        Me.txtProjectCode.TabIndex = 116
        Me.txtProjectCode.TabStop = False
        Me.txtProjectCode.Text = ""
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(141, 432)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 117
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FGuaranteeLetterTerminate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(538, 463)
        Me.Controls.Add(Me.lblProjectCode)
        Me.Controls.Add(Me.lblCorporationName)
        Me.Controls.Add(Me.txtCorporationName)
        Me.Controls.Add(Me.txtProjectCode)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCommit)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FGuaranteeLetterTerminate"
        Me.Text = "登记保证责任终止通知书"
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.Controls.SetChildIndex(Me.txtCorporationName, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.lblCorporationName, 0)
        Me.Controls.SetChildIndex(Me.lblProjectCode, 0)
        Me.TabControl1.ResumeLayout(False)
        Me.pgRefundAttest.ResumeLayout(False)
        Me.grpRefundInfo.ResumeLayout(False)
        Me.grpBaseInfo.ResumeLayout(False)
        Me.pgProjectTerminate.ResumeLayout(False)
        Me.grpTerminateInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private bFormLoad As Boolean = False
    Private bIsChanged As Boolean = False
    Private dsBank, dsRefundBank As DataSet

    Private Sub FGuaranteeLetterTerminate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.InitComboBox()
            Me.GetProjectBaseInfo()
            Me.GetProjectRefundInfo()
            Me.GetProjectTerminateInfo()
            Me.bFormLoad = True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub InitComboBox()
        '申请贷款银行
        Me.dsBank = gWs.GetBankInfo("%", "%")
        Me.cboBank.DataSource = dsBank.Tables("bank")
        Me.cboBank.DisplayMember = "bank_name"
        Me.cboBank.ValueMember = "bank_code"
        Me.cboSubBank.DataSource = dsBank.Tables("bank_branch").DefaultView
        Me.cboSubBank.DisplayMember = "branch_bank_name"
        Me.cboSubBank.ValueMember = "branch_bank_code"
        AddHandler cboBank.SelectedIndexChanged, AddressOf BankChanged
        BankChanged(Nothing, Nothing)
        '还款银行
        Me.dsRefundBank = gWs.GetBankInfo("%", "%")
        If Not dsRefundBank.Tables("bank").Rows.Count = 0 Then
            dsRefundBank.Tables("bank").DefaultView.Sort = "bank_name"
            Me.cboRefundBank.DataSource = dsRefundBank.Tables("bank").DefaultView
            Me.cboRefundBank.DisplayMember = "bank_name"
            Me.cboRefundBank.ValueMember = "bank_code"
            Me.cboRefundBank.SelectedIndex = 0
        End If
        dsRefundBank.Tables("bank_branch").DefaultView.Sort = "branch_bank_name"
        Me.cboRefundSubBank.DataSource = dsRefundBank.Tables("bank_branch").DefaultView
        Me.cboRefundSubBank.DisplayMember = "branch_bank_name"
        Me.cboRefundSubBank.ValueMember = "branch_bank_code"
        AddHandler cboRefundBank.SelectedIndexChanged, AddressOf RefundBankChanged
        RefundBankChanged(Nothing, Nothing)
        Dim tempDS As DataSet
        '取得项目终止类型
        tempDS = gWs.GetTerminateType("%")
        If Not tempDS.Tables(0).Rows.Count = 0 Then
            Me.cboTerminateType.DataSource = tempDS.Tables(0)
            Me.cboTerminateType.DisplayMember = "terminate_type"
            Me.cboTerminateType.ValueMember = "terminate_type"
        End If
    End Sub

    '根据银行编码初始化支行的ComboBox
    Protected Sub BankChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code='" & Me.cboBank.SelectedValue & "'"
    End Sub
    Private Sub RefundBankChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.dsRefundBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code='" & Me.cboRefundBank.SelectedValue & "'"
        Me.dsRefundBank.Tables("bank_branch").DefaultView.Sort = "branch_bank_name"

        Page0_HasChanged(Nothing, Nothing)
    End Sub

    '项目基本信息
    Private Sub GetProjectBaseInfo()
        Me.txtProjectCode.Text = Me.getProjectCode()
        Me.txtCorporationName.Text = Me.getCorporationName()
        Dim tempDS As DataSet
        tempDS = gWs.GetLoanNoticeInfo("{project_code='" & Me.getProjectCode() & "'}")
        If Not tempDS.Tables(0).Rows.Count = 0 Then
            With tempDS.Tables(0).Rows(0)
                Me.txtGuaranteeSum.Text = IIf(.Item("sum") Is DBNull.Value, "0", .Item("sum"))
                Me.txtTerms.Text = IIf(.Item("term") Is DBNull.Value, "0", .Item("term"))
                If Not .Item("bank") Is System.DBNull.Value Then
                    Me.cboBank.SelectedValue = .Item("bank")
                    Me.BankChanged(Nothing, Nothing)
                End If
                If Not .Item("branch_bank") Is System.DBNull.Value Then
                    Me.cboSubBank.SelectedValue = .Item("branch_bank")
                End If
            End With
        End If
    End Sub
    '获取偿还信息
    Private Sub GetProjectRefundInfo()
        Dim TempDS As DataSet
        TempDS = gWs.GetRefundCertificateInfo("{project_code='" & Me.getProjectCode() & "'}")
        If Not TempDS.Tables(0).Rows.Count = 0 Then
            With TempDS.Tables(0).Rows(0)
                If Not .Item("bank") Is DBNull.Value Then
                    Me.cboRefundBank.SelectedValue = .Item("bank")
                    Me.RefundBankChanged(Nothing, Nothing)
                End If
                If Not .Item("branch_bank") Is DBNull.Value Then
                    Me.cboRefundSubBank.SelectedValue = .Item("branch_bank")
                End If
                If Not .Item("refund_date") Is DBNull.Value Then
                    Me.dtpRefundDate.Value = .Item("refund_date")
                End If
                Me.txtLoanContract_num.Text = IIf(IsDBNull(.Item("loanContract_num")), "", .Item("loanContract_num"))   '借款合同号　
                Me.txtAssureContract_num.Text = IIf(IsDBNull(.Item("assureContract_num")), "", .Item("assureContract_num")) '保证合同号
            End With
        End If
        AddHandler dtpRefundDate.TextChanged, AddressOf DataHasChanged
        AddHandler txtLoanContract_num.TextChanged, AddressOf DataHasChanged
        AddHandler txtAssureContract_num.TextChanged, AddressOf DataHasChanged
    End Sub
    '获取项目终止信息
    Private Sub GetProjectTerminateInfo()
        Dim tempDS As DataSet
        tempDS = gWs.GetTerminateReportInfo("{project_code='" & Me.getProjectCode() & "'}")
        If Not tempDS.Tables(0).Rows.Count = 0 Then
            With tempDS.Tables(0).Rows(0)
                If Not .Item("terminate_date") Is DBNull.Value Then    '终止日期
                    Me.dtpProjectEndDate.Value = .Item("terminate_date")
                End If
                If Not .Item("terminate_type") Is DBNull.Value Then    '终止类型
                    Me.cboTerminateType.SelectedValue = .Item("terminate_type")
                End If
                Me.txtTerminateReason.Text = IIf(.Item("detail_reason") Is DBNull.Value, "", .Item("detail_reason"))  '终止原因
                Me.txtProjectEvaluate.Text = IIf(.Item("appraisement") Is DBNull.Value, "", .Item("appraisement"))    '项目评价
                If Not .Item("is_high_risk") Is DBNull.Value Then      '是否高风险
                    If .Item("is_high_risk") = "1" Then
                        Me.chkHighRisk.Checked = True
                    End If
                End If
                If Not .Item("is_continue_support") Is DBNull.Value Then '是否继续支持
                    If .Item("is_continue_support") = "1" Then
                        Me.chkContinueSupport.Checked = True
                    End If
                End If
            End With
        End If
        AddHandler cboTerminateType.SelectedIndexChanged, AddressOf Page1_HasChanged
        AddHandler dtpProjectEndDate.TextChanged, AddressOf DataHasChanged
        AddHandler txtTerminateReason.TextChanged, AddressOf DataHasChanged
        AddHandler txtProjectEvaluate.TextChanged, AddressOf DataHasChanged
        AddHandler chkHighRisk.CheckedChanged, AddressOf DataHasChanged
        AddHandler chkContinueSupport.CheckedChanged, AddressOf DataHasChanged
    End Sub

    Private Sub DataHasChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Me.bFormLoad Then
            bIsChanged = True
        End If
    End Sub

    Private Sub Page0_HasChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Me.bFormLoad And Me.intTabIndex = 0 Then
            bIsChanged = True
        End If
    End Sub

    Private Sub Page1_HasChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Me.bFormLoad And Me.intTabIndex = 1 Then
            bIsChanged = True
        End If
    End Sub

    Private intTabIndex As Integer  '避免TabPage的index变化后，ComboBox不必要的初始化
    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        Me.intTabIndex = Me.TabControl1.SelectedIndex
    End Sub

    Private Function SaveData() As Boolean
        Try
            If Not Me.CheckData() Then
                return False 
            End If
            If Not Me.SaveRefund() Then
                Return False
            End If
            If Not Me.SaveTerminate() Then
                Return False
            End If
            Me.bIsChanged = False
            Return True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '保存前对数据进行校验
    Private Function CheckData() As Boolean
        If Me.cboRefundSubBank.Text = "" Then
            SWDialogBox.MessageBox.Show("$1007", "还款信息银行支行")
            Return False
        End If
        If Me.cboTerminateType.Text = "" Then
            SWDialogBox.MessageBox.Show("$1007", "项目终止类型")
            Return False
        End If
        Return True
        ''借款合同号，和保证合同号至少有一个必须输入正确　
        'Dim dsTemp As DataSet = gWs.GetProjectSignatureInfo("{project_code LIKE '" & Me.getProjectCode() & "'}")
        'If Not dsTemp.Tables(0).Rows.Count = 0 Then
        '    With dsTemp.Tables(0).Rows(0)
        '        If Not IsDBNull(.Item("loanContract_num")) Then
        '            If Me.txtLoanContract_num.Text = CStr(.Item("loanContract_num")) Then '借款合同号　
        '                Return True
        '            End If
        '        End If
        '        If Not IsDBNull(.Item("assureContract_num")) Then
        '            If Me.txtAssureContract_num.Text = CStr(.Item("assureContract_num")) Then '保证合同号
        '                Return True
        '            End If
        '        End If
        '    End With
        '    SWDialogBox.MessageBox.Show("借款合同号，和保证合同号至少有一个必须输入正确!", "提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
        '    Return False
        'Else
        '    If DialogResult.Yes = SWDialogBox.MessageBox.Show("未取到登记签约有关信息，是否继续？", "提示", "", SWDialogBox.MessageBoxButton.YesNo, SWDialogBox.MessageBoxIcon.Question) Then
        '        Return True
        '    End If
        '    Return False
        'End If

    End Function
    '保存放款信息
    Protected Overridable Function SaveRefund() As Boolean
        Dim tempDS As DataSet
        Dim strResult As String
        Try
            tempDS = gWs.GetRefundCertificateInfo("{project_code='" & Me.getProjectCode() & "'}")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    .Item("bank") = Me.cboRefundBank.SelectedValue
                    .Item("branch_bank") = Me.cboRefundSubBank.SelectedValue
                    .Item("refund_date") = Me.dtpRefundDate.Value
                    .Item("loanContract_num") = Me.txtLoanContract_num.Text.Trim() '借款合同号　
                    .Item("assureContract_num") = Me.txtAssureContract_num.Text.Trim() '保证合同号
                End With
            Else
                Dim dr As DataRow = tempDS.Tables(0).NewRow()
                With dr
                    .Item("project_code") = Me.getProjectCode()
                    .Item("bank") = Me.cboRefundBank.SelectedValue
                    .Item("branch_bank") = Me.cboRefundSubBank.SelectedValue
                    .Item("refund_date") = Me.dtpRefundDate.Value
                    .Item("sum") = Convert.ToDecimal(Me.txtGuaranteeSum.Text)
                    .Item("loanContract_num") = Me.txtLoanContract_num.Text.Trim() '借款合同号　
                    .Item("assureContract_num") = Me.txtAssureContract_num.Text.Trim() '保证合同号
                End With
                tempDS.Tables(0).Rows.Add(dr)
            End If
            strResult = gWs.UpdateRefundCertificate(tempDS)
            If strResult <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "更新还款证明审核意见失败", strResult, "")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '保存项目终止信息
    Protected Function SaveTerminate() As Boolean
        Dim tempDS As DataSet
        Dim strResult As String
        Try
            tempDS = gWs.GetcorporationInfo("{corporation_code='" & Me.getProjectCode() & "'}", "null")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    .Item("is_high_risk") = Me.chkHighRisk.Checked
                    .Item("is_continue_support") = Me.chkContinueSupport.Checked
                End With
            End If
            strResult = gWs.UpdateCorCon(tempDS)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "更新企业信息操作失败", strResult, "")
                Return False
            End If
            tempDS = gWs.GetTerminateReportInfo("{project_code='" & Me.getProjectCode() & "'}")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    .Item("terminate_type") = Me.cboTerminateType.Text
                    .Item("terminate_date") = Me.dtpProjectEndDate.Value
                    .Item("detail_reason") = Me.txtTerminateReason.Text
                    .Item("appraisement") = Me.txtProjectEvaluate.Text
                    .Item("is_high_risk") = Me.chkHighRisk.Checked
                    .Item("is_continue_support") = Me.chkContinueSupport.Checked
                    .Item("create_date") = gWs.GetSysTime()
                    .Item("create_person") = UserName
                End With
            Else
                Dim dr As DataRow = tempDS.Tables(0).NewRow()
                With dr
                    .Item("project_code") = Me.getProjectCode()
                    .Item("terminate_type") = Me.cboTerminateType.Text
                    .Item("terminate_date") = Me.dtpProjectEndDate.Value
                    .Item("detail_reason") = Me.txtTerminateReason.Text
                    .Item("appraisement") = Me.txtProjectEvaluate.Text
                    .Item("is_high_risk") = Me.chkHighRisk.Checked
                    .Item("is_continue_support") = Me.chkContinueSupport.Checked
                    .Item("create_date") = gWs.GetSysTime()
                    .Item("create_person") = UserName
                End With
                tempDS.Tables(0).Rows.Add(dr)
            End If
            strResult = gWs.UpdateTerminateReport(tempDS)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "项目终止报告更新操作失败", strResult, "")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
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
            If Not Me.SaveData() Then
                Return
            End If
            Dim strResult As String
            strResult = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), "", UserName)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "登记保证责任终止通知书")
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

    Private Sub btnRefundReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefundReport.Click
        Dim frm As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "45", "012", UserName)
        frm.AllowTransparency = False
        frm.Text = "上载保证责任终止通知书"
        frm.setMakeDocEnable(False)
        frm.ShowDialog()
    End Sub

    Private Sub btnTerminateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminateReport.Click
        Dim frm As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "45", "004", UserName)
        frm.AllowTransparency = False
        frm.ShowDialog()
    End Sub


End Class
