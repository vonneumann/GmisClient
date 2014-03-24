

Public Class frmMakeContract
    Inherits MainInterface.frmDocumentManageBusiness

    Private strWorkFlowID As String
    Private strProjectCode As String
    Private strCorporationName As String
    Private strTaskID As String
    Private strPerson As String

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
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOpinion As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnConclusion As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCondition As System.Windows.Forms.TextBox
    Friend WithEvents txtOrgName As System.Windows.Forms.TextBox
    Friend WithEvents txtRefundTerm As System.Windows.Forms.TextBox
    Friend WithEvents txtRefundSum As System.Windows.Forms.TextBox
    Friend WithEvents txtRetAver As System.Windows.Forms.TextBox
    Friend WithEvents txtRetType As System.Windows.Forms.TextBox
    Friend WithEvents txtBranch As System.Windows.Forms.TextBox
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents btnContractElement As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtContractNum As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtComfirmBank As System.Windows.Forms.TextBox
    Friend WithEvents txtComfirmBranchBank As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMakeContract))
        Me.btnCommit = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtOpinion = New System.Windows.Forms.TextBox
        Me.btnConclusion = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtCondition = New System.Windows.Forms.TextBox
        Me.txtRefundTerm = New System.Windows.Forms.TextBox
        Me.txtRefundSum = New System.Windows.Forms.TextBox
        Me.txtRetAver = New System.Windows.Forms.TextBox
        Me.txtBranch = New System.Windows.Forms.TextBox
        Me.txtRetType = New System.Windows.Forms.TextBox
        Me.txtBank = New System.Windows.Forms.TextBox
        Me.txtOrgName = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.btnContractElement = New System.Windows.Forms.Button
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtContractNum = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtComfirmBranchBank = New System.Windows.Forms.TextBox
        Me.txtComfirmBank = New System.Windows.Forms.TextBox
        CType(Me.dgFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnModify
        '
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.ImageIndex = -1
        Me.btnModify.ImageList = Nothing
        Me.btnModify.Location = New System.Drawing.Point(432, 528)
        Me.btnModify.Name = "btnModify"
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageIndex = -1
        Me.btnDelete.ImageList = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(344, 528)
        Me.btnDelete.Name = "btnDelete"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageIndex = -1
        Me.btnNew.ImageList = Nothing
        Me.btnNew.Location = New System.Drawing.Point(256, 528)
        Me.btnNew.Name = "btnNew"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageIndex = -1
        Me.btnSave.ImageList = Nothing
        Me.btnSave.Location = New System.Drawing.Point(520, 528)
        Me.btnSave.Name = "btnSave"
        '
        'btnUpload
        '
        Me.btnUpload.Image = CType(resources.GetObject("btnUpload.Image"), System.Drawing.Image)
        Me.btnUpload.ImageIndex = -1
        Me.btnUpload.ImageList = Nothing
        Me.btnUpload.Location = New System.Drawing.Point(64, 528)
        Me.btnUpload.Name = "btnUpload"
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Image)
        Me.btnOpen.ImageIndex = -1
        Me.btnOpen.ImageList = Nothing
        Me.btnOpen.Location = New System.Drawing.Point(392, 128)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Visible = False
        '
        'btnMakeDoc
        '
        Me.btnMakeDoc.Image = CType(resources.GetObject("btnMakeDoc.Image"), System.Drawing.Image)
        Me.btnMakeDoc.ImageIndex = -1
        Me.btnMakeDoc.ImageList = Nothing
        Me.btnMakeDoc.Location = New System.Drawing.Point(152, 528)
        Me.btnMakeDoc.Name = "btnMakeDoc"
        Me.btnMakeDoc.Size = New System.Drawing.Size(93, 23)
        Me.btnMakeDoc.Text = "合同要素(&A)"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(432, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(336, 21)
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label4.Location = New System.Drawing.Point(560, 52)
        Me.Label4.Name = "Label4"
        '
        'txtCode
        '
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(128, 21)
        '
        'txtVersion
        '
        Me.txtVersion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtVersion.Location = New System.Drawing.Point(608, 24)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(144, 21)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        '
        'Label8
        '
        Me.Label8.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label8.Location = New System.Drawing.Point(560, 24)
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.Location = New System.Drawing.Point(8, 83)
        Me.Label7.Name = "Label7"
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtTitle.Location = New System.Drawing.Point(40, 24)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(504, 21)
        Me.txtTitle.Text = "初审报告"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 53)
        Me.Label6.Name = "Label6"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(8, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(760, 138)
        '
        'txtAuthor
        '
        Me.txtAuthor.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtAuthor.Location = New System.Drawing.Point(608, 52)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(144, 21)
        '
        'dateCreate
        '
        Me.dateCreate.Name = "dateCreate"
        Me.dateCreate.Size = New System.Drawing.Size(664, 21)
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(376, 8)
        Me.Label2.Name = "Label2"
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtRemark.Location = New System.Drawing.Point(40, 88)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(712, 40)
        '
        'Label5
        '
        Me.Label5.Name = "Label5"
        '
        'cmbType
        '
        Me.cmbType.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.cmbType.Items.AddRange(New Object() {"初审报告", "评审报告", "保后检查记录表", "项目终止报告", "初审报告", "评审报告", "保后检查记录表", "项目终止报告", "初审报告", "评审报告", "保后检查记录表", "项目终止报告"})
        Me.cmbType.Location = New System.Drawing.Point(40, 53)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(392, 20)
        '
        'dgFiles
        '
        Me.dgFiles.Name = "dgFiles"
        Me.dgFiles.Size = New System.Drawing.Size(754, 118)
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.GroupBox3.Location = New System.Drawing.Point(8, 376)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(760, 136)
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(688, 528)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 14
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(608, 528)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 13
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtOpinion)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 167)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(760, 63)
        Me.GroupBox4.TabIndex = 15
        Me.GroupBox4.TabStop = False
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 23)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "审核意见"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOpinion
        '
        Me.txtOpinion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOpinion.Location = New System.Drawing.Point(64, 16)
        Me.txtOpinion.Multiline = True
        Me.txtOpinion.Name = "txtOpinion"
        Me.txtOpinion.ReadOnly = True
        Me.txtOpinion.Size = New System.Drawing.Size(680, 40)
        Me.txtOpinion.TabIndex = 0
        Me.txtOpinion.Text = ""
        '
        'btnConclusion
        '
        Me.btnConclusion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnConclusion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConclusion.ImageIndex = 26
        Me.btnConclusion.ImageList = Me.ImageListBasic
        Me.btnConclusion.Location = New System.Drawing.Point(440, 48)
        Me.btnConclusion.Name = "btnConclusion"
        Me.btnConclusion.Size = New System.Drawing.Size(104, 23)
        Me.btnConclusion.TabIndex = 16
        Me.btnConclusion.Text = "评审会结论(&R)"
        Me.btnConclusion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtCondition)
        Me.GroupBox5.Controls.Add(Me.txtRefundTerm)
        Me.GroupBox5.Controls.Add(Me.txtRefundSum)
        Me.GroupBox5.Controls.Add(Me.txtRetAver)
        Me.GroupBox5.Controls.Add(Me.txtBranch)
        Me.GroupBox5.Controls.Add(Me.txtRetType)
        Me.GroupBox5.Controls.Add(Me.txtBank)
        Me.GroupBox5.Controls.Add(Me.txtOrgName)
        Me.GroupBox5.Controls.Add(Me.TextBox1)
        Me.GroupBox5.Controls.Add(Me.Label18)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Controls.Add(Me.Label13)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label17)
        Me.GroupBox5.Controls.Add(Me.btnConclusion)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 80)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(760, 80)
        Me.GroupBox5.TabIndex = 17
        Me.GroupBox5.TabStop = False
        '
        'txtCondition
        '
        Me.txtCondition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCondition.Enabled = False
        Me.txtCondition.Location = New System.Drawing.Point(568, 72)
        Me.txtCondition.Multiline = True
        Me.txtCondition.Name = "txtCondition"
        Me.txtCondition.ReadOnly = True
        Me.txtCondition.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtCondition.Size = New System.Drawing.Size(183, 40)
        Me.txtCondition.TabIndex = 27
        Me.txtCondition.Text = ""
        '
        'txtRefundTerm
        '
        Me.txtRefundTerm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRefundTerm.Enabled = False
        Me.txtRefundTerm.Location = New System.Drawing.Point(568, 43)
        Me.txtRefundTerm.Name = "txtRefundTerm"
        Me.txtRefundTerm.ReadOnly = True
        Me.txtRefundTerm.Size = New System.Drawing.Size(184, 21)
        Me.txtRefundTerm.TabIndex = 26
        Me.txtRefundTerm.Text = ""
        '
        'txtRefundSum
        '
        Me.txtRefundSum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRefundSum.Enabled = False
        Me.txtRefundSum.Location = New System.Drawing.Point(568, 16)
        Me.txtRefundSum.Name = "txtRefundSum"
        Me.txtRefundSum.ReadOnly = True
        Me.txtRefundSum.Size = New System.Drawing.Size(184, 21)
        Me.txtRefundSum.TabIndex = 25
        Me.txtRefundSum.Text = ""
        '
        'txtRetAver
        '
        Me.txtRetAver.Enabled = False
        Me.txtRetAver.Location = New System.Drawing.Point(320, 71)
        Me.txtRetAver.Name = "txtRetAver"
        Me.txtRetAver.ReadOnly = True
        Me.txtRetAver.Size = New System.Drawing.Size(120, 21)
        Me.txtRetAver.TabIndex = 24
        Me.txtRetAver.Text = ""
        '
        'txtBranch
        '
        Me.txtBranch.Enabled = False
        Me.txtBranch.Location = New System.Drawing.Point(320, 43)
        Me.txtBranch.Name = "txtBranch"
        Me.txtBranch.ReadOnly = True
        Me.txtBranch.Size = New System.Drawing.Size(120, 21)
        Me.txtBranch.TabIndex = 23
        Me.txtBranch.Text = ""
        '
        'txtRetType
        '
        Me.txtRetType.Enabled = False
        Me.txtRetType.Location = New System.Drawing.Point(64, 71)
        Me.txtRetType.Name = "txtRetType"
        Me.txtRetType.ReadOnly = True
        Me.txtRetType.Size = New System.Drawing.Size(136, 21)
        Me.txtRetType.TabIndex = 22
        Me.txtRetType.Text = ""
        '
        'txtBank
        '
        Me.txtBank.Enabled = False
        Me.txtBank.Location = New System.Drawing.Point(64, 43)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.ReadOnly = True
        Me.txtBank.Size = New System.Drawing.Size(136, 21)
        Me.txtBank.TabIndex = 21
        Me.txtBank.Text = ""
        '
        'txtOrgName
        '
        Me.txtOrgName.Enabled = False
        Me.txtOrgName.Location = New System.Drawing.Point(320, 15)
        Me.txtOrgName.Name = "txtOrgName"
        Me.txtOrgName.ReadOnly = True
        Me.txtOrgName.Size = New System.Drawing.Size(120, 21)
        Me.txtOrgName.TabIndex = 20
        Me.txtOrgName.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(64, 15)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(136, 21)
        Me.TextBox1.TabIndex = 19
        Me.TextBox1.Text = "再担保"
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(224, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(92, 23)
        Me.Label18.TabIndex = 18
        Me.Label18.Text = "担保机构名称"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(8, 14)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(56, 23)
        Me.Label16.TabIndex = 17
        Me.Label16.Text = "业务品种"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(465, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 23)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "再担保额度(万元)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 23)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "贷款银行"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(224, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(92, 23)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "贷  款  支  行"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 23)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "还款方式"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(224, 70)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 23)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "每次还款金额(元)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(465, 64)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 23)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "再担保条件"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(465, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 23)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "贷款期限(月)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnContractElement
        '
        Me.btnContractElement.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnContractElement.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnContractElement.ImageIndex = 19
        Me.btnContractElement.ImageList = Me.ImageListBasic
        Me.btnContractElement.Location = New System.Drawing.Point(152, 528)
        Me.btnContractElement.Name = "btnContractElement"
        Me.btnContractElement.Size = New System.Drawing.Size(95, 24)
        Me.btnContractElement.TabIndex = 18
        Me.btnContractElement.Text = "合同要素(&A)"
        Me.btnContractElement.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(223, 12)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(42, 16)
        Me.Label19.TabIndex = 11
        Me.Label19.Text = "合同号"
        '
        'txtContractNum
        '
        Me.txtContractNum.Location = New System.Drawing.Point(268, 8)
        Me.txtContractNum.Name = "txtContractNum"
        Me.txtContractNum.ReadOnly = True
        Me.txtContractNum.Size = New System.Drawing.Size(73, 21)
        Me.txtContractNum.TabIndex = 12
        Me.txtContractNum.Text = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtComfirmBranchBank)
        Me.GroupBox1.Controls.Add(Me.txtComfirmBank)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 48)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'Label21
        '
        Me.Label21.Location = New System.Drawing.Point(368, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 23)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "支行"
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(8, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(48, 16)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "银行"
        '
        'txtComfirmBranchBank
        '
        Me.txtComfirmBranchBank.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComfirmBranchBank.Location = New System.Drawing.Point(424, 16)
        Me.txtComfirmBranchBank.Name = "txtComfirmBranchBank"
        Me.txtComfirmBranchBank.ReadOnly = True
        Me.txtComfirmBranchBank.Size = New System.Drawing.Size(328, 21)
        Me.txtComfirmBranchBank.TabIndex = 1
        Me.txtComfirmBranchBank.Text = ""
        '
        'txtComfirmBank
        '
        Me.txtComfirmBank.Location = New System.Drawing.Point(56, 17)
        Me.txtComfirmBank.Name = "txtComfirmBank"
        Me.txtComfirmBank.ReadOnly = True
        Me.txtComfirmBank.Size = New System.Drawing.Size(280, 21)
        Me.txtComfirmBank.TabIndex = 0
        Me.txtComfirmBank.Text = ""
        '
        'frmMakeContract
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(778, 559)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnContractElement)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.txtContractNum)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "frmMakeContract"
        Me.Text = "合同制作"
        Me.Controls.SetChildIndex(Me.txtContractNum, 0)
        Me.Controls.SetChildIndex(Me.Label19, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtCode, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.GroupBox5, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.btnNew, 0)
        Me.Controls.SetChildIndex(Me.btnUpload, 0)
        Me.Controls.SetChildIndex(Me.btnOpen, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnMakeDoc, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.btnModify, 0)
        Me.Controls.SetChildIndex(Me.txtName, 0)
        Me.Controls.SetChildIndex(Me.btnContractElement, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        CType(Me.dgFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    '提交
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            'If MsgBoxResult.Yes = MsgBox("是否确认提交?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "提示") Then
            If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1000", "提交") Then
                commit()
            End If
        Else
            commit()
        End If
        
    End Sub
    '提交处理
    Private Sub commit()
        'qxd modify 2004-11-19 
        '深圳版本需求：中心的合同采用印刷文稿，不在制作合同时上载合同文本，在制作合同任务中取消不上载合同文本不能提交的限制。
        If fileIsNotUpload() Then
            'MsgBox("有未上载文件的记录,不允许提交!", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$X021")
            Exit Sub
        End If
        Dim strCommit As String
        Try
            strCommit = gWs.finishedTask(strWorkFlowID, strProjectCode, strTaskID, "", strPerson)
            If "1" = strCommit Then
                'MsgBox("提交成功!", MsgBoxStyle.Information, "提示")
                SWDialogBox.MessageBox.Show("$SubmitSucceed")
                raiseCommitSucceed()
                Me.Close()
            Else
                'MsgBox("提交失败!" & strCommit, MsgBoxStyle.Critical, "提示")
                SWDialogBox.MessageBox.Show("*999", "", strCommit, "")
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '设置确认签约的银行
    Private Function setBank()
        '判断是否有意向书，如果有显示意向书银行
        Dim dsIntentLetter As DataSet = gWs.GetIntentLetterInfo("{project_code LIKE '" & Me.getProjectCode & "' ORDER BY intent_code DESC}")
        Dim tmpConfirmBankCode, tmpConfirmBranchBankCode, tmpConfirmBankName, tmpConfirmBranchBankName As String
        Dim dsConfirmBank, dsConfirmBranchBank As DataSet
        If dsIntentLetter.Tables(0).Rows.Count > 0 Then
            tmpConfirmBankCode = IIf(IsDBNull(dsIntentLetter.Tables(0).Rows(0)("loan_bank")), "", dsIntentLetter.Tables(0).Rows(0)("loan_bank"))
            tmpConfirmBranchBankCode = IIf(IsDBNull(dsIntentLetter.Tables(0).Rows(0)("loan_branch_bank")), "", dsIntentLetter.Tables(0).Rows(0)("loan_branch_bank"))
            dsConfirmBank = gWs.GetCommonQueryInfo("select bank_name from bank where bank_code='" & tmpConfirmBankCode & "'")
            dsConfirmBranchBank = gWs.GetCommonQueryInfo("select branch_bank_name from bank_branch where bank_code='" & tmpConfirmBankCode & "' and branch_bank_code='" & tmpConfirmBranchBankCode & "'")
            If dsConfirmBank.Tables(0).Rows.Count > 0 Then
                tmpConfirmBankName = dsConfirmBank.Tables(0).Rows(0).Item("bank_name")
            End If

            If dsConfirmBranchBank.Tables(0).Rows.Count > 0 Then
                tmpConfirmBranchBankName = dsConfirmBranchBank.Tables(0).Rows(0).Item("branch_bank_name")
            End If

            '否则显示申请银行
        Else
            Dim dsProject As DataSet = gWs.GetCommonQueryInfo("select apply_bank,apply_branch_bank from project where project_code='" & Me.getProjectCode & "'")
            If dsProject.Tables(0).Rows.Count > 0 Then
                tmpConfirmBankCode = IIf(IsDBNull(dsProject.Tables(0).Rows(0)("apply_bank")), "", dsProject.Tables(0).Rows(0)("apply_bank"))
                tmpConfirmBranchBankCode = IIf(IsDBNull(dsProject.Tables(0).Rows(0)("apply_branch_bank")), "", dsProject.Tables(0).Rows(0)("apply_branch_bank"))
                dsConfirmBank = gWs.GetCommonQueryInfo("select bank_name from bank where bank_code='" & tmpConfirmBankCode & "'")
                dsConfirmBranchBank = gWs.GetCommonQueryInfo("select branch_bank_name from bank_branch where bank_code='" & tmpConfirmBankCode & "' and branch_bank_code='" & tmpConfirmBranchBankCode & "'")
                If dsConfirmBank.Tables(0).Rows.Count > 0 Then
                    tmpConfirmBankName = dsConfirmBank.Tables(0).Rows(0).Item("bank_name")
                End If

                If dsConfirmBranchBank.Tables(0).Rows.Count > 0 Then
                    tmpConfirmBranchBankName = dsConfirmBranchBank.Tables(0).Rows(0).Item("branch_bank_name")
                End If
            End If

        End If

        txtComfirmBank.Text = tmpConfirmBankName
        txtComfirmBranchBank.Text = tmpConfirmBranchBankName

    End Function

    'Load（）
    Private Sub frmMakeContract_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.strProjectCode = Me.getProjectCode()
        Me.strCorporationName = Me.getCorporationName()
        Me.strWorkFlowID = Me.getWorkFlowID()
        Me.strTaskID = Me.getTaskID()
        Me.strPerson = Me.getUser()
        'edit by 9sky 20050705
        'If dgFiles.CurrentRowIndex() < 0 Then
        '    btnUpload.Enabled = False
        'Else
        '    btnUpload.Enabled = True
        'End If

        '2008-6-20 yjf add 增加合同号功能，在窗体加载时获取合同号
        Dim dtProjectContract As DataTable = gWs.GetCommonQueryInfo("select contract_num from project_contract_num where project_code='" & Me.getProjectCode & "'").Tables(0)
        If dtProjectContract.Rows.Count <> 0 Then
            Me.txtContractNum.Text = Trim(dtProjectContract.Rows(0).Item("contract_num"))
        End If

        Me.setRefound()
        Me.setOpinion()
        Me.setBank()

    End Sub
    '
    '根据是否有文件,确定是否允许提交
    '
    Private Function fileIsNotUpload() As Boolean
        Dim dt As DataTable
        Dim i As Integer
        '2008-3-20 yjf edit 只有本公司但非系统制作的合同必须上载文本
        Dim dtTempItem As DataTable = gWs.GetCommonQueryInfo("select * from item where item_type='43'").Tables(0)
        Dim strTempItem, strTempAdditonRemark As String
        Try
            dt = CType(Me.dgFiles.DataSource, DataTable)
            i = dt.Rows.Count
            If Not dt Is Nothing Then
                If i > 0 Then
                    For i = 0 To i - 1
                        If dt.Rows(i).Item("relation_num") Is System.DBNull.Value Then
                            Me.dgFiles.SelectionBackColor = Color.YellowGreen
                            Me.dgFiles.UnSelect(Me.dgFiles.CurrentCell.RowNumber)
                            Me.dgFiles.Select(i)
                            Me.dgFiles.CurrentRowIndex = i
                            setButton()
                            '2008-3-20 yjf edit 只有本公司但非系统制作的合同必须上载文本(即标记为DOC的ITEM)
                            If dt.Rows(i).Item("item_type") = "43" Then
                                strTempItem = dt.Rows(i).Item("item_code")
                                If dtTempItem.Select("item_code='" & strTempItem & "'").Length > 0 Then
                                    strTempAdditonRemark = IIf(IsDBNull(dtTempItem.Select("item_code='" & strTempItem & "'")(0).Item("additional_remark")), "", dtTempItem.Select("item_code='" & strTempItem & "'")(0).Item("additional_remark"))
                                    If strTempAdditonRemark = "DOC" Then
                                        Return True
                                    End If
                                End If
                            End If
                        End If
                    Next
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    '是否显示审核意见
    Private Sub setOpinion()
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strSql As String
        Dim i As Integer
        Dim isVisible As Boolean = False

        If gWs Is Nothing Then
            Exit Sub
        End If
        strSql = "{project_code='" & strProjectCode & "' and item_type='53' and item_code='002'}"
        ds = gWs.GetProjectOpinionByProjectNo(strSql)
        i = ds.Tables("TProjectOpinion").Rows.Count

        If i > 0 Then
            dr = ds.Tables("TProjectOpinion").Rows(0)
            If Not dr.Item("content") Is System.DBNull.Value Then
                If Not dr.Item("content") = "" Then
                    Me.txtOpinion.Text = dr.Item("content") '存在且不为空时显示
                    isVisible = True
                End If
            End If
        End If

        If isVisible = False Then
            GroupBox2.Location = New Point(GroupBox2.Location.X, GroupBox2.Location.Y - GroupBox4.Height)
            GroupBox2.Height = GroupBox4.Height + GroupBox2.Height
            GroupBox4.Height = 0
        End If

    End Sub
    '评审会结论
    Private Sub btnConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConclusion.Click
        'edit by 9sky 20050705  对保函业务品种做特殊处理
        '************************原来的代码*******************************************
        'If gWs.GetConfTrialInfo("{project_code = '" + Me.getProjectCode() + "'}", "NULL").Tables("conference_trial").Rows.Count <= 0 Then
        '    '显示“无效或没有可供操作的数据”消息框
        '    SWDialogBox.MessageBox.Show("$1005", " 评审会结论 ")
        '    Return
        'End If

        'Dim meet As New frmMeetingRecord(strProjectCode, strCorporationName)
        'meet.ReadOnly = True
        'meet.AllowTransparency = False
        'meet.ShowDialog()
        '************************************************************************

        If gWs.GetCommonQueryInfo("select apply_service_type from project where project_code='" & Me.getProjectCode & "'").Tables(0).Rows(0)(0) <> "保函" Then
            If gWs.GetConfTrialInfo("{project_code = '" + Me.getProjectCode() + "'}", "NULL").Tables("conference_trial").Rows.Count <= 0 Then
                '显示“无效或没有可供操作的数据”消息框
                SWDialogBox.MessageBox.Show("$1005", " 评审会结论 ")
                Return
            End If

            Dim meet As New frmMeetRecordQuery(strProjectCode, strCorporationName)
            meet.AllowTransparency = False
            meet.ShowDialog()
        Else

            If gWs.GetConfTrialInfo("{project_code = '" + Me.getProjectCode() + "'}", "NULL").Tables("conference_trial").Rows.Count > 0 Then
                frmChangeGuarantyFee.OpenWord(Me.getProjectCode(), Me, Me.getCorporationName() & "评审会意见表", True, Me.strCorporationName)
            Else
                Dim ProjectCode As String = MyBase.getProjectCode
                Dim apply_date As DateTime = Money.GetApplyDate(ProjectCode)
                Dim dsLetter As DataSet = gWs.GetGuaranteeLetter(ProjectCode.Substring(0, 5), apply_date)
                Dim fileProjectCode As String
                If dsLetter.Tables(0).Rows.Count > 0 Then
                    fileProjectCode = dsLetter.Tables(0).Rows(0)("project_code") & String.Empty
                    frmChangeGuarantyFee.OpenWord(fileProjectCode, Me, Me.getCorporationName() & "评审会意见表", False, String.Empty)
                End If
            End If
        End If
    End Sub

    '显示再担保信息
    Private Sub reFundInfo()

        Dim dsLoanNotice As DataSet
        Dim dsConTrial As DataSet
        Dim dsProjectOrg As DataSet

        Dim dsTemp As DataSet

        Dim dr As DataRow
        dsLoanNotice = gWs.GetLoanNoticeInfo("{project_code='" & Me.strProjectCode & "'}")
        dsConTrial = gWs.GetConfTrialInfo("{project_code='" & Me.strProjectCode & "'}", "")
        dsProjectOrg = gWs.GetProjectOrganization("{project_code='" & Me.strProjectCode & "'}")

        '再担保机构名称,再担保条件
        If dsProjectOrg.Tables(0).Rows.Count > 0 Then
            dr = dsProjectOrg.Tables(0).Rows(0)
            txtCondition.Text = dr.Item("ReguaranteeCondition").ToString
            If Not dr.Item("organno") Is System.DBNull.Value Then
                dsTemp = gWs.GetTOrganizationInfo("{organno='" & dr.Item("organno") & "'}")
                txtOrgName.Text = dsTemp.Tables(0).Rows(0).Item("name")
            End If
        End If

        '再担保额度,再担保期限,还款方式,每次还款金额
        If dsConTrial.Tables(0).Rows.Count > 0 Then
            dr = dsConTrial.Tables(0).Rows(0)
            txtRefundSum.Text = dr.Item("guarantee_sum").ToString
            txtRefundTerm.Text = dr.Item("terms").ToString
            txtRetAver.Text = dr.Item("refund_sum_average").ToString
            txtRetType.Text = dr.Item("refund_type").ToString
        End If

        '银行,支行
        If dsLoanNotice.Tables("loan_notice").Rows.Count > 0 Then
            dr = dsLoanNotice.Tables("loan_notice").Rows(0)
            If Not dr.Item("bank") Is System.DBNull.Value Then
                Dim dsBanka As DataSet
                dsBanka = gWs.GetBankInfo("{bank_code='" & dr.Item("bank") & "'}", "{bank_code='" & dr.Item("bank") & "'}")
                txtBank.Text = dsBanka.Tables("bank").Rows(0).Item("bank_name")
                txtBranch.Text = dsBanka.Tables("bank_branch").Select("branch_bank_code='" & dr.Item("branch_bank") & "'")(0).Item("branch_bank_name")
            End If
        End If
        GroupBox5.Text = "再担保信息"
    End Sub

    '判断是否需要显示再担保信息
    Private Sub setRefound()
        Dim dsProject As DataSet
        dsProject = gWs.GetProjectInfo("{project_code='" & Me.strProjectCode & "'}")
        If dsProject.Tables(0).Rows(0).Item("apply_service_type") = "再担保" Then
            reFundInfo()
        Else
            GroupBox4.Location = New Point(GroupBox2.Location.X, GroupBox5.Location.Y)
            GroupBox2.Location = New Point(GroupBox2.Location.X, GroupBox2.Location.Y - GroupBox5.Height)
            GroupBox2.Height = GroupBox2.Height + GroupBox5.Height
            GroupBox5.Height = 0
        End If
    End Sub

    '通过文档类型获取SelectCase的判断条件，判断条件为：item_type & item_code
    Private Function getSelectCase(ByVal strFileType As String) As String
        Dim ds As DataSet
        Dim i As Integer
        Dim strSelectCase As String

        If Not gWs Is Nothing Then
            Try
                ds = gWs.GetItem("{item_name='" & strFileType & "'}", Nothing)
                i = ds.Tables("TItem").Rows.Count
                If i > 0 Then
                    With ds.Tables("TItem").Rows(0)
                        strSelectCase = .Item("item_type")
                        strSelectCase = strSelectCase.Trim & .Item("item_code")
                    End With
                    Return strSelectCase.Trim
                End If
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Function

    Private Sub btnContractElement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContractElement.Click
        Dim strFileType As String = cmbType.Text
        Dim strItemTpeItemCode As String = getSelectCase(strFileType)
        Dim strItemType As String = strItemTpeItemCode.Substring(0, 2)
        Dim strItemCode As String = strItemTpeItemCode.Substring(2, 3)
        Dim strSql As String = "select apply_tool from item where item_type='" & strItemType & "' and item_code='" & strItemCode & "'"


        Dim frmApply As frmCommonContract = New frmCommonContract(Me.txtName.Text, Me.txtTitle.Text, strItemType, strItemCode, Me.txtCode.Text)
        frmApply.btnPrint.Visible = True
        frmApply.DataGridTableStyle1.ReadOnly = False
        frmApply.ShowDialog()

    End Sub

    '2008-6-20 yjf add 保存前需要做的动作
    Protected Overrides Function BeforeSave() As Object
        '判断当前项目是否存在合同号
        '如果不存在
        If Trim(txtContractNum.Text) = "" Then
            Dim MaxNum As String = gWs.GetMaxContractNum(Me.getProjectCode)
            txtContractNum.Text = MaxNum
            If MaxNum <> "" Then
                gWs.GetCommonQueryInfo("insert into project_contract_num (project_code,contract_year,contract_num,create_date) values ('" & Me.getProjectCode & "','" & Year(gWs.GetSysTime).ToString & "','" & MaxNum & "','" & gWs.GetSysTime & "')")
            End If

        End If




        'If Trim(txtContractNum.Text) = "" Then
        '    Dim dtProjectContract As DataTable
        '    Dim MaxNum As String
        '    Dim tmpLen As Integer
        '    Dim i As Integer

        '    '判断是否额度项下保函，如果不是，使用新合同号，否则，不显示合同号
        '    Dim dsProject As DataSet = gWs.GetCommonQueryInfo("select workflow from project where project_code='" & Me.getProjectCode & "'")
        '    If IIf(IsDBNull(dsProject.Tables(0).Rows(0).Item("workflow")), "", dsProject.Tables(0).Rows(0).Item("workflow")) <> "额度项下保函" Then
        '        dtProjectContract = gWs.GetCommonQueryInfo("select top 1 contract_num from project_contract_num where contract_year='" & Year(gWs.GetSysTime).ToString & "' order by contract_num desc").Tables(0)
        '        If dtProjectContract.Rows.Count <> 0 Then
        '            MaxNum = CInt(dtProjectContract.Rows(0).Item("contract_num")) + 1
        '        Else
        '            MaxNum = "1"
        '        End If

        '        tmpLen = 3 - Len(MaxNum)
        '        For i = 0 To tmpLen - 1
        '            MaxNum = "0" & MaxNum
        '        Next

        '        txtContractNum.Text = MaxNum
        '        gWs.GetCommonQueryInfo("insert into project_contract_num (project_code,contract_year,contract_num,create_date) values ('" & Me.getProjectCode & "','" & Year(gWs.GetSysTime).ToString & "','" & MaxNum & "','" & gWs.GetSysTime & "')")
        '    Else
        '        txtContractNum.Text = ""
        '        'dtProjectContract = gWs.GetCommonQueryInfo("select top 1 contract_num from project_contract_num where project_contract_num.project_code in (select project.project_code from project where project.project_code like '" & Me.getProjectCode.Substring(1, 5) & "%' and isnull(project.workflow,'')='保函综合授信') order by create_date desc").Tables(0)
        '        'If dtProjectContract.Rows.Count <> 0 Then
        '        '    txtContractNum.Text = dtProjectContract.Rows(0).Item("contract_num")
        '        'End If
        '    End If



        'End If

    End Function

End Class
