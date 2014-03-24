Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FQueryWorkLog
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
	Friend WithEvents chkVisible As System.Windows.Forms.CheckBox
	Friend WithEvents btnRefresh As System.Windows.Forms.Button
	Friend WithEvents btnExit As System.Windows.Forms.Button
	Friend WithEvents grdTable As System.Windows.Forms.DataGrid
	Friend WithEvents tsWorkLog As System.Windows.Forms.DataGridTableStyle
	Friend WithEvents btnPrint As System.Windows.Forms.Button
	Friend WithEvents csSerialID As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csProjectNo As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csTaskID As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csTaskName As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csAttendPerson As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csTaskStatus As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csFinishTime As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csStartTime As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csDayName As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csPeriod As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csDescription As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csPhase As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csProjectStatus As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csCreateDate As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents lblAttendPerson As System.Windows.Forms.Label
	Friend WithEvents lblSerialID As System.Windows.Forms.Label
	Friend WithEvents cboStaff As System.Windows.Forms.ComboBox
	Friend WithEvents lblStartTimeTo As System.Windows.Forms.Label
	Friend WithEvents dtpStartTimeFrom As System.Windows.Forms.DateTimePicker
	Friend WithEvents chkStartTime As System.Windows.Forms.CheckBox
	Friend WithEvents dtpStartTimeTo As System.Windows.Forms.DateTimePicker
	Friend WithEvents lblPeriod As System.Windows.Forms.Label
	Friend WithEvents cboPeriod As System.Windows.Forms.ComboBox
	Friend WithEvents cboTaskName As System.Windows.Forms.ComboBox
	Friend WithEvents txtDescription As System.Windows.Forms.TextBox
	Friend WithEvents lblDescription As System.Windows.Forms.Label
	Friend WithEvents btnClear As System.Windows.Forms.Button
	Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents crManHour As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryWorkLog))
        Me.grpCondition = New System.Windows.Forms.GroupBox
        Me.cboTaskName = New System.Windows.Forms.ComboBox
        Me.cboStaff = New System.Windows.Forms.ComboBox
        Me.cboPeriod = New System.Windows.Forms.ComboBox
        Me.lblStartTimeTo = New System.Windows.Forms.Label
        Me.dtpStartTimeTo = New System.Windows.Forms.DateTimePicker
        Me.dtpStartTimeFrom = New System.Windows.Forms.DateTimePicker
        Me.lblAttendPerson = New System.Windows.Forms.Label
        Me.lblPeriod = New System.Windows.Forms.Label
        Me.txtDescription = New System.Windows.Forms.TextBox
        Me.lblDescription = New System.Windows.Forms.Label
        Me.lblSerialID = New System.Windows.Forms.Label
        Me.chkStartTime = New System.Windows.Forms.CheckBox
        Me.chkVisible = New System.Windows.Forms.CheckBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExit = New System.Windows.Forms.Button
        Me.grdTable = New System.Windows.Forms.DataGrid
        Me.tsWorkLog = New System.Windows.Forms.DataGridTableStyle
        Me.csSerialID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csProjectNo = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csTaskID = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csStartTime = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csDayName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csPeriod = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csTaskName = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csTaskStatus = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csFinishTime = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csDescription = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csPhase = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csProjectStatus = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csAttendPerson = New System.Windows.Forms.DataGridTextBoxColumn
        Me.csCreateDate = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.crManHour = New System.Windows.Forms.DataGridTextBoxColumn
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpCondition.Controls.Add(Me.cboTaskName)
        Me.grpCondition.Controls.Add(Me.cboStaff)
        Me.grpCondition.Controls.Add(Me.cboPeriod)
        Me.grpCondition.Controls.Add(Me.lblStartTimeTo)
        Me.grpCondition.Controls.Add(Me.dtpStartTimeTo)
        Me.grpCondition.Controls.Add(Me.dtpStartTimeFrom)
        Me.grpCondition.Controls.Add(Me.lblAttendPerson)
        Me.grpCondition.Controls.Add(Me.lblPeriod)
        Me.grpCondition.Controls.Add(Me.txtDescription)
        Me.grpCondition.Controls.Add(Me.lblDescription)
        Me.grpCondition.Controls.Add(Me.lblSerialID)
        Me.grpCondition.Controls.Add(Me.chkStartTime)
        Me.grpCondition.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCondition.Location = New System.Drawing.Point(8, 8)
        Me.grpCondition.Name = "grpCondition"
        Me.grpCondition.Size = New System.Drawing.Size(696, 96)
        Me.grpCondition.TabIndex = 0
        Me.grpCondition.TabStop = False
        Me.grpCondition.Text = "查询条件"
        '
        'cboTaskName
        '
        Me.cboTaskName.Location = New System.Drawing.Point(64, 16)
        Me.cboTaskName.Name = "cboTaskName"
        Me.cboTaskName.Size = New System.Drawing.Size(120, 20)
        Me.cboTaskName.TabIndex = 2
        '
        'cboStaff
        '
        Me.cboStaff.Location = New System.Drawing.Point(64, 40)
        Me.cboStaff.Name = "cboStaff"
        Me.cboStaff.Size = New System.Drawing.Size(120, 20)
        Me.cboStaff.TabIndex = 6
        '
        'cboPeriod
        '
        Me.cboPeriod.Items.AddRange(New Object() {"正常上班", "平时加班", "假日加班", "请假", "休假", "出差"})
        Me.cboPeriod.Location = New System.Drawing.Point(272, 16)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(120, 20)
        Me.cboPeriod.TabIndex = 4
        '
        'lblStartTimeTo
        '
        Me.lblStartTimeTo.AutoSize = True
        Me.lblStartTimeTo.Location = New System.Drawing.Point(424, 44)
        Me.lblStartTimeTo.Name = "lblStartTimeTo"
        Me.lblStartTimeTo.Size = New System.Drawing.Size(17, 17)
        Me.lblStartTimeTo.TabIndex = 9
        Me.lblStartTimeTo.Text = "到"
        '
        'dtpStartTimeTo
        '
        Me.dtpStartTimeTo.Enabled = False
        Me.dtpStartTimeTo.Location = New System.Drawing.Point(448, 40)
        Me.dtpStartTimeTo.Name = "dtpStartTimeTo"
        Me.dtpStartTimeTo.Size = New System.Drawing.Size(120, 21)
        Me.dtpStartTimeTo.TabIndex = 10
        '
        'dtpStartTimeFrom
        '
        Me.dtpStartTimeFrom.CalendarFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpStartTimeFrom.Enabled = False
        Me.dtpStartTimeFrom.Location = New System.Drawing.Point(272, 40)
        Me.dtpStartTimeFrom.Name = "dtpStartTimeFrom"
        Me.dtpStartTimeFrom.Size = New System.Drawing.Size(120, 21)
        Me.dtpStartTimeFrom.TabIndex = 8
        '
        'lblAttendPerson
        '
        Me.lblAttendPerson.AutoSize = True
        Me.lblAttendPerson.Location = New System.Drawing.Point(8, 44)
        Me.lblAttendPerson.Name = "lblAttendPerson"
        Me.lblAttendPerson.Size = New System.Drawing.Size(54, 17)
        Me.lblAttendPerson.TabIndex = 5
        Me.lblAttendPerson.Text = "姓名"
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(216, 20)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(54, 17)
        Me.lblPeriod.TabIndex = 3
        Me.lblPeriod.Text = "时段"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescription.Location = New System.Drawing.Point(64, 64)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(504, 21)
        Me.txtDescription.TabIndex = 12
        Me.txtDescription.Text = ""
        '
        'lblDescription
        '
        Me.lblDescription.AutoSize = True
        Me.lblDescription.Location = New System.Drawing.Point(8, 68)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(54, 17)
        Me.lblDescription.TabIndex = 11
        Me.lblDescription.Text = "工作内容"
        '
        'lblSerialID
        '
        Me.lblSerialID.AutoSize = True
        Me.lblSerialID.Location = New System.Drawing.Point(8, 20)
        Me.lblSerialID.Name = "lblSerialID"
        Me.lblSerialID.Size = New System.Drawing.Size(54, 17)
        Me.lblSerialID.TabIndex = 1
        Me.lblSerialID.Text = "工作类别"
        '
        'chkStartTime
        '
        Me.chkStartTime.Location = New System.Drawing.Point(216, 40)
        Me.chkStartTime.Name = "chkStartTime"
        Me.chkStartTime.Size = New System.Drawing.Size(56, 24)
        Me.chkStartTime.TabIndex = 7
        Me.chkStartTime.Text = "日 期"
        '
        'chkVisible
        '
        Me.chkVisible.BackColor = System.Drawing.Color.Transparent
        Me.chkVisible.Checked = True
        Me.chkVisible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVisible.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVisible.Location = New System.Drawing.Point(8, 112)
        Me.chkVisible.Name = "chkVisible"
        Me.chkVisible.Size = New System.Drawing.Size(184, 24)
        Me.chkVisible.TabIndex = 13
        Me.chkVisible.Text = "是否显示查询条件设置(&V)"
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.ImageIndex = 2
        Me.btnRefresh.ImageList = Me.ImageList1
        Me.btnRefresh.Location = New System.Drawing.Point(432, 112)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(77, 23)
        Me.btnRefresh.TabIndex = 15
        Me.btnRefresh.Text = "查 询(&S)"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 3
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(624, 112)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 18
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdTable
        '
        Me.grdTable.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTable.CaptionVisible = False
        Me.grdTable.DataMember = ""
        Me.grdTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTable.Location = New System.Drawing.Point(8, 144)
        Me.grdTable.Name = "grdTable"
        Me.grdTable.ReadOnly = True
        Me.grdTable.Size = New System.Drawing.Size(696, 344)
        Me.grdTable.TabIndex = 19
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsWorkLog})
        '
        'tsWorkLog
        '
        Me.tsWorkLog.DataGrid = Me.grdTable
        Me.tsWorkLog.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csSerialID, Me.csProjectNo, Me.csTaskID, Me.csStartTime, Me.csDayName, Me.csPeriod, Me.csTaskName, Me.csTaskStatus, Me.csFinishTime, Me.csDescription, Me.crManHour, Me.csPhase, Me.csProjectStatus, Me.csAttendPerson, Me.csCreateDate})
        Me.tsWorkLog.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsWorkLog.MappingName = "TWorkLog"
        '
        'csSerialID
        '
        Me.csSerialID.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.csSerialID.Format = ""
        Me.csSerialID.FormatInfo = Nothing
        Me.csSerialID.HeaderText = "序号"
        Me.csSerialID.MappingName = "serial_num"
        Me.csSerialID.Width = 0
        '
        'csProjectNo
        '
        Me.csProjectNo.Format = ""
        Me.csProjectNo.FormatInfo = Nothing
        Me.csProjectNo.HeaderText = "项目编号"
        Me.csProjectNo.MappingName = "project_code"
        Me.csProjectNo.Width = 0
        '
        'csTaskID
        '
        Me.csTaskID.Format = ""
        Me.csTaskID.FormatInfo = Nothing
        Me.csTaskID.HeaderText = "任务编号"
        Me.csTaskID.MappingName = "task_id"
        Me.csTaskID.Width = 0
        '
        'csStartTime
        '
        Me.csStartTime.Format = "D"
        Me.csStartTime.FormatInfo = Nothing
        Me.csStartTime.HeaderText = "工作时间"
        Me.csStartTime.MappingName = "start_time"
        Me.csStartTime.Width = 120
        '
        'csDayName
        '
        Me.csDayName.Format = ""
        Me.csDayName.FormatInfo = Nothing
        Me.csDayName.HeaderText = "星期几"
        Me.csDayName.MappingName = "day_name"
        Me.csDayName.Width = 60
        '
        'csPeriod
        '
        Me.csPeriod.Format = ""
        Me.csPeriod.FormatInfo = Nothing
        Me.csPeriod.HeaderText = "时段"
        Me.csPeriod.MappingName = "period"
        Me.csPeriod.Width = 60
        '
        'csTaskName
        '
        Me.csTaskName.Format = ""
        Me.csTaskName.FormatInfo = Nothing
        Me.csTaskName.HeaderText = "工作类别"
        Me.csTaskName.MappingName = "task_name"
        Me.csTaskName.Width = 75
        '
        'csTaskStatus
        '
        Me.csTaskStatus.Format = ""
        Me.csTaskStatus.FormatInfo = Nothing
        Me.csTaskStatus.HeaderText = "任务状况"
        Me.csTaskStatus.MappingName = "task_status"
        Me.csTaskStatus.Width = 0
        '
        'csFinishTime
        '
        Me.csFinishTime.Format = "D"
        Me.csFinishTime.FormatInfo = Nothing
        Me.csFinishTime.HeaderText = "完成时间"
        Me.csFinishTime.MappingName = "finish_time"
        Me.csFinishTime.Width = 0
        '
        'csDescription
        '
        Me.csDescription.Format = ""
        Me.csDescription.FormatInfo = Nothing
        Me.csDescription.HeaderText = "工作内容"
        Me.csDescription.MappingName = "description"
        Me.csDescription.Width = 250
        '
        'csPhase
        '
        Me.csPhase.Format = ""
        Me.csPhase.FormatInfo = Nothing
        Me.csPhase.HeaderText = "项目阶段"
        Me.csPhase.MappingName = "project_phase"
        Me.csPhase.Width = 0
        '
        'csProjectStatus
        '
        Me.csProjectStatus.Format = ""
        Me.csProjectStatus.FormatInfo = Nothing
        Me.csProjectStatus.HeaderText = "项目状态"
        Me.csProjectStatus.MappingName = "project_status"
        Me.csProjectStatus.Width = 0
        '
        'csAttendPerson
        '
        Me.csAttendPerson.Format = ""
        Me.csAttendPerson.FormatInfo = Nothing
        Me.csAttendPerson.HeaderText = "姓  名"
        Me.csAttendPerson.MappingName = "attend_person"
        Me.csAttendPerson.Width = 60
        '
        'csCreateDate
        '
        Me.csCreateDate.Format = "D"
        Me.csCreateDate.FormatInfo = Nothing
        Me.csCreateDate.HeaderText = "创建日期"
        Me.csCreateDate.MappingName = "create_date"
        Me.csCreateDate.Width = 120
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.Location = New System.Drawing.Point(528, 112)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(77, 23)
        Me.btnPrint.TabIndex = 17
        Me.btnPrint.Text = "打 印(&P)"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPrint.Visible = False
        '
        'btnClear
        '
        Me.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClear.ImageIndex = 0
        Me.btnClear.ImageList = Me.ImageList1
        Me.btnClear.Location = New System.Drawing.Point(192, 112)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(77, 23)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "清 空(&C)"
        Me.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExport
        '
        Me.btnExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExport.ImageIndex = 1
        Me.btnExport.ImageList = Me.ImageList1
        Me.btnExport.Location = New System.Drawing.Point(528, 112)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(77, 23)
        Me.btnExport.TabIndex = 16
        Me.btnExport.Text = "导 出(&O)"
        Me.btnExport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'crManHour
        '
        Me.crManHour.Format = ""
        Me.crManHour.FormatInfo = Nothing
        Me.crManHour.HeaderText = "工时"
        Me.crManHour.MappingName = "man_hour"
        Me.crManHour.Width = 60
        '
        'FQueryWorkLog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.chkVisible)
        Me.Controls.Add(Me.grdTable)
        Me.Controls.Add(Me.grpCondition)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(720, 520)
        Me.Name = "FQueryWorkLog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "工作日志查询"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

	Private Const ALLSTAFF As String = "<所有用户>"

	Public Event Confirm(ByVal sender As Object, ByVal e As DataRowView)

	Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
		cboStaff.Text = UserName

		cboPeriod.Text = ""
		cboPeriod.SelectedIndex = -1
		cboPeriod.SelectedItem = Nothing
		cboTaskName.Text = ""
		cboTaskName.SelectedIndex = -1
		cboTaskName.SelectedItem = Nothing

		chkStartTime.Checked = False
		txtDescription.Text = ""
	End Sub

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
        btnClear.Top += h
        btnPrint.Top += h
        btnExport.Top += h
        btnRefresh.Top += h
        chkVisible.Top += h
        grdTable.Top += h
        grdTable.Height = Me.ClientSize.Height - grdTable.Top - 8
    End Sub

    Private Function SetPermission(Optional ByVal userID As String = "") As Boolean
        If userID Is Nothing OrElse userID.Trim = String.Empty Then
            userID = UserName
        End If

        Dim i As Integer
        Dim dtStaff As DataTable = gWs.GetStaff("%").Tables(0)
        dtStaff.PrimaryKey = New DataColumn() {dtStaff.Columns("staff_name")}

        Dim findRow = dtStaff.Rows.Find(userID)
        If findRow Is Nothing Then
            MessageBox.Show("当前 " + userID + " 用户没有指定的权限定义。", "无效的登录用户", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End If

        Dim permission As String = findRow("read_logs_right").ToString()
        Dim department As String = findRow("dept_name").ToString()
        Dim departmentList As String = SplitStringListForWhereCondition(findRow("logs_department_list").ToString())

        cboStaff.Items.Clear()
        cboStaff.Items.Add(ALLSTAFF)

        Select Case permission
            Case "0"
                cboStaff.Enabled = True
                cboStaff.DropDownStyle = ComboBoxStyle.DropDown

                For i = 0 To dtStaff.Rows.Count - 1
                    cboStaff.Items.Add(dtStaff.Rows(i)("staff_name"))
                Next
            Case "2"
                cboStaff.Enabled = True
                cboStaff.DropDownStyle = ComboBoxStyle.DropDownList

                Dim rows() As DataRow = dtStaff.Select("dept_name = '" + department + "'")
                For i = 0 To rows.Length - 1
                    cboStaff.Items.Add(rows(i)("staff_name"))
                Next
            Case "3"
                cboStaff.Enabled = True
                cboStaff.DropDownStyle = ComboBoxStyle.DropDownList

                cboStaff.Items.Add(userID)

                Dim rows() As DataRow = dtStaff.Select("read_logs_right = '1'")
                For i = 0 To rows.Length - 1
                    cboStaff.Items.Add(rows(i)("staff_name"))
                Next
            Case "4"
                cboStaff.Enabled = True
                cboStaff.DropDownStyle = ComboBoxStyle.DropDownList


                Dim rows() As DataRow = dtStaff.Select("dept_name in (" + departmentList + ")")
                For i = 0 To rows.Length - 1
                    cboStaff.Items.Add(rows(i)("staff_name"))
                Next
            Case Else
                cboStaff.Enabled = False
                cboStaff.DropDownStyle = ComboBoxStyle.Simple
        End Select

        cboStaff.Text = userID

        Return True
    End Function

    Private Sub FWorkLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpStartTimeFrom.Value = DateTime.Today
        dtpStartTimeTo.Value = DateTime.Today

        cboTaskName.DataSource = gWs.GetWorkType("%").Tables(0)
        cboTaskName.DisplayMember = "name"
        cboTaskName.ValueMember = "name"

        If Not SetPermission() Then
            Me.btnPrint.Enabled = False
            Me.btnRefresh.Enabled = False
        End If

        cboPeriod.Text = ""
        cboPeriod.SelectedItem = Nothing
        cboTaskName.Text = ""
        cboTaskName.SelectedItem = Nothing
    End Sub

    Private Sub FWorkLog_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.F5 And btnRefresh.Enabled Then
            Me.Refresh("")
        End If
    End Sub

    Private Sub TextEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.Enter
        If (Not sender Is Nothing) AndAlso sender.GetType() Is GetType(TextBox) Then
            CType(sender, TextBox).SelectAll()
        End If
    End Sub

    Public Overloads Sub Refresh(ByVal Condition As String)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim rsResult As DataSet = gWs.GetWorkLogInfo(Me.GetCondition())

            rsResult.Tables(0).TableName = "TWorkLog"

            grdTable.SetDataBinding(rsResult, "TWorkLog")
            Me.Text = "工作日志查询(" + rsResult.Tables("TWorkLog").Rows.Count.ToString + ")"
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GetCondition() As String
        Dim condition As String

        If cboTaskName.Text.Trim() <> "" Then
            condition = "task_name LIKE '" + cboTaskName.Text + "'"
        End If
        If cboPeriod.Text.Trim() <> "" Then
            condition += IIf(condition <> "", " AND ", "") + " period LIKE '" + cboPeriod.Text + "'"
        End If
        If cboStaff.Text.Trim() <> "" And cboStaff.Text <> ALLSTAFF Then
            condition += IIf(condition <> "", " AND ", "") + " attend_person LIKE '" + cboStaff.Text + "'"
        Else
            Dim i As Integer
            Dim sql As String

            For i = 1 To cboStaff.Items.Count - 1
                If sql <> "" Then
                    sql += " OR "
                End If

                sql += " attend_person LIKE '" + cboStaff.Items(i).ToString + "' "
            Next

            If sql <> "" Then
                sql = " (" + sql + ") "
            End If

            condition += IIf(condition <> "", " AND ", "") + sql
        End If
        If txtDescription.Text.Trim() <> "" Then
            condition += IIf(condition <> "", " AND ", "") + " description LIKE '%" + txtDescription.Text + "%'"
        End If

        If chkStartTime.Checked Then
            condition += IIf(condition <> "", " AND ", "") + " start_time >= '" + dtpStartTimeFrom.Value.ToString("yyyy-MM-dd") + "'"
            condition += IIf(condition <> "", " AND ", "") + " start_time <= '" + dtpStartTimeTo.Value.ToString("yyyy-MM-dd") + "'"
        End If

        If condition <> "" Then
            Return "{auto = 0 AND " + condition + " ORDER BY dbo.work_log.start_time DESC}"
        Else
            Return "{auto = 0 ORDER BY dbo.work_log.start_time DESC}"
        End If
    End Function

    Private Sub grdTable_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdTable.DoubleClick
        'Try
        '	If grdTable.DataSource Is Nothing Then
        '		Return
        '	End If

        '          Dim bm As BindingManagerBase = Me.BindingContext(grdTable.DataSource, "TWorkLog")

        '	If bm Is Nothing OrElse bm.Count <= 0 Then
        '		Return
        '	End If

        '	Dim rv As DataRowView = CType(bm.Current, DataRowView)

        '	If WorkLog Is Nothing OrElse WorkLog.IsDisposed Then
        '		WorkLog = New FWorkLog()
        '	End If

        '	WorkLog.Owner = Me.Owner
        '	WorkLog.MdiParent = Me.MdiParent
        '	WorkLog.Show()
        '	WorkLog.Activate()

        '	RaiseEvent Confirm(sender, rv)
        'Catch ex As System.Exception
        '	'统一错误处理
        '	ExceptionHandler.ShowMessageBox(ex)
        'End Try
    End Sub

    Private Sub chkStartTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkStartTime.CheckedChanged
        dtpStartTimeFrom.Enabled = chkStartTime.Checked
        dtpStartTimeTo.Enabled = chkStartTime.Checked
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click
        'Dim reportViewerForm As FReportViewer = New FReportViewer()

        'Try
        '	reportViewerForm.ShowDialog(Application.StartupPath + "\Reports\QueryWorkLog.rpt", grdTable.DataSource, "工作日志一览表", Me)
        'Finally
        '	If Not reportViewerForm Is Nothing Then
        '		reportViewerForm.Dispose()
        '	End If
        'End Try
    End Sub

    Private Sub btnExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExport.Click
        'Dim report As ReportObject = New ReportObject()
        'Dim dataSource As Object

        'If Not grdTable.DataSource Is Nothing Then
        '	dataSource = CType(grdTable.DataSource, DataSet).Tables(0)
        '	CType(dataSource, DataTable).TableName = "TWorkLog"
        '	dataSource = grdTable.DataSource
        'End If

        'report.DataSource = dataSource
        'report.ReportFile = Application.StartupPath + "\Reports\QueryWorkLog.rpt"
        'report.ReportTitle = "工作日志一览表"

        'report.Export()
        'report = Nothing

        Try
            Me.Cursor = Cursors.WaitCursor

            Dim export As ReportToExcel = New ReportToExcel()
            export.ToExcel(grdTable, "工作日志一览表", "工作日志一览表")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class
