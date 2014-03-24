'作者： 罗庆锋 日期：2003-04-10
'记录评审会议记录
Public Class frmMeetingRecordExp
    Inherits frmBasic
    '通过，暂缓，补充调查
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        Me.btnSplitProject.Enabled = (ProjectCode = String.Empty)

    End Sub

    Public Sub New(ByVal project_code As String, ByVal corpName As String)
        Me.New()
        ProjectCode = project_code
        CorporationName = corpName
    End Sub

    Public Sub New(ByVal canEditSplitProject As Boolean, ByVal is_SplitProject As Boolean, ByVal ParProjectCode As String)
        Me.New()

        Me.btnSplitProject.Enabled = canEditSplitProject
        Me.isSplitProject = is_SplitProject
        Me.ParentProjectCode = ParProjectCode
    End Sub
    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsAccountDetail Is Nothing Then
            dsAccountDetail.Dispose()
        End If
        If Not dsArea Is Nothing Then
            dsArea.Dispose()
        End If
        If Not dsBank Is Nothing Then
            dsBank.Dispose()
        End If
        If Not dsBureau Is Nothing Then
            dsBureau.Dispose()
        End If
        If Not dsConCopy Is Nothing Then
            dsConCopy.Dispose()
        End If
        If Not dsConference Is Nothing Then
            dsConference.Dispose()
        End If
        If Not dsConferenceTrial Is Nothing Then
            dsConferenceTrial.Dispose()
        End If
        If Not dsCor Is Nothing Then
            dsCor.Dispose()
        End If
        If Not dsGuaForm Is Nothing Then
            dsGuaForm.Dispose()
        End If
        If Not dsGuaranteeLetter Is Nothing Then
            dsGuaranteeLetter.Dispose()
        End If
        If Not dsGuaranteeLetterType Is Nothing Then
            dsGuaranteeLetterType.Dispose()
        End If
        If Not dsGuaranteeLetterUsage Is Nothing Then
            dsGuaranteeLetterUsage.Dispose()
        End If
        If Not dsGuaranty Is Nothing Then
            dsGuaranty.Dispose()
        End If
        If Not dsGuaSubmit Is Nothing Then
            dsGuaSubmit.Dispose()
        End If
        If Not dsOppGuaForm Is Nothing Then
            dsOppGuaForm.Dispose()
        End If
        If Not dsPerson Is Nothing Then
            dsPerson.Dispose()
        End If
        If Not dsPro Is Nothing Then
            dsPro.Dispose()
        End If
        If Not dsProCor Is Nothing Then
            dsProCor.Dispose()
        End If
        If Not dsProInfo Is Nothing Then
            dsProInfo.Dispose()
        End If
        If Not dsReimburseType Is Nothing Then
            dsReimburseType.Dispose()
        End If
        If Not dsServiceType Is Nothing Then
            dsServiceType.Dispose()
        End If
        If Not dsStaffRole Is Nothing Then
            dsStaffRole.Dispose()
        End If
        If Not dsSubBank Is Nothing Then
            dsSubBank.Dispose()
        End If
        If Not dsAdditionalForm Is Nothing Then
            dsAdditionalForm.Dispose()
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

    Friend WithEvents dgOpinion As System.Windows.Forms.DataGrid
    Public WithEvents txtCorName As System.Windows.Forms.TextBox
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTimes As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbxServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbxFinalDesicion As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbxConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbxRefundtype As System.Windows.Forms.ComboBox
    Friend WithEvents cmbxLoanForm As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tpOpinion As System.Windows.Forms.TabPage
    Friend WithEvents tpConclusion As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents nudTerms As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtMeetCount As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents gpbxOppGua As System.Windows.Forms.GroupBox
    Friend WithEvents dgOppGua As System.Windows.Forms.DataGrid
    Friend WithEvents tpOppGua As System.Windows.Forms.TabPage
    Friend WithEvents txtOpinion As System.Windows.Forms.TextBox
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtReviewFeeStandard As System.Windows.Forms.TextBox
    Friend WithEvents txtGuarantyFeeStandard As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtReviewFee As System.Windows.Forms.TextBox
    Friend WithEvents txtGuarantyFee As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents tpInfo As System.Windows.Forms.TabPage
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtNewName As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents cmbxArea As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cmbxApplyServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents cmbxApplyBank As System.Windows.Forms.ComboBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtApplySum As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtApplyTerms As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents cmbxSubBank As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRateRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtLoanRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtReturnRemark As System.Windows.Forms.TextBox
    Friend WithEvents gpbxInfo As System.Windows.Forms.GroupBox
    Friend WithEvents gpbxConclusion As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents cboPartner As System.Windows.Forms.ComboBox
    Friend WithEvents dtpPartnerDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtPartnerMoney As System.Windows.Forms.TextBox
    Friend WithEvents txtPartnerOpnion As System.Windows.Forms.TextBox
    Friend WithEvents chkPartner As System.Windows.Forms.CheckBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents lblGuaranSumDescription As System.Windows.Forms.Label
    Friend WithEvents lblTermDescription As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtScaleMoney As System.Windows.Forms.TextBox
    Friend WithEvents txtGuaranteeScale As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents cboRebetType As System.Windows.Forms.ComboBox
    Friend WithEvents cboBaoHanType As System.Windows.Forms.ComboBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dgIntegrate As System.Windows.Forms.DataGrid
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtApplyDate As System.Windows.Forms.TextBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cboRunMode As System.Windows.Forms.ComboBox
    Friend WithEvents gpbDownLetter As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemainLetter As System.Windows.Forms.TextBox
    Friend WithEvents txtEndDateLetter As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents cboLetterBank As System.Windows.Forms.ComboBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents cboLetterSubBank As System.Windows.Forms.ComboBox
    Friend WithEvents tpOtherInfo As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents gpxBaoHan As System.Windows.Forms.GroupBox
    Friend WithEvents gpxReGuarantee As System.Windows.Forms.GroupBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtReOrganizationName As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtReGuaranteeCondition As System.Windows.Forms.TextBox
    Friend WithEvents lblGuaranteeFeeStandDesc As System.Windows.Forms.Label
    Friend WithEvents lblGuaFeeDescription As System.Windows.Forms.Label
    Friend WithEvents txtSourceST As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtSourceGS As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtSourceTerms As SWSystem.Windows.Forms.TextBox
    Protected WithEvents btnCommit As System.Windows.Forms.Button
    Protected WithEvents btnSave As System.Windows.Forms.Button
    Protected WithEvents btnSplitProject As System.Windows.Forms.Button
    Protected WithEvents TabControl As System.Windows.Forms.TabControl
    Protected WithEvents btnDetailInfo As System.Windows.Forms.Button
    Protected WithEvents btnJoinReport As System.Windows.Forms.Button
    Protected WithEvents btnPrintReport As System.Windows.Forms.Button
    Friend WithEvents txtEachReturnFee As System.Windows.Forms.TextBox
    Friend WithEvents txtGuarantySum As System.Windows.Forms.TextBox
    Protected WithEvents btnSupplyOppGua As System.Windows.Forms.Button
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents gpxAdditionalForm As System.Windows.Forms.GroupBox
    Friend WithEvents cklbxAdditionalForm As System.Windows.Forms.CheckedListBox
    Friend WithEvents dgDetail As System.Windows.Forms.DataGrid
    Friend WithEvents dtpGuarantStartDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents dtpGuarantEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tpExpConclusion As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cboConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtExpandRefundAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtExpandTerm As System.Windows.Forms.TextBox
    Friend WithEvents txtExpandAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExpendApplyReason As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents txtExpandApplyTerm As System.Windows.Forms.TextBox
    Friend WithEvents txtExpandApplyAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents cboExpandRefundType As System.Windows.Forms.ComboBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents txtGuarantyFeeExp As System.Windows.Forms.TextBox
    Friend WithEvents txtGuarantyFeeStandardExp As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMeetingRecordExp))
        Me.btnCommit = New System.Windows.Forms.Button
        Me.TabControl = New System.Windows.Forms.TabControl
        Me.tpInfo = New System.Windows.Forms.TabPage
        Me.gpbxInfo = New System.Windows.Forms.GroupBox
        Me.cmbxSubBank = New System.Windows.Forms.ComboBox
        Me.txtApplyDate = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cboPartner = New System.Windows.Forms.ComboBox
        Me.chkPartner = New System.Windows.Forms.CheckBox
        Me.dtpPartnerDate = New System.Windows.Forms.DateTimePicker
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtPartnerMoney = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtPartnerOpnion = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmbxArea = New System.Windows.Forms.ComboBox
        Me.txtNewName = New System.Windows.Forms.TextBox
        Me.txtApplySum = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.Label32 = New System.Windows.Forms.Label
        Me.cmbxApplyBank = New System.Windows.Forms.ComboBox
        Me.cmbxApplyServiceType = New System.Windows.Forms.ComboBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtApplyTerms = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Label29 = New System.Windows.Forms.Label
        Me.tpOpinion = New System.Windows.Forms.TabPage
        Me.txtMeetCount = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtOpinion = New System.Windows.Forms.TextBox
        Me.dgOpinion = New System.Windows.Forms.DataGrid
        Me.tpConclusion = New System.Windows.Forms.TabPage
        Me.gpbxConclusion = New System.Windows.Forms.GroupBox
        Me.dtpGuarantEndDate = New System.Windows.Forms.DateTimePicker
        Me.lblMonth = New System.Windows.Forms.Label
        Me.txtEachReturnFee = New System.Windows.Forms.TextBox
        Me.cboRunMode = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.cboRebetType = New System.Windows.Forms.ComboBox
        Me.cboBaoHanType = New System.Windows.Forms.ComboBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.txtScaleMoney = New System.Windows.Forms.TextBox
        Me.Label48 = New System.Windows.Forms.Label
        Me.txtGuaranteeScale = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.txtReturnRemark = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtLoanRemark = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtRateRemark = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtGuarantyFee = New System.Windows.Forms.TextBox
        Me.lblGuaFeeDescription = New System.Windows.Forms.Label
        Me.txtReviewFee = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtGuarantyFeeStandard = New System.Windows.Forms.TextBox
        Me.lblGuaranteeFeeStandDesc = New System.Windows.Forms.Label
        Me.txtReviewFeeStandard = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtRemark = New System.Windows.Forms.TextBox
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.nudTerms = New System.Windows.Forms.NumericUpDown
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbxRefundtype = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.cmbxLoanForm = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtTimes = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbxServiceType = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cbxFinalDesicion = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbxConclusion = New System.Windows.Forms.ComboBox
        Me.lblGuaranSumDescription = New System.Windows.Forms.Label
        Me.lblTermDescription = New System.Windows.Forms.Label
        Me.txtGuarantySum = New System.Windows.Forms.TextBox
        Me.dtpGuarantStartDate = New System.Windows.Forms.DateTimePicker
        Me.tpExpConclusion = New System.Windows.Forms.TabPage
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.txtGuarantyFeeExp = New System.Windows.Forms.TextBox
        Me.Label53 = New System.Windows.Forms.Label
        Me.txtGuarantyFeeStandardExp = New System.Windows.Forms.TextBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.cboConclusion = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtExpandRefundAmount = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.cboExpandRefundType = New System.Windows.Forms.ComboBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtExpandTerm = New System.Windows.Forms.TextBox
        Me.txtExpandAmount = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtExpendApplyReason = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.txtExpandApplyTerm = New System.Windows.Forms.TextBox
        Me.txtExpandApplyAmount = New System.Windows.Forms.TextBox
        Me.lblSum = New System.Windows.Forms.Label
        Me.Label50 = New System.Windows.Forms.Label
        Me.tpOppGua = New System.Windows.Forms.TabPage
        Me.dgDetail = New System.Windows.Forms.DataGrid
        Me.gpxAdditionalForm = New System.Windows.Forms.GroupBox
        Me.cklbxAdditionalForm = New System.Windows.Forms.CheckedListBox
        Me.Splitter1 = New System.Windows.Forms.Splitter
        Me.gpbxOppGua = New System.Windows.Forms.GroupBox
        Me.dgOppGua = New System.Windows.Forms.DataGrid
        Me.tpOtherInfo = New System.Windows.Forms.TabPage
        Me.gpxReGuarantee = New System.Windows.Forms.GroupBox
        Me.txtSourceTerms = New SWSystem.Windows.Forms.TextBox
        Me.txtSourceGS = New SWSystem.Windows.Forms.TextBox
        Me.txtSourceST = New SWSystem.Windows.Forms.TextBox
        Me.txtReGuaranteeCondition = New System.Windows.Forms.TextBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.txtReOrganizationName = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.gpxBaoHan = New System.Windows.Forms.GroupBox
        Me.btnNew = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label41 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.cboLetterBank = New System.Windows.Forms.ComboBox
        Me.cboLetterSubBank = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgIntegrate = New System.Windows.Forms.DataGrid
        Me.btnDelete = New System.Windows.Forms.Button
        Me.gpbDownLetter = New System.Windows.Forms.GroupBox
        Me.txtRemainLetter = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtEndDateLetter = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtCorName = New System.Windows.Forms.TextBox
        Me.txtProjectCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnPrintReport = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnDetailInfo = New System.Windows.Forms.Button
        Me.btnJoinReport = New System.Windows.Forms.Button
        Me.btnSplitProject = New System.Windows.Forms.Button
        Me.btnSupplyOppGua = New System.Windows.Forms.Button
        Me.TabControl.SuspendLayout()
        Me.tpInfo.SuspendLayout()
        Me.gpbxInfo.SuspendLayout()
        Me.tpOpinion.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgOpinion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpConclusion.SuspendLayout()
        Me.gpbxConclusion.SuspendLayout()
        CType(Me.nudTerms, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpExpConclusion.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.tpOppGua.SuspendLayout()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpxAdditionalForm.SuspendLayout()
        Me.gpbxOppGua.SuspendLayout()
        CType(Me.dgOppGua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpOtherInfo.SuspendLayout()
        Me.gpxReGuarantee.SuspendLayout()
        Me.gpxBaoHan.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgIntegrate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbDownLetter.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(584, 504)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(70, 23)
        Me.btnExit.TabIndex = 46
        Me.btnExit.Text = "退出(&X)"
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(398, 504)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(70, 23)
        Me.btnCommit.TabIndex = 45
        Me.btnCommit.Text = "提交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TabControl
        '
        Me.TabControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl.Controls.Add(Me.tpInfo)
        Me.TabControl.Controls.Add(Me.tpOpinion)
        Me.TabControl.Controls.Add(Me.tpConclusion)
        Me.TabControl.Controls.Add(Me.tpExpConclusion)
        Me.TabControl.Controls.Add(Me.tpOppGua)
        Me.TabControl.Controls.Add(Me.tpOtherInfo)
        Me.TabControl.Location = New System.Drawing.Point(8, 32)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(640, 464)
        Me.TabControl.TabIndex = 30
        '
        'tpInfo
        '
        Me.tpInfo.Controls.Add(Me.gpbxInfo)
        Me.tpInfo.Location = New System.Drawing.Point(4, 21)
        Me.tpInfo.Name = "tpInfo"
        Me.tpInfo.Size = New System.Drawing.Size(632, 439)
        Me.tpInfo.TabIndex = 4
        Me.tpInfo.Text = "项目信息"
        '
        'gpbxInfo
        '
        Me.gpbxInfo.Controls.Add(Me.cmbxSubBank)
        Me.gpbxInfo.Controls.Add(Me.txtApplyDate)
        Me.gpbxInfo.Controls.Add(Me.Label8)
        Me.gpbxInfo.Controls.Add(Me.cboPartner)
        Me.gpbxInfo.Controls.Add(Me.chkPartner)
        Me.gpbxInfo.Controls.Add(Me.dtpPartnerDate)
        Me.gpbxInfo.Controls.Add(Me.Label36)
        Me.gpbxInfo.Controls.Add(Me.txtPartnerMoney)
        Me.gpbxInfo.Controls.Add(Me.Label19)
        Me.gpbxInfo.Controls.Add(Me.txtPartnerOpnion)
        Me.gpbxInfo.Controls.Add(Me.Label18)
        Me.gpbxInfo.Controls.Add(Me.cmbxArea)
        Me.gpbxInfo.Controls.Add(Me.txtNewName)
        Me.gpbxInfo.Controls.Add(Me.txtApplySum)
        Me.gpbxInfo.Controls.Add(Me.Label30)
        Me.gpbxInfo.Controls.Add(Me.Label32)
        Me.gpbxInfo.Controls.Add(Me.cmbxApplyBank)
        Me.gpbxInfo.Controls.Add(Me.cmbxApplyServiceType)
        Me.gpbxInfo.Controls.Add(Me.Label35)
        Me.gpbxInfo.Controls.Add(Me.Label33)
        Me.gpbxInfo.Controls.Add(Me.Label31)
        Me.gpbxInfo.Controls.Add(Me.txtApplyTerms)
        Me.gpbxInfo.Controls.Add(Me.Label34)
        Me.gpbxInfo.Controls.Add(Me.Label29)
        Me.gpbxInfo.Location = New System.Drawing.Point(8, 8)
        Me.gpbxInfo.Name = "gpbxInfo"
        Me.gpbxInfo.Size = New System.Drawing.Size(616, 408)
        Me.gpbxInfo.TabIndex = 83
        Me.gpbxInfo.TabStop = False
        '
        'cmbxSubBank
        '
        Me.cmbxSubBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxSubBank.Location = New System.Drawing.Point(408, 128)
        Me.cmbxSubBank.Name = "cmbxSubBank"
        Me.cmbxSubBank.Size = New System.Drawing.Size(121, 20)
        Me.cmbxSubBank.TabIndex = 0
        '
        'txtApplyDate
        '
        Me.txtApplyDate.Location = New System.Drawing.Point(408, 80)
        Me.txtApplyDate.Name = "txtApplyDate"
        Me.txtApplyDate.ReadOnly = True
        Me.txtApplyDate.Size = New System.Drawing.Size(120, 21)
        Me.txtApplyDate.TabIndex = 89
        Me.txtApplyDate.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(344, 83)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 17)
        Me.Label8.TabIndex = 88
        Me.Label8.Text = "申请日期"
        '
        'cboPartner
        '
        Me.cboPartner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartner.Enabled = False
        Me.cboPartner.Location = New System.Drawing.Point(112, 216)
        Me.cboPartner.Name = "cboPartner"
        Me.cboPartner.Size = New System.Drawing.Size(112, 20)
        Me.cboPartner.TabIndex = 13
        '
        'chkPartner
        '
        Me.chkPartner.Location = New System.Drawing.Point(16, 216)
        Me.chkPartner.Name = "chkPartner"
        Me.chkPartner.Size = New System.Drawing.Size(88, 20)
        Me.chkPartner.TabIndex = 12
        Me.chkPartner.Text = "推荐合作区"
        '
        'dtpPartnerDate
        '
        Me.dtpPartnerDate.Enabled = False
        Me.dtpPartnerDate.Location = New System.Drawing.Point(496, 216)
        Me.dtpPartnerDate.Name = "dtpPartnerDate"
        Me.dtpPartnerDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpPartnerDate.TabIndex = 15
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(440, 218)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(54, 17)
        Me.Label36.TabIndex = 87
        Me.Label36.Text = "推荐日期"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPartnerMoney
        '
        Me.txtPartnerMoney.Enabled = False
        Me.txtPartnerMoney.Location = New System.Drawing.Point(336, 216)
        Me.txtPartnerMoney.Name = "txtPartnerMoney"
        Me.txtPartnerMoney.Size = New System.Drawing.Size(96, 21)
        Me.txtPartnerMoney.TabIndex = 14
        Me.txtPartnerMoney.Text = ""
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(240, 218)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(91, 17)
        Me.Label19.TabIndex = 85
        Me.Label19.Text = "推荐金额(万元)"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPartnerOpnion
        '
        Me.txtPartnerOpnion.Enabled = False
        Me.txtPartnerOpnion.Location = New System.Drawing.Point(112, 264)
        Me.txtPartnerOpnion.MaxLength = 250
        Me.txtPartnerOpnion.Multiline = True
        Me.txtPartnerOpnion.Name = "txtPartnerOpnion"
        Me.txtPartnerOpnion.Size = New System.Drawing.Size(496, 88)
        Me.txtPartnerOpnion.TabIndex = 16
        Me.txtPartnerOpnion.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(16, 272)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 17)
        Me.Label18.TabIndex = 83
        Me.Label18.Text = "合 作 区 意 见"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbxArea
        '
        Me.cmbxArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxArea.Location = New System.Drawing.Point(408, 32)
        Me.cmbxArea.Name = "cmbxArea"
        Me.cmbxArea.Size = New System.Drawing.Size(120, 20)
        Me.cmbxArea.TabIndex = 3
        '
        'txtNewName
        '
        Me.txtNewName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNewName.Location = New System.Drawing.Point(112, 32)
        Me.txtNewName.Name = "txtNewName"
        Me.txtNewName.ReadOnly = True
        Me.txtNewName.Size = New System.Drawing.Size(216, 21)
        Me.txtNewName.TabIndex = 1
        Me.txtNewName.Text = ""
        '
        'txtApplySum
        '
        Me.txtApplySum.Location = New System.Drawing.Point(112, 168)
        Me.txtApplySum.Name = "txtApplySum"
        Me.txtApplySum.TabIndex = 9
        Me.txtApplySum.Text = ""
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(344, 32)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(60, 17)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "所属区域 "
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(16, 128)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(79, 17)
        Me.Label32.TabIndex = 6
        Me.Label32.Text = "申请贷款银行"
        Me.Label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbxApplyBank
        '
        Me.cmbxApplyBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxApplyBank.Location = New System.Drawing.Point(112, 128)
        Me.cmbxApplyBank.Name = "cmbxApplyBank"
        Me.cmbxApplyBank.Size = New System.Drawing.Size(216, 20)
        Me.cmbxApplyBank.TabIndex = 7
        '
        'cmbxApplyServiceType
        '
        Me.cmbxApplyServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxApplyServiceType.Location = New System.Drawing.Point(112, 80)
        Me.cmbxApplyServiceType.Name = "cmbxApplyServiceType"
        Me.cmbxApplyServiceType.Size = New System.Drawing.Size(216, 20)
        Me.cmbxApplyServiceType.TabIndex = 5
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(344, 128)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(48, 17)
        Me.Label35.TabIndex = 12
        Me.Label35.Text = "支   行"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(16, 168)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(91, 17)
        Me.Label33.TabIndex = 8
        Me.Label33.Text = "申请金额(万元)"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(16, 80)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(79, 17)
        Me.Label31.TabIndex = 4
        Me.Label31.Text = "申请业务品种"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtApplyTerms
        '
        Me.txtApplyTerms.Location = New System.Drawing.Point(296, 168)
        Me.txtApplyTerms.Name = "txtApplyTerms"
        Me.txtApplyTerms.Size = New System.Drawing.Size(32, 21)
        Me.txtApplyTerms.TabIndex = 11
        Me.txtApplyTerms.Text = ""
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(240, 168)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(54, 17)
        Me.Label34.TabIndex = 10
        Me.Label34.Text = "期限(月)"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(16, 32)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 17)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "企 业 名 称"
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tpOpinion
        '
        Me.tpOpinion.Controls.Add(Me.txtMeetCount)
        Me.tpOpinion.Controls.Add(Me.Label24)
        Me.tpOpinion.Controls.Add(Me.GroupBox3)
        Me.tpOpinion.Controls.Add(Me.dgOpinion)
        Me.tpOpinion.Location = New System.Drawing.Point(4, 21)
        Me.tpOpinion.Name = "tpOpinion"
        Me.tpOpinion.Size = New System.Drawing.Size(632, 439)
        Me.tpOpinion.TabIndex = 0
        Me.tpOpinion.Text = "评委意见"
        '
        'txtMeetCount
        '
        Me.txtMeetCount.BackColor = System.Drawing.SystemColors.Window
        Me.txtMeetCount.Enabled = False
        Me.txtMeetCount.Location = New System.Drawing.Point(72, 5)
        Me.txtMeetCount.Name = "txtMeetCount"
        Me.txtMeetCount.Size = New System.Drawing.Size(40, 21)
        Me.txtMeetCount.TabIndex = 31
        Me.txtMeetCount.Text = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 8)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(54, 17)
        Me.Label24.TabIndex = 30
        Me.Label24.Text = "上会次数"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtOpinion)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 328)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(616, 104)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "评委意见"
        '
        'txtOpinion
        '
        Me.txtOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtOpinion.Location = New System.Drawing.Point(3, 17)
        Me.txtOpinion.MaxLength = 500
        Me.txtOpinion.Multiline = True
        Me.txtOpinion.Name = "txtOpinion"
        Me.txtOpinion.Size = New System.Drawing.Size(610, 84)
        Me.txtOpinion.TabIndex = 4
        Me.txtOpinion.Text = ""
        '
        'dgOpinion
        '
        Me.dgOpinion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgOpinion.CaptionVisible = False
        Me.dgOpinion.DataMember = ""
        Me.dgOpinion.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgOpinion.Location = New System.Drawing.Point(9, 32)
        Me.dgOpinion.Name = "dgOpinion"
        Me.dgOpinion.Size = New System.Drawing.Size(615, 296)
        Me.dgOpinion.TabIndex = 0
        '
        'tpConclusion
        '
        Me.tpConclusion.Controls.Add(Me.gpbxConclusion)
        Me.tpConclusion.Location = New System.Drawing.Point(4, 21)
        Me.tpConclusion.Name = "tpConclusion"
        Me.tpConclusion.Size = New System.Drawing.Size(632, 439)
        Me.tpConclusion.TabIndex = 1
        Me.tpConclusion.Text = "评审会意见"
        '
        'gpbxConclusion
        '
        Me.gpbxConclusion.Controls.Add(Me.dtpGuarantEndDate)
        Me.gpbxConclusion.Controls.Add(Me.lblMonth)
        Me.gpbxConclusion.Controls.Add(Me.txtEachReturnFee)
        Me.gpbxConclusion.Controls.Add(Me.cboRunMode)
        Me.gpbxConclusion.Controls.Add(Me.Label9)
        Me.gpbxConclusion.Controls.Add(Me.Label38)
        Me.gpbxConclusion.Controls.Add(Me.Label39)
        Me.gpbxConclusion.Controls.Add(Me.cboRebetType)
        Me.gpbxConclusion.Controls.Add(Me.cboBaoHanType)
        Me.gpbxConclusion.Controls.Add(Me.Label37)
        Me.gpbxConclusion.Controls.Add(Me.txtScaleMoney)
        Me.gpbxConclusion.Controls.Add(Me.Label48)
        Me.gpbxConclusion.Controls.Add(Me.txtGuaranteeScale)
        Me.gpbxConclusion.Controls.Add(Me.Label47)
        Me.gpbxConclusion.Controls.Add(Me.txtReturnRemark)
        Me.gpbxConclusion.Controls.Add(Me.Label17)
        Me.gpbxConclusion.Controls.Add(Me.txtLoanRemark)
        Me.gpbxConclusion.Controls.Add(Me.Label16)
        Me.gpbxConclusion.Controls.Add(Me.txtRateRemark)
        Me.gpbxConclusion.Controls.Add(Me.Label12)
        Me.gpbxConclusion.Controls.Add(Me.Label27)
        Me.gpbxConclusion.Controls.Add(Me.Label26)
        Me.gpbxConclusion.Controls.Add(Me.txtGuarantyFee)
        Me.gpbxConclusion.Controls.Add(Me.lblGuaFeeDescription)
        Me.gpbxConclusion.Controls.Add(Me.txtReviewFee)
        Me.gpbxConclusion.Controls.Add(Me.Label23)
        Me.gpbxConclusion.Controls.Add(Me.txtGuarantyFeeStandard)
        Me.gpbxConclusion.Controls.Add(Me.lblGuaranteeFeeStandDesc)
        Me.gpbxConclusion.Controls.Add(Me.txtReviewFeeStandard)
        Me.gpbxConclusion.Controls.Add(Me.Label20)
        Me.gpbxConclusion.Controls.Add(Me.txtRemark)
        Me.gpbxConclusion.Controls.Add(Me.txtDate)
        Me.gpbxConclusion.Controls.Add(Me.nudTerms)
        Me.gpbxConclusion.Controls.Add(Me.Label21)
        Me.gpbxConclusion.Controls.Add(Me.Label10)
        Me.gpbxConclusion.Controls.Add(Me.cmbxRefundtype)
        Me.gpbxConclusion.Controls.Add(Me.Label15)
        Me.gpbxConclusion.Controls.Add(Me.cmbxLoanForm)
        Me.gpbxConclusion.Controls.Add(Me.Label14)
        Me.gpbxConclusion.Controls.Add(Me.Label13)
        Me.gpbxConclusion.Controls.Add(Me.Label3)
        Me.gpbxConclusion.Controls.Add(Me.Label4)
        Me.gpbxConclusion.Controls.Add(Me.txtTimes)
        Me.gpbxConclusion.Controls.Add(Me.Label5)
        Me.gpbxConclusion.Controls.Add(Me.cmbxServiceType)
        Me.gpbxConclusion.Controls.Add(Me.Label6)
        Me.gpbxConclusion.Controls.Add(Me.cbxFinalDesicion)
        Me.gpbxConclusion.Controls.Add(Me.Label7)
        Me.gpbxConclusion.Controls.Add(Me.cmbxConclusion)
        Me.gpbxConclusion.Controls.Add(Me.lblGuaranSumDescription)
        Me.gpbxConclusion.Controls.Add(Me.lblTermDescription)
        Me.gpbxConclusion.Controls.Add(Me.txtGuarantySum)
        Me.gpbxConclusion.Controls.Add(Me.dtpGuarantStartDate)
        Me.gpbxConclusion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbxConclusion.Location = New System.Drawing.Point(0, 0)
        Me.gpbxConclusion.Name = "gpbxConclusion"
        Me.gpbxConclusion.Size = New System.Drawing.Size(632, 439)
        Me.gpbxConclusion.TabIndex = 33
        Me.gpbxConclusion.TabStop = False
        '
        'dtpGuarantEndDate
        '
        Me.dtpGuarantEndDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpGuarantEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpGuarantEndDate.Location = New System.Drawing.Point(232, 69)
        Me.dtpGuarantEndDate.Name = "dtpGuarantEndDate"
        Me.dtpGuarantEndDate.Size = New System.Drawing.Size(88, 21)
        Me.dtpGuarantEndDate.TabIndex = 103
        Me.dtpGuarantEndDate.Visible = False
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(160, 72)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(29, 17)
        Me.lblMonth.TabIndex = 102
        Me.lblMonth.Text = "(月)"
        '
        'txtEachReturnFee
        '
        Me.txtEachReturnFee.Location = New System.Drawing.Point(432, 149)
        Me.txtEachReturnFee.Name = "txtEachReturnFee"
        Me.txtEachReturnFee.Size = New System.Drawing.Size(176, 21)
        Me.txtEachReturnFee.TabIndex = 100
        Me.txtEachReturnFee.Text = ""
        '
        'cboRunMode
        '
        Me.cboRunMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRunMode.Enabled = False
        Me.cboRunMode.Items.AddRange(New Object() {"单笔保函", "额度项下保函"})
        Me.cboRunMode.Location = New System.Drawing.Point(120, 96)
        Me.cboRunMode.Name = "cboRunMode"
        Me.cboRunMode.Size = New System.Drawing.Size(136, 20)
        Me.cboRunMode.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(16, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 17)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "运  作  方  式"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(320, 205)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(97, 17)
        Me.Label38.TabIndex = 96
        Me.Label38.Text = "偿 付 责 任类型"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(16, 205)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(91, 17)
        Me.Label39.TabIndex = 95
        Me.Label39.Text = "保  函  种  类"
        '
        'cboRebetType
        '
        Me.cboRebetType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRebetType.Enabled = False
        Me.cboRebetType.Location = New System.Drawing.Point(432, 202)
        Me.cboRebetType.Name = "cboRebetType"
        Me.cboRebetType.Size = New System.Drawing.Size(176, 20)
        Me.cboRebetType.TabIndex = 98
        '
        'cboBaoHanType
        '
        Me.cboBaoHanType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBaoHanType.Enabled = False
        Me.cboBaoHanType.Location = New System.Drawing.Point(120, 202)
        Me.cboBaoHanType.Name = "cboBaoHanType"
        Me.cboBaoHanType.Size = New System.Drawing.Size(136, 20)
        Me.cboBaoHanType.TabIndex = 97
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(162, 315)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(11, 17)
        Me.Label37.TabIndex = 94
        Me.Label37.Text = "%"
        '
        'txtScaleMoney
        '
        Me.txtScaleMoney.Location = New System.Drawing.Point(432, 309)
        Me.txtScaleMoney.Name = "txtScaleMoney"
        Me.txtScaleMoney.Size = New System.Drawing.Size(176, 21)
        Me.txtScaleMoney.TabIndex = 93
        Me.txtScaleMoney.Text = ""
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(320, 312)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(97, 17)
        Me.Label48.TabIndex = 92
        Me.Label48.Text = "保 证 金 额(元)"
        '
        'txtGuaranteeScale
        '
        Me.txtGuaranteeScale.Enabled = False
        Me.txtGuaranteeScale.Location = New System.Drawing.Point(120, 309)
        Me.txtGuaranteeScale.Name = "txtGuaranteeScale"
        Me.txtGuaranteeScale.Size = New System.Drawing.Size(40, 21)
        Me.txtGuaranteeScale.TabIndex = 91
        Me.txtGuaranteeScale.Text = ""
        Me.txtGuaranteeScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(16, 312)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(97, 17)
        Me.Label47.TabIndex = 90
        Me.Label47.Text = "保 证 金 比  例"
        '
        'txtReturnRemark
        '
        Me.txtReturnRemark.Enabled = False
        Me.txtReturnRemark.Location = New System.Drawing.Point(120, 175)
        Me.txtReturnRemark.MaxLength = 50
        Me.txtReturnRemark.Name = "txtReturnRemark"
        Me.txtReturnRemark.Size = New System.Drawing.Size(488, 21)
        Me.txtReturnRemark.TabIndex = 8
        Me.txtReturnRemark.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(16, 178)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 17)
        Me.Label17.TabIndex = 85
        Me.Label17.Text = "还  款  说  明"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLoanRemark
        '
        Me.txtLoanRemark.Enabled = False
        Me.txtLoanRemark.Location = New System.Drawing.Point(120, 122)
        Me.txtLoanRemark.MaxLength = 50
        Me.txtLoanRemark.Name = "txtLoanRemark"
        Me.txtLoanRemark.Size = New System.Drawing.Size(488, 21)
        Me.txtLoanRemark.TabIndex = 6
        Me.txtLoanRemark.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(16, 125)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 17)
        Me.Label16.TabIndex = 83
        Me.Label16.Text = "放  款  说  明"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRateRemark
        '
        Me.txtRateRemark.Location = New System.Drawing.Point(120, 282)
        Me.txtRateRemark.MaxLength = 30
        Me.txtRateRemark.Name = "txtRateRemark"
        Me.txtRateRemark.Size = New System.Drawing.Size(488, 21)
        Me.txtRateRemark.TabIndex = 11
        Me.txtRateRemark.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(16, 285)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(97, 17)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "担 保 费 率说明"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(162, 262)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(11, 17)
        Me.Label27.TabIndex = 78
        Me.Label27.Text = "%"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(162, 233)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(11, 17)
        Me.Label26.TabIndex = 77
        Me.Label26.Text = "%"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGuarantyFee
        '
        Me.txtGuarantyFee.Location = New System.Drawing.Point(432, 255)
        Me.txtGuarantyFee.MaxLength = 13
        Me.txtGuarantyFee.Name = "txtGuarantyFee"
        Me.txtGuarantyFee.Size = New System.Drawing.Size(176, 21)
        Me.txtGuarantyFee.TabIndex = 76
        Me.txtGuarantyFee.Text = ""
        '
        'lblGuaFeeDescription
        '
        Me.lblGuaFeeDescription.AutoSize = True
        Me.lblGuaFeeDescription.Location = New System.Drawing.Point(320, 258)
        Me.lblGuaFeeDescription.Name = "lblGuaFeeDescription"
        Me.lblGuaFeeDescription.Size = New System.Drawing.Size(97, 17)
        Me.lblGuaFeeDescription.TabIndex = 75
        Me.lblGuaFeeDescription.Text = "担  保  费 (元)"
        Me.lblGuaFeeDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReviewFee
        '
        Me.txtReviewFee.Location = New System.Drawing.Point(432, 228)
        Me.txtReviewFee.MaxLength = 13
        Me.txtReviewFee.Name = "txtReviewFee"
        Me.txtReviewFee.Size = New System.Drawing.Size(176, 21)
        Me.txtReviewFee.TabIndex = 74
        Me.txtReviewFee.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(320, 231)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(97, 17)
        Me.Label23.TabIndex = 73
        Me.Label23.Text = "评  审  费 (元)"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGuarantyFeeStandard
        '
        Me.txtGuarantyFeeStandard.Enabled = False
        Me.txtGuarantyFeeStandard.Location = New System.Drawing.Point(120, 255)
        Me.txtGuarantyFeeStandard.Name = "txtGuarantyFeeStandard"
        Me.txtGuarantyFeeStandard.Size = New System.Drawing.Size(40, 21)
        Me.txtGuarantyFeeStandard.TabIndex = 10
        Me.txtGuarantyFeeStandard.Text = ""
        Me.txtGuarantyFeeStandard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblGuaranteeFeeStandDesc
        '
        Me.lblGuaranteeFeeStandDesc.AutoSize = True
        Me.lblGuaranteeFeeStandDesc.Location = New System.Drawing.Point(16, 258)
        Me.lblGuaranteeFeeStandDesc.Name = "lblGuaranteeFeeStandDesc"
        Me.lblGuaranteeFeeStandDesc.Size = New System.Drawing.Size(91, 17)
        Me.lblGuaranteeFeeStandDesc.TabIndex = 71
        Me.lblGuaranteeFeeStandDesc.Text = "担保费标准(年)"
        Me.lblGuaranteeFeeStandDesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReviewFeeStandard
        '
        Me.txtReviewFeeStandard.Enabled = False
        Me.txtReviewFeeStandard.Location = New System.Drawing.Point(120, 228)
        Me.txtReviewFeeStandard.Name = "txtReviewFeeStandard"
        Me.txtReviewFeeStandard.Size = New System.Drawing.Size(40, 21)
        Me.txtReviewFeeStandard.TabIndex = 9
        Me.txtReviewFeeStandard.Text = ""
        Me.txtReviewFeeStandard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(16, 231)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(97, 17)
        Me.Label20.TabIndex = 69
        Me.Label20.Text = "评 审 费 标 准 "
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(120, 336)
        Me.txtRemark.MaxLength = 1000
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(488, 79)
        Me.txtRemark.TabIndex = 12
        Me.txtRemark.Text = ""
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.SystemColors.Window
        Me.txtDate.Enabled = False
        Me.txtDate.Location = New System.Drawing.Point(120, 16)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(136, 21)
        Me.txtDate.TabIndex = 67
        Me.txtDate.Text = ""
        '
        'nudTerms
        '
        Me.nudTerms.BackColor = System.Drawing.SystemColors.HighlightText
        Me.nudTerms.Enabled = False
        Me.nudTerms.Location = New System.Drawing.Point(120, 69)
        Me.nudTerms.Name = "nudTerms"
        Me.nudTerms.ReadOnly = True
        Me.nudTerms.Size = New System.Drawing.Size(40, 21)
        Me.nudTerms.TabIndex = 2
        Me.nudTerms.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(104, 112)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 0)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "%"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(320, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 17)
        Me.Label10.TabIndex = 53
        Me.Label10.Text = "每次还款额(元)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbxRefundtype
        '
        Me.cmbxRefundtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxRefundtype.Enabled = False
        Me.cmbxRefundtype.Location = New System.Drawing.Point(120, 149)
        Me.cmbxRefundtype.Name = "cmbxRefundtype"
        Me.cmbxRefundtype.Size = New System.Drawing.Size(136, 20)
        Me.cmbxRefundtype.TabIndex = 7
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 152)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 17)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "还  款  方  式"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbxLoanForm
        '
        Me.cmbxLoanForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxLoanForm.Enabled = False
        Me.cmbxLoanForm.Location = New System.Drawing.Point(432, 96)
        Me.cmbxLoanForm.Name = "cmbxLoanForm"
        Me.cmbxLoanForm.Size = New System.Drawing.Size(178, 20)
        Me.cmbxLoanForm.TabIndex = 5
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(320, 99)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(91, 17)
        Me.Label14.TabIndex = 49
        Me.Label14.Text = "放  款  方  式"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 368)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(85, 17)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "备         注"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "上  会  日  期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(320, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "上  会  次  数"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTimes
        '
        Me.txtTimes.BackColor = System.Drawing.SystemColors.Window
        Me.txtTimes.Enabled = False
        Me.txtTimes.Location = New System.Drawing.Point(432, 16)
        Me.txtTimes.Name = "txtTimes"
        Me.txtTimes.Size = New System.Drawing.Size(40, 21)
        Me.txtTimes.TabIndex = 36
        Me.txtTimes.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 17)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "评审会议 意 见"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbxServiceType
        '
        Me.cmbxServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxServiceType.Enabled = False
        Me.cmbxServiceType.Location = New System.Drawing.Point(432, 43)
        Me.cmbxServiceType.Name = "cmbxServiceType"
        Me.cmbxServiceType.Size = New System.Drawing.Size(176, 20)
        Me.cmbxServiceType.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(504, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "恢复项目状态"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxFinalDesicion
        '
        Me.cbxFinalDesicion.Enabled = False
        Me.cbxFinalDesicion.Location = New System.Drawing.Point(592, 18)
        Me.cbxFinalDesicion.Name = "cbxFinalDesicion"
        Me.cbxFinalDesicion.Size = New System.Drawing.Size(24, 16)
        Me.cbxFinalDesicion.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(320, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 17)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "业  务  品  种"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbxConclusion
        '
        Me.cmbxConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxConclusion.Location = New System.Drawing.Point(120, 43)
        Me.cmbxConclusion.Name = "cmbxConclusion"
        Me.cmbxConclusion.Size = New System.Drawing.Size(135, 20)
        Me.cmbxConclusion.TabIndex = 0
        '
        'lblGuaranSumDescription
        '
        Me.lblGuaranSumDescription.AutoSize = True
        Me.lblGuaranSumDescription.Location = New System.Drawing.Point(320, 72)
        Me.lblGuaranSumDescription.Name = "lblGuaranSumDescription"
        Me.lblGuaranSumDescription.Size = New System.Drawing.Size(91, 17)
        Me.lblGuaranSumDescription.TabIndex = 43
        Me.lblGuaranSumDescription.Text = "担保金额(万元)"
        Me.lblGuaranSumDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTermDescription
        '
        Me.lblTermDescription.AutoSize = True
        Me.lblTermDescription.Location = New System.Drawing.Point(16, 72)
        Me.lblTermDescription.Name = "lblTermDescription"
        Me.lblTermDescription.Size = New System.Drawing.Size(72, 17)
        Me.lblTermDescription.TabIndex = 44
        Me.lblTermDescription.Text = "担 保 期 限"
        Me.lblTermDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGuarantySum
        '
        Me.txtGuarantySum.Location = New System.Drawing.Point(432, 69)
        Me.txtGuarantySum.MaxLength = 14
        Me.txtGuarantySum.Name = "txtGuarantySum"
        Me.txtGuarantySum.Size = New System.Drawing.Size(176, 21)
        Me.txtGuarantySum.TabIndex = 3
        Me.txtGuarantySum.Text = ""
        '
        'dtpGuarantStartDate
        '
        Me.dtpGuarantStartDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpGuarantStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpGuarantStartDate.Location = New System.Drawing.Point(120, 69)
        Me.dtpGuarantStartDate.Name = "dtpGuarantStartDate"
        Me.dtpGuarantStartDate.Size = New System.Drawing.Size(88, 21)
        Me.dtpGuarantStartDate.TabIndex = 101
        Me.dtpGuarantStartDate.Visible = False
        '
        'tpExpConclusion
        '
        Me.tpExpConclusion.Controls.Add(Me.GroupBox5)
        Me.tpExpConclusion.Controls.Add(Me.GroupBox4)
        Me.tpExpConclusion.Location = New System.Drawing.Point(4, 21)
        Me.tpExpConclusion.Name = "tpExpConclusion"
        Me.tpExpConclusion.Size = New System.Drawing.Size(632, 439)
        Me.tpExpConclusion.TabIndex = 6
        Me.tpExpConclusion.Text = "展期评审会结论"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label52)
        Me.GroupBox5.Controls.Add(Me.txtGuarantyFeeExp)
        Me.GroupBox5.Controls.Add(Me.Label53)
        Me.GroupBox5.Controls.Add(Me.txtGuarantyFeeStandardExp)
        Me.GroupBox5.Controls.Add(Me.Label54)
        Me.GroupBox5.Controls.Add(Me.cboConclusion)
        Me.GroupBox5.Controls.Add(Me.Label22)
        Me.GroupBox5.Controls.Add(Me.txtExpandRefundAmount)
        Me.GroupBox5.Controls.Add(Me.Label25)
        Me.GroupBox5.Controls.Add(Me.cboExpandRefundType)
        Me.GroupBox5.Controls.Add(Me.Label44)
        Me.GroupBox5.Controls.Add(Me.Label46)
        Me.GroupBox5.Controls.Add(Me.txtExpandTerm)
        Me.GroupBox5.Controls.Add(Me.txtExpandAmount)
        Me.GroupBox5.Controls.Add(Me.Label49)
        Me.GroupBox5.Location = New System.Drawing.Point(16, 232)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(600, 192)
        Me.GroupBox5.TabIndex = 19
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "展期评审信息"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(152, 160)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(11, 17)
        Me.Label52.TabIndex = 113
        Me.Label52.Text = "%"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGuarantyFeeExp
        '
        Me.txtGuarantyFeeExp.Location = New System.Drawing.Point(424, 152)
        Me.txtGuarantyFeeExp.MaxLength = 13
        Me.txtGuarantyFeeExp.Name = "txtGuarantyFeeExp"
        Me.txtGuarantyFeeExp.Size = New System.Drawing.Size(168, 21)
        Me.txtGuarantyFeeExp.TabIndex = 112
        Me.txtGuarantyFeeExp.Text = "0"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(320, 152)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(97, 17)
        Me.Label53.TabIndex = 111
        Me.Label53.Text = "担  保  费 (元)"
        Me.Label53.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGuarantyFeeStandardExp
        '
        Me.txtGuarantyFeeStandardExp.Location = New System.Drawing.Point(112, 152)
        Me.txtGuarantyFeeStandardExp.Name = "txtGuarantyFeeStandardExp"
        Me.txtGuarantyFeeStandardExp.Size = New System.Drawing.Size(40, 21)
        Me.txtGuarantyFeeStandardExp.TabIndex = 109
        Me.txtGuarantyFeeStandardExp.Text = "0"
        Me.txtGuarantyFeeStandardExp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(16, 152)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(91, 17)
        Me.Label54.TabIndex = 110
        Me.Label54.Text = "担保费标准(年)"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboConclusion
        '
        Me.cboConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConclusion.Location = New System.Drawing.Point(112, 32)
        Me.cboConclusion.Name = "cboConclusion"
        Me.cboConclusion.Size = New System.Drawing.Size(168, 20)
        Me.cboConclusion.TabIndex = 105
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(32, 32)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 17)
        Me.Label22.TabIndex = 106
        Me.Label22.Text = "评审会结论"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExpandRefundAmount
        '
        Me.txtExpandRefundAmount.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpandRefundAmount.Location = New System.Drawing.Point(112, 112)
        Me.txtExpandRefundAmount.Name = "txtExpandRefundAmount"
        Me.txtExpandRefundAmount.Size = New System.Drawing.Size(104, 21)
        Me.txtExpandRefundAmount.TabIndex = 104
        Me.txtExpandRefundAmount.Text = ""
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(16, 112)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(91, 17)
        Me.Label25.TabIndex = 103
        Me.Label25.Text = "每次还款额(元)"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboExpandRefundType
        '
        Me.cboExpandRefundType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExpandRefundType.Enabled = False
        Me.cboExpandRefundType.Location = New System.Drawing.Point(424, 72)
        Me.cboExpandRefundType.Name = "cboExpandRefundType"
        Me.cboExpandRefundType.Size = New System.Drawing.Size(169, 20)
        Me.cboExpandRefundType.TabIndex = 101
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(352, 72)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(54, 17)
        Me.Label44.TabIndex = 102
        Me.Label44.Text = "还款方式"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(24, 72)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(79, 17)
        Me.Label46.TabIndex = 51
        Me.Label46.Text = "展期期限(月)"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExpandTerm
        '
        Me.txtExpandTerm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpandTerm.Location = New System.Drawing.Point(112, 72)
        Me.txtExpandTerm.Name = "txtExpandTerm"
        Me.txtExpandTerm.Size = New System.Drawing.Size(104, 21)
        Me.txtExpandTerm.TabIndex = 50
        Me.txtExpandTerm.Text = ""
        '
        'txtExpandAmount
        '
        Me.txtExpandAmount.Location = New System.Drawing.Point(424, 32)
        Me.txtExpandAmount.Name = "txtExpandAmount"
        Me.txtExpandAmount.Size = New System.Drawing.Size(168, 21)
        Me.txtExpandAmount.TabIndex = 48
        Me.txtExpandAmount.Text = ""
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(320, 32)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(91, 17)
        Me.Label49.TabIndex = 49
        Me.Label49.Text = "展期金额(万元)"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txtExpendApplyReason)
        Me.GroupBox4.Controls.Add(Me.Label45)
        Me.GroupBox4.Controls.Add(Me.txtExpandApplyTerm)
        Me.GroupBox4.Controls.Add(Me.txtExpandApplyAmount)
        Me.GroupBox4.Controls.Add(Me.lblSum)
        Me.GroupBox4.Controls.Add(Me.Label50)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(600, 208)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "展期申请信息"
        '
        'txtExpendApplyReason
        '
        Me.txtExpendApplyReason.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpendApplyReason.Enabled = False
        Me.txtExpendApplyReason.Location = New System.Drawing.Point(104, 56)
        Me.txtExpendApplyReason.Multiline = True
        Me.txtExpendApplyReason.Name = "txtExpendApplyReason"
        Me.txtExpendApplyReason.Size = New System.Drawing.Size(472, 136)
        Me.txtExpendApplyReason.TabIndex = 49
        Me.txtExpendApplyReason.Text = ""
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(288, 24)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(79, 17)
        Me.Label45.TabIndex = 47
        Me.Label45.Text = "展期期限(月)"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExpandApplyTerm
        '
        Me.txtExpandApplyTerm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpandApplyTerm.Enabled = False
        Me.txtExpandApplyTerm.Location = New System.Drawing.Point(376, 24)
        Me.txtExpandApplyTerm.Name = "txtExpandApplyTerm"
        Me.txtExpandApplyTerm.Size = New System.Drawing.Size(200, 21)
        Me.txtExpandApplyTerm.TabIndex = 46
        Me.txtExpandApplyTerm.Text = ""
        '
        'txtExpandApplyAmount
        '
        Me.txtExpandApplyAmount.Enabled = False
        Me.txtExpandApplyAmount.Location = New System.Drawing.Point(104, 24)
        Me.txtExpandApplyAmount.Name = "txtExpandApplyAmount"
        Me.txtExpandApplyAmount.Size = New System.Drawing.Size(168, 21)
        Me.txtExpandApplyAmount.TabIndex = 37
        Me.txtExpandApplyAmount.Text = ""
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(8, 24)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(91, 17)
        Me.lblSum.TabIndex = 40
        Me.lblSum.Text = "展期金额(万元)"
        Me.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label50
        '
        Me.Label50.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(40, 64)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(54, 17)
        Me.Label50.TabIndex = 38
        Me.Label50.Text = "展期原因"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tpOppGua
        '
        Me.tpOppGua.Controls.Add(Me.dgDetail)
        Me.tpOppGua.Controls.Add(Me.gpxAdditionalForm)
        Me.tpOppGua.Controls.Add(Me.Splitter1)
        Me.tpOppGua.Controls.Add(Me.gpbxOppGua)
        Me.tpOppGua.Location = New System.Drawing.Point(4, 21)
        Me.tpOppGua.Name = "tpOppGua"
        Me.tpOppGua.Size = New System.Drawing.Size(632, 439)
        Me.tpOppGua.TabIndex = 3
        Me.tpOppGua.Text = "反担保措施"
        '
        'dgDetail
        '
        Me.dgDetail.CaptionVisible = False
        Me.dgDetail.DataMember = ""
        Me.dgDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDetail.Location = New System.Drawing.Point(0, 291)
        Me.dgDetail.Name = "dgDetail"
        Me.dgDetail.Size = New System.Drawing.Size(632, 148)
        Me.dgDetail.TabIndex = 4
        '
        'gpxAdditionalForm
        '
        Me.gpxAdditionalForm.Controls.Add(Me.cklbxAdditionalForm)
        Me.gpxAdditionalForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpxAdditionalForm.Location = New System.Drawing.Point(0, 211)
        Me.gpxAdditionalForm.Name = "gpxAdditionalForm"
        Me.gpxAdditionalForm.Size = New System.Drawing.Size(632, 80)
        Me.gpxAdditionalForm.TabIndex = 3
        Me.gpxAdditionalForm.TabStop = False
        Me.gpxAdditionalForm.Text = "附加反担保物措施"
        '
        'cklbxAdditionalForm
        '
        Me.cklbxAdditionalForm.CheckOnClick = True
        Me.cklbxAdditionalForm.ColumnWidth = 180
        Me.cklbxAdditionalForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cklbxAdditionalForm.Location = New System.Drawing.Point(3, 17)
        Me.cklbxAdditionalForm.MultiColumn = True
        Me.cklbxAdditionalForm.Name = "cklbxAdditionalForm"
        Me.cklbxAdditionalForm.Size = New System.Drawing.Size(626, 60)
        Me.cklbxAdditionalForm.TabIndex = 2
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(0, 208)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(632, 3)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'gpbxOppGua
        '
        Me.gpbxOppGua.Controls.Add(Me.dgOppGua)
        Me.gpbxOppGua.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpbxOppGua.Location = New System.Drawing.Point(0, 0)
        Me.gpbxOppGua.Name = "gpbxOppGua"
        Me.gpbxOppGua.Size = New System.Drawing.Size(632, 208)
        Me.gpbxOppGua.TabIndex = 1
        Me.gpbxOppGua.TabStop = False
        Me.gpbxOppGua.Text = "独立反担保措施"
        '
        'dgOppGua
        '
        Me.dgOppGua.CaptionVisible = False
        Me.dgOppGua.DataMember = ""
        Me.dgOppGua.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOppGua.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgOppGua.Location = New System.Drawing.Point(3, 17)
        Me.dgOppGua.Name = "dgOppGua"
        Me.dgOppGua.Size = New System.Drawing.Size(626, 188)
        Me.dgOppGua.TabIndex = 1
        '
        'tpOtherInfo
        '
        Me.tpOtherInfo.Controls.Add(Me.gpxReGuarantee)
        Me.tpOtherInfo.Controls.Add(Me.gpxBaoHan)
        Me.tpOtherInfo.Location = New System.Drawing.Point(4, 21)
        Me.tpOtherInfo.Name = "tpOtherInfo"
        Me.tpOtherInfo.Size = New System.Drawing.Size(632, 439)
        Me.tpOtherInfo.TabIndex = 5
        Me.tpOtherInfo.Tag = "保函"
        Me.tpOtherInfo.Text = "其它信息"
        '
        'gpxReGuarantee
        '
        Me.gpxReGuarantee.Controls.Add(Me.txtSourceTerms)
        Me.gpxReGuarantee.Controls.Add(Me.txtSourceGS)
        Me.gpxReGuarantee.Controls.Add(Me.txtSourceST)
        Me.gpxReGuarantee.Controls.Add(Me.txtReGuaranteeCondition)
        Me.gpxReGuarantee.Controls.Add(Me.Label43)
        Me.gpxReGuarantee.Controls.Add(Me.txtReOrganizationName)
        Me.gpxReGuarantee.Controls.Add(Me.Label42)
        Me.gpxReGuarantee.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gpxReGuarantee.Location = New System.Drawing.Point(0, 335)
        Me.gpxReGuarantee.Name = "gpxReGuarantee"
        Me.gpxReGuarantee.Size = New System.Drawing.Size(632, 104)
        Me.gpxReGuarantee.TabIndex = 18
        Me.gpxReGuarantee.TabStop = False
        Me.gpxReGuarantee.Text = "再担保信息"
        '
        'txtSourceTerms
        '
        Me.txtSourceTerms.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSourceTerms.DefaultValue = CType(resources.GetObject("txtSourceTerms.DefaultValue"), Object)
        Me.txtSourceTerms.LabelText = "贷款(申请)期限(月)"
        Me.txtSourceTerms.LabelWidth = 116
        Me.txtSourceTerms.Location = New System.Drawing.Point(408, 40)
        Me.txtSourceTerms.MaxLength = 32767
        Me.txtSourceTerms.Name = "txtSourceTerms"
        Me.txtSourceTerms.ReadOnly = True
        Me.txtSourceTerms.Size = New System.Drawing.Size(216, 21)
        Me.txtSourceTerms.TabIndex = 6
        Me.txtSourceTerms.Value = CType(resources.GetObject("txtSourceTerms.Value"), Object)
        '
        'txtSourceGS
        '
        Me.txtSourceGS.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSourceGS.DefaultValue = CType(resources.GetObject("txtSourceGS.DefaultValue"), Object)
        Me.txtSourceGS.LabelText = "贷款金额(万元)"
        Me.txtSourceGS.LabelWidth = 91
        Me.txtSourceGS.Location = New System.Drawing.Point(8, 40)
        Me.txtSourceGS.MaxLength = 32767
        Me.txtSourceGS.Name = "txtSourceGS"
        Me.txtSourceGS.ReadOnly = True
        Me.txtSourceGS.Size = New System.Drawing.Size(368, 21)
        Me.txtSourceGS.TabIndex = 5
        Me.txtSourceGS.Value = CType(resources.GetObject("txtSourceGS.Value"), Object)
        '
        'txtSourceST
        '
        Me.txtSourceST.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSourceST.DefaultValue = CType(resources.GetObject("txtSourceST.DefaultValue"), Object)
        Me.txtSourceST.LabelText = "贷 款 业 务 品 种 "
        Me.txtSourceST.LabelWidth = 116
        Me.txtSourceST.Location = New System.Drawing.Point(408, 14)
        Me.txtSourceST.MaxLength = 32767
        Me.txtSourceST.Name = "txtSourceST"
        Me.txtSourceST.ReadOnly = True
        Me.txtSourceST.Size = New System.Drawing.Size(216, 21)
        Me.txtSourceST.TabIndex = 4
        Me.txtSourceST.Value = CType(resources.GetObject("txtSourceST.Value"), Object)
        '
        'txtReGuaranteeCondition
        '
        Me.txtReGuaranteeCondition.BackColor = System.Drawing.Color.Gainsboro
        Me.txtReGuaranteeCondition.Location = New System.Drawing.Point(99, 64)
        Me.txtReGuaranteeCondition.Multiline = True
        Me.txtReGuaranteeCondition.Name = "txtReGuaranteeCondition"
        Me.txtReGuaranteeCondition.ReadOnly = True
        Me.txtReGuaranteeCondition.Size = New System.Drawing.Size(528, 32)
        Me.txtReGuaranteeCondition.TabIndex = 3
        Me.txtReGuaranteeCondition.Text = ""
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(8, 73)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(85, 17)
        Me.Label43.TabIndex = 2
        Me.Label43.Text = "再 担 保 条件"
        '
        'txtReOrganizationName
        '
        Me.txtReOrganizationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtReOrganizationName.Location = New System.Drawing.Point(99, 14)
        Me.txtReOrganizationName.Name = "txtReOrganizationName"
        Me.txtReOrganizationName.ReadOnly = True
        Me.txtReOrganizationName.Size = New System.Drawing.Size(280, 21)
        Me.txtReOrganizationName.TabIndex = 1
        Me.txtReOrganizationName.Text = ""
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(8, 21)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(79, 17)
        Me.Label42.TabIndex = 0
        Me.Label42.Text = "担保机构名称"
        '
        'gpxBaoHan
        '
        Me.gpxBaoHan.Controls.Add(Me.btnNew)
        Me.gpxBaoHan.Controls.Add(Me.GroupBox2)
        Me.gpxBaoHan.Controls.Add(Me.GroupBox1)
        Me.gpxBaoHan.Controls.Add(Me.btnDelete)
        Me.gpxBaoHan.Controls.Add(Me.gpbDownLetter)
        Me.gpxBaoHan.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpxBaoHan.Location = New System.Drawing.Point(0, 0)
        Me.gpxBaoHan.Name = "gpxBaoHan"
        Me.gpxBaoHan.Size = New System.Drawing.Size(632, 304)
        Me.gpxBaoHan.TabIndex = 17
        Me.gpxBaoHan.TabStop = False
        Me.gpxBaoHan.Text = "保函信息"
        '
        'btnNew
        '
        Me.btnNew.Enabled = False
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 13
        Me.btnNew.ImageList = Me.ImageListBasic
        Me.btnNew.Location = New System.Drawing.Point(440, 184)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 23)
        Me.btnNew.TabIndex = 11
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Label41)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.cboLetterBank)
        Me.GroupBox2.Controls.Add(Me.cboLetterSubBank)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 208)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(616, 40)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "银行信息"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(280, 16)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(85, 17)
        Me.Label41.TabIndex = 14
        Me.Label41.Text = "出  函 支  行"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(8, 16)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(72, 17)
        Me.Label40.TabIndex = 12
        Me.Label40.Text = "出 函 银 行"
        '
        'cboLetterBank
        '
        Me.cboLetterBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLetterBank.Enabled = False
        Me.cboLetterBank.Location = New System.Drawing.Point(88, 13)
        Me.cboLetterBank.Name = "cboLetterBank"
        Me.cboLetterBank.Size = New System.Drawing.Size(152, 20)
        Me.cboLetterBank.TabIndex = 13
        '
        'cboLetterSubBank
        '
        Me.cboLetterSubBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLetterSubBank.Enabled = False
        Me.cboLetterSubBank.Location = New System.Drawing.Point(376, 13)
        Me.cboLetterSubBank.Name = "cboLetterSubBank"
        Me.cboLetterSubBank.Size = New System.Drawing.Size(184, 20)
        Me.cboLetterSubBank.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgIntegrate)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 160)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "综合授信"
        '
        'dgIntegrate
        '
        Me.dgIntegrate.CaptionVisible = False
        Me.dgIntegrate.DataMember = ""
        Me.dgIntegrate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgIntegrate.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgIntegrate.Location = New System.Drawing.Point(3, 17)
        Me.dgIntegrate.Name = "dgIntegrate"
        Me.dgIntegrate.Size = New System.Drawing.Size(610, 140)
        Me.dgIntegrate.TabIndex = 0
        '
        'btnDelete
        '
        Me.btnDelete.Enabled = False
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 25
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(528, 184)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpbDownLetter
        '
        Me.gpbDownLetter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpbDownLetter.Controls.Add(Me.txtRemainLetter)
        Me.gpbDownLetter.Controls.Add(Me.Label28)
        Me.gpbDownLetter.Controls.Add(Me.txtEndDateLetter)
        Me.gpbDownLetter.Controls.Add(Me.Label11)
        Me.gpbDownLetter.Location = New System.Drawing.Point(8, 255)
        Me.gpbDownLetter.Name = "gpbDownLetter"
        Me.gpbDownLetter.Size = New System.Drawing.Size(616, 40)
        Me.gpbDownLetter.TabIndex = 9
        Me.gpbDownLetter.TabStop = False
        Me.gpbDownLetter.Text = "额度项下保函"
        '
        'txtRemainLetter
        '
        Me.txtRemainLetter.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRemainLetter.Location = New System.Drawing.Point(88, 13)
        Me.txtRemainLetter.Name = "txtRemainLetter"
        Me.txtRemainLetter.ReadOnly = True
        Me.txtRemainLetter.TabIndex = 8
        Me.txtRemainLetter.Text = ""
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(8, 19)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(72, 17)
        Me.Label28.TabIndex = 7
        Me.Label28.Tag = ""
        Me.Label28.Text = "剩 余 额 度"
        '
        'txtEndDateLetter
        '
        Me.txtEndDateLetter.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEndDateLetter.Location = New System.Drawing.Point(376, 13)
        Me.txtEndDateLetter.Name = "txtEndDateLetter"
        Me.txtEndDateLetter.ReadOnly = True
        Me.txtEndDateLetter.TabIndex = 4
        Me.txtEndDateLetter.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(280, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "额 度 到 期 日"
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(240, 6)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(240, 21)
        Me.txtCorName.TabIndex = 39
        Me.txtCorName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(64, 6)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 38
        Me.txtProjectCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(176, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "企业名称"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "项目编码"
        '
        'btnPrintReport
        '
        Me.btnPrintReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPrintReport.Enabled = False
        Me.btnPrintReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrintReport.ImageIndex = 18
        Me.btnPrintReport.ImageList = Me.ImageListBasic
        Me.btnPrintReport.Location = New System.Drawing.Point(474, 504)
        Me.btnPrintReport.Name = "btnPrintReport"
        Me.btnPrintReport.Size = New System.Drawing.Size(104, 23)
        Me.btnPrintReport.TabIndex = 44
        Me.btnPrintReport.Text = "评审意见表(&P)"
        Me.btnPrintReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(227, 504)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(70, 23)
        Me.btnSave.TabIndex = 41
        Me.btnSave.Text = "保存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDetailInfo
        '
        Me.btnDetailInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDetailInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetailInfo.ImageIndex = 3
        Me.btnDetailInfo.ImageList = Me.ImageListBasic
        Me.btnDetailInfo.Location = New System.Drawing.Point(131, 504)
        Me.btnDetailInfo.Name = "btnDetailInfo"
        Me.btnDetailInfo.Size = New System.Drawing.Size(93, 23)
        Me.btnDetailInfo.TabIndex = 40
        Me.btnDetailInfo.Text = "项目信息(&L)"
        Me.btnDetailInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnJoinReport
        '
        Me.btnJoinReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnJoinReport.Enabled = False
        Me.btnJoinReport.Location = New System.Drawing.Point(210, 552)
        Me.btnJoinReport.Name = "btnJoinReport"
        Me.btnJoinReport.Size = New System.Drawing.Size(96, 23)
        Me.btnJoinReport.TabIndex = 42
        Me.btnJoinReport.Text = "项目审批表(&O)"
        Me.btnJoinReport.Visible = False
        '
        'btnSplitProject
        '
        Me.btnSplitProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSplitProject.Enabled = False
        Me.btnSplitProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSplitProject.ImageIndex = 7
        Me.btnSplitProject.ImageList = Me.ImageListBasic
        Me.btnSplitProject.Location = New System.Drawing.Point(300, 504)
        Me.btnSplitProject.Name = "btnSplitProject"
        Me.btnSplitProject.Size = New System.Drawing.Size(93, 23)
        Me.btnSplitProject.TabIndex = 43
        Me.btnSplitProject.Text = "拆分项目(&K)"
        Me.btnSplitProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSupplyOppGua
        '
        Me.btnSupplyOppGua.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSupplyOppGua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSupplyOppGua.ImageIndex = 6
        Me.btnSupplyOppGua.ImageList = Me.ImageListBasic
        Me.btnSupplyOppGua.Location = New System.Drawing.Point(0, 504)
        Me.btnSupplyOppGua.Name = "btnSupplyOppGua"
        Me.btnSupplyOppGua.Size = New System.Drawing.Size(128, 23)
        Me.btnSupplyOppGua.TabIndex = 47
        Me.btnSupplyOppGua.Text = "补充反担保措施(&S)"
        Me.btnSupplyOppGua.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmMeetingRecordExp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(658, 535)
        Me.Controls.Add(Me.btnSupplyOppGua)
        Me.Controls.Add(Me.btnSplitProject)
        Me.Controls.Add(Me.btnJoinReport)
        Me.Controls.Add(Me.btnDetailInfo)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnPrintReport)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProjectCode)
        Me.Controls.Add(Me.txtCorName)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMeetingRecordExp"
        Me.Text = "记录评审会评审结论"
        Me.Controls.SetChildIndex(Me.txtCorName, 0)
        Me.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.TabControl, 0)
        Me.Controls.SetChildIndex(Me.btnPrintReport, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnDetailInfo, 0)
        Me.Controls.SetChildIndex(Me.btnJoinReport, 0)
        Me.Controls.SetChildIndex(Me.btnSplitProject, 0)
        Me.Controls.SetChildIndex(Me.btnSupplyOppGua, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.TabControl.ResumeLayout(False)
        Me.tpInfo.ResumeLayout(False)
        Me.gpbxInfo.ResumeLayout(False)
        Me.tpOpinion.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgOpinion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpConclusion.ResumeLayout(False)
        Me.gpbxConclusion.ResumeLayout(False)
        CType(Me.nudTerms, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpExpConclusion.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.tpOppGua.ResumeLayout(False)
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpxAdditionalForm.ResumeLayout(False)
        Me.gpbxOppGua.ResumeLayout(False)
        CType(Me.dgOppGua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpOtherInfo.ResumeLayout(False)
        Me.gpxReGuarantee.ResumeLayout(False)
        Me.gpxBaoHan.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgIntegrate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbDownLetter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Const RecordTaskID As String = "RecordReviewConclusion" '由于继承类会覆盖taskid，没有办法只能明码写记录会议评审结论得TaskID
    Private Const denyText As String = "否" '表示否定，否决
    Private Const passText As String = "通" '表示通过，评审通过
    Private DataChanged As Boolean = False
    Private MaxMoney As Double = 1000000000
    Protected ProjectCode, CorporationName, WorkFlowID, TaskID As String
    Private dsConferenceTrial As DataSet
    Private TrialTimes As Integer   '获得最近一次会议的审核次数
    Private bmOpinion As BindingManagerBase
    Private bmConclusion As BindingManagerBase
    Public ConCode As Integer = -1  '评审会议编码
    Protected SystemDate As DateTime
    Private item_type, item_code As String
    Private HasRecorded As Boolean = False
    Private dsConference As DataSet
    Private dsConCopy As DataSet '如果没有项目评委，则返回会议评委的copy表
    Private MainDelegate As String  '项目主评    
    '''以下几个数据集为打印报表服务

    Private dsProInfo As DataSet
    Private htMeeting As Hashtable  '项目评审意见表的哈希表
    Private htJoin As Hashtable    '项目审批表(会签报告)的哈希表
    Private dsGuaranty As DataSet  '反担保物

    Private htDeny As Hashtable ' 否定意见表的哈希表
    Private dsBureau As DataSet '合作区及其意见
    Private bmBureau As BindingManagerBase
    Private dsGuaForm As DataSet
    Private dsGuaSubmit As DataSet
    Private IsComeFromMeetQuery As Boolean = False    '是否从会议查询进来的
    Private isSplitProject As Boolean = False       '是否是拆分项目 2003-11-18增加
    Private ParentProjectCode As String '如果是项目拆分，表示父项目的项目编码
    Private dsCor, dsPro, dsArea, dsServiceType, dsBank, dsSubBank, dsRefundType As DataSet
    Private bmCor, bmPro As BindingManagerBase


    Private dsAccountDetail As DataSet '项目的评审费，担保费，保证金
    Private Const GuaFeeItemType As String = "31" '担保费
    Private Const GuaFeeItemCode As String = "002" '担保费
    Private Const RevFeeItemType As String = "31" '评审费
    Private Const RevFeeItemCode As String = "001" '评审费
    Private Const SecFeeItemType As String = "34" '保证金
    Private Const SecFeeItemCode As String = "009" '保证金

    Private Sub BindDataOfBasicInfo()
        dsPro = gWs.GetProjectInfo("{project_code LIKE '" & ProjectCode & "'}")
        bmPro = BindingContext(dsPro, "project")
        Dim CorCode As String
        CorCode = dsPro.Tables(0).Rows(0)("corporation_code").ToString
        dsCor = gWs.GetcorporationInfo("{corporation_code LIKE '" & CorCode & "'}", "null")
        bmCor = BindingContext(dsCor, "corporation")
        txtNewName.DataBindings.Add("Text", dsCor, "corporation.corporation_name")
        dsArea = gWs.GetDistrict("%")
        dsServiceType = gWs.GetServiceType("%")
        'dsBank = gWs.GetBankInfo("{0=0 ORDER BY bank_name}", "%")        '"bank"   "bank_branch"
        'qxd modify 2005-10-21 通过存储实现了按名称升序排序
        dsBank = gWs.GetBankInfo("%", "%")
        Dim dr As DataRow
        cmbxApplyBank.DataSource = dsBank.Tables("bank")
        cmbxApplyBank.DisplayMember = "bank_name"
        cmbxApplyBank.ValueMember = "bank_code"
        AddHandler cmbxApplyBank.SelectedValueChanged, AddressOf BankChanged

        '企业所在区域
        'cmbxArea.Items.Add(String.Empty)
        'For Each dr In dsArea.Tables("TDistrict").Rows
        '    cmbxArea.Items.Add(dr("district_name"))
        'Next
        cmbxArea.DataSource = dsArea.Tables("TDistrict")
        cmbxArea.DisplayMember = "district_name"
        cmbxArea.ValueMember = "district_name"
        '项目申请业务品种
        'cmbxApplyServiceType.Items.Add(String.Empty)
        'For Each dr In dsServiceType.Tables("TServiceType").Rows
        '    cmbxApplyServiceType.Items.Add(dr("service_type"))
        'Next
        cmbxApplyServiceType.DataSource = dsServiceType.Tables("TServiceType")
        cmbxApplyServiceType.DisplayMember = "service_type"
        cmbxApplyServiceType.ValueMember = "service_type"

        cmbxArea.DataBindings.Add("SelectedValue", dsCor, "corporation.district_name")
        cmbxApplyServiceType.DataBindings.Add("SelectedValue", dsPro, "project.apply_service_type")
        Dim dateTimebinding As Binding = New Binding("Text", dsPro, "project.apply_date")
        AddHandler dateTimebinding.Format, AddressOf DateTimeFormat
        txtApplyDate.DataBindings.Add(dateTimebinding)
        dateTimebinding = Nothing
        txtApplySum.DataBindings.Add("Text", dsPro, "project.apply_sum")
        txtApplyTerms.DataBindings.Add("Text", dsPro, "project.apply_term")
        cmbxApplyBank.DataBindings.Add("SelectedValue", dsPro, "project.apply_bank")
        BankChanged(Nothing, Nothing)
        '''''合作区局'''''''''
        Dim dsPartner As DataSet = gWs.GetCooperateOrganization("%")
        'cboPartner.Items.Add(String.Empty)
        For Each dr In dsPartner.Tables(0).Rows
            cboPartner.Items.Add(dr("cooperate_organization"))
        Next
        dsBureau = gWs.GetCooperateOpinionInfo("null", "{project_code LIKE '" & ProjectCode & "'}")
        bmBureau = BindingContext(dsBureau, "cooperate_organization_opinion")
        BindInfoOfPartner()
        chkPartner.Checked = bmBureau.Count > 0
    End Sub

    Private Sub DateTimeFormat(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If Not IsDBNull(e.Value) Then
            e.Value = String.Format("{0:yyyy年M月d日}", e.Value)
        End If
    End Sub

    Private Sub BankChanged(ByVal sender As Object, ByVal e As EventArgs)
        If cmbxApplyBank.SelectedIndex < 0 Then Return
        dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code LIKE '" & cmbxApplyBank.SelectedValue & "'"
        dsBank.Tables("bank_branch").DefaultView.Sort = "branch_bank_name"
        cmbxSubBank.DataSource = dsBank.Tables("bank_branch").DefaultView
        If cmbxSubBank.DisplayMember = String.Empty Then
            cmbxSubBank.DisplayMember = "branch_bank_name"
            cmbxSubBank.ValueMember = "branch_bank_code"
            cmbxSubBank.SelectedValue = dsPro.Tables(0).Rows(0)("apply_branch_bank")
        End If
    End Sub

    Private Sub GetDataSource()
        dsConferenceTrial = New DataSet
        If ConCode < 0 Then
            Dim dsConTrialTemp As DataSet
            dsConTrialTemp = gWs.GetConfTrialInfo("{project_code LIKE '" & ProjectCode & "' AND (NOT (conference_code IS NULL)) ORDER BY trial_times DESC}", "null")
            With dsConTrialTemp.Tables("conference_trial")
                If .Rows.Count = 0 Then
                    SWDialogBox.MessageBox.Show("$X012")
                    'MessageBox.Show("该项目没有会议评审记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim obj As Control
                    For Each obj In Controls
                        obj.Enabled = False
                    Next
                    btnExit.Enabled = True
                    Return
                End If
                ConCode = CInt(.Rows(0).Item("conference_code"))
            End With
            dsConferenceTrial = gWs.GetConfTrialInfo("{(project_code LIKE '" & ProjectCode & "' AND conference_code=" & ConCode & ")}", "null")
        Else '通过会议查询进来的
            dsConferenceTrial = gWs.GetConfTrialInfo("{(project_code LIKE '" & ProjectCode & "' AND conference_code=" & ConCode & ")}", "null")
            IsComeFromMeetQuery = True
        End If

        With dsConferenceTrial.Tables("conference_trial")
            TrialTimes = CInt(.Rows(0)("trial_times"))
            HasRecorded = CBool(.Rows(0)("status"))
            MainDelegate = .Rows(0)("prime_committeeman") & String.Empty
        End With
        dsConferenceTrial.Tables.Remove(dsConferenceTrial.Tables("committeeman_opinion"))
        dsConferenceTrial.Merge(gWs.GetConfTrialInfo("null", "{project_code LIKE '" & ProjectCode & "' AND trial_times=" & TrialTimes & "}").Tables("committeeman_opinion"))

        dsConference = gWs.GetConferenceInfo("{conference_code=" & ConCode & "}", "{conference_code=" & ConCode & "}")
        txtDate.Text = dsConference.Tables("conference").Rows(0)("conference_date") & ""
        '如果已有项目评委，则返回dsConferenceTrial.Tables("committeeman_opinion")
        '否则返回dsConference.Tables("conference_committeeman")
        If dsConferenceTrial.Tables("committeeman_opinion").Rows.Count = 0 Then
            dsConCopy = New DataSet    '会议表的copy
            dsConCopy.Merge(dsConference.Tables("conference_committeeman"))
            dsConCopy.Tables("conference_committeeman").Columns.Add("RoleName", GetType(String), "IIf(committeeman LIKE '" & MainDelegate & "', '主评', '评委')")
            dsConCopy.Tables("conference_committeeman").Columns.Add("opinion", GetType(String))
            txtOpinion.DataBindings.Add(New Binding("Text", dsConCopy, "conference_committeeman.Opinion"))
            bmOpinion = BindingContext(dsConCopy, "conference_committeeman")
            dgOpinion.DataMember = "conference_committeeman"
            dgOpinion.DataSource = dsConCopy
            addTableStyleForOpinion("conference_committeeman")
        Else
            txtOpinion.DataBindings.Add(New Binding("Text", dsConferenceTrial, "committeeman_opinion.Opinion"))
            dsConferenceTrial.Tables("committeeman_opinion").Columns.Add("RoleName", GetType(String), "IIf(role_id LIKE '28', '主评', '评委')")
            bmOpinion = BindingContext(dsConferenceTrial, "committeeman_opinion")
            dgOpinion.DataMember = "committeeman_opinion"
            dgOpinion.DataSource = dsConferenceTrial
            addTableStyleForOpinion("committeeman_opinion")
        End If
        Dim view As DataView = CType(CType(Me.BindingContext(dgOpinion.DataSource, dgOpinion.DataMember), CurrencyManager).List, DataView)
        view.AllowDelete = False
        view.AllowNew = False

        dsAccountDetail = gWs.GetProjectAccountDetailInfo("{project_code LIKE '" & ProjectCode & "' AND item_type IN ('" & GuaFeeItemType & "', '" & SecFeeItemType & "') AND income IS NULL}")
        'dsGuaranteeFee = gWs.GetProjectAccountDetailInfo("{project_code LIKE '" & ProjectCode & "' AND item_type='31' AND item_code='002' AND phase='评审' AND payout IS NOT NULL}")
        If dsAccountDetail.Tables(0).Rows.Count > 0 Then
            dsAccountDetail.Tables(0).DefaultView.RowFilter = "item_type='" & GuaFeeItemType & "' AND item_code='" & GuaFeeItemCode & "'"
            If dsAccountDetail.Tables(0).DefaultView.Count > 0 Then
                txtRateRemark.Text = dsAccountDetail.Tables(0).DefaultView(0)("remark") & ""
            End If
        End If
    End Sub

    Private Sub frmMeetingRecordExp_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

        If ProjectCode Is Nothing Then
            TaskID = MyBase.getTaskID
            WorkFlowID = MyBase.getWorkFlowID
            ProjectCode = MyBase.getProjectCode
            CorporationName = MyBase.getCorporationName
        End If
        txtProjectCode.Text = ProjectCode : txtCorName.Text = CorporationName
        AddHandler btnCommit.Click, AddressOf btnCommit_Click

        '2007-12-5 yjf add 将本项目的展期上会记录删除
        Dim dsTempConferenceTrial As DataSet = gWs.GetConfTrialInfo("{project_code='" & Me.ProjectCode & "' and isnull(is_exp,0)=1}", "null")
        Dim i As Integer
        For i = 0 To dsTempConferenceTrial.Tables(0).Rows.Count - 1
            dsTempConferenceTrial.Tables(0).Rows(i).Delete()
        Next
        gWs.UpdateConfTrial(dsTempConferenceTrial)


        Try
            Me.Cursor = Cursors.WaitCursor
            SystemDate = gWs.GetSysTime
            GetDataSource()
            If Not TabControl.Enabled Then
                Return
            End If
            GetDataSourceOfOppGua()
            txtMeetCount.DataBindings.Add(New Binding("Text", dsConferenceTrial, "conference_trial.trial_times"))
            BindDataOfBasicInfo()  '绑定基本信息
            Dim dsConclusion As DataSet '绑定评审会议意见
            If Me.isSplitProject Then
                Dim result As String = gWs.SplitPrjoect(Me.ParentProjectCode, Me.ProjectCode)
                If result <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "拆分项目工作流失败", result, "")
                    Return
                End If
            End If
            dsConclusion = gWs.GetTransCondition(WorkFlowID, ProjectCode, RecordTaskID)
            cmbxConclusion.DataSource = dsConclusion.Tables(0) '.Tables("project_task_transfer") 这里已修改
            cmbxConclusion.DisplayMember = "transfer_condition"
            cmbxConclusion.ValueMember = "transfer_condition"
            Dim dsServiceTypeCopy As DataSet = New DataSet
            dsServiceTypeCopy = dsServiceType.Copy
            cmbxServiceType.DataSource = dsServiceTypeCopy.Tables(0)
            cmbxServiceType.DisplayMember = "service_type"
            cmbxServiceType.ValueMember = "service_type"
            Dim dsLoanForm As DataSet = New DataSet   '绑定放款方式
            dsLoanForm = gWs.GetLoanProvideForm("%")
            cmbxLoanForm.DataSource = dsLoanForm.Tables(0)
            cmbxLoanForm.DisplayMember = "loan_provide_form"
            cmbxLoanForm.ValueMember = "loan_provide_form"
            Dim dsRefundType As DataSet = New DataSet   '绑定还款方式
            dsRefundType = gWs.GetRefundType("%")
            cmbxRefundtype.DataSource = dsRefundType.Tables(0)
            cmbxRefundtype.DisplayMember = "refund_type"
            cmbxRefundtype.ValueMember = "refund_type"

            '出函银行
            If dsBankCopy Is Nothing Then
                dsBankCopy = New DataSet
                dsBankCopy = dsBank.Copy
            End If
            If cboLetterBank.DataSource Is Nothing Then '出函银行
                cboLetterBank.DataSource = New DataView(dsBankCopy.Tables("bank"))
                cboLetterBank.DisplayMember = "bank_name"
                cboLetterBank.ValueMember = "bank_code"
            End If
            bmConclusion = BindingContext(dsConferenceTrial, "conference_trial")
            ManageBindingForConclusion()  '加绑  
            btnJoinReport.Enabled = True

            TabControl.SelectedTab = tpConclusion '起始页为会议结论页
            cmbxConclusion.SelectedValue = dsConferenceTrial.Tables("conference_trial").Rows(0)("trial_conclusion")
            nudTerms.Value = MyIIf(dsConferenceTrial.Tables("conference_trial").Rows(0)("terms"), GetType(Integer), 12)
            cmbxConclusion_Selection(Nothing, Nothing)
            If IsComeFromMeetQuery And HasRecorded Then

                SWDialogBox.MessageBox.Show("$X031")
                'MessageBox.Show("该项目会议评审结论已提交", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim obj As Control
                For Each obj In Controls
                    obj.Enabled = obj.GetType Is GetType(TabControl)
                Next
                For Each obj In GroupBox3.Controls
                    obj.Enabled = obj.GetType Is GetType(Label)
                Next
                For Each obj In gpbxConclusion.Controls
                    obj.Enabled = obj.GetType Is GetType(Label)
                Next
                For Each obj In gpbxInfo.Controls
                    obj.Enabled = obj.GetType Is GetType(Label)
                Next
                btnExit.Enabled = True : btnDetailInfo.Enabled = True : btnJoinReport.Enabled = True

                If Not IsDBNull(dsConferenceTrial.Tables("conference_trial").Rows(0)("terms")) Then
                    nudTerms.DataBindings.Add(New Binding("Value", dsConferenceTrial, "conference_trial.terms"))
                End If
                Return
            End If
            TabControl.SelectedTab = tpConclusion

            cmbxServiceType.SelectedValue = dsConferenceTrial.Tables("conference_trial").Rows(bmConclusion.Position)("service_type")
            ServiceTypeChanged(Nothing, Nothing)
            AddHandler TabControl.SelectedIndexChanged, AddressOf TabControl_TabIndexChanged
            AddHandler Me.cmbxServiceType.SelectionChangeCommitted, AddressOf ServiceTypeChanged
            AddHandler txtReviewFeeStandard.KeyPress, AddressOf Money_KeyPress  '加上事件，只能输入数字
            AddHandler txtGuarantyFeeStandard.KeyPress, AddressOf Money_KeyPress
            AddHandler txtGuaranteeScale.KeyPress, AddressOf Money_KeyPress
            '返回已经保存过的评审费率，担保费率（如果有）
            txtReviewFeeStandard.Text = CType(bmConclusion.Current, DataRowView)("trial_rate") & ""
            txtGuarantyFeeStandard.Text = CType(bmConclusion.Current, DataRowView)("guarantee_rate") & ""
            txtGuaranteeScale.Text = CType(bmConclusion.Current, DataRowView)("security_rate") & ""
            '计算评审费是否已经保存过
            Dim dvAccount As DataView = dsAccountDetail.Tables(0).DefaultView
            dvAccount.Sort = "serial_num DESC"
            dvAccount.RowFilter = "item_type='" & RevFeeItemType & "' AND item_code='" & RevFeeItemCode & "' AND phase='评审'"
            If dvAccount.Count > 0 Then
                Dim dr As DataRow
                Dim sum As Double = 0
                Dim drs() As DataRow = dsAccountDetail.Tables(0).Select("item_type='" & RevFeeItemType & "' AND item_code='" & RevFeeItemCode & "'")
                For Each dr In drs
                    sum += CDbl(dr("payout"))
                Next
                txtReviewFee.Text = sum.ToString("n")
            Else '根据评审费率计算的评审费
                txtReviewFeeStandard_Leave(Nothing, Nothing)
            End If
            '计算担保费是否保存过
            dvAccount.RowFilter = "item_type='" & GuaFeeItemType & "' AND item_code='" & GuaFeeItemCode & "' AND phase='评审'"
            If dvAccount.Count > 0 Then
                txtGuarantyFee.Text = dvAccount(0)("payout") & ""
            Else '根据担保费率计算的担保费
                txtGuarantyFeeStandard_Leave(Nothing, Nothing)
            End If
            '计算保证金是否保存过
            dvAccount.RowFilter = "item_type='" & SecFeeItemType & "' AND item_code='" & SecFeeItemCode & "' AND phase='评审'"
            If dvAccount.Count > 0 Then
                txtScaleMoney.Text = dvAccount(0)("payout") & ""
            Else '根据保证金比例计算的保证金
                txtGuaranteeScale_Leave(Nothing, Nothing)
            End If

            '要判断每次还款额是否为空
            txtEachReturnFee.Text = CType(bmConclusion.Current, DataRowView)("refund_sum_average") & ""
            If txtEachReturnFee.Text = String.Empty Then
                cmbxRefundtype_SelectionChangeCommitted(Nothing, Nothing)
            End If

            '判断是否存在保函起始日，截止日
            If Not IsDBNull(CType(bmConclusion.Current, DataRowView)("guarant_start_date")) Then
                dtpGuarantStartDate.Value = DateTime.Parse(CType(bmConclusion.Current, DataRowView)("guarant_start_date"))
                dtpGuarantEndDate.Value = DateTime.Parse(CType(bmConclusion.Current, DataRowView)("guarant_end_date"))
            End If

            AddHandlerToObjs()

            '出函分行
            If cboLetterSubBank.DataSource Is Nothing Then '出函分行
                Dim dv As DataView = New DataView(dsBankCopy.Tables("bank_branch"))
                dv.Sort = "branch_bank_name"
                dv.RowFilter = "bank_code='" & dsConferenceTrial.Tables("conference_trial").Rows(0)("bank") & "'"
                cboLetterSubBank.DataSource = dv
                cboLetterSubBank.DisplayMember = "branch_bank_name"
                cboLetterSubBank.ValueMember = "branch_bank_code"
            End If
            cboLetterSubBank.SelectedValue = dsConferenceTrial.Tables("conference_trial").Rows(0)("bank_branch")
            AddHandler cboLetterBank.SelectionChangeCommitted, AddressOf cboLetterBank_Changed
            txtReviewFee.DataBindings.Add("Enabled", txtReviewFeeStandard, "Enabled") '同步“评审费率”和评审费的Enabled属性
            txtGuarantyFee.DataBindings.Add("Enabled", txtGuarantyFeeStandard, "Enabled") '同步“担保费率”和担保费的Enabled属性
            txtRateRemark.DataBindings.Add("Enabled", txtGuarantyFeeStandard, "Enabled") '同步“担保费率说明”和担保费率的Enabled属性
            txtScaleMoney.DataBindings.Add("Enabled", txtGuaranteeScale, "Enabled")

            cbxFinalDesicion.Enabled = TaskID <> "RecordReviewConclusion_Update"

            '2007-12-5 yjf add 屏蔽评审会意见标签，显示展期评审会意见标签，并加载展期评审会意见标签内容
            Me.TabControl.TabPages.Remove(tpConclusion)
            Me.tpInfo.Enabled = False


            Me.cboExpandRefundType.DataSource = dsRefundType.Tables(0)
            cboExpandRefundType.DisplayMember = "refund_type"
            cboExpandRefundType.ValueMember = "refund_type"

            '绑定评审会议结论
            dsProjectExpandDate = gWs.GetProjectExpandDateInfo("{project_code='" & ProjectCode & "'}")

            cboConclusion.Items.Add("")
            For i = 0 To dsConclusion.Tables(0).Rows.Count - 1
                cboConclusion.Items.Add(dsConclusion.Tables(0).Rows(i).Item("transfer_condition"))
            Next
            cboConclusion.SelectedValue = ""
            AddHandler cboConclusion.SelectedIndexChanged, AddressOf cboConclusion_IndexChanged

            If dsProjectExpandDate.Tables(0).Rows.Count <> 0 Then
                If IIf(IsDBNull(dsProjectExpandDate.Tables(0).Rows(0).Item("exp_conclusion")), "", dsProjectExpandDate.Tables(0).Rows(0).Item("exp_conclusion")) <> "" Then
                    cboConclusion.SelectedValue = dsProjectExpandDate.Tables(0).Rows(0).Item("exp_conclusion")
                Else
                    cboConclusion.SelectedValue = ""
                End If
            End If

            '加载展期评审会意见信息
            If dsProjectExpandDate.Tables(0).Rows.Count <> 0 Then
                Dim dr As DataRow = dsProjectExpandDate.Tables(0).Rows(0)
                With dr
                    Me.txtExpandApplyAmount.Text = IIf(IsDBNull(.Item("exp_apply_amount")), "", .Item("exp_apply_amount"))
                    Me.txtExpandApplyTerm.Text = IIf(IsDBNull(.Item("exp_apply_term")), "", .Item("exp_apply_term"))
                    Me.txtExpendApplyReason.Text = IIf(IsDBNull(.Item("exp_apply_reason")), "", .Item("exp_apply_reason"))
                    Me.txtExpandAmount.Text = IIf(IsDBNull(.Item("exp_amount")), "", .Item("exp_amount"))
                    Me.txtExpandTerm.Text = IIf(IsDBNull(.Item("exp_term")), "", .Item("exp_term"))
                    Me.cboExpandRefundType.SelectedValue = IIf(IsDBNull(.Item("exp_refund_type")), "", .Item("exp_refund_type"))
                    Me.txtExpandRefundAmount.Text = IIf(IsDBNull(.Item("exp_refund_amount")), "", .Item("exp_refund_amount"))
                End With
            End If

            '屏蔽控件
            SetExpControlStatus(False)

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub cboConclusion_IndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim isEnable As Boolean
        If cboConclusion.Text = "" Then
            isEnable = False
        Else
            isEnable = True
        End If
        SetExpControlStatus(isEnable)
    End Sub

    Private Sub SetExpControlStatus(ByVal isEnable As Boolean)
        txtExpandAmount.Enabled = isEnable
        txtExpandTerm.Enabled = isEnable
        cboExpandRefundType.Enabled = isEnable
        txtExpandRefundAmount.Enabled = isEnable
        tpOppGua.Enabled = isEnable : gpxBaoHan.Enabled = isEnable : gpxReGuarantee.Enabled = isEnable
        txtGuarantyFeeStandardExp.Enabled = isEnable
        txtGuarantyFeeExp.Enabled = isEnable
    End Sub

    Private dsProjectExpandDate As DataSet

    Public Sub saveExp()
        '保存展期评审信息

        If dsProjectExpandDate.Tables(0).Rows.Count <> 0 Then
            Dim dr As DataRow = dsProjectExpandDate.Tables(0).Rows(0)
            With dr
                .Item("exp_conclusion") = CDbl(Me.cboConclusion.SelectedValue)
                .Item("exp_amount") = CDbl(Me.txtExpandAmount.Text)
                .Item("exp_term") = CInt(Me.txtExpandTerm.Text)
                .Item("exp_refund_type") = Me.cboExpandRefundType.Text
                .Item("exp_refund_amount") = CDbl(Me.txtExpandRefundAmount.Text)
            End With
            gWs.UpdateProjectExpandDate(dsProjectExpandDate)
        End If

        '保存担保费应收记录
        Dim dsAccountDetailExp As DataSet = gWs.GetProjectAccountDetailInfo("null")
        Dim drTemp As DataRow = dsAccountDetailExp.Tables(0).NewRow
        With drTemp
            .Item("project_code") = ProjectCode
            .Item("date") = SystemDate.Date
            .Item("item_type") = GuaFeeItemType '"31"
            .Item("item_code") = GuaFeeItemCode '"002"
            .Item("remark") = txtRateRemark.Text
            .Item("phase") = "评审"
            .Item("payout") = CDbl(txtGuarantyFeeExp.Text)
            .Item("create_person") = UserName
            .Item("create_date") = SystemDate
        End With
        dsAccountDetailExp.Tables(0).Rows.Add(drTemp)
        gWs.UpdateProjectAccountDetail(dsAccountDetailExp)

    End Sub

    '担保费率改变    
    Private Sub txtGuarantyFeeStandardExp_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtGuarantyFeeStandardExp.Leave
        If txtExpandAmount.Text = String.Empty Or txtGuarantyFeeStandardExp.Text = String.Empty Then
            txtGuarantyFeeExp.Text = "" : Return
        End If
        Try
            txtGuarantyFeeExp.Text = Me.CaculateGuaranteeOfServiceTypeExp(CDbl(txtExpandAmount.Text) * 10000, CInt(Me.txtExpandTerm.Text)).ToString("n")
        Catch
            txtGuarantyFeeStandardExp.Text = "0"
            txtGuarantyFeeExp.Text = "0"
        End Try
    End Sub

    '''''''''''''''''''''''评委意见'''''''''''''''''''''''''''''''''''
    '评委意见样式表
    Private Sub addTableStyleForOpinion(ByVal tablename As String)
        dgOpinion.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle
        dgts.AllowSorting = False
        'dgts.RowHeadersVisible = False
        dgts.MappingName = tablename
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index 1
        col3.MappingName = "committeeman"
        col3.HeaderText = " 会议评委"
        col3.Width = 70
        col3.NullText = String.Empty
        col3.ReadOnly = True
        dgts.GridColumnStyles.Add(col3)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index 2 
        col4.MappingName = "RoleName"
        col4.HeaderText = "角色"
        col4.ReadOnly = True
        col4.NullText = String.Empty
        col4.Width = 40
        dgts.GridColumnStyles.Add(col4)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index 2 
        col2.MappingName = "opinion"
        col2.HeaderText = "评委意见"
        col2.ReadOnly = False
        col2.NullText = String.Empty
        col2.Width = 440
        col2.TextBox.MaxLength = txtOpinion.MaxLength
        dgts.GridColumnStyles.Add(col2)
        dgOpinion.TableStyles.Add(dgts)
    End Sub


    Private Sub QuitBindingForOpinion()
        txtOpinion.DataBindings.Clear()
    End Sub


    '''''''''''''''''''''''评委意见'''''''''''''''''''''''''''''''''''
    '''''''''''''''''''''''会议评审结论''''''''''''''''''''''''''''''

    Private Sub ManageBindingForConclusion()
        txtTimes.DataBindings.Add(New Binding("Text", dsConferenceTrial, "conference_trial.trial_times"))
        txtRemark.DataBindings.Add(New Binding("Text", dsConferenceTrial, "conference_trial.Remark"))
        If Not dsConferenceTrial.Tables("conference_trial").Rows(0).Item("is_final_conclusion") Is DBNull.Value Then
            cbxFinalDesicion.DataBindings.Add(New Binding("Checked", dsConferenceTrial, "conference_trial.is_final_conclusion"))
        End If
        cmbxLoanForm.DataBindings.Add(New Binding("SelectedValue", dsConferenceTrial, "conference_trial.loan_provide_form"))
        cmbxRefundtype.DataBindings.Add(New Binding("SelectedValue", dsConferenceTrial, "conference_trial.refund_type"))
        'cmbxServiceType.DataBindings.Add(New Binding("SelectedValue", dsConferenceTrial, "conference_trial.service_type"))
        'txtReviewFeeStandard.DataBindings.Add(New Binding("Text", dsConferenceTrial, "conference_trial.trial_rate"))
        'txtGuarantyFeeStandard.DataBindings.Add(New Binding("Text", dsConferenceTrial, "conference_trial.guarantee_rate"))
        txtLoanRemark.DataBindings.Add(New Binding("Text", dsConferenceTrial, "conference_trial.loan_form_remark"))
        txtReturnRemark.DataBindings.Add(New Binding("Text", dsConferenceTrial, "conference_trial.refund_type_remark"))
        txtGuarantySum.DataBindings.Add(New Binding("Text", dsConferenceTrial, "conference_trial.guarantee_sum"))

        '添加保函业务品种的绑定        
        cboLetterBank.DataBindings.Add("SelectedValue", dsConferenceTrial, "conference_trial.bank")
        'cboLetterSubBank.DataBindings.Add("SelectedValue", dsConferenceTrial, "conference_trial.bank_branch")
    End Sub

    Private Sub SetSomItemsDBNull(ByVal ItemNames() As String)
        Dim ItemName As String
        For Each ItemName In ItemNames
            dsConferenceTrial.Tables("conference_trial").Rows(0)(ItemName) = DBNull.Value
        Next
    End Sub

    Private Sub ClearConclusionContent(ByVal clearData As Boolean)
        If clearData Then
            Dim ItemNames() As String = New String() {"terms", "loan_provide_form", "refund_type", "service_type", _
                "loan_form_remark", "refund_type_remark", "refund_sum_average", "guarantee_sum", "reimburse_type", _
                 "guarantee_letter_type", "security_rate", "guarantee_rate", "trial_rate", "bank", "bank_branch", "workflow"}
            SetSomItemsDBNull(ItemNames)
            cmbxServiceType.SelectedValue = DBNull.Value
            cmbxServiceType.SelectedItem = Nothing
            If cboRunMode.DropDownStyle = ComboBoxStyle.Simple Then
                cboRunMode.Text = String.Empty
            Else
                cboRunMode.SelectedIndex = -1
            End If
            cmbxServiceType.Tag = Nothing '在此必须要置回NULL            
        End If
    End Sub

    Private Sub SetSomeObjsEnabled(ByVal IsEnable As Boolean)
        cmbxServiceType.Enabled = IsEnable : nudTerms.Enabled = IsEnable : txtGuarantySum.Enabled = IsEnable
        cbxFinalDesicion.Enabled = IsEnable And (TaskID <> "RecordReviewConclusion_Update")
        'txtGuarantyFeeStandard.Enabled = IsEnable : txtRateRemark.Enabled = IsEnable
        tpOppGua.Enabled = IsEnable : gpxBaoHan.Enabled = IsEnable : gpxReGuarantee.Enabled = IsEnable
        If Not IsEnable Then '如果是暂缓
            cmbxRefundtype.Enabled = IsEnable : cmbxLoanForm.Enabled = IsEnable : txtEachReturnFee.Text = String.Empty
            txtReviewFeeStandard.Enabled = IsEnable : txtEachReturnFee.Enabled = IsEnable
            txtReturnRemark.Enabled = IsEnable : txtLoanRemark.Enabled = IsEnable : txtGuaranteeScale.Text = ""
            cboRunMode.Enabled = IsEnable : cboRebetType.Enabled = IsEnable : cboBaoHanType.Enabled = IsEnable
        End If
    End Sub

    Private Sub cmbxConclusion_Selection(ByVal sender As Object, ByVal e As EventArgs) Handles cmbxConclusion.SelectionChangeCommitted
        If Not DataChanged Then
            DataChanged = Not cmbxConclusion.Tag Is Nothing AndAlso Not System.Object.Equals(cmbxConclusion.SelectedValue, cmbxConclusion.Tag)
        End If
        cmbxConclusion.Tag = cmbxConclusion.SelectedValue
        Me.btnPrintReport.Enabled = Me.cmbxConclusion.Text <> String.Empty
        Dim strCon As String = cmbxConclusion.Text '会议结论的文本值
        SetSomeObjsEnabled(strCon.IndexOf(denyText) < 0 And strCon.Trim <> String.Empty) 'strCon.IndexOf("暂缓") < 0 
        ClearConclusionContent(strCon.IndexOf(denyText) >= 0) 'strCon.IndexOf("暂缓") >= 0
        bmConclusion.Position = bmConclusion.Position
    End Sub

    Private Sub cmbxRefundtype_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbxRefundtype.SelectionChangeCommitted
        If txtGuarantySum.Text = String.Empty Then
            Return
        End If
        '如果不是保函业务品种，就不用计算每次还款金额  06,08表示保函业务品种的编码
        If "06,08".IndexOf(Me.GetServicetypeCode) >= 0 Then 'CStr(Me.cmbxServiceType.SelectedValue & "").IndexOf("保函") >= 0 Then 
            Return
        End If
        If dsRefundType Is Nothing Then
            dsRefundType = gWs.GetRefundType("%")
        End If
        If cmbxRefundtype.Text = String.Empty Then
            txtEachReturnFee.Text = String.Empty
            Return
        End If
        Dim LoanMoney As Double = CDbl(txtGuarantySum.Text) * 10000
        Dim code As String = dsRefundType.Tables(0).Select("refund_type='" & cmbxRefundtype.Text & "'")(0)("refund_type_code")
        Select Case code
            Case "01" '"到期一次还款"
                txtEachReturnFee.Text = LoanMoney.ToString("n")
            Case "02" '"等额每季还款"
                Dim season As Integer
                If CInt(nudTerms.Value) <= 3 Then
                    season = 1
                Else
                    If CInt(nudTerms.Value) Mod 3 <> 0 Then
                        season = CLng(nudTerms.Value) \ 3 + 1
                    Else
                        season = CLng(nudTerms.Value) \ 3
                    End If
                End If
                txtEachReturnFee.Text = CLng(LoanMoney / season).ToString("n")
            Case "03" '"等额每月还款"
                txtEachReturnFee.Text = CLng(LoanMoney / CInt(nudTerms.Value)).ToString("n")
            Case "04" '"等额每周还款"
                Dim count As Integer = CLng(CInt(nudTerms.Value) * 52 / 12)
                txtEachReturnFee.Text = CLng(LoanMoney / count).ToString("n")
            Case "05" '"等额每日还款"
                Dim count As Integer = CLng(CInt(nudTerms.Value) * 365 / 12)
                txtEachReturnFee.Text = CLng(LoanMoney / count).ToString("n")
            Case Else
                txtEachReturnFee.Text = String.Empty
                Return
        End Select

    End Sub
    '''''''''''''''''''''''会议评审结论''''''''''''''''''''''''''''''

    Private Sub txtMoney_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPartnerMoney.Enter, txtReviewFee.Enter, txtGuarantyFee.Enter, txtEachReturnFee.Enter, txtGuarantySum.Enter
        Money.Money_Enter(sender, e)
    End Sub
    Private Sub txtMoney_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPartnerMoney.KeyPress, txtReviewFee.KeyPress, txtGuarantyFee.KeyPress, txtEachReturnFee.KeyPress, txtGuarantySum.KeyPress
        Money.Money_KeyPress(sender, e)
    End Sub
    Private Sub txtMoney_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPartnerMoney.Leave, txtEachReturnFee.Leave, txtGuarantySum.Leave
        Try
            Dim d As Double = CDbl(CType(sender, TextBox).Text)
            If Not CType(sender, TextBox) Is txtEachReturnFee Then
                If CDbl(CType(sender, TextBox).Text) * 10000 > MaxMoney Then
                    SWDialogBox.MessageBox.Show("$X032", MaxMoney.ToString("n"))
                    CType(sender, TextBox).Text = String.Empty
                    Return
                End If
            ElseIf txtGuarantySum.Text.Trim <> "" And CDbl(txtEachReturnFee.Text) > CDbl(txtGuarantySum.Text) * 10000 Then
                SWDialogBox.MessageBox.Show("$X033")
                txtEachReturnFee.Text = String.Empty
                Return
            End If
        Catch
            CType(sender, TextBox).Text = String.Empty
            Return
        End Try
        If Not CType(sender, TextBox) Is txtGuarantySum Then
            Money.Money_Leave(sender, e)
        End If
    End Sub

    ''''''''''''''''''''''放款处理'''''''''''''''''''''''''''''''''''
    '恢复项目状态
    Private Function ResumeProject() As Boolean
        If Not dsPro.Tables(0).Rows(0).IsNull("origPhase") Then
            If Not dsPro.Tables(0).Rows(0).IsNull("origStatus") Then
                dsPro.Tables(0).Rows(0)("phase") = dsPro.Tables(0).Rows(0)("origPhase")
                dsPro.Tables(0).Rows(0)("status") = dsPro.Tables(0).Rows(0)("origStatus")
                dsPro.Tables(0).Rows(0)("origPhase") = DBNull.Value
                dsPro.Tables(0).Rows(0)("origStatus") = DBNull.Value
                Dim strResult As String = gWs.UpdateProject(dsPro.GetChanges)
                If strResult <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "保存项目阶段信息失败", strResult, "")
                    Return False
                End If
                dsPro.AcceptChanges()  '接受修改
            End If
        End If
        Return True
    End Function

    Private Function ResumeProjectFlow() As Boolean
        If Not ResumeProject() Then
            Return False
        End If
        Dim dsTask As DataSet = gWs.GetProjectTaskAttendeeInfo("{project_code='" & ProjectCode & "'}")
        Dim drs() As DataRow = dsTask.Tables(0).Select("task_status='A'")
        If drs.Length = 0 Then
            Return False
        End If
        Dim dr As DataRow
        For Each dr In drs
            dr("task_status") = "P"
        Next
        dsTask.Tables(0).Select("task_id='" & TaskID & "'")(0)("task_status") = "F"
        Dim result As String = gWs.UpdateProjectTaskAttendee(dsTask.GetChanges)
        dsTask.Dispose()
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "恢复项目状态失败", result, "")
            Return True
        Else
            SWDialogBox.MessageBox.Show("$OperateSucceed")
            MyBase.raiseCommitSucceed()
            RemoveHandler MyBase.Closing, AddressOf frmMeetingRecordExp_Closing
            Close()
        End If
        Return True
    End Function
    '提交

    Protected Overridable Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交") 'MessageBox.Show("请确定提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If

        If Not HasUploadReport() Then '还没上载评审意见表
            Return
        End If

        'If Not IsInfoEffective() Then Return

        If DataChanged Then
            If Not Save(Nothing) Then
                Return
            End If
        End If

        If cbxFinalDesicion.Enabled AndAlso (Not IsDBNull(dsConferenceTrial.Tables("conference_trial").Rows(bmConclusion.Position)("is_final_conclusion"))) Then
            If CBool(dsConferenceTrial.Tables("conference_trial").Rows(bmConclusion.Position)("is_final_conclusion")) Then '选择恢复项目状态
                If ResumeProjectFlow() Then
                    Return
                End If
            End If
        End If

        Dim dsTask As DataSet = gWs.GetProjectTaskAttendeeInfo("{project_code='" & ProjectCode & "'}")
        Dim drs() As DataRow = dsTask.Tables(0).Select("task_status='A'")
        If drs.Length > 0 Then
            Dim dr As DataRow
            For Each dr In drs
                dr("task_status") = "F"
            Next
            Dim result As String = gWs.UpdateProjectTaskAttendee(dsTask.GetChanges)
            dsTask.Dispose()
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "更改项目状态失败", result, "")
                Return
            End If
        End If

        Dim strResult As String = gWs.finishedTask(cboRunMode.Text, ProjectCode, TaskID, Me.cboConclusion.Text, UserName)
        If strResult = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            If Not CBool(dsConferenceTrial.Tables("conference_trial").Rows(bmConclusion.Position)("status")) Then
                dsConferenceTrial.Tables("conference_trial").Rows(bmConclusion.Position)("status") = True
                Dim strTemp As String = gWs.UpdateConfTrial(dsConferenceTrial.GetChanges)
                If strTemp <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "评审会议结论保存失败", strTemp, "")
                End If
            End If
            If CStr(dsConference.Tables("conference").Rows(0)("status")) <> "已开" Then
                dsConference.Tables("conference").Rows(0)("status") = "已开"
                gWs.UpdateConferenceCommitteeman(dsConference.GetChanges)
            End If
            MyBase.raiseCommitSucceed()
            RemoveHandler MyBase.Closing, AddressOf frmMeetingRecordExp_Closing
            Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "")
        End If
    End Sub

    Private Sub frmMeetingRecordExp_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        MyBase.setEnterKeyPress(sender, e)
    End Sub

    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ConfirmClose(sender, e)
    End Sub
    Private Function ConfirmClose(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        If DataChanged Then
            Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003") 'MessageBox.Show("数据已修改，是否保存？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If QueryResult = DialogResult.Yes Then
                If Not Save(Nothing) Then
                    Return False
                End If
            ElseIf QueryResult = DialogResult.Cancel Then
                Return False
            End If
        End If
        RemoveHandler MyBase.Closing, AddressOf frmMeetingRecordExp_Closing
        Close()
        Return True
    End Function

    Protected Sub frmMeetingRecordExp_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, e)
    End Sub
    '贷款金额的改变
    Private Sub txtGuarantySum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGuarantySum.TextChanged
        Dim obj As TextBox = CType(sender, TextBox)

        If Not TextIsDigit(obj.Text) Then
            obj.Text = "" : txtEachReturnFee.Text = "" : txtReturnRemark.Text = "" : txtLoanRemark.Text = ""
            txtReviewFee.Text = "" : txtGuarantyFee.Text = "" : txtRateRemark.Text = "" : txtScaleMoney.Text = ""
            'Return
        End If

        'GetFeeRateFromDataViewToTextBox() '是否有保证金比例要显示
        txtGuaranteeScale_Leave(Nothing, Nothing) '是否要计算保证金金额
        txtGuarantyFeeStandard_Leave(Nothing, Nothing)
        'txtGuarantyFee.Text = Me.CaculateGuaranteeOfServiceType(CDbl(txtGuarantySum.Text) * 10000, CInt(nudTerms.Value)).ToString("n")
        txtReviewFeeStandard_Leave(Nothing, Nothing) '评审费 

        cmbxRefundtype_SelectionChangeCommitted(sender, e)
    End Sub
    '保函品种的保证金比例改变时
    Private Sub txtGuaranteeScale_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtGuaranteeScale.Leave
        If txtGuaranteeScale.Text = String.Empty Or txtGuarantySum.Text = String.Empty Then
            txtScaleMoney.Text = String.Empty : Return
        End If
        Try
            txtScaleMoney.Text = (CDbl(txtGuarantySum.Text) * 100 * CDbl(txtGuaranteeScale.Text)).ToString("n")
        Catch
            txtGuaranteeScale.Text = "0" : txtScaleMoney.Text = "0"
        End Try
    End Sub
    '担保费率改变    
    Private Sub txtGuarantyFeeStandard_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtGuarantyFeeStandard.Leave
        If txtGuarantySum.Text = String.Empty Or txtGuarantyFeeStandard.Text = String.Empty Then
            txtGuarantyFee.Text = "" : Return
        End If
        Try
            txtGuarantyFee.Text = Me.CaculateGuaranteeOfServiceType(CDbl(txtGuarantySum.Text) * 10000, CInt(nudTerms.Value)).ToString("n")
        Catch
            txtGuarantyFeeStandard.Text = "0"
            txtGuarantyFee.Text = "0"
        End Try
    End Sub
    '评审费率改变    
    Private Sub txtReviewFeeStandard_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtReviewFeeStandard.Leave
        If Not txtReviewFeeStandard.Enabled Then
            txtReviewFee.Text = ""
            Return
        End If
        If txtGuarantySum.Text = String.Empty Then
            txtReviewFee.Text = "" : Return
        End If
        '06,08表示保函业务品种的编码
        If "06,08".IndexOf(Me.GetServicetypeCode) >= 0 Then 'CStr(cmbxServiceType.SelectedValue & "").IndexOf("保函") > -1 Then
            Return
        End If
        Try
            txtReviewFee.Text = (CDbl(txtGuarantySum.Text) * 100 * CDbl(IIf(txtReviewFeeStandard.Text = String.Empty, 0, txtReviewFeeStandard.Text))).ToString("n")
            If CDbl(txtReviewFee.Text) < GetLowestReviewFee() Then
                txtReviewFee.Text = GetLowestReviewFee()
            End If
        Catch
            txtReviewFeeStandard.Text = "0"
            txtReviewFee.Text = "0"
        End Try
    End Sub
    '计算非保函业务品种的最低评审费
    Private Function GetLowestReviewFee() As Double
        If Not cmbxServiceType.SelectedItem Is Nothing Then
            Dim drv As DataRowView = CType(cmbxServiceType.SelectedItem, DataRowView)
            Return CDbl(drv("lowest_review_sum") + "0")
        End If
        Return 0
    End Function


    Private Function IsInfoEffective() As Boolean
        If chkPartner.Checked And Me.cboPartner.Text = String.Empty Then '合作区局
            SWDialogBox.MessageBox.Show("$1001", "合作区局")
            cboPartner.Focus()
            Return False
        End If
        If Me.cmbxConclusion.Text = String.Empty Then
            SWDialogBox.MessageBox.Show("$1001", "会议评审意见")
            cmbxConclusion.Focus()
            Return False
        End If
        If cmbxConclusion.Text.IndexOf(passText) >= 0 AndAlso Me.GetServicetypeCode <> "03" Then 'cmbxServiceType.SelectedValue <> "委托评审" Then
            If cmbxServiceType.SelectedIndex < 0 Then
                SWDialogBox.MessageBox.Show("$1001", "业务品种")
                cmbxServiceType.Focus()
                Return False
            End If
            If cboRunMode.Text = String.Empty Then
                SWDialogBox.MessageBox.Show("$1001", "运作方式")
                cboRunMode.Focus()
                Return False
            End If
            If "06,08".IndexOf(Me.GetServicetypeCode) < 0 Then 'CStr(cmbxServiceType.SelectedValue).IndexOf("保函") < 0 Then
                If cmbxLoanForm.SelectedIndex < 0 And Me.GetServicetypeCode <> "09" Then 'cmbxServiceType.SelectedValue <> "综合授信"
                    SWDialogBox.MessageBox.Show("$1001", "放款方式")
                    cmbxLoanForm.Focus()
                    Return False
                ElseIf cmbxRefundtype.SelectedIndex < 0 And Me.GetServicetypeCode <> "09" Then   'cmbxServiceType.SelectedValue <> "综合授信" 
                    SWDialogBox.MessageBox.Show("$1001", "还款方式")
                    cmbxRefundtype.Focus()
                    Return False
                End If
            End If

            If txtGuarantySum.Text = String.Empty OrElse CDbl(txtGuarantySum.Text) <= 0 Then
                SWDialogBox.MessageBox.Show("$1003", lblGuaranSumDescription.Text.Substring(0, lblGuaranSumDescription.Text.IndexOf("("))) '"贷款金额")
                txtGuarantySum.Focus()
                Return False
            End If
        End If

        If dtpGuarantStartDate.Visible Then '保函品种
            If dtpGuarantStartDate.Value.Date >= Me.dtpGuarantEndDate.Value.Date Then
                SWDialogBox.MessageBox.Show("$1008", "保函起始日", "截止日")
                dtpGuarantStartDate.Focus()
                Return False
            End If
        End If

        Return True
    End Function

    Private Function HasUploadReport() As Boolean
        '判断有没有上载评审意见表
        If cmbxConclusion.Text.IndexOf(passText) >= 0 Then
            '"45"："011"
            Dim dsProFiles As DataSet = gWs.GetProjectFile(ProjectCode, "011", "45")
            Dim hasFile As Boolean = True
            If dsProFiles.Tables(0).Rows.Count = 0 Then
                hasFile = False
            ElseIf IsDBNull(dsProFiles.Tables(0).Rows(0)("document")) Then
                hasFile = False
            End If
            dsProFiles.Dispose()
            If Not hasFile Then
                SWDialogBox.MessageBox.Show("请上载评审意见表", "系统提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
                Return False
            End If
        End If
        Return True
    End Function

    Private Function Save(ByVal sender As Object) As Boolean
        If Not IsGuaranteeLetterUsageInfoEffective() Then
            SWDialogBox.MessageBox.Show("保函种类、偿还责任类型及期限存在重复值", "系统提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Warning)
            If Not TabControl.SelectedTab Is tpOtherInfo Then
                TabControl.SelectedTab = tpOtherInfo
            End If
            dgIntegrate.Focus()
            Return False
        End If
        Try
            Me.Cursor = Cursors.WaitCursor

            If Not OtherAction() Then '保存担保费或评审费失败
                Return False
            End If

            If Not SaveGuaranteeLetter() Then '保存guarantee_letter和guarantee_letter_usage,如果业务品种是保函综合授信
                Return False
            End If
            '''''保存合作区局意见'''''''''''''''''''
            SavePartner()
            Dim strResult As String
            '保存项目申请信息
            dsPro.Tables(0).Rows(0)("apply_branch_bank") = IIf(cmbxSubBank.SelectedValue Is Nothing, DBNull.Value, cmbxSubBank.SelectedValue)
            bmCor.EndCurrentEdit() : bmPro.EndCurrentEdit()
            If dsCor.HasChanges Then
                strResult = gWs.UpdateCorCon(dsCor.GetChanges)
                If strResult <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "保存企业信息失败", strResult, "")
                    Return False
                End If
                dsCor.AcceptChanges()  '接受修改
            End If
            If dsPro.HasChanges Then
                strResult = gWs.UpdateProject(dsPro.GetChanges)
                If strResult <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "保存项目申请信息失败", strResult, "")
                    Return False
                End If
                dsPro.AcceptChanges()  '接受修改
            End If
            '保存评委意见
            bmOpinion.Position = dgOpinion.CurrentRowIndex
            If Not CType(dgOpinion.DataSource, DataSet) Is dsConferenceTrial Then
                dgOpinion.DataMember = String.Empty
                dgOpinion.DataSource = Nothing
                Dim dr As DataRow
                For Each dr In dsConCopy.Tables("conference_committeeman").Rows
                    Dim newdr As DataRow = dsConferenceTrial.Tables("committeeman_opinion").NewRow
                    With newdr
                        .Item("project_code") = ProjectCode
                        .Item("trial_times") = TrialTimes
                        .Item("committeeman") = dr("committeeman")
                        .Item("opinion") = dr("Opinion")
                        .Item("role_id") = IIf(CStr(dr("RoleName")) = "主评", "28", "26")
                        .Item("create_person") = UserName
                        .Item("create_date") = SystemDate.Date
                    End With
                    dsConferenceTrial.Tables("committeeman_opinion").Rows.Add(newdr)
                Next
                txtOpinion.DataBindings.Clear()
                txtOpinion.DataBindings.Add(New Binding("Text", dsConferenceTrial, "committeeman_opinion.Opinion"))
                dsConferenceTrial.Tables("committeeman_opinion").Columns.Add("RoleName", GetType(String), "IIf(role_id LIKE '28', '主评', '评委')")
                bmOpinion = BindingContext(dsConferenceTrial, "committeeman_opinion")
                addTableStyleForOpinion("committeeman_opinion")
                dgOpinion.DataMember = "committeeman_opinion"
                dgOpinion.DataSource = dsConferenceTrial
                dsConCopy = Nothing

                Dim view As DataView = CType(CType(Me.BindingContext(dgOpinion.DataSource, dgOpinion.DataMember), CurrencyManager).List, DataView)
                view.AllowDelete = False
                view.AllowNew = False
            End If

            '保存会议结论
            'If dsConferenceTrial.HasChanges Then
            '    bmConclusion.Position = 0
            '    With dsConferenceTrial.Tables("conference_trial").Rows(bmConclusion.Position)
            '        .Item("trial_conclusion") = cmbxConclusion.SelectedValue
            '        .Item("is_final_conclusion") = cbxFinalDesicion.Checked
            '        'If cmbxConclusion.Text <> "暂缓" Then
            '        .Item("refund_sum_average") = IIf(txtEachReturnFee.Text <> String.Empty, txtEachReturnFee.Text, DBNull.Value)
            '        .Item("terms") = CInt(nudTerms.Value)
            '        'End If
            '        .Item("trial_rate") = IIf(txtReviewFeeStandard.Text <> String.Empty, txtReviewFeeStandard.Text, DBNull.Value)
            '        .Item("guarantee_rate") = IIf(txtGuarantyFeeStandard.Text <> String.Empty, txtGuarantyFeeStandard.Text, DBNull.Value)
            '        .Item("security_rate") = IIf(txtGuaranteeScale.Text <> String.Empty, txtGuaranteeScale.Text, DBNull.Value)
            '        .Item("workflow") = IIf(cboRunMode.Text <> String.Empty, cboRunMode.Text, DBNull.Value)
            '        .Item("bank_branch") = IIf(cboLetterSubBank.SelectedValue Is Nothing, DBNull.Value, cboLetterSubBank.SelectedValue)
            '        If dtpGuarantStartDate.Visible Then
            '            .Item("guarant_start_date") = dtpGuarantStartDate.Value
            '            .Item("guarant_end_date") = dtpGuarantEndDate.Value
            '            .Item("terms") = Math.Abs(dtpGuarantEndDate.Value.Year * 12 + dtpGuarantEndDate.Value.Month - dtpGuarantStartDate.Value.Year * 12 - dtpGuarantStartDate.Value.Month)
            '        Else
            '            .Item("guarant_start_date") = DBNull.Value
            '            .Item("guarant_end_date") = DBNull.Value
            '        End If
            '    End With
            '    bmConclusion.EndCurrentEdit()
            '    strResult = IIf(dsConferenceTrial.HasChanges, gWs.UpdateConfTrial(dsConferenceTrial.GetChanges), "")
            'End If
            SaveOppGua() '保存反担保措施

            saveExp() '保存展期信息

            If strResult = "1" Then 'Or strResult = "11"
                DataChanged = False
                btnPrintReport.Enabled = True
                btnJoinReport.Enabled = True
                dsConferenceTrial.AcceptChanges()
                If sender Is Nothing Then
                    Return True
                End If
                If dsAccountDetail.HasChanges(DataRowState.Added) Then '(由于serial_num，必须重新获取)
                    dsAccountDetail = gWs.GetProjectAccountDetailInfo("{project_code LIKE '" & ProjectCode & "' AND item_type IN ('" & GuaFeeItemType & "', '" & SecFeeItemType & "') AND income IS NULL}")
                Else
                    dsAccountDetail.AcceptChanges()
                End If
            Else
                SWDialogBox.MessageBox.Show("*999", "保存失败", strResult, "")
                Return False
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        Return True
    End Function

    Private Sub SaveEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Save(sender) Then
            SWDialogBox.MessageBox.Show("$SaveSucceed")
        End If
    End Sub

    '增加担保费，评审费支出到project_account_detail
    Private Function OtherAction() As Boolean
        If cmbxConclusion.Text.IndexOf(denyText) >= 0 Then Return True
        If txtGuarantySum.Text = "" OrElse CDbl(txtGuarantySum.Text) = 0 Then
            Return True
        End If

        Dim ReviewFee, GuarantyFee, SecurityFee As Double
        GuarantyFee = CDbl(IIf(txtGuarantyFee.Text <> "", txtGuarantyFee.Text, 0)) '担保费
        ReviewFee = CDbl(IIf(txtReviewFee.Text <> "", txtReviewFee.Text, 0)) '评审费
        SecurityFee = CDbl(IIf(txtScaleMoney.Text <> "", txtScaleMoney.Text, 0)) '保证金

        Dim strRowFilter, result, strSql As String
        Dim dsTemp As DataSet
        If txtGuarantyFeeStandard.Enabled Then

            strSql = "{project_code='" & Me.ProjectCode & "' and item_type='" & GuaFeeItemType & "' AND item_code='" & GuaFeeItemCode & "' and payout is not null}"
            dsTemp = gWs.GetProjectAccountDetailInfo(strSql)

            If dsTemp.Tables(0).Rows.Count <> 0 Then
                Dim dr As DataRow
                For Each dr In dsTemp.Tables(0).Rows
                    dr.Delete()
                Next
                If dsTemp.HasChanges Then
                    result = gWs.UpdateProjectAccountDetail(dsTemp.GetChanges)
                    If result <> "1" Then
                        SWDialogBox.MessageBox.Show("*999", "保存费用失败", result, "")
                        Return False
                    End If
                End If
            End If

            If GuarantyFee > 0 Then '应收担保费>0
                dsTemp = gWs.GetProjectAccountDetailInfo(strSql)
                Dim dr As DataRow = dsTemp.Tables(0).NewRow
                With dr
                    .Item("project_code") = ProjectCode
                    .Item("date") = SystemDate.Date
                    .Item("item_type") = GuaFeeItemType '"31"
                    .Item("item_code") = GuaFeeItemCode '"002"
                    .Item("remark") = txtRateRemark.Text
                    .Item("phase") = "评审"
                    .Item("payout") = GuarantyFee
                    .Item("create_person") = UserName
                    .Item("create_date") = SystemDate
                End With
                dsTemp.Tables(0).Rows.Add(dr)
                If dsTemp.HasChanges Then
                    result = gWs.UpdateProjectAccountDetail(dsTemp.GetChanges)
                    If result <> "1" Then
                        SWDialogBox.MessageBox.Show("*999", "保存费用失败", result, "")
                        Return False
                    End If
                End If
            End If


            strSql = "{project_code='" & Me.ProjectCode & "' and item_type='" & GuaFeeItemType & "' AND item_code='" & GuaFeeItemCode & "' and payout is not null}"
            dsTemp = gWs.GetProjectAccountDetailInfo(strSql)
            If dsTemp.Tables(0).Rows.Count > 1 Then
                Dim i As Integer
                For i = 1 To dsTemp.Tables(0).Rows.Count
                    dsTemp.Tables(0).Rows(i).Delete()
                Next
                If dsTemp.HasChanges Then
                    result = gWs.UpdateProjectAccountDetail(dsTemp.GetChanges)
                    If result <> "1" Then
                        SWDialogBox.MessageBox.Show("*999", "保存费用失败", result, "")
                        Return False
                    End If
                End If
            End If


        End If

        '取保证金的payout不为Null的记录
        '2007-08-02 yjf edit 所有业务品种都可以收取保证金
        If txtScaleMoney.Text <> "" AndAlso txtScaleMoney.Text > 0 Then

            '2007-9-5 yjf add  消除产生两条记录的可能，使用局部变量
            strSql = "{project_code='" & Me.ProjectCode & "' and item_type='" & SecFeeItemType & "' AND item_code='" & SecFeeItemCode & "' and payout is not null}"
            dsTemp = gWs.GetProjectAccountDetailInfo(strSql)
            If dsTemp.Tables(0).Rows.Count <> 0 Then
                Dim dr As DataRow
                For Each dr In dsTemp.Tables(0).Rows
                    dr.Delete()
                Next
                If dsTemp.HasChanges Then
                    result = gWs.UpdateProjectAccountDetail(dsTemp.GetChanges)
                    If result <> "1" Then
                        SWDialogBox.MessageBox.Show("*999", "保存费用失败", result, "")
                        Return False
                    End If
                End If
            End If

            If SecurityFee > 0 Then
                dsTemp = gWs.GetProjectAccountDetailInfo(strSql)
                Dim dr As DataRow = dsTemp.Tables(0).NewRow
                With dr
                    .Item("project_code") = ProjectCode
                    .Item("date") = SystemDate.Date
                    .Item("item_type") = SecFeeItemType '"34"
                    .Item("item_code") = SecFeeItemCode '"009"
                    .Item("phase") = "评审"
                    .Item("payout") = SecurityFee
                    .Item("create_person") = UserName
                    .Item("create_date") = SystemDate
                End With
                dsTemp.Tables(0).Rows.Add(dr)
                If dsTemp.HasChanges Then
                    result = gWs.UpdateProjectAccountDetail(dsTemp.GetChanges)
                    If result <> "1" Then
                        SWDialogBox.MessageBox.Show("*999", "保存费用失败", result, "")
                        Return False
                    End If
                End If
            End If

            dsTemp = gWs.GetProjectAccountDetailInfo(strSql)
            If dsTemp.Tables(0).Rows.Count > 1 Then
                Dim i As Integer
                For i = 1 To dsTemp.Tables(0).Rows.Count
                    dsTemp.Tables(0).Rows(i).Delete()
                Next
                If dsTemp.HasChanges Then
                    result = gWs.UpdateProjectAccountDetail(dsTemp.GetChanges)
                    If result <> "1" Then
                        SWDialogBox.MessageBox.Show("*999", "保存费用失败", result, "")
                        Return False
                    End If
                End If
            End If

        End If


        If txtReviewFeeStandard.Enabled Then
            Dim dsOpinion As DataSet
            Dim strOpinion As String
            Dim needInsertReviewFee As Boolean = True
            dsOpinion = gWs.GetProjectOpinionByProjectNo(ProjectCode)
            If dsOpinion.Tables(0).Select("item_type='51' AND item_code='004'").Length > 0 Then
                Dim dr As DataRow = dsOpinion.Tables(0).Select("item_type='51' AND item_code='004'")(0)
                strOpinion = dr("conclusion") & ""
                If strOpinion = "免收" Then
                    needInsertReviewFee = False
                    'Return True
                End If
            End If
            If needInsertReviewFee Then

                If ReviewFee > 0 Then

                    '2007-9-5 yjf add  消除产生两条记录的可能，使用局部变量
                    strSql = "{project_code='" & Me.ProjectCode & "' and item_type='" & RevFeeItemType & "' AND item_code='" & RevFeeItemCode & "' and payout is not null}"
                    dsTemp = gWs.GetProjectAccountDetailInfo(strSql)
                    If dsTemp.Tables(0).Rows.Count <> 0 Then
                        Dim dr1 As DataRow
                        For Each dr1 In dsTemp.Tables(0).Rows
                            dr1.Delete()
                        Next
                        If dsTemp.HasChanges Then
                            result = gWs.UpdateProjectAccountDetail(dsTemp.GetChanges)
                            If result <> "1" Then
                                SWDialogBox.MessageBox.Show("*999", "保存费用失败", result, "")
                                Return False
                            End If
                        End If
                    End If

                    dsTemp = gWs.GetProjectAccountDetailInfo(strSql)
                    Dim dr As DataRow = dsTemp.Tables(0).NewRow
                    With dr
                        .Item("project_code") = ProjectCode
                        .Item("date") = SystemDate.Date
                        .Item("item_type") = RevFeeItemType '"31"
                        .Item("item_code") = RevFeeItemCode '"001"
                        .Item("phase") = "评审"
                        '.Item("payout") = balance
                        .Item("payout") = ReviewFee
                        .Item("create_person") = UserName
                        .Item("create_date") = SystemDate
                    End With
                    dsTemp.Tables(0).Rows.Add(dr)
                    If dsTemp.HasChanges Then
                        result = gWs.UpdateProjectAccountDetail(dsTemp.GetChanges)
                        If result <> "1" Then
                            SWDialogBox.MessageBox.Show("*999", "保存费用失败", result, "")
                            Return False
                        End If
                    End If

                    dsTemp = gWs.GetProjectAccountDetailInfo(strSql)
                    If dsTemp.Tables(0).Rows.Count > 1 Then
                        Dim i As Integer
                        For i = 1 To dsTemp.Tables(0).Rows.Count
                            dsTemp.Tables(0).Rows(i).Delete()
                        Next
                        If dsTemp.HasChanges Then
                            result = gWs.UpdateProjectAccountDetail(dsTemp.GetChanges)
                            If result <> "1" Then
                                SWDialogBox.MessageBox.Show("*999", "保存费用失败", result, "")
                                Return False
                            End If
                        End If
                    End If

                End If
            End If

        End If

        If Not IsNothing(dsTemp) Then
            If dsTemp.HasChanges Then
                result = gWs.UpdateProjectAccountDetail(dsTemp.GetChanges)
                If result <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "保存费用失败", result, "")
                    Return False
                End If
            End If
        End If


        Return True
    End Function


#Region "反担保物措施管理"
    '表opposite_guarantee 的列：opposite_guarantee_form ；guaranty_type；project_code   源表
    '表project_guarantee_form 的列：guarantee_form ；guaranty；project_code             目的表
    '其中源表的guaranty_type从表 item_type 的列 item_type 获得 item_name   

    '返回数据集 "TProjectGuaranteeForm"
    Private dsLocal As DataSet
    Private cmLocal As CurrencyManager
    Private dsProCor As DataSet '保证企业
    Private dsPerson As DataSet '个人保证
    Private dsOppGuaForm As DataSet
    Private dsAdditionalForm As DataSet '附加方式（汽车，房地产之类）
    Private GuaType As String = "total"

    Private Sub GetDataSourceOfOppGua()
        Dim dsOppGuaFormTemp As DataSet = gWs.GetOppositeGuaranteeForm("{flag=1}")
        dsOppGuaForm = gWs.GetOppositeGuaranteeForm("{flag=0}")

        Dim dsItemType As DataSet = gWs.GetItemType("%") '
        dsGuaForm = gWs.GetProjectGuaranteeForm("{project_code LIKE '" & ProjectCode & "'}")
        dsProCor = gWs.FetchProjectCorporation(ProjectCode, "%", "2", "%")
        dsProCor.Tables("TProjectCorporation").Columns.Add("is_used", GetType(Boolean))
        dsPerson = gWs.GetOppositeGuaranteeAssurerInfo("{project_code LIKE '" & ProjectCode & "'}")
        dsPerson.Tables("opposite_guarantee_assurer").Columns.Add("is_used", GetType(Boolean))

        dsGuaSubmit = gWs.GetGuarantyInfo("{project_code LIKE '" & ProjectCode & "' ORDER BY opposite_guarantee_form}", "{project_code LIKE '" & ProjectCode & "'}")
        dsGuaranty = New DataSet
        dsGuaranty = dsGuaSubmit.Copy
        dsGuaranty.Tables("opposite_guarantee").Columns.Add("ItemName", GetType(String))
        dsGuaranty.Tables("opposite_guarantee").Columns.Add("is_used", GetType(Boolean))

        Dim dr As DataRow
        '先初始化num和guarantee_sum为零
        For Each dr In dsGuaForm.Tables("TProjectGuaranteeForm").Rows
            dr("num") = 0
            dr("guarantee_sum") = 0
        Next
        Dim drs As DataRow()

        '由表opposite_guarantee_assurer得出的反担保物
        For Each dr In dsPerson.Tables(0).Rows
            drs = dsGuaForm.Tables("TProjectGuaranteeForm").Select("guarantee_form LIKE '个人保证'")
            If drs.Length > 0 Then
                dr("is_used") = IIf(CStr(dr("status") & "").Trim = "评审通过", True, False)
                drs(0)("num") = CInt(drs(0)("num")) + IIf(CBool(dr("is_used")), 1, 0)
                drs(0)("guarantee_sum") = CDbl(drs(0)("guarantee_sum")) + IIf(CBool(dr("is_used")), (dr("guarantee_sum") + "0"), 0)
                If Not CBool(drs(0)("is_used")) Then
                    drs(0)("is_used") = dr("is_used")
                End If
            Else
                Dim newdr As DataRow = dsGuaForm.Tables("TProjectGuaranteeForm").NewRow
                With newdr
                    .Item("project_code") = ProjectCode
                    .Item("guarantee_form") = "个人保证"
                    .Item("description") = "个人保证"
                    .Item("guaranty") = DBNull.Value
                    .Item("num") = 0
                    .Item("is_used") = False
                    .Item("guarantee_sum") = 0 'MyIIf(dr("guarantee_sum"), GetType(Double), 0)
                    .Item("create_person") = UserName
                    .Item("create_date") = SystemDate
                End With
                dsGuaForm.Tables("TProjectGuaranteeForm").Rows.Add(newdr)
                dr("is_used") = False
            End If
        Next
        '由表project_corporation得出的反担保物
        For Each dr In dsProCor.Tables("TProjectCorporation").Rows
            drs = dsGuaForm.Tables("TProjectGuaranteeForm").Select("guarantee_form LIKE '企业保证'")
            If drs.Length > 0 Then
                dr("is_used") = IIf(CStr(dr("status") & "").Trim = "评审通过", True, False)
                drs(0)("num") = CInt(drs(0)("num")) + IIf(CBool(dr("is_used")), 1, 0)
                If Not CBool(drs(0)("is_used")) Then
                    drs(0)("is_used") = dr("is_used")
                End If
            Else
                Dim newdr As DataRow = dsGuaForm.Tables("TProjectGuaranteeForm").NewRow
                With newdr
                    .Item("project_code") = ProjectCode
                    .Item("guarantee_form") = "企业保证"
                    .Item("description") = "企业保证"
                    .Item("guaranty") = DBNull.Value
                    .Item("num") = 0
                    .Item("is_used") = False
                    .Item("create_person") = UserName
                    .Item("create_date") = SystemDate
                End With
                dsGuaForm.Tables("TProjectGuaranteeForm").Rows.Add(newdr)
                dr("is_used") = False
            End If
        Next

        Dim statusArray() As String = New String() {"评审通过", "抵押质押", "解除"}
        '由表opposite_guarantee得出的反担保物
        For Each dr In dsGuaranty.Tables("opposite_guarantee").Rows '遍历反担保物主表
            dr("ItemName") = dsItemType.Tables("TItemType").Select("item_type='" & dr("guaranty_type") & "'")(0)("type_name")
            drs = dsGuaForm.Tables("TProjectGuaranteeForm").Select("guarantee_form = '" & CStr(dr("opposite_guarantee_form") & "") & "' AND guaranty = '" & CStr(dr("guaranty_type") & "") & "'")
            If drs.Length > 0 Then
                dr("is_used") = statusArray.IndexOf(statusArray, dr("status")) >= 0
                drs(0)("num") = CInt(drs(0)("num")) + IIf(CBool(dr("is_used")), 1, 0)
                drs(0)("guarantee_sum") = CDbl(drs(0)("guarantee_sum")) + IIf(CBool(dr("is_used")), (dr("guarantee_value") + "0"), 0)
                If Not CBool(drs(0)("is_used")) Then
                    drs(0)("is_used") = dr("is_used")
                End If
            Else
                Dim newdr As DataRow = dsGuaForm.Tables("TProjectGuaranteeForm").NewRow
                With newdr
                    .Item("project_code") = ProjectCode
                    .Item("guarantee_form") = Trim(dr("opposite_guarantee_form") & "")
                    .Item("guaranty") = Trim(dr("guaranty_type") & "")
                    .Item("num") = 0
                    .Item("description") = dr("ItemName").ToString & dr("opposite_guarantee_form").ToString
                    .Item("guarantee_sum") = 0 'Money.MyIIf(dr("guarantee_value"), GetType(Double), 0)
                    .Item("is_used") = False
                    .Item("create_person") = UserName
                    .Item("create_date") = SystemDate
                End With
                dsGuaForm.Tables("TProjectGuaranteeForm").Rows.Add(newdr)
                dr("is_used") = False
            End If
        Next
        '不用界面，从表opposite_guarantee_form自动增加到反担保措施（如果没有）
        For Each dr In dsOppGuaFormTemp.Tables(0).Rows
            Dim strName As String = dr("name") & ""
            If strName <> String.Empty AndAlso strName.IndexOf("个人保证") < 0 AndAlso strName.IndexOf("企业保证") < 0 Then '非企业保证和个人保证
                drs = dsGuaForm.Tables("TProjectGuaranteeForm").Select("guarantee_form='" & strName & "'")
                If drs.Length = 0 Then
                    Dim newdr As DataRow = dsGuaForm.Tables("TProjectGuaranteeForm").NewRow
                    With newdr
                        .Item("project_code") = ProjectCode
                        .Item("guarantee_form") = strName.Trim
                        .Item("description") = strName
                        .Item("guaranty") = DBNull.Value
                        .Item("num") = 0
                        .Item("is_used") = False
                        .Item("guarantee_sum") = 0
                        .Item("create_person") = UserName
                        .Item("create_date") = SystemDate
                    End With
                    dsGuaForm.Tables("TProjectGuaranteeForm").Rows.Add(newdr)
                End If
            End If
        Next

        dsLocal = New DataSet
        dsLocal = dsGuaForm.Copy
        dsLocal.Tables("TProjectGuaranteeForm").Columns.Add("ItemName", GetType(String))
        For Each dr In dsLocal.Tables("TProjectGuaranteeForm").Rows
            If IsDBNull(dr("guaranty")) Then
                dr("ItemName") = DBNull.Value
            Else
                dr("ItemName") = dsItemType.Tables("TItemType").Select("item_type='" & dr("guaranty") & "'")(0)("type_name")
            End If
        Next

        dgOppGua.DataMember = "TProjectGuaranteeForm"
        dgOppGua.DataSource = dsLocal
        AddTableStyleForOppGua()
        cmLocal = Me.BindingContext(dsLocal, "TProjectGuaranteeForm")
        CType(cmLocal.List, DataView).AllowDelete = False
        CType(cmLocal.List, DataView).AllowNew = False

        cm_PositionChanged(Nothing, Nothing)
        AddHandler cmLocal.PositionChanged, AddressOf cm_PositionChanged

    End Sub

    Private Sub cm_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If cmLocal.Count = 0 Then
            dgDetail.Visible = False
            gpxAdditionalForm.Visible = False
            gpbxOppGua.Height += (dgDetail.Top + dgDetail.Height - gpbxOppGua.Top - gpbxOppGua.Height)
            dgDetail.DataSource = Nothing
            Return
        End If

        dgDetail.DataMember = "" : dgDetail.DataSource = Nothing
        Dim str As String = CStr(CType(cmLocal.Current, DataRowView)("guarantee_form")).Trim
        If str = "个人保证" Then
            GuaType = "person"
            dsPerson.Tables("opposite_guarantee_assurer").DefaultView.AllowNew = False
            dsPerson.Tables("opposite_guarantee_assurer").DefaultView.AllowDelete = False
            dgDetail.DataSource = dsPerson.Tables("opposite_guarantee_assurer").DefaultView
            AddTableStyleOfPerson()
        ElseIf str = "企业保证" Then
            GuaType = "company"
            dsProCor.Tables("TProjectCorporation").DefaultView.AllowNew = False
            dsProCor.Tables("TProjectCorporation").DefaultView.AllowDelete = False
            dgDetail.DataSource = dsProCor.Tables("TProjectCorporation").DefaultView
            AddTableStyleOfCompany()
        ElseIf IsDBNull(CType(cmLocal.Current, DataRowView)("guaranty")) Then
            dgDetail.TableStyles.Clear()
            dgDetail.DataSource = Nothing
            GuaType = "nothing"
        Else
            If GuaType <> "" Then
                AddTableStyleOfDetail()
            End If
            dsGuaranty.Tables("opposite_guarantee").DefaultView.RowFilter = "opposite_guarantee_form = '" & dsLocal.Tables(0).Rows(cmLocal.Position)("guarantee_form").ToString & _
                     "' AND guaranty_type='" & dsLocal.Tables(0).Rows(cmLocal.Position)("guaranty").ToString & "'"
            dsGuaranty.Tables("opposite_guarantee").DefaultView.AllowDelete = False
            dsGuaranty.Tables("opposite_guarantee").DefaultView.AllowNew = False
            dgDetail.DataSource = dsGuaranty.Tables("opposite_guarantee").DefaultView
            GuaType = ""

            If cklbxAdditionalForm.DataSource Is Nothing Then
                cklbxAdditionalForm.DataSource = dsOppGuaForm.Tables(0)
                cklbxAdditionalForm.DisplayMember = "name"
                cklbxAdditionalForm.ValueMember = "name"
                cklbxAdditionalForm.Tag = "true"
                AddHandler cklbxAdditionalForm.ItemCheck, AddressOf AdditionalForm_ItemCheckChanged
            End If
            If dsAdditionalForm Is Nothing Then
                '获取数据集
                dsAdditionalForm = gWs.GetProjectGuaranteeFormAdd("{project_code LIKE '" & ProjectCode & "'}")
            End If
            If dgOppGua.CurrentCell.ColumnNumber <> 0 Then
                ShowAdditionalForm() '显示附加方式
            End If
        End If

        dgDetail.Visible = (GuaType <> "nothing")
        gpxAdditionalForm.Visible = (GuaType = String.Empty)
    End Sub

    Private Sub ShowDetailInfo(ByVal sender As Object, ByVal e As EventArgs) Handles dgDetail.DoubleClick
        If dgDetail.CurrentRowIndex < 0 Then
            Return
        End If
        Dim row As DataRowView = CType(dgDetail.DataSource, DataView)(dgDetail.CurrentRowIndex)
        If dgDetail.TableStyles.Contains("opposite_guarantee") Then
            Dim frmShow As FShowOppGuaranteeDetail = New FShowOppGuaranteeDetail(ProjectCode, Convert.ToInt32(row("serial_num")), row("guaranty_type") & "")
            frmShow.AllowTransparency = False
            frmShow.StartPosition = FormStartPosition.CenterScreen
            frmShow.ShowDialog(Me)
        ElseIf dgDetail.TableStyles.Contains("TProjectCorporation") Then
            Dim frmCor As frmCorAssure = New frmCorAssure(0, ProjectCode, Me.CorporationName, row("phase") & "", row("corporation_code") & "")
            frmCor.StartPosition = FormStartPosition.CenterScreen
            frmCor.OnlyView()
            frmCor.ShowDialog()
        End If
    End Sub

    Private Sub ClearAdditionalForm()
        Dim i, count As Int32
        Dim drv As DataRowView = CType(cmLocal.Current, DataRowView)
        Dim rowFilter As String = "guarantee_form='" & drv("guarantee_form").ToString & "' AND guaranty='" & drv("guaranty").ToString & "'"
        Dim drs() As DataRow = dsAdditionalForm.Tables(0).Select(rowFilter, "", DataViewRowState.CurrentRows)
        count = drs.Length
        For i = count - 1 To 0 Step -1
            drs(i).Delete()
        Next
        drv = Nothing
        cklbxAdditionalForm.Tag = "clear"
        cklbxAdditionalForm.ClearSelected()
        count = cklbxAdditionalForm.CheckedIndices.Count - 1
        For i = count To 0 Step -1
            cklbxAdditionalForm.SetItemChecked(cklbxAdditionalForm.CheckedIndices(i), False)
        Next
        cklbxAdditionalForm.Tag = "true"
    End Sub

    '附加方式改变时
    Private Sub AdditionalForm_ItemCheckChanged(ByVal sender As Object, ByVal e As ItemCheckEventArgs)
        If cklbxAdditionalForm.Tag.ToString = "false" Then '表示不需触发本事件，即不调用本方法
            Return
        End If

        If Not CBool(CType(cmLocal.Current, DataRowView)("is_used")) Then '主反担保措施没打勾
            If cklbxAdditionalForm.Tag.ToString <> "clear" Then '如果不是 clear 状态，即通过鼠标去打勾，而不是通过代码去改变值，就永远改变不了值
                e.NewValue = e.CurrentValue
            End If
            Return '如果是clear状态，不做任何操作，直接退出
        End If

        If e.NewValue Then
            Dim dr As DataRow = dsAdditionalForm.Tables(0).NewRow
            dr("project_code") = ProjectCode
            dr("guarantee_form") = CType(cmLocal.Current, DataRowView)("guarantee_form")
            dr("guaranty") = CType(cmLocal.Current, DataRowView)("guaranty")
            dr("additional_guarantee_form") = Trim(cklbxAdditionalForm.SelectedValue & "")
            dr("create_person") = UserName
            dr("create_date") = SystemDate
            dsAdditionalForm.Tables(0).Rows.Add(dr)
        Else
            Dim drv As DataRowView = CType(cmLocal.Current, DataRowView)
            Dim strSelected As String = "guarantee_form='" & drv("guarantee_form").ToString & "' AND guaranty='" & drv("guaranty").ToString & "' AND additional_guarantee_form='" & Trim(cklbxAdditionalForm.SelectedValue & "") & "'"
            dsAdditionalForm.Tables(0).Select(strSelected)(0).Delete()
        End If
        DataChanged = True
    End Sub

    Private Sub ShowAdditionalForm()
        If GuaType <> "" Then Return '非具体的反担保物
        cklbxAdditionalForm.Tag = "false"
        cklbxAdditionalForm.ClearSelected()
        Dim drv As DataRowView = CType(cmLocal.Current, DataRowView)
        Dim dv As DataView = dsAdditionalForm.Tables(0).DefaultView
        dv.RowFilter = "guarantee_form='" & drv("guarantee_form").ToString & "' AND guaranty='" & drv("guaranty").ToString & "'"
        Dim key As String
        Dim i As Int32
        '先把所有的选项去勾
        For i = 0 To cklbxAdditionalForm.Items.Count - 1
            cklbxAdditionalForm.SetItemChecked(i, False)
        Next
        '再打勾
        For Each drv In dv
            key = drv("additional_guarantee_form").ToString
            For i = 0 To cklbxAdditionalForm.Items.Count - 1
                If key = CType(cklbxAdditionalForm.Items(i), DataRowView)("name").ToString Then
                    cklbxAdditionalForm.SetItemChecked(i, True)
                    Exit For
                End If
            Next
        Next
        cklbxAdditionalForm.Tag = "true"
    End Sub

    Private Sub SetParentBoolOfPerson(ByVal value As Boolean)
        Dim i As Integer
        Dim total As Double
        Dim name As String = String.Empty
        For i = 0 To dsPerson.Tables("opposite_guarantee_assurer").DefaultView.Count - 1
            dsPerson.Tables("opposite_guarantee_assurer").DefaultView(i)("is_used") = value
            dsPerson.Tables("opposite_guarantee_assurer").DefaultView(i)("status") = IIf(value, "评审通过", "申请")
            total += CDbl(dsPerson.Tables("opposite_guarantee_assurer").DefaultView(i)("guarantee_sum") + "0")
            If (dsPerson.Tables("opposite_guarantee_assurer").DefaultView(i)("name") & "") <> String.Empty Then
                If name = String.Empty Then
                    name = dsPerson.Tables("opposite_guarantee_assurer").DefaultView(i)("name") & ""
                Else
                    name += "、" & dsPerson.Tables("opposite_guarantee_assurer").DefaultView(i)("name") & ""
                End If
            End If
        Next
        CType(cmLocal.Current, DataRowView)("num") = IIf(value, dsPerson.Tables("opposite_guarantee_assurer").DefaultView.Count, 0)
        CType(cmLocal.Current, DataRowView)("guarantee_sum") = IIf(value, total, 0)
        CType(cmLocal.Current, DataRowView)("description") = IIf(value, "个人保证" & ":" & name, "个人保证")
    End Sub

    Private Sub SetChildBoolOfPerson(ByVal inx As Integer, ByVal value As Boolean)
        Dim obj As Object = dsPerson.Tables("opposite_guarantee_assurer").DefaultView(inx)("guarantee_sum")
        With dsLocal.Tables(0).Rows(cmLocal.Position)
            .Item("num") = CInt(.Item("num")) + IIf(value, 1, -1)
            .Item("guarantee_sum") = CDbl(.Item("guarantee_sum")) + IIf(value, 1, -1) * CDbl(obj + "0")
            .Item("is_used") = CInt(.Item("num")) > 0
        End With
        dsPerson.Tables("opposite_guarantee_assurer").DefaultView(inx)("status") = IIf(value, "评审通过", "申请")
        Dim personName As String = dsPerson.Tables("opposite_guarantee_assurer").DefaultView(inx)("name") & ""
        If personName <> String.Empty Then
            Dim str As String = CType(cmLocal.Current, DataRowView)("description").ToString.Trim
            If value Then
                If str.IndexOf(":") > -1 Then
                    str += "、" & personName
                Else
                    str += ":" & personName
                End If
            Else
                str = str.Replace("、" & personName, "")
                str = str.Replace(personName, "")
            End If
            If str.IndexOf("、") = str.IndexOf(":") + 1 Then
                str = str.Remove(str.IndexOf("、"), 1)
            End If
            CType(cmLocal.Current, DataRowView)("description") = str
        End If
    End Sub

    Private Sub SetParentBoolOfCompany(ByVal value As Boolean)
        Dim i As Integer
        Dim name As String = String.Empty
        For i = 0 To dsProCor.Tables("TProjectCorporation").DefaultView.Count - 1
            dsProCor.Tables("TProjectCorporation").DefaultView(i)("is_used") = value
            dsProCor.Tables("TProjectCorporation").DefaultView(i)("status") = IIf(value, "评审通过", "申请")
            If dsProCor.Tables("TProjectCorporation").DefaultView(i)("corporation_name") & "" <> String.Empty Then
                If name = String.Empty Then
                    name = dsProCor.Tables("TProjectCorporation").DefaultView(i)("corporation_name") & ""
                Else
                    name += "、" & dsProCor.Tables("TProjectCorporation").DefaultView(i)("corporation_name") & ""
                End If
            End If
        Next
        CType(cmLocal.Current, DataRowView)("num") = IIf(value, dsProCor.Tables("TProjectCorporation").DefaultView.Count, 0)
        CType(cmLocal.Current, DataRowView)("description") = IIf(value, "企业保证" & ":" & name, "企业保证")
    End Sub

    Private Sub SetChildboolOfCompany(ByVal inx As Integer, ByVal value As Boolean)
        With dsLocal.Tables(0).Rows(cmLocal.Position)
            .Item("num") = CInt(.Item("num")) + IIf(value, 1, -1)
            .Item("is_used") = CInt(.Item("num")) > 0
        End With
        dsProCor.Tables("TProjectCorporation").DefaultView(inx)("status") = IIf(value, "评审通过", "申请")
        Dim str As String = CType(cmLocal.Current, DataRowView)("description") & ""
        Dim comName As String = dsProCor.Tables("TProjectCorporation").DefaultView(inx)("corporation_name") & ""
        If value Then
            If str.IndexOf(":") > -1 Then
                str += "、" & comName
            Else
                str += ":" & comName
            End If
        Else
            str = str.Replace("、" & comName, "")
            str = str.Replace(comName, "")
        End If
        If str.IndexOf("、") = str.IndexOf(":") + 1 Then
            str = str.Remove(str.IndexOf("、"), 1)
        End If
        CType(cmLocal.Current, DataRowView)("description") = str
    End Sub

    Private Sub SetParentBoolOfOther(ByVal value As Boolean)
        Dim i As Integer
        Dim total As Double
        For i = 0 To dsGuaranty.Tables("opposite_guarantee").DefaultView.Count - 1
            dsGuaranty.Tables("opposite_guarantee").DefaultView(i)("is_used") = value
            dsGuaranty.Tables("opposite_guarantee").DefaultView(i)("status") = IIf(value, "评审通过", "申请")
            total += CDbl(dsGuaranty.Tables("opposite_guarantee").DefaultView(i)("guarantee_value") + "0")
            dsGuaSubmit.Tables("opposite_guarantee").Select("serial_num=" & _
                        CInt(dsGuaranty.Tables("opposite_guarantee").DefaultView(i)("serial_num")).ToString)(0)("status") = IIf(value, "评审通过", "申请")
        Next
        CType(cmLocal.Current, DataRowView)("num") = IIf(value, dsGuaranty.Tables("opposite_guarantee").DefaultView.Count, 0)
        CType(cmLocal.Current, DataRowView)("guarantee_sum") = IIf(value, total, 0)
        Dim dv As DataRowView = dsGuaranty.Tables("opposite_guarantee").DefaultView(0)
        Dim str As String = IIf(value, "(数量:" & CType(cmLocal.Current, DataRowView)("num") & "): 担保金额:" & total.ToString & "元", "")
        CType(cmLocal.Current, DataRowView)("description") = dv("ItemName") & "" & dv("opposite_guarantee_form") & str

        If Not value Then '如 False 则清除附加方式
            ClearAdditionalForm()
        End If
    End Sub

    Private Sub SetChildBoolOfOther(ByVal inx As Integer, ByVal value As Boolean)
        Dim obj As Object = dsGuaranty.Tables("opposite_guarantee").DefaultView(inx)("guarantee_value")
        With dsLocal.Tables(0).Rows(cmLocal.Position)
            .Item("num") = CInt(.Item("num")) + IIf(value, 1, -1)
            .Item("guarantee_sum") = CDbl(.Item("guarantee_sum")) + IIf(value, 1, -1) * CDbl(obj + "0")
            .Item("is_used") = CInt(.Item("num")) > 0
        End With
        Dim dv As DataRowView = dsGuaranty.Tables("opposite_guarantee").DefaultView(inx)
        dv("status") = IIf(value, "评审通过", "申请")
        dsGuaSubmit.Tables("opposite_guarantee").Select("serial_num=" & _
                                CInt(dv("serial_num")).ToString)(0)("status") = IIf(value, "评审通过", "申请")
        Dim count As Int32 = CType(cmLocal.Current, DataRowView)("num")
        If count = 0 Then
            Dim str As String = CType(cmLocal.Current, DataRowView)("description") & ""
            CType(cmLocal.Current, DataRowView)("description") = str.Substring(0, str.IndexOf("("))
            '清除附加方式
            ClearAdditionalForm()
        Else
            CType(cmLocal.Current, DataRowView)("description") = dv("ItemName") & "" & dv("opposite_guarantee_form") & "(数量:" & count & "): 担保金额:" & CType(cmLocal.Current, DataRowView)("guarantee_sum") & "元"
        End If

    End Sub

    Private Sub dgOpp_Click(ByVal sender As Object, ByVal e As EventArgs) Handles dgOppGua.Click
        Me.ShowAdditionalForm() '显示附加方式
    End Sub

    Private Sub dgOpp_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgOppGua.MouseUp, dgDetail.MouseUp
        Dim he As DataGrid = CType(sender, DataGrid)
        If he.HitTest(e.X, e.Y).Type <> DataGrid.HitTestType.Cell Then Return
        If he.CurrentCell.ColumnNumber <> 0 Then Return
        If IsComeFromMeetQuery And HasRecorded Then Return
        he.Item(he.CurrentCell) = Not CBool(he.Item(he.CurrentCell))
        DataChanged = True
        If he Is dgOppGua Then
            If GuaType = "" Then
                'ShowAdditionalForm() '显示附加方式
                dgDetail.CurrentRowIndex = dsGuaranty.Tables("opposite_guarantee").DefaultView.Count - 1
                SetParentBoolOfOther(CBool(he.Item(he.CurrentCell)))
            ElseIf GuaType = "company" Then
                dgDetail.CurrentRowIndex = dsProCor.Tables("TProjectCorporation").DefaultView.Count - 1
                SetParentBoolOfCompany(CBool(he.Item(he.CurrentCell)))
            ElseIf GuaType = "person" Then
                dgDetail.CurrentRowIndex = dsPerson.Tables("opposite_guarantee_assurer").DefaultView.Count - 1
                SetParentBoolOfPerson(CBool(he.Item(he.CurrentCell)))
            End If
        ElseIf he Is dgDetail Then
            If GuaType = "" Then
                'ShowAdditionalForm() '显示附加方式
                SetChildBoolOfOther(he.CurrentCell.RowNumber, he.Item(he.CurrentCell))
            ElseIf GuaType = "company" Then
                SetChildboolOfCompany(he.CurrentCell.RowNumber, he.Item(he.CurrentCell))
            ElseIf GuaType = "person" Then
                SetChildBoolOfPerson(he.CurrentCell.RowNumber, he.Item(he.CurrentCell))
            End If
            dgDetail.CurrentRowIndex = dgDetail.CurrentRowIndex
        End If
        cmLocal.Position = dgOppGua.CurrentRowIndex
    End Sub

    Private Sub SaveOppGua()
        Dim i As Integer = 0
        Dim dr As DataRow
        For Each dr In dsLocal.Tables("TProjectGuaranteeForm").Rows
            dsGuaForm.Tables(0).Rows(i)("is_used") = dr("is_used")
            dsGuaForm.Tables(0).Rows(i)("num") = dr("num")
            dsGuaForm.Tables(0).Rows(i)("guarantee_sum") = dr("guarantee_sum")
            dsGuaForm.Tables(0).Rows(i)("description") = dr("description")
            'dsGuaForm.Tables(0).Rows(i)("additional_guarantee_form") = dr("additional_guarantee_form")
            i += 1
        Next
        Dim strResult As String = gWs.UpdateProjectGuaranteeForm(dsGuaForm.GetChanges)
        If strResult <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存反担保措施失败", strResult, "")
            Return
        Else
            dsGuaForm = gWs.GetProjectGuaranteeForm("{project_code LIKE '" & ProjectCode & "'}")
            dsLocal.AcceptChanges()
        End If
        '附加方式的保存
        If Not dsAdditionalForm Is Nothing Then
            If dsAdditionalForm.HasChanges Then
                strResult = gWs.UpdateProjectGuaranteeFormAdd(dsAdditionalForm.GetChanges)
                If strResult <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "保存附加方式失败", strResult, "")
                    Return
                Else
                    dsAdditionalForm = gWs.GetProjectGuaranteeFormAdd("{project_code LIKE '" & ProjectCode & "'}")
                End If
            End If
        End If
        '个人保证的保存
        If dsPerson.HasChanges Then
            strResult = gWs.UpdateOppositeGuaranteeAssurer(dsPerson.GetChanges)
            If strResult <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存个人保证失败", strResult, "")
                Return
            Else
                dsPerson.AcceptChanges()
            End If
        End If
        '企业保证的保存
        If dsProCor.HasChanges Then
            strResult = gWs.UpdateProjectCorporation(dsProCor.GetChanges)
            If strResult <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存企业保证失败", strResult, "")
                Return
            Else
                dsProCor.AcceptChanges()
            End If
        End If
        '明细反担保物的保存

        If dsGuaSubmit.HasChanges Then
            strResult = gWs.UpdateGuaranty(dsGuaSubmit.GetChanges)
            If strResult <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存反担保物失败", strResult, "")
                Return
            Else
                dsGuaSubmit.AcceptChanges() : dsGuaranty.AcceptChanges()
            End If
        End If
    End Sub
#End Region

#Region "反担保物各个DataGrid样式表"
    Private Sub AddTableStyleOfPerson()
        dgDetail.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle
        dgts.MappingName = "opposite_guarantee_assurer"
        dgts.AllowSorting = False
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf MyGetColorRowCol)
        Dim col5 As DataGridColoredBoolColumn = New DataGridColoredBoolColumn(d, 0)
        col5.MappingName = "is_used"
        col5.AllowNull = False
        col5.ReadOnly = IsComeFromMeetQuery And HasRecorded
        col5.HeaderText = "是否采用"
        col5.Width = 60
        dgts.GridColumnStyles.Add(col5)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col2.ReadOnly = True
        col2.MappingName = "name"
        col2.HeaderText = "姓名"
        col2.Width = 60
        col2.NullText = ""
        dgts.GridColumnStyles.Add(col2)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col6.MappingName = "status"
        col6.HeaderText = "状态"
        col6.NullText = ""
        col6.ReadOnly = True
        col6.Width = 60
        dgts.GridColumnStyles.Add(col6)
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col1.MappingName = "sex"
        col1.ReadOnly = True
        col1.HeaderText = "性别"
        col1.Width = 40
        col1.NullText = ""
        dgts.GridColumnStyles.Add(col1)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col3.MappingName = "phone"
        col3.ReadOnly = True
        col3.HeaderText = "联系电话"
        col3.Width = 90
        col3.NullText = ""
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col4.MappingName = "address"
        col4.ReadOnly = True
        col4.HeaderText = "住址"
        col4.Width = 300
        col4.NullText = ""
        dgts.GridColumnStyles.Add(col4)
        dgDetail.TableStyles.Add(dgts)
    End Sub
    Private Sub AddTableStyleOfCompany()
        dgDetail.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle
        dgts.MappingName = "TProjectCorporation"
        dgts.AllowSorting = False
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf MyGetColorRowCol)
        Dim col5 As DataGridColoredBoolColumn = New DataGridColoredBoolColumn(d, 0)
        col5.MappingName = "is_used"
        col5.AllowNull = False
        col5.ReadOnly = IsComeFromMeetQuery And HasRecorded
        col5.HeaderText = "是否采用"
        col5.Width = 60
        dgts.GridColumnStyles.Add(col5)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col2.ReadOnly = True
        col2.MappingName = "corporation_name"
        col2.HeaderText = "公司名称"
        col2.NullText = ""
        col2.Width = 150
        dgts.GridColumnStyles.Add(col2)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col6.MappingName = "status"
        col6.HeaderText = "状态"
        col6.NullText = ""
        col6.ReadOnly = True
        col6.Width = 60
        dgts.GridColumnStyles.Add(col6)
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col1.MappingName = "legal_representative"
        col1.ReadOnly = True
        col1.HeaderText = "法定代表人"
        col1.Width = 85
        col1.NullText = ""
        col1.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col1)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col3.MappingName = "contact_phone"
        col3.ReadOnly = True
        col3.HeaderText = "联系电话"
        col3.Width = 90
        col3.NullText = ""
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col4.MappingName = "register_address"
        col4.ReadOnly = True
        col4.HeaderText = "注册地址"
        col4.Width = 200
        col4.NullText = ""
        dgts.GridColumnStyles.Add(col4)
        dgDetail.TableStyles.Add(dgts)
    End Sub
    '设置列的颜色
    Public Function MyGetColorRowCol(ByVal row As Integer, ByVal col As Integer) As Color
        ' just conditionally set colors based on row, col values...
        If col = 0 Then
            Return Color.LightYellow
        ElseIf col = 1 Then
            Return Color.LightBlue
        End If
        Return Color.White
    End Function

    Private Sub AddTableStyleForOppGua()
        dgOppGua.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle
        dgts.MappingName = "TProjectGuaranteeForm"
        dgts.AllowSorting = False
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf MyGetColorRowCol)
        Dim col1 As DataGridColoredBoolColumn = New DataGridColoredBoolColumn(d, 0) ' DataGridBoolColumn = New DataGridBoolColumn()
        col1.MappingName = "is_used"
        col1.AllowNull = False
        col1.ReadOnly = IsComeFromMeetQuery And HasRecorded
        col1.HeaderText = "是否采用"
        col1.Width = 55
        dgts.GridColumnStyles.Add(col1)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col2.ReadOnly = True
        col2.MappingName = "guarantee_form"
        col2.HeaderText = "反担保方式"
        col2.Width = 90
        dgts.GridColumnStyles.Add(col2)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col3.MappingName = "ItemName"
        col3.ReadOnly = True
        col3.HeaderText = "反担保物"
        col3.Width = 90
        col3.NullText = ""
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        'Dim col10 As DataGridComboBoxColumn = New DataGridComboBoxColumn()
        'col10.MappingName = "additional_guarantee_form"
        'col10.HeaderText = "附加方式"
        'col10.Width = 120
        'col10.NullText = String.Empty
        'col10.ColumnComboBox.DataSource = dsOppGuaForm.Tables(0).DefaultView
        'col10.ColumnComboBox.DisplayMember = "name"
        'col10.ColumnComboBox.ValueMember = "name"
        'col10.ColumnComboBox.Enabled = Not (IsComeFromMeetQuery And HasRecorded)
        'dgts.GridColumnStyles.Add(col10)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col4.MappingName = "num"
        col4.ReadOnly = True
        col4.HeaderText = "数量"
        col4.Width = 30
        col4.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col4)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col5.MappingName = "guarantee_sum"
        col5.ReadOnly = True
        col5.HeaderText = "担保金额(元) "
        col5.Width = 90
        col5.Format = "n"
        col5.NullText = ""
        col5.Alignment = HorizontalAlignment.Right
        dgts.GridColumnStyles.Add(col5)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col6.MappingName = "description"
        col6.ReadOnly = IsComeFromMeetQuery And HasRecorded
        col6.HeaderText = "描述"
        col6.Width = 340
        col6.NullText = ""
        col6.Alignment = HorizontalAlignment.Left
        col6.TextBox.MaxLength = 100
        AddHandler col6.TextBox.KeyPress, AddressOf DescriptionChanged
        dgts.GridColumnStyles.Add(col6)
        dgOppGua.TableStyles.Add(dgts)
    End Sub
    Private Sub DescriptionChanged(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        DataChanged = True
    End Sub

    Private Sub AddTableStyleOfDetail()
        dgDetail.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle
        dgts.MappingName = "opposite_guarantee"
        dgts.AllowSorting = False
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf MyGetColorRowCol)
        Dim col9 As DataGridColoredBoolColumn = New DataGridColoredBoolColumn(d, 0)
        col9.MappingName = "is_used"
        col9.ReadOnly = IsComeFromMeetQuery And HasRecorded
        col9.AllowNull = False
        col9.HeaderText = "是否采用"
        col9.Width = 70
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col1.HeaderText = "反担保物"
        col1.ReadOnly = True
        col1.MappingName = "ItemName"
        col1.NullText = ""
        col1.Width = 75
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col2.HeaderText = "反担保方式"
        col2.MappingName = "opposite_guarantee_form"
        col2.NullText = ""
        col2.ReadOnly = True
        col2.Width = 75
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col10.MappingName = "status"
        col10.HeaderText = "状态"
        col10.NullText = ""
        col10.ReadOnly = True
        col10.Width = 60
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col3.HeaderText = "原值(元)"
        col3.MappingName = "original_value"
        col3.NullText = "0"
        col3.Width = 75
        col3.ReadOnly = True
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col4.HeaderText = "评估值(元)"
        col4.MappingName = "evaluate_value"
        col4.NullText = "0"
        col4.Width = 75
        col4.ReadOnly = True
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col5.HeaderText = "担保额(元)"
        col5.MappingName = "guarantee_value"
        col5.NullText = "0"
        col5.Width = 75
        col5.ReadOnly = True
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col6.HeaderText = "评估日期"
        col6.MappingName = "evaluate_date"
        col6.NullText = ""
        col6.Format = "yyyy-MM-dd"
        col6.Width = 70
        col6.ReadOnly = True
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col7.HeaderText = "评估师"
        col7.MappingName = "evaluate_person"
        col7.NullText = ""
        col7.ReadOnly = True
        col7.Width = 75
        col7.ReadOnly = True
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col8.HeaderText = "说明"
        col8.MappingName = "remark"
        col8.NullText = ""
        col8.Width = 75
        col8.ReadOnly = True
        dgts.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {col9, col2, col1, col10, col3, col4, col5, col6, col7, col8})
        dgDetail.TableStyles.Add(dgts)
    End Sub
    ''''''反担保物管理'''''''''''''''''
#End Region

#Region "打印报告"
    Private Sub btnPrintReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintReport.Click
        If btnPrintReport.Tag Is Nothing Then
            Return
        End If
        If btnPrintReport.Tag.ToString = "approval" Then '通过
            PrintPassOpinion(sender, e)
        ElseIf btnPrintReport.Tag.ToString = "deny" Then '暂缓
            PrintDenyOpinion(sender, e)
        End If
    End Sub

    '打印项目评审意见表 "45"："011"
    Private Sub PrintPassOpinion(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not IsInfoEffective() Then Return

        If DataChanged Then
            If Not Save(Nothing) Then
                Return
            End If
        End If
        Me.Cursor = Cursors.WaitCursor
        Dim i As Integer
        Try  '''''生成哈希表
            If htMeeting Is Nothing Then
                If dsProInfo Is Nothing Then
                    'dsProInfo = New DataSet()
                    dsProInfo = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
                    If dsProInfo Is Nothing Then
                        MessageBox.Show("获取项目信息出错，没有记录")
                        Return
                    End If
                End If
                htMeeting = New Hashtable
                htMeeting.Add("&#Number", ProjectCode)
                htMeeting.Add("&#Date", txtDate.Text)
                htMeeting.Add("&#Times", txtTimes.Text)
                htMeeting.Add("&#ID", txtDate.Text)
                '''''项目角色信息''''''''''''''''''                
                Dim drMan As DataRow = dsProInfo.Tables(0).Rows(0)
                htMeeting.Add("&#MA", drMan("24") & "")
                htMeeting.Add("&#MB", drMan("25") & "")
                htMeeting.Add("&#LawManager", drMan("33") & "")
                '''''与会人员'''''''''''''''''''''
                Dim meetingOpinion As String = String.Empty
                Dim strPeople As String
                Dim dt As DataTable = CType(dgOpinion.DataSource, DataSet).Tables(dgOpinion.DataMember)
                For i = 0 To dt.Rows.Count - 1
                    meetingOpinion += CStr(dt.Rows(i)("committeeman")) & "（" & dt.Rows(i)("opinion") & "）" & Chr(13)
                    strPeople += IIf(strPeople Is Nothing, "", "，") & CStr(dt.Rows(i)("committeeman"))
                Next
                If dt.Rows.Count > 0 Then
                    meetingOpinion = meetingOpinion.Substring(0, meetingOpinion.Length - 1)
                End If
                ReplaceFlag(htMeeting, "&#", "ManOpi", meetingOpinion, 12)
                htMeeting.Add("&#People", strPeople)
                ''''''''与会人员 END'''''''''''''''''''''
                htMeeting.Item("&#InputDate") = SystemDate.ToString("yyyy-MM-dd")
            End If
            ''''''''''''项目信息'''''''''''''''''''''
            Dim drInfo As DataRow = dsPro.Tables(0).Rows(0)
            htMeeting.Item("&#Corporation") = txtNewName.Text
            htMeeting.Item("&#Area") = cmbxArea.Text
            Dim applyServiceType As String = drInfo("apply_service_type") & ""
            htMeeting.Item("&#ApplyServiceType") = applyServiceType
            htMeeting.Item("&#ApplySum") = (drInfo("apply_sum") + "0") & "万元"
            'htMeeting.Item("&#ApplyTerm") = (drInfo("apply_term") + "0") & "月"
            htMeeting.Item("&#Bank") = cmbxApplyBank.Text
            htMeeting.Item("&#SubBank") = cmbxSubBank.Text

            ''''''''''''评审会评审意见'''''''''''''''
            Dim infoRow As DataRow = dsConferenceTrial.Tables("conference_trial").Rows(0)
            Dim isBaoHan As Boolean = False '业务品种是否为保函
            '业务品种
            Dim obj As Object
            If infoRow("workflow") = infoRow("service_type") Then
                obj = infoRow("service_type")
            Else
                obj = infoRow("service_type") & "（" & infoRow("workflow") & "）"
            End If
            htMeeting.Item("&#ServiceType") = obj & ""
            isBaoHan = CStr(obj & "").IndexOf("保函") >= 0 '会议评审为保函品种
            '担保金额，保函额度
            obj = infoRow("guarantee_sum")
            htMeeting.Item("&#Sum") = CDbl(obj + "0") & "万元"

            Dim applyBaoHan As Boolean = applyServiceType.IndexOf("保函") >= 0 '申请品种为保函品种
            '申请期限（如是保函，则为日期期间）
            If applyBaoHan Then  '"06,08".IndexOf(Me.GetServicetypeCode) >= 0 
                Dim dsQuery As DataSet = gWs.GetCommonQueryInfo("SELECT guarant_start_date,guarant_end_date FROM dbo.project WHERE project_code='" & ProjectCode & "'")
                If dsQuery.Tables(0).Rows.Count = 0 Then
                    htMeeting.Item("&#ApplyTerm") = String.Empty
                Else
                    Dim startD, endD As String
                    If Not IsDBNull(dsQuery.Tables(0).Rows(0)("guarant_start_date")) Then
                        startD = Format(DateTime.Parse(dsQuery.Tables(0).Rows(0)("guarant_start_date")), "yyyy-MM-dd")
                    End If
                    If Not IsDBNull(dsQuery.Tables(0).Rows(0)("guarant_end_date")) Then
                        endD = Format(DateTime.Parse(dsQuery.Tables(0).Rows(0)("guarant_end_date")), "yyyy-MM-dd")
                    End If
                    htMeeting.Item("&#ApplyTerm") = "有效日期 " & startD & " - " & endD
                End If
                dsQuery.Dispose()
            Else
                '申请期限，保函期限'003010401'
                obj = dsConferenceTrial.Tables("conference_trial").Rows(0)("terms")
                htMeeting.Item("&#ApplyTerm") = CDbl(obj + "0") & "月"
            End If

            '会议审核担保期限（如是保函，则为日期期间）
            If dtpGuarantStartDate.Visible Then  '表示当前选择的是保函品种  
                htMeeting.Item("&#Term") = "有效日期" & Format(DateTime.Parse(infoRow("guarant_start_date")), "yyyy-MM-dd") & _
                                "至" & Format(DateTime.Parse(infoRow("guarant_end_date")), "yyyy-MM-dd")
            Else
                htMeeting.Item("&#Term") = infoRow("terms") & "月"
            End If

            '保费费率
            obj = infoRow("guarantee_rate")
            Dim strTemp As String = ""
            strTemp = obj & ""
            htMeeting.Item("&#RateGuaranteeFee") = IIf(strTemp = "", 0, strTemp) & "%" & _
                                    IIf(txtGuarantyFee.Text = "", "", "(" & txtGuarantyFee.Text & "元)") _
                                    & IIf(txtRateRemark.Text = String.Empty, "", "(" & txtRateRemark.Text & ")")

            '评审费
            obj = infoRow("trial_rate")
            strTemp = obj & ""
            htMeeting.Item("&#TrialFee") = IIf(strTemp = "", 0, strTemp) & "%" & _
                                    IIf(txtReviewFee.Text = "", "", "(" & txtReviewFee.Text & "元)")

            If isBaoHan Then '为保函
                htMeeting.Item("&#1Item") = "保函种类"
                htMeeting.Item("&#1ContentItem") = cboBaoHanType.Text
                htMeeting.Item("&#2Item") = "偿付责任类型"
                htMeeting.Item("&#2ContentItem") = cboRebetType.Text
                htMeeting.Item("&#Deposit") = IIf(txtGuaranteeScale.Text = "", 0, txtGuaranteeScale.Text) & "%(" & _
                                                  IIf(txtScaleMoney.Text = "", "0", txtScaleMoney.Text) & "元)"
                htMeeting.Item("&#SpecialLabel") = "中心评委签字"
                If txtRemainLetter.Text <> String.Empty Then
                    htMeeting.Item("&#balanceSum") = "剩余额度 " & txtRemainLetter.Text & "(万元)"
                Else
                    Dim dsLetter As DataSet = gWs.GetGuaranteeLetter(ProjectCode.Substring(0, 5), DateTime.Parse(txtApplyDate.Text).Date)
                    If dsLetter.Tables("TGuaranteeLetter").Rows.Count > 0 Then
                        htMeeting.Item("&#balanceSum") = "剩余额度 " & IIf(IsDBNull(dsLetter.Tables("TGuaranteeLetter").Rows(0)("remnant_line")), 0, _
                                            dsLetter.Tables("TGuaranteeLetter").Rows(0)("remnant_line")).ToString & "(万元)"
                    Else
                        htMeeting.Item("&#balanceSum") = String.Empty
                    End If
                    dsLetter.Dispose()
                End If
            Else
                Dim strRemark As String = ""
                '放款方式                
                htMeeting.Item("&#1Item") = "放款方式"
                obj = infoRow("loan_provide_form")
                strTemp = obj & ""
                '放款方式说明
                obj = infoRow("loan_form_remark")
                strRemark = obj & ""
                htMeeting.Item("&#1ContentItem") = strTemp & IIf(strRemark = "", "", "(" & strRemark & ")") '放款方式内容

                '还款方式
                htMeeting.Item("&#2Item") = "还款方式"
                '还款方式说明
                obj = infoRow("refund_type_remark")
                strRemark = obj & ""
                obj = infoRow("refund_type")
                strTemp = obj & ""
                If Not IsDBNull(obj) Then '如果还款方式不为空
                    Dim RefundSumAverage As Object = infoRow("refund_sum_average")
                    htMeeting.Item("&#2ContentItem") = strTemp & "(每次还款额：" & CDbl(RefundSumAverage + "0") & "元)" & IIf(strRemark = "", "", "(" & strRemark & ")")
                Else
                    htMeeting.Item("&#2ContentItem") = strTemp & IIf(strRemark = "", "", "(" & strRemark & ")")
                End If
                '保证金
                htMeeting.Item("&#Deposit") = String.Empty
                htMeeting.Item("&#SpecialLabel") = "评审顾问"
                htMeeting.Item("&#balanceSum") = String.Empty
            End If
            '备注
            obj = infoRow("Remark")
            htMeeting.Item("&#Remark") = obj & ""
            '评审结论
            obj = infoRow("trial_conclusion")
            htMeeting.Item("&#Conclusion") = obj & ""
            '推荐合作区
            htMeeting.Item("&#Cooperation") = IIf(chkPartner.Checked, cboPartner.Text, "无")
            '''''''''''''''反担保措施'''''''''''''''          
            htMeeting.Item("&#AGuarantyMeasure") = String.Empty 'GetGuaranteeFormDescription() 'strGuaranty
            htMeeting.Item("&#BGuarantyMeasure") = String.Empty
            htMeeting.Item("&#CGuarantyMeasure") = String.Empty
            Dim strGuaranty As String = GetGuaranteeFormDescription()
            If strGuaranty.Length > 500 Then
                htMeeting.Item("&#AGuarantyMeasure") = strGuaranty.Substring(0, 250)
                htMeeting.Item("&#BGuarantyMeasure") = strGuaranty.Substring(249, 250)
                htMeeting.Item("&#CGuarantyMeasure") = strGuaranty.Substring(498)
            ElseIf strGuaranty.Length > 250 Then
                htMeeting.Item("&#AGuarantyMeasure") = strGuaranty.Substring(0, 250)
                htMeeting.Item("&#BGuarantyMeasure") = strGuaranty.Substring(249)
            Else
                htMeeting.Item("&#AGuarantyMeasure") = strGuaranty
            End If
            '''''''''''''''反担保措施 END'''''''''''''''
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        Dim key() As String
        Dim value As ArrayList = New ArrayList
        Dim k As Integer = 0
        ReDim key(htMeeting.Count - 1)
        Dim ItemList As IDictionaryEnumerator = htMeeting.GetEnumerator
        While ItemList.MoveNext
            key(k) = ItemList.Key
            value.Add(ItemList.Value)
            k += 1
        End While
        Try
            Dim ofrm1 As frmDocumentManageBusiness
            ofrm1 = New frmDocumentManageBusiness(ProjectCode, TaskID, CorporationName, "45", "011", UserName, key, value)
            ofrm1.AllowTransparency = False
            ofrm1.StartPosition = FormStartPosition.CenterScreen
            ofrm1.ShowDialog()
        Catch ex As Exception
            'ExceptionHandler.ShowMessageBox(ex)
            SWDialogBox.MessageBox.Show("*999", "调用文档管理页面发生错误", ex.Source, ex.Message)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub ReplaceFlag(ByRef ht As Hashtable, ByVal prefix As String, ByVal suffix As String, ByVal content As String, ByVal maxIndex As Int32)
        content = replaceExt(content)
        content = IIf(content Is Nothing, String.Empty, content)
        Dim MaxCount As Int32 = Math.Ceiling(content.Length / 250)
        Dim i As Int32
        For i = MaxCount + 1 To maxIndex
            ht.Item(prefix & i.ToString & suffix) = String.Empty
        Next
        For i = 1 To MaxCount
            If i = MaxCount Then
                ht.Item(prefix & i.ToString & suffix) = content.Substring((i - 1) * 250)
            Else
                ht.Item(prefix & i.ToString & suffix) = content.Substring((i - 1) * 250, 250)
            End If
        Next
    End Sub

    Private Function replaceExt(ByVal strContent As String)
        'Chr(10) 代表换行符
        'Chr(13) 代表回车符
        Try
            Dim flag As String = Chr(13).ToString
            strContent = Replace(strContent, Chr(10), flag)
            If InStr(strContent, Chr(10)) <> 0 Then
                replaceExt(strContent)
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Return strContent
    End Function

    '返回反担保物措施字符串
    Private Function GetGuaranteeFormDescription() As String
        Dim drvAdd As DataRow
        Dim rowsAdd() As DataRow
        Dim strAdd As String '组合附加反担保物措施的字符串
        Dim dr As DataRow
        Dim i As Int32
        Dim strGuaranty As String = String.Empty : i = 1
        For Each dr In dsGuaForm.Tables("TProjectGuaranteeForm").Rows
            If CBool(dr("is_used")) Then  '反担保物采用
                If (Not dr.IsNull("guaranty")) Then '为汽车、房地产之类的反担保物
                    strAdd = String.Empty '先赋为空串
                    '如果额外方式不为空
                    If dsAdditionalForm Is Nothing Then
                        dsAdditionalForm = gWs.GetProjectGuaranteeFormAdd("{project_code LIKE '" & ProjectCode & "'}") '获取数据集
                    End If
                    rowsAdd = dsAdditionalForm.Tables(0).Select("guarantee_form='" & dr("guarantee_form").ToString & "' AND guaranty='" & dr("guaranty").ToString & "'")
                    For Each drvAdd In rowsAdd
                        strAdd += IIf(strAdd = String.Empty, drvAdd("additional_guarantee_form").ToString, "，" & drvAdd("additional_guarantee_form").ToString)
                    Next
                End If
                strGuaranty += i & "、" & dr("description").ToString & Chr(13) & IIf(strAdd = String.Empty, "", "（附加措施：" & strAdd & "）" & Chr(13))
                i += 1
            End If
        Next
        Return strGuaranty
    End Function
    Private dsStaffRole As DataSet

    '项目审批表(会签报告) "45"："006"
    Private Sub btnJoinReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnJoinReport.Click
        Try  '''''生成哈希表
            If dsStaffRole Is Nothing Then
                dsStaffRole = New DataSet
                dsStaffRole = gWs.GetStaffByRoleID("%")
            End If
            If dsProInfo Is Nothing Then
                'dsProInfo = New DataSet()
                dsProInfo = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
                If dsProInfo Is Nothing Then
                    MessageBox.Show("获取项目信息出错，没有记录")
                    Return
                End If
            End If
            Dim drMan As DataRow = dsProInfo.Tables(0).Rows(0)
            If htJoin Is Nothing Then
                htJoin = New Hashtable
                htJoin.Add("&#MA", drMan("24") & "")
                htJoin.Add("&#MB", drMan("25") & "")
                htJoin.Add("&#Date", SystemDate.Date.ToString("yyyy/M/d"))
                htJoin.Add("&#Number", ProjectCode)
            End If
            htJoin.Item("&#Corporation") = txtNewName.Text
            Dim drInfo As DataRow = dsPro.Tables(0).Rows(0)
            htJoin.Item("&#Money") = (drInfo("apply_sum") + "0") & "万元"
            htJoin.Item("&#Term") = (drInfo("apply_term") + "0") & "月"
            htJoin.Item("&#Bank") = cmbxApplyBank.Text
            htJoin.Item("&#SubBank") = cmbxSubBank.Text

            Dim strRoleID() As String = {"12", "21", "31", "40", "01"}
            Dim var() As String = {"&#ConsultOpinion", "&#VouchOpinion", "&#RiskOpinion", "&#TotalOpinion", "&#DirectorOpinion"}
            Dim dr As DataRow
            Dim i As Integer
            For i = 0 To var.Length - 1
                htJoin.Item(var(i)) = String.Empty
            Next
            For i = 0 To strRoleID.Length - 1
                For Each dr In dsConferenceTrial.Tables("committeeman_opinion").Rows
                    If dsStaffRole.Tables(0).Select("staff_name LIKE '" & CStr(dr("committeeman")) & "' AND role_id LIKE '" & strRoleID(i) & "'").Length > 0 Then
                        htJoin.Item(var(i)) = dr("opinion") & ""
                    End If
                Next
            Next
            '''''''''''''''反担保措施'''''''''''''''
            htJoin.Item("&#AGuarantyMeasure") = String.Empty 'GetGuaranteeFormDescription() 'strGuaranty
            htJoin.Item("&#BGuarantyMeasure") = String.Empty
            htJoin.Item("&#CGuarantyMeasure") = String.Empty
            Dim strGuaranty As String = GetGuaranteeFormDescription()
            If strGuaranty.Length > 500 Then
                htJoin.Item("&#AGuarantyMeasure") = strGuaranty.Substring(0, 250)
                htJoin.Item("&#BGuarantyMeasure") = strGuaranty.Substring(249, 250)
                htJoin.Item("&#CGuarantyMeasure") = strGuaranty.Substring(498)
            ElseIf strGuaranty.Length > 250 Then
                htJoin.Item("&#AGuarantyMeasure") = strGuaranty.Substring(0, 250)
                htJoin.Item("&#BGuarantyMeasure") = strGuaranty.Substring(249)
            Else
                htJoin.Item("&#AGuarantyMeasure") = strGuaranty
            End If
            '''''''''''''''反担保措施 END'''''''''''''''
            '评审意见            
            Dim obj As Object = dsConferenceTrial.Tables("conference_trial").Rows(0)("trial_conclusion")
            htJoin.Item("&#Conclusion") = obj & ""
            obj = dsConferenceTrial.Tables("conference_trial").Rows(0)("Remark")
            htJoin.Item("&#TrialOpinion") = obj & ""
            htJoin.Item("&#SubDirectorOpinion") = String.Empty
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", "生成标记值发生错误", ex.Source, ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        Dim key() As String
        Dim value As ArrayList = New ArrayList
        Dim k As Integer = 0
        ReDim key(htJoin.Count - 1)
        Dim ItemList As IDictionaryEnumerator = htJoin.GetEnumerator
        While ItemList.MoveNext
            key(k) = ItemList.Key
            value.Add(ItemList.Value)
            k += 1
        End While
        Try
            Dim ofrm2 As frmDocumentManageBusiness
            ofrm2 = New frmDocumentManageBusiness(ProjectCode, TaskID, CorporationName, "45", "006", UserName, key, value)
            ofrm2.AllowTransparency = False
            ofrm2.StartPosition = FormStartPosition.CenterScreen
            ofrm2.ShowDialog()
        Catch ex As Exception
            'ExceptionHandler.ShowMessageBox(ex)
            SWDialogBox.MessageBox.Show("*999", "调用文档管理页面发生错误", ex.Source, ex.Message)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    '项目否定意见表( 45 013)
    Private Sub PrintDenyOpinion(ByVal sender As Object, ByVal e As EventArgs)
        Try
            Me.Cursor = Cursors.WaitCursor
            If htDeny Is Nothing Then
                If dsProInfo Is Nothing Then
                    'dsProInfo = New DataSet()
                    dsProInfo = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
                    If dsProInfo Is Nothing Then
                        MessageBox.Show("获取项目信息出错，没有记录")
                        Return
                    End If
                End If
                htDeny = New Hashtable
                htDeny.Add("&#Number", ProjectCode)
                htDeny.Add("&#Date", txtDate.Text)
                htDeny.Add("&#Times", txtTimes.Text)
                htDeny.Add("&#ID", txtDate.Text)
                '''''项目角色信息''''''''''''''''''                
                Dim drMan As DataRow = dsProInfo.Tables(0).Rows(0)
                htDeny.Add("&#MA", drMan("24") & "")
                htDeny.Add("&#MB", drMan("25") & "")
                htDeny.Add("&#LawManager", drMan("33") & "")
                '''''与会人员'''''''''''''''''''''
                Dim i As Integer
                Dim strPeople As String = String.Empty
                Dim dt As DataTable = CType(dgOpinion.DataSource, DataSet).Tables(dgOpinion.DataMember)
                For i = 0 To dt.Rows.Count - 1
                    strPeople += CStr(dt.Rows(i)("committeeman")) & "  "
                Next
                If strPeople <> String.Empty Then
                    strPeople = strPeople.Substring(0, strPeople.Length - 1)
                End If
                htDeny.Add("&#People", strPeople)
                ''''''''与会人员 END'''''''''''''''''''''                
            End If
            ''''''''''''项目信息'''''''''''''''''''''
            Dim drInfo As DataRow = dsPro.Tables(0).Rows(0)
            htDeny.Item("&#Corporation") = txtNewName.Text
            htDeny.Item("&#Area") = cmbxArea.Text
            htDeny.Item("&#ApplyServiceType") = drInfo("apply_service_type") & ""
            htDeny.Item("&#ApplySum") = (drInfo("apply_sum") + "0") & "万元"
            htDeny.Item("&#ApplyTerm") = (drInfo("apply_term") + "0") & "月"
            htDeny.Item("&#Bank") = cmbxApplyBank.Text
            htDeny.Item("&#SubBank") = cmbxSubBank.Text
            '''''''''''评 审 会 评 审 意 见'''''''''''''''
            Dim obj As Object = dsConferenceTrial.Tables("conference_trial").Rows(0)("trial_conclusion")
            htDeny.Item("&#Conclusion") = obj & ""
            obj = dsConferenceTrial.Tables("conference_trial").Rows(0)("Remark")
            htDeny.Item("&#Remark") = obj & ""
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", "生成标记值发生错误", ex.Source, ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        Dim key() As String
        Dim value As ArrayList = New ArrayList
        Dim k As Integer = 0
        ReDim key(htDeny.Count - 1)
        Dim ItemList As IDictionaryEnumerator = htDeny.GetEnumerator
        While ItemList.MoveNext
            key(k) = ItemList.Key
            value.Add(ItemList.Value)
            k += 1
        End While
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ofrm3 As frmDocumentManageBusiness
            ofrm3 = New frmDocumentManageBusiness(ProjectCode, TaskID, CorporationName, "45", "013", UserName, key, value)
            ofrm3.AllowTransparency = False
            ofrm3.ShowDialog()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", "调用文档管理页面发生错误", ex.Source, ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
#End Region

    Private Sub btnDetailInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetailInfo.Click
        Dim ofrmShowProjectInfo As frmShowProjectInfo = New frmShowProjectInfo(ProjectCode, CorporationName)
        ofrmShowProjectInfo.AllowTransparency = False
        ofrmShowProjectInfo.ShowDialog()
    End Sub

    Private Sub nudTerms_ValueChanged(ByVal sender As Object, ByVal e As EventArgs) Handles nudTerms.ValueChanged
        cmbxRefundtype_SelectionChangeCommitted(sender, e)
        txtGuarantyFeeStandard_Leave(Nothing, Nothing)
    End Sub

    Private Sub Object_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtOpinion.Enter
        Money.SetObjTag(sender)
    End Sub
    Private Sub Object_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtOpinion.Leave
        If Not DataChanged Then   '确保正确判断数据是否已修改
            DataChanged = Money.IsChanged(sender)
        End If
    End Sub
    Private Sub AddHandlerToObjs()
        Dim obj As Control
        For Each obj In gpbxInfo.Controls
            AddHandler obj.Enter, AddressOf Object_Enter
            AddHandler obj.Leave, AddressOf Object_Leave
        Next
        For Each obj In gpbxConclusion.Controls
            AddHandler obj.Enter, AddressOf Object_Enter
            AddHandler obj.Leave, AddressOf Object_Leave
        Next
        '不能直接调用Conclusion_IndexChanged方法，因为这时DataChanged并不为true
        If cmbxConclusion.Text <> String.Empty Then
            Dim isPass As Boolean = cmbxConclusion.Text.IndexOf(denyText) < 0 'cmbxConclusion.Text.IndexOf("暂缓") < 0
            btnPrintReport.Tag = IIf(isPass, "approval", "deny")
            'btnPrintReport.Text = IIf(isPass, "评审意见表(&P)", "否定意见表(&D)")
        End If
        AddHandler cmbxConclusion.SelectedIndexChanged, AddressOf Conclusion_IndexChanged
    End Sub
    Private Sub Conclusion_IndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If cmbxConclusion.Text <> String.Empty Then
            Dim isPass As Boolean = cmbxConclusion.Text.IndexOf(denyText) < 0  'cmbxConclusion.Text.IndexOf("暂缓") < 0 
            btnPrintReport.Tag = IIf(isPass, "approval", "deny")
            'btnPrintReport.Text = IIf(isPass, "评审意见表(&P)", "否定意见表(&D)")
        End If
    End Sub

    Private Sub TabControl_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        cmbxConclusion.SelectedValue = IIf(cmbxConclusion.Tag Is Nothing, DBNull.Value, cmbxConclusion.Tag)
        cmbxServiceType.SelectedValue = IIf(cmbxServiceType.Tag Is Nothing, DBNull.Value, cmbxServiceType.Tag)
        ShowAdditionalForm() '显示额外方式
    End Sub

#Region "项目合作区"
    Private Sub BindInfoOfPartner()
        If bmBureau.Count > 0 Then
            cboPartner.Text = CType(bmBureau.Current, DataRowView)("cooperate_organization") & ""
            txtPartnerOpnion.Text = CType(bmBureau.Current, DataRowView)("opinion") & ""
            txtPartnerMoney.Text = CType(bmBureau.Current, DataRowView)("recommend_sum") & ""
            dtpPartnerDate.Value = CType(bmBureau.Current, DataRowView)("recommend_date")
            'If dtpPartnerDate.DataBindings.Count = 0 Then
            '    cboPartner.DataBindings.Add("Text", dsBureau, "cooperate_organization_opinion.cooperate_organization")
            '    txtPartnerOpnion.DataBindings.Add("Text", dsBureau, "cooperate_organization_opinion.opinion")
            '    txtPartnerMoney.DataBindings.Add("Text", dsBureau, "cooperate_organization_opinion.recommend_sum")
            '    dtpPartnerDate.DataBindings.Add("Value", dsBureau, "cooperate_organization_opinion.recommend_date")
            'End If
            'Else
            '    dtpPartnerDate.DataBindings.Clear()
            '    txtPartnerMoney.DataBindings.Clear()
            '    txtPartnerOpnion.DataBindings.Clear()
            '    cboPartner.DataBindings.Clear()
        End If
    End Sub

    Private Sub chkPartner_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles chkPartner.CheckedChanged
        cboPartner.Enabled = chkPartner.Checked
        txtPartnerMoney.Enabled = chkPartner.Checked
        dtpPartnerDate.Enabled = chkPartner.Checked
        txtPartnerOpnion.Enabled = chkPartner.Checked
    End Sub

    Private Sub SavePartner()
        If Not cboPartner.Enabled Or cboPartner.Text = String.Empty Then
            If dsBureau.Tables("cooperate_organization_opinion").Select("", "", DataViewRowState.CurrentRows).Length > 0 Then
                dsBureau.Tables("cooperate_organization_opinion").Select("", "", DataViewRowState.CurrentRows)(0).Delete()
            End If
        ElseIf dsBureau.Tables("cooperate_organization_opinion").Rows.Count = 0 Then             '并没选上合作区局
            Dim dr As DataRow = dsBureau.Tables("cooperate_organization_opinion").NewRow
            With dr
                .Item("project_code") = ProjectCode
                .Item("cooperate_organization") = cboPartner.Text
                .Item("recommend_sum") = MyIIf(txtPartnerMoney.Text, GetType(Double), DBNull.Value)
                .Item("opinion") = txtPartnerOpnion.Text
                .Item("recommend_date") = dtpPartnerDate.Value.Date
                .Item("create_person") = UserName
                .Item("create_date") = SystemDate.Date
            End With
            dsBureau.Tables("cooperate_organization_opinion").Rows.Add(dr)
        Else
            With dsBureau.Tables("cooperate_organization_opinion").Rows(0)
                .Item("cooperate_organization") = cboPartner.Text
                .Item("recommend_sum") = IIf(txtPartnerMoney.Text = String.Empty, DBNull.Value, txtPartnerMoney.Text)
                .Item("opinion") = txtPartnerOpnion.Text
                .Item("recommend_date") = dtpPartnerDate.Value.Date
            End With
        End If
        bmBureau.EndCurrentEdit()
        If Not dsBureau.HasChanges Then '没变化则回退
            Return
        End If
        Dim result As String = gWs.UpdateCooperateOpinion(dsBureau.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存合作区局失败", result, "")
        Else
            dsBureau.AcceptChanges()
        End If
        'BindInfoOfPartner()
    End Sub
#End Region

    ' 拆分项目
    Private Sub btnSplitProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSplitProject.Click
        '建立新的项目编码，copy申请信息，反担保物措施的具体信息，会议评审记录
        'dsGuaSubmit，表opposite_guarantee：opposite_guarantee_detail
        '个人保证   dsPerson.Tables("opposite_guarantee_assurer")   注意其中加了一列"is_used"
        '企业保证   dsProCor.Tables("TProjectCorporation")   注意其中加了一列"is_used"
        'project表 conference_trial表
        If SWDialogBox.MessageBox.Show("?1000", "拆分项目") = DialogResult.No Then Return
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.SaveEvent(Nothing, Nothing)
            '获得原来的项目在project表的记录
            Dim dsProject As DataSet = gWs.GetProjectInfo("{project_code LIKE '" & Me.ProjectCode & "'}")
            If dsProject.Tables.Count = 0 OrElse dsProject.Tables(0).Rows.Count = 0 Then
                SWDialogBox.MessageBox.Show("*999", "当前项目在project表没记录", "", "")
                Return
            End If
            Dim CorporationCode As String = dsProject.Tables(0).Rows(0)("corporation_code")
            '产生新的项目编码,产生新的项目记录并保存
            Dim newPC As String = gWs.GetProjectCode(CorporationCode)
            Dim newProjectDataRow As DataRow = dsProject.Tables(0).NewRow
            newProjectDataRow.ItemArray = dsProject.Tables(0).Rows(0).ItemArray
            newProjectDataRow("project_code") = newPC
            newProjectDataRow("apply_date") = SystemDate.Date
            newProjectDataRow("create_person") = UserName
            newProjectDataRow("create_date") = SystemDate.Date
            dsProject.Tables(0).Rows.Add(newProjectDataRow)
            Dim result As String = gWs.UpdateProject(dsProject.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "产生新的项目失败", result, "")
                Return
            End If
            dsProject = Nothing
            '将原项目的所有反担保物措施复制到新的面目中去
            Dim newDsGuanranty As DataSet = gWs.GetGuarantyInfo("{project_code LIKE '" & newPC & "'}", "{project_code LIKE '" & newPC & "'}")
            Dim dr, ndr As DataRow
            For Each dr In dsGuaSubmit.Tables("opposite_guarantee").Rows
                ndr = newDsGuanranty.Tables("opposite_guarantee").NewRow
                ndr.ItemArray = dr.ItemArray
                ndr("project_code") = newPC
                newDsGuanranty.Tables("opposite_guarantee").Rows.Add(ndr)
            Next
            For Each dr In dsGuaSubmit.Tables("opposite_guarantee_detail").Rows
                ndr = newDsGuanranty.Tables("opposite_guarantee_detail").NewRow
                ndr.ItemArray = dr.ItemArray
                ndr("project_code") = newPC
                newDsGuanranty.Tables("opposite_guarantee_detail").Rows.Add(ndr)
            Next
            result = gWs.UpdateGuaranty(newDsGuanranty.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "复制原项目的反担保物记录到新项目时出错", result, "")
                Return
            End If
            newDsGuanranty = Nothing
            '将原项目的个人保证复制到新的项目中去
            Dim dsPersonTem, dsProCorTem As DataSet
            dsPersonTem = New DataSet
            dsPersonTem = dsPerson.Copy
            dsPersonTem.Tables(0).Columns.Remove(dsPersonTem.Tables(0).Columns("is_used"))
            Dim dsPersonNew As DataSet = gWs.GetOppositeGuaranteeAssurerInfo("{project_code LIKE '" & newPC & "'}")
            For Each dr In dsPersonTem.Tables(0).Rows
                ndr = dsPersonNew.Tables(0).NewRow
                ndr.ItemArray = dr.ItemArray
                ndr("project_code") = newPC
                dsPersonNew.Tables(0).Rows.Add(ndr)
            Next
            result = gWs.UpdateOppositeGuaranteeAssurer(dsPersonNew.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "复制原项目的个人保证到新项目时出错", result, "")
                Return
            End If
            dsPersonNew = Nothing : dsPersonTem = Nothing
            '将原项目的企业保证复制到新的项目中去
            dsProCorTem = New DataSet
            dsProCorTem = dsProCor.Copy
            dsProCorTem.Tables("TProjectCorporation").Columns.Remove(dsProCorTem.Tables("TProjectCorporation").Columns("is_used"))
            Dim dsProCorNew As DataSet = gWs.FetchProjectCorporation(newPC, "%", "2", "%")
            For Each dr In dsProCorTem.Tables("TProjectCorporation").Rows
                ndr = dsProCorNew.Tables("TProjectCorporation").NewRow
                ndr.ItemArray = dr.ItemArray
                ndr("project_code") = newPC
                dsProCorNew.Tables("TProjectCorporation").Rows.Add(ndr)
            Next
            result = gWs.UpdateProjectCorporation(dsProCorNew.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "复制原项目的企业保证到新项目时出错", result, "")
                Return
            End If
            dsProCorTem = Nothing : dsProCorNew = Nothing
            '对新的项目产生新的项目会议评审记录
            Dim dsConTrialNew As DataSet = gWs.GetConfTrialInfo("{project_code LIKE '" & newPC & "' ORDER BY trial_times DESC}", "{project_code LIKE '" & newPC & "'}")
            If dsConTrialNew.Tables("conference_trial").Rows.Count < Me.TrialTimes Then '即没有本次记录
                ndr = dsConTrialNew.Tables("conference_trial").NewRow
                ndr("project_code") = newPC
                ndr("trial_times") = 1
                ndr("conference_code") = Me.ConCode
                ndr("prime_committeeman") = Me.MainDelegate
                ndr("serial_num") = CType(Me.bmConclusion.Current, DataRowView)("serial_num")
                ndr("status") = False
                ndr("create_person") = UserName
                ndr("create_date") = SystemDate
                dsConTrialNew.Tables("conference_trial").Rows.Add(ndr)
                'committeeman_opinion   复制会议评委意见
                For Each dr In CType(Me.dgOpinion.DataSource, DataSet).Tables(Me.dgOpinion.DataMember).Rows
                    ndr = dsConTrialNew.Tables("committeeman_opinion").NewRow
                    ndr("committeeman") = dr("committeeman")
                    ndr("role_id") = dr("role_id")
                    ndr("opinion") = dr("opinion")
                    ndr("project_code") = newPC
                    ndr("trial_times") = 1
                    ndr("create_person") = UserName
                    ndr("create_date") = SystemDate
                    dsConTrialNew.Tables("committeeman_opinion").Rows.Add(ndr)
                Next
                result = gWs.UpdateConfTrial(dsConTrialNew.GetChanges)
                If result <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "产生新项目的会议评审记录出错", result, "")
                    Return
                End If
                dsConTrialNew = Nothing
            End If
            Dim ofrm As frmMeetingRecordExp = New frmMeetingRecordExp(False, True, Me.ProjectCode)
            ofrm.OpenApplyTool(newPC, CorporationName, WorkFlowID, TaskID, Me, UserName)

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try


    End Sub

#Region "保函信息 Added by LQF at 2003-11-26"
    '当保函种类为综合授信时,先是DataGrid,数据院是表guarantee_letter
    Private Sub AddTableStyleOfGuaranteeLetterUsage()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle
        dgts.MappingName = "TGuaranteeLetterUsage"

        Dim col1 As DataGridComboBoxColumn = New DataGridComboBoxColumn
        '来自数据库表guarantee_letter_type
        col1.MappingName = "guarantee_letter_type"  '保函种类编码
        col1.HeaderText = "保函种类"
        col1.Width = 100
        col1.ColumnComboBox.DataSource = dsGuaranteeLetterType.Tables("TGuaranteeLetterType").DefaultView
        col1.ColumnComboBox.DisplayMember = "name"
        col1.ColumnComboBox.ValueMember = "type_code"

        Dim col2 As DataGridComboBoxColumn = New DataGridComboBoxColumn
        col2.HeaderText = "偿付责任类型"
        '来自数据库表reimburse_type
        col2.MappingName = "reimburse_type"     '偿付责任类型编码        
        col2.ColumnComboBox.DataSource = dsReimburseType.Tables("TReimburseType").DefaultView
        col2.ColumnComboBox.DisplayMember = "name"
        col2.ColumnComboBox.ValueMember = "type_code"
        col2.Width = 100

        Dim col2_1 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col2_1.MappingName = "term"     '期限
        col2_1.HeaderText = "期限(月)"
        col2_1.TextBox.MaxLength = 18
        col2_1.NullText = String.Empty
        col2_1.Width = 75

        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col3.MappingName = "guarantee_rate"     '担保费率
        col3.HeaderText = "担保费费率(%)"
        col3.TextBox.MaxLength = 18
        col3.Format = "n" : col3.NullText = String.Empty
        col3.Width = 100
        AddHandler col3.TextBox.Enter, AddressOf Money_Enter
        AddHandler col3.TextBox.KeyPress, AddressOf LetterDataGridColumnKeyPress
        AddHandler col3.TextBox.Leave, AddressOf Money_Leave

        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col4.MappingName = "guarantee_scale"    '保证金比例
        col4.HeaderText = "保证金比例(%)"
        col4.TextBox.MaxLength = 18
        col4.Format = "n"
        col4.Width = 100 : col4.NullText = String.Empty
        AddHandler col4.TextBox.Enter, AddressOf Money_Enter
        AddHandler col4.TextBox.KeyPress, AddressOf LetterDataGridColumnKeyPress
        AddHandler col4.TextBox.Leave, AddressOf Money_Leave

        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col2_1, col3, col4})
        dgIntegrate.TableStyles.Clear()
        dgIntegrate.TableStyles.Add(dgts)
    End Sub
    Private Sub LetterDataGridColumnKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        DataChanged = True
    End Sub

    Private Function ReturnLetterType() As Integer
        '0表示单笔保函,1 表示综合授信， 2表示额度项下保函
        '如果是单笔保函,则担保费费率、担保费金额、保证金比例、保证金金额从会议评审记录表,不需要显示剩余额度、额度到期日
        '额度向下保函,
        Dim strServiceType As String = cmbxServiceType.SelectedValue & ""
        If strServiceType.IndexOf("保函综合授信") > -1 Then
            dsGuaranteeLetter = gWs.GetGuaranteeLetter("{project_code LIKE '" & ProjectCode & "'}")
            Return 1
        ElseIf strServiceType.IndexOf("保函") > -1 Then
            dsGuaranteeLetter = gWs.GetGuaranteeLetter(ProjectCode.Substring(0, 5), DateTime.Parse(txtApplyDate.Text).Date)
            If dsGuaranteeLetter.Tables(0).Rows.Count > 0 Then
                Return 2
            Else
                Return 0
            End If
        End If
        Return -1
    End Function
#End Region

    Private dsBankCopy As DataSet
    Private dsReimburseType As DataSet
    Private dsGuaranteeLetterType As DataSet
    Private dsGuaranteeLetter As DataSet
    Private dsGuaranteeLetterUsage As DataSet
    Private cmGuaranteeLetterUsage As CurrencyManager
    Private BaoHanType As Integer   '具体的保函业务品种
    'isPass表示评审会意见为非暂缓，isShouXin表示是否综合授信品种
    Private Sub SetSomeControlEnabledFromServiceType(ByVal isPass As Boolean, ByVal isShouXin As Boolean)
        Dim isBaoHan As Boolean = "06,08".IndexOf(Me.GetServicetypeCode) >= 0 '(CStr(cmbxServiceType.SelectedValue & "").IndexOf("保函") > -1)
        cmbxRefundtype.Enabled = Not isBaoHan And isPass
        cmbxLoanForm.Enabled = Not isBaoHan And isPass
        txtReviewFeeStandard.Enabled = Not isBaoHan And isPass
        txtLoanRemark.Enabled = Not isBaoHan And isPass
        txtReturnRemark.Enabled = Not isBaoHan And isPass
        txtEachReturnFee.Enabled = Not isBaoHan And isPass
        'txtRateRemark.Enabled = Not isBaoHan And isPass
        '保证金比例是保函品种所有的
        cboRunMode.Enabled = isBaoHan And isPass And Not isShouXin '非综合授信的保函才为true
        cboLetterBank.Enabled = isBaoHan And isPass
        cboLetterSubBank.Enabled = cboLetterBank.Enabled
        If cboRunMode.Enabled Then '让用户选择单笔或额度向下保函
            cboRunMode.DropDownStyle = ComboBoxStyle.DropDownList
            If cboRunMode.Tag Is Nothing Then
                cboRunMode.Text = dsConferenceTrial.Tables("conference_trial").Rows(0)("workflow") & ""
                'gpbDownLetter.Visible = (cboRunMode.SelectedIndex = 1)
                cboRunMode.Tag = String.Empty
            End If
        Else '不是保函品种，变返回业务品种的值
            cboRunMode.DropDownStyle = ComboBoxStyle.Simple
            cboRunMode.Text = cmbxServiceType.SelectedValue
        End If

        '2007-08-02 yjf edit 所有业务品种都可以收取保证金
        txtGuaranteeScale.Enabled = isPass
        'txtGuaranteeScale.Enabled = isBaoHan And isPass And Not isShouXin

        cboBaoHanType.Enabled = isBaoHan And isPass And Not isShouXin
        cboRebetType.Enabled = isBaoHan And isPass And Not isShouXin
        'gpbDownLetter.Visible = cboRebetType.Enabled '是否显示剩余额度和额度到期日
        txtGuarantyFeeStandard.Enabled = isPass And Not isShouXin
        btnNew.Enabled = isShouXin And isPass : btnDelete.Enabled = btnNew.Enabled
        dgIntegrate.Enabled = isShouXin And isPass
        If isBaoHan Then
            txtReviewFeeStandard.Text = String.Empty : Me.txtReviewFee.Text = String.Empty
        End If
        If isShouXin Then
            txtGuaranteeScale.Text = String.Empty : txtScaleMoney.Text = String.Empty
            txtGuarantyFeeStandard.Text = String.Empty : txtGuarantyFee.Text = String.Empty
        End If
        If (isBaoHan And Not isShouXin) Then '保函业务品种，期限改为两个下拉框选择
            nudTerms.Visible = False
            dtpGuarantStartDate.Visible = True
            dtpGuarantEndDate.Visible = True
            lblMonth.Location = New Point(dtpGuarantStartDate.Location.X + dtpGuarantStartDate.Width, lblMonth.Location.Y)
            lblMonth.Text = "至"
        ElseIf Not nudTerms.Visible Then
            nudTerms.Visible = True
            dtpGuarantStartDate.Visible = False
            dtpGuarantEndDate.Visible = False
            lblMonth.Location = New Point(nudTerms.Location.X + nudTerms.Width, lblMonth.Location.Y)
            lblMonth.Text = "(月)"
        End If
    End Sub

    Private Sub cboRunMode_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cboRunMode.SelectedIndexChanged
        If BaoHanType = 0 Then
            If cboRunMode.Text = "额度项下保函" Then
                '该企业只能做单笔保函，在此弹出对话框
                SWDialogBox.MessageBox.Show("$1003", "运作方式")
                cboRunMode.SelectedIndex = 0
            End If
        ElseIf BaoHanType = 2 Then '如果计算出来的是额度向下保函
            'gpbDownLetter.Visible = (cboRunMode.SelectedIndex = 1)
        End If
    End Sub

    Private Sub ServiceTypeChanged(ByVal sender As Object, ByVal e As EventArgs)
        If CStr(cmbxConclusion.SelectedValue & "").IndexOf(denyText) >= 0 Then '意见为否定
            SetSomeControlEnabledFromServiceType(False, False) '此方法必须在conference_trial表相关字段的值置为NULL之后调用
            Return
        End If
        If Not DataChanged Then '判断数据有没有改变
            DataChanged = Not cmbxServiceType.Tag Is Nothing AndAlso Not System.Object.Equals(cmbxServiceType.SelectedValue, cmbxServiceType.Tag)
        End If
        If Not cmbxServiceType.SelectedValue Is Nothing AndAlso System.Object.Equals(cmbxServiceType.SelectedValue, cmbxServiceType.Tag) Then
            Return '由于TabControl切换时会触发本事件，所以要判断
        End If
        If "06,08".IndexOf(Me.GetServicetypeCode) >= 0 Then '表示当前选择的是保函品种        
            If Not cmbxServiceType.Tag Is Nothing Then
                If SWDialogBox.MessageBox.Show("?1000", "（数据将丢失）") = DialogResult.No Then
                    cmbxServiceType.SelectedValue = cmbxServiceType.Tag
                    Return
                End If
                SetSomItemsDBNull(New String() {"terms", "loan_provide_form", "refund_type", "loan_form_remark", "refund_type_remark", "refund_sum_average", "guarantee_sum", "guarantee_rate", "guarantee_letter_type", "reimburse_type", "security_rate"})
                'cboBaoHanType.SelectedValue = DBNull.Value : cboRebetType.SelectedValue = DBNull.Value
            End If
            SetLabelTextFromServiceType(True, False)
            Try
                Me.Cursor = Cursors.WaitCursor
                If dsGuaranteeLetterType Is Nothing Then '绑定保函种类编号
                    dsGuaranteeLetterType = gWs.GetGuaranteeLetterType("%")
                    cboBaoHanType.DataSource = New DataView(dsGuaranteeLetterType.Tables(0))
                    cboBaoHanType.DisplayMember = "name"
                    cboBaoHanType.ValueMember = "type_code"
                    AddHandler cboBaoHanType.SelectionChangeCommitted, AddressOf cboBaoHanType_Changed
                    cboBaoHanType.DataBindings.Add("SelectedValue", dsConferenceTrial, "conference_trial.guarantee_letter_type")  '保函种类编码
                End If
                If dsReimburseType Is Nothing Then '绑定偿还责任类型编号
                    dsReimburseType = gWs.GetReimburseType("%")
                    cboRebetType.DataSource = New DataView(dsReimburseType.Tables(0))
                    cboRebetType.DisplayMember = "name"
                    cboRebetType.ValueMember = "type_code"
                    AddHandler cboRebetType.SelectionChangeCommitted, AddressOf cboRebetType_Changed
                    cboRebetType.DataBindings.Add("SelectedValue", dsConferenceTrial, "conference_trial.reimburse_type")  '偿付责任类型编码
                End If
                BaoHanType = ReturnLetterType()
                SetSomeControlEnabledFromServiceType(True, BaoHanType = 1) '要把某些控件置灰
                If BaoHanType = 1 Then '保函综合授信
                    dsGuaranteeLetterUsage = gWs.GetGuaranteeLetterUsage("{project_code LIKE '" & ProjectCode & "'}")
                    cmGuaranteeLetterUsage = Me.BindingContext(dsGuaranteeLetterUsage, "TGuaranteeLetterUsage")
                    dsGuaranteeLetterUsage.Tables("TGuaranteeLetterUsage").Columns("guarantee_rate").DefaultValue = 0
                    dsGuaranteeLetterUsage.Tables("TGuaranteeLetterUsage").Columns("guarantee_scale").DefaultValue = 0
                    dgIntegrate.SetDataBinding(dsGuaranteeLetterUsage, "TGuaranteeLetterUsage")
                    If dgIntegrate.TableStyles.Count = 0 Then
                        AddTableStyleOfGuaranteeLetterUsage()
                    End If
                    CType(cmGuaranteeLetterUsage.List, DataView).AllowNew = False
                    CType(cmGuaranteeLetterUsage.List, DataView).AllowDelete = False
                ElseIf BaoHanType = 2 Then '如果是额度向下保函
                    Dim curDr As DataRow = dsGuaranteeLetter.Tables(0).Rows(0)
                    dsGuaranteeLetterUsage = gWs.GetGuaranteeLetterUsage("{project_code LIKE '" & curDr("project_code") & "'}")
                    If txtRemainLetter.DataBindings.Count = 0 Then
                        txtRemainLetter.DataBindings.Add("Text", dsGuaranteeLetter, "TGuaranteeLetter.remnant_line")
                        Dim dateBinding As Binding = New Binding("Text", dsGuaranteeLetter, "TGuaranteeLetter.enddate")
                        txtEndDateLetter.DataBindings.Add(dateBinding)
                        AddHandler dateBinding.Format, AddressOf DateTimeFormat
                    End If
                End If
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            Finally
                Me.Cursor = Cursors.Default
            End Try

            '要把纪录的某些字段置为DBNull
            If cmbxServiceType.Tag Is Nothing Then
                cboBaoHanType.Tag = cboBaoHanType.SelectedValue
                cboRebetType.Tag = cboRebetType.SelectedValue
            End If
            bmConclusion.Position = bmConclusion.Position
            '如果是由保函品种变成非保函品种，也要弹出对话框
        ElseIf Not cmbxServiceType.Tag Is Nothing AndAlso "06,08".IndexOf(GetServicetypeCode(CStr(cmbxServiceType.Tag & ""))) >= 0 Then 'CStr(cmbxServiceType.Tag & "").IndexOf("保函") > -1 Then
            If SWDialogBox.MessageBox.Show("?1000", "（数据将丢失）") = DialogResult.No Then
                cmbxServiceType.SelectedValue = cmbxServiceType.Tag
                Return
            End If

            SetSomeControlEnabledFromServiceType(True, False)
            SetSomItemsDBNull(New String() {"guarantee_letter_type", "reimburse_type", "security_rate", "terms", "guarantee_sum", "guarantee_rate", "bank", "bank_branch"})
            txtGuaranteeScale.Text = String.Empty : cboLetterSubBank.SelectedValue = DBNull.Value
            bmConclusion.Position = bmConclusion.Position
            '赋评审费率，担保费率的默认值
            Dim drv As DataRowView = CType(cmbxServiceType.SelectedItem, DataRowView)
            txtReviewFeeStandard.Text = drv("review_fee_rate") & ""
            txtGuarantyFeeStandard.Text = drv("guarantee_fee_rate") & ""
            '判断是不是再担保品种
            If Me.GetServicetypeCode = "07" Then 'cmbxServiceType.SelectedValue.ToString.IndexOf("再担保") >= 0 Then
                SetLabelTextFromServiceType(False, True)
                txtReviewFeeStandard.Text = String.Empty '屏蔽评审费率
                txtReviewFeeStandard.Enabled = False
            Else
                SetLabelTextFromServiceType(False, False)
                txtReviewFeeStandard.Enabled = True
            End If
        ElseIf Not cmbxServiceType.SelectedItem Is Nothing Then '非保函品种            

            '业务品种改变时，评审费率，担保费率，评审费，担保费随之改变
            Dim drv As DataRowView = CType(cmbxServiceType.SelectedItem, DataRowView)
            txtReviewFeeStandard.Text = drv("review_fee_rate") & ""
            txtGuarantyFeeStandard.Text = drv("guarantee_fee_rate") & ""
            txtReviewFeeStandard_Leave(Nothing, Nothing)
            txtGuarantyFeeStandard_Leave(Nothing, Nothing)
            If cmbxServiceType.Tag Is Nothing Then
                SetSomeControlEnabledFromServiceType(True, False)
            End If
            '判断是不是再担保品种
            If Me.GetServicetypeCode = "07" Then 'cmbxServiceType.SelectedValue.ToString.IndexOf("再担保") >= 0 Then
                SetLabelTextFromServiceType(False, True)
                txtReviewFeeStandard.Text = String.Empty '屏蔽评审费率，评审费
                txtReviewFeeStandard.Enabled = False
            Else
                SetLabelTextFromServiceType(False, False)
                txtReviewFeeStandard.Enabled = True
            End If

            cboRunMode.Text = cmbxServiceType.SelectedValue
        End If
        cmbxServiceType.Tag = cmbxServiceType.SelectedValue
        dsConferenceTrial.Tables("conference_trial").Rows(bmConclusion.Position)("service_type") = IIf(cmbxServiceType.SelectedValue Is Nothing, DBNull.Value, cmbxServiceType.SelectedValue)
    End Sub

    '根据业务品种设置“担保金额”，“担保期限”的标签文本
    Private Sub SetLabelTextFromServiceType(ByVal isBaoHan As Boolean, ByVal isZaiDanBao As Boolean)
        txtReOrganizationName.Text = String.Empty '再担保时，担保机构名称
        txtReGuaranteeCondition.Text = String.Empty '再担保时条件 
        txtSourceGS.Value = DBNull.Value : txtSourceST.Value = DBNull.Value : txtSourceTerms.Value = DBNull.Value
        '先隐藏“保函”，“再担保”的信息框
        'gpxBaoHan.Visible = False
        'gpxReGuarantee.Visible = False
        If isBaoHan Then
            lblGuaranSumDescription.Text = "保函额度(万元)"
            lblTermDescription.Text = "保 函 期 限"
            lblGuaranteeFeeStandDesc.Text = "担保费标准(年)"
            lblGuaFeeDescription.Text = "担  保  费 (元)"
            'gpxBaoHan.Visible = True
        ElseIf isZaiDanBao Then
            lblGuaranSumDescription.Text = "再担保额度(万元)"
            lblTermDescription.Text = "再担保期限"
            lblGuaranteeFeeStandDesc.Text = "保  费  利  率"
            lblGuaFeeDescription.Text = "再 担 保 费(元)"

            '如果担保机构名称，再担保条件为空
            If txtReOrganizationName.Tag Is Nothing Then
                Dim dsTemp As DataSet = gWs.GetReGuaranteeProjectInfo("{ProjectCode LIKE '" & ProjectCode & "'}")
                If dsTemp.Tables(0).Rows.Count > 0 Then '将第一次获得的数据赋给tag属性，下次就不用读数据库了
                    txtReOrganizationName.Tag = dsTemp.Tables(0).Rows(0)("OrganizationName")    '担保机构名称
                    txtReGuaranteeCondition.Tag = dsTemp.Tables(0).Rows(0)("ReguaranteeCondition")  '担保机构的再担保条件
                    txtSourceGS.Tag = dsTemp.Tables(0).Rows(0)("SourceLoanSum") '源项目的担保金额
                    txtSourceTerms.Tag = dsTemp.Tables(0).Rows(0)("SourceLoanTerm") '源项目的担保期限
                    txtSourceST.Tag = dsTemp.Tables(0).Rows(0)("SourceServiceType") '源项目的担保业务品种
                End If
                dsTemp = Nothing
            End If
            txtReOrganizationName.Text = CStr(txtReOrganizationName.Tag & "")
            txtReGuaranteeCondition.Text = CStr(txtReGuaranteeCondition.Tag & "")
            txtSourceGS.Value = txtSourceGS.Tag
            txtSourceST.Value = txtSourceST.Tag
            txtSourceTerms.Value = txtSourceTerms.Tag
            '设置文本框内容完毕
            'gpxReGuarantee.Visible = True
        Else
            lblGuaranSumDescription.Text = "担保金额(万元)"
            lblTermDescription.Text = "担 保 期 限"
            lblGuaranteeFeeStandDesc.Text = "担保费标准(年)"
            lblGuaFeeDescription.Text = "担  保  费 (元)"
        End If
    End Sub

    Private Sub btnNewGuaranteeLetterUsage(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        Dim dr As DataRow = dsGuaranteeLetterUsage.Tables(0).NewRow
        '赋默认值给新增记录的三个字段
        If dsGuaranteeLetterType.Tables(0).Rows.Count > 0 And dsReimburseType.Tables(0).Rows.Count > 0 Then
            dr("guarantee_letter_type") = dsGuaranteeLetterType.Tables(0).Rows(0)("type_code") '保函种类编码
            dr("reimburse_type") = dsReimburseType.Tables(0).Rows(0)("type_code")  '偿还责任类型编码
            dr("project_code") = ProjectCode
            dr("create_person") = UserName
            dr("create_date") = SystemDate
        End If
        dsGuaranteeLetterUsage.Tables(0).Rows.Add(dr)
    End Sub

    Private Sub btnDeleteGuaranteeLetterUsage(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If dgIntegrate.CurrentRowIndex < 0 Then Return
        CType(cmGuaranteeLetterUsage.Current, DataRowView).Row.Delete()
    End Sub

    '如果是 保函综合授信，保存数据库表guarantee_letter
    Private Function SaveGuaranteeLetter() As Boolean
        If txtGuarantySum.Text = String.Empty OrElse CDbl(txtGuarantySum.Text) = 0 Then '如果没输入保函额度，则不用修改guarantee_letter
            Return True
        End If
        If Me.GetServicetypeCode = "08" Then 'CStr(cmbxServiceType.SelectedValue & "").IndexOf("保函综合授信") > -1 Then
            If dsGuaranteeLetter.Tables(0).Rows.Count = 0 Then
                Dim dr As DataRow = dsGuaranteeLetter.Tables(0).NewRow
                dr("project_code") = ProjectCode
                dr("corporation_code") = ProjectCode.Substring(0, 5)
                dr("guarantee_line") = CDbl(txtGuarantySum.Text)
                dr("term") = CInt(nudTerms.Value)
                dr("flag") = 0
                dr("create_person") = UserName
                dr("create_date") = SystemDate
                dsGuaranteeLetter.Tables(0).Rows.Add(dr)
            Else
                dsGuaranteeLetter.Tables(0).Rows(0)("guarantee_line") = CDbl(txtGuarantySum.Text)
                dsGuaranteeLetter.Tables(0).Rows(0)("term") = CInt(nudTerms.Value)
            End If
            If dsGuaranteeLetter.HasChanges Then
                Dim result As String = gWs.UpdateGuaranteeLetter(dsGuaranteeLetter.GetChanges)
                If result <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "保存guarantee_letter表出错", result, "")
                    Return False
                End If
                dsGuaranteeLetter.AcceptChanges()
            End If
            Return SaveGuaranteeLetterUsage()
        End If
        Return True '默认保存成功
    End Function

    '然后保存表guarantee_letter_usage
    Private Function SaveGuaranteeLetterUsage() As Boolean
        If Not cmGuaranteeLetterUsage Is Nothing Then
            cmGuaranteeLetterUsage.EndCurrentEdit()
        End If
        If dsGuaranteeLetterUsage.HasChanges Then
            Dim result As String = gWs.UpdateGuaranteeLetterUsage(dsGuaranteeLetterUsage.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存guarantee_letter_usage表失败", result, "")
                Return False
            End If
        End If
        dsGuaranteeLetterUsage.AcceptChanges()
        Return True
    End Function

    '由于保函种类和偿还责任类型不能重复，所以保存前要判断：业务品种：综合授信
    Private Function IsGuaranteeLetterUsageInfoEffective() As Boolean
        If cmGuaranteeLetterUsage Is Nothing Then Return True
        If Not dgIntegrate.Enabled Then Return True

        '        If Not dgIntegrate.Enabled OrElse cmGuaranteeLetterUsage Is Nothing Then Return True '如果不是综合授信则不用判断guarantee_letter_usage数据是否正确
        Dim i, j, count As Int32
        Dim dv As DataView = CType(cmGuaranteeLetterUsage.List, DataView)
        count = dv.Count
        For i = 0 To count - 1
            For j = i + 1 To count - 1
                If System.Object.Equals(dv(i)("guarantee_letter_type"), dv(j)("guarantee_letter_type")) AndAlso System.Object.Equals(dv(i)("reimburse_type"), dv(j)("reimburse_type")) AndAlso System.Object.Equals(dv(i)("term"), dv(j)("term")) Then
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    '保函种类变更时
    Private Sub cboBaoHanType_Changed(ByVal sender As Object, ByVal e As EventArgs)
        If System.Object.Equals(cboBaoHanType.Tag, cboBaoHanType.SelectedValue) Then
            Return
        End If
        GetFeeRateFromDataViewToTextBox()
        cboBaoHanType.Tag = cboBaoHanType.SelectedValue
    End Sub

    '出函银行改变时，改变出函分行的选项
    Private Sub cboLetterBank_Changed(ByVal sender As Object, ByVal e As EventArgs)
        CType(cboLetterSubBank.DataSource, DataView).RowFilter = "bank_code='" & cboLetterBank.SelectedValue & "'"
    End Sub

    Private Sub GetFeeRateFromDataViewToTextBox()
        If Not cboRebetType.SelectedValue Is Nothing AndAlso Not cboBaoHanType.SelectedValue Is Nothing Then
            If BaoHanType = 2 Then  '如果是额度向下保函，则费率的默认值从 guarantee_letter_usage表取
                Dim dv As DataView = dsGuaranteeLetterUsage.Tables(0).DefaultView
                dv.RowFilter = "guarantee_letter_type LIKE '" & cboBaoHanType.SelectedValue & "' AND reimburse_type LIKE '" & cboRebetType.SelectedValue & "'"
                If dv.Count > 0 Then
                    txtGuarantyFeeStandard.Text = dv(0)("guarantee_rate") & ""
                    txtGuaranteeScale.Text = dv(0)("guarantee_scale") & ""
                End If
            ElseIf BaoHanType = 0 Then '如果是单笔保函，则从service_type表取
                Dim drv As DataRowView = CType(cmbxServiceType.SelectedItem, DataRowView)
                txtGuaranteeScale.Text = drv("security_rate") & ""
                txtGuarantyFeeStandard.Text = drv("guarantee_fee_rate") & ""
            End If
            txtGuaranteeScale_Leave(Nothing, Nothing)
            txtGuarantyFeeStandard_Leave(Nothing, Nothing)
        End If
    End Sub

    '偿还责任类型变更时
    Private Sub cboRebetType_Changed(ByVal sender As Object, ByVal e As EventArgs)
        If System.Object.Equals(cboRebetType.Tag, cboRebetType.SelectedValue) Then
            Return
        End If
        GetFeeRateFromDataViewToTextBox()
        cboRebetType.Tag = cboRebetType.SelectedValue
    End Sub

    '额度项下保函，担保费率从guarantee_letter_usage取，单笔保函就从业务品种取
    '如果数据库表guarantee_letter里有记录，则是综合授信
    Private Function CaculateGuaranteeOfServiceType(ByVal GuaranSum As Double, ByVal month As Integer) As Double '计算各个品种的担保费 GuaranSum为万元
        If txtGuarantyFeeStandard.Text = String.Empty Then
            txtGuarantyFeeStandard.Text = "0"
        End If
        'If "06,08".IndexOf(Me.GetServicetypeCode) >= 0 Then   '保函品种
        '    If month <= 6 Then
        '        Return GuaranSum * CDbl(txtGuarantyFeeStandard.Text) * 6 / 100 / 12
        '    ElseIf month <= 12 Then
        '        Return GuaranSum * CDbl(txtGuarantyFeeStandard.Text) * 12 / 100 / 12
        '    ElseIf month > 12 Then
        '        Return GuaranSum * CDbl(txtGuarantyFeeStandard.Text) * month / 100 / 12
        '    End If
        'ElseIf GetServicetypeCode() = "07" Then '再担保品种
        '    '计算公式：再担保额度（担保金额）×利率（担保费率）×20％
        '    Return GuaranSum * CDbl(txtGuarantyFeeStandard.Text) * 0.2 / 100
        'Else '流贷或其它品种
        '    Return GuaranSum * CDbl(txtGuarantyFeeStandard.Text) * month / 1200
        'End If

        Return GuaranSum * CDbl(txtGuarantyFeeStandard.Text) / 100

    End Function

    '额度项下保函，担保费率从guarantee_letter_usage取，单笔保函就从业务品种取
    '如果数据库表guarantee_letter里有记录，则是综合授信
    Private Function CaculateGuaranteeOfServiceTypeExp(ByVal GuaranSum As Double, ByVal month As Integer) As Double '计算各个品种的担保费 GuaranSum为万元
        If txtGuarantyFeeStandardExp.Text = String.Empty Then
            txtGuarantyFeeStandardExp.Text = "0"
        End If
        'If "06,08".IndexOf(Me.GetServicetypeCode) >= 0 Then   '保函品种
        '    If month <= 6 Then
        '        Return GuaranSum * CDbl(txtGuarantyFeeStandardExp.Text) * 6 / 100 / 12
        '    ElseIf month <= 12 Then
        '        Return GuaranSum * CDbl(txtGuarantyFeeStandardExp.Text) * 12 / 100 / 12
        '    ElseIf month > 12 Then
        '        Return GuaranSum * CDbl(txtGuarantyFeeStandardExp.Text) * month / 100 / 12
        '    End If
        'ElseIf GetServicetypeCode() = "07" Then '再担保品种
        '    '计算公式：再担保额度（担保金额）×利率（担保费率）×20％
        '    Return GuaranSum * CDbl(txtGuarantyFeeStandardExp.Text) * 0.2 / 100
        'Else '流贷或其它品种
        '    Return GuaranSum * CDbl(txtGuarantyFeeStandardExp.Text) * month / 1200
        'End If
        Return GuaranSum * CDbl(txtGuarantyFeeStandard.Text) / 100
    End Function

    '消息发往项目经理A
    Private Sub btnSupplyOppGua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSupplyOppGua.Click
        Dim manager_A As String
        If dsProInfo Is Nothing Then
            dsProInfo = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
        End If
        manager_A = dsProInfo.Tables(0).Rows(0)("manager_A") & ""
        Dim fMessage As FSendMessage = New FSendMessage(ProjectCode, Me.Text, manager_A, Me.txtRemark.Text)
        fMessage.StartPosition = FormStartPosition.CenterScreen
        fMessage.ShowDialog()
    End Sub

    Private Overloads Function GetServicetypeCode() As String
        If cmbxServiceType.SelectedItem Is Nothing Then
            Return "Nothing" 'String.Empty
        Else
            Return CType(cmbxServiceType.SelectedItem, DataRowView)("service_type_code").ToString
        End If
    End Function

    Private Overloads Function GetServicetypeCode(ByVal service_type_name As String) As String
        Dim table As DataTable = CType(cmbxServiceType.DataSource, DataTable)
        Dim drs() As DataRow = table.Select("service_type='" & service_type_name & "'")
        If drs.Length > 0 Then
            Return drs(0)("service_type_code").ToString
        End If
        Return "Nothing"
    End Function

    Private Function TextIsDigit(ByVal text As String) As Boolean
        If text = String.Empty Then
            Return False
        End If
        Try
            Dim d As Double = CDbl(text)
        Catch
            Return False
        End Try
        Return True
    End Function

    '只读属性
    Public WriteOnly Property [ReadOnly]() As Boolean
        Set(ByVal Value As Boolean)
            If Value Then
                AddHandler MyBase.Load, AddressOf MustBeDisabled
            End If
        End Set
    End Property

    Private Sub MustBeDisabled(ByVal sender As Object, ByVal e As EventArgs)
        LockControls(tpConclusion)
        LockControls(tpInfo)
        LockControls(tpOpinion)
        LockControls(tpOppGua)
        LockControls(tpOtherInfo)

        RemoveHandler dgOppGua.MouseUp, AddressOf dgOpp_MouseUp
        RemoveHandler dgDetail.MouseUp, AddressOf dgOpp_MouseUp
        RemoveHandler MyBase.Closing, AddressOf frmMeetingRecordExp_Closing
        btnPrintReport.Enabled = False
        btnSave.Enabled = False
        btnSplitProject.Enabled = False
        btnCommit.Enabled = False
        btnSupplyOppGua.Enabled = False
    End Sub

End Class

