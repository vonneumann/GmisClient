Option Explicit On 

Imports System.Drawing

Public Class frmMainInterface
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        mnuSystemPrint.Icon = imgMenu.Images(IMAGEPRINT)
        mnuSystemPageSetup.Icon = imgMenu.Images(IMAGEPAGESETUP)
        mnuHelpContext.Icon = imgMenu.Images(IMAGEHELPCONTEXT)
        mnuHelpIndex.Icon = imgMenu.Images(IMAGEHELPINDEX)
        mnuHelpSearch.Icon = imgMenu.Images(IMAGEHELPSEARCH)
        mnuHelpSupport.Icon = imgMenu.Images(IMAGEHELPSUPPORT)

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
    Friend WithEvents StatusBar1 As System.Windows.Forms.StatusBar
    Friend WithEvents StatusBarPanel2 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel3 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents StatusBarPanel4 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents MenuItem1 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MenuItem4 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem7 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem8 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem9 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem10 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem11 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents ToolBarButton10 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton6 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton9 As System.Windows.Forms.ToolBarButton
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents StatusBarPanel5 As System.Windows.Forms.StatusBarPanel
    Friend WithEvents MenuItem47 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton5 As System.Windows.Forms.ToolBarButton
    Friend WithEvents TlBrBttnExit As System.Windows.Forms.ToolBarButton
    Friend WithEvents TlBrMain As System.Windows.Forms.ToolBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents mnQuery As System.Windows.Forms.ContextMenu
    Friend WithEvents muHelp As System.Windows.Forms.ContextMenu
    Friend WithEvents MainMn As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem44 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem34 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem51 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem52 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem53 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem54 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem55 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem56 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem57 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem58 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem59 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem60 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem61 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem62 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem63 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem64 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem18 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemRight As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuBaseGeneral As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemProPause As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemProCancel As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem19 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem20 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemTool As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemStatic As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemProConsign As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemProCancelCon As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemProManual As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemProAssign As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemMeetQuery As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemMeetSet As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton8 As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem24 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem25 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem26 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents ToolBarBttnConsult As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBttnApply As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem28 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem29 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemBranch As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemRole As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemTeam As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemStaff As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemStaffRole As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemOrganize As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents ToolBarBttn1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarBttnRefresh As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem42 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem13 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem49 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemAccept As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemConsult As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem14 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem15 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem33 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem35 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents CntxtMnMsg As System.Windows.Forms.ContextMenu
    Friend WithEvents MnItmfreshMsg As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItmReadMsg As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItmDelMsg As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem46 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemBank As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemCreditAppraise As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemCreditSystem As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemCreditQuantity As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemQuality As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemGuaranty As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemMaterial As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemDocQry As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemCooperate As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem67 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnFincialItem As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuCorporationRelationType As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuTaskList As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuMessages As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem71 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuAlarm As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuWorkType As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuWorkLog As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuWorkLogEnter As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuWorkLogQuery As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuItem03 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem69 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuTransaction As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuBase As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuWorkFlow As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuMeeting As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuDocument As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQuery As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuTools As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuView As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuProjectDelete As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuCompanyFileManage As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem16 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryFirstTrialProject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryAcceptProject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryAllocateProject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryPresentingProject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQuerySignProject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryLoanProject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryCreditProject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryRequiteProject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryRecantProject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryProcessingProject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryRegionProject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryChargeStatistics As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem17 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuWorkFlowHoliday As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuWorkFlowTask As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuCreditProject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents btnCredit As System.Windows.Forms.ToolBarButton
    Friend WithEvents MenuItem22 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryStatisticsMarketingA As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryStatisticsMarketingB As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryStatisticsMarketingC As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem50 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryStatisticsCompensation As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryStatisticsRegion As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryStatisticsCounterguarantee As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuQueryStatisticsPMService As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuWorkLogStatistics As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemModifyGuaranty As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuDataItem04 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpIndex As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpContext As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemRemeet As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem30 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem31 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemStatisticsFee As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnItemGuaranteeLetterType As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnItemReimburseType As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemStatisticsRecommendproject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemQrySignaturePlan As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemUnSignProject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemStaticsFirstLoan As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemQueryGuaranteeForm As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MnItemOrganization As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents imgMenu As System.Windows.Forms.ImageList
    Friend WithEvents mnuSystem As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuSystemLogin As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuSystemSeparator1 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuSystemPageSetup As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuSystemPreview As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuSystemPrint As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuSystemSeparator2 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuSystemExit As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpAbout As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem23 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuToolsNotepad As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuToolsCalculator As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem36 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem27 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpSeparator1 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpSearch As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpSupport As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpSeparator2 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuToolsPassword As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuToolsOptions As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem32 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuUpdateMeetRecord As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuChargeFee As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuTransactionSeparator1 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuUnDealProject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuGuaranteeProject As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuAfterGuaranteeRecord As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuItemClaim As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuItemProjectRequite As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuItemIntentLetter As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuFinancialAnalysis As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuTransactionSeparator3 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuTransactionSeparator4 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuTransactionSeparator2 As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuItemUpdateGuarantee As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuItemEvaluate As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnuItemFirReviewCancel As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mneItemUpdateProcess As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mitemWorkTime As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mitemJobTask As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mitemJobRes As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mitemPostConfig As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents mnitemWorkLog As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents muitemWorkingHour As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents muiQueryGuarantingCorporation As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents muiConferenceRoom As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents muiUpdateIntentLetter As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents muChargeManner As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuDefectRecord As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuDefectRecordEdit As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuDefectRecordAdd As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuReviewGuarantee As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuCreditManager As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuContractManage As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuProjectExp As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuQueryProjectExpandDate As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents ColNum As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColProjectCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColMessage As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColTime As System.Windows.Forms.ColumnHeader
    Friend WithEvents LstVwMsg As System.Windows.Forms.ListView
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents mnuMessagesSender As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents grpTask As System.Windows.Forms.GroupBox
    Friend WithEvents mnuSkin As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem21 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem37 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem38 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem39 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem40 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem41 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem43 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem45 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem48 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem65 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem66 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem68 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem70 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem72 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem73 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem74 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem75 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem76 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem77 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem78 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem79 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem80 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuBackFee As SWSystem.Windows.Forms.MenuItem
    Friend WithEvents MenuItem81 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem82 As System.Windows.Forms.MenuItem
    Friend WithEvents task_name_tree As System.Windows.Forms.TreeView

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainInterface))
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("任务列表")
        Me.StatusBar1 = New System.Windows.Forms.StatusBar
        Me.StatusBarPanel2 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel3 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel5 = New System.Windows.Forms.StatusBarPanel
        Me.StatusBarPanel4 = New System.Windows.Forms.StatusBarPanel
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.mnQuery = New System.Windows.Forms.ContextMenu
        Me.MenuItem1 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem2 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem3 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem4 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem5 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem6 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem7 = New SWSystem.Windows.Forms.MenuItem
        Me.muHelp = New System.Windows.Forms.ContextMenu
        Me.MenuItem8 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem9 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem11 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem10 = New SWSystem.Windows.Forms.MenuItem
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.grpTask = New System.Windows.Forms.GroupBox
        Me.task_name_tree = New System.Windows.Forms.TreeView
        Me.CntxtMnMsg = New System.Windows.Forms.ContextMenu
        Me.MnItmfreshMsg = New SWSystem.Windows.Forms.MenuItem
        Me.MnItmReadMsg = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem47 = New SWSystem.Windows.Forms.MenuItem
        Me.MnItmDelMsg = New SWSystem.Windows.Forms.MenuItem
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.ToolBarButton10 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBttnConsult = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBttn1 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarBttnRefresh = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton6 = New System.Windows.Forms.ToolBarButton
        Me.btnCredit = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton9 = New System.Windows.Forms.ToolBarButton
        Me.TlBrBttnExit = New System.Windows.Forms.ToolBarButton
        Me.TlBrMain = New System.Windows.Forms.ToolBar
        Me.ToolBarBttnApply = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton5 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton8 = New System.Windows.Forms.ToolBarButton
        Me.MainMn = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuSystem = New SWSystem.Windows.Forms.MenuItem
        Me.mnuSystemLogin = New SWSystem.Windows.Forms.MenuItem
        Me.mnuSystemSeparator1 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuToolsPassword = New SWSystem.Windows.Forms.MenuItem
        Me.mnuMessages = New SWSystem.Windows.Forms.MenuItem
        Me.mnuMessagesSender = New SWSystem.Windows.Forms.MenuItem
        Me.mnuSystemPageSetup = New SWSystem.Windows.Forms.MenuItem
        Me.mnuSystemPreview = New SWSystem.Windows.Forms.MenuItem
        Me.mnuSystemPrint = New SWSystem.Windows.Forms.MenuItem
        Me.mnuSystemSeparator2 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuSystemExit = New SWSystem.Windows.Forms.MenuItem
        Me.mnuTransaction = New SWSystem.Windows.Forms.MenuItem
        Me.mnuChargeFee = New SWSystem.Windows.Forms.MenuItem
        Me.mnuBackFee = New SWSystem.Windows.Forms.MenuItem
        Me.mnuTransactionSeparator1 = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemConsult = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemAccept = New SWSystem.Windows.Forms.MenuItem
        Me.mnuTransactionSeparator2 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuCreditManager = New SWSystem.Windows.Forms.MenuItem
        Me.MenuDefectRecord = New SWSystem.Windows.Forms.MenuItem
        Me.MenuDefectRecordAdd = New SWSystem.Windows.Forms.MenuItem
        Me.MenuDefectRecordEdit = New SWSystem.Windows.Forms.MenuItem
        Me.mnuCreditProject = New SWSystem.Windows.Forms.MenuItem
        Me.mnuFinancialAnalysis = New SWSystem.Windows.Forms.MenuItem
        Me.mnuTransactionSeparator3 = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemModifyGuaranty = New SWSystem.Windows.Forms.MenuItem
        Me.mnuTransactionSeparator4 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuMeeting = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemMeetQuery = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemMeetSet = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemQrySignaturePlan = New SWSystem.Windows.Forms.MenuItem
        Me.mnuWorkFlow = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemProPause = New SWSystem.Windows.Forms.MenuItem
        Me.mnuItemFirReviewCancel = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemProCancel = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemProConsign = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemProCancelCon = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemProManual = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemProAssign = New SWSystem.Windows.Forms.MenuItem
        Me.mnuUpdateMeetRecord = New SWSystem.Windows.Forms.MenuItem
        Me.muiUpdateIntentLetter = New SWSystem.Windows.Forms.MenuItem
        Me.mnuItemClaim = New SWSystem.Windows.Forms.MenuItem
        Me.mnuProjectDelete = New SWSystem.Windows.Forms.MenuItem
        Me.MenuReviewGuarantee = New SWSystem.Windows.Forms.MenuItem
        Me.mnuItemUpdateGuarantee = New SWSystem.Windows.Forms.MenuItem
        Me.MenuProjectExp = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem17 = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemRemeet = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem31 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuWorkFlowHoliday = New SWSystem.Windows.Forms.MenuItem
        Me.mnuWorkFlowTask = New SWSystem.Windows.Forms.MenuItem
        Me.mneItemUpdateProcess = New SWSystem.Windows.Forms.MenuItem
        Me.mnuBase = New SWSystem.Windows.Forms.MenuItem
        Me.mnuBaseGeneral = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem53 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem62 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem59 = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemBank = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemCooperate = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem51 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem63 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuCorporationRelationType = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem34 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem52 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem56 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem54 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem55 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem60 = New SWSystem.Windows.Forms.MenuItem
        Me.muChargeManner = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem61 = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemMaterial = New SWSystem.Windows.Forms.MenuItem
        Me.MnFincialItem = New SWSystem.Windows.Forms.MenuItem
        Me.mnuAlarm = New SWSystem.Windows.Forms.MenuItem
        Me.mnuWorkType = New SWSystem.Windows.Forms.MenuItem
        Me.mnuItem03 = New SWSystem.Windows.Forms.MenuItem
        Me.mnItemGuaranteeLetterType = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem58 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem57 = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemGuaranty = New SWSystem.Windows.Forms.MenuItem
        Me.mnuDataItem04 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem44 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem64 = New SWSystem.Windows.Forms.MenuItem
        Me.mnItemReimburseType = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemOrganization = New SWSystem.Windows.Forms.MenuItem
        Me.muiConferenceRoom = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemOrganize = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemBranch = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemRole = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemStaff = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemStaffRole = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemTeam = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemCreditAppraise = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemCreditSystem = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemCreditQuantity = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemQuality = New SWSystem.Windows.Forms.MenuItem
        Me.mnitemWorkLog = New SWSystem.Windows.Forms.MenuItem
        Me.mitemPostConfig = New SWSystem.Windows.Forms.MenuItem
        Me.mitemJobRes = New SWSystem.Windows.Forms.MenuItem
        Me.mitemJobTask = New SWSystem.Windows.Forms.MenuItem
        Me.mitemWorkTime = New SWSystem.Windows.Forms.MenuItem
        Me.mnuDocument = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemDocQry = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem69 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuCompanyFileManage = New SWSystem.Windows.Forms.MenuItem
        Me.MenuContractManage = New SWSystem.Windows.Forms.MenuItem
        Me.mnuWorkLog = New SWSystem.Windows.Forms.MenuItem
        Me.mnuWorkLogEnter = New SWSystem.Windows.Forms.MenuItem
        Me.mnuWorkLogQuery = New SWSystem.Windows.Forms.MenuItem
        Me.mnuWorkLogStatistics = New SWSystem.Windows.Forms.MenuItem
        Me.muitemWorkingHour = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQuery = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem19 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem42 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem18 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem20 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryFirstTrialProject = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem28 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryAllocateProject = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryProcessingProject = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryAcceptProject = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryPresentingProject = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryLoanProject = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryCreditProject = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryRequiteProject = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem13 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryRecantProject = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem49 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem24 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem67 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem29 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuGuaranteeProject = New SWSystem.Windows.Forms.MenuItem
        Me.mnuAfterGuaranteeRecord = New SWSystem.Windows.Forms.MenuItem
        Me.mnuUnDealProject = New SWSystem.Windows.Forms.MenuItem
        Me.mnuItemIntentLetter = New SWSystem.Windows.Forms.MenuItem
        Me.mnuItemEvaluate = New SWSystem.Windows.Forms.MenuItem
        Me.MenuQueryProjectExpandDate = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem14 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuItemProjectRequite = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemUnSignProject = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQuerySignProject = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem16 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem15 = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemQueryGuaranteeForm = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem27 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryRegionProject = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryChargeStatistics = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem32 = New SWSystem.Windows.Forms.MenuItem
        Me.muiQueryGuarantingCorporation = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem33 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem35 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem22 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryStatisticsMarketingA = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryStatisticsMarketingB = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryStatisticsMarketingC = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem50 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem46 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem30 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryStatisticsCompensation = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemStatisticsFee = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryStatisticsRegion = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryStatisticsCounterguarantee = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemStaticsFirstLoan = New SWSystem.Windows.Forms.MenuItem
        Me.mnuQueryStatisticsPMService = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemStatisticsRecommendproject = New SWSystem.Windows.Forms.MenuItem
        Me.mnuTools = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemRight = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem23 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuToolsNotepad = New SWSystem.Windows.Forms.MenuItem
        Me.mnuToolsCalculator = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem36 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuToolsOptions = New SWSystem.Windows.Forms.MenuItem
        Me.mnuSkin = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.MenuItem21 = New System.Windows.Forms.MenuItem
        Me.MenuItem37 = New System.Windows.Forms.MenuItem
        Me.MenuItem38 = New System.Windows.Forms.MenuItem
        Me.MenuItem39 = New System.Windows.Forms.MenuItem
        Me.MenuItem40 = New System.Windows.Forms.MenuItem
        Me.MenuItem41 = New System.Windows.Forms.MenuItem
        Me.MenuItem43 = New System.Windows.Forms.MenuItem
        Me.MenuItem45 = New System.Windows.Forms.MenuItem
        Me.MenuItem48 = New System.Windows.Forms.MenuItem
        Me.MenuItem65 = New System.Windows.Forms.MenuItem
        Me.MenuItem66 = New System.Windows.Forms.MenuItem
        Me.MenuItem68 = New System.Windows.Forms.MenuItem
        Me.MenuItem70 = New System.Windows.Forms.MenuItem
        Me.MenuItem72 = New System.Windows.Forms.MenuItem
        Me.MenuItem73 = New System.Windows.Forms.MenuItem
        Me.MenuItem74 = New System.Windows.Forms.MenuItem
        Me.MenuItem75 = New System.Windows.Forms.MenuItem
        Me.MenuItem76 = New System.Windows.Forms.MenuItem
        Me.MenuItem77 = New System.Windows.Forms.MenuItem
        Me.MenuItem78 = New System.Windows.Forms.MenuItem
        Me.MenuItem79 = New System.Windows.Forms.MenuItem
        Me.MenuItem80 = New System.Windows.Forms.MenuItem
        Me.mnuView = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemTool = New SWSystem.Windows.Forms.MenuItem
        Me.MnItemStatic = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem25 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuTaskList = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem71 = New SWSystem.Windows.Forms.MenuItem
        Me.MenuItem26 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuHelp = New SWSystem.Windows.Forms.MenuItem
        Me.mnuHelpContext = New SWSystem.Windows.Forms.MenuItem
        Me.mnuHelpIndex = New SWSystem.Windows.Forms.MenuItem
        Me.mnuHelpSearch = New SWSystem.Windows.Forms.MenuItem
        Me.mnuHelpSeparator1 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuHelpSupport = New SWSystem.Windows.Forms.MenuItem
        Me.mnuHelpSeparator2 = New SWSystem.Windows.Forms.MenuItem
        Me.mnuHelpAbout = New SWSystem.Windows.Forms.MenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.imgMenu = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.LstVwMsg = New System.Windows.Forms.ListView
        Me.ColNum = New System.Windows.Forms.ColumnHeader
        Me.ColProjectCode = New System.Windows.Forms.ColumnHeader
        Me.ColMessage = New System.Windows.Forms.ColumnHeader
        Me.ColTime = New System.Windows.Forms.ColumnHeader
        Me.Splitter2 = New System.Windows.Forms.Splitter
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuItem81 = New System.Windows.Forms.MenuItem
        Me.MenuItem82 = New System.Windows.Forms.MenuItem
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.grpTask.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusBar1
        '
        Me.StatusBar1.Location = New System.Drawing.Point(0, 485)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.Panels.AddRange(New System.Windows.Forms.StatusBarPanel() {Me.StatusBarPanel2, Me.StatusBarPanel3, Me.StatusBarPanel5, Me.StatusBarPanel4})
        Me.StatusBar1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusBar1.ShowPanels = True
        Me.StatusBar1.Size = New System.Drawing.Size(997, 27)
        Me.StatusBar1.TabIndex = 2
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarPanel2
        '
        Me.StatusBarPanel2.AutoSize = System.Windows.Forms.StatusBarPanelAutoSize.Spring
        Me.StatusBarPanel2.Icon = CType(resources.GetObject("StatusBarPanel2.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel2.Name = "StatusBarPanel2"
        Me.StatusBarPanel2.Text = "消息"
        Me.StatusBarPanel2.Width = 520
        '
        'StatusBarPanel3
        '
        Me.StatusBarPanel3.Icon = CType(resources.GetObject("StatusBarPanel3.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel3.Name = "StatusBarPanel3"
        Me.StatusBarPanel3.Text = "操作员："
        Me.StatusBarPanel3.Width = 160
        '
        'StatusBarPanel5
        '
        Me.StatusBarPanel5.Icon = CType(resources.GetObject("StatusBarPanel5.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel5.Name = "StatusBarPanel5"
        Me.StatusBarPanel5.Width = 150
        '
        'StatusBarPanel4
        '
        Me.StatusBarPanel4.Icon = CType(resources.GetObject("StatusBarPanel4.Icon"), System.Drawing.Icon)
        Me.StatusBarPanel4.Name = "StatusBarPanel4"
        Me.StatusBarPanel4.Width = 150
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "")
        Me.ImageList1.Images.SetKeyName(12, "")
        '
        'mnQuery
        '
        Me.mnQuery.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.MenuItem2, Me.MenuItem6, Me.MenuItem7})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.OwnerDraw = True
        Me.MenuItem1.Text = "企业信息查询"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 1
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem3, Me.MenuItem4, Me.MenuItem5})
        Me.MenuItem2.OwnerDraw = True
        Me.MenuItem2.Text = "项目进度查询"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 0
        Me.MenuItem3.OwnerDraw = True
        Me.MenuItem3.Text = "初审阶段"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 1
        Me.MenuItem4.OwnerDraw = True
        Me.MenuItem4.Text = "评审阶段"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.OwnerDraw = True
        Me.MenuItem5.Text = "在保阶段"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 2
        Me.MenuItem6.OwnerDraw = True
        Me.MenuItem6.Text = "项目逾期查询"
        '
        'MenuItem7
        '
        Me.MenuItem7.Index = 3
        Me.MenuItem7.OwnerDraw = True
        Me.MenuItem7.Text = "项目代偿查询"
        '
        'muHelp
        '
        Me.muHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem8, Me.MenuItem9, Me.MenuItem11, Me.MenuItem10})
        '
        'MenuItem8
        '
        Me.MenuItem8.Index = 0
        Me.MenuItem8.OwnerDraw = True
        Me.MenuItem8.Text = "目录"
        '
        'MenuItem9
        '
        Me.MenuItem9.Index = 1
        Me.MenuItem9.OwnerDraw = True
        Me.MenuItem9.Text = "搜索帮助主题"
        '
        'MenuItem11
        '
        Me.MenuItem11.Index = 2
        Me.MenuItem11.OwnerDraw = True
        Me.MenuItem11.Text = "-"
        '
        'MenuItem10
        '
        Me.MenuItem10.Index = 3
        Me.MenuItem10.OwnerDraw = True
        Me.MenuItem10.Text = "关于系统"
        '
        'Panel1
        '
        Me.Panel1.AllowDrop = True
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 32)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 453)
        Me.Panel1.TabIndex = 10
        Me.Panel1.Visible = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.grpTask)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(224, 453)
        Me.Panel4.TabIndex = 0
        '
        'grpTask
        '
        Me.grpTask.Controls.Add(Me.task_name_tree)
        Me.grpTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpTask.Location = New System.Drawing.Point(0, 0)
        Me.grpTask.Name = "grpTask"
        Me.grpTask.Size = New System.Drawing.Size(224, 453)
        Me.grpTask.TabIndex = 0
        Me.grpTask.TabStop = False
        '
        'task_name_tree
        '
        Me.task_name_tree.BackColor = System.Drawing.SystemColors.Window
        Me.task_name_tree.Dock = System.Windows.Forms.DockStyle.Fill
        Me.task_name_tree.ImageIndex = 6
        Me.task_name_tree.ImageList = Me.ImageList1
        Me.task_name_tree.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.task_name_tree.Indent = 23
        Me.task_name_tree.ItemHeight = 20
        Me.task_name_tree.Location = New System.Drawing.Point(3, 17)
        Me.task_name_tree.Name = "task_name_tree"
        TreeNode2.Name = ""
        TreeNode2.Text = "任务列表"
        Me.task_name_tree.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode2})
        Me.task_name_tree.SelectedImageIndex = 5
        Me.task_name_tree.ShowRootLines = False
        Me.task_name_tree.Size = New System.Drawing.Size(218, 433)
        Me.task_name_tree.TabIndex = 21
        '
        'CntxtMnMsg
        '
        Me.CntxtMnMsg.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnItmfreshMsg, Me.MnItmReadMsg, Me.MenuItem47, Me.MnItmDelMsg})
        '
        'MnItmfreshMsg
        '
        Me.MnItmfreshMsg.Index = 0
        Me.MnItmfreshMsg.OwnerDraw = True
        Me.MnItmfreshMsg.Text = "刷新消息"
        '
        'MnItmReadMsg
        '
        Me.MnItmReadMsg.Index = 1
        Me.MnItmReadMsg.OwnerDraw = True
        Me.MnItmReadMsg.Text = "查看消息"
        '
        'MenuItem47
        '
        Me.MenuItem47.Index = 2
        Me.MenuItem47.OwnerDraw = True
        Me.MenuItem47.Text = "-"
        '
        'MnItmDelMsg
        '
        Me.MnItmDelMsg.Index = 3
        Me.MnItmDelMsg.OwnerDraw = True
        Me.MnItmDelMsg.Text = "消息确认"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(224, 32)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(5, 453)
        Me.Panel2.TabIndex = 16
        '
        'PictureBox2
        '
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-4, 260)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(8, 12)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 264)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(7, 12)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(229, 32)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(768, 4)
        Me.Panel3.TabIndex = 18
        '
        'ToolBarButton10
        '
        Me.ToolBarButton10.Name = "ToolBarButton10"
        Me.ToolBarButton10.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarBttnConsult
        '
        Me.ToolBarBttnConsult.Enabled = False
        Me.ToolBarBttnConsult.ImageIndex = 9
        Me.ToolBarBttnConsult.Name = "ToolBarBttnConsult"
        Me.ToolBarBttnConsult.Tag = "1"
        Me.ToolBarBttnConsult.ToolTipText = "咨询登记"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.Name = "ToolBarButton2"
        Me.ToolBarButton2.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.DropDownMenu = Me.mnQuery
        Me.ToolBarButton3.ImageIndex = 12
        Me.ToolBarButton3.Name = "ToolBarButton3"
        Me.ToolBarButton3.Tag = "5"
        Me.ToolBarButton3.ToolTipText = "重新登录"
        '
        'ToolBarBttn1
        '
        Me.ToolBarBttn1.Name = "ToolBarBttn1"
        Me.ToolBarBttn1.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarBttnRefresh
        '
        Me.ToolBarBttnRefresh.ImageIndex = 3
        Me.ToolBarBttnRefresh.Name = "ToolBarBttnRefresh"
        Me.ToolBarBttnRefresh.Tag = "3"
        Me.ToolBarBttnRefresh.ToolTipText = "任务刷新"
        '
        'ToolBarButton6
        '
        Me.ToolBarButton6.Name = "ToolBarButton6"
        Me.ToolBarButton6.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'btnCredit
        '
        Me.btnCredit.ImageIndex = 1
        Me.btnCredit.Name = "btnCredit"
        Me.btnCredit.Tag = "4"
        Me.btnCredit.ToolTipText = "资信评分"
        '
        'ToolBarButton9
        '
        Me.ToolBarButton9.DropDownMenu = Me.muHelp
        Me.ToolBarButton9.Name = "ToolBarButton9"
        Me.ToolBarButton9.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        Me.ToolBarButton9.Tag = "6"
        '
        'TlBrBttnExit
        '
        Me.TlBrBttnExit.ImageIndex = 4
        Me.TlBrBttnExit.Name = "TlBrBttnExit"
        Me.TlBrBttnExit.Tag = "0"
        Me.TlBrBttnExit.ToolTipText = "退出"
        '
        'TlBrMain
        '
        Me.TlBrMain.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton10, Me.ToolBarButton3, Me.ToolBarButton6, Me.ToolBarBttnConsult, Me.ToolBarButton2, Me.ToolBarBttnApply, Me.ToolBarButton5, Me.ToolBarBttnRefresh, Me.ToolBarBttn1, Me.btnCredit, Me.ToolBarButton9, Me.TlBrBttnExit, Me.ToolBarButton8})
        Me.TlBrMain.DropDownArrows = True
        Me.TlBrMain.ImageList = Me.ImageList1
        Me.TlBrMain.Location = New System.Drawing.Point(0, 0)
        Me.TlBrMain.Name = "TlBrMain"
        Me.TlBrMain.ShowToolTips = True
        Me.TlBrMain.Size = New System.Drawing.Size(997, 32)
        Me.TlBrMain.TabIndex = 1
        '
        'ToolBarBttnApply
        '
        Me.ToolBarBttnApply.Enabled = False
        Me.ToolBarBttnApply.ImageIndex = 8
        Me.ToolBarBttnApply.Name = "ToolBarBttnApply"
        Me.ToolBarBttnApply.Tag = "2"
        Me.ToolBarBttnApply.ToolTipText = "受理申请"
        '
        'ToolBarButton5
        '
        Me.ToolBarButton5.Name = "ToolBarButton5"
        Me.ToolBarButton5.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'ToolBarButton8
        '
        Me.ToolBarButton8.Name = "ToolBarButton8"
        Me.ToolBarButton8.Style = System.Windows.Forms.ToolBarButtonStyle.Separator
        '
        'MainMn
        '
        Me.MainMn.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSystem, Me.mnuTransaction, Me.mnuBase, Me.mnuDocument, Me.mnuWorkLog, Me.mnuQuery})
        '
        'mnuSystem
        '
        Me.mnuSystem.Index = 0
        Me.mnuSystem.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuSystemLogin, Me.mnuSystemSeparator1, Me.mnuToolsPassword, Me.mnuMessages, Me.mnuMessagesSender, Me.mnuSystemPageSetup, Me.mnuSystemPreview, Me.mnuSystemPrint, Me.mnuSystemSeparator2, Me.mnuSystemExit})
        Me.mnuSystem.OwnerDraw = True
        Me.mnuSystem.Text = "系统(&S)"
        '
        'mnuSystemLogin
        '
        Me.mnuSystemLogin.Index = 0
        Me.mnuSystemLogin.OwnerDraw = True
        Me.mnuSystemLogin.Text = "重新登录(&L)"
        '
        'mnuSystemSeparator1
        '
        Me.mnuSystemSeparator1.Index = 1
        Me.mnuSystemSeparator1.OwnerDraw = True
        Me.mnuSystemSeparator1.Text = "-"
        '
        'mnuToolsPassword
        '
        Me.mnuToolsPassword.Index = 2
        Me.mnuToolsPassword.OwnerDraw = True
        Me.mnuToolsPassword.Text = "口令设置(&P)"
        '
        'mnuMessages
        '
        Me.mnuMessages.Index = 3
        Me.mnuMessages.OwnerDraw = True
        Me.mnuMessages.Text = "消息管理器(&M)"
        '
        'mnuMessagesSender
        '
        Me.mnuMessagesSender.Index = 4
        Me.mnuMessagesSender.OwnerDraw = True
        Me.mnuMessagesSender.Text = "发送消息(&S)"
        '
        'mnuSystemPageSetup
        '
        Me.mnuSystemPageSetup.Enabled = False
        Me.mnuSystemPageSetup.Index = 5
        Me.mnuSystemPageSetup.OwnerDraw = True
        Me.mnuSystemPageSetup.Text = "页面设置(&U)"
        '
        'mnuSystemPreview
        '
        Me.mnuSystemPreview.Enabled = False
        Me.mnuSystemPreview.Index = 6
        Me.mnuSystemPreview.OwnerDraw = True
        Me.mnuSystemPreview.Text = "预览(&V)"
        '
        'mnuSystemPrint
        '
        Me.mnuSystemPrint.Enabled = False
        Me.mnuSystemPrint.Index = 7
        Me.mnuSystemPrint.OwnerDraw = True
        Me.mnuSystemPrint.Shortcut = System.Windows.Forms.Shortcut.CtrlP
        Me.mnuSystemPrint.Text = "打印(&P)"
        '
        'mnuSystemSeparator2
        '
        Me.mnuSystemSeparator2.Index = 8
        Me.mnuSystemSeparator2.OwnerDraw = True
        Me.mnuSystemSeparator2.Text = "-"
        '
        'mnuSystemExit
        '
        Me.mnuSystemExit.Index = 9
        Me.mnuSystemExit.OwnerDraw = True
        Me.mnuSystemExit.Text = "退出(&X)"
        '
        'mnuTransaction
        '
        Me.mnuTransaction.Index = 1
        Me.mnuTransaction.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuChargeFee, Me.mnuBackFee, Me.MenuItem81, Me.MenuItem82, Me.mnuTransactionSeparator1, Me.MnItemConsult, Me.MnItemAccept, Me.mnuTransactionSeparator2, Me.MenuCreditManager, Me.mnuCreditProject, Me.mnuFinancialAnalysis, Me.mnuTransactionSeparator3, Me.MnItemModifyGuaranty, Me.mnuTransactionSeparator4, Me.mnuMeeting, Me.mnuWorkFlow, Me.mneItemUpdateProcess})
        Me.mnuTransaction.OwnerDraw = True
        Me.mnuTransaction.Text = "事务处理(&T)"
        '
        'mnuChargeFee
        '
        Me.mnuChargeFee.Index = 0
        Me.mnuChargeFee.OwnerDraw = True
        Me.mnuChargeFee.Text = "费用收取(&F)"
        '
        'mnuBackFee
        '
        Me.mnuBackFee.Index = 1
        Me.mnuBackFee.OwnerDraw = True
        Me.mnuBackFee.Text = "退费(&R)"
        '
        'mnuTransactionSeparator1
        '
        Me.mnuTransactionSeparator1.Index = 3
        Me.mnuTransactionSeparator1.OwnerDraw = True
        Me.mnuTransactionSeparator1.Text = "-"
        '
        'MnItemConsult
        '
        Me.MnItemConsult.Enabled = False
        Me.MnItemConsult.Index = 4
        Me.MnItemConsult.OwnerDraw = True
        Me.MnItemConsult.Text = "咨询登记(&C)"
        '
        'MnItemAccept
        '
        Me.MnItemAccept.Enabled = False
        Me.MnItemAccept.Index = 5
        Me.MnItemAccept.OwnerDraw = True
        Me.MnItemAccept.Text = "受理申请(&A)"
        '
        'mnuTransactionSeparator2
        '
        Me.mnuTransactionSeparator2.Index = 6
        Me.mnuTransactionSeparator2.OwnerDraw = True
        Me.mnuTransactionSeparator2.Text = "-"
        '
        'MenuCreditManager
        '
        Me.MenuCreditManager.Index = 7
        Me.MenuCreditManager.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuDefectRecord, Me.MenuDefectRecordAdd, Me.MenuDefectRecordEdit})
        Me.MenuCreditManager.OwnerDraw = True
        Me.MenuCreditManager.Text = "信用管理"
        '
        'MenuDefectRecord
        '
        Me.MenuDefectRecord.Index = 0
        Me.MenuDefectRecord.OwnerDraw = True
        Me.MenuDefectRecord.Text = "企业失信记录查询"
        '
        'MenuDefectRecordAdd
        '
        Me.MenuDefectRecordAdd.Index = 1
        Me.MenuDefectRecordAdd.OwnerDraw = True
        Me.MenuDefectRecordAdd.Text = "企业失信记录新增"
        '
        'MenuDefectRecordEdit
        '
        Me.MenuDefectRecordEdit.Index = 2
        Me.MenuDefectRecordEdit.OwnerDraw = True
        Me.MenuDefectRecordEdit.Text = "企业失信记录维护"
        '
        'mnuCreditProject
        '
        Me.mnuCreditProject.Enabled = False
        Me.mnuCreditProject.Index = 8
        Me.mnuCreditProject.OwnerDraw = True
        Me.mnuCreditProject.Text = "资信评分(&E)"
        '
        'mnuFinancialAnalysis
        '
        Me.mnuFinancialAnalysis.Enabled = False
        Me.mnuFinancialAnalysis.Index = 9
        Me.mnuFinancialAnalysis.OwnerDraw = True
        Me.mnuFinancialAnalysis.Text = "财务分析(&S)"
        '
        'mnuTransactionSeparator3
        '
        Me.mnuTransactionSeparator3.Index = 10
        Me.mnuTransactionSeparator3.OwnerDraw = True
        Me.mnuTransactionSeparator3.Text = "-"
        Me.mnuTransactionSeparator3.Visible = False
        '
        'MnItemModifyGuaranty
        '
        Me.MnItemModifyGuaranty.Index = 11
        Me.MnItemModifyGuaranty.OwnerDraw = True
        Me.MnItemModifyGuaranty.Text = "调整反担保措施"
        Me.MnItemModifyGuaranty.Visible = False
        '
        'mnuTransactionSeparator4
        '
        Me.mnuTransactionSeparator4.Index = 12
        Me.mnuTransactionSeparator4.OwnerDraw = True
        Me.mnuTransactionSeparator4.Text = "-"
        '
        'mnuMeeting
        '
        Me.mnuMeeting.Index = 13
        Me.mnuMeeting.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnItemMeetQuery, Me.MnItemMeetSet, Me.MnItemQrySignaturePlan})
        Me.mnuMeeting.OwnerDraw = True
        Me.mnuMeeting.Text = "会议管理(&M)"
        '
        'MnItemMeetQuery
        '
        Me.MnItemMeetQuery.Enabled = False
        Me.MnItemMeetQuery.Index = 0
        Me.MnItemMeetQuery.OwnerDraw = True
        Me.MnItemMeetQuery.Text = "会议查询(&Q)"
        '
        'MnItemMeetSet
        '
        Me.MnItemMeetSet.Enabled = False
        Me.MnItemMeetSet.Index = 1
        Me.MnItemMeetSet.OwnerDraw = True
        Me.MnItemMeetSet.Text = "会议设置(&N)"
        '
        'MnItemQrySignaturePlan
        '
        Me.MnItemQrySignaturePlan.Enabled = False
        Me.MnItemQrySignaturePlan.Index = 2
        Me.MnItemQrySignaturePlan.OwnerDraw = True
        Me.MnItemQrySignaturePlan.Text = "签约安排查询"
        '
        'mnuWorkFlow
        '
        Me.mnuWorkFlow.Index = 14
        Me.mnuWorkFlow.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnItemProPause, Me.mnuItemFirReviewCancel, Me.MnItemProCancel, Me.MnItemProConsign, Me.MnItemProCancelCon, Me.MnItemProManual, Me.MnItemProAssign, Me.mnuUpdateMeetRecord, Me.muiUpdateIntentLetter, Me.mnuItemClaim, Me.mnuProjectDelete, Me.MenuReviewGuarantee, Me.mnuItemUpdateGuarantee, Me.MenuProjectExp, Me.MenuItem17, Me.MnItemRemeet, Me.MenuItem31, Me.mnuWorkFlowHoliday, Me.mnuWorkFlowTask})
        Me.mnuWorkFlow.OwnerDraw = True
        Me.mnuWorkFlow.Text = "流程管理(&W)"
        '
        'MnItemProPause
        '
        Me.MnItemProPause.Enabled = False
        Me.MnItemProPause.Index = 0
        Me.MnItemProPause.OwnerDraw = True
        Me.MnItemProPause.Text = "项目暂停(&P)"
        '
        'mnuItemFirReviewCancel
        '
        Me.mnuItemFirReviewCancel.Index = 1
        Me.mnuItemFirReviewCancel.OwnerDraw = True
        Me.mnuItemFirReviewCancel.Text = "初审暂缓(&V)"
        '
        'MnItemProCancel
        '
        Me.MnItemProCancel.Enabled = False
        Me.MnItemProCancel.Index = 2
        Me.MnItemProCancel.OwnerDraw = True
        Me.MnItemProCancel.Text = "项目暂缓(&T)"
        '
        'MnItemProConsign
        '
        Me.MnItemProConsign.Enabled = False
        Me.MnItemProConsign.Index = 3
        Me.MnItemProConsign.OwnerDraw = True
        Me.MnItemProConsign.Text = "任务委托(&C)"
        '
        'MnItemProCancelCon
        '
        Me.MnItemProCancelCon.Enabled = False
        Me.MnItemProCancelCon.Index = 4
        Me.MnItemProCancelCon.OwnerDraw = True
        Me.MnItemProCancelCon.Text = "撤消委托(&D)"
        '
        'MnItemProManual
        '
        Me.MnItemProManual.Enabled = False
        Me.MnItemProManual.Index = 5
        Me.MnItemProManual.OwnerDraw = True
        Me.MnItemProManual.Text = "手动任务(&M)"
        '
        'MnItemProAssign
        '
        Me.MnItemProAssign.Enabled = False
        Me.MnItemProAssign.Index = 6
        Me.MnItemProAssign.OwnerDraw = True
        Me.MnItemProAssign.Text = "更换角色(&R)"
        '
        'mnuUpdateMeetRecord
        '
        Me.mnuUpdateMeetRecord.Enabled = False
        Me.mnuUpdateMeetRecord.Index = 7
        Me.mnuUpdateMeetRecord.OwnerDraw = True
        Me.mnuUpdateMeetRecord.Text = "修改评审会结论"
        '
        'muiUpdateIntentLetter
        '
        Me.muiUpdateIntentLetter.Index = 8
        Me.muiUpdateIntentLetter.OwnerDraw = True
        Me.muiUpdateIntentLetter.Text = "修改担保意向书"
        '
        'mnuItemClaim
        '
        Me.mnuItemClaim.Enabled = False
        Me.mnuItemClaim.Index = 9
        Me.mnuItemClaim.OwnerDraw = True
        Me.mnuItemClaim.Text = "保函索赔(&G)"
        '
        'mnuProjectDelete
        '
        Me.mnuProjectDelete.Enabled = False
        Me.mnuProjectDelete.Index = 10
        Me.mnuProjectDelete.OwnerDraw = True
        Me.mnuProjectDelete.Text = "项目删除(&E)"
        '
        'MenuReviewGuarantee
        '
        Me.MenuReviewGuarantee.Index = 11
        Me.MenuReviewGuarantee.OwnerDraw = True
        Me.MenuReviewGuarantee.Text = "复评反担保措施"
        '
        'mnuItemUpdateGuarantee
        '
        Me.mnuItemUpdateGuarantee.Index = 12
        Me.mnuItemUpdateGuarantee.OwnerDraw = True
        Me.mnuItemUpdateGuarantee.Text = "更新反担保措施(&U)"
        '
        'MenuProjectExp
        '
        Me.MenuProjectExp.Index = 13
        Me.MenuProjectExp.OwnerDraw = True
        Me.MenuProjectExp.Text = "项目展期"
        '
        'MenuItem17
        '
        Me.MenuItem17.Index = 14
        Me.MenuItem17.OwnerDraw = True
        Me.MenuItem17.Text = "-"
        '
        'MnItemRemeet
        '
        Me.MnItemRemeet.Enabled = False
        Me.MnItemRemeet.Index = 15
        Me.MnItemRemeet.OwnerDraw = True
        Me.MnItemRemeet.Text = "重新上会(&A)"
        '
        'MenuItem31
        '
        Me.MenuItem31.Index = 16
        Me.MenuItem31.OwnerDraw = True
        Me.MenuItem31.Text = "-"
        '
        'mnuWorkFlowHoliday
        '
        Me.mnuWorkFlowHoliday.Enabled = False
        Me.mnuWorkFlowHoliday.Index = 17
        Me.mnuWorkFlowHoliday.OwnerDraw = True
        Me.mnuWorkFlowHoliday.Text = "节假日设置(H)"
        '
        'mnuWorkFlowTask
        '
        Me.mnuWorkFlowTask.Enabled = False
        Me.mnuWorkFlowTask.Index = 18
        Me.mnuWorkFlowTask.OwnerDraw = True
        Me.mnuWorkFlowTask.Text = "工作流定义(&F)"
        '
        'mneItemUpdateProcess
        '
        Me.mneItemUpdateProcess.Index = 15
        Me.mneItemUpdateProcess.OwnerDraw = True
        Me.mneItemUpdateProcess.Text = "业务流程同步(&U)"
        '
        'mnuBase
        '
        Me.mnuBase.Index = 2
        Me.mnuBase.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuBaseGeneral, Me.MnItemOrganize, Me.MnItemCreditAppraise, Me.mnitemWorkLog})
        Me.mnuBase.OwnerDraw = True
        Me.mnuBase.Text = "基础资料(&B)"
        '
        'mnuBaseGeneral
        '
        Me.mnuBaseGeneral.Index = 0
        Me.mnuBaseGeneral.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem53, Me.MenuItem62, Me.MenuItem59, Me.MnItemBank, Me.MnItemCooperate, Me.MenuItem51, Me.MenuItem63, Me.mnuCorporationRelationType, Me.MenuItem34, Me.MenuItem52, Me.MenuItem56, Me.MenuItem54, Me.MenuItem55, Me.MenuItem60, Me.muChargeManner, Me.MenuItem61, Me.MnItemMaterial, Me.MnFincialItem, Me.mnuAlarm, Me.mnuWorkType, Me.mnuItem03, Me.mnItemGuaranteeLetterType, Me.MenuItem58, Me.MenuItem57, Me.MnItemGuaranty, Me.mnuDataItem04, Me.MenuItem44, Me.MenuItem64, Me.mnItemReimburseType, Me.MnItemOrganization, Me.muiConferenceRoom})
        Me.mnuBaseGeneral.OwnerDraw = True
        Me.mnuBaseGeneral.Text = "常规基础资料"
        '
        'MenuItem53
        '
        Me.MenuItem53.Index = 0
        Me.MenuItem53.OwnerDraw = True
        Me.MenuItem53.Text = "区域"
        '
        'MenuItem62
        '
        Me.MenuItem62.Index = 1
        Me.MenuItem62.OwnerDraw = True
        Me.MenuItem62.Text = "业务品种"
        '
        'MenuItem59
        '
        Me.MenuItem59.Index = 2
        Me.MenuItem59.OwnerDraw = True
        Me.MenuItem59.Text = "推荐类型"
        '
        'MnItemBank
        '
        Me.MnItemBank.Index = 3
        Me.MnItemBank.OwnerDraw = True
        Me.MnItemBank.Text = "合作银行"
        '
        'MnItemCooperate
        '
        Me.MnItemCooperate.Index = 4
        Me.MnItemCooperate.OwnerDraw = True
        Me.MnItemCooperate.Text = "合作区局"
        '
        'MenuItem51
        '
        Me.MenuItem51.Index = 5
        Me.MenuItem51.OwnerDraw = True
        Me.MenuItem51.Text = "行业类型"
        '
        'MenuItem63
        '
        Me.MenuItem63.Index = 6
        Me.MenuItem63.OwnerDraw = True
        Me.MenuItem63.Text = "技术类型"
        '
        'mnuCorporationRelationType
        '
        Me.mnuCorporationRelationType.Index = 7
        Me.mnuCorporationRelationType.OwnerDraw = True
        Me.mnuCorporationRelationType.Text = "关系类型"
        '
        'MenuItem34
        '
        Me.MenuItem34.Index = 8
        Me.MenuItem34.OwnerDraw = True
        Me.MenuItem34.Text = "货币类型"
        Me.MenuItem34.Visible = False
        '
        'MenuItem52
        '
        Me.MenuItem52.Index = 9
        Me.MenuItem52.OwnerDraw = True
        Me.MenuItem52.Text = "投资方式"
        Me.MenuItem52.Visible = False
        '
        'MenuItem56
        '
        Me.MenuItem56.Index = 10
        Me.MenuItem56.OwnerDraw = True
        Me.MenuItem56.Text = "借款类型"
        Me.MenuItem56.Visible = False
        '
        'MenuItem54
        '
        Me.MenuItem54.Index = 11
        Me.MenuItem54.OwnerDraw = True
        Me.MenuItem54.Text = "借款方式"
        Me.MenuItem54.Visible = False
        '
        'MenuItem55
        '
        Me.MenuItem55.Index = 12
        Me.MenuItem55.OwnerDraw = True
        Me.MenuItem55.Text = "放款方式"
        '
        'MenuItem60
        '
        Me.MenuItem60.Index = 13
        Me.MenuItem60.OwnerDraw = True
        Me.MenuItem60.Text = "还款方式"
        '
        'muChargeManner
        '
        Me.muChargeManner.Index = 14
        Me.muChargeManner.OwnerDraw = True
        Me.muChargeManner.Text = "收费方式"
        '
        'MenuItem61
        '
        Me.MenuItem61.Index = 15
        Me.MenuItem61.OwnerDraw = True
        Me.MenuItem61.Text = "风险等级"
        Me.MenuItem61.Visible = False
        '
        'MnItemMaterial
        '
        Me.MnItemMaterial.Index = 16
        Me.MnItemMaterial.OwnerDraw = True
        Me.MnItemMaterial.Text = "项目材料"
        '
        'MnFincialItem
        '
        Me.MnFincialItem.Index = 17
        Me.MnFincialItem.OwnerDraw = True
        Me.MnFincialItem.Text = "财务科目"
        '
        'mnuAlarm
        '
        Me.mnuAlarm.Index = 18
        Me.mnuAlarm.OwnerDraw = True
        Me.mnuAlarm.Text = "预警等级"
        '
        'mnuWorkType
        '
        Me.mnuWorkType.Index = 19
        Me.mnuWorkType.OwnerDraw = True
        Me.mnuWorkType.Text = "日志类型"
        '
        'mnuItem03
        '
        Me.mnuItem03.Index = 20
        Me.mnuItem03.OwnerDraw = True
        Me.mnuItem03.Text = "文件类别"
        '
        'mnItemGuaranteeLetterType
        '
        Me.mnItemGuaranteeLetterType.Index = 21
        Me.mnItemGuaranteeLetterType.OwnerDraw = True
        Me.mnItemGuaranteeLetterType.Text = "保函种类"
        '
        'MenuItem58
        '
        Me.MenuItem58.Index = 22
        Me.MenuItem58.OwnerDraw = True
        Me.MenuItem58.Text = "所有制形式"
        '
        'MenuItem57
        '
        Me.MenuItem57.Index = 23
        Me.MenuItem57.OwnerDraw = True
        Me.MenuItem57.Text = "反担保方式"
        '
        'MnItemGuaranty
        '
        Me.MnItemGuaranty.Index = 24
        Me.MnItemGuaranty.OwnerDraw = True
        Me.MnItemGuaranty.Text = "反担保物品种"
        '
        'mnuDataItem04
        '
        Me.mnuDataItem04.Index = 25
        Me.mnuDataItem04.OwnerDraw = True
        Me.mnuDataItem04.Text = "文档合同类别"
        '
        'MenuItem44
        '
        Me.MenuItem44.Index = 26
        Me.MenuItem44.OwnerDraw = True
        Me.MenuItem44.Text = "报告合同模板"
        '
        'MenuItem64
        '
        Me.MenuItem64.Index = 27
        Me.MenuItem64.OwnerDraw = True
        Me.MenuItem64.Text = "项目终止类型"
        '
        'mnItemReimburseType
        '
        Me.mnItemReimburseType.Index = 28
        Me.mnItemReimburseType.OwnerDraw = True
        Me.mnItemReimburseType.Text = "偿付责任类型"
        '
        'MnItemOrganization
        '
        Me.MnItemOrganization.Index = 29
        Me.MnItemOrganization.OwnerDraw = True
        Me.MnItemOrganization.Text = "担保机构设置"
        '
        'muiConferenceRoom
        '
        Me.muiConferenceRoom.Index = 30
        Me.muiConferenceRoom.OwnerDraw = True
        Me.muiConferenceRoom.Text = "会场设置"
        '
        'MnItemOrganize
        '
        Me.MnItemOrganize.Index = 1
        Me.MnItemOrganize.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnItemBranch, Me.MnItemRole, Me.MnItemStaff, Me.MnItemStaffRole, Me.MnItemTeam})
        Me.MnItemOrganize.OwnerDraw = True
        Me.MnItemOrganize.Text = "员工角色资料"
        '
        'MnItemBranch
        '
        Me.MnItemBranch.Enabled = False
        Me.MnItemBranch.Index = 0
        Me.MnItemBranch.OwnerDraw = True
        Me.MnItemBranch.Text = "部门设置"
        '
        'MnItemRole
        '
        Me.MnItemRole.Enabled = False
        Me.MnItemRole.Index = 1
        Me.MnItemRole.OwnerDraw = True
        Me.MnItemRole.Text = "角色设置"
        '
        'MnItemStaff
        '
        Me.MnItemStaff.Enabled = False
        Me.MnItemStaff.Index = 2
        Me.MnItemStaff.OwnerDraw = True
        Me.MnItemStaff.Text = "员工设置"
        '
        'MnItemStaffRole
        '
        Me.MnItemStaffRole.Enabled = False
        Me.MnItemStaffRole.Index = 3
        Me.MnItemStaffRole.OwnerDraw = True
        Me.MnItemStaffRole.Text = "员工角色设置"
        '
        'MnItemTeam
        '
        Me.MnItemTeam.Enabled = False
        Me.MnItemTeam.Index = 4
        Me.MnItemTeam.OwnerDraw = True
        Me.MnItemTeam.Text = "项目组别设置"
        '
        'MnItemCreditAppraise
        '
        Me.MnItemCreditAppraise.Index = 2
        Me.MnItemCreditAppraise.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnItemCreditSystem, Me.MnItemCreditQuantity, Me.MnItemQuality})
        Me.MnItemCreditAppraise.OwnerDraw = True
        Me.MnItemCreditAppraise.Text = "资信评分资料"
        '
        'MnItemCreditSystem
        '
        Me.MnItemCreditSystem.Index = 0
        Me.MnItemCreditSystem.OwnerDraw = True
        Me.MnItemCreditSystem.Text = "资信评分体系设置"
        '
        'MnItemCreditQuantity
        '
        Me.MnItemCreditQuantity.Index = 1
        Me.MnItemCreditQuantity.OwnerDraw = True
        Me.MnItemCreditQuantity.Text = "定量评分指标设置"
        '
        'MnItemQuality
        '
        Me.MnItemQuality.Index = 2
        Me.MnItemQuality.OwnerDraw = True
        Me.MnItemQuality.Text = "定性评分指标设置"
        '
        'mnitemWorkLog
        '
        Me.mnitemWorkLog.Index = 3
        Me.mnitemWorkLog.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mitemPostConfig, Me.mitemJobRes, Me.mitemJobTask, Me.mitemWorkTime})
        Me.mnitemWorkLog.OwnerDraw = True
        Me.mnitemWorkLog.Text = "工作日志资料"
        '
        'mitemPostConfig
        '
        Me.mitemPostConfig.Index = 0
        Me.mitemPostConfig.OwnerDraw = True
        Me.mitemPostConfig.Text = "员工岗位设置"
        '
        'mitemJobRes
        '
        Me.mitemJobRes.Index = 1
        Me.mitemJobRes.OwnerDraw = True
        Me.mitemJobRes.Text = "岗位职责设置"
        '
        'mitemJobTask
        '
        Me.mitemJobTask.Index = 2
        Me.mitemJobTask.OwnerDraw = True
        Me.mitemJobTask.Text = "工作职责设置"
        '
        'mitemWorkTime
        '
        Me.mitemWorkTime.Index = 3
        Me.mitemWorkTime.OwnerDraw = True
        Me.mitemWorkTime.Text = "工作时间表设置"
        '
        'mnuDocument
        '
        Me.mnuDocument.Index = 3
        Me.mnuDocument.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnItemDocQry, Me.MenuItem69, Me.mnuCompanyFileManage, Me.MenuContractManage})
        Me.mnuDocument.OwnerDraw = True
        Me.mnuDocument.Text = "文档管理(&D)"
        '
        'MnItemDocQry
        '
        Me.MnItemDocQry.Enabled = False
        Me.MnItemDocQry.Index = 0
        Me.MnItemDocQry.OwnerDraw = True
        Me.MnItemDocQry.Text = "项目文档查询(&P)"
        '
        'MenuItem69
        '
        Me.MenuItem69.Enabled = False
        Me.MenuItem69.Index = 1
        Me.MenuItem69.OwnerDraw = True
        Me.MenuItem69.Text = "中心文件查询(&Q)"
        '
        'mnuCompanyFileManage
        '
        Me.mnuCompanyFileManage.Enabled = False
        Me.mnuCompanyFileManage.Index = 2
        Me.mnuCompanyFileManage.OwnerDraw = True
        Me.mnuCompanyFileManage.Text = "中心文件管理(&M)"
        '
        'MenuContractManage
        '
        Me.MenuContractManage.Index = 3
        Me.MenuContractManage.OwnerDraw = True
        Me.MenuContractManage.Text = "合同管理(&C)"
        '
        'mnuWorkLog
        '
        Me.mnuWorkLog.Index = 4
        Me.mnuWorkLog.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuWorkLogEnter, Me.mnuWorkLogQuery, Me.mnuWorkLogStatistics, Me.muitemWorkingHour})
        Me.mnuWorkLog.OwnerDraw = True
        Me.mnuWorkLog.Text = "工作日志(&L)"
        '
        'mnuWorkLogEnter
        '
        Me.mnuWorkLogEnter.Enabled = False
        Me.mnuWorkLogEnter.Index = 0
        Me.mnuWorkLogEnter.OwnerDraw = True
        Me.mnuWorkLogEnter.Text = "工作日志录入(&R)"
        '
        'mnuWorkLogQuery
        '
        Me.mnuWorkLogQuery.Enabled = False
        Me.mnuWorkLogQuery.Index = 1
        Me.mnuWorkLogQuery.OwnerDraw = True
        Me.mnuWorkLogQuery.Text = "工作日志查询(&Q)"
        '
        'mnuWorkLogStatistics
        '
        Me.mnuWorkLogStatistics.Enabled = False
        Me.mnuWorkLogStatistics.Index = 2
        Me.mnuWorkLogStatistics.OwnerDraw = True
        Me.mnuWorkLogStatistics.Text = "工作日志统计(&S)"
        '
        'muitemWorkingHour
        '
        Me.muitemWorkingHour.Index = 3
        Me.muitemWorkingHour.OwnerDraw = True
        Me.muitemWorkingHour.Text = "员工工时统计(&H)"
        '
        'mnuQuery
        '
        Me.mnuQuery.Index = 5
        Me.mnuQuery.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem19, Me.MenuItem42, Me.MenuItem18, Me.MenuItem33})
        Me.mnuQuery.OwnerDraw = True
        Me.mnuQuery.Text = "查询(&Q)"
        '
        'MenuItem19
        '
        Me.MenuItem19.Enabled = False
        Me.MenuItem19.Index = 0
        Me.MenuItem19.OwnerDraw = True
        Me.MenuItem19.Text = "项目查询(&P)"
        '
        'MenuItem42
        '
        Me.MenuItem42.Index = 1
        Me.MenuItem42.OwnerDraw = True
        Me.MenuItem42.Text = "-"
        Me.MenuItem42.Visible = False
        '
        'MenuItem18
        '
        Me.MenuItem18.Index = 2
        Me.MenuItem18.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem20, Me.mnuQueryFirstTrialProject, Me.MenuItem28, Me.mnuQueryAllocateProject, Me.mnuQueryProcessingProject, Me.mnuQueryAcceptProject, Me.mnuQueryPresentingProject, Me.mnuQueryLoanProject, Me.mnuQueryCreditProject, Me.mnuQueryRequiteProject, Me.MenuItem13, Me.mnuQueryRecantProject, Me.MenuItem49, Me.MenuItem24, Me.MenuItem67, Me.MenuItem29, Me.mnuGuaranteeProject, Me.mnuAfterGuaranteeRecord, Me.mnuUnDealProject, Me.mnuItemIntentLetter, Me.mnuItemEvaluate, Me.MenuQueryProjectExpandDate, Me.MenuItem14, Me.mnuItemProjectRequite, Me.MnItemUnSignProject, Me.mnuQuerySignProject, Me.MenuItem16, Me.MenuItem15, Me.MnItemQueryGuaranteeForm, Me.MenuItem27, Me.mnuQueryRegionProject, Me.mnuQueryChargeStatistics, Me.MenuItem32, Me.muiQueryGuarantingCorporation})
        Me.MenuItem18.OwnerDraw = True
        Me.MenuItem18.Text = "系统查询"
        Me.MenuItem18.Visible = False
        '
        'MenuItem20
        '
        Me.MenuItem20.Enabled = False
        Me.MenuItem20.Index = 0
        Me.MenuItem20.OwnerDraw = True
        Me.MenuItem20.Text = "咨询企业一览表"
        '
        'mnuQueryFirstTrialProject
        '
        Me.mnuQueryFirstTrialProject.Enabled = False
        Me.mnuQueryFirstTrialProject.Index = 1
        Me.mnuQueryFirstTrialProject.OwnerDraw = True
        Me.mnuQueryFirstTrialProject.Text = "申请项目一览表"
        '
        'MenuItem28
        '
        Me.MenuItem28.Enabled = False
        Me.MenuItem28.Index = 2
        Me.MenuItem28.OwnerDraw = True
        Me.MenuItem28.Text = "初审项目一览表"
        '
        'mnuQueryAllocateProject
        '
        Me.mnuQueryAllocateProject.Enabled = False
        Me.mnuQueryAllocateProject.Index = 3
        Me.mnuQueryAllocateProject.OwnerDraw = True
        Me.mnuQueryAllocateProject.Text = "项目分配一览表"
        '
        'mnuQueryProcessingProject
        '
        Me.mnuQueryProcessingProject.Enabled = False
        Me.mnuQueryProcessingProject.Index = 4
        Me.mnuQueryProcessingProject.OwnerDraw = True
        Me.mnuQueryProcessingProject.Text = "正在进行项目一览表"
        Me.mnuQueryProcessingProject.Visible = False
        '
        'mnuQueryAcceptProject
        '
        Me.mnuQueryAcceptProject.Enabled = False
        Me.mnuQueryAcceptProject.Index = 5
        Me.mnuQueryAcceptProject.OwnerDraw = True
        Me.mnuQueryAcceptProject.Text = "正式受理项目一览表"
        '
        'mnuQueryPresentingProject
        '
        Me.mnuQueryPresentingProject.Enabled = False
        Me.mnuQueryPresentingProject.Index = 6
        Me.mnuQueryPresentingProject.OwnerDraw = True
        Me.mnuQueryPresentingProject.Text = "提交上会项目一览表"
        '
        'mnuQueryLoanProject
        '
        Me.mnuQueryLoanProject.Enabled = False
        Me.mnuQueryLoanProject.Index = 7
        Me.mnuQueryLoanProject.OwnerDraw = True
        Me.mnuQueryLoanProject.Text = "承保项目一览表"
        '
        'mnuQueryCreditProject
        '
        Me.mnuQueryCreditProject.Enabled = False
        Me.mnuQueryCreditProject.Index = 8
        Me.mnuQueryCreditProject.OwnerDraw = True
        Me.mnuQueryCreditProject.Text = "在保项目一览表"
        '
        'mnuQueryRequiteProject
        '
        Me.mnuQueryRequiteProject.Enabled = False
        Me.mnuQueryRequiteProject.Index = 9
        Me.mnuQueryRequiteProject.OwnerDraw = True
        Me.mnuQueryRequiteProject.Text = "还款项目一览表"
        '
        'MenuItem13
        '
        Me.MenuItem13.Enabled = False
        Me.MenuItem13.Index = 10
        Me.MenuItem13.OwnerDraw = True
        Me.MenuItem13.Text = "到期项目一览表"
        '
        'mnuQueryRecantProject
        '
        Me.mnuQueryRecantProject.Enabled = False
        Me.mnuQueryRecantProject.Index = 11
        Me.mnuQueryRecantProject.OwnerDraw = True
        Me.mnuQueryRecantProject.Text = "撤保项目一览表"
        '
        'MenuItem49
        '
        Me.MenuItem49.Enabled = False
        Me.MenuItem49.Index = 12
        Me.MenuItem49.OwnerDraw = True
        Me.MenuItem49.Text = "终止项目一览表"
        '
        'MenuItem24
        '
        Me.MenuItem24.Enabled = False
        Me.MenuItem24.Index = 13
        Me.MenuItem24.OwnerDraw = True
        Me.MenuItem24.Text = "逾期项目一览表"
        '
        'MenuItem67
        '
        Me.MenuItem67.Enabled = False
        Me.MenuItem67.Index = 14
        Me.MenuItem67.OwnerDraw = True
        Me.MenuItem67.Text = "代偿项目一览表"
        '
        'MenuItem29
        '
        Me.MenuItem29.Enabled = False
        Me.MenuItem29.Index = 15
        Me.MenuItem29.OwnerDraw = True
        Me.MenuItem29.Text = "暂缓项目一览表"
        '
        'mnuGuaranteeProject
        '
        Me.mnuGuaranteeProject.Enabled = False
        Me.mnuGuaranteeProject.Index = 16
        Me.mnuGuaranteeProject.OwnerDraw = True
        Me.mnuGuaranteeProject.Text = "保函项目一览表"
        '
        'mnuAfterGuaranteeRecord
        '
        Me.mnuAfterGuaranteeRecord.Enabled = False
        Me.mnuAfterGuaranteeRecord.Index = 17
        Me.mnuAfterGuaranteeRecord.OwnerDraw = True
        Me.mnuAfterGuaranteeRecord.Text = "保后检查一览表"
        '
        'mnuUnDealProject
        '
        Me.mnuUnDealProject.Enabled = False
        Me.mnuUnDealProject.Index = 18
        Me.mnuUnDealProject.OwnerDraw = True
        Me.mnuUnDealProject.Text = "未处理项目一览表"
        '
        'mnuItemIntentLetter
        '
        Me.mnuItemIntentLetter.Index = 19
        Me.mnuItemIntentLetter.OwnerDraw = True
        Me.mnuItemIntentLetter.Text = "意向书发放一览表"
        '
        'mnuItemEvaluate
        '
        Me.mnuItemEvaluate.Index = 20
        Me.mnuItemEvaluate.OwnerDraw = True
        Me.mnuItemEvaluate.Text = "资产评估一览表"
        '
        'MenuQueryProjectExpandDate
        '
        Me.MenuQueryProjectExpandDate.Index = 21
        Me.MenuQueryProjectExpandDate.OwnerDraw = True
        Me.MenuQueryProjectExpandDate.Text = "展期项目一览表"
        '
        'MenuItem14
        '
        Me.MenuItem14.Index = 22
        Me.MenuItem14.OwnerDraw = True
        Me.MenuItem14.Text = "-"
        '
        'mnuItemProjectRequite
        '
        Me.mnuItemProjectRequite.Index = 23
        Me.mnuItemProjectRequite.OwnerDraw = True
        Me.mnuItemProjectRequite.Text = "项目还款情况查询"
        '
        'MnItemUnSignProject
        '
        Me.MnItemUnSignProject.Enabled = False
        Me.MnItemUnSignProject.Index = 24
        Me.MnItemUnSignProject.OwnerDraw = True
        Me.MnItemUnSignProject.Text = "在途项目查询"
        '
        'mnuQuerySignProject
        '
        Me.mnuQuerySignProject.Enabled = False
        Me.mnuQuerySignProject.Index = 25
        Me.mnuQuerySignProject.OwnerDraw = True
        Me.mnuQuerySignProject.Text = "签约项目查询"
        '
        'MenuItem16
        '
        Me.MenuItem16.Index = 26
        Me.MenuItem16.OwnerDraw = True
        Me.MenuItem16.Text = "-"
        '
        'MenuItem15
        '
        Me.MenuItem15.Enabled = False
        Me.MenuItem15.Index = 27
        Me.MenuItem15.OwnerDraw = True
        Me.MenuItem15.Text = "反担保物品查询"
        '
        'MnItemQueryGuaranteeForm
        '
        Me.MnItemQueryGuaranteeForm.Enabled = False
        Me.MnItemQueryGuaranteeForm.Index = 28
        Me.MnItemQueryGuaranteeForm.OwnerDraw = True
        Me.MnItemQueryGuaranteeForm.Text = "反担保措施查询"
        '
        'MenuItem27
        '
        Me.MenuItem27.Index = 29
        Me.MenuItem27.OwnerDraw = True
        Me.MenuItem27.Text = "-"
        '
        'mnuQueryRegionProject
        '
        Me.mnuQueryRegionProject.Enabled = False
        Me.mnuQueryRegionProject.Index = 30
        Me.mnuQueryRegionProject.OwnerDraw = True
        Me.mnuQueryRegionProject.Text = "合作项目查询"
        '
        'mnuQueryChargeStatistics
        '
        Me.mnuQueryChargeStatistics.Enabled = False
        Me.mnuQueryChargeStatistics.Index = 31
        Me.mnuQueryChargeStatistics.OwnerDraw = True
        Me.mnuQueryChargeStatistics.Text = "项目收费查询"
        '
        'MenuItem32
        '
        Me.MenuItem32.Enabled = False
        Me.MenuItem32.Index = 32
        Me.MenuItem32.OwnerDraw = True
        Me.MenuItem32.Text = "项目评价查询"
        '
        'muiQueryGuarantingCorporation
        '
        Me.muiQueryGuarantingCorporation.Index = 33
        Me.muiQueryGuarantingCorporation.OwnerDraw = True
        Me.muiQueryGuarantingCorporation.Text = "未保后跟踪项目一览表"
        '
        'MenuItem33
        '
        Me.MenuItem33.Index = 3
        Me.MenuItem33.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem35, Me.MenuItem22, Me.mnuQueryStatisticsMarketingA, Me.mnuQueryStatisticsMarketingB, Me.mnuQueryStatisticsMarketingC, Me.MenuItem50, Me.MenuItem46, Me.MenuItem30, Me.mnuQueryStatisticsCompensation, Me.MnItemStatisticsFee, Me.mnuQueryStatisticsRegion, Me.mnuQueryStatisticsCounterguarantee, Me.MnItemStaticsFirstLoan, Me.mnuQueryStatisticsPMService, Me.MnItemStatisticsRecommendproject})
        Me.MenuItem33.OwnerDraw = True
        Me.MenuItem33.Text = "系统统计"
        Me.MenuItem33.Visible = False
        '
        'MenuItem35
        '
        Me.MenuItem35.Enabled = False
        Me.MenuItem35.Index = 0
        Me.MenuItem35.OwnerDraw = True
        Me.MenuItem35.Text = "担保业务统计"
        Me.MenuItem35.Visible = False
        '
        'MenuItem22
        '
        Me.MenuItem22.Index = 1
        Me.MenuItem22.OwnerDraw = True
        Me.MenuItem22.Text = "-"
        Me.MenuItem22.Visible = False
        '
        'mnuQueryStatisticsMarketingA
        '
        Me.mnuQueryStatisticsMarketingA.Enabled = False
        Me.mnuQueryStatisticsMarketingA.Index = 2
        Me.mnuQueryStatisticsMarketingA.OwnerDraw = True
        Me.mnuQueryStatisticsMarketingA.Text = "业务完成情况统计"
        '
        'mnuQueryStatisticsMarketingB
        '
        Me.mnuQueryStatisticsMarketingB.Enabled = False
        Me.mnuQueryStatisticsMarketingB.Index = 3
        Me.mnuQueryStatisticsMarketingB.OwnerDraw = True
        Me.mnuQueryStatisticsMarketingB.Text = "担保金额分段统计"
        '
        'mnuQueryStatisticsMarketingC
        '
        Me.mnuQueryStatisticsMarketingC.Enabled = False
        Me.mnuQueryStatisticsMarketingC.Index = 4
        Me.mnuQueryStatisticsMarketingC.OwnerDraw = True
        Me.mnuQueryStatisticsMarketingC.Text = "担保金额有关统计"
        '
        'MenuItem50
        '
        Me.MenuItem50.Index = 5
        Me.MenuItem50.OwnerDraw = True
        Me.MenuItem50.Text = "-"
        '
        'MenuItem46
        '
        Me.MenuItem46.Enabled = False
        Me.MenuItem46.Index = 6
        Me.MenuItem46.OwnerDraw = True
        Me.MenuItem46.Text = "担保业务分类统计"
        '
        'MenuItem30
        '
        Me.MenuItem30.Index = 7
        Me.MenuItem30.OwnerDraw = True
        Me.MenuItem30.Text = "-"
        '
        'mnuQueryStatisticsCompensation
        '
        Me.mnuQueryStatisticsCompensation.Enabled = False
        Me.mnuQueryStatisticsCompensation.Index = 8
        Me.mnuQueryStatisticsCompensation.OwnerDraw = True
        Me.mnuQueryStatisticsCompensation.Text = "代偿情况统计"
        '
        'MnItemStatisticsFee
        '
        Me.MnItemStatisticsFee.Enabled = False
        Me.MnItemStatisticsFee.Index = 9
        Me.MnItemStatisticsFee.OwnerDraw = True
        Me.MnItemStatisticsFee.Text = "收费情况统计"
        '
        'mnuQueryStatisticsRegion
        '
        Me.mnuQueryStatisticsRegion.Enabled = False
        Me.mnuQueryStatisticsRegion.Index = 10
        Me.mnuQueryStatisticsRegion.OwnerDraw = True
        Me.mnuQueryStatisticsRegion.Text = "合作区情况统计"
        '
        'mnuQueryStatisticsCounterguarantee
        '
        Me.mnuQueryStatisticsCounterguarantee.Enabled = False
        Me.mnuQueryStatisticsCounterguarantee.Index = 11
        Me.mnuQueryStatisticsCounterguarantee.OwnerDraw = True
        Me.mnuQueryStatisticsCounterguarantee.Text = "反担保情况统计"
        '
        'MnItemStaticsFirstLoan
        '
        Me.MnItemStaticsFirstLoan.Enabled = False
        Me.MnItemStaticsFirstLoan.Index = 12
        Me.MnItemStaticsFirstLoan.OwnerDraw = True
        Me.MnItemStaticsFirstLoan.Text = "首次贷款企业情况统计"
        Me.MnItemStaticsFirstLoan.Visible = False
        '
        'mnuQueryStatisticsPMService
        '
        Me.mnuQueryStatisticsPMService.Enabled = False
        Me.mnuQueryStatisticsPMService.Index = 13
        Me.mnuQueryStatisticsPMService.OwnerDraw = True
        Me.mnuQueryStatisticsPMService.Text = "项目经理业务情况统计"
        '
        'MnItemStatisticsRecommendproject
        '
        Me.MnItemStatisticsRecommendproject.Enabled = False
        Me.MnItemStatisticsRecommendproject.Index = 14
        Me.MnItemStatisticsRecommendproject.OwnerDraw = True
        Me.MnItemStatisticsRecommendproject.Text = "项目来源情况统计"
        '
        'mnuTools
        '
        Me.mnuTools.Index = -1
        Me.mnuTools.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnItemRight, Me.MenuItem23, Me.mnuToolsNotepad, Me.mnuToolsCalculator, Me.MenuItem36, Me.mnuToolsOptions})
        Me.mnuTools.OwnerDraw = True
        Me.mnuTools.Text = "工具(&T)"
        '
        'MnItemRight
        '
        Me.MnItemRight.Enabled = False
        Me.MnItemRight.Index = 0
        Me.MnItemRight.OwnerDraw = True
        Me.MnItemRight.Text = "用户管理(&U)"
        '
        'MenuItem23
        '
        Me.MenuItem23.Index = 1
        Me.MenuItem23.OwnerDraw = True
        Me.MenuItem23.Text = "-"
        '
        'mnuToolsNotepad
        '
        Me.mnuToolsNotepad.Index = 2
        Me.mnuToolsNotepad.OwnerDraw = True
        Me.mnuToolsNotepad.Text = "记事本(&N)"
        '
        'mnuToolsCalculator
        '
        Me.mnuToolsCalculator.Index = 3
        Me.mnuToolsCalculator.OwnerDraw = True
        Me.mnuToolsCalculator.Text = "计算器(&C)"
        '
        'MenuItem36
        '
        Me.MenuItem36.Index = 4
        Me.MenuItem36.OwnerDraw = True
        Me.MenuItem36.Text = "-"
        Me.MenuItem36.Visible = False
        '
        'mnuToolsOptions
        '
        Me.mnuToolsOptions.Index = 5
        Me.mnuToolsOptions.OwnerDraw = True
        Me.mnuToolsOptions.Text = "选项(&O)..."
        Me.mnuToolsOptions.Visible = False
        '
        'mnuSkin
        '
        Me.mnuSkin.Index = -1
        Me.mnuSkin.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem12, Me.MenuItem21, Me.MenuItem37, Me.MenuItem38, Me.MenuItem39, Me.MenuItem40, Me.MenuItem41, Me.MenuItem43, Me.MenuItem45, Me.MenuItem48, Me.MenuItem65, Me.MenuItem66, Me.MenuItem68, Me.MenuItem70, Me.MenuItem72, Me.MenuItem73, Me.MenuItem74, Me.MenuItem75, Me.MenuItem76, Me.MenuItem77, Me.MenuItem78, Me.MenuItem79, Me.MenuItem80})
        Me.mnuSkin.Text = "皮肤(&P)"
        '
        'MenuItem12
        '
        Me.MenuItem12.Index = 0
        Me.MenuItem12.Text = "Carlmness"
        '
        'MenuItem21
        '
        Me.MenuItem21.Index = 1
        Me.MenuItem21.Text = "Deep"
        '
        'MenuItem37
        '
        Me.MenuItem37.Index = 2
        Me.MenuItem37.Text = "Diamond"
        '
        'MenuItem38
        '
        Me.MenuItem38.Index = 3
        Me.MenuItem38.Text = "Eighteen"
        '
        'MenuItem39
        '
        Me.MenuItem39.Index = 4
        Me.MenuItem39.Text = "Emerald"
        '
        'MenuItem40
        '
        Me.MenuItem40.Index = 5
        Me.MenuItem40.Text = "Glass"
        '
        'MenuItem41
        '
        Me.MenuItem41.Index = 6
        Me.MenuItem41.Text = "Longhorn"
        '
        'MenuItem43
        '
        Me.MenuItem43.Index = 7
        Me.MenuItem43.Text = "MacOS"
        '
        'MenuItem45
        '
        Me.MenuItem45.Index = 8
        Me.MenuItem45.Text = "Midsummer"
        '
        'MenuItem48
        '
        Me.MenuItem48.Index = 9
        Me.MenuItem48.Text = "MP10"
        '
        'MenuItem65
        '
        Me.MenuItem65.Index = 10
        Me.MenuItem65.Text = "MSN"
        '
        'MenuItem66
        '
        Me.MenuItem66.Index = 11
        Me.MenuItem66.Text = "Office2007"
        '
        'MenuItem68
        '
        Me.MenuItem68.Index = 12
        Me.MenuItem68.Text = "One"
        '
        'MenuItem70
        '
        Me.MenuItem70.Index = 13
        Me.MenuItem70.Text = "Page"
        '
        'MenuItem72
        '
        Me.MenuItem72.Index = 14
        Me.MenuItem72.Text = "RealOne"
        '
        'MenuItem73
        '
        Me.MenuItem73.Index = 15
        Me.MenuItem73.Text = "Silver"
        '
        'MenuItem74
        '
        Me.MenuItem74.Index = 16
        Me.MenuItem74.Text = "Sports"
        '
        'MenuItem75
        '
        Me.MenuItem75.Index = 17
        Me.MenuItem75.Text = "Steel"
        '
        'MenuItem76
        '
        Me.MenuItem76.Index = 18
        Me.MenuItem76.Text = "Vista1"
        '
        'MenuItem77
        '
        Me.MenuItem77.Index = 19
        Me.MenuItem77.Text = "Vista2"
        '
        'MenuItem78
        '
        Me.MenuItem78.Index = 20
        Me.MenuItem78.Text = "Warm"
        '
        'MenuItem79
        '
        Me.MenuItem79.Index = 21
        Me.MenuItem79.Text = "Wave"
        '
        'MenuItem80
        '
        Me.MenuItem80.Index = 22
        Me.MenuItem80.Text = "WinXP"
        '
        'mnuView
        '
        Me.mnuView.Index = -1
        Me.mnuView.MdiList = True
        Me.mnuView.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MnItemTool, Me.MnItemStatic, Me.MenuItem25, Me.mnuTaskList, Me.MenuItem71, Me.MenuItem26})
        Me.mnuView.OwnerDraw = True
        Me.mnuView.Text = "视图(&V)"
        '
        'MnItemTool
        '
        Me.MnItemTool.Checked = True
        Me.MnItemTool.Index = 0
        Me.MnItemTool.OwnerDraw = True
        Me.MnItemTool.Text = "工具栏(&T)"
        '
        'MnItemStatic
        '
        Me.MnItemStatic.Checked = True
        Me.MnItemStatic.Index = 1
        Me.MnItemStatic.OwnerDraw = True
        Me.MnItemStatic.Text = "状态栏(&B)"
        '
        'MenuItem25
        '
        Me.MenuItem25.Index = 2
        Me.MenuItem25.OwnerDraw = True
        Me.MenuItem25.Text = "-"
        Me.MenuItem25.Visible = False
        '
        'mnuTaskList
        '
        Me.mnuTaskList.Index = 3
        Me.mnuTaskList.OwnerDraw = True
        Me.mnuTaskList.Text = "任务列表(&T)"
        Me.mnuTaskList.Visible = False
        '
        'MenuItem71
        '
        Me.MenuItem71.Index = 4
        Me.MenuItem71.OwnerDraw = True
        Me.MenuItem71.Text = "-"
        '
        'MenuItem26
        '
        Me.MenuItem26.Index = 5
        Me.MenuItem26.OwnerDraw = True
        Me.MenuItem26.Text = "刷新任务(&R)"
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = -1
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHelpContext, Me.mnuHelpIndex, Me.mnuHelpSearch, Me.mnuHelpSeparator1, Me.mnuHelpSupport, Me.mnuHelpSeparator2, Me.mnuHelpAbout})
        Me.mnuHelp.OwnerDraw = True
        Me.mnuHelp.Text = "帮助(&H)"
        '
        'mnuHelpContext
        '
        Me.mnuHelpContext.Index = 0
        Me.mnuHelpContext.OwnerDraw = True
        Me.mnuHelpContext.Shortcut = System.Windows.Forms.Shortcut.F1
        Me.mnuHelpContext.Text = "目录(&C)"
        '
        'mnuHelpIndex
        '
        Me.mnuHelpIndex.Index = 1
        Me.mnuHelpIndex.OwnerDraw = True
        Me.mnuHelpIndex.Text = "索引(&I)"
        Me.mnuHelpIndex.Visible = False
        '
        'mnuHelpSearch
        '
        Me.mnuHelpSearch.Index = 2
        Me.mnuHelpSearch.OwnerDraw = True
        Me.mnuHelpSearch.Text = "搜索(&S)"
        Me.mnuHelpSearch.Visible = False
        '
        'mnuHelpSeparator1
        '
        Me.mnuHelpSeparator1.Index = 3
        Me.mnuHelpSeparator1.OwnerDraw = True
        Me.mnuHelpSeparator1.Text = "-"
        '
        'mnuHelpSupport
        '
        Me.mnuHelpSupport.Index = 4
        Me.mnuHelpSupport.OwnerDraw = True
        Me.mnuHelpSupport.Text = "技术支持(&T)"
        '
        'mnuHelpSeparator2
        '
        Me.mnuHelpSeparator2.Index = 5
        Me.mnuHelpSeparator2.OwnerDraw = True
        Me.mnuHelpSeparator2.Text = "-"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Index = 6
        Me.mnuHelpAbout.OwnerDraw = True
        Me.mnuHelpAbout.Text = "关于(&A)"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 10000
        '
        'imgMenu
        '
        Me.imgMenu.ImageStream = CType(resources.GetObject("imgMenu.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgMenu.TransparentColor = System.Drawing.Color.Transparent
        Me.imgMenu.Images.SetKeyName(0, "")
        Me.imgMenu.Images.SetKeyName(1, "")
        Me.imgMenu.Images.SetKeyName(2, "")
        Me.imgMenu.Images.SetKeyName(3, "")
        Me.imgMenu.Images.SetKeyName(4, "")
        Me.imgMenu.Images.SetKeyName(5, "")
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.LstVwMsg)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(229, 369)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(768, 116)
        Me.Panel5.TabIndex = 20
        Me.Panel5.Visible = False
        '
        'LstVwMsg
        '
        Me.LstVwMsg.BackColor = System.Drawing.SystemColors.Window
        Me.LstVwMsg.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColNum, Me.ColProjectCode, Me.ColMessage, Me.ColTime})
        Me.LstVwMsg.ContextMenu = Me.CntxtMnMsg
        Me.LstVwMsg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LstVwMsg.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LstVwMsg.FullRowSelect = True
        Me.LstVwMsg.Location = New System.Drawing.Point(0, 0)
        Me.LstVwMsg.Name = "LstVwMsg"
        Me.LstVwMsg.Size = New System.Drawing.Size(768, 116)
        Me.LstVwMsg.TabIndex = 22
        Me.LstVwMsg.UseCompatibleStateImageBehavior = False
        Me.LstVwMsg.View = System.Windows.Forms.View.Details
        Me.LstVwMsg.Visible = False
        '
        'ColNum
        '
        Me.ColNum.Text = "序号"
        Me.ColNum.Width = 0
        '
        'ColProjectCode
        '
        Me.ColProjectCode.Text = "项目编码"
        Me.ColProjectCode.Width = 100
        '
        'ColMessage
        '
        Me.ColMessage.Text = "消息内容"
        Me.ColMessage.Width = 400
        '
        'ColTime
        '
        Me.ColTime.Text = "发送时间"
        Me.ColTime.Width = 150
        '
        'Splitter2
        '
        Me.Splitter2.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Splitter2.Location = New System.Drawing.Point(229, 333)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(768, 36)
        Me.Splitter2.TabIndex = 21
        Me.Splitter2.TabStop = False
        Me.Splitter2.Visible = False
        '
        'MenuItem81
        '
        Me.MenuItem81.Index = 2
        Me.MenuItem81.Text = "财务监管上报"
        '
        'MenuItem82
        '
        Me.MenuItem82.Index = 3
        Me.MenuItem82.Text = "业务监管上报"
        '
        'frmMainInterface
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(997, 512)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TlBrMain)
        Me.Controls.Add(Me.StatusBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMn
        Me.Name = "frmMainInterface"
        Me.Text = "担保业务管理系统(Version 2.0.1)"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.StatusBarPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBarPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.grpTask.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'Private strUser As String = UserName

    '定义WebService对象
    Private ws As htfServer.Service1 = gWs  'gWs是全局WebService对象

    '
    'arrayTasks中存放任务列表(项目编号,工作流编号,任务编号,完成任务的应用程序编号,任务节点的索引)
    '
    Dim arrayTasks As New ArrayList

    Private _taskList As FTaskList = New FTaskList
    Private _messageList As FMessage = New FMessage
    Private _messageSender As FMessageSender = New FMessageSender


    Private frmConsultaion As frmQueryCorporationInfo  '咨询登记
    Private frmAcception As frmQueryAcceptRequest    '申请受理
    Private frmProjectCredit As FProjectCredit     '资信评分
    Private _financialAnalysisForm As FFinancialAnalysis '财务分析
    Private projectInfo As frmProjectInfo   '任务列表

    '系统设置
    Private frmTemplateManage_1 As frmTemplateManage  '报告模板设置
    Private frmBranch As FBranch  '部门、分支机构设置
    Private frmStaff As FStaff  '员工设置
    Private frmRole As FRole    '角色设置
    Private frmStaffRole As FStaffRole  '员工角色
    Private frmTeam As FTeam '项目组
    Private frmServiceType As FServiceType '业务品种设置
    Private frmDistrict As FDistrict  '区
    Private frmCooperateOrganization As FCooperateOrganization  '合作单位
    Private frmProprietorshipType As FProprietorshipType  '企业所有制类型
    Private frmIndustryType As FIndustryType '行业类型
    Private frmTechnologyType As FTechnologyType  '企业科技类型
    Private frmRecommendType As FRecommendType  '推荐类型
    Private frmCurrency As FCurrency  '币种
    Private frmInvestForm As FInvestForm  '投资方式
    Private frmLoanType As FLoanType  '借款类型
    Private frmLoanForm As FLoanForm  '借款方式
    Private frmOppositeGuaranteeForm As FOppositeGuaranteeForm  '反担保方式
    Private frmLoanProvideForm As FLoanProvideForm  '放款方式
    Private frmRefundType As FRefundType  '还款方式
    Private frmLoanChargeManner As FLoanChargeManner '收费方式
    Private frmRiskClass As FRiskClass  '风险分类
    Private frmTerminateType As FTerminateType  '项目终止类型
    Private frmBank As FBank '合作银行
    Private frmItem As FItem '反担保物品种
    'Private frmItem01 As FItem01 '项目材料
    Private frmMaterial As FMaterial '项目材料
    Private frmItem02 As FItem02 '财务科目
    Private frmItem03 As FItem03 '公司文档类型
    Private frmItem04 As FItem04    '文档合同
    Private frmCorporationRelationType As FCorporatioRelationType '企业关系类型
    Private frmAlarm As FAlarm '预警信息
    Private frmWorkType As FWorkType '日志类型
    Private frmGuaranteeLetterType As FGuaranteeLetterType   '保函种类
    Private frmReimburseType As FReimburseType  '偿付责任类型

    Private frmCreditAppraiseSystem As FCreditAppraiseSystem  '资信评分指标体系
    Private frmCreditAppraiseQuantity As FCreditAppraiseQuantity  '定量评分指标
    Private frmCreditAppraiseQuality As FCreditAppraiseQuality  '定性评分指标

    '会议管理
    Private frmMeetQuery_1 As frmMeetQuery   '会议查询
    Private frmMeetSetup_1 As frmMeetSetup   '会议安排
    Private frmSignatureQuery As FSignatureQuery   '签约安排查询

    '文档管理
    Private frmDocumentSystem_1 As frmDocumentSystem  '文档查询
    Private frmCompanyFileQuery As frmCompanyFileQuery  '中心文档查询
    Private frmCompanyFileManage As frmCompanyFileManage  '中心文档管理

    '工作流管理
    Private frmSuspendProcess_1 As frmSuspendProcess
    Private frmCancelProcess_1 As frmCancelProcess
    Private frmConsignTask_1 As frmConsignTask
    Private frmCancelConsignTask_1 As frmCancelConsignTask
    Private frmManualTask_1 As frmManualTask
    Private frmReAssignAttendee_1 As frmReAssignAttendee
    Private frmProject As FProject = New FProject
    Private frmHoliday As frmHoliday
    Private frmTaskDefine As frmTaskDefine
    Private frmReMeeting As FReMeeting
    Private fOrganization As FOrganization
    Private FUpdateMeetRecord As FUpdateMeetRecord
    Private oFUpdateIntentLetter As FUpdateIntentLetter
    Private FClaimTool As FClaimTool
    Private FUpdateGuarantee As FUpdateGuarantee
    Private FFirstReviewCancel As FFirstReviewCancel
    Private FUpdateProcess As FUpdateProcess
    Private FContract As FContract

    'Private frmImportDataToExcel_1 As frmImportDataToExcel

    '查询界面
    Private frmFindProject_1 As frmFindProjectInfo  '项目查询
    Private frmQueryConsultation As FQueryConsultation '咨询企业一览表
    'Private frmQueryProjectCorporation As FQueryProjectCorporation '申请企业查询--作废
    Private frmQueryFirstProject As FQueryFirstProject '初审项目一览表
    'Private frmQueryCorporationAttendee As FQueryCorporationAttendee  '--作废
    'Private frmNeedMeetProjectQuery_1 As frmNeedMeetProjectQuery  '申请上会项目一览表 --作废
    Private frmOverdueProjectQuery_1 As frmOverdueProjectQuery  '逾期项目一览表
    Private frmRefundDebtProjectQuery_1 As frmRefundDebtProjectQuery  '代偿项目一览表
    Private frmMaturityProjectReview_1 As frmMaturityProjectReview   '到期项目一览表
    'Private frmOnVouchProjectReview_1 As frmOnVouchProjectReview   '在保项目一览表  --作废
    Private frmTerminateProjectReview_1 As frmTerminateProjectReview   '终止项目一览表
    Private frmQueryPauseProject As FQueryPauseProject   '暂缓项目一览表
    Private FQueryProjectAppraise As FQueryProjectAppraise '项目评价查询
    Private frmQryOppGuarantee_1 As frmQueryOppGuarantee   '反担保物查询
    Private frmQueryStatisticsAssurance As FQueryStatisticsAssurance   '担保业务统计
    'Private frmQueryStatisticsBank As FQueryStatisticsBank   '合作银行担保业务统计 --作废
    'Private frmQueryStatisticsIndustry As FQueryStatisticsIndustry   '担保企业行业分类统计  --作废
    Private frmQueryStatisticsTradeRegion As FQueryStatisticsTradeRegion   '担保业务分类统计
    'Private frmQueryStatisticsServiceType As FQueryStatisticsServiceType   '担保业务业务品种分类统计 --作废
    Private frmQueryStatisticsWorkLog As FQueryStatisticsWorkLog '工作日志统计

    Private firstTrialProjectQuery As FQueryFirstTrialProject '申请项目一览表
    Private acceptProjectQuery As FQueryAcceptProject '正式受理项目一览表
    Private allocateProjectQuery As FQueryAllocateProject   '项目分配一览表
    Private presentingProjectQuery As FQueryPresentingProject   '提交评审会讨论项目一览表
    Private signProjectQuery As FQuerySignProject   '签约项目一览表
    Private frmQueryunSignProject As FQueryUnSignProject   '未签约项目一览表
    Private loanProjectQuery As FQueryLoanProject   '承保项目一览表
    Private creditProjectQuery As FQueryCreditProject   '在保项目一览表
    Private requiteProjectQuery As FQueryRequiteProject '还款项目一览表
    Private recantProjectQuery As FQueryRecantProject '撤保项目一览表
    Private processingProjectQuery As FQueryProcessingProject   '各项目经理正在进行项目一览表
    Private regionProjectQuery As FQueryRegionProject   '合作区项目管理一览表
    Private chargeStatistics As FQueryChargeStatistics '收费查询
    Private FQueryUnDealProject As FQueryUnDealProject  '未处理项目一览表
    Private FQueryGuaranteeProject As FQueryGetGuaranteeProject '保函项目一览表
    Private FQueryAfterGuaranteeRecord As FQueryAfterGuaranteeRecord '保后检查一览表
    Private FQueryProjectRequite As FQueryProjectRequite '项目还款情况查询
    Private FQueryIntentLetter As FQueryIntentLetter '担保意向书发放一览表
    Private FQueryOppEvaluate As FQueryOppEvaluate '资产评估一览表

    Private _queryStatisticsMarketingA As FQueryStatisticsMarketingA   '经营情况统计（一）
    Private _queryStatisticsMarketingB As FQueryStatisticsMarketingB   '经营情况统计（二）
    Private _queryStatisticsMarketingC As FQueryStatisticsMarketingC   '经营情况统计（三）
    Private _queryStatisticsCompensation As FQueryStatisticsCompensation   '代偿情况统计
    Private frmQueryGuaranteeForm As FQueryGuaranteeForm    '反担保措施查询
    'Private _queryStatisticsGEProprietorship As FQueryStatisticsGEProprietorship '担保企业所有制类型统计 --作废
    Private _queryStatisticsRegion As FQueryStatisticsRegion   '合作区情况统计
    Private _queryStatisticsCounterGuarantee As FQueryStatisticsCounterGuarantee '反担保情况统计
    Private _queryStatisticsPMService As FQueryStatisticsPMService  '项目经理业务情况统计表
    Private frmStatisticsFee As FStatisticsFee   '收费统计表
    Private frmStatisticsRecommendProject As FStatisticsRecommendProject   '中心员工推荐项目统计表
    Private frmIsFirstLoanStat_ As frmIsFirstLoanStat   '(非)首次贷款企业统计表
    Private oFQueryGuarantingCorporation As FQueryGuarantingCorporation
    Private oFConferenceRoom As FConferenceRoom
    Private frmQueryDefectRecord As frmQueryDefectRecord
    Private frmDefectRecord As frmDefectRecord
    Private frmDefectRecordAdd As frmDefectRecordAdd
    Private FReviewGuarantee As FReviewGuarantee
    Private FProjectExpandDate As FProjectExpandDate
    Private FQueryProjectExpandDate As FQueryProjectExpandDate

    '工具
    Private frmPassword As FPassword   '口令设置
    Private FChargeFeeTool As FChargeFeeTool
    Private FChargeBackFeeTool As FChargeBackFeeTool
    Private FrmOverseeFinanceInfo As FrmOverseeFinanceInfo
    Private frmOversee As frmOversee


    Dim iProPermissionId As Integer = 0

    Public Const IMAGEPRINT As Integer = 0
    Public Const IMAGEPAGESETUP As Integer = 1
    Public Const IMAGEHELPCONTEXT As Integer = 2
    Public Const IMAGEHELPINDEX As Integer = 3
    Public Const IMAGEHELPSEARCH As Integer = 4
    Public Const IMAGEHELPSUPPORT As Integer = 5

    Private Sub Relogin()
        Dim login As SWDialogBox.LoginBox = New SWDialogBox.LoginBox

        Try
            '读取配置
            login.UserName = SWConsole.Configuration.GetAppValue("LoginBox.UserName")
            login.Server = SWConsole.Configuration.GetAppValue("LoginBox.Server")
        Catch
        End Try

        AddHandler login.Logined, AddressOf LoginedProcess

        If login.Login() Then
            Dim i As Integer
            For i = Me.MdiChildren.Length - 1 To 0 Step -1
                Me.MdiChildren(i).Close()
            Next
            setFormMenu(Me)
            Me.getTasklistAndMsg()
        End If
    End Sub
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    '                                                                      '
    '担保系统主界面                                                        '
    '2003－2－22新建                                                       ' 
    'by quexd                                                              ' 
    '                                                                      '
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    Public Sub SetStatus(ByVal status As String)
        Select Case status
            Case "Customer"
                mnuTransaction.Visible = True
                mnuBase.Visible = False
                mnuDocument.Visible = False
                mnuMeeting.Visible = False
                mnuQuery.Visible = False
                mnuWorkLog.Visible = False
                mnuWorkFlow.Visible = False
            Case "System"
                mnuTransaction.Visible = False
                mnuBase.Visible = True
                mnuDocument.Visible = False
                mnuMeeting.Visible = False
                mnuQuery.Visible = False
                mnuWorkLog.Visible = False
                mnuWorkFlow.Visible = False
            Case "Document"
                mnuTransaction.Visible = False
                mnuBase.Visible = False
                mnuDocument.Visible = True
                mnuMeeting.Visible = False
                mnuQuery.Visible = False
                mnuWorkLog.Visible = False
                mnuWorkFlow.Visible = False
            Case "Meeting"
                mnuTransaction.Visible = False
                mnuBase.Visible = False
                mnuDocument.Visible = False
                mnuMeeting.Visible = True
                mnuQuery.Visible = False
                mnuWorkLog.Visible = False
                mnuWorkFlow.Visible = False
            Case "Query"
                mnuTransaction.Visible = False
                mnuBase.Visible = False
                mnuDocument.Visible = False
                mnuMeeting.Visible = False
                mnuQuery.Visible = True
                mnuWorkLog.Visible = False
                mnuWorkFlow.Visible = False
            Case "WorkLog"
                mnuTransaction.Visible = False
                mnuBase.Visible = False
                mnuDocument.Visible = False
                mnuMeeting.Visible = False
                mnuQuery.Visible = False
                mnuWorkLog.Visible = True
                mnuWorkFlow.Visible = False
            Case "WorkFlow"
                mnuTransaction.Visible = False
                mnuBase.Visible = False
                mnuDocument.Visible = False
                mnuMeeting.Visible = False
                mnuQuery.Visible = False
                mnuWorkLog.Visible = False
                mnuWorkFlow.Visible = True
            Case Else
                mnuTransaction.Visible = True
                mnuBase.Visible = True
                mnuDocument.Visible = True
                mnuMeeting.Visible = True
                mnuQuery.Visible = True
                mnuWorkLog.Visible = True
                mnuWorkFlow.Visible = True
        End Select

        'If status = "WorkLog" Or status = "Document" Or status = "System" Or status = "Query" Then
        '    Panel1.Visible = False
        '    Panel2.Visible = False
        '    Panel3.Visible = False
        '    'Splitter1.Visible = False
        'Else
        '    Panel1.Visible = True
        '    Panel2.Visible = True
        '    Panel3.Visible = True
        '    'Splitter1.Visible = True
        'End If
    End Sub

    ''
    ''设置私有对象为Nothing
    ''参数类型：Form
    ''
    'Public Sub setFrmObject(ByVal frmName As Form)
    '    Dim strFrmName As String = frmName.Name.ToString
    '    '      setFrmObject(strFrmName)
    'End Sub
    ''
    ''设置子窗体的父窗体
    ''参数类型：Form
    ''
    ''Public Sub setMdiParent(ByVal frmObject As Form)
    ''    MsgBox(Me.Name.ToString)
    ''    frmObject.MdiParent = Me
    ''End Sub

    '
    '按照窗体的高度设置图片的位置居中；且设置工作列表和消息框的高度比率为7：2
    '
    Private Sub rePointPicture()
        'Dim height As Integer = Panel2.Height
        'PictureBox1.Location = New Point(PictureBox1.Location.X, height / 2)
        'PictureBox2.Location = New Point(PictureBox2.Location.X, height / 2)

        'Panel5.Height = Panel1.Height * 1 / 9
        ''      'Panel4.Height = Panel1.Height * 5 / 9
        'reSizeTreeWidth()
        Dim img As Image
        If System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width = 800 Then
            img = New Bitmap(New Bitmap(Application.StartupPath & "\img\backgroup800.jpg"), Me.Width, Height)
        ElseIf System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width = 1024 Then
            img = New Bitmap(New Bitmap(Application.StartupPath & "\img\backgroup1024.jpg"), Me.Width, Height)
        ElseIf System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width = 1280 Then
            img = New Bitmap(New Bitmap(Application.StartupPath & "\img\backgroup1280.jpg"), Me.Width, Height)
        ElseIf System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width = 1650 Then
            img = New Bitmap(New Bitmap(Application.StartupPath & "\img\backgroup1650.jpg"), Me.Width, Height)
        ElseIf System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width = 1920 Then
            img = New Bitmap(New Bitmap(Application.StartupPath & "\img\backgroup1920.jpg"), Me.Width, Height)
        Else
            img = New Bitmap(New Bitmap(Application.StartupPath & "\img\backgroup800.jpg"), Me.Width, Height)
        End If

        Me.BackgroundImage = img
    End Sub

    '
    '根据分辨率和主窗体的大小设定TreeView的宽度
    '
    Private Sub reSizeTreeWidth()
        Try
            Dim s As Screen
            s = Screen.AllScreens(0)
            Dim width, height As Integer
            width = s.WorkingArea.Width
            height = s.WorkingArea.Height
            'StatusBarPanel5.Text = "分辨率：" & width & "*" & height
            If ((width >= 1024) And (height >= 768)) Then
                If ((Me.Width > 800) And (Me.Height > 600)) Then
                    Panel1.Width = 240
                Else
                    Panel1.Width = 200
                End If
            End If

            Dim strPath As String

            If width > 800 Then
                StatusBarPanel5.Text = "分辨率： 1024 * 768"
                'Me.BackgroundImage = Me.ImgLstBackGround.Images(0)
                If (Me.Panel1.Visible = True) Then
                    Me.BackgroundImage = Me.BackgroundImage.FromFile(strRootPath & "\image\1024.png")
                Else
                    Me.BackgroundImage = Me.BackgroundImage.FromFile(strRootPath & "\image\All1024.png")
                End If
            Else
                StatusBarPanel5.Text = "分辨率： 800 * 600"
                'Me.BackgroundImage = Me.ImgLstBackGround.Images(1)
                If (Me.Panel1.Visible = True) Then
                    Me.BackgroundImage = Me.BackgroundImage.FromFile(strRootPath & "\image\800.png")
                Else
                    Me.BackgroundImage = Me.BackgroundImage.FromFile(strRootPath & "\image\All800.png")
                End If
            End If
        Catch
        End Try
    End Sub

    '
    '根据登录用户ID，动态生成Tree的节点
    '
    Private Sub taskTree_Load(ByVal strEmployee As String)
        If strEmployee = "" Then
            Exit Sub
        End If

        Dim ds As DataSet
        Dim dr As DataRowView
        Dim i, iCounter, taskCount As Integer
        Dim strTaskName, strTaskID, strRoleID As String
        Dim strProjectCode, strWorkFlow, strApplyTool As String

        Dim iIndx As Integer = 0

        Dim dvTmp As DataView

        arrayTasks.Clear()
        '调用WebService的方法,获得某个用户的工作任务列表
        Try
            If ws Is Nothing Then
                ws = GetWebService(strUrl)
            End If
            ds = ws.LookUpWorking(strEmployee)
            dvTmp = ds.Tables(0).DefaultView
            'dvTmp.Sort = "task_name, task_id ASC"
            dvTmp.Sort = "task_id ASC"   '鉴定前恢复为按task_id分组列出项目，鉴定后该为按任务名称分组，需要仔细考虑实现方式

            iCounter = ds.Tables(0).Rows.Count

            For i = 0 To iCounter - 1
                dr = dvTmp.Item(i)
                With dr
                    'If Not .Item("task_name") Is System.DBNull.Value Then
                    strProjectCode = .Item("project_code")
                    strWorkFlow = .Item("workflow_id")
                    strTaskID = .Item("task_id")
                    strTaskName = .Item("task_name")
                    'strRoleID = .Item("role_id")
                    If Not .Item("Apply_tool") Is System.DBNull.Value Then
                        strApplyTool = .Item("Apply_Tool")
                    Else
                        strApplyTool = ""
                    End If

                    If i = 0 Then
                        task_name_tree.Nodes(0).Nodes.Add(strTaskID)
                        task_name_tree.Nodes(0).Nodes(i).Text = strTaskName
                        'iIndx += 1
                        taskCount = 1
                    Else
                        If dvTmp.Item(i - 1).Item("task_id") <> strTaskID Then
                            task_name_tree.Nodes(0).Nodes(task_name_tree.Nodes(0).Nodes.Count - 1).Text = task_name_tree.Nodes(0).Nodes(task_name_tree.Nodes(0).Nodes.Count - 1).Text + "(" + taskCount.ToString() + ")"
                            task_name_tree.Nodes(0).Nodes.Add(strTaskID)
                            iIndx += 1
                            task_name_tree.Nodes(0).Nodes(iIndx).Text = strTaskName
                            taskCount = 1
                        Else
                            taskCount += 1
                        End If
                    End If
                    'arrayTaskID.Add(strTaskID)
                    'arrayTask.Clear()
                    arrayTasks.Add(strProjectCode)
                    arrayTasks.Add(strWorkFlow)
                    arrayTasks.Add(strTaskID)
                    arrayTasks.Add(strApplyTool)
                    arrayTasks.Add(iIndx)
                    'arrayTasks.Add(arrayTask)
                    'End If
                End With
            Next

            If task_name_tree.Nodes(0).Nodes.Count > 0 Then
                task_name_tree.Nodes(0).Nodes(task_name_tree.Nodes(0).Nodes.Count - 1).Text = task_name_tree.Nodes(0).Nodes(task_name_tree.Nodes(0).Nodes.Count - 1).Text + "(" + taskCount.ToString() + ")"
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub


    '
    'Load()方法，初始化
    '
    Private Sub frmMainInterface_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            'PictureBox1_Click(sender, e)
            Me.Cursor = Cursors.WaitCursor
            '设置Form的大小
            Me.Width = 852
            Me.Height = 602

            '根据分辨率和主窗体的大小设定TreeView的宽度
            reSizeTreeWidth()

            '启动定时器，且设置其时间间隔为60000（1秒）
            Me.Timer1.Start()
            Me.Timer1.Interval = 1000 * 30

            '重新放置左右箭头的位置
            rePointPicture()
            'Me.PictureBox2.Hide()

            '刷新任务和消息
            getTasklistAndMsg()

            '2009-06-09 yjf add 弹出消息框
            ShowMsgBx()

            Me.Cursor = Cursors.Arrow


        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MsgBox("担保系统主界面启动时出错！ (" & ex.Message & ")", MsgBoxStyle.Information, "担保系统")
        End Try
    End Sub

    '
    '以下两个方法实现左边树的收缩功能.
    '
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        If (Me.Panel1.Visible = True) Then
            Me.Panel1.Hide()
            Me.PictureBox1.Hide()
            Me.PictureBox2.Show()
        Else
            Me.Panel1.Show()
        End If
        rePointPicture()
    End Sub
    '
    '实现左边树的收缩功能
    '
    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        If (Me.Panel1.Visible = False) Then
            Me.Panel1.Show()
            Me.PictureBox1.Show()
            Me.PictureBox2.Hide()
        Else
            Me.Panel1.Show()
        End If
        rePointPicture()
    End Sub

    '
    '主窗体Size改变后的事件
    '
    Private Sub frmMainInterface_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.SizeChanged
        'rePointPicture()
    End Sub


    '
    '判断Form是否已被创建
    '
    Private Function hasCreated(ByVal frmType As Type) As Boolean
        Try
            Dim i As Integer
            Dim b As Boolean = False
            For i = 0 To Me.MdiChildren.Length - 1
                If Me.MdiChildren(i).GetType Is frmType Then
                    b = True
                    Exit For
                End If
            Next
            Return b
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    '
    '工具栏的事件
    '
    Private Sub TlBrMain_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles TlBrMain.ButtonClick

        Try
            Select Case TlBrMain.Buttons.IndexOf(e.Button)
                Case 11      '退出
                    Dim i As Integer
                    For i = Me.MdiChildren.Length - 1 To 0 Step -1
                        Me.MdiChildren(i).Close()
                    Next
                    Me.Close()
                Case 3     '企业咨询
                    Me.MnItemConsult_Click(sender, e)
                    'If hasCreated(GetType(MainInterface.frmQueryCorporationInfo)) = True Then
                    '    frmConsultaion.Activate()
                    'Else
                    '    frmConsultaion = New frmQueryCorporationInfo()
                    '    frmConsultaion.MdiParent = Me
                    '    frmConsultaion.Show()
                    'End If

                Case 5     '受理申请
                    Me.MnItemAccept_Click(sender, e)
                    'If hasCreated(GetType(MainInterface.frmQueryAcceptRequest)) = True Then
                    '    Me.frmAcception.Activate()
                    'Else
                    '    frmAcception = New frmQueryAcceptRequest()
                    '    AddHandler frmAcception.Closed, AddressOf Me.getTasklistAndMsg  '当窗口关闭时，刷新任务和消息
                    '    frmAcception.MdiParent = Me
                    '    frmAcception.WindowState = FormWindowState.Maximized
                    '    frmAcception.Show()
                    'End If

                Case 7
                    'Me.getTasklistAndMsg(sender, e)
                    task_name_tree.Nodes(0).Nodes.Clear()
                    taskTree_Load(UserName)
                    'Me.FillLstBxMsg()

                    '_taskList.Owner = Me
                    '_taskList.Show()
                    '_taskList.Clear()
                    '_taskList.Refresh(UserName)
                Case 9    '资信评分
                    If hasCreated(GetType(MainInterface.FProjectCredit)) = True Then
                        Me.frmProjectCredit.Activate()
                    Else
                        frmProjectCredit = New FProjectCredit
                        frmProjectCredit.MdiParent = Me
                        frmProjectCredit.Show()
                    End If
                Case 1    '重新登录
                    Me.Relogin()
            End Select
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
    End Sub

    '双击任务栏事件
    Private Sub task_name_tree_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles task_name_tree.DoubleClick

        Dim strTaskID As String
        Dim arrTasktmp As New ArrayList

        Dim i As Integer
        Try
            If Me.task_name_tree.SelectedNode.Parent Is Nothing Then
                Exit Sub
            End If

            If arrayTasks.Count = 0 Then
                Exit Sub
            End If

            For i = 0 To arrayTasks.Count / 5 - 1
                If Me.task_name_tree.SelectedNode.Index = arrayTasks(5 * i + 4) Then
                    strTaskID = arrayTasks(5 * i + 2)

                    '生成完成项目任务的应用程序数组
                    arrTasktmp.Add(arrayTasks(5 * i))     '项目编码
                    arrTasktmp.Add(arrayTasks(5 * i + 1))       '工作流ID
                    arrTasktmp.Add(arrayTasks(5 * i + 3))       '应用程序
                End If
            Next

            '''''启动该任务的项目列表
            For i = 0 To Me.MdiChildren.Length - 1
                If Me.MdiChildren(i).GetType Is GetType(MainInterface.frmProjectInfo) Then
                    Me.MdiChildren(i).Close()
                    Exit For
                End If
            Next
            projectInfo = New frmProjectInfo
            AddHandler projectInfo.TaskCommit, AddressOf getTasklistAndMsg   '当窗口关闭时，刷新任务和消息
            projectInfo.MdiParent = Me
            projectInfo.Text = Me.task_name_tree.SelectedNode.Text
            projectInfo.arrTask = arrTasktmp
            projectInfo.strTaskID = strTaskID
            projectInfo.Show()
        Catch
            MessageBox.Show("打开项目列表时出错！（" & Err.Description & "）", "", MessageBoxButtons.OK)
        End Try
    End Sub

    '2009-06-09 yjf add 弹出消息框
    Private Sub ShowMsgBx()
        Try
            Dim dsTmp As Data.DataSet
            Dim iCounter, i As Integer

            '只显示三天内未阅读过的消息
            dsTmp = gWs.LookUpMessage("{accepter='" & UserName & "' and is_affirmed='N' and convert(char(10),send_time,120)>=convert(char(10),dateadd(day,-3,getdate()),120) order by send_time desc}")
            If dsTmp Is Nothing Then
                Exit Sub
            End If
            'Me.LstBxMsg.DisplayMember = "message_content"
            'Me.LstBxMsg.ValueMember = "serial_num"
            'Me.LstBxMsg.DataSource = dsTmp.Tables(0)

            '填充listview控件
            Dim strTime As String
            Dim message As String

            For i = 0 To dsTmp.Tables(0).Rows.Count - 1
                Dim tmpNoteBox As New NoteBox(dsTmp.Tables(0).Rows(i))
                tmpNoteBox.Show()
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub FillLstBxMsg()
        Try
            Dim dsTmp As Data.DataSet
            Dim iCounter, i As Integer

            Me.LstVwMsg.Items.Clear()

            dsTmp = gWs.LookUpMessage("{accepter='" & UserName & "' and is_affirmed<>'Y' order by send_time desc}")
            If dsTmp Is Nothing Then
                Exit Sub
            End If
            'Me.LstBxMsg.DisplayMember = "message_content"
            'Me.LstBxMsg.ValueMember = "serial_num"
            'Me.LstBxMsg.DataSource = dsTmp.Tables(0)

            '填充listview控件
            Dim strTime As String
            Dim message As String

            For i = 0 To dsTmp.Tables(0).Rows.Count - 1
                Me.LstVwMsg.Items.Add(dsTmp.Tables(0).Rows(i).Item("serial_num"))
                If dsTmp.Tables(0).Rows(i).Item("project_code") Is DBNull.Value Then
                    Me.LstVwMsg.Items(i).SubItems.Add("")
                Else
                    Me.LstVwMsg.Items(i).SubItems.Add(dsTmp.Tables(0).Rows(i).Item("project_code"))
                End If

                Me.LstVwMsg.Items(i).SubItems.Add(dsTmp.Tables(0).Rows(i).Item("message_content"))
                strTime = dsTmp.Tables(0).Rows(i).Item("send_time")
                Me.LstVwMsg.Items(i).SubItems.Add(strTime)

                '合并消息信息（发送时间＋项目编号＋消息内容）
                'message = String.Format("{0:F}", dsTmp.Tables(0).Rows(i).Item("send_time")) + "  " + dsTmp.Tables(0).Rows(i).Item("project_code") + "  " + dsTmp.Tables(0).Rows(i).Item("message_content").ToString()
                'message = dsTmp.Tables(0).Rows(i).Item("send_time") + "  " + dsTmp.Tables(0).Rows(i).Item("project_code") + "  " + dsTmp.Tables(0).Rows(i).Item("message_content").ToString()
                'message = dsTmp.Tables(0).Rows(i).Item("message_content").ToString() + "  " + dsTmp.Tables(0).Rows(i).Item("project_code") + "  " + dsTmp.Tables(0).Rows(i).Item("send_time")
                'Me.LstVwMsg.Items(i).SubItems.Add(message)

                If dsTmp.Tables(0).Rows(i).Item("is_affirmed") = "N" Then
                    LstVwMsg.Items(i).Font = New Font(LstVwMsg.Font, FontStyle.Bold)
                Else
                    LstVwMsg.Items(i).Font = New Font(LstVwMsg.Font, FontStyle.Regular)
                End If
            Next
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        getTasklistAndMsgEx()

        '2007-10-16 yjf add 扫描预警消息
        Try
            gWs.ScanTimingTask()
        Catch

        End Try

    End Sub

    Private Sub getTasklistAndMsg(ByVal sender As Object, ByVal e As System.EventArgs)
        getTasklistAndMsg()
    End Sub

    Private Sub getTasklistAndMsg()
        Try
            '获取任务列表
            task_name_tree.Nodes(0).Nodes.Clear()
            taskTree_Load(UserName)
            '展开工作列表树的所有节点
            Me.task_name_tree.ExpandAll()

            '获取消息列表
            'FillLstBxMsg()
            Me.StatusBarPanel2.Text = ""

        Catch ex As Exception
            Me.StatusBarPanel2.Text = "获取用户为：" & UserName & " 的任务列表时出错！(" & ex.Message & ")"
            'MsgBox("获取用户为" & UserName & " 的任务和消息列表时出错！(" & ex.Message & ")", MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub getTasklistAndMsgEx()
        Try
            '判断当前用户是否有新的任务或消息
            Dim ds As DataSet = gWs.GetStaff("{staff_name='" & UserName & "'}")
            If ds.Tables(0).Rows(0).Item("DoScan") Then

                '获取任务列表
                task_name_tree.Nodes(0).Nodes.Clear()
                taskTree_Load(UserName)
                '展开工作列表树的所有节点
                Me.task_name_tree.ExpandAll()

                '获取消息列表
                'FillLstBxMsg()

                '2009-06-09 yjf add 弹出消息框
                ShowMsgBx()

                Me.StatusBarPanel2.Text = ""

                ds.Tables(0).Rows(0).Item("DoScan") = 0
                gWs.UpdateStaff(ds)

            End If

        Catch ex As Exception
            Me.StatusBarPanel2.Text = "获取用户为：" & UserName & " 的任务列表时出错！(" & ex.Message & ")"
            'MsgBox("获取用户为" & UserName & " 的任务和消息列表时出错！(" & ex.Message & ")", MsgBoxStyle.Critical, "错误")
        End Try
    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem44.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmTemplateManage)) = True Then
                Me.frmTemplateManage_1.Activate()
            Else
                frmTemplateManage_1 = New frmTemplateManage
                frmTemplateManage_1.MdiParent = Me
                frmTemplateManage_1.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub MenuItem54_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem54.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FLoanForm)) = True Then
                Me.frmLoanForm.Activate()
            Else
                frmLoanForm = New FLoanForm
                frmLoanForm.MdiParent = Me
                frmLoanForm.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem62_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem62.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FServiceType)) = True Then
                Me.frmServiceType.Activate()
            Else
                frmServiceType = New FServiceType
                frmServiceType.MdiParent = Me
                frmServiceType.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem53_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem53.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FDistrict)) = True Then
                Me.frmDistrict.Activate()
            Else
                frmDistrict = New FDistrict
                frmDistrict.MdiParent = Me
                frmDistrict.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem58_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem58.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FProprietorshipType)) = True Then
                Me.frmProprietorshipType.Activate()
            Else
                frmProprietorshipType = New FProprietorshipType
                frmProprietorshipType.MdiParent = Me
                frmProprietorshipType.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem51_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem51.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FIndustryType)) = True Then
                Me.frmIndustryType.Activate()
            Else
                frmIndustryType = New FIndustryType
                frmIndustryType.MdiParent = Me
                frmIndustryType.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem63_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem63.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FTechnologyType)) = True Then
                Me.frmTechnologyType.Activate()
            Else
                frmTechnologyType = New FTechnologyType
                frmTechnologyType.MdiParent = Me
                frmTechnologyType.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem59_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem59.Click
        Try
            Me.Cursor = Cursors.AppStarting
            If hasCreated(GetType(MainInterface.FRecommendType)) = True Then
                Me.frmRecommendType.Activate()
            Else
                frmRecommendType = New FRecommendType
                frmRecommendType.MdiParent = Me
                frmRecommendType.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem34.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FCurrency)) = True Then
                Me.frmCurrency.Activate()
            Else
                frmCurrency = New FCurrency
                frmCurrency.MdiParent = Me
                frmCurrency.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem52_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem52.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FInvestForm)) = True Then
                Me.frmInvestForm.Activate()
            Else
                frmInvestForm = New FInvestForm
                frmInvestForm.MdiParent = Me
                frmInvestForm.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem55_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem55.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FLoanProvideForm)) = True Then
                Me.frmLoanProvideForm.Activate()
            Else
                frmLoanProvideForm = New FLoanProvideForm
                frmLoanProvideForm.MdiParent = Me
                frmLoanProvideForm.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem56_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem56.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FLoanType)) = True Then
                Me.frmLoanType.Activate()
            Else
                frmLoanType = New FLoanType
                frmLoanType.MdiParent = Me
                frmLoanType.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem57_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem57.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FOppositeGuaranteeForm)) = True Then
                Me.frmOppositeGuaranteeForm.Activate()
            Else
                frmOppositeGuaranteeForm = New FOppositeGuaranteeForm
                frmOppositeGuaranteeForm.MdiParent = Me
                frmOppositeGuaranteeForm.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem60_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem60.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FRefundType)) = True Then
                Me.frmRefundType.Activate()
            Else
                frmRefundType = New FRefundType
                frmRefundType.MdiParent = Me
                frmRefundType.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem61_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem61.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FRiskClass)) = True Then
                Me.frmRiskClass.Activate()
            Else
                frmRiskClass = New FRiskClass
                frmRiskClass.MdiParent = Me
                frmRiskClass.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem64_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem64.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FTerminateType)) = True Then
                Me.frmTerminateType.Activate()
            Else
                frmTerminateType = New FTerminateType
                frmTerminateType.MdiParent = Me
                frmTerminateType.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub MenuItem42_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemTeam.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FTeam)) = True Then
                Me.frmTeam.Activate()
            Else
                frmTeam = New FTeam
                frmTeam.MdiParent = Me
                frmTeam.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem67_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemMeetQuery.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmMeetQuery)) = True Then
                Me.frmMeetQuery_1.Activate()
            Else
                frmMeetQuery_1 = New frmMeetQuery
                frmMeetQuery_1.MdiParent = Me
                frmMeetQuery_1.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem68_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemProPause.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmSuspendProcess)) = True Then
                Me.frmSuspendProcess_1.Activate()
            Else
                frmSuspendProcess_1 = New frmSuspendProcess
                frmSuspendProcess_1.MdiParent = Me
                frmSuspendProcess_1.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem69_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemProCancel.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmCancelProcess)) = True Then
                Me.frmCancelProcess_1.Activate()
            Else
                frmCancelProcess_1 = New frmCancelProcess
                AddHandler frmCancelProcess_1.refreshTaskCommit, AddressOf Me.getTasklistAndMsg
                frmCancelProcess_1.MdiParent = Me
                frmCancelProcess_1.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub MenuItem70_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemMeetSet.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmMeetSetup)) = True Then
                Me.frmMeetSetup_1.Activate()
            Else
                frmMeetSetup_1 = New frmMeetSetup
                frmMeetSetup_1.btnArrangeProject.Visible = False
                frmMeetSetup_1.MdiParent = Me
                frmMeetSetup_1.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemRight.Click
        Try
            Me.Cursor = Cursors.AppStarting

            Dim strComnd As String
            strComnd = "SWUserManager.exe """ & UserName & """ """ & strPasswd & """ ""[" & wsPermission.Url & "]"""
            Me.iProPermissionId = Shell(strComnd, AppWinStyle.NormalFocus)
            'Shell("""SWUserManager.exe"" " & UserName & """ """ & strPasswd & """ " & strServer, AppWinStyle.Hide)
        Catch ex As Exception
            Me.iProPermissionId = 0
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmMainInterface_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        Try
            If Me.iProPermissionId <> 0 Then
                Dim oProcess As System.Diagnostics.Process

                oProcess = System.Diagnostics.Process.GetProcessById(Me.iProPermissionId)
                If Not oProcess Is Nothing Then
                    oProcess.Kill()
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem19.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmFindProjectInfo)) = True Then
                Me.frmFindProject_1.Activate()
            Else
                frmFindProject_1 = New frmFindProjectInfo
                frmFindProject_1.MdiParent = Me
                frmFindProject_1.WindowState = FormWindowState.Maximized
                frmFindProject_1.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem20.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryConsultation)) = True Then
                Me.frmQueryConsultation.Activate()
            Else
                frmQueryConsultation = New FQueryConsultation
                frmQueryConsultation.MdiParent = Me
                frmQueryConsultation.WindowState = FormWindowState.Maximized
                frmQueryConsultation.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub MnItemTool_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemTool.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If Me.MnItemTool.Checked = False Then
                Me.MnItemTool.Checked = True
                Me.TlBrMain.Visible = True
            Else
                Me.MnItemTool.Checked = False
                Me.TlBrMain.Visible = False
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemStatic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemStatic.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If Me.MnItemStatic.Checked = False Then
                Me.MnItemStatic.Checked = True
                Me.StatusBar1.Visible = True
            Else
                Me.MnItemStatic.Checked = False
                Me.StatusBar1.Visible = False
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem24.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmOverdueProjectQuery)) = True Then
                Me.frmOverdueProjectQuery_1.Activate()
            Else
                frmOverdueProjectQuery_1 = New frmOverdueProjectQuery
                frmOverdueProjectQuery_1.MdiParent = Me
                frmOverdueProjectQuery_1.WindowState = FormWindowState.Maximized
                frmOverdueProjectQuery_1.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub MenuItem26_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem26.Click
        Try
            Me.Cursor = Cursors.AppStarting

            task_name_tree.Nodes(0).Nodes.Clear()
            taskTree_Load(UserName)
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub MenuItem28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem28.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryFirstProject)) = True Then
                Me.frmQueryFirstProject.Activate()
            Else
                frmQueryFirstProject = New FQueryFirstProject
                frmQueryFirstProject.MdiParent = Me
                frmQueryFirstProject.WindowState = FormWindowState.Maximized
                frmQueryFirstProject.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem35_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemBranch.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FBranch)) = True Then
                Me.frmBranch.Activate()
            Else
                frmBranch = New FBranch
                frmBranch.MdiParent = Me
                frmBranch.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemRole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemRole.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FRole)) = True Then
                Me.frmRole.Activate()
            Else
                frmRole = New FRole
                frmRole.MdiParent = Me
                frmRole.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemStaff_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemStaff.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FStaff)) = True Then
                Me.frmStaff.Activate()
            Else
                frmStaff = New FStaff
                frmStaff.MdiParent = Me
                frmStaff.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemStaffRole_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemStaffRole.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FStaffRole)) = True Then
                Me.frmStaffRole.Activate()
            Else
                frmStaffRole = New FStaffRole
                frmStaffRole.MdiParent = Me
                frmStaffRole.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    '到期项目一览表
    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem13.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmMaturityProjectReview)) = True Then
                Me.frmMaturityProjectReview_1.Activate()
            Else
                frmMaturityProjectReview_1 = New frmMaturityProjectReview
                frmMaturityProjectReview_1.MdiParent = Me
                frmMaturityProjectReview_1.WindowState = FormWindowState.Maximized
                frmMaturityProjectReview_1.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '终止项目一览表
    Private Sub MenuItem49_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem49.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmTerminateProjectReview)) = True Then
                Me.frmTerminateProjectReview_1.Activate()
            Else
                frmTerminateProjectReview_1 = New frmTerminateProjectReview
                frmTerminateProjectReview_1.MdiParent = Me
                frmTerminateProjectReview_1.WindowState = FormWindowState.Maximized
                frmTerminateProjectReview_1.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemAccept_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemAccept.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmQueryAcceptRequest)) = True Then
                Me.frmAcception.Activate()
            Else
                frmAcception = New frmQueryAcceptRequest
                AddHandler frmAcception.refreshTask, AddressOf Me.getTasklistAndMsg     '当窗口关闭时，刷新任务和消息
                frmAcception.MdiParent = Me
                frmAcception.WindowState = FormWindowState.Maximized
                frmAcception.Show()
            End If

        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemConsult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemConsult.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmQueryCorporationInfo)) = True Then
                frmConsultaion.Activate()
            Else
                frmConsultaion = New frmQueryCorporationInfo
                AddHandler frmConsultaion.reFreshTask, AddressOf getTasklistAndMsg
                frmConsultaion.MdiParent = Me
                frmConsultaion.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem29.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryPauseProject)) = True Then
                frmQueryPauseProject.Activate()
            Else
                frmQueryPauseProject = New FQueryPauseProject
                frmQueryPauseProject.MdiParent = Me
                frmQueryPauseProject.WindowState = FormWindowState.Maximized
                frmQueryPauseProject.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem15.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmQueryOppGuarantee)) = True Then
                frmQryOppGuarantee_1.Activate()
            Else
                frmQryOppGuarantee_1 = New frmQueryOppGuarantee
                frmQryOppGuarantee_1.MdiParent = Me
                frmQryOppGuarantee_1.WindowState = FormWindowState.Maximized
                frmQryOppGuarantee_1.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem35_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem35.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryStatisticsAssurance)) = True Then
                frmQueryStatisticsAssurance.Activate()
            Else
                frmQueryStatisticsAssurance = New FQueryStatisticsAssurance
                frmQueryStatisticsAssurance.MdiParent = Me
                frmQueryStatisticsAssurance.WindowState = FormWindowState.Maximized
                frmQueryStatisticsAssurance.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemProConsign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemProConsign.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmConsignTask)) = True Then
                frmConsignTask_1.Activate()
            Else
                frmConsignTask_1 = New frmConsignTask(UserName)
                AddHandler frmConsignTask_1.refreshTaskCommit, AddressOf Me.getTasklistAndMsg
                frmConsignTask_1.MdiParent = Me
                'frmConsignTask.WindowState = FormWindowState.Maximized
                frmConsignTask_1.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemProCancelCon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemProCancelCon.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmCancelConsignTask)) = True Then
                frmCancelConsignTask_1.Activate()
            Else
                frmCancelConsignTask_1 = New frmCancelConsignTask
                AddHandler frmCancelConsignTask_1.refreshTaskCommit, AddressOf Me.getTasklistAndMsg
                frmCancelConsignTask_1.MdiParent = Me
                'frmCancelConsignTask.WindowState = FormWindowState.Maximized
                frmCancelConsignTask_1.Show()
            End If

        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemProManual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemProManual.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmManualTask)) = True Then
                frmManualTask_1.Activate()
            Else
                frmManualTask_1 = New frmManualTask
                AddHandler frmManualTask_1.refreshTaskCommit, AddressOf Me.getTasklistAndMsg
                frmManualTask_1.MdiParent = Me
                'frmManualTask.WindowState = FormWindowState.Maximized
                frmManualTask_1.Show()
            End If

        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemProAssign_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemProAssign.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmReAssignAttendee)) = True Then
                frmReAssignAttendee_1.Activate()
            Else
                frmReAssignAttendee_1 = New frmReAssignAttendee
                frmReAssignAttendee_1.MdiParent = Me
                'frmReAssignAttendee.WindowState = FormWindowState.Maximized
                frmReAssignAttendee_1.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LstVwMsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstVwMsg.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If Me.LstVwMsg.Items.Count = 0 Then
                Exit Sub
            End If
            If Me.LstVwMsg.FocusedItem Is Nothing Then
                Exit Sub
            End If

            Me.StatusBar1.Panels(0).Text = Me.LstVwMsg.FocusedItem.SubItems(2).Text

            Dim iNum As Int64
            Dim dsTmp As DataSet

            iNum = Me.LstVwMsg.FocusedItem.Text
            'Me.LstBxMsg.
            dsTmp = gWs.LookUpMessage("{serial_num=" & iNum.ToString & "}")
            If Not dsTmp Is Nothing Then
                'MessageBox.Show(dsTmp.Tables(0).Rows(0).Item("message_content"), "消息内容", MessageBoxButtons.OK, MessageBoxIcon.None)
                dsTmp.Tables(0).Rows(0).Item("is_affirmed") = "R"
                gWs.UpdateMessage(dsTmp)
            End If
            Me.LstVwMsg.FocusedItem.Font = New Font(LstVwMsg.Font, FontStyle.Regular)
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LstVwMsg_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstVwMsg.DoubleClick
        Try
            Me.Cursor = Cursors.WaitCursor

            If LstVwMsg.SelectedItems.Count > 0 Then
                Dim projectNo As String = LstVwMsg.SelectedItems(0).SubItems(1).Text
                If projectNo = String.Empty Then
                    Exit Sub
                End If
                Dim projectInfo As frmShowProjectInfo = New frmShowProjectInfo(projectNo)
                projectInfo.TabControl1.SelectedTab = projectInfo.TabPage2
                'projectInfo.MdiParent = Me
                projectInfo.ShowDialog(Me)
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItmfreshMsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItmfreshMsg.Click
        Try
            Me.Cursor = Cursors.AppStarting

            Me.getTasklistAndMsg(sender, e)
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItmReadMsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItmReadMsg.Click
        If Me.LstVwMsg.FocusedItem Is Nothing Then
            Exit Sub
        End If
        MessageBox.Show(Me.LstVwMsg.FocusedItem.SubItems(2).Text, "消息内容", MessageBoxButtons.OK, MessageBoxIcon.None)
    End Sub

    Private Sub MnItmDelMsg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItmDelMsg.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If Me.LstVwMsg.FocusedItem Is Nothing Then
                Exit Sub
            End If

            Dim iNum As Int64
            Dim dsTmp As DataSet
            iNum = Me.LstVwMsg.FocusedItem.Text
            'Me.LstBxMsg.
            dsTmp = gWs.LookUpMessage("{serial_num=" & iNum.ToString & "}")
            If Not dsTmp Is Nothing Then
                'MessageBox.Show(dsTmp.Tables(0).Rows(0).Item("message_content"), "消息内容", MessageBoxButtons.OK, MessageBoxIcon.None)
                dsTmp.Tables(0).Rows(0).Item("is_affirmed") = "Y"
                gWs.UpdateMessage(dsTmp)
            End If
            'Me.FillLstBxMsg()
            Me.LstVwMsg.FocusedItem.Remove()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub LstVwMsg_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstVwMsg.Leave
        Me.StatusBar1.Panels(0).Text = ""
    End Sub

    'Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
    '    If hasCreated(GetType(MainInterface.FQueryStatisticsBank)) = True Then
    '        frmQueryStatisticsBank.Activate()
    '    Else
    '        frmQueryStatisticsBank = New FQueryStatisticsBank()
    '        frmQueryStatisticsBank.MdiParent = Me
    '        frmQueryStatisticsBank.WindowState = FormWindowState.Maximized
    '        frmQueryStatisticsBank.Show()
    '    End If
    'End Sub

    'Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
    '    If hasCreated(GetType(MainInterface.FQueryStatisticsIndustry)) = True Then
    '        frmQueryStatisticsIndustry.Activate()
    '    Else
    '        frmQueryStatisticsIndustry = New FQueryStatisticsIndustry()
    '        frmQueryStatisticsIndustry.MdiParent = Me
    '        frmQueryStatisticsIndustry.WindowState = FormWindowState.Maximized
    '        frmQueryStatisticsIndustry.Show()
    '    End If
    'End Sub

    Private Sub MenuItem46_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem46.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryStatisticsTradeRegion)) = True Then
                frmQueryStatisticsTradeRegion.Activate()
            Else
                frmQueryStatisticsTradeRegion = New FQueryStatisticsTradeRegion
                frmQueryStatisticsTradeRegion.MdiParent = Me
                frmQueryStatisticsTradeRegion.WindowState = FormWindowState.Maximized
                frmQueryStatisticsTradeRegion.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click
    '    If hasCreated(GetType(MainInterface.FQueryStatisticsServiceType)) = True Then
    '        frmQueryStatisticsServiceType.Activate()
    '    Else
    '        frmQueryStatisticsServiceType = New FQueryStatisticsServiceType()
    '        frmQueryStatisticsServiceType.MdiParent = Me
    '        frmQueryStatisticsServiceType.WindowState = FormWindowState.Maximized
    '        frmQueryStatisticsServiceType.Show()
    '    End If
    'End Sub

    Private Sub mnuToolsPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolsPassword.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FPassword)) = True Then
                frmPassword.Activate()
            Else
                frmPassword = New FPassword
                'frmPassword.MdiParent = Me
                frmPassword.ShowDialog()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemBank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemBank.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FBank)) = True Then
                frmBank.Activate()
            Else
                frmBank = New FBank
                frmBank.MdiParent = Me
                frmBank.WindowState = FormWindowState.Maximized
                frmBank.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemCreditSystem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemCreditSystem.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FCreditAppraiseSystem)) = True Then
                frmCreditAppraiseSystem.Activate()
            Else
                frmCreditAppraiseSystem = New FCreditAppraiseSystem
                frmCreditAppraiseSystem.MdiParent = Me
                frmCreditAppraiseSystem.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemCreditQuantity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemCreditQuantity.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FCreditAppraiseQuantity)) = True Then
                frmCreditAppraiseQuantity.Activate()
            Else
                frmCreditAppraiseQuantity = New FCreditAppraiseQuantity
                frmCreditAppraiseQuantity.MdiParent = Me
                frmCreditAppraiseQuantity.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemQuality_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemQuality.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FCreditAppraiseQuality)) = True Then
                frmCreditAppraiseQuality.Activate()
            Else
                frmCreditAppraiseQuality = New FCreditAppraiseQuality
                frmCreditAppraiseQuality.MdiParent = Me
                frmCreditAppraiseQuality.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemGuaranty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemGuaranty.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FItem)) = True Then
                frmItem.Activate()
            Else
                frmItem = New FItem
                frmItem.MdiParent = Me
                frmItem.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemMaterial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemMaterial.Click
        Try
            Me.Cursor = Cursors.AppStarting

            'If hasCreated(GetType(MainInterface.FItem01)) = True Then
            '    frmItem01.Activate()
            'Else
            '    frmItem01 = New FItem01()
            '    frmItem01.MdiParent = Me
            '    frmItem01.Show()
            'End If

            If hasCreated(GetType(MainInterface.FMaterial)) = True Then
                frmMaterial.Activate()
            Else
                frmMaterial = New FMaterial
                frmMaterial.MdiParent = Me
                frmMaterial.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemDocQry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemDocQry.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmDocumentSystem)) = True Then
                frmDocumentSystem_1.Activate()
            Else
                frmDocumentSystem_1 = New frmDocumentSystem
                frmDocumentSystem_1.MdiParent = Me
                frmDocumentSystem_1.Show()
            End If

        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemCooperate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemCooperate.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FCooperateOrganization)) = True Then
                frmCooperateOrganization.Activate()
            Else
                frmCooperateOrganization = New FCooperateOrganization
                frmCooperateOrganization.MdiParent = Me
                frmCooperateOrganization.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem67_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem67.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmRefundDebtProjectQuery)) = True Then
                frmRefundDebtProjectQuery_1.Activate()
            Else
                frmRefundDebtProjectQuery_1 = New frmRefundDebtProjectQuery
                frmRefundDebtProjectQuery_1.MdiParent = Me
                frmRefundDebtProjectQuery_1.WindowState = FormWindowState.Maximized
                frmRefundDebtProjectQuery_1.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnFincialItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnFincialItem.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FItem02)) = True Then
                frmItem02.Activate()
            Else
                frmItem02 = New FItem02
                frmItem02.MdiParent = Me
                frmItem02.WindowState = FormWindowState.Maximized
                frmItem02.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuDataItem04_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDataItem04.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FItem04)) = True Then
                frmItem04.Activate()
            Else
                frmItem04 = New FItem04
                frmItem04.MdiParent = Me
                frmItem04.WindowState = FormWindowState.Maximized
                frmItem04.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem68_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuProjectDelete.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FProject)) = True Then
                frmProject.Activate()
            Else
                frmProject = New FProject
                AddHandler frmProject.refreshTaskCommit, AddressOf Me.getTasklistAndMsg
                frmProject.MdiParent = Me
                frmProject.WindowState = FormWindowState.Maximized
                frmProject.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuCorporationRelationType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCorporationRelationType.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FCorporatioRelationType)) = True Then
                frmCorporationRelationType.Activate()
            Else
                frmCorporationRelationType = New FCorporatioRelationType
                frmCorporationRelationType.MdiParent = Me
                frmCorporationRelationType.WindowState = FormWindowState.Maximized
                frmCorporationRelationType.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuTaskList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTaskList.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If _taskList.IsDisposed Then
                _taskList = New FTaskList
            End If

            _taskList.Owner = Me
            _taskList.Show()
            _taskList.Refresh(UserName)
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuMessages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMessages.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If _messageList.IsDisposed Then
                _messageList = New FMessage
            End If

            _messageList.Owner = Me
            _messageList.ShowDialog()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuAlarm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAlarm.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FAlarm)) = True Then
                frmAlarm.Activate()
            Else
                frmAlarm = New FAlarm
                frmAlarm.MdiParent = Me
                frmAlarm.WindowState = FormWindowState.Maximized
                frmAlarm.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuWorkType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWorkType.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FWorkType)) = True Then
                frmWorkType.Activate()
            Else
                frmWorkType = New FWorkType
                frmWorkType.MdiParent = Me
                frmWorkType.WindowState = FormWindowState.Maximized
                frmWorkType.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuWorkLogEnter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWorkLogEnter.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If WorkLog Is Nothing OrElse WorkLog.IsDisposed Then
                WorkLog = New FWorkLog
            End If

            WorkLog.MdiParent = Me
            WorkLog.WindowState = FormWindowState.Maximized
            WorkLog.Show()
            WorkLog.Activate()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuWorkLogQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWorkLogQuery.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If QueryWorkLog Is Nothing OrElse QueryWorkLog.IsDisposed Then
                QueryWorkLog = New FQueryWorkLog
            End If
            QueryWorkLog.WindowState = FormWindowState.Maximized
            QueryWorkLog.MdiParent = Me
            QueryWorkLog.Show()
            QueryWorkLog.Activate()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuItem03_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItem03.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FItem03)) = True Then
                frmItem03.Activate()
            Else
                frmItem03 = New FItem03
                frmItem03.MdiParent = Me
                frmItem03.WindowState = FormWindowState.Maximized
                frmItem03.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem69_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem69.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmCompanyFileQuery)) = True Then
                frmCompanyFileQuery.Activate()
            Else
                frmCompanyFileQuery = New frmCompanyFileQuery
                frmCompanyFileQuery.MdiParent = Me
                frmCompanyFileQuery.WindowState = FormWindowState.Maximized
                frmCompanyFileQuery.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuCompanyFileManage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCompanyFileManage.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmCompanyFileManage)) = True Then
                frmCompanyFileManage.Activate()
            Else
                frmCompanyFileManage = New frmCompanyFileManage
                frmCompanyFileManage.MdiParent = Me
                frmCompanyFileManage.WindowState = FormWindowState.Maximized
                frmCompanyFileManage.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmMainInterface_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        StatusBarPanel3.Text = "操作员：" & UserName
    End Sub

    Private Sub mnuQueryFirstTrialProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryFirstTrialProject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryFirstTrialProject)) = True Then
                firstTrialProjectQuery.Activate()
            Else
                firstTrialProjectQuery = New FQueryFirstTrialProject
                firstTrialProjectQuery.MdiParent = Me
                firstTrialProjectQuery.WindowState = FormWindowState.Maximized
                firstTrialProjectQuery.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryAcceptProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryAcceptProject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryAcceptProject)) = True Then
                acceptProjectQuery.Activate()
            Else
                acceptProjectQuery = New FQueryAcceptProject
                acceptProjectQuery.MdiParent = Me
                acceptProjectQuery.WindowState = FormWindowState.Maximized
                acceptProjectQuery.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryAllocateProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryAllocateProject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryAllocateProject)) = True Then
                allocateProjectQuery.Activate()
            Else
                allocateProjectQuery = New FQueryAllocateProject
                allocateProjectQuery.MdiParent = Me
                allocateProjectQuery.WindowState = FormWindowState.Maximized
                allocateProjectQuery.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryPresentingProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryPresentingProject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryPresentingProject)) = True Then
                presentingProjectQuery.Activate()
            Else
                presentingProjectQuery = New FQueryPresentingProject
                presentingProjectQuery.MdiParent = Me
                presentingProjectQuery.WindowState = FormWindowState.Maximized
                presentingProjectQuery.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQuerySignProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQuerySignProject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQuerySignProject)) = True Then
                signProjectQuery.Activate()
            Else
                signProjectQuery = New FQuerySignProject
                signProjectQuery.MdiParent = Me
                signProjectQuery.WindowState = FormWindowState.Maximized
                signProjectQuery.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryLoanProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryLoanProject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryLoanProject)) = True Then
                loanProjectQuery.Activate()
            Else
                loanProjectQuery = New FQueryLoanProject
                loanProjectQuery.MdiParent = Me
                loanProjectQuery.WindowState = FormWindowState.Maximized
                loanProjectQuery.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryCreditProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryCreditProject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryCreditProject)) = True Then
                creditProjectQuery.Activate()
            Else
                creditProjectQuery = New FQueryCreditProject
                creditProjectQuery.MdiParent = Me
                creditProjectQuery.WindowState = FormWindowState.Maximized
                creditProjectQuery.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryRequiteProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryRequiteProject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryRequiteProject)) = True Then
                requiteProjectQuery.Activate()
            Else
                requiteProjectQuery = New FQueryRequiteProject
                requiteProjectQuery.MdiParent = Me
                requiteProjectQuery.WindowState = FormWindowState.Maximized
                requiteProjectQuery.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryRecantProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryRecantProject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryRecantProject)) = True Then
                recantProjectQuery.Activate()
            Else
                recantProjectQuery = New FQueryRecantProject
                recantProjectQuery.MdiParent = Me
                recantProjectQuery.WindowState = FormWindowState.Maximized
                recantProjectQuery.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryProcessingProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryProcessingProject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryProcessingProject)) = True Then
                processingProjectQuery.Activate()
            Else
                processingProjectQuery = New FQueryProcessingProject
                processingProjectQuery.MdiParent = Me
                processingProjectQuery.WindowState = FormWindowState.Maximized
                processingProjectQuery.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryRegionProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryRegionProject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryRegionProject)) = True Then
                regionProjectQuery.Activate()
            Else
                regionProjectQuery = New FQueryRegionProject
                regionProjectQuery.MdiParent = Me
                regionProjectQuery.WindowState = FormWindowState.Maximized
                regionProjectQuery.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryChargeStatistics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryChargeStatistics.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryChargeStatistics)) = True Then
                chargeStatistics.Activate()
            Else
                chargeStatistics = New FQueryChargeStatistics
                chargeStatistics.MdiParent = Me
                chargeStatistics.WindowState = FormWindowState.Maximized
                chargeStatistics.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuWorkFlowHoliday_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWorkFlowHoliday.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmHoliday)) = True Then
                frmHoliday.Activate()
            Else
                frmHoliday = New frmHoliday
                frmHoliday.MdiParent = Me
                frmHoliday.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuWorkFlowTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWorkFlowTask.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmTaskDefine)) = True Then
                frmTaskDefine.Activate()
            Else
                frmTaskDefine = New frmTaskDefine
                frmTaskDefine.MdiParent = Me
                frmTaskDefine.WindowState = FormWindowState.Maximized
                frmTaskDefine.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuCreditProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCreditProject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FProjectCredit)) = True Then
                frmProjectCredit.Activate()
            Else
                frmProjectCredit = New FProjectCredit
                frmProjectCredit.MdiParent = Me
                frmProjectCredit.WindowState = FormWindowState.Maximized
                frmProjectCredit.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryStatisticsMarketingA_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryStatisticsMarketingA.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryStatisticsMarketingA)) = True Then
                _queryStatisticsMarketingA.Activate()
            Else
                _queryStatisticsMarketingA = New FQueryStatisticsMarketingA
                _queryStatisticsMarketingA.MdiParent = Me
                _queryStatisticsMarketingA.WindowState = FormWindowState.Maximized
                _queryStatisticsMarketingA.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryStatisticsMarketingB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryStatisticsMarketingB.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryStatisticsMarketingB)) = True Then
                _queryStatisticsMarketingB.Activate()
            Else
                _queryStatisticsMarketingB = New FQueryStatisticsMarketingB
                _queryStatisticsMarketingB.MdiParent = Me
                _queryStatisticsMarketingB.WindowState = FormWindowState.Maximized
                _queryStatisticsMarketingB.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryStatisticsMarketingC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryStatisticsMarketingC.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryStatisticsMarketingC)) = True Then
                _queryStatisticsMarketingC.Activate()
            Else
                _queryStatisticsMarketingC = New FQueryStatisticsMarketingC
                _queryStatisticsMarketingC.MdiParent = Me
                _queryStatisticsMarketingC.WindowState = FormWindowState.Maximized
                _queryStatisticsMarketingC.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryStatisticsCompensation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryStatisticsCompensation.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryStatisticsCompensation)) = True Then
                _queryStatisticsCompensation.Activate()
            Else
                _queryStatisticsCompensation = New FQueryStatisticsCompensation
                _queryStatisticsCompensation.MdiParent = Me
                _queryStatisticsCompensation.WindowState = FormWindowState.Maximized
                _queryStatisticsCompensation.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub mnuQueryStatisticsRegion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryStatisticsRegion.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryStatisticsRegion)) = True Then
                _queryStatisticsRegion.Activate()
            Else
                _queryStatisticsRegion = New FQueryStatisticsRegion
                _queryStatisticsRegion.MdiParent = Me
                _queryStatisticsRegion.WindowState = FormWindowState.Maximized
                _queryStatisticsRegion.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryStatisticsCounterguarantee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryStatisticsCounterguarantee.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryStatisticsCounterGuarantee)) = True Then
                _queryStatisticsCounterGuarantee.Activate()
            Else
                _queryStatisticsCounterGuarantee = New FQueryStatisticsCounterGuarantee
                _queryStatisticsCounterGuarantee.MdiParent = Me
                _queryStatisticsCounterGuarantee.WindowState = FormWindowState.Maximized
                _queryStatisticsCounterGuarantee.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuQueryStatisticsPMService_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryStatisticsPMService.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryStatisticsPMService)) = True Then
                _queryStatisticsPMService.Activate()
            Else
                _queryStatisticsPMService = New FQueryStatisticsPMService
                _queryStatisticsPMService.MdiParent = Me
                _queryStatisticsPMService.WindowState = FormWindowState.Maximized
                _queryStatisticsPMService.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuWorkLogStatistics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuWorkLogStatistics.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryStatisticsWorkLog)) = True Then
                frmQueryStatisticsWorkLog.Activate()
            Else
                frmQueryStatisticsWorkLog = New FQueryStatisticsWorkLog
                frmQueryStatisticsWorkLog.MdiParent = Me
                frmQueryStatisticsWorkLog.WindowState = FormWindowState.Maximized
                frmQueryStatisticsWorkLog.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemModifyGuaranty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemModifyGuaranty.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmFindProjectInfo)) = True Then
                Me.frmFindProject_1.Activate()
            Else
                frmFindProject_1 = New frmFindProjectInfo
                frmFindProject_1.MdiParent = Me
                frmFindProject_1.WindowState = FormWindowState.Maximized
                frmFindProject_1.btnShowProjectInfo.Visible = False
                frmFindProject_1.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuHelpContext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpContext.Click
        Try
            Me.Cursor = Cursors.AppStarting

            System.Diagnostics.Process.Start("GMIS.chm")
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemRemeet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemRemeet.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FReMeeting)) = True Then
                Me.frmReMeeting.Activate()
            Else
                frmReMeeting = New FReMeeting
                AddHandler frmReMeeting.refreshTaskCommit, AddressOf Me.getTasklistAndMsg
                frmReMeeting.MdiParent = Me
                frmReMeeting.WindowState = FormWindowState.Maximized
                frmReMeeting.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemStatisticsFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemStatisticsFee.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FStatisticsFee)) = True Then
                Me.frmStatisticsFee.Activate()
            Else
                frmStatisticsFee = New FStatisticsFee
                frmStatisticsFee.MdiParent = Me
                frmStatisticsFee.WindowState = FormWindowState.Maximized
                frmStatisticsFee.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnItemGuaranteeLetterType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnItemGuaranteeLetterType.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FGuaranteeLetterType)) = True Then
                Me.frmGuaranteeLetterType.Activate()
            Else
                frmGuaranteeLetterType = New FGuaranteeLetterType
                frmGuaranteeLetterType.MdiParent = Me
                frmGuaranteeLetterType.WindowState = FormWindowState.Normal
                frmGuaranteeLetterType.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnItemReimburseType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnItemReimburseType.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FReimburseType)) = True Then
                Me.frmReimburseType.Activate()
            Else
                frmReimburseType = New FReimburseType
                frmReimburseType.MdiParent = Me
                frmReimburseType.WindowState = FormWindowState.Normal
                frmReimburseType.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemStatisticsRecommendproject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemStatisticsRecommendproject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FStatisticsRecommendProject)) = True Then
                Me.frmStatisticsRecommendProject.Activate()
            Else
                frmStatisticsRecommendProject = New FStatisticsRecommendProject
                frmStatisticsRecommendProject.MdiParent = Me
                frmStatisticsRecommendProject.WindowState = FormWindowState.Maximized
                frmStatisticsRecommendProject.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemStaticsFirstLoan.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmIsFirstLoanStat)) = True Then
                Me.frmIsFirstLoanStat_.Activate()
            Else
                frmIsFirstLoanStat_ = New frmIsFirstLoanStat
                frmIsFirstLoanStat_.MdiParent = Me
                frmIsFirstLoanStat_.WindowState = FormWindowState.Maximized
                frmIsFirstLoanStat_.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemQrySignaturePlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemQrySignaturePlan.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FSignatureQuery)) = True Then
                Me.frmSignatureQuery.Activate()
            Else
                frmSignatureQuery = New FSignatureQuery
                frmSignatureQuery.MdiParent = Me
                frmSignatureQuery.WindowState = FormWindowState.Normal
                frmSignatureQuery.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemUnSignProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemUnSignProject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryUnSignProject)) = True Then
                Me.frmQueryunSignProject.Activate()
            Else
                frmQueryunSignProject = New FQueryUnSignProject
                frmQueryunSignProject.MdiParent = Me
                frmQueryunSignProject.WindowState = FormWindowState.Maximized
                frmQueryunSignProject.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MnItemQueryGuaranteeForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemQueryGuaranteeForm.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryGuaranteeForm)) = True Then
                Me.frmQueryGuaranteeForm.Activate()
            Else
                frmQueryGuaranteeForm = New FQueryGuaranteeForm
                frmQueryGuaranteeForm.MdiParent = Me
                frmQueryGuaranteeForm.WindowState = FormWindowState.Maximized
                frmQueryGuaranteeForm.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '担保机构设置
    Private Sub MnItemOrganization_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MnItemOrganization.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FOrganization)) = True Then
                Me.fOrganization.Activate()
            Else
                fOrganization = New FOrganization
                fOrganization.MdiParent = Me
                fOrganization.WindowState = FormWindowState.Maximized
                fOrganization.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuToolsNotepad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolsNotepad.Click
        Try
            Me.Cursor = Cursors.AppStarting

            System.Diagnostics.Process.Start("notepad.exe")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuToolsCalculator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuToolsCalculator.Click
        Try
            Me.Cursor = Cursors.AppStarting

            System.Diagnostics.Process.Start("calc.exe")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuHelpSupport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpSupport.Click
        Try
            Me.Cursor = Cursors.AppStarting

            System.Diagnostics.Process.Start("http://www.HTF.com.cn")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuSystemLogin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSystemLogin.Click
        Me.Relogin()
    End Sub

    Private Sub mnuSystemExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuSystemExit.Click
        Me.Close()
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem32.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryProjectAppraise)) = True Then
                FQueryProjectAppraise.Activate()
            Else
                FQueryProjectAppraise = New FQueryProjectAppraise
                FQueryProjectAppraise.MdiParent = Me
                FQueryProjectAppraise.WindowState = FormWindowState.Maximized
                FQueryProjectAppraise.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuUpdateMeetRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUpdateMeetRecord.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FUpdateMeetRecord)) = True Then
                FUpdateMeetRecord.Activate()
            Else
                FUpdateMeetRecord = New FUpdateMeetRecord
                AddHandler FUpdateMeetRecord.refreshTaskCommit, AddressOf Me.getTasklistAndMsg
                FUpdateMeetRecord.MdiParent = Me
                FUpdateMeetRecord.WindowState = FormWindowState.Maximized
                FUpdateMeetRecord.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuChargeFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChargeFee.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FChargeFeeTool)) = True Then
                FChargeFeeTool.Activate()
            Else
                FChargeFeeTool = New FChargeFeeTool
                AddHandler FChargeFeeTool.refreshTaskCommit, AddressOf Me.getTasklistAndMsg
                FChargeFeeTool.MdiParent = Me
                FChargeFeeTool.WindowState = FormWindowState.Maximized
                FChargeFeeTool.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuGuaranteeProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGuaranteeProject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryGetGuaranteeProject)) = True Then
                FQueryGuaranteeProject.Activate()
            Else
                FQueryGuaranteeProject = New FQueryGetGuaranteeProject
                FQueryGuaranteeProject.MdiParent = Me
                FQueryGuaranteeProject.WindowState = FormWindowState.Maximized
                FQueryGuaranteeProject.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuUnDealProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuUnDealProject.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryUnDealProject)) = True Then
                FQueryUnDealProject.Activate()
            Else
                FQueryUnDealProject = New FQueryUnDealProject
                FQueryUnDealProject.MdiParent = Me
                FQueryUnDealProject.WindowState = FormWindowState.Maximized
                FQueryUnDealProject.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuAfterGuaranteeRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAfterGuaranteeRecord.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryAfterGuaranteeRecord)) = True Then
                FQueryAfterGuaranteeRecord.Activate()
            Else
                FQueryAfterGuaranteeRecord = New FQueryAfterGuaranteeRecord
                FQueryAfterGuaranteeRecord.MdiParent = Me
                FQueryAfterGuaranteeRecord.WindowState = FormWindowState.Maximized
                FQueryAfterGuaranteeRecord.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuItemClaim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemClaim.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FClaimTool)) = True Then
                FClaimTool.Activate()
            Else
                FClaimTool = New FClaimTool
                FClaimTool.MdiParent = Me
                FClaimTool.WindowState = FormWindowState.Maximized
                FClaimTool.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub mnuItemProjectRequite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemProjectRequite.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryProjectRequite)) = True Then
                FQueryProjectRequite.Activate()
            Else
                FQueryProjectRequite = New FQueryProjectRequite
                FQueryProjectRequite.MdiParent = Me
                FQueryProjectRequite.WindowState = FormWindowState.Maximized
                FQueryProjectRequite.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuItemIntentLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemIntentLetter.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryIntentLetter)) = True Then
                FQueryIntentLetter.Activate()
            Else
                FQueryIntentLetter = New FQueryIntentLetter
                FQueryIntentLetter.MdiParent = Me
                FQueryIntentLetter.WindowState = FormWindowState.Maximized
                FQueryIntentLetter.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuFinancialAnalysis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFinancialAnalysis.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FFinancialAnalysis)) = True Then
                _financialAnalysisForm.Activate()
            Else
                _financialAnalysisForm = New FFinancialAnalysis
                _financialAnalysisForm.MdiParent = Me
                _financialAnalysisForm.WindowState = FormWindowState.Maximized
                _financialAnalysisForm.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuItemUpdateGuarantee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemUpdateGuarantee.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FUpdateGuarantee)) = True Then
                FUpdateGuarantee.Activate()
            Else
                FUpdateGuarantee = New FUpdateGuarantee
                AddHandler FUpdateGuarantee.refreshTaskCommit, AddressOf Me.getTasklistAndMsg
                FUpdateGuarantee.MdiParent = Me
                FUpdateGuarantee.WindowState = FormWindowState.Maximized
                FUpdateGuarantee.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuItemEvaluate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemEvaluate.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryOppEvaluate)) = True Then
                FQueryOppEvaluate.Activate()
            Else
                FQueryOppEvaluate = New FQueryOppEvaluate
                FQueryOppEvaluate.MdiParent = Me
                FQueryOppEvaluate.WindowState = FormWindowState.Maximized
                FQueryOppEvaluate.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub mnuItemFirReviewCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemFirReviewCancel.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FFirstReviewCancel)) = True Then
                FFirstReviewCancel.Activate()
            Else
                FFirstReviewCancel = New FFirstReviewCancel
                AddHandler FFirstReviewCancel.refreshTaskCommit, AddressOf Me.getTasklistAndMsg
                FFirstReviewCancel.MdiParent = Me
                FFirstReviewCancel.WindowState = FormWindowState.Maximized
                FFirstReviewCancel.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Dim fWaitProcess As FWaitingProcess ' = New FWaitingProcess("[业务流程同步] 正在进行中，请等候！")

    Private Sub mneItemUpdateProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mneItemUpdateProcess.Click
        '''Dim thread As System.Threading.Thread
        '''Try
        '''    Me.Cursor = Cursors.AppStarting

        '''    fWaitProcess = New FWaitingProcess("[业务流程同步] 正在进行中，请等候！")

        '''    Dim strMsg As String
        '''    strMsg = "[业务流程同步] 需要花费较多时间,您确认执行吗？"
        '''    If MsgBox(strMsg, MsgBoxStyle.Information + MsgBoxStyle.OKCancel, "业务流程同步") = MsgBoxResult.OK Then
        '''        Dim strResult As String

        '''        thread = New System.Threading.Thread(AddressOf ShowInformationBox)
        '''        thread.Start()

        '''        strResult = gWs.updateProcessEx()

        '''        If strResult = "1" Then
        '''            fWaitProcess.setBtnSucced(True)
        '''            fWaitProcess.setLabText("恭喜您 [业务流程同步] 成功！")
        '''            'MsgBox("[业务流程同步] 成功！", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "业务流程同步")
        '''        Else
        '''            fWaitProcess.setBtnSucced(True)
        '''            fWaitProcess.setLabText("非常抱歉 [业务流程同步] 失败！ " & strResult.ToString)
        '''            'MsgBox("[业务流程同步] 失败！", MsgBoxStyle.Exclamation + MsgBoxStyle.OKOnly, "业务流程同步")
        '''        End If
        '''    End If
        '''Catch ex As Exception
        '''    SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        '''    Try
        '''        thread.Abort()
        '''    Catch thex As Threading.ThreadAbortException
        '''    End Try
        '''    fWaitProcess.Close()
        '''    GC.Collect()
        '''Finally
        '''    Me.Cursor = Cursors.Default
        '''End Try
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FUpdateProcess)) = True Then
                FUpdateProcess.Activate()
            Else
                FUpdateProcess = New FUpdateProcess
                AddHandler FUpdateProcess.refreshTaskCommit, AddressOf Me.getTasklistAndMsg
                FUpdateProcess.MdiParent = Me
                FUpdateProcess.WindowState = FormWindowState.Maximized
                FUpdateProcess.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub ShowInformationBox()
        fWaitProcess.setLabText("[业务流程同步] 正在进行中，请等候！")
        fWaitProcess.Owner = Me
        fWaitProcess.ShowDialog()
    End Sub
    '员工岗位设置
    Private Sub mitemPostConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitemPostConfig.Click
        Try
            Me.Cursor = Cursors.AppStarting

            Dim fUserPost As FUserPost = New FUserPost
            fUserPost.MdiParent = Me
            fUserPost.WindowState = FormWindowState.Maximized
            fUserPost.Show()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '岗位职责设置
    Private Sub mitemJobRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitemJobRes.Click
        Try
            Me.Cursor = Cursors.AppStarting

            Dim fPost As FPostConfigure = New FPostConfigure
            fPost.MdiParent = Me
            fPost.WindowState = FormWindowState.Maximized
            fPost.Show()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '工作职责设置
    Private Sub mitemJobTask_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitemJobTask.Click
        Try
            Me.Cursor = Cursors.AppStarting

            Dim fJobRes As FWorkLogConfigure = New FWorkLogConfigure
            fJobRes.MdiParent = Me
            fJobRes.WindowState = FormWindowState.Maximized
            fJobRes.Show()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub mitemWorkTime_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitemWorkTime.Click
        Try
            Me.Cursor = Cursors.AppStarting

            Dim fWorkTime As FWorkPeriod = New FWorkPeriod
            fWorkTime.MdiParent = Me
            fWorkTime.Show()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub muitemWorkingHour_Click(ByVal sender As Object, ByVal e As EventArgs) Handles muitemWorkingHour.Click
        Try
            Me.Cursor = Cursors.AppStarting

            Dim frmWorkingHour As FStatisticsWorkingHours = New FStatisticsWorkingHours
            frmWorkingHour.MdiParent = Me
            frmWorkingHour.Show()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub muiQueryGuarantingCorporation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muiQueryGuarantingCorporation.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryGuarantingCorporation)) = True Then
                oFQueryGuarantingCorporation.Activate()
            Else
                oFQueryGuarantingCorporation = New FQueryGuarantingCorporation
                oFQueryGuarantingCorporation.MdiParent = Me
                oFQueryGuarantingCorporation.WindowState = FormWindowState.Maximized
                oFQueryGuarantingCorporation.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub muiConferenceRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muiConferenceRoom.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FConferenceRoom)) = True Then
                Me.oFConferenceRoom.Activate()
            Else
                oFConferenceRoom = New FConferenceRoom
                oFConferenceRoom.MdiParent = Me
                oFConferenceRoom.WindowState = FormWindowState.Maximized
                oFConferenceRoom.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub muiUpdateIntentLetter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muiUpdateIntentLetter.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FUpdateIntentLetter)) = True Then
                oFUpdateIntentLetter.Activate()
            Else
                oFUpdateIntentLetter = New FUpdateIntentLetter
                AddHandler oFUpdateIntentLetter.refreshTaskCommit, AddressOf Me.getTasklistAndMsg
                oFUpdateIntentLetter.MdiParent = Me
                oFUpdateIntentLetter.WindowState = FormWindowState.Maximized
                oFUpdateIntentLetter.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub muChargeManner_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles muChargeManner.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FLoanChargeManner)) = True Then
                Me.frmLoanChargeManner.Activate()
            Else
                frmLoanChargeManner = New FLoanChargeManner
                frmLoanChargeManner.MdiParent = Me
                frmLoanChargeManner.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuDefectRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDefectRecord.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmQueryDefectRecord)) = True Then
                Me.frmQueryDefectRecord.Activate()
            Else
                frmQueryDefectRecord = New frmQueryDefectRecord
                frmQueryDefectRecord.MdiParent = Me
                frmQueryDefectRecord.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuDefectRecordEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDefectRecordEdit.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmDefectRecord)) = True Then
                Me.frmDefectRecord.Activate()
            Else
                frmDefectRecord = New frmDefectRecord
                frmDefectRecord.MdiParent = Me
                frmDefectRecord.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuDefectRecordAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuDefectRecordAdd.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmDefectRecordAdd)) = True Then
                Me.frmDefectRecordAdd.Activate()
            Else
                frmDefectRecordAdd = New frmDefectRecordAdd
                frmDefectRecordAdd.MdiParent = Me
                frmDefectRecordAdd.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuReviewGuarantee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuReviewGuarantee.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FReviewGuarantee)) = True Then
                Me.FReviewGuarantee.Activate()
            Else
                FReviewGuarantee = New FReviewGuarantee
                FReviewGuarantee.MdiParent = Me
                FReviewGuarantee.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuContractManage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuContractManage.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FContract)) = True Then
                Me.FContract.Activate()
            Else
                FContract = New FContract
                FContract.MdiParent = Me
                FContract.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub MenuProjectExp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuProjectExp.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FProjectExpandDate)) = True Then
                Me.FProjectExpandDate.Activate()
            Else
                FProjectExpandDate = New FProjectExpandDate
                AddHandler FProjectExpandDate.refreshTaskCommit, AddressOf Me.getTasklistAndMsg
                FProjectExpandDate.MdiParent = Me
                FProjectExpandDate.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuQueryProjectExpandDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuQueryProjectExpandDate.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FQueryProjectExpandDate)) = True Then
                Me.FQueryProjectExpandDate.Activate()
            Else
                FQueryProjectExpandDate = New FQueryProjectExpandDate
                FQueryProjectExpandDate.MdiParent = Me
                FQueryProjectExpandDate.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmMainInterface_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed

    End Sub

    Private Sub mnuMessagesSender_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMessagesSender.Click
        Try
            Me.Cursor = Cursors.AppStarting

            _messageSender = New FMessageSender

            _messageSender.Owner = Me
            _messageSender.ShowDialog()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Private Sub SetSkin(ByVal Path As String)
    '    SkinEngine1.Active = False
    '    SkinEngine1.SkinFile = Path
    '    If Not SkinEngine1.Active Then
    '        SkinEngine1.Active = True
    '    End If
    'End Sub

    'Private _strSkinPath As String

    'Private Sub MenuItem12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem12.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "Carlmness\" + "Calmness.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    'Private Sub MenuItem21_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem21.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "Deep\" + "DeepCyan.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    'Private Sub MenuItem37_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem37.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "Diamond\" + "DiamondGreen.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub


    'Private Sub MenuItem38_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem38.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "Eighteen\" + "Eighteen.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    'Private Sub MenuItem39_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem39.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "Emerald\" + "Emerald.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    'Private Sub MenuItem40_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem40.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "Glass\" + "GlassBrown.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    'Private Sub MenuItem41_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem41.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "Longhorn\" + "Longhorn.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    'Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem43.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "MacOS\" + "MacOS.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    'Private Sub MenuItem45_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem45.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "Midsummer\" + "Midsummer.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    'Private Sub MenuItem48_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem48.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "mp10\" + "mp10.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    'Private Sub MenuItem65_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem65.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "MSN\" + "MSN.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    'Private Sub MenuItem66_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem66.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "Office2007\" + "Office2007.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    'Private Sub MenuItem68_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem68.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "One\" + "One.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    'Private Sub MenuItem70_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem70.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "Page\" + "PageColor2.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    'Private Sub MenuItem72_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem72.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "RealOne\" + "RealOne.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    'Private Sub MenuItem73_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem73.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "Silver\" + "Silver.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    'Private Sub MenuItem74_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem74.Click
    '    _strSkinPath = System.Environment.CurrentDirectory + "\Skins\" + "Sports\" + "Sports.ssk"
    '    SetSkin(_strSkinPath)
    'End Sub

    Private Sub mnuReturnFee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuBackFee.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FChargeBackFeeTool)) = True Then
                FChargeBackFeeTool.Activate()
            Else
                FChargeBackFeeTool = New FChargeBackFeeTool
                AddHandler FChargeBackFeeTool.refreshTaskCommit, AddressOf Me.getTasklistAndMsg
                FChargeBackFeeTool.MdiParent = Me
                FChargeBackFeeTool.WindowState = FormWindowState.Maximized
                FChargeBackFeeTool.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem81_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem81.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.FrmOverseeFinanceInfo)) = True Then
                FChargeBackFeeTool.Activate()
            Else
                FrmOverseeFinanceInfo = New FrmOverseeFinanceInfo

                FrmOverseeFinanceInfo.MdiParent = Me
                FrmOverseeFinanceInfo.WindowState = FormWindowState.Maximized
                FrmOverseeFinanceInfo.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub MenuItem82_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem82.Click
        Try
            Me.Cursor = Cursors.AppStarting

            If hasCreated(GetType(MainInterface.frmOversee)) = True Then
                frmOversee.Activate()
            Else
                frmOversee = New frmOversee

                frmOversee.MdiParent = Me
                frmOversee.WindowState = FormWindowState.Maximized
                frmOversee.Show()
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class
