Public Class FClaimTool
    Inherits frmBaseWorkflow

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
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupQuery.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.project_group.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupQuery
        '
        Me.GroupQuery.Size = New System.Drawing.Size(576, 45)
        Me.GroupQuery.Visible = True
        '
        'btnEntery
        '
        Me.btnEntery.Location = New System.Drawing.Point(256, 408)
        Me.btnEntery.Visible = True
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        '
        'dgQueryResult
        '
        Me.dgQueryResult.AccessibleName = "DataGrid"
        Me.dgQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgQueryResult.Size = New System.Drawing.Size(574, 342)
        Me.dgQueryResult.Visible = True
        '
        'project_group
        '
        Me.project_group.Size = New System.Drawing.Size(576, 352)
        Me.project_group.Visible = True
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(169, 408)
        Me.btnQuery.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(343, 408)
        Me.btnExit.Visible = True
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "业务品种"
        Me.DataGridTextBoxColumn5.MappingName = "ServiceType"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "运作方式"
        Me.DataGridTextBoxColumn6.MappingName = "workflow"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 120
        '
        'FClaimTool
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(592, 437)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.project_group, Me.GroupQuery, Me.btnQuery, Me.btnEntery, Me.btnExit})
        Me.Name = "FClaimTool"
        Me.Text = "项目索赔"
        Me.GroupQuery.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.project_group.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsTempProject As DataSet
    Private tmpProjectID As String
    Private iIndex As Integer


    Private Sub FClaimTool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '获取项目列表
        'Dim i As Integer
        Dim strSql As String

        '获取项目列表
        strSql = " SELECT a.ProjectCode, a.EnterpriseName, a.phase, a.status,c.ServiceType,c.workflow" & _
                 " FROM dbo.ViewProjectInfo_Guaranting AS a,dbo.ViewProjectInfo_SignLoan AS b,dbo.ViewProjectInfo_Review AS c" & _
                 " WHERE (a.ProjectCode=b.ProjectCode) AND (a.certificate_date IS NULL)" & _
                 " AND (NOT b.StartTime IS NULL) AND a.ProjectCode=c.ProjectCode AND c.ServiceType LIKE '%保函%'"     'and manager_A='" & UserName & "'"
        dsTempProject = gWs.GetCommonQueryInfo(strSql)
        dgQueryResult.DataSource = dsTempProject.Tables(0).DefaultView

        If dsTempProject.Tables(0).Rows.Count = 0 Then
            MsgBox("无项目列表!", MsgBoxStyle.Information, "项目索赔")
            btnEntery.Enabled = False
            btnQuery.Enabled = False
            Exit Sub
        End If

        MyBase.LabelCustomer.Left = MyBase.txtProjectCode.Left + MyBase.txtProjectCode.Width + 20
        MyBase.txtCorporation.Left = MyBase.LabelCustomer.Left + MyBase.LabelCustomer.Width - 10
        MyBase.btnQueryProject.Left = MyBase.txtCorporation.Left + MyBase.txtCorporation.Width + 10
        iIndex = dgQueryResult.CurrentRowIndex
        '获取项目ID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)
    End Sub

    Private Sub dgQueryResult_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgQueryResult.CurrentCellChanged
        'Static lastRow As Integer = -1
        If dgQueryResult.CurrentRowIndex < 0 Then
            Return
        End If
        iIndex = dgQueryResult.CurrentRowIndex
        '获取项目ID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)
        'lastRow = dgQueryResult.CurrentRowIndex
    End Sub

    Private Sub btnQueryProject_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQueryProject.Click
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

        '重新获取当前项目编码及其任务列表
        dgQueryResult_CurrentCellChanged(sender, e)
    End Sub

    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        Dim response As MsgBoxResult
        Dim strErr As String

        iIndex = dgQueryResult.CurrentRowIndex
        If iIndex < 0 Then
            Return
        End If

        '获取列表当前行的项目ID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)

        response = MsgBox("是否确定要启动保函项目索赔?", MsgBoxStyle.YesNo, "项目索赔")

        '调用cancelProcess方法取消所选项目的工作流
        If response = MsgBoxResult.Yes Then

            strErr = gWs.CreateProcess("索赔", Trim(tmpProjectID), UserName, String.Empty)
            If strErr = "1" Then
                MsgBox("启动保函项目索赔成功!", MsgBoxStyle.Information, "项目索赔")
                dsTempProject.Tables(0).Rows(iIndex).Delete()
                dsTempProject.AcceptChanges()
            Else
                MsgBox("启动保函项目索赔失败:" & strErr, MsgBoxStyle.Critical, "项目索赔")
            End If
        Else
            Exit Sub
        End If
    End Sub
End Class
