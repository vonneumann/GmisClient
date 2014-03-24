

Public Class frmCompanyFileQuery
    Inherits MainInterface.frmBasic

    Private count As Integer = 0
    Private nCurrentCount As Integer = 0
    Private isLoad As Boolean = False
    Private strDir As String = "\Document\"
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents cmbChildType As System.Windows.Forms.ComboBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtVersion As System.Windows.Forms.TextBox
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents dgContent As System.Windows.Forms.DataGrid
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCompanyFileQuery))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.cmbChildType = New System.Windows.Forms.ComboBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgContent = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
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
        Me.btnExit.Location = New System.Drawing.Point(368, 472)
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnQuery, Me.txtVersion, Me.txtTitle, Me.cmbChildType, Me.cmbType, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(686, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询条件"
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuery.ImageIndex = 3
        Me.btnQuery.ImageList = Me.ImageListBasic
        Me.btnQuery.Location = New System.Drawing.Point(600, 48)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(77, 24)
        Me.btnQuery.TabIndex = 4
        Me.btnQuery.Text = "查 询(&Q)"
        Me.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtVersion
        '
        Me.txtVersion.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtVersion.Location = New System.Drawing.Point(312, 48)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(136, 21)
        Me.txtVersion.TabIndex = 3
        Me.txtVersion.Text = ""
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtTitle.Location = New System.Drawing.Point(312, 16)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(368, 21)
        Me.txtTitle.TabIndex = 2
        Me.txtTitle.Text = ""
        '
        'cmbChildType
        '
        Me.cmbChildType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbChildType.Location = New System.Drawing.Point(64, 48)
        Me.cmbChildType.Name = "cmbChildType"
        Me.cmbChildType.Size = New System.Drawing.Size(144, 20)
        Me.cmbChildType.TabIndex = 1
        '
        'cmbType
        '
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Location = New System.Drawing.Point(64, 16)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(144, 20)
        Me.cmbType.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(256, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "版 本 号 "
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(256, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "文件标题"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "子 类 型"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "文件类型"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgContent})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(686, 368)
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
        Me.dgContent.Size = New System.Drawing.Size(680, 348)
        Me.dgContent.TabIndex = 0
        Me.dgContent.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgContent
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridBoolColumn1, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn2})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TProjectFile"
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.MappingName = "relation_num"
        Me.DataGridTextBoxColumn6.Width = 0
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
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "文件类型"
        Me.DataGridTextBoxColumn7.MappingName = "type"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "子类型"
        Me.DataGridTextBoxColumn8.MappingName = "type_name"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 75
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
        Me.DataGridBoolColumn1.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "版本"
        Me.DataGridTextBoxColumn9.MappingName = "version"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "文件名"
        Me.DataGridTextBoxColumn3.MappingName = "file_name"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "创建人"
        Me.DataGridTextBoxColumn4.MappingName = "create_person"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "创建日期"
        Me.DataGridTextBoxColumn5.MappingName = "create_date"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "备注"
        Me.DataGridTextBoxColumn2.MappingName = "remark"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 120
        '
        'btnView
        '
        Me.btnView.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Bitmap)
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.ImageIndex = 17
        Me.btnView.ImageList = Me.ImageListBasic
        Me.btnView.Location = New System.Drawing.Point(259, 472)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(93, 24)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "打开文件(&V)"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmCompanyFileQuery
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(706, 503)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnView, Me.GroupBox2, Me.GroupBox1})
        Me.Name = "frmCompanyFileQuery"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "公司文件查询"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmCompanyFileQuery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            isLoad = True
            Me.btnView.Enabled = False
            bindingType()
            flag = True
            'btnQuery_Click(sender, e)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '绑定文件类型,61,62,63,……
    Private Sub bindingType()
        Dim ds As DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim strSql As String
        'strSql = "{item_type like '61' or item_type like '62' or item_type like '63'}"
        strSql = "{item_type_belong like '06'}"
        ds = gWs.GetItemType(strSql)
        dt = ds.Tables(0)
        Try
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
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Me.cmbType.DataSource = ds.Tables(0)
        Me.cmbType.DisplayMember = "type_name"
        Me.cmbType.ValueMember = "item_type"
    End Sub
    '获得子类型
    Private Sub setChileType()
        Dim ds As DataSet
        Dim dt As DataTable
        Dim dr As DataRow
        Dim strSql As String
        Dim strItemType As String = Me.cmbType.SelectedValue
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
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Me.cmbChildType.DataSource = ds.Tables(0)
        Me.cmbChildType.DisplayMember = "item_name"
        Me.cmbChildType.ValueMember = "item_code"
        If Me.cmbChildType.SelectedValue = "" Then
            Me.cmbChildType.Text = ""
            Exit Sub
        End If
    End Sub
    'cmbType_SelectValueChanged
    Private Sub cmbType_SelectValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectedValueChanged
        flag = False
        If isLoad Then
            count = count + 1
        End If
        If nCurrentCount < count Then
        Else
            setChileType()
            flag = True
            'btnQuery_Click(sender, e)
        End If
        nCurrentCount = nCurrentCount + 1
    End Sub
    'cmbType_DropDown
    Private Sub cmbType_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.DropDown
        isLoad = False
    End Sub
    'cmbType_Enter
    Private Sub cmbType_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.Enter
        isLoad = False
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    '查询
    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim strSql As String
            Dim ds As DataSet
            Dim dr As DataRow
            Dim i As Integer
            Dim strRelationNum As String
            strSql = getQueryCondition()
            ds = getCompanyFile(strSql)
            Me.dgContent.DataSource = ds.Tables("TProjectFile")
            setButton()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '获得公司文件
    Private Function getCompanyFile(ByVal strSql As String)
        Dim ds As DataSet
        Dim dsItem As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strItemType As String
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
            ExceptionHandler.ShowMessageBox(ex)
        End Try
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
    '获得查询条件
    Private Function getQueryCondition()
        Dim strItemType, strItemCode As String
        Dim strTitle, strVersion As String
        Dim strSql As String
        If Me.cmbType.Text = "" Then
            strItemType = "%"
            strItemCode = "%"
        Else
            strItemType = Me.cmbType.SelectedValue
            strItemCode = Me.cmbChildType.SelectedValue
            If strItemCode = "" Then
                strItemCode = "%"
            End If
        End If
        If Me.txtTitle.Text = "" Then
            strTitle = ""
        Else
            strTitle = Me.txtTitle.Text
        End If
        If Me.txtVersion.Text = "" Then
            strVersion = ""
        Else
            strVersion = Me.txtVersion.Text
        End If
        strSql = "{item_type like '" & strItemType & "' and item_code like '" & strItemCode & "' and title like '%" & _
                strTitle & "%' and version like '%" & strVersion & "%' " & _
                "and (item_type like '6%')}"
        Return strSql
    End Function
    '根据relation_num是否为空设置按钮"打开文档"的Enabled属性
    Private Sub setButton()
        If CType(Me.dgContent.DataSource, DataTable).Rows.Count > 0 Then
            If Me.dgContent.Item(Me.dgContent.CurrentCell.RowNumber, 0) Is System.DBNull.Value Then
                Me.btnView.Enabled = False
            Else
                Me.btnView.Enabled = True
            End If
        Else
            Me.btnView.Enabled = False
        End If
    End Sub
    'MouseUp
    Private Sub dgContent_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgContent.MouseUp
        If Me.dgContent.DataSource Is Nothing Then
            Exit Sub
        End If
        If CType(Me.dgContent.DataSource, DataTable).Rows.Count > 0 Then
            Me.dgContent.Select(Me.dgContent.CurrentCell.RowNumber)
        End If
        setButton()
    End Sub
    '打开文档
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        If Me.dgContent.DataSource Is Nothing Then
            Exit Sub
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim strRelationNum As String
            strRelationNum = IIf(Me.dgContent.Item(Me.dgContent.CurrentCell.RowNumber, 0) Is System.DBNull.Value, "", Me.dgContent.Item(Me.dgContent.CurrentCell.RowNumber, 0))

            Dim docClass As New frmDocumentClass()
            docClass.setIsDocument(True)
            docClass.openFileByRelation(strRelationNum, strDir)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '选择子类型
    Private Sub cmbChildType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbChildType.SelectedValueChanged
        If flag Then
            btnQuery_Click(sender, e)
        End If
    End Sub

    Private Sub frmCompanyFileQuery_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        setEnterKeyPress(sender, e)
    End Sub
End Class
