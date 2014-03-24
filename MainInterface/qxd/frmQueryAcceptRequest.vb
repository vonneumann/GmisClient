Public Class frmQueryAcceptRequest
    Inherits System.Windows.Forms.Form

    Protected dsConsult As DataSet

    'Protected dsCorpA As DataSet
    Protected dsConsultA As DataSet

    Private corpIndex As Integer = 0    ' 企业信息的位置
    Private consultIndex As Integer = 0 ' 咨询信息的位置

    'qxd add 2003-6-23
    Private strCorporationCode As String
    Private strSerialNum As String = "1"
    Private isNoCommited As Boolean = False
    Private strProjectCode As String

    Public Event refreshTask()

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents btnQuery As System.Windows.Forms.Button
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtCorpCode As System.Windows.Forms.TextBox
    Public WithEvents txtCorpName As System.Windows.Forms.TextBox
    Public WithEvents dgQueryResult As System.Windows.Forms.DataGrid
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAcceptRequest As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgProjectInfo As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn21 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn22 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn3 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmQueryAcceptRequest))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtCorpCode = New System.Windows.Forms.TextBox()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgQueryResult = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAcceptRequest = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgProjectInfo = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn22 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn21 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn3 = New System.Windows.Forms.DataGridBoolColumn()
        Me.btnView = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgProjectInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnQuery, Me.txtCorpCode, Me.txtCorpName, Me.Label2, Me.Label1})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuery.ImageIndex = 2
        Me.btnQuery.ImageList = Me.ImageList1
        Me.btnQuery.Location = New System.Drawing.Point(520, 14)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(77, 24)
        Me.btnQuery.TabIndex = 9
        Me.btnQuery.Text = "查 询(&Q)"
        Me.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'txtCorpCode
        '
        Me.txtCorpCode.Location = New System.Drawing.Point(64, 17)
        Me.txtCorpCode.MaxLength = 5
        Me.txtCorpCode.Name = "txtCorpCode"
        Me.txtCorpCode.Size = New System.Drawing.Size(112, 21)
        Me.txtCorpCode.TabIndex = 8
        Me.txtCorpCode.Text = ""
        Me.txtCorpCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCorpName
        '
        Me.txtCorpName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtCorpName.Location = New System.Drawing.Point(280, 17)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(216, 21)
        Me.txtCorpName.TabIndex = 7
        Me.txtCorpName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "企业编码"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(224, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "企业名称"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgQueryResult})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(614, 240)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "查询结果"
        '
        'dgQueryResult
        '
        Me.dgQueryResult.CaptionVisible = False
        Me.dgQueryResult.DataMember = ""
        Me.dgQueryResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgQueryResult.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgQueryResult.Location = New System.Drawing.Point(3, 17)
        Me.dgQueryResult.Name = "dgQueryResult"
        Me.dgQueryResult.Size = New System.Drawing.Size(608, 220)
        Me.dgQueryResult.TabIndex = 0
        Me.dgQueryResult.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgQueryResult
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn11, Me.DataGridBoolColumn1, Me.DataGridBoolColumn2, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "corporation"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "企业编码"
        Me.DataGridTextBoxColumn7.MappingName = "corporation_code"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "企业名称"
        Me.DataGridTextBoxColumn1.MappingName = "corporation_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 150
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "企业类型"
        Me.DataGridTextBoxColumn2.MappingName = "corporation_type"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 0
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "注册地址"
        Me.DataGridTextBoxColumn3.MappingName = "register_address"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "所属区"
        Me.DataGridTextBoxColumn10.MappingName = "district_name"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 90
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "成立日期"
        Me.DataGridTextBoxColumn4.MappingName = "found_date"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "行业类型"
        Me.DataGridTextBoxColumn5.MappingName = "industry_type"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "所有制类型"
        Me.DataGridTextBoxColumn6.MappingName = "proprietorship_type"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 130
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "科技类型"
        Me.DataGridTextBoxColumn11.MappingName = "technology_name"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.AllowNull = False
        Me.DataGridBoolColumn1.FalseValue = ""
        Me.DataGridBoolColumn1.HeaderText = "是否继续支持"
        Me.DataGridBoolColumn1.MappingName = "is_continue_support"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = Nothing
        Me.DataGridBoolColumn1.TrueValue = ""
        Me.DataGridBoolColumn1.Width = 0
        '
        'DataGridBoolColumn2
        '
        Me.DataGridBoolColumn2.AllowNull = False
        Me.DataGridBoolColumn2.FalseValue = ""
        Me.DataGridBoolColumn2.HeaderText = "是否高风险"
        Me.DataGridBoolColumn2.MappingName = "is_high_risk"
        Me.DataGridBoolColumn2.NullText = ""
        Me.DataGridBoolColumn2.NullValue = Nothing
        Me.DataGridBoolColumn2.TrueValue = ""
        Me.DataGridBoolColumn2.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "继续支持"
        Me.DataGridTextBoxColumn12.MappingName = "continue_support"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "是否高风险"
        Me.DataGridTextBoxColumn13.MappingName = "high_risk"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 1
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(374, 432)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnAcceptRequest
        '
        Me.btnAcceptRequest.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAcceptRequest.Image = CType(resources.GetObject("btnAcceptRequest.Image"), System.Drawing.Bitmap)
        Me.btnAcceptRequest.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAcceptRequest.ImageIndex = 0
        Me.btnAcceptRequest.ImageList = Me.ImageList1
        Me.btnAcceptRequest.Location = New System.Drawing.Point(182, 432)
        Me.btnAcceptRequest.Name = "btnAcceptRequest"
        Me.btnAcceptRequest.Size = New System.Drawing.Size(77, 24)
        Me.btnAcceptRequest.TabIndex = 4
        Me.btnAcceptRequest.Text = "受 理(&A)"
        Me.btnAcceptRequest.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgProjectInfo})
        Me.GroupBox3.Location = New System.Drawing.Point(9, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(614, 120)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "企业历史项目信息"
        '
        'dgProjectInfo
        '
        Me.dgProjectInfo.AllowNavigation = False
        Me.dgProjectInfo.AllowSorting = False
        Me.dgProjectInfo.CaptionVisible = False
        Me.dgProjectInfo.DataMember = ""
        Me.dgProjectInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProjectInfo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgProjectInfo.Location = New System.Drawing.Point(3, 17)
        Me.dgProjectInfo.Name = "dgProjectInfo"
        Me.dgProjectInfo.ReadOnly = True
        Me.dgProjectInfo.Size = New System.Drawing.Size(608, 100)
        Me.dgProjectInfo.TabIndex = 0
        Me.dgProjectInfo.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        Me.dgProjectInfo.TabStop = False
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dgProjectInfo
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn22, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20, Me.DataGridTextBoxColumn21, Me.DataGridBoolColumn3})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "ViewProject"
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn8.MappingName = "ProjectCode"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn22
        '
        Me.DataGridTextBoxColumn22.Format = ""
        Me.DataGridTextBoxColumn22.FormatInfo = Nothing
        Me.DataGridTextBoxColumn22.HeaderText = "企业名称"
        Me.DataGridTextBoxColumn22.MappingName = "EnterpriseName"
        Me.DataGridTextBoxColumn22.NullText = ""
        Me.DataGridTextBoxColumn22.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "受理日期"
        Me.DataGridTextBoxColumn9.MappingName = "ApplyDate"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "初审人员"
        Me.DataGridTextBoxColumn14.MappingName = "first_review_person"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 75
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "初审结论"
        Me.DataGridTextBoxColumn15.MappingName = ""
        Me.DataGridTextBoxColumn15.NullText = ""
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "项目经理A"
        Me.DataGridTextBoxColumn16.MappingName = "manager_A"
        Me.DataGridTextBoxColumn16.NullText = ""
        Me.DataGridTextBoxColumn16.Width = 75
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "项目经理B"
        Me.DataGridTextBoxColumn17.MappingName = "manager_B"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 75
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "评审会结论"
        Me.DataGridTextBoxColumn18.MappingName = "trial_conclusion"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 75
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "最终阶段"
        Me.DataGridTextBoxColumn19.MappingName = "phase"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 75
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "最终状态"
        Me.DataGridTextBoxColumn20.MappingName = "Status"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 75
        '
        'DataGridTextBoxColumn21
        '
        Me.DataGridTextBoxColumn21.Format = ""
        Me.DataGridTextBoxColumn21.FormatInfo = Nothing
        Me.DataGridTextBoxColumn21.HeaderText = "是否首次贷款"
        Me.DataGridTextBoxColumn21.MappingName = ""
        Me.DataGridTextBoxColumn21.NullText = ""
        Me.DataGridTextBoxColumn21.Width = 0
        '
        'DataGridBoolColumn3
        '
        Me.DataGridBoolColumn3.AllowNull = False
        Me.DataGridBoolColumn3.FalseValue = "0"
        Me.DataGridBoolColumn3.HeaderText = "是否首次贷款"
        Me.DataGridBoolColumn3.MappingName = "is_first_loan"
        Me.DataGridBoolColumn3.NullText = ""
        Me.DataGridBoolColumn3.NullValue = CType(resources.GetObject("DataGridBoolColumn3.NullValue"), System.DBNull)
        Me.DataGridBoolColumn3.TrueValue = "1"
        Me.DataGridBoolColumn3.Width = 90
        '
        'btnView
        '
        Me.btnView.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Bitmap)
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.ImageIndex = 3
        Me.btnView.ImageList = Me.ImageList1
        Me.btnView.Location = New System.Drawing.Point(280, 432)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(77, 24)
        Me.btnView.TabIndex = 6
        Me.btnView.Text = "查 看(&V)"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmQueryAcceptRequest
        '
        Me.AcceptButton = Me.btnQuery
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(632, 461)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnView, Me.GroupBox3, Me.btnAcceptRequest, Me.btnExit, Me.GroupBox2, Me.GroupBox1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQueryAcceptRequest"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "受理申请查询"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgProjectInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    '
    '企业数据集
    '
    Protected dsCorp As DataSet
    Protected queryString As String

    Private Overloads Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        queryAccept()
        dgQueryResult_Click(sender, e)
    End Sub
    '查询受理
    Private Sub queryAccept()
        Dim strWhere As String = "corporation_code is not null order by corporation_code desc"
        Dim nameNULL As Boolean = (Me.txtCorpName.Text = "")
        Dim codeNULL As Boolean = (Me.txtCorpCode.Text = "")

        dsCorp = Nothing
        dgQueryResult.DataSource = Nothing

        Try
            If (codeNULL) Then
                If Me.txtCorpName.Text = "" Then
                    Dim strSql As String
                    strSql = "{corporation_code is not null and corporation_type='1' order by corporation_code desc }" ' "{corporation_type='1'}"
                    dsCorp = gWs.GetcorporationInfo(strSql, "")
                    'dgQueryResult.DataMember = "corporation"
                    'dgQueryResult.DataSource = dsCorp
                Else
                    strWhere = "corporation_name like '%" + Me.txtCorpName.Text + "%' and corporation_type='1' order by corporation_code desc"
                End If
            Else
                strWhere = "corporation_code='" + Me.txtCorpCode.Text & "' and corporation_type='1' order by corporation_code desc"
            End If

            If dsCorp Is Nothing Then dsCorp = gWs.GetcorporationInfo("{" + strWhere + "}", "")
            ''只添加一次,以显示科技类型
            'dsCorp.Tables("corporation").Columns.Add("technology_name", GetType(String))
            'dsCorp.Tables("corporation").Columns.Add("high_risk", GetType(String))
            'dsCorp.Tables("corporation").Columns.Add("continue_support", GetType(String))
            ''获取科技类型
            'Dim i As Integer
            'Dim dr As DataRow
            'i = dsCorp.Tables("corporation").Rows.Count
            'If i > 0 Then
            '    For i = 0 To i - 1
            '        dr = dsCorp.Tables("corporation").Rows(i)
            '        With dr
            '            If .Item("technology_type") Is System.DBNull.Value Then
            '                .Item("technology_name") = ""
            '            Else
            '                .Item("technology_name") = getTechnologyType(.Item("technology_type"))
            '            End If
            '            If Not .Item("is_high_risk") Is System.DBNull.Value Then
            '                If .Item("is_high_risk") Then
            '                    .Item("high_risk") = "是"
            '                Else
            '                    .Item("high_risk") = "否"
            '                End If
            '            Else
            '                .Item("high_risk") = ""
            '            End If
            '            If Not .Item("is_continue_support") Is System.DBNull.Value Then
            '                If .Item("is_continue_support") Then
            '                    .Item("continue_support") = "是"
            '                Else
            '                    .Item("continue_support") = "否"
            '                End If
            '            Else
            '                .Item("continue_support") = ""
            '            End If
            '        End With
            '    Next
            'End If
            Dim dsCorpA As DataSet = dsCorp.Copy()

            If Not dsCorpA Is Nothing Then
                If dsCorpA.Tables("corporation").Rows.Count = 0 Then
                    Me.btnAcceptRequest.Enabled = False
                Else
                    Me.btnAcceptRequest.Enabled = True
                    Me.dgQueryResult.DataSource = dsCorpA.Tables("corporation")
                    setDgAttribute(Me.dgQueryResult, Me)
                End If
            Else
                Me.btnAcceptRequest.Enabled = False
                Me.btnView.Enabled = False
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Exclamation, "受理申请")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
    '企业编码
    Private Sub txtCorpCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCorpCode.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    End Sub
    '受理
    Private Sub btnAcceptRequest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAcceptRequest.Click
        If Me.dgQueryResult.DataSource Is Nothing Then '不存在咨询单位时
            Return
        End If
        If dsCorp.Tables("corporation").Rows.Count <= 0 Then '所选择的咨询单位没有申请项目时
            Return
        End If

        Try
            Dim inx As Integer '咨询单位
            Dim ccode As String '咨询单位代号
            Dim pcode As String
            Dim corpName As String '咨询单位名称

            inx = dgQueryResult.CurrentRowIndex
            ccode = dsCorp.Tables("corporation").Rows(inx).Item("corporation_code")
            strCorporationCode = ccode
            Dim strSql As String = "{corporation_code='" & ccode & "'}"
            Dim dsConsult As DataSet = gWs.GetcorporationInfo("", strSql)
            If dsConsult.Tables("consultation").Rows.Count > 0 Then
                Me.strSerialNum = dsConsult.Tables("consultation").Select(Nothing, "serial_num desc")(0).Item("serial_num")
            End If
            corpName = dsCorp.Tables("corporation").Rows(inx).Item("corporation_name")

            '如果有未提交的项目,则获取该项目编码进行受理;
            '否则获取新的项目编码

            Me.isNoCommited = isNoCommitedProject(ccode) '如果phase AND status同为空，表示存在有没有提交的项目

            If isNoCommited Then
                pcode = Me.strProjectCode
            Else '为false
                pcode = gWs.GetProjectCode(ccode)
            End If

            Dim aq As New frmAcceptRequest(Me, Me.strCorporationCode, Me.strSerialNum)
            aq.setProjectCode(pcode) '项目编码
            aq.setCorporationCode(ccode) '企业编码
            aq.setCorporationName(corpName) '企业名称
            aq.setUser(UserName) '用户名称
            aq.setIsNewPorjectCode(Not isNoCommited) '是否使用的新的项目编码

            AddHandler aq.refreshTaskCommit, AddressOf refreshTaskSub

            aq.AllowTransparency = False
            aq.ShowDialog()

            Me.dgQueryResult_Click(sender, e)

        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    'DoubleClick
    Private Sub dgQueryResult_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgQueryResult.DoubleClick
        btnAcceptRequest_Click(Nothing, Nothing)
    End Sub
    'Load()
    Private Sub frmQueryAcceptRequest_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnView.Enabled = False
        Me.btnAcceptRequest.Enabled = False
    End Sub
    'MouseUp
    Private Sub dgQueryResult_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgQueryResult.MouseUp
        If Me.dsCorp Is Nothing Then
            Exit Sub
        End If
        If Me.dsCorp.Tables("corporation").Rows.Count > 0 Then
            Me.dgQueryResult.Select(Me.dgQueryResult.CurrentCell.RowNumber)
            dgQueryResult_Click(sender, e)
        End If
    End Sub
    '点击查询信息,获得咨询信息
    Private Sub dgQueryResult_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgQueryResult.Click
        Try
            If Me.dgQueryResult.DataSource Is Nothing Then
                dgProjectInfo.DataSource = Nothing
                Return
            End If
            If Me.dsCorp.Tables("corporation").Rows.Count <= 0 Then
                Me.dgProjectInfo.DataSource = Nothing
                Me.btnView.Enabled = False
                Return
            End If
            corpIndex = dgQueryResult.CurrentRowIndex
            Dim corpCode As String = Me.dgQueryResult.Item(corpIndex, 0)
            Me.getAcceptProject(corpCode)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
        End Try
    End Sub
    '根据企业编码,获取受理信息
    Private Sub getAcceptProject(ByVal corporationCode As String)
        Dim ds As DataSet
        Dim i As Integer
        Dim strSql As String
        strSql = "{projectcode like '" & corporationCode & "%' order by projectcode desc}"
        Try
            ds = gWs.GetProjectInfoEx(strSql)
            Me.dgProjectInfo.DataSource = ds.Tables("ViewProject")
            If ds.Tables(0).Rows.Count > 0 Then
                Me.btnView.Enabled = True
            Else
                Me.btnView.Enabled = False
            End If
        Catch
        Finally
        End Try
    End Sub
    'MouseUp
    Private Sub dgProjectInfo_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgProjectInfo.MouseUp
        If CType(Me.dgProjectInfo.DataSource, DataTable) Is Nothing Then
            Exit Sub
        End If
        If CType(Me.dgProjectInfo.DataSource, DataTable).Rows.Count > 0 Then
            Me.dgProjectInfo.Select(Me.dgProjectInfo.CurrentCell.RowNumber)
        End If
    End Sub
    '查看完整项目信息
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If CType(Me.dgProjectInfo.DataSource, DataTable) Is Nothing Then
            Exit Sub
        End If
        If CType(Me.dgProjectInfo.DataSource, DataTable).Rows.Count > 0 Then
            Me.dgProjectInfo.Select(Me.dgProjectInfo.CurrentCell.RowNumber)
            Dim projectCode, enterpriseName As String
            projectCode = Me.dgProjectInfo.Item(Me.dgProjectInfo.CurrentCell.RowNumber, 0)
            enterpriseName = Me.dgProjectInfo.Item(Me.dgProjectInfo.CurrentCell.RowNumber, 1)
            Dim showProject As New frmShowProjectInfo(projectCode, enterpriseName)
            showProject.ShowDialog()
        End If
    End Sub
    '根据企业编码，判断是否有未提交的项目信息。有,则读出该项目编码
    Private Function isNoCommitedProject(ByVal corporationCode As String) As Boolean
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strSql As String
        Dim i As Integer
        Try
            strSql = "{corporation_code='" & corporationCode & " '}"
            ds = gWs.GetProjectInfo(strSql)
            i = ds.Tables("project").Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    dr = ds.Tables("project").Rows(i)
                    With dr
                        If (.Item("phase") Is System.DBNull.Value) And (.Item("status") Is System.DBNull.Value) Then
                            Me.strProjectCode = .Item("project_code")
                            Return True
                            Exit Function
                        End If
                    End With
                Next
            End If
        Catch
        Finally
        End Try
        Return False
    End Function

    Private Sub refreshTaskSub()
        RaiseEvent refreshTask()
    End Sub

End Class
