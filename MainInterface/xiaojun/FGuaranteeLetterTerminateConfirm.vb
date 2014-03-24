
'确认保证责任终止通知书　－－保函
Public Class FGuaranteeLetterTerminateConfirm
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
    Protected WithEvents lblProjectCode As System.Windows.Forms.Label
    Protected WithEvents lblCorporationName As System.Windows.Forms.Label
    Protected WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Public WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents pgRefundAttest As System.Windows.Forms.TabPage
    Friend WithEvents grpRefundInfo As System.Windows.Forms.GroupBox
    Public WithEvents dtpRefundDate As System.Windows.Forms.DateTimePicker
    Public WithEvents cboRefundSubBank As System.Windows.Forms.ComboBox
    Public WithEvents cboRefundBank As System.Windows.Forms.ComboBox
    Friend WithEvents lblRefundSubBank As System.Windows.Forms.Label
    Friend WithEvents lblRefundBank As System.Windows.Forms.Label
    Friend WithEvents grpBaseInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtGuaranteeSum As System.Windows.Forms.TextBox
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents cboBank As System.Windows.Forms.ComboBox
    Friend WithEvents cboSubBank As System.Windows.Forms.ComboBox
    Friend WithEvents txtTerms As System.Windows.Forms.TextBox
    Friend WithEvents lblSubBank As System.Windows.Forms.Label
    Friend WithEvents lblTerms As System.Windows.Forms.Label
    Friend WithEvents lblGuaranteeSum As System.Windows.Forms.Label
    Public WithEvents pgProjectTerminate As System.Windows.Forms.TabPage
    Public WithEvents grpTerminateInfo As System.Windows.Forms.GroupBox
    Public WithEvents txtProjectEvaluate As System.Windows.Forms.TextBox
    Public WithEvents txtTerminateReason As System.Windows.Forms.TextBox
    Friend WithEvents lblProjectEvaluate As System.Windows.Forms.Label
    Public WithEvents chkHighRisk As System.Windows.Forms.CheckBox
    Public WithEvents chkContinueSupport As System.Windows.Forms.CheckBox
    Friend WithEvents lblTerminateReason As System.Windows.Forms.Label
    Public WithEvents dtpProjectEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblProjectEndDate As System.Windows.Forms.Label
    Public WithEvents cboTerminateType As System.Windows.Forms.ComboBox
    Friend WithEvents lblTerminateType As System.Windows.Forms.Label
    Public WithEvents grpCheckInfo As System.Windows.Forms.GroupBox
    Public WithEvents lblCheckPerson As System.Windows.Forms.Label
    Public WithEvents lblCheckDate As System.Windows.Forms.Label
    Public WithEvents txtCheckPerson As System.Windows.Forms.TextBox
    Public WithEvents lblCheckOpinion As System.Windows.Forms.Label
    Public WithEvents cboCheckOpinion As System.Windows.Forms.ComboBox
    Public WithEvents dtpCheckDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblRefundDate As System.Windows.Forms.Label
    Public WithEvents btnRefundReport As System.Windows.Forms.Button
    Public WithEvents btnTerminateReport As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FGuaranteeLetterTerminateConfirm))
        Me.lblProjectCode = New System.Windows.Forms.Label()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pgRefundAttest = New System.Windows.Forms.TabPage()
        Me.grpCheckInfo = New System.Windows.Forms.GroupBox()
        Me.lblCheckPerson = New System.Windows.Forms.Label()
        Me.lblCheckDate = New System.Windows.Forms.Label()
        Me.txtCheckPerson = New System.Windows.Forms.TextBox()
        Me.lblCheckOpinion = New System.Windows.Forms.Label()
        Me.cboCheckOpinion = New System.Windows.Forms.ComboBox()
        Me.dtpCheckDate = New System.Windows.Forms.DateTimePicker()
        Me.btnRefundReport = New System.Windows.Forms.Button()
        Me.grpRefundInfo = New System.Windows.Forms.GroupBox()
        Me.dtpRefundDate = New System.Windows.Forms.DateTimePicker()
        Me.cboRefundSubBank = New System.Windows.Forms.ComboBox()
        Me.cboRefundBank = New System.Windows.Forms.ComboBox()
        Me.lblRefundDate = New System.Windows.Forms.Label()
        Me.lblRefundSubBank = New System.Windows.Forms.Label()
        Me.lblRefundBank = New System.Windows.Forms.Label()
        Me.grpBaseInfo = New System.Windows.Forms.GroupBox()
        Me.txtGuaranteeSum = New System.Windows.Forms.TextBox()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.cboSubBank = New System.Windows.Forms.ComboBox()
        Me.txtTerms = New System.Windows.Forms.TextBox()
        Me.lblSubBank = New System.Windows.Forms.Label()
        Me.lblTerms = New System.Windows.Forms.Label()
        Me.lblGuaranteeSum = New System.Windows.Forms.Label()
        Me.pgProjectTerminate = New System.Windows.Forms.TabPage()
        Me.grpTerminateInfo = New System.Windows.Forms.GroupBox()
        Me.txtProjectEvaluate = New System.Windows.Forms.TextBox()
        Me.txtTerminateReason = New System.Windows.Forms.TextBox()
        Me.lblProjectEvaluate = New System.Windows.Forms.Label()
        Me.chkHighRisk = New System.Windows.Forms.CheckBox()
        Me.chkContinueSupport = New System.Windows.Forms.CheckBox()
        Me.lblTerminateReason = New System.Windows.Forms.Label()
        Me.dtpProjectEndDate = New System.Windows.Forms.DateTimePicker()
        Me.lblProjectEndDate = New System.Windows.Forms.Label()
        Me.cboTerminateType = New System.Windows.Forms.ComboBox()
        Me.lblTerminateType = New System.Windows.Forms.Label()
        Me.btnTerminateReport = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.pgRefundAttest.SuspendLayout()
        Me.grpCheckInfo.SuspendLayout()
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
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(317, 432)
        Me.btnExit.Visible = True
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Location = New System.Drawing.Point(16, 8)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectCode.TabIndex = 126
        Me.lblProjectCode.Text = "项目编码"
        Me.lblProjectCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Location = New System.Drawing.Point(168, 8)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(56, 16)
        Me.lblCorporationName.TabIndex = 125
        Me.lblCorporationName.Text = "企业名称"
        Me.lblCorporationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorporationName
        '
        Me.txtCorporationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorporationName.Location = New System.Drawing.Point(232, 6)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.ReadOnly = True
        Me.txtCorporationName.Size = New System.Drawing.Size(296, 21)
        Me.txtCorporationName.TabIndex = 127
        Me.txtCorporationName.TabStop = False
        Me.txtCorporationName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(79, 6)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(80, 21)
        Me.txtProjectCode.TabIndex = 128
        Me.txtProjectCode.TabStop = False
        Me.txtProjectCode.Text = ""
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(229, 432)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 124
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabControl1
        '
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.pgRefundAttest, Me.pgProjectTerminate})
        Me.TabControl1.Location = New System.Drawing.Point(8, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(520, 392)
        Me.TabControl1.TabIndex = 123
        '
        'pgRefundAttest
        '
        Me.pgRefundAttest.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpCheckInfo, Me.btnRefundReport, Me.grpRefundInfo, Me.grpBaseInfo})
        Me.pgRefundAttest.Location = New System.Drawing.Point(4, 21)
        Me.pgRefundAttest.Name = "pgRefundAttest"
        Me.pgRefundAttest.Size = New System.Drawing.Size(512, 367)
        Me.pgRefundAttest.TabIndex = 0
        Me.pgRefundAttest.Text = "管理还款证明"
        '
        'grpCheckInfo
        '
        Me.grpCheckInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblCheckPerson, Me.lblCheckDate, Me.txtCheckPerson, Me.lblCheckOpinion, Me.cboCheckOpinion, Me.dtpCheckDate})
        Me.grpCheckInfo.Location = New System.Drawing.Point(8, 184)
        Me.grpCheckInfo.Name = "grpCheckInfo"
        Me.grpCheckInfo.Size = New System.Drawing.Size(496, 80)
        Me.grpCheckInfo.TabIndex = 57
        Me.grpCheckInfo.TabStop = False
        Me.grpCheckInfo.Text = "确认还款证明书"
        '
        'lblCheckPerson
        '
        Me.lblCheckPerson.Location = New System.Drawing.Point(8, 48)
        Me.lblCheckPerson.Name = "lblCheckPerson"
        Me.lblCheckPerson.Size = New System.Drawing.Size(56, 16)
        Me.lblCheckPerson.TabIndex = 50
        Me.lblCheckPerson.Text = "确认人"
        '
        'lblCheckDate
        '
        Me.lblCheckDate.Location = New System.Drawing.Point(8, 24)
        Me.lblCheckDate.Name = "lblCheckDate"
        Me.lblCheckDate.Size = New System.Drawing.Size(56, 16)
        Me.lblCheckDate.TabIndex = 49
        Me.lblCheckDate.Text = "确认时间"
        '
        'txtCheckPerson
        '
        Me.txtCheckPerson.BackColor = System.Drawing.SystemColors.Window
        Me.txtCheckPerson.Location = New System.Drawing.Point(96, 46)
        Me.txtCheckPerson.Name = "txtCheckPerson"
        Me.txtCheckPerson.ReadOnly = True
        Me.txtCheckPerson.Size = New System.Drawing.Size(144, 21)
        Me.txtCheckPerson.TabIndex = 6
        Me.txtCheckPerson.Text = ""
        '
        'lblCheckOpinion
        '
        Me.lblCheckOpinion.Location = New System.Drawing.Point(256, 24)
        Me.lblCheckOpinion.Name = "lblCheckOpinion"
        Me.lblCheckOpinion.Size = New System.Drawing.Size(56, 16)
        Me.lblCheckOpinion.TabIndex = 56
        Me.lblCheckOpinion.Text = "确认意见"
        '
        'cboCheckOpinion
        '
        Me.cboCheckOpinion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCheckOpinion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.cboCheckOpinion.Location = New System.Drawing.Point(336, 22)
        Me.cboCheckOpinion.Name = "cboCheckOpinion"
        Me.cboCheckOpinion.Size = New System.Drawing.Size(144, 20)
        Me.cboCheckOpinion.TabIndex = 57
        '
        'dtpCheckDate
        '
        Me.dtpCheckDate.Enabled = False
        Me.dtpCheckDate.Location = New System.Drawing.Point(96, 22)
        Me.dtpCheckDate.Name = "dtpCheckDate"
        Me.dtpCheckDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpCheckDate.TabIndex = 5
        '
        'btnRefundReport
        '
        Me.btnRefundReport.Image = CType(resources.GetObject("btnRefundReport.Image"), System.Drawing.Bitmap)
        Me.btnRefundReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefundReport.ImageIndex = 18
        Me.btnRefundReport.ImageList = Me.ImageListBasic
        Me.btnRefundReport.Location = New System.Drawing.Point(320, 328)
        Me.btnRefundReport.Name = "btnRefundReport"
        Me.btnRefundReport.Size = New System.Drawing.Size(176, 23)
        Me.btnRefundReport.TabIndex = 55
        Me.btnRefundReport.Text = "查看保证责任终止通知书(&V)"
        Me.btnRefundReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpRefundInfo
        '
        Me.grpRefundInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpRefundDate, Me.cboRefundSubBank, Me.cboRefundBank, Me.lblRefundDate, Me.lblRefundSubBank, Me.lblRefundBank})
        Me.grpRefundInfo.Location = New System.Drawing.Point(8, 96)
        Me.grpRefundInfo.Name = "grpRefundInfo"
        Me.grpRefundInfo.Size = New System.Drawing.Size(496, 80)
        Me.grpRefundInfo.TabIndex = 50
        Me.grpRefundInfo.TabStop = False
        Me.grpRefundInfo.Text = "项目还款信息"
        '
        'dtpRefundDate
        '
        Me.dtpRefundDate.Enabled = False
        Me.dtpRefundDate.Location = New System.Drawing.Point(96, 46)
        Me.dtpRefundDate.Name = "dtpRefundDate"
        Me.dtpRefundDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpRefundDate.TabIndex = 3
        '
        'cboRefundSubBank
        '
        Me.cboRefundSubBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRefundSubBank.Enabled = False
        Me.cboRefundSubBank.Location = New System.Drawing.Point(336, 22)
        Me.cboRefundSubBank.Name = "cboRefundSubBank"
        Me.cboRefundSubBank.Size = New System.Drawing.Size(144, 20)
        Me.cboRefundSubBank.TabIndex = 2
        '
        'cboRefundBank
        '
        Me.cboRefundBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRefundBank.Enabled = False
        Me.cboRefundBank.Location = New System.Drawing.Point(96, 22)
        Me.cboRefundBank.Name = "cboRefundBank"
        Me.cboRefundBank.Size = New System.Drawing.Size(144, 20)
        Me.cboRefundBank.TabIndex = 1
        '
        'lblRefundDate
        '
        Me.lblRefundDate.Location = New System.Drawing.Point(8, 48)
        Me.lblRefundDate.Name = "lblRefundDate"
        Me.lblRefundDate.Size = New System.Drawing.Size(56, 16)
        Me.lblRefundDate.TabIndex = 48
        Me.lblRefundDate.Text = "解除日期"
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
        Me.grpBaseInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtGuaranteeSum, Me.lblBank, Me.cboBank, Me.cboSubBank, Me.txtTerms, Me.lblSubBank, Me.lblTerms, Me.lblGuaranteeSum})
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
        Me.txtGuaranteeSum.Text = ""
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
        Me.lblSubBank.Size = New System.Drawing.Size(56, 16)
        Me.lblSubBank.TabIndex = 53
        Me.lblSubBank.Text = "出函支行"
        '
        'lblTerms
        '
        Me.lblTerms.Location = New System.Drawing.Point(256, 24)
        Me.lblTerms.Name = "lblTerms"
        Me.lblTerms.Size = New System.Drawing.Size(80, 16)
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
        Me.pgProjectTerminate.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpTerminateInfo, Me.btnTerminateReport})
        Me.pgProjectTerminate.Location = New System.Drawing.Point(4, 21)
        Me.pgProjectTerminate.Name = "pgProjectTerminate"
        Me.pgProjectTerminate.Size = New System.Drawing.Size(512, 367)
        Me.pgProjectTerminate.TabIndex = 1
        Me.pgProjectTerminate.Text = "管理项目终止报告"
        Me.pgProjectTerminate.Visible = False
        '
        'grpTerminateInfo
        '
        Me.grpTerminateInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtProjectEvaluate, Me.txtTerminateReason, Me.lblProjectEvaluate, Me.chkHighRisk, Me.chkContinueSupport, Me.lblTerminateReason, Me.dtpProjectEndDate, Me.lblProjectEndDate, Me.cboTerminateType, Me.lblTerminateType})
        Me.grpTerminateInfo.Location = New System.Drawing.Point(8, 8)
        Me.grpTerminateInfo.Name = "grpTerminateInfo"
        Me.grpTerminateInfo.Size = New System.Drawing.Size(496, 304)
        Me.grpTerminateInfo.TabIndex = 2
        Me.grpTerminateInfo.TabStop = False
        '
        'txtProjectEvaluate
        '
        Me.txtProjectEvaluate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectEvaluate.Location = New System.Drawing.Point(88, 184)
        Me.txtProjectEvaluate.Multiline = True
        Me.txtProjectEvaluate.Name = "txtProjectEvaluate"
        Me.txtProjectEvaluate.ReadOnly = True
        Me.txtProjectEvaluate.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProjectEvaluate.Size = New System.Drawing.Size(392, 112)
        Me.txtProjectEvaluate.TabIndex = 24
        Me.txtProjectEvaluate.Text = ""
        '
        'txtTerminateReason
        '
        Me.txtTerminateReason.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerminateReason.Location = New System.Drawing.Point(88, 80)
        Me.txtTerminateReason.Multiline = True
        Me.txtTerminateReason.Name = "txtTerminateReason"
        Me.txtTerminateReason.ReadOnly = True
        Me.txtTerminateReason.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTerminateReason.Size = New System.Drawing.Size(392, 96)
        Me.txtTerminateReason.TabIndex = 23
        Me.txtTerminateReason.Text = ""
        '
        'lblProjectEvaluate
        '
        Me.lblProjectEvaluate.AutoSize = True
        Me.lblProjectEvaluate.Location = New System.Drawing.Point(8, 192)
        Me.lblProjectEvaluate.Name = "lblProjectEvaluate"
        Me.lblProjectEvaluate.Size = New System.Drawing.Size(54, 14)
        Me.lblProjectEvaluate.TabIndex = 22
        Me.lblProjectEvaluate.Text = "项目评价"
        '
        'chkHighRisk
        '
        Me.chkHighRisk.Enabled = False
        Me.chkHighRisk.Location = New System.Drawing.Point(88, 48)
        Me.chkHighRisk.Name = "chkHighRisk"
        Me.chkHighRisk.Size = New System.Drawing.Size(120, 24)
        Me.chkHighRisk.TabIndex = 13
        Me.chkHighRisk.Text = "是否高风险"
        '
        'chkContinueSupport
        '
        Me.chkContinueSupport.Enabled = False
        Me.chkContinueSupport.Location = New System.Drawing.Point(240, 48)
        Me.chkContinueSupport.Name = "chkContinueSupport"
        Me.chkContinueSupport.Size = New System.Drawing.Size(144, 24)
        Me.chkContinueSupport.TabIndex = 14
        Me.chkContinueSupport.Text = "是否继续支持该企业"
        '
        'lblTerminateReason
        '
        Me.lblTerminateReason.AutoSize = True
        Me.lblTerminateReason.Location = New System.Drawing.Point(8, 88)
        Me.lblTerminateReason.Name = "lblTerminateReason"
        Me.lblTerminateReason.Size = New System.Drawing.Size(79, 14)
        Me.lblTerminateReason.TabIndex = 19
        Me.lblTerminateReason.Text = "终止原因说明"
        '
        'dtpProjectEndDate
        '
        Me.dtpProjectEndDate.Enabled = False
        Me.dtpProjectEndDate.Location = New System.Drawing.Point(88, 21)
        Me.dtpProjectEndDate.Name = "dtpProjectEndDate"
        Me.dtpProjectEndDate.Size = New System.Drawing.Size(136, 21)
        Me.dtpProjectEndDate.TabIndex = 11
        '
        'lblProjectEndDate
        '
        Me.lblProjectEndDate.AutoSize = True
        Me.lblProjectEndDate.Location = New System.Drawing.Point(8, 24)
        Me.lblProjectEndDate.Name = "lblProjectEndDate"
        Me.lblProjectEndDate.Size = New System.Drawing.Size(79, 14)
        Me.lblProjectEndDate.TabIndex = 17
        Me.lblProjectEndDate.Text = "项目终止日期"
        '
        'cboTerminateType
        '
        Me.cboTerminateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTerminateType.Enabled = False
        Me.cboTerminateType.Location = New System.Drawing.Point(320, 21)
        Me.cboTerminateType.Name = "cboTerminateType"
        Me.cboTerminateType.Size = New System.Drawing.Size(160, 20)
        Me.cboTerminateType.TabIndex = 12
        '
        'lblTerminateType
        '
        Me.lblTerminateType.AutoSize = True
        Me.lblTerminateType.Location = New System.Drawing.Point(240, 24)
        Me.lblTerminateType.Name = "lblTerminateType"
        Me.lblTerminateType.Size = New System.Drawing.Size(79, 14)
        Me.lblTerminateType.TabIndex = 15
        Me.lblTerminateType.Text = "项目终止类型"
        '
        'btnTerminateReport
        '
        Me.btnTerminateReport.Image = CType(resources.GetObject("btnTerminateReport.Image"), System.Drawing.Bitmap)
        Me.btnTerminateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTerminateReport.ImageIndex = 18
        Me.btnTerminateReport.ImageList = Me.ImageListBasic
        Me.btnTerminateReport.Location = New System.Drawing.Point(352, 328)
        Me.btnTerminateReport.Name = "btnTerminateReport"
        Me.btnTerminateReport.Size = New System.Drawing.Size(144, 23)
        Me.btnTerminateReport.TabIndex = 17
        Me.btnTerminateReport.Text = "查看项目终止报告(&V)"
        Me.btnTerminateReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(141, 432)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 129
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FGuaranteeLetterTerminateConfirm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(538, 463)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblProjectCode, Me.lblCorporationName, Me.btnExit, Me.btnSave, Me.txtCorporationName, Me.txtProjectCode, Me.btnCommit, Me.TabControl1})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FGuaranteeLetterTerminateConfirm"
        Me.Text = "确认保证责任终止通知书"
        Me.TabControl1.ResumeLayout(False)
        Me.pgRefundAttest.ResumeLayout(False)
        Me.grpCheckInfo.ResumeLayout(False)
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

    Private Sub FGuaranteeLetterTerminateConfirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.InitComboBox()
            Me.GetProjectBaseInfo()
            Me.GetProjectRefundInfo()
            Me.GetProjectTerminateInfo()
            Me.GetRefundCheckInfo()
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
        Me.cboRefundBank.DataSource = dsRefundBank.Tables("bank")
        Me.cboRefundBank.DisplayMember = "bank_name"
        Me.cboRefundBank.ValueMember = "bank_code"
        Me.cboRefundSubBank.DataSource = dsRefundBank.Tables("bank_branch").DefaultView
        Me.cboRefundSubBank.DisplayMember = "branch_bank_name"
        Me.cboRefundSubBank.ValueMember = "branch_bank_code"
        AddHandler cboRefundBank.SelectedIndexChanged, AddressOf RefundBankChanged
        RefundBankChanged(Nothing, Nothing)
        Dim tempDS As DataSet
        '取得项目终止类型
        tempDS = gWs.GetTerminateType("%")
        If Not tempDS.Tables(0).Rows.Count = 0 Then
            Me.cboTerminateType.DataSource = tempDS.Tables(0).DefaultView
            Me.cboTerminateType.DisplayMember = "terminate_type"
            Me.cboTerminateType.ValueMember = "terminate_type"
        End If
        '取得确认还款的意见
        tempDS = gWs.GetTransCondition(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID())
        If Not tempDS.Tables(0).Rows.Count = 0 Then
            Me.cboCheckOpinion.DataSource = tempDS.Tables(0).DefaultView
            Me.cboCheckOpinion.DisplayMember = "transfer_condition"
            Me.cboCheckOpinion.ValueMember = "transfer_condition"
        End If
    End Sub

    '根据银行编码初始化支行的ComboBox
    Protected Sub BankChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code='" & Me.cboBank.SelectedValue & "'"
    End Sub
    Private Sub RefundBankChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.dsRefundBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code='" & Me.cboRefundBank.SelectedValue & "'"
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
            End With
        End If
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
    End Sub
    '
    Private Sub GetRefundCheckInfo()
        Dim TempDS As DataSet
        TempDS = gWs.GetRefundCertificateInfo("{project_code='" & Me.getProjectCode() & "'}")
        If Not TempDS.Tables(0).Rows.Count = 0 Then
            With TempDS.Tables(0).Rows(0)
                If Not .Item("affirm_date") Is System.DBNull.Value Then
                    Me.dtpCheckDate.Value = .Item("affirm_date")
                Else
                    Me.dtpCheckDate.Value = gWs.GetSysTime()
                End If
            End With
        End If
        Me.txtCheckPerson.Text = UserName               '默认为当前用户
        TempDS = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "' AND item_type='56' AND item_code='003'}")
        If Not TempDS.Tables(0).Rows.Count = 0 Then
            If Not TempDS.Tables(0).Rows(0).Item("conclusion") Is System.DBNull.Value Then
                Me.cboCheckOpinion.SelectedValue = TempDS.Tables(0).Rows(0).Item("conclusion")
            End If
        End If
        AddHandler dtpCheckDate.TextChanged, AddressOf DataHasChanged
        AddHandler cboCheckOpinion.SelectedIndexChanged, AddressOf Page0_HasChanged
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
        Dim tempDS As DataSet
        Dim strResult As String
        Me.Cursor = Cursors.WaitCursor
        Try
            tempDS = gWs.GetRefundCertificateInfo("{project_code='" & Me.getProjectCode() & "'}")
            If tempDS.Tables(0).Rows.Count = 0 Then
                'MessageBox.Show("现在没有生成相关的还款证明书，无法进行审核操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SWDialogBox.MessageBox.Show("$1005", "相关的还款证明书")
                Return False
            Else
                With tempDS.Tables(0).Rows(0)
                    .Item("affirm_person") = Me.txtCheckPerson.Text
                    .Item("affirm_date") = Me.dtpCheckDate.Value
                End With
            End If
            strResult = gWs.UpdateRefundCertificate(tempDS)
            If strResult <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "还款信息更新失败", strResult, "")
                Return False
            End If
            tempDS = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "'AND item_type='56' AND item_code='003'}")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    .Item("conclusion") = Me.cboCheckOpinion.Text
                End With
            Else
                Dim dr As DataRow = tempDS.Tables(0).NewRow()
                With dr
                    .Item("project_code") = Me.getProjectCode()
                    .Item("item_type") = "56"
                    .Item("item_code") = "003"
                    .Item("conclusion") = Me.cboCheckOpinion.Text
                End With
                tempDS.Tables(0).Rows.Add(dr)
            End If
            strResult = gWs.UpdateProjectOpinion(tempDS)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "更新还款证明审核意见失败", strResult, "")
                Return False
            Else
                Me.bIsChanged = False                     '更新成功
                Return True
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return False
        Finally
            Me.Cursor = Cursors.Default
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
            strResult = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), Me.cboCheckOpinion.Text, UserName)
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
    '还款证明书
    Private Sub btnRefundReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefundReport.Click
        Dim frm As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "45", "012", UserName)
        frm.AllowTransparency = False
        frm.Text = "查看保证责任终止通知书"
        frm.setIsButtonEnable(True)
        frm.ShowDialog()
    End Sub
    '项目终止证明书
    Private Sub btnTerminateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTerminateReport.Click
        Dim frm As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "45", "004", UserName)
        frm.AllowTransparency = False
        frm.setIsButtonEnable(True)
        frm.ShowDialog()
    End Sub
End Class
