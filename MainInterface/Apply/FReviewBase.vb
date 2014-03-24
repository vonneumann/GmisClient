
'项目评审基类－－供保函、再担保继承
Public Class FReviewBase
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
    Public WithEvents pgProject As System.Windows.Forms.TabPage
    Public WithEvents grpProjectPassed As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Protected WithEvents grpRequest As System.Windows.Forms.GroupBox
    Protected WithEvents txtRecommendPerson As System.Windows.Forms.TextBox
    Protected WithEvents txtPurpose As System.Windows.Forms.TextBox
    Protected WithEvents dtpApplyDate As System.Windows.Forms.DateTimePicker
    Protected WithEvents nuTerm As System.Windows.Forms.NumericUpDown
    Protected WithEvents txtApplySum As System.Windows.Forms.TextBox
    Protected WithEvents dtpRecommend As System.Windows.Forms.DateTimePicker
    Protected WithEvents txtRecommendSum As System.Windows.Forms.TextBox
    Public WithEvents pgCorpInfo As System.Windows.Forms.TabPage
    Friend WithEvents groupbox As System.Windows.Forms.GroupBox
    Protected WithEvents txtColledgeNum As System.Windows.Forms.TextBox
    Protected WithEvents txtBachelorNum As System.Windows.Forms.TextBox
    Protected WithEvents txtMasterNum As System.Windows.Forms.TextBox
    Protected WithEvents txtDoctorNum As System.Windows.Forms.TextBox
    Protected WithEvents txtEmployeeAmount As System.Windows.Forms.TextBox
    Protected WithEvents grpProjectHeader As System.Windows.Forms.GroupBox
    Protected WithEvents lblProjectPhase As System.Windows.Forms.Label
    Protected WithEvents lblCorporationName As System.Windows.Forms.Label
    Protected WithEvents lblProjectCode As System.Windows.Forms.Label
    Protected WithEvents grpProjectBody As System.Windows.Forms.GroupBox
    Protected WithEvents lblProjectRequestDate As System.Windows.Forms.Label
    Protected WithEvents lblProjectRequestServiceType As System.Windows.Forms.Label
    Protected WithEvents lblProjectRequestBranch As System.Windows.Forms.Label
    Protected WithEvents lblProjectRequestBank As System.Windows.Forms.Label
    Protected WithEvents lblProjectRequestSum As System.Windows.Forms.Label
    Protected WithEvents lblProjectRecommendDate As System.Windows.Forms.Label
    Protected WithEvents lblProjectRecommendSum As System.Windows.Forms.Label
    Protected WithEvents lblProjectCooperateOpinion As System.Windows.Forms.Label
    Protected WithEvents lblProjectRequestTerm As System.Windows.Forms.Label
    Protected WithEvents chkIsFirstLoan As System.Windows.Forms.CheckBox
    Protected WithEvents txtLegelMobile As System.Windows.Forms.TextBox
    Protected WithEvents txtLegelPhone As System.Windows.Forms.TextBox
    Protected WithEvents txtContactEmail As System.Windows.Forms.TextBox
    Protected WithEvents txtContactMobile As System.Windows.Forms.TextBox
    Protected WithEvents lblAttachColledge As System.Windows.Forms.Label
    Protected WithEvents lblAttachMaster As System.Windows.Forms.Label
    Protected WithEvents lblAttachMember As System.Windows.Forms.Label
    Protected WithEvents lblFoundDate As System.Windows.Forms.Label
    Protected WithEvents dtpFoundDate As System.Windows.Forms.DateTimePicker
    Protected WithEvents clbTechType As System.Windows.Forms.CheckedListBox
    Protected WithEvents lblCorpTechType As System.Windows.Forms.Label
    Protected WithEvents lblCorpPropriateShip As System.Windows.Forms.Label
    Protected WithEvents lblCorpIndustryType As System.Windows.Forms.Label
    Protected WithEvents txtAddressDetail As System.Windows.Forms.TextBox
    Protected WithEvents lblCorpRegisterAddress As System.Windows.Forms.Label
    Protected WithEvents txtLoanCardID As System.Windows.Forms.TextBox
    Protected WithEvents lblCorpCardID As System.Windows.Forms.Label
    Protected WithEvents txtRepID As System.Windows.Forms.TextBox
    Protected WithEvents lblCorpRepreCardID As System.Windows.Forms.Label
    Protected WithEvents txtLoanID As System.Windows.Forms.TextBox
    Protected WithEvents lblCorpPaperID As System.Windows.Forms.Label
    Protected WithEvents txtCorpID As System.Windows.Forms.TextBox
    Protected WithEvents lblCorpBusinessCode As System.Windows.Forms.Label
    Protected WithEvents txtFax As System.Windows.Forms.TextBox
    Protected WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Protected WithEvents txtContactPerson As System.Windows.Forms.TextBox
    Protected WithEvents txtRepreID As System.Windows.Forms.TextBox
    Protected WithEvents txtCashReceive As System.Windows.Forms.TextBox
    Protected WithEvents txtRepreNation As System.Windows.Forms.TextBox
    Protected WithEvents txtInvisibleAssets As System.Windows.Forms.TextBox
    Protected WithEvents txtRepresentative As System.Windows.Forms.TextBox
    Protected WithEvents txtRealCapital As System.Windows.Forms.TextBox
    Protected WithEvents txtRegCapital As System.Windows.Forms.TextBox
    Protected WithEvents txtEvalInstitute As System.Windows.Forms.TextBox
    Protected WithEvents txtCreditLevel As System.Windows.Forms.TextBox
    Protected WithEvents lblContactorFax As System.Windows.Forms.Label
    Protected WithEvents lblCorpContactNumber As System.Windows.Forms.Label
    Protected WithEvents lblCorpContactor As System.Windows.Forms.Label
    Protected WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Protected WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    Protected WithEvents lblCorpInvisibleAsset As System.Windows.Forms.Label
    Protected WithEvents lblCorpRepre As System.Windows.Forms.Label
    Protected WithEvents lblCorpRepreID As System.Windows.Forms.Label
    Protected WithEvents lblCorpRepreNation As System.Windows.Forms.Label
    Protected WithEvents lblCorpCreditLevel As System.Windows.Forms.Label
    Protected WithEvents lblCorpEvalInstitute As System.Windows.Forms.Label
    Protected WithEvents lblCorpRealAsset As System.Windows.Forms.Label
    Protected WithEvents lblCorpCashArrived As System.Windows.Forms.Label
    Protected WithEvents lblCorpBusinessStartDate As System.Windows.Forms.Label
    Protected WithEvents lblCorpBusinessEndDate As System.Windows.Forms.Label
    Protected WithEvents lblCorpRegisterAsset As System.Windows.Forms.Label
    Protected WithEvents MainMenu As System.Windows.Forms.MainMenu
    Protected WithEvents cboApplyServiceType As System.Windows.Forms.ComboBox
    Protected WithEvents cboApplyBranch As System.Windows.Forms.ComboBox
    Protected WithEvents cboApplyBank As System.Windows.Forms.ComboBox
    Protected WithEvents cboRecommendType As System.Windows.Forms.ComboBox
    Protected WithEvents cboMainServiceType As System.Windows.Forms.ComboBox
    Protected WithEvents cboProprietorShip As System.Windows.Forms.ComboBox
    Protected WithEvents cboIndustryType As System.Windows.Forms.ComboBox
    Protected WithEvents cboAddressRange As System.Windows.Forms.ComboBox
    Protected WithEvents lblMainServiceType As System.Windows.Forms.Label
    Protected WithEvents lblContactEmail As System.Windows.Forms.Label
    Protected WithEvents txtProjectPhase As System.Windows.Forms.TextBox
    Protected WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Protected WithEvents lblRecommend As System.Windows.Forms.Label
    Protected WithEvents lblPurpose As System.Windows.Forms.Label
    Protected WithEvents lblLegelMobile As System.Windows.Forms.Label
    Protected WithEvents lblLegelPhone As System.Windows.Forms.Label
    Protected WithEvents lblContactMobile As System.Windows.Forms.Label
    Protected WithEvents dgProject As System.Windows.Forms.DataGrid
    Protected WithEvents lblAttachBancholer As System.Windows.Forms.Label
    Protected WithEvents lblAttachDoctor As System.Windows.Forms.Label
    Protected WithEvents btnReport As System.Windows.Forms.Button
    Protected WithEvents btnSave As System.Windows.Forms.Button
    Protected WithEvents btnCommit As System.Windows.Forms.Button
    Protected WithEvents cboRecommendItems As System.Windows.Forms.ComboBox
    Protected WithEvents txtCooperateOpinion As System.Windows.Forms.TextBox
    Protected WithEvents mnuCheckMaterial As System.Windows.Forms.MenuItem
    Protected WithEvents mnuImportHistory As System.Windows.Forms.MenuItem
    Protected WithEvents mnuFinanceAnalyze As System.Windows.Forms.MenuItem
    Protected WithEvents mnuInputFinance As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Protected WithEvents cboMoneyType As System.Windows.Forms.ComboBox
    Protected WithEvents lblMoneyType As System.Windows.Forms.Label
    Friend WithEvents tabReview As System.Windows.Forms.TabControl
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FReviewBase))
        Me.grpProjectHeader = New System.Windows.Forms.GroupBox
        Me.txtProjectPhase = New System.Windows.Forms.TextBox
        Me.txtCorporationName = New System.Windows.Forms.TextBox
        Me.txtProjectCode = New System.Windows.Forms.TextBox
        Me.lblProjectPhase = New System.Windows.Forms.Label
        Me.lblCorporationName = New System.Windows.Forms.Label
        Me.lblProjectCode = New System.Windows.Forms.Label
        Me.grpProjectBody = New System.Windows.Forms.GroupBox
        Me.tabReview = New System.Windows.Forms.TabControl
        Me.pgProject = New System.Windows.Forms.TabPage
        Me.grpProjectPassed = New System.Windows.Forms.GroupBox
        Me.dgProject = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.grpRequest = New System.Windows.Forms.GroupBox
        Me.txtRecommendPerson = New System.Windows.Forms.TextBox
        Me.cboRecommendItems = New System.Windows.Forms.ComboBox
        Me.cboRecommendType = New System.Windows.Forms.ComboBox
        Me.lblRecommend = New System.Windows.Forms.Label
        Me.txtPurpose = New System.Windows.Forms.TextBox
        Me.lblPurpose = New System.Windows.Forms.Label
        Me.lblProjectRequestDate = New System.Windows.Forms.Label
        Me.dtpApplyDate = New System.Windows.Forms.DateTimePicker
        Me.nuTerm = New System.Windows.Forms.NumericUpDown
        Me.lblProjectRequestTerm = New System.Windows.Forms.Label
        Me.cboApplyServiceType = New System.Windows.Forms.ComboBox
        Me.lblProjectRequestServiceType = New System.Windows.Forms.Label
        Me.cboApplyBranch = New System.Windows.Forms.ComboBox
        Me.cboApplyBank = New System.Windows.Forms.ComboBox
        Me.lblProjectRequestBranch = New System.Windows.Forms.Label
        Me.txtApplySum = New System.Windows.Forms.TextBox
        Me.lblProjectRequestBank = New System.Windows.Forms.Label
        Me.lblProjectRequestSum = New System.Windows.Forms.Label
        Me.txtCooperateOpinion = New System.Windows.Forms.TextBox
        Me.dtpRecommend = New System.Windows.Forms.DateTimePicker
        Me.lblProjectRecommendDate = New System.Windows.Forms.Label
        Me.txtRecommendSum = New System.Windows.Forms.TextBox
        Me.lblProjectRecommendSum = New System.Windows.Forms.Label
        Me.lblProjectCooperateOpinion = New System.Windows.Forms.Label
        Me.pgCorpInfo = New System.Windows.Forms.TabPage
        Me.groupbox = New System.Windows.Forms.GroupBox
        Me.cboMoneyType = New System.Windows.Forms.ComboBox
        Me.lblMoneyType = New System.Windows.Forms.Label
        Me.cboMainServiceType = New System.Windows.Forms.ComboBox
        Me.lblMainServiceType = New System.Windows.Forms.Label
        Me.chkIsFirstLoan = New System.Windows.Forms.CheckBox
        Me.txtLegelMobile = New System.Windows.Forms.TextBox
        Me.lblLegelMobile = New System.Windows.Forms.Label
        Me.txtLegelPhone = New System.Windows.Forms.TextBox
        Me.lblLegelPhone = New System.Windows.Forms.Label
        Me.txtContactEmail = New System.Windows.Forms.TextBox
        Me.txtContactMobile = New System.Windows.Forms.TextBox
        Me.lblContactEmail = New System.Windows.Forms.Label
        Me.lblContactMobile = New System.Windows.Forms.Label
        Me.txtColledgeNum = New System.Windows.Forms.TextBox
        Me.lblAttachColledge = New System.Windows.Forms.Label
        Me.txtBachelorNum = New System.Windows.Forms.TextBox
        Me.lblAttachBancholer = New System.Windows.Forms.Label
        Me.txtMasterNum = New System.Windows.Forms.TextBox
        Me.lblAttachMaster = New System.Windows.Forms.Label
        Me.txtDoctorNum = New System.Windows.Forms.TextBox
        Me.lblAttachDoctor = New System.Windows.Forms.Label
        Me.txtEmployeeAmount = New System.Windows.Forms.TextBox
        Me.lblAttachMember = New System.Windows.Forms.Label
        Me.lblFoundDate = New System.Windows.Forms.Label
        Me.dtpFoundDate = New System.Windows.Forms.DateTimePicker
        Me.clbTechType = New System.Windows.Forms.CheckedListBox
        Me.lblCorpTechType = New System.Windows.Forms.Label
        Me.cboProprietorShip = New System.Windows.Forms.ComboBox
        Me.lblCorpPropriateShip = New System.Windows.Forms.Label
        Me.cboIndustryType = New System.Windows.Forms.ComboBox
        Me.lblCorpIndustryType = New System.Windows.Forms.Label
        Me.cboAddressRange = New System.Windows.Forms.ComboBox
        Me.txtAddressDetail = New System.Windows.Forms.TextBox
        Me.lblCorpRegisterAddress = New System.Windows.Forms.Label
        Me.txtLoanCardID = New System.Windows.Forms.TextBox
        Me.lblCorpCardID = New System.Windows.Forms.Label
        Me.txtRepID = New System.Windows.Forms.TextBox
        Me.lblCorpRepreCardID = New System.Windows.Forms.Label
        Me.txtLoanID = New System.Windows.Forms.TextBox
        Me.lblCorpPaperID = New System.Windows.Forms.Label
        Me.txtCorpID = New System.Windows.Forms.TextBox
        Me.lblCorpBusinessCode = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.txtContactNumber = New System.Windows.Forms.TextBox
        Me.txtContactPerson = New System.Windows.Forms.TextBox
        Me.txtRepreID = New System.Windows.Forms.TextBox
        Me.txtCashReceive = New System.Windows.Forms.TextBox
        Me.txtRepreNation = New System.Windows.Forms.TextBox
        Me.txtInvisibleAssets = New System.Windows.Forms.TextBox
        Me.txtRepresentative = New System.Windows.Forms.TextBox
        Me.txtRealCapital = New System.Windows.Forms.TextBox
        Me.txtRegCapital = New System.Windows.Forms.TextBox
        Me.txtEvalInstitute = New System.Windows.Forms.TextBox
        Me.txtCreditLevel = New System.Windows.Forms.TextBox
        Me.lblContactorFax = New System.Windows.Forms.Label
        Me.lblCorpContactNumber = New System.Windows.Forms.Label
        Me.lblCorpContactor = New System.Windows.Forms.Label
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker
        Me.lblCorpInvisibleAsset = New System.Windows.Forms.Label
        Me.lblCorpRepre = New System.Windows.Forms.Label
        Me.lblCorpRepreID = New System.Windows.Forms.Label
        Me.lblCorpRepreNation = New System.Windows.Forms.Label
        Me.lblCorpCreditLevel = New System.Windows.Forms.Label
        Me.lblCorpEvalInstitute = New System.Windows.Forms.Label
        Me.lblCorpRealAsset = New System.Windows.Forms.Label
        Me.lblCorpCashArrived = New System.Windows.Forms.Label
        Me.lblCorpBusinessStartDate = New System.Windows.Forms.Label
        Me.lblCorpBusinessEndDate = New System.Windows.Forms.Label
        Me.lblCorpRegisterAsset = New System.Windows.Forms.Label
        Me.btnReport = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSave = New System.Windows.Forms.Button
        Me.MainMenu = New System.Windows.Forms.MainMenu
        Me.mnuCheckMaterial = New System.Windows.Forms.MenuItem
        Me.mnuImportHistory = New System.Windows.Forms.MenuItem
        Me.mnuInputFinance = New System.Windows.Forms.MenuItem
        Me.mnuFinanceAnalyze = New System.Windows.Forms.MenuItem
        Me.btnCommit = New System.Windows.Forms.Button
        Me.grpProjectHeader.SuspendLayout()
        Me.grpProjectBody.SuspendLayout()
        Me.tabReview.SuspendLayout()
        Me.pgProject.SuspendLayout()
        Me.grpProjectPassed.SuspendLayout()
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRequest.SuspendLayout()
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgCorpInfo.SuspendLayout()
        Me.groupbox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(511, 484)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        '
        'grpProjectHeader
        '
        Me.grpProjectHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProjectHeader.Controls.Add(Me.txtProjectPhase)
        Me.grpProjectHeader.Controls.Add(Me.txtCorporationName)
        Me.grpProjectHeader.Controls.Add(Me.txtProjectCode)
        Me.grpProjectHeader.Controls.Add(Me.lblProjectPhase)
        Me.grpProjectHeader.Controls.Add(Me.lblCorporationName)
        Me.grpProjectHeader.Controls.Add(Me.lblProjectCode)
        Me.grpProjectHeader.Location = New System.Drawing.Point(9, 11)
        Me.grpProjectHeader.Name = "grpProjectHeader"
        Me.grpProjectHeader.Size = New System.Drawing.Size(776, 48)
        Me.grpProjectHeader.TabIndex = 3
        Me.grpProjectHeader.TabStop = False
        Me.grpProjectHeader.Text = "项目信息"
        '
        'txtProjectPhase
        '
        Me.txtProjectPhase.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.txtProjectPhase.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectPhase.Location = New System.Drawing.Point(672, 16)
        Me.txtProjectPhase.Name = "txtProjectPhase"
        Me.txtProjectPhase.ReadOnly = True
        Me.txtProjectPhase.Size = New System.Drawing.Size(80, 21)
        Me.txtProjectPhase.TabIndex = 0
        Me.txtProjectPhase.TabStop = False
        Me.txtProjectPhase.Text = ""
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorporationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorporationName.Location = New System.Drawing.Point(200, 16)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.ReadOnly = True
        Me.txtCorporationName.Size = New System.Drawing.Size(400, 21)
        Me.txtCorporationName.TabIndex = 0
        Me.txtCorporationName.TabStop = False
        Me.txtCorporationName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(64, 16)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(72, 21)
        Me.txtProjectCode.TabIndex = 0
        Me.txtProjectCode.TabStop = False
        Me.txtProjectCode.Text = ""
        '
        'lblProjectPhase
        '
        Me.lblProjectPhase.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.lblProjectPhase.AutoSize = True
        Me.lblProjectPhase.Location = New System.Drawing.Point(616, 19)
        Me.lblProjectPhase.Name = "lblProjectPhase"
        Me.lblProjectPhase.Size = New System.Drawing.Size(54, 17)
        Me.lblProjectPhase.TabIndex = 0
        Me.lblProjectPhase.Text = "项目阶段"
        Me.lblProjectPhase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorporationName
        '
        Me.lblCorporationName.AutoSize = True
        Me.lblCorporationName.Location = New System.Drawing.Point(144, 19)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(54, 17)
        Me.lblCorporationName.TabIndex = 0
        Me.lblCorporationName.Text = "企业名称"
        Me.lblCorporationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjectCode
        '
        Me.lblProjectCode.AutoSize = True
        Me.lblProjectCode.Location = New System.Drawing.Point(8, 19)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(54, 17)
        Me.lblProjectCode.TabIndex = 0
        Me.lblProjectCode.Text = "项目编码"
        Me.lblProjectCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpProjectBody
        '
        Me.grpProjectBody.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProjectBody.Controls.Add(Me.tabReview)
        Me.grpProjectBody.Location = New System.Drawing.Point(9, 59)
        Me.grpProjectBody.Name = "grpProjectBody"
        Me.grpProjectBody.Size = New System.Drawing.Size(776, 420)
        Me.grpProjectBody.TabIndex = 2
        Me.grpProjectBody.TabStop = False
        '
        'tabReview
        '
        Me.tabReview.Controls.Add(Me.pgProject)
        Me.tabReview.Controls.Add(Me.pgCorpInfo)
        Me.tabReview.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabReview.Location = New System.Drawing.Point(3, 17)
        Me.tabReview.Name = "tabReview"
        Me.tabReview.SelectedIndex = 0
        Me.tabReview.Size = New System.Drawing.Size(770, 400)
        Me.tabReview.TabIndex = 0
        Me.tabReview.TabStop = False
        '
        'pgProject
        '
        Me.pgProject.BackColor = System.Drawing.SystemColors.Control
        Me.pgProject.Controls.Add(Me.grpProjectPassed)
        Me.pgProject.Controls.Add(Me.grpRequest)
        Me.pgProject.Location = New System.Drawing.Point(4, 21)
        Me.pgProject.Name = "pgProject"
        Me.pgProject.Size = New System.Drawing.Size(762, 375)
        Me.pgProject.TabIndex = 11
        Me.pgProject.Text = "项目基本信息"
        '
        'grpProjectPassed
        '
        Me.grpProjectPassed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpProjectPassed.BackColor = System.Drawing.SystemColors.Control
        Me.grpProjectPassed.Controls.Add(Me.dgProject)
        Me.grpProjectPassed.Location = New System.Drawing.Point(0, 8)
        Me.grpProjectPassed.Name = "grpProjectPassed"
        Me.grpProjectPassed.Size = New System.Drawing.Size(762, 108)
        Me.grpProjectPassed.TabIndex = 0
        Me.grpProjectPassed.TabStop = False
        Me.grpProjectPassed.Text = "历史受理记录"
        '
        'dgProject
        '
        Me.dgProject.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgProject.CaptionVisible = False
        Me.dgProject.DataMember = ""
        Me.dgProject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProject.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgProject.Location = New System.Drawing.Point(3, 17)
        Me.dgProject.Name = "dgProject"
        Me.dgProject.Size = New System.Drawing.Size(756, 88)
        Me.dgProject.TabIndex = 0
        Me.dgProject.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgProject.TabStop = False
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgProject
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "OldProject"
        Me.DataGridTableStyle1.ReadOnly = True
        Me.DataGridTableStyle1.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn1.MappingName = "project_code"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 70
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "申请日期"
        Me.DataGridTextBoxColumn2.MappingName = "apply_date"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "申请业务品种"
        Me.DataGridTextBoxColumn3.MappingName = "apply_service_type"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 120
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "申请银行"
        Me.DataGridTextBoxColumn4.MappingName = "CBank"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 120
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "申请支行"
        Me.DataGridTextBoxColumn5.MappingName = "CBranch"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn6.Format = "c"
        Me.DataGridTextBoxColumn6.FormatInfo = CType(resources.GetObject("DataGridTextBoxColumn6.FormatInfo"), System.IFormatProvider)
        Me.DataGridTextBoxColumn6.HeaderText = "申请担保金额(万) "
        Me.DataGridTextBoxColumn6.MappingName = "apply_sum"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 120
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "担保期限(月)"
        Me.DataGridTextBoxColumn7.MappingName = "apply_term"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 80
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "用途"
        Me.DataGridTextBoxColumn8.MappingName = "purpose"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 180
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn9.Format = "c"
        Me.DataGridTextBoxColumn9.FormatInfo = CType(resources.GetObject("DataGridTextBoxColumn9.FormatInfo"), System.IFormatProvider)
        Me.DataGridTextBoxColumn9.HeaderText = "贷款金额(万元)"
        Me.DataGridTextBoxColumn9.MappingName = "loan_sum"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 110
        '
        'grpRequest
        '
        Me.grpRequest.BackColor = System.Drawing.SystemColors.Control
        Me.grpRequest.Controls.Add(Me.txtRecommendPerson)
        Me.grpRequest.Controls.Add(Me.cboRecommendItems)
        Me.grpRequest.Controls.Add(Me.cboRecommendType)
        Me.grpRequest.Controls.Add(Me.lblRecommend)
        Me.grpRequest.Controls.Add(Me.txtPurpose)
        Me.grpRequest.Controls.Add(Me.lblPurpose)
        Me.grpRequest.Controls.Add(Me.lblProjectRequestDate)
        Me.grpRequest.Controls.Add(Me.dtpApplyDate)
        Me.grpRequest.Controls.Add(Me.nuTerm)
        Me.grpRequest.Controls.Add(Me.lblProjectRequestTerm)
        Me.grpRequest.Controls.Add(Me.cboApplyServiceType)
        Me.grpRequest.Controls.Add(Me.lblProjectRequestServiceType)
        Me.grpRequest.Controls.Add(Me.cboApplyBranch)
        Me.grpRequest.Controls.Add(Me.cboApplyBank)
        Me.grpRequest.Controls.Add(Me.lblProjectRequestBranch)
        Me.grpRequest.Controls.Add(Me.txtApplySum)
        Me.grpRequest.Controls.Add(Me.lblProjectRequestBank)
        Me.grpRequest.Controls.Add(Me.lblProjectRequestSum)
        Me.grpRequest.Controls.Add(Me.txtCooperateOpinion)
        Me.grpRequest.Controls.Add(Me.dtpRecommend)
        Me.grpRequest.Controls.Add(Me.lblProjectRecommendDate)
        Me.grpRequest.Controls.Add(Me.txtRecommendSum)
        Me.grpRequest.Controls.Add(Me.lblProjectRecommendSum)
        Me.grpRequest.Controls.Add(Me.lblProjectCooperateOpinion)
        Me.grpRequest.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpRequest.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.grpRequest.Location = New System.Drawing.Point(0, 111)
        Me.grpRequest.Name = "grpRequest"
        Me.grpRequest.Size = New System.Drawing.Size(762, 264)
        Me.grpRequest.TabIndex = 0
        Me.grpRequest.TabStop = False
        '
        'txtRecommendPerson
        '
        Me.txtRecommendPerson.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtRecommendPerson.Location = New System.Drawing.Point(168, 134)
        Me.txtRecommendPerson.MaxLength = 20
        Me.txtRecommendPerson.Name = "txtRecommendPerson"
        Me.txtRecommendPerson.Size = New System.Drawing.Size(104, 21)
        Me.txtRecommendPerson.TabIndex = 9
        Me.txtRecommendPerson.TabStop = False
        Me.txtRecommendPerson.Text = ""
        '
        'cboRecommendItems
        '
        Me.cboRecommendItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRecommendItems.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboRecommendItems.Location = New System.Drawing.Point(168, 134)
        Me.cboRecommendItems.Name = "cboRecommendItems"
        Me.cboRecommendItems.Size = New System.Drawing.Size(104, 20)
        Me.cboRecommendItems.TabIndex = 10
        Me.cboRecommendItems.TabStop = False
        '
        'cboRecommendType
        '
        Me.cboRecommendType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRecommendType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboRecommendType.ItemHeight = 12
        Me.cboRecommendType.Location = New System.Drawing.Point(88, 134)
        Me.cboRecommendType.Name = "cboRecommendType"
        Me.cboRecommendType.Size = New System.Drawing.Size(80, 20)
        Me.cboRecommendType.TabIndex = 7
        '
        'lblRecommend
        '
        Me.lblRecommend.Location = New System.Drawing.Point(8, 136)
        Me.lblRecommend.Name = "lblRecommend"
        Me.lblRecommend.Size = New System.Drawing.Size(80, 16)
        Me.lblRecommend.TabIndex = 12
        Me.lblRecommend.Text = "推荐单位(人)"
        Me.lblRecommend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPurpose
        '
        Me.txtPurpose.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtPurpose.Location = New System.Drawing.Point(88, 72)
        Me.txtPurpose.MaxLength = 100
        Me.txtPurpose.Multiline = True
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPurpose.Size = New System.Drawing.Size(656, 56)
        Me.txtPurpose.TabIndex = 6
        Me.txtPurpose.TabStop = False
        Me.txtPurpose.Text = ""
        '
        'lblPurpose
        '
        Me.lblPurpose.Location = New System.Drawing.Point(8, 80)
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.Size = New System.Drawing.Size(64, 16)
        Me.lblPurpose.TabIndex = 0
        Me.lblPurpose.Text = " 用 途"
        Me.lblPurpose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjectRequestDate
        '
        Me.lblProjectRequestDate.Location = New System.Drawing.Point(504, 24)
        Me.lblProjectRequestDate.Name = "lblProjectRequestDate"
        Me.lblProjectRequestDate.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectRequestDate.TabIndex = 0
        Me.lblProjectRequestDate.Text = "申请日期"
        Me.lblProjectRequestDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpApplyDate
        '
        Me.dtpApplyDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpApplyDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpApplyDate.Enabled = False
        Me.dtpApplyDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpApplyDate.Location = New System.Drawing.Point(560, 22)
        Me.dtpApplyDate.Name = "dtpApplyDate"
        Me.dtpApplyDate.Size = New System.Drawing.Size(184, 21)
        Me.dtpApplyDate.TabIndex = 2
        '
        'nuTerm
        '
        Me.nuTerm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.nuTerm.Location = New System.Drawing.Point(336, 22)
        Me.nuTerm.Maximum = New Decimal(New Integer() {36, 0, 0, 0})
        Me.nuTerm.Name = "nuTerm"
        Me.nuTerm.Size = New System.Drawing.Size(152, 21)
        Me.nuTerm.TabIndex = 1
        Me.nuTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nuTerm.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'lblProjectRequestTerm
        '
        Me.lblProjectRequestTerm.Location = New System.Drawing.Point(256, 24)
        Me.lblProjectRequestTerm.Name = "lblProjectRequestTerm"
        Me.lblProjectRequestTerm.Size = New System.Drawing.Size(88, 16)
        Me.lblProjectRequestTerm.TabIndex = 0
        Me.lblProjectRequestTerm.Text = "申请期限(月)"
        Me.lblProjectRequestTerm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboApplyServiceType
        '
        Me.cboApplyServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboApplyServiceType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboApplyServiceType.Location = New System.Drawing.Point(88, 48)
        Me.cboApplyServiceType.Name = "cboApplyServiceType"
        Me.cboApplyServiceType.Size = New System.Drawing.Size(160, 20)
        Me.cboApplyServiceType.TabIndex = 3
        '
        'lblProjectRequestServiceType
        '
        Me.lblProjectRequestServiceType.Location = New System.Drawing.Point(8, 48)
        Me.lblProjectRequestServiceType.Name = "lblProjectRequestServiceType"
        Me.lblProjectRequestServiceType.Size = New System.Drawing.Size(80, 16)
        Me.lblProjectRequestServiceType.TabIndex = 0
        Me.lblProjectRequestServiceType.Text = "申请业务品种"
        Me.lblProjectRequestServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboApplyBranch
        '
        Me.cboApplyBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboApplyBranch.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboApplyBranch.Location = New System.Drawing.Point(560, 46)
        Me.cboApplyBranch.Name = "cboApplyBranch"
        Me.cboApplyBranch.Size = New System.Drawing.Size(184, 20)
        Me.cboApplyBranch.TabIndex = 5
        '
        'cboApplyBank
        '
        Me.cboApplyBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboApplyBank.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cboApplyBank.Location = New System.Drawing.Point(336, 46)
        Me.cboApplyBank.Name = "cboApplyBank"
        Me.cboApplyBank.Size = New System.Drawing.Size(152, 20)
        Me.cboApplyBank.TabIndex = 4
        '
        'lblProjectRequestBranch
        '
        Me.lblProjectRequestBranch.Location = New System.Drawing.Point(504, 48)
        Me.lblProjectRequestBranch.Name = "lblProjectRequestBranch"
        Me.lblProjectRequestBranch.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectRequestBranch.TabIndex = 0
        Me.lblProjectRequestBranch.Text = "申请支行"
        Me.lblProjectRequestBranch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApplySum
        '
        Me.txtApplySum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtApplySum.Location = New System.Drawing.Point(88, 22)
        Me.txtApplySum.MaxLength = 8
        Me.txtApplySum.Name = "txtApplySum"
        Me.txtApplySum.Size = New System.Drawing.Size(160, 21)
        Me.txtApplySum.TabIndex = 0
        Me.txtApplySum.Text = ""
        Me.txtApplySum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblProjectRequestBank
        '
        Me.lblProjectRequestBank.Location = New System.Drawing.Point(256, 48)
        Me.lblProjectRequestBank.Name = "lblProjectRequestBank"
        Me.lblProjectRequestBank.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectRequestBank.TabIndex = 0
        Me.lblProjectRequestBank.Text = "申请银行"
        Me.lblProjectRequestBank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjectRequestSum
        '
        Me.lblProjectRequestSum.Location = New System.Drawing.Point(8, 24)
        Me.lblProjectRequestSum.Name = "lblProjectRequestSum"
        Me.lblProjectRequestSum.Size = New System.Drawing.Size(80, 16)
        Me.lblProjectRequestSum.TabIndex = 0
        Me.lblProjectRequestSum.Text = "申请金额(万)"
        Me.lblProjectRequestSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCooperateOpinion
        '
        Me.txtCooperateOpinion.Enabled = False
        Me.txtCooperateOpinion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtCooperateOpinion.Location = New System.Drawing.Point(88, 160)
        Me.txtCooperateOpinion.MaxLength = 250
        Me.txtCooperateOpinion.Multiline = True
        Me.txtCooperateOpinion.Name = "txtCooperateOpinion"
        Me.txtCooperateOpinion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCooperateOpinion.Size = New System.Drawing.Size(656, 96)
        Me.txtCooperateOpinion.TabIndex = 10
        Me.txtCooperateOpinion.Text = ""
        '
        'dtpRecommend
        '
        Me.dtpRecommend.CustomFormat = "yyyy-MM-dd"
        Me.dtpRecommend.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpRecommend.Enabled = False
        Me.dtpRecommend.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dtpRecommend.Location = New System.Drawing.Point(560, 134)
        Me.dtpRecommend.Name = "dtpRecommend"
        Me.dtpRecommend.Size = New System.Drawing.Size(184, 21)
        Me.dtpRecommend.TabIndex = 9
        '
        'lblProjectRecommendDate
        '
        Me.lblProjectRecommendDate.Location = New System.Drawing.Point(504, 136)
        Me.lblProjectRecommendDate.Name = "lblProjectRecommendDate"
        Me.lblProjectRecommendDate.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectRecommendDate.TabIndex = 0
        Me.lblProjectRecommendDate.Text = "推荐日期"
        Me.lblProjectRecommendDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRecommendSum
        '
        Me.txtRecommendSum.Enabled = False
        Me.txtRecommendSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtRecommendSum.Location = New System.Drawing.Point(368, 134)
        Me.txtRecommendSum.MaxLength = 8
        Me.txtRecommendSum.Name = "txtRecommendSum"
        Me.txtRecommendSum.Size = New System.Drawing.Size(120, 21)
        Me.txtRecommendSum.TabIndex = 8
        Me.txtRecommendSum.Text = ""
        Me.txtRecommendSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblProjectRecommendSum
        '
        Me.lblProjectRecommendSum.Location = New System.Drawing.Point(288, 136)
        Me.lblProjectRecommendSum.Name = "lblProjectRecommendSum"
        Me.lblProjectRecommendSum.Size = New System.Drawing.Size(80, 16)
        Me.lblProjectRecommendSum.TabIndex = 0
        Me.lblProjectRecommendSum.Text = "推荐金额(万)"
        Me.lblProjectRecommendSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProjectCooperateOpinion
        '
        Me.lblProjectCooperateOpinion.Location = New System.Drawing.Point(8, 168)
        Me.lblProjectCooperateOpinion.Name = "lblProjectCooperateOpinion"
        Me.lblProjectCooperateOpinion.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectCooperateOpinion.TabIndex = 0
        Me.lblProjectCooperateOpinion.Text = "合作意见"
        Me.lblProjectCooperateOpinion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pgCorpInfo
        '
        Me.pgCorpInfo.Controls.Add(Me.groupbox)
        Me.pgCorpInfo.Location = New System.Drawing.Point(4, 21)
        Me.pgCorpInfo.Name = "pgCorpInfo"
        Me.pgCorpInfo.Size = New System.Drawing.Size(762, 375)
        Me.pgCorpInfo.TabIndex = 0
        Me.pgCorpInfo.Text = "企业信息"
        Me.pgCorpInfo.Visible = False
        '
        'groupbox
        '
        Me.groupbox.BackColor = System.Drawing.SystemColors.Control
        Me.groupbox.Controls.Add(Me.cboMoneyType)
        Me.groupbox.Controls.Add(Me.lblMoneyType)
        Me.groupbox.Controls.Add(Me.cboMainServiceType)
        Me.groupbox.Controls.Add(Me.lblMainServiceType)
        Me.groupbox.Controls.Add(Me.chkIsFirstLoan)
        Me.groupbox.Controls.Add(Me.txtLegelMobile)
        Me.groupbox.Controls.Add(Me.lblLegelMobile)
        Me.groupbox.Controls.Add(Me.txtLegelPhone)
        Me.groupbox.Controls.Add(Me.lblLegelPhone)
        Me.groupbox.Controls.Add(Me.txtContactEmail)
        Me.groupbox.Controls.Add(Me.txtContactMobile)
        Me.groupbox.Controls.Add(Me.lblContactEmail)
        Me.groupbox.Controls.Add(Me.lblContactMobile)
        Me.groupbox.Controls.Add(Me.txtColledgeNum)
        Me.groupbox.Controls.Add(Me.lblAttachColledge)
        Me.groupbox.Controls.Add(Me.txtBachelorNum)
        Me.groupbox.Controls.Add(Me.lblAttachBancholer)
        Me.groupbox.Controls.Add(Me.txtMasterNum)
        Me.groupbox.Controls.Add(Me.lblAttachMaster)
        Me.groupbox.Controls.Add(Me.txtDoctorNum)
        Me.groupbox.Controls.Add(Me.lblAttachDoctor)
        Me.groupbox.Controls.Add(Me.txtEmployeeAmount)
        Me.groupbox.Controls.Add(Me.lblAttachMember)
        Me.groupbox.Controls.Add(Me.lblFoundDate)
        Me.groupbox.Controls.Add(Me.dtpFoundDate)
        Me.groupbox.Controls.Add(Me.clbTechType)
        Me.groupbox.Controls.Add(Me.lblCorpTechType)
        Me.groupbox.Controls.Add(Me.cboProprietorShip)
        Me.groupbox.Controls.Add(Me.lblCorpPropriateShip)
        Me.groupbox.Controls.Add(Me.cboIndustryType)
        Me.groupbox.Controls.Add(Me.lblCorpIndustryType)
        Me.groupbox.Controls.Add(Me.cboAddressRange)
        Me.groupbox.Controls.Add(Me.txtAddressDetail)
        Me.groupbox.Controls.Add(Me.lblCorpRegisterAddress)
        Me.groupbox.Controls.Add(Me.txtLoanCardID)
        Me.groupbox.Controls.Add(Me.lblCorpCardID)
        Me.groupbox.Controls.Add(Me.txtRepID)
        Me.groupbox.Controls.Add(Me.lblCorpRepreCardID)
        Me.groupbox.Controls.Add(Me.txtLoanID)
        Me.groupbox.Controls.Add(Me.lblCorpPaperID)
        Me.groupbox.Controls.Add(Me.txtCorpID)
        Me.groupbox.Controls.Add(Me.lblCorpBusinessCode)
        Me.groupbox.Controls.Add(Me.txtFax)
        Me.groupbox.Controls.Add(Me.txtContactNumber)
        Me.groupbox.Controls.Add(Me.txtContactPerson)
        Me.groupbox.Controls.Add(Me.txtRepreID)
        Me.groupbox.Controls.Add(Me.txtCashReceive)
        Me.groupbox.Controls.Add(Me.txtRepreNation)
        Me.groupbox.Controls.Add(Me.txtInvisibleAssets)
        Me.groupbox.Controls.Add(Me.txtRepresentative)
        Me.groupbox.Controls.Add(Me.txtRealCapital)
        Me.groupbox.Controls.Add(Me.txtRegCapital)
        Me.groupbox.Controls.Add(Me.txtEvalInstitute)
        Me.groupbox.Controls.Add(Me.txtCreditLevel)
        Me.groupbox.Controls.Add(Me.lblContactorFax)
        Me.groupbox.Controls.Add(Me.lblCorpContactNumber)
        Me.groupbox.Controls.Add(Me.lblCorpContactor)
        Me.groupbox.Controls.Add(Me.dtpEndDate)
        Me.groupbox.Controls.Add(Me.dtpStartDate)
        Me.groupbox.Controls.Add(Me.lblCorpInvisibleAsset)
        Me.groupbox.Controls.Add(Me.lblCorpRepre)
        Me.groupbox.Controls.Add(Me.lblCorpRepreID)
        Me.groupbox.Controls.Add(Me.lblCorpRepreNation)
        Me.groupbox.Controls.Add(Me.lblCorpCreditLevel)
        Me.groupbox.Controls.Add(Me.lblCorpEvalInstitute)
        Me.groupbox.Controls.Add(Me.lblCorpRealAsset)
        Me.groupbox.Controls.Add(Me.lblCorpCashArrived)
        Me.groupbox.Controls.Add(Me.lblCorpBusinessStartDate)
        Me.groupbox.Controls.Add(Me.lblCorpBusinessEndDate)
        Me.groupbox.Controls.Add(Me.lblCorpRegisterAsset)
        Me.groupbox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.groupbox.Location = New System.Drawing.Point(0, 0)
        Me.groupbox.Name = "groupbox"
        Me.groupbox.Size = New System.Drawing.Size(762, 375)
        Me.groupbox.TabIndex = 0
        Me.groupbox.TabStop = False
        '
        'cboMoneyType
        '
        Me.cboMoneyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneyType.Location = New System.Drawing.Point(352, 183)
        Me.cboMoneyType.Name = "cboMoneyType"
        Me.cboMoneyType.Size = New System.Drawing.Size(136, 20)
        Me.cboMoneyType.TabIndex = 328
        '
        'lblMoneyType
        '
        Me.lblMoneyType.Location = New System.Drawing.Point(264, 184)
        Me.lblMoneyType.Name = "lblMoneyType"
        Me.lblMoneyType.Size = New System.Drawing.Size(100, 16)
        Me.lblMoneyType.TabIndex = 329
        Me.lblMoneyType.Text = "货币类型"
        '
        'cboMainServiceType
        '
        Me.cboMainServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMainServiceType.Enabled = False
        Me.cboMainServiceType.ItemHeight = 12
        Me.cboMainServiceType.Location = New System.Drawing.Point(256, 232)
        Me.cboMainServiceType.Name = "cboMainServiceType"
        Me.cboMainServiceType.Size = New System.Drawing.Size(232, 20)
        Me.cboMainServiceType.TabIndex = 19
        Me.cboMainServiceType.Visible = False
        '
        'lblMainServiceType
        '
        Me.lblMainServiceType.Location = New System.Drawing.Point(192, 232)
        Me.lblMainServiceType.Name = "lblMainServiceType"
        Me.lblMainServiceType.Size = New System.Drawing.Size(56, 16)
        Me.lblMainServiceType.TabIndex = 325
        Me.lblMainServiceType.Text = "主营业务"
        Me.lblMainServiceType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMainServiceType.Visible = False
        '
        'chkIsFirstLoan
        '
        Me.chkIsFirstLoan.Location = New System.Drawing.Point(8, 228)
        Me.chkIsFirstLoan.Name = "chkIsFirstLoan"
        Me.chkIsFirstLoan.Size = New System.Drawing.Size(168, 24)
        Me.chkIsFirstLoan.TabIndex = 18
        Me.chkIsFirstLoan.Text = "该企业第一次贷款"
        '
        'txtLegelMobile
        '
        Me.txtLegelMobile.BackColor = System.Drawing.SystemColors.Window
        Me.txtLegelMobile.Location = New System.Drawing.Point(352, 254)
        Me.txtLegelMobile.MaxLength = 12
        Me.txtLegelMobile.Name = "txtLegelMobile"
        Me.txtLegelMobile.Size = New System.Drawing.Size(136, 21)
        Me.txtLegelMobile.TabIndex = 24
        Me.txtLegelMobile.Text = ""
        '
        'lblLegelMobile
        '
        Me.lblLegelMobile.Location = New System.Drawing.Point(256, 256)
        Me.lblLegelMobile.Name = "lblLegelMobile"
        Me.lblLegelMobile.Size = New System.Drawing.Size(96, 16)
        Me.lblLegelMobile.TabIndex = 324
        Me.lblLegelMobile.Text = "法定代表人手机"
        Me.lblLegelMobile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLegelPhone
        '
        Me.txtLegelPhone.BackColor = System.Drawing.SystemColors.Window
        Me.txtLegelPhone.Location = New System.Drawing.Point(96, 278)
        Me.txtLegelPhone.MaxLength = 20
        Me.txtLegelPhone.Name = "txtLegelPhone"
        Me.txtLegelPhone.Size = New System.Drawing.Size(152, 21)
        Me.txtLegelPhone.TabIndex = 23
        Me.txtLegelPhone.Text = ""
        '
        'lblLegelPhone
        '
        Me.lblLegelPhone.Location = New System.Drawing.Point(8, 280)
        Me.lblLegelPhone.Name = "lblLegelPhone"
        Me.lblLegelPhone.Size = New System.Drawing.Size(96, 16)
        Me.lblLegelPhone.TabIndex = 320
        Me.lblLegelPhone.Text = "法定代表人电话"
        Me.lblLegelPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContactEmail
        '
        Me.txtContactEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtContactEmail.Location = New System.Drawing.Point(352, 302)
        Me.txtContactEmail.MaxLength = 100
        Me.txtContactEmail.Name = "txtContactEmail"
        Me.txtContactEmail.Size = New System.Drawing.Size(392, 21)
        Me.txtContactEmail.TabIndex = 29
        Me.txtContactEmail.Text = ""
        '
        'txtContactMobile
        '
        Me.txtContactMobile.BackColor = System.Drawing.SystemColors.Window
        Me.txtContactMobile.Location = New System.Drawing.Point(608, 278)
        Me.txtContactMobile.MaxLength = 12
        Me.txtContactMobile.Name = "txtContactMobile"
        Me.txtContactMobile.Size = New System.Drawing.Size(136, 21)
        Me.txtContactMobile.TabIndex = 28
        Me.txtContactMobile.Text = ""
        '
        'lblContactEmail
        '
        Me.lblContactEmail.Location = New System.Drawing.Point(264, 304)
        Me.lblContactEmail.Name = "lblContactEmail"
        Me.lblContactEmail.Size = New System.Drawing.Size(72, 16)
        Me.lblContactEmail.TabIndex = 315
        Me.lblContactEmail.Text = "联系人Email"
        Me.lblContactEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContactMobile
        '
        Me.lblContactMobile.Location = New System.Drawing.Point(512, 280)
        Me.lblContactMobile.Name = "lblContactMobile"
        Me.lblContactMobile.Size = New System.Drawing.Size(80, 16)
        Me.lblContactMobile.TabIndex = 316
        Me.lblContactMobile.Text = "联系人手机"
        Me.lblContactMobile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtColledgeNum
        '
        Me.txtColledgeNum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtColledgeNum.Location = New System.Drawing.Point(352, 326)
        Me.txtColledgeNum.MaxLength = 6
        Me.txtColledgeNum.Name = "txtColledgeNum"
        Me.txtColledgeNum.Size = New System.Drawing.Size(136, 21)
        Me.txtColledgeNum.TabIndex = 31
        Me.txtColledgeNum.Text = "0"
        Me.txtColledgeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAttachColledge
        '
        Me.lblAttachColledge.Location = New System.Drawing.Point(264, 328)
        Me.lblAttachColledge.Name = "lblAttachColledge"
        Me.lblAttachColledge.Size = New System.Drawing.Size(72, 16)
        Me.lblAttachColledge.TabIndex = 301
        Me.lblAttachColledge.Text = "大专生人数"
        Me.lblAttachColledge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBachelorNum
        '
        Me.txtBachelorNum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtBachelorNum.Location = New System.Drawing.Point(608, 326)
        Me.txtBachelorNum.MaxLength = 6
        Me.txtBachelorNum.Name = "txtBachelorNum"
        Me.txtBachelorNum.Size = New System.Drawing.Size(136, 21)
        Me.txtBachelorNum.TabIndex = 32
        Me.txtBachelorNum.Text = "0"
        Me.txtBachelorNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAttachBancholer
        '
        Me.lblAttachBancholer.Location = New System.Drawing.Point(504, 328)
        Me.lblAttachBancholer.Name = "lblAttachBancholer"
        Me.lblAttachBancholer.Size = New System.Drawing.Size(72, 16)
        Me.lblAttachBancholer.TabIndex = 303
        Me.lblAttachBancholer.Text = "本科生人数"
        Me.lblAttachBancholer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMasterNum
        '
        Me.txtMasterNum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtMasterNum.Location = New System.Drawing.Point(352, 350)
        Me.txtMasterNum.MaxLength = 6
        Me.txtMasterNum.Name = "txtMasterNum"
        Me.txtMasterNum.Size = New System.Drawing.Size(136, 21)
        Me.txtMasterNum.TabIndex = 33
        Me.txtMasterNum.Text = "0"
        Me.txtMasterNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAttachMaster
        '
        Me.lblAttachMaster.Location = New System.Drawing.Point(264, 352)
        Me.lblAttachMaster.Name = "lblAttachMaster"
        Me.lblAttachMaster.Size = New System.Drawing.Size(72, 16)
        Me.lblAttachMaster.TabIndex = 302
        Me.lblAttachMaster.Text = "硕士生人数"
        Me.lblAttachMaster.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDoctorNum
        '
        Me.txtDoctorNum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtDoctorNum.Location = New System.Drawing.Point(608, 350)
        Me.txtDoctorNum.MaxLength = 6
        Me.txtDoctorNum.Name = "txtDoctorNum"
        Me.txtDoctorNum.Size = New System.Drawing.Size(136, 21)
        Me.txtDoctorNum.TabIndex = 34
        Me.txtDoctorNum.Text = "0"
        Me.txtDoctorNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAttachDoctor
        '
        Me.lblAttachDoctor.Location = New System.Drawing.Point(504, 352)
        Me.lblAttachDoctor.Name = "lblAttachDoctor"
        Me.lblAttachDoctor.Size = New System.Drawing.Size(72, 16)
        Me.lblAttachDoctor.TabIndex = 300
        Me.lblAttachDoctor.Text = "博士生人数"
        Me.lblAttachDoctor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmployeeAmount
        '
        Me.txtEmployeeAmount.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtEmployeeAmount.Location = New System.Drawing.Point(96, 350)
        Me.txtEmployeeAmount.MaxLength = 6
        Me.txtEmployeeAmount.Name = "txtEmployeeAmount"
        Me.txtEmployeeAmount.Size = New System.Drawing.Size(152, 21)
        Me.txtEmployeeAmount.TabIndex = 30
        Me.txtEmployeeAmount.Text = "0"
        Me.txtEmployeeAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblAttachMember
        '
        Me.lblAttachMember.Location = New System.Drawing.Point(8, 352)
        Me.lblAttachMember.Name = "lblAttachMember"
        Me.lblAttachMember.Size = New System.Drawing.Size(80, 16)
        Me.lblAttachMember.TabIndex = 306
        Me.lblAttachMember.Text = "员工总人数"
        Me.lblAttachMember.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFoundDate
        '
        Me.lblFoundDate.Location = New System.Drawing.Point(512, 72)
        Me.lblFoundDate.Name = "lblFoundDate"
        Me.lblFoundDate.Size = New System.Drawing.Size(56, 16)
        Me.lblFoundDate.TabIndex = 0
        Me.lblFoundDate.Text = "成立日期"
        Me.lblFoundDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFoundDate.Visible = False
        '
        'dtpFoundDate
        '
        Me.dtpFoundDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpFoundDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpFoundDate.Enabled = False
        Me.dtpFoundDate.Location = New System.Drawing.Point(608, 70)
        Me.dtpFoundDate.Name = "dtpFoundDate"
        Me.dtpFoundDate.Size = New System.Drawing.Size(136, 21)
        Me.dtpFoundDate.TabIndex = 8
        Me.dtpFoundDate.Visible = False
        '
        'clbTechType
        '
        Me.clbTechType.CheckOnClick = True
        Me.clbTechType.Location = New System.Drawing.Point(96, 120)
        Me.clbTechType.MultiColumn = True
        Me.clbTechType.Name = "clbTechType"
        Me.clbTechType.Size = New System.Drawing.Size(648, 36)
        Me.clbTechType.TabIndex = 11
        '
        'lblCorpTechType
        '
        Me.lblCorpTechType.Location = New System.Drawing.Point(8, 128)
        Me.lblCorpTechType.Name = "lblCorpTechType"
        Me.lblCorpTechType.Size = New System.Drawing.Size(80, 16)
        Me.lblCorpTechType.TabIndex = 0
        Me.lblCorpTechType.Text = "企业技术类型"
        Me.lblCorpTechType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboProprietorShip
        '
        Me.cboProprietorShip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboProprietorShip.ItemHeight = 12
        Me.cboProprietorShip.Location = New System.Drawing.Point(96, 94)
        Me.cboProprietorShip.Name = "cboProprietorShip"
        Me.cboProprietorShip.Size = New System.Drawing.Size(272, 20)
        Me.cboProprietorShip.TabIndex = 9
        '
        'lblCorpPropriateShip
        '
        Me.lblCorpPropriateShip.Location = New System.Drawing.Point(8, 96)
        Me.lblCorpPropriateShip.Name = "lblCorpPropriateShip"
        Me.lblCorpPropriateShip.Size = New System.Drawing.Size(72, 16)
        Me.lblCorpPropriateShip.TabIndex = 0
        Me.lblCorpPropriateShip.Text = "所有制类型"
        Me.lblCorpPropriateShip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboIndustryType
        '
        Me.cboIndustryType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboIndustryType.ItemHeight = 12
        Me.cboIndustryType.Location = New System.Drawing.Point(496, 94)
        Me.cboIndustryType.Name = "cboIndustryType"
        Me.cboIndustryType.Size = New System.Drawing.Size(248, 20)
        Me.cboIndustryType.TabIndex = 10
        '
        'lblCorpIndustryType
        '
        Me.lblCorpIndustryType.Location = New System.Drawing.Point(424, 96)
        Me.lblCorpIndustryType.Name = "lblCorpIndustryType"
        Me.lblCorpIndustryType.Size = New System.Drawing.Size(56, 16)
        Me.lblCorpIndustryType.TabIndex = 0
        Me.lblCorpIndustryType.Text = "行业类型"
        Me.lblCorpIndustryType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAddressRange
        '
        Me.cboAddressRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddressRange.ItemHeight = 12
        Me.cboAddressRange.Location = New System.Drawing.Point(96, 70)
        Me.cboAddressRange.Name = "cboAddressRange"
        Me.cboAddressRange.Size = New System.Drawing.Size(152, 20)
        Me.cboAddressRange.TabIndex = 6
        '
        'txtAddressDetail
        '
        Me.txtAddressDetail.Location = New System.Drawing.Point(256, 70)
        Me.txtAddressDetail.MaxLength = 50
        Me.txtAddressDetail.Name = "txtAddressDetail"
        Me.txtAddressDetail.Size = New System.Drawing.Size(240, 21)
        Me.txtAddressDetail.TabIndex = 7
        Me.txtAddressDetail.Text = ""
        '
        'lblCorpRegisterAddress
        '
        Me.lblCorpRegisterAddress.Location = New System.Drawing.Point(8, 72)
        Me.lblCorpRegisterAddress.Name = "lblCorpRegisterAddress"
        Me.lblCorpRegisterAddress.Size = New System.Drawing.Size(56, 16)
        Me.lblCorpRegisterAddress.TabIndex = 0
        Me.lblCorpRegisterAddress.Text = "注册地址"
        Me.lblCorpRegisterAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLoanCardID
        '
        Me.txtLoanCardID.Location = New System.Drawing.Point(608, 46)
        Me.txtLoanCardID.MaxLength = 18
        Me.txtLoanCardID.Name = "txtLoanCardID"
        Me.txtLoanCardID.Size = New System.Drawing.Size(136, 21)
        Me.txtLoanCardID.TabIndex = 5
        Me.txtLoanCardID.Text = ""
        '
        'lblCorpCardID
        '
        Me.lblCorpCardID.Location = New System.Drawing.Point(512, 48)
        Me.lblCorpCardID.Name = "lblCorpCardID"
        Me.lblCorpCardID.Size = New System.Drawing.Size(64, 16)
        Me.lblCorpCardID.TabIndex = 0
        Me.lblCorpCardID.Text = "贷款卡号码"
        Me.lblCorpCardID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRepID
        '
        Me.txtRepID.Location = New System.Drawing.Point(96, 46)
        Me.txtRepID.MaxLength = 10
        Me.txtRepID.Name = "txtRepID"
        Me.txtRepID.Size = New System.Drawing.Size(152, 21)
        Me.txtRepID.TabIndex = 3
        Me.txtRepID.Text = ""
        '
        'lblCorpRepreCardID
        '
        Me.lblCorpRepreCardID.Location = New System.Drawing.Point(8, 24)
        Me.lblCorpRepreCardID.Name = "lblCorpRepreCardID"
        Me.lblCorpRepreCardID.Size = New System.Drawing.Size(80, 16)
        Me.lblCorpRepreCardID.TabIndex = 0
        Me.lblCorpRepreCardID.Text = "法人代码证号码"
        Me.lblCorpRepreCardID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLoanID
        '
        Me.txtLoanID.Location = New System.Drawing.Point(360, 46)
        Me.txtLoanID.MaxLength = 7
        Me.txtLoanID.Name = "txtLoanID"
        Me.txtLoanID.Size = New System.Drawing.Size(136, 21)
        Me.txtLoanID.TabIndex = 4
        Me.txtLoanID.Text = ""
        '
        'lblCorpPaperID
        '
        Me.lblCorpPaperID.Location = New System.Drawing.Point(272, 48)
        Me.lblCorpPaperID.Name = "lblCorpPaperID"
        Me.lblCorpPaperID.Size = New System.Drawing.Size(64, 16)
        Me.lblCorpPaperID.TabIndex = 0
        Me.lblCorpPaperID.Text = "贷款证号码"
        Me.lblCorpPaperID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorpID
        '
        Me.txtCorpID.Location = New System.Drawing.Point(96, 22)
        Me.txtCorpID.MaxLength = 15
        Me.txtCorpID.Name = "txtCorpID"
        Me.txtCorpID.Size = New System.Drawing.Size(152, 21)
        Me.txtCorpID.TabIndex = 0
        Me.txtCorpID.Text = "深司字"
        '
        'lblCorpBusinessCode
        '
        Me.lblCorpBusinessCode.Location = New System.Drawing.Point(8, 48)
        Me.lblCorpBusinessCode.Name = "lblCorpBusinessCode"
        Me.lblCorpBusinessCode.Size = New System.Drawing.Size(80, 16)
        Me.lblCorpBusinessCode.TabIndex = 0
        Me.lblCorpBusinessCode.Text = "营业执照号码"
        Me.lblCorpBusinessCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(96, 326)
        Me.txtFax.MaxLength = 10
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(152, 21)
        Me.txtFax.TabIndex = 27
        Me.txtFax.Text = ""
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(352, 278)
        Me.txtContactNumber.MaxLength = 20
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(136, 21)
        Me.txtContactNumber.TabIndex = 26
        Me.txtContactNumber.Text = ""
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Location = New System.Drawing.Point(96, 302)
        Me.txtContactPerson.MaxLength = 10
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.Size = New System.Drawing.Size(152, 21)
        Me.txtContactPerson.TabIndex = 25
        Me.txtContactPerson.Text = ""
        '
        'txtRepreID
        '
        Me.txtRepreID.Location = New System.Drawing.Point(608, 230)
        Me.txtRepreID.MaxLength = 20
        Me.txtRepreID.Name = "txtRepreID"
        Me.txtRepreID.Size = New System.Drawing.Size(136, 21)
        Me.txtRepreID.TabIndex = 22
        Me.txtRepreID.Text = ""
        '
        'txtCashReceive
        '
        Me.txtCashReceive.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtCashReceive.Location = New System.Drawing.Point(352, 208)
        Me.txtCashReceive.MaxLength = 8
        Me.txtCashReceive.Name = "txtCashReceive"
        Me.txtCashReceive.Size = New System.Drawing.Size(136, 21)
        Me.txtCashReceive.TabIndex = 16
        Me.txtCashReceive.Text = ""
        Me.txtCashReceive.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRepreNation
        '
        Me.txtRepreNation.Location = New System.Drawing.Point(608, 256)
        Me.txtRepreNation.MaxLength = 10
        Me.txtRepreNation.Name = "txtRepreNation"
        Me.txtRepreNation.Size = New System.Drawing.Size(136, 21)
        Me.txtRepreNation.TabIndex = 21
        Me.txtRepreNation.Text = "中国"
        '
        'txtInvisibleAssets
        '
        Me.txtInvisibleAssets.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtInvisibleAssets.Location = New System.Drawing.Point(96, 208)
        Me.txtInvisibleAssets.MaxLength = 8
        Me.txtInvisibleAssets.Name = "txtInvisibleAssets"
        Me.txtInvisibleAssets.Size = New System.Drawing.Size(152, 21)
        Me.txtInvisibleAssets.TabIndex = 15
        Me.txtInvisibleAssets.Text = ""
        Me.txtInvisibleAssets.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRepresentative
        '
        Me.txtRepresentative.Location = New System.Drawing.Point(96, 254)
        Me.txtRepresentative.MaxLength = 10
        Me.txtRepresentative.Name = "txtRepresentative"
        Me.txtRepresentative.Size = New System.Drawing.Size(152, 21)
        Me.txtRepresentative.TabIndex = 20
        Me.txtRepresentative.Text = ""
        '
        'txtRealCapital
        '
        Me.txtRealCapital.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtRealCapital.Location = New System.Drawing.Point(608, 208)
        Me.txtRealCapital.MaxLength = 8
        Me.txtRealCapital.Name = "txtRealCapital"
        Me.txtRealCapital.Size = New System.Drawing.Size(136, 21)
        Me.txtRealCapital.TabIndex = 17
        Me.txtRealCapital.Text = ""
        Me.txtRealCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtRegCapital
        '
        Me.txtRegCapital.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtRegCapital.Location = New System.Drawing.Point(96, 182)
        Me.txtRegCapital.MaxLength = 8
        Me.txtRegCapital.Name = "txtRegCapital"
        Me.txtRegCapital.Size = New System.Drawing.Size(152, 21)
        Me.txtRegCapital.TabIndex = 14
        Me.txtRegCapital.Text = ""
        Me.txtRegCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtEvalInstitute
        '
        Me.txtEvalInstitute.Location = New System.Drawing.Point(352, 158)
        Me.txtEvalInstitute.MaxLength = 20
        Me.txtEvalInstitute.Name = "txtEvalInstitute"
        Me.txtEvalInstitute.Size = New System.Drawing.Size(392, 21)
        Me.txtEvalInstitute.TabIndex = 13
        Me.txtEvalInstitute.Text = ""
        '
        'txtCreditLevel
        '
        Me.txtCreditLevel.Location = New System.Drawing.Point(96, 158)
        Me.txtCreditLevel.MaxLength = 10
        Me.txtCreditLevel.Name = "txtCreditLevel"
        Me.txtCreditLevel.Size = New System.Drawing.Size(152, 21)
        Me.txtCreditLevel.TabIndex = 12
        Me.txtCreditLevel.Text = ""
        '
        'lblContactorFax
        '
        Me.lblContactorFax.Location = New System.Drawing.Point(8, 328)
        Me.lblContactorFax.Name = "lblContactorFax"
        Me.lblContactorFax.Size = New System.Drawing.Size(80, 16)
        Me.lblContactorFax.TabIndex = 0
        Me.lblContactorFax.Text = "联系人传真"
        Me.lblContactorFax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpContactNumber
        '
        Me.lblCorpContactNumber.Location = New System.Drawing.Point(264, 280)
        Me.lblCorpContactNumber.Name = "lblCorpContactNumber"
        Me.lblCorpContactNumber.Size = New System.Drawing.Size(72, 16)
        Me.lblCorpContactNumber.TabIndex = 0
        Me.lblCorpContactNumber.Text = "联系人电话"
        Me.lblCorpContactNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpContactor
        '
        Me.lblCorpContactor.Location = New System.Drawing.Point(8, 304)
        Me.lblCorpContactor.Name = "lblCorpContactor"
        Me.lblCorpContactor.Size = New System.Drawing.Size(56, 16)
        Me.lblCorpContactor.TabIndex = 0
        Me.lblCorpContactor.Text = "联系人"
        Me.lblCorpContactor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpEndDate
        '
        Me.dtpEndDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpEndDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpEndDate.Location = New System.Drawing.Point(608, 22)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(136, 21)
        Me.dtpEndDate.TabIndex = 2
        '
        'dtpStartDate
        '
        Me.dtpStartDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpStartDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.dtpStartDate.Location = New System.Drawing.Point(360, 22)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(136, 21)
        Me.dtpStartDate.TabIndex = 1
        '
        'lblCorpInvisibleAsset
        '
        Me.lblCorpInvisibleAsset.Location = New System.Drawing.Point(8, 208)
        Me.lblCorpInvisibleAsset.Name = "lblCorpInvisibleAsset"
        Me.lblCorpInvisibleAsset.Size = New System.Drawing.Size(104, 16)
        Me.lblCorpInvisibleAsset.TabIndex = 0
        Me.lblCorpInvisibleAsset.Text = "无形资产(万)"
        Me.lblCorpInvisibleAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpRepre
        '
        Me.lblCorpRepre.Location = New System.Drawing.Point(8, 256)
        Me.lblCorpRepre.Name = "lblCorpRepre"
        Me.lblCorpRepre.Size = New System.Drawing.Size(80, 16)
        Me.lblCorpRepre.TabIndex = 0
        Me.lblCorpRepre.Text = "法定代表人"
        Me.lblCorpRepre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpRepreID
        '
        Me.lblCorpRepreID.Location = New System.Drawing.Point(496, 232)
        Me.lblCorpRepreID.Name = "lblCorpRepreID"
        Me.lblCorpRepreID.Size = New System.Drawing.Size(120, 16)
        Me.lblCorpRepreID.TabIndex = 0
        Me.lblCorpRepreID.Text = "法定代表人身份证"
        Me.lblCorpRepreID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpRepreNation
        '
        Me.lblCorpRepreNation.Location = New System.Drawing.Point(504, 256)
        Me.lblCorpRepreNation.Name = "lblCorpRepreNation"
        Me.lblCorpRepreNation.Size = New System.Drawing.Size(96, 16)
        Me.lblCorpRepreNation.TabIndex = 0
        Me.lblCorpRepreNation.Text = "法定代表人国籍"
        Me.lblCorpRepreNation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpCreditLevel
        '
        Me.lblCorpCreditLevel.Location = New System.Drawing.Point(8, 160)
        Me.lblCorpCreditLevel.Name = "lblCorpCreditLevel"
        Me.lblCorpCreditLevel.Size = New System.Drawing.Size(56, 16)
        Me.lblCorpCreditLevel.TabIndex = 0
        Me.lblCorpCreditLevel.Text = "资质证书"
        Me.lblCorpCreditLevel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpEvalInstitute
        '
        Me.lblCorpEvalInstitute.Location = New System.Drawing.Point(264, 160)
        Me.lblCorpEvalInstitute.Name = "lblCorpEvalInstitute"
        Me.lblCorpEvalInstitute.Size = New System.Drawing.Size(56, 16)
        Me.lblCorpEvalInstitute.TabIndex = 0
        Me.lblCorpEvalInstitute.Text = "评估单位"
        Me.lblCorpEvalInstitute.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpRealAsset
        '
        Me.lblCorpRealAsset.Location = New System.Drawing.Point(512, 208)
        Me.lblCorpRealAsset.Name = "lblCorpRealAsset"
        Me.lblCorpRealAsset.Size = New System.Drawing.Size(80, 16)
        Me.lblCorpRealAsset.TabIndex = 0
        Me.lblCorpRealAsset.Text = "实收资本(万)"
        Me.lblCorpRealAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpCashArrived
        '
        Me.lblCorpCashArrived.Location = New System.Drawing.Point(248, 208)
        Me.lblCorpCashArrived.Name = "lblCorpCashArrived"
        Me.lblCorpCashArrived.Size = New System.Drawing.Size(104, 16)
        Me.lblCorpCashArrived.TabIndex = 0
        Me.lblCorpCashArrived.Text = "货币资金到位(万)"
        Me.lblCorpCashArrived.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpBusinessStartDate
        '
        Me.lblCorpBusinessStartDate.Location = New System.Drawing.Point(272, 24)
        Me.lblCorpBusinessStartDate.Name = "lblCorpBusinessStartDate"
        Me.lblCorpBusinessStartDate.Size = New System.Drawing.Size(88, 16)
        Me.lblCorpBusinessStartDate.TabIndex = 0
        Me.lblCorpBusinessStartDate.Text = "经营期限起始日"
        Me.lblCorpBusinessStartDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpBusinessEndDate
        '
        Me.lblCorpBusinessEndDate.Location = New System.Drawing.Point(512, 24)
        Me.lblCorpBusinessEndDate.Name = "lblCorpBusinessEndDate"
        Me.lblCorpBusinessEndDate.Size = New System.Drawing.Size(88, 16)
        Me.lblCorpBusinessEndDate.TabIndex = 0
        Me.lblCorpBusinessEndDate.Text = "经营期限截止日"
        Me.lblCorpBusinessEndDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorpRegisterAsset
        '
        Me.lblCorpRegisterAsset.Location = New System.Drawing.Point(8, 184)
        Me.lblCorpRegisterAsset.Name = "lblCorpRegisterAsset"
        Me.lblCorpRegisterAsset.Size = New System.Drawing.Size(80, 16)
        Me.lblCorpRegisterAsset.TabIndex = 0
        Me.lblCorpRegisterAsset.Text = "注册资本(万)"
        Me.lblCorpRegisterAsset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnReport
        '
        Me.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnReport.ImageIndex = 19
        Me.btnReport.ImageList = Me.ImageListBasic
        Me.btnReport.Location = New System.Drawing.Point(208, 484)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(120, 23)
        Me.btnReport.TabIndex = 46
        Me.btnReport.Text = "评审报告管理(&R)"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnSave.ImageIndex = 0
        Me.btnSave.ImageList = Me.ImageList1
        Me.btnSave.Location = New System.Drawing.Point(339, 484)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 47
        Me.btnSave.TabStop = False
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'MainMenu
        '
        Me.MainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuCheckMaterial, Me.mnuImportHistory, Me.mnuInputFinance, Me.mnuFinanceAnalyze})
        '
        'mnuCheckMaterial
        '
        Me.mnuCheckMaterial.Index = 0
        Me.mnuCheckMaterial.Text = "查验材料清单(&I)"
        '
        'mnuImportHistory
        '
        Me.mnuImportHistory.Index = 1
        Me.mnuImportHistory.Text = "导入历史数据(&O)"
        '
        'mnuInputFinance
        '
        Me.mnuInputFinance.Index = 2
        Me.mnuInputFinance.Text = "录入财务数据(&I)"
        '
        'mnuFinanceAnalyze
        '
        Me.mnuFinanceAnalyze.Index = 3
        Me.mnuFinanceAnalyze.Text = "财务分析(&A)"
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(425, 484)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.TabIndex = 48
        Me.btnCommit.TabStop = False
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FReviewBase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(794, 515)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.grpProjectHeader)
        Me.Controls.Add(Me.grpProjectBody)
        Me.Controls.Add(Me.btnReport)
        Me.MaximizeBox = False
        Me.Menu = Me.MainMenu
        Me.Name = "FReviewBase"
        Me.Text = "项目评审"
        Me.Controls.SetChildIndex(Me.btnReport, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.grpProjectBody, 0)
        Me.Controls.SetChildIndex(Me.grpProjectHeader, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.grpProjectHeader.ResumeLayout(False)
        Me.grpProjectBody.ResumeLayout(False)
        Me.tabReview.ResumeLayout(False)
        Me.pgProject.ResumeLayout(False)
        Me.grpProjectPassed.ResumeLayout(False)
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRequest.ResumeLayout(False)
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgCorpInfo.ResumeLayout(False)
        Me.groupbox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected ds As New DataSet()
    Protected dsBank As DataSet
    Protected CorpCode As String
    Protected Phase As String
    Protected bFormLoad As Boolean = False
    Protected bIsChanged As Boolean = False
    Protected ProCode As String
    Protected SysDate As Date '系统日期
    Protected CorpName As String
    ' Protected Project_code, Phase_Code As String '从窗体frmProjectCorpInfo选择的要导入的项目编码和阶段值

    Private Sub FReviewBase_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        '    Me.InitCorpCodeAndPhase()
        '    Me.InitComboBox()
        '    Me.InitDataSet()
        '    Me.GetData()
        '    Me.bFormLoad = True
        'Catch ex As Exception
        '    ExceptionHandler.ShowMessageBox(ex)
        'End Try
      
    End Sub

#Region "初始化部分"
    '初始化企业编码与阶段
    Protected Overridable Sub InitCorpCodeAndPhase()
        'Dim dt As DataTable = gWs.GetProjectInfo("{project_code='" & Me.getProjectCode & "'}").Tables("project")
        'If Not dt.Rows.Count = 0 Then
        '    Me.CorpCode = dt.Rows(0).Item("corporation_code")
        'End If
        Me.ProCode = Me.getProjectCode()
        Me.CorpCode = Me.ProCode.Substring(0, 5)
        Me.Phase = "评审"
        SysDate = gWs.GetSysTime()
        Dim dt As DataTable = gWs.GetCommonQueryInfo("select corporation_name from corporation where corporation_code='" & CorpCode & "'").Tables(0)
        If Not dt.Rows.Count = 0 Then
            Me.CorpName = dt.Rows(0).Item("corporation_name")
        End If
    End Sub
    '初始化或绑定窗体中的ComboBox
    Protected Overridable Sub InitComboBox()
        '申请贷款银行
        dsBank = gWs.GetBankInfo("%", "%")
        dsBank.Tables("bank").DefaultView.Sort = "bank_name"
        Me.cboApplyBank.DataSource = dsBank.Tables("bank")
        Me.cboApplyBank.DisplayMember = "bank_name"
        Me.cboApplyBank.ValueMember = "bank_code"
        Me.dsBank.Tables("bank_branch").DefaultView.Sort = "branch_bank_name"
        Me.cboApplyBranch.DataSource = dsBank.Tables("bank_branch").DefaultView
        Me.cboApplyBranch.DisplayMember = "branch_bank_name"
        Me.cboApplyBranch.ValueMember = "branch_bank_code"
        AddHandler cboApplyBank.SelectedIndexChanged, AddressOf BankChanged
        BankChanged(Nothing, Nothing)
        '申请业务品种
        Me.cboApplyServiceType.DataSource = ServiceTypeDS.Tables("TServiceType")
        Me.cboApplyServiceType.DisplayMember = "service_type"
        Me.cboApplyServiceType.ValueMember = "service_type"
        '推荐类型
        Me.cboRecommendType.DataSource = RecommendTypeDS.Tables("TRecommendType")
        Me.cboRecommendType.DisplayMember = "recommend_type"
        Me.cboRecommendType.ValueMember = "recommend_type"
        '区域
        Me.cboAddressRange.DataSource = DistrictDS.Tables("TDistrict")
        Me.cboAddressRange.DisplayMember = "district_name"
        Me.cboAddressRange.ValueMember = "district_name"
        '技术类型
        Me.clbTechType.DataSource = TechnologyTypeDS.Tables("TTechnologyType")
        Me.clbTechType.DisplayMember = "technology_type"
        Me.clbTechType.ValueMember = "technology_type_code"
        AddHandler clbTechType.ItemCheck, AddressOf clbTechType_ItemCheck
        '所有制类型
        Me.cboProprietorShip.DataSource = ProprietorShipDS.Tables("TProprietorshipType")
        Me.cboProprietorShip.DisplayMember = "proprietorship_type"
        Me.cboProprietorShip.ValueMember = "proprietorship_type"
        '行业类型
        Me.cboIndustryType.DataSource = IndustryTypeDS.Tables("TIndustryType")
        Me.cboIndustryType.DisplayMember = "industry_type"
        Me.cboIndustryType.ValueMember = "industry_type"
        '货币类型
        Me.cboMoneyType.DataSource = gWs.GetMoneyInfo("%").Tables(0)
        Me.cboMoneyType.DisplayMember = "name"
        Me.cboMoneyType.ValueMember = "money_id"
    End Sub
    '根据银行编码初始化支行的ComboBox
    Protected Sub BankChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.cboApplyBranch.DataBindings.Clear()
        Me.dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code='" & Me.cboApplyBank.SelectedValue & "'"
        Me.dsBank.Tables("bank_branch").DefaultView.Sort = "branch_bank_name"
    End Sub
    '初始化ds
    Protected Overridable Sub InitDataSet()
        Try
            '项目信息
            ds.Merge(gWs.GetProjectInfo("{project_code='" + Me.getProjectCode + "'}").Tables("project"))
            '企业代码证等信息
            ds.Merge(gWs.GetcorporationInfo("{corporation_code='" + Me.CorpCode + "'}", "null").Tables("Corporation"))

            '加入项目企业信息表 如果不存在评审数据，就取得初审数据
            Dim dsTemp As DataSet
            dsTemp = gWs.FetchProjectCorporation(Me.getProjectCode, Me.CorpCode, "1", "评审")
            If Not dsTemp.Tables("TProjectCorporation").Rows.Count = 0 Then
                ds.Merge(dsTemp.Tables("TProjectCorporation"))
            Else
                ds.Merge(gWs.FetchProjectCorporation(Me.getProjectCode, Me.CorpCode, "1", "初审").Tables("TProjectCorporation"))
            End If

            '加入过去的项目信息
            ds.Merge(Me.GetProjRejectCode())
            '加入银行与支行两张表
            ds.Merge(gWs.GetBankInfo("%", "%"))
            ds.Relations.Add("RBank", ds.Tables("bank").Columns("bank_code"), ds.Tables("OldProject").Columns("apply_bank"))
            ds.Tables("OldProject").Columns.Add("CBank", GetType(System.String), "parent(RBank).bank_name")
            '合作区意见表
            ds.Merge(gWs.GetCooperateOpinionInfo("", Me.getProjectCode()).Tables("cooperate_organization_opinion"))
            If ds.Tables("cooperate_organization_opinion").Rows.Count = 0 Then
                Dim dr As DataRow = ds.Tables("cooperate_organization_opinion").NewRow()
                dr.Item("project_code") = Me.getProjectCode()
                dr.Item("recommend_sum") = 0
                dr.Item("recommend_date") = gWs.GetSysTime()
                ds.Tables("cooperate_organization_opinion").Rows.Add(dr)
                ds.AcceptChanges()
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '获取项目编码不为code的项目表,目的是为了找到当前项目企业过去的担保信息
    Protected Overridable Function GetProjRejectCode() As DataTable
        Dim dt As DataTable
        dt = gWs.GetProjectInfo("{corporation_code='" + Me.CorpCode + "' AND project_code <> '" + Me.getProjectCode + "'}").Tables(0)
        dt.TableName = "OldProject"
        Return dt
    End Function
    '复制最后输入的咨询信息及部分企业信息
    Private Sub CopyFinalConsultaion()
        Dim drProjectCorporation, drConsult, drCorporation As DataRow
        Try
            Dim dt As DataTable = gWs.GetcorporationInfo("null", "{corporation_code = '" & Me.CorpCode & "' ORDER BY serial_num DESC }").Tables("consultation")
            If dt.Rows.Count = 0 Then Return
            drConsult = dt.Rows(0)
            drCorporation = ds.Tables("Corporation").Rows(0)
            Dim nowTime As DateTime = gWs.GetSysTime()
            drProjectCorporation = ds.Tables("TProjectCorporation").NewRow
            With drProjectCorporation
                .Item("district_name") = drConsult.Item("district_name")                '所在区名
                .Item("register_address") = drConsult.Item("register_address")          '注册地址
                .Item("industry_type") = drConsult.Item("industry_type")                '行业类型
                .Item("proprietorship_type") = drConsult.Item("proprietorship_type")    '所有制类型
                .Item("total_capital_stock") = drConsult.Item("total_assets")           '总资产 
                .Item("register_capital") = drConsult.Item("register_capital")          '注册资本
                .Item("contact_person") = drConsult.Item("contact_person")              '联系人 
                .Item("contact_phone") = drConsult.Item("phone_num")                    '联系电话
                .Item("fax") = drConsult.Item("fax")                                    '传真 
                .Item("contact_mobile") = drConsult.Item("mobile")                      '联系人手机
                .Item("e_mail") = drConsult.Item("e_mail")                              '企业e_mail
                If Not drCorporation.Item("found_date") Is DBNull.Value Then
                    .Item("found_date") = drCorporation.Item("found_date")                  '成立日期
                Else
                    .Item("found_date") = nowTime                                           '成立日期
                End If
                If Not drCorporation.Item("found_date") Is DBNull.Value Then
                    .Item("business_start_date") = drCorporation.Item("found_date")                  '经营开始日 
                Else
                    .Item("business_start_date") = nowTime                                           '经营开始日   避免绑定失效
                End If

                .Item("business_end_date") = drCorporation.Item("business_end_date")       '经营截止日
                .Item("technology_type") = drCorporation.Item("technology_type")            '科技类型
                .Item("business_licence_code") = drCorporation.Item("business_licence_code") '企业营业执照代码
                .Item("corp_paper_id") = drCorporation.Item("corp_paper_id")                 '企业法人代码证号码
                .Item("loan_paper_id") = drCorporation.Item("loan_paper_id")                 '贷款证号码
                .Item("loan_card_id") = drCorporation.Item("loan_card_id")                   '贷款卡号码
                .Item("legal_representative") = drCorporation.Item("legal_representative")   '法人代表
                .Item("legal_representative_phone") = drCorporation.Item("legal_representative_phone")   '法人电话
                .Item("legal_representative_mobile") = drCorporation.Item("legal_representative_mobile") '法人手机

            End With
            ds.Tables("TProjectCorporation").Rows.Add(drProjectCorporation)
            ds.AcceptChanges()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Protected bmProjectCorporation As BindingManagerBase
    Protected bmProject As BindingManagerBase
    Protected bmCooperate As BindingManagerBase
    '绑定项目信息表
    Protected Overridable Sub GetProjectData()
        Dim binding As Binding
        '项目表project       
        Me.cboApplyServiceType.DataBindings.Add("SelectedValue", ds, "project.apply_service_type") '申请业务品种 
        Me.cboApplyBank.DataBindings.Add("SelectedValue", ds, "project.apply_bank")           '推荐银行
        Me.BankChanged(Nothing, Nothing) '更新支行ComboBox的内容
        Me.cboApplyBranch.DataBindings.Add("SelectedValue", ds, "project.apply_branch_bank")  '推荐支行
        binding = New Binding("Text", ds, "project.apply_sum")
        AddHandler binding.Format, AddressOf DecimalToCurrency
        AddHandler binding.Parse, AddressOf CurrencyToDecimal
        Me.txtApplySum.DataBindings.Add(binding)                                                       '申请金额
        Me.nuTerm.DataBindings.Add("Text", ds, "project.apply_term")                      '申请期限 
        Me.txtPurpose.DataBindings.Add("Text", ds, "project.purpose")                     '目的
        Me.dtpApplyDate.DataBindings.Add("Text", ds, "project.apply_date")                '申请日期 
        Me.cboRecommendType.DataBindings.Add("SelectedValue", ds, "project.recommend_type") '推荐人类型
        Select Case Me.cboRecommendType.SelectedValue.ToString()
            Case "员工开发"
                Me.txtRecommendPerson.Visible = False
                Me.cboRecommendItems.Visible = False
            Case "合作银行"
                Me.cboRecommendItems.DataBindings.Add("SelectedValue", ds, "project.recommend_person")     '推荐人
            Case "回头客户"
                Me.cboRecommendItems.DataBindings.Add("SelectedValue", ds, "project.recommend_person")     '推荐人
            Case "合作区局"
                Me.cboRecommendItems.DataBindings.Add("SelectedValue", ds, "project.recommend_person")     '推荐人
            Case Else '其它，关联企业
                Me.txtRecommendPerson.DataBindings.Add("Text", ds, "project.recommend_person")     '推荐人
        End Select
        Me.chkIsFirstLoan.DataBindings.Add("Checked", ds, "project.is_first_loan")     '是否首次贷款

        bmProject = BindingContext(ds, "project")
        AddHandler bmProject.CurrentChanged, AddressOf BindDataChanged

    End Sub
    '绑定项目企业信息表
    Protected Overridable Sub GetProjectCorporationData()
        Dim binding As Binding
        '项目企业信息还不存在(则复制咨询信息)
        If ds.Tables("TProjectCorporation").Rows.Count = 0 Then
            CopyFinalConsultaion()
        End If
        '项目企业表project_corporation    
        Me.dtpStartDate.DataBindings.Add("Text", ds, "TProjectCorporation.business_start_date")  '经营开始日
        Me.dtpEndDate.DataBindings.Add("Text", ds, "TProjectCorporation.business_end_date")      '经营截止日
        Me.txtCreditLevel.DataBindings.Add("Text", ds, "TProjectCorporation.credit_grade")          '资信等级 
        Me.txtEvalInstitute.DataBindings.Add("Text", ds, "TProjectCorporation.evaluate_institution") '评分单位 
        Me.cboAddressRange.DataBindings.Add("SelectedValue", ds, "TProjectCorporation.district_name") '地址所在区名字
        Me.txtAddressDetail.DataBindings.Add("Text", ds, "TProjectCorporation.register_address")      '地址明细
        Me.cboIndustryType.DataBindings.Add("SelectedValue", ds, "TProjectCorporation.industry_type") '行业类型
        Me.cboMoneyType.DataBindings.Add("SelectedValue", ds, "TProjectCorporation.moneyID")          '货币类型
        If Not ds.Tables("TProjectCorporation").Rows(0).Item("technology_type") Is DBNull.Value Then
            int_TechTypes = ds.Tables("TProjectCorporation").Rows(0).Item("technology_type")              '科技类型
        Else
            int_TechTypes = 0
        End If
        Me.InitTechType()
        Me.cboProprietorShip.DataBindings.Add("SelectedValue", ds, "TProjectCorporation.proprietorship_type") '所有制类型
        binding = New Binding("Text", ds, "TProjectCorporation.register_capital")
        AddHandler binding.Format, AddressOf DecimalToCurrency
        AddHandler binding.Parse, AddressOf CurrencyToDecimal
        Me.txtRegCapital.DataBindings.Add(binding)                              '注册资本
        binding = New Binding("Text", ds, "TProjectCorporation.invisible_assets")
        AddHandler binding.Format, AddressOf DecimalToCurrency
        AddHandler binding.Parse, AddressOf CurrencyToDecimal
        Me.txtInvisibleAssets.DataBindings.Add(binding)                         '无形资产
        binding = New Binding("Text", ds, "TProjectCorporation.real_capital")
        AddHandler binding.Format, AddressOf DecimalToCurrency
        AddHandler binding.Parse, AddressOf CurrencyToDecimal
        Me.txtRealCapital.DataBindings.Add(binding)                             '实收资本
        binding = New Binding("Text", ds, "TProjectCorporation.cash_receive")
        AddHandler binding.Format, AddressOf DecimalToCurrency
        AddHandler binding.Parse, AddressOf CurrencyToDecimal
        Me.txtCashReceive.DataBindings.Add(binding)                             '货币资金到位

        Me.txtRepresentative.DataBindings.Add("Text", ds, "TProjectCorporation.legal_representative") '法人
        Me.txtRepreNation.DataBindings.Add("Text", ds, "TProjectCorporation.nationality")             '法人国籍
        Me.txtRepreID.DataBindings.Add("Text", ds, "TProjectCorporation.id_card")                     '法人身份证号 
        Me.txtLegelPhone.DataBindings.Add("Text", ds, "TProjectCorporation.legal_representative_phone")  '法人电话
        Me.txtLegelMobile.DataBindings.Add("Text", ds, "TProjectCorporation.legal_representative_mobile") '法人手机
        'Me.txtAttorney.DataBindings.Add("Text", ds, "TProjectCorporation.attorney")                  '授权人
        'Me.txtAttorneyNation.DataBindings.Add("Text", ds, "TProjectCorporation.attorney_nationality")
        Me.txtEmployeeAmount.DataBindings.Add("Text", ds, "TProjectCorporation.employee_amount") '员工人数
        Me.txtDoctorNum.DataBindings.Add("Text", ds, "TProjectCorporation.docter")            '博士 
        Me.txtMasterNum.DataBindings.Add("Text", ds, "TProjectCorporation.master")            '硕士 
        Me.txtBachelorNum.DataBindings.Add("Text", ds, "TProjectCorporation.bachelor")        '大学
        Me.txtColledgeNum.DataBindings.Add("Text", ds, "TProjectCorporation.college")         '大专
        Me.txtContactPerson.DataBindings.Add("Text", ds, "TProjectCorporation.contact_person") '联系人
        Me.txtContactNumber.DataBindings.Add("Text", ds, "TProjectCorporation.contact_phone")  '联系电话
        Me.txtFax.DataBindings.Add("Text", ds, "TProjectCorporation.fax")                      '联系人传真
        Me.txtContactEmail.DataBindings.Add("Text", ds, "TProjectCorporation.e_mail")          '联系人e-mail
        Me.txtContactMobile.DataBindings.Add("Text", ds, "TProjectCorporation.contact_mobile")

        Me.txtLoanCardID.DataBindings.Add("Text", ds, "TProjectCorporation.loan_card_id")        '贷款证卡号
        Me.txtLoanID.DataBindings.Add("Text", ds, "TProjectCorporation.loan_paper_id")           '贷款证号码
        Me.txtCorpID.DataBindings.Add("Text", ds, "TProjectCorporation.business_licence_code")   '营业执照
        Me.txtRepID.DataBindings.Add("Text", ds, "TProjectCorporation.corp_paper_id")            '法人代码证号码
        If ds.Tables("TProjectCorporation").Rows(0).Item("found_date") Is DBNull.Value Then
            ds.Tables("TProjectCorporation").Rows(0).Item("found_date") = gWs.GetSysTime()
        End If
        Me.dtpFoundDate.DataBindings.Add("Text", ds, "TProjectCorporation.found_date")           '成立日期
        Me.bmProjectCorporation = BindingContext(ds, "TProjectCorporation")
        AddHandler bmProjectCorporation.CurrentChanged, AddressOf BindDataChanged
    End Sub

    Protected Sub GetData()
        Me.txtProjectCode.Text = Me.getProjectCode()
        Me.txtCorporationName.Text = Me.getCorporationName()
        Me.txtProjectPhase.Text = Me.Phase
        Me.dgProject.DataSource = ds.Tables("OldProject").DefaultView

        Me.GetProjectData()
        Me.GetProjectCorporationData()

        Dim binding As Binding
        '合作信息表cooperate_organization_opinion
        binding = New Binding("Text", ds, "cooperate_organization_opinion.recommend_sum")            '推荐金额  
        AddHandler binding.Format, AddressOf DecimalToCurrency
        AddHandler binding.Parse, AddressOf CurrencyToDecimal
        Me.txtRecommendSum.DataBindings.Add(binding)
        Me.txtCooperateOpinion.DataBindings.Add("Text", ds, "cooperate_organization_opinion.opinion")   '合作意见
        Me.dtpRecommend.DataBindings.Add("Text", ds, "cooperate_organization_opinion.recommend_date")  '推荐日期
        bmCooperate = BindingContext(ds, "cooperate_organization_opinion")
        AddHandler bmCooperate.CurrentChanged, AddressOf BindDataChanged

        Me.tabReview.SelectedTab = Me.pgCorpInfo        '最先显示的为企业表
    End Sub
    '浮点到货币字符串
    Protected Sub DecimalToCurrency(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If Not e.DesiredType Is GetType(String) Then
            Exit Sub
        End If
        If e.Value Is System.DBNull.Value Then
            Exit Sub
        End If
        e.Value = Numeric2Currency(e.Value)
    End Sub
    '货币字符串到浮点
    Protected Sub CurrencyToDecimal(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If Not e.DesiredType Is GetType(Decimal) Then
            Exit Sub
        End If
        e.Value = Currency2Numeric(e.Value)
    End Sub
    '数据改变
    Protected Sub BindDataChanged(ByVal sender As Object, ByVal e As EventArgs)
        If Me.bFormLoad Then
            bIsChanged = True
        End If
    End Sub

#End Region

#Region "菜单与按钮部分"

    '查验材料清单
    Private Sub mnuCheckMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCheckMaterial.Click
        Dim frm As New frmInspectMaterial()
        frm.OpenApplyTool(Me.getProjectCode(), Me.getCorporationName(), Me.getWorkFlowID(), Me.getTaskID(), Me, UserName)
    End Sub

    '导入历史财务数据
    Private Sub mnuImportHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImportHistory.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim f As New FImportFinance(Me.getProjectCode(), "评审", Me.getCorporationName())
            f.AllowTransparency = False
            f.ShowDialog()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        ''If MessageBox.Show("真的要选择历史数据来覆盖当前数据吗？", "选择历史数据", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
        'Dim frm As New frmProjectCorpInfo(CorpCode)
        'frm.ShowDialog()
        'Project_code = frm.Project_code
        'Phase_Code = frm.Phase_Code
        'If Project_code = "" Or Phase_Code = "" Or (Project_code = Me.getProjectCode() And Phase_Code = "评审") Then
        '    Return
        'End If

        'Try
        '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        '    If Not ds.Tables("TProjectCorporation").Rows.Count = 0 Then
        '        'MsgBox("是否覆盖已存在的数据？", MsgBoxStyle.OKCancel Or MsgBoxStyle.Question, "项目评审")
        '        If SWDialogBox.MessageBox.Show("!1002") = MsgBoxResult.No Then
        '            Return
        '        End If
        '    End If
        '    If Not CopyTrialDataToEval() Then
        '        Return
        '    End If
        '    Me.mnuImportHistory.Enabled = False
        '    Me.InitTechType()              '科技类型再次初始化
        'Catch ex As Exception
        '    ExceptionHandler.ShowMessageBox(ex)
        'Finally
        '    Me.Cursor = System.Windows.Forms.Cursors.Default
        'End Try
        'SWDialogBox.MessageBox.Show("$OperateSucceed")
    End Sub
    ''复制信息
    'Private Function CopyTrialDataToEval() As Boolean
    '    Dim ret As Boolean = True
    '    '复制项目企业信息
    '    If Not CopyProjectCorporation() Then ret = False
    '    Me.bIsChanged = True
    '    '复制财务数据
    '    Try
    '        If Convert.ToString(gWs.ImportFinanceData(Me.CorpCode, Project_code, Phase_Code, String.Empty, Me.getProjectCode, "评审", UserName, gWs.GetSysTime(), True)) <> "1" Then
    '            ret = False
    '        End If
    '    Catch ex As Exception
    '        ExceptionHandler.ShowMessageBox(ex)
    '    End Try
    '    Return ret
    'End Function
    ''复制项目企业信息
    'Private Function CopyProjectCorporation() As Boolean
    '    Dim dsTemp As DataSet
    '    Dim dt As DataTable
    '    Dim dr As DataRow
    '    Dim i As Integer

    '    Try
    '        dt = gWs.FetchProjectCorporation(Project_code, Me.CorpCode, "1", "初审").Tables("TProjectCorporation")
    '        If Not dt.Rows.Count = 0 Then
    '            If Not ds.Tables("TProjectCorporation").Rows.Count = 0 Then
    '                With ds.Tables("TProjectCorporation").Rows(0)
    '                    For i = 0 To ds.Tables("TProjectCorporation").Columns.Count - 1
    '                        .Item(i) = dt.Rows(0).Item(i)
    '                    Next
    '                    Me.int_TechTypes = dt.Rows(0).Item("technology_type")
    '                    .Item("technology_type") = Me.int_TechTypes
    '                    .Item("phase") = "初审"
    '                    .Item("project_code") = Me.getProjectCode()
    '                    .Item("create_person") = UserName
    '                    .Item("create_date") = gWs.GetSysTime
    '                End With
    '            End If
    '        End If
    '    Catch ex As Exception
    '        ExceptionHandler.ShowMessageBox(ex)
    '    End Try
    '    Return True
    'End Function

    '录入财务数据
    Private Sub mnuInputFinance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInputFinance.Click
        Dim frm As New frmFinanceManage(Me.getProjectCode(), Me.getCorporationName(), Me.CorpCode, "评审", Me)
        frm.AllowTransparency = False
        frm.ShowDialog()
    End Sub
    '财务分析
    Private Sub mnuFinanceAnalyze_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFinanceAnalyze.Click
        If Not Me.SaveData() Then       'added by hute 2004-2-10
            Return
        End If
        Dim dsTemp As DataSet
        Try
            dsTemp = gWs.GetAccount("{project_code = '" & Me.getProjectCode() & "' AND phase = '评审'}")
            If dsTemp.Tables(0).Rows.Count = 0 Then
                'MessageBox.Show("尚不存在该项目的财务数据，无法进行财务分析。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                SWDialogBox.MessageBox.Show("$1007", "财务数据")
                Return
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Dim frm As New FFinancialAnalysis()
        frm.SetEditState(False)
        frm.ShowDialog(Me.getProjectCode(), Me.CorpCode, "评审")
    End Sub
    '保存按钮按下
    Protected Overridable Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
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
    '提交按钮按下 
    Protected Overridable Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        'MsgBox("请确认提交！", MsgBoxStyle.OKCancel Or MsgBoxStyle.Question, "项目评审") 
        If SWDialogBox.MessageBox.Show("?1000", "提交") <> MsgBoxResult.Yes Then
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            If Not Me.SaveData() Then
                Return
            End If
            '没有上载评审报告，则不能提交
            If Not LoadedReport() Then
                SWDialogBox.MessageBox.Show("$1005", "评审报告")
                Return
            End If
            Dim strResult As String
            strResult = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), "", UserName)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "项目评审")
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
    '退出按钮按下
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
    '可重写，类型不同
    Protected Overridable Function LoadedReport() As Boolean
        Return True
    End Function

    Protected Function ReportExisted(ByVal fileType As String, ByVal fileCode As String) As Boolean
        Dim ds As DataSet = VouchService.GetProjectFile(Me.getProjectCode, fileCode, fileType)
        If ds.Tables("TProjectFile").Rows.Count = 0 Then
            Return False
        End If
        Dim i As Integer
        For i = 0 To ds.Tables("TProjectFile").Rows.Count - 1
            If IsDBNull(ds.Tables("TProjectFile").Rows(0).Item("relation_num")) Then
                Return False
            End If
        Next

        Return True
    End Function

#End Region

#Region "保存部分"

    Protected Overridable Function SaveData() As Boolean
        Try
            If Not Me.CheckData() Then
                Return False
            End If
            If Not Me.SaveProjectCorporation() Then
                Return False
            End If
            If Not Me.SaveProject() Then
                Return False
            End If
            If Not Me.SaveCorporation() Then
                Return False
            End If
            If Not Me.SaveCooperate() Then
                Return False
            End If
            Me.bIsChanged = False       '保存成功
            Return True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '数据校验 成功返回真
    Protected Overridable Function CheckData() As Boolean
        '总员工人数不得少于大专生、本科、硕士、博士之和
        Dim reg As New System.Text.RegularExpressions.Regex("^\d+$")
        Dim EmployeeAmount, ColledgeNum, BachelorNum, Masternum, DoctorNum As Integer
        EmployeeAmount = CInt(IIf(reg.Match(Me.txtEmployeeAmount.Text).Success, reg.Match(Me.txtEmployeeAmount.Text).Value, 0))
        ColledgeNum = CInt(IIf(reg.Match(Me.txtColledgeNum.Text).Success, reg.Match(Me.txtColledgeNum.Text).Value, 0))
        BachelorNum = CInt(IIf(reg.Match(Me.txtBachelorNum.Text).Success, reg.Match(Me.txtBachelorNum.Text).Value, 0))
        Masternum = CInt(IIf(reg.Match(Me.txtMasterNum.Text).Success, reg.Match(Me.txtMasterNum.Text).Value, 0))
        DoctorNum = CInt(IIf(reg.Match(Me.txtDoctorNum.Text).Success, reg.Match(Me.txtDoctorNum.Text).Value, 0))

        If EmployeeAmount < ColledgeNum + BachelorNum + Masternum + DoctorNum Then
            'MessageBox.Show("输入的员工总人数起码不能小于大专，本科，硕士，博士的人数之和。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1008", "员工总人数", "大专，本科，硕士，博士的人数之和")
            Me.txtEmployeeAmount.Focus()
            Return False
        End If
        If Me.cboRecommendType.SelectedValue.ToString() = "合作区局" And Me.cboRecommendItems.Text = "" Then
            SWDialogBox.MessageBox.Show("$1007", "合作区局")
            Return False
        End If
        Return True
    End Function
    '保存project_corporation表
    Protected Overridable Function SaveProjectCorporation() As Boolean
        Dim strResult As String
        Dim dsTemp As DataSet
        Try
            dsTemp = gWs.FetchProjectCorporation(Me.getProjectCode(), CorpCode, "1", "评审")
            If dsTemp.Tables("TProjectCorporation").Rows.Count > 0 Then
                With dsTemp.Tables("TProjectCorporation").Rows(0)
                    .Item("business_start_date") = Me.dtpStartDate.Value                 '经营起始日
                    .Item("business_end_date") = Me.dtpEndDate.Value                     '经营截止日
                    '.Item("found_date") = Me.dtpFoundDate.Value                         '企业创建日
                    '.Item("technology_level") = Me.txtTechLevel.Text
                    '.Item("business_scope") = Me.txtBizScope.Text
                    '.Item("leading_product") = Me.txtLeadProduct.Text
                    '.Item("chairman") = Me.txtChairMan.Text  '董事长

                    .Item("district_name") = Me.cboAddressRange.Text                     '企业所在区 
                    .Item("register_address") = Me.txtAddressDetail.Text                 '企业所在地址明细 
                    .Item("industry_type") = Me.cboIndustryType.Text                     '行业类型
                    .Item("moneyID") = Me.cboMoneyType.SelectedValue                     '货币类型 
                    .Item("proprietorship_type") = Me.cboProprietorShip.Text             '所有制类型 
                    .Item("technology_type") = Me.int_TechTypes                          '科技类型

                    .Item("loan_paper_id") = Me.txtLoanID.Text                           '贷款证号码
                    .Item("loan_card_id") = Me.txtLoanCardID.Text                        '贷款卡号码 
                    .Item("business_licence_code") = Me.txtCorpID.Text                   '营业执照号码 
                    .Item("corp_paper_id") = Me.txtRepID.Text                            '企业法人代码证号码
                    'Try
                    '    .Item("total_capital_stock") = Currency2Double(Me.txtTotalCapital.Text)
                    'Catch
                    'End Try
                    .Item("credit_grade") = Me.txtCreditLevel.Text                       '资信等级
                    .Item("evaluate_institution") = Me.txtEvalInstitute.Text             '评分单位
                    Try
                        .Item("register_capital") = Currency2Double(Me.txtRegCapital.Text) '注册资金
                    Catch
                    End Try
                    Try
                        .Item("real_capital") = Currency2Double(Me.txtRealCapital.Text)   '实收资本
                    Catch
                    End Try
                    Try
                        .Item("cash_receive") = Currency2Double(Me.txtCashReceive.Text)   '现金资本
                    Catch
                    End Try
                    Try
                        .Item("invisible_assets") = Currency2Double(Me.txtInvisibleAssets.Text) '无形资产
                    Catch
                    End Try
                    .Item("legal_representative") = Me.txtRepresentative.Text              '法人代表
                    .Item("id_card") = Me.txtRepreID.Text                                  '法人身份证号
                    .Item("nationality") = Me.txtRepreNation.Text                          '法人国籍
                    .Item("legal_representative_phone") = Me.txtLegelPhone.Text            '法人电话 
                    .Item("legal_representative_mobile") = Me.txtLegelMobile.Text          '法人手机
                    If Me.txtEmployeeAmount.Text <> "" Then
                        .Item("employee_amount") = Int32.Parse(Me.txtEmployeeAmount.Text)  '员工人数 
                    End If
                    If Me.txtColledgeNum.Text <> "" Then
                        .Item("college") = Int32.Parse(Me.txtColledgeNum.Text)             '大专生 
                    End If
                    If Me.txtBachelorNum.Text <> "" Then
                        .Item("bachelor") = Int32.Parse(Me.txtBachelorNum.Text)            '本科生
                    End If
                    If Me.txtMasterNum.Text <> "" Then
                        .Item("master") = Int32.Parse(Me.txtMasterNum.Text)                '硕士生
                    End If
                    If Me.txtDoctorNum.Text <> "" Then
                        .Item("docter") = Int32.Parse(Me.txtDoctorNum.Text)                '博士生
                    End If
                    .Item("contact_person") = Me.txtContactPerson.Text                     '联系人
                    .Item("contact_phone") = Me.txtContactNumber.Text                      '联系人电话
                    .Item("fax") = Me.txtFax.Text                    '传真 
                    .Item("e_mail") = Me.txtContactEmail.Text         '联系人e-mail
                    .Item("contact_mobile") = txtContactMobile.Text
                    .Item("create_person") = UserName
                    .Item("create_date") = gWs.GetSysTime()
                End With
            Else
                Dim dr As DataRow
                dr = dsTemp.Tables("TProjectCorporation").NewRow()
                With dr
                    .Item("project_code") = Me.getProjectCode()
                    .Item("corporation_code") = Me.CorpCode
                    .Item("phase") = "评审"
                    .Item("corporation_name") = Me.getCorporationName
                    .Item("corporation_type") = "1"

                    .Item("business_start_date") = Me.dtpStartDate.Value                 '经营起始日
                    .Item("business_end_date") = Me.dtpEndDate.Value                     '经营截止日
                    '.Item("found_date") = Me.dtpFoundDate.Value                         '企业创建日
                    '.Item("technology_level") = Me.txtTechLevel.Text
                    '.Item("business_scope") = Me.txtBizScope.Text
                    '.Item("leading_product") = Me.txtLeadProduct.Text
                    '.Item("chairman") = Me.txtChairMan.Text  '董事长

                    .Item("district_name") = Me.cboAddressRange.Text                     '企业所在区 
                    .Item("register_address") = Me.txtAddressDetail.Text                 '企业所在地址明细 
                    .Item("industry_type") = Me.cboIndustryType.Text                     '行业类型
                    .Item("moneyID") = Me.cboMoneyType.SelectedValue                     '货币类型
                    .Item("proprietorship_type") = Me.cboProprietorShip.Text             '所有制类型 
                    .Item("technology_type") = Me.int_TechTypes                          '科技类型

                    .Item("loan_paper_id") = Me.txtLoanID.Text                           '贷款证号码
                    .Item("loan_card_id") = Me.txtLoanCardID.Text                        '贷款卡号码 
                    .Item("business_licence_code") = Me.txtCorpID.Text                   '营业执照号码 
                    .Item("corp_paper_id") = Me.txtRepID.Text                            '企业法人代码证号码
                    'Try
                    '    .Item("total_capital_stock") = Currency2Double(Me.txtTotalCapital.Text)
                    'Catch
                    'End Try
                    .Item("credit_grade") = Me.txtCreditLevel.Text                       '资信等级
                    .Item("evaluate_institution") = Me.txtEvalInstitute.Text             '评分单位
                    Try
                        .Item("register_capital") = Currency2Double(Me.txtRegCapital.Text) '注册资金
                    Catch
                    End Try
                    Try
                        .Item("real_capital") = Currency2Double(Me.txtRealCapital.Text)   '实收资本
                    Catch
                    End Try
                    Try
                        .Item("cash_receive") = Currency2Double(Me.txtCashReceive.Text)   '现金资本
                    Catch
                    End Try
                    Try
                        .Item("invisible_assets") = Currency2Double(Me.txtInvisibleAssets.Text) '无形资产
                    Catch
                    End Try
                    .Item("legal_representative") = Me.txtRepresentative.Text              '法人代表
                    .Item("id_card") = Me.txtRepreID.Text                                  '法人身份证号
                    .Item("nationality") = Me.txtRepreNation.Text                          '法人国籍
                    .Item("legal_representative_phone") = Me.txtLegelPhone.Text            '法人电话 
                    .Item("legal_representative_mobile") = Me.txtLegelMobile.Text          '法人手机
                    If Me.txtEmployeeAmount.Text <> "" Then
                        .Item("employee_amount") = CInt(Me.txtEmployeeAmount.Text.Trim())  '员工人数 
                    End If
                    If Me.txtColledgeNum.Text <> "" Then
                        .Item("college") = CInt(Me.txtColledgeNum.Text.Trim())             '大专生 
                    End If
                    If Me.txtBachelorNum.Text <> "" Then
                        .Item("bachelor") = CInt(Me.txtBachelorNum.Text.Trim())            '本科生
                    End If
                    If Me.txtMasterNum.Text <> "" Then
                        .Item("master") = CInt(Me.txtMasterNum.Text.Trim())                '硕士生
                    End If
                    If Me.txtDoctorNum.Text <> "" Then
                        .Item("docter") = CInt(Me.txtDoctorNum.Text.Trim())                '博士生
                    End If
                    .Item("contact_person") = Me.txtContactPerson.Text                     '联系人
                    .Item("contact_phone") = Me.txtContactNumber.Text                      '联系人电话
                    .Item("fax") = Me.txtFax.Text                                          '传真 
                    .Item("e_mail") = Me.txtContactEmail.Text         '联系人e-mail
                    .Item("contact_mobile") = txtContactMobile.Text
                    .Item("create_person") = UserName
                    .Item("create_date") = gWs.GetSysTime()
                End With
                dsTemp.Tables("TProjectCorporation").Rows.Add(dr)
            End If

            strResult = gWs.UpdateProjectCorporation(dsTemp)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存项目企业信息失败！", strResult, "")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '保存project表
    Protected Overridable Function SaveProject() As Boolean
        Dim dsTemp As DataSet
        Try
            dsTemp = gWs.GetProjectInfo("{project_code='" & Me.getProjectCode() & "'}")
            If Not dsTemp.Tables("project").Rows.Count = 0 Then
                With dsTemp.Tables("project").Rows(0)
                    '.Item("apply_service_type") = Me.cboApplyServiceType.SelectedValue
                    .Item("recommend_type") = Me.cboRecommendType.Text
                    .Item("recommend_person") = Me.GetRecommendPerson()
                    .Item("apply_bank") = Me.cboApplyBank.SelectedValue
                    If Me.cboApplyBranch.Text <> "" Then
                        .Item("apply_branch_bank") = Me.cboApplyBranch.SelectedValue
                    Else
                        .Item("apply_branch_bank") = System.DBNull.Value
                    End If
                    Try
                        .Item("apply_sum") = Currency2Double(Me.txtApplySum.Text)
                    Catch
                    End Try
                    .Item("purpose") = Me.txtPurpose.Text
                    .Item("apply_term") = Me.nuTerm.Text
                    '.Item("apply_date") = Me.dtpApplyDate.Value
                    .Item("is_first_loan") = Me.chkIsFirstLoan.Checked
                    '.Item("create_person") = UserName
                    '.Item("create_date") = SysDate.Date
                End With
            End If
            Dim strResult As String = gWs.UpdateProject(dsTemp)
            If strResult <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存项目信息失败", strResult, "")
                Return False
            End If
            Return True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '保存corporation表
    Protected Overridable Function SaveCorporation() As Boolean
        Dim dsTemp As DataSet
        Try
            dsTemp = gWs.GetcorporationInfo("{corporation_code='" + Me.CorpCode + "'}", "null")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                With dsTemp.Tables("corporation").Rows(0)
                    .Item("loan_paper_id") = Me.txtLoanID.Text
                    .Item("loan_card_id") = Me.txtLoanCardID.Text
                    .Item("business_end_date") = Me.dtpEndDate.Value                     '经营截止日
                    .Item("business_licence_code") = Me.txtCorpID.Text
                    .Item("corp_paper_id") = Me.txtRepID.Text
                    .Item("found_date") = Me.dtpStartDate.Value
                    .Item("contact_person") = Me.txtContactPerson.Text.Trim()
                    .Item("phone_num") = Me.txtContactNumber.Text.Trim()
                    .Item("mobile") = Me.txtContactMobile.Text.Trim()
                    .Item("e_mail") = Me.txtContactEmail.Text.Trim()
                    .Item("fax") = Me.txtFax.Text.Trim()
                    .Item("legal_representative") = Me.txtRepresentative.Text.Trim()
                    ' .Item("legal_representative_email") = Me.txtLegelEmail.Text.Trim()
                    '.Item("legal_representative_fax") = Me.txtLegelFax.Text.Trim()
                    .Item("legal_representative_mobile") = Me.txtLegelMobile.Text.Trim()
                    .Item("legal_representative_phone") = Me.txtLegelPhone.Text.Trim()
                    .Item("district_name") = Me.cboAddressRange.Text
                    .Item("register_address") = Me.txtAddressDetail.Text
                    .Item("proprietorship_type") = Me.cboProprietorShip.Text
                    .Item("industry_type") = Me.cboIndustryType.Text
                    .Item("technology_type") = Me.int_TechTypes
                End With
            End If
            Dim strResult As String = gWs.UpdateCorCon(dsTemp)
            If strResult <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "企业信息保存失败", strResult, "企业信息")
                Return False
            End If
            Return True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '保存合作意见cooperate_organization_opinion表
    Protected Overridable Function SaveCooperate() As Boolean
        Dim dsTemp As DataSet
        Dim strResult As String
        Try
            If Me.cboRecommendType.SelectedValue.ToString() = "合作区局" Then  '推荐类型为合作局
                dsTemp = gWs.GetCooperateOpinionInfo("null", Me.getProjectCode())
                If Not dsTemp.Tables("cooperate_organization_opinion").Rows.Count = 0 Then
                    With dsTemp.Tables("cooperate_organization_opinion").Rows(0)
                        .Item("cooperate_organization") = Me.cboRecommendItems.Text
                        Try
                            .Item("recommend_sum") = Currency2Double(Me.txtRecommendSum.Text)
                        Catch
                            .Item("recommend_sum") = 0
                        End Try
                        .Item("opinion") = Me.txtCooperateOpinion.Text
                        .Item("recommend_date") = Me.dtpRecommend.Value

                        .Item("create_person") = UserName
                        .Item("create_date") = gWs.GetSysTime()
                    End With
                Else
                    Dim dr As DataRow
                    dr = dsTemp.Tables("cooperate_organization_opinion").NewRow()
                    With dr
                        .Item("project_code") = Me.getProjectCode()
                        .Item("cooperate_organization") = Me.cboRecommendItems.Text
                        Try
                            .Item("recommend_sum") = Currency2Double(Me.txtRecommendSum.Text)
                        Catch
                            .Item("recommend_sum") = 0
                        End Try
                        .Item("opinion") = Me.txtCooperateOpinion.Text
                        .Item("recommend_date") = Me.dtpRecommend.Value

                        .Item("create_person") = UserName
                        .Item("create_date") = gWs.GetSysTime()
                    End With
                    dsTemp.Tables("cooperate_organization_opinion").Rows.Add(dr)
                End If

                strResult = gWs.UpdateCooperateOpinion(dsTemp)
                If strResult <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "保存合作意见失败", strResult, "合作意见")
                    Return False
                Else
                    Return True
                End If
            Else
                dsTemp = gWs.GetCooperateOpinionInfo("null", Me.getProjectCode())
                If Not dsTemp.Tables("cooperate_organization_opinion").Rows.Count = 0 Then
                    dsTemp.Tables("cooperate_organization_opinion").Rows(0).Delete()
                End If
                If dsTemp.HasChanges Then
                    strResult = gWs.UpdateCooperateOpinion(dsTemp)
                    If strResult <> "1" Then
                        SWDialogBox.MessageBox.Show("*999", "保存合作意见失败", strResult, "合作意见")
                        Return False
                    End If
                End If
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

#End Region

#Region "对科技类型以及合作区的处理"

    Protected int_TechTypes As Integer = 0  '科技类型
    '初始化科技类型CheckedListBox
    Protected Sub InitTechType()
        Dim tempChanged As Boolean = Me.bIsChanged
        Me.clbTechType.ClearSelected()
        Dim i As Integer
        Dim choose As Integer

        For i = 0 To Me.clbTechType.Items.Count - 1
            '选择类型
            choose = CType(CType(Me.clbTechType.Items(i), DataRowView).Item("technology_type_code"), Integer)
            '确定选择类型
            If int_TechTypes And choose Then
                Me.clbTechType.SetItemCheckState(i, CheckState.Checked)
            Else
                Me.clbTechType.SetItemCheckState(i, CheckState.Unchecked)
            End If
        Next
        Me.bIsChanged = tempChanged
    End Sub
    '选择科技类型后设置科技类型的值
    Public Sub clbTechType_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs)
        Dim val As Integer = CType(CType(Me.clbTechType.Items(e.Index), DataRowView).Item("technology_type_code"), Integer)  '当前选定项的值
        If e.NewValue Then
            int_TechTypes = (int_TechTypes Or val)
        Else
            int_TechTypes = (int_TechTypes And Not val)
        End If
        If Me.bFormLoad Then
            Me.bIsChanged = True
        End If
    End Sub

    Private bTabChanged As Boolean = False '避免TabPage的index变化后，不必要的初始化
    '设置合作类型选择后的状态
    Private Sub cboRecommendType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRecommendType.SelectedIndexChanged
        If Me.bTabChanged Then
            Me.dtpRecommend.Enabled = False
            Me.txtRecommendSum.Enabled = False
            Me.txtCooperateOpinion.Enabled = False

            Select Case Me.cboRecommendType.SelectedValue.ToString()
                Case "员工开发"
                    Me.txtRecommendPerson.Visible = False
                    Me.cboRecommendItems.Visible = False
                Case "合作银行"
                    Me.txtRecommendPerson.Visible = False
                    Me.cboRecommendItems.Visible = True
                    Me.cboRecommendItems.DataSource = BankDS.Tables("bank")
                    Me.cboRecommendItems.DisplayMember = "bank_name"
                    Me.cboRecommendItems.ValueMember = "bank_name"
                Case "回头客户"
                    Me.txtRecommendPerson.Visible = False
                    Me.cboRecommendItems.Visible = True
                    Me.cboRecommendItems.DataSource = StaffDS.Tables("TStaff")
                    Me.cboRecommendItems.DisplayMember = "staff_name"
                    Me.cboRecommendItems.ValueMember = "staff_name"
                Case "合作区局"
                    Me.txtRecommendPerson.Visible = False
                    Me.cboRecommendItems.Visible = True
                    Me.cboRecommendItems.DataSource = CooperatorInfoDS.Tables("cooperate_organization")
                    Me.cboRecommendItems.DisplayMember = "cooperate_organization"
                    Me.cboRecommendItems.ValueMember = "cooperate_organization"
                    Me.dtpRecommend.Enabled = True
                    Me.txtRecommendSum.Enabled = True
                    Me.txtCooperateOpinion.Enabled = True
                Case Else '其它，关联企业
                    Me.txtRecommendPerson.Visible = True
                    Me.cboRecommendItems.Visible = False
            End Select
            If Me.bFormLoad Then
                Me.bIsChanged = True
            End If
        End If
    End Sub
    '获取合作人名(有可能是银行名，或者合作区局)
    Protected Function GetRecommendPerson() As String
        Select Case Me.cboRecommendType.SelectedValue.ToString()
            Case "员工开发"
                Return ""
            Case "合作银行"
                Return Me.cboRecommendItems.Text
            Case "回头客户"
                Return Me.cboRecommendItems.Text
            Case "合作区局"
                Return Me.cboRecommendItems.Text
            Case Else '其它，关联企业
                Return Me.txtRecommendPerson.Text
        End Select
    End Function

    'tabpage变化时，设置科技类型CheckListBox   
    Private Sub tabReview_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabReview.SelectedIndexChanged
        If tabReview.SelectedIndex = 1 Then
            RemoveHandler cboRecommendType.SelectedIndexChanged, AddressOf cboRecommendType_SelectedIndexChanged
            Me.bTabChanged = False
            Me.InitTechType()
        ElseIf tabReview.SelectedIndex = 0 Then
            AddHandler cboRecommendType.SelectedIndexChanged, AddressOf cboRecommendType_SelectedIndexChanged
            Me.bTabChanged = True
        Else
            RemoveHandler cboRecommendType.SelectedIndexChanged, AddressOf cboRecommendType_SelectedIndexChanged
            Me.bTabChanged = False
        End If
    End Sub

#End Region

    '对界面回车键的处理
    Protected Overrides Function ProcessDialogKey(ByVal keyData As System.Windows.Forms.Keys) As Boolean
        If Me.ActiveControl.GetType() Is GetType(TextBox) Then
            Dim txt As TextBox = CType(Me.ActiveControl, TextBox)
            If txt.Multiline = True Then            '对多行TextBox跳过
                Return False
            End If
        End If
        If keyData = Keys.Enter And Not Me.ActiveControl.GetType() Is GetType(Button) Then '避免两次search
            SendKeys.Send("{TAB}")
        End If
        MyBase.ProcessDialogKey(keyData)
        Return False
    End Function

End Class
