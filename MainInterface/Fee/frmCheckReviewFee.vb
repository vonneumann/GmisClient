Public Class frmCheckReviewFee
    Inherits frmBasic
    Private Const passText As String = "通过"
    Private ProjectCode, TaskID, WorkFlowID As String
    Private dsAccount As DataSet
    Private bmAccount As BindingManagerBase
    Private Const MaxFee As Double = 100000000
    Private dsServiceType As DataSet


#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsAccount Is Nothing Then
            dsAccount.Dispose()
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
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReviewFee As System.Windows.Forms.TextBox
    Protected WithEvents txtCorName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents txtLoanForm As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEachReturnFee As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtRefundType As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtStandard As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtServiceType As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtConclusion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtConclusionReviewFee As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ckxPartnerAffirm As System.Windows.Forms.CheckBox
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents gpxBaoHan As System.Windows.Forms.GroupBox
    Friend WithEvents gpxApplyInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtApplyResuiseType As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtApplyBaoHanType As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtApplySubBank As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtApplyBank As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtApplyTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtApplySum As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents grdLetterUsage As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCheckReviewFee))
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReviewFee = New System.Windows.Forms.TextBox()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.gpxMeeting = New System.Windows.Forms.GroupBox()
        Me.ckxPartnerAffirm = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtLoanForm = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEachReturnFee = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtRefundType = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtStandard = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSum = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtServiceType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtConclusion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConclusionReviewFee = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.gpxBaoHan = New System.Windows.Forms.GroupBox()
        Me.gpxApplyInfo = New System.Windows.Forms.GroupBox()
        Me.txtApplyResuiseType = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtApplyBaoHanType = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtApplySubBank = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtApplyBank = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txtApplyTerm = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtApplySum = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.grdLetterUsage = New System.Windows.Forms.DataGrid()
        Me.gpxMeeting.SuspendLayout()
        Me.gpxBaoHan.SuspendLayout()
        Me.gpxApplyInfo.SuspendLayout()
        CType(Me.grdLetterUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(391, 416)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(307, 416)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 2
        Me.btnCommit.Text = "提交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 419)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "应收费用(元)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReviewFee
        '
        Me.txtReviewFee.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.txtReviewFee.Location = New System.Drawing.Point(96, 416)
        Me.txtReviewFee.Name = "txtReviewFee"
        Me.txtReviewFee.Size = New System.Drawing.Size(88, 21)
        Me.txtReviewFee.TabIndex = 0
        Me.txtReviewFee.Text = ""
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(224, 8)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(240, 21)
        Me.txtCorName.TabIndex = 41
        Me.txtCorName.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "企业名称"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "项目编码"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(64, 8)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(80, 21)
        Me.txtProjectCode.TabIndex = 40
        Me.txtProjectCode.Text = ""
        '
        'gpxMeeting
        '
        Me.gpxMeeting.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.gpxMeeting.Controls.AddRange(New System.Windows.Forms.Control() {Me.ckxPartnerAffirm, Me.Label9, Me.txtLoanForm, Me.Label13, Me.txtEachReturnFee, Me.Label12, Me.txtRefundType, Me.Label11, Me.txtTerm, Me.Label10, Me.txtStandard, Me.Label8, Me.txtSum, Me.Label7, Me.txtServiceType, Me.Label4, Me.txtConclusion, Me.Label3, Me.txtConclusionReviewFee, Me.Label2})
        Me.gpxMeeting.Location = New System.Drawing.Point(8, 264)
        Me.gpxMeeting.Name = "gpxMeeting"
        Me.gpxMeeting.Size = New System.Drawing.Size(464, 144)
        Me.gpxMeeting.TabIndex = 42
        Me.gpxMeeting.TabStop = False
        Me.gpxMeeting.Text = "评审会意见"
        '
        'ckxPartnerAffirm
        '
        Me.ckxPartnerAffirm.BackColor = System.Drawing.Color.Gainsboro
        Me.ckxPartnerAffirm.Enabled = False
        Me.ckxPartnerAffirm.ForeColor = System.Drawing.Color.Gainsboro
        Me.ckxPartnerAffirm.Location = New System.Drawing.Point(296, 113)
        Me.ckxPartnerAffirm.Name = "ckxPartnerAffirm"
        Me.ckxPartnerAffirm.Size = New System.Drawing.Size(15, 18)
        Me.ckxPartnerAffirm.TabIndex = 59
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(208, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 14)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "互   助   会"
        '
        'txtLoanForm
        '
        Me.txtLoanForm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanForm.Location = New System.Drawing.Point(296, 40)
        Me.txtLoanForm.Name = "txtLoanForm"
        Me.txtLoanForm.ReadOnly = True
        Me.txtLoanForm.Size = New System.Drawing.Size(160, 21)
        Me.txtLoanForm.TabIndex = 57
        Me.txtLoanForm.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(208, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(79, 14)
        Me.Label13.TabIndex = 56
        Me.Label13.Text = "放  款 方 式"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEachReturnFee
        '
        Me.txtEachReturnFee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEachReturnFee.Location = New System.Drawing.Point(296, 88)
        Me.txtEachReturnFee.Name = "txtEachReturnFee"
        Me.txtEachReturnFee.ReadOnly = True
        Me.txtEachReturnFee.Size = New System.Drawing.Size(160, 21)
        Me.txtEachReturnFee.TabIndex = 55
        Me.txtEachReturnFee.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(208, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 14)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "每次还款额(元)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRefundType
        '
        Me.txtRefundType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRefundType.Location = New System.Drawing.Point(104, 88)
        Me.txtRefundType.Name = "txtRefundType"
        Me.txtRefundType.ReadOnly = True
        Me.txtRefundType.Size = New System.Drawing.Size(96, 21)
        Me.txtRefundType.TabIndex = 18
        Me.txtRefundType.Text = ""
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 90)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 14)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "还  款 方 式"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTerm
        '
        Me.txtTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerm.Location = New System.Drawing.Point(296, 64)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.ReadOnly = True
        Me.txtTerm.Size = New System.Drawing.Size(160, 21)
        Me.txtTerm.TabIndex = 16
        Me.txtTerm.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(208, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 14)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "担保期限 (月)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStandard
        '
        Me.txtStandard.BackColor = System.Drawing.Color.Gainsboro
        Me.txtStandard.Location = New System.Drawing.Point(104, 112)
        Me.txtStandard.Name = "txtStandard"
        Me.txtStandard.ReadOnly = True
        Me.txtStandard.Size = New System.Drawing.Size(96, 21)
        Me.txtStandard.TabIndex = 13
        Me.txtStandard.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 114)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 14)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "收 取 标 准(%)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSum
        '
        Me.txtSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSum.Location = New System.Drawing.Point(104, 40)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.ReadOnly = True
        Me.txtSum.Size = New System.Drawing.Size(96, 21)
        Me.txtSum.TabIndex = 11
        Me.txtSum.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 42)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 14)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "担保金额(万元)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtServiceType
        '
        Me.txtServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtServiceType.Location = New System.Drawing.Point(296, 16)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(160, 21)
        Me.txtServiceType.TabIndex = 9
        Me.txtServiceType.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "业  务 品 种"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtConclusion
        '
        Me.txtConclusion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConclusion.Location = New System.Drawing.Point(104, 16)
        Me.txtConclusion.Name = "txtConclusion"
        Me.txtConclusion.ReadOnly = True
        Me.txtConclusion.Size = New System.Drawing.Size(96, 21)
        Me.txtConclusion.TabIndex = 7
        Me.txtConclusion.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "会  议 结 论"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtConclusionReviewFee
        '
        Me.txtConclusionReviewFee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConclusionReviewFee.Location = New System.Drawing.Point(104, 64)
        Me.txtConclusionReviewFee.Name = "txtConclusionReviewFee"
        Me.txtConclusionReviewFee.ReadOnly = True
        Me.txtConclusionReviewFee.Size = New System.Drawing.Size(96, 21)
        Me.txtConclusionReviewFee.TabIndex = 5
        Me.txtConclusionReviewFee.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "应收评审费(元)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnRecord
        '
        Me.btnRecord.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnRecord.Image = CType(resources.GetObject("btnRecord.Image"), System.Drawing.Bitmap)
        Me.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecord.ImageIndex = 11
        Me.btnRecord.ImageList = Me.ImageListBasic
        Me.btnRecord.Location = New System.Drawing.Point(192, 416)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(108, 23)
        Me.btnRecord.TabIndex = 1
        Me.btnRecord.Text = "评审会结论(&M)"
        Me.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpxBaoHan
        '
        Me.gpxBaoHan.Controls.AddRange(New System.Windows.Forms.Control() {Me.gpxApplyInfo, Me.grdLetterUsage})
        Me.gpxBaoHan.Location = New System.Drawing.Point(8, 32)
        Me.gpxBaoHan.Name = "gpxBaoHan"
        Me.gpxBaoHan.Size = New System.Drawing.Size(464, 224)
        Me.gpxBaoHan.TabIndex = 43
        Me.gpxBaoHan.TabStop = False
        Me.gpxBaoHan.Text = "保函协议信息"
        Me.gpxBaoHan.Visible = False
        '
        'gpxApplyInfo
        '
        Me.gpxApplyInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtApplyResuiseType, Me.Label26, Me.txtApplyBaoHanType, Me.Label25, Me.txtApplySubBank, Me.Label24, Me.txtApplyBank, Me.Label23, Me.txtApplyTerm, Me.Label22, Me.txtApplySum, Me.Label18})
        Me.gpxApplyInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gpxApplyInfo.Location = New System.Drawing.Point(3, 125)
        Me.gpxApplyInfo.Name = "gpxApplyInfo"
        Me.gpxApplyInfo.Size = New System.Drawing.Size(458, 96)
        Me.gpxApplyInfo.TabIndex = 19
        Me.gpxApplyInfo.TabStop = False
        Me.gpxApplyInfo.Text = "申请信息"
        '
        'txtApplyResuiseType
        '
        Me.txtApplyResuiseType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyResuiseType.Location = New System.Drawing.Point(304, 72)
        Me.txtApplyResuiseType.Name = "txtApplyResuiseType"
        Me.txtApplyResuiseType.ReadOnly = True
        Me.txtApplyResuiseType.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyResuiseType.TabIndex = 11
        Me.txtApplyResuiseType.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(216, 75)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 14)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "责任偿付类型"
        '
        'txtApplyBaoHanType
        '
        Me.txtApplyBaoHanType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyBaoHanType.Location = New System.Drawing.Point(80, 72)
        Me.txtApplyBaoHanType.Name = "txtApplyBaoHanType"
        Me.txtApplyBaoHanType.ReadOnly = True
        Me.txtApplyBaoHanType.Size = New System.Drawing.Size(120, 21)
        Me.txtApplyBaoHanType.TabIndex = 9
        Me.txtApplyBaoHanType.Text = ""
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 75)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 14)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "保函种类"
        '
        'txtApplySubBank
        '
        Me.txtApplySubBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplySubBank.Location = New System.Drawing.Point(304, 44)
        Me.txtApplySubBank.Name = "txtApplySubBank"
        Me.txtApplySubBank.ReadOnly = True
        Me.txtApplySubBank.Size = New System.Drawing.Size(144, 21)
        Me.txtApplySubBank.TabIndex = 7
        Me.txtApplySubBank.Text = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(216, 47)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(79, 14)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "支        行"
        '
        'txtApplyBank
        '
        Me.txtApplyBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyBank.Location = New System.Drawing.Point(80, 44)
        Me.txtApplyBank.Name = "txtApplyBank"
        Me.txtApplyBank.ReadOnly = True
        Me.txtApplyBank.Size = New System.Drawing.Size(120, 21)
        Me.txtApplyBank.TabIndex = 5
        Me.txtApplyBank.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 47)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(54, 14)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "银    行"
        '
        'txtApplyTerm
        '
        Me.txtApplyTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyTerm.Location = New System.Drawing.Point(304, 16)
        Me.txtApplyTerm.Name = "txtApplyTerm"
        Me.txtApplyTerm.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyTerm.TabIndex = 3
        Me.txtApplyTerm.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(216, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(85, 14)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "期     限(月)"
        '
        'txtApplySum
        '
        Me.txtApplySum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplySum.Location = New System.Drawing.Point(80, 16)
        Me.txtApplySum.Name = "txtApplySum"
        Me.txtApplySum.ReadOnly = True
        Me.txtApplySum.Size = New System.Drawing.Size(120, 21)
        Me.txtApplySum.TabIndex = 1
        Me.txtApplySum.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 14)
        Me.Label18.TabIndex = 0
        Me.Label18.Text = "额度(万元)"
        '
        'grdLetterUsage
        '
        Me.grdLetterUsage.CaptionVisible = False
        Me.grdLetterUsage.DataMember = ""
        Me.grdLetterUsage.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdLetterUsage.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdLetterUsage.Location = New System.Drawing.Point(3, 17)
        Me.grdLetterUsage.Name = "grdLetterUsage"
        Me.grdLetterUsage.ReadOnly = True
        Me.grdLetterUsage.Size = New System.Drawing.Size(458, 103)
        Me.grdLetterUsage.TabIndex = 16
        '
        'frmCheckReviewFee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(482, 447)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.gpxBaoHan, Me.Label5, Me.Label6, Me.btnExit, Me.Label1, Me.btnRecord, Me.gpxMeeting, Me.txtCorName, Me.txtProjectCode, Me.txtReviewFee, Me.btnCommit})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmCheckReviewFee"
        Me.Text = "审核应收评审费"
        Me.gpxMeeting.ResumeLayout(False)
        Me.gpxBaoHan.ResumeLayout(False)
        Me.gpxApplyInfo.ResumeLayout(False)
        CType(Me.grdLetterUsage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    '或取项目保函协议信息
    Private Sub ShowBaoHanInfo(ByVal dr As DataRow)
        gpxBaoHan.Visible = True
        If Not dr Is Nothing Then 'dr为项目上会的记录，有些项目不需要上会，例如额度向下
            'If Not IsDBNull(dr("guarantee_letter_type")) Then '保函种类
            '    Dim dsTemp As DataSet = gWs.GetGuaranteeLetterType(dr("guarantee_letter_type").ToString)
            '    txtBaoHanType.Text = dsTemp.Tables(0).Rows(0)("name")
            '    dsTemp = Nothing
            'End If
            'If Not IsDBNull(dr("reimburse_type")) Then '偿还责任类型
            '    Dim dstemp As DataSet = gWs.GetReimburseType(dr("reimburse_type").ToString)
            '    txtRebetType.Text = dsTemp.Tables(0).Rows(0)("name")
            '    dstemp = Nothing
            'End If
            ''出函银行
            'Dim dsBank As DataSet = gWs.GetBankInfo("%", "%")
            'If Not IsDBNull(dr("bank")) Then
            '    txtSigBank.Text = dsBank.Tables("bank").Select("bank_code='" & dr("bank").ToString & "'")(0)("bank_name").ToString
            '    '出函支行
            '    If Not IsDBNull(dr("bank_branch")) Then
            '        txtSigSubBank.Text = dsBank.Tables("bank_branch").Select("bank_code='" & dr("bank").ToString & "' AND branch_bank_code='" & dr("bank_branch").ToString & "'")(0)("branch_bank_name").ToString
            '    End If
            'End If
            'dsBank.Dispose()

            ''保证金比例
            'txtSecurityScale.Text = dr("security_rate") & ""
            ''剩余额度，额度到期日
            'Dim CorCode As String = ProjectCode.Substring(0, 5)
            'Dim dsLetter As DataSet = gWs.GetCommonQueryInfo("SELECT * FROM dbo.Guarantee_letter_EX WHERE corporation_code='" & CorCode & "'")
            'If dsLetter.Tables(0).Rows.Count > 0 Then
            '    Dim odr As DataRow = dsLetter.Tables(0).Rows(0)
            '    txtRemailSum.Text = odr("remnant_line") & ""
            '    If Not IsDBNull(odr("enddate")) Then
            '        txtEndDate.Text = String.Format("{0,11:yyyy年M月d日}", odr("enddate"))
            '    End If
            'End If
            'dsLetter.Dispose()
        End If
        '获取保函协议信息
        Dim dsLetterType As DataSet = gWs.GetGuaranteeLetterType("%")
        Dim dsReimBurse As DataSet = gWs.GetReimburseType("%")
        Dim dsLetterUsage As DataSet = gWs.GetGuaranteeLetterUsage("{SUBSTRING(project_code,1,5)='" & ProjectCode.Substring(0, 5) & "'}")
        dsLetterUsage.Tables("TGuaranteeLetterUsage").Columns.Add("LetterTypeName", GetType(String))
        dsLetterUsage.Tables("TGuaranteeLetterUsage").Columns.Add("ReimburseName", GetType(String))
        Dim qdr As DataRow
        For Each qdr In dsLetterUsage.Tables("TGuaranteeLetterUsage").Rows
            qdr("LetterTypeName") = dsLetterType.Tables(0).Select("type_code='" & qdr("guarantee_letter_type").ToString & "'")(0)("name")
            qdr("ReimburseName") = dsReimBurse.Tables(0).Select("type_code='" & qdr("reimburse_type").ToString & "'")(0)("name")
        Next
        grdLetterUsage.SetDataBinding(dsLetterUsage, "TGuaranteeLetterUsage")
        dsLetterType.Dispose()
        dsReimBurse.Dispose()
        If dr Is Nothing Then
            GetApplyInfo()
        End If
    End Sub

    '获取项目申请信息
    Private Sub GetApplyInfo()
        Dim strSql As String = "SELECT project_code,apply_sum,apply_term,G.name AS ApplyBanHanName,R.name AS ReimName,B.bank_name AS ApplaBankName, SB.branch_bank_name AS ApplySubBankName" & _
                               " FROM project AS P" & _
                               " LEFT JOIN guarantee_letter_type AS G ON P.guarantee_letter_type=G.type_code" & _
                               " LEFT JOIN reimburse_type AS R ON P.reimburse_type=R.type_code" & _
                               " LEFT JOIN bank AS B ON P.apply_bank=B.bank_code" & _
                               " LEFT JOIN bank_branch AS SB ON SB.bank_code=P.apply_bank AND SB.branch_bank_code=P.apply_branch_bank" & _
                               " WHERE P.project_code='" & ProjectCode & "'"
        Dim dsApplyInfo As DataSet = gWs.GetCommonQueryInfo(strSql)
        If dsApplyInfo.Tables.Count > 0 Then
            Dim tableName As String = dsApplyInfo.Tables(0).TableName
            txtApplyBank.DataBindings.Add("Text", dsApplyInfo, tableName & ".ApplaBankName")
            txtApplyBaoHanType.DataBindings.Add("Text", dsApplyInfo, tableName & ".ApplyBanHanName")
            txtApplyResuiseType.DataBindings.Add("Text", dsApplyInfo, tableName & ".ReimName")
            txtApplySubBank.DataBindings.Add("Text", dsApplyInfo, tableName & ".ApplySubBankName")
            txtApplySum.DataBindings.Add("Text", dsApplyInfo, tableName & ".apply_sum")
            txtApplyTerm.DataBindings.Add("Text", dsApplyInfo, tableName & ".apply_term")
        End If
    End Sub

    '确认收取评审费
    Private Sub frm_load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            ProjectCode = MyBase.getProjectCode
            TaskID = MyBase.getTaskID
            WorkFlowID = MyBase.getWorkFlowID
            txtProjectCode.Text = ProjectCode : txtCorName.Text = MyBase.getCorporationName

            dsAccount = gWs.GetProjectAccountDetailInfo("{project_code LIKE '" & ProjectCode & "' AND item_type='31' AND item_code='001' AND NOT payout IS NULL ORDER BY serial_num}") 'AND phase LIKE '%评审%'   DESC
            bmAccount = BindingContext(dsAccount, "project_account_detail")
            'txtReviewFee.DataBindings.Add("Text", dsAccount, "project_account_detail.payout")
            'If bmAccount.Count > 0 Then
            '    bmAccount.Position = 0
            'End If

            Dim dsTrial As DataSet = gWs.GetConfTrialInfo("{project_code LIKE '" & ProjectCode & "' ORDER BY trial_times DESC}", "null") 'AND trial_conclusion LIKE '%" & passText & "%' 
            txtConclusion.DataBindings.Add("Text", dsTrial, "conference_trial.trial_conclusion")
            txtSum.DataBindings.Add("Text", dsTrial, "conference_trial.guarantee_sum")
            txtServiceType.DataBindings.Add("Text", dsTrial, "conference_trial.service_type")
            txtStandard.DataBindings.Add("Text", dsTrial, "conference_trial.trial_rate")
            txtLoanForm.DataBindings.Add("Text", dsTrial, "conference_trial.loan_provide_form")
            txtTerm.DataBindings.Add("Text", dsTrial, "conference_trial.terms")
            txtRefundType.DataBindings.Add("Text", dsTrial, "conference_trial.refund_type")
            txtEachReturnFee.DataBindings.Add("Text", dsTrial, "conference_trial.refund_sum_average")

            Dim dsServiceType As DataSet = gWs.GetServiceType("{service_type='" & txtServiceType.Text & "'}")
            Dim lowest As Double = 0
            If dsServiceType.Tables(0).Rows.Count > 0 Then
                lowest = CDbl(dsServiceType.Tables(0).Rows(0)("lowest_review_sum") + "0") '最低收取评审费
            End If

            Dim calculate As Double = 0 '会议结论里根据评审费率计算的评审费
            If txtSum.Text <> String.Empty AndAlso txtStandard.Text <> String.Empty Then
                Dim dr As DataRow
                For Each dr In dsAccount.Tables(0).Rows
                    calculate += CDbl(dr("payout"))
                Next
                'calculate = CDbl(txtSum.Text) * 100 * CDbl(txtStandard.Text)
            End If
            txtConclusionReviewFee.Text = Math.Max(calculate, lowest).ToString("n")
            dsServiceType.Dispose()

            txtReviewFee.Text = txtConclusionReviewFee.Text
            AddHandler txtReviewFee.Enter, AddressOf Money.Money_Enter
            AddHandler txtReviewFee.KeyPress, AddressOf Money.Money_KeyPress

            Dim strWorkFlow As String
            '如果业务评种是保函非综合授信
            If txtServiceType.Text <> String.Empty Then
                strWorkFlow = dsTrial.Tables("conference_trial").Rows(0)("workflow") & ""
                If GetServicetypeCode(txtServiceType.Text) <> "08" AndAlso GetServicetypeCode(txtServiceType.Text) = "06" Then   '非保函综合授信的保函业务品种，如果是额度项下保函
                    'txtRunMode.Text = strWorkFlow
                    ShowBaoHanInfo(dsTrial.Tables("conference_trial").Rows(0))
                End If
                '有开过会议则不需要显示申请信息
                gpxApplyInfo.Visible = False
                gpxBaoHan.Height -= gpxApplyInfo.Height
                Me.Height -= gpxApplyInfo.Height
            Else '该项目没有上过会，有可能是保函品种，因此去project查看运作方式
                Dim dsProject As DataSet = gWs.GetProjectInfo("{project_code='" & ProjectCode & "'}")
                If dsProject.Tables(0).Rows.Count > 0 Then
                    strWorkFlow = dsProject.Tables(0).Rows(0)("workflow") & ""
                    If "06,08".IndexOf(GetServicetypeCode(dsProject.Tables(0).Rows(0)("apply_service_type") & "")) >= 0 Then '保函品种
                        'txtRunMode.Text = strWorkFlow
                        ShowBaoHanInfo(Nothing)
                    End If
                End If
                dsProject.Dispose()
                '不需显示会议方框
                gpxMeeting.Visible = False
                Me.Height -= gpxMeeting.Height
            End If

            Me.Height -= IIf(gpxBaoHan.Visible, 0, gpxBaoHan.Height)
            Me.gpxMeeting.Location = IIf(gpxBaoHan.Visible, gpxMeeting.Location, gpxBaoHan.Location)

            If gpxMeeting.Visible Then
                '增加显示互助会确认是否采用
                Dim dsPartner As DataSet = gWs.GetProjectGuaranteeForm("{project_code LIKE '" & ProjectCode & "' AND guarantee_form LIKE '%互助%'}")
                Dim rows() As DataRow = dsPartner.Tables(0).Select("is_used=1")
                ckxPartnerAffirm.Checked = rows.Length > 0
                dsPartner.Dispose()
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub


    Private Sub txt_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtReviewFee.Leave
        Money.Money_Leave(sender, e)
        If txtReviewFee.Text <> String.Empty Then
            If CDbl(txtReviewFee.Text) > MaxFee Then
                SWDialogBox.MessageBox.Show("$X032", MaxFee.ToString("n"))
                txtReviewFee.Text = ""
            End If
        End If
    End Sub

    Private Function IsInfoEffective() As Boolean
        Try
            If txtReviewFee.Text.Trim = "" Then
                Return False
            End If
        Catch
            Return False
        End Try
        Return True
    End Function

    Private Overloads Function GetServicetypeCode(ByVal service_type_name As String) As String
        If dsServiceType Is Nothing Then
            dsServiceType = gWs.GetServiceType("%")
        End If
        Dim table As DataTable = dsServiceType.Tables(0)
        Dim drs() As DataRow = table.Select("service_type='" & service_type_name & "'")
        If drs.Length > 0 Then
            Return drs(0)("service_type_code").ToString
        End If
        Return "Nothing"
    End Function


    Private Sub InsertAFeeRecord(ByVal payout As Double)
        Dim now As DateTime = gWs.GetSysTime
        Dim dr As DataRow = dsAccount.Tables(0).NewRow
        With dr
            .Item("project_code") = ProjectCode
            .Item("phase") = "评审"
            .Item("date") = now.Date
            .Item("item_type") = "31"
            .Item("item_code") = "001"
            .Item("payout") = payout
            .Item("create_person") = UserName
            .Item("create_date") = now
        End With
        dsAccount.Tables(0).Rows.Add(dr)
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If Not IsInfoEffective() Then
            SWDialogBox.MessageBox.Show("$1003", "评审费用")
            txtReviewFee.Focus()
            Return
        End If
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交")
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If

        Dim result As String
        Dim balance As Double = CDbl(txtReviewFee.Text)
        Dim rowsCount As Int32 = dsAccount.Tables("project_account_detail").Rows.Count
        'If balance >= CDbl(txtConclusionReviewFee.Text) Then '确认收取费用>=应收评审费
        If rowsCount = 2 Then '两条记录，rows（1）为“评审”，rows（0）为“初审”
            balance -= CDbl(dsAccount.Tables(0).Rows(0)("payout")) '确认金额减去预收的
            If balance <= 0 Then '减去后为零则删除，否则修改
                dsAccount.Tables(0).Rows(1).Delete()
            Else
                dsAccount.Tables(0).Rows(1)("payout") = balance
            End If
        ElseIf rowsCount = 1 Then '一条记录
            Dim strPhase As String = dsAccount.Tables(0).Rows(0)("phase") & ""
            If Trim(strPhase) = "评审" Then '直接修改
                If balance = 0 Then '如确认金额为零，直接删除，否则修改
                    dsAccount.Tables(0).Rows(0).Delete()
                Else
                    dsAccount.Tables(0).Rows(0)("payout") = balance
                End If
            Else '非评审阶段 确认金额减去预收的，大于0就插入
                balance -= CDbl(dsAccount.Tables(0).Rows(0)("payout"))
                If balance > 0 Then
                    InsertAFeeRecord(balance)
                End If
            End If
        ElseIf rowsCount = 0 And balance > 0 Then '尚未有记录
            InsertAFeeRecord(balance)
        End If
        'Else '确认收取费用 < 应收评审费
        '    If rowsCount = 2 Then
        '        dsAccount.Tables(0).Rows(1).Delete()
        '        balance -= CDbl(dsAccount.Tables(0).Rows(0)("payout")) '删除原有的“评审”阶段的payout记录
        '        If balance > 0 Then
        '            InsertAFeeRecord(balance)
        '        End If
        '    ElseIf rowsCount = 1 Then
        '        Dim strPhase As String = dsAccount.Tables(0).Rows(0)("phase") & ""
        '        If Trim(strPhase) = "评审" Then
        '            If balance = 0 Then '如确认金额为零，直接删除，否则修改
        '                dsAccount.Tables(0).Rows(0).Delete()
        '            Else
        '                dsAccount.Tables(0).Rows(0)("payout") = balance
        '            End If
        '        Else '非评审阶段    确认金额减去预收的，大于0就插入
        '            balance -= CDbl(dsAccount.Tables(0).Rows(0)("payout"))
        '            If balance > 0 Then
        '                InsertAFeeRecord(balance)
        '            End If
        '        End If
        '    ElseIf rowsCount = 1 And balance > 0 Then
        '        InsertAFeeRecord(balance)
        '    End If
        'End If

        bmAccount.EndCurrentEdit()
        If dsAccount.HasChanges Then
            result = gWs.UpdateProjectAccountDetail(dsAccount.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "修改评审费出错", result, "")
                Return
            End If
        End If
        result = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, "", UserName)
        If result = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            MyBase.raiseCommitSucceed()
            Me.Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "提交失败", result, "")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        If Not gpxBaoHan.Visible Then '非保函品种
            Dim meet As New frmMeetRecordQuery(ProjectCode, txtCorName.Text)
            meet.AllowTransparency = False
            meet.ShowDialog()
        ElseIf gpxMeeting.Visible Then '保函品种且开过评审会
            frmChangeGuarantyFee.OpenWord(ProjectCode, Me, txtCorName.Text.Trim & "评审会意见表", True, txtCorName.Text)
        Else
            Dim apply_date As DateTime = Money.GetApplyDate(ProjectCode)
            Dim dsLetter As DataSet = gWs.GetGuaranteeLetter(ProjectCode.Substring(0, 5), apply_date)
            Dim fileProjectCode As String
            If dsLetter.Tables(0).Rows.Count > 0 Then
                fileProjectCode = dsLetter.Tables(0).Rows(0)("project_code") & String.Empty
                frmChangeGuarantyFee.OpenWord(fileProjectCode, Me, txtCorName.Text.Trim & "评审会意见表", False, String.Empty)
            End If
        End If
    End Sub
    Friend WithEvents gpxMeeting As System.Windows.Forms.GroupBox
End Class
