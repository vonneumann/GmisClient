

Public Class frmDocumentSystem
    Inherits MainInterface.frmBasic

    Private strProjectCode, strCorporationName As String
    Private strItemType As String
    Private strDir As String = "\Document\"
    Dim isProjectCodeEmpty As Boolean '如果项目编码不为空,则其他条件排除

    Private count As Integer = 0
    Private nCurrentCount As Integer = 0
    Private isLoad As Boolean = False
    Private flag As Boolean = False '选择子类型

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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents cmbFileType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents dgContent As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbPerson As System.Windows.Forms.ComboBox
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbChildType As System.Windows.Forms.ComboBox
    Friend WithEvents dateCreateStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents chbDate As System.Windows.Forms.CheckBox
    Friend WithEvents dateCreateEnd As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDocumentSystem))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dateCreateStart = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chbDate = New System.Windows.Forms.CheckBox()
        Me.dateCreateEnd = New System.Windows.Forms.DateTimePicker()
        Me.cmbChildType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbPerson = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbFileType = New System.Windows.Forms.ComboBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgContent = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnView = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgContent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(370, 472)
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dateCreateStart, Me.Label3, Me.Label8, Me.chbDate, Me.dateCreateEnd, Me.cmbChildType, Me.Label7, Me.cmbPerson, Me.Label6, Me.btnQuery, Me.txtFileName, Me.Label5, Me.cmbFileType, Me.txtName, Me.txtCode, Me.Label4, Me.Label2, Me.Label1})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(696, 120)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询条件"
        '
        'dateCreateStart
        '
        Me.dateCreateStart.Location = New System.Drawing.Point(112, 19)
        Me.dateCreateStart.Name = "dateCreateStart"
        Me.dateCreateStart.Size = New System.Drawing.Size(120, 21)
        Me.dateCreateStart.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(40, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 23)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "创建日期起"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(264, 18)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 23)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "创建日期止"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chbDate
        '
        Me.chbDate.Location = New System.Drawing.Point(16, 17)
        Me.chbDate.Name = "chbDate"
        Me.chbDate.Size = New System.Drawing.Size(16, 24)
        Me.chbDate.TabIndex = 29
        '
        'dateCreateEnd
        '
        Me.dateCreateEnd.Location = New System.Drawing.Point(336, 19)
        Me.dateCreateEnd.Name = "dateCreateEnd"
        Me.dateCreateEnd.Size = New System.Drawing.Size(112, 21)
        Me.dateCreateEnd.TabIndex = 27
        '
        'cmbChildType
        '
        Me.cmbChildType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChildType.Location = New System.Drawing.Point(336, 96)
        Me.cmbChildType.Name = "cmbChildType"
        Me.cmbChildType.Size = New System.Drawing.Size(121, 20)
        Me.cmbChildType.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(280, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 23)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "子 类 型"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPerson
        '
        Me.cmbPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPerson.Location = New System.Drawing.Point(64, 72)
        Me.cmbPerson.Name = "cmbPerson"
        Me.cmbPerson.Size = New System.Drawing.Size(168, 20)
        Me.cmbPerson.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 23)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "创 建 人"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuery.ImageIndex = 3
        Me.btnQuery.ImageList = Me.ImageListBasic
        Me.btnQuery.Location = New System.Drawing.Point(608, 16)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(77, 24)
        Me.btnQuery.TabIndex = 8
        Me.btnQuery.Text = "查 询(&Q)"
        Me.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFileName
        '
        Me.txtFileName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtFileName.Location = New System.Drawing.Point(336, 72)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(352, 21)
        Me.txtFileName.TabIndex = 5
        Me.txtFileName.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(280, 72)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "文档名称"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbFileType
        '
        Me.cmbFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFileType.Location = New System.Drawing.Point(64, 96)
        Me.cmbFileType.Name = "cmbFileType"
        Me.cmbFileType.Size = New System.Drawing.Size(168, 20)
        Me.cmbFileType.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtName.Location = New System.Drawing.Point(336, 48)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(352, 21)
        Me.txtName.TabIndex = 1
        Me.txtName.Text = ""
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 48)
        Me.txtCode.MaxLength = 9
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(168, 21)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "文档类型"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(280, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgContent})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(696, 328)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "查询结果"
        '
        'dgContent
        '
        Me.dgContent.CaptionVisible = False
        Me.dgContent.DataMember = ""
        Me.dgContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgContent.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgContent.Location = New System.Drawing.Point(3, 17)
        Me.dgContent.Name = "dgContent"
        Me.dgContent.ReadOnly = True
        Me.dgContent.Size = New System.Drawing.Size(690, 308)
        Me.dgContent.TabIndex = 0
        Me.dgContent.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgContent
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn5, Me.DataGridBoolColumn1, Me.DataGridTextBoxColumn4, Me.DataGridBoolColumn2, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TProjectDocument"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn1.MappingName = "project_code"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "文档名称"
        Me.DataGridTextBoxColumn2.MappingName = "doc_name"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 300
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "创建时间"
        Me.DataGridTextBoxColumn3.MappingName = "create_date"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "创建人"
        Me.DataGridTextBoxColumn5.MappingName = "create_person"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.AllowNull = False
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "有文件"
        Me.DataGridBoolColumn1.MappingName = "is_file"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), System.DBNull)
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "备注"
        Me.DataGridTextBoxColumn4.MappingName = "remark"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 150
        '
        'DataGridBoolColumn2
        '
        Me.DataGridBoolColumn2.AllowNull = False
        Me.DataGridBoolColumn2.FalseValue = False
        Me.DataGridBoolColumn2.HeaderText = "关键"
        Me.DataGridBoolColumn2.MappingName = "is_important"
        Me.DataGridBoolColumn2.NullText = "False"
        Me.DataGridBoolColumn2.NullValue = CType(resources.GetObject("DataGridBoolColumn2.NullValue"), System.DBNull)
        Me.DataGridBoolColumn2.TrueValue = True
        Me.DataGridBoolColumn2.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.MappingName = "file_relation_num"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "file_relation"
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'btnView
        '
        Me.btnView.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Bitmap)
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.ImageIndex = 17
        Me.btnView.ImageList = Me.ImageListBasic
        Me.btnView.Location = New System.Drawing.Point(265, 472)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(93, 24)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "打开文档(&V)"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmDocumentSystem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 503)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnView, Me.GroupBox2, Me.GroupBox1})
        Me.Name = "frmDocumentSystem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "项目文档查询"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmDocumentSystem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isLoad = True
        Try
            Me.dateCreateStart.Value = gWs.GetSysTime()
            Me.dateCreateEnd.Value = gWs.GetSysTime()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        Me.dateCreateStart.Enabled = False
        Me.dateCreateEnd.Enabled = False
        Me.btnView.Enabled = False
        bindingDocType()
        flag = True
        bindingPerson()
    End Sub
    '绑定itemType表中的文件类型
    Private Sub bindingDocType()
        Dim ds As DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim strSql As String
        strSql = "{item_type like '43' or item_type like '45'}"
        Try
            ds = gWs.GetItemType(strSql)
            dt = ds.Tables(0)
            dr = dt.NewRow
            With dr
                .Item("item_type") = "**"
                .Item("type_name") = ""
                .Item("additional_remark") = ""
                .Item("item_type_belong") = ""
                .Item("remark") = ""
            End With
            dt.Rows.InsertAt(dr, 0)
        Catch ex As Exception
        End Try
        Me.cmbFileType.DataSource = ds.Tables(0)
        Me.cmbFileType.DisplayMember = "type_name"
        Me.cmbFileType.ValueMember = "item_type"
    End Sub
    '获得子类型
    Private Sub setChileType()
        Dim ds As DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim strSql As String
        Dim strItemType As String = Me.cmbFileType.SelectedValue
        Me.cmbChildType.DataSource = Nothing
        Me.cmbChildType.Items.Clear()
        If strItemType = "**" Then
            Me.cmbChildType.Text = ""
            Exit Sub
        End If
        strSql = "{item_type like '" & strItemType & "'}"
        ds = gWs.GetItemEx(strSql)
        dt = ds.Tables(0)
        Try
            dr = dt.NewRow
            With dr
                .Item("item_type") = strItemType
                .Item("item_code") = ""
                .Item("item_name") = ""
                .Item("additional_remark") = ""
                .Item("item_type_remark") = ""
            End With
            dt.Rows.InsertAt(dr, 0)
        Catch ex As Exception
        End Try
        Me.cmbChildType.DataSource = ds.Tables(0)
        Me.cmbChildType.DisplayMember = "item_name"
        Me.cmbChildType.ValueMember = "item_code"
        If Me.cmbChildType.SelectedValue = "" Then
            Me.cmbChildType.Text = ""
            Exit Sub
        End If
    End Sub
    '创建人
    Private Sub bindingPerson()
        Dim ds As DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Try
            ds = gWs.GetStaff("%")
            dt = ds.Tables("TStaff")
            dr = dt.NewRow
            With dr
                .Item("staff_name") = ""
                .Item("staff_code") = ""
                .Item("dept_name") = ""
                .Item("branch_name") = ""
                .Item("read_logs_right") = ""
            End With
            dt.Rows.InsertAt(dr, 0)
        Catch ex As Exception
        End Try
        Me.cmbPerson.DataSource = ds.Tables("TStaff")
        Me.cmbPerson.DisplayMember = "staff_name"
        Me.cmbPerson.ValueMember = "staff_name"
    End Sub
    '获取查询条件
    Private Function getQueryCondition()
        Dim strCode As String
        Dim strName, strCode_Name As String
        Dim strDate, strNextDate As String
        Dim strFileType, strItemType, strItemCode As String
        Dim strFileName As String
        Dim strPerson As String
        Dim strSql As String
        If Me.txtCode.Text.Trim = "" Then
            strCode = "%"
            isProjectCodeEmpty = False
        Else
            strCode = Me.txtCode.Text
            isProjectCodeEmpty = True
        End If
        If Me.txtName.Text.Trim = "" Or isProjectCodeEmpty Then
            strCode_Name = "%"
        Else
            strName = Me.txtName.Text
            strCorporationName = strName
            Dim ds As DataSet
            Dim dr As DataRow
            Dim i As Integer
            Try
                strSql = "{EnterpriseName like '%" & strName & "%'}"
                ds = gWs.GetProjectInfoEx(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        strCode_Name = IIf(.Item("ProjectCode") Is System.DBNull.Value, "%", .Item("ProjectCode"))
                        strProjectCode = strCode_Name
                        strCorporationName = IIf(.Item("EnterpriseName") Is System.DBNull.Value, strName, .Item("EnterpriseName"))
                    End With
                End If
            Catch ex As Exception
            Finally
                Me.Cursor = System.Windows.Forms.Cursors.Default
            End Try
        End If
        If Not Me.chbDate.Checked Or isProjectCodeEmpty Then
            strDate = "1970-1-1"
            strNextDate = "2080-1-1"
        Else
            strDate = Me.dateCreateStart.Value
            strNextDate = Me.dateCreateEnd.Value
            determineDate(strDate, strNextDate)
        End If
        If Me.cmbFileType.Text.Trim = "" Or isProjectCodeEmpty Then
            strItemType = "%"
            strItemCode = "%"
        Else
            strItemType = Me.cmbFileType.SelectedValue
            strItemCode = Me.cmbChildType.SelectedValue
            If strItemCode = "" Then
                strItemCode = "%"
            End If
        End If
        If Me.cmbPerson.Text = "" Or isProjectCodeEmpty Then
            strPerson = "%"
        Else
            strPerson = Me.cmbPerson.Text
        End If
        If Me.txtFileName.Text.Trim = "" Or isProjectCodeEmpty Then
            strFileName = ""
        Else
            strFileName = Me.txtFileName.Text
        End If
        strSql = "{(project_code like '" & strCode & "' and project_code like '" _
        & strCode_Name & "') and create_date >= '" & strDate & "' and create_date <= '" & strNextDate & "'" & _
        " and item_type like'" & strItemType & "' and item_code like'" & strItemCode & "' and doc_name like '%" & strFileName & "%'" & _
        " and create_person like '" & strPerson & "'and (item_type='43' or item_type='45')}"
        Return strSql
    End Function
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
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
    '查询
    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim strCondition As String
            Dim strRelationNum As String
            Dim i As Integer
            Dim dsContent As DataSet
            Dim dt As DataTable
            Dim dsItem As DataSet
            strCondition = Me.getQueryCondition()
            dsContent = gWs.GetProjectDocumentByCondition(strCondition)
            dsContent.Tables(0).Columns.Add("file_relation", GetType(String))
            i = dsContent.Tables(0).Rows.Count
            'For i = 0 To i - 1
            '    strRelationNum = dsContent.Tables(0).Rows(i).Item("file_relation_num")
            '    If gWs.GetProjectFileByCondition("{relation_num='" & strRelationNum & "'}").Tables(0).Rows.Count > 0 Then
            '        dsContent.Tables(0).Rows(i).Item("file_relation") = strRelationNum
            '    End If
            'Next
            If Not dsContent Is Nothing Then
                Me.dgContent.DataSource = dsContent.Tables(0)
            End If
            If Not Me.txtName.Text = "" Then
                Me.txtName.Text = strCorporationName
                Me.txtCode.Text = strProjectCode
            End If
            dgContent_MouseUp(Nothing, Nothing)
            'setButton()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    'MouseUp
    Private Sub dgContent_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgContent.MouseUp
        If Me.dgContent.DataSource Is Nothing Then
            Exit Sub
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            If CType(Me.dgContent.DataSource, DataTable).Rows.Count > 0 Then
                Dim strRelationNum As String
                Dim i As Integer
                Dim dtContent As DataTable
                i = Me.dgContent.CurrentCell.RowNumber
                Me.dgContent.Select(Me.dgContent.CurrentCell.RowNumber)

                '判断是否有查看该文档的权限
                If isAllowViewDocument() Then
                    dtContent = CType(Me.dgContent.DataSource, DataTable)
                    strRelationNum = dtContent.Rows(i).Item("file_relation_num")
                    If gWs.GetProjectFileByCondition("{relation_num='" & strRelationNum & "'}").Tables(0).Rows.Count > 0 Then
                        Me.dgContent.Item(i, 8) = strRelationNum
                        'dtContent.Rows(i).Item("file_relation") = strRelationNum
                    End If
                    setButton()
                Else
                    Me.btnView.Enabled = False
                End If
            End If
            'setButton()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '打开文档
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim strRelationNum As String
        strRelationNum = IIf(Me.dgContent.Item(Me.dgContent.CurrentCell.RowNumber, 7) Is System.DBNull.Value, "", Me.dgContent.Item(Me.dgContent.CurrentCell.RowNumber, 7))
        Dim docClass As New frmDocumentClass()
        docClass.setIsDocument(True)
        docClass.openFileByRelation(strRelationNum, strDir)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    '根据file_relation_num是否为空设置按钮"打开文档"的Enabled属性
    Private Sub setButton()
        Dim isFiles As Boolean
        If CType(Me.dgContent.DataSource, DataTable).Rows.Count > 0 Then
            If Me.dgContent.Item(Me.dgContent.CurrentCell.RowNumber, 7) Is System.DBNull.Value Then
                Me.btnView.Enabled = False
            Else
                If Not Me.dgContent.Item(Me.dgContent.CurrentCell.RowNumber, 8) Is System.DBNull.Value Then
                    Me.btnView.Enabled = True
                Else
                    Me.btnView.Enabled = False
                End If
            End If
        Else
            Me.btnView.Enabled = False
        End If
    End Sub
    '如果打勾则不作为查询条件
    Private Sub chbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbDate.CheckedChanged
        If Not chbDate.Checked Then
            Me.dateCreateStart.Enabled = False
            Me.dateCreateEnd.Enabled = False
        Else
            Me.dateCreateStart.Enabled = True
            Me.dateCreateEnd.Enabled = True
        End If
    End Sub

    Private Sub cmbFileType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFileType.SelectedValueChanged
        flag = False
        If isLoad Then
            count = count + 1
        End If
        If nCurrentCount < count Then
        Else
            setChileType()
            flag = True
            btnQuery_Click(sender, e)
        End If
        nCurrentCount = nCurrentCount + 1
    End Sub

    Private Sub cmbFileType_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFileType.DropDown
        isLoad = False
    End Sub

    Private Sub cmbFileType_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFileType.Enter
        isLoad = False
    End Sub
    '选择子类型
    Private Sub cmbChildType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbChildType.SelectedValueChanged
        If flag Then
            btnQuery_Click(sender, e)
        End If
    End Sub

    Private Sub frmDocumentSystem_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        setEnterKeyPress(sender, e)
    End Sub
    '判断起始和截止日期
    Private Sub determineDate(ByVal dateStart As Date, ByVal dateEnd As Date)
        If dateStart > dateEnd Then
            'MsgBox("截止日期必须大于或等于起始日期", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1008", "起始日期", "截止日期")
        End If
    End Sub
    '判断是否有查看该文档的权限
    Private Function isAllowViewDocument()
        Dim strCreatePerson As String
        Dim projectCode As String
        Dim strSql As String
        Dim currentIndex As Integer
        Dim bHaveRight, isManger As Boolean
        Dim ds As DataSet

        Try
            '评委可以查看所有文档,"26"表示评委
            strSql = "{staff_name=" & "'" & UserName & "' AND Role_id = '26'" & "}"
            ds = gWs.GetStaffByRoleID(strSql)
            If ds.Tables(0).Rows.Count <> 0 OrElse isBranchManager() Then
                bHaveRight = True
            End If

            '当前选中的行号
            currentIndex = Me.dgContent.CurrentRowIndex

            '是否四该项目的项目经理
            projectCode = Me.dgContent.Item(currentIndex, 0)
            isManger = isProjectManager(projectCode, UserName)

            '在tableStyle中第三个item是"创建人"
            strCreatePerson = Me.dgContent.Item(currentIndex, 3)
            '只有当前用户为项目经理或自己创建的文档或者是评委才可以查看
            If UserName = strCreatePerson OrElse bHaveRight OrElse isManger Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Function
    '是否是该项目的项目经理(A,B)
    Private Function isProjectManager(ByVal projectCode As String, ByVal strPerson As String)
        Dim dsProjectTaskAttendee As DataSet
        Dim drProjectTaskAttendee As DataRow
        Dim k, nloop As Integer
        Dim strABManager As String

        ' "role_id='24' or role_id='25'"分别代表项目经理A,B
        Try
            strABManager = "{projectcode='" & projectCode & "'}"
            dsProjectTaskAttendee = gWs.GetProjectInfoEx(strABManager)
            k = dsProjectTaskAttendee.Tables(0).Rows.Count
            If k > 0 Then
                drProjectTaskAttendee = dsProjectTaskAttendee.Tables(0).Rows(0)
                With drProjectTaskAttendee
                    If .Item("24") = strPerson Or .Item("25") = strPerson Then
                        Return True
                    Else
                        Return False
                    End If
                End With
            Else
                Return False
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '判断是否是某个分部的部门负责人,且该文档是该部门创建的.
    Private Function isBranchManager()
        Dim ds, dsStaff, dsDept As DataSet
        Dim strSql, strStaffDept, strDept As String
        Dim i, count As Integer

        Try
            '"29"表示项目分配人员
            strSql = "{staff_name=" & "'" & UserName & "' AND Role_id = '29'" & "}"
            ds = gWs.GetStaffByRoleID(strSql)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                '如果是项目分配人员,且其所属部门与该项目文档的创建部门相同,则返回True
                If count > 0 Then
                    dsStaff = gWs.GetStaff("{staff_name='" & UserName & "'}")
                    dsDept = gWs.FetchProjectCorporationEx("{ProjectCode='" & strProjectCode & "'}")
                    If Not dsStaff Is Nothing Then
                        If dsStaff.Tables(0).Rows.Count > 0 Then
                            strStaffDept = dsStaff.Tables(0).Rows(0).Item("dept_name")
                        End If
                    End If
                    If Not dsDept Is Nothing Then
                        If dsDept.Tables(0).Rows.Count > 0 Then
                            strDept = dsDept.Tables(0).Rows(0).Item("branch_name")
                        End If
                    End If
                    If strStaffDept.Trim = strDept.Trim Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            Else
                Return False
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
End Class
