
'再担保分配项目经理
Public Class FAssignPm_ZDB
    Inherits FAssignPmBase

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
    Friend WithEvents lblPurpose As System.Windows.Forms.Label
    Friend WithEvents txtPurpose As System.Windows.Forms.TextBox
    Friend WithEvents lblOrganization As System.Windows.Forms.Label
    Friend WithEvents txtOrganization As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblPurpose = New System.Windows.Forms.Label()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.lblOrganization = New System.Windows.Forms.Label()
        Me.txtOrganization = New System.Windows.Forms.TextBox()
        Me.grpBaseInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(221, 336)
        Me.btnCommit.Visible = True
        '
        'cboBank
        '
        Me.cboBank.ItemHeight = 12
        Me.cboBank.Size = New System.Drawing.Size(152, 20)
        Me.cboBank.Visible = True
        '
        'cboPmB
        '
        Me.cboPmB.ItemHeight = 12
        Me.cboPmB.Location = New System.Drawing.Point(352, 288)
        Me.cboPmB.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Visible = True
        '
        'lblPmB
        '
        Me.lblPmB.Location = New System.Drawing.Point(272, 290)
        Me.lblPmB.Visible = True
        '
        'txtApplyGuaranteeSum
        '
        Me.txtApplyGuaranteeSum.Visible = True
        '
        'lblStatus
        '
        Me.lblStatus.Visible = True
        '
        'lblEnterpriseType
        '
        Me.lblEnterpriseType.Visible = True
        '
        'lblFirstChecker
        '
        Me.lblFirstChecker.Visible = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(133, 336)
        Me.btnSearch.Visible = True
        '
        'lblIndustryType
        '
        Me.lblIndustryType.Visible = True
        '
        'txtFirstChecker
        '
        Me.txtFirstChecker.Visible = True
        '
        'cboSubBank
        '
        Me.cboSubBank.ItemHeight = 12
        Me.cboSubBank.Size = New System.Drawing.Size(144, 20)
        Me.cboSubBank.Visible = True
        '
        'txtIndustryType
        '
        Me.txtIndustryType.Visible = True
        '
        'lblApplyServiceType
        '
        Me.lblApplyServiceType.Visible = True
        '
        'txtEnterpriseType
        '
        Me.txtEnterpriseType.Visible = True
        '
        'chkProjectDuty
        '
        Me.chkProjectDuty.Location = New System.Drawing.Point(24, 312)
        Me.chkProjectDuty.Size = New System.Drawing.Size(112, 24)
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Visible = True
        '
        'cboPmA
        '
        Me.cboPmA.ItemHeight = 12
        Me.cboPmA.Location = New System.Drawing.Point(104, 288)
        Me.cboPmA.Visible = True
        '
        'lblApplyGuaranteeSum
        '
        Me.lblApplyGuaranteeSum.Visible = True
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Visible = True
        '
        'lblApplyGuaranteeTerm
        '
        Me.lblApplyGuaranteeTerm.Visible = True
        '
        'lblBank
        '
        Me.lblBank.Visible = True
        '
        'txtApplyGuaranteeTerm
        '
        Me.txtApplyGuaranteeTerm.Visible = True
        '
        'lblApplyDate
        '
        Me.lblApplyDate.Visible = True
        '
        'lblSubBank
        '
        Me.lblSubBank.Visible = True
        '
        'txtPhase
        '
        Me.txtPhase.Visible = True
        '
        'grpBaseInfo
        '
        Me.grpBaseInfo.Controls.AddRange(New System.Windows.Forms.Control() {Me.lblPurpose, Me.txtOrganization, Me.lblOrganization, Me.txtPurpose})
        Me.grpBaseInfo.Size = New System.Drawing.Size(504, 248)
        Me.grpBaseInfo.Visible = True
        '
        'txtApplyServiceType
        '
        Me.txtApplyServiceType.Visible = True
        '
        'txtStatus
        '
        Me.txtStatus.Visible = True
        '
        'lblPhase
        '
        Me.lblPhase.Visible = True
        '
        'lblPmA
        '
        Me.lblPmA.Location = New System.Drawing.Point(24, 290)
        Me.lblPmA.Visible = True
        '
        'dtpApplyDate
        '
        Me.dtpApplyDate.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(309, 336)
        Me.btnExit.Visible = True
        '
        'lblPurpose
        '
        Me.lblPurpose.AutoSize = True
        Me.lblPurpose.Location = New System.Drawing.Point(8, 176)
        Me.lblPurpose.Name = "lblPurpose"
        Me.lblPurpose.Size = New System.Drawing.Size(42, 14)
        Me.lblPurpose.TabIndex = 42
        Me.lblPurpose.Text = " 用 途"
        '
        'txtPurpose
        '
        Me.txtPurpose.BackColor = System.Drawing.Color.Gainsboro
        Me.txtPurpose.Location = New System.Drawing.Point(96, 168)
        Me.txtPurpose.Multiline = True
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.ReadOnly = True
        Me.txtPurpose.Size = New System.Drawing.Size(392, 72)
        Me.txtPurpose.TabIndex = 43
        Me.txtPurpose.TabStop = False
        Me.txtPurpose.Text = ""
        '
        'lblOrganization
        '
        Me.lblOrganization.Location = New System.Drawing.Point(264, 144)
        Me.lblOrganization.Name = "lblOrganization"
        Me.lblOrganization.Size = New System.Drawing.Size(54, 16)
        Me.lblOrganization.TabIndex = 44
        Me.lblOrganization.Text = "担保机构"
        '
        'txtOrganization
        '
        Me.txtOrganization.BackColor = System.Drawing.Color.Gainsboro
        Me.txtOrganization.Location = New System.Drawing.Point(344, 142)
        Me.txtOrganization.Name = "txtOrganization"
        Me.txtOrganization.ReadOnly = True
        Me.txtOrganization.Size = New System.Drawing.Size(144, 21)
        Me.txtOrganization.TabIndex = 45
        Me.txtOrganization.Text = ""
        '
        'FAssignPm_ZDB
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(522, 367)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkProjectDuty, Me.lblPmA, Me.lblPmB, Me.lblCorporationName, Me.lblProjectCode, Me.btnExit, Me.btnSearch, Me.btnCommit, Me.cboPmB, Me.cboPmA, Me.grpBaseInfo, Me.txtCorporationName, Me.txtProjectCode})
        Me.Name = "FAssignPm_ZDB"
        Me.grpBaseInfo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FAssignPm_ZDB_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    '获取基本数据
    Protected Overrides Sub GetDate()
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
                    Me.txtPhase.Text = IIf(IsDBNull(.Item("phase")), "", .Item("phase"))                  '阶段
                    Me.txtStatus.Text = IIf(IsDBNull(.Item("status")), "", .Item("status"))               '状态
                    Me.txtApplyGuaranteeSum.Text = IIf(IsDBNull(.Item("apply_sum")), "", .Item("apply_sum")) '申请金额
                    Me.txtApplyGuaranteeTerm.Text = IIf(IsDBNull(.Item("apply_term")), "", .Item("apply_term")) '申请期限
                    If Not .Item("apply_date") Is System.DBNull.Value Then
                        Me.dtpApplyDate.Value = .Item("apply_date")         '申请时间
                    End If
                    Me.txtApplyServiceType.Text = IIf(IsDBNull(.Item("apply_service_type")), "", .Item("apply_service_type")) '申请业务品种
                    If Not .Item("apply_bank") Is System.DBNull.Value Then
                        Me.cboBank.SelectedValue = .Item("apply_bank")      '申请银行
                        Me.BankChanged()
                    End If
                    If Not .Item("apply_branch_bank") Is System.DBNull.Value Then
                        Me.cboSubBank.SelectedValue = .Item("apply_branch_bank") '申请支行
                    End If
                    Me.txtPurpose.Text = IIf(IsDBNull(.Item("purpose")), "", .Item("purpose"))               '用途
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
            dsTemp = gWs.GetProjectOrganization("{project_code = '" & Me.getProjectCode() & "'}")
            Dim OrganNo As String
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                OrganNo = IIf(IsDBNull(dsTemp.Tables(0).Rows(0)("OrganNo")), "", dsTemp.Tables(0).Rows(0)("OrganNo"))
            End If
            dsTemp = gWs.GetTOrganizationInfo("{OrganNo = '" & OrganNo & "'}")
            If Not dsTemp.Tables(0).Rows.Count = 0 Then
                Me.txtOrganization.Text = IIf(IsDBNull(dsTemp.Tables(0).Rows(0)("Name")), "", dsTemp.Tables(0).Rows(0)("Name"))  '取得机构名称
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

End Class
