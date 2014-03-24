Public Class FCheckMeetRecordUpdate
    Inherits frmMeetingRecord

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsOpinion Is Nothing Then
            dsOpinion.Dispose()
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
    Friend WithEvents txtCheckOpinion As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents tpApplyUpdate As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboCheckConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents grdCheckOpinion As System.Windows.Forms.DataGrid
    Friend WithEvents grdReason As System.Windows.Forms.DataGrid
    Friend WithEvents style_Reason As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_reason As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_conclusion As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_person As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents style_Check As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_check As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents check_conclusion As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FCheckMeetRecordUpdate))
        Me.tpApplyUpdate = New System.Windows.Forms.TabPage
        Me.txtReason = New System.Windows.Forms.TextBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.grdCheckOpinion = New System.Windows.Forms.DataGrid
        Me.style_Check = New System.Windows.Forms.DataGridTableStyle
        Me.col_check = New System.Windows.Forms.DataGridTextBoxColumn
        Me.check_conclusion = New System.Windows.Forms.DataGridTextBoxColumn
        Me.cboCheckConclusion = New System.Windows.Forms.ComboBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.grdReason = New System.Windows.Forms.DataGrid
        Me.style_Reason = New System.Windows.Forms.DataGridTableStyle
        Me.col_reason = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_conclusion = New System.Windows.Forms.DataGridTextBoxColumn
        Me.col_person = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.txtCheckOpinion = New System.Windows.Forms.TextBox
        Me.TabControl.SuspendLayout()
        Me.tpApplyUpdate.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.grdCheckOpinion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.grdReason, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDetailInfo
        '
        Me.btnDetailInfo.Image = CType(resources.GetObject("btnDetailInfo.Image"), System.Drawing.Image)
        Me.btnDetailInfo.ImageIndex = -1
        Me.btnDetailInfo.ImageList = Nothing
        Me.btnDetailInfo.Location = New System.Drawing.Point(245, 504)
        Me.btnDetailInfo.Name = "btnDetailInfo"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageIndex = -1
        Me.btnSave.ImageList = Nothing
        Me.btnSave.Location = New System.Drawing.Point(256, 504)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 0)
        Me.btnSave.Text = "保 存(&S)"
        '
        'btnCommit
        '
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Image)
        Me.btnCommit.ImageIndex = -1
        Me.btnCommit.ImageList = Nothing
        Me.btnCommit.Location = New System.Drawing.Point(468, 504)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.Text = "提 交(&C)"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Name = "txtProjectCode"
        '
        'btnSupplyOppGua
        '
        Me.btnSupplyOppGua.Image = CType(resources.GetObject("btnSupplyOppGua.Image"), System.Drawing.Image)
        Me.btnSupplyOppGua.ImageIndex = -1
        Me.btnSupplyOppGua.ImageList = Nothing
        Me.btnSupplyOppGua.Location = New System.Drawing.Point(104, 504)
        Me.btnSupplyOppGua.Name = "btnSupplyOppGua"
        '
        'btnPrintReport
        '
        Me.btnPrintReport.Image = CType(resources.GetObject("btnPrintReport.Image"), System.Drawing.Image)
        Me.btnPrintReport.ImageIndex = -1
        Me.btnPrintReport.ImageList = Nothing
        Me.btnPrintReport.Location = New System.Drawing.Point(351, 504)
        Me.btnPrintReport.Name = "btnPrintReport"
        '
        'txtCorName
        '
        Me.txtCorName.Name = "txtCorName"
        '
        'btnJoinReport
        '
        Me.btnJoinReport.Location = New System.Drawing.Point(392, 504)
        Me.btnJoinReport.Name = "btnJoinReport"
        Me.btnJoinReport.Size = New System.Drawing.Size(96, 0)
        Me.btnJoinReport.Visible = True
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.tpApplyUpdate)
        Me.TabControl.ItemSize = New System.Drawing.Size(60, 17)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.Controls.SetChildIndex(Me.tpApplyUpdate, 0)
        '
        'btnSplitProject
        '
        Me.btnSplitProject.Image = CType(resources.GetObject("btnSplitProject.Image"), System.Drawing.Image)
        Me.btnSplitProject.ImageIndex = -1
        Me.btnSplitProject.ImageList = Nothing
        Me.btnSplitProject.Location = New System.Drawing.Point(410, 538)
        Me.btnSplitProject.Name = "btnSplitProject"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(558, 504)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.Text = "退 出(&X)"
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'tpApplyUpdate
        '
        Me.tpApplyUpdate.Controls.Add(Me.txtReason)
        Me.tpApplyUpdate.Controls.Add(Me.GroupBox6)
        Me.tpApplyUpdate.Controls.Add(Me.cboCheckConclusion)
        Me.tpApplyUpdate.Controls.Add(Me.Label22)
        Me.tpApplyUpdate.Controls.Add(Me.GroupBox5)
        Me.tpApplyUpdate.Controls.Add(Me.txtCheckOpinion)
        Me.tpApplyUpdate.Location = New System.Drawing.Point(4, 21)
        Me.tpApplyUpdate.Name = "tpApplyUpdate"
        Me.tpApplyUpdate.Size = New System.Drawing.Size(632, 439)
        Me.tpApplyUpdate.TabIndex = 6
        Me.tpApplyUpdate.Text = "申请事项"
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(11, 120)
        Me.txtReason.MaxLength = 1000
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.ReadOnly = True
        Me.txtReason.Size = New System.Drawing.Size(610, 88)
        Me.txtReason.TabIndex = 4
        Me.txtReason.Text = ""
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.grdCheckOpinion)
        Me.GroupBox6.Location = New System.Drawing.Point(8, 216)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(616, 80)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "确认意见"
        '
        'grdCheckOpinion
        '
        Me.grdCheckOpinion.CaptionVisible = False
        Me.grdCheckOpinion.DataMember = ""
        Me.grdCheckOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdCheckOpinion.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdCheckOpinion.Location = New System.Drawing.Point(3, 17)
        Me.grdCheckOpinion.Name = "grdCheckOpinion"
        Me.grdCheckOpinion.Size = New System.Drawing.Size(610, 60)
        Me.grdCheckOpinion.TabIndex = 0
        Me.grdCheckOpinion.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.style_Check})
        '
        'style_Check
        '
        Me.style_Check.DataGrid = Me.grdCheckOpinion
        Me.style_Check.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_check, Me.check_conclusion})
        Me.style_Check.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.style_Check.MappingName = "TProjectOpinion"
        '
        'col_check
        '
        Me.col_check.Format = ""
        Me.col_check.FormatInfo = Nothing
        Me.col_check.HeaderText = "审核意见"
        Me.col_check.MappingName = "content"
        Me.col_check.NullText = ""
        Me.col_check.Width = 300
        '
        'check_conclusion
        '
        Me.check_conclusion.Format = ""
        Me.check_conclusion.FormatInfo = Nothing
        Me.check_conclusion.HeaderText = "审核结论"
        Me.check_conclusion.MappingName = "conclusion"
        Me.check_conclusion.NullText = ""
        Me.check_conclusion.ReadOnly = True
        Me.check_conclusion.Width = 85
        '
        'cboCheckConclusion
        '
        Me.cboCheckConclusion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCheckConclusion.Location = New System.Drawing.Point(96, 392)
        Me.cboCheckConclusion.Name = "cboCheckConclusion"
        Me.cboCheckConclusion.Size = New System.Drawing.Size(168, 20)
        Me.cboCheckConclusion.TabIndex = 1
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(16, 392)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(66, 17)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "结      论"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.grdReason)
        Me.GroupBox5.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(616, 104)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "更改事由"
        '
        'grdReason
        '
        Me.grdReason.CaptionVisible = False
        Me.grdReason.DataMember = ""
        Me.grdReason.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdReason.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdReason.Location = New System.Drawing.Point(3, 17)
        Me.grdReason.Name = "grdReason"
        Me.grdReason.ReadOnly = True
        Me.grdReason.Size = New System.Drawing.Size(610, 84)
        Me.grdReason.TabIndex = 1
        Me.grdReason.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.style_Reason})
        '
        'style_Reason
        '
        Me.style_Reason.DataGrid = Me.grdReason
        Me.style_Reason.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_reason, Me.col_conclusion, Me.col_person, Me.DataGridTextBoxColumn1})
        Me.style_Reason.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.style_Reason.MappingName = "TProjectOpinion"
        '
        'col_reason
        '
        Me.col_reason.Format = ""
        Me.col_reason.FormatInfo = Nothing
        Me.col_reason.HeaderText = "理由"
        Me.col_reason.MappingName = "content"
        Me.col_reason.NullText = ""
        Me.col_reason.Width = 300
        '
        'col_conclusion
        '
        Me.col_conclusion.Format = ""
        Me.col_conclusion.FormatInfo = Nothing
        Me.col_conclusion.HeaderText = "审核结论"
        Me.col_conclusion.MappingName = "conclusion"
        Me.col_conclusion.NullText = ""
        Me.col_conclusion.Width = 85
        '
        'col_person
        '
        Me.col_person.Format = ""
        Me.col_person.FormatInfo = Nothing
        Me.col_person.HeaderText = "申请人"
        Me.col_person.MappingName = "create_person"
        Me.col_person.NullText = ""
        Me.col_person.Width = 75
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "申请日期"
        Me.DataGridTextBoxColumn1.MappingName = "create_date"
        Me.DataGridTextBoxColumn1.NullText = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn1.Width = 80
        '
        'txtCheckOpinion
        '
        Me.txtCheckOpinion.Location = New System.Drawing.Point(8, 304)
        Me.txtCheckOpinion.MaxLength = 1000
        Me.txtCheckOpinion.Multiline = True
        Me.txtCheckOpinion.Name = "txtCheckOpinion"
        Me.txtCheckOpinion.Size = New System.Drawing.Size(610, 72)
        Me.txtCheckOpinion.TabIndex = 0
        Me.txtCheckOpinion.Text = ""
        '
        'FCheckMeetRecordUpdate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(658, 535)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "FCheckMeetRecordUpdate"
        Me.Text = "确认修改评审会结论"
        Me.TabControl.ResumeLayout(False)
        Me.tpApplyUpdate.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.grdCheckOpinion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.grdReason, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Const ApplyItemType As String = "52"
    Private Const ApplyItemCode As String = "010"
    Private Const CheckItemType As String = "52"
    Private Const CheckItemCode As String = "011"
    Private dsReason, dsOpinion As DataSet

    Private Sub FCheckMeetRecordUpdate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor

            MyBase.ReadOnly = True

            Dim dsCheckConclusion As DataSet = gWs.GetTransCondition(MyBase.WorkFlowID, MyBase.ProjectCode, MyBase.TaskID)
            cboCheckConclusion.DataSource = dsCheckConclusion.Tables(0)
            cboCheckConclusion.DisplayMember = "transfer_condition"
            cboCheckConclusion.ValueMember = "transfer_condition"

            Dim strSql As String = "{{project_code='{0}' AND item_type='{1}' AND item_code='{2}' ORDER BY serial_num}}"

            dsReason = gWs.GetProjectOpinionByProjectNo(String.Format(strSql, MyBase.ProjectCode, ApplyItemType, ApplyItemCode))

            '申请更改事由
            grdReason.SetDataBinding(dsReason, "TProjectOpinion")

            '确认意见
            dsOpinion = gWs.GetProjectOpinionByProjectNo(String.Format(strSql, ProjectCode, CheckItemType, CheckItemCode))
            grdCheckOpinion.SetDataBinding(dsOpinion, "TProjectOpinion")

            If dsReason.Tables(0).Rows.Count <> dsOpinion.Tables(0).Rows.Count Then
                Dim row As DataRow = dsOpinion.Tables("TProjectOpinion").NewRow
                row("project_code") = MyBase.getProjectCode
                row("item_type") = CheckItemType
                row("item_code") = CheckItemCode
                row("create_person") = UserName
                row("create_date") = gWs.GetSysTime
                dsOpinion.Tables("TProjectOpinion").Rows.Add(row)
            End If

            Dim cm As CurrencyManager = CType(Me.BindingContext(dsOpinion, "TProjectOpinion"), CurrencyManager)
            CType(cm.List, DataView).AllowDelete = False
            CType(cm.List, DataView).AllowNew = False

            txtReason.DataBindings.Add("Text", dsReason, "TProjectOpinion.content")

            txtCheckOpinion.DataBindings.Add("Text", dsOpinion, "TProjectOpinion.content")
            cboCheckConclusion.DataBindings.Add("SelectedValue", dsOpinion, "TProjectOpinion.conclusion")
            AddHandler cm.PositionChanged, AddressOf PositionChanged
            PositionChanged(cm, EventArgs.Empty)
            col_check.TextBox.MaxLength = txtCheckOpinion.MaxLength
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If CType(sender, CurrencyManager).Position < 0 Then
            Return
        End If
        col_reason.ReadOnly = Not IsDBNull(CType(CType(sender, CurrencyManager).Current, DataRowView)("status"))
        txtCheckOpinion.ReadOnly = col_check.ReadOnly
        cboCheckConclusion.Enabled = Not txtCheckOpinion.ReadOnly
    End Sub

    Private Function IsInfoEffective() As Boolean
        If cboCheckConclusion.SelectedItem Is Nothing Then
            SWDialogBox.MessageBox.Show("$1001", "确认意见")
            If Not MyBase.TabControl.SelectedTab Is tpApplyUpdate Then
                MyBase.TabControl.SelectedTab = tpApplyUpdate
            End If
            cboCheckConclusion.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function Save() As Boolean
        Dim j As Int32 = dsReason.Tables("TProjectOpinion").Rows.Count
        dsReason.Tables("TProjectOpinion").Rows(j - 1)("status") = "1"
        Dim result As String = gWs.UpdateProjectOpinion(dsReason.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存失败", result, "")
            Return False
        End If

        dsOpinion.Tables("TProjectOpinion").Rows(j - 1)("status") = "1"
        Me.BindingContext(dsOpinion, "TProjectOpinion").EndCurrentEdit()
        result = gWs.UpdateProjectOpinion(dsOpinion.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存失败", result, "")
            Return False
        End If

        Return True
    End Function

    Protected Overrides Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Not IsInfoEffective() Then
            Return
        End If
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交")
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If

        If Not Save() Then '插入意见
            Return
        End If

        Dim strResult As String = gWs.finishedTask(MyBase.WorkFlowID, ProjectCode, TaskID, cboCheckConclusion.SelectedValue, UserName)
        If strResult = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            RemoveHandler MyBase.Closing, AddressOf frmMeetingRecord_Closing
            MyBase.raiseCommitSucceed()
            Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "")
        End If
    End Sub


    'Private Sub grdReason_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdReason.CurrentCellChanged
    '    Dim iIndex As Integer = grdReason.CurrentRowIndex
    '    Dim strReason As String
    '    If iIndex > -1 Then
    '        strReason = grdReason.Item(iIndex, 0)
    '    End If
    '    txtReason.Text = strReason
    'End Sub
End Class
