Public Class FQueryStatisticsBank
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
	Friend WithEvents lblDateTo As System.Windows.Forms.Label
	Friend WithEvents btnPrint As System.Windows.Forms.Button
	Friend WithEvents btnRefresh As System.Windows.Forms.Button
	Friend WithEvents grdTable As System.Windows.Forms.DataGrid
	Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
	Friend WithEvents btnExit As System.Windows.Forms.Button
	Friend WithEvents dtpDateFrom As System.Windows.Forms.DateTimePicker
	Friend WithEvents dtpDateTo As System.Windows.Forms.DateTimePicker
	Friend WithEvents csBank As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csSum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csBranchBank As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents rdoByBank As System.Windows.Forms.RadioButton
    Friend WithEvents rdoByBranch As System.Windows.Forms.RadioButton
    Friend WithEvents csCount As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryStatisticsBank))
        Me.lblDateFrom = New System.Windows.Forms.Label()
        Me.lblDateTo = New System.Windows.Forms.Label()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.grdTable = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.csBank = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csBranchBank = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCount = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dtpDateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpDateTo = New System.Windows.Forms.DateTimePicker()
        Me.rdoByBank = New System.Windows.Forms.RadioButton()
        Me.rdoByBranch = New System.Windows.Forms.RadioButton()
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
        'lblDateTo
        '
        Me.lblDateTo.Location = New System.Drawing.Point(208, 16)
        Me.lblDateTo.Name = "lblDateTo"
        Me.lblDateTo.Size = New System.Drawing.Size(40, 16)
        Me.lblDateTo.TabIndex = 2
        Me.lblDateTo.Text = "到(&T)"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnPrint.Location = New System.Drawing.Point(552, 40)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(80, 24)
        Me.btnPrint.TabIndex = 5
        Me.btnPrint.Text = "打 印(&P)"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnRefresh.Location = New System.Drawing.Point(464, 40)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(80, 24)
        Me.btnRefresh.TabIndex = 4
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
        Me.grdTable.Location = New System.Drawing.Point(8, 72)
        Me.grdTable.Name = "grdTable"
        Me.grdTable.ReadOnly = True
        Me.grdTable.Size = New System.Drawing.Size(712, 368)
        Me.grdTable.TabIndex = 7
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csBank, Me.csBranchBank, Me.csSum, Me.csCount})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'csBank
        '
        Me.csBank.Format = ""
        Me.csBank.FormatInfo = Nothing
        Me.csBank.HeaderText = "银行名称"
        Me.csBank.MappingName = "BankName"
        Me.csBank.Width = 120
        '
        'csBranchBank
        '
        Me.csBranchBank.Format = ""
        Me.csBranchBank.FormatInfo = Nothing
        Me.csBranchBank.HeaderText = "支行名称"
        Me.csBranchBank.MappingName = "BranchBankName"
        Me.csBranchBank.Width = 150
        '
        'csSum
        '
        Me.csSum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csSum.Format = "c"
        Me.csSum.FormatInfo = Nothing
        Me.csSum.HeaderText = "金 额"
        Me.csSum.MappingName = "ApplySum"
        Me.csSum.Width = 90
        '
        'csCount
        '
        Me.csCount.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csCount.Format = ""
        Me.csCount.FormatInfo = Nothing
        Me.csCount.HeaderText = "家 次"
        Me.csCount.MappingName = "ApplyCount"
        Me.csCount.Width = 75
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Location = New System.Drawing.Point(640, 40)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "退 出(&X)"
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.Location = New System.Drawing.Point(80, 8)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.ShowCheckBox = True
        Me.dtpDateFrom.Size = New System.Drawing.Size(120, 21)
        Me.dtpDateFrom.TabIndex = 1
        '
        'dtpDateTo
        '
        Me.dtpDateTo.Location = New System.Drawing.Point(248, 8)
        Me.dtpDateTo.Name = "dtpDateTo"
        Me.dtpDateTo.ShowCheckBox = True
        Me.dtpDateTo.Size = New System.Drawing.Size(120, 21)
        Me.dtpDateTo.TabIndex = 3
        '
        'rdoByBank
        '
        Me.rdoByBank.Checked = True
        Me.rdoByBank.Location = New System.Drawing.Point(384, 8)
        Me.rdoByBank.Name = "rdoByBank"
        Me.rdoByBank.Size = New System.Drawing.Size(120, 24)
        Me.rdoByBank.TabIndex = 8
        Me.rdoByBank.TabStop = True
        Me.rdoByBank.Text = "按银行统计(&1)"
        '
        'rdoByBranch
        '
        Me.rdoByBranch.Location = New System.Drawing.Point(512, 8)
        Me.rdoByBranch.Name = "rdoByBranch"
        Me.rdoByBranch.Size = New System.Drawing.Size(120, 24)
        Me.rdoByBranch.TabIndex = 9
        Me.rdoByBranch.Text = "按支行统计(&2)"
        '
        'FQueryStatisticsBank
        '
        Me.AcceptButton = Me.btnRefresh
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(728, 445)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.rdoByBranch, Me.rdoByBank, Me.dtpDateTo, Me.dtpDateFrom, Me.btnExit, Me.grdTable, Me.btnPrint, Me.btnRefresh, Me.lblDateTo, Me.lblDateFrom})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FQueryStatisticsBank"
        Me.Text = "合作银行统计"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

	Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
		Dim reportViewerForm As FReportViewer = New FReportViewer()

		Try
			Dim dataSource As Object

			Me.Cursor = Cursors.WaitCursor

			If Not grdTable.DataSource Is Nothing Then
				dataSource = CType(grdTable.DataSource, DataSet).Tables(0)
				CType(dataSource, DataTable).TableName = "TQueryStatisticsBank"
				dataSource = grdTable.DataSource
			End If

			reportViewerForm.ShowDialog(Application.StartupPath + "\Reports\QueryStatisticsBank.rpt", dataSource, "合作银行统计", Me)
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

            Dim startDate As DateTime = DateTime.MinValue
            If dtpDateFrom.Checked Then
                startDate = dtpDateFrom.Value
            End If

            Dim endDate As DateTime = DateTime.MaxValue
            If dtpDateTo.Checked Then
                endDate = dtpDateTo.Value
            End If

            Dim groupType As Int32 = IIf(rdoByBank.Checked, 0, 1)
            Dim rsResult As DataSet = gWs.GetQueryStatisticsBankInfo(startDate, endDate, groupType)

            grdTable.SetDataBinding(rsResult, "Table")
            Me.Text = "合作银行统计(" + rsResult.Tables("Table").Rows.Count.ToString + ")"
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub FQueryStatisticsBank_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Refresh()
        End If
    End Sub
End Class
