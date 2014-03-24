
Public Class FQueryStatisticsWorkLog
	Inherits FQueryBase

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
    Friend WithEvents cboAttendPerson As System.Windows.Forms.ComboBox
    Friend WithEvents lblAttendPerson As System.Windows.Forms.Label
    Friend WithEvents lblWorkType As System.Windows.Forms.Label
    Friend WithEvents cboStatisticsType As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboPost As System.Windows.Forms.ComboBox
    Friend WithEvents cboJob As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboTask As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents cboPeriod As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryStatisticsWorkLog))
        Me.cboAttendPerson = New System.Windows.Forms.ComboBox()
        Me.lblAttendPerson = New System.Windows.Forms.Label()
        Me.cboPost = New System.Windows.Forms.ComboBox()
        Me.lblWorkType = New System.Windows.Forms.Label()
        Me.cboStatisticsType = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboJob = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboTask = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.cboPeriod = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.BackgroundImage = CType(resources.GetObject("grpCondition.BackgroundImage"), System.Drawing.Bitmap)
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboPeriod, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.lblWorkType, Me.lblAttendPerson, Me.dtpEnd, Me.dtpStart, Me.cboTask, Me.cboJob, Me.cboStatisticsType, Me.cboPost, Me.cboAttendPerson})
        Me.grpCondition.Size = New System.Drawing.Size(696, 112)
        Me.grpCondition.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Bitmap)
        Me.btnClear.ImageIndex = -1
        Me.btnClear.ImageList = Nothing
        Me.btnClear.Location = New System.Drawing.Point(208, 128)
        Me.btnClear.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Bitmap)
        Me.btnExport.ImageIndex = -1
        Me.btnExport.ImageList = Nothing
        Me.btnExport.Location = New System.Drawing.Point(520, 128)
        Me.btnExport.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(616, 128)
        Me.btnExit.Visible = True
        '
        'ImageListQuery
        '
        Me.ImageListQuery.ImageStream = CType(resources.GetObject("ImageListQuery.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageIndex = -1
        Me.btnRefresh.ImageList = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(424, 128)
        Me.btnRefresh.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(512, 128)
        Me.btnPrint.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 160)
        Me.grdTable.Size = New System.Drawing.Size(696, 328)
        Me.grdTable.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.BackgroundImage = CType(resources.GetObject("chkVisible.BackgroundImage"), System.Drawing.Bitmap)
        Me.chkVisible.Location = New System.Drawing.Point(8, 128)
        Me.chkVisible.Size = New System.Drawing.Size(176, 24)
        Me.chkVisible.Visible = True
        '
        'cboAttendPerson
        '
        Me.cboAttendPerson.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAttendPerson.Location = New System.Drawing.Point(64, 16)
        Me.cboAttendPerson.MaxLength = 4
        Me.cboAttendPerson.Name = "cboAttendPerson"
        Me.cboAttendPerson.Size = New System.Drawing.Size(152, 22)
        Me.cboAttendPerson.Sorted = True
        Me.cboAttendPerson.TabIndex = 7
        '
        'lblAttendPerson
        '
        Me.lblAttendPerson.AutoSize = True
        Me.lblAttendPerson.Image = CType(resources.GetObject("lblAttendPerson.Image"), System.Drawing.Bitmap)
        Me.lblAttendPerson.Location = New System.Drawing.Point(8, 24)
        Me.lblAttendPerson.Name = "lblAttendPerson"
        Me.lblAttendPerson.Size = New System.Drawing.Size(54, 14)
        Me.lblAttendPerson.TabIndex = 6
        Me.lblAttendPerson.Text = "姓名"
        '
        'cboPost
        '
        Me.cboPost.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPost.Location = New System.Drawing.Point(64, 48)
        Me.cboPost.MaxLength = 4
        Me.cboPost.Name = "cboPost"
        Me.cboPost.Size = New System.Drawing.Size(152, 22)
        Me.cboPost.TabIndex = 9
        '
        'lblWorkType
        '
        Me.lblWorkType.AutoSize = True
        Me.lblWorkType.Image = CType(resources.GetObject("lblWorkType.Image"), System.Drawing.Bitmap)
        Me.lblWorkType.Location = New System.Drawing.Point(8, 56)
        Me.lblWorkType.Name = "lblWorkType"
        Me.lblWorkType.Size = New System.Drawing.Size(54, 14)
        Me.lblWorkType.TabIndex = 8
        Me.lblWorkType.Text = "岗位类别"
        '
        'cboStatisticsType
        '
        Me.cboStatisticsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatisticsType.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboStatisticsType.Items.AddRange(New Object() {"岗位工作统计表", "职责工作统计表", "工作类别统计表"})
        Me.cboStatisticsType.Location = New System.Drawing.Point(288, 80)
        Me.cboStatisticsType.MaxLength = 4
        Me.cboStatisticsType.Name = "cboStatisticsType"
        Me.cboStatisticsType.Size = New System.Drawing.Size(160, 22)
        Me.cboStatisticsType.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Bitmap)
        Me.Label1.Location = New System.Drawing.Point(224, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "统计类型"
        '
        'cboJob
        '
        Me.cboJob.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboJob.Location = New System.Drawing.Point(288, 48)
        Me.cboJob.MaxLength = 4
        Me.cboJob.Name = "cboJob"
        Me.cboJob.Size = New System.Drawing.Size(160, 22)
        Me.cboJob.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Bitmap)
        Me.Label2.Location = New System.Drawing.Point(224, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "职责类别"
        '
        'cboTask
        '
        Me.cboTask.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.cboTask.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTask.Location = New System.Drawing.Point(520, 48)
        Me.cboTask.MaxLength = 4
        Me.cboTask.Name = "cboTask"
        Me.cboTask.Size = New System.Drawing.Size(168, 22)
        Me.cboTask.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Bitmap)
        Me.Label3.Location = New System.Drawing.Point(456, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "工作任务"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Bitmap)
        Me.Label4.Location = New System.Drawing.Point(224, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "起始日期"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Image = CType(resources.GetObject("Label5.Image"), System.Drawing.Bitmap)
        Me.Label5.Location = New System.Drawing.Point(456, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "截至日期"
        '
        'dtpStart
        '
        Me.dtpStart.Location = New System.Drawing.Point(288, 17)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(160, 21)
        Me.dtpStart.TabIndex = 18
        '
        'dtpEnd
        '
        Me.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.dtpEnd.Location = New System.Drawing.Point(520, 17)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(168, 21)
        Me.dtpEnd.TabIndex = 19
        '
        'cboPeriod
        '
        Me.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriod.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPeriod.Location = New System.Drawing.Point(64, 80)
        Me.cboPeriod.MaxLength = 4
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(152, 22)
        Me.cboPeriod.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Bitmap)
        Me.Label6.Location = New System.Drawing.Point(8, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "工作时段"
        '
        'FQueryStatisticsWorkLog
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Bitmap)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryStatisticsWorkLog"
        Me.Text = "工作日志统计"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsPostAndJob As DataSet

    '岗位改变后
    Private Sub PostChanged(ByVal sender As Object, ByVal e As EventArgs)
        '先清空工作职责的选项内容
        cboJob.Items.Clear()
        If Not cboPost.SelectedItem Is Nothing Then
            Dim drs() As DataRow = dsPostAndJob.Tables("TPost").Select("post_name='" & cboPost.SelectedItem.ToString & "'")
            Dim row As DataRow
            For Each row In drs
                If cboJob.Items.IndexOf(row("post_responsibility")) < 0 Then
                    cboJob.Items.Add(row("post_responsibility"))
                End If
            Next
        End If
        cboJob.Text = String.Empty
        cboTask.Text = String.Empty
    End Sub

    '工作职责改变后
    Private Sub JobChanged(ByVal sender As Object, ByVal e As EventArgs)
        cboTask.Items.Clear()
        If Not cboJob.SelectedItem Is Nothing Then
            Dim drs() As DataRow = dsPostAndJob.Tables("TJobResponsibility").Select("post_responsibility='" & cboJob.SelectedItem.ToString & "'")
            Dim row As DataRow
            For Each row In drs
                cboTask.Items.Add(row("post_task"))
            Next
        End If
        cboTask.Text = String.Empty
    End Sub


    Protected Overrides Sub Clear()
        If Not Me.IsHandleCreated Then
            Return
        End If

        'cboAttendPerson.Text = ""
        'cboAttendPerson.SelectedIndex = -1
        'cboAttendPerson.SelectedItem = Nothing
        cboPost.Text = ""
        cboPost.SelectedIndex = -1
        cboPost.SelectedItem = Nothing

        cboPeriod.Text = ""
        cboPeriod.SelectedIndex = -1
        cboPeriod.SelectedItem = Nothing

        cboJob.Text = ""
        cboJob.SelectedIndex = -1
        cboJob.SelectedItem = Nothing

        cboTask.Text = ""
        cboTask.SelectedIndex = -1
        cboTask.SelectedItem = Nothing

        cboStatisticsType.SelectedIndex = 0
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


        cboAttendPerson.Items.Clear()

        Select Case permission
            Case "0"
                cboAttendPerson.Enabled = True
                cboAttendPerson.DropDownStyle = ComboBoxStyle.DropDown

                For i = 0 To dtStaff.Rows.Count - 1
                    cboAttendPerson.Items.Add(dtStaff.Rows(i)("staff_name"))
                Next
            Case "2"
                cboAttendPerson.Enabled = True
                cboAttendPerson.DropDownStyle = ComboBoxStyle.DropDownList

                Dim rows() As DataRow = dtStaff.Select("dept_name = '" + department + "'")
                For i = 0 To rows.Length - 1
                    cboAttendPerson.Items.Add(rows(i)("staff_name"))
                Next
            Case "3"
                cboAttendPerson.Enabled = True
                cboAttendPerson.DropDownStyle = ComboBoxStyle.DropDownList

                cboAttendPerson.Items.Add(userID)

                Dim rows() As DataRow = dtStaff.Select("read_logs_right = '1'")
                For i = 0 To rows.Length - 1
                    cboAttendPerson.Items.Add(rows(i)("staff_name"))
                Next
            Case "4"
                cboAttendPerson.Enabled = True
                cboAttendPerson.DropDownStyle = ComboBoxStyle.DropDownList


                Dim rows() As DataRow = dtStaff.Select("dept_name in (" + departmentList + ")")
                For i = 0 To rows.Length - 1
                    cboAttendPerson.Items.Add(rows(i)("staff_name"))
                Next
            Case Else
                cboAttendPerson.Enabled = False
                cboAttendPerson.DropDownStyle = ComboBoxStyle.Simple
        End Select

        cboAttendPerson.Text = userID

        Return True
    End Function

    Private Function JudgeCombox(ByVal cbo As ComboBox, ByVal desc As String) As Boolean
        If cbo.Text.Trim = String.Empty Then
            SWDialogBox.MessageBox.Show("$1001", desc)
            cbo.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function ConditionIsEffective() As Boolean
        Select Case cboStatisticsType.SelectedIndex
            Case 0
                If Not JudgeCombox(cboPost, "岗位类别") Then
                    Return False
                End If
            Case 1
                If Not JudgeCombox(cboPost, "岗位类别") Then
                    Return False
                End If
                If Not JudgeCombox(cboJob, "职责类别") Then
                    Return False
                End If
            Case 2
                If Not JudgeCombox(cboPost, "岗位类别") Then
                    Return False
                End If
                If Not JudgeCombox(cboJob, "职责类别") Then
                    Return False
                End If
                If Not JudgeCombox(cboTask, "工作任务") Then
                    Return False
                End If
        End Select
        Return True
    End Function

    Protected Overloads Sub GetCondition(ByRef queryType As String, ByRef dateStart As DateTime, ByRef dateEnd As DateTime, ByRef attendPerson As String, ByRef post_name As String, ByRef job_name As String, ByRef task_name As String, ByRef period As String)
        queryType = cboStatisticsType.SelectedIndex.ToString
        dateStart = dtpStart.Value.Date
        dateEnd = dtpEnd.Value.AddDays(1).Date
        attendPerson = IIf(cboAttendPerson.Text.Trim() = "", "%", cboAttendPerson.Text)
        post_name = IIf(cboPost.Text.Trim() = "", "%", cboPost.Text)
        job_name = IIf(cboJob.Text.Trim() = "", "%", cboJob.Text)
        task_name = IIf(cboTask.Text.Trim() = "", "%", cboTask.Text)
        period = IIf(cboPeriod.Text.Trim() = "", "%", "%" & cboPeriod.Text & "%")
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        'If Not ConditionIsEffective() Then
        '    Return
        'End If

        Dim dateStart, dateEnd As System.DateTime
        Dim attendPerson, queryType, post_name, job_name, task_name, period As String

        GetCondition(queryType, dateStart, dateEnd, attendPerson, post_name, job_name, task_name, period)

        Dim dsResult As DataSet = gWs.PQueryWorkLog(queryType, dateStart, dateEnd, attendPerson, post_name, job_name, task_name, period)

        dsResult.Tables("Table").TableName = "TQueryStatisticsWorkLog"
        grdTable.SetDataBinding(dsResult, "TQueryStatisticsWorkLog")
        AddTableStyle(queryType)
        'CType(CType(Me.BindingContext(dsResult, "TQueryStatisticsWorkLog"), CurrencyManager).List, DataView).Sort = "task_name DESC,man_hour,subtask_name"

        Me.Text = "工作日志统计(" + dsResult.Tables("TQueryStatisticsWorkLog").Rows.Count.ToString + ")"
    End Sub

    Private Sub AddTableStyle(ByVal QueryType As Int16)
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "TQueryStatisticsWorkLog"
        Dim colName As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        colName.MappingName = "attend_person"
        colName.HeaderText = "姓 名"
        colName.Width = 90
        colName.NullText = String.Empty
        Dim colPost As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        colPost.MappingName = "post_name"
        colPost.HeaderText = "岗位类别"
        colPost.Width = 100
        colPost.NullText = String.Empty
        Dim colJob As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        colJob.MappingName = "task_name"
        colJob.HeaderText = "职责类别"
        colJob.Width = 130
        colJob.NullText = String.Empty
        Dim colTask As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        colTask.MappingName = "subtask_name"
        colTask.HeaderText = "工作类别"
        colTask.Width = 200
        colTask.NullText = String.Empty
        Dim colPeriod As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        colPeriod.MappingName = "period"
        colPeriod.HeaderText = "时段"
        colPeriod.Width = 85
        colPeriod.NullText = String.Empty
        Dim colFrequency As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        colFrequency.MappingName = "frequency"
        colFrequency.HeaderText = "频次"
        colFrequency.Width = 60
        colFrequency.NullText = String.Empty
        Dim colManHour As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        colManHour.MappingName = "man_hour"
        colManHour.HeaderText = "用时"
        colManHour.Width = 65
        colManHour.NullText = String.Empty
        If QueryType = 0 Then
            dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {colName, colPost, colPeriod, colFrequency, colManHour})
        ElseIf QueryType = 1 Then
            dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {colName, colPost, colJob, colPeriod, colFrequency, colManHour})
        Else
            dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {colName, colPost, colJob, colTask, colPeriod, colFrequency, colManHour})
        End If
        Me.grdTable.TableStyles.Clear()
        Me.grdTable.TableStyles.Add(dgts)
    End Sub

    Private Sub FQueryStatisticsWorkLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim SysDate As DateTime = gWs.GetSysTime
        dtpEnd.Value = SysDate.Date
        dtpStart.Value = SysDate.Date

        dsPostAndJob = gWs.GetPostAndJobResponsibilityInfo("%", "%")

        If Not SetPermission() Then
            Me.btnPrint.Enabled = False
            Me.btnRefresh.Enabled = False
        End If

        Dim row As DataRow

        '工作岗位
        For Each row In dsPostAndJob.Tables("TPost").Rows
            If cboPost.Items.IndexOf(row("post_name")) < 0 Then
                cboPost.Items.Add(row("post_name"))
            End If
        Next

        '工作时段
        'Dim dsPeriod As DataSet = gWs.GetJobPeriodInfo("%")
        'For Each row In dsPeriod.Tables(0).Rows
        '    cboPeriod.Items.Add(row("period"))
        'Next
        'dsPeriod.Dispose()
        cboPeriod.Items.Add("正常上班")
        cboPeriod.Items.Add("平时加班")
        cboPeriod.Items.Add("假日加班")
        cboPeriod.Items.Add("出差")
        cboPeriod.Items.Add("休假")
        cboPeriod.Items.Add("请假")

        Me.Clear()
        AddHandler cboPost.SelectedIndexChanged, AddressOf PostChanged
        AddHandler cboJob.SelectedIndexChanged, AddressOf JobChanged
    End Sub

    Protected Overrides Sub Export()
        Dim arrChart1 As New ArrayList()
        Dim arrChart2 As New ArrayList()
        Dim arrChart3 As New ArrayList()
        Dim arrChartList As New ArrayList()

        arrChart1.Add("2")
        arrChart1.Add("时段")
        arrChart1.Add("用时")

        arrChart2.Add("2")
        If cboStatisticsType.SelectedIndex > 1 Then
            arrChart2.Add("工作类别")
        ElseIf cboStatisticsType.SelectedIndex > 0 Then
            arrChart2.Add("职责类别")
        Else
            arrChart2.Add("岗位类别")
        End If
        arrChart2.Add("用时")

        arrChart3.Add("2")
        If cboStatisticsType.SelectedIndex > 1 Then
            arrChart3.Add("工作类别")
        ElseIf cboStatisticsType.SelectedIndex > 0 Then
            arrChart3.Add("职责类别")
        Else
            arrChart3.Add("岗位类别")
        End If
        arrChart3.Add("频次")

        arrChartList.Add(arrChart1)
        arrChartList.Add(arrChart2)
        arrChartList.Add(arrChart3)

        ReportToExcel.ToExcel(grdTable, cboStatisticsType.SelectedItem.ToString, cboStatisticsType.SelectedItem.ToString, arrChartList)
    End Sub
End Class
