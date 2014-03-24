'项目评审
Public Class frmEvalTrial
    Inherits frmCoMBase

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        MyBase._Phase = "评审"

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
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tpOpinion As System.Windows.Forms.TabPage
    Public WithEvents grpOpinion As System.Windows.Forms.GroupBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents txtOpinion As System.Windows.Forms.TextBox
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents mnuPersonAssure As System.Windows.Forms.MenuItem
    Public WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents mnuMaterial As System.Windows.Forms.MenuItem
    Friend WithEvents mnuImport As System.Windows.Forms.MenuItem
    Friend WithEvents mnuInputFinance As System.Windows.Forms.MenuItem
    Friend WithEvents mnuGuarantee As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFinanceAnalysis As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCreditEstimate As System.Windows.Forms.MenuItem
    Friend WithEvents mnuImportCorp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuImportFinance As System.Windows.Forms.MenuItem

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEvalTrial))
        Me.btnCommit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.tpOpinion = New System.Windows.Forms.TabPage
        Me.grpOpinion = New System.Windows.Forms.GroupBox
        Me.txtOpinion = New System.Windows.Forms.TextBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnuMaterial = New System.Windows.Forms.MenuItem
        Me.mnuImport = New System.Windows.Forms.MenuItem
        Me.mnuImportCorp = New System.Windows.Forms.MenuItem
        Me.mnuImportFinance = New System.Windows.Forms.MenuItem
        Me.mnuInputFinance = New System.Windows.Forms.MenuItem
        Me.mnuGuarantee = New System.Windows.Forms.MenuItem
        Me.mnuPersonAssure = New System.Windows.Forms.MenuItem
        Me.mnuFinanceAnalysis = New System.Windows.Forms.MenuItem
        Me.mnuCreditEstimate = New System.Windows.Forms.MenuItem
        Me.btnReport = New System.Windows.Forms.Button
        Me.Label18 = New System.Windows.Forms.Label
        Me.grpProjectHeader.SuspendLayout()
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCoMBase.SuspendLayout()
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpOpinion.SuspendLayout()
        Me.grpOpinion.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboIndustryType
        '
        Me.cboIndustryType.DropDownWidth = 224
        Me.cboIndustryType.Location = New System.Drawing.Point(496, 94)
        Me.cboIndustryType.Name = "cboIndustryType"
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Location = New System.Drawing.Point(96, 304)
        Me.txtContactPerson.Name = "txtContactPerson"
        '
        'txtRepreID
        '
        Me.txtRepreID.Location = New System.Drawing.Point(608, 230)
        Me.txtRepreID.Name = "txtRepreID"
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Location = New System.Drawing.Point(352, 278)
        Me.txtContactNumber.Name = "txtContactNumber"
        Me.txtContactNumber.Size = New System.Drawing.Size(144, 21)
        '
        'cboMoneyType
        '
        Me.cboMoneyType.DropDownWidth = 144
        Me.cboMoneyType.ItemHeight = 12
        Me.cboMoneyType.Location = New System.Drawing.Point(352, 184)
        Me.cboMoneyType.Name = "cboMoneyType"
        Me.cboMoneyType.Size = New System.Drawing.Size(144, 21)
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(608, 278)
        Me.txtFax.Name = "txtFax"
        '
        'txtCashReceive
        '
        Me.txtCashReceive.Location = New System.Drawing.Point(608, 208)
        Me.txtCashReceive.Name = "txtCashReceive"
        '
        'txtCreditLevel
        '
        Me.txtCreditLevel.Location = New System.Drawing.Point(96, 158)
        Me.txtCreditLevel.Name = "txtCreditLevel"
        '
        'lblCorpBusinessCode
        '
        Me.lblCorpBusinessCode.Name = "lblCorpBusinessCode"
        '
        'txtCorpID
        '
        Me.txtCorpID.Name = "txtCorpID"
        '
        'lblCorpPaperID
        '
        Me.lblCorpPaperID.Name = "lblCorpPaperID"
        '
        'lblContactorFax
        '
        Me.lblContactorFax.Location = New System.Drawing.Point(512, 280)
        Me.lblContactorFax.Name = "lblContactorFax"
        '
        'txtLoanID
        '
        Me.txtLoanID.Location = New System.Drawing.Point(352, 46)
        Me.txtLoanID.Name = "txtLoanID"
        Me.txtLoanID.Size = New System.Drawing.Size(144, 21)
        '
        'txtRepreNation
        '
        Me.txtRepreNation.Location = New System.Drawing.Point(608, 256)
        Me.txtRepreNation.Name = "txtRepreNation"
        '
        'lblCorpRepreCardID
        '
        Me.lblCorpRepreCardID.Name = "lblCorpRepreCardID"
        '
        'lblCorpContactNumber
        '
        Me.lblCorpContactNumber.Location = New System.Drawing.Point(264, 280)
        Me.lblCorpContactNumber.Name = "lblCorpContactNumber"
        '
        'lblCorpContactor
        '
        Me.lblCorpContactor.Location = New System.Drawing.Point(8, 304)
        Me.lblCorpContactor.Name = "lblCorpContactor"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Value = New Date(2003, 7, 3, 0, 0, 0, 0)
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(352, 22)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpStartDate.Value = New Date(2003, 7, 3, 0, 0, 0, 0)
        '
        'txtRepID
        '
        Me.txtRepID.Name = "txtRepID"
        '
        'lblCorpCardID
        '
        Me.lblCorpCardID.Name = "lblCorpCardID"
        '
        'Label14
        '
        Me.Label14.Name = "Label14"
        '
        'lblCorpInvisibleAsset
        '
        Me.lblCorpInvisibleAsset.Location = New System.Drawing.Point(8, 208)
        Me.lblCorpInvisibleAsset.Name = "lblCorpInvisibleAsset"
        '
        'txtInvisibleAssets
        '
        Me.txtInvisibleAssets.Location = New System.Drawing.Point(96, 208)
        Me.txtInvisibleAssets.Name = "txtInvisibleAssets"
        '
        'txtLoanCardID
        '
        Me.txtLoanCardID.Name = "txtLoanCardID"
        '
        'lblCorpRepre
        '
        Me.lblCorpRepre.Location = New System.Drawing.Point(8, 256)
        Me.lblCorpRepre.Name = "lblCorpRepre"
        '
        'lblCorpRegisterAddress
        '
        Me.lblCorpRegisterAddress.Name = "lblCorpRegisterAddress"
        '
        'Label7
        '
        Me.Label7.Name = "Label7"
        '
        'lblCorpRepreID
        '
        Me.lblCorpRepreID.Location = New System.Drawing.Point(504, 232)
        Me.lblCorpRepreID.Name = "lblCorpRepreID"
        '
        'lblCorpRepreNation
        '
        Me.lblCorpRepreNation.Location = New System.Drawing.Point(504, 256)
        Me.lblCorpRepreNation.Name = "lblCorpRepreNation"
        '
        'lblCorpCreditLevel
        '
        Me.lblCorpCreditLevel.Location = New System.Drawing.Point(8, 160)
        Me.lblCorpCreditLevel.Name = "lblCorpCreditLevel"
        '
        'lblCorpEvalInstitute
        '
        Me.lblCorpEvalInstitute.Location = New System.Drawing.Point(264, 160)
        Me.lblCorpEvalInstitute.Name = "lblCorpEvalInstitute"
        '
        'txtAddressDetail
        '
        Me.txtAddressDetail.Name = "txtAddressDetail"
        '
        'lblCorpIndustryType
        '
        Me.lblCorpIndustryType.Name = "lblCorpIndustryType"
        '
        'lblCorpPropriateShip
        '
        Me.lblCorpPropriateShip.Name = "lblCorpPropriateShip"
        '
        'lblCorpTechType
        '
        Me.lblCorpTechType.Location = New System.Drawing.Point(8, 120)
        Me.lblCorpTechType.Name = "lblCorpTechType"
        '
        'clbTechType
        '
        Me.clbTechType.Location = New System.Drawing.Point(96, 120)
        Me.clbTechType.Name = "clbTechType"
        '
        'lblCorpRealAsset
        '
        Me.lblCorpRealAsset.Location = New System.Drawing.Point(264, 210)
        Me.lblCorpRealAsset.Name = "lblCorpRealAsset"
        '
        'dtpFoundDate
        '
        Me.dtpFoundDate.Name = "dtpFoundDate"
        Me.dtpFoundDate.Value = New Date(2003, 7, 3, 0, 0, 0, 0)
        '
        'lblFoundDate
        '
        Me.lblFoundDate.Name = "lblFoundDate"
        '
        'lblAttachMember
        '
        Me.lblAttachMember.Location = New System.Drawing.Point(8, 352)
        Me.lblAttachMember.Name = "lblAttachMember"
        '
        'txtRepresentative
        '
        Me.txtRepresentative.Location = New System.Drawing.Point(96, 256)
        Me.txtRepresentative.Name = "txtRepresentative"
        '
        'lblAttachMaster
        '
        Me.lblAttachMaster.Location = New System.Drawing.Point(264, 352)
        Me.lblAttachMaster.Name = "lblAttachMaster"
        '
        'lblAttachColledge
        '
        Me.lblAttachColledge.Location = New System.Drawing.Point(264, 328)
        Me.lblAttachColledge.Name = "lblAttachColledge"
        '
        'txtContactMobile
        '
        Me.txtContactMobile.Location = New System.Drawing.Point(96, 328)
        Me.txtContactMobile.Name = "txtContactMobile"
        '
        'lblCorpCashArrived
        '
        Me.lblCorpCashArrived.Location = New System.Drawing.Point(504, 210)
        Me.lblCorpCashArrived.Name = "lblCorpCashArrived"
        '
        'txtContactEmail
        '
        Me.txtContactEmail.Location = New System.Drawing.Point(352, 302)
        Me.txtContactEmail.Name = "txtContactEmail"
        Me.txtContactEmail.Size = New System.Drawing.Size(144, 21)
        '
        'txtRealCapital
        '
        Me.txtRealCapital.Location = New System.Drawing.Point(352, 208)
        Me.txtRealCapital.Name = "txtRealCapital"
        Me.txtRealCapital.Size = New System.Drawing.Size(144, 21)
        '
        'txtLegelPhone
        '
        Me.txtLegelPhone.Location = New System.Drawing.Point(96, 280)
        Me.txtLegelPhone.Name = "txtLegelPhone"
        '
        'txtRegCapital
        '
        Me.txtRegCapital.Location = New System.Drawing.Point(96, 182)
        Me.txtRegCapital.Name = "txtRegCapital"
        '
        'txtLegelMobile
        '
        Me.txtLegelMobile.Location = New System.Drawing.Point(352, 254)
        Me.txtLegelMobile.Name = "txtLegelMobile"
        Me.txtLegelMobile.Size = New System.Drawing.Size(144, 21)
        '
        'lblCorpBusinessStartDate
        '
        Me.lblCorpBusinessStartDate.Name = "lblCorpBusinessStartDate"
        '
        'lblCorpBusinessEndDate
        '
        Me.lblCorpBusinessEndDate.Name = "lblCorpBusinessEndDate"
        '
        'lblCorpRegisterAsset
        '
        Me.lblCorpRegisterAsset.Location = New System.Drawing.Point(8, 184)
        Me.lblCorpRegisterAsset.Name = "lblCorpRegisterAsset"
        '
        'chkIsFirstLoan
        '
        Me.chkIsFirstLoan.Location = New System.Drawing.Point(16, 232)
        Me.chkIsFirstLoan.Name = "chkIsFirstLoan"
        '
        'cboApplyServiceType
        '
        Me.cboApplyServiceType.DropDownWidth = 128
        Me.cboApplyServiceType.ItemHeight = 12
        Me.cboApplyServiceType.Name = "cboApplyServiceType"
        Me.cboApplyServiceType.Size = New System.Drawing.Size(160, 20)
        '
        'lblProjectRequestTerm
        '
        Me.lblProjectRequestTerm.Name = "lblProjectRequestTerm"
        '
        'lblProjectCooperateOpinion
        '
        Me.lblProjectCooperateOpinion.Name = "lblProjectCooperateOpinion"
        '
        'lblProjectRecommendSum
        '
        Me.lblProjectRecommendSum.Name = "lblProjectRecommendSum"
        '
        'lblProjectRecommendDate
        '
        Me.lblProjectRecommendDate.Name = "lblProjectRecommendDate"
        '
        'cboApplyBranch
        '
        Me.cboApplyBranch.ItemHeight = 12
        Me.cboApplyBranch.Name = "cboApplyBranch"
        Me.cboApplyBranch.Size = New System.Drawing.Size(184, 20)
        '
        'lblProjectRequestSum
        '
        Me.lblProjectRequestSum.Name = "lblProjectRequestSum"
        '
        'lblProjectRequestBank
        '
        Me.lblProjectRequestBank.Name = "lblProjectRequestBank"
        '
        'lblProjectRequestBranch
        '
        Me.lblProjectRequestBranch.Name = "lblProjectRequestBranch"
        '
        'cboApplyBank
        '
        Me.cboApplyBank.ItemHeight = 12
        Me.cboApplyBank.Name = "cboApplyBank"
        Me.cboApplyBank.Size = New System.Drawing.Size(152, 20)
        '
        'lblProjectRequestServiceType
        '
        Me.lblProjectRequestServiceType.Name = "lblProjectRequestServiceType"
        '
        'lblProjectRequestDate
        '
        Me.lblProjectRequestDate.Name = "lblProjectRequestDate"
        '
        'grpProjectBody
        '
        Me.grpProjectBody.Name = "grpProjectBody"
        Me.grpProjectBody.Size = New System.Drawing.Size(768, 424)
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Location = New System.Drawing.Point(16, 16)
        Me.lblProjectCode.Name = "lblProjectCode"
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Name = "lblCorporationName"
        '
        'lblProjectPhase
        '
        Me.lblProjectPhase.Name = "lblProjectPhase"
        Me.lblProjectPhase.Size = New System.Drawing.Size(62, 23)
        '
        'grpProjectHeader
        '
        Me.grpProjectHeader.Controls.Add(Me.Label18)
        Me.grpProjectHeader.Name = "grpProjectHeader"
        Me.grpProjectHeader.Controls.SetChildIndex(Me.Label18, 0)
        Me.grpProjectHeader.Controls.SetChildIndex(Me.lblProjectCode, 0)
        Me.grpProjectHeader.Controls.SetChildIndex(Me.lblCorporationName, 0)
        Me.grpProjectHeader.Controls.SetChildIndex(Me.lblProjectPhase, 0)
        Me.grpProjectHeader.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.grpProjectHeader.Controls.SetChildIndex(Me.txtCorporationName, 0)
        Me.grpProjectHeader.Controls.SetChildIndex(Me.txtPhase, 0)
        '
        'txtEmployeeAmount
        '
        Me.txtEmployeeAmount.Location = New System.Drawing.Point(96, 352)
        Me.txtEmployeeAmount.Name = "txtEmployeeAmount"
        '
        'txtDoctorNum
        '
        Me.txtDoctorNum.Location = New System.Drawing.Point(608, 350)
        Me.txtDoctorNum.Name = "txtDoctorNum"
        '
        'txtMasterNum
        '
        Me.txtMasterNum.Location = New System.Drawing.Point(352, 350)
        Me.txtMasterNum.Name = "txtMasterNum"
        Me.txtMasterNum.Size = New System.Drawing.Size(144, 21)
        '
        'txtBachelorNum
        '
        Me.txtBachelorNum.Location = New System.Drawing.Point(608, 326)
        Me.txtBachelorNum.Name = "txtBachelorNum"
        '
        'txtColledgeNum
        '
        Me.txtColledgeNum.Location = New System.Drawing.Point(352, 326)
        Me.txtColledgeNum.Name = "txtColledgeNum"
        Me.txtColledgeNum.Size = New System.Drawing.Size(144, 21)
        '
        'groupbox
        '
        Me.groupbox.Name = "groupbox"
        Me.groupbox.Size = New System.Drawing.Size(85, 387)
        '
        'pgCorpInfo
        '
        Me.pgCorpInfo.Name = "pgCorpInfo"
        Me.pgCorpInfo.Size = New System.Drawing.Size(85, 387)
        '
        'txtRecommendSum
        '
        Me.txtRecommendSum.Name = "txtRecommendSum"
        '
        'dtpRecommend
        '
        Me.dtpRecommend.Name = "dtpRecommend"
        Me.dtpRecommend.Value = New Date(2003, 6, 18, 0, 0, 0, 0)
        '
        'cboRecommendType
        '
        Me.cboRecommendType.Name = "cboRecommendType"
        Me.cboRecommendType.Size = New System.Drawing.Size(80, 20)
        '
        'txtApplySum
        '
        Me.txtApplySum.Name = "txtApplySum"
        '
        'nuTerm
        '
        Me.nuTerm.Name = "nuTerm"
        '
        'lblMoneyType
        '
        Me.lblMoneyType.Location = New System.Drawing.Point(264, 184)
        Me.lblMoneyType.Name = "lblMoneyType"
        '
        'dtpApplyDate
        '
        Me.dtpApplyDate.Enabled = False
        Me.dtpApplyDate.Name = "dtpApplyDate"
        Me.dtpApplyDate.Value = New Date(2003, 6, 18, 0, 0, 0, 0)
        '
        'txtPurpose
        '
        Me.txtPurpose.Name = "txtPurpose"
        '
        'txtRecommendPerson
        '
        Me.txtRecommendPerson.Name = "txtRecommendPerson"
        '
        'txtCooperateOpinion
        '
        Me.txtCooperateOpinion.Name = "txtCooperateOpinion"
        Me.txtCooperateOpinion.Size = New System.Drawing.Size(656, 80)
        '
        'grpRequest
        '
        Me.grpRequest.Location = New System.Drawing.Point(0, 131)
        Me.grpRequest.Name = "grpRequest"
        Me.grpRequest.Size = New System.Drawing.Size(754, 248)
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 280)
        Me.Label16.Name = "Label16"
        '
        'cboProprietorShip
        '
        Me.cboProprietorShip.DropDownWidth = 160
        Me.cboProprietorShip.Location = New System.Drawing.Point(96, 94)
        Me.cboProprietorShip.Name = "cboProprietorShip"
        Me.cboProprietorShip.Size = New System.Drawing.Size(264, 21)
        '
        'cboRecommendItems
        '
        Me.cboRecommendItems.ItemHeight = 12
        Me.cboRecommendItems.Name = "cboRecommendItems"
        Me.cboRecommendItems.Size = New System.Drawing.Size(104, 20)
        '
        'txtPhase
        '
        Me.txtPhase.Name = "txtPhase"
        Me.txtPhase.Size = New System.Drawing.Size(75, 21)
        '
        'grpProjectPassed
        '
        Me.grpProjectPassed.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grpProjectPassed.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpProjectPassed.Location = New System.Drawing.Point(0, 0)
        Me.grpProjectPassed.Name = "grpProjectPassed"
        Me.grpProjectPassed.Size = New System.Drawing.Size(754, 136)
        '
        'pgProject
        '
        Me.pgProject.Name = "pgProject"
        Me.pgProject.Size = New System.Drawing.Size(754, 379)
        '
        'cboAddressRange
        '
        Me.cboAddressRange.DropDownWidth = 112
        Me.cboAddressRange.Name = "cboAddressRange"
        '
        'txtEvalInstitute
        '
        Me.txtEvalInstitute.Location = New System.Drawing.Point(352, 158)
        Me.txtEvalInstitute.Name = "txtEvalInstitute"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(264, 256)
        Me.Label13.Name = "Label13"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 328)
        Me.Label11.Name = "Label11"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(264, 304)
        Me.Label10.Name = "Label10"
        '
        'tabCoMBase
        '
        Me.tabCoMBase.Controls.Add(Me.tpOpinion)
        Me.tabCoMBase.ItemSize = New System.Drawing.Size(60, 17)
        Me.tabCoMBase.Name = "tabCoMBase"
        Me.tabCoMBase.Size = New System.Drawing.Size(762, 404)
        Me.tabCoMBase.Controls.SetChildIndex(Me.tpOpinion, 0)
        Me.tabCoMBase.Controls.SetChildIndex(Me.pgCorpInfo, 0)
        Me.tabCoMBase.Controls.SetChildIndex(Me.pgProject, 0)
        '
        'lblAttachDoctor
        '
        Me.lblAttachDoctor.Location = New System.Drawing.Point(512, 352)
        Me.lblAttachDoctor.Name = "lblAttachDoctor"
        '
        'lblAttachBancholer
        '
        Me.lblAttachBancholer.Location = New System.Drawing.Point(512, 328)
        Me.lblAttachBancholer.Name = "lblAttachBancholer"
        '
        'dgProject
        '
        Me.dgProject.AccessibleName = "DataGrid"
        Me.dgProject.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgProject.Name = "dgProject"
        Me.dgProject.Size = New System.Drawing.Size(748, 116)
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Name = "txtCorporationName"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Name = "txtProjectCode"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.Location = New System.Drawing.Point(519, 491)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 46
        Me.btnExit.TabStop = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(427, 491)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 45
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(332, 491)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 24)
        Me.btnSave.TabIndex = 44
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tpOpinion
        '
        Me.tpOpinion.Controls.Add(Me.grpOpinion)
        Me.tpOpinion.Location = New System.Drawing.Point(4, 21)
        Me.tpOpinion.Name = "tpOpinion"
        Me.tpOpinion.Size = New System.Drawing.Size(754, 387)
        Me.tpOpinion.TabIndex = 13
        Me.tpOpinion.Text = "评审意见"
        '
        'grpOpinion
        '
        Me.grpOpinion.Controls.Add(Me.txtOpinion)
        Me.grpOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpOpinion.Location = New System.Drawing.Point(0, 0)
        Me.grpOpinion.Name = "grpOpinion"
        Me.grpOpinion.Size = New System.Drawing.Size(754, 387)
        Me.grpOpinion.TabIndex = 0
        Me.grpOpinion.TabStop = False
        '
        'txtOpinion
        '
        Me.txtOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOpinion.Location = New System.Drawing.Point(3, 17)
        Me.txtOpinion.MaxLength = 250
        Me.txtOpinion.Multiline = True
        Me.txtOpinion.Name = "txtOpinion"
        Me.txtOpinion.Size = New System.Drawing.Size(748, 367)
        Me.txtOpinion.TabIndex = 0
        Me.txtOpinion.Text = ""
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMaterial, Me.mnuImport, Me.mnuInputFinance, Me.mnuGuarantee, Me.mnuPersonAssure, Me.mnuFinanceAnalysis, Me.mnuCreditEstimate})
        '
        'mnuMaterial
        '
        Me.mnuMaterial.Index = 0
        Me.mnuMaterial.Text = "查验材料清单(&I)"
        '
        'mnuImport
        '
        Me.mnuImport.Index = 1
        Me.mnuImport.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuImportCorp, Me.mnuImportFinance})
        Me.mnuImport.Text = "导入历史数据(&O)"
        '
        'mnuImportCorp
        '
        Me.mnuImportCorp.Index = 0
        Me.mnuImportCorp.Text = "企业信息"
        '
        'mnuImportFinance
        '
        Me.mnuImportFinance.Index = 1
        Me.mnuImportFinance.Text = "财务数据"
        '
        'mnuInputFinance
        '
        Me.mnuInputFinance.Index = 2
        Me.mnuInputFinance.Text = "录入财务数据(&F)"
        '
        'mnuGuarantee
        '
        Me.mnuGuarantee.Index = 3
        Me.mnuGuarantee.Text = "输入保证企业(&G)"
        '
        'mnuPersonAssure
        '
        Me.mnuPersonAssure.Index = 4
        Me.mnuPersonAssure.Text = "个人保证信息处理(&P)"
        '
        'mnuFinanceAnalysis
        '
        Me.mnuFinanceAnalysis.Index = 5
        Me.mnuFinanceAnalysis.Text = "财务分析(&A)"
        '
        'mnuCreditEstimate
        '
        Me.mnuCreditEstimate.Index = 6
        Me.mnuCreditEstimate.Text = "资信评分(&M)"
        '
        'btnReport
        '
        Me.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.ImageIndex = 18
        Me.btnReport.ImageList = Me.ImageListBasic
        Me.btnReport.Location = New System.Drawing.Point(191, 491)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(122, 24)
        Me.btnReport.TabIndex = 43
        Me.btnReport.Text = "评审报告管理(&R)"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label18.Location = New System.Drawing.Point(3997, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 23)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "项目阶段"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEvalTrial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(786, 523)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCommit)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Menu = Me.MainMenu1
        Me.MinimizeBox = False
        Me.Name = "frmEvalTrial"
        Me.Text = "项目评审"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnReport, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.grpProjectBody, 0)
        Me.Controls.SetChildIndex(Me.grpProjectHeader, 0)
        Me.grpProjectHeader.ResumeLayout(False)
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCoMBase.ResumeLayout(False)
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpOpinion.ResumeLayout(False)
        Me.grpOpinion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim Project_code, Phase_Code As String '从窗体frmProjectCorpInfo选择的要导入的项目编码和阶段值

    Private Sub EvalTrial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            MyBase.InitCorpCodeAndPhase()
            MyBase.InitComboBox()
            MyBase.InitDataSet()
            MyBase.GetData()
            Me.Init()
            Me.bFormLoad = True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '获取与评审相关的数据
    Private Sub Init()
        dsTemp = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me._ProCode & "' AND item_type='52' and item_code='002'}")
        If Not dstemp.Tables(0).Rows.Count = 0 Then
            With dstemp.Tables(0).Rows(0)
                Me.txtOpinion.Text = IIf(IsDBNull(.Item("content")), "", .Item("content")) '项目调研结论
            End With
        End If

        AddHandler txtOpinion.TextChanged, AddressOf BindDataChanged
    End Sub

    '保存项目评审数据
    Private Function EvalTrialSave() As Boolean
        If Not Save() Then
            Return False
        End If

        dsTemp = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me._ProCode & "' AND item_type='52' and item_code='002'}")
        If Not dstemp.Tables(0).Rows.Count = 0 Then
            With dstemp.Tables(0).Rows(0)
                .Item("content") = Me.txtOpinion.Text                '项目调研结论
            End With
        Else
            Dim dr As DataRow = dstemp.Tables(0).NewRow()
            With dr
                .Item("project_code") = Me._ProCode
                .Item("content") = Me.txtOpinion.Text
                .Item("item_type") = "52"   '项目调研结论
                .Item("item_code") = "002"
                .Item("create_person") = UserName
                .Item("create_date") = SysDate
            End With
            dstemp.Tables(0).Rows.Add(dr)
        End If

        Dim strResult As String = gWs.UpdateProjectOpinion(dsTemp)
        If Not strResult = "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存评审审核意见失败", strResult, "项目评审")
            Return False
        Else
            bIsChanged = False
            Return True
        End If
    End Function

#Region "菜单与按钮"

    '导入企业信息
    Private Sub mnuImportCorp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImportCorp.Click
        Dim f As New frmProjectCorpInfo(Me._CorpCode)
        f.ShowDialog()
        Project_code = f.Project_code
        Phase_Code = f.Phase_Code
        If Project_code = "" Or Phase_Code = "" Or (Project_code = Me._ProCode And Phase_Code = "评审") Then
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            If Me.ds.Tables("TProjectCorporation").Rows.Count > 0 Then
                'MsgBox("是否覆盖已存在的数据？", MsgBoxStyle.OKCancel Or MsgBoxStyle.Question, "项目评审")
                If SWDialogBox.MessageBox.Show("!1002") <> MsgBoxResult.Yes Then
                    Return
                End If
            End If

            Dim dt As DataTable
            dsTemp = gWs.FetchProjectCorporation(Me._ProCode, Me._CorpCode, "1", Me._Phase)
            dt = gWs.FetchProjectCorporation(Project_code, Me._CorpCode, "1", Phase_Code).Tables("TProjectCorporation")
            If dt.Rows.Count > 0 Then
                If dsTemp.Tables("TProjectCorporation").Rows.Count > 0 Then
                    With dsTemp.Tables("TProjectCorporation").Rows(0)
                        .ItemArray = dt.Rows(0).ItemArray
                        .Item("phase") = Me._Phase
                        .Item("project_code") = Me._ProCode
                        .Item("corporation_name") = Me.CorpName
                        .Item("create_person") = UserName
                        .Item("create_date") = SysDate
                    End With

                Else
                    Dim dr As DataRow = dsTemp.Tables("TProjectCorporation").NewRow()
                    With dr
                        .ItemArray = dt.Rows(0).ItemArray
                        .Item("phase") = Me._Phase
                        .Item("project_code") = Me._ProCode
                        .Item("corporation_name") = Me.CorpName
                        .Item("create_person") = UserName
                        .Item("create_date") = SysDate
                    End With
                    dsTemp.Tables("TProjectCorporation").Rows.Add(dr)
                End If

                Dim strResult As String = gWs.UpdateProjectCorporation(dsTemp)
                If Not strResult = "1" Then
                    SWDialogBox.MessageBox.Show("*999", "复制企业信息失败,原因是：", strResult, "项目评审")
                Else
                    SWDialogBox.MessageBox.Show("$OperateSucceed")

                    With ds.Tables("TProjectCorporation").Rows(0)
                        .ItemArray = dt.Rows(0).ItemArray
                        Me.int_TechTypes = dt.Rows(0).Item("technology_type")
                    End With
                    Me.ds.AcceptChanges()

                    Me.tabCoMBase.Visible = False
                    Me.tabCoMBase.Tag = Me.tabCoMBase.SelectedIndex
                    Dim i As Integer
                    For i = 0 To Me.tabCoMBase.TabPages.Count - 1
                        Me.tabCoMBase.SelectedIndex = i
                    Next
                    Me.tabCoMBase.SelectedIndex = CInt(Me.tabCoMBase.Tag)
                    Me.tabCoMBase.Visible = True

                    Me.InitTechType()
                    Me.clbTechType_Leave(Nothing, Nothing)
                    Me.bIsChanged = False
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '导入财务数据
    Private Sub mnuImportFinance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuImportFinance.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim f As New FImportFinance(Me._ProCode, "评审", Me.getCorporationName())
            f.AllowTransparency = False
            f.ShowDialog()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '录入财务数据菜单　
    Private Sub mnuInputFinance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuInputFinance.Click
        Dim finance As New frmFinanceManage(getProjectCode, getCorporationName, Me._CorpCode, "评审", Me)
        finance.AllowTransparency = False
        finance.ShowDialog()
    End Sub
    '查验材料清单菜单
    Private Sub mnuMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMaterial.Click
        Dim mat As New frmInspectMaterial()
        mat.OpenApplyTool(getProjectCode(), getCorporationName(), getWorkFlowID(), getTaskID(), Me, UserName)
    End Sub
    '输入保证企业菜单
    Private Sub mnuGuarantee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGuarantee.Click
        Dim assure As New frmCorAssureList()
        assure.Text = "输入保证企业"
        assure.OpenApplyTool(getProjectCode(), getCorporationName(), getWorkFlowID(), getTaskID(), Me, UserName)
    End Sub
    '个人保证信息处理菜单
    Private Sub mnuPersonAssure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPersonAssure.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frm As New frmPersonAssure(Me.getProjectCode(), Me.getCorporationName())
            frm.AllowTransparency = False
            frm.ShowDialog()
        Catch ex As Exception
            'modified by Michael
            'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '财务分析菜单
    Private Sub mnuFinanceAnalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFinanceAnalysis.Click
        Try
            If Not Me.EvalTrialSave() Then
                Return
            End If
            Call Me.AnalisisFinance(Me._ProCode, Me._CorpCode, "评审")
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '资信评分菜单
    Private Sub mnuCreditEstimate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCreditEstimate.Click
        Dim ds As DataSet
        ds = gWs.GetAccount("{project_code LIKE '" & Me.getProjectCode() & "' AND phase LIKE '评审'}")
        If ds.Tables(0).Rows.Count = 0 Then
            SWDialogBox.MessageBox.Show("$1005", "该项目的评审财务数据")  '不存在相应阶段的财务数据
            Return
        End If

        Dim f As New FProjectCredit()
        'f.Show()
        f.SetEditState(False)
        f.ShowDialog(Me._ProCode, Me._CorpCode, _Phase)
    End Sub

    '保存按钮
    Private Shadows Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not EvalTrialSave() Then
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
        Try
            If Not Me.EvalTrialSave() Then Return
            If SWDialogBox.MessageBox.Show("?1000", "提交") <> MsgBoxResult.Yes Then
                Return
            End If

            If cboApplyServiceType.Text.Trim = "小额委托放款" Then
                If Not Me.HasReport("202", "45") Then
                    SWDialogBox.MessageBox.Show("$1005", "评审报告")
                    Return
                End If
            Else
                If Not Me.HasReport("002", "45") Then
                    ' MsgBox("评审报告没有上载，不能提交！", MsgBoxStyle.Exclamation, "项目评审") '*999
                    SWDialogBox.MessageBox.Show("$1005", "评审报告")
                    Return
                End If
            End If

            Dim strResult As String = gWs.finishedTask(getWorkFlowID(), getProjectCode(), getTaskID(), "", UserName)
            If strResult <> "1" Then
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
    '退出按钮
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If bIsChanged Then
            'MsgBox("您已经修改了数据，要保存吗？", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question, "项目评审")
            Select Case SWDialogBox.MessageBox.Show("?1003")
                Case MsgBoxResult.Yes
                    btnSave_Click(sender, e)
                    Me.Close()
                Case MsgBoxResult.No
                    Close()
                    'e.Cancel = True
            End Select
        Else
            Close()
        End If
    End Sub
    '评审报告管理
    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Try
            If Not EvalTrialSave() Then
                Return
            End If
            If Not Me.hasFinanceAnalysis(Me._ProCode, "评审") Then
                If DialogResult.No = SWDialogBox.MessageBox.Show("?X008") Then
                    Return
                End If
            End If
            Me.Cursor = Cursors.WaitCursor
            If cboApplyServiceType.Text.Trim = "小额委托放款" Then
                Dim doc As New frmDocumentManageBusiness(getProjectCode, getTaskID, getCorporationName, "45", "202", UserName)
                doc.AllowTransparency = False
                doc.ShowDialog()
            Else
                Dim doc As New frmDocumentManageBusiness(getProjectCode, getTaskID, getCorporationName, "45", "002", UserName)
                doc.AllowTransparency = False
                doc.ShowDialog()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#End Region

End Class
