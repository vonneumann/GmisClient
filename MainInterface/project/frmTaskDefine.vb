'任务定义窗体
'继承工作流定义窗体
Public Class frmTaskDefine
    Inherits MainInterface.frmBaseWfDefine

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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csWorkflowID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csTaskID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csTaskName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cbServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents csPhase As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csStatus As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csTaskType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csApplyTool As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csMergeRelation As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csFlowTool As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csHasMessage As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents ImageListBasic As System.Windows.Forms.ImageList

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTaskDefine))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.csWorkflowID = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTaskID = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTaskName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csPhase = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csStatus = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTaskType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csApplyTool = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csMergeRelation = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csFlowTool = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csHasMessage = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbServiceType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ImageListBasic = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 64)
        Me.grdTable.Size = New System.Drawing.Size(496, 312)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.grdTable.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageIndex = -1
        Me.btnRefresh.ImageList = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(96, 384)
        Me.btnRefresh.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageIndex = -1
        Me.btnDelete.ImageList = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(184, 384)
        Me.btnDelete.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(360, 384)
        Me.btnExit.Visible = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.ImageIndex = -1
        Me.btnUpdate.ImageList = Nothing
        Me.btnUpdate.Location = New System.Drawing.Point(272, 384)
        Me.btnUpdate.Visible = True
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Bitmap)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 2
        Me.Button1.ImageList = Me.ImageListBasic
        Me.Button1.Location = New System.Drawing.Point(184, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(77, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "角 色(&R)"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Bitmap)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageIndex = 8
        Me.Button2.ImageList = Me.ImageListBasic
        Me.Button2.Location = New System.Drawing.Point(272, 420)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 23)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "流 转(&T)"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button3
        '
        Me.Button3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Bitmap)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImageIndex = 22
        Me.Button3.ImageList = Me.ImageListBasic
        Me.Button3.Location = New System.Drawing.Point(360, 420)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(77, 23)
        Me.Button3.TabIndex = 12
        Me.Button3.Text = "提 示(&A)"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csWorkflowID, Me.csTaskID, Me.csTaskName, Me.csPhase, Me.csStatus, Me.csTaskType, Me.csApplyTool, Me.csMergeRelation, Me.csFlowTool, Me.csHasMessage})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "task_template"
        '
        'csWorkflowID
        '
        Me.csWorkflowID.Format = ""
        Me.csWorkflowID.FormatInfo = Nothing
        Me.csWorkflowID.HeaderText = "模版ID"
        Me.csWorkflowID.MappingName = "workflow_id"
        Me.csWorkflowID.Width = 75
        '
        'csTaskID
        '
        Me.csTaskID.Format = ""
        Me.csTaskID.FormatInfo = Nothing
        Me.csTaskID.HeaderText = "任务ID"
        Me.csTaskID.MappingName = "task_id"
        Me.csTaskID.Width = 200
        '
        'csTaskName
        '
        Me.csTaskName.Format = ""
        Me.csTaskName.FormatInfo = Nothing
        Me.csTaskName.HeaderText = "任务名称"
        Me.csTaskName.MappingName = "task_name"
        Me.csTaskName.Width = 200
        '
        'csPhase
        '
        Me.csPhase.Format = ""
        Me.csPhase.FormatInfo = Nothing
        Me.csPhase.HeaderText = "阶段"
        Me.csPhase.MappingName = "phase"
        Me.csPhase.NullText = ""
        Me.csPhase.Width = 75
        '
        'csStatus
        '
        Me.csStatus.Format = ""
        Me.csStatus.FormatInfo = Nothing
        Me.csStatus.HeaderText = "状态"
        Me.csStatus.MappingName = "status"
        Me.csStatus.Width = 75
        '
        'csTaskType
        '
        Me.csTaskType.Format = ""
        Me.csTaskType.FormatInfo = Nothing
        Me.csTaskType.HeaderText = "任务类型"
        Me.csTaskType.MappingName = "task_type"
        Me.csTaskType.Width = 75
        '
        'csApplyTool
        '
        Me.csApplyTool.Format = ""
        Me.csApplyTool.FormatInfo = Nothing
        Me.csApplyTool.HeaderText = "应用工具"
        Me.csApplyTool.MappingName = "apply_tool"
        Me.csApplyTool.Width = 75
        '
        'csMergeRelation
        '
        Me.csMergeRelation.Format = ""
        Me.csMergeRelation.FormatInfo = Nothing
        Me.csMergeRelation.HeaderText = "汇集类型"
        Me.csMergeRelation.MappingName = "merge_relation"
        Me.csMergeRelation.Width = 75
        '
        'csFlowTool
        '
        Me.csFlowTool.Format = ""
        Me.csFlowTool.FormatInfo = Nothing
        Me.csFlowTool.HeaderText = "流程工具"
        Me.csFlowTool.MappingName = "flow_tool"
        Me.csFlowTool.Width = 75
        '
        'csHasMessage
        '
        Me.csHasMessage.Format = ""
        Me.csHasMessage.FormatInfo = Nothing
        Me.csHasMessage.HeaderText = "是否发消息"
        Me.csHasMessage.MappingName = "hasMessage"
        Me.csHasMessage.Width = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.cbServiceType, Me.Label1})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 45)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'cbServiceType
        '
        Me.cbServiceType.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.cbServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbServiceType.Location = New System.Drawing.Point(96, 17)
        Me.cbServiceType.Name = "cbServiceType"
        Me.cbServiceType.Size = New System.Drawing.Size(392, 20)
        Me.cbServiceType.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "请选择业务品种"
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageListBasic.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmTaskDefine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 453)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdTable, Me.GroupBox1, Me.Button3, Me.Button2, Me.Button1})
        Me.Name = "frmTaskDefine"
        Me.Text = "zh"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private iIndex As Integer
    Private tmpWorkflowID, tmpTaskID, tmpServiceType As String
    Private frmTaskRoleDefine As frmTaskRoleDefine
    Private frmTaskTransferDefine As frmTaskTransferDefine
    Private frmTimingTaskDefine As frmTimingTaskDefine
    Private dsResult As New DataSet()

    '重写父类的Refresh方法
    Public Overloads Overrides Sub Refresh()
        Try
            Dim strSql As String
            Dim i As Integer
            'strSql = "select distinct service_type from workflow"

            '获取所有的业务品种数据集
            'strSql = "SELECT DISTINCT b.service_type_code, b.service_type FROM workflow a ,service_type b where a.service_type = b.service_type ORDER BY b.service_type_code, b.service_type"
            strSql = "select distinct service_type from workflow"
            Dim dsServiceType As DataSet = gWs.GetCommonQueryInfo(strSql)

            '填充业务品种选择下拉列表
            For i = 0 To dsServiceType.Tables(0).Rows.Count - 1
                cbServiceType.Items.Add(dsServiceType.Tables(0).Rows(i).Item("service_type"))
            Next

        Catch ex As System.Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '重写父类的Update方法
    Public Overrides Function Update() As Boolean
        If cbServiceType.Text <> "" Then
            Try
                Me.Cursor = Cursors.WaitCursor
                '保存数据集的变化
                Dim dsCommit As DataSet = CType(grdTable.DataSource, DataSet)
                Dim result As String = gWs.UpdateWfTaskTemplate(dsCommit.GetChanges())

                If result = "1" Then
                    '接受所有更改
                    dsCommit.AcceptChanges()

                    Return True
                Else
                    MessageBox.Show("系统返回信息：" + result, "数据引擎", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As System.Exception
                ExceptionHandler.ShowMessageBox(ex)
            Finally
                Me.Cursor = Cursors.Default
            End Try

            Return False
        End If
    End Function

    Private Sub frmTaskDefine_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnRefresh.Visible = False
    End Sub

    Private Sub grdTable_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdTable.CurrentCellChanged
        Static lastRow As Integer = -1
        If grdTable.CurrentRowIndex <> lastRow Then

            iIndex = grdTable.CurrentRowIndex

            '获取模版ID,任务ID
            tmpWorkflowID = grdTable.Item(iIndex, 0)
            tmpTaskID = grdTable.Item(iIndex, 1)

        End If
        lastRow = grdTable.CurrentRowIndex
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cbServiceType.Text <> "" Then
            iIndex = grdTable.CurrentRowIndex

            '获取模版ID,任务ID
            tmpWorkflowID = grdTable.Item(iIndex, 0)
            tmpTaskID = grdTable.Item(iIndex, 1)


            frmTaskRoleDefine = New frmTaskRoleDefine(tmpWorkflowID, tmpTaskID, dsResult)
            frmTaskRoleDefine.ShowDialog()
        End If
    End Sub

    '判断Form是否已被创建
    '
    Private Function hasCreated(ByVal frmType As Type) As Boolean
        Try
            Dim i As Integer
            Dim b As Boolean = False
            For i = 0 To Me.MdiChildren.Length - 1
                If Me.MdiChildren(i).GetType Is frmType Then
                    b = True
                    Exit For
                End If
            Next
            Return b
        Catch ex As Exception
            Throw ex
        End Try
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If cbServiceType.Text <> "" Then
            iIndex = grdTable.CurrentRowIndex

            '获取模版ID,任务ID
            tmpWorkflowID = grdTable.Item(iIndex, 0)
            tmpTaskID = grdTable.Item(iIndex, 1)


            frmTaskTransferDefine = New frmTaskTransferDefine(tmpWorkflowID, tmpTaskID, dsResult)
            frmTaskTransferDefine.ShowDialog()
        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If cbServiceType.Text <> "" Then

            iIndex = grdTable.CurrentRowIndex

            '获取模版ID,任务ID
            tmpWorkflowID = grdTable.Item(iIndex, 0)
            tmpTaskID = grdTable.Item(iIndex, 1)


            frmTimingTaskDefine = New frmTimingTaskDefine(tmpWorkflowID, tmpTaskID, dsResult)
            frmTimingTaskDefine.ShowDialog()
        End If
    End Sub


    '业务品种选择下拉列表变化事件
    Private Sub cbServiceType_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbServiceType.SelectedValueChanged
        Try
            Dim strSql As String
            Dim i As Integer
            Dim tmpWorkflowID As String

            '获取所选业务品种
            tmpServiceType = cbServiceType.Text

            Me.Cursor = Cursors.WaitCursor


            '获取该业务品种的所有任务
            strSql = "select distinct workflow_id from workflow where service_type=" & "'" & tmpServiceType & "'"
            '     获取构成该业务品种的模版ID
            Dim dsWorkflowID As DataSet = gWs.GetCommonQueryInfo(strSql)

            Dim dsTask As New DataSet()

            '     获取该业务品种的所有任务列表
            For i = 0 To dsWorkflowID.Tables(0).Rows.Count - 1
                tmpWorkflowID = dsWorkflowID.Tables(0).Rows(i).Item("workflow_id")
                strSql = "{workflow_id=" & "'" & tmpWorkflowID & "'" & "}"
                dsTask.Merge(gWs.GetWfTaskTemplateInfo(strSql))
            Next

            '将任务记录集传递给其他工作流定义窗体
            dsResult = dsTask

            '填充任务列表
            grdTable.SetDataBinding(dsTask, "task_template")

            '设置网格不能新增记录
            setDgAttribute(Me.grdTable, Me)

        Catch ex As System.Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try


    End Sub

  
End Class
