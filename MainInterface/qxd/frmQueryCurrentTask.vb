

Public Class frmQueryCurrentTask
    Inherits MainInterface.frmBasic

    Private strRoleID As String = ""
    Private AttendPerson As String = ""
    Private TaskName As String = ""

    Private count As Integer = 0
    Private nCurrentCount As Integer = 0
    Private isLoad As Boolean = False
    Private strProjectCode As String
    Private strTaskID As String

    Public Property ProjectCode() As String
        Get
            Return strProjectCode
        End Get
        Set(ByVal Value As String)
            strProjectCode = Value
        End Set
    End Property

    Public Property TaskID() As String
        Get
            Return strTaskID
        End Get
        Set(ByVal Value As String)
            strTaskID = Value
        End Set
    End Property

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub
    Public Sub New(ByVal role_id As String)
        Me.New()
        Me.strRoleID = role_id
    End Sub
    Public Sub New(ByVal role_id As String, ByVal attend_person As String, ByVal task_name As String)
        Me.New()
        Me.strRoleID = role_id
        Me.AttendPerson = attend_person
        Me.TaskName = task_name
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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgTask As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents cmbRole As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbName As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTask As System.Windows.Forms.TextBox
    Friend WithEvents btnCodeQuery As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTaskName As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmQueryCurrentTask))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTaskName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCodeQuery = New System.Windows.Forms.Button()
        Me.txtTask = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbName = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbRole = New System.Windows.Forms.ComboBox()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgTask = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgTask, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnExit.Location = New System.Drawing.Point(297, 408)
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtTaskName, Me.Label5, Me.btnCodeQuery, Me.txtTask, Me.Label4, Me.cmbName, Me.Label2, Me.Label3, Me.cmbRole, Me.btnQuery, Me.txtCode, Me.Label1})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询条件"
        '
        'txtTaskName
        '
        Me.txtTaskName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtTaskName.Location = New System.Drawing.Point(272, 48)
        Me.txtTaskName.Name = "txtTaskName"
        Me.txtTaskName.Size = New System.Drawing.Size(272, 21)
        Me.txtTaskName.TabIndex = 11
        Me.txtTaskName.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(208, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "任务名称"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCodeQuery
        '
        Me.btnCodeQuery.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCodeQuery.Location = New System.Drawing.Point(560, 16)
        Me.btnCodeQuery.Name = "btnCodeQuery"
        Me.btnCodeQuery.Size = New System.Drawing.Size(80, 24)
        Me.btnCodeQuery.TabIndex = 3
        Me.btnCodeQuery.Text = "按编码查询"
        Me.btnCodeQuery.Visible = False
        '
        'txtTask
        '
        Me.txtTask.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtTask.Location = New System.Drawing.Point(448, 17)
        Me.txtTask.Name = "txtTask"
        Me.txtTask.ReadOnly = True
        Me.txtTask.Size = New System.Drawing.Size(96, 21)
        Me.txtTask.TabIndex = 3
        Me.txtTask.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "任务总数"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbName
        '
        Me.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbName.Location = New System.Drawing.Point(64, 48)
        Me.cmbName.Name = "cmbName"
        Me.cmbName.Size = New System.Drawing.Size(136, 20)
        Me.cmbName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "角色人员"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "项目角色"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbRole
        '
        Me.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbRole.Location = New System.Drawing.Point(64, 18)
        Me.cmbRole.Name = "cmbRole"
        Me.cmbRole.Size = New System.Drawing.Size(136, 20)
        Me.cmbRole.TabIndex = 0
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuery.ImageIndex = 3
        Me.btnQuery.ImageList = Me.ImageListBasic
        Me.btnQuery.Location = New System.Drawing.Point(560, 48)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(77, 24)
        Me.btnQuery.TabIndex = 4
        Me.btnQuery.Text = "查 询(&Q)"
        Me.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(272, 17)
        Me.txtCode.MaxLength = 9
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(104, 21)
        Me.txtCode.TabIndex = 1
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(208, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgTask})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 304)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "任务列表"
        '
        'dgTask
        '
        Me.dgTask.CaptionVisible = False
        Me.dgTask.DataMember = ""
        Me.dgTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTask.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgTask.Location = New System.Drawing.Point(3, 17)
        Me.dgTask.Name = "dgTask"
        Me.dgTask.ReadOnly = True
        Me.dgTask.RowHeaderWidth = 0
        Me.dgTask.Size = New System.Drawing.Size(650, 284)
        Me.dgTask.TabIndex = 0
        Me.dgTask.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgTask
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
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
        Me.DataGridTextBoxColumn2.HeaderText = "任务名称"
        Me.DataGridTextBoxColumn2.MappingName = "task_name"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 180
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "参与人"
        Me.DataGridTextBoxColumn4.MappingName = "attend_person"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "开始时间"
        Me.DataGridTextBoxColumn3.MappingName = "start_time"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 200
        '
        'frmQueryCurrentTask
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(674, 439)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.GroupBox2, Me.GroupBox1})
        Me.Name = "frmQueryCurrentTask"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "当前工作任务"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgTask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmQueryCurrentTask_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isLoad = True
        If Not TaskName = "" Then
            Me.txtTaskName.Text = TaskName
            Me.txtTaskName.Enabled = False
        End If
        setRoles()
        setName()
        btnQuery_Click(sender, e)
    End Sub
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    '查询，组合条件；若为空，则不作为查询条件
    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Me.Cursor = Cursors.WaitCursor
        Dim dt As DataTable
        Dim strCode, strRoleID, strAttenPerson, strTaskName, strSql As String
        If Me.txtCode.Text = "" Then
            strCode = "%"
        Else
            strCode = Me.txtCode.Text
        End If
        If Me.cmbRole.Text = "" Then
            strRoleID = "%"
        Else
            strRoleID = Me.cmbRole.SelectedValue
        End If
        If Me.cmbName.Text = "" Then
            strAttenPerson = "%"
        Else
            strAttenPerson = Me.cmbName.Text
        End If
        If Me.txtTaskName.Text = "" Then
            strTaskName = "%"
        Else
            strTaskName = Me.txtTaskName.Text.Trim
        End If
        'qxd add 2003-6-9
        'If Me.cmbRole.Text.Trim = "" Then
        '    btnCodeQuery_Click(sender, e)
        '    Exit Sub
        'End If

        'strSql = "{role_id like '" & strRoleID & "' and project_code like '" & strCode & "' and attend_person like '" & strAttenPerson & "' and task_status='P'}"
        'dt = gWs.LookUpWorkingEx(strSql).Tables("project_task")

        If strRoleID = "33" Then
            strSql = "select b.task_name,* from project_task_attendee a left join " & _
                    "project_task b on a.task_id=b.task_id and a.workflow_id=b.workflow_id and a.project_code =b.project_code " & _
                    "where a.task_status='P' and a.role_id like '" & strRoleID & _
                    "' and a.attend_person like '" & strAttenPerson & "' and a.project_code like '" & strCode & _
                    "' and b.task_name like '%" & strTaskName & "%' and b.task_id='DraftOutContract'"
        Else
            strSql = "select b.task_name,* from project_task_attendee a left join " & _
                    "project_task b on a.task_id=b.task_id and a.workflow_id=b.workflow_id and a.project_code =b.project_code " & _
                    "where a.task_status='P' and a.role_id like '" & strRoleID & _
                    "' and a.attend_person like '" & strAttenPerson & "' and a.project_code like '" & strCode & _
                    "' and b.task_name like '%" & strTaskName & "%'"

        End If

        dt = gWs.GetCommonQueryInfo(strSql).Tables(0)
        Me.dgTask.DataSource = dt
        Me.txtTask.Text = dt.Rows.Count & "   (个)"
        Me.Cursor = Cursors.Default
    End Sub
    '获得工作任务dataset
    Private Function getQueryDataSet(ByVal projectCode As String, ByVal roleID As String, ByVal attendPerson As String) As DataSet
        Dim strSql As String
        Dim ds As DataSet
        Me.Cursor = Cursors.WaitCursor
        Try
            strSql = "{role_id ='" & roleID & "' and project_code like '" & projectCode & "' and attend_person = '" & attendPerson & "' and task_status='P'}"
            ds = gWs.LookUpWorkingEx(strSql)
        Catch ex As Exception
        Finally
            Me.Cursor = Cursors.Default
        End Try
        Return ds
    End Function
    '设置项目角色，Role
    Private Sub setRoles()
        If Not gWs Is Nothing Then
            Dim dt As DataTable
            Dim dr As DataRow
            Dim strSql As String
            '除了"项目组"外,其他都显示
            strSql = "{not role_id='22'}"
            dt = gWs.GetRole(strSql).Tables(0)
            'qxd add start 2003-6-9
            '添加一空白行,若选择,则说明此条件不作为查询条件.
            Try
                dr = dt.NewRow
                With dr
                    .Item("role_id") = "**"
                    .Item("role_name") = ""
                    .Item("isConsign") = True
                End With
                dt.Rows.InsertAt(dr, 0)
            Catch ex As Exception
            End Try
            ' qxd add end 2003-6-9
            Me.cmbRole.DataSource = dt
            Me.cmbRole.ValueMember = "role_id"
            Me.cmbRole.DisplayMember = "role_name"
            If Not strRoleID = "" Then
                Me.cmbRole.SelectedValue = strRoleID
            End If
        End If
    End Sub
    '设置角色人员的名字
    Private Sub setName()
        If Not gWs Is Nothing Then
            Me.cmbName.DataSource = Nothing
            Me.cmbName.Items.Clear()
            'Dim dt As DataTable
            'Dim strSql As String
            Dim i As Integer = 0
            Dim arylist As ArrayList = New ArrayList()
            If Me.cmbRole.Text = "" Then
                'strSql = "%"
                Exit Sub
            Else
                arylist = MdlGlobal.GetPersnList(MdlGlobal.GetConsigner(strProjectCode, strTaskID), Me.cmbRole.SelectedValue)
                'strSql = "SELECT DISTINCT attend_person FROM project_task_attendee  WHERE (NOT (attend_person = '')) and role_id='" & Me.cmbRole.SelectedValue & "'"
            End If
            'dt = gWs.GetCommonQueryInfo(strSql).Tables(0)
            '添加一空白行,若选择,则说明此条件不作为查询条件.
            'Dim dr As DataRow
            'Try
            '    dr = dt.NewRow
            '    With dr
            '        .Item("attend_person") = ""
            '    End With
            '    dt.Rows.InsertAt(dr, 0)
            'Catch ex As Exception
            'End Try
            'i = dt.Rows.Count
            'If i > 0 Then
            '    For i = 0 To i - 1
            '        Me.cmbName.Items.Add(dt.Rows(i).Item("attend_person"))
            '        If AttendPerson = "" Then
            '            Me.cmbName.SelectedIndex = 0
            '        Else
            '            Me.cmbName.Text = AttendPerson
            '        End If
            '        'Me.cmbName.SelectedIndex = 0
            '    Next
            'Else
            '    Me.cmbName.Text = ""
            'End If
            If arylist.Count > 0 Then
                Me.cmbName.Items.Add("")
                For i = 0 To arylist.Count - 1
                    Me.cmbName.Items.Add(arylist.Item(i).ToString())
                Next
            End If
        End If
    End Sub
    '选择项目角色下拉框触发的事件
    Private Sub cmbRole_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRole.SelectedValueChanged
        If isLoad Then
            count = count + 1
        End If
        If nCurrentCount < count Then
        Else
            setName()
            btnQuery_Click(sender, e)
        End If
        nCurrentCount = nCurrentCount + 1
    End Sub
    '下拉事件
    Private Sub cmbRole_DropDown(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRole.DropDown
        isLoad = False
    End Sub
    '获得焦点事件
    Private Sub cmbRole_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbRole.Enter
        isLoad = False
    End Sub
    '选择角色人员下拉框触发的事件
    Private Sub cmbName_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbName.SelectedValueChanged
        btnQuery_Click(sender, e)
    End Sub
    '列表中鼠标点击的事件，点中cell（0，0）
    Private Sub dgTask_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgTask.MouseUp
        If Me.dgTask.DataSource Is Nothing Then
            Exit Sub
        End If
        If CType(Me.dgTask.DataSource, DataTable).Rows.Count > 0 Then
            Me.dgTask.Select(Me.dgTask.CurrentCell.RowNumber)
        End If
    End Sub
    '按编码查询
    Private Sub btnCodeQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCodeQuery.Click
        Dim strSql As String
        Dim ds As DataSet
        Dim projectCode As String
        Me.Cursor = Cursors.WaitCursor
        If Me.txtCode.Text = "" Then
            projectCode = "%"
        Else
            projectCode = Me.txtCode.Text
        End If
        Try
            strSql = "{project_code like '" & projectCode & "' and task_status='P'}"
            ds = gWs.LookUpWorkingEx(strSql)
        Catch ex As Exception
        Finally
            Me.dgTask.DataSource = ds.Tables("project_task")
            Me.txtTask.Text = ds.Tables("project_task").Rows.Count & "   (个)"
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class
