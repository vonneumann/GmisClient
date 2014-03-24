Public Class frmFindProjectInfo
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgGrid As System.Windows.Forms.DataGrid
    Friend WithEvents btnShowProjectInfo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents cmbProjectStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbProjectManager As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPhase As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txt_project_code As System.Windows.Forms.TextBox
    Friend WithEvents txt_corp_name As System.Windows.Forms.TextBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFindProjectInfo))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txt_corp_name = New System.Windows.Forms.TextBox
        Me.txt_project_code = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbPhase = New System.Windows.Forms.ComboBox
        Me.cmbProjectManager = New System.Windows.Forms.ComboBox
        Me.cmbProjectStatus = New System.Windows.Forms.ComboBox
        Me.btnSearch = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgGrid = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnShowProjectInfo = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txt_corp_name)
        Me.GroupBox1.Controls.Add(Me.txt_project_code)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbPhase)
        Me.GroupBox1.Controls.Add(Me.cmbProjectManager)
        Me.GroupBox1.Controls.Add(Me.cmbProjectStatus)
        Me.GroupBox1.Controls.Add(Me.btnSearch)
        Me.GroupBox1.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "查询条件"
        '
        'txt_corp_name
        '
        Me.txt_corp_name.Location = New System.Drawing.Point(264, 21)
        Me.txt_corp_name.Name = "txt_corp_name"
        Me.txt_corp_name.Size = New System.Drawing.Size(120, 21)
        Me.txt_corp_name.TabIndex = 1
        Me.txt_corp_name.Text = ""
        '
        'txt_project_code
        '
        Me.txt_project_code.Location = New System.Drawing.Point(72, 21)
        Me.txt_project_code.Name = "txt_project_code"
        Me.txt_project_code.Size = New System.Drawing.Size(104, 21)
        Me.txt_project_code.TabIndex = 0
        Me.txt_project_code.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(400, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "项目经理"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(200, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "项目状态"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(200, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "企业名称"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 14)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = " 阶 段"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "项目编码"
        '
        'cmbPhase
        '
        Me.cmbPhase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPhase.Location = New System.Drawing.Point(72, 45)
        Me.cmbPhase.Name = "cmbPhase"
        Me.cmbPhase.Size = New System.Drawing.Size(104, 20)
        Me.cmbPhase.TabIndex = 3
        '
        'cmbProjectManager
        '
        Me.cmbProjectManager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProjectManager.Location = New System.Drawing.Point(464, 21)
        Me.cmbProjectManager.Name = "cmbProjectManager"
        Me.cmbProjectManager.Size = New System.Drawing.Size(104, 20)
        Me.cmbProjectManager.Sorted = True
        Me.cmbProjectManager.TabIndex = 2
        '
        'cmbProjectStatus
        '
        Me.cmbProjectStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProjectStatus.Location = New System.Drawing.Point(264, 45)
        Me.cmbProjectStatus.Name = "cmbProjectStatus"
        Me.cmbProjectStatus.Size = New System.Drawing.Size(120, 20)
        Me.cmbProjectStatus.TabIndex = 4
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.ImageIndex = 1
        Me.btnSearch.ImageList = Me.ImageList1
        Me.btnSearch.Location = New System.Drawing.Point(488, 48)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "查 询(&S)"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgGrid)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(584, 344)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'dgGrid
        '
        Me.dgGrid.CaptionVisible = False
        Me.dgGrid.DataMember = ""
        Me.dgGrid.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgGrid.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgGrid.Location = New System.Drawing.Point(3, 18)
        Me.dgGrid.Name = "dgGrid"
        Me.dgGrid.ReadOnly = True
        Me.dgGrid.Size = New System.Drawing.Size(578, 323)
        Me.dgGrid.TabIndex = 0
        Me.dgGrid.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgGrid
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "ViewProject"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn1.MappingName = "ProjectCode"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 72
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "企业名称"
        Me.DataGridTextBoxColumn2.MappingName = "EnterPriseName"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "业务品种"
        Me.DataGridTextBoxColumn3.MappingName = "ServiceType"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 110
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "责任A角"
        Me.DataGridTextBoxColumn4.MappingName = "manager_A"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "责任B角"
        Me.DataGridTextBoxColumn5.MappingName = "manager_B"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "阶段"
        Me.DataGridTextBoxColumn6.MappingName = "phase"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 50
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "状态"
        Me.DataGridTextBoxColumn7.MappingName = "status"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "申请日期"
        Me.DataGridTextBoxColumn8.MappingName = "ApplyDate"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 78
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "申请业务品种"
        Me.DataGridTextBoxColumn12.MappingName = "ApplyServiceType"
        Me.DataGridTextBoxColumn12.NullText = ""
        Me.DataGridTextBoxColumn12.Width = 110
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn9.Format = "c"
        Me.DataGridTextBoxColumn9.FormatInfo = CType(resources.GetObject("DataGridTextBoxColumn9.FormatInfo"), System.IFormatProvider)
        Me.DataGridTextBoxColumn9.HeaderText = "申请金额(万)"
        Me.DataGridTextBoxColumn9.MappingName = "ApplySum"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 84
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn10.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "承保日期"
        Me.DataGridTextBoxColumn10.MappingName = "StartTime"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 78
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn11.Format = "c"
        Me.DataGridTextBoxColumn11.FormatInfo = CType(resources.GetObject("DataGridTextBoxColumn11.FormatInfo"), System.IFormatProvider)
        Me.DataGridTextBoxColumn11.HeaderText = "在保金额(元)"
        Me.DataGridTextBoxColumn11.MappingName = "guaranting_sum"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 94
        '
        'btnShowProjectInfo
        '
        Me.btnShowProjectInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowProjectInfo.Enabled = False
        Me.btnShowProjectInfo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShowProjectInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnShowProjectInfo.ImageIndex = 0
        Me.btnShowProjectInfo.ImageList = Me.ImageList1
        Me.btnShowProjectInfo.Location = New System.Drawing.Point(384, 440)
        Me.btnShowProjectInfo.Name = "btnShowProjectInfo"
        Me.btnShowProjectInfo.Size = New System.Drawing.Size(120, 23)
        Me.btnShowProjectInfo.TabIndex = 2
        Me.btnShowProjectInfo.Text = "项目详细信息(&L)"
        Me.btnShowProjectInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 2
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(512, 440)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "处理A角"
        Me.DataGridTextBoxColumn13.MappingName = "nowManagerA"
        Me.DataGridTextBoxColumn13.Width = 75
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "处理B角"
        Me.DataGridTextBoxColumn14.MappingName = "nowManagerB"
        Me.DataGridTextBoxColumn14.Width = 75
        '
        'frmFindProjectInfo
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(600, 471)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnShowProjectInfo)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmFindProjectInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "查询项目信息"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private strSearchProjectCode, strSearchEnterpriseName As String '用于传入显示项目信息窗体的project code及corporation name

    Private Sub frmFindProjectInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Me.InitCombo()
            AddHandler dgGrid.DoubleClick, AddressOf btnShowProjectInfo_Click
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    '初始化查询条件所有下拉列表
    Private Sub InitCombo()
        Dim ds As DataSet
        Dim i As Integer
        Me.cmbProjectManager.Items.Add("")
        ds = gWs.GetStaff("{team_name is not null}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Me.cmbProjectManager.Items.Add(ds.Tables(0).Rows(i).Item("staff_name"))
            Next
        End If
        '取得所有的项目阶段
        Me.cmbPhase.Items.Add("")
        ds = gWs.GetPhase("%")
        If Not ds.Tables(0).Rows.Count = 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Me.cmbPhase.Items.Add(ds.Tables(0).Rows(i).Item("phase_name"))
            Next
        End If
        '取得所有的项目状态
        Me.cmbProjectStatus.Items.Add("")
        ds = gWs.GetWfTaskStatus()
        If Not ds.Tables(0).Rows.Count = 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                Me.cmbProjectStatus.Items.Add(ds.Tables(0).Rows(i).Item(0))
            Next
        End If
    End Sub
    '点击DataGrid，设置strSearchProjectCode和strSearchEnterpriseName
    Private Sub dgGrid_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgGrid.CurrentCellChanged
        Me.dgGrid.Select(Me.dgGrid.CurrentCell.RowNumber)
        Me.strSearchProjectCode = Me.dgGrid.Item(Me.dgGrid.CurrentRowIndex, 0)
        Me.strSearchEnterpriseName = Me.dgGrid.Item(Me.dgGrid.CurrentRowIndex, 1)
    End Sub
    'project_code文本框有输入，则设置其它控件的状态

    Private Sub txt_project_code_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txt_project_code.TextChanged
        Dim bIsAllInput As Boolean = IIf(Me.txt_project_code.Text.Trim() = "", True, False)
        Me.txt_corp_name.Enabled = bIsAllInput
        Me.cmbPhase.Enabled = bIsAllInput
        Me.cmbProjectManager.Enabled = bIsAllInput
        Me.cmbProjectStatus.Enabled = bIsAllInput
    End Sub
    '查询按钮
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim ds As DataSet
            '注：如果project_code不为空串，其它控件显示的数据虽然传过去，但并未被存储过程采用
            ds = gWs.GetQueryProjectInfo(Me.txt_project_code.Text.Trim(), Me.txt_corp_name.Text.Trim(), Me.cmbProjectManager.Text.Trim(), Me.cmbPhase.Text.Trim(), Me.cmbProjectStatus.Text.Trim())
            If Not ds.Tables(0).Rows.Count = 0 Then
                Me.btnShowProjectInfo.Enabled = True
                Me.dgGrid.DataSource = ds.Tables(0).DefaultView
                Me.dgGrid.CurrentRowIndex = 0
                Me.strSearchProjectCode = Me.dgGrid.Item(0, 0)
                Me.strSearchEnterpriseName = Me.dgGrid.Item(0, 1)
            Else
                Me.btnShowProjectInfo.Enabled = False
                'MessageBox.Show("没有符合条件的查询信息。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                SWDialogBox.MessageBox.Show("$X050")
                Me.dgGrid.DataSource = ds.Tables(0).DefaultView
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '查看项目信息
    Private Sub btnShowProjectInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowProjectInfo.Click
        If Me.strSearchProjectCode = "" Or Me.strSearchEnterpriseName = "" Then
            'MessageBox.Show("请确认是否选择了数据行进行操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1007", "数据行")
            Return
        End If
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim frm As New frmShowProjectInfo(Me.strSearchProjectCode, Me.strSearchEnterpriseName, Me.cmbPhase.Text.Trim())
            frm.AllowTransparency = False
            frm.ShowDialog()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '退出按钮
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
