

Public Class frmDocumentBill
    Inherits MainInterface.frmBasic

    Private strProjectCode As String
    Private dsProjectDocument As DataSet
    Private strDir As String = "\Document\"

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub
    '构造函数
    Public Sub New(ByVal projectCode As String)
        Me.New()
        Me.strProjectCode = projectCode
        Me.txtCode.Text = Me.strProjectCode
        Me.txtCode.ReadOnly = True
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
    Friend WithEvents dgContent As System.Windows.Forms.DataGrid
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents cmbFileType As System.Windows.Forms.ComboBox
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDocumentBill))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.cmbFileType = New System.Windows.Forms.ComboBox()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgContent = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
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
        Me.btnExit.Location = New System.Drawing.Point(311, 354)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCode, Me.cmbFileType, Me.btnQuery, Me.Label2, Me.Label1})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 72)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询条件"
        '
        'txtCode
        '
        Me.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtCode.Location = New System.Drawing.Point(64, 16)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(120, 21)
        Me.txtCode.TabIndex = 0
        Me.txtCode.Text = ""
        '
        'cmbFileType
        '
        Me.cmbFileType.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.cmbFileType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbFileType.Location = New System.Drawing.Point(64, 44)
        Me.cmbFileType.Name = "cmbFileType"
        Me.cmbFileType.Size = New System.Drawing.Size(121, 20)
        Me.cmbFileType.TabIndex = 1
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuery.ImageIndex = 3
        Me.btnQuery.ImageList = Me.ImageListBasic
        Me.btnQuery.Location = New System.Drawing.Point(488, 40)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(77, 24)
        Me.btnQuery.TabIndex = 2
        Me.btnQuery.Text = "查 询(&Q)"
        Me.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "清单类型"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 15)
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
        Me.GroupBox2.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 256)
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
        Me.dgContent.Size = New System.Drawing.Size(570, 236)
        Me.dgContent.TabIndex = 0
        Me.dgContent.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgContent
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
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
        Me.DataGridTextBoxColumn2.Width = 350
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "创建人"
        Me.DataGridTextBoxColumn3.MappingName = "create_person"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "创建时间"
        Me.DataGridTextBoxColumn4.MappingName = "create_date"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
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
        Me.btnView.Location = New System.Drawing.Point(209, 354)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(93, 24)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "打开文档(&V)"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmDocumentBill
        '
        Me.AcceptButton = Me.btnQuery
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(596, 383)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnView, Me.GroupBox2, Me.GroupBox1})
        Me.Name = "frmDocumentBill"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "查看卷宗清单"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Load()
    Private Sub frmDocumentBill_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnView.Enabled = False
        bindingDocType()
    End Sub
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    '绑定itemType表中的文件类型
    Private Sub bindingDocType()
        Dim ds As DataSet
        Dim strSql As String
        Dim i As Integer
        strSql = "{item_type like '41' or item_type like '42' or item_type like '43' or item_type like '45'}"
        ds = gWs.GetItemType(strSql)
        i = ds.Tables(0).Rows.Count
        For i = 0 To i - 1
            Me.cmbFileType.Items.Add(ds.Tables(0).Rows(i).Item("type_name"))
        Next
    End Sub
    '获取查询条件
    Private Function getQueryCondition()
        Dim strCode As String
        Dim strSql As String
        If Me.txtCode.Text.Trim = "" Then
            strCode = "%"
        Else
            strCode = Me.txtCode.Text
        End If
        strSql = "{project_code='" & strCode & "'}"
        Return strSql
    End Function
    '查询
    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        If Me.txtCode.Text = "" Then
            'MsgBox("请输入项目编码!", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1001", "项目编码")
            Me.txtCode.Focus()
            Exit Sub
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim strCondition As String
        Dim dsContent As DataSet
        Dim dt As DataTable
        Dim dsItem As DataSet
        Dim i As Integer
        Dim strRelationNum As String
        strCondition = Me.getQueryCondition()
        dsContent = gWs.GetProjectDocumentByCondition(strCondition)
        dsContent.Tables(0).Columns.Add("file_relation", GetType(String))
        i = dsContent.Tables(0).Rows.Count
        For i = 0 To i - 1
            If Not dsContent.Tables(0).Rows(i).Item("file_relation_num") Is System.DBNull.Value Then
                strRelationNum = dsContent.Tables(0).Rows(i).Item("file_relation_num")
                If gWs.GetProjectFileByCondition("{relation_num='" & strRelationNum & "'}").Tables(0).Rows.Count > 0 Then
                    dsContent.Tables(0).Rows(i).Item("file_relation") = strRelationNum
                End If
            End If
        Next
        dsProjectDocument = dsContent
        If Not dsContent Is Nothing Then
            Me.dgContent.DataSource = dsContent.Tables(0)
        End If
        setButton()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    '选择文档类新
    Private Sub cmbFileType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbFileType.SelectedValueChanged
        If Me.dsProjectDocument Is Nothing Then
            Exit Sub
        ElseIf (Me.dsProjectDocument.Tables(0) Is Nothing) Then
            Exit Sub
        End If
        Dim ds As New DataSet()
        Dim typeCode As String
        Dim strItemType As String = Me.cmbFileType.Text
        typeCode = (gWs.GetItemType("{type_name='" & strItemType & "'}")).Tables(0).Rows(0).Item("item_type")
        Select Case typeCode
            Case "41"
                ds.Merge(dsProjectDocument.Tables(0).Select("item_type='41'"))
            Case "42"
                ds.Merge(dsProjectDocument.Tables(0).Select("item_type='42'"))
            Case "43"
                ds.Merge(dsProjectDocument.Tables(0).Select("item_type='43'"))
            Case "45"
                ds.Merge(dsProjectDocument.Tables(0).Select("item_type='45'"))
        End Select
        If ds.Tables.Count > 0 Then
            Me.dgContent.DataSource = ds.Tables(0)
        End If
        setButton()
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
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim strRelationNum As String
        strRelationNum = IIf(Me.dgContent.Item(Me.dgContent.CurrentCell.RowNumber, 6) Is System.DBNull.Value, "", Me.dgContent.Item(Me.dgContent.CurrentCell.RowNumber, 6))
        Dim docClass As New frmDocumentClass()
        docClass.setIsDocument(True)
        docClass.openFileByRelation(strRelationNum, strDir)
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub
    '根据file_relation_num是否为空设置按钮"打开文档"的Enabled属性
    Private Sub setButton()
        Dim isFiles As Boolean
        If CType(Me.dgContent.DataSource, DataTable).Rows.Count > 0 Then
            If Me.dgContent.Item(Me.dgContent.CurrentCell.RowNumber, 5) Is System.DBNull.Value Then
                Me.btnView.Enabled = False
            Else
                If Not Me.dgContent.Item(Me.dgContent.CurrentCell.RowNumber, 6) Is System.DBNull.Value Then
                    Me.btnView.Enabled = True
                Else
                    Me.btnView.Enabled = False
                End If
            End If
        Else
            Me.btnView.Enabled = False
        End If
    End Sub
End Class
