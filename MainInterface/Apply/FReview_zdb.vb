
'再担保项目审核
Public Class FReview_zdb
    Inherits FReviewBase

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
    Protected WithEvents pgOrganization As System.Windows.Forms.TabPage
    Protected WithEvents grpOrganization As System.Windows.Forms.GroupBox
    Protected WithEvents lblName As System.Windows.Forms.Label
    Protected WithEvents lblOpinion50001 As System.Windows.Forms.Label
    Protected WithEvents txtOpinion50001 As System.Windows.Forms.TextBox
    Protected WithEvents txtReguaranteeCondition As System.Windows.Forms.TextBox
    Protected WithEvents lblReguaranteeCondition As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Protected WithEvents txtSourceServiceType As System.Windows.Forms.TextBox
    Protected WithEvents lblSourceServiceType As System.Windows.Forms.Label
    Protected WithEvents txtSourceLoanTerm As System.Windows.Forms.TextBox
    Protected WithEvents txtSourceLoanSum As System.Windows.Forms.TextBox
    Protected WithEvents lblSourceLoanTerm As System.Windows.Forms.Label
    Protected WithEvents lblSourceLoanSum As System.Windows.Forms.Label
    Protected WithEvents txtSourceGuaranteeFee As System.Windows.Forms.TextBox
    Protected WithEvents lblSourceGuaranteeFee As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FReview_zdb))
        Me.pgOrganization = New System.Windows.Forms.TabPage()
        Me.grpOrganization = New System.Windows.Forms.GroupBox()
        Me.txtSourceGuaranteeFee = New System.Windows.Forms.TextBox()
        Me.lblSourceGuaranteeFee = New System.Windows.Forms.Label()
        Me.txtSourceServiceType = New System.Windows.Forms.TextBox()
        Me.lblSourceServiceType = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSourceLoanTerm = New System.Windows.Forms.TextBox()
        Me.txtSourceLoanSum = New System.Windows.Forms.TextBox()
        Me.lblSourceLoanTerm = New System.Windows.Forms.Label()
        Me.lblSourceLoanSum = New System.Windows.Forms.Label()
        Me.txtOpinion50001 = New System.Windows.Forms.TextBox()
        Me.lblOpinion50001 = New System.Windows.Forms.Label()
        Me.txtReguaranteeCondition = New System.Windows.Forms.TextBox()
        Me.lblReguaranteeCondition = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tabReview.SuspendLayout()
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgProject.SuspendLayout()
        Me.grpProjectPassed.SuspendLayout()
        Me.grpRequest.SuspendLayout()
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgCorpInfo.SuspendLayout()
        Me.grpProjectHeader.SuspendLayout()
        Me.grpProjectBody.SuspendLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgOrganization.SuspendLayout()
        Me.grpOrganization.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboIndustryType
        '
        Me.cboIndustryType.DropDownWidth = 240
        Me.cboIndustryType.Size = New System.Drawing.Size(248, 20)
        Me.cboIndustryType.Visible = True
        '
        'cboProprietorShip
        '
        Me.cboProprietorShip.DropDownWidth = 288
        Me.cboProprietorShip.Size = New System.Drawing.Size(288, 20)
        Me.cboProprietorShip.Visible = True
        '
        'cboMainServiceType
        '
        Me.cboMainServiceType.DropDownWidth = 128
        Me.cboMainServiceType.Location = New System.Drawing.Point(248, 231)
        Me.cboMainServiceType.Size = New System.Drawing.Size(248, 20)
        '
        'lblMainServiceType
        '
        Me.lblMainServiceType.Location = New System.Drawing.Point(184, 231)
        '
        'cboRecommendType
        '
        Me.cboRecommendType.Size = New System.Drawing.Size(80, 20)
        Me.cboRecommendType.Visible = True
        '
        'cboApplyBank
        '
        Me.cboApplyBank.ItemHeight = 12
        Me.cboApplyBank.Size = New System.Drawing.Size(152, 20)
        Me.cboApplyBank.Visible = True
        '
        'cboApplyBranch
        '
        Me.cboApplyBranch.ItemHeight = 12
        Me.cboApplyBranch.Size = New System.Drawing.Size(184, 20)
        Me.cboApplyBranch.Visible = True
        '
        'cboApplyServiceType
        '
        Me.cboApplyServiceType.ItemHeight = 12
        Me.cboApplyServiceType.Size = New System.Drawing.Size(160, 20)
        Me.cboApplyServiceType.Visible = True
        '
        'tabReview
        '
        Me.tabReview.Controls.AddRange(New System.Windows.Forms.Control() {Me.pgOrganization})
        Me.tabReview.ItemSize = New System.Drawing.Size(84, 17)
        Me.tabReview.Size = New System.Drawing.Size(770, 444)
        Me.tabReview.Visible = True
        '
        'lblCorpRegisterAsset
        '
        Me.lblCorpRegisterAsset.Visible = True
        '
        'lblCorpBusinessEndDate
        '
        Me.lblCorpBusinessEndDate.Visible = True
        '
        'lblCorpBusinessStartDate
        '
        Me.lblCorpBusinessStartDate.Location = New System.Drawing.Point(264, 24)
        Me.lblCorpBusinessStartDate.Visible = True
        '
        'lblCorpCashArrived
        '
        Me.lblCorpCashArrived.Location = New System.Drawing.Point(256, 210)
        Me.lblCorpCashArrived.Visible = True
        '
        'lblCorpRealAsset
        '
        Me.lblCorpRealAsset.Location = New System.Drawing.Point(520, 210)
        Me.lblCorpRealAsset.Visible = True
        '
        'lblCorpEvalInstitute
        '
        Me.lblCorpEvalInstitute.Visible = True
        '
        'lblCorpCreditLevel
        '
        Me.lblCorpCreditLevel.Visible = True
        '
        'lblContactEmail
        '
        Me.lblContactEmail.Visible = True
        '
        'lblCorpRepreNation
        '
        Me.lblCorpRepreNation.Visible = True
        '
        'lblCorpRepreID
        '
        Me.lblCorpRepreID.Size = New System.Drawing.Size(110, 16)
        Me.lblCorpRepreID.Visible = True
        '
        'lblCorpRepre
        '
        Me.lblCorpRepre.Visible = True
        '
        'lblCorpInvisibleAsset
        '
        Me.lblCorpInvisibleAsset.Visible = True
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(352, 22)
        Me.dtpStartDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpStartDate.Value = New Date(2004, 2, 20, 9, 57, 1, 250)
        Me.dtpStartDate.Visible = True
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(600, 22)
        Me.dtpEndDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpEndDate.Value = New Date(2004, 2, 20, 9, 57, 1, 250)
        Me.dtpEndDate.Visible = True
        '
        'lblCorpContactor
        '
        Me.lblCorpContactor.Visible = True
        '
        'lblCorpContactNumber
        '
        Me.lblCorpContactNumber.Visible = True
        '
        'lblContactorFax
        '
        Me.lblContactorFax.Visible = True
        '
        'txtCreditLevel
        '
        Me.txtCreditLevel.Visible = True
        '
        'txtEvalInstitute
        '
        Me.txtEvalInstitute.Visible = True
        '
        'txtProjectPhase
        '
        Me.txtProjectPhase.Visible = True
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'txtRegCapital
        '
        Me.txtRegCapital.Visible = True
        '
        'lblRecommend
        '
        Me.lblRecommend.Visible = True
        '
        'lblPurpose
        '
        Me.lblPurpose.Visible = True
        '
        'txtRealCapital
        '
        Me.txtRealCapital.Location = New System.Drawing.Point(600, 208)
        Me.txtRealCapital.Size = New System.Drawing.Size(144, 21)
        Me.txtRealCapital.Visible = True
        '
        'lblLegelMobile
        '
        Me.lblLegelMobile.Visible = True
        '
        'lblLegelPhone
        '
        Me.lblLegelPhone.Visible = True
        '
        'txtRepresentative
        '
        Me.txtRepresentative.Visible = True
        '
        'txtInvisibleAssets
        '
        Me.txtInvisibleAssets.Visible = True
        '
        'lblContactMobile
        '
        Me.lblContactMobile.Location = New System.Drawing.Point(520, 280)
        Me.lblContactMobile.Visible = True
        '
        'dgProject
        '
        Me.dgProject.AccessibleName = "DataGrid"
        Me.dgProject.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgProject.Size = New System.Drawing.Size(756, 100)
        Me.dgProject.Visible = True
        '
        'txtRepreNation
        '
        Me.txtRepreNation.Location = New System.Drawing.Point(600, 254)
        Me.txtRepreNation.Size = New System.Drawing.Size(144, 21)
        Me.txtRepreNation.Visible = True
        '
        'lblAttachBancholer
        '
        Me.lblAttachBancholer.Location = New System.Drawing.Point(520, 328)
        Me.lblAttachBancholer.Visible = True
        '
        'lblAttachDoctor
        '
        Me.lblAttachDoctor.Location = New System.Drawing.Point(520, 352)
        Me.lblAttachDoctor.Visible = True
        '
        'btnReport
        '
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Bitmap)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.ImageIndex = -1
        Me.btnReport.ImageList = Nothing
        Me.btnReport.Location = New System.Drawing.Point(213, 528)
        Me.btnReport.Visible = True
        '
        'txtCashReceive
        '
        Me.txtCashReceive.Size = New System.Drawing.Size(144, 21)
        Me.txtCashReceive.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(341, 528)
        Me.btnSave.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageIndex = -1
        Me.btnCommit.ImageList = Nothing
        Me.btnCommit.Location = New System.Drawing.Point(424, 528)
        Me.btnCommit.Visible = True
        '
        'cboRecommendItems
        '
        Me.cboRecommendItems.ItemHeight = 12
        Me.cboRecommendItems.Size = New System.Drawing.Size(104, 20)
        Me.cboRecommendItems.Visible = True
        '
        'txtRepreID
        '
        Me.txtRepreID.Location = New System.Drawing.Point(600, 230)
        Me.txtRepreID.Size = New System.Drawing.Size(144, 21)
        Me.txtRepreID.Visible = True
        '
        'txtCooperateOpinion
        '
        Me.txtCooperateOpinion.Visible = True
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Visible = True
        '
        'cboMoneyType
        '
        Me.cboMoneyType.DropDownWidth = 144
        Me.cboMoneyType.ItemHeight = 12
        Me.cboMoneyType.Size = New System.Drawing.Size(144, 20)
        Me.cboMoneyType.Visible = True
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Size = New System.Drawing.Size(144, 21)
        Me.txtContactNumber.Visible = True
        '
        'lblMoneyType
        '
        Me.lblMoneyType.Visible = True
        '
        'pgProject
        '
        Me.pgProject.Size = New System.Drawing.Size(762, 419)
        '
        'grpProjectPassed
        '
        Me.grpProjectPassed.Size = New System.Drawing.Size(762, 120)
        Me.grpProjectPassed.Visible = True
        '
        'txtFax
        '
        Me.txtFax.Visible = True
        '
        'lblCorpBusinessCode
        '
        Me.lblCorpBusinessCode.Visible = True
        '
        'txtCorpID
        '
        Me.txtCorpID.Visible = True
        '
        'lblCorpPaperID
        '
        Me.lblCorpPaperID.Location = New System.Drawing.Point(264, 48)
        Me.lblCorpPaperID.Visible = True
        '
        'txtLoanID
        '
        Me.txtLoanID.Location = New System.Drawing.Point(352, 46)
        Me.txtLoanID.Size = New System.Drawing.Size(144, 21)
        Me.txtLoanID.Visible = True
        '
        'lblCorpRepreCardID
        '
        Me.lblCorpRepreCardID.Visible = True
        '
        'txtRepID
        '
        Me.txtRepID.Visible = True
        '
        'grpRequest
        '
        Me.grpRequest.Location = New System.Drawing.Point(0, 123)
        Me.grpRequest.Size = New System.Drawing.Size(762, 296)
        Me.grpRequest.Visible = True
        '
        'lblCorpCardID
        '
        Me.lblCorpCardID.Visible = True
        '
        'txtLoanCardID
        '
        Me.txtLoanCardID.Location = New System.Drawing.Point(600, 46)
        Me.txtLoanCardID.Size = New System.Drawing.Size(144, 21)
        Me.txtLoanCardID.Visible = True
        '
        'lblCorpRegisterAddress
        '
        Me.lblCorpRegisterAddress.Visible = True
        '
        'txtRecommendPerson
        '
        Me.txtRecommendPerson.Visible = True
        '
        'txtAddressDetail
        '
        Me.txtAddressDetail.Location = New System.Drawing.Point(248, 70)
        Me.txtAddressDetail.Size = New System.Drawing.Size(248, 21)
        Me.txtAddressDetail.Visible = True
        '
        'lblCorpIndustryType
        '
        Me.lblCorpIndustryType.Visible = True
        '
        'lblCorpPropriateShip
        '
        Me.lblCorpPropriateShip.Visible = True
        '
        'txtPurpose
        '
        Me.txtPurpose.Visible = True
        '
        'lblCorpTechType
        '
        Me.lblCorpTechType.Visible = True
        '
        'cboAddressRange
        '
        Me.cboAddressRange.DropDownWidth = 128
        Me.cboAddressRange.Size = New System.Drawing.Size(152, 20)
        Me.cboAddressRange.Visible = True
        '
        'clbTechType
        '
        Me.clbTechType.Visible = True
        '
        'dtpFoundDate
        '
        Me.dtpFoundDate.Location = New System.Drawing.Point(600, 70)
        Me.dtpFoundDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpFoundDate.Value = New Date(2004, 2, 20, 9, 57, 1, 0)
        '
        'dtpApplyDate
        '
        Me.dtpApplyDate.Value = New Date(2004, 2, 20, 9, 57, 0, 937)
        Me.dtpApplyDate.Visible = True
        '
        'lblAttachMember
        '
        Me.lblAttachMember.Visible = True
        '
        'lblAttachMaster
        '
        Me.lblAttachMaster.Visible = True
        '
        'lblAttachColledge
        '
        Me.lblAttachColledge.Visible = True
        '
        'nuTerm
        '
        Me.nuTerm.Visible = True
        '
        'txtApplySum
        '
        Me.txtApplySum.Visible = True
        '
        'dtpRecommend
        '
        Me.dtpRecommend.Value = New Date(2004, 2, 20, 9, 57, 0, 906)
        Me.dtpRecommend.Visible = True
        '
        'txtContactMobile
        '
        Me.txtContactMobile.Location = New System.Drawing.Point(600, 278)
        Me.txtContactMobile.Size = New System.Drawing.Size(144, 21)
        Me.txtContactMobile.Visible = True
        '
        'txtRecommendSum
        '
        Me.txtRecommendSum.Visible = True
        '
        'pgCorpInfo
        '
        Me.pgCorpInfo.Size = New System.Drawing.Size(762, 419)
        '
        'txtContactEmail
        '
        Me.txtContactEmail.Visible = True
        '
        'txtColledgeNum
        '
        Me.txtColledgeNum.Size = New System.Drawing.Size(144, 21)
        Me.txtColledgeNum.Visible = True
        '
        'txtBachelorNum
        '
        Me.txtBachelorNum.Location = New System.Drawing.Point(600, 326)
        Me.txtBachelorNum.Size = New System.Drawing.Size(144, 21)
        Me.txtBachelorNum.Visible = True
        '
        'txtLegelPhone
        '
        Me.txtLegelPhone.Visible = True
        '
        'txtMasterNum
        '
        Me.txtMasterNum.Size = New System.Drawing.Size(144, 21)
        Me.txtMasterNum.Visible = True
        '
        'txtDoctorNum
        '
        Me.txtDoctorNum.Location = New System.Drawing.Point(600, 350)
        Me.txtDoctorNum.Size = New System.Drawing.Size(144, 21)
        Me.txtDoctorNum.Visible = True
        '
        'txtEmployeeAmount
        '
        Me.txtEmployeeAmount.Visible = True
        '
        'txtLegelMobile
        '
        Me.txtLegelMobile.Size = New System.Drawing.Size(144, 21)
        Me.txtLegelMobile.Visible = True
        '
        'grpProjectHeader
        '
        Me.grpProjectHeader.Location = New System.Drawing.Point(9, 8)
        Me.grpProjectHeader.Visible = True
        '
        'lblProjectPhase
        '
        Me.lblProjectPhase.Visible = True
        '
        'chkIsFirstLoan
        '
        Me.chkIsFirstLoan.Location = New System.Drawing.Point(8, 227)
        Me.chkIsFirstLoan.Visible = True
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Visible = True
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Visible = True
        '
        'grpProjectBody
        '
        Me.grpProjectBody.Location = New System.Drawing.Point(9, 56)
        Me.grpProjectBody.Size = New System.Drawing.Size(776, 464)
        Me.grpProjectBody.Visible = True
        '
        'lblProjectRequestTerm
        '
        Me.lblProjectRequestTerm.Visible = True
        '
        'lblProjectRequestDate
        '
        Me.lblProjectRequestDate.Visible = True
        '
        'lblProjectRequestServiceType
        '
        Me.lblProjectRequestServiceType.Visible = True
        '
        'lblProjectRequestBranch
        '
        Me.lblProjectRequestBranch.Visible = True
        '
        'lblProjectCooperateOpinion
        '
        Me.lblProjectCooperateOpinion.Visible = True
        '
        'lblProjectRequestBank
        '
        Me.lblProjectRequestBank.Visible = True
        '
        'lblProjectRequestSum
        '
        Me.lblProjectRequestSum.Visible = True
        '
        'lblProjectRecommendSum
        '
        Me.lblProjectRecommendSum.Visible = True
        '
        'lblProjectRecommendDate
        '
        Me.lblProjectRecommendDate.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = 4
        Me.btnExit.ImageList = Me.ImageListBasic
        Me.btnExit.Location = New System.Drawing.Point(507, 528)
        Me.btnExit.Visible = True
        '
        'pgOrganization
        '
        Me.pgOrganization.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpOrganization})
        Me.pgOrganization.Location = New System.Drawing.Point(4, 21)
        Me.pgOrganization.Name = "pgOrganization"
        Me.pgOrganization.Size = New System.Drawing.Size(762, 419)
        Me.pgOrganization.TabIndex = 12
        Me.pgOrganization.Text = "担保机构信息"
        '
        'grpOrganization
        '
        Me.grpOrganization.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtSourceGuaranteeFee, Me.lblSourceGuaranteeFee, Me.txtSourceServiceType, Me.lblSourceServiceType, Me.txtName, Me.txtSourceLoanTerm, Me.txtSourceLoanSum, Me.lblSourceLoanTerm, Me.lblSourceLoanSum, Me.txtOpinion50001, Me.lblOpinion50001, Me.txtReguaranteeCondition, Me.lblReguaranteeCondition, Me.lblName})
        Me.grpOrganization.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpOrganization.Name = "grpOrganization"
        Me.grpOrganization.Size = New System.Drawing.Size(762, 419)
        Me.grpOrganization.TabIndex = 0
        Me.grpOrganization.TabStop = False
        '
        'txtSourceGuaranteeFee
        '
        Me.txtSourceGuaranteeFee.Location = New System.Drawing.Point(104, 69)
        Me.txtSourceGuaranteeFee.MaxLength = 10
        Me.txtSourceGuaranteeFee.Name = "txtSourceGuaranteeFee"
        Me.txtSourceGuaranteeFee.Size = New System.Drawing.Size(152, 21)
        Me.txtSourceGuaranteeFee.TabIndex = 3
        Me.txtSourceGuaranteeFee.Text = ""
        Me.txtSourceGuaranteeFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSourceGuaranteeFee
        '
        Me.lblSourceGuaranteeFee.Location = New System.Drawing.Point(8, 72)
        Me.lblSourceGuaranteeFee.Name = "lblSourceGuaranteeFee"
        Me.lblSourceGuaranteeFee.Size = New System.Drawing.Size(80, 14)
        Me.lblSourceGuaranteeFee.TabIndex = 58
        Me.lblSourceGuaranteeFee.Text = "担保费(元)"
        '
        'txtSourceServiceType
        '
        Me.txtSourceServiceType.Location = New System.Drawing.Point(360, 46)
        Me.txtSourceServiceType.MaxLength = 20
        Me.txtSourceServiceType.Name = "txtSourceServiceType"
        Me.txtSourceServiceType.Size = New System.Drawing.Size(160, 21)
        Me.txtSourceServiceType.TabIndex = 0
        Me.txtSourceServiceType.Text = ""
        '
        'lblSourceServiceType
        '
        Me.lblSourceServiceType.Location = New System.Drawing.Point(272, 49)
        Me.lblSourceServiceType.Name = "lblSourceServiceType"
        Me.lblSourceServiceType.Size = New System.Drawing.Size(79, 14)
        Me.lblSourceServiceType.TabIndex = 56
        Me.lblSourceServiceType.Text = "贷款业务品种"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(104, 22)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(416, 21)
        Me.txtName.TabIndex = 55
        Me.txtName.Text = ""
        '
        'txtSourceLoanTerm
        '
        Me.txtSourceLoanTerm.Location = New System.Drawing.Point(624, 46)
        Me.txtSourceLoanTerm.MaxLength = 4
        Me.txtSourceLoanTerm.Name = "txtSourceLoanTerm"
        Me.txtSourceLoanTerm.Size = New System.Drawing.Size(120, 21)
        Me.txtSourceLoanTerm.TabIndex = 2
        Me.txtSourceLoanTerm.Text = ""
        Me.txtSourceLoanTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSourceLoanSum
        '
        Me.txtSourceLoanSum.Location = New System.Drawing.Point(104, 46)
        Me.txtSourceLoanSum.MaxLength = 10
        Me.txtSourceLoanSum.Name = "txtSourceLoanSum"
        Me.txtSourceLoanSum.Size = New System.Drawing.Size(152, 21)
        Me.txtSourceLoanSum.TabIndex = 1
        Me.txtSourceLoanSum.Text = ""
        Me.txtSourceLoanSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSourceLoanTerm
        '
        Me.lblSourceLoanTerm.Location = New System.Drawing.Point(536, 49)
        Me.lblSourceLoanTerm.Name = "lblSourceLoanTerm"
        Me.lblSourceLoanTerm.Size = New System.Drawing.Size(80, 14)
        Me.lblSourceLoanTerm.TabIndex = 50
        Me.lblSourceLoanTerm.Text = "贷款期限(月)"
        '
        'lblSourceLoanSum
        '
        Me.lblSourceLoanSum.Location = New System.Drawing.Point(8, 48)
        Me.lblSourceLoanSum.Name = "lblSourceLoanSum"
        Me.lblSourceLoanSum.Size = New System.Drawing.Size(88, 16)
        Me.lblSourceLoanSum.TabIndex = 49
        Me.lblSourceLoanSum.Text = "贷款金额(万)"
        '
        'txtOpinion50001
        '
        Me.txtOpinion50001.Location = New System.Drawing.Point(104, 232)
        Me.txtOpinion50001.MaxLength = 1000
        Me.txtOpinion50001.Multiline = True
        Me.txtOpinion50001.Name = "txtOpinion50001"
        Me.txtOpinion50001.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOpinion50001.Size = New System.Drawing.Size(640, 136)
        Me.txtOpinion50001.TabIndex = 5
        Me.txtOpinion50001.Text = ""
        '
        'lblOpinion50001
        '
        Me.lblOpinion50001.Location = New System.Drawing.Point(16, 240)
        Me.lblOpinion50001.Name = "lblOpinion50001"
        Me.lblOpinion50001.Size = New System.Drawing.Size(64, 48)
        Me.lblOpinion50001.TabIndex = 47
        Me.lblOpinion50001.Text = "担保机构评审意见"
        '
        'txtReguaranteeCondition
        '
        Me.txtReguaranteeCondition.Location = New System.Drawing.Point(104, 96)
        Me.txtReguaranteeCondition.MaxLength = 1000
        Me.txtReguaranteeCondition.Multiline = True
        Me.txtReguaranteeCondition.Name = "txtReguaranteeCondition"
        Me.txtReguaranteeCondition.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtReguaranteeCondition.Size = New System.Drawing.Size(640, 128)
        Me.txtReguaranteeCondition.TabIndex = 4
        Me.txtReguaranteeCondition.Text = ""
        '
        'lblReguaranteeCondition
        '
        Me.lblReguaranteeCondition.Location = New System.Drawing.Point(8, 104)
        Me.lblReguaranteeCondition.Name = "lblReguaranteeCondition"
        Me.lblReguaranteeCondition.Size = New System.Drawing.Size(80, 16)
        Me.lblReguaranteeCondition.TabIndex = 12
        Me.lblReguaranteeCondition.Text = "再担保条件"
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(8, 24)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(64, 16)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "机构名称"
        '
        'FReview_zdb
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(794, 555)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnSave, Me.btnCommit, Me.grpProjectHeader, Me.grpProjectBody, Me.btnExit, Me.btnReport})
        Me.MinimizeBox = False
        Me.Name = "FReview_zdb"
        Me.tabReview.ResumeLayout(False)
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgProject.ResumeLayout(False)
        Me.grpProjectPassed.ResumeLayout(False)
        Me.grpRequest.ResumeLayout(False)
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgCorpInfo.ResumeLayout(False)
        Me.grpProjectHeader.ResumeLayout(False)
        Me.grpProjectBody.ResumeLayout(False)
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgOrganization.ResumeLayout(False)
        Me.grpOrganization.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsProjectOrganization As DataSet

    Private Sub FReview_zdb_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.InitCorpCodeAndPhase()
            Me.InitComboBox()
            Me.InitDataSet()
            Me.GetData()
            Me.GetReguaranteeData()
            Me.bFormLoad = True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '获取项目机构信息以及机构评审意见
    Private Sub GetReguaranteeData()
        Dim dsTemp As DataSet
        Me.dsProjectOrganization = gWs.GetProjectOrganization("{project_code = '" & Me.getProjectCode() & "'}")
        Dim OrganNo As String
        If Not dsProjectOrganization.Tables(0).Rows.Count = 0 Then
            With dsProjectOrganization.Tables(0).Rows(0)
                OrganNo = IIf(IsDBNull(.Item("OrganNo")), "", .Item("OrganNo"))
            End With
        End If
        dsTemp = gWs.GetTOrganizationInfo("{OrganNo = '" & OrganNo & "'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            Me.txtName.Text = IIf(IsDBNull(dsTemp.Tables(0).Rows(0)("Name")), "", dsTemp.Tables(0).Rows(0)("Name"))  '取得机构名称
        End If
        Dim bind As Binding
        bind = New Binding("Text", dsProjectOrganization, "TProjectOrganization.SourceLoanSum")                           '贷款额度
        AddHandler bind.Format, AddressOf DecimalToCurrency
        AddHandler bind.Parse, AddressOf CurrencyToDecimal
        Me.txtSourceLoanSum.DataBindings.Add(bind)
        Me.txtSourceLoanTerm.DataBindings.Add("Text", dsProjectOrganization, "TProjectOrganization.SourceLoanTerm") '贷款期限
        bind = New Binding("Text", dsProjectOrganization, "TProjectOrganization.SourceGuaranteeFee")                           '担保费
        AddHandler bind.Format, AddressOf DecimalToCurrency
        AddHandler bind.Parse, AddressOf CurrencyToDecimal
        Me.txtSourceGuaranteeFee.DataBindings.Add(bind)

        Me.txtSourceServiceType.DataBindings.Add("Text", dsProjectOrganization, "TProjectOrganization.SourceServiceType")  '贷款业务品种
        Me.txtReguaranteeCondition.DataBindings.Add("Text", dsProjectOrganization, "TProjectOrganization.ReguaranteeCondition") '再担保条件

        AddHandler BindingContext(Me.dsProjectOrganization, "TProjectOrganization").CurrentChanged, AddressOf BindDataChanged

        dsTemp = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "' and item_type='50' and item_code='001'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            Me.txtOpinion50001.Text = IIf(IsDBNull(dsTemp.Tables(0).Rows(0)("Content")), "", dsTemp.Tables(0).Rows(0)("Content"))  '取得机构评审意见
        End If

        AddHandler txtOpinion50001.TextChanged, AddressOf BindDataChanged
    End Sub

    '保存项目机构信息
    Private Function SaveReguarantee() As Boolean
        Try
            BindingContext(Me.dsProjectOrganization, "TProjectOrganization").EndCurrentEdit()
            If Me.dsProjectOrganization.HasChanges Then
                Dim strResult As String = gWs.UpdateProjectOrganization(Me.dsProjectOrganization)
                If strResult <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "保存项目机构信息失败", strResult, "项目评审")
                    Return False
                Else
                    Me.dsProjectOrganization.AcceptChanges()
                    Return True
                End If
            Else
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    '保存机构评审意见
    Private Function SaveOpinion() As Boolean
        Dim tempDS As DataSet
        Try
            tempDS = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.getProjectCode() & "' AND item_type='50' AND item_code='001'}") '项目调研结论
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    .Item("content") = Me.txtOpinion50001.Text
                End With
            Else
                Dim dr As DataRow = tempDS.Tables(0).NewRow()
                With dr
                    .Item("project_code") = Me.getProjectCode()
                    .Item("content") = Me.txtOpinion50001.Text
                    .Item("item_type") = "50"
                    .Item("item_code") = "001"
                    .Item("create_person") = UserName
                    .Item("create_date") = gWs.GetSysTime()
                End With
                tempDS.Tables(0).Rows.Add(dr)
            End If
            Dim strResult As String = gWs.UpdateProjectOpinion(tempDS)
            If strResult <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存评审审核意见失败", strResult, "项目评审")
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
            If Not Me.SaveReguarantee() Then  '保存项目机构信息
                Return False
            End If
            If Not Me.SaveOpinion() Then      '保存机构评审意见
                Return False
            End If
            Me.bIsChanged = False       '保存成功
            Return True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

   
End Class
