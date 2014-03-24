

Public Class frmFraternityAffirm
    Inherits MainInterface.frmBasic

    Private strWorkFlowID As String
    Private strProjectCode As String
    Private strCorporationName As String
    Private strTaskID As String
    Private strPerson As String
    Private strPhase As String

    Private strItemType As String = "44"
    Private strItemCode As String = "011" '44011为互助会手续办理确认

    Private dsMaterial As DataSet

    Private systemTime As Date
    Private Const STREXEMPT As String = "豁免"

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
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgMaterial As System.Windows.Forms.DataGrid
    Public WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkExempt As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFraternityAffirm))
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgMaterial = New System.Windows.Forms.DataGrid()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkExempt = New System.Windows.Forms.CheckBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnExit.Location = New System.Drawing.Point(302, 352)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(214, 352)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 8
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgMaterial})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(576, 304)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "互助会确认材料"
        '
        'dgMaterial
        '
        Me.dgMaterial.CaptionVisible = False
        Me.dgMaterial.DataMember = ""
        Me.dgMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMaterial.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMaterial.Location = New System.Drawing.Point(3, 17)
        Me.dgMaterial.Name = "dgMaterial"
        Me.dgMaterial.Size = New System.Drawing.Size(570, 284)
        Me.dgMaterial.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtName.Location = New System.Drawing.Point(328, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(256, 21)
        Me.txtName.TabIndex = 13
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(264, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 8)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(152, 21)
        Me.txtCode.TabIndex = 11
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkExempt
        '
        Me.chkExempt.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.chkExempt.Location = New System.Drawing.Point(16, 352)
        Me.chkExempt.Name = "chkExempt"
        Me.chkExempt.Size = New System.Drawing.Size(48, 24)
        Me.chkExempt.TabIndex = 14
        Me.chkExempt.Text = "豁免"
        '
        'frmFraternityAffirm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(596, 383)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.chkExempt, Me.txtName, Me.Label2, Me.txtCode, Me.Label1, Me.GroupBox2, Me.btnCommit, Me.btnExit})
        Me.Name = "frmFraternityAffirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "互助会手续办妥确认"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub frmFraternity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.strProjectCode = Me.getProjectCode()
        Me.strCorporationName = Me.getCorporationName()
        Me.strWorkFlowID = Me.getWorkFlowID()
        Me.strTaskID = Me.getTaskID()
        Me.strPerson = Me.getUser()
        Me.strPhase = getPhase(strProjectCode)

        Me.txtCode.Text = Me.strProjectCode
        Me.txtName.Text = Me.strCorporationName

        Me.setChkExempt() '设置chbexempt的初始值

        Try
            Me.dsMaterial = Me.getMaterial()
            If Not Me.dsMaterial Is Nothing Then
                Me.dgMaterial.DataSource = Me.dsMaterial.Tables("TProjectDocument")
                setDgAttribute(Me.dgMaterial, Me)
                Me.addStyle(Me.dsMaterial)
            End If
            systemTime = gWs.GetSysTime()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
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

        If Not Me.addProjectDocument() Then
            Exit Sub
        End If

        If Not Me.Affirm Then
            Exit Sub
        End If

        Dim strCommit As String
        Try
            strCommit = gWs.finishedTask(strWorkFlowID, strProjectCode, strTaskID, "", strPerson)
            If "1" = strCommit Then
                'MsgBox("提交成功!", MsgBoxStyle.Information, "提示")
                SWDialogBox.MessageBox.Show("$SubmitSucceed")
                raiseCommitSucceed()
                Me.Close()
            Else
                'MsgBox("提交失败!" & strCommit, MsgBoxStyle.Critical, "提示")
                SWDialogBox.MessageBox.Show("*999", "", strCommit, "")
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    '
    '确认时,若记录已经存在,则修改确认记录;否则新增一条记录
    '保存在表project_document中
    '
    Private Function addProjectDocument() As Boolean
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strResult As String
        Try
            ds = gWs.GetProjectDocumentByCondition("{project_code='" & Me.strProjectCode & "' and item_type='" & Me.strItemType & "' and item_code='" & Me.strItemCode & "'}")
        Catch ex As Exception
            'MsgBox("获取project_document时出错!" & ex.Message, MsgBoxStyle.Critical, "提示")
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        If ds Is Nothing Then
            Return False
        End If

        i = ds.Tables("TProjectDocument").Rows.Count
        'If Me.isOneAffirm() Then
        If i = 1 Then
            dr = ds.Tables("TProjectDocument").Rows(0)
            With dr
                .Item("phase") = strPhase
                .Item("check_person") = strPerson
                .Item("check_date") = systemTime
                If Me.chkExempt.Checked Then
                    .Item("remark") = Me.STREXEMPT
                Else
                    .Item("remark") = ""
                End If
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
                .Item("check_date") = systemTime
                .Item("create_person") = strPerson
                .Item("create_date") = systemTime
                If Me.chkExempt.Checked Then
                    .Item("remark") = Me.STREXEMPT
                Else
                    .Item("remark") = ""
                End If
            End With
            ds.Tables("TProjectDocument").Rows.Add(dr)
        End If
        'Else
        'If i = 1 Then
        '    ds.Tables("TProjectDocument").Rows(0).Delete()
        'End If
        'End If

        strResult = gWs.UpdateProjectDocument(ds)
        If strResult = "1" Then
            Return True
        Else
            SWDialogBox.MessageBox.Show("*999", "", strResult, "")
            Return False
        End If

    End Function

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
        column_1.Width = 400
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
        'AddHandler Me.aColumnTextColumn.TextBox.MouseDown, AddressOf dgmaterial.MouseDown

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

    '功能:获取这些互助材料信息,返回dataset
    '
    '详细:从project_document中取得,如果不存在,则先从item表中拷入所有item_type=48
    Private Function getMaterial() As DataSet
        Dim strSql As String
        Dim ds As DataSet
        Dim i As Int16

        strSql = "{project_code='" & Me.strProjectCode & "'and item_type='48'}"
        Try
            ds = gWs.GetProjectDocumentByCondition(strSql)
            If ds Is Nothing Then
                MyMsgBox("获取数据出现错误，请退出！")
                Return Nothing
            End If
            If ds.Tables("TProjectDocument").Rows.Count = 0 Then
                copyToDocument()
                ds = gWs.GetProjectDocumentByCondition(strSql)
            End If

            ds.Tables("TProjectDocument").Columns.Add("is_check", GetType(Boolean))

            For i = 0 To ds.Tables("TProjectDocument").Rows.Count - 1
                If Not ds.Tables("TProjectDocument").Rows(i).Item("check_person") Is System.DBNull.Value And _
                   Not ds.Tables("TProjectDocument").Rows(i).Item("check_date") Is System.DBNull.Value Then

                    ds.Tables("TProjectDocument").Rows(i).Item("is_check") = True
                Else
                    ds.Tables("TProjectDocument").Rows(i).Item("is_check") = False
                End If
            Next i

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        Return ds

    End Function

    '功能:从item表中把item_type=48的拷入project_document中
    Private Sub copyToDocument()
        Dim dsfrom As DataSet
        Dim dsto As DataSet
        Dim i As Int16
        Try
            dsfrom = gWs.GetItem("%", "48") '取得互助会材料信息
            dsto = gWs.GetProjectDocumentByCondition("null")
            Dim len As Int16 = dsfrom.Tables("titem").Rows.Count
            For i = 0 To len - 1
                Dim drfrom As DataRow = dsfrom.Tables(0).Rows(i)
                Dim dr As DataRow = dsto.Tables("TProjectDocument").NewRow
                With dr
                    .Item("project_code") = Me.strProjectCode
                    .Item("phase") = Me.getPhase(Me.strProjectCode)
                    .Item("item_code") = drfrom.Item("item_code")
                    .Item("item_type") = drfrom.Item("item_type")
                    .Item("doc_name") = drfrom.Item("item_name")
                    .Item("create_person") = Me.strPerson
                    .Item("create_date") = gWs.GetSysTime
                End With
                dsto.Tables("TProjectDocument").Rows.Add(dr)
            Next
            gWs.UpdateProjectDocument(dsto.GetChanges(DataRowState.Added))
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '功能:保存确认相
    Private Function Affirm() As Boolean
        Dim i As Int16
        Dim strResult As String
        Dim dr As DataRow
        If Me.dsMaterial Is Nothing Then
            Return False
        End If

        Try
            For i = 0 To Me.dsMaterial.Tables("TProjectDocument").Rows.Count - 1
                dr = dsMaterial.Tables("TProjectDocument").Rows(i)
                If dr.Item("is_check") Then
                    dr.Item("check_person") = Me.strPerson
                    dr.Item("check_date") = gWs.GetSysTime
                Else
                    dr.Item("check_person") = System.DBNull.Value
                    dr.Item("check_date") = System.DBNull.Value
                End If
            Next
            strResult = gWs.UpdateProjectDocument(Me.dsMaterial.GetChanges(DataRowState.Modified))
            If strResult = "1" Then
                Return True
            Else
                SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                Return False
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            Return False
        End Try
    End Function

    '设置豁免chbExempt的初始值
    Private Sub setChkExempt()
        Dim strSql As String = "{project_code='" & Me.strProjectCode & "' and item_type='" & Me.strItemType & "' and item_code='" & Me.strItemCode & "'}"
        Dim ds As DataSet
        Try
            ds = gWs.GetProjectDocumentByCondition(strSql)
            If Not ds Is Nothing Then
                Dim i As Int16 = ds.Tables("TProjectDocument").Rows.Count
                If i > 0 Then
                    If Not ds.Tables("TProjectDocument").Rows(0).Item("remark") Is System.DBNull.Value Then
                        If ds.Tables("TProjectDocument").Rows(0).Item("remark") = Me.STREXEMPT Then
                            Me.chkExempt.Checked = True
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '是否有一个确认
    Private Function isOneAffirm() As Boolean
        If Me.dgMaterial.DataSource Is Nothing Then
            Return False
        End If

        Dim dt As DataTable = CType(Me.dgMaterial.DataSource, DataTable)
        Dim i As Int16 = dt.Rows.Count
        For i = 0 To i - 1
            If dt.Rows(i).Item("is_check") Then
                Return True
            End If
        Next
        Return False
    End Function

    '列表中鼠标按下事件
    Private Sub dgmaterial_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgMaterial.MouseUp
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

End Class
