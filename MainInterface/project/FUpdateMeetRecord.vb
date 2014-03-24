

Public Class FUpdateMeetRecord
    Inherits MainInterface.frmBasic

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
    Public WithEvents GroupQuery As System.Windows.Forms.GroupBox
    Friend WithEvents txtCorporation As System.Windows.Forms.TextBox
    Friend WithEvents LabelCustomer As System.Windows.Forms.Label
    Friend WithEvents btnQueryProject As System.Windows.Forms.Button
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents LabelQuery As System.Windows.Forms.Label
    Public WithEvents btnQuery As System.Windows.Forms.Button
    Public WithEvents btnEntery As System.Windows.Forms.Button
    Public WithEvents dgQueryResult As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FUpdateMeetRecord))
        Me.GroupQuery = New System.Windows.Forms.GroupBox()
        Me.txtCorporation = New System.Windows.Forms.TextBox()
        Me.LabelCustomer = New System.Windows.Forms.Label()
        Me.btnQueryProject = New System.Windows.Forms.Button()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.LabelQuery = New System.Windows.Forms.Label()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.btnEntery = New System.Windows.Forms.Button()
        Me.dgQueryResult = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupQuery.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(349, 408)
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'GroupQuery
        '
        Me.GroupQuery.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupQuery.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCorporation, Me.LabelCustomer, Me.btnQueryProject, Me.txtProjectCode, Me.LabelQuery})
        Me.GroupQuery.Location = New System.Drawing.Point(8, 2)
        Me.GroupQuery.Name = "GroupQuery"
        Me.GroupQuery.Size = New System.Drawing.Size(576, 45)
        Me.GroupQuery.TabIndex = 16
        Me.GroupQuery.TabStop = False
        '
        'txtCorporation
        '
        Me.txtCorporation.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtCorporation.Location = New System.Drawing.Point(256, 16)
        Me.txtCorporation.Name = "txtCorporation"
        Me.txtCorporation.Size = New System.Drawing.Size(224, 21)
        Me.txtCorporation.TabIndex = 16
        Me.txtCorporation.Text = ""
        '
        'LabelCustomer
        '
        Me.LabelCustomer.Location = New System.Drawing.Point(200, 21)
        Me.LabelCustomer.Name = "LabelCustomer"
        Me.LabelCustomer.Size = New System.Drawing.Size(72, 16)
        Me.LabelCustomer.TabIndex = 15
        Me.LabelCustomer.Text = "企业名称"
        '
        'btnQueryProject
        '
        Me.btnQueryProject.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnQueryProject.Image = CType(resources.GetObject("btnQueryProject.Image"), System.Drawing.Bitmap)
        Me.btnQueryProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQueryProject.ImageIndex = 26
        Me.btnQueryProject.ImageList = Me.ImageListBasic
        Me.btnQueryProject.Location = New System.Drawing.Point(488, 15)
        Me.btnQueryProject.Name = "btnQueryProject"
        Me.btnQueryProject.Size = New System.Drawing.Size(77, 23)
        Me.btnQueryProject.TabIndex = 14
        Me.btnQueryProject.Text = "查 询(&Q)"
        Me.btnQueryProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(64, 16)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(104, 21)
        Me.txtProjectCode.TabIndex = 13
        Me.txtProjectCode.Text = ""
        '
        'LabelQuery
        '
        Me.LabelQuery.Location = New System.Drawing.Point(10, 21)
        Me.LabelQuery.Name = "LabelQuery"
        Me.LabelQuery.Size = New System.Drawing.Size(86, 16)
        Me.LabelQuery.TabIndex = 12
        Me.LabelQuery.Text = "项目编码"
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuery.ImageIndex = 1
        Me.btnQuery.ImageList = Me.ImageListBasic
        Me.btnQuery.Location = New System.Drawing.Point(171, 407)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(77, 23)
        Me.btnQuery.TabIndex = 15
        Me.btnQuery.Text = "查 看(&L)"
        Me.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEntery
        '
        Me.btnEntery.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEntery.Image = CType(resources.GetObject("btnEntery.Image"), System.Drawing.Bitmap)
        Me.btnEntery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntery.ImageIndex = 7
        Me.btnEntery.ImageList = Me.ImageListBasic
        Me.btnEntery.Location = New System.Drawing.Point(258, 407)
        Me.btnEntery.Name = "btnEntery"
        Me.btnEntery.Size = New System.Drawing.Size(77, 23)
        Me.btnEntery.TabIndex = 14
        Me.btnEntery.Text = "处 理(&T)"
        Me.btnEntery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgQueryResult
        '
        Me.dgQueryResult.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.dgQueryResult.CaptionVisible = False
        Me.dgQueryResult.DataMember = ""
        Me.dgQueryResult.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgQueryResult.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgQueryResult.Location = New System.Drawing.Point(10, 56)
        Me.dgQueryResult.Name = "dgQueryResult"
        Me.dgQueryResult.ReadOnly = True
        Me.dgQueryResult.Size = New System.Drawing.Size(574, 342)
        Me.dgQueryResult.TabIndex = 13
        Me.dgQueryResult.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgQueryResult
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn1.MappingName = "ProjectCode"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "企业名称"
        Me.DataGridTextBoxColumn2.MappingName = "EnterpriseName"
        Me.DataGridTextBoxColumn2.Width = 400
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "阶段"
        Me.DataGridTextBoxColumn3.MappingName = "phase"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "状态"
        Me.DataGridTextBoxColumn4.MappingName = "status"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'FUpdateMeetRecord
        '
        Me.AcceptButton = Me.btnQueryProject
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 437)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupQuery, Me.btnQuery, Me.btnEntery, Me.dgQueryResult, Me.btnExit})
        Me.Name = "FUpdateMeetRecord"
        Me.Text = "修改评审会结论"
        Me.GroupQuery.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsTempProject As DataSet
    Private tmpProjectID As String
    Private iIndex As Integer
    Public Event refreshTaskCommit()
   
    Private Sub FUpdateMeetRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '1.获得允许修改记录评审会评审结论的项目列表
        Dim strSql As String

        ''获取项目列表,获取做过记录评审会结论任务的项目
        ''做过“记录评审会结论”且未放过款（loan_notice没有记录），且没有正在做“修改评审会结论流程”（没有workflow_id=15的流程）
        ''放款阶段的项目不能修改评审会结论，只有项目经理A角才能申请修改自己负责项目的评审会结论
        'strSql = "select a.project_code as ProjectCode ,c.corporation_name as EnterpriseName,a.phase,a.status from project a " & _
        '        " left join corporation c " & _
        '        " on a.corporation_code=c.corporation_code " & _
        '        " where project_code in (select project_code from project_task_attendee " & _
        '        " where task_id='RecordReviewConclusion'  and task_status='F' " & _
        '        " and project_code not in (select distinct(project_code) from project_task_attendee where workflow_id='15') " & _
        '        " and  project_code in (select distinct(project_code) from project_task_attendee where attend_person='" & UserName & "' and  role_id='24'))" & _
        '        " and a.project_code not in(select distinct project_code from loan_notice)"

        '获取项目列表,获取做过记录评审会结论任务的项目
        'yjf eidt 且放款方式为多次放款，且未放完款（放款总金额小于评审会通过金额），且放款的最后一次意见不为同意
        '且没有正在做“修改评审会结论流程”（没有workflow_id=15的流程）
        '放款阶段的项目不能修改评审会结论，只有项目经理A角才能申请修改自己负责项目的评审会结论
        'strSql = "select a.project_code as ProjectCode ,c.corporation_name as EnterpriseName,a.phase,a.status from project a " & _
        '        " left join corporation c " & _
        '        " on a.corporation_code=c.corporation_code " & _
        '        " where project_code in (select project_code from project_task_attendee " & _
        '        " where task_id='RecordReviewConclusion'  and task_status='F' " & _
        '        " and project_code not in (select distinct(project_code) from project_task_attendee where workflow_id='15') " & _
        '        " and  project_code in (select distinct(project_code) from project_task_attendee where attend_person='" & UserName & "' and  role_id='24'))" & _
        '        " and a.project_code not in (select top 1 project_code from project_opinion where item_type='54' and item_code='001' and isnull(conclusion,'')='同意') " & _
        '        " union " & _
        '        " select ProjectCode as project_code,EnterpriseName,phase,status from viewProjectInfo " & _
        '        " where rtrim(isnull(LoanType,''))='多次放款' and isnull(loan_sum,0)<isnull(GuaranteeSum,0) and isnull(manager_a,'')='" & UserName & "'" & _
        '        " and isliving<>0"
        'strSql = " select ProjectCode , EnterpriseName,phase,status from viewprojectinfo " & _
        '         " where guaranteesum is not null and manager_a='" & UserName & "'" & _
        '         " and certificate_sum is null " & _
        '         " and loan_sum is null " & _
        '         " UNION " & _
        '         " select ProjectCode as project_code,EnterpriseName,phase,status from viewProjectInfo " & _
        '         " where rtrim(isnull(LoanType,''))='多次放款' and isnull(loan_sum,0)<isnull(GuaranteeSum,0) and isnull(manager_a,'')='" & UserName & "'" & _
        '         " and isliving<>0 "

        strSql = " SELECT ProjectCode, EnterpriseName, phase, Status,ServiceType" & _
               " FROM dbo.queryProjectInfo" & _
               " WHERE  (isliving = 1) and (manager_A='" & UserName & "'" & _
               " or (select top 1 attend_person from project_task_attendee where project_task_attendee.project_code=queryProjectInfo.ProjectCode and role_id='24')='" & UserName & "') "


        'strSql = " SELECT ProjectCode, EnterpriseName, phase, Status,ServiceType" & _
        '     " FROM dbo.queryProjectInfo" & _
        '     " WHERE  (manager_A='" & UserName & "'" & _
        '     " or (select top 1 attend_person from project_task_attendee where project_task_attendee.project_code=queryProjectInfo.ProjectCode and role_id='24')='" & UserName & "') "



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
    End Sub

    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        Dim response As MsgBoxResult
        Dim strErr As String
        Dim strCorpName As String

        iIndex = dgQueryResult.CurrentRowIndex

        '获取列表当前行的项目ID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)
        strCorpName = dgQueryResult.Item(iIndex, 1)


        'add   yansm   2013/12/5
        '判断是否记录过评审会结论
        If gWs.GetCommonQueryInfo("select task_id from work_log where project_code='" & Me.tmpProjectID & "'and task_id='RecordReviewConclusion'").Tables(0).Rows.Count = 0 Then
            MsgBox("该项目未记录过评审会结论，不能修改！", MsgBoxStyle.OkOnly, "修改评审意见表")
            Return
        End If

        Dim updateMeetApply As FUpdateMeetRecordApply = New FUpdateMeetRecordApply()
        updateMeetApply.OpenApplyTool(tmpProjectID, strCorpName, getWorkFlowID(), getTaskID(), Me, UserName)

        'response = MsgBox("是否确定启动修改评审会结论流程?", MsgBoxStyle.YesNo, "修改评审会结论")

        ''调用cancelProcess方法取消所选项目的工作流
        'If response = MsgBoxResult.Yes Then

        'strErr = gWs.CreateProcess("修改评审会结论", Trim(tmpProjectID), UserName)


        'If strErr = "1" Then
        '    MsgBox("启动修改评审会结论流程成功!", MsgBoxStyle.Information, "修改评审会结论")
        '    dsTempProject.Tables(0).Rows(iIndex).Delete()
        '    dsTempProject.AcceptChanges()
        '    RaiseEvent refreshTaskCommit()
        'Else
        '    MsgBox("启动修改评审会结论流程失败:" & strErr, MsgBoxStyle.Critical, "修改评审会结论")
        'End If
        'Else
        '    Exit Sub
        'End If

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
            'tmpProjectID = dgQueryResult.Item(iIndex, 0)
            If iIndex > -1 Then
                tmpProjectID = dgQueryResult.Item(iIndex, 0)
                Me.btnEntery.Enabled = True
                Me.btnQuery.Enabled = True
            Else
                Me.btnEntery.Enabled = False
                Me.btnQuery.Enabled = False
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

    '基类的查询项目详细信息按钮事件
    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Try

            Dim index As Integer
            Dim strProjectCode, strCorpName As String
            index = Me.dgQueryResult.CurrentRowIndex()
            If index < 0 Then
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            strProjectCode = Me.dgQueryResult.Item(index, 0)
            strCorpName = Me.dgQueryResult.Item(index, 1)

            Dim frmQueryProjectInfo As New frmShowProjectInfo(strProjectCode, strCorpName)
            frmQueryProjectInfo.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("查看项目信息时出错！(" & ex.Message & ")", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
