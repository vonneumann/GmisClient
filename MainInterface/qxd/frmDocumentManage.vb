

Public Class frmDocumentManage
    Inherits MainInterface.frmBasic
    '
    'Author quexd
    'Date Created  2003-3-25
    'Modificate Date
    '

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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents dgFiles As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents txtTitle As System.Windows.Forms.TextBox
    Public WithEvents txtAuthor As System.Windows.Forms.TextBox
    Public WithEvents dateCreate As System.Windows.Forms.DateTimePicker
    Public WithEvents cmbType As System.Windows.Forms.ComboBox
    Public WithEvents txtVersion As System.Windows.Forms.TextBox
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txtRemark As System.Windows.Forms.TextBox
    Public WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtCode As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDocumentManage))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgFiles = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtRemark = New System.Windows.Forms.TextBox
        Me.txtVersion = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.dateCreate = New System.Windows.Forms.DateTimePicker
        Me.txtAuthor = New System.Windows.Forms.TextBox
        Me.txtTitle = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Location = New System.Drawing.Point(285, 393)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgFiles)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(632, 192)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "文件列表"
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
        Me.dgFiles.Size = New System.Drawing.Size(626, 172)
        Me.dgFiles.TabIndex = 0
        Me.dgFiles.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgFiles
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "project_files"
        Me.DataGridTableStyle1.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "标题"
        Me.DataGridTextBoxColumn1.MappingName = "title"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "作者"
        Me.DataGridTextBoxColumn2.MappingName = "author"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "日期"
        Me.DataGridTextBoxColumn3.MappingName = "date"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "版本"
        Me.DataGridTextBoxColumn4.MappingName = "version"
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
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "类型"
        Me.DataGridTextBoxColumn6.MappingName = ""
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtRemark)
        Me.GroupBox3.Controls.Add(Me.txtVersion)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.cmbType)
        Me.GroupBox3.Controls.Add(Me.dateCreate)
        Me.GroupBox3.Controls.Add(Me.txtAuthor)
        Me.GroupBox3.Controls.Add(Me.txtTitle)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 240)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(632, 144)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "文件信息"
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtRemark.Location = New System.Drawing.Point(40, 72)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemark.Size = New System.Drawing.Size(584, 64)
        Me.txtRemark.TabIndex = 11
        Me.txtRemark.Text = ""
        '
        'txtVersion
        '
        Me.txtVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtVersion.Location = New System.Drawing.Point(504, 21)
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(120, 21)
        Me.txtVersion.TabIndex = 4
        Me.txtVersion.Text = "1.0"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Location = New System.Drawing.Point(472, 20)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 23)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "版本"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbType
        '
        Me.cmbType.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbType.Location = New System.Drawing.Point(304, 47)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(128, 20)
        Me.cmbType.TabIndex = 3
        '
        'dateCreate
        '
        Me.dateCreate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateCreate.Location = New System.Drawing.Point(40, 47)
        Me.dateCreate.Name = "dateCreate"
        Me.dateCreate.Size = New System.Drawing.Size(192, 21)
        Me.dateCreate.TabIndex = 2
        '
        'txtAuthor
        '
        Me.txtAuthor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAuthor.Location = New System.Drawing.Point(304, 22)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(128, 21)
        Me.txtAuthor.TabIndex = 1
        Me.txtAuthor.Text = ""
        '
        'txtTitle
        '
        Me.txtTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTitle.Location = New System.Drawing.Point(40, 22)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(192, 21)
        Me.txtTitle.TabIndex = 0
        Me.txtTitle.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 23)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "备注"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(272, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "类型"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "日期"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.Location = New System.Drawing.Point(272, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "作者"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "标题"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(328, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(312, 21)
        Me.txtName.TabIndex = 7
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(272, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 8)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(160, 21)
        Me.txtCode.TabIndex = 5
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDocumentManage
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(650, 423)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmDocumentManage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "文档管理"
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.txtCode, 0)
        Me.Controls.SetChildIndex(Me.txtName, 0)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    '
    '通过Itemtype，得到文件类型
    '
    Public Sub getFilesType(ByVal strItemType As String)
        Dim ds As DataSet
        Dim i As Integer
        If Not gws Is Nothing Then
            Try
                ds = gWs.GetItem("{item_type='" & strItemType & "' and isnull(disable,0)<>1}", Nothing)
                i = ds.Tables("TItem").Rows.Count
                cmbType.Items.Clear()
                If i > 0 Then
                    For i = 0 To i - 1
                        With ds.Tables("TItem").Rows(i)
                            cmbType.Items.Add(.Item("item_name"))
                        End With
                    Next
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
            Try
                cmbType.SelectedIndex = 0
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Sub
    '
    '通过Itemtype和item_code，得到文件类型
    '
    Public Sub getFilesType(ByVal strItemType As String, ByVal strItemCode As String)
        Dim ds As DataSet
        Dim i As Integer
        If Not gws Is Nothing Then
            Try
                ds = gws.GetItemEx("{item_code ='" & strItemCode & "' and item_type='" & strItemType & "'}")
                i = ds.Tables("TItem").Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        With ds.Tables("TItem").Rows(i)
                            Me.cmbType.Items.Add(.Item("item_name"))
                        End With
                    Next
                    cmbType.SelectedIndex = 0
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Sub
    '
    '通过文件类型，获得item_code
    '
    Public Function getItemCode(ByVal strFileType As String) As String
        Dim ds As DataSet
        Dim i As Integer
        If Not gws Is Nothing Then
            Try
                ds = gws.GetItem("{item_name='" & strFileType & "'}", Nothing)
                i = ds.Tables("TItem").Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        With ds.Tables("TItem").Rows(i)
                            If Not .Item("item_code") Is System.DBNull.Value Then
                                Return .Item("item_code")
                            Else
                                Return ""
                            End If
                        End With
                    Next
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Function
    '
    '通过文件类型，获得item_type
    '
    Public Function getItemType(ByVal strFileType As String) As String
        Dim ds As DataSet
        Dim i As Integer
        If Not gws Is Nothing Then
            Try
                ds = gws.GetItem("{item_name='" & strFileType & "'}", Nothing)
                i = ds.Tables("TItem").Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        With ds.Tables("TItem").Rows(i)
                            Return .Item("item_type")
                        End With
                    Next
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Function
    '
    '通过item_type 和item_code，获得item_name
    '
    Public Function getItemName(ByVal strItemType As String, ByVal strItemCode As String) As String
        Dim ds As DataSet
        Dim i As Integer
        If Not gws Is Nothing Then
            Try
                ds = gws.GetItem(strItemCode, strItemType)
                i = ds.Tables("TItem").Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        With ds.Tables("TItem").Rows(i)
                            If Not .Item("item_name") Is System.DBNull.Value Then
                                Return .Item("item_name")
                            Else
                                Return "未知的文件类型"
                            End If
                        End With
                    Next
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Function
    '
    '从表number中获得最大数,供relation_num用
    '
    Protected Function getRelationNumber() As String
        If Not gws Is Nothing Then
            Try
                Return gws.GetRelationID()
            Catch ex As Exception
            End Try
        End If
    End Function

    
End Class
