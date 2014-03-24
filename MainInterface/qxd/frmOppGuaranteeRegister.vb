

Public Class frmOppGuaranteeRegister
    Inherits MainInterface.frmOppGuarantee

    Private strProjectCode As String
    Private strCorporationName As String
    Private strWorkFlowID As String
    Private strTaskID As String
    Private strPerson As String

    Private strItemCode As String = "001"

    Private currentIndex As Integer '当前选中行的位置
    Private add_num As Integer = 0
    Private strStatus As String = "申请"
    Private serialNum As String

    Private strDir As String = "\Document\Image\" '图片保存的目录
    Private dsOppGuaranteeView As DataSet '显示
    Private dsDetailView As DataSet '显示
    Private dsDetailDeal As DataSet
    Private bmOpp As BindingManagerBase
    Private dsOppGuarantee As DataSet

    Private isSaved As Boolean = False ' 新增和修改则设置isSaved为true，保存后设置为false
    Private isModify As Boolean = False

    Private lastRow As Integer = -1 'currentCell切换时,最后一次更改的行的编号;避免点击同一行的不同cell时做重复的动作

    Private dsProjectCorporation, dsCorporation As DataSet '项目企业表,获取"企业联系人"和"联系电话";对应的字段:corp_contact_person,corp_contact_phone
    Private hasProCorpChanged As Boolean = False '判断是否改变了"企业联系人"和"联系电话"
    Private isExitSave As Boolean = False
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    ' 在"退出"事件中不提示保存成功
    Private strPhase As String = "评审"

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
    Friend WithEvents uploadFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents btnCommit As System.Windows.Forms.Button
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnUpload As System.Windows.Forms.Button
    Public WithEvents btnView As System.Windows.Forms.Button
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents corp_contact_phone As System.Windows.Forms.TextBox
    Friend WithEvents corp_contact_person As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOppGuaranteeRegister))
        Me.btnCommit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnUpload = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.uploadFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnModify = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnImport = New System.Windows.Forms.Button
        Me.corp_contact_phone = New System.Windows.Forms.TextBox
        Me.corp_contact_person = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEvaluateNet
        '
        Me.txtEvaluateNet.Location = New System.Drawing.Point(450, 80)
        Me.txtEvaluateNet.MaxLength = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Size = New System.Drawing.Size(440, 264)
        Me.GroupBox2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Location = New System.Drawing.Point(456, 40)
        Me.GroupBox3.Size = New System.Drawing.Size(288, 264)
        Me.GroupBox3.TabIndex = 2
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.ItemHeight = 12
        Me.cmbType.Location = New System.Drawing.Point(72, 19)
        Me.cmbType.TabIndex = 0
        '
        'txtOriginal
        '
        Me.txtOriginal.Location = New System.Drawing.Point(75, 80)
        Me.txtOriginal.MaxLength = 12
        '
        'cmbMeasure
        '
        Me.cmbMeasure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMeasure.DropDownWidth = 120
        Me.cmbMeasure.ItemHeight = 12
        Me.cmbMeasure.Location = New System.Drawing.Point(312, 19)
        Me.cmbMeasure.Size = New System.Drawing.Size(120, 20)
        Me.cmbMeasure.TabIndex = 1
        '
        'dateEvaluate
        '
        Me.dateEvaluate.Location = New System.Drawing.Point(560, 19)
        Me.dateEvaluate.Size = New System.Drawing.Size(168, 21)
        Me.dateEvaluate.TabIndex = 2
        Me.dateEvaluate.Value = New Date(2003, 4, 3, 11, 27, 30, 687)
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(72, 48)
        Me.txtRemark.MaxLength = 50
        Me.txtRemark.Size = New System.Drawing.Size(656, 21)
        Me.txtRemark.TabIndex = 3
        '
        'txtGuarantee
        '
        Me.txtGuarantee.Location = New System.Drawing.Point(629, 80)
        Me.txtGuarantee.MaxLength = 12
        Me.txtGuarantee.Size = New System.Drawing.Size(98, 21)
        Me.txtGuarantee.TabIndex = 6
        '
        'dgOppGuarantee
        '
        Me.dgOppGuarantee.AccessibleName = "DataGrid"
        Me.dgOppGuarantee.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgOppGuarantee.Size = New System.Drawing.Size(434, 244)
        Me.dgOppGuarantee.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'dgDetail
        '
        Me.dgDetail.AccessibleName = "DataGrid"
        Me.dgDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgDetail.Size = New System.Drawing.Size(282, 244)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 344)
        Me.GroupBox4.Size = New System.Drawing.Size(736, 112)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.Controls.SetChildIndex(Me.txtEvaluateNet, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label7, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label4, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txtOriginal, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label5, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txtEvaluate, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txtGuarantee, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label8, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label3, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.cmbType, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label6, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.cmbMeasure, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label9, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label10, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.dateEvaluate, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txtRemark, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label11, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txtContract, 0)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 19)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 86)
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(175, 86)
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(240, 19)
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(558, 83)
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(480, 19)
        Me.Label9.Size = New System.Drawing.Size(80, 23)
        Me.Label9.Text = "预约评估日期"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 48)
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(376, -64)
        Me.Label11.Size = New System.Drawing.Size(56, 61)
        '
        'txtContract
        '
        Me.txtContract.Location = New System.Drawing.Point(440, -64)
        Me.txtContract.Size = New System.Drawing.Size(208, 21)
        '
        'txtName
        '
        Me.txtName.Size = New System.Drawing.Size(424, 21)
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(645, 464)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 11
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
        Me.ImageListBasic.Images.SetKeyName(25, "")
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(562, 464)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 10
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(479, 464)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 24)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 13
        Me.btnNew.ImageList = Me.ImageListBasic
        Me.btnNew.Location = New System.Drawing.Point(230, 464)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 24)
        Me.btnNew.TabIndex = 6
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpload
        '
        Me.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpload.Enabled = False
        Me.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpload.ImageIndex = 25
        Me.btnUpload.ImageList = Me.ImageListBasic
        Me.btnUpload.Location = New System.Drawing.Point(131, 464)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(93, 24)
        Me.btnUpload.TabIndex = 5
        Me.btnUpload.Text = "上载图片(&U)"
        Me.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnView
        '
        Me.btnView.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.ImageIndex = 17
        Me.btnView.ImageList = Me.ImageListBasic
        Me.btnView.Location = New System.Drawing.Point(32, 464)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(93, 24)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "浏览图片(&V)"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(313, 464)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 24)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "类型"
        Me.DataGridTextBoxColumn4.MappingName = "type_name"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "原值"
        Me.DataGridTextBoxColumn5.MappingName = "original_value"
        Me.DataGridTextBoxColumn5.NullText = "0.00"
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AllowSorting = False
        Me.DataGridTableStyle2.DataGrid = Me.dgOppGuarantee
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "opposite_guarantee"
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "类型"
        Me.DataGridTextBoxColumn6.MappingName = "type_name"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = "yyyy年MM月dd日"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "预约评估日期"
        Me.DataGridTextBoxColumn7.MappingName = "evaluate_date"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 95
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "反担保方式"
        Me.DataGridTextBoxColumn8.MappingName = "opposite_guarantee_form"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.ReadOnly = True
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "原值(元)"
        Me.DataGridTextBoxColumn3.MappingName = "original_value"
        Me.DataGridTextBoxColumn3.NullText = "0"
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "评估总值(元)"
        Me.DataGridTextBoxColumn10.MappingName = "evaluate_value"
        Me.DataGridTextBoxColumn10.NullText = "0"
        Me.DataGridTextBoxColumn10.ReadOnly = True
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "担保额(元)"
        Me.DataGridTextBoxColumn11.MappingName = "guarantee_value"
        Me.DataGridTextBoxColumn11.NullText = "0"
        Me.DataGridTextBoxColumn11.ReadOnly = True
        Me.DataGridTextBoxColumn11.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "备注"
        Me.DataGridTextBoxColumn9.MappingName = "remark"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "状态"
        Me.DataGridTextBoxColumn14.MappingName = "status"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 75
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "评估净值(元)"
        Me.DataGridTextBoxColumn15.MappingName = "evaluate_net_value"
        Me.DataGridTextBoxColumn15.NullText = "0"
        Me.DataGridTextBoxColumn15.ReadOnly = True
        Me.DataGridTextBoxColumn15.Width = 75
        '
        'btnModify
        '
        Me.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.ImageIndex = 14
        Me.btnModify.ImageList = Me.ImageListBasic
        Me.btnModify.Location = New System.Drawing.Point(396, 464)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(77, 24)
        Me.btnModify.TabIndex = 8
        Me.btnModify.Text = "修 改(&M)"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(248, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 23)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Label8"
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImport.ImageIndex = 16
        Me.btnImport.ImageList = Me.ImageListBasic
        Me.btnImport.Location = New System.Drawing.Point(544, 312)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(120, 24)
        Me.btnImport.TabIndex = 12
        Me.btnImport.Text = "导入反担保物(&I)"
        Me.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'corp_contact_phone
        '
        Me.corp_contact_phone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.corp_contact_phone.Location = New System.Drawing.Point(304, 314)
        Me.corp_contact_phone.Name = "corp_contact_phone"
        Me.corp_contact_phone.Size = New System.Drawing.Size(144, 21)
        Me.corp_contact_phone.TabIndex = 22
        '
        'corp_contact_person
        '
        Me.corp_contact_person.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.corp_contact_person.Location = New System.Drawing.Point(88, 314)
        Me.corp_contact_person.Name = "corp_contact_person"
        Me.corp_contact_person.Size = New System.Drawing.Size(128, 21)
        Me.corp_contact_person.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(232, 317)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "联系电话"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(16, 317)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(65, 12)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "企业联系人"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmOppGuaranteeRegister
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(754, 495)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.corp_contact_phone)
        Me.Controls.Add(Me.corp_contact_person)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCommit)
        Me.Name = "frmOppGuaranteeRegister"
        Me.Text = "登记反担保措施"
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnNew, 0)
        Me.Controls.SetChildIndex(Me.btnUpload, 0)
        Me.Controls.SetChildIndex(Me.btnView, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.btnModify, 0)
        Me.Controls.SetChildIndex(Me.btnImport, 0)
        Me.Controls.SetChildIndex(Me.corp_contact_person, 0)
        Me.Controls.SetChildIndex(Me.corp_contact_phone, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.txtName, 0)
        Me.Controls.SetChildIndex(Me.Label13, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'Load()
    Private Sub frmOppGuaranteeRegister_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.strProjectCode = Me.getProjectCode()
        Me.strCorporationName = Me.getCorporationName()
        Me.strWorkFlowID = Me.getWorkFlowID()
        Me.strTaskID = Me.getTaskID()
        Me.strPerson = Me.getUser

        Me.txtCode.Text = Me.strProjectCode
        Me.txtName.Text = Me.strCorporationName

        strPhase = Me.getPhase(Me.strProjectCode)
        getProjectCorporation(Me.strProjectCode, strPhase)

        Try
            Me.dateEvaluate.Value = gWs.GetSysTime()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try


        'dsOppGuarantee = Me.getOppGuaranteeRecord(strProjectCode, "0")
        'dsOppGuarantee.Tables("opposite_guarantee_detail").Columns.Add("item_name")
        'Dim dsxy As DataSet

        'dsOppGuarantee.Tables("opposite_guarantee").PrimaryKey = New DataColumn() {dsOppGuarantee.Tables("opposite_guarantee").Columns("project_code"), dsOppGuarantee.Tables("opposite_guarantee").Columns("serial_num")}
        'dsOppGuarantee.Tables("opposite_guarantee_detail").PrimaryKey = New DataColumn() {dsOppGuarantee.Tables("opposite_guarantee_detail").Columns("project_code"), dsOppGuarantee.Tables("opposite_guarantee_detail").Columns("serial_num"), dsOppGuarantee.Tables("opposite_guarantee_detail").Columns("item_type"), dsOppGuarantee.Tables("opposite_guarantee_detail").Columns("item_code")}
        'dsOppGuarantee.Relations.Add("detail", New DataColumn() {dsOppGuarantee.Tables("opposite_guarantee").Columns("project_code"), dsOppGuarantee.Tables("opposite_guarantee").Columns("serial_num")}, New DataColumn() {dsOppGuarantee.Tables("opposite_guarantee_detail").Columns("project_code"), dsOppGuarantee.Tables("opposite_guarantee_detail").Columns("serial_num")}, False)


        dsOppGuaranteeView = Me.getOppGuaranteeRecord(strProjectCode, "0")
        If Not dsOppGuaranteeView Is Nothing Then
            Me.dgOppGuarantee.DataSource = dsOppGuaranteeView.Tables("opposite_guarantee")
            Me.dsOppGuaranteeView.AcceptChanges()
            Me.setDgAttribute(Me.dgOppGuarantee)
        End If

        Try
            dsDetailDeal = gWs.GetGuarantyInfo("null", "null")
        Catch ex As Exception
        End Try
        If Not dsDetailDeal Is Nothing Then
            dsDetailDeal.Tables("opposite_guarantee_detail").Columns.Add("item_name", GetType(String))
        End If
        If Not dsOppGuaranteeView Is Nothing Then
            Me.bmOpp = Me.BindingContext(dsOppGuaranteeView, "opposite_guarantee")
        End If
        getOppGuaranteeType() '设置类型
        getOppGuaranteeMeasure() '设置措施
        Me.txtOriginal.Enabled = False
        Me.txtGuarantee.Enabled = False
        Me.txtEvaluate.Enabled = False
        Me.txtEvaluateNet.Enabled = False
        Me.txtContract.Enabled = False
        setTextBox(False)
        If Not dsOppGuaranteeView Is Nothing Then
            Me.dsOppGuaranteeView.AcceptChanges()
        End If
        If Not dsDetailDeal Is Nothing Then
            Me.dsDetailDeal.AcceptChanges()
        End If
        If Not dsDetailView Is Nothing Then
            Me.dsDetailView.AcceptChanges()
        End If
        getDetail()
        setButton()
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.dgDetail.TableStyles(0).GridColumnStyles(1).ReadOnly = True

        AddHandler corp_contact_person.TextChanged, AddressOf corp_contact_person_TextChanged
        AddHandler corp_contact_phone.TextChanged, AddressOf corp_contact_phone_TextChanged

        'Me.dgOppGuarantee.SetDataBinding(dsOppGuarantee, "opposite_guarantee")
        'Me.dgDetail.SetDataBinding(dsOppGuarantee, "opposite_guarantee.detail")
    End Sub
    '
    '设置Text的Enabled属性
    '
    Private Sub setTextBox(ByVal isEnabled As Boolean)
        Me.cmbType.Enabled = isEnabled
        Me.dateEvaluate.Enabled = isEnabled
        Me.txtRemark.Enabled = isEnabled
        Me.cmbMeasure.Enabled = isEnabled

        Me.txtOriginal.Enabled = isEnabled
        'Me.txtEvaluate.Enabled = isEnabled
        Me.txtGuarantee.Enabled = isEnabled
    End Sub
    '
    '浏览
    '
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim ds As DataSet
        Dim strCode As String
        Dim strRelationNum As String
        Dim strItemType As String

        Dim index As Integer
        index = Me.dgOppGuarantee.CurrentRowIndex
        If index < 0 Then
            Exit Sub
        End If

        ds = dsOppGuaranteeView
        If Not ds.Tables("opposite_guarantee").Rows(index).Item("project_code") Is System.DBNull.Value Then
            strCode = ds.Tables("opposite_guarantee").Rows(index).Item("project_code")
        End If
        If Not ds.Tables("opposite_guarantee").Rows(index).Item("guaranty_type") Is System.DBNull.Value Then
            strItemType = ds.Tables("opposite_guarantee").Rows(index).Item("guaranty_type")
        End If
        'qxd modify 2004-8-17
        'If Not ds.Tables("opposite_guarantee").Rows(index).Item("file_relation_num") Is System.DBNull.Value Then
        '    strRelationNum = ds.Tables("opposite_guarantee").Rows(index).Item("file_relation_num")
        '    Me.Cursor = Cursors.WaitCursor
        '    Dim docClass As New frmDocumentClass("")
        '    'docClass.openFileList(strProjectCode, strItemType, "", strDir)
        '    docClass.openFileList(strProjectCode, "2%", "", strDir)
        '    Me.Cursor = Cursors.Default
        'Else
        '    'MsgBox("没有相关的图片!", MsgBoxStyle.Exclamation, "提示")
        '    SWDialogBox.MessageBox.Show("$1005", "图片")
        'End If
        Me.Cursor = Cursors.WaitCursor
        Dim docClass As New frmDocumentClass("")
        'docClass.openFileList(strProjectCode, strItemType, "", strDir)
        docClass.openFileList(strProjectCode, "2%", "", strDir)
        Me.Cursor = Cursors.Default
    End Sub
    '提交
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Dim dt As DataTable
        Try
            dt = CType(Me.dgOppGuarantee.DataSource, DataTable)
            If Not dt Is Nothing Then
                If Not dt.Rows.Count > 0 Then
                    'MsgBox("没有反担保物记录，无需提交！", MsgBoxStyle.Exclamation, "提示")
                    'SWDialogBox.MessageBox.Show("$1005", "反担保物")
                    If MessageBox.Show("没有反担保记录，是否确认提交！", "反担保物", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
                        Exit Sub
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
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
        Dim strCommit As String
        Try
            strCommit = gWs.finishedTask(strWorkFlowID, strProjectCode, strTaskID, "", strPerson)
        Catch ex As Exception
        End Try
        If "1" = strCommit Then
            'MsgBox("提交成功!", MsgBoxStyle.Information, "提示")
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            raiseCommitSucceed()
            Me.Close()
        Else
            'MsgBox("提交失败!" & strCommit, MsgBoxStyle.Critical, "提示")
            SWDialogBox.MessageBox.Show("*999", "", strCommit, "")
        End If
    End Sub
    '
    '获得反担保物的详细信息
    '
    Private Sub getDetail()
        Dim index As Integer
        Dim strCode, strSerial, strType, strState As String
        index = Me.dgOppGuarantee.CurrentRowIndex
        If index < 0 Then
            Exit Sub
        End If
        Try
            strCode = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("project_code")
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("serial_num") Is System.DBNull.Value Then
            strSerial = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("serial_num")
            If Not dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("guaranty_type") Is System.DBNull.Value Then
                strType = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("guaranty_type")
            End If
            If Not dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("status") Is System.DBNull.Value Then
                strState = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("status")
            End If
            dsDetailView = getOppGuaranteeDetail(strCode, strSerial, strType)
            If dsDetailView.Tables("opposite_guarantee_detail").Rows.Count > 0 Then
                Me.dgDetail.TableStyles.Clear()
                addStyle(Me.dsDetailView)
                Me.dgDetail.DataSource = dsDetailView.Tables("opposite_guarantee_detail")
                Me.dsDetailView.AcceptChanges()
                Me.setDgAttribute(Me.dgDetail)
            Else
                Me.dgDetail.DataSource = dsDetailDeal.Tables("opposite_guarantee_detail")
                Me.setDgAttribute(Me.dgDetail)
            End If
        Else
            dsDetailView.Tables("opposite_guarantee_detail").Clear()
        End If
    End Sub
    '设置按钮的Enabled属性
    Private Sub setButton()
        Dim dt As DataTable
        Try
            dt = CType(Me.dgOppGuarantee.DataSource, DataTable)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    Me.btnDelete.Enabled = True
                    Me.btnModify.Enabled = True
                    'Me.btnUpload.Enabled = True
                    setButtonApply()
                    ' qxd modify 2004-8-17
                    If IsAllowViewPicture() Then
                        Me.btnView.Enabled = True
                    Else
                        Me.btnView.Enabled = False
                    End If
                    'If dt.Rows(Me.dgOppGuarantee.CurrentRowIndex).Item("file_relation_num") Is System.DBNull.Value Then
                    '    Me.btnView.Enabled = False
                    'Else
                    '    Me.btnView.Enabled = True
                    'End If
                Else
                    Me.btnDelete.Enabled = False
                    Me.btnModify.Enabled = False
                    Me.btnUpload.Enabled = False
                    Me.btnView.Enabled = False
                End If
            Else
                Me.btnDelete.Enabled = False
                Me.btnModify.Enabled = False
                Me.btnUpload.Enabled = False
                Me.btnView.Enabled = False
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '根据反担保物状态,是否是"申请"进行判断是否允许:修改,上载,删除
    Private Sub setButtonApply()
        Dim dt As DataTable
        Dim dr As DataRow
        Try
            dt = CType(Me.dgOppGuarantee.DataSource, DataTable)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    dr = dt.Rows(Me.dgOppGuarantee.CurrentRowIndex)
                    'Me.btnUpload.Enabled = True
                    If Not dr.Item("status") Is System.DBNull.Value Then
                        If Not dr.Item("status") = "申请" Then
                            'Me.btnModify.Enabled = True
                            'Me.btnDelete.Enabled = True
                            'Me.btnUpload.Enabled = True
                            'Else
                            Me.btnModify.Enabled = False
                            Me.btnDelete.Enabled = False
                            Me.btnUpload.Enabled = False
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '设置反担保物信息
    '
    Private Sub getOppGuaranteeInfo()
        Dim index As Integer
        Dim dt As DataTable
        index = Me.dgOppGuarantee.CurrentRowIndex
        dt = CType(Me.dgOppGuarantee.DataSource, DataTable)
        If index < 0 Then
            Exit Sub
        End If
        Try
            With dt.Rows(index)
                If Not .Item("original_value") Is System.DBNull.Value Then
                    Me.txtOriginal.Text = .Item("original_value")
                Else
                    Me.txtOriginal.Text = ""
                End If
                If Not .Item("evaluate_value") Is System.DBNull.Value Then
                    Me.txtEvaluate.Text = .Item("evaluate_value")
                Else
                    Me.txtEvaluate.Text = ""
                End If
                If Not .Item("evaluate_net_value") Is System.DBNull.Value Then
                    Me.txtEvaluateNet.Text = .Item("evaluate_net_value")
                Else
                    Me.txtEvaluateNet.Text = ""
                End If
                If Not .Item("guarantee_value") Is System.DBNull.Value Then
                    Me.txtGuarantee.Text = .Item("guarantee_value")
                Else
                    Me.txtGuarantee.Text = ""
                End If
                If Not .Item("evaluate_date") Is System.DBNull.Value Then
                    Me.dateEvaluate.Value = .Item("evaluate_date")
                Else
                    Try
                        Me.dateEvaluate.Value = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End If
                If Not .Item("contract_no") Is System.DBNull.Value Then
                    Me.txtContract.Text = .Item("contract_no")
                Else
                    Me.txtContract.Text = ""
                End If
                If Not .Item("remark") Is System.DBNull.Value Then
                    Me.txtRemark.Text = .Item("remark")
                Else
                    Me.txtRemark.Text = ""
                End If
                If Not .Item("guaranty_type") Is System.DBNull.Value Then
                    Me.cmbType.Text = getGuaranteeType(.Item("guaranty_type"))
                End If
                If Not .Item("opposite_guarantee_form") Is System.DBNull.Value Then
                    Me.cmbMeasure.Text = getGuaranteeForm(.Item("opposite_guarantee_form"))
                End If
            End With
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '上载图片
    '
    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        '根据详细信息获得project_code serial_num item_type,
        '并查询表opposite_guarantee中的file_relation_num是否为空
        '为空,则从表number中取得一数字(上传图片时,更新file_relation_num);不为空,则取出file_relation_num的值
        '获取文件,并保存到project_files
        '
        Dim ds, dsGuarantee As DataSet
        Dim strCode As String
        Dim strSerial As String
        Dim strItemType As String

        Dim index As Integer
        index = dgDetail.CurrentRowIndex
        If index < 0 Then
            'MsgBox("请选中详细信息的记录!", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$X023")
            Exit Sub
        End If
        If Not dsDetailView Is Nothing Then
            ds = dsDetailView
            strCode = ds.Tables("opposite_guarantee_detail").Rows(index).Item("project_code")
            strSerial = ds.Tables("opposite_guarantee_detail").Rows(index).Item("serial_num")
            strItemType = ds.Tables("opposite_guarantee_detail").Rows(index).Item("item_type")
            Dim i As Integer
            Dim strFileRelationNum As String
            Try
                dsGuarantee = gWs.GetGuarantyInfo("{project_code='" & strCode & "' and serial_num='" & strSerial & "' and guaranty_type='" & strItemType & "'}", "null")
                i = dsGuarantee.Tables("opposite_guarantee").Rows.Count
            Catch ex As Exception
            End Try
            If i > 0 Then
                If Not dsGuarantee.Tables("opposite_guarantee").Rows(0).Item("file_relation_num") Is System.DBNull.Value Then
                    strFileRelationNum = dsGuarantee.Tables("opposite_guarantee").Rows(0).Item("file_relation_num")
                End If
                If strFileRelationNum = "" Then
                    strFileRelationNum = getRelationNumber()
                    dsGuarantee.Tables("opposite_guarantee").Rows(0).Item("file_relation_num") = strFileRelationNum
                Else
                End If
                '保存图片
                Dim docClass As New frmDocumentClass("")
                If "1" = docClass.uploadDocument(strProjectCode, strFileRelationNum, strItemType, strItemCode, True, False, False) Then
                    '更新opposite_guarantee的file_relation_num字段
                    dsGuarantee.Tables("opposite_guarantee").Rows(0).Item("file_relation_num") = strFileRelationNum
                    gWs.UpdateGuaranty(dsGuarantee)
                End If
            End If
            '重新获得反担保物信息
            dsOppGuaranteeView = Me.getOppGuaranteeRecord(strProjectCode, "0")
            Me.dgOppGuarantee.DataSource = dsOppGuaranteeView.Tables("opposite_guarantee")
            Me.dsOppGuaranteeView.AcceptChanges()
            Me.setDgAttribute(Me.dgOppGuarantee)
            If Not dsOppGuaranteeView Is Nothing Then
                Me.bmOpp = Me.BindingContext(dsOppGuaranteeView, "opposite_guarantee")
            End If
        End If
        setButton()
    End Sub
    '
    '从表number中获得最大数,供relation_num用
    '
    Private Function getRelationNumber() As String
        Try
            Return gWs.GetRelationID()
        Catch ex As Exception
        End Try
    End Function
    '
    '新增
    '
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            If Not dsOppGuaranteeView Is Nothing Then
                If btnNew.Text = "新 增(&N)" Then
                    isSaved = True
                    Me.btnDelete.Enabled = False
                    Me.btnModify.Enabled = False
                    Me.btnView.Enabled = False
                    Me.btnUpload.Enabled = False
                    Me.btnCommit.Enabled = False

                    setTextBox(True)

                    Me.cmbType.Focus()
                    delBinding()
                    addBinding()
                    addOppGuarantee(strProjectCode)

                    btnNew.Text = "取 消(&C)"
                    Me.dgOppGuarantee.Enabled = False

                    setEvaTextEnabled(Me.dsOppGuaranteeView)

                    Me.DataGridTextBoxColumn2.ReadOnly = False
                    Me.dgDetail.TableStyles(0).GridColumnStyles(1).ReadOnly = False
                ElseIf btnNew.Text = "取 消(&C)" Then
                    dsDetailDeal.Clear()
                    isSaved = False
                    btnNew.Text = "新 增(&N)"
                    Me.btnDelete.Enabled = True
                    Me.btnModify.Enabled = True
                    Me.btnView.Enabled = True
                    'Me.btnUpload.Enabled = True
                    Me.btnCommit.Enabled = True
                    Me.dgOppGuarantee.Enabled = True
                    setTextBox(False)
                    delBinding()
                    '数据回滚
                    Me.dsOppGuaranteeView.RejectChanges()
                    Me.dsDetailView.RejectChanges()
                    setButton()
                    Me.DataGridTextBoxColumn2.ReadOnly = True
                    Me.dgDetail.TableStyles(0).GridColumnStyles(1).ReadOnly = True
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.txtEvaluate.Enabled = False
            Me.txtEvaluateNet.Enabled = False
        End Try
    End Sub
    '
    '添加绑定
    '
    Private Sub addBinding()
        If Not dsOppGuaranteeView Is Nothing Then
            Me.txtOriginal.DataBindings.Add("Text", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "original_value")
            Me.txtEvaluate.DataBindings.Add("Text", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "evaluate_value")
            Me.txtEvaluateNet.DataBindings.Add("Text", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "evaluate_net_value")
            Me.txtGuarantee.DataBindings.Add("Text", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "guarantee_value")

            Me.dateEvaluate.DataBindings.Add("Value", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "evaluate_date")
            Me.txtContract.DataBindings.Add("Text", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "contract_no")
            Me.txtRemark.DataBindings.Add("Text", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "remark")
        End If
    End Sub
    '
    '删除绑定
    '
    Private Sub delBinding()
        Me.txtOriginal.DataBindings.Clear()
        Me.txtEvaluate.DataBindings.Clear()
        Me.txtEvaluateNet.DataBindings.Clear()
        Me.txtGuarantee.DataBindings.Clear()

        Me.dateEvaluate.DataBindings.Clear()
        Me.txtContract.DataBindings.Clear()
        Me.txtRemark.DataBindings.Clear()
    End Sub
    '
    '新增反担保物记录
    '
    Private Function addOppGuarantee(ByVal strProjectCode As String) As String
        Dim dr As DataRow
        Dim strSerialNum As String
        Dim strItemType As String
        Dim strDateTime As Date
        Try
            strDateTime = gWs.GetSysTime()
            Me.dateEvaluate.Value = strDateTime.ToShortDateString
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        strItemType = getGuaranteeCode(Me.cmbType.Text)
        Try
            'qxd modify 2003-11-4
            strSerialNum = gWs.GetMaxGuarantyNum(strProjectCode) '+ add_num
            'add_num = add_num + 1
            'qxd end
            If Not dsOppGuaranteeView Is Nothing Then
                dr = Me.dsOppGuaranteeView.Tables("opposite_guarantee").NewRow
                With dr
                    .Item("project_code") = strProjectCode
                    .Item("serial_num") = strSerialNum
                    .Item("type_name") = Me.cmbType.Text
                    .Item("guaranty_type") = strItemType
                    .Item("opposite_guarantee_form") = getGuaranteeFormCode(Me.cmbMeasure.Text)
                    .Item("evaluate_date") = Me.dateEvaluate.Value
                    .Item("contract_no") = Me.txtContract.Text
                    .Item("remark") = Me.txtRemark.Text
                    .Item("status") = strStatus
                    .Item("create_person") = strPerson
                    .Item("create_date") = strDateTime
                End With
                dsOppGuaranteeView.Tables("opposite_guarantee").Rows.Add(dr)
                'addDetail(strSerialNum)
                addDetail(strSerialNum, strItemType)
                serialNum = strSerialNum
                If Not dsOppGuaranteeView Is Nothing Then
                    Me.bmOpp = Me.BindingContext(dsOppGuaranteeView, "opposite_guarantee")
                End If
                Me.dgOppGuarantee.CurrentRowIndex = bmOpp.Count - 1
                Return strSerialNum
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    '
    '新增时,添加详细信息
    '
    Private Sub addDetail(ByVal strSerialNum As String, ByVal strItemType As String)

        Dim i, len, count As Integer
        Dim dsTemp As DataSet
        Dim dsCopy As DataSet '从opposite_guarantee_detail中查找是否有相同的类型的反担保物详细信息
        Dim drTemp As DataRow
        Dim strSql As String
        Dim strItemCode As String '反担保物类型的code

        'strItemType = getGuaranteeCode(Me.cmbType.Text)
        strSql = "{project_code='" & strProjectCode & "' and item_type='" & strItemType & "' order by serial_num desc}"

        Try
            dsCopy = gWs.GetGuarantyInfo("nul", strSql)
            count = dsCopy.Tables("opposite_guarantee_detail").Rows.Count

            dsTemp = getItemDataSet(strItemType)
            len = dsTemp.Tables("TItem").Rows.Count

            'For i = 0 To i - 1'qxd closeed 2003-9-19 14:00
            If dsDetailDeal Is Nothing Then
                Try
                    dsDetailDeal = gWs.GetGuarantyInfo("null", "null")
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
            End If
            If len > 0 Then
                For i = 0 To len - 1
                    drTemp = dsDetailDeal.Tables("opposite_guarantee_detail").NewRow
                    strItemCode = dsTemp.Tables("TItem").Rows(i).Item("item_code")
                    With drTemp
                        .Item("project_code") = strProjectCode
                        .Item("serial_num") = strSerialNum
                        .Item("item_type") = getGuaranteeCode(Me.cmbType.Text)
                        .Item("item_name") = dsTemp.Tables("TItem").Rows(i).Item("item_name")

                        Dim temp As String
                        If count > 0 Then
                            If dsCopy.Tables("opposite_guarantee_detail").Select("item_code='" & strItemCode & "'").Length > 0 Then
                                temp = dsCopy.Tables("opposite_guarantee_detail").Select("item_code='" & strItemCode & "'")(0).Item("item_value") & ""
                            Else
                                temp = ""
                            End If
                        Else
                            temp = ""
                        End If

                        .Item("item_value") = temp

                        .Item("item_code") = strItemCode
                        .Item("create_person") = strPerson
                        .Item("create_date") = Me.dateEvaluate.Value
                    End With
                    dsDetailDeal.Tables("opposite_guarantee_detail").Rows.Add(drTemp)
                    dsDetailView = dsDetailDeal 'qxd modify 2003-4-12
                Next
                Me.dgDetail.DataSource = Nothing 'xie
                Me.dgDetail.DataSource = dsDetailDeal.Tables("opposite_guarantee_detail") 'qxd
                setDgAttribute(dgDetail)
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '设置不同措施
    '
    Private Sub cmbMeasure_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMeasure.SelectedValueChanged
        If isSaved Then
            Dim dr As DataRow
            Dim i As Integer
            i = dsOppGuaranteeView.Tables("opposite_guarantee").Rows.Count
            If i > 0 Then
                dr = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(i - 1)
                With dr
                    .Item("opposite_guarantee_form") = getGuaranteeFormCode(Me.cmbMeasure.Text)
                End With
                Me.dgOppGuarantee.CurrentRowIndex = Me.bmOpp.Count - 1
            End If
        End If
        If isModify Then
            Dim dr As DataRow
            Dim i As Integer
            i = Me.dgOppGuarantee.CurrentRowIndex
            If i >= 0 Then
                dr = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(i)
                With dr
                    .Item("opposite_guarantee_form") = getGuaranteeFormCode(Me.cmbMeasure.Text)
                End With
            End If
        End If
    End Sub
    '
    '改变类型时,重新设置详细信息和反担保物类型
    '
    Private Sub cmbType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectedValueChanged
        If isSaved Then
            Dim dr As DataRow
            Dim i As Integer
            Dim strItemType As String = getGuaranteeCode(Me.cmbType.Text)
            i = dsOppGuaranteeView.Tables("opposite_guarantee").Rows.Count
            If i > 0 Then
                dr = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(i - 1)
                With dr
                    .Item("type_name") = Me.cmbType.Text
                    .Item("guaranty_type") = getGuaranteeCode(Me.cmbType.Text)
                End With
                Me.dgOppGuarantee.CurrentRowIndex = Me.bmOpp.Count - 1
                dsDetailDeal.Clear()
                addDetail(serialNum, strItemType)
                setEvaTextEnabled(Me.dsOppGuaranteeView)
                Me.txtEvaluate.Enabled = False
                Me.txtEvaluateNet.Enabled = False
            End If
        End If
    End Sub
    '
    '保存
    '
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim strGuaranteeCode As String = getGuaranteeCode(Me.cmbType.Text)
        If strGuaranteeCode = "26" Then
            Dim row As DataRow
            For Each row In dsDetailView.Tables("opposite_guarantee_detail").Rows
                If row("item_code") = "004" Then
                    Try
                        row("item_value") = txtOriginal.Text.Trim()
                    Catch
                    End Try
                End If
            Next
        End If

        SaveProjectCorporation(Me.strProjectCode, strPhase)

        If Not dsOppGuaranteeView Is Nothing Then
            isSaved = False
            delBinding()

            Dim strResult, str As String
            Me.dgOppGuarantee.CurrentRowIndex = currentIndex
            Try
                strResult = gWs.UpdateGuaranty(dsOppGuaranteeView)
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try

            If strResult = "1" Then
                'dsDetailDeal = dsDetailView 'qxd modify 2003-4-12
                Try
                    '新增操作时,保存详细信息
                    str = gWs.UpdateGuaranty(dsDetailDeal)
                    '保证修改详细信息可以保存
                    gWs.UpdateGuaranty(dsDetailView)
                Catch ex As Exception
                End Try
                If str = "1" Then
                    Me.dgDetail.DataSource = Nothing
                    If Not dsDetailDeal Is Nothing Then
                        Me.dsDetailDeal.Clear()
                    End If
                    setTextBox(False)
                    btnNew.Text = "新 增(&N)"
                    btnModify.Text = "修 改(&M)"
                    btnDelete.Enabled = True
                    Me.btnNew.Enabled = True
                    Me.btnModify.Enabled = True
                    Me.btnView.Enabled = True
                    ' Me.btnUpload.Enabled = True
                    Me.btnCommit.Enabled = True
                    Me.dgOppGuarantee.Enabled = True
                    'MsgBox("保存成功!", MsgBoxStyle.Information, "提示")
                    If Not isExitSave Then
                        SWDialogBox.MessageBox.Show("$SaveSucceed")
                    End If
                    lastRow = 0
                End If
                Me.dsOppGuaranteeView.AcceptChanges() 'qxd add 2003-6-7
            Else
                If Not dsDetailDeal Is Nothing Then
                    Me.dsDetailDeal.Clear()
                End If
                'MsgBox("保存失败!" & strResult, MsgBoxStyle.Critical, "提示")
                SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                Me.dsOppGuaranteeView.RejectChanges() 'qxd add 2003-6-7
            End If
            'qxd close 2003-6-7
            'Try
            '    dsOppGuaranteeView = Me.getOppGuaranteeRecord(strProjectCode)
            '    Me.dgOppGuarantee.DataSource = dsOppGuaranteeView.Tables("opposite_guarantee")
            '    Me.dsOppGuaranteeView.AcceptChanges()
            '    Me.setDgAttribute(Me.dgOppGuarantee)
            'Catch ex As Exception
            'Finally
            'End Try
            If Not dsOppGuaranteeView Is Nothing Then
                Me.bmOpp = Me.BindingContext(dsOppGuaranteeView, "opposite_guarantee")
            End If
        End If
        getDetail()
        setButton()
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.dgDetail.TableStyles(0).GridColumnStyles(1).ReadOnly = True
    End Sub
    '
    '删除
    '
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Not dsOppGuaranteeView Is Nothing Then
            Dim relationNum As String
            Dim strDelResult As String
            'If 1 = MsgBox("确定删除选中的记录吗?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "提示") Then
            If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1004", "选中的") Then
                If Me.dgOppGuarantee.CurrentRowIndex >= 0 Then
                    If Not dsOppGuaranteeView.Tables("opposite_guarantee").Rows(Me.dgOppGuarantee.CurrentRowIndex).Item("file_relation_num") Is System.DBNull.Value Then
                        relationNum = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(Me.dgOppGuarantee.CurrentRowIndex).Item("file_relation_num")
                    End If
                    Dim strSerialNum As String
                    strSerialNum = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(Me.dgOppGuarantee.CurrentRowIndex).Item("serial_num")
                    dsOppGuaranteeView.Tables("opposite_guarantee").Rows(Me.dgOppGuarantee.CurrentRowIndex).Delete()

                    If Not dsDetailView Is Nothing Then
                        dsDetailView.Clear()
                    End If
                    Try
                        strDelResult = gWs.UpdateGuaranty(dsOppGuaranteeView.GetChanges())
                    Catch ex As Exception
                    End Try
                    '如果删除记录成功，则也删除project_files中的图片记录
                    If strDelResult = "1" Then
                        delOppDetail(strProjectCode, strSerialNum)
                        If Not relationNum = "" Then
                            delOppFiles(relationNum)
                        End If
                    End If
                    dsOppGuaranteeView = Me.getOppGuaranteeRecord(strProjectCode, "0")
                    Me.dgOppGuarantee.DataSource = dsOppGuaranteeView.Tables("opposite_guarantee")
                    Me.dsOppGuaranteeView.AcceptChanges()
                    Me.setDgAttribute(Me.dgOppGuarantee)
                    If Not dsOppGuaranteeView Is Nothing Then
                        Me.bmOpp = Me.BindingContext(dsOppGuaranteeView, "opposite_guarantee")
                    End If
                    lastRow = 0
                End If
            End If
            setButton()
        End If
    End Sub
    '如果删除记录成功，则也删除project_files中的图片记录
    Private Sub delOppFiles(ByVal relationNum As String)
        Dim strSql As String
        strSql = "delete project_files where relation_num='" & relationNum & "'"
        Try
            gWs.GetCommonQueryInfo(strSql)
        Catch ex As Exception
        Finally
        End Try
    End Sub
    '如果反担保物主表信息删除成功，则同时删除详细信息
    Private Sub delOppDetail(ByVal projectCode As String, ByVal serialNum As String)
        Dim strSql As String
        strSql = "delete opposite_guarantee_detail where project_code='" & projectCode & "' and serial_num='" & serialNum & "'"
        Try
            gWs.GetCommonQueryInfo(strSql)
        Catch ex As Exception
        Finally
        End Try
    End Sub
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        frmExit(sender, e)
    End Sub
    '退出处理
    Private Function frmExit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '根据dataSet判断是否修改了
        Dim changedCount As Integer = 0
        Dim changedCount_detail As Integer = 0

        isExitSave = True

        If Not Me.dsOppGuaranteeView Is Nothing Then
            Try
                changedCount = Me.dsOppGuaranteeView.GetChanges.Tables(0).Rows.Count
            Catch
            End Try
        End If
        If Not Me.dsDetailView Is Nothing Then
            Try
                changedCount_detail = CType(Me.dgDetail.DataSource, DataTable).GetChanges.Rows.Count
            Catch
            End Try
        End If
        If changedCount > 0 Or changedCount_detail > 0 Or Me.hasProCorpChanged Then
            Dim strMesg As Integer
            'strMesg = MsgBox("数据已修改，是否保存？", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "提示")
            strMesg = SWDialogBox.MessageBox.Show("?1003")
            If 6 = strMesg Then
                Call btnSave_Click(sender, e)
                Me.Close()
            ElseIf strMesg = 7 Then
                Me.Close()
            Else
                Return True
            End If
        Else
            Me.Close()
        End If
    End Function
    'KeyPress()
    Private Sub frmOppGuaranteeRegister_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
    End Sub
    'Closing()
    Private Sub frmOppGuaranteeRegister_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If sender.GetType Is GetType(Form) Then
            If frmExit(sender, e) Then
                e.Cancel = True
            End If
        End If
    End Sub
    '修改
    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        If Not dsOppGuaranteeView Is Nothing Then
            If btnModify.Text = "修 改(&M)" Then
                isModify = True
                'isSaved = True
                Me.btnDelete.Enabled = False
                Me.btnNew.Enabled = False
                Me.btnView.Enabled = False
                Me.btnUpload.Enabled = False
                Me.btnCommit.Enabled = False
                Me.dgOppGuarantee.Enabled = False
                currentIndex = Me.dgOppGuarantee.CurrentRowIndex
                Me.dgOppGuarantee.Select(currentIndex)
                setTextBox(True)
                Me.cmbType.Enabled = False
                Me.cmbType.Focus()
                addBinding()
                btnModify.Text = "取 消(&C)"
                setEvaTextEnabled(Me.dsOppGuaranteeView)
                Me.DataGridTextBoxColumn2.ReadOnly = False
                Me.dgDetail.TableStyles(0).GridColumnStyles(1).ReadOnly = False
            ElseIf btnModify.Text = "取 消(&C)" Then
                isModify = False
                'isSaved = False
                Me.btnDelete.Enabled = True
                Me.btnNew.Enabled = True
                Me.btnView.Enabled = True
                'Me.btnUpload.Enabled = True
                Me.btnCommit.Enabled = True
                Me.dgOppGuarantee.Enabled = True
                setTextBox(False)
                btnModify.Text = "修 改(&M)"
                Me.dsOppGuaranteeView.RejectChanges()
                delBinding()
                setButton()
                Me.DataGridTextBoxColumn2.ReadOnly = True
                Me.dgDetail.TableStyles(0).GridColumnStyles(1).ReadOnly = True
            End If
            Me.txtEvaluate.Enabled = False
            Me.txtEvaluateNet.Enabled = False
        End If
    End Sub
    '列表中鼠标按下事件
    Private Sub dgOppGuarantee_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgOppGuarantee.MouseUp
        If Me.dsOppGuaranteeView Is Nothing Then
            Exit Sub
        End If
        If Me.dsOppGuaranteeView.Tables("opposite_guarantee").Rows.Count > 0 Then
            Me.dgOppGuarantee.Select(Me.dgOppGuarantee.CurrentCell.RowNumber)
            currentIndex = Me.dgOppGuarantee.CurrentRowIndex
            If Not isSaved Then
                setButton()
                getDetail()
                getOppGuaranteeInfo()
            End If
            Me.dgOppGuarantee.Select(Me.dgOppGuarantee.CurrentCell.RowNumber)
        End If
        lastRow = Me.dgOppGuarantee.CurrentRowIndex
    End Sub
    '日期改变
    Private Sub dateEvaluate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dateEvaluate.ValueChanged
        'If isSaved Or isModify Then
        '    Try
        '        If Me.dateEvaluate.Value < gWs.GetSysTime() Then
        '            Me.dateEvaluate.Value = gWs.GetSysTime()
        '        End If
        '    Catch ex As Exception
        '        ExceptionHandler.ShowMessageBox(ex)
        '    End Try
        'End If
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim oppImport As FOppImportData = New FOppImportData(strProjectCode, Nothing, Me)
        oppImport.AllowTransparency = False
        oppImport.ShowDialog()
    End Sub

    Public Function setDg() As DataSet
        dsOppGuaranteeView = Me.getOppGuaranteeRecord(strProjectCode, "1")
        If Not dsOppGuaranteeView Is Nothing Then
            Me.dgOppGuarantee.DataSource = dsOppGuaranteeView.Tables("opposite_guarantee")
            Me.dsOppGuaranteeView.AcceptChanges()
            Me.setDgAttribute(Me.dgOppGuarantee)
        End If
        Return dsOppGuaranteeView
    End Function

    '获得项目企业表信息,并设置“企业联系人”和“联系电话”的初始值
    Private Sub getProjectCorporation(ByVal projectCode As String, ByVal phase As String)
        '获取初始值要分几种情况,如果对应的联系人存在,则就是这个值
        '如果不存在,则选择评审中的联系人,
        '如果评审中的不存在,则选择初审中的
        Dim dr As DataRow()
        Try
            Dim strSql As String
            '从基类获取阶段
            strSql = "{project_code='" & projectCode & "' and (phase='初审' or phase='评审') and corporation_code='" & projectCode.Substring(0, 5) & "'}"
            'dsProjectCorporation = gWs.FetchProjectCorporation(strSql)
            dsProjectCorporation = gWs.FetchProjectCorporation(Me.getProjectCode(), "%", "1", Me.getPhase(getProjectCode()))
            If Not dsProjectCorporation Is Nothing AndAlso dsProjectCorporation.Tables(0).Rows.Count > 0 Then
                dr = dsProjectCorporation.Tables(0).Select("phase='评审'")
                If dr.Length = 1 Then
                    If dr(0).Item("corp_contact_person") Is DBNull.Value OrElse dr(0).Item("corp_contact_phone") Is DBNull.Value Then
                        dr = dsProjectCorporation.Tables(0).Select("phase='初审'")
                        If dr.Length = 1 Then
                            If dr(0).Item("corp_contact_person") Is DBNull.Value OrElse dr(0).Item("corp_contact_phone") Is DBNull.Value Then
                                Me.corp_contact_person.Text = dr(0).Item("contact_person") & String.Empty
                                Me.corp_contact_phone.Text = dr(0).Item("contact_phone") & String.Empty
                            Else
                                Me.corp_contact_person.Text = dr(0).Item("corp_contact_person") & String.Empty
                                Me.corp_contact_phone.Text = dr(0).Item("corp_contact_phone") & String.Empty
                            End If
                        End If
                    Else
                        Me.corp_contact_person.Text = dr(0).Item("corp_contact_person") & String.Empty
                        Me.corp_contact_phone.Text = dr(0).Item("corp_contact_phone") & String.Empty
                    End If
                Else '没有联系人信息
                    dr = dsProjectCorporation.Tables(0).Select("phase='初审'")
                    If dr.Length = 1 Then
                        If dr(0).Item("corp_contact_person") Is DBNull.Value OrElse dr(0).Item("corp_contact_phone") Is DBNull.Value Then
                            Me.corp_contact_person.Text = dr(0).Item("contact_person") & String.Empty
                            Me.corp_contact_phone.Text = dr(0).Item("contact_phone") & String.Empty
                        Else
                            Me.corp_contact_person.Text = dr(0).Item("corp_contact_person") & String.Empty
                            Me.corp_contact_phone.Text = dr(0).Item("corp_contact_phone") & String.Empty
                        End If
                    End If
                End If
            Else
                dsCorporation = gWs.GetcorporationInfo("{corporation_code='" & projectCode.Substring(0, 5) & "'}", "NULL")
                If Not dsCorporation.Tables(0).Rows.Count = 0 Then
                    Me.corp_contact_person.Text = dsCorporation.Tables(0).Rows(0)("contact_person") & String.Empty
                    Me.corp_contact_phone.Text = dsCorporation.Tables(0).Rows(0)("phone_num") & String.Empty
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '保存“企业联系人”和“联系电话”到项目企业表
    Private Function SaveProjectCorporation(ByVal projectCode As String, ByVal phase As String) As String
        Dim dr As DataRow()
        Try
            'Dim strSql As String
            ''去掉阶段查询条件，如果尚未进行项目评审，则会企业信息新增记录，引起数据不一致 modify by wzh 2006-06-12
            ''strSql = "{project_code='" & projectCode & "' and (phase='" & phase & "') and corporation_code='" & projectCode.Substring(0, 5) & "'}"
            'strSql = "{project_code='" & projectCode & "'  and corporation_code='" & projectCode.Substring(0, 5) & "'}"
            'dsProjectCorporation = gWs.FetchProjectCorporation(strSql)
            If Not dsProjectCorporation Is Nothing AndAlso dsProjectCorporation.Tables(0).Rows.Count > 0 Then
                dr = dsProjectCorporation.Tables(0).Select("phase='评审'")
                If dr.Length = 1 Then
                    dr(0).Item("corp_contact_person") = Me.corp_contact_person.Text
                    dr(0).Item("corp_contact_phone") = Me.corp_contact_phone.Text
                Else '没有联系人信息
                    dr = dsProjectCorporation.Tables(0).Select("phase='初审'")
                    If dr.Length = 1 Then
                        dr(0).Item("corp_contact_person") = Me.corp_contact_person.Text
                        dr(0).Item("corp_contact_phone") = Me.corp_contact_phone.Text
                    End If
                End If

                hasProCorpChanged = False
                Return gWs.UpdateProjectCorporation(dsProjectCorporation)
                'Else
                'If dsCorporation.Tables(0).Rows.Count > 0 Then
                '    dsCorporation.Tables(0).Rows(0)("contact_person") = Me.corp_contact_person.Text
                '    dsCorporation.Tables(0).Rows(0)("phone_num") = Me.corp_contact_phone.Text

                '    hasProCorpChanged = False
                '    Return gWs.UpdateCorCon(dsCorporation.GetChanges())
                'End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Function

    Private Sub corp_contact_person_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles corp_contact_person.TextChanged
        hasProCorpChanged = True
    End Sub

    Private Sub corp_contact_phone_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) 'Handles corp_contact_phone.TextChanged
        hasProCorpChanged = True
    End Sub

    '
    '如果项目其中的一个反担保物有图片，则查看按钮可用。
    'qxd add 2004－8－17 
    '目的：为了省去查看时，需要选择具体一个反担保物有图片时才允许查看图片的麻烦！
    Private Function IsAllowViewPicture()
        Dim dt As DataTable
        Dim dr As DataRow
        Dim i, count As Integer
        Dim flag As Boolean = False
        Try
            dt = CType(Me.dgOppGuarantee.DataSource, DataTable)

            If Not dt Is Nothing Then
                count = dt.Rows.Count
                If count > 0 Then
                    For i = 0 To count - 1
                        If Not dt.Rows(i).Item("file_relation_num") Is System.DBNull.Value Then
                            flag = True
                            Exit For
                        End If
                    Next
                End If
            End If
            Return flag
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    Private Sub txtOriginal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOriginal.TextChanged
        Dim strGuaranteeCode As String = getGuaranteeCode(Me.cmbType.Text)
        If strGuaranteeCode = "26" Then
            Dim row As DataRow
            For Each row In dsDetailView.Tables("opposite_guarantee_detail").Rows
                If row("item_code") = "004" Then
                    Try
                        row("item_value") = txtOriginal.Text.Trim()
                    Catch
                    End Try
                End If
            Next
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class
