

Public Class frmArchiveMaterial
    Inherits MainInterface.frmBasic

    Private strProjectCode As String
    Private strCorporationName As String
    Private strTaskID As String
    Private strWorkFlowID As String = "01"
    Private strPerson As String
    Private dsMaterial As DataSet

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgMaterial As System.Windows.Forms.DataGrid
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmArchiveMaterial))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgMaterial = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(363, 472)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgMaterial})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(696, 312)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "项目资料"
        '
        'dgMaterial
        '
        Me.dgMaterial.CaptionVisible = False
        Me.dgMaterial.DataMember = ""
        Me.dgMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMaterial.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMaterial.Location = New System.Drawing.Point(3, 17)
        Me.dgMaterial.Name = "dgMaterial"
        Me.dgMaterial.Size = New System.Drawing.Size(690, 292)
        Me.dgMaterial.TabIndex = 0
        Me.dgMaterial.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgMaterial
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TProjectDocument"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "资料名称"
        Me.DataGridTextBoxColumn1.MappingName = "doc_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 400
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "说明"
        Me.DataGridTextBoxColumn2.MappingName = "remark"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "确认人"
        Me.DataGridTextBoxColumn3.MappingName = "check_person"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "时间"
        Me.DataGridTextBoxColumn4.MappingName = "check_date"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(275, 472)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 3
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtRemark, Me.Label3})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 360)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(696, 104)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "归档项目资料备注"
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtRemark.Location = New System.Drawing.Point(80, 19)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtRemark.Size = New System.Drawing.Size(608, 77)
        Me.txtRemark.TabIndex = 1
        Me.txtRemark.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "备    注"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtName
        '
        Me.txtName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtName.Location = New System.Drawing.Point(368, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(336, 21)
        Me.txtName.TabIndex = 7
        Me.txtName.Text = ""
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 8)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(176, 21)
        Me.txtCode.TabIndex = 6
        Me.txtCode.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(312, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmArchiveMaterial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 503)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtName, Me.txtCode, Me.Label2, Me.Label1, Me.btnExit, Me.GroupBox3, Me.btnCommit, Me.GroupBox2})
        Me.Name = "frmArchiveMaterial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "归档项目资料"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Load()
    Private Sub frmArchiveMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Me.strProjectCode = Me.getProjectCode()
            Me.strCorporationName = Me.getCorporationName()
            Me.strWorkFlowID = Me.getWorkFlowID()
            Me.strTaskID = Me.getTaskID()
            Me.strPerson = Me.getUser()

            Me.txtCode.Text = Me.strProjectCode
            Me.txtName.Text = Me.strCorporationName
            Me.dsMaterial = getProjectDocument()

            If Not Me.dsMaterial Is Nothing Then
                Me.dgMaterial.DataSource = Me.dsMaterial.Tables("TProjectDocument")
                setDgAttribute(Me.dgMaterial, Me)
                addStyle(dsMaterial)
            End If

            '获得该项目的归档资料意见
            getOpinion()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '添加dataGrid的style
    Private Sub addStyle(ByVal ds As DataSet)
        Dim tableStyle As DataGridTableStyle = New DataGridTableStyle()
        tableStyle.MappingName = "TProjectDocument"
        tableStyle.AllowSorting = False
        tableStyle.RowHeadersVisible = True

        Dim numCols As Integer = ds.Tables("TProjectDocument").Columns.Count
        Dim dgc As New DataGridColoredBoolColumn()
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf dgc.MyGetColorRowCol)

        Dim column_1 As New DataGridTextBoxColumn()
        column_1.Width = 300
        column_1.ReadOnly = True
        column_1.NullText = ""
        column_1.HeaderText = "资料名称"
        column_1.MappingName = "doc_name"
        tableStyle.GridColumnStyles.Add(column_1)

        Dim aColumnTextColumn As DataGridColoredBoolColumn
        aColumnTextColumn = New DataGridColoredBoolColumn(d, 0)
        aColumnTextColumn.HeaderText = "确认"
        aColumnTextColumn.AllowNull = False
        aColumnTextColumn.MappingName = "is_check"
        tableStyle.GridColumnStyles.Add(aColumnTextColumn)
        'AddHandler Me.aColumnTextColumn.TextBox.MouseDown, AddressOf dgDetail.MouseDown

        Dim bColumnTextColumn As New DataGridBoolColumn()
        bColumnTextColumn.HeaderText = "关键"
        bColumnTextColumn.AllowNull = False
        bColumnTextColumn.MappingName = "is_important"
        'tableStyle.GridColumnStyles.Add(bColumnTextColumn)

        Dim column_2 As New DataGridTextBoxColumn()
        column_2.ReadOnly = True
        column_2.Width = 0
        column_2.NullText = ""
        column_2.HeaderText = "有文档"
        column_2.MappingName = "is_file"
        'tableStyle.GridColumnStyles.Add(column_2)

        Dim column_3 As New DataGridTextBoxColumn()
        column_3.ReadOnly = True
        column_3.Width = 150
        column_3.NullText = ""
        column_3.HeaderText = "说明"
        column_3.MappingName = "remark"
        tableStyle.GridColumnStyles.Add(column_3)

        Dim column_4 As New DataGridTextBoxColumn()
        column_4.ReadOnly = True
        column_4.NullText = ""
        column_4.HeaderText = "确认人"
        column_4.MappingName = "check_person"
        tableStyle.GridColumnStyles.Add(column_4)

        Dim column_5 As New DataGridTextBoxColumn()
        column_5.ReadOnly = True
        column_5.NullText = ""
        column_5.HeaderText = "日期"
        column_5.MappingName = "check_date"
        tableStyle.GridColumnStyles.Add(column_5)

        Me.dgMaterial.TableStyles.Clear()
        Me.dgMaterial.TableStyles.Add(tableStyle)
    End Sub
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    '获取项目的所有资料
    Private Function getProjectDocument() As DataSet
        Dim strSql As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        If gWs Is Nothing Then
            Exit Function
        End If
        strSql = "{project_code='" & strProjectCode & "' and (item_type='41' or item_type='42'or item_type='45') and check_person is not null order by item_type desc}"
        Try
            ds = gWs.GetProjectDocumentByCondition(strSql)
            ds.Tables("TProjectDocument").Columns.Add("is_check", GetType(Boolean))
            i = ds.Tables("TProjectDocument").Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    dr = ds.Tables("TProjectDocument").Rows(i)
                    With dr
                        If Not .Item("archive_person") Is System.DBNull.Value Then
                            If .Item("archive_person") = "" Then
                                .Item("is_check") = False
                            Else
                                .Item("is_check") = True
                            End If
                        Else
                            .Item("is_check") = False
                        End If
                    End With
                Next
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
        End Try
        Return ds
    End Function
    '提交
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            'If MsgBoxResult.Yes = MsgBox("是否确认提交?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "提示") Then
            If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1000", "提交") Then
                commit()
            End If
        Else
            commit()
        End If
    End Sub
    '提交处理
    Private Sub commit()
        Dim strCommit As String
        Dim strFinishFlag As String
        If Not saveArchive() Then
            Exit Sub
        End If
        strCommit = gWs.finishedTask(strWorkFlowID, strProjectCode, strTaskID, strFinishFlag, strPerson)
        If "1" = strCommit Then
            'MsgBox("提交成功!", MsgBoxStyle.Information, "提示")
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            MyBase.raiseCommitSucceed()
            Me.Close()
        Else
            'MsgBox("提交失败!" & strCommit, MsgBoxStyle.Critical, "提示")
            SWDialogBox.MessageBox.Show("*999", "", strCommit, "")
        End If
    End Sub
    '列表中鼠标按下事件
    Private Sub dgMaterial_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgMaterial.MouseUp
        If Me.dgMaterial.DataSource Is Nothing Then
            Exit Sub
        End If
        If CType(Me.dgMaterial.DataSource, DataTable).Rows.Count > 0 Then
            Me.dgMaterial.Select(Me.dgMaterial.CurrentCell.RowNumber)
            '单击datagrid中的checkbox时改变checked
            Dim rowNum, colNum As Integer
            rowNum = Me.dgMaterial.CurrentCell.RowNumber
            colNum = Me.dgMaterial.CurrentCell.ColumnNumber
            If colNum = 1 Then
                Dim he As DataGrid = CType(sender, DataGrid)
                If he.HitTest(e.X, e.Y).Type <> DataGrid.HitTestType.Cell Then Return
                Me.dgMaterial.Item(rowNum, colNum) = Not Me.dgMaterial.Item(rowNum, colNum)
            End If
        End If
    End Sub
    '获得该项目的归档资料意见
    Private Sub getOpinion()
        Dim strItemType As String = "53"
        Dim strItemCode As String = "005"
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strSql As String
        Try
            strSql = "{project_code='" & strProjectCode & "' and item_type='" & strItemType & "' and item_code='" & strItemCode & "'}"
            ds = gWs.GetProjectOpinionByProjectNo(strSql)
            i = ds.Tables("TProjectOpinion").Rows.Count
            If i > 0 Then
                dr = ds.Tables("TProjectOpinion").Rows(0)
                With dr
                    If Not .Item("content") Is System.DBNull.Value Then
                        Me.txtRemark.Text = .Item("content")
                    End If
                End With
            End If
        Catch
        Finally
        End Try
    End Sub
    '保存归档人和归档时间
    Private Function saveArchive()
        Dim i As Integer
        Dim dr As DataRow
        i = Me.dsMaterial.Tables("TProjectDocument").Rows.Count
        If i > 0 Then
            For i = 0 To i - 1
                dr = Me.dsMaterial.Tables("TProjectDocument").Rows(i)
                With dr
                    If Not .Item("is_check") Is System.DBNull.Value Then
                        '三种状态:true,false,DBNull
                        If .Item("is_check") = True Then
                            .Item("archive_person") = strPerson
                            Try
                                .Item("archive_date") = gWs.GetSysTime()
                            Catch ex As Exception
                                ExceptionHandler.ShowMessageBox(ex)
                            End Try
                        Else
                            .Item("archive_person") = System.DBNull.Value
                            .Item("archive_date") = System.DBNull.Value
                        End If
                    Else
                        .Item("archive_person") = System.DBNull.Value
                        .Item("archive_date") = System.DBNull.Value
                    End If
                End With
            Next
        End If
        Dim strResult As String
        strResult = gWs.UpdateProjectDocument(Me.dsMaterial)
        If strResult = "1" And saveArchiveOpinion() = "1" Then
            'MsgBox("保存成功!", MsgBoxStyle.Information, "提示")
            'SWDialogBox.MessageBox.Show("$SaveSucceed")
            Return True
        Else
            'MsgBox("保存失败!", MsgBoxStyle.Information, "提示")
            SWDialogBox.MessageBox.Show("*999", "", strResult, "")
            Return False
        End If
    End Function
    '保存归档资料意见,item_type:53;item_code:005
    Private Function saveArchiveOpinion()
        Dim strItemType As String = "53"
        Dim strItemCode As String = "005"
        Dim strSql As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer

        Try
            strSql = "{project_code='" & strProjectCode & "' and item_type='" & strItemType & "' and item_code='" & strItemCode & "'}"
            ds = gWs.GetProjectOpinionByProjectNo(strSql)
            i = ds.Tables("TProjectOpinion").Rows.Count
            If i = 0 Then
                dr = ds.Tables("TProjectOpinion").NewRow
                With dr
                    .Item("project_code") = strProjectCode
                    .Item("item_type") = strItemType
                    .Item("item_code") = strItemCode
                    .Item("content") = Me.txtRemark.Text
                    .Item("create_person") = strPerson
                    Try
                        .Item("create_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
                ds.Tables("TProjectOpinion").Rows.Add(dr)
            Else
                dr = ds.Tables("TProjectOpinion").Rows(0)
                With dr
                    .Item("content") = Me.txtRemark.Text
                    .Item("create_person") = strPerson
                    Try
                        .Item("create_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
            End If
            Dim strResult As String
            strResult = gWs.UpdateProjectOpinion(ds)
            Return strResult
        Catch
            Return ""
        Finally
        End Try
    End Function
End Class
