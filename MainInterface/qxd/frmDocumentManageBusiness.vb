
Public Class frmDocumentManageBusiness
    Inherits MainInterface.frmDocumentManage

    '
    '文档管理
    '
    'quexd 2003-4
    '

    Private strProjectCode As String
    Private strWorkFlowID As String
    Private strTaskID As String
    Private strCorporationName As String
    Private strPerson As String
    Private strItemType As String
    Private strItemCode As String
    Private strProItemCode As String
    Private strProTitle As String

    Private dsFiles As DataSet
    Private strFileName As String
    Private strDir As String = "\Document\" '保存文档的目录
    Private count As Integer = 0 '判断选择Combox的次数
    Private isNewBtnClick As Boolean = False '是否点击了"新增"按钮

    Private bmDocument As BindingManagerBase '允许对 Windows 窗体上绑定到相同数据源的数据绑定控件进行同步
    Private isButtonEnable As Boolean = False '设置项目终止报告中显示时置灰一些按钮
    Private isCmbTypeEnable As Boolean = False '设置cmbType的Enabled属性
    Private strSpace As String = "          " ' 制作文档是替换没有内容的变量
    Private currentIndex As Integer = 0 '当前选中行的位置
    Private strPhase As String '项目阶段
    Private strCorporationCode As String '企业编码
    '供其他调用制作报告，传入参数
    Private key As String() '待替换标记
    Private value As New ArrayList() '替换内容
    Private isMakeDocButten As Boolean 'True：不改变按钮btnMakeDoc的属性
    Private relationNumSucceed As String = Nothing '上载成功时,返回relationNum,否则返回nothing 

    Private isUpload As Boolean  '是否可以上载

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub
    '重载构造函数
    Public Sub New(ByVal projectCode As String, ByVal taskID As String, ByVal corporationName As String, ByVal itemType As String, ByVal itemCode As String, ByVal user As String)
        Me.New()
        Me.strProjectCode = projectCode
        Me.strTaskID = taskID
        Me.strCorporationName = corporationName
        Me.strItemType = itemType
        Me.strItemCode = itemCode
        Me.strPerson = user
        Me.isCmbTypeEnable = True
    End Sub
    '重载构造函数
    Public Sub New(ByVal projectCode As String, ByVal taskID As String, ByVal corporationName As String, _
        ByVal itemType As String, ByVal itemCode As String, ByVal user As String, ByVal key As String(), ByVal value As ArrayList)
        Me.New()
        Me.strProjectCode = projectCode
        Me.strTaskID = taskID
        Me.strCorporationName = corporationName
        Me.strItemType = itemType
        Me.strItemCode = itemCode
        Me.strPerson = user
        Me.key = key
        Me.value = value
        Me.isCmbTypeEnable = True
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
    Friend WithEvents uploadFileDialog As System.Windows.Forms.OpenFileDialog
    Public WithEvents btnOpen As System.Windows.Forms.Button
    Public WithEvents btnUpload As System.Windows.Forms.Button
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents btnMakeDoc As System.Windows.Forms.Button
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Public WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDocumentManageBusiness))
        Me.btnOpen = New System.Windows.Forms.Button
        Me.btnUpload = New System.Windows.Forms.Button
        Me.btnNew = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.uploadFileDialog = New System.Windows.Forms.OpenFileDialog
        Me.btnMakeDoc = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.btnModify = New System.Windows.Forms.Button
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgFiles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtAuthor
        '
        Me.txtAuthor.Location = New System.Drawing.Point(504, 44)
        Me.txtAuthor.MaxLength = 10
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(184, 21)
        Me.txtAuthor.TabIndex = 4
        '
        'txtVersion
        '
        Me.txtVersion.Location = New System.Drawing.Point(504, 16)
        Me.txtVersion.MaxLength = 10
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Size = New System.Drawing.Size(184, 21)
        Me.txtVersion.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(32, -40)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 40)
        '
        'dateCreate
        '
        Me.dateCreate.Location = New System.Drawing.Point(80, -32)
        Me.dateCreate.Name = "dateCreate"
        Me.dateCreate.Size = New System.Drawing.Size(152, 21)
        Me.dateCreate.Value = New Date(2003, 3, 24, 21, 30, 44, 296)
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 328)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(696, 136)
        Me.GroupBox3.Controls.SetChildIndex(Me.Button1, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.Label3, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.Label4, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.Label5, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.Label6, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.Label7, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.txtTitle, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.txtAuthor, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.dateCreate, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.cmbType, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.Label8, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.txtVersion, 0)
        Me.GroupBox3.Controls.SetChildIndex(Me.txtRemark, 0)
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(8, 44)
        Me.Label6.Name = "Label6"
        '
        'txtRemark
        '
        Me.txtRemark.MaxLength = 100
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(648, 56)
        Me.txtRemark.TabIndex = 5
        '
        'txtCode
        '
        Me.txtCode.Name = "txtCode"
        '
        'Label2
        '
        Me.Label2.Name = "Label2"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(456, 43)
        Me.Label4.Name = "Label4"
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridBoolColumn1})
        Me.DataGridTableStyle1.MappingName = "TProjectFile"
        Me.DataGridTableStyle1.RowHeadersVisible = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Width = 300
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Width = 50
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Width = 90
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Width = 120
        '
        'dgFiles
        '
        Me.dgFiles.AccessibleName = "DataGrid"
        Me.dgFiles.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgFiles.Name = "dgFiles"
        Me.dgFiles.Size = New System.Drawing.Size(690, 260)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 15)
        Me.Label3.Name = "Label3"
        '
        'cmbType
        '
        Me.cmbType.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbType.DropDownWidth = 144
        Me.cmbType.ItemHeight = 12
        Me.cmbType.Location = New System.Drawing.Point(40, 44)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(336, 20)
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(456, 15)
        Me.Label8.Name = "Label8"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 69)
        Me.Label7.Name = "Label7"
        '
        'txtName
        '
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(376, 21)
        '
        'GroupBox2
        '
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(696, 280)
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(40, 16)
        Me.txtTitle.MaxLength = 50
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(336, 21)
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(624, 472)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 13
        '
        'btnOpen
        '
        Me.btnOpen.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnOpen.ImageIndex = 18
        Me.btnOpen.ImageList = Me.ImageListBasic
        Me.btnOpen.Location = New System.Drawing.Point(114, 472)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(77, 24)
        Me.btnOpen.TabIndex = 7
        Me.btnOpen.Text = "打 开(&O)"
        Me.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpload
        '
        Me.btnUpload.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpload.ImageIndex = 25
        Me.btnUpload.ImageList = Me.ImageListBasic
        Me.btnUpload.Location = New System.Drawing.Point(199, 472)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(77, 24)
        Me.btnUpload.TabIndex = 8
        Me.btnUpload.Text = "上 载(&U)"
        Me.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 13
        Me.btnNew.ImageList = Me.ImageListBasic
        Me.btnNew.Location = New System.Drawing.Point(284, 472)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 24)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(539, 472)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 24)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnMakeDoc
        '
        Me.btnMakeDoc.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnMakeDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMakeDoc.ImageIndex = 19
        Me.btnMakeDoc.ImageList = Me.ImageListBasic
        Me.btnMakeDoc.Location = New System.Drawing.Point(11, 472)
        Me.btnMakeDoc.Name = "btnMakeDoc"
        Me.btnMakeDoc.Size = New System.Drawing.Size(95, 24)
        Me.btnMakeDoc.TabIndex = 6
        Me.btnMakeDoc.Text = "制作文档(&A)"
        Me.btnMakeDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(369, 472)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 24)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnModify
        '
        Me.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.ImageIndex = 14
        Me.btnModify.ImageList = Me.ImageListBasic
        Me.btnModify.Location = New System.Drawing.Point(454, 472)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(77, 24)
        Me.btnModify.TabIndex = 11
        Me.btnModify.Text = "修 改(&M)"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.AllowNull = False
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "有文件"
        Me.DataGridBoolColumn1.MappingName = "is_file"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), Object)
        Me.DataGridBoolColumn1.ReadOnly = True
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 75
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(400, 40)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Button1"
        Me.Button1.Visible = False
        '
        'frmDocumentManageBusiness
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 503)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnMakeDoc)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnOpen)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.btnNew)
        Me.Name = "frmDocumentManageBusiness"
        Me.Controls.SetChildIndex(Me.btnNew, 0)
        Me.Controls.SetChildIndex(Me.btnUpload, 0)
        Me.Controls.SetChildIndex(Me.btnOpen, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnMakeDoc, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.btnModify, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.txtName, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtCode, 0)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgFiles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    '
    '设置按钮是否可用,true:设置Enabled为False;
    '
    Public Sub setIsButtonEnable(ByVal isButton As Boolean)
        Me.isButtonEnable = isButton
    End Sub
    '
    '设置制作文档按钮是否可用,True,可用;False,不可用
    '
    Public Sub setMakeDocEnable(ByVal isEnabled As Boolean)
        Me.btnMakeDoc.Enabled = isEnabled
        isMakeDocButten = True
    End Sub
    '
    '上载成功时,返回relationNum,否则返回nothing 
    '
    Public Function getUploadSucceed()
        Return relationNumSucceed
    End Function
    '
    '根据TaskID判断ItemType（文档或合同）,并设置Form的标题
    '
    Private Function setItemType(ByVal strTaskID As String)
        'If strTaskID = "DraftOutContract" Then
        If strTaskID.StartsWith("Draft") Then '"DraftOutContract"(制作合同)，“DraftLetterOfGuarantee"（制作保函）
            Me.Text = "合同制作"
            Return "43" '合同
        Else
            'task_id 分别为：Review（生成初审报告） ProjectAppraiseReport（制作评审报告）
            'ProjectFinishedReport（制作项目终止报告）
            Me.Text = "文档管理"
            Return "45" '文档
        End If
    End Function
    '
    'Load()
    '
    Private Sub frmDocumentManageBusiness_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Try
            If gWs Is Nothing Then
                Exit Sub
            End If
            Try
                Me.dateCreate.Value = gWs.GetSysTime()
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
            '根据类型,设置不同的类型列表
            If strItemType = "45" Then '文档管理
                Me.strItemType = setItemType(strTaskID)
                getFilesType(strItemType, strItemCode)
                Me.cmbType.Enabled = False
            ElseIf strItemType = "00" Then   '文档管理
                Me.strItemType = "43"
                getFilesType("43")
            Else '合同制作
                Me.strProjectCode = Me.getProjectCode()
                Me.strCorporationName = Me.getCorporationName()
                Me.strWorkFlowID = Me.getWorkFlowID()
                Me.strTaskID = Me.getTaskID()
                Me.strPerson = Me.getUser()
                Me.strItemType = setItemType(strTaskID)
                getFilesType(strItemType)
            End If

            Me.txtCode.Text = strProjectCode
            Me.txtName.Text = strCorporationName
            Me.txtAuthor.Text = strPerson
            Me.txtTitle.Text = strCorporationName & Me.cmbType.Text
            strPhase = getPhase(strProjectCode)
            strCorporationCode = getCorporationCode(strProjectCode)

            '在TableStyle中添加文档类型一列
            addFileTypeName()
            '设置TextBox的Enabled属性
            setTextBox(False)
            '获取并显示文档信息
            dsFiles = getFilesContent()
            If Not dsFiles Is System.DBNull.Value Then
                dgFiles.DataSource = dsFiles.Tables("TProjectFile")
                Try
                    Me.bmDocument = Me.BindingContext(dsFiles, "TProjectFile")
                Catch ex As Exception
                    'MsgBox(ex.Message)
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
                Me.dsFiles.AcceptChanges()
            End If

            If isButtonEnable Then
                setButtonEnable(False)
            Else
                '根据选择的记录是否上载了文件,设置"打开"按钮的Enabled
                setButton()
            End If
            '根据不同任务,设置标题
            If Me.isCmbTypeEnable Then
                If isButtonEnable Then
                    Me.Text = "查看" & Me.cmbType.Text
                Else
                    Me.Text = "制作" & Me.cmbType.Text
                End If
            End If
            dgFiles_CurrentCellChanged(sender, e)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '
    '在TableStyles中添加一显示列:type_name
    '
    Private Sub addFileTypeName()
        Dim fileType As New DataGridTextBoxColumn()
        fileType.MappingName = "type_name"
        fileType.NullText = ""
        fileType.HeaderText = "类型"
        fileType.Width = 120
        dgFiles.TableStyles(0).GridColumnStyles.Add(fileType)
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
    '
    '从数据库中按Project_code获取文档的信息,包括标题、作者、日期等
    '
    Private Function getFilesContent() As DataSet
        Dim ds As DataSet
        Dim dsItem As DataSet  '获得Item表的类型名称
        Dim i As Integer
        If Not gWs Is Nothing Then
            Try
                ds = gWs.GetProjectFileByCondition("{project_code='" & strProjectCode & "' and item_type='" & strItemType & "'}")
                dsItem = getItemDataSet(strItemType)
                ds.Tables("TProjectFile").Columns.Add("type_name", GetType(String))
                ds.Tables("TProjectFile").Columns.Add("is_file", GetType(Boolean))
                Dim j As Integer
                j = ds.Tables("TProjectFile").Rows.Count
                For j = 0 To j - 1
                    Dim str_item_code, str_item_type As String

                    If Not ds.Tables("TProjectFile").Rows(j).Item("item_code") Is System.DBNull.Value Then
                        str_item_code = ds.Tables("TProjectFile").Rows(j).Item("item_code")
                    Else
                        Exit For
                    End If

                    If Not str_item_type = ds.Tables("TProjectFile").Rows(j).Item("item_type") Is System.DBNull.Value Then
                        str_item_type = ds.Tables("TProjectFile").Rows(j).Item("item_type")
                    Else
                        Exit For
                    End If

                    If Not dsItem.Tables("TItem").Select("item_code='" & str_item_code & "' and item_type='" & str_item_type & "'")(0).Item("item_name") Is System.DBNull.Value Then
                        ds.Tables("TProjectFile").Rows(j).Item("type_name") = dsItem.Tables("TItem").Select("item_code='" & str_item_code & "' and item_type='" & str_item_type & "'")(0).Item("item_name")
                    Else
                        ds.Tables("TProjectFile").Rows(j).Item("type_name") = "未知的文件类型"
                    End If

                    '判断是否有文件
                    If Not ds.Tables("TProjectFile").Rows(j).Item("relation_num") Is System.DBNull.Value Then
                        ds.Tables("TProjectFile").Rows(j).Item("is_file") = True
                    Else
                        ds.Tables("TProjectFile").Rows(j).Item("is_file") = False
                    End If
                Next
            Catch ex As Exception
                'MsgBox("获取文档类型出错!" & ex.Message, MsgBoxStyle.Critical, "提示")
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
        Return ds
    End Function
    '
    '新增文件列表中的一条记录
    '
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        If Not dsFiles Is System.DBNull.Value Then
            If btnNew.Text = "新 增(&N)" Then
                setTextBox(True)
                Me.txtTitle.Focus()
                delBinding()
                addBinding()
                addDocumentRecord()
                isNewBtnClick = True
                btnNew.Text = "取 消(&C)"
                Me.dgFiles.Enabled = False
                Me.btnDelete.Enabled = False
                Me.btnModify.Enabled = False
                Me.btnUpload.Enabled = False
                Me.btnOpen.Enabled = False
                If Not isMakeDocButten Then
                    Me.btnMakeDoc.Enabled = False
                End If
            ElseIf btnNew.Text = "取 消(&C)" Then

                Dim index As Integer = dsFiles.Tables("TProjectFile").Rows.Count - 1
                If index >= 0 Then
                    Dim strMaterialName As String
                    strMaterialName = dsFiles.Tables("TProjectFile").Rows(index).Item("title")
                    btnNew.Text = "新 增(&N)"
                    Me.dgFiles.Enabled = True
                    Me.btnDelete.Enabled = True
                    Me.btnModify.Enabled = True
                    Me.btnUpload.Enabled = True
                    Me.btnOpen.Enabled = True
                    If Not isMakeDocButten Then
                        Me.btnMakeDoc.Enabled = True
                    End If
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
    End Sub
    '
    '添加绑定
    '
    Private Sub addBinding()
        Me.txtTitle.DataBindings.Add("Text", Me.dsFiles.Tables("TProjectFile"), "title")
        Me.txtAuthor.DataBindings.Add("Text", Me.dsFiles.Tables("TProjectFile"), "author")
        Me.txtVersion.DataBindings.Add("Text", Me.dsFiles.Tables("TProjectFile"), "version")
        Me.dateCreate.DataBindings.Add("Value", Me.dsFiles.Tables("TProjectFile"), "date")
        Me.txtRemark.DataBindings.Add("Text", Me.dsFiles.Tables("TProjectFile"), "remark")
        Me.cmbType.DataBindings.Add("Text", Me.dsFiles.Tables("TProjectFile"), "type_name")
    End Sub
    '
    '删除绑定
    '
    Private Sub delBinding()
        Me.txtTitle.DataBindings.Clear()
        Me.txtAuthor.DataBindings.Clear()
        Me.txtVersion.DataBindings.Clear()
        Me.dateCreate.DataBindings.Clear()
        Me.txtRemark.DataBindings.Clear()
        Me.cmbType.DataBindings.Clear()
    End Sub
    '
    '向project_file表中新增一条记录
    '同时向project_document表中也添加一条记录
    '
    Private Sub addDocumentRecord()
        Me.txtTitle.Text = strCorporationName & Me.cmbType.Text
        Me.txtAuthor.Text = strPerson
        Me.txtVersion.Text = "1.0"
        Me.txtRemark.Text = ""
        Dim dr As DataRow
        Dim itemCode As String
        Try
            Me.dateCreate.Value = gWs.GetSysTime()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not Me.txtTitle.Text = "" Then
            itemCode = getItemCode(Me.cmbType.Text)
            If itemCode = "" Or itemCode Is Nothing Then
                MsgBox("新增记录错误!", MsgBoxStyle.Critical + MsgBoxStyle.OKOnly, "新增提示")
                Exit Sub
            End If
            dr = dsFiles.Tables("TProjectFile").NewRow

            With dr
                .Item("project_code") = strProjectCode
                .Item("item_type") = strItemType
                .Item("item_code") = itemCode
                .Item("title") = Me.txtTitle.Text
                .Item("author") = Me.txtAuthor.Text
                Try
                    .Item("date") = gWs.GetSysTime()
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
                .Item("version") = Me.txtVersion.Text
                .Item("remark") = Me.txtRemark.Text
                .Item("type_name") = Me.cmbType.Text
                .Item("create_person") = strPerson
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
        Else
            'MsgBox("请输入标题的内容!", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1001", "标题")
            Me.txtTitle.Focus()
        End If
    End Sub
    '文件类型的选择
    Private Sub cmbType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectedValueChanged
        If Not count = 0 And isNewBtnClick Then
            Me.txtTitle.Text = Me.strCorporationName & Me.cmbType.Text
            strProTitle = Me.txtTitle.Text
            Dim dr As DataRow
            Dim i As Integer
            If Not dsFiles Is Nothing Then
                i = dsFiles.Tables("TProjectFile").Rows.Count
                If i > 0 Then
                    dr = dsFiles.Tables("TProjectFile").Rows(i - 1)
                    With dr
                        .Item("type_name") = Me.cmbType.Text
                        .Item("item_type") = strItemType
                        strProItemCode = getItemCode(Me.cmbType.Text)
                        .Item("item_code") = strProItemCode
                        .Item("title") = strCorporationName & Me.cmbType.Text
                    End With
                End If
            End If
        End If
        count = count + 1
    End Sub
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

        '2008-3-5 YJF ADD 判断是否为系统制作的PDF合同,如果是则使用PDF制作并打开
        If Not dsFiles.Tables(0).Rows(index).Item("serial_num") Is System.DBNull.Value Then
            strSerialNum = dsFiles.Tables(0).Rows(index).Item("serial_num")
            Dim strContractName As String = dsFiles.Tables(0).Rows(index).Item("title")
            strItemType = dsFiles.Tables(0).Rows(index).Item("item_type")
            strItemCode = dsFiles.Tables(0).Rows(index).Item("item_code")

            Dim dsTempItem As DataSet = gWs.GetItemEx("{item_type='" & strItemType & "' and item_code='" & strItemCode & "'}")
            Dim strPDFRemark = IIf(IsDBNull(dsTempItem.Tables(0).Rows(0).Item("additional_remark")), "", dsTempItem.Tables(0).Rows(0).Item("additional_remark"))
            If strPDFRemark = "PDF" Then
                PrintPDF(Me.getProjectCode, strItemType, strItemCode, strContractName)
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
        End If

        strFileName = dsFiles.Tables(0).Rows(index).Item("title")
        If Not dsFiles.Tables(0).Rows(index).Item("relation_num") Is System.DBNull.Value Then
            strRelationNum = dsFiles.Tables(0).Rows(index).Item("relation_num")
            strSerialNum = dsFiles.Tables(0).Rows(index).Item("serial_num")
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
            Dim docClass As New frmDocumentClass(strCorporationName)
            docClass.openFileBySerial(strSerialNum, strDir)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '
    '对选中记录上载某个文件保存到数据库
    '从project_files获得serial_num，再从project_document获得file_relation_num
    '注：file_relation_num在新增时就从relation_num表获得,保存在project_document中
    '
    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Me.Cursor = Cursors.WaitCursor
        Dim index As Integer
        Dim strSerialNum As String
        Dim strRelationNum As String = System.DBNull.Value.ToString
        index = dgFiles.CurrentRowIndex
        If index < 0 Then
            Exit Sub
        End If
        If Not dsFiles.Tables(0).Rows(index).Item("serial_num") Is System.DBNull.Value Then
            strSerialNum = dsFiles.Tables(0).Rows(index).Item("serial_num")
            strItemType = dsFiles.Tables(0).Rows(index).Item("item_type")
            strItemCode = dsFiles.Tables(0).Rows(index).Item("item_code")

            '2008-3-5 YJF ADD 判断是否为系统制作的PDF合同,如果是则提示“该合同由系统制作,不必上载”
            Dim dsTempItem As DataSet = gWs.GetItemEx("{item_type='" & strItemType & "' and item_code='" & strItemCode & "'}")
            Dim strPDFRemark = IIf(IsDBNull(dsTempItem.Tables(0).Rows(0).Item("additional_remark")), "", dsTempItem.Tables(0).Rows(0).Item("additional_remark"))
            If strPDFRemark = "PDF" Then
                MsgBox("该合同由系统制作,不必上载", MsgBoxStyle.Information, "合同制作")
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Dim ds As DataSet
            Dim i As Integer
            Dim strSql As String
            strSql = "{project_code='" & strProjectCode & "' and item_type='" & strItemType & "' and item_code='" & strItemCode & "'}"
            Try
                ds = gWs.GetProjectDocumentByCondition(strSql)
                i = ds.Tables("TProjectDocument").Rows.Count
                If i = 1 Then
                    strRelationNum = ds.Tables("TProjectDocument").Rows(0).Item("file_relation_num")
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        Else
            'MsgBox("该记录未保存!不能上载文件.", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$X020")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Dim docClass As New frmDocumentClass(strCorporationName)
        Dim strResult As String
        'If Me.cmbType.Text.StartsWith("保后检查记录表") Then
        If strItemType = "45" And strItemCode = "003" Then
            strResult = docClass.uploadDocumentForCheckRecord(strSerialNum, strRelationNum, True, False)
        Else
            strResult = docClass.uploadDocument(strSerialNum, strRelationNum, True, True)
        End If
        If strResult = "1" Then
            relationNumSucceed = strSerialNum
            dsFiles = getFilesContent()
            Me.dgFiles.DataSource = dsFiles.Tables("TProjectFile")
            Me.dsFiles.AcceptChanges()
            setButton()
        End If
        Me.Cursor = Cursors.Default
    End Sub
    '
    '把文件列表中新增的记录保存到数据库中
    '
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnNew.Text = "新 增(&N)"
        btnModify.Text = "修 改(&M)"
        Me.dgFiles.Enabled = True
        Me.btnNew.Enabled = True
        Me.btnModify.Enabled = True
        Me.btnDelete.Enabled = True
        Me.btnUpload.Enabled = True
        Me.btnOpen.Enabled = True
        If Not isCmbTypeEnable Then
            Me.cmbType.Enabled = True
        End If
        If Not isMakeDocButten Then
            Me.btnMakeDoc.Enabled = True
        End If
        setTextBox(False)
        'qxd add 2003-9-25
        Try
            If Me.bmDocument.Count > 0 Then
                Me.dgFiles.CurrentRowIndex = Me.bmDocument.Count - 1
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        'qxd end 
        delBinding()
        'isNewBtnClick = False
        Dim strResult As String
        Try
            '向project_document中添加记录
            addDocument()
            strResult = gWs.UpdateProjectFile(dsFiles.GetChanges())
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        '2008-6-20 yjf add 保存前需要做的动作
        BeforeSave()

        If "1" = strResult Then
            'MsgBox("保存成功!", MsgBoxStyle.Information, "提示")
            SWDialogBox.MessageBox.Show("$SaveSucceed")
            dsFiles.Clear()
            dsFiles = getFilesContent()
            If Not dsFiles Is System.DBNull.Value Then
                Me.dgFiles.DataSource = dsFiles.Tables("TProjectFile")
                Me.dsFiles.AcceptChanges()
                Me.bmDocument = Me.BindingContext(dsFiles, "TProjectFile")
                Me.dgFiles.CurrentRowIndex = currentIndex 'qxd modify 2003-5-22
                If isNewBtnClick Then
                    Me.dgFiles.CurrentRowIndex = Me.bmDocument.Count - 1
                End If
            End If
        Else
            'MsgBox("保存失败!" & strResult, MsgBoxStyle.Critical, "提示")
            SWDialogBox.MessageBox.Show("*999", "", strResult, "")
        End If
        isNewBtnClick = False
        setButton()
    End Sub

    '2008-6-20 yjf add 保存前需要做的动作
    Protected Overridable Function BeforeSave()

    End Function
    '
    '向project_document表中添加记录
    '
    Private Sub addDocument()
        '向project_document表中添加记录
        'If strProItemCode = "" Then
        strProItemCode = getItemCode(Me.cmbType.Text)
        'End If
        If strProTitle = "" Then
            strProTitle = Me.strCorporationName & Me.cmbType.Text
        End If
        Dim itemCode As String = strProItemCode
        Dim ds As DataSet
        Dim drTemp As DataRow
        Dim i As Integer
        Dim strSql As String
        strSql = "{project_code='" & strProjectCode & "' and item_type='" & strItemType & "' and item_code='" & itemCode & "'}"
        Try
            ds = gWs.GetProjectDocumentByCondition(strSql)
            i = ds.Tables("TProjectDocument").Rows.Count
            If i = 0 Then
                drTemp = ds.Tables("TProjectDocument").NewRow
                With drTemp
                    .Item("project_code") = strProjectCode
                    .Item("phase") = getPhase(strProjectCode)
                    .Item("item_type") = strItemType
                    .Item("item_code") = itemCode
                    .Item("doc_name") = strProTitle
                    .Item("file_relation_num") = Me.getRelationNumber()
                    ' 2003-6-4 add by qxd
                    .Item("check_person") = strPerson
                    Try
                        .Item("check_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                    ' add end 
                    .Item("create_person") = strPerson
                    Try
                        .Item("create_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
                ds.Tables("TProjectDocument").Rows.Add(drTemp)
                gWs.UpdateProjectDocument(ds.GetChanges())
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '制作文档
    Public Sub btnMakeDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeDoc.Click
        Dim isOpenExcel As Boolean = False '是否打开Excel
        Dim docType As String '文件类型
        Dim ds As DataSet
        Dim i As Integer
        Dim strItemType As String
        Dim strItemCode As String
        Dim strFileType As String
        'qxd add 2003-10-30
        Dim strTemp As String

        strFileType = Me.cmbType.Text
        If strFileType = "" Then
            'MsgBox("请选中文档类型!", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1005", "文档类型")
            Me.cmbType.Focus()
            Exit Sub
        End If
        If Not System.IO.Directory.Exists(Application.StartupPath & strDir) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & strDir)
        End If
        strItemType = getItemType(strFileType)
        strItemCode = getItemCode(strFileType)
        If Not gWs Is Nothing Then
            Dim word1 As Word.ApplicationClass
            Dim excel1 As Excel.ApplicationClass
            Try
                ds = gWs.GetFileTemplateByCondition("{item_type='" & strItemType & "' and item_code ='" & strItemCode & "' and is_current_ver='1' order by version DESC}")
                i = ds.Tables("TFileTemplate").Rows.Count
                If i > 0 Then
                    With ds.Tables("TFileTemplate").Rows(0)
                        If Not .Item("template") Is System.DBNull.Value Then
                            Me.Cursor = Cursors.WaitCursor
                            Dim data As Byte() = .Item("template")
                            docType = .Item("doc_type")
                            docType = docType.Trim
                            Dim myfilestream As System.IO.FileStream
                            Dim strPath As String
                            Dim isThread As Boolean = False

                            strTemp = getLegalFileName(strCorporationName) & strFileType ' qxd add 2003-10-30
                            strPath = Application.StartupPath & strDir & strTemp
                            If docType.Trim = "doc" Then
                                strPath = strPath & ".doc"
                            Else
                                strPath = strPath & ".xls"
                            End If
                            '判断文件是否存在,如果存在则删除;如果删除出错,说明文件已经被另一进程占用了.则不创建新的文件
                            If System.IO.File.Exists(strPath) Then
                                Try
                                    System.IO.File.Delete(strPath)
                                Catch
                                    isThread = True
                                End Try
                            End If
                            If Not isThread Then
                                'myfilestream = New System.IO.FileStream(strPath, IO.FileMode.Create, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite)
                                myfilestream = New System.IO.FileStream(strPath, IO.FileMode.Create)
                                myfilestream.Write(data, 0, data.Length)
                                myfilestream.Close()
                            End If

                            Dim j As Integer
                            Dim ar As String() '字符数组
                            Dim replace As ArrayList '动态数组
                            '文档替换标记和替换内容
                            Dim flagContent As frmFlagContentClass
                            flagContent = New frmFlagContentClass(strProjectCode, strCorporationName, strCorporationCode, strPhase)
                            '判断是哪个文档,不同文档有不同的标记
                            Dim cmbTypeText As String
                            cmbTypeText = getSelectCase(Me.cmbType.Text)
                            Select Case cmbTypeText
                                Case "45002" '"评审报告(流动资金贷款担保)"
                                    isOpenExcel = True
                                    ar = flagContent.getReviewDocFlag(cmbTypeText) '得到模板文档的特殊标记
                                    replace = flagContent.getReviewReplace(cmbTypeText) '得到数据库的对应特殊标记的内容
                                Case "45102" '"评审报告(保函)"
                                    isOpenExcel = True
                                    ar = flagContent.getReviewDocFlag(cmbTypeText) '得到模板文档的特殊标记
                                    replace = flagContent.getReviewReplace(cmbTypeText) '得到数据库的对应特殊标记的内容
                                Case "45202"
                                    isOpenExcel = True
                                    ar = flagContent.getReviewDocFlag(cmbTypeText) '得到模板文档的特殊标记
                                    replace = flagContent.getReviewReplace(cmbTypeText) '得到数据库的对应特殊标记的内容
                                Case "45001" '"初审报告"
                                    isOpenExcel = True
                                    ar = flagContent.getFirstInstanceDocFlag()
                                    replace = flagContent.getFirstInstanceReplace()
                                Case "45004" '"项目终止报告"
                                    ar = flagContent.getTerminateReportDocFlag()
                                    replace = flagContent.getTerminateReplace()
                                Case "45007" '"评估作价报告"
                                    ar = flagContent.getEvaluateReportDocFlag()
                                    replace = flagContent.getEvaluateReplace()
                                    '导入反担保物记录到Excel中
                                    'qxd modify 2003-11-4
                                    If Not newEvaluateExcel() Then
                                        Exit Sub
                                    End If
                                Case "43005" '"质押反担保合同"
                                    ar = flagContent.getImpawnContractFlag()
                                    replace = flagContent.getImpawnContractReplace()
                                Case "43004" '"抵押反担保合同"
                                    ar = flagContent.getPledgeContractFlag()
                                    replace = flagContent.getPledgeContractReplace()
                                Case "43003" '"保证合同"
                                    ar = flagContent.getAssureContractFlag()
                                    replace = flagContent.getAssureContractReplace()
                                Case "43006" '"企业保证反担保合同"
                                    ar = flagContent.getAssureOppContractFlag()
                                    replace = flagContent.getAssureOppContractReplace()
                                Case "43001" '"委托保证合同"
                                    ar = flagContent.getDelegateContractFlag()
                                    replace = flagContent.getDelegateContractReplace()
                                Case "43002" '"委托贷款合同"
                                    ar = flagContent.getDelegateLoanContractFlag()
                                    replace = flagContent.getDelegateLoanContractReplace()
                                Case "43007" '"个人保证合同"
                                    ar = flagContent.getPersonalOppContractFlag()
                                    replace = flagContent.getPersonalOppContractReplace()
                                Case "43201" '开立额度保函协议书
                                    ar = flagContent.getLetterProtocolFlag()
                                    replace = flagContent.getLetterProtocolReplace()
                                Case "43108" '开立保函确认书
                                    ar = flagContent.getLetterAffirmFlag()
                                    replace = flagContent.getLetterAffirmReplace()
                                Case "43107" '个人保证合同(保函)
                                    ar = flagContent.getLetterPledgeFlag()
                                    replace = flagContent.getLetterPledgeReplace()
                                Case "43203" '再担保合同
                                    ar = flagContent.getReGuaranteeFlag()
                                    replace = flagContent.getReGuaranteeReplace()
                                Case Else
                                    '  其他文档替换
                                    ' "项目处理意见表"
                                    ' "项目审批表"
                                    ' "担保意向通知书"
                                    ' "委托放款通知书"
                                    ' "担保放款通知书"
                                    ar = key
                                    replace = value
                            End Select

                            If Not replace Is Nothing Then
                                Dim replaceCount, arLength As Integer
                                replaceCount = replace.Count
                                If Not ar Is Nothing Then
                                    arLength = ar.Length
                                Else
                                    Me.Cursor = Cursors.Default
                                    Exit Sub
                                End If
                                If replaceCount > 0 And (replaceCount = arLength) Then
                                    '打开Word文档
                                    If docType.Trim = "doc" Then
                                        word1 = New Word.ApplicationClass
                                        word1.Application.Documents.Add(strPath)
                                        'word1.Application.Documents.Open(strPath)
                                        For j = 0 To arLength - 1
                                            replaceText(word1, ar(j), replace(j)) '替换特殊标记
                                        Next
                                        '显示文档
                                        'qxd modify 2003-10-30
                                        'word1.ActiveDocument.SaveAs(strPath)
                                        'word1.Caption = strTemp
                                        'qxd end 
                                        word1.Application.Visible = True
                                    Else
                                        excel1 = New Excel.ApplicationClass
                                        excel1.Application.Workbooks.Add(strPath)

                                        Dim rang As Excel.Range
                                        rang = excel1.ActiveWorkbook.Sheets(1).Cells

                                        For j = 0 To arLength - 1
                                            ReplaceExcelSign(rang, ar(j), replace(j))  '替换特殊标记
                                        Next

                                        importSpecialData(rang, strProjectCode)
                                        excel1.Application.Visible = True
                                    End If
                                Else
                                    isOpenExcel = False
                                    'MsgBox("获取项目企业信息出错!" & Chr(13) & "无法制作《" & strCorporationName + strFileType & "》.", MsgBoxStyle.Exclamation, "提示")
                                    '''MsgBox("该项目处于：""" & strPhase & """ 阶段,没有相应的项目企业信息!" & Chr(13) & "无法制作《" & strCorporationName + strFileType & "》.", MsgBoxStyle.Exclamation, "提示")
                                    SWDialogBox.MessageBox.Show("$X015", strCorporationName + strFileType)
                                End If
                            Else
                                'MsgBox("无须制作《" & strCorporationName + strFileType & "》!", MsgBoxStyle.Exclamation, "提示")
                                SWDialogBox.MessageBox.Show("$X017", strCorporationName + strFileType)
                            End If

                            Me.Cursor = Cursors.Default
                        Else
                            'MsgBox("《" & strFileType & "》的模板文件不存在!", MsgBoxStyle.Exclamation, "提示")
                            SWDialogBox.MessageBox.Show("$2002", strFileType)
                        End If
                    End With
                Else
                    'MsgBox("当前版本《" & strFileType & "》的模板文件不存在!", MsgBoxStyle.Exclamation, "提示")
                    'SWDialogBox.MessageBox.Show("$2002", strFileType)
                    Dim strMessage As String = "当前版本《" & strFileType & "》的文件模板不存在!"
                    SWDialogBox.MessageBox.Show(strMessage, "系统提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                '关闭打开的文件
                If Not word1 Is Nothing Then
                    word1.Application.Documents.Close()
                    '退出Word,且不提示是否保存
                    CType(word1.Application, Word.ApplicationClass).Quit(Word.WdSaveOptions.wdDoNotSaveChanges)
                End If
                If Not excel1 Is Nothing Then
                    excel1.Application.Workbooks.Close()
                    '退出Excel,且不提示是否保存
                    CType(excel1.Application, Excel.ApplicationClass).Quit()
                End If
                'MsgBox("文件已经打开或文件有误!", MsgBoxStyle.Exclamation, "提示")
                ExceptionHandler.ShowMessageBox(ex)
                Exit Sub
            Finally
                Me.Cursor = Cursors.Default
                word1 = Nothing
                excel1 = Nothing
                GC.Collect()
            End Try
        End If
        ' 只有文档时，才需要导入Excel，合同管理时不需要导入；根据isOpenExcel判断。qxd add 2003-5-10
        Try
            If Not Me.Name = "frmDocumentManageBusiness" Then
                Exit Sub
            End If
            If Not isOpenExcel Then
                Exit Sub
            End If
            Dim import As New frmImportDataToExcel(strProjectCode, strCorporationName)
            Dim strPhase As String
            Dim strExcelFile As String
            strExcelFile = Me.cmbType.Text
            If strExcelFile = "" Then
                strExcelFile = "文档"
            End If
            strPhase = Me.getPhase(strProjectCode)
            Dim strOppCorporationCode As String
            strOppCorporationCode = getFieldName("corporation_code", "2")
            import.importExcel(strProjectCode, strExcelFile, strPhase, "所有表", strOppCorporationCode)
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            GC.Collect()
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    '评估作价报告
    '导入反担保物记录到Excel中
    Private Function newEvaluateExcel()
        '导入反担保物记录到Excel中
        Dim evaExcel As New Excel.ApplicationClass
        Dim workBook As Excel.WorkbookClass
        Dim workSheet As Excel.Worksheet
        Dim rang As Excel.Range
        Dim strExcelFile As String

        'qxd modify 2003-11-4
        'strExcelFile = Application.StartupPath & "\评估作价报告.xls"
        strExcelFile = Application.StartupPath & strDir & "评估作价报告.xls"


        Try
            If System.IO.File.Exists(strExcelFile) Then
                System.IO.File.Delete(strExcelFile)
            End If
            'evaExcel.Application.Workbooks.Add(strExcelFile)
            evaExcel.Application.Workbooks.Add()
            evaExcel.Application.Workbooks(1).SaveAs(strExcelFile)
            workBook = evaExcel.ActiveWorkbook
            workSheet = workBook.Sheets(1)
            rang = workSheet.Cells

            workSheet.Select()
            Dim import As New frmImportDataToExcel(strProjectCode, strCorporationName)
            Dim strPhase As String
            strPhase = Me.getPhase(strProjectCode)
            import.importOppGuarantee(rang, strPhase)
            rang.Columns.AutoFit()
            evaExcel.Application.Visible = True
            Return True
        Catch ex As Exception
            'MsgBox("请确保在目录" & Application.StartupPath & "下，存在文件： 《评估作价报告.xls》.", MsgBoxStyle.Exclamation, "提示")
            'SWDialogBox.MessageBox.Show("$2002", "评估作价报告.xls")
            If Not evaExcel Is Nothing Then
                evaExcel.Application.Workbooks.Close()
                CType(evaExcel.Application, Excel.ApplicationClass).Quit()
                evaExcel = Nothing
            End If
            ExceptionHandler.ShowMessageBox(ex)
            Return False
        End Try
    End Function
    '
    '替换文档中的的指定字符
    '
    Private Sub replaceText(ByVal word1 As Word.ApplicationClass, ByVal strFlag As String, ByVal strReplace As String)
        Dim docActive As Word.DocumentClass
        Dim content As Word.Range
        Dim fd As Word.Find

        docActive = word1.ActiveDocument
        content = docActive.Content
        fd = content.Find

        fd.Format = True
        'fd.MatchCase = false '不区分大小写
        fd.MatchCase = True '区分大小写
        fd.ClearFormatting() '清除格式
        fd.MatchWholeWord = True '查找完整的单词
        fd.MatchWildcards = False '不查找包含通配符
        fd.Wrap = Word.WdFindWrap.wdFindContinue '到达文末后，从头继续查找
        'fd.Replacement.ClearFormatting() '清除替换后的格式
        fd.Replacement.Style = Word.WdReplace.wdReplaceAll '替换所有

        Try
            If Not strReplace Is Nothing AndAlso strReplace.Length > 255 Then
                Dim strTemp As String
                Dim i As Int16
                For i = 0 To (strReplace.Length \ 230 + 1) - 2 '最后一次替换在后面完成
                    strTemp = strReplace.Substring(230 * i, 230) + strFlag
                    fd.Execute(strFlag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strTemp, Word.WdReplace.wdReplaceAll, Nothing, Nothing, Nothing, Nothing)
                Next
                strTemp = strReplace.Substring(i * 230)
                strReplace = strTemp
            End If
            'fd.Execute(strFlag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strReplace)
            fd.Execute(strFlag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strReplace, Word.WdReplace.wdReplaceAll, Nothing, Nothing, Nothing, Nothing)
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        fd = Nothing
        content = Nothing
        docActive = Nothing
    End Sub
    '
    '替换Excel文档的标记
    '
    Private Sub ReplaceExcelSign(ByVal rang As Excel.Range, ByVal strFlag As String, ByVal strReplace As String)

        rang.Replace(strFlag, strReplace, Excel.XlLookAt.xlWhole, Excel.XlSearchOrder.xlByRows, True)
    End Sub
    '设置textbox的enable属性
    Private Sub setTextBox(ByVal isEnabled As Boolean)
        Me.txtTitle.Enabled = isEnabled
        Me.txtAuthor.Enabled = isEnabled
        Me.dateCreate.Enabled = isEnabled
        Me.cmbType.Enabled = isEnabled
        Me.txtVersion.Enabled = isEnabled
        Me.txtRemark.Enabled = isEnabled
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
    'KeyPress事件
    Private Sub frmDocumentManageBusiness_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
    End Sub
    'Closing事件
    Private Sub frmDocumentManageBusiness_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If sender.GetType Is GetType(Form) Then
            If frmExit(sender, e) Then
                e.Cancel = True
            End If
        End If
    End Sub
    '设置Button的Enable属性
    Public Sub setButtonEnable(ByVal isEnable As Boolean)
        Me.btnNew.Enabled = isEnable
        Me.btnUpload.Enabled = isEnable
        Me.btnSave.Enabled = isEnable
        Me.btnMakeDoc.Enabled = isEnable
        Me.btnDelete.Enabled = isEnable
        Me.btnModify.Enabled = isEnable
        Me.btnOpen.Enabled = isEnable
    End Sub
    '删除
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Not Me.dsFiles Is Nothing Then
            'If MsgBoxResult.OK = MsgBox("确定删除选中的记录吗?", MsgBoxStyle.Question + MsgBoxStyle.OKCancel, "提示") Then
            If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1004", "选中的") Then
                Dim i As Integer
                i = Me.dgFiles.CurrentRowIndex
                If i >= 0 Then
                    Dim projectCode, itemType, itemCode, relationNum As String
                    With Me.dsFiles.Tables("TProjectFile").Rows(i)
                        projectCode = .Item("project_code")
                        itemType = .Item("item_type")
                        itemCode = .Item("item_code")
                        If Not .Item("relation_num") Is System.DBNull.Value Then
                            relationNum = .Item("relation_num")
                        Else
                            relationNum = System.DBNull.Value.ToString
                        End If
                        .Delete()
                    End With
                    '同时删除project_document中的记录
                    Dim nDelCount As Integer
                    Dim strSql As String
                    strSql = "project_code='" & projectCode & "' and item_type='" & itemType & "' and item_code='" & itemCode & "'"
                    nDelCount = Me.dsFiles.Tables("TProjectFile").Select(strSql).Length()
                    If nDelCount = 0 Then '表示有一个记录
                        delectDocument(projectCode, itemType, itemCode)

                        '2008-2-20 yjf add 如果文档类型为合同，同时删除合同要素记录
                        delectElement(projectCode, itemType, itemCode)
                    End If


                    Try
                        gWs.UpdateProjectFile(Me.dsFiles.GetChanges())
                    Catch
                    End Try

                    dsFiles = getFilesContent()
                    If Not dsFiles Is System.DBNull.Value Then
                        dgFiles.DataSource = dsFiles.Tables("TProjectFile")
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
    '
    '同时删除project_document中的记录
    '
    Private Function delectDocument(ByVal projectCode As String, ByVal itemType As String, ByVal itemCode As String)
        Dim dsDocument As DataSet
        Dim strSql As String
        Dim i As Integer
        Try
            If gWs Is Nothing Then
                Exit Function
            End If
            strSql = "{project_code='" & projectCode & "' and item_type='" & itemType & "' and item_code='" & itemCode & "'}"
            dsDocument = gWs.GetProjectDocumentByCondition(strSql)
            i = dsDocument.Tables("TProjectDocument").Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    dsDocument.Tables("TProjectDocument").Rows(i).Delete()
                Next
                gWs.UpdateProjectDocument(dsDocument)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    '同时删除project_contract_element中的记录
    '
    Private Function delectElement(ByVal projectCode As String, ByVal itemType As String, ByVal itemCode As String)
        Dim dsElement As DataSet
        Dim strSql As String
        Dim i As Integer
        Try
            If gWs Is Nothing Then
                Exit Function
            End If
            strSql = "{project_code='" & projectCode & "' and item_type='" & itemType & "' and item_code='" & itemCode & "'}"
            dsElement = gWs.GetProjectContractElementInfo(strSql)
            i = dsElement.Tables(0).Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    dsElement.Tables(0).Rows(i).Delete()
                Next
                gWs.UpdateProjectContractElement(dsElement)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    '点中datagrid做的事件
    Private Sub setTextContent()
        currentIndex = Me.dgFiles.CurrentCell.RowNumber
        Static lastRow As Integer = -1
        Me.dgFiles.Select(Me.dgFiles.CurrentCell.RowNumber)

        If Me.dgFiles.CurrentRowIndex <> lastRow Then
            Dim index As Integer = dgFiles.CurrentRowIndex()
            If index >= 0 Then
                Dim strMaterialName As String
                If Not dsFiles.Tables("TProjectFile").Rows(index).Item("title") Is System.DBNull.Value Then
                    strMaterialName = dsFiles.Tables("TProjectFile").Rows(index).Item("title")
                    Me.txtTitle.Text = strMaterialName
                End If
                If Not dsFiles.Tables("TProjectFile").Rows(index).Item("author") Is System.DBNull.Value Then
                    Me.txtAuthor.Text = dsFiles.Tables("TProjectFile").Rows(index).Item("author")
                End If
                If Not dsFiles.Tables("TProjectFile").Rows(index).Item("date") Is System.DBNull.Value Then
                    Me.dateCreate.Value = dsFiles.Tables("TProjectFile").Rows(index).Item("date")
                End If
                If Not dsFiles.Tables("TProjectFile").Rows(index).Item("item_code") Is System.DBNull.Value Then
                    Me.cmbType.Text = getItemName(strItemType, dsFiles.Tables("TProjectFile").Rows(index).Item("item_code"))
                End If
                If Not dsFiles.Tables("TProjectFile").Rows(index).Item("remark") Is System.DBNull.Value Then
                    Me.txtRemark.Text = dsFiles.Tables("TProjectFile").Rows(index).Item("remark")
                End If
                If Not dsFiles.Tables("TProjectFile").Rows(index).Item("version") Is System.DBNull.Value Then
                    Me.txtVersion.Text = dsFiles.Tables("TProjectFile").Rows(index).Item("version")
                End If
            End If
        End If
        setButton()
        lastRow = Me.dgFiles.CurrentRowIndex
    End Sub
    '列表中的鼠标按下事件
    'Private Sub dgFiles_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgFiles.MouseUp
    '    If Me.dsFiles.Tables("TProjectFile").Rows.Count > 0 Then
    '        Me.dgFiles.Select(Me.dgFiles.CurrentCell.RowNumber)
    '        setTextContent()
    '    End If
    'End Sub
    Private Sub dgFiles_CurrentCellChanged(ByVal send As Object, ByVal e As System.EventArgs) Handles dgFiles.CurrentCellChanged
        If Me.dsFiles.Tables("TProjectFile").Rows.Count > 0 Then
            Me.dgFiles.Select(Me.dgFiles.CurrentCell.RowNumber)
            setTextContent()
        End If
    End Sub

    '
    '根据是否有文件,确定"打开","上载","删除"按钮的属性
    '
    Protected Sub setButton()
        Dim dt As DataTable
        Try
            dt = CType(Me.dgFiles.DataSource, DataTable)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    If Not isButtonEnable Then
                        'Me.btnUpload.Enabled = True
                        Me.btnDelete.Enabled = True
                    End If
                    If dt.Rows(Me.dgFiles.CurrentRowIndex).Item("relation_num") Is System.DBNull.Value Then
                        Me.btnOpen.Enabled = False
                        isUpload = True
                        'Me.btnUpload.Enabled = True
                    Else
                        Me.btnOpen.Enabled = True
                        'Me.btnUpload.Enabled = False
                        isUpload = False
                    End If
                Else
                    Me.btnUpload.Enabled = False
                    Me.btnDelete.Enabled = False
                    Me.btnOpen.Enabled = False
                    Me.btnModify.Enabled = False
                End If
            Else
                Me.btnUpload.Enabled = False
                Me.btnDelete.Enabled = False
                Me.btnOpen.Enabled = False
                Me.btnModify.Enabled = False
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        setIsOperate(isUpload)
    End Sub
    '
    '根据类型,设置是否可以进行:删除,修改,上载操作.
    '
    Private Sub setIsOperate(ByVal isUpload As Boolean)
        '去掉类型判断   by 9sky 20050705
        'If Not Me.cmbType.Enabled Then
        Dim dt As DataTable
        Try
            dt = CType(Me.dgFiles.DataSource, DataTable)
            If dt.Rows.Count > 0 Then
                If dt.Rows(Me.dgFiles.CurrentRowIndex).Item("type_name") = Me.cmbType.Text Then
                    If Not isButtonEnable Then
                        Me.btnDelete.Enabled = True
                        Me.btnModify.Enabled = True
                        'if添加类型的判断---------------------------------------qxd 
                        '去掉类型判断   by 9sky 20050701
                        'If Me.cmbType.Text.StartsWith("初审报告") Or Me.cmbType.Text.StartsWith("评审报告") Then
                        If isUpload Then
                            Me.btnUpload.Enabled = True
                            Me.btnDelete.Enabled = True
                        Else
                            Me.btnUpload.Enabled = False
                            Me.btnDelete.Enabled = False
                        End If
                        'Else
                        '    Me.btnUpload.Enabled = True
                        '    Me.btnDelete.Enabled = True
                        'End If
                    End If
                Else
                    Me.btnDelete.Enabled = False
                    Me.btnModify.Enabled = False
                    Me.btnUpload.Enabled = False
                    Me.cmbType.Enabled = False
                End If
            Else
                Me.btnDelete.Enabled = False
                Me.btnModify.Enabled = False
                Me.btnUpload.Enabled = False
                Me.cmbType.Enabled = False
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        'End If
    End Sub
    '修改
    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        If Not Me.dsFiles Is Nothing Then
            If btnModify.Text = "修 改(&M)" Then
                Me.btnDelete.Enabled = False
                Me.btnNew.Enabled = False
                Me.btnOpen.Enabled = False
                Me.btnUpload.Enabled = False
                If Not isMakeDocButten Then
                    Me.btnMakeDoc.Enabled = False
                End If
                Me.cmbType.Enabled = False
                Me.dgFiles.Enabled = False
                currentIndex = Me.dgFiles.CurrentRowIndex
                'qxd add 2003-5-14
                Me.dgFiles.Select(currentIndex)
                setTextBox(True)
                Me.cmbType.Focus()
                delBinding()
                addBinding()
                btnModify.Text = "取 消(&C)"
            ElseIf btnModify.Text = "取 消(&C)" Then
                Me.btnDelete.Enabled = True
                Me.btnNew.Enabled = True
                Me.btnOpen.Enabled = True
                Me.btnUpload.Enabled = True
                If Not isMakeDocButten Then
                    Me.btnMakeDoc.Enabled = True
                End If
                If Not isCmbTypeEnable Then
                    Me.cmbType.Enabled = True
                End If
                Me.dgFiles.Enabled = True
                setTextBox(False)
                btnModify.Text = "修 改(&M)"
                Me.dsFiles.RejectChanges()
                Me.dgFiles.Refresh() 'qxd add 2003-6-7
                delBinding()
                setButton()
            End If
        End If
    End Sub
    '获得project_corporation中的字段值
    Private Function getFieldName(ByVal fieldName As String, ByVal corporationType As String)
        Dim strSql As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer

        If Not gWs Is Nothing Then
            Try
                'strSql = "{project_code='" & strProjectCode & "' and phase='评审' and corporation_type='1'}"
                'ds = gWs.FetchProjectCorporationEx(strSql)
                'ds = gWs.FetchProjectCorporation(strProjectCode, "%", corporationType, "评审")
                ds = gWs.FetchProjectCorporation(Me.getProjectCode(), "%", "1", Me.getPhase(getProjectCode()))
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        '企业名称
                        If Not .Item(fieldName) Is System.DBNull.Value Then
                            Return .Item(fieldName)
                        Else
                            Return ""
                        End If
                    End With
                Else
                    Return ""
                End If
            Catch ex As Exception
                Return ""
            End Try
        End If
    End Function
    '通过文档类型获取SelectCase的判断条件，判断条件为：item_type & item_code
    Private Function getSelectCase(ByVal strFileType As String) As String
        Dim ds As DataSet
        Dim i As Integer
        Dim strSelectCase As String

        If Not gWs Is Nothing Then
            Try
                ds = gWs.GetItem("{item_name='" & strFileType & "'}", Nothing)
                i = ds.Tables("TItem").Rows.Count
                If i > 0 Then
                    With ds.Tables("TItem").Rows(0)
                        strSelectCase = .Item("item_type")
                        strSelectCase = strSelectCase.Trim & .Item("item_code")
                    End With
                    Return strSelectCase.Trim
                End If
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Function

    '保后检查记录表
    Private Sub importSpecialData(ByVal rang As Excel.Range, ByVal projectCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Try
            ds = gWs.FQueryCreditProject(projectCode.Substring(0, 5), "", "", "2099-1-1", "", "", "", UserName)
            If Not ds Is Nothing Then
                Dim d1, d2 As Double
                d1 = 0 : d2 = 0
                For Each dr In ds.Tables(0).Rows
                    d1 += CDbl(IIf(IsDBNull(dr("guarantee_sum")), 0, dr("guarantee_sum")))
                    d2 += CDbl(IIf(IsDBNull(dr("surplus_total")), 0, dr("surplus_total")))
                Next
                '增加合计记录
                dr = ds.Tables(0).NewRow
                dr("service_type") = "合计"
                dr("guarantee_sum") = d1
                dr("surplus_total") = d2
                ds.Tables(0).Rows.Add(dr)

                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    rang.Item(34 + i, 2) = dr("service_type") & String.Empty
                    rang.Item(34 + i, 3) = dr("guarantee_sum") & String.Empty
                    rang.Item(34 + i, 4) = dr("terms") & String.Empty
                    rang.Item(34 + i, 5) = dr("end_date") & String.Empty
                    rang.Item(34 + i, 6) = dr("surplus_total") & String.Empty
                    rang.Item(34 + i, 7) = dr("bank") & String.Empty
                    rang.Item(34 + i, 8) = dr("branch_bank") & String.Empty
                    rang.Item(34 + i, 9) = String.Empty
                Next
                ds.Dispose()
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Cursor = Cursors.WaitCursor
        Dim index As Integer
        Dim strSerialNum As String
        Dim strRelationNum As String = System.DBNull.Value.ToString
        index = dgFiles.CurrentRowIndex
        If index < 0 Then
            Exit Sub
        End If
        If Not dsFiles.Tables(0).Rows(index).Item("serial_num") Is System.DBNull.Value Then
            strSerialNum = dsFiles.Tables(0).Rows(index).Item("serial_num")
            strItemType = dsFiles.Tables(0).Rows(index).Item("item_type")
            strItemCode = dsFiles.Tables(0).Rows(index).Item("item_code")

            '2008-3-5 YJF ADD 判断是否为系统制作的PDF合同,如果是则提示“该合同由系统制作,不必上载”
            Dim dsTempItem As DataSet = gWs.GetItemEx("{item_type='" & strItemType & "' and item_code='" & strItemCode & "'}")
            Dim strPDFRemark = IIf(IsDBNull(dsTempItem.Tables(0).Rows(0).Item("additional_remark")), "", dsTempItem.Tables(0).Rows(0).Item("additional_remark"))
            If strPDFRemark = "PDF" Then
                MsgBox("该合同由系统制作,不必上载", MsgBoxStyle.Information, "合同制作")
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            Dim ds As DataSet
            Dim i As Integer
            Dim strSql As String
            strSql = "{project_code='" & strProjectCode & "' and item_type='" & strItemType & "' and item_code='" & strItemCode & "'}"
            Try
                ds = gWs.GetProjectDocumentByCondition(strSql)
                i = ds.Tables("TProjectDocument").Rows.Count
                If i = 1 Then
                    strRelationNum = ds.Tables("TProjectDocument").Rows(0).Item("file_relation_num")
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        Else
            'MsgBox("该记录未保存!不能上载文件.", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$X020")
            Me.Cursor = Cursors.Default
            Exit Sub
        End If
        Dim docClass As New frmDocumentClass(strCorporationName)
        Dim strResult As String
        'If Me.cmbType.Text.StartsWith("保后检查记录表") Then
        If strItemType = "45" And strItemCode = "003" Then
            strResult = docClass.uploadDocumentForCheckRecord(strSerialNum, strRelationNum, True, False)
        Else
            strResult = docClass.uploadDocument(strSerialNum, strRelationNum, True, True)
        End If
        If strResult = "1" Then
            relationNumSucceed = strSerialNum
            dsFiles = getFilesContent()
            Me.dgFiles.DataSource = dsFiles.Tables("TProjectFile")
            Me.dsFiles.AcceptChanges()
            setButton()
        End If
        Me.Cursor = Cursors.Default
    End Sub
End Class
