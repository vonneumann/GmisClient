
Public Class frmMaterialAffirm
    Inherits frmBasic

    Private strProjectCode As String
    Private strCorporationName As String
    Private strWorkFlowID As String = "1"   '工作流ID
    Private strTaskID As String = "1" '任务ID
    Private strPerson As String

    Private strItemType As String = "44" '放款检查列表
    Private strItemCode As String = "001" ' 材料确认
    Private strPhase As String

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
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents dgDetail As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmMaterialAffirm))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgDetail = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnExit.Location = New System.Drawing.Point(361, 472)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgDetail})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(696, 416)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "请确认材料收取"
        '
        'dgDetail
        '
        Me.dgDetail.CaptionVisible = False
        Me.dgDetail.DataMember = ""
        Me.dgDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDetail.Location = New System.Drawing.Point(3, 17)
        Me.dgDetail.Name = "dgDetail"
        Me.dgDetail.Size = New System.Drawing.Size(690, 396)
        Me.dgDetail.TabIndex = 0
        Me.dgDetail.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.DataGrid = Me.dgDetail
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridBoolColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TProjectDocument"
        Me.DataGridTableStyle1.RowHeadersVisible = False
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
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.AllowNull = False
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "是否关键"
        Me.DataGridBoolColumn1.MappingName = "is_important"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), System.DBNull)
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "确认人"
        Me.DataGridTextBoxColumn2.MappingName = "affirm_person"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "日期"
        Me.DataGridTextBoxColumn3.MappingName = "affirm_date"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(273, 472)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 2
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtName.Location = New System.Drawing.Point(352, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(352, 21)
        Me.txtName.TabIndex = 7
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(296, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 8)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(152, 21)
        Me.txtCode.TabIndex = 5
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmMaterialAffirm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 503)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtName, Me.Label2, Me.txtCode, Me.Label1, Me.btnExit, Me.btnCommit, Me.GroupBox2})
        Me.Name = "frmMaterialAffirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "资料收取完毕确认"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    
    'Load()
    Private Sub frmMaterialAffirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.strProjectCode = Me.getProjectCode()
        Me.strCorporationName = Me.getCorporationName()
        Me.strWorkFlowID = Me.getWorkFlowID()
        Me.strTaskID = Me.getTaskID()
        Me.strPerson = Me.getUser()
        Me.txtCode.Text = Me.strProjectCode
        Me.txtName.Text = Me.strCorporationName
        Me.strPhase = getPhase(Me.strProjectCode)
        Dim ds As DataSet = getMaterialDetail()
        If Not ds Is Nothing Then
            Me.dgDetail.DataSource = ds.Tables("TProjectDocument")
            setDgAttribute(Me.dgDetail, Me)
            addStyle(ds)
        End If
    End Sub
    '获得材料的详细信息
    '材料包括:已经确认过的"41"和"42"材料
    Public Function getMaterialDetail() As DataSet

        Dim ds As DataSet
        Dim dr As DataRow
        'item_type为"41"的表示一次材料,"42"表示二次材料
        Try
            Dim strSql As String
            Dim i As Integer
            'strSql = "{project_code='" & strProjectCode & "' and (item_type='41' or item_type='42') and is_important ='1' and not check_person is null}"
            strSql = "{project_code='" & strProjectCode & "' and (item_type='41' or item_type='42') and  (check_date is not null or check_person is not null)}"
            ds = gWs.GetProjectDocumentByCondition(strSql)
            ds.Tables("TProjectDocument").Columns.Add("is_check", GetType(Boolean))
            i = ds.Tables("TProjectDocument").Rows.Count
            For i = 0 To i - 1
                dr = ds.Tables("TProjectDocument").Rows(i)
                With dr
                    If Not .Item("affirm_person") Is System.DBNull.Value And Not .Item("affirm_date") Is System.DBNull.Value Then
                        'If .Item("affirm_person") = "" And .Item("affirm_date") = "" Then
                        .Item("is_check") = True
                        'Else
                        '    .Item("is_check") = False
                        'End If
                    Else
                    .Item("is_check") = False
                    End If

                    If .Item("phase") = "" Then
                        .Item("phase") = "初审"
                    End If
                End With
            Next
            Return ds
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Function
    '添加确认的纪录到project_document表中
    Private Function addProjectDocument() As Boolean
        If gWs Is Nothing Then
            Exit Function
        End If
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strResult As String
        ds = gWs.GetProjectDocumentByCondition("{project_code='" & strProjectCode & "' and item_type='" & strItemType & "' and item_code='" & strItemCode & "'}")
        i = ds.Tables("TProjectDocument").Rows.Count
        If i = 1 Then
            dr = ds.Tables("TProjectDocument").Rows(0)
            With dr
                .Item("phase") = strPhase
                .Item("check_person") = strPerson
                Try
                    .Item("check_date") = gWs.GetSysTime()
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
            End With
        ElseIf i = 0 Then
            dr = ds.Tables("TProjectDocument").NewRow
            With dr
                .Item("project_code") = strProjectCode
                .Item("phase") = strPhase
                .Item("item_type") = strItemType
                .Item("item_code") = strItemCode
                .Item("doc_name") = Me.Text
                .Item("check_person") = strPerson
                Try
                    .Item("check_date") = gWs.GetSysTime()
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
            End With
            ds.Tables("TProjectDocument").Rows.Add(dr)
        End If
        strResult = gWs.UpdateProjectDocument(ds)
        If strResult = "1" Then
            Return True
        Else
            SWDialogBox.MessageBox.Show("*999", "", strResult, "")
            Return False
        End If
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

        'qxd modify 2004-11-19
        '深圳担保中心提出新需求：材料清单的限制过于严格。有些项目不需要材料清单所列材料时不能提交。
        'If Not Me.isAllAffirm() Then
        '    Exit Sub
        'End If

        Dim strResult As String
        strResult = gWs.UpdateProjectDocument(CType(Me.dgDetail.DataSource, DataTable).DataSet)
        If strResult <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "", strResult, "")
            Exit Sub
        End If


        Dim strCommit As String
        Dim strFinishFlag As String = "完整"

        If Not Me.addProjectDocument() Then
            Exit Sub
        End If
        strCommit = gWs.finishedTask(strWorkFlowID, strProjectCode, strTaskID, strFinishFlag, strPerson)
        If "1" = strCommit Then
            'MsgBox("提交成功!", MsgBoxStyle.Information, "提交")
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            raiseCommitSucceed()
            Me.Close()
        Else
            'MsgBox("提交失败!" & strCommit, MsgBoxStyle.Critical, "提交")
            SWDialogBox.MessageBox.Show("*999", "", strCommit, "")
        End If
    End Sub
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
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

        Dim column_1 As New DataGridTextBoxColumn() '1
        column_1.Width = 400
        column_1.ReadOnly = True
        column_1.NullText = ""
        column_1.HeaderText = "资料名称"
        column_1.MappingName = "doc_name"
        tableStyle.GridColumnStyles.Add(column_1)

        Dim aColumnTextColumn As DataGridColoredBoolColumn '2
        aColumnTextColumn = New DataGridColoredBoolColumn(d, 0)
        aColumnTextColumn.HeaderText = "确认"
        aColumnTextColumn.AllowNull = False
        aColumnTextColumn.MappingName = "is_check"
        tableStyle.GridColumnStyles.Add(aColumnTextColumn)
        'AddHandler Me.aColumnTextColumn.TextBox.MouseDown, AddressOf dgDetail.MouseDown

        Dim bColumnTextColumn As New DataGridBoolColumn() '3
        bColumnTextColumn.HeaderText = "关键"
        bColumnTextColumn.AllowNull = False
        bColumnTextColumn.Width = 0
        bColumnTextColumn.MappingName = "is_important"
        tableStyle.GridColumnStyles.Add(bColumnTextColumn)

        Dim column_2 As New DataGridTextBoxColumn() '4
        column_2.ReadOnly = True
        column_2.Width = 0
        column_2.NullText = ""
        column_2.HeaderText = "有文档"
        column_2.MappingName = "is_file"
        'tableStyle.GridColumnStyles.Add(column_2)

        Dim column_20 As New DataGridTextBoxColumn() '5
        column_20.ReadOnly = True
        'column_20.Width = 75
        'column_20.NullText = "初审"
        column_20.HeaderText = "项目阶段"
        column_20.MappingName = "phase"
        tableStyle.GridColumnStyles.Add(column_20)

        Dim column_3 As New DataGridTextBoxColumn() '6
        column_3.ReadOnly = True
        column_3.Width = 150
        column_3.NullText = ""
        column_3.HeaderText = "说明"
        column_3.MappingName = "remark"
        tableStyle.GridColumnStyles.Add(column_3)

        Dim column_4 As New DataGridTextBoxColumn() '7
        column_4.ReadOnly = False
        column_4.NullText = ""
        column_4.HeaderText = "确认人"
        column_4.MappingName = "affirm_person"
        tableStyle.GridColumnStyles.Add(column_4)

        Dim column_5 As New DataGridTextBoxColumn() '8
        column_5.ReadOnly = False
        column_5.NullText = ""
        column_5.HeaderText = "日期"
        column_5.MappingName = "affirm_date"
        tableStyle.GridColumnStyles.Add(column_5)

        Me.dgDetail.TableStyles.Clear()
        Me.dgDetail.TableStyles.Add(tableStyle)
    End Sub
    'KeyPress()
    Private Sub frmMaterialAffirm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
    End Sub
    '列表中鼠标按下事件
    Private Sub dgDetail_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgDetail.MouseUp
        If Me.dgDetail.DataSource Is Nothing Then
            Exit Sub
        End If
        If CType(Me.dgDetail.DataSource, DataTable).Rows.Count > 0 Then
            Me.dgDetail.Select(Me.dgDetail.CurrentCell.RowNumber)
            '单击datagrid中的checkbox时改变checked
            Dim rowNum, colNum As Integer
            rowNum = Me.dgDetail.CurrentCell.RowNumber
            colNum = Me.dgDetail.CurrentCell.ColumnNumber
            If colNum = 1 Then
                Dim he As DataGrid = CType(sender, DataGrid)
                If he.HitTest(e.X, e.Y).Type <> DataGrid.HitTestType.Cell Then Return
                Me.dgDetail.Item(rowNum, colNum) = Not Me.dgDetail.Item(rowNum, colNum)
                If Me.dgDetail.Item(rowNum, colNum) = True Then
                    Me.dgDetail.Item(rowNum, 5) = Me.strPerson
                    Me.dgDetail.Item(rowNum, 6) = gWs.GetSysTime
                Else
                    Me.dgDetail.Item(rowNum, 5) = System.DBNull.Value
                    Me.dgDetail.Item(rowNum, 6) = System.DBNull.Value
                End If
            End If
            End If
    End Sub
    '
    '判断材料是否已确认
    '如果有一个没有确认,则返回true
    '
    Private Function isAllAffirm()
        Dim dt As DataTable
        dt = CType(Me.dgDetail.DataSource, DataTable)

        If Not dt Is Nothing Then
            Dim i As Integer
            Dim dr As DataRow
            Dim isNotChecked As Boolean = False
            Try
                i = dt.Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = dt.Rows(i)
                        With dr
                            If Not .Item("is_check") Is System.DBNull.Value Then
                                If Not .Item("is_check") Then
                                    SWDialogBox.MessageBox.Show("$1009", "未确认的材料")
                                    Return False
                                End If
                            Else
                                Return False
                            End If
                        End With
                    Next
                End If
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try

            Return True
        Else
            Return False
        End If
    End Function


End Class
