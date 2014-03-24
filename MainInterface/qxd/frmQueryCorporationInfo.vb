Public Class frmQueryCorporationInfo
    Inherits System.Windows.Forms.Form

    'qxd add 2003-6-23
    Private strCorporationCode As String
    Private strCorporationName As String
    Private strSerialNum As String

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
    Friend WithEvents ttpQuery As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgConsultationInfo As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnRegister As System.Windows.Forms.Button
    Friend WithEvents corpinfo As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents consultinfo As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents txtCorpCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents dgCorpInfo As System.Windows.Forms.DataGrid
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQueryCorporationInfo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgCorpInfo = New System.Windows.Forms.DataGrid
        Me.corpinfo = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgConsultationInfo = New System.Windows.Forms.DataGrid
        Me.consultinfo = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.ttpQuery = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnQuery = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtCorpCode = New System.Windows.Forms.TextBox
        Me.txtCorpName = New System.Windows.Forms.TextBox
        Me.btnRegister = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnUpdate = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnExit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgCorpInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgConsultationInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgCorpInfo)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "企业信息"
        '
        'dgCorpInfo
        '
        Me.dgCorpInfo.AllowSorting = False
        Me.dgCorpInfo.CaptionVisible = False
        Me.dgCorpInfo.DataMember = ""
        Me.dgCorpInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgCorpInfo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgCorpInfo.Location = New System.Drawing.Point(3, 17)
        Me.dgCorpInfo.Name = "dgCorpInfo"
        Me.dgCorpInfo.ReadOnly = True
        Me.dgCorpInfo.Size = New System.Drawing.Size(616, 151)
        Me.dgCorpInfo.TabIndex = 5
        Me.dgCorpInfo.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.corpinfo})
        Me.dgCorpInfo.TabStop = False
        Me.ttpQuery.SetToolTip(Me.dgCorpInfo, "双击选定的行，查看咨询信息")
        '
        'corpinfo
        '
        Me.corpinfo.DataGrid = Me.dgCorpInfo
        Me.corpinfo.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10})
        Me.corpinfo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.corpinfo.MappingName = "corporation"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "企业编码"
        Me.DataGridTextBoxColumn1.MappingName = "corporation_code"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 60
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "企业名称"
        Me.DataGridTextBoxColumn2.MappingName = "corporation_name"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 180
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "所属区域"
        Me.DataGridTextBoxColumn8.MappingName = "district_name"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 80
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "注册地址"
        Me.DataGridTextBoxColumn7.MappingName = "register_address"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 180
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "营业执照"
        Me.DataGridTextBoxColumn12.MappingName = "business_licence_code"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.ReadOnly = True
        Me.DataGridTextBoxColumn12.Width = 90
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "法人代码证"
        Me.DataGridTextBoxColumn9.MappingName = "corp_paper_id"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.ReadOnly = True
        Me.DataGridTextBoxColumn9.Width = 90
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "贷款卡"
        Me.DataGridTextBoxColumn10.MappingName = "loan_card_id"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.ReadOnly = True
        Me.DataGridTextBoxColumn10.Width = 90
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgConsultationInfo)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(622, 128)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "咨询信息"
        '
        'dgConsultationInfo
        '
        Me.dgConsultationInfo.AllowNavigation = False
        Me.dgConsultationInfo.AllowSorting = False
        Me.dgConsultationInfo.CaptionVisible = False
        Me.dgConsultationInfo.DataMember = ""
        Me.dgConsultationInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgConsultationInfo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgConsultationInfo.Location = New System.Drawing.Point(3, 17)
        Me.dgConsultationInfo.Name = "dgConsultationInfo"
        Me.dgConsultationInfo.ReadOnly = True
        Me.dgConsultationInfo.Size = New System.Drawing.Size(616, 108)
        Me.dgConsultationInfo.TabIndex = 0
        Me.dgConsultationInfo.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.consultinfo})
        Me.dgConsultationInfo.TabStop = False
        Me.ttpQuery.SetToolTip(Me.dgConsultationInfo, "双击选定的行，修改咨询信息")
        '
        'consultinfo
        '
        Me.consultinfo.DataGrid = Me.dgConsultationInfo
        Me.consultinfo.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn20})
        Me.consultinfo.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.consultinfo.MappingName = "consultation"
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "咨询次数"
        Me.DataGridTextBoxColumn17.MappingName = "serial_num"
        Me.DataGridTextBoxColumn17.NullText = ""
        Me.DataGridTextBoxColumn17.Width = 60
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "咨询日期"
        Me.DataGridTextBoxColumn13.MappingName = "consult_date"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 70
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.HeaderText = "申请业务品种"
        Me.DataGridTextBoxColumn19.MappingName = "apply_service_type"
        Me.DataGridTextBoxColumn19.NullText = ""
        Me.DataGridTextBoxColumn19.Width = 90
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn18.Format = ""
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "申请担保金额(万元)"
        Me.DataGridTextBoxColumn18.MappingName = "apply_guarantee_sum"
        Me.DataGridTextBoxColumn18.NullText = ""
        Me.DataGridTextBoxColumn18.Width = 150
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "担保期限(月)"
        Me.DataGridTextBoxColumn4.MappingName = "apply_term"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 80
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "申请贷款银行"
        Me.DataGridTextBoxColumn3.MappingName = "CAppyBank"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 110
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "推荐类型"
        Me.DataGridTextBoxColumn5.MappingName = "recommend_type"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 60
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "推荐人(单位)"
        Me.DataGridTextBoxColumn6.MappingName = "recommend_person"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 90
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "咨询人员"
        Me.DataGridTextBoxColumn14.MappingName = "consult_person"
        Me.DataGridTextBoxColumn14.NullText = ""
        Me.DataGridTextBoxColumn14.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "上年销售收入(万元)"
        Me.DataGridTextBoxColumn11.MappingName = "lastyear_sales_income"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 150
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.HeaderText = "上年利润总额(万元)"
        Me.DataGridTextBoxColumn20.MappingName = "lastyear_total_profit"
        Me.DataGridTextBoxColumn20.NullText = ""
        Me.DataGridTextBoxColumn20.Width = 150
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuery.ImageIndex = 0
        Me.btnQuery.ImageList = Me.ImageList1
        Me.btnQuery.Location = New System.Drawing.Point(526, 15)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(77, 24)
        Me.btnQuery.TabIndex = 7
        Me.btnQuery.Text = "查 询(&Q)"
        Me.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpQuery.SetToolTip(Me.btnQuery, "查询企业信息")
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        '
        'txtCorpCode
        '
        Me.txtCorpCode.Location = New System.Drawing.Point(64, 16)
        Me.txtCorpCode.MaxLength = 5
        Me.txtCorpCode.Name = "txtCorpCode"
        Me.txtCorpCode.Size = New System.Drawing.Size(120, 21)
        Me.txtCorpCode.TabIndex = 5
        Me.txtCorpCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ttpQuery.SetToolTip(Me.txtCorpCode, "企业编码")
        '
        'txtCorpName
        '
        Me.txtCorpName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorpName.Location = New System.Drawing.Point(296, 16)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(190, 21)
        Me.txtCorpName.TabIndex = 6
        Me.ttpQuery.SetToolTip(Me.txtCorpName, "企业名称")
        '
        'btnRegister
        '
        Me.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRegister.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRegister.ImageIndex = 3
        Me.btnRegister.ImageList = Me.ImageList1
        Me.btnRegister.Location = New System.Drawing.Point(216, 376)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(144, 24)
        Me.btnRegister.TabIndex = 6
        Me.btnRegister.Text = "增加再次企业咨询(&A)"
        Me.btnRegister.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpQuery.SetToolTip(Me.btnRegister, "登记新的企业咨询信息")
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 2
        Me.btnNew.ImageList = Me.ImageList1
        Me.btnNew.Location = New System.Drawing.Point(64, 376)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(144, 24)
        Me.btnNew.TabIndex = 213
        Me.btnNew.Text = "登记首次企业咨询(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ttpQuery.SetToolTip(Me.btnNew, "登记新的企业咨询信息")
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.ImageIndex = 4
        Me.btnUpdate.ImageList = Me.ImageList1
        Me.btnUpdate.Location = New System.Drawing.Point(368, 376)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(124, 24)
        Me.btnUpdate.TabIndex = 7
        Me.btnUpdate.Text = "修改企业咨询(&M)"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btnQuery)
        Me.GroupBox3.Controls.Add(Me.txtCorpCode)
        Me.GroupBox3.Controls.Add(Me.txtCorpName)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(622, 48)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "企业编码"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(240, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "企业名称"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 1
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(500, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 212
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmQueryCorporationInfo
        '
        Me.AcceptButton = Me.btnQuery
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(640, 425)
        Me.Controls.Add(Me.btnNew)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnRegister)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQueryCorporationInfo"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "查询企业信息"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgCorpInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgConsultationInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected dsCorp As DataSet
    Protected dsConsult As DataSet

    Protected dsCorpA As DataSet
    Protected dsConsultA As DataSet

    Private corpIndex As Integer = 0    ' 企业信息的位置
    Private consultIndex As Integer = 0 ' 咨询信息的位置

    Private WithEvents rc As frmRegisterCorporationInfo
    Public Event reFreshTask()

    Private Sub txtCorpCode_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtCorpCode.SelectAll()
    End Sub

    Protected Sub dgCorpInfo_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCorpInfo.CurrentCellChanged
        Dim he As DataGrid = CType(sender, DataGrid)
        he.Select(he.CurrentRowIndex)
        dgCorpInfo_Click(Nothing, Nothing)
    End Sub

    Public Sub dgCorpInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgCorpInfo.Click

        If Me.dgCorpInfo.DataSource Is Nothing Then Return
        If Me.dsCorp.Tables("corporation").Rows.Count <= 0 Then Return

        corpIndex = dgCorpInfo.CurrentRowIndex

        Me.dgConsultationInfo.DataSource = Nothing
        Try
            'Me.Cursor = Cursors.WaitCursor
            Dim corpCode As String = Me.dgCorpInfo.Item(corpIndex, 0)
            Me.strCorporationCode = corpCode 'qxd add 2003-6-23
            strCorporationName = Me.dgCorpInfo.Item(corpIndex, 1)

            Dim strWhere As String = "{corporation_code='" & corpCode & "'}"
            dsConsult = VouchService.GetcorporationInfo("", strWhere)
            dsConsultA = dsConsult.Copy()

            If dsConsultA.Tables("consultation").Rows.Count <= 0 Then
                Me.btnRegister.Enabled = False
                Me.btnUpdate.Enabled = False
                Return
            End If
            '????
            If dsConsult.Tables("consultation").Rows.Count > 0 Then
                Me.btnRegister.Enabled = True
                Me.btnUpdate.Enabled = True
                dsConsultA.Merge(BankDS.Tables("bank"))

                dsConsultA.Relations.Add("RBank", dsConsultA.Tables("bank").Columns("bank_code"), dsConsultA.Tables("consultation").Columns("apply_bank_code"))
                dsConsultA.Tables("consultation").Columns.Add("CAppyBank", GetType(String), "Parent(RBank).bank_name")

            End If

            If Not dsConsult Is Nothing Then
                Me.dgConsultationInfo.DataSource = dsConsult.Tables("consultation")
                setDgAttribute(Me.dgConsultationInfo, Me)
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally

            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub dgConsultationInfo_CurrentCellChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgConsultationInfo.CurrentCellChanged
        Dim he As DataGrid = CType(sender, DataGrid)
        he.Select(he.CurrentRowIndex)
    End Sub

    '新增
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        strSerialNum = "1" 'qxd
        If Me.txtCorpCode.Text = "" And Me.txtCorpName.Text <> "" AndAlso Me.dsCorp.Tables("corporation").Rows.Count = 0 Then
            rc = New frmRegisterCorporationInfo(Nothing, strSerialNum, Nothing, Me, Me.txtCorpName.Text) 'qxd
        Else
            rc = New frmRegisterCorporationInfo(Nothing, strSerialNum, Nothing, Me) 'qxd
        End If
        rc.AllowTransparency = False
        rc.Text = "登记企业咨询信息"
        rc.NewCorporation = True
        rc.ShowDialog(Me)
    End Sub
    '增加
    Private Sub btnRegister_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRegister.Click

        Dim currentIndx As Integer
        currentIndx = Me.dgConsultationInfo.CurrentRowIndex
        strSerialNum = Me.dgConsultationInfo.Item(currentIndx, 0)

        rc = New frmRegisterCorporationInfo(Me.strCorporationCode, Me.strSerialNum, dsConsult, Me)
        rc.AllowTransparency = False
        rc.Text = "增加企业咨询信息"
        rc.txtCorporation_name.Text = dsCorp.Tables("corporation").Rows(corpIndex).Item("corporation_name")
        rc.txtCorporation_name.Enabled = False
        rc.ShowDialog(Me)
    End Sub
    '更新
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If dgConsultationInfo.DataSource Is Nothing Then Return
        If Me.dsCorp.Tables("consultation").Rows.Count <= 0 Then Return

        consultIndex = dgConsultationInfo.CurrentRowIndex

        If consultIndex < 0 Then Return

        Try
            '----------------------------------------------qxd 2003.7.10 add ???
            '重新获得dsConsult，以确保dgConsult中显示的信息与dsConsult同步
            Dim corpCode As Integer
            corpCode = Me.strCorporationCode
            Dim strWhere As String = "corporation_code=" & corpCode
            dsConsult = VouchService.GetcorporationInfo("", "{" + strWhere + "}")
            '----------------------------------------------
            strSerialNum = Me.dgConsultationInfo.Item(consultIndex, 0)
            rc = New frmRegisterCorporationInfo(Me.strCorporationCode, Me.strSerialNum, dsConsult, Me)
            rc.NeedNewRecord = False
            rc.Text = "修改咨询企业信息"
            rc.AllowTransparency = False
            rc.ShowDialog(Me)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '查询
    Public Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Me.Cursor = Cursors.WaitCursor
        queryCorporation()
        dgCorpInfo_Click(Nothing, Nothing) '列出第一条企业咨询信息
        Me.Cursor = Cursors.Default
    End Sub
    '查询企业信息
    Public Sub queryCorporation()

        Dim strSql As String

        '获取查询条件，如果企业编码不为空，以企业编码为准
        If Me.txtCorpCode.Text = "" Then
            strSql = "{corporation_name like '%" & Me.txtCorpName.Text.Trim & "%'and corporation_type='1' order by corporation_code DESC}"
        Else
            strSql = "{corporation_code like '%" & Me.txtCorpCode.Text.Trim & "%'and corporation_type='1' order by corporation_code DESC}"
        End If

        Try
            dsCorp = VouchService.GetcorporationInfo(strSql, "")
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        If Not dsCorp.Tables("corporation") Is Nothing Then
            If dsCorp.Tables("corporation").Rows.Count = 0 Then
                Me.btnRegister.Enabled = False
                Me.btnUpdate.Enabled = False
            Else
                Me.btnRegister.Enabled = True
                Me.btnUpdate.Enabled = True
            End If

            Me.dgCorpInfo.DataSource = dsCorp.Tables("corporation")
        End If

        Me.dgConsultationInfo.DataSource = Nothing
    End Sub
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
    'Load()
    Private Sub frmQueryCorporationInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnRegister.Enabled = False
        Me.btnUpdate.Enabled = False
    End Sub

    Private Sub subRegister() Handles rc.evtAccept
        RaiseEvent reFreshTask()
    End Sub
End Class
