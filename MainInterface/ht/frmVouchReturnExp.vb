Public Class frmVouchReturnExp
    Inherits frmBasic

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写 dispose 以清理组件列表。
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents txtExpandTerm As System.Windows.Forms.TextBox
    Friend WithEvents txtExpandAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label49 As System.Windows.Forms.Label
    Public WithEvents ImageListBasic As System.Windows.Forms.ImageList
    Public WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents btnCommit As System.Windows.Forms.Button
    Public WithEvents dEndTime As System.Windows.Forms.DateTimePicker
    Public WithEvents dStartTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVouchReturnExp))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dEndTime = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.dStartTime = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label46 = New System.Windows.Forms.Label
        Me.txtExpandTerm = New System.Windows.Forms.TextBox
        Me.txtExpandAmount = New System.Windows.Forms.TextBox
        Me.Label49 = New System.Windows.Forms.Label
        Me.ImageListBasic = New System.Windows.Forms.ImageList(Me.components)
        Me.btnExit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCorporationName = New System.Windows.Forms.TextBox
        Me.txtProjectCode = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCommit = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dEndTime)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.dStartTime)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label46)
        Me.GroupBox2.Controls.Add(Me.txtExpandTerm)
        Me.GroupBox2.Controls.Add(Me.txtExpandAmount)
        Me.GroupBox2.Controls.Add(Me.Label49)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 72)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(552, 160)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        '
        'dEndTime
        '
        Me.dEndTime.Location = New System.Drawing.Point(392, 104)
        Me.dEndTime.Name = "dEndTime"
        Me.dEndTime.Size = New System.Drawing.Size(112, 21)
        Me.dEndTime.TabIndex = 59
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(320, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 16)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "展期到期日"
        '
        'dStartTime
        '
        Me.dStartTime.Location = New System.Drawing.Point(112, 104)
        Me.dStartTime.Name = "dStartTime"
        Me.dStartTime.Size = New System.Drawing.Size(120, 21)
        Me.dStartTime.TabIndex = 57
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 16)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "展期起始日"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(304, 40)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(79, 17)
        Me.Label46.TabIndex = 55
        Me.Label46.Text = "展期期限(月)"
        Me.Label46.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExpandTerm
        '
        Me.txtExpandTerm.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtExpandTerm.Location = New System.Drawing.Point(392, 40)
        Me.txtExpandTerm.Name = "txtExpandTerm"
        Me.txtExpandTerm.Size = New System.Drawing.Size(144, 21)
        Me.txtExpandTerm.TabIndex = 54
        Me.txtExpandTerm.Text = ""
        '
        'txtExpandAmount
        '
        Me.txtExpandAmount.Location = New System.Drawing.Point(112, 40)
        Me.txtExpandAmount.Name = "txtExpandAmount"
        Me.txtExpandAmount.Size = New System.Drawing.Size(168, 21)
        Me.txtExpandAmount.TabIndex = 52
        Me.txtExpandAmount.Text = ""
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.Location = New System.Drawing.Point(8, 40)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(91, 17)
        Me.Label49.TabIndex = 53
        Me.Label49.Text = "展期金额(万元)"
        Me.Label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnExit
        '
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 4
        Me.btnExit.ImageList = Me.ImageListBasic
        Me.btnExit.Location = New System.Drawing.Point(480, 240)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtCorporationName)
        Me.GroupBox1.Controls.Add(Me.txtProjectCode)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(552, 64)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "企业名称"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCorporationName.Enabled = False
        Me.txtCorporationName.Location = New System.Drawing.Point(280, 24)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.Size = New System.Drawing.Size(256, 21)
        Me.txtCorporationName.TabIndex = 58
        Me.txtCorporationName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Enabled = False
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 24)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(112, 21)
        Me.txtProjectCode.TabIndex = 56
        Me.txtProjectCode.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "项目编码"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(392, 240)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 10
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmVouchReturnExp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(576, 270)
        Me.Controls.Add(Me.btnCommit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmVouchReturnExp"
        Me.Text = "登记展期回执"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim dsProjectExp As DataSet

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        Me.Cursor = Cursors.WaitCursor
        If SWDialogBox.MessageBox.Show("?1000", "提交") <> MsgBoxResult.Yes Then
            Return
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            If dsProjectExp.Tables(0).Rows.Count <> 0 Then
                Dim dr As DataRow = dsProjectExp.Tables(0).Rows(0)
                With dr
                    .Item("exp_start_time") = dStartTime.Value
                    .Item("exp_end_time") = dEndTime.Value
                End With
            End If
            gWs.UpdateProjectExpandDate(dsProjectExp)

            '2007－12－18 yjf add 修改放款截至日
            Dim dsLoan As DataSet = gWs.GetLoanNoticeInfo("{project_code='" & MyBase.getProjectCode & "' order by notice_code desc}")
            If dsLoan.Tables(0).Rows.Count <> 0 Then
                dsLoan.Tables(0).Rows(0).Item("end_date") = dEndTime.Value
            End If
            gWs.UpdateLoanNotice(dsLoan)

            Dim strResult As String = gWs.finishedTask(Me.getWorkFlowID(), Me.getProjectCode(), Me.getTaskID(), "", UserName)
            If Not strResult = "1" Then
                SWDialogBox.MessageBox.Show("*999", "提交失败", strResult, "登记展期回执")
            Else
                MyBase.raiseCommitSucceed()
                SWDialogBox.MessageBox.Show("$SubmitSucceed")
                Close()
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub


    Private Sub frmVouchReturnExp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtProjectCode.Text = MyBase.getProjectCode
        Me.txtCorporationName.Text = MyBase.getCorporationName

        dsProjectExp = gWs.GetProjectExpandDateInfo("{project_code='" & MyBase.getProjectCode & "'}")
        If dsProjectExp.Tables(0).Rows.Count <> 0 Then
            Dim dr As DataRow = dsProjectExp.Tables(0).Rows(0)
            With dr
                Me.txtExpandAmount.Text = IIf(IsDBNull(.Item("exp_amount")), "", .Item("exp_amount"))
                Me.txtExpandTerm.Text = IIf(IsDBNull(.Item("exp_term")), "", .Item("exp_term"))
            End With
        End If
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
