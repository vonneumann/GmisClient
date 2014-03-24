Public Class FOrganization
    Inherits System.Windows.Forms.Form
    Implements IDataService

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        cboRelation.Items.AddRange(New String() {"中央", "省属", "市（地）属以下"})
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
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents tabTable As System.Windows.Forms.TabControl
    Friend WithEvents pagTable As System.Windows.Forms.TabPage
    Friend WithEvents txtOrganNo As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtName As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtZip As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtAddress As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtGuaranteeSum As SWSystem.Windows.Forms.NumericBox
    Friend WithEvents txtURL As SWSystem.Windows.Forms.TextBox
    Friend WithEvents cboRelation As SWSystem.Windows.Forms.ComboBox
    Friend WithEvents txtEMail As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtLegalman As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtLegalmanPhoneNumber As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtContact As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtContactPhoneNumber As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtRemark As SWSystem.Windows.Forms.TextBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents grdTable As System.Windows.Forms.DataGrid
    Friend WithEvents tsOrganization As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csOrganNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csAddress As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csZip As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csURL As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csEMail As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csLegalman As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csLegalmanPhoneNumber As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csContact As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csContactPhoneNumber As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csRemark As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csGuaranteeSum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csEstablishDate As DataGridDateTimeColumn
    Friend WithEvents csIsOwner As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents csIsReguarantee As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents txtOrganForm As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtEmployees As SWSystem.Windows.Forms.NumericBox
    Friend WithEvents txtOfficials As SWSystem.Windows.Forms.NumericBox
    Friend WithEvents txtUndergraduates As SWSystem.Windows.Forms.NumericBox
    Friend WithEvents txtAgent As SWSystem.Windows.Forms.TextBox
    Friend WithEvents lblEstablishDate As System.Windows.Forms.Label
    Friend WithEvents dtpEstablishDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents csIP As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtPhoneNumber As SWSystem.Windows.Forms.TextBox
    Friend WithEvents txtFax As SWSystem.Windows.Forms.TextBox
    Friend WithEvents chkIsOwner As System.Windows.Forms.CheckBox
    Friend WithEvents chkIsReguarantee As System.Windows.Forms.CheckBox
    Friend WithEvents txtIP As SWSystem.Windows.Forms.TextBox
    Friend WithEvents csPhoneNumber As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csFax As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csOrganForm As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csAgent As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csEmployees As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csOfficials As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csUndergraduates As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FOrganization))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tabTable = New System.Windows.Forms.TabControl()
        Me.pagTable = New System.Windows.Forms.TabPage()
        Me.txtIP = New SWSystem.Windows.Forms.TextBox()
        Me.chkIsReguarantee = New System.Windows.Forms.CheckBox()
        Me.chkIsOwner = New System.Windows.Forms.CheckBox()
        Me.txtFax = New SWSystem.Windows.Forms.TextBox()
        Me.txtPhoneNumber = New SWSystem.Windows.Forms.TextBox()
        Me.dtpEstablishDate = New System.Windows.Forms.DateTimePicker()
        Me.lblEstablishDate = New System.Windows.Forms.Label()
        Me.txtAgent = New SWSystem.Windows.Forms.TextBox()
        Me.txtUndergraduates = New SWSystem.Windows.Forms.NumericBox()
        Me.txtOfficials = New SWSystem.Windows.Forms.NumericBox()
        Me.txtEmployees = New SWSystem.Windows.Forms.NumericBox()
        Me.txtOrganForm = New SWSystem.Windows.Forms.TextBox()
        Me.txtRemark = New SWSystem.Windows.Forms.TextBox()
        Me.txtContactPhoneNumber = New SWSystem.Windows.Forms.TextBox()
        Me.txtContact = New SWSystem.Windows.Forms.TextBox()
        Me.txtLegalmanPhoneNumber = New SWSystem.Windows.Forms.TextBox()
        Me.txtLegalman = New SWSystem.Windows.Forms.TextBox()
        Me.txtEMail = New SWSystem.Windows.Forms.TextBox()
        Me.cboRelation = New SWSystem.Windows.Forms.ComboBox()
        Me.txtURL = New SWSystem.Windows.Forms.TextBox()
        Me.txtGuaranteeSum = New SWSystem.Windows.Forms.NumericBox()
        Me.txtAddress = New SWSystem.Windows.Forms.TextBox()
        Me.txtZip = New SWSystem.Windows.Forms.TextBox()
        Me.txtName = New SWSystem.Windows.Forms.TextBox()
        Me.txtOrganNo = New SWSystem.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.grdTable = New System.Windows.Forms.DataGrid()
        Me.tsOrganization = New System.Windows.Forms.DataGridTableStyle()
        Me.csOrganNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csGuaranteeSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csAddress = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csZip = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csPhoneNumber = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csFax = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csURL = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csEMail = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csOrganForm = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csAgent = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csEmployees = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csOfficials = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csUndergraduates = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csLegalman = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csLegalmanPhoneNumber = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csContact = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csContactPhoneNumber = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIsOwner = New System.Windows.Forms.DataGridBoolColumn()
        Me.csIsReguarantee = New System.Windows.Forms.DataGridBoolColumn()
        Me.csIP = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csRemark = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.tabTable.SuspendLayout()
        Me.pagTable.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTitle.Font = New System.Drawing.Font("方正姚体", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(166, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(340, 30)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "担保机构设置"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblTitle.Visible = False
        '
        'tabTable
        '
        Me.tabTable.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.tabTable.Controls.AddRange(New System.Windows.Forms.Control() {Me.pagTable, Me.TabPage1})
        Me.tabTable.Location = New System.Drawing.Point(8, 8)
        Me.tabTable.Name = "tabTable"
        Me.tabTable.SelectedIndex = 0
        Me.tabTable.Size = New System.Drawing.Size(656, 360)
        Me.tabTable.TabIndex = 2
        '
        'pagTable
        '
        Me.pagTable.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtIP, Me.chkIsReguarantee, Me.chkIsOwner, Me.txtFax, Me.txtPhoneNumber, Me.dtpEstablishDate, Me.lblEstablishDate, Me.txtAgent, Me.txtUndergraduates, Me.txtOfficials, Me.txtEmployees, Me.txtOrganForm, Me.txtRemark, Me.txtContactPhoneNumber, Me.txtContact, Me.txtLegalmanPhoneNumber, Me.txtLegalman, Me.txtEMail, Me.cboRelation, Me.txtURL, Me.txtGuaranteeSum, Me.txtAddress, Me.txtZip, Me.txtName, Me.txtOrganNo})
        Me.pagTable.Location = New System.Drawing.Point(4, 21)
        Me.pagTable.Name = "pagTable"
        Me.pagTable.Size = New System.Drawing.Size(648, 335)
        Me.pagTable.TabIndex = 0
        Me.pagTable.Text = "基础资料"
        '
        'txtIP
        '
        Me.txtIP.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtIP.DefaultValue = CType(resources.GetObject("txtIP.DefaultValue"), System.DBNull)
        Me.txtIP.LabelText = "ＩＰ地址"
        Me.txtIP.LabelWidth = 54
        Me.txtIP.Location = New System.Drawing.Point(192, 128)
        Me.txtIP.MaxLength = 50
        Me.txtIP.Name = "txtIP"
        Me.txtIP.Size = New System.Drawing.Size(448, 21)
        Me.txtIP.TabIndex = 14
        Me.txtIP.Value = ""
        '
        'chkIsReguarantee
        '
        Me.chkIsReguarantee.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.chkIsReguarantee.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIsReguarantee.Location = New System.Drawing.Point(440, 200)
        Me.chkIsReguarantee.Name = "chkIsReguarantee"
        Me.chkIsReguarantee.Size = New System.Drawing.Size(200, 24)
        Me.chkIsReguarantee.TabIndex = 24
        Me.chkIsReguarantee.Text = "是否再担保机构(&R)"
        Me.chkIsReguarantee.Visible = False
        '
        'chkIsOwner
        '
        Me.chkIsOwner.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.chkIsOwner.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkIsOwner.Location = New System.Drawing.Point(440, 176)
        Me.chkIsOwner.Name = "chkIsOwner"
        Me.chkIsOwner.Size = New System.Drawing.Size(200, 24)
        Me.chkIsOwner.TabIndex = 23
        Me.chkIsOwner.Text = "是否本机构(&O)"
        Me.chkIsOwner.Visible = False
        '
        'txtFax
        '
        Me.txtFax.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtFax.DefaultValue = CType(resources.GetObject("txtFax.DefaultValue"), System.DBNull)
        Me.txtFax.LabelText = "传真号码"
        Me.txtFax.LabelWidth = 54
        Me.txtFax.Location = New System.Drawing.Point(440, 152)
        Me.txtFax.MaxLength = 25
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(200, 21)
        Me.txtFax.TabIndex = 18
        Me.txtFax.Value = ""
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtPhoneNumber.DefaultValue = CType(resources.GetObject("txtPhoneNumber.DefaultValue"), System.DBNull)
        Me.txtPhoneNumber.LabelText = "电话号码"
        Me.txtPhoneNumber.LabelWidth = 54
        Me.txtPhoneNumber.Location = New System.Drawing.Point(192, 152)
        Me.txtPhoneNumber.MaxLength = 25
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(200, 21)
        Me.txtPhoneNumber.TabIndex = 17
        Me.txtPhoneNumber.Value = ""
        '
        'dtpEstablishDate
        '
        Me.dtpEstablishDate.Location = New System.Drawing.Point(62, 152)
        Me.dtpEstablishDate.Name = "dtpEstablishDate"
        Me.dtpEstablishDate.Size = New System.Drawing.Size(106, 21)
        Me.dtpEstablishDate.TabIndex = 16
        '
        'lblEstablishDate
        '
        Me.lblEstablishDate.Location = New System.Drawing.Point(8, 158)
        Me.lblEstablishDate.Name = "lblEstablishDate"
        Me.lblEstablishDate.Size = New System.Drawing.Size(56, 16)
        Me.lblEstablishDate.TabIndex = 15
        Me.lblEstablishDate.Text = "成立日期"
        '
        'txtAgent
        '
        Me.txtAgent.DefaultValue = CType(resources.GetObject("txtAgent.DefaultValue"), System.DBNull)
        Me.txtAgent.LabelText = "委托代理"
        Me.txtAgent.LabelWidth = 54
        Me.txtAgent.Location = New System.Drawing.Point(8, 128)
        Me.txtAgent.MaxLength = 10
        Me.txtAgent.Name = "txtAgent"
        Me.txtAgent.Size = New System.Drawing.Size(160, 21)
        Me.txtAgent.TabIndex = 13
        Me.txtAgent.Value = ""
        '
        'txtUndergraduates
        '
        Me.txtUndergraduates.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtUndergraduates.DataType = GetType(System.Int16)
        Me.txtUndergraduates.DefaultValue = CType(resources.GetObject("txtUndergraduates.DefaultValue"), System.DBNull)
        Me.txtUndergraduates.LabelText = "大学毕业人数"
        Me.txtUndergraduates.LabelWidth = 79
        Me.txtUndergraduates.Location = New System.Drawing.Point(504, 104)
        Me.txtUndergraduates.MaxLength = 5
        Me.txtUndergraduates.Name = "txtUndergraduates"
        Me.txtUndergraduates.Size = New System.Drawing.Size(136, 21)
        Me.txtUndergraduates.TabIndex = 12
        Me.txtUndergraduates.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtUndergraduates.Value = CType(resources.GetObject("txtUndergraduates.Value"), System.DBNull)
        '
        'txtOfficials
        '
        Me.txtOfficials.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtOfficials.DataType = GetType(System.Int16)
        Me.txtOfficials.DefaultValue = CType(resources.GetObject("txtOfficials.DefaultValue"), System.DBNull)
        Me.txtOfficials.LabelText = "机关在编人数"
        Me.txtOfficials.LabelWidth = 79
        Me.txtOfficials.Location = New System.Drawing.Point(352, 104)
        Me.txtOfficials.MaxLength = 5
        Me.txtOfficials.Name = "txtOfficials"
        Me.txtOfficials.Size = New System.Drawing.Size(136, 21)
        Me.txtOfficials.TabIndex = 11
        Me.txtOfficials.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtOfficials.Value = CType(resources.GetObject("txtOfficials.Value"), System.DBNull)
        '
        'txtEmployees
        '
        Me.txtEmployees.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtEmployees.DataType = GetType(System.Int16)
        Me.txtEmployees.DefaultValue = CType(resources.GetObject("txtEmployees.DefaultValue"), System.DBNull)
        Me.txtEmployees.LabelText = "员工人数"
        Me.txtEmployees.LabelWidth = 54
        Me.txtEmployees.Location = New System.Drawing.Point(192, 104)
        Me.txtEmployees.MaxLength = 5
        Me.txtEmployees.Name = "txtEmployees"
        Me.txtEmployees.Size = New System.Drawing.Size(136, 21)
        Me.txtEmployees.TabIndex = 10
        Me.txtEmployees.TextAlignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmployees.Value = CType(resources.GetObject("txtEmployees.Value"), System.DBNull)
        '
        'txtOrganForm
        '
        Me.txtOrganForm.DefaultValue = CType(resources.GetObject("txtOrganForm.DefaultValue"), System.DBNull)
        Me.txtOrganForm.LabelText = "组织形式"
        Me.txtOrganForm.LabelWidth = 54
        Me.txtOrganForm.Location = New System.Drawing.Point(8, 104)
        Me.txtOrganForm.MaxLength = 10
        Me.txtOrganForm.Name = "txtOrganForm"
        Me.txtOrganForm.Size = New System.Drawing.Size(160, 21)
        Me.txtOrganForm.TabIndex = 9
        Me.txtOrganForm.Value = ""
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtRemark.DefaultValue = CType(resources.GetObject("txtRemark.DefaultValue"), System.DBNull)
        Me.txtRemark.LabelSizeable = SWSystem.Windows.Forms.SizeableMode.ManualAdjust
        Me.txtRemark.LabelText = "备　　注"
        Me.txtRemark.LabelWidth = 54
        Me.txtRemark.Location = New System.Drawing.Point(8, 232)
        Me.txtRemark.MaxLength = 32767
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(632, 96)
        Me.txtRemark.TabIndex = 25
        Me.txtRemark.TextMultiline = True
        Me.txtRemark.TextScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemark.Value = ""
        '
        'txtContactPhoneNumber
        '
        Me.txtContactPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtContactPhoneNumber.DefaultValue = CType(resources.GetObject("txtContactPhoneNumber.DefaultValue"), System.DBNull)
        Me.txtContactPhoneNumber.LabelText = "联系电话"
        Me.txtContactPhoneNumber.LabelWidth = 54
        Me.txtContactPhoneNumber.Location = New System.Drawing.Point(192, 200)
        Me.txtContactPhoneNumber.MaxLength = 25
        Me.txtContactPhoneNumber.Name = "txtContactPhoneNumber"
        Me.txtContactPhoneNumber.Size = New System.Drawing.Size(200, 21)
        Me.txtContactPhoneNumber.TabIndex = 22
        Me.txtContactPhoneNumber.Value = ""
        '
        'txtContact
        '
        Me.txtContact.DefaultValue = CType(resources.GetObject("txtContact.DefaultValue"), System.DBNull)
        Me.txtContact.LabelText = "联系人名"
        Me.txtContact.LabelWidth = 54
        Me.txtContact.Location = New System.Drawing.Point(8, 200)
        Me.txtContact.MaxLength = 10
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(160, 21)
        Me.txtContact.TabIndex = 21
        Me.txtContact.Value = ""
        '
        'txtLegalmanPhoneNumber
        '
        Me.txtLegalmanPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtLegalmanPhoneNumber.DefaultValue = CType(resources.GetObject("txtLegalmanPhoneNumber.DefaultValue"), System.DBNull)
        Me.txtLegalmanPhoneNumber.LabelText = "法人电话"
        Me.txtLegalmanPhoneNumber.LabelWidth = 54
        Me.txtLegalmanPhoneNumber.Location = New System.Drawing.Point(192, 176)
        Me.txtLegalmanPhoneNumber.MaxLength = 25
        Me.txtLegalmanPhoneNumber.Name = "txtLegalmanPhoneNumber"
        Me.txtLegalmanPhoneNumber.Size = New System.Drawing.Size(200, 21)
        Me.txtLegalmanPhoneNumber.TabIndex = 20
        Me.txtLegalmanPhoneNumber.Value = ""
        '
        'txtLegalman
        '
        Me.txtLegalman.DefaultValue = CType(resources.GetObject("txtLegalman.DefaultValue"), System.DBNull)
        Me.txtLegalman.LabelText = "法人姓名"
        Me.txtLegalman.LabelWidth = 54
        Me.txtLegalman.Location = New System.Drawing.Point(8, 176)
        Me.txtLegalman.MaxLength = 10
        Me.txtLegalman.Name = "txtLegalman"
        Me.txtLegalman.Size = New System.Drawing.Size(160, 21)
        Me.txtLegalman.TabIndex = 19
        Me.txtLegalman.Value = ""
        '
        'txtEMail
        '
        Me.txtEMail.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtEMail.DefaultValue = CType(resources.GetObject("txtEMail.DefaultValue"), System.DBNull)
        Me.txtEMail.LabelText = "电子邮箱"
        Me.txtEMail.LabelWidth = 54
        Me.txtEMail.Location = New System.Drawing.Point(192, 80)
        Me.txtEMail.MaxLength = 50
        Me.txtEMail.Name = "txtEMail"
        Me.txtEMail.Size = New System.Drawing.Size(448, 21)
        Me.txtEMail.TabIndex = 8
        Me.txtEMail.Value = ""
        '
        'cboRelation
        '
        Me.cboRelation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRelation.ItemHeight = 12
        Me.cboRelation.LabelText = "隶属关系"
        Me.cboRelation.LabelWidth = 54
        Me.cboRelation.Location = New System.Drawing.Point(8, 80)
        Me.cboRelation.Name = "cboRelation"
        Me.cboRelation.Size = New System.Drawing.Size(160, 20)
        Me.cboRelation.TabIndex = 7
        '
        'txtURL
        '
        Me.txtURL.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtURL.DefaultValue = CType(resources.GetObject("txtURL.DefaultValue"), System.DBNull)
        Me.txtURL.LabelText = "机构网址"
        Me.txtURL.LabelWidth = 54
        Me.txtURL.Location = New System.Drawing.Point(192, 56)
        Me.txtURL.MaxLength = 50
        Me.txtURL.Name = "txtURL"
        Me.txtURL.Size = New System.Drawing.Size(448, 21)
        Me.txtURL.TabIndex = 6
        Me.txtURL.Value = ""
        '
        'txtGuaranteeSum
        '
        Me.txtGuaranteeSum.DefaultValue = CType(resources.GetObject("txtGuaranteeSum.DefaultValue"), System.DBNull)
        Me.txtGuaranteeSum.LabelText = "基金总额"
        Me.txtGuaranteeSum.LabelWidth = 54
        Me.txtGuaranteeSum.Location = New System.Drawing.Point(8, 56)
        Me.txtGuaranteeSum.MaxLength = 10
        Me.txtGuaranteeSum.Name = "txtGuaranteeSum"
        Me.txtGuaranteeSum.Size = New System.Drawing.Size(160, 21)
        Me.txtGuaranteeSum.TabIndex = 5
        Me.txtGuaranteeSum.Value = CType(resources.GetObject("txtGuaranteeSum.Value"), System.DBNull)
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtAddress.DefaultValue = CType(resources.GetObject("txtAddress.DefaultValue"), System.DBNull)
        Me.txtAddress.LabelText = "机构地址"
        Me.txtAddress.LabelWidth = 54
        Me.txtAddress.Location = New System.Drawing.Point(192, 32)
        Me.txtAddress.MaxLength = 100
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(448, 21)
        Me.txtAddress.TabIndex = 4
        Me.txtAddress.Value = ""
        '
        'txtZip
        '
        Me.txtZip.DefaultValue = CType(resources.GetObject("txtZip.DefaultValue"), System.DBNull)
        Me.txtZip.LabelText = "邮政编码"
        Me.txtZip.LabelWidth = 54
        Me.txtZip.Location = New System.Drawing.Point(8, 32)
        Me.txtZip.MaxLength = 10
        Me.txtZip.Name = "txtZip"
        Me.txtZip.Size = New System.Drawing.Size(160, 21)
        Me.txtZip.TabIndex = 3
        Me.txtZip.Value = ""
        '
        'txtName
        '
        Me.txtName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtName.DefaultValue = CType(resources.GetObject("txtName.DefaultValue"), System.DBNull)
        Me.txtName.LabelText = "机构名称"
        Me.txtName.LabelWidth = 54
        Me.txtName.Location = New System.Drawing.Point(192, 8)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(448, 21)
        Me.txtName.TabIndex = 2
        Me.txtName.Value = ""
        '
        'txtOrganNo
        '
        Me.txtOrganNo.DefaultValue = CType(resources.GetObject("txtOrganNo.DefaultValue"), System.DBNull)
        Me.txtOrganNo.LabelText = "机构编号"
        Me.txtOrganNo.LabelWidth = 54
        Me.txtOrganNo.Location = New System.Drawing.Point(8, 8)
        Me.txtOrganNo.MaxLength = 25
        Me.txtOrganNo.Name = "txtOrganNo"
        Me.txtOrganNo.Size = New System.Drawing.Size(160, 21)
        Me.txtOrganNo.TabIndex = 1
        Me.txtOrganNo.Value = ""
        '
        'TabPage1
        '
        Me.TabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.grdTable})
        Me.TabPage1.Location = New System.Drawing.Point(4, 21)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(648, 335)
        Me.TabPage1.TabIndex = 1
        Me.TabPage1.Text = "网格操作"
        '
        'grdTable
        '
        Me.grdTable.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grdTable.CaptionVisible = False
        Me.grdTable.DataMember = ""
        Me.grdTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTable.Location = New System.Drawing.Point(8, 8)
        Me.grdTable.Name = "grdTable"
        Me.grdTable.Size = New System.Drawing.Size(632, 320)
        Me.grdTable.TabIndex = 0
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsOrganization})
        '
        'tsOrganization
        '
        Me.tsOrganization.DataGrid = Me.grdTable
        Me.tsOrganization.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csOrganNo, Me.csName, Me.csGuaranteeSum, Me.csAddress, Me.csZip, Me.csPhoneNumber, Me.csFax, Me.csURL, Me.csEMail, Me.csOrganForm, Me.csAgent, Me.csEmployees, Me.csOfficials, Me.csUndergraduates, Me.csLegalman, Me.csLegalmanPhoneNumber, Me.csContact, Me.csContactPhoneNumber, Me.csIsOwner, Me.csIsReguarantee, Me.csIP, Me.csRemark})
        Me.tsOrganization.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsOrganization.MappingName = "TOrganization"
        '
        'csOrganNo
        '
        Me.csOrganNo.Format = ""
        Me.csOrganNo.FormatInfo = Nothing
        Me.csOrganNo.HeaderText = "机构编号"
        Me.csOrganNo.MappingName = "OrganNo"
        Me.csOrganNo.Width = 80
        '
        'csName
        '
        Me.csName.Format = ""
        Me.csName.FormatInfo = Nothing
        Me.csName.HeaderText = "名  称"
        Me.csName.MappingName = "Name"
        Me.csName.Width = 200
        '
        'csGuaranteeSum
        '
        Me.csGuaranteeSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csGuaranteeSum.Format = ""
        Me.csGuaranteeSum.FormatInfo = Nothing
        Me.csGuaranteeSum.HeaderText = "基金总额"
        Me.csGuaranteeSum.MappingName = "GuaranteeSum"
        Me.csGuaranteeSum.Width = 90
        '
        'csAddress
        '
        Me.csAddress.Format = ""
        Me.csAddress.FormatInfo = Nothing
        Me.csAddress.HeaderText = "机构地址"
        Me.csAddress.MappingName = "Address"
        Me.csAddress.Width = 200
        '
        'csZip
        '
        Me.csZip.Format = ""
        Me.csZip.FormatInfo = Nothing
        Me.csZip.HeaderText = "邮编"
        Me.csZip.MappingName = "Zip"
        Me.csZip.Width = 60
        '
        'csPhoneNumber
        '
        Me.csPhoneNumber.Format = ""
        Me.csPhoneNumber.FormatInfo = Nothing
        Me.csPhoneNumber.HeaderText = "电话号码"
        Me.csPhoneNumber.MappingName = "PhoneNumber"
        Me.csPhoneNumber.Width = 90
        '
        'csFax
        '
        Me.csFax.Format = ""
        Me.csFax.FormatInfo = Nothing
        Me.csFax.HeaderText = "传真号码"
        Me.csFax.MappingName = "Fax"
        Me.csFax.Width = 90
        '
        'csURL
        '
        Me.csURL.Format = ""
        Me.csURL.FormatInfo = Nothing
        Me.csURL.HeaderText = "网  址"
        Me.csURL.MappingName = "URL"
        Me.csURL.Width = 200
        '
        'csEMail
        '
        Me.csEMail.Format = ""
        Me.csEMail.FormatInfo = Nothing
        Me.csEMail.HeaderText = "电子邮箱"
        Me.csEMail.MappingName = "EMail"
        Me.csEMail.Width = 200
        '
        'csOrganForm
        '
        Me.csOrganForm.Format = ""
        Me.csOrganForm.FormatInfo = Nothing
        Me.csOrganForm.HeaderText = "组织形式"
        Me.csOrganForm.MappingName = "OrganForm"
        Me.csOrganForm.Width = 80
        '
        'csAgent
        '
        Me.csAgent.Format = ""
        Me.csAgent.FormatInfo = Nothing
        Me.csAgent.HeaderText = "委托代理人"
        Me.csAgent.MappingName = "Agent"
        Me.csAgent.Width = 80
        '
        'csEmployees
        '
        Me.csEmployees.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csEmployees.Format = ""
        Me.csEmployees.FormatInfo = Nothing
        Me.csEmployees.HeaderText = "员工人数"
        Me.csEmployees.MappingName = "Employees"
        Me.csEmployees.Width = 80
        '
        'csOfficials
        '
        Me.csOfficials.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csOfficials.Format = ""
        Me.csOfficials.FormatInfo = Nothing
        Me.csOfficials.HeaderText = "正式机关在编人数"
        Me.csOfficials.MappingName = "Officials"
        Me.csOfficials.Width = 120
        '
        'csUndergraduates
        '
        Me.csUndergraduates.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csUndergraduates.Format = ""
        Me.csUndergraduates.FormatInfo = Nothing
        Me.csUndergraduates.HeaderText = "大学毕业人数"
        Me.csUndergraduates.MappingName = "Undergraduates"
        Me.csUndergraduates.Width = 80
        '
        'csLegalman
        '
        Me.csLegalman.Format = ""
        Me.csLegalman.FormatInfo = Nothing
        Me.csLegalman.HeaderText = "法  人"
        Me.csLegalman.MappingName = "Legalman"
        Me.csLegalman.Width = 80
        '
        'csLegalmanPhoneNumber
        '
        Me.csLegalmanPhoneNumber.Format = ""
        Me.csLegalmanPhoneNumber.FormatInfo = Nothing
        Me.csLegalmanPhoneNumber.HeaderText = "法人电话"
        Me.csLegalmanPhoneNumber.MappingName = "LegalmanPhoneNumber"
        Me.csLegalmanPhoneNumber.Width = 110
        '
        'csContact
        '
        Me.csContact.Format = ""
        Me.csContact.FormatInfo = Nothing
        Me.csContact.HeaderText = "联系人"
        Me.csContact.MappingName = "Contact"
        Me.csContact.Width = 80
        '
        'csContactPhoneNumber
        '
        Me.csContactPhoneNumber.Format = ""
        Me.csContactPhoneNumber.FormatInfo = Nothing
        Me.csContactPhoneNumber.HeaderText = "联系人电话"
        Me.csContactPhoneNumber.MappingName = "ContactPhoneNumber"
        Me.csContactPhoneNumber.Width = 110
        '
        'csIsOwner
        '
        Me.csIsOwner.FalseValue = False
        Me.csIsOwner.HeaderText = "是否本机构"
        Me.csIsOwner.MappingName = "IsOwner"
        Me.csIsOwner.NullValue = CType(resources.GetObject("csIsOwner.NullValue"), System.DBNull)
        Me.csIsOwner.TrueValue = True
        Me.csIsOwner.Width = 80
        '
        'csIsReguarantee
        '
        Me.csIsReguarantee.FalseValue = False
        Me.csIsReguarantee.HeaderText = "再担保机构"
        Me.csIsReguarantee.MappingName = "IsReguarantee"
        Me.csIsReguarantee.NullValue = CType(resources.GetObject("csIsReguarantee.NullValue"), System.DBNull)
        Me.csIsReguarantee.TrueValue = True
        Me.csIsReguarantee.Width = 80
        '
        'csIP
        '
        Me.csIP.Format = ""
        Me.csIP.FormatInfo = Nothing
        Me.csIP.HeaderText = "机构IP地址"
        Me.csIP.MappingName = "IP"
        Me.csIP.Width = 150
        '
        'csRemark
        '
        Me.csRemark.Format = ""
        Me.csRemark.FormatInfo = Nothing
        Me.csRemark.HeaderText = "备  注"
        Me.csRemark.MappingName = "Remark"
        Me.csRemark.Width = 200
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 4
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(472, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 105
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.ImageIndex = 3
        Me.btnUpdate.ImageList = Me.ImageList1
        Me.btnUpdate.Location = New System.Drawing.Point(384, 376)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(77, 23)
        Me.btnUpdate.TabIndex = 104
        Me.btnUpdate.Text = "保 存(&S)"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 2
        Me.btnDelete.ImageList = Me.ImageList1
        Me.btnDelete.Location = New System.Drawing.Point(296, 376)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 103
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.ImageIndex = 0
        Me.btnRefresh.ImageList = Me.ImageList1
        Me.btnRefresh.Location = New System.Drawing.Point(120, 376)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(77, 23)
        Me.btnRefresh.TabIndex = 101
        Me.btnRefresh.Text = "刷 新(&R)"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnInsert
        '
        Me.btnInsert.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnInsert.Image = CType(resources.GetObject("btnInsert.Image"), System.Drawing.Bitmap)
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.ImageIndex = 1
        Me.btnInsert.ImageList = Me.ImageList1
        Me.btnInsert.Location = New System.Drawing.Point(208, 376)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(77, 23)
        Me.btnInsert.TabIndex = 102
        Me.btnInsert.Text = "新 增(&A)"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FOrganization
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(672, 405)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnInsert, Me.btnExit, Me.btnUpdate, Me.btnDelete, Me.btnRefresh, Me.tabTable, Me.lblTitle})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(640, 400)
        Me.Name = "FOrganization"
        Me.Text = "机构设置"
        Me.tabTable.ResumeLayout(False)
        Me.pagTable.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _organDST As DataSet

    Private Sub Rebinding()
        txtOrganNo.DataBindings.Add("Value", _organDST, "TOrganization.OrganNo")
        txtName.DataBindings.Add("Value", _organDST, "TOrganization.Name")
        txtZip.DataBindings.Add("Value", _organDST, "TOrganization.Zip")
        txtURL.DataBindings.Add("Value", _organDST, "TOrganization.URL")
        txtEMail.DataBindings.Add("Value", _organDST, "TOrganization.EMail")
        txtAddress.DataBindings.Add("Value", _organDST, "TOrganization.Address")
        txtGuaranteeSum.DataBindings.Add("Value", _organDST, "TOrganization.GuaranteeSum")
        txtLegalman.DataBindings.Add("Value", _organDST, "TOrganization.Legalman")
        txtLegalmanPhoneNumber.DataBindings.Add("Value", _organDST, "TOrganization.LegalmanPhoneNumber")
        txtContact.DataBindings.Add("Value", _organDST, "TOrganization.Contact")
        txtContactPhoneNumber.DataBindings.Add("Value", _organDST, "TOrganization.ContactPhoneNumber")
        txtRemark.DataBindings.Add("Value", _organDST, "TOrganization.Remark")

        txtOrganForm.DataBindings.Add("Value", _organDST, "TOrganization.OrganForm")
        txtAgent.DataBindings.Add("Value", _organDST, "TOrganization.Agent")
        txtPhoneNumber.DataBindings.Add("Value", _organDST, "TOrganization.PhoneNumber")
        txtFax.DataBindings.Add("Value", _organDST, "TOrganization.Fax")
        txtIP.DataBindings.Add("Value", _organDST, "TOrganization.IP")
        txtEmployees.DataBindings.Add("Value", _organDST, "TOrganization.Employees")
        txtOfficials.DataBindings.Add("Value", _organDST, "TOrganization.Officials")
        txtUndergraduates.DataBindings.Add("Value", _organDST, "TOrganization.Undergraduates")

        '成立日期
        Dim dateBinding As Binding = New Binding("Value", _organDST, "TOrganization.EstablishDate")
        AddHandler dateBinding.Parse, New ConvertEventHandler(AddressOf DateTime_Parse)
        AddHandler dateBinding.Format, New ConvertEventHandler(AddressOf DateTime_Format)
        dtpEstablishDate.DataBindings.Add(dateBinding)

        Dim checkState As Binding

        checkState = New Binding("CheckState", _organDST, "TOrganization.IsOwner")
        AddHandler checkState.Parse, New ConvertEventHandler(AddressOf CheckState_Parse)
        AddHandler checkState.Format, New ConvertEventHandler(AddressOf CheckState_Format)
        chkIsOwner.DataBindings.Add(checkState)
        checkState = Nothing

        checkState = New Binding("CheckState", _organDST, "TOrganization.IsReguarantee")
        AddHandler checkState.Parse, New ConvertEventHandler(AddressOf CheckState_Parse)
        AddHandler checkState.Format, New ConvertEventHandler(AddressOf CheckState_Format)
        chkIsReguarantee.DataBindings.Add(checkState)
        checkState = Nothing

        Dim relationBinding As Binding = New Binding("SelectedIndex", _organDST, "TOrganization.Relation")
        AddHandler relationBinding.Parse, New ConvertEventHandler(AddressOf Relation_Parse)
        AddHandler relationBinding.Format, New ConvertEventHandler(AddressOf Relation_Format)
        cboRelation.DataBindings.Add(relationBinding)

        grdTable.DataSource = _organDST
        grdTable.DataMember = "TOrganization"

        'AddHandler _organDST.Tables("TOrganization").ColumnChanging, AddressOf Table_ColumnChanging
        'AddHandler _organDST.Tables("TOrganization").ColumnChanged, AddressOf Table_ColumnChanged
    End Sub

    Public Sub Clear() Implements IDataService.Clear
        txtOrganNo.DataBindings.Clear()
        txtName.DataBindings.Clear()
        txtURL.DataBindings.Clear()
        txtEMail.DataBindings.Clear()
        txtZip.DataBindings.Clear()
        txtGuaranteeSum.DataBindings.Clear()
        txtAddress.DataBindings.Clear()
        txtLegalman.DataBindings.Clear()
        txtLegalmanPhoneNumber.DataBindings.Clear()
        txtContact.DataBindings.Clear()
        txtContactPhoneNumber.DataBindings.Clear()
        txtRemark.DataBindings.Clear()
        cboRelation.DataBindings.Clear()

        txtOrganForm.DataBindings.Clear()
        txtAgent.DataBindings.Clear()
        txtPhoneNumber.DataBindings.Clear()
        txtFax.DataBindings.Clear()
        txtIP.DataBindings.Clear()
        txtEmployees.DataBindings.Clear()
        txtOfficials.DataBindings.Clear()
        txtUndergraduates.DataBindings.Clear()

        dtpEstablishDate.DataBindings.Clear()
        chkIsOwner.DataBindings.Clear()
        chkIsReguarantee.DataBindings.Clear()

        grdTable.DataSource = Nothing
    End Sub

    Public Sub Delete(ByVal args As Object()) Implements IDataService.Delete
        Dim cm As CurrencyManager

        If _organDST Is Nothing Then
            Return
        End If

        Try
            cm = Me.BindingContext(_organDST, "TOrganization")

            If cm.Position < 0 Then
                Return
            End If

            Dim rv As DataRowView = CType(cm.Current, DataRowView)

            If Not rv Is Nothing Then
                rv.Delete()
            End If

            rv = Nothing
        Finally
            cm = Nothing
        End Try
    End Sub

    Public Sub Insert(ByVal args As Object()) Implements IDataService.Insert
        If _organDST Is Nothing Then
            Return
        End If

        If _organDST Is Nothing Then
            _organDST = gWs.GetTOrganizationInfo("")
            Me.Clear()
            Me.Rebinding()
        End If

        Dim row As DataRow = _organDST.Tables("TOrganization").NewRow()
        _organDST.Tables("TOrganization").Rows.Add(row)
        Dim bm As BindingManagerBase = Me.BindingContext(_organDST, "TOrganization")
        bm.Position = bm.Count - 1
    End Sub

    Public Overloads Function Update(ByVal args As Object()) As Boolean Implements IDataService.Update
        If _organDST Is Nothing Then
            Return False
        End If

        Try
            Me.Cursor = Cursors.WaitCursor

            Me.BindingContext(_organDST, "TOrganization").EndCurrentEdit()

            Dim row As DataRow
            Dim isOwner As Boolean = False
            Dim isReguarantee As Boolean = False
            For Each row In _organDST.Tables("TOrganization").Rows
                If row.RowState <> DataRowState.Deleted Then
                    If isOwner AndAlso (Not Convert.IsDBNull(row("IsOwner"))) AndAlso row("IsOwner") Then
                        MessageBox.Show("『是否本机构』被重复指定，请重新指定一个唯一的值。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return False
                    End If
                    If isReguarantee AndAlso (Not Convert.IsDBNull(row("IsReguarantee"))) AndAlso row("IsReguarantee") Then
                        MessageBox.Show("『是否再担保机构』被重复指定，请重新指定一个唯一的值。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return False
                    End If

                    If Not row.IsNull("IsOwner") Then
                        isOwner = row("IsOwner")
                    End If
                    If Not row.IsNull("IsReguarantee") Then
                        isReguarantee = row("IsReguarantee")
                    End If
                End If
            Next

            Dim result As String = gWs.UpdateTOrganization(_organDST.GetChanges())
            If result = "1" Then
                _organDST.AcceptChanges()
                SWDialogBox.MessageBox.Show("$SaveSucceed")
                Return True
            Else
                '显示服务器的返回错误信息
                SWDialogBox.MessageBox.Show("*999", Me.Name + ".Update", result, "")
                Return False
            End If
        Catch ex As System.Web.Services.Protocols.SoapException
            Dim exceptionHandler As ExceptionHandler = New ExceptionHandler()
            exceptionHandler.ShowMessageBoxEx(ex)
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Public Overloads Sub Refresh(ByVal args As Object()) Implements IDataService.Refresh
        MyBase.Refresh()

        Try
            Me.Cursor = Cursors.WaitCursor

            Me.Clear()

            Dim parameter As Object = DBNull.Value
            If (Not args Is Nothing) AndAlso args.Length > 0 Then
                parameter = args(0)
            End If

            _organDST = gWs.GetTOrganizationInfo(parameter)

            Me.Rebinding()

            'Dim cm As CurrencyManager = Me.BindingContext(_organDST, "TOrganization")
            'cm.Refresh()
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Me.Delete(Nothing)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.Refresh(New String() {"%"})
    End Sub

    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Me.Insert(Nothing)
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Me.Update(Nothing)
    End Sub

    Private Sub FOrganization_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.F5 Then
            btnRefresh.PerformClick()
        End If
    End Sub

    Private Sub txtOrganNo_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOrganNo.Validated
        'Dim originalValue As Object
        'Dim currentValue As Object

        'If _organDST Is Nothing Then
        '    currentValue = txtOrganNo.Value
        'Else
        '    Dim cm As CurrencyManager = Me.BindingContext(_organDST, "TOrganization")
        '    If cm.Position < 0 Then
        '        currentValue = txtOrganNo.Value
        '    Else
        '        Dim rv As DataRowView = CType(cm.Current, DataRowView)

        '        If (Not rv Is Nothing) AndAlso (rv.Row.RowState <> DataRowState.Added) Then
        '            If rv.Row.HasVersion(DataRowVersion.Original) Then
        '                originalValue = rv.Row.Item("OrganNo", DataRowVersion.Original)
        '            End If

        '            currentValue = txtOrganNo.Value
        '        End If
        '    End If
        'End If

        'If originalValue <> currentValue Then
        '    Me.Refresh(New Object() {txtOrganNo.Value})
        'End If
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

    Private Sub CheckState_Parse(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If Not e.DesiredType Is GetType(Boolean) Then
            Return
        End If

        Dim state As System.Windows.Forms.CheckState = CType(e.Value, System.Windows.Forms.CheckState)

        Select Case state
            Case CheckState.Indeterminate
                e.Value = DBNull.Value
            Case CheckState.Checked
                e.Value = True
            Case CheckState.Unchecked
                e.Value = False
        End Select
    End Sub

    Private Sub CheckState_Format(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If Not e.DesiredType Is GetType(System.Windows.Forms.CheckState) Then
            Return
        End If

        If IsDBNull(e.Value) Then
            e.Value = System.Windows.Forms.CheckState.Indeterminate
        Else
            e.Value = IIf(e.Value, CheckState.Checked, CheckState.Unchecked)
        End If
    End Sub

    Private Sub Relation_Parse(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If (Not e.DesiredType Is GetType(Int32)) AndAlso (Not e.DesiredType Is GetType(Int64)) AndAlso (Not e.DesiredType Is GetType(Int16)) AndAlso (Not e.DesiredType Is GetType(Byte)) Then
            Return
        End If

        If e.Value < 0 Or e.Value >= cboRelation.Items.Count Then
            e.Value = DBNull.Value
        End If
    End Sub

    Private Sub Relation_Format(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If (Not e.DesiredType Is GetType(Int32)) AndAlso (Not e.DesiredType Is GetType(Int64)) AndAlso (Not e.DesiredType Is GetType(Int16)) AndAlso (Not e.DesiredType Is GetType(Byte)) Then
            Return
        End If

        If IsDBNull(e.Value) Then
            e.Value = -1
        Else
            If e.Value < 0 OrElse e.Value >= cboRelation.Items.Count Then
                e.Value = -1
            End If
        End If
    End Sub

    Private Sub FOrganization_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtRemark.Height = pagTable.Height - txtRemark.Top - 8

        btnRefresh.PerformClick()
    End Sub

    Private Sub Table_ColumnChanged(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs)
        'If e.Column.ColumnName = "IsOwner" Then
        '    Dim row As DataRow

        '    For Each row In _organDST.Tables("TOrganization").Rows
        '        If row("OrganNo").ToString() <> e.Row("OrganNo").ToString() Then
        '            row.BeginEdit()
        '            row("IsOwner") = False
        '        End If
        '    Next

        '    'For Each row In _organDST.Tables("TOrganization").Rows
        '    '    row.EndEdit()
        '    'Next
        'End If
    End Sub

    Private Sub Table_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs)
        'If e.Column.ColumnName = "IsOwner" Then
        '    'If Not e.ProposedValue Then
        '    '    e.ProposedValue = e.Row(e.Column)
        '    '    Return
        '    'End If

        '    Dim row As DataRow

        '    For Each row In _organDST.Tables("TOrganization").Rows
        '        If Not row Is e.Row Then
        '            'row.BeginEdit()
        '            row("IsOwner") = False
        '        End If
        '    Next

        '    'For Each row In _organDST.Tables("TOrganization").Rows
        '    '    row.EndEdit()
        '    'Next
        'End If
    End Sub

    'Private Sub chkIsOwner_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkIsOwner.CheckedChanged
    '    If _organDST Is Nothing Then
    '        Return
    '    End If

    '    'If Not chkIsOwner.Checked Then
    '    '    chkIsOwner.Checked = True
    '    '    Return
    '    'End If

    '    Dim cm As CurrencyManager = Me.BindingContext(_organDST, "TOrganization")
    '    Dim rv As DataRowView = cm.Current

    '    Dim row As DataRow
    '    For Each row In _organDST.Tables("TOrganization").Rows
    '        row.BeginEdit()
    '        If row("OrganNo").ToString() <> rv.Row("OrganNo").ToString() Then
    '            row("IsOwner") = False
    '        End If
    '    Next

    '    'For Each row In _organDST.Tables("TOrganization").Rows
    '    '    row.EndEdit()
    '    'Next

    '    cm.Refresh()
    'End Sub

    Private Sub FOrganization_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If _organDST Is Nothing Then
            Return
        End If

        Me.BindingContext(_organDST, "TOrganization").EndCurrentEdit()

        If Not _organDST.HasChanges() Then
            Return
        End If

        '资料已经被改动过，您要保存吗？
        Dim result As DialogResult = SWDialogBox.MessageBox.Show("?1003")

        If result = DialogResult.Yes Then
            If Not Me.Update(Nothing) Then
                e.Cancel = True
            End If
        Else
            If result = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class
