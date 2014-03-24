'工作流基类窗体，为子类提供
'共用的项目列表、项目查询功能以及退出功能
'项目筛选按钮、处理按钮
Public Class frmBaseWorkflow
    Inherits System.Windows.Forms.Form

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
    Public WithEvents project_group As System.Windows.Forms.GroupBox
    Public WithEvents dgQueryResult As System.Windows.Forms.DataGrid
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents ProjectCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents EnterpriseName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Phase As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Status As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Public WithEvents GroupQuery As System.Windows.Forms.GroupBox
    Friend WithEvents LabelQuery As System.Windows.Forms.Label
    Friend WithEvents LabelCustomer As System.Windows.Forms.Label
    Public WithEvents ImageListBasic As System.Windows.Forms.ImageList
    Public WithEvents btnEntery As System.Windows.Forms.Button
    Public WithEvents txtCorporation As System.Windows.Forms.TextBox
    Public WithEvents btnQueryProject As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBaseWorkflow))
        Me.project_group = New System.Windows.Forms.GroupBox
        Me.dgQueryResult = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.ProjectCode = New System.Windows.Forms.DataGridTextBoxColumn
        Me.EnterpriseName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Phase = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Status = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnExit = New System.Windows.Forms.Button
        Me.ImageListBasic = New System.Windows.Forms.ImageList(Me.components)
        Me.btnQuery = New System.Windows.Forms.Button
        Me.btnEntery = New System.Windows.Forms.Button
        Me.GroupQuery = New System.Windows.Forms.GroupBox
        Me.txtCorporation = New System.Windows.Forms.TextBox
        Me.LabelCustomer = New System.Windows.Forms.Label
        Me.btnQueryProject = New System.Windows.Forms.Button
        Me.txtProjectCode = New System.Windows.Forms.TextBox
        Me.LabelQuery = New System.Windows.Forms.Label
        Me.project_group.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupQuery.SuspendLayout()
        Me.SuspendLayout()
        '
        'project_group
        '
        Me.project_group.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.project_group.Controls.Add(Me.dgQueryResult)
        Me.project_group.Location = New System.Drawing.Point(8, 48)
        Me.project_group.Name = "project_group"
        Me.project_group.Size = New System.Drawing.Size(560, 352)
        Me.project_group.TabIndex = 4
        Me.project_group.TabStop = False
        '
        'dgQueryResult
        '
        Me.dgQueryResult.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgQueryResult.CaptionVisible = False
        Me.dgQueryResult.DataMember = ""
        Me.dgQueryResult.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgQueryResult.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.dgQueryResult.Location = New System.Drawing.Point(1, 8)
        Me.dgQueryResult.Name = "dgQueryResult"
        Me.dgQueryResult.ReadOnly = True
        Me.dgQueryResult.Size = New System.Drawing.Size(558, 342)
        Me.dgQueryResult.TabIndex = 0
        Me.dgQueryResult.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgQueryResult
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.ProjectCode, Me.EnterpriseName, Me.Phase, Me.Status})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'ProjectCode
        '
        Me.ProjectCode.Format = ""
        Me.ProjectCode.FormatInfo = Nothing
        Me.ProjectCode.HeaderText = "项目编码"
        Me.ProjectCode.MappingName = "ProjectCode"
        Me.ProjectCode.Width = 75
        '
        'EnterpriseName
        '
        Me.EnterpriseName.Format = ""
        Me.EnterpriseName.FormatInfo = Nothing
        Me.EnterpriseName.HeaderText = "企业名称"
        Me.EnterpriseName.MappingName = "EnterpriseName"
        Me.EnterpriseName.Width = 200
        '
        'Phase
        '
        Me.Phase.Format = ""
        Me.Phase.FormatInfo = Nothing
        Me.Phase.HeaderText = "阶段"
        Me.Phase.MappingName = "Phase"
        Me.Phase.Width = 75
        '
        'Status
        '
        Me.Status.Format = ""
        Me.Status.FormatInfo = Nothing
        Me.Status.HeaderText = "状态"
        Me.Status.MappingName = "Status"
        Me.Status.Width = 75
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 4
        Me.btnExit.ImageList = Me.ImageListBasic
        Me.btnExit.Location = New System.Drawing.Point(335, 408)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuery.ImageIndex = 1
        Me.btnQuery.ImageList = Me.ImageListBasic
        Me.btnQuery.Location = New System.Drawing.Point(161, 408)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(77, 23)
        Me.btnQuery.TabIndex = 8
        Me.btnQuery.Text = "查 看(&L)"
        Me.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnEntery
        '
        Me.btnEntery.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnEntery.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEntery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEntery.ImageIndex = 7
        Me.btnEntery.ImageList = Me.ImageListBasic
        Me.btnEntery.Location = New System.Drawing.Point(248, 408)
        Me.btnEntery.Name = "btnEntery"
        Me.btnEntery.Size = New System.Drawing.Size(77, 23)
        Me.btnEntery.TabIndex = 7
        Me.btnEntery.Text = "处 理(&T)"
        Me.btnEntery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupQuery
        '
        Me.GroupQuery.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupQuery.Controls.Add(Me.txtCorporation)
        Me.GroupQuery.Controls.Add(Me.LabelCustomer)
        Me.GroupQuery.Controls.Add(Me.btnQueryProject)
        Me.GroupQuery.Controls.Add(Me.txtProjectCode)
        Me.GroupQuery.Controls.Add(Me.LabelQuery)
        Me.GroupQuery.Location = New System.Drawing.Point(8, 0)
        Me.GroupQuery.Name = "GroupQuery"
        Me.GroupQuery.Size = New System.Drawing.Size(560, 45)
        Me.GroupQuery.TabIndex = 12
        Me.GroupQuery.TabStop = False
        '
        'txtCorporation
        '
        Me.txtCorporation.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorporation.Location = New System.Drawing.Point(256, 16)
        Me.txtCorporation.Name = "txtCorporation"
        Me.txtCorporation.Size = New System.Drawing.Size(208, 21)
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
        Me.btnQueryProject.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQueryProject.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnQueryProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQueryProject.ImageIndex = 26
        Me.btnQueryProject.ImageList = Me.ImageListBasic
        Me.btnQueryProject.Location = New System.Drawing.Point(472, 15)
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
        'frmBaseWorkflow
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(576, 437)
        Me.Controls.Add(Me.project_group)
        Me.Controls.Add(Me.GroupQuery)
        Me.Controls.Add(Me.btnQuery)
        Me.Controls.Add(Me.btnEntery)
        Me.Controls.Add(Me.btnExit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmBaseWorkflow"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "请修改标题"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.project_group.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupQuery.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmBaseWorkflow_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub


    Private Sub btnQueryProject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupQuery.Enter

    End Sub

    
End Class
