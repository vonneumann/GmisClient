Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FQueryConsultation
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
	Friend WithEvents txtRecommendName As System.Windows.Forms.TextBox
	Friend WithEvents lblRecommendName As System.Windows.Forms.Label
	Friend WithEvents lblDistrictName As System.Windows.Forms.Label
	Friend WithEvents txtConsultName As System.Windows.Forms.TextBox
	Friend WithEvents lblConsultName As System.Windows.Forms.Label
	Friend WithEvents chkVisible As System.Windows.Forms.CheckBox
	Friend WithEvents btnRefresh As System.Windows.Forms.Button
	Friend WithEvents btnExit As System.Windows.Forms.Button
	Friend WithEvents grdTable As System.Windows.Forms.DataGrid
	Friend WithEvents tsConsultation As System.Windows.Forms.DataGridTableStyle
	Friend WithEvents csCorporationNo As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
	Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents lblToDate As System.Windows.Forms.Label
	Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblFromDate As System.Windows.Forms.Label
	Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
	Friend WithEvents cboDistrictName As System.Windows.Forms.ComboBox
	Friend WithEvents btnPrint As System.Windows.Forms.Button
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryConsultation))
        Me.grpCondition = New System.Windows.Forms.GroupBox()
        Me.cboDistrictName = New System.Windows.Forms.ComboBox()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.lblFromDate = New System.Windows.Forms.Label()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.txtConsultName = New System.Windows.Forms.TextBox()
        Me.lblConsultName = New System.Windows.Forms.Label()
        Me.lblDistrictName = New System.Windows.Forms.Label()
        Me.txtRecommendName = New System.Windows.Forms.TextBox()
        Me.lblRecommendName = New System.Windows.Forms.Label()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.txtCorporationNo = New System.Windows.Forms.TextBox()
        Me.lblCorporationNo = New System.Windows.Forms.Label()
        Me.chkVisible = New System.Windows.Forms.CheckBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grdTable = New System.Windows.Forms.DataGrid()
        Me.tsConsultation = New System.Windows.Forms.DataGridTableStyle()
        Me.csCorporationNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboDistrictName, Me.lblToDate, Me.dtpToDate, Me.lblFromDate, Me.dtpFromDate, Me.txtConsultName, Me.lblConsultName, Me.lblDistrictName, Me.txtRecommendName, Me.lblRecommendName, Me.txtCorporationName, Me.lblCorporationName, Me.txtCorporationNo, Me.lblCorporationNo})
        Me.grpCondition.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCondition.Location = New System.Drawing.Point(8, 8)
        Me.grpCondition.Name = "grpCondition"
        Me.grpCondition.Size = New System.Drawing.Size(576, 96)
        Me.grpCondition.TabIndex = 0
        Me.grpCondition.TabStop = False
        Me.grpCondition.Text = "查询条件"
        '
        'cboDistrictName
        '
        Me.cboDistrictName.Location = New System.Drawing.Point(272, 40)
        Me.cboDistrictName.Name = "cboDistrictName"
        Me.cboDistrictName.Size = New System.Drawing.Size(120, 20)
        Me.cboDistrictName.TabIndex = 8
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
        Me.lblFromDate.Text = "咨询日期"
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CalendarFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Location = New System.Drawing.Point(272, 64)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpFromDate.TabIndex = 12
        '
        'txtConsultName
        '
        Me.txtConsultName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsultName.Location = New System.Drawing.Point(64, 64)
        Me.txtConsultName.Name = "txtConsultName"
        Me.txtConsultName.Size = New System.Drawing.Size(120, 21)
        Me.txtConsultName.TabIndex = 10
        Me.txtConsultName.Text = ""
        '
        'lblConsultName
        '
        Me.lblConsultName.AutoSize = True
        Me.lblConsultName.Location = New System.Drawing.Point(8, 72)
        Me.lblConsultName.Name = "lblConsultName"
        Me.lblConsultName.Size = New System.Drawing.Size(54, 14)
        Me.lblConsultName.TabIndex = 9
        Me.lblConsultName.Text = "咨询人员"
        '
        'lblDistrictName
        '
        Me.lblDistrictName.AutoSize = True
        Me.lblDistrictName.Location = New System.Drawing.Point(216, 48)
        Me.lblDistrictName.Name = "lblDistrictName"
        Me.lblDistrictName.Size = New System.Drawing.Size(54, 14)
        Me.lblDistrictName.TabIndex = 7
        Me.lblDistrictName.Text = "所属地区"
        '
        'txtRecommendName
        '
        Me.txtRecommendName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecommendName.Location = New System.Drawing.Point(64, 40)
        Me.txtRecommendName.Name = "txtRecommendName"
        Me.txtRecommendName.Size = New System.Drawing.Size(120, 21)
        Me.txtRecommendName.TabIndex = 6
        Me.txtRecommendName.Text = ""
        '
        'lblRecommendName
        '
        Me.lblRecommendName.AutoSize = True
        Me.lblRecommendName.Location = New System.Drawing.Point(8, 48)
        Me.lblRecommendName.Name = "lblRecommendName"
        Me.lblRecommendName.Size = New System.Drawing.Size(54, 14)
        Me.lblRecommendName.TabIndex = 5
        Me.lblRecommendName.Text = "推荐人名"
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
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsConsultation})
        '
        'tsConsultation
        '
        Me.tsConsultation.DataGrid = Me.grdTable
        Me.tsConsultation.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csCorporationNo, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridBoolColumn1, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn8})
        Me.tsConsultation.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsConsultation.MappingName = "consultation"
        '
        'csCorporationNo
        '
        Me.csCorporationNo.Format = ""
        Me.csCorporationNo.FormatInfo = Nothing
        Me.csCorporationNo.HeaderText = "企业编号"
        Me.csCorporationNo.MappingName = "corporation_code"
        Me.csCorporationNo.Width = 80
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "企业名称"
        Me.DataGridTextBoxColumn1.MappingName = "corporation_name"
        Me.DataGridTextBoxColumn1.Width = 150
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "业务品种"
        Me.DataGridTextBoxColumn2.MappingName = "apply_service_type"
        Me.DataGridTextBoxColumn2.Width = 120
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = "D"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "咨询日期"
        Me.DataGridTextBoxColumn3.MappingName = "consult_date"
        Me.DataGridTextBoxColumn3.Width = 120
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "所属地区"
        Me.DataGridTextBoxColumn4.MappingName = "district_name"
        Me.DataGridTextBoxColumn4.Width = 80
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "所属行业"
        Me.DataGridTextBoxColumn5.MappingName = "industry_type"
        Me.DataGridTextBoxColumn5.Width = 80
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "首次贷款"
        Me.DataGridBoolColumn1.MappingName = "is_first_loan"
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), System.DBNull)
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 60
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "推荐人"
        Me.DataGridTextBoxColumn7.MappingName = "recommend_person"
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "咨询人"
        Me.DataGridTextBoxColumn6.MappingName = "consult_person"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "创建人"
        Me.DataGridTextBoxColumn8.MappingName = "create_person"
        Me.DataGridTextBoxColumn8.Width = 75
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
        'FQueryConsultation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(592, 373)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grdTable, Me.grpCondition})
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "FQueryConsultation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "咨询企业一览表"
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

	Private Sub FConsultation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		dtpFromDate.Value = DateTime.Today
		dtpToDate.Value = DateTime.Today

		cboDistrictName.DataSource = gWs.GetDistrict("%").Tables(0)
		cboDistrictName.DisplayMember = "district_name"
		cboDistrictName.ValueMember = "district_name"
	End Sub

	Private Sub FConsultation_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		If e.KeyCode = Keys.F5 Then
			Me.Refresh("")
		End If
	End Sub

	Private Sub TextEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtConsultName.Enter, txtCorporationNo.Enter, txtCorporationName.Enter, txtRecommendName.Enter
		If (Not sender Is Nothing) AndAlso sender.GetType() Is GetType(TextBox) Then
			CType(sender, TextBox).SelectAll()
		End If
	End Sub

	Public Overloads Sub Refresh(ByVal Condition As String)
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim rsResult As DataSet = gWs.GetcorporationInfo("", Me.GetCondition())

			grdTable.SetDataBinding(rsResult, "consultation")
            Me.Text = "咨询企业一览表(" + rsResult.Tables("consultation").Rows.Count.ToString + ")"
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Private Function GetCondition() As String
		Dim condition As String

		If txtCorporationNo.Text.Trim() <> "" Then
			condition = "corporation_code LIKE '" + txtCorporationNo.Text + "'"
		End If
		If txtCorporationName.Text.Trim() <> "" Then
			condition += IIf(condition <> "", " AND ", "") + " corporation_name LIKE '" + txtCorporationName.Text + "'"
		End If
		If txtRecommendName.Text.Trim() <> "" Then
			condition += IIf(condition <> "", " AND ", "") + " recommend_person LIKE '" + txtRecommendName.Text + "'"
		End If
		If cboDistrictName.Text.Trim() <> "" Then
			condition += IIf(condition <> "", " AND ", "") + " district_name LIKE '" + cboDistrictName.Text + "'"
		End If
		If txtConsultName.Text.Trim() <> "" Then
			condition += IIf(condition <> "", " AND ", "") + " consult_person LIKE '" + txtConsultName.Text + "'"
		End If

		condition += IIf(condition <> "", " AND ", "") + " consult_date >= '" + dtpFromDate.Value.ToString("yyyy-MM-dd") + "'"
        condition += IIf(condition <> "", " AND ", "") + " consult_date <= '" + dtpToDate.Value.ToString("yyyy-MM-dd") + " 23:59'"

		If condition <> "" Then
			Return "{" + condition + "}"
		Else
			Return "%"
		End If
	End Function

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Dim reportViewerForm As FReportViewer = New FReportViewer()

		Try
			Dim dataSource As Object

			If Not grdTable.DataSource Is Nothing Then
                dataSource = CType(grdTable.DataSource, DataSet).Tables("consultation")
                If Not dataSource Is Nothing Then
                    CType(dataSource, DataTable).TableName = "TConsultation"
                End If

                dataSource = grdTable.DataSource
            End If

            reportViewerForm.ShowDialog(Application.StartupPath + "\Reports\QueryConsultation.rpt", dataSource, "咨询企业一览表", Me)
        Finally
			If Not reportViewerForm Is Nothing Then
				reportViewerForm.Dispose()
			End If
		End Try
	End Sub
End Class
