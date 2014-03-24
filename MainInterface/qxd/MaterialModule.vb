Module MaterialModule

    '''''''''''''''''''''''''''''''''''''''''''''''''''''''''
    'qxd 
    '2003-4-7
    '
    ''''''''''''''''''''''''''''''''''''''''''''''''''''''''

    'Private systemTime As Date '系统（中间层返回来的）时间

    '
    '设置dg不能自动增加行
    '
    Public Sub setDgAttribute(ByVal dGrid As DataGrid, ByVal frm As Form)
        Dim cm As CurrencyManager
        Try
            cm = CType(frm.BindingContext(dGrid.DataSource, dGrid.DataMember), CurrencyManager)
            Dim dv As DataView = New DataView()
            dv = CType(cm.List, DataView)
            dv.AllowNew = False  '不允许自增
        Catch ex As Exception
            'MsgBox("设定DataGrid不能自动增加新行时出错!" & ex.Message, MsgBoxStyle.Critical, "错误")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '设置dg不能删除行
    '
    Public Sub setDgDeleteAttribute(ByVal dGrid As DataGrid, ByVal frm As Form)
        Dim cm As CurrencyManager
        Try
            cm = CType(frm.BindingContext(dGrid.DataSource, dGrid.DataMember), CurrencyManager)
            Dim dv As DataView = New DataView()
            dv = CType(cm.List, DataView)
            dv.AllowDelete = False   '不允许删除
        Catch ex As Exception
            'MsgBox("设定DataGrid不能自动增加新行时出错!" & ex.Message, MsgBoxStyle.Critical, "错误")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '获取项目阶段phase
    '
    Public Function getPhase(ByVal strCode As String) As String
        Dim ds As DataSet
        Dim i As Integer
        Try
            ds = gWs.GetProjectInfo("{project_code='" & strCode & "'}")
            i = ds.Tables("project").Rows.Count
            If i > 0 Then
                If Not ds.Tables("project").Rows(0).Item("phase") Is System.DBNull.Value Then
                    Return ds.Tables("project").Rows(0).Item("phase")
                Else
                    Return ""
                End If
            Else
                Return ""
            End If
        Catch ex As Exception
            'MsgBox("获取项目阶段出错!", MsgBoxStyle.Critical, "错误")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '获得企业编码
    Public Function getCorporationCode(ByVal strCode As String) As String
        Dim ds As DataSet
        Dim i As Integer
        Try
            ds = gWs.GetProjectInfo("{project_code='" & strCode & "'}")
            i = ds.Tables("project").Rows.Count
            If i > 0 Then
                If Not ds.Tables("project").Rows(0).Item("corporation_code") Is System.DBNull.Value Then
                    Return ds.Tables("project").Rows(0).Item("corporation_code")
                Else
                    Return ""
                End If
            Else
                Return ""
            End If
        Catch ex As Exception
            'MsgBox("获取企业编码出错!", MsgBoxStyle.Critical, "错误")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '
    '通过item_name文件类型，获得item_type
    '
    Public Function getItemType(ByVal strFileType As String) As String
        Dim ds As DataSet
        Dim i As Integer
        Try
            ds = gWs.GetItem("{item_name='" & strFileType & "'}", Nothing)
            i = ds.Tables("TItem").Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    With ds.Tables("TItem").Rows(i)
                        Return .Item("item_type")
                    End With
                Next
            End If
        Catch ex As Exception
            'MsgBox("获取item_type出错!", MsgBoxStyle.Critical, "错误")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '
    '通过文件类型，获得item_code
    '
    Public Function getItemCode(ByVal strFileType As String) As String
        Dim ds As DataSet
        Dim i As Integer
        Try
            ds = gWs.GetItem("{item_name='" & strFileType & "'}", Nothing)
            i = ds.Tables("TItem").Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    With ds.Tables("TItem").Rows(i)
                        Return .Item("item_code")
                    End With
                Next
            End If
        Catch ex As Exception
            'MsgBox("获取item_code 出错!", MsgBoxStyle.Critical, "错误")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '
    '通过用户的WorkFlowID，TaskID，ProjectID获得用户的FinishedFlag。
    '
    Public Function GetFinishedFlag(ByVal projectCode As String, ByVal workFlowID As String, ByVal taskID As String) As ArrayList
        Dim arList As New ArrayList()
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        If Not gWs Is Nothing Then
            Try
                ds = gWs.GetTransCondition(workFlowID, projectCode, taskID)
                If Not ds Is Nothing Then
                    i = ds.Tables(0).Rows.Count
                    If i > 0 Then
                        For i = 0 To i - 1
                            dr = ds.Tables(0).Rows(i)
                            With dr
                                If Not .Item("transfer_condition") Is System.DBNull.Value Then
                                    arList.Add(.Item("transfer_condition"))
                                End If
                            End With
                        Next
                        Return arList
                    Else
                        Return arList
                    End If
                End If
            Catch ex As Exception
                'MsgBox("获得用户的FinishedFlag出错!" & ex.Message, MsgBoxStyle.Critical, "错误")
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Function
    '
    'technology_type，获得科技类型
    '
    Public Function getTechnologyType(ByVal code As String) As String
        If Not gWs Is Nothing Then
            Dim ds As DataSet
            Dim i As Integer
            Dim strTechnologyType As String
            Dim choose As Integer
            Dim typeCode As Integer = CType(code, Integer)
            Try
                ds = gWs.GetTechnologyType("%")

                i = ds.Tables("TTechnologyType").Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        choose = ds.Tables("TTechnologyType").Rows(i).Item("technology_type_code")
                        '企业类型是取或;如7=1+2+4,则显示code为1,2,4的三种类型
                        If typeCode And choose Then
                            strTechnologyType += ds.Tables("TTechnologyType").Rows(i).Item("technology_type")
                            strTechnologyType += ";"
                        End If
                    Next
                End If
                Return strTechnologyType
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Function
    '
    '通过银行代码,获得银行名称
    '
    Public Function getBankName(ByVal bankCode As String)
        If Not gWs Is Nothing Then
            Dim ds As DataSet
            Dim dr As DataRow
            Dim i As Integer
            Dim strSql As String
            Dim strBankName As String
            strSql = "{bank_code='" & bankCode & "'}"
            Try
                ds = gWs.GetBankInfo(strSql, "null")
                i = ds.Tables("bank").Rows.Count
                If i > 0 Then
                    dr = ds.Tables("bank").Rows(0)
                    strBankName = dr.Item("bank_name")
                End If
                Return strBankName
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Function
    '
    '通过支行代码,获得支行名称
    '
    Public Function getBranchBankName(ByVal bankCode As String, ByVal branchCode As String)
        If Not gWs Is Nothing Then
            Dim ds As DataSet
            Dim dr As DataRow
            Dim i As Integer
            Dim strSql As String
            Dim strBankName As String
            strSql = "{bank_code='" & bankCode & "' and branch_bank_code='" & branchCode & "'}"
            Try
                ds = gWs.GetBankInfo("null", strSql)
                i = ds.Tables("bank_branch").Rows.Count
                If i > 0 Then
                    dr = ds.Tables("bank_branch").Rows(0)
                    strBankName = dr.Item("branch_bank_name")
                End If
                Return strBankName
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Function
    '
    '获得中间层返回的当前时间
    '
    'Public Function getSystemTime() As Date
    '    setSystemTime()
    '    Return systemTime.ToString("yyyy年MM月dd日")
    'End Function
    ''设置时间
    'Private Sub setSystemTime()
    '    Try
    '        If Not gWs Is Nothing Then
    '            systemTime = gWs.GetSysTime()
    '        Else

    '        End If
    '    Catch ex As Exception
    '        'MsgBox(ex.Message)
    '        ExceptionHandler.ShowMessageBox(ex)
    '    End Try
    'End Sub
    '删除某个目录下的所有文件及子目录
    Public Function delAllFiles(ByVal path As String)
        Try
            If System.IO.Directory.Exists(path) Then
                Dim len, lenDir As Integer
                Dim i As Integer
                Dim fileList As String()
                Dim dirList As String()
                fileList = System.IO.Directory.GetFiles(path)
                len = fileList.Length
                dirList = System.IO.Directory.GetDirectories(path)
                lenDir = dirList.Length
                For i = 0 To len - 1
                    System.IO.File.Delete(fileList(i))
                Next
                For i = 0 To lenDir - 1
                    delAllFiles(dirList(i))
                Next
            End If
        Catch ex As Exception
        Finally
        End Try
    End Function
    '检查文件名是否含有非法字符（\ / : * ? " < > |）
    Public Function getLegalFileName(ByVal fileName As String)
        If fileName Is Nothing Or fileName = "" Then
            fileName = ""
        Else
            Dim i, j, len, count As Integer
            Dim strFileName As String
            Try
                Dim strTemp As Object() = {"\", "/", ":", "*", "?", """", "<", ">", "|"}
                Dim str As String
                count = strTemp.Length
                len = fileName.Length
                For j = 0 To count - 1
                    fileName = replaceExt(fileName, strTemp(j), "×")
                Next
            Catch ex As Exception
            End Try
        End If
        'Return fileName.Trim
        Return fileName
    End Function
    '替换字符串中的某个字符
    Private Function replaceExt(ByVal strContent As String, ByVal flag As String, ByVal replaceFlag As String)
        Try
            strContent = Replace(strContent, flag, replaceFlag)
            If InStr(strContent, flag) <> 0 Then
                replaceExt(strContent, flag, replaceFlag)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Return strContent
    End Function
    '通过保函编码item_type获得保函类型名称
    Public Function getGuaranteeLetterName(ByVal typeCode As String)
        If Not gWs Is Nothing Then
            Dim ds As DataSet
            Dim dr As DataRow
            Dim i As Integer
            Dim strSql As String
            Dim strLetterName As String

            strSql = "{type_code='" & typeCode & "'}"
            Try
                ds = gWs.GetGuaranteeLetterType(strSql)
                i = ds.Tables(0).Rows.Count
                If i > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    strLetterName = dr.Item("name")
                End If
                Return strLetterName
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Function
    ''获得项目的申请日期
    'Public Function getApplyDate(ByVal strProjectCode As String) As String
    '    Dim strMonth As String
    '    Dim strApplyDate As String
    '    Try
    '        Dim dsPro As DataSet
    '        dsPro = gWs.GetProjectInfo("{project_code='" & strProjectCode & "'}")
    '        If dsPro.Tables("project").Rows.Count > 0 Then
    '            strApplyDate = dsPro.Tables("project").Rows(0).Item("apply_date")
    '        End If
    '    Catch ex As Exception
    '        'MsgBox("获取项目的申请日期时出错!", MsgBoxStyle.Exclamation, "提示")
    '        ExceptionHandler.ShowMessageBox(ex)
    '    Finally
    '        If strApplyDate = "" Then
    '            strApplyDate = gWs.GetSysTime()
    '        End If
    '    End Try
    '    Return strApplyDate
    'End Function


    Public Function MyMsgBox(ByVal strMessage As String, Optional ByVal strDetail As String = "", _
             Optional ByVal intButton As Int16 = 0, Optional ByVal intIcon As Int16 = 0, _
             Optional ByVal strCaption As String = "系统提示") As MsgBoxResult

        Try
            Dim SwButton As SWDialogBox.MessageBoxButton
            Dim swIcon As SWDialogBox.MessageBoxIcon
            Select Case intButton
                Case 0
                    SwButton = SWDialogBox.MessageBoxButton.OK
                Case 1
                    SwButton = SWDialogBox.MessageBoxButton.Detail
                Case 2
                    SwButton = SWDialogBox.MessageBoxButton.YesNo
            End Select
            Select Case intIcon
                Case 0
                    swIcon = SWDialogBox.MessageBoxIcon.Information
                Case 1
                    swIcon = SWDialogBox.MessageBoxIcon.Question
                Case 2
                    swIcon = SWDialogBox.MessageBoxIcon.Exclamation
            End Select

            SWDialogBox.MessageBox.Show(strMessage, strCaption, strDetail, SwButton, SWDialogBox.MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("调用组件错误", "错误提示", MessageBoxButtons.OK)
        End Try

    End Function

    '获得staff表中某个登录人或指定人的Team_name
    Public Function getStaffTeamName(ByVal strUser As String) As String
        Dim i, count As Integer
        Dim ds As DataSet
        Dim strSql As String
        Dim strTeamName As String = ""

        If strUser.Trim = "" Then
            strUser = UserName
        End If

        Try
            strSql = "{staff_name='" & strUser & "'}"
            ds = gWs.GetStaff(strSql)
            If Not ds Is Nothing Then
                If ds.Tables(0).Rows.Count > 0 Then
                    'If Not ds.Tables(0).Rows(0).Item("team_name") Is System.DBNull.Value Then
                    '    strTeamName = ds.Tables(0).Rows(0).Item("team_name")
                    'End If
                    If Not ds.Tables(0).Rows(0).Item("branch_name") Is System.DBNull.Value Then
                        strTeamName = ds.Tables(0).Rows(0).Item("branch_name")
                    End If
                End If
            End If
            Return strTeamName
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Function

End Module
