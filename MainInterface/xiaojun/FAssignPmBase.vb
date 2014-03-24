
Public Class FAssignPmBase
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
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Protected WithEvents dtpApplyDate As System.Windows.Forms.DateTimePicker
    Protected WithEvents txtFirstChecker As System.Windows.Forms.TextBox
    Protected WithEvents txtApplyGuaranteeTerm As System.Windows.Forms.TextBox
    Protected WithEvents txtApplyGuaranteeSum As System.Windows.Forms.TextBox
    Protected WithEvents txtApplyServiceType As System.Windows.Forms.TextBox
    Protected WithEvents txtStatus As System.Windows.Forms.TextBox
    Protected WithEvents txtIndustryType As System.Windows.Forms.TextBox
    Protected WithEvents txtEnterpriseType As System.Windows.Forms.TextBox
    Protected WithEvents txtPhase As System.Windows.Forms.TextBox
    Protected WithEvents btnSearch As System.Windows.Forms.Button
    Protected WithEvents btnCommit As System.Windows.Forms.Button
    Protected WithEvents grpBaseInfo As System.Windows.Forms.GroupBox
    Protected WithEvents lblSubBank As System.Windows.Forms.Label
    Protected WithEvents lblApplyDate As System.Windows.Forms.Label
    Protected WithEvents lblFirstChecker As System.Windows.Forms.Label
    Protected WithEvents lblApplyGuaranteeTerm As System.Windows.Forms.Label
    Protected WithEvents lblApplyGuaranteeSum As System.Windows.Forms.Label
    Protected WithEvents lblBank As System.Windows.Forms.Label
    Protected WithEvents lblApplyServiceType As System.Windows.Forms.Label
    Protected WithEvents lblStatus As System.Windows.Forms.Label
    Protected WithEvents lblIndustryType As System.Windows.Forms.Label
    Protected WithEvents lblEnterpriseType As System.Windows.Forms.Label
    Protected WithEvents lblPhase As System.Windows.Forms.Label
    Public WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Public WithEvents lblCorporationName As System.Windows.Forms.Label
    Public WithEvents lblProjectCode As System.Windows.Forms.Label
    Protected WithEvents cboBank As System.Windows.Forms.ComboBox
    Protected WithEvents cboSubBank As System.Windows.Forms.ComboBox
    Protected WithEvents lblPmA As System.Windows.Forms.Label
    Protected WithEvents cboPmB As System.Windows.Forms.ComboBox
    Protected WithEvents lblPmB As System.Windows.Forms.Label
    Protected WithEvents cboPmA As System.Windows.Forms.ComboBox
    Protected WithEvents chkProjectDuty As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FAssignPmBase))
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.lblProjectCode = New System.Windows.Forms.Label()
        Me.grpBaseInfo = New System.Windows.Forms.GroupBox()
        Me.cboSubBank = New System.Windows.Forms.ComboBox()
        Me.cboBank = New System.Windows.Forms.ComboBox()
        Me.lblSubBank = New System.Windows.Forms.Label()
        Me.lblApplyDate = New System.Windows.Forms.Label()
        Me.dtpApplyDate = New System.Windows.Forms.DateTimePicker()
        Me.txtFirstChecker = New System.Windows.Forms.TextBox()
        Me.lblFirstChecker = New System.Windows.Forms.Label()
        Me.txtApplyGuaranteeTerm = New System.Windows.Forms.TextBox()
        Me.lblApplyGuaranteeTerm = New System.Windows.Forms.Label()
        Me.txtApplyGuaranteeSum = New System.Windows.Forms.TextBox()
        Me.lblApplyGuaranteeSum = New System.Windows.Forms.Label()
        Me.lblBank = New System.Windows.Forms.Label()
        Me.txtApplyServiceType = New System.Windows.Forms.TextBox()
        Me.lblApplyServiceType = New System.Windows.Forms.Label()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.txtIndustryType = New System.Windows.Forms.TextBox()
        Me.lblIndustryType = New System.Windows.Forms.Label()
        Me.txtEnterpriseType = New System.Windows.Forms.TextBox()
        Me.lblEnterpriseType = New System.Windows.Forms.Label()
        Me.txtPhase = New System.Windows.Forms.TextBox()
        Me.lblPhase = New System.Windows.Forms.Label()
        Me.lblPmA = New System.Windows.Forms.Label()
        Me.cboPmB = New System.Windows.Forms.ComboBox()
        Me.lblPmB = New System.Windows.Forms.Label()
        Me.cboPmA = New System.Windows.Forms.ComboBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.chkProjectDuty = New System.Windows.Forms.CheckBox()
        Me.grpBaseInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(307, 272)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Visible = True
        '
        'txtCorporationName
        '
        Me.txtCorporationName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorporationName.Location = New System.Drawing.Point(256, 8)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.ReadOnly = True
        Me.txtCorporationName.Size = New System.Drawing.Size(256, 21)
        Me.txtCorporationName.TabIndex = 8
        Me.txtCorporationName.TabStop = False
        Me.txtCorporationName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(88, 8)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 7
        Me.txtProjectCode.TabStop = False
        Me.txtProjectCode.Text = ""
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Location = New System.Drawing.Point(192, 11)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(54, 16)
        Me.lblCorporationName.TabIndex = 6
        Me.lblCorporationName.Text = "企业名称"
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Location = New System.Drawing.Point(16, 8)
        Me.lblProjectCode.Name = "lblProjectCode"
        Me.lblProjectCode.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectCode.TabIndex = 5
        Me.lblProjectCode.Text = "项目编码"
        '
        'grpBaseInfo
        '
        Me.grpBaseInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboSubBank, Me.cboBank, Me.lblSubBank, Me.lblApplyDate, Me.dtpApplyDate, Me.txtFirstChecker, Me.lblFirstChecker, Me.txtApplyGuaranteeTerm, Me.lblApplyGuaranteeTerm, Me.txtApplyGuaranteeSum, Me.lblApplyGuaranteeSum, Me.lblBank, Me.txtApplyServiceType, Me.lblApplyServiceType, Me.txtStatus, Me.lblStatus, Me.txtIndustryType, Me.lblIndustryType, Me.txtEnterpriseType, Me.lblEnterpriseType, Me.txtPhase, Me.lblPhase})
        Me.grpBaseInfo.Location = New System.Drawing.Point(8, 32)
        Me.grpBaseInfo.Name = "grpBaseInfo"
        Me.grpBaseInfo.Size = New System.Drawing.Size(504, 176)
        Me.grpBaseInfo.TabIndex = 11
        Me.grpBaseInfo.TabStop = False
        Me.grpBaseInfo.Text = "项目基本信息"
        '
        'cboSubBank
        '
        Me.cboSubBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSubBank.Enabled = False
        Me.cboSubBank.Location = New System.Drawing.Point(344, 94)
        Me.cboSubBank.Name = "cboSubBank"
        Me.cboSubBank.Size = New System.Drawing.Size(144, 20)
        Me.cboSubBank.TabIndex = 32
        Me.cboSubBank.TabStop = False
        '
        'cboBank
        '
        Me.cboBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBank.Enabled = False
        Me.cboBank.Location = New System.Drawing.Point(96, 94)
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(152, 20)
        Me.cboBank.TabIndex = 31
        Me.cboBank.TabStop = False
        '
        'lblSubBank
        '
        Me.lblSubBank.Location = New System.Drawing.Point(264, 96)
        Me.lblSubBank.Name = "lblSubBank"
        Me.lblSubBank.Size = New System.Drawing.Size(54, 16)
        Me.lblSubBank.TabIndex = 29
        Me.lblSubBank.Text = "申请支行"
        '
        'lblApplyDate
        '
        Me.lblApplyDate.Location = New System.Drawing.Point(8, 72)
        Me.lblApplyDate.Name = "lblApplyDate"
        Me.lblApplyDate.Size = New System.Drawing.Size(56, 16)
        Me.lblApplyDate.TabIndex = 26
        Me.lblApplyDate.Text = "申请日期"
        '
        'dtpApplyDate
        '
        Me.dtpApplyDate.Enabled = False
        Me.dtpApplyDate.Location = New System.Drawing.Point(96, 70)
        Me.dtpApplyDate.Name = "dtpApplyDate"
        Me.dtpApplyDate.Size = New System.Drawing.Size(152, 21)
        Me.dtpApplyDate.TabIndex = 25
        Me.dtpApplyDate.TabStop = False
        Me.dtpApplyDate.Value = New Date(2003, 6, 27, 0, 0, 0, 0)
        '
        'txtFirstChecker
        '
        Me.txtFirstChecker.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFirstChecker.Location = New System.Drawing.Point(96, 142)
        Me.txtFirstChecker.Name = "txtFirstChecker"
        Me.txtFirstChecker.ReadOnly = True
        Me.txtFirstChecker.Size = New System.Drawing.Size(152, 21)
        Me.txtFirstChecker.TabIndex = 24
        Me.txtFirstChecker.TabStop = False
        Me.txtFirstChecker.Text = ""
        '
        'lblFirstChecker
        '
        Me.lblFirstChecker.Location = New System.Drawing.Point(8, 144)
        Me.lblFirstChecker.Name = "lblFirstChecker"
        Me.lblFirstChecker.Size = New System.Drawing.Size(56, 16)
        Me.lblFirstChecker.TabIndex = 23
        Me.lblFirstChecker.Text = "初审人员"
        '
        'txtApplyGuaranteeTerm
        '
        Me.txtApplyGuaranteeTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyGuaranteeTerm.Location = New System.Drawing.Point(344, 118)
        Me.txtApplyGuaranteeTerm.Name = "txtApplyGuaranteeTerm"
        Me.txtApplyGuaranteeTerm.ReadOnly = True
        Me.txtApplyGuaranteeTerm.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyGuaranteeTerm.TabIndex = 22
        Me.txtApplyGuaranteeTerm.TabStop = False
        Me.txtApplyGuaranteeTerm.Text = ""
        Me.txtApplyGuaranteeTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblApplyGuaranteeTerm
        '
        Me.lblApplyGuaranteeTerm.Location = New System.Drawing.Point(264, 120)
        Me.lblApplyGuaranteeTerm.Name = "lblApplyGuaranteeTerm"
        Me.lblApplyGuaranteeTerm.Size = New System.Drawing.Size(80, 16)
        Me.lblApplyGuaranteeTerm.TabIndex = 21
        Me.lblApplyGuaranteeTerm.Text = "申请期限(月)"
        '
        'txtApplyGuaranteeSum
        '
        Me.txtApplyGuaranteeSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyGuaranteeSum.Location = New System.Drawing.Point(96, 118)
        Me.txtApplyGuaranteeSum.Name = "txtApplyGuaranteeSum"
        Me.txtApplyGuaranteeSum.ReadOnly = True
        Me.txtApplyGuaranteeSum.Size = New System.Drawing.Size(152, 21)
        Me.txtApplyGuaranteeSum.TabIndex = 20
        Me.txtApplyGuaranteeSum.TabStop = False
        Me.txtApplyGuaranteeSum.Text = ""
        Me.txtApplyGuaranteeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblApplyGuaranteeSum
        '
        Me.lblApplyGuaranteeSum.Location = New System.Drawing.Point(8, 120)
        Me.lblApplyGuaranteeSum.Name = "lblApplyGuaranteeSum"
        Me.lblApplyGuaranteeSum.Size = New System.Drawing.Size(96, 16)
        Me.lblApplyGuaranteeSum.TabIndex = 19
        Me.lblApplyGuaranteeSum.Text = "申请金额(万元)"
        '
        'lblBank
        '
        Me.lblBank.Location = New System.Drawing.Point(8, 96)
        Me.lblBank.Name = "lblBank"
        Me.lblBank.Size = New System.Drawing.Size(56, 16)
        Me.lblBank.TabIndex = 17
        Me.lblBank.Text = "申请银行"
        '
        'txtApplyServiceType
        '
        Me.txtApplyServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtApplyServiceType.Location = New System.Drawing.Point(344, 70)
        Me.txtApplyServiceType.Name = "txtApplyServiceType"
        Me.txtApplyServiceType.ReadOnly = True
        Me.txtApplyServiceType.Size = New System.Drawing.Size(144, 21)
        Me.txtApplyServiceType.TabIndex = 16
        Me.txtApplyServiceType.TabStop = False
        Me.txtApplyServiceType.Text = ""
        '
        'lblApplyServiceType
        '
        Me.lblApplyServiceType.Location = New System.Drawing.Point(264, 72)
        Me.lblApplyServiceType.Name = "lblApplyServiceType"
        Me.lblApplyServiceType.Size = New System.Drawing.Size(79, 16)
        Me.lblApplyServiceType.TabIndex = 15
        Me.lblApplyServiceType.Text = "申请业务品种"
        '
        'txtStatus
        '
        Me.txtStatus.BackColor = System.Drawing.Color.Gainsboro
        Me.txtStatus.Location = New System.Drawing.Point(344, 46)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(144, 21)
        Me.txtStatus.TabIndex = 14
        Me.txtStatus.TabStop = False
        Me.txtStatus.Text = ""
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(264, 48)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(48, 16)
        Me.lblStatus.TabIndex = 13
        Me.lblStatus.Text = " 状 态 "
        '
        'txtIndustryType
        '
        Me.txtIndustryType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtIndustryType.Location = New System.Drawing.Point(96, 22)
        Me.txtIndustryType.Name = "txtIndustryType"
        Me.txtIndustryType.ReadOnly = True
        Me.txtIndustryType.Size = New System.Drawing.Size(152, 21)
        Me.txtIndustryType.TabIndex = 3
        Me.txtIndustryType.TabStop = False
        Me.txtIndustryType.Text = ""
        '
        'lblIndustryType
        '
        Me.lblIndustryType.Location = New System.Drawing.Point(8, 24)
        Me.lblIndustryType.Name = "lblIndustryType"
        Me.lblIndustryType.Size = New System.Drawing.Size(54, 16)
        Me.lblIndustryType.TabIndex = 2
        Me.lblIndustryType.Text = "行业类型"
        '
        'txtEnterpriseType
        '
        Me.txtEnterpriseType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEnterpriseType.Location = New System.Drawing.Point(344, 22)
        Me.txtEnterpriseType.Name = "txtEnterpriseType"
        Me.txtEnterpriseType.ReadOnly = True
        Me.txtEnterpriseType.Size = New System.Drawing.Size(144, 21)
        Me.txtEnterpriseType.TabIndex = 1
        Me.txtEnterpriseType.TabStop = False
        Me.txtEnterpriseType.Text = ""
        '
        'lblEnterpriseType
        '
        Me.lblEnterpriseType.Location = New System.Drawing.Point(264, 24)
        Me.lblEnterpriseType.Name = "lblEnterpriseType"
        Me.lblEnterpriseType.Size = New System.Drawing.Size(56, 16)
        Me.lblEnterpriseType.TabIndex = 0
        Me.lblEnterpriseType.Text = "企业类型"
        '
        'txtPhase
        '
        Me.txtPhase.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPhase.Location = New System.Drawing.Point(96, 46)
        Me.txtPhase.Name = "txtPhase"
        Me.txtPhase.ReadOnly = True
        Me.txtPhase.Size = New System.Drawing.Size(152, 21)
        Me.txtPhase.TabIndex = 12
        Me.txtPhase.TabStop = False
        Me.txtPhase.Text = ""
        '
        'lblPhase
        '
        Me.lblPhase.Location = New System.Drawing.Point(8, 48)
        Me.lblPhase.Name = "lblPhase"
        Me.lblPhase.Size = New System.Drawing.Size(48, 16)
        Me.lblPhase.TabIndex = 11
        Me.lblPhase.Text = " 阶 段 "
        '
        'lblPmA
        '
        Me.lblPmA.Location = New System.Drawing.Point(16, 218)
        Me.lblPmA.Name = "lblPmA"
        Me.lblPmA.Size = New System.Drawing.Size(60, 16)
        Me.lblPmA.TabIndex = 27
        Me.lblPmA.Text = "项目经理A"
        '
        'cboPmB
        '
        Me.cboPmB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPmB.Location = New System.Drawing.Point(352, 216)
        Me.cboPmB.Name = "cboPmB"
        Me.cboPmB.Size = New System.Drawing.Size(144, 20)
        Me.cboPmB.TabIndex = 1
        '
        'lblPmB
        '
        Me.lblPmB.Location = New System.Drawing.Point(272, 218)
        Me.lblPmB.Name = "lblPmB"
        Me.lblPmB.Size = New System.Drawing.Size(60, 16)
        Me.lblPmB.TabIndex = 25
        Me.lblPmB.Text = "项目经理B"
        '
        'cboPmA
        '
        Me.cboPmA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPmA.Location = New System.Drawing.Point(104, 216)
        Me.cboPmA.Name = "cboPmA"
        Me.cboPmA.Size = New System.Drawing.Size(152, 20)
        Me.cboPmA.TabIndex = 0
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Bitmap)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.ImageIndex = 3
        Me.btnSearch.ImageList = Me.ImageListBasic
        Me.btnSearch.Location = New System.Drawing.Point(139, 272)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(77, 23)
        Me.btnSearch.TabIndex = 2
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
        Me.btnCommit.Location = New System.Drawing.Point(223, 272)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 3
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkProjectDuty
        '
        Me.chkProjectDuty.Location = New System.Drawing.Point(16, 240)
        Me.chkProjectDuty.Name = "chkProjectDuty"
        Me.chkProjectDuty.Size = New System.Drawing.Size(144, 24)
        Me.chkProjectDuty.TabIndex = 28
        Me.chkProjectDuty.Text = "项目责任人"
        '
        'FAssignPmBase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(522, 303)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkProjectDuty, Me.lblPmA, Me.lblPmB, Me.lblCorporationName, Me.lblProjectCode, Me.btnExit, Me.btnSearch, Me.btnCommit, Me.cboPmB, Me.cboPmA, Me.grpBaseInfo, Me.txtCorporationName, Me.txtProjectCode})
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FAssignPmBase"
        Me.Text = "分配项目经理"
        Me.grpBaseInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected dsBank As DataSet  '用于存放银行信息

    'Private Sub FAssignPmBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Try
    '        Me.Cursor = Cursors.WaitCursor
    '        Me.GetDate()
    '        Me.GetPMData()
    '    Catch ex As Exception
    '        ExceptionHandler.ShowMessageBox(ex)
    '    Finally
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Sub

    '获取基本数据
    Protected Overridable Sub GetDate()
        Me.txtProjectCode.Text = Me.getProjectCode()
        Me.txtCorporationName.Text = Me.getCorporationName()
        Dim dsTemp As DataSet
        Try
            dsTemp = gWs.GetcorporationInfo("{corporation_name='" & Me.getCorporationName() & "'}", "null")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                With dsTemp.Tables(0).Rows(0)
                    If Not .Item("industry_type") Is System.DBNull.Value Then
                        Me.txtIndustryType.Text = .Item("industry_type")         '行业类型
                    End If
                    If Not .Item("proprietorship_type") Is System.DBNull.Value Then
                        Me.txtEnterpriseType.Text = .Item("proprietorship_type") '企业类型
                    End If
                End With
            End If
            '初始化银行的ComboBox
            dsBank = gWs.GetBankInfo("%", "%")
            Me.cboBank.DataSource = dsBank.Tables("bank")
            Me.cboBank.DisplayMember = "bank_name"
            Me.cboBank.ValueMember = "bank_code"
            Me.cboSubBank.DataSource = dsBank.Tables("bank_branch").DefaultView
            Me.cboSubBank.DisplayMember = "branch_bank_name"
            Me.cboSubBank.ValueMember = "branch_bank_code"
            Me.BankChanged()

            dsTemp = gWs.GetProjectInfo("{project_code='" & Me.getProjectCode() & "'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                With dsTemp.Tables(0).Rows(0)
                    If Not .Item("phase") Is System.DBNull.Value Then
                        Me.txtPhase.Text = .Item("phase")                  '阶段
                    End If
                    If Not .Item("status") Is System.DBNull.Value Then
                        Me.txtStatus.Text = .Item("status")                '状态
                    End If
                    If Not .Item("apply_sum") Is System.DBNull.Value Then
                        Me.txtApplyGuaranteeSum.Text = .Item("apply_sum")  '申请金额
                    End If
                    If Not .Item("apply_term") Is System.DBNull.Value Then
                        Me.txtApplyGuaranteeTerm.Text = .Item("apply_term") '申请期限
                    End If
                    If Not .Item("apply_date") Is System.DBNull.Value Then
                        Me.dtpApplyDate.Value = .Item("apply_date")         '申请时间
                    End If
                    If Not .Item("apply_service_type") Is System.DBNull.Value Then
                        Me.txtApplyServiceType.Text = .Item("apply_service_type") '申请业务品种
                    End If
                    If Not .Item("apply_bank") Is System.DBNull.Value Then
                        Me.cboBank.SelectedValue = .Item("apply_bank")      '申请银行
                        Me.BankChanged()
                    End If
                    If Not .Item("apply_branch_bank") Is System.DBNull.Value Then
                        Me.cboSubBank.SelectedValue = .Item("apply_branch_bank") '申请支行
                    End If
                End With
            End If
            dsTemp = gWs.FetchProjectCorporation(Me.getProjectCode(), "%", "%", "%")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                With dsTemp.Tables(0).Rows(0)
                    If Not .Item("create_person") Is System.DBNull.Value Then
                        Me.txtFirstChecker.Text = .Item("create_person")    '初审人员
                    End If
                End With
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '根据cboBank的值改变cboSubBank的值
    Protected Sub BankChanged()
        dsBank.Tables("bank_branch").DefaultView.RowFilter = "bank_code='" & Me.cboBank.SelectedValue & "'"
    End Sub

    '初始化项目经理A和项目经理B的的ComboBox
    Protected Overridable Sub GetPMData()
        Dim dsTemp As DataSet
        dsTemp = gWs.GetProjectTaskAttendeeInfo("{project_code='" & Me.getProjectCode() & "' AND role_id='22'}")
        If Not dsTemp.Tables(0).Rows.Count = 0 Then              '分配项目组的情况
            Dim strTeamName = dsTemp.Tables(0).Rows(0).Item("attend_person")
            dsTemp = gWs.GetStaffEX("{team_name='" & strTeamName & "'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                Me.cboPmA.DataSource = dsTemp.Tables(0)
                Me.cboPmA.DisplayMember = "staff_name"
                Dim tbl As DataTable = dsTemp.Tables(0).Copy()
                dsTemp = gWs.GetDefaultPerson(Me.getProjectCode(), "24")
                If Not dsTemp.Tables(0).Rows.Count = 0 AndAlso Not IsDBNull(dsTemp.Tables(0).Rows(0).Item("Person")) Then
                    Me.cboPmA.SelectedIndex = Me.cboPmA.FindString(dsTemp.Tables(0).Rows(0).Item("Person"))
                End If

                Dim dr As DataRow = tbl.NewRow()
                dr("staff_name") = ""  '项目经理B的ComboBox增加一个为空的项
                tbl.Rows.Add(dr)
                Me.cboPmB.DataSource = tbl
                Me.cboPmB.DisplayMember = "staff_name"
                dsTemp = gWs.GetDefaultPerson(Me.getProjectCode(), "25")
                If Not dsTemp.Tables(0).Rows.Count = 0 AndAlso Not IsDBNull(dsTemp.Tables(0).Rows(0).Item("Person")) Then
                    Me.cboPmB.SelectedIndex = Me.cboPmB.FindString(dsTemp.Tables(0).Rows(0).Item("Person"))
                End If

            End If
        Else                                                      '不是分配项目组的情况
            Dim dtTemp As DataTable
            dtTemp = MdlGlobal.GetPerson(Me.getProjectCode(), "24")
            Me.cboPmA.DataSource = dtTemp
            Me.cboPmA.DisplayMember = "staff_name"
            dtTemp = MdlGlobal.GetPerson(Me.getProjectCode(), "25")
            Me.cboPmB.DataSource = dtTemp
            Me.cboPmB.DisplayMember = "staff_name"

            'get the default peson
            dsTemp = gWs.GetDefaultPerson(Me.getProjectCode(), "24")
            If Not dsTemp.Tables(0).Rows.Count = 0 AndAlso Not IsDBNull(dsTemp.Tables(0).Rows(0).Item("Person")) Then
                Me.cboPmA.SelectedIndex = Me.cboPmA.FindString(dsTemp.Tables(0).Rows(0).Item("Person"))
            End If
            If Not dsTemp.Tables(0).Rows.Count = 0 AndAlso Not IsDBNull(dsTemp.Tables(0).Rows(0).Item("Person")) Then
                Me.cboPmB.SelectedIndex = Me.cboPmB.FindString(dsTemp.Tables(0).Rows(0).Item("Person"))
            End If
        End If
    End Sub

    '保存
    Protected Overridable Function SaveDate() As Boolean
        Try
            Dim dsTemp As DataSet
            dsTemp = gWs.GetProjectInfoEx("{projectcode ='" & Me.getProjectCode() & "'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                If dsTemp.Tables(0).Rows(0).Item("applyservicetype") = "委托评审" Then
                    If Me.cboPmA.Text = "" Then
                        'MessageBox.Show("项目经理A不能为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        SWDialogBox.MessageBox.Show("$1001", "项目经理A")
                        Me.cboPmA.Focus()
                        Return False
                    End If
                Else
                    If Me.cboPmA.Text = "" Or Me.cboPmB.Text = "" Then
                        'MessageBox.Show("项目经理A或者项目经理B不能为空。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        SWDialogBox.MessageBox.Show("$1001", "项目经理A或者项目经理B")
                        CType(IIf(Me.cboBank.SelectedValue Is Nothing, Me.cboBank, Me.cboSubBank), ComboBox).Focus()
                        Return False
                    End If
                End If
            End If

            If String.Equals(Me.cboPmA.Text, Me.cboPmB.Text) Then
                'MessageBox.Show("项目经理A或者项目经理B不能为同一人。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                SWDialogBox.MessageBox.Show("$1003", "项目经理A或者项目经理B")
                Return False
            End If

            'added by hute 2004/6/10
            Dim dr As DataRow
            Dim strResult As String
            dsTemp = gWs.GetProjectResponsibleInfo("{project_code = '" & Me.getProjectCode() & "'}")
            If dsTemp.Tables(0).Rows.Count = 0 Then
                dr = dsTemp.Tables(0).NewRow
                dr("project_code") = Me.getProjectCode()
                dr("manager_A") = Me.cboPmA.Text
                dr("manager_B") = Me.cboPmB.Text
                dr("create_person") = UserName
                dr("create_date") = gWs.GetSysTime()
                dsTemp.Tables(0).Rows.Add(dr)
            ElseIf Me.chkProjectDuty.Checked Then
                With dsTemp.Tables(0).Rows(0)
                    .Item("project_code") = Me.getProjectCode()
                    .Item("manager_A") = Me.cboPmA.Text
                    .Item("manager_B") = Me.cboPmB.Text
                    .Item("create_person") = UserName
                    .Item("create_date") = gWs.GetSysTime()
                End With
            End If
            strResult = gWs.UpdateProjectResponsible(dsTemp)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "更新项目责任人失败", strResult, "")
                Return 0
            End If
            'added ended

            Dim i As Integer
            Dim nowDate As Date = gWs.GetSysTime()
            dsTemp = gWs.GetProjectTaskAttendeeInfo("{project_code='" & Me.getProjectCode() & "' AND role_id='24'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                For i = 0 To dsTemp.Tables(0).Rows.Count - 1
                    dsTemp.Tables(0).Rows(i).Item("attend_person") = Workflow.GetRealTaskAttendee("24", Me.cboPmA.Text) '项目经理A
                    dsTemp.Tables(0).Rows(i).Item("create_date") = nowDate
                Next
            End If

            strResult = gWs.UpdateProjectTaskAttendee(dsTemp)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "记录更新项目经理A失败", strResult, "")
                Return False
            End If
            dsTemp = gWs.GetProjectTaskAttendeeInfo("{project_code='" & Me.getProjectCode() & "' AND role_id='25'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                For i = 0 To dsTemp.Tables(0).Rows.Count - 1
                    dsTemp.Tables(0).Rows(i).Item("attend_person") = Workflow.GetRealTaskAttendee("25", Me.cboPmB.Text) '项目经理B
                    dsTemp.Tables(0).Rows(i).Item("create_date") = nowDate
                Next
            End If
            strResult = gWs.UpdateProjectTaskAttendee(dsTemp)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "记录更新项目经理B失败", strResult, "")
                Return False
            End If

            '更新项目表中managerTeam_name字段
            dsTemp = gWs.GetProjectInfo("{project_code='" & Me.getProjectCode() & "'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                With dsTemp.Tables(0).Rows(0)
                    .Item("managerTeam_name") = getStaffTeamName(Me.cboPmA.Text)
                End With
            End If
            strResult = gWs.UpdateProject(dsTemp)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "更新项目表失败", strResult, "")
                Return False
            End If

            Return True
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    '查询工作任务
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frm As New frmQueryCurrentTask("24", Me.cboPmA.Text, "项目评审") '查询当前工作任务
            frm.AllowTransparency = False
            frm.ProjectCode = Me.getProjectCode()
            frm.TaskID = Me.getTaskID()
            frm.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    '提交操作
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            'MessageBox.Show("确定提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交")
            If answer = DialogResult.No Then
                Return
            End If
        End If
        If Not Me.SaveDate() Then  '保存
            Return
        End If
        Dim strResult As String
        strResult = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), "", UserName)
        If strResult = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            MyBase.raiseCommitSucceed()
            Me.Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "")
        End If
    End Sub

End Class
