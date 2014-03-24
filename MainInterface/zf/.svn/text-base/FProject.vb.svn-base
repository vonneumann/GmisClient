Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FProject
	Inherits FBaseData

#Region " Windows 窗体设计器生成的代码 "

	Public Sub New()
		MyBase.New()

		'该调用是 Windows 窗体设计器所必需的。
		InitializeComponent()

		'在 InitializeComponent() 调用之后添加任何初始化
        btnRefresh.Top = btnClear.Top
        btnDelete.Top = btnClear.Top
        btnUpdate.Top = btnClear.Top
        btnExit.Top = btnClear.Top

        grdTable.Top = 120
        grdTable.Height = Me.ClientSize.Height - grdTable.Top - 8
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
	Friend tsProject As System.Windows.Forms.DataGridTableStyle
	Friend csProjectNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend csCorporationNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend csCorporationName As System.Windows.Forms.DataGridTextBoxColumn
	Friend csPhase As System.Windows.Forms.DataGridTextBoxColumn
	Friend csStatus As System.Windows.Forms.DataGridTextBoxColumn
	Friend csApplyServiceType As System.Windows.Forms.DataGridTextBoxColumn
	Friend csApplyBank As System.Windows.Forms.DataGridTextBoxColumn
	Friend csApplyBranchBank As System.Windows.Forms.DataGridTextBoxColumn
	Friend csApplySum As System.Windows.Forms.DataGridTextBoxColumn
	Friend csApplyTerm As System.Windows.Forms.DataGridTextBoxColumn
	Friend csApplyDate As System.Windows.Forms.DataGridTextBoxColumn
	Friend csPurpose As System.Windows.Forms.DataGridTextBoxColumn
	Friend csRecommendType As System.Windows.Forms.DataGridTextBoxColumn
	Friend csRecommendPerson As System.Windows.Forms.DataGridTextBoxColumn
	Friend csIsFirstLoan As System.Windows.Forms.DataGridBoolColumn
	Friend csConsultSerialID As System.Windows.Forms.DataGridTextBoxColumn
	Friend csIsLiving As System.Windows.Forms.DataGridBoolColumn
	Friend csCreatePerson As System.Windows.Forms.DataGridTextBoxColumn
	Friend csCreateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents grpCondition As System.Windows.Forms.GroupBox
    Friend WithEvents lblProjectNo As System.Windows.Forms.Label
    Friend WithEvents txtProjectNo As System.Windows.Forms.TextBox
    Friend WithEvents lblPhase As System.Windows.Forms.Label
    Friend WithEvents cboPhase As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblServiceType As System.Windows.Forms.Label
    Friend WithEvents lblCorporationName As System.Windows.Forms.Label
    Friend WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents chkVisible As System.Windows.Forms.CheckBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FProject))
        Me.tsProject = New System.Windows.Forms.DataGridTableStyle()
        Me.csProjectNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCorporationNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCorporationName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csPhase = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csStatus = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csApplyServiceType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csApplyBank = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csApplyBranchBank = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csApplySum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csApplyTerm = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csApplyDate = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csPurpose = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csRecommendType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csRecommendPerson = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIsFirstLoan = New System.Windows.Forms.DataGridBoolColumn()
        Me.csConsultSerialID = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIsLiving = New System.Windows.Forms.DataGridBoolColumn()
        Me.csCreatePerson = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCreateDate = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.grpCondition = New System.Windows.Forms.GroupBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.cboPhase = New System.Windows.Forms.ComboBox()
        Me.lblPhase = New System.Windows.Forms.Label()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.txtProjectNo = New System.Windows.Forms.TextBox()
        Me.lblProjectNo = New System.Windows.Forms.Label()
        Me.chkVisible = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.Location = New System.Drawing.Point(536, 88)
        Me.btnUpdate.TabIndex = 5
        Me.btnUpdate.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.Location = New System.Drawing.Point(536, 88)
        Me.btnDelete.TabIndex = 4
        Me.btnDelete.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(624, 88)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.Location = New System.Drawing.Point(448, 88)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "查 询(&S)"
        Me.btnRefresh.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 120)
        Me.grdTable.Size = New System.Drawing.Size(696, 368)
        Me.grdTable.TabIndex = 7
        Me.grdTable.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'tsProject
        '
        Me.tsProject.DataGrid = Me.grdTable
        Me.tsProject.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csProjectNo, Me.csCorporationNo, Me.csCorporationName, Me.csPhase, Me.csStatus, Me.csApplyServiceType, Me.csApplyBank, Me.csApplyBranchBank, Me.csApplySum, Me.csApplyTerm, Me.csApplyDate, Me.csPurpose, Me.csRecommendType, Me.csRecommendPerson, Me.csIsFirstLoan, Me.csConsultSerialID, Me.csIsLiving, Me.csCreatePerson, Me.csCreateDate})
        Me.tsProject.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsProject.MappingName = "Table"
        Me.tsProject.ReadOnly = True
        '
        'csProjectNo
        '
        Me.csProjectNo.Format = ""
        Me.csProjectNo.FormatInfo = Nothing
        Me.csProjectNo.HeaderText = "项目编号"
        Me.csProjectNo.MappingName = "projectCode"
        Me.csProjectNo.Width = 70
        '
        'csCorporationNo
        '
        Me.csCorporationNo.Format = ""
        Me.csCorporationNo.FormatInfo = Nothing
        Me.csCorporationNo.HeaderText = "客户编号"
        Me.csCorporationNo.MappingName = "corporation_code"
        Me.csCorporationNo.Width = 0
        '
        'csCorporationName
        '
        Me.csCorporationName.Format = ""
        Me.csCorporationName.FormatInfo = Nothing
        Me.csCorporationName.HeaderText = "企业名称"
        Me.csCorporationName.MappingName = "EnterpriseName"
        Me.csCorporationName.Width = 250
        '
        'csPhase
        '
        Me.csPhase.Format = ""
        Me.csPhase.FormatInfo = Nothing
        Me.csPhase.HeaderText = "阶  段"
        Me.csPhase.MappingName = ""
        Me.csPhase.Width = 0
        '
        'csStatus
        '
        Me.csStatus.Format = ""
        Me.csStatus.FormatInfo = Nothing
        Me.csStatus.HeaderText = "所属区域"
        Me.csStatus.MappingName = "district_name"
        Me.csStatus.Width = 80
        '
        'csApplyServiceType
        '
        Me.csApplyServiceType.Format = ""
        Me.csApplyServiceType.FormatInfo = Nothing
        Me.csApplyServiceType.HeaderText = "业务品种"
        Me.csApplyServiceType.MappingName = "ServiceType"
        Me.csApplyServiceType.Width = 110
        '
        'csApplyBank
        '
        Me.csApplyBank.Format = ""
        Me.csApplyBank.FormatInfo = Nothing
        Me.csApplyBank.HeaderText = "申请银行"
        Me.csApplyBank.MappingName = "apply_bank"
        Me.csApplyBank.Width = 0
        '
        'csApplyBranchBank
        '
        Me.csApplyBranchBank.Format = ""
        Me.csApplyBranchBank.FormatInfo = Nothing
        Me.csApplyBranchBank.HeaderText = "申请支行"
        Me.csApplyBranchBank.MappingName = "apply_branch_bank"
        Me.csApplyBranchBank.Width = 0
        '
        'csApplySum
        '
        Me.csApplySum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csApplySum.Format = ""
        Me.csApplySum.FormatInfo = Nothing
        Me.csApplySum.HeaderText = "申请金额"
        Me.csApplySum.MappingName = "ApplySum"
        Me.csApplySum.Width = 70
        '
        'csApplyTerm
        '
        Me.csApplyTerm.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csApplyTerm.Format = ""
        Me.csApplyTerm.FormatInfo = Nothing
        Me.csApplyTerm.HeaderText = "申请期限"
        Me.csApplyTerm.MappingName = "ApplyTerm"
        Me.csApplyTerm.Width = 60
        '
        'csApplyDate
        '
        Me.csApplyDate.Format = "D"
        Me.csApplyDate.FormatInfo = Nothing
        Me.csApplyDate.HeaderText = "申请日期"
        Me.csApplyDate.MappingName = "ApplyDate"
        Me.csApplyDate.Width = 110
        '
        'csPurpose
        '
        Me.csPurpose.Format = ""
        Me.csPurpose.FormatInfo = Nothing
        Me.csPurpose.HeaderText = "阶 段"
        Me.csPurpose.MappingName = "phase"
        Me.csPurpose.Width = 70
        '
        'csRecommendType
        '
        Me.csRecommendType.Format = ""
        Me.csRecommendType.FormatInfo = Nothing
        Me.csRecommendType.HeaderText = "状 态"
        Me.csRecommendType.MappingName = "status"
        Me.csRecommendType.Width = 80
        '
        'csRecommendPerson
        '
        Me.csRecommendPerson.Format = ""
        Me.csRecommendPerson.FormatInfo = Nothing
        Me.csRecommendPerson.HeaderText = "推荐人"
        Me.csRecommendPerson.MappingName = "recommend_person"
        Me.csRecommendPerson.Width = 0
        '
        'csIsFirstLoan
        '
        Me.csIsFirstLoan.FalseValue = False
        Me.csIsFirstLoan.HeaderText = "首次贷款"
        Me.csIsFirstLoan.MappingName = "is_first_loan"
        Me.csIsFirstLoan.NullValue = CType(resources.GetObject("csIsFirstLoan.NullValue"), System.DBNull)
        Me.csIsFirstLoan.TrueValue = True
        Me.csIsFirstLoan.Width = 0
        '
        'csConsultSerialID
        '
        Me.csConsultSerialID.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.csConsultSerialID.Format = ""
        Me.csConsultSerialID.FormatInfo = Nothing
        Me.csConsultSerialID.HeaderText = "结论序号"
        Me.csConsultSerialID.MappingName = "consult_serial_num"
        Me.csConsultSerialID.Width = 0
        '
        'csIsLiving
        '
        Me.csIsLiving.FalseValue = False
        Me.csIsLiving.HeaderText = "活动的"
        Me.csIsLiving.MappingName = "isliving"
        Me.csIsLiving.NullValue = CType(resources.GetObject("csIsLiving.NullValue"), System.DBNull)
        Me.csIsLiving.TrueValue = True
        Me.csIsLiving.Width = 0
        '
        'csCreatePerson
        '
        Me.csCreatePerson.Format = ""
        Me.csCreatePerson.FormatInfo = Nothing
        Me.csCreatePerson.HeaderText = "创建人"
        Me.csCreatePerson.MappingName = "create_person"
        Me.csCreatePerson.Width = 0
        '
        'csCreateDate
        '
        Me.csCreateDate.Format = "D"
        Me.csCreateDate.FormatInfo = Nothing
        Me.csCreateDate.HeaderText = "创建日期"
        Me.csCreateDate.MappingName = "create_date"
        Me.csCreateDate.Width = 0
        '
        'grpCondition
        '
        Me.grpCondition.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtStatus, Me.lblServiceType, Me.cboServiceType, Me.lblStatus, Me.cboPhase, Me.lblPhase, Me.txtCorporationName, Me.lblCorporationName, Me.txtProjectNo, Me.lblProjectNo})
        Me.grpCondition.Location = New System.Drawing.Point(8, 8)
        Me.grpCondition.Name = "grpCondition"
        Me.grpCondition.Size = New System.Drawing.Size(696, 72)
        Me.grpCondition.TabIndex = 0
        Me.grpCondition.TabStop = False
        Me.grpCondition.Text = "查询条件"
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(400, 16)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.Size = New System.Drawing.Size(88, 21)
        Me.txtStatus.TabIndex = 5
        Me.txtStatus.Text = ""
        '
        'lblServiceType
        '
        Me.lblServiceType.Location = New System.Drawing.Point(344, 48)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(56, 16)
        Me.lblServiceType.TabIndex = 8
        Me.lblServiceType.Text = "业务品种"
        '
        'cboServiceType
        '
        Me.cboServiceType.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.cboServiceType.Location = New System.Drawing.Point(400, 40)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(288, 20)
        Me.cboServiceType.TabIndex = 9
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(344, 24)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(56, 16)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "项目状态"
        '
        'cboPhase
        '
        Me.cboPhase.Location = New System.Drawing.Point(248, 16)
        Me.cboPhase.Name = "cboPhase"
        Me.cboPhase.Size = New System.Drawing.Size(88, 20)
        Me.cboPhase.TabIndex = 3
        '
        'lblPhase
        '
        Me.lblPhase.Location = New System.Drawing.Point(192, 24)
        Me.lblPhase.Name = "lblPhase"
        Me.lblPhase.Size = New System.Drawing.Size(56, 16)
        Me.lblPhase.TabIndex = 2
        Me.lblPhase.Text = "项目阶段"
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Location = New System.Drawing.Point(64, 40)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.Size = New System.Drawing.Size(272, 21)
        Me.txtCorporationName.TabIndex = 7
        Me.txtCorporationName.Text = ""
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Location = New System.Drawing.Point(8, 48)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(56, 16)
        Me.lblCorporationName.TabIndex = 6
        Me.lblCorporationName.Text = "企业名称"
        '
        'txtProjectNo
        '
        Me.txtProjectNo.Location = New System.Drawing.Point(64, 16)
        Me.txtProjectNo.Name = "txtProjectNo"
        Me.txtProjectNo.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectNo.TabIndex = 1
        Me.txtProjectNo.Text = ""
        '
        'lblProjectNo
        '
        Me.lblProjectNo.Location = New System.Drawing.Point(8, 24)
        Me.lblProjectNo.Name = "lblProjectNo"
        Me.lblProjectNo.Size = New System.Drawing.Size(56, 16)
        Me.lblProjectNo.TabIndex = 0
        Me.lblProjectNo.Text = "项目编号"
        '
        'chkVisible
        '
        Me.chkVisible.Checked = True
        Me.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVisible.Location = New System.Drawing.Point(8, 88)
        Me.chkVisible.Name = "chkVisible"
        Me.chkVisible.Size = New System.Drawing.Size(184, 24)
        Me.chkVisible.TabIndex = 1
        Me.chkVisible.Text = "是否显示查询条件设置(&V)"
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Bitmap)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.ImageIndex = 3
        Me.btnClear.ImageList = Me.ImageList1
        Me.btnClear.Location = New System.Drawing.Point(200, 88)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "清 空(&C)"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdTable, Me.btnClear, Me.chkVisible, Me.grpCondition})
        Me.Name = "FProject"
        Me.Text = "项目删除"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Event refreshTaskCommit()

    Public Function GetCondition() As String
        Dim condition As String = String.Empty
        Dim sql As String

        If txtProjectNo.Text.Trim() <> String.Empty Then
            sql = "ProjectCode LIKE '%" + txtProjectNo.Text + "%'"

            If condition = String.Empty Then
                condition = sql
            Else
                condition += " AND " + sql
            End If
        End If

        If txtCorporationName.Text.Trim() <> String.Empty Then
            sql = "EnterpriseName LIKE '%" + txtCorporationName.Text + "%'"

            If condition = String.Empty Then
                condition = sql
            Else
                condition += " AND " + sql
            End If
        End If

        If cboServiceType.Text.Trim() <> String.Empty Then
            sql = "ServiceType LIKE '%" + cboServiceType.Text + "%'"

            If condition = String.Empty Then
                condition = sql
            Else
                condition += " AND " + sql
            End If
        End If

        If cboPhase.Text.Trim() <> String.Empty Then
            sql = "phase LIKE '%" + cboPhase.Text + "%'"

            If condition = String.Empty Then
                condition = sql
            Else
                condition += " AND " + sql
            End If
        End If

        If txtStatus.Text.Trim() <> String.Empty Then
            sql = "status LIKE '%" + txtStatus.Text + "%'"

            If condition = String.Empty Then
                condition = sql
            Else
                condition += " AND " + sql
            End If
        End If

        If condition = String.Empty Then
            Return "ProjectCode LIKE '%'"
        Else
            Return condition
        End If
    End Function

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtStatus.Text = String.Empty
        txtProjectNo.Text = String.Empty
        txtCorporationName.Text = String.Empty
        cboPhase.ResetText()
        cboServiceType.ResetText()
        cboPhase.SelectedIndex = -1
        cboServiceType.SelectedIndex = -1
    End Sub

    Public Overrides Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If Me.BindingContext(grdTable.DataSource, grdTable.DataMember).Position < 0 Then
                Return
            End If

            If MessageBox.Show("您确认要删除当前选择的记录吗？", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) <> DialogResult.Yes Then
                Return
            End If

            If Not grdTable.DataSource Is Nothing Then
                If Me.BindingContext(grdTable.DataSource, grdTable.DataMember).Position >= 0 Then
                    Dim rv As DataRowView = CType(Me.BindingContext(grdTable.DataSource, grdTable.DataMember).Current, DataRowView)

                    gWs.DelProject(rv("ProjectCode").ToString())
                    Me.Refresh()
                    RaiseEvent refreshTaskCommit()
                End If
            End If
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Public Overloads Overrides Sub Refresh()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dsResult As DataSet

            Dim condition As String = GetCondition()

            'dsResult = gWs.GetProjectInfoEx(condition)
            'grdTable.SetDataBinding(dsResult, "ViewProject")
            Dim strSql As String
            strSql = "select ProjectCode,EnterpriseName,ServiceType,district_name,applySum,applyTerm,applyDate,phase,status from ViewProjectInfo_firstReview where " & condition
            dsResult = gWs.GetCommonQueryInfo(strSql)
            grdTable.SetDataBinding(dsResult, "Table")

            dsResult.AcceptChanges()

            Dim dv As DataView = CType(CType(Me.BindingContext(grdTable.DataSource, grdTable.DataMember), CurrencyManager).List, DataView)
            dv.AllowNew = False
            dv.AllowDelete = False
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Overrides Function Update() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dsCommit As DataSet = CType(grdTable.DataSource, DataSet)

            If dsCommit Is Nothing OrElse (Not dsCommit.HasChanges()) Then
                Return False
            End If

            Dim result As String = gWs.UpdateProject(dsCommit.GetChanges())

            If result = "1" Then
                '接受所有更改
                dsCommit.AcceptChanges()

                Return True
            Else
                '显示服务器的返回错误信息
                SWDialogBox.MessageBox.Show("*999", Me.Name + ".Update", result, "")
            End If
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        Return False
    End Function

    Private Sub FBranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grdTable.TableStyles.Add(Me.tsProject)

        cboPhase.DataSource = gWs.GetPhase("%").Tables(0).DefaultView
        cboPhase.DisplayMember = "phase_name"
        cboPhase.ValueMember = "phase_name"

        cboServiceType.DataSource = gWs.GetServiceType("%").Tables(0).DefaultView
        cboServiceType.DisplayMember = "service_type"
        cboServiceType.ValueMember = "service_type"

        cboPhase.Text = ""
        cboPhase.SelectedIndex = -1
        cboServiceType.Text = ""
        cboServiceType.SelectedIndex = -1

        cboPhase.Text = ""
        cboPhase.SelectedIndex = -1
        cboServiceType.Text = ""
        cboServiceType.SelectedIndex = -1
    End Sub

    Private Sub chkVisible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVisible.CheckedChanged
        Dim height As Integer = IIf(chkVisible.Checked, grpCondition.Height, -grpCondition.Height)

        grpCondition.Visible = chkVisible.Checked

        btnExit.Top += height
        btnDelete.Top += height
        btnUpdate.Top += height
        btnClear.Top += height
        btnRefresh.Top += height
        chkVisible.Top += height
        grdTable.Top += height
        grdTable.Height = Me.ClientSize.Height - grdTable.Top - 8
    End Sub

    Private Sub ClearControl(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        Me.clear()
    End Sub

    Protected Overridable Sub clear()
        txtStatus.Text = String.Empty
        txtProjectNo.Text = String.Empty
        txtCorporationName.Text = String.Empty
        cboPhase.ResetText()
        cboServiceType.ResetText()
        cboPhase.SelectedIndex = -1
        cboServiceType.SelectedIndex = -1
    End Sub

End Class
