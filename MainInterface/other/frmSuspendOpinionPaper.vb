

Public Class frmSuspendOpinionPaper
    Inherits MainInterface.frmBasic
    Private ProjectCode As String
    Private CorporationName As String
    Private fileType As String = "45"
    Private fileCode As String = "205"

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Protected WithEvents txtCorName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents btnLookConclusion As System.Windows.Forms.Button
    Friend WithEvents btnMakeSuspendDoc As System.Windows.Forms.Button
    Friend WithEvents btnSubmit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConferenceConclusion As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtConferenceConclusion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.btnLookConclusion = New System.Windows.Forms.Button()
        Me.btnMakeSuspendDoc = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Location = New System.Drawing.Point(486, 144)
        Me.btnExit.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtConferenceConclusion, Me.Label1, Me.txtCorName, Me.Label5, Me.Label6, Me.txtProjectCode})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 104)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'txtConferenceConclusion
        '
        Me.txtConferenceConclusion.Location = New System.Drawing.Point(88, 64)
        Me.txtConferenceConclusion.Name = "txtConferenceConclusion"
        Me.txtConferenceConclusion.Size = New System.Drawing.Size(128, 21)
        Me.txtConferenceConclusion.TabIndex = 39
        Me.txtConferenceConclusion.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "评审会结论"
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtCorName.Enabled = False
        Me.txtCorName.Location = New System.Drawing.Point(248, 26)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.Size = New System.Drawing.Size(312, 21)
        Me.txtCorName.TabIndex = 37
        Me.txtCorName.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "企业名称"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "项目编码"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtProjectCode.Enabled = False
        Me.txtProjectCode.Location = New System.Drawing.Point(88, 26)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(72, 21)
        Me.txtProjectCode.TabIndex = 36
        Me.txtProjectCode.Text = ""
        '
        'btnLookConclusion
        '
        Me.btnLookConclusion.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnLookConclusion.Location = New System.Drawing.Point(144, 144)
        Me.btnLookConclusion.Name = "btnLookConclusion"
        Me.btnLookConclusion.Size = New System.Drawing.Size(120, 24)
        Me.btnLookConclusion.TabIndex = 3
        Me.btnLookConclusion.Text = "查看评审会结论(&R)"
        '
        'btnMakeSuspendDoc
        '
        Me.btnMakeSuspendDoc.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnMakeSuspendDoc.Location = New System.Drawing.Point(273, 144)
        Me.btnMakeSuspendDoc.Name = "btnMakeSuspendDoc"
        Me.btnMakeSuspendDoc.Size = New System.Drawing.Size(120, 23)
        Me.btnMakeSuspendDoc.TabIndex = 4
        Me.btnMakeSuspendDoc.Text = "制作暂缓意见书(&M)"
        '
        'btnSubmit
        '
        Me.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSubmit.Location = New System.Drawing.Point(402, 144)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.TabIndex = 5
        Me.btnSubmit.Text = "提交(&C)"
        '
        'frmSuspendOpinionPaper
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(596, 183)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnSubmit, Me.btnMakeSuspendDoc, Me.btnLookConclusion, Me.GroupBox1})
        Me.Name = "frmSuspendOpinionPaper"
        Me.Text = "出具暂缓意见书"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnLookConclusion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLookConclusion.Click
        Dim frm As New frmMeetRecordQuery(ProjectCode, CorporationName)
        frm.AllowTransparency = False
        frm.ShowDialog()
    End Sub

    Private Sub frmSuspendOpinionPaper_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            ProjectCode = MyBase.getProjectCode
            CorporationName = MyBase.getCorporationName

            txtProjectCode.Text = ProjectCode : txtCorName.Text = CorporationName

            Dim dsTrial As DataSet = gWs.GetConfTrialInfo("{project_code LIKE '" & ProjectCode & "' ORDER BY trial_times DESC}", "")
            If Not dsTrial Is Nothing Then
                txtConferenceConclusion.Text = Trim(dsTrial.Tables(0).Rows(0).Item("trial_conclusion"))
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub btnMakeSuspendDoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMakeSuspendDoc.Click
        Dim htOpinion As New Hashtable()
        Dim SystemDate As Date
        Dim TaskID As String = MyBase.getTaskID()
        Dim dsProject As DataSet = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")

        '''''''生成哈希表'''''''''
        htOpinion.Item("&#Date") = SystemDate.Date.ToString("yyyy/M/d")
        htOpinion.Item("&#ProjectCode") = ProjectCode
        htOpinion.Item("&#Corporation") = txtCorName.Text

        If Not IsDBNull(dsProject.Tables(0).Rows(0).Item("manager_A")) Then
            htOpinion.Item("&#ManagerA") = dsProject.Tables(0).Rows(0).Item("manager_A")
        Else
            htOpinion.Item("&#ManagerA") = ""
        End If

        If Not IsDBNull(dsProject.Tables(0).Rows(0).Item("manager_B")) Then
            htOpinion.Item("&#ManagerB") = dsProject.Tables(0).Rows(0).Item("manager_B")
        Else
            htOpinion.Item("&#ManagerB") = ""
        End If
        
        htOpinion.Item("&#ApplySum") = dsProject.Tables(0).Rows(0).Item("ApplySum") & "万元"
        htOpinion.Item("&#Term") = dsProject.Tables(0).Rows(0).Item("ApplyTerm")
        htOpinion.Item("&#Bank") = dsProject.Tables(0).Rows(0).Item("ApplyBank")

        '''''''''''''''反担保措施'''''''''''''''
        Dim strGuaranty As String = String.Empty
        Dim dsGuaForm As DataSet = gWs.GetProjectGuaranteeForm("{project_code LIKE '" & ProjectCode & "'}")
        Dim dr As DataRow
        For Each dr In dsGuaForm.Tables("TProjectGuaranteeForm").Rows
            strGuaranty += dr("description").ToString & Chr(13)
        Next
        htOpinion.Item("&#Guaranty") = strGuaranty

        htOpinion.Item("&#ConclusionA") = "项目暂缓"
        htOpinion.Item("&#Remark") = Trim(txtConferenceConclusion.Text)
        htOpinion.Item("&#ConclusionB") = "该项目暂缓"
        htOpinion.Item("&#VouchOpinion") = ""
        '''''''生成哈希表'''''''''

        Dim key() As String
        Dim value As ArrayList = New ArrayList()
        Dim i As Integer = 0
        ReDim key(htOpinion.Count - 1)
        Dim ItemList As IDictionaryEnumerator = htOpinion.GetEnumerator
        While ItemList.MoveNext
            key(i) = ItemList.Key
            value.Add(ItemList.Value)
            i += 1
        End While
        Try
            Dim ofrmDocumentManageBusiness As frmDocumentManageBusiness
            ofrmDocumentManageBusiness = New frmDocumentManageBusiness(ProjectCode, TaskID, CorporationName, fileType, fileCode, UserName, key, value)
            ofrmDocumentManageBusiness.AllowTransparency = False
            ofrmDocumentManageBusiness.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        htOpinion = Nothing
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSubmit.Click
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交")
            If answer = DialogResult.No Then
                Return
            End If
        End If

        Dim dsProjectFile As DataSet = gWs.GetProjectFile(ProjectCode, fileCode, fileType)
        If dsProjectFile.Tables(0).Rows.Count > 0 Then
            If IsDBNull(dsProjectFile.Tables(0).Rows(0).Item("relation_num")) Then
                SWDialogBox.MessageBox.Show("$1005", "项目暂缓意见书")
                Return
            End If
        Else
            SWDialogBox.MessageBox.Show("$1005", "项目暂缓意见书")
            Return
        End If

        Dim result As String = gWs.finishedTask(MyBase.getWorkFlowID, ProjectCode, getTaskID(), "", UserName)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "提交失败", result, "")
        Else
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            MyBase.raiseCommitSucceed()
            Close()
        End If
    End Sub
End Class
