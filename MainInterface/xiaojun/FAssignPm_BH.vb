

Public Class FAssignPm_BH
    Inherits MainInterface.FAssignPmBase

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
    Friend WithEvents lblWorkflow As System.Windows.Forms.Label
    Friend WithEvents lblPurpose As System.Windows.Forms.Label
    Friend WithEvents grpBH_type As System.Windows.Forms.GroupBox
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents txtRecommendPerson As System.Windows.Forms.TextBox
    Friend WithEvents lblRecommendPerson As System.Windows.Forms.Label
    Friend WithEvents lblGuaranteeLetterType As System.Windows.Forms.Label
    Friend WithEvents lblReimburseType As System.Windows.Forms.Label
    Friend WithEvents lblBeneficiary As System.Windows.Forms.Label
    Friend WithEvents txtWorkflow As System.Windows.Forms.TextBox
    Friend WithEvents txtBeneficiary As System.Windows.Forms.TextBox
    Friend WithEvents cboReimburseType As System.Windows.Forms.ComboBox
    Friend WithEvents cboGuaranteeLetterType As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FAssignPm_BH))
        Me.lblGuaranteeLetterType = New System.Windows.Forms.Label
        Me.lblReimburseType = New System.Windows.Forms.Label
        Me.lblWorkflow = New System.Windows.Forms.Label
        Me.lblPurpose = New System.Windows.Forms.Label
        Me.lblBeneficiary = New System.Windows.Forms.Label
        Me.grpBH_type = New System.Windows.Forms.GroupBox
        Me.txtWorkflow = New System.Windows.Forms.TextBox
        Me.txtBeneficiary = New System.Windows.Forms.TextBox
        Me.cboGuaranteeLetterType = New System.Windows.Forms.ComboBox
        Me.cboReimburseType = New System.Windows.Forms.ComboBox
        Me.txtPurpose = New System.Windows.Forms.TextBox
        Me.txtRecommendPerson = New System.Windows.Forms.TextBox
        Me.lblRecommendPerson = New System.Windows.Forms.Label
        Me.grpBaseInfo.SuspendLayout()
        Me.grpBH_type.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Name = "txtProjectCode"
        '
        'txtStatus
        '
        Me.txtStatus.Name = "txtStatus"
        '
        'cboBank
        '
        Me.cboBank.ItemHeight = 12
        Me.cboBank.Name = "cboBank"
        Me.cboBank.Size = New System.Drawing.Size(152, 20)
        '
        'lblIndustryType
        '
        Me.lblIndustryType.Name = "lblIndustryType"
        '
        'txtApplyGuaranteeSum
        '
        Me.txtApplyGuaranteeSum.Name = "txtApplyGuaranteeSum"
        '
        'lblApplyGuaranteeTerm
        '
        Me.lblApplyGuaranteeTerm.Name = "lblApplyGuaranteeTerm"
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Name = "lblCorporationName"
        '
        'lblPmB
        '
        Me.lblPmB.Location = New System.Drawing.Point(272, 362)
        Me.lblPmB.Name = "lblPmB"
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(221, 408)
        Me.btnCommit.Name = "btnCommit"
        '
        'lblStatus
        '
        Me.lblStatus.Name = "lblStatus"
        '
        'lblFirstChecker
        '
        Me.lblFirstChecker.Name = "lblFirstChecker"
        '
        'txtIndustryType
        '
        Me.txtIndustryType.Name = "txtIndustryType"
        '
        'cboSubBank
        '
        Me.cboSubBank.ItemHeight = 12
        Me.cboSubBank.Name = "cboSubBank"
        Me.cboSubBank.Size = New System.Drawing.Size(144, 20)
        '
        'grpBaseInfo
        '
        Me.grpBaseInfo.Controls.Add(Me.lblPurpose)
        Me.grpBaseInfo.Controls.Add(Me.txtRecommendPerson)
        Me.grpBaseInfo.Controls.Add(Me.txtPurpose)
        Me.grpBaseInfo.Controls.Add(Me.lblRecommendPerson)
        Me.grpBaseInfo.Name = "grpBaseInfo"
        Me.grpBaseInfo.Size = New System.Drawing.Size(504, 232)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.lblRecommendPerson, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.txtPurpose, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.txtRecommendPerson, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.lblPurpose, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.lblPhase, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.txtPhase, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.lblEnterpriseType, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.txtEnterpriseType, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.lblIndustryType, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.txtIndustryType, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.lblStatus, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.txtStatus, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.lblApplyServiceType, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.txtApplyServiceType, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.lblBank, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.lblApplyGuaranteeSum, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.txtApplyGuaranteeSum, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.lblApplyGuaranteeTerm, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.txtApplyGuaranteeTerm, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.lblFirstChecker, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.txtFirstChecker, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.dtpApplyDate, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.lblApplyDate, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.lblSubBank, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.cboBank, 0)
        Me.grpBaseInfo.Controls.SetChildIndex(Me.cboSubBank, 0)
        '
        'lblApplyDate
        '
        Me.lblApplyDate.Name = "lblApplyDate"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(133, 408)
        Me.btnSearch.Name = "btnSearch"
        '
        'dtpApplyDate
        '
        Me.dtpApplyDate.Name = "dtpApplyDate"
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Name = "lblProjectCode"
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Name = "txtCorporationName"
        '
        'lblPmA
        '
        Me.lblPmA.Location = New System.Drawing.Point(24, 362)
        Me.lblPmA.Name = "lblPmA"
        '
        'lblEnterpriseType
        '
        Me.lblEnterpriseType.Name = "lblEnterpriseType"
        '
        'chkProjectDuty
        '
        Me.chkProjectDuty.Checked = True
        Me.chkProjectDuty.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkProjectDuty.Location = New System.Drawing.Point(24, 384)
        Me.chkProjectDuty.Name = "chkProjectDuty"
        '
        'txtEnterpriseType
        '
        Me.txtEnterpriseType.Name = "txtEnterpriseType"
        '
        'lblBank
        '
        Me.lblBank.Name = "lblBank"
        '
        'txtApplyGuaranteeTerm
        '
        Me.txtApplyGuaranteeTerm.Name = "txtApplyGuaranteeTerm"
        '
        'cboPmB
        '
        Me.cboPmB.ItemHeight = 12
        Me.cboPmB.Location = New System.Drawing.Point(352, 360)
        Me.cboPmB.Name = "cboPmB"
        '
        'lblSubBank
        '
        Me.lblSubBank.Name = "lblSubBank"
        '
        'cboPmA
        '
        Me.cboPmA.ItemHeight = 12
        Me.cboPmA.Location = New System.Drawing.Point(104, 360)
        Me.cboPmA.Name = "cboPmA"
        '
        'txtApplyServiceType
        '
        Me.txtApplyServiceType.Name = "txtApplyServiceType"
        '
        'txtFirstChecker
        '
        Me.txtFirstChecker.Name = "txtFirstChecker"
        '
        'lblApplyServiceType
        '
        Me.lblApplyServiceType.Name = "lblApplyServiceType"
        '
        'lblPhase
        '
        Me.lblPhase.Name = "lblPhase"
        '
        'txtPhase
        '
        Me.txtPhase.Name = "txtPhase"
        '
        'lblApplyGuaranteeSum
        '
        Me.lblApplyGuaranteeSum.Name = "lblApplyGuaranteeSum"
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(309, 408)
        Me.btnExit.Name = "btnExit"
        '
        'lblGuaranteeLetterType
        '
        Me.lblGuaranteeLetterType.Location = New System.Drawing.Point(264, 24)
        Me.lblGuaranteeLetterType.Name = "lblGuaranteeLetterType"
        Me.lblGuaranteeLetterType.Size = New System.Drawing.Size(56, 16)
        Me.lblGuaranteeLetterType.TabIndex = 30
        Me.lblGuaranteeLetterType.Text = "保函种类"
        '
        'lblReimburseType
        '
        Me.lblReimburseType.Location = New System.Drawing.Point(8, 48)
        Me.lblReimburseType.Name = "lblReimburseType"
        Me.lblReimburseType.Size = New System.Drawing.Size(80, 16)
        Me.lblReimburseType.TabIndex = 34
        Me.lblReimburseType.Text = "偿付责任类型"
        '
        'lblWorkflow
        '
        Me.lblWorkflow.Location = New System.Drawing.Point(8, 24)
        Me.lblWorkflow.Name = "lblWorkflow"
        Me.lblWorkflow.Size = New System.Drawing.Size(54, 16)
        Me.lblWorkflow.TabIndex = 37
        Me.lblWorkflow.Text = "运作方式"
        '
        'lblPurpose
        '
        Me.lblPurpose.AutoSize = True
        Me.lblPurpose.Location = New System.Drawing.Point(8, 176)
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.Size = New System.Drawing.Size(42, 17)
        Me.lblPurpose.TabIndex = 40
        Me.lblPurpose.Text = " 用 途"
        '
        'lblBeneficiary
        '
        Me.lblBeneficiary.Location = New System.Drawing.Point(264, 48)
        Me.lblBeneficiary.Name = "lblBeneficiary"
        Me.lblBeneficiary.Size = New System.Drawing.Size(64, 16)
        Me.lblBeneficiary.TabIndex = 41
        Me.lblBeneficiary.Text = "受益人名称"
        '
        'grpBH_type
        '
        Me.grpBH_type.Controls.Add(Me.txtWorkflow)
        Me.grpBH_type.Controls.Add(Me.txtBeneficiary)
        Me.grpBH_type.Controls.Add(Me.cboGuaranteeLetterType)
        Me.grpBH_type.Controls.Add(Me.cboReimburseType)
        Me.grpBH_type.Controls.Add(Me.lblWorkflow)
        Me.grpBH_type.Controls.Add(Me.lblGuaranteeLetterType)
        Me.grpBH_type.Controls.Add(Me.lblReimburseType)
        Me.grpBH_type.Controls.Add(Me.lblBeneficiary)
        Me.grpBH_type.Location = New System.Drawing.Point(8, 272)
        Me.grpBH_type.Name = "grpBH_type"
        Me.grpBH_type.Size = New System.Drawing.Size(504, 80)
        Me.grpBH_type.TabIndex = 42
        Me.grpBH_type.TabStop = False
        Me.grpBH_type.Text = "保函品种信息"
        '
        'txtWorkflow
        '
        Me.txtWorkflow.BackColor = System.Drawing.Color.Gainsboro
        Me.txtWorkflow.Location = New System.Drawing.Point(96, 21)
        Me.txtWorkflow.Name = "txtWorkflow"
        Me.txtWorkflow.ReadOnly = True
        Me.txtWorkflow.Size = New System.Drawing.Size(152, 21)
        Me.txtWorkflow.TabIndex = 45
        Me.txtWorkflow.TabStop = False
        Me.txtWorkflow.Text = ""
        '
        'txtBeneficiary
        '
        Me.txtBeneficiary.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBeneficiary.Location = New System.Drawing.Point(344, 48)
        Me.txtBeneficiary.Name = "txtBeneficiary"
        Me.txtBeneficiary.ReadOnly = True
        Me.txtBeneficiary.Size = New System.Drawing.Size(144, 21)
        Me.txtBeneficiary.TabIndex = 44
        Me.txtBeneficiary.TabStop = False
        Me.txtBeneficiary.Text = ""
        '
        'cboGuaranteeLetterType
        '
        Me.cboGuaranteeLetterType.Enabled = False
        Me.cboGuaranteeLetterType.Location = New System.Drawing.Point(344, 21)
        Me.cboGuaranteeLetterType.Name = "cboGuaranteeLetterType"
        Me.cboGuaranteeLetterType.Size = New System.Drawing.Size(144, 20)
        Me.cboGuaranteeLetterType.TabIndex = 43
        Me.cboGuaranteeLetterType.TabStop = False
        '
        'cboReimburseType
        '
        Me.cboReimburseType.Enabled = False
        Me.cboReimburseType.Location = New System.Drawing.Point(96, 48)
        Me.cboReimburseType.Name = "cboReimburseType"
        Me.cboReimburseType.Size = New System.Drawing.Size(152, 20)
        Me.cboReimburseType.TabIndex = 42
        Me.cboReimburseType.TabStop = False
        '
        'txtPurpose
        '
        Me.txtPurpose.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPurpose.Location = New System.Drawing.Point(96, 168)
        Me.txtPurpose.Multiline = True
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.ReadOnly = True
        Me.txtPurpose.Size = New System.Drawing.Size(392, 56)
        Me.txtPurpose.TabIndex = 41
        Me.txtPurpose.TabStop = False
        Me.txtPurpose.Text = ""
        '
        'txtRecommendPerson
        '
        Me.txtRecommendPerson.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRecommendPerson.Location = New System.Drawing.Point(344, 142)
        Me.txtRecommendPerson.Name = "txtRecommendPerson"
        Me.txtRecommendPerson.ReadOnly = True
        Me.txtRecommendPerson.Size = New System.Drawing.Size(144, 21)
        Me.txtRecommendPerson.TabIndex = 42
        Me.txtRecommendPerson.TabStop = False
        Me.txtRecommendPerson.Text = ""
        '
        'lblRecommendPerson
        '
        Me.lblRecommendPerson.Location = New System.Drawing.Point(264, 144)
        Me.lblRecommendPerson.Name = "lblRecommendPerson"
        Me.lblRecommendPerson.Size = New System.Drawing.Size(54, 16)
        Me.lblRecommendPerson.TabIndex = 43
        Me.lblRecommendPerson.Text = "推荐单位"
        '
        'FAssignPm_BH
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(522, 439)
        Me.Controls.Add(Me.grpBH_type)
        Me.Name = "FAssignPm_BH"
        Me.Controls.SetChildIndex(Me.grpBH_type, 0)
        Me.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.Controls.SetChildIndex(Me.txtCorporationName, 0)
        Me.Controls.SetChildIndex(Me.grpBaseInfo, 0)
        Me.Controls.SetChildIndex(Me.cboPmA, 0)
        Me.Controls.SetChildIndex(Me.cboPmB, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.btnSearch, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.lblProjectCode, 0)
        Me.Controls.SetChildIndex(Me.lblCorporationName, 0)
        Me.Controls.SetChildIndex(Me.lblPmB, 0)
        Me.Controls.SetChildIndex(Me.lblPmA, 0)
        Me.Controls.SetChildIndex(Me.chkProjectDuty, 0)
        Me.grpBaseInfo.ResumeLayout(False)
        Me.grpBH_type.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub FAssignPm_BH_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            Me.GetDate()
            Me.GetPMData()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '获取保函数据
    Protected Overrides Sub GetDate()
        Me.txtProjectCode.Text = Me.getProjectCode()
        Me.txtCorporationName.Text = Me.getCorporationName()
        Dim tempDS As DataSet
        Try
            tempDS = gWs.GetcorporationInfo("{corporation_name='" & Me.getCorporationName() & "'}", "null")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
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

            tempDS = gWs.GetReimburseType("%")
            Me.cboReimburseType.DataSource = tempDS.Tables(0)
            Me.cboReimburseType.DisplayMember = "name"
            Me.cboReimburseType.ValueMember = "type_code"
            tempDS = gWs.GetGuaranteeLetterType("%")
            Me.cboGuaranteeLetterType.DataSource = tempDS.Tables(0)
            Me.cboGuaranteeLetterType.DisplayMember = "name"
            Me.cboGuaranteeLetterType.ValueMember = "type_code"

            tempDS = gWs.GetProjectInfo("{project_code='" & Me.getProjectCode() & "'}")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
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

                    If Not .Item("purpose") Is System.DBNull.Value Then
                        Me.txtPurpose.Text = .Item("purpose")               '用途
                    End If
                    If Not .Item("recommend_person") Is System.DBNull.Value Then
                        Me.txtRecommendPerson.Text = .Item("recommend_person") '推荐单位
                    End If
                    If Not .Item("workflow") Is System.DBNull.Value Then
                        Me.txtWorkflow.Text = .Item("workflow")             '运作方式
                    End If
                    If Not .Item("guarantee_letter_type") Is System.DBNull.Value Then
                        Me.cboGuaranteeLetterType.SelectedValue = .Item("guarantee_letter_type") '保函种类
                    End If
                    If Not .Item("reimburse_type") Is System.DBNull.Value Then
                        Me.cboReimburseType.SelectedValue = .Item("reimburse_type") '偿付责任类型
                    End If
                    If Not .Item("beneficiary") Is System.DBNull.Value Then
                        Me.txtBeneficiary.Text = .Item("beneficiary")        '受益人名称 
                    End If
                End With
            End If
            tempDS = gWs.FetchProjectCorporation(Me.getProjectCode(), "%", "%", "%")
            If Not tempDS.Tables(0).Rows.Count = 0 Then
                With tempDS.Tables(0).Rows(0)
                    If Not .Item("create_person") Is System.DBNull.Value Then
                        Me.txtFirstChecker.Text = .Item("create_person")    '初审人员
                    End If
                End With
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Sub

End Class
