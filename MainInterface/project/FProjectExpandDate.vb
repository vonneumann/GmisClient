
Public Class FProjectExpandDate
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
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExpandAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblSum As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Friend WithEvents txtExpandProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtExpandTerm As System.Windows.Forms.TextBox
    Friend WithEvents txtExpandApplyReason As System.Windows.Forms.TextBox
    Friend WithEvents txtExpCorporationName As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FProjectExpandDate))
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtExpCorporationName = New System.Windows.Forms.TextBox
        Me.txtExpandApplyReason = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtExpandTerm = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtExpandProjectCode = New System.Windows.Forms.TextBox
        Me.txtExpandAmount = New System.Windows.Forms.TextBox
        Me.lblSum = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.project_group.SuspendLayout()
        Me.GroupQuery.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'project_group
        '
        Me.project_group.Name = "project_group"
        Me.project_group.Size = New System.Drawing.Size(600, 192)
        '
        'GroupQuery
        '
        Me.GroupQuery.Name = "GroupQuery"
        Me.GroupQuery.Size = New System.Drawing.Size(600, 54)
        '
        'btnEntery
        '
        Me.btnEntery.Location = New System.Drawing.Point(268, 416)
        Me.btnEntery.Name = "btnEntery"
        '
        'txtCorporation
        '
        Me.txtCorporation.Name = "txtCorporation"
        Me.txtCorporation.Size = New System.Drawing.Size(248, 21)
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn5})
        '
        'dgQueryResult
        '
        Me.dgQueryResult.AccessibleName = "DataGrid"
        Me.dgQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgQueryResult.Name = "dgQueryResult"
        Me.dgQueryResult.Size = New System.Drawing.Size(598, 182)
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(355, 417)
        Me.btnExit.Name = "btnExit"
        '
        'btnQueryProject
        '
        Me.btnQueryProject.Location = New System.Drawing.Point(512, 16)
        Me.btnQueryProject.Name = "btnQueryProject"
        '
        'btnQuery
        '
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Image)
        Me.btnQuery.ImageIndex = -1
        Me.btnQuery.ImageList = Nothing
        Me.btnQuery.Location = New System.Drawing.Point(180, 416)
        Me.btnQuery.Name = "btnQuery"
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "业务品种"
        Me.DataGridTextBoxColumn5.MappingName = "ServiceType"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 200
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.txtExpCorporationName)
        Me.GroupBox1.Controls.Add(Me.txtExpandApplyReason)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtExpandTerm)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtExpandProjectCode)
        Me.GroupBox1.Controls.Add(Me.txtExpandAmount)
        Me.GroupBox1.Controls.Add(Me.lblSum)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 240)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 168)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'txtExpCorporationName
        '
        Me.txtExpCorporationName.Enabled = False
        Me.txtExpCorporationName.Location = New System.Drawing.Point(104, 24)
        Me.txtExpCorporationName.Name = "txtExpCorporationName"
        Me.txtExpCorporationName.Size = New System.Drawing.Size(240, 21)
        Me.txtExpCorporationName.TabIndex = 49
        Me.txtExpCorporationName.Text = ""
        '
        'txtExpandApplyReason
        '
        Me.txtExpandApplyReason.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpandApplyReason.Location = New System.Drawing.Point(104, 96)
        Me.txtExpandApplyReason.Multiline = True
        Me.txtExpandApplyReason.Name = "txtExpandApplyReason"
        Me.txtExpandApplyReason.Size = New System.Drawing.Size(472, 64)
        Me.txtExpandApplyReason.TabIndex = 48
        Me.txtExpandApplyReason.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(376, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "展期期限(月)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExpandTerm
        '
        Me.txtExpandTerm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpandTerm.Location = New System.Drawing.Point(464, 56)
        Me.txtExpandTerm.Name = "txtExpandTerm"
        Me.txtExpandTerm.Size = New System.Drawing.Size(112, 21)
        Me.txtExpandTerm.TabIndex = 46
        Me.txtExpandTerm.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(400, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "项目编码"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "企业名称"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExpandProjectCode
        '
        Me.txtExpandProjectCode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpandProjectCode.Enabled = False
        Me.txtExpandProjectCode.Location = New System.Drawing.Point(464, 24)
        Me.txtExpandProjectCode.Name = "txtExpandProjectCode"
        Me.txtExpandProjectCode.Size = New System.Drawing.Size(112, 21)
        Me.txtExpandProjectCode.TabIndex = 43
        Me.txtExpandProjectCode.Text = ""
        '
        'txtExpandAmount
        '
        Me.txtExpandAmount.Location = New System.Drawing.Point(104, 56)
        Me.txtExpandAmount.Name = "txtExpandAmount"
        Me.txtExpandAmount.Size = New System.Drawing.Size(240, 21)
        Me.txtExpandAmount.TabIndex = 37
        Me.txtExpandAmount.Text = ""
        '
        'lblSum
        '
        Me.lblSum.AutoSize = True
        Me.lblSum.Location = New System.Drawing.Point(8, 60)
        Me.lblSum.Name = "lblSum"
        Me.lblSum.Size = New System.Drawing.Size(91, 17)
        Me.lblSum.TabIndex = 40
        Me.lblSum.Text = "展期金额(万元)"
        Me.lblSum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 17)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "备   注"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FProjectExpandDate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(616, 446)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FProjectExpandDate"
        Me.Text = "展期申请"
        Me.Controls.SetChildIndex(Me.btnEntery, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.btnQuery, 0)
        Me.Controls.SetChildIndex(Me.GroupQuery, 0)
        Me.Controls.SetChildIndex(Me.project_group, 0)
        Me.project_group.ResumeLayout(False)
        Me.GroupQuery.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsTempProject As DataSet
    Private tmpProjectID As String
    Private iIndex As Integer
    Public Event refreshTaskCommit()

    Private Sub FClaimTool_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '获取项目列表
        'Dim i As Integer
        Dim strSql As String

        '获取项目列表
        'strSql = " SELECT a.ProjectCode, a.EnterpriseName, a.phase, a.status,c.ServiceType,c.workflow" & _
        '         " FROM dbo.ViewProjectInfo_Guaranting AS a,dbo.ViewProjectInfo_SignLoan AS b,dbo.ViewProjectInfo_Review AS c" & _
        '         " WHERE (a.ProjectCode=b.ProjectCode) AND (a.certificate_date IS NULL)" & _
        '         " AND (NOT b.StartTime IS NULL) AND a.ProjectCode=c.ProjectCode AND manager_A='" & UserName & "'"

        '列出未放款的项目经理A为登录人且业务品种不是“保函”，“委托评审”的未终止的项目
        'strSql = " SELECT ProjectCode, EnterpriseName, phase, Status,ServiceType" & _
        '         " FROM dbo.ViewProjectInfo" & _
        '         " WHERE StartTime is null and (isliving = 1) and manager_A='" & UserName & "' and (ServiceType<>'保函' and ServiceType <>'委托评审')"

        'strSql = " SELECT ProjectCode, EnterpriseName, phase, Status,ServiceType" & _
        '         " FROM dbo.queryProjectInfo" & _
        '         " WHERE StartTime is null and (isliving = 1) and manager_A='" & UserName & "' and ServiceType <>'委托评审'"
        strSql = " SELECT ProjectCode, EnterpriseName, phase, Status,ServiceType" & _
                " FROM dbo.queryProjectInfo" & _
                " WHERE  (isliving = 1) and (manager_A='" & UserName & "'" & _
                " or (select top 1 attend_person from project_task_attendee where project_task_attendee.project_code=queryProjectInfo.ProjectCode and role_id='24')='" & UserName & "') " & _
                " and ServiceType <>'委托评审'"
        dsTempProject = gWs.GetCommonQueryInfo(strSql)
        dgQueryResult.DataSource = dsTempProject.Tables(0).DefaultView

        If dsTempProject.Tables(0).Rows.Count = 0 Then
            MsgBox("无项目列表!", MsgBoxStyle.Information, "展期申请")
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
        Me.txtExpandProjectCode.Text = tmpProjectID
        Me.txtExpCorporationName.Text = dgQueryResult.Item(iIndex, 1)

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

        Dim tmpCorporationName As String = dgQueryResult.Item(iIndex, 1)

        Me.txtExpCorporationName.Text = tmpCorporationName
        Me.txtExpandProjectCode.Text = tmpProjectID

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

    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        Dim response As MsgBoxResult
        Dim strErr As String

        iIndex = dgQueryResult.CurrentRowIndex
        If iIndex < 0 Then
            Return
        End If

        '获取列表当前行的项目ID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)

        response = MsgBox("是否确定要启动展期申请?", MsgBoxStyle.YesNo, "展期申请")

        '调用cancelProcess方法取消所选项目的工作流
        If response = MsgBoxResult.Yes Then

            '保存展期申请信息
            Dim dsProjectExpandDate As DataSet = gWs.GetProjectExpandDateInfo("{project_code='" & tmpProjectID & "'}")
            If dsProjectExpandDate.Tables(0).Rows.Count = 0 Then
                Dim dr As DataRow = dsProjectExpandDate.Tables(0).NewRow
                With dr
                    .Item("project_code") = tmpProjectID
                    .Item("exp_apply_amount") = CDbl(Me.txtExpandAmount.Text)
                    .Item("exp_apply_term") = CInt(Me.txtExpandTerm.Text)
                    .Item("exp_apply_reason") = Me.txtExpandApplyReason.Text
                End With
                dsProjectExpandDate.Tables(0).Rows.Add(dr)

                gWs.UpdateProjectExpandDate(dsProjectExpandDate)
            Else
                MsgBox("该项目已展期,不能再次展期!", MsgBoxStyle.Information, "展期申请")
                Exit Sub
            End If

            strErr = gWs.CreateProcess("展期", Trim(tmpProjectID), UserName, "")
            If strErr = "1" Then
                MsgBox("启动展期申请成功!", MsgBoxStyle.Information, "展期申请")
                RaiseEvent refreshTaskCommit()
            Else
                MsgBox("启动展期申请失败:" & strErr, MsgBoxStyle.Critical, "展期申请")
            End If
        Else
            Exit Sub
        End If
    End Sub

End Class
