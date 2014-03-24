
'分配法务经理 －－保函
Public Class FAssignLawer_bh
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
    Public WithEvents lblCorporationName As System.Windows.Forms.Label
    Public WithEvents lblProjectCode As System.Windows.Forms.Label
    Protected WithEvents btnSearch As System.Windows.Forms.Button
    Protected WithEvents grpBaseInfo As System.Windows.Forms.GroupBox
    Protected WithEvents cboSubBank As System.Windows.Forms.ComboBox
    Protected WithEvents cboBank As System.Windows.Forms.ComboBox
    Protected WithEvents lblSubBank As System.Windows.Forms.Label
    Protected WithEvents lblApplyDate As System.Windows.Forms.Label
    Protected WithEvents dtpApplyDate As System.Windows.Forms.DateTimePicker
    Protected WithEvents txtApplyGuaranteeTerm As System.Windows.Forms.TextBox
    Protected WithEvents lblApplyGuaranteeTerm As System.Windows.Forms.Label
    Protected WithEvents txtApplyGuaranteeSum As System.Windows.Forms.TextBox
    Protected WithEvents lblApplyGuaranteeSum As System.Windows.Forms.Label
    Protected WithEvents lblBank As System.Windows.Forms.Label
    Protected WithEvents txtApplyServiceType As System.Windows.Forms.TextBox
    Protected WithEvents lblApplyServiceType As System.Windows.Forms.Label
    Protected WithEvents txtIndustryType As System.Windows.Forms.TextBox
    Protected WithEvents lblIndustryType As System.Windows.Forms.Label
    Protected WithEvents txtEnterpriseType As System.Windows.Forms.TextBox
    Protected WithEvents lblEnterpriseType As System.Windows.Forms.Label
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Public WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Protected WithEvents btnCommit As System.Windows.Forms.Button
    Protected WithEvents cboLawer As System.Windows.Forms.ComboBox
    Protected WithEvents lblLawer As System.Windows.Forms.Label
    Friend WithEvents grpBH_type As System.Windows.Forms.GroupBox
    Friend WithEvents txtWorkflow As System.Windows.Forms.TextBox
    Friend WithEvents cboGuaranteeLetterType As System.Windows.Forms.ComboBox
    Friend WithEvents cboReimburseType As System.Windows.Forms.ComboBox
    Friend WithEvents lblWorkflow As System.Windows.Forms.Label
    Friend WithEvents lblGuaranteeLetterType As System.Windows.Forms.Label
    Friend WithEvents lblReimburseType As System.Windows.Forms.Label
    Friend WithEvents txtPmB As System.Windows.Forms.TextBox
    Friend WithEvents lbPmB As System.Windows.Forms.Label
    Friend WithEvents txtPmA As System.Windows.Forms.TextBox
    Friend WithEvents lblPmA As System.Windows.Forms.Label
    Friend WithEvents lblGuaranteeSum As System.Windows.Forms.Label
    Friend WithEvents lblTerms As System.Windows.Forms.Label
    Friend WithEvents lblConfirmbank As System.Windows.Forms.Label
    Friend WithEvents lblConfirmbankBranch As System.Windows.Forms.Label
    Friend WithEvents txtGuaranteeSum As System.Windows.Forms.TextBox
    Friend WithEvents txtTerms As System.Windows.Forms.TextBox
    Friend WithEvents cboConfirmBank As System.Windows.Forms.ComboBox
    Friend WithEvents cboConfirmBankBranch As System.Windows.Forms.ComboBox
    Friend WithEvents btnConclusion As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FAssignLawer_bh))
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.lblProjectCode = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.grpBaseInfo = New System.Windows.Forms.GroupBox()
        Me.txtPmB = New System.Windows.Forms.TextBox()
        Me.lbPmB = New System.Windows.Forms.Label()
        Me.txtPmA = New System.Windows.Forms.TextBox()
        Me.lblPmA = New System.Windows.Forms.Label()
        Me.cboSubBank = New System.Windows.Forms.ComboBox()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.lblSubBank = New System.Windows.Forms.Label()
        Me.lblApplyDate = New System.Windows.Forms.Label()
        Me.dtpApplyDate = New System.Windows.Forms.DateTimePicker()
        Me.txtApplyGuaranteeTerm = New System.Windows.Forms.TextBox()
        Me.lblApplyGuaranteeTerm = New System.Windows.Forms.Label()
        Me.txtApplyGuaranteeSum = New System.Windows.Forms.TextBox()
        Me.lblApplyGuaranteeSum = New System.Windows.Forms.Label()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.txtApplyServiceType = New System.Windows.Forms.TextBox()
        Me.lblApplyServiceType = New System.Windows.Forms.Label()
        Me.txtIndustryType = New System.Windows.Forms.TextBox()
        Me.lblIndustryType = New System.Windows.Forms.Label()
        Me.txtEnterpriseType = New System.Windows.Forms.TextBox()
        Me.lblEnterpriseType = New System.Windows.Forms.Label()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.cboLawer = New System.Windows.Forms.ComboBox()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.lblLawer = New System.Windows.Forms.Label()
        Me.grpBH_type = New System.Windows.Forms.GroupBox()
        Me.cboConfirmBankBranch = New System.Windows.Forms.ComboBox()
        Me.cboConfirmBank = New System.Windows.Forms.ComboBox()
        Me.txtTerms = New System.Windows.Forms.TextBox()
        Me.txtGuaranteeSum = New System.Windows.Forms.TextBox()
        Me.lblConfirmbankBranch = New System.Windows.Forms.Label()
        Me.lblConfirmbank = New System.Windows.Forms.Label()
        Me.lblTerms = New System.Windows.Forms.Label()
        Me.lblGuaranteeSum = New System.Windows.Forms.Label()
        Me.txtWorkflow = New System.Windows.Forms.TextBox()
        Me.cboGuaranteeLetterType = New System.Windows.Forms.ComboBox()
        Me.cboReimburseType = New System.Windows.Forms.ComboBox()
        Me.lblWorkflow = New System.Windows.Forms.Label()
        Me.lblGuaranteeLetterType = New System.Windows.Forms.Label()
        Me.lblReimburseType = New System.Windows.Forms.Label()
        Me.btnConclusion = New System.Windows.Forms.Button()
        Me.grpBaseInfo.SuspendLayout()
        Me.grpBH_type.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(360, 352)
        Me.btnExit.Visible = True
        '
        'lblCorporationName
        '
        Me.lblCorporationName.AutoSize = True
        Me.lblCorporationName.Location = New System.Drawing.Point(184, 8)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(54, 14)
        Me.lblCorporationName.TabIndex = 33
        Me.lblCorporationName.Text = "企业名称"
        '
        'lblProjectCode
        '
        Me.lblProjectCode.AutoSize = True
        Me.lblProjectCode.Location = New System.Drawing.Point(16, 8)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(54, 14)
        Me.lblProjectCode.TabIndex = 32
        Me.lblProjectCode.Text = "项目编码"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Bitmap)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.ImageIndex = 27
        Me.btnSearch.ImageList = Me.ImageListBasic
        Me.btnSearch.Location = New System.Drawing.Point(185, 352)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 23)
        Me.btnSearch.TabIndex = 30
        Me.btnSearch.Text = "查 询(&S)"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpBaseInfo
        '
        Me.grpBaseInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtPmB, Me.lbPmB, Me.txtPmA, Me.lblPmA, Me.cboSubBank, Me.cboBank, Me.lblSubBank, Me.lblApplyDate, Me.dtpApplyDate, Me.txtApplyGuaranteeTerm, Me.lblApplyGuaranteeTerm, Me.txtApplyGuaranteeSum, Me.lblApplyGuaranteeSum, Me.lblBank, Me.txtApplyServiceType, Me.lblApplyServiceType, Me.txtIndustryType, Me.lblIndustryType, Me.txtEnterpriseType, Me.lblEnterpriseType})
        Me.grpBaseInfo.Location = New System.Drawing.Point(8, 32)
        Me.grpBaseInfo.Name = "grpBaseInfo"
        Me.grpBaseInfo.Size = New System.Drawing.Size(504, 152)
        Me.grpBaseInfo.TabIndex = 36
        Me.grpBaseInfo.TabStop = False
        Me.grpBaseInfo.Text = "项目基本信息"
        '
        'txtPmB
        '
        Me.txtPmB.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPmB.Location = New System.Drawing.Point(344, 118)
        Me.txtPmB.Name = "txtPmB"
        Me.txtPmB.ReadOnly = True
        Me.txtPmB.Size = New System.Drawing.Size(144, 21)
        Me.txtPmB.TabIndex = 52
        Me.txtPmB.Text = ""
        '
        'lbPmB
        '
        Me.lbPmB.Location = New System.Drawing.Point(264, 120)
        Me.lbPmB.Name = "lbPmB"
        Me.lbPmB.Size = New System.Drawing.Size(60, 16)
        Me.lbPmB.TabIndex = 51
        Me.lbPmB.Text = "项目经理B"
        '
        'txtPmA
        '
        Me.txtPmA.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPmA.Location = New System.Drawing.Point(96, 118)
        Me.txtPmA.Name = "txtPmA"
        Me.txtPmA.ReadOnly = True
        Me.txtPmA.Size = New System.Drawing.Size(152, 21)
        Me.txtPmA.TabIndex = 50
        Me.txtPmA.Text = ""
        '
        'lblPmA
        '
        Me.lblPmA.Location = New System.Drawing.Point(8, 120)
        Me.lblPmA.Name = "lblPmA"
        Me.lblPmA.Size = New System.Drawing.Size(60, 16)
        Me.lblPmA.TabIndex = 49
        Me.lblPmA.Text = "项目经理A"
        '
        'cboSubBank
        '
        Me.cboSubBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubBank.Enabled = False
        Me.cboSubBank.Location = New System.Drawing.Point(344, 70)
        Me.cboSubBank.Name = "cboSubBank"
        Me.cboSubBank.Size = New System.Drawing.Size(144, 20)
        Me.cboSubBank.TabIndex = 32
        Me.cboSubBank.TabStop = False
        '
        'cboBank
        '
        Me.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBank.Enabled = False
        Me.cboBank.Location = New System.Drawing.Point(96, 70)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(152, 20)
        Me.cboBank.TabIndex = 31
        Me.cboBank.TabStop = False
        '
        'lblSubBank
        '
        Me.lblSubBank.Location = New System.Drawing.Point(264, 72)
        Me.lblSubBank.Name = "lblSubBank"
        Me.lblSubBank.Size = New System.Drawing.Size(54, 16)
        Me.lblSubBank.TabIndex = 29
        Me.lblSubBank.Text = "申请支行"
        '
        'lblApplyDate
        '
        Me.lblApplyDate.Location = New System.Drawing.Point(8, 48)
        Me.lblApplyDate.Name = "lblApplyDate"
        Me.lblApplyDate.Size = New System.Drawing.Size(54, 16)
        Me.lblApplyDate.TabIndex = 26
        Me.lblApplyDate.Text = "申请日期"
        '
        'dtpApplyDate
        '
        Me.dtpApplyDate.Enabled = False
        Me.dtpApplyDate.Location = New System.Drawing.Point(96, 46)
        Me.dtpApplyDate.Name = "dtpApplyDate"
        Me.dtpApplyDate.Size = New System.Drawing.Size(152, 21)
        Me.dtpApplyDate.TabIndex = 25
        Me.dtpApplyDate.TabStop = False
        Me.dtpApplyDate.Value = New Date(2003, 6, 27, 0, 0, 0, 0)
        '
        'txtApplyGuaranteeTerm
        '
        Me.txtApplyGuaranteeTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyGuaranteeTerm.Location = New System.Drawing.Point(344, 94)
        Me.txtApplyGuaranteeTerm.Name = "txtApplyGuaranteeTerm"
        Me.txtApplyGuaranteeTerm.ReadOnly = True
        Me.txtApplyGuaranteeTerm.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyGuaranteeTerm.TabIndex = 22
        Me.txtApplyGuaranteeTerm.TabStop = False
        Me.txtApplyGuaranteeTerm.Text = ""
        Me.txtApplyGuaranteeTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblApplyGuaranteeTerm
        '
        Me.lblApplyGuaranteeTerm.Location = New System.Drawing.Point(264, 96)
        Me.lblApplyGuaranteeTerm.Name = "lblApplyGuaranteeTerm"
        Me.lblApplyGuaranteeTerm.Size = New System.Drawing.Size(80, 16)
        Me.lblApplyGuaranteeTerm.TabIndex = 21
        Me.lblApplyGuaranteeTerm.Text = "申请期限(月)"
        '
        'txtApplyGuaranteeSum
        '
        Me.txtApplyGuaranteeSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyGuaranteeSum.Location = New System.Drawing.Point(96, 94)
        Me.txtApplyGuaranteeSum.Name = "txtApplyGuaranteeSum"
        Me.txtApplyGuaranteeSum.ReadOnly = True
        Me.txtApplyGuaranteeSum.Size = New System.Drawing.Size(152, 21)
        Me.txtApplyGuaranteeSum.TabIndex = 20
        Me.txtApplyGuaranteeSum.TabStop = False
        Me.txtApplyGuaranteeSum.Text = ""
        Me.txtApplyGuaranteeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblApplyGuaranteeSum
        '
        Me.lblApplyGuaranteeSum.Location = New System.Drawing.Point(8, 96)
        Me.lblApplyGuaranteeSum.Name = "lblApplyGuaranteeSum"
        Me.lblApplyGuaranteeSum.Size = New System.Drawing.Size(96, 16)
        Me.lblApplyGuaranteeSum.TabIndex = 19
        Me.lblApplyGuaranteeSum.Text = "申请金额(万元)"
        '
        'lblBank
        '
        Me.lblBank.Location = New System.Drawing.Point(8, 72)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(54, 16)
        Me.lblBank.TabIndex = 17
        Me.lblBank.Text = "申请银行"
        '
        'txtApplyServiceType
        '
        Me.txtApplyServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyServiceType.Location = New System.Drawing.Point(344, 46)
        Me.txtApplyServiceType.Name = "txtApplyServiceType"
        Me.txtApplyServiceType.ReadOnly = True
        Me.txtApplyServiceType.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyServiceType.TabIndex = 16
        Me.txtApplyServiceType.TabStop = False
        Me.txtApplyServiceType.Text = ""
        '
        'lblApplyServiceType
        '
        Me.lblApplyServiceType.Location = New System.Drawing.Point(264, 48)
        Me.lblApplyServiceType.Name = "lblApplyServiceType"
        Me.lblApplyServiceType.Size = New System.Drawing.Size(80, 16)
        Me.lblApplyServiceType.TabIndex = 15
        Me.lblApplyServiceType.Text = "申请业务品种"
        '
        'txtIndustryType
        '
        Me.txtIndustryType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtIndustryType.Location = New System.Drawing.Point(96, 22)
        Me.txtIndustryType.Name = "txtIndustryType"
        Me.txtIndustryType.ReadOnly = True
        Me.txtIndustryType.Size = New System.Drawing.Size(152, 21)
        Me.txtIndustryType.TabIndex = 3
        Me.txtIndustryType.TabStop = False
        Me.txtIndustryType.Text = ""
        '
        'lblIndustryType
        '
        Me.lblIndustryType.Location = New System.Drawing.Point(8, 24)
        Me.lblIndustryType.Name = "lblIndustryType"
        Me.lblIndustryType.Size = New System.Drawing.Size(54, 16)
        Me.lblIndustryType.TabIndex = 2
        Me.lblIndustryType.Text = "行业类型"
        '
        'txtEnterpriseType
        '
        Me.txtEnterpriseType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEnterpriseType.Location = New System.Drawing.Point(344, 22)
        Me.txtEnterpriseType.Name = "txtEnterpriseType"
        Me.txtEnterpriseType.ReadOnly = True
        Me.txtEnterpriseType.Size = New System.Drawing.Size(144, 21)
        Me.txtEnterpriseType.TabIndex = 1
        Me.txtEnterpriseType.TabStop = False
        Me.txtEnterpriseType.Text = ""
        '
        'lblEnterpriseType
        '
        Me.lblEnterpriseType.Location = New System.Drawing.Point(264, 24)
        Me.lblEnterpriseType.Name = "lblEnterpriseType"
        Me.lblEnterpriseType.Size = New System.Drawing.Size(54, 16)
        Me.lblEnterpriseType.TabIndex = 0
        Me.lblEnterpriseType.Text = "企业类型"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 5)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 34
        Me.txtProjectCode.TabStop = False
        Me.txtProjectCode.Text = ""
        '
        'cboLawer
        '
        Me.cboLawer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLawer.Location = New System.Drawing.Point(104, 328)
        Me.cboLawer.Name = "cboLawer"
        Me.cboLawer.Size = New System.Drawing.Size(152, 20)
        Me.cboLawer.TabIndex = 28
        '
        'txtCorporationName
        '
        Me.txtCorporationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorporationName.Location = New System.Drawing.Point(248, 5)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.ReadOnly = True
        Me.txtCorporationName.Size = New System.Drawing.Size(264, 21)
        Me.txtCorporationName.TabIndex = 35
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
        Me.btnCommit.Location = New System.Drawing.Point(272, 352)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 31
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLawer
        '
        Me.lblLawer.Location = New System.Drawing.Point(16, 330)
        Me.lblLawer.Name = "lblLawer"
        Me.lblLawer.Size = New System.Drawing.Size(56, 16)
        Me.lblLawer.TabIndex = 38
        Me.lblLawer.Text = "分配人员"
        '
        'grpBH_type
        '
        Me.grpBH_type.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboConfirmBankBranch, Me.cboConfirmBank, Me.txtTerms, Me.txtGuaranteeSum, Me.lblConfirmbankBranch, Me.lblConfirmbank, Me.lblTerms, Me.lblGuaranteeSum, Me.txtWorkflow, Me.cboGuaranteeLetterType, Me.cboReimburseType, Me.lblWorkflow, Me.lblGuaranteeLetterType, Me.lblReimburseType})
        Me.grpBH_type.Location = New System.Drawing.Point(8, 192)
        Me.grpBH_type.Name = "grpBH_type"
        Me.grpBH_type.Size = New System.Drawing.Size(504, 128)
        Me.grpBH_type.TabIndex = 43
        Me.grpBH_type.TabStop = False
        Me.grpBH_type.Text = "保函品种信息"
        '
        'cboConfirmBankBranch
        '
        Me.cboConfirmBankBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConfirmBankBranch.Enabled = False
        Me.cboConfirmBankBranch.Location = New System.Drawing.Point(344, 94)
        Me.cboConfirmBankBranch.Name = "cboConfirmBankBranch"
        Me.cboConfirmBankBranch.Size = New System.Drawing.Size(144, 20)
        Me.cboConfirmBankBranch.TabIndex = 53
        '
        'cboConfirmBank
        '
        Me.cboConfirmBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConfirmBank.Enabled = False
        Me.cboConfirmBank.Location = New System.Drawing.Point(96, 94)
        Me.cboConfirmBank.Name = "cboConfirmBank"
        Me.cboConfirmBank.Size = New System.Drawing.Size(152, 20)
        Me.cboConfirmBank.TabIndex = 52
        '
        'txtTerms
        '
        Me.txtTerms.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerms.Location = New System.Drawing.Point(344, 70)
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.ReadOnly = True
        Me.txtTerms.Size = New System.Drawing.Size(144, 21)
        Me.txtTerms.TabIndex = 51
        Me.txtTerms.Text = ""
        Me.txtTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGuaranteeSum
        '
        Me.txtGuaranteeSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuaranteeSum.Location = New System.Drawing.Point(96, 70)
        Me.txtGuaranteeSum.Name = "txtGuaranteeSum"
        Me.txtGuaranteeSum.ReadOnly = True
        Me.txtGuaranteeSum.Size = New System.Drawing.Size(152, 21)
        Me.txtGuaranteeSum.TabIndex = 50
        Me.txtGuaranteeSum.Text = ""
        Me.txtGuaranteeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblConfirmbankBranch
        '
        Me.lblConfirmbankBranch.Location = New System.Drawing.Point(264, 96)
        Me.lblConfirmbankBranch.Name = "lblConfirmbankBranch"
        Me.lblConfirmbankBranch.Size = New System.Drawing.Size(54, 16)
        Me.lblConfirmbankBranch.TabIndex = 49
        Me.lblConfirmbankBranch.Text = "出函支行"
        '
        'lblConfirmbank
        '
        Me.lblConfirmbank.Location = New System.Drawing.Point(8, 96)
        Me.lblConfirmbank.Name = "lblConfirmbank"
        Me.lblConfirmbank.Size = New System.Drawing.Size(54, 16)
        Me.lblConfirmbank.TabIndex = 48
        Me.lblConfirmbank.Text = "出函银行"
        '
        'lblTerms
        '
        Me.lblTerms.Location = New System.Drawing.Point(264, 72)
        Me.lblTerms.Name = "lblTerms"
        Me.lblTerms.Size = New System.Drawing.Size(80, 16)
        Me.lblTerms.TabIndex = 47
        Me.lblTerms.Text = "保函期限(月)"
        '
        'lblGuaranteeSum
        '
        Me.lblGuaranteeSum.Location = New System.Drawing.Point(8, 72)
        Me.lblGuaranteeSum.Name = "lblGuaranteeSum"
        Me.lblGuaranteeSum.Size = New System.Drawing.Size(96, 16)
        Me.lblGuaranteeSum.TabIndex = 46
        Me.lblGuaranteeSum.Text = "保函额度(万元)"
        '
        'txtWorkflow
        '
        Me.txtWorkflow.BackColor = System.Drawing.Color.Gainsboro
        Me.txtWorkflow.Location = New System.Drawing.Point(96, 22)
        Me.txtWorkflow.Name = "txtWorkflow"
        Me.txtWorkflow.ReadOnly = True
        Me.txtWorkflow.Size = New System.Drawing.Size(152, 21)
        Me.txtWorkflow.TabIndex = 45
        Me.txtWorkflow.TabStop = False
        Me.txtWorkflow.Text = ""
        '
        'cboGuaranteeLetterType
        '
        Me.cboGuaranteeLetterType.Enabled = False
        Me.cboGuaranteeLetterType.Location = New System.Drawing.Point(344, 22)
        Me.cboGuaranteeLetterType.Name = "cboGuaranteeLetterType"
        Me.cboGuaranteeLetterType.Size = New System.Drawing.Size(144, 20)
        Me.cboGuaranteeLetterType.TabIndex = 43
        Me.cboGuaranteeLetterType.TabStop = False
        '
        'cboReimburseType
        '
        Me.cboReimburseType.Enabled = False
        Me.cboReimburseType.Location = New System.Drawing.Point(96, 46)
        Me.cboReimburseType.Name = "cboReimburseType"
        Me.cboReimburseType.Size = New System.Drawing.Size(152, 20)
        Me.cboReimburseType.TabIndex = 42
        Me.cboReimburseType.TabStop = False
        '
        'lblWorkflow
        '
        Me.lblWorkflow.Location = New System.Drawing.Point(8, 24)
        Me.lblWorkflow.Name = "lblWorkflow"
        Me.lblWorkflow.Size = New System.Drawing.Size(54, 16)
        Me.lblWorkflow.TabIndex = 37
        Me.lblWorkflow.Text = "运作方式"
        '
        'lblGuaranteeLetterType
        '
        Me.lblGuaranteeLetterType.Location = New System.Drawing.Point(264, 24)
        Me.lblGuaranteeLetterType.Name = "lblGuaranteeLetterType"
        Me.lblGuaranteeLetterType.Size = New System.Drawing.Size(54, 16)
        Me.lblGuaranteeLetterType.TabIndex = 30
        Me.lblGuaranteeLetterType.Text = "保函种类"
        '
        'lblReimburseType
        '
        Me.lblReimburseType.Location = New System.Drawing.Point(8, 48)
        Me.lblReimburseType.Name = "lblReimburseType"
        Me.lblReimburseType.Size = New System.Drawing.Size(79, 16)
        Me.lblReimburseType.TabIndex = 34
        Me.lblReimburseType.Text = "偿付责任类型"
        '
        'btnConclusion
        '
        Me.btnConclusion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnConclusion.Image = CType(resources.GetObject("btnConclusion.Image"), System.Drawing.Bitmap)
        Me.btnConclusion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConclusion.ImageIndex = 28
        Me.btnConclusion.ImageList = Me.ImageListBasic
        Me.btnConclusion.Location = New System.Drawing.Point(64, 352)
        Me.btnConclusion.Name = "btnConclusion"
        Me.btnConclusion.Size = New System.Drawing.Size(112, 23)
        Me.btnConclusion.TabIndex = 44
        Me.btnConclusion.Text = "评审会结论(&R)"
        Me.btnConclusion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FAssignLawer_bh
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(522, 383)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnConclusion, Me.grpBH_type, Me.lblLawer, Me.lblCorporationName, Me.lblProjectCode, Me.btnSearch, Me.grpBaseInfo, Me.txtProjectCode, Me.cboLawer, Me.txtCorporationName, Me.btnCommit, Me.btnExit})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FAssignLawer_bh"
        Me.Text = "分配法务经理"
        Me.grpBaseInfo.ResumeLayout(False)
        Me.grpBH_type.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsBank, dsConfirmBank As DataSet

    Private Sub FAssignLawer_bh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.GetData()
            Me.GetLawerData()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '获取保函数据
    Private Sub GetData()
        Me.txtProjectCode.Text = Me.getProjectCode()
        Me.txtCorporationName.Text = Me.getCorporationName()
        Dim tempDS As DataSet
        Try
            tempDS = gWs.GetcorporationInfo("{corporation_name='" & Me.getCorporationName() & "'}", "null")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    If Not .Item("industry_type") Is System.DBNull.Value Then
                        Me.txtIndustryType.Text = .Item("industry_type")         '行业类型
                    End If
                    If Not .Item("proprietorship_type") Is System.DBNull.Value Then
                        Me.txtEnterpriseType.Text = .Item("proprietorship_type") '企业类型
                    End If
                End With
            End If
            '初始化银行的ComboBox
            dsBank = gWs.GetBankInfo("%", "%")
            Me.cboBank.DataSource = dsBank.Tables("bank")
            Me.cboBank.DisplayMember = "bank_name"
            Me.cboBank.ValueMember = "bank_code"
            Me.cboSubBank.DataSource = dsBank.Tables("bank_branch").DefaultView
            Me.cboSubBank.DisplayMember = "branch_bank_name"
            Me.cboSubBank.ValueMember = "branch_bank_code"
            Me.BankChanged()

            dsConfirmBank = gWs.GetBankInfo("%", "%")
            Me.cboConfirmBank.DataSource = dsConfirmBank.Tables("bank")
            Me.cboConfirmBank.DisplayMember = "bank_name"
            Me.cboConfirmBank.ValueMember = "bank_code"
            Me.cboConfirmBankBranch.DataSource = dsConfirmBank.Tables("bank_branch").DefaultView
            Me.cboConfirmBankBranch.DisplayMember = "branch_bank_name"
            Me.cboConfirmBankBranch.ValueMember = "branch_bank_code"
            Me.ConFirmBankChanged()

            tempDS = gWs.GetReimburseType("%")
            Me.cboReimburseType.DataSource = tempDS.Tables(0)
            Me.cboReimburseType.DisplayMember = "name"
            Me.cboReimburseType.ValueMember = "type_code"
            tempDS = gWs.GetGuaranteeLetterType("%")
            Me.cboGuaranteeLetterType.DataSource = tempDS.Tables(0)
            Me.cboGuaranteeLetterType.DisplayMember = "name"
            Me.cboGuaranteeLetterType.ValueMember = "type_code"

            tempDS = gWs.GetProjectInfo("{project_code='" & Me.getProjectCode() & "'}")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    Me.txtApplyGuaranteeSum.Text = IIf(.Item("apply_sum") Is DBNull.Value, "", .Item("apply_sum"))  '申请金额
                    Me.txtApplyGuaranteeTerm.Text = IIf(.Item("apply_term") Is DBNull.Value, "", .Item("apply_term")) '申请期限
                    If Not .Item("apply_date") Is System.DBNull.Value Then
                        Me.dtpApplyDate.Value = .Item("apply_date")         '申请时间
                    End If
                    Me.txtApplyServiceType.Text = IIf(.Item("apply_service_type") Is DBNull.Value, "", .Item("apply_service_type")) '申请业务品种
                    If Not .Item("apply_bank") Is System.DBNull.Value Then
                        Me.cboBank.SelectedValue = .Item("apply_bank")      '申请银行
                        Me.BankChanged()
                    End If
                    If Not .Item("apply_branch_bank") Is System.DBNull.Value Then
                        Me.cboSubBank.SelectedValue = .Item("apply_branch_bank") '申请支行
                    End If
                    Me.txtWorkflow.Text = IIf(.Item("workflow") Is DBNull.Value, "", .Item("workflow"))            '运作方式
                    Me.txtGuaranteeSum.Text = IIf(.Item("apply_sum") Is DBNull.Value, "", .Item("apply_sum")) '保函额度
                    Me.txtTerms.Text = IIf(.Item("apply_term") Is DBNull.Value, "", .Item("apply_term"))   '保函限期
                    If Not .Item("guarantee_letter_type") Is DBNull.Value Then
                        Me.cboGuaranteeLetterType.SelectedValue = .Item("guarantee_letter_type") '保函种类
                    End If
                    If Not .Item("reimburse_type") Is DBNull.Value Then
                        Me.cboReimburseType.SelectedValue = .Item("reimburse_type")           '偿付责任类型
                    End If
                    If Not .Item("apply_bank") Is DBNull.Value Then
                        Me.cboConfirmBank.SelectedValue = .Item("apply_bank")                       '出函银行
                        Me.ConFirmBankChanged()
                    End If
                    If Not .Item("apply_branch_bank") Is DBNull.Value Then
                        Me.cboConfirmBankBranch.SelectedValue = .Item("apply_branch_bank")          '出函支行 
                    End If
                End With
            End If
            tempDS = gWs.GetProjectInfoEx("{ProjectCode = '" & Me.getProjectCode() & "'}")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    Me.txtPmA.Text = IIf(.Item("manager_A") Is DBNull.Value, "", .Item("manager_A"))  '项目经理A
                    Me.txtPmB.Text = IIf(.Item("manager_B") Is DBNull.Value, "", .Item("manager_B"))  '项目经理B
                End With
            End If

            tempDS = gWs.GetConfTrialInfo("{project_code LIKE '" & Me.getProjectCode() & "' ORDER BY trial_times DESC }", "null")
            If Not tempDS.Tables("conference_trial").Rows.Count = 0 Then
                With tempDS.Tables("conference_trial").Rows(0)
                    Me.txtWorkflow.Text = IIf(.Item("workflow") Is DBNull.Value, "", .Item("workflow"))  '运作方式
                    Me.txtGuaranteeSum.Text = IIf(.Item("guarantee_sum") Is DBNull.Value, "", .Item("guarantee_sum")) '保函额度
                    Me.txtTerms.Text = IIf(.Item("terms") Is DBNull.Value, "", .Item("terms"))   '保函限期
                    If Not .Item("guarantee_letter_type") Is DBNull.Value Then
                        Me.cboGuaranteeLetterType.SelectedValue = .Item("guarantee_letter_type") '保函种类
                    End If
                    If Not .Item("reimburse_type") Is DBNull.Value Then
                        Me.cboReimburseType.SelectedValue = .Item("reimburse_type")           '偿付责任类型
                    End If
                    If Not .Item("bank") Is DBNull.Value Then
                        Me.cboConfirmBank.SelectedValue = .Item("bank")                       '出函银行
                        Me.ConFirmBankChanged()
                    End If
                    If Not .Item("bank_branch") Is DBNull.Value Then
                        Me.cboConfirmBankBranch.SelectedValue = .Item("bank_branch")          '出函支行 
                    End If
                End With
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Sub
    '初始化分配人员的ComboBox
    Private Sub GetLawerData()
        Dim dtTemp As DataTable
        'dtTemp = MdlGlobal.GetPerson(Me.getProjectCode(), "33")
        Dim i As Integer
        'For i = 0 To dtTemp.Rows.Count - 1
        '    Me.cboLawer.Items.Add(dtTemp.Rows(i).Item("staff_name"))
        'Next
        Dim arylist As ArrayList = MdlGlobal.GetPersnList(MdlGlobal.GetConsigner(Me.getProjectCode(), Me.getTaskID()), "33")
        For i = 0 To arylist.Count - 1
            Me.cboLawer.Items.Add(arylist.Item(i).ToString())
        Next
        'get the default peson
        dtTemp = gWs.GetDefaultPerson(Me.getProjectCode(), "33").Tables(0)
        If Not dtTemp.Rows.Count = 0 Then
            Me.cboLawer.SelectedItem = dtTemp.Rows(0).Item("Person")
        End If
    End Sub

    Private Sub BankChanged()
        dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code = '" & Me.cboBank.SelectedValue & "'"
    End Sub
    Private Sub ConFirmBankChanged()
        dsConfirmBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code = '" & Me.cboConfirmBank.SelectedValue & "'"
    End Sub

    Private Function SaveData() As Boolean
        If Me.cboLawer.Text = "" Then
            SWDialogBox.MessageBox.Show("$1007", "分配人员")
            Return False
        End If
        Dim tempDS As DataSet
        Dim i As Integer
        Try
            tempDS = gWs.GetProjectTaskAttendeeInfo("{project_code='" & Me.getProjectCode() & "' and role_id='33'}")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                For i = 0 To tempDS.Tables(0).Rows.Count - 1
                    tempDS.Tables(0).Rows(i).Item("attend_person") = Workflow.GetRealTaskAttendee("33", Me.cboLawer.Text)
                Next
            End If
            Dim strResult As String = gWs.UpdateProjectTaskAttendee(tempDS)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "分配法务经理失败", strResult, "")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '评审会结论
    Private Sub btnConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConclusion.Click
        '额度项下的项目所有调用查看评审会结论的地方，如果本项目没有评审会结论，调用综合授信的评审会意见表，否则调用本项目的评审会意见表
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
    '工作任务
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim frm As New frmQueryCurrentTask("33")
        frm.AllowTransparency = False
        frm.ProjectCode = Me.getProjectCode()
        frm.TaskID = Me.getTaskID()
        frm.ShowDialog()
    End Sub
    '提交
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If SWDialogBox.MessageBox.Show("?1000", "提交") <> MsgBoxResult.Yes Then
            Return
        End If
        Try
            If Not Me.SaveData() Then
                Return
            End If
            Dim strResult As String
            strResult = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), Me.cboLawer.Text, UserName)
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
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
