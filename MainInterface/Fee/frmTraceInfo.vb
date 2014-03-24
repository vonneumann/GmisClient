

Public Class frmTraceInfo
    Inherits frmBasic
    Private ProjectCode, CorCode, phase As String     'CorCode 企业编码
    Private TaskID As String
    Private WorkFlowID As String
    Private SerialNum As Integer '表示当前检查次数
    Private dsRecord As DataSet
    Private cmRecord As CurrencyManager
    Private dsAlarmType As DataSet
    Private dsAlarmDetail As DataSet
    Private htfSelected As Hashtable  '存储已选预警选项的哈希表
    Private SystemDate As Date
    Private DataChanged As Boolean = False

    Private dsCorCount As DataSet '财务数据数据集
    Private htfAccount As Hashtable '存储每一阶段的财务数据的哈希表
    Private ApplyDate As Date
    Private HistoryAlarm() As String    '保存历史预警等级内容
    Private Sub FormatBasicInfo()
        txtCorName.Text = MyBase.getCorporationName : txtProjectCode.Text = ProjectCode
        Dim dsProject As DataSet = New DataSet()
        dsProject = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
        txtMA.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.manager_A"))
        txtMB.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.manager_B"))
        txtMoney.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.GuaranteeSum"))
        txtBigBank.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.BankName"))
        txtBank.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.BranchBankName"))
        txtTerm.DataBindings.Add(New Binding("Text", dsProject, "ViewProject.terms"))
        CorCode = dsProject.Tables(0).Rows(0)("corporation_code").ToString
        ApplyDate = DateTime.Parse(dsProject.Tables(0).Rows(0)("ApplyDate").ToString)
        '''''合同号'''''''''''
        Dim dsProDoc As DataSet = gWs.GetProjectDocumentByCondition("{project_code LIKE '" & ProjectCode & "' AND item_type='43' AND item_code = '003'}")
        txtBargainNum.DataBindings.Add("Text", dsProDoc, "TProjectDocument.doc_id")
    End Sub

    Private Sub LoadData()
        htfSelected = New Hashtable()
        dsRecord = New DataSet()  '表名："guarantee_check_record"   "guarantee_check_alarm"
        dsRecord = gWs.GetCheckRecordInfo("{project_code LIKE '" & ProjectCode & "'}", "{project_code LIKE '" & ProjectCode & "'}")
        dsAlarmType = gWs.GetAlarmType("%")
        dsAlarmDetail = gWs.GetAlarmCode("%")
        cmRecord = BindingContext(dsRecord, "guarantee_check_record")
        If cmRecord.Count > 0 Then
            Dim dr As DataRow = dsRecord.Tables("guarantee_check_record").Rows(cmRecord.Count - 1)
            If CBool(dr("status")) Then '已经提交过
                SerialNum = cmRecord.Count + 1
            Else
                SerialNum = cmRecord.Count
                ''''初始化哈希表''''''
                Dim odr As DataRow
                For Each odr In dsRecord.Tables("guarantee_check_alarm").Select("serial_num=" & SerialNum)
                    htfSelected.Add(odr("alarm_type").ToString & ":" & odr("alarm").ToString, -1)
                Next
                ''''''''''''''''''''''
                txtYearMonth.Text = dr("finacial_report_month") & ""
                txtContactMan.Text = dr("contact_person") & ""
                txtPhone.Text = dr("contact_phone") & ""
                txtContent.Text = dr("explanation") & ""
                dtpCheckDate.Value = dr("check_date")
                btnDocument.Enabled = True
            End If
        Else
            SerialNum = 1
        End If
        ReDim HistoryAlarm(SerialNum)
        dgRecord.DataMember = "guarantee_check_record"
        dgRecord.DataSource = dsRecord
        AddTableStyleOfHistory()
        clbDescription.DataSource = dsAlarmDetail.Tables(0).DefaultView
        clbDescription.DisplayMember = "alarm_name"
        clbDescription.ValueMember = "alarm_code"
        cmbxAlarmGrade.DataSource = dsAlarmType.Tables(0).DefaultView
        cmbxAlarmGrade.DisplayMember = "alarm_type_name"
        cmbxAlarmGrade.ValueMember = "alarm_type"
        If dsAlarmType.Tables(0).Rows.Count > 0 Then
            cmbxAlarmGrade.SelectedIndex = 0
            cmbxAlarmGrade_SelectedValueChanged(cmbxAlarmGrade, Nothing)
        End If
        AddHandler cmbxAlarmGrade.SelectedValueChanged, AddressOf cmbxAlarmGrade_SelectedValueChanged
        AddHandler clbDescription.ItemCheck, AddressOf clbDescription_ItemCheck
        AddHandler cmRecord.PositionChanged, AddressOf CM_PositionChanged
        CM_PositionChanged(Nothing, Nothing)
    End Sub

    Private Sub cmbxAlarmGrade_SelectedValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim cmbx As ComboBox = CType(sender, ComboBox)
        If cmbx.SelectedIndex < 0 Then Return
        CType(clbDescription.DataSource, DataView).RowFilter = "alarm_type='" & CStr(cmbx.SelectedValue).Trim & "'"
        clbDescription.Tag = "false"
        clbDescription.ClearSelected()
        Dim str As String
        Dim AlarmType, AlarmCode As String
        Dim KeyList As IDictionaryEnumerator = htfSelected.GetEnumerator
        While KeyList.MoveNext
            str = KeyList.Key.ToString
            AlarmType = str.Substring(0, str.IndexOf(":"))
            If AlarmType = cmbx.SelectedValue Then
                If CInt(KeyList.Value) >= 0 Then
                    clbDescription.SetItemChecked(CInt(KeyList.Value), True)
                Else
                    AlarmCode = str.Substring(str.IndexOf(":") + 1, str.Length - str.IndexOf(":") - 1)
                    Dim i As Integer
                    Dim drv As DataRowView
                    For i = 0 To clbDescription.Items.Count - 1
                        drv = CType(clbDescription.Items(i), DataRowView)
                        If AlarmCode = drv("alarm_code").ToString Then
                            clbDescription.SetItemChecked(i, True)
                            'htfSelected.Item(KeyList.Key) = i
                            Exit For
                        End If
                    Next
                End If
            End If
        End While
        clbDescription.Tag = "true"
    End Sub

    Private Sub clbDescription_ItemCheck(ByVal sender As Object, ByVal e As ItemCheckEventArgs)
        If clbDescription.Tag.ToString = "false" Then Return

        If e.NewValue = CheckState.Checked Then
            Dim dr As DataRow = dsRecord.Tables("guarantee_check_alarm").NewRow
            With dr
                .Item("project_code") = ProjectCode
                .Item("serial_num") = SerialNum
                .Item("alarm_type") = cmbxAlarmGrade.SelectedValue
                .Item("alarm") = clbDescription.SelectedValue
            End With
            dsRecord.Tables("guarantee_check_alarm").Rows.Add(dr)
            htfSelected.Item(cmbxAlarmGrade.SelectedValue.ToString & ":" & clbDescription.SelectedValue.ToString) = e.Index
        Else
            dsRecord.Tables("guarantee_check_alarm").Select("serial_num=" & SerialNum & " AND alarm_type='" & cmbxAlarmGrade.SelectedValue & "' AND alarm='" & clbDescription.SelectedValue & "'")(0).Delete()
            htfSelected.Remove(cmbxAlarmGrade.SelectedValue.ToString & ":" & clbDescription.SelectedValue.ToString)
        End If
        DataChanged = True
        HistoryAlarm(SerialNum) = Nothing
    End Sub

    Private Sub frmTraceInfo_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            ProjectCode = MyBase.getProjectCode
            WorkFlowID = MyBase.getWorkFlowID
            TaskID = MyBase.getTaskID()
            phase = MyBase.getPhase(ProjectCode)
            SystemDate = gWs.GetSysTime
            dtpCheckDate.Value = SystemDate.Date
            FormatBasicInfo()
            LoadData()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub CopyValueToDataRow(ByVal dr As DataRow)
        dr("check_date") = dtpCheckDate.Value.Date.ToString("yyyy-MM-dd")
        dr("finacial_report_month") = txtYearMonth.Text
        dr("contact_person") = txtContactMan.Text
        dr("contact_phone") = txtPhone.Text
        dr("explanation") = txtContent.Text
    End Sub
    Private IsWrong As Boolean = False
    Private Sub SaveEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        IsWrong = True
        If txtYearMonth.Text = String.Empty Then
            SWDialogBox.MessageBox.Show("$1001", "所依据的财务报表年月")
            txtYearMonth.Focus()
            Return
        End If
        Dim drs() As DataRow = dsRecord.Tables("guarantee_check_record").Select("serial_num=" & SerialNum)
        If drs.Length > 0 Then
            CopyValueToDataRow(drs(0))
        Else
            Dim dr As DataRow = dsRecord.Tables("guarantee_check_record").NewRow
            With dr
                .Item("project_code") = ProjectCode
                .Item("serial_num") = SerialNum
                .Item("status") = False
                .Item("phase") = phase
                .Item("create_person") = UserName
                .Item("create_date") = SystemDate
            End With
            CopyValueToDataRow(dr)
            dsRecord.Tables("guarantee_check_record").Rows.Add(dr)
        End If

        Dim result As String
        result = gWs.UpdateCheckRecordAlarm(dsRecord.GetChanges)
        IsWrong = result <> "1"
        If Not IsWrong Then
            dsRecord.AcceptChanges()
            DataChanged = False
            btnDocument.Enabled = True
            If sender Is Nothing Then Return
            SWDialogBox.MessageBox.Show("$SaveSucceed")
        Else
            SWDialogBox.MessageBox.Show("*999", "保存失败", result, "")
        End If
    End Sub

    Private Sub CommitEvent(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交") 'MessageBox.Show("确定提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If
        Dim drs() As DataRow = dsRecord.Tables("guarantee_check_record").Select("serial_num=" & SerialNum)
        If DataChanged Or drs.Length = 0 Then
            SaveEvent(Nothing, Nothing)
            If IsWrong Then Return
        End If
        '''''''''必须确保保后检查记录表已录入''''''''''''''''
        '2008-5-28 yjf edit 上传保后检查记录表时更新保后检查记录的文档关联编号
        Dim strSql As String = "{project_code='" & Me.getProjectCode & "' and serial_num=" & SerialNum & "}"
        dsRecord = gWs.GetCheckRecordInfo(strSql, "")
        If IsDBNull(dsRecord.Tables("guarantee_check_record").Select("serial_num=" & SerialNum)(0)("file_relation_num")) Then
            SWDialogBox.MessageBox.Show("$X043")
            'MessageBox.Show("请先制作并上载保后检查记录表，再提交", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
        ''''''''''''''''''''''''''''''''''''''''''''''''''''
        Dim result As String = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, "", UserName)
        If result = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            'MessageBox.Show("提交成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            With dsRecord.Tables("guarantee_check_record").Select("serial_num=" & SerialNum)(0)
                If Not CBool(.Item("status")) Then
                    .Item("status") = True
                    If gWs.UpdateCheckRecordAlarm(dsRecord.GetChanges) <> "1" Then
                        SWDialogBox.MessageBox.Show("*999", "记录状态保存出错", "", "")
                        'MessageBox.Show("记录状态保存出错", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            End With
            MyBase.raiseCommitSucceed()
            RemoveHandler MyBase.Closing, AddressOf frmTraceInfo_Closing
            Me.Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "提交失败", result, "")
            'MessageBox.Show("提交失败" & vbCr & result, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        ConfirmClose(sender, e)
    End Sub
    Private Function ConfirmClose(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        If DataChanged Then
            Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003") 'MessageBox.Show("数据已修改，是否保存？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If QueryResult = DialogResult.Yes Then
                SaveEvent(Nothing, Nothing)
                If IsWrong Then Return False
            ElseIf QueryResult = DialogResult.Cancel Then
                Return False
            End If
        End If
        RemoveHandler MyBase.Closing, AddressOf frmTraceInfo_Closing
        Close()
        Return True
    End Function
    Private Sub frmTraceInfo_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, e)
    End Sub
    'historyalarm
    Private Sub CM_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If cmRecord.Position < 0 Then Return
        Dim selectSN As Int32 = CInt(CType(cmRecord.Current, DataRowView)("serial_num"))
        Dim result As String = String.Empty
        If Not HistoryAlarm(selectSN) Is Nothing Then
            result = HistoryAlarm(selectSN)
        Else
            Dim strRowFilter As String = "serial_num=" & selectSN.ToString
            Dim dv As DataView = New DataView(dsRecord.Tables("guarantee_check_alarm"), strRowFilter, "serial_num", DataViewRowState.CurrentRows)
            Dim drv As DataRowView
            For Each drv In dv
                result += dsAlarmDetail.Tables(0).Select("alarm_type='" & drv("alarm_type").ToString & "' AND alarm_code='" & drv("alarm").ToString & "'")(0)("alarm_name") & "   "
            Next
            HistoryAlarm(selectSN) = result
        End If

        txtHistoryAlarm.Text = result
    End Sub
    Private Sub AddTableStyleOfHistory()
        dgRecord.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.AllowSorting = False
        dgts.MappingName = "guarantee_check_record"
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "serial_num"
        col1.HeaderText = "检查次数"
        col1.Width = 55
        col1.Alignment = HorizontalAlignment.Center
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.MappingName = "check_date"
        col2.HeaderText = "检查日期"
        col2.Width = 70
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.MappingName = "finacial_report_month"
        col3.HeaderText = "依据的财务报表年月"
        col3.Width = 90
        col3.NullText = ""
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.MappingName = "contact_person"
        col4.HeaderText = "贷款银行联系人"
        col4.NullText = ""
        col4.Width = 80
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "contact_phone"
        col5.HeaderText = "联系人电话"
        col5.NullText = ""
        col5.Width = 80
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col6.MappingName = "explanation"
        col6.HeaderText = "情况说明"
        col6.NullText = ""
        col6.Width = 300
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col4, col5, col6})
        dgRecord.TableStyles.Add(dgts)
    End Sub

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsAlarmDetail Is Nothing Then
            dsAlarmDetail.Dispose()
        End If
        If Not dsAlarmType Is Nothing Then
            dsAlarmType.Dispose()
        End If
        If Not dsCorCount Is Nothing Then
            dsCorCount.Dispose()
        End If
        If Not dsRecord Is Nothing Then
            dsRecord.Dispose()
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Protected WithEvents txtCorName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMoney As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBank As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMA As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMB As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dgRecord As System.Windows.Forms.DataGrid
    Friend WithEvents ttHelp As System.Windows.Forms.ToolTip
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtBigBank As System.Windows.Forms.TextBox
    Friend WithEvents txtBargainNum As System.Windows.Forms.TextBox
    Friend WithEvents txtHistoryAlarm As System.Windows.Forms.TextBox
    Protected WithEvents clbDescription As System.Windows.Forms.CheckedListBox
    Protected WithEvents txtContactMan As System.Windows.Forms.TextBox
    Protected WithEvents txtPhone As System.Windows.Forms.TextBox
    Protected WithEvents dtpCheckDate As System.Windows.Forms.DateTimePicker
    Protected WithEvents btnSave As System.Windows.Forms.Button
    Protected WithEvents btnFinance As System.Windows.Forms.Button
    Protected WithEvents btnDocument As System.Windows.Forms.Button
    Protected WithEvents txtYearMonth As System.Windows.Forms.TextBox
    Protected WithEvents cmbxAlarmGrade As System.Windows.Forms.ComboBox
    Protected WithEvents txtContent As System.Windows.Forms.TextBox
    Protected WithEvents gpxInputInfo As System.Windows.Forms.GroupBox
    Protected WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Protected WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Protected WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btnDetailInfo As System.Windows.Forms.Button
    Friend WithEvents cmuFinance As System.Windows.Forms.ContextMenu
    Friend WithEvents mitemImport As System.Windows.Forms.MenuItem
    Friend WithEvents mitemWrite As System.Windows.Forms.MenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTraceInfo))
        Me.gpxInputInfo = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtContent = New System.Windows.Forms.TextBox
        Me.cmbxAlarmGrade = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtYearMonth = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtpCheckDate = New System.Windows.Forms.DateTimePicker
        Me.Label14 = New System.Windows.Forms.Label
        Me.clbDescription = New System.Windows.Forms.CheckedListBox
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.txtContactMan = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtBargainNum = New System.Windows.Forms.TextBox
        Me.txtBigBank = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtMB = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtProjectCode = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtMoney = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtBank = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtMA = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtTerm = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCorName = New System.Windows.Forms.TextBox
        Me.btnCommit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnFinance = New System.Windows.Forms.Button
        Me.btnDocument = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgRecord = New System.Windows.Forms.DataGrid
        Me.ttHelp = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtHistoryAlarm = New System.Windows.Forms.TextBox
        Me.btnDetailInfo = New System.Windows.Forms.Button
        Me.cmuFinance = New System.Windows.Forms.ContextMenu
        Me.mitemImport = New System.Windows.Forms.MenuItem
        Me.mitemWrite = New System.Windows.Forms.MenuItem
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.gpxInputInfo.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgRecord, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(610, 488)
        Me.btnExit.TabIndex = 11
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.Images.SetKeyName(0, "")
        Me.ImageListBasic.Images.SetKeyName(1, "")
        Me.ImageListBasic.Images.SetKeyName(2, "")
        Me.ImageListBasic.Images.SetKeyName(3, "")
        Me.ImageListBasic.Images.SetKeyName(4, "")
        Me.ImageListBasic.Images.SetKeyName(5, "")
        Me.ImageListBasic.Images.SetKeyName(6, "")
        Me.ImageListBasic.Images.SetKeyName(7, "")
        Me.ImageListBasic.Images.SetKeyName(8, "")
        Me.ImageListBasic.Images.SetKeyName(9, "")
        Me.ImageListBasic.Images.SetKeyName(10, "")
        Me.ImageListBasic.Images.SetKeyName(11, "")
        Me.ImageListBasic.Images.SetKeyName(12, "")
        Me.ImageListBasic.Images.SetKeyName(13, "")
        Me.ImageListBasic.Images.SetKeyName(14, "")
        Me.ImageListBasic.Images.SetKeyName(15, "")
        Me.ImageListBasic.Images.SetKeyName(16, "")
        Me.ImageListBasic.Images.SetKeyName(17, "")
        Me.ImageListBasic.Images.SetKeyName(18, "")
        Me.ImageListBasic.Images.SetKeyName(19, "")
        Me.ImageListBasic.Images.SetKeyName(20, "")
        Me.ImageListBasic.Images.SetKeyName(21, "")
        Me.ImageListBasic.Images.SetKeyName(22, "")
        Me.ImageListBasic.Images.SetKeyName(23, "")
        Me.ImageListBasic.Images.SetKeyName(24, "")
        Me.ImageListBasic.Images.SetKeyName(25, "")
        '
        'gpxInputInfo
        '
        Me.gpxInputInfo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gpxInputInfo.Controls.Add(Me.Label2)
        Me.gpxInputInfo.Controls.Add(Me.txtContent)
        Me.gpxInputInfo.Controls.Add(Me.cmbxAlarmGrade)
        Me.gpxInputInfo.Controls.Add(Me.Label16)
        Me.gpxInputInfo.Controls.Add(Me.txtYearMonth)
        Me.gpxInputInfo.Controls.Add(Me.Label1)
        Me.gpxInputInfo.Controls.Add(Me.dtpCheckDate)
        Me.gpxInputInfo.Controls.Add(Me.Label14)
        Me.gpxInputInfo.Controls.Add(Me.clbDescription)
        Me.gpxInputInfo.Controls.Add(Me.txtPhone)
        Me.gpxInputInfo.Controls.Add(Me.txtContactMan)
        Me.gpxInputInfo.Controls.Add(Me.Label4)
        Me.gpxInputInfo.Controls.Add(Me.Label3)
        Me.gpxInputInfo.Location = New System.Drawing.Point(8, 312)
        Me.gpxInputInfo.Name = "gpxInputInfo"
        Me.gpxInputInfo.Size = New System.Drawing.Size(746, 168)
        Me.gpxInputInfo.TabIndex = 1
        Me.gpxInputInfo.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 12)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "情况说明"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContent
        '
        Me.txtContent.Location = New System.Drawing.Point(72, 40)
        Me.txtContent.MaxLength = 250
        Me.txtContent.Multiline = True
        Me.txtContent.Name = "txtContent"
        Me.txtContent.Size = New System.Drawing.Size(664, 48)
        Me.txtContent.TabIndex = 4
        '
        'cmbxAlarmGrade
        '
        Me.cmbxAlarmGrade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbxAlarmGrade.Location = New System.Drawing.Point(72, 96)
        Me.cmbxAlarmGrade.Name = "cmbxAlarmGrade"
        Me.cmbxAlarmGrade.Size = New System.Drawing.Size(104, 20)
        Me.cmbxAlarmGrade.TabIndex = 5
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 99)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(53, 12)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "预警等级"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtYearMonth
        '
        Me.txtYearMonth.Location = New System.Drawing.Point(312, 11)
        Me.txtYearMonth.MaxLength = 6
        Me.txtYearMonth.Name = "txtYearMonth"
        Me.txtYearMonth.Size = New System.Drawing.Size(48, 21)
        Me.txtYearMonth.TabIndex = 1
        Me.ttHelp.SetToolTip(Me.txtYearMonth, "格式为yyyyMM")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(192, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 12)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "依据的财务报表年月"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpCheckDate
        '
        Me.dtpCheckDate.Location = New System.Drawing.Point(72, 11)
        Me.dtpCheckDate.Name = "dtpCheckDate"
        Me.dtpCheckDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpCheckDate.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(53, 12)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "检查日期"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'clbDescription
        '
        Me.clbDescription.CheckOnClick = True
        Me.clbDescription.ColumnWidth = 250
        Me.clbDescription.Location = New System.Drawing.Point(184, 96)
        Me.clbDescription.MultiColumn = True
        Me.clbDescription.Name = "clbDescription"
        Me.clbDescription.Size = New System.Drawing.Size(552, 68)
        Me.clbDescription.TabIndex = 6
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(632, 11)
        Me.txtPhone.MaxLength = 15
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(104, 21)
        Me.txtPhone.TabIndex = 3
        '
        'txtContactMan
        '
        Me.txtContactMan.Location = New System.Drawing.Point(464, 11)
        Me.txtContactMan.MaxLength = 10
        Me.txtContactMan.Name = "txtContactMan"
        Me.txtContactMan.Size = New System.Drawing.Size(88, 21)
        Me.txtContactMan.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(560, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 12)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "联系人电话"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(368, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 12)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "贷款银行联系人"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txtBargainNum)
        Me.GroupBox4.Controls.Add(Me.txtBigBank)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.txtMB)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtProjectCode)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txtMoney)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.txtBank)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtMA)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.txtTerm)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.txtCorName)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(746, 96)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        '
        'txtBargainNum
        '
        Me.txtBargainNum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBargainNum.Location = New System.Drawing.Point(88, 40)
        Me.txtBargainNum.Name = "txtBargainNum"
        Me.txtBargainNum.ReadOnly = True
        Me.txtBargainNum.Size = New System.Drawing.Size(72, 21)
        Me.txtBargainNum.TabIndex = 40
        '
        'txtBigBank
        '
        Me.txtBigBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBigBank.Location = New System.Drawing.Point(256, 40)
        Me.txtBigBank.Name = "txtBigBank"
        Me.txtBigBank.ReadOnly = True
        Me.txtBigBank.Size = New System.Drawing.Size(184, 21)
        Me.txtBigBank.TabIndex = 39
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(472, 43)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(53, 12)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "支    行"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(8, 43)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 12)
        Me.Label15.TabIndex = 36
        Me.Label15.Text = "合  同  号 "
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMB
        '
        Me.txtMB.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMB.Location = New System.Drawing.Point(256, 69)
        Me.txtMB.Name = "txtMB"
        Me.txtMB.ReadOnly = True
        Me.txtMB.Size = New System.Drawing.Size(72, 21)
        Me.txtMB.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(176, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(71, 12)
        Me.Label12.TabIndex = 34
        Me.Label12.Text = "项目经理B角"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 12)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "项 目 编 码"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(88, 14)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(72, 21)
        Me.txtProjectCode.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(584, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(29, 12)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "万元"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMoney
        '
        Me.txtMoney.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMoney.Location = New System.Drawing.Point(528, 69)
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.ReadOnly = True
        Me.txtMoney.Size = New System.Drawing.Size(56, 21)
        Me.txtMoney.TabIndex = 29
        Me.txtMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(472, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "贷款金额"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBank
        '
        Me.txtBank.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBank.Location = New System.Drawing.Point(528, 40)
        Me.txtBank.Name = "txtBank"
        Me.txtBank.ReadOnly = True
        Me.txtBank.Size = New System.Drawing.Size(200, 21)
        Me.txtBank.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(176, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 12)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "贷 款 银 行"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMA
        '
        Me.txtMA.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMA.Location = New System.Drawing.Point(88, 69)
        Me.txtMA.Name = "txtMA"
        Me.txtMA.ReadOnly = True
        Me.txtMA.Size = New System.Drawing.Size(72, 21)
        Me.txtMA.TabIndex = 25
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 72)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 12)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "项目经理A角"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(616, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 12)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "期限"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTerm
        '
        Me.txtTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerm.Location = New System.Drawing.Point(648, 69)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.ReadOnly = True
        Me.txtTerm.Size = New System.Drawing.Size(32, 21)
        Me.txtTerm.TabIndex = 28
        Me.txtTerm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(680, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 12)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "月"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(176, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 12)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "企 业 名 称"
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(256, 14)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(184, 21)
        Me.txtCorName.TabIndex = 33
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(526, 488)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(75, 23)
        Me.btnCommit.TabIndex = 10
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(338, 488)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnFinance
        '
        Me.btnFinance.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnFinance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFinance.ImageIndex = 25
        Me.btnFinance.ImageList = Me.ImageListBasic
        Me.btnFinance.Location = New System.Drawing.Point(233, 488)
        Me.btnFinance.Name = "btnFinance"
        Me.btnFinance.Size = New System.Drawing.Size(96, 23)
        Me.btnFinance.TabIndex = 8
        Me.btnFinance.Text = "财务数据(&F)"
        Me.btnFinance.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDocument
        '
        Me.btnDocument.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDocument.Enabled = False
        Me.btnDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocument.ImageIndex = 18
        Me.btnDocument.ImageList = Me.ImageListBasic
        Me.btnDocument.Location = New System.Drawing.Point(424, 488)
        Me.btnDocument.Name = "btnDocument"
        Me.btnDocument.Size = New System.Drawing.Size(93, 23)
        Me.btnDocument.TabIndex = 7
        Me.btnDocument.Text = "制作报表(&D)"
        Me.btnDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgRecord)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 96)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(746, 152)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        '
        'dgRecord
        '
        Me.dgRecord.CaptionVisible = False
        Me.dgRecord.DataMember = ""
        Me.dgRecord.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgRecord.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgRecord.Location = New System.Drawing.Point(3, 17)
        Me.dgRecord.Name = "dgRecord"
        Me.dgRecord.ReadOnly = True
        Me.dgRecord.Size = New System.Drawing.Size(740, 132)
        Me.dgRecord.TabIndex = 11
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.txtHistoryAlarm)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 248)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(744, 64)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "历史预警等级内容"
        '
        'txtHistoryAlarm
        '
        Me.txtHistoryAlarm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtHistoryAlarm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtHistoryAlarm.Location = New System.Drawing.Point(3, 17)
        Me.txtHistoryAlarm.Multiline = True
        Me.txtHistoryAlarm.Name = "txtHistoryAlarm"
        Me.txtHistoryAlarm.ReadOnly = True
        Me.txtHistoryAlarm.Size = New System.Drawing.Size(738, 44)
        Me.txtHistoryAlarm.TabIndex = 0
        '
        'btnDetailInfo
        '
        Me.btnDetailInfo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDetailInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDetailInfo.ImageIndex = 3
        Me.btnDetailInfo.ImageList = Me.ImageListBasic
        Me.btnDetailInfo.Location = New System.Drawing.Point(104, 488)
        Me.btnDetailInfo.Name = "btnDetailInfo"
        Me.btnDetailInfo.Size = New System.Drawing.Size(120, 23)
        Me.btnDetailInfo.TabIndex = 41
        Me.btnDetailInfo.Text = "项目详细信息(&L)"
        Me.btnDetailInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmuFinance
        '
        Me.cmuFinance.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mitemImport, Me.mitemWrite})
        '
        'mitemImport
        '
        Me.mitemImport.Index = 0
        Me.mitemImport.Text = "导    入"
        '
        'mitemWrite
        '
        Me.mitemWrite.Index = 1
        Me.mitemWrite.Text = "录    入"
        '
        'frmTraceInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(762, 519)
        Me.Controls.Add(Me.btnDetailInfo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnDocument)
        Me.Controls.Add(Me.btnFinance)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.gpxInputInfo)
        Me.Name = "frmTraceInfo"
        Me.Text = "登记保后检查记录表"
        Me.Controls.SetChildIndex(Me.gpxInputInfo, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnFinance, 0)
        Me.Controls.SetChildIndex(Me.btnDocument, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.btnDetailInfo, 0)
        Me.gpxInputInfo.ResumeLayout(False)
        Me.gpxInputInfo.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgRecord, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmTraceInfo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        MyBase.setEnterKeyPress(sender, e)
    End Sub

    Private Sub txtYearMonth_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtYearMonth.KeyPress
        If Not (IsNumeric(e.KeyChar) Or e.KeyChar = ChrW(8)) Then
            e.Handled = True
        End If
    End Sub

    Private Sub obj_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContent.Enter, txtYearMonth.Enter, dtpCheckDate.Enter, txtPhone.Enter, txtContactMan.Enter
        SetObjTag(sender)
    End Sub
    Private Sub obj_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContent.Leave, txtYearMonth.Leave, dtpCheckDate.Leave, txtPhone.Leave, txtContactMan.Leave
        DataChanged = IsChanged(sender)
    End Sub

    Private Function TextIsDigit(ByVal text As String) As Boolean
        If text = String.Empty Then
            Return False
        End If
        Dim i As Int32
        For i = 0 To text.Length - 1
            If Not Char.IsDigit(text.Chars(i)) Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub txt_leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtYearMonth.Leave
        Dim text As String = txtYearMonth.Text
        If Not TextIsDigit(text) Then
            txtYearMonth.Text = String.Empty
            Return
        End If
        If text.Length <= 4 Then
            txtYearMonth.Text = String.Empty
        Else
            If CInt(text.Substring(0, 4)) < 1990 Then
                txtYearMonth.Text = "1990" & text.Substring(4)
            End If
            If text.Length = 5 Then
                txtYearMonth.Text = text.Substring(0, 4) & "0" & text.Substring(4, 1)
                Return
            End If
            If text.Length = 6 Then
                If CInt(text.Substring(4, 2)) > 12 Then
                    txtYearMonth.Text = text.Substring(0, 4) & "12"
                End If
            End If
        End If
    End Sub
    ''''''''''''''''这里处理从文档管理页面退出时，当前页面获得焦点的事件''''''''''''''''''''
    Private Sub frmTraceInfo_Activated(ByVal sender As Object, ByVal e As EventArgs)
        '2008-5-28 yjf edit 上传保后检查记录表时更新保后检查记录的文档关联编号
        'RemoveHandler MyBase.Activated, AddressOf frmTraceInfo_Activated
        'Dim obj As Object = ofrmDoc.getUploadSucceed
        'If Not IsNothing(obj) Then
        '    dsRecord.Tables("guarantee_check_record").Select("serial_num=" & SerialNum)(0)("file_relation_num") = MyIIf(obj, GetType(Long), DBNull.Value)
        '    If dsRecord.HasChanges Then
        '        Dim result As String = gWs.UpdateCheckRecordAlarm(dsRecord.GetChanges)
        '        If result <> "1" Then
        '            SWDialogBox.MessageBox.Show("*999", "保存文档号出错", result, "")
        '            'MessageBox.Show("保存文档号出错" & vbCr & result, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '        Else
        '            dsRecord.AcceptChanges()
        '        End If
        '    End If
        'End If
    End Sub

    '财务数据
    Private Sub btnFinance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinance.Click
        Me.cmuFinance.Show(btnFinance, New Point(0, btnFinance.Height))
    End Sub

    Private ofrmDoc As frmDocumentManageBusiness
    '文档管理
    Private Sub btnDocument_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDocument.Click
        Dim eachDr As DataRow
        For Each eachDr In dsRecord.Tables("guarantee_check_record").Rows
            If IsDBNull(eachDr("finacial_report_month")) Then
                SWDialogBox.MessageBox.Show("$1001", "制表年月")
                txtYearMonth.Focus()
                Return
            End If
        Next
        Try
            dsCorCount = gWs.FetchCorporationAccount("{phase <> '初审' AND corporation_code LIKE '" & CorCode & "' AND project_code LIKE '" & ProjectCode & "'}")
            If dsCorCount.Tables.Count = 0 OrElse dsCorCount.Tables(0).Select("month LIKE '" & txtYearMonth.Text.Trim & "'").Length = 0 Then
                SWDialogBox.MessageBox.Show("$X044", txtYearMonth.Text) '请先录入制表年月(" & txtYearMonth.Text & ")的财务数据"
                Return
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        Try
            Me.Cursor = Cursors.WaitCursor
            If htfAccount Is Nothing Then
                htfAccount = New Hashtable
                'htfAccount.Item("&#Bargain") = txtBargainNum.Text
                htfAccount.Item("&#MA") = txtMA.Text
                htfAccount.Item("&#MB") = txtMB.Text
                htfAccount.Item("&#Corp") = txtCorName.Text
                'htfAccount.Item("&#Bank") = txtBigBank.Text & txtBank.Text
                'htfAccount.Item("&#Guaransum") = IIf(txtMoney.Text = "", "0", txtMoney.Text) & "万元"
                'htfAccount.Item("&#Term") = IIf(txtTerm.Text = "", "0", txtTerm.Text) & "月"
            End If
            Dim dr As DataRow = dsRecord.Tables("guarantee_check_record").Select("serial_num=" & SerialNum)(0)
            htfAccount.Item("&#Date") = DateTime.Parse(dr("check_date")).ToString("yyyy-MM-dd")
            htfAccount.Item("&#YearMonth") = dr("finacial_report_month") & ""
            htfAccount.Item("&#People") = dr("contact_person") '& "：" & dr("contact_phone") & ""
            htfAccount.Item("&#Content") = dr("explanation") & ""

            '在保余额
            'htfAccount.Item("&#Remain") = String.Empty
            'Dim dsFee As DataSet = gWs.GetCommonQueryInfo("SELECT guaranting_sum FROM dbo.ViewProjectInfo_Guaranting WHERE ProjectCode='" & ProjectCode & "'")
            'If dsFee.Tables(0).Rows.Count > 0 Then
            '    htfAccount.Item("&#Remain") = IIf(IsDBNull(dsFee.Tables(0).Rows(0)(0)), "", dsFee.Tables(0).Rows(0)(0) & "元")
            'End If
            'dsFee.Dispose()

            '一级预警，二级预警，三级预警
            Dim strOne, strTwo, strThree As String
            For Each dr In dsRecord.Tables("guarantee_check_alarm").Select("serial_num=" & SerialNum & " AND alarm_type='1'")
                If strOne Is Nothing Then
                    strOne = dsAlarmDetail.Tables(0).Select("alarm_type='1' AND alarm_code='" & dr("alarm") & "'")(0)("alarm_name")
                Else
                    strOne += "  " & dsAlarmDetail.Tables(0).Select("alarm_type='1' AND alarm_code='" & dr("alarm") & "'")(0)("alarm_name")
                End If
            Next
            htfAccount.Item("&#OneAlarm") = IIf(strOne = "", "无", strOne & "")
            For Each dr In dsRecord.Tables("guarantee_check_alarm").Select("serial_num=" & SerialNum & " AND alarm_type='2'")
                If strTwo Is Nothing Then
                    strTwo = dsAlarmDetail.Tables(0).Select("alarm_type='2' AND alarm_code='" & dr("alarm") & "'")(0)("alarm_name")
                Else
                    strTwo += "  " & dsAlarmDetail.Tables(0).Select("alarm_type='2' AND alarm_code='" & dr("alarm") & "'")(0)("alarm_name")
                End If
            Next
            htfAccount.Item("&#TwoAlarm") = IIf(strTwo = "", "无", strTwo & "")
            For Each dr In dsRecord.Tables("guarantee_check_alarm").Select("serial_num=" & SerialNum & " AND alarm_type='3'")
                If strThree Is Nothing Then
                    strThree = dsAlarmDetail.Tables(0).Select("alarm_type='3' AND alarm_code='" & dr("alarm") & "'")(0)("alarm_name")
                Else
                    strThree += "  " & dsAlarmDetail.Tables(0).Select("alarm_type='3' AND alarm_code='" & dr("alarm") & "'")(0)("alarm_name")
                End If
            Next
            htfAccount.Item("&#ThreeAlarm") = IIf(strThree = "", "无", strThree & "")
            GetFinanceDataBeforeVouch()
            GetFinanceData()
            CaculateBalance()
            ''''''''生成参数调用其它页面'''''''''''''
            Dim key() As String
            Dim value As ArrayList = New ArrayList
            Dim i As Integer = 0
            ReDim key(htfAccount.Count - 1)
            Dim ItemList As IDictionaryEnumerator = htfAccount.GetEnumerator
            While ItemList.MoveNext
                key(i) = ItemList.Key
                value.Add(ItemList.Value)
                i += 1
            End While

            Try
                ofrmDoc = New frmDocumentManageBusiness(ProjectCode, TaskID, txtCorName.Text, "45", "003", UserName, key, value)
                ofrmDoc.AllowTransparency = False
                AddHandler MyBase.Activated, AddressOf frmTraceInfo_Activated
                ofrmDoc.ShowDialog()
            Catch ex As Exception
                RemoveHandler MyBase.Activated, AddressOf frmTraceInfo_Activated
                ExceptionHandler.ShowMessageBox(ex)
                'MessageBox.Show("生成文档发生错误" & vbCr & ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '以下全属于obj()
    '                                    item_type       item_code            index  代码标记名       Excel标识
    '货币资金-------------------------------01              a01                 0
    '应收    -----------------------------------            sum(a03:a09)        1
    '存货-----------------------------------01              a10                 2
    '待摊费用-------------------------------01              a11                 3
    '长期投资-------------------------------01              a17                 4
    '固定资产净值---------------------------01              a22                 5
    '总资产---------------------------------01              a34                 6
    '短期、长期借款-------------------------01              a35 + a50           7
    '应付-----------------------------------                Sum(a36:a44)-a42    8
    '应交税金-------------------------------                a42                 9
    '实收资本-------------------------------01              a58                 10
    '资本公积-------------------------------01--------------a59                 11
    '留存利益(未分配利润、盈余公积)---------01--------------a60 + a62           12
    '负债和所有者权益-----------------------01              a66                 13
    '销售收入-------------------------------02              b01                 14
    '成本税金-------------------------------                b02+b03             15
    '期间费用-------------------------------                b06+b07+b08         16
    '投资收益-------------------------------02              b10                 17
    '所得税---------------------------------                b15                 18
    '净利润---------------------------------02              b18                 19

    Private obj() As Double = New Double() {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    ''获得贷前财务数据 所依据的财务报表的month(申请年月的前一个月)
    'Private Sub GetFinanceDataBeforeVouch()
    '    Dim bYM As String = String.Format("{0:yyyyMM}", ApplyDate.AddMonths(-12))
    '    Dim ds As DataSet = New DataSet
    '    Dim i, k As Integer
    '    '表示申请年月的前一月没记录
    '    If dsCorCount.Tables("TCorporationAccount").Select("month LIKE '" & bYM & "'").Length = 0 Then
    '        Dim drs() As DataRow = dsCorCount.Tables("TCorporationAccount").Select("phase= '评审'", "month DESC")
    '        If drs.Length = 0 Then '评审阶段（即贷前）没有录入财务数据
    '            For i = 0 To obj.Length - 1
    '                htfAccount.Item("&#0:" & i) = String.Empty
    '            Next
    '            htfAccount.Item("&#0YM") = String.Empty
    '            Return
    '        End If
    '        bYM = drs(0)("month").ToString
    '    End If
    '    htfAccount.Item("&#0YM") = bYM
    '    ds.Merge(dsCorCount.Tables("TCorporationAccount").Select("month LIKE '" & bYM & "'"))
    '    If ds.Tables.Count > 0 Then
    '        GiveValueToArray(ds)
    '        For i = 0 To obj.Length - 1
    '            htfAccount.Item("&#0:" & i) = obj(i).ToString
    '        Next
    '    Else
    '        For i = 0 To obj.Length - 1
    '            htfAccount.Item("&#0:" & i) = String.Empty
    '        Next
    '    End If
    '    ds.Dispose()
    'End Sub

    '2013-04-23 获得贷前财务数据 所依据的财务报表的month的去年同期的财务数据
    Private Sub GetFinanceDataBeforeVouch()
        Dim bYM As String = (CInt(txtYearMonth.Text.Substring(0, 4)) - 1).ToString() + txtYearMonth.Text.Substring(4, 2)
        Dim ds As DataSet = New DataSet
        Dim i, k As Integer
        '获取去年同期财务数据

        Dim dsLastYearYM As DataSet = gWs.FetchCorporationAccount("{corporation_code LIKE '" & CorCode & "' AND project_code LIKE '" & ProjectCode & "' and month LIKE '" & bYM & "'}")
       
        htfAccount.Item("&#0YM") = bYM

        If dsLastYearYM.Tables.Count > 0 Then
            GiveValueToArray(dsLastYearYM)
            For i = 0 To obj.Length - 1
                htfAccount.Item("&#0:" & i) = obj(i).ToString
            Next
        Else
            For i = 0 To obj.Length - 1
                htfAccount.Item("&#0:" & i) = String.Empty
            Next
        End If
        dsLastYearYM.Dispose()
    End Sub
    ''获得当前SerialNum及之前的财务数据
    'Private Sub GetFinanceData()
    '    Dim ds As DataSet
    '    Dim dr As DataRow
    '    Dim EachSN As Integer = 0 '第几次检查
    '    Dim EachYM As String '每个制表年月
    '    Dim EachPA As String '每次录入保后检查记录表的阶段
    '    Dim i As Integer
    '    For Each dr In dsRecord.Tables("guarantee_check_record").Rows
    '        EachSN = CInt(dr("serial_num"))
    '        EachYM = CStr(dr("finacial_report_month")).Trim
    '        EachPA = dr("phase") & ""
    '        htfAccount.Item("&#" & EachSN.ToString & "YM") = EachYM
    '        ds = New DataSet
    '        ds.Merge(dsCorCount.Tables("TCorporationAccount").Select("month='" & EachYM & "' AND (phase='" & EachPA & "' OR phase IS NULL)"))
    '        If ds.Tables.Count > 0 Then
    '            GiveValueToArray(ds)
    '            For i = 0 To obj.Length - 1
    '                htfAccount.Item("&#" & EachSN & ":" & i) = obj(i).ToString
    '            Next
    '        Else
    '            For i = 0 To obj.Length - 1
    '                htfAccount.Item("&#" & EachSN & ":" & i) = String.Empty
    '            Next
    '        End If
    '        ds.Dispose()
    '    Next
    '    Dim k As Integer
    '    'For i = EachSN + 1 To 6
    '    '2009-09-15 yjf add 增加 第七次检查记录
    '    For i = EachSN + 1 To 7
    '        htfAccount.Item("&#" & i & "YM") = String.Empty
    '        For k = 0 To obj.Length - 1
    '            htfAccount.Item("&#" & i & ":" & k) = String.Empty
    '        Next
    '    Next
    'End Sub

    '2013-04-23 获得当前SerialNum(本次保后检查)的财务数据 
    Private Sub GetFinanceData()
        Dim ds As DataSet
        Dim dr As DataRow
        Dim EachSN As Integer = 0 '第几次检查
        Dim EachYM As String '每个制表年月
        Dim EachPA As String '每次录入保后检查记录表的阶段
        Dim i As Integer
        For Each dr In dsRecord.Tables("guarantee_check_record").Select("serial_num=" & SerialNum)
            EachSN = 1
            EachYM = CStr(dr("finacial_report_month")).Trim
            EachPA = dr("phase") & ""
            htfAccount.Item("&#" & EachSN.ToString & "YM") = EachYM
            ds = New DataSet
            ds.Merge(dsCorCount.Tables("TCorporationAccount").Select("month='" & EachYM & "' AND (phase='" & EachPA & "' OR phase IS NULL)"))
            If ds.Tables.Count > 0 Then
                GiveValueToArray(ds)
                For i = 0 To obj.Length - 1
                    htfAccount.Item("&#" & EachSN & ":" & i) = obj(i).ToString
                Next
            Else
                For i = 0 To obj.Length - 1
                    htfAccount.Item("&#" & EachSN & ":" & i) = String.Empty
                Next
            End If
            ds.Dispose()
        Next

    End Sub

    Private Sub GiveValueToArray(ByVal ds As DataSet)
        Dim odr As DataRow
        Dim drs() As DataRow
        Dim denominator As Double = 10000 '分母

        '货币资金
        obj(0) = 0
        drs = ds.Tables(0).Select("item_type='01' AND item_code = 'a01'")
        If drs.Length > 0 Then
            obj(0) = CDbl(drs(0)("value") + "0") / denominator
        End If
        '应收
        Dim tempSum As Double = 0
        For Each odr In ds.Tables(0).Select("item_type='01' AND item_code >='a03' AND item_code <='a09'")
            tempSum += CDbl(odr("value") + "0") / denominator
        Next
        obj(1) = tempSum
        '存货
        obj(2) = 0
        drs = ds.Tables(0).Select("item_type='01' AND item_code = 'a10'")
        If drs.Length > 0 Then
            obj(2) = CDbl(drs(0)("value") + "0") / denominator
        End If
        '待摊费用
        obj(3) = 0
        drs = ds.Tables(0).Select("item_type='01' AND item_code = 'a11'")
        If drs.Length > 0 Then
            obj(3) = CDbl(drs(0)("value") + "0") / denominator
        End If
        '长期投资
        obj(4) = 0
        drs = ds.Tables(0).Select("item_type='01' AND item_code = 'a17'")
        If drs.Length > 0 Then
            obj(4) = CDbl(drs(0)("value") + "0") / denominator
        End If
        '固定资产净值
        obj(5) = 0
        drs = ds.Tables(0).Select("item_type='01' AND item_code = 'a22'")
        If drs.Length > 0 Then
            obj(5) = CDbl(drs(0)("value") + "0") / denominator
        End If
        '总资产
        obj(6) = 0
        drs = ds.Tables(0).Select("item_type='01' AND item_code = 'a34'")
        If drs.Length > 0 Then
            obj(6) = CDbl(drs(0)("value") + "0") / denominator
        End If

        '短期、长期借款
        tempSum = 0
        For Each odr In ds.Tables(0).Select("item_type='01' AND item_code IN ('a35','a50')")
            tempSum += CDbl(odr("value") + "0") / denominator
        Next
        obj(7) = tempSum

        '应交税金   a42
        obj(9) = 0
        drs = ds.Tables(0).Select("item_type='01' AND item_code = 'a42'")
        If drs.Length > 0 Then
            obj(9) = CDbl(drs(0)("value") + "0") / denominator
        End If

        '应付  Sum(a36:a44)-a42
        tempSum = 0
        For Each odr In ds.Tables(0).Select("item_type='01' AND item_code >='a36' AND item_code <='a44'")
            tempSum += CDbl(odr("value") + "0") / denominator
        Next
        obj(8) = tempSum - obj(9)

        '实收资本
        obj(10) = 0
        drs = ds.Tables(0).Select("item_type='01' AND item_code = 'a58'")
        If drs.Length > 0 Then
            obj(10) = CDbl(drs(0)("value") + "0") / denominator
        End If

        '资本公积
        obj(11) = 0
        drs = ds.Tables(0).Select("item_type='01' AND item_code = 'a59'")
        If drs.Length > 0 Then
            obj(11) = CDbl(drs(0)("value") + "0") / denominator
        End If

        '留存利益
        tempSum = 0
        For Each odr In ds.Tables(0).Select("item_type='01' AND item_code IN ('a60','a62')")
            tempSum += CDbl(odr("value") + "0") / denominator
        Next
        obj(12) = tempSum

        '负债和所有者权益
        obj(13) = 0
        drs = ds.Tables(0).Select("item_type='01' AND item_code = 'a66'")
        If drs.Length > 0 Then
            obj(13) = CDbl(drs(0)("value") + "0") / denominator
        End If

        '销售收入
        obj(14) = 0
        drs = ds.Tables(0).Select("item_type='02' AND item_code = 'b01'")
        If drs.Length > 0 Then
            obj(14) = CDbl(drs(0)("value") + "0") / denominator
        End If

        '成本税金-------------------------------                b02+b03 
        tempSum = 0
        For Each odr In ds.Tables(0).Select("item_type='02' AND item_code IN ('b02','b03')")
            tempSum += CDbl(odr("value") + "0") / denominator
        Next
        obj(15) = tempSum

        '期间费用-------------------------------                b06+b07+b08
        tempSum = 0
        For Each odr In ds.Tables(0).Select("item_type='02' AND item_code IN ('b06','b07','b08')")
            tempSum += CDbl(odr("value") + "0") / denominator
        Next
        obj(16) = tempSum

        '投资收益
        obj(17) = 0
        drs = ds.Tables(0).Select("item_type='02' AND item_code = 'b10'")
        If drs.Length > 0 Then
            obj(17) = CDbl(drs(0)("value") + "0") / denominator
        End If

        '所得税---------------------------------                b15  
        obj(18) = 0
        drs = ds.Tables(0).Select("item_type='02' AND item_code = 'b15'")
        If drs.Length > 0 Then
            obj(18) = CDbl(drs(0)("value") + "0") / denominator
        End If

        '净利润
        obj(19) = 0
        drs = ds.Tables(0).Select("item_type='02' AND item_code = 'b18'")
        If drs.Length > 0 Then
            obj(19) = CDbl(drs(0)("value") + "0") / denominator
        End If
    End Sub

    'Private Sub CaculateBalance()
    '    '&#M1:0
    '    Dim i, k As Integer
    '    Dim strForward, strBack As Object
    '    '2009-09-15 yjf add 增加 第七次检查记录
    '    For i = 1 To 7
    '        For k = 0 To obj.Length - 1
    '            strForward = htfAccount.Item("&#" & (i - 1).ToString & ":" & k)
    '            If IsDBNull(strForward) OrElse strForward.ToString = String.Empty Then '分母为空
    '                htfAccount.Item("&#" & i & "-" & (i - 1).ToString & ":" & k) = ""
    '            Else
    '                strBack = htfAccount.Item("&#" & i & ":" & k)
    '                If IsDBNull(strBack) OrElse strBack.ToString = String.Empty Then '分子为空
    '                    htfAccount.Item("&#" & i & "-" & (i - 1).ToString & ":" & k) = ""
    '                ElseIf CDbl(strForward) = 0 Then '分母为零
    '                    htfAccount.Item("&#" & i & "-" & (i - 1).ToString & ":" & k) = "/"
    '                Else '分子分母皆不为空且分母并不为零
    '                    htfAccount.Item("&#" & i & "-" & (i - 1).ToString & ":" & k) = ((CDbl(strBack) - CDbl(strForward)) * 100 / CDbl(strForward)).ToString & "%"
    '                End If
    '            End If
    '        Next
    '    Next
    'End Sub

    '2013-04-23 yjf add 只计算本期与去年同期对比
    Private Sub CaculateBalance()
        '&#M1:0
        Dim i, k As Integer
        Dim strForward, strBack As Object
        '2009-09-15 yjf add 增加 第七次检查记录
        For i = 1 To 1
            For k = 0 To obj.Length - 1
                strForward = htfAccount.Item("&#" & (i - 1).ToString & ":" & k)
                If IsDBNull(strForward) OrElse strForward.ToString = String.Empty Then '分母为空
                    htfAccount.Item("&#" & i & "-" & (i - 1).ToString & ":" & k) = ""
                Else
                    strBack = htfAccount.Item("&#" & i & ":" & k)
                    If IsDBNull(strBack) OrElse strBack.ToString = String.Empty Then '分子为空
                        htfAccount.Item("&#" & i & "-" & (i - 1).ToString & ":" & k) = ""
                    ElseIf CDbl(strForward) = 0 Then '分母为零
                        htfAccount.Item("&#" & i & "-" & (i - 1).ToString & ":" & k) = "/"
                    Else '分子分母皆不为空且分母并不为零
                        htfAccount.Item("&#" & i & "-" & (i - 1).ToString & ":" & k) = ((CDbl(strBack) - CDbl(strForward)) * 100 / CDbl(strForward)).ToString & "%"
                    End If
                End If
            Next
        Next
    End Sub

    '导入历史财务数据
    '修改记录：FCopyGuaranteeCheckRecord增加一个构造参数，同项目，同阶段的财务数据不予显示
    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitemImport.Click
        Dim frm As New FCopyGuaranteeCheckRecord(Me.CorCode, ProjectCode)
        frm.StartPosition = FormStartPosition.CenterScreen
        frm.ShowDialog()
        Dim OldProjectCode, OldMonth, OldPhase As String
        OldProjectCode = frm.ProjectCode
        OldMonth = frm.Month
        OldPhase = frm.Phase
        If OldProjectCode = "" Or OldMonth = "" Or OldPhase = "" Then
            Return
        End If
        If OldMonth <> txtYearMonth.Text Then
            SWDialogBox.MessageBox.Show("$1003", "导入财务数据的年月", "导入财务数据的年月应等于所依据的财务报表年月", "")
            Return
        End If
        '阶段为在保，年月不能为空
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor

            If SWDialogBox.MessageBox.Show("!1002") = MsgBoxResult.No Then
                Return
            End If

            If gWs.ImportFinanceData(Me.CorCode, OldProjectCode, OldPhase, OldMonth, Me.CorCode, ProjectCode, phase, UserName, gWs.GetSysTime(), True) <> "1" Then
                Return
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
        SWDialogBox.MessageBox.Show("$OperateSucceed")
    End Sub
    '录入财务数据
    Private Sub WriteFinanceData(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mitemWrite.Click
        Dim ofrm As frmFinanceManage = New frmFinanceManage(ProjectCode, txtCorName.Text, CorCode, phase, Me)
        ofrm.StartPosition = FormStartPosition.CenterScreen
        'ofrmFinanceManage.LookOnly = True
        ofrm.AllowTransparency = False
        ofrm.ShowDialog()
    End Sub
    Private Function ImportFinanceData() As Boolean

    End Function
    '查看项目详细信息
    Private Sub btnDetailInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetailInfo.Click
        Dim ofrmShowProjectInfo As frmShowProjectInfo = New frmShowProjectInfo(txtProjectCode.Text.Trim, txtCorName.Text.Trim)
        ofrmShowProjectInfo.ShowDialog()
    End Sub

    'Private Sub importSpecialData(ByVal rang As Excel.Range)
    '    Dim ds As DataSet
    '    Dim dr As DataRow
    '    Dim i As Integer
    '    Dim count As Integer
    '    Try
    '        ds = gWs.FQueryCreditProject(ProjectCode.Substring(0, 5), "", "", "", "", "", "")
    '        If Not ds Is Nothing Then
    '            Dim d1, d2 As Double
    '            d1 = 0 : d2 = 0
    '            For Each dr In ds.Tables(0).Rows
    '                d1 += CDbl(IIf(IsDBNull(dr("sum")), 0, dr("sum")))
    '                d2 += CDbl(IIf(IsDBNull(dr("surplus_total")), 0, dr("surplus_total")))
    '            Next
    '            '增加合计记录
    '            dr = ds.Tables(0).NewRow
    '            dr("service_type") = "合计"
    '            dr("sum") = d1
    '            dr("surplus_total") = d2
    '            ds.Tables(0).Rows.Add(dr)

    '            count = ds.Tables(0).Rows.Count
    '            For i = 0 To count - 1
    '                dr = ds.Tables(0).Rows(i)
    '                rang.Item(34 + i, 2) = dr("service_type") & String.Empty
    '                rang.Item(34 + i, 3) = dr("sum") & String.Empty
    '                rang.Item(34 + i, 4) = dr("terms") & String.Empty
    '                rang.Item(34 + i, 5) = dr("end_date") & String.Empty
    '                rang.Item(34 + i, 6) = dr("surplus_total") & String.Empty
    '                rang.Item(34 + i, 7) = dr("bank") & String.Empty
    '                rang.Item(34 + i, 8) = dr("branch_bank") & String.Empty
    '                rang.Item(34 + i, 9) = String.Empty
    '            Next
    '            ds.Dispose()
    '        End If
    '    Catch ex As Exception
    '        ExceptionHandler.ShowMessageBox(ex)
    '    End Try
    'End Sub
End Class
