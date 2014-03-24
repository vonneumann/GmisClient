Public Class FUpdateMeetRecordApply
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
    Protected WithEvents txtCorName As System.Windows.Forms.TextBox
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents txtUpdateReason As System.Windows.Forms.TextBox
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents grdReason As System.Windows.Forms.DataGrid
    Friend WithEvents styleReason As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col_reason As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_conclusion As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col_date As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FUpdateMeetRecordApply))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.grdReason = New System.Windows.Forms.DataGrid()
        Me.styleReason = New System.Windows.Forms.DataGridTableStyle()
        Me.col_reason = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col_conclusion = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtUpdateReason = New System.Windows.Forms.TextBox()
        Me.btnCommit = New System.Windows.Forms.Button()
        CType(Me.grdReason, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(273, 328)
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(160, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "企业名称"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "项目编码"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(224, 8)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(232, 21)
        Me.txtCorName.TabIndex = 45
        Me.txtCorName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(64, 8)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(80, 21)
        Me.txtProjectCode.TabIndex = 44
        Me.txtProjectCode.Text = ""
        '
        'grdReason
        '
        Me.grdReason.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grdReason.CaptionVisible = False
        Me.grdReason.DataMember = ""
        Me.grdReason.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdReason.Location = New System.Drawing.Point(8, 40)
        Me.grdReason.Name = "grdReason"
        Me.grdReason.Size = New System.Drawing.Size(520, 168)
        Me.grdReason.TabIndex = 0
        Me.grdReason.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.styleReason})
        '
        'styleReason
        '
        Me.styleReason.DataGrid = Me.grdReason
        Me.styleReason.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col_reason, Me.col_conclusion, Me.col_date})
        Me.styleReason.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.styleReason.MappingName = "TProjectOpinion"
        '
        'col_reason
        '
        Me.col_reason.Format = ""
        Me.col_reason.FormatInfo = Nothing
        Me.col_reason.HeaderText = "修改事由"
        Me.col_reason.MappingName = "content"
        Me.col_reason.NullText = ""
        Me.col_reason.Width = 250
        '
        'col_conclusion
        '
        Me.col_conclusion.Format = ""
        Me.col_conclusion.FormatInfo = Nothing
        Me.col_conclusion.HeaderText = "审核结论"
        Me.col_conclusion.MappingName = "conclusion"
        Me.col_conclusion.NullText = ""
        Me.col_conclusion.ReadOnly = True
        Me.col_conclusion.Width = 90
        '
        'col_date
        '
        Me.col_date.Format = "yyyy年M月d日"
        Me.col_date.FormatInfo = Nothing
        Me.col_date.HeaderText = "申请日期"
        Me.col_date.MappingName = "create_date"
        Me.col_date.NullText = ""
        Me.col_date.ReadOnly = True
        Me.col_date.Width = 85
        '
        'txtUpdateReason
        '
        Me.txtUpdateReason.Location = New System.Drawing.Point(8, 216)
        Me.txtUpdateReason.MaxLength = 1000
        Me.txtUpdateReason.Multiline = True
        Me.txtUpdateReason.Name = "txtUpdateReason"
        Me.txtUpdateReason.Size = New System.Drawing.Size(520, 100)
        Me.txtUpdateReason.TabIndex = 0
        Me.txtUpdateReason.Text = ""
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(185, 328)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 47
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FUpdateMeetRecordApply
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(538, 359)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label5, Me.Label6, Me.btnExit, Me.btnCommit, Me.txtCorName, Me.txtProjectCode, Me.txtUpdateReason, Me.grdReason})
        Me.Name = "FUpdateMeetRecordApply"
        Me.Text = "修改评审会结论申请"
        CType(Me.grdReason, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ProjectCode, CorporationName, WorkFlowID, TaskID As String
    Private Const ItemType As String = "52"
    Private Const ItemCode As String = "010"
    Private _dsReason As DataSet

    Private Sub FUpdateMeetRecordApply_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            ProjectCode = MyBase.getProjectCode
            CorporationName = MyBase.getCorporationName
            WorkFlowID = MyBase.getWorkFlowID
            TaskID = MyBase.getTaskID
            txtProjectCode.Text = ProjectCode : txtCorName.Text = CorporationName

            Dim strSql As String = "{project_code='" & ProjectCode & "' AND item_type='" & ItemType & "' AND item_code='" & ItemCode & "' ORDER BY serial_num}"
            _dsReason = gWs.GetProjectOpinionByProjectNo(strSql)
            grdReason.SetDataBinding(_dsReason, "TProjectOpinion")
            Dim j As Int32 = _dsReason.Tables("TProjectOpinion").Rows.Count
            If j = 0 OrElse (Not _dsReason.Tables("TProjectOpinion").Rows(j - 1).IsNull("status")) Then
                Dim row As DataRow = _dsReason.Tables("TProjectOpinion").NewRow
                row("project_code") = ProjectCode
                row("item_type") = ItemType
                row("item_code") = ItemCode
                row("create_person") = UserName
                row("create_date") = gWs.GetSysTime
                _dsReason.Tables("TProjectOpinion").Rows.Add(row)
            End If

            Dim cm As CurrencyManager = CType(Me.BindingContext(_dsReason, "TProjectOpinion"), CurrencyManager)
            CType(cm.List, DataView).AllowDelete = False
            CType(cm.List, DataView).AllowNew = False

            txtUpdateReason.DataBindings.Add("Text", _dsReason, "TProjectOpinion.content")
            AddHandler cm.PositionChanged, AddressOf PositionChanged
            PositionChanged(cm, EventArgs.Empty)
            col_reason.TextBox.MaxLength = txtUpdateReason.MaxLength
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
        txtUpdateReason.ReadOnly = col_reason.ReadOnly
    End Sub

    Private Function Save() As Boolean
        Me.BindingContext(_dsReason, "TProjectOpinion").EndCurrentEdit()
        'Dim hasNew As Boolean = _dsReason.HasChanges(DataRowState.Added)
        Dim result As String = gWs.UpdateProjectOpinion(_dsReason.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存失败", result, "")
            Return False
            'Else
            '    If hasNew Then
            '        Dim strSql As String = "SELECT MAX(serial_num) AS a FROM project_opinion WHERE project_code='" & _
            '                                ProjectCode & "' AND item_type='" & ItemType & "' AND item_code='" & ItemCode & "'"
            '        Dim dsTemp As DataSet = gWs.GetCommonQueryInfo(strSql)
            '        Dim j As Int32 = _dsReason.Tables("TProjectOpinion").Rows.Count
            '        _dsReason.Tables("TProjectOpinion").Rows(j - 1)("serial_num") = dsTemp.Tables(0).Rows(0)(0)
            '        dsTemp.AcceptChanges()
            '    End If
        End If
        _dsReason.AcceptChanges()
        Return True
    End Function

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        '2009-09-11 yjf add 检查是否填写意见，如没有禁止提交
        If txtUpdateReason.Text.Trim = "" Then
            MessageBox.Show("请填写修改意见!", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交")
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If

        If Not Save() Then
            Return
        End If

        Dim result As String = gWs.CreateProcess("修改评审会结论", ProjectCode, UserName, String.Empty)
        If result = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            MyBase.raiseCommitSucceed()
            Me.Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "提交失败", result, "")
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class
