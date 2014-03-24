Imports SZCGC.DocumentManager

'查看项目信息
Public Class frmShowProjectInfo
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        strEnterpriseName = "123"
        strProjectCode = "001400301"
    End Sub

    Public Sub New(ByVal ProjectCode As String)
        Call Me.New()
        Me.strProjectCode = ProjectCode
        ds = gWs.GetcorporationInfo("{corporation_code like '" & Me.strProjectCode.Substring(1, 5) & "'}", "null")

        If Not ds.Tables(0).Rows.Count = 0 Then
            Me.strEnterpriseName = ds.Tables(0).Rows(0).Item("corporation_name")
        Else
            Me.strEnterpriseName = ""
        End If

    End Sub

    Public Sub New(ByVal ProjectCode As String, ByVal EnterpriseName As String)
        Me.New()
        Me.strProjectCode = ProjectCode
        Me.strEnterpriseName = EnterpriseName
    End Sub

    Public Sub New(ByVal ProjectCode As String, ByVal EnterpriseName As String, ByVal Phase As String)
        Me.New()
        Me.strProjectCode = ProjectCode
        Me.strEnterpriseName = EnterpriseName
        Me.strPhase = Phase
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents grdProjectProcess As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents grdProjectDoc As System.Windows.Forms.DataGrid
    Friend WithEvents btnCheckFile As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents dgFee As System.Windows.Forms.DataGrid
    Friend WithEvents dgRefundProcess As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents dgProjectOpinion As System.Windows.Forms.DataGrid
    Friend WithEvents dgProjectConferenceTrial As System.Windows.Forms.DataGrid
    Friend WithEvents dgProjectCorpAreaOpinion As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle6 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn32 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn33 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn34 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn35 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn36 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle7 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn37 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn38 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn39 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn40 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTableStyle8 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn41 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn42 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn43 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn44 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn45 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents TabControl2 As System.Windows.Forms.TabControl
    Friend WithEvents cmbFinancePhase As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents btnFinanceSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents dgFinanceDebt As System.Windows.Forms.DataGrid
    Friend WithEvents dgFinanceBenifit As System.Windows.Forms.DataGrid
    Friend WithEvents dgFinanceCashExchange As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn47 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn48 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn49 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn50 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnPreVouchRecord As System.Windows.Forms.Button
    Friend WithEvents btnAftVouchRecord As System.Windows.Forms.Button
    Friend WithEvents GroupBox16 As System.Windows.Forms.GroupBox
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents txtVouchCardNO As System.Windows.Forms.TextBox
    Friend WithEvents txtLicenseNO As System.Windows.Forms.TextBox
    Friend WithEvents txtSum As System.Windows.Forms.Label
    Friend WithEvents txtRegisterSum As System.Windows.Forms.TextBox
    Friend WithEvents chkIsFirstVouch As System.Windows.Forms.CheckBox
    Friend WithEvents txtWebSite As System.Windows.Forms.TextBox
    Friend WithEvents txtSumCapital As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox17 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox18 As System.Windows.Forms.GroupBox
    Friend WithEvents dgParent As System.Windows.Forms.DataGrid
    Friend WithEvents dgDetail As System.Windows.Forms.DataGrid
    Friend WithEvents btnCheckCredit As System.Windows.Forms.Button
    Friend WithEvents btnCheckReguarantee As System.Windows.Forms.Button
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents grdProjectMaterial As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle5 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn27 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn29 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn28 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox14 As System.Windows.Forms.GroupBox
    Friend WithEvents txtApplyGuaranteeSum As System.Windows.Forms.TextBox
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents txtApplyBranchBank As System.Windows.Forms.TextBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtApplyBank As System.Windows.Forms.TextBox
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtAcceptPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents txtApplyTerms As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtRecommander As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents txtApplyServiceType As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents GroupBox15 As System.Windows.Forms.GroupBox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents txtOnVouchSum As System.Windows.Forms.TextBox
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents txtReplaceSum As System.Windows.Forms.TextBox
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents txtOvertimeSum As System.Windows.Forms.TextBox
    Friend WithEvents txtRefundSum As System.Windows.Forms.TextBox
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents txtVouchSum As System.Windows.Forms.TextBox
    Friend WithEvents Label58 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtVouchBranchBank As System.Windows.Forms.TextBox
    Friend WithEvents txtVouchBank As System.Windows.Forms.TextBox
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Label57 As System.Windows.Forms.Label
    Friend WithEvents txtAcceptSum As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label55 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtLawPersonFax As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtLawPersonEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtLawPersonMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtLawPersonPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtContractEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtContractMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtRecommendPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtEnterpriseFax As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEnterpriseContactPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtEnterpriseContactPerson As System.Windows.Forms.TextBox
    Friend WithEvents txtEnterpriseLowPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEnterpriseAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEnterpriseProprietorShip As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEnterpriseType As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProjectManagerB As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtProjectManagerA As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtProjectVouchTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtProjectRefundType As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtProjectVouchType As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtProjectVouchAccount As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtProjectType As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtProjectStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dtpFoundDate As System.Windows.Forms.TextBox
    Friend WithEvents dtpProjectEndDate As System.Windows.Forms.TextBox
    Friend WithEvents dtpProjectStartDate As System.Windows.Forms.TextBox
    Friend WithEvents dtpSignDate As System.Windows.Forms.TextBox
    Friend WithEvents dtpAcceptStartDate As System.Windows.Forms.TextBox
    Friend WithEvents dtpAcceptEndDate As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label73 As System.Windows.Forms.Label
    Friend WithEvents txtItem33005 As System.Windows.Forms.TextBox
    Friend WithEvents txtDoubtful_account As System.Windows.Forms.TextBox
    Friend WithEvents txtItem35005Sub004 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox19 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox20 As System.Windows.Forms.GroupBox
    Friend WithEvents TabPage0 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage01 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage02 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage03 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox21 As System.Windows.Forms.GroupBox
    Friend WithEvents grdGuaranteeFormAdditional As System.Windows.Forms.DataGrid
    Friend WithEvents tsGuaranteeFormAdditional As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col40 As DataGridColoredBoolColumn
    Friend WithEvents col41 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col42 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col43 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboAssureCorp As System.Windows.Forms.ComboBox
    Friend WithEvents lblAssureCorp As System.Windows.Forms.Label
    Friend WithEvents txtBeneficiary As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtGuarantee_letter_type As System.Windows.Forms.TextBox
    Friend WithEvents txtReimburse_type As System.Windows.Forms.TextBox
    Friend WithEvents txtWorkflow As System.Windows.Forms.TextBox
    Friend WithEvents txtEnterpriseName As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DataGridTextBoxColumn26 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn119 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents txtEvaler As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents txtLawManager As System.Windows.Forms.TextBox
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents txtFirstChecker As System.Windows.Forms.TextBox
    Friend WithEvents TabPage9 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox22 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExpandRefundAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtExpandRefundType As System.Windows.Forms.ComboBox
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents txtExpandTerm As System.Windows.Forms.TextBox
    Friend WithEvents txtExpandAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents GroupBox23 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExpendApplyReason As System.Windows.Forms.TextBox
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents txtExpandApplyTerm As System.Windows.Forms.TextBox
    Friend WithEvents txtExpandApplyAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents Label48 As System.Windows.Forms.Label
    Friend WithEvents gpxSigInfo As System.Windows.Forms.GroupBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents txtExpSignTerm As SWSystem.Windows.Forms.NumericBox
    Friend WithEvents txtExpSignSum As System.Windows.Forms.TextBox
    Friend WithEvents txtExpStartTime As System.Windows.Forms.TextBox
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents txtExpEndTime As System.Windows.Forms.TextBox
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents TabPage10 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox24 As System.Windows.Forms.GroupBox
    Public WithEvents dgQueryResult As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle9 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn30 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn31 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn46 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn51 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn52 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn53 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn54 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtContractNum As System.Windows.Forms.TextBox
    Friend WithEvents Label60 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmShowProjectInfo))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage0 = New System.Windows.Forms.TabPage
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtProjectManagerA = New System.Windows.Forms.TextBox
        Me.txtProjectVouchType = New System.Windows.Forms.TextBox
        Me.txtProjectStatus = New System.Windows.Forms.TextBox
        Me.txtEvaler = New System.Windows.Forms.TextBox
        Me.txtProjectManagerB = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.dtpProjectEndDate = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.dtpProjectStartDate = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtProjectVouchTerm = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtProjectRefundType = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtProjectVouchAccount = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtProjectType = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label40 = New System.Windows.Forms.Label
        Me.Label41 = New System.Windows.Forms.Label
        Me.txtLawManager = New System.Windows.Forms.TextBox
        Me.Label42 = New System.Windows.Forms.Label
        Me.txtFirstChecker = New System.Windows.Forms.TextBox
        Me.GroupBox15 = New System.Windows.Forms.GroupBox
        Me.txtAcceptSum = New System.Windows.Forms.TextBox
        Me.txtOvertimeSum = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtDoubtful_account = New System.Windows.Forms.TextBox
        Me.Label69 = New System.Windows.Forms.Label
        Me.txtItem35005Sub004 = New System.Windows.Forms.TextBox
        Me.Label73 = New System.Windows.Forms.Label
        Me.txtItem33005 = New System.Windows.Forms.TextBox
        Me.dtpAcceptEndDate = New System.Windows.Forms.TextBox
        Me.dtpAcceptStartDate = New System.Windows.Forms.TextBox
        Me.dtpSignDate = New System.Windows.Forms.TextBox
        Me.Label72 = New System.Windows.Forms.Label
        Me.txtOnVouchSum = New System.Windows.Forms.TextBox
        Me.Label62 = New System.Windows.Forms.Label
        Me.txtReplaceSum = New System.Windows.Forms.TextBox
        Me.Label51 = New System.Windows.Forms.Label
        Me.txtRefundSum = New System.Windows.Forms.TextBox
        Me.Label59 = New System.Windows.Forms.Label
        Me.txtVouchSum = New System.Windows.Forms.TextBox
        Me.Label58 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtVouchBranchBank = New System.Windows.Forms.TextBox
        Me.txtVouchBank = New System.Windows.Forms.TextBox
        Me.Label56 = New System.Windows.Forms.Label
        Me.Label57 = New System.Windows.Forms.Label
        Me.Label49 = New System.Windows.Forms.Label
        Me.Label53 = New System.Windows.Forms.Label
        Me.Label55 = New System.Windows.Forms.Label
        Me.GroupBox14 = New System.Windows.Forms.GroupBox
        Me.txtApplyGuaranteeSum = New System.Windows.Forms.TextBox
        Me.Label43 = New System.Windows.Forms.Label
        Me.txtApplyBranchBank = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.txtApplyBank = New System.Windows.Forms.TextBox
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtAcceptPerson = New System.Windows.Forms.TextBox
        Me.Label36 = New System.Windows.Forms.Label
        Me.txtApplyTerms = New System.Windows.Forms.TextBox
        Me.Label37 = New System.Windows.Forms.Label
        Me.txtRecommander = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.txtApplyServiceType = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtRecommendPerson = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtEnterpriseAddress = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtEnterpriseProprietorShip = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtEnterpriseType = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEnterpriseName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox16 = New System.Windows.Forms.GroupBox
        Me.txtBeneficiary = New System.Windows.Forms.TextBox
        Me.txtWorkflow = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtReimburse_type = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtGuarantee_letter_type = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.dtpFoundDate = New System.Windows.Forms.TextBox
        Me.txtWebSite = New System.Windows.Forms.TextBox
        Me.Label70 = New System.Windows.Forms.Label
        Me.chkIsFirstVouch = New System.Windows.Forms.CheckBox
        Me.txtSumCapital = New System.Windows.Forms.TextBox
        Me.txtSum = New System.Windows.Forms.Label
        Me.txtRegisterSum = New System.Windows.Forms.TextBox
        Me.Label67 = New System.Windows.Forms.Label
        Me.txtVouchCardNO = New System.Windows.Forms.TextBox
        Me.Label64 = New System.Windows.Forms.Label
        Me.txtLicenseNO = New System.Windows.Forms.TextBox
        Me.Label65 = New System.Windows.Forms.Label
        Me.Label63 = New System.Windows.Forms.Label
        Me.GroupBox20 = New System.Windows.Forms.GroupBox
        Me.txtLawPersonMobile = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtLawPersonPhone = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtEnterpriseLowPerson = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtLawPersonEmail = New System.Windows.Forms.TextBox
        Me.txtLawPersonFax = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox19 = New System.Windows.Forms.GroupBox
        Me.txtContractEmail = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtEnterpriseContactPhone = New System.Windows.Forms.TextBox
        Me.Label32 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtContractMobile = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtEnterpriseContactPerson = New System.Windows.Forms.TextBox
        Me.txtEnterpriseFax = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnAftVouchRecord = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnPreVouchRecord = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.grdProjectProcess = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle9 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn30 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn31 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn46 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn51 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn52 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn53 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn54 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.GroupBox10 = New System.Windows.Forms.GroupBox
        Me.dgProjectCorpAreaOpinion = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle8 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn41 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn42 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn43 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn44 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn45 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox9 = New System.Windows.Forms.GroupBox
        Me.dgProjectConferenceTrial = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle7 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn37 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn38 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn39 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn40 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridTextBoxColumn50 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox8 = New System.Windows.Forms.GroupBox
        Me.dgProjectOpinion = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle6 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn32 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn33 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn34 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn35 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn36 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn48 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn49 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage4 = New System.Windows.Forms.TabPage
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.dgRefundProcess = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.dgFee = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn119 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn47 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage5 = New System.Windows.Forms.TabPage
        Me.btnCheckFile = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.grdProjectDoc = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn26 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.TabPage6 = New System.Windows.Forms.TabPage
        Me.GroupBox7 = New System.Windows.Forms.GroupBox
        Me.grdProjectMaterial = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle5 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn29 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn27 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn28 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.TabPage7 = New System.Windows.Forms.TabPage
        Me.GroupBox21 = New System.Windows.Forms.GroupBox
        Me.grdGuaranteeFormAdditional = New System.Windows.Forms.DataGrid
        Me.tsGuaranteeFormAdditional = New System.Windows.Forms.DataGridTableStyle
        Me.col41 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col42 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col43 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnCheckReguarantee = New System.Windows.Forms.Button
        Me.GroupBox18 = New System.Windows.Forms.GroupBox
        Me.dgDetail = New System.Windows.Forms.DataGrid
        Me.GroupBox17 = New System.Windows.Forms.GroupBox
        Me.dgParent = New System.Windows.Forms.DataGrid
        Me.TabPage8 = New System.Windows.Forms.TabPage
        Me.lblAssureCorp = New System.Windows.Forms.Label
        Me.cboAssureCorp = New System.Windows.Forms.ComboBox
        Me.TabControl2 = New System.Windows.Forms.TabControl
        Me.TabPage01 = New System.Windows.Forms.TabPage
        Me.GroupBox13 = New System.Windows.Forms.GroupBox
        Me.dgFinanceDebt = New System.Windows.Forms.DataGrid
        Me.TabPage02 = New System.Windows.Forms.TabPage
        Me.GroupBox12 = New System.Windows.Forms.GroupBox
        Me.dgFinanceBenifit = New System.Windows.Forms.DataGrid
        Me.TabPage03 = New System.Windows.Forms.TabPage
        Me.GroupBox11 = New System.Windows.Forms.GroupBox
        Me.dgFinanceCashExchange = New System.Windows.Forms.DataGrid
        Me.btnFinanceSearch = New System.Windows.Forms.Button
        Me.btnCheckCredit = New System.Windows.Forms.Button
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmbFinancePhase = New System.Windows.Forms.ComboBox
        Me.TabPage9 = New System.Windows.Forms.TabPage
        Me.gpxSigInfo = New System.Windows.Forms.GroupBox
        Me.txtExpEndTime = New System.Windows.Forms.TextBox
        Me.Label54 = New System.Windows.Forms.Label
        Me.txtExpStartTime = New System.Windows.Forms.TextBox
        Me.Label52 = New System.Windows.Forms.Label
        Me.txtExpSignSum = New System.Windows.Forms.TextBox
        Me.Label50 = New System.Windows.Forms.Label
        Me.txtExpSignTerm = New SWSystem.Windows.Forms.NumericBox
        Me.GroupBox22 = New System.Windows.Forms.GroupBox
        Me.txtExpandRefundAmount = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtExpandRefundType = New System.Windows.Forms.ComboBox
        Me.Label44 = New System.Windows.Forms.Label
        Me.Label33 = New System.Windows.Forms.Label
        Me.txtExpandTerm = New System.Windows.Forms.TextBox
        Me.txtExpandAmount = New System.Windows.Forms.TextBox
        Me.Label45 = New System.Windows.Forms.Label
        Me.GroupBox23 = New System.Windows.Forms.GroupBox
        Me.txtExpendApplyReason = New System.Windows.Forms.TextBox
        Me.Label47 = New System.Windows.Forms.Label
        Me.txtExpandApplyTerm = New System.Windows.Forms.TextBox
        Me.txtExpandApplyAmount = New System.Windows.Forms.TextBox
        Me.lblSum = New System.Windows.Forms.Label
        Me.Label48 = New System.Windows.Forms.Label
        Me.TabPage10 = New System.Windows.Forms.TabPage
        Me.GroupBox24 = New System.Windows.Forms.GroupBox
        Me.dgQueryResult = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnExit = New System.Windows.Forms.Button
        Me.txtContractNum = New System.Windows.Forms.TextBox
        Me.Label60 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage0.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox15.SuspendLayout()
        Me.GroupBox14.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox16.SuspendLayout()
        Me.GroupBox20.SuspendLayout()
        Me.GroupBox19.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdProjectProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        CType(Me.dgProjectCorpAreaOpinion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox9.SuspendLayout()
        CType(Me.dgProjectConferenceTrial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox8.SuspendLayout()
        CType(Me.dgProjectOpinion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.dgRefundProcess, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.dgFee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grdProjectDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.grdProjectMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage7.SuspendLayout()
        Me.GroupBox21.SuspendLayout()
        CType(Me.grdGuaranteeFormAdditional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox18.SuspendLayout()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox17.SuspendLayout()
        CType(Me.dgParent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage8.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage01.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        CType(Me.dgFinanceDebt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage02.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        CType(Me.dgFinanceBenifit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage03.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        CType(Me.dgFinanceCashExchange, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage9.SuspendLayout()
        Me.gpxSigInfo.SuspendLayout()
        Me.GroupBox22.SuspendLayout()
        Me.GroupBox23.SuspendLayout()
        Me.TabPage10.SuspendLayout()
        Me.GroupBox24.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage0)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage9)
        Me.TabControl1.Controls.Add(Me.TabPage10)
        Me.TabControl1.Location = New System.Drawing.Point(8, 8)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(864, 448)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage0
        '
        Me.TabPage0.Controls.Add(Me.GroupBox2)
        Me.TabPage0.Controls.Add(Me.GroupBox15)
        Me.TabPage0.Controls.Add(Me.GroupBox14)
        Me.TabPage0.Location = New System.Drawing.Point(4, 21)
        Me.TabPage0.Name = "TabPage0"
        Me.TabPage0.Size = New System.Drawing.Size(856, 423)
        Me.TabPage0.TabIndex = 0
        Me.TabPage0.Text = "项目基本信息"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.txtProjectManagerA)
        Me.GroupBox2.Controls.Add(Me.txtProjectVouchType)
        Me.GroupBox2.Controls.Add(Me.txtProjectStatus)
        Me.GroupBox2.Controls.Add(Me.txtEvaler)
        Me.GroupBox2.Controls.Add(Me.txtProjectManagerB)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.dtpProjectEndDate)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.dtpProjectStartDate)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtProjectVouchTerm)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtProjectRefundType)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.txtProjectVouchAccount)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtProjectType)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label40)
        Me.GroupBox2.Controls.Add(Me.Label41)
        Me.GroupBox2.Controls.Add(Me.txtLawManager)
        Me.GroupBox2.Controls.Add(Me.Label42)
        Me.GroupBox2.Controls.Add(Me.txtFirstChecker)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(840, 128)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "项目信息"
        '
        'txtProjectManagerA
        '
        Me.txtProjectManagerA.Location = New System.Drawing.Point(80, 70)
        Me.txtProjectManagerA.Name = "txtProjectManagerA"
        Me.txtProjectManagerA.ReadOnly = True
        Me.txtProjectManagerA.Size = New System.Drawing.Size(136, 21)
        Me.txtProjectManagerA.TabIndex = 41
        Me.txtProjectManagerA.Text = ""
        '
        'txtProjectVouchType
        '
        Me.txtProjectVouchType.Location = New System.Drawing.Point(80, 46)
        Me.txtProjectVouchType.Name = "txtProjectVouchType"
        Me.txtProjectVouchType.ReadOnly = True
        Me.txtProjectVouchType.Size = New System.Drawing.Size(136, 21)
        Me.txtProjectVouchType.TabIndex = 25
        Me.txtProjectVouchType.Text = ""
        '
        'txtProjectStatus
        '
        Me.txtProjectStatus.Location = New System.Drawing.Point(80, 22)
        Me.txtProjectStatus.Name = "txtProjectStatus"
        Me.txtProjectStatus.ReadOnly = True
        Me.txtProjectStatus.Size = New System.Drawing.Size(136, 21)
        Me.txtProjectStatus.TabIndex = 19
        Me.txtProjectStatus.Text = ""
        '
        'txtEvaler
        '
        Me.txtEvaler.Location = New System.Drawing.Point(80, 94)
        Me.txtEvaler.Name = "txtEvaler"
        Me.txtEvaler.ReadOnly = True
        Me.txtEvaler.Size = New System.Drawing.Size(136, 21)
        Me.txtEvaler.TabIndex = 9
        Me.txtEvaler.Text = ""
        '
        'txtProjectManagerB
        '
        Me.txtProjectManagerB.Location = New System.Drawing.Point(296, 70)
        Me.txtProjectManagerB.Name = "txtProjectManagerB"
        Me.txtProjectManagerB.ReadOnly = True
        Me.txtProjectManagerB.Size = New System.Drawing.Size(152, 21)
        Me.txtProjectManagerB.TabIndex = 43
        Me.txtProjectManagerB.Text = ""
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(232, 72)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(64, 16)
        Me.Label21.TabIndex = 42
        Me.Label21.Text = "项目经理B"
        '
        'Label22
        '
        Me.Label22.Location = New System.Drawing.Point(8, 72)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 16)
        Me.Label22.TabIndex = 40
        Me.Label22.Text = "项目经理A"
        '
        'dtpProjectEndDate
        '
        Me.dtpProjectEndDate.Location = New System.Drawing.Point(648, 96)
        Me.dtpProjectEndDate.Name = "dtpProjectEndDate"
        Me.dtpProjectEndDate.ReadOnly = True
        Me.dtpProjectEndDate.Size = New System.Drawing.Size(8, 21)
        Me.dtpProjectEndDate.TabIndex = 33
        Me.dtpProjectEndDate.Text = ""
        Me.dtpProjectEndDate.Visible = False
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(624, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(8, 16)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "终止日期："
        Me.Label11.Visible = False
        '
        'dtpProjectStartDate
        '
        Me.dtpProjectStartDate.Location = New System.Drawing.Point(600, 96)
        Me.dtpProjectStartDate.Name = "dtpProjectStartDate"
        Me.dtpProjectStartDate.ReadOnly = True
        Me.dtpProjectStartDate.Size = New System.Drawing.Size(16, 21)
        Me.dtpProjectStartDate.TabIndex = 31
        Me.dtpProjectStartDate.Text = ""
        Me.dtpProjectStartDate.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(576, 104)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(24, 16)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "起始日期："
        Me.Label12.Visible = False
        '
        'txtProjectVouchTerm
        '
        Me.txtProjectVouchTerm.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProjectVouchTerm.Location = New System.Drawing.Point(536, 46)
        Me.txtProjectVouchTerm.Name = "txtProjectVouchTerm"
        Me.txtProjectVouchTerm.ReadOnly = True
        Me.txtProjectVouchTerm.Size = New System.Drawing.Size(288, 21)
        Me.txtProjectVouchTerm.TabIndex = 29
        Me.txtProjectVouchTerm.Text = ""
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(456, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 16)
        Me.Label13.TabIndex = 28
        Me.Label13.Text = "担保期限(月)"
        '
        'txtProjectRefundType
        '
        Me.txtProjectRefundType.Location = New System.Drawing.Point(296, 46)
        Me.txtProjectRefundType.Name = "txtProjectRefundType"
        Me.txtProjectRefundType.ReadOnly = True
        Me.txtProjectRefundType.Size = New System.Drawing.Size(152, 21)
        Me.txtProjectRefundType.TabIndex = 27
        Me.txtProjectRefundType.Text = ""
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(232, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 16)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "还款方式"
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 16)
        Me.Label15.TabIndex = 24
        Me.Label15.Text = "放款方式"
        '
        'txtProjectVouchAccount
        '
        Me.txtProjectVouchAccount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtProjectVouchAccount.Location = New System.Drawing.Point(560, 22)
        Me.txtProjectVouchAccount.Name = "txtProjectVouchAccount"
        Me.txtProjectVouchAccount.ReadOnly = True
        Me.txtProjectVouchAccount.Size = New System.Drawing.Size(264, 21)
        Me.txtProjectVouchAccount.TabIndex = 23
        Me.txtProjectVouchAccount.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(448, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(120, 16)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = "评审会通过金额(万)"
        '
        'txtProjectType
        '
        Me.txtProjectType.Location = New System.Drawing.Point(296, 22)
        Me.txtProjectType.Name = "txtProjectType"
        Me.txtProjectType.ReadOnly = True
        Me.txtProjectType.Size = New System.Drawing.Size(152, 21)
        Me.txtProjectType.TabIndex = 21
        Me.txtProjectType.Text = ""
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(232, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(56, 16)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "业务品种"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(8, 24)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(56, 16)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "项目状态"
        '
        'Label40
        '
        Me.Label40.Location = New System.Drawing.Point(232, 96)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(56, 16)
        Me.Label40.TabIndex = 10
        Me.Label40.Text = "法务经理"
        '
        'Label41
        '
        Me.Label41.Location = New System.Drawing.Point(8, 96)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(72, 16)
        Me.Label41.TabIndex = 8
        Me.Label41.Text = "资产评估师"
        '
        'txtLawManager
        '
        Me.txtLawManager.Location = New System.Drawing.Point(296, 94)
        Me.txtLawManager.Name = "txtLawManager"
        Me.txtLawManager.ReadOnly = True
        Me.txtLawManager.Size = New System.Drawing.Size(152, 21)
        Me.txtLawManager.TabIndex = 11
        Me.txtLawManager.Text = ""
        '
        'Label42
        '
        Me.Label42.Location = New System.Drawing.Point(456, 72)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(72, 16)
        Me.Label42.TabIndex = 18
        Me.Label42.Text = "初审人员"
        '
        'txtFirstChecker
        '
        Me.txtFirstChecker.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFirstChecker.Location = New System.Drawing.Point(536, 70)
        Me.txtFirstChecker.Name = "txtFirstChecker"
        Me.txtFirstChecker.ReadOnly = True
        Me.txtFirstChecker.Size = New System.Drawing.Size(288, 21)
        Me.txtFirstChecker.TabIndex = 19
        Me.txtFirstChecker.Text = ""
        '
        'GroupBox15
        '
        Me.GroupBox15.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox15.Controls.Add(Me.txtContractNum)
        Me.GroupBox15.Controls.Add(Me.Label60)
        Me.GroupBox15.Controls.Add(Me.txtAcceptSum)
        Me.GroupBox15.Controls.Add(Me.txtOvertimeSum)
        Me.GroupBox15.Controls.Add(Me.Label19)
        Me.GroupBox15.Controls.Add(Me.txtDoubtful_account)
        Me.GroupBox15.Controls.Add(Me.Label69)
        Me.GroupBox15.Controls.Add(Me.txtItem35005Sub004)
        Me.GroupBox15.Controls.Add(Me.Label73)
        Me.GroupBox15.Controls.Add(Me.txtItem33005)
        Me.GroupBox15.Controls.Add(Me.dtpAcceptEndDate)
        Me.GroupBox15.Controls.Add(Me.dtpAcceptStartDate)
        Me.GroupBox15.Controls.Add(Me.dtpSignDate)
        Me.GroupBox15.Controls.Add(Me.Label72)
        Me.GroupBox15.Controls.Add(Me.txtOnVouchSum)
        Me.GroupBox15.Controls.Add(Me.Label62)
        Me.GroupBox15.Controls.Add(Me.txtReplaceSum)
        Me.GroupBox15.Controls.Add(Me.Label51)
        Me.GroupBox15.Controls.Add(Me.txtRefundSum)
        Me.GroupBox15.Controls.Add(Me.Label59)
        Me.GroupBox15.Controls.Add(Me.txtVouchSum)
        Me.GroupBox15.Controls.Add(Me.Label58)
        Me.GroupBox15.Controls.Add(Me.Label46)
        Me.GroupBox15.Controls.Add(Me.txtVouchBranchBank)
        Me.GroupBox15.Controls.Add(Me.txtVouchBank)
        Me.GroupBox15.Controls.Add(Me.Label56)
        Me.GroupBox15.Controls.Add(Me.Label57)
        Me.GroupBox15.Controls.Add(Me.Label49)
        Me.GroupBox15.Controls.Add(Me.Label53)
        Me.GroupBox15.Controls.Add(Me.Label55)
        Me.GroupBox15.Location = New System.Drawing.Point(8, 256)
        Me.GroupBox15.Name = "GroupBox15"
        Me.GroupBox15.Size = New System.Drawing.Size(840, 160)
        Me.GroupBox15.TabIndex = 2
        Me.GroupBox15.TabStop = False
        Me.GroupBox15.Text = "项目承保信息"
        '
        'txtAcceptSum
        '
        Me.txtAcceptSum.Location = New System.Drawing.Point(312, 22)
        Me.txtAcceptSum.Name = "txtAcceptSum"
        Me.txtAcceptSum.ReadOnly = True
        Me.txtAcceptSum.Size = New System.Drawing.Size(128, 21)
        Me.txtAcceptSum.TabIndex = 37
        Me.txtAcceptSum.Text = ""
        Me.txtAcceptSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtOvertimeSum
        '
        Me.txtOvertimeSum.Location = New System.Drawing.Point(88, 70)
        Me.txtOvertimeSum.Name = "txtOvertimeSum"
        Me.txtOvertimeSum.ReadOnly = True
        Me.txtOvertimeSum.Size = New System.Drawing.Size(128, 21)
        Me.txtOvertimeSum.TabIndex = 57
        Me.txtOvertimeSum.Text = ""
        Me.txtOvertimeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(8, 120)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 16)
        Me.Label19.TabIndex = 77
        Me.Label19.Text = "追偿金额(元)"
        '
        'txtDoubtful_account
        '
        Me.txtDoubtful_account.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDoubtful_account.Location = New System.Drawing.Point(536, 118)
        Me.txtDoubtful_account.Name = "txtDoubtful_account"
        Me.txtDoubtful_account.ReadOnly = True
        Me.txtDoubtful_account.Size = New System.Drawing.Size(288, 21)
        Me.txtDoubtful_account.TabIndex = 75
        Me.txtDoubtful_account.Text = ""
        Me.txtDoubtful_account.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label69
        '
        Me.Label69.Location = New System.Drawing.Point(456, 120)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(80, 16)
        Me.Label69.TabIndex = 74
        Me.Label69.Text = "坏帐损失(元)"
        '
        'txtItem35005Sub004
        '
        Me.txtItem35005Sub004.Location = New System.Drawing.Point(312, 118)
        Me.txtItem35005Sub004.Name = "txtItem35005Sub004"
        Me.txtItem35005Sub004.ReadOnly = True
        Me.txtItem35005Sub004.Size = New System.Drawing.Size(128, 21)
        Me.txtItem35005Sub004.TabIndex = 72
        Me.txtItem35005Sub004.Text = ""
        Me.txtItem35005Sub004.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label73
        '
        Me.Label73.Location = New System.Drawing.Point(232, 120)
        Me.Label73.Name = "Label73"
        Me.Label73.Size = New System.Drawing.Size(80, 16)
        Me.Label73.TabIndex = 71
        Me.Label73.Text = "追偿余额(元)"
        '
        'txtItem33005
        '
        Me.txtItem33005.Location = New System.Drawing.Point(88, 118)
        Me.txtItem33005.Name = "txtItem33005"
        Me.txtItem33005.ReadOnly = True
        Me.txtItem33005.Size = New System.Drawing.Size(128, 21)
        Me.txtItem33005.TabIndex = 69
        Me.txtItem33005.Text = ""
        Me.txtItem33005.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpAcceptEndDate
        '
        Me.dtpAcceptEndDate.Location = New System.Drawing.Point(88, 46)
        Me.dtpAcceptEndDate.Name = "dtpAcceptEndDate"
        Me.dtpAcceptEndDate.ReadOnly = True
        Me.dtpAcceptEndDate.Size = New System.Drawing.Size(128, 21)
        Me.dtpAcceptEndDate.TabIndex = 68
        Me.dtpAcceptEndDate.Text = ""
        '
        'dtpAcceptStartDate
        '
        Me.dtpAcceptStartDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpAcceptStartDate.Location = New System.Drawing.Point(536, 22)
        Me.dtpAcceptStartDate.Name = "dtpAcceptStartDate"
        Me.dtpAcceptStartDate.ReadOnly = True
        Me.dtpAcceptStartDate.Size = New System.Drawing.Size(288, 21)
        Me.dtpAcceptStartDate.TabIndex = 67
        Me.dtpAcceptStartDate.Text = ""
        '
        'dtpSignDate
        '
        Me.dtpSignDate.Location = New System.Drawing.Point(88, 22)
        Me.dtpSignDate.Name = "dtpSignDate"
        Me.dtpSignDate.ReadOnly = True
        Me.dtpSignDate.Size = New System.Drawing.Size(128, 21)
        Me.dtpSignDate.TabIndex = 66
        Me.dtpSignDate.Text = ""
        '
        'Label72
        '
        Me.Label72.Location = New System.Drawing.Point(8, 72)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(80, 16)
        Me.Label72.TabIndex = 65
        Me.Label72.Text = "逾期金额(万)"
        '
        'txtOnVouchSum
        '
        Me.txtOnVouchSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOnVouchSum.Location = New System.Drawing.Point(536, 70)
        Me.txtOnVouchSum.Name = "txtOnVouchSum"
        Me.txtOnVouchSum.ReadOnly = True
        Me.txtOnVouchSum.Size = New System.Drawing.Size(288, 21)
        Me.txtOnVouchSum.TabIndex = 63
        Me.txtOnVouchSum.Text = ""
        Me.txtOnVouchSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label62
        '
        Me.Label62.Location = New System.Drawing.Point(456, 72)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(80, 16)
        Me.Label62.TabIndex = 62
        Me.Label62.Text = "在保金额(万)"
        '
        'txtReplaceSum
        '
        Me.txtReplaceSum.Location = New System.Drawing.Point(312, 70)
        Me.txtReplaceSum.Name = "txtReplaceSum"
        Me.txtReplaceSum.ReadOnly = True
        Me.txtReplaceSum.Size = New System.Drawing.Size(128, 21)
        Me.txtReplaceSum.TabIndex = 60
        Me.txtReplaceSum.Text = ""
        Me.txtReplaceSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label51
        '
        Me.Label51.Location = New System.Drawing.Point(232, 72)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(96, 16)
        Me.Label51.TabIndex = 59
        Me.Label51.Text = "代偿金额(万)"
        '
        'txtRefundSum
        '
        Me.txtRefundSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRefundSum.Location = New System.Drawing.Point(536, 46)
        Me.txtRefundSum.Name = "txtRefundSum"
        Me.txtRefundSum.ReadOnly = True
        Me.txtRefundSum.Size = New System.Drawing.Size(288, 21)
        Me.txtRefundSum.TabIndex = 54
        Me.txtRefundSum.Text = ""
        Me.txtRefundSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label59
        '
        Me.Label59.Location = New System.Drawing.Point(456, 48)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(80, 16)
        Me.Label59.TabIndex = 53
        Me.Label59.Text = "还款金额(万)"
        '
        'txtVouchSum
        '
        Me.txtVouchSum.Location = New System.Drawing.Point(312, 46)
        Me.txtVouchSum.Name = "txtVouchSum"
        Me.txtVouchSum.ReadOnly = True
        Me.txtVouchSum.Size = New System.Drawing.Size(128, 21)
        Me.txtVouchSum.TabIndex = 51
        Me.txtVouchSum.Text = ""
        Me.txtVouchSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label58
        '
        Me.Label58.Location = New System.Drawing.Point(232, 48)
        Me.Label58.Name = "Label58"
        Me.Label58.Size = New System.Drawing.Size(96, 16)
        Me.Label58.TabIndex = 50
        Me.Label58.Text = "承保金额(万)"
        '
        'Label46
        '
        Me.Label46.Location = New System.Drawing.Point(8, 48)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(80, 16)
        Me.Label46.TabIndex = 48
        Me.Label46.Text = "还款截止日期"
        '
        'txtVouchBranchBank
        '
        Me.txtVouchBranchBank.Location = New System.Drawing.Point(312, 94)
        Me.txtVouchBranchBank.Name = "txtVouchBranchBank"
        Me.txtVouchBranchBank.ReadOnly = True
        Me.txtVouchBranchBank.Size = New System.Drawing.Size(128, 21)
        Me.txtVouchBranchBank.TabIndex = 45
        Me.txtVouchBranchBank.Text = ""
        '
        'txtVouchBank
        '
        Me.txtVouchBank.Location = New System.Drawing.Point(88, 94)
        Me.txtVouchBank.Name = "txtVouchBank"
        Me.txtVouchBank.ReadOnly = True
        Me.txtVouchBank.Size = New System.Drawing.Size(128, 21)
        Me.txtVouchBank.TabIndex = 44
        Me.txtVouchBank.Text = ""
        '
        'Label56
        '
        Me.Label56.Location = New System.Drawing.Point(232, 96)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(56, 16)
        Me.Label56.TabIndex = 43
        Me.Label56.Text = "贷款支行"
        '
        'Label57
        '
        Me.Label57.Location = New System.Drawing.Point(8, 96)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(56, 16)
        Me.Label57.TabIndex = 42
        Me.Label57.Text = "贷款银行"
        '
        'Label49
        '
        Me.Label49.Location = New System.Drawing.Point(232, 24)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(96, 16)
        Me.Label49.TabIndex = 36
        Me.Label49.Text = "签约金额(万)"
        '
        'Label53
        '
        Me.Label53.Location = New System.Drawing.Point(456, 24)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(80, 16)
        Me.Label53.TabIndex = 26
        Me.Label53.Text = "放款起始日期"
        '
        'Label55
        '
        Me.Label55.Location = New System.Drawing.Point(8, 24)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(56, 16)
        Me.Label55.TabIndex = 22
        Me.Label55.Text = "签约日期"
        '
        'GroupBox14
        '
        Me.GroupBox14.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox14.Controls.Add(Me.txtApplyGuaranteeSum)
        Me.GroupBox14.Controls.Add(Me.Label43)
        Me.GroupBox14.Controls.Add(Me.txtApplyBranchBank)
        Me.GroupBox14.Controls.Add(Me.Label38)
        Me.GroupBox14.Controls.Add(Me.txtApplyBank)
        Me.GroupBox14.Controls.Add(Me.Label39)
        Me.GroupBox14.Controls.Add(Me.txtAcceptPerson)
        Me.GroupBox14.Controls.Add(Me.Label36)
        Me.GroupBox14.Controls.Add(Me.txtApplyTerms)
        Me.GroupBox14.Controls.Add(Me.Label37)
        Me.GroupBox14.Controls.Add(Me.txtRecommander)
        Me.GroupBox14.Controls.Add(Me.Label35)
        Me.GroupBox14.Controls.Add(Me.txtApplyServiceType)
        Me.GroupBox14.Controls.Add(Me.Label34)
        Me.GroupBox14.Location = New System.Drawing.Point(8, 143)
        Me.GroupBox14.Name = "GroupBox14"
        Me.GroupBox14.Size = New System.Drawing.Size(840, 104)
        Me.GroupBox14.TabIndex = 1
        Me.GroupBox14.TabStop = False
        Me.GroupBox14.Text = "项目受理信息"
        '
        'txtApplyGuaranteeSum
        '
        Me.txtApplyGuaranteeSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtApplyGuaranteeSum.Location = New System.Drawing.Point(536, 22)
        Me.txtApplyGuaranteeSum.Name = "txtApplyGuaranteeSum"
        Me.txtApplyGuaranteeSum.ReadOnly = True
        Me.txtApplyGuaranteeSum.Size = New System.Drawing.Size(288, 21)
        Me.txtApplyGuaranteeSum.TabIndex = 17
        Me.txtApplyGuaranteeSum.Text = ""
        Me.txtApplyGuaranteeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label43
        '
        Me.Label43.Location = New System.Drawing.Point(456, 24)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(80, 16)
        Me.Label43.TabIndex = 16
        Me.Label43.Text = "申请金额(万)"
        '
        'txtApplyBranchBank
        '
        Me.txtApplyBranchBank.Location = New System.Drawing.Point(312, 70)
        Me.txtApplyBranchBank.Name = "txtApplyBranchBank"
        Me.txtApplyBranchBank.ReadOnly = True
        Me.txtApplyBranchBank.Size = New System.Drawing.Size(128, 21)
        Me.txtApplyBranchBank.TabIndex = 15
        Me.txtApplyBranchBank.Text = ""
        '
        'Label38
        '
        Me.Label38.Location = New System.Drawing.Point(232, 72)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(80, 16)
        Me.Label38.TabIndex = 14
        Me.Label38.Text = "申请贷款支行"
        '
        'txtApplyBank
        '
        Me.txtApplyBank.Location = New System.Drawing.Point(88, 70)
        Me.txtApplyBank.Name = "txtApplyBank"
        Me.txtApplyBank.ReadOnly = True
        Me.txtApplyBank.Size = New System.Drawing.Size(128, 21)
        Me.txtApplyBank.TabIndex = 13
        Me.txtApplyBank.Text = ""
        '
        'Label39
        '
        Me.Label39.Location = New System.Drawing.Point(8, 72)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(80, 16)
        Me.Label39.TabIndex = 12
        Me.Label39.Text = "申请贷款银行"
        '
        'txtAcceptPerson
        '
        Me.txtAcceptPerson.Location = New System.Drawing.Point(312, 46)
        Me.txtAcceptPerson.Name = "txtAcceptPerson"
        Me.txtAcceptPerson.ReadOnly = True
        Me.txtAcceptPerson.Size = New System.Drawing.Size(128, 21)
        Me.txtAcceptPerson.TabIndex = 7
        Me.txtAcceptPerson.Text = ""
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(232, 48)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(56, 16)
        Me.Label36.TabIndex = 6
        Me.Label36.Text = "受理人员"
        '
        'txtApplyTerms
        '
        Me.txtApplyTerms.Location = New System.Drawing.Point(88, 46)
        Me.txtApplyTerms.Name = "txtApplyTerms"
        Me.txtApplyTerms.ReadOnly = True
        Me.txtApplyTerms.Size = New System.Drawing.Size(128, 21)
        Me.txtApplyTerms.TabIndex = 5
        Me.txtApplyTerms.Text = ""
        Me.txtApplyTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(8, 48)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(80, 16)
        Me.Label37.TabIndex = 4
        Me.Label37.Text = "申请期限(月)"
        '
        'txtRecommander
        '
        Me.txtRecommander.Location = New System.Drawing.Point(312, 22)
        Me.txtRecommander.Name = "txtRecommander"
        Me.txtRecommander.ReadOnly = True
        Me.txtRecommander.Size = New System.Drawing.Size(128, 21)
        Me.txtRecommander.TabIndex = 3
        Me.txtRecommander.Text = ""
        '
        'Label35
        '
        Me.Label35.Location = New System.Drawing.Point(232, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(80, 16)
        Me.Label35.TabIndex = 2
        Me.Label35.Text = "推荐单位(人)"
        '
        'txtApplyServiceType
        '
        Me.txtApplyServiceType.Location = New System.Drawing.Point(88, 22)
        Me.txtApplyServiceType.Name = "txtApplyServiceType"
        Me.txtApplyServiceType.ReadOnly = True
        Me.txtApplyServiceType.Size = New System.Drawing.Size(128, 21)
        Me.txtApplyServiceType.TabIndex = 1
        Me.txtApplyServiceType.Text = ""
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(8, 24)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(80, 16)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "申请业务品种"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.GroupBox16)
        Me.TabPage1.Controls.Add(Me.GroupBox20)
        Me.TabPage1.Controls.Add(Me.GroupBox19)
        Me.TabPage1.Location = New System.Drawing.Point(4, 21)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(856, 423)
        Me.TabPage1.TabIndex = 6
        Me.TabPage1.Text = "企业信息"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtRecommendPerson)
        Me.GroupBox1.Controls.Add(Me.Label25)
        Me.GroupBox1.Controls.Add(Me.txtEnterpriseAddress)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtEnterpriseProprietorShip)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtEnterpriseType)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtEnterpriseName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(840, 80)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "基本信息"
        '
        'txtRecommendPerson
        '
        Me.txtRecommendPerson.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecommendPerson.Location = New System.Drawing.Point(560, 22)
        Me.txtRecommendPerson.Name = "txtRecommendPerson"
        Me.txtRecommendPerson.ReadOnly = True
        Me.txtRecommendPerson.Size = New System.Drawing.Size(264, 21)
        Me.txtRecommendPerson.TabIndex = 19
        Me.txtRecommendPerson.Text = ""
        '
        'Label25
        '
        Me.Label25.Location = New System.Drawing.Point(512, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 16)
        Me.Label25.TabIndex = 18
        Me.Label25.Text = "推荐人"
        '
        'txtEnterpriseAddress
        '
        Me.txtEnterpriseAddress.Location = New System.Drawing.Point(88, 46)
        Me.txtEnterpriseAddress.Name = "txtEnterpriseAddress"
        Me.txtEnterpriseAddress.ReadOnly = True
        Me.txtEnterpriseAddress.Size = New System.Drawing.Size(216, 21)
        Me.txtEnterpriseAddress.TabIndex = 9
        Me.txtEnterpriseAddress.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = " 地 址 "
        '
        'txtEnterpriseProprietorShip
        '
        Me.txtEnterpriseProprietorShip.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnterpriseProprietorShip.Location = New System.Drawing.Point(392, 46)
        Me.txtEnterpriseProprietorShip.Name = "txtEnterpriseProprietorShip"
        Me.txtEnterpriseProprietorShip.ReadOnly = True
        Me.txtEnterpriseProprietorShip.Size = New System.Drawing.Size(432, 21)
        Me.txtEnterpriseProprietorShip.TabIndex = 5
        Me.txtEnterpriseProprietorShip.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(320, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "所有制类型"
        '
        'txtEnterpriseType
        '
        Me.txtEnterpriseType.Location = New System.Drawing.Point(392, 22)
        Me.txtEnterpriseType.Name = "txtEnterpriseType"
        Me.txtEnterpriseType.ReadOnly = True
        Me.txtEnterpriseType.Size = New System.Drawing.Size(104, 21)
        Me.txtEnterpriseType.TabIndex = 3
        Me.txtEnterpriseType.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(320, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "企业行业"
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Location = New System.Drawing.Point(88, 22)
        Me.txtEnterpriseName.Name = "txtEnterpriseName"
        Me.txtEnterpriseName.ReadOnly = True
        Me.txtEnterpriseName.Size = New System.Drawing.Size(216, 21)
        Me.txtEnterpriseName.TabIndex = 1
        Me.txtEnterpriseName.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "企业名称"
        '
        'GroupBox16
        '
        Me.GroupBox16.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox16.Controls.Add(Me.txtBeneficiary)
        Me.GroupBox16.Controls.Add(Me.txtWorkflow)
        Me.GroupBox16.Controls.Add(Me.Label4)
        Me.GroupBox16.Controls.Add(Me.txtReimburse_type)
        Me.GroupBox16.Controls.Add(Me.Label7)
        Me.GroupBox16.Controls.Add(Me.txtGuarantee_letter_type)
        Me.GroupBox16.Controls.Add(Me.Label10)
        Me.GroupBox16.Controls.Add(Me.Label20)
        Me.GroupBox16.Controls.Add(Me.dtpFoundDate)
        Me.GroupBox16.Controls.Add(Me.txtWebSite)
        Me.GroupBox16.Controls.Add(Me.Label70)
        Me.GroupBox16.Controls.Add(Me.chkIsFirstVouch)
        Me.GroupBox16.Controls.Add(Me.txtSumCapital)
        Me.GroupBox16.Controls.Add(Me.txtSum)
        Me.GroupBox16.Controls.Add(Me.txtRegisterSum)
        Me.GroupBox16.Controls.Add(Me.Label67)
        Me.GroupBox16.Controls.Add(Me.txtVouchCardNO)
        Me.GroupBox16.Controls.Add(Me.Label64)
        Me.GroupBox16.Controls.Add(Me.txtLicenseNO)
        Me.GroupBox16.Controls.Add(Me.Label65)
        Me.GroupBox16.Controls.Add(Me.Label63)
        Me.GroupBox16.Location = New System.Drawing.Point(8, 272)
        Me.GroupBox16.Name = "GroupBox16"
        Me.GroupBox16.Size = New System.Drawing.Size(840, 88)
        Me.GroupBox16.TabIndex = 2
        Me.GroupBox16.TabStop = False
        Me.GroupBox16.Text = "附加信息"
        '
        'txtBeneficiary
        '
        Me.txtBeneficiary.Location = New System.Drawing.Point(88, 91)
        Me.txtBeneficiary.Name = "txtBeneficiary"
        Me.txtBeneficiary.ReadOnly = True
        Me.txtBeneficiary.Size = New System.Drawing.Size(128, 21)
        Me.txtBeneficiary.TabIndex = 69
        Me.txtBeneficiary.Text = ""
        '
        'txtWorkflow
        '
        Me.txtWorkflow.Location = New System.Drawing.Point(312, 116)
        Me.txtWorkflow.Name = "txtWorkflow"
        Me.txtWorkflow.ReadOnly = True
        Me.txtWorkflow.Size = New System.Drawing.Size(128, 21)
        Me.txtWorkflow.TabIndex = 68
        Me.txtWorkflow.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(224, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "运作方式"
        '
        'txtReimburse_type
        '
        Me.txtReimburse_type.Location = New System.Drawing.Point(88, 116)
        Me.txtReimburse_type.Name = "txtReimburse_type"
        Me.txtReimburse_type.ReadOnly = True
        Me.txtReimburse_type.Size = New System.Drawing.Size(128, 21)
        Me.txtReimburse_type.TabIndex = 66
        Me.txtReimburse_type.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "偿付责任类型"
        '
        'txtGuarantee_letter_type
        '
        Me.txtGuarantee_letter_type.Location = New System.Drawing.Point(312, 91)
        Me.txtGuarantee_letter_type.Name = "txtGuarantee_letter_type"
        Me.txtGuarantee_letter_type.ReadOnly = True
        Me.txtGuarantee_letter_type.Size = New System.Drawing.Size(128, 21)
        Me.txtGuarantee_letter_type.TabIndex = 64
        Me.txtGuarantee_letter_type.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(224, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 16)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "保函类型"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 96)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(56, 16)
        Me.Label20.TabIndex = 62
        Me.Label20.Text = "受益人"
        '
        'dtpFoundDate
        '
        Me.dtpFoundDate.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dtpFoundDate.Location = New System.Drawing.Point(88, 16)
        Me.dtpFoundDate.Name = "dtpFoundDate"
        Me.dtpFoundDate.ReadOnly = True
        Me.dtpFoundDate.Size = New System.Drawing.Size(128, 21)
        Me.dtpFoundDate.TabIndex = 61
        Me.dtpFoundDate.Text = ""
        '
        'txtWebSite
        '
        Me.txtWebSite.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtWebSite.Location = New System.Drawing.Point(88, 65)
        Me.txtWebSite.Name = "txtWebSite"
        Me.txtWebSite.ReadOnly = True
        Me.txtWebSite.Size = New System.Drawing.Size(736, 21)
        Me.txtWebSite.TabIndex = 18
        Me.txtWebSite.Text = ""
        '
        'Label70
        '
        Me.Label70.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label70.Location = New System.Drawing.Point(8, 72)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(56, 16)
        Me.Label70.TabIndex = 17
        Me.Label70.Text = "企业网址"
        '
        'chkIsFirstVouch
        '
        Me.chkIsFirstVouch.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.chkIsFirstVouch.Enabled = False
        Me.chkIsFirstVouch.Location = New System.Drawing.Point(224, 40)
        Me.chkIsFirstVouch.Name = "chkIsFirstVouch"
        Me.chkIsFirstVouch.Size = New System.Drawing.Size(112, 24)
        Me.chkIsFirstVouch.TabIndex = 12
        Me.chkIsFirstVouch.Text = "是否第一次贷款"
        '
        'txtSumCapital
        '
        Me.txtSumCapital.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSumCapital.Location = New System.Drawing.Point(536, 39)
        Me.txtSumCapital.Name = "txtSumCapital"
        Me.txtSumCapital.ReadOnly = True
        Me.txtSumCapital.Size = New System.Drawing.Size(288, 21)
        Me.txtSumCapital.TabIndex = 11
        Me.txtSumCapital.Text = ""
        Me.txtSumCapital.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSumCapital.Visible = False
        '
        'txtSum
        '
        Me.txtSum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSum.Location = New System.Drawing.Point(456, 48)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.Size = New System.Drawing.Size(72, 16)
        Me.txtSum.TabIndex = 10
        Me.txtSum.Text = "总资产(万)"
        Me.txtSum.Visible = False
        '
        'txtRegisterSum
        '
        Me.txtRegisterSum.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtRegisterSum.Location = New System.Drawing.Point(88, 41)
        Me.txtRegisterSum.Name = "txtRegisterSum"
        Me.txtRegisterSum.ReadOnly = True
        Me.txtRegisterSum.Size = New System.Drawing.Size(128, 21)
        Me.txtRegisterSum.TabIndex = 9
        Me.txtRegisterSum.Text = ""
        Me.txtRegisterSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label67
        '
        Me.Label67.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label67.Location = New System.Drawing.Point(8, 48)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(88, 16)
        Me.Label67.TabIndex = 8
        Me.Label67.Text = "注册资本(万)"
        '
        'txtVouchCardNO
        '
        Me.txtVouchCardNO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtVouchCardNO.Location = New System.Drawing.Point(536, 15)
        Me.txtVouchCardNO.Name = "txtVouchCardNO"
        Me.txtVouchCardNO.ReadOnly = True
        Me.txtVouchCardNO.Size = New System.Drawing.Size(288, 21)
        Me.txtVouchCardNO.TabIndex = 7
        Me.txtVouchCardNO.Text = ""
        '
        'Label64
        '
        Me.Label64.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label64.Location = New System.Drawing.Point(456, 24)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(72, 16)
        Me.Label64.TabIndex = 6
        Me.Label64.Text = "贷款卡号码"
        '
        'txtLicenseNO
        '
        Me.txtLicenseNO.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtLicenseNO.Location = New System.Drawing.Point(312, 16)
        Me.txtLicenseNO.Name = "txtLicenseNO"
        Me.txtLicenseNO.ReadOnly = True
        Me.txtLicenseNO.Size = New System.Drawing.Size(128, 21)
        Me.txtLicenseNO.TabIndex = 5
        Me.txtLicenseNO.Text = ""
        '
        'Label65
        '
        Me.Label65.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label65.Location = New System.Drawing.Point(224, 24)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(80, 16)
        Me.Label65.TabIndex = 4
        Me.Label65.Text = "营业执照号码"
        '
        'Label63
        '
        Me.Label63.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label63.Location = New System.Drawing.Point(8, 24)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(56, 16)
        Me.Label63.TabIndex = 0
        Me.Label63.Text = "成立日期"
        '
        'GroupBox20
        '
        Me.GroupBox20.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox20.Controls.Add(Me.txtLawPersonMobile)
        Me.GroupBox20.Controls.Add(Me.Label28)
        Me.GroupBox20.Controls.Add(Me.txtLawPersonPhone)
        Me.GroupBox20.Controls.Add(Me.Label29)
        Me.GroupBox20.Controls.Add(Me.Label30)
        Me.GroupBox20.Controls.Add(Me.txtEnterpriseLowPerson)
        Me.GroupBox20.Controls.Add(Me.Label31)
        Me.GroupBox20.Controls.Add(Me.txtLawPersonEmail)
        Me.GroupBox20.Controls.Add(Me.txtLawPersonFax)
        Me.GroupBox20.Controls.Add(Me.Label6)
        Me.GroupBox20.Location = New System.Drawing.Point(8, 184)
        Me.GroupBox20.Name = "GroupBox20"
        Me.GroupBox20.Size = New System.Drawing.Size(840, 80)
        Me.GroupBox20.TabIndex = 36
        Me.GroupBox20.TabStop = False
        Me.GroupBox20.Text = "法定代表人信息"
        '
        'txtLawPersonMobile
        '
        Me.txtLawPersonMobile.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLawPersonMobile.Location = New System.Drawing.Point(528, 22)
        Me.txtLawPersonMobile.Name = "txtLawPersonMobile"
        Me.txtLawPersonMobile.ReadOnly = True
        Me.txtLawPersonMobile.Size = New System.Drawing.Size(296, 21)
        Me.txtLawPersonMobile.TabIndex = 28
        Me.txtLawPersonMobile.Text = ""
        '
        'Label28
        '
        Me.Label28.Location = New System.Drawing.Point(248, 48)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(48, 16)
        Me.Label28.TabIndex = 29
        Me.Label28.Text = "Email"
        Me.Label28.Visible = False
        '
        'txtLawPersonPhone
        '
        Me.txtLawPersonPhone.Location = New System.Drawing.Point(304, 22)
        Me.txtLawPersonPhone.Name = "txtLawPersonPhone"
        Me.txtLawPersonPhone.ReadOnly = True
        Me.txtLawPersonPhone.Size = New System.Drawing.Size(160, 21)
        Me.txtLawPersonPhone.TabIndex = 25
        Me.txtLawPersonPhone.Text = ""
        '
        'Label29
        '
        Me.Label29.Location = New System.Drawing.Point(472, 24)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(56, 16)
        Me.Label29.TabIndex = 27
        Me.Label29.Text = "移动电话"
        '
        'Label30
        '
        Me.Label30.Location = New System.Drawing.Point(248, 24)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(56, 16)
        Me.Label30.TabIndex = 24
        Me.Label30.Text = "联系电话"
        '
        'txtEnterpriseLowPerson
        '
        Me.txtEnterpriseLowPerson.Location = New System.Drawing.Point(88, 22)
        Me.txtEnterpriseLowPerson.Name = "txtEnterpriseLowPerson"
        Me.txtEnterpriseLowPerson.ReadOnly = True
        Me.txtEnterpriseLowPerson.Size = New System.Drawing.Size(144, 21)
        Me.txtEnterpriseLowPerson.TabIndex = 11
        Me.txtEnterpriseLowPerson.Text = ""
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(14, 48)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(40, 16)
        Me.Label31.TabIndex = 31
        Me.Label31.Text = "传 真"
        Me.Label31.Visible = False
        '
        'txtLawPersonEmail
        '
        Me.txtLawPersonEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLawPersonEmail.Location = New System.Drawing.Point(304, 46)
        Me.txtLawPersonEmail.Name = "txtLawPersonEmail"
        Me.txtLawPersonEmail.ReadOnly = True
        Me.txtLawPersonEmail.Size = New System.Drawing.Size(520, 21)
        Me.txtLawPersonEmail.TabIndex = 30
        Me.txtLawPersonEmail.Text = ""
        Me.txtLawPersonEmail.Visible = False
        '
        'txtLawPersonFax
        '
        Me.txtLawPersonFax.Location = New System.Drawing.Point(88, 48)
        Me.txtLawPersonFax.Name = "txtLawPersonFax"
        Me.txtLawPersonFax.ReadOnly = True
        Me.txtLawPersonFax.Size = New System.Drawing.Size(144, 21)
        Me.txtLawPersonFax.TabIndex = 32
        Me.txtLawPersonFax.Text = ""
        Me.txtLawPersonFax.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = " 姓 名 "
        '
        'GroupBox19
        '
        Me.GroupBox19.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox19.Controls.Add(Me.txtContractEmail)
        Me.GroupBox19.Controls.Add(Me.Label9)
        Me.GroupBox19.Controls.Add(Me.txtEnterpriseContactPhone)
        Me.GroupBox19.Controls.Add(Me.Label32)
        Me.GroupBox19.Controls.Add(Me.Label8)
        Me.GroupBox19.Controls.Add(Me.txtContractMobile)
        Me.GroupBox19.Controls.Add(Me.Label26)
        Me.GroupBox19.Controls.Add(Me.Label27)
        Me.GroupBox19.Controls.Add(Me.txtEnterpriseContactPerson)
        Me.GroupBox19.Controls.Add(Me.txtEnterpriseFax)
        Me.GroupBox19.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox19.Name = "GroupBox19"
        Me.GroupBox19.Size = New System.Drawing.Size(840, 80)
        Me.GroupBox19.TabIndex = 35
        Me.GroupBox19.TabStop = False
        Me.GroupBox19.Text = "联系人信息"
        '
        'txtContractEmail
        '
        Me.txtContractEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContractEmail.Location = New System.Drawing.Point(304, 46)
        Me.txtContractEmail.Name = "txtContractEmail"
        Me.txtContractEmail.ReadOnly = True
        Me.txtContractEmail.Size = New System.Drawing.Size(520, 21)
        Me.txtContractEmail.TabIndex = 23
        Me.txtContractEmail.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(472, 24)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "传真"
        '
        'txtEnterpriseContactPhone
        '
        Me.txtEnterpriseContactPhone.Location = New System.Drawing.Point(304, 22)
        Me.txtEnterpriseContactPhone.Name = "txtEnterpriseContactPhone"
        Me.txtEnterpriseContactPhone.ReadOnly = True
        Me.txtEnterpriseContactPhone.Size = New System.Drawing.Size(152, 21)
        Me.txtEnterpriseContactPhone.TabIndex = 15
        Me.txtEnterpriseContactPhone.Text = ""
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(8, 24)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(48, 16)
        Me.Label32.TabIndex = 33
        Me.Label32.Text = " 姓 名 "
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(248, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "联系电话"
        '
        'txtContractMobile
        '
        Me.txtContractMobile.Location = New System.Drawing.Point(88, 46)
        Me.txtContractMobile.Name = "txtContractMobile"
        Me.txtContractMobile.ReadOnly = True
        Me.txtContractMobile.Size = New System.Drawing.Size(144, 21)
        Me.txtContractMobile.TabIndex = 21
        Me.txtContractMobile.Text = ""
        '
        'Label26
        '
        Me.Label26.Location = New System.Drawing.Point(248, 48)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 16)
        Me.Label26.TabIndex = 22
        Me.Label26.Text = "Email"
        '
        'Label27
        '
        Me.Label27.Location = New System.Drawing.Point(8, 48)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(56, 16)
        Me.Label27.TabIndex = 20
        Me.Label27.Text = "移动电话"
        '
        'txtEnterpriseContactPerson
        '
        Me.txtEnterpriseContactPerson.Location = New System.Drawing.Point(88, 22)
        Me.txtEnterpriseContactPerson.Name = "txtEnterpriseContactPerson"
        Me.txtEnterpriseContactPerson.ReadOnly = True
        Me.txtEnterpriseContactPerson.Size = New System.Drawing.Size(144, 21)
        Me.txtEnterpriseContactPerson.TabIndex = 13
        Me.txtEnterpriseContactPerson.Text = ""
        '
        'txtEnterpriseFax
        '
        Me.txtEnterpriseFax.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnterpriseFax.Location = New System.Drawing.Point(520, 22)
        Me.txtEnterpriseFax.Name = "txtEnterpriseFax"
        Me.txtEnterpriseFax.ReadOnly = True
        Me.txtEnterpriseFax.Size = New System.Drawing.Size(304, 21)
        Me.txtEnterpriseFax.TabIndex = 17
        Me.txtEnterpriseFax.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnAftVouchRecord)
        Me.TabPage2.Controls.Add(Me.btnPreVouchRecord)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Location = New System.Drawing.Point(4, 21)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(856, 423)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "项目进展情况"
        '
        'btnAftVouchRecord
        '
        Me.btnAftVouchRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAftVouchRecord.ImageIndex = 5
        Me.btnAftVouchRecord.ImageList = Me.ImageList1
        Me.btnAftVouchRecord.Location = New System.Drawing.Point(728, 392)
        Me.btnAftVouchRecord.Name = "btnAftVouchRecord"
        Me.btnAftVouchRecord.Size = New System.Drawing.Size(116, 23)
        Me.btnAftVouchRecord.TabIndex = 2
        Me.btnAftVouchRecord.Text = "保后跟踪记录(&H)"
        Me.btnAftVouchRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnPreVouchRecord
        '
        Me.btnPreVouchRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPreVouchRecord.ImageIndex = 4
        Me.btnPreVouchRecord.ImageList = Me.ImageList1
        Me.btnPreVouchRecord.Location = New System.Drawing.Point(600, 392)
        Me.btnPreVouchRecord.Name = "btnPreVouchRecord"
        Me.btnPreVouchRecord.Size = New System.Drawing.Size(116, 23)
        Me.btnPreVouchRecord.TabIndex = 1
        Me.btnPreVouchRecord.Text = "保前调研记录(&Q)"
        Me.btnPreVouchRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.grdProjectProcess)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(840, 376)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        '
        'grdProjectProcess
        '
        Me.grdProjectProcess.CaptionVisible = False
        Me.grdProjectProcess.DataMember = ""
        Me.grdProjectProcess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdProjectProcess.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdProjectProcess.Location = New System.Drawing.Point(3, 17)
        Me.grdProjectProcess.Name = "grdProjectProcess"
        Me.grdProjectProcess.ReadOnly = True
        Me.grdProjectProcess.Size = New System.Drawing.Size(834, 356)
        Me.grdProjectProcess.TabIndex = 0
        Me.grdProjectProcess.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle9})
        '
        'DataGridTableStyle9
        '
        Me.DataGridTableStyle9.DataGrid = Me.grdProjectProcess
        Me.DataGridTableStyle9.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn30, Me.DataGridTextBoxColumn31, Me.DataGridTextBoxColumn46, Me.DataGridTextBoxColumn51, Me.DataGridTextBoxColumn52, Me.DataGridTextBoxColumn53, Me.DataGridTextBoxColumn54})
        Me.DataGridTableStyle9.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle9.MappingName = "Table"
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn13.MappingName = "project_code"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 65
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "任务名称"
        Me.DataGridTextBoxColumn14.MappingName = "task_name"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 116
        '
        'DataGridTextBoxColumn30
        '
        Me.DataGridTextBoxColumn30.Format = ""
        Me.DataGridTextBoxColumn30.FormatInfo = Nothing
        Me.DataGridTextBoxColumn30.HeaderText = "执行人员"
        Me.DataGridTextBoxColumn30.MappingName = "attend_person"
        Me.DataGridTextBoxColumn30.NullText = ""
        Me.DataGridTextBoxColumn30.Width = 58
        '
        'DataGridTextBoxColumn31
        '
        Me.DataGridTextBoxColumn31.Format = ""
        Me.DataGridTextBoxColumn31.FormatInfo = Nothing
        Me.DataGridTextBoxColumn31.HeaderText = "任务状态"
        Me.DataGridTextBoxColumn31.MappingName = "task_status"
        Me.DataGridTextBoxColumn31.NullText = ""
        Me.DataGridTextBoxColumn31.Width = 58
        '
        'DataGridTextBoxColumn46
        '
        Me.DataGridTextBoxColumn46.Format = ""
        Me.DataGridTextBoxColumn46.FormatInfo = Nothing
        Me.DataGridTextBoxColumn46.HeaderText = "开始时间"
        Me.DataGridTextBoxColumn46.MappingName = "start_time"
        Me.DataGridTextBoxColumn46.NullText = ""
        Me.DataGridTextBoxColumn46.Width = 104
        '
        'DataGridTextBoxColumn51
        '
        Me.DataGridTextBoxColumn51.Format = ""
        Me.DataGridTextBoxColumn51.FormatInfo = Nothing
        Me.DataGridTextBoxColumn51.HeaderText = "完成时间"
        Me.DataGridTextBoxColumn51.MappingName = "finish_time"
        Me.DataGridTextBoxColumn51.NullText = ""
        Me.DataGridTextBoxColumn51.Width = 104
        '
        'DataGridTextBoxColumn52
        '
        Me.DataGridTextBoxColumn52.Format = ""
        Me.DataGridTextBoxColumn52.FormatInfo = Nothing
        Me.DataGridTextBoxColumn52.HeaderText = "项目阶段"
        Me.DataGridTextBoxColumn52.MappingName = "project_phase"
        Me.DataGridTextBoxColumn52.NullText = ""
        Me.DataGridTextBoxColumn52.Width = 58
        '
        'DataGridTextBoxColumn53
        '
        Me.DataGridTextBoxColumn53.Format = ""
        Me.DataGridTextBoxColumn53.FormatInfo = Nothing
        Me.DataGridTextBoxColumn53.HeaderText = "项目状态"
        Me.DataGridTextBoxColumn53.MappingName = "project_status"
        Me.DataGridTextBoxColumn53.NullText = ""
        Me.DataGridTextBoxColumn53.Width = 60
        '
        'DataGridTextBoxColumn54
        '
        Me.DataGridTextBoxColumn54.Format = ""
        Me.DataGridTextBoxColumn54.FormatInfo = Nothing
        Me.DataGridTextBoxColumn54.HeaderText = "启动方式"
        Me.DataGridTextBoxColumn54.MappingName = "task_mode"
        Me.DataGridTextBoxColumn54.NullText = ""
        Me.DataGridTextBoxColumn54.Width = 60
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox10)
        Me.TabPage3.Controls.Add(Me.GroupBox9)
        Me.TabPage3.Controls.Add(Me.GroupBox8)
        Me.TabPage3.Location = New System.Drawing.Point(4, 21)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(856, 423)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "项目评审意见"
        '
        'GroupBox10
        '
        Me.GroupBox10.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox10.Controls.Add(Me.dgProjectCorpAreaOpinion)
        Me.GroupBox10.Location = New System.Drawing.Point(8, 288)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(840, 128)
        Me.GroupBox10.TabIndex = 2
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "合作区意见"
        '
        'dgProjectCorpAreaOpinion
        '
        Me.dgProjectCorpAreaOpinion.CaptionVisible = False
        Me.dgProjectCorpAreaOpinion.DataMember = ""
        Me.dgProjectCorpAreaOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProjectCorpAreaOpinion.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgProjectCorpAreaOpinion.Location = New System.Drawing.Point(3, 17)
        Me.dgProjectCorpAreaOpinion.Name = "dgProjectCorpAreaOpinion"
        Me.dgProjectCorpAreaOpinion.ReadOnly = True
        Me.dgProjectCorpAreaOpinion.Size = New System.Drawing.Size(834, 108)
        Me.dgProjectCorpAreaOpinion.TabIndex = 0
        Me.dgProjectCorpAreaOpinion.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle8})
        '
        'DataGridTableStyle8
        '
        Me.DataGridTableStyle8.DataGrid = Me.dgProjectCorpAreaOpinion
        Me.DataGridTableStyle8.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn41, Me.DataGridTextBoxColumn42, Me.DataGridTextBoxColumn43, Me.DataGridTextBoxColumn44, Me.DataGridTextBoxColumn45})
        Me.DataGridTableStyle8.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle8.MappingName = "cooperate_organization_opinion"
        '
        'DataGridTextBoxColumn41
        '
        Me.DataGridTextBoxColumn41.Format = ""
        Me.DataGridTextBoxColumn41.FormatInfo = Nothing
        Me.DataGridTextBoxColumn41.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn41.MappingName = "project_code"
        Me.DataGridTextBoxColumn41.NullText = ""
        Me.DataGridTextBoxColumn41.Width = 68
        '
        'DataGridTextBoxColumn42
        '
        Me.DataGridTextBoxColumn42.Format = ""
        Me.DataGridTextBoxColumn42.FormatInfo = Nothing
        Me.DataGridTextBoxColumn42.HeaderText = "合作区"
        Me.DataGridTextBoxColumn42.MappingName = "cooperate_organization"
        Me.DataGridTextBoxColumn42.NullText = ""
        Me.DataGridTextBoxColumn42.Width = 150
        '
        'DataGridTextBoxColumn43
        '
        Me.DataGridTextBoxColumn43.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn43.Format = "c"
        Me.DataGridTextBoxColumn43.FormatInfo = CType(resources.GetObject("DataGridTextBoxColumn43.FormatInfo"), System.IFormatProvider)
        Me.DataGridTextBoxColumn43.HeaderText = "申请金额(元)"
        Me.DataGridTextBoxColumn43.MappingName = "recommend_sum"
        Me.DataGridTextBoxColumn43.NullText = ""
        Me.DataGridTextBoxColumn43.Width = 120
        '
        'DataGridTextBoxColumn44
        '
        Me.DataGridTextBoxColumn44.Format = ""
        Me.DataGridTextBoxColumn44.FormatInfo = Nothing
        Me.DataGridTextBoxColumn44.HeaderText = "意见"
        Me.DataGridTextBoxColumn44.MappingName = "opinion"
        Me.DataGridTextBoxColumn44.NullText = ""
        Me.DataGridTextBoxColumn44.Width = 192
        '
        'DataGridTextBoxColumn45
        '
        Me.DataGridTextBoxColumn45.Format = ""
        Me.DataGridTextBoxColumn45.FormatInfo = Nothing
        Me.DataGridTextBoxColumn45.HeaderText = "合作创建日期"
        Me.DataGridTextBoxColumn45.MappingName = "recommend_date"
        Me.DataGridTextBoxColumn45.NullText = ""
        Me.DataGridTextBoxColumn45.Width = 104
        '
        'GroupBox9
        '
        Me.GroupBox9.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox9.Controls.Add(Me.dgProjectConferenceTrial)
        Me.GroupBox9.Location = New System.Drawing.Point(8, 144)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(840, 136)
        Me.GroupBox9.TabIndex = 1
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "评审会议结论"
        '
        'dgProjectConferenceTrial
        '
        Me.dgProjectConferenceTrial.CaptionVisible = False
        Me.dgProjectConferenceTrial.DataMember = ""
        Me.dgProjectConferenceTrial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProjectConferenceTrial.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgProjectConferenceTrial.Location = New System.Drawing.Point(3, 17)
        Me.dgProjectConferenceTrial.Name = "dgProjectConferenceTrial"
        Me.dgProjectConferenceTrial.ReadOnly = True
        Me.dgProjectConferenceTrial.Size = New System.Drawing.Size(834, 116)
        Me.dgProjectConferenceTrial.TabIndex = 0
        Me.dgProjectConferenceTrial.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle7})
        '
        'DataGridTableStyle7
        '
        Me.DataGridTableStyle7.DataGrid = Me.dgProjectConferenceTrial
        Me.DataGridTableStyle7.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn37, Me.DataGridTextBoxColumn38, Me.DataGridTextBoxColumn39, Me.DataGridTextBoxColumn40, Me.DataGridBoolColumn2, Me.DataGridTextBoxColumn50})
        Me.DataGridTableStyle7.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle7.MappingName = "conference_trial"
        '
        'DataGridTextBoxColumn37
        '
        Me.DataGridTextBoxColumn37.Format = ""
        Me.DataGridTextBoxColumn37.FormatInfo = Nothing
        Me.DataGridTextBoxColumn37.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn37.MappingName = "project_code"
        Me.DataGridTextBoxColumn37.NullText = ""
        Me.DataGridTextBoxColumn37.Width = 68
        '
        'DataGridTextBoxColumn38
        '
        Me.DataGridTextBoxColumn38.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn38.Format = ""
        Me.DataGridTextBoxColumn38.FormatInfo = Nothing
        Me.DataGridTextBoxColumn38.HeaderText = "上会次数"
        Me.DataGridTextBoxColumn38.MappingName = "trial_times"
        Me.DataGridTextBoxColumn38.NullText = ""
        Me.DataGridTextBoxColumn38.Width = 60
        '
        'DataGridTextBoxColumn39
        '
        Me.DataGridTextBoxColumn39.Format = ""
        Me.DataGridTextBoxColumn39.FormatInfo = Nothing
        Me.DataGridTextBoxColumn39.HeaderText = "上会结论"
        Me.DataGridTextBoxColumn39.MappingName = "trial_conclusion"
        Me.DataGridTextBoxColumn39.NullText = ""
        Me.DataGridTextBoxColumn39.Width = 60
        '
        'DataGridTextBoxColumn40
        '
        Me.DataGridTextBoxColumn40.Format = ""
        Me.DataGridTextBoxColumn40.FormatInfo = Nothing
        Me.DataGridTextBoxColumn40.HeaderText = "备注"
        Me.DataGridTextBoxColumn40.MappingName = "remark"
        Me.DataGridTextBoxColumn40.NullText = ""
        Me.DataGridTextBoxColumn40.Width = 200
        '
        'DataGridBoolColumn2
        '
        Me.DataGridBoolColumn2.AllowNull = False
        Me.DataGridBoolColumn2.FalseValue = False
        Me.DataGridBoolColumn2.HeaderText = "是否最后结论"
        Me.DataGridBoolColumn2.MappingName = "is_final_conclusion"
        Me.DataGridBoolColumn2.NullText = ""
        Me.DataGridBoolColumn2.NullValue = CType(resources.GetObject("DataGridBoolColumn2.NullValue"), Object)
        Me.DataGridBoolColumn2.TrueValue = True
        Me.DataGridBoolColumn2.Width = 80
        '
        'DataGridTextBoxColumn50
        '
        Me.DataGridTextBoxColumn50.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn50.Format = "c"
        Me.DataGridTextBoxColumn50.FormatInfo = CType(resources.GetObject("DataGridTextBoxColumn50.FormatInfo"), System.IFormatProvider)
        Me.DataGridTextBoxColumn50.HeaderText = "通过评审会金额(万元)"
        Me.DataGridTextBoxColumn50.MappingName = "guarantee_sum"
        Me.DataGridTextBoxColumn50.NullText = "0"
        Me.DataGridTextBoxColumn50.Width = 120
        '
        'GroupBox8
        '
        Me.GroupBox8.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox8.Controls.Add(Me.dgProjectOpinion)
        Me.GroupBox8.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(840, 128)
        Me.GroupBox8.TabIndex = 0
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "项目评审意见"
        '
        'dgProjectOpinion
        '
        Me.dgProjectOpinion.CaptionVisible = False
        Me.dgProjectOpinion.DataMember = ""
        Me.dgProjectOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProjectOpinion.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgProjectOpinion.Location = New System.Drawing.Point(3, 17)
        Me.dgProjectOpinion.Name = "dgProjectOpinion"
        Me.dgProjectOpinion.ReadOnly = True
        Me.dgProjectOpinion.Size = New System.Drawing.Size(834, 108)
        Me.dgProjectOpinion.TabIndex = 0
        Me.dgProjectOpinion.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle6})
        '
        'DataGridTableStyle6
        '
        Me.DataGridTableStyle6.DataGrid = Me.dgProjectOpinion
        Me.DataGridTableStyle6.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn32, Me.DataGridTextBoxColumn33, Me.DataGridTextBoxColumn34, Me.DataGridTextBoxColumn35, Me.DataGridTextBoxColumn36, Me.DataGridTextBoxColumn48, Me.DataGridTextBoxColumn49})
        Me.DataGridTableStyle6.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle6.MappingName = "TProjectOpinion"
        '
        'DataGridTextBoxColumn32
        '
        Me.DataGridTextBoxColumn32.Format = ""
        Me.DataGridTextBoxColumn32.FormatInfo = Nothing
        Me.DataGridTextBoxColumn32.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn32.MappingName = "project_code"
        Me.DataGridTextBoxColumn32.NullText = ""
        Me.DataGridTextBoxColumn32.Width = 68
        '
        'DataGridTextBoxColumn33
        '
        Me.DataGridTextBoxColumn33.Format = ""
        Me.DataGridTextBoxColumn33.FormatInfo = Nothing
        Me.DataGridTextBoxColumn33.HeaderText = "意见类型"
        Me.DataGridTextBoxColumn33.MappingName = "item_name"
        Me.DataGridTextBoxColumn33.NullText = ""
        Me.DataGridTextBoxColumn33.Width = 150
        '
        'DataGridTextBoxColumn34
        '
        Me.DataGridTextBoxColumn34.Format = ""
        Me.DataGridTextBoxColumn34.FormatInfo = Nothing
        Me.DataGridTextBoxColumn34.HeaderText = "意见内容"
        Me.DataGridTextBoxColumn34.MappingName = "content"
        Me.DataGridTextBoxColumn34.NullText = ""
        Me.DataGridTextBoxColumn34.Width = 200
        '
        'DataGridTextBoxColumn35
        '
        Me.DataGridTextBoxColumn35.Format = ""
        Me.DataGridTextBoxColumn35.FormatInfo = Nothing
        Me.DataGridTextBoxColumn35.HeaderText = "评审结论"
        Me.DataGridTextBoxColumn35.MappingName = "conclusion"
        Me.DataGridTextBoxColumn35.NullText = ""
        Me.DataGridTextBoxColumn35.Width = 58
        '
        'DataGridTextBoxColumn36
        '
        Me.DataGridTextBoxColumn36.Format = ""
        Me.DataGridTextBoxColumn36.FormatInfo = Nothing
        Me.DataGridTextBoxColumn36.HeaderText = "创建人"
        Me.DataGridTextBoxColumn36.MappingName = "create_person"
        Me.DataGridTextBoxColumn36.NullText = ""
        Me.DataGridTextBoxColumn36.Width = 60
        '
        'DataGridTextBoxColumn48
        '
        Me.DataGridTextBoxColumn48.Format = ""
        Me.DataGridTextBoxColumn48.FormatInfo = Nothing
        Me.DataGridTextBoxColumn48.HeaderText = "时间"
        Me.DataGridTextBoxColumn48.MappingName = "create_date"
        Me.DataGridTextBoxColumn48.NullText = ""
        Me.DataGridTextBoxColumn48.Width = 104
        '
        'DataGridTextBoxColumn49
        '
        Me.DataGridTextBoxColumn49.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn49.Format = "c"
        Me.DataGridTextBoxColumn49.FormatInfo = CType(resources.GetObject("DataGridTextBoxColumn49.FormatInfo"), System.IFormatProvider)
        Me.DataGridTextBoxColumn49.HeaderText = "涉及金额(元)"
        Me.DataGridTextBoxColumn49.MappingName = "income"
        Me.DataGridTextBoxColumn49.NullText = "0"
        Me.DataGridTextBoxColumn49.Width = 120
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.GroupBox6)
        Me.TabPage4.Controls.Add(Me.GroupBox5)
        Me.TabPage4.Location = New System.Drawing.Point(4, 21)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(856, 423)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "项目收费和还款"
        '
        'GroupBox6
        '
        Me.GroupBox6.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox6.Controls.Add(Me.dgRefundProcess)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 216)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(840, 200)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "还款进度"
        '
        'dgRefundProcess
        '
        Me.dgRefundProcess.AllowSorting = False
        Me.dgRefundProcess.CaptionVisible = False
        Me.dgRefundProcess.DataMember = ""
        Me.dgRefundProcess.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRefundProcess.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgRefundProcess.Location = New System.Drawing.Point(3, 17)
        Me.dgRefundProcess.Name = "dgRefundProcess"
        Me.dgRefundProcess.ReadOnly = True
        Me.dgRefundProcess.Size = New System.Drawing.Size(834, 180)
        Me.dgRefundProcess.TabIndex = 0
        Me.dgRefundProcess.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.AllowSorting = False
        Me.DataGridTableStyle4.DataGrid = Me.dgRefundProcess
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn25})
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle4.MappingName = "Table"
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn20.MappingName = "project_code"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 68
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "应还款日期"
        Me.DataGridTextBoxColumn21.MappingName = "create_date_1"
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.Width = 80
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn22.Format = "c"
        Me.DataGridTextBoxColumn22.FormatInfo = CType(resources.GetObject("DataGridTextBoxColumn22.FormatInfo"), System.IFormatProvider)
        Me.DataGridTextBoxColumn22.HeaderText = "应还款金额(元)"
        Me.DataGridTextBoxColumn22.MappingName = "income_1"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.Width = 120
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = ""
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "实际还款日期"
        Me.DataGridTextBoxColumn23.MappingName = "create_date_2"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.Width = 80
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn24.Format = "c"
        Me.DataGridTextBoxColumn24.FormatInfo = CType(resources.GetObject("DataGridTextBoxColumn24.FormatInfo"), System.IFormatProvider)
        Me.DataGridTextBoxColumn24.HeaderText = "实际还款金额(元)"
        Me.DataGridTextBoxColumn24.MappingName = "income_11"
        Me.DataGridTextBoxColumn24.NullText = "0"
        Me.DataGridTextBoxColumn24.Width = 120
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = ""
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "还款登记人"
        Me.DataGridTextBoxColumn25.MappingName = "create_person_2"
        Me.DataGridTextBoxColumn25.NullText = ""
        Me.DataGridTextBoxColumn25.Width = 80
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.dgFee)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(840, 200)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "收费记录"
        '
        'dgFee
        '
        Me.dgFee.CaptionVisible = False
        Me.dgFee.DataMember = ""
        Me.dgFee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgFee.Location = New System.Drawing.Point(3, 17)
        Me.dgFee.Name = "dgFee"
        Me.dgFee.ReadOnly = True
        Me.dgFee.Size = New System.Drawing.Size(834, 180)
        Me.dgFee.TabIndex = 0
        Me.dgFee.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.dgFee
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn119, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn47})
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle3.MappingName = "project_account_detail"
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn15.MappingName = "project_code"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 68
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "收费日期"
        Me.DataGridTextBoxColumn16.MappingName = "date"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 75
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "收费名目"
        Me.DataGridTextBoxColumn17.MappingName = "item_name"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 75
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn18.Format = "c"
        Me.DataGridTextBoxColumn18.FormatInfo = CType(resources.GetObject("DataGridTextBoxColumn18.FormatInfo"), System.IFormatProvider)
        Me.DataGridTextBoxColumn18.HeaderText = "收费金额(元)"
        Me.DataGridTextBoxColumn18.MappingName = "income"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 110
        '
        'DataGridTextBoxColumn119
        '
        Me.DataGridTextBoxColumn119.Format = ""
        Me.DataGridTextBoxColumn119.FormatInfo = Nothing
        Me.DataGridTextBoxColumn119.HeaderText = "收费方式"
        Me.DataGridTextBoxColumn119.MappingName = "type"
        Me.DataGridTextBoxColumn119.NullText = ""
        Me.DataGridTextBoxColumn119.Width = 75
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "创建人"
        Me.DataGridTextBoxColumn19.MappingName = "create_person"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 60
        '
        'DataGridTextBoxColumn47
        '
        Me.DataGridTextBoxColumn47.Format = ""
        Me.DataGridTextBoxColumn47.FormatInfo = Nothing
        Me.DataGridTextBoxColumn47.HeaderText = "备注"
        Me.DataGridTextBoxColumn47.MappingName = "remark"
        Me.DataGridTextBoxColumn47.NullText = ""
        Me.DataGridTextBoxColumn47.Width = 246
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.btnCheckFile)
        Me.TabPage5.Controls.Add(Me.GroupBox4)
        Me.TabPage5.Location = New System.Drawing.Point(4, 21)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(856, 423)
        Me.TabPage5.TabIndex = 2
        Me.TabPage5.Text = "项目文档"
        '
        'btnCheckFile
        '
        Me.btnCheckFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckFile.ImageIndex = 1
        Me.btnCheckFile.ImageList = Me.ImageList1
        Me.btnCheckFile.Location = New System.Drawing.Point(752, 392)
        Me.btnCheckFile.Name = "btnCheckFile"
        Me.btnCheckFile.Size = New System.Drawing.Size(96, 23)
        Me.btnCheckFile.TabIndex = 1
        Me.btnCheckFile.Text = "打开文档(&O)"
        Me.btnCheckFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.grdProjectDoc)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(840, 376)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'grdProjectDoc
        '
        Me.grdProjectDoc.CaptionVisible = False
        Me.grdProjectDoc.DataMember = ""
        Me.grdProjectDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdProjectDoc.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdProjectDoc.Location = New System.Drawing.Point(3, 17)
        Me.grdProjectDoc.Name = "grdProjectDoc"
        Me.grdProjectDoc.ReadOnly = True
        Me.grdProjectDoc.Size = New System.Drawing.Size(834, 356)
        Me.grdProjectDoc.TabIndex = 1
        Me.grdProjectDoc.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.grdProjectDoc
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn26})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "Table"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn1.MappingName = "project_code"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 68
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "文档类别"
        Me.DataGridTextBoxColumn2.MappingName = "item_name"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "标题"
        Me.DataGridTextBoxColumn3.MappingName = "title"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 145
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "作者"
        Me.DataGridTextBoxColumn4.MappingName = "author"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 58
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "上传时间"
        Me.DataGridTextBoxColumn5.MappingName = "date"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "版本"
        Me.DataGridTextBoxColumn6.MappingName = "version"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 38
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "备注"
        Me.DataGridTextBoxColumn7.MappingName = "remark"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 150
        '
        'DataGridTextBoxColumn26
        '
        Me.DataGridTextBoxColumn26.Format = ""
        Me.DataGridTextBoxColumn26.FormatInfo = Nothing
        Me.DataGridTextBoxColumn26.MappingName = "file_type"
        Me.DataGridTextBoxColumn26.NullText = ""
        Me.DataGridTextBoxColumn26.Width = 0
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox7)
        Me.TabPage6.Location = New System.Drawing.Point(4, 21)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(856, 423)
        Me.TabPage6.TabIndex = 8
        Me.TabPage6.Text = "项目材料清单"
        '
        'GroupBox7
        '
        Me.GroupBox7.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox7.Controls.Add(Me.grdProjectMaterial)
        Me.GroupBox7.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(840, 408)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        '
        'grdProjectMaterial
        '
        Me.grdProjectMaterial.CaptionVisible = False
        Me.grdProjectMaterial.DataMember = ""
        Me.grdProjectMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdProjectMaterial.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdProjectMaterial.Location = New System.Drawing.Point(3, 17)
        Me.grdProjectMaterial.Name = "grdProjectMaterial"
        Me.grdProjectMaterial.ReadOnly = True
        Me.grdProjectMaterial.Size = New System.Drawing.Size(834, 388)
        Me.grdProjectMaterial.TabIndex = 0
        Me.grdProjectMaterial.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle5})
        '
        'DataGridTableStyle5
        '
        Me.DataGridTableStyle5.DataGrid = Me.grdProjectMaterial
        Me.DataGridTableStyle5.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn29, Me.DataGridTextBoxColumn27, Me.DataGridTextBoxColumn28, Me.DataGridBoolColumn1})
        Me.DataGridTableStyle5.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle5.MappingName = "TProjectDocument"
        '
        'DataGridTextBoxColumn29
        '
        Me.DataGridTextBoxColumn29.Format = ""
        Me.DataGridTextBoxColumn29.FormatInfo = Nothing
        Me.DataGridTextBoxColumn29.HeaderText = "材料名称"
        Me.DataGridTextBoxColumn29.MappingName = "doc_name"
        Me.DataGridTextBoxColumn29.NullText = ""
        Me.DataGridTextBoxColumn29.Width = 418
        '
        'DataGridTextBoxColumn27
        '
        Me.DataGridTextBoxColumn27.Format = ""
        Me.DataGridTextBoxColumn27.FormatInfo = Nothing
        Me.DataGridTextBoxColumn27.HeaderText = "查验人"
        Me.DataGridTextBoxColumn27.MappingName = "check_person"
        Me.DataGridTextBoxColumn27.NullText = ""
        Me.DataGridTextBoxColumn27.Width = 60
        '
        'DataGridTextBoxColumn28
        '
        Me.DataGridTextBoxColumn28.Format = ""
        Me.DataGridTextBoxColumn28.FormatInfo = Nothing
        Me.DataGridTextBoxColumn28.HeaderText = "查验日期"
        Me.DataGridTextBoxColumn28.MappingName = "check_date"
        Me.DataGridTextBoxColumn28.NullText = ""
        Me.DataGridTextBoxColumn28.Width = 80
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "是否关键"
        Me.DataGridBoolColumn1.MappingName = "is_important"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), Object)
        Me.DataGridBoolColumn1.ReadOnly = True
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 60
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.GroupBox21)
        Me.TabPage7.Controls.Add(Me.btnCheckReguarantee)
        Me.TabPage7.Controls.Add(Me.GroupBox18)
        Me.TabPage7.Controls.Add(Me.GroupBox17)
        Me.TabPage7.Location = New System.Drawing.Point(4, 21)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(856, 423)
        Me.TabPage7.TabIndex = 7
        Me.TabPage7.Text = "反担保措施"
        '
        'GroupBox21
        '
        Me.GroupBox21.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox21.Controls.Add(Me.grdGuaranteeFormAdditional)
        Me.GroupBox21.Location = New System.Drawing.Point(8, 152)
        Me.GroupBox21.Name = "GroupBox21"
        Me.GroupBox21.Size = New System.Drawing.Size(840, 112)
        Me.GroupBox21.TabIndex = 3
        Me.GroupBox21.TabStop = False
        Me.GroupBox21.Text = "附加的反担保措施"
        '
        'grdGuaranteeFormAdditional
        '
        Me.grdGuaranteeFormAdditional.CaptionVisible = False
        Me.grdGuaranteeFormAdditional.DataMember = ""
        Me.grdGuaranteeFormAdditional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdGuaranteeFormAdditional.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdGuaranteeFormAdditional.Location = New System.Drawing.Point(3, 17)
        Me.grdGuaranteeFormAdditional.Name = "grdGuaranteeFormAdditional"
        Me.grdGuaranteeFormAdditional.ReadOnly = True
        Me.grdGuaranteeFormAdditional.Size = New System.Drawing.Size(834, 92)
        Me.grdGuaranteeFormAdditional.TabIndex = 0
        Me.grdGuaranteeFormAdditional.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsGuaranteeFormAdditional})
        '
        'tsGuaranteeFormAdditional
        '
        Me.tsGuaranteeFormAdditional.DataGrid = Me.grdGuaranteeFormAdditional
        Me.tsGuaranteeFormAdditional.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col41, Me.col42, Me.col43})
        Me.tsGuaranteeFormAdditional.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsGuaranteeFormAdditional.MappingName = "TProjectGuaranteeFormAdditional"
        '
        'col41
        '
        Me.col41.Format = ""
        Me.col41.FormatInfo = Nothing
        Me.col41.HeaderText = "反担保方式"
        Me.col41.MappingName = "guarantee_form"
        Me.col41.NullText = ""
        Me.col41.ReadOnly = True
        Me.col41.Width = 90
        '
        'col42
        '
        Me.col42.Format = ""
        Me.col42.FormatInfo = Nothing
        Me.col42.HeaderText = "反担保物"
        Me.col42.MappingName = "guaranty_name"
        Me.col42.NullText = ""
        Me.col42.ReadOnly = True
        Me.col42.Width = 90
        '
        'col43
        '
        Me.col43.Format = ""
        Me.col43.FormatInfo = Nothing
        Me.col43.HeaderText = "附加反担保方式"
        Me.col43.MappingName = "additional_guarantee_form"
        Me.col43.NullText = ""
        Me.col43.ReadOnly = True
        Me.col43.Width = 120
        '
        'btnCheckReguarantee
        '
        Me.btnCheckReguarantee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckReguarantee.ImageIndex = 2
        Me.btnCheckReguarantee.ImageList = Me.ImageList1
        Me.btnCheckReguarantee.Location = New System.Drawing.Point(720, 392)
        Me.btnCheckReguarantee.Name = "btnCheckReguarantee"
        Me.btnCheckReguarantee.Size = New System.Drawing.Size(120, 23)
        Me.btnCheckReguarantee.TabIndex = 2
        Me.btnCheckReguarantee.Text = "查询反担保物(&G)"
        Me.btnCheckReguarantee.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox18
        '
        Me.GroupBox18.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox18.Controls.Add(Me.dgDetail)
        Me.GroupBox18.Location = New System.Drawing.Point(8, 264)
        Me.GroupBox18.Name = "GroupBox18"
        Me.GroupBox18.Size = New System.Drawing.Size(840, 120)
        Me.GroupBox18.TabIndex = 1
        Me.GroupBox18.TabStop = False
        Me.GroupBox18.Text = "反担保物"
        '
        'dgDetail
        '
        Me.dgDetail.CaptionVisible = False
        Me.dgDetail.DataMember = ""
        Me.dgDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDetail.Location = New System.Drawing.Point(3, 17)
        Me.dgDetail.Name = "dgDetail"
        Me.dgDetail.ReadOnly = True
        Me.dgDetail.Size = New System.Drawing.Size(834, 100)
        Me.dgDetail.TabIndex = 1
        '
        'GroupBox17
        '
        Me.GroupBox17.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox17.Controls.Add(Me.dgParent)
        Me.GroupBox17.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox17.Name = "GroupBox17"
        Me.GroupBox17.Size = New System.Drawing.Size(840, 144)
        Me.GroupBox17.TabIndex = 0
        Me.GroupBox17.TabStop = False
        Me.GroupBox17.Text = "独立的反担保措施"
        '
        'dgParent
        '
        Me.dgParent.CaptionVisible = False
        Me.dgParent.DataMember = ""
        Me.dgParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgParent.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgParent.Location = New System.Drawing.Point(3, 17)
        Me.dgParent.Name = "dgParent"
        Me.dgParent.ReadOnly = True
        Me.dgParent.Size = New System.Drawing.Size(834, 124)
        Me.dgParent.TabIndex = 0
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.lblAssureCorp)
        Me.TabPage8.Controls.Add(Me.cboAssureCorp)
        Me.TabPage8.Controls.Add(Me.TabControl2)
        Me.TabPage8.Controls.Add(Me.btnFinanceSearch)
        Me.TabPage8.Controls.Add(Me.btnCheckCredit)
        Me.TabPage8.Controls.Add(Me.Label23)
        Me.TabPage8.Controls.Add(Me.cmbFinancePhase)
        Me.TabPage8.Location = New System.Drawing.Point(4, 21)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(856, 423)
        Me.TabPage8.TabIndex = 5
        Me.TabPage8.Text = "财务和资信评分"
        '
        'lblAssureCorp
        '
        Me.lblAssureCorp.Location = New System.Drawing.Point(200, 18)
        Me.lblAssureCorp.Name = "lblAssureCorp"
        Me.lblAssureCorp.Size = New System.Drawing.Size(56, 16)
        Me.lblAssureCorp.TabIndex = 6
        Me.lblAssureCorp.Text = "保证企业"
        Me.lblAssureCorp.Visible = False
        '
        'cboAssureCorp
        '
        Me.cboAssureCorp.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAssureCorp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAssureCorp.Location = New System.Drawing.Point(256, 16)
        Me.cboAssureCorp.Name = "cboAssureCorp"
        Me.cboAssureCorp.Size = New System.Drawing.Size(344, 21)
        Me.cboAssureCorp.TabIndex = 5
        Me.cboAssureCorp.Visible = False
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage01)
        Me.TabControl2.Controls.Add(Me.TabPage02)
        Me.TabControl2.Controls.Add(Me.TabPage03)
        Me.TabControl2.Location = New System.Drawing.Point(0, 40)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(856, 384)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage01
        '
        Me.TabPage01.Controls.Add(Me.GroupBox13)
        Me.TabPage01.Location = New System.Drawing.Point(4, 21)
        Me.TabPage01.Name = "TabPage01"
        Me.TabPage01.Size = New System.Drawing.Size(848, 359)
        Me.TabPage01.TabIndex = 0
        Me.TabPage01.Text = "资产负债表"
        '
        'GroupBox13
        '
        Me.GroupBox13.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox13.Controls.Add(Me.dgFinanceDebt)
        Me.GroupBox13.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(848, 359)
        Me.GroupBox13.TabIndex = 1
        Me.GroupBox13.TabStop = False
        '
        'dgFinanceDebt
        '
        Me.dgFinanceDebt.CaptionVisible = False
        Me.dgFinanceDebt.DataMember = ""
        Me.dgFinanceDebt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFinanceDebt.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgFinanceDebt.Location = New System.Drawing.Point(3, 17)
        Me.dgFinanceDebt.Name = "dgFinanceDebt"
        Me.dgFinanceDebt.ReadOnly = True
        Me.dgFinanceDebt.Size = New System.Drawing.Size(842, 339)
        Me.dgFinanceDebt.TabIndex = 0
        '
        'TabPage02
        '
        Me.TabPage02.Controls.Add(Me.GroupBox12)
        Me.TabPage02.Location = New System.Drawing.Point(4, 21)
        Me.TabPage02.Name = "TabPage02"
        Me.TabPage02.Size = New System.Drawing.Size(848, 359)
        Me.TabPage02.TabIndex = 1
        Me.TabPage02.Text = "损益表"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.dgFinanceBenifit)
        Me.GroupBox12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox12.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(848, 359)
        Me.GroupBox12.TabIndex = 1
        Me.GroupBox12.TabStop = False
        '
        'dgFinanceBenifit
        '
        Me.dgFinanceBenifit.CaptionVisible = False
        Me.dgFinanceBenifit.DataMember = ""
        Me.dgFinanceBenifit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFinanceBenifit.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgFinanceBenifit.Location = New System.Drawing.Point(3, 17)
        Me.dgFinanceBenifit.Name = "dgFinanceBenifit"
        Me.dgFinanceBenifit.ReadOnly = True
        Me.dgFinanceBenifit.Size = New System.Drawing.Size(842, 339)
        Me.dgFinanceBenifit.TabIndex = 0
        '
        'TabPage03
        '
        Me.TabPage03.Controls.Add(Me.GroupBox11)
        Me.TabPage03.Location = New System.Drawing.Point(4, 21)
        Me.TabPage03.Name = "TabPage03"
        Me.TabPage03.Size = New System.Drawing.Size(848, 359)
        Me.TabPage03.TabIndex = 2
        Me.TabPage03.Text = "现金流量表"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.dgFinanceCashExchange)
        Me.GroupBox11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox11.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(848, 359)
        Me.GroupBox11.TabIndex = 0
        Me.GroupBox11.TabStop = False
        '
        'dgFinanceCashExchange
        '
        Me.dgFinanceCashExchange.CaptionVisible = False
        Me.dgFinanceCashExchange.DataMember = ""
        Me.dgFinanceCashExchange.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFinanceCashExchange.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgFinanceCashExchange.Location = New System.Drawing.Point(3, 17)
        Me.dgFinanceCashExchange.Name = "dgFinanceCashExchange"
        Me.dgFinanceCashExchange.ReadOnly = True
        Me.dgFinanceCashExchange.Size = New System.Drawing.Size(842, 339)
        Me.dgFinanceCashExchange.TabIndex = 0
        '
        'btnFinanceSearch
        '
        Me.btnFinanceSearch.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnFinanceSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFinanceSearch.ImageIndex = 3
        Me.btnFinanceSearch.ImageList = Me.ImageList1
        Me.btnFinanceSearch.Location = New System.Drawing.Point(608, 14)
        Me.btnFinanceSearch.Name = "btnFinanceSearch"
        Me.btnFinanceSearch.Size = New System.Drawing.Size(120, 23)
        Me.btnFinanceSearch.TabIndex = 3
        Me.btnFinanceSearch.Text = "显示财务数据(&V)"
        Me.btnFinanceSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCheckCredit
        '
        Me.btnCheckCredit.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnCheckCredit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCheckCredit.ImageIndex = 2
        Me.btnCheckCredit.ImageList = Me.ImageList1
        Me.btnCheckCredit.Location = New System.Drawing.Point(728, 14)
        Me.btnCheckCredit.Name = "btnCheckCredit"
        Me.btnCheckCredit.Size = New System.Drawing.Size(120, 23)
        Me.btnCheckCredit.TabIndex = 4
        Me.btnCheckCredit.Text = "查询资信评分(&W)"
        Me.btnCheckCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label23.Location = New System.Drawing.Point(24, 16)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(56, 16)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "阶段选择"
        '
        'cmbFinancePhase
        '
        Me.cmbFinancePhase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFinancePhase.Location = New System.Drawing.Point(88, 14)
        Me.cmbFinancePhase.Name = "cmbFinancePhase"
        Me.cmbFinancePhase.Size = New System.Drawing.Size(104, 20)
        Me.cmbFinancePhase.TabIndex = 1
        '
        'TabPage9
        '
        Me.TabPage9.Controls.Add(Me.gpxSigInfo)
        Me.TabPage9.Controls.Add(Me.GroupBox22)
        Me.TabPage9.Controls.Add(Me.GroupBox23)
        Me.TabPage9.Location = New System.Drawing.Point(4, 21)
        Me.TabPage9.Name = "TabPage9"
        Me.TabPage9.Size = New System.Drawing.Size(856, 423)
        Me.TabPage9.TabIndex = 9
        Me.TabPage9.Text = "展期信息"
        '
        'gpxSigInfo
        '
        Me.gpxSigInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpxSigInfo.Controls.Add(Me.txtExpEndTime)
        Me.gpxSigInfo.Controls.Add(Me.Label54)
        Me.gpxSigInfo.Controls.Add(Me.txtExpStartTime)
        Me.gpxSigInfo.Controls.Add(Me.Label52)
        Me.gpxSigInfo.Controls.Add(Me.txtExpSignSum)
        Me.gpxSigInfo.Controls.Add(Me.Label50)
        Me.gpxSigInfo.Controls.Add(Me.txtExpSignTerm)
        Me.gpxSigInfo.Location = New System.Drawing.Point(16, 296)
        Me.gpxSigInfo.Name = "gpxSigInfo"
        Me.gpxSigInfo.Size = New System.Drawing.Size(824, 120)
        Me.gpxSigInfo.TabIndex = 18
        Me.gpxSigInfo.TabStop = False
        Me.gpxSigInfo.Text = "展期签约信息"
        '
        'txtExpEndTime
        '
        Me.txtExpEndTime.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpEndTime.Enabled = False
        Me.txtExpEndTime.Location = New System.Drawing.Point(454, 72)
        Me.txtExpEndTime.Name = "txtExpEndTime"
        Me.txtExpEndTime.Size = New System.Drawing.Size(344, 21)
        Me.txtExpEndTime.TabIndex = 39
        Me.txtExpEndTime.Text = ""
        '
        'Label54
        '
        Me.Label54.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label54.AutoSize = True
        Me.Label54.Location = New System.Drawing.Point(384, 72)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(54, 17)
        Me.Label54.TabIndex = 40
        Me.Label54.Text = "结束日期"
        Me.Label54.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExpStartTime
        '
        Me.txtExpStartTime.Enabled = False
        Me.txtExpStartTime.Location = New System.Drawing.Point(104, 72)
        Me.txtExpStartTime.Name = "txtExpStartTime"
        Me.txtExpStartTime.Size = New System.Drawing.Size(168, 21)
        Me.txtExpStartTime.TabIndex = 37
        Me.txtExpStartTime.Text = ""
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Location = New System.Drawing.Point(40, 72)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(54, 17)
        Me.Label52.TabIndex = 38
        Me.Label52.Text = "起始日期"
        Me.Label52.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExpSignSum
        '
        Me.txtExpSignSum.Enabled = False
        Me.txtExpSignSum.Location = New System.Drawing.Point(104, 32)
        Me.txtExpSignSum.Name = "txtExpSignSum"
        Me.txtExpSignSum.Size = New System.Drawing.Size(168, 21)
        Me.txtExpSignSum.TabIndex = 2
        Me.txtExpSignSum.Text = ""
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(8, 40)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(91, 17)
        Me.Label50.TabIndex = 7
        Me.Label50.Text = "签约金额(万元)"
        Me.Label50.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExpSignTerm
        '
        Me.txtExpSignTerm.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpSignTerm.DefaultValue = CType(resources.GetObject("txtExpSignTerm.DefaultValue"), Object)
        Me.txtExpSignTerm.Enabled = False
        Me.txtExpSignTerm.LabelAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtExpSignTerm.LabelText = "展期期限(月)  "
        Me.txtExpSignTerm.LabelWidth = 91
        Me.txtExpSignTerm.Location = New System.Drawing.Point(363, 32)
        Me.txtExpSignTerm.MaxLength = 3
        Me.txtExpSignTerm.Name = "txtExpSignTerm"
        Me.txtExpSignTerm.Size = New System.Drawing.Size(437, 21)
        Me.txtExpSignTerm.TabIndex = 36
        Me.txtExpSignTerm.Value = CType(resources.GetObject("txtExpSignTerm.Value"), Object)
        '
        'GroupBox22
        '
        Me.GroupBox22.Controls.Add(Me.txtExpandRefundAmount)
        Me.GroupBox22.Controls.Add(Me.Label24)
        Me.GroupBox22.Controls.Add(Me.txtExpandRefundType)
        Me.GroupBox22.Controls.Add(Me.Label44)
        Me.GroupBox22.Controls.Add(Me.Label33)
        Me.GroupBox22.Controls.Add(Me.txtExpandTerm)
        Me.GroupBox22.Controls.Add(Me.txtExpandAmount)
        Me.GroupBox22.Controls.Add(Me.Label45)
        Me.GroupBox22.Location = New System.Drawing.Point(16, 176)
        Me.GroupBox22.Name = "GroupBox22"
        Me.GroupBox22.Size = New System.Drawing.Size(824, 112)
        Me.GroupBox22.TabIndex = 17
        Me.GroupBox22.TabStop = False
        Me.GroupBox22.Text = "展期评审信息"
        '
        'txtExpandRefundAmount
        '
        Me.txtExpandRefundAmount.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpandRefundAmount.Enabled = False
        Me.txtExpandRefundAmount.Location = New System.Drawing.Point(456, 72)
        Me.txtExpandRefundAmount.Name = "txtExpandRefundAmount"
        Me.txtExpandRefundAmount.Size = New System.Drawing.Size(344, 21)
        Me.txtExpandRefundAmount.TabIndex = 104
        Me.txtExpandRefundAmount.Text = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(352, 72)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(91, 17)
        Me.Label24.TabIndex = 103
        Me.Label24.Text = "每次还款额(元)"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExpandRefundType
        '
        Me.txtExpandRefundType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtExpandRefundType.Enabled = False
        Me.txtExpandRefundType.Location = New System.Drawing.Point(104, 72)
        Me.txtExpandRefundType.Name = "txtExpandRefundType"
        Me.txtExpandRefundType.Size = New System.Drawing.Size(168, 20)
        Me.txtExpandRefundType.TabIndex = 101
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(8, 72)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(91, 17)
        Me.Label44.TabIndex = 102
        Me.Label44.Text = "还  款  方  式"
        Me.Label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(368, 32)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(79, 17)
        Me.Label33.TabIndex = 51
        Me.Label33.Text = "展期期限(月)"
        Me.Label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExpandTerm
        '
        Me.txtExpandTerm.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpandTerm.Enabled = False
        Me.txtExpandTerm.Location = New System.Drawing.Point(456, 32)
        Me.txtExpandTerm.Name = "txtExpandTerm"
        Me.txtExpandTerm.Size = New System.Drawing.Size(344, 21)
        Me.txtExpandTerm.TabIndex = 50
        Me.txtExpandTerm.Text = ""
        '
        'txtExpandAmount
        '
        Me.txtExpandAmount.Enabled = False
        Me.txtExpandAmount.Location = New System.Drawing.Point(104, 32)
        Me.txtExpandAmount.Name = "txtExpandAmount"
        Me.txtExpandAmount.Size = New System.Drawing.Size(168, 21)
        Me.txtExpandAmount.TabIndex = 48
        Me.txtExpandAmount.Text = ""
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(8, 32)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(91, 17)
        Me.Label45.TabIndex = 49
        Me.Label45.Text = "展期金额(万元)"
        Me.Label45.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox23
        '
        Me.GroupBox23.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox23.Controls.Add(Me.txtExpendApplyReason)
        Me.GroupBox23.Controls.Add(Me.Label47)
        Me.GroupBox23.Controls.Add(Me.txtExpandApplyTerm)
        Me.GroupBox23.Controls.Add(Me.txtExpandApplyAmount)
        Me.GroupBox23.Controls.Add(Me.lblSum)
        Me.GroupBox23.Controls.Add(Me.Label48)
        Me.GroupBox23.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox23.Name = "GroupBox23"
        Me.GroupBox23.Size = New System.Drawing.Size(824, 160)
        Me.GroupBox23.TabIndex = 16
        Me.GroupBox23.TabStop = False
        Me.GroupBox23.Text = "展期申请信息"
        '
        'txtExpendApplyReason
        '
        Me.txtExpendApplyReason.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpendApplyReason.Enabled = False
        Me.txtExpendApplyReason.Location = New System.Drawing.Point(104, 56)
        Me.txtExpendApplyReason.Multiline = True
        Me.txtExpendApplyReason.Name = "txtExpendApplyReason"
        Me.txtExpendApplyReason.Size = New System.Drawing.Size(696, 88)
        Me.txtExpendApplyReason.TabIndex = 49
        Me.txtExpendApplyReason.Text = ""
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(368, 24)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(79, 17)
        Me.Label47.TabIndex = 47
        Me.Label47.Text = "展期期限(月)"
        Me.Label47.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExpandApplyTerm
        '
        Me.txtExpandApplyTerm.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpandApplyTerm.Enabled = False
        Me.txtExpandApplyTerm.Location = New System.Drawing.Point(456, 24)
        Me.txtExpandApplyTerm.Name = "txtExpandApplyTerm"
        Me.txtExpandApplyTerm.Size = New System.Drawing.Size(344, 21)
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
        'Label48
        '
        Me.Label48.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(40, 64)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(54, 17)
        Me.Label48.TabIndex = 38
        Me.Label48.Text = "展期原因"
        Me.Label48.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabPage10
        '
        Me.TabPage10.Controls.Add(Me.GroupBox24)
        Me.TabPage10.Location = New System.Drawing.Point(4, 21)
        Me.TabPage10.Name = "TabPage10"
        Me.TabPage10.Size = New System.Drawing.Size(856, 423)
        Me.TabPage10.TabIndex = 10
        Me.TabPage10.Text = "失信记录"
        '
        'GroupBox24
        '
        Me.GroupBox24.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox24.Controls.Add(Me.dgQueryResult)
        Me.GroupBox24.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox24.Name = "GroupBox24"
        Me.GroupBox24.Size = New System.Drawing.Size(848, 408)
        Me.GroupBox24.TabIndex = 3
        Me.GroupBox24.TabStop = False
        '
        'dgQueryResult
        '
        Me.dgQueryResult.CaptionVisible = False
        Me.dgQueryResult.DataMember = ""
        Me.dgQueryResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgQueryResult.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgQueryResult.Location = New System.Drawing.Point(3, 17)
        Me.dgQueryResult.Name = "dgQueryResult"
        Me.dgQueryResult.Size = New System.Drawing.Size(842, 388)
        Me.dgQueryResult.TabIndex = 1
        Me.dgQueryResult.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgQueryResult
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "corporation_defect_record"
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "失信日期"
        Me.DataGridTextBoxColumn8.MappingName = "DiscreditableDate"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "来源"
        Me.DataGridTextBoxColumn9.MappingName = "source"
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "失信描述"
        Me.DataGridTextBoxColumn10.MappingName = "description"
        Me.DataGridTextBoxColumn10.Width = 180
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "创建人"
        Me.DataGridTextBoxColumn11.MappingName = "create_person"
        Me.DataGridTextBoxColumn11.Width = 75
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "创建时间"
        Me.DataGridTextBoxColumn12.MappingName = "create_date"
        Me.DataGridTextBoxColumn12.Width = 75
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 0
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(896, 464)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtContractNum
        '
        Me.txtContractNum.Location = New System.Drawing.Point(536, 94)
        Me.txtContractNum.Name = "txtContractNum"
        Me.txtContractNum.ReadOnly = True
        Me.txtContractNum.Size = New System.Drawing.Size(128, 21)
        Me.txtContractNum.TabIndex = 79
        Me.txtContractNum.Text = ""
        '
        'Label60
        '
        Me.Label60.Location = New System.Drawing.Point(456, 96)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(56, 16)
        Me.Label60.TabIndex = 78
        Me.Label60.Text = "合同号"
        '
        'frmShowProjectInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(882, 495)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmShowProjectInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "显示信息"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage0.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox15.ResumeLayout(False)
        Me.GroupBox14.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox16.ResumeLayout(False)
        Me.GroupBox20.ResumeLayout(False)
        Me.GroupBox19.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdProjectProcess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox10.ResumeLayout(False)
        CType(Me.dgProjectCorpAreaOpinion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox9.ResumeLayout(False)
        CType(Me.dgProjectConferenceTrial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.dgProjectOpinion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.dgRefundProcess, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.dgFee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.grdProjectDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        CType(Me.grdProjectMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage7.ResumeLayout(False)
        Me.GroupBox21.ResumeLayout(False)
        CType(Me.grdGuaranteeFormAdditional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox18.ResumeLayout(False)
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox17.ResumeLayout(False)
        CType(Me.dgParent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage8.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage01.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        CType(Me.dgFinanceDebt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage02.ResumeLayout(False)
        Me.GroupBox12.ResumeLayout(False)
        CType(Me.dgFinanceBenifit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage03.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        CType(Me.dgFinanceCashExchange, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage9.ResumeLayout(False)
        Me.gpxSigInfo.ResumeLayout(False)
        Me.GroupBox22.ResumeLayout(False)
        Me.GroupBox23.ResumeLayout(False)
        Me.TabPage10.ResumeLayout(False)
        Me.GroupBox24.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ds As DataSet               '用作临时数据集 
    Private dsProjInfoView As DataSet   '拥有project_info view的数据集'
    Private strEnterpriseName As String '企业名称
    Private strProjectCode As String    '项目编码
    Private strPhase As String          '阶段，财务数据tabpage用  
    Private i As Integer                '用作临时变量
    Private strFileTitle As String      '文档标题
    Private strFileType As String        '文档类型
    Private branch_name As String       '银行名，打开文档按钮用

    '以下变量显示反担保物用
    Private dsGuaForm As DataSet        '反担保措施
    Private dsProCor As DataSet         '保证企业
    Private dsPerson As DataSet         '个人保证
    Private dsGuaranty As DataSet       '具体反担保物
    Private cmLocal As CurrencyManager  '绑定反担保措施
    Private GuaType As String = "total" '用于区分反担保物措施的种类

    Private Sub frmShowProjectInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            dsProjInfoView = gWs.GetProjectInfoEx("{ProjectCode = '" & Me.strProjectCode & "'}")  '获取返回project_info view的数据集
            '2007-10-18 yjf edit 提高系统性能
            'dsProjInfoView = gWs.GetCommonQueryInfo("select * from viewShowProjectInfo")  '获取返回project_info view的数据集
            Call Me.GetEnterpriseInfo(Me.strEnterpriseName)
            Call Me.GetCorporaionSubInfo(Me.strProjectCode, Me.strEnterpriseName)
            Call Me.GetProjectInfo(Me.strProjectCode)
            Call Me.GetProjectProcessInfo(Me.strProjectCode)
            Call Me.GetProjectFeeRefundInfo(Me.strProjectCode)
            Call Me.GetProjectOpinionInfo(Me.strProjectCode)
            Call Me.GetProjectFileInfo(Me.strProjectCode)
            Call Me.GetProjectMaterial(Me.strProjectCode)
            Call Me.GetOppGuaranteeInfo(Me.strProjectCode)
            Call Me.GetProjectExpandInfo(Me.strProjectCode)
            Call Me.GetPhaseList(Me.cmbFinancePhase)
            Call Me.GetAssureCorp(Me.cboAssureCorp)
            Call Me.GetDefectRecord(Me.GetCorpCode(Me.strProjectCode))
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '获取企业失信记录
    Private Function GetDefectRecord(ByVal CorporationCode As String)
        Dim strWhere As String 

        dgQueryResult.DataSource = Nothing

        strWhere = "{corporation_code='" + CorporationCode & "'}"

        Dim dsDefectRecord As DataSet = gWs.GetCorpDefectInfo(strWhere)

        If Not dsDefectRecord Is Nothing Then
            If dsDefectRecord.Tables(0).Rows.Count <> 0 Then
                Me.dgQueryResult.DataSource = dsDefectRecord.Tables(0)
                setDgAttribute(Me.dgQueryResult, Me)
            End If
        End If
    End Function

    '获取展期信息
    Private Function GetProjectExpandInfo(ByVal ProjectCode As String)
        ds = gWs.GetProjectExpandDateInfo("{project_code = '" & Me.strProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtExpandApplyAmount.Text = IIf(IsDBNull(.Item("exp_apply_amount")), "", .Item("exp_apply_amount"))
                Me.txtExpandApplyTerm.Text = IIf(IsDBNull(.Item("exp_apply_term")), "", .Item("exp_apply_term"))
                Me.txtExpendApplyReason.Text = IIf(IsDBNull(.Item("exp_apply_reason")), "", .Item("exp_apply_reason"))
                Me.txtExpandAmount.Text = IIf(IsDBNull(.Item("exp_amount")), "", .Item("exp_amount"))
                Me.txtExpandTerm.Text = IIf(IsDBNull(.Item("exp_term")), "", .Item("exp_term"))
                Me.txtExpandRefundType.Text = IIf(IsDBNull(.Item("exp_refund_type")), "", .Item("exp_refund_type"))
                Me.txtExpandRefundAmount.Text = IIf(IsDBNull(.Item("exp_refund_amount")), "", .Item("exp_refund_amount"))
                Me.txtExpSignSum.Text = IIf(IsDBNull(.Item("exp_sign_amount")), "", .Item("exp_sign_amount"))
                Me.txtExpSignTerm.Text = IIf(IsDBNull(.Item("exp_sign_term")), "", .Item("exp_sign_term"))
                Me.txtExpStartTime.Text = IIf(IsDBNull(.Item("exp_start_time")), "", .Item("exp_start_time"))
                Me.txtExpEndTime.Text = IIf(IsDBNull(.Item("exp_end_time")), "", .Item("exp_end_time"))
            End With
        End If
    End Function

    '获取企业编码
    Private Function GetCorpCode(ByVal ProjectCode As String) As String
        ds = gWs.GetProjectInfo("{project_code like '" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            Return ds.Tables(0).Rows(0).Item("corporation_code")
        Else
            Return ""
        End If
    End Function

    '获取企业信息
    Private Sub GetEnterpriseInfo(ByVal EnterpriseName As String)
        ds = gWs.GetcorporationInfo("{corporation_code = '" & Me.GetCorpCode(Me.strProjectCode) & "' }", "null")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtEnterpriseName.Text = IIf(IsDBNull(.Item("corporation_name")), "", .Item("corporation_name"))                         '企业名称
                Me.txtEnterpriseAddress.Text = IIf(IsDBNull(.Item("district_name")), "", .Item("district_name")) & IIf(IsDBNull(.Item("register_address")), "", .Item("register_address"))   '注册地址
                Me.txtEnterpriseProprietorShip.Text = IIf(IsDBNull(.Item("proprietorship_type")), "", .Item("proprietorship_type"))         '所有制类型
                Me.txtEnterpriseType.Text = IIf(IsDBNull(.Item("industry_type")), "", .Item("industry_type"))                               '企业类型
                Me.txtEnterpriseContactPerson.Text = IIf(IsDBNull(.Item("contact_person")), "", .Item("contact_person"))                    '联系人
                Me.txtEnterpriseContactPhone.Text = IIf(IsDBNull(.Item("phone_num")), "", .Item("phone_num"))                               '联系人电话
                Me.txtEnterpriseFax.Text = IIf(IsDBNull(.Item("fax")), "", .Item("fax"))                                                    '联系人传真
                Me.txtContractMobile.Text = IIf(IsDBNull(.Item("mobile")), "", .Item("mobile"))                                             '联系人移动电话
                Me.txtContractEmail.Text = IIf(IsDBNull(.Item("e_mail")), "", .Item("e_mail"))                                              '联系人Email
                Me.txtEnterpriseLowPerson.Text = IIf(IsDBNull(.Item("legal_representative")), "", .Item("legal_representative"))            '法定代表人
                Me.txtLawPersonPhone.Text = IIf(IsDBNull(.Item("legal_representative_phone")), "", .Item("legal_representative_phone"))     '法定代表人电话
                Me.txtLawPersonEmail.Text = IIf(IsDBNull(.Item("legal_representative_email")), "", .Item("legal_representative_email"))     '法定代表人Email
                Me.txtLawPersonFax.Text = IIf(IsDBNull(.Item("legal_representative_fax")), "", .Item("legal_representative_fax"))           '法定代表人传真
                Me.txtLawPersonMobile.Text = IIf(IsDBNull(.Item("legal_representative_mobile")), "", .Item("legal_representative_mobile"))  '法定代表人移动电话
            End With
        End If
        ds = gWs.GetProjectInfo("{project_code = '" & Me.strProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtRecommendPerson.Text = IIf(IsDBNull(.Item("recommend_person")), "", .Item("recommend_person"))                        '推荐人
            End With
        End If
    End Sub
    '获取项目信息
    Private Sub GetProjectInfo(ByVal ProjectCode As String)
        ds = gWs.GetProjectInfo("{project_code='" & Me.strProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtProjectStatus.Text = IIf(IsDBNull(.Item("status")), "", .Item("status"))           '项目状态
                If Not IsDBNull(.Item("apply_service_type")) AndAlso .Item("apply_service_type") = "保函" Then
                    Me.txtWorkflow.Text = IIf(IsDBNull(.Item("workflow")), "", .Item("workflow"))                                         '运作方式    
                    Dim drs As DataRow()
                    Dim dsTemp As DataSet = gWs.GetGuaranteeLetterType("%")
                    Me.txtGuarantee_letter_type.Text = IIf(IsDBNull(.Item("guarantee_letter_type")), "", .Item("guarantee_letter_type"))  '保函种类
                    drs = dsTemp.Tables(0).Select("type_code='" + Me.txtGuarantee_letter_type.Text + "'")
                    If Not drs.Length = 0 Then
                        Me.txtGuarantee_letter_type.Text = drs(0).Item("name")
                    End If
                    dsTemp = gWs.GetReimburseType("%")
                    Me.txtReimburse_type.Text = IIf(IsDBNull(.Item("reimburse_type")), "", .Item("reimburse_type"))                       '偿付责任类型
                    drs = dsTemp.Tables(0).Select("type_code='" + Me.txtReimburse_type.Text + "'")
                    If Not drs.Length = 0 Then
                        Me.txtReimburse_type.Text = drs(0).Item("name")
                    End If
                    Me.txtBeneficiary.Text = IIf(IsDBNull(.Item("beneficiary")), "", .Item("beneficiary"))                                '受益人名称
                    Me.GroupBox16.Height += 53
                End If
            End With
        End If
        ds = gWs.GetConfTrialInfo("{project_code='" & ProjectCode & "' ORDER BY create_date DESC}", "null")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtProjectType.Text = IIf(IsDBNull(.Item("service_type")), "", .Item("service_type"))                '业务品种
                Me.txtProjectVouchAccount.Text = IIf(IsDBNull(.Item("guarantee_sum")), "", .Item("guarantee_sum"))      '评审会通过金额
                Me.txtProjectVouchType.Text = IIf(IsDBNull(.Item("loan_provide_form")), "", .Item("loan_provide_form")) '放款方式
                Me.txtProjectRefundType.Text = IIf(IsDBNull(.Item("refund_type")), "", .Item("refund_type"))            '还款方式
                Me.txtProjectVouchTerm.Text = IIf(IsDBNull(.Item("terms")), "", .Item("terms"))                         '担保期限
            End With
        End If
        ds = gWs.GetLoanNoticeInfo("{project_code='" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                If Not IsDBNull(.Item("start_date")) Then
                    Me.dtpProjectStartDate.Text = Format(.Item("start_date"), "yyyy年MM月dd日")   '起始日期
                End If
                If Not IsDBNull(.Item("end_date")) Then
                    Me.dtpProjectEndDate.Text = Format(.Item("end_date"), "yyyy年MM月dd日")       '终止日期
                End If
            End With
        End If
        If Not Me.dsProjInfoView.Tables(0).Rows.Count = 0 Then
            With Me.dsProjInfoView.Tables(0).Rows(0)
                Me.txtProjectManagerA.Text = IIf(IsDBNull(.Item("manager_A")), "", .Item("manager_A"))  '项目经理A
                Me.txtProjectManagerB.Text = IIf(IsDBNull(.Item("manager_B")), "", .Item("manager_B"))  '项目经理A
                Me.branch_name = IIf(IsDBNull(.Item("branch_name")), "", .Item("branch_name"))
            End With
        End If
        '显示合同号
        Dim dsContractNum As DataSet = gWs.GetCommonQueryInfo("select top 1 contract_num from project_contract_num where project_code='" & Me.strProjectCode & "'")
        If dsContractNum.Tables(0).Rows.Count <> 0 Then
            txtContractNum.Text = dsContractNum.Tables(0).Rows(0).Item("contract_num")
        End If
    End Sub
    '获取银行或支行名
    Private Function GetBankName(ByVal BankCode As String, ByVal BranchBankCode As String) As String
        Dim dsTemp As DataSet
        If BranchBankCode = Nothing Then    '取得银行名称。
            dsTemp = gWs.GetBankInfo("{bank_code='" & BankCode & "'}", "null")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                If Not IsDBNull(dsTemp.Tables(0).Rows(0).Item("bank_name")) Then
                    Return dsTemp.Tables(0).Rows(0).Item("bank_name")
                End If
            End If
        Else    '取得银行支行名称
            dsTemp = gWs.GetBankInfo("null", "{bank_code='" & BankCode & "' and branch_bank_code='" & BranchBankCode & "'}")
            If Not dsTemp.Tables(1).Rows.Count = 0 Then
                If Not IsDBNull(dsTemp.Tables(1).Rows(0).Item("branch_bank_name")) Then
                    Return dsTemp.Tables(1).Rows(0).Item("branch_bank_name")
                End If
            End If
        End If
        Return ""
    End Function
    '获取项目进展情况
    Private Sub GetProjectProcessInfo(ByVal ProjectCode As String)
        ds = gWs.GetProjectScheduleInfo(ProjectCode)
        ds.Tables(0).Columns.Add(New DataColumn("task_mode", GetType(String), "iif(start_mode = 'manual','手动','自动')"))
        Me.grdProjectProcess.DataSource = ds.Tables(0)
    End Sub
    '双击显示项目进展的datagrid弹出发送消息框
    Private Sub grdProjectProcess_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdProjectProcess.DoubleClick
        If Me.grdProjectProcess.DataSource Is Nothing OrElse Me.grdProjectProcess.CurrentRowIndex = -1 Then
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        Try
            '临时变量，用以传入项目编码，任务名称，消息接受人
            Dim project_code, task_name, attend_person As String
            Dim index As Integer
            index = Me.grdProjectProcess.CurrentRowIndex
            project_code = Me.grdProjectProcess.Item(index, 0)
            task_name = Me.grdProjectProcess.Item(index, 1)
            attend_person = Me.grdProjectProcess.Item(index, 2)
            '消息接受人与用户不能为同一人
            If attend_person.Trim() = UserName Then
                SWDialogBox.MessageBox.Show("$1003", "消息接受人")
                Return
            Else
                Dim FSendMessage As New FSendMessage(project_code, task_name, attend_person)
                FSendMessage.ShowDialog()
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '为收费表，意见表，材料表清单加入item_name
    Private Sub AddColumnItemName(ByVal ds As DataSet)
        ds.Tables(0).Columns.Add("item_name", GetType(String))
        Dim dsTemp As DataSet
        dsTemp = gWs.GetItemEx("%")
        Dim drs() As DataRow
        Dim i1 As Integer = ds.Tables(0).Columns("item_type").Ordinal
        Dim i2 As Integer = ds.Tables(0).Columns("item_code").Ordinal
        Dim i3 As Integer = ds.Tables(0).Columns("item_name").Ordinal
        Dim i4 As Integer = dsTemp.Tables(0).Columns("item_name").Ordinal    'TItem表

        For i = 0 To ds.Tables(0).Rows.Count - 1
            With ds.Tables(0).Rows(i)
                drs = dsTemp.Tables(0).Select("item_type='" & .Item(i1) & "' AND item_code='" & .Item(i2) & "'")
                If Not drs.Length = 0 Then
                    .Item(i3) = drs(0)(i4)
                End If
            End With
        Next
    End Sub

    '获取收费情况与还款情况
    Private Sub GetProjectFeeRefundInfo(ByVal ProjectCode As String)

        '收费  34_009为保证金
        ds = gWs.GetProjectAccountDetailInfo("{project_code='" & ProjectCode & "' AND income IS NOT NULL AND (item_type='31' OR (item_type='34' AND item_code='009'))}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            Me.AddColumnItemName(ds)
            Me.dgFee.DataSource = ds.Tables(0).DefaultView
        End If
        ds = gWs.GetProjectAccountDetailInfo("{project_code='" & ProjectCode & "' AND item_type='35' }")
        Dim dr() As DataRow
        Dim a, b As Double
        a = 0 : b = 0
        dr = ds.Tables(0).Select("item_code='005'")
        If Not dr.Length = 0 Then
            If Not IsDBNull(dr(0).Item("payout")) Then
                Me.txtItem33005.Text = Numeric2Currency(dr(0).Item("payout"))  '追偿金额
                a = dr(0).Item("payout")
            End If
        End If
        dr = ds.Tables(0).Select("item_code='004'")
        If Not dr.Length = 0 Then
            If Not IsDBNull(dr(0).Item("payout")) Then
                b = dr(0).Item("payout")                   '索赔收入
            End If
        End If
        '追偿余额=追偿金额-索赔收入
        If a = 0 And b = 0 Then
            Me.txtItem35005Sub004.Text = ""
        Else
            Me.txtItem35005Sub004.Text = Numeric2Currency(a - b)
        End If
        ds = gWs.GetProjectEndCaseInfo("{project_code='" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                If Not IsDBNull(.Item("doubtful_account")) Then
                    Me.txtDoubtful_account.Text = Numeric2Currency(.Item("doubtful_account"))   '坏账损失
                End If
            End With
        End If

        '还款进度
        'ds = gWs.GetProjectAccountDetailInfo("{project_code='" & ProjectCode & "' and item_type='34' and item_code='001'}")
        ds = gWs.GetRefundProcess(ProjectCode)
        If Not ds.Tables(0).Rows.Count = 0 Then
            Dim i As Integer
            For i = 0 To ds.Tables(0).Rows.Count - 1
                ds.Tables(0).Rows(i).Item("project_code") = Me.strProjectCode
            Next
            Me.dgRefundProcess.DataSource = ds.Tables(0).DefaultView
        End If
    End Sub

    '获取项目意见表清单
    Private Sub GetProjectOpinionInfo(ByVal ProjectCode As String)
        Dim dsTemp As DataSet
        Dim drs() As DataRow
        Dim ItemType, ItemCode As String

        ds = gWs.GetProjectOpinionByProjectNo("{project_code='" & ProjectCode & "' and item_type like '5%'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            Me.AddColumnItemName(ds)
            ds.Tables(0).Columns.Add("income", GetType(Double))

            dsTemp = gWs.GetProjectAccountDetailInfo("{project_code='" & ProjectCode & "' AND item_type='31'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    With ds.Tables(0).Rows(i)
                        If .Item("item_type") = "51" AndAlso .Item("item_code") = "004" Then  '评审费收取意见
                            drs = dsTemp.Tables(0).Select("item_code='001'")
                            If Not drs.Length = 0 Then
                                .Item("income") = drs(0)("payout")        '评审费
                            End If
                        End If
                        If .Item("item_type") = "52" AndAlso .Item("item_code") = "004" Then  '担保费收取审批意见
                            drs = dsTemp.Tables(0).Select("item_code='002'")
                            If Not drs.Length = 0 Then
                                .Item("income") = drs(0)("payout")        '担保费
                            End If
                        End If
                    End With
                Next
            End If
            Me.dgProjectOpinion.DataSource = ds.Tables(0).DefaultView
        End If
        ds = gWs.GetConfTrialInfo("{project_code='" & ProjectCode & "'}", "null")
        If Not ds.Tables(0).Rows.Count = 0 Then
            Me.dgProjectConferenceTrial.DataSource = ds.Tables(0).DefaultView
        End If
        ds = gWs.GetCooperateOpinionInfo("null", "{project_code='" & ProjectCode & "'}")
        If Not ds.Tables(1).Rows.Count = 0 Then
            Me.dgProjectCorpAreaOpinion.DataSource = ds.Tables(1).DefaultView
        End If
    End Sub

#Region "项目文档"
    '获取项目文档清单
    Private Sub GetProjectFileInfo(ByVal ProjectCode As String)
        'ds = gWs.GetProjectFileByCondition("{project_code='" & ProjectCode & "' and item_type in ('43','45') }")
        ds = gWs.GetCommonQueryInfo("select serial_num,project_code,item_type,item_code,title,author,[date],version,remark,file_type from project_files where project_code='" & ProjectCode & "' and item_type in ('43','45') order by [date]")
        If Not ds.Tables(0).Rows.Count = 0 Then
            Me.AddColumnItemName(ds)
            Me.grdProjectDoc.DataSource = ds.Tables(0).DefaultView
            Me.strFileTitle = Me.grdProjectDoc.Item(0, 2).ToString().Trim()
            Me.strFileType = Me.grdProjectDoc.Item(0, 7).ToString().Trim()
        Else
            Me.btnCheckFile.Enabled = False
        End If
    End Sub
    '打开文档按钮
    Private Sub btnCheckFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckFile.Click
        If Me.strFileTitle = "" And Me.strFileType = "" Then
            Return
        End If
        Dim strSql As String
        Dim bHaveRight As Boolean = False
        strSql = "{staff_name = '" & UserName & "' AND Role_id = '26'" & "}"
        Dim dsTemp As DataSet = gWs.GetStaffByRoleID(strSql)
        If Not dsTemp.Tables(0).Rows.Count = 0 Then
            bHaveRight = True
        End If
        If Not bHaveRight Then
            strSql = "{staff_name = '" & UserName & "' AND Role_id = '29'" & "}"
            dsTemp = gWs.GetStaffByRoleID(strSql)
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                strSql = "{staff_name = '" & UserName & "' AND dept_name = '" & Me.branch_name & "'}"
                dsTemp = gWs.GetStaff(strSql)
                If Not dsTemp.Tables(0).Rows.Count = 0 Then              '项目分配人员且项目视图中的branch_name与用户部门相同
                    bHaveRight = True
                End If
            End If
        End If

        '2007-07-13 yjf add
        '托管的项目经理不管是否为责任人都可查看文档
        If Not bHaveRight Then
            strSql = "select manager_a from project_responsible where project_code='" & Me.strProjectCode & "' and manager_a='" & UserName & "'"
            dsTemp = gWs.GetCommonQueryInfo(strSql)
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                bHaveRight = True
            End If

            If Not bHaveRight Then
                strSql = "select attend_person from project_task_attendee where project_code='" & Me.strProjectCode & "' and attend_person='" & UserName & "'and role_id='24'"
                dsTemp = gWs.GetCommonQueryInfo(strSql)
                If Not dsTemp.Tables(0).Rows.Count = 0 Then
                    bHaveRight = True
                End If
            End If

        End If

        '2007-07-30 yjf add
        '托管的项目经理B不管是否为责任人都可查看文档
        If Not bHaveRight Then
            strSql = "select manager_b from project_responsible where project_code='" & Me.strProjectCode & "' and manager_b='" & UserName & "'"
            dsTemp = gWs.GetCommonQueryInfo(strSql)
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                bHaveRight = True
            End If

            If Not bHaveRight Then
                strSql = "select attend_person from project_task_attendee where project_code='" & Me.strProjectCode & "' and attend_person='" & UserName & "'and role_id='25'"
                dsTemp = gWs.GetCommonQueryInfo(strSql)
                If Not dsTemp.Tables(0).Rows.Count = 0 Then
                    bHaveRight = True
                End If
            End If

        End If

        '2008-3-5 YJF ADD 判断是否为系统制作的PDF合同,如果是则使用PDF制作并打开
        Dim dtFiles As DataTable = CType(grdProjectDoc.DataSource, DataView).Table
        If Not dtFiles.Rows(grdProjectDoc.CurrentRowIndex).Item("serial_num") Is System.DBNull.Value Then
            Dim strSerialNum As String = dtFiles.Rows(grdProjectDoc.CurrentRowIndex).Item("serial_num")
            Dim strContractName As String = dtFiles.Rows(grdProjectDoc.CurrentRowIndex).Item("title")
            Dim strItemType As String = dtFiles.Rows(grdProjectDoc.CurrentRowIndex).Item("item_type")
            Dim strItemCode As String = dtFiles.Rows(grdProjectDoc.CurrentRowIndex).Item("item_code")

            Dim dsTempItem As DataSet = gWs.GetItemEx("{item_type='" & strItemType & "' and item_code='" & strItemCode & "'}")
            Dim strPDFRemark = IIf(IsDBNull(dsTempItem.Tables(0).Rows(0).Item("additional_remark")), "", dsTempItem.Tables(0).Rows(0).Item("additional_remark"))
            If strPDFRemark = "PDF" Then
                PrintPDF(Me.strProjectCode, strItemType, strItemCode, strContractName)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If

        '需要调用阙兴登文档类中方法
        '所传入参数：项目编号，文档类型，文档版本号           '只有当前用户为项目经理或自己创建的文档或者是评委才可以查看
        If UserName = Me.txtProjectManagerA.Text Or UserName = Me.grdProjectDoc.Item(Me.grdProjectDoc.CurrentRowIndex, 3) Or bHaveRight Then
            Me.Cursor = Cursors.WaitCursor
            Try
                Me.OpenDoc()
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            Finally
                Me.Cursor = Cursors.Default
            End Try
        Else
            SWDialogBox.MessageBox.Show("!1001")
        End If
    End Sub

    Private Sub OpenDoc()
        Dim strPath As String = Application.StartupPath & "\TempDoc"

        If Not System.IO.Directory.Exists(strPath) Then
            System.IO.Directory.CreateDirectory(strPath)
        End If

        If Me.strFileType.Length < 3 Then
            strPath += "\" & getLegalFileName(Me.strFileTitle) & "." & Me.strFileType
        Else
            strPath += "\" & getLegalFileName(Me.strFileTitle) & "." & Me.strFileType.Substring(0, 3)
        End If

        If System.IO.File.Exists(strPath) Then
            Try
                System.IO.File.Delete(strPath)
            Catch
                SWDialogBox.MessageBox.Show("该文件正由另一进程使用", "提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
                Return
                '判断文件是否存在,如果存在则删除;如果删除出错,说明文件已经被另一进程占用了.则不创建新的文件
            End Try
        End If

        Try
            '2008-5-5 yjf edit 修改项目信息中取文档不取DOCUMENT字段后，需要重新获取的问题
            Dim iSerialNum As Integer = CType(Me.grdProjectDoc.DataSource, DataView)(Me.grdProjectDoc.CurrentRowIndex).Item("serial_num")
            Dim dsDocument As DataSet = gWs.GetCommonQueryInfo("select document from project_files where serial_num=" & iSerialNum)
            Dim document As Object = dsDocument.Tables(0).Rows(0).Item("document")

            If IsDBNull(document) Then
                SWDialogBox.MessageBox.Show("数据库中不存在该文件", "提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
                Return
            End If
            Dim data As Byte() = CType(document, Byte())
            Dim fs = New System.IO.FileStream(strPath, IO.FileMode.Create, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite, 5)
            fs.Write(data, 0, data.Length)
            fs.Close()
            System.Diagnostics.Process.Start(strPath)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            GC.Collect()
        End Try
    End Sub

    '点击grdProjectDoc时，设置FileTitle和FileVersion
    Private Sub grdProjectDoc_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdProjectDoc.CurrentCellChanged
        If Me.grdProjectDoc.DataSource Is Nothing Then
            Return
        End If
        Me.grdProjectDoc.Select(Me.grdProjectDoc.CurrentCell.RowNumber)
        Me.strFileTitle = Me.grdProjectDoc.Item(Me.grdProjectDoc.CurrentRowIndex, 2).ToString().Trim()
        Me.strFileType = Me.grdProjectDoc.Item(Me.grdProjectDoc.CurrentRowIndex, 7).ToString().Trim()
    End Sub
    '双击查看项目文档
    Private Sub grdProjectDoc_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdProjectDoc.DoubleClick
        Me.btnCheckFile_Click(Nothing, Nothing)  '调用打开文档按钮
    End Sub
#End Region

    '项目材料清单
    Private Sub GetProjectMaterial(ByVal ProjectCode As String)
        Me.ds = gWs.GetProjectDocumentByCondition("{item_type in ('41','42') and check_person is not null and project_code like '" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            Me.grdProjectMaterial.DataSource = Me.ds.Tables(0).DefaultView
        End If
    End Sub

#Region "财务数据"
    '获取阶段
    Private Sub GetPhaseList(ByVal cbo As ComboBox)
        ds = gWs.GetPhase("%")
        If Not ds.Tables(0).Rows.Count = 0 Then
            cbo.Items.Clear()
            For i = 0 To ds.Tables(0).Rows.Count - 1
                cbo.Items.Add(ds.Tables(0).Rows(i).Item("phase_name"))
            Next
        End If
    End Sub
    '获取保证企业　
    Private Sub GetAssureCorp(ByVal cbo As ComboBox)
        Dim dt As New DataTable
        dt.Columns.Add(New DataColumn("corporation_code", GetType(String)))
        dt.Columns.Add(New DataColumn("corporation_name", GetType(String)))

        dt.Rows.Add(New Object() {Me.GetCorpCode(Me.strProjectCode), ""})

        ds = gWs.FetchProjectCorporation(strProjectCode, "%", "2", "评审")
        If Not ds.Tables(0).Rows.Count = 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                With ds.Tables(0).Rows(i)
                    dt.Rows.Add(New Object() {.Item("corporation_code"), .Item("corporation_name")})
                End With
            Next
        End If

        cbo.DataSource = dt
        cbo.DisplayMember = "corporation_name"
        cbo.ValueMember = "corporation_code"
    End Sub

    '获取财务数据
    Private Sub btnFinanceSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinanceSearch.Click
        If Me.cmbFinancePhase.Text = "" Then
            'MessageBox.Show("请选择阶段信息进行操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1007", "阶段信息")
            Me.cmbFinancePhase.Focus()
            Return
        End If

        Me.Cursor = Cursors.WaitCursor
        Try
            Me.GetFinanceDebtData(Me.strProjectCode, Me.cmbFinancePhase.Text.Trim())
            Me.GetFinanceBenefitData(Me.strProjectCode, Me.cmbFinancePhase.Text.Trim())
            Me.GetFinanceCashExchangeData(Me.strProjectCode, Me.cmbFinancePhase.Text.Trim())
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '获取资产负债表数据
    Private Sub GetFinanceDebtData(ByVal ProjectCode As String, ByVal Phase As String)
        ds = gWs.GetFinanceReviewData(ProjectCode, Me.cboAssureCorp.SelectedValue, Phase, "01")
        Dim ts As DataGridTableStyle = New DataGridTableStyle     'modified by hute 2003-10-30 加入DataGridTableStyle
        Me.dgFinanceDebt.DataSource = Me.ShowDataGridTitleContent(ds, ds.Tables(0).Columns.Count, ts).Tables(0).DefaultView
        Me.dgFinanceDebt.TableStyles.Clear()
        Me.dgFinanceDebt.TableStyles.Add(ts)
    End Sub
    '获取利润表数据
    Private Sub GetFinanceBenefitData(ByVal ProjectCode As String, ByVal Phase As String)
        ds = gWs.GetFinanceReviewData(ProjectCode, Me.cboAssureCorp.SelectedValue, Phase, "02")
        Dim ts As DataGridTableStyle = New DataGridTableStyle      'modified by hute 2003-10-30 加入DataGridTableStyle
        Me.dgFinanceBenifit.DataSource = Me.ShowDataGridTitleContent(ds, ds.Tables(0).Columns.Count, ts).Tables(0).DefaultView
        Me.dgFinanceBenifit.TableStyles.Clear()
        Me.dgFinanceBenifit.TableStyles.Add(ts)
    End Sub
    '获取现金流量表数据
    Private Sub GetFinanceCashExchangeData(ByVal ProjectCode As String, ByVal Phase As String)
        ds = gWs.GetFinanceReviewData(ProjectCode, Me.cboAssureCorp.SelectedValue, Phase, "03")
        Dim ts As DataGridTableStyle = New DataGridTableStyle      'modified by hute 2003-10-30 加入DataGridTableStyle
        Me.dgFinanceCashExchange.DataSource = Me.ShowDataGridTitleContent(ds, ds.Tables(0).Columns.Count, ts).Tables(0).DefaultView
        Me.dgFinanceCashExchange.TableStyles.Clear()
        Me.dgFinanceCashExchange.TableStyles.Add(ts)
    End Sub
    '为财务数据三张表加入TableStyle
    Private Function ShowDataGridTitleContent(ByVal ds As DataSet, ByVal Cols As Integer, ByVal ts As DataGridTableStyle) As DataSet
        ts.MappingName = ds.Tables(0).TableName
        Dim strTemp As String
        For i = 0 To Cols - 1
            Dim col As DataGridTextBoxColumn = New DataGridTextBoxColumn
            If i = 0 Then
                ds.Tables(0).Columns(i).ColumnName = "内容显示"
                col.HeaderText = "内容显示"
                col.Width = 220
                col.MappingName = "内容显示"
            Else
                strTemp = Me.FormatColName(ds.Tables(0).Columns(i).ColumnName.ToString().Trim())
                ds.Tables(0).Columns(i).ColumnName = strTemp
                col.HeaderText = strTemp
                col.Width = 88
                col.MappingName = strTemp
                col.Alignment = HorizontalAlignment.Right
                col.Format = "n"
            End If
            ts.GridColumnStyles.Add(col)
        Next i
        Return ds
    End Function
    '将类似"c200301"的字符串转化为"2003年01月
    Private Function FormatColName(ByVal ColName As String) As String
        ColName = ColName.Remove(0, 1)
        ColName = ColName.Insert(4, "年")
        ColName = ColName.Insert(7, "月")
        Return ColName
    End Function

    '查询资信评分
    Private Sub btnCheckCredit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckCredit.Click
        If Me.cmbFinancePhase.Text.Trim() = "" Then
            'MessageBox.Show("请选择项目阶段查询资信评分。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1007", "阶段信息")
            Me.cmbFinancePhase.Focus()
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim f As New FProjectCredit
            f.bCanEdit = False  '资信评分数据不可以修改
            f.Show()
            f.SetEditState(False)
            f.ShowDialog(Me.strProjectCode, Me.cboAssureCorp.SelectedValue, Me.cmbFinancePhase.Text.Trim())
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '财务数据的阶段选择
    Private Sub cmbFinancePhase_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbFinancePhase.SelectedIndexChanged
        If Me.cboAssureCorp.Items.Count = 1 Then
            Return
        End If

        If Me.cmbFinancePhase.Text = "评审" Then
            Me.cboAssureCorp.Visible = True
            Me.lblAssureCorp.Visible = True
        Else
            Me.cboAssureCorp.Visible = False
            Me.cboAssureCorp.SelectedIndex = 0
            Me.lblAssureCorp.Visible = False
        End If
    End Sub

#End Region

    '评审会结论查询
    Private Sub dgProjectConferenceTrial_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgProjectConferenceTrial.DoubleClick
        If Not Me.txtProjectType.Text = "保函" Then
            Dim meet As New frmMeetRecordQuery(Me.strProjectCode, Me.strEnterpriseName)
            meet.AllowTransparency = False
            meet.ShowDialog()
        ElseIf gWs.GetConfTrialInfo("{project_code = '" + Me.strProjectCode + "'}", "NULL").Tables("conference_trial").Rows.Count > 0 Then  '保函品种且开过评审会
            frmChangeGuarantyFee.OpenWord(Me.strProjectCode, Me, Me.strEnterpriseName & "评审会意见表", True, Me.strEnterpriseName)
        Else
            Dim apply_date As DateTime = Money.GetApplyDate(strProjectCode)
            Dim dsLetter As DataSet = gWs.GetGuaranteeLetter(strProjectCode.Substring(0, 5), apply_date)
            Dim fileProjectCode As String
            If dsLetter.Tables(0).Rows.Count > 0 Then
                fileProjectCode = dsLetter.Tables(0).Rows(0)("project_code") & String.Empty
                frmChangeGuarantyFee.OpenWord(fileProjectCode, Me, Me.strEnterpriseName & "评审会意见表", False, String.Empty)
            End If
        End If
    End Sub
    '查看保前调研记录
    Private Sub btnPreVouchRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreVouchRecord.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim frm As New frmShowVouchRecord(Me.strProjectCode, Me.strEnterpriseName, "PreguaranteeActivity")
            frm.Text = "保前调研记录"
            frm.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '保后跟踪记录
    Private Sub btnAftVouchRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAftVouchRecord.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim frm As New frmShowVouchRecord(Me.strProjectCode, Me.strEnterpriseName, "RecordProjectProcess")
            frm.Text = "保后跟踪记录"
            frm.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '获取企业附加信息
    Private Sub GetCorporaionSubInfo(ByVal ProjectCode As String, ByVal CorpName As String)
        Call Me.ProjectAcceptInfo(ProjectCode, CorpName)    '项目受理信息
        Call Me.ProjectVouchInfo(ProjectCode, CorpName)     '项目承保信息
        Call Me.CorpSubInfo(ProjectCode, CorpName)          '企业附加信息
    End Sub

    '项目受理信息
    Private Sub ProjectAcceptInfo(ByVal ProjectCode As String, ByVal CorpName As String)
        Dim BankCode, BranchBankCode As String

        ds = gWs.GetProjectInfo("{project_code like '" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtApplyServiceType.Text = IIf(.Item("apply_service_type") Is System.DBNull.Value, "", .Item("apply_service_type")) '申请业务品种
                If Me.txtProjectType.Text.Trim() = "" Then
                    Me.txtProjectType.Text = Me.txtApplyServiceType.Text
                End If
                Me.txtRecommander.Text = IIf(.Item("recommend_person") Is System.DBNull.Value, "", .Item("recommend_person"))
                Me.txtApplyGuaranteeSum.Text = IIf(.Item("apply_sum") Is System.DBNull.Value, "", .Item("apply_sum"))
                Me.txtApplyTerms.Text = IIf(.Item("apply_term") Is System.DBNull.Value, "", .Item("apply_term"))
                Me.txtAcceptPerson.Text = IIf(.Item("create_person") Is System.DBNull.Value, "", .Item("create_person"))
                BankCode = IIf(.Item("apply_bank") Is System.DBNull.Value, "", .Item("apply_bank"))
                Me.txtApplyBank.Text = Me.GetBankName(BankCode, Nothing)
                BranchBankCode = IIf(.Item("apply_branch_bank") Is System.DBNull.Value, "", .Item("apply_branch_bank"))
                Me.txtApplyBranchBank.Text = Me.GetBankName(BankCode, BranchBankCode)
            End With
        End If
        '添加项目的初审人员，资产评估师，法务经理
        If Not Me.dsProjInfoView.Tables(0).Rows.Count = 0 Then
            With Me.dsProjInfoView.Tables(0).Rows(0)
                Me.txtFirstChecker.Text = IIf(.Item("first_review_person") Is System.DBNull.Value, "", .Item("first_review_person")) '13
                Me.txtEvaler.Text = IIf(.Item("assets_valuator") Is System.DBNull.Value, "", .Item("assets_valuator"))  '34
                Me.txtLawManager.Text = IIf(.Item("law_manager") Is System.DBNull.Value, "", .Item("law_manager"))  '33
            End With
        End If
    End Sub
    '项目承保信息
    Private Sub ProjectVouchInfo(ByVal ProjectCode As String, ByVal CorpName As String)
        Try
            If Not Me.dsProjInfoView.Tables(0).Rows.Count = 0 Then
                With Me.dsProjInfoView.Tables(0).Rows(0)
                    '签约日期
                    If Not (.Item("sign_date") Is System.DBNull.Value) Then
                        Me.dtpSignDate.Text = Format(.Item("sign_date"), "yyyy年MM月dd日")
                    Else
                        Me.dtpSignDate.Text = ""
                    End If
                    '签约金额
                    If Not (.Item("sign_sum") Is System.DBNull.Value) Then '1
                        Me.txtAcceptSum.Text = (.Item("sign_sum"))
                    Else
                        txtAcceptSum.Text = String.Empty
                    End If
                    '承保金额
                    If Not (.Item("loan_sum") Is System.DBNull.Value) Then '2
                        Me.txtVouchSum.Text = (.Item("loan_sum"))
                        Dim tempVouchSum As Single = CType(Me.txtVouchSum.Text, Single)
                        Me.txtVouchSum.Text = Convert.ToString(tempVouchSum)
                    Else
                        Me.txtVouchSum.Text = String.Empty
                        'Me.txtVouchSum.Text = ""
                    End If
                    '还款金额
                    If Not (.Item("refund_sum") Is System.DBNull.Value) Then '3
                        Me.txtRefundSum.Text = (.Item("refund_sum"))
                        Dim tempRefundSum As Single = CType(Me.txtRefundSum.Text, Single) / 10000.0 '单位万元
                        Me.txtRefundSum.Text = Convert.ToString(tempRefundSum)
                    Else
                        Me.txtRefundSum.Text = String.Empty
                        'Me.txtRefundSum.Text = ""
                    End If
                    '逾期金额
                    If Not (.Item("overdue_sum") Is System.DBNull.Value) Then '4
                        Me.txtOvertimeSum.Text = (.Item("overdue_sum"))
                        Dim tempOverdueSum As Single = CType(Me.txtOvertimeSum.Text, Single) / 10000.0 '单位万元
                        Me.txtOvertimeSum.Text = Convert.ToString(tempOverdueSum)
                    Else
                        Me.txtOvertimeSum.Text = String.Empty
                    End If
                    '代偿金额
                    If Not (.Item("debt_sum") Is System.DBNull.Value) Then '5
                        Me.txtReplaceSum.Text = (CDbl(.Item("debt_sum")) / 10000).ToString("n")  '单位万元                    
                    Else
                        Me.txtReplaceSum.Text = String.Empty
                    End If
                    ''在保金额----
                    'Dim VouchNum As Single
                    'Dim RefundNum As Single
                    'Dim tempNum As Single
                    'Try
                    '    If (Not (Me.txtVouchSum.Text = String.Empty)) Then
                    '        VouchNum = CType(Me.txtVouchSum.Text, Single)
                    '        If (Not (Me.txtRefundSum.Text = String.Empty)) Then
                    '            RefundNum = CType(Me.txtRefundSum.Text, Single)
                    '            tempNum = VouchNum - RefundNum  '"承保金额" 减去 "还款金额"
                    '            Me.txtOnVouchSum.Text = Convert.ToString(tempNum)
                    '        Else
                    '            Me.txtOnVouchSum.Text = Convert.ToString(VouchNum)
                    '        End If
                    '    Else
                    '        Me.txtOnVouchSum.Text = String.Empty
                    '    End If
                    'Catch ex As Exception
                    '    ExceptionHandler.ShowMessageBox(ex)
                    'End Try

                    '2008-4-3 yjf edit 直接取视图中的在保余额
                    '在保余额
                    If Not (.Item("guaranting_sum") Is System.DBNull.Value) Then '2
                        Me.txtOnVouchSum.Text = (.Item("guaranting_sum"))
                        Dim tempOnVouchSum As Single = CType(Me.txtOnVouchSum.Text, Single) / 10000.0 '单位万元
                        Me.txtOnVouchSum.Text = Convert.ToString(tempOnVouchSum)
                    Else
                        Me.txtOnVouchSum.Text = String.Empty
                        'Me.txtVouchSum.Text = ""
                    End If

                    '放款起始日期
                    If Not (.Item("StartTime") Is System.DBNull.Value) Then
                        Me.dtpAcceptStartDate.Text = Format(.Item("StartTime"), "yyyy年MM月dd日")
                    Else
                        ' 如果为空,金额赋回
                        '－－－－－－－－－－－－－－－－
                        Me.txtVouchSum.Text = String.Empty       '承保金额
                        Me.txtRefundSum.Text = String.Empty      '还款金额
                        Me.txtOvertimeSum.Text = String.Empty    '逾期金额
                        Me.txtReplaceSum.Text = String.Empty     '代偿金额
                        Me.txtOnVouchSum.Text = String.Empty     '在保金额
                        '------------------------------------
                        Me.dtpAcceptStartDate.Text = ""
                    End If
                    '放款截止日期
                    If Not (.Item("EndTime") Is System.DBNull.Value) Then
                        Me.dtpAcceptEndDate.Text = Format(.Item("EndTime"), "yyyy年MM月dd日")
                    Else
                        Me.dtpAcceptEndDate.Text = ""
                    End If
                    '贷款银行
                    If Not (.Item("BankName") Is System.DBNull.Value) Then '7
                        Me.txtVouchBank.Text = (.Item("BankName")) 'BankName
                    Else
                        Me.txtVouchBank.Text = String.Empty
                    End If
                    '贷款支行
                    If Not (.Item("BranchBankName") Is System.DBNull.Value) Then '8
                        Me.txtVouchBranchBank.Text = (.Item("BranchBankName")) 'BranchBankName
                    Else
                        Me.txtVouchBranchBank.Text = String.Empty
                    End If
                End With
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '企业附加信息
    Private Sub CorpSubInfo(ByVal ProjectCode As String, ByVal CorpName As String)
        ds = gWs.GetcorporationInfo("{corporation_code like '" & Me.GetCorpCode(ProjectCode) & "'}", "null")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                If Not IsDBNull(.Item("found_date")) Then
                    Me.dtpFoundDate.Text = Format(.Item("found_date"), "yyyy年MM月dd日")
                End If
                Me.txtLicenseNO.Text = IIf(IsDBNull(.Item("business_licence_code")), "", .Item("business_licence_code"))
                Me.txtVouchCardNO.Text = IIf(IsDBNull(.Item("loan_card_id")), "", .Item("loan_card_id"))
                Me.txtWebSite.Text = IIf(IsDBNull(.Item("web_site")), "", .Item("web_site"))
            End With
        End If
        'ds = gWs.FetchProjectCorporation(ProjectCode)
        ds = gWs.FetchProjectCorporation(ProjectCode, "%", "1", "%")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtRegisterSum.Text = IIf(IsDBNull(.Item("register_capital")), "", .Item("register_capital"))
                Me.txtSumCapital.Text = IIf(IsDBNull(.Item("total_capital_stock")), "", .Item("total_capital_stock"))
            End With
        End If
        ds = gWs.GetProjectInfo("{project_code = '" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.chkIsFirstVouch.Checked = IIf(IsDBNull(.Item("is_first_loan")), False, .Item("is_first_loan"))
            End With
        End If
    End Sub

#Region "反担保物"
    '获取反担保物
    Private Sub GetOppGuaranteeInfo(ByVal ProjectCode As String)
        Try
            ds = gWs.GetProjectGuaranteeFormAdd("{project_code = '" & ProjectCode & "'}")
            ds.Merge(gWs.GetItemType("%").Tables("TItemType"))

            ds.Tables(0).Columns.Add("guaranty_name", GetType(String))
            Dim dr As DataRow
            Dim drs() As DataRow
            For Each dr In ds.Tables(0).Rows
                If Not IsDBNull(dr("guaranty")) Then
                    drs = ds.Tables(1).Select("item_type='" & dr("guaranty") & "'")
                    If Not drs.Length = 0 Then
                        dr("guaranty_name") = drs(0)("type_name")
                    End If
                End If
                dr("is_checked") = IIf(IsDBNull(dr("is_checked")), False, True)
            Next
            Me.grdGuaranteeFormAdditional.DataSource = ds.Tables(0)

            dsGuaForm = gWs.GetProjectGuaranteeForm("{project_code = '" & ProjectCode & "'}")
            If dsGuaForm.Tables(0).Rows.Count = 0 Then Return

            'dsProCor = gWs.FetchProjectCorporation(ProjectCode", "%", "2", "%")
            dsProCor = gWs.FetchProjectCorporation("{project_code='" & ProjectCode & "' and corporation_type='2' and status='评审通过'}")
            dsPerson = gWs.GetOppositeGuaranteeAssurerInfo("{project_code = '" & ProjectCode & "' and status='评审通过'}")
            dsGuaranty = gWs.GetGuarantyInfo("{project_code = '" & ProjectCode & "' and status in ('评审通过','抵押质押','解除') ORDER BY opposite_guarantee_form}", "null")
            Dim dsItemType As DataSet = gWs.GetItemType("%") '

            dsPerson.Tables("opposite_guarantee_assurer").Columns.Add("is_used", GetType(Boolean), "IIf(status='评审通过',true,false)")
            dsProCor.Tables("TProjectCorporation").Columns.Add("is_used", GetType(Boolean), "IIf(status='评审通过',true,false)")
            dsGuaranty.Tables("opposite_guarantee").Columns.Add("is_used", GetType(Boolean), "IIf(status='评审通过' OR status='抵押质押' OR status='解除',true,false)")
            dsGuaranty.Tables("opposite_guarantee").Columns.Add("ItemName", GetType(String))
            dsGuaForm.Tables("TProjectGuaranteeForm").Columns.Add("ItemName", GetType(String))
            For Each dr In dsGuaranty.Tables("opposite_guarantee").Rows
                dr("ItemName") = dsItemType.Tables("TItemType").Select("item_type='" & dr("guaranty_type") & "'")(0)("type_name")
            Next
            For Each dr In dsGuaForm.Tables("TProjectGuaranteeForm").Rows
                If IsDBNull(dr("guaranty")) Then
                    dr("ItemName") = DBNull.Value
                Else
                    dr("ItemName") = dsItemType.Tables("TItemType").Select("item_type='" & dr("guaranty") & "'")(0)("type_name")
                End If
            Next
            ''''''''''删除没有采用的反担保物'''''''''''''''''''
            For Each dr In dsGuaForm.Tables("TProjectGuaranteeForm").Rows
                If Not CBool(dr("is_used")) Then
                    dr.Delete()
                End If
            Next
            For Each dr In dsPerson.Tables("opposite_guarantee_assurer").Rows
                If Not CBool(dr("is_used")) Then
                    dr.Delete()
                End If
            Next
            For Each dr In dsProCor.Tables("TProjectCorporation").Rows
                If Not CBool(dr("is_used")) Then
                    dr.Delete()
                End If
            Next
            For Each dr In dsGuaranty.Tables("opposite_guarantee").Rows
                If Not CBool(dr("is_used")) Then
                    dr.Delete()
                End If
            Next
            dsGuaForm.AcceptChanges()  'added by hute 2003-12-01
            ''''''''''删除没有采用的反担保物'''''''''''''''''''
            dgParent.DataMember = "TProjectGuaranteeForm"
            dgParent.DataSource = dsGuaForm
            AddTableStyleForOppGua()
            cmLocal = BindingContext(dsGuaForm, "TProjectGuaranteeForm")
            CType(cmLocal.List, DataView).AllowDelete = False
            CType(cmLocal.List, DataView).AllowNew = False
            AddHandler cmLocal.PositionChanged, AddressOf cm_PositionChanged
            cm_PositionChanged(Nothing, Nothing)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '反担保物措施变化，相应的datagrid产生变化
    Private Sub cm_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If cmLocal.Count = 0 Then
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
            dsGuaranty.Tables("opposite_guarantee").DefaultView.RowFilter = "opposite_guarantee_form LIKE '" & dsGuaForm.Tables(0).Rows(cmLocal.Position)("guarantee_form").ToString & _
                     "' AND guaranty_type='" & dsGuaForm.Tables(0).Rows(cmLocal.Position)("guaranty").ToString & "'"
            dsGuaranty.Tables("opposite_guarantee").DefaultView.AllowDelete = False
            dsGuaranty.Tables("opposite_guarantee").DefaultView.AllowNew = False
            dgDetail.DataSource = dsGuaranty.Tables("opposite_guarantee").DefaultView
            GuaType = ""
        End If
    End Sub

    '''''''''''''''反担保物的样式表''''''''''''''''
    Private d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf MyGetColorRowCol)
    '人个保证的datagrid样式
    Private Sub AddTableStyleOfPerson()
        dgDetail.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle
        dgts.MappingName = "opposite_guarantee_assurer"
        dgts.AllowSorting = False
        Dim col5 As DataGridColoredBoolColumn = New DataGridColoredBoolColumn(d, 0)
        col5.MappingName = "is_used"
        col5.AllowNull = False
        col5.ReadOnly = True
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
        col1.Alignment = HorizontalAlignment.Center
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
        col4.Width = 324
        col4.NullText = ""
        dgts.GridColumnStyles.Add(col4)
        dgDetail.TableStyles.Add(dgts)
    End Sub
    '公司保证的datagrid样式
    Private Sub AddTableStyleOfCompany()
        dgDetail.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle
        dgts.MappingName = "TProjectCorporation"
        dgts.AllowSorting = False
        Dim col5 As DataGridColoredBoolColumn = New DataGridColoredBoolColumn(d, 0)
        col5.MappingName = "is_used"
        col5.AllowNull = False
        col5.ReadOnly = True
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
        col1.MappingName = "contact_person"
        col1.ReadOnly = True
        col1.HeaderText = "联系人"
        col1.Width = 80
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
    '抵押、质押等的反担保物样式
    Private Sub AddTableStyleForOppGua()
        dgParent.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle
        dgts.MappingName = "TProjectGuaranteeForm"
        dgts.AllowSorting = False
        Dim col1 As DataGridColoredBoolColumn = New DataGridColoredBoolColumn(d, 0) ' DataGridBoolColumn = New DataGridBoolColumn()
        col1.MappingName = "is_used"
        col1.AllowNull = False
        col1.ReadOnly = True
        col1.HeaderText = "是否采用"
        col1.Width = 60
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
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col4.MappingName = "num"
        col4.ReadOnly = True
        col4.HeaderText = "数量"
        col4.Width = 40
        col4.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col4)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col5.MappingName = "guarantee_sum"
        col5.ReadOnly = True
        col5.HeaderText = "担保金额 " & ControlChars.Tab
        col5.Width = 90
        col5.Format = "c"
        col5.FormatInfo = CGFormatInfo
        col5.Alignment = HorizontalAlignment.Right
        dgts.GridColumnStyles.Add(col5)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col6.MappingName = "description"
        col6.ReadOnly = True
        col6.HeaderText = "描述"
        col6.Width = 340
        col6.NullText = ""
        col6.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col6)
        dgParent.TableStyles.Add(dgts)
    End Sub
    '为反担保物细节表加入TableStyle
    Private Sub AddTableStyleOfDetail()
        dgDetail.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle
        dgts.MappingName = "opposite_guarantee"
        dgts.AllowSorting = False
        Dim col9 As DataGridColoredBoolColumn = New DataGridColoredBoolColumn(d, 0)
        col9.MappingName = "is_used"
        col9.ReadOnly = True
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
        col4.HeaderText = "评估总值(元)"
        col4.MappingName = "evaluate_value"
        col4.NullText = "0"
        col4.Width = 80
        col4.ReadOnly = True

        'add   yansm  2013/12/4
        Dim col12 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col12.HeaderText = "评估净值(元)"
        col12.MappingName = "evaluate_net_value"
        col12.NullText = "0"
        col12.Width = 80
        col12.ReadOnly = True

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
        dgts.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {col9, col2, col1, col10, col3, col4, col12, col5, col6, col7, col8})
        dgDetail.TableStyles.Add(dgts)
    End Sub

    '查询反担保物
    Private Sub btnCheckReguarantee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCheckReguarantee.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim frm As New frmOppGuaranteeQueryCheck(Me.strProjectCode)
            frm.AllowTransparency = False
            frm.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

#End Region

    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
