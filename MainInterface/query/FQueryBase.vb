Public Class FQueryBase
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
	Public WithEvents grpCondition As System.Windows.Forms.GroupBox
	Public WithEvents chkVisible As System.Windows.Forms.CheckBox
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents btnRefresh As System.Windows.Forms.Button
	Public WithEvents grdTable As System.Windows.Forms.DataGrid
	Public WithEvents btnClear As System.Windows.Forms.Button
	Public WithEvents btnExport As System.Windows.Forms.Button
    Public WithEvents btnPrint As System.Windows.Forms.Button
    Public WithEvents ImageListQuery As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryBase))
        Me.grpCondition = New System.Windows.Forms.GroupBox()
        Me.chkVisible = New System.Windows.Forms.CheckBox()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.ImageListQuery = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.grdTable = New System.Windows.Forms.DataGrid()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grpCondition.Location = New System.Drawing.Point(8, 8)
        Me.grpCondition.Name = "grpCondition"
        Me.grpCondition.Size = New System.Drawing.Size(696, 96)
        Me.grpCondition.TabIndex = 0
        Me.grpCondition.TabStop = False
        Me.grpCondition.Text = "查询条件"
        '
        'chkVisible
        '
        Me.chkVisible.Checked = True
        Me.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVisible.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVisible.Location = New System.Drawing.Point(8, 112)
        Me.chkVisible.Name = "chkVisible"
        Me.chkVisible.Size = New System.Drawing.Size(184, 24)
        Me.chkVisible.TabIndex = 101
        Me.chkVisible.Text = "是否显示查询条件设置(&V)"
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.ImageList = Me.ImageListQuery
        Me.btnPrint.Location = New System.Drawing.Point(536, 112)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(77, 0)
        Me.btnPrint.TabIndex = 105
        Me.btnPrint.TabStop = False
        Me.btnPrint.Text = "打 印(&P)"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.Visible = False
        '
        'ImageListQuery
        '
        Me.ImageListQuery.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageListQuery.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListQuery.ImageStream = CType(resources.GetObject("ImageListQuery.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListQuery.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 3
        Me.btnExit.ImageList = Me.ImageListQuery
        Me.btnExit.Location = New System.Drawing.Point(624, 112)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 106
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.ImageIndex = 1
        Me.btnRefresh.ImageList = Me.ImageListQuery
        Me.btnRefresh.Location = New System.Drawing.Point(448, 112)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(77, 24)
        Me.btnRefresh.TabIndex = 103
        Me.btnRefresh.Text = "查 询(&S)"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.grdTable.Size = New System.Drawing.Size(696, 344)
        Me.grdTable.TabIndex = 107
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Bitmap)
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.ImageIndex = 0
        Me.btnClear.ImageList = Me.ImageListQuery
        Me.btnClear.Location = New System.Drawing.Point(192, 112)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 24)
        Me.btnClear.TabIndex = 102
        Me.btnClear.Text = "清 空(&C)"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExport
        '
        Me.btnExport.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Bitmap)
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport.ImageIndex = 2
        Me.btnExport.ImageList = Me.ImageListQuery
        Me.btnExport.Location = New System.Drawing.Point(536, 112)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(77, 24)
        Me.btnExport.TabIndex = 104
        Me.btnExport.Text = "导 出(&O)"
        Me.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FQueryBase
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.grpCondition, Me.btnExport, Me.btnClear, Me.grdTable, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.btnPrint})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(720, 520)
        Me.Name = "FQueryBase"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

	Private _dataSource As Object
	Private _reportFile As String
	Private _reportTitle As String

	Public Property DataSource() As Object
		Get
			Return _dataSource
		End Get
		Set(ByVal Value As Object)
			_dataSource = Value
		End Set
	End Property

	Public Property ReportFile() As String
		Get
			Return _reportFile
		End Get
		Set(ByVal Value As String)
			_reportFile = Value
		End Set
	End Property

	Public Property ReportTitle() As String
		Get
			Return _reportTitle
		End Get
		Set(ByVal Value As String)
			_reportTitle = Value
		End Set
	End Property

	Protected Overridable Sub SetLayout()
		Dim height As Integer = IIf(chkVisible.Checked, grpCondition.Height, -grpCondition.Height)

		grpCondition.Visible = chkVisible.Checked

		btnExit.Top += height
		btnClear.Top += height
		btnExport.Top += height
		btnPrint.Top += height
		btnRefresh.Top += height
		chkVisible.Top += height
		grdTable.Top += height
		grdTable.Height = Me.ClientSize.Height - grdTable.Top - 8
	End Sub

	Protected Overridable Sub Clear()
		Dim control As Control

		For Each control In grpCondition.Controls
			If control.GetType() Is GetType(TextBox) Then
				control.Text = ""
			End If
			If control.GetType() Is GetType(ComboBox) Then
				CType(control, ComboBox).SelectedIndex = -1
				CType(control, ComboBox).SelectedItem = Nothing
			End If
			If control.GetType() Is GetType(CheckBox) Then
				CType(control, CheckBox).Checked = False
			End If
		Next
	End Sub

	Protected Overridable Function GetCondition() As String
		Return "%"
	End Function

	Protected Overridable Overloads Sub Refresh(ByVal Condition As String)
		If Condition Is Nothing OrElse Condition.Trim() = "" Then
			Condition = Me.GetCondition()
		End If
	End Sub

	Protected Overridable Sub Export()
        'Dim report As ReportObject = New ReportObject()

        'If _dataSource Is Nothing Then
        '	_dataSource = grdTable.DataSource
        'End If

        'report.DataSource = _dataSource
        'report.ReportFile = _reportFile
        'report.ReportTitle = _reportTitle

        'report.Export()
        'report = Nothing

        Dim export As ReportToExcel = New ReportToExcel()

        export.ToExcel(grdTable, ReportTitle, ReportTitle)
	End Sub

	Protected Overridable Sub Print()
        'Dim i As Integer
        'Dim reportViewerForm As FReportViewer = New FReportViewer()

        'Try
        '	If _dataSource Is Nothing Then
        '		_dataSource = grdTable.DataSource
        '	End If

        '	reportViewerForm.ShowDialog(ReportFile, _dataSource, _reportTitle, Me)
        'Finally
        '	If Not reportViewerForm Is Nothing Then
        '		reportViewerForm.Dispose()
        '	End If
        'End Try
	End Sub

	Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
		Me.Clear()
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
		Try
			Me.Cursor = Cursors.WaitCursor

			Me.Refresh(Nothing)
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
		Try
			Me.Cursor = Cursors.AppStarting

			Me.Export()
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        Try
            Me.Cursor = Cursors.AppStarting

            Me.Print()
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub chkVisible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkVisible.CheckedChanged
        Me.SetLayout()
        Me.Clear()
    End Sub

    Private Sub FQueryBase_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Try
            If e.KeyCode = Keys.F5 Then
                Me.Cursor = Cursors.WaitCursor

                Me.Refresh(Nothing)
            End If
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    'Protected Overrides Sub OnLoad(ByVal e As System.EventArgs)
    '    MyBase.OnLoad(e)
    '    Me.Clear()
    'End Sub

    '在load时清除控件的默认值
    Private Sub ClearControl(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        Me.Clear()
    End Sub

    '调用此方法后保留控件的默认值
    Protected Sub RemoveClearControl()
        RemoveHandler MyBase.VisibleChanged, AddressOf ClearControl
    End Sub
End Class
