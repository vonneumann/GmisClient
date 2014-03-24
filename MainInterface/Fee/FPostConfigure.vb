Public Class FPostConfigure
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
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents grdPost As System.Windows.Forms.DataGrid
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FPostConfigure))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.grdPost = New System.Windows.Forms.DataGrid()
        CType(Me.grdPost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 3
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(234, 200)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 0
        Me.btnSave.ImageList = Me.ImageList1
        Me.btnSave.Location = New System.Drawing.Point(146, 200)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 2
        Me.btnDelete.ImageList = Me.ImageList1
        Me.btnDelete.Location = New System.Drawing.Point(58, 200)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 1
        Me.btnNew.ImageList = Me.ImageList1
        Me.btnNew.Location = New System.Drawing.Point(16, 200)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 23)
        Me.btnNew.TabIndex = 14
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.Visible = False
        '
        'grdPost
        '
        Me.grdPost.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grdPost.CaptionVisible = False
        Me.grdPost.DataMember = ""
        Me.grdPost.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdPost.Location = New System.Drawing.Point(8, 8)
        Me.grdPost.Name = "grdPost"
        Me.grdPost.Size = New System.Drawing.Size(352, 176)
        Me.grdPost.TabIndex = 13
        '
        'FPostConfigure
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(368, 229)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnSave, Me.btnDelete, Me.btnNew, Me.grdPost})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FPostConfigure"
        Me.Text = "岗位职责设置"
        CType(Me.grdPost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsPost As DataSet

    Private Function RemoveRepeatRow(ByVal sourceDT As DataTable) As DataTable
        Dim al As ArrayList = New ArrayList()
        Dim row As DataRow
        For Each row In sourceDT.Rows
            If Not al.Contains(row("post_responsibility")) Then
                al.Add(row("post_responsibility"))
            End If
        Next
        Dim newDt As DataTable = New DataTable(sourceDT.TableName)
        newDt = sourceDT.Clone
        Dim iEnum As IEnumerator = al.GetEnumerator
        While iEnum.MoveNext
            newDt.ImportRow(sourceDT.Select("post_responsibility='" & iEnum.Current.ToString & "'")(0))
        End While
        iEnum = Nothing
        Return newDt
    End Function

    Private Sub FPostConfigure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dsPost = gWs.GetPostAndJobResponsibilityInfo("%", "%")
        Dim tableNoRepeatRow As DataTable = RemoveRepeatRow(dsPost.Tables("TJobResponsibility"))
        dsPost.Tables.Remove(dsPost.Tables("TJobResponsibility"))
        dsPost.Merge(tableNoRepeatRow)

        grdPost.SetDataBinding(dsPost, "TPost")
        'CType(CType(Me.BindingContext(dsPost, "TPost"), CurrencyManager).List, DataView).AllowNew = False
        'CType(CType(Me.BindingContext(dsPost, "TPost"), CurrencyManager).List, DataView).AllowDelete = False
        AddTableStyle()
        btnNew.Focus()
    End Sub

    Private Sub AddTableStyle()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "TPost"
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "post_name"
        col1.HeaderText = "岗位名称"
        col1.Width = 130
        col1.TextBox.MaxLength = 10
        col1.NullText = String.Empty
        Dim col2 As DataGridComboBoxColumn = New DataGridComboBoxColumn()
        col2.MappingName = "post_responsibility"
        col2.HeaderText = "工作职责"
        col2.ColumnComboBox.DataSource = dsPost.Tables("TJobResponsibility").DefaultView
        col2.ColumnComboBox.DisplayMember = "post_responsibility"
        col2.ColumnComboBox.ValueMember = "post_responsibility"
        col2.Width = 150
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2})
        grdPost.TableStyles.Clear()
        grdPost.TableStyles.Add(dgts)
    End Sub

    'Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
    '    Dim row As DataRow = dsPost.Tables("TPost").NewRow
    '    dsPost.Tables("TPost").Rows.Add(row)
    '    grdPost.CurrentRowIndex = dsPost.Tables("TPost").Select("", "", DataViewRowState.CurrentRows).Length - 1
    'End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If grdPost.CurrentRowIndex < 0 Then
            Return
        End If
        CType(Me.BindingContext(dsPost, "TPost").Current, DataRowView).Row.Delete()
    End Sub

    Private Function IsInfoEffective() As Boolean
        If dsPost.Tables("TPost").Select("post_name IS NULL OR post_responsibility IS NULL", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1003", "岗位名称或工作职责")
            Return False
        End If
        Dim i, j, length As Int16
        Dim drs() As DataRow = dsPost.Tables("TPost").Select("", "", DataViewRowState.CurrentRows)
        length = dsPost.Tables("TPost").Select("", "", DataViewRowState.CurrentRows).Length
        For i = 0 To length - 1
            For j = i + 1 To length - 1
                If String.Compare(drs(i)("post_name"), drs(j)("post_name")) = 0 And _
                   String.Compare(drs(i)("post_responsibility"), drs(j)("post_responsibility")) = 0 Then
                    SWDialogBox.MessageBox.Show("$1003", "(岗位名称和工作职责不能重复)")
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Private Function Save(ByVal sender As Object) As Boolean
        Me.BindingContext(dsPost, "TPost").EndCurrentEdit()
        If Not dsPost.HasChanges Then
            Return True
        End If

        If Not IsInfoEffective() Then
            Return False
        End If
        Dim result As String = gWs.UpdatePostAndJobResponsibility(dsPost.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存失败", result, "")
            Return False
        Else
            dsPost.AcceptChanges()
        End If
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Save(sender)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Function ConfirmClose(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        If dsPost.HasChanges Then
            Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003")
            If QueryResult = DialogResult.Yes Then
                If Not Save(Nothing) Then
                    Return False
                End If
            ElseIf QueryResult = DialogResult.Cancel Then
                Return False
            End If
        End If
        RemoveHandler MyBase.Closing, AddressOf FPostConfigure_Closing
        Close()
        Return True
    End Function

    Private Sub FPostConfigure_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, Nothing)
    End Sub
End Class
