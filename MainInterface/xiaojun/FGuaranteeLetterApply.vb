
'呈请出函  /保函业务hute 2003-12-05
Public Class FGuaranteeLetterApply
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
    Protected WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Protected WithEvents lblCorporationName As System.Windows.Forms.Label
    Protected WithEvents lblProjectCode As System.Windows.Forms.Label
    Protected WithEvents dgDatum As System.Windows.Forms.DataGrid
    Protected WithEvents btnConferenceTrial As System.Windows.Forms.Button
    Protected WithEvents btnCommit As System.Windows.Forms.Button
    Protected WithEvents lblWorkflow As System.Windows.Forms.Label
    Protected WithEvents txtWorkflow As System.Windows.Forms.TextBox
    Protected WithEvents lblGuaranteeLetterType As System.Windows.Forms.Label
    Protected WithEvents lblBeneficiary As System.Windows.Forms.Label
    Protected WithEvents cboGuaranteeLetterType As System.Windows.Forms.ComboBox
    Protected WithEvents txtBeneficiary As System.Windows.Forms.TextBox
    Protected WithEvents cboReimburseType As System.Windows.Forms.ComboBox
    Protected WithEvents lblReimburseType As System.Windows.Forms.Label
    Protected WithEvents grpGuaranteeLetter As System.Windows.Forms.GroupBox
    Protected WithEvents lblGuaranteeLine As System.Windows.Forms.Label
    Protected WithEvents lblGuaranteeRate As System.Windows.Forms.Label
    Protected WithEvents lblGuaranteeSum As System.Windows.Forms.Label
    Protected WithEvents lblSecurityRate As System.Windows.Forms.Label
    Protected WithEvents lblEnsureMoney As System.Windows.Forms.Label
    Protected WithEvents txtGuaranteeRate As System.Windows.Forms.TextBox
    Protected WithEvents txtSecurityRate As System.Windows.Forms.TextBox
    Protected WithEvents txtEnsureMoney As System.Windows.Forms.TextBox
    Protected WithEvents btnDocument As System.Windows.Forms.Button
    Protected WithEvents txtTerms As System.Windows.Forms.TextBox
    Protected WithEvents lbTerms As System.Windows.Forms.Label
    Protected WithEvents txtGuaranteeFee As System.Windows.Forms.TextBox
    Protected WithEvents txtGuaranteeSum As System.Windows.Forms.TextBox
    Protected WithEvents cboSubBank As System.Windows.Forms.ComboBox
    Protected WithEvents cboBank As System.Windows.Forms.ComboBox
    Protected WithEvents lblBank As System.Windows.Forms.Label
    Protected WithEvents lblSubBank As System.Windows.Forms.Label
    Protected WithEvents lblServiceType As System.Windows.Forms.Label
    Protected WithEvents txtServiceType As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnViewEntente As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FGuaranteeLetterApply))
        Me.dgDatum = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnConferenceTrial = New System.Windows.Forms.Button()
        Me.btnDocument = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.lblProjectCode = New System.Windows.Forms.Label()
        Me.lblWorkflow = New System.Windows.Forms.Label()
        Me.txtWorkflow = New System.Windows.Forms.TextBox()
        Me.lblGuaranteeLetterType = New System.Windows.Forms.Label()
        Me.lblBeneficiary = New System.Windows.Forms.Label()
        Me.cboGuaranteeLetterType = New System.Windows.Forms.ComboBox()
        Me.txtBeneficiary = New System.Windows.Forms.TextBox()
        Me.cboReimburseType = New System.Windows.Forms.ComboBox()
        Me.lblReimburseType = New System.Windows.Forms.Label()
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
        Me.btnViewEntente = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpGuaranteeLetter.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.btnExit.Location = New System.Drawing.Point(449, 392)
        Me.btnExit.Visible = True
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
        Me.dgDatum.Size = New System.Drawing.Size(522, 132)
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
        Me.DataGridTextBoxColumn1.Width = 325
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
        Me.DataGridTextBoxColumn3.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "检查日期"
        Me.DataGridTextBoxColumn3.MappingName = "check_date"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConferenceTrial.Image = CType(resources.GetObject("btnConferenceTrial.Image"), System.Drawing.Bitmap)
        Me.btnConferenceTrial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConferenceTrial.ImageIndex = 27
        Me.btnConferenceTrial.ImageList = Me.ImageListBasic
        Me.btnConferenceTrial.Location = New System.Drawing.Point(248, 392)
        Me.btnConferenceTrial.Name = "btnConferenceTrial"
        Me.btnConferenceTrial.Size = New System.Drawing.Size(112, 23)
        Me.btnConferenceTrial.TabIndex = 11
        Me.btnConferenceTrial.Text = "评审会结论(&R)"
        Me.btnConferenceTrial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDocument
        '
        Me.btnDocument.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDocument.Image = CType(resources.GetObject("btnDocument.Image"), System.Drawing.Bitmap)
        Me.btnDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocument.ImageIndex = 19
        Me.btnDocument.ImageList = Me.ImageListBasic
        Me.btnDocument.Location = New System.Drawing.Point(122, 392)
        Me.btnDocument.Name = "btnDocument"
        Me.btnDocument.Size = New System.Drawing.Size(120, 23)
        Me.btnDocument.TabIndex = 10
        Me.btnDocument.Text = "制作出函申请(&M)"
        Me.btnDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(366, 392)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 9
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCorporationName
        '
        Me.txtCorporationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorporationName.Location = New System.Drawing.Point(232, 6)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.ReadOnly = True
        Me.txtCorporationName.Size = New System.Drawing.Size(304, 21)
        Me.txtCorporationName.TabIndex = 14
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
        Me.txtProjectCode.TabIndex = 15
        Me.txtProjectCode.TabStop = False
        Me.txtProjectCode.Text = ""
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Location = New System.Drawing.Point(168, 8)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(56, 16)
        Me.lblCorporationName.TabIndex = 12
        Me.lblCorporationName.Text = "企业名称"
        Me.lblCorporationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Location = New System.Drawing.Point(16, 8)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectCode.TabIndex = 13
        Me.lblProjectCode.Text = "项目编码"
        Me.lblProjectCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWorkflow
        '
        Me.lblWorkflow.Location = New System.Drawing.Point(272, 24)
        Me.lblWorkflow.Name = "lblWorkflow"
        Me.lblWorkflow.Size = New System.Drawing.Size(56, 16)
        Me.lblWorkflow.TabIndex = 92
        Me.lblWorkflow.Text = "运作方式"
        '
        'txtWorkflow
        '
        Me.txtWorkflow.BackColor = System.Drawing.Color.Gainsboro
        Me.txtWorkflow.Location = New System.Drawing.Point(368, 22)
        Me.txtWorkflow.Name = "txtWorkflow"
        Me.txtWorkflow.ReadOnly = True
        Me.txtWorkflow.Size = New System.Drawing.Size(144, 21)
        Me.txtWorkflow.TabIndex = 86
        Me.txtWorkflow.TabStop = False
        Me.txtWorkflow.Text = ""
        '
        'lblGuaranteeLetterType
        '
        Me.lblGuaranteeLetterType.Location = New System.Drawing.Point(8, 48)
        Me.lblGuaranteeLetterType.Name = "lblGuaranteeLetterType"
        Me.lblGuaranteeLetterType.Size = New System.Drawing.Size(56, 16)
        Me.lblGuaranteeLetterType.TabIndex = 90
        Me.lblGuaranteeLetterType.Text = "保函种类"
        '
        'lblBeneficiary
        '
        Me.lblBeneficiary.Location = New System.Drawing.Point(8, 72)
        Me.lblBeneficiary.Name = "lblBeneficiary"
        Me.lblBeneficiary.Size = New System.Drawing.Size(64, 16)
        Me.lblBeneficiary.TabIndex = 93
        Me.lblBeneficiary.Text = "受益人名称"
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
        'cboReimburseType
        '
        Me.cboReimburseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReimburseType.Enabled = False
        Me.cboReimburseType.ItemHeight = 12
        Me.cboReimburseType.Location = New System.Drawing.Point(368, 46)
        Me.cboReimburseType.Name = "cboReimburseType"
        Me.cboReimburseType.Size = New System.Drawing.Size(144, 20)
        Me.cboReimburseType.TabIndex = 88
        Me.cboReimburseType.TabStop = False
        '
        'lblReimburseType
        '
        Me.lblReimburseType.Location = New System.Drawing.Point(272, 48)
        Me.lblReimburseType.Name = "lblReimburseType"
        Me.lblReimburseType.Size = New System.Drawing.Size(80, 16)
        Me.lblReimburseType.TabIndex = 91
        Me.lblReimburseType.Text = "偿付责任类型"
        '
        'grpGuaranteeLetter
        '
        Me.grpGuaranteeLetter.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtServiceType, Me.lblServiceType, Me.cboSubBank, Me.cboBank, Me.lblBank, Me.lblSubBank, Me.txtEnsureMoney, Me.txtSecurityRate, Me.txtGuaranteeRate, Me.txtGuaranteeFee, Me.lblEnsureMoney, Me.lblSecurityRate, Me.lblGuaranteeSum, Me.lblGuaranteeRate, Me.txtTerms, Me.txtGuaranteeSum, Me.lbTerms, Me.lblGuaranteeLine, Me.txtWorkflow, Me.lblBeneficiary, Me.lblReimburseType, Me.lblGuaranteeLetterType, Me.cboGuaranteeLetterType, Me.cboReimburseType, Me.lblWorkflow, Me.txtBeneficiary})
        Me.grpGuaranteeLetter.Location = New System.Drawing.Point(8, 192)
        Me.grpGuaranteeLetter.Name = "grpGuaranteeLetter"
        Me.grpGuaranteeLetter.Size = New System.Drawing.Size(528, 192)
        Me.grpGuaranteeLetter.TabIndex = 94
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
        Me.cboSubBank.Location = New System.Drawing.Point(368, 118)
        Me.cboSubBank.Name = "cboSubBank"
        Me.cboSubBank.Size = New System.Drawing.Size(144, 20)
        Me.cboSubBank.TabIndex = 111
        '
        'cboBank
        '
        Me.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
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
        Me.lblSubBank.Location = New System.Drawing.Point(272, 120)
        Me.lblSubBank.Name = "lblSubBank"
        Me.lblSubBank.Size = New System.Drawing.Size(56, 16)
        Me.lblSubBank.TabIndex = 108
        Me.lblSubBank.Text = "出函支行"
        '
        'txtEnsureMoney
        '
        Me.txtEnsureMoney.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEnsureMoney.Location = New System.Drawing.Point(368, 166)
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
        Me.txtGuaranteeFee.Location = New System.Drawing.Point(368, 142)
        Me.txtGuaranteeFee.Name = "txtGuaranteeFee"
        Me.txtGuaranteeFee.ReadOnly = True
        Me.txtGuaranteeFee.Size = New System.Drawing.Size(144, 21)
        Me.txtGuaranteeFee.TabIndex = 104
        Me.txtGuaranteeFee.Text = ""
        Me.txtGuaranteeFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblEnsureMoney
        '
        Me.lblEnsureMoney.Location = New System.Drawing.Point(272, 168)
        Me.lblEnsureMoney.Name = "lblEnsureMoney"
        Me.lblEnsureMoney.Size = New System.Drawing.Size(96, 16)
        Me.lblEnsureMoney.TabIndex = 103
        Me.lblEnsureMoney.Text = "保证金金额(元)"
        '
        'lblSecurityRate
        '
        Me.lblSecurityRate.Location = New System.Drawing.Point(16, 168)
        Me.lblSecurityRate.Name = "lblSecurityRate"
        Me.lblSecurityRate.Size = New System.Drawing.Size(72, 16)
        Me.lblSecurityRate.TabIndex = 102
        Me.lblSecurityRate.Text = "保证金比例"
        '
        'lblGuaranteeSum
        '
        Me.lblGuaranteeSum.Location = New System.Drawing.Point(272, 144)
        Me.lblGuaranteeSum.Name = "lblGuaranteeSum"
        Me.lblGuaranteeSum.Size = New System.Drawing.Size(96, 16)
        Me.lblGuaranteeSum.TabIndex = 101
        Me.lblGuaranteeSum.Text = "担保费金额(元)"
        '
        'lblGuaranteeRate
        '
        Me.lblGuaranteeRate.Location = New System.Drawing.Point(8, 144)
        Me.lblGuaranteeRate.Name = "lblGuaranteeRate"
        Me.lblGuaranteeRate.Size = New System.Drawing.Size(72, 16)
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
        Me.txtGuaranteeSum.Location = New System.Drawing.Point(368, 94)
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
        Me.lblGuaranteeLine.Location = New System.Drawing.Point(272, 96)
        Me.lblGuaranteeLine.Name = "lblGuaranteeLine"
        Me.lblGuaranteeLine.Size = New System.Drawing.Size(96, 16)
        Me.lblGuaranteeLine.TabIndex = 94
        Me.lblGuaranteeLine.Text = "保函额度(万元)"
        '
        'btnViewEntente
        '
        Me.btnViewEntente.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnViewEntente.Image = CType(resources.GetObject("btnViewEntente.Image"), System.Drawing.Bitmap)
        Me.btnViewEntente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewEntente.ImageIndex = 28
        Me.btnViewEntente.ImageList = Me.ImageListBasic
        Me.btnViewEntente.Location = New System.Drawing.Point(20, 392)
        Me.btnViewEntente.Name = "btnViewEntente"
        Me.btnViewEntente.Size = New System.Drawing.Size(96, 23)
        Me.btnViewEntente.TabIndex = 95
        Me.btnViewEntente.Text = "查看协议(&V)"
        Me.btnViewEntente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnViewEntente.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgDatum})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(528, 152)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "材料清单"
        '
        'FGuaranteeLetterApply
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(546, 423)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.lblCorporationName, Me.lblProjectCode, Me.btnExit, Me.btnViewEntente, Me.grpGuaranteeLetter, Me.txtCorporationName, Me.txtProjectCode, Me.btnConferenceTrial, Me.btnDocument, Me.btnCommit})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FGuaranteeLetterApply"
        Me.Text = "呈请出函"
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpGuaranteeLetter.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsBank As DataSet
    Protected bFormLoad As Boolean = False  '子类使用
    Protected bIsChanged As Boolean = False '子类使用

    Private Sub FGuaranteeLetterApply_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.GetProjectData()
            Me.GetRequestVouchApplicationData()
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
        If Not dsBank.Tables("bank").Rows.Count = 0 Then
            dsBank.Tables("bank").DefaultView.Sort = "bank_name"
            Me.cboBank.DataSource = dsBank.Tables("bank").DefaultView
            Me.cboBank.DisplayMember = "bank_name"
            Me.cboBank.ValueMember = "bank_code"
            Me.cboBank.SelectedIndex = 0
        End If
        dsBank.Tables("bank_branch").DefaultView.Sort = "branch_bank_name"
        Me.cboSubBank.DataSource = dsBank.Tables("bank_branch").DefaultView
        Me.cboSubBank.DisplayMember = "branch_bank_name"
        Me.cboSubBank.ValueMember = "branch_bank_code"
        AddHandler cboBank.SelectedIndexChanged, AddressOf BankChanged
        Me.BankChanged(Nothing, Nothing)

        Dim tempDS As DataSet
        tempDS = gWs.GetReimburseType("%")                '偿付责任类型
        If Not tempDS.Tables(0).Rows.Count = 0 Then
            Me.cboReimburseType.DataSource = tempDS.Tables(0)
            Me.cboReimburseType.DisplayMember = "name"
            Me.cboReimburseType.ValueMember = "type_code"
            Me.cboReimburseType.SelectedIndex = 0
        End If

        tempDS = gWs.GetGuaranteeLetterType("%")          '保函类型
        If Not tempDS.Tables(0).Rows.Count = 0 Then
            Me.cboGuaranteeLetterType.DataSource = tempDS.Tables(0)
            Me.cboGuaranteeLetterType.DisplayMember = "name"
            Me.cboGuaranteeLetterType.ValueMember = "type_code"
            Me.cboGuaranteeLetterType.SelectedIndex = 0
        End If

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
                    If Not .Item("bank") Is DBNull.Value Then
                        Me.cboBank.SelectedValue = .Item("bank")                      '出函银行
                        Me.BankChanged(Nothing, Nothing)
                    End If
                    If Not .Item("bank_branch") Is DBNull.Value Then
                        Me.cboSubBank.SelectedValue = .Item("bank_branch")          '出函支行 
                    End If
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
                        If Not .Item("apply_bank") Is DBNull.Value Then
                            Me.cboBank.SelectedValue = .Item("apply_bank")                      '出函银行
                            Me.BankChanged(Nothing, Nothing)
                        End If
                        If Not .Item("apply_branch_bank") Is DBNull.Value Then
                            Me.cboSubBank.SelectedValue = .Item("apply_branch_bank")          '出函支行 
                        End If
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
                Me.BankChanged(Nothing, Nothing)
                Me.cboSubBank.SelectedValue = .Item("branch_bank")
            End With
        End If

        If Me.txtWorkflow.Text.Trim() = "额度项下保函" Then
            Me.btnViewEntente.Visible = True
        Else
            Me.btnDocument.Left -= 44
            Me.btnConferenceTrial.Left -= 44
            Me.btnCommit.Left -= 44
            Me.btnExit.Left -= 44
        End If

        AddHandler cboBank.SelectedIndexChanged, AddressOf DataChanged
        AddHandler cboSubBank.SelectedIndexChanged, AddressOf DataChanged
    End Sub

    Private Sub GetRequestVouchApplicationData()
        Dim dsTemp As DataSet = gWs.GetItem("%", "44")
        If Not dsTemp.Tables("TItem").Rows.Count = 0 Then
            Me.dgDatum.DataSource = Me.IsDatumFinished(dsTemp).Tables(0).DefaultView
        End If
        Me.AddTableStyle()
    End Sub

    Private Sub AddTableStyle()
        Me.dgDatum.TableStyles.Clear()
        Dim ts As DataGridTableStyle = New DataGridTableStyle()
        ts.MappingName = "TItem"

        Dim col0 As New DataGridTextBoxColumn()
        col0.HeaderText = "确认项名称"
        col0.MappingName = "item_name"
        col0.Width = 300

        Dim col1 As New DataGridTextBoxColumn()
        col1.HeaderText = "确认情况"
        col1.Alignment = HorizontalAlignment.Center
        col1.MappingName = "IsFinished"
        col1.Width = 80

        Dim col2 As New DataGridTextBoxColumn()
        col2.HeaderText = "确认人"
        col2.MappingName = "check_person"
        col2.NullText = ""
        col2.Width = 60

        Dim col3 As New DataGridTextBoxColumn()
        col3.Format = "yyyy-MM-dd"
        col3.HeaderText = "确认日期"
        col3.MappingName = "check_date"
        col3.NullText = ""
        col3.Width = 72

        Dim col4 As New DataGridTextBoxColumn()
        col4.MappingName = "item_code"
        col4.Width = 0

        ts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col0, col1, col2, col3, col4})

        Me.dgDatum.TableStyles.Add(ts)
    End Sub

    Private Function IsDatumFinished(ByVal ds As DataSet) As DataSet
        Dim dsTemp As DataSet
        dsTemp = gWs.GetProjectDocumentByCondition("{project_code='" & Me.getProjectCode() & "' AND item_type='44' AND check_person IS NOT NULL}")
        '添加文档是否完整的标志字段。
        ds.Tables("TItem").Columns.Add(("IsFinished"), GetType(String))
        '添加文档的检查人，检查日期字段。
        ds.Tables("TItem").Columns.Add(("check_person"), GetType(String))
        ds.Tables("TItem").Columns.Add(("check_date"), GetType(DateTime))

        Dim i As Integer
        For i = 0 To ds.Tables("TItem").Rows.Count - 1
            ds.Tables("TItem").Rows(i).Item("IsFinished") = "［Χ］"
        Next

        Dim intIsFinished As Integer = ds.Tables("TItem").Columns("IsFinished").Ordinal
        Dim intCheck_person As Integer = dsTemp.Tables(0).Columns("check_person").Ordinal
        Dim intCheck_date As Integer = dsTemp.Tables(0).Columns("check_date").Ordinal

        Dim dr() As DataRow
        For i = 0 To ds.Tables("TItem").Rows.Count - 1
            With ds.Tables("TItem").Rows(i)
                dr = dsTemp.Tables(0).Select("item_type = '" & .Item("item_type") & "' AND item_code = '" & .Item("item_code") & "'")
                If Not dr.Length = 0 Then
                    If Not IsDBNull(dr(0).Item("remark")) AndAlso dr(0).Item("remark") = "豁免" Then
                        .Item(intIsFinished) = "豁免"
                    Else
                        .Item(intIsFinished) = "［√］"
                    End If
                    .Item(intIsFinished + 1) = dr(0).Item(intCheck_person)
                    .Item(intIsFinished + 2) = dr(0).Item(intCheck_date)
                End If
            End With
        Next

        Return ds
    End Function

    Private Sub BankChanged(ByVal sender As Object, ByVal e As EventArgs)
        dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code = '" & Me.cboBank.SelectedValue & "'"
        dsBank.Tables("bank_branch").DefaultView.Sort = "branch_bank_name"
    End Sub

    Protected Sub DataChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Me.bFormLoad Then
            Me.bIsChanged = True
        End If
    End Sub

    Protected Overridable Function SaveData() As Boolean
        If Me.cboSubBank.SelectedValue Is Nothing Or cboSubBank.Text = "" Then
            'MessageBox.Show("支行输入不能为空，请确认。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1001", "银行")
            Return False
        End If
        Dim tempDS As DataSet
        Try
            tempDS = gWs.GetLoanNoticeInfo("{project_code = '" & Me.getProjectCode() & "'}")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    .Item("bank") = Me.cboBank.SelectedValue
                    .Item("branch_bank") = Me.cboSubBank.SelectedValue
                    .Item("sum") = Convert.ToDecimal(Me.txtGuaranteeSum.Text)
                    .Item("term") = Convert.ToDecimal(Me.txtTerms.Text)
                    .Item("create_date") = gWs.GetSysTime()
                    .Item("create_person") = UserName
                End With
            Else
                Dim dr As DataRow = tempDS.Tables(0).NewRow
                With dr
                    .Item("project_code") = Me.getProjectCode()
                    .Item("bank") = Me.cboBank.SelectedValue
                    .Item("branch_bank") = Me.cboSubBank.SelectedValue
                    Try
                        .Item("sum") = Convert.ToDecimal(Me.txtGuaranteeSum.Text)
                    Catch
                    End Try
                    Try
                        .Item("term") = Convert.ToDecimal(Me.txtTerms.Text)
                    Catch
                    End Try
                    .Item("create_date") = gWs.GetSysTime()
                    .Item("create_person") = UserName
                End With
                tempDS.Tables(0).Rows.Add(dr)
            End If
            Dim strResult As String = gWs.UpdateLoanNotice(tempDS)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存放款记录失败", strResult, "")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '制作出函通知书
    Protected Overridable Sub btnDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocument.Click
        If Me.cboSubBank.Text = "" Then
            'MessageBox.Show("支行输入不能为空，请确认。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1001", "银行")
            Return
        End If
        Dim strReplaceFrom(2) As String
        Dim Sum As Double
        strReplaceFrom(0) = "&#CorporationName"
        strReplaceFrom(1) = "&#BankName"
        strReplaceFrom(2) = "&#BranchBankName"
        Dim arrReplaceTo As New ArrayList()
        arrReplaceTo.Add(Me.getCorporationName())
        arrReplaceTo.Add(Me.cboBank.Text)
        arrReplaceTo.Add(Me.cboSubBank.Text)

        Dim doc As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "45", "110", Me.getUser(), strReplaceFrom, arrReplaceTo)
        doc.AllowTransparency = False
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
        Me.Close()
    End Sub
    '查看协议信息
    Private Sub btnViewEntente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewEntente.Click
        Dim frm As New FViewGuaranteeLetterUsage(Me.getProjectCode())
        frm.AllowTransparency = False
        frm.ShowDialog()
    End Sub

    Private Sub dgDatum_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDatum.DoubleClick
        If Me.dgDatum.DataSource Is Nothing Then
            Return
        End If
        If Me.dgDatum(dgDatum.CurrentRowIndex, 4).ToString().Trim() = "" Then
            Return
        End If
        Dim bIsGuarantee As Boolean = False
        Select Case Me.dgDatum.Item(dgDatum.CurrentRowIndex, 4).ToString().Trim()
            Case "006"               '抵押登记已办妥并收齐相关文本及资料
                Dim f As New frmRegistryAffirm(Me.getProjectCode(), True)
                f.AllowTransparency = False
                f.ShowDialog()
                bIsGuarantee = True
            Case "007"               '质押登记已办妥并收齐相关文本及资料
                Dim f As New frmPledgeRegistryAffirm(Me.getProjectCode(), True)
                f.AllowTransparency = False
                f.ShowDialog()
                bIsGuarantee = True
            Case "008"               '抵押反担保物保险已办妥并注明中心为第一收益人(保险手续确认)
            Case "009"               '已办理财产处置先行授权并公证项(预典当手续确认)
            Case "011"               '互助会手续办理确认
            Case "013"               '监管手续确认
                Dim f As New frmWardAffirm(Me.getProjectCode(), True)
                f.AllowTransparency = False
                f.ShowDialog()
                bIsGuarantee = True
            Case "014"               '法律文本确认
        End Select

        If Not bIsGuarantee Then
            Dim frm As New FViewConfirmItem(Me.getProjectCode(), Me.dgDatum.Item(dgDatum.CurrentRowIndex, 4).ToString().Trim())
            frm.AllowTransparency = False
            frm.ShowDialog()
        End If
    End Sub
End Class
