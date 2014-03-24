
'分配项目经理
Public Class frmAssignationProjectManager
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
    Public WithEvents btnCommit As System.Windows.Forms.Button
    Public WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents dtpApplyDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtFirstChecker As System.Windows.Forms.TextBox
    Friend WithEvents txtApplyGuaranteeTerm As System.Windows.Forms.TextBox
    Friend WithEvents txtApplyGuaranteeSum As System.Windows.Forms.TextBox
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents txtApplyServiceType As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtIndustryType As System.Windows.Forms.TextBox
    Friend WithEvents txtEnterpriseType As System.Windows.Forms.TextBox
    Friend WithEvents txtPhase As System.Windows.Forms.TextBox
    Friend WithEvents txtApplyBranchBank As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents cmbAssignManagerB As System.Windows.Forms.ComboBox
    Public WithEvents Label17 As System.Windows.Forms.Label
    Public WithEvents cmbAssignManagerA As System.Windows.Forms.ComboBox
    Protected WithEvents chkProjectDuty As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAssignationProjectManager))
        Me.btnCommit = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtApplyBranchBank = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.dtpApplyDate = New System.Windows.Forms.DateTimePicker
        Me.txtFirstChecker = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtApplyGuaranteeTerm = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtApplyGuaranteeSum = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtBank = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtApplyServiceType = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtStatus = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtIndustryType = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtEnterpriseType = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtPhase = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbAssignManagerB = New System.Windows.Forms.ComboBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.cmbAssignManagerA = New System.Windows.Forms.ComboBox
        Me.chkProjectDuty = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(192, 8)
        Me.Label2.Name = "Label2"
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Location = New System.Drawing.Point(256, 6)
        Me.txtEnterpriseName.Name = "txtEnterpriseName"
        Me.txtEnterpriseName.Size = New System.Drawing.Size(248, 21)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 6)
        Me.txtProjectCode.Name = "txtProjectCode"
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(304, 264)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(219, 264)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 6
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.ImageIndex = 26
        Me.btnSearch.ImageList = Me.ImageListBasic
        Me.btnSearch.Location = New System.Drawing.Point(134, 264)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 23)
        Me.btnSearch.TabIndex = 7
        Me.btnSearch.Text = "查 询(&S)"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtApplyBranchBank)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.dtpApplyDate)
        Me.GroupBox1.Controls.Add(Me.txtFirstChecker)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtApplyGuaranteeTerm)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtApplyGuaranteeSum)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtBank)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtApplyServiceType)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtStatus)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtIndustryType)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtEnterpriseType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtPhase)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 176)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "项目基本信息"
        '
        'txtApplyBranchBank
        '
        Me.txtApplyBranchBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyBranchBank.Location = New System.Drawing.Point(336, 94)
        Me.txtApplyBranchBank.Name = "txtApplyBranchBank"
        Me.txtApplyBranchBank.ReadOnly = True
        Me.txtApplyBranchBank.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyBranchBank.TabIndex = 30
        Me.txtApplyBranchBank.Text = ""
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(256, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 16)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "申请贷款支行"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 16)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "申请日期"
        '
        'dtpApplyDate
        '
        Me.dtpApplyDate.Enabled = False
        Me.dtpApplyDate.Location = New System.Drawing.Point(96, 70)
        Me.dtpApplyDate.Name = "dtpApplyDate"
        Me.dtpApplyDate.Size = New System.Drawing.Size(144, 21)
        Me.dtpApplyDate.TabIndex = 25
        Me.dtpApplyDate.Value = New Date(2003, 6, 27, 0, 0, 0, 0)
        '
        'txtFirstChecker
        '
        Me.txtFirstChecker.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFirstChecker.Location = New System.Drawing.Point(336, 142)
        Me.txtFirstChecker.Name = "txtFirstChecker"
        Me.txtFirstChecker.ReadOnly = True
        Me.txtFirstChecker.Size = New System.Drawing.Size(144, 21)
        Me.txtFirstChecker.TabIndex = 24
        Me.txtFirstChecker.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(256, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 16)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "初审人员"
        '
        'txtApplyGuaranteeTerm
        '
        Me.txtApplyGuaranteeTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyGuaranteeTerm.Location = New System.Drawing.Point(336, 118)
        Me.txtApplyGuaranteeTerm.Name = "txtApplyGuaranteeTerm"
        Me.txtApplyGuaranteeTerm.ReadOnly = True
        Me.txtApplyGuaranteeTerm.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyGuaranteeTerm.TabIndex = 22
        Me.txtApplyGuaranteeTerm.Text = ""
        Me.txtApplyGuaranteeTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(256, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 16)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "申请期限(月)"
        '
        'txtApplyGuaranteeSum
        '
        Me.txtApplyGuaranteeSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyGuaranteeSum.Location = New System.Drawing.Point(96, 118)
        Me.txtApplyGuaranteeSum.Name = "txtApplyGuaranteeSum"
        Me.txtApplyGuaranteeSum.ReadOnly = True
        Me.txtApplyGuaranteeSum.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyGuaranteeSum.TabIndex = 20
        Me.txtApplyGuaranteeSum.Text = ""
        Me.txtApplyGuaranteeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(8, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 16)
        Me.Label10.TabIndex = 19
        Me.Label10.Text = "申请金额(万元)"
        '
        'txtBank
        '
        Me.txtBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBank.Location = New System.Drawing.Point(96, 94)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.ReadOnly = True
        Me.txtBank.Size = New System.Drawing.Size(144, 21)
        Me.txtBank.TabIndex = 18
        Me.txtBank.Text = ""
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(8, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 16)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "申请贷款银行"
        '
        'txtApplyServiceType
        '
        Me.txtApplyServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyServiceType.Location = New System.Drawing.Point(96, 46)
        Me.txtApplyServiceType.Name = "txtApplyServiceType"
        Me.txtApplyServiceType.ReadOnly = True
        Me.txtApplyServiceType.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyServiceType.TabIndex = 16
        Me.txtApplyServiceType.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(8, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "申请业务品种"
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.Gainsboro
        Me.txtStatus.Location = New System.Drawing.Point(336, 46)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(144, 21)
        Me.txtStatus.TabIndex = 14
        Me.txtStatus.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(256, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 16)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = " 状 态 "
        '
        'txtIndustryType
        '
        Me.txtIndustryType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtIndustryType.Location = New System.Drawing.Point(96, 142)
        Me.txtIndustryType.Name = "txtIndustryType"
        Me.txtIndustryType.ReadOnly = True
        Me.txtIndustryType.Size = New System.Drawing.Size(144, 21)
        Me.txtIndustryType.TabIndex = 3
        Me.txtIndustryType.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 144)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "行业类型"
        '
        'txtEnterpriseType
        '
        Me.txtEnterpriseType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEnterpriseType.Location = New System.Drawing.Point(96, 22)
        Me.txtEnterpriseType.Name = "txtEnterpriseType"
        Me.txtEnterpriseType.ReadOnly = True
        Me.txtEnterpriseType.Size = New System.Drawing.Size(144, 21)
        Me.txtEnterpriseType.TabIndex = 1
        Me.txtEnterpriseType.Text = ""
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "企业类型"
        '
        'txtPhase
        '
        Me.txtPhase.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPhase.Location = New System.Drawing.Point(336, 22)
        Me.txtPhase.Name = "txtPhase"
        Me.txtPhase.ReadOnly = True
        Me.txtPhase.Size = New System.Drawing.Size(144, 21)
        Me.txtPhase.TabIndex = 12
        Me.txtPhase.Text = ""
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(256, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = " 阶 段 "
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 218)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "项目经理A"
        '
        'cmbAssignManagerB
        '
        Me.cmbAssignManagerB.Location = New System.Drawing.Point(344, 216)
        Me.cmbAssignManagerB.Name = "cmbAssignManagerB"
        Me.cmbAssignManagerB.Size = New System.Drawing.Size(144, 20)
        Me.cmbAssignManagerB.TabIndex = 22
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(264, 218)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 16)
        Me.Label17.TabIndex = 21
        Me.Label17.Text = "项目经理B"
        '
        'cmbAssignManagerA
        '
        Me.cmbAssignManagerA.Location = New System.Drawing.Point(104, 216)
        Me.cmbAssignManagerA.Name = "cmbAssignManagerA"
        Me.cmbAssignManagerA.Size = New System.Drawing.Size(144, 20)
        Me.cmbAssignManagerA.TabIndex = 20
        '
        'chkProjectDuty
        '
        Me.chkProjectDuty.Checked = True
        Me.chkProjectDuty.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkProjectDuty.Location = New System.Drawing.Point(16, 240)
        Me.chkProjectDuty.Name = "chkProjectDuty"
        Me.chkProjectDuty.Size = New System.Drawing.Size(112, 24)
        Me.chkProjectDuty.TabIndex = 29
        Me.chkProjectDuty.Text = "项目责任人"
        '
        'frmAssignationProjectManager
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(514, 295)
        Me.Controls.Add(Me.chkProjectDuty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbAssignManagerB)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.cmbAssignManagerA)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnCommit)
        Me.MinimizeBox = False
        Me.Name = "frmAssignationProjectManager"
        Me.Text = "分配项目经理"
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.btnSearch, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.cmbAssignManagerA, 0)
        Me.Controls.SetChildIndex(Me.Label17, 0)
        Me.Controls.SetChildIndex(Me.cmbAssignManagerB, 0)
        Me.Controls.SetChildIndex(Me.Label3, 0)
        Me.Controls.SetChildIndex(Me.chkProjectDuty, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.Controls.SetChildIndex(Me.txtEnterpriseName, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ds As DataSet
    Private RoleID As String = "22"
    Private BankCode, BranchBankCode As String

    Private Sub frmAssignProjectTeam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Me.ShowIniData(Me.strProjectCode, Me.strEnterpriseName)
            Me.IniComboxContral(Me.RoleID)
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
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
                If Not .Item("proprietorship_type") Is System.DBNull.Value Then
                    Me.txtEnterpriseType.Text = .Item("proprietorship_type")
                End If
            End With
        End If
        ds = gWs.GetProjectInfo("{project_code='" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                If Not .Item("phase") Is System.DBNull.Value Then
                    Me.txtPhase.Text = .Item("phase")
                End If
                If Not .Item("status") Is System.DBNull.Value Then
                    Me.txtStatus.Text = .Item("status")
                End If
                If Not .Item("apply_sum") Is System.DBNull.Value Then
                    Me.txtApplyGuaranteeSum.Text = .Item("apply_sum")
                End If
                If Not .Item("apply_term") Is System.DBNull.Value Then
                    Me.txtApplyGuaranteeTerm.Text = .Item("apply_term")
                End If
                If Not .Item("apply_date") Is System.DBNull.Value Then
                    Me.dtpApplyDate.Value = .Item("apply_date")
                End If
                If Not .Item("apply_service_type") Is System.DBNull.Value Then
                    Me.txtApplyServiceType.Text = .Item("apply_service_type")
                End If
                If Not .Item("apply_bank") Is System.DBNull.Value Then
                    Me.BankCode = .Item("apply_bank")
                Else
                    Me.BankCode = Nothing
                End If
                If Not .Item("apply_branch_bank") Is System.DBNull.Value Then
                    Me.BranchBankCode = .Item("apply_branch_bank")
                Else
                    Me.BranchBankCode = ""
                End If
            End With
        End If
        ds = gWs.FetchProjectCorporation(ProjectCode, "%", "%", "%")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                If Not .Item("create_person") Is System.DBNull.Value Then
                    Me.txtFirstChecker.Text = .Item("create_person")
                End If
            End With
        End If
        Me.txtBank.Text = GetBankName(Me.BankCode, Nothing)
        Me.txtApplyBranchBank.Text = GetBankName(Me.BankCode, Me.BranchBankCode)
    End Sub

    Private Function GetBankName(ByVal BankCode As String, ByVal BranchBankCode As String) As String
        If gWs Is Nothing Then Exit Function
        Dim TempDS As New DataSet()
        If BranchBankCode Is Nothing Then
            TempDS = gWs.GetBankInfo("{bank_code='" & BankCode & "'}", "null")
            If Not TempDS.Tables(0).Rows.Count = 0 Then
                Return TempDS.Tables(0).Rows(0).Item("bank_name")
            End If
        Else
            TempDS = gWs.GetBankInfo("null", "{bank_code='" & BankCode & "' and branch_bank_code='" & BranchBankCode & "'}")
            If Not TempDS.Tables(1).Rows.Count = 0 Then
                Return TempDS.Tables(1).Rows(0).Item("branch_bank_name")
            End If
        End If
    End Function

    Private Sub IniComboxContral(ByVal RoleID As String)
        Dim TempDs As New DataSet()
        'Dim arrList As New ArrayList()
        Dim j As Integer
        'Me.cmbAssignManagerA.Items.Clear()
        'Me.cmbAssignManagerB.Items.Clear()
        'arrList.Clear()
        'TempDs = gWs.GetProjectTaskAttendeeInfo("{project_code='" & Me.strProjectCode & "' and role_id='" & RoleID & "'}")

        'If Not TempDs.Tables(0).Rows.Count = 0 Then
        '    For i = 0 To TempDs.Tables(0).Rows.Count - 1
        '        arrList.Add(TempDs.Tables(0).Rows(i).Item("attend_person"))
        '    Next
        '    For i = 0 To arrList.Count - 1
        '        TempDs = gWs.GetStaffEX("{team_name='" & arrList.Item(i) & "'}")
        '        If Not TempDs.Tables(0).Rows.Count = 0 Then
        '            For j = 0 To TempDs.Tables(0).Rows.Count - 1
        '                Me.cmbAssignManagerA.Items.Add(TempDs.Tables(0).Rows(j).Item("staff_name"))
        '                Me.cmbAssignManagerB.Items.Add(TempDs.Tables(0).Rows(j).Item("staff_name"))
        '            Next
        '        End If
        '        TempDs = gWs.GetDefaultPerson(Me.getProjectCode(), "24")
        '        If Not TempDs.Tables(0).Rows.Count = 0 Then
        '            Me.cmbAssignManagerA.SelectedItem = TempDs.Tables(0).Rows(0).Item("Person")
        '        End If
        '        TempDs = gWs.GetDefaultPerson(Me.getProjectCode(), "25")
        '        If Not TempDs.Tables(0).Rows.Count = 0 Then
        '            Me.cmbAssignManagerB.SelectedItem = TempDs.Tables(0).Rows(0).Item("Person")
        '        End If
        '    Next
        'Else   'modified by hute 2003-10-15
            '分配项目经理
            Me.cmbAssignManagerA.Items.Clear()
            Me.cmbAssignManagerB.Items.Clear()
            Dim dtTemp As DataTable
            Dim arylist As ArrayList = New ArrayList()
            arylist = MdlGlobal.GetPersnList(MdlGlobal.GetConsigner(Me.getProjectCode(), Me.getTaskID()), 24)
            For i = 0 To arylist.Count - 1
                Me.cmbAssignManagerA.Items.Add(arylist(i).ToString())
            Next

            arylist.Clear()
            arylist = MdlGlobal.GetPersnList(MdlGlobal.GetConsigner(Me.getProjectCode(), Me.getTaskID()), 25)
            For i = 0 To arylist.Count - 1
                Me.cmbAssignManagerB.Items.Add(arylist(i).ToString())
            Next

            'get the default peson
            dtTemp = gWs.GetDefaultPerson(Me.getProjectCode(), "24").Tables(0)
            If Not dtTemp.Rows.Count = 0 Then
                Me.cmbAssignManagerA.SelectedItem = dtTemp.Rows(0).Item("Person")
            End If
            dtTemp = gWs.GetDefaultPerson(Me.getProjectCode(), "25").Tables(0)
            If Not dtTemp.Rows.Count = 0 Then
                Me.cmbAssignManagerB.SelectedItem = dtTemp.Rows(0).Item("Person")
            End If
        'End If

    End Sub

    '保存之前校验数据
    Private Function CheckData() As Boolean
        ds = gWs.GetProjectInfoEx("{projectcode like '" & Me.strProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            If ds.Tables(0).Rows(0).Item("applyservicetype") = "委托评审" Then
                If Me.cmbAssignManagerA.Text.Trim() = "" Then
                    SWDialogBox.MessageBox.Show("$1001", "项目经理A")
                    Return False
                End If
            Else
                If Me.cmbAssignManagerA.Text.Trim() = "" Or Me.cmbAssignManagerB.Text.Trim() = "" Then
                    SWDialogBox.MessageBox.Show("$1001", "项目经理A或者项目经理B")
                    Return False
                End If
            End If
        End If
        If Me.cmbAssignManagerA.Text.Trim() = Me.cmbAssignManagerB.Text.Trim() Then
            SWDialogBox.MessageBox.Show("$1003", "项目经理A或者项目经理B")
            Return False
        End If
        Return True
    End Function

    Private Function SaveData() As Boolean
        If Not Me.CheckData() Then
            Return False
        End If

        Dim strResult As String
        ds = gWs.GetProjectResponsibleInfo("{project_code = '" & Me.strProjectCode & "'}")
        If ds.Tables(0).Rows.Count = 0 Then
            Dim dr As DataRow = ds.Tables(0).NewRow
            dr("project_code") = Me.getProjectCode()
            dr("manager_A") = Me.cmbAssignManagerA.Text
            dr("manager_B") = Me.cmbAssignManagerB.Text
            dr("create_person") = UserName
            dr("create_date") = gWs.GetSysTime()
            ds.Tables(0).Rows.Add(dr)
        ElseIf Me.chkProjectDuty.Checked Then
            With ds.Tables(0).Rows(0)
                .Item("project_code") = Me.getProjectCode()
                .Item("manager_A") = Me.cmbAssignManagerA.Text
                .Item("manager_B") = Me.cmbAssignManagerB.Text
                .Item("create_person") = UserName
                .Item("create_date") = gWs.GetSysTime()
            End With
        End If
        strResult = gWs.UpdateProjectResponsible(ds)
        If Not strResult = "1" Then
            SWDialogBox.MessageBox.Show("*999", "更新项目责任人失败", strResult, "")
            Return False
        End If

        ds = gWs.GetProjectTaskAttendeeInfo("{project_code='" & Me.strProjectCode & "' and role_id='24'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                ds.Tables(0).Rows(i).Item("attend_person") = Workflow.GetRealTaskAttendee("24", Me.cmbAssignManagerA.Text)
                ds.Tables(0).Rows(i).Item("create_date") = gWs.GetSysTime()
            Next
        End If
        strResult = gWs.UpdateProjectTaskAttendee(ds)
        If Not strResult = "1" Then
            SWDialogBox.MessageBox.Show("*999", "记录更新项目经理A失败", strResult, "")
            Return False
        End If

        ds = gWs.GetProjectTaskAttendeeInfo("{project_code='" & Me.strProjectCode & "' and role_id='25'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            For i = 0 To ds.Tables(0).Rows.Count - 1
                ds.Tables(0).Rows(i).Item("attend_person") = Workflow.GetRealTaskAttendee("25", Me.cmbAssignManagerB.Text)
                ds.Tables(0).Rows(i).Item("create_date") = gWs.GetSysTime()
            Next
        End If
        strResult = gWs.UpdateProjectTaskAttendee(ds)
        If Not strResult = "1" Then
            SWDialogBox.MessageBox.Show("*999", "记录更新项目经理B失败", strResult, "")
            Return False
        End If

        '更新项目表中managerTeam_name字段
        ds = gWs.GetProjectInfo("{project_code='" & Me.getProjectCode() & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                .Item("managerTeam_name") = getStaffTeamName(Me.cmbAssignManagerA.Text)
            End With
        End If
        strResult = gWs.UpdateProject(ds)
        If Not strResult = "1" Then
            SWDialogBox.MessageBox.Show("*999", "更新项目表失败", strResult, "")
            Return False
        End If

        Return True
    End Function

    '查询
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim frm As New frmQueryCurrentTask("24", Me.cmbAssignManagerA.Text, "项目评审")
            frm.AllowTransparency = False
            frm.ProjectCode = Me.getProjectCode()
            frm.TaskID = Me.getTaskID()
            frm.ShowDialog()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '提交按钮按下 
    Protected Overridable Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If SWDialogBox.MessageBox.Show("?1000", "提交") <> MsgBoxResult.Yes Then
            Return
        End If

        Try
            Me.Cursor = Cursors.WaitCursor
            If Not Me.SaveData() Then
                Return
            End If

            Dim strResult As String
            strResult = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), "", UserName)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "分配项目经理")
            Else
                MyBase.raiseCommitSucceed()
                SWDialogBox.MessageBox.Show("$SubmitSucceed")
                Close()
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '退出按钮按下
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
