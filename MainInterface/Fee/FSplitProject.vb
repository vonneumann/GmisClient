Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FSplitProject
    Inherits FBaseData

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
    Friend tsServiceType As System.Windows.Forms.DataGridTableStyle
    Friend csWorkflowID As System.Windows.Forms.DataGridTextBoxColumn
    Friend csServiceType As System.Windows.Forms.DataGridTextBoxColumn
    Friend csSubSystem As System.Windows.Forms.DataGridTextBoxColumn

    Friend WithEvents btnSplit As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FSplitProject))
        Me.tsServiceType = New System.Windows.Forms.DataGridTableStyle
        Me.csWorkflowID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csServiceType = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csSubSystem = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnSplit = New System.Windows.Forms.Button
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(184, 304)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(424, 304)
        Me.btnExit.Name = "btnExit"
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(8, 304)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Visible = False
        '
        'grdTable
        '
        Me.grdTable.Name = "grdTable"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(96, 304)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Visible = False
        '
        'tsServiceType
        '
        Me.tsServiceType.DataGrid = Me.grdTable
        Me.tsServiceType.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csWorkflowID, Me.csServiceType, Me.csSubSystem})
        Me.tsServiceType.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsServiceType.MappingName = "Table"
        '
        'csWorkflowID
        '
        Me.csWorkflowID.Format = ""
        Me.csWorkflowID.FormatInfo = Nothing
        Me.csWorkflowID.MappingName = "workflow_id"
        Me.csWorkflowID.Width = 0
        '
        'csServiceType
        '
        Me.csServiceType.Format = ""
        Me.csServiceType.FormatInfo = Nothing
        Me.csServiceType.HeaderText = "请选择拆分项目的业务品种"
        Me.csServiceType.MappingName = "service_type_parent"
        Me.csServiceType.Width = 300

        'csSubSystem
        '
        Me.csSubSystem.Format = ""
        Me.csSubSystem.FormatInfo = Nothing
        Me.csSubSystem.HeaderText = ""
        Me.csSubSystem.MappingName = "sub_system"
        Me.csSubSystem.Width = 0
        '
        'btnSplit
        '
        Me.btnSplit.Location = New System.Drawing.Point(328, 304)
        Me.btnSplit.Name = "btnSplit"
        Me.btnSplit.TabIndex = 10
        Me.btnSplit.Text = "拆分(&P)"
        '
        'FSplitProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.Add(Me.btnSplit)
        Me.Name = "FSplitProject"
        Me.Text = "项目拆分"
        Me.Controls.SetChildIndex(Me.btnSplit, 0)
        Me.Controls.SetChildIndex(Me.grdTable, 0)
        Me.Controls.SetChildIndex(Me.btnUpdate, 0)
        Me.Controls.SetChildIndex(Me.btnRefresh, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overloads Overrides Sub Refresh()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dsResult As DataSet
            Dim strSql As String
            'strSql = "SELECT workflow_id, service_type_parent,sub_system FROM workflow WHERE (IsDisplay = 1) ORDER BY service_type_parent_order"
            strSql = "SELECT workflow_id, service_type_parent FROM workflow WHERE (IsDisplay = 1) ORDER BY service_type_parent_order"
            dsResult = gWs.GetCommonQueryInfo(strSql)

            'AddHandler dsResult.Tables("TBranch").RowChanged, AddressOf Table_Changed

            grdTable.SetDataBinding(dsResult, "Table")
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Overrides Function Update() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dsCommit As DataSet = CType(grdTable.DataSource, DataSet)

            If Not dsCommit.HasChanges() Then
                Return False
            End If

            Dim result As String = gWs.UpdateBranch(dsCommit.GetChanges())

            If result = "1" Then
                '接受所有更改
                dsCommit.AcceptChanges()

                Return True
            Else
                '显示服务器的返回错误信息
                SWDialogBox.MessageBox.Show("*999", Me.Name + ".Update", result, "")
            End If
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        Return False
    End Function

    Private Sub FBranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim strSql As String = "SELECT workflow_id, service_type_parent ,sub_system FROM workflow WHERE (IsDisplay = 1) ORDER BY service_type_parent_order"

        Dim strSql As String = "SELECT workflow_id, service_type_parent FROM workflow WHERE (IsDisplay = 1) ORDER BY service_type_parent_order"
        Dim dsResult As DataSet = gWs.GetCommonQueryInfo(strSql)

        grdTable.TableStyles.Add(Me.tsServiceType)
    End Sub

    Private Sub Table_Changed(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        'If e.Action = DataRowAction.Add Then
        '    Dim rv As DataRowView = CType(Me.BindingContext(grdTable.DataSource, grdTable.DataMember).Current, DataRowView)

        '    rv("create_person") = UserName
        '    rv("create_date") = DateTime.Today
        'End If
    End Sub

    Public Shared _workflowID As String = ""
    Public Shared _servcieType As String = ""
    'Public Shared _subSystem As String = ""
    Private Sub btnSplit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSplit.Click

        If grdTable.CurrentRowIndex <> -1 Then
            _workflowID = grdTable.Item(grdTable.CurrentRowIndex, 0)
            _servcieType = grdTable.Item(grdTable.CurrentRowIndex, 1)
            '_subSystem = grdTable.Item(grdTable.CurrentRowIndex, 2)
            'm_applyCallback(dgGrid.Item(dgGrid.CurrentRowIndex, 0), dgGrid.Item(dgGrid.CurrentRowIndex, 1))
        Else
            _workflowID = ""
            _servcieType = ""
            '_subSystem = ""
        End If
        Me.Close()

    End Sub
End Class
