'作者：罗庆锋；日期2003-04-05
Public Class frmSettleMeet
    Inherits Form

    Private ProjectCode As String
    Private dsConference As DataSet  '返回所有大于当前日期的会议
    Private dsTemp As DataSet 'DataSet for show record
    Private dsConferenceTrial As DataSet 'DataSet for update to DataBase
    Private bmMeet As CurrencyManager
    Private SystemDate As DateTime

    Private ConferenceCode As Integer
    Private ConferenceDate As Date
    Private ConferenceTime As String

    Friend isCommitConfirm As Boolean
    Private HasArranged As Boolean  '会议状态为“已安排”则true，否则false
    Private OldPL As String         '旧的会议项目列表
    Private NewPL As String         '新的会议项目列表
    Private NPL As String           '需要上会的项目列表
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
    End Sub
    Public Sub New(ByVal con_code As Integer, ByVal con_date As Date, ByVal con_time As String, ByVal pl As String, ByVal _HasArranged As Boolean)
        MyBase.New()
        InitializeComponent()
        ConferenceCode = con_code
        ConferenceDate = con_date
        ConferenceTime = con_time
        NPL = pl
        HasArranged = _HasArranged
    End Sub
    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsConference Is Nothing Then
            dsConference.Dispose()
        End If
        If Not dsTemp Is Nothing Then
            dsTemp.Dispose()
        End If
        If Not dsConferenceTrial Is Nothing Then
            dsConferenceTrial.Dispose()
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
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents groupbox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gpbxMeeting As System.Windows.Forms.GroupBox
    Friend WithEvents dgMeet As System.Windows.Forms.DataGrid
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudMeetOrder As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtProCode As System.Windows.Forms.TextBox
    Friend WithEvents cmbxDelegates As System.Windows.Forms.ComboBox
    Public WithEvents txtMeetTime As System.Windows.Forms.TextBox
    Public WithEvents txtMeetDate As System.Windows.Forms.TextBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDetailInfo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgProList As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtContent As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSettleMeet))
        Me.txtMeetTime = New System.Windows.Forms.TextBox()
        Me.txtMeetDate = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.groupbox = New System.Windows.Forms.GroupBox()
        Me.cmbxDelegates = New System.Windows.Forms.ComboBox()
        Me.txtProCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudMeetOrder = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gpbxMeeting = New System.Windows.Forms.GroupBox()
        Me.dgMeet = New System.Windows.Forms.DataGrid()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDetailInfo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgProList = New System.Windows.Forms.DataGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtContent = New System.Windows.Forms.TextBox()
        Me.groupbox.SuspendLayout()
        CType(Me.nudMeetOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbxMeeting.SuspendLayout()
        CType(Me.dgMeet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgProList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtMeetTime
        '
        Me.txtMeetTime.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMeetTime.Location = New System.Drawing.Point(280, 8)
        Me.txtMeetTime.Name = "txtMeetTime"
        Me.txtMeetTime.ReadOnly = True
        Me.txtMeetTime.Size = New System.Drawing.Size(112, 21)
        Me.txtMeetTime.TabIndex = 32
        Me.txtMeetTime.Text = ""
        '
        'txtMeetDate
        '
        Me.txtMeetDate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMeetDate.Location = New System.Drawing.Point(80, 8)
        Me.txtMeetDate.Name = "txtMeetDate"
        Me.txtMeetDate.ReadOnly = True
        Me.txtMeetDate.Size = New System.Drawing.Size(96, 21)
        Me.txtMeetDate.TabIndex = 31
        Me.txtMeetDate.Text = ""
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(192, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 16)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "会议开始时间"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "会议日期"
        '
        'groupbox
        '
        Me.groupbox.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.groupbox.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbxDelegates, Me.txtProCode, Me.Label4, Me.nudMeetOrder, Me.Label2, Me.Label1})
        Me.groupbox.Location = New System.Drawing.Point(8, 497)
        Me.groupbox.Name = "groupbox"
        Me.groupbox.Size = New System.Drawing.Size(776, 35)
        Me.groupbox.TabIndex = 28
        Me.groupbox.TabStop = False
        '
        'cmbxDelegates
        '
        Me.cmbxDelegates.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.cmbxDelegates.BackColor = System.Drawing.SystemColors.HighlightText
        Me.cmbxDelegates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxDelegates.Location = New System.Drawing.Point(420, 10)
        Me.cmbxDelegates.Name = "cmbxDelegates"
        Me.cmbxDelegates.Size = New System.Drawing.Size(121, 20)
        Me.cmbxDelegates.TabIndex = 2
        '
        'txtProCode
        '
        Me.txtProCode.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtProCode.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtProCode.Location = New System.Drawing.Point(212, 10)
        Me.txtProCode.Name = "txtProCode"
        Me.txtProCode.ReadOnly = True
        Me.txtProCode.Size = New System.Drawing.Size(112, 21)
        Me.txtProCode.TabIndex = 0
        Me.txtProCode.Text = ""
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(148, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "项目编码"
        '
        'nudMeetOrder
        '
        Me.nudMeetOrder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.nudMeetOrder.BackColor = System.Drawing.SystemColors.HighlightText
        Me.nudMeetOrder.Location = New System.Drawing.Point(76, 10)
        Me.nudMeetOrder.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudMeetOrder.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudMeetOrder.Name = "nudMeetOrder"
        Me.nudMeetOrder.ReadOnly = True
        Me.nudMeetOrder.Size = New System.Drawing.Size(40, 21)
        Me.nudMeetOrder.TabIndex = 1
        Me.nudMeetOrder.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.Location = New System.Drawing.Point(12, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "上会次序"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(380, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 14)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "主评"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpbxMeeting
        '
        Me.gpbxMeeting.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.gpbxMeeting.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgMeet})
        Me.gpbxMeeting.Location = New System.Drawing.Point(8, 312)
        Me.gpbxMeeting.Name = "gpbxMeeting"
        Me.gpbxMeeting.Size = New System.Drawing.Size(776, 184)
        Me.gpbxMeeting.TabIndex = 27
        Me.gpbxMeeting.TabStop = False
        Me.gpbxMeeting.Text = "会议安排情况"
        '
        'dgMeet
        '
        Me.dgMeet.CaptionVisible = False
        Me.dgMeet.DataMember = ""
        Me.dgMeet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMeet.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMeet.Location = New System.Drawing.Point(3, 17)
        Me.dgMeet.Name = "dgMeet"
        Me.dgMeet.ReadOnly = True
        Me.dgMeet.Size = New System.Drawing.Size(770, 164)
        Me.dgMeet.TabIndex = 2
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.Location = New System.Drawing.Point(385, 542)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 8
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(471, 542)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDetailInfo
        '
        Me.btnDetailInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDetailInfo.Enabled = False
        Me.btnDetailInfo.Image = CType(resources.GetObject("btnDetailInfo.Image"), System.Drawing.Bitmap)
        Me.btnDetailInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetailInfo.Location = New System.Drawing.Point(256, 542)
        Me.btnDetailInfo.Name = "btnDetailInfo"
        Me.btnDetailInfo.Size = New System.Drawing.Size(120, 23)
        Me.btnDetailInfo.TabIndex = 3
        Me.btnDetailInfo.Text = "项目详细信息(&L)"
        Me.btnDetailInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgProList})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 192)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "申请上会项目一览表"
        '
        'dgProList
        '
        Me.dgProList.CaptionVisible = False
        Me.dgProList.DataMember = ""
        Me.dgProList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgProList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgProList.Location = New System.Drawing.Point(3, 17)
        Me.dgProList.Name = "dgProList"
        Me.dgProList.ReadOnly = True
        Me.dgProList.Size = New System.Drawing.Size(770, 172)
        Me.dgProList.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtContent})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 230)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 80)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "调研意见"
        '
        'txtContent
        '
        Me.txtContent.BackColor = System.Drawing.Color.Gainsboro
        Me.txtContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtContent.Location = New System.Drawing.Point(3, 17)
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.ReadOnly = True
        Me.txtContent.Size = New System.Drawing.Size(770, 60)
        Me.txtContent.TabIndex = 0
        Me.txtContent.Text = ""
        '
        'frmSettleMeet
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 573)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox2, Me.GroupBox1, Me.btnDetailInfo, Me.btnExit, Me.txtMeetTime, Me.txtMeetDate, Me.Label5, Me.Label6, Me.gpbxMeeting, Me.btnCommit, Me.groupbox})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettleMeet"
        Me.Text = "项目会议安排"
        Me.groupbox.ResumeLayout(False)
        CType(Me.nudMeetOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbxMeeting.ResumeLayout(False)
        CType(Me.dgMeet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgProList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub GetDataSource()
        'conference_trial    committeeman_opinion      ((conference_code=" & ConferenceCode & ") OR (conference_code IS NULL)) AND
        dsConferenceTrial = gWs.GetConfTrialInfo("{(project_code IN (" & NPL & ") OR conference_code=" & ConferenceCode & ") AND status=0}", "null")
        '上面尚有缺陷
        dsTemp = New DataSet()
        Dim drs As DataRow() = dsConferenceTrial.Tables("conference_trial").Select("conference_code=" & ConferenceCode)
        If drs.Length > 0 Then
            dsTemp.Merge(drs)
        Else
            dsTemp.Merge(dsConferenceTrial.Tables("conference_trial").Clone)
        End If

        With dsTemp.Tables("conference_trial")
            .Columns.Add("conclusion", GetType(String))
            .Columns.Add("PMA", GetType(String))
            .Columns.Add("PMB", GetType(String))
            .Columns.Add("Area", GetType(String))
            .Columns.Add("CorName", GetType(String))
            .Columns.Add("ServiceType", GetType(String))
            .Columns.Add("content", GetType(String))
            '.Columns.Add("GuarantySum", GetType(String))
            If .Rows.Count = 0 Then
                Return  '如没记录，返回空结构
            End If
        End With

        Dim dsInfo As DataSet  = gWs.GetNeedMeetProjectInfo("", ConferenceCode, "0") '("{b.conference_code=" & ConferenceCode & "}")
        Dim infoDR As DataRow
        For Each infoDR In dsInfo.Tables("Table").Rows
            With dsTemp.Tables("conference_trial").Select("project_code LIKE '" & CStr(infoDR("project_code")) & "' and trial_times=" & CInt(infoDR("times")))(0)
                .Item("conclusion") = infoDR("conclusion")
                .Item("PMA") = infoDR("PMA")
                .Item("PMB") = infoDR("PMB")
                .Item("Area") = infoDR("Area")
                .Item("CorName") = infoDR("CorName")
                .Item("ServiceType") = infoDR("ServiceType")
                .Item("content") = infoDR("content")
            End With
        Next
        dsTemp.AcceptChanges()
    End Sub

    Private Sub frmSettleMeet_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            If NPL.Trim = String.Empty Then
                SWDialogBox.MessageBox.Show("$X048")
                'MessageBox.Show("没有要上会的项目", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnCommit.Enabled = False
                Return
            End If
            txtMeetDate.Text = ConferenceDate.ToString("yyyy-MM-dd") : txtMeetTime.Text = CStr(ConferenceTime)
            GetDataSource()
            addTableStyle()
            bmMeet = BindingContext(dsTemp, "conference_trial")
            dgMeet.DataMember = "conference_trial"
            dgMeet.DataSource = dsTemp
            nudMeetOrder.Maximum = IIf(bmMeet.Count > 0, bmMeet.Count, 0)
            nudMeetOrder.Minimum = IIf(bmMeet.Count > 0, 1, 0)
            SystemDate = gWs.GetSysTime()
            CType(bmMeet.List, DataView).Sort = "serial_num" '本来注释掉得

            '返回会议评委
            dsConference = gWs.GetConferenceInfo("{(conference_code=" & ConferenceCode & ")}", "{(conference_code=" & ConferenceCode & ")}")
            cmbxDelegates.Items.Add(String.Empty)
            Dim dr As DataRow
            For Each dr In dsConference.Tables("conference_committeeman").Rows
                cmbxDelegates.Items.Add(dr("committeeman"))
            Next
            'cmbxDelegates.DataSource = dsConference.Tables("conference_committeeman")
            'cmbxDelegates.DisplayMember = "committeeman"
            'cmbxDelegates.ValueMember = "committeeman"
            AddHandler cmbxDelegates.SelectionChangeCommitted, AddressOf cmbxDelegates_SelectedValueChanged
            AddHandler nudMeetOrder.Leave, AddressOf nudmeetorder_Leave
            AddHandler bmMeet.CurrentChanged, AddressOf bmmeet_PosChanged
            bmmeet_PosChanged(sender, e)

            '''''''''''''
            dsTecType = New DataSet()
            dsTecType = gWs.GetTechnologyType("%")
            GetAnotherDataSource()
            AddOtherTableStyle()
            AddHandler dgMeet.DoubleClick, AddressOf TextBoxDoubleClickHandler
            AddHandler dgProList.DoubleClick, AddressOf TextBoxDoubleClickHandler
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '样式表
    Private Sub addTableStyle()
        dgMeet.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "conference_trial"
        dgts.AllowSorting = False
        'dgts.RowHeadersVisible = False
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "serial_num"                                      'index 0
        col5.HeaderText = "顺序"
        col5.Alignment = HorizontalAlignment.Center
        col5.Width = 50
        col5.NullText = String.Empty
        col5.TextBox.Tag = dgMeet
        AddHandler col5.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col5)
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()      'index 1
        col1.MappingName = "project_code"
        col1.HeaderText = "项目编码"
        col1.Width = 0
        col1.Alignment = HorizontalAlignment.Left
        col1.TextBox.Tag = dgMeet
        AddHandler col1.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col1)
        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2
        col11.MappingName = "Area"
        col11.HeaderText = "区域"
        col11.Width = 90
        col11.NullText = String.Empty
        col11.Alignment = HorizontalAlignment.Left
        col11.TextBox.Tag = dgMeet
        AddHandler col11.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col11)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 3 
        col2.MappingName = "CorName"
        col2.HeaderText = "企业名称"
        col2.Alignment = HorizontalAlignment.Left
        col2.NullText = String.Empty
        col2.Width = 170
        col2.TextBox.Tag = dgMeet
        AddHandler col2.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col2)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 5
        col3.MappingName = "PMA"
        col3.HeaderText = "项目经理A角"
        col3.Width = 70
        col3.NullText = String.Empty
        col3.Alignment = HorizontalAlignment.Left
        col3.TextBox.Tag = dgMeet
        AddHandler col3.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col3)
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 6
        col7.MappingName = "PMB"
        col7.HeaderText = "项目经理B角"
        col7.Width = 70
        col7.NullText = String.Empty
        col7.Alignment = HorizontalAlignment.Left
        col7.TextBox.Tag = dgMeet
        AddHandler col7.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col7)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 4  为删除dsConferenceTrial而设计
        col6.MappingName = "trial_times"
        col6.HeaderText = "上会次数"
        col6.Width = 55
        col6.NullText = String.Empty
        col6.Alignment = HorizontalAlignment.Center
        col6.TextBox.Tag = dgMeet
        AddHandler col6.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col6)
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col8.MappingName = "prime_committeeman"
        col8.HeaderText = "主评"
        col8.Alignment = HorizontalAlignment.Left
        col8.Width = 70
        col8.NullText = String.Empty
        col8.TextBox.Tag = dgMeet
        AddHandler col8.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col8)
        Dim col12 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col12.MappingName = "manager_recommend_sum"
        col12.HeaderText = "拟同意金额(万元)"
        col12.Width = 100
        col12.Format = "n"
        col12.NullText = String.Empty
        col12.TextBox.Tag = dgMeet
        AddHandler col12.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col12)
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col9.MappingName = "ServiceType"
        col9.HeaderText = "业务品种"
        col9.Alignment = HorizontalAlignment.Left
        col9.Width = 120
        col9.NullText = String.Empty
        col9.TextBox.Tag = dgMeet
        AddHandler col9.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col9)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col4.MappingName = "content"
        col4.HeaderText = "调研意见"
        col4.Alignment = HorizontalAlignment.Left
        col4.Width = 300
        col4.NullText = String.Empty
        col4.TextBox.Tag = dgMeet
        AddHandler col4.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col4)
        dgMeet.TableStyles.Add(dgts)
    End Sub

    Private Sub TextBoxDoubleClickHandler(ByVal sender As Object, ByVal e As EventArgs)
        DoSomething(CType(sender, DataGrid))
    End Sub
    Private Sub TextBoxMouseDownHandler(ByVal sender As Object, ByVal e As MouseEventArgs)
        DoSomething(CType(CType(sender, TextBox).Tag, DataGrid))
    End Sub

    Private Sub DoSomething(ByVal sender As DataGrid)
        If CType(sender.DataSource, DataSet).Tables(0).Rows.Count = 0 Then Return

        Dim PC As String : Dim TT As Integer
        Try
            Me.Cursor = Cursors.WaitCursor
            If sender Is dgProList Then 'dsShow,dsCollection 的转换,将dsShow的当前行转换为dsTemp,上会项目增加一个
                PC = CStr(CType(bmShow.Current, DataRowView)("project_code"))
                TT = CInt(CType(bmShow.Current, DataRowView)("times"))
                '初始化主评为空
                cmbxDelegates.SelectedItem = Nothing
                ' 获取当前选中项目的上次上会记录，主评赋一默认值
                Dim dsPrev As DataSet = gWs.GetConfTrialInfo("{project_code='" & PC & "' AND trial_times=" & (TT - 1).ToString & "}", "null")
                If dsPrev.Tables("conference_trial").Rows.Count > 0 Then
                    If Not IsDBNull(dsPrev.Tables("conference_trial").Rows(0)("prime_committeeman")) Then
                        cmbxDelegates.SelectedItem = dsPrev.Tables("conference_trial").Rows(0)("prime_committeeman")
                    End If
                End If
                dsPrev.Dispose()
                With dsShow.Tables(0).Rows(bmShow.Position)
                    Dim dr As DataRow = dsTemp.Tables(0).NewRow
                    dr("project_code") = PC
                    dr("trial_times") = TT
                    dr("prime_committeeman") = cmbxDelegates.Text
                    dr("serial_num") = bmMeet.Count + 1
                    dr("conclusion") = .Item("conclusion")
                    dr("content") = .Item("content")
                    dr("PMA") = .Item("PMA")
                    dr("PMB") = .Item("PMB")
                    dr("Area") = .Item("Area")
                    dr("CorName") = .Item("CorName")
                    dr("ServiceType") = .Item("ServiceType")
                    dr("manager_recommend_sum") = .Item("RecommendSum") '项目经理推荐金额
                    dsTemp.Tables(0).Rows.Add(dr)
                    dsTemp.AcceptChanges()
                End With
                With dsConferenceTrial.Tables("conference_trial").Select("project_code LIKE '" & PC & "' AND trial_times=" & TT)(0)
                    .Item("conference_code") = ConferenceCode
                    .Item("prime_committeeman") = cmbxDelegates.Text
                End With
                dsCollection.Tables(0).ImportRow(dsShow.Tables(0).Rows(bmShow.Position))
                dsShow.Tables(0).Rows.RemoveAt(bmShow.Position)
                nudMeetOrder.Maximum = bmMeet.Count
                nudMeetOrder.Minimum = 1
                bmMeet.Position = bmMeet.Count - 1
            ElseIf sender Is dgMeet Then    'dsShow,dsCollection 的转换,dsTemp删除当前行，dsConferenceTrial的会议编码置null
                PC = CStr(CType(bmMeet.Current, DataRowView)("project_code"))
                TT = CInt(CType(bmMeet.Current, DataRowView)("trial_times"))
                dgMeet.Tag = "false"
                Dim deleteOrder As Integer = CInt(CType(bmMeet.Current, DataRowView)("serial_num"))
                If deleteOrder <> bmMeet.Count Then
                    Dim drs() As DataRow = dsTemp.Tables("conference_trial").Select("serial_num>" & deleteOrder, "", DataViewRowState.CurrentRows)
                    Dim i As Integer
                    For i = drs.Length - 1 To 0 Step -1 'bmMeet.Count - 1
                        drs(i)("serial_num") = CInt(drs(i)("serial_num")) - 1
                    Next
                End If
                dgMeet.Tag = "true"
                dsTemp.Tables("conference_trial").Rows.Remove(dsTemp.Tables("conference_trial").Select("project_code='" & PC & "' AND trial_times=" & TT.ToString)(0))
                With dsConferenceTrial.Tables("conference_trial").Select("project_code LIKE '" & PC & "' AND trial_times=" & TT)(0)
                    .Item("conference_code") = DBNull.Value
                    .Item("prime_committeeman") = DBNull.Value
                    .Item("serial_num") = DBNull.Value
                End With
                dsShow.Tables(0).ImportRow(dsCollection.Tables(0).Select("project_code LIKE '" & PC & "' AND times=" & TT)(0))
                dsCollection.Tables(0).Rows.Remove(dsCollection.Tables(0).Select("project_code LIKE '" & PC & "' AND times=" & TT)(0))
                nudMeetOrder.Maximum = bmMeet.Count
                nudMeetOrder.Minimum = IIf(bmMeet.Count > 0, 1, 0)

            End If
            btnDetailInfo.Enabled = bmShow.Count > 0
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function RollbackSomeProjects() As Boolean
        If Not HasArranged Then Return True
        If OldPL Is Nothing Then Return True

        Dim dr As DataRow
        For Each dr In dsTemp.Tables(0).Rows
            NewPL += CStr(dr("project_code")) & ","
        Next
        Dim eachPC As String
        Dim result As String
        For Each eachPC In OldPL.Split(",")
            If eachPC.Trim <> String.Empty Then
                If NewPL.IndexOf(eachPC) < 0 Then
                    result = gWs.CancelReviewConferencePlanProject(eachPC)
                    If result <> "1" Then
                        SWDialogBox.MessageBox.Show("$X041", eachPC)
                        'MessageBox.Show("项目：" & eachPC & "回退失败" & vbCr & result, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Return False
                    End If
                End If
            End If
        Next
        Return True
    End Function


    Private Sub nudmeetorder_Leave(ByVal sender As Object, ByVal e As EventArgs)
        If bmMeet.Count = 0 Then Return
        Dim currentDRV As DataRowView = CType(bmMeet.Current, DataRowView)
        Dim currentPC As String = currentDRV("project_code").ToString
        Dim OldOrder As Integer = CInt(currentDRV("serial_num"))
        Dim NewOrder As Integer = CInt(nudMeetOrder.Value)
        '上会次序没改变，则返回
        If OldOrder = NewOrder Then
            dgMeet.Tag = "true"
            Return
        End If

        dgMeet.Tag = "false"

        Dim k As Integer = bmMeet.Position

        Dim i, EachOrder As Integer
        For i = 0 To bmMeet.Count - 1
            If dsTemp.Tables(0).Rows(i)("project_code").ToString <> currentPC Then    '确保修改的行不是当前行
                EachOrder = CInt(dsTemp.Tables(0).Rows(i)("serial_num"))
                If NewOrder > OldOrder Then
                    If EachOrder >= OldOrder + 1 And EachOrder <= NewOrder Then
                        dsTemp.Tables(0).Rows(i)("serial_num") = EachOrder - 1
                    End If
                Else
                    If EachOrder >= NewOrder And EachOrder <= OldOrder - 1 Then
                        dsTemp.Tables(0).Rows(i)("serial_num") = EachOrder + 1
                    End If
                End If
            End If
        Next

        dsTemp.Tables(0).Select("project_code='" & currentPC & "'")(0)("serial_num") = NewOrder
        bmMeet.Position = k
        dgMeet.Tag = "true"
        'CType(bmMeet.List, DataView).Sort = "serial_num" '本来注释掉得
        bmmeet_PosChanged(sender, e)
    End Sub

    Private Sub cmbxDelegates_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        If bmMeet.Count = 0 Then Return
        dgMeet.Tag = "false"
        CType(bmMeet.Current, DataRowView)("prime_committeeman") = cmbxDelegates.Text
        dgMeet.Tag = "true"
    End Sub

    Private Sub bmmeet_PosChanged(ByVal sender As Object, ByVal e As EventArgs)
        If bmMeet.Count = 0 Then
            txtProCode.Text = String.Empty
            Return
        End If
        If Not dgMeet.Tag Is Nothing Then
            If CStr(dgMeet.Tag) = "false" Then
                Return
            End If
        End If
        dgMeet.CurrentRowIndex = bmMeet.Position
        dgMeet.Select(bmMeet.Position)
        With CType(bmMeet.Current, DataRowView)
            txtProCode.Text = CStr(.Item("project_code"))
            nudMeetOrder.Value = CInt(.Item("serial_num"))
            cmbxDelegates.Text = CStr(.Item("prime_committeeman"))
        End With
    End Sub

    Private Sub SetSomeRecordConferenceCodeDbNull()
        Dim count As Int32 = bmShow.Count
        Dim i As Int32
        For i = 0 To count - 1
            dsConferenceTrial.Tables("conference_trial").Select("project_code='" & dsShow.Tables(0).Rows(i)("project_code").ToString & _
                   "' AND trial_times=" & dsShow.Tables(0).Rows(i)("times").ToString)(0)("conference_code") = DBNull.Value
        Next
    End Sub

    '工作流
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If dgMeet.CurrentRowIndex < 0 Then
            SWDialogBox.MessageBox.Show("$X039")
            'MessageBox.Show("没有项目安排到该会议，不能提交", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交") 'MessageBox.Show("请确定提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If
        If Not RollbackSomeProjects() Then Return '回退项目失败
        '设置某些记录的会议编码值为NULL
        SetSomeRecordConferenceCodeDbNull()
        Dim dv As DataView = CType(bmMeet.List, DataView)
        dv.Sort = "project_code"
        Dim i As Integer
        Dim realDRs As DataRow() = dsConferenceTrial.Tables("conference_trial").Select("conference_code=" & ConferenceCode, "project_code", DataViewRowState.CurrentRows)
        For i = 0 To realDRs.Length - 1
            realDRs(i)("serial_num") = dv(i)("serial_num")
            realDRs(i)("prime_committeeman") = dv(i)("prime_committeeman")
        Next

        Dim strResult As String = gWs.UpdateConfTrial(dsConferenceTrial.GetChanges)
        If strResult <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存失败", strResult, "")
            Return
        End If

        Dim strSuccess As String = gWs.FinishedReviewConferencePlan(ConferenceCode.ToString)
        If strSuccess = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            If Not HasArranged Then
                dsConference.Tables("conference").Rows(0)("status") = "已安排"
                If gWs.UpdateConferenceCommitteeman(dsConference.GetChanges) <> "1" Then
                    SWDialogBox.MessageBox.Show("*999", "会议状态保存出错", "", "")
                End If
            End If
            CType(Me.Owner, frmMeetSetup).IsOwnedFormCommit = True
            CType(Me.Owner, frmMeetSetup).raiseCommitSucceed()
            Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "提交失败", strSuccess, "")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    ''''''''''''''''''''''下面是申请上会项目的
    Private dsShow As DataSet
    Private bmShow As BindingManagerBase
    Private dsTecType As DataSet
    Private dsCollection As DataSet

    Private Sub GetAnotherDataSource()
        'and (b.conference_code=" & ConferenceCode & " OR b.conference_code IS NULL)
        'Dim condition As String = "{(b.project_code IN (" & NPL & ") OR b.conference_code=" & ConferenceCode & ") and b.status=0}"
        NPL = NPL.Replace("'", "")
        dsShow = gWs.GetNeedMeetProjectInfo(NPL, ConferenceCode, "0") '(condition)
        dsShow.Tables("Table").Columns.Add("TecType", GetType(String))
        Dim dr As DataRow
        Dim tecType As Integer : Dim strTechonologyType As String
        For Each dr In dsShow.Tables("Table").Rows
            If IsDBNull(dr("technology_type")) Then
                tecType = -1
            Else
                tecType = CInt(dr("technology_type"))
            End If
            If tecType <> -1 Then
                strTechonologyType = String.Empty
                Dim odr As DataRow
                For Each odr In dsTecType.Tables("TTechnologyType").Rows
                    If tecType And CInt(odr("technology_type_code")) Then
                        strTechonologyType += CStr(odr("technology_type")) & "，"
                    End If
                Next
                If strTechonologyType <> String.Empty Then
                    dr("TecType") = strTechonologyType.Substring(0, strTechonologyType.Length - 1)
                End If
            End If
        Next
        bmShow = BindingContext(dsShow, "Table")
        dgProList.DataMember = "Table"
        dgProList.DataSource = dsShow
        txtContent.DataBindings.Add(New Binding("Text", dsShow, "Table.content"))
        dsCollection = New DataSet()
        dsCollection = dsShow.Clone
        For Each dr In dsTemp.Tables("conference_trial").Rows
            OldPL += CStr(dr("project_code")) & ","
            dsCollection.Tables(0).ImportRow(dsShow.Tables(0).Select("project_code LIKE '" & CStr(dr("project_code")) & "'")(0))
            dsShow.Tables(0).Rows.Remove(dsShow.Tables(0).Select("project_code LIKE '" & CStr(dr("project_code")) & "'")(0))
        Next
        btnDetailInfo.Enabled = bmShow.Count > 0
    End Sub
    Private Sub AddOtherTableStyle()
        dgProList.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "Table"
        dgts.AllowSorting = False
        'dgts.RowHeadersVisible = False
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 0
        col1.MappingName = "project_code"
        col1.HeaderText = "项目编码"
        col1.Width = 0
        col1.Alignment = HorizontalAlignment.Left
        col1.TextBox.Tag = dgProList
        AddHandler col1.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col1)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1 
        col2.MappingName = "CorName"
        col2.HeaderText = "企业名称"
        col2.Alignment = HorizontalAlignment.Left
        col2.NullText = String.Empty
        col2.Width = 170
        col2.TextBox.Tag = dgProList
        AddHandler col2.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col2)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 5
        col3.MappingName = "PMA"
        col3.HeaderText = "项目经理A"
        col3.Width = 70
        col3.NullText = String.Empty
        col3.Alignment = HorizontalAlignment.Left
        col3.TextBox.Tag = dgProList
        AddHandler col3.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col3)
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 6
        col7.MappingName = "PMB"
        col7.HeaderText = "项目经理B"
        col7.Width = 70
        col7.NullText = String.Empty
        col7.Alignment = HorizontalAlignment.Left
        col7.TextBox.Tag = dgProList
        AddHandler col7.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col7)
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 0
        col8.MappingName = "Area"
        col8.HeaderText = "区域"
        col8.Width = 90
        col8.NullText = String.Empty
        col8.Alignment = HorizontalAlignment.Left
        col8.TextBox.Tag = dgProList
        AddHandler col8.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col8)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 4  为删除dsConferenceTrial而设计
        col6.MappingName = "times"
        col6.HeaderText = "上会次数"
        col6.Width = 55
        col6.NullText = String.Empty
        col6.Alignment = HorizontalAlignment.Center
        col6.TextBox.Tag = dgProList
        AddHandler col6.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col6)
        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col11.MappingName = "RecommendSum"
        col11.HeaderText = "拟同意金额(万元)"
        col11.Width = 100
        col11.Format = "c"
        col11.FormatInfo = CGFormatInfo
        col11.NullText = String.Empty
        col11.TextBox.Tag = dgProList
        AddHandler col11.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col11)
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col10.MappingName = "ApplySum"
        col10.HeaderText = "申请金额(万元)"
        col10.Width = 105
        col10.Format = "c"
        col10.FormatInfo = CGFormatInfo
        col10.NullText = String.Empty
        col10.TextBox.Tag = dgProList
        AddHandler col10.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col10)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col4.MappingName = "conclusion"
        col4.HeaderText = "调研结论 "
        col4.Alignment = HorizontalAlignment.Left
        col4.Width = 60
        col4.NullText = String.Empty
        col4.TextBox.Tag = dgProList
        AddHandler col4.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col4)
        Dim col12 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col12.MappingName = "TecType"
        col12.HeaderText = "科技类型"
        col12.Alignment = HorizontalAlignment.Left
        col12.Width = 110
        col12.NullText = String.Empty
        col12.TextBox.Tag = dgProList
        AddHandler col12.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col12)
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col9.MappingName = "ServiceType"
        col9.HeaderText = "业务品种 "
        col9.Alignment = HorizontalAlignment.Left
        col9.Width = 120
        col9.NullText = String.Empty
        col9.TextBox.Tag = dgProList
        AddHandler col9.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col9)
        Dim col13 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col13.MappingName = "conference_date"
        col13.HeaderText = "上次上会时间 "
        col13.Alignment = HorizontalAlignment.Left
        col13.Width = 120
        col13.NullText = String.Empty
        col13.TextBox.Tag = dgProList
        AddHandler col13.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col13)

        Dim col14 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col14.MappingName = "place"
        col14.HeaderText = "上次上会会场 "
        col14.Alignment = HorizontalAlignment.Left
        col14.Width = 120
        col14.NullText = String.Empty
        col14.TextBox.Tag = dgProList
        AddHandler col14.TextBox.MouseDown, AddressOf TextBoxMouseDownHandler
        dgts.GridColumnStyles.Add(col14)

        dgProList.TableStyles.Add(dgts)
    End Sub
    Private Sub btnDetailInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetailInfo.Click
        If dgProList.CurrentRowIndex < 0 Then
            'MessageBox.Show("请选中一个项目", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        Dim Pro_Code As String = CStr(CType(bmShow.Current, DataRowView)("project_code"))
        Dim Cor_name As String = CStr(CType(bmShow.Current, DataRowView)("CorName"))
        Dim ofrmShowProjectInfo As frmShowProjectInfo = New frmShowProjectInfo(Pro_Code, Cor_name)
        ofrmShowProjectInfo.ShowDialog()
    End Sub



End Class
