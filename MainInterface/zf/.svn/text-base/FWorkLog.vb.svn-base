Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FWorkLog
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
	Friend WithEvents lblTaskName As System.Windows.Forms.Label
	Friend WithEvents cboTaskName As System.Windows.Forms.ComboBox
	Friend WithEvents lblStartTime As System.Windows.Forms.Label
	Friend WithEvents dtpStartTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents lblPeriod As System.Windows.Forms.Label
	Friend WithEvents txtAttendName As System.Windows.Forms.TextBox
	Friend WithEvents lblAttendName As System.Windows.Forms.Label
	Friend WithEvents txtCreateDate As System.Windows.Forms.TextBox
	Friend WithEvents lblCreateDate As System.Windows.Forms.Label
	Friend WithEvents txtDescription As System.Windows.Forms.TextBox
	Friend WithEvents lblDescription As System.Windows.Forms.Label
	Friend WithEvents btnAddNew As System.Windows.Forms.Button
	Friend WithEvents btnDelete As System.Windows.Forms.Button
	Friend WithEvents btnSave As System.Windows.Forms.Button
	Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents grdTable As System.Windows.Forms.DataGrid
    Friend WithEvents tsWorkLog As System.Windows.Forms.DataGridTableStyle
	Friend WithEvents csSerialID As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csTaskName As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csStartTime As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csPeriod As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csDayName As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csDescription As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csAttendPerson As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csCreateDate As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboSubTaskName As System.Windows.Forms.ComboBox
    Friend WithEvents lblSubTaskName As System.Windows.Forms.Label
    Friend WithEvents csSubtaskName As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FWorkLog))
        Me.lblTaskName = New System.Windows.Forms.Label()
        Me.cboTaskName = New System.Windows.Forms.ComboBox()
        Me.lblStartTime = New System.Windows.Forms.Label()
        Me.dtpStartTime = New System.Windows.Forms.DateTimePicker()
        Me.cboPeriod = New System.Windows.Forms.ComboBox()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.txtAttendName = New System.Windows.Forms.TextBox()
        Me.lblAttendName = New System.Windows.Forms.Label()
        Me.txtCreateDate = New System.Windows.Forms.TextBox()
        Me.lblCreateDate = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.lblDescription = New System.Windows.Forms.Label()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grdTable = New System.Windows.Forms.DataGrid()
        Me.tsWorkLog = New System.Windows.Forms.DataGridTableStyle()
        Me.csSerialID = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csStartTime = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csDayName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csPeriod = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTaskName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSubtaskName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csDescription = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csAttendPerson = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCreateDate = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cboSubTaskName = New System.Windows.Forms.ComboBox()
        Me.lblSubTaskName = New System.Windows.Forms.Label()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTaskName
        '
        Me.lblTaskName.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.lblTaskName.BackColor = System.Drawing.Color.Transparent
        Me.lblTaskName.Location = New System.Drawing.Point(8, 256)
        Me.lblTaskName.Name = "lblTaskName"
        Me.lblTaskName.Size = New System.Drawing.Size(56, 16)
        Me.lblTaskName.TabIndex = 5
        Me.lblTaskName.Text = "职责类别"
        '
        'cboTaskName
        '
        Me.cboTaskName.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.cboTaskName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTaskName.Location = New System.Drawing.Point(64, 248)
        Me.cboTaskName.MaxLength = 20
        Me.cboTaskName.Name = "cboTaskName"
        Me.cboTaskName.Size = New System.Drawing.Size(160, 22)
        Me.cboTaskName.TabIndex = 6
        '
        'lblStartTime
        '
        Me.lblStartTime.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.lblStartTime.BackColor = System.Drawing.Color.Transparent
        Me.lblStartTime.Location = New System.Drawing.Point(8, 232)
        Me.lblStartTime.Name = "lblStartTime"
        Me.lblStartTime.Size = New System.Drawing.Size(56, 16)
        Me.lblStartTime.TabIndex = 1
        Me.lblStartTime.Text = "工作日期"
        '
        'dtpStartTime
        '
        Me.dtpStartTime.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.dtpStartTime.CustomFormat = "yyyy年MM月dd ddd"
        Me.dtpStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpStartTime.Location = New System.Drawing.Point(64, 224)
        Me.dtpStartTime.Name = "dtpStartTime"
        Me.dtpStartTime.Size = New System.Drawing.Size(160, 21)
        Me.dtpStartTime.TabIndex = 2
        '
        'cboPeriod
        '
        Me.cboPeriod.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.cboPeriod.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriod.Items.AddRange(New Object() {"上 午", "下 午", "加 班"})
        Me.cboPeriod.Location = New System.Drawing.Point(304, 224)
        Me.cboPeriod.MaxLength = 10
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(320, 22)
        Me.cboPeriod.TabIndex = 4
        '
        'lblPeriod
        '
        Me.lblPeriod.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.lblPeriod.BackColor = System.Drawing.Color.Transparent
        Me.lblPeriod.Location = New System.Drawing.Point(248, 232)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(56, 16)
        Me.lblPeriod.TabIndex = 3
        Me.lblPeriod.Text = "时段"
        '
        'txtAttendName
        '
        Me.txtAttendName.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.txtAttendName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAttendName.Location = New System.Drawing.Point(64, 272)
        Me.txtAttendName.Name = "txtAttendName"
        Me.txtAttendName.ReadOnly = True
        Me.txtAttendName.Size = New System.Drawing.Size(160, 21)
        Me.txtAttendName.TabIndex = 10
        Me.txtAttendName.TabStop = False
        Me.txtAttendName.Text = ""
        Me.txtAttendName.Visible = False
        '
        'lblAttendName
        '
        Me.lblAttendName.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.lblAttendName.BackColor = System.Drawing.Color.Transparent
        Me.lblAttendName.Location = New System.Drawing.Point(8, 280)
        Me.lblAttendName.Name = "lblAttendName"
        Me.lblAttendName.Size = New System.Drawing.Size(56, 16)
        Me.lblAttendName.TabIndex = 9
        Me.lblAttendName.Text = "姓名"
        Me.lblAttendName.Visible = False
        '
        'txtCreateDate
        '
        Me.txtCreateDate.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtCreateDate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCreateDate.Location = New System.Drawing.Point(304, 272)
        Me.txtCreateDate.Name = "txtCreateDate"
        Me.txtCreateDate.ReadOnly = True
        Me.txtCreateDate.Size = New System.Drawing.Size(320, 21)
        Me.txtCreateDate.TabIndex = 12
        Me.txtCreateDate.TabStop = False
        Me.txtCreateDate.Text = ""
        Me.txtCreateDate.Visible = False
        '
        'lblCreateDate
        '
        Me.lblCreateDate.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.lblCreateDate.BackColor = System.Drawing.Color.Transparent
        Me.lblCreateDate.Location = New System.Drawing.Point(248, 280)
        Me.lblCreateDate.Name = "lblCreateDate"
        Me.lblCreateDate.Size = New System.Drawing.Size(56, 16)
        Me.lblCreateDate.TabIndex = 11
        Me.lblCreateDate.Text = "创建日期"
        Me.lblCreateDate.Visible = False
        '
        'txtDescription
        '
        Me.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtDescription.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescription.Location = New System.Drawing.Point(64, 272)
        Me.txtDescription.MaxLength = 500
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtDescription.Size = New System.Drawing.Size(560, 144)
        Me.txtDescription.TabIndex = 14
        Me.txtDescription.Text = ""
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.lblDescription.BackColor = System.Drawing.Color.Transparent
        Me.lblDescription.Location = New System.Drawing.Point(8, 280)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(56, 16)
        Me.lblDescription.TabIndex = 13
        Me.lblDescription.Text = "工作内容"
        '
        'btnAddNew
        '
        Me.btnAddNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnAddNew.Location = New System.Drawing.Point(148, 424)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(80, 24)
        Me.btnAddNew.TabIndex = 101
        Me.btnAddNew.Text = "新 增(&A)"
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Location = New System.Drawing.Point(236, 424)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(80, 24)
        Me.btnDelete.TabIndex = 102
        Me.btnDelete.Text = "删 除(&D)"
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Location = New System.Drawing.Point(324, 424)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(80, 24)
        Me.btnSave.TabIndex = 103
        Me.btnSave.Text = "保 存(&S)"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Location = New System.Drawing.Point(412, 424)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.TabIndex = 104
        Me.btnExit.Text = "退 出(&X)"
        '
        'grdTable
        '
        Me.grdTable.AllowSorting = False
        Me.grdTable.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grdTable.CaptionVisible = False
        Me.grdTable.DataMember = ""
        Me.grdTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTable.Location = New System.Drawing.Point(8, 8)
        Me.grdTable.Name = "grdTable"
        Me.grdTable.Size = New System.Drawing.Size(616, 208)
        Me.grdTable.TabIndex = 0
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsWorkLog})
        '
        'tsWorkLog
        '
        Me.tsWorkLog.DataGrid = Me.grdTable
        Me.tsWorkLog.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csSerialID, Me.csStartTime, Me.csDayName, Me.csPeriod, Me.csTaskName, Me.csSubtaskName, Me.csDescription, Me.csAttendPerson, Me.csCreateDate})
        Me.tsWorkLog.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsWorkLog.MappingName = "work_log"
        Me.tsWorkLog.ReadOnly = True
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
        'csStartTime
        '
        Me.csStartTime.Format = "D"
        Me.csStartTime.FormatInfo = Nothing
        Me.csStartTime.HeaderText = "工作日期"
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
        Me.csPeriod.HeaderText = "时 段"
        Me.csPeriod.MappingName = "period"
        Me.csPeriod.Width = 60
        '
        'csTaskName
        '
        Me.csTaskName.Format = ""
        Me.csTaskName.FormatInfo = Nothing
        Me.csTaskName.HeaderText = "职责类别"
        Me.csTaskName.MappingName = "task_name"
        Me.csTaskName.Width = 80
        '
        'csSubtaskName
        '
        Me.csSubtaskName.Format = ""
        Me.csSubtaskName.FormatInfo = Nothing
        Me.csSubtaskName.HeaderText = "工作类别"
        Me.csSubtaskName.MappingName = "subtask_name"
        Me.csSubtaskName.Width = 80
        '
        'csDescription
        '
        Me.csDescription.Format = ""
        Me.csDescription.FormatInfo = Nothing
        Me.csDescription.HeaderText = "工作内容"
        Me.csDescription.MappingName = "description"
        Me.csDescription.Width = 250
        '
        'csAttendPerson
        '
        Me.csAttendPerson.Format = ""
        Me.csAttendPerson.FormatInfo = Nothing
        Me.csAttendPerson.HeaderText = "创建人"
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
        'cboSubTaskName
        '
        Me.cboSubTaskName.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.cboSubTaskName.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSubTaskName.Location = New System.Drawing.Point(304, 248)
        Me.cboSubTaskName.MaxLength = 20
        Me.cboSubTaskName.Name = "cboSubTaskName"
        Me.cboSubTaskName.Size = New System.Drawing.Size(320, 22)
        Me.cboSubTaskName.TabIndex = 8
        '
        'lblSubTaskName
        '
        Me.lblSubTaskName.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.lblSubTaskName.BackColor = System.Drawing.Color.Transparent
        Me.lblSubTaskName.Location = New System.Drawing.Point(248, 256)
        Me.lblSubTaskName.Name = "lblSubTaskName"
        Me.lblSubTaskName.Size = New System.Drawing.Size(56, 16)
        Me.lblSubTaskName.TabIndex = 7
        Me.lblSubTaskName.Text = "工作类别"
        '
        'FWorkLog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboSubTaskName, Me.lblSubTaskName, Me.grdTable, Me.btnExit, Me.btnSave, Me.btnDelete, Me.btnAddNew, Me.txtDescription, Me.lblDescription, Me.txtCreateDate, Me.lblCreateDate, Me.txtAttendName, Me.lblAttendName, Me.cboPeriod, Me.lblPeriod, Me.dtpStartTime, Me.lblStartTime, Me.cboTaskName, Me.lblTaskName})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MinimumSize = New System.Drawing.Size(480, 400)
        Me.Name = "FWorkLog"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "工作日志"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private _serialID As Long
    Private _dsWorkLog As DataSet
	Private _cmWorkLog As CurrencyManager

    Private Sub Table_ColumnChanged(ByVal sender As Object, ByVal e As DataColumnChangeEventArgs)
        'MessageBox.Show(e.Row(e.Column).ToString() + vbCrLf + e.Column.ColumnName, "Table_ColumnChanged")

        If e.Column.ColumnName = "start_time" Then
            Dim dt As DateTime = e.Row(e.Column)

            If dt < gWs.GetSysTime().AddDays(-7) Then
                MessageBox.Show("您不能录入一周（七天）以前的工作日志。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                e.Row.CancelEdit()
            Else
                e.Row("day_name") = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetDayName(dt.DayOfWeek)
                e.Row.EndEdit()
            End If
        End If

        'e.Row.EndEdit()
        _cmWorkLog.Refresh()
    End Sub

    Private Sub WorkLog_CurrentChanged(ByVal sender As Object, ByVal e As EventArgs)
        '	Dim bm As BindingManagerBase = CType(sender, BindingManagerBase)
        '	If Not (bm.Current.GetType() Is GetType(DataRowView)) Then
        '		Return
        '	End If

        '	Dim rv As DataRowView = CType(bm.Current, DataRowView)
        '	If rv.IsNew Then
        '		dtpStartTime.Value = DateTime.Today
        '		txtDayName.Text = ""
        '		cboPeriod.Text = ""
        '		txtAttendName.Text = ""
        '		txtDescription.Text = ""
        '		cboTaskName.Text = ""
        '       cboSubTaskName.Text = ""
        '		txtCreateDate.Text = DateTime.Now
        '	Else
        '		dtpStartTime.Value = IIf(rv("start_time") Is DBNull.Value, DateTime.Today, rv("start_time"))
        '		txtDayName.Text = IIf(rv("day_name") Is DBNull.Value, "", rv("day_name"))
        '		cboPeriod.Text = rv("period").ToString()
        '		txtAttendName.Text = rv("attend_person").ToString()
        '		txtDescription.Text = rv("description").ToString()
        '		cboTaskName.Text = rv("task_name").ToString()
        '       cboSubTaskName.Text = rv("subtask_name").ToString()
        '		txtCreateDate.Text = rv("create_date").ToString
        '	End If
    End Sub

    Private Sub ReBinding()
        dtpStartTime.DataBindings.Clear()
        cboPeriod.DataBindings.Clear()
        txtAttendName.DataBindings.Clear()
        txtCreateDate.DataBindings.Clear()
        txtDescription.DataBindings.Clear()
        cboTaskName.DataBindings.Clear()
        cboSubTaskName.DataBindings.Clear()

        _dsWorkLog.Tables("work_log").DefaultView.RowStateFilter = (DataViewRowState.Unchanged Or DataViewRowState.Added)

        If _dsWorkLog.Tables("work_log").DefaultView.Count > 0 Then
            dtpStartTime.DataBindings.Add("Value", _dsWorkLog, "work_log.start_time")
            cboPeriod.DataBindings.Add("Text", _dsWorkLog, "work_log.period")
            txtAttendName.DataBindings.Add("Text", _dsWorkLog, "work_log.attend_person")
            txtDescription.DataBindings.Add("Text", _dsWorkLog, "work_log.description")
            cboTaskName.DataBindings.Add("Text", _dsWorkLog, "work_log.task_name")
            cboSubTaskName.DataBindings.Add("Text", _dsWorkLog, "work_log.subtask_name")
            txtCreateDate.DataBindings.Add("Text", _dsWorkLog, "work_log.create_date")
        End If

        _dsWorkLog.Tables("work_log").DefaultView.RowStateFilter = DataViewRowState.None
    End Sub

    Public Overloads Sub Refresh(ByVal SerialID As Long)
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim sysTime As DateTime = gWs.GetSysTime()

            If SerialID = 0 Then
                _dsWorkLog = gWs.GetWorkLogInfo("{start_time > '" + sysTime.AddDays(-7).ToString("yyyy-MM-dd") + "' AND attend_person = '" + UserName.ToString() + "' AND auto = 0}")
            Else
                _dsWorkLog = gWs.GetWorkLogInfo("{serial_num = " + SerialID.ToString() + " OR (start_time > '" + sysTime.AddDays(-7).ToString("yyyy-MM-dd") + "' AND attend_person = '" + UserName.ToString() + "' AND auto = 0)}")
            End If

            grdTable.SetDataBinding(_dsWorkLog, "work_log")

            Me.ReBinding()

            _serialID = SerialID
            _cmWorkLog = Me.BindingContext(_dsWorkLog, "work_log")

            CType(_cmWorkLog.List, DataView).AllowNew = False
            CType(_cmWorkLog.List, DataView).Sort = "start_time, period"
            'CType(_cmWorkLog.List, DataView).Sort = "start_time DESC"
            'AddHandler _cmWorkLog.CurrentChanged, AddressOf WorkLog_CurrentChanged
            AddHandler _dsWorkLog.Tables("work_log").ColumnChanged, AddressOf Table_ColumnChanged
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Public Overridable Shadows Function Update() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            If _dsWorkLog Is Nothing Then
                Return False
            End If

            If Not _cmWorkLog Is Nothing Then
                _cmWorkLog.EndCurrentEdit()
                _cmWorkLog.Refresh()
            End If

            Dim dsTemp As DataSet = _dsWorkLog.GetChanges()
            Dim dw As DataRow

            If dsTemp Is Nothing Then
                Return True
            End If

            For Each dw In dsTemp.Tables("work_log").Rows
                'MessageBox.Show(dw("start_time").ToString(), dsTemp.Tables("work_log").Rows.Count.ToString())
                Dim sysTime As DateTime = gWs.GetSysTime()

                If dw.RowState <> DataRowState.Deleted AndAlso dw("start_time") < sysTime.AddDays(-5) Then
                    MessageBox.Show("您修改了五天以前的工作日志[" + dw("start_time").ToString() + "]。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return False
                End If
            Next

            Dim result As String = gWs.UpdateWorkLog(_dsWorkLog.GetChanges())

            If result = "1" Then
                '接受所有更改
                _dsWorkLog.AcceptChanges()

                '重新刷新当前数据集
                Me.Refresh(_serialID)

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

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnAddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddNew.Click
        If Not _cmWorkLog Is Nothing Then
            Dim systemTime As DateTime = gWs.GetSysTime()
            Dim rw As DataRow = CType(_cmWorkLog.List, DataView).Table.NewRow()

            rw("auto") = False
            rw("start_time") = systemTime
            rw("day_name") = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetDayName(systemTime.DayOfWeek)
            rw("period") = ""
            rw("description") = ""
            rw("task_name") = ""
            rw("attend_person") = UserName
            rw("create_date") = systemTime
            CType(_cmWorkLog.List, DataView).Table.Rows.Add(rw)

            Me.ReBinding()

            _cmWorkLog.Position = _cmWorkLog.Count - 1
            grdTable.CurrentRowIndex = _cmWorkLog.Count - 1
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If Not _dsWorkLog Is Nothing Then
                If Me.BindingContext(_dsWorkLog, "work_log").Position >= 0 Then
                    Dim rv As DataRowView = CType(Me.BindingContext(_dsWorkLog, "work_log").Current, DataRowView)

                    _dsWorkLog.Tables("work_log").DefaultView.RowStateFilter = DataViewRowState.Unchanged Or DataViewRowState.Added

                    If _dsWorkLog.Tables("work_log").DefaultView.Count = 1 Then
                        dtpStartTime.DataBindings.Clear()
                        rv.Delete()
                        Me.Update()
                    Else
                        rv.Delete()
                    End If
                    'rv.Delete()

                End If
            End If

        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Me.Update()
    End Sub

    Private Sub Query_Confirm(ByVal sender As Object, ByVal e As DataRowView)
        Try
            Me.Cursor = Cursors.WaitCursor

            Me.Activate()
            Me.Refresh(e("serial_num"))
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub FWorkLog_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Refresh(_serialID)
        End If

        If e.KeyCode = Keys.F3 Then
            If QueryWorkLog Is Nothing OrElse QueryWorkLog.IsDisposed Then
                QueryWorkLog = New FQueryWorkLog()
            End If

            AddHandler QueryWorkLog.Confirm, AddressOf Query_Confirm

            QueryWorkLog.MdiParent = Me.MdiParent
            QueryWorkLog.Show()
            QueryWorkLog.Activate()
        End If
    End Sub

    Private Sub FWorkLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dtpStartTime.Value = gWs.GetSysTime()

        Dim i As Integer
        Dim dsWorkType As DataSet = gWs.GetWorkType("%")

        cboTaskName.DataSource = dsWorkType.Tables("TWorkType").DefaultView
        cboTaskName.ValueMember = "work_type"
        cboTaskName.DisplayMember = "name"

        'For i = 0 To dsWorkType.Tables("TWorkType").Rows.Count - 1
        '    cboTaskName.Items.Add(dsWorkType.Tables("TWorkType").Rows(i)("name").ToString())
        'Next

        Me.Refresh(0)

        If Not (QueryWorkLog Is Nothing OrElse QueryWorkLog.IsDisposed) Then
            AddHandler QueryWorkLog.Confirm, AddressOf Query_Confirm
        End If
    End Sub

    Private Sub FWorkLog_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Not _cmWorkLog Is Nothing Then
            _cmWorkLog.EndCurrentEdit()
        End If

        If _dsWorkLog Is Nothing Then
            Return
        Else
            If Not _dsWorkLog.HasChanges() Then
                Return
            End If
        End If

        '资料已经被改动过，您要保存吗？
        Dim result As DialogResult = SWDialogBox.MessageBox.Show("?1003")

        If result = DialogResult.Yes Then
            If Not Me.Update() Then
                e.Cancel = True
            End If
        Else
            If result = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    'Private Sub dtpStartTime_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpStartTime.ValueChanged
    '    If _cmWorkLog Is Nothing Then
    '        Return
    '    End If

    '    Dim rv As DataRowView = CType(_cmWorkLog.Current, DataRowView)

    '    rv("day_name") = System.Globalization.DateTimeFormatInfo.CurrentInfo.GetDayName(dtpStartTime.Value.DayOfWeek)
    '    txtDayName.Text = rv("day_name")

    '    If dtpStartTime.Value < gWs.GetSysTime().AddDays(-5) Then
    '        MessageBox.Show("您设置的日期是五天以前的。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '    End If
    'End Sub

    'Private Sub SetFields(Optional ByVal fieldName As String = "", Optional ByVal fieldValue As Object = Nothing)
    '	If _cmWorkLog Is Nothing OrElse Not (_cmWorkLog.Current.GetType() Is GetType(DataRowView)) Then
    '		Return
    '	End If

    '	Dim rv As DataRowView = CType(_cmWorkLog.Current, DataRowView)
    '	Dim createDate As Object

    '	Try
    '		createDate = DateTime.Parse(txtCreateDate.Text)
    '	Catch
    '		createDate = DBNull.Value
    '	End Try

    '	If fieldName.Trim() = String.Empty Then
    '		rv("start_time") = dtpStartTime.Value
    '		rv("day_name") = txtDayName.Text
    '		rv("period") = cboPeriod.Text
    '		rv("attend_person") = txtAttendName.Text
    '		rv("description") = txtDescription.Text
    '		rv("task_name") = cboTaskName.Text
    '       rv("subtask_name") = cboSubTaskName.Text
    '		rv("create_date") = createDate
    '	Else
    '		rv(fieldName) = fieldValue
    '	End If
    'End Sub

    'Private Sub txtDescription_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDescription.TextChanged
    '	SetFields("description", txtDescription.Text)
    'End Sub

    'Private Sub txtAttendName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAttendName.TextChanged
    '	SetFields("attend_person", txtAttendName.Text)
    'End Sub

    'Private Sub txtCreateDate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCreateDate.TextChanged
    '	Dim createDate As Object

    '	Try
    '		createDate = DateTime.Parse(txtCreateDate.Text)
    '	Catch
    '		createDate = DBNull.Value
    '	End Try

    '	SetFields("create_date", createDate)
    'End Sub

    Private Sub cboTaskName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTaskName.SelectedIndexChanged
        Dim text As String = cboTaskName.Text
        cboTaskName.ResetText()
        cboTaskName.Text = text

        Dim i As Integer
        Dim dsWorkSubType As DataSet = gWs.GetWorkSubType(cboTaskName.SelectedValue.ToString())

        cboSubTaskName.Items.Clear()
        For i = 0 To dsWorkSubType.Tables("TWorkSubType").Rows.Count - 1
            cboSubTaskName.Items.Add(dsWorkSubType.Tables("TWorkSubType").Rows(i)("name").ToString())
        Next
    End Sub
End Class
