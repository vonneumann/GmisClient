

Public Class frmCorAssure
    Inherits Form

    Private CorporationName As String
    Private ProjectCode As String
    Private SystemDate As Date
    Private dsCorporation As DataSet
    Private bmCorporation As BindingManagerBase
    Private dsProCor As DataSet
    Private bmProCor As BindingManagerBase
    Private dsStockStru As DataSet
    Private bmStockStru As BindingManagerBase
    Private dsVouchRec As DataSet
    Private bmVouchRec As BindingManagerBase
    Private dsLoanRec As DataSet
    Private bmLoanRec As BindingManagerBase
    Private phrase As String
    Private strStatus As String = String.Empty
    Private CorPosition As Integer '若为新增,则为-1,否则为修改
    Private CorporationCode As String '企业编码
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub
    Public Sub New(ByVal CorIndex As Integer, ByVal project_code As String, ByVal cor_name As String, ByVal phrase As String)
        MyBase.New()
        Me.InitializeComponent()
        CorPosition = CorIndex
        Me.ProjectCode = project_code
        Me.CorporationName = cor_name
        Me.phrase = phrase
    End Sub
    Public Sub New(ByVal CorIndex As Integer, ByVal project_code As String, ByVal cor_name As String, ByVal phrase As String, ByVal cor_code As String)
        MyBase.New()
        Me.InitializeComponent()
        CorPosition = CorIndex
        Me.ProjectCode = project_code
        Me.CorporationName = cor_name
        Me.phrase = phrase
        Me.CorporationCode = cor_code
    End Sub
    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsCorporation Is Nothing Then
            dsCorporation.Dispose()
        End If
        If Not dsProCor Is Nothing Then
            dsProCor.Dispose()
        End If

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
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents grpProjectHeader As System.Windows.Forms.GroupBox
    Friend WithEvents lblPhase As System.Windows.Forms.TextBox
    Friend WithEvents lblCorpName As System.Windows.Forms.TextBox
    Friend WithEvents lblProjCode As System.Windows.Forms.TextBox
    Friend WithEvents lblProjectPhase As System.Windows.Forms.Label
    Friend WithEvents lblCorporationName As System.Windows.Forms.Label
    Friend WithEvents lblProjectCode As System.Windows.Forms.Label
    Public WithEvents tcCoMBase As System.Windows.Forms.TabControl
    Public WithEvents pgCorpInfo As System.Windows.Forms.TabPage
    Public WithEvents grpCorp As System.Windows.Forms.GroupBox
    Friend WithEvents clbTechType As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblCorpTechType As System.Windows.Forms.Label
    Friend WithEvents cbxProprietorShip As System.Windows.Forms.ComboBox
    Public WithEvents lblCorpPropriateShip As System.Windows.Forms.Label
    Friend WithEvents cbxIndustryType As System.Windows.Forms.ComboBox
    Friend WithEvents lblCorpIndustryType As System.Windows.Forms.Label
    Friend WithEvents cbxAddressRange As System.Windows.Forms.ComboBox
    Friend WithEvents txtAddressDetail As System.Windows.Forms.TextBox
    Friend WithEvents lblCorpRegisterAddress As System.Windows.Forms.Label
    Friend WithEvents txtLoanCardID As System.Windows.Forms.TextBox
    Friend WithEvents lblCorpCardID As System.Windows.Forms.Label
    Friend WithEvents txtRepID As System.Windows.Forms.TextBox
    Friend WithEvents lblCorpRepreCardID As System.Windows.Forms.Label
    Friend WithEvents txtLoanID As System.Windows.Forms.TextBox
    Friend WithEvents lblCorpPaperID As System.Windows.Forms.Label
    Friend WithEvents txtCorpID As System.Windows.Forms.TextBox
    Friend WithEvents lblCorpBusinessCode As System.Windows.Forms.Label
    Friend WithEvents lblCorpUnit5 As System.Windows.Forms.Label
    Friend WithEvents lblCorpUnit4 As System.Windows.Forms.Label
    Friend WithEvents lblCorpUnit3 As System.Windows.Forms.Label
    Friend WithEvents lblCorpUnit2 As System.Windows.Forms.Label
    Friend WithEvents lblCorpUnit1 As System.Windows.Forms.Label
    Friend WithEvents txtRepreID As System.Windows.Forms.TextBox
    Friend WithEvents txtCashReceive As System.Windows.Forms.TextBox
    Friend WithEvents txtRepreNation As System.Windows.Forms.TextBox
    Friend WithEvents txtInvisibleAssets As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalCapital As System.Windows.Forms.TextBox
    Friend WithEvents txtRepresentative As System.Windows.Forms.TextBox
    Friend WithEvents txtRealCapital As System.Windows.Forms.TextBox
    Friend WithEvents txtRegCapital As System.Windows.Forms.TextBox
    Friend WithEvents txtCreditLevel As System.Windows.Forms.TextBox
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblCorpInvisibleAsset As System.Windows.Forms.Label
    Friend WithEvents lblCorpRepre As System.Windows.Forms.Label
    Friend WithEvents lblCorpRepreID As System.Windows.Forms.Label
    Friend WithEvents lblCorpRepreNation As System.Windows.Forms.Label
    Friend WithEvents lblCorpCreditLevel As System.Windows.Forms.Label
    Friend WithEvents lblCorpRealAsset As System.Windows.Forms.Label
    Friend WithEvents lblCorpCashArrived As System.Windows.Forms.Label
    Friend WithEvents lblCorpBusinessStartDate As System.Windows.Forms.Label
    Friend WithEvents lblCorpTotalAsset As System.Windows.Forms.Label
    Friend WithEvents lblCorpRegisterAsset As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxRelation As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtNewCorName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents btnFinance As System.Windows.Forms.Button
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents btnAnalysis As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCorAssure))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.grpProjectHeader = New System.Windows.Forms.GroupBox()
        Me.lblPhase = New System.Windows.Forms.TextBox()
        Me.lblProjCode = New System.Windows.Forms.TextBox()
        Me.lblProjectPhase = New System.Windows.Forms.Label()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.lblProjectCode = New System.Windows.Forms.Label()
        Me.lblCorpName = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.tcCoMBase = New System.Windows.Forms.TabControl()
        Me.pgCorpInfo = New System.Windows.Forms.TabPage()
        Me.grpCorp = New System.Windows.Forms.GroupBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtNewCorName = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbxRelation = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clbTechType = New System.Windows.Forms.CheckedListBox()
        Me.lblCorpTechType = New System.Windows.Forms.Label()
        Me.cbxProprietorShip = New System.Windows.Forms.ComboBox()
        Me.lblCorpPropriateShip = New System.Windows.Forms.Label()
        Me.cbxIndustryType = New System.Windows.Forms.ComboBox()
        Me.lblCorpIndustryType = New System.Windows.Forms.Label()
        Me.cbxAddressRange = New System.Windows.Forms.ComboBox()
        Me.txtAddressDetail = New System.Windows.Forms.TextBox()
        Me.lblCorpRegisterAddress = New System.Windows.Forms.Label()
        Me.txtLoanCardID = New System.Windows.Forms.TextBox()
        Me.lblCorpCardID = New System.Windows.Forms.Label()
        Me.txtRepID = New System.Windows.Forms.TextBox()
        Me.lblCorpRepreCardID = New System.Windows.Forms.Label()
        Me.txtLoanID = New System.Windows.Forms.TextBox()
        Me.lblCorpPaperID = New System.Windows.Forms.Label()
        Me.txtCorpID = New System.Windows.Forms.TextBox()
        Me.lblCorpBusinessCode = New System.Windows.Forms.Label()
        Me.lblCorpUnit5 = New System.Windows.Forms.Label()
        Me.lblCorpUnit4 = New System.Windows.Forms.Label()
        Me.lblCorpUnit3 = New System.Windows.Forms.Label()
        Me.lblCorpUnit2 = New System.Windows.Forms.Label()
        Me.lblCorpUnit1 = New System.Windows.Forms.Label()
        Me.txtRepreID = New System.Windows.Forms.TextBox()
        Me.txtCashReceive = New System.Windows.Forms.TextBox()
        Me.txtRepreNation = New System.Windows.Forms.TextBox()
        Me.txtInvisibleAssets = New System.Windows.Forms.TextBox()
        Me.txtTotalCapital = New System.Windows.Forms.TextBox()
        Me.txtRepresentative = New System.Windows.Forms.TextBox()
        Me.txtRealCapital = New System.Windows.Forms.TextBox()
        Me.txtRegCapital = New System.Windows.Forms.TextBox()
        Me.txtCreditLevel = New System.Windows.Forms.TextBox()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.lblCorpInvisibleAsset = New System.Windows.Forms.Label()
        Me.lblCorpRepre = New System.Windows.Forms.Label()
        Me.lblCorpRepreID = New System.Windows.Forms.Label()
        Me.lblCorpRepreNation = New System.Windows.Forms.Label()
        Me.lblCorpCreditLevel = New System.Windows.Forms.Label()
        Me.lblCorpRealAsset = New System.Windows.Forms.Label()
        Me.lblCorpCashArrived = New System.Windows.Forms.Label()
        Me.lblCorpBusinessStartDate = New System.Windows.Forms.Label()
        Me.lblCorpTotalAsset = New System.Windows.Forms.Label()
        Me.lblCorpRegisterAsset = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnFinance = New System.Windows.Forms.Button()
        Me.btnAnalysis = New System.Windows.Forms.Button()
        Me.grpProjectHeader.SuspendLayout()
        Me.tcCoMBase.SuspendLayout()
        Me.pgCorpInfo.SuspendLayout()
        Me.grpCorp.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 0
        Me.btnSave.ImageList = Me.ImageList1
        Me.btnSave.Location = New System.Drawing.Point(561, 480)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "保存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'grpProjectHeader
        '
        Me.grpProjectHeader.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grpProjectHeader.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblPhase, Me.lblProjCode, Me.lblProjectPhase, Me.lblCorporationName, Me.lblProjectCode, Me.lblCorpName, Me.TextBox1, Me.TextBox2})
        Me.grpProjectHeader.Location = New System.Drawing.Point(8, 8)
        Me.grpProjectHeader.Name = "grpProjectHeader"
        Me.grpProjectHeader.Size = New System.Drawing.Size(776, 48)
        Me.grpProjectHeader.TabIndex = 109
        Me.grpProjectHeader.TabStop = False
        Me.grpProjectHeader.Text = "项目信息"
        '
        'lblPhase
        '
        Me.lblPhase.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblPhase.BackColor = System.Drawing.SystemColors.Window
        Me.lblPhase.Enabled = False
        Me.lblPhase.Location = New System.Drawing.Point(624, 16)
        Me.lblPhase.Name = "lblPhase"
        Me.lblPhase.ReadOnly = True
        Me.lblPhase.Size = New System.Drawing.Size(72, 21)
        Me.lblPhase.TabIndex = 0
        Me.lblPhase.Text = ""
        '
        'lblProjCode
        '
        Me.lblProjCode.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblProjCode.Enabled = False
        Me.lblProjCode.Location = New System.Drawing.Point(64, 16)
        Me.lblProjCode.Name = "lblProjCode"
        Me.lblProjCode.ReadOnly = True
        Me.lblProjCode.Size = New System.Drawing.Size(72, 21)
        Me.lblProjCode.TabIndex = 0
        Me.lblProjCode.Text = ""
        '
        'lblProjectPhase
        '
        Me.lblProjectPhase.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblProjectPhase.AutoSize = True
        Me.lblProjectPhase.Location = New System.Drawing.Point(568, 19)
        Me.lblProjectPhase.Name = "lblProjectPhase"
        Me.lblProjectPhase.Size = New System.Drawing.Size(54, 14)
        Me.lblProjectPhase.TabIndex = 39
        Me.lblProjectPhase.Text = "项目阶段"
        Me.lblProjectPhase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorporationName
        '
        Me.lblCorporationName.AutoSize = True
        Me.lblCorporationName.Location = New System.Drawing.Point(144, 19)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(54, 14)
        Me.lblCorporationName.TabIndex = 38
        Me.lblCorporationName.Text = "企业名称"
        Me.lblCorporationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjectCode
        '
        Me.lblProjectCode.AutoSize = True
        Me.lblProjectCode.Location = New System.Drawing.Point(8, 19)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(54, 14)
        Me.lblProjectCode.TabIndex = 27
        Me.lblProjectCode.Text = "项目编码"
        Me.lblProjectCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpName
        '
        Me.lblCorpName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.lblCorpName.Enabled = False
        Me.lblCorpName.Location = New System.Drawing.Point(208, 16)
        Me.lblCorpName.Name = "lblCorpName"
        Me.lblCorpName.ReadOnly = True
        Me.lblCorpName.Size = New System.Drawing.Size(240, 21)
        Me.lblCorpName.TabIndex = 0
        Me.lblCorpName.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox1.Location = New System.Drawing.Point(208, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(240, 21)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Window
        Me.TextBox2.Location = New System.Drawing.Point(64, 16)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(72, 21)
        Me.TextBox2.TabIndex = 0
        Me.TextBox2.Text = ""
        '
        'tcCoMBase
        '
        Me.tcCoMBase.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.tcCoMBase.Controls.AddRange(New System.Windows.Forms.Control() {Me.pgCorpInfo})
        Me.tcCoMBase.Location = New System.Drawing.Point(8, 64)
        Me.tcCoMBase.Name = "tcCoMBase"
        Me.tcCoMBase.SelectedIndex = 0
        Me.tcCoMBase.Size = New System.Drawing.Size(770, 408)
        Me.tcCoMBase.TabIndex = 110
        '
        'pgCorpInfo
        '
        Me.pgCorpInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpCorp})
        Me.pgCorpInfo.Location = New System.Drawing.Point(4, 21)
        Me.pgCorpInfo.Name = "pgCorpInfo"
        Me.pgCorpInfo.Size = New System.Drawing.Size(762, 383)
        Me.pgCorpInfo.TabIndex = 0
        Me.pgCorpInfo.Text = "企业信息"
        Me.pgCorpInfo.Visible = False
        '
        'grpCorp
        '
        Me.grpCorp.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grpCorp.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtPhone, Me.Label24, Me.txtNewCorName, Me.Label8, Me.cbxRelation, Me.Label1, Me.clbTechType, Me.lblCorpTechType, Me.cbxProprietorShip, Me.lblCorpPropriateShip, Me.cbxIndustryType, Me.lblCorpIndustryType, Me.cbxAddressRange, Me.txtAddressDetail, Me.lblCorpRegisterAddress, Me.txtLoanCardID, Me.lblCorpCardID, Me.txtRepID, Me.lblCorpRepreCardID, Me.txtLoanID, Me.lblCorpPaperID, Me.txtCorpID, Me.lblCorpBusinessCode, Me.lblCorpUnit5, Me.lblCorpUnit4, Me.lblCorpUnit3, Me.lblCorpUnit2, Me.lblCorpUnit1, Me.txtRepreID, Me.txtCashReceive, Me.txtRepreNation, Me.txtInvisibleAssets, Me.txtTotalCapital, Me.txtRepresentative, Me.txtRealCapital, Me.txtRegCapital, Me.txtCreditLevel, Me.dtpEndDate, Me.dtpStartDate, Me.lblCorpInvisibleAsset, Me.lblCorpRepre, Me.lblCorpRepreID, Me.lblCorpRepreNation, Me.lblCorpCreditLevel, Me.lblCorpRealAsset, Me.lblCorpCashArrived, Me.lblCorpBusinessStartDate, Me.lblCorpTotalAsset, Me.lblCorpRegisterAsset, Me.Label9})
        Me.grpCorp.Name = "grpCorp"
        Me.grpCorp.Size = New System.Drawing.Size(762, 383)
        Me.grpCorp.TabIndex = 250
        Me.grpCorp.TabStop = False
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(368, 317)
        Me.txtPhone.MaxLength = 20
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(112, 21)
        Me.txtPhone.TabIndex = 20
        Me.txtPhone.Text = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(264, 320)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(91, 14)
        Me.Label24.TabIndex = 305
        Me.Label24.Text = "联  系  电  话"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtNewCorName
        '
        Me.txtNewCorName.Location = New System.Drawing.Point(120, 24)
        Me.txtNewCorName.MaxLength = 30
        Me.txtNewCorName.Name = "txtNewCorName"
        Me.txtNewCorName.Size = New System.Drawing.Size(360, 21)
        Me.txtNewCorName.TabIndex = 1
        Me.txtNewCorName.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(16, 27)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 14)
        Me.Label8.TabIndex = 304
        Me.Label8.Text = "保证企业名称"
        '
        'cbxRelation
        '
        Me.cbxRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxRelation.Location = New System.Drawing.Point(608, 24)
        Me.cbxRelation.Name = "cbxRelation"
        Me.cbxRelation.Size = New System.Drawing.Size(128, 20)
        Me.cbxRelation.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(504, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 14)
        Me.Label1.TabIndex = 302
        Me.Label1.Text = "与担保企业关系"
        '
        'clbTechType
        '
        Me.clbTechType.CheckOnClick = True
        Me.clbTechType.Location = New System.Drawing.Point(120, 197)
        Me.clbTechType.MultiColumn = True
        Me.clbTechType.Name = "clbTechType"
        Me.clbTechType.Size = New System.Drawing.Size(616, 36)
        Me.clbTechType.TabIndex = 13
        Me.clbTechType.Tag = "true"
        '
        'lblCorpTechType
        '
        Me.lblCorpTechType.AutoSize = True
        Me.lblCorpTechType.Location = New System.Drawing.Point(16, 207)
        Me.lblCorpTechType.Name = "lblCorpTechType"
        Me.lblCorpTechType.Size = New System.Drawing.Size(97, 14)
        Me.lblCorpTechType.TabIndex = 301
        Me.lblCorpTechType.Text = "企 业 技 术类型"
        Me.lblCorpTechType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxProprietorShip
        '
        Me.cbxProprietorShip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProprietorShip.ItemHeight = 12
        Me.cbxProprietorShip.Location = New System.Drawing.Point(120, 163)
        Me.cbxProprietorShip.Name = "cbxProprietorShip"
        Me.cbxProprietorShip.Size = New System.Drawing.Size(160, 20)
        Me.cbxProprietorShip.TabIndex = 11
        '
        'lblCorpPropriateShip
        '
        Me.lblCorpPropriateShip.AutoSize = True
        Me.lblCorpPropriateShip.Location = New System.Drawing.Point(16, 166)
        Me.lblCorpPropriateShip.Name = "lblCorpPropriateShip"
        Me.lblCorpPropriateShip.Size = New System.Drawing.Size(91, 14)
        Me.lblCorpPropriateShip.TabIndex = 299
        Me.lblCorpPropriateShip.Text = "所 有 制 类 型"
        Me.lblCorpPropriateShip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxIndustryType
        '
        Me.cbxIndustryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxIndustryType.ItemHeight = 12
        Me.cbxIndustryType.Location = New System.Drawing.Point(368, 163)
        Me.cbxIndustryType.Name = "cbxIndustryType"
        Me.cbxIndustryType.Size = New System.Drawing.Size(368, 20)
        Me.cbxIndustryType.TabIndex = 12
        '
        'lblCorpIndustryType
        '
        Me.lblCorpIndustryType.Location = New System.Drawing.Point(296, 166)
        Me.lblCorpIndustryType.Name = "lblCorpIndustryType"
        Me.lblCorpIndustryType.Size = New System.Drawing.Size(54, 14)
        Me.lblCorpIndustryType.TabIndex = 298
        Me.lblCorpIndustryType.Text = "行业类型"
        Me.lblCorpIndustryType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxAddressRange
        '
        Me.cbxAddressRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddressRange.ItemHeight = 12
        Me.cbxAddressRange.Location = New System.Drawing.Point(120, 129)
        Me.cbxAddressRange.Name = "cbxAddressRange"
        Me.cbxAddressRange.Size = New System.Drawing.Size(104, 20)
        Me.cbxAddressRange.TabIndex = 9
        '
        'txtAddressDetail
        '
        Me.txtAddressDetail.Location = New System.Drawing.Point(232, 129)
        Me.txtAddressDetail.MaxLength = 50
        Me.txtAddressDetail.Name = "txtAddressDetail"
        Me.txtAddressDetail.Size = New System.Drawing.Size(504, 21)
        Me.txtAddressDetail.TabIndex = 10
        Me.txtAddressDetail.Text = ""
        '
        'lblCorpRegisterAddress
        '
        Me.lblCorpRegisterAddress.AutoSize = True
        Me.lblCorpRegisterAddress.Location = New System.Drawing.Point(16, 132)
        Me.lblCorpRegisterAddress.Name = "lblCorpRegisterAddress"
        Me.lblCorpRegisterAddress.Size = New System.Drawing.Size(91, 14)
        Me.lblCorpRegisterAddress.TabIndex = 295
        Me.lblCorpRegisterAddress.Text = "注  册  地  址"
        Me.lblCorpRegisterAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLoanCardID
        '
        Me.txtLoanCardID.Location = New System.Drawing.Point(608, 94)
        Me.txtLoanCardID.MaxLength = 20
        Me.txtLoanCardID.Name = "txtLoanCardID"
        Me.txtLoanCardID.Size = New System.Drawing.Size(128, 21)
        Me.txtLoanCardID.TabIndex = 8
        Me.txtLoanCardID.Text = ""
        '
        'lblCorpCardID
        '
        Me.lblCorpCardID.AutoSize = True
        Me.lblCorpCardID.Location = New System.Drawing.Point(504, 97)
        Me.lblCorpCardID.Name = "lblCorpCardID"
        Me.lblCorpCardID.Size = New System.Drawing.Size(91, 14)
        Me.lblCorpCardID.TabIndex = 292
        Me.lblCorpCardID.Text = "贷 款 卡 号 码"
        Me.lblCorpCardID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRepID
        '
        Me.txtRepID.Location = New System.Drawing.Point(120, 94)
        Me.txtRepID.MaxLength = 10
        Me.txtRepID.Name = "txtRepID"
        Me.txtRepID.Size = New System.Drawing.Size(104, 21)
        Me.txtRepID.TabIndex = 6
        Me.txtRepID.Text = ""
        '
        'lblCorpRepreCardID
        '
        Me.lblCorpRepreCardID.AutoSize = True
        Me.lblCorpRepreCardID.Location = New System.Drawing.Point(16, 97)
        Me.lblCorpRepreCardID.Name = "lblCorpRepreCardID"
        Me.lblCorpRepreCardID.Size = New System.Drawing.Size(91, 14)
        Me.lblCorpRepreCardID.TabIndex = 290
        Me.lblCorpRepreCardID.Text = "法人代码证号码"
        Me.lblCorpRepreCardID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLoanID
        '
        Me.txtLoanID.Location = New System.Drawing.Point(368, 94)
        Me.txtLoanID.MaxLength = 10
        Me.txtLoanID.Name = "txtLoanID"
        Me.txtLoanID.Size = New System.Drawing.Size(112, 21)
        Me.txtLoanID.TabIndex = 7
        Me.txtLoanID.Text = ""
        '
        'lblCorpPaperID
        '
        Me.lblCorpPaperID.AutoSize = True
        Me.lblCorpPaperID.Location = New System.Drawing.Point(264, 97)
        Me.lblCorpPaperID.Name = "lblCorpPaperID"
        Me.lblCorpPaperID.Size = New System.Drawing.Size(91, 14)
        Me.lblCorpPaperID.TabIndex = 288
        Me.lblCorpPaperID.Text = "贷 款 证 号 码"
        Me.lblCorpPaperID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorpID
        '
        Me.txtCorpID.Location = New System.Drawing.Point(120, 59)
        Me.txtCorpID.MaxLength = 15
        Me.txtCorpID.Name = "txtCorpID"
        Me.txtCorpID.Size = New System.Drawing.Size(104, 21)
        Me.txtCorpID.TabIndex = 3
        Me.txtCorpID.Text = ""
        '
        'lblCorpBusinessCode
        '
        Me.lblCorpBusinessCode.AutoSize = True
        Me.lblCorpBusinessCode.Location = New System.Drawing.Point(16, 62)
        Me.lblCorpBusinessCode.Name = "lblCorpBusinessCode"
        Me.lblCorpBusinessCode.Size = New System.Drawing.Size(85, 14)
        Me.lblCorpBusinessCode.TabIndex = 286
        Me.lblCorpBusinessCode.Text = "营业执照号 码"
        Me.lblCorpBusinessCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpUnit5
        '
        Me.lblCorpUnit5.AutoSize = True
        Me.lblCorpUnit5.Location = New System.Drawing.Point(704, 285)
        Me.lblCorpUnit5.Name = "lblCorpUnit5"
        Me.lblCorpUnit5.Size = New System.Drawing.Size(29, 14)
        Me.lblCorpUnit5.TabIndex = 263
        Me.lblCorpUnit5.Text = "万元"
        Me.lblCorpUnit5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpUnit4
        '
        Me.lblCorpUnit4.AutoSize = True
        Me.lblCorpUnit4.Location = New System.Drawing.Point(180, 320)
        Me.lblCorpUnit4.Name = "lblCorpUnit4"
        Me.lblCorpUnit4.Size = New System.Drawing.Size(29, 14)
        Me.lblCorpUnit4.TabIndex = 262
        Me.lblCorpUnit4.Text = "万元"
        Me.lblCorpUnit4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpUnit3
        '
        Me.lblCorpUnit3.AutoSize = True
        Me.lblCorpUnit3.Location = New System.Drawing.Point(528, 285)
        Me.lblCorpUnit3.Name = "lblCorpUnit3"
        Me.lblCorpUnit3.Size = New System.Drawing.Size(29, 14)
        Me.lblCorpUnit3.TabIndex = 261
        Me.lblCorpUnit3.Text = "万元"
        Me.lblCorpUnit3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpUnit2
        '
        Me.lblCorpUnit2.AutoSize = True
        Me.lblCorpUnit2.Location = New System.Drawing.Point(336, 285)
        Me.lblCorpUnit2.Name = "lblCorpUnit2"
        Me.lblCorpUnit2.Size = New System.Drawing.Size(29, 14)
        Me.lblCorpUnit2.TabIndex = 260
        Me.lblCorpUnit2.Text = "万元"
        Me.lblCorpUnit2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpUnit1
        '
        Me.lblCorpUnit1.AutoSize = True
        Me.lblCorpUnit1.Location = New System.Drawing.Point(180, 285)
        Me.lblCorpUnit1.Name = "lblCorpUnit1"
        Me.lblCorpUnit1.Size = New System.Drawing.Size(29, 14)
        Me.lblCorpUnit1.TabIndex = 259
        Me.lblCorpUnit1.Text = "万元"
        Me.lblCorpUnit1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRepreID
        '
        Me.txtRepreID.Location = New System.Drawing.Point(624, 352)
        Me.txtRepreID.MaxLength = 20
        Me.txtRepreID.Name = "txtRepreID"
        Me.txtRepreID.Size = New System.Drawing.Size(112, 21)
        Me.txtRepreID.TabIndex = 23
        Me.txtRepreID.Text = ""
        '
        'txtCashReceive
        '
        Me.txtCashReceive.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtCashReceive.Location = New System.Drawing.Point(472, 282)
        Me.txtCashReceive.MaxLength = 8
        Me.txtCashReceive.Name = "txtCashReceive"
        Me.txtCashReceive.Size = New System.Drawing.Size(56, 21)
        Me.txtCashReceive.TabIndex = 17
        Me.txtCashReceive.Text = ""
        Me.txtCashReceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRepreNation
        '
        Me.txtRepreNation.Location = New System.Drawing.Point(368, 352)
        Me.txtRepreNation.MaxLength = 10
        Me.txtRepreNation.Name = "txtRepreNation"
        Me.txtRepreNation.Size = New System.Drawing.Size(112, 21)
        Me.txtRepreNation.TabIndex = 22
        Me.txtRepreNation.Text = "中国"
        '
        'txtInvisibleAssets
        '
        Me.txtInvisibleAssets.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtInvisibleAssets.Location = New System.Drawing.Point(648, 282)
        Me.txtInvisibleAssets.MaxLength = 8
        Me.txtInvisibleAssets.Name = "txtInvisibleAssets"
        Me.txtInvisibleAssets.Size = New System.Drawing.Size(56, 21)
        Me.txtInvisibleAssets.TabIndex = 18
        Me.txtInvisibleAssets.Text = ""
        Me.txtInvisibleAssets.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtTotalCapital
        '
        Me.txtTotalCapital.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtTotalCapital.Location = New System.Drawing.Point(120, 317)
        Me.txtTotalCapital.MaxLength = 8
        Me.txtTotalCapital.Name = "txtTotalCapital"
        Me.txtTotalCapital.Size = New System.Drawing.Size(56, 21)
        Me.txtTotalCapital.TabIndex = 19
        Me.txtTotalCapital.Text = ""
        Me.txtTotalCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRepresentative
        '
        Me.txtRepresentative.Location = New System.Drawing.Point(120, 352)
        Me.txtRepresentative.MaxLength = 10
        Me.txtRepresentative.Name = "txtRepresentative"
        Me.txtRepresentative.TabIndex = 21
        Me.txtRepresentative.Text = ""
        '
        'txtRealCapital
        '
        Me.txtRealCapital.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtRealCapital.Location = New System.Drawing.Point(280, 282)
        Me.txtRealCapital.MaxLength = 8
        Me.txtRealCapital.Name = "txtRealCapital"
        Me.txtRealCapital.Size = New System.Drawing.Size(56, 21)
        Me.txtRealCapital.TabIndex = 16
        Me.txtRealCapital.Text = ""
        Me.txtRealCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRegCapital
        '
        Me.txtRegCapital.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtRegCapital.Location = New System.Drawing.Point(120, 282)
        Me.txtRegCapital.MaxLength = 8
        Me.txtRegCapital.Name = "txtRegCapital"
        Me.txtRegCapital.Size = New System.Drawing.Size(56, 21)
        Me.txtRegCapital.TabIndex = 15
        Me.txtRegCapital.Text = ""
        Me.txtRegCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCreditLevel
        '
        Me.txtCreditLevel.Location = New System.Drawing.Point(120, 247)
        Me.txtCreditLevel.MaxLength = 10
        Me.txtCreditLevel.Name = "txtCreditLevel"
        Me.txtCreditLevel.TabIndex = 14
        Me.txtCreditLevel.Text = ""
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpEndDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpEndDate.Location = New System.Drawing.Point(608, 59)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(128, 21)
        Me.dtpEndDate.TabIndex = 5
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpStartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpStartDate.Location = New System.Drawing.Point(368, 59)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpStartDate.TabIndex = 4
        '
        'lblCorpInvisibleAsset
        '
        Me.lblCorpInvisibleAsset.AutoSize = True
        Me.lblCorpInvisibleAsset.Location = New System.Drawing.Point(584, 285)
        Me.lblCorpInvisibleAsset.Name = "lblCorpInvisibleAsset"
        Me.lblCorpInvisibleAsset.Size = New System.Drawing.Size(54, 14)
        Me.lblCorpInvisibleAsset.TabIndex = 225
        Me.lblCorpInvisibleAsset.Text = "无形资产"
        Me.lblCorpInvisibleAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpRepre
        '
        Me.lblCorpRepre.AutoSize = True
        Me.lblCorpRepre.Location = New System.Drawing.Point(16, 355)
        Me.lblCorpRepre.Name = "lblCorpRepre"
        Me.lblCorpRepre.Size = New System.Drawing.Size(91, 14)
        Me.lblCorpRepre.TabIndex = 224
        Me.lblCorpRepre.Text = "法 定 代 表 人"
        Me.lblCorpRepre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpRepreID
        '
        Me.lblCorpRepreID.AutoSize = True
        Me.lblCorpRepreID.Location = New System.Drawing.Point(512, 355)
        Me.lblCorpRepreID.Name = "lblCorpRepreID"
        Me.lblCorpRepreID.Size = New System.Drawing.Size(116, 14)
        Me.lblCorpRepreID.TabIndex = 223
        Me.lblCorpRepreID.Text = "法定代表人身份证号"
        Me.lblCorpRepreID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpRepreNation
        '
        Me.lblCorpRepreNation.AutoSize = True
        Me.lblCorpRepreNation.Location = New System.Drawing.Point(264, 355)
        Me.lblCorpRepreNation.Name = "lblCorpRepreNation"
        Me.lblCorpRepreNation.Size = New System.Drawing.Size(91, 14)
        Me.lblCorpRepreNation.TabIndex = 222
        Me.lblCorpRepreNation.Text = "法定代表人国籍"
        Me.lblCorpRepreNation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpCreditLevel
        '
        Me.lblCorpCreditLevel.AutoSize = True
        Me.lblCorpCreditLevel.Location = New System.Drawing.Point(16, 250)
        Me.lblCorpCreditLevel.Name = "lblCorpCreditLevel"
        Me.lblCorpCreditLevel.Size = New System.Drawing.Size(91, 14)
        Me.lblCorpCreditLevel.TabIndex = 221
        Me.lblCorpCreditLevel.Text = "资  信  等  级"
        Me.lblCorpCreditLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpRealAsset
        '
        Me.lblCorpRealAsset.AutoSize = True
        Me.lblCorpRealAsset.Location = New System.Drawing.Point(224, 285)
        Me.lblCorpRealAsset.Name = "lblCorpRealAsset"
        Me.lblCorpRealAsset.Size = New System.Drawing.Size(54, 14)
        Me.lblCorpRealAsset.TabIndex = 215
        Me.lblCorpRealAsset.Text = "实收资本"
        Me.lblCorpRealAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpCashArrived
        '
        Me.lblCorpCashArrived.AutoSize = True
        Me.lblCorpCashArrived.Location = New System.Drawing.Point(392, 285)
        Me.lblCorpCashArrived.Name = "lblCorpCashArrived"
        Me.lblCorpCashArrived.Size = New System.Drawing.Size(79, 14)
        Me.lblCorpCashArrived.TabIndex = 214
        Me.lblCorpCashArrived.Text = "其中现金到位"
        Me.lblCorpCashArrived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpBusinessStartDate
        '
        Me.lblCorpBusinessStartDate.AutoSize = True
        Me.lblCorpBusinessStartDate.Location = New System.Drawing.Point(264, 62)
        Me.lblCorpBusinessStartDate.Name = "lblCorpBusinessStartDate"
        Me.lblCorpBusinessStartDate.Size = New System.Drawing.Size(91, 14)
        Me.lblCorpBusinessStartDate.TabIndex = 213
        Me.lblCorpBusinessStartDate.Text = "经营期限起始日"
        Me.lblCorpBusinessStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpTotalAsset
        '
        Me.lblCorpTotalAsset.AutoSize = True
        Me.lblCorpTotalAsset.Location = New System.Drawing.Point(16, 320)
        Me.lblCorpTotalAsset.Name = "lblCorpTotalAsset"
        Me.lblCorpTotalAsset.Size = New System.Drawing.Size(79, 14)
        Me.lblCorpTotalAsset.TabIndex = 210
        Me.lblCorpTotalAsset.Text = "总   股   本"
        Me.lblCorpTotalAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpRegisterAsset
        '
        Me.lblCorpRegisterAsset.AutoSize = True
        Me.lblCorpRegisterAsset.Location = New System.Drawing.Point(16, 285)
        Me.lblCorpRegisterAsset.Name = "lblCorpRegisterAsset"
        Me.lblCorpRegisterAsset.Size = New System.Drawing.Size(91, 14)
        Me.lblCorpRegisterAsset.TabIndex = 209
        Me.lblCorpRegisterAsset.Text = "注  册  资  本"
        Me.lblCorpRegisterAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(504, 62)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 14)
        Me.Label9.TabIndex = 212
        Me.Label9.Text = "经营期限截止日"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 1
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(648, 480)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "退出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFinance
        '
        Me.btnFinance.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnFinance.Image = CType(resources.GetObject("btnFinance.Image"), System.Drawing.Bitmap)
        Me.btnFinance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFinance.ImageIndex = 2
        Me.btnFinance.ImageList = Me.ImageList1
        Me.btnFinance.Location = New System.Drawing.Point(328, 480)
        Me.btnFinance.Name = "btnFinance"
        Me.btnFinance.Size = New System.Drawing.Size(120, 23)
        Me.btnFinance.TabIndex = 24
        Me.btnFinance.Text = "录入财务数据(&F)"
        Me.btnFinance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAnalysis
        '
        Me.btnAnalysis.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnAnalysis.Image = CType(resources.GetObject("btnAnalysis.Image"), System.Drawing.Bitmap)
        Me.btnAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAnalysis.ImageIndex = 3
        Me.btnAnalysis.ImageList = Me.ImageList1
        Me.btnAnalysis.Location = New System.Drawing.Point(458, 480)
        Me.btnAnalysis.Name = "btnAnalysis"
        Me.btnAnalysis.Size = New System.Drawing.Size(93, 23)
        Me.btnAnalysis.TabIndex = 111
        Me.btnAnalysis.Text = "财务分析(&A)"
        Me.btnAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCorAssure
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(794, 511)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnAnalysis, Me.btnFinance, Me.tcCoMBase, Me.grpProjectHeader, Me.btnSave, Me.btnExit})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmCorAssure"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "保证企业信息"
        Me.grpProjectHeader.ResumeLayout(False)
        Me.tcCoMBase.ResumeLayout(False)
        Me.pgCorpInfo.ResumeLayout(False)
        Me.grpCorp.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    '''''''''''''''''''''''''''''企业信息   BEGIN''''''''''''''''''''''''''''''' ConInfo
    Private CorTechType As Integer = 0 '企业技术类型

    Private Sub IniBindingForConInfo()
        ''''''''绑定项目信息的某一部分 表:project_corporation
        dtpStartDate.DataBindings.Add("Text", dsProCor, "TProjectCorporation.business_start_date")
        dtpEndDate.DataBindings.Add("Text", dsProCor, "TProjectCorporation.business_end_date")

        txtNewCorName.DataBindings.Add("Text", dsProCor, "TProjectCorporation.corporation_name")
        txtCreditLevel.DataBindings.Add("Text", dsProCor, "TProjectCorporation.credit_grade")
        'txtEvalInstitute.DataBindings.Add("Text", dsProCor, "TProjectCorporation.evaluate_institution")

        cbxAddressRange.DataBindings.Add("SelectedValue", dsProCor, "TProjectCorporation.district_name")
        txtAddressDetail.DataBindings.Add("Text", dsProCor, "TProjectCorporation.register_address")
        cbxIndustryType.DataBindings.Add("SelectedValue", dsProCor, "TProjectCorporation.industry_type")
        cbxProprietorShip.DataBindings.Add("SelectedValue", dsProCor, "TProjectCorporation.proprietorship_type")
        cbxRelation.DataBindings.Add("SelectedValue", dsProCor, "TProjectCorporation.relation")

        txtRegCapital.DataBindings.Add("Text", dsProCor, "TProjectCorporation.register_capital")
        txtTotalCapital.DataBindings.Add("Text", dsProCor, "TProjectCorporation.total_capital_stock")
        txtInvisibleAssets.DataBindings.Add("Text", dsProCor, "TProjectCorporation.invisible_assets")

        txtRealCapital.DataBindings.Add("Text", dsProCor, "TProjectCorporation.real_capital")
        txtCashReceive.DataBindings.Add("Text", dsProCor, "TProjectCorporation.cash_receive")

        txtRepresentative.DataBindings.Add("Text", dsProCor, "TProjectCorporation.legal_representative")
        txtRepreNation.DataBindings.Add("Text", dsProCor, "TProjectCorporation.nationality")
        txtRepreID.DataBindings.Add("Text", dsProCor, "TProjectCorporation.id_card")
        txtPhone.DataBindings.Add("Text", dsProCor, "TProjectCorporation.contact_phone")
        '
        '执照和代码证
        '
        txtLoanCardID.DataBindings.Add(New Binding("Text", dsProCor, "TProjectCorporation.loan_card_id"))
        txtLoanID.DataBindings.Add(New Binding("Text", dsProCor, "TProjectCorporation.loan_paper_id"))
        txtCorpID.DataBindings.Add(New Binding("Text", dsProCor, "TProjectCorporation.business_licence_code"))
        txtRepID.DataBindings.Add(New Binding("Text", dsProCor, "TProjectCorporation.corp_paper_id"))
    End Sub
    Private IsTechChanged As Boolean = False
    '框框决定CorTechType
    Private Sub clbTechType_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs)
        If clbTechType.Tag.ToString.Trim = "false" Then Return

        Dim val As Integer = CType(CType(clbTechType.Items(e.Index), DataRowView).Item("technology_type_code"), Integer)  '当前选定项的值
        If e.NewValue Then
            CorTechType = (CorTechType Or val)
        Else
            CorTechType = (CorTechType And Not val)
        End If
        IsTechChanged = True
    End Sub

    '根据int_TechTypes的值来确定选定的技术类型
    '选择类型
    'CorTechType决定框框
    Private Sub InitTechType(ByVal sender As Object)
        clbTechType.ClearSelected()
        Dim i As Integer
        Dim choose As Integer
        For i = 0 To clbTechType.Items.Count - 1
            '选择类型
            choose = CType(CType(clbTechType.Items(i), DataRowView).Item("technology_type_code"), Integer)
            '确定选择类型
            If CorTechType And choose Then
                clbTechType.SetItemCheckState(i, CheckState.Checked)
            End If
        Next
    End Sub
    '''''''''''''''''''''''''''''企业信息   END'''''''''''''''''''''''''''''''

    '''''''''''''''''''''''''''''股权结构   BEGIN''''''''''''''''''''''''''''''' StockStru

    '''''''''''''''''''''''''''''股权结构   END'''''''''''''''''''''''''''''''

    '''''''''''''''''''''''''''''对外担保记录  BEGIN''''''''''''''''''''''''''' VouchRec   
    
    '''''''''''''''''''''''''''''对外担保记录  END'''''''''''''''''''''''''''

    '''''''''''''''''''''''''''''借款记录   BEGIN'''''''''''''''''''''''''''''''   LoanRec
    
    '''''''''''''''''''''''''''''借款记录   END'''''''''''''''''''''''''''''''

    '''''''''''''''''''''''''''''其它信息'''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''其它信息'''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''银行存款'''''''''''''''''''''''''''''''  BankMoney
    '''''''''''''''''''''''''''''银行存款''''''''''''''''''''''''''''''''
    ''''''''''''''''''''''''''''''诉讼记录''''''''''''''''''''''''''''''  SuitRec
    ''''''''''''''''''''''''''''''诉讼记录''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''信用记录'''''''''''''''''''''''''''''''  CreditRec
    '''''''''''''''''''''''''''''信用记录'''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''纳税记录'''''''''''''''''''''''''''''''  TaxRec
    '''''''''''''''''''''''''''''纳税记录'''''''''''''''''''''''''''''''
    '''''''''''''''''''''''''''''经营情况'''''''''''''''''''''''''''''''  
    '''''''''''''''''''''''''''''经营情况'''''''''''''''''''''''''''''''


    Private Sub frmCorAssure_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor

            SystemDate = gWs.GetSysTime
            lblProjCode.Text = ProjectCode : lblCorpName.Text = CorporationName : lblPhase.Text = phrase
            InitComboBox()
            If CorPosition < 0 Then  '新增保证企业到数据库表:corporation    project_corporation
                'InitDataSetAndItsBindingManager(String.Empty)
                '项目企业信息
                dsProCor = gWs.FetchProjectCorporation(ProjectCode, "%", "2", phrase)
                '企业信息
                dsCorporation = gWs.GetcorporationInfo("null", "null")

                CorporationCode = gWs.GetCorporationMaxCode_Guarantee()
                '项目企业信息
                Dim drCorPro As DataRow = dsProCor.Tables("TProjectCorporation").NewRow
                With drCorPro
                    .Item("project_code") = ProjectCode
                    .Item("corporation_code") = CorporationCode
                    .Item("phase") = phrase
                    .Item("corporation_type") = "2"
                    .Item("create_person") = UserName
                    .Item("create_date") = SystemDate.Date
                    .Item("nationality") = "中国"
                    .Item("status") = "申请"
                    .Item("attorney_nationality") = "中国"
                    .Item("business_licence_code") = "深司字"
                    .Item("business_start_date") = SystemDate.Date
                    .Item("business_end_date") = SystemDate.Date
                End With
                dsProCor.Tables("TProjectCorporation").Rows.Add(drCorPro)
                'bmProCor.Position = bmProCor.Count - 1
                dtpStartDate.Value = SystemDate.Date : dtpEndDate.Value = SystemDate.Date
                '企业信息
                Dim drCorporation As DataRow = dsCorporation.Tables("corporation").NewRow
                With drCorporation
                    .Item("corporation_code") = CorporationCode
                    .Item("corporation_type") = "2"
                    .Item("create_person") = UserName
                    .Item("create_date") = SystemDate.Date
                End With
                dsCorporation.Tables("corporation").Rows.Add(drCorporation)
                'bmCorporation.Position = bmCorporation.Count - 1
                gWs.UpdateCorporationAndProjectCorporation(dsCorporation.GetChanges, dsProCor.GetChanges)
                'dsCorporation.AcceptChanges() : dsProCor.AcceptChanges()
                strStatus = "new"
                btnFinance.Enabled = False
            End If

            InitDataSetAndItsBindingManager(CorporationCode)
            '不管怎么样,bmCorporation.Position和bmProCor.Position都为0 根据CorporationCode作参数
            bmProCor.Position = 0
            bmCorporation.Position = 0
            If Not dsProCor.Tables("TProjectCorporation").Rows(0).Item("technology_type") Is DBNull.Value Then
                CorTechType = dsProCor.Tables("TProjectCorporation").Rows(0).Item("technology_type")
                InitTechType(sender) '初始化企业技术类型
            End If

            AddHandler tcCoMBase.SelectedIndexChanged, AddressOf tcCoMBase_TabIndexChanged
            AddHandler clbTechType.ItemCheck, AddressOf clbTechType_ItemCheck
            IniBindingForConInfo()
            'IniBindingForLoanRec()
            'IniBindingForStockStru()
            'IniBindingForVouchRec()
            'SerialNumForLoanRec = gWs.GetMaxSerialID("serial_num", "corporation_loan")
            'SerialNumForVouchRec = gWs.GetMaxSerialID("serial_num", "corporation_external_guarantee")
            'SerialNumStockStru = gWs.GetMaxSerialID("serial_num", "corporation_stock_structure")
            'UpdateBtnStatusForLoanRec()   '借款记录
            'UpdateBtnStatusForStockStru()  '股权结构
            'UpdateBtnStatusForVouchRec()   '对外担保记录
            ''''以下这段代码功能：在控件焦点进入时，确保去掉绑定
            'Dim obj As Control
            'For Each obj In grpLoanOper.Controls
            '    If (Not obj.GetType Is GetType(Label)) Or (Not obj.GetType Is GetType(Button)) Then
            '        AddHandler obj.Enter, AddressOf objEnterForLoanRec
            '    End If
            'Next
            'For Each obj In grpExternalOper.Controls
            '    If (Not obj.GetType Is GetType(Label)) Or (Not obj.GetType Is GetType(Button)) Then
            '        AddHandler obj.Enter, AddressOf objVouchRec_Enter
            '    End If
            'Next
            
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Private Sub InitDataSetAndItsBindingManager(ByVal CorCode As String)
        If CorCode = String.Empty Then
            '项目企业信息
            dsProCor = gWs.FetchProjectCorporation(ProjectCode, "%", "2", phrase)
            '企业信息
            dsCorporation = gWs.GetcorporationInfo("null", "null")
            ''股权结构
            'dsStockStru = gWs.FetchCorporationStockStructure(ProjectCode, "null", phrase, -1)
            ''对外担保记录
            'dsVouchRec = gWs.FetchCorporationExternalGuarantee(ProjectCode, "null", phrase, -1)
            ''借款记录
            'dsLoanRec = gWs.FetchCorporationLoan(ProjectCode, "null", phrase, -1)
        Else
            dsProCor = gWs.FetchProjectCorporation(ProjectCode, CorCode, "2", phrase)
            dsCorporation = gWs.GetcorporationInfo("{corporation_code LIKE '" & CorCode & "'}", "null")
            ''股权结构
            'dsStockStru = gWs.FetchCorporationStockStructure(ProjectCode, CorCode, phrase, -1)
            'Dim dr As DataRow
            'Dim totalSum As Double = 0.0
            'For Each dr In dsStockStru.Tables("TCorporationStockStructure").Rows
            '    totalSum += CDbl(dr("invest_sum"))
            'Next
            'txtTotalInvestSum.Text = totalSum.ToString("c", CGFormatInfo)
            ''对外担保记录
            'dsVouchRec = gWs.FetchCorporationExternalGuarantee(ProjectCode, CorCode, phrase, -1)
            ''借款记录
            'dsLoanRec = gWs.FetchCorporationLoan(ProjectCode, CorCode, phrase, -1)
        End If

        bmProCor = BindingContext(dsProCor, "TProjectCorporation")

        '企业信息
        bmCorporation = BindingContext(dsCorporation, "corporation")

        ''股权结构
        'bmStockStru = BindingContext(dsStockStru, "TCorporationStockStructure")
        'dgHolders.DataMember = "TCorporationStockStructure"
        'dgHolders.DataSource = dsStockStru
        'AddTableStyleForStockStru()

        ''对外担保记录
        'bmVouchRec = BindingContext(dsVouchRec, "TCorporationExternalGuarantee")
        'dgVouchRecord.DataMember = "TCorporationExternalGuarantee"
        'dgVouchRecord.DataSource = dsVouchRec
        'AddTableStyleForVouchRec()

        ''借款记录
        'bmLoanRec = BindingContext(dsLoanRec, "TCorporationLoan")
        'dgLoanRecord.DataMember = "TCorporationLoan"
        'dgLoanRecord.DataSource = dsLoanRec
        'AddTableStyleForLoanRec()
    End Sub
    ''''''''''''''''''''''下面为各种文本框的输入限制''''''''''''''''''''''
    'Private Sub txtRepID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRepID.KeyPress
    '    e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    'End Sub

    Private Sub txtLoanID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoanID.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    End Sub

    'Private Sub txtLoanCardID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLoanCardID.KeyPress
    '    e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    'End Sub
    '''法人代表身份证号
    'Private Sub txtRepreID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRepreID.KeyPress
    '    e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    'End Sub
    Private Sub Money_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRealCapital.Enter, txtRegCapital.Enter, txtInvisibleAssets.Enter, txtTotalCapital.Enter, txtCashReceive.Enter
        Money.Money_Enter(sender, e)
    End Sub
    Private Sub Money_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRealCapital.KeyPress, txtRegCapital.KeyPress, txtInvisibleAssets.KeyPress, txtTotalCapital.KeyPress, txtCashReceive.KeyPress
        Money.Money_KeyPress(sender, e)
    End Sub
    Private Sub Money_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRealCapital.Leave, txtRegCapital.Leave, txtTotalCapital.Leave, txtInvisibleAssets.Leave, txtCashReceive.Leave
        Money.Money_Leave(sender, e)
    End Sub

    '
    '初始化选项框控件的包含数据
    '
    Private Sub InitComboBox()
        '
        '币种
        '
        'cbxCurrencyType.DataSource = CurrencyDS.Tables("TCurrency")
        'cbxCurrencyType.DisplayMember = "currency"
        'cbxCurrencyType.ValueMember = "currency"
        '
        '2
        '
        'cbxLoanCurrency.DataSource = CurrencyDS.Tables("TCurrency")
        'cbxLoanCurrency.DisplayMember = "currency"
        'cbxLoanCurrency.ValueMember = "currency"
        '
        '贷款方式
        '
        'cbxLoanMethod.DataSource = LoanFormDS.Tables("TLoanForm")
        'cbxLoanMethod.DisplayMember = "loan_form"
        'cbxLoanMethod.ValueMember = "loan_form"
        '
        '贷款类型
        '
        'cbxLoanType.DataSource = LoanTypeDS.Tables("TLoanType")
        'cbxLoanType.DisplayMember = "loan_type"
        'cbxLoanType.ValueMember = "loan_type"
        '
        '与担保企业关系  '尚有修改
        '
        Dim dsCorRelation As DataSet = gWs.GetCorporatioRelationType("%")
        cbxRelation.DataSource = dsCorRelation.Tables("TCorporatioRelationType")
        cbxRelation.DisplayMember = "corporation_relation_type"
        cbxRelation.ValueMember = "corporation_relation_type"
        '
        '区域
        '
        cbxAddressRange.DataSource = DistrictDS.Tables("TDistrict")
        cbxAddressRange.DisplayMember = "district_name"
        cbxAddressRange.ValueMember = "district_name"
        '
        '技术类型
        '
        clbTechType.DataSource = TechnologyTypeDS.Tables("TTechnologyType")
        clbTechType.DisplayMember = "technology_type"
        clbTechType.ValueMember = "technology_type_code"
        '
        '所有制类型
        '
        cbxProprietorShip.DataSource = ProprietorShipDS.Tables("TProprietorshipType")
        cbxProprietorShip.DisplayMember = "proprietorship_type"
        cbxProprietorShip.ValueMember = "proprietorship_type"
        '
        '行业类型
        '
        cbxIndustryType.DataSource = IndustryTypeDS.Tables("TIndustryType")
        cbxIndustryType.DisplayMember = "industry_type"
        cbxIndustryType.ValueMember = "industry_type"
        '
        '出资方式
        '
        'cmbxInvest.DataSource = InvestFormDS.Tables("TInvestForm")
        'cmbxInvest.DisplayMember = "invest_form"
        'cmbxInvest.ValueMember = "invest_form"
    End Sub
    Private hasasked As Boolean = False
    Private IsWrong As Boolean = False
    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        IsWrong = True
        If txtNewCorName.Text = String.Empty Then
            'MessageBox.Show("企业名称不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SWDialogBox.MessageBox.Show("$1001", "企业名称")
            txtNewCorName.Focus()
            Return
        End If
        'If Not hasasked And (txtTotalInvestSum.Text.Trim <> String.Empty) And (txtRealCapital.Text.Trim <> String.Empty) Then
        '    If CDbl(txtTotalInvestSum.Text) <> CDbl(txtRealCapital.Text) Then
        '        hasasked = True
        '        If MessageBox.Show("股东总投资资本不等于实收资本，要强制保存吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.No Then
        '            Return
        '        End If
        '    End If
        'End If
        '企业表
        With dsCorporation.Tables("corporation").Rows(bmCorporation.Position)
            .Item("technology_type") = CorTechType
            .Item("corporation_name") = txtNewCorName.Text
            .Item("district_name") = cbxAddressRange.SelectedValue
            .Item("register_address") = txtAddressDetail.Text
            .Item("industry_type") = cbxIndustryType.SelectedValue
            .Item("proprietorship_type") = cbxProprietorShip.SelectedValue
            '''new add
            .Item("loan_card_id") = txtLoanCardID.Text
            .Item("loan_paper_id") = txtLoanID.Text
            .Item("business_licence_code") = txtCorpID.Text
            .Item("corp_paper_id") = txtRepID.Text
        End With
        '项目企业表
        Me.BindingContext(dsProCor, "TProjectCorporation").EndCurrentEdit()
        With dsProCor.Tables("TProjectCorporation").Rows(bmProCor.Position)
            .Item("technology_type") = CorTechType
        End With

        'Dim dr As DataRow
        ''借款记录
        'Dim drsLoanRec As DataRow() = dsLoanRec.Tables("TCorporationLoan").Select("", "", DataViewRowState.Added)
        'For Each dr In drsLoanRec
        '    SerialNumForLoanRec += 1
        '    dr("serial_num") = SerialNumForLoanRec
        'Next

        ''对外担保记录
        'Dim drsForVouchRec As DataRow() = dsVouchRec.Tables("TCorporationExternalGuarantee").Select("", "", DataViewRowState.Added)
        'For Each dr In drsForVouchRec
        '    SerialNumForVouchRec += 1
        '    dr("serial_num") = SerialNumForVouchRec
        'Next
        ''股权结构   
        'For Each dr In dsStockStru.Tables("TCorporationStockStructure").Select("", "", DataViewRowState.Added)
        '    SerialNumStockStru += 1
        '    dr("serial_num") = SerialNumStockStru
        'Next

        bmProCor.Position = bmProCor.Position
        '提交数据库
        Dim strResult As String
        strResult = gWs.UpdateCorporationAndProjectCorporation(dsCorporation.GetChanges, dsProCor.GetChanges)
        'strResult += gWs.UpdateCorporationStockStructure(dsStockStru.GetChanges)
        'strResult += gWs.UpdateCorporationExternalGuarantee(dsVouchRec.GetChanges)
        'strResult += gWs.UpdateCorporationLoan(dsLoanRec.GetChanges)
        If strResult = "1" Then
            IsWrong = False
            btnFinance.Enabled = True
            If Not sender Is Nothing Then
                'MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                SWDialogBox.MessageBox.Show("$SaveSucceed")
            End If
            dsCorporation.AcceptChanges() : dsProCor.AcceptChanges()
            'dsStockStru.AcceptChanges() : dsVouchRec.AcceptChanges()
            'dsLoanRec.AcceptChanges()
            strStatus = String.Empty
            IsTechChanged = False
        Else
            SWDialogBox.MessageBox.Show("*999", "保存失败", strResult, "")
            'MessageBox.Show("保存失败" & vbCr & strResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        ConfirmClose(sender, e)
    End Sub

    Private Function ConfirmClose(ByVal sender, ByVal e) As Boolean
        'bmProCor.Position = bmProCor.Position
        If Not Me.Owner Is Nothing Then '拥有者不为空的情况下，才需判断是否需要保存修改
            If dsProCor.HasChanges Or IsTechChanged Then 'Or dsStockStru.HasChanges Or dsVouchRec.HasChanges Or dsLoanRec.HasChanges 
                Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003")
                If QueryResult = DialogResult.Yes Then
                    btnSave_Click(Nothing, Nothing)
                    If IsWrong Then Return False
                ElseIf QueryResult = DialogResult.Cancel Then
                    Return False
                End If
            End If
            If (CorPosition < 0) And (strStatus <> String.Empty) Then '表示新增企业并没有保存过
                CType(bmCorporation.Current, DataRowView).Delete()
                CType(bmProCor.Current, DataRowView).Delete()
                gWs.UpdateCorporationAndProjectCorporation(dsCorporation.GetChanges, dsProCor.GetChanges)
            End If
            CType(Owner, frmCorAssureList).Refresh()
        End If

        RemoveHandler MyBase.Closing, AddressOf frmCorAssure_Closing
        Close()
        Return True
    End Function

    Private Sub frmCorAssure_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, e)
    End Sub

    Private Sub tcCoMBase_TabIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        clbTechType.Tag = "false"
        InitTechType(sender)
        clbTechType.Tag = "true"
    End Sub

    Private Sub frmWorkLog_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Chr(13) Then
            CType(sender, Form).SelectNextControl(Me.ActiveControl, True, False, True, True)
        End If
    End Sub

    Private Sub btnFinance_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnFinance.Click
        Dim strName As String = CType(bmProCor.Current, DataRowView)("corporation_name").ToString
        Dim ofrmFinanceManage As frmFinanceManage = New frmFinanceManage(ProjectCode, strName, Me.CorporationCode, phrase, Me)
        'ofrmFinanceManage.LookOnly = True
        ofrmFinanceManage.AllowTransparency = False
        ofrmFinanceManage.ShowDialog()
    End Sub

    Private Sub frmCorAssure_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        If Not Me.Owner Is Nothing Then
            If Me.Owner.GetType Is GetType(frmCorAssureList) Then
                CType(Owner, frmCorAssureList).Focus()
            End If
        End If
    End Sub

    '财务分析
    Private Sub btnAnalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalysis.Click
        Try
            '进行财务分析之前进行财务数据判断，如果没有财务数据则不能进行财务分析。
            Dim ds As New DataSet()
            ds = gWs.GetAccount("{project_code like '" & ProjectCode & "' and phase like '" & phrase & "' and corporation_code LIKE '" & CorporationCode & "'}")
            If ds.Tables(0).Rows.Count = 0 Then
                SWDialogBox.MessageBox.Show("$1007", "保证企业财务数据")
                Return
            End If
            Dim frm As New FFinancialAnalysis()
            frm.SetEditState(False)
            frm.ShowDialog(ProjectCode, CorporationCode, phrase)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Public Sub OnlyView()
        Dim c As Control
        For Each c In grpCorp.Controls
            If c.GetType Is GetType(TextBox) Then
                CType(c, TextBox).ReadOnly = True
            Else
                c.Enabled = c.GetType Is GetType(Label)
            End If
        Next
        btnFinance.Visible = False
        btnAnalysis.Visible = False
        btnSave.Visible = False
    End Sub

End Class
