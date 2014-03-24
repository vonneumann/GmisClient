Public Class frmDocumentClass

    '
    'Author quexd 
    'Create date 2003-4-10
    '
    Private strCorporationName As String
    Private strFileName As String  '文件名称
    Private strFileType As String '文件类型
    Private isDocument As Boolean = False

    '构造函数
    Public Sub New()
    End Sub
    Public Sub New(ByVal corporationName As String)
        Me.strCorporationName = corporationName
    End Sub
    '设置判断是否时Doc文档
    Public Sub setIsDocument(ByVal isDoc As Boolean)
        Me.isDocument = isDoc
    End Sub
    '
    '上载文件
    'projectCode  项目编码
    'relationNum 文件关联号码
    'itemType 
    'itemCode
    'isSetParameter 是否设置其他参数 ：true ,则弹出一设置对话框；false ,直接保存到project_files 
    '
    Public Function uploadDocument(ByVal projectCode As String, ByVal relationNum As String, ByVal itemType As String, ByVal itemCode As String, ByVal isSetParameter As Boolean, ByVal isWordOrPicture As Boolean, ByVal isWordOrExcel As Boolean)
        Dim data() As Byte
        data = getFileContent("", "Document", isWordOrPicture, isWordOrExcel)
        If Not data Is Nothing Then
            If isSetParameter Then
                Dim docParameter As New frmDocumentParameter()
                docParameter.setProjectCode(projectCode)
                docParameter.setRelationNum(relationNum)
                docParameter.setItemType(itemType)
                docParameter.setItemCode(itemCode)
                docParameter.setFileContent(data)
                docParameter.setFileName(strFileName)
                docParameter.setFileType(strFileType)
                docParameter.AllowTransparency = False
                docParameter.ShowDialog()
                Return docParameter.getResult()
            Else
                Dim ds As DataSet
                Dim dr As DataRow
                Dim strResult As String
                Try
                    ds = gWs.GetProjectFileByCondition("null")
                Catch
                End Try
                If Not ds Is Nothing Then
                    dr = ds.Tables("TProjectFile").NewRow
                    With dr
                        .Item("project_code") = projectCode
                        .Item("item_type") = itemType
                        .Item("item_code") = itemCode
                        .Item("relation_num") = relationNum
                        .Item("document") = data
                        .Item("file_name") = strFileName
                        .Item("file_type") = strFileType
                    End With
                    ds.Tables("TProjectFile").Rows.Add(dr)
                    strResult = gWs.UpdateProjectFile(ds.GetChanges())
                    If "1" = strResult Then
                        'MsgBox("文件上载成功!", MsgBoxStyle.Information, "上载文件")
                        SWDialogBox.MessageBox.Show("$UploadSucceed")
                    Else
                        'MsgBox("文件上载失败!" & strResult, MsgBoxStyle.Critical, "上载文件")
                        SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                    End If
                    Return strResult
                End If
            End If
        End If
    End Function
    '
    '上载文档
    'serialNum ,relationNum
    '
    Public Function uploadDocument(ByVal serialNum As String, ByVal relationNum As String, ByVal isWordOrPicture As Boolean, ByVal isWordOrExcel As Boolean)
        Dim data() As Byte
        data = getFileContent("", "Document", isWordOrPicture, isWordOrExcel)
        If Not data Is Nothing Then
            Dim ds As DataSet
            Dim dr As DataRow
            Dim strResult As String
            Dim strSql As String
            Try
                strSql = "{serial_num='" & serialNum & "'}"
                ds = gWs.GetProjectFileByCondition(strSql)
            Catch
            End Try
            If Not ds Is Nothing Then
                If ds.Tables("TProjectFile").Rows.Count = 1 Then
                    dr = ds.Tables("TProjectFile").Rows(0)
                    With dr
                        If Not relationNum = "" Then
                            .Item("relation_num") = relationNum
                        End If
                        .Item("document") = data
                        .Item("file_name") = strFileName
                        .Item("file_type") = strFileType
                    End With
                    strResult = gWs.UpdateProjectFile(ds.GetChanges())
                    If "1" = strResult Then
                        'MsgBox("文件上载成功!", MsgBoxStyle.Information, "上载文件")
                        SWDialogBox.MessageBox.Show("$UploadSucceed")
                    Else
                        'MsgBox("文件上载失败!" & strResult, MsgBoxStyle.Critical, "上载文件")
                        SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                    End If
                    Return strResult
                End If
            End If
        End If
    End Function

    Public Function uploadDocumentForCheckRecord(ByVal serialNum As String, ByVal relationNum As String, ByVal isWordOrPicture As Boolean, ByVal isWordOrExcel As Boolean)
        Dim data() As Byte
        data = getFileContent("", "Document", isWordOrPicture, isWordOrExcel)
        '2008-5-28 yjf edit 上传保后检查记录表时更新保后检查记录的文档关联编号
        Dim dsCheckRecord As DataSet
        Dim i As Integer

        If Not data Is Nothing Then
            Dim ds As DataSet
            Dim dr As DataRow
            Dim strResult As String
            Dim strSql As String
            Dim strProjectCode As String
            Try
                strSql = "{serial_num='" & serialNum & "'}"
                ds = gWs.GetProjectFileByCondition(strSql)
            Catch
            End Try
            If Not ds Is Nothing Then
                If ds.Tables("TProjectFile").Rows.Count = 1 Then
                    dr = ds.Tables("TProjectFile").Rows(0)
                    With dr
                        '2008-5-28 yjf edit 上传保后检查记录表时更新保后检查记录的文档关联编号
                        strProjectCode = dr.Item("project_code")

                        If Not relationNum = "" Then
                            .Item("relation_num") = relationNum
                        End If
                        .Item("document") = data
                        .Item("file_name") = strFileName
                        .Item("file_type") = strFileType
                    End With

                    '2008-5-28 yjf edit 上传保后检查记录表时更新保后检查记录的文档关联编号
                    strSql = "{project_code='" & strProjectCode & "' and file_relation_num is null}"
                    dsCheckRecord = gWs.GetCheckRecordInfo(strSql, "")
                    For i = 0 To dsCheckRecord.Tables(0).Rows.Count - 1
                        dsCheckRecord.Tables(0).Rows(i).Item("file_relation_num") = serialNum
                    Next
                    strResult = gWs.UpdateCheckRecordAlarm(dsCheckRecord)


                    strResult = gWs.UpdateProjectFile(ds.GetChanges())
                    If "1" = strResult Then
                        'MsgBox("文件上载成功!", MsgBoxStyle.Information, "上载文件")
                        SWDialogBox.MessageBox.Show("$UploadSucceed")
                    Else
                        'MsgBox("文件上载失败!" & strResult, MsgBoxStyle.Critical, "上载文件")
                        SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                    End If
                    Return strResult
                End If
            End If
        End If
    End Function
    '
    '设置打开文件对话框的属性,并返回打开文件的内容
    '返回值类型：Byte()
    '
    Public Function getFileContent(ByVal strDialogTitle As String, ByVal strRelativePath As String, ByVal isWordOrPicture As Boolean, ByVal isWordOrExcel As Boolean)
        Dim uploadFilesDialog As New OpenFileDialog

        If strDialogTitle = "" Then
            uploadFilesDialog.Title = "上载文件到数据库"
        Else
            uploadFilesDialog.Title = strDialogTitle
        End If
        If isWordOrPicture Then
            '"Word文档(*.doc)|*.doc|Excel文档(*.xls)|*.xls|所有文件(*.*)|*.*"
            If isWordOrExcel Then
                uploadFilesDialog.Filter = "Word文档(*.doc)|*.doc|PDF文档(*.pdf)|*.pdf|Excel文档(*.xls)|*.xls|TXT(*.txt)|*.txt|所有文件(*.*)|*.*"
            Else
                'uploadFilesDialog.Filter = "Excel文档(*.xls)|*.xls|Word文档(*.doc)|*.doc|TXT(*.txt)|*.txt|所有文件(*.*)|*.*"
                uploadFilesDialog.Filter = "Excel文档(*.xls)|*.xls|PDF文档(*.pdf)|*.pdf|Word文档(*.doc)|*.doc|TXT(*.txt)|*.txt|所有文件(*.*)|*.*"
            End If
        Else
            uploadFilesDialog.Filter = "JPEG(*.jpg)|*.jpg|GIF(*.gif)|*.gif|位图BMP(*.bmp)|*.bmp|所有文件(*.*)|*.*"
        End If
        uploadFilesDialog.Multiselect = False '不允许多选文件
        If uploadFilesDialog.ShowDialog() = DialogResult.OK Then
            Dim strFileNameTemp, strFileNameAll As String
            strFileNameTemp = uploadFilesDialog.FileName
            strFileNameAll = strFileNameTemp.Substring(strFileNameTemp.LastIndexOf("\") + 1, strFileNameTemp.Length - strFileNameTemp.LastIndexOf("\") - 1)
            Try
                If strFileNameAll.LastIndexOf(".") > 0 Then
                    strFileName = strFileNameAll.Substring(0, strFileNameAll.LastIndexOf("."))
                    strFileType = strFileNameAll.Substring(strFileNameAll.LastIndexOf(".") + 1, strFileNameAll.Length - strFileNameAll.LastIndexOf(".") - 1)
                Else
                    strFileName = strFileNameAll
                    strFileType = "*"
                End If
            Catch
            Finally
            End Try

            Dim myfilestream As System.IO.FileStream
            Dim isReadOnly As Boolean = False

            '如果文件属性为：ReadOnly，则先改为：Normal；然后再改回：ReadOnly
            If System.IO.File.GetAttributes(strFileNameTemp).ToString.ToUpper.StartsWith("ReadOnly".ToUpper) Then
                isReadOnly = True
                System.IO.File.SetAttributes(strFileNameTemp, IO.FileAttributes.Normal) '修改文件的属性为：Normal
            End If

            Try
                'myfilestream = New System.IO.FileStream(strFileNameAll, IO.FileMode.Open, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite)
                myfilestream = New System.IO.FileStream(strFileNameTemp, IO.FileMode.Open, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite)
            Catch ex As Exception
                'MsgBox("文件属性为只读,无法上载!", MsgBoxStyle.Exclamation, "提示")
                SWDialogBox.MessageBox.Show("$X018")
            Finally
                If isReadOnly Then
                    'System.IO.File.SetAttributes(strFileNameAll, IO.FileAttributes.ReadOnly) '修改文件的属性为：ReadOnly
                    System.IO.File.SetAttributes(strFileNameTemp, IO.FileAttributes.ReadOnly) '修改文件的属性为：ReadOnly
                End If
            End Try

            If Not (myfilestream Is Nothing) Then
                Dim data() As Byte
                ReDim data(myfilestream.Length - 1) 'ReDim：过程级用于重新分配数组变量的存储空间
                myfilestream.Read(data, 0, myfilestream.Length)
                myfilestream.Close()
                Return data
            Else
                Return Nothing
            End If
        Else
            Return Nothing
        End If
    End Function
    '获得文件的类型
    Public Function getFileType()
        Return strFileType
    End Function
    '
    '设定相对路径的格式:以"\"起头
    '
    Public Function getRelativePath(ByVal relativePath As String) As String
        Dim len As Integer
        len = relativePath.Length
        Try
            If len > 1 Then
                If relativePath.Substring(1, 1) = ":" Then
                    Return relativePath.Substring(2, len - 3)
                ElseIf Not relativePath.Substring(0, 1) = "\" Then
                    Return "\" + relativePath
                Else
                    Return relativePath
                End If
            ElseIf len = 1 Then
                If Not relativePath.Substring(0, 1) = "\" Then
                    Return "\" + relativePath
                Else
                    Return relativePath
                End If
            Else
                Return relativePath
            End If
        Catch ex As Exception
            'MsgBox("设置相对路径时字符转化出错：" & ex.Message, MsgBoxStyle.Exclamation, "上载文件")
            'SWDialogBox.MessageBox.Show("$2002")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '
    '通过serialNum 获得文件的内容
    '
    Public Function openFileBySerial(ByVal serialNum As String, ByVal relativePath As String)
        Dim ds As DataSet
        Dim dsFile As DataSet
        Dim strDir As String
        '设定相对路径的格式:以"\"起头
        strDir = getRelativePath(relativePath)
        Try
            ds = gWs.GetProjectFileByCondition("{serial_num='" & serialNum & "'}")
        Catch ex As Exception
            'MsgBox("文件已经打开或者获取文件内容时出错!" & ex.Message, MsgBoxStyle.Exclamation, "获取文件")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            '从数据库获得文件内容，并在程序启动下的strDir目录中生成该文件
            dsFile = getDataFromDataBase(ds, strDir)
            Dim strFileName As String
            Dim strFileType As String
            Try
                strFileName = dsFile.Tables("TProjectFile").Select("serial_num='" & serialNum & "'")(0).Item("file_name")
                strFileType = strFileName.Substring(strFileName.LastIndexOf(".") + 1, strFileName.Length - strFileName.LastIndexOf(".") - 1)
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
            Me.showDocument(strCorporationName & strFileName, strFileType, strDir)
        End If
    End Function
    '
    '通过relationNum 获得文件的内容
    '
    Public Function openFileByRelation(ByVal relationNum As String, ByVal relativePath As String)
        Dim ds As DataSet
        Dim dsFile As DataSet
        Dim strDir As String
        strDir = getRelativePath(relativePath)
        Try
            ds = gWs.GetProjectFileByCondition("{relation_num='" & relationNum & "'}")
        Catch ex As Exception
            'MsgBox("文件已经打开或者获取文件内容时出错!" & ex.Message, MsgBoxStyle.Exclamation, "获取文件")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            dsFile = getDataFromDataBase(ds, strDir)
            listDocument(dsFile, strDir)
        End If
    End Function
    '
    '通过fileID 获得文件的内容
    '
    Public Function openFileByFileID(ByVal fileID As String, ByVal relativePath As String)
        Dim ds As DataSet
        Dim dsFile As DataSet
        Dim strDir As String
        Dim arList As New ArrayList
        strDir = getRelativePath(relativePath)
        Try
            ds = gWs.GetProjectFileByCondition("{file_id='" & fileID & "'}")
        Catch ex As Exception
            'MsgBox("文件已经打开或者获取文件内容时出错!" & ex.Message, MsgBoxStyle.Exclamation, "获取文件")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            dsFile = getDataFromDataBase(ds, strDir)
            listDocument(dsFile, strDir)
        End If
    End Function
    '
    '通过itemType和itemCode 获得文件的内容
    '
    Public Function openFileList(ByVal itemType As String, ByVal itemCode As String, ByVal relativePath As String)
        Dim ds As DataSet
        Dim dsFile As DataSet
        Dim strDir As String
        Dim strSql As String
        strDir = getRelativePath(relativePath)
        strSql = "{item_type='" & itemType & "' and item_code='" & itemCode & "'}"
        Try
            ds = gWs.GetProjectFileByCondition(strSql)
        Catch ex As Exception
            'MsgBox("文件已经打开或者获取文件内容时出错!" & ex.Message, MsgBoxStyle.Exclamation, "获取文件")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            dsFile = getDataFromDataBase(ds, strDir)
            listDocument(dsFile, strDir)
        End If
    End Function
    '
    '通过projectCode ,itemType和itemCode 获得文件的内容
    '
    Public Function openFileList(ByVal projectCode As String, ByVal itemType As String, ByVal itemCode As String, ByVal relativePath As String)
        Dim ds As DataSet
        Dim dsFile As DataSet
        Dim strDir As String
        Dim strSql As String
        strDir = getRelativePath(relativePath)
        'qxd 2004-8-5
        If itemCode = "%" Or itemCode = "" Then
            strSql = "{project_code='" & projectCode & "' and item_type like '" & itemType & "'}"
        Else
            strSql = "{project_code='" & projectCode & "' and item_type='" & itemType & "' and item_code='" & itemCode & "'}"
        End If
        Try
            ds = gWs.GetProjectFileByCondition(strSql)
        Catch ex As Exception
            'MsgBox("文件已经打开或者获取文件内容时出错!" & ex.Message, MsgBoxStyle.Exclamation, "获取文件")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            If itemType = "43" Then
                listDocument(ds, strDir)
            Else
                dsFile = getDataFromDataBase(ds, strDir)
                listDocument(dsFile, strDir)
            End If
        End If
    End Function
    '
    '通过project_code ,title,version,获取文件内容
    '
    Public Function openFileByTitleVersion(ByVal projectCode As String, ByVal title As String, ByVal version As String, ByVal relativePath As String)
        Dim ds As DataSet
        Dim dsFile As DataSet
        Dim strDir As String
        Dim strSql As String
        strDir = getRelativePath(relativePath)
        strSql = "{project_code='" & projectCode & "' and title='" & title & "' and version='" & version & "'}"
        Try
            ds = gWs.GetProjectFileByCondition(strSql)
        Catch ex As Exception
            'MsgBox("文件已经打开或者获取文件内容时出错!" & ex.Message, MsgBoxStyle.Exclamation, "获取文件")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            dsFile = getDataFromDataBase(ds, strDir)
            listDocument(dsFile, strDir)
        End If
    End Function
    '
    '从数据库获得文件内容，并在程序启动下的strDir目录中生成该文件
    '
    '
    Private Function getDataFromDataBase(ByVal ds As DataSet, ByVal strDir As String)
        Dim i As Integer
        Dim dr As DataRow
        Try
            i = ds.Tables("TProjectFile").Rows.Count
        Catch ex As Exception
            'MsgBox("文件已经打开或者获取文件内容时出错!" & ex.Message, MsgBoxStyle.Exclamation, "获取文件")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not System.IO.Directory.Exists(Application.StartupPath & strDir) Then
            System.IO.Directory.CreateDirectory(Application.StartupPath & strDir)
        Else
            delAllFiles(Application.StartupPath & strDir)
        End If
        If i > 0 Then
            For i = 0 To i - 1
                dr = ds.Tables("TProjectFile").Rows(i)
                With dr
                    If Not .Item("document") Is System.DBNull.Value Then
                        Dim data As Byte()
                        data = .Item("document")
                        If Not .Item("file_type") Is System.DBNull.Value Then
                            strFileType = .Item("file_type")
                        Else
                            strFileType = ""
                        End If
                        If Not .Item("file_name") Is System.DBNull.Value Then
                            strFileName = .Item("file_name")
                        Else
                            strFileName = i
                        End If
                        Try
                            .Item("file_name") = strFileName & "." & strFileType.Trim()
                            Dim strPath As String
                            Dim isThread As Boolean = False
                            Dim myfilestream As System.IO.FileStream
                            strPath = Application.StartupPath & strDir & "\" & getLegalFileName(strCorporationName) & getLegalFileName(strFileName) & "." & strFileType.Trim()
                            '判断文件是否存在,如果存在则删除;如果删除出错,说明文件已经被另一进程占用了.则不创建新的文件
                            If System.IO.File.Exists(strPath) Then
                                Try
                                    System.IO.File.Delete(strPath)
                                Catch
                                    isThread = True
                                End Try
                            End If
                            If Not isThread Then
                                myfilestream = New System.IO.FileStream(strPath, IO.FileMode.Create, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite, 5)
                                myfilestream.Write(data, 0, data.Length)
                                myfilestream.Close()
                            End If
                        Catch ex As Exception
                            'MsgBox("文件已经打开或者获取文件内容时出错!", MsgBoxStyle.Exclamation, "获取文件")
                            ExceptionHandler.ShowMessageBox(ex)
                        End Try
                    Else
                        ds.Tables("TProjectFile").Rows(i).Delete()
                    End If
                End With
            Next
            ds.AcceptChanges()
            Return ds
        End If
    End Function
    '
    '实例frmDocumentList()
    '
    Private Sub listDocument(ByVal ds As DataSet, ByVal strDir As String)
        Dim listDoc As New frmDocumentList(strCorporationName)
        Dim i As Integer
        If Not ds Is Nothing Then
            Try
                i = ds.Tables("TProjectFile").Rows.Count
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
            If i > 0 Then
                listDoc.setDir(strDir)
                listDoc.dgFile.DataSource = ds.Tables("TProjectFile")
                Try
                    If isDocument Then
                        listDoc.setViewBox()
                    End If
                    If Me.ViewGuanty Then
                        listDoc.ShowDeleteButton()
                    End If
                    listDoc.ShowDialog()
                Catch ex As Exception
                    'MsgBox(ex.Message)
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
            Else
                'MsgBox("没有相关的文件内容!", MsgBoxStyle.Exclamation, "打开文件")
                SWDialogBox.MessageBox.Show("$2004", "")
            End If
        Else
            'MsgBox("没有相关的文件内容!", MsgBoxStyle.Exclamation, "打开文件")
            SWDialogBox.MessageBox.Show("$2004", "")
        End If
    End Sub
    '打开word,excel文件
    Private Sub showDocument(ByVal fileName As String, ByVal fileType As String, ByVal strDir As String)
        Dim strPath As String
        Dim strTemp As String 'qxd add 2003-10-30

        strTemp = getLegalFileName(fileName)
        'qxd modify 2003-12-26
        'strPath = Application.StartupPath & strDir & "\" & strTemp
        strPath = Application.StartupPath & strDir & strTemp
        'If Not System.IO.File.Exists(strPath) Then
        '    SWDialogBox.MessageBox.Show("$2004", "")
        '    Exit Sub
        'End If
        If fileType.Trim() = "doc" Then
            Dim word1 As Word.ApplicationClass
            Try
                word1 = New Word.ApplicationClass
                ' qxd modify 2003-10-30
                'word1.Application.Documents.Open(strPath)
                word1.Application.Documents.Add(strPath)
                word1.Caption = strTemp
                'qxd end
                word1.Application.Visible = True
            Catch ex As Exception
                '关闭打开的文件
                word1.Application.Documents.Close()
                '退出Word,且不提示是否保存
                CType(word1.Application, Word.ApplicationClass).Quit(Word.WdSaveOptions.wdDoNotSaveChanges)
                'MsgBox("文件已经打开!", MsgBoxStyle.Exclamation, "打开文件")
                SWDialogBox.MessageBox.Show("$2001", "")
            Finally
                word1 = Nothing
                GC.Collect()
            End Try
        ElseIf fileType.Trim() = "xls" Then
            Dim excel1 As Excel.ApplicationClass
            Try
                excel1 = New Excel.ApplicationClass
                'excel1.Application.Workbooks.Open(strPath)
                excel1.Application.Workbooks.Add(strPath)
                excel1.Application.Visible = True
            Catch ex As Exception
                '关闭打开的文件
                excel1.Application.Workbooks.Close()
                '退出Excel,且不提示是否保存
                CType(excel1.Application, Excel.ApplicationClass).Quit()
                'MsgBox("文件已经打开!", MsgBoxStyle.Exclamation, "打开文件")
                SWDialogBox.MessageBox.Show("$2001", "")
            Finally
                excel1 = Nothing
                GC.Collect()
            End Try
        ElseIf fileType.Trim() = "jpg" Or fileType.Trim() = "gif" Or fileType.Trim() = "bmp" Or fileType.Trim() = "jpeg" _
        Or fileType.Trim() = "JPG" Or fileType.Trim() = "GIF" Or fileType.Trim() = "BMP" Or fileType.Trim() = "JPEG" Then
            Try
                System.Diagnostics.Process.Start(strPath)
            Catch ex As Exception
                'MsgBox("图片文件读取错误!", MsgBoxStyle.Critical, "提示")
                ExceptionHandler.ShowMessageBox(ex)
            Finally
                GC.Collect()
            End Try
        Else
            Try
                System.Diagnostics.Process.Start(strPath)
            Catch ex As Exception
                'MsgBox("图片文件读取错误!", MsgBoxStyle.Critical, "提示")
                ExceptionHandler.ShowMessageBox(ex)
            Finally
                GC.Collect()
            End Try
            'Else
            '    'MsgBox("文件类型未知!", MsgBoxStyle.Critical, "错误")
            '    SWDialogBox.MessageBox.Show("$2003", "")
        End If
    End Sub

    Private isViewOpp As Boolean
    Public Property ViewGuanty() As Boolean
        Get
            Return Me.isViewOpp
        End Get
        Set(ByVal Value As Boolean)
            Me.isViewOpp = Value
        End Set
    End Property

End Class
