Public Class FQueryStatisticsAssurance
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
	Friend WithEvents lblDateFrom As System.Windows.Forms.Label
	Friend WithEvents cboDateFrom As System.Windows.Forms.ComboBox
	Friend WithEvents cboDateTo As System.Windows.Forms.ComboBox
	Friend WithEvents lblDateTo As System.Windows.Forms.Label
	Friend WithEvents cboMonthTo As System.Windows.Forms.ComboBox
	Friend WithEvents btnPrint As System.Windows.Forms.Button
	Friend WithEvents btnRefresh As System.Windows.Forms.Button
	Friend WithEvents grdTable As System.Windows.Forms.DataGrid
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
	Friend WithEvents btnExit As System.Windows.Forms.Button
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryStatisticsAssurance))
		Me.lblDateFrom = New System.Windows.Forms.Label()
		Me.cboDateFrom = New System.Windows.Forms.ComboBox()
		Me.cboDateTo = New System.Windows.Forms.ComboBox()
		Me.lblDateTo = New System.Windows.Forms.Label()
		Me.cboMonthTo = New System.Windows.Forms.ComboBox()
		Me.btnPrint = New System.Windows.Forms.Button()
		Me.btnRefresh = New System.Windows.Forms.Button()
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
		Me.btnExit = New System.Windows.Forms.Button()
		CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'lblDateFrom
		'
		Me.lblDateFrom.Location = New System.Drawing.Point(8, 14)
		Me.lblDateFrom.Name = "lblDateFrom"
		Me.lblDateFrom.Size = New System.Drawing.Size(72, 16)
		Me.lblDateFrom.TabIndex = 0
		Me.lblDateFrom.Text = "起始年月(&F)"
		'
		'cboDateFrom
		'
		Me.cboDateFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboDateFrom.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDateFrom.Location = New System.Drawing.Point(80, 8)
		Me.cboDateFrom.Name = "cboDateFrom"
		Me.cboDateFrom.Size = New System.Drawing.Size(72, 22)
		Me.cboDateFrom.TabIndex = 1
		'
		'cboDateTo
		'
		Me.cboDateTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboDateTo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboDateTo.Location = New System.Drawing.Point(200, 8)
		Me.cboDateTo.Name = "cboDateTo"
		Me.cboDateTo.Size = New System.Drawing.Size(72, 22)
		Me.cboDateTo.TabIndex = 3
		'
		'lblDateTo
		'
		Me.lblDateTo.Location = New System.Drawing.Point(160, 16)
		Me.lblDateTo.Name = "lblDateTo"
		Me.lblDateTo.Size = New System.Drawing.Size(40, 16)
		Me.lblDateTo.TabIndex = 2
		Me.lblDateTo.Text = "到(&T)"
		'
		'cboMonthTo
		'
		Me.cboMonthTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.cboMonthTo.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cboMonthTo.Location = New System.Drawing.Point(272, 8)
		Me.cboMonthTo.Name = "cboMonthTo"
		Me.cboMonthTo.Size = New System.Drawing.Size(48, 22)
		Me.cboMonthTo.TabIndex = 4
		'
		'btnPrint
		'
		Me.btnPrint.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
		Me.btnPrint.Location = New System.Drawing.Point(416, 8)
		Me.btnPrint.Name = "btnPrint"
		Me.btnPrint.Size = New System.Drawing.Size(80, 24)
		Me.btnPrint.TabIndex = 6
		Me.btnPrint.Text = "打 印(&P)"
		'
		'btnRefresh
		'
		Me.btnRefresh.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
		Me.btnRefresh.Location = New System.Drawing.Point(328, 8)
		Me.btnRefresh.Name = "btnRefresh"
		Me.btnRefresh.Size = New System.Drawing.Size(80, 24)
		Me.btnRefresh.TabIndex = 5
		Me.btnRefresh.Text = "查 询(&S)"
		'
		'grdTable
		'
		Me.grdTable.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
					Or System.Windows.Forms.AnchorStyles.Left) _
					Or System.Windows.Forms.AnchorStyles.Right)
		Me.grdTable.CaptionVisible = False
		Me.grdTable.DataMember = ""
		Me.grdTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.grdTable.Location = New System.Drawing.Point(8, 48)
		Me.grdTable.Name = "grdTable"
		Me.grdTable.ReadOnly = True
		Me.grdTable.Size = New System.Drawing.Size(576, 320)
		Me.grdTable.TabIndex = 8
		Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
		'
		'DataGridTableStyle1
		'
		Me.DataGridTableStyle1.DataGrid = Me.grdTable
		Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9})
		Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.DataGridTableStyle1.MappingName = "Table"
		Me.DataGridTableStyle1.ReadOnly = True
		'
		'DataGridTextBoxColumn1
		'
		Me.DataGridTextBoxColumn1.Format = ""
		Me.DataGridTextBoxColumn1.FormatInfo = Nothing
		Me.DataGridTextBoxColumn1.HeaderText = "年月"
		Me.DataGridTextBoxColumn1.MappingName = "Year"
		Me.DataGridTextBoxColumn1.Width = 60
		'
		'DataGridTextBoxColumn2
		'
		Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.DataGridTextBoxColumn2.Format = "c"
		Me.DataGridTextBoxColumn2.FormatInfo = Nothing
		Me.DataGridTextBoxColumn2.HeaderText = "申请担保金额"
		Me.DataGridTextBoxColumn2.MappingName = "ApplySum"
		Me.DataGridTextBoxColumn2.Width = 90
		'
		'DataGridTextBoxColumn3
		'
		Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.DataGridTextBoxColumn3.Format = ""
		Me.DataGridTextBoxColumn3.FormatInfo = Nothing
		Me.DataGridTextBoxColumn3.HeaderText = "申请担保家次"
		Me.DataGridTextBoxColumn3.MappingName = "ApplyCount"
		Me.DataGridTextBoxColumn3.Width = 60
		'
		'DataGridTextBoxColumn4
		'
		Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.DataGridTextBoxColumn4.Format = "C"
		Me.DataGridTextBoxColumn4.FormatInfo = Nothing
		Me.DataGridTextBoxColumn4.HeaderText = "正式受理金额"
		Me.DataGridTextBoxColumn4.MappingName = "TakeSum"
		Me.DataGridTextBoxColumn4.Width = 90
		'
		'DataGridTextBoxColumn5
		'
		Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.DataGridTextBoxColumn5.Format = ""
		Me.DataGridTextBoxColumn5.FormatInfo = Nothing
		Me.DataGridTextBoxColumn5.HeaderText = "正式受理家次"
		Me.DataGridTextBoxColumn5.MappingName = "TakeCount"
		Me.DataGridTextBoxColumn5.Width = 60
		'
		'DataGridTextBoxColumn6
		'
		Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.DataGridTextBoxColumn6.Format = "C"
		Me.DataGridTextBoxColumn6.FormatInfo = Nothing
		Me.DataGridTextBoxColumn6.HeaderText = "通过评审金额"
		Me.DataGridTextBoxColumn6.MappingName = "TrialSum"
		Me.DataGridTextBoxColumn6.Width = 90
		'
		'DataGridTextBoxColumn7
		'
		Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.DataGridTextBoxColumn7.Format = ""
		Me.DataGridTextBoxColumn7.FormatInfo = Nothing
		Me.DataGridTextBoxColumn7.HeaderText = "通过评审家次"
		Me.DataGridTextBoxColumn7.MappingName = "TrialCount"
		Me.DataGridTextBoxColumn7.Width = 60
		'
		'DataGridTextBoxColumn8
		'
		Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.DataGridTextBoxColumn8.Format = "C"
		Me.DataGridTextBoxColumn8.FormatInfo = Nothing
		Me.DataGridTextBoxColumn8.HeaderText = "签约担保金额"
		Me.DataGridTextBoxColumn8.MappingName = "SignSum"
		Me.DataGridTextBoxColumn8.Width = 90
		'
		'DataGridTextBoxColumn9
		'
		Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Right
		Me.DataGridTextBoxColumn9.Format = ""
		Me.DataGridTextBoxColumn9.FormatInfo = Nothing
		Me.DataGridTextBoxColumn9.HeaderText = "签约担保家次"
		Me.DataGridTextBoxColumn9.MappingName = "SignCount"
		Me.DataGridTextBoxColumn9.Width = 60
		'
		'btnExit
		'
		Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
		Me.btnExit.Location = New System.Drawing.Point(504, 8)
		Me.btnExit.Name = "btnExit"
		Me.btnExit.Size = New System.Drawing.Size(80, 24)
		Me.btnExit.TabIndex = 7
		Me.btnExit.Text = "退 出(&X)"
		'
		'FQueryStatisticsAssurance
		'
		Me.AcceptButton = Me.btnRefresh
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.ClientSize = New System.Drawing.Size(592, 373)
		Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.grdTable, Me.btnPrint, Me.btnRefresh, Me.cboMonthTo, Me.cboDateTo, Me.lblDateTo, Me.cboDateFrom, Me.lblDateFrom})
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.Name = "FQueryStatisticsAssurance"
		Me.Text = "担保业务统计"
		CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

#End Region

	Private Sub FStatisticsAssurance_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Const FIRSTYEAR = 1970
		Const LASTYEAR = 2100

		Dim i As Integer

		For i = 1 To 12
			cboMonthTo.Items.Add(i.ToString())
		Next

		For i = FIRSTYEAR To LASTYEAR
			cboDateTo.Items.Add(i.ToString())
			cboDateFrom.Items.Add(i.ToString())
		Next

		cboMonthTo.SelectedIndex = DateTime.Today.Month - 1
		cboDateTo.SelectedIndex = DateTime.Today.Year - FIRSTYEAR
		cboDateFrom.SelectedIndex = DateTime.Today.Year - FIRSTYEAR
	End Sub

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Dim reportViewerForm As FReportViewer = New FReportViewer()

		Try
			Dim dataSource As Object

			Me.Cursor = Cursors.WaitCursor

			If Not grdTable.DataSource Is Nothing Then
				dataSource = CType(grdTable.DataSource, DataSet).Tables(0)
				CType(dataSource, DataTable).TableName = "TQueryStatisticsAssurance"
				dataSource = grdTable.DataSource
			End If

			reportViewerForm.ShowDialog(Application.StartupPath + "\Reports\QueryStatisticsAssurance.rpt", dataSource, "担保业务统计", Me)
		Finally
			Me.Cursor = Cursors.Default

			If Not reportViewerForm Is Nothing Then
				reportViewerForm.Dispose()
			End If
		End Try
	End Sub

	Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
		Me.Refresh()
	End Sub

	Public Overloads Sub Refresh()
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim dateFrom, dateTo As DateTime

			dateFrom = DateTime.Parse(cboDateFrom.Text + "-1-1")
			dateTo = DateTime.Parse(cboDateTo.Text + "-12-31")

			Dim rsResult As DataSet = gWs.GetQueryStatisticsAssuranceInfo(dateFrom, dateTo)

			grdTable.SetDataBinding(rsResult, "Table")
			Me.Text = "担保业务统计(" + rsResult.Tables("Table").Rows.Count.ToString + ")"
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Private Sub FQueryStatisticsAssurance_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
		If e.KeyCode = Keys.F5 Then
			Me.Refresh()
		End If
	End Sub
End Class
