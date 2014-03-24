'初审审核
Public Class frmTrialFirstOpinionFinal
    Inherits frmCoMBase

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        MyBase._Phase = "初审"

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
    Friend WithEvents Label80 As System.Windows.Forms.Label
    Friend WithEvents cboConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents TrialFinalConclusionGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox23 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents txtFee As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents pgConclusion As System.Windows.Forms.TabPage
    Friend WithEvents cboFeeTrial As System.Windows.Forms.ComboBox
    Friend WithEvents lblFee As System.Windows.Forms.Label
    Friend WithEvents lblFeeTrial As System.Windows.Forms.Label
    Friend WithEvents txtFirstTrial As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtAuditOpinion As System.Windows.Forms.TextBox
    Friend Shadows WithEvents ImageList1 As System.Windows.Forms.ImageList
    Public WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTrialFirstOpinionFinal))
        Me.pgConclusion = New System.Windows.Forms.TabPage()
        Me.cboFeeTrial = New System.Windows.Forms.ComboBox()
        Me.cboConclusion = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblFeeTrial = New System.Windows.Forms.Label()
        Me.txtFee = New System.Windows.Forms.TextBox()
        Me.lblFee = New System.Windows.Forms.Label()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.txtFirstTrial = New System.Windows.Forms.TextBox()
        Me.TrialFinalConclusionGroupBox = New System.Windows.Forms.GroupBox()
        Me.txtAuditOpinion = New System.Windows.Forms.TextBox()
        Me.Label80 = New System.Windows.Forms.Label()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCoMBase.SuspendLayout()
        Me.pgProject.SuspendLayout()
        Me.grpProjectPassed.SuspendLayout()
        Me.grpRequest.SuspendLayout()
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgCorpInfo.SuspendLayout()
        Me.groupbox.SuspendLayout()
        Me.grpProjectHeader.SuspendLayout()
        Me.grpProjectBody.SuspendLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgConclusion.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        Me.TrialFinalConclusionGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblAttachDoctor
        '
        Me.lblAttachDoctor.Visible = True
        '
        'Label11
        '
        Me.Label11.Visible = True
        '
        'lblAttachBancholer
        '
        Me.lblAttachBancholer.Visible = True
        '
        'Label10
        '
        Me.Label10.Visible = True
        '
        'dgProject
        '
        Me.dgProject.AccessibleName = "DataGrid"
        Me.dgProject.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgProject.Size = New System.Drawing.Size(756, 103)
        Me.dgProject.Visible = True
        '
        'tabCoMBase
        '
        Me.tabCoMBase.Controls.AddRange(New System.Windows.Forms.Control() {Me.pgConclusion})
        Me.tabCoMBase.ItemSize = New System.Drawing.Size(60, 17)
        Me.tabCoMBase.Size = New System.Drawing.Size(770, 412)
        Me.tabCoMBase.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Visible = True
        '
        'Label16
        '
        Me.Label16.Visible = True
        '
        'cboAddressRange
        '
        Me.cboAddressRange.Enabled = False
        Me.cboAddressRange.Size = New System.Drawing.Size(152, 20)
        Me.cboAddressRange.Visible = True
        '
        'cboIndustryType
        '
        Me.cboIndustryType.DropDownWidth = 224
        Me.cboIndustryType.Enabled = False
        Me.cboIndustryType.Size = New System.Drawing.Size(248, 20)
        Me.cboIndustryType.Visible = True
        '
        'cboProprietorShip
        '
        Me.cboProprietorShip.DropDownWidth = 160
        Me.cboProprietorShip.Enabled = False
        Me.cboProprietorShip.Size = New System.Drawing.Size(256, 20)
        Me.cboProprietorShip.Visible = True
        '
        'cboRecommendType
        '
        Me.cboRecommendType.Enabled = False
        Me.cboRecommendType.Size = New System.Drawing.Size(80, 20)
        Me.cboRecommendType.Visible = True
        '
        'Label7
        '
        Me.Label7.Visible = True
        '
        'cboApplyBank
        '
        Me.cboApplyBank.Enabled = False
        Me.cboApplyBank.ItemHeight = 12
        Me.cboApplyBank.Size = New System.Drawing.Size(152, 20)
        Me.cboApplyBank.Visible = True
        '
        'cboApplyBranch
        '
        Me.cboApplyBranch.Enabled = False
        Me.cboApplyBranch.ItemHeight = 12
        Me.cboApplyBranch.Size = New System.Drawing.Size(184, 20)
        Me.cboApplyBranch.Visible = True
        '
        'txtPhase
        '
        Me.txtPhase.Location = New System.Drawing.Point(688, 16)
        Me.txtPhase.Visible = True
        '
        'Label14
        '
        Me.Label14.Visible = True
        '
        'cboRecommendItems
        '
        Me.cboRecommendItems.Enabled = False
        Me.cboRecommendItems.ItemHeight = 12
        Me.cboRecommendItems.Size = New System.Drawing.Size(104, 20)
        Me.cboRecommendItems.Visible = True
        '
        'cboApplyServiceType
        '
        Me.cboApplyServiceType.DropDownWidth = 128
        Me.cboApplyServiceType.Enabled = False
        Me.cboApplyServiceType.ItemHeight = 12
        Me.cboApplyServiceType.Visible = True
        '
        'txtCooperateOpinion
        '
        Me.txtCooperateOpinion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCooperateOpinion.Enabled = True
        Me.txtCooperateOpinion.ReadOnly = True
        Me.txtCooperateOpinion.Visible = True
        '
        'cboMoneyType
        '
        Me.cboMoneyType.DropDownWidth = 144
        Me.cboMoneyType.Enabled = False
        Me.cboMoneyType.ItemHeight = 12
        Me.cboMoneyType.Size = New System.Drawing.Size(144, 20)
        Me.cboMoneyType.Visible = True
        '
        'lblMoneyType
        '
        Me.lblMoneyType.Location = New System.Drawing.Point(264, 194)
        Me.lblMoneyType.Visible = True
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
        Me.lblCorpBusinessStartDate.Visible = True
        '
        'lblCorpCashArrived
        '
        Me.lblCorpCashArrived.Visible = True
        '
        'lblCorpRealAsset
        '
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
        'lblCorpRepreNation
        '
        Me.lblCorpRepreNation.Visible = True
        '
        'lblCorpRepreID
        '
        Me.lblCorpRepreID.Location = New System.Drawing.Point(504, 240)
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
        Me.dtpStartDate.Enabled = False
        Me.dtpStartDate.Location = New System.Drawing.Point(352, 22)
        Me.dtpStartDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpStartDate.Value = New Date(2003, 7, 3, 0, 0, 0, 0)
        Me.dtpStartDate.Visible = True
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Enabled = False
        Me.dtpEndDate.Value = New Date(2003, 7, 3, 0, 0, 0, 0)
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
        Me.txtCreditLevel.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCreditLevel.ReadOnly = True
        Me.txtCreditLevel.Visible = True
        '
        'txtEvalInstitute
        '
        Me.txtEvalInstitute.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEvalInstitute.ReadOnly = True
        Me.txtEvalInstitute.Visible = True
        '
        'txtRegCapital
        '
        Me.txtRegCapital.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRegCapital.ReadOnly = True
        Me.txtRegCapital.Visible = True
        '
        'txtRealCapital
        '
        Me.txtRealCapital.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRealCapital.ReadOnly = True
        Me.txtRealCapital.Visible = True
        '
        'txtRepresentative
        '
        Me.txtRepresentative.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRepresentative.ReadOnly = True
        Me.txtRepresentative.Visible = True
        '
        'pgProject
        '
        Me.pgProject.Size = New System.Drawing.Size(762, 387)
        '
        'grpProjectPassed
        '
        Me.grpProjectPassed.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)
        Me.grpProjectPassed.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpProjectPassed.Location = New System.Drawing.Point(0, 0)
        Me.grpProjectPassed.Size = New System.Drawing.Size(762, 123)
        Me.grpProjectPassed.Visible = True
        '
        'grpRequest
        '
        Me.grpRequest.Size = New System.Drawing.Size(762, 264)
        Me.grpRequest.Visible = True
        '
        'txtInvisibleAssets
        '
        Me.txtInvisibleAssets.BackColor = System.Drawing.Color.Gainsboro
        Me.txtInvisibleAssets.ReadOnly = True
        Me.txtInvisibleAssets.Visible = True
        '
        'txtRecommendPerson
        '
        Me.txtRecommendPerson.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRecommendPerson.ReadOnly = True
        Me.txtRecommendPerson.Visible = True
        '
        'txtPurpose
        '
        Me.txtPurpose.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPurpose.ReadOnly = True
        Me.txtPurpose.Visible = True
        '
        'dtpApplyDate
        '
        Me.dtpApplyDate.Enabled = False
        Me.dtpApplyDate.Value = New Date(2003, 4, 28, 16, 26, 34, 156)
        Me.dtpApplyDate.Visible = True
        '
        'txtRepreNation
        '
        Me.txtRepreNation.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRepreNation.ReadOnly = True
        Me.txtRepreNation.Visible = True
        '
        'nuTerm
        '
        Me.nuTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.nuTerm.ReadOnly = True
        Me.nuTerm.Visible = True
        '
        'txtApplySum
        '
        Me.txtApplySum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplySum.ReadOnly = True
        Me.txtApplySum.Visible = True
        '
        'dtpRecommend
        '
        Me.dtpRecommend.Value = New Date(2003, 4, 28, 16, 26, 34, 93)
        Me.dtpRecommend.Visible = True
        '
        'txtCashReceive
        '
        Me.txtCashReceive.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCashReceive.ReadOnly = True
        Me.txtCashReceive.Size = New System.Drawing.Size(144, 21)
        Me.txtCashReceive.Visible = True
        '
        'txtRecommendSum
        '
        Me.txtRecommendSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRecommendSum.Enabled = True
        Me.txtRecommendSum.ReadOnly = True
        Me.txtRecommendSum.Visible = True
        '
        'pgCorpInfo
        '
        Me.pgCorpInfo.Size = New System.Drawing.Size(762, 387)
        '
        'groupbox
        '
        Me.groupbox.Size = New System.Drawing.Size(762, 387)
        Me.groupbox.Visible = True
        '
        'txtRepreID
        '
        Me.txtRepreID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRepreID.ReadOnly = True
        Me.txtRepreID.Visible = True
        '
        'txtColledgeNum
        '
        Me.txtColledgeNum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtColledgeNum.ReadOnly = True
        Me.txtColledgeNum.Size = New System.Drawing.Size(144, 21)
        Me.txtColledgeNum.Visible = True
        '
        'txtBachelorNum
        '
        Me.txtBachelorNum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBachelorNum.ReadOnly = True
        Me.txtBachelorNum.Visible = True
        '
        'txtContactPerson
        '
        Me.txtContactPerson.BackColor = System.Drawing.Color.Gainsboro
        Me.txtContactPerson.ReadOnly = True
        Me.txtContactPerson.Visible = True
        '
        'txtMasterNum
        '
        Me.txtMasterNum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMasterNum.ReadOnly = True
        Me.txtMasterNum.Size = New System.Drawing.Size(144, 21)
        Me.txtMasterNum.Visible = True
        '
        'txtContactNumber
        '
        Me.txtContactNumber.BackColor = System.Drawing.Color.Gainsboro
        Me.txtContactNumber.ReadOnly = True
        Me.txtContactNumber.Size = New System.Drawing.Size(144, 21)
        Me.txtContactNumber.Visible = True
        '
        'txtDoctorNum
        '
        Me.txtDoctorNum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDoctorNum.ReadOnly = True
        Me.txtDoctorNum.Visible = True
        '
        'txtEmployeeAmount
        '
        Me.txtEmployeeAmount.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEmployeeAmount.ReadOnly = True
        Me.txtEmployeeAmount.Visible = True
        '
        'grpProjectHeader
        '
        Me.grpProjectHeader.Size = New System.Drawing.Size(776, 48)
        Me.grpProjectHeader.Visible = True
        '
        'txtFax
        '
        Me.txtFax.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFax.ReadOnly = True
        Me.txtFax.Visible = True
        '
        'lblProjectPhase
        '
        Me.lblProjectPhase.Location = New System.Drawing.Point(624, 16)
        Me.lblProjectPhase.Size = New System.Drawing.Size(57, 23)
        Me.lblProjectPhase.Visible = True
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Visible = True
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Visible = True
        '
        'lblCorpBusinessCode
        '
        Me.lblCorpBusinessCode.Visible = True
        '
        'grpProjectBody
        '
        Me.grpProjectBody.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)
        Me.grpProjectBody.Size = New System.Drawing.Size(776, 432)
        Me.grpProjectBody.Visible = True
        '
        'lblProjectRequestDate
        '
        Me.lblProjectRequestDate.Visible = True
        '
        'lblProjectRequestServiceType
        '
        Me.lblProjectRequestServiceType.Visible = True
        '
        'txtCorpID
        '
        Me.txtCorpID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorpID.ReadOnly = True
        Me.txtCorpID.Visible = True
        '
        'lblProjectRequestBranch
        '
        Me.lblProjectRequestBranch.Visible = True
        '
        'lblProjectRequestBank
        '
        Me.lblProjectRequestBank.Visible = True
        '
        'lblCorpPaperID
        '
        Me.lblCorpPaperID.Visible = True
        '
        'lblProjectRequestSum
        '
        Me.lblProjectRequestSum.Visible = True
        '
        'txtLoanID
        '
        Me.txtLoanID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanID.Location = New System.Drawing.Point(352, 46)
        Me.txtLoanID.ReadOnly = True
        Me.txtLoanID.Size = New System.Drawing.Size(144, 21)
        Me.txtLoanID.Visible = True
        '
        'lblProjectRecommendDate
        '
        Me.lblProjectRecommendDate.Visible = True
        '
        'lblProjectRecommendSum
        '
        Me.lblProjectRecommendSum.Visible = True
        '
        'lblProjectCooperateOpinion
        '
        Me.lblProjectCooperateOpinion.Visible = True
        '
        'lblCorpRepreCardID
        '
        Me.lblCorpRepreCardID.Visible = True
        '
        'lblProjectRequestTerm
        '
        Me.lblProjectRequestTerm.Visible = True
        '
        'chkIsFirstLoan
        '
        Me.chkIsFirstLoan.Enabled = False
        Me.chkIsFirstLoan.Location = New System.Drawing.Point(8, 240)
        Me.chkIsFirstLoan.Visible = True
        '
        'txtLegelMobile
        '
        Me.txtLegelMobile.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLegelMobile.ReadOnly = True
        Me.txtLegelMobile.Size = New System.Drawing.Size(144, 21)
        Me.txtLegelMobile.Visible = True
        '
        'txtRepID
        '
        Me.txtRepID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRepID.ReadOnly = True
        Me.txtRepID.Visible = True
        '
        'txtLegelPhone
        '
        Me.txtLegelPhone.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLegelPhone.ReadOnly = True
        Me.txtLegelPhone.Visible = True
        '
        'txtContactEmail
        '
        Me.txtContactEmail.BackColor = System.Drawing.Color.Gainsboro
        Me.txtContactEmail.ReadOnly = True
        Me.txtContactEmail.Visible = True
        '
        'txtContactMobile
        '
        Me.txtContactMobile.BackColor = System.Drawing.Color.Gainsboro
        Me.txtContactMobile.ReadOnly = True
        Me.txtContactMobile.Visible = True
        '
        'lblCorpCardID
        '
        Me.lblCorpCardID.Visible = True
        '
        'txtLoanCardID
        '
        Me.txtLoanCardID.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanCardID.ReadOnly = True
        Me.txtLoanCardID.Visible = True
        '
        'lblCorpRegisterAddress
        '
        Me.lblCorpRegisterAddress.Visible = True
        '
        'lblAttachColledge
        '
        Me.lblAttachColledge.Visible = True
        '
        'txtAddressDetail
        '
        Me.txtAddressDetail.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAddressDetail.ReadOnly = True
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
        'lblAttachMaster
        '
        Me.lblAttachMaster.Visible = True
        '
        'lblAttachMember
        '
        Me.lblAttachMember.Visible = True
        '
        'lblCorpTechType
        '
        Me.lblCorpTechType.Visible = True
        '
        'dtpFoundDate
        '
        Me.dtpFoundDate.Value = New Date(2003, 7, 3, 0, 0, 0, 0)
        '
        'clbTechType
        '
        Me.clbTechType.BackColor = System.Drawing.SystemColors.Control
        Me.clbTechType.Enabled = False
        Me.clbTechType.Visible = True
        '
        'Label13
        '
        Me.Label13.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(497, 492)
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 204
        Me.btnExit.Visible = True
        '
        'pgConclusion
        '
        Me.pgConclusion.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboFeeTrial, Me.cboConclusion, Me.Label23, Me.Label22, Me.Label21, Me.Label20, Me.Label19, Me.Label18, Me.lblFeeTrial, Me.txtFee, Me.lblFee, Me.GroupBox23, Me.TrialFinalConclusionGroupBox, Me.Label80})
        Me.pgConclusion.Location = New System.Drawing.Point(4, 21)
        Me.pgConclusion.Name = "pgConclusion"
        Me.pgConclusion.Size = New System.Drawing.Size(762, 387)
        Me.pgConclusion.TabIndex = 13
        Me.pgConclusion.Text = "意见及结论"
        '
        'cboFeeTrial
        '
        Me.cboFeeTrial.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cboFeeTrial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFeeTrial.Location = New System.Drawing.Point(324, 360)
        Me.cboFeeTrial.Name = "cboFeeTrial"
        Me.cboFeeTrial.Size = New System.Drawing.Size(120, 20)
        Me.cboFeeTrial.TabIndex = 4
        '
        'cboConclusion
        '
        Me.cboConclusion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cboConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConclusion.Location = New System.Drawing.Point(108, 360)
        Me.cboConclusion.Name = "cboConclusion"
        Me.cboConclusion.Size = New System.Drawing.Size(126, 20)
        Me.cboConclusion.TabIndex = 3
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label23.Location = New System.Drawing.Point(28, 362)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(86, 16)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "初审审核结论"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(-620, -480)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(54, 14)
        Me.Label22.TabIndex = 10
        Me.Label22.Text = "评审结论"
        Me.Label22.Visible = False
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(-404, -480)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(54, 14)
        Me.Label21.TabIndex = 9
        Me.Label21.Text = "收费方式"
        Me.Label21.Visible = False
        '
        'Label20
        '
        Me.Label20.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(-1316, -1320)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 14)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "收费方式"
        Me.Label20.Visible = False
        '
        'Label19
        '
        Me.Label19.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(-1348, -1320)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(0, 14)
        Me.Label19.TabIndex = 7
        Me.Label19.Visible = False
        '
        'Label18
        '
        Me.Label18.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(-1092, -1320)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 14)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "审核意见"
        Me.Label18.Visible = False
        '
        'lblFeeTrial
        '
        Me.lblFeeTrial.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblFeeTrial.Location = New System.Drawing.Point(252, 362)
        Me.lblFeeTrial.Name = "lblFeeTrial"
        Me.lblFeeTrial.Size = New System.Drawing.Size(86, 16)
        Me.lblFeeTrial.TabIndex = 0
        Me.lblFeeTrial.Text = "评审费审批"
        Me.lblFeeTrial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFeeTrial.Visible = False
        '
        'txtFee
        '
        Me.txtFee.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtFee.Location = New System.Drawing.Point(596, 360)
        Me.txtFee.MaxLength = 8
        Me.txtFee.Name = "txtFee"
        Me.txtFee.Size = New System.Drawing.Size(104, 21)
        Me.txtFee.TabIndex = 5
        Me.txtFee.Text = ""
        Me.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFee.Visible = False
        '
        'lblFee
        '
        Me.lblFee.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblFee.Location = New System.Drawing.Point(476, 362)
        Me.lblFee.Name = "lblFee"
        Me.lblFee.Size = New System.Drawing.Size(120, 16)
        Me.lblFee.TabIndex = 0
        Me.lblFee.Text = "评审费收取金额(元)"
        Me.lblFee.Visible = False
        '
        'GroupBox23
        '
        Me.GroupBox23.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox23.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtFirstTrial})
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(762, 176)
        Me.GroupBox23.TabIndex = 0
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "初审意见"
        '
        'txtFirstTrial
        '
        Me.txtFirstTrial.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFirstTrial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtFirstTrial.Location = New System.Drawing.Point(3, 17)
        Me.txtFirstTrial.MaxLength = 250
        Me.txtFirstTrial.Multiline = True
        Me.txtFirstTrial.Name = "txtFirstTrial"
        Me.txtFirstTrial.ReadOnly = True
        Me.txtFirstTrial.Size = New System.Drawing.Size(756, 156)
        Me.txtFirstTrial.TabIndex = 0
        Me.txtFirstTrial.Text = ""
        '
        'TrialFinalConclusionGroupBox
        '
        Me.TrialFinalConclusionGroupBox.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.TrialFinalConclusionGroupBox.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtAuditOpinion})
        Me.TrialFinalConclusionGroupBox.Location = New System.Drawing.Point(0, 176)
        Me.TrialFinalConclusionGroupBox.Name = "TrialFinalConclusionGroupBox"
        Me.TrialFinalConclusionGroupBox.Size = New System.Drawing.Size(760, 176)
        Me.TrialFinalConclusionGroupBox.TabIndex = 0
        Me.TrialFinalConclusionGroupBox.TabStop = False
        Me.TrialFinalConclusionGroupBox.Text = "审核意见"
        '
        'txtAuditOpinion
        '
        Me.txtAuditOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAuditOpinion.Location = New System.Drawing.Point(3, 17)
        Me.txtAuditOpinion.MaxLength = 250
        Me.txtAuditOpinion.Multiline = True
        Me.txtAuditOpinion.Name = "txtAuditOpinion"
        Me.txtAuditOpinion.Size = New System.Drawing.Size(754, 156)
        Me.txtAuditOpinion.TabIndex = 1
        Me.txtAuditOpinion.Text = ""
        '
        'Label80
        '
        Me.Label80.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label80.AutoSize = True
        Me.Label80.Location = New System.Drawing.Point(-1676, -1732)
        Me.Label80.Name = "Label80"
        Me.Label80.Size = New System.Drawing.Size(54, 14)
        Me.Label80.TabIndex = 0
        Me.Label80.Text = "审核结论"
        Me.Label80.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(418, 492)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.TabIndex = 203
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnReport
        '
        Me.btnReport.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Bitmap)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.ImageIndex = 18
        Me.btnReport.ImageList = Me.ImageListBasic
        Me.btnReport.Location = New System.Drawing.Point(215, 492)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(120, 23)
        Me.btnReport.TabIndex = 201
        Me.btnReport.Text = "查看初审报告(&V)"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(339, 492)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.TabIndex = 202
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 28
        Me.Button1.ImageList = Me.ImageListBasic
        Me.Button1.Location = New System.Drawing.Point(440, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "新 增(&N)"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmTrialFirstOpinionFinal
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(786, 519)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpProjectHeader, Me.grpProjectBody, Me.btnExit, Me.btnSave, Me.btnReport, Me.btnCommit})
        Me.MinimizeBox = False
        Me.Name = "frmTrialFirstOpinionFinal"
        Me.Text = "初审审核"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCoMBase.ResumeLayout(False)
        Me.pgProject.ResumeLayout(False)
        Me.grpProjectPassed.ResumeLayout(False)
        Me.grpRequest.ResumeLayout(False)
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgCorpInfo.ResumeLayout(False)
        Me.groupbox.ResumeLayout(False)
        Me.grpProjectHeader.ResumeLayout(False)
        Me.grpProjectBody.ResumeLayout(False)
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgConclusion.ResumeLayout(False)
        Me.GroupBox23.ResumeLayout(False)
        Me.TrialFinalConclusionGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dAuditFee As Double '评审会收取标准

    Private Sub frmTrialFirstOpinionFinal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    '获取与初审审核相关的数据
    Private Sub Init()
        Me.cboConclusion.Items.AddRange(New Object() {"受理", "不受理"})
        Me.cboConclusion.SelectedIndex = 0
        Me.cboFeeTrial.Items.AddRange(New Object() {"预收", "不预收", "免收"})
        Me.cboFeeTrial.SelectedIndex = 0

        dsTemp = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me._ProCode & "' AND item_type='51'}")
        '初审意见
        Dim rows() As DataRow = dsTemp.Tables("TProjectOpinion").Select("item_type='51' AND item_code='002'")
        If rows.Length > 0 Then
            Me.txtFirstTrial.Text = IIf(IsDBNull(rows(0).Item("content")), "", rows(0).Item("content"))
        End If

        '初审审核意见
        rows = dsTemp.Tables("TProjectOpinion").Select("item_type='51' AND item_code='003'")
        If rows.Length > 0 Then
            Me.txtAuditOpinion.Text = IIf(IsDBNull(rows(0).Item("content")), "", rows(0).Item("content"))
            If Not rows(0).Item("conclusion") Is System.DBNull.Value Then
                Me.cboConclusion.SelectedItem = IIf(IsDBNull(rows(0).Item("conclusion")), "", rows(0).Item("conclusion"))
            End If
        End If

        Dim dsTemp1 As DataSet = gWs.GetServiceType("{service_type='" + Me.cboApplyServiceType.Text + "'}")
        If Not dsTemp1.Tables(0).Rows.Count = 0 Then
            With dsTemp1.Tables(0).Rows(0) '根据申请类型获得最低评审费标准
                Me.dAuditFee = IIf(IsDBNull(.Item("lowest_review_sum")), 0, .Item("lowest_review_sum"))
            End With
        End If

        If Me.cboConclusion.Text = "受理" Then
            '加载评审收费意见
            Me.lblFeeTrial.Visible = True
            Me.cboFeeTrial.Visible = True
            rows = dsTemp.Tables("TProjectOpinion").Select("item_type='51' AND item_code='004'")
            If rows.Length > 0 Then
                If Not rows(0).Item("conclusion") Is System.DBNull.Value Then
                    Me.cboFeeTrial.SelectedItem = rows(0).Item("conclusion")
                End If
            End If

            '收费意见
            If Me.cboFeeTrial.Text = "预收" Then
                Me.lblFee.Visible = True
                Me.txtFee.Visible = True

                dsTemp = gWs.GetProjectAccountDetailInfo("{project_code='" & _ProCode & "' AND item_type='31' AND item_code='001'}")
                If Not dsTemp.Tables(0).Rows.Count = 0 Then
                    With dstemp.Tables(0).Rows(0) '获取评审费
                        Me.txtFee.Text = Numeric2Currency(IIf(IsDBNull(.Item("payout")), 0, .Item("payout")))
                    End With
                Else
                    Me.txtFee.Text = Numeric2Currency(Me.dAuditFee)
                End If
            End If

        End If

        Me.tabCoMBase.SelectedTab = Me.pgConclusion

        AddHandler txtAuditOpinion.TextChanged, AddressOf BindDataChanged
        AddHandler txtFee.Enter, AddressOf Money.Money_Enter
        AddHandler txtFee.KeyPress, AddressOf Money_KeyPress
        AddHandler txtFee.Leave, AddressOf Money_Leave
        AddHandler txtFee.TextChanged, AddressOf BindDataChanged
    End Sub
    '保存
    Private Function AuditSave() As Boolean
        If Me.cboConclusion.Text = "受理" And Me.cboFeeTrial.Text = "预收" And Me.txtFee.Text = "" Then
            'MsgBox("请输入评审费！", MsgBoxStyle.Exclamation, "初审审核")
            SWDialogBox.MessageBox.Show("$1001", "评审费")
            Return False
        End If

        Dim dsTemp As DataSet = gWs.GetProjectOpinionByProjectNo(Me._ProCode)
        Dim dr As DataRow
        Dim rows() As DataRow = dsTemp.Tables("TProjectOpinion").Select("item_type='51' AND item_code='003'")

        If rows.Length > 0 Then
            rows(0).Item("content") = Me.txtAuditOpinion.Text
            rows(0).Item("conclusion") = Me.cboConclusion.Text
        Else
            dr = dsTemp.Tables("TProjectOpinion").NewRow
            With dr
                .Item("project_code") = _ProCode
                .Item("content") = Me.txtAuditOpinion.Text
                .Item("conclusion") = Me.cboConclusion.Text
                .Item("item_type") = "51"
                .Item("item_code") = "003"   '评审意见
                .Item("create_person") = UserName
                .Item("create_date") = SysDate
            End With
            dsTemp.Tables("TProjectOpinion").Rows.Add(dr)
        End If

        If Me.cboConclusion.Text = "受理" Then
            rows = dsTemp.Tables("TProjectOpinion").Select("item_type='51' AND item_code='004'")
            If rows.Length > 0 Then
                rows(0).Item("content") = Me.txtAuditOpinion.Text
                rows(0).Item("conclusion") = Me.cboFeeTrial.Text
            Else
                dr = dsTemp.Tables("TProjectOpinion").NewRow
                With dr
                    .Item("project_code") = _ProCode
                    .Item("content") = Me.txtAuditOpinion.Text
                    .Item("conclusion") = Me.cboFeeTrial.Text
                    .Item("item_type") = "51"
                    .Item("item_code") = "004"  '评审费审批意见
                    .Item("create_person") = UserName
                    .Item("create_date") = SysDate
                End With
                dsTemp.Tables("TProjectOpinion").Rows.Add(dr)
            End If

            Dim result As String = gWs.UpdateProjectOpinion(dsTemp)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存初审审核意见失败,原因是", result, "初审审核")
                Return False
            End If

            If Me.cboFeeTrial.Text = "预收" Then
                dsTemp = gWs.GetProjectAccountDetailInfo("{project_code='" & _ProCode & "' AND item_type='31' AND item_code='001' AND phase='初审'}")
                If Not dsTemp.Tables(0).Rows.Count = 0 Then
                    With dsTemp.Tables(0).Rows(0)
                        .Item("date") = SysDate
                        .Item("payout") = Currency2Numeric(Me.txtFee.Text)
                    End With
                Else
                    dr = dsTemp.Tables("project_account_detail").NewRow
                    With dr
                        .Item("project_code") = _ProCode
                        .Item("item_type") = "31"
                        .Item("item_code") = "001"
                        .Item("date") = SysDate
                        .Item("phase") = "初审"
                        .Item("payout") = Currency2Numeric(Me.txtFee.Text)
                        .Item("create_person") = UserName
                        .Item("create_date") = SysDate
                    End With
                    dsTemp.Tables("project_account_detail").Rows.Add(dr)
                End If
                result = gWs.UpdateProjectAccountDetail(dsTemp)
                If result <> "1" Then
                    'MsgBox("保存评审费失败,原因是" + result, MsgBoxStyle.Exclamation, "初审审核")
                    SWDialogBox.MessageBox.Show("*999", "保存评审费失败,原因是", result, "初审审核")
                    Return False
                End If
            End If
        End If
        'added by hute 2004-03-12  当评审结论为不受理，或者受理时不选择预收评审费时，删除可能已经存在的评审费记录
        If Not Me.cboConclusion.Text = "受理" Or Not Me.cboFeeTrial.Text = "预收" Then
            dsTemp = gWs.GetProjectAccountDetailInfo("{project_code='" & _ProCode & "' AND item_type='31' AND item_code='001' AND phase='初审'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                Dim i As Integer
                For i = 0 To dsTemp.Tables(0).Rows.Count - 1
                    dsTemp.Tables(0).Rows(i).Delete()
                Next
            End If
            Dim strResult As String = gWs.UpdateProjectAccountDetail(dsTemp)
            If strResult <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存评审费失败,原因是", strResult, "初审审核")
                Return False
            End If
        End If

        bIsChanged = False
        Return True
    End Function

    '受理不受理ComboBox
    Private Sub cboConclusion_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboConclusion.SelectedIndexChanged
        If Me.cboConclusion.Text = "受理" Then
            Me.lblFeeTrial.Visible = True
            Me.cboFeeTrial.Visible = True
            Me.cboFeeTrial_SelectedIndexChanged(Nothing, Nothing)
        Else
            Me.lblFeeTrial.Visible = False : Me.cboFeeTrial.Visible = False
            Me.lblFee.Visible = False : Me.txtFee.Visible = False
        End If
        Me.BindDataChanged(Nothing, Nothing)
    End Sub
    '预收不预收ComboBox
    Private Sub cboFeeTrial_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboFeeTrial.SelectedIndexChanged
        If Me.cboFeeTrial.Text = "预收" Then
            Me.lblFee.Visible = True
            Me.txtFee.Visible = True
            If Currency2Numeric(Me.txtFee.Text) = 0 OrElse Currency2Numeric(Me.txtFee.Text) <> Me.dAuditFee Then
                Me.txtFee.Text = Numeric2Currency(Me.dAuditFee)
            End If
        Else
            Me.lblFee.Visible = False
            Me.txtFee.Visible = False
        End If

        Me.BindDataChanged(Nothing, Nothing)
    End Sub

    '查看初审报告　
    Private Sub btnReport_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Try
            Dim doc As New frmDocumentManageBusiness(getProjectCode, getTaskID, getCorporationName, "45", "001", UserName)
            doc.setIsButtonEnable(True)
            doc.AllowTransparency = False
            doc.ShowDialog()
            doc.Text = "查看初审报告"
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '保存按钮
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not Me.AuditSave() Then
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
            Me.Cursor = Cursors.WaitCursor
            If Not Me.AuditSave() Then
                Return
            End If
            Dim strResult As String
            If Me.cboConclusion.Text.Trim() = "不受理" Then
                strResult = gWs.finishedTask(getWorkFlowID(), getProjectCode(), getTaskID(), Me.cboConclusion.Text.Trim(), UserName)
            ElseIf Me.cboConclusion.Text.Trim() = "受理" Then
                strResult = gWs.finishedTask(getWorkFlowID(), getProjectCode(), getTaskID(), Me.cboConclusion.Text & Me.cboFeeTrial.Text, UserName)
            End If
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
    '退出按钮
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If bIsChanged Then
            'MsgBox("您已经修改了数据，要保存吗？", MsgBoxStyle.YesNoCancel Or MsgBoxStyle.Question, "初审审核")
            Select Case SWDialogBox.MessageBox.Show("?1003")
                Case MsgBoxResult.Yes
                    btnSave_Click(Me.btnSave, e)
                    Me.Close()
                Case MsgBoxResult.No
                    Me.Close()
            End Select
        Else
            Close()
        End If
    End Sub

End Class
