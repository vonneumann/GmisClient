'手动任务窗体，将完成的任务手动置起
'继承工作流窗体
Public Class frmManualTask
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
    Friend WithEvents combo_task As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmManualTask))
        Me.combo_task = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupQuery.SuspendLayout()
        Me.project_group.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(345, 440)
        Me.btnExit.Visible = True
        '
        'btnQuery
        '
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.Location = New System.Drawing.Point(169, 440)
        Me.btnQuery.Visible = True
        '
        'GroupQuery
        '
        Me.GroupQuery.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupQuery.Size = New System.Drawing.Size(579, 45)
        Me.GroupQuery.Visible = True
        '
        'btnEntery
        '
        Me.btnEntery.Image = CType(resources.GetObject("btnEntery.Image"), System.Drawing.Bitmap)
        Me.btnEntery.Location = New System.Drawing.Point(257, 440)
        Me.btnEntery.Text = "启 动(&S)"
        Me.btnEntery.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'project_group
        '
        Me.project_group.Location = New System.Drawing.Point(8, 47)
        Me.project_group.Size = New System.Drawing.Size(579, 353)
        Me.project_group.Visible = True
        '
        'dgQueryResult
        '
        Me.dgQueryResult.AccessibleName = "DataGrid"
        Me.dgQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgQueryResult.Size = New System.Drawing.Size(576, 344)
        Me.dgQueryResult.Visible = True
        '
        'combo_task
        '
        Me.combo_task.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.combo_task.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_task.Location = New System.Drawing.Point(40, 408)
        Me.combo_task.Name = "combo_task"
        Me.combo_task.Size = New System.Drawing.Size(264, 20)
        Me.combo_task.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label1.Location = New System.Drawing.Point(8, 412)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "任务"
        '
        'frmManualTask
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 469)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.combo_task, Me.Label1, Me.GroupQuery, Me.btnQuery, Me.btnEntery, Me.project_group, Me.btnExit})
        Me.Name = "frmManualTask"
        Me.Text = "手动启动任务"
        Me.GroupQuery.ResumeLayout(False)
        Me.project_group.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsTempProject, dsTempTask, dsTempAttend As DataSet
    Private tmpProjectID, tmpTaskID, tmpTaskStatus As String
    Private iIndex As Integer
    Public Event refreshTaskCommit()

    '窗体的load事件
    Private Sub frmManualTask_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
            MsgBox("无项目列表!", MsgBoxStyle.Information, "手动任务")
            btnEntery.Enabled = False
            Exit Sub
        End If

        iIndex = dgQueryResult.CurrentRowIndex
        '获取项目ID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)

        '获取任务列表(只能为完成的任务)
        'strSql = " SELECT dbo.project_task_attendee.task_id, dbo.project_task.task_name" & _
        '         " FROM dbo.project_task_attendee INNER JOIN" & _
        '         " dbo.project_task ON " & _
        '         " dbo.project_task_attendee.project_code = dbo.project_task.project_code AND" & _
        '         " dbo.project_task_attendee.workflow_id = dbo.project_task.workflow_id AND" & _
        '         " dbo.project_task_attendee.task_id = dbo.project_task.task_id" & _
        '         " WHERE dbo.project_task_attendee.task_status = 'F' AND" & _
        '         " ISNULL(dbo.project_task.task_type, '') <> 'AUTO' AND" & _
        '         " dbo.project_task_attendee.task_id NOT IN ('Application') AND" & _
        '         " dbo.project_task_attendee.project_code =" & "'" & tmpProjectID & "'"

        refreshTaskList()
       
    End Sub

    '任务选择下拉列表改变事件
    Private Sub combo_task_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combo_task.SelectedValueChanged
        If combo_task.SelectedIndex <> 0 Then

            Dim i As Integer
            Dim strSql As String

            '获取任务名
            Dim tmpTaskName As String = Trim(combo_task.Text)
            strSql = "task_name=" & "'" & tmpTaskName & "'"

            '通过任务名获取任务ID
            Dim dr() As DataRow = dsTempTask.Tables(0).Select(strSql)
            tmpTaskID = dr(0).Item("task_id")

            '获取该任务的参与人数据集
            strSql = "{project_code=" & "'" & tmpProjectID & "'" & " and task_id=" & "'" & tmpTaskID & "'" & "}"
            dsTempAttend = gWs.GetWfProjectTaskAttendeeInfo(strSql)


        End If
    End Sub

    '处理按钮事件
    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        If combo_task.SelectedIndex = 0 Then
            MsgBox("请选择一个任务!", MsgBoxStyle.Information, "手动任务")
            Exit Sub
        End If

        Dim response As MsgBoxResult
        Dim strErr As String

        iIndex = dgQueryResult.CurrentRowIndex

        '获取项目ID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)

        response = MsgBox("是否确定要手动启动任务?", MsgBoxStyle.YesNo, "手动任务")

        '调用StartTaskByManual方法将该项目所选任务手动置起
        If response = MsgBoxResult.Yes Then
            strErr = gWs.StartTaskByManual("01", tmpProjectID, tmpTaskID)
            If strErr = "1" Then
                MsgBox("任务已被手工启动!", MsgBoxStyle.Information, "手动任务")
                RaiseEvent refreshTaskCommit()
            Else
                MsgBox("手动启动任务失败:" & strErr, MsgBoxStyle.Critical, "手动任务")
            End If
        End If

    End Sub


    Private Sub dgQueryResult_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgQueryResult.CurrentCellChanged
        Static lastRow As Integer = -1
        If dgQueryResult.CurrentRowIndex <> lastRow Then
            combo_task.SelectedIndex = 0

            iIndex = dgQueryResult.CurrentRowIndex
            '获取项目ID
            tmpProjectID = dgQueryResult.Item(iIndex, 0)

        End If
        lastRow = dgQueryResult.CurrentRowIndex

        refreshTaskList()

    End Sub

    '刷新任务列表
    Private Sub refreshTaskList()
        Dim strSql As String
        Dim i As Integer
        combo_task.Items.Clear()

        iIndex = dgQueryResult.CurrentRowIndex
        '获取项目ID
        If iIndex >= 0 Then
            tmpProjectID = dgQueryResult.Item(iIndex, 0)
        Else
            tmpProjectID = Me.txtProjectCode.Text
        End If


        '在参与人表中获取已完成的任务,排除记录评审会评审结论（RecordReviewConclusion）、
        '申请担保意向书(ApplyLetterIntent)
        'strSql = " select distinct p.task_id,t.task_name from project_task_attendee p,task_template t " & _
        '        " where p.task_id=t.task_id and p.workflow_id=t.workflow_id" & _
        '        " and p.task_id <> 'Application' and p.task_status='F'" & _
        '        " and p.project_code=" & "'" & tmpProjectID & "'" & _
        '        " and p.attend_person='" & UserName & "' and isnull(t.task_type,'')<>'AUTO' " & _
        '        " order by t.task_name"

        strSql = " select distinct p.task_id,t.task_name from project_task_attendee p,task_template t " & _
                " where p.task_id=t.task_id and p.workflow_id=t.workflow_id" & _
                " and not p.task_id in ('Application','RecordReviewConclusion','ApplyLetterIntent') and p.task_status='F'" & _
                " and p.project_code=" & "'" & tmpProjectID & "'" & _
                " and p.attend_person='" & UserName & "' and isnull(t.task_type,'')<>'AUTO' " & _
                " order by t.task_name"
        dsTempTask = gWs.GetCommonQueryInfo(strSql)
        combo_task.Items.Insert(0, "--请选择一个任务--")

        '填充任务选择下拉列表
        For i = 0 To dsTempTask.Tables(0).Rows.Count - 1
            combo_task.Items.Add(dsTempTask.Tables(0).Rows(i).Item("task_name"))
        Next

        combo_task.SelectedIndex = 0
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

        refreshTaskList()
    End Sub

End Class
