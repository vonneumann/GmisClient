

Public Class FOppImportData
    Inherits MainInterface.frmBasic

    Private dsOppGuaranteeView, dsDetailView As DataSet
    Private strProjectCode, strCorporationName, ProjectCode As String
    Private strDir As String = "\Document\Image\" '图片保存的目录

    Private totalOriginal, totalEvaluate, totalEvaluatenet, totalGuarantee As String
    Private dOriginal, dEvaluate, dEvaluatenet, dGuarantee As Double

    Dim SourceProjectCode, SourceSerialNum, CreatePerson As String
    Dim CreateDate As Date
    Dim frmOppEva As frmOppGuaranteeEvaluate
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Dim frmOppReg As frmOppGuaranteeRegister

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    Public Sub New(ByVal ProjectCode As String, ByVal frmEva As Form, ByVal frmReg As Form)
        Me.New()
        Me.ProjectCode = ProjectCode
        Me.frmOppEva = frmEva
        Me.frmOppReg = frmReg
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents dateEvaluate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgOppGuarantee As System.Windows.Forms.DataGrid
    Friend WithEvents dgDetail As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents chbDate As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbOppType As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbOppForm As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbOppStatus As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtCode As System.Windows.Forms.ComboBox
    Friend WithEvents btnImport As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FOppImportData))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCode = New System.Windows.Forms.ComboBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.cmbOppStatus = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbOppForm = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbOppType = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.chbDate = New System.Windows.Forms.CheckBox
        Me.btnQuery = New System.Windows.Forms.Button
        Me.dateEvaluate = New System.Windows.Forms.DateTimePicker
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgOppGuarantee = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgDetail = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnView = New System.Windows.Forms.Button
        Me.btnImport = New System.Windows.Forms.Button
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(487, 442)
        Me.btnExit.TabIndex = 5
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.cmbOppStatus)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbOppForm)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbOppType)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.chbDate)
        Me.GroupBox1.Controls.Add(Me.btnQuery)
        Me.GroupBox1.Controls.Add(Me.dateEvaluate)
        Me.GroupBox1.Controls.Add(Me.txtAddress)
        Me.GroupBox1.Controls.Add(Me.txtName)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(808, 128)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询条件"
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(120, 32)
        Me.txtCode.MaxDropDownItems = 100
        Me.txtCode.MaxLength = 9
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(121, 20)
        Me.txtCode.TabIndex = 12
        '
        'btnClear
        '
        Me.btnClear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.ImageIndex = 12
        Me.btnClear.ImageList = Me.ImageListBasic
        Me.btnClear.Location = New System.Drawing.Point(720, 64)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 23)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "清 空(&C)"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOppStatus
        '
        Me.cmbOppStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbOppStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOppStatus.Location = New System.Drawing.Point(584, 65)
        Me.cmbOppStatus.Name = "cmbOppStatus"
        Me.cmbOppStatus.Size = New System.Drawing.Size(121, 20)
        Me.cmbOppStatus.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(496, 68)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 12)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "反担保物状态"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbOppForm
        '
        Me.cmbOppForm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOppForm.Location = New System.Drawing.Point(352, 65)
        Me.cmbOppForm.Name = "cmbOppForm"
        Me.cmbOppForm.Size = New System.Drawing.Size(121, 20)
        Me.cmbOppForm.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(256, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 23)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "反担保物方式"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbOppType
        '
        Me.cmbOppType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOppType.Location = New System.Drawing.Point(120, 65)
        Me.cmbOppType.Name = "cmbOppType"
        Me.cmbOppType.Size = New System.Drawing.Size(121, 20)
        Me.cmbOppType.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "反担保物类型"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chbDate
        '
        Me.chbDate.Location = New System.Drawing.Point(16, 95)
        Me.chbDate.Name = "chbDate"
        Me.chbDate.Size = New System.Drawing.Size(16, 24)
        Me.chbDate.TabIndex = 5
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuery.ImageIndex = 3
        Me.btnQuery.ImageList = Me.ImageListBasic
        Me.btnQuery.Location = New System.Drawing.Point(720, 96)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(77, 23)
        Me.btnQuery.TabIndex = 4
        Me.btnQuery.Text = "查 询(&Q)"
        Me.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dateEvaluate
        '
        Me.dateEvaluate.Location = New System.Drawing.Point(120, 97)
        Me.dateEvaluate.Name = "dateEvaluate"
        Me.dateEvaluate.Size = New System.Drawing.Size(120, 21)
        Me.dateEvaluate.TabIndex = 5
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.Location = New System.Drawing.Point(352, 97)
        Me.txtAddress.MaxLength = 100
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(352, 21)
        Me.txtAddress.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(352, 33)
        Me.txtName.MaxLength = 100
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(352, 21)
        Me.txtName.TabIndex = 1
        Me.txtName.Visible = False
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(256, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "房地产地址"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "评估时间"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(256, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "客户名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Visible = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgOppGuarantee)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 144)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(536, 280)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "反担保物记录"
        '
        'dgOppGuarantee
        '
        Me.dgOppGuarantee.CaptionVisible = False
        Me.dgOppGuarantee.DataMember = ""
        Me.dgOppGuarantee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOppGuarantee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgOppGuarantee.Location = New System.Drawing.Point(3, 17)
        Me.dgOppGuarantee.Name = "dgOppGuarantee"
        Me.dgOppGuarantee.ReadOnly = True
        Me.dgOppGuarantee.Size = New System.Drawing.Size(530, 260)
        Me.dgOppGuarantee.TabIndex = 0
        Me.dgOppGuarantee.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dgOppGuarantee
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "opposite_guarantee"
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn3.MappingName = "project_code"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.MappingName = "serial_num"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.MappingName = "guaranty_type"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.MappingName = "file_relation_num"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "客户名称"
        Me.DataGridTextBoxColumn15.MappingName = "corporation_name"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 150
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "反担保物类型"
        Me.DataGridTextBoxColumn6.MappingName = "type_name"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "担保方式"
        Me.DataGridTextBoxColumn7.MappingName = "opposite_guarantee_form"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "反担保物状态"
        Me.DataGridTextBoxColumn14.MappingName = "status"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "评估日期"
        Me.DataGridTextBoxColumn4.MappingName = "evaluate_date"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "原值(元)"
        Me.DataGridTextBoxColumn11.MappingName = "original_value"
        Me.DataGridTextBoxColumn11.NullText = "0"
        Me.DataGridTextBoxColumn11.Width = 75
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "评估总值(元)"
        Me.DataGridTextBoxColumn12.MappingName = "evaluate_value"
        Me.DataGridTextBoxColumn12.NullText = "0"
        Me.DataGridTextBoxColumn12.Width = 75
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "担保额(元)"
        Me.DataGridTextBoxColumn13.MappingName = "guarantee_value"
        Me.DataGridTextBoxColumn13.NullText = "0"
        Me.DataGridTextBoxColumn13.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "说明"
        Me.DataGridTextBoxColumn5.MappingName = "remark"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 150
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.dgDetail)
        Me.GroupBox3.Location = New System.Drawing.Point(552, 144)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(264, 280)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "详细信息"
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
        Me.dgDetail.Size = New System.Drawing.Size(258, 260)
        Me.dgDetail.TabIndex = 0
        Me.dgDetail.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgDetail
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "opposite_guarantee_detail"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "类目"
        Me.DataGridTextBoxColumn1.MappingName = "item_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "描述"
        Me.DataGridTextBoxColumn2.MappingName = "item_value"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 120
        '
        'btnView
        '
        Me.btnView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.ImageIndex = 17
        Me.btnView.ImageList = Me.ImageListBasic
        Me.btnView.Location = New System.Drawing.Point(375, 442)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(93, 23)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "浏览图片(&V)"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImport.ImageIndex = 16
        Me.btnImport.ImageList = Me.ImageListBasic
        Me.btnImport.Location = New System.Drawing.Point(263, 442)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(93, 23)
        Me.btnImport.TabIndex = 6
        Me.btnImport.Text = "导入数据(&I)"
        Me.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "评估净值(元)"
        Me.DataGridTextBoxColumn16.MappingName = "evaluate_net_value"
        Me.DataGridTextBoxColumn16.NullText = "0"
        Me.DataGridTextBoxColumn16.Width = 75
        '
        'FOppImportData
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(826, 487)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FOppImportData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "导入历史的反担保物记录"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.btnView, 0)
        Me.Controls.SetChildIndex(Me.btnImport, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub FOppImportData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            CreateDate = gWs.GetSysTime()
            CreatePerson = UserName
            Me.dateEvaluate.Value = CreateDate
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Me.dateEvaluate.Enabled = False
        Me.btnImport.Enabled = False
        getProjectCodeList(ProjectCode)
        setViewEnabled()
        bindingType()
        bindingForm()
        bindingStatus()
    End Sub
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    '
    '获得ItemType表的DataSet
    '
    Public Function getItemTypeDataSet(ByVal strItemType As String) As DataSet
        Dim ds As DataSet
        Try
            ds = gWs.GetItemType("{item_type='" & strItemType & "'}")
            Return ds
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        Finally
        End Try
    End Function
    '根据条件查询反担保物记录
    Private Function queryOppGuarantee(ByVal strCondition As String)
        dOriginal = 0.0
        dEvaluate = 0.0
        dEvaluatenet = 0.0
        dGuarantee = 0.0
        totalOriginal = 0.0
        totalEvaluate = 0.0
        totalGuarantee = 0.0
        Dim i As Integer
        Dim strSql As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim oDateEvaluate As Object

        If gWs Is Nothing Then
            Exit Function
        End If
        If Me.chbDate.Checked Then
            oDateEvaluate = Me.dateEvaluate.Value.Date
        Else
            oDateEvaluate = Nothing
        End If
        Try
            ' ds = gWs.GetGuarantyInfo(strCondition, "null")
            ds = gWs.GetGuarantyInfoEx(Me.txtCode.Text, Me.txtName.Text, Me.txtAddress.Text, Me.cmbOppForm.SelectedValue, oDateEvaluate, Me.cmbOppStatus.SelectedValue, Me.cmbOppType.SelectedValue)
            ds.Tables("opposite_guarantee").Columns.Add("type_name", GetType(String))
            ds.Tables("opposite_guarantee").Columns.Add("corporation_name", GetType(String))
            i = ds.Tables("opposite_guarantee").Rows.Count
            For i = 0 To i - 1
                dr = ds.Tables("opposite_guarantee").Rows(i)
                With dr
                    '金额统计，qxd add 2003-5-10
                    If Not .Item("original_value") Is System.DBNull.Value Then
                        totalOriginal = .Item("original_value")
                        dOriginal = totalOriginal + dOriginal
                    End If
                    If Not .Item("evaluate_value") Is System.DBNull.Value Then
                        totalEvaluate = .Item("evaluate_value")
                        dEvaluate = totalEvaluate + dEvaluate
                    End If
                    'add yansm 2013/12/7
                    If Not .Item("evaluate_net_value") Is System.DBNull.Value Then
                        totalEvaluate = .Item("evaluate_net_value")
                        dEvaluatenet = totalEvaluatenet + dEvaluatenet
                    End If
                    If Not .Item("guarantee_value") Is System.DBNull.Value Then
                        totalGuarantee = .Item("guarantee_value")
                        dGuarantee = totalGuarantee + dGuarantee
                    End If
                    Try
                        If Not .Item("guaranty_type") Is System.DBNull.Value Then
                            Dim strItemType As String
                            Dim dsItemType As DataSet
                            strItemType = .Item("guaranty_type")
                            dsItemType = getItemTypeDataSet(strItemType)
                            'oppGuarantee显示的类型名映射为ItemType中的typeName
                            .Item("type_name") = dsItemType.Tables("TItemType").Select("item_type='" & strItemType & "'")(0).Item("type_name")
                        End If
                    Catch ex As Exception
                        'MsgBox("获取反担保物类型出错!" & ex.Message, MsgBoxStyle.Critical, "提示")
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try

                    '写入企业名称
                    Dim projectCode As String = .Item("project_code")
                    Dim dsProjectCorporation As DataSet
                    Dim drProjectCorporation As DataRow
                    Try
                        strSql = "{project_code='" & projectCode & "'}"
                        'dsProjectCorporation = gWs.FetchProjectCorporation(strSql)
                        dsProjectCorporation = gWs.FetchProjectCorporation(Me.getProjectCode(), "%", "1", Me.getPhase(getProjectCode()))
                        If Not dsProjectCorporation Is Nothing Then
                            If dsProjectCorporation.Tables("TProjectCorporation").Rows.Count > 0 Then
                                drProjectCorporation = dsProjectCorporation.Tables("TProjectCorporation").Rows(0)
                                If Not drProjectCorporation.Item("corporation_name") Is System.DBNull.Value Then
                                    .Item("corporation_name") = drProjectCorporation.Item("corporation_name")
                                End If
                            End If
                        End If
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
            Next
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            'Me.txtOriginalTotal.Text = dOriginal
            'Me.txtEvaluateTotal.Text = dEvaluate
            'Me.txtGuaranteeTotal.Text = dGuarantee
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
        Return ds
    End Function

    '查询
    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim strCondition As String
            If Not Me.dsDetailView Is Nothing Then
                Me.dsDetailView.Clear()
            End If
            'strCondition = Me.getQueryCondition()
            dsOppGuaranteeView = Me.queryOppGuarantee(strCondition)
            If Not Me.dsOppGuaranteeView Is Nothing Then
                Me.dgOppGuarantee.DataSource = dsOppGuaranteeView.Tables(0)
            End If

            getDetail()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '
    '获得反担保物的详细信息
    '
    Private Sub getDetail()
        Dim index As Integer
        Dim strCode, strSerial, strType, strState As String
        index = Me.dgOppGuarantee.CurrentRowIndex
        If index < 0 Then
            Me.btnImport.Enabled = False
            Exit Sub
        Else
            Me.btnImport.Enabled = True
        End If
        Try
            strCode = Me.dgOppGuarantee.Item(Me.dgOppGuarantee.CurrentCell.RowNumber, 0)
            strSerial = Me.dgOppGuarantee.Item(Me.dgOppGuarantee.CurrentCell.RowNumber, 1)
            strType = Me.dgOppGuarantee.Item(Me.dgOppGuarantee.CurrentCell.RowNumber, 2)
            SourceProjectCode = strCode
            SourceSerialNum = strSerial

            Dim oppGuarantee As New frmOppGuarantee()

            dsDetailView = oppGuarantee.getOppGuaranteeDetail(strCode, strSerial, strType)
            Me.dgDetail.DataSource = dsDetailView.Tables("opposite_guarantee_detail")
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '点击datagrid事件
    Private Sub dgOppGuarantee_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgOppGuarantee.Click
        setViewEnabled()
        getDetail()
    End Sub
    '浏览图片
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
        strCode = Me.dgOppGuarantee.Item(Me.dgOppGuarantee.CurrentCell.RowNumber, 0)
        strItemType = Me.dgOppGuarantee.Item(Me.dgOppGuarantee.CurrentCell.RowNumber, 2)

        If Not Me.dgOppGuarantee.Item(Me.dgOppGuarantee.CurrentCell.RowNumber, 3) Is System.DBNull.Value Then
            Me.Cursor = Cursors.WaitCursor
            Dim docClass As New frmDocumentClass("")
            'docClass.openFileList(strCode, strItemType, "", strDir)
            docClass.openFileList(strCode, "2%", "", strDir)
            Me.Cursor = Cursors.Default
        Else
            'MsgBox("没有相关的图片!", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1005", "图片")
        End If
    End Sub
    '设置"浏览图片"按钮的可用性
    Private Sub setViewEnabled()
        Dim index As Integer
        index = Me.dgOppGuarantee.CurrentRowIndex
        If index < 0 Then
            Me.btnView.Enabled = False
            Exit Sub
        End If
        If Me.dgOppGuarantee.Item(Me.dgOppGuarantee.CurrentCell.RowNumber, 3) Is System.DBNull.Value Then
            Me.btnView.Enabled = False
        Else
            Me.btnView.Enabled = True
        End If
    End Sub
    '列表中鼠标按下的事件
    Private Sub dgOppGuarantee_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgOppGuarantee.MouseUp
        If Me.dgOppGuarantee.DataSource Is Nothing Then
            Exit Sub
        End If
        If CType(Me.dgOppGuarantee.DataSource, DataTable).Rows.Count > 0 Then
            Me.dgOppGuarantee.Select(Me.dgOppGuarantee.CurrentCell.RowNumber)
            setViewEnabled()
            getDetail()
        End If
    End Sub

    Private Sub chbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbDate.CheckedChanged
        If Not Me.chbDate.Checked Then
            Me.dateEvaluate.Enabled = False
        Else
            Me.dateEvaluate.Enabled = True
        End If
    End Sub
    '绑定反担保物类型
    Private Sub bindingType()
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strSql As String
        strSql = "{item_type_belong='02'}"
        Try
            ds = gWs.GetItemType(strSql)
            dr = ds.Tables(0).NewRow
            With dr
                .Item("item_type") = ""
                .Item("type_name") = ""
            End With
            ds.Tables(0).Rows.InsertAt(dr, 0)
        Catch
        End Try
        If Not ds Is Nothing And ds.Tables.Count > 0 Then
            Me.cmbOppType.DataSource = ds.Tables(0)
            Me.cmbOppType.DisplayMember = "type_name"
            Me.cmbOppType.ValueMember = "item_type"
        End If
    End Sub
    '绑定反担保方式
    Private Sub bindingForm()
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strSql As String
        strSql = "{flag is null}"
        Try
            ds = gWs.GetOppositeGuaranteeForm(strSql)
            dr = ds.Tables(0).NewRow
            With dr
                .Item("name") = ""
                .Item("form_code") = ""
            End With
            ds.Tables(0).Rows.InsertAt(dr, 0)
        Catch
        End Try
        If Not ds Is Nothing And ds.Tables.Count > 0 Then
            Me.cmbOppForm.DataSource = ds.Tables(0)
            Me.cmbOppForm.DisplayMember = "name"
            Me.cmbOppForm.ValueMember = "name"
        End If
    End Sub
    '绑定反担保物状态
    Private Sub bindingStatus()
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strSql As String
        strSql = "%"
        Try
            ds = gWs.GetDdGuarantyStatusInfo(strSql)
            dr = ds.Tables(0).NewRow
            With dr
                .Item("guaranty_status") = ""
            End With
            ds.Tables(0).Rows.InsertAt(dr, 0)
        Catch
        End Try
        If Not ds Is Nothing Then
            If ds.Tables.Count > 0 Then
                Me.cmbOppStatus.DataSource = ds.Tables(0)
                Me.cmbOppStatus.DisplayMember = "guaranty_status"
                Me.cmbOppStatus.ValueMember = "guaranty_status"
            End If
        End If
    End Sub
    '清空
    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Try
            'Me.txtCode.Text = ""
            '把项目编码控件选定内容清空 add by wuzhuohui 2006-04-21
            Me.txtCode.SelectedIndex = -1
            Me.txtName.Text = ""
            Me.txtAddress.Text = ""
            Me.cmbOppForm.SelectedIndex = -1
            Me.cmbOppStatus.SelectedIndex = -1
            Me.cmbOppType.SelectedIndex = -1
            Me.chbDate.Checked = False
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub getProjectCodeList(ByVal ProjectCode As String)
        Dim ds As DataSet
        Dim i, count As Integer
        Dim strSql As String
        Dim corporationCode As String = ProjectCode.Substring(0, 5)
        Try
            strSql = "select project_code from project where project_code like '" & corporationCode & "%' and project_code<> '" & ProjectCode & "' order by project_code"
            ds = gWs.GetCommonQueryInfo(strSql)
            Me.txtCode.DataSource = ds.Tables(0)
            Me.txtCode.ValueMember = "project_code"
            Me.txtCode.DisplayMember = "project_code"
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        Dim strResult As String
        If MsgBoxResult.Yes = MsgBox("确认要导入指定的反担保措施?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "确认") Then
            Try
                strResult = gWs.PCopyOppGuarantee(ProjectCode, SourceProjectCode, SourceSerialNum, CreatePerson, CreateDate)
                If strResult = "1" Then
                    MsgBox("数据导入成功!", MsgBoxStyle.Information + MsgBoxStyle.OKOnly, "提示")
                    If Not frmOppEva Is Nothing Then
                        frmOppEva.setDg()
                    End If
                    If Not frmOppReg Is Nothing Then
                        frmOppReg.setDg()
                    End If

                Else
                    MsgBox("数据导入失败!", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "提示")
                End If
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Sub
End Class
