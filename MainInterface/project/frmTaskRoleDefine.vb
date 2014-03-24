'工作流任务角色定义窗体
'继承工作流定义窗体
Public Class frmTaskRoleDefine
    Inherits MainInterface.frmBaseWfDefine

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub


    Public Sub New(ByVal workflowID As String, ByVal taskID As String, ByVal taskData As DataSet)
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        strWorkflowID = workflowID
        strTaskID = taskID
        dsTask = taskData

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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csWorkflowID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csTaskID As DataGridComboBoxColumn
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents csRoleID As MainInterface.DataGridComboBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmTaskRoleDefine))
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.csWorkflowID = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTaskID = New MainInterface.DataGridComboBoxColumn()
        Me.csRoleID = New MainInterface.DataGridComboBoxColumn()
        Me.btnAdd = New System.Windows.Forms.Button()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.grdTable.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.Location = New System.Drawing.Point(53, 304)
        Me.btnRefresh.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.Location = New System.Drawing.Point(213, 304)
        Me.btnDelete.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(373, 304)
        Me.btnExit.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.Location = New System.Drawing.Point(293, 304)
        Me.btnUpdate.Visible = True
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csWorkflowID, Me.csTaskID, Me.csRoleID})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "task_role_template"
        '
        'csWorkflowID
        '
        Me.csWorkflowID.Format = ""
        Me.csWorkflowID.FormatInfo = Nothing
        Me.csWorkflowID.HeaderText = "模版ID"
        Me.csWorkflowID.MappingName = "workflow_id"
        Me.csWorkflowID.ReadOnly = True
        Me.csWorkflowID.Width = 75
        '
        'csTaskID
        '
        Me.csTaskID.Format = ""
        Me.csTaskID.FormatInfo = Nothing
        Me.csTaskID.HeaderText = "任务ID"
        Me.csTaskID.MappingName = "task_ID"
        Me.csTaskID.ReadOnly = True
        Me.csTaskID.Width = 200
        '
        'csRoleID
        '
        Me.csRoleID.Format = ""
        Me.csRoleID.FormatInfo = Nothing
        Me.csRoleID.HeaderText = "参与角色"
        Me.csRoleID.MappingName = "role_id"
        Me.csRoleID.Width = 120
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAdd.Image = CType(resources.GetObject("btnAdd.Image"), System.Drawing.Bitmap)
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.ImageIndex = 4
        Me.btnAdd.ImageList = Me.ImageList1
        Me.btnAdd.Location = New System.Drawing.Point(133, 304)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(77, 23)
        Me.btnAdd.TabIndex = 10
        Me.btnAdd.Text = "新 增(&A)"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmTaskRoleDefine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdTable, Me.btnAdd})
        Me.Name = "frmTaskRoleDefine"
        Me.Text = "角色定义"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private strWorkflowID, strTaskID As String
    Private dsResult, dsTask As DataSet

    '重写父类的刷新方法,实现子类的刷新功能
    Public Overloads Overrides Sub Refresh()
        Try
            Me.Cursor = Cursors.WaitCursor

            '获取指定工作流ID和任务ID的任务角色定义数据集
            Dim strSql As String = "{workflow_id=" & "'" & strWorkflowID & "'" & " and task_id=" & "'" & strTaskID & "'" & "}"
            dsResult = gWs.GetWfTaskRoleTemplateInfo(strSql)
            grdTable.SetDataBinding(dsResult, "task_role_template")
        Catch ex As System.Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '重写父类的保存方法,实现子类的保存功能
    Public Overrides Function Update() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim result As String = gWs.UpdateWfTaskRoleTemplate(dsResult.GetChanges())

            If result = "1" Then
                '接受所有更改
                dsResult.AcceptChanges()

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
    End Function

    '窗体的load事件
    Private Sub frmTaskRoleDefine_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '获取所有的角色
        Dim dsRole As DataSet = gWs.GetRole("%")

        '将角色列表绑定到角色下拉列表选择框
        csRoleID.ColumnComboBox.DataSource = dsRole.Tables("TRole").DefaultView
        csRoleID.ColumnComboBox.DisplayMember = "role_name"
        csRoleID.ColumnComboBox.ValueMember = "role_id"

        ''获取所有的任务列表
        'Dim strSql As String = "select distinct task_id,task_name from task_template"
        'Dim dsTask As DataSet = gWs.GetCommonQueryInfo(strSql)

        '将任务列表绑定到任务下拉列表选择框
        csTaskID.ColumnComboBox.DataSource = dsTask.Tables(0).DefaultView
        csTaskID.ColumnComboBox.DisplayMember = "task_name"
        csTaskID.ColumnComboBox.ValueMember = "task_id"



        '设置网格不能新增记录
        setDgAttribute(Me.grdTable, Me)

    End Sub

    '添加按钮事件
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        '新增记录
        Dim newRow As DataRow = dsResult.Tables(0).NewRow

        '自动填写工作流ID及任务ID
        With newRow
            .Item("workflow_id") = strWorkflowID
            .Item("task_id") = strTaskID
        End With
        dsResult.Tables(0).Rows.Add(newRow)

    End Sub


   

End Class
