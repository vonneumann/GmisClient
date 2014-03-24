Public Class FUserPost
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
    Friend WithEvents grdUserPost As System.Windows.Forms.DataGrid
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboStaff As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboPost As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboJob As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboTask As System.Windows.Forms.ComboBox
    Friend WithEvents gpbxContainer As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FUserPost))
        Me.grdUserPost = New System.Windows.Forms.DataGrid()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboStaff = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboPost = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboJob = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboTask = New System.Windows.Forms.ComboBox()
        Me.gpbxContainer = New System.Windows.Forms.GroupBox()
        CType(Me.grdUserPost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbxContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdUserPost
        '
        Me.grdUserPost.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grdUserPost.CaptionVisible = False
        Me.grdUserPost.DataMember = ""
        Me.grdUserPost.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdUserPost.Location = New System.Drawing.Point(8, 8)
        Me.grdUserPost.Name = "grdUserPost"
        Me.grdUserPost.ReadOnly = True
        Me.grdUserPost.Size = New System.Drawing.Size(632, 328)
        Me.grdUserPost.TabIndex = 99
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(422, 424)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(332, 424)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 6
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(242, 424)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(152, 424)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 23)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "员 工 姓 名"
        '
        'cboStaff
        '
        Me.cboStaff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStaff.Location = New System.Drawing.Point(96, 16)
        Me.cboStaff.Name = "cboStaff"
        Me.cboStaff.Size = New System.Drawing.Size(192, 20)
        Me.cboStaff.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(344, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 14)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "岗 位 名 称"
        '
        'cboPost
        '
        Me.cboPost.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPost.Location = New System.Drawing.Point(424, 16)
        Me.cboPost.Name = "cboPost"
        Me.cboPost.Size = New System.Drawing.Size(192, 20)
        Me.cboPost.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 14)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "默认工作职责"
        '
        'cboJob
        '
        Me.cboJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJob.Location = New System.Drawing.Point(96, 48)
        Me.cboJob.Name = "cboJob"
        Me.cboJob.Size = New System.Drawing.Size(192, 20)
        Me.cboJob.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(344, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 14)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "默认工作类别"
        '
        'cboTask
        '
        Me.cboTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTask.Location = New System.Drawing.Point(424, 48)
        Me.cboTask.Name = "cboTask"
        Me.cboTask.Size = New System.Drawing.Size(192, 20)
        Me.cboTask.TabIndex = 3
        '
        'gpbxContainer
        '
        Me.gpbxContainer.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.gpbxContainer.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboTask, Me.Label3, Me.Label4, Me.cboJob, Me.Label2, Me.Label1, Me.cboStaff, Me.cboPost})
        Me.gpbxContainer.Location = New System.Drawing.Point(8, 336)
        Me.gpbxContainer.Name = "gpbxContainer"
        Me.gpbxContainer.Size = New System.Drawing.Size(632, 80)
        Me.gpbxContainer.TabIndex = 20
        Me.gpbxContainer.TabStop = False
        '
        'FUserPost
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(648, 453)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.gpbxContainer, Me.btnExit, Me.btnSave, Me.btnDelete, Me.btnNew, Me.grdUserPost})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FUserPost"
        Me.Text = "员工岗位表设置"
        CType(Me.grdUserPost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbxContainer.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsStaffPost, dsPostAndJob, dsStaff As DataSet

    Private Sub AddTableStyle()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "TUserPost"
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "staff_name"
        col1.HeaderText = "员工姓名"
        col1.Width = 90
        col1.NullText = String.Empty

        Dim colPost As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        colPost.MappingName = "post_name"
        colPost.HeaderText = "岗位职责"
        colPost.Width = 120
        colPost.NullText = String.Empty

        'Dim colDefaultPost As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        'colDefaultPost.MappingName = "default_post"
        'colDefaultPost.HeaderText = "默认岗位"
        'colDefaultPost.Width = 110
        'colDefaultPost.NullText = String.Empty

        Dim colDefaultJob As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        colDefaultJob.MappingName = "default_responsibility"
        colDefaultJob.HeaderText = "默认工作职责"
        colDefaultJob.Width = 150
        colDefaultJob.NullText = String.Empty
        '
        Dim colDefaultTask As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        colDefaultTask.MappingName = "default_task"
        colDefaultTask.HeaderText = "默认工作类别"
        colDefaultTask.Width = 200
        colDefaultTask.NullText = String.Empty
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, colPost, colDefaultJob, colDefaultTask})
        grdUserPost.TableStyles.Clear()
        grdUserPost.TableStyles.Add(dgts)
    End Sub

    Private Function RemoveRepeatRow(ByVal sourceDT As DataTable) As DataTable
        Dim al As ArrayList = New ArrayList()
        Dim row As DataRow
        For Each row In sourceDT.Rows
            If Not al.Contains(row("post_name")) Then
                al.Add(row("post_name"))
            End If
        Next
        Dim newDt As DataTable = New DataTable(sourceDT.TableName)
        newDt = sourceDT.Clone
        Dim iEnum As IEnumerator = al.GetEnumerator
        While iEnum.MoveNext
            newDt.ImportRow(sourceDT.Select("post_name='" & iEnum.Current.ToString & "'")(0))
        End While
        iEnum = Nothing
        Return newDt
    End Function

    Private Sub InitializeComboBox()
        '缺省工作岗位
        'cboDefaultPost.DataSource = dsStaffPost.Tables(0).DefaultView
        'dsStaffPost.Tables(0).DefaultView.RowStateFilter = DataViewRowState.CurrentRows
        'cboDefaultPost.DisplayMember = "post_name"
        'cboDefaultPost.ValueMember = "post_name"

        cboStaff.DataSource = dsStaff.Tables(0).DefaultView
        cboStaff.DisplayMember = "staff_name"
        cboStaff.ValueMember = "staff_name"
        AddHandler cboStaff.SelectedIndexChanged, AddressOf StaffChanged
        cboStaff.DataBindings.Add("SelectedValue", dsStaffPost, "TUserPost.staff_name")

        'cboTask.DataSource = dsPostAndJob.Tables("TJobResponsibility").DefaultView
        'dsPostAndJob.Tables("TJobResponsibility").DefaultView.RowStateFilter = DataViewRowState.CurrentRows
        'cboTask.DisplayMember = "post_task"
        'cboTask.ValueMember = "post_task"

        'Dim anotherPostDs As DataSet = New DataSet()
        'anotherPostDs.Merge(dsPostAndJob.Tables("TPost").Copy)
        'anotherPostDs.Tables("TPost").DefaultView.RowStateFilter = DataViewRowState.CurrentRows
        'cboJob.DataSource = anotherPostDs.Tables("TPost").DefaultView
        'cboJob.DisplayMember = "post_responsibility"
        'cboJob.ValueMember = "post_responsibility"

        AddHandler cboJob.SelectedIndexChanged, AddressOf DefaultJobChanged

        'cboPost.DataSource = RemoveRepeatRow(dsPostAndJob.Tables("TPost")).DefaultView
        'dsPostAndJob.Tables("TPost").DefaultView.RowStateFilter = DataViewRowState.CurrentRows
        'cboPost.DisplayMember = "post_name"
        'cboPost.ValueMember = "post_name"
        Dim row As DataRow
        For Each row In dsPostAndJob.Tables("TPost").Rows
            If cboPost.Items.IndexOf(row("post_name")) < 0 Then
                cboPost.Items.Add(row("post_name"))
            End If
        Next

        AddHandler cboPost.SelectedIndexChanged, AddressOf PostChanged

        'cboDefaultPost.DataBindings.Add("SelectedItem", dsStaffPost, "TUserPost.default_post")
    End Sub

    Private Sub FUserPost_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        dsStaff = gWs.GetStaff("%")
        dsStaffPost = gWs.GetUserPostInfo("%")
        dsPostAndJob = gWs.GetPostAndJobResponsibilityInfo("%", "%")
        grdUserPost.SetDataBinding(dsStaffPost, "TUserPost")
        AddTableStyle()
        InitializeComboBox()

        'Dim bind As Binding
        'bind = New Binding("SelectedItem", dsStaffPost, "TUserPost.post_name")
        'AddHandler bind.Format, AddressOf ComboBoxBindingFormat
        'AddHandler bind.Parse, AddressOf ComboBoxBindingParse
        'cboPost.DataBindings.Add(bind)
        'bind = New Binding("SelectedItem", dsStaffPost, "TUserPost.default_responsibility")
        'AddHandler bind.Format, AddressOf ComboBoxBindingFormat
        'AddHandler bind.Parse, AddressOf ComboBoxBindingParse
        'cboJob.DataBindings.Add(bind)
        'bind = New Binding("SelectedItem", dsStaffPost, "TUserPost.default_task")
        'AddHandler bind.Format, AddressOf ComboBoxBindingFormat
        'AddHandler bind.Parse, AddressOf ComboBoxBindingParse
        'cboTask.DataBindings.Add(bind)
        DataRowToControl(Nothing, Nothing)
        AddHandler Me.BindingContext(dsStaffPost, "TUserPost").PositionChanged, AddressOf DataRowToControl
        cboStaff.Focus()
        If dsStaffPost.HasChanges Then
            dsStaffPost.AcceptChanges()
        End If
    End Sub

    Private Sub StaffChanged(ByVal sender As Object, ByVal e As EventArgs)
        cboPost.SelectedItem = Nothing
    End Sub

    '岗位改变时
    Private Sub PostChanged(ByVal sender As Object, ByVal e As EventArgs)
        cboJob.Items.Clear()
        If CType(sender, ComboBox).SelectedIndex < 0 Then
            Return
        End If
        Dim row As DataRow
        For Each row In dsPostAndJob.Tables("TPost").Select("post_name='" & CType(sender, ComboBox).SelectedItem.ToString & "'")
            If cboJob.Items.IndexOf(row("post_responsibility")) < 0 Then
                cboJob.Items.Add(row("post_responsibility"))
            End If
        Next
    End Sub
    '工作职责改变时
    Private Sub DefaultJobChanged(ByVal sender As Object, ByVal e As EventArgs)
        cboTask.Items.Clear()
        If CType(sender, ComboBox).SelectedIndex < 0 Then
            Return
        End If
        Dim row As DataRow
        For Each row In dsPostAndJob.Tables("TJobResponsibility").Select("post_responsibility='" & CType(sender, ComboBox).SelectedItem.ToString & "'")
            If cboTask.Items.IndexOf(row("post_task")) < 0 Then
                cboTask.Items.Add(row("post_task"))
            End If
        Next
    End Sub

    Private Sub DataRowToControl(ByVal sender As Object, ByVal e As EventArgs)
        If grdUserPost.CurrentRowIndex < 0 Then
            Return
        End If
        Dim rowView As DataRowView = CType(Me.BindingContext(dsStaffPost, "TUserPost").Current, DataRowView)
        Dim i As Int32
        i = cboPost.Items.IndexOf(rowView("post_name"))
        If i < 0 Then
            cboPost.SelectedIndex = 0
            rowView("default_responsibility") = DBNull.Value
        Else
            cboPost.SelectedIndex = i
        End If
        i = cboJob.Items.IndexOf(rowView("default_responsibility"))
        If i < 0 Then
            If cboJob.Items.Count > 0 Then
                cboJob.SelectedIndex = 0
            Else
                cboJob.SelectedItem = Nothing
                rowView("default_task") = DBNull.Value
            End If
        Else
            cboJob.SelectedIndex = i
        End If
        i = cboTask.Items.IndexOf(rowView("default_task"))
        If i < 0 Then
            If cboTask.Items.Count > 0 Then
                cboTask.SelectedIndex = 0
            Else
                cboTask.SelectedItem = Nothing
            End If
        Else
            cboTask.SelectedIndex = i
        End If
    End Sub

    Private Sub ControlToDataRow()
        If grdUserPost.CurrentRowIndex < 0 Then
            Return
        End If
        Dim rowView As DataRowView = CType(Me.BindingContext(dsStaffPost, "TUserPost").Current, DataRowView)
        rowView("post_name") = IIf(cboPost.SelectedItem Is Nothing, DBNull.Value, cboPost.SelectedItem)
        rowView("default_responsibility") = IIf(cboJob.SelectedItem Is Nothing, DBNull.Value, cboJob.SelectedItem)
        rowView("default_task") = IIf(cboTask.SelectedItem Is Nothing, DBNull.Value, cboTask.SelectedItem)
    End Sub

    Private Sub ComboBox_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles cboJob.Leave, cboPost.Leave, cboTask.Leave
        ControlToDataRow()
    End Sub

    Private Sub SetNull()
        cboStaff.SelectedValue = DBNull.Value
        cboPost.SelectedItem = Nothing
    End Sub

    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        Dim row As DataRow = dsStaffPost.Tables("TUserPost").NewRow
        dsStaffPost.Tables("TUserPost").Rows.Add(row)
        grdUserPost.CurrentRowIndex = dsStaffPost.Tables("TUserPost").Select("", "", DataViewRowState.CurrentRows).Length - 1
        SetNull()
        grdUserPost.Enabled = False
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If grdUserPost.CurrentRowIndex < 0 Then
            Return
        End If
        CType(Me.BindingContext(dsStaffPost, "TUserPost").Current, DataRowView).Row.Delete()
        If Not grdUserPost.Enabled Then
            If dsStaffPost.HasChanges(DataRowState.Added) Then
                grdUserPost.CurrentRowIndex = dsStaffPost.Tables("TUserPost").Select("", "", DataViewRowState.CurrentRows).Length - 1
            Else
                grdUserPost.Enabled = True
                grdUserPost.Size = New Size(grdUserPost.Width + 5, grdUserPost.Height + 5)
                grdUserPost.Size = New Size(grdUserPost.Width - 5, grdUserPost.Height - 5)
            End If
        End If
    End Sub

    Private Sub ChangeFocus()
        Dim c, curControl As Control
        curControl = Me.ActiveControl
        For Each c In gpbxContainer.Controls
            If Not c Is curControl Then
                c.Focus()
            End If
        Next
        curControl.Focus()
    End Sub

    Private Function IsInfoEffective() As Boolean
        If dsStaffPost.Tables("TUserPost").Select("staff_name IS NULL OR post_name IS NULL").Length > 0 Then
            SWDialogBox.MessageBox.Show("$1003", "员工姓名或岗位名称")
            Return False
        End If
        Dim i, j, length As Int16
        Dim drs() As DataRow = dsStaffPost.Tables("TUserPost").Select("", "", DataViewRowState.CurrentRows)
        length = drs.Length
        For i = 0 To length - 1
            For j = i + 1 To length - 1
                If String.Compare(drs(i)("staff_name"), drs(j)("staff_name")) = 0 And _
                    String.Compare(drs(i)("post_name"), drs(j)("post_name")) = 0 Then
                    SWDialogBox.MessageBox.Show("$1003", "(员工姓名和岗位名称不能重复)")
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Private Function Save(ByVal sender As Object) As Boolean
        grdUserPost.Focus()
        Me.BindingContext(dsStaffPost, "TUserPost").EndCurrentEdit()
        If Not dsStaffPost.HasChanges Then
            Return True
        End If

        If Not IsInfoEffective() Then
            Return False
        End If

        Dim result As String = gWs.UpdateUserPost(dsStaffPost.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存失败", result, "")
            Return False
        Else
            dsStaffPost.AcceptChanges()
        End If
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If Save(sender) Then
            grdUserPost.Enabled = True
            grdUserPost.Size = New Size(grdUserPost.Width + 5, grdUserPost.Height + 5)
            grdUserPost.Size = New Size(grdUserPost.Width - 5, grdUserPost.Height - 5)
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Function ConfirmClose(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        If dsStaffPost.HasChanges(DataRowState.Added Or DataRowState.Deleted) Then
            Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003")
            If QueryResult = DialogResult.Yes Then
                If Not Save(Nothing) Then
                    Return False
                End If
            ElseIf QueryResult = DialogResult.Cancel Then
                Return False
            End If
        End If
        RemoveHandler MyBase.Closing, AddressOf FUserPost_Closing
        Close()
        Return True
    End Function

    Private Sub FUserPost_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, Nothing)
    End Sub

    'Private Sub grdUserPost_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdUserPost.CurrentCellChanged
    '    PostChanged(sender, e)
    '    DefaultJobChanged(sender, e)
    'End Sub

    'Private Sub ComboBoxBindingFormat(ByVal sender As Object, ByVal e As ConvertEventArgs)
    '    txtMessage.Text = txtMessage.Text & System.Environment.NewLine & "ComboBoxBindingFormat --" & CType(sender, Binding).Control.Name
    '    Dim ComBox As ComboBox = CType(CType(sender, Binding).Control, ComboBox)
    '    If IsDBNull(e.Value) Then
    '        e.Value = Nothing
    '    ElseIf ComBox.Items.IndexOf(e.Value) < 0 Then
    '        e.Value = Nothing
    '    End If
    'End Sub

    'Private Sub ComboBoxBindingParse(ByVal sender As Object, ByVal e As ConvertEventArgs)
    '    txtMessage.Text = txtMessage.Text & System.Environment.NewLine & "ComboBoxBindingParse --" & CType(sender, Binding).Control.Name
    '    If e.Value Is Nothing Or IsDBNull(e.Value) Then
    '        e.Value = DBNull.Value
    '    End If
    'End Sub
End Class
