

Public Class frmOppGuaranteeEvaluate
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

    Private isSaved As Boolean = False ' 新增和修改则设置isSaced为true，保存后设置为false
    Private isModify As Boolean = False '是否是修改,用在设置反担保物措施时判断
    Private isNewOrModify As Boolean = False 'false:表示新增;true:表示修改

    Private lastRow As Integer = -1 'currentCell切换时,最后一次更改的行的编号;避免点击同一行的不同cell时做重复的动作

    Private dsProjectCorporation As DataSet '项目企业表,获取"企业联系人"和"联系电话";对应的字段:corp_contact_person,corp_contact_phone
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
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtOriginalTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtEvaluateTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtGuaranteeTotal As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents corp_contact_person As System.Windows.Forms.TextBox
    Friend WithEvents corp_contact_phone As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOppGuaranteeEvaluate))
        Me.btnCommit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnUpload = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.txtGuaranteeTotal = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtEvaluateTotal = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtOriginalTotal = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.btnReport = New System.Windows.Forms.Button
        Me.btnImport = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.corp_contact_person = New System.Windows.Forms.TextBox
        Me.corp_contact_phone = New System.Windows.Forms.TextBox
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEvaluateNet
        '
        Me.txtEvaluateNet.Location = New System.Drawing.Point(427, 80)
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Size = New System.Drawing.Size(416, 248)
        Me.GroupBox2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Location = New System.Drawing.Point(432, 40)
        Me.GroupBox3.Size = New System.Drawing.Size(280, 248)
        Me.GroupBox3.TabIndex = 2
        '
        'cmbType
        '
        Me.cmbType.DropDownWidth = 184
        Me.cmbType.ItemHeight = 12
        Me.cmbType.Size = New System.Drawing.Size(184, 20)
        Me.cmbType.TabIndex = 0
        '
        'txtOriginal
        '
        Me.txtOriginal.Location = New System.Drawing.Point(75, 78)
        Me.txtOriginal.MaxLength = 12
        Me.txtOriginal.TabIndex = 5
        '
        'txtEvaluate
        '
        Me.txtEvaluate.Location = New System.Drawing.Point(254, 79)
        Me.txtEvaluate.MaxLength = 12
        Me.txtEvaluate.TabIndex = 6
        '
        'cmbMeasure
        '
        Me.cmbMeasure.DropDownWidth = 104
        Me.cmbMeasure.ItemHeight = 12
        Me.cmbMeasure.Location = New System.Drawing.Point(360, 25)
        Me.cmbMeasure.Size = New System.Drawing.Size(104, 20)
        Me.cmbMeasure.TabIndex = 1
        '
        'dateEvaluate
        '
        Me.dateEvaluate.Location = New System.Drawing.Point(568, 53)
        Me.dateEvaluate.Size = New System.Drawing.Size(120, 21)
        Me.dateEvaluate.TabIndex = 4
        Me.dateEvaluate.Value = New Date(2003, 4, 22, 11, 4, 16, 656)
        '
        'txtRemark
        '
        Me.txtRemark.MaxLength = 50
        Me.txtRemark.Size = New System.Drawing.Size(392, 21)
        Me.txtRemark.TabIndex = 3
        '
        'txtGuarantee
        '
        Me.txtGuarantee.MaxLength = 12
        Me.txtGuarantee.TabIndex = 7
        '
        'dgOppGuarantee
        '
        Me.dgOppGuarantee.AccessibleName = "DataGrid"
        Me.dgOppGuarantee.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgOppGuarantee.ReadOnly = True
        Me.dgOppGuarantee.Size = New System.Drawing.Size(410, 228)
        Me.dgOppGuarantee.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'dgDetail
        '
        Me.dgDetail.AccessibleName = "DataGrid"
        Me.dgDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgDetail.Size = New System.Drawing.Size(274, 228)
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(8, 384)
        Me.GroupBox4.Size = New System.Drawing.Size(704, 112)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 81)
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(288, 24)
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(532, 85)
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(480, 52)
        Me.Label9.Size = New System.Drawing.Size(80, 23)
        Me.Label9.Text = "确认评估日期"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(480, 24)
        Me.Label11.Size = New System.Drawing.Size(72, 23)
        '
        'txtContract
        '
        Me.txtContract.Location = New System.Drawing.Point(568, 25)
        Me.txtContract.MaxLength = 10
        Me.txtContract.Size = New System.Drawing.Size(120, 21)
        Me.txtContract.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Size = New System.Drawing.Size(392, 21)
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(599, 504)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 12
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
        Me.btnCommit.Location = New System.Drawing.Point(514, 504)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 11
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Enabled = False
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(429, 504)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 24)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnModify
        '
        Me.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModify.Enabled = False
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.ImageIndex = 14
        Me.btnModify.ImageList = Me.ImageListBasic
        Me.btnModify.Location = New System.Drawing.Point(344, 504)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(77, 24)
        Me.btnModify.TabIndex = 9
        Me.btnModify.Text = "修 改(&M)"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Enabled = False
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(259, 504)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 24)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.Enabled = False
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 13
        Me.btnNew.ImageList = Me.ImageListBasic
        Me.btnNew.Location = New System.Drawing.Point(174, 504)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 24)
        Me.btnNew.TabIndex = 7
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnView
        '
        Me.btnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.ImageIndex = 17
        Me.btnView.ImageList = Me.ImageListBasic
        Me.btnView.Location = New System.Drawing.Point(416, 296)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(93, 24)
        Me.btnView.TabIndex = 5
        Me.btnView.Text = "浏览图片(&V)"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AllowSorting = False
        Me.DataGridTableStyle2.DataGrid = Me.dgOppGuarantee
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "opposite_guarantee"
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "类型"
        Me.DataGridTextBoxColumn3.MappingName = "type_name"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "反担保方式"
        Me.DataGridTextBoxColumn10.MappingName = "opposite_guarantee_form"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "原值(元)"
        Me.DataGridTextBoxColumn4.MappingName = "original_value"
        Me.DataGridTextBoxColumn4.NullText = "0"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "评估总值(元)"
        Me.DataGridTextBoxColumn5.MappingName = "evaluate_value"
        Me.DataGridTextBoxColumn5.NullText = "0"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "担保额(元)"
        Me.DataGridTextBoxColumn6.MappingName = "guarantee_value"
        Me.DataGridTextBoxColumn6.NullText = "0"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "日期"
        Me.DataGridTextBoxColumn7.MappingName = "evaluate_date"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "评估师"
        Me.DataGridTextBoxColumn9.MappingName = "evaluate_person"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "备注"
        Me.DataGridTextBoxColumn8.MappingName = "remark"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.MappingName = "guaranty_type"
        Me.DataGridTextBoxColumn13.Width = 0
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
        'btnUpload
        '
        Me.btnUpload.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpload.ImageIndex = 25
        Me.btnUpload.ImageList = Me.ImageListBasic
        Me.btnUpload.Location = New System.Drawing.Point(512, 296)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(93, 24)
        Me.btnUpload.TabIndex = 6
        Me.btnUpload.Text = "上载图片(&U)"
        Me.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox5.Controls.Add(Me.txtGuaranteeTotal)
        Me.GroupBox5.Controls.Add(Me.Label16)
        Me.GroupBox5.Controls.Add(Me.txtEvaluateTotal)
        Me.GroupBox5.Controls.Add(Me.Label15)
        Me.GroupBox5.Controls.Add(Me.txtOriginalTotal)
        Me.GroupBox5.Controls.Add(Me.Label14)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 328)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(704, 48)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "汇总信息"
        '
        'txtGuaranteeTotal
        '
        Me.txtGuaranteeTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGuaranteeTotal.Location = New System.Drawing.Point(552, 19)
        Me.txtGuaranteeTotal.Name = "txtGuaranteeTotal"
        Me.txtGuaranteeTotal.ReadOnly = True
        Me.txtGuaranteeTotal.Size = New System.Drawing.Size(128, 21)
        Me.txtGuaranteeTotal.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(456, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 21)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "担保额(元)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEvaluateTotal
        '
        Me.txtEvaluateTotal.Location = New System.Drawing.Point(288, 19)
        Me.txtEvaluateTotal.Name = "txtEvaluateTotal"
        Me.txtEvaluateTotal.ReadOnly = True
        Me.txtEvaluateTotal.Size = New System.Drawing.Size(128, 21)
        Me.txtEvaluateTotal.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(216, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(72, 21)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "评估总值(元)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOriginalTotal
        '
        Me.txtOriginalTotal.Location = New System.Drawing.Point(72, 19)
        Me.txtOriginalTotal.Name = "txtOriginalTotal"
        Me.txtOriginalTotal.ReadOnly = True
        Me.txtOriginalTotal.Size = New System.Drawing.Size(128, 21)
        Me.txtOriginalTotal.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(16, 19)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 21)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "原值(元)"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnReport
        '
        Me.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.ImageIndex = 19
        Me.btnReport.ImageList = Me.ImageListBasic
        Me.btnReport.Location = New System.Drawing.Point(46, 504)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(120, 24)
        Me.btnReport.TabIndex = 13
        Me.btnReport.Text = "评估报告管理(&R)"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.Enabled = False
        Me.btnImport.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImport.ImageIndex = 16
        Me.btnImport.ImageList = Me.ImageListBasic
        Me.btnImport.Location = New System.Drawing.Point(608, 296)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(104, 24)
        Me.btnImport.TabIndex = 14
        Me.btnImport.Text = "导入反担保物"
        Me.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 301)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "企业联系人"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(208, 301)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "联系电话"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'corp_contact_person
        '
        Me.corp_contact_person.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.corp_contact_person.Location = New System.Drawing.Point(80, 298)
        Me.corp_contact_person.Name = "corp_contact_person"
        Me.corp_contact_person.ReadOnly = True
        Me.corp_contact_person.Size = New System.Drawing.Size(112, 21)
        Me.corp_contact_person.TabIndex = 17
        '
        'corp_contact_phone
        '
        Me.corp_contact_phone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.corp_contact_phone.Location = New System.Drawing.Point(272, 298)
        Me.corp_contact_phone.Name = "corp_contact_phone"
        Me.corp_contact_phone.ReadOnly = True
        Me.corp_contact_phone.Size = New System.Drawing.Size(128, 21)
        Me.corp_contact_phone.TabIndex = 18
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "评估净值(元)"
        Me.DataGridTextBoxColumn15.MappingName = "evaluate_net_value"
        Me.DataGridTextBoxColumn15.NullText = "0.00"
        Me.DataGridTextBoxColumn15.Width = 75
        '
        'frmOppGuaranteeEvaluate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(722, 535)
        Me.Controls.Add(Me.corp_contact_phone)
        Me.Controls.Add(Me.corp_contact_person)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCommit)
        Me.Name = "frmOppGuaranteeEvaluate"
        Me.Text = "反担保物评估"
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnModify, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.btnNew, 0)
        Me.Controls.SetChildIndex(Me.btnView, 0)
        Me.Controls.SetChildIndex(Me.btnUpload, 0)
        Me.Controls.SetChildIndex(Me.GroupBox5, 0)
        Me.Controls.SetChildIndex(Me.btnReport, 0)
        Me.Controls.SetChildIndex(Me.btnImport, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.corp_contact_person, 0)
        Me.Controls.SetChildIndex(Me.corp_contact_phone, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.txtName, 0)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'Load()
    Private Sub frmOppGuaranteeEvaluate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.strProjectCode = Me.getProjectCode()
        Me.strCorporationName = Me.getCorporationName()
        Me.strWorkFlowID = Me.getWorkFlowID()
        Me.strTaskID = Me.getTaskID()
        Me.strPerson = Me.getUser
        Try
            Me.dateEvaluate.Value = gWs.GetSysTime()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        Me.txtCode.Text = Me.strProjectCode
        Me.txtName.Text = Me.strCorporationName

        'strPhase = Me.getPhase(Me.strProjectCode)
        getProjectCorporation(Me.strProjectCode, strPhase)

        'dsOppGuaranteeView = Me.getOppGuaranteeRecord(strProjectCode, "1")
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

        Me.txtContract.Enabled = False
        setTextBox(False)
        setTextBoxModify(False)
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
        setTotal() '统计金额
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.dgDetail.TableStyles(0).GridColumnStyles(1).ReadOnly = True
    End Sub
    '
    '计算总额
    '
    Private Sub setTotal()
        Me.txtOriginalTotal.Text = Me.getOriginalTotal()
        Me.txtEvaluateTotal.Text = Me.getEvaluateTotal()
        Me.txtGuaranteeTotal.Text = Me.getGuaranteeTotal()
    End Sub
    '
    '设置Text的Enabled属性
    '
    Private Sub setTextBox(ByVal isEnabled As Boolean)
        Me.cmbType.Enabled = isEnabled
        Me.txtRemark.Enabled = isEnabled
        Me.cmbMeasure.Enabled = isEnabled

        Me.txtOriginal.Enabled = isEnabled
        Me.txtEvaluate.Enabled = isEnabled
        Me.txtEvaluate.Enabled = isEnabled
        Me.txtGuarantee.Enabled = isEnabled
        Me.dateEvaluate.Enabled = isEnabled
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
        docClass.ViewGuanty = True
        docClass.openFileList(strProjectCode, "2%", "", strDir)
        Me.Cursor = Cursors.Default
    End Sub
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
    '判断评估师,再进行设置"删除","修改","上载"按钮操作
    Private Sub setButton()
        Dim dt As DataTable
        Dim dr As DataRow
        Try
            dt = CType(Me.dgOppGuarantee.DataSource, DataTable)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    dr = dt.Rows(Me.dgOppGuarantee.CurrentRowIndex)
                    Me.btnUpload.Enabled = True
                    If Not dr.Item("evaluate_person") Is System.DBNull.Value Then
                        If dr.Item("evaluate_person") = strPerson Or Workflow.GetRealTaskAttendee("34", dr.Item("evaluate_person")) = strPerson Then
                            Me.btnModify.Enabled = True
                            Me.btnDelete.Enabled = True
                            Me.btnUpload.Enabled = True
                            setButtonApply()
                        Else
                            Me.btnModify.Enabled = False
                            Me.btnDelete.Enabled = False
                            Me.btnUpload.Enabled = False
                        End If
                    Else
                        Me.btnModify.Enabled = True
                        Me.btnDelete.Enabled = True
                        Me.btnUpload.Enabled = True
                        setButtonApply()
                    End If
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
                    Me.btnModify.Enabled = False
                    Me.btnDelete.Enabled = False
                    Me.btnUpload.Enabled = False
                    Me.btnView.Enabled = False
                End If
            Else
                Me.btnModify.Enabled = False
                Me.btnDelete.Enabled = False
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
                    Me.btnUpload.Enabled = True
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
                    Me.txtEvaluateNet.Text = "'"
                End If
                If Not .Item("guarantee_value") Is System.DBNull.Value Then
                    Me.txtGuarantee.Text = .Item("guarantee_value")
                Else
                    Me.txtGuarantee.Text = ""
                End If
                If Not .Item("affirm_evaluate_date") Is System.DBNull.Value Then
                    Me.dateEvaluate.Value = .Item("affirm_evaluate_date")
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
    '新增
    '
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If Not dsOppGuaranteeView Is Nothing Then
            If btnNew.Text = "新 增(&N)" Then
                isNewOrModify = False
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
                Me.btnUpload.Enabled = True
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

            Dim dateBinding As Binding = New Binding("Value", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "affirm_evaluate_date")
            AddHandler dateBinding.Parse, New ConvertEventHandler(AddressOf DateTime_Parse)
            AddHandler dateBinding.Format, New ConvertEventHandler(AddressOf DateTime_Format)
            Me.dateEvaluate.DataBindings.Add(dateBinding)

            'Me.dateEvaluate.DataBindings.Add("Value", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "affirm_evaluate_date")

            Me.txtContract.DataBindings.Add("Text", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "contract_no")
            Me.txtRemark.DataBindings.Add("Text", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "remark")
        End If
    End Sub

    Private Sub DateTime_Parse(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If IsDBNull(e.Value) Then
            e.Value = DateTime.Today
        End If
    End Sub

    Private Sub DateTime_Format(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If Not e.DesiredType Is GetType(DateTime) Then
            Return
        End If

        If IsDBNull(e.Value) Then
            e.Value = DateTime.Today
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
        Me.txtRemark.Text = ""
        Try
            Me.dateEvaluate.Value = gWs.GetSysTime()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        strItemType = getGuaranteeCode(Me.cmbType.Text)
        Try
            'qxd modify 2003-11-4
            strSerialNum = gWs.GetMaxGuarantyNum(strProjectCode) '+ add_num
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            Exit Function
        End Try
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
                .Item("evaluate_person") = strPerson
                Try
                    .Item("affirm_evaluate_date") = gWs.GetSysTime()
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
                .Item("contract_no") = Me.txtContract.Text
                .Item("remark") = Me.txtRemark.Text
                .Item("status") = strStatus
                .Item("create_person") = strPerson
                Try
                    .Item("create_date") = gWs.GetSysTime()
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
            End With
            dsOppGuaranteeView.Tables("opposite_guarantee").Rows.Add(dr)
            addDetail(strSerialNum)
            serialNum = strSerialNum
            If Not dsOppGuaranteeView Is Nothing Then
                Me.bmOpp = Me.BindingContext(dsOppGuaranteeView, "opposite_guarantee")
            End If
            Me.dgOppGuarantee.CurrentRowIndex = bmOpp.Count - 1
            Return strSerialNum
        End If
    End Function
    '
    '新增时,添加详细信息
    '
    Private Sub addDetail(ByVal strSerialNum As String)
        Dim i, count As Integer
        Dim dsTemp As DataSet
        Dim dsCopy As DataSet '从opposite_guarantee_detail中查找是否有相同的类型的反担保物详细信息
        Dim drTemp As DataRow
        Dim strSql As String
        Dim strItemType, strItemCode As String '反担保物类型的code
        strItemType = getGuaranteeCode(Me.cmbType.Text)
        strSql = "{project_code='" & strProjectCode & "' and item_type='" & strItemType & "' order by serial_num desc}"
        dsCopy = gWs.GetGuarantyInfo("nul", strSql)
        count = dsCopy.Tables("opposite_guarantee_detail").Rows.Count
        dsTemp = getItemDataSet(strItemType)
        i = dsTemp.Tables("TItem").Rows.Count
        For i = 0 To i - 1
            If dsDetailDeal Is Nothing Then
                Try
                    dsDetailDeal = gWs.GetGuarantyInfo("null", "null")
                Catch ex As Exception
                End Try
            End If
            drTemp = dsDetailDeal.Tables("opposite_guarantee_detail").NewRow
            strItemCode = dsTemp.Tables("TItem").Rows(i).Item("item_code")
            With drTemp
                .Item("project_code") = strProjectCode
                .Item("serial_num") = strSerialNum
                .Item("item_type") = getGuaranteeCode(Me.cmbType.Text)
                .Item("item_name") = dsTemp.Tables("TItem").Rows(i).Item("item_name")
                Dim temp As String
                If count > 0 Then
                    temp = dsCopy.Tables("opposite_guarantee_detail").Select("item_code='" & strItemCode & "'")(0).Item("item_value") & ""
                End If
                .Item("item_value") = IIf(count > 0, temp, "")
                .Item("item_code") = strItemCode
                .Item("create_person") = strPerson
                .Item("create_date") = Me.dateEvaluate.Value
            End With
            dsDetailDeal.Tables("opposite_guarantee_detail").Rows.Add(drTemp)
            dsDetailView = dsDetailDeal
        Next
        Me.dgDetail.DataSource = dsDetailDeal.Tables("opposite_guarantee_detail") 'qxd
        setDgAttribute(dgDetail)
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
            i = dsOppGuaranteeView.Tables("opposite_guarantee").Rows.Count
            If i > 0 Then
                dr = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(i - 1)
                With dr
                    .Item("type_name") = Me.cmbType.Text
                    .Item("guaranty_type") = getGuaranteeCode(Me.cmbType.Text)
                End With
                Me.dgOppGuarantee.CurrentRowIndex = Me.bmOpp.Count - 1
                dsDetailDeal.Clear()
                addDetail(serialNum)
                setEvaTextEnabled(Me.dsOppGuaranteeView)
            End If
        End If
    End Sub
    '
    '保存
    '
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        saveProjectCorporation(Me.strProjectCode, strPhase)

        If Not dsOppGuaranteeView Is Nothing Then
            If Not isNewOrModify Then '新增
                isSaved = False
                btnNew.Text = "新 增(&N)"
                Me.dgOppGuarantee.Enabled = True
                setTextBox(False)
                delBinding()
                Me.btnNew.Enabled = True
                Me.btnDelete.Enabled = True
                Me.btnModify.Enabled = True
                Me.btnView.Enabled = True
                Me.btnUpload.Enabled = True
                Me.btnCommit.Enabled = True

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
                        'MsgBox("保存成功!", MsgBoxStyle.Information, "提示")
                        If Not isExitSave Then
                            SWDialogBox.MessageBox.Show("$SaveSucceed")
                        End If
                        currentIndex = Me.dgOppGuarantee.CurrentRowIndex
                        Me.dsOppGuaranteeView.AcceptChanges()
                        lastRow = 0
                    End If
                Else
                    If Not dsDetailDeal Is Nothing Then
                        Me.dsDetailDeal.Clear()
                    End If
                    'MsgBox("保存失败!" & strResult, MsgBoxStyle.Critical, "提示")
                    SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                    Me.dsOppGuaranteeView.RejectChanges()
                End If
                'qxd close 2003-6-7
                'Try
                '    dsOppGuaranteeView = Me.getOppGuaranteeRecord(strProjectCode)
                '    Me.dgOppGuarantee.DataSource = dsOppGuaranteeView.Tables("opposite_guarantee")
                '    Me.dsOppGuaranteeView.AcceptChanges()
                '    Me.setDgAttribute(Me.dgOppGuarantee)
                'Catch ex As Exception
                '    MsgBox(ex.Message)
                'Finally
                'End Try
                If Not dsOppGuaranteeView Is Nothing Then
                    Me.bmOpp = Me.BindingContext(dsOppGuaranteeView, "opposite_guarantee")
                End If
            Else '修改
                setTextBoxModify(False)
                btnModify.Text = "修 改(&M)"
                Me.dgOppGuarantee.Enabled = True
                Me.btnNew.Enabled = False
                Me.btnDelete.Enabled = True
                Me.btnModify.Enabled = True
                Me.btnCommit.Enabled = True
                Me.btnSave.Enabled = False
                delBindingModify()

                Dim strResult As String
                Me.dgOppGuarantee.CurrentRowIndex = currentIndex
                strResult = gWs.UpdateGuaranty(dsOppGuaranteeView)
                '保证修改详细信息可以保存
                gWs.UpdateGuaranty(dsDetailView)
                If strResult = "1" Then
                    'MsgBox("保存成功!", MsgBoxStyle.Information, "提示")
                    SWDialogBox.MessageBox.Show("$SaveSucceed")
                    currentIndex = Me.dgOppGuarantee.CurrentRowIndex
                    Me.dsOppGuaranteeView.AcceptChanges()
                    'qxd close 2003-6-7
                    'Try
                    '    dsOppGuaranteeView = Me.getOppGuaranteeRecord(strProjectCode)
                    '    Me.dgOppGuarantee.DataSource = dsOppGuaranteeView.Tables("opposite_guarantee")
                    '    Me.dsOppGuaranteeView.AcceptChanges()
                    '    Me.setDgAttribute(Me.dgOppGuarantee)
                    'Catch ex As Exception
                    '    MsgBox(ex.Message)
                    'Finally
                    'End Try
                Else
                    'MsgBox("保存失败!", MsgBoxStyle.Critical, "提示")
                    SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                    Me.dsOppGuaranteeView.RejectChanges()
                End If
            End If
        End If
        'Me.getOppGuaranteeRecord(strProjectCode, "1")
        Me.getOppGuaranteeRecord(strProjectCode, "0")
        setTotal()
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
            Dim strDelResult, relationNum As String
            'If 1 = MsgBox("确定删除选中的记录吗?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "提示") Then
            If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1004", "") Then
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
                    'dsOppGuaranteeView = Me.getOppGuaranteeRecord(strProjectCode, "1")
                    dsOppGuaranteeView = Me.getOppGuaranteeRecord(strProjectCode, "0")
                    Me.dgOppGuarantee.DataSource = dsOppGuaranteeView.Tables("opposite_guarantee")
                    Me.dsOppGuaranteeView.AcceptChanges()
                    Me.setDgAttribute(Me.dgOppGuarantee)
                    If Not dsOppGuaranteeView Is Nothing Then
                        Me.bmOpp = Me.BindingContext(dsOppGuaranteeView, "opposite_guarantee")
                    End If
                    lastRow = 0
                    setButton()
                    setTotal()
                End If
            End If
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
        If changedCount > 0 Or changedCount_detail > 0 Or hasProCorpChanged Then
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
    '修改
    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        If Not dsOppGuaranteeView Is Nothing Then
            If btnModify.Text = "修 改(&M)" Then
                isNewOrModify = True
                isModify = True
                currentIndex = Me.dgOppGuarantee.CurrentRowIndex
                Me.dgOppGuarantee.Select(currentIndex) 'qxd add 2003-5-13
                Try
                    Me.dsOppGuaranteeView.Tables("opposite_guarantee").Rows(currentIndex).Item("evaluate_person") = strPerson
                Catch ex As Exception
                    'MsgBox(ex.Message)
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
                setTextBoxModify(True)
                Me.cmbMeasure.Focus()
                delBindingModify()
                addBindingModify()
                btnModify.Text = "取 消(&C)"
                Me.dgOppGuarantee.Enabled = False
                Me.btnSave.Enabled = True
                Me.btnNew.Enabled = False
                Me.btnDelete.Enabled = False
                Me.btnView.Enabled = False
                Me.btnUpload.Enabled = False
                Me.btnCommit.Enabled = False
                setEvaTextEnabled(Me.dsOppGuaranteeView)
                Me.DataGridTextBoxColumn2.ReadOnly = False
                Me.dgDetail.TableStyles(0).GridColumnStyles(1).ReadOnly = False
            ElseIf btnModify.Text = "取 消(&C)" Then
                isNewOrModify = False
                isModify = False
                setTextBoxModify(False)
                btnModify.Text = "修 改(&M)"
                Me.dgOppGuarantee.Enabled = True
                Me.btnSave.Enabled = False
                Me.btnNew.Enabled = False
                Me.btnDelete.Enabled = True
                Me.btnView.Enabled = True
                Me.btnUpload.Enabled = True
                Me.btnCommit.Enabled = True
                Me.dsOppGuaranteeView.RejectChanges()
                delBindingModify()
                setButton()
                Me.DataGridTextBoxColumn2.ReadOnly = True
                Me.dgDetail.TableStyles(0).GridColumnStyles(1).ReadOnly = True
                Try
                    getDetail()
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
            End If
        End If
    End Sub
    '设置TextBox的enabled属性
    Private Sub setTextBoxModify(ByVal isEnabled As Boolean)
        Me.txtOriginal.Enabled = isEnabled
        Me.txtGuarantee.Enabled = isEnabled
        Me.txtEvaluate.Enabled = isEnabled
        Me.txtEvaluateNet.Enabled = isEnabled
        Me.dateEvaluate.Enabled = isEnabled

        Me.cmbMeasure.Enabled = isEnabled
        Me.txtRemark.Enabled = isEnabled
    End Sub
    '添加绑定
    Private Sub addBindingModify()
        Me.txtOriginal.DataBindings.Add("Text", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "original_value")
        Me.txtEvaluate.DataBindings.Add("Text", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "evaluate_value")
        Me.txtEvaluateNet.DataBindings.Add("Text", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "evaluate_net_value")
        Me.txtGuarantee.DataBindings.Add("Text", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "guarantee_value")

        Dim dateBinding As Binding = New Binding("Value", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "affirm_evaluate_date")
        AddHandler dateBinding.Parse, New ConvertEventHandler(AddressOf DateTime_Parse)
        AddHandler dateBinding.Format, New ConvertEventHandler(AddressOf DateTime_Format)
        Me.dateEvaluate.DataBindings.Add(dateBinding)
        'Me.dateEvaluate.DataBindings.Add("Text", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "affirm_evaluate_date")

        Me.txtRemark.DataBindings.Add("Text", Me.dsOppGuaranteeView.Tables("opposite_guarantee"), "remark")
    End Sub
    '删除绑定
    Private Sub delBindingModify()
        Me.txtOriginal.DataBindings.Clear()
        Me.txtEvaluate.DataBindings.Clear()
        Me.txtEvaluateNet.DataBindings.Clear()
        Me.txtGuarantee.DataBindings.Clear()
        Me.dateEvaluate.DataBindings.Clear()

        Me.txtRemark.DataBindings.Clear()
    End Sub
    'KeyPress()
    Private Sub frmOppGuaranteeEvaluate2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
    End Sub
    'Closing()
    Private Sub frmOppGuaranteeEvaluate2_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If sender.GetType Is GetType(Form) Then
            If frmExit(sender, e) Then
                e.Cancel = True
            End If
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
            If Not isSaved Then 'qxd add 2003-5-15
                setButton()
                getDetail()
                getOppGuaranteeInfo()
            End If
            Me.dgOppGuarantee.Select(Me.dgOppGuarantee.CurrentCell.RowNumber)
        End If
        lastRow = Me.dgOppGuarantee.CurrentRowIndex
    End Sub
    '上载
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
            'dsOppGuaranteeView = Me.getOppGuaranteeRecord(strProjectCode, "1")
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
    '制作报告
    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        Dim doc As New frmDocumentManageBusiness(strProjectCode, strTaskID, strCorporationName, "45", "007", strPerson)
        doc.AllowTransparency = False
        doc.ShowDialog()
    End Sub
    Private Sub dgDetail_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDetail.CurrentCellChanged
        'If Not Me.DataGridTextBoxColumn2.ReadOnly Then
        Try
            If Not Me.dgDetail.TableStyles(0).GridColumnStyles(1).ReadOnly Then
                Dim currentIndex As Integer
                currentIndex = Me.dgOppGuarantee.CurrentRowIndex
                If Me.dgOppGuarantee.Item(Me.dgOppGuarantee.CurrentRowIndex, 8) = "21" Then
                    setEstate(CType(Me.dgDetail.DataSource, DataTable), CType(Me.dgOppGuarantee.DataSource, DataTable), currentIndex)
                ElseIf Me.dgOppGuarantee.Item(Me.dgOppGuarantee.CurrentRowIndex, 8) = "22" Then
                    setAutocar(CType(Me.dgDetail.DataSource, DataTable), CType(Me.dgOppGuarantee.DataSource, DataTable), currentIndex)
                ElseIf Me.dgOppGuarantee.Item(Me.dgOppGuarantee.CurrentRowIndex, 8) = "23" Then
                    setMachineryEquipment(CType(Me.dgDetail.DataSource, DataTable), CType(Me.dgOppGuarantee.DataSource, DataTable), currentIndex)
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim oppImport As FOppImportData = New FOppImportData(strProjectCode, Me, Nothing)
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
        setTotal() '统计金额
        Return dsOppGuaranteeView
    End Function

    '获得项目企业表信息,并设置“企业联系人”和“联系电话”的初始值
    Private Sub getProjectCorporation(ByVal projectCode As String, ByVal phase As String)
        Try
            Dim strSql As String

            strSql = "{project_code='" & projectCode & "' and phase='" & phase & "' and corporation_code='" & projectCode.Substring(0, 5) & "'}"
            'dsProjectCorporation = gWs.FetchProjectCorporation(strSql)
            dsProjectCorporation = gWs.FetchProjectCorporation(Me.getProjectCode(), "%", "1", Me.getPhase(getProjectCode()))
            If Not dsProjectCorporation Is Nothing Then
                If dsProjectCorporation.Tables(0).Rows.Count > 0 Then
                    If Not dsProjectCorporation.Tables(0).Rows(0).Item("corp_contact_person") Is System.DBNull.Value Then
                        Me.corp_contact_person.Text = dsProjectCorporation.Tables(0).Rows(0).Item("corp_contact_person")
                    End If
                    If Not dsProjectCorporation.Tables(0).Rows(0).Item("corp_contact_phone") Is System.DBNull.Value Then
                        Me.corp_contact_phone.Text = dsProjectCorporation.Tables(0).Rows(0).Item("corp_contact_phone")
                    End If
                    hasProCorpChanged = False
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '保存“企业联系人”和“联系电话”到项目企业表
    Private Function saveProjectCorporation(ByVal projectCode As String, ByVal phase As String) As String
        Dim dr As DataRow
        Try
            If Not dsProjectCorporation Is Nothing Then
                If dsProjectCorporation.Tables(0).Rows.Count > 0 Then
                    dr = dsProjectCorporation.Tables(0).Rows(0)
                    With dr
                        .Item("corp_contact_person") = Me.corp_contact_person.Text
                        .Item("corp_contact_phone") = Me.corp_contact_phone.Text
                    End With
                Else
                    dr = dsProjectCorporation.Tables(0).NewRow
                    With dr
                        .Item("project_code") = projectCode
                        .Item("corporation_code") = projectCode.Substring(0, 5)
                        .Item("phase") = phase
                        .Item("corporation_type") = "1"
                        .Item("create_person") = UserName
                        .Item("create_date") = gWs.GetSysTime()
                        .Item("corp_contact_person") = Me.corp_contact_person.Text
                        .Item("corp_contact_phone") = Me.corp_contact_phone.Text
                    End With
                    dsProjectCorporation.Tables(0).Rows.Add(dr)
                End If

                hasProCorpChanged = False
                Return gWs.UpdateProjectCorporation(dsProjectCorporation)
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Function

    Private Sub corp_contact_person_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles corp_contact_person.TextChanged
        hasProCorpChanged = True
    End Sub

    Private Sub corp_contact_phone_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles corp_contact_phone.TextChanged
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

    ''qxd add 2004-11-19 原值修改时，重新计算。
    'Private Sub txtOriginal_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOriginal.KeyUp
    '    dgDetail_CurrentCellChanged(sender, Nothing)
    'End Sub

End Class
