
'确认收取担保费
Public Class frmChangeGuarantyFee
    Inherits frmBasic
    Private Const passText As String = "通过"
    Private ProjectCode, TaskID, WorkFlowID As String
    Private dsAccount As DataSet
    Private bmAccount As BindingManagerBase
    Private Const MaxFee As Double = 100000000
    Private Const GuarantyFeeStandard As Double = 0.018
    Private isReGuarantee As Boolean = False
    Private dsServiceType As DataSet
    'Private dsServiceType As DataSet

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
    Friend WithEvents txtGuaFee As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Protected WithEvents txtCorName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFee As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtConclusion As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtServiceType As System.Windows.Forms.TextBox
    Friend WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents txtStandard As System.Windows.Forms.TextBox
    Friend WithEvents txtRefundType As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEachReturnFee As System.Windows.Forms.TextBox
    Friend WithEvents txtLoanForm As System.Windows.Forms.TextBox
    Friend WithEvents txtRateRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtOrgaName As SWSystem.Windows.Forms.TextBox
    Friend WithEvents lblTerms As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtRunMode As System.Windows.Forms.TextBox
    Friend WithEvents txtRemailSum As System.Windows.Forms.TextBox
    Friend WithEvents txtBaoHanType As System.Windows.Forms.TextBox
    Friend WithEvents txtRebetType As System.Windows.Forms.TextBox
    Friend WithEvents txtSigBank As System.Windows.Forms.TextBox
    Friend WithEvents txtSigSubBank As System.Windows.Forms.TextBox
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents txtSecurityScale As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents colBaoHanType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents colRes As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents colGuanFeeRate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents colSecuRate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents gpxApplyInfo As System.Windows.Forms.GroupBox
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents gpxReGuarantee As System.Windows.Forms.GroupBox
    Friend WithEvents txtReguaranteeFee As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtSubBank As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtBank As SWSystem.Windows.Forms.TextBox
    Friend WithEvents gpxMeeting As System.Windows.Forms.GroupBox
    Friend WithEvents lblStandard As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ckxPartnerAffirm As System.Windows.Forms.CheckBox
    Friend WithEvents lblItem2 As System.Windows.Forms.Label
    Friend WithEvents lblItem1 As System.Windows.Forms.Label
    Friend WithEvents gpxBaoHan As System.Windows.Forms.GroupBox
    Friend WithEvents grdLetterUsage As System.Windows.Forms.DataGrid
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtApplySum As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtApplyTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtApplyBank As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtApplySubBank As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtApplyBaoHanType As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtApplyResuiseType As System.Windows.Forms.TextBox
    Friend WithEvents chkIsReFee As System.Windows.Forms.CheckBox
    Friend WithEvents dateReFeeTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents col2_1 As DataGridTextBoxColumn

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmChangeGuarantyFee))
        Me.btnCommit = New System.Windows.Forms.Button
        Me.gpxMeeting = New System.Windows.Forms.GroupBox
        Me.ckxPartnerAffirm = New System.Windows.Forms.CheckBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtRateRemark = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtLoanForm = New System.Windows.Forms.TextBox
        Me.lblItem1 = New System.Windows.Forms.Label
        Me.txtEachReturnFee = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtRefundType = New System.Windows.Forms.TextBox
        Me.lblItem2 = New System.Windows.Forms.Label
        Me.txtTerm = New System.Windows.Forms.TextBox
        Me.lblTerms = New System.Windows.Forms.Label
        Me.txtSum = New System.Windows.Forms.TextBox
        Me.lblSum = New System.Windows.Forms.Label
        Me.txtServiceType = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtConclusion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFee = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtStandard = New System.Windows.Forms.TextBox
        Me.lblStandard = New System.Windows.Forms.Label
        Me.txtGuaFee = New System.Windows.Forms.TextBox
        Me.txtCorName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtProjectCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.gpxReGuarantee = New System.Windows.Forms.GroupBox
        Me.txtReguaranteeFee = New SWSystem.Windows.Forms.TextBox
        Me.txtSubBank = New SWSystem.Windows.Forms.TextBox
        Me.txtBank = New SWSystem.Windows.Forms.TextBox
        Me.txtOrgaName = New SWSystem.Windows.Forms.TextBox
        Me.gpxBaoHan = New System.Windows.Forms.GroupBox
        Me.gpxApplyInfo = New System.Windows.Forms.GroupBox
        Me.txtApplyResuiseType = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtApplyBaoHanType = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.txtApplySubBank = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtApplyBank = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.txtApplyTerm = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.txtApplySum = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.grdLetterUsage = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.colBaoHanType = New System.Windows.Forms.DataGridTextBoxColumn
        Me.colRes = New System.Windows.Forms.DataGridTextBoxColumn
        Me.colGuanFeeRate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.colSecuRate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtSecurityScale = New System.Windows.Forms.TextBox
        Me.txtEndDate = New System.Windows.Forms.TextBox
        Me.txtSigSubBank = New System.Windows.Forms.TextBox
        Me.txtSigBank = New System.Windows.Forms.TextBox
        Me.txtRebetType = New System.Windows.Forms.TextBox
        Me.txtBaoHanType = New System.Windows.Forms.TextBox
        Me.txtRemailSum = New System.Windows.Forms.TextBox
        Me.txtRunMode = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.btnRecord = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkIsReFee = New System.Windows.Forms.CheckBox
        Me.dateReFeeTime = New System.Windows.Forms.DateTimePicker
        Me.Label19 = New System.Windows.Forms.Label
        Me.col2_1 = New DataGridTextBoxColumn
        Me.gpxMeeting.SuspendLayout()
        Me.gpxReGuarantee.SuspendLayout()
        Me.gpxBaoHan.SuspendLayout()
        Me.gpxApplyInfo.SuspendLayout()
        CType(Me.grdLetterUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.btnExit.Location = New System.Drawing.Point(447, 585)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 3
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(363, 585)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 2
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpxMeeting
        '
        Me.gpxMeeting.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpxMeeting.Controls.Add(Me.ckxPartnerAffirm)
        Me.gpxMeeting.Controls.Add(Me.Label9)
        Me.gpxMeeting.Controls.Add(Me.txtRateRemark)
        Me.gpxMeeting.Controls.Add(Me.Label14)
        Me.gpxMeeting.Controls.Add(Me.txtLoanForm)
        Me.gpxMeeting.Controls.Add(Me.lblItem1)
        Me.gpxMeeting.Controls.Add(Me.txtEachReturnFee)
        Me.gpxMeeting.Controls.Add(Me.Label12)
        Me.gpxMeeting.Controls.Add(Me.txtRefundType)
        Me.gpxMeeting.Controls.Add(Me.lblItem2)
        Me.gpxMeeting.Controls.Add(Me.txtTerm)
        Me.gpxMeeting.Controls.Add(Me.lblTerms)
        Me.gpxMeeting.Controls.Add(Me.txtSum)
        Me.gpxMeeting.Controls.Add(Me.lblSum)
        Me.gpxMeeting.Controls.Add(Me.txtServiceType)
        Me.gpxMeeting.Controls.Add(Me.Label4)
        Me.gpxMeeting.Controls.Add(Me.txtConclusion)
        Me.gpxMeeting.Controls.Add(Me.Label3)
        Me.gpxMeeting.Controls.Add(Me.txtFee)
        Me.gpxMeeting.Controls.Add(Me.Label1)
        Me.gpxMeeting.Location = New System.Drawing.Point(8, 352)
        Me.gpxMeeting.Name = "gpxMeeting"
        Me.gpxMeeting.Size = New System.Drawing.Size(520, 152)
        Me.gpxMeeting.TabIndex = 2
        Me.gpxMeeting.TabStop = False
        Me.gpxMeeting.Text = "评审会意见"
        '
        'ckxPartnerAffirm
        '
        Me.ckxPartnerAffirm.BackColor = System.Drawing.Color.Gainsboro
        Me.ckxPartnerAffirm.Enabled = False
        Me.ckxPartnerAffirm.ForeColor = System.Drawing.Color.Gainsboro
        Me.ckxPartnerAffirm.Location = New System.Drawing.Point(496, 65)
        Me.ckxPartnerAffirm.Name = "ckxPartnerAffirm"
        Me.ckxPartnerAffirm.Size = New System.Drawing.Size(15, 18)
        Me.ckxPartnerAffirm.TabIndex = 85
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(400, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 17)
        Me.Label9.TabIndex = 84
        Me.Label9.Text = "互   助   会"
        '
        'txtRateRemark
        '
        Me.txtRateRemark.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRateRemark.Location = New System.Drawing.Point(112, 112)
        Me.txtRateRemark.MaxLength = 30
        Me.txtRateRemark.Multiline = True
        Me.txtRateRemark.Name = "txtRateRemark"
        Me.txtRateRemark.ReadOnly = True
        Me.txtRateRemark.Size = New System.Drawing.Size(400, 32)
        Me.txtRateRemark.TabIndex = 82
        Me.txtRateRemark.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 120)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 17)
        Me.Label14.TabIndex = 83
        Me.Label14.Text = "担保费率说明"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLoanForm
        '
        Me.txtLoanForm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanForm.Location = New System.Drawing.Point(312, 40)
        Me.txtLoanForm.Name = "txtLoanForm"
        Me.txtLoanForm.ReadOnly = True
        Me.txtLoanForm.Size = New System.Drawing.Size(200, 21)
        Me.txtLoanForm.TabIndex = 57
        Me.txtLoanForm.Text = ""
        '
        'lblItem1
        '
        Me.lblItem1.AutoSize = True
        Me.lblItem1.Location = New System.Drawing.Point(216, 43)
        Me.lblItem1.Name = "lblItem1"
        Me.lblItem1.Size = New System.Drawing.Size(79, 17)
        Me.lblItem1.TabIndex = 56
        Me.lblItem1.Text = "放  款 方 式"
        Me.lblItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEachReturnFee
        '
        Me.txtEachReturnFee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEachReturnFee.Location = New System.Drawing.Point(312, 88)
        Me.txtEachReturnFee.Name = "txtEachReturnFee"
        Me.txtEachReturnFee.ReadOnly = True
        Me.txtEachReturnFee.Size = New System.Drawing.Size(200, 21)
        Me.txtEachReturnFee.TabIndex = 55
        Me.txtEachReturnFee.Text = ""
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(216, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(91, 17)
        Me.Label12.TabIndex = 54
        Me.Label12.Text = "每次还款额(元)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRefundType
        '
        Me.txtRefundType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRefundType.Location = New System.Drawing.Point(112, 88)
        Me.txtRefundType.Name = "txtRefundType"
        Me.txtRefundType.ReadOnly = True
        Me.txtRefundType.Size = New System.Drawing.Size(96, 21)
        Me.txtRefundType.TabIndex = 18
        Me.txtRefundType.Text = ""
        '
        'lblItem2
        '
        Me.lblItem2.AutoSize = True
        Me.lblItem2.Location = New System.Drawing.Point(8, 91)
        Me.lblItem2.Name = "lblItem2"
        Me.lblItem2.Size = New System.Drawing.Size(85, 17)
        Me.lblItem2.TabIndex = 17
        Me.lblItem2.Text = "还  款  方 式"
        Me.lblItem2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTerm
        '
        Me.txtTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerm.Location = New System.Drawing.Point(312, 64)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.ReadOnly = True
        Me.txtTerm.Size = New System.Drawing.Size(80, 21)
        Me.txtTerm.TabIndex = 16
        Me.txtTerm.Text = ""
        '
        'lblTerms
        '
        Me.lblTerms.AutoSize = True
        Me.lblTerms.Location = New System.Drawing.Point(216, 67)
        Me.lblTerms.Name = "lblTerms"
        Me.lblTerms.Size = New System.Drawing.Size(85, 17)
        Me.lblTerms.TabIndex = 15
        Me.lblTerms.Text = "担保期限 (月)"
        Me.lblTerms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSum
        '
        Me.txtSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSum.Location = New System.Drawing.Point(112, 40)
        Me.txtSum.Name = "txtSum"
        Me.txtSum.ReadOnly = True
        Me.txtSum.Size = New System.Drawing.Size(96, 21)
        Me.txtSum.TabIndex = 11
        Me.txtSum.Text = ""
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(8, 43)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(91, 17)
        Me.lblSum.TabIndex = 10
        Me.lblSum.Text = "担保金额(万元)"
        Me.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtServiceType
        '
        Me.txtServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtServiceType.Location = New System.Drawing.Point(312, 16)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(200, 21)
        Me.txtServiceType.TabIndex = 9
        Me.txtServiceType.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "业  务 品 种"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtConclusion
        '
        Me.txtConclusion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConclusion.Location = New System.Drawing.Point(112, 16)
        Me.txtConclusion.Name = "txtConclusion"
        Me.txtConclusion.ReadOnly = True
        Me.txtConclusion.Size = New System.Drawing.Size(96, 21)
        Me.txtConclusion.TabIndex = 7
        Me.txtConclusion.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "会  议  结  论"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFee
        '
        Me.txtFee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFee.Location = New System.Drawing.Point(112, 64)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.ReadOnly = True
        Me.txtFee.Size = New System.Drawing.Size(96, 21)
        Me.txtFee.TabIndex = 5
        Me.txtFee.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "应收担保费(元)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStandard
        '
        Me.txtStandard.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtStandard.BackColor = System.Drawing.Color.Gainsboro
        Me.txtStandard.Location = New System.Drawing.Point(120, 512)
        Me.txtStandard.Name = "txtStandard"
        Me.txtStandard.ReadOnly = True
        Me.txtStandard.Size = New System.Drawing.Size(96, 21)
        Me.txtStandard.TabIndex = 13
        Me.txtStandard.Text = ""
        '
        'lblStandard
        '
        Me.lblStandard.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblStandard.AutoSize = True
        Me.lblStandard.Location = New System.Drawing.Point(16, 512)
        Me.lblStandard.Name = "lblStandard"
        Me.lblStandard.Size = New System.Drawing.Size(91, 17)
        Me.lblStandard.TabIndex = 12
        Me.lblStandard.Text = "收取标准(%/年)"
        Me.lblStandard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGuaFee
        '
        Me.txtGuaFee.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtGuaFee.Location = New System.Drawing.Point(344, 512)
        Me.txtGuaFee.MaxLength = 14
        Me.txtGuaFee.Name = "txtGuaFee"
        Me.txtGuaFee.Size = New System.Drawing.Size(96, 21)
        Me.txtGuaFee.TabIndex = 0
        Me.txtGuaFee.Text = ""
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(224, 8)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(248, 21)
        Me.txtCorName.TabIndex = 37
        Me.txtCorName.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "企业名称"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 17)
        Me.Label6.TabIndex = 34
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
        Me.txtProjectCode.TabIndex = 36
        Me.txtProjectCode.Text = ""
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(256, 512)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "收取费用(元)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gpxReGuarantee
        '
        Me.gpxReGuarantee.Controls.Add(Me.txtReguaranteeFee)
        Me.gpxReGuarantee.Controls.Add(Me.txtSubBank)
        Me.gpxReGuarantee.Controls.Add(Me.txtBank)
        Me.gpxReGuarantee.Controls.Add(Me.txtOrgaName)
        Me.gpxReGuarantee.Location = New System.Drawing.Point(8, 40)
        Me.gpxReGuarantee.Name = "gpxReGuarantee"
        Me.gpxReGuarantee.Size = New System.Drawing.Size(520, 72)
        Me.gpxReGuarantee.TabIndex = 38
        Me.gpxReGuarantee.TabStop = False
        Me.gpxReGuarantee.Text = "再担保信息"
        Me.gpxReGuarantee.Visible = False
        '
        'txtReguaranteeFee
        '
        Me.txtReguaranteeFee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtReguaranteeFee.DefaultValue = CType(resources.GetObject("txtReguaranteeFee.DefaultValue"), Object)
        Me.txtReguaranteeFee.LabelText = "担保机构收取的担保费(元)"
        Me.txtReguaranteeFee.LabelWidth = 153
        Me.txtReguaranteeFee.Location = New System.Drawing.Point(288, 16)
        Me.txtReguaranteeFee.MaxLength = 32767
        Me.txtReguaranteeFee.Name = "txtReguaranteeFee"
        Me.txtReguaranteeFee.ReadOnly = True
        Me.txtReguaranteeFee.Size = New System.Drawing.Size(224, 21)
        Me.txtReguaranteeFee.TabIndex = 26
        Me.txtReguaranteeFee.Value = CType(resources.GetObject("txtReguaranteeFee.Value"), Object)
        '
        'txtSubBank
        '
        Me.txtSubBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSubBank.DefaultValue = CType(resources.GetObject("txtSubBank.DefaultValue"), Object)
        Me.txtSubBank.LabelText = "支  行"
        Me.txtSubBank.LabelWidth = 42
        Me.txtSubBank.Location = New System.Drawing.Point(288, 40)
        Me.txtSubBank.MaxLength = 32767
        Me.txtSubBank.Name = "txtSubBank"
        Me.txtSubBank.ReadOnly = True
        Me.txtSubBank.Size = New System.Drawing.Size(224, 21)
        Me.txtSubBank.TabIndex = 25
        Me.txtSubBank.Value = CType(resources.GetObject("txtSubBank.Value"), Object)
        '
        'txtBank
        '
        Me.txtBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBank.DefaultValue = CType(resources.GetObject("txtBank.DefaultValue"), Object)
        Me.txtBank.LabelText = "放 款 银  行"
        Me.txtBank.LabelWidth = 79
        Me.txtBank.Location = New System.Drawing.Point(8, 40)
        Me.txtBank.MaxLength = 32767
        Me.txtBank.Name = "txtBank"
        Me.txtBank.ReadOnly = True
        Me.txtBank.Size = New System.Drawing.Size(272, 21)
        Me.txtBank.TabIndex = 24
        Me.txtBank.Value = CType(resources.GetObject("txtBank.Value"), Object)
        '
        'txtOrgaName
        '
        Me.txtOrgaName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOrgaName.DefaultValue = CType(resources.GetObject("txtOrgaName.DefaultValue"), Object)
        Me.txtOrgaName.LabelText = "担保机构名称"
        Me.txtOrgaName.LabelWidth = 79
        Me.txtOrgaName.Location = New System.Drawing.Point(8, 16)
        Me.txtOrgaName.MaxLength = 32767
        Me.txtOrgaName.Name = "txtOrgaName"
        Me.txtOrgaName.ReadOnly = True
        Me.txtOrgaName.Size = New System.Drawing.Size(272, 21)
        Me.txtOrgaName.TabIndex = 23
        Me.txtOrgaName.Value = CType(resources.GetObject("txtOrgaName.Value"), Object)
        '
        'gpxBaoHan
        '
        Me.gpxBaoHan.Controls.Add(Me.gpxApplyInfo)
        Me.gpxBaoHan.Controls.Add(Me.grdLetterUsage)
        Me.gpxBaoHan.Location = New System.Drawing.Point(8, 120)
        Me.gpxBaoHan.Name = "gpxBaoHan"
        Me.gpxBaoHan.Size = New System.Drawing.Size(520, 224)
        Me.gpxBaoHan.TabIndex = 39
        Me.gpxBaoHan.TabStop = False
        Me.gpxBaoHan.Text = "保函协议信息"
        Me.gpxBaoHan.Visible = False
        '
        'gpxApplyInfo
        '
        Me.gpxApplyInfo.Controls.Add(Me.txtApplyResuiseType)
        Me.gpxApplyInfo.Controls.Add(Me.Label26)
        Me.gpxApplyInfo.Controls.Add(Me.txtApplyBaoHanType)
        Me.gpxApplyInfo.Controls.Add(Me.Label25)
        Me.gpxApplyInfo.Controls.Add(Me.txtApplySubBank)
        Me.gpxApplyInfo.Controls.Add(Me.Label24)
        Me.gpxApplyInfo.Controls.Add(Me.txtApplyBank)
        Me.gpxApplyInfo.Controls.Add(Me.Label23)
        Me.gpxApplyInfo.Controls.Add(Me.txtApplyTerm)
        Me.gpxApplyInfo.Controls.Add(Me.Label22)
        Me.gpxApplyInfo.Controls.Add(Me.txtApplySum)
        Me.gpxApplyInfo.Controls.Add(Me.Label18)
        Me.gpxApplyInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gpxApplyInfo.Location = New System.Drawing.Point(3, 125)
        Me.gpxApplyInfo.Name = "gpxApplyInfo"
        Me.gpxApplyInfo.Size = New System.Drawing.Size(514, 96)
        Me.gpxApplyInfo.TabIndex = 19
        Me.gpxApplyInfo.TabStop = False
        Me.gpxApplyInfo.Text = "申请信息"
        '
        'txtApplyResuiseType
        '
        Me.txtApplyResuiseType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyResuiseType.Location = New System.Drawing.Point(360, 72)
        Me.txtApplyResuiseType.Name = "txtApplyResuiseType"
        Me.txtApplyResuiseType.ReadOnly = True
        Me.txtApplyResuiseType.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyResuiseType.TabIndex = 11
        Me.txtApplyResuiseType.Text = ""
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(272, 75)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(79, 17)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "责任偿付类型"
        '
        'txtApplyBaoHanType
        '
        Me.txtApplyBaoHanType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyBaoHanType.Location = New System.Drawing.Point(80, 72)
        Me.txtApplyBaoHanType.Name = "txtApplyBaoHanType"
        Me.txtApplyBaoHanType.ReadOnly = True
        Me.txtApplyBaoHanType.Size = New System.Drawing.Size(160, 21)
        Me.txtApplyBaoHanType.TabIndex = 9
        Me.txtApplyBaoHanType.Text = ""
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 75)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(54, 17)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "保函种类"
        '
        'txtApplySubBank
        '
        Me.txtApplySubBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplySubBank.Location = New System.Drawing.Point(360, 44)
        Me.txtApplySubBank.Name = "txtApplySubBank"
        Me.txtApplySubBank.ReadOnly = True
        Me.txtApplySubBank.Size = New System.Drawing.Size(144, 21)
        Me.txtApplySubBank.TabIndex = 7
        Me.txtApplySubBank.Text = ""
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(272, 47)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(79, 17)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "支        行"
        '
        'txtApplyBank
        '
        Me.txtApplyBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyBank.Location = New System.Drawing.Point(80, 44)
        Me.txtApplyBank.Name = "txtApplyBank"
        Me.txtApplyBank.ReadOnly = True
        Me.txtApplyBank.Size = New System.Drawing.Size(160, 21)
        Me.txtApplyBank.TabIndex = 5
        Me.txtApplyBank.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 47)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(54, 17)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "银    行"
        '
        'txtApplyTerm
        '
        Me.txtApplyTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyTerm.Location = New System.Drawing.Point(360, 16)
        Me.txtApplyTerm.Name = "txtApplyTerm"
        Me.txtApplyTerm.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyTerm.TabIndex = 3
        Me.txtApplyTerm.Text = ""
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(272, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(85, 17)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "期     限(月)"
        '
        'txtApplySum
        '
        Me.txtApplySum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplySum.Location = New System.Drawing.Point(80, 16)
        Me.txtApplySum.Name = "txtApplySum"
        Me.txtApplySum.ReadOnly = True
        Me.txtApplySum.Size = New System.Drawing.Size(160, 21)
        Me.txtApplySum.TabIndex = 1
        Me.txtApplySum.Text = ""
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 19)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 17)
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
        Me.grdLetterUsage.Size = New System.Drawing.Size(514, 103)
        Me.grdLetterUsage.TabIndex = 16
        Me.grdLetterUsage.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})


        col2_1.MappingName = "term"     '期限
        col2_1.HeaderText = "期限(月)"
        col2_1.TextBox.MaxLength = 18
        col2_1.NullText = String.Empty
        col2_1.Width = 75

        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdLetterUsage
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.colBaoHanType, Me.colRes, Me.col2_1, Me.colGuanFeeRate, Me.colSecuRate})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TGuaranteeLetterUsage"
        '
        'colBaoHanType
        '
        Me.colBaoHanType.Format = ""
        Me.colBaoHanType.FormatInfo = Nothing
        Me.colBaoHanType.HeaderText = "保函种类"
        Me.colBaoHanType.MappingName = "LetterTypeName"
        Me.colBaoHanType.NullText = ""
        Me.colBaoHanType.Width = 110
        '
        'colRes
        '
        Me.colRes.Format = ""
        Me.colRes.FormatInfo = Nothing
        Me.colRes.HeaderText = "偿付责任类型"
        Me.colRes.MappingName = "ReimburseName"
        Me.colRes.NullText = ""
        Me.colRes.Width = 110

        '
        'colGuanFeeRate
        '
        Me.colGuanFeeRate.Format = ""
        Me.colGuanFeeRate.FormatInfo = Nothing
        Me.colGuanFeeRate.HeaderText = "担保费率(%)"
        Me.colGuanFeeRate.MappingName = "guarantee_rate"
        Me.colGuanFeeRate.NullText = ""
        Me.colGuanFeeRate.Width = 90
        '
        'colSecuRate
        '
        Me.colSecuRate.Format = ""
        Me.colSecuRate.FormatInfo = Nothing
        Me.colSecuRate.HeaderText = "保证金比例(%)"
        Me.colSecuRate.MappingName = "guarantee_scale"
        Me.colSecuRate.NullText = ""
        Me.colSecuRate.Width = 90
        '
        'txtSecurityScale
        '
        Me.txtSecurityScale.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSecurityScale.Location = New System.Drawing.Point(376, 104)
        Me.txtSecurityScale.Name = "txtSecurityScale"
        Me.txtSecurityScale.ReadOnly = True
        Me.txtSecurityScale.Size = New System.Drawing.Size(136, 21)
        Me.txtSecurityScale.TabIndex = 15
        Me.txtSecurityScale.Text = ""
        '
        'txtEndDate
        '
        Me.txtEndDate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEndDate.Location = New System.Drawing.Point(88, 104)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.ReadOnly = True
        Me.txtEndDate.Size = New System.Drawing.Size(152, 21)
        Me.txtEndDate.TabIndex = 14
        Me.txtEndDate.Text = ""
        '
        'txtSigSubBank
        '
        Me.txtSigSubBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSigSubBank.Location = New System.Drawing.Point(376, 72)
        Me.txtSigSubBank.Name = "txtSigSubBank"
        Me.txtSigSubBank.ReadOnly = True
        Me.txtSigSubBank.Size = New System.Drawing.Size(136, 21)
        Me.txtSigSubBank.TabIndex = 13
        Me.txtSigSubBank.Text = ""
        '
        'txtSigBank
        '
        Me.txtSigBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSigBank.Location = New System.Drawing.Point(88, 72)
        Me.txtSigBank.Name = "txtSigBank"
        Me.txtSigBank.ReadOnly = True
        Me.txtSigBank.Size = New System.Drawing.Size(152, 21)
        Me.txtSigBank.TabIndex = 12
        Me.txtSigBank.Text = ""
        '
        'txtRebetType
        '
        Me.txtRebetType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRebetType.Location = New System.Drawing.Point(376, 48)
        Me.txtRebetType.Name = "txtRebetType"
        Me.txtRebetType.ReadOnly = True
        Me.txtRebetType.Size = New System.Drawing.Size(136, 21)
        Me.txtRebetType.TabIndex = 11
        Me.txtRebetType.Text = ""
        '
        'txtBaoHanType
        '
        Me.txtBaoHanType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBaoHanType.Location = New System.Drawing.Point(88, 48)
        Me.txtBaoHanType.Name = "txtBaoHanType"
        Me.txtBaoHanType.ReadOnly = True
        Me.txtBaoHanType.Size = New System.Drawing.Size(152, 21)
        Me.txtBaoHanType.TabIndex = 10
        Me.txtBaoHanType.Text = ""
        '
        'txtRemailSum
        '
        Me.txtRemailSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRemailSum.Location = New System.Drawing.Point(376, 24)
        Me.txtRemailSum.Name = "txtRemailSum"
        Me.txtRemailSum.ReadOnly = True
        Me.txtRemailSum.Size = New System.Drawing.Size(136, 21)
        Me.txtRemailSum.TabIndex = 9
        Me.txtRemailSum.Text = ""
        '
        'txtRunMode
        '
        Me.txtRunMode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRunMode.Location = New System.Drawing.Point(88, 24)
        Me.txtRunMode.Name = "txtRunMode"
        Me.txtRunMode.ReadOnly = True
        Me.txtRunMode.Size = New System.Drawing.Size(152, 21)
        Me.txtRunMode.TabIndex = 8
        Me.txtRunMode.Text = ""
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(280, 104)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(85, 17)
        Me.Label17.TabIndex = 7
        Me.Label17.Text = "保证金比例(%)"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 17)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "额度到期日"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(280, 24)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 17)
        Me.Label15.TabIndex = 5
        Me.Label15.Text = "剩余额度(万元)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 24)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(54, 17)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "运作方式"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(280, 80)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(91, 17)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "出  函  支  行"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 17)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "出函银行"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(280, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "偿付责任类型"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 17)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "保函种类"
        '
        'btnRecord
        '
        Me.btnRecord.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecord.ImageIndex = 11
        Me.btnRecord.ImageList = Me.ImageListBasic
        Me.btnRecord.Location = New System.Drawing.Point(248, 585)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(108, 23)
        Me.btnRecord.TabIndex = 1
        Me.btnRecord.Text = "评审会结论(&M)"
        Me.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtRemailSum)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtSecurityScale)
        Me.GroupBox1.Controls.Add(Me.txtSigBank)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtRunMode)
        Me.GroupBox1.Controls.Add(Me.txtBaoHanType)
        Me.GroupBox1.Controls.Add(Me.txtSigSubBank)
        Me.GroupBox1.Controls.Add(Me.txtRebetType)
        Me.GroupBox1.Controls.Add(Me.txtEndDate)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 656)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(520, 136)
        Me.GroupBox1.TabIndex = 40
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        Me.GroupBox1.Visible = False
        '
        'chkIsReFee
        '
        Me.chkIsReFee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkIsReFee.Location = New System.Drawing.Point(120, 552)
        Me.chkIsReFee.Name = "chkIsReFee"
        Me.chkIsReFee.TabIndex = 41
        Me.chkIsReFee.Text = "需要补收"
        '
        'dateReFeeTime
        '
        Me.dateReFeeTime.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateReFeeTime.Location = New System.Drawing.Point(344, 552)
        Me.dateReFeeTime.Name = "dateReFeeTime"
        Me.dateReFeeTime.Size = New System.Drawing.Size(112, 21)
        Me.dateReFeeTime.TabIndex = 42
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.Location = New System.Drawing.Point(256, 552)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(64, 23)
        Me.Label19.TabIndex = 43
        Me.Label19.Text = "补收日期"
        '
        'frmChangeGuarantyFee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(538, 616)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.dateReFeeTime)
        Me.Controls.Add(Me.chkIsReFee)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gpxBaoHan)
        Me.Controls.Add(Me.gpxReGuarantee)
        Me.Controls.Add(Me.txtCorName)
        Me.Controls.Add(Me.txtProjectCode)
        Me.Controls.Add(Me.txtGuaFee)
        Me.Controls.Add(Me.gpxMeeting)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.lblStandard)
        Me.Controls.Add(Me.txtStandard)
        Me.MaximizeBox = False
        Me.Name = "frmChangeGuarantyFee"
        Me.Text = "审核应收担保费"
        Me.Controls.SetChildIndex(Me.txtStandard, 0)
        Me.Controls.SetChildIndex(Me.lblStandard, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.gpxMeeting, 0)
        Me.Controls.SetChildIndex(Me.txtGuaFee, 0)
        Me.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.Controls.SetChildIndex(Me.txtCorName, 0)
        Me.Controls.SetChildIndex(Me.gpxReGuarantee, 0)
        Me.Controls.SetChildIndex(Me.gpxBaoHan, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.btnRecord, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.chkIsReFee, 0)
        Me.Controls.SetChildIndex(Me.dateReFeeTime, 0)
        Me.Controls.SetChildIndex(Me.Label19, 0)
        Me.gpxMeeting.ResumeLayout(False)
        Me.gpxReGuarantee.ResumeLayout(False)
        Me.gpxBaoHan.ResumeLayout(False)
        Me.gpxApplyInfo.ResumeLayout(False)
        CType(Me.grdLetterUsage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    '获取再担保项目信息
    Private Sub ShowReGuaranteeProjectInfo()
        gpxReGuarantee.Visible = True
        lblSum.Text = "再担保额度(万元)"
        lblTerms.Text = "再担保期限(月)"
        Dim dsTemp As DataSet = gWs.GetReGuaranteeProjectInfo("{ProjectCode LIKE '" & ProjectCode & "'}")
        txtOrgaName.DataBindings.Add("Value", dsTemp, dsTemp.Tables(0).TableName & ".OrganizationName")
        txtReguaranteeFee.DataBindings.Add("Value", dsTemp, dsTemp.Tables(0).TableName & ".SourceGuaranteeFee")
        txtBank.DataBindings.Add("Value", dsTemp, dsTemp.Tables(0).TableName & ".BankName")
        txtSubBank.DataBindings.Add("Value", dsTemp, dsTemp.Tables(0).TableName & ".BranchBankName")
        dsTemp = Nothing
    End Sub
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

    Private Sub frm_load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            ProjectCode = MyBase.getProjectCode
            TaskID = MyBase.getTaskID
            WorkFlowID = MyBase.getWorkFlowID
            txtProjectCode.Text = ProjectCode : txtCorName.Text = MyBase.getCorporationName
            ''获取业务品种数据集
            'dsServiceType = gWs.GetServiceType("%")

            dsAccount = gWs.GetProjectAccountDetailInfo("{project_code LIKE '" & ProjectCode & "' AND item_type='31' AND item_code='002' AND phase LIKE '%评审%' AND NOT payout IS NULL ORDER BY serial_num DESC}")
            bmAccount = BindingContext(dsAccount, "project_account_detail")
            txtGuaFee.DataBindings.Add("Text", dsAccount, "project_account_detail.payout")
            txtRateRemark.DataBindings.Add("Text", dsAccount, "project_account_detail.remark")
            If bmAccount.Count > 0 Then
                bmAccount.Position = 0
            End If

            Dim dsTrial As DataSet = gWs.GetConfTrialInfo("{project_code LIKE '" & ProjectCode & "' ORDER BY trial_times DESC}", "null") ' AND trial_conclusion LIKE '%" & passText & "%'
            txtConclusion.DataBindings.Add("Text", dsTrial, "conference_trial.trial_conclusion")
            txtSum.DataBindings.Add("Text", dsTrial, "conference_trial.guarantee_sum")
            txtServiceType.DataBindings.Add("Text", dsTrial, "conference_trial.service_type")
            txtLoanForm.DataBindings.Add("Text", dsTrial, "conference_trial.loan_provide_form")
            txtTerm.DataBindings.Add("Text", dsTrial, "conference_trial.terms")
            txtRefundType.DataBindings.Add("Text", dsTrial, "conference_trial.refund_type")
            txtEachReturnFee.DataBindings.Add("Text", dsTrial, "conference_trial.refund_sum_average")

            '如果业务评种是再担保
            If txtServiceType.Text <> String.Empty Then  '.IndexOf("再担保") >= 0
                If GetServicetypeCode(txtServiceType.Text) = "07" Then
                    ShowReGuaranteeProjectInfo()
                    lblStandard.Text = "利         率"
                End If
            End If

            Dim strWorkFlow As String
            '如果业务评种是保函非综合授信
            If txtServiceType.Text <> String.Empty Then
                strWorkFlow = dsTrial.Tables("conference_trial").Rows(0)("workflow") & ""
                If GetServicetypeCode(txtServiceType.Text) <> "08" AndAlso GetServicetypeCode(txtServiceType.Text) = "06" Then   '非保函综合授信的保函业务品种，如果是额度项下保函
                    'txtRunMode.Text = strWorkFlow
                    ShowBaoHanInfo(dsTrial.Tables("conference_trial").Rows(0))
                End If
                txtStandard.DataBindings.Add("Text", dsTrial, "conference_trial.guarantee_rate")
                '有开过会议则不需要显示申请信息
                gpxApplyInfo.Visible = False
                gpxBaoHan.Height -= gpxApplyInfo.Height
                Me.Height -= gpxApplyInfo.Height
            Else '该项目没有上过会，有可能是保函品种，因此去project查看运作方式
                '从project表读取保证金比例，如有则采用
                Dim dsProject As DataSet = gWs.GetProjectInfo(ProjectCode)
                If Not IsDBNull(dsProject.Tables(0).Rows(0)("guarantee_rate")) Then
                    txtStandard.Text = Format(dsProject.Tables(0).Rows(0)("guarantee_rate"), "n")
                End If
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
            Me.Height -= IIf(gpxReGuarantee.Visible, 0, gpxReGuarantee.Height)
            Me.Height -= IIf(gpxBaoHan.Visible, 0, gpxBaoHan.Height)
            Me.gpxBaoHan.Location = IIf(gpxBaoHan.Visible, gpxReGuarantee.Location, gpxBaoHan.Location)
            Me.gpxMeeting.Location = IIf(Me.gpxReGuarantee.Visible, Me.gpxBaoHan.Location, IIf(Me.gpxBaoHan.Visible, New Point(Me.gpxMeeting.Left, Me.gpxBaoHan.Top + Me.gpxBaoHan.Height + 5), Me.gpxReGuarantee.Location))

            If gpxMeeting.Visible Then
                '增加显示互助会确认是否采用
                Dim dsPartner As DataSet = gWs.GetProjectGuaranteeForm("{project_code LIKE '" & ProjectCode & "' AND guarantee_form LIKE '%互助%'}")
                Dim rows() As DataRow = dsPartner.Tables(0).Select("is_used=1")
                ckxPartnerAffirm.Checked = rows.Length > 0
                dsPartner.Dispose()
            End If

            Dim sum As Double
            Dim term As Int32
            If txtSum.Text <> String.Empty Then
                sum = CDbl(txtSum.Text)
                term = Convert.ToInt32(txtTerm.Text)
            ElseIf txtApplySum.Text <> String.Empty Then
                sum = CDbl(txtApplySum.Text)
                term = Convert.ToInt32(IIf(txtApplyTerm.Text = String.Empty, 0, txtApplyTerm.Text))
            End If
            If txtTerm.Text <> String.Empty Then
                txtFee.Text = CaculateGuaranteeOfServiceType(sum * 10000, term).ToString("n")
            End If
            'If txtFee.Text <> String.Empty Then
            txtGuaFee.Text = txtFee.Text
            'End If

            Me.dateReFeeTime.Enabled = False
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    Private Function CaculateGuaranteeOfServiceType(ByVal GuaranSum As Double, ByVal month As Integer) As Double '计算各个品种的担保费 GuaranSum为万元
        If txtStandard.Text = String.Empty Then
            Return 0
        End If
        'If "06,08".IndexOf(GetServicetypeCode(txtServiceType.Text)) >= 0 Then     '保函品种
        '    If month <= 6 Then
        '        Return GuaranSum * CDbl(txtStandard.Text) * 6 / 100 / 12
        '    ElseIf month <= 12 Then
        '        Return GuaranSum * CDbl(txtStandard.Text) * 12 / 100 / 12
        '    ElseIf month > 12 Then
        '        Return GuaranSum * CDbl(txtStandard.Text) * month / 100 / 12
        '    End If
        'ElseIf GetServicetypeCode(txtServiceType.Text) = "07" Then  '再担保品种
        '    '计算公式：再担保额度（担保金额）×利率（担保费率）×20％
        '    Return GuaranSum * CDbl(txtStandard.Text) * 0.2 / 100
        'Else '流贷或其它品种
        '    Return GuaranSum * CDbl(txtStandard.Text) * month / 1200
        'End If

        'add   yansm  2013/12/9

        If "06,08" Then                                              '如果是保函，則與日期無關
            Return GuaranSum * CDbl(txtStandard.Text) / 100
        Else
            Return GuaranSum * CDbl(txtStandard.Text) * month / 12 / 100
        End If
    End Function
    Private Function IsInfoEffective() As Boolean
        Try
            If txtGuaFee.Text.Trim = "" Then
                Return False
                'ElseIf CDbl(txtGuaFee.Text) < 0 Then
                '    Return False
            End If
        Catch
            Return False
        End Try
        Return True
    End Function

    Private Sub btnCommit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCommit.Click
        If Not IsInfoEffective() Then
            SWDialogBox.MessageBox.Show("$1003", "担保费用")
            txtGuaFee.Focus()
            Return
        End If
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交")
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If
        'add yansm   2013 12 9
        Dim result As String
        If dsAccount.Tables(0).Rows.Count > 0 Then
            dsAccount.Tables(0).Rows(0)("payout") = IIf(txtGuaFee.Text <> String.Empty, txtGuaFee.Text, DBNull.Value)
            dsAccount.Tables(0).Rows(0)("create_person") = UserName
            dsAccount.Tables(0).Rows(0)("create_date") = Now
        ElseIf CDbl(txtGuaFee.Text) > 0 Then
            Dim now As DateTime = gWs.GetSysTime
            Dim dr As DataRow = dsAccount.Tables(0).NewRow
            With dr
                .Item("project_code") = ProjectCode
                .Item("phase") = "评审"
                .Item("date") = now.Date
                .Item("item_type") = "31"
                .Item("item_code") = "002"
                .Item("payout") = IIf(txtGuaFee.Text <> String.Empty, txtGuaFee.Text, DBNull.Value)
                .Item("create_person") = UserName
                .Item("create_date") = now
            End With
            dsAccount.Tables(0).Rows.Add(dr)
        End If
        bmAccount.EndCurrentEdit()
        If dsAccount.HasChanges Then
            result = gWs.UpdateProjectAccountDetail(dsAccount.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "修改担保费出错", result, "")
                Return
            End If
        End If

        '补收担保费
        Dim dsTempProject As DataSet = gWs.GetProjectInfo("{project_code='" & Me.ProjectCode & "'}")
        If dsTempProject.Tables(0).Rows.Count <> 0 Then
            Dim drProject As DataRow = dsTempProject.Tables(0).Rows(0)
            With drProject
                If Me.chkIsReFee.Checked Then
                    .Item("is_refee") = True
                    .Item("refee_date") = Me.dateReFeeTime.Value.ToShortDateString
                Else
                    .Item("is_refee") = False
                End If
            End With
            If dsTempProject.HasChanges Then
                result = gWs.UpdateProject(dsTempProject.GetChanges)
                If result <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "补收担保费出错", result, "")
                    Return
                End If
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

    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtGuaFee.KeyPress
        Money.Money_KeyPress(sender, e)
    End Sub
    Private Sub txt_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtGuaFee.Enter
        Money.Money_Enter(sender, e)
    End Sub
    Private Sub txt_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtGuaFee.Leave
        Money.Money_Leave(sender, e)
        If txtGuaFee.Text <> String.Empty Then
            If CDbl(txtGuaFee.Text) > MaxFee Then
                SWDialogBox.MessageBox.Show("$X032", MaxFee.ToString("n")) '担保费用已经大于 MaxFee
                txtGuaFee.Text = ""
            End If
        End If
    End Sub

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



    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        If Not gpxBaoHan.Visible Then '非保函品种
            Dim meet As New frmMeetRecordQuery(ProjectCode, txtCorName.Text)
            meet.AllowTransparency = False
            meet.ShowDialog()
        ElseIf gpxMeeting.Visible Then '保函品种且开过评审会
            OpenWord(ProjectCode, Me, txtCorName.Text.Trim & "评审会意见表", True, txtCorName.Text)
        Else
            Dim apply_date As DateTime = Money.GetApplyDate(ProjectCode)
            Dim dsLetter As DataSet = gWs.GetGuaranteeLetter(ProjectCode.Substring(0, 5), apply_date)
            Dim fileProjectCode As String
            If dsLetter.Tables(0).Rows.Count > 0 Then
                fileProjectCode = dsLetter.Tables(0).Rows(0)("project_code") & String.Empty
                OpenWord(fileProjectCode, Me, txtCorName.Text.Trim & "评审会意见表", False, String.Empty)
            End If
        End If
    End Sub

    Public Shared Sub OpenWord(ByVal fileProjectCode As String, ByVal ownerForm As Form, ByVal fileName As String, ByVal hasMeetingRecord As Boolean, ByVal corporation_name As String)
        If hasMeetingRecord Then
            Dim meet As New frmMeetRecordQuery(fileProjectCode, corporation_name)
            meet.AllowTransparency = False
            meet.ShowDialog()
            Return
        End If

        Dim dsFile As DataSet
        Dim i As Int16
        Dim hasFile As Boolean
        Try
            dsFile = gWs.GetProjectFile(fileProjectCode, "011", "45") '"45"："011"
            i = dsFile.Tables(0).Rows.Count
            If i = 0 Then
                hasFile = False
            ElseIf IsDBNull(dsFile.Tables(0).Rows(i - 1)("document")) Then
                hasFile = False
            Else
                hasFile = True
            End If

            If Not hasFile Then
                SWDialogBox.MessageBox.Show("项目" & fileProjectCode & "未上载评审意见表", "系统提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
                Exit Sub
            End If

            ownerForm.Cursor = Cursors.WaitCursor
            Dim dr As DataRow = dsFile.Tables(0).Rows(i - 1)
            Dim data As Byte() = CType(dr.Item("document"), Byte())
            Dim docType As String = dr.Item("file_type").trim
            Dim myFileStream As System.IO.FileStream
            Dim strDocumentPath As String = Application.StartupPath + "\Document"
            If Not System.IO.Directory.Exists(strDocumentPath) Then
                System.IO.Directory.CreateDirectory(strDocumentPath)
            End If
            Dim strPath As String = strDocumentPath + "\" & getLegalFileName(fileName) & "." & docType
            Dim isThread As Boolean = False

            '判断文件是否存在,如果存在则删除;如果删除出错,说明文件已经被另一进程占用了.则不创建新的文件
            If System.IO.File.Exists(strPath) Then
                Try
                    System.IO.File.Delete(strPath)
                Catch
                    isThread = True
                End Try
            End If
            If Not isThread Then
                'myfilestream = New System.IO.FileStream(strPath, IO.FileMode.Create, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite)
                myFileStream = New System.IO.FileStream(strPath, IO.FileMode.Create)
                myFileStream.Write(data, 0, data.Length)
                myFileStream.Close()
            End If


            Dim word1 = New Word.ApplicationClass()
            word1.Application.Documents.Add(strPath)

            word1.Application.Visible = True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            ownerForm.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub chkIsReFee_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkIsReFee.CheckedChanged
        If chkIsReFee.Checked = True Then
            Me.dateReFeeTime.Enabled = True
        Else
            Me.dateReFeeTime.Enabled = False
        End If
    End Sub
End Class
