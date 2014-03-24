Public Class frmBusinessBaseWin
    Inherits frmBasic

    Protected strProjectCode, strEnterpriseName As String
    Protected strTaskID As String
    Protected strWorkFlowID As String
    Protected strUserID As String
    'Protected gWs As New htfServer.Service1()
    Protected i As Integer
    Private Service As htfServer.Service1 = gWs

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    Public Sub New(ByVal ProjectCode As String, ByVal EnterpriseName As String)
        Me.New()
        Me.strProjectCode = ProjectCode
        Me.strEnterpriseName = EnterpriseName
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
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Public WithEvents txtEnterpriseName As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.txtEnterpriseName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(472, 392)
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
        Me.btnExit.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "项目编码"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(192, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "企业名称"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(88, 14)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 2
        Me.txtProjectCode.Text = ""
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEnterpriseName.Location = New System.Drawing.Point(256, 14)
        Me.txtEnterpriseName.Name = "txtEnterpriseName"
        Me.txtEnterpriseName.ReadOnly = True
        Me.txtEnterpriseName.Size = New System.Drawing.Size(240, 21)
        Me.txtEnterpriseName.TabIndex = 4
        Me.txtEnterpriseName.Text = ""
        '
        'frmBusinessBaseWin
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(592, 473)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1})
        Me.MaximizeBox = False
        Me.Name = "frmBusinessBaseWin"
        Me.Text = "业务基类"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmBusinessBaseWin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtProjectCode.Text = Me.getProjectCode()
        Me.txtEnterpriseName.Text = Me.getCorporationName()
        Me.strProjectCode = Me.getProjectCode()
        Me.strEnterpriseName = Me.getCorporationName()
        Me.strTaskID = Me.getTaskID()
        Me.strWorkFlowID = Me.getWorkFlowID()
        Me.strUserID = Me.getUser()
    End Sub

    '通过用户的WorkFlowID，TaskID，ProjectID获得用户的FinishedFlag。
    Protected Function GetFinishedFlag(ByVal WorkFlowID As String, ByVal ProjectCode As String, ByVal TaskID As String) As DataSet
        Dim TempDS As New DataSet()
        TempDS = Service.GetTransCondition(Me.strWorkFlowID, Me.strProjectCode, Me.strTaskID)
        If Not TempDS.Tables(0).Rows.Count = 0 Then
            Return TempDS
        Else
            Return Nothing
        End If
    End Function

    '提交用户进行的操作。
    Protected Overloads Sub CommitWorkFlow(ByVal FinishedFlag As String)
        Dim strCommitResult As String
        strCommitResult = Service.finishedTask(Me.strWorkFlowID, Me.strProjectCode, Me.strTaskID, FinishedFlag, Me.strUserID)
        If strCommitResult = "1" Then
            'Michael
            'MessageBox.Show("提交成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            Call Me.raiseCommitSucceed()
        Else
            'Michael
            'MessageBox.Show("提交失败：" + strCommitResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", "提交失败：" + strCommitResult, "", "")
        End If
    End Sub

    Protected Overloads Sub CommitWorkFlow(ByVal FinishedFlag As String, ByVal frmOwn As Form)
        Dim strCommitResult As String
        strCommitResult = Me.Service.finishedTask(Me.strWorkFlowID, Me.strProjectCode, Me.strTaskID, FinishedFlag, Me.strUserID)
        If strCommitResult = "1" Then
            'Michael
            'MessageBox.Show("提交成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            Call Me.raiseCommitSucceed()
        Else
            'Michael
            ' MessageBox.Show("提交失败：" + strCommitResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", "提交失败：" + strCommitResult, "", "")
            Return
        End If
        frmOwn.Close()
    End Sub

    Protected Sub SendKeys(ByVal keymode As Integer, ByVal strTemp As String, ByVal key As System.Windows.Forms.KeyPressEventArgs)
        Select Case keymode
            Case 1 '控制输入仅为整数。
                key.Handled = Not (((key.KeyChar) >= Convert.ToChar(48) And (key.KeyChar) <= Convert.ToChar(57) Or (key.KeyChar) = Convert.ToChar(8) Or (key.KeyChar) = Convert.ToChar(45)))
            Case 2 '控制输入为小数。
                key.Handled = Not (((key.KeyChar) >= Convert.ToChar(48) And (key.KeyChar) <= Convert.ToChar(57) Or (key.KeyChar) = Convert.ToChar(8) Or (key.KeyChar) = Convert.ToChar(45)))
                If (key.KeyChar = Convert.ToChar(46)) Then
                    If (strTemp.IndexOf(".") <> -1) Then
                        key.Handled = True
                    Else
                        key.Handled = False
                    End If
                End If
        End Select
    End Sub

    '
    '替换文档中的的指定字符
    '
    Protected Sub replaceText(ByVal word1 As Word.ApplicationClass, ByVal strFlag As String, ByVal strReplace As String)
        Dim docActive As Word.DocumentClass
        Dim content As Word.Range
        Dim fd As Word.Find

        docActive = word1.ActiveDocument
        content = docActive.Content
        fd = content.Find

        fd.Format = True
        'fd.MatchCase = false '不区分大小写
        fd.MatchCase = True '区分大小写
        fd.ClearFormatting() '清除格式
        fd.MatchWholeWord = True '查找完整的单词
        fd.MatchWildcards = False '不查找包含通配符
        fd.Wrap = Word.WdFindWrap.wdFindContinue '到达文末后，从头继续查找
        fd.Replacement.ClearFormatting() '清除替换后的格式
        fd.Replacement.Style = Word.WdReplace.wdReplaceAll '替换所有

        Try
            fd.Execute(strFlag, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, strReplace)
        Catch ex As Exception
            'mocidifed by Michael
            'MsgBox(ex.Message)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        End Try
        fd = Nothing
        content = Nothing
        docActive = Nothing
    End Sub
    '
    '生成并保存临时的Word文件
    '
    Protected Function GetWordTemplate(ByVal ItemType As String, ByVal ItemCode As String, ByVal FileType As String) As Word.ApplicationClass
        Dim ds As New DataSet()
        ds = gWs.GetFileTemplateByCondition("{item_type='" & ItemType & "' and item_code='" & ItemCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            Dim data As Byte() = ds.Tables(0).Rows(0).Item("template")
            Dim myfilestream As System.IO.FileStream
            Dim strPath As String
            Dim isThread As Boolean = False
            Dim strFileType As String = FileType
            strPath = Application.StartupPath & "\" & strFileType
            '判断文件是否存在,如果存在则删除;如果删除出错,说明文件已经被另一进程占用了.则不创建新的文件
            If System.IO.File.Exists(strPath) Then
                Try
                    System.IO.File.Delete(strPath)
                Catch
                    isThread = True
                End Try
            End If
            If Not isThread Then
                myfilestream = New System.IO.FileStream(Application.StartupPath & "\" & strFileType, IO.FileMode.Create, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite)
                myfilestream.Write(data, 0, data.Length)
                myfilestream.Close()
            End If
            '打开Word文档
            Dim word1 As Word.ApplicationClass = New Word.ApplicationClass()
            word1.Application.Documents.Open(Application.StartupPath & "\" & strFileType)
            word1.Application.Visible = True
            Return word1
        End If
    End Function

    '获取项目人员的详细工作量,Param为传入的人名参数。
    Public Sub GetRoleTaskList(ByVal Param As String, ByVal dgGrid As DataGrid, ByVal DS As DataSet)
        Dim TempDS As New DataSet()
        'DS = gWs.GetReviewListInfo()
        DS.Tables(0).Columns.Add("project_name", GetType(String))
        For i = 0 To DS.Tables(0).Rows.Count - 1
            Dim proj_code, corp_name As String
            proj_code = DS.Tables(0).Rows(i).Item("project_code")
            TempDS = gWs.GetProjectInfoEx("{projectcode= '" & proj_code & "'}")
            If Not TempDS.Tables(0).Rows.Count = 0 Then
                corp_name = TempDS.Tables(0).Rows(0).Item("enterprisename")
            Else
                corp_name = ""
            End If
            DS.Tables(0).Rows(i).Item("project_name") = corp_name
        Next

        Dim TempDS1 As New DataSet()
        TempDS1.Merge(DS.Tables(0).Select("attend_person ='%" & Param & "%'"))
        If DS.Tables(0).Select("attend_person ='%" & Param & "%'").Length > 0 Then
            If Not DS.Tables(0).Rows.Count = 0 Then
                dgGrid.DataSource = TempDS1.Tables(0).DefaultView
                dgGrid.CaptionText = "统计工作共计 " + TempDS1.Tables(0).Rows.Count.ToString() + " 件"
            Else
                dgGrid.CaptionText = "统计工作共计 0 件"
            End If
        Else
            dgGrid.DataSource = TempDS1
            dgGrid.CaptionText = "统计工作共计 0 件"
        End If
    End Sub
End Class
