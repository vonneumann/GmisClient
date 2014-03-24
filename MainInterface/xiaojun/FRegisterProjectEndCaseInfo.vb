
'登记项目结案信息
Public Class FRegisterProjectEndCaseInfo
    Inherits MainInterface.frmBasic

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
    Protected WithEvents grpBaseInfo As System.Windows.Forms.GroupBox
    Protected WithEvents txtSign_bank_branch_name As System.Windows.Forms.TextBox
    Friend WithEvents txtSign_bank_name As System.Windows.Forms.TextBox
    Protected WithEvents dtpStartTime As System.Windows.Forms.DateTimePicker
    Protected WithEvents txtOverdue_sum As System.Windows.Forms.TextBox
    Protected WithEvents lblOverdue_sum As System.Windows.Forms.Label
    Friend WithEvents txtManager_B As System.Windows.Forms.TextBox
    Friend WithEvents lbPmB As System.Windows.Forms.Label
    Friend WithEvents txtManager_A As System.Windows.Forms.TextBox
    Friend WithEvents lblPmA As System.Windows.Forms.Label
    Protected WithEvents lblSubBank As System.Windows.Forms.Label
    Protected WithEvents lblApplyDate As System.Windows.Forms.Label
    Protected WithEvents dtpSign_date As System.Windows.Forms.DateTimePicker
    Protected WithEvents txtTerms As System.Windows.Forms.TextBox
    Protected WithEvents txtSign_sum As System.Windows.Forms.TextBox
    Protected WithEvents lblBank As System.Windows.Forms.Label
    Protected WithEvents txtServiceType As System.Windows.Forms.TextBox
    Protected WithEvents btnCommit As System.Windows.Forms.Button
    Protected WithEvents lblCorporationName As System.Windows.Forms.Label
    Protected WithEvents lblProjectCode As System.Windows.Forms.Label
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Protected WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Protected WithEvents btnSave As System.Windows.Forms.Button
    Protected WithEvents grpEndCaseInfo As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Protected WithEvents txtDoubtful_account As System.Windows.Forms.TextBox
    Protected WithEvents dtpEndCase_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblRemark As System.Windows.Forms.Label
    Friend WithEvents lblDoubtful_account As System.Windows.Forms.Label
    Friend WithEvents lblEndCase_date As System.Windows.Forms.Label
    Protected WithEvents lblStartTime As System.Windows.Forms.Label
    Protected WithEvents lblTerms As System.Windows.Forms.Label
    Protected WithEvents lblSign_sum As System.Windows.Forms.Label
    Protected WithEvents lblServiceType As System.Windows.Forms.Label
    Protected WithEvents btnDoc As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRegisterProjectEndCaseInfo))
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.lblProjectCode = New System.Windows.Forms.Label()
        Me.grpBaseInfo = New System.Windows.Forms.GroupBox()
        Me.txtSign_bank_branch_name = New System.Windows.Forms.TextBox()
        Me.txtSign_bank_name = New System.Windows.Forms.TextBox()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.txtOverdue_sum = New System.Windows.Forms.TextBox()
        Me.lblOverdue_sum = New System.Windows.Forms.Label()
        Me.txtManager_B = New System.Windows.Forms.TextBox()
        Me.lbPmB = New System.Windows.Forms.Label()
        Me.txtManager_A = New System.Windows.Forms.TextBox()
        Me.lblPmA = New System.Windows.Forms.Label()
        Me.lblSubBank = New System.Windows.Forms.Label()
        Me.lblApplyDate = New System.Windows.Forms.Label()
        Me.dtpSign_date = New System.Windows.Forms.DateTimePicker()
        Me.txtTerms = New System.Windows.Forms.TextBox()
        Me.lblTerms = New System.Windows.Forms.Label()
        Me.txtSign_sum = New System.Windows.Forms.TextBox()
        Me.lblSign_sum = New System.Windows.Forms.Label()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.txtServiceType = New System.Windows.Forms.TextBox()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.grpEndCaseInfo = New System.Windows.Forms.GroupBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.txtDoubtful_account = New System.Windows.Forms.TextBox()
        Me.dtpEndCase_date = New System.Windows.Forms.DateTimePicker()
        Me.lblRemark = New System.Windows.Forms.Label()
        Me.lblDoubtful_account = New System.Windows.Forms.Label()
        Me.lblEndCase_date = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDoc = New System.Windows.Forms.Button()
        Me.grpBaseInfo.SuspendLayout()
        Me.grpEndCaseInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(376, 360)
        Me.btnExit.Visible = True
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Location = New System.Drawing.Point(184, 8)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(56, 16)
        Me.lblCorporationName.TabIndex = 58
        Me.lblCorporationName.Text = "企业名称"
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Location = New System.Drawing.Point(16, 8)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectCode.TabIndex = 57
        Me.lblProjectCode.Text = "项目编码"
        '
        'grpBaseInfo
        '
        Me.grpBaseInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtSign_bank_branch_name, Me.txtSign_bank_name, Me.lblStartTime, Me.dtpStartTime, Me.txtOverdue_sum, Me.lblOverdue_sum, Me.txtManager_B, Me.lbPmB, Me.txtManager_A, Me.lblPmA, Me.lblSubBank, Me.lblApplyDate, Me.dtpSign_date, Me.txtTerms, Me.lblTerms, Me.txtSign_sum, Me.lblSign_sum, Me.lblBank, Me.txtServiceType, Me.lblServiceType})
        Me.grpBaseInfo.Location = New System.Drawing.Point(8, 32)
        Me.grpBaseInfo.Name = "grpBaseInfo"
        Me.grpBaseInfo.Size = New System.Drawing.Size(496, 152)
        Me.grpBaseInfo.TabIndex = 61
        Me.grpBaseInfo.TabStop = False
        Me.grpBaseInfo.Text = "项目基本信息"
        '
        'txtSign_bank_branch_name
        '
        Me.txtSign_bank_branch_name.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSign_bank_branch_name.Location = New System.Drawing.Point(336, 46)
        Me.txtSign_bank_branch_name.Name = "txtSign_bank_branch_name"
        Me.txtSign_bank_branch_name.ReadOnly = True
        Me.txtSign_bank_branch_name.Size = New System.Drawing.Size(144, 21)
        Me.txtSign_bank_branch_name.TabIndex = 61
        Me.txtSign_bank_branch_name.TabStop = False
        Me.txtSign_bank_branch_name.Text = ""
        '
        'txtSign_bank_name
        '
        Me.txtSign_bank_name.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSign_bank_name.Location = New System.Drawing.Point(96, 46)
        Me.txtSign_bank_name.Name = "txtSign_bank_name"
        Me.txtSign_bank_name.ReadOnly = True
        Me.txtSign_bank_name.Size = New System.Drawing.Size(144, 21)
        Me.txtSign_bank_name.TabIndex = 60
        Me.txtSign_bank_name.Text = ""
        '
        'lblStartTime
        '
        Me.lblStartTime.Location = New System.Drawing.Point(8, 120)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(56, 16)
        Me.lblStartTime.TabIndex = 59
        Me.lblStartTime.Text = "放款日期"
        '
        'dtpStartTime
        '
        Me.dtpStartTime.Enabled = False
        Me.dtpStartTime.Location = New System.Drawing.Point(96, 118)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.Size = New System.Drawing.Size(144, 21)
        Me.dtpStartTime.TabIndex = 58
        Me.dtpStartTime.TabStop = False
        Me.dtpStartTime.Value = New Date(2003, 6, 27, 0, 0, 0, 0)
        '
        'txtOverdue_sum
        '
        Me.txtOverdue_sum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOverdue_sum.Location = New System.Drawing.Point(336, 118)
        Me.txtOverdue_sum.Name = "txtOverdue_sum"
        Me.txtOverdue_sum.ReadOnly = True
        Me.txtOverdue_sum.Size = New System.Drawing.Size(144, 21)
        Me.txtOverdue_sum.TabIndex = 54
        Me.txtOverdue_sum.TabStop = False
        Me.txtOverdue_sum.Text = ""
        Me.txtOverdue_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblOverdue_sum
        '
        Me.lblOverdue_sum.Location = New System.Drawing.Point(256, 120)
        Me.lblOverdue_sum.Name = "lblOverdue_sum"
        Me.lblOverdue_sum.Size = New System.Drawing.Size(80, 16)
        Me.lblOverdue_sum.TabIndex = 53
        Me.lblOverdue_sum.Text = "逾期金额(元)"
        '
        'txtManager_B
        '
        Me.txtManager_B.BackColor = System.Drawing.Color.Gainsboro
        Me.txtManager_B.Location = New System.Drawing.Point(336, 94)
        Me.txtManager_B.Name = "txtManager_B"
        Me.txtManager_B.ReadOnly = True
        Me.txtManager_B.Size = New System.Drawing.Size(144, 21)
        Me.txtManager_B.TabIndex = 52
        Me.txtManager_B.Text = ""
        '
        'lbPmB
        '
        Me.lbPmB.Location = New System.Drawing.Point(256, 96)
        Me.lbPmB.Name = "lbPmB"
        Me.lbPmB.Size = New System.Drawing.Size(64, 16)
        Me.lbPmB.TabIndex = 51
        Me.lbPmB.Text = "项目经理B"
        '
        'txtManager_A
        '
        Me.txtManager_A.BackColor = System.Drawing.Color.Gainsboro
        Me.txtManager_A.Location = New System.Drawing.Point(96, 94)
        Me.txtManager_A.Name = "txtManager_A"
        Me.txtManager_A.ReadOnly = True
        Me.txtManager_A.Size = New System.Drawing.Size(144, 21)
        Me.txtManager_A.TabIndex = 50
        Me.txtManager_A.Text = ""
        '
        'lblPmA
        '
        Me.lblPmA.Location = New System.Drawing.Point(8, 96)
        Me.lblPmA.Name = "lblPmA"
        Me.lblPmA.Size = New System.Drawing.Size(64, 16)
        Me.lblPmA.TabIndex = 49
        Me.lblPmA.Text = "项目经理A"
        '
        'lblSubBank
        '
        Me.lblSubBank.Location = New System.Drawing.Point(256, 48)
        Me.lblSubBank.Name = "lblSubBank"
        Me.lblSubBank.Size = New System.Drawing.Size(56, 16)
        Me.lblSubBank.TabIndex = 29
        Me.lblSubBank.Text = "签约支行"
        '
        'lblApplyDate
        '
        Me.lblApplyDate.Location = New System.Drawing.Point(8, 24)
        Me.lblApplyDate.Name = "lblApplyDate"
        Me.lblApplyDate.Size = New System.Drawing.Size(56, 16)
        Me.lblApplyDate.TabIndex = 26
        Me.lblApplyDate.Text = "签约日期"
        '
        'dtpSign_date
        '
        Me.dtpSign_date.Enabled = False
        Me.dtpSign_date.Location = New System.Drawing.Point(96, 22)
        Me.dtpSign_date.Name = "dtpSign_date"
        Me.dtpSign_date.Size = New System.Drawing.Size(144, 21)
        Me.dtpSign_date.TabIndex = 25
        Me.dtpSign_date.TabStop = False
        Me.dtpSign_date.Value = New Date(2003, 6, 27, 0, 0, 0, 0)
        '
        'txtTerms
        '
        Me.txtTerms.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerms.Location = New System.Drawing.Point(336, 70)
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.ReadOnly = True
        Me.txtTerms.Size = New System.Drawing.Size(144, 21)
        Me.txtTerms.TabIndex = 22
        Me.txtTerms.TabStop = False
        Me.txtTerms.Text = ""
        Me.txtTerms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTerms
        '
        Me.lblTerms.Location = New System.Drawing.Point(256, 72)
        Me.lblTerms.Name = "lblTerms"
        Me.lblTerms.Size = New System.Drawing.Size(80, 16)
        Me.lblTerms.TabIndex = 21
        Me.lblTerms.Text = "申请期限(月)"
        '
        'txtSign_sum
        '
        Me.txtSign_sum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtSign_sum.Location = New System.Drawing.Point(96, 70)
        Me.txtSign_sum.Name = "txtSign_sum"
        Me.txtSign_sum.ReadOnly = True
        Me.txtSign_sum.Size = New System.Drawing.Size(144, 21)
        Me.txtSign_sum.TabIndex = 20
        Me.txtSign_sum.TabStop = False
        Me.txtSign_sum.Text = ""
        Me.txtSign_sum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSign_sum
        '
        Me.lblSign_sum.Location = New System.Drawing.Point(8, 72)
        Me.lblSign_sum.Name = "lblSign_sum"
        Me.lblSign_sum.Size = New System.Drawing.Size(96, 16)
        Me.lblSign_sum.TabIndex = 19
        Me.lblSign_sum.Text = "签约金额(万元)"
        '
        'lblBank
        '
        Me.lblBank.Location = New System.Drawing.Point(8, 48)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(56, 16)
        Me.lblBank.TabIndex = 17
        Me.lblBank.Text = "签约银行"
        '
        'txtServiceType
        '
        Me.txtServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtServiceType.Location = New System.Drawing.Point(336, 22)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(144, 21)
        Me.txtServiceType.TabIndex = 16
        Me.txtServiceType.TabStop = False
        Me.txtServiceType.Text = ""
        '
        'lblServiceType
        '
        Me.lblServiceType.Location = New System.Drawing.Point(256, 24)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(56, 16)
        Me.lblServiceType.TabIndex = 15
        Me.lblServiceType.Text = "业务品种"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 6)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 59
        Me.txtProjectCode.TabStop = False
        Me.txtProjectCode.Text = ""
        '
        'txtCorporationName
        '
        Me.txtCorporationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorporationName.Location = New System.Drawing.Point(240, 6)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.ReadOnly = True
        Me.txtCorporationName.Size = New System.Drawing.Size(264, 21)
        Me.txtCorporationName.TabIndex = 60
        Me.txtCorporationName.TabStop = False
        Me.txtCorporationName.Text = ""
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(289, 360)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 56
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grpEndCaseInfo
        '
        Me.grpEndCaseInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtRemark, Me.txtDoubtful_account, Me.dtpEndCase_date, Me.lblRemark, Me.lblDoubtful_account, Me.lblEndCase_date})
        Me.grpEndCaseInfo.Location = New System.Drawing.Point(8, 192)
        Me.grpEndCaseInfo.Name = "grpEndCaseInfo"
        Me.grpEndCaseInfo.Size = New System.Drawing.Size(496, 160)
        Me.grpEndCaseInfo.TabIndex = 62
        Me.grpEndCaseInfo.TabStop = False
        Me.grpEndCaseInfo.Text = "结案信息"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(96, 48)
        Me.txtRemark.MaxLength = 1000
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemark.Size = New System.Drawing.Size(384, 104)
        Me.txtRemark.TabIndex = 62
        Me.txtRemark.Text = ""
        '
        'txtDoubtful_account
        '
        Me.txtDoubtful_account.Location = New System.Drawing.Point(336, 22)
        Me.txtDoubtful_account.MaxLength = 12
        Me.txtDoubtful_account.Name = "txtDoubtful_account"
        Me.txtDoubtful_account.Size = New System.Drawing.Size(144, 21)
        Me.txtDoubtful_account.TabIndex = 60
        Me.txtDoubtful_account.TabStop = False
        Me.txtDoubtful_account.Text = ""
        Me.txtDoubtful_account.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpEndCase_date
        '
        Me.dtpEndCase_date.Location = New System.Drawing.Point(96, 22)
        Me.dtpEndCase_date.Name = "dtpEndCase_date"
        Me.dtpEndCase_date.Size = New System.Drawing.Size(144, 21)
        Me.dtpEndCase_date.TabIndex = 59
        Me.dtpEndCase_date.TabStop = False
        Me.dtpEndCase_date.Value = New Date(2003, 6, 27, 0, 0, 0, 0)
        '
        'lblRemark
        '
        Me.lblRemark.Location = New System.Drawing.Point(8, 56)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(56, 16)
        Me.lblRemark.TabIndex = 2
        Me.lblRemark.Text = "结案说明"
        '
        'lblDoubtful_account
        '
        Me.lblDoubtful_account.Location = New System.Drawing.Point(256, 24)
        Me.lblDoubtful_account.Name = "lblDoubtful_account"
        Me.lblDoubtful_account.Size = New System.Drawing.Size(80, 16)
        Me.lblDoubtful_account.TabIndex = 1
        Me.lblDoubtful_account.Text = "坏帐损失(元)"
        '
        'lblEndCase_date
        '
        Me.lblEndCase_date.Location = New System.Drawing.Point(8, 24)
        Me.lblEndCase_date.Name = "lblEndCase_date"
        Me.lblEndCase_date.Size = New System.Drawing.Size(56, 16)
        Me.lblEndCase_date.TabIndex = 0
        Me.lblEndCase_date.Text = "结案日期"
        '
        'btnSave
        '
        Me.btnSave.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(202, 360)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 63
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDoc
        '
        Me.btnDoc.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnDoc.Image = CType(resources.GetObject("btnDoc.Image"), System.Drawing.Bitmap)
        Me.btnDoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDoc.ImageIndex = 19
        Me.btnDoc.ImageList = Me.ImageListBasic
        Me.btnDoc.Location = New System.Drawing.Point(48, 360)
        Me.btnDoc.Name = "btnDoc"
        Me.btnDoc.Size = New System.Drawing.Size(144, 23)
        Me.btnDoc.TabIndex = 64
        Me.btnDoc.Text = "制作项目结案报告(&M)"
        Me.btnDoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRegisterProjectEndCaseInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(514, 391)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnDoc, Me.lblCorporationName, Me.lblProjectCode, Me.btnExit, Me.btnSave, Me.txtProjectCode, Me.txtCorporationName, Me.btnCommit, Me.grpEndCaseInfo, Me.grpBaseInfo})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRegisterProjectEndCaseInfo"
        Me.Text = "登记项目结案信息"
        Me.grpBaseInfo.ResumeLayout(False)
        Me.grpEndCaseInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected bFormLoad As Boolean = False
    Protected bIsChanged As Boolean = False
    Protected dsTemp As DataSet

    Private Sub FRegisterProjectEndCaseInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.GetData()
            Me.bFormLoad = True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '获取项目结案信息
    Protected Sub GetData()
        Me.txtProjectCode.Text = Me.getProjectCode()
        Me.txtCorporationName.Text = Me.getCorporationName()

        Try
            dsTemp = gWs.GetProjectInfoEx("{projectcode='" & Me.getProjectCode() & "'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                With dsTemp.Tables(0).Rows(0)
                    If Not IsDBNull(.Item("sign_date")) Then
                        Me.dtpSign_date.Value = .Item("sign_date")
                    End If
                    If Not IsDBNull(.Item("sign_sum")) Then
                        Me.txtSign_sum.Text = CGModule.Numeric2Currency(.Item("sign_sum"))         '担保金额
                    End If
                    Me.txtServiceType.Text = IIf(IsDBNull(.Item("ServiceType")), "", .Item("ServiceType"))
                    Me.txtSign_bank_name.Text = IIf(IsDBNull(.Item("sign_bank_name")), "", .Item("sign_bank_name"))
                    Me.txtSign_bank_branch_name.Text = IIf(IsDBNull(.Item("sign_bank_branch_name")), "", .Item("sign_bank_branch_name"))
                    Me.txtTerms.Text = IIf(IsDBNull(.Item("terms")), "", .Item("terms"))
                    Me.txtManager_A.Text = IIf(IsDBNull(.Item("manager_A")), "", .Item("manager_A"))
                    Me.txtManager_B.Text = IIf(IsDBNull(.Item("manager_B")), "", .Item("manager_B"))
                    If Not IsDBNull(.Item("StartTime")) Then
                        Me.dtpStartTime.Value = .Item("StartTime")
                    End If
                    If Not IsDBNull(.Item("overdue_sum")) Then
                        Me.txtOverdue_sum.Text = CGModule.Numeric2Currency(.Item("overdue_sum"))
                    End If
                End With
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try


        Try
            Me.dsTemp = gWs.GetProjectEndCaseInfo("{project_code = '" & Me.getProjectCode() & "'}")
            If Not Me.dsTemp.Tables(0).Rows.Count = 0 Then
                With Me.dsTemp.Tables(0).Rows(0)
                    Me.dtpEndCase_date.Value = IIf(IsDBNull(.Item("endCase_date")), gWs.GetSysTime, .Item("endCase_date")) '结案日期
                    If Not IsDBNull(.Item("doubtful_account")) Then
                        Me.txtDoubtful_account.Text = Numeric2Currency(.Item("doubtful_account"))           '坏账损失
                    End If
                    Me.txtRemark.Text = IIf(IsDBNull(.Item("remark")), "", .Item("remark"))                 '结案说明
                End With
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        AddHandler dtpEndCase_date.TextChanged, AddressOf DataChanged
        AddHandler txtDoubtful_account.TextChanged, AddressOf DataChanged
        AddHandler txtRemark.TextChanged, AddressOf DataChanged

        AddHandler txtDoubtful_account.Enter, AddressOf Money.Money_Enter
        AddHandler txtDoubtful_account.KeyPress, AddressOf Money.Money_KeyPress
        AddHandler txtDoubtful_account.Leave, AddressOf Money.Money_Leave
    End Sub
    '数据改变
    Protected Sub DataChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If Me.bFormLoad Then
            bIsChanged = True
        End If
    End Sub
    '保存项目结案信息
    Protected Function SaveData() As Boolean
        Try
            Me.dsTemp = gWs.GetProjectEndCaseInfo("{project_code = '" & Me.getProjectCode() & "'}")
            If Not Me.dsTemp.Tables(0).Rows.Count = 0 Then
                With Me.dsTemp.Tables(0).Rows(0)
                    .Item("endCase_date") = Me.dtpEndCase_date.Value
                    .Item("doubtful_account") = Currency2Numeric(Me.txtDoubtful_account.Text)
                    .Item("remark") = Me.txtRemark.Text
                End With
            Else
                Dim dr As DataRow = Me.dsTemp.Tables(0).NewRow
                With dr
                    .Item("project_code") = Me.getProjectCode()
                    .Item("endCase_date") = Me.dtpEndCase_date.Value
                    .Item("doubtful_account") = Currency2Numeric(Me.txtDoubtful_account.Text)
                    .Item("remark") = Me.txtRemark.Text
                    .Item("create_person") = UserName
                    .Item("create_date") = gWs.GetSysTime()
                End With
                Me.dsTemp.Tables(0).Rows.Add(dr)
            End If

            Dim strResult As String = gWs.UpdateProjectEndCase(dsTemp)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存项目结案信息败", strResult, "")
                Return False
            Else
                Me.bIsChanged = False
                Return True
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '制作和上载结案报告(暂用项目终止报告)
    Private Sub btnDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDoc.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frm As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "45", "004", UserName)
            frm.AllowTransparency = False
            frm.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '保存按钮
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not Me.SaveData() Then
                Return
            End If
            SWDialogBox.MessageBox.Show("$SaveSucceed")
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '提交按钮
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If SWDialogBox.MessageBox.Show("?1000", "提交") <> MsgBoxResult.Yes Then
            Return
        End If
        Try
            If Not Me.SaveData() Then
                Return
            End If
            Dim strResult As String
            strResult = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), "", UserName)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "")
            Else
                MyBase.raiseCommitSucceed()
                SWDialogBox.MessageBox.Show("$SubmitSucceed")
                Close()
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '退出按钮
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        If Not Me.bIsChanged Then
            Me.Close()
            Return
        End If
        Select Case SWDialogBox.MessageBox.Show("?1003")   '是否保存更改
            Case DialogResult.Yes
                If Not Me.SaveData() Then
                    Return
                End If
                SWDialogBox.MessageBox.Show("$SaveSucceed")
            Case DialogResult.Cancel
                Return
        End Select
        Me.Close()
    End Sub

End Class
