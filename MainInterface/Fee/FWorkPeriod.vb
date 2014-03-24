Public Class FWorkPeriod
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboStartTime As System.Windows.Forms.ComboBox
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cboEndTime As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents grdPeriod As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboPeriod As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FWorkPeriod))
        Me.grdPeriod = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboStartTime = New System.Windows.Forms.ComboBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cboEndTime = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cboPeriod = New System.Windows.Forms.ComboBox()
        CType(Me.grdPeriod, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdPeriod
        '
        Me.grdPeriod.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grdPeriod.CaptionVisible = False
        Me.grdPeriod.DataMember = ""
        Me.grdPeriod.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdPeriod.Location = New System.Drawing.Point(8, 8)
        Me.grdPeriod.Name = "grdPeriod"
        Me.grdPeriod.ReadOnly = True
        Me.grdPeriod.Size = New System.Drawing.Size(400, 152)
        Me.grdPeriod.TabIndex = 9
        Me.grdPeriod.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdPeriod
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TJobPeriod"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "时段"
        Me.DataGridTextBoxColumn1.MappingName = "period"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 130
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "开始时间"
        Me.DataGridTextBoxColumn2.MappingName = "start_time"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 90
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "结束时间"
        Me.DataGridTextBoxColumn3.MappingName = "end_time"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 90
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "时 段"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(152, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "开始时间"
        '
        'cboStartTime
        '
        Me.cboStartTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cboStartTime.Location = New System.Drawing.Point(208, 168)
        Me.cboStartTime.MaxLength = 6
        Me.cboStartTime.Name = "cboStartTime"
        Me.cboStartTime.Size = New System.Drawing.Size(64, 20)
        Me.cboStartTime.TabIndex = 2
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(24, 200)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 23)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(114, 200)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(204, 200)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboEndTime
        '
        Me.cboEndTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cboEndTime.Location = New System.Drawing.Point(336, 168)
        Me.cboEndTime.MaxLength = 6
        Me.cboEndTime.Name = "cboEndTime"
        Me.cboEndTime.Size = New System.Drawing.Size(64, 20)
        Me.cboEndTime.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(280, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "结束时间"
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(294, 200)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboPeriod
        '
        Me.cboPeriod.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cboPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPeriod.Items.AddRange(New Object() {"正常上班", "平时加班"})
        Me.cboPeriod.Location = New System.Drawing.Point(48, 168)
        Me.cboPeriod.Name = "cboPeriod"
        Me.cboPeriod.Size = New System.Drawing.Size(96, 20)
        Me.cboPeriod.TabIndex = 1
        '
        'FWorkPeriod
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(416, 229)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboPeriod, Me.btnExit, Me.cboEndTime, Me.Label3, Me.Label2, Me.Label1, Me.btnSave, Me.btnDelete, Me.btnNew, Me.cboStartTime, Me.grdPeriod})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FWorkPeriod"
        Me.Text = "工作时间设置"
        CType(Me.grdPeriod, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsPeriod As DataSet

    Private Sub AddDataBinding()
        cboStartTime.DataBindings.Add("Text", dsPeriod, "TJobPeriod.start_time")
        cboEndTime.DataBindings.Add("Text", dsPeriod, "TJobPeriod.end_time")
        cboPeriod.DataBindings.Add("SelectedItem", dsPeriod, "TJobPeriod.period")
    End Sub

    Private Sub FWorkPeriod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            dsPeriod = gWs.GetJobPeriodInfo("%")
            grdPeriod.SetDataBinding(dsPeriod, "TJobPeriod")
            'CType(CType(Me.BindingContext(dsPeriod, "TJobPeriod"), CurrencyManager).List, DataView).AllowNew = False
            'CType(CType(Me.BindingContext(dsPeriod, "TJobPeriod"), CurrencyManager).List, DataView).AllowDelete = False
            FillTimeComboBox(cboStartTime)
            FillTimeComboBox(cboEndTime)
            '添加绑定
            AddDataBinding()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim row As DataRow = dsPeriod.Tables("TJobPeriod").NewRow
        dsPeriod.Tables("TJobPeriod").Rows.Add(row)
        grdPeriod.CurrentRowIndex = dsPeriod.Tables("TJobPeriod").Select("", "", DataViewRowState.CurrentRows).Length - 1
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If grdPeriod.CurrentRowIndex < 0 Then
            Return
        End If
        Dim row As DataRow = CType(Me.BindingContext(dsPeriod, "TJobPeriod").Current, DataRowView).Row
        row.Delete()
    End Sub

    Private Function IsInfoEffective() As Boolean
        If dsPeriod.Tables("TJobPeriod").Select("period IS NULL").Length > 0 Then
            SWDialogBox.MessageBox.Show("$1003", "阶段")
            Return False
        End If
        If dsPeriod.Tables("TJobPeriod").Select("start_time IS NULL OR end_time IS NULL").Length > 0 Then
            SWDialogBox.MessageBox.Show("$1003", "开始时间或结束时间")
            Return False
        End If

        Dim i, j, length As Int16
        Dim drs() As DataRow = dsPeriod.Tables("TJobPeriod").Select("", "", DataViewRowState.CurrentRows)
        length = drs.Length
        For i = 0 To length - 1
            If String.Compare(drs(i)("start_time"), drs(i)("end_time")) >= 0 Then
                SWDialogBox.MessageBox.Show("$1003", "(开始时间-结束时间)")
                Return False
            End If

            For j = i + 1 To length - 1
                If drs(i)("period") = drs(j)("period") AndAlso drs(i)("start_time") = drs(j)("start_time") Then
                    SWDialogBox.MessageBox.Show("$1003", "（阶段和开始时间存在重复）")
                    Return False
                End If
                If (String.Compare(drs(i)("start_time"), drs(j)("start_time")) > 0 And _
                      String.Compare(drs(i)("start_time"), drs(j)("end_time")) < 0) Or _
                        (String.Compare(drs(i)("end_time"), drs(j)("start_time")) > 0 And _
                            String.Compare(drs(i)("end_time"), drs(j)("end_time")) < 0) Then
                    SWDialogBox.MessageBox.Show("$1003", "（时间段存在重复）")
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Private Sub ChangedFocus()
        Dim c As Control = Me.ActiveControl
        If c Is cboPeriod Then
            cboStartTime.Focus()
        ElseIf c Is cboStartTime Then
            cboEndTime.Focus()
        ElseIf c Is cboEndTime Then
            cboPeriod.Focus()
        End If
    End Sub

    Private Function Save(ByVal sender As Object) As Boolean
        ChangedFocus()
        Me.BindingContext(dsPeriod, "TJobPeriod").EndCurrentEdit()
        If Not dsPeriod.HasChanges Then
            Return True
        End If

        If Not IsInfoEffective() Then
            Return False
        End If

        Dim result As String = gWs.UpdateJobPeriod(dsPeriod.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存失败", result, "")
            Return False
        Else
            dsPeriod.AcceptChanges()
        End If
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save(sender)
    End Sub

    Private Function ConfirmClose(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        If dsPeriod.HasChanges(DataRowState.Added) Then
            Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003")
            If QueryResult = DialogResult.Yes Then
                If Not Save(Nothing) Then
                    Return False
                End If
            ElseIf QueryResult = DialogResult.Cancel Then
                Return False
            End If
        End If
        RemoveHandler MyBase.Closing, AddressOf Me_Closing
        Close()
        Return True
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ConfirmClose(sender, e)
    End Sub

    Private Sub Me_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, Nothing)
    End Sub

    Private Sub FillTimeComboBox(ByVal cboTime As ComboBox)
        Dim i, j As Int16
        For i = 0 To 23
            j = 0
            While j < 60
                cboTime.Items.Add(Format(DateTime.Parse(i & ":" & j.ToString), "HH:mm"))
                j += 10
            End While
        Next
    End Sub

    Private Sub StartTimeLeave(ByVal sender As Object, ByVal e As EventArgs) Handles cboStartTime.Leave
        Try
            If cboStartTime.SelectedIndex < 0 Then
                Dim dt As DateTime = DateTime.Parse(cboStartTime.Text)
                cboEndTime.SelectedIndex = dt.Hour * 6 + Math.Ceiling(dt.Minute / 10)
                cboStartTime.Text = Format(dt, "HH:mm")
            ElseIf cboStartTime.SelectedIndex < cboEndTime.Items.Count - 1 Then
                cboEndTime.SelectedIndex = cboStartTime.SelectedIndex + 1
            End If
        Catch
            cboStartTime.Text = ""
        End Try
    End Sub

    Private Sub EndTimeLeave(ByVal sender As Object, ByVal e As EventArgs) Handles cboEndTime.Leave
        Try
            If cboEndTime.SelectedIndex < 0 Then
                Dim dt As DateTime = DateTime.Parse(cboEndTime.Text)
                cboEndTime.Text = Format(dt, "HH:mm")
            End If
        Catch
            cboEndTime.Text = ""
        End Try
    End Sub

End Class
