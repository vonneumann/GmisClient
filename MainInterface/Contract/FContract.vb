Imports SZCGC.DocumentManager

Public Class FContract
    Inherits MainInterface.frmBaseWorkflow

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
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgContract As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents btnPrint As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FContract))
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.btnPrint = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgContract = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.project_group.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupQuery.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgContract, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEntery
        '
        Me.btnEntery.Location = New System.Drawing.Point(488, 576)
        Me.btnEntery.Name = "btnEntery"
        '
        'project_group
        '
        Me.project_group.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.project_group.Name = "project_group"
        Me.project_group.Size = New System.Drawing.Size(752, 328)
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn5})
        '
        'dgQueryResult
        '
        Me.dgQueryResult.AccessibleName = "DataGrid"
        Me.dgQueryResult.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgQueryResult.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgQueryResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgQueryResult.Location = New System.Drawing.Point(3, 17)
        Me.dgQueryResult.Name = "dgQueryResult"
        Me.dgQueryResult.Size = New System.Drawing.Size(746, 308)
        '
        'GroupQuery
        '
        Me.GroupQuery.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupQuery.Name = "GroupQuery"
        Me.GroupQuery.Size = New System.Drawing.Size(760, 384)
        '
        'txtCorporation
        '
        Me.txtCorporation.Name = "txtCorporation"
        Me.txtCorporation.Size = New System.Drawing.Size(408, 21)
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnQueryProject
        '
        Me.btnQueryProject.Location = New System.Drawing.Point(672, 15)
        Me.btnQueryProject.Name = "btnQueryProject"
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(488, 576)
        Me.btnExit.Name = "btnExit"
        '
        'btnQuery
        '
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Image)
        Me.btnQuery.ImageIndex = -1
        Me.btnQuery.ImageList = Nothing
        Me.btnQuery.Location = New System.Drawing.Point(312, 576)
        Me.btnQuery.Name = "btnQuery"
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "业务品种"
        Me.DataGridTextBoxColumn5.MappingName = "ServiceType"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 200
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPrint.ImageIndex = 23
        Me.btnPrint.ImageList = Me.ImageListBasic
        Me.btnPrint.Location = New System.Drawing.Point(400, 576)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(77, 23)
        Me.btnPrint.TabIndex = 13
        Me.btnPrint.Text = "预 览(&P)"
        Me.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgContract)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 384)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(760, 184)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        '
        'dgContract
        '
        Me.dgContract.AllowSorting = False
        Me.dgContract.CaptionVisible = False
        Me.dgContract.DataMember = ""
        Me.dgContract.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgContract.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgContract.Location = New System.Drawing.Point(3, 17)
        Me.dgContract.Name = "dgContract"
        Me.dgContract.Size = New System.Drawing.Size(754, 164)
        Me.dgContract.TabIndex = 0
        Me.dgContract.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dgContract
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "Table"
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "合同名称"
        Me.DataGridTextBoxColumn6.MappingName = "doc_name"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 200
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "创建人"
        Me.DataGridTextBoxColumn7.MappingName = "create_person"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "创建时间"
        Me.DataGridTextBoxColumn8.MappingName = "create_time"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "审核人"
        Me.DataGridTextBoxColumn9.MappingName = "check_person"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "审核时间"
        Me.DataGridTextBoxColumn10.MappingName = "check_time"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'FContract
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(776, 606)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FContract"
        Me.Text = "合同管理"
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnPrint, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.btnQuery, 0)
        Me.Controls.SetChildIndex(Me.GroupQuery, 0)
        Me.Controls.SetChildIndex(Me.project_group, 0)
        Me.Controls.SetChildIndex(Me.btnEntery, 0)
        Me.project_group.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupQuery.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgContract, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsTempProject As DataSet
    Private tmpProjectID, strCorporationName As String
    Private iIndex As Integer
    Public Event refreshTaskCommit()
    Private strDir As String = "\Document\" '保存文档的目录
    Private Sub FContract_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '获取项目列表
        'Dim i As Integer
        Dim strSql As String

        '获取项目列表
        'strSql = " SELECT a.ProjectCode, a.EnterpriseName, a.phase, a.status,c.ServiceType,c.workflow" & _
        '         " FROM dbo.ViewProjectInfo_Guaranting AS a,dbo.ViewProjectInfo_SignLoan AS b,dbo.ViewProjectInfo_Review AS c" & _
        '         " WHERE (a.ProjectCode=b.ProjectCode) AND (a.certificate_date IS NULL)" & _
        '         " AND (NOT b.StartTime IS NULL) AND a.ProjectCode=c.ProjectCode AND manager_A='" & UserName & "'"

        '列出未放款的项目经理A为登录人且业务品种不是“保函”，“委托评审”的未终止的项目
        'strSql = " SELECT ProjectCode, EnterpriseName, phase, Status,ServiceType" & _
        '         " FROM dbo.ViewProjectInfo" & _
        '         " WHERE StartTime is null and (isliving = 1) and manager_A='" & UserName & "' and (ServiceType<>'保函' and ServiceType <>'委托评审')"

        'strSql = " SELECT ProjectCode, EnterpriseName, phase, Status,ServiceType" & _
        '         " FROM dbo.queryProjectInfo" & _
        '         " WHERE StartTime is null and (isliving = 1) and manager_A='" & UserName & "' and ServiceType <>'委托评审'"
        strSql = " SELECT ProjectCode, EnterpriseName, phase, Status,ServiceType" & _
                " FROM dbo.queryProjectInfo" & _
                " WHERE  (isliving = 1) "
        dsTempProject = gWs.GetCommonQueryInfo(strSql)
        dgQueryResult.DataSource = dsTempProject.Tables(0).DefaultView

        If dsTempProject.Tables(0).Rows.Count = 0 Then
            MsgBox("无项目列表!", MsgBoxStyle.Information, "合同管理")
            btnEntery.Enabled = False
            btnQuery.Enabled = False
            Exit Sub
        End If

        MyBase.LabelCustomer.Left = MyBase.txtProjectCode.Left + MyBase.txtProjectCode.Width + 20
        MyBase.txtCorporation.Left = MyBase.LabelCustomer.Left + MyBase.LabelCustomer.Width - 10
        MyBase.btnQueryProject.Left = MyBase.txtCorporation.Left + MyBase.txtCorporation.Width + 10
        iIndex = dgQueryResult.CurrentRowIndex
        '获取项目ID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)

        btnEntery.Visible = False
    End Sub

    Private Sub dgQueryResult_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgQueryResult.CurrentCellChanged
        'Static lastRow As Integer = -1
        If dgQueryResult.CurrentRowIndex < 0 Then
            Return
        End If
        iIndex = dgQueryResult.CurrentRowIndex
        '获取项目ID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)
        strCorporationName = dgQueryResult.Item(iIndex, 1)
        'lastRow = dgQueryResult.CurrentRowIndex

        Dim strSql As String = "select * from project_document where project_code='" & tmpProjectID & "' and item_type='43' and check_person is not null"
        Dim ds As DataSet = gWs.GetCommonQueryInfo(strSql)
        dgContract.DataSource = ds.Tables(0)
        setDgAttribute(dgContract, Me)
        setDgDeleteAttribute(dgContract, Me)
    End Sub

    Private Sub btnQueryProject_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnQueryProject.Click
        Dim strSql As String
        Dim tmpProjectCode, tmpCorporation As String
        tmpProjectCode = Trim(txtProjectCode.Text)
        tmpCorporation = Trim(txtCorporation.Text)
        If tmpProjectCode = "" Then
            If tmpCorporation = "" Then
                strSql = ""
            End If
            strSql = "EnterpriseName like '%" & tmpCorporation & "%'"
        Else
            strSql = "ProjectCode like '%" & tmpProjectCode & "%'"
        End If
        dsTempProject.Tables(0).DefaultView.RowFilter = strSql

        Dim index As Integer
        index = Me.dgQueryResult.CurrentRowIndex()

        If index < 0 Then
            Me.btnEntery.Enabled = False
            Me.btnQuery.Enabled = False
            Exit Sub
        Else
            Me.btnEntery.Enabled = True
            Me.btnQuery.Enabled = True
        End If

        '重新获取当前项目编码及其任务列表
        dgQueryResult_CurrentCellChanged(sender, e)
    End Sub

    Private Sub btnEntery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEntery.Click
        Dim response As MsgBoxResult
        Dim strErr As String

        iIndex = dgQueryResult.CurrentRowIndex
        If iIndex < 0 Then
            Return
        End If

        '获取列表当前行的项目ID
        tmpProjectID = dgQueryResult.Item(iIndex, 0)

        response = MsgBox("是否确定要启动合同管理?", MsgBoxStyle.YesNo, "合同管理")

        '调用cancelProcess方法取消所选项目的工作流
        If response = MsgBoxResult.Yes Then

            strErr = gWs.CreateProcess("合同管理", Trim(tmpProjectID), UserName, String.Empty)
            If strErr = "1" Then
                MsgBox("启动合同管理成功!", MsgBoxStyle.Information, "合同管理")
                dsTempProject.Tables(0).Rows(iIndex).Delete()
                dsTempProject.AcceptChanges()

                'AssignValuator_Update
                '以前所分配的分配评估师,确认评估日期,资产评估任务记录要删除掉(分配评估师,确认评估日期,资产评估)
                Dim strSql As String = ""
                strSql = "delete from project_task_attendee where project_code=" & "'" & Me.txtProjectCode.Text & "'" & " and role_id='34'" & " and task_id in ('AssignValuator','AffirmEvaluateDate','CapitialEvaluated')  "
                gWs.GetCommonQueryInfo(strSql)

                RaiseEvent refreshTaskCommit()
            Else
                MsgBox("启动合同管理失败:" & strErr, MsgBoxStyle.Critical, "合同管理")
            End If
        Else
            Exit Sub
        End If
    End Sub


    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim index As Integer
        Dim strRelationNum As String
        Dim strSerialNum As String
        index = dgContract.CurrentRowIndex
        If index < 0 Then
            Exit Sub
        End If

        '2008-3-5 YJF ADD 判断是否为系统制作的PDF合同,如果是则使用PDF制作并打开
        Dim dtFiles As DataTable = CType(dgContract.DataSource, DataTable)
        If Not dtFiles.Rows(index).Item("serial_num") Is System.DBNull.Value Then
            strSerialNum = dtFiles.Rows(index).Item("serial_num")
            Dim strContractName As String = dtFiles.Rows(index).Item("doc_name")
            Dim strItemType As String = dtFiles.Rows(index).Item("item_type")
            Dim strItemCode As String = dtFiles.Rows(index).Item("item_code")

            Dim dsTempItem As DataSet = gWs.GetItemEx("{item_type='" & strItemType & "' and item_code='" & strItemCode & "'}")
            Dim strPDFRemark = IIf(IsDBNull(dsTempItem.Tables(0).Rows(0).Item("additional_remark")), "", dsTempItem.Tables(0).Rows(0).Item("additional_remark"))
            If strPDFRemark = "PDF" Then
                PrintPDF(Me.tmpProjectID, strItemType, strItemCode, strContractName)
                Exit Sub
            End If
        End If

        Dim strFileName As String = dtFiles.Rows(index).Item("title")
        If Not dtFiles.Rows(index).Item("relation_num") Is System.DBNull.Value Then
            strRelationNum = dtFiles.Rows(index).Item("relation_num")
            strSerialNum = dtFiles.Rows(index).Item("serial_num")
        Else
            'MsgBox("该记录未保存文件内容!不能打开文件.", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$X019")
            Exit Sub
        End If
        If Not System.IO.Directory.Exists(Application.StartupPath & strDir) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & strDir)
        Else
            delAllFiles(Application.StartupPath & strDir)
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim docClass As New frmDocumentClass(strCorporationName)
            docClass.openFileBySerial(strSerialNum, strDir)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        'If dgQueryResult.CurrentRowIndex < 0 Then
        '    Return
        'End If
        'If dgContract.CurrentRowIndex < 0 Then
        '    Return
        'End If

        ''获取所选记录的项目编码、合同类型、合同编码、合同名称
        'Dim iIndex As Integer = dgContract.CurrentRowIndex
        'Dim dr As DataRow = CType(dgContract.DataSource, DataTable).Rows(iIndex)
        'Dim strItemType As String = dr.Item("item_type")
        'Dim strItemCode As String = dr.Item("item_code")
        'Dim strItemTpeItemCode As String = strItemType & strItemCode
        'Dim strProjectCode As String = dr.Item("project_code")
        'Dim strContractName As String = dr.Item("doc_name")

        ''获取项目合同要素
        'Dim strSql As String = "{project_code='" & strProjectCode & "' and item_type='" & strItemType & "' and item_code='" & strItemCode & "'}"
        'Dim dsProjectContractElement, dsProjectContractEstate, dsProjectContractChattel, dsProjectContractCar As DataSet
        'dsProjectContractElement = gWs.GetProjectContractElementInfo(strSql)

        'strSql = "{project_code='" & strProjectCode & "' and contract_name='" & Trim(strContractName) & "'}"
        'dsProjectContractEstate = gWs.GetProjectContractEstateElementInfo(strSql)
        'dsProjectContractChattel = gWs.GetProjectContractChattelElementInfo(strSql)
        'dsProjectContractCar = gWs.GetProjectContractCarElementInfo(strSql)

        'Me.Cursor = Cursors.WaitCursor

        'Dim objDoc As New CCWordApp()

        ''删除DOCUMENT目录所有的文件；
        'Dim strPath As String = Application.StartupPath & strDir
        'delAllFiles(strPath)

        ''获取合同模板
        'Dim ds As DataSet
        'Dim docType As String
        'Dim i As Integer
        'Try
        '    ds = gWs.GetFileTemplateByCondition("{item_type='" & strItemType & "' and item_code ='" & strItemCode & "' and is_current_ver='1' order by version DESC}")
        '    i = ds.Tables("TFileTemplate").Rows.Count
        '    If i > 0 Then
        '        With ds.Tables("TFileTemplate").Rows(0)
        '            If Not .Item("template") Is System.DBNull.Value Then
        '                Me.Cursor = Cursors.WaitCursor
        '                Dim data As Byte() = .Item("template")
        '                docType = .Item("doc_type")
        '                docType = docType.Trim
        '                Dim myfilestream As System.IO.FileStream
        '                Dim strTemp As String
        '                Dim isThread As Boolean = False

        '                strTemp = Trim(strContractName) 'getLegalFileName(Me.txtCorporationName.Text) & Me.txtContractName.Text ' qxd add 2003-10-30
        '                strPath = Application.StartupPath & strDir & strTemp
        '                If docType.Trim = "doc" Then
        '                    strPath = strPath & ".doc"
        '                End If
        '                '判断文件是否存在,如果存在则删除;如果删除出错,说明文件已经被另一进程占用了.则不创建新的文件
        '                If System.IO.File.Exists(strPath) Then
        '                    Try
        '                        System.IO.File.Delete(strPath)
        '                    Catch
        '                        isThread = True
        '                    End Try
        '                End If
        '                If Not isThread Then
        '                    'myfilestream = New System.IO.FileStream(strPath, IO.FileMode.Create, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite)
        '                    myfilestream = New System.IO.FileStream(strPath, IO.FileMode.Create)
        '                    myfilestream.Write(data, 0, data.Length)
        '                    myfilestream.Close()
        '                End If

        '                Dim j As Integer


        '                If docType.Trim = "doc" Then
        '                    'word1 = New Word.ApplicationClass()
        '                    'word1.Application.Documents.Add(strPath)
        '                    ''qxd modify 2003-10-30
        '                    ''word1.ActiveDocument.SaveAs(strPath)
        '                    'word1.Caption = strTemp
        '                    ''qxd end 
        '                    'word1.Application.Visible = True
        '                    objDoc.Open(strPath)
        '                End If
        '                'Else

        '                '    'MsgBox("当前版本《" & strFileType & "》的模板文件不存在!", MsgBoxStyle.Exclamation, "提示")
        '                '    'SWDialogBox.MessageBox.Show("$2002", strFileType)
        '                '    Dim strMessage As String = "当前版本《" & Me.txtContractName.Text & "》的文件模板不存在!"
        '                '    SWDialogBox.MessageBox.Show(strMessage, "系统提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
        '            End If
        '        End With
        '    End If
        'Catch ex As Exception
        '    '关闭打开的文件
        '    objDoc.Quit()
        '    'MsgBox("文件已经打开或文件有误!", MsgBoxStyle.Exclamation, "提示")
        '    ExceptionHandler.ShowMessageBox(ex)
        '    Exit Sub
        'Finally
        '    Me.Cursor = Cursors.Default
        '    GC.Collect()
        'End Try




        ''将项目合同要素替换合同模板的BOOKMARK标记；
        'Dim objDocGernerate As New DocumentGenerator()
        'Try
        '    objDocGernerate.GenerateDocument(dsProjectContractElement, dsProjectContractEstate, dsProjectContractChattel, dsProjectContractCar, objDoc)
        'Catch
        'End Try

        ''保存生成的合同WORD文档；
        'objDoc.SaveAs(strPath)

        'objDoc.Quit()

        ''将合同的WORD文档转换为PDF文档并打开；
        'objDoc.SaveAsPdf(strPath)

        'objDoc = Nothing
        'Me.Cursor = Cursors.Default
    End Sub
End Class
