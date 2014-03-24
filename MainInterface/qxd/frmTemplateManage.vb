Public Class frmTemplateManage
    Inherits frmBasic

    Private dsFileTemplate As DataSet
    Private bmFileTemplate As BindingManagerBase
    Private strDir As String = "\Document\Template" '默认目录
    Private strFileName As String = "模板文档"
    Private strFileType As String = "doc"
    Private isNewBtnClick As Boolean = False
    Private count As Integer = 0

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
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents dgFileTemplate As System.Windows.Forms.DataGrid
    Friend WithEvents chbCurrent As System.Windows.Forms.CheckBox
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents txtVersion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTemplateManage))
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn()
        Me.dgFileTemplate = New System.Windows.Forms.DataGrid()
        Me.chbCurrent = New System.Windows.Forms.CheckBox()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.txtVersion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgFileTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(505, 376)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(329, 376)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 24)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 13
        Me.btnNew.ImageList = Me.ImageListBasic
        Me.btnNew.Location = New System.Drawing.Point(241, 376)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 24)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOpen.Image = CType(resources.GetObject("btnOpen.Image"), System.Drawing.Bitmap)
        Me.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpen.ImageIndex = 17
        Me.btnOpen.ImageList = Me.ImageListBasic
        Me.btnOpen.Location = New System.Drawing.Point(153, 376)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(77, 24)
        Me.btnOpen.TabIndex = 3
        Me.btnOpen.Text = "打 开(&O)"
        Me.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpload
        '
        Me.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpload.Image = CType(resources.GetObject("btnUpload.Image"), System.Drawing.Bitmap)
        Me.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpload.ImageIndex = 25
        Me.btnUpload.ImageList = Me.ImageListBasic
        Me.btnUpload.Location = New System.Drawing.Point(65, 376)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(77, 24)
        Me.btnUpload.TabIndex = 2
        Me.btnUpload.Text = "上 载(&U)"
        Me.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(417, 376)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 24)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "模板名称"
        Me.DataGridTextBoxColumn1.MappingName = "item_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 250
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "版本"
        Me.DataGridTextBoxColumn2.MappingName = "version"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.AllowNull = False
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "当前版本"
        Me.DataGridBoolColumn1.MappingName = "is_current_ver"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), System.DBNull)
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Item类型"
        Me.DataGridTextBoxColumn3.MappingName = "item_type"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Item代码"
        Me.DataGridTextBoxColumn4.MappingName = "item_code"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "文件类型"
        Me.DataGridTextBoxColumn5.MappingName = "doc_type"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridBoolColumn2
        '
        Me.DataGridBoolColumn2.AllowNull = False
        Me.DataGridBoolColumn2.FalseValue = False
        Me.DataGridBoolColumn2.HeaderText = "有文件"
        Me.DataGridBoolColumn2.MappingName = "is_file"
        Me.DataGridBoolColumn2.NullText = "false"
        Me.DataGridBoolColumn2.NullValue = CType(resources.GetObject("DataGridBoolColumn2.NullValue"), System.DBNull)
        Me.DataGridBoolColumn2.ReadOnly = True
        Me.DataGridBoolColumn2.TrueValue = True
        Me.DataGridBoolColumn2.Width = 75
        '
        'dgFileTemplate
        '
        Me.dgFileTemplate.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.dgFileTemplate.CaptionVisible = False
        Me.dgFileTemplate.DataMember = ""
        Me.dgFileTemplate.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgFileTemplate.Location = New System.Drawing.Point(8, 8)
        Me.dgFileTemplate.Name = "dgFileTemplate"
        Me.dgFileTemplate.Size = New System.Drawing.Size(632, 328)
        Me.dgFileTemplate.TabIndex = 8
        '
        'chbCurrent
        '
        Me.chbCurrent.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.chbCurrent.Checked = True
        Me.chbCurrent.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbCurrent.Location = New System.Drawing.Point(608, 343)
        Me.chbCurrent.Name = "chbCurrent"
        Me.chbCurrent.Size = New System.Drawing.Size(16, 24)
        Me.chbCurrent.TabIndex = 13
        '
        'cmbType
        '
        Me.cmbType.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Location = New System.Drawing.Point(56, 344)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(360, 20)
        Me.cmbType.TabIndex = 9
        '
        'txtVersion
        '
        Me.txtVersion.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtVersion.Location = New System.Drawing.Point(480, 344)
        Me.txtVersion.MaxLength = 10
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(56, 21)
        Me.txtVersion.TabIndex = 12
        Me.txtVersion.Text = ""
        '
        'Label3
        '
        Me.Label3.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label3.Location = New System.Drawing.Point(552, 344)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "当前版本"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label2.Location = New System.Drawing.Point(432, 343)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "版  本"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label1.Location = New System.Drawing.Point(8, 343)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "类  型"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmTemplateManage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(650, 407)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chbCurrent, Me.cmbType, Me.txtVersion, Me.Label3, Me.Label2, Me.Label1, Me.dgFileTemplate, Me.btnExit, Me.btnSave, Me.btnUpload, Me.btnOpen, Me.btnNew, Me.btnDelete})
        Me.Name = "frmTemplateManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "模板管理"
        CType(Me.dgFileTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    '
    'load()
    '
    Private Sub frmTemplateManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setTextBoxEnabled(False)
        addFileType()
        Me.dsFileTemplate = getFileTemplate()
        Me.dgFileTemplate.DataSource = Me.dsFileTemplate.Tables("TFileTemplate")
        If Not Me.dsFileTemplate Is Nothing Then
            setDgAttribute(Me.dgFileTemplate, Me)
            Me.dsFileTemplate.AcceptChanges()
            Me.bmFileTemplate = BindingContext(Me.dsFileTemplate, "TFileTemplate")
            addStyle(Me.dsFileTemplate)
        End If
        setButton()
    End Sub
    '添加dataGrid的style
    Private Sub addStyle(ByVal ds As DataSet)
        Dim tableStyle As DataGridTableStyle = New DataGridTableStyle()
        tableStyle.MappingName = "TFileTemplate"
        tableStyle.AllowSorting = False
        tableStyle.RowHeadersVisible = True

        Dim numCols As Integer = ds.Tables("TFileTemplate").Columns.Count
        Dim dgc As New DataGridColoredBoolColumn()
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf dgc.MyGetColorRowCol)

        Dim column_1 As New DataGridTextBoxColumn()
        column_1.Width = 300
        column_1.ReadOnly = True
        column_1.NullText = ""
        column_1.HeaderText = "模板名称"
        column_1.MappingName = "item_name"
        tableStyle.GridColumnStyles.Add(column_1)

        Dim column_2 As New DataGridTextBoxColumn()
        column_2.ReadOnly = True
        column_2.NullText = ""
        column_2.HeaderText = "版本"
        column_2.MappingName = "version"
        tableStyle.GridColumnStyles.Add(column_2)

        Dim aColumnTextColumn As DataGridColoredBoolColumn
        aColumnTextColumn = New DataGridColoredBoolColumn(d, 0)
        aColumnTextColumn.HeaderText = "当前版本"
        aColumnTextColumn.AllowNull = False
        aColumnTextColumn.MappingName = "is_current_ver"
        tableStyle.GridColumnStyles.Add(aColumnTextColumn)

        Dim column_3 As New DataGridTextBoxColumn()
        column_3.ReadOnly = True
        column_3.Width = 0
        column_3.NullText = ""
        column_3.HeaderText = "itemType"
        column_3.MappingName = "item_type"
        tableStyle.GridColumnStyles.Add(column_3)

        Dim column_4 As New DataGridTextBoxColumn()
        column_4.ReadOnly = True
        column_4.Width = 0
        column_4.NullText = ""
        column_4.HeaderText = "itemCode"
        column_4.MappingName = "item_code"
        tableStyle.GridColumnStyles.Add(column_4)

        Dim aColumnTextColumn1 As DataGridBoolColumn
        aColumnTextColumn1 = New DataGridBoolColumn()
        aColumnTextColumn1.ReadOnly = True
        aColumnTextColumn1.HeaderText = "有文件"
        aColumnTextColumn1.AllowNull = False
        aColumnTextColumn1.MappingName = "is_file"
        tableStyle.GridColumnStyles.Add(aColumnTextColumn1)

        Dim column_5 As New DataGridTextBoxColumn()
        column_5.ReadOnly = True
        column_5.NullText = ""
        column_5.HeaderText = "文件类型"
        column_5.MappingName = "doc_type"
        tableStyle.GridColumnStyles.Add(column_5)

        Me.dgFileTemplate.TableStyles.Clear()
        Me.dgFileTemplate.TableStyles.Add(tableStyle)
    End Sub
    '
    '获得文件模板类型
    '"43":表示合同;"45":表示文档
    '
    Private Sub addFileType()
        If Not gWs Is Nothing Then
            Dim i As Integer
            Dim strSql As String
            Dim ds As DataSet
            Dim dr As DataRow
            '"43":表示合同;"45":表示文档;"47":表示Excel模板
            strSql = "{item_type='43' or item_type='45' or item_type='47'}"
            Try
                ds = gWs.GetItemEx(strSql)
                i = ds.Tables("TItem").Rows.Count
                Me.cmbType.Items.Clear()
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = ds.Tables("TItem").Rows(i)
                        With dr
                            Me.cmbType.Items.Add(.Item("item_name"))
                        End With
                    Next
                    Me.cmbType.SelectedIndex = 0
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Sub
    '
    '从表file_template中获得模板的信息，并增加一字段：item_name，为显示用
    '
    Private Function getFileTemplate()
        If Not gWs Is Nothing Then
            Dim i As Integer
            Dim strSql As String
            Dim ds, dsItem As DataSet
            Dim dr As DataRow
            '"43":表示合同;"45":表示文档;"47":表示Excel模板
            strSql = "{item_type='43' or item_type='45' or item_type='47'}"
            Try
                ds = gWs.GetFileTemplateByCondition("%")
                dsItem = gWs.GetItemEx(strSql)
                ds.Tables("TFileTemplate").Columns.Add("item_name", GetType(String))
                ds.Tables("TFileTemplate").Columns.Add("is_file", GetType(Boolean))
                i = ds.Tables("TFileTemplate").Rows.Count
                Dim selDr As DataRow()
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = ds.Tables("TFileTemplate").Rows(i)
                        With dr
                            strSql = "item_type='" & .Item("item_type") & "' and item_code='" & .Item("item_code") & "'"
                            selDr = dsItem.Tables("TItem").Select(strSql)
                            If selDr.Length > 0 Then
                                .Item("item_name") = selDr(0).Item("item_name")
                            Else
                                .Item("item_name") = "***在item表中没有找到对应名称***"
                            End If
                            If Not .Item("template") Is System.DBNull.Value Then
                                .Item("is_file") = True
                            Else
                                .Item("is_file") = False
                            End If
                        End With
                    Next
                End If
                Return ds
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Function
    '
    '退出，判断是否修改后未保存，提示
    '
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        frmExit(sender, e)
    End Sub
    '
    'frmExit()
    '
    Private Function frmExit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim changedCount As Integer = 0
        If Not Me.dsFileTemplate Is Nothing Then
            Try
                changedCount = Me.dsFileTemplate.GetChanges.Tables(0).Rows.Count
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
    '
    '新增记录到file_template
    '
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If Me.btnNew.Text = "新 增(&N)" Then
            isNewBtnClick = True
            setTextBoxEnabled(True)
            Try
                Me.cmbType.Focus()
                Me.txtVersion.Text = "1.0"
                Me.chbCurrent.Enabled = True
            Catch
            End Try
            delBinding()
            addBinding()
            addFileTemplate()
            Me.btnNew.Text = "取 消(&C)"
            setNewButton(False)
        Else
            isNewBtnClick = False
            setTextBoxEnabled(False)
            Me.btnNew.Text = "新 增(&N)"
            Me.dsFileTemplate.RejectChanges()
            If Not Me.dsFileTemplate Is Nothing Then
                Me.bmFileTemplate = BindingContext(Me.dsFileTemplate, "TFileTemplate")
                Me.dgFileTemplate.CurrentRowIndex = 0
            End If
            setNewButton(True)
        End If
        setButton()
        addStyle(Me.dsFileTemplate)
        Me.dgFileTemplate.Refresh()
    End Sub
    '设置新增时按钮的Enabled属性
    Private Sub setNewButton(ByVal flag As Boolean)
        Me.dgFileTemplate.Enabled = flag
        Me.btnDelete.Enabled = flag
        Me.btnOpen.Enabled = flag
        Me.btnUpload.Enabled = flag
    End Sub
    '
    '增加控件的绑定
    '
    Private Sub addBinding()
        If Not Me.dsFileTemplate Is Nothing Then
            Try
                Me.cmbType.DataBindings.Add("Text", Me.dsFileTemplate.Tables("TFileTemplate"), "item_name")
                Me.txtVersion.DataBindings.Add("Text", Me.dsFileTemplate.Tables("TFileTemplate"), "version")
                Me.chbCurrent.DataBindings.Add("Checked", Me.dsFileTemplate.Tables("TFileTemplate"), "is_current_ver")
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Sub
    '
    '清除绑定
    '
    Private Sub delBinding()
        Me.cmbType.DataBindings.Clear()
        Me.txtVersion.DataBindings.Clear()
        Me.chbCurrent.DataBindings.Clear()
    End Sub
    '
    '新增记录
    '
    Private Sub addFileTemplate()
        If Not Me.dsFileTemplate Is Nothing Then
            Dim i As Integer
            Dim dr As DataRow
            Try
                dr = Me.dsFileTemplate.Tables("TFileTemplate").NewRow
                With dr
                    .Item("item_name") = Me.cmbType.Text
                    .Item("item_type") = getItemType(Me.cmbType.Text)
                    .Item("item_code") = getItemCode(Me.cmbType.Text)
                    .Item("version") = Me.txtVersion.Text
                    .Item("is_current_ver") = Me.chbCurrent.Checked
                    If Me.cmbType.Text = "Excel表格" Or Me.cmbType.Text = "保后检查记录表" Then
                        .Item("doc_type") = "xls"
                    Else
                        .Item("doc_type") = "doc"
                    End If
                End With
                Me.dsFileTemplate.Tables("TFileTemplate").Rows.Add(dr)
                If Not Me.dsFileTemplate Is System.DBNull.Value Then
                    Me.bmFileTemplate = BindingContext(Me.dsFileTemplate, "TFileTemplate")
                    Me.dgFileTemplate.CurrentRowIndex = Me.bmFileTemplate.Count - 1
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Sub
    '
    '保存
    '
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Not Me.dsFileTemplate Is Nothing Then
            If Me.dsFileTemplate.GetChanges() Is Nothing Then
                'MsgBox("保存成功!", MsgBoxStyle.Information, "提示")
                SWDialogBox.MessageBox.Show("$SaveSucceed")
                Exit Sub
            End If
            Dim strResult As String
            Dim dr As DataRow
            If Me.isNewBtnClick Then
                isNewBtnClick = False
                Dim i As Integer
                Dim ds As DataSet
                Dim strSql As String
                Dim itemType, itemCode As String
                i = Me.bmFileTemplate.Count - 1
                Me.dgFileTemplate.CurrentRowIndex = i
                Try
                    dr = Me.dsFileTemplate.Tables("TFileTemplate").Rows(i)
                    With dr
                        itemType = getItemType(Me.cmbType.Text)
                        itemCode = getItemCode(Me.cmbType.Text)
                        .Item("item_name") = Me.cmbType.Text
                        .Item("item_type") = itemType
                        .Item("item_code") = itemCode
                        .Item("version") = Me.txtVersion.Text
                        .Item("is_current_ver") = Me.chbCurrent.Checked
                        If Me.chbCurrent.Checked Then
                            setNoCurrent(itemType, itemCode, Me.dsFileTemplate, Me.txtVersion.Text)
                        End If
                        If Me.cmbType.Text = "Excel表格" Or Me.cmbType.Text = "保后检查记录表" Then
                            .Item("doc_type") = "xls"
                        Else
                            .Item("doc_type") = "doc"
                        End If
                    End With
                Catch ex As Exception
                    'MsgBox(ex.Message)
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
            End If
            Try
                strResult = gWs.UpdateFileTemplate(Me.dsFileTemplate.GetChanges())
                If strResult = "1" Then
                    setNewButton(True)
                    setTextBoxEnabled(False)
                    'MsgBox("保存成功!", MsgBoxStyle.Information, "提示")
                    SWDialogBox.MessageBox.Show("$SaveSucceed")
                    Me.dsFileTemplate = getFileTemplate()
                    Me.dgFileTemplate.DataSource = Me.dsFileTemplate.Tables("TFileTemplate")
                    If Not Me.dsFileTemplate Is Nothing Then
                        setDgAttribute(Me.dgFileTemplate, Me)
                        Me.dsFileTemplate.AcceptChanges()
                        Me.bmFileTemplate = BindingContext(Me.dsFileTemplate, "TFileTemplate")
                    End If
                    '定位当前行为新增的行
                    If Not dr Is Nothing Then
                        Dim i As Int16
                        Dim drPos As DataRow
                        i = Me.dsFileTemplate.Tables("TFileTemplate").Rows.Count
                        For i = 0 To i - 1
                            drPos = Me.dsFileTemplate.Tables("TFileTemplate").Rows(i)
                            If dr.Item("item_type") = drPos.Item("item_type") AndAlso _
                                    dr.Item("item_code") = drPos.Item("item_code") AndAlso _
                                    dr.Item("version") = drPos.Item("version") Then

                                Me.dgFileTemplate.CurrentRowIndex = i
                                Exit For
                            End If
                        Next
                    End If
                Else
                    If strResult.StartsWith("违反了 PRIMARY KEY") Then
                        'MsgBox("保存失败!" & Chr(13) & "版本为： " & Me.txtVersion.Text & "的《" & Me.cmbType.Text & "》记录已经存在.", MsgBoxStyle.Critical, "提示")
                        SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                    Else
                        'MsgBox("保存失败!" & strResult, MsgBoxStyle.Critical, "提示")
                        SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                    End If
                    Me.dsFileTemplate.RejectChanges()
                    Me.dsFileTemplate.AcceptChanges()
                    setNewButton(True)
                    setTextBoxEnabled(False)
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
            Me.btnNew.Text = "新 增(&N)"
            Me.dgFileTemplate.Enabled = True
            Me.dgFileTemplate.Refresh()
        End If
        setButton()
    End Sub
    '设置同类型的模板,is_current_ver为false
    Private Sub setNoCurrent(ByVal itemType As String, ByVal itemCode As String, ByVal ds As DataSet, ByVal strVersion As String)
        Dim i As Integer
        Dim strSql As String
        Dim dr As DataRow()
        If Not ds Is Nothing Then
            strSql = "item_type='" & itemType & "' and item_code='" & itemCode & "' and not version='" & strVersion & "'"
            dr = ds.Tables(0).Select(strSql)
            i = dr.Length
            If i > 0 Then
                For i = 0 To i - 1
                    With dr(i)
                        .Item("is_current_ver") = False
                    End With
                Next
            End If
        End If
    End Sub
    '
    '设置控件的Enabled属性
    '
    Private Sub setTextBoxEnabled(ByVal isEnabled As Boolean)
        Me.cmbType.Enabled = isEnabled
        Me.txtVersion.Enabled = isEnabled
        Me.chbCurrent.Enabled = isEnabled
    End Sub
    '
    '删除
    '
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Me.Cursor = Cursors.WaitCursor
        Dim i As Integer
        Dim strResult As String
        Try
            i = Me.dgFileTemplate.CurrentRowIndex
            If i >= 0 Then
                'If MsgBoxResult.Yes = MsgBox("确定删除选中的项目吗?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "提示") Then
                If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1004", "") Then
                    Me.dsFileTemplate.Tables("TFileTemplate").Rows(i).Delete()
                    strResult = gWs.UpdateFileTemplate(Me.dsFileTemplate)
                    Me.dsFileTemplate.AcceptChanges()
                    If Not Me.dsFileTemplate Is Nothing Then
                        Me.bmFileTemplate = BindingContext(Me.dsFileTemplate, "TFileTemplate")
                    End If
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        setButton()
        Me.Cursor = Cursors.Default
    End Sub
    '
    '上载文件
    '
    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Me.Cursor = Cursors.WaitCursor
        Dim docClass As New frmDocumentClass("")
        Dim data As Byte()
        If Me.cmbType.Text.StartsWith("保后检查记录表") Then
            data = docClass.getFileContent("", "Document", True, False)
        Else
            data = docClass.getFileContent("", "Document", True, True)
        End If
        If Not data Is Nothing Then
            Dim i As Integer
            Dim strResult As String
            Dim dr As DataRow
            Try
                i = Me.dgFileTemplate.CurrentRowIndex
                If i >= 0 Then
                    dr = Me.dsFileTemplate.Tables("TFileTemplate").Rows(i)
                    With dr
                        .Item("template") = data
                        .Item("doc_type") = docClass.getFileType()
                    End With
                    strResult = gWs.UpdateFileTemplate(Me.dsFileTemplate.GetChanges())
                    If strResult = "1" Then
                        'MsgBox("文件上载成功!", MsgBoxStyle.Information, "提示")
                        SWDialogBox.MessageBox.Show("$UploadSucceed")
                        Me.dsFileTemplate.Tables("TFileTemplate").Rows(i).Item("is_file") = True
                        Me.dsFileTemplate.AcceptChanges()
                    Else
                        'MsgBox("文件上载失败!" & strResult, MsgBoxStyle.Critical, "提示")
                        SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                    End If
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
        Me.Cursor = Cursors.Default
    End Sub
    '
    '打开文件
    '
    Private Sub btnOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpen.Click
        Me.Cursor = Cursors.WaitCursor
        Dim docClass As New frmDocumentClass("")
        strDir = docClass.getRelativePath(strDir)
        Dim itemType, itemCode, itemName As String
        Dim data As Byte()
        Dim i As Integer
        If Not Me.dsFileTemplate Is Nothing Then
            Try
                i = Me.dgFileTemplate.CurrentRowIndex
                Dim dr As DataRow
                dr = Me.dsFileTemplate.Tables("TFileTemplate").Rows(i)
                With dr
                    If Not .Item("template") Is System.DBNull.Value Then
                        data = .Item("template")
                        itemType = .Item("item_type")
                        itemCode = .Item("item_code")
                        itemName = .Item("item_name")
                        strFileType = .Item("doc_type")
                    Else
                        'MsgBox("该记录未保存文件内容!不能打开文件.", MsgBoxStyle.Exclamation, "提示")
                        SWDialogBox.MessageBox.Show("$X019")
                        Me.Cursor = Cursors.Default
                        Exit Sub
                    End If
                End With
                If Not System.IO.Directory.Exists(Application.StartupPath & strDir) Then
                    System.IO.Directory.CreateDirectory(Application.StartupPath & strDir)
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            Finally
                Me.Cursor = Cursors.Default
            End Try
            Dim word1 As Word.ApplicationClass
            Dim excel1 As Excel.ApplicationClass
            Try
                strFileName = itemName + "." + strFileType
                Dim myfilestream As New System.IO.FileStream(Application.StartupPath & strDir & "\" & strFileName, IO.FileMode.Create)
                myfilestream.Write(data, 0, data.Length)
                myfilestream.Close()
                If strFileType.Trim() = "doc" Then
                    word1 = New Word.ApplicationClass()
                    'word1.Application.Documents.Open(Application.StartupPath & strDir & "\" & strFileName)
                    word1.Application.Documents.Add(Application.StartupPath & strDir & "\" & strFileName)
                    word1.Caption = strFileName
                    word1.Application.Visible = True
                ElseIf strFileType.Trim() = "xls" Then
                    excel1 = New Excel.ApplicationClass()
                    'excel1.Application.Workbooks.Open(Application.StartupPath & strDir & "\" & strFileName)
                    excel1.Application.Workbooks.Add(Application.StartupPath & strDir & "\" & strFileName)
                    excel1.Application.Visible = True
                Else
                    Try
                        System.Diagnostics.Process.Start(Application.StartupPath & strDir & "\" & strFileName)
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    Finally
                        GC.Collect()
                    End Try
                End If
            Catch ex As Exception
                word1 = Nothing
                excel1 = Nothing
                'MsgBox("文件已经打开或文件有误!" & ex.Message, MsgBoxStyle.Exclamation, "获取文件")
                ExceptionHandler.ShowMessageBox(ex)
            Finally
                Me.Cursor = Cursors.Default
            End Try
        End If
        Me.Cursor = Cursors.Default
    End Sub
    '
    '关闭
    '
    Private Sub frmTemplateManage_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If sender.GetType Is GetType(Form) Then
            If frmExit(sender, e) Then
                e.Cancel = True
            End If
        End If
    End Sub
    '类型改变触发的事件
    Private Sub cmbType_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbType.SelectedIndexChanged
        If Me.isNewBtnClick Then
            Dim i As Integer = 0
            Dim dr As DataRow
            i = Me.bmFileTemplate.Count
            Try
                dr = Me.dsFileTemplate.Tables("TFileTemplate").Rows(i - 1)
                With dr
                    .Item("item_name") = Me.cmbType.Text
                    .Item("version") = Me.txtVersion.Text
                    .Item("is_current_ver") = Me.chbCurrent.Checked
                    .Item("doc_type") = getDocType(Me.cmbType.Text)
                    .Item("item_type") = getItemType(Me.cmbType.Text)
                    .Item("item_code") = getItemCode(Me.cmbType.Text)
                End With
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Sub
    '获得文件的类型:doc,xls
    Private Function getDocType(ByVal type As String) As String
        If type = "Excel表格" Or Me.cmbType.Text = "保后检查记录表" Then
            Return "xls"
        Else
            Return "doc"
        End If
    End Function
    '设置button的enable属性
    Private Sub setButton()
        Dim i As Integer
        If Not Me.dsFileTemplate Is Nothing Then
            Try
                i = Me.dgFileTemplate.CurrentRowIndex
                Dim dr As DataRow
                dr = Me.dsFileTemplate.Tables("TFileTemplate").Rows(i)
                With dr
                    If Not .Item("template") Is System.DBNull.Value Then
                        Me.btnOpen.Enabled = True
                    Else
                        Me.btnOpen.Enabled = False
                    End If
                End With
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Sub
    '列表中的鼠标按下事件
    Private Sub dgFileTemplate_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgFileTemplate.MouseUp
        If Me.dsFileTemplate Is Nothing Then
            Exit Sub
        End If
        Dim itemType, itemCode, version As String
        If Me.dsFileTemplate.Tables("TFileTemplate").Rows.Count > 0 Then
            Me.dgFileTemplate.Select(Me.dgFileTemplate.CurrentCell.RowNumber)
            '单击datagrid中的checkbox时改变checked
            Dim rowNum, colNum As Integer
            rowNum = Me.dgFileTemplate.CurrentCell.RowNumber
            colNum = Me.dgFileTemplate.CurrentCell.ColumnNumber
            itemType = Me.dgFileTemplate.Item(rowNum, 3)
            itemCode = Me.dgFileTemplate.Item(rowNum, 4)
            version = Me.dgFileTemplate.Item(rowNum, 1)
            If colNum = 2 Then
                Dim he As DataGrid = CType(sender, DataGrid)
                If he.HitTest(e.X, e.Y).Type <> DataGrid.HitTestType.Cell Then Return
                'Me.dgFileTemplate.Item(rowNum, colNum) = Not Me.dgFileTemplate.Item(rowNum, colNum)
                If Not Me.dgFileTemplate.Item(rowNum, colNum) Then
                    Me.dgFileTemplate.Item(rowNum, colNum) = Not Me.dgFileTemplate.Item(rowNum, colNum)
                    setNoCurrent(itemType, itemCode, Me.dsFileTemplate, version)
                End If
            End If
            Me.cmbType.Text = Me.dgFileTemplate.Item(Me.dgFileTemplate.CurrentRowIndex, 0).ToString
            Me.txtVersion.Text = Me.dgFileTemplate.Item(Me.dgFileTemplate.CurrentRowIndex, 1).ToString
            Me.chbCurrent.Checked = Me.dgFileTemplate.Item(Me.dgFileTemplate.CurrentRowIndex, 2)
            setButton()
        End If
    End Sub

End Class
