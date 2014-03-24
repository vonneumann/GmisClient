Public Class frmInsuraceAffirm

    Inherits MainInterface.frmBasic

    Private strProjectCode As String
    Private strCorporationName As String
    Private strTaskID As String
    Private strWorkFlowID As String
    Private strPerson As String
    Private strOppForm As String '担保措施
    Private strItemType As String = "44"
    Private strItemCode As String '具体那种附加反担保措施
    Private isNew As Boolean
    Private strPhase As String = " "
    Private strStatus As String = "评审通过"
    Dim dsTemp As DataSet


#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub
    ''重载构造函数
    'Public Sub New(ByVal projectCode As String, ByVal corporationName As String, ByVal oppForm As String)
    '    Me.New()
    '    Me.isNew = True
    '    Me.strProjectCode = projectCode
    '    Me.strCorporationName = corporationName
    '    Me.strOppForm = oppForm
    '    If oppForm.StartsWith("保险") Then
    '        Me.Text = "保险确认"
    '    End If
    'End Sub
    'Public Sub New(ByVal oppForm As String)
    '    Me.New()
    '    Me.strOppForm = oppForm
    '    If oppForm.StartsWith(" 保险") Then
    '        Me.Text = "保险确认"
    '    End If
    'End Sub


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
    Friend WithEvents dgOppGuarantee As System.Windows.Forms.DataGrid
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgAdditional As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInsuraceAffirm))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgOppGuarantee = New System.Windows.Forms.DataGrid()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgAdditional = New System.Windows.Forms.DataGrid()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgAdditional, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.btnExit.Location = New System.Drawing.Point(323, 408)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgOppGuarantee})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(616, 160)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "独立反担保措施"
        '
        'dgOppGuarantee
        '
        Me.dgOppGuarantee.CaptionVisible = False
        Me.dgOppGuarantee.DataMember = ""
        Me.dgOppGuarantee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOppGuarantee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgOppGuarantee.Location = New System.Drawing.Point(3, 17)
        Me.dgOppGuarantee.Name = "dgOppGuarantee"
        Me.dgOppGuarantee.Size = New System.Drawing.Size(610, 140)
        Me.dgOppGuarantee.TabIndex = 0
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(235, 408)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 12
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtname
        '
        Me.txtname.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtname.Location = New System.Drawing.Point(375, 8)
        Me.txtname.Name = "txtname"
        Me.txtname.ReadOnly = True
        Me.txtname.Size = New System.Drawing.Size(248, 21)
        Me.txtname.TabIndex = 9
        Me.txtname.Text = ""
        '
        'txtcode
        '
        Me.txtcode.Location = New System.Drawing.Point(72, 8)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.ReadOnly = True
        Me.txtcode.Size = New System.Drawing.Size(160, 21)
        Me.txtcode.TabIndex = 8
        Me.txtcode.Text = ""
        '
        'Label2
        '
        Me.Label2.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label2.Location = New System.Drawing.Point(312, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "企业名称"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "项目编码"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgAdditional})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(616, 192)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "附加反担保措施"
        '
        'dgAdditional
        '
        Me.dgAdditional.CaptionVisible = False
        Me.dgAdditional.DataMember = ""
        Me.dgAdditional.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgAdditional.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgAdditional.Location = New System.Drawing.Point(3, 17)
        Me.dgAdditional.Name = "dgAdditional"
        Me.dgAdditional.Size = New System.Drawing.Size(610, 172)
        Me.dgAdditional.TabIndex = 1
        '
        'frmInsuraceAffirm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(634, 439)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.txtname, Me.txtcode, Me.Label2, Me.Label1, Me.btnCommit, Me.GroupBox2, Me.btnExit})
        Me.Name = "frmInsuraceAffirm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "保险手续确认"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgAdditional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Load（）
    Private Sub frmLawTextAffirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Not isNew Then
            Me.strProjectCode = Me.getProjectCode()
            Me.strCorporationName = Me.getCorporationName()
            Me.strWorkFlowID = Me.getWorkFlowID()
            Me.strTaskID = Me.getTaskID()
            Me.strPerson = Me.getUser
            strPhase = Me.getPhase(Me.strProjectCode)
        End If

        Me.txtcode.Text = Me.strProjectCode
        Me.txtname.Text = Me.strCorporationName

        Me.selectAffirm() '选择是那种附加反担保措施

        '设置dg的数据源
        Me.getOppInfo()
    End Sub
    '设置担保措施strOppForm
    Public Sub setOppForm(ByVal oppForm As String)
        Me.strOppForm = oppForm
    End Sub
    '初始化开始确认是那种确认
    Private Sub selectAffirm()
        Select Case Me.Text.Substring(0, 2)
            Case "保险"
                Me.strItemCode = "008"
                Me.strOppForm = "保险"
            Case "预典"
                Me.strItemCode = "009"
                Me.strOppForm = "预典当"
            Case "法律"
                Me.strItemCode = "014"
                Me.strOppForm = "法律文本"
        End Select
    End Sub

    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
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

        Try
            If Not Me.Affirm() Then '保存确认相
                Exit Sub
            End If

            If Not Me.AddProjectDocument() Then  '保存TProjectGuaranteeForm状态并插入一条记录到project_document
                Exit Sub
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try


        Dim strCommit As String
        Try
            strCommit = gWs.finishedTask(strWorkFlowID, strProjectCode, strTaskID, "", strPerson)
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If "1" = strCommit Then
            'MsgBox("提交成功!", MsgBoxStyle.Information, "提示")
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            raiseCommitSucceed()
            Me.Close()
        Else
            'MsgBox("提交失败!" & strCommit, MsgBoxStyle.Critical, "提示")
            SWDialogBox.MessageBox.Show("*999", "", strCommit, "")
        End If
    End Sub
    '获得反担保物记录
    Private Sub getOppInfo()

        Try
            dsTemp = gWs.GetProjectGuaranteeFormAdditional(Me.strProjectCode, Me.strItemType, Me.strItemCode)
            If Not dsTemp Is Nothing Then

                Dim i As Int16
                Dim dr As DataRow

                dsTemp.Tables("TProjectGuaranteeForm").Columns.Add("type_name")
                dsTemp.Tables("TProjectGuaranteeFormAdditional").Columns.Add("type_name")

                i = dsTemp.Tables(0).Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = dsTemp.Tables(0).Rows(i)

                        If Not dr.Item("guaranty") Is System.DBNull.Value Then
                            dr.Item("type_name") = getItemName(dr.Item("guaranty"))
                        Else
                            dr.Item("type_name") = ""
                        End If

                        If dr.Item("is_checked") Is System.DBNull.Value Then
                            dr.Item("is_checked") = False
                        End If
                    Next
                End If

                i = dsTemp.Tables(1).Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = dsTemp.Tables(1).Rows(i)

                        dr.Item("type_name") = getItemName(dr.Item("guaranty"))

                        If dr.Item("is_checked") Is System.DBNull.Value Then
                            dr.Item("is_checked") = False
                        End If
                    Next
                End If

                addStyle1(dsTemp)
                addStyle2(dsTemp)

                Me.dgOppGuarantee.DataSource = dsTemp.Tables("TProjectGuaranteeForm")
                Me.dgAdditional.DataSource = dsTemp.Tables("TProjectGuaranteeFormAdditional")

                setDgAttribute(Me.dgOppGuarantee, Me)
                setDgAttribute(Me.dgAdditional, Me)

            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
        End Try
    End Sub

    '获取对应的Item名称
    Private Function getItemName(ByVal strItemType As String) As String
        Dim ds As DataSet = gWs.GetItemType("{item_type='" & strItemType & "'}")
        If ds.Tables("TItemType").Rows.Count > 0 Then
            Return ds.Tables("TItemType").Rows(0).Item("type_name")
        Else
            Return ""
        End If
    End Function

    '添加datagrid的style
    Private Sub addStyle1(ByVal ds As DataSet)
        Dim tableStyle As DataGridTableStyle = New DataGridTableStyle()
        tableStyle.MappingName = "TProjectGuaranteeForm"
        tableStyle.AllowSorting = False
        tableStyle.RowHeadersVisible = True

        Dim numCols As Integer = ds.Tables("TProjectGuaranteeForm").Columns.Count
        Dim dgc As New DataGridColoredBoolColumn()
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf dgc.MyGetColorRowCol)


        Dim bColumnTextColumn As DataGridColoredBoolColumn
        bColumnTextColumn = New DataGridColoredBoolColumn(d, 0)
        bColumnTextColumn.HeaderText = "确认"
        bColumnTextColumn.AllowNull = False
        bColumnTextColumn.MappingName = "is_checked"
        tableStyle.GridColumnStyles.Add(bColumnTextColumn)


        Dim column_3 As New DataGridTextBoxColumn()
        column_3.ReadOnly = True
        column_3.NullText = ""
        column_3.HeaderText = "类型"
        column_3.MappingName = "type_name"
        tableStyle.GridColumnStyles.Add(column_3)

        Dim column_4 As New DataGridTextBoxColumn()
        column_4.ReadOnly = True
        column_4.NullText = ""
        column_4.HeaderText = "反担保形式"
        column_4.MappingName = "guarantee_form"
        tableStyle.GridColumnStyles.Add(column_4)

        Dim column_5 As New DataGridTextBoxColumn()
        column_5.ReadOnly = True
        column_5.NullText = "0"
        column_5.HeaderText = "反担保金额"
        column_5.MappingName = "guarantee_sum"
        tableStyle.GridColumnStyles.Add(column_5)


        Dim column_6 As New DataGridTextBoxColumn()
        column_6.ReadOnly = True
        column_6.NullText = ""
        column_6.HeaderText = "备注"
        column_6.Width = 250
        column_6.MappingName = "description"
        tableStyle.GridColumnStyles.Add(column_6)

        Me.dgOppGuarantee.TableStyles.Clear()
        Me.dgOppGuarantee.TableStyles.Add(tableStyle)
    End Sub
    '添加datagrid的style
    Private Sub addStyle2(ByVal ds As DataSet)
        Dim tableStyle As DataGridTableStyle = New DataGridTableStyle()
        tableStyle.MappingName = "TProjectGuaranteeFormAdditional"
        tableStyle.AllowSorting = False
        tableStyle.RowHeadersVisible = True

        Dim numCols As Integer = ds.Tables("TProjectGuaranteeFormAdditional").Columns.Count
        Dim dgc As New DataGridColoredBoolColumn()
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf dgc.MyGetColorRowCol)

        Dim bColumnTextColumn As DataGridColoredBoolColumn
        bColumnTextColumn = New DataGridColoredBoolColumn(d, 0)
        bColumnTextColumn.HeaderText = "确认"
        bColumnTextColumn.AllowNull = False
        bColumnTextColumn.MappingName = "is_checked"
        tableStyle.GridColumnStyles.Add(bColumnTextColumn)

        Dim column_3 As New DataGridTextBoxColumn()
        column_3.ReadOnly = True
        column_3.NullText = ""
        column_3.HeaderText = "类型"
        column_3.MappingName = "type_name"
        tableStyle.GridColumnStyles.Add(column_3)

        Dim column_4 As New DataGridTextBoxColumn()
        column_4.ReadOnly = True
        column_4.NullText = ""
        column_4.HeaderText = "反担保形式"
        column_4.MappingName = "guarantee_form"
        tableStyle.GridColumnStyles.Add(column_4)

        Dim column_7 As New DataGridTextBoxColumn()
        column_7.ReadOnly = True
        column_7.NullText = ""
        column_7.HeaderText = "附加反担保形式"
        column_7.Width = 100
        column_7.MappingName = "additional_guarantee_form"
        tableStyle.GridColumnStyles.Add(column_7)


        Me.dgAdditional.TableStyles.Clear()
        Me.dgAdditional.TableStyles.Add(tableStyle)
    End Sub

    Private Function AddProjectDocument() As Boolean  '用于提交时保存所有的确认相及向project_document中增加一条记录
        Dim ds As DataSet = CType(Me.dgAdditional.DataSource, DataTable).DataSet
        Dim dsProjectDocument As DataSet
        Dim i As Int16

        '存在一条记录的is_check为true,则添加或修改Project_document表
        Dim strSql As String = "{project_code='" & Me.strProjectCode & "' and item_type='" & Me.strItemType & "' and item_code='" & Me.strItemCode & "'}"
        dsProjectDocument = gWs.GetProjectDocumentByCondition(strSql)
        i = dsProjectDocument.Tables("TProjectDocument").Rows.Count
        If Me.isOneAffirm(ds) Then
            Dim dr As DataRow
            If i = 1 Then
                dr = dsProjectDocument.Tables("TprojectDocument").Rows(0)
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
                dr = dsProjectDocument.Tables("TProjectDocument").NewRow
                With dr
                    .Item("project_code") = strProjectCode
                    .Item("phase") = strPhase
                    .Item("item_type") = Me.strItemType
                    .Item("item_code") = Me.strItemCode
                    .Item("doc_name") = Me.Text
                    .Item("check_person") = strPerson
                    Try
                        .Item("check_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                    .Item("create_person") = strPerson
                    Try
                        .Item("create_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
                dsProjectDocument.Tables("TProjectDocument").Rows.Add(dr)
            End If
        Else '删除记录
            If i = 1 Then
                dsProjectDocument.Tables("TProjectDocument").Rows(0).Delete()
            End If
        End If
        Dim strResult As String = gWs.UpdateProjectDocument(dsProjectDocument)
        If strResult = "1" Then
            Return True
        Else
            SWDialogBox.MessageBox.Show("*999", "", strResult, "")
            Return False
        End If

    End Function


    '判断是否存在记录确认
    Private Function isOneAffirm(ByVal dsDg As DataSet)
        Dim i As Int16 = dsDg.Tables("TProjectGuaranteeFormAdditional").Rows.Count

        For i = 0 To i - 1
            If dsDg.Tables("TProjectGuaranteeFormAdditional").Rows(i).Item("is_checked") = True Then
                Return True
            End If
        Next
        Return False
    End Function

    '保存确认相
    Private Function Affirm() As Boolean
        Dim strReturn As String
        strReturn = gWs.UpdateProjectGuaranteeForm(dsTemp)
        If strReturn = "1" Then
            dsTemp.Tables("TProjectGuaranteeForm").AcceptChanges()
            strReturn = gWs.UpdateProjectGuaranteeFormAdd(dsTemp)
        Else
            SWDialogBox.MessageBox.Show("*999", "", strReturn, "")
            Return False
        End If

        If strReturn = "1" Then
            dsTemp.Tables("TProjectGuaranteeFormAdditional").AcceptChanges()
            Return True
        Else
            SWDialogBox.MessageBox.Show("*999", "", strReturn, "")
            Return False
        End If
    End Function

    Private Sub dgOppGuarantee_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgOppGuarantee.MouseUp
        If Me.dgOppGuarantee.DataSource Is Nothing Then
            Exit Sub
        End If
        If CType(Me.dgOppGuarantee.DataSource, DataTable).Rows.Count > 0 Then
            '单击datagrid中的checkbox时改变checked
            Dim rowNum, colNum As Integer
            rowNum = Me.dgOppGuarantee.CurrentCell.RowNumber
            colNum = Me.dgOppGuarantee.CurrentCell.ColumnNumber
            If colNum = 0 Then
                Dim he As DataGrid = CType(sender, DataGrid)
                If he.HitTest(e.X, e.Y).Type <> DataGrid.HitTestType.Cell Then Return
                Me.dgOppGuarantee.Item(rowNum, colNum) = Not Me.dgOppGuarantee.Item(rowNum, colNum)
            End If

            Me.dgOppGuarantee.Select(Me.dgOppGuarantee.CurrentCell.RowNumber)
        End If
    End Sub

    Private Sub dgAdditional_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgAdditional.MouseUp

        If Me.dgAdditional.DataSource Is Nothing Then
            Exit Sub
        End If
        If CType(Me.dgAdditional.DataSource, DataTable).Rows.Count > 0 Then
            '单击datagrid中的checkbox时改变checked
            Dim rowNum, colNum As Integer
            rowNum = Me.dgAdditional.CurrentCell.RowNumber
            colNum = Me.dgAdditional.CurrentCell.ColumnNumber
            If colNum = 0 Then
                Dim he As DataGrid = CType(sender, DataGrid)
                If he.HitTest(e.X, e.Y).Type <> DataGrid.HitTestType.Cell Then Return
                Me.dgAdditional.Item(rowNum, colNum) = Not Me.dgAdditional.Item(rowNum, colNum)
            End If

            Me.dgAdditional.Select(Me.dgAdditional.CurrentCell.RowNumber)
        End If
    End Sub

End Class