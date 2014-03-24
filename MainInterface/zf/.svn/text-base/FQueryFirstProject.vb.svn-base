Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FQueryFirstProject
	Inherits System.Windows.Forms.Form

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
	Friend WithEvents grpCondition As System.Windows.Forms.GroupBox
	Friend WithEvents lblCorporationNo As System.Windows.Forms.Label
	Friend WithEvents txtCorporationNo As System.Windows.Forms.TextBox
	Friend WithEvents txtCorporationName As System.Windows.Forms.TextBox
	Friend WithEvents lblCorporationName As System.Windows.Forms.Label
	Friend WithEvents chkVisible As System.Windows.Forms.CheckBox
	Friend WithEvents btnRefresh As System.Windows.Forms.Button
	Friend WithEvents btnExit As System.Windows.Forms.Button
	Friend WithEvents grdTable As System.Windows.Forms.DataGrid
	Friend WithEvents txtProjectNo As System.Windows.Forms.TextBox
	Friend WithEvents lblProjectNo As System.Windows.Forms.Label
	Friend WithEvents lblToDate As System.Windows.Forms.Label
	Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblFromDate As System.Windows.Forms.Label
	Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblPhase As System.Windows.Forms.Label
	Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
	Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents lblServiceType As System.Windows.Forms.Label
	Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
	Friend WithEvents cboPhase As System.Windows.Forms.ComboBox
	Friend WithEvents btnPrint As System.Windows.Forms.Button
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryFirstProject))
        Me.grpCondition = New System.Windows.Forms.GroupBox()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.cboPhase = New System.Windows.Forms.ComboBox()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.txtProjectNo = New System.Windows.Forms.TextBox()
        Me.lblProjectNo = New System.Windows.Forms.Label()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.lblPhase = New System.Windows.Forms.Label()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.txtCorporationNo = New System.Windows.Forms.TextBox()
        Me.lblCorporationNo = New System.Windows.Forms.Label()
        Me.chkVisible = New System.Windows.Forms.CheckBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grdTable = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboServiceType, Me.cboPhase, Me.lblToDate, Me.dtpToDate, Me.lblFromDate, Me.dtpFromDate, Me.txtProjectNo, Me.lblProjectNo, Me.lblServiceType, Me.lblPhase, Me.txtCorporationName, Me.lblCorporationName, Me.txtCorporationNo, Me.lblCorporationNo})
        Me.grpCondition.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCondition.Location = New System.Drawing.Point(8, 8)
        Me.grpCondition.Name = "grpCondition"
        Me.grpCondition.Size = New System.Drawing.Size(576, 96)
        Me.grpCondition.TabIndex = 0
        Me.grpCondition.TabStop = False
        Me.grpCondition.Text = "查询条件"
        '
        'cboServiceType
        '
        Me.cboServiceType.Location = New System.Drawing.Point(272, 40)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(120, 20)
        Me.cboServiceType.TabIndex = 8
        '
        'cboPhase
        '
        Me.cboPhase.Location = New System.Drawing.Point(64, 40)
        Me.cboPhase.Name = "cboPhase"
        Me.cboPhase.Size = New System.Drawing.Size(120, 20)
        Me.cboPhase.TabIndex = 6
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Location = New System.Drawing.Point(424, 72)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(17, 14)
        Me.lblToDate.TabIndex = 13
        Me.lblToDate.Text = "到"
        '
        'dtpToDate
        '
        Me.dtpToDate.Location = New System.Drawing.Point(448, 64)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpToDate.TabIndex = 14
        '
        'lblFromDate
        '
        Me.lblFromDate.AutoSize = True
        Me.lblFromDate.Location = New System.Drawing.Point(216, 72)
        Me.lblFromDate.Name = "lblFromDate"
        Me.lblFromDate.Size = New System.Drawing.Size(54, 14)
        Me.lblFromDate.TabIndex = 11
        Me.lblFromDate.Text = "初审日期"
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CalendarFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Location = New System.Drawing.Point(272, 64)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpFromDate.TabIndex = 12
        '
        'txtProjectNo
        '
        Me.txtProjectNo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProjectNo.Location = New System.Drawing.Point(64, 64)
        Me.txtProjectNo.Name = "txtProjectNo"
        Me.txtProjectNo.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectNo.TabIndex = 10
        Me.txtProjectNo.Text = ""
        '
        'lblProjectNo
        '
        Me.lblProjectNo.AutoSize = True
        Me.lblProjectNo.Location = New System.Drawing.Point(8, 72)
        Me.lblProjectNo.Name = "lblProjectNo"
        Me.lblProjectNo.Size = New System.Drawing.Size(54, 14)
        Me.lblProjectNo.TabIndex = 9
        Me.lblProjectNo.Text = "项目编号"
        '
        'lblServiceType
        '
        Me.lblServiceType.AutoSize = True
        Me.lblServiceType.Location = New System.Drawing.Point(216, 48)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(54, 14)
        Me.lblServiceType.TabIndex = 7
        Me.lblServiceType.Text = "业务品种"
        '
        'lblPhase
        '
        Me.lblPhase.AutoSize = True
        Me.lblPhase.Location = New System.Drawing.Point(8, 48)
        Me.lblPhase.Name = "lblPhase"
        Me.lblPhase.Size = New System.Drawing.Size(54, 14)
        Me.lblPhase.TabIndex = 5
        Me.lblPhase.Text = "项目阶段"
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorporationName.Location = New System.Drawing.Point(272, 16)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.Size = New System.Drawing.Size(120, 21)
        Me.txtCorporationName.TabIndex = 4
        Me.txtCorporationName.Text = ""
        '
        'lblCorporationName
        '
        Me.lblCorporationName.AutoSize = True
        Me.lblCorporationName.Location = New System.Drawing.Point(216, 24)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(54, 14)
        Me.lblCorporationName.TabIndex = 3
        Me.lblCorporationName.Text = "企业名称"
        '
        'txtCorporationNo
        '
        Me.txtCorporationNo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorporationNo.Location = New System.Drawing.Point(64, 16)
        Me.txtCorporationNo.Name = "txtCorporationNo"
        Me.txtCorporationNo.Size = New System.Drawing.Size(120, 21)
        Me.txtCorporationNo.TabIndex = 2
        Me.txtCorporationNo.Text = ""
        '
        'lblCorporationNo
        '
        Me.lblCorporationNo.AutoSize = True
        Me.lblCorporationNo.Location = New System.Drawing.Point(8, 24)
        Me.lblCorporationNo.Name = "lblCorporationNo"
        Me.lblCorporationNo.Size = New System.Drawing.Size(54, 14)
        Me.lblCorporationNo.TabIndex = 1
        Me.lblCorporationNo.Text = "企业编号"
        '
        'chkVisible
        '
        Me.chkVisible.Checked = True
        Me.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVisible.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVisible.Location = New System.Drawing.Point(8, 112)
        Me.chkVisible.Name = "chkVisible"
        Me.chkVisible.Size = New System.Drawing.Size(184, 24)
        Me.chkVisible.TabIndex = 15
        Me.chkVisible.Text = "是否显示查询条件设置(&V)"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnRefresh.Location = New System.Drawing.Point(288, 112)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(88, 24)
        Me.btnRefresh.TabIndex = 16
        Me.btnRefresh.Text = "查 询(&S)"
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Location = New System.Drawing.Point(496, 112)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(88, 24)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "退 出(&X)"
        '
        'grdTable
        '
        Me.grdTable.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grdTable.CaptionVisible = False
        Me.grdTable.DataMember = ""
        Me.grdTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTable.Location = New System.Drawing.Point(8, 144)
        Me.grdTable.Name = "grdTable"
        Me.grdTable.ReadOnly = True
        Me.grdTable.Size = New System.Drawing.Size(576, 224)
        Me.grdTable.TabIndex = 19
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "项目编号"
        Me.DataGridTextBoxColumn1.MappingName = "project_code"
        Me.DataGridTextBoxColumn1.Width = 80
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "企业编号"
        Me.DataGridTextBoxColumn2.MappingName = "corporation_code"
        Me.DataGridTextBoxColumn2.Width = 80
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "企业名称"
        Me.DataGridTextBoxColumn3.MappingName = "corporation_name"
        Me.DataGridTextBoxColumn3.Width = 150
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "阶 段"
        Me.DataGridTextBoxColumn4.MappingName = "phase"
        Me.DataGridTextBoxColumn4.Width = 60
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "业务品种"
        Me.DataGridTextBoxColumn5.MappingName = "apply_service_Type"
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = "D"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "申请日期"
        Me.DataGridTextBoxColumn6.MappingName = "apply_date"
        Me.DataGridTextBoxColumn6.Width = 120
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "申请金额"
        Me.DataGridTextBoxColumn7.MappingName = "apply_sum"
        Me.DataGridTextBoxColumn7.Width = 60
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "申请期限"
        Me.DataGridTextBoxColumn8.MappingName = "apply_term"
        Me.DataGridTextBoxColumn8.Width = 60
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "申请银行"
        Me.DataGridTextBoxColumn9.MappingName = "bank_name"
        Me.DataGridTextBoxColumn9.Width = 150
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "初审人员"
        Me.DataGridTextBoxColumn10.MappingName = "attend_person"
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = "D"
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "分配日期"
        Me.DataGridTextBoxColumn11.MappingName = "start_time"
        Me.DataGridTextBoxColumn11.Width = 120
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = "D"
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "完成日期"
        Me.DataGridTextBoxColumn12.MappingName = "end_time"
        Me.DataGridTextBoxColumn12.Width = 120
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "结 论"
        Me.DataGridTextBoxColumn13.MappingName = "conclusion"
        Me.DataGridTextBoxColumn13.Width = 80
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnPrint.Location = New System.Drawing.Point(392, 112)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(88, 24)
        Me.btnPrint.TabIndex = 17
        Me.btnPrint.Text = "打 印(&P)"
        '
        'FQueryFirstProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(592, 373)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grdTable, Me.grpCondition})
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "FQueryFirstProject"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "初审项目一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
		Me.Refresh("")
	End Sub

	Private Sub chkVisible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVisible.CheckedChanged
		Dim h As Integer = IIf(chkVisible.Checked, grpCondition.Height, -grpCondition.Height)

		grpCondition.Visible = chkVisible.Checked

		btnExit.Top += h
		btnPrint.Top += h
		btnRefresh.Top += h
		chkVisible.Top += h
		grdTable.Top += h
		grdTable.Height = Me.ClientSize.Height - grdTable.Top - 8
	End Sub

	Private Sub FFirstProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		dtpFromDate.Value = DateTime.Today
		dtpToDate.Value = DateTime.Today

		cboPhase.DataSource = gWs.GetPhase("%").Tables(0)
		cboPhase.DisplayMember = "phase_name"
		cboPhase.ValueMember = "phase_name"

		cboServiceType.DataSource = gWs.GetServiceType("%").Tables(0)
		cboServiceType.DisplayMember = "service_type"
		cboServiceType.ValueMember = "service_type"
	End Sub

	Private Sub FFirstProject_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		If e.KeyCode = Keys.F5 Then
			Me.Refresh("")
		End If
	End Sub

	Private Sub TextEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCorporationNo.Enter, txtCorporationName.Enter, txtProjectNo.Enter
		If (Not sender Is Nothing) AndAlso sender.GetType() Is GetType(TextBox) Then
			CType(sender, TextBox).SelectAll()
		End If
	End Sub

	Public Overloads Sub Refresh(ByVal Condition As String)
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim projectNo, corporationNo, corporationName, phase, serviceType As String

			Me.GetCondition(projectNo, corporationNo, corporationName, phase, serviceType)

			Dim rsResult As DataSet = gWs.GetQueryFirstProject(projectNo, corporationNo, corporationName, phase, serviceType, dtpFromDate.Value, dtpToDate.Value)

			grdTable.DataSource = rsResult
			grdTable.SetDataBinding(rsResult, "Table")
            Me.Text = "初审项目一览表(" + rsResult.Tables("Table").Rows.Count.ToString + ")"
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Private Function GetCondition(ByRef projectNo As String, ByRef corporationNo As String, ByRef corporationName As String, ByRef phase As String, ByRef serviceType As String) As String
		projectNo = IIf(txtProjectNo.Text.Trim() = "", "%", txtProjectNo.Text)
		corporationNo = IIf(txtCorporationNo.Text.Trim() = "", "%", txtCorporationNo.Text)
		corporationName = IIf(txtCorporationName.Text.Trim() = "", "%", txtCorporationName.Text)
		phase = IIf(cboPhase.Text.Trim() = "", "%", cboPhase.Text)
		serviceType = IIf(cboServiceType.Text.Trim() = "", "%", cboServiceType.Text)
	End Function

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Dim reportViewerForm As FReportViewer = New FReportViewer()

		Try
			Dim dataSource As Object

			If Not grdTable.DataSource Is Nothing Then
                dataSource = CType(grdTable.DataSource, DataSet).Tables(0)
                If Not dataSource Is Nothing Then
                    CType(dataSource, DataTable).TableName = "TQueryFirstProject"
                End If

                dataSource = grdTable.DataSource
            End If

            reportViewerForm.ShowDialog(Application.StartupPath + "\Reports\QueryFirstProject.rpt", dataSource, "初审项目一览表", Me)
        Finally
			If Not reportViewerForm Is Nothing Then
				reportViewerForm.Dispose()
			End If
		End Try
	End Sub
End Class
