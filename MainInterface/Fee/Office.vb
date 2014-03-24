'功能：根据替换内容的长度自动产生标记并替换的方法  
'Created by LQF
Public Class Office

    Private _TransitionIndex As Int16

    Public Function CreateOfficeTable() As DataTable
        _TransitionIndex = 1
        Dim dtExcel As DataTable = New DataTable("OFFICE")
        dtExcel.Columns.Add("flag", GetType(String))
        dtExcel.Columns.Add("value", GetType(Object))
        Return dtExcel
    End Function

    '计算新生成的标记中的区别数字的总长度
    Private Sub CaculateDigitalLength(ByVal flagCount As Int16, ByRef digitalLength As Int16)
        Dim digitalStr As String = flagCount.ToString
        Dim i As Int16
        digitalLength = (Int16.Parse(digitalStr.Substring(0)) - Math.Pow(10, digitalStr.Length - 1) + 1) * digitalStr.Length
        For i = 1 To digitalStr.Length - 2
            digitalLength += (Math.Pow(10, digitalStr.Length - i) - Math.Pow(10, digitalStr.Length - i - 1)) * (digitalStr.Length - i)
        Next
        digitalLength += Int16.Parse(digitalStr.Substring(digitalStr.Length - 1))
    End Sub

    '拆分过渡期的标记名称
    Private Sub SplitTransitionFlag(ByRef dtOffice As DataTable, ByVal prefix As String, _
                                                    ByVal suffix As String, ByVal finalFlagCount As Int16, _
                                                    ByVal position As Int16, ByVal flagNameWaitForReplaced As String)
        Dim k As Int16 = 1
        Do
            prefix = prefix & "@"
            dtOffice.Rows.Add(New Object() {flagNameWaitForReplaced, prefix & k.ToString & prefix & (k + 1).ToString})

            Dim i As Int16
            Dim newFlagName As String = String.Empty
            For i = position To finalFlagCount
                position = i '至关重要 It's terminated
                If newFlagName.Length + Len(prefix) + Len(suffix) + Len(i.ToString) > 250 Then
                    dtOffice.Rows.Add(New Object() {prefix & k.ToString, newFlagName})
                    Exit For
                End If
                newFlagName += "&#" & i.ToString & suffix
            Next

            flagNameWaitForReplaced = prefix & (k + 1).ToString
            If position = finalFlagCount Then
                Dim rows() As DataRow = dtOffice.Select("flag='" & prefix & k.ToString & "'")
                If rows.Length = 0 Then
                    dtOffice.Rows.Add(New Object() {prefix & k.ToString, newFlagName})
                End If
                dtOffice.Rows.Add(New Object() {prefix & (k + 1).ToString, String.Empty}) '最后一个辅助标记设为空串
                Exit Do
            End If
            k += 2
        Loop
    End Sub



    Public Overloads Sub ReplaceFlag(ByRef dtOffice As DataTable, ByVal flag As Object, ByVal value As Object)
        Dim flagName, flagValue As String
        If flag Is Nothing OrElse IsDBNull(flag) Then
            Throw New Exception("传入标记名称不能为空！")
        End If

        flagName = flag.ToString
        If value Is Nothing OrElse IsDBNull(value) Then
            flagValue = String.Empty
        End If
        flagValue = value.ToString

        Dim prefix, suffix As String
        prefix = flagName.Substring(0, 2)
        suffix = flagName.Substring(2)
        Dim finalFlagCount As Int16 = Math.Ceiling(flagValue.Length * 1.0 / 250)
        '如果并无超过250个字，直接赋值、返回
        If finalFlagCount <= 1 Then
            dtOffice.Rows.Add(New Object() {flagName, flagValue})
            Return
        End If

        SplitTransitionFlag(dtOffice, prefix & _TransitionIndex.ToString, suffix, finalFlagCount, 1, flagName)
        _TransitionIndex += 1 '递增计数器
        ReplaceFlag(dtOffice, prefix, suffix, flagValue, finalFlagCount)
    End Sub

    Public Overloads Sub ReplaceFlag(ByRef dtOffice As DataTable, ByVal prefix As String, ByVal suffix As String, ByVal content As String, ByVal maxIndex As Int32)
        content = frmFlagContentClass.replaceExt(content, "")
        content = IIf(content Is Nothing, String.Empty, content)
        Dim MaxCount As Int32 = Math.Ceiling(content.Length / 250)
        Dim i As Int32
        For i = 1 To MaxCount
            If i = MaxCount Then
                dtOffice.Rows.Add(New Object() {prefix & i.ToString & suffix, content.Substring((i - 1) * 250)})
            Else
                dtOffice.Rows.Add(New Object() {prefix & i.ToString & suffix, content.Substring((i - 1) * 250, 250)})
            End If
        Next
        For i = MaxCount + 1 To maxIndex
            dtOffice.Rows.Add(New Object() {prefix & i.ToString & suffix, String.Empty})
        Next
    End Sub

    Public Sub GetFlagAndValueArray(ByVal dtOffice As DataTable, ByRef keys() As String, ByRef value As ArrayList, Optional ByVal disposeTableOffice As Boolean = True)
        Dim k As Integer
        ReDim keys(dtOffice.Rows.Count - 1)
        value = New ArrayList()
        For k = 0 To keys.Length - 1
            keys(k) = dtOffice.Rows(k)("flag")
            value.Add(dtOffice.Rows(k)("value"))
        Next
        If disposeTableOffice Then
            dtOffice.Dispose()
        End If
    End Sub

End Class

