

Public Class frmAcceptRequest
    Inherits MainInterface.frmMaterial

    Private strProjectCode As String
    Private strCorporationName As String
    Private strCorporationCode As String
    Private strWorkFlowID As String = "01"
    Private strPerson As String
    Private strPhase As String

    Private strItemType As String = "41"  ' 表示企业材料
    Private strItemCode As String = "999" ' 表示其他资料
    Private strMaterial As String = "企业材料"

    Private dsTemp As DataSet '备份的一个中间Projectdocument,当退出而不保存数据时用于恢复数据 'add xie
    Private isLoadOver As Boolean = False 'load是否完成,完成后为true
    Private isNewProjectCode As Boolean = False '项目编号是否是一个新增的,用于是否需要复制材料清单到数据库

    Private dsMaterial As DataSet
    Private dsWorkflow As DataSet
    Private bmMaterial As BindingManagerBase
    Private isLoad As Boolean = False '供退出时判断,是否是刚load,没做任何其他按钮操作
    Private isCommit As Boolean = False '是否是提交，如果是，则在保存成功时，不提示成功信息
    Private currentIndex As Integer '选中当前行
    Private formParent As Form '调用该类的父类

    Private isNewBtn As Boolean = False '保存时,判断是否是新增

    '为修改咨询信息而添加的
    Private str_RecommendMethod As String = "员工开发"
    Private str_RecommendType As String = Nothing
    Private BankDT As DataTable = BankDS.Tables("bank").Copy()
    Private strSerialNum As String 'consultation中的serial_num
    Private isChanged As Boolean '判断是否被修改了
    Private isTxtRecommend As Boolean '判断保存的推荐人信息是否是txtRecommendItem还是cmbRecommendItem的输入

    Private dsBank As DataSet

    '**********************qxd add 2003-12-17***************************
    '从咨询表(consultation)直接复制信息到项目表(project)
    Private guarantee_letter_type As Object
    Private reimburse_type As Object
    Private beneficiary As Object
    '******************************************************************

    Public Event refreshTaskCommit()

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub
    Public Sub New(ByVal frm As Form, ByVal corporationCode As String, ByVal serialNum As String)
        Me.New()
        Me.formParent = frm
        Me.strCorporationCode = corporationCode
        Me.strSerialNum = serialNum
    End Sub
    Public Sub New(ByVal projectCode As String, ByVal corporationCode As String, ByVal corporationName As String, ByVal user As String, ByVal workFlowID As String)
        Me.New()
        Me.strProjectCode = projectCode
        Me.strCorporationCode = corporationCode
        Me.strCorporationName = corporationName
        Me.strPerson = user
        Me.strWorkFlowID = workFlowID
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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridBoolColumn3 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtRecommendPerson As System.Windows.Forms.TextBox
    Friend WithEvents txtVouchSum As System.Windows.Forms.TextBox
    Protected WithEvents nuTerm As System.Windows.Forms.NumericUpDown
    Public WithEvents cmbRecommend As System.Windows.Forms.ComboBox
    Public WithEvents cmbBankCode As System.Windows.Forms.ComboBox
    Public WithEvents cmbServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRecommendItems As System.Windows.Forms.ComboBox
    Friend WithEvents cmbBranch As System.Windows.Forms.ComboBox
    Friend WithEvents chbFirstLoan As System.Windows.Forms.CheckBox
    Friend WithEvents chbAgainAccept As System.Windows.Forms.CheckBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbOperateMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmbOrgName As System.Windows.Forms.ComboBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtOrgOpinion As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents PanelGuarantee As System.Windows.Forms.Panel
    Friend WithEvents dateGuarantStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dateGuarantEnd As System.Windows.Forms.DateTimePicker
    Public WithEvents cbxAddressRangeParent As System.Windows.Forms.ComboBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Public WithEvents cbxAddressRange As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents cbxCorAddressRangeParent As System.Windows.Forms.ComboBox
    Public WithEvents cbxCorAddressRange As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAcceptRequest))
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridBoolColumn3 = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnCommit = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cbxAddressRangeParent = New System.Windows.Forms.ComboBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.cbxAddressRange = New System.Windows.Forms.ComboBox
        Me.PanelGuarantee = New System.Windows.Forms.Panel
        Me.dateGuarantStart = New System.Windows.Forms.DateTimePicker
        Me.Label17 = New System.Windows.Forms.Label
        Me.dateGuarantEnd = New System.Windows.Forms.DateTimePicker
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtOrgOpinion = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmbOrgName = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.cmbOperateMode = New System.Windows.Forms.ComboBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.chbAgainAccept = New System.Windows.Forms.CheckBox
        Me.cmbBranch = New System.Windows.Forms.ComboBox
        Me.chbFirstLoan = New System.Windows.Forms.CheckBox
        Me.nuTerm = New System.Windows.Forms.NumericUpDown
        Me.cmbServiceType = New System.Windows.Forms.ComboBox
        Me.cmbBankCode = New System.Windows.Forms.ComboBox
        Me.txtVouchSum = New System.Windows.Forms.TextBox
        Me.cmbRecommendItems = New System.Windows.Forms.ComboBox
        Me.txtRecommendPerson = New System.Windows.Forms.TextBox
        Me.cmbRecommend = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cbxCorAddressRangeParent = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.cbxCorAddressRange = New System.Windows.Forms.ComboBox
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.PanelGuarantee.SuspendLayout()
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(536, -64)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 64)
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(8, 13)
        Me.Label5.Name = "Label5"
        '
        'txtName
        '
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(392, 21)
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(520, 128)
        Me.Label10.Name = "Label10"
        '
        'dateCheck
        '
        Me.dateCheck.Location = New System.Drawing.Point(560, 128)
        Me.dateCheck.Name = "dateCheck"
        Me.dateCheck.Value = New Date(2003, 4, 16, 13, 51, 28, 31)
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 52)
        Me.Label11.Name = "Label11"
        '
        'chbFile
        '
        Me.chbFile.Location = New System.Drawing.Point(600, -64)
        Me.chbFile.Name = "chbFile"
        Me.chbFile.Size = New System.Drawing.Size(24, 64)
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 448)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(776, 88)
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(440, 16)
        Me.Label4.Name = "Label4"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(376, 128)
        Me.Label9.Name = "Label9"
        '
        'Label2
        '
        Me.Label2.Name = "Label2"
        '
        'txtMaterial
        '
        Me.txtMaterial.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMaterial.Location = New System.Drawing.Point(80, 14)
        Me.txtMaterial.MaxLength = 100
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(352, 21)
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(80, 43)
        Me.txtRemark.MaxLength = 50
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(688, 40)
        Me.txtRemark.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(552, 16)
        Me.Label6.Name = "Label6"
        '
        'Label1
        '
        Me.Label1.Name = "Label1"
        '
        'txtPerson
        '
        Me.txtPerson.Location = New System.Drawing.Point(416, 128)
        Me.txtPerson.Name = "txtPerson"
        '
        'chbImportant
        '
        Me.chbImportant.Location = New System.Drawing.Point(608, 15)
        Me.chbImportant.Name = "chbImportant"
        Me.chbImportant.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(696, 16)
        Me.Label7.Name = "Label7"
        '
        'chbCheck
        '
        Me.chbCheck.Location = New System.Drawing.Point(752, 15)
        Me.chbCheck.Name = "chbCheck"
        Me.chbCheck.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(770, 152)
        Me.Panel1.TabIndex = 4
        '
        'cmbContent
        '
        Me.cmbContent.DropDownWidth = 272
        Me.cmbContent.ItemHeight = 12
        Me.cmbContent.Location = New System.Drawing.Point(496, 16)
        Me.cmbContent.Name = "cmbContent"
        Me.cmbContent.Size = New System.Drawing.Size(272, 20)
        '
        'Label3
        '
        Me.Label3.Name = "Label3"
        '
        'txtCode
        '
        Me.txtCode.Name = "txtCode"
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(8, 240)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 200)
        '
        'dgMaterial
        '
        Me.dgMaterial.AccessibleName = "DataGrid"
        Me.dgMaterial.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgMaterial.Name = "dgMaterial"
        Me.dgMaterial.Size = New System.Drawing.Size(770, 152)
        Me.dgMaterial.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'cmbType
        '
        Me.cmbType.Enabled = True
        Me.cmbType.ItemHeight = 12
        Me.cmbType.Location = New System.Drawing.Point(72, 16)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(192, 20)
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
        Me.btnExit.Location = New System.Drawing.Point(579, 544)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 9
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgMaterial
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = ""
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "资料名称"
        Me.DataGridTextBoxColumn1.MappingName = "doc_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 420
        '
        'DataGridBoolColumn2
        '
        Me.DataGridBoolColumn2.AllowNull = False
        Me.DataGridBoolColumn2.FalseValue = False
        Me.DataGridBoolColumn2.HeaderText = "确认"
        Me.DataGridBoolColumn2.MappingName = "is_check"
        Me.DataGridBoolColumn2.NullText = ""
        Me.DataGridBoolColumn2.NullValue = CType(resources.GetObject("DataGridBoolColumn2.NullValue"), Object)
        Me.DataGridBoolColumn2.TrueValue = True
        Me.DataGridBoolColumn2.Width = 50
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.AllowNull = False
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "关键"
        Me.DataGridBoolColumn1.MappingName = "is_important"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), Object)
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 50
        '
        'DataGridBoolColumn3
        '
        Me.DataGridBoolColumn3.AllowNull = False
        Me.DataGridBoolColumn3.FalseValue = False
        Me.DataGridBoolColumn3.HeaderText = "有文档"
        Me.DataGridBoolColumn3.MappingName = "is_file"
        Me.DataGridBoolColumn3.NullText = ""
        Me.DataGridBoolColumn3.NullValue = CType(resources.GetObject("DataGridBoolColumn3.NullValue"), Object)
        Me.DataGridBoolColumn3.ReadOnly = True
        Me.DataGridBoolColumn3.TrueValue = True
        Me.DataGridBoolColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "备注"
        Me.DataGridTextBoxColumn4.MappingName = "remark"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "确认人"
        Me.DataGridTextBoxColumn2.MappingName = "check_person"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 50
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "日期"
        Me.DataGridTextBoxColumn3.MappingName = "check_date"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 13
        Me.btnNew.ImageList = Me.ImageListBasic
        Me.btnNew.Location = New System.Drawing.Point(139, 544)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 24)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(403, 544)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 24)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(491, 544)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 8
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnModify
        '
        Me.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.ImageIndex = 14
        Me.btnModify.ImageList = Me.ImageListBasic
        Me.btnModify.Location = New System.Drawing.Point(315, 544)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(77, 24)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "修 改(&M)"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(227, 544)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 24)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.cbxCorAddressRangeParent)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.cbxCorAddressRange)
        Me.GroupBox4.Controls.Add(Me.cbxAddressRangeParent)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.cbxAddressRange)
        Me.GroupBox4.Controls.Add(Me.PanelGuarantee)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.txtOrgOpinion)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.cmbOrgName)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.cmbOperateMode)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.chbAgainAccept)
        Me.GroupBox4.Controls.Add(Me.cmbBranch)
        Me.GroupBox4.Controls.Add(Me.chbFirstLoan)
        Me.GroupBox4.Controls.Add(Me.nuTerm)
        Me.GroupBox4.Controls.Add(Me.cmbServiceType)
        Me.GroupBox4.Controls.Add(Me.cmbBankCode)
        Me.GroupBox4.Controls.Add(Me.txtVouchSum)
        Me.GroupBox4.Controls.Add(Me.cmbRecommendItems)
        Me.GroupBox4.Controls.Add(Me.txtRecommendPerson)
        Me.GroupBox4.Controls.Add(Me.cmbRecommend)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(776, 208)
        Me.GroupBox4.TabIndex = 10
        Me.GroupBox4.TabStop = False
        '
        'cbxAddressRangeParent
        '
        Me.cbxAddressRangeParent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxAddressRangeParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddressRangeParent.ItemHeight = 12
        Me.cbxAddressRangeParent.Location = New System.Drawing.Point(123, 114)
        Me.cbxAddressRangeParent.Name = "cbxAddressRangeParent"
        Me.cbxAddressRangeParent.Size = New System.Drawing.Size(152, 20)
        Me.cbxAddressRangeParent.TabIndex = 52
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 117)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(91, 17)
        Me.Label18.TabIndex = 51
        Me.Label18.Text = "保函项目归属地"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxAddressRange
        '
        Me.cbxAddressRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxAddressRange.ItemHeight = 12
        Me.cbxAddressRange.Location = New System.Drawing.Point(281, 114)
        Me.cbxAddressRange.Name = "cbxAddressRange"
        Me.cbxAddressRange.Size = New System.Drawing.Size(152, 20)
        Me.cbxAddressRange.TabIndex = 50
        '
        'PanelGuarantee
        '
        Me.PanelGuarantee.Controls.Add(Me.dateGuarantStart)
        Me.PanelGuarantee.Controls.Add(Me.Label17)
        Me.PanelGuarantee.Controls.Add(Me.dateGuarantEnd)
        Me.PanelGuarantee.Location = New System.Drawing.Point(568, 64)
        Me.PanelGuarantee.Name = "PanelGuarantee"
        Me.PanelGuarantee.Size = New System.Drawing.Size(200, 25)
        Me.PanelGuarantee.TabIndex = 33
        '
        'dateGuarantStart
        '
        Me.dateGuarantStart.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dateGuarantStart.Location = New System.Drawing.Point(0, 2)
        Me.dateGuarantStart.Name = "dateGuarantStart"
        Me.dateGuarantStart.Size = New System.Drawing.Size(88, 21)
        Me.dateGuarantStart.TabIndex = 30
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(92, 5)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(17, 17)
        Me.Label17.TabIndex = 32
        Me.Label17.Text = "至"
        '
        'dateGuarantEnd
        '
        Me.dateGuarantEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dateGuarantEnd.Location = New System.Drawing.Point(114, 2)
        Me.dateGuarantEnd.MinDate = New Date(1975, 1, 1, 0, 0, 0, 0)
        Me.dateGuarantEnd.Name = "dateGuarantEnd"
        Me.dateGuarantEnd.Size = New System.Drawing.Size(88, 21)
        Me.dateGuarantEnd.TabIndex = 31
        Me.dateGuarantEnd.Value = New Date(2006, 6, 9, 17, 9, 0, 0)
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.Location = New System.Drawing.Point(656, 67)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(40, 16)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "个月"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOrgOpinion
        '
        Me.txtOrgOpinion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtOrgOpinion.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtOrgOpinion.Location = New System.Drawing.Point(123, 164)
        Me.txtOrgOpinion.MaxLength = 1000
        Me.txtOrgOpinion.Multiline = True
        Me.txtOrgOpinion.Name = "txtOrgOpinion"
        Me.txtOrgOpinion.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtOrgOpinion.Size = New System.Drawing.Size(645, 38)
        Me.txtOrgOpinion.TabIndex = 21
        Me.txtOrgOpinion.Text = ""
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(11, 168)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(103, 17)
        Me.Label23.TabIndex = 28
        Me.Label23.Text = "担保机构评审意见"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbOrgName
        '
        Me.cmbOrgName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrgName.Location = New System.Drawing.Point(123, 138)
        Me.cmbOrgName.Name = "cmbOrgName"
        Me.cmbOrgName.Size = New System.Drawing.Size(152, 20)
        Me.cmbOrgName.TabIndex = 18
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(11, 138)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(110, 17)
        Me.Label22.TabIndex = 26
        Me.Label22.Text = "担 保 机 构 名 称"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbOperateMode
        '
        Me.cmbOperateMode.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbOperateMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOperateMode.Location = New System.Drawing.Point(568, 40)
        Me.cmbOperateMode.Name = "cmbOperateMode"
        Me.cmbOperateMode.Size = New System.Drawing.Size(200, 20)
        Me.cmbOperateMode.TabIndex = 15
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(480, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(72, 17)
        Me.Label21.TabIndex = 24
        Me.Label21.Text = "运 作 方 式"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chbAgainAccept
        '
        Me.chbAgainAccept.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chbAgainAccept.Location = New System.Drawing.Point(616, 88)
        Me.chbAgainAccept.Name = "chbAgainAccept"
        Me.chbAgainAccept.TabIndex = 20
        Me.chbAgainAccept.Text = "再次申请项目"
        '
        'cmbBranch
        '
        Me.cmbBranch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbBranch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBranch.Location = New System.Drawing.Point(281, 16)
        Me.cmbBranch.Name = "cmbBranch"
        Me.cmbBranch.Size = New System.Drawing.Size(152, 20)
        Me.cmbBranch.TabIndex = 11
        '
        'chbFirstLoan
        '
        Me.chbFirstLoan.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chbFirstLoan.Location = New System.Drawing.Point(480, 88)
        Me.chbFirstLoan.Name = "chbFirstLoan"
        Me.chbFirstLoan.TabIndex = 19
        Me.chbFirstLoan.Text = "是否首次贷款"
        '
        'nuTerm
        '
        Me.nuTerm.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.nuTerm.BackColor = System.Drawing.SystemColors.Window
        Me.nuTerm.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.nuTerm.Location = New System.Drawing.Point(568, 64)
        Me.nuTerm.Name = "nuTerm"
        Me.nuTerm.Size = New System.Drawing.Size(72, 21)
        Me.nuTerm.TabIndex = 17
        Me.nuTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nuTerm.Value = New Decimal(New Integer() {12, 0, 0, 0})
        '
        'cmbServiceType
        '
        Me.cmbServiceType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbServiceType.ItemHeight = 12
        Me.cmbServiceType.Location = New System.Drawing.Point(568, 16)
        Me.cmbServiceType.Name = "cmbServiceType"
        Me.cmbServiceType.Size = New System.Drawing.Size(200, 20)
        Me.cmbServiceType.TabIndex = 12
        '
        'cmbBankCode
        '
        Me.cmbBankCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbBankCode.Location = New System.Drawing.Point(123, 16)
        Me.cmbBankCode.Name = "cmbBankCode"
        Me.cmbBankCode.Size = New System.Drawing.Size(152, 20)
        Me.cmbBankCode.TabIndex = 10
        '
        'txtVouchSum
        '
        Me.txtVouchSum.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtVouchSum.Location = New System.Drawing.Point(123, 66)
        Me.txtVouchSum.MaxLength = 10
        Me.txtVouchSum.Name = "txtVouchSum"
        Me.txtVouchSum.Size = New System.Drawing.Size(152, 21)
        Me.txtVouchSum.TabIndex = 16
        Me.txtVouchSum.Text = ""
        Me.txtVouchSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmbRecommendItems
        '
        Me.cmbRecommendItems.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbRecommendItems.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRecommendItems.Location = New System.Drawing.Point(281, 40)
        Me.cmbRecommendItems.Name = "cmbRecommendItems"
        Me.cmbRecommendItems.Size = New System.Drawing.Size(152, 20)
        Me.cmbRecommendItems.TabIndex = 14
        Me.cmbRecommendItems.Visible = False
        '
        'txtRecommendPerson
        '
        Me.txtRecommendPerson.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRecommendPerson.Location = New System.Drawing.Point(281, 42)
        Me.txtRecommendPerson.MaxLength = 20
        Me.txtRecommendPerson.Name = "txtRecommendPerson"
        Me.txtRecommendPerson.Size = New System.Drawing.Size(152, 21)
        Me.txtRecommendPerson.TabIndex = 11
        Me.txtRecommendPerson.Text = ""
        Me.txtRecommendPerson.Visible = False
        '
        'cmbRecommend
        '
        Me.cmbRecommend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRecommend.ItemHeight = 12
        Me.cmbRecommend.Location = New System.Drawing.Point(123, 41)
        Me.cmbRecommend.Name = "cmbRecommend"
        Me.cmbRecommend.Size = New System.Drawing.Size(152, 20)
        Me.cmbRecommend.TabIndex = 13
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(480, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 17)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "申请业务品种"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 19)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(110, 17)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "申 请 贷 款 银 行"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(480, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(79, 17)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "申请担保期限"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 68)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(116, 17)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "申请担保金额(万元)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 43)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(103, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "推 荐 单 位 (人)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxCorAddressRangeParent
        '
        Me.cbxCorAddressRangeParent.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbxCorAddressRangeParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCorAddressRangeParent.ItemHeight = 12
        Me.cbxCorAddressRangeParent.Location = New System.Drawing.Point(123, 91)
        Me.cbxCorAddressRangeParent.Name = "cbxCorAddressRangeParent"
        Me.cbxCorAddressRangeParent.Size = New System.Drawing.Size(152, 20)
        Me.cbxCorAddressRangeParent.TabIndex = 55
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(11, 94)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 17)
        Me.Label20.TabIndex = 54
        Me.Label20.Text = "企业归属地"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxCorAddressRange
        '
        Me.cbxCorAddressRange.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxCorAddressRange.ItemHeight = 12
        Me.cbxCorAddressRange.Location = New System.Drawing.Point(281, 91)
        Me.cbxCorAddressRange.Name = "cbxCorAddressRange"
        Me.cbxCorAddressRange.Size = New System.Drawing.Size(152, 20)
        Me.cbxCorAddressRange.TabIndex = 53
        '
        'frmAcceptRequest
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(794, 575)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnSave)
        Me.Name = "frmAcceptRequest"
        Me.Text = "受理申请"
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnNew, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.btnModify, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.txtName, 0)
        Me.Controls.SetChildIndex(Me.txtCode, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.GroupBox3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.PanelGuarantee.ResumeLayout(False)
        CType(Me.nuTerm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    '
    '设置项目编码
    '
    Public Sub setProjectCode(ByVal projectCode As String)
        Me.strProjectCode = projectCode
    End Sub
    '
    '设置企业名称
    '
    Public Sub setCorporationName(ByVal corporationName)
        Me.strCorporationName = corporationName
    End Sub
    '
    '设置企业编码
    '
    Public Sub setCorporationCode(ByVal corporationCode)
        Me.strCorporationCode = corporationCode
    End Sub
    '
    '设置用户名
    '
    Public Sub setUser(ByVal userName As String)
        Me.strPerson = userName
    End Sub
    '
    '设置工作流ID
    '
    Public Sub setWorkFlowID(ByVal workFlowID As String)
        Me.strWorkFlowID = workFlowID
    End Sub
    '
    '设置是否是新增的项目编码还是从保存的项目中提取的未受理项目
    '
    Public Sub setIsNewPorjectCode(ByVal isNewCode As Boolean)
        Me.isnewprojectcode = isNewCode
    End Sub
    'load()
    Private Sub frmAcceptRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strSqlTemp As String = " SELECT DISTINCT service_type_parent, service_type,service_type_parent_order, service_type_order" & _
                                   " FROM Workflow " & _
                                   " WHERE service_type_order Is Not NULL " & _
                                   " ORDER BY service_type_parent_order, service_type_order "

        dsWorkflow = gWs.GetCommonQueryInfo(strSqlTemp)

        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            isLoad = True
            Me.txtCode.Text = strProjectCode
            Me.txtName.Text = strCorporationName
            Me.strPhase = getPhase(strProjectCode)

            Me.dateGuarantStart.Value = Now.Date
            Me.dateGuarantEnd.Value = Now.Date.AddYears(1)

            MyBase.addCmbType(strItemType)
            '设置TextBox等的Enabled属性
            MyBase.setTextBox(False)

            '绑定数据到显示企业信息的控件上
            BindControls(strCorporationCode, strSerialNum)

            '绑定企业归属地
            bindingCorDistrict()

            '绑定银行
            bindingBank()

            '绑定业务品种
            bindingServiceType()

            '绑定保函项目归属地
            bindingProjectDistrict()

            '绑定担保机构名称
            Me.bindingOrgName()

            '获得咨询信息
            getConsultation()

            '添加事件
            addHandle()

            '如果是新项目,则复制项目材料
            If isNewProjectCode Then Me.copyTemplate(Me.strProjectCode, Me.cmbServiceType.Text.Trim)

            '设置dgmaterial的数据源
            Me.dsMaterial = setdgdatasource(Me.strProjectCode, True)

            '根据是否关键,设置delete,modify按钮的可用性
            setButton()

            If Not Me.dgMaterial.DataSource Is Nothing Then
                addStyle(Me.dsMaterial)
            End If

            Me.dsTemp = gWs.GetProjectDocumentByCondition("{project_code='" & Me.strProjectCode & "'}")
            Me.isLoadOver = True

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try

    End Sub
    '
    '添加dataGrid的style
    '
    Private Sub addStyle(ByVal ds As DataSet)
        Dim tableStyle As DataGridTableStyle = New DataGridTableStyle()
        tableStyle.MappingName = "TProjectDocument"
        tableStyle.AllowSorting = True
        tableStyle.RowHeadersVisible = True

        Dim numCols As Integer = ds.Tables("TProjectDocument").Columns.Count
        Dim dgc As New DataGridColoredBoolColumn()
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf dgc.MyGetColorRowCol)

        Dim column_1 As New DataGridTextBoxColumn()
        column_1.Width = 380
        column_1.ReadOnly = True
        column_1.NullText = ""
        column_1.HeaderText = "资料名称"
        column_1.MappingName = "doc_name"
        tableStyle.GridColumnStyles.Add(column_1)

        Dim aColumnTextColumn As DataGridColoredBoolColumn
        aColumnTextColumn = New DataGridColoredBoolColumn(d, 0)
        aColumnTextColumn.Width = 60
        aColumnTextColumn.HeaderText = "确认"
        aColumnTextColumn.AllowNull = False
        aColumnTextColumn.MappingName = "is_check"
        tableStyle.GridColumnStyles.Add(aColumnTextColumn)

        Dim bColumnTextColumn As DataGridColoredBoolColumn
        bColumnTextColumn = New DataGridColoredBoolColumn(d, 2)
        bColumnTextColumn.Width = 60
        bColumnTextColumn.HeaderText = "关键"
        bColumnTextColumn.AllowNull = False
        bColumnTextColumn.ReadOnly = True
        bColumnTextColumn.MappingName = "is_important"
        tableStyle.GridColumnStyles.Add(bColumnTextColumn)

        Dim column_2 As New DataGridTextBoxColumn()
        column_2.ReadOnly = True
        column_2.Width = 0
        column_2.NullText = ""
        column_2.HeaderText = "有文档"
        column_2.MappingName = "is_file"
        tableStyle.GridColumnStyles.Add(column_2)

        Dim column_3 As New DataGridTextBoxColumn()
        column_3.ReadOnly = True
        column_3.Width = 120
        column_3.NullText = ""
        column_3.HeaderText = "备注"
        column_3.MappingName = "remark"
        tableStyle.GridColumnStyles.Add(column_3)

        Dim column_4 As New DataGridTextBoxColumn()
        column_4.ReadOnly = True
        column_4.NullText = ""
        column_4.HeaderText = "确认人"
        column_4.MappingName = "check_person"
        tableStyle.GridColumnStyles.Add(column_4)

        Dim column_5 As New DataGridTextBoxColumn()
        column_5.ReadOnly = True
        column_5.NullText = ""
        column_5.HeaderText = "日期"
        column_5.MappingName = "check_date"
        tableStyle.GridColumnStyles.Add(column_5)

        Me.dgMaterial.TableStyles.Clear()
        Me.dgMaterial.TableStyles.Add(tableStyle)
    End Sub
    '
    ' 显示内容
    '
    Private Sub cmbContent_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbContent.SelectedValueChanged
        selectCombox()
    End Sub
    '
    '类型
    '
    Private Sub cmbType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectedValueChanged

        If isLoadOver = True Then
            If Me.cmbType.Text.Trim = "企业材料" Then
                strItemType = "41"
            Else
                strItemType = "42"
            End If
            saveAffirm()
            selectCombox()
        End If
    End Sub
    '设置所有按钮
    Private Sub setAllButton(ByVal isEnabled As Boolean)
        Me.btnNew.Enabled = isEnabled
        Me.btnDelete.Enabled = isEnabled
        Me.btnModify.Enabled = isEnabled
        Me.btnSave.Enabled = isEnabled
        Me.btnCommit.Enabled = isEnabled
    End Sub
    '
    '选择ComBox做的事件
    '
    Private Sub selectCombox()
        Me.Cursor = Cursors.WaitCursor
        Me.dsMaterial = setDgDataSource(strProjectCode, True)
        If Not dsMaterial Is Nothing Then
            Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
        End If
        If Not dsMaterial Is Nothing Then
            If Me.dsMaterial.Tables("TProjectDocument").Rows.Count = 0 Then
                Try
                    setAllButton(False)
                    Me.setButton()
                Catch
                End Try
            ElseIf Me.dsMaterial.Tables("TProjectDocument").Rows.Count > 0 Then
                Try
                    setAllButton(True)
                Catch
                End Try
                setButton()
            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub
    '
    '退出
    '
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        frmExit(sender, e)
    End Sub
    '
    '退出处理
    '
    Private Function frmExit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim changedCount As Integer = 0

        If Not Me.dsMaterial Is Nothing Then
            Try
                If Me.dsMaterial.HasChanges Then
                    changedCount = 1
                    'changedCount = Me.dsMaterial.GetChanges.Tables(0).Rows.Count
                End If
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If

        If isLoad Then
            Me.Close()
            Exit Function
        End If

        If changedCount > 0 Or isChanged Then
            Dim strMesg As Integer
            'strMesg = MsgBox("数据已修改，是否保存？", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "提示")
            strMesg = SWDialogBox.MessageBox.Show("?1003")

            If MsgBoxResult.Yes = strMesg Then
                Call btnSave_Click(sender, e)
                Me.Close()
            ElseIf MsgBoxResult.No = strMesg Then
                Me.delDataset()
                Dim i As Int16 = Me.dsTemp.Tables("TProjectDocument").Rows.Count
                Dim j As Int16 = Me.dsTemp.Tables("TProjectDocument").Columns.Count
                If i > 0 Then
                    Dim dsRet As DataSet = gWs.GetProjectDocumentByCondition("null")
                    For i = 0 To i - 1
                        Dim drSource As DataRow = Me.dsTemp.Tables("TProjectDocument").Rows(i)
                        Dim drRet As DataRow = dsRet.Tables("TProjectDocument").NewRow
                        For j = 0 To j - 1
                            drRet.Item(j) = drSource.Item(j)
                        Next
                        dsRet.Tables("TProjectDocument").Rows.Add(drRet)
                    Next
                    gWs.UpdateProjectDocument(dsRet.GetChanges())
                End If
                Me.Close()
            Else
                Return True
            End If
        Else
            Me.Close()
        End If
    End Function
    '
    '新增
    '
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        isLoad = False
        If btnNew.Text = "新 增(&N)" Then

            '====点击新增时，自动保存确认过的材料，免得再点击取消按钮，丢失了确认过的标记===add by wzh 2006-09-04============================
            If Not dsMaterial Is Nothing Then

                '设置TextBox的Enabled属性
                'setTextBoxEnable(False)

                Dim dr As DataRow
                Dim i As Integer
                Dim strResult As String

                Me.dgMaterial.CurrentRowIndex = currentIndex
                i = Me.dsMaterial.Tables("TProjectDocument").Rows.Count

                If i > 0 Then '保存确认相
                    For i = 0 To i - 1
                        dr = Me.dsMaterial.Tables("TProjectDocument").Rows(i)
                        With dr
                            .Item("phase") = strPhase
                            If Not .Item("is_check") Is System.DBNull.Value Then
                                '三种状态:true,false,DBNull
                                If .Item("is_check") = True Then
                                    .Item("check_person") = strPerson
                                    Try
                                        .Item("check_date") = gWs.GetSysTime()
                                    Catch ex As Exception
                                        ExceptionHandler.ShowMessageBox(ex)
                                    End Try
                                Else
                                    .Item("check_person") = System.DBNull.Value
                                    .Item("check_date") = System.DBNull.Value
                                End If
                            Else
                                .Item("check_person") = System.DBNull.Value
                                .Item("check_date") = System.DBNull.Value
                            End If
                        End With
                    Next
                End If
                strResult = gWs.UpdateProjectDocument(Me.dsMaterial.GetChanges())
                Try
                    Me.dsMaterial = setDgDataSource(strProjectCode, True)
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                Finally
                End Try
            End If
            '===================================================
            isNewBtn = True

            '设置TextBox的Enabled属性
            setTextBoxEnable(True)
            '删除绑定
            delBinding()
            '添加绑定
            addBinding()

            Me.txtMaterial.Text = ""
            Me.txtMaterial.Focus()
            Me.txtRemark.Text = ""
            Me.chbImportant.Checked = False
            Me.chbCheck.Checked = True

            '新增一条记录
            addOtherMaterial()

            btnNew.Text = "取 消(&C)"
            Me.btnDelete.Enabled = False
            Me.btnModify.Enabled = False
            Me.btnCommit.Enabled = False
            Me.dgMaterial.Enabled = False
        ElseIf btnNew.Text = "取 消(&C)" Then
            isNewBtn = False

            '设置TextBox的Enabled属性
            setTextBoxEnable(False)
            '删除绑定
            delBinding()

            '设置DataGrid的DataSource,并返回ds
            Try
                Me.dsMaterial = setDgDataSource(strProjectCode, True)
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            Finally
            End Try

            If Me.dsMaterial.Tables("TProjectDocument").Rows.Count > 0 Then
                Me.btnDelete.Enabled = Not Me.dsMaterial.Tables("TProjectDocument").Rows(Me.dgMaterial.CurrentRowIndex).Item("is_important")
                Me.btnModify.Enabled = True
            Else
                Me.btnDelete.Enabled = False
                btnModify.Enabled = False
            End If
            btnNew.Text = "新 增(&N)"
            Me.btnCommit.Enabled = True
            Me.dgMaterial.Enabled = True
            Me.btnNew.Enabled = True

            If Me.dsMaterial Is Nothing Then
                Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
                Me.dsMaterial.AcceptChanges()
            End If
        End If
    End Sub
    '设置TextBox的Enabled属性
    Private Sub setTextBoxEnable(ByVal isEnabled As Boolean)
        Me.txtMaterial.Enabled = isEnabled
        Me.txtRemark.Enabled = isEnabled
        Me.chbCheck.Enabled = isEnabled
    End Sub
    '
    '新增一条记录
    '
    Private Sub addOtherMaterial()
        Dim dr As DataRow

        If Not Me.dsMaterial Is Nothing Then
            dr = Me.dsMaterial.Tables("TProjectDocument").NewRow
            With dr
                .Item("project_code") = strProjectCode
                .Item("phase") = getPhase(strProjectCode)
                .Item("item_type") = strItemType
                .Item("item_code") = strItemCode
                .Item("doc_name") = Me.txtMaterial.Text
                .Item("remark") = Me.txtRemark.Text
                .Item("is_important") = Me.chbImportant.Checked
                .Item("is_check") = Me.chbCheck.Checked
                .Item("is_file") = False
                .Item("create_person") = strPerson

                Try
                    .Item("create_date") = gWs.GetSysTime()
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
            End With

            Me.dsMaterial.Tables("TProjectDocument").Rows.Add(dr)

            If Not dsMaterial Is Nothing Then
                Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
            End If

            Me.dgMaterial.CurrentRowIndex = Me.bmMaterial.Count - 1
        End If
    End Sub
    '
    '添加绑定
    '
    Private Sub addBinding()
        If Not dsMaterial Is Nothing Then
            Try
                Me.txtMaterial.DataBindings.Add("Text", dsMaterial.Tables("TProjectDocument"), "doc_name")
                Me.txtRemark.DataBindings.Add("Text", dsMaterial.Tables("TProjectDocument"), "remark")
                Me.chbImportant.DataBindings.Add("Checked", dsMaterial.Tables("TProjectDocument"), "is_important")
                Me.chbCheck.DataBindings.Add("Checked", dsMaterial.Tables("TProjectDocument"), "is_check")
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Sub
    '
    '删除绑定
    '
    Private Sub delBinding()
        Me.txtMaterial.DataBindings.Clear()
        Me.txtRemark.DataBindings.Clear()
        Me.chbCheck.DataBindings.Clear()
        Me.chbImportant.DataBindings.Clear()
    End Sub
    '
    '保存
    '
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            If determineDate() Then
                Me.dateGuarantEnd.Focus()
                Exit Sub
            End If
            Me.isCommit = False
            save()
            'Me.isCmbSend = False
            '根据是否关键,设置delete,modify按钮的可用性.
            setButton()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '保存
    Private Function save() As Boolean

        strPhase = getPhase(strProjectCode)
        isLoad = False
        isChanged = False

        '如果运作方式位额度项下保函时,判断是否满足额度项下保函的条件
        If Not Me.isAllowGuaranteeLetter(True) Then Return False

        '向project中添加或修改信息
        createProjectInfo(gWs) 'project的一些基本信息

        If Me.cmbOrgName.Enabled = True Then '再担保业务
            Me.createProjectOrg()
        End If

        If Not dsMaterial Is Nothing Then

            '设置TextBox的Enabled属性
            setTextBoxEnable(False)

            Dim dr As DataRow
            Dim i As Integer
            Dim strResult As String

            Me.dgMaterial.CurrentRowIndex = currentIndex
            i = Me.dsMaterial.Tables("TProjectDocument").Rows.Count

            If i > 0 Then '保存确认相
                For i = 0 To i - 1
                    dr = Me.dsMaterial.Tables("TProjectDocument").Rows(i)
                    With dr
                        .Item("phase") = strPhase
                        If Not .Item("is_check") Is System.DBNull.Value Then
                            '三种状态:true,false,DBNull
                            If .Item("is_check") = True Then
                                .Item("check_person") = strPerson
                                Try
                                    .Item("check_date") = gWs.GetSysTime()
                                Catch ex As Exception
                                    ExceptionHandler.ShowMessageBox(ex)
                                End Try
                            Else
                                .Item("check_person") = System.DBNull.Value
                                .Item("check_date") = System.DBNull.Value
                            End If
                        Else
                            .Item("check_person") = System.DBNull.Value
                            .Item("check_date") = System.DBNull.Value
                        End If
                    End With
                Next
            End If

            '如果文件名(材料类型)为空,则不保存!!! 
            If isNewBtn Then
                Try
                    If Not Me.dsMaterial.GetChanges Is Nothing Then
                        Dim j As Integer
                        j = Me.dsMaterial.Tables("TProjectDocument").Rows.Count
                        If j > 1 Then
                            If Me.dsMaterial.GetChanges.Tables("TProjectDocument").Rows(j - 1).Item("doc_name") = "" Then
                                Me.dsMaterial.RejectChanges()
                            End If
                        End If
                    End If
                Catch ex As Exception
                    'MsgBox(ex.Message)
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
            End If

            strResult = gWs.UpdateProjectDocument(Me.dsMaterial.GetChanges())

            If strResult = "1" Then
                btnNew.Text = "新 增(&N)"
                Me.btnModify.Text = "修 改(&M)"
                Me.btnNew.Enabled = True
                Me.btnDelete.Enabled = True
                Me.btnModify.Enabled = True
                Me.btnCommit.Enabled = True
                Me.dgMaterial.Enabled = True

                Try
                    Me.dsMaterial = setDgDataSource(strProjectCode, True)
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                Finally
                End Try

                If Not dsMaterial Is Nothing Then
                    Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
                    If Not isNewBtn Then
                        Me.dsMaterial.AcceptChanges()
                    End If
                End If

                If Not isCommit Then ' And Me.isCmbSend = False Then
                    'MsgBox("保存成功!", MsgBoxStyle.Information, "提示")
                    SWDialogBox.MessageBox.Show("$SaveSucceed")
                    Me.dsTemp = gWs.GetProjectDocumentByCondition("{project_code='" & Me.strProjectCode & "'}")
                End If
                isNewBtn = False
                Return True
            Else
                SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                Return False
            End If
        End If
    End Function
    '在切换类型时，保存确认项
    Private Sub saveAffirm()
        strPhase = getPhase(strProjectCode)

        If Not dsMaterial Is Nothing Then
            Dim dr As DataRow
            Dim i As Integer
            Dim strResult As String
            i = Me.dsMaterial.Tables("TProjectDocument").Rows.Count

            If i > 0 Then
                For i = 0 To i - 1
                    dr = Me.dsMaterial.Tables("TProjectDocument").Rows(i)
                    With dr
                        .Item("phase") = strPhase
                        If Not .Item("is_check") Is System.DBNull.Value Then
                            '三种状态:true,false,DBNull
                            If .Item("is_check") = True Then
                                .Item("check_person") = strPerson
                                Try
                                    .Item("check_date") = gWs.GetSysTime()
                                Catch ex As Exception
                                    ExceptionHandler.ShowMessageBox(ex)
                                End Try
                            Else
                                .Item("check_person") = System.DBNull.Value
                                .Item("check_date") = System.DBNull.Value
                            End If
                        Else
                            .Item("check_person") = System.DBNull.Value
                            .Item("check_date") = System.DBNull.Value
                        End If
                    End With
                Next
                gWs.UpdateProjectDocument(Me.dsMaterial)
            End If
        End If
    End Sub
    '
    '提交
    '
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            isLoad = False
            If isCommitConfirm Then '需要提交确认
                'If MsgBoxResult.Yes = MsgBox("是否确认提交?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "提示") Then
                If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1000", "提交") Then
                    commit(sender, e)
                End If
            Else
                commit(sender, e)
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '
    '实现提交功能
    '
    Private Sub commit(ByVal sender As System.Object, ByVal e As System.EventArgs)

        '判断文本框的输入值是否满足要求
        If Not Me.isAllowTextCommit() Then
            Exit Sub
        End If

        '此企业是否满足额度相下保函的条件
        If Not isAllowGuaranteeLetter(False) Then
            Exit Sub
        End If

        Dim changedCount As Integer

        If Not Me.dsMaterial Is Nothing Then
            Try
                If Me.dsMaterial.HasChanges Then
                    changedCount = 1
                    'changedCount = Me.dsMaterial.GetChanges.Tables(0).Rows.Count
                End If
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If

        If isLoad Then
            Me.Close()
            Exit Sub
        End If

        Dim strSaveSuccess As String = "1"
        If changedCount > 0 Then
            Me.isCommit = True
            '如果保存失败,则不继续往下提交
            If Not save() Then
                setButton()
                Me.isCommit = False
                Exit Sub
            End If
        Else
            strSaveSuccess = createProjectInfo(gWs)
        End If

        If Not strSaveSuccess = "1" Then
            'MsgBox("创建项目失败!" & strSaveSuccess, MsgBoxStyle.Critical, "提示")
            SWDialogBox.MessageBox.Show("*999", "", strSaveSuccess, "")
            Exit Sub
        End If

        If isAccreditCommit() Then
            'MsgBox("有关键的材料未确认,不能提交!", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$X022")
            setButton()
            isCommit = False
            Exit Sub
        End If

        '此公司是否存在一个已受理的同一业务品种的未提交调研结论的项目(受理条件的判断应放在保存之后,否则判断的存储过程逻辑出现错误)
        If Me.isAnotherProject() Then
            Exit Sub
        End If

        '判断企业归属地和项目归属地
        If Me.cbxCorAddressRangeParent.Text = "" Then
            SWDialogBox.MessageBox.Show("$1001", "企业归属地(一级)")
            Me.cbxAddressRangeParent.Focus()
            Exit Sub
        End If

        If Me.cbxCorAddressRange.Text = "" Then
            SWDialogBox.MessageBox.Show("$1001", "企业归属地(二级)")
            Me.cbxAddressRange.Focus()
            Exit Sub
        End If

        If cmbServiceType.Text.Trim() = "保函" Then
            If Me.cbxAddressRangeParent.Text = "" Then
                SWDialogBox.MessageBox.Show("$1001", "保函项目归属地(一级)")
                Me.cbxAddressRangeParent.Focus()
                Exit Sub
            End If

            If Me.cbxAddressRange.Text = "" Then
                SWDialogBox.MessageBox.Show("$1001", "保函项目归属地(二级)")
                Me.cbxAddressRange.Focus()
                Exit Sub
            End If
        End If


        Dim strResult As String
        strWorkFlowID = Me.cmbOperateMode.Text.Trim
        Try
            strResult = gWs.CreateProcess(strWorkFlowID, strProjectCode, strPerson)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If strResult = "1" Then
            'MsgBox("提交成功！", MsgBoxStyle.Information, "提示")
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            RaiseEvent refreshTaskCommit()
            Me.Close()
        Else
            'MsgBox("提交失败！" & strResult, MsgBoxStyle.Critical, "提示")
            SWDialogBox.MessageBox.Show("*999", "", strResult, "")
            isCommit = False
        End If

    End Sub
    '
    '判断基本的确认项是否已确认,是关键的,提交时验证是否确认了.
    '如果有一个没有确认,则返回true   
    'modify 不需要验证反担保材料
    '
    Private Function isAccreditCommit() As Boolean
        Dim ds As DataSet
        Dim strSql As String
        Try
            strSql = "{project_code='" & strProjectCode & "' and item_type='41' and is_important='1' order by item_type}"
            ds = gWs.GetProjectDocumentByCondition(strSql)
        Catch
        End Try
        If Not ds Is Nothing Then
            Dim i As Integer
            Dim dr As DataRow
            Try
                i = ds.Tables("TProjectDocument").Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = ds.Tables("TProjectDocument").Rows(i)
                        With dr
                            If (.Item("check_person") Is System.DBNull.Value) Then
                                Me.cmbType.Text = "企业材料"
                                Return True '返回
                            End If
                        End With
                    Next
                End If
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
            Return False
        End If
    End Function
    '
    '向project中添加或修改信息
    '
    Private Function createProjectInfo(ByVal gWs As htfServer.Service1) As String
        Dim dr As DataRow
        Dim dsProject As DataSet
        Dim strResult As String
        Dim dsCorporation As DataSet
        Dim strSql As String
        Try
            dsProject = gWs.GetProjectInfo(strProjectCode)
            dsCorporation = gWs.GetcorporationInfo("{corporation_code='" & strCorporationCode & "'}", "null")
            If dsCorporation.Tables(0).Rows.Count <> 0 Then
                dsCorporation.Tables(0).Rows(0).Item("district_parent_name") = cbxCorAddressRangeParent.Text
                dsCorporation.Tables(0).Rows(0).Item("district_name") = cbxCorAddressRange.Text
            End If
            strResult = gWs.UpdateCorCon(dsCorporation.GetChanges(DataRowState.Modified))

            If dsProject.Tables("project").Rows.Count > 0 Then '修改
                dr = dsProject.Tables("project").Rows(0)
                With dr
                    .Item("create_person") = strPerson

                    If Me.cbxAddressRangeParent.Enabled = True Then '保函业务
                        .Item("bh_project_district_parent_name") = cbxAddressRangeParent.Text
                        .Item("bh_project_district_name") = cbxAddressRange.Text
                    End If

                    Try
                        .Item("apply_date") = gWs.GetSysTime()
                        '记录创建日期只有在刚开始填写， 其他任何时候都不应该修改
                        '另外，此日期会作为创建项目编码的一个参照数。
                        ' .Item("create_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try

                    .Item("consult_serial_num") = Me.strSerialNum
                    .Item("apply_service_type") = Me.cmbServiceType.SelectedValue
                    .Item("workflow") = Me.cmbOperateMode.Text
                    .Item("apply_bank") = Me.cmbBankCode.SelectedValue
                    'BankChanged(Nothing, Nothing)
                    .Item("apply_branch_bank") = Me.cmbBranch.SelectedValue
                    .Item("apply_sum") = IIf(Me.txtVouchSum.Text.Trim = "", "0", Me.txtVouchSum.Text)
                    .Item("apply_term") = Me.nuTerm.Text
                    .Item("recommend_type") = Me.cmbRecommend.Text
                    'If Me.cmbRecommendItems.Text = "" Then
                    If isTxtRecommend Then
                        .Item("recommend_person") = Me.txtRecommendPerson.Text
                    Else
                        .Item("recommend_person") = Me.cmbRecommendItems.Text
                    End If
                    .Item("is_first_loan") = Me.chbFirstLoan.Checked
                    .Item("is_again_apply") = Me.chbAgainAccept.Checked
                    'qxd add 2004-11-19 申请人所属的Team_name
                    .Item("applicantTeam_name") = getStaffTeamName(UserName)
                    'qxd add 2004-11-30 保函期限
                    If Me.PanelGuarantee.Visible Then
                        .Item("guarant_start_date") = Me.dateGuarantStart.Value
                        .Item("guarant_end_date") = Me.dateGuarantEnd.Value
                    Else
                        .Item("guarant_start_date") = System.DBNull.Value
                        .Item("guarant_end_date") = System.DBNull.Value
                    End If

                    'add by 9sky 20050725 
                    If Me.cmbOperateMode.Text = "额度项下保函" Then
                        .Item("managerTeam_name") = gWs.GetCommonQueryInfo("select branch_name from staff where staff_name='" & UserName & "'").Tables(0).Rows(0)(0)
                    End If
                End With
                strResult = gWs.UpdateProject(dsProject.GetChanges(DataRowState.Modified))
            Else '创建
                Dim ds As DataSet
                Dim drConsult As DataRow
                Dim i As Integer
                dr = dsProject.Tables("project").NewRow

                With dr
                    .Item("project_code") = strProjectCode
                    .Item("corporation_code") = strCorporationCode
                    Try
                        .Item("apply_date") = gWs.GetSysTime()
                        .Item("create_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                    .Item("create_person") = strPerson

                    If Me.cbxAddressRangeParent.Enabled = True Then '保函业务
                        .Item("bh_project_district_parent_name") = cbxAddressRangeParent.Text
                        .Item("bh_project_district_name") = cbxAddressRange.Text
                    End If

                    .Item("consult_serial_num") = Me.strSerialNum
                    .Item("apply_service_type") = Me.cmbServiceType.SelectedValue
                    .Item("workflow") = Me.cmbOperateMode.Text
                    .Item("apply_bank") = Me.cmbBankCode.SelectedValue
                    'BankChanged(Nothing, Nothing)
                    .Item("apply_branch_bank") = Me.cmbBranch.SelectedValue
                    .Item("apply_sum") = IIf(Me.txtVouchSum.Text.Trim = "", "0", Me.txtVouchSum.Text)
                    .Item("apply_term") = Me.nuTerm.Text
                    .Item("recommend_type") = Me.cmbRecommend.Text
                    'If Me.cmbRecommendItems.Text = "" Then
                    If isTxtRecommend Then
                        .Item("recommend_person") = Me.txtRecommendPerson.Text
                    Else
                        .Item("recommend_person") = Me.cmbRecommendItems.Text
                    End If
                    .Item("is_first_loan") = Me.chbFirstLoan.Checked
                    .Item("is_again_apply") = Me.chbAgainAccept.Checked
                    'qxd add 2003-12-17------------------
                    .Item("guarantee_letter_type") = guarantee_letter_type
                    .Item("reimburse_type") = reimburse_type
                    .Item("beneficiary") = beneficiary
                    'qxd add 2003-12-17------------------
                    'qxd add 2004-11-19 申请人所属的Team_name
                    .Item("applicantTeam_name") = getStaffTeamName(UserName)
                    'qxd add 2004-11-30 保函期限
                    If Me.PanelGuarantee.Visible Then
                        .Item("guarant_start_date") = Me.dateGuarantStart.Value
                        .Item("guarant_end_date") = Me.dateGuarantEnd.Value
                    Else
                        .Item("guarant_start_date") = System.DBNull.Value
                        .Item("guarant_end_date") = System.DBNull.Value
                    End If
                End With
                dsProject.Tables("project").Rows.Add(dr)
                strResult = gWs.UpdateProject(dsProject.GetChanges(DataRowState.Added))
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Return strResult
    End Function
    '
    '向TProjectOrganization添加或修改信息
    '
    Private Function createProjectOrg() As String
        If cmbOrgName.Text = "" Or cmbOrgName.SelectedValue = Nothing Then Exit Function
        Dim dsProjectOrg As DataSet
        dsProjectOrg = gWs.GetProjectOrganization("{project_code='" & Me.strProjectCode & "'}")
        Dim dt As DataTable = dsProjectOrg.Tables(0)
        Dim dr As DataRow
        Dim strResult As String
        Try
            If dt.Rows.Count > 0 Then
                dr = dt.Rows(0)
                With dr
                    .Item("project_code") = Me.strProjectCode
                    .Item("organno") = Me.cmbOrgName.SelectedValue
                    '.Item("ReguaranteeSum") = Me.txtVouchSum.Text
                    '.Item("ReguaranteeTerm") = Me.nuTerm.Text
                    .Item("OrganizationOpinion") = Me.txtOrgOpinion.Text
                End With
                strResult = gWs.UpdateProjectOrganization(dsProjectOrg.GetChanges(DataRowState.Modified))
            Else
                dr = dt.NewRow()
                With dr
                    .Item("project_code") = Me.strProjectCode
                    .Item("organno") = Me.cmbOrgName.SelectedValue
                    '.Item("ReguaranteeSum") = Me.txtVouchSum.Text
                    '.Item("ReguaranteeTerm") = Me.nuTerm.Text
                    .Item("OrganizationOpinion") = Me.txtOrgOpinion.Text
                    If Me.isNewProjectCode Then
                        Dim strSql As String = "select top 1 * from consultation where corporation_code='" & strCorporationCode & "' order by serial_num desc"
                        Dim ds As DataSet = gWs.GetCommonQueryInfo(strSql)
                        .Item("sourceservicetype") = ds.Tables(0).Rows(0).Item("source_service_type")
                        .Item("sourceloansum") = ds.Tables(0).Rows(0).Item("source_guarantee_sum")
                        .Item("sourceloanterm") = ds.Tables(0).Rows(0).Item("source_guarantee_term")
                    End If
                End With
                dt.Rows.Add(dr)
                strResult = gWs.UpdateProjectOrganization(dsProjectOrg.GetChanges(DataRowState.Added))
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Return strResult
    End Function
    '复制材料清单
    '同时复制企业材料和反担保材料
    '"41":企业材料;"42":反担保材料
    '
    Private Sub copyTemplate(ByVal projectCode As String, ByVal serviceType As String)

        Dim dsItem, dsDocument, dsDocTemp As DataSet
        Dim i As Integer
        Dim strSql As String
        'strSql = "{project_code='" & projectCode & "' and (item_type='" & itemType & "' or item_type='42')}"
        strSql = "{project_code='" & projectCode & "'}"
        If Not gWs Is Nothing Then
            Try
                dsDocument = gWs.GetProjectDocumentByCondition(strSql)
                dsDocTemp = gWs.GetProjectDocumentByCondition("null")
                '一起复制反担保材料"42"
                'dsItem = gWs.GetItemEx("{(item_type='" & itemType & "' or item_type='42') and not item_code='999'}")
                dsItem = gWs.GetMaterial("{service_type='" & serviceType & "' and not item_code='999'}")
                i = dsDocument.Tables("TProjectDocument").Rows.Count
                If i > 0 Then
                    '模板文档已经存在,不复制;否则,复制模板文档
                    '先删除所有材料
                    delDataset()
                End If
                Me.dsMaterial = copyDataset(gWs, dsItem, dsDocTemp, strProjectCode)
                Me.dsMaterial = setdgdatasource(Me.strProjectCode, True)
                If Not Me.dsMaterial Is Nothing Then
                    addStyle(Me.dsMaterial)
                End If
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Sub
    '
    '删除project_document中的反担保材料的记录
    '删除project_document中的所有材料记录 modify xie
    Private Sub delDataset()
        Dim i As Integer
        Dim ds As DataSet
        Dim strSql As String
        If Not gWs Is Nothing Then
            'strSql = "{project_code='" & strProjectCode & "' and item_type='42'}"
            strSql = "{project_code='" & strProjectCode & "'}"
            Try
                ds = gWs.GetProjectDocumentByCondition(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        ds.Tables(0).Rows(i).Delete()
                    Next
                    gWs.UpdateProjectDocument(ds.GetChanges())
                End If
            Catch
            End Try
        End If
    End Sub
    '
    '复制材料清单
    '
    Private Function copyDataset(ByVal gWs As htfServer.Service1, ByVal dsItem As DataSet, ByVal dsDocTemp As DataSet, ByVal projectCode As String) As DataSet
        Dim i As Integer
        Dim strResult As String
        Dim drItem, drDocTemp As DataRow
        Try
            i = dsItem.Tables("TMaterial").Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    drItem = dsItem.Tables("TMaterial").Rows(i)
                    drDocTemp = dsDocTemp.Tables("TProjectDocument").NewRow
                    With drItem
                        drDocTemp.Item("project_code") = projectCode
                        drDocTemp.Item("phase") = strPhase
                        drDocTemp.Item("item_type") = .Item("item_type")
                        drDocTemp.Item("item_code") = .Item("item_code")
                        drDocTemp.Item("doc_name") = .Item("item_name")
                        drDocTemp.Item("is_important") = .Item("is_important")
                        drDocTemp.Item("create_person") = strPerson
                        Try
                            drDocTemp.Item("create_date") = gWs.GetSysTime()
                        Catch ex As Exception
                            ExceptionHandler.ShowMessageBox(ex)
                        End Try
                    End With
                    dsDocTemp.Tables("TProjectDocument").Rows.Add(drDocTemp)
                Next
                strResult = gWs.UpdateProjectDocument(dsDocTemp.GetChanges)
                If strResult = "1" Then
                    Me.dsMaterial = setDgDataSource(strProjectCode, True)
                    If Not dsMaterial Is Nothing Then
                        Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
                    End If
                    Return dsDocTemp
                Else
                    SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                    Return Nothing
                End If
            Else
                If isLoad = False Then
                    SWDialogBox.MessageBox.Show("$1005", "材料清单")
                End If
                Return Nothing
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    'KeyPress()
    Private Sub frmAcceptRequest_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
    End Sub
    'closing()
    Private Sub frmAcceptRequest_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If sender.GetType Is GetType(Form) Then
            If frmExit(sender, e) Then
                e.Cancel = True
            End If
        End If
    End Sub
    '修改
    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            isLoad = False
            If Me.btnModify.Text = "修 改(&M)" Then
                Dim i As Integer
                i = Me.dgMaterial.CurrentRowIndex
                currentIndex = i
                If i >= 0 Then
                    Me.dgMaterial.Select(i)
                    setTextBoxEnable(True)
                    Me.delBinding()
                    Me.addBinding()
                    If Not Me.dsMaterial Is Nothing Then
                        Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
                    End If
                    Me.dgMaterial.CurrentRowIndex = i
                End If
                Me.dgMaterial.Enabled = False
                Me.btnNew.Enabled = False
                Me.btnDelete.Enabled = False
                Me.btnCommit.Enabled = False
                Me.btnModify.Text = "取 消(&C)"
            Else
                setTextBoxEnable(False)
                Me.delBinding()
                Try
                    Me.dsMaterial = setDgDataSource(strProjectCode, True)
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                Finally
                End Try

                If Me.dsMaterial.Tables("TProjectDocument").Rows.Count > 0 Then
                    Me.btnDelete.Enabled = Not Me.dsMaterial.Tables("TProjectDocument").Rows(Me.dgMaterial.CurrentRowIndex).Item("is_important")
                    Me.btnModify.Enabled = True
                Else
                    Me.btnDelete.Enabled = False
                    btnModify.Enabled = False
                End If

                Me.btnCommit.Enabled = True
                Me.btnNew.Enabled = True
                Me.dgMaterial.Enabled = True
                Me.btnModify.Text = "修 改(&M)"

                If Not Me.dsMaterial Is Nothing Then
                    Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
                    Me.dsMaterial.AcceptChanges()
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '点击datagrid,设置text显示的内容
    Private Sub setTextContent()
        Static lastRow As Integer = -1
        Me.dgMaterial.Select(Me.dgMaterial.CurrentCell.RowNumber)
        If Me.dgMaterial.CurrentRowIndex <> lastRow Then
            currentIndex = Me.dgMaterial.CurrentRowIndex
            Try
                If Not Me.dsMaterial.Tables("TProjectDocument").Rows(Me.dgMaterial.CurrentCell.RowNumber).Item("is_check") Is System.DBNull.Value Then
                    If Not Me.dsMaterial.Tables("TProjectDocument").Rows(Me.dgMaterial.CurrentCell.RowNumber).Item("is_check") Then
                        isLoad = False
                    End If
                End If
            Catch ex As Exception
            Finally
                Try
                    Me.setMaterialInfo(Me.dgMaterial, 1)
                Catch ex As Exception
                    'MsgBox(ex.Message)
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
            End Try
            setButton()
        End If
        lastRow = Me.dgMaterial.CurrentRowIndex
    End Sub
    '列表中鼠标按下事件
    Private Sub dgMaterial_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgMaterial.MouseUp
        If Me.dsMaterial Is Nothing Then
            Exit Sub
        End If
        If Me.dsMaterial.Tables("TProjectDocument").Rows.Count > 0 Then
            Me.dgMaterial.Select(Me.dgMaterial.CurrentCell.RowNumber)
            '单击datagrid中的checkbox时改变checked
            Dim rowNum, colNum As Integer
            rowNum = Me.dgMaterial.CurrentCell.RowNumber
            colNum = Me.dgMaterial.CurrentCell.ColumnNumber
            If colNum = 1 Then
                isLoad = False
                Dim he As DataGrid = CType(sender, DataGrid)
                If he.HitTest(e.X, e.Y).Type <> DataGrid.HitTestType.Cell Then Return
                Me.dgMaterial.Item(rowNum, colNum) = Not Me.dgMaterial.Item(rowNum, colNum)
            End If
            setTextContent()
        End If
    End Sub
    '删除
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            isLoad = False
            If Not Me.dsMaterial Is Nothing Then
                Dim strResult As String
                Try
                    If Not Me.dsMaterial Is Nothing Then
                        Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
                    End If
                    Dim i As Int16 = Me.dgMaterial.CurrentRowIndex
                    'If MsgBoxResult.OK = MsgBox("确定删除选中的记录吗?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "提示") Then
                    If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1004", "选中的") Then
                        Me.bmMaterial.Position = Me.dgMaterial.CurrentRowIndex
                        CType(Me.bmMaterial.Current, DataRowView).Delete()
                        strResult = gWs.UpdateProjectDocument(Me.dsMaterial.GetChanges)
                        Me.dsMaterial = setDgDataSource(strProjectCode, True)
                        If Not Me.dsMaterial Is Nothing Then
                            Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
                            Me.dsMaterial.AcceptChanges()
                        End If
                        If strResult = "1" Then
                        Else
                            SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                        End If
                    End If
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
            End If
            setButton()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '根据是否关键,设置delete,modify按钮的可用性.
    Private Sub setButton()
        Dim dt As DataTable
        Try
            If Not Me.dgMaterial.DataSource Is Nothing Then

                dt = CType(Me.dgMaterial.DataSource, DataTable)
                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then
                        If Not dt.Rows(Me.dgMaterial.CurrentCell.RowNumber).Item("is_important") Is System.DBNull.Value Then
                            Me.btnDelete.Enabled = Not dt.Rows(Me.dgMaterial.CurrentCell.RowNumber).Item("is_important")
                        Else
                            Me.btnDelete.Enabled = True
                        End If
                        Me.btnModify.Enabled = True
                    Else
                        Me.btnDelete.Enabled = False
                        Me.btnModify.Enabled = False
                    End If
                Else
                    Me.btnDelete.Enabled = False
                    Me.btnModify.Enabled = False
                End If
                Me.btnSave.Enabled = True
                Me.btnCommit.Enabled = True
                Me.btnNew.Enabled = True
            Else
                If Not Me.btnDelete Is Nothing Then
                    Me.btnDelete.Enabled = False
                End If
                If Not Me.btnModify Is Nothing Then
                    Me.btnModify.Enabled = False
                End If
                If Not Me.btnSave Is Nothing Then
                    Me.btnSave.Enabled = False
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '获得咨询信息
    Private Sub getConsultation()
        Dim ds As DataSet
        Dim drConsult As DataRow
        Dim i As Integer
        Dim strSql As String
        Dim isConsultTable As Boolean
        strSql = "{project_code='" & strProjectCode & "'}"
        ds = gWs.GetProjectInfo(strSql)
        i = ds.Tables("project").Rows.Count
        If Not i > 0 Then
            isConsultTable = True
            strSql = "select top 1 * from consultation where corporation_code='" & strCorporationCode & "' order by serial_num desc"
            ds = gWs.GetCommonQueryInfo(strSql)
            i = ds.Tables(0).Rows.Count
        End If
        If i > 0 Then
            drConsult = ds.Tables(0).Rows(0)
            '再担保
            If Me.isNewProjectCode = True Then
                Me.txtOrgOpinion.Text = drConsult.Item("organization_opinion").ToString
                Me.cmbOrgName.SelectedValue = IIf(drConsult.Item("organno") Is System.DBNull.Value, System.DBNull.Value, drConsult.Item("organno"))
            Else
                Dim dsPO As DataSet = gWs.GetProjectOrganization("{project_code='" & Me.strProjectCode & "'}")
                If dsPO.Tables(0).Rows.Count > 0 Then
                    Me.txtOrgOpinion.Text = dsPO.Tables(0).Rows(0).Item("organizationopinion").ToString
                    Me.cmbOrgName.SelectedValue = IIf(dsPO.Tables(0).Rows(0).Item("organno") Is System.DBNull.Value, System.DBNull.Value, dsPO.Tables(0).Rows(0).Item("organno"))
                End If
            End If

            Me.cmbServiceType.SelectedValue = IIf(drConsult.Item("apply_service_type") Is System.DBNull.Value, System.DBNull.Value, drConsult.Item("apply_service_type"))
            'qxd add 2003-12-17 ---------------------------
            guarantee_letter_type = IIf(drConsult.Item("guarantee_letter_type") Is System.DBNull.Value, System.DBNull.Value, drConsult.Item("guarantee_letter_type"))
            reimburse_type = IIf(drConsult.Item("reimburse_type") Is System.DBNull.Value, System.DBNull.Value, drConsult.Item("reimburse_type"))
            beneficiary = IIf(drConsult.Item("beneficiary") Is System.DBNull.Value, System.DBNull.Value, drConsult.Item("beneficiary"))
            'qxd add 2003-12-17 ---------------------------

            If isConsultTable Then
                Me.cmbBankCode.SelectedValue = IIf(drConsult.Item("apply_bank_code") Is System.DBNull.Value, System.DBNull.Value, drConsult.Item("apply_bank_code"))
                Me.cmbBranch.SelectedValue = IIf(drConsult.Item("apply_branch_code") Is System.DBNull.Value, System.DBNull.Value, drConsult.Item("apply_branch_code"))
                cmbServiceType_SelectedIndexChanged(Nothing, Nothing)
            Else
                Me.cmbBankCode.SelectedValue = IIf(drConsult.Item("apply_bank") Is System.DBNull.Value, System.DBNull.Value, drConsult.Item("apply_bank"))
                Me.cmbBranch.SelectedValue = IIf(drConsult.Item("apply_branch_bank") Is System.DBNull.Value, System.DBNull.Value, drConsult.Item("apply_branch_bank"))
                cmbServiceType_SelectedIndexChanged(Nothing, Nothing)
                Me.cmbOperateMode.SelectedItem = IIf(drConsult.Item("workflow") Is System.DBNull.Value, Me.cmbServiceType.Text, drConsult.Item("workflow"))
            End If
            If isConsultTable Then
                Me.txtVouchSum.Text = drConsult.Item("apply_guarantee_sum").ToString
            Else
                Me.txtVouchSum.Text = drConsult.Item("apply_sum").ToString
            End If
            Me.nuTerm.Text = drConsult.Item("apply_term").ToString
            'qxd add 2004-11-30 保函期限
            If Me.PanelGuarantee.Visible And isConsultTable = False Then
                Me.dateGuarantStart.Value = drConsult.Item("guarant_start_date")
                Me.dateGuarantEnd.Value = drConsult.Item("guarant_end_date")
            End If
            Me.cmbRecommend.Text = drConsult.Item("recommend_type").ToString
            Me.cmbRecommendItems.SelectedValue = IIf(drConsult.Item("recommend_person") Is System.DBNull.Value, System.DBNull.Value, drConsult.Item("recommend_person"))
            Me.txtRecommendPerson.Text = drConsult.Item("recommend_person").ToString
            If Not drConsult.Item("is_first_loan") Is System.DBNull.Value Then
                If drConsult.Item("is_first_loan") Then
                    Me.chbFirstLoan.Checked = True
                Else
                    Me.chbFirstLoan.Checked = False
                End If
            End If
            If Not isConsultTable Then
                If Not drConsult.Item("is_again_apply") Is System.DBNull.Value Then
                    If drConsult.Item("is_again_apply") Then
                        Me.chbAgainAccept.Checked = True
                    Else
                        Me.chbAgainAccept.Checked = False
                    End If
                End If
            End If
        End If
    End Sub
    '绑定银行
    Private Sub bindingBank()
        '申请贷款银行
        If dsBank Is Nothing Then
            'dsBank = gWs.GetBankInfo("{bank_name like '%' order by bank_name}", "{branch_bank_name like '%' order by branch_bank_name}")
            'qxd modify 2005-10-21 通过存储实现了按名称升序排序
            dsBank = gWs.GetBankInfo("%", "%")
        End If
        Me.cmbBankCode.DataSource = dsBank.Tables("bank")
        Me.cmbBankCode.DisplayMember = "bank_name"
        Me.cmbBankCode.ValueMember = "bank_code"
        Me.cmbBranch.DataSource = dsBank.Tables("bank_branch").DefaultView
        Me.cmbBranch.DisplayMember = "branch_bank_name"
        Me.cmbBranch.ValueMember = "branch_bank_code"
        AddHandler cmbBankCode.SelectedIndexChanged, AddressOf BankChanged
        BankChanged(Nothing, Nothing)
    End Sub
    '根据银行编码初始化支行的ComboBox
    Protected Sub BankChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.cmbBranch.DataBindings.Clear()
        Me.dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code='" & Me.cmbBankCode.SelectedValue & "'"
    End Sub
    '绑定推荐人
    Private Sub bindingReCommend()
        Dim ds As DataSet
        ds = gWs.GetRecommendType("%")
        Me.cmbRecommend.DataSource = ds.Tables(0)
        Me.cmbRecommend.DisplayMember = "recommend_type"
        Me.cmbRecommend.ValueMember = "type_code"
        AddHandler txtRecommendPerson.TextChanged, AddressOf txtRecommendPerson_TextChanged '推荐单位或个人
        AddHandler cmbRecommendItems.SelectedIndexChanged, AddressOf cbxRecommendItems_SelectedIndexChanged
        AddHandler cmbRecommend.SelectedIndexChanged, AddressOf cbxRecommendType_SelectedIndexChanged
    End Sub
    '绑定业务品种
    Private Sub bindingServiceType()
        Dim ds As DataSet
        ds = gWs.GetServiceType("%")
        Me.cmbServiceType.DataSource = ds.Tables(0)
        Me.cmbServiceType.DisplayMember = "service_type"
        Me.cmbServiceType.ValueMember = "service_type"
        AddHandler cmbServiceType.SelectedIndexChanged, AddressOf cmbServiceType_SelectedIndexChanged
    End Sub

    '绑定企业归属地
    Private Sub bindingCorDistrict()
        Me.cbxCorAddressRangeParent.DataSource = VouchService.GetCommonQueryInfo("select distinct district_parent_name from district").Tables(0)
        Me.cbxCorAddressRangeParent.DisplayMember = "district_parent_name"
        Me.cbxCorAddressRangeParent.ValueMember = "district_parent_name"

        Me.cbxCorAddressRange.DataSource = VouchService.GetCommonQueryInfo("select * from district where district_parent_name='" & cbxAddressRangeParent.SelectedValue & "' order by district_code").Tables(0)
        Me.cbxCorAddressRange.DisplayMember = "district_name"
        Me.cbxCorAddressRange.ValueMember = "district_name"

        AddHandler cbxCorAddressRangeParent.SelectedIndexChanged, AddressOf cbxCorAddressRangeParent_SelectedIndexChanged

        Dim dsCorp As DataSet = gWs.GetCommonQueryInfo("select district_parent_name,district_name from corporation where corporation_code='" & strCorporationCode & "'")
        If dsCorp.Tables(0).Rows.Count <> 0 Then
            cbxCorAddressRangeParent.SelectedValue = IIf(dsCorp.Tables(0).Rows(0).Item("district_parent_name") Is System.DBNull.Value, System.DBNull.Value, dsCorp.Tables(0).Rows(0).Item("district_parent_name"))
            cbxCorAddressRange.SelectedValue = IIf(dsCorp.Tables(0).Rows(0).Item("district_name") Is System.DBNull.Value, System.DBNull.Value, dsCorp.Tables(0).Rows(0).Item("district_name"))
        End If

    End Sub

    '绑定保函项目归属地
    Private Sub bindingProjectDistrict()
        Me.cbxAddressRangeParent.DataSource = VouchService.GetCommonQueryInfo("select distinct district_parent_name from district").Tables(0)
        Me.cbxAddressRangeParent.DisplayMember = "district_parent_name"
        Me.cbxAddressRangeParent.ValueMember = "district_parent_name"

        Me.cbxAddressRange.DataSource = VouchService.GetCommonQueryInfo("select * from district where district_parent_name='" & cbxAddressRangeParent.SelectedValue & "' order by district_code").Tables(0)
        Me.cbxAddressRange.DisplayMember = "district_name"
        Me.cbxAddressRange.ValueMember = "district_name"

        AddHandler cbxAddressRangeParent.SelectedIndexChanged, AddressOf cbxAddressRangeParent_SelectedIndexChanged
    End Sub
    '绑定担保机构名称
    Private Sub bindingOrgName()
        Dim dsOrg As DataSet = gWs.GetTOrganizationInfo("%")
        Me.cmbOrgName.DataSource = dsOrg.Tables(0)
        Me.cmbOrgName.DisplayMember = "Name"
        Me.cmbOrgName.ValueMember = "OrganNo"
    End Sub
    '绑定数据到显示企业信息的控件上
    Private Sub BindControls(ByVal corporationCode As String, ByVal serialNum As String)
        Dim dsRef As DataSet
        Dim dt As DataTable
        Dim strSql As String
        Dim i As Integer
        Dim isConsultTable As Boolean
        'strSql = "{corporation_code='" & corporationCode & "' and serial_num='" & serialNum & "'}"
        'dsRef = gWs.GetcorporationInfo("null", strSql)
        strSql = "{project_code='" & strProjectCode & "'}"
        dsRef = gWs.GetProjectInfo(strSql)
        i = dsRef.Tables("project").Rows.Count
        If Not i > 0 Then
            isConsultTable = True
            strSql = "select top 1 * from consultation where corporation_code='" & strCorporationCode & "' order by serial_num desc"
            dsRef = gWs.GetCommonQueryInfo(strSql)
        End If
        bindingReCommend()
        If dsRef Is Nothing Then Return
        If isConsultTable Then
            dt = dsRef.Tables("Table")
        Else
            dt = dsRef.Tables("project")
        End If
        If dt.Rows.Count <= 0 Then Return

        With dt.Rows(0)
            '推荐信息
            '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            '推荐机构
            If Not .Item("recommend_type") Is System.DBNull.Value Then
                str_RecommendMethod = .Item("recommend_type")
                Me.cmbRecommend.Text = str_RecommendMethod
            End If
            '推荐人
            If Not .Item("recommend_person") Is System.DBNull.Value Then
                str_RecommendType = .Item("recommend_person")
                SelectReommends(str_RecommendType)
            End If
        End With
    End Sub
    '
    Private Sub SelectReommends(ByVal rcon As String)
        Dim rows() As DataRow = RecommendTypeDS.Tables("TRecommendType").Select("recommend_type='" + str_RecommendMethod + "'")
        Dim selActor As String = "01"
        If rows.Length > 0 Then
            selActor = rows(0).Item("type_code")
        End If
        Me.cmbRecommend.SelectedValue = selActor
        Me.UpdateRecommends(selActor)
    End Sub

    Private Sub UpdateRecommends(ByVal rtype As String)
        isTxtRecommend = False 'qxd add 2003-7-18
        Select Case rtype
            Case "01" '自荐
                Me.txtRecommendPerson.Visible = False
                Me.cmbRecommendItems.Visible = False
                'QXD ADD 2003-10-15
                Me.txtRecommendPerson.Text = ""
                Me.cmbRecommendItems.DataSource = Nothing
                Me.cmbRecommendItems.Items.Clear()
                'END
                str_RecommendType = Nothing
            Case "02" '合作银行
                Me.txtRecommendPerson.Visible = False
                Me.cmbRecommendItems.Visible = True
                If dsBank Is Nothing Then
                    'dsBank = gWs.GetBankInfo("{bank_name like '%' order by bank_name}", "{branch_bank_name like '%' order by branch_bank_name}")
                    'qxd modify 2005-10-21 通过存储实现了按名称升序排序
                    dsBank = gWs.GetBankInfo("%", "%")
                End If
                Dim dsBankCopy As DataSet = dsBank.Copy() '使帮定的数据源与申请银行的数据源不在一起
                Me.cmbRecommendItems.DataSource = dsBankCopy.Tables("bank")
                Me.cmbRecommendItems.DisplayMember = "bank_name"
                Me.cmbRecommendItems.ValueMember = "bank_name"
            Case "03" '中心员工
                Me.txtRecommendPerson.Visible = False
                Me.cmbRecommendItems.Visible = True

                Me.cmbRecommendItems.DataSource = StaffDS.Tables("TStaff")
                Me.cmbRecommendItems.DisplayMember = "staff_name"
                Me.cmbRecommendItems.ValueMember = "staff_name"
            Case "04" '合作区局
                Me.txtRecommendPerson.Visible = False
                Me.cmbRecommendItems.Visible = True

                Me.cmbRecommendItems.DataSource = CooperatorInfoDS.Tables("cooperate_organization")
                Me.cmbRecommendItems.DisplayMember = "cooperate_organization"
                Me.cmbRecommendItems.ValueMember = "cooperate_organization"
            Case Else '其它，关联企业
                Me.txtRecommendPerson.Visible = True
                Me.cmbRecommendItems.Visible = False
                Me.txtRecommendPerson.Text = ""
                isTxtRecommend = True 'qxd add 2003-7-18
        End Select
    End Sub
    '
    '推荐单位或个人
    '
    Private Sub txtRecommendPerson_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        str_RecommendType = CType(sender, TextBox).Text
    End Sub

    Private Sub cbxRecommendItems_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim he As ComboBox = CType(sender, ComboBox)
        str_RecommendType = he.Text
    End Sub
    Private Sub cbxRecommendType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim he As ComboBox = CType(sender, ComboBox)
        UpdateRecommends(he.SelectedValue)
    End Sub

    '处理TextBox输入数字几特殊符号
    'isInputMinus: True ,允许输入“－”负号;False ,不允许输入“－”负号
    Private Sub MoneyKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs, ByVal isInputMinus As Boolean)
        If isInputMinus Then
            If e.KeyChar = "." Or e.KeyChar = "-" Then
                If CType(sender, TextBox).Text = "" Then
                    If e.KeyChar = "-" Then
                        e.Handled = (CType(sender, TextBox).Text.IndexOf("-") = 0)
                    Else
                        e.Handled = True
                    End If
                Else
                    If e.KeyChar = "-" Then
                        If CType(sender, TextBox).Text.StartsWith("-") Then
                            e.Handled = True
                        ElseIf CType(sender, TextBox).Text.IndexOf("-") >= 0 Then
                            e.Handled = True
                        Else
                            e.Handled = False
                        End If
                    Else
                        e.Handled = (CType(sender, TextBox).Text.IndexOf(".") >= 0)
                    End If
                End If
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
            End If
        Else
            If e.KeyChar = "." Then
                If sender.GetType.IsInstanceOfType(Me.nuTerm) Then
                    e.Handled = True
                    Return
                End If
                If CType(sender, TextBox).Text = "" Then
                    e.Handled = True
                Else
                    e.Handled = (CType(sender, TextBox).Text.IndexOf(".") >= 0)
                End If
            Else
                e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
            End If
        End If
    End Sub

    Private Sub txtVouchSum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVouchSum.KeyPress
        MoneyKeyPress(sender, e, False)
    End Sub
    '是否被修改了
    'TextBox,Combox等
    Private Sub setChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        isLoad = False
        isChanged = True
    End Sub
    '添加事件
    Private Sub addHandle()
        AddHandler cmbRecommend.SelectedValueChanged, AddressOf setChanged
        AddHandler cmbRecommendItems.SelectedValueChanged, AddressOf setChanged
        AddHandler txtRecommendPerson.TextChanged, AddressOf setChanged
        AddHandler txtVouchSum.TextChanged, AddressOf setChanged
        AddHandler nuTerm.TextChanged, AddressOf setChanged
        AddHandler cmbBankCode.SelectedValueChanged, AddressOf setChanged
        AddHandler cmbBranch.SelectedValueChanged, AddressOf setChanged
        AddHandler cmbServiceType.SelectedValueChanged, AddressOf setChanged
        AddHandler cmbOperateMode.SelectedValueChanged, AddressOf setChanged
        AddHandler chbFirstLoan.CheckStateChanged, AddressOf setChanged
        AddHandler chbAgainAccept.CheckStateChanged, AddressOf setChanged
    End Sub
    '设置期限的最大值，最小值
    Private Sub nuTerm_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles nuTerm.Leave
        Dim strTerm As String
        Dim dTerm As Double
        strTerm = Me.nuTerm.Text
        Try
            If Not strTerm = "" Then
                If IsNumeric(strTerm) Then
                    dTerm = CType(strTerm, Double)
                    If dTerm > 36 Then
                        Me.nuTerm.Text = "36"
                    ElseIf (dTerm < 0) Then
                        Me.nuTerm.Text = "0"
                    End If
                Else
                    Me.nuTerm.Text = "12"
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub nuTerm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles nuTerm.KeyPress
        MoneyKeyPress(sender, e, False)
    End Sub

    '保函项目一级归属地变化时触发
    Private Sub cbxAddressRangeParent_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.cbxAddressRange.DataSource = VouchService.GetCommonQueryInfo("select * from district where district_parent_name='" & cbxAddressRangeParent.SelectedValue & "' order by district_code").Tables(0)
        Me.cbxAddressRange.DisplayMember = "district_name"
        Me.cbxAddressRange.ValueMember = "district_name"
    End Sub

    Private Sub cbxCorAddressRangeParent_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.cbxCorAddressRange.DataSource = VouchService.GetCommonQueryInfo("select * from district where district_parent_name='" & cbxCorAddressRangeParent.SelectedValue & "' order by district_code").Tables(0)
        Me.cbxCorAddressRange.DisplayMember = "district_name"
        Me.cbxCorAddressRange.ValueMember = "district_name"
    End Sub


    '改变业务品种,同时更改运作方式
    Private Sub cmbServiceType_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim strService As String = Me.cmbServiceType.Text

        cmbOperateMode.Items.Clear()

        For Each dr As DataRow In dsWorkflow.Tables(0).Select("service_type_parent='" & strService & "'")
            cmbOperateMode.Items.Add(dr.Item("service_type"))
        Next

        cmbOperateMode.SelectedIndex = 0

        Select Case strService
            Case "保函"
                'Me.cmbOperateMode.Items.Clear()
                'Me.cmbOperateMode.Items.Add("额度项下保函")
                'Me.cmbOperateMode.Items.Add("单笔保函")
                'Me.cmbOperateMode.SelectedIndex = 0
                Me.cmbOrgName.Enabled = False
                Me.txtOrgOpinion.Enabled = False

                Me.PanelGuarantee.Visible = True
                cbxAddressRangeParent.Enabled = True
                cbxAddressRange.Enabled = True
                Dim dsProjectTemp As DataSet = gWs.GetProjectInfo("{project_code='" & Me.strProjectCode & "'}")
                If dsProjectTemp.Tables(0).Rows.Count > 0 Then
                    Me.cbxAddressRangeParent.SelectedValue = IIf(dsProjectTemp.Tables(0).Rows(0).Item("bh_project_district_parent_name") Is System.DBNull.Value, System.DBNull.Value, dsProjectTemp.Tables(0).Rows(0).Item("bh_project_district_parent_name"))
                    Me.cbxAddressRange.SelectedValue = IIf(dsProjectTemp.Tables(0).Rows(0).Item("bh_project_district_name") Is System.DBNull.Value, System.DBNull.Value, dsProjectTemp.Tables(0).Rows(0).Item("bh_project_district_name"))
                End If

                Me.cmbOrgName.SelectedIndex = -1
                Me.txtOrgOpinion.Text = ""
            Case "再担保"
                'Me.cmbOperateMode.Items.Clear()
                'Me.cmbOperateMode.Items.Add(strService)
                'Me.cmbOperateMode.SelectedIndex = 0
                cbxAddressRangeParent.Enabled = False
                cbxAddressRange.Enabled = False
                Me.cmbOrgName.Enabled = True
                Me.txtOrgOpinion.Enabled = True
                Me.PanelGuarantee.Visible = False
                Dim dsPO As DataSet = gWs.GetProjectOrganization("{project_code='" & Me.strProjectCode & "'}")
                If dsPO.Tables(0).Rows.Count > 0 Then
                    Me.txtOrgOpinion.Text = dsPO.Tables(0).Rows(0).Item("organizationopinion").ToString
                    Me.cmbOrgName.SelectedValue = IIf(dsPO.Tables(0).Rows(0).Item("organno") Is System.DBNull.Value, System.DBNull.Value, dsPO.Tables(0).Rows(0).Item("organno"))
                End If
            Case Else
                'Me.cmbOperateMode.Items.Clear()
                'Me.cmbOperateMode.Items.Add(strService)
                'Me.cmbOperateMode.SelectedIndex = 0
                cbxAddressRangeParent.Enabled = False
                cbxAddressRange.Enabled = False
                Me.cmbOrgName.Enabled = False
                Me.txtOrgOpinion.Enabled = False
                Me.PanelGuarantee.Visible = False
                Me.cmbOrgName.SelectedIndex = -1
                Me.txtOrgOpinion.Text = ""
        End Select

        If isLoad = False Then
            Try
                Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
                copyTemplate(Me.strProjectCode, cmbServiceType.Text.Trim)
            Catch
            Finally
                Me.Cursor = System.Windows.Forms.Cursors.Default
                setButton()
            End Try
        End If
        setButton()

    End Sub

    '判断是否满足做额度项下保函(保存,提交时都需判断)
    '输入参数isSave判断是保存时判断还是提交时判断,保存时传入true
    Private Function isAllowGuaranteeLetter(ByVal isSave As Boolean) As Boolean
        Dim ds As DataSet
        Dim dateApply As Date
        Dim count As Integer

        If Not Me.cmbOperateMode.Text.Trim = "额度项下保函" Then Return True '不是额度相下保函

        If isSave And isCommit Then Return True '提交时保存不需判断

        Try
            dateApply = gWs.GetSysTime().ToShortDateString
            ds = gWs.GetGuaranteeLetter(strCorporationCode, dateApply)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
            End If

            If count > 0 Then
                Dim dblRemnant As Double
                Dim strMessage As String

                If isSave Then
                    strMessage = "保存？"
                Else
                    strMessage = "受理？"
                End If

                If count > 1 Then 'add xie 6/14/2004  这一时期的项目可能有多次综合授信
                    For count = 0 To count - 1
                        dblRemnant += ds.Tables(0).Rows(count).Item("remnant_line")
                    Next
                Else
                    dblRemnant = ds.Tables(0).Rows(0).Item("remnant_line")
                End If
                'dblRemnant = ds.Tables(0).Rows(0).Item("remnant_line")
                If dblRemnant < Double.Parse(Me.txtVouchSum.Text) Then
                    'If DialogResult.No = SWDialogBox.MessageBox.Show("额度项下保函的申请金额已超过保函综合授信协议的剩余额度,是否" + strMessage, "系统提示", "", SWDialogBox.MessageBoxButton.YesNo, SWDialogBox.MessageBoxIcon.Question) Then
                    '    Me.txtVouchSum.Focus()
                    '    Return False
                    'End If

                    '2007-8-7 yjf edit 额度超出不可受理
                    MsgBox("额度项下保函的申请金额已超过保函综合授信协议的剩余额度!", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "提示")
                    Return False

                End If
                Return True
            Else
                MsgBox("当前企业未做保函综合授信业务或者当前受理日期不符合授信协议有效日期!", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "提示")
                Return False
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function


    '点击DataGrid中任意一行，则整行选中（高亮显示）
    Protected Overrides Sub dgMaterial_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMaterial.CurrentCellChanged
        Static lastRow As Integer = -1
        If Me.dgMaterial.CurrentRowIndex <> lastRow Then
            Me.dgMaterial.Select(Me.dgMaterial.CurrentCell.RowNumber)
        End If
        lastRow = Me.dgMaterial.CurrentRowIndex
        If Not Me.dsMaterial Is Nothing Then
            If Me.dsMaterial.Tables("TProjectDocument").Rows.Count > 1 Then
                Me.btnDelete.Enabled = Not Me.dsMaterial.Tables("TProjectDocument").Rows(Me.dgMaterial.CurrentRowIndex).Item("is_important")
            End If
        End If
    End Sub

    '判断是否存在一个同一业务品种已提交且未提交调研结论的项目
    Private Function isAnotherProject() As Boolean

        Dim dstemp As DataSet
        Dim dt As DataTable
        Dim strOnProjectList As String
        Dim isServiceNull As Boolean

        dstemp = gWs.GetCorporationAttendeePerson(Me.strProjectCode, Me.cmbServiceType.Text, "24", Me.strPerson)
        dt = dstemp.Tables(0)
        Dim i As Int16 = dt.Rows.Count
        If i = 1 Then '只有一行的时候
            If dt.Rows(0).Item("AttendeePerson").ToString = "0" Then
                Return False
            Else
                If dt.Rows(0).Item(1) Is System.DBNull.Value Then
                    isServiceNull = True
                    strOnProjectList = i.ToString & "。项目经理:" & dt.Rows(0).Item(0).ToString & ControlChars.CrLf
                Else '同一返回集的servicetype要么全为null,要么全部有值
                    isServiceNull = False
                    strOnProjectList = i.ToString & "。项目受理人员:" & dt.Rows(0).Item(0).ToString _
                    & ";现已受理业务品种:" & dt.Rows(0).Item(1).ToString & ControlChars.CrLf
                End If
            End If

        Else

            For i = 0 To i - 1
                If dt.Rows(i).Item(1) Is System.DBNull.Value Then
                    isServiceNull = True
                    strOnProjectList = strOnProjectList & (i + 1).ToString & "。项目经理:" & dt.Rows(i).Item(0).ToString & ControlChars.CrLf
                Else
                    isServiceNull = False
                    strOnProjectList = strOnProjectList & (i + 1).ToString & "。项目受理人员:" & dt.Rows(i).Item(0).ToString _
                    & ";现已受理业务品种:" & dt.Rows(i).Item(1).ToString & ControlChars.CrLf
                End If
            Next
        End If

        Dim strDetail As String
        Dim strMessage As String
        Dim strPerson As String = "以下为正在处理该公司项目的项目经理,如需受理,请用这些用户登录!" & ControlChars.CrLf
        Dim strPersonService As String = "以下为已受理的该公司项目的受理人员,如需受理,请用这些用户登录!(同一业务品种不能重复受理)" & ControlChars.CrLf

        If isServiceNull Then
            strMessage = "该企业项目已经受理,不能重复或跨地受理!" & ControlChars.CrLf & "请点击详细按钮了解详细情况."
            strDetail = strPerson & strOnProjectList
        Else
            strMessage = "该企业已受理同一业务品种项目,不能重复或跨区受理!" & ControlChars.CrLf & "请点击详细按钮了解详细情况."
            strDetail = strPersonService & strOnProjectList
        End If

        SWDialogBox.MessageBox.Show(strMessage, "系统提示", strDetail, SWDialogBox.MessageBoxButton.Detail, SWDialogBox.MessageBoxIcon.Information)
        Return True

    End Function

    Private Function isAllowTextCommit() As Boolean
        'start 几个不能提交的情况
        If Me.cmbServiceType.Text = "" Or Me.cmbServiceType.SelectedValue Is Nothing Then
            MsgBox("申请业务品种不能为空!", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "提示")
            cmbServiceType.Focus()
            Return False
        End If
        If Me.txtVouchSum.Text = "" Or Me.txtVouchSum.Text = "0" Or Me.txtVouchSum.Text = "0.00" Then
            MsgBox("申请金额不能为零或空!", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "提示")
            Me.txtVouchSum.Focus()
            Return False
        End If
        If Me.cmbOperateMode.Text = "" Then
            MsgBox("操作方式不能为空!", MsgBoxStyle.OKOnly + MsgBoxStyle.Information, "提示")
            Me.cmbOperateMode.Focus()
            Return False
        End If

        If cmbServiceType.Text = "再担保" Then
            If cmbOrgName.Text = "" Or cmbOrgName.SelectedValue = Nothing Then
                MsgBox("业务品种为再担保时担保机构名称不能为空!", MsgBoxStyle.OKOnly + MsgBoxStyle.Exclamation, "提示")
                cmbOrgName.Focus()
                Return False
            End If
        End If
        'end 几个不能提交的情况

        Return True
    End Function

    '判断起始和截止日期
    Private Function determineDate() As Boolean
        If dateGuarantStart.Value.Date > dateGuarantEnd.Value.Date Then
            'MsgBox("截止日期必须大于或等于起始日期", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1008", "起始日期", "截止日期")
            Return True
        End If
    End Function

    Private Sub dateGuarantEnd_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateGuarantEnd.ValueChanged
        Dim count As Integer
        Me.nuTerm.Text = getSubtractMonth(Me.dateGuarantStart.Value, Me.dateGuarantEnd.Value)
    End Sub

    Private Function getSubtractMonth(ByVal dateStart As Date, ByVal dateEnd As Date)
        Dim startYear, endYear, startMonth, endMonth As Integer

        startYear = dateStart.Year
        startMonth = dateStart.Month
        endYear = dateEnd.Year
        endMonth = dateEnd.Month
        Dim i, count As Integer
        count = endYear - startYear
        i = endMonth - startMonth

        Return count * 12 + i

    End Function


End Class
