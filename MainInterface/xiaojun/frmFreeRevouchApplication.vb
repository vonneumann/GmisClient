

Public Class frmFreeRevouchApplication
    Inherits MainInterface.frmCenCheckProjectTerminate

    'item_type=56 item_code=004  解除反担保申请
    'item_type=56 item_code=005  审核解除反担保申请
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
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents txtFreeRevouchApplicationPerson As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents dtpFreeRevouchApplicationTime As System.Windows.Forms.DateTimePicker
    Public WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtCheckRevouchApplicationPerson As System.Windows.Forms.TextBox
    Friend WithEvents dtpChekcRevouchApplicationTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbCheckRevouchApplicationConclusion As System.Windows.Forms.ComboBox
    Friend WithEvents btnRevouchApplicationSave As System.Windows.Forms.Button
    Public WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents txtCheckRevouchApplicationOpinion As System.Windows.Forms.TextBox
    Friend WithEvents txtFreeRevouchApplicationOpinion As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.btnRevouchApplicationSave = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtCheckRevouchApplicationOpinion = New System.Windows.Forms.TextBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txtCheckRevouchApplicationPerson = New System.Windows.Forms.TextBox()
        Me.dtpChekcRevouchApplicationTime = New System.Windows.Forms.DateTimePicker()
        Me.cmbCheckRevouchApplicationConclusion = New System.Windows.Forms.ComboBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.txtFreeRevouchApplicationOpinion = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.dtpFreeRevouchApplicationTime = New System.Windows.Forms.DateTimePicker()
        Me.txtFreeRevouchApplicationPerson = New System.Windows.Forms.TextBox()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Visible = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Value = New Date(2003, 6, 21, 14, 8, 20, 724)
        Me.DateTimePicker1.Visible = True
        '
        'txtDepCheckPerson
        '
        Me.txtDepCheckPerson.Visible = True
        '
        'cmbDepCheckConclusion
        '
        Me.cmbDepCheckConclusion.Visible = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Visible = True
        '
        'TabPage3
        '
        Me.TabPage3.Text = "审核(确认)项目终止报告"
        '
        'GroupBox5
        '
        Me.GroupBox5.Enabled = True
        Me.GroupBox5.Visible = True
        '
        'Label16
        '
        Me.Label16.Visible = True
        '
        'btnBuildRefundReport
        '
        Me.btnBuildRefundReport.Visible = True
        '
        'btnUploadRefundCertificate
        '
        Me.btnUploadRefundCertificate.Visible = True
        '
        'dtpRefundCheckDate
        '
        Me.dtpRefundCheckDate.Value = New Date(2003, 6, 16, 11, 6, 3, 343)
        '
        'txtRefundCheckPerson
        '
        Me.txtRefundCheckPerson.Visible = True
        '
        'txtRefundCertificateNO
        '
        'Me.txtRefundCertificateNO.Visible = True
        '
        'txtNoVouchAccount
        '
        Me.txtNoVouchAccount.Visible = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Visible = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Visible = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabPage4})
        Me.TabControl1.Visible = True
        '
        'txtProjectEvaluate
        '
        Me.txtProjectEvaluate.BackColor = System.Drawing.SystemColors.Menu
        Me.txtProjectEvaluate.ReadOnly = True
        Me.txtProjectEvaluate.Visible = True
        '
        'txtTerminateReason
        '
        Me.txtTerminateReason.BackColor = System.Drawing.SystemColors.Menu
        Me.txtTerminateReason.ReadOnly = True
        Me.txtTerminateReason.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnRevouchApplicationSave, Me.GroupBox8, Me.GroupBox7})
        Me.TabPage4.Location = New System.Drawing.Point(4, 21)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(504, 367)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "解除反担保申请"
        '
        'btnRevouchApplicationSave
        '
        Me.btnRevouchApplicationSave.Location = New System.Drawing.Point(408, 328)
        Me.btnRevouchApplicationSave.Name = "btnRevouchApplicationSave"
        Me.btnRevouchApplicationSave.Size = New System.Drawing.Size(88, 24)
        Me.btnRevouchApplicationSave.TabIndex = 2
        Me.btnRevouchApplicationSave.Text = "保存(&S)"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCheckRevouchApplicationOpinion, Me.Label34, Me.Label35, Me.Label36, Me.Label37, Me.txtCheckRevouchApplicationPerson, Me.dtpChekcRevouchApplicationTime, Me.cmbCheckRevouchApplicationConclusion})
        Me.GroupBox8.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(488, 144)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "审核解除反担保申请"
        '
        'txtCheckRevouchApplicationOpinion
        '
        Me.txtCheckRevouchApplicationOpinion.Location = New System.Drawing.Point(56, 48)
        Me.txtCheckRevouchApplicationOpinion.Multiline = True
        Me.txtCheckRevouchApplicationOpinion.Name = "txtCheckRevouchApplicationOpinion"
        Me.txtCheckRevouchApplicationOpinion.Size = New System.Drawing.Size(424, 88)
        Me.txtCheckRevouchApplicationOpinion.TabIndex = 8
        Me.txtCheckRevouchApplicationOpinion.Text = ""
        '
        'Label34
        '
        Me.Label34.Location = New System.Drawing.Point(16, 56)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(32, 16)
        Me.Label34.TabIndex = 7
        Me.Label34.Text = "意见"
        '
        'Label35
        '
        Me.Label35.Enabled = False
        Me.Label35.Location = New System.Drawing.Point(320, 24)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(64, 16)
        Me.Label35.TabIndex = 6
        Me.Label35.Text = "审核结论"
        Me.Label35.Visible = False
        '
        'Label36
        '
        Me.Label36.Location = New System.Drawing.Point(168, 24)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(48, 16)
        Me.Label36.TabIndex = 5
        Me.Label36.Text = "审核人"
        '
        'Label37
        '
        Me.Label37.Location = New System.Drawing.Point(16, 24)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(32, 16)
        Me.Label37.TabIndex = 4
        Me.Label37.Text = "时间"
        '
        'txtCheckRevouchApplicationPerson
        '
        Me.txtCheckRevouchApplicationPerson.Location = New System.Drawing.Point(216, 16)
        Me.txtCheckRevouchApplicationPerson.Name = "txtCheckRevouchApplicationPerson"
        Me.txtCheckRevouchApplicationPerson.ReadOnly = True
        Me.txtCheckRevouchApplicationPerson.Size = New System.Drawing.Size(88, 21)
        Me.txtCheckRevouchApplicationPerson.TabIndex = 2
        Me.txtCheckRevouchApplicationPerson.Text = ""
        '
        'dtpChekcRevouchApplicationTime
        '
        Me.dtpChekcRevouchApplicationTime.Enabled = False
        Me.dtpChekcRevouchApplicationTime.Location = New System.Drawing.Point(56, 16)
        Me.dtpChekcRevouchApplicationTime.Name = "dtpChekcRevouchApplicationTime"
        Me.dtpChekcRevouchApplicationTime.Size = New System.Drawing.Size(112, 21)
        Me.dtpChekcRevouchApplicationTime.TabIndex = 1
        '
        'cmbCheckRevouchApplicationConclusion
        '
        Me.cmbCheckRevouchApplicationConclusion.Enabled = False
        Me.cmbCheckRevouchApplicationConclusion.Location = New System.Drawing.Point(384, 16)
        Me.cmbCheckRevouchApplicationConclusion.Name = "cmbCheckRevouchApplicationConclusion"
        Me.cmbCheckRevouchApplicationConclusion.Size = New System.Drawing.Size(96, 20)
        Me.cmbCheckRevouchApplicationConclusion.TabIndex = 0
        Me.cmbCheckRevouchApplicationConclusion.Visible = False
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtFreeRevouchApplicationOpinion, Me.Label33, Me.Label32, Me.Label31, Me.dtpFreeRevouchApplicationTime, Me.txtFreeRevouchApplicationPerson})
        Me.GroupBox7.Enabled = False
        Me.GroupBox7.Location = New System.Drawing.Point(8, 176)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(488, 144)
        Me.GroupBox7.TabIndex = 0
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "解除反担保申请"
        Me.GroupBox7.Visible = False
        '
        'txtFreeRevouchApplicationOpinion
        '
        Me.txtFreeRevouchApplicationOpinion.Location = New System.Drawing.Point(64, 16)
        Me.txtFreeRevouchApplicationOpinion.Multiline = True
        Me.txtFreeRevouchApplicationOpinion.Name = "txtFreeRevouchApplicationOpinion"
        Me.txtFreeRevouchApplicationOpinion.Size = New System.Drawing.Size(416, 80)
        Me.txtFreeRevouchApplicationOpinion.TabIndex = 6
        Me.txtFreeRevouchApplicationOpinion.Text = ""
        '
        'Label33
        '
        Me.Label33.Location = New System.Drawing.Point(8, 24)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(56, 16)
        Me.Label33.TabIndex = 5
        Me.Label33.Text = "申请说明"
        '
        'Label32
        '
        Me.Label32.Location = New System.Drawing.Point(8, 112)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(56, 16)
        Me.Label32.TabIndex = 4
        Me.Label32.Text = "申请人员"
        '
        'Label31
        '
        Me.Label31.Location = New System.Drawing.Point(264, 112)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 16)
        Me.Label31.TabIndex = 3
        Me.Label31.Text = "申请时间"
        '
        'dtpFreeRevouchApplicationTime
        '
        Me.dtpFreeRevouchApplicationTime.Enabled = False
        Me.dtpFreeRevouchApplicationTime.Location = New System.Drawing.Point(328, 104)
        Me.dtpFreeRevouchApplicationTime.Name = "dtpFreeRevouchApplicationTime"
        Me.dtpFreeRevouchApplicationTime.Size = New System.Drawing.Size(152, 21)
        Me.dtpFreeRevouchApplicationTime.TabIndex = 2
        '
        'txtFreeRevouchApplicationPerson
        '
        Me.txtFreeRevouchApplicationPerson.Enabled = False
        Me.txtFreeRevouchApplicationPerson.Location = New System.Drawing.Point(64, 104)
        Me.txtFreeRevouchApplicationPerson.Name = "txtFreeRevouchApplicationPerson"
        Me.txtFreeRevouchApplicationPerson.ReadOnly = True
        Me.txtFreeRevouchApplicationPerson.Size = New System.Drawing.Size(160, 21)
        Me.txtFreeRevouchApplicationPerson.TabIndex = 1
        Me.txtFreeRevouchApplicationPerson.Text = ""
        '
        'frmFreeRevouchApplication
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(530, 471)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.TabControl1, Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1})
        Me.Name = "frmFreeRevouchApplication"
        Me.Text = "解除反担保申请"
        Me.GroupBox6.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ds As New DataSet()

    Protected bIsFormLoadFreeRevouchApplication As Boolean = False

    Protected Overrides Sub IniFormType()
        Me.LockGroupBox2() : LockGroupBox3()
        LockGroupBox4()
        Me.LockGroupBox5() : GroupBox5.Visible = True
        Me.LockGroupBox6() : GroupBox6.Visible = True
        LockGroupBox8() : GroupBox8.Visible = False
        btnRefundSave.Enabled = False : btnTerminateSave.Enabled = False
        btnBuildRefundReport.Enabled = False : Me.btnCheckProjectTerminateReportSave.Enabled = False
    End Sub

    Protected Overridable Sub GetRevouchApplicationData()
        ds = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.strProjectCode & "' and item_type='56' and item_code='004'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                If Not .Item("create_date") Is System.DBNull.Value Then
                    Me.dtpFreeRevouchApplicationTime.Value = .Item("create_date")
                Else
                    Me.dtpFreeRevouchApplicationTime.Value = gWs.GetSysTime()
                End If
                If Not .Item("create_person") Is System.DBNull.Value Then
                    Me.txtFreeRevouchApplicationPerson.Text = .Item("create_person")
                Else
                    Me.txtFreeRevouchApplicationPerson.Text = Me.strUserID
                End If
                If Not .Item("content") Is System.DBNull.Value Then
                    Me.txtFreeRevouchApplicationOpinion.Text = .Item("content")
                Else
                    Me.txtFreeRevouchApplicationOpinion.Text = ""
                End If
            End With
        Else
            Me.dtpFreeRevouchApplicationTime.Value = gWs.GetSysTime()
            Me.txtFreeRevouchApplicationPerson.Text = Me.strUserID
        End If
    End Sub

    Private Sub frmFreeRevouchApplication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call GetRevouchApplicationData()
        Me.bIsFormLoadFreeRevouchApplication = True
        Me.TabControl1.SelectedTab = Me.TabPage4
        btnBuildRefundReport.Enabled = True : btnBuildRefundReport.Visible = True
    End Sub

    '需要在子类覆盖该方法。
    Protected Overridable Function SaveFreeRevouchApplication() As String
        Dim ds As New DataSet()
        ds = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.strProjectCode & "' and item_type='56' and item_code='004'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                .Item("project_code") = Me.strProjectCode
                .Item("item_type") = "56"
                .Item("item_code") = "004"
                .Item("content") = Me.txtFreeRevouchApplicationOpinion.Text.Trim()
                .Item("create_date") = Me.dtpFreeRevouchApplicationTime.Value()
                .Item("create_person") = Me.strUserID
            End With
        Else
            ds = gWs.GetProjectOpinionByProjectNo("null")
            Dim NewRow As DataRow = ds.Tables(0).NewRow()
            With NewRow
                .Item("project_code") = Me.strProjectCode
                .Item("item_type") = "56"
                .Item("item_code") = "004"
                .Item("content") = Me.txtFreeRevouchApplicationOpinion.Text.Trim()
                .Item("create_date") = Me.dtpFreeRevouchApplicationTime.Value()
                .Item("create_person") = Me.strUserID
            End With
            ds.Tables(0).Rows.Add(NewRow)
        End If

        Return gWs.UpdateProjectOpinion(ds)
    End Function

    Private Sub btnRevouchApplicationSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevouchApplicationSave.Click
        Dim strUpdateResult As String
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            strUpdateResult = SaveFreeRevouchApplication()
            If Not strUpdateResult Is Nothing Then
                If strUpdateResult = "1" Then
                    ' MessageBox.Show("解除反担保申请操作成功。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    SWDialogBox.MessageBox.Show("$OperateSucceed")
                Else
                    'MessageBox.Show("解除反担保申请操作失败：" + strUpdateResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SWDialogBox.MessageBox.Show("*999", "解除反担保申请操作失败：" + strUpdateResult, "", "")
                End If
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Protected Overrides Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.isCommitConfirm = True Then
            'MessageBox.Show("是否确认提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If SWDialogBox.MessageBox.Show("?1000", "确认提交") = DialogResult.No Then
                Return
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Try
            If Me.bIsTextChange Then
                Me.strResult = Me.SaveFreeRevouchApplication()
                If Me.strResult <> "1" Then
                    'MessageBox.Show("解除反担保申请意见保存失败：" + strResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SWDialogBox.MessageBox.Show("*999", "解除反担保申请意见保存失败：", Me.strResult, "")
                    Return
                End If
                Me.bIsFormLoadFreeRevouchApplication = False : Me.bIsTextChange = False
            End If
            Call Me.CommitWorkFlow("", Me)
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub dtpFreeRevouchApplicationTime_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpFreeRevouchApplicationTime.TextChanged
        If Me.bIsFormLoadFreeRevouchApplication Then Me.bIsTextChange = True
    End Sub

    Private Sub txtFreeRevouchApplicationPerson_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFreeRevouchApplicationPerson.TextChanged
        If Me.bIsFormLoadFreeRevouchApplication Then Me.bIsTextChange = True
    End Sub

    Private Sub dtpChekcRevouchApplicationTime_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpChekcRevouchApplicationTime.TextChanged
        If Me.bIsFormLoadFreeRevouchApplication Then Me.bIsTextChange = True
    End Sub

    Private Sub txtCheckRevouchApplicationPerson_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCheckRevouchApplicationPerson.TextChanged
        If Me.bIsFormLoadFreeRevouchApplication Then Me.bIsTextChange = True
    End Sub


    Private Sub txtCheckRevouchApplicationOpinion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCheckRevouchApplicationOpinion.TextChanged
        If Me.bIsFormLoadFreeRevouchApplication Then Me.bIsTextChange = True
    End Sub

    Private Sub txtFreeRevouchApplicationOpinion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFreeRevouchApplicationOpinion.TextChanged
        If Me.bIsFormLoadFreeRevouchApplication Then Me.bIsTextChange = True
    End Sub

    Private Sub cmbCheckRevouchApplicationConclusion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbCheckRevouchApplicationConclusion.TextChanged
        If Me.bIsFormLoadFreeRevouchApplication Then Me.bIsTextChange = True
    End Sub

    Protected Overrides Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dlgResult As MsgBoxResult
        If Me.bIsTextChange Then
            'MessageBox.Show("是否保存对数据的修改？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            dlgResult = SWDialogBox.MessageBox.Show("?1003")
            If dlgResult = MsgBoxResult.Yes Then
                Me.strResult = Me.SaveFreeRevouchApplication()
                If Me.strResult <> "1" Then
                    'MessageBox.Show("项目终止报告审核失败：" + strResult, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error) '(*999)
                    SWDialogBox.MessageBox.Show("*999", "项目终止报告审核失败：", Me.strResult, "")
                    Return
                End If
                Me.Close()
                Me.bIsFormLoadFreeRevouchApplication = False : Me.bIsTextChange = False
            ElseIf dlgResult = MsgBoxResult.No Then
                Me.Close()
                Me.bIsFormLoadFreeRevouchApplication = False : Me.bIsTextChange = False
            ElseIf dlgResult = MsgBoxResult.Cancel Then
                Return
            End If
        Else
            Me.Close()
            Me.bIsFormLoadFreeRevouchApplication = False : Me.bIsTextChange = False
        End If
    End Sub

    Public Sub LockGroupBox7()
        Me.GroupBox7.Enabled = True
        Me.dtpFreeRevouchApplicationTime.Enabled = False
        Me.txtFreeRevouchApplicationOpinion.ReadOnly = True
    End Sub

    Public Sub FreeGroupBox7()
        Me.GroupBox7.Enabled = True
        Me.dtpFreeRevouchApplicationTime.Enabled = True
        Me.txtFreeRevouchApplicationOpinion.ReadOnly = False
    End Sub

    Public Sub LockGroupBox8()
        Me.GroupBox8.Enabled = True
        Me.dtpChekcRevouchApplicationTime.Enabled = False
        Me.txtCheckRevouchApplicationOpinion.ReadOnly = True
        Me.cmbCheckRevouchApplicationConclusion.Enabled = False
    End Sub

    Public Sub FreeGroupBox8()
        Me.GroupBox8.Enabled = True
        Me.dtpChekcRevouchApplicationTime.Enabled = True
        Me.txtCheckRevouchApplicationOpinion.ReadOnly = False
        Me.cmbCheckRevouchApplicationConclusion.Enabled = True
    End Sub


End Class
