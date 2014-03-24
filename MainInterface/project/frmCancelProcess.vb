'项目暂缓窗体
'继承工作流窗体
Public Class frmCancelProcess
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmCancelProcess))
        Me.GroupQuery.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.project_group.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuery
        '
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Image)
        Me.btnQuery.ImageIndex = -1
        Me.btnQuery.ImageList = Nothing
        Me.btnQuery.Name = "btnQuery"
        '
        'GroupQuery
        '
        Me.GroupQuery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupQuery.Name = "GroupQuery"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Name = "btnExit"
        '
        'dgQueryResult
        '
        Me.dgQueryResult.AccessibleName = "DataGrid"
        Me.dgQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgQueryResult.Location = New System.Drawing.Point(0, 8)
        Me.dgQueryResult.Name = "dgQueryResult"
        Me.dgQueryResult.Size = New System.Drawing.Size(565, 342)
        '
        'project_group
        '
        Me.project_group.Name = "project_group"
        Me.project_group.Size = New System.Drawing.Size(567, 352)
        '
        'btnEntery
        '
        Me.btnEntery.Image = CType(resources.GetObject("btnEntery.Image"), System.Drawing.Image)
        Me.btnEntery.ImageIndex = -1
        Me.btnEntery.ImageList = Nothing
        Me.btnEntery.Name = "btnEntery"
        Me.btnEntery.Text = "暂 缓(&C)"
        '
        'btnQueryProject
        '
        Me.btnQueryProject.Name = "btnQueryProject"
        '
        'txtCorporation
        '
        Me.txtCorporation.Name = "txtCorporation"
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'frmCancelProcess
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(584, 437)
        Me.Name = "frmCancelProcess"
        Me.Text = "项目暂缓"
        Me.GroupQuery.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.project_group.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsTempProject As DataSet
    Private tmpProjectID, serviceType As String
    Private iIndex As Integer
    Public Event refreshTaskCommit()

    Private Sub frmCancelProcess_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '获取项目列表
        'Dim i As Integer
        Dim strSql As String

        '获取项目列表
        'strSql = " SELECT ProjectCode, EnterpriseName, phase, Status" & _
        '         " FROM dbo.ViewProjectInfo" & _
        '         " WHERE (isliving = 1) and manager_A='" & UserName & "'"
        'add by wwd 2006-09-05
        strSql = " SELECT ProjectCode, EnterpriseName, phase, Status " & _
                 " FROM dbo.queryProjectInfo LEFT OUTER JOIN loan_notice ON queryProjectInfo.ProjectCode = loan_notice.project_code " & _
                 "  WHERE StartTime is null and (queryProjectInfo.isliving = 1) and (queryProjectInfo.manager_A='" & UserName & "'" & _
                 " or (select top 1 attend_person from project_task_attendee where project_task_attendee.project_code=queryProjectInfo.ProjectCode and role_id='24')='" & UserName & "') "


        'strSql = " SELECT ProjectCode, EnterpriseName, phase, Status" & _
        '                 " FROM dbo.queryProjectInfo" & _
        '                 " WHERE (isliving = 1) and isnull(manager_A,'')='" & UserName & "'"

        dsTempProject = gWs.GetCommonQueryInfo(strSql)
        dgQueryResult.DataSource = dsTempProject.Tables(0).DefaultView

        If dsTempProject.Tables(0).Rows.Count = 0 Then
            MsgBox("无项目列表!", MsgBoxStyle.Information, "项目暂缓")
            btnEntery.Enabled = False
            Exit Sub
        End If


        iIndex = dgQueryResult.CurrentRowIndex
        '获取项目ID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)
        'serviceType = dgQueryResult.Item(iIndex, 4)

    End Sub

    '检查是否进入在保
    Private Function CancelProcessDo() As Boolean
        Dim strSql As String
        '  获取工作日志中信息，判断该项目是否存在签发放款通知书任务
        strSql = "{project_code='" & tmpProjectID & "' and task_name in('建立项目还款计划', '登记出函回执') }"
        Dim dsWorklog As DataSet = gWs.GetWorkLogInfo(strSql)
        If dsWorklog.Tables(0).Rows.Count <> 0 Then
            MsgBox("该项目进入在保阶段,不可暂缓!", MsgBoxStyle.Information, "项目暂缓")
            Return False
        End If
        Return True
    End Function
    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        Dim response As MsgBoxResult
        Dim strErr As String

        iIndex = dgQueryResult.CurrentRowIndex
        If Not CancelProcessDo() Then
            Exit Sub
        End If
        '获取列表当前行的项目ID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)

        response = MsgBox("是否确定要暂缓项目?", MsgBoxStyle.YesNo, "项目暂缓")

        '调用cancelProcess方法取消所选项目的工作流
        If response = MsgBoxResult.Yes Then

            strErr = gWs.CreateProcess("项目结束", Trim(tmpProjectID), UserName)
            If strErr = "1" Then
                MsgBox("项目暂缓成功!", MsgBoxStyle.Information, "项目暂缓")
                dsTempProject.Tables(0).Rows(iIndex).Delete()
                dsTempProject.AcceptChanges()
                RaiseEvent refreshTaskCommit()
            Else
                MsgBox("项目暂缓失败:" & strErr, MsgBoxStyle.Critical, "项目暂缓")
            End If
        Else
            Exit Sub
        End If

    End Sub


    Private Sub dgQueryResult_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgQueryResult.CurrentCellChanged

        'qxd add 20034-7-23
        iIndex = dgQueryResult.CurrentRowIndex
        '获取项目ID
        If iIndex > -1 Then
            tmpProjectID = dgQueryResult.Item(iIndex, 0)
        End If

        Static lastRow As Integer = -1
        If dgQueryResult.CurrentRowIndex <> lastRow Then
            iIndex = dgQueryResult.CurrentRowIndex
            '获取项目ID
            tmpProjectID = dgQueryResult.Item(iIndex, 0)
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
End Class
