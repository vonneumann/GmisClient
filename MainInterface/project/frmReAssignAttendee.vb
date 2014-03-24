'更换项目角色窗体
'继承工作流窗体
Public Class frmReAssignAttendee
    Inherits MainInterface.frmBaseWorkflow

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents combo_staff As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents combo_role As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chbResponsible As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReAssignAttendee))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chbResponsible = New System.Windows.Forms.CheckBox()
        Me.combo_staff = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combo_role = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupQuery.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.project_group.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuery
        '
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.ImageIndex = -1
        Me.btnQuery.ImageList = Nothing
        Me.btnQuery.Location = New System.Drawing.Point(169, 456)
        Me.btnQuery.Visible = True
        '
        'btnEntery
        '
        Me.btnEntery.Image = CType(resources.GetObject("btnEntery.Image"), System.Drawing.Bitmap)
        Me.btnEntery.ImageIndex = -1
        Me.btnEntery.ImageList = Nothing
        Me.btnEntery.Location = New System.Drawing.Point(257, 456)
        Me.btnEntery.Text = "确 定(&O)"
        Me.btnEntery.Visible = True
        '
        'GroupQuery
        '
        Me.GroupQuery.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupQuery.Size = New System.Drawing.Size(579, 45)
        Me.GroupQuery.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(345, 456)
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'dgQueryResult
        '
        Me.dgQueryResult.AccessibleName = "DataGrid"
        Me.dgQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgQueryResult.Size = New System.Drawing.Size(576, 339)
        Me.dgQueryResult.Visible = True
        '
        'project_group
        '
        Me.project_group.Size = New System.Drawing.Size(579, 349)
        Me.project_group.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.chbResponsible, Me.combo_staff, Me.Label2, Me.combo_role, Me.Label1})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 398)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(578, 49)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'chbResponsible
        '
        Me.chbResponsible.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.chbResponsible.Location = New System.Drawing.Point(448, 19)
        Me.chbResponsible.Name = "chbResponsible"
        Me.chbResponsible.TabIndex = 4
        Me.chbResponsible.Text = "项目责任人"
        Me.chbResponsible.Visible = False
        '
        'combo_staff
        '
        Me.combo_staff.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.combo_staff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_staff.Location = New System.Drawing.Point(288, 21)
        Me.combo_staff.Name = "combo_staff"
        Me.combo_staff.Size = New System.Drawing.Size(112, 20)
        Me.combo_staff.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(240, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 14)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "员工"
        '
        'combo_role
        '
        Me.combo_role.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_role.Location = New System.Drawing.Point(64, 21)
        Me.combo_role.Name = "combo_role"
        Me.combo_role.Size = New System.Drawing.Size(112, 20)
        Me.combo_role.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "项目角色"
        '
        'frmReAssignAttendee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 485)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupQuery, Me.btnQuery, Me.btnEntery, Me.project_group, Me.btnExit, Me.GroupBox2})
        Me.Name = "frmReAssignAttendee"
        Me.Text = "更换项目角色"
        Me.GroupQuery.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.project_group.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsTempProject As DataSet
    Private dsTempRole As DataSet
    Private dsTempStaff As DataSet
    Private tmpProjectID, tmpRoleName, tmpRoleID, tmpStaff, tmpAnotherRoleID, tmpAnotherStaff As String
    Private iIndex As Integer

    '窗体的load事件
    Private Sub frmReAssignAttendee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '获取项目列表
        Dim i As Integer
        Dim strSql As String

        'strSql = " SELECT ProjectCode, EnterpriseName, phase, Status" & _
        '         " FROM dbo.ViewProjectInfo" & _
        '         " WHERE (isliving = 1)"
        strSql = " SELECT ProjectCode, EnterpriseName, phase, Status" & _
                " FROM dbo.queryProjectInfo" & _
                " WHERE (isliving = 1)"
        dsTempProject = gWs.GetCommonQueryInfo(strSql)
        dgQueryResult.DataSource = dsTempProject.Tables(0).DefaultView

        If dsTempProject.Tables(0).Rows.Count = 0 Then
            MsgBox("无项目列表!", MsgBoxStyle.Information, "更换项目角色")
            btnEntery.Enabled = False
            Exit Sub
        End If

        '获取角色列表
        strSql = "%"
        dsTempRole = gWs.GetRole(strSql)
        strSql = "role_id in ('24','25','13','33','51')"
        Dim drRole() As DataRow = dsTempRole.Tables(0).Select(strSql)
        combo_role.Items.Insert(0, "--请选择一个角色--")

        If UserName = "张顺" Then
            strSql = "role_id in ('33')"
            drRole = dsTempRole.Tables(0).Select(strSql)
            For i = 0 To drRole.Length - 1
                combo_role.Items.Add(drRole(i).Item("role_name"))
            Next
        Else
            For i = 0 To drRole.Length - 1
                combo_role.Items.Add(drRole(i).Item("role_name"))
            Next
        End If

        combo_role.SelectedIndex = 0

        '获取员工记录集
        strSql = "%"
        dsTempStaff = gWs.GetStaff(strSql)

        'combo_role.DisplayMember = "role_name"
        'combo_role.ValueMember = "role_id"

        iIndex = dgQueryResult.CurrentRowIndex
        '获取项目ID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)


    End Sub

    '角色选择下拉列表改变事件
    Private Sub combo_role_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles combo_role.SelectedValueChanged

        combo_staff.Items.Clear()

        '判断是否为第一个选项
        If combo_role.SelectedIndex <> 0 Then
            Dim i As Integer
            Dim strSql As String

            '获取角色名
            tmpRoleName = Trim(combo_role.Text)

            '通过角色名获取角色ID
            strSql = "role_name=" & "'" & tmpRoleName & "'"
            Dim drRoleID() As DataRow = dsTempRole.Tables(0).Select(strSql)

            '获取该项目参与人
            tmpRoleID = drRoleID(0).Item("role_id")
            strSql = "{project_code=" & "'" & tmpProjectID & "'" & " and role_id='" & tmpRoleID & "'}"
            Dim dsTemp As DataSet = gWs.GetWfProjectTaskAttendeeInfo(strSql)
            Dim tmpRoleStaff As String = ""
            If dsTemp.Tables(0).Rows.Count <> 0 Then
                tmpRoleStaff = dsTemp.Tables(0).Rows(0).Item("attend_person")
            End If

            '填充员工列表
            If tmpRoleName.StartsWith("评审会记录员") Or tmpRoleName.StartsWith("法务经理") Then
                strSql = "select staff_name from staff_role where role_id='" & tmpRoleID & "'"
                Dim dsTempStaffRole As DataSet = gWs.GetCommonQueryInfo(strSql)
                For i = 0 To dsTempStaffRole.Tables(0).Rows.Count - 1
                    combo_staff.Items.Add(dsTempStaffRole.Tables(0).Rows(i).Item("staff_name"))
                Next
            Else
                For i = 0 To dsTempStaff.Tables(0).Rows.Count - 1
                    combo_staff.Items.Add(dsTempStaff.Tables(0).Rows(i).Item("staff_name"))
                Next
            End If


            If Trim(tmpRoleStaff) = "" Then
                'combo_staff.Items.Clear()
                combo_staff.SelectedIndex = -1
            Else
                combo_staff.Text = tmpRoleStaff
            End If

            'qxd add 2004-6-10 添加项目责任人
            If tmpRoleName.StartsWith("项目经理") Then
                Me.chbResponsible.Visible = True
            Else
                Me.chbResponsible.Visible = False
            End If
        End If
    End Sub

    '处理按钮事件
    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        
        iIndex = dgQueryResult.CurrentRowIndex
        '获取项目ID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)

        '项目角色分配后，业务方法更新工作流的任务角色参与人。
        ChangeAttendee(tmpProjectID, tmpRoleID, Trim(combo_staff.Text))

        'qxd add 2004-6-10
        saveProjectResponsible(tmpProjectID)

    End Sub

    Private Sub dgQueryResult_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgQueryResult.DoubleClick
        combo_role.SelectedIndex = 0
        combo_staff.Text = ""
        combo_staff.Items.Clear()

    End Sub

    '设置项目参与人ChangeAttendee（ProjectID、RoleID、Employee）
    Public Function ChangeAttendee(ByVal projectID As String, ByVal roleID As String, ByVal staff As String)
        Dim strSql As String
        Dim i As Integer
        Dim response As MsgBoxResult
        response = MsgBox("是否确认要更改角色参与人!", MsgBoxStyle.YesNo, "更换项目角色")

        If response = MsgBoxResult.Yes Then
            '    '项目经理A,B角不能相同
            '    '    获取另一个项目经理角色
            '    If tmpRoleID = "24" Then
            '        tmpAnotherRoleID = "25"
            '    Else
            '        tmpAnotherRoleID = "24"
            '    End If

            '    '   获取另一个项目经理角色的参与人
            '    strSql = "{ProjectCode=" & "'" & tmpProjectID & "'" & "}"
            '    tmpAnotherStaff = gWs.GetProjectInfoEx(strSql).Tables(0).Rows(0).Item(tmpAnotherRoleID)

            '    If staff <> tmpAnotherStaff Then

            '项目角色分配后，业务方法更新工作流的任务角色参与人。
            '①	在项目参与人表将项目编码为ProjectID、角色为RoleID、任务状态不为“F”的任务员工改为Employee；

            Dim strErr As String = Workflow.AssignTaskAttendee(projectID, roleID, staff)

            If strErr <> 1 Then
                MsgBox("更改失败:" & strErr, MsgBoxStyle.Critical, "更换项目角色")
            Else
                MsgBox("更改成功", MsgBoxStyle.Information, "更换项目角色")
            End If
            'Else
            '    MsgBox("项目经理A,B角不能相同", MsgBoxStyle.Critical, "更换项目角色")
            '    combo_staff.Text = tmpStaff
            '    Exit Function
            'End If
        End If

    End Function

    Private Sub dgQueryResult_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgQueryResult.CurrentCellChanged

        'qxd add 20034-7-23
        iIndex = dgQueryResult.CurrentRowIndex
        '获取项目ID
        If iIndex > -1 Then
            tmpProjectID = dgQueryResult.Item(iIndex, 0)
        End If

        Static lastRow As Integer = -1
        If dgQueryResult.CurrentRowIndex <> lastRow Then
            combo_role.SelectedIndex = 0
            combo_staff.Text = ""
            combo_staff.Items.Clear()

            iIndex = dgQueryResult.CurrentRowIndex
            '获取项目ID
            tmpProjectID = dgQueryResult.Item(iIndex, 0)

            'qxd add 2004-6-10 添加项目责任人
            If Me.combo_role.Text.StartsWith("项目经理") Then
                Me.chbResponsible.Visible = True
            Else
                Me.chbResponsible.Visible = False
            End If
        End If
        lastRow = dgQueryResult.CurrentRowIndex
    End Sub

    Private Sub btnQueryProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQueryProject.Click
        Dim strSql As String
        Dim tmpProjectCode, tmpCorporation As String
        tmpProjectCode = Trim(txtProjectCode.Text)
        tmpCorporation = Trim(txtCorporation.Text)
        If tmpProjectCode = "" Then
            If tmpCorporation = "" Then
                strSql = ""
            End If
            strSql = "EnterpriseName like '%" & tmpCorporation & "%'"
        Else
            strSql = "ProjectCode like '%" & tmpProjectCode & "%'"
        End If
        dsTempProject.Tables(0).DefaultView.RowFilter = strSql

        Dim index As Integer
        index = Me.dgQueryResult.CurrentRowIndex()

        If index < 0 Then
            Me.btnEntery.Enabled = False
            Me.btnQuery.Enabled = False
            Exit Sub
        Else
            Me.btnEntery.Enabled = True
            Me.btnQuery.Enabled = True
        End If

        '重新获取当前项目编码及其任务列表
        dgQueryResult_CurrentCellChanged(sender, e)
    End Sub

    Private Sub saveProjectResponsible(ByVal ProjectCode As String)
        Try
            If Me.chbResponsible.Checked Then
                Dim ds As DataSet
                Dim dr As DataRow
                Dim count As Integer

                ds = gWs.GetProjectResponsibleInfo(ProjectCode)
                If Not ds Is Nothing Then
                    If ds.Tables("project_responsible").Rows.Count > 0 Then
                        dr = ds.Tables("project_responsible").Rows(0)
                        With dr
                            If Me.combo_role.Text.Trim = "项目经理A角" Then
                                .Item("manager_A") = Me.combo_staff.Text
                            ElseIf Me.combo_role.Text.Trim = "项目经理B角" Then
                                .Item("manager_B") = Me.combo_staff.Text
                            End If
                        End With
                    Else
                        dr = ds.Tables("project_responsible").NewRow
                        With dr
                            .Item("project_code") = ProjectCode
                            If Me.combo_role.Text.Trim = "项目经理A角" Then
                                .Item("manager_A") = Me.combo_staff.Text
                            ElseIf Me.combo_role.Text.Trim = "项目经理B角" Then
                                .Item("manager_B") = Me.combo_staff.Text
                            End If
                            .Item("create_person") = UserName
                            .Item("create_date") = gWs.GetSysTime()
                        End With
                        ds.Tables("project_responsible").Rows.Add(dr)
                    End If
                    gWs.UpdateProjectResponsible(ds)
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
End Class
