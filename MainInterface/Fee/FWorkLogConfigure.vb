Public Class FWorkLogConfigure
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
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents grdJobRespon As System.Windows.Forms.DataGrid
    Friend WithEvents colResponsibility As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboTask As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents cboRemark As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents dgtsJogRes As System.Windows.Forms.DataGridTableStyle
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FWorkLogConfigure))
        Me.grdJobRespon = New System.Windows.Forms.DataGrid()
        Me.dgtsJogRes = New System.Windows.Forms.DataGridTableStyle()
        Me.colResponsibility = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cboTask = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridBoolColumn()
        Me.cboRemark = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.grdJobRespon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdJobRespon
        '
        Me.grdJobRespon.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grdJobRespon.CaptionVisible = False
        Me.grdJobRespon.DataMember = ""
        Me.grdJobRespon.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdJobRespon.Location = New System.Drawing.Point(8, 8)
        Me.grdJobRespon.Name = "grdJobRespon"
        Me.grdJobRespon.Size = New System.Drawing.Size(552, 232)
        Me.grdJobRespon.TabIndex = 0
        Me.grdJobRespon.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dgtsJogRes})
        '
        'dgtsJogRes
        '
        Me.dgtsJogRes.DataGrid = Me.grdJobRespon
        Me.dgtsJogRes.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.colResponsibility, Me.cboTask, Me.DataGridTextBoxColumn3})
        Me.dgtsJogRes.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgtsJogRes.MappingName = "TJobResponsibility"
        '
        'colResponsibility
        '
        Me.colResponsibility.Format = ""
        Me.colResponsibility.FormatInfo = Nothing
        Me.colResponsibility.HeaderText = "工作职责"
        Me.colResponsibility.MappingName = "post_responsibility"
        Me.colResponsibility.NullText = ""
        Me.colResponsibility.Width = 90
        '
        'cboTask
        '
        Me.cboTask.Format = ""
        Me.cboTask.FormatInfo = Nothing
        Me.cboTask.HeaderText = "工作任务"
        Me.cboTask.MappingName = "post_task"
        Me.cboTask.NullText = ""
        Me.cboTask.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.AllowNull = False
        Me.DataGridTextBoxColumn3.FalseValue = False
        Me.DataGridTextBoxColumn3.HeaderText = "后补特权"
        Me.DataGridTextBoxColumn3.MappingName = "laterInput_privilege"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.NullValue = CType(resources.GetObject("DataGridTextBoxColumn3.NullValue"), System.DBNull)
        Me.DataGridTextBoxColumn3.TrueValue = True
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'cboRemark
        '
        Me.cboRemark.Format = ""
        Me.cboRemark.FormatInfo = Nothing
        Me.cboRemark.HeaderText = "职责说明"
        Me.cboRemark.MappingName = "task_remark"
        Me.cboRemark.NullText = ""
        Me.cboRemark.Width = 500
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(48, 248)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 23)
        Me.btnNew.TabIndex = 9
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.Visible = False
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.Location = New System.Drawing.Point(148, 248)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 10
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(246, 248)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(344, 248)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FWorkLogConfigure
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(568, 277)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnSave, Me.btnDelete, Me.btnNew, Me.grdJobRespon})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FWorkLogConfigure"
        Me.Text = "工作职责设置"
        CType(Me.grdJobRespon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private dsJobPrivilege As DataSet

    Private Function GetTaskTypeTable() As DataTable
        Dim table As DataTable = New DataTable("TaskType")
        table.Columns.Add("Text", GetType(String))
        table.Columns.Add("Value", GetType(Int16))
        Dim row As DataRow = table.NewRow
        row("Text") = 0 '"需要计算加班工时" 
        row("Value") = 0
        table.Rows.Add(row)
        row = table.NewRow
        row("Text") = 1 '"不需要计算加班工时"  时段就是任务名称，例如请假，休假
        row("Value") = 1
        table.Rows.Add(row)
        row = table.NewRow
        row("Text") = 2 '"不需要计算加班工时"  时段保持正常上班，平时加班，假日加班
        row("Value") = 2
        table.Rows.Add(row)
        Return table
    End Function

    Private Sub AlterDataGridTableStyle()
        Dim colTaskType As DataGridComboBoxColumn = New DataGridComboBoxColumn()
        colTaskType.MappingName = "post_task_type"
        colTaskType.HeaderText = "计算工时类型"
        colTaskType.ColumnComboBox.DataSource = GetTaskTypetable.DefaultView
        colTaskType.ColumnComboBox.DisplayMember = "Text"
        colTaskType.ColumnComboBox.ValueMember = "Value"
        colTaskType.Width = 100
        dgtsJogRes.GridColumnStyles.Add(colTaskType)
        dgtsJogRes.GridColumnStyles.Add(cboRemark)
    End Sub

    Private Sub FWorkLogConfigure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dsJobPrivilege = gWs.GetPostAndJobResponsibilityInfo("null", "%")
        grdJobRespon.SetDataBinding(dsJobPrivilege, "TJobResponsibility")
        'CType(CType(Me.BindingContext(dsJobPrivilege, "TJobResponsibility"), CurrencyManager).List, DataView).AllowNew = False
        'CType(CType(Me.BindingContext(dsJobPrivilege, "TJobResponsibility"), CurrencyManager).List, DataView).AllowDelete = False
        dsJobPrivilege.Tables("TJobResponsibility").Columns("laterInput_privilege").DefaultValue = False
        dsJobPrivilege.Tables("TJobResponsibility").Columns("post_task_type").DefaultValue = 0
        colResponsibility.TextBox.MaxLength = 20
        cboTask.TextBox.MaxLength = 50
        cboRemark.TextBox.MaxLength = 100
        AlterDataGridTableStyle()
    End Sub

    'Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
    '    Dim row As DataRow = dsJobPrivilege.Tables("TJobResponsibility").NewRow
    '    If grdJobRespon.CurrentRowIndex >= 0 Then
    '        '必须确保该字段在该列
    '        row("post_responsibility") = grdJobRespon.Item(grdJobRespon.CurrentRowIndex, 0)
    '    End If
    '    dsJobPrivilege.Tables("TJobResponsibility").Rows.Add(row)
    '    grdJobRespon.CurrentRowIndex = dsJobPrivilege.Tables("TJobResponsibility").Select("", "", DataViewRowState.CurrentRows).Length - 1
    'End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If grdJobRespon.CurrentRowIndex < 0 Then
            Return
        End If
        CType(Me.BindingContext(dsJobPrivilege, "TJobResponsibility").Current, DataRowView).Row.Delete()
    End Sub

    Private Function IsInfoEffective() As Boolean
        If dsJobPrivilege.Tables("TJobResponsibility").Select("post_responsibility IS NULL OR post_task IS NULL").Length > 0 Then
            SWDialogBox.MessageBox.Show("$1003", "工作职责或工作任务")
            Return False
        End If
        Dim i, j, length As Int16
        Dim drs() As DataRow = dsJobPrivilege.Tables("TJobResponsibility").Select("", "", DataViewRowState.CurrentRows)
        length = drs.Length
        For i = 0 To length - 1
            For j = i + 1 To length - 1
                If String.Compare(drs(i)("post_responsibility"), drs(j)("post_responsibility")) = 0 And _
                    String.Compare(drs(i)("post_task"), drs(j)("post_task")) = 0 Then
                    SWDialogBox.MessageBox.Show("$1003", "(工作职责和工作任务不能重复)")
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Private Function Save(ByVal sender As Object) As Boolean
        If Not IsInfoEffective() Then
            Return False
        End If
        If Not dsJobPrivilege.HasChanges Then
            Return True
        End If
        Dim result As String = gWs.UpdatePostAndJobResponsibility(dsJobPrivilege.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存失败", result, "")
            Return False
        Else
            dsJobPrivilege.AcceptChanges()
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
        If dsJobPrivilege.HasChanges Then
            Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003")
            If QueryResult = DialogResult.Yes Then
                If Not Save(Nothing) Then
                    Return False
                End If
            ElseIf QueryResult = DialogResult.Cancel Then
                Return False
            End If
        End If
        RemoveHandler MyBase.Closing, AddressOf FWorkLogConfigure_Closing
        Close()
        Return True
    End Function

    Private Sub FWorkLogConfigure_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, Nothing)
    End Sub
End Class
