

Public Class frmMaterial
    Inherits frmBasic

    '
    'Creater by quexd
    'Create Date 2003-4-8
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
    Protected WithEvents dgMaterial As System.Windows.Forms.DataGrid
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents dateCheck As System.Windows.Forms.DateTimePicker
    Public WithEvents chbFile As System.Windows.Forms.CheckBox
    Public WithEvents txtPerson As System.Windows.Forms.TextBox
    Public WithEvents chbImportant As System.Windows.Forms.CheckBox
    Public WithEvents txtMaterial As System.Windows.Forms.TextBox
    Public WithEvents chbCheck As System.Windows.Forms.CheckBox
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents Panel1 As System.Windows.Forms.Panel
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents cmbType As System.Windows.Forms.ComboBox
    Public WithEvents cmbContent As System.Windows.Forms.ComboBox
    Public WithEvents txtName As System.Windows.Forms.TextBox
    Public WithEvents txtRemark As System.Windows.Forms.TextBox
    Protected WithEvents Label1 As System.Windows.Forms.Label
    Protected WithEvents txtCode As System.Windows.Forms.TextBox
    Protected WithEvents Label2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbContent = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgMaterial = New System.Windows.Forms.DataGrid()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dateCheck = New System.Windows.Forms.DateTimePicker()
        Me.chbFile = New System.Windows.Forms.CheckBox()
        Me.txtPerson = New System.Windows.Forms.TextBox()
        Me.chbCheck = New System.Windows.Forms.CheckBox()
        Me.chbImportant = New System.Windows.Forms.CheckBox()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Location = New System.Drawing.Point(584, 404)
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.Visible = True
        '
        'txtName
        '
        Me.txtName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtName.Location = New System.Drawing.Point(392, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(288, 21)
        Me.txtName.TabIndex = 3
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(336, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 8)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(192, 21)
        Me.txtCode.TabIndex = 1
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
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
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbContent, Me.Label4, Me.cmbType, Me.Label3, Me.Panel1})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(672, 264)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'cmbContent
        '
        Me.cmbContent.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.cmbContent.Items.AddRange(New Object() {"全部资料", "关键资料", "已确认资料", "关键未确认资料"})
        Me.cmbContent.Location = New System.Drawing.Point(424, 16)
        Me.cmbContent.Name = "cmbContent"
        Me.cmbContent.Size = New System.Drawing.Size(240, 20)
        Me.cmbContent.TabIndex = 3
        Me.cmbContent.Text = "全部资料"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(368, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "显示内容"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbType
        '
        Me.cmbType.Enabled = False
        Me.cmbType.Location = New System.Drawing.Point(64, 16)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(192, 20)
        Me.cmbType.TabIndex = 1
        Me.cmbType.Text = "企业材料"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "类    型"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgMaterial})
        Me.Panel1.Location = New System.Drawing.Point(3, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(666, 216)
        Me.Panel1.TabIndex = 0
        '
        'dgMaterial
        '
        Me.dgMaterial.CaptionVisible = False
        Me.dgMaterial.DataMember = ""
        Me.dgMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMaterial.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMaterial.Name = "dgMaterial"
        Me.dgMaterial.Size = New System.Drawing.Size(666, 216)
        Me.dgMaterial.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtRemark, Me.Label11, Me.dateCheck, Me.chbFile, Me.txtPerson, Me.chbCheck, Me.chbImportant, Me.txtMaterial, Me.Label10, Me.Label9, Me.Label8, Me.Label7, Me.Label6, Me.Label5})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 312)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(672, 80)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "资料信息"
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtRemark.Location = New System.Drawing.Point(64, 48)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(216, 24)
        Me.txtRemark.TabIndex = 14
        Me.txtRemark.Text = ""
        '
        'Label11
        '
        Me.Label11.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label11.Location = New System.Drawing.Point(8, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 23)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "备    注"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dateCheck
        '
        Me.dateCheck.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.dateCheck.Location = New System.Drawing.Point(504, 48)
        Me.dateCheck.Name = "dateCheck"
        Me.dateCheck.Size = New System.Drawing.Size(160, 21)
        Me.dateCheck.TabIndex = 13
        '
        'chbFile
        '
        Me.chbFile.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.chbFile.Location = New System.Drawing.Point(648, 16)
        Me.chbFile.Name = "chbFile"
        Me.chbFile.Size = New System.Drawing.Size(16, 24)
        Me.chbFile.TabIndex = 7
        '
        'txtPerson
        '
        Me.txtPerson.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtPerson.Location = New System.Drawing.Point(360, 48)
        Me.txtPerson.Name = "txtPerson"
        Me.txtPerson.Size = New System.Drawing.Size(80, 21)
        Me.txtPerson.TabIndex = 11
        Me.txtPerson.Text = ""
        '
        'chbCheck
        '
        Me.chbCheck.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.chbCheck.Location = New System.Drawing.Point(504, 16)
        Me.chbCheck.Name = "chbCheck"
        Me.chbCheck.Size = New System.Drawing.Size(16, 24)
        Me.chbCheck.TabIndex = 5
        '
        'chbImportant
        '
        Me.chbImportant.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.chbImportant.Location = New System.Drawing.Point(360, 16)
        Me.chbImportant.Name = "chbImportant"
        Me.chbImportant.Size = New System.Drawing.Size(16, 24)
        Me.chbImportant.TabIndex = 3
        '
        'txtMaterial
        '
        Me.txtMaterial.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtMaterial.Location = New System.Drawing.Point(64, 16)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(216, 21)
        Me.txtMaterial.TabIndex = 1
        Me.txtMaterial.Text = ""
        '
        'Label10
        '
        Me.Label10.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label10.Location = New System.Drawing.Point(448, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 23)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "日    期"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label9.Location = New System.Drawing.Point(304, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 23)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "人    员"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label8.Location = New System.Drawing.Point(592, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 23)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "有无文档"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label7.Location = New System.Drawing.Point(448, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 23)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "是否确认"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label6.Location = New System.Drawing.Point(304, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 23)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "是否关键"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "资料名称"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMaterial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(690, 431)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.GroupBox3, Me.GroupBox2, Me.Label2, Me.txtName, Me.Label1, Me.txtCode})
        Me.Name = "frmMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    '
    '从item_type表中获得资料类型
    'Return:ArrayList
    Protected Function getMaterialType() As ArrayList
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strSql As String
        Dim arList As ArrayList
        'item_type分别为;41,42,43,44;表示企业材料,反担保材料,合同列表,放款检查列表
        'strSql = "{item_type='41' or item_type='42' or item_type='43' or item_type='44'}"
        strSql = "{item_type='41' or item_type='42'}"
        Try
            ds = gWs.GetItemType(strSql)
            i = ds.Tables("TItemType").Rows.Count
        Catch ex As Exception
            'MsgBox("获取资料类型错误" & ex.Message, MsgBoxStyle.Critical, "提示")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If i > 0 Then
            arList = New ArrayList()
            For i = 0 To i - 1
                dr = ds.Tables("TItemType").Rows(i)
                With dr
                    arList.Add(dr.Item("type_name"))
                End With
            Next
            Return arList
        Else
            Return Nothing
        End If
    End Function
    '
    '从表project_document中获得资料列表信息
    'projectCode:项目编码
    'itemType:不同的材料类型
    'isImportant:是否关键;"1" 关键;"0" 非关键
    'isCheck: 是否检查核对;true 检查核对过; false 未检查核对过
    'isAll:是否全部显示;true 全部;false 根据以上条件
    'Return:DataSet
    Protected Function getDocumentInfo(ByVal projectCode As String, ByVal itemType As String, ByVal isImportant As String, ByVal isCheck As Boolean, ByVal isAll As Boolean, ByVal isAcceptMaterial As Boolean) As DataSet
        Dim ds As DataSet
        Dim dsFileRelationNum As DataSet
        Dim drFileRelationNum As DataRow
        Dim itemCode As String
        Dim dr As DataRow
        Dim i As Integer
        Dim strSql As String
        Dim strPhase As String = getPhase(projectCode)
        If isAll Then
            '全部资料(,,,,true)
            If itemType = "43" Then '如果是合同,则列出Project_document表中的所有数据;43:表示合同
                strSql = "{project_code='" & projectCode & "' and item_type='" & itemType & "'}"
            Else
                strSql = "{project_code='" & projectCode & "' and item_type='" & itemType & "' and phase='" & strPhase & "'}"
            End If
        Else
            If isImportant = 1 Then
                If isCheck Then
                    '关键资料(,,1,true,false)
                    strSql = "{project_code='" & projectCode & "' and item_type='" & itemType & "' and phase='" & strPhase & "' and is_important='" & isImportant & "'}"
                Else
                    '关键未确认资料(,,1,false,false)
                    strSql = "{project_code='" & projectCode & "' and item_type='" & itemType & "' and phase='" & strPhase & "' and is_important='" & isImportant & "' and check_person is null }"
                End If
            Else
                '已确认资料(,,0,,false)
                If Me.Name = "frmDevolveOnProject" Then
                    strSql = "{project_code='" & projectCode & "' and (( item_type='" & itemType & "'and not check_person is null) OR (item_type = '44') AND (item_code = '002') OR  (item_type = '45') AND (item_code = '001') ) }"
                Else
                    strSql = "{project_code='" & projectCode & "' and item_type='" & itemType & "' and phase='" & strPhase & "' and check_person is not null }"
                End If
            End If
        End If
        Try
            ds = gWs.GetProjectDocumentByCondition(strSql)
            ds.Tables("TProjectDocument").Columns.Add("is_check", GetType(Boolean))
            ds.Tables("TProjectDocument").Columns.Add("is_affirm", GetType(Boolean))
            ds.Tables("TProjectDocument").Columns.Add("is_file", GetType(Boolean))
            i = ds.Tables("TProjectDocument").Rows.Count
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Dim strRelationNum As String
        If i > 0 Then
            For i = 0 To i - 1
                dr = ds.Tables("TProjectDocument").Rows(i)
                If Not dr.Item("file_relation_num") Is System.DBNull.Value Then
                    strRelationNum = dr.Item("file_relation_num")
                    strSql = "select count(relation_num) as relation_count from project_files where project_code='" & projectCode & "' and relation_num='" & strRelationNum & "' "
                    dsFileRelationNum = gWs.GetCommonQueryInfo(strSql)
                    drFileRelationNum = dsFileRelationNum.Tables(0).Rows(0)
                End If
                With dr
                    If Not .Item("check_person") Is System.DBNull.Value Then
                        If .Item("check_person") = "" Then
                            .Item("is_check") = False
                        Else
                            .Item("is_check") = True
                        End If
                    Else
                        .Item("is_check") = False
                    End If
                    If Not .Item("affirm_person") Is System.DBNull.Value Then
                        If .Item("affirm_person") = "" Then
                            .Item("is_affirm") = False
                        Else
                            .Item("is_affirm") = True
                        End If
                    Else
                        .Item("is_affirm") = False
                    End If
                    If Not .Item("is_important") Is System.DBNull.Value Then
                        If isAcceptMaterial Then
                            If .Item("is_important") = "1" Then
                                .Item("is_important") = True
                            Else
                                .Item("is_important") = False
                            End If
                        Else
                            If .Item("is_important") = "2" Then
                                .Item("is_important") = True
                            Else
                                .Item("is_important") = False
                            End If
                        End If
                    Else
                        .Item("is_important") = False
                    End If
                    If Not drFileRelationNum Is Nothing Then
                        If Not drFileRelationNum.Item("relation_count") Is System.DBNull.Value Then
                            If Convert.ToString(drFileRelationNum.Item("relation_count")) = "0" Then
                                .Item("is_file") = False
                            Else
                                .Item("is_file") = True
                            End If
                        Else
                            .Item("is_file") = False
                        End If
                    Else
                        .Item("is_file") = False
                    End If
                End With
            Next
            Return ds
        Else
            'Return Nothing
            Return ds
        End If
    End Function
    '
    '设置DataGrid中的CheckBox为默认打勾
    '
    Protected Sub setCheckIsTrue(ByVal ds As DataSet, ByVal strCol As String)
        If Not ds Is Nothing Then
            Dim i As Integer
            Try
                i = ds.Tables("TProjectDocument").Rows.Count
                For i = 0 To i - 1
                    ds.Tables("TProjectDocument").Rows(i).Item(strCol) = True
                Next
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Sub
    '
    '如果确认人有一个不为空:True,就不设置默认值按确认人设置相应的值;否则,False设置默认值
    '
    Public Function setCheckByPerson(ByVal ds As DataSet, ByVal strCol As String)
        Dim dr As DataRow
        Dim bTemp As Boolean = False
        If Not ds Is Nothing Then
            Dim i As Integer
            Try
                i = ds.Tables("TProjectDocument").Rows.Count
                For i = 0 To i - 1
                    dr = ds.Tables("TProjectDocument").Rows(i)
                    With dr
                        If Not .Item("check_person") Is System.DBNull.Value Then
                            .Item(strCol) = True
                            If Not bTemp Then
                                bTemp = True
                            End If
                        End If
                    End With
                Next
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
        Return bTemp
    End Function
    '
    '根据type_name,获得item_type
    '
    Protected Function getItemType(ByVal typeName As String) As String
        Dim ds As DataSet
        Dim i As Integer
        Dim strSql As String
        strSql = "{type_name='" & typeName & "'}"
        Try
            ds = gWs.GetItemType(strSql)
            i = ds.Tables("TItemType").Rows.Count
        Catch ex As Exception
            'MsgBox("获取ItemType出错!" & ex.Message, MsgBoxStyle.Critical, "提示")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If i > 0 Then
            Return ds.Tables("TItemType").Rows(0).Item("item_type")
        Else
            Return typeName
        End If
    End Function
    '
    '根据不同的ItemType和显示内容,获取不同的资料信息
    'strProjectCode ;项目编码
    '    '
    Protected Function getDocumentInfoByContent(ByVal strProjectCode As String, ByVal isAcceptMaterial As Boolean) As DataSet
        Dim itemType As String
        Dim ds As DataSet
        itemType = getItemType(cmbType.Text)
        If cmbContent.Text = "全部资料" Then
            If isAcceptMaterial Then
                ds = getDocumentInfo(strProjectCode, itemType, 1, False, True, True)
            Else
                ds = getDocumentInfo(strProjectCode, itemType, 1, False, True, False)
            End If
        ElseIf cmbContent.Text = "关键资料" Then
            If isAcceptMaterial Then
                ds = getDocumentInfo(strProjectCode, itemType, 1, True, False, True)
            Else
                ds = getDocumentInfo(strProjectCode, itemType, 1, True, False, False)
            End If
        ElseIf cmbContent.Text = "已确认资料" Then
            If isAcceptMaterial Then
                ds = getDocumentInfo(strProjectCode, itemType, 0, True, False, True)
            Else
                ds = getDocumentInfo(strProjectCode, itemType, 0, True, False, False)
            End If
        ElseIf cmbContent.Text = "关键未确认资料" Then
            If isAcceptMaterial Then
                ds = getDocumentInfo(strProjectCode, itemType, 1, False, False, True)
            Else
                ds = getDocumentInfo(strProjectCode, itemType, 1, False, False, False)
            End If
        End If
        Return ds
    End Function
    '
    '添加(材料的)类型
    '
    Protected Sub addCmbType(ByVal flag As String)
        Dim ar As New ArrayList()
        Dim i As Integer
        ar = Me.getMaterialType()
        If Not ar Is Nothing Then
            i = ar.Count
            If i > 0 Then
                For i = 0 To i - 1
                    cmbType.Items.Add(ar(i))
                Next
                If flag = "41" Then
                    cmbType.SelectedIndex = 0
                ElseIf flag = "42" Then
                    cmbType.SelectedIndex = 1
                End If
            End If
        End If
    End Sub
    '
    '设置DataGrid的DataSource,并返回ds
    '
    Protected Function setDgDataSource(ByVal strProjectCode As String, ByVal isAcceptMaterial As Boolean) As DataSet

        If strProjectCode Is Nothing Then Return Nothing

        Dim ds As DataSet
        If isAcceptMaterial Then
            ds = getDocumentInfoByContent(strProjectCode, True)
        Else
            ds = getDocumentInfoByContent(strProjectCode, False)
        End If
        Try
            If Not ds Is Nothing Then
                Me.dgMaterial.DataSource = ds.Tables("TProjectDocument")
                Me.dgMaterial.Refresh()
                setDgAttribute(Me.dgMaterial, Me)
                Return ds
            Else
                Me.dgMaterial.DataSource = Nothing
                Return Nothing
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '
    '设置资料信息,直接从DataSet中获取数据
    '
    Protected Sub setMaterialInfo(ByVal ds As DataSet, ByVal index As Integer)
        Dim i As Integer
        Dim dr As DataRow
        i = ds.Tables("TProjectDocument").Rows.Count
        If i > 0 Then
            dr = ds.Tables("TProjectDocument").Rows(index)
            With dr
                If Not .Item("doc_name") Is System.DBNull.Value Then
                    Me.txtMaterial.Text = .Item("doc_name")
                Else
                    Me.txtMaterial.Text = ""
                End If
                If Not .Item("remark") Is System.DBNull.Value Then
                    Me.txtRemark.Text = .Item("remark")
                Else
                    Me.txtRemark.Text = ""
                End If
                If Not .Item("is_check") Is System.DBNull.Value Then
                    Me.chbCheck.Checked = .Item("is_check")
                Else
                    Me.chbCheck.Checked = False
                End If
                If Not .Item("check_person") Is System.DBNull.Value Then
                    Me.txtPerson.Text = .Item("check_person")
                Else
                    Me.txtPerson.Text = ""
                End If
                If Not .Item("check_date") Is System.DBNull.Value Then
                    Me.dateCheck.Value = .Item("check_date")
                Else
                    Try
                        Me.dateCheck.Value = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End If
                If Not .Item("is_important") Is System.DBNull.Value Then
                    Me.chbImportant.Checked = .Item("is_important")
                Else
                    Me.chbImportant.Checked = False
                End If
                If Not .Item("is_file") Is System.DBNull.Value Then
                    Me.chbFile.Checked = .Item("is_file")
                Else
                    Me.chbFile.Checked = False
                End If
            End With
        End If
    End Sub
    '
    '设置资料信息,从DataGrid的DataSource中获取数据
    '
    Protected Sub setMaterialInfo(ByVal dg As DataGrid, ByVal index As Integer)
        Dim i As Integer
        Dim ds As DataSet
        Dim dr As DataRow
        i = dg.CurrentCell.RowNumber
        If i >= 0 Then
            With dg
                If Not .Item(i, 0) Is System.DBNull.Value Then
                    Me.txtMaterial.Text = .Item(i, 0)
                Else
                    Me.txtMaterial.Text = ""
                End If
                If Not .Item(i, 4) Is System.DBNull.Value Then
                    Me.txtRemark.Text = .Item(i, 4)
                Else
                    Me.txtRemark.Text = ""
                End If
                If Not .Item(i, 1) Is System.DBNull.Value Then
                    Me.chbCheck.Checked = .Item(i, 1)
                Else
                    Me.chbCheck.Checked = False
                End If
                If Not .Item(i, 5) Is System.DBNull.Value Then
                    Me.txtPerson.Text = .Item(i, 5)
                Else
                    Me.txtPerson.Text = ""
                End If
                If Not .Item(i, 6) Is System.DBNull.Value Then
                    Me.dateCheck.Value = .Item(i, 6)
                Else
                    Try
                        Me.dateCheck.Value = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End If
                If Not .Item(i, 2) Is System.DBNull.Value Then
                    Me.chbImportant.Checked = .Item(i, 2)
                Else
                    Me.chbImportant.Checked = False
                End If
                If Not .Item(i, 3) Is System.DBNull.Value Then
                    Me.chbFile.Checked = .Item(i, 3)
                Else
                    Me.chbFile.Checked = False
                End If
            End With
        End If
    End Sub
    '
    '设置TextBox等的Enabled属性
    '
    Protected Sub setTextBox(ByVal isEnabled As Boolean)
        Me.txtMaterial.Enabled = isEnabled
        Me.txtPerson.Enabled = isEnabled
        Me.txtRemark.Enabled = isEnabled
        Me.dateCheck.Enabled = isEnabled
        Me.chbCheck.Enabled = isEnabled
        Me.chbFile.Enabled = isEnabled
        Me.chbImportant.Enabled = isEnabled
    End Sub
    '点击DataGrid中任意一行，则整行选中（高亮显示）
    Protected Overridable Sub dgMaterial_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgMaterial.CurrentCellChanged
        Static lastRow As Integer = -1
        If Me.dgMaterial.CurrentRowIndex <> lastRow Then
            Me.dgMaterial.Select(Me.dgMaterial.CurrentCell.RowNumber)
        End If
        lastRow = Me.dgMaterial.CurrentRowIndex
    End Sub


End Class
