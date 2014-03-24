

Public Class frmCompanyFileManage
    Inherits MainInterface.frmBasic

    Private count As Integer = 0
    Private nCurrentCount As Integer = 0
    Private isLoad As Boolean = False
    Private strDir As String = "\Document\"

    Private dsFiles As DataSet
    Private bmDocument As BindingManagerBase '允许对 Windows 窗体上绑定到相同数据源的数据绑定控件进行同步
    Private isNewBtnClick As Boolean = False '是否点击了"新增"按钮
    Private currentIndex As Integer = 0 '当前选中行的位置

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtVersion As System.Windows.Forms.TextBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbChildType As System.Windows.Forms.ComboBox
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents dgFiles As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCompanyFileManage))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgFiles = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.cmbChildType = New System.Windows.Forms.ComboBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(560, 472)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgFiles})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 336)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "文件列表"
        '
        'dgFiles
        '
        Me.dgFiles.CaptionVisible = False
        Me.dgFiles.DataMember = ""
        Me.dgFiles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgFiles.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgFiles.Location = New System.Drawing.Point(3, 17)
        Me.dgFiles.Name = "dgFiles"
        Me.dgFiles.ReadOnly = True
        Me.dgFiles.Size = New System.Drawing.Size(690, 316)
        Me.dgFiles.TabIndex = 0
        Me.dgFiles.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgFiles
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridBoolColumn1, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TProjectFile"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "标题"
        Me.DataGridTextBoxColumn1.MappingName = "title"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 250
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "文件类型"
        Me.DataGridTextBoxColumn2.MappingName = "type"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "子类型"
        Me.DataGridTextBoxColumn3.MappingName = "type_name"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.AllowNull = False
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "有文件"
        Me.DataGridBoolColumn1.MappingName = "is_file"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = Nothing
        Me.DataGridBoolColumn1.ReadOnly = True
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "备注"
        Me.DataGridTextBoxColumn4.MappingName = "remark"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 120
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "版本"
        Me.DataGridTextBoxColumn5.MappingName = "version"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "文件名称"
        Me.DataGridTextBoxColumn6.MappingName = "file_name"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "item_type"
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.MappingName = "item_code"
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.MappingName = "relation_num"
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "创建人"
        Me.DataGridTextBoxColumn10.MappingName = "create_person"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "创建日期"
        Me.DataGridTextBoxColumn11.MappingName = "create_date"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 75
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.MappingName = "serial_num"
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtRemark, Me.cmbChildType, Me.cmbType, Me.txtVersion, Me.txtTitle, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 352)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(696, 112)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "文件信息"
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtRemark.Location = New System.Drawing.Point(320, 56)
        Me.txtRemark.MaxLength = 100
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemark.Size = New System.Drawing.Size(352, 48)
        Me.txtRemark.TabIndex = 4
        Me.txtRemark.Text = ""
        '
        'cmbChildType
        '
        Me.cmbChildType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChildType.Location = New System.Drawing.Point(64, 83)
        Me.cmbChildType.Name = "cmbChildType"
        Me.cmbChildType.Size = New System.Drawing.Size(168, 20)
        Me.cmbChildType.TabIndex = 3
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Location = New System.Drawing.Point(64, 56)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(168, 20)
        Me.cmbType.TabIndex = 2
        '
        'txtVersion
        '
        Me.txtVersion.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtVersion.Location = New System.Drawing.Point(488, 24)
        Me.txtVersion.MaxLength = 10
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(184, 21)
        Me.txtVersion.TabIndex = 1
        Me.txtVersion.Text = ""
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtTitle.Location = New System.Drawing.Point(64, 24)
        Me.txtTitle.MaxLength = 50
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(336, 21)
        Me.txtTitle.TabIndex = 0
        Me.txtTitle.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(288, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "备注"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "子类型"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "文件类型"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label2.Location = New System.Drawing.Point(456, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "版本"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "标    题"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(480, 472)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(400, 472)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnModify
        '
        Me.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Bitmap)
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.ImageIndex = 14
        Me.btnModify.ImageList = Me.ImageListBasic
        Me.btnModify.Location = New System.Drawing.Point(320, 472)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(77, 23)
        Me.btnModify.TabIndex = 5
        Me.btnModify.Text = "修 改(&M)"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 13
        Me.btnNew.ImageList = Me.ImageListBasic
        Me.btnNew.Location = New System.Drawing.Point(240, 472)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 23)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpload
        '
        Me.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpload.Image = CType(resources.GetObject("btnUpload.Image"), System.Drawing.Bitmap)
        Me.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpload.ImageIndex = 25
        Me.btnUpload.ImageList = Me.ImageListBasic
        Me.btnUpload.Location = New System.Drawing.Point(160, 472)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(77, 23)
        Me.btnUpload.TabIndex = 3
        Me.btnUpload.Text = "上 载(&U)"
        Me.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Bitmap)
        Me.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpen.ImageIndex = 17
        Me.btnOpen.ImageList = Me.ImageListBasic
        Me.btnOpen.Location = New System.Drawing.Point(80, 472)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(77, 23)
        Me.btnOpen.TabIndex = 2
        Me.btnOpen.Text = "打 开(&O)"
        Me.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCompanyFileManage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 503)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnOpen, Me.btnUpload, Me.btnNew, Me.btnModify, Me.btnDelete, Me.btnSave, Me.GroupBox2, Me.GroupBox1})
        Me.Name = "frmCompanyFileManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "公司文件管理"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCompanyFileManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            isLoad = True

            '绑定文件类型
            bindingType()
            '设置子类型
            setChildType()
            '设置TextBox的属性
            setTextBox(False)
            '获得公司文件
            Me.dsFiles = getCompanyFile()

            If Not Me.dsFiles Is Nothing Then
                Me.dgFiles.DataSource = Me.dsFiles.Tables("TProjectFile")
                Try
                    Me.bmDocument = Me.BindingContext(dsFiles, "TProjectFile")
                Catch ex As Exception
                    'MsgBox(ex.Message)
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
                '设置dg不能自动增加行
                setDgAttribute(Me.dgFiles, Me)
                Me.dsFiles.AcceptChanges()
                '设置按钮的Enabled属性
                setButton()
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '绑定文件类型,61,62,63,……
    Private Sub bindingType()
        Dim ds As DataSet
        Dim strSql As String
        'strSql = "{item_type like '61' or item_type like '62' or item_type like '63'}"
        strSql = "{item_type like '6%'}"
        ds = gWs.GetItemType(strSql)
        Me.cmbType.DataSource = ds.Tables(0)
        Me.cmbType.DisplayMember = "type_name"
        Me.cmbType.ValueMember = "item_type"
    End Sub
    '设置子类型
    Private Sub setChildType()
        Dim ds As DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim strSql As String
        Dim strItemType As String = Me.cmbType.SelectedValue
        Me.cmbChildType.DataSource = Nothing
        Me.cmbChildType.Items.Clear()
        strSql = "{item_type like '" & strItemType & "'}"
        ds = gWs.GetItemEx(strSql)
        Me.cmbChildType.DataSource = ds.Tables(0)
        Me.cmbChildType.DisplayMember = "item_name"
        Me.cmbChildType.ValueMember = "item_code"
        If Me.cmbChildType.SelectedValue = "" Then
            Me.cmbChildType.Text = ""
            Exit Sub
        End If
    End Sub
    'cmbType_SelectValueChanged
    Private Sub cmbType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectedValueChanged
        If isLoad Then
            count = count + 1
        End If
        If nCurrentCount < count Then
        Else
            setChildType()
        End If
        nCurrentCount = nCurrentCount + 1

        If isNewBtnClick Then
            'Me.txtTitle.Text = Me.cmbType.Text & Me.cmbChildType.Text
            Dim dr As DataRow
            Dim i As Integer
            If Not dsFiles Is Nothing Then
                i = dsFiles.Tables("TProjectFile").Rows.Count
                If i > 0 Then
                    dr = dsFiles.Tables("TProjectFile").Rows(i - 1)
                    With dr
                        .Item("type") = Me.cmbType.Text
                        .Item("type_name") = Me.cmbChildType.Text
                        .Item("item_type") = Me.cmbType.SelectedValue
                        .Item("item_code") = Me.cmbChildType.SelectedValue
                        .Item("title") = Me.txtTitle.Text 'Me.cmbType.Text & Me.cmbChildType.Text
                    End With
                End If
            End If
        End If
    End Sub
    'cmbChildType_SelectedValueChanged
    Private Sub cmbChildType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbChildType.SelectedValueChanged
        If isNewBtnClick Then
            'Me.txtTitle.Text = Me.cmbType.Text & Me.cmbChildType.Text
            Dim dr As DataRow
            Dim i As Integer
            If Not dsFiles Is Nothing Then
                i = dsFiles.Tables("TProjectFile").Rows.Count
                If i > 0 Then
                    dr = dsFiles.Tables("TProjectFile").Rows(i - 1)
                    With dr
                        .Item("type") = Me.cmbType.Text
                        .Item("type_name") = Me.cmbChildType.Text
                        .Item("item_type") = Me.cmbType.SelectedValue
                        .Item("item_code") = Me.cmbChildType.SelectedValue
                        .Item("title") = Me.txtTitle.Text 'Me.cmbType.Text & Me.cmbChildType.Text
                    End With
                End If
            End If
        End If
    End Sub
    'cmbType_DropDown
    Private Sub cmbType_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.DropDown
        isLoad = False
    End Sub
    'cmbType_Enter
    Private Sub cmbType_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.Enter
        isLoad = False
    End Sub
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        frmExit(sender, e)
    End Sub
    '退出处理
    Private Function frmExit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '根据dataSet判断是否修改了
        Dim changedCount As Integer = 0
        If Not Me.dsFiles Is Nothing Then
            Try
                changedCount = Me.dsFiles.GetChanges.Tables(0).Rows.Count
            Catch
            End Try
        End If
        If changedCount > 0 Then
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
    '设置textbox的enable属性
    Private Sub setTextBox(ByVal isEnabled As Boolean)
        Me.txtTitle.Enabled = isEnabled
        Me.cmbType.Enabled = isEnabled
        Me.cmbChildType.Enabled = isEnabled
        Me.txtVersion.Enabled = isEnabled
        Me.txtRemark.Enabled = isEnabled
    End Sub
    '获得公司文件
    Private Function getCompanyFile()
        Return getCompanyFile("")
    End Function
    '获得公司文件
    Private Function getCompanyFile(ByVal flag As String)
        Dim ds As DataSet
        Dim dsItem As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strSql As String
        Dim strItemType As String
        If flag = "1" Then
            strSql = "{item_type like '6%'}"
        Else
            strSql = "{item_type like '6%' order by serial_num desc}"
        End If
        Try
            ds = gWs.GetProjectFileByCondition(strSql)
            ds.Tables("TProjectFile").Columns.Add("type", GetType(String))
            ds.Tables("TProjectFile").Columns.Add("type_name", GetType(String))
            ds.Tables("TProjectFile").Columns.Add("is_file", GetType(Boolean))
            Dim j As Integer
            j = ds.Tables("TProjectFile").Rows.Count
            For j = 0 To j - 1
                dr = ds.Tables("TProjectFile").Rows(j)
                With dr
                    strItemType = .Item("item_type")

                    .Item("type") = getItemName(strItemType)

                    dsItem = getItemDataSet(strItemType)

                    Dim str_item_code, str_item_type As String

                    str_item_code = .Item("item_code")
                    str_item_type = .Item("item_type")

                    .Item("type_name") = dsItem.Tables("TItem").Select("item_code='" & str_item_code & "' and item_type='" & str_item_type & "'")(0).Item("item_name")
                    '判断是否有文件
                    If Not .Item("relation_num") Is System.DBNull.Value Then
                        .Item("is_file") = True
                    Else
                        .Item("is_file") = False
                    End If
                End With
            Next
        Catch ex As Exception
        End Try
        Return ds
    End Function
    '
    '获得Item表的DataSet
    '
    Private Function getItemDataSet(ByVal strItemType As String) As DataSet
        Dim ds As DataSet
        Try
            ds = gWs.GetItem("{item_type='" & strItemType & "'}", Nothing)
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Return ds
    End Function
    '通过itemType，获得typeName
    Private Function getItemName(ByVal itemType As String) As String
        Dim ds As DataSet
        Dim i As Integer
        Try
            ds = gWs.GetItemType("{item_type='" & itemType & "'}")
            i = ds.Tables("TItemType").Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    With ds.Tables("TItemType").Rows(i)
                        Return .Item("type_name")
                    End With
                Next
            End If
        Catch ex As Exception
        End Try
    End Function
    'MouseUp
    Private Sub dgFiles_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgFiles.MouseUp
        If CType(Me.dgFiles.DataSource, DataTable).Rows.Count > 0 Then
            Me.dgFiles.Select(Me.dgFiles.CurrentCell.RowNumber)
            'setTextContent()
            setTextContent_1()
            setButton()
        End If
    End Sub
    '设置Text的值
    Private Sub setTextContent()
        Static lastCmbType As String
        If CType(Me.dgFiles.DataSource, DataTable).Rows.Count > 0 Then
            Dim index As Integer
            Dim dr As DataRow
            index = Me.dgFiles.CurrentRowIndex
            currentIndex = index
            dr = CType(Me.dgFiles.DataSource, DataTable).Rows(index)
            With dr
                Me.txtTitle.Text = IIf(.Item("title") Is System.DBNull.Value, "", .Item("title"))
                Me.txtVersion.Text = IIf(.Item("version") Is System.DBNull.Value, "", .Item("version"))
                Me.cmbType.SelectedValue = .Item("item_type")
                If Not lastCmbType = Me.cmbType.SelectedValue Then
                    setChildType()
                End If
                Me.cmbChildType.SelectedValue = .Item("item_code")
                Me.txtRemark.Text = IIf(.Item("remark") Is System.DBNull.Value, "", .Item("remark"))
            End With
        End If
        lastCmbType = Me.cmbType.SelectedValue
    End Sub
    '设置Text的值
    Private Sub setTextContent_1()
        Static lastCmbType As String
        If CType(Me.dgFiles.DataSource, DataTable).Rows.Count > 0 Then
            Dim index As Integer
            Dim dr As DataRow
            index = Me.dgFiles.CurrentRowIndex
            currentIndex = index
            'dr = CType(Me.dgFiles.DataSource, DataTable).Rows(index)
            'With dr
            Me.txtTitle.Text = IIf(Me.dgFiles.Item(index, 0) Is System.DBNull.Value, "", Me.dgFiles.Item(index, 0))
            Me.txtVersion.Text = IIf(Me.dgFiles.Item(index, 5) Is System.DBNull.Value, "", Me.dgFiles.Item(index, 5))
            Me.cmbType.SelectedValue = IIf(Me.dgFiles.Item(index, 7) Is System.DBNull.Value, "", Me.dgFiles.Item(index, 7))
            If Not lastCmbType = Me.cmbType.SelectedValue Then
                setChildType()
            End If
            Me.cmbChildType.SelectedValue = IIf(Me.dgFiles.Item(index, 8) Is System.DBNull.Value, "", Me.dgFiles.Item(index, 8))
            Me.txtRemark.Text = IIf(Me.dgFiles.Item(index, 4) Is System.DBNull.Value, "", Me.dgFiles.Item(index, 4))
            'End With
        End If
        lastCmbType = Me.cmbType.SelectedValue
    End Sub
    '
    '对选中记录上载某个文件保存到数据库
    '从project_files获得serial_num，再从project_document获得file_relation_num
    '注：file_relation_num在新增时就从relation_num表获得,保存在project_document中
    '
    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Me.Cursor = Cursors.WaitCursor

        Dim index As Integer
        Dim strItemType, strItemCode As String
        Dim strSerialNum As String
        Dim strRelationNum As String = System.DBNull.Value.ToString
        index = dgFiles.CurrentRowIndex
        Try
            If index < 0 Then
                Exit Sub
            End If
            If Not Me.dgFiles.Item(index, 12) Is System.DBNull.Value Then
                'If Not dsFiles.Tables(0).Rows(index).Item("serial_num") Is System.DBNull.Value Then
                '    strSerialNum = dsFiles.Tables(0).Rows(index).Item("serial_num")
                '    strItemType = dsFiles.Tables(0).Rows(index).Item("item_type")
                '    strItemCode = dsFiles.Tables(0).Rows(index).Item("item_code")
                '    strRelationNum = getRelationNumber()
                strSerialNum = Me.dgFiles.Item(index, 12)
                strItemType = IIf(Me.dgFiles.Item(index, 7) Is System.DBNull.Value, "", Me.dgFiles.Item(index, 7))
                strItemCode = IIf(Me.dgFiles.Item(index, 8) Is System.DBNull.Value, "", Me.dgFiles.Item(index, 8))
                strRelationNum = getRelationNumber()
            Else
                'MsgBox("该记录未保存!不能上载文件.", MsgBoxStyle.Exclamation, "提示")
                SWDialogBox.MessageBox.Show("$X020")
                Exit Sub
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try

        '调用类frmDocumentClass中的上载文件的方法uploadDocument()
        Dim docClass As New frmDocumentClass("")
        Dim strResult As String
        strResult = docClass.uploadDocument(strSerialNum, strRelationNum, True, True)
        If strResult = "1" Then
            dsFiles = getCompanyFile()
            If Not dsFiles Is System.DBNull.Value Then
                Me.dgFiles.DataSource = dsFiles.Tables("TProjectFile")
                Me.dsFiles.AcceptChanges()
                setDgAttribute(Me.dgFiles, Me)
                Me.bmDocument = Me.BindingContext(dsFiles, "TProjectFile")
            End If
            'Me.dgFiles.Item(index, 3) = True
            'Me.dgFiles.Item(index, 9) = strRelationNum
            'Me.dgFiles.DataSource = dsFiles.Tables("TProjectFile")
            'Me.dsFiles.AcceptChanges()
            setButton()
        End If
    End Sub
    '
    '从表number中获得最大数,供relation_num用
    '
    Protected Function getRelationNumber() As String
        If Not gWs Is Nothing Then
            Try
                Return gWs.GetRelationID()
            Catch ex As Exception
            End Try
        End If
    End Function
    '
    '打开当前选中的记录的文件
    '
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click

        Dim index As Integer
        Dim strRelationNum As String
        Dim strSerialNum As String
        index = dgFiles.CurrentRowIndex
        If index < 0 Then
            Exit Sub
        End If
        Dim strTitle As String
        strTitle = dsFiles.Tables(0).Rows(index).Item("title")
        If Not Me.dgFiles.Item(index, 9) Is System.DBNull.Value Then '由于DataGrid允许排序,故必须按照dataGrid.item(*,*)来取得值
            'If Not dsFiles.Tables(0).Rows(index).Item("relation_num") Is System.DBNull.Value Then
            'strRelationNum = dsFiles.Tables(0).Rows(index).Item("relation_num")
            'strSerialNum = dsFiles.Tables(0).Rows(index).Item("serial_num")
            strRelationNum = Me.dgFiles.Item(index, 9)
            strSerialNum = Me.dgFiles.Item(index, 12)
        Else
            'MsgBox("该记录未保存文件内容!不能打开文件.", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$X019")
            Exit Sub
        End If
        If Not System.IO.Directory.Exists(Application.StartupPath & strDir) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & strDir)
        Else
            delAllFiles(Application.StartupPath & strDir)
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            'Dim docClass As New frmDocumentClass(strTitle)'传入Title+文件名.doc
            Dim docClass As New frmDocumentClass("")
            docClass.openFileBySerial(strSerialNum, strDir)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '设置按钮的Enabled属性
    Private Sub setButton()
        Dim index As Integer
        If CType(Me.dgFiles.DataSource, DataTable).Rows.Count <= 0 Then
            Me.btnOpen.Enabled = False
            Me.btnUpload.Enabled = False
            Me.btnDelete.Enabled = False
            Me.btnModify.Enabled = False
            Exit Sub
        End If
        index = Me.dgFiles.CurrentRowIndex
        If Me.dgFiles.Item(index, 9) Is System.DBNull.Value Then
            Me.btnOpen.Enabled = False
        Else
            Me.btnOpen.Enabled = True
        End If
    End Sub
    '删除
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Not Me.dsFiles Is Nothing Then
            'If MsgBoxResult.OK = MsgBox("确定删除选中的记录吗?", MsgBoxStyle.Question + MsgBoxStyle.OKCancel, "提示") Then
            If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1004", "选中的") Then
                Dim i As Integer
                i = Me.dgFiles.CurrentRowIndex
                If i >= 0 Then
                    With Me.dsFiles.Tables("TProjectFile").Rows(i)
                        .Delete()
                    End With
                    Try
                        gWs.UpdateProjectFile(Me.dsFiles.GetChanges())
                    Catch
                    End Try
                    dsFiles = getCompanyFile()
                    If Not dsFiles Is System.DBNull.Value Then
                        dgFiles.DataSource = dsFiles.Tables("TProjectFile")
                        setDgAttribute(Me.dgFiles, Me)
                        Me.dsFiles.AcceptChanges()
                    End If
                    Try
                        Me.bmDocument = Me.BindingContext(dsFiles, "TProjectFile")
                    Catch ex As Exception
                        'MsgBox(ex.Message)
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End If
            End If
            setButton()
        End If
    End Sub
    '新增
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            If Not dsFiles Is System.DBNull.Value Then
                If btnNew.Text = "新 增(&N)" Then
                    setTextBox(True)
                    Me.txtTitle.Focus()
                    delBinding()
                    addBinding()
                    addDocumentRecord()
                    isNewBtnClick = True
                    btnNew.Text = "取 消(&C)"
                    setNewButton(False)
                    Me.btnOpen.Enabled = False
                ElseIf btnNew.Text = "取 消(&C)" Then
                    Dim index As Integer = dsFiles.Tables("TProjectFile").Rows.Count - 1
                    If index >= 0 Then
                        Dim strMaterialName As String
                        strMaterialName = dsFiles.Tables("TProjectFile").Rows(index).Item("title")
                        btnNew.Text = "新 增(&N)"
                        setNewButton(True)
                        setTextBox(False)
                        delBinding()
                        isNewBtnClick = False

                        Me.dsFiles.RejectChanges()
                        Me.dgFiles.DataSource = Me.dsFiles.Tables("TProjectFile")
                        Try
                            Me.bmDocument = Me.BindingContext(dsFiles, "TProjectFile")
                        Catch ex As Exception
                            'MsgBox(ex.Message)
                            ExceptionHandler.ShowMessageBox(ex)
                        End Try
                    End If
                    setButton()
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '
    '添加绑定
    '
    Private Sub addBinding()
        Me.txtTitle.DataBindings.Add("Text", Me.dsFiles.Tables("TProjectFile"), "title")
        Me.txtVersion.DataBindings.Add("Text", Me.dsFiles.Tables("TProjectFile"), "version")
        Me.txtRemark.DataBindings.Add("Text", Me.dsFiles.Tables("TProjectFile"), "remark")
        Me.cmbType.DataBindings.Add("Text", Me.dsFiles.Tables("TProjectFile"), "type")
        Me.cmbChildType.DataBindings.Add("Text", Me.dsFiles.Tables("TProjectFile"), "type_name")
    End Sub
    '
    '删除绑定
    '
    Private Sub delBinding()
        Me.txtTitle.DataBindings.Clear()
        Me.txtVersion.DataBindings.Clear()
        Me.txtRemark.DataBindings.Clear()
        Me.cmbType.DataBindings.Clear()
        Me.cmbChildType.DataBindings.Clear()
    End Sub
    '
    '向project_file表中新增一条记录
    '
    Private Sub addDocumentRecord()
        Me.txtTitle.Text = ""
        Me.txtVersion.Text = "1.0"
        Me.txtRemark.Text = ""
        Me.cmbType.SelectedIndex = 0
        setChildType()
        'Me.cmbChildType.SelectedIndex = 0
        Dim dr As DataRow
        Dim itemType, itemCode As String
        'If Not Me.txtTitle.Text = "" Then
        dr = dsFiles.Tables("TProjectFile").NewRow
        itemType = Me.cmbType.SelectedValue
        itemCode = Me.cmbChildType.SelectedValue
        With dr
            '.Item("project_code") = strProjectCode
            .Item("item_type") = itemType
            .Item("item_code") = itemCode
            .Item("title") = Me.txtTitle.Text
            .Item("version") = Me.txtVersion.Text
            .Item("remark") = Me.txtRemark.Text
            .Item("type") = Me.cmbType.Text
            .Item("type_name") = Me.cmbChildType.Text
            .Item("is_file") = False
            .Item("create_person") = UserName
            Try
                .Item("create_date") = gWs.GetSysTime()
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End With
        dsFiles.Tables("TProjectFile").Rows.Add(dr)

        If Not dsFiles Is System.DBNull.Value Then
            Me.bmDocument = Me.BindingContext(dsFiles, "TProjectFile")
            Me.dgFiles.CurrentRowIndex = Me.bmDocument.Count - 1
        End If
        'Else
        'MsgBox("请输入标题的内容!", MsgBoxStyle.Exclamation, "提示")
        'Me.txtTitle.Focus()
        'End If
    End Sub
    '新增时，设置其他按钮的Enabled属性
    Private Sub setNewButton(ByVal flag As Boolean)
        Me.dgFiles.Enabled = flag
        Me.btnDelete.Enabled = flag
        Me.btnModify.Enabled = flag
        Me.btnUpload.Enabled = flag
        Me.btnOpen.Enabled = flag
    End Sub
    '修改
    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        If Not Me.dsFiles Is Nothing Then
            If btnModify.Text = "修 改(&M)" Then
                setTextBox(True)
                Me.btnDelete.Enabled = False
                Me.btnNew.Enabled = False
                Me.btnOpen.Enabled = False
                Me.btnUpload.Enabled = False
                Me.cmbType.Enabled = False
                Me.cmbChildType.Enabled = False
                Me.dgFiles.Enabled = False
                currentIndex = Me.dgFiles.CurrentRowIndex
                Me.dgFiles.Select(currentIndex)
                Me.cmbType.Focus()
                delBinding()
                addBinding()
                btnModify.Text = "取 消(&C)"
            ElseIf btnModify.Text = "取 消(&C)" Then
                Me.btnDelete.Enabled = True
                Me.btnNew.Enabled = True
                Me.btnOpen.Enabled = True
                Me.btnUpload.Enabled = True
                Me.dgFiles.Enabled = True
                setTextBox(False)
                btnModify.Text = "修 改(&M)"
                Me.dsFiles.RejectChanges()
                Me.dgFiles.Refresh()
                delBinding()
                setButton()
            End If
        End If
    End Sub
    '保存
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            btnNew.Text = "新 增(&N)"
            btnModify.Text = "修 改(&M)"
            Me.dgFiles.Enabled = True
            Me.btnNew.Enabled = True
            Me.btnModify.Enabled = True
            Me.btnDelete.Enabled = True
            Me.btnUpload.Enabled = True
            Me.btnOpen.Enabled = True
            setTextBox(False)
            delBinding()
            isNewBtnClick = False
            Dim strResult As String = "1"
            Dim isChanged As Boolean = False
            Me.dgFiles.CurrentRowIndex = currentIndex
            isChanged = dsFiles.HasChanges
            If isChanged Then
                Try
                    strResult = gWs.UpdateProjectFile(dsFiles.GetChanges())
                Catch ex As Exception
                    'MsgBox(ex.Message)
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
            End If
            If "1" = strResult Then
                'MsgBox("保存成功!", MsgBoxStyle.Information, "提示")
                SWDialogBox.MessageBox.Show("$SaveSucceed")
                If isChanged Then
                    'dsFiles.Clear()
                    dsFiles = getCompanyFile()
                    If Not dsFiles Is System.DBNull.Value Then
                        Me.dgFiles.DataSource = dsFiles.Tables("TProjectFile")
                        setDgAttribute(Me.dgFiles, Me)
                        Me.dsFiles.AcceptChanges()
                        Me.bmDocument = Me.BindingContext(dsFiles, "TProjectFile")
                    End If
                End If
            Else
                'MsgBox("保存失败!" & strResult, MsgBoxStyle.Critical, "提示")
                SWDialogBox.MessageBox.Show("*999", "", strResult, "")
            End If
            setButton()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
End Class
