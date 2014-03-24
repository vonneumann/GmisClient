Public Class frmMeetRecordQuery
    Inherits Form
    Private ProjectCode As String
    Private CorporationName As String
    Private dsConTrial As DataSet
    Private cmConTrial As CurrencyManager
    Private cmOpinion As CurrencyManager
    Private dsGuaForm As DataSet    '反担保措施
    Private dsProCor As DataSet     '保证企业
    Private dsPerson As DataSet     '个人保证
    Private dsGuaranty As DataSet   '具体反担保物
    Private cmLocal As CurrencyManager '绑定反担保措施
    Private dsAdditionalForm As DataSet '附加方式
    Private GuaType As String = "total"
    'Private dsAccount As DataSet
    Private times As Integer
    Private IsPass As Boolean = False
    Private dsConference As DataSet
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub
    Public Sub New(ByVal _ProjectCode As String, ByVal _CorporationName As String)
        MyBase.New()
        InitializeComponent()
        ProjectCode = _ProjectCode
        CorporationName = _CorporationName
    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsConference Is Nothing Then
            dsConference.Dispose()
        End If
        If Not dsConTrial Is Nothing Then
            dsConTrial.Dispose()
        End If
        If Not dsGuaForm Is Nothing Then
            dsGuaForm.Dispose()
        End If
        If Not dsProCor Is Nothing Then
            dsProCor.Dispose()
        End If
        If Not dsPerson Is Nothing Then
            dsPerson.Dispose()
        End If
        If Not dsGuaranty Is Nothing Then
            dsGuaranty.Dispose()
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
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Public WithEvents txtCorName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEachReturn As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtGuaSum As System.Windows.Forms.TextBox
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents txtServiceType As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtConclusion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtOpinion As System.Windows.Forms.TextBox
    Friend WithEvents dgOpinion As System.Windows.Forms.DataGrid
    Friend WithEvents dgParent As System.Windows.Forms.DataGrid
    Friend WithEvents dgDetail As System.Windows.Forms.DataGrid
    Friend WithEvents cmbxTimes As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents tpConclusion As System.Windows.Forms.TabPage
    Friend WithEvents tpGuaranty As System.Windows.Forms.TabPage
    Public WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents lblRate As System.Windows.Forms.Label
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtScaleRate As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDescription2 As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription2 As System.Windows.Forms.Label
    Friend WithEvents txtDescription1 As System.Windows.Forms.TextBox
    Friend WithEvents lblDescription1 As System.Windows.Forms.Label
    Friend WithEvents lblTerm As System.Windows.Forms.Label
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents cklbxAdditionalForm As System.Windows.Forms.CheckedListBox
    Friend WithEvents gpbxOppGua As System.Windows.Forms.GroupBox
    Friend WithEvents gpxAdditionalForm As System.Windows.Forms.GroupBox
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Public WithEvents ImageListBasic As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMeetRecordQuery))
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.tpConclusion = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtScaleRate = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEachReturn = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtGuaSum = New System.Windows.Forms.TextBox()
        Me.lblSum = New System.Windows.Forms.Label()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.lblTerm = New System.Windows.Forms.Label()
        Me.txtDescription2 = New System.Windows.Forms.TextBox()
        Me.lblDescription2 = New System.Windows.Forms.Label()
        Me.txtDescription1 = New System.Windows.Forms.TextBox()
        Me.lblDescription1 = New System.Windows.Forms.Label()
        Me.txtServiceType = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtConclusion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgOpinion = New System.Windows.Forms.DataGrid()
        Me.txtOpinion = New System.Windows.Forms.TextBox()
        Me.tpGuaranty = New System.Windows.Forms.TabPage()
        Me.gpxAdditionalForm = New System.Windows.Forms.GroupBox()
        Me.cklbxAdditionalForm = New System.Windows.Forms.CheckedListBox()
        Me.gpbxOppGua = New System.Windows.Forms.GroupBox()
        Me.dgParent = New System.Windows.Forms.DataGrid()
        Me.dgDetail = New System.Windows.Forms.DataGrid()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.cmbxTimes = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.ImageListBasic = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl.SuspendLayout()
        Me.tpConclusion.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgOpinion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpGuaranty.SuspendLayout()
        Me.gpxAdditionalForm.SuspendLayout()
        Me.gpbxOppGua.SuspendLayout()
        CType(Me.dgParent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.TabControl.Controls.AddRange(New System.Windows.Forms.Control() {Me.tpConclusion, Me.tpGuaranty})
        Me.TabControl.Location = New System.Drawing.Point(8, 88)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(640, 384)
        Me.TabControl.TabIndex = 0
        '
        'tpConclusion
        '
        Me.tpConclusion.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.GroupBox1})
        Me.tpConclusion.Location = New System.Drawing.Point(4, 21)
        Me.tpConclusion.Name = "tpConclusion"
        Me.tpConclusion.Size = New System.Drawing.Size(632, 359)
        Me.tpConclusion.TabIndex = 0
        Me.tpConclusion.Text = "评审会意见"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label12, Me.txtScaleRate, Me.Label6, Me.Label11, Me.txtRate, Me.lblRate, Me.txtRemark, Me.Label13, Me.txtEachReturn, Me.Label10, Me.txtGuaSum, Me.lblSum, Me.txtTerm, Me.lblTerm, Me.txtDescription2, Me.lblDescription2, Me.txtDescription1, Me.lblDescription1, Me.txtServiceType, Me.Label7, Me.txtConclusion, Me.Label5})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(616, 152)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(592, 67)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 14)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "%"
        '
        'txtScaleRate
        '
        Me.txtScaleRate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtScaleRate.Location = New System.Drawing.Point(456, 64)
        Me.txtScaleRate.Name = "txtScaleRate"
        Me.txtScaleRate.ReadOnly = True
        Me.txtScaleRate.Size = New System.Drawing.Size(128, 21)
        Me.txtScaleRate.TabIndex = 73
        Me.txtScaleRate.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(384, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 14)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "保证金比例"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(336, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 14)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "%/年"
        '
        'txtRate
        '
        Me.txtRate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRate.Location = New System.Drawing.Point(264, 64)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.ReadOnly = True
        Me.txtRate.Size = New System.Drawing.Size(72, 21)
        Me.txtRate.TabIndex = 70
        Me.txtRate.Text = ""
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Location = New System.Drawing.Point(184, 67)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(72, 14)
        Me.lblRate.TabIndex = 69
        Me.lblRate.Text = "担 保 费 率"
        '
        'txtRemark
        '
        Me.txtRemark.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRemark.Location = New System.Drawing.Point(96, 90)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ReadOnly = True
        Me.txtRemark.Size = New System.Drawing.Size(512, 56)
        Me.txtRemark.TabIndex = 68
        Me.txtRemark.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 111)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 14)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "备       注"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEachReturn
        '
        Me.txtEachReturn.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEachReturn.Location = New System.Drawing.Point(96, 64)
        Me.txtEachReturn.Name = "txtEachReturn"
        Me.txtEachReturn.ReadOnly = True
        Me.txtEachReturn.Size = New System.Drawing.Size(80, 21)
        Me.txtEachReturn.TabIndex = 59
        Me.txtEachReturn.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 14)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "每次还款额(元)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGuaSum
        '
        Me.txtGuaSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuaSum.Location = New System.Drawing.Point(96, 39)
        Me.txtGuaSum.Name = "txtGuaSum"
        Me.txtGuaSum.ReadOnly = True
        Me.txtGuaSum.Size = New System.Drawing.Size(80, 21)
        Me.txtGuaSum.TabIndex = 57
        Me.txtGuaSum.Text = ""
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(8, 42)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(91, 14)
        Me.lblSum.TabIndex = 56
        Me.lblSum.Text = "担保金额(万元)"
        Me.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTerm
        '
        Me.txtTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerm.Location = New System.Drawing.Point(264, 14)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.ReadOnly = True
        Me.txtTerm.Size = New System.Drawing.Size(104, 21)
        Me.txtTerm.TabIndex = 55
        Me.txtTerm.Text = ""
        '
        'lblTerm
        '
        Me.lblTerm.AutoSize = True
        Me.lblTerm.Location = New System.Drawing.Point(184, 17)
        Me.lblTerm.Name = "lblTerm"
        Me.lblTerm.Size = New System.Drawing.Size(79, 14)
        Me.lblTerm.TabIndex = 54
        Me.lblTerm.Text = "担保期限(月)"
        Me.lblTerm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription2
        '
        Me.txtDescription2.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescription2.Location = New System.Drawing.Point(456, 39)
        Me.txtDescription2.Name = "txtDescription2"
        Me.txtDescription2.ReadOnly = True
        Me.txtDescription2.Size = New System.Drawing.Size(152, 21)
        Me.txtDescription2.TabIndex = 53
        Me.txtDescription2.Text = ""
        '
        'lblDescription2
        '
        Me.lblDescription2.AutoSize = True
        Me.lblDescription2.Location = New System.Drawing.Point(384, 42)
        Me.lblDescription2.Name = "lblDescription2"
        Me.lblDescription2.Size = New System.Drawing.Size(54, 14)
        Me.lblDescription2.TabIndex = 52
        Me.lblDescription2.Text = "还款方式"
        Me.lblDescription2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescription1
        '
        Me.txtDescription1.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDescription1.Location = New System.Drawing.Point(264, 39)
        Me.txtDescription1.Name = "txtDescription1"
        Me.txtDescription1.ReadOnly = True
        Me.txtDescription1.Size = New System.Drawing.Size(104, 21)
        Me.txtDescription1.TabIndex = 51
        Me.txtDescription1.Text = ""
        '
        'lblDescription1
        '
        Me.lblDescription1.AutoSize = True
        Me.lblDescription1.Location = New System.Drawing.Point(184, 42)
        Me.lblDescription1.Name = "lblDescription1"
        Me.lblDescription1.Size = New System.Drawing.Size(72, 14)
        Me.lblDescription1.TabIndex = 50
        Me.lblDescription1.Text = "放 款 方 式"
        Me.lblDescription1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtServiceType
        '
        Me.txtServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtServiceType.Location = New System.Drawing.Point(456, 14)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(152, 21)
        Me.txtServiceType.TabIndex = 43
        Me.txtServiceType.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(384, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 14)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "业务品种"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtConclusion
        '
        Me.txtConclusion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConclusion.Location = New System.Drawing.Point(96, 14)
        Me.txtConclusion.Name = "txtConclusion"
        Me.txtConclusion.ReadOnly = True
        Me.txtConclusion.Size = New System.Drawing.Size(80, 21)
        Me.txtConclusion.TabIndex = 39
        Me.txtConclusion.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 14)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "评审会议意见"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgOpinion, Me.txtOpinion})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 192)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dgOpinion
        '
        Me.dgOpinion.CaptionVisible = False
        Me.dgOpinion.DataMember = ""
        Me.dgOpinion.Dock = System.Windows.Forms.DockStyle.Left
        Me.dgOpinion.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgOpinion.Location = New System.Drawing.Point(3, 17)
        Me.dgOpinion.Name = "dgOpinion"
        Me.dgOpinion.ReadOnly = True
        Me.dgOpinion.Size = New System.Drawing.Size(189, 172)
        Me.dgOpinion.TabIndex = 0
        '
        'txtOpinion
        '
        Me.txtOpinion.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtOpinion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOpinion.Location = New System.Drawing.Point(192, 17)
        Me.txtOpinion.Multiline = True
        Me.txtOpinion.Name = "txtOpinion"
        Me.txtOpinion.ReadOnly = True
        Me.txtOpinion.Size = New System.Drawing.Size(416, 172)
        Me.txtOpinion.TabIndex = 1
        Me.txtOpinion.Text = ""
        '
        'tpGuaranty
        '
        Me.tpGuaranty.Controls.AddRange(New System.Windows.Forms.Control() {Me.gpxAdditionalForm, Me.gpbxOppGua, Me.dgDetail})
        Me.tpGuaranty.Location = New System.Drawing.Point(4, 21)
        Me.tpGuaranty.Name = "tpGuaranty"
        Me.tpGuaranty.Size = New System.Drawing.Size(632, 359)
        Me.tpGuaranty.TabIndex = 2
        Me.tpGuaranty.Text = "反担保措施"
        '
        'gpxAdditionalForm
        '
        Me.gpxAdditionalForm.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.gpxAdditionalForm.Controls.AddRange(New System.Windows.Forms.Control() {Me.cklbxAdditionalForm})
        Me.gpxAdditionalForm.Location = New System.Drawing.Point(8, 184)
        Me.gpxAdditionalForm.Name = "gpxAdditionalForm"
        Me.gpxAdditionalForm.Size = New System.Drawing.Size(616, 72)
        Me.gpxAdditionalForm.TabIndex = 3
        Me.gpxAdditionalForm.TabStop = False
        Me.gpxAdditionalForm.Text = "附加反担保措施"
        '
        'cklbxAdditionalForm
        '
        Me.cklbxAdditionalForm.CheckOnClick = True
        Me.cklbxAdditionalForm.ColumnWidth = 100
        Me.cklbxAdditionalForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cklbxAdditionalForm.Location = New System.Drawing.Point(3, 17)
        Me.cklbxAdditionalForm.MultiColumn = True
        Me.cklbxAdditionalForm.Name = "cklbxAdditionalForm"
        Me.cklbxAdditionalForm.Size = New System.Drawing.Size(610, 52)
        Me.cklbxAdditionalForm.TabIndex = 4
        '
        'gpbxOppGua
        '
        Me.gpbxOppGua.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.gpbxOppGua.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgParent})
        Me.gpbxOppGua.Location = New System.Drawing.Point(8, 8)
        Me.gpbxOppGua.Name = "gpbxOppGua"
        Me.gpbxOppGua.Size = New System.Drawing.Size(616, 176)
        Me.gpbxOppGua.TabIndex = 2
        Me.gpbxOppGua.TabStop = False
        Me.gpbxOppGua.Text = "独立反担保措施"
        '
        'dgParent
        '
        Me.dgParent.CaptionVisible = False
        Me.dgParent.DataMember = ""
        Me.dgParent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgParent.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgParent.Location = New System.Drawing.Point(3, 17)
        Me.dgParent.Name = "dgParent"
        Me.dgParent.Size = New System.Drawing.Size(610, 156)
        Me.dgParent.TabIndex = 0
        '
        'dgDetail
        '
        Me.dgDetail.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.dgDetail.CaptionVisible = False
        Me.dgDetail.DataMember = ""
        Me.dgDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDetail.Location = New System.Drawing.Point(8, 264)
        Me.dgDetail.Name = "dgDetail"
        Me.dgDetail.Size = New System.Drawing.Size(616, 88)
        Me.dgDetail.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "上会日期"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(184, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "上会次数"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 0
        Me.btnExit.ImageList = Me.ImageListBasic
        Me.btnExit.Location = New System.Drawing.Point(544, 480)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtDate, Me.cmbxTimes, Me.Label3, Me.Label4, Me.Label2, Me.Label1, Me.txtProjectCode, Me.txtCorName})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(640, 72)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'txtDate
        '
        Me.txtDate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtDate.Location = New System.Drawing.Point(72, 40)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.Size = New System.Drawing.Size(96, 21)
        Me.txtDate.TabIndex = 73
        Me.txtDate.Text = ""
        '
        'cmbxTimes
        '
        Me.cmbxTimes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxTimes.Location = New System.Drawing.Point(248, 40)
        Me.cmbxTimes.Name = "cmbxTimes"
        Me.cmbxTimes.Size = New System.Drawing.Size(48, 20)
        Me.cmbxTimes.TabIndex = 72
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "项目编码"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(184, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "企业名称"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(72, 16)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 42
        Me.txtProjectCode.Text = ""
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(248, 16)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(240, 21)
        Me.txtCorName.TabIndex = 43
        Me.txtCorName.Text = ""
        '
        'btnReport
        '
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Bitmap)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.ImageIndex = 1
        Me.btnReport.ImageList = Me.ImageListBasic
        Me.btnReport.Location = New System.Drawing.Point(408, 480)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(128, 23)
        Me.btnReport.TabIndex = 3
        Me.btnReport.Text = "查看评审意见表(&R)"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageListBasic.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmMeetRecordQuery
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(656, 509)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnReport, Me.GroupBox2, Me.btnExit, Me.TabControl})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMeetRecordQuery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "会议结论"
        Me.TabControl.ResumeLayout(False)
        Me.tpConclusion.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgOpinion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpGuaranty.ResumeLayout(False)
        Me.gpxAdditionalForm.ResumeLayout(False)
        Me.gpbxOppGua.ResumeLayout(False)
        CType(Me.dgParent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GetDataSourceOfMeeting()
        dsConTrial = New DataSet()
        dsConTrial = gWs.GetConfTrialInfo("{project_code LIKE '" & ProjectCode & "' AND (NOT conference_code IS NULL)}", "{project_code LIKE '" & ProjectCode & "'}")
        If dsConTrial.Tables("conference_trial").Rows.Count = 0 Then Return '没有会议记录
        '增加“角色”列
        dsConTrial.Tables("committeeman_opinion").Columns.Add("RoleName", GetType(String), "IIf(role_id LIKE '28', '主评', '评委')")
        cmConTrial = BindingContext(dsConTrial, "conference_trial")
        cmOpinion = BindingContext(dsConTrial, "committeeman_opinion")
        '绑定会议评审意见
        txtConclusion.DataBindings.Add(New Binding("Text", dsConTrial, "conference_trial.trial_conclusion"))
        '绑定评委意见到文本框
        txtOpinion.DataBindings.Add(New Binding("Text", dsConTrial, "committeeman_opinion.opinion"))
        txtRemark.DataBindings.Add(New Binding("Text", dsConTrial, "conference_trial.Remark"))
        '绑定评委
        dgOpinion.DataMember = "committeeman_opinion"
        dgOpinion.DataSource = dsConTrial
        AddTableStyleForOpinion()

        Dim ConCodeList As String = ""
        Dim i As Integer
        For i = dsConTrial.Tables("conference_trial").Rows.Count - 1 To 0 Step -1
            cmbxTimes.Items.Add(dsConTrial.Tables("conference_trial").Rows(i)("trial_times"))
            '取得会议编码列表
            If Not IsDBNull(dsConTrial.Tables("conference_trial").Rows(i)("conference_code")) Then
                ConCodeList += dsConTrial.Tables("conference_trial").Rows(i)("conference_code") & ","
            End If
        Next
        cmbxTimes.SelectedIndex = 0
        If ConCodeList.Trim <> String.Empty Then
            dsConference = gWs.GetConferenceInfo("{conference_code IN (" & ConCodeList.Substring(0, ConCodeList.Length - 1) & ")}", "null")
        End If
    End Sub

    'Private Sub GetDataSourceOfAccount()
    '    '放款计划
    '    Dim item_type, item_code As String
    '    item_type = "34" : item_code = "008"
    '    dsAccount = New DataSet()
    '    dsAccount = gWs.GetProjectAccountDetailInfo("{project_code='" & ProjectCode & "' and item_type='" & item_type & "' and  item_code='" & item_code & "'}")
    '    dsAccount.Tables("project_account_detail").Columns.Add("FalseMoney", GetType(String), "income/10000")
    '    dgLoan.DataSource = dsAccount.Tables("project_account_detail").DefaultView
    'AddTableStyleForLoan()
    'End Sub
    Private Sub GetDatasourceOfGuaranty()
        dsGuaForm = gWs.GetProjectGuaranteeForm("{project_code LIKE '" & ProjectCode & "'}")
        If dsGuaForm.Tables(0).Rows.Count = 0 Then Return

        dsProCor = gWs.FetchProjectCorporation(ProjectCode, "%", "2", "%")
        dsPerson = gWs.GetOppositeGuaranteeAssurerInfo("{project_code LIKE '" & ProjectCode & "'}")
        dsGuaranty = gWs.GetGuarantyInfo("{project_code LIKE '" & ProjectCode & "' ORDER BY opposite_guarantee_form}", "null")
        Dim dsItemType As DataSet = gWs.GetItemType("%") '

        dsPerson.Tables("opposite_guarantee_assurer").Columns.Add("is_used", GetType(Boolean), "IIf(status='评审通过',true,false)")
        dsProCor.Tables("TProjectCorporation").Columns.Add("is_used", GetType(Boolean), "IIf(status='评审通过',true,false)")
        dsGuaranty.Tables("opposite_guarantee").Columns.Add("is_used", GetType(Boolean), "IIf(status='评审通过' OR status='抵押质押' OR status='解除',true,false)")
        dsGuaranty.Tables("opposite_guarantee").Columns.Add("ItemName", GetType(String))
        dsGuaForm.Tables("TProjectGuaranteeForm").Columns.Add("ItemName", GetType(String))
        Dim dr As DataRow
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
        If dsGuaForm.HasChanges Then
            dsGuaForm.AcceptChanges()
        End If
        ''''''''''删除没有采用的反担保物'''''''''''''''''''
        dgParent.DataMember = "TProjectGuaranteeForm"
        dgParent.DataSource = dsGuaForm
        AddTableStyleForOppGua()
        cmLocal = BindingContext(dsGuaForm, "TProjectGuaranteeForm")
        CType(cmLocal.List, DataView).AllowDelete = False
        CType(cmLocal.List, DataView).AllowNew = False
        AddHandler cmLocal.PositionChanged, AddressOf cm_PositionChanged
        cm_PositionChanged(Nothing, Nothing)
    End Sub

    Private Sub DisableShow(ByVal sender As Object, ByVal e As PaintEventArgs)
        Me.Visible = False
    End Sub

    Private Sub frm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        txtCorName.Text = CorporationName : txtProjectCode.Text = ProjectCode
        Try
            GetDataSourceOfMeeting()
            If cmbxTimes.SelectedIndex < 0 Then
                SWDialogBox.MessageBox.Show("$X012")
                'MessageBox.Show("该项目并不存在会议评审记录", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                AddHandler Me.Paint, AddressOf DisableShow
                Return
            End If
            'GetDataSourceOfAccount()
            GetDatasourceOfGuaranty()
            AddHandler cmbxTimes.TextChanged, AddressOf cmbx_IndexChanged
            AddHandler cmbxTimes.SelectedIndexChanged, AddressOf cmbx_IndexChanged
            cmbx_IndexChanged(sender, e)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Me.AllowTransparency = False
    End Sub

    Private Sub cmbx_IndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        times = CInt(cmbxTimes.Text)
        Dim dr As DataRow = dsConTrial.Tables("conference_trial").Select("trial_times=" & times)(0)
        'Dim ConCode As Integer = CInt(dr("conference_code"))
        IsPass = dr("trial_conclusion") & "" <> "暂缓"
        SetBinding(IsPass)
        CType(cmConTrial.List, DataView).RowFilter = "trial_times=" & times
        CType(cmOpinion.List, DataView).RowFilter = "trial_times=" & times
        If Not IsDBNull(dr("conference_code")) Then
            txtDate.Text = CDate(dsConference.Tables("conference").Select("conference_code=" & dr("conference_code"))(0)("conference_date")).ToString("yyyy年M月d日")
        Else
            txtDate.Text = String.Empty
        End If
        If IsPass Then
            If TabControl.TabPages.IndexOf(tpGuaranty) < 0 Then
                'TabControl.TabPages.Add(tpLoan)
                TabControl.TabPages.Add(tpGuaranty)
            End If
        Else
            'TabControl.TabPages.Remove(tpLoan)
            TabControl.TabPages.Remove(tpGuaranty)
        End If
    End Sub

    Private Sub SetBinding(ByVal value As Boolean)
        If value Then
            If txtGuaSum.DataBindings.Count <> 0 Then Return
            txtGuaSum.DataBindings.Add(New Binding("Text", dsConTrial, "conference_trial.guarantee_sum"))

            txtServiceType.DataBindings.Add(New Binding("Text", dsConTrial, "conference_trial.service_type"))
            txtEachReturn.DataBindings.Add(New Binding("Text", dsConTrial, "conference_trial.refund_sum_average"))
            txtTerm.DataBindings.Add(New Binding("Text", dsConTrial, "conference_trial.terms"))
            txtScaleRate.DataBindings.Add("Text", dsConTrial, "conference_trial.security_rate")
            txtRate.DataBindings.Add("Text", dsConTrial, "conference_trial.guarantee_rate")
            If txtServiceType.Text.IndexOf("保函") < 0 Then
                lblSum.Text = "担保金额(万元)"
                lblTerm.Text = "担保期限(月)"
                lblDescription1.Text = "放 款 方 式"
                lblDescription2.Text = "还款方式"
                txtDescription1.DataBindings.Clear()
                txtDescription2.DataBindings.Clear()
                txtDescription1.DataBindings.Add(New Binding("Text", dsConTrial, "conference_trial.loan_provide_form"))
                txtDescription2.DataBindings.Add(New Binding("Text", dsConTrial, "conference_trial.refund_type"))
            Else
                lblSum.Text = "保函额度(万元)"
                lblTerm.Text = "保函期限(月)"
                lblDescription1.Text = "保 函 种 类"
                lblDescription2.Text = "偿 还 类 型"
                txtDescription1.Text = getDescription1()
                txtDescription2.Text = getDescription2()
            End If
        Else
            txtGuaSum.Clear()
            txtEachReturn.DataBindings.Clear()
            txtServiceType.DataBindings.Clear()
            txtDescription1.DataBindings.Clear()
            txtDescription2.DataBindings.Clear()
            txtScaleRate.DataBindings.Clear()
            txtTerm.DataBindings.Clear()
            txtRate.DataBindings.Clear()
        End If
    End Sub
    Private Function getDescription1() As String '根据保函种类编码获得保函种类名称
        If txtDescription1.Tag Is Nothing Then
            If cmConTrial.Position >= 0 Then
                If IsDBNull(CType(cmConTrial.Current, DataRowView)("guarantee_letter_type")) Then
                    txtDescription1.Tag = String.Empty
                Else
                    Dim tempDs As DataSet = gWs.GetGuaranteeLetterType("%")
                    Dim drs() As DataRow = tempDs.Tables(0).Select("type_code LIKE '" & CType(cmConTrial.Current, DataRowView)("guarantee_letter_type").ToString & "'")
                    txtDescription1.Tag = drs(0)("name")
                End If
            Else
                txtDescription1.Tag = String.Empty
            End If
        End If
        Return txtDescription1.Tag.ToString
    End Function

    Private Function getDescription2() As String '根据偿还类型编码获得偿还类型名称
        If txtDescription2.Tag Is Nothing Then
            If cmConTrial.Position >= 0 Then
                If IsDBNull(CType(cmConTrial.Current, DataRowView)("reimburse_type")) Then
                    txtDescription2.Tag = String.Empty
                Else
                    Dim tempDs As DataSet = gWs.GetReimburseType("%")
                    Dim drs() As DataRow = tempDs.Tables(0).Select("type_code LIKE '" & CType(cmConTrial.Current, DataRowView)("reimburse_type").ToString & "'")
                    txtDescription2.Tag = drs(0)("name")
                End If
            Else
                txtDescription2.Tag = String.Empty
            End If
        End If
        Return txtDescription2.Tag.ToString
    End Function

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
            dsGuaranty.Tables("opposite_guarantee").DefaultView.RowFilter = "opposite_guarantee_form LIKE '" & dsGuaForm.Tables(0).Rows(cmLocal.Position)("guarantee_form").ToString & _
                     "' AND guaranty_type='" & dsGuaForm.Tables(0).Rows(cmLocal.Position)("guaranty").ToString & "'"
            dsGuaranty.Tables("opposite_guarantee").DefaultView.AllowDelete = False
            dsGuaranty.Tables("opposite_guarantee").DefaultView.AllowNew = False
            dgDetail.DataSource = dsGuaranty.Tables("opposite_guarantee").DefaultView
            GuaType = ""
            If dgDetail.Top - gpbxOppGua.Top - gpbxOppGua.Height < gpxAdditionalForm.Height Then
                gpxAdditionalForm.Visible = True
            End If
            If cklbxAdditionalForm.DataSource Is Nothing Then
                Dim dsOppGuaForm As DataSet = gWs.GetOppositeGuaranteeForm("{flag=0}")
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
            ShowAdditionalForm() '显示附加方式
        End If
        If GuaType = "nothing" Then
            If gpbxOppGua.Top + gpbxOppGua.Height < dgDetail.Top Then
                dgDetail.Visible = False
                gpbxOppGua.Height += (dgDetail.Top + dgDetail.Height - gpbxOppGua.Top - gpbxOppGua.Height)
            End If
        ElseIf gpbxOppGua.Top + gpbxOppGua.Height > dgDetail.Top Then
            dgDetail.Visible = True
            gpbxOppGua.Height = dgDetail.Top - gpbxOppGua.Top - 5
        End If

        If dgDetail.Top >= gpbxOppGua.Top + gpbxOppGua.Height Then '即dgDetail可见
            If GuaType <> "" Then
                If dgDetail.Top - gpbxOppGua.Top - gpbxOppGua.Height > gpxAdditionalForm.Height Then
                    gpxAdditionalForm.Visible = False
                    gpbxOppGua.Height += gpxAdditionalForm.Height + 5
                End If
            Else
                gpbxOppGua.Height = gpxAdditionalForm.Top - gpbxOppGua.Top - 5
            End If
        Else
            gpxAdditionalForm.Visible = False
        End If
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

    Private Sub ShowAdditionalForm()
        If GuaType <> "" Then
            Return
        End If
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
    '附加方式改变时
    Private Sub AdditionalForm_ItemCheckChanged(ByVal sender As Object, ByVal e As ItemCheckEventArgs)
        If cklbxAdditionalForm.Tag = "false" Then
            Return
        End If
        e.NewValue = e.CurrentValue
    End Sub

    '评委意见样式表
    Private Sub AddTableStyleForOpinion()
        dgOpinion.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.AllowSorting = False
        dgts.MappingName = "committeeman_opinion"
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1
        col3.MappingName = "committeeman"
        col3.HeaderText = " 会议评委"
        col3.Width = 80
        col3.NullText = String.Empty
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2 
        col4.MappingName = "RoleName"
        col4.HeaderText = "角色"
        col4.Alignment = HorizontalAlignment.Left
        col4.NullText = String.Empty
        col4.Width = 50
        dgts.GridColumnStyles.Add(col4)
        dgOpinion.TableStyles.Add(dgts)
    End Sub
    'Private Sub AddTableStyleForLoan()
    '    dgLoan.TableStyles.Clear()
    '    Dim dgts As DataGridTableStyle = New DataGridTableStyle()
    '    dgts.MappingName = "project_account_detail"
    '    dgts.AllowSorting = False
    '    Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1 
    '    col5.MappingName = "date"
    '    col5.HeaderText = "放款日期"
    '    col5.Width = 75
    '    col5.Format = "yyyy-MM-dd"
    '    col5.Alignment = HorizontalAlignment.Left
    '    dgts.GridColumnStyles.Add(col5)
    '    Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2 
    '    col2.MappingName = "date_1"
    '    col2.HeaderText = "还款日期"
    '    col2.Format = "yyyy-MM-dd"
    '    col2.Width = 75
    '    col2.Alignment = HorizontalAlignment.Left
    '    dgts.GridColumnStyles.Add(col2)
    '    Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 3
    '    col3.MappingName = "FalseMoney"
    '    col3.HeaderText = " 放款金额(万元)"
    '    col3.Width = 100
    '    col3.Format = "c"
    '    col3.FormatInfo = CGFormatInfo
    '    col3.NullText = String.Empty
    '    col3.Alignment = HorizontalAlignment.Right
    '    dgts.GridColumnStyles.Add(col3)
    '    Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 4 
    '    col4.MappingName = "remark"
    '    col4.HeaderText = "摘要"
    '    col4.Alignment = HorizontalAlignment.Left
    '    col4.NullText = String.Empty
    '    col4.Width = 330
    '    dgts.GridColumnStyles.Add(col4)
    '    dgLoan.TableStyles.Add(dgts)
    'End Sub
    '''''''''''''''反担保物的样式表''''''''''''''''
    Private d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf MyGetColorRowCol)
    Private Sub AddTableStyleOfPerson()
        dgDetail.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "opposite_guarantee_assurer"
        dgts.AllowSorting = False
        Dim col5 As DataGridColoredBoolColumn = New DataGridColoredBoolColumn(d, 0)
        col5.MappingName = "is_used"
        col5.AllowNull = False
        col5.ReadOnly = True
        col5.HeaderText = "是否采用"
        col5.Width = 60
        dgts.GridColumnStyles.Add(col5)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.ReadOnly = True
        col2.MappingName = "name"
        col2.HeaderText = "姓名"
        col2.Width = 60
        col2.NullText = ""
        dgts.GridColumnStyles.Add(col2)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col6.MappingName = "status"
        col6.HeaderText = "状态"
        col6.NullText = ""
        col6.ReadOnly = True
        col6.Width = 60
        dgts.GridColumnStyles.Add(col6)
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "sex"
        col1.ReadOnly = True
        col1.HeaderText = "性别"
        col1.Width = 40
        col1.NullText = ""
        dgts.GridColumnStyles.Add(col1)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.MappingName = "phone"
        col3.ReadOnly = True
        col3.HeaderText = "联系电话"
        col3.Width = 90
        col3.NullText = ""
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
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
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "TProjectCorporation"
        dgts.AllowSorting = False
        Dim col5 As DataGridColoredBoolColumn = New DataGridColoredBoolColumn(d, 0)
        col5.MappingName = "is_used"
        col5.AllowNull = False
        col5.ReadOnly = True
        col5.HeaderText = "是否采用"
        col5.Width = 60
        dgts.GridColumnStyles.Add(col5)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.ReadOnly = True
        col2.MappingName = "corporation_name"
        col2.HeaderText = "公司名称"
        col2.NullText = ""
        col2.Width = 150
        dgts.GridColumnStyles.Add(col2)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col6.MappingName = "status"
        col6.HeaderText = "状态"
        col6.NullText = ""
        col6.ReadOnly = True
        col6.Width = 60
        dgts.GridColumnStyles.Add(col6)
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "contact_person"
        col1.ReadOnly = True
        col1.HeaderText = "联系人"
        col1.Width = 80
        col1.NullText = ""
        col1.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col1)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.MappingName = "contact_phone"
        col3.ReadOnly = True
        col3.HeaderText = "联系电话"
        col3.Width = 90
        col3.NullText = ""
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
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
        dgParent.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "TProjectGuaranteeForm"
        dgts.AllowSorting = False
        Dim col1 As DataGridColoredBoolColumn = New DataGridColoredBoolColumn(d, 0) ' DataGridBoolColumn = New DataGridBoolColumn()
        col1.MappingName = "is_used"
        col1.AllowNull = False
        col1.ReadOnly = True
        col1.HeaderText = "是否采用"
        col1.Width = 60
        dgts.GridColumnStyles.Add(col1)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.ReadOnly = True
        col2.MappingName = "guarantee_form"
        col2.HeaderText = "反担保方式"
        col2.Width = 90
        dgts.GridColumnStyles.Add(col2)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.MappingName = "ItemName"
        col3.ReadOnly = True
        col3.HeaderText = "反担保物"
        col3.Width = 90
        col3.NullText = ""
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.MappingName = "num"
        col4.ReadOnly = True
        col4.HeaderText = "数量"
        col4.Width = 40
        col4.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col4)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "guarantee_sum"
        col5.ReadOnly = True
        col5.HeaderText = "担保金额 " & ControlChars.Tab
        col5.Width = 90
        col5.Format = "n"
        col5.Alignment = HorizontalAlignment.Right
        dgts.GridColumnStyles.Add(col5)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col6.MappingName = "description"
        col6.ReadOnly = True
        col6.HeaderText = "描述"
        col6.Width = 340
        col6.NullText = ""
        col6.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col6)
        dgParent.TableStyles.Add(dgts)
    End Sub
    Private Sub AddTableStyleOfDetail()
        dgDetail.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "opposite_guarantee"
        dgts.AllowSorting = False
        Dim col9 As DataGridColoredBoolColumn = New DataGridColoredBoolColumn(d, 0)
        col9.MappingName = "is_used"
        col9.ReadOnly = True
        col9.AllowNull = False
        col9.HeaderText = "是否采用"
        col9.Width = 70
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.HeaderText = "反担保物"
        col1.ReadOnly = True
        col1.MappingName = "ItemName"
        col1.NullText = ""
        col1.Width = 75
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.HeaderText = "反担保方式"
        col2.MappingName = "opposite_guarantee_form"
        col2.NullText = ""
        col2.ReadOnly = True
        col2.Width = 75
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col10.MappingName = "status"
        col10.HeaderText = "状态"
        col10.NullText = ""
        col10.ReadOnly = True
        col10.Width = 60
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.HeaderText = "原值(元)"
        col3.MappingName = "original_value"
        col3.NullText = "0"
        col3.Width = 75
        col3.ReadOnly = True
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.HeaderText = "评估总值(元)"
        col4.MappingName = "evaluate_value"
        col4.NullText = "0"
        col4.Width = 75
        col4.ReadOnly = True

        'add   yansm   2013-12-3
        '担保额原来为5，评估时间原来为6
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col5.HeaderText = "评估净值(元)"
        col5.MappingName = "evaluate_net_value"
        col5.NullText = "0"
        col5.Width = 75
        col5.ReadOnly = True


        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col6.HeaderText = "担保额(元)"
        col6.MappingName = "guarantee_value"
        col6.NullText = "0"
        col6.Width = 75
        col6.ReadOnly = True

        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col11.HeaderText = "评估日期"
        col11.MappingName = "evaluate_date"
        col11.NullText = ""
        col11.Format = "yyyy-MM-dd"
        col11.Width = 70
        col11.ReadOnly = True

        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col7.HeaderText = "评估师"
        col7.MappingName = "evaluate_person"
        col7.NullText = ""
        col7.ReadOnly = True
        col7.Width = 75
        col7.ReadOnly = True
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col8.HeaderText = "说明"
        col8.MappingName = "remark"
        col8.NullText = ""
        col8.Width = 75
        col8.ReadOnly = True
        dgts.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {col9, col2, col1, col10, col3, col4, col5, col6, col7, col8})
        dgDetail.TableStyles.Add(dgts)
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub TabControl_TabIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl.SelectedIndexChanged
        ShowAdditionalForm()
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        frmChangeGuarantyFee.OpenWord(ProjectCode, Me, txtCorName.Text.Trim & "评审会意见表", False, String.Empty)
    End Sub
End Class
