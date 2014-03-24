'初审
Public Class frmFirstTrial
    Inherits frmCoMBase

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

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
    Friend WithEvents pgOpinion As System.Windows.Forms.TabPage
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cboConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents Label97 As System.Windows.Forms.Label
    Public WithEvents GroupBox23 As System.Windows.Forms.GroupBox
    Public WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents txtOpinion As System.Windows.Forms.TextBox
    Friend WithEvents btnFinanceImport As System.Windows.Forms.Button
    Friend WithEvents btnCreditEstimate As System.Windows.Forms.Button
    Protected WithEvents btnFinanceAnalyse As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFirstTrial))
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnFinanceImport = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.pgOpinion = New System.Windows.Forms.TabPage()
        Me.GroupBox23 = New System.Windows.Forms.GroupBox()
        Me.txtOpinion = New System.Windows.Forms.TextBox()
        Me.cboConclusion = New System.Windows.Forms.ComboBox()
        Me.Label97 = New System.Windows.Forms.Label()
        Me.btnCreditEstimate = New System.Windows.Forms.Button()
        Me.btnFinanceAnalyse = New System.Windows.Forms.Button()
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCoMBase.SuspendLayout()
        Me.grpProjectBody.SuspendLayout()
        Me.grpProjectHeader.SuspendLayout()
        Me.groupbox.SuspendLayout()
        Me.pgCorpInfo.SuspendLayout()
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpRequest.SuspendLayout()
        Me.grpProjectPassed.SuspendLayout()
        Me.pgProject.SuspendLayout()
        CType(Me.ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgOpinion.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblCorpCashArrived
        '
        Me.lblCorpCashArrived.Visible = True
        '
        'lblCorpRealAsset
        '
        Me.lblCorpRealAsset.Visible = True
        '
        'lblCorpBusinessStartDate
        '
        Me.lblCorpBusinessStartDate.Visible = True
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
        Me.dtpStartDate.Location = New System.Drawing.Point(352, 22)
        Me.dtpStartDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpStartDate.Value = New Date(2003, 7, 3, 0, 0, 0, 0)
        Me.dtpStartDate.Visible = True
        '
        'lblCorpBusinessEndDate
        '
        Me.lblCorpBusinessEndDate.Visible = True
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Value = New Date(2003, 7, 3, 0, 0, 0, 0)
        Me.dtpEndDate.Visible = True
        '
        'lblCorpContactor
        '
        Me.lblCorpContactor.Visible = True
        '
        'lblCorpRegisterAsset
        '
        Me.lblCorpRegisterAsset.Visible = True
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
        'txtRegCapital
        '
        Me.txtRegCapital.Visible = True
        '
        'cboApplyServiceType
        '
        Me.cboApplyServiceType.ItemHeight = 12
        Me.cboApplyServiceType.Visible = True
        '
        'txtRealCapital
        '
        Me.txtRealCapital.Visible = True
        '
        'txtRepresentative
        '
        Me.txtRepresentative.Visible = True
        '
        'txtInvisibleAssets
        '
        Me.txtInvisibleAssets.Visible = True
        '
        'cboApplyBranch
        '
        Me.cboApplyBranch.ItemHeight = 12
        Me.cboApplyBranch.Size = New System.Drawing.Size(184, 20)
        Me.cboApplyBranch.Visible = True
        '
        'txtRepreNation
        '
        Me.txtRepreNation.Visible = True
        '
        'txtCashReceive
        '
        Me.txtCashReceive.Size = New System.Drawing.Size(144, 21)
        Me.txtCashReceive.Visible = True
        '
        'txtRepreID
        '
        Me.txtRepreID.Visible = True
        '
        'cboApplyBank
        '
        Me.cboApplyBank.ItemHeight = 12
        Me.cboApplyBank.Size = New System.Drawing.Size(152, 20)
        Me.cboApplyBank.Visible = True
        '
        'txtContactPerson
        '
        Me.txtContactPerson.Visible = True
        '
        'txtContactNumber
        '
        Me.txtContactNumber.Size = New System.Drawing.Size(144, 21)
        Me.txtContactNumber.Visible = True
        '
        'txtFax
        '
        Me.txtFax.Visible = True
        '
        'cboRecommendType
        '
        Me.cboRecommendType.Size = New System.Drawing.Size(80, 20)
        Me.cboRecommendType.Visible = True
        '
        'lblCorpBusinessCode
        '
        Me.lblCorpBusinessCode.Visible = True
        '
        'txtCorpID
        '
        Me.txtCorpID.Visible = True
        '
        'cboProprietorShip
        '
        Me.cboProprietorShip.Size = New System.Drawing.Size(272, 20)
        Me.cboProprietorShip.Visible = True
        '
        'cboIndustryType
        '
        Me.cboIndustryType.Size = New System.Drawing.Size(248, 20)
        Me.cboIndustryType.Visible = True
        '
        'cboAddressRange
        '
        Me.cboAddressRange.Size = New System.Drawing.Size(152, 20)
        Me.cboAddressRange.Visible = True
        '
        'lblCorpPaperID
        '
        Me.lblCorpPaperID.Visible = True
        '
        'txtLoanID
        '
        Me.txtLoanID.Location = New System.Drawing.Point(352, 46)
        Me.txtLoanID.Size = New System.Drawing.Size(144, 21)
        Me.txtLoanID.Visible = True
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Visible = True
        '
        'lblCorpRepreCardID
        '
        Me.lblCorpRepreCardID.Visible = True
        '
        'txtRepID
        '
        Me.txtRepID.Visible = True
        '
        'lblCorpCardID
        '
        Me.lblCorpCardID.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'txtLoanCardID
        '
        Me.txtLoanCardID.Visible = True
        '
        'lblCorpRegisterAddress
        '
        Me.lblCorpRegisterAddress.Visible = True
        '
        'txtAddressDetail
        '
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
        'lblCorpTechType
        '
        Me.lblCorpTechType.Visible = True
        '
        'dgProject
        '
        Me.dgProject.AccessibleName = "DataGrid"
        Me.dgProject.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgProject.Size = New System.Drawing.Size(748, 116)
        Me.dgProject.Visible = True
        '
        'clbTechType
        '
        Me.clbTechType.Visible = True
        '
        'tabCoMBase
        '
        Me.tabCoMBase.Controls.AddRange(New System.Windows.Forms.Control() {Me.pgOpinion})
        Me.tabCoMBase.ItemSize = New System.Drawing.Size(60, 17)
        Me.tabCoMBase.TabStop = True
        Me.tabCoMBase.Visible = True
        '
        'dtpFoundDate
        '
        Me.dtpFoundDate.Value = New Date(2003, 7, 3, 0, 0, 0, 0)
        '
        'lblAttachMember
        '
        Me.lblAttachMember.Visible = True
        '
        'lblAttachBancholer
        '
        Me.lblAttachBancholer.Visible = True
        '
        'lblAttachMaster
        '
        Me.lblAttachMaster.Visible = True
        '
        'Label10
        '
        Me.Label10.Visible = True
        '
        'lblAttachColledge
        '
        Me.lblAttachColledge.Visible = True
        '
        'lblAttachDoctor
        '
        Me.lblAttachDoctor.Visible = True
        '
        'txtContactMobile
        '
        Me.txtContactMobile.Visible = True
        '
        'Label11
        '
        Me.Label11.Visible = True
        '
        'txtContactEmail
        '
        Me.txtContactEmail.Visible = True
        '
        'Label13
        '
        Me.Label13.Visible = True
        '
        'Label16
        '
        Me.Label16.Visible = True
        '
        'cboRecommendItems
        '
        Me.cboRecommendItems.ItemHeight = 12
        Me.cboRecommendItems.Size = New System.Drawing.Size(104, 20)
        Me.cboRecommendItems.Visible = True
        '
        'txtLegelPhone
        '
        Me.txtLegelPhone.Visible = True
        '
        'txtLegelMobile
        '
        Me.txtLegelMobile.Size = New System.Drawing.Size(144, 21)
        Me.txtLegelMobile.Visible = True
        '
        'chkIsFirstLoan
        '
        Me.chkIsFirstLoan.Visible = True
        '
        'lblProjectRequestTerm
        '
        Me.lblProjectRequestTerm.Visible = True
        '
        'lblProjectCooperateOpinion
        '
        Me.lblProjectCooperateOpinion.Visible = True
        '
        'lblProjectRecommendSum
        '
        Me.lblProjectRecommendSum.Visible = True
        '
        'lblProjectRecommendDate
        '
        Me.lblProjectRecommendDate.Visible = True
        '
        'Label7
        '
        Me.Label7.Visible = True
        '
        'lblProjectRequestSum
        '
        Me.lblProjectRequestSum.Visible = True
        '
        'lblProjectRequestBank
        '
        Me.lblProjectRequestBank.Visible = True
        '
        'lblProjectRequestBranch
        '
        Me.lblProjectRequestBranch.Visible = True
        '
        'lblProjectRequestServiceType
        '
        Me.lblProjectRequestServiceType.Visible = True
        '
        'lblProjectRequestDate
        '
        Me.lblProjectRequestDate.Visible = True
        '
        'grpProjectBody
        '
        Me.grpProjectBody.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)
        Me.grpProjectBody.Visible = True
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Visible = True
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Visible = True
        '
        'lblProjectPhase
        '
        Me.lblProjectPhase.Size = New System.Drawing.Size(64, 23)
        Me.lblProjectPhase.Visible = True
        '
        'txtCooperateOpinion
        '
        Me.txtCooperateOpinion.Visible = True
        '
        'Label14
        '
        Me.Label14.Visible = True
        '
        'grpProjectHeader
        '
        Me.grpProjectHeader.Visible = True
        '
        'txtPhase
        '
        Me.txtPhase.Visible = True
        '
        'txtEmployeeAmount
        '
        Me.txtEmployeeAmount.Visible = True
        '
        'txtDoctorNum
        '
        Me.txtDoctorNum.Visible = True
        '
        'cboMoneyType
        '
        Me.cboMoneyType.DropDownWidth = 144
        Me.cboMoneyType.ItemHeight = 12
        Me.cboMoneyType.Size = New System.Drawing.Size(144, 20)
        Me.cboMoneyType.Visible = True
        '
        'txtMasterNum
        '
        Me.txtMasterNum.Size = New System.Drawing.Size(144, 21)
        Me.txtMasterNum.Visible = True
        '
        'txtBachelorNum
        '
        Me.txtBachelorNum.Visible = True
        '
        'txtColledgeNum
        '
        Me.txtColledgeNum.Size = New System.Drawing.Size(144, 21)
        Me.txtColledgeNum.Visible = True
        '
        'groupbox
        '
        Me.groupbox.Visible = True
        '
        'txtRecommendSum
        '
        Me.txtRecommendSum.Visible = True
        '
        'dtpRecommend
        '
        Me.dtpRecommend.Value = New Date(2003, 4, 30, 21, 20, 20, 343)
        Me.dtpRecommend.Visible = True
        '
        'lblMoneyType
        '
        Me.lblMoneyType.Visible = True
        '
        'txtApplySum
        '
        Me.txtApplySum.Visible = True
        '
        'nuTerm
        '
        Me.nuTerm.Visible = True
        '
        'dtpApplyDate
        '
        Me.dtpApplyDate.Enabled = False
        Me.dtpApplyDate.Value = New Date(2003, 4, 30, 21, 20, 20, 375)
        Me.dtpApplyDate.Visible = True
        '
        'txtPurpose
        '
        Me.txtPurpose.Visible = True
        '
        'txtRecommendPerson
        '
        Me.txtRecommendPerson.Visible = True
        '
        'grpRequest
        '
        Me.grpRequest.Location = New System.Drawing.Point(0, 131)
        Me.grpRequest.Size = New System.Drawing.Size(754, 256)
        Me.grpRequest.Visible = True
        '
        'grpProjectPassed
        '
        Me.grpProjectPassed.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)
        Me.grpProjectPassed.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpProjectPassed.Location = New System.Drawing.Point(0, 0)
        Me.grpProjectPassed.Size = New System.Drawing.Size(754, 136)
        Me.grpProjectPassed.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(663, 492)
        Me.btnExit.TabIndex = 1006
        Me.btnExit.TabStop = True
        Me.btnExit.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(581, 492)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 1005
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnReport
        '
        Me.btnReport.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Bitmap)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.ImageIndex = 19
        Me.btnReport.ImageList = Me.ImageListBasic
        Me.btnReport.Location = New System.Drawing.Point(374, 492)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(120, 23)
        Me.btnReport.TabIndex = 1003
        Me.btnReport.Text = "制作初审报告(&M)"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFinanceImport
        '
        Me.btnFinanceImport.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnFinanceImport.Image = CType(resources.GetObject("btnFinanceImport.Image"), System.Drawing.Bitmap)
        Me.btnFinanceImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFinanceImport.ImageIndex = 27
        Me.btnFinanceImport.ImageList = Me.ImageListBasic
        Me.btnFinanceImport.Location = New System.Drawing.Point(47, 492)
        Me.btnFinanceImport.Name = "btnFinanceImport"
        Me.btnFinanceImport.Size = New System.Drawing.Size(120, 23)
        Me.btnFinanceImport.TabIndex = 1000
        Me.btnFinanceImport.Text = "录入财务数据(&F)"
        Me.btnFinanceImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(499, 492)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 1004
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'pgOpinion
        '
        Me.pgOpinion.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox23})
        Me.pgOpinion.Location = New System.Drawing.Point(4, 21)
        Me.pgOpinion.Name = "pgOpinion"
        Me.pgOpinion.Size = New System.Drawing.Size(754, 387)
        Me.pgOpinion.TabIndex = 13
        Me.pgOpinion.Text = "初审意见"
        '
        'GroupBox23
        '
        Me.GroupBox23.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtOpinion, Me.cboConclusion, Me.Label97})
        Me.GroupBox23.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(754, 387)
        Me.GroupBox23.TabIndex = 0
        Me.GroupBox23.TabStop = False
        '
        'txtOpinion
        '
        Me.txtOpinion.Dock = System.Windows.Forms.DockStyle.Top
        Me.txtOpinion.Location = New System.Drawing.Point(3, 17)
        Me.txtOpinion.MaxLength = 250
        Me.txtOpinion.Multiline = True
        Me.txtOpinion.Name = "txtOpinion"
        Me.txtOpinion.Size = New System.Drawing.Size(748, 335)
        Me.txtOpinion.TabIndex = 3
        Me.txtOpinion.Text = ""
        '
        'cboConclusion
        '
        Me.cboConclusion.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.cboConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConclusion.Location = New System.Drawing.Point(120, 360)
        Me.cboConclusion.Name = "cboConclusion"
        Me.cboConclusion.Size = New System.Drawing.Size(117, 20)
        Me.cboConclusion.TabIndex = 2
        '
        'Label97
        '
        Me.Label97.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label97.Location = New System.Drawing.Point(56, 360)
        Me.Label97.Name = "Label97"
        Me.Label97.Size = New System.Drawing.Size(69, 23)
        Me.Label97.TabIndex = 0
        Me.Label97.Text = "初审结论"
        Me.Label97.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCreditEstimate
        '
        Me.btnCreditEstimate.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCreditEstimate.Image = CType(resources.GetObject("btnCreditEstimate.Image"), System.Drawing.Bitmap)
        Me.btnCreditEstimate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreditEstimate.ImageIndex = 21
        Me.btnCreditEstimate.ImageList = Me.ImageListBasic
        Me.btnCreditEstimate.Location = New System.Drawing.Point(273, 492)
        Me.btnCreditEstimate.Name = "btnCreditEstimate"
        Me.btnCreditEstimate.Size = New System.Drawing.Size(96, 23)
        Me.btnCreditEstimate.TabIndex = 1002
        Me.btnCreditEstimate.Text = "资信评分(&R)"
        Me.btnCreditEstimate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFinanceAnalyse
        '
        Me.btnFinanceAnalyse.Image = CType(resources.GetObject("btnFinanceAnalyse.Image"), System.Drawing.Bitmap)
        Me.btnFinanceAnalyse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFinanceAnalyse.ImageIndex = 28
        Me.btnFinanceAnalyse.ImageList = Me.ImageListBasic
        Me.btnFinanceAnalyse.Location = New System.Drawing.Point(172, 492)
        Me.btnFinanceAnalyse.Name = "btnFinanceAnalyse"
        Me.btnFinanceAnalyse.Size = New System.Drawing.Size(96, 23)
        Me.btnFinanceAnalyse.TabIndex = 1007
        Me.btnFinanceAnalyse.Text = "财务分析(&A)"
        Me.btnFinanceAnalyse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmFirstTrial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(786, 519)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.grpProjectBody, Me.grpProjectHeader, Me.btnCreditEstimate, Me.btnFinanceAnalyse, Me.btnFinanceImport, Me.btnSave, Me.btnReport, Me.btnCommit})
        Me.MinimizeBox = False
        Me.Name = "frmFirstTrial"
        Me.Text = "初审"
        Me.WindowState = System.Windows.Forms.FormWindowState.Normal
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCoMBase.ResumeLayout(False)
        Me.grpProjectBody.ResumeLayout(False)
        Me.grpProjectHeader.ResumeLayout(False)
        Me.groupbox.ResumeLayout(False)
        Me.pgCorpInfo.ResumeLayout(False)
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpRequest.ResumeLayout(False)
        Me.grpProjectPassed.ResumeLayout(False)
        Me.pgProject.ResumeLayout(False)
        CType(Me.ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgOpinion.ResumeLayout(False)
        Me.GroupBox23.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FirstTrial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Init()
        Me.cboConclusion.Items.AddRange(New Object() {"受理", "不受理"})
        Me.cboConclusion.SelectedIndex = 0

        dstemp = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me._ProCode & "' AND item_type='51' AND item_code='002'}")
        If Not dstemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                Me.txtOpinion.Text = IIf(IsDBNull(.Item("content")), "", .Item("content"))
                Me.cboConclusion.SelectedItem = IIf(IsDBNull(.Item("conclusion")), "", .Item("conclusion"))
            End With
        End If

        AddHandler txtOpinion.TextChanged, AddressOf BindDataChanged
        AddHandler cboConclusion.SelectedIndexChanged, AddressOf BindDataChanged
    End Sub

    Private Function TrialSave() As Boolean
        If Not Save() Then
            Return False
        End If

        dstemp = gWs.GetProjectOpinionByProjectNo("{project_code like '" & Me._ProCode & "' and item_type='51' and item_code='002'}")
        If Not dstemp.Tables(0).Rows.Count = 0 Then
            With dsTemp.Tables(0).Rows(0)
                .Item("content") = Me.txtOpinion.Text '初审意见
                .Item("conclusion") = Me.cboConclusion.Text '初审结论，是否受理
            End With
        Else
            Dim dr As DataRow = dstemp.Tables(0).NewRow()
            With dr
                .Item("project_code") = _ProCode
                .Item("content") = Me.txtOpinion.Text
                .Item("item_type") = "51"
                .Item("item_code") = "002"
                .Item("conclusion") = Me.cboConclusion.Text
                .Item("create_person") = UserName
                .Item("create_date") = SysDate
            End With
            dstemp.Tables(0).Rows.Add(dr)
        End If

        Dim strResult As String = gWs.UpdateProjectOpinion(dstemp)
        If strResult <> "1" Then
            'MsgBox("保存初审意见失败", MsgBoxStyle.Exclamation, "初审")
            SWDialogBox.MessageBox.Show("*999", "保存初审意见失败", strResult, "初审")
            Return False
        Else
            bIsChanged = False
            Return True
        End If
    End Function

#Region "按钮"

    '录入财务数据按钮
    Private Sub btnFinanceImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinanceImport.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim f As New frmFinanceManage(getProjectCode, getCorporationName, Me._CorpCode, "初审", Me)
            f.AllowTransparency = False
            f.Text = "录入财务数据"
            f.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '财务分析按钮
    Private Sub btnAnalisisFinance_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinanceAnalyse.Click
        If Not TrialSave() Then
            Return
        End If
        Me.AnalisisFinance(Me._ProCode, Me._CorpCode, Me._Phase)
    End Sub
    '资信评分按钮
    Private Sub btnCreditEstimate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreditEstimate.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim dsTemp As DataSet = gWs.GetAccount("{project_code LIKE '" & Me._ProCode & "' AND phase LIKE '初审'}")
            If dsTemp.Tables(0).Rows.Count = 0 Then
                SWDialogBox.MessageBox.Show("$1005", "该项目的初审财务数据")
            End If
            Dim f As New FProjectCredit()
            f.SetEditState(False)
            f.Text = "资信评分"
            f.ShowDialog(_ProCode, Me._CorpCode, _Phase)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '制作初审报告
    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not TrialSave() Then
                Return
            End If
            If gWs.GetProjectOpinionByProjectNo("{project_code like '" & Me._ProCode & "' and item_type='51' and item_code='002'}").Tables(0).Rows.Count = 0 Then
                SWDialogBox.MessageBox.Show("$X053")
                Return
            End If
            '没有进行“财务分析”就不能进行文档管理。
            If Not Me.hasFinanceAnalysis(Me._ProCode, "初审") Then
                'If DialogResult.No = MessageBox.Show("该项目没有进行财务分析，是否继续？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) Then
                If DialogResult.No = SWDialogBox.MessageBox.Show("?X008") Then
                    Return
                End If
            End If
            Dim f As New frmDocumentManageBusiness(Me._ProCode, Me.getTaskID(), Me.getCorporationName(), "45", "001", UserName)
            f.AllowTransparency = False
            f.ShowDialog()

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '保存按钮
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not TrialSave() Then
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
            If Not TrialSave() Then
                Return
            End If
            If Not HasReport("001", "45") Then
                SWDialogBox.MessageBox.Show("$1005", "初审报告") 'MsgBox("初审报告没有上载，不能提交！", MsgBoxStyle.Exclamation, "初审")
                Return
            End If
            Dim strResult As String = gWs.finishedTask(getWorkFlowID(), getProjectCode(), getTaskID(), "", UserName)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "初审")
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
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If Not Me.bIsChanged Then
            Me.Close()
            Return
        End If
        Select Case SWDialogBox.MessageBox.Show("?1003")
            Case DialogResult.Yes
                If Not Me.TrialSave() Then
                    Return
                End If
                SWDialogBox.MessageBox.Show("$SaveSucceed")
            Case DialogResult.Cancel
                Return
        End Select
        Me.Close()
    End Sub
#End Region

End Class

