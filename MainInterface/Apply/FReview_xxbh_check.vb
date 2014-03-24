
'项下保函复审
Public Class FReview_xxbh_check
    Inherits MainInterface.FReviewBase

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
    Friend WithEvents pgGuaranteeLetter As System.Windows.Forms.TabPage
    Friend WithEvents pgPmOpinion As System.Windows.Forms.TabPage
    Friend WithEvents pgGuaranteeLetterCheck As System.Windows.Forms.TabPage
    Friend WithEvents grpGuaranteeLetter As System.Windows.Forms.GroupBox
    Friend WithEvents lblBeneficiaryIntroduction As System.Windows.Forms.Label
    Friend WithEvents lblCounterclaimCondition As System.Windows.Forms.Label
    Friend WithEvents lblImplementAbility As System.Windows.Forms.Label
    Friend WithEvents lblProjectContent As System.Windows.Forms.Label
    Friend WithEvents lblProjectName As System.Windows.Forms.Label
    Friend WithEvents txtCounterclaimCondition As System.Windows.Forms.TextBox
    Friend WithEvents txtBeneficiaryIntroduction As System.Windows.Forms.TextBox
    Friend WithEvents txtImplementAbility As System.Windows.Forms.TextBox
    Friend WithEvents txtProjectContent As System.Windows.Forms.TextBox
    Friend WithEvents txtProjectName As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkflow As System.Windows.Forms.TextBox
    Friend WithEvents txtBeneficiary As System.Windows.Forms.TextBox
    Friend WithEvents cboGuaranteeLetterType As System.Windows.Forms.ComboBox
    Friend WithEvents cboReimburseType As System.Windows.Forms.ComboBox
    Friend WithEvents lblWorkflow As System.Windows.Forms.Label
    Friend WithEvents lblGuaranteeLetterType As System.Windows.Forms.Label
    Friend WithEvents lblReimburseType As System.Windows.Forms.Label
    Friend WithEvents lblBeneficiary As System.Windows.Forms.Label
    Friend WithEvents grpOpinion As System.Windows.Forms.GroupBox
    Friend WithEvents txtOpinion As System.Windows.Forms.TextBox
    Friend WithEvents grpGuaranteeLetterCheck As System.Windows.Forms.GroupBox
    Friend WithEvents txtCheckOpinion As System.Windows.Forms.TextBox
    Friend WithEvents pgRated As System.Windows.Forms.TabPage
    Friend WithEvents grpUsage As System.Windows.Forms.GroupBox
    Friend WithEvents dgRatedUsage As System.Windows.Forms.DataGrid
    Friend WithEvents grpRated As System.Windows.Forms.GroupBox
    Friend WithEvents dtpGuaranteeEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpGuaranteeStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblEndDate As System.Windows.Forms.Label
    Friend WithEvents lblStartDate As System.Windows.Forms.Label
    Friend WithEvents txtGuaranteeProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents lblGuaranteeProjectCode As System.Windows.Forms.Label
    Friend WithEvents cboSubBank As System.Windows.Forms.ComboBox
    Friend WithEvents cboBank As System.Windows.Forms.ComboBox
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents txtRemnantLine As System.Windows.Forms.TextBox
    Friend WithEvents txtGuaranteeLine As System.Windows.Forms.TextBox
    Friend WithEvents txtGuaranteeLetterCode As System.Windows.Forms.TextBox
    Friend WithEvents chkFlag As System.Windows.Forms.CheckBox
    Friend WithEvents lblBank As System.Windows.Forms.Label
    Friend WithEvents lblSubBank As System.Windows.Forms.Label
    Friend WithEvents lblGuaranteeLetterCode As System.Windows.Forms.Label
    Friend WithEvents lblRemnantLine As System.Windows.Forms.Label
    Friend WithEvents lblTerm As System.Windows.Forms.Label
    Friend WithEvents lblGuaranteeLine As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Protected WithEvents btnUpdateReport As System.Windows.Forms.Button
    Friend WithEvents txtGuaranteeRate As System.Windows.Forms.TextBox
    Friend WithEvents lblGuaranteeRate As System.Windows.Forms.Label
    Friend WithEvents txtEnsureMoneyRate As System.Windows.Forms.TextBox
    Friend WithEvents lblEnsureMoneyRate As System.Windows.Forms.Label
    Friend WithEvents lblRateUnit1 As System.Windows.Forms.Label
    Friend WithEvents lblRateUnit0 As System.Windows.Forms.Label
    Friend WithEvents col2_1 As DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FReview_xxbh_check))
        Me.pgGuaranteeLetter = New System.Windows.Forms.TabPage
        Me.grpGuaranteeLetter = New System.Windows.Forms.GroupBox
        Me.lblBeneficiaryIntroduction = New System.Windows.Forms.Label
        Me.lblCounterclaimCondition = New System.Windows.Forms.Label
        Me.lblImplementAbility = New System.Windows.Forms.Label
        Me.lblProjectContent = New System.Windows.Forms.Label
        Me.lblProjectName = New System.Windows.Forms.Label
        Me.txtCounterclaimCondition = New System.Windows.Forms.TextBox
        Me.txtBeneficiaryIntroduction = New System.Windows.Forms.TextBox
        Me.txtImplementAbility = New System.Windows.Forms.TextBox
        Me.txtProjectContent = New System.Windows.Forms.TextBox
        Me.txtProjectName = New System.Windows.Forms.TextBox
        Me.txtWorkflow = New System.Windows.Forms.TextBox
        Me.txtBeneficiary = New System.Windows.Forms.TextBox
        Me.cboGuaranteeLetterType = New System.Windows.Forms.ComboBox
        Me.cboReimburseType = New System.Windows.Forms.ComboBox
        Me.lblWorkflow = New System.Windows.Forms.Label
        Me.lblGuaranteeLetterType = New System.Windows.Forms.Label
        Me.lblReimburseType = New System.Windows.Forms.Label
        Me.lblBeneficiary = New System.Windows.Forms.Label
        Me.pgPmOpinion = New System.Windows.Forms.TabPage
        Me.grpOpinion = New System.Windows.Forms.GroupBox
        Me.txtOpinion = New System.Windows.Forms.TextBox
        Me.pgGuaranteeLetterCheck = New System.Windows.Forms.TabPage
        Me.lblRateUnit1 = New System.Windows.Forms.Label
        Me.lblRateUnit0 = New System.Windows.Forms.Label
        Me.grpGuaranteeLetterCheck = New System.Windows.Forms.GroupBox
        Me.txtCheckOpinion = New System.Windows.Forms.TextBox
        Me.lblEnsureMoneyRate = New System.Windows.Forms.Label
        Me.txtGuaranteeRate = New System.Windows.Forms.TextBox
        Me.lblGuaranteeRate = New System.Windows.Forms.Label
        Me.txtEnsureMoneyRate = New System.Windows.Forms.TextBox
        Me.pgRated = New System.Windows.Forms.TabPage
        Me.grpRated = New System.Windows.Forms.GroupBox
        Me.dtpGuaranteeEndDate = New System.Windows.Forms.DateTimePicker
        Me.dtpGuaranteeStartDate = New System.Windows.Forms.DateTimePicker
        Me.lblEndDate = New System.Windows.Forms.Label
        Me.lblStartDate = New System.Windows.Forms.Label
        Me.txtGuaranteeProjectCode = New System.Windows.Forms.TextBox
        Me.lblGuaranteeProjectCode = New System.Windows.Forms.Label
        Me.cboSubBank = New System.Windows.Forms.ComboBox
        Me.cboBank = New System.Windows.Forms.ComboBox
        Me.txtTerm = New System.Windows.Forms.TextBox
        Me.txtRemnantLine = New System.Windows.Forms.TextBox
        Me.txtGuaranteeLine = New System.Windows.Forms.TextBox
        Me.txtGuaranteeLetterCode = New System.Windows.Forms.TextBox
        Me.chkFlag = New System.Windows.Forms.CheckBox
        Me.lblBank = New System.Windows.Forms.Label
        Me.lblSubBank = New System.Windows.Forms.Label
        Me.lblGuaranteeLetterCode = New System.Windows.Forms.Label
        Me.lblRemnantLine = New System.Windows.Forms.Label
        Me.lblTerm = New System.Windows.Forms.Label
        Me.lblGuaranteeLine = New System.Windows.Forms.Label
        Me.grpUsage = New System.Windows.Forms.GroupBox
        Me.dgRatedUsage = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col2_1 = New DataGridTextBoxColumn
        Me.btnUpdateReport = New System.Windows.Forms.Button
        Me.grpProjectHeader.SuspendLayout()
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRequest.SuspendLayout()
        Me.grpProjectPassed.SuspendLayout()
        Me.pgProject.SuspendLayout()
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgGuaranteeLetter.SuspendLayout()
        Me.grpGuaranteeLetter.SuspendLayout()
        Me.pgPmOpinion.SuspendLayout()
        Me.grpOpinion.SuspendLayout()
        Me.pgGuaranteeLetterCheck.SuspendLayout()
        Me.grpGuaranteeLetterCheck.SuspendLayout()
        Me.pgRated.SuspendLayout()
        Me.grpRated.SuspendLayout()
        Me.grpUsage.SuspendLayout()
        CType(Me.dgRatedUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProjectRequestDate
        '
        Me.lblProjectRequestDate.Name = "lblProjectRequestDate"
        '
        'grpProjectBody
        '
        Me.grpProjectBody.Name = "grpProjectBody"
        Me.grpProjectBody.Size = New System.Drawing.Size(776, 431)
        '
        'lblProjectRequestBranch
        '
        Me.lblProjectRequestBranch.Name = "lblProjectRequestBranch"
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Name = "lblProjectCode"
        '
        'lblProjectRequestBank
        '
        Me.lblProjectRequestBank.Name = "lblProjectRequestBank"
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Name = "lblCorporationName"
        '
        'lblProjectPhase
        '
        Me.lblProjectPhase.Name = "lblProjectPhase"
        '
        'lblProjectRequestSum
        '
        Me.lblProjectRequestSum.Name = "lblProjectRequestSum"
        '
        'lblProjectRecommendDate
        '
        Me.lblProjectRecommendDate.Name = "lblProjectRecommendDate"
        '
        'lblProjectRecommendSum
        '
        Me.lblProjectRecommendSum.Name = "lblProjectRecommendSum"
        '
        'grpProjectHeader
        '
        Me.grpProjectHeader.Location = New System.Drawing.Point(9, 8)
        Me.grpProjectHeader.Name = "grpProjectHeader"
        '
        'lblProjectCooperateOpinion
        '
        Me.lblProjectCooperateOpinion.Location = New System.Drawing.Point(8, 160)
        Me.lblProjectCooperateOpinion.Name = "lblProjectCooperateOpinion"
        '
        'lblProjectRequestTerm
        '
        Me.lblProjectRequestTerm.Name = "lblProjectRequestTerm"
        '
        'txtEmployeeAmount
        '
        Me.txtEmployeeAmount.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEmployeeAmount.Name = "txtEmployeeAmount"
        Me.txtEmployeeAmount.ReadOnly = True
        '
        'txtDoctorNum
        '
        Me.txtDoctorNum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDoctorNum.Location = New System.Drawing.Point(600, 350)
        Me.txtDoctorNum.Name = "txtDoctorNum"
        Me.txtDoctorNum.ReadOnly = True
        Me.txtDoctorNum.Size = New System.Drawing.Size(144, 21)
        '
        'chkIsFirstLoan
        '
        Me.chkIsFirstLoan.Enabled = False
        Me.chkIsFirstLoan.Name = "chkIsFirstLoan"
        '
        'txtMasterNum
        '
        Me.txtMasterNum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMasterNum.Name = "txtMasterNum"
        Me.txtMasterNum.ReadOnly = True
        Me.txtMasterNum.Size = New System.Drawing.Size(144, 21)
        '
        'txtBachelorNum
        '
        Me.txtBachelorNum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBachelorNum.Location = New System.Drawing.Point(600, 326)
        Me.txtBachelorNum.Name = "txtBachelorNum"
        Me.txtBachelorNum.ReadOnly = True
        Me.txtBachelorNum.Size = New System.Drawing.Size(144, 21)
        '
        'txtColledgeNum
        '
        Me.txtColledgeNum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtColledgeNum.Name = "txtColledgeNum"
        Me.txtColledgeNum.ReadOnly = True
        Me.txtColledgeNum.Size = New System.Drawing.Size(144, 21)
        '
        'pgCorpInfo
        '
        Me.pgCorpInfo.Name = "pgCorpInfo"
        '
        'txtLegelMobile
        '
        Me.txtLegelMobile.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLegelMobile.Name = "txtLegelMobile"
        Me.txtLegelMobile.ReadOnly = True
        Me.txtLegelMobile.Size = New System.Drawing.Size(144, 21)
        '
        'txtLegelPhone
        '
        Me.txtLegelPhone.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLegelPhone.Name = "txtLegelPhone"
        Me.txtLegelPhone.ReadOnly = True
        '
        'txtRecommendSum
        '
        Me.txtRecommendSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRecommendSum.Enabled = True
        Me.txtRecommendSum.Name = "txtRecommendSum"
        Me.txtRecommendSum.ReadOnly = True
        '
        'txtContactEmail
        '
        Me.txtContactEmail.BackColor = System.Drawing.Color.Gainsboro
        Me.txtContactEmail.Name = "txtContactEmail"
        Me.txtContactEmail.ReadOnly = True
        '
        'dtpRecommend
        '
        Me.dtpRecommend.Name = "dtpRecommend"
        Me.dtpRecommend.Value = New Date(2003, 12, 3, 10, 9, 50, 562)
        '
        'txtApplySum
        '
        Me.txtApplySum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplySum.Name = "txtApplySum"
        Me.txtApplySum.ReadOnly = True
        '
        'txtContactMobile
        '
        Me.txtContactMobile.BackColor = System.Drawing.Color.Gainsboro
        Me.txtContactMobile.Location = New System.Drawing.Point(600, 278)
        Me.txtContactMobile.Name = "txtContactMobile"
        Me.txtContactMobile.ReadOnly = True
        Me.txtContactMobile.Size = New System.Drawing.Size(144, 21)
        '
        'nuTerm
        '
        Me.nuTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.nuTerm.Name = "nuTerm"
        Me.nuTerm.ReadOnly = True
        '
        'lblAttachColledge
        '
        Me.lblAttachColledge.Name = "lblAttachColledge"
        '
        'dtpApplyDate
        '
        Me.dtpApplyDate.Name = "dtpApplyDate"
        Me.dtpApplyDate.Value = New Date(2003, 12, 3, 10, 9, 50, 625)
        '
        'lblAttachMaster
        '
        Me.lblAttachMaster.Name = "lblAttachMaster"
        '
        'txtPurpose
        '
        Me.txtPurpose.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.ReadOnly = True
        '
        'lblAttachMember
        '
        Me.lblAttachMember.Name = "lblAttachMember"
        '
        'txtRecommendPerson
        '
        Me.txtRecommendPerson.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRecommendPerson.Name = "txtRecommendPerson"
        Me.txtRecommendPerson.ReadOnly = True
        '
        'lblFoundDate
        '
        Me.lblFoundDate.Name = "lblFoundDate"
        '
        'dtpFoundDate
        '
        Me.dtpFoundDate.Location = New System.Drawing.Point(600, 70)
        Me.dtpFoundDate.Name = "dtpFoundDate"
        Me.dtpFoundDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpFoundDate.Value = New Date(2003, 12, 3, 10, 9, 50, 281)
        '
        'clbTechType
        '
        Me.clbTechType.Enabled = False
        Me.clbTechType.Name = "clbTechType"
        '
        'lblCorpTechType
        '
        Me.lblCorpTechType.Name = "lblCorpTechType"
        '
        'lblCorpPropriateShip
        '
        Me.lblCorpPropriateShip.Name = "lblCorpPropriateShip"
        '
        'grpRequest
        '
        Me.grpRequest.Location = New System.Drawing.Point(0, 162)
        Me.grpRequest.Name = "grpRequest"
        Me.grpRequest.Size = New System.Drawing.Size(762, 224)
        '
        'lblCorpIndustryType
        '
        Me.lblCorpIndustryType.Name = "lblCorpIndustryType"
        '
        'txtAddressDetail
        '
        Me.txtAddressDetail.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAddressDetail.Location = New System.Drawing.Point(248, 70)
        Me.txtAddressDetail.Name = "txtAddressDetail"
        Me.txtAddressDetail.ReadOnly = True
        Me.txtAddressDetail.Size = New System.Drawing.Size(248, 21)
        '
        'lblCorpRegisterAddress
        '
        Me.lblCorpRegisterAddress.Name = "lblCorpRegisterAddress"
        '
        'txtLoanCardID
        '
        Me.txtLoanCardID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanCardID.Location = New System.Drawing.Point(600, 46)
        Me.txtLoanCardID.Name = "txtLoanCardID"
        Me.txtLoanCardID.ReadOnly = True
        Me.txtLoanCardID.Size = New System.Drawing.Size(144, 21)
        '
        'lblCorpCardID
        '
        Me.lblCorpCardID.Name = "lblCorpCardID"
        '
        'txtRepID
        '
        Me.txtRepID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRepID.Name = "txtRepID"
        Me.txtRepID.ReadOnly = True
        '
        'lblCorpRepreCardID
        '
        Me.lblCorpRepreCardID.Name = "lblCorpRepreCardID"
        '
        'txtLoanID
        '
        Me.txtLoanID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanID.Location = New System.Drawing.Point(352, 46)
        Me.txtLoanID.Name = "txtLoanID"
        Me.txtLoanID.ReadOnly = True
        Me.txtLoanID.Size = New System.Drawing.Size(144, 21)
        '
        'lblCorpPaperID
        '
        Me.lblCorpPaperID.Location = New System.Drawing.Point(264, 48)
        Me.lblCorpPaperID.Name = "lblCorpPaperID"
        '
        'txtCorpID
        '
        Me.txtCorpID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorpID.Name = "txtCorpID"
        Me.txtCorpID.ReadOnly = True
        '
        'lblCorpBusinessCode
        '
        Me.lblCorpBusinessCode.Name = "lblCorpBusinessCode"
        '
        'txtFax
        '
        Me.txtFax.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFax.Name = "txtFax"
        Me.txtFax.ReadOnly = True
        '
        'txtContactNumber
        '
        Me.txtContactNumber.BackColor = System.Drawing.Color.Gainsboro
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.ReadOnly = True
        Me.txtContactNumber.Size = New System.Drawing.Size(144, 21)
        '
        'txtContactPerson
        '
        Me.txtContactPerson.BackColor = System.Drawing.Color.Gainsboro
        Me.txtContactPerson.Name = "txtContactPerson"
        Me.txtContactPerson.ReadOnly = True
        '
        'lblProjectRequestServiceType
        '
        Me.lblProjectRequestServiceType.Name = "lblProjectRequestServiceType"
        '
        'txtRepreID
        '
        Me.txtRepreID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRepreID.Location = New System.Drawing.Point(600, 230)
        Me.txtRepreID.Name = "txtRepreID"
        Me.txtRepreID.ReadOnly = True
        Me.txtRepreID.Size = New System.Drawing.Size(144, 21)
        '
        'txtCashReceive
        '
        Me.txtCashReceive.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCashReceive.Name = "txtCashReceive"
        Me.txtCashReceive.ReadOnly = True
        Me.txtCashReceive.Size = New System.Drawing.Size(144, 21)
        '
        'txtRepreNation
        '
        Me.txtRepreNation.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRepreNation.Location = New System.Drawing.Point(600, 254)
        Me.txtRepreNation.Name = "txtRepreNation"
        Me.txtRepreNation.ReadOnly = True
        Me.txtRepreNation.Size = New System.Drawing.Size(144, 21)
        '
        'txtInvisibleAssets
        '
        Me.txtInvisibleAssets.BackColor = System.Drawing.Color.Gainsboro
        Me.txtInvisibleAssets.Name = "txtInvisibleAssets"
        Me.txtInvisibleAssets.ReadOnly = True
        '
        'txtRepresentative
        '
        Me.txtRepresentative.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRepresentative.Name = "txtRepresentative"
        Me.txtRepresentative.ReadOnly = True
        '
        'txtRealCapital
        '
        Me.txtRealCapital.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRealCapital.Location = New System.Drawing.Point(600, 208)
        Me.txtRealCapital.Name = "txtRealCapital"
        Me.txtRealCapital.ReadOnly = True
        Me.txtRealCapital.Size = New System.Drawing.Size(144, 21)
        '
        'txtRegCapital
        '
        Me.txtRegCapital.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRegCapital.Name = "txtRegCapital"
        Me.txtRegCapital.ReadOnly = True
        '
        'txtEvalInstitute
        '
        Me.txtEvalInstitute.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEvalInstitute.Name = "txtEvalInstitute"
        Me.txtEvalInstitute.ReadOnly = True
        '
        'txtCreditLevel
        '
        Me.txtCreditLevel.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCreditLevel.Name = "txtCreditLevel"
        Me.txtCreditLevel.ReadOnly = True
        '
        'lblContactorFax
        '
        Me.lblContactorFax.Name = "lblContactorFax"
        '
        'lblCorpContactNumber
        '
        Me.lblCorpContactNumber.Name = "lblCorpContactNumber"
        '
        'lblCorpContactor
        '
        Me.lblCorpContactor.Name = "lblCorpContactor"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Location = New System.Drawing.Point(600, 22)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpEndDate.Value = New Date(2003, 12, 3, 10, 9, 50, 640)
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Location = New System.Drawing.Point(352, 22)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpStartDate.Value = New Date(2003, 12, 3, 10, 9, 50, 640)
        '
        'lblCorpInvisibleAsset
        '
        Me.lblCorpInvisibleAsset.Name = "lblCorpInvisibleAsset"
        '
        'lblCorpRepre
        '
        Me.lblCorpRepre.Name = "lblCorpRepre"
        '
        'lblCorpRepreID
        '
        Me.lblCorpRepreID.Location = New System.Drawing.Point(498, 232)
        Me.lblCorpRepreID.Name = "lblCorpRepreID"
        Me.lblCorpRepreID.Size = New System.Drawing.Size(110, 16)
        '
        'lblCorpRepreNation
        '
        Me.lblCorpRepreNation.Name = "lblCorpRepreNation"
        '
        'lblCorpCreditLevel
        '
        Me.lblCorpCreditLevel.Name = "lblCorpCreditLevel"
        '
        'lblCorpEvalInstitute
        '
        Me.lblCorpEvalInstitute.Name = "lblCorpEvalInstitute"
        '
        'lblCorpRealAsset
        '
        Me.lblCorpRealAsset.Name = "lblCorpRealAsset"
        '
        'lblCorpCashArrived
        '
        Me.lblCorpCashArrived.Location = New System.Drawing.Point(256, 208)
        Me.lblCorpCashArrived.Name = "lblCorpCashArrived"
        '
        'lblCorpBusinessStartDate
        '
        Me.lblCorpBusinessStartDate.Location = New System.Drawing.Point(264, 24)
        Me.lblCorpBusinessStartDate.Name = "lblCorpBusinessStartDate"
        '
        'lblCorpBusinessEndDate
        '
        Me.lblCorpBusinessEndDate.Name = "lblCorpBusinessEndDate"
        '
        'lblCorpRegisterAsset
        '
        Me.lblCorpRegisterAsset.Name = "lblCorpRegisterAsset"
        '
        'cboApplyServiceType
        '
        Me.cboApplyServiceType.Enabled = False
        Me.cboApplyServiceType.ItemHeight = 12
        Me.cboApplyServiceType.Location = New System.Drawing.Point(88, 46)
        Me.cboApplyServiceType.Name = "cboApplyServiceType"
        Me.cboApplyServiceType.Size = New System.Drawing.Size(160, 20)
        '
        'cboApplyBranch
        '
        Me.cboApplyBranch.Enabled = False
        Me.cboApplyBranch.ItemHeight = 12
        Me.cboApplyBranch.Name = "cboApplyBranch"
        Me.cboApplyBranch.Size = New System.Drawing.Size(184, 20)
        '
        'cboApplyBank
        '
        Me.cboApplyBank.Enabled = False
        Me.cboApplyBank.ItemHeight = 12
        Me.cboApplyBank.Name = "cboApplyBank"
        Me.cboApplyBank.Size = New System.Drawing.Size(152, 20)
        '
        'cboRecommendType
        '
        Me.cboRecommendType.Enabled = False
        Me.cboRecommendType.Name = "cboRecommendType"
        Me.cboRecommendType.Size = New System.Drawing.Size(80, 20)
        '
        'cboMainServiceType
        '
        Me.cboMainServiceType.DropDownWidth = 128
        Me.cboMainServiceType.Name = "cboMainServiceType"
        Me.cboMainServiceType.Size = New System.Drawing.Size(248, 21)
        '
        'cboProprietorShip
        '
        Me.cboProprietorShip.DropDownWidth = 288
        Me.cboProprietorShip.Enabled = False
        Me.cboProprietorShip.Name = "cboProprietorShip"
        Me.cboProprietorShip.Size = New System.Drawing.Size(256, 21)
        '
        'grpProjectPassed
        '
        Me.grpProjectPassed.Location = New System.Drawing.Point(0, 0)
        Me.grpProjectPassed.Name = "grpProjectPassed"
        Me.grpProjectPassed.Size = New System.Drawing.Size(762, 166)
        '
        'cboIndustryType
        '
        Me.cboIndustryType.DropDownWidth = 240
        Me.cboIndustryType.Enabled = False
        Me.cboIndustryType.Name = "cboIndustryType"
        '
        'pgProject
        '
        Me.pgProject.Name = "pgProject"
        Me.pgProject.Size = New System.Drawing.Size(762, 386)
        '
        'cboAddressRange
        '
        Me.cboAddressRange.DropDownWidth = 128
        Me.cboAddressRange.Enabled = False
        Me.cboAddressRange.Name = "cboAddressRange"
        '
        'lblMainServiceType
        '
        Me.lblMainServiceType.Name = "lblMainServiceType"
        '
        'lblContactEmail
        '
        Me.lblContactEmail.Name = "lblContactEmail"
        '
        'txtProjectPhase
        '
        Me.txtProjectPhase.Name = "txtProjectPhase"
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Name = "txtCorporationName"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Name = "txtProjectCode"
        '
        'lblRecommend
        '
        Me.lblRecommend.Name = "lblRecommend"
        '
        'lblPurpose
        '
        Me.lblPurpose.Name = "lblPurpose"
        '
        'lblLegelMobile
        '
        Me.lblLegelMobile.Name = "lblLegelMobile"
        '
        'lblLegelPhone
        '
        Me.lblLegelPhone.Name = "lblLegelPhone"
        '
        'lblContactMobile
        '
        Me.lblContactMobile.Name = "lblContactMobile"
        '
        'dgProject
        '
        Me.dgProject.AccessibleName = "DataGrid"
        Me.dgProject.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgProject.Name = "dgProject"
        Me.dgProject.Size = New System.Drawing.Size(756, 146)
        '
        'lblAttachBancholer
        '
        Me.lblAttachBancholer.Location = New System.Drawing.Point(512, 328)
        Me.lblAttachBancholer.Name = "lblAttachBancholer"
        '
        'lblAttachDoctor
        '
        Me.lblAttachDoctor.Location = New System.Drawing.Point(512, 352)
        Me.lblAttachDoctor.Name = "lblAttachDoctor"
        '
        'btnReport
        '
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Image)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.ImageIndex = -1
        Me.btnReport.ImageList = Nothing
        Me.btnReport.Location = New System.Drawing.Point(264, 496)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(130, 24)
        Me.btnReport.Text = "制作保函审批表(&R)"
        '
        'lblMoneyType
        '
        Me.lblMoneyType.Name = "lblMoneyType"
        '
        'cboMoneyType
        '
        Me.cboMoneyType.DropDownWidth = 144
        Me.cboMoneyType.Enabled = False
        Me.cboMoneyType.ItemHeight = 12
        Me.cboMoneyType.Name = "cboMoneyType"
        Me.cboMoneyType.Size = New System.Drawing.Size(144, 21)
        '
        'btnSave
        '
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(401, 496)
        Me.btnSave.Name = "btnSave"
        '
        'btnCommit
        '
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Image)
        Me.btnCommit.ImageIndex = -1
        Me.btnCommit.ImageList = Nothing
        Me.btnCommit.Location = New System.Drawing.Point(483, 496)
        Me.btnCommit.Name = "btnCommit"
        '
        'cboRecommendItems
        '
        Me.cboRecommendItems.Enabled = False
        Me.cboRecommendItems.ItemHeight = 12
        Me.cboRecommendItems.Name = "cboRecommendItems"
        Me.cboRecommendItems.Size = New System.Drawing.Size(104, 20)
        '
        'mnuInputFinance
        '
        Me.mnuInputFinance.Enabled = False
        '
        'mnuFinanceAnalyze
        '
        Me.mnuFinanceAnalyze.Enabled = False
        '
        'mnuImportHistory
        '
        Me.mnuImportHistory.Enabled = False
        '
        'mnuCheckMaterial
        '
        Me.mnuCheckMaterial.Enabled = False
        '
        'txtCooperateOpinion
        '
        Me.txtCooperateOpinion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCooperateOpinion.Enabled = True
        Me.txtCooperateOpinion.Name = "txtCooperateOpinion"
        Me.txtCooperateOpinion.ReadOnly = True
        Me.txtCooperateOpinion.Size = New System.Drawing.Size(656, 56)
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = 4
        Me.btnExit.ImageList = Me.ImageListBasic
        Me.btnExit.Location = New System.Drawing.Point(565, 496)
        Me.btnExit.Name = "btnExit"
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'pgGuaranteeLetter
        '
        Me.pgGuaranteeLetter.Controls.Add(Me.grpGuaranteeLetter)
        Me.pgGuaranteeLetter.Location = New System.Drawing.Point(4, 21)
        Me.pgGuaranteeLetter.Name = "pgGuaranteeLetter"
        Me.pgGuaranteeLetter.Size = New System.Drawing.Size(762, 375)
        Me.pgGuaranteeLetter.TabIndex = 12
        Me.pgGuaranteeLetter.Text = "保函信息"
        '
        'grpGuaranteeLetter
        '
        Me.grpGuaranteeLetter.Controls.Add(Me.lblBeneficiaryIntroduction)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblCounterclaimCondition)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblImplementAbility)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblProjectContent)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblProjectName)
        Me.grpGuaranteeLetter.Controls.Add(Me.txtCounterclaimCondition)
        Me.grpGuaranteeLetter.Controls.Add(Me.txtBeneficiaryIntroduction)
        Me.grpGuaranteeLetter.Controls.Add(Me.txtImplementAbility)
        Me.grpGuaranteeLetter.Controls.Add(Me.txtProjectContent)
        Me.grpGuaranteeLetter.Controls.Add(Me.txtProjectName)
        Me.grpGuaranteeLetter.Controls.Add(Me.txtWorkflow)
        Me.grpGuaranteeLetter.Controls.Add(Me.txtBeneficiary)
        Me.grpGuaranteeLetter.Controls.Add(Me.cboGuaranteeLetterType)
        Me.grpGuaranteeLetter.Controls.Add(Me.cboReimburseType)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblWorkflow)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblGuaranteeLetterType)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblReimburseType)
        Me.grpGuaranteeLetter.Controls.Add(Me.lblBeneficiary)
        Me.grpGuaranteeLetter.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpGuaranteeLetter.Location = New System.Drawing.Point(0, 0)
        Me.grpGuaranteeLetter.Name = "grpGuaranteeLetter"
        Me.grpGuaranteeLetter.Size = New System.Drawing.Size(762, 375)
        Me.grpGuaranteeLetter.TabIndex = 1
        Me.grpGuaranteeLetter.TabStop = False
        '
        'lblBeneficiaryIntroduction
        '
        Me.lblBeneficiaryIntroduction.Location = New System.Drawing.Point(8, 312)
        Me.lblBeneficiaryIntroduction.Name = "lblBeneficiaryIntroduction"
        Me.lblBeneficiaryIntroduction.Size = New System.Drawing.Size(72, 16)
        Me.lblBeneficiaryIntroduction.TabIndex = 99
        Me.lblBeneficiaryIntroduction.Text = "受益人简介"
        '
        'lblCounterclaimCondition
        '
        Me.lblCounterclaimCondition.Location = New System.Drawing.Point(8, 232)
        Me.lblCounterclaimCondition.Name = "lblCounterclaimCondition"
        Me.lblCounterclaimCondition.Size = New System.Drawing.Size(56, 16)
        Me.lblCounterclaimCondition.TabIndex = 98
        Me.lblCounterclaimCondition.Text = "索赔条件"
        '
        'lblImplementAbility
        '
        Me.lblImplementAbility.Location = New System.Drawing.Point(8, 168)
        Me.lblImplementAbility.Name = "lblImplementAbility"
        Me.lblImplementAbility.Size = New System.Drawing.Size(56, 16)
        Me.lblImplementAbility.TabIndex = 97
        Me.lblImplementAbility.Text = "履约能力"
        '
        'lblProjectContent
        '
        Me.lblProjectContent.Location = New System.Drawing.Point(8, 104)
        Me.lblProjectContent.Name = "lblProjectContent"
        Me.lblProjectContent.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectContent.TabIndex = 96
        Me.lblProjectContent.Text = "中标内容"
        '
        'lblProjectName
        '
        Me.lblProjectName.Location = New System.Drawing.Point(8, 72)
        Me.lblProjectName.Name = "lblProjectName"
        Me.lblProjectName.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectName.TabIndex = 95
        Me.lblProjectName.Text = "项目名称"
        '
        'txtCounterclaimCondition
        '
        Me.txtCounterclaimCondition.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCounterclaimCondition.Location = New System.Drawing.Point(88, 224)
        Me.txtCounterclaimCondition.Multiline = True
        Me.txtCounterclaimCondition.Name = "txtCounterclaimCondition"
        Me.txtCounterclaimCondition.ReadOnly = True
        Me.txtCounterclaimCondition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCounterclaimCondition.Size = New System.Drawing.Size(656, 72)
        Me.txtCounterclaimCondition.TabIndex = 13
        Me.txtCounterclaimCondition.Text = ""
        '
        'txtBeneficiaryIntroduction
        '
        Me.txtBeneficiaryIntroduction.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBeneficiaryIntroduction.Location = New System.Drawing.Point(88, 304)
        Me.txtBeneficiaryIntroduction.Multiline = True
        Me.txtBeneficiaryIntroduction.Name = "txtBeneficiaryIntroduction"
        Me.txtBeneficiaryIntroduction.ReadOnly = True
        Me.txtBeneficiaryIntroduction.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBeneficiaryIntroduction.Size = New System.Drawing.Size(656, 64)
        Me.txtBeneficiaryIntroduction.TabIndex = 14
        Me.txtBeneficiaryIntroduction.Text = ""
        '
        'txtImplementAbility
        '
        Me.txtImplementAbility.BackColor = System.Drawing.Color.Gainsboro
        Me.txtImplementAbility.Location = New System.Drawing.Point(88, 160)
        Me.txtImplementAbility.Multiline = True
        Me.txtImplementAbility.Name = "txtImplementAbility"
        Me.txtImplementAbility.ReadOnly = True
        Me.txtImplementAbility.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtImplementAbility.Size = New System.Drawing.Size(656, 56)
        Me.txtImplementAbility.TabIndex = 12
        Me.txtImplementAbility.Text = ""
        '
        'txtProjectContent
        '
        Me.txtProjectContent.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectContent.Location = New System.Drawing.Point(88, 96)
        Me.txtProjectContent.Multiline = True
        Me.txtProjectContent.Name = "txtProjectContent"
        Me.txtProjectContent.ReadOnly = True
        Me.txtProjectContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProjectContent.Size = New System.Drawing.Size(656, 56)
        Me.txtProjectContent.TabIndex = 11
        Me.txtProjectContent.Text = ""
        '
        'txtProjectName
        '
        Me.txtProjectName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectName.Location = New System.Drawing.Point(88, 70)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.ReadOnly = True
        Me.txtProjectName.Size = New System.Drawing.Size(464, 21)
        Me.txtProjectName.TabIndex = 10
        Me.txtProjectName.Text = ""
        '
        'txtWorkflow
        '
        Me.txtWorkflow.BackColor = System.Drawing.Color.Gainsboro
        Me.txtWorkflow.Location = New System.Drawing.Point(88, 22)
        Me.txtWorkflow.Name = "txtWorkflow"
        Me.txtWorkflow.ReadOnly = True
        Me.txtWorkflow.Size = New System.Drawing.Size(184, 21)
        Me.txtWorkflow.TabIndex = 6
        Me.txtWorkflow.TabStop = False
        Me.txtWorkflow.Text = ""
        '
        'txtBeneficiary
        '
        Me.txtBeneficiary.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBeneficiary.Location = New System.Drawing.Point(368, 46)
        Me.txtBeneficiary.Name = "txtBeneficiary"
        Me.txtBeneficiary.ReadOnly = True
        Me.txtBeneficiary.Size = New System.Drawing.Size(184, 21)
        Me.txtBeneficiary.TabIndex = 9
        Me.txtBeneficiary.TabStop = False
        Me.txtBeneficiary.Text = ""
        '
        'cboGuaranteeLetterType
        '
        Me.cboGuaranteeLetterType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGuaranteeLetterType.Enabled = False
        Me.cboGuaranteeLetterType.Location = New System.Drawing.Point(368, 22)
        Me.cboGuaranteeLetterType.Name = "cboGuaranteeLetterType"
        Me.cboGuaranteeLetterType.Size = New System.Drawing.Size(184, 20)
        Me.cboGuaranteeLetterType.TabIndex = 7
        Me.cboGuaranteeLetterType.TabStop = False
        '
        'cboReimburseType
        '
        Me.cboReimburseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboReimburseType.Enabled = False
        Me.cboReimburseType.Location = New System.Drawing.Point(88, 46)
        Me.cboReimburseType.Name = "cboReimburseType"
        Me.cboReimburseType.Size = New System.Drawing.Size(184, 20)
        Me.cboReimburseType.TabIndex = 8
        Me.cboReimburseType.TabStop = False
        '
        'lblWorkflow
        '
        Me.lblWorkflow.Location = New System.Drawing.Point(8, 24)
        Me.lblWorkflow.Name = "lblWorkflow"
        Me.lblWorkflow.Size = New System.Drawing.Size(56, 16)
        Me.lblWorkflow.TabIndex = 84
        Me.lblWorkflow.Text = "运作方式"
        '
        'lblGuaranteeLetterType
        '
        Me.lblGuaranteeLetterType.Location = New System.Drawing.Point(288, 25)
        Me.lblGuaranteeLetterType.Name = "lblGuaranteeLetterType"
        Me.lblGuaranteeLetterType.Size = New System.Drawing.Size(54, 14)
        Me.lblGuaranteeLetterType.TabIndex = 82
        Me.lblGuaranteeLetterType.Text = "保函种类"
        '
        'lblReimburseType
        '
        Me.lblReimburseType.Location = New System.Drawing.Point(8, 48)
        Me.lblReimburseType.Name = "lblReimburseType"
        Me.lblReimburseType.Size = New System.Drawing.Size(80, 16)
        Me.lblReimburseType.TabIndex = 83
        Me.lblReimburseType.Text = "偿付责任类型"
        '
        'lblBeneficiary
        '
        Me.lblBeneficiary.Location = New System.Drawing.Point(288, 49)
        Me.lblBeneficiary.Name = "lblBeneficiary"
        Me.lblBeneficiary.Size = New System.Drawing.Size(66, 14)
        Me.lblBeneficiary.TabIndex = 85
        Me.lblBeneficiary.Text = "受益人名称"
        '
        'pgPmOpinion
        '
        Me.pgPmOpinion.Controls.Add(Me.grpOpinion)
        Me.pgPmOpinion.Location = New System.Drawing.Point(4, 21)
        Me.pgPmOpinion.Name = "pgPmOpinion"
        Me.pgPmOpinion.Size = New System.Drawing.Size(762, 375)
        Me.pgPmOpinion.TabIndex = 13
        Me.pgPmOpinion.Text = "项目经理意见"
        '
        'grpOpinion
        '
        Me.grpOpinion.Controls.Add(Me.txtOpinion)
        Me.grpOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpOpinion.Location = New System.Drawing.Point(0, 0)
        Me.grpOpinion.Name = "grpOpinion"
        Me.grpOpinion.Size = New System.Drawing.Size(762, 375)
        Me.grpOpinion.TabIndex = 1
        Me.grpOpinion.TabStop = False
        Me.grpOpinion.Text = "评审意见"
        '
        'txtOpinion
        '
        Me.txtOpinion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOpinion.Location = New System.Drawing.Point(3, 17)
        Me.txtOpinion.MaxLength = 5000
        Me.txtOpinion.Multiline = True
        Me.txtOpinion.Name = "txtOpinion"
        Me.txtOpinion.ReadOnly = True
        Me.txtOpinion.Size = New System.Drawing.Size(756, 355)
        Me.txtOpinion.TabIndex = 0
        Me.txtOpinion.TabStop = False
        Me.txtOpinion.Text = ""
        '
        'pgGuaranteeLetterCheck
        '
        Me.pgGuaranteeLetterCheck.Controls.Add(Me.lblRateUnit1)
        Me.pgGuaranteeLetterCheck.Controls.Add(Me.lblRateUnit0)
        Me.pgGuaranteeLetterCheck.Controls.Add(Me.grpGuaranteeLetterCheck)
        Me.pgGuaranteeLetterCheck.Controls.Add(Me.lblEnsureMoneyRate)
        Me.pgGuaranteeLetterCheck.Controls.Add(Me.txtGuaranteeRate)
        Me.pgGuaranteeLetterCheck.Controls.Add(Me.lblGuaranteeRate)
        Me.pgGuaranteeLetterCheck.Controls.Add(Me.txtEnsureMoneyRate)
        Me.pgGuaranteeLetterCheck.Location = New System.Drawing.Point(4, 21)
        Me.pgGuaranteeLetterCheck.Name = "pgGuaranteeLetterCheck"
        Me.pgGuaranteeLetterCheck.Size = New System.Drawing.Size(762, 375)
        Me.pgGuaranteeLetterCheck.TabIndex = 14
        Me.pgGuaranteeLetterCheck.Text = "保函专审员意见"
        '
        'lblRateUnit1
        '
        Me.lblRateUnit1.Location = New System.Drawing.Point(264, 360)
        Me.lblRateUnit1.Name = "lblRateUnit1"
        Me.lblRateUnit1.Size = New System.Drawing.Size(24, 16)
        Me.lblRateUnit1.TabIndex = 14
        Me.lblRateUnit1.Text = "%"
        '
        'lblRateUnit0
        '
        Me.lblRateUnit0.Location = New System.Drawing.Point(136, 360)
        Me.lblRateUnit0.Name = "lblRateUnit0"
        Me.lblRateUnit0.Size = New System.Drawing.Size(24, 16)
        Me.lblRateUnit0.TabIndex = 13
        Me.lblRateUnit0.Text = "%"
        '
        'grpGuaranteeLetterCheck
        '
        Me.grpGuaranteeLetterCheck.Controls.Add(Me.txtCheckOpinion)
        Me.grpGuaranteeLetterCheck.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpGuaranteeLetterCheck.Location = New System.Drawing.Point(0, 0)
        Me.grpGuaranteeLetterCheck.Name = "grpGuaranteeLetterCheck"
        Me.grpGuaranteeLetterCheck.Size = New System.Drawing.Size(762, 344)
        Me.grpGuaranteeLetterCheck.TabIndex = 0
        Me.grpGuaranteeLetterCheck.TabStop = False
        Me.grpGuaranteeLetterCheck.Text = "复审意见"
        '
        'txtCheckOpinion
        '
        Me.txtCheckOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCheckOpinion.Location = New System.Drawing.Point(3, 17)
        Me.txtCheckOpinion.Multiline = True
        Me.txtCheckOpinion.Name = "txtCheckOpinion"
        Me.txtCheckOpinion.Size = New System.Drawing.Size(756, 324)
        Me.txtCheckOpinion.TabIndex = 0
        Me.txtCheckOpinion.Text = ""
        '
        'lblEnsureMoneyRate
        '
        Me.lblEnsureMoneyRate.Location = New System.Drawing.Point(32, 360)
        Me.lblEnsureMoneyRate.Name = "lblEnsureMoneyRate"
        Me.lblEnsureMoneyRate.Size = New System.Drawing.Size(72, 16)
        Me.lblEnsureMoneyRate.TabIndex = 9
        Me.lblEnsureMoneyRate.Text = "保证金比率"
        '
        'txtGuaranteeRate
        '
        Me.txtGuaranteeRate.Location = New System.Drawing.Point(232, 358)
        Me.txtGuaranteeRate.Name = "txtGuaranteeRate"
        Me.txtGuaranteeRate.Size = New System.Drawing.Size(32, 21)
        Me.txtGuaranteeRate.TabIndex = 12
        Me.txtGuaranteeRate.Text = ""
        Me.txtGuaranteeRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblGuaranteeRate
        '
        Me.lblGuaranteeRate.Location = New System.Drawing.Point(160, 360)
        Me.lblGuaranteeRate.Name = "lblGuaranteeRate"
        Me.lblGuaranteeRate.Size = New System.Drawing.Size(72, 16)
        Me.lblGuaranteeRate.TabIndex = 11
        Me.lblGuaranteeRate.Text = "担保费费率"
        '
        'txtEnsureMoneyRate
        '
        Me.txtEnsureMoneyRate.Location = New System.Drawing.Point(104, 358)
        Me.txtEnsureMoneyRate.Name = "txtEnsureMoneyRate"
        Me.txtEnsureMoneyRate.Size = New System.Drawing.Size(32, 21)
        Me.txtEnsureMoneyRate.TabIndex = 10
        Me.txtEnsureMoneyRate.Text = ""
        Me.txtEnsureMoneyRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'pgRated
        '
        Me.pgRated.Controls.Add(Me.grpRated)
        Me.pgRated.Controls.Add(Me.grpUsage)
        Me.pgRated.Location = New System.Drawing.Point(4, 21)
        Me.pgRated.Name = "pgRated"
        Me.pgRated.Size = New System.Drawing.Size(762, 375)
        Me.pgRated.TabIndex = 15
        Me.pgRated.Text = "保函额度协议信息"
        '
        'grpRated
        '
        Me.grpRated.Controls.Add(Me.dtpGuaranteeEndDate)
        Me.grpRated.Controls.Add(Me.dtpGuaranteeStartDate)
        Me.grpRated.Controls.Add(Me.lblEndDate)
        Me.grpRated.Controls.Add(Me.lblStartDate)
        Me.grpRated.Controls.Add(Me.txtGuaranteeProjectCode)
        Me.grpRated.Controls.Add(Me.lblGuaranteeProjectCode)
        Me.grpRated.Controls.Add(Me.cboSubBank)
        Me.grpRated.Controls.Add(Me.cboBank)
        Me.grpRated.Controls.Add(Me.txtTerm)
        Me.grpRated.Controls.Add(Me.txtRemnantLine)
        Me.grpRated.Controls.Add(Me.txtGuaranteeLine)
        Me.grpRated.Controls.Add(Me.txtGuaranteeLetterCode)
        Me.grpRated.Controls.Add(Me.chkFlag)
        Me.grpRated.Controls.Add(Me.lblBank)
        Me.grpRated.Controls.Add(Me.lblSubBank)
        Me.grpRated.Controls.Add(Me.lblGuaranteeLetterCode)
        Me.grpRated.Controls.Add(Me.lblRemnantLine)
        Me.grpRated.Controls.Add(Me.lblTerm)
        Me.grpRated.Controls.Add(Me.lblGuaranteeLine)
        Me.grpRated.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grpRated.Location = New System.Drawing.Point(0, 127)
        Me.grpRated.Name = "grpRated"
        Me.grpRated.Size = New System.Drawing.Size(762, 248)
        Me.grpRated.TabIndex = 4
        Me.grpRated.TabStop = False
        '
        'dtpGuaranteeEndDate
        '
        Me.dtpGuaranteeEndDate.Enabled = False
        Me.dtpGuaranteeEndDate.Location = New System.Drawing.Point(368, 94)
        Me.dtpGuaranteeEndDate.Name = "dtpGuaranteeEndDate"
        Me.dtpGuaranteeEndDate.Size = New System.Drawing.Size(168, 21)
        Me.dtpGuaranteeEndDate.TabIndex = 19
        '
        'dtpGuaranteeStartDate
        '
        Me.dtpGuaranteeStartDate.Enabled = False
        Me.dtpGuaranteeStartDate.Location = New System.Drawing.Point(104, 94)
        Me.dtpGuaranteeStartDate.Name = "dtpGuaranteeStartDate"
        Me.dtpGuaranteeStartDate.Size = New System.Drawing.Size(168, 21)
        Me.dtpGuaranteeStartDate.TabIndex = 18
        '
        'lblEndDate
        '
        Me.lblEndDate.Location = New System.Drawing.Point(288, 96)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(88, 16)
        Me.lblEndDate.TabIndex = 17
        Me.lblEndDate.Text = "截止时间"
        '
        'lblStartDate
        '
        Me.lblStartDate.Location = New System.Drawing.Point(8, 96)
        Me.lblStartDate.Name = "lblStartDate"
        Me.lblStartDate.Size = New System.Drawing.Size(88, 16)
        Me.lblStartDate.TabIndex = 16
        Me.lblStartDate.Text = "起始时间"
        '
        'txtGuaranteeProjectCode
        '
        Me.txtGuaranteeProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuaranteeProjectCode.Location = New System.Drawing.Point(368, 22)
        Me.txtGuaranteeProjectCode.Name = "txtGuaranteeProjectCode"
        Me.txtGuaranteeProjectCode.ReadOnly = True
        Me.txtGuaranteeProjectCode.Size = New System.Drawing.Size(168, 21)
        Me.txtGuaranteeProjectCode.TabIndex = 15
        Me.txtGuaranteeProjectCode.Text = ""
        '
        'lblGuaranteeProjectCode
        '
        Me.lblGuaranteeProjectCode.Location = New System.Drawing.Point(288, 24)
        Me.lblGuaranteeProjectCode.Name = "lblGuaranteeProjectCode"
        Me.lblGuaranteeProjectCode.Size = New System.Drawing.Size(88, 16)
        Me.lblGuaranteeProjectCode.TabIndex = 14
        Me.lblGuaranteeProjectCode.Text = "项目编号"
        '
        'cboSubBank
        '
        Me.cboSubBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubBank.Enabled = False
        Me.cboSubBank.Location = New System.Drawing.Point(368, 118)
        Me.cboSubBank.Name = "cboSubBank"
        Me.cboSubBank.Size = New System.Drawing.Size(168, 20)
        Me.cboSubBank.TabIndex = 13
        '
        'cboBank
        '
        Me.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBank.Enabled = False
        Me.cboBank.Location = New System.Drawing.Point(104, 118)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(168, 20)
        Me.cboBank.TabIndex = 12
        '
        'txtTerm
        '
        Me.txtTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerm.Location = New System.Drawing.Point(104, 70)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.ReadOnly = True
        Me.txtTerm.Size = New System.Drawing.Size(168, 21)
        Me.txtTerm.TabIndex = 11
        Me.txtTerm.Text = ""
        '
        'txtRemnantLine
        '
        Me.txtRemnantLine.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRemnantLine.Location = New System.Drawing.Point(368, 46)
        Me.txtRemnantLine.Name = "txtRemnantLine"
        Me.txtRemnantLine.ReadOnly = True
        Me.txtRemnantLine.Size = New System.Drawing.Size(168, 21)
        Me.txtRemnantLine.TabIndex = 10
        Me.txtRemnantLine.Text = ""
        Me.txtRemnantLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGuaranteeLine
        '
        Me.txtGuaranteeLine.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuaranteeLine.Location = New System.Drawing.Point(104, 46)
        Me.txtGuaranteeLine.Name = "txtGuaranteeLine"
        Me.txtGuaranteeLine.ReadOnly = True
        Me.txtGuaranteeLine.Size = New System.Drawing.Size(168, 21)
        Me.txtGuaranteeLine.TabIndex = 9
        Me.txtGuaranteeLine.Text = ""
        Me.txtGuaranteeLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtGuaranteeLetterCode
        '
        Me.txtGuaranteeLetterCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuaranteeLetterCode.Location = New System.Drawing.Point(104, 22)
        Me.txtGuaranteeLetterCode.Name = "txtGuaranteeLetterCode"
        Me.txtGuaranteeLetterCode.ReadOnly = True
        Me.txtGuaranteeLetterCode.Size = New System.Drawing.Size(168, 21)
        Me.txtGuaranteeLetterCode.TabIndex = 8
        Me.txtGuaranteeLetterCode.Text = ""
        '
        'chkFlag
        '
        Me.chkFlag.Enabled = False
        Me.chkFlag.Location = New System.Drawing.Point(296, 68)
        Me.chkFlag.Name = "chkFlag"
        Me.chkFlag.TabIndex = 7
        Me.chkFlag.Text = "有效"
        '
        'lblBank
        '
        Me.lblBank.Location = New System.Drawing.Point(8, 120)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(88, 16)
        Me.lblBank.TabIndex = 5
        Me.lblBank.Text = "签约银行"
        '
        'lblSubBank
        '
        Me.lblSubBank.Location = New System.Drawing.Point(288, 120)
        Me.lblSubBank.Name = "lblSubBank"
        Me.lblSubBank.Size = New System.Drawing.Size(88, 16)
        Me.lblSubBank.TabIndex = 4
        Me.lblSubBank.Text = "签约支行"
        '
        'lblGuaranteeLetterCode
        '
        Me.lblGuaranteeLetterCode.Location = New System.Drawing.Point(8, 24)
        Me.lblGuaranteeLetterCode.Name = "lblGuaranteeLetterCode"
        Me.lblGuaranteeLetterCode.Size = New System.Drawing.Size(104, 16)
        Me.lblGuaranteeLetterCode.TabIndex = 3
        Me.lblGuaranteeLetterCode.Text = "保函协议书编号"
        '
        'lblRemnantLine
        '
        Me.lblRemnantLine.Location = New System.Drawing.Point(288, 48)
        Me.lblRemnantLine.Name = "lblRemnantLine"
        Me.lblRemnantLine.Size = New System.Drawing.Size(88, 16)
        Me.lblRemnantLine.TabIndex = 2
        Me.lblRemnantLine.Text = "剩余额度(万)"
        '
        'lblTerm
        '
        Me.lblTerm.Location = New System.Drawing.Point(8, 72)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(88, 16)
        Me.lblTerm.TabIndex = 1
        Me.lblTerm.Text = "额度期限(月)"
        '
        'lblGuaranteeLine
        '
        Me.lblGuaranteeLine.Location = New System.Drawing.Point(8, 48)
        Me.lblGuaranteeLine.Name = "lblGuaranteeLine"
        Me.lblGuaranteeLine.Size = New System.Drawing.Size(88, 16)
        Me.lblGuaranteeLine.TabIndex = 0
        Me.lblGuaranteeLine.Text = "保函额度(万)"
        '
        'grpUsage
        '
        Me.grpUsage.Controls.Add(Me.dgRatedUsage)
        Me.grpUsage.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpUsage.Location = New System.Drawing.Point(0, 0)
        Me.grpUsage.Name = "grpUsage"
        Me.grpUsage.Size = New System.Drawing.Size(762, 136)
        Me.grpUsage.TabIndex = 3
        Me.grpUsage.TabStop = False
        Me.grpUsage.Text = "额度使用协议信息"
        '
        'dgRatedUsage
        '
        Me.dgRatedUsage.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgRatedUsage.CaptionVisible = False
        Me.dgRatedUsage.DataMember = ""
        Me.dgRatedUsage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRatedUsage.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgRatedUsage.Location = New System.Drawing.Point(3, 17)
        Me.dgRatedUsage.Name = "dgRatedUsage"
        Me.dgRatedUsage.ReadOnly = True
        Me.dgRatedUsage.RowHeadersVisible = False
        Me.dgRatedUsage.Size = New System.Drawing.Size(756, 116)
        Me.dgRatedUsage.TabIndex = 0
        Me.dgRatedUsage.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})


        col2_1.MappingName = "term"     '期限
        col2_1.HeaderText = "期限(月)"
        col2_1.TextBox.MaxLength = 18
        col2_1.NullText = String.Empty
        col2_1.Width = 75

        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dgRatedUsage
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.col2_1, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "TGuaranteeLetterUsage"
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "保函种类"
        Me.DataGridTextBoxColumn10.MappingName = "letter_name"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 120
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "偿付责任类型"
        Me.DataGridTextBoxColumn11.MappingName = "Reimburse_name"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 120

        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "保证金比例(%)"
        Me.DataGridTextBoxColumn12.MappingName = "guarantee_scale"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 125
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "担保费率(%)"
        Me.DataGridTextBoxColumn13.MappingName = "guarantee_rate"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 75
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "创建人"
        Me.DataGridTextBoxColumn14.MappingName = "create_person"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 75
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = "yy-MM-dd"
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "创建时间"
        Me.DataGridTextBoxColumn15.MappingName = "create_date"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 75
        '
        'btnUpdateReport
        '
        Me.btnUpdateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateReport.ImageIndex = 25
        Me.btnUpdateReport.ImageList = Me.ImageListBasic
        Me.btnUpdateReport.Location = New System.Drawing.Point(155, 496)
        Me.btnUpdateReport.Name = "btnUpdateReport"
        Me.btnUpdateReport.Size = New System.Drawing.Size(102, 24)
        Me.btnUpdateReport.TabIndex = 51
        Me.btnUpdateReport.Text = "查看保函样本"
        Me.btnUpdateReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FReview_xxbh_check
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(794, 523)
        Me.Controls.Add(Me.btnUpdateReport)
        Me.MinimizeBox = False
        Me.Name = "FReview_xxbh_check"
        Me.Text = "复审保函"
        Me.Controls.SetChildIndex(Me.btnUpdateReport, 0)
        Me.Controls.SetChildIndex(Me.btnReport, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.grpProjectBody, 0)
        Me.Controls.SetChildIndex(Me.grpProjectHeader, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.grpProjectHeader.ResumeLayout(False)
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRequest.ResumeLayout(False)
        Me.grpProjectPassed.ResumeLayout(False)
        Me.pgProject.ResumeLayout(False)
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgGuaranteeLetter.ResumeLayout(False)
        Me.grpGuaranteeLetter.ResumeLayout(False)
        Me.pgPmOpinion.ResumeLayout(False)
        Me.grpOpinion.ResumeLayout(False)
        Me.pgGuaranteeLetterCheck.ResumeLayout(False)
        Me.grpGuaranteeLetterCheck.ResumeLayout(False)
        Me.pgRated.ResumeLayout(False)
        Me.grpRated.ResumeLayout(False)
        Me.grpUsage.ResumeLayout(False)
        CType(Me.dgRatedUsage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsSignBank As DataSet

    Private Sub FReview_xxbh_check_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            MyBase.InitCorpCodeAndPhase()
            MyBase.InitComboBox()
            MyBase.InitDataSet()
            Me.Init()
            MyBase.GetData()
            Me.bFormLoad = True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '同fReview_xxbh窗体
    Protected Overrides Sub GetProjectData()
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
        Me.chkIsFirstLoan.DataBindings.Add("Checked", ds, "project.is_first_loan")                 '是否首次贷款

        Me.txtWorkflow.DataBindings.Add("Text", ds, "project.workflow")                                    '运作方式    
        Me.cboGuaranteeLetterType.DataBindings.Add("SelectedValue", ds, "project.guarantee_letter_type")   '保函种类
        Me.cboReimburseType.DataBindings.Add("SelectedValue", ds, "project.reimburse_type")                '偿付责任类型
        Me.txtBeneficiary.DataBindings.Add("Text", ds, "project.beneficiary")                              '受益人名称

        Me.txtProjectName.DataBindings.Add("Text", ds, "project.bh_project_name")                          '项目名称 
        Me.txtProjectContent.DataBindings.Add("Text", ds, "project.bh_project_content")                    '中标内容
        Me.txtImplementAbility.DataBindings.Add("Text", ds, "project.bh_implement_ability")                '履约能力
        Me.txtCounterclaimCondition.DataBindings.Add("Text", ds, "project.bh_counterclaim_condition")      '索赔条件 
        Me.txtBeneficiaryIntroduction.DataBindings.Add("Text", ds, "project.bh_beneficiary_introduction")  '受益人简介
        Me.txtGuaranteeRate.DataBindings.Add("Text", ds, "project.guarantee_rate")    '担保费费率     'added by hute 2005-03-25
        Me.txtEnsureMoneyRate.DataBindings.Add("Text", ds, "project.security_rate") '保证金比率

        bmProject = BindingContext(ds, "project")
        AddHandler bmProject.CurrentChanged, AddressOf BindDataChanged

    End Sub

    Private Sub SignBankChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.dsSignBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code ='" & Me.cboBank.SelectedValue & "'"
    End Sub

    '初始化或绑定窗体中的ComboBox
    Private Sub Init()
        Dim tempDS As DataSet
        tempDS = gWs.GetReimburseType("%")
        Me.cboReimburseType.DataSource = tempDS.Tables(0)
        Me.cboReimburseType.DisplayMember = "name"
        Me.cboReimburseType.ValueMember = "type_code"
        tempDS = gWs.GetGuaranteeLetterType("%")
        Me.cboGuaranteeLetterType.DataSource = tempDS.Tables(0)
        Me.cboGuaranteeLetterType.DisplayMember = "name"
        Me.cboGuaranteeLetterType.ValueMember = "type_code"

        Me.dsSignBank = gWs.GetBankInfo("%", "%")
        Me.cboBank.DataSource = Me.dsSignBank.Tables("bank")
        Me.cboBank.DisplayMember = "bank_name"
        Me.cboBank.ValueMember = "bank_code"
        Me.cboSubBank.DataSource = Me.dsSignBank.Tables("bank_branch").DefaultView
        Me.cboSubBank.DisplayMember = "branch_bank_name"
        Me.cboSubBank.ValueMember = "branch_bank_code"
        SignBankChanged(Nothing, Nothing)

        Dim applyDate As DateTime
        applyDate = ds.Tables("project").Rows(0).Item("apply_date")
        ds.Merge(gWs.GetGuaranteeLetter(Me.CorpCode, applyDate))
        If Not ds.Tables("TGuaranteeLetter").Rows.Count = 0 Then
            Dim project_code As String         '先从GuaranteeLetter中取得project_code
            If Not ds.Tables("TGuaranteeLetter").Rows(0).Item("project_code") Is DBNull.Value Then
                project_code = ds.Tables("TGuaranteeLetter").Rows(0).Item("project_code").ToString()
                If Not project_code = "" Then
                    Try
                        tempDS = New DataSet()
                        tempDS.Merge(gWs.GetGuaranteeLetterUsage("{project_code ='" & project_code & "'}").Tables("TGuaranteeLetterUsage"))
                        tempDS.Merge(gWs.GetGuaranteeLetterType("%").Tables("TGuaranteeLetterType"))
                        tempDS.Relations.Add("RLetterType", tempDS.Tables("TGuaranteeLetterType").Columns("type_code"), tempDS.Tables("TGuaranteeLetterUsage").Columns("guarantee_letter_type"))
                        tempDS.Tables("TGuaranteeLetterUsage").Columns.Add("letter_name", GetType(String), "parent(RLetterType).name")
                        tempDS.Merge(gWs.GetReimburseType("%").Tables("TReimburseType"))
                        tempDS.Relations.Add("RReimburseType", tempDS.Tables("TReimburseType").Columns("type_code"), tempDS.Tables("TGuaranteeLetterUsage").Columns("reimburse_type"))
                        tempDS.Tables("TGuaranteeLetterUsage").Columns.Add("Reimburse_name", GetType(String), "parent(RReimburseType).name")
                        Me.dgRatedUsage.DataSource = tempDS.Tables("TGuaranteeLetterUsage")
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End If
            End If
            Me.txtGuaranteeProjectCode.DataBindings.Add("Text", ds, "TGuaranteeLetter.project_code")
            Me.txtGuaranteeLetterCode.DataBindings.Add("Text", ds, "TGuaranteeLetter.guarantee_letter_code")
            Dim binding As Binding
            binding = New Binding("Text", ds, "TGuaranteeLetter.guarantee_line")
            AddHandler binding.Format, AddressOf DecimalToCurrency
            AddHandler binding.Parse, AddressOf CurrencyToDecimal
            Me.txtGuaranteeLine.DataBindings.Add(binding)
            binding = New Binding("Text", ds, "TGuaranteeLetter.remnant_line")
            AddHandler binding.Format, AddressOf DecimalToCurrency
            AddHandler binding.Parse, AddressOf CurrencyToDecimal
            Me.txtRemnantLine.DataBindings.Add(binding)
            Me.txtTerm.DataBindings.Add("Text", ds, "TGuaranteeLetter.term")
            Dim nowTime As Date = gWs.GetSysTime()
            If ds.Tables("TGuaranteeLetter").Rows(0).Item("startdate") Is DBNull.Value Then
                ds.Tables("TGuaranteeLetter").Rows(0).Item("startdate") = nowTime
            End If
            Me.dtpGuaranteeStartDate.DataBindings.Add("Text", ds, "TGuaranteeLetter.startdate")
            If ds.Tables("TGuaranteeLetter").Rows(0).Item("enddate") Is DBNull.Value Then
                ds.Tables("TGuaranteeLetter").Rows(0).Item("enddate") = nowTime
            End If
            Me.dtpGuaranteeEndDate.DataBindings.Add("Text", ds, "TGuaranteeLetter.enddate")
            Me.cboBank.DataBindings.Add("SelectedValue", ds, "TGuaranteeLetter.bank")
            Me.dsSignBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code ='" & ds.Tables("TGuaranteeLetter").Rows(0).Item("bank") & "'"
            Me.cboSubBank.DataBindings.Add("SelectedValue", ds, "TGuaranteeLetter.bank_branch")
            Me.chkFlag.DataBindings.Add("Checked", ds, "TGuaranteeLetter.flag")
        End If

        Try
            tempDS = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "' AND item_type='52' AND item_code='002'}") '项目调研结论
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                Me.txtOpinion.Text = IIf(tempDS.Tables(0).Rows(0).Item("content") Is DBNull.Value, "", tempDS.Tables(0).Rows(0).Item("content"))
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        '----------------------------------------------------以上代码同项下保函项目评审一样

        Try
            tempDS = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "' AND item_type='52' AND item_code='008'}")  '保函专审员复审意见
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                Me.txtCheckOpinion.Text = IIf(tempDS.Tables(0).Rows(0).Item("content") Is DBNull.Value, "", tempDS.Tables(0).Rows(0).Item("content"))
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        AddHandler txtCheckOpinion.TextChanged, AddressOf BindDataChanged
    End Sub

    '保存project表
    Protected Overrides Function SaveProject() As Boolean
        Dim result As String
        Dim tempDS As DataSet
        Try
            tempDS = gWs.GetProjectInfo("{project_code='" & Me.getProjectCode() & "'}")
            If Not tempDS.Tables("project").Rows.Count = 0 Then
                With tempDS.Tables("project").Rows(0)
                    .Item("guarantee_rate") = Currency2Numeric(Me.txtGuaranteeRate.Text)     '担保费费率     'added by hute 2005-03-25
                    .Item("security_rate") = Currency2Numeric(Me.txtEnsureMoneyRate.Text)     '保证金比率
                    '.Item("create_person") = UserName
                    '.Item("create_date") = SysDate.Date
                End With
            End If
            Dim strResult As String = gWs.UpdateProject(tempDS)
            If strResult <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存项目信息失败", strResult, "")
                Return False
            End If
            Return True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '保存保函专审员复审意见
    Private Function SaveOpinion() As Boolean
        Dim tempDS As DataSet
        Try
            tempDS = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "' AND item_type='52' AND item_code='008'}")  '保函专审员意见
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    .Item("content") = Me.txtCheckOpinion.Text
                End With
            Else
                Dim dr As DataRow = tempDS.Tables(0).NewRow()
                With dr
                    .Item("project_code") = Me.getProjectCode()
                    .Item("content") = Me.txtCheckOpinion.Text
                    .Item("item_type") = "52"   '保函专审员意见
                    .Item("item_code") = "008"
                    .Item("create_person") = UserName
                    .Item("create_date") = gWs.GetSysTime()
                End With
                tempDS.Tables(0).Rows.Add(dr)
            End If
            Dim strResult As String = gWs.UpdateProjectOpinion(tempDS)
            If strResult <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存审核意见失败", strResult, "项目评审")
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    Protected Overrides Function SaveData() As Boolean
        Try
            If Not Me.SaveProject() Then
                Return False
            End If
            If Not Me.SaveOpinion() Then
                Return False
            End If
            Me.bIsChanged = False       '保存成功
            Return True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    '申请金额超过剩余额度
    Protected Function OverRemnantLine() As Boolean
        Dim ApplySum, RemnantLine As Double
        Try
            ApplySum = Currency2Double(Me.txtApplySum.Text)
        Catch
        End Try
        Try
            With ds.Tables("TGuaranteeLetter").Rows(0)
                RemnantLine = IIf(IsDBNull(.Item("remnant_line")), 0, .Item("remnant_line"))
            End With
        Catch
        End Try
        If ApplySum > RemnantLine Then
            If DialogResult.No = SWDialogBox.MessageBox.Show("额度项下保函的申请金额已超过保函综合授信协议的剩余额度,是否提交？", "系统提示", "", SWDialogBox.MessageBoxButton.YesNo, SWDialogBox.MessageBoxIcon.Question) Then
                Return False
            End If
        End If
        Return True
    End Function

    '查看保函样本功能
    Private Sub btnUpdateReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateReport.Click
        Try
            Dim frm As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "45", "103", UserName)
            frm.AllowTransparency = False
            frm.Text = "查看保函样本"
            frm.setIsButtonEnable(True)
            frm.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim strReplaceFrom(23) As String
        Dim Sum As Double
        strReplaceFrom(0) = "&#CheckTime"                  '审核时间
        strReplaceFrom(1) = "&#ProjectCode"                '项目编码　
        strReplaceFrom(2) = "&#CorporationName"            '企业名称
        strReplaceFrom(3) = "&#GuaranteeLetterCode"        '保函协议书编号
        strReplaceFrom(4) = "&#GuaranteeEndDate"           '额度到期日
        strReplaceFrom(5) = "&#RemnantLine"                '剩余额度
        strReplaceFrom(6) = "&#GuaranteeLetterType"        '申请保函的种类
        strReplaceFrom(7) = "&#Term"                       '申请保函的期限
        strReplaceFrom(8) = "&#ApplySum"                   '申请保函的金额
        strReplaceFrom(9) = "&#Bank"                       ' 开具保函银行
        strReplaceFrom(10) = "&#SubBank"                   '
        strReplaceFrom(11) = "&#IsInLine"                  '是否在额度内
        strReplaceFrom(12) = "&#Beneficiary"               '受益人名称
        strReplaceFrom(13) = "&#A_BeneficiaryIntroduction"   '受益人基本情况
        strReplaceFrom(14) = "&#CounterclaimCondition"     '索赔条款
        strReplaceFrom(15) = "&#Opinion"                   '项目经理意见 
        strReplaceFrom(16) = "&#B_Opinion"                   '保函专审员意见 
        strReplaceFrom(17) = "&#B_CheckTime"                 '保函复审时间
        strReplaceFrom(18) = "&#C_Opinion"                   '风险部长意见 
        strReplaceFrom(19) = "&#C_CheckTime"                   '风险部长审批时间 
        strReplaceFrom(20) = "&#GuaranteeRate"               '担保费率
        strReplaceFrom(21) = "&#EnsureMoneyRate"           '保证金比率
        strReplaceFrom(22) = "&#EnsureMoneySum"            '保证金
        strReplaceFrom(23) = "&#Guaranteeline"             '保函额度  

        Dim arrReplaceTo As New ArrayList()
        Dim nowTime As DateTime = gWs.GetSysTime()
        Dim tempDS As DataSet = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "' AND item_type='52' AND item_code='002'}")  '项目调研结论
        If tempDS.Tables(0).Rows.Count = 0 Then
            arrReplaceTo.Add(nowTime.ToString("yyyy年MM月dd日"))           '0
        Else
            arrReplaceTo.Add(CType(tempDS.Tables(0).Rows(0).Item("create_date"), Date).ToString("yyyy年MM月dd日"))           '0
        End If
        arrReplaceTo.Add(Me.txtProjectCode.Text)                       '1
        arrReplaceTo.Add(Me.txtCorporationName.Text)                   '2 
        arrReplaceTo.Add(Me.txtGuaranteeLetterCode.Text)               '3
        arrReplaceTo.Add(ds.Tables("TGuaranteeLetter").Rows(0).Item("enddate"))          '4
        With ds.Tables("TGuaranteeLetter").Rows(0)
            arrReplaceTo.Add(IIf(IsDBNull(.Item("guarantee_line")), 0, .Item("guarantee_line")).ToString()) '保函额度)                       '5 
        End With
        arrReplaceTo.Add(Me.cboGuaranteeLetterType.Text)               '6

        If Not IsDBNull(ds.Tables("project").Rows(0).Item("guarant_start_date")) Then       '7
            With ds.Tables("project").Rows(0)
                arrReplaceTo.Add(CType(.Item("guarant_start_date"), DateTime).ToString("yyyy.MM.dd") + "-" + CType(.Item("guarant_end_date"), DateTime).ToString("yyyy.MM.dd"))
            End With
        Else
            arrReplaceTo.Add("")
        End If

        arrReplaceTo.Add(Me.txtApplySum.Text)                          '8
        arrReplaceTo.Add(Me.cboApplyBank.Text)                              '9
        If Not Me.cboApplyBranch.SelectedItem Is Nothing Then
            arrReplaceTo.Add(Me.cboApplyBranch.Text)                           '10
        Else
            arrReplaceTo.Add("")
        End If
        Dim ApplySum, RemnantLine As Double
        Try
            ApplySum = Currency2Double(Me.txtApplySum.Text)
        Catch
        End Try
        Try
            With ds.Tables("TGuaranteeLetter").Rows(0)
                RemnantLine = IIf(IsDBNull(.Item("remnant_line")), 0, .Item("remnant_line"))
            End With
        Catch
        End Try

        If ApplySum > RemnantLine Then
            arrReplaceTo.Add("□是              ■否")                 '11
        Else
            arrReplaceTo.Add("■是              □否")
        End If
        With ds.Tables("project").Rows(0)
            arrReplaceTo.Add(IIf(IsDBNull(.Item("beneficiary")), "", .Item("beneficiary")))                     '12
            arrReplaceTo.Add(IIf(IsDBNull(.Item("bh_beneficiary_introduction")), "", .Item("bh_beneficiary_introduction")))         '13 
            arrReplaceTo.Add(IIf(IsDBNull(.Item("bh_counterclaim_condition")), "", .Item("bh_counterclaim_condition")))          '14
        End With
        arrReplaceTo.Add(Me.txtOpinion.Text)                           '15 
        arrReplaceTo.Add(Me.txtCheckOpinion.Text)                      '16 
        arrReplaceTo.Add(nowTime.ToString("yyyy年MM月dd日"))           '17 
        arrReplaceTo.Add("")                           '18 
        arrReplaceTo.Add("")                           '19 

        Try
            If Me.txtGuaranteeRate.Text.Trim() = "" Then
                Me.txtGuaranteeRate.Text = "0"
            End If
            arrReplaceTo.Add(CType(Me.txtGuaranteeRate.Text, Decimal) / 100) '20 
        Catch
            arrReplaceTo.Add("")
        End Try

        Try
            If Me.txtEnsureMoneyRate.Text.Trim() = "" Then
                Me.txtEnsureMoneyRate.Text = "0"
            End If
            arrReplaceTo.Add(CType(Me.txtEnsureMoneyRate.Text, Decimal) / 100)  '21
        Catch
            arrReplaceTo.Add("")
        End Try

        Try
            If Me.txtApplySum.Text.Trim() = "" Then
                Me.txtApplySum.Text = "0"
            End If
            If Me.txtEnsureMoneyRate.Text.Trim() = "" Then
                Me.txtEnsureMoneyRate.Text = "0"
            End If

            arrReplaceTo.Add(CType(Me.txtApplySum.Text, Decimal) * CType(Me.txtEnsureMoneyRate.Text, Decimal) * 100)                     '22 
        Catch
            arrReplaceTo.Add("")
        End Try
        Dim guarantee_line As Decimal
        Try
            With ds.Tables("TGuaranteeLetter").Rows(0)
                guarantee_line = IIf(IsDBNull(.Item("guarantee_line")), 0, .Item("guarantee_line"))
            End With
        Catch
        End Try
        arrReplaceTo.Add(guarantee_line.ToString())   '23

        Dim doc As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "45", "105", UserName, strReplaceFrom, arrReplaceTo)
        doc.AllowTransparency = False
        doc.ShowDialog()
    End Sub

    '提交按钮按下 
    Protected Overrides Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If SWDialogBox.MessageBox.Show("?1000", "提交") <> MsgBoxResult.Yes Then
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            If Not Me.SaveData() Then
                Return
            End If
            If Me.txtGuaranteeRate.Text = "" Then
                SWDialogBox.MessageBox.Show("输入的担保费率不符合要求，请重新输入", "提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
                Return
            ElseIf CDec(Me.txtGuaranteeRate.Text) = 0 Then
                SWDialogBox.MessageBox.Show("输入的担保费率不符合要求，请重新输入", "提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
                Return
            End If
            If Not Me.OverRemnantLine() Then
                Return
            End If
            Dim strResult As String
            strResult = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), "", UserName)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "项下保函复审")
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

End Class
