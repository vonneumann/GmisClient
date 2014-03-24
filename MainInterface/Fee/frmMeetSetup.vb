Public Class frmMeetSetup
    Inherits frmBasic

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsConference Is Nothing Then
            dsConference.Dispose()
        End If
        If Not dsPro Is Nothing Then
            dsPro.Dispose()
        End If
        If Not dsTemp Is Nothing Then
            dsTemp.Dispose()
        End If
        If Not dsDelegates Is Nothing Then
            dsDelegates.Dispose()
        End If
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents clbDelegates As System.Windows.Forms.CheckedListBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgList As System.Windows.Forms.DataGrid
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents btnSure As System.Windows.Forms.Button
    Friend WithEvents txtOther As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gpbxDelegates As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTopic As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbxStartTime As System.Windows.Forms.ComboBox
    Friend WithEvents gpbxSet As System.Windows.Forms.GroupBox
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnArrangeProject As System.Windows.Forms.Button
    Friend WithEvents mcDate As SWCalendar.MyCalendar
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgProject As System.Windows.Forms.DataGrid
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    Friend WithEvents btnCancelProject As System.Windows.Forms.Button
    Friend WithEvents cboRoom As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMeetSetup))
        Me.gpbxSet = New System.Windows.Forms.GroupBox()
        Me.cboRoom = New System.Windows.Forms.ComboBox()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.mcDate = New SWCalendar.MyCalendar()
        Me.cmbxStartTime = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTopic = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpbxDelegates = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOther = New System.Windows.Forms.TextBox()
        Me.btnSure = New System.Windows.Forms.Button()
        Me.clbDelegates = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgList = New System.Windows.Forms.DataGrid()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSet = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnArrangeProject = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgProject = New System.Windows.Forms.DataGrid()
        Me.btnCancelProject = New System.Windows.Forms.Button()
        Me.gpbxSet.SuspendLayout()
        Me.gpbxDelegates.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(592, 544)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'gpbxSet
        '
        Me.gpbxSet.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.gpbxSet.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboRoom, Me.lblMessage, Me.mcDate, Me.cmbxStartTime, Me.Label2, Me.txtTopic, Me.Label4, Me.Label1, Me.gpbxDelegates})
        Me.gpbxSet.Location = New System.Drawing.Point(8, 320)
        Me.gpbxSet.Name = "gpbxSet"
        Me.gpbxSet.Size = New System.Drawing.Size(728, 216)
        Me.gpbxSet.TabIndex = 26
        Me.gpbxSet.TabStop = False
        '
        'cboRoom
        '
        Me.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRoom.Location = New System.Drawing.Point(504, 16)
        Me.cboRoom.Name = "cboRoom"
        Me.cboRoom.Size = New System.Drawing.Size(216, 20)
        Me.cboRoom.TabIndex = 30
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Orange
        Me.lblMessage.Font = New System.Drawing.Font("宋体", 10.5!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblMessage.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblMessage.Location = New System.Drawing.Point(8, 184)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(312, 24)
        Me.lblMessage.TabIndex = 29
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'mcDate
        '
        Me.mcDate.Location = New System.Drawing.Point(8, 16)
        Me.mcDate.Name = "mcDate"
        Me.mcDate.Size = New System.Drawing.Size(317, 168)
        Me.mcDate.TabIndex = 28
        '
        'cmbxStartTime
        '
        Me.cmbxStartTime.Items.AddRange(New Object() {"0:00", "0:30", "1:00", "1:30", "2:00", "2:30", "3:00", "3:30", "4:00", "4:30", "5:00", "5:30", "6:00", "6:30", "7:00", "7:30", "8:00", "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00", "22:30", "23:00", "23:30"})
        Me.cmbxStartTime.Location = New System.Drawing.Point(392, 16)
        Me.cmbxStartTime.Name = "cmbxStartTime"
        Me.cmbxStartTime.Size = New System.Drawing.Size(64, 20)
        Me.cmbxStartTime.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(336, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "开始时间"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTopic
        '
        Me.txtTopic.Location = New System.Drawing.Point(392, 40)
        Me.txtTopic.MaxLength = 50
        Me.txtTopic.Name = "txtTopic"
        Me.txtTopic.Size = New System.Drawing.Size(328, 21)
        Me.txtTopic.TabIndex = 2
        Me.txtTopic.Text = "开评审会议"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(336, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 14)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "主   题"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(464, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "会场"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gpbxDelegates
        '
        Me.gpbxDelegates.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.gpbxDelegates.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label3, Me.txtOther, Me.btnSure, Me.clbDelegates})
        Me.gpbxDelegates.Location = New System.Drawing.Point(336, 64)
        Me.gpbxDelegates.Name = "gpbxDelegates"
        Me.gpbxDelegates.Size = New System.Drawing.Size(384, 144)
        Me.gpbxDelegates.TabIndex = 20
        Me.gpbxDelegates.TabStop = False
        Me.gpbxDelegates.Text = "评委"
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.Location = New System.Drawing.Point(40, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "其他评委"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOther
        '
        Me.txtOther.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.txtOther.Location = New System.Drawing.Point(128, 116)
        Me.txtOther.MaxLength = 5
        Me.txtOther.Name = "txtOther"
        Me.txtOther.Size = New System.Drawing.Size(104, 21)
        Me.txtOther.TabIndex = 5
        Me.txtOther.Text = ""
        '
        'btnSure
        '
        Me.btnSure.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSure.Enabled = False
        Me.btnSure.Location = New System.Drawing.Point(240, 115)
        Me.btnSure.Name = "btnSure"
        Me.btnSure.Size = New System.Drawing.Size(64, 23)
        Me.btnSure.TabIndex = 6
        Me.btnSure.Text = "新增"
        '
        'clbDelegates
        '
        Me.clbDelegates.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.clbDelegates.CheckOnClick = True
        Me.clbDelegates.ColumnWidth = 75
        Me.clbDelegates.HorizontalScrollbar = True
        Me.clbDelegates.Location = New System.Drawing.Point(8, 16)
        Me.clbDelegates.MultiColumn = True
        Me.clbDelegates.Name = "clbDelegates"
        Me.clbDelegates.Size = New System.Drawing.Size(368, 84)
        Me.clbDelegates.TabIndex = 4
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgList})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(728, 120)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "会议列表"
        '
        'dgList
        '
        Me.dgList.CaptionVisible = False
        Me.dgList.DataMember = ""
        Me.dgList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgList.Location = New System.Drawing.Point(3, 17)
        Me.dgList.Name = "dgList"
        Me.dgList.ReadOnly = True
        Me.dgList.Size = New System.Drawing.Size(722, 100)
        Me.dgList.TabIndex = 0
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Enabled = False
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(504, 544)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSet
        '
        Me.btnSet.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSet.Image = CType(resources.GetObject("btnSet.Image"), System.Drawing.Bitmap)
        Me.btnSet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSet.ImageIndex = 13
        Me.btnSet.ImageList = Me.ImageListBasic
        Me.btnSet.Location = New System.Drawing.Point(192, 544)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(93, 23)
        Me.btnSet.TabIndex = 9
        Me.btnSet.Text = "新增会议(&N)"
        Me.btnSet.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Enabled = False
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(296, 544)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(93, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "撤销会议(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnArrangeProject
        '
        Me.btnArrangeProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnArrangeProject.Enabled = False
        Me.btnArrangeProject.Image = CType(resources.GetObject("btnArrangeProject.Image"), System.Drawing.Bitmap)
        Me.btnArrangeProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArrangeProject.ImageIndex = 1
        Me.btnArrangeProject.ImageList = Me.ImageListBasic
        Me.btnArrangeProject.Location = New System.Drawing.Point(88, 544)
        Me.btnArrangeProject.Name = "btnArrangeProject"
        Me.btnArrangeProject.Size = New System.Drawing.Size(93, 23)
        Me.btnArrangeProject.TabIndex = 8
        Me.btnArrangeProject.Text = "项目安排(&A)"
        Me.btnArrangeProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgProject})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(728, 192)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "项目安排情况"
        '
        'dgProject
        '
        Me.dgProject.AllowSorting = False
        Me.dgProject.CaptionVisible = False
        Me.dgProject.DataMember = ""
        Me.dgProject.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProject.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgProject.Location = New System.Drawing.Point(3, 17)
        Me.dgProject.Name = "dgProject"
        Me.dgProject.ReadOnly = True
        Me.dgProject.Size = New System.Drawing.Size(722, 172)
        Me.dgProject.TabIndex = 0
        '
        'btnCancelProject
        '
        Me.btnCancelProject.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCancelProject.Enabled = False
        Me.btnCancelProject.Image = CType(resources.GetObject("btnCancelProject.Image"), System.Drawing.Bitmap)
        Me.btnCancelProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelProject.ImageIndex = 25
        Me.btnCancelProject.ImageList = Me.ImageListBasic
        Me.btnCancelProject.Location = New System.Drawing.Point(400, 544)
        Me.btnCancelProject.Name = "btnCancelProject"
        Me.btnCancelProject.Size = New System.Drawing.Size(93, 23)
        Me.btnCancelProject.TabIndex = 28
        Me.btnCancelProject.Text = "撤销项目(&R)"
        Me.btnCancelProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmMeetSetup
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(746, 575)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnCancelProject, Me.GroupBox1, Me.btnArrangeProject, Me.btnDelete, Me.gpbxSet, Me.GroupBox2, Me.btnSave, Me.btnSet})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMeetSetup"
        Me.Text = "会议管理"
        Me.gpbxSet.ResumeLayout(False)
        Me.gpbxDelegates.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsConference As DataSet
    Private strStatus As String = String.Empty
    Private serialNum As Integer = 0
    Private SystemDate As DateTime
    Private bmMeet As CurrencyManager
    Private dsTemp As DataSet
    Private bmTemp As CurrencyManager
    '''会议项目信息''''''
    Private bmProject As CurrencyManager
    Private dsPro As DataSet
    '''会议项目信息''''''
    Public IsOwnedFormCommit As Boolean = False
    Private dsDelegates, dsRoom As DataSet

    Private Sub AddTableStyle()
        dgList.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.AllowSorting = False
        dgts.MappingName = "conference"
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn() 'index 0  会议编码
        col5.MappingName = "conference_code"
        col5.Width = 0
        dgts.GridColumnStyles.Add(col5)
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1
        col1.MappingName = "conference_date"
        col1.HeaderText = "会议日期"
        col1.Width = 70
        col1.NullText = String.Empty
        col1.Format = "yyyy-MM-dd"
        col1.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col1)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2 
        col4.MappingName = "start_time"
        col4.HeaderText = "开始时间"
        col4.NullText = String.Empty
        col4.Format = "H:mm"
        col4.Alignment = HorizontalAlignment.Left
        col4.Width = 70
        dgts.GridColumnStyles.Add(col4)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col6.MappingName = "status"
        col6.HeaderText = "会议状态"
        col6.Alignment = HorizontalAlignment.Left
        col6.Width = 70
        col6.NullText = String.Empty
        dgts.GridColumnStyles.Add(col6)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 3
        col3.MappingName = "place"
        col3.HeaderText = "地点"
        col3.Width = 150
        col3.Alignment = HorizontalAlignment.Left
        col3.NullText = String.Empty
        dgts.GridColumnStyles.Add(col3)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 4 
        col2.MappingName = "remark"
        col2.HeaderText = "主题"
        col2.Alignment = HorizontalAlignment.Left
        col2.NullText = String.Empty
        col2.Width = 300
        dgts.GridColumnStyles.Add(col2)
        dgList.TableStyles.Add(dgts)
    End Sub
    '返回数据源
    Private Sub GetDataSource()
        dsConference = gWs.GetConferenceInfo("{conference_date>='" & SystemDate.Date & "'}", "null") ' AND status<>'已开' SystemDate.Date
        serialNum = gWs.GetMaxConferenceCodeNum 'dsConference.Tables("conference").Rows.Count
        If (dsConference.Tables("conference").Rows.Count > 0) Then   '设置已有会议日期为粗体
            Dim i As Integer
            Dim strDate As String
            For i = 0 To dsConference.Tables("conference").Rows.Count - 1
                mcDate.AddColorDate(DateTime.Parse(dsConference.Tables("conference").Rows(i).Item("conference_date")))
            Next
            mcDate.UpdateColorDates()
        End If
        bmMeet = BindingContext(dsConference, "conference")
    End Sub

    Private Sub ReturnConferenceEachDay(ByVal EachDate As Date)
        Dim str As String = EachDate.ToString("yyyy-MM-dd")
        If bmTemp Is Nothing Then
            dsTemp = New DataSet()
            dsTemp = dsConference.Clone
            dsTemp.Merge(dsConference.Tables(0).Select("conference_date=#" & str & "#"))
            dgList.DataMember = "conference"
            dgList.DataSource = dsTemp
            bmTemp = BindingContext(dsTemp, "conference")
            AddTableStyle()
            bmTemp_CurrentChanged(Nothing, Nothing)
            AddHandler bmTemp.PositionChanged, AddressOf bmTemp_CurrentChanged
            RefreshMessage()
            Return
        ElseIf bmTemp.Count > 0 Then
            Dim dr As DataRow
            For Each dr In dsTemp.Tables(0).Rows
                dr.Delete()
            Next
            dsTemp.Tables(0).AcceptChanges()
        End If
        dsTemp.Merge(dsConference.Tables(0).Select("conference_date=#" & str & "#"))
        
        If bmTemp.Count = 0 Then
            If Not bmProject Is Nothing Then
                CType(bmProject.List, DataView).RowFilter = "ConCode = -1"
            End If
            If strStatus = String.Empty Then
                ClearDelegates()
            End If
        End If
        If strStatus = String.Empty Then
            RefreshMessage()
        End If
    End Sub
    Private Sub ClearDelegates()
        Dim i As Int32
        For i = clbDelegates.Items.Count - 1 To 0 Step -1
            clbDelegates.Items.RemoveAt(i)
        Next
    End Sub
    '返回所有角色为“评委”的人员
    Private Sub GetAllConferenceCommitteeman(ByVal ConfereceRoom As String)
        Try
            dsDelegates = gWs.GetStaffByRoleID("{role_id='26' and ISNULL(CHARINDEX('" & Trim(cboRoom.Text) & "', conference_address),0) <> 0}")
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", "获取会议评委出错", ex.Message, ex.StackTrace)
        End Try

        Dim dv As DataView = dsDelegates.Tables(0).DefaultView
        dv.Sort = "staff_name DESC"

        ClearDelegates()
        Dim drv As DataRowView
        For Each drv In dv
            clbDelegates.Items.Add(CStr(drv("staff_name")))
            clbDelegates.SetItemChecked(clbDelegates.Items.Count - 1, True)
        Next
    End Sub
    '返回特定会议的评委
    Private Sub GetSomeConferenceCommitteeman(ByVal conferenceCode As Int32)
        Dim dv As DataView = dsConference.Tables("conference_committeeman").DefaultView
        dv.RowFilter = "conference_code=" & conferenceCode.ToString
        ClearDelegates()
        Dim drv As DataRowView
        For Each drv In dv
            clbDelegates.Items.Add(drv("committeeman").ToString)
            clbDelegates.SetItemChecked(clbDelegates.Items.Count - 1, True)
        Next
    End Sub

    Private Sub frmMeetManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim str As String = gWs.RefreshConference()
            If str <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "刷新会议列表错误", str, "")
                Dim obj As Control
                For Each obj In Me.Controls
                    obj.Enabled = Not obj.GetType Is GetType(Button)
                Next
                btnExit.Enabled = True
                Return
            End If
            SystemDate = gWs.GetSysTime
            cmbxStartTime.Text = "9:30"
            GetDataSource()
            mcDate.SetToday(SystemDate.Date)
            ReturnConferenceEachDay(mcDate.SelectedDate)

            AddHandler btnSet.Click, New EventHandler(AddressOf btnSet_Click)

            dsRoom = gWs.FetchConfernceRoom("%")
            Dim i As Integer
            For i = 0 To dsRoom.Tables(0).Rows.Count - 1
                cboRoom.Items.Add(dsRoom.Tables(0).Rows(i).Item("conference_address"))
            Next
            'cboRoom.DataSource = dsRoom.Tables("TConferenceRoom")
            'cboRoom.DisplayMember = "conference_address"
            'cboRoom.ValueMember = "conference_address"

            cboRoom.SelectedIndex = 0 : txtTopic.Text = "开评审会议"

            If dsRoom.Tables("TConferenceRoom").Rows.Count = 0 Then
                SWDialogBox.MessageBox.Show("请先进行会场设置", "系统提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Warning)
                btnSet.Enabled = False
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
        'Me.AllowTransparency = False
    End Sub

    Private strConCode As System.Text.StringBuilder = New System.Text.StringBuilder
    Public Sub bmTemp_CurrentChanged(ByVal sender As Object, ByVal e As EventArgs)

        If bmTemp.Count = 0 Then
            Return
        End If

        With CType(bmTemp.Current, DataRowView)
            cmbxStartTime.Text = .Item("start_time")
            cboRoom.Text = .Item("place")
            txtTopic.Text = .Item("remark") & ""
        End With

        Dim ConCode As Integer = CInt(CType(bmTemp.Current, DataRowView)("conference_code"))
        Dim codeHasExisted As Boolean = (strConCode.ToString.IndexOf(ConCode.ToString) >= 0)
        If Not codeHasExisted Then
            dsConference.Merge(gWs.GetConferenceInfo("null", "{conference_code=" & ConCode.ToString & "}").Tables("conference_committeeman").Select("", "", DataViewRowState.CurrentRows))
            strConCode.Append(ConCode.ToString & ",")
        End If

        If strStatus = String.Empty Then '正常状态下显示特定会议的评委
            Me.GetSomeConferenceCommitteeman(ConCode)
        End If

        If CStr(CType(bmTemp.Current, DataRowView)("status")) = "未安排" Then
            If Not bmProject Is Nothing Then
                CType(bmProject.List, DataView).RowFilter = "ConCode = -1"
            End If
            If strStatus = String.Empty Then
                RefreshMessage()
            End If
            Return
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not codeHasExisted Then
                Dim dsT As DataSet
                Dim eachDr As DataRow
                If bmProject Is Nothing Then
                    dsT = gWs.GetNeedMeetProjectInfo("", ConCode, "0") '("{b.conference_code=" & ConCode & "}")
                    dsPro = New DataSet
                    dsPro = dsT.Copy
                    bmProject = BindingContext(dsPro, "Table")
                    dgProject.DataMember = "Table"
                    dgProject.DataSource = dsPro
                    AddTableStyleForProject()
                    dsT.Dispose()
                    Return
                End If
                dsT = gWs.GetNeedMeetProjectInfo("", ConCode, "0") '("{b.conference_code=" & ConCode & "}")
                For Each eachDr In dsT.Tables(0).Rows
                    dsPro.Tables(0).ImportRow(eachDr)
                Next
                dsT.Dispose()
            End If

            CType(bmProject.List, DataView).RowFilter = "ConCode = " & ConCode.ToString
            If CType(bmProject.List, DataView).Sort = String.Empty Then
                CType(bmProject.List, DataView).Sort = "SerialNum"
            End If

            If strStatus = String.Empty Then
                RefreshMessage()
            End If
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub AddTableStyleForProject()
        dgProject.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle
        dgts.MappingName = "Table"
        dgts.AllowSorting = False
        'dgts.RowHeadersVisible = False
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col5.MappingName = "SerialNum"                                      'index 0
        col5.HeaderText = "上会次序"
        col5.Alignment = HorizontalAlignment.Center
        col5.Width = 55
        col5.NullText = String.Empty
        dgts.GridColumnStyles.Add(col5)
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn        'index 1
        col1.MappingName = "project_code"
        col1.HeaderText = "项目编码"
        col1.Width = 65
        col1.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col1)
        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index 2
        col11.MappingName = "Area"
        col11.HeaderText = "区域"
        col11.Width = 85
        col11.NullText = String.Empty
        col11.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col11)
        Dim col12 As DataGridTextBoxColumn = New DataGridTextBoxColumn
        col12.MappingName = "PrevDateTime"
        col12.HeaderText = "上次开会时间"
        col12.NullText = String.Empty
        col12.Width = 105
        dgts.GridColumnStyles.Add(col12)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index 3 
        col2.MappingName = "CorName"
        col2.HeaderText = "企业名称"
        col2.Alignment = HorizontalAlignment.Left
        col2.NullText = String.Empty
        col2.Width = 170
        dgts.GridColumnStyles.Add(col2)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index 5
        col3.MappingName = "PMA"
        col3.HeaderText = "项目经理A"
        col3.Width = 70
        col3.NullText = String.Empty
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index 6
        col7.MappingName = "PMB"
        col7.HeaderText = "项目经理B"
        col7.Width = 70
        col7.NullText = String.Empty
        col7.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col7)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index 4  为删除dsConferenceTrial而设计
        col6.MappingName = "times"
        col6.HeaderText = "上会次数"
        col6.Width = 55
        col6.NullText = String.Empty
        col6.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col6)
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index 7
        col8.MappingName = "prime_committee"
        col8.HeaderText = "主评"
        col8.Alignment = HorizontalAlignment.Left
        col8.Width = 55
        col8.NullText = String.Empty
        dgts.GridColumnStyles.Add(col8)
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index 7
        col10.MappingName = "ApplySum"
        col10.HeaderText = "申请金额(万元)"
        col10.Alignment = HorizontalAlignment.Left
        col10.Width = 95
        col10.Format = "c"
        col10.FormatInfo = CGFormatInfo
        col10.NullText = String.Empty
        dgts.GridColumnStyles.Add(col10)
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index 7
        col9.MappingName = "ServiceType"
        col9.HeaderText = "业务品种"
        col9.Alignment = HorizontalAlignment.Left
        col9.Width = 120
        col9.NullText = String.Empty
        dgts.GridColumnStyles.Add(col9)
        dgProject.TableStyles.Add(dgts)
    End Sub
    Private Sub Cancel(ByVal sender As Object, ByVal e As EventArgs)
        If Not sender.GetType Is GetType(Button) Then Return

        If (dsConference.HasChanges) Then
            dsConference.RejectChanges()
        End If
        btnSet.Text = "新增会议(&N)"
        strStatus = String.Empty : btnSave.Enabled = False
        dgList.Enabled = True
        If dgList.VisibleRowCount < bmMeet.Count Then
            AddTableStyle()
        End If
        ReturnConferenceEachDay(mcDate.SelectedDate)
        If CType(sender, Button) Is btnSave Then
            bmTemp.Position = bmTemp.Count - 1
            dgList.Select(bmTemp.Position)
        End If
        RemoveHandler btnSet.Click, AddressOf Cancel
        AddHandler btnSet.Click, AddressOf btnSet_Click
    End Sub

    '新增一个会议
    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dr As DataRow = dsConference.Tables("conference").NewRow
        With dr
            .Item("remark") = txtTopic.Text
            .Item("place") = cboRoom.Text
        End With
        dsConference.Tables("conference").Rows.Add(dr)
        bmMeet.Position = bmMeet.Count - 1
        strStatus = "new" : btnSave.Enabled = True
        btnSet.Text = "取 消(&N)" : btnDelete.Enabled = False : btnArrangeProject.Enabled = False
        RemoveHandler btnSet.Click, AddressOf btnSet_Click
        AddHandler btnSet.Click, AddressOf Cancel
        If mcDate.SelectedDate.Date = SystemDate.Date Then
            cmbxStartTime.Text = SystemDate.AddHours(4).Hour & ":30"
        End If
        'cboRoom.SelectedIndex = 0 : txtTopic.Text = "开评审会议"
        dgList.Enabled = False
        cboRoom.Focus()
        Me.GetAllConferenceCommitteeman(Me.cboRoom.Text) '获取所有的会议评委人员
    End Sub
    Private IsWrong As Boolean = False
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        IsWrong = True
        If (mcDate.SelectedDate.Date < SystemDate.Date) Then
            SWDialogBox.MessageBox.Show("$1008", "会议日期", SystemDate.Date)
            'MessageBox.Show("您选择的会议日期小于""今天""，不能设置会议", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        'If (mcDate.SelectedDate.Date = SystemDate.Date) Then
        '    SystemDate = gWs.GetSysTime
        '    Dim strTime As String = cmbxStartTime.Text
        '    Dim kHour As Integer = CInt(strTime.Substring(0, strTime.IndexOf(":")))
        '    If kHour < SystemDate.Hour Then
        '        SWDialogBox.MessageBox.Show("$1008", "会议开始时间", SystemDate.TimeOfDay)
        '        'MessageBox.Show("您选择的开始时间小于当前时间，不能设置会议", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Return
        '    ElseIf kHour = SystemDate.Hour Then
        '        If CInt(strTime.Substring(strTime.IndexOf(":") + 1, strTime.Length - strTime.IndexOf(":") - 1)) < SystemDate.Minute Then
        '            SWDialogBox.MessageBox.Show("$1008", "会议开始时间", SystemDate.TimeOfDay)
        '            'MessageBox.Show("您选择的开始时间小于当前时间，不能设置会议", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '            Return
        '        End If
        '    End If
        'End If

        'If dsConference.Tables("conference").Select("conference_date='" & mcDate.SelectedDate.Date & "' AND start_time='" & cmbxStartTime.Text.Trim & "'").Length > 0 Then
        '    SWDialogBox.MessageBox.Show("$X029")
        '    'MessageBox.Show("您设置的会议(开始时间)已存在于会议日期列表，不能设置会议", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return
        'End If
        If clbDelegates.CheckedItems.Count = 0 Then
            SWDialogBox.MessageBox.Show("$1001", "会议评委")
            'MessageBox.Show("请选择会议评委", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        '插入基本信息
        bmMeet.Position = bmMeet.Count - 1
        With CType(bmMeet.Current, DataRowView)
            .Item("conference_code") = serialNum
            .Item("conference_date") = mcDate.SelectedDate.ToString("yyyy-MM-dd")
            .Item("remark") = txtTopic.Text
            .Item("place") = cboRoom.Text
            .Item("start_time") = cmbxStartTime.Text
            .Item("status") = "未安排"
            .Item("create_person") = UserName
            .Item("create_date") = SystemDate.Date
        End With
        'dsConference.Tables("conference").Rows.Add(realDr)
        '插入评委信息
        Dim i As Integer
        For i = 0 To clbDelegates.CheckedItems.Count - 1
            Dim dr As DataRow = dsConference.Tables("conference_committeeman").NewRow
            With dr
                .Item("conference_code") = serialNum
                .Item("committeeman") = CStr(clbDelegates.Items(clbDelegates.CheckedIndices.Item(i)))
                .Item("create_person") = UserName
                .Item("create_date") = SystemDate.Date
            End With
            dsConference.Tables("conference_committeeman").Rows.Add(dr)
        Next
        strConCode.Append(serialNum.ToString & ",") '增加到已包括评委的会议编码的列表
        serialNum += 1

        Dim strResult As String = gWs.UpdateConferenceCommitteeman(dsConference.GetChanges)
        If strResult = "1" Then
            IsWrong = False
            If sender Is Nothing Then Return

            SWDialogBox.MessageBox.Show("$SaveSucceed")
            'MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dsConference.AcceptChanges()
            mcDate.AddColorDate(mcDate.SelectedDate)
            mcDate.UpdateColorDates()
        Else
            SWDialogBox.MessageBox.Show("*999", "保存失败", strResult, "")
            'MessageBox.Show("保存失败" & vbCr & strResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            IsWrong = True
            Return
        End If

        Cancel(sender, e)
    End Sub


    Private Sub RefreshMessage()
        btnDelete.Enabled = bmTemp.Count > 0
        btnArrangeProject.Enabled = btnDelete.Enabled
        lblMessage.Text = "选择日期：" & mcDate.SelectedDate.ToString("yyyy-MM-dd") & IIf(btnDelete.Enabled, "，有会议", "，没会议")
        If Not bmProject Is Nothing Then
            btnCancelProject.Enabled = bmProject.Count > 0
        End If
        If btnDelete.Enabled Then '如果会议已开过，则屏蔽某些操作
            If CStr(CType(bmTemp.Current, DataRowView)("status")) = "已开" Then
                btnDelete.Enabled = False
                btnArrangeProject.Enabled = False
                btnCancelProject.Enabled = False
            End If
        End If
    End Sub

    Private Sub mcDate_DateChanged(ByVal sender As Object, ByVal e As EventArgs) Handles mcDate.DateChanged
        Me.Cursor = Cursors.WaitCursor
        ReturnConferenceEachDay(mcDate.SelectedDate)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btnSure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSure.Click
        clbDelegates.Items.Add(txtOther.Text)
        clbDelegates.SetItemChecked(clbDelegates.Items.Count - 1, True)
        txtOther.Text = String.Empty
    End Sub

    Private Sub txtOther_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOther.TextChanged
        btnSure.Enabled = txtOther.Text <> String.Empty
    End Sub

    Private Sub btnExit_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ConfirmClose(sender, e)
    End Sub
    Private Function ConfirmClose(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        If strStatus <> String.Empty Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1003") 'MessageBox.Show("数据已修改，是否保存？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If answer = DialogResult.Yes Then
                btnSave_Click(Nothing, Nothing)
                If IsWrong Then Return False
            ElseIf answer = DialogResult.Cancel Then
                Return False
            End If
        End If
        RemoveHandler MyBase.Closing, AddressOf frmMeetSetup_Closing
        Close()
        Return True
    End Function

    Private Sub frmMeetSetup_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, e)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim delConCode As Integer
        Dim delConDate As Date
        Dim delTime As String
        Try
            delConCode = CInt(CType(bmTemp.Current, DataRowView)("conference_code"))
            delConDate = DateTime.Parse(CType(bmTemp.Current, DataRowView)("conference_date"))
            delTime = CStr(CType(bmTemp.Current, DataRowView)("start_time"))
        Catch
            SWDialogBox.MessageBox.Show("$X030")
            'MessageBox.Show("并无会议可撤销", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnDelete.Enabled = False
        End Try

        'MessageBox.Show("您将撤销该会议(日期：" & delConDate & "；时间：" & delTime & ")？", "警告", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If SWDialogBox.MessageBox.Show("?X002", "(日期：" & delConDate & "；时间：" & delTime & ")") = DialogResult.Yes Then
            '从会议评委的会议编码列表中删除该会议编码
            strConCode.Replace(delConCode.ToString & ",", "")
            Dim strResult As String
            If CStr(CType(bmTemp.Current, DataRowView)("status")) = "未安排" Then
                Dim dsConTrial As DataSet
                dsConTrial = gWs.GetConfTrialInfo("{conference_code=" & delConCode & "}", "null")
                Dim dr As DataRow
                For Each dr In dsConTrial.Tables("conference_trial").Rows
                    dr("conference_code") = DBNull.Value
                    dr("serial_num") = DBNull.Value
                    dr("prime_committeeman") = DBNull.Value
                Next
                If dsConTrial.HasChanges Then
                    If gWs.UpdateConfTrial(dsConTrial) <> "1" Then
                        SWDialogBox.MessageBox.Show("*999", "修改项目评审记录失败", "", "")
                        'MessageBox.Show("修改项目评审记录出错", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return
                    End If
                End If
                dsConference.Tables(0).Select("conference_code=" & delConCode)(0).Delete()
                strResult = gWs.UpdateConferenceCommitteeman(dsConference.GetChanges)
            Else
                strResult = gWs.CancelReviewConferencePlan(CStr(delConCode))
                dsConference.Tables(0).Select("conference_code=" & delConCode)(0).Delete()
            End If
            If strResult = "1" Then
                SWDialogBox.MessageBox.Show("$OperateSucceed")
                'MessageBox.Show("撤销会议成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dsConference.AcceptChanges()
                If dsConference.Tables("conference").Select("conference_date=#" & delConDate.Date & "#").Length = 0 Then
                    mcDate.DeleteColorDate(delConDate)
                    mcDate.UpdateColorDates()
                End If
                ReturnConferenceEachDay(delConDate)
            Else
                SWDialogBox.MessageBox.Show("*999", "撤销会议失败", strResult, "")
                'MessageBox.Show("撤销会议失败" & vbCr & strResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub CancelProjectEvent(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelProject.Click
        Dim PC As String = CStr(CType(bmProject.Current, DataRowView)("project_code"))
        Dim CorName As String = CStr(CType(bmProject.Current, DataRowView)("CorName"))
        'MessageBox.Show("确定将该项目(" & PC & "：" & CorName & ")从当前会议退出？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If SWDialogBox.MessageBox.Show("?1004", "(" & PC & "：" & CorName & ")") = DialogResult.No Then
            Return
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim result As String
            result = gWs.CancelReviewConferencePlanProject(PC)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "回退项目失败", result, "")
                Return
            End If
            Dim SerialNum As Integer = CInt(CType(bmProject.Current, DataRowView)("SerialNum"))
            Dim ConCode As Integer = CInt(CType(bmTemp.Current, DataRowView)("conference_code"))
            Dim TT As Integer = CInt(CType(bmProject.Current, DataRowView)("times"))
            Dim ds As DataSet = gWs.GetConfTrialInfo("{conference_code=" & ConCode & "}", "null")
            '置空会议评审记录的字段
            With ds.Tables("conference_trial").Select("project_code LIKE '" & PC & "' AND trial_times=" & TT)(0)
                .Item("conference_code") = DBNull.Value
                .Item("serial_num") = DBNull.Value
                .Item("prime_committeeman") = DBNull.Value
            End With
            '修改同一会议评审项目的上会次序
            Dim dr As DataRow
            For Each dr In ds.Tables("conference_trial").Select("conference_code=" & ConCode)
                If CInt(dr("serial_num")) > SerialNum Then
                    dr("serial_num") = CInt(dr("serial_num")) - 1
                End If
            Next
            result = gWs.UpdateConfTrial(ds.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "保存评审会议记录失败", result, "")
                Return
            End If
            '删除本地数据集的该项目的记录
            If dsPro.Tables(0).Select("project_code='" & PC & "' AND times=" & TT.ToString).Length > 0 Then
                dsPro.Tables(0).Rows.Remove(dsPro.Tables(0).Select("project_code='" & PC & "' AND times=" & TT.ToString)(0))
            End If
            bmTemp_CurrentChanged(sender, e)
            RefreshMessage()
            MyBase.raiseCommitSucceed()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '项目安排
    Private Sub btnArrangeProject_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnArrangeProject.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim con_code As Integer = CInt(CType(bmTemp.Current, DataRowView)("conference_code"))
            Dim con_date As Date = DateTime.Parse(CType(bmTemp.Current, DataRowView)("conference_date"))
            Dim con_time As String = CStr(CType(bmTemp.Current, DataRowView)("start_time"))
            Dim status As String = CStr(CType(bmTemp.Current, DataRowView)("status"))
            Dim ofrmSettleMeet As frmSettleMeet = New frmSettleMeet(con_code, con_date.Date, con_time, GetProjectList, IIf(status = "已安排", True, False))
            ofrmSettleMeet.Owner = Me
            ofrmSettleMeet.AllowTransparency = False
            ofrmSettleMeet.isCommitConfirm = MyBase.isCommitConfirm
            AddHandler MyBase.Activated, AddressOf Me_Activated
            ofrmSettleMeet.StartPosition = FormStartPosition.CenterScreen
            ofrmSettleMeet.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RemoveHandler MyBase.Activated, AddressOf Me_Activated
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function GetProjectList() As String
        Dim ds As DataSet = gWs.GetConferenceProjectList(UserName)
        Dim result As String = ""
        Dim dr As DataRow
        For Each dr In ds.Tables(0).Rows
            result += "'" & CStr(dr("ProjectCode")) & "',"
        Next
        If result <> "" Then
            result = result.Substring(0, result.Length - 1)
        End If
        Return result
    End Function

    Private Sub Me_Activated(ByVal sender As Object, ByVal e As EventArgs)
        If IsOwnedFormCommit Then
            RemoveHandler MyBase.Closing, AddressOf frmMeetSetup_Closing
            Close()
        End If
        RemoveHandler MyBase.Activated, AddressOf Me_Activated
    End Sub

    Private Sub cmbxStartTime_leave(ByVal sender As Object, ByVal e As EventArgs) Handles cmbxStartTime.Leave
        If cmbxStartTime.FindStringExact(cmbxStartTime.Text) < 0 Then
            Try
                Dim dt As DateTime = DateTime.Parse(cmbxStartTime.Text & ":01")
                cmbxStartTime.Text = Format(dt, "H:mm")
            Catch
                cmbxStartTime.Text = String.Empty
            End Try
        End If
    End Sub


    Private Sub cboRoom_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboRoom.SelectedValueChanged
        GetAllConferenceCommitteeman(cboRoom.Text)
    End Sub
End Class
