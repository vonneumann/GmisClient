Public Class frmMeetQuery
    Inherits Form

    Private dsConference As DataSet
    Private SystemDate As Date
    Private dsShow As DataSet
    Private bmShow As CurrencyManager
    Private dsTime As DataSet
    Private bmTime As BindingManagerBase
    Private MeetDates() As Date
    Private htSelected As Hashtable
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not htSelected Is Nothing Then
            htSelected = Nothing
        End If
        If Not MeetDates Is Nothing Then
            MeetDates = Nothing
        End If
        If Not dsShow Is Nothing Then
            dsShow.Dispose()
        End If
        If Not dsTime Is Nothing Then
            dsTime.Dispose()
        End If
        If Not dsConference Is Nothing Then
            dsConference.Dispose()
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDetailInfo As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnRecord As System.Windows.Forms.Button
    Friend WithEvents lbxStartTimes As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lbxDelegates As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbxMeetDates As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nudYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbxMonth As System.Windows.Forms.ComboBox
    Friend WithEvents btnSure As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgMeet As System.Windows.Forms.DataGrid
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMeetQuery))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnSure = New System.Windows.Forms.Button()
        Me.cmbxMonth = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbxMeetDates = New System.Windows.Forms.ListBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbxDelegates = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbxStartTimes = New System.Windows.Forms.ListBox()
        Me.btnDetailInfo = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnRecord = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgMeet = New System.Windows.Forms.DataGrid()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgMeet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnSure, Me.cmbxMonth, Me.Label2, Me.nudYear, Me.Label1, Me.GroupBox4, Me.GroupBox3, Me.GroupBox2})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 240)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(642, 152)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        '
        'btnSure
        '
        Me.btnSure.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSure.Location = New System.Drawing.Point(160, 11)
        Me.btnSure.Name = "btnSure"
        Me.btnSure.Size = New System.Drawing.Size(64, 23)
        Me.btnSure.TabIndex = 8
        Me.btnSure.Text = "确定(&S)"
        '
        'cmbxMonth
        '
        Me.cmbxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cmbxMonth.Location = New System.Drawing.Point(96, 12)
        Me.cmbxMonth.Name = "cmbxMonth"
        Me.cmbxMonth.Size = New System.Drawing.Size(40, 20)
        Me.cmbxMonth.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(136, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "月"
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(16, 12)
        Me.nudYear.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.ReadOnly = True
        Me.nudYear.Size = New System.Drawing.Size(56, 21)
        Me.nudYear.TabIndex = 5
        Me.nudYear.Value = New Decimal(New Integer() {2003, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(72, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "年"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.lbxMeetDates})
        Me.GroupBox4.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(336, 104)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "会议日期"
        '
        'lbxMeetDates
        '
        Me.lbxMeetDates.ColumnWidth = 75
        Me.lbxMeetDates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxMeetDates.ItemHeight = 12
        Me.lbxMeetDates.Location = New System.Drawing.Point(3, 17)
        Me.lbxMeetDates.MultiColumn = True
        Me.lbxMeetDates.Name = "lbxMeetDates"
        Me.lbxMeetDates.Size = New System.Drawing.Size(330, 76)
        Me.lbxMeetDates.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.lbxDelegates})
        Me.GroupBox3.Location = New System.Drawing.Point(456, 16)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(176, 128)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "会议评委"
        '
        'lbxDelegates
        '
        Me.lbxDelegates.ColumnWidth = 55
        Me.lbxDelegates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxDelegates.ItemHeight = 12
        Me.lbxDelegates.Location = New System.Drawing.Point(3, 17)
        Me.lbxDelegates.MultiColumn = True
        Me.lbxDelegates.Name = "lbxDelegates"
        Me.lbxDelegates.Size = New System.Drawing.Size(170, 100)
        Me.lbxDelegates.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.lbxStartTimes})
        Me.GroupBox2.Location = New System.Drawing.Point(352, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(96, 128)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "会议开始时间"
        '
        'lbxStartTimes
        '
        Me.lbxStartTimes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxStartTimes.ItemHeight = 12
        Me.lbxStartTimes.Location = New System.Drawing.Point(3, 17)
        Me.lbxStartTimes.Name = "lbxStartTimes"
        Me.lbxStartTimes.Size = New System.Drawing.Size(90, 100)
        Me.lbxStartTimes.TabIndex = 0
        '
        'btnDetailInfo
        '
        Me.btnDetailInfo.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDetailInfo.Enabled = False
        Me.btnDetailInfo.Image = CType(resources.GetObject("btnDetailInfo.Image"), System.Drawing.Bitmap)
        Me.btnDetailInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetailInfo.ImageIndex = 1
        Me.btnDetailInfo.ImageList = Me.ImageList1
        Me.btnDetailInfo.Location = New System.Drawing.Point(328, 400)
        Me.btnDetailInfo.Name = "btnDetailInfo"
        Me.btnDetailInfo.Size = New System.Drawing.Size(120, 23)
        Me.btnDetailInfo.TabIndex = 30
        Me.btnDetailInfo.Text = "项目详细信息(&L)"
        Me.btnDetailInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 0
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(462, 400)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 31
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRecord
        '
        Me.btnRecord.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRecord.Enabled = False
        Me.btnRecord.Image = CType(resources.GetObject("btnRecord.Image"), System.Drawing.Bitmap)
        Me.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRecord.ImageIndex = 3
        Me.btnRecord.ImageList = Me.ImageList1
        Me.btnRecord.Location = New System.Drawing.Point(194, 400)
        Me.btnRecord.Name = "btnRecord"
        Me.btnRecord.Size = New System.Drawing.Size(120, 23)
        Me.btnRecord.TabIndex = 32
        Me.btnRecord.Text = "会议评审结论(&R)"
        Me.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRecord.Visible = False
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Bitmap)
        Me.btnExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcel.ImageIndex = 2
        Me.btnExcel.ImageList = Me.ImageList1
        Me.btnExcel.Location = New System.Drawing.Point(103, 400)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(77, 23)
        Me.btnExcel.TabIndex = 33
        Me.btnExcel.Text = "导 出(&E)"
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = "D"
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "上次上会日期"
        Me.DataGridTextBoxColumn1.MappingName = "PrevDateTime"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'dgMeet
        '
        Me.dgMeet.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.dgMeet.CaptionVisible = False
        Me.dgMeet.DataMember = ""
        Me.dgMeet.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMeet.Location = New System.Drawing.Point(8, 8)
        Me.dgMeet.Name = "dgMeet"
        Me.dgMeet.ReadOnly = True
        Me.dgMeet.Size = New System.Drawing.Size(640, 232)
        Me.dgMeet.TabIndex = 34
        '
        'frmMeetQuery
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(656, 429)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgMeet, Me.btnExcel, Me.btnRecord, Me.btnExit, Me.btnDetailInfo, Me.GroupBox1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMeetQuery"
        Me.Text = "会议查询"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgMeet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    
    Private Sub GetMeetProject(ByVal ConCode As Integer)
        If Not htSelected.ContainsKey(ConCode.ToString) Then
            htSelected.Add(ConCode.ToString, ConCode.ToString)
            Dim ds As DataSet = gWs.GetNeedMeetProjectInfo("", ConCode, "2")
            ds.Tables(0).Columns.Add("PrevDT", GetType(String))
            Dim dr As DataRow
            For Each dr In ds.Tables(0).Rows
                If Not IsDBNull(dr("PrevDateTime")) Then
                    dr("PrevDT") = String.Format("{0:yyyy年M月d日}", DateTime.Parse(dr("PrevDateTime")))
                End If
            Next
            If bmShow Is Nothing Then
                dsShow = New DataSet()
                dsShow = ds.Clone
                dsShow.Merge(ds.Tables(0).Select("", "SerialNum", DataViewRowState.CurrentRows))
                dgMeet.DataMember = "Table"
                dgMeet.DataSource = dsShow
                AddTableStyle()
            Else
                dsShow.Merge(ds.Tables(0).Select("", "SerialNum", DataViewRowState.CurrentRows))
            End If
            ds.Dispose()
        End If
        bmShow = BindingContext(dsShow, "Table")
        CType(bmShow.List, DataView).RowFilter = "ConCode=" & ConCode.ToString
    End Sub

    Private Sub GetMeetingDates(ByVal myYear As Integer, ByVal myMonth As Integer)
        Dim MinDate As DateTime = New DateTime(myYear, myMonth, 1)
        Dim MaxDate As DateTime = New DateTime(IIf(myMonth = 12, myYear + 1, myYear), IIf(myMonth = 12, 1, myMonth + 1), 1)
        Dim ConCodeList As String = String.Empty
        dsConference = gWs.GetConferenceInfo("{(conference_date>='" & MinDate & "' AND conference_date<'" & MaxDate & "') ORDER BY conference_date}", "null")
        If (dsConference.Tables("conference").Rows.Count > 0) Then   '设置已有会议日期为粗体
            Dim totalCount As Integer = dsConference.Tables("conference").Rows.Count
            ReDim MeetDates(totalCount - 1)
            Dim i As Integer
            Dim eachDate As Date
            For i = 0 To totalCount - 1
                eachDate = DateTime.Parse(dsConference.Tables("conference").Rows(i).Item("conference_date")).Date
                MeetDates(i) = eachDate.ToString("yyyy-MM-dd")
                ConCodeList += CStr(dsConference.Tables("conference").Rows(i).Item("conference_code")) & ","
            Next
            For Each eachDate In MeetDates
                'If lbxMeetDates.Items.Count > 0 Then
                    If lbxMeetDates.Items.IndexOf(eachDate.ToString("yyyy-MM-dd")) < 0 Then
                        lbxMeetDates.Items.Add(eachDate.ToString("yyyy-MM-dd"))
                    End If
                    'Else
                    '    lbxMeetDates.Items.Add(eachDate.ToString("yyyy-MM-dd"))
                    'End If
            Next
            dsConference.Tables.Remove(dsConference.Tables("conference_committeeman"))
            dsConference.Merge(gWs.GetConferenceInfo("null", "{conference_code IN (" & ConCodeList.Substring(0, ConCodeList.Length - 1) & ")}").Tables("conference_committeeman"))
        End If
    End Sub

    Private Sub frmMeetQuery_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        htSelected = New Hashtable()
        SystemDate = gWs.GetSysTime
        nudYear.Value = SystemDate.Year
        cmbxMonth.Text = SystemDate.Month.ToString
        GetMeetingDates(Convert.ToInt32(nudYear.Value), Convert.ToInt32(cmbxMonth.Text))
    End Sub


    Private Sub AddTableStyle()
        Me.dgMeet.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "Table"
        dgts.AllowSorting = False
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 3
        col5.MappingName = "SerialNum"
        col5.HeaderText = "上会次序"
        col5.Width = 55
        col5.NullText = String.Empty
        col5.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col5)
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 0
        col1.MappingName = "project_code"
        col1.HeaderText = "项目编码"
        col1.Width = 65
        col1.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col1)
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 0
        col8.MappingName = "Area"
        col8.HeaderText = "区域"
        col8.Width = 90
        col8.NullText = String.Empty
        col8.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col8)
        Dim col12 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col12.MappingName = "PrevDT"
        col12.HeaderText = "上次上会日期"
        col12.NullText = String.Empty
        col12.Width = 90
        dgts.GridColumnStyles.Add(col12)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1 
        col2.MappingName = "CorName"
        col2.HeaderText = "企业名称"
        col2.Alignment = HorizontalAlignment.Left
        col2.NullText = String.Empty
        col2.Width = 130
        dgts.GridColumnStyles.Add(col2)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 5
        col3.MappingName = "PMA"
        col3.HeaderText = "责任A角"
        col3.Width = 75
        col3.NullText = String.Empty
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 6
        col7.MappingName = "PMB"
        col7.HeaderText = "责任B角"
        col7.Width = 65
        col7.NullText = String.Empty
        col7.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col7)
        Dim col21 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index 5
        col21.MappingName = "nowManagerA"
        col21.HeaderText = "处理A角"
        col21.Width = 75
        col21.NullText = String.Empty
        col21.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col21)
        Dim col22 As DataGridTextBoxColumn = New DataGridTextBoxColumn    'index 6
        col22.MappingName = "nowManagerB"
        col22.HeaderText = "处理B角"
        col22.Width = 65
        col22.NullText = String.Empty
        col22.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col22)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 4  为删除dsConferenceTrial而设计
        col6.MappingName = "times"
        col6.HeaderText = "上会次数"
        col6.Width = 60
        col6.NullText = String.Empty
        col6.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col6)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col4.MappingName = "prime_committee"
        col4.HeaderText = "  主评委"
        col4.Alignment = HorizontalAlignment.Center
        col4.Width = 75
        col4.NullText = String.Empty
        dgts.GridColumnStyles.Add(col4)
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col9.MappingName = "ServiceType"
        col9.HeaderText = "业务品种"
        col9.Alignment = HorizontalAlignment.Center
        col9.Width = 120
        col9.NullText = String.Empty
        dgts.GridColumnStyles.Add(col9)
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col10.MappingName = "ApplySum"
        col10.HeaderText = "申请金额(万元)"
        col10.Alignment = HorizontalAlignment.Left
        col10.Width = 110
        col10.Format = "n"
        col10.NullText = String.Empty
        dgts.GridColumnStyles.Add(col10)
        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col11.MappingName = "RecommendSum"
        col11.HeaderText = "拟同意金额(万元)"
        col11.Alignment = HorizontalAlignment.Left
        col11.Width = 120
        col11.Format = "n"
        col11.NullText = String.Empty
        dgts.GridColumnStyles.Add(col11)
        Me.dgMeet.TableStyles.Add(dgts)
    End Sub
    Private OldDate As String = ""
    Private Sub lbxMeetDates_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lbxMeetDates.MouseUp
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            If lbxMeetDates.SelectedItem Is Nothing Then
                Return
            End If
            If lbxMeetDates.SelectedItem.ToString = OldDate Then Return '选择的日期并没变化
            OldDate = lbxMeetDates.SelectedItem.ToString

            lbxStartTimes.Tag = "false"
            If Not dsTime Is Nothing Then
                Dim dr As DataRow
                For Each dr In dsTime.Tables(0).Rows
                    dr.Delete()
                Next
                dsTime.AcceptChanges()
            Else
                dsTime = New DataSet()
            End If
            lbxDelegates.Items.Clear()
            Dim selDate As Date = DateTime.Parse(lbxMeetDates.SelectedItem).Date
            dsTime.Merge(dsConference.Tables("conference").Select("conference_date>=#" & selDate & "# AND conference_date<#" & selDate.AddDays(1).Date & "#"))
            If bmTime Is Nothing Then
                If dsTime.Tables.Count = 0 Then
                    dsTime.Merge(dsConference.Tables("conference").Clone)
                End If
                bmTime = BindingContext(dsTime, "conference")
                lbxStartTimes.DataSource = dsTime.Tables("conference")
                lbxStartTimes.DisplayMember = "start_time"
                lbxStartTimes.ValueMember = "conference_code"
                AddHandler lbxStartTimes.SelectedIndexChanged, AddressOf lbxStartTimes_SelectedIndexChanged
            End If
            lbxStartTimes.Tag = "true"
            lbxStartTimes_SelectedIndexChanged(Nothing, Nothing)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "警告", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub lbxStartTimes_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        If lbxStartTimes.Tag.ToString = "false" Then
            Return
        End If

        lbxDelegates.Items.Clear()
        GetMeetProject(CInt(lbxStartTimes.SelectedValue))
        btnRecord.Enabled = (dgMeet.CurrentRowIndex > -1) : btnDetailInfo.Enabled = btnRecord.Enabled
        '会议评委 
        Dim dr As DataRow
        For Each dr In dsConference.Tables("conference_committeeman").Select("conference_code=" & CInt(lbxStartTimes.SelectedValue))
            lbxDelegates.Items.Add(dr.Item("committeeman"))
        Next
    End Sub

    Private Sub btnRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecord.Click
        If lbxStartTimes.SelectedIndex < 0 Then
            SWDialogBox.MessageBox.Show("$1005", "会议开始时间")
            'MessageBox.Show("请选中一个会议", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        With dgMeet
            Dim index As Integer = .CurrentRowIndex
            Dim ProCode As String = CStr(.Item(index, 1))
            Dim Cor_Name As String = CStr(.Item(index, 3))
            Dim oForm As frmMeetingRecord = New frmMeetingRecord()
            oForm.ConCode = CInt(lbxStartTimes.SelectedValue)
            oForm.OpenApplyTool(ProCode, Cor_Name, "01", "RecordReviewConclusion", Me, UserName)
        End With
    End Sub
    '察看项目详细信息
    Private Sub btnDetailInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetailInfo.Click
        If dgMeet.CurrentRowIndex < 0 Then
            SWDialogBox.MessageBox.Show("$1005", "项目")  '请选中一个项目
            Return
        End If
        Dim rowView As DataRowView = CType(bmShow.Current, DataRowView)
        Dim Pro_Code As String = rowView("project_code") & String.Empty 'CStr(dgMeet.Item(dgMeet.CurrentRowIndex, 1))
        Dim Cor_name As String = rowView("CorName") & String.Empty 'CStr(dgMeet.Item(dgMeet.CurrentRowIndex, 4))
        Dim ofrmShowProjectInfo As frmShowProjectInfo = New frmShowProjectInfo(Pro_Code, Cor_name)
        ofrmShowProjectInfo.ShowDialog()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
    Private IsChanged As Boolean = False
    Private Sub btnSure_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSure.Click
        If IsChanged Then
            Try
                Me.Cursor = Cursors.WaitCursor
                lbxStartTimes.Tag = "false"
                If Not dsTime Is Nothing Then
                    Dim dr As DataRow
                    For Each dr In dsTime.Tables(0).Rows
                        dr.Delete()
                    Next
                    dsTime.AcceptChanges()
                End If
                lbxStartTimes.Tag = "true"
                Dim i As Integer
                For i = lbxMeetDates.Items.Count - 1 To 0 Step -1
                    lbxMeetDates.Items.RemoveAt(i)
                Next
                For i = lbxDelegates.Items.Count - 1 To 0 Step -1
                    lbxDelegates.Items.RemoveAt(i)
                Next
                If Not bmShow Is Nothing Then
                    CType(bmShow.List, DataView).RowFilter = "ConCode = -1"
                End If
                btnDetailInfo.Enabled = False : btnRecord.Enabled = False
                GetMeetingDates(Convert.ToInt32(nudYear.Value), Convert.ToInt32(cmbxMonth.Text))
                OldDate = ""
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
                'MessageBox.Show("发生错误" & vbCr & ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                IsChanged = False
                Me.Cursor = Cursors.Default
            End Try
        End If
    End Sub

    Private Sub cmbxMonth_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbxMonth.SelectedIndexChanged
        IsChanged = True
    End Sub

    Private Sub nudYear_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudYear.ValueChanged
        IsChanged = True
    End Sub
    '
    '打印会议项目情况到Excel
    '
    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        If lbxMeetDates.SelectedItem Is Nothing Then
            SWDialogBox.MessageBox.Show("$1001", "会议日期")
            Return
        End If
        Dim fName As String = "会议" & lbxMeetDates.SelectedItem.ToString() & "项目安排表"
        ReportToExcel.ToExcel(Me.dgMeet, fName, fName)
        'Dim sfd As SaveFileDialog = New SaveFileDialog()
        'sfd.FileName = "会议" & lbxMeetDates.SelectedItem.ToString() & "项目安排表"
        'sfd.Filter = "Excel文件|*.xls"
        'Dim FilePath As String = String.Empty
        'If sfd.ShowDialog = DialogResult.OK Then
        '    FilePath = sfd.FileName '.Replace(".xls)", String.Empty)
        'Else
        '    Return
        'End If

        'Dim oExcel As Excel.ApplicationClass
        'Try
        '    If System.IO.File.Exists(FilePath) Then
        '        System.IO.File.Delete(FilePath)
        '    End If
        '    Me.Cursor = Cursors.WaitCursor
        '    oExcel = New Excel.ApplicationClass()
        '    oExcel.Application.Workbooks.Add()

        '    oExcel.Application.Workbooks(1).SaveAs(FilePath)
        '    Dim workBook As Excel.WorkbookClass = oExcel.ActiveWorkbook
        '    Dim workSheet As Excel.Worksheet = workBook.Sheets(1)
        '    Dim rang As Excel.Range = workSheet.Cells
        '    Dim i, row, col As Integer
        '    Dim column As DataGridTextBoxColumn
        '    For Each column In dgMeet.TableStyles(0).GridColumnStyles
        '        row = 4
        '        col = dgMeet.TableStyles(0).GridColumnStyles.IndexOf(column)
        '        rang.Item(row, col + 1) = column.HeaderText
        '        For i = 0 To bmShow.Count - 1
        '            rang.Item(row + i + 1, col + 1) = dsShow.Tables(0).Rows(i)(column.MappingName)
        '        Next
        '    Next
        '    workSheet.Columns.AutoFit()
        '    oExcel.Application.Visible = True
        'Catch ex As Exception
        '    If Not oExcel Is Nothing Then
        '        oExcel.Application.Workbooks.Close()
        '        '退出Excel,且不提示是否保存
        '        CType(oExcel.Application, Excel.ApplicationClass).Quit()
        '        oExcel = Nothing
        '    End If
        '    ExceptionHandler.ShowMessageBox(ex)
        'Finally
        '    Me.Cursor = Cursors.Default
        '    oExcel = Nothing
        '    'GC.Collect()
        'End Try
    End Sub

    Private Sub lbxMeetDates_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbxMeetDates.SelectedIndexChanged

    End Sub
End Class
