

Public Class frmAssignationLawManager
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents cmbAssignInfo As System.Windows.Forms.ComboBox
    Public WithEvents btnSearch As System.Windows.Forms.Button
    Public WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpApplyDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtApplyServiceType As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPhase As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtApplyBranchBank As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtApplyGuaranteeTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtApplyGuaranteeSum As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtManagerB As System.Windows.Forms.TextBox
    Friend WithEvents txtManagerA As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAssignationLawManager))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtManagerB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtManagerA = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtApplyGuaranteeTerm = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtApplyGuaranteeSum = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtApplyBranchBank = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtBank = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dtpApplyDate = New System.Windows.Forms.DateTimePicker()
        Me.txtApplyServiceType = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPhase = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbAssignInfo = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Location = New System.Drawing.Point(256, 6)
        Me.txtEnterpriseName.Size = New System.Drawing.Size(248, 21)
        Me.txtEnterpriseName.Visible = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(192, 8)
        Me.Label2.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(88, 6)
        Me.txtProjectCode.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(305, 216)
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtManagerB, Me.Label5, Me.txtManagerA, Me.Label4, Me.txtApplyGuaranteeTerm, Me.Label11, Me.txtApplyGuaranteeSum, Me.Label10, Me.txtApplyBranchBank, Me.Label16, Me.txtBank, Me.Label9, Me.Label13, Me.dtpApplyDate, Me.txtApplyServiceType, Me.Label8, Me.txtStatus, Me.Label7, Me.txtPhase, Me.Label6})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 152)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "项目基本信息"
        '
        'txtManagerB
        '
        Me.txtManagerB.BackColor = System.Drawing.Color.Gainsboro
        Me.txtManagerB.Location = New System.Drawing.Point(336, 118)
        Me.txtManagerB.Name = "txtManagerB"
        Me.txtManagerB.ReadOnly = True
        Me.txtManagerB.Size = New System.Drawing.Size(144, 21)
        Me.txtManagerB.TabIndex = 48
        Me.txtManagerB.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(256, 120)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 16)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "项目经理B"
        '
        'txtManagerA
        '
        Me.txtManagerA.BackColor = System.Drawing.Color.Gainsboro
        Me.txtManagerA.Location = New System.Drawing.Point(96, 118)
        Me.txtManagerA.Name = "txtManagerA"
        Me.txtManagerA.ReadOnly = True
        Me.txtManagerA.Size = New System.Drawing.Size(144, 21)
        Me.txtManagerA.TabIndex = 46
        Me.txtManagerA.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 16)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "项目经理A"
        '
        'txtApplyGuaranteeTerm
        '
        Me.txtApplyGuaranteeTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyGuaranteeTerm.Location = New System.Drawing.Point(336, 94)
        Me.txtApplyGuaranteeTerm.Name = "txtApplyGuaranteeTerm"
        Me.txtApplyGuaranteeTerm.ReadOnly = True
        Me.txtApplyGuaranteeTerm.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyGuaranteeTerm.TabIndex = 42
        Me.txtApplyGuaranteeTerm.Text = ""
        Me.txtApplyGuaranteeTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(256, 96)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(88, 16)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "担保期限(月)"
        '
        'txtApplyGuaranteeSum
        '
        Me.txtApplyGuaranteeSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyGuaranteeSum.Location = New System.Drawing.Point(96, 94)
        Me.txtApplyGuaranteeSum.Name = "txtApplyGuaranteeSum"
        Me.txtApplyGuaranteeSum.ReadOnly = True
        Me.txtApplyGuaranteeSum.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyGuaranteeSum.TabIndex = 40
        Me.txtApplyGuaranteeSum.Text = ""
        Me.txtApplyGuaranteeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "担保金额(万元)"
        '
        'txtApplyBranchBank
        '
        Me.txtApplyBranchBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyBranchBank.Location = New System.Drawing.Point(336, 70)
        Me.txtApplyBranchBank.Name = "txtApplyBranchBank"
        Me.txtApplyBranchBank.ReadOnly = True
        Me.txtApplyBranchBank.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyBranchBank.TabIndex = 38
        Me.txtApplyBranchBank.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(256, 72)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 16)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "意向贷款支行"
        '
        'txtBank
        '
        Me.txtBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBank.Location = New System.Drawing.Point(96, 70)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.ReadOnly = True
        Me.txtBank.Size = New System.Drawing.Size(144, 21)
        Me.txtBank.TabIndex = 36
        Me.txtBank.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "意向贷款银行"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 34
        Me.Label13.Text = "申请日期"
        '
        'dtpApplyDate
        '
        Me.dtpApplyDate.Enabled = False
        Me.dtpApplyDate.Location = New System.Drawing.Point(96, 46)
        Me.dtpApplyDate.Name = "dtpApplyDate"
        Me.dtpApplyDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpApplyDate.TabIndex = 33
        Me.dtpApplyDate.Value = New Date(2003, 5, 20, 0, 0, 0, 0)
        '
        'txtApplyServiceType
        '
        Me.txtApplyServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyServiceType.Location = New System.Drawing.Point(336, 46)
        Me.txtApplyServiceType.Name = "txtApplyServiceType"
        Me.txtApplyServiceType.ReadOnly = True
        Me.txtApplyServiceType.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyServiceType.TabIndex = 32
        Me.txtApplyServiceType.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(256, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "业务品种"
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.Gainsboro
        Me.txtStatus.Location = New System.Drawing.Point(336, 22)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(144, 21)
        Me.txtStatus.TabIndex = 30
        Me.txtStatus.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(256, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = " 状 态 "
        '
        'txtPhase
        '
        Me.txtPhase.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPhase.Location = New System.Drawing.Point(96, 22)
        Me.txtPhase.Name = "txtPhase"
        Me.txtPhase.ReadOnly = True
        Me.txtPhase.Size = New System.Drawing.Size(144, 21)
        Me.txtPhase.TabIndex = 28
        Me.txtPhase.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = " 阶 段 "
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "分配信息"
        '
        'cmbAssignInfo
        '
        Me.cmbAssignInfo.Location = New System.Drawing.Point(104, 192)
        Me.cmbAssignInfo.Name = "cmbAssignInfo"
        Me.cmbAssignInfo.Size = New System.Drawing.Size(144, 20)
        Me.cmbAssignInfo.TabIndex = 12
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Bitmap)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.ImageIndex = 27
        Me.btnSearch.ImageList = Me.ImageListBasic
        Me.btnSearch.Location = New System.Drawing.Point(129, 216)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 23)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "查 询(&S)"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(217, 216)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 10
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmAssignationLawManager
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(514, 247)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.Label3, Me.cmbAssignInfo, Me.btnSearch, Me.btnCommit, Me.GroupBox1})
        Me.MinimizeBox = False
        Me.Name = "frmAssignationLawManager"
        Me.Text = "分配法务经理"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private bIsFormLoad As Boolean = False
    Private bIsTextChanged As Boolean = False
    Private UpdateResult As String
    Private ds As DataSet
    Private roleID As String = "33"

    Private Sub frmAssignLawManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Me.InitializeData()
            Me.bIsFormLoad = True
        Catch ex As Exception
            'Micahel
            'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub InitializeData()
        '-------取得法务经理列表
        Dim dtTemp As DataTable
        'dtTemp = MdlGlobal.GetPerson(Me.getProjectCode(), roleID)
        'For i = 0 To dtTemp.Rows.Count - 1
        '    Me.cmbAssignInfo.Items.Add(dtTemp.Rows(i).Item("staff_name"))
        'Next
        Dim arylist As ArrayList = MdlGlobal.GetPersnList(MdlGlobal.GetConsigner(Me.getProjectCode(), Me.getTaskID()), roleID)
        For i = 0 To arylist.Count - 1
            Me.cmbAssignInfo.Items.Add(arylist.Item(i).ToString())
        Next
        'get the default peson
        dtTemp = gWs.GetDefaultPerson(Me.getProjectCode(), roleID).Tables(0)
        If Not dtTemp.Rows.Count = 0 Then
            Me.cmbAssignInfo.SelectedItem = dtTemp.Rows(0).Item("Person")
        End If

        '-------界面显示一些项目信息
        ds = gWs.GetProjectInfoEx("{projectcode='" & Me.getProjectCode() & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtPhase.Text = IIf(.Item("phase") Is System.DBNull.Value, "", .Item("phase"))
                Me.txtStatus.Text = IIf(.Item("status") Is System.DBNull.Value, "", .Item("status"))
                Me.dtpApplyDate.Text = IIf(.Item("applydate") Is System.DBNull.Value, "", .Item("applydate"))
                Me.txtApplyServiceType.Text = IIf(.Item("servicetype") Is System.DBNull.Value, "", .Item("servicetype"))
                Me.txtBank.Text = IIf(.Item("applybank") Is System.DBNull.Value, "", .Item("applybank"))
                Me.txtApplyBranchBank.Text = IIf(.Item("ApplyBranchBank") Is System.DBNull.Value, "", .Item("ApplyBranchBank"))
                Me.txtApplyGuaranteeSum.Text = IIf(.Item("guaranteesum") Is System.DBNull.Value, "", .Item("guaranteesum"))
                Me.txtApplyGuaranteeTerm.Text = IIf(.Item("terms") Is System.DBNull.Value, "", .Item("terms"))
            End With
        End If

        ds = gWs.GetProjectTaskAttendeeInfo("{project_code='" & Me.getProjectCode() & "' and role_id='24'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtManagerA.Text = IIf(.Item("attend_person") Is System.DBNull.Value, "", .Item("attend_person"))
            End With
        End If
        ds = gWs.GetProjectTaskAttendeeInfo("{project_code='" & Me.getProjectCode() & "' and role_id='25'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.txtManagerB.Text = IIf(.Item("attend_person") Is System.DBNull.Value, "", .Item("attend_person"))
            End With
        End If
    End Sub

    Private Sub cmbAssignInfo_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAssignInfo.TextChanged
        If Me.bIsFormLoad = True Then Me.bIsTextChanged = True
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Function SaveData() As Integer
        If Me.cmbAssignInfo.Text.Trim() = "" Then
            'Michael
            'MessageBox.Show("请选择分配信息进行操作。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("$1007", "分配信息")
            Me.cmbAssignInfo.Focus() : Return 0
        End If
        ds = gWs.GetProjectTaskAttendeeInfo("{project_code='" & Me.strProjectCode & "' AND role_id='33'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                ds.Tables(0).Rows(i).Item("attend_person") = Workflow.GetRealTaskAttendee("33", Me.cmbAssignInfo.Text)
            Next
        End If
        '若数据集ds发生了更改，则保存该更改。
        Me.UpdateResult = gWs.UpdateProjectTaskAttendee(ds)
        If Me.UpdateResult = "1" Then
            Me.bIsTextChanged = False : Me.bIsFormLoad = False : Return 1
        Else
            'Michael
            'MessageBox.Show("记录更新失败：" + Me.UpdateResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", "记录更新失败", Me.UpdateResult, "")
            Return 0
        End If
    End Function

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            'Michael
            'If MessageBox.Show("是否确认提交？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = DialogResult.OK Then
            If SWDialogBox.MessageBox.Show("?1000", "提交") = DialogResult.Yes Then
                If Me.SaveData() = 0 Then Return
                Me.CommitWorkFlow(Me.cmbAssignInfo.Text.Trim(), Me)
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

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim frm As New frmQueryCurrentTask(roleID)
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
