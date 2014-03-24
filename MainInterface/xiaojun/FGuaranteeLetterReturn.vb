
'登记出函回执
Public Class FGuaranteeLetterReturn
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
    Protected WithEvents grpSign As System.Windows.Forms.GroupBox
    Protected WithEvents txtSignPerson As System.Windows.Forms.TextBox
    Protected WithEvents lblConclusion As System.Windows.Forms.Label
    Protected WithEvents lblSignPerson As System.Windows.Forms.Label
    Protected WithEvents lblSignDate As System.Windows.Forms.Label
    Protected WithEvents lblProjectCode As System.Windows.Forms.Label
    Protected WithEvents grpGuaranteeLetter As System.Windows.Forms.GroupBox
    Protected WithEvents txtServiceType As System.Windows.Forms.TextBox
    Protected WithEvents lblServiceType As System.Windows.Forms.Label
    Protected WithEvents cboSubBank As System.Windows.Forms.ComboBox
    Protected WithEvents cboBank As System.Windows.Forms.ComboBox
    Protected WithEvents lblBank As System.Windows.Forms.Label
    Protected WithEvents lblSubBank As System.Windows.Forms.Label
    Protected WithEvents txtEnsureMoney As System.Windows.Forms.TextBox
    Protected WithEvents txtSecurityRate As System.Windows.Forms.TextBox
    Protected WithEvents txtGuaranteeRate As System.Windows.Forms.TextBox
    Protected WithEvents txtGuaranteeFee As System.Windows.Forms.TextBox
    Protected WithEvents lblEnsureMoney As System.Windows.Forms.Label
    Protected WithEvents lblSecurityRate As System.Windows.Forms.Label
    Protected WithEvents lblGuaranteeSum As System.Windows.Forms.Label
    Protected WithEvents lblGuaranteeRate As System.Windows.Forms.Label
    Protected WithEvents txtTerms As System.Windows.Forms.TextBox
    Protected WithEvents txtGuaranteeSum As System.Windows.Forms.TextBox
    Protected WithEvents lbTerms As System.Windows.Forms.Label
    Protected WithEvents lblGuaranteeLine As System.Windows.Forms.Label
    Protected WithEvents txtWorkflow As System.Windows.Forms.TextBox
    Protected WithEvents lblBeneficiary As System.Windows.Forms.Label
    Protected WithEvents lblReimburseType As System.Windows.Forms.Label
    Protected WithEvents lblGuaranteeLetterType As System.Windows.Forms.Label
    Protected WithEvents cboGuaranteeLetterType As System.Windows.Forms.ComboBox
    Protected WithEvents cboReimburseType As System.Windows.Forms.ComboBox
    Protected WithEvents lblWorkflow As System.Windows.Forms.Label
    Protected WithEvents txtBeneficiary As System.Windows.Forms.TextBox
    Protected WithEvents btnConferenceTrial As System.Windows.Forms.Button
    Protected WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Protected WithEvents btnCommit As System.Windows.Forms.Button
    Protected WithEvents lblCorporationName As System.Windows.Forms.Label
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Protected WithEvents btnDocument As System.Windows.Forms.Button
    Protected WithEvents grpDatum As System.Windows.Forms.GroupBox
    Protected WithEvents dgDatum As System.Windows.Forms.DataGrid
    Public WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Public WithEvents txtRegisterPerson As System.Windows.Forms.TextBox
    Friend WithEvents lblRegisterPerson As System.Windows.Forms.Label
    Protected WithEvents dtpSignDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMonths As System.Windows.Forms.Label
    Protected WithEvents txtMonths As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtConclusion As System.Windows.Forms.TextBox
    Protected WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FGuaranteeLetterReturn))
        Me.grpSign = New System.Windows.Forms.GroupBox()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtConclusion = New System.Windows.Forms.TextBox()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.txtSignPerson = New System.Windows.Forms.TextBox()
        Me.dtpSignDate = New System.Windows.Forms.DateTimePicker()
        Me.lblConclusion = New System.Windows.Forms.Label()
        Me.lblSignPerson = New System.Windows.Forms.Label()
        Me.lblSignDate = New System.Windows.Forms.Label()
        Me.txtRegisterPerson = New System.Windows.Forms.TextBox()
        Me.lblMonths = New System.Windows.Forms.Label()
        Me.lblStartDate = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblRegisterPerson = New System.Windows.Forms.Label()
        Me.lblProjectCode = New System.Windows.Forms.Label()
        Me.grpGuaranteeLetter = New System.Windows.Forms.GroupBox()
        Me.txtServiceType = New System.Windows.Forms.TextBox()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.cboSubBank = New System.Windows.Forms.ComboBox()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.lblSubBank = New System.Windows.Forms.Label()
        Me.txtEnsureMoney = New System.Windows.Forms.TextBox()
        Me.txtSecurityRate = New System.Windows.Forms.TextBox()
        Me.txtGuaranteeRate = New System.Windows.Forms.TextBox()
        Me.txtGuaranteeFee = New System.Windows.Forms.TextBox()
        Me.lblEnsureMoney = New System.Windows.Forms.Label()
        Me.lblSecurityRate = New System.Windows.Forms.Label()
        Me.lblGuaranteeSum = New System.Windows.Forms.Label()
        Me.lblGuaranteeRate = New System.Windows.Forms.Label()
        Me.txtTerms = New System.Windows.Forms.TextBox()
        Me.txtGuaranteeSum = New System.Windows.Forms.TextBox()
        Me.lbTerms = New System.Windows.Forms.Label()
        Me.lblGuaranteeLine = New System.Windows.Forms.Label()
        Me.txtWorkflow = New System.Windows.Forms.TextBox()
        Me.lblBeneficiary = New System.Windows.Forms.Label()
        Me.lblReimburseType = New System.Windows.Forms.Label()
        Me.lblGuaranteeLetterType = New System.Windows.Forms.Label()
        Me.cboGuaranteeLetterType = New System.Windows.Forms.ComboBox()
        Me.cboReimburseType = New System.Windows.Forms.ComboBox()
        Me.lblWorkflow = New System.Windows.Forms.Label()
        Me.txtBeneficiary = New System.Windows.Forms.TextBox()
        Me.btnConferenceTrial = New System.Windows.Forms.Button()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.btnDocument = New System.Windows.Forms.Button()
        Me.grpDatum = New System.Windows.Forms.GroupBox()
        Me.dgDatum = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.grpSign.SuspendLayout()
        Me.grpGuaranteeLetter.SuspendLayout()
        Me.grpDatum.SuspendLayout()
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(387, 480)
        Me.btnExit.Visible = True
        '
        'grpSign
        '
        Me.grpSign.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpEndDate, Me.Label1, Me.txtConclusion, Me.txtMonths, Me.txtSignPerson, Me.dtpSignDate, Me.lblConclusion, Me.lblSignPerson, Me.lblSignDate, Me.txtRegisterPerson, Me.lblMonths, Me.lblStartDate, Me.dtpStartDate, Me.lblRegisterPerson})
        Me.grpSign.Location = New System.Drawing.Point(8, 360)
        Me.grpSign.Name = "grpSign"
        Me.grpSign.Size = New System.Drawing.Size(512, 112)
        Me.grpSign.TabIndex = 114
        Me.grpSign.TabStop = False
        Me.grpSign.Text = "登记出函回执"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(352, 61)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpEndDate.TabIndex = 120
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(256, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 118
        Me.Label1.Text = "保函到期日"
        '
        'txtConclusion
        '
        Me.txtConclusion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConclusion.Location = New System.Drawing.Point(88, 38)
        Me.txtConclusion.Name = "txtConclusion"
        Me.txtConclusion.ReadOnly = True
        Me.txtConclusion.Size = New System.Drawing.Size(152, 21)
        Me.txtConclusion.TabIndex = 117
        Me.txtConclusion.Text = ""
        '
        'txtMonths
        '
        Me.txtMonths.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMonths.Location = New System.Drawing.Point(88, 86)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.ReadOnly = True
        Me.txtMonths.Size = New System.Drawing.Size(152, 21)
        Me.txtMonths.TabIndex = 115
        Me.txtMonths.Text = "0"
        Me.txtMonths.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSignPerson
        '
        Me.txtSignPerson.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSignPerson.Location = New System.Drawing.Point(352, 14)
        Me.txtSignPerson.Name = "txtSignPerson"
        Me.txtSignPerson.ReadOnly = True
        Me.txtSignPerson.Size = New System.Drawing.Size(144, 21)
        Me.txtSignPerson.TabIndex = 11
        Me.txtSignPerson.Text = ""
        '
        'dtpSignDate
        '
        Me.dtpSignDate.Enabled = False
        Me.dtpSignDate.Location = New System.Drawing.Point(88, 14)
        Me.dtpSignDate.Name = "dtpSignDate"
        Me.dtpSignDate.Size = New System.Drawing.Size(152, 21)
        Me.dtpSignDate.TabIndex = 10
        Me.dtpSignDate.Value = New Date(2003, 10, 28, 0, 0, 0, 0)
        '
        'lblConclusion
        '
        Me.lblConclusion.Location = New System.Drawing.Point(8, 40)
        Me.lblConclusion.Name = "lblConclusion"
        Me.lblConclusion.Size = New System.Drawing.Size(56, 16)
        Me.lblConclusion.TabIndex = 9
        Me.lblConclusion.Text = "签发意见"
        '
        'lblSignPerson
        '
        Me.lblSignPerson.Location = New System.Drawing.Point(256, 16)
        Me.lblSignPerson.Name = "lblSignPerson"
        Me.lblSignPerson.Size = New System.Drawing.Size(56, 16)
        Me.lblSignPerson.TabIndex = 0
        Me.lblSignPerson.Text = "签发人"
        '
        'lblSignDate
        '
        Me.lblSignDate.Location = New System.Drawing.Point(8, 16)
        Me.lblSignDate.Name = "lblSignDate"
        Me.lblSignDate.Size = New System.Drawing.Size(56, 16)
        Me.lblSignDate.TabIndex = 5
        Me.lblSignDate.Text = "签发日期"
        '
        'txtRegisterPerson
        '
        Me.txtRegisterPerson.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRegisterPerson.Location = New System.Drawing.Point(352, 85)
        Me.txtRegisterPerson.Name = "txtRegisterPerson"
        Me.txtRegisterPerson.ReadOnly = True
        Me.txtRegisterPerson.Size = New System.Drawing.Size(144, 21)
        Me.txtRegisterPerson.TabIndex = 13
        Me.txtRegisterPerson.Text = ""
        '
        'lblMonths
        '
        Me.lblMonths.Location = New System.Drawing.Point(8, 89)
        Me.lblMonths.Name = "lblMonths"
        Me.lblMonths.Size = New System.Drawing.Size(96, 16)
        Me.lblMonths.TabIndex = 17
        Me.lblMonths.Text = "出函期限(月)"
        '
        'lblStartDate
        '
        Me.lblStartDate.Location = New System.Drawing.Point(8, 64)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(56, 16)
        Me.lblStartDate.TabIndex = 15
        Me.lblStartDate.Text = "出函日期"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(88, 62)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(152, 21)
        Me.dtpStartDate.TabIndex = 16
        '
        'lblRegisterPerson
        '
        Me.lblRegisterPerson.Location = New System.Drawing.Point(256, 88)
        Me.lblRegisterPerson.Name = "lblRegisterPerson"
        Me.lblRegisterPerson.Size = New System.Drawing.Size(72, 16)
        Me.lblRegisterPerson.TabIndex = 7
        Me.lblRegisterPerson.Text = "登记人"
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Location = New System.Drawing.Point(16, 8)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectCode.TabIndex = 110
        Me.lblProjectCode.Text = "项目编码"
        Me.lblProjectCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpGuaranteeLetter
        '
        Me.grpGuaranteeLetter.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtServiceType, Me.lblServiceType, Me.cboSubBank, Me.cboBank, Me.lblBank, Me.lblSubBank, Me.txtEnsureMoney, Me.txtSecurityRate, Me.txtGuaranteeRate, Me.txtGuaranteeFee, Me.lblEnsureMoney, Me.lblSecurityRate, Me.lblGuaranteeSum, Me.lblGuaranteeRate, Me.txtTerms, Me.txtGuaranteeSum, Me.lbTerms, Me.lblGuaranteeLine, Me.txtWorkflow, Me.lblBeneficiary, Me.lblReimburseType, Me.lblGuaranteeLetterType, Me.cboGuaranteeLetterType, Me.cboReimburseType, Me.lblWorkflow, Me.txtBeneficiary})
        Me.grpGuaranteeLetter.Location = New System.Drawing.Point(8, 160)
        Me.grpGuaranteeLetter.Name = "grpGuaranteeLetter"
        Me.grpGuaranteeLetter.Size = New System.Drawing.Size(512, 192)
        Me.grpGuaranteeLetter.TabIndex = 113
        Me.grpGuaranteeLetter.TabStop = False
        Me.grpGuaranteeLetter.Text = "项目基本信息"
        '
        'txtServiceType
        '
        Me.txtServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtServiceType.Location = New System.Drawing.Point(88, 22)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(152, 21)
        Me.txtServiceType.TabIndex = 116
        Me.txtServiceType.Text = ""
        '
        'lblServiceType
        '
        Me.lblServiceType.Location = New System.Drawing.Point(8, 24)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(56, 16)
        Me.lblServiceType.TabIndex = 115
        Me.lblServiceType.Text = "业务品种"
        '
        'cboSubBank
        '
        Me.cboSubBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubBank.Enabled = False
        Me.cboSubBank.Location = New System.Drawing.Point(352, 118)
        Me.cboSubBank.Name = "cboSubBank"
        Me.cboSubBank.Size = New System.Drawing.Size(144, 20)
        Me.cboSubBank.TabIndex = 111
        '
        'cboBank
        '
        Me.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBank.Enabled = False
        Me.cboBank.Location = New System.Drawing.Point(88, 118)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(152, 20)
        Me.cboBank.TabIndex = 110
        '
        'lblBank
        '
        Me.lblBank.Location = New System.Drawing.Point(8, 120)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(56, 16)
        Me.lblBank.TabIndex = 109
        Me.lblBank.Text = "出函银行"
        '
        'lblSubBank
        '
        Me.lblSubBank.Location = New System.Drawing.Point(256, 120)
        Me.lblSubBank.Name = "lblSubBank"
        Me.lblSubBank.Size = New System.Drawing.Size(56, 16)
        Me.lblSubBank.TabIndex = 108
        Me.lblSubBank.Text = "出函支行"
        '
        'txtEnsureMoney
        '
        Me.txtEnsureMoney.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEnsureMoney.Location = New System.Drawing.Point(352, 166)
        Me.txtEnsureMoney.Name = "txtEnsureMoney"
        Me.txtEnsureMoney.ReadOnly = True
        Me.txtEnsureMoney.Size = New System.Drawing.Size(144, 21)
        Me.txtEnsureMoney.TabIndex = 107
        Me.txtEnsureMoney.Text = ""
        Me.txtEnsureMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSecurityRate
        '
        Me.txtSecurityRate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSecurityRate.Location = New System.Drawing.Point(88, 166)
        Me.txtSecurityRate.Name = "txtSecurityRate"
        Me.txtSecurityRate.ReadOnly = True
        Me.txtSecurityRate.Size = New System.Drawing.Size(152, 21)
        Me.txtSecurityRate.TabIndex = 106
        Me.txtSecurityRate.Text = ""
        Me.txtSecurityRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGuaranteeRate
        '
        Me.txtGuaranteeRate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuaranteeRate.Location = New System.Drawing.Point(88, 142)
        Me.txtGuaranteeRate.Name = "txtGuaranteeRate"
        Me.txtGuaranteeRate.ReadOnly = True
        Me.txtGuaranteeRate.Size = New System.Drawing.Size(152, 21)
        Me.txtGuaranteeRate.TabIndex = 105
        Me.txtGuaranteeRate.Text = ""
        Me.txtGuaranteeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGuaranteeFee
        '
        Me.txtGuaranteeFee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuaranteeFee.Location = New System.Drawing.Point(352, 142)
        Me.txtGuaranteeFee.Name = "txtGuaranteeFee"
        Me.txtGuaranteeFee.ReadOnly = True
        Me.txtGuaranteeFee.Size = New System.Drawing.Size(144, 21)
        Me.txtGuaranteeFee.TabIndex = 104
        Me.txtGuaranteeFee.Text = ""
        Me.txtGuaranteeFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEnsureMoney
        '
        Me.lblEnsureMoney.Location = New System.Drawing.Point(256, 168)
        Me.lblEnsureMoney.Name = "lblEnsureMoney"
        Me.lblEnsureMoney.Size = New System.Drawing.Size(96, 16)
        Me.lblEnsureMoney.TabIndex = 103
        Me.lblEnsureMoney.Text = "保证金金额(元)"
        '
        'lblSecurityRate
        '
        Me.lblSecurityRate.Location = New System.Drawing.Point(8, 168)
        Me.lblSecurityRate.Name = "lblSecurityRate"
        Me.lblSecurityRate.Size = New System.Drawing.Size(88, 16)
        Me.lblSecurityRate.TabIndex = 102
        Me.lblSecurityRate.Text = "保证金比例"
        '
        'lblGuaranteeSum
        '
        Me.lblGuaranteeSum.Location = New System.Drawing.Point(256, 144)
        Me.lblGuaranteeSum.Name = "lblGuaranteeSum"
        Me.lblGuaranteeSum.Size = New System.Drawing.Size(104, 16)
        Me.lblGuaranteeSum.TabIndex = 101
        Me.lblGuaranteeSum.Text = "担保费金额(元)"
        '
        'lblGuaranteeRate
        '
        Me.lblGuaranteeRate.Location = New System.Drawing.Point(8, 144)
        Me.lblGuaranteeRate.Name = "lblGuaranteeRate"
        Me.lblGuaranteeRate.Size = New System.Drawing.Size(88, 16)
        Me.lblGuaranteeRate.TabIndex = 100
        Me.lblGuaranteeRate.Text = "担保费比例"
        '
        'txtTerms
        '
        Me.txtTerms.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerms.Location = New System.Drawing.Point(88, 94)
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.ReadOnly = True
        Me.txtTerms.Size = New System.Drawing.Size(152, 21)
        Me.txtTerms.TabIndex = 97
        Me.txtTerms.Text = ""
        Me.txtTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGuaranteeSum
        '
        Me.txtGuaranteeSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuaranteeSum.Location = New System.Drawing.Point(352, 94)
        Me.txtGuaranteeSum.Name = "txtGuaranteeSum"
        Me.txtGuaranteeSum.ReadOnly = True
        Me.txtGuaranteeSum.Size = New System.Drawing.Size(144, 21)
        Me.txtGuaranteeSum.TabIndex = 96
        Me.txtGuaranteeSum.Text = ""
        Me.txtGuaranteeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbTerms
        '
        Me.lbTerms.Location = New System.Drawing.Point(8, 96)
        Me.lbTerms.Name = "lbTerms"
        Me.lbTerms.Size = New System.Drawing.Size(80, 16)
        Me.lbTerms.TabIndex = 95
        Me.lbTerms.Text = "保函期限(月)"
        '
        'lblGuaranteeLine
        '
        Me.lblGuaranteeLine.Location = New System.Drawing.Point(256, 96)
        Me.lblGuaranteeLine.Name = "lblGuaranteeLine"
        Me.lblGuaranteeLine.Size = New System.Drawing.Size(96, 16)
        Me.lblGuaranteeLine.TabIndex = 94
        Me.lblGuaranteeLine.Text = "保函额度(万元)"
        '
        'txtWorkflow
        '
        Me.txtWorkflow.BackColor = System.Drawing.Color.Gainsboro
        Me.txtWorkflow.Location = New System.Drawing.Point(352, 22)
        Me.txtWorkflow.Name = "txtWorkflow"
        Me.txtWorkflow.ReadOnly = True
        Me.txtWorkflow.Size = New System.Drawing.Size(144, 21)
        Me.txtWorkflow.TabIndex = 86
        Me.txtWorkflow.TabStop = False
        Me.txtWorkflow.Text = ""
        '
        'lblBeneficiary
        '
        Me.lblBeneficiary.Location = New System.Drawing.Point(8, 72)
        Me.lblBeneficiary.Name = "lblBeneficiary"
        Me.lblBeneficiary.Size = New System.Drawing.Size(64, 16)
        Me.lblBeneficiary.TabIndex = 93
        Me.lblBeneficiary.Text = "受益人名称"
        '
        'lblReimburseType
        '
        Me.lblReimburseType.Location = New System.Drawing.Point(256, 48)
        Me.lblReimburseType.Name = "lblReimburseType"
        Me.lblReimburseType.Size = New System.Drawing.Size(80, 16)
        Me.lblReimburseType.TabIndex = 91
        Me.lblReimburseType.Text = "偿付责任类型"
        '
        'lblGuaranteeLetterType
        '
        Me.lblGuaranteeLetterType.Location = New System.Drawing.Point(8, 48)
        Me.lblGuaranteeLetterType.Name = "lblGuaranteeLetterType"
        Me.lblGuaranteeLetterType.Size = New System.Drawing.Size(56, 16)
        Me.lblGuaranteeLetterType.TabIndex = 90
        Me.lblGuaranteeLetterType.Text = "保函种类"
        '
        'cboGuaranteeLetterType
        '
        Me.cboGuaranteeLetterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGuaranteeLetterType.Enabled = False
        Me.cboGuaranteeLetterType.ItemHeight = 12
        Me.cboGuaranteeLetterType.Location = New System.Drawing.Point(88, 46)
        Me.cboGuaranteeLetterType.Name = "cboGuaranteeLetterType"
        Me.cboGuaranteeLetterType.Size = New System.Drawing.Size(152, 20)
        Me.cboGuaranteeLetterType.TabIndex = 87
        Me.cboGuaranteeLetterType.TabStop = False
        '
        'cboReimburseType
        '
        Me.cboReimburseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReimburseType.Enabled = False
        Me.cboReimburseType.ItemHeight = 12
        Me.cboReimburseType.Location = New System.Drawing.Point(352, 46)
        Me.cboReimburseType.Name = "cboReimburseType"
        Me.cboReimburseType.Size = New System.Drawing.Size(144, 20)
        Me.cboReimburseType.TabIndex = 88
        Me.cboReimburseType.TabStop = False
        '
        'lblWorkflow
        '
        Me.lblWorkflow.Location = New System.Drawing.Point(256, 24)
        Me.lblWorkflow.Name = "lblWorkflow"
        Me.lblWorkflow.Size = New System.Drawing.Size(56, 16)
        Me.lblWorkflow.TabIndex = 92
        Me.lblWorkflow.Text = "运作方式"
        '
        'txtBeneficiary
        '
        Me.txtBeneficiary.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBeneficiary.Location = New System.Drawing.Point(88, 70)
        Me.txtBeneficiary.Name = "txtBeneficiary"
        Me.txtBeneficiary.ReadOnly = True
        Me.txtBeneficiary.Size = New System.Drawing.Size(152, 21)
        Me.txtBeneficiary.TabIndex = 89
        Me.txtBeneficiary.TabStop = False
        Me.txtBeneficiary.Text = ""
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConferenceTrial.Image = CType(resources.GetObject("btnConferenceTrial.Image"), System.Drawing.Bitmap)
        Me.btnConferenceTrial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConferenceTrial.ImageIndex = 26
        Me.btnConferenceTrial.ImageList = Me.ImageListBasic
        Me.btnConferenceTrial.Location = New System.Drawing.Point(187, 480)
        Me.btnConferenceTrial.Name = "btnConferenceTrial"
        Me.btnConferenceTrial.Size = New System.Drawing.Size(112, 23)
        Me.btnConferenceTrial.TabIndex = 108
        Me.btnConferenceTrial.Text = "评审会结论(&R)"
        Me.btnConferenceTrial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCorporationName
        '
        Me.txtCorporationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorporationName.Location = New System.Drawing.Point(224, 6)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.ReadOnly = True
        Me.txtCorporationName.Size = New System.Drawing.Size(296, 21)
        Me.txtCorporationName.TabIndex = 111
        Me.txtCorporationName.TabStop = False
        Me.txtCorporationName.Text = ""
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(303, 480)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 106
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Location = New System.Drawing.Point(160, 8)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(56, 16)
        Me.lblCorporationName.TabIndex = 109
        Me.lblCorporationName.Text = "企业名称"
        Me.lblCorporationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(72, 6)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(80, 21)
        Me.txtProjectCode.TabIndex = 112
        Me.txtProjectCode.TabStop = False
        Me.txtProjectCode.Text = ""
        '
        'btnDocument
        '
        Me.btnDocument.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDocument.Image = CType(resources.GetObject("btnDocument.Image"), System.Drawing.Bitmap)
        Me.btnDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocument.ImageIndex = 27
        Me.btnDocument.ImageList = Me.ImageListBasic
        Me.btnDocument.Location = New System.Drawing.Point(63, 480)
        Me.btnDocument.Name = "btnDocument"
        Me.btnDocument.Size = New System.Drawing.Size(120, 23)
        Me.btnDocument.TabIndex = 107
        Me.btnDocument.Text = "查看出函申请(&M)"
        Me.btnDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpDatum
        '
        Me.grpDatum.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgDatum})
        Me.grpDatum.Location = New System.Drawing.Point(8, 32)
        Me.grpDatum.Name = "grpDatum"
        Me.grpDatum.Size = New System.Drawing.Size(512, 120)
        Me.grpDatum.TabIndex = 105
        Me.grpDatum.TabStop = False
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
        Me.dgDatum.RowHeadersVisible = False
        Me.dgDatum.Size = New System.Drawing.Size(506, 100)
        Me.dgDatum.TabIndex = 8
        Me.dgDatum.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgDatum
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TProjectDocument"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "已确认的材料名称"
        Me.DataGridTextBoxColumn1.MappingName = "doc_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 300
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "检查人"
        Me.DataGridTextBoxColumn2.MappingName = "check_person"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = "yy-MM-dd"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "检查日期"
        Me.DataGridTextBoxColumn3.MappingName = "check_date"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'FGuaranteeLetterReturn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(530, 511)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblProjectCode, Me.lblCorporationName, Me.btnExit, Me.grpSign, Me.grpGuaranteeLetter, Me.btnConferenceTrial, Me.txtCorporationName, Me.btnCommit, Me.txtProjectCode, Me.btnDocument, Me.grpDatum})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FGuaranteeLetterReturn"
        Me.Text = "登记出函回执"
        Me.grpSign.ResumeLayout(False)
        Me.grpGuaranteeLetter.ResumeLayout(False)
        Me.grpDatum.ResumeLayout(False)
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsBank As DataSet
    Protected bFormLoad As Boolean = False
    Protected bIsChanged As Boolean = False

    Private Sub FGuaranteeLetterReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.GetProjectData()
            Me.GetConclusionData()
            Me.GetLoanNoticeData()
            Me.bFormLoad = True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Protected Sub GetProjectData()
        Me.txtProjectCode.Text = Me.getProjectCode()          '项目编码 
        Me.txtCorporationName.Text = Me.getCorporationName()  '企业名称
        '初始化银行的ComboBox
        dsBank = gWs.GetBankInfo("%", "%")
        Me.cboBank.DataSource = dsBank.Tables("bank")
        Me.cboBank.DisplayMember = "bank_name"
        Me.cboBank.ValueMember = "bank_code"
        Me.cboSubBank.DataSource = dsBank.Tables("bank_branch").DefaultView
        Me.cboSubBank.DisplayMember = "branch_bank_name"
        Me.cboSubBank.ValueMember = "branch_bank_code"
        Me.BankChanged()

        Dim tempDS As DataSet
        tempDS = gWs.GetReimburseType("%")                '偿付责任类型
        Me.cboReimburseType.DataSource = tempDS.Tables(0)
        Me.cboReimburseType.DisplayMember = "name"
        Me.cboReimburseType.ValueMember = "type_code"
        tempDS = gWs.GetGuaranteeLetterType("%")          '保函类型
        Me.cboGuaranteeLetterType.DataSource = tempDS.Tables(0)
        Me.cboGuaranteeLetterType.DisplayMember = "name"
        Me.cboGuaranteeLetterType.ValueMember = "type_code"

        Try
            tempDS = gWs.GetProjectDocumentByCondition("{project_code='" & Me.getProjectCode() & "' AND item_type='44' AND check_person IS NOT NULL}")
            Me.dgDatum.DataSource = tempDS.Tables(0)   '填充材料datagrid
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Dim HasConference As Boolean = False
        Try
            tempDS = gWs.GetConfTrialInfo("{project_code = '" & Me.getProjectCode() & "' ORDER BY trial_times DESC }", "null")
            If Not tempDS.Tables("conference_trial").Rows.Count = 0 Then
                With tempDS.Tables("conference_trial").Rows(0)
                    Me.txtServiceType.Text = IIf(.Item("service_type") Is DBNull.Value, "", .Item("service_type"))  '业务品种
                    Me.txtWorkflow.Text = IIf(.Item("workflow") Is DBNull.Value, "", .Item("workflow"))  '运作方式

                    Me.txtTerms.Text = IIf(.Item("terms") Is DBNull.Value, "0", .Item("terms"))   '保函期限
                    If Not .Item("guarantee_letter_type") Is DBNull.Value Then
                        Me.cboGuaranteeLetterType.SelectedValue = .Item("guarantee_letter_type") '保函种类
                    End If
                    If Not .Item("reimburse_type") Is DBNull.Value Then
                        Me.cboReimburseType.SelectedValue = .Item("reimburse_type")           '偿付责任类型
                    End If
                    'If Not .Item("bank") Is DBNull.Value Then
                    '    Me.cboBank.SelectedValue = .Item("bank")                      '出函银行
                    '    Me.BankChanged()
                    'End If
                    'If Not .Item("bank_branch") Is DBNull.Value Then
                    '    Me.cboSubBank.SelectedValue = .Item("bank_branch")          '出函支行 
                    'End If
                    Dim GuaranteeSum As Double
                    Dim GuaranteeRate As Double
                    GuaranteeSum = CDbl(.Item("guarantee_sum") + "0")          '保函额度
                    Me.txtGuaranteeSum.Text = GuaranteeSum.ToString
                    GuaranteeRate = CDbl(.Item("guarantee_rate") + "0") / 100  '担保费比率
                    Me.txtGuaranteeRate.Text = CDbl(.Item("guarantee_rate") + "0").ToString + "%"

                    '   Me.txtGuaranteeFee.Text = (GuaranteeSum * GuaranteeRate * 1000).ToString("c", CGFormatInfo)     '担保费 
                    Me.txtSecurityRate.Text = CDbl(.Item("security_rate") + "0").ToString() + "%"     '保证金比率
                End With
                HasConference = True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Try
            tempDS = gWs.GetProjectInfo("{project_code='" + Me.getProjectCode + "'}")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    Me.txtBeneficiary.Text = IIf(.Item("beneficiary") Is DBNull.Value, "", .Item("beneficiary")) '受益人
                    If Not HasConference Then  '存在评审会
                        Me.txtServiceType.Text = IIf(.Item("apply_service_type") Is DBNull.Value, "", .Item("apply_service_type"))  '业务品种
                        Me.txtWorkflow.Text = IIf(.Item("workflow") Is DBNull.Value, "", .Item("workflow"))  '运作方式

                        Me.txtTerms.Text = IIf(.Item("apply_term") Is DBNull.Value, "0", .Item("apply_term"))   '保函期限
                        If Not .Item("guarantee_letter_type") Is DBNull.Value Then
                            Me.cboGuaranteeLetterType.SelectedValue = .Item("guarantee_letter_type") '保函种类
                        End If
                        If Not .Item("reimburse_type") Is DBNull.Value Then
                            Me.cboReimburseType.SelectedValue = .Item("reimburse_type")           '偿付责任类型
                        End If
                        'If Not .Item("apply_bank") Is DBNull.Value Then
                        '    Me.cboBank.SelectedValue = .Item("apply_bank")                      '出函银行
                        '    Me.BankChanged(Nothing, Nothing)
                        'End If
                        'If Not .Item("apply_branch_bank") Is DBNull.Value Then
                        '    Me.cboSubBank.SelectedValue = .Item("apply_branch_bank")          '出函支行 
                        'End If
                        Me.txtGuaranteeSum.Text = CDbl(.Item("apply_sum") + "0").ToString()          '保函额度
                        Me.txtGuaranteeRate.Text = CDbl(.Item("guarantee_rate") + "0").ToString + "%" '担保费比率
                        Me.txtSecurityRate.Text = CDbl(.Item("security_rate") + "0").ToString() + "%"     '保证金比率
                    End If
                End With
            End If
            tempDS = gWs.GetProjectAccountDetailInfo("{project_code = '" & Me.getProjectCode() & "' AND item_type='31' AND item_code='002' AND phase='评审'}")
            Me.txtGuaranteeFee.Text = Numeric2Currency("0")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                If Not tempDS.Tables(0).Rows(0).Item("payout") Is DBNull.Value Then
                    Me.txtGuaranteeFee.Text = Numeric2Currency(tempDS.Tables(0).Rows(0).Item("payout"))            '担保费
                End If
            End If
            tempDS = gWs.GetProjectAccountDetailInfo("{project_code = '" & Me.getProjectCode() & "' AND item_type='34' AND item_code='009' AND phase='评审'}")
            Me.txtEnsureMoney.Text = Numeric2Currency("0")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                If Not tempDS.Tables(0).Rows(0).Item("payout") Is DBNull.Value Then
                    Me.txtEnsureMoney.Text = Numeric2Currency(tempDS.Tables(0).Rows(0).Item("payout"))            '保证金
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        '已存在放款记录的情况
        tempDS = gWs.GetLoanNoticeInfo("{project_code = '" & Me.getProjectCode() & "'}")
        If Not tempDS.Tables(0).Rows.Count = 0 Then
            With tempDS.Tables(0).Rows(0)
                Me.cboBank.SelectedValue = .Item("bank")
                Me.BankChanged()
                Me.cboSubBank.SelectedValue = .Item("branch_bank")
            End With
        Else
            SWDialogBox.MessageBox.Show("$1007", "放款信息")  '放款信息不存在
        End If

    End Sub

    Private Sub BankChanged()
        dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code = '" & Me.cboBank.SelectedValue & "'"
    End Sub
    '获取部长签发意见 
    Private Sub GetConclusionData()
        Dim tempDS As DataSet
        Try
            tempDS = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "' AND item_type='54' AND item_code='001'}")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    Me.dtpSignDate.Value = .Item("create_date")
                    Me.txtConclusion.Text = .Item("conclusion")
                    Me.txtSignPerson.Text = .Item("create_person")
                End With
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub GetLoanNoticeData()
        Dim tempDS As DataSet
        Try
            tempDS = gWs.GetLoanNoticeInfo("{project_code='" & Me.getProjectCode() & "'}")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    If Not .Item("register_date") Is DBNull.Value And Not .Item("end_date") Is DBNull.Value Then
                        Me.dtpStartDate.Value = .Item("start_date")
                        Dim StartDate, EndDate As DateTime
                        StartDate = .Item("register_date")
                        EndDate = .Item("end_date")
                        Me.txtMonths.Text = (EndDate.Year * 12 + EndDate.Month - StartDate.Year * 12 - StartDate.Month).ToString()
                    End If
                End With
            Else
                SWDialogBox.MessageBox.Show("$1007", "放款信息")
            End If
            Me.txtRegisterPerson.Text = UserName
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Protected Overridable Function SaveData() As Boolean
        Dim tempDS As DataSet
        '修改放款信息loan_not ice表中的记录
        Try
            tempDS = gWs.GetLoanNoticeInfo("{project_code='" & Me.getProjectCode() & "' order by create_date desc}")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    .Item("register_person") = UserName
                    .Item("register_date") = Me.dtpStartDate.Value
                    Dim month As Integer
                    Try
                        month = CInt(Me.txtMonths.Text)
                    Catch
                        month = 0
                    End Try
                    .Item("start_date") = Me.dtpStartDate.Value
                    .Item("end_date") = Me.dtpEndDate.Value
                End With
            Else
                SWDialogBox.MessageBox.Show("$1007", "放款信息")
                Return False
            End If
            Dim strResult As String = gWs.UpdateLoanNotice(tempDS)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "放款信息更新失败", strResult, "")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '查看出函通知书
    Private Sub btnDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocument.Click
        Dim doc As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "45", "110", UserName)
        doc.setIsButtonEnable(True)
        doc.AllowTransparency = False
        doc.Text = "查看出函通知书"
        doc.ShowDialog()
    End Sub
    '查看评审会结论    
    Private Sub btnConferenceTrial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConferenceTrial.Click
        If gWs.GetConfTrialInfo("{project_code = '" + Me.getProjectCode() + "'}", "NULL").Tables("conference_trial").Rows.Count > 0 Then
            frmChangeGuarantyFee.OpenWord(Me.getProjectCode(), Me, Me.getCorporationName() & "评审会意见表", True, Me.getCorporationName())
        Else
            Dim ProjectCode As String = MyBase.getProjectCode
            Dim apply_date As DateTime = Money.GetApplyDate(ProjectCode)
            Dim dsLetter As DataSet = gWs.GetGuaranteeLetter(ProjectCode.Substring(0, 5), apply_date)
            Dim fileProjectCode As String
            If dsLetter.Tables(0).Rows.Count > 0 Then
                fileProjectCode = dsLetter.Tables(0).Rows(0)("project_code") & String.Empty
                frmChangeGuarantyFee.OpenWord(fileProjectCode, Me, Me.getCorporationName() & "评审会意见表", False, String.Empty)
            End If
        End If
    End Sub
    '提交按钮
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        'MsgBox("请确认提交！", MsgBoxStyle.OKCancel Or MsgBoxStyle.Question, "项目评审") 
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
                SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "")
            Else
                MyBase.raiseCommitSucceed()
                SWDialogBox.MessageBox.Show("$SubmitSucceed")
                Close()
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '提出按钮
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
       me.Close()
    End Sub

    Protected Sub DataHasChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Me.bFormLoad Then
            bIsChanged = True
        End If
    End Sub

    Private Sub txtMonths_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMonths.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or e.KeyChar = Convert.ToChar(8))
    End Sub

    'Private Sub txtMonths_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMonths.TextChanged
    '    Try
    '        Dim i As Integer = CInt(Me.txtMonths.Text)

    '    Catch
    '        Me.txtMonths.Text = "0"
    '    End Try
    'End Sub

    Private Sub dtpEndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpEndDate.ValueChanged
        txtMonths.Text = DateDiff(DateInterval.Month, dtpStartDate.Value, dtpEndDate.Value).ToString()
    End Sub
End Class
