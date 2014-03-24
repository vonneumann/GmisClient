Public Class FViewAffirmContent
    Inherits Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    Public Sub New(ByVal project_code As String, ByVal corporation_name As String)
        Me.New()

        strProjectCode = project_code
        strCorporatioName = corporation_name
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pgDoc As System.Windows.Forms.TabPage
    Friend WithEvents pgFee As System.Windows.Forms.TabPage
    Friend WithEvents pgOppositeGuarantee As System.Windows.Forms.TabPage
    Friend WithEvents grdDoc As System.Windows.Forms.DataGrid
    Friend WithEvents grdFee As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents pgCooperateOrganization As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents grdCooperateOrganization As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle4 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn23 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn24 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn25 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents grdGuaranteeForm As System.Windows.Forms.DataGrid
    Friend WithEvents grdGuaranteeFormAdditional As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FViewAffirmContent))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.pgDoc = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grdDoc = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.pgFee = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.grdFee = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.pgOppositeGuarantee = New System.Windows.Forms.TabPage()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.grdGuaranteeFormAdditional = New System.Windows.Forms.DataGrid()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.grdGuaranteeForm = New System.Windows.Forms.DataGrid()
        Me.pgCooperateOrganization = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.grdCooperateOrganization = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle4 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn23 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn24 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn25 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.pgDoc.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdDoc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgFee.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.grdFee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgOppositeGuarantee.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.grdGuaranteeFormAdditional, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdGuaranteeForm, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgCooperateOrganization.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.grdCooperateOrganization, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.pgDoc, Me.pgFee, Me.pgOppositeGuarantee, Me.pgCooperateOrganization})
        Me.TabControl1.Location = New System.Drawing.Point(8, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(676, 368)
        Me.TabControl1.TabIndex = 1
        '
        'pgDoc
        '
        Me.pgDoc.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1})
        Me.pgDoc.Location = New System.Drawing.Point(4, 21)
        Me.pgDoc.Name = "pgDoc"
        Me.pgDoc.Size = New System.Drawing.Size(668, 343)
        Me.pgDoc.TabIndex = 0
        Me.pgDoc.Text = "材料"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.grdDoc})
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(668, 343)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'grdDoc
        '
        Me.grdDoc.CaptionVisible = False
        Me.grdDoc.DataMember = ""
        Me.grdDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdDoc.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdDoc.Location = New System.Drawing.Point(3, 17)
        Me.grdDoc.Name = "grdDoc"
        Me.grdDoc.ReadOnly = True
        Me.grdDoc.Size = New System.Drawing.Size(662, 323)
        Me.grdDoc.TabIndex = 1
        Me.grdDoc.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdDoc
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridBoolColumn1})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TProjectDocument"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "材料名称"
        Me.DataGridTextBoxColumn1.MappingName = "doc_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 418
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "查验人"
        Me.DataGridTextBoxColumn2.MappingName = "check_person"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 60
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "查验日期"
        Me.DataGridTextBoxColumn3.MappingName = "check_date"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 80
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "是否关键"
        Me.DataGridBoolColumn1.MappingName = "is_important"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), System.DBNull)
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 60
        '
        'pgFee
        '
        Me.pgFee.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2})
        Me.pgFee.Location = New System.Drawing.Point(4, 21)
        Me.pgFee.Name = "pgFee"
        Me.pgFee.Size = New System.Drawing.Size(668, 343)
        Me.pgFee.TabIndex = 1
        Me.pgFee.Text = "费用"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.grdFee})
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(668, 343)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        '
        'grdFee
        '
        Me.grdFee.CaptionVisible = False
        Me.grdFee.DataMember = ""
        Me.grdFee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdFee.Location = New System.Drawing.Point(3, 17)
        Me.grdFee.Name = "grdFee"
        Me.grdFee.ReadOnly = True
        Me.grdFee.Size = New System.Drawing.Size(662, 323)
        Me.grdFee.TabIndex = 1
        Me.grdFee.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.grdFee
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "project_account_detail"
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn4.MappingName = "project_code"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 68
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = "yyyy年MM月dd日"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "收费日期"
        Me.DataGridTextBoxColumn5.MappingName = "date"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 78
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "收费名目"
        Me.DataGridTextBoxColumn6.MappingName = "item_name"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn7.Format = "c"
        Me.DataGridTextBoxColumn7.FormatInfo = CType(resources.GetObject("DataGridTextBoxColumn7.FormatInfo"), System.Globalization.NumberFormatInfo)
        Me.DataGridTextBoxColumn7.HeaderText = "收费金额(元)"
        Me.DataGridTextBoxColumn7.MappingName = "income"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 110
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "备注"
        Me.DataGridTextBoxColumn8.MappingName = "remark"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 250
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "创建人"
        Me.DataGridTextBoxColumn9.MappingName = "create_person"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 250
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = "yyyy年MM月dd日"
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "创建时间"
        Me.DataGridTextBoxColumn10.MappingName = "create_date"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 78
        '
        'pgOppositeGuarantee
        '
        Me.pgOppositeGuarantee.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3})
        Me.pgOppositeGuarantee.Location = New System.Drawing.Point(4, 21)
        Me.pgOppositeGuarantee.Name = "pgOppositeGuarantee"
        Me.pgOppositeGuarantee.Size = New System.Drawing.Size(668, 343)
        Me.pgOppositeGuarantee.TabIndex = 2
        Me.pgOppositeGuarantee.Text = "反担保物"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.grdGuaranteeFormAdditional, Me.Splitter1, Me.grdGuaranteeForm})
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(668, 343)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        '
        'grdGuaranteeFormAdditional
        '
        Me.grdGuaranteeFormAdditional.CaptionVisible = False
        Me.grdGuaranteeFormAdditional.DataMember = ""
        Me.grdGuaranteeFormAdditional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdGuaranteeFormAdditional.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdGuaranteeFormAdditional.Location = New System.Drawing.Point(3, 184)
        Me.grdGuaranteeFormAdditional.Name = "grdGuaranteeFormAdditional"
        Me.grdGuaranteeFormAdditional.ReadOnly = True
        Me.grdGuaranteeFormAdditional.Size = New System.Drawing.Size(662, 156)
        Me.grdGuaranteeFormAdditional.TabIndex = 2
        '
        'Splitter1
        '
        Me.Splitter1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Splitter1.Location = New System.Drawing.Point(3, 176)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(662, 8)
        Me.Splitter1.TabIndex = 3
        Me.Splitter1.TabStop = False
        '
        'grdGuaranteeForm
        '
        Me.grdGuaranteeForm.CaptionVisible = False
        Me.grdGuaranteeForm.DataMember = ""
        Me.grdGuaranteeForm.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdGuaranteeForm.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdGuaranteeForm.Location = New System.Drawing.Point(3, 17)
        Me.grdGuaranteeForm.Name = "grdGuaranteeForm"
        Me.grdGuaranteeForm.ReadOnly = True
        Me.grdGuaranteeForm.Size = New System.Drawing.Size(662, 159)
        Me.grdGuaranteeForm.TabIndex = 1
        '
        'pgCooperateOrganization
        '
        Me.pgCooperateOrganization.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox4})
        Me.pgCooperateOrganization.Location = New System.Drawing.Point(4, 21)
        Me.pgCooperateOrganization.Name = "pgCooperateOrganization"
        Me.pgCooperateOrganization.Size = New System.Drawing.Size(668, 343)
        Me.pgCooperateOrganization.TabIndex = 3
        Me.pgCooperateOrganization.Text = "合作区局"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.grdCooperateOrganization})
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(668, 343)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        '
        'grdCooperateOrganization
        '
        Me.grdCooperateOrganization.CaptionVisible = False
        Me.grdCooperateOrganization.DataMember = ""
        Me.grdCooperateOrganization.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCooperateOrganization.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdCooperateOrganization.Location = New System.Drawing.Point(3, 17)
        Me.grdCooperateOrganization.Name = "grdCooperateOrganization"
        Me.grdCooperateOrganization.ReadOnly = True
        Me.grdCooperateOrganization.Size = New System.Drawing.Size(662, 323)
        Me.grdCooperateOrganization.TabIndex = 0
        Me.grdCooperateOrganization.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle4})
        '
        'DataGridTableStyle4
        '
        Me.DataGridTableStyle4.DataGrid = Me.grdCooperateOrganization
        Me.DataGridTableStyle4.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn23, Me.DataGridTextBoxColumn24, Me.DataGridTextBoxColumn25})
        Me.DataGridTableStyle4.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle4.MappingName = "TCooperateOrganizationOpinion"
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "合作区局"
        Me.DataGridTextBoxColumn20.MappingName = "cooperate_organization"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 120
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn21.Format = "c"
        Me.DataGridTextBoxColumn21.FormatInfo = CType(resources.GetObject("DataGridTextBoxColumn21.FormatInfo"), System.Globalization.NumberFormatInfo)
        Me.DataGridTextBoxColumn21.HeaderText = "推荐金额(万)"
        Me.DataGridTextBoxColumn21.MappingName = "recommend_sum"
        Me.DataGridTextBoxColumn21.Width = 90
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "推荐意见"
        Me.DataGridTextBoxColumn22.MappingName = "opinion"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.Width = 250
        '
        'DataGridTextBoxColumn23
        '
        Me.DataGridTextBoxColumn23.Format = "yyyy年MM月dd日"
        Me.DataGridTextBoxColumn23.FormatInfo = Nothing
        Me.DataGridTextBoxColumn23.HeaderText = "推荐日期"
        Me.DataGridTextBoxColumn23.MappingName = "recommend_date"
        Me.DataGridTextBoxColumn23.NullText = ""
        Me.DataGridTextBoxColumn23.Width = 95
        '
        'DataGridTextBoxColumn24
        '
        Me.DataGridTextBoxColumn24.Format = ""
        Me.DataGridTextBoxColumn24.FormatInfo = Nothing
        Me.DataGridTextBoxColumn24.HeaderText = "记录人"
        Me.DataGridTextBoxColumn24.MappingName = "create_person"
        Me.DataGridTextBoxColumn24.NullText = ""
        Me.DataGridTextBoxColumn24.Width = 60
        '
        'DataGridTextBoxColumn25
        '
        Me.DataGridTextBoxColumn25.Format = "yyyy年MM月dd日"
        Me.DataGridTextBoxColumn25.FormatInfo = Nothing
        Me.DataGridTextBoxColumn25.HeaderText = "记录日期"
        Me.DataGridTextBoxColumn25.MappingName = "create_date"
        Me.DataGridTextBoxColumn25.NullText = ""
        Me.DataGridTextBoxColumn25.Width = 95
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtCorporationName.Location = New System.Drawing.Point(264, 6)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.ReadOnly = True
        Me.txtCorporationName.Size = New System.Drawing.Size(412, 21)
        Me.txtCorporationName.TabIndex = 8
        Me.txtCorporationName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(96, 6)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 7
        Me.txtProjectCode.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(200, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "企业名称"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "项目编码"
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(604, 408)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "反担保物类型"
        Me.DataGridTextBoxColumn11.MappingName = "type_name"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 75
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "反担保方式"
        Me.DataGridTextBoxColumn12.MappingName = "opposite_guarantee_form"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 75
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "状态"
        Me.DataGridTextBoxColumn13.MappingName = "status"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 75
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn14.Format = "c"
        Me.DataGridTextBoxColumn14.FormatInfo = CType(resources.GetObject("DataGridTextBoxColumn14.FormatInfo"), System.Globalization.NumberFormatInfo)
        Me.DataGridTextBoxColumn14.HeaderText = "原值(元)"
        Me.DataGridTextBoxColumn14.MappingName = "original_value"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 75
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn15.Format = "c"
        Me.DataGridTextBoxColumn15.FormatInfo = CType(resources.GetObject("DataGridTextBoxColumn15.FormatInfo"), System.Globalization.NumberFormatInfo)
        Me.DataGridTextBoxColumn15.HeaderText = "评估总值(元)"
        Me.DataGridTextBoxColumn15.MappingName = "evaluate_value"
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 75
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn16.Format = "c"
        Me.DataGridTextBoxColumn16.FormatInfo = CType(resources.GetObject("DataGridTextBoxColumn16.FormatInfo"), System.Globalization.NumberFormatInfo)
        Me.DataGridTextBoxColumn16.HeaderText = "担保额(元)"
        Me.DataGridTextBoxColumn16.MappingName = "guarantee_value"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 75
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "评估日期"
        Me.DataGridTextBoxColumn17.MappingName = "evaluate_date"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 75
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "评估师"
        Me.DataGridTextBoxColumn18.MappingName = "evaluate_person"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 75
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "说明"
        Me.DataGridTextBoxColumn19.MappingName = "remark"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 160
        '
        'FViewAffirmContent
        '
        Me.AllowDrop = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(696, 439)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.txtCorporationName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.TabControl1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "FViewAffirmContent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "查看确认材料"
        Me.TabControl1.ResumeLayout(False)
        Me.pgDoc.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdDoc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgFee.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.grdFee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgOppositeGuarantee.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.grdGuaranteeFormAdditional, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdGuaranteeForm, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgCooperateOrganization.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.grdCooperateOrganization, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private strProjectCode As String '项目编码
    Private strCorporatioName As String '企业名称
    Private dsTemp As DataSet

    Private Sub FViewAffirmContent_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.txtProjectCode.Text = Me.strProjectCode
            Me.txtCorporationName.Text = Me.strCorporatioName
            '材料清单     'TProjectDocument
            Me.grdDoc.DataSource = gWs.GetProjectDocumentByCondition("{item_type in ('41','42','43') AND check_person IS NOT NULL AND project_code LIKE '" & Me.strProjectCode & "'}").Tables(0)
            '收费清单     'project_account_detail
            Me.grdFee.DataSource = Me.GetFee().Tables(0)
            '获取合作区推荐意见          '返回表名TCooperateOrganizationOpinion
            Me.grdCooperateOrganization.DataSource = gWs.GetCooperateOrganizationOpinion("{project_code = '" & strProjectCode & "'}").Tables(0)
            '反担保物
            'dsTemp = Me.GetGuaranteeForm()
            Me.grdGuaranteeForm.DataSource = dsTemp.Tables("project_guarantee_form")
            Me.grdGuaranteeFormAdditional.DataSource = dsTemp.Tables("project_guarantee_form_additional")
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    '  收费清单
    Private Function GetFee() As DataSet
        dsTemp = gWs.GetProjectAccountDetailInfo("{project_code='" & strProjectCode & "' AND income IS NOT NULL}")
        dsTemp.Merge(gWs.GetItemEx("{item_type in ('31', '34')}").Tables("TItem"))
        Dim dc0() As DataColumn = {dsTemp.Tables(0).Columns("item_type"), dsTemp.Tables(0).Columns("item_code")}
        Dim dc1() As DataColumn = {dsTemp.Tables(1).Columns("item_type"), dsTemp.Tables(1).Columns("item_code")}
        dsTemp.Relations.Add("RItem", dc1, dc0)
        dsTemp.Tables(0).Columns.Add("item_name", GetType(String), "parent(RItem).item_name")
        Return dsTemp
    End Function
    '  反担保物清单
    'Private Function GetGuaranteeForm() As DataSet
    '    dsTemp = gWs.GetProjectGuaranteeFormAdditional(Me._ProjectCode, "44", Me._ItemCode)
    '    dsTemp.Merge(gWs.GetItemType("%").Tables(0)) '"TItemType"
    '    With dsTemp
    '        .Relations.Add("RItemType0", .Tables("TItemType").Columns("item_type"), .Tables("project_guarantee_form").Columns("guaranty"))
    '        .Tables(0).Columns.Add("guaranty_name", GetType(String), "parent(RItemType0).type_name")
    '        .Relations.Add("RItemType1", .Tables("TItemType").Columns("item_type"), .Tables("project_guarantee_form_additional").Columns("guaranty"))
    '        .Tables(0).Columns.Add("guaranty_name", GetType(String), "parent(RItemType1).type_name")
    '    End With
    '    Return dsTemp
    'End Function


    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
