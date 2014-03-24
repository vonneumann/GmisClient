Public Class FConfirmMeetRecord
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
    Friend WithEvents tpConfirmOpinion As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtConfirmOpinion As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cboConfirm As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgReasonAOpinion As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csReason As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csCheckOpinion As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csComfirm As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FConfirmMeetRecord))
        Me.tpConfirmOpinion = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgReasonAOpinion = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.csID = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csReason = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csCheckOpinion = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csComfirm = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cboConfirm = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtConfirmOpinion = New System.Windows.Forms.TextBox()
        Me.TabControl.SuspendLayout()
        Me.tpConfirmOpinion.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgReasonAOpinion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCorName
        '
        Me.txtCorName.Visible = True
        '
        'btnSplitProject
        '
        Me.btnSplitProject.Image = CType(resources.GetObject("btnSplitProject.Image"), System.Drawing.Bitmap)
        Me.btnSplitProject.ImageIndex = -1
        Me.btnSplitProject.ImageList = Nothing
        Me.btnSplitProject.Location = New System.Drawing.Point(312, 546)
        Me.btnSplitProject.Visible = True
        '
        'TabControl
        '
        Me.TabControl.Controls.AddRange(New System.Windows.Forms.Control() {Me.tpConfirmOpinion})
        Me.TabControl.ItemSize = New System.Drawing.Size(60, 17)
        Me.TabControl.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'btnJoinReport
        '
        Me.btnJoinReport.Location = New System.Drawing.Point(306, 504)
        Me.btnJoinReport.Size = New System.Drawing.Size(96, 0)
        Me.btnJoinReport.Visible = True
        '
        'btnPrintReport
        '
        Me.btnPrintReport.Image = CType(resources.GetObject("btnPrintReport.Image"), System.Drawing.Bitmap)
        Me.btnPrintReport.ImageIndex = -1
        Me.btnPrintReport.ImageList = Nothing
        Me.btnPrintReport.Location = New System.Drawing.Point(359, 504)
        Me.btnPrintReport.Visible = True
        '
        'btnSupplyOppGua
        '
        Me.btnSupplyOppGua.Image = CType(resources.GetObject("btnSupplyOppGua.Image"), System.Drawing.Bitmap)
        Me.btnSupplyOppGua.ImageIndex = -1
        Me.btnSupplyOppGua.ImageList = Nothing
        Me.btnSupplyOppGua.Location = New System.Drawing.Point(120, 504)
        Me.btnSupplyOppGua.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageIndex = -1
        Me.btnSave.ImageList = Nothing
        Me.btnSave.Location = New System.Drawing.Point(267, 504)
        Me.btnSave.Size = New System.Drawing.Size(77, 0)
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageIndex = -1
        Me.btnCommit.ImageList = Nothing
        Me.btnCommit.Location = New System.Drawing.Point(472, 504)
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.Visible = True
        '
        'btnDetailInfo
        '
        Me.btnDetailInfo.Image = CType(resources.GetObject("btnDetailInfo.Image"), System.Drawing.Bitmap)
        Me.btnDetailInfo.ImageIndex = -1
        Me.btnDetailInfo.ImageList = Nothing
        Me.btnDetailInfo.Location = New System.Drawing.Point(257, 504)
        Me.btnDetailInfo.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(558, 504)
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'tpConfirmOpinion
        '
        Me.tpConfirmOpinion.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox4, Me.cboConfirm, Me.Label22, Me.GroupBox7})
        Me.tpConfirmOpinion.Location = New System.Drawing.Point(4, 21)
        Me.tpConfirmOpinion.Name = "tpConfirmOpinion"
        Me.tpConfirmOpinion.Size = New System.Drawing.Size(632, 439)
        Me.tpConfirmOpinion.TabIndex = 6
        Me.tpConfirmOpinion.Text = "审核事项"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgReasonAOpinion})
        Me.GroupBox4.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(616, 208)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'dgReasonAOpinion
        '
        Me.dgReasonAOpinion.CaptionVisible = False
        Me.dgReasonAOpinion.DataMember = ""
        Me.dgReasonAOpinion.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgReasonAOpinion.Location = New System.Drawing.Point(8, 16)
        Me.dgReasonAOpinion.Name = "dgReasonAOpinion"
        Me.dgReasonAOpinion.ReadOnly = True
        Me.dgReasonAOpinion.Size = New System.Drawing.Size(600, 184)
        Me.dgReasonAOpinion.TabIndex = 0
        Me.dgReasonAOpinion.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgReasonAOpinion
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csID, Me.csReason, Me.csCheckOpinion, Me.csComfirm})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TProjectOpinion"
        '
        'csID
        '
        Me.csID.Format = ""
        Me.csID.FormatInfo = Nothing
        Me.csID.HeaderText = "序号"
        Me.csID.MappingName = "Number"
        Me.csID.NullText = ""
        Me.csID.Width = 60
        '
        'csReason
        '
        Me.csReason.Format = ""
        Me.csReason.FormatInfo = Nothing
        Me.csReason.HeaderText = "申请更改事由"
        Me.csReason.MappingName = "content"
        Me.csReason.NullText = ""
        Me.csReason.Width = 300
        '
        'csCheckOpinion
        '
        Me.csCheckOpinion.Format = ""
        Me.csCheckOpinion.FormatInfo = Nothing
        Me.csCheckOpinion.HeaderText = "确认意见"
        Me.csCheckOpinion.MappingName = "CheckOpinion"
        Me.csCheckOpinion.NullText = ""
        Me.csCheckOpinion.Width = 200
        '
        'csComfirm
        '
        Me.csComfirm.Format = ""
        Me.csComfirm.FormatInfo = Nothing
        Me.csComfirm.HeaderText = "审核意见"
        Me.csComfirm.MappingName = "ConfirmOpinion"
        Me.csComfirm.NullText = ""
        Me.csComfirm.Width = 200
        '
        'cboConfirm
        '
        Me.cboConfirm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboConfirm.Location = New System.Drawing.Point(88, 320)
        Me.cboConfirm.Name = "cboConfirm"
        Me.cboConfirm.Size = New System.Drawing.Size(136, 20)
        Me.cboConfirm.TabIndex = 4
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(16, 323)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 14)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "结     论"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtConfirmOpinion})
        Me.GroupBox7.Location = New System.Drawing.Point(8, 216)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(616, 100)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "审核意见"
        '
        'txtConfirmOpinion
        '
        Me.txtConfirmOpinion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtConfirmOpinion.Location = New System.Drawing.Point(3, 17)
        Me.txtConfirmOpinion.MaxLength = 1000
        Me.txtConfirmOpinion.Multiline = True
        Me.txtConfirmOpinion.Name = "txtConfirmOpinion"
        Me.txtConfirmOpinion.Size = New System.Drawing.Size(610, 80)
        Me.txtConfirmOpinion.TabIndex = 0
        Me.txtConfirmOpinion.Text = ""
        '
        'FConfirmMeetRecord
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(658, 535)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnSupplyOppGua, Me.btnExit, Me.btnSplitProject, Me.btnJoinReport, Me.btnDetailInfo, Me.btnSave, Me.btnPrintReport, Me.TabControl, Me.btnCommit, Me.txtProjectCode, Me.txtCorName})
        Me.Name = "FConfirmMeetRecord"
        Me.Text = "审核评审会结论"
        Me.TabControl.ResumeLayout(False)
        Me.tpConfirmOpinion.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgReasonAOpinion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Const ConfirmItemType As String = "52"
    Private Const ConfirmItemCode As String = "012"
    Private Const CheckItemType As String = "52"
    Private Const CheckItemCode As String = "011"
    Private Const ApplyItemType As String = "52"
    Private Const ApplyItemCode As String = "010"
    Private dsOpinion As DataSet

    Private Sub SetControlDisenabled()
        Dim tp As TabPage
        For Each tp In MyBase.TabControl.TabPages
            If tp Is tpOppGua Then
                tp.Enabled = False
            ElseIf Not tp Is tpConfirmOpinion Then
                SetControlDisenabled(tp)
            End If
        Next
    End Sub

    Private Sub SetControlDisenabled(ByVal parentContainer As Control)
        Dim obj As Control
        For Each obj In parentContainer.Controls
            If obj.Controls.Count > 0 Then
                SetControlDisenabled(obj)
                'ElseIf obj.GetType Is GetType(DataGrid) Then
                'ctype(me.BindingContext(ctype(obj,DataGrid).DataSource,ctyp
                'Dim colStyle As DataGridColumnStyle
                'For Each colStyle In CType(obj, DataGrid).TableStyles(0).GridColumnStyles
                '    colStyle.ReadOnly = True
                '    If colStyle.GetType Is GetType(DataGridComboBoxColumn) Then
                '        CType(colStyle, DataGridComboBoxColumn).ColumnComboBox.Enabled = False
                '    End If
                'Next
            ElseIf Not obj.GetType Is GetType(Label) Then
                obj.Enabled = False
            End If
        Next
    End Sub
    Private Sub FConfirmMeetRecord_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            SetControlDisenabled() '屏蔽各种输入框
            MyBase.btnSave.Enabled = False
            MyBase.btnSplitProject.Enabled = False
            Dim dsCheckConclusion As DataSet = gWs.GetTransCondition(MyBase.WorkFlowID, MyBase.ProjectCode, MyBase.TaskID)
            cboConfirm.DataSource = dsCheckConclusion.Tables(0)
            cboConfirm.DisplayMember = "transfer_condition"
            cboConfirm.ValueMember = "transfer_condition"
            dsCheckConclusion = Nothing

            '获取申请更改事项理由
            Dim strSql As String = "{{project_code='{0}' AND item_type='{1}' AND item_code='{2}'}}"
            Dim i As Integer
            Dim dstemp, dsTrail As DataSet
            dstemp = gWs.GetProjectOpinionByProjectNo(String.Format(strSql, MyBase.ProjectCode, CheckItemType, CheckItemCode))
            dsTrail = gWs.GetProjectOpinionByProjectNo(String.Format(strSql, MyBase.ProjectCode, CheckItemType, ConfirmItemCode))
            dsOpinion = gWs.GetProjectOpinionByProjectNo(String.Format(strSql, MyBase.ProjectCode, ApplyItemType, ApplyItemCode))
            dsOpinion.Tables("TProjectOpinion").Columns.Add(New DataColumn("Number", GetType(String)))
            dsOpinion.Tables("TProjectOpinion").Columns.Add(New DataColumn("CheckOpinion", GetType(String)))
            dsOpinion.Tables("TProjectOpinion").Columns.Add(New DataColumn("ConfirmOpinion", GetType(String)))
            If dsOpinion.Tables("TProjectOpinion").Rows.Count > 0 Then
                For i = 0 To dsOpinion.Tables("TProjectOpinion").Rows.Count - 1
                    With dsOpinion.Tables("TProjectOpinion").Rows(i)
                        .Item("Number")=i+1
                        .Item("CheckOpinion") = dstemp.Tables(0).Rows(i).Item("content") & String.Empty

                        If dsTrail.Tables(0).Rows.Count = 0 Then
                            .Item("ConfirmOpinion") = ""
                        Else
                            If dsTrail.Tables(0).Rows.Count = dsOpinion.Tables("TProjectOpinion").Rows.Count Then
                                .Item("ConfirmOpinion") = dsTrail.Tables(0).Rows(i).Item("content") & String.Empty
                            Else
                                If i > dsTrail.Tables(0).Rows.Count - 1 Then
                                    .Item("ConfirmOpinion") = ""
                                Else
                                    .Item("ConfirmOpinion") = dsTrail.Tables(0).Rows(i).Item("content") & String.Empty
                                End If
                            End If
                        End If
                    End With
                Next
            End If
            '申请更改事由
            Me.dgReasonAOpinion.SetDataBinding(dsOpinion, "TProjectOpinion")
            dsOpinion = gWs.GetProjectOpinionByProjectNo(String.Format(strSql, MyBase.ProjectCode, ConfirmItemType, ConfirmItemCode))
            If dsOpinion.Tables(0).Rows.Count > 0 Then
                txtConfirmOpinion.Text = dsOpinion.Tables(0).Rows(0)("content") & ""
                cboConfirm.SelectedValue = dsOpinion.Tables(0).Rows(0)("conclusion")
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function IsInfoEffective() As Boolean
        If cboConfirm.SelectedItem Is Nothing Then
            SWDialogBox.MessageBox.Show("$1001", "审核意见")
            If Not MyBase.TabControl.SelectedTab Is tpConfirmOpinion Then
                MyBase.TabControl.SelectedTab = tpConfirmOpinion
            End If
            cboConfirm.Focus()
            Return False
        End If
        Return True
    End Function

    Private Function InsertAnOpition() As Boolean
        Dim hasNew As Boolean = False
        If dsOpinion.Tables(0).Rows.Count = 0 Then
            Dim dr As DataRow = dsOpinion.Tables(0).NewRow
            With dr
                .Item("project_code") = MyBase.ProjectCode
                .Item("item_type") = ConfirmItemType
                .Item("item_code") = ConfirmItemCode
                .Item("content") = txtConfirmOpinion.Text
                .Item("conclusion") = cboConfirm.SelectedValue
                .Item("create_person") = UserName
                .Item("create_date") = MyBase.SystemDate
            End With
            dsOpinion.Tables(0).Rows.Add(dr)
            hasNew = True
        Else
            dsOpinion.Tables(0).Rows(0)("content") = txtConfirmOpinion.Text
            dsOpinion.Tables(0).Rows(0)("conclusion") = cboConfirm.SelectedValue
        End If

        Dim result As String = gWs.UpdateProjectOpinion(dsOpinion.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存意见失败", result, "")
            Return False
        End If
        If hasNew Then
            Dim strSql As String = "{project_code='" & ProjectCode & "' AND item_type='" & ConfirmItemType & "' AND item_code='" & ConfirmItemCode & "'}"
            Dim dsTemp As DataSet = gWs.GetProjectOpinionByProjectNo(strSql)
            dsOpinion.Tables(0).Rows(0)("serial_num") = dsTemp.Tables(0).Rows(0)("serial_num")
            dsTemp.Dispose()
        End If
        dsOpinion.AcceptChanges()

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

        If Not InsertAnOpition() Then '插入意见
            Return
        End If

        Dim strResult As String = gWs.finishedTask(cboRunMode.Text, ProjectCode, TaskID, cboConfirm.SelectedValue, UserName)
        If strResult = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            RemoveHandler MyBase.Closing, AddressOf frmMeetingRecord_Closing
            MyBase.raiseCommitSucceed()
            Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "")
        End If
    End Sub
End Class
