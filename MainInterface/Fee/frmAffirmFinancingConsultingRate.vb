

Public Class frmAffirmFinancingConsultingRate
    Inherits MainInterface.frmBasic
    Private Const passText As String = "通过"
    Private ProjectCode, TaskID, WorkFlowID As String
    Private dsAccount As DataSet
    Private bmAccount As BindingManagerBase
    Private Const MaxFee As Double = 100000000
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
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtStandard As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSum As System.Windows.Forms.TextBox
    Friend WithEvents txtServiceType As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtConclusion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFee As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFinancingConsultingFee As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtFinancingConsultingRate As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtBaoHanType As System.Windows.Forms.TextBox
    Friend WithEvents txtRebetType As System.Windows.Forms.TextBox
    Friend WithEvents gpxBaoHan As System.Windows.Forms.GroupBox
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    Friend WithEvents txtSigSubBank As System.Windows.Forms.TextBox
    Friend WithEvents txtSigBank As System.Windows.Forms.TextBox
    Friend WithEvents txtRemailSum As System.Windows.Forms.TextBox
    Friend WithEvents txtRunMode As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents gpxMeeting As System.Windows.Forms.GroupBox
    Friend WithEvents grdLetterUsage As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label17 As System.Windows.Forms.Label
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
    Friend WithEvents gpxApplyInfo As System.Windows.Forms.GroupBox
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents ckxPartnerAffirm As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAffirmFinancingConsultingRate))
        Me.txtCorName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtProjectCode = New System.Windows.Forms.TextBox
        Me.gpxMeeting = New System.Windows.Forms.GroupBox
        Me.ckxPartnerAffirm = New System.Windows.Forms.CheckBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtRebetType = New System.Windows.Forms.TextBox
        Me.txtBaoHanType = New System.Windows.Forms.TextBox
        Me.Label38 = New System.Windows.Forms.Label
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtLoanForm = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtEachReturnFee = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtRefundType = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtTerm = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtStandard = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtSum = New System.Windows.Forms.TextBox
        Me.lblSum = New System.Windows.Forms.Label
        Me.txtServiceType = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtConclusion = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFee = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtFinancingConsultingRate = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtFinancingConsultingFee = New System.Windows.Forms.TextBox
        Me.btnCommit = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
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
        Me.Label17 = New System.Windows.Forms.Label
        Me.grdLetterUsage = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtEndDate = New System.Windows.Forms.TextBox
        Me.txtSigSubBank = New System.Windows.Forms.TextBox
        Me.txtSigBank = New System.Windows.Forms.TextBox
        Me.txtRemailSum = New System.Windows.Forms.TextBox
        Me.txtRunMode = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.btnRecord = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.gpxMeeting.SuspendLayout()
        Me.gpxBaoHan.SuspendLayout()
        Me.gpxApplyInfo.SuspendLayout()
        CType(Me.grdLetterUsage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(391, 488)
        Me.btnExit.TabIndex = 3
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.Images.SetKeyName(0, "")
        Me.ImageListBasic.Images.SetKeyName(1, "")
        Me.ImageListBasic.Images.SetKeyName(2, "")
        Me.ImageListBasic.Images.SetKeyName(3, "")
        Me.ImageListBasic.Images.SetKeyName(4, "")
        Me.ImageListBasic.Images.SetKeyName(5, "")
        Me.ImageListBasic.Images.SetKeyName(6, "")
        Me.ImageListBasic.Images.SetKeyName(7, "")
        Me.ImageListBasic.Images.SetKeyName(8, "")
        Me.ImageListBasic.Images.SetKeyName(9, "")
        Me.ImageListBasic.Images.SetKeyName(10, "")
        Me.ImageListBasic.Images.SetKeyName(11, "")
        Me.ImageListBasic.Images.SetKeyName(12, "")
        Me.ImageListBasic.Images.SetKeyName(13, "")
        Me.ImageListBasic.Images.SetKeyName(14, "")
        Me.ImageListBasic.Images.SetKeyName(15, "")
        Me.ImageListBasic.Images.SetKeyName(16, "")
        Me.ImageListBasic.Images.SetKeyName(17, "")
        Me.ImageListBasic.Images.SetKeyName(18, "")
        Me.ImageListBasic.Images.SetKeyName(19, "")
        Me.ImageListBasic.Images.SetKeyName(20, "")
        Me.ImageListBasic.Images.SetKeyName(21, "")
        Me.ImageListBasic.Images.SetKeyName(22, "")
        Me.ImageListBasic.Images.SetKeyName(23, "")
        Me.ImageListBasic.Images.SetKeyName(24, "")
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(224, 8)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(232, 21)
        Me.txtCorName.TabIndex = 41
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 12)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "企业名称"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 12)
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
        '
        'gpxMeeting
        '
        Me.gpxMeeting.Controls.Add(Me.ckxPartnerAffirm)
        Me.gpxMeeting.Controls.Add(Me.Label7)
        Me.gpxMeeting.Controls.Add(Me.txtRebetType)
        Me.gpxMeeting.Controls.Add(Me.txtBaoHanType)
        Me.gpxMeeting.Controls.Add(Me.Label38)
        Me.gpxMeeting.Controls.Add(Me.Label39)
        Me.gpxMeeting.Controls.Add(Me.txtLoanForm)
        Me.gpxMeeting.Controls.Add(Me.Label13)
        Me.gpxMeeting.Controls.Add(Me.txtEachReturnFee)
        Me.gpxMeeting.Controls.Add(Me.Label12)
        Me.gpxMeeting.Controls.Add(Me.txtRefundType)
        Me.gpxMeeting.Controls.Add(Me.Label11)
        Me.gpxMeeting.Controls.Add(Me.txtTerm)
        Me.gpxMeeting.Controls.Add(Me.Label10)
        Me.gpxMeeting.Controls.Add(Me.Label9)
        Me.gpxMeeting.Controls.Add(Me.txtStandard)
        Me.gpxMeeting.Controls.Add(Me.Label8)
        Me.gpxMeeting.Controls.Add(Me.txtSum)
        Me.gpxMeeting.Controls.Add(Me.lblSum)
        Me.gpxMeeting.Controls.Add(Me.txtServiceType)
        Me.gpxMeeting.Controls.Add(Me.Label4)
        Me.gpxMeeting.Controls.Add(Me.txtConclusion)
        Me.gpxMeeting.Controls.Add(Me.Label3)
        Me.gpxMeeting.Controls.Add(Me.txtFee)
        Me.gpxMeeting.Controls.Add(Me.Label1)
        Me.gpxMeeting.Location = New System.Drawing.Point(8, 280)
        Me.gpxMeeting.Name = "gpxMeeting"
        Me.gpxMeeting.Size = New System.Drawing.Size(462, 168)
        Me.gpxMeeting.TabIndex = 42
        Me.gpxMeeting.TabStop = False
        Me.gpxMeeting.Text = "评审会意见"
        '
        'ckxPartnerAffirm
        '
        Me.ckxPartnerAffirm.BackColor = System.Drawing.Color.Gainsboro
        Me.ckxPartnerAffirm.Enabled = False
        Me.ckxPartnerAffirm.ForeColor = System.Drawing.Color.Gainsboro
        Me.ckxPartnerAffirm.Location = New System.Drawing.Point(296, 137)
        Me.ckxPartnerAffirm.Name = "ckxPartnerAffirm"
        Me.ckxPartnerAffirm.Size = New System.Drawing.Size(15, 18)
        Me.ckxPartnerAffirm.TabIndex = 106
        Me.ckxPartnerAffirm.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(208, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 12)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "互   助   会"
        '
        'txtRebetType
        '
        Me.txtRebetType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRebetType.Location = New System.Drawing.Point(296, 112)
        Me.txtRebetType.Name = "txtRebetType"
        Me.txtRebetType.ReadOnly = True
        Me.txtRebetType.Size = New System.Drawing.Size(160, 21)
        Me.txtRebetType.TabIndex = 104
        '
        'txtBaoHanType
        '
        Me.txtBaoHanType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBaoHanType.Location = New System.Drawing.Point(104, 112)
        Me.txtBaoHanType.Name = "txtBaoHanType"
        Me.txtBaoHanType.ReadOnly = True
        Me.txtBaoHanType.Size = New System.Drawing.Size(96, 21)
        Me.txtBaoHanType.TabIndex = 103
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(208, 115)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(77, 12)
        Me.Label38.TabIndex = 100
        Me.Label38.Text = "偿付责任类型"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(8, 115)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(89, 12)
        Me.Label39.TabIndex = 99
        Me.Label39.Text = "保  函  种  类"
        '
        'txtLoanForm
        '
        Me.txtLoanForm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanForm.Location = New System.Drawing.Point(296, 40)
        Me.txtLoanForm.Name = "txtLoanForm"
        Me.txtLoanForm.ReadOnly = True
        Me.txtLoanForm.Size = New System.Drawing.Size(160, 21)
        Me.txtLoanForm.TabIndex = 57
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(208, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(77, 12)
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
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(208, 91)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(89, 12)
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
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 91)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(89, 12)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "还  款  方  式"
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
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(208, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 12)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "担保期限 (月)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(168, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "%/年"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStandard
        '
        Me.txtStandard.BackColor = System.Drawing.Color.Gainsboro
        Me.txtStandard.Location = New System.Drawing.Point(104, 136)
        Me.txtStandard.Name = "txtStandard"
        Me.txtStandard.ReadOnly = True
        Me.txtStandard.Size = New System.Drawing.Size(64, 21)
        Me.txtStandard.TabIndex = 13
        Me.txtStandard.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(89, 12)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "担保费收取标准"
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
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(8, 43)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(89, 12)
        Me.lblSum.TabIndex = 10
        Me.lblSum.Text = "保函额度(万元)"
        Me.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtServiceType
        '
        Me.txtServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtServiceType.Location = New System.Drawing.Point(296, 16)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(160, 21)
        Me.txtServiceType.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 12)
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
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "会  议 结  论"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFee
        '
        Me.txtFee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFee.Location = New System.Drawing.Point(104, 64)
        Me.txtFee.Name = "txtFee"
        Me.txtFee.ReadOnly = True
        Me.txtFee.Size = New System.Drawing.Size(96, 21)
        Me.txtFee.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "应收保证金(元)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(160, 456)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 12)
        Me.Label16.TabIndex = 86
        Me.Label16.Text = "%"
        '
        'txtFinancingConsultingRate
        '
        Me.txtFinancingConsultingRate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtFinancingConsultingRate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFinancingConsultingRate.Location = New System.Drawing.Point(112, 453)
        Me.txtFinancingConsultingRate.Name = "txtFinancingConsultingRate"
        Me.txtFinancingConsultingRate.ReadOnly = True
        Me.txtFinancingConsultingRate.Size = New System.Drawing.Size(40, 21)
        Me.txtFinancingConsultingRate.TabIndex = 85
        Me.txtFinancingConsultingRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 456)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(77, 12)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "融资顾问费率"
        '
        'txtFinancingConsultingFee
        '
        Me.txtFinancingConsultingFee.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtFinancingConsultingFee.Location = New System.Drawing.Point(366, 453)
        Me.txtFinancingConsultingFee.MaxLength = 14
        Me.txtFinancingConsultingFee.Name = "txtFinancingConsultingFee"
        Me.txtFinancingConsultingFee.Size = New System.Drawing.Size(98, 21)
        Me.txtFinancingConsultingFee.TabIndex = 0
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(307, 488)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 2
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 456)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 12)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "应收融资顾问费(元)"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gpxBaoHan
        '
        Me.gpxBaoHan.Controls.Add(Me.gpxApplyInfo)
        Me.gpxBaoHan.Controls.Add(Me.grdLetterUsage)
        Me.gpxBaoHan.Location = New System.Drawing.Point(8, 32)
        Me.gpxBaoHan.Name = "gpxBaoHan"
        Me.gpxBaoHan.Size = New System.Drawing.Size(464, 240)
        Me.gpxBaoHan.TabIndex = 44
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
        Me.gpxApplyInfo.Controls.Add(Me.Label17)
        Me.gpxApplyInfo.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gpxApplyInfo.Location = New System.Drawing.Point(3, 141)
        Me.gpxApplyInfo.Name = "gpxApplyInfo"
        Me.gpxApplyInfo.Size = New System.Drawing.Size(458, 96)
        Me.gpxApplyInfo.TabIndex = 18
        Me.gpxApplyInfo.TabStop = False
        Me.gpxApplyInfo.Text = "申请信息"
        '
        'txtApplyResuiseType
        '
        Me.txtApplyResuiseType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyResuiseType.Location = New System.Drawing.Point(312, 66)
        Me.txtApplyResuiseType.Name = "txtApplyResuiseType"
        Me.txtApplyResuiseType.ReadOnly = True
        Me.txtApplyResuiseType.Size = New System.Drawing.Size(128, 21)
        Me.txtApplyResuiseType.TabIndex = 11
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(224, 69)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(77, 12)
        Me.Label26.TabIndex = 10
        Me.Label26.Text = "责任偿付类型"
        '
        'txtApplyBaoHanType
        '
        Me.txtApplyBaoHanType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyBaoHanType.Location = New System.Drawing.Point(80, 66)
        Me.txtApplyBaoHanType.Name = "txtApplyBaoHanType"
        Me.txtApplyBaoHanType.ReadOnly = True
        Me.txtApplyBaoHanType.Size = New System.Drawing.Size(128, 21)
        Me.txtApplyBaoHanType.TabIndex = 9
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 69)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(53, 12)
        Me.Label25.TabIndex = 8
        Me.Label25.Text = "保函种类"
        '
        'txtApplySubBank
        '
        Me.txtApplySubBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplySubBank.Location = New System.Drawing.Point(312, 41)
        Me.txtApplySubBank.Name = "txtApplySubBank"
        Me.txtApplySubBank.ReadOnly = True
        Me.txtApplySubBank.Size = New System.Drawing.Size(128, 21)
        Me.txtApplySubBank.TabIndex = 7
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(224, 44)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(77, 12)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "支        行"
        '
        'txtApplyBank
        '
        Me.txtApplyBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyBank.Location = New System.Drawing.Point(80, 41)
        Me.txtApplyBank.Name = "txtApplyBank"
        Me.txtApplyBank.ReadOnly = True
        Me.txtApplyBank.Size = New System.Drawing.Size(128, 21)
        Me.txtApplyBank.TabIndex = 5
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 44)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(53, 12)
        Me.Label23.TabIndex = 4
        Me.Label23.Text = "银    行"
        '
        'txtApplyTerm
        '
        Me.txtApplyTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyTerm.Location = New System.Drawing.Point(312, 16)
        Me.txtApplyTerm.Name = "txtApplyTerm"
        Me.txtApplyTerm.Size = New System.Drawing.Size(128, 21)
        Me.txtApplyTerm.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(224, 19)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(83, 12)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "期     限(月)"
        '
        'txtApplySum
        '
        Me.txtApplySum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplySum.Location = New System.Drawing.Point(80, 16)
        Me.txtApplySum.Name = "txtApplySum"
        Me.txtApplySum.ReadOnly = True
        Me.txtApplySum.Size = New System.Drawing.Size(128, 21)
        Me.txtApplySum.TabIndex = 1
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 12)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "额度(万元)"
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
        Me.grdLetterUsage.Size = New System.Drawing.Size(458, 119)
        Me.grdLetterUsage.TabIndex = 17
        Me.grdLetterUsage.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdLetterUsage
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TGuaranteeLetterUsage"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "保函种类"
        Me.DataGridTextBoxColumn1.MappingName = "LetterTypeName"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 110
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "偿付责任类型"
        Me.DataGridTextBoxColumn2.MappingName = "ReimburseName"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 110
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "担保费率(%)"
        Me.DataGridTextBoxColumn3.MappingName = "guarantee_rate"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 90
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "保证金比例"
        Me.DataGridTextBoxColumn4.MappingName = "guarantee_scale"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 90
        '
        'txtEndDate
        '
        Me.txtEndDate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEndDate.Location = New System.Drawing.Point(88, 72)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.ReadOnly = True
        Me.txtEndDate.Size = New System.Drawing.Size(128, 21)
        Me.txtEndDate.TabIndex = 14
        '
        'txtSigSubBank
        '
        Me.txtSigSubBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSigSubBank.Location = New System.Drawing.Point(320, 48)
        Me.txtSigSubBank.Name = "txtSigSubBank"
        Me.txtSigSubBank.ReadOnly = True
        Me.txtSigSubBank.Size = New System.Drawing.Size(136, 21)
        Me.txtSigSubBank.TabIndex = 13
        '
        'txtSigBank
        '
        Me.txtSigBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSigBank.Location = New System.Drawing.Point(88, 48)
        Me.txtSigBank.Name = "txtSigBank"
        Me.txtSigBank.ReadOnly = True
        Me.txtSigBank.Size = New System.Drawing.Size(128, 21)
        Me.txtSigBank.TabIndex = 12
        '
        'txtRemailSum
        '
        Me.txtRemailSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRemailSum.Location = New System.Drawing.Point(320, 16)
        Me.txtRemailSum.Name = "txtRemailSum"
        Me.txtRemailSum.ReadOnly = True
        Me.txtRemailSum.Size = New System.Drawing.Size(136, 21)
        Me.txtRemailSum.TabIndex = 9
        '
        'txtRunMode
        '
        Me.txtRunMode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRunMode.Location = New System.Drawing.Point(88, 16)
        Me.txtRunMode.Name = "txtRunMode"
        Me.txtRunMode.ReadOnly = True
        Me.txtRunMode.Size = New System.Drawing.Size(128, 21)
        Me.txtRunMode.TabIndex = 8
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 12)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "额度到期日"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(224, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(89, 12)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "剩余额度(万元)"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(8, 16)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(53, 12)
        Me.Label19.TabIndex = 4
        Me.Label19.Text = "运作方式"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(224, 48)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(89, 12)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "出  函  支  行"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 12)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "出函银行"
        '
        'btnRecord
        '
        Me.btnRecord.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecord.ImageIndex = 11
        Me.btnRecord.ImageList = Me.ImageListBasic
        Me.btnRecord.Location = New System.Drawing.Point(192, 488)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(108, 23)
        Me.btnRecord.TabIndex = 1
        Me.btnRecord.Text = "评审会结论(&M)"
        Me.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSigBank)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtSigSubBank)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.txtRunMode)
        Me.GroupBox1.Controls.Add(Me.txtEndDate)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtRemailSum)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 513)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 100)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        Me.GroupBox1.Visible = False
        '
        'frmAffirmFinancingConsultingRate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(482, 519)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRecord)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.gpxBaoHan)
        Me.Controls.Add(Me.txtFinancingConsultingFee)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.gpxMeeting)
        Me.Controls.Add(Me.txtCorName)
        Me.Controls.Add(Me.txtProjectCode)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtFinancingConsultingRate)
        Me.Controls.Add(Me.Label16)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAffirmFinancingConsultingRate"
        Me.Text = "确认保证金收费标准"
        Me.Controls.SetChildIndex(Me.Label16, 0)
        Me.Controls.SetChildIndex(Me.txtFinancingConsultingRate, 0)
        Me.Controls.SetChildIndex(Me.Label15, 0)
        Me.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.Controls.SetChildIndex(Me.txtCorName, 0)
        Me.Controls.SetChildIndex(Me.gpxMeeting, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.txtFinancingConsultingFee, 0)
        Me.Controls.SetChildIndex(Me.gpxBaoHan, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.btnRecord, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.gpxMeeting.ResumeLayout(False)
        Me.gpxMeeting.PerformLayout()
        Me.gpxBaoHan.ResumeLayout(False)
        Me.gpxApplyInfo.ResumeLayout(False)
        Me.gpxApplyInfo.PerformLayout()
        CType(Me.grdLetterUsage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    '或取项目保函协议信息
    Private Sub ShowBaoHanInfo(ByVal dr As DataRow)
        gpxBaoHan.Visible = True
        'If Not dr Is Nothing Then
        '    '保函种类和责任偿还类型
        '    If Not IsDBNull(dr("guarantee_letter_type")) Then
        '        Dim dsTemp As DataSet = gWs.GetGuaranteeLetterType(dr("guarantee_letter_type").ToString)
        '        txtBaoHanType.Text = dsTemp.Tables(0).Rows(0)("name")
        '        dsTemp = Nothing
        '    End If
        '    If Not IsDBNull(dr("reimburse_type")) Then
        '        Dim dstemp As DataSet = gWs.GetReimburseType(dr("reimburse_type").ToString)
        '        txtRebetType.Text = dsTemp.Tables(0).Rows(0)("name")
        '        dstemp = Nothing
        '    End If
        '    '出函银行
        '    Dim dsBank As DataSet = gWs.GetBankInfo("%", "%")
        '    If Not IsDBNull(dr("bank")) Then
        '        txtSigBank.Text = dsBank.Tables("bank").Select("bank_code='" & dr("bank").ToString & "'")(0)("bank_name").ToString
        '        '出函支行
        '        If Not IsDBNull(dr("bank_branch")) Then
        '            txtSigSubBank.Text = dsBank.Tables("bank_branch").Select("bank_code='" & dr("bank").ToString & "' AND branch_bank_code='" & dr("bank_branch").ToString & "'")(0)("branch_bank_name").ToString
        '        End If
        '    End If
        '    dsBank.Dispose()
        '    '剩余额度，额度到期日
        '    Dim CorCode As String = ProjectCode.Substring(0, 5)
        '    Dim dsLetter As DataSet = gWs.GetCommonQueryInfo("SELECT * FROM dbo.Guarantee_letter_EX WHERE corporation_code='" & CorCode & "'")
        '    If dsLetter.Tables(0).Rows.Count > 0 Then
        '        Dim odr As DataRow = dsLetter.Tables(0).Rows(0)
        '        txtRemailSum.Text = odr("remnant_line") & ""
        '        If Not IsDBNull(odr("enddate")) Then
        '            txtEndDate.Text = String.Format("{0,11:yyyy年M月d日}", odr("enddate"))
        '        End If
        '    End If
        '    dsLetter.Dispose()
        'End If
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

    '确认收取保证金
    Private Sub FAffirmSecurityFee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ProjectCode = MyBase.getProjectCode
            TaskID = MyBase.getTaskID
            WorkFlowID = MyBase.getWorkFlowID
            txtProjectCode.Text = ProjectCode : txtCorName.Text = MyBase.getCorporationName

            dsAccount = gWs.GetProjectAccountDetailInfo("{project_code LIKE '" & ProjectCode & "' AND item_type='34' AND item_code='009' AND LTRIM(RTRIM(phase))= '评审' AND NOT payout IS NULL ORDER BY serial_num DESC}")
            bmAccount = BindingContext(dsAccount, "project_account_detail")
            txtFinancingConsultingFee.DataBindings.Add("Text", dsAccount, "project_account_detail.payout")

            If bmAccount.Count > 0 Then
                bmAccount.Position = 0
            End If

            Dim dsTrial As DataSet = gWs.GetConfTrialInfo("{project_code LIKE '" & ProjectCode & "' ORDER BY trial_times DESC}", "null") 'AND trial_conclusion LIKE '%" & passText & "%' 
            txtConclusion.DataBindings.Add("Text", dsTrial, "conference_trial.trial_conclusion")
            txtSum.DataBindings.Add("Text", dsTrial, "conference_trial.guarantee_sum")
            txtServiceType.DataBindings.Add("Text", dsTrial, "conference_trial.service_type")
            txtStandard.DataBindings.Add("Text", dsTrial, "conference_trial.guarantee_rate")
            txtLoanForm.DataBindings.Add("Text", dsTrial, "conference_trial.loan_provide_form")
            txtTerm.DataBindings.Add("Text", dsTrial, "conference_trial.terms")
            txtRefundType.DataBindings.Add("Text", dsTrial, "conference_trial.refund_type")
            txtEachReturnFee.DataBindings.Add("Text", dsTrial, "conference_trial.refund_sum_average")

            Dim strWorkFlow As String
            '如果业务评种是保函非综合授信
            If txtServiceType.Text <> String.Empty Then
                strWorkFlow = dsTrial.Tables("conference_trial").Rows(0)("workflow") & ""
                If GetServicetypeCode(txtServiceType.Text) <> "08" AndAlso GetServicetypeCode(txtServiceType.Text) = "06" Then   '非保函综合授信的保函业务品种，如果是额度项下保函
                    txtRunMode.Text = strWorkFlow
                    ShowBaoHanInfo(dsTrial.Tables("conference_trial").Rows(0))
                End If
                txtFinancingConsultingRate.DataBindings.Add("Text", dsTrial, "conference_trial.FinancingConsultingRate")
                '有开过会议则不需要显示申请信息
                gpxApplyInfo.Visible = False
                gpxBaoHan.Height -= gpxApplyInfo.Height
                Me.Height -= gpxApplyInfo.Height
            Else '该项目没有上过会，有可能是保函品种，因此去project查看运作方式
                '从project表读取保证金比例，如有则采用
                Dim dsProject As DataSet = gWs.GetProjectInfo(ProjectCode)
                If Not IsDBNull(dsProject.Tables(0).Rows(0)("security_rate")) Then
                    txtFinancingConsultingRate.Text = Format(dsProject.Tables(0).Rows(0)("FinancingConsultingRate"), "n")
                End If
                If dsProject.Tables(0).Rows.Count > 0 Then
                    strWorkFlow = dsProject.Tables(0).Rows(0)("workflow") & ""
                    If "06,08".IndexOf(GetServicetypeCode(dsProject.Tables(0).Rows(0)("apply_service_type") & "")) >= 0 Then
                        txtRunMode.Text = strWorkFlow
                        ShowBaoHanInfo(Nothing)
                    End If
                End If
                dsProject.Dispose()
                '不需显示会议方框
                gpxMeeting.Visible = False
                Me.Height -= gpxMeeting.Height
            End If
            Me.Height -= IIf(gpxBaoHan.Visible, 0, gpxBaoHan.Height)
            If gpxMeeting.Visible Then
                Me.gpxMeeting.Location = IIf(Me.gpxBaoHan.Visible, New Point(gpxBaoHan.Left, gpxBaoHan.Top + gpxBaoHan.Height + 5), Me.gpxBaoHan.Location)
                '增加显示互助会确认是否采用
                Dim dsPartner As DataSet = gWs.GetProjectGuaranteeForm("{project_code LIKE '" & ProjectCode & "' AND guarantee_form LIKE '%互助%'}")
                Dim rows() As DataRow = dsPartner.Tables(0).Select("is_used=1")
                ckxPartnerAffirm.Checked = rows.Length > 0
                dsPartner.Dispose()
            End If

            Dim sum As Double
            If txtSum.Text <> String.Empty Then
                sum = CDbl(txtSum.Text)
            ElseIf txtApplySum.Text <> String.Empty Then
                sum = CDbl(txtApplySum.Text)
            End If

            txtFee.Text = (sum * 100 * CDbl(IIf(txtFinancingConsultingRate.Text = String.Empty, 0, txtFinancingConsultingRate.Text))).ToString("n")
            txtFinancingConsultingFee.Text = txtFee.Text

            AddHandler txtFinancingConsultingFee.Enter, AddressOf Money_Enter
            AddHandler txtFinancingConsultingFee.KeyPress, AddressOf Money_KeyPress
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Overloads Function GetServicetypeCode(ByVal service_type_name As String) As String
        Dim dsServiceType As DataSet = gWs.GetServiceType("%")
        Dim table As DataTable = dsServiceType.Tables(0)
        Dim drs() As DataRow = table.Select("service_type='" & service_type_name & "'")
        If drs.Length > 0 Then
            Return drs(0)("service_type_code").ToString
        End If
        Return "Nothing"
    End Function

    Private Sub txt_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtFinancingConsultingFee.Leave
        Money.Money_Leave(sender, e)
        If txtFinancingConsultingFee.Text <> String.Empty Then
            If CDbl(txtFinancingConsultingFee.Text) > MaxFee Then
                SWDialogBox.MessageBox.Show("$X032", MaxFee.ToString("n"))
                txtFinancingConsultingFee.Text = ""
            End If
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Function IsInfoEffective() As Boolean
        Try
            If txtFinancingConsultingFee.Text.Trim = "" Then
                Return False
            End If
        Catch
            Return False
        End Try
        Return True
    End Function

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If Not IsInfoEffective() Then
            SWDialogBox.MessageBox.Show("$1003", "保证金额")
            txtFinancingConsultingFee.Focus()
            Return
        End If

        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交")
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If

        Dim result As String
        If dsAccount.Tables(0).Rows.Count > 0 Then
            dsAccount.Tables(0).Rows(0)("payout") = IIf(txtFinancingConsultingFee.Text <> String.Empty, txtFinancingConsultingFee.Text, DBNull.Value)
        ElseIf CDbl(txtFinancingConsultingFee.Text) > 0 Then
            Dim now As DateTime = gWs.GetSysTime
            Dim dr As DataRow = dsAccount.Tables(0).NewRow
            With dr
                .Item("project_code") = ProjectCode
                .Item("phase") = "评审"
                .Item("date") = now.Date
                .Item("item_type") = "34"
                .Item("item_code") = "009"
                .Item("payout") = IIf(txtFinancingConsultingFee.Text <> String.Empty, txtFinancingConsultingFee.Text, DBNull.Value)
                .Item("create_person") = UserName
                .Item("create_date") = now
            End With
            dsAccount.Tables(0).Rows.Add(dr)
        End If
        bmAccount.EndCurrentEdit()
        If dsAccount.HasChanges Then
            result = gWs.UpdateProjectAccountDetail(dsAccount.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "修改保证金出错", result, "")
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
End Class
