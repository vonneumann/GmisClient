

Public Class frmRequestVouchApplication
    Inherits MainInterface.frmBusinessBaseWin

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
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents btnCommit As System.Windows.Forms.Button
    Public WithEvents dgDatum As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents btnUploadReport As System.Windows.Forms.Button
    Public WithEvents btnConferenceTrial As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRequestVouchApplication))
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgDatum = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnUploadReport = New System.Windows.Forms.Button()
        Me.btnConferenceTrial = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Location = New System.Drawing.Point(240, 8)
        Me.txtEnterpriseName.Size = New System.Drawing.Size(192, 21)
        Me.txtEnterpriseName.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(64, 8)
        Me.txtProjectCode.Visible = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(184, 16)
        Me.Label2.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(352, 232)
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(264, 232)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 5
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgDatum})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 192)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'dgDatum
        '
        Me.dgDatum.CaptionVisible = False
        Me.dgDatum.DataMember = ""
        Me.dgDatum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDatum.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDatum.Location = New System.Drawing.Point(3, 17)
        Me.dgDatum.Name = "dgDatum"
        Me.dgDatum.ReadOnly = True
        Me.dgDatum.Size = New System.Drawing.Size(418, 172)
        Me.dgDatum.TabIndex = 8
        Me.dgDatum.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgDatum
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn2, Me.DataGridBoolColumn1, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TItem"
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "确认材料名称"
        Me.DataGridTextBoxColumn2.MappingName = "item_name"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 420
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridBoolColumn1.AllowNull = False
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "材料是否完备"
        Me.DataGridBoolColumn1.MappingName = "IsFinished"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), System.DBNull)
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 240
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "检查人"
        Me.DataGridTextBoxColumn3.MappingName = "check_person"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "检查日期"
        Me.DataGridTextBoxColumn4.MappingName = "check_date"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = ""
        Me.DataGridTextBoxColumn1.Width = -1
        '
        'btnUploadReport
        '
        Me.btnUploadReport.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnUploadReport.Enabled = False
        Me.btnUploadReport.Image = CType(resources.GetObject("btnUploadReport.Image"), System.Drawing.Bitmap)
        Me.btnUploadReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUploadReport.ImageIndex = 19
        Me.btnUploadReport.ImageList = Me.ImageListBasic
        Me.btnUploadReport.Location = New System.Drawing.Point(24, 232)
        Me.btnUploadReport.Name = "btnUploadReport"
        Me.btnUploadReport.Size = New System.Drawing.Size(112, 23)
        Me.btnUploadReport.TabIndex = 7
        Me.btnUploadReport.Text = "制作放款申请书"
        Me.btnUploadReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUploadReport.Visible = False
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnConferenceTrial.Image = CType(resources.GetObject("btnConferenceTrial.Image"), System.Drawing.Bitmap)
        Me.btnConferenceTrial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnConferenceTrial.ImageIndex = 26
        Me.btnConferenceTrial.ImageList = Me.ImageListBasic
        Me.btnConferenceTrial.Location = New System.Drawing.Point(144, 232)
        Me.btnConferenceTrial.Name = "btnConferenceTrial"
        Me.btnConferenceTrial.Size = New System.Drawing.Size(112, 23)
        Me.btnConferenceTrial.TabIndex = 8
        Me.btnConferenceTrial.Text = "评审会结论(&R)"
        Me.btnConferenceTrial.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmRequestVouchApplication
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(442, 263)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.btnConferenceTrial, Me.btnUploadReport, Me.GroupBox1, Me.btnCommit})
        Me.Name = "frmRequestVouchApplication"
        Me.Text = "呈请放款申请书"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ds As DataSet
    'Protected intReportType As Integer

    Private Sub frmRequestVouchApplication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            AddHandler btnExit.Click, AddressOf btnExit_Click
            AddHandler btnCommit.Click, AddressOf btnCommit_Click
            Call Me.GetRequestVouchApplicationData()
            AddTableStyle()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    'added by hute 2003-10-29
    Private Sub AddTableStyle()
        Me.dgDatum.TableStyles.Clear()
        Dim ts As DataGridTableStyle = New DataGridTableStyle()
        ts.MappingName = "TItem"

        Dim col0 As New DataGridTextBoxColumn()
        col0.HeaderText = "确认项名称"
        col0.MappingName = "item_name"
        col0.Width = 360

        Dim col1 As New DataGridTextBoxColumn()
        col1.HeaderText = "确认情况"
        col1.Alignment = HorizontalAlignment.Center
        col1.MappingName = "IsFinished"
        col1.width = 80

        Dim col2 As New DataGridTextBoxColumn()
        col2.HeaderText = "确认人"
        col2.MappingName = "check_person"
        col2.NullText = ""
        col2.Width = 60

        Dim col3 As New DataGridTextBoxColumn()
        col3.Format = "yyyy-MM-dd"
        col3.HeaderText = "确认日期"
        col3.MappingName = "check_date"
        col3.NullText = ""
        col3.Width = 72

        Dim col4 As New DataGridTextBoxColumn()
        col4.MappingName = "item_code"
        col4.Width = 0

        ts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col0, col1, col2, col3, col4})

        Me.dgDatum.TableStyles.Add(ts)
    End Sub

    Private Sub GetRequestVouchApplicationData()
        ds = gWs.GetItem("%", "44")
        If Not ds.Tables("TItem").Rows.Count = 0 Then
            Me.dgDatum.DataSource = Me.IsDatumFinished(ds).Tables(0).DefaultView
        End If
    End Sub

    Private Function IsDatumFinished(ByVal ds As DataSet) As DataSet
        Dim dsTemp As DataSet
        Dim j As Integer
        dsTemp = gWs.GetProjectDocumentByCondition("{project_code='" & Me.strProjectCode & "' AND item_type='44' AND check_person IS NOT NULL}")
        '添加文档是否完整的标志字段。
        ds.Tables("TItem").Columns.Add(("IsFinished"), GetType(String))
        '添加文档的检查人，检查日期字段。
        ds.Tables("TItem").Columns.Add(("check_person"), GetType(String))
        ds.Tables("TItem").Columns.Add(("check_date"), GetType(DateTime))

        For i = 0 To ds.Tables("TItem").Rows.Count - 1
            ds.Tables("TItem").Rows(i).Item("IsFinished") = "［Χ］"
        Next

        Dim intIsFinished As Integer = ds.Tables("TItem").Columns("IsFinished").Ordinal
        Dim intCheck_person As Integer = dsTemp.Tables(0).Columns("check_person").Ordinal
        Dim intCheck_date As Integer = dsTemp.Tables(0).Columns("check_date").Ordinal

        Dim dr() As DataRow
        For i = 0 To ds.Tables("TItem").Rows.Count - 1
            With ds.Tables("TItem").Rows(i)
                dr = dsTemp.Tables(0).Select("item_type = '" & .Item("item_type") & "' AND item_code = '" & .Item("item_code") & "'")
                If Not dr.Length = 0 Then
                    If Not IsDBNull(dr(0).Item("remark")) AndAlso dr(0).Item("remark") = "豁免" Then
                        .Item(intIsFinished) = "豁免"
                    Else
                        .Item(intIsFinished) = "［√］"
                    End If
                    .Item(intIsFinished + 1) = dr(0).Item(intCheck_person)
                    .Item(intIsFinished + 2) = dr(0).Item(intCheck_date)
                End If
            End With
        Next

        Return ds
    End Function

    Protected Overridable Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.isCommitConfirm = True Then
            'If MessageBox.Show("是否确认提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            If SWDialogBox.MessageBox.Show("?1000", "提交") = DialogResult.No Then
                Return
            End If
        End If
        Call Me.CommitWorkFlow("", Me)
    End Sub


    'Private Sub btnUploadReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadReport.Click

    'End Sub

    Private Function GetBankName(ByVal BankCode As String, ByVal BranchBankCode As String) As String
        Dim TempDS As DataSet
        If BranchBankCode = Nothing Then    '取得银行名称。
            TempDS = gWs.GetBankInfo("{bank_code='" & BankCode & "'}", "null")
            If Not TempDS.Tables(0).Rows(0).Item("bank_name") Is System.DBNull.Value Then
                Return TempDS.Tables(0).Rows(0).Item("bank_name")
            End If
        Else    '取得银行支行名称
            TempDS = gWs.GetBankInfo("null", "{bank_code='" & BankCode & "' and branch_bank_code='" & BranchBankCode & "'}")
            If Not TempDS.Tables(1).Rows(0).Item("branch_bank_name") Is System.DBNull.Value Then
                Return TempDS.Tables(1).Rows(0).Item("branch_bank_name")
            End If
        End If
    End Function

    Private Sub btnConferenceTrial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConferenceTrial.Click
        Dim meet As New frmMeetRecordQuery(Me.strProjectCode, Me.strEnterpriseName)
        meet.AllowTransparency = False
        meet.ShowDialog()
    End Sub

    Protected Overridable Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class
