

Public Class FReMeeting
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FReMeeting))
        Me.GroupQuery.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.project_group.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuery
        '
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.Visible = True
        '
        'btnEntery
        '
        Me.btnEntery.Image = CType(resources.GetObject("btnEntery.Image"), System.Drawing.Bitmap)
        Me.btnEntery.Visible = True
        '
        'GroupQuery
        '
        Me.GroupQuery.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
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
        Me.dgQueryResult.Visible = True
        '
        'project_group
        '
        Me.project_group.Visible = True
        '
        'FReMeeting
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 437)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.project_group, Me.GroupQuery, Me.btnQuery, Me.btnEntery, Me.btnExit})
        Me.Name = "FReMeeting"
        Me.Text = "重新上会"
        Me.GroupQuery.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.project_group.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsTempProject As DataSet
    Private tmpProjectID As String
    Private iIndex As Integer

    Public Event refreshTaskCommit()

    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        Dim ProjectCode As String = Me.dgQueryResult.Item(dgQueryResult.CurrentRowIndex, 0)
        If SWDialogBox.MessageBox.Show("?1000", "重新上会") = DialogResult.Yes Then
            Dim result As String = gWs.ReMeetingPlan(ProjectCode)
            If result = "1" Then
                SWDialogBox.MessageBox.Show("$OperateSucceed")
                RaiseEvent refreshTaskCommit()
            Else
                SWDialogBox.MessageBox.Show("*999", "重新上会失败", result, "")
            End If
        End If
    End Sub

    Private Sub FReMeeting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '获取项目列表
        'Dim i As Integer
        Dim strSql As String

        '获取项目列表
        '重新上会项目列表，只显示项目经理A负责的记录评审会任务状态为‘F’的项目
        'strSql = " SELECT ProjectCode, EnterpriseName, phase, Status" & _
        '         " FROM dbo.queryProjectInfo" & _
        '         " WHERE (isliving = 1) AND manager_A='" & UserName & "'"
        'strSql = "select ProjectCode, EnterpriseName, phase, Status from queryProjectinfo" & _
        '        " where projectcode in (" & _
        '        " select project_code from project_task_attendee " & _
        '        " where manager_A='" & UserName & "' and StartTime is null)"
        'strSql = " select ProjectCode , EnterpriseName,phase,status from viewprojectinfo " & _
        ' " where guaranteesum is not null and manager_a='" & UserName & "'" & _
        ' " and certificate_sum is null " & _
        ' " and loan_sum is null " & _
        ' " UNION " & _
        ' " select ProjectCode as project_code,EnterpriseName,phase,status from viewProjectInfo " & _
        ' " where rtrim(isnull(LoanType,''))='多次放款' and isnull(loan_sum,0)<isnull(GuaranteeSum,0) and isnull(manager_a,'')='" & UserName & "'" & _
        ' " and isliving<>0 "
        strSql = " SELECT ProjectCode, EnterpriseName, phase, Status,ServiceType" & _
               " FROM dbo.queryProjectInfo" & _
               " WHERE  (isliving = 1) and (manager_A='" & UserName & "'" & _
               " or (select top 1 attend_person from project_task_attendee where project_task_attendee.project_code=queryProjectInfo.ProjectCode and role_id='24')='" & UserName & "') "
        '" where projectcode in (" & _
        '" select project_code from project_task_attendee " & _
        '" where manager_A='" & UserName & "')"

        ''2005-03-21 yjf modify 
        ''修改重新上会列表，允许已提交上会的项目再次提交上会（放款前的项目）用RecordReturnReceipt任务状态不为F的项目
        'strSql = "select ProjectCode, EnterpriseName, phase, Status from queryProjectinfo" & _
        '              " where projectcode in (" & _
        '              " select project_code from project_task_attendee " & _
        '              " where task_id='RecordReturnReceipt'  and isnull(task_status,'')<>'F' ) and manager_A='" & UserName & "' and StartTime is null"
        dsTempProject = gWs.GetCommonQueryInfo(strSql)
        dgQueryResult.DataSource = dsTempProject.Tables(0).DefaultView

        If dsTempProject.Tables(0).Rows.Count = 0 Then
            MsgBox("无项目列表!", MsgBoxStyle.Information, "重新上会")
            btnEntery.Enabled = False
            Exit Sub
        End If


        iIndex = dgQueryResult.CurrentRowIndex
        '获取项目ID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)
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
    End Sub

End Class
