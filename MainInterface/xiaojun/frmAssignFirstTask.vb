

Public Class frmAssignFirstTask
    Inherits MainInterface.frmBusinessBaseWin

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
    Public WithEvents btnSearch As System.Windows.Forms.Button
    Public WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtApplyGuaranteeTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtApplyGuaranteeSum As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtIndustryType As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtEnterpriseType As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents cmbAssignInfo As System.Windows.Forms.ComboBox
    Public WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents cmbAssignPerson As System.Windows.Forms.ComboBox
    Friend WithEvents dtpConsultateDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtConsultatePerson As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAssignFirstTask))
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpConsultateDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtConsultatePerson = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIndustryType = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEnterpriseType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApplyGuaranteeTerm = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtApplyGuaranteeSum = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbAssignInfo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbAssignPerson = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Location = New System.Drawing.Point(240, 6)
        Me.txtEnterpriseName.Size = New System.Drawing.Size(264, 21)
        Me.txtEnterpriseName.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(72, 6)
        Me.txtProjectCode.Visible = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(184, 8)
        Me.Label2.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(305, 176)
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.Visible = True
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Bitmap)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.ImageIndex = 27
        Me.btnSearch.ImageList = Me.ImageListBasic
        Me.btnSearch.Location = New System.Drawing.Point(129, 176)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 23)
        Me.btnSearch.TabIndex = 9
        Me.btnSearch.Text = "查 询(&S)"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(217, 176)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 8
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dtpConsultateDate, Me.Label3, Me.txtConsultatePerson, Me.Label6, Me.txtIndustryType, Me.Label5, Me.txtEnterpriseType, Me.Label4, Me.txtApplyGuaranteeTerm, Me.Label11, Me.txtApplyGuaranteeSum, Me.Label10})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 104)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "项目基本信息"
        '
        'dtpConsultateDate
        '
        Me.dtpConsultateDate.Enabled = False
        Me.dtpConsultateDate.Location = New System.Drawing.Point(336, 70)
        Me.dtpConsultateDate.Name = "dtpConsultateDate"
        Me.dtpConsultateDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpConsultateDate.TabIndex = 42
        Me.dtpConsultateDate.Value = New Date(2003, 5, 20, 0, 0, 0, 0)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(256, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "咨询日期"
        '
        'txtConsultatePerson
        '
        Me.txtConsultatePerson.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConsultatePerson.Location = New System.Drawing.Point(96, 70)
        Me.txtConsultatePerson.Name = "txtConsultatePerson"
        Me.txtConsultatePerson.ReadOnly = True
        Me.txtConsultatePerson.Size = New System.Drawing.Size(144, 21)
        Me.txtConsultatePerson.TabIndex = 40
        Me.txtConsultatePerson.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "咨询人员"
        '
        'txtIndustryType
        '
        Me.txtIndustryType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtIndustryType.Location = New System.Drawing.Point(336, 22)
        Me.txtIndustryType.Name = "txtIndustryType"
        Me.txtIndustryType.ReadOnly = True
        Me.txtIndustryType.Size = New System.Drawing.Size(144, 21)
        Me.txtIndustryType.TabIndex = 38
        Me.txtIndustryType.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(256, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "行业类型"
        '
        'txtEnterpriseType
        '
        Me.txtEnterpriseType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEnterpriseType.Location = New System.Drawing.Point(96, 22)
        Me.txtEnterpriseType.Name = "txtEnterpriseType"
        Me.txtEnterpriseType.ReadOnly = True
        Me.txtEnterpriseType.Size = New System.Drawing.Size(144, 21)
        Me.txtEnterpriseType.TabIndex = 36
        Me.txtEnterpriseType.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "企业类型"
        '
        'txtApplyGuaranteeTerm
        '
        Me.txtApplyGuaranteeTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyGuaranteeTerm.Location = New System.Drawing.Point(336, 46)
        Me.txtApplyGuaranteeTerm.Name = "txtApplyGuaranteeTerm"
        Me.txtApplyGuaranteeTerm.ReadOnly = True
        Me.txtApplyGuaranteeTerm.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyGuaranteeTerm.TabIndex = 32
        Me.txtApplyGuaranteeTerm.Text = ""
        Me.txtApplyGuaranteeTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(256, 48)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "申请期限(月)"
        '
        'txtApplyGuaranteeSum
        '
        Me.txtApplyGuaranteeSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyGuaranteeSum.Location = New System.Drawing.Point(96, 46)
        Me.txtApplyGuaranteeSum.Name = "txtApplyGuaranteeSum"
        Me.txtApplyGuaranteeSum.ReadOnly = True
        Me.txtApplyGuaranteeSum.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyGuaranteeSum.TabIndex = 30
        Me.txtApplyGuaranteeSum.Text = ""
        Me.txtApplyGuaranteeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 29
        Me.Label10.Text = "申请金额(万元)"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(264, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "分配人员"
        '
        'cmbAssignInfo
        '
        Me.cmbAssignInfo.Location = New System.Drawing.Point(104, 144)
        Me.cmbAssignInfo.Name = "cmbAssignInfo"
        Me.cmbAssignInfo.Size = New System.Drawing.Size(144, 20)
        Me.cmbAssignInfo.TabIndex = 12
        Me.cmbAssignInfo.Text = "初审分配"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 146)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "分配信息 "
        '
        'cmbAssignPerson
        '
        Me.cmbAssignPerson.Location = New System.Drawing.Point(344, 144)
        Me.cmbAssignPerson.Name = "cmbAssignPerson"
        Me.cmbAssignPerson.Size = New System.Drawing.Size(144, 20)
        Me.cmbAssignPerson.TabIndex = 14
        '
        'frmAssignFirstTask
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(514, 207)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label8, Me.cmbAssignPerson, Me.Label7, Me.cmbAssignInfo, Me.GroupBox1, Me.btnSearch, Me.btnCommit, Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1})
        Me.MinimizeBox = False
        Me.Name = "frmAssignFirstTask"
        Me.Text = "项目初审分配"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private bIsFormLoad As Boolean = False
    Private bIsTextChanaged As Boolean = False
    Private ds As DataSet
    Private RoleID As String = "13"
    Private intAssignType As Integer
    Private CorporationType As String
    Private UpdateResult As String

    Private Sub frmAssignationBasic_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call Me.ShowIniData(Me.strProjectCode, Me.strEnterpriseName)
            Call Me.IniAssignInfo()
            Call Me.IniAssignPersonInfo()
            Me.bIsFormLoad = True
        Catch ex As Exception
            'Michael
            'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub ShowIniData(ByVal ProjectCode As String, ByVal EnterpriseName As String)
        ds = gWs.GetcorporationInfo("{corporation_name='" & EnterpriseName & "'}", "null")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With Me.ds.Tables(0).Rows(0)
                If Not .Item("industry_type") Is System.DBNull.Value Then
                    Me.txtIndustryType.Text = .Item("industry_type")
                End If
                If Not .Item("corporation_type") Is System.DBNull.Value Then
                    Me.CorporationType = .Item("corporation_type")
                End If
            End With
        End If
        ds = gWs.GetCorporationType(Me.CorporationType)
        If Not ds.Tables(0).Rows.Count = 0 Then
            If Not Me.ds.Tables(0).Rows(0).Item("corporation_type") Is System.DBNull.Value Then
                Me.txtEnterpriseType.Text = Me.ds.Tables(0).Rows(0).Item("corporation_type")
            End If
        End If
        ds = gWs.GetProjectInfo("{project_code='" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                If Not .Item("apply_sum") Is System.DBNull.Value Then
                    Me.txtApplyGuaranteeSum.Text = .Item("apply_sum")
                End If
                If Not .Item("apply_term") Is System.DBNull.Value Then
                    Me.txtApplyGuaranteeTerm.Text = .Item("apply_term")
                End If
            End With
        End If
        ds = gWs.GetcorporationInfo("null", "{corporation_name='" & EnterpriseName & "' order by consult_date desc}")
        If Not ds.Tables(1).Rows.Count = 0 Then
            With ds.Tables(1).Rows(0)
                Me.txtConsultatePerson.Text = IIf(.Item("consult_person") Is System.DBNull.Value, "", .Item("consult_person"))
                Me.dtpConsultateDate.Text = IIf(.Item("consult_date") Is System.DBNull.Value, "", .Item("consult_date"))
            End With
        End If
    End Sub

    Private Sub IniAssignInfo()
        ds = gWs.GetTransCondition(Me.strWorkFlowID, Me.strProjectCode, Me.strTaskID)
        If Not ds.Tables(0).Rows.Count = 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                If Not ds.Tables(0).Rows(i).Item("transfer_condition") Is System.DBNull.Value Then
                    With Me.cmbAssignInfo.Items
                        .Add(ds.Tables(0).Rows(i).Item("transfer_condition"))
                    End With
                End If
            Next
        End If
    End Sub

    Private Sub IniAssignPersonInfo()
        Dim dtTemp As DataTable
        dtTemp = MdlGlobal.GetPerson(Me.getProjectCode(), RoleID) '取得初审人员
        For i = 0 To dtTemp.Rows.Count - 1
            Me.cmbAssignPerson.Items.Add(dtTemp.Rows(i).Item("staff_name"))
        Next
        'get the default peson
        dtTemp = gWs.GetDefaultPerson(Me.getProjectCode(), RoleID).Tables(0)
        If Not dtTemp.Rows.Count = 0 Then
            Me.cmbAssignPerson.SelectedItem = dtTemp.Rows(0).Item("Person")
        End If
    End Sub

    Private Sub cmbAssignInfo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAssignInfo.TextChanged
        If Me.bIsFormLoad Then Me.bIsTextChanaged = True
    End Sub

    Private Sub cmbAssignPerson_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAssignPerson.TextChanged
        If Me.bIsFormLoad Then Me.bIsTextChanaged = True
    End Sub

    Private Sub cmbAssignInfo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAssignInfo.SelectedIndexChanged
        Dim strAssignType As String
        strAssignType = Me.cmbAssignInfo.Text.Trim()
        If strAssignType = "快速通道" Or strAssignType = "再次申请" Then
            Me.intAssignType = 1
            Me.cmbAssignPerson.Enabled = False
        Else
            Me.intAssignType = 2
            Me.cmbAssignPerson.Enabled = True
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Dim MsgResult As MsgBoxResult
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If Me.bIsTextChanaged Then
                'Michael
                'MsgResult = MessageBox.Show("是否保存对数据的修改。", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
                MsgResult = SWDialogBox.MessageBox.Show("?1003")
            Else
                Me.Close()
            End If
            If MsgResult = MsgBoxResult.Cancel Then Return
            If MsgResult = MsgBoxResult.No Then Me.bIsFormLoad = False : Me.bIsTextChanaged = False : Me.Close()
            If MsgResult = MsgBoxResult.Yes Then
                If Me.SaveData() = 1 Then
                    'Michael
                    'MessageBox.Show("数据保存成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SWDialogBox.MessageBox.Show("$SaveSucceed")
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            'Michael
            'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            'Mihchael
            ' If MessageBox.Show("是否确认提交？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            If SWDialogBox.MessageBox.Show("?1000", "提交") = DialogResult.Yes Then
                If Me.SaveData() = 0 Then Return
            End If
            Me.CommitWorkFlow(Me.cmbAssignInfo.Text.Trim(), Me)
        Catch ex As Exception
            'Michael
            'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Function SaveData() As Integer
        If Me.cmbAssignInfo.Text.Trim() = "" Or Me.cmbAssignPerson.Text.Trim() = "" Then
            'Michael
            'MessageBox.Show("请选择相应的操作对象进行操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1005", "操作对象")
            Return 0
        End If
        Dim strAssignType As String
        strAssignType = Me.cmbAssignInfo.Text.Trim()
        If strAssignType = "快速通道" Or strAssignType = "再次申请" Then
            Me.intAssignType = 1
        Else
            Me.intAssignType = 2
        End If
        ds = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.strProjectCode & "' and item_type='51' and item_code='005'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                .Item("project_code") = Me.strProjectCode
                .Item("item_type") = "51"
                .Item("item_code") = "005"
                .Item("conclusion") = Me.cmbAssignInfo.Text.Trim()
                .Item("create_person") = Me.strUserID
                .Item("create_date") = gWs.GetSysTime()
            End With
        Else
            ds = gWs.GetProjectOpinionByProjectNo("null")
            Dim NewRow As DataRow = ds.Tables(0).NewRow()
            With NewRow
                .Item("project_code") = Me.strProjectCode
                .Item("item_type") = "51"
                .Item("item_code") = "005"
                .Item("conclusion") = Me.cmbAssignInfo.Text.Trim()
                .Item("create_person") = Me.strUserID
                .Item("create_date") = gWs.GetSysTime()
            End With
            ds.Tables(0).Rows.Add(NewRow)
        End If
        Me.UpdateResult = gWs.UpdateProjectOpinion(ds)
        If Me.UpdateResult <> "1" Then
            'Michael
            ' MessageBox.Show("初审类型分配失败：" + Me.UpdateResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", "初审类型分配失败", Me.UpdateResult, "")
            Return 0
        End If

        '如果用户选择了分配类型“初审分配”执行。
        ds = gWs.GetProjectTaskAttendeeInfo("{project_code='" & Me.strProjectCode & "' and role_id='" & Me.RoleID & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                If Me.intAssignType = 2 Then
                    ds.Tables(0).Rows(i).Item("attend_person") = Workflow.GetRealTaskAttendee(Me.RoleID, Me.cmbAssignPerson.Text)
                Else
                    ds.Tables(0).Rows(i).Item("attend_person") = ""
                End If
            Next
        End If
        '若数据集ds发生了更改，则保存该更改。
        Me.UpdateResult = gWs.UpdateProjectTaskAttendee(ds)
        If Me.UpdateResult = "1" Then
            Me.bIsTextChanaged = False : Me.bIsFormLoad = False : Return 1
        Else
            'Michael
            'MessageBox.Show("记录更新失败：" + Me.UpdateResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", "记录更新失败：", Me.UpdateResult, "")
            Return 0
        End If
    End Function

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim frm As New frmQueryCurrentTask(Me.RoleID)
            frm.AllowTransparency = False
            frm.ProjectCode = Me.getProjectCode()
            frm.TaskID = Me.getTaskID()
            frm.ShowDialog()
        Catch ex As Exception
            'Michael
            'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

End Class
