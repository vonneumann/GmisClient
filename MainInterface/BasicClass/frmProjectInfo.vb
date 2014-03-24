

Public Class frmProjectInfo
    Inherits MainInterface.frmBasicProject

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
    Friend WithEvents btnEntery As System.Windows.Forms.Button
    Friend WithEvents btnRollBack As System.Windows.Forms.Button
    Public WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend Shadows WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProjectInfo))
        Me.btnEntery = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnRollBack = New System.Windows.Forms.Button
        Me.btnQuery = New System.Windows.Forms.Button
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.txtCorporationName = New System.Windows.Forms.TextBox
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'dgQueryResult
        '
        Me.dgQueryResult.AccessibleName = "DataGrid"
        Me.dgQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgQueryResult.Name = "dgQueryResult"
        Me.dgQueryResult.Size = New System.Drawing.Size(656, 292)
        '
        'project_group
        '
        Me.project_group.Location = New System.Drawing.Point(8, 64)
        Me.project_group.Name = "project_group"
        Me.project_group.Size = New System.Drawing.Size(662, 312)
        Me.project_group.Text = "项目列表"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(474, 388)
        Me.btnExit.Name = "btnExit"
        '
        'btnEntery
        '
        Me.btnEntery.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEntery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntery.ImageIndex = 3
        Me.btnEntery.ImageList = Me.ImageList1
        Me.btnEntery.Location = New System.Drawing.Point(362, 388)
        Me.btnEntery.Name = "btnEntery"
        Me.btnEntery.Size = New System.Drawing.Size(94, 24)
        Me.btnEntery.TabIndex = 2
        Me.btnEntery.Text = "任务处理(&T)"
        Me.btnEntery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnRollBack
        '
        Me.btnRollBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRollBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRollBack.ImageIndex = 1
        Me.btnRollBack.ImageList = Me.ImageList1
        Me.btnRollBack.Location = New System.Drawing.Point(130, 388)
        Me.btnRollBack.Name = "btnRollBack"
        Me.btnRollBack.Size = New System.Drawing.Size(77, 24)
        Me.btnRollBack.TabIndex = 3
        Me.btnRollBack.Text = "回 退(&R)"
        Me.btnRollBack.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuery.ImageIndex = 2
        Me.btnQuery.ImageList = Me.ImageList1
        Me.btnQuery.Location = New System.Drawing.Point(226, 388)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(118, 24)
        Me.btnQuery.TabIndex = 6
        Me.btnQuery.Text = "项目信息查看(&L)"
        Me.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn1.MappingName = "ProjectCode"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 70
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "企业名称"
        Me.DataGridTextBoxColumn2.MappingName = "EnterpriseName"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "阶段"
        Me.DataGridTextBoxColumn3.MappingName = "phase"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 40
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "状态"
        Me.DataGridTextBoxColumn4.MappingName = "Status"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 60
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "前置任务"
        Me.DataGridTextBoxColumn5.MappingName = "previous_task_name"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 110
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "前置任务完成人"
        Me.DataGridTextBoxColumn6.MappingName = "previous_task_attendee"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 95
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = "yyyy-MM-dd HH:mm"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "任务开始时间"
        Me.DataGridTextBoxColumn7.MappingName = "start_time"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 110
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "允许滞留天数"
        Me.DataGridTextBoxColumn8.MappingName = "time_limit"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 80
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "应用项"
        Me.DataGridTextBoxColumn9.MappingName = "apply_tool"
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "Task_ID"
        Me.DataGridTextBoxColumn10.MappingName = "previous_task_id"
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "启动方式"
        Me.DataGridTextBoxColumn11.MappingName = "task_mode"
        Me.DataGridTextBoxColumn11.Width = 0
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "业务品种"
        Me.DataGridTextBoxColumn12.MappingName = "servicetype"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 130
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "角色ID"
        Me.DataGridTextBoxColumn13.MappingName = "role_id"
        Me.DataGridTextBoxColumn13.NullText = ""
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "担保金额"
        Me.DataGridTextBoxColumn14.MappingName = "GuaranteeSum"
        Me.DataGridTextBoxColumn14.Width = 75
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "企业名称："
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Controls.Add(Me.txtCorporationName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(664, 48)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询条件"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.Location = New System.Drawing.Point(576, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "查询"
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorporationName.Location = New System.Drawing.Point(72, 16)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.Size = New System.Drawing.Size(496, 21)
        Me.txtCorporationName.TabIndex = 8
        Me.txtCorporationName.Text = ""
        '
        'frmProjectInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(680, 421)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.btnRollBack)
        Me.Controls.Add(Me.btnEntery)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProjectInfo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.btnEntery, 0)
        Me.Controls.SetChildIndex(Me.btnRollBack, 0)
        Me.Controls.SetChildIndex(Me.btnQuery, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.project_group, 0)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private ws As htfServer.Service1 = gWs
    Private strUser As String = UserName
    Friend strTaskID As String   '任务ID
    Friend arrTask As ArrayList
    Private dsTask As DataSet


    Private strProjectCode As String
    Private index() As Color   'added by hute 03-10-08 用以记录每行的风险等级

    Public Event TaskCommit()

    Private taskName As String

    '双击DataGrid
    Private Sub dgQueryResult_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgQueryResult.DoubleClick
        Me.Cursor = Cursors.WaitCursor
        Dim index As Integer
        Dim strCorpName As String
        Dim strWorkFlow As String
        Dim strApplyTool As String
        Dim strRoleID As String
        Dim i As Int16
        Try
            index = Me.dgQueryResult.CurrentRowIndex()
            If index < 0 Then
                Me.Cursor = Cursors.Arrow
                Exit Sub
            End If
            strProjectCode = Me.dgQueryResult.Item(index, 0)
            strCorpName = Me.dgQueryResult.Item(index, 1)
            strApplyTool = Me.dgQueryResult.Item(index, 8)
            strRoleID = Me.dgQueryResult.Item(index, 12)
            'If strTaskID = "AppraiseProjectProcess" Then
            '    strApplyTool = "frmProjectAppraisement"
            'Else
            '    strApplyTool = Me.dgQueryResult.Item(index, 8)
            'End If
            '

            'strWorkFlow = Me.dgQueryResult.Item(index, 9)

            If strProjectCode = "" Then
                Me.Cursor = Cursors.Arrow
                Exit Sub
            End If

            For i = 0 To Me.arrTask.Count / 3 - 1
                If arrTask(3 * i).toupper = strProjectCode.ToUpper Then
                    strWorkFlow = arrTask(3 * i + 1)
                    'strApplyTool = arrTask(3 * i + 2)
                    'MsgBox(arrApplyTool(2 * i + 1))
                    Exit For
                End If
            Next

            If strTaskID = "ReviewMeetingPlan" Or strTaskID = "PlanSignature" Then
                strProjectCode = ""
                For i = 0 To Me.arrTask.Count / 3 - 1
                    strProjectCode = strProjectCode & arrTask(3 * i) & ","
                Next
                strProjectCode = strProjectCode.Substring(0, strProjectCode.Length - 1)
            End If

            strApplyTool = "MainInterface." & strApplyTool
            Dim t As System.Type = System.Type.GetType(strApplyTool)
            Dim frmApply As IApplyTool = Activator.CreateInstance(t)
            AddHandler frmApply.CommitSucceed, AddressOf project_refresh
            frmApply.OpenApplyTool(strProjectCode, strCorpName, strWorkFlow, strTaskID, Me, strUser, taskName, strRoleID)
            Me.Cursor = Cursors.Arrow

        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            MessageBox.Show("进入任务处理时出错!(" & ex.Message & ")", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'SWDialogBox.MessageBox.Show("$Login106")
        End Try
    End Sub

    Private Sub dgQueryResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgQueryResult.Click
        setRollBack()
    End Sub

    Private Sub dgQueryResult_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgQueryResult.CurrentCellChanged
        setRollBack()
    End Sub

    Private Sub frmProjectInfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            FilldtGrid()
            '设置某些任务不能进行回退，按钮btnRollBack置为灰色
            If (strTaskID.ToUpper = "ReviewAssign".ToUpper Or strTaskID.ToUpper = "RecordReviewConclusion".ToUpper Or _
             strTaskID.ToUpper = "RefundRecord".ToUpper Or strTaskID.ToUpper = "RecordProjectProcess".ToUpper Or _
             strTaskID.ToUpper = "RecordProjectTraceInfo".ToUpper Or strTaskID.ToUpper = "RecordRefundCertificate".ToUpper Or _
             strTaskID.ToUpper = "AppraiseProjectProcess".ToUpper) _
            Then
                Me.btnRollBack.Enabled = False
            Else
                setRollBack()
            End If

            taskName = getTaskNameFromMeText(Me.Text)
            AddHandler TaskCommit, AddressOf isCloseFrm
        Catch ex As Exception
            'MessageBox.Show("列出项目时出错！（" & ex.Message & "）", "提示", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
            SWDialogBox.MessageBox.Show("$Login106")
        End Try
    End Sub

    '在点击项目列表时，判断该任务的前驱任务是否为记录评审会评审结论（RecordReviewConclusion）；
    '如果是，则屏蔽回退按钮
    Private Sub setRollBack()
        Me.Cursor = Cursors.WaitCursor
        Dim index As Integer
        Dim task_ID As String
        Dim task_Name As String = ""
        Dim i As Int16
        Try
            index = Me.dgQueryResult.CurrentRowIndex()

            If index < 0 Then
                Me.Cursor = Cursors.Arrow
                Exit Sub
            End If

            task_ID = Me.dgQueryResult.Item(index, 9)
            task_Name = Me.dgQueryResult.Item(index, 4)

            'If task_ID.ToUpper = "RecordReviewConclusion".ToUpper Then
            If (strTaskID.ToUpper = "ReviewAssign".ToUpper Or strTaskID.ToUpper = "RecordReviewConclusion".ToUpper Or _
            strTaskID.ToUpper = "RefundRecord".ToUpper Or strTaskID.ToUpper = "RecordProjectProcess".ToUpper Or _
            strTaskID.ToUpper = "RecordProjectTraceInfo".ToUpper Or strTaskID.ToUpper = "RecordRefundCertificate".ToUpper Or _
            strTaskID.ToUpper = "AppraiseProjectProcess".ToUpper) Or task_Name = "" Or task_ID.ToUpper = "Application".ToUpper _
           Then
                Me.btnRollBack.Enabled = False
            Else
                Me.btnRollBack.Enabled = True
            End If

            Me.Cursor = Cursors.Arrow
        Catch ex As Exception
            Me.Cursor = Cursors.Arrow
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '根据具体的Task,得到相关的项目信息;
    Private Function getProject(ByVal arrTaskLst As ArrayList) As DataSet
        Dim dataSetProject As DataSet
        Dim arrProject As New ArrayList
        Dim strSql As String
        Dim i As Integer

        If arrTaskLst.Count = 0 Then
            Return Nothing
        End If

        '抽取项目列表
        For i = 0 To arrTaskLst.Count / 3 - 1
            If arrTaskLst(3 * i) <> "" Then
                arrProject.Add(arrTaskLst(3 * i))
            End If
        Next

        If arrProject.Count = 0 Then
            Return Nothing
        End If

        Try
            strSql = "{projectcode in ("
            For i = 0 To arrProject.Count - 1
                If i = 0 Then
                    strSql = strSql & "'" & arrProject(i) & "'"
                Else
                    strSql = strSql & ",'" & arrProject(i) & "'"
                End If
            Next
            strSql = strSql & ") order by projectcode}"
            If ws Is Nothing Then
                ws = GetWebService(strUrl)
            End If
            'dataSetProject = ws.GetProjectInfo(strSql)
            dataSetProject = ws.GetProjectInfoEx(strSql)
            Return dataSetProject
        Catch ex As Exception
            'MessageBox.Show("数据库出错!(" & ex.Message & ")", "提示", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
            SWDialogBox.MessageBox.Show("$Login106")
        End Try
    End Function

    Private Function getCorpInfo() As DataSet
        Try
            Dim dsCorp As DataSet

            If ws Is Nothing Then
                ws = GetWebService(strUrl)
            End If

            dsCorp = ws.GetcorporationInfo("%", "null")
            Return dsCorp
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Private Sub FilldtGrid()
        Try
            'Dim strPhase As String

            'Dim dsTmp As DataSet
            'dsTmp = gWs.GetTaskProjectList(strTaskID, UserName)
            'If dsTmp Is Nothing Then
            '    dgQueryResult.DataSource = Nothing
            '    dgQueryResult.DataMember = ""
            '    Exit Sub
            'End If

            ''MyBase.CreateDtGrig(dsTmp.Tables(0).TableName)
            ''If dsTmp.Tables("viewproject").Rows(0).Item("phase") Is DBNull.Value Then
            ''    strPhase = "初审"
            ''Else
            ''    strPhase = dsTmp.Tables("viewproject").Rows(0).Item("phase")
            ''End If

            'dgQueryResult.DataSource = dsTmp
            'dgQueryResult.DataMember = dsTmp.Tables(0).TableName
            '项目评审时，对datagrid进行着色

            '如果是“项目评价”，则按照是否项目评价、风险等级排序；其他则按企业名称排序
            If strTaskID = "AppraiseProjectProcess" Then
                dsTask = gWs.GetTaskProjectList(strTaskID, UserName, 1)
            Else
                dsTask = gWs.GetTaskProjectList(strTaskID, UserName)
            End If
            dsTask.Tables(0).Columns.Add(New DataColumn("task_mode", GetType(String), "iif(start_mode = 'manual','手动','自动')"))
            If dsTask Is Nothing Then
                dgQueryResult.DataSource = Nothing
                dgQueryResult.DataMember = ""
                Exit Sub
            End If

            dvTask = dsTask.Tables(0).DefaultView
            dgQueryResult.DataSource = dvTask
            'dgQueryResult.DataMember = dsTask.Tables(0).TableName
            If strTaskID = "AppraiseProjectProcess" Then
                GetRowColor()
                SetDataGridStyle()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    '------------------------------------------------------------------------------------
    'added by hute 03-10-08
    '根据dataset中的risk_grade得到每一行需要着色的类别，置入index()
    Public Sub GetRowColor()
        Dim i As Integer = 0
        Dim temp As DataSet
        Dim hasConclusion As Boolean
        'temp = gWs.GetAppraisementInfo("%")

        ReDim index(dsTask.Tables(0).Rows.Count - 1)
        Dim dr As DataRow
        For Each dr In dsTask.Tables(0).Rows
            If dr("hasAppraised") Is DBNull.Value Then
                hasConclusion = False
            Else
                hasConclusion = dr("hasAppraised")
            End If
            'hasConclusion = False
            'If Not temp.Tables(0).Select("project_code='" & dr("ProjectCode") & "'").Length = 0 Then
            '    hasConclusion = True                          '风险管理部长有评价
            'End If
            If dr("risk_grade") Is DBNull.Value Then
                index(i) = Color.White                        '项目经理未做评价 (正常着色)
            Else
                Select Case dr("risk_grade")
                    Case 0
                        If hasConclusion Then
                            index(i) = Color.White            '风险管理部长评价过后的正常项目 (正常着色) 
                        Else
                            index(i) = Color.LightGreen       '风险管理部长未做评价的正常项目 (浅绿)
                        End If
                    Case 1
                        If hasConclusion Then
                            index(i) = Color.SkyBlue          '风险管理部长评价过后的风险项目 (天蓝)
                        Else
                            index(i) = Color.Yellow           '项目经理评价风险一级           (黄色)  
                        End If
                    Case 2
                        If hasConclusion Then
                            index(i) = Color.SkyBlue
                        Else
                            index(i) = Color.Orange           '项目经理评价风险二级           (橙色) 
                        End If
                    Case 3
                        If hasConclusion Then
                            index(i) = Color.SkyBlue
                        Else
                            index(i) = Color.Red              '项目经理评价风险三级           (红色)
                        End If
                End Select
            End If
            i = i + 1
        Next
    End Sub

    '为每一行对应着色
    Public Sub SetDataGridStyle()
        Dim ts As New DataGridTableStyle
        Dim aColumnTextColumn As DataGridColoredTextBoxColumn '上面自定义的类
        Dim numCols As Integer
        Dim numindex() As Integer

        ts.AllowSorting = False                 '设置不能排序
        'ts.MappingName = CType(dgQueryResult.DataSource, DataSet).Tables(0).TableName
        ts.MappingName = CType(dgQueryResult.DataSource, DataView).Table.TableName

        Dim i, j As Integer
        i = 0
        j = 0

        Do While (i < 13) '重绘所有的列
            aColumnTextColumn = New DataGridColoredTextBoxColumn
            ReDim aColumnTextColumn.ForeColor(index.Length)
            ReDim aColumnTextColumn.BackColor(index.Length)
            For j = 0 To index.Length - 1
                aColumnTextColumn.rowcollection.Add(j) '指定行数 
                aColumnTextColumn.ForeColor(j) = Color.Black
                aColumnTextColumn.BackColor(j) = index(j)
            Next

            'aColumnTextColumn.MappingName = dt.Table.Columns(i).ColumnName
            Select Case i
                Case 0
                    aColumnTextColumn.MappingName = "ProjectCode"
                    aColumnTextColumn.HeaderText = "项目编码"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 70
                    aColumnTextColumn.NullText = String.Empty
                Case 1
                    aColumnTextColumn.MappingName = "EnterpriseName"
                    aColumnTextColumn.HeaderText = "企业名称"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 150
                    aColumnTextColumn.NullText = String.Empty
                Case 2
                    aColumnTextColumn.MappingName = "phase"
                    aColumnTextColumn.HeaderText = "阶段"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 40
                    aColumnTextColumn.NullText = String.Empty
                Case 3
                    aColumnTextColumn.MappingName = "Status"
                    aColumnTextColumn.HeaderText = "状态"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 60
                    aColumnTextColumn.NullText = String.Empty
                Case 4
                    aColumnTextColumn.MappingName = "previous_task_name"
                    aColumnTextColumn.HeaderText = "前置任务"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 110
                    aColumnTextColumn.NullText = String.Empty
                Case 5
                    aColumnTextColumn.MappingName = "previous_task_attendee"
                    aColumnTextColumn.HeaderText = "前置任务完成人"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 95
                    aColumnTextColumn.NullText = String.Empty
                Case 6
                    aColumnTextColumn.MappingName = "start_time"
                    aColumnTextColumn.HeaderText = "任务开始时间"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 110
                    aColumnTextColumn.NullText = String.Empty
                    aColumnTextColumn.Format = "yyyy-MM-dd HH:mm"
                Case 7
                    aColumnTextColumn.MappingName = "time_limit"
                    aColumnTextColumn.HeaderText = "允许滞留天数"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Right
                    aColumnTextColumn.Width = 110
                    aColumnTextColumn.NullText = String.Empty
                Case 8
                    aColumnTextColumn.MappingName = "apply_tool"
                    aColumnTextColumn.HeaderText = "启动窗口"
                    aColumnTextColumn.Width = 0
                    aColumnTextColumn.NullText = String.Empty
                Case 9
                    aColumnTextColumn.MappingName = "previous_task_id"
                    aColumnTextColumn.HeaderText = "task_id"
                    aColumnTextColumn.Alignment = HorizontalAlignment.Left
                    aColumnTextColumn.Width = 0
                    aColumnTextColumn.NullText = String.Empty
                Case 10
                    aColumnTextColumn.MappingName = "servicetype"
                    aColumnTextColumn.HeaderText = "业务品种"
                    aColumnTextColumn.Width = 130
                    aColumnTextColumn.NullText = String.Empty
                Case 11
                    aColumnTextColumn.MappingName = "task_mode"
                    aColumnTextColumn.HeaderText = "启动方式"
                    aColumnTextColumn.Width = 60
                    aColumnTextColumn.NullText = String.Empty
                Case 12
                    aColumnTextColumn.MappingName = "role_id"
                    aColumnTextColumn.HeaderText = "角色ID"
                    aColumnTextColumn.Width = 0
                    aColumnTextColumn.NullText = String.Empty
            End Select
            ts.GridColumnStyles.Add(aColumnTextColumn)
            i = (i + 1)
        Loop

        Me.dgQueryResult.TableStyles.Clear()
        Me.dgQueryResult.TableStyles.Add(ts)
    End Sub

    'DataGridTextBoxColumn的继承类，重载paint，重画DataGrid
    Public Class DataGridColoredTextBoxColumn
        Inherits DataGridTextBoxColumn  '继承接口

        Public rowcollection As New Collection   '用于存放行号的集合
        Public BackColor() As Color '用于存放背景色的集合，索引与行号集号一致(集合索引减１）
        Public ForeColor() As Color '用于存放前景色的集合，索引与行号集号一致

        Private Function GetText(ByVal Value As Object) As String
            '为进行重绘读出textbox中的内容，这个函数是增加容错能力的，与实现机制无关
            If TypeOf (Value) Is System.DBNull Then
                Return NullText
            ElseIf Value Is Nothing Then
                Return ""
            Else
                Return Value.ToString
            End If
        End Function

        Protected Overloads Overrides Sub Paint(ByVal g As System.Drawing.Graphics, _
            ByVal bounds As System.Drawing.Rectangle, _
            ByVal source As System.Windows.Forms.CurrencyManager, _
            ByVal rowNum As Integer, _
            ByVal backBrush As System.Drawing.Brush, _
            ByVal foreBrush As System.Drawing.Brush, _
            ByVal alignToRight As Boolean)

            Dim text As String              '按默认模式重绘
            text = GetText(GetColumnValueAtRow(source, rowNum)) '这句就是上文提及的取数据
            backBrush = New SolidBrush(TextBox.BackColor) '背景色
            foreBrush = New SolidBrush(TextBox.ForeColor)  '前景色

            ''防止用户没有定义集合大小
            'ReDim Preserve BackColor(rowcollection.Count)
            'ReDim Preserve ForeColor(rowcollection.Count)

            Dim i As Integer = 1 '集合索引从１开始
            Do While (i <= rowcollection.Count)
                If rowNum = Val(rowcollection.Item(i)) Then  '判断要集合中的行数是
                    If Not BackColor(i - 1).IsEmpty Then '没有定义的就按默认色绘制
                        backBrush = New SolidBrush(BackColor(i - 1))
                    End If
                    If Not ForeColor(i - 1).IsEmpty Then '没有定义的就按默认色绘制
                        foreBrush = New SolidBrush(ForeColor(i - 1))
                    End If
                End If
                i += 1
            Loop

            MyBase.PaintText(g, bounds, text, backBrush, foreBrush, alignToRight)
        End Sub
    End Class

    '------------------------------------------------------------------------------------
    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        dgQueryResult_DoubleClick(sender, e)
    End Sub

    Private Sub btnRollBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRollBack.Click
        Dim index As Integer
        Dim strProjectCode As String
        Dim strWorkFlow, strRtn As String
        Dim i As Int16
        Try
            index = Me.dgQueryResult.CurrentRowIndex()
            If index < 0 Then
                Exit Sub
            End If
            strProjectCode = Me.dgQueryResult.Item(index, 0)

            Dim task_name As String = Me.dgQueryResult.Item(index, 4)     'added by hute 2003-12-25
            Dim attend_person As String = Me.dgQueryResult.Item(index, 5) 'added by hute 2003-12-25

            'If MsgBox("确认回退项目（" & strProjectCode & "）？", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "提示") = MsgBoxResult.No Then
            If Not (SWDialogBox.MessageBox.Show("?1000", "回退") = DialogResult.Yes) Then
                Exit Sub
            End If

            If Not strProjectCode = "" Then
                For i = 0 To Me.arrTask.Count / 3 - 1
                    If arrTask(3 * i).toupper = strProjectCode.ToUpper Then
                        strWorkFlow = arrTask(3 * i + 1)
                        Exit For
                    End If
                Next
            Else
                'MsgBox("请选中项目,并保证项目编码不为空!", MsgBoxStyle.Exclamation, "警告")
                SWDialogBox.MessageBox.Show("$1007", "回退项目")
                Exit Sub
            End If
            Dim strReason As String
            'strReason = InputBox("请输入回退原因", "回退消息发送", , )
            Dim frmRollbakreason As New FRollbackReason
            frmRollbakreason.ShowDialog()
            strReason = frmRollbakreason.txtReason.Text
            strRtn = gWs.rollbackTask(strWorkFlow, strProjectCode, strTaskID, UserName, strReason)
            If strRtn = "1" Then
                RaiseEvent TaskCommit()
                For i = Me.arrTask.Count / 3 - 1 To 0 Step -1
                    If arrTask(3 * i).toupper = strProjectCode.ToUpper Then
                        arrTask.RemoveAt(3 * i + 2)
                        arrTask.RemoveAt(3 * i + 1)
                        arrTask.RemoveAt(3 * i)
                    End If
                Next
                FilldtGrid()  '刷新项目列表
                SWDialogBox.MessageBox.Show("$OperateSucceed")
                RaiseEvent TaskCommit()
                If Me.dgQueryResult.DataSource Is Nothing Then
                    Me.Visible = False
                End If
            Else
                SWDialogBox.MessageBox.Show("*999", "任务回退失败", strRtn, "")
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim index As Integer
            Dim strProjectCode, strCorpName As String
            index = Me.dgQueryResult.CurrentRowIndex()
            If index < 0 Then
                Exit Sub
            End If
            strProjectCode = Me.dgQueryResult.Item(index, 0)
            strCorpName = Me.dgQueryResult.Item(index, 1)

            Dim frmQueryProjectInfo As New frmShowProjectInfo(strProjectCode, strCorpName)
            frmQueryProjectInfo.ShowDialog()
        Catch ex As Exception
            'MessageBox.Show("查看项目信息时出错！(" & ex.Message & ")", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SWDialogBox.MessageBox.Show("$Login106")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub project_refresh()
        Try
            RaiseEvent TaskCommit()
            Dim i As Integer
            If strTaskID = "ReviewMeetingPlan" Or strTaskID = "PlanSignature" Then
                '查询该任务
                Dim dsTmp As DataSet
                'Dim drtmp As DataRow
                '            Dim strSql As String

                dsTmp = ws.LookUpWorking(UserName)
                If dsTmp Is Nothing Then
                    Me.Close()
                    Exit Sub
                End If
                For i = Me.arrTask.Count / 3 - 1 To 0 Step -1
                    If dsTmp.Tables(0).Select("task_id='" & strTaskID & "' and project_code='" & arrTask(3 * i) & "'").Length = 0 Then
                        arrTask.RemoveAt(3 * i + 2)
                        arrTask.RemoveAt(3 * i + 1)
                        arrTask.RemoveAt(3 * i)
                    End If
                Next
            Else
                For i = Me.arrTask.Count / 3 - 1 To 0 Step -1
                    If strProjectCode = arrTask(3 * i) Then
                        arrTask.RemoveAt(3 * i + 2)
                        arrTask.RemoveAt(3 * i + 1)
                        arrTask.RemoveAt(3 * i)
                    End If
                Next
            End If
            'If arrTask.Count = 0 Then
            '    MyBase.Close()
            '    'Me.Visible = False
            'Else
            '    Me.FilldtGrid()
            'End If
            Me.FilldtGrid()
        Catch ex As Exception
            'MessageBox.Show("刷新项目时出错！（" & ex.Message & "）", "提示", MessageBoxButtons.OK, MsgBoxStyle.Exclamation)
            SWDialogBox.MessageBox.Show("$Login106")
        End Try
    End Sub

    '处理任务名称：去掉（*）。
    Private Function getTaskNameFromMeText(ByVal text As String) As String
        Dim i, len As Integer
        Dim strTemp As String

        len = text.Length
        If len > 0 Then
            i = text.IndexOf("(")
            strTemp = text.Substring(0, i)
        End If
        Return strTemp
    End Function

    '根据表中数据,判断是否关闭本窗口
    Private Sub isCloseFrm()
        If Not Me.dsTask.Tables(0).Rows.Count > 0 Then
            Me.Close()
        End If
    End Sub

    Private dvTask As DataView

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        Dim RowFilterExpr As String = ""
        RowFilterExpr = "EnterpriseName like '%" & txtCorporationName.Text.Trim & "%'"
        If RowFilterExpr = "" Then
            MessageBox.Show("您没有设定任何筛选条件")
            Exit Sub
        End If
        dvTask.RowFilter = RowFilterExpr

    End Sub
End Class
