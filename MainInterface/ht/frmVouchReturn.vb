
'登记放款回执
Public Class frmVouchReturn
    Inherits MainInterface.frmSignVouchApplication

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
    Public WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents dtpVouchReturnEndDate As System.Windows.Forms.DateTimePicker
    Public WithEvents dtpVouchReturnStartDate As System.Windows.Forms.DateTimePicker
    Public WithEvents dtpVouchReturnSignDate As System.Windows.Forms.DateTimePicker
    Public WithEvents txtVouchReturnPerson As System.Windows.Forms.TextBox
    Friend WithEvents txtLoanofficertelphone As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtLoanofficer As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label120 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVouchReturn))
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtLoanofficertelphone = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtLoanofficer = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpVouchReturnEndDate = New System.Windows.Forms.DateTimePicker
        Me.Label15 = New System.Windows.Forms.Label
        Me.dtpVouchReturnStartDate = New System.Windows.Forms.DateTimePicker
        Me.Label120 = New System.Windows.Forms.Label
        Me.dtpVouchReturnSignDate = New System.Windows.Forms.DateTimePicker
        Me.txtVouchReturnPerson = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgLoanNotice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpLoanNotice.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(8, 296)
        Me.GroupBox3.Size = New System.Drawing.Size(624, 72)
        '
        'cmbSignVouchOpinion
        '
        Me.cmbSignVouchOpinion.DropDownWidth = 144
        Me.cmbSignVouchOpinion.ItemHeight = 12
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(8, 200)
        Me.GroupBox2.Size = New System.Drawing.Size(624, 96)
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(368, 72)
        Me.Label3.Size = New System.Drawing.Size(8, 16)
        '
        'dtpVouchDate
        '
        Me.dtpVouchDate.Location = New System.Drawing.Point(360, 72)
        '
        'cmbVouchBank
        '
        Me.cmbVouchBank.DropDownWidth = 144
        '
        'cmbRefundType
        '
        Me.cmbRefundType.DropDownWidth = 144
        '
        'dgLoanNotice
        '
        Me.dgLoanNotice.Size = New System.Drawing.Size(618, 148)
        '
        'grpLoanNotice
        '
        Me.grpLoanNotice.Location = New System.Drawing.Point(8, 32)
        Me.grpLoanNotice.Size = New System.Drawing.Size(624, 168)
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(248, 448)
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 3
        Me.btnSave.TabStop = True
        '
        'btnViewAffirmContent
        '
        Me.btnViewAffirmContent.ImageIndex = 26
        Me.btnViewAffirmContent.Location = New System.Drawing.Point(73, 496)
        '
        'btnAdd
        '
        Me.btnAdd.ImageIndex = 26
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(56, 56)
        Me.GroupBox1.Size = New System.Drawing.Size(416, 32)
        '
        'btnCommit
        '
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Image)
        Me.btnCommit.Location = New System.Drawing.Point(336, 448)
        Me.btnCommit.TabIndex = 2
        '
        'dgDatum
        '
        Me.dgDatum.Size = New System.Drawing.Size(410, 12)
        '
        'btnUploadReport
        '
        Me.btnUploadReport.Image = CType(resources.GetObject("btnUploadReport.Image"), System.Drawing.Image)
        Me.btnUploadReport.Location = New System.Drawing.Point(161, 496)
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Image = CType(resources.GetObject("btnConferenceTrial.Image"), System.Drawing.Image)
        Me.btnConferenceTrial.Location = New System.Drawing.Point(128, 448)
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Location = New System.Drawing.Point(272, 8)
        Me.txtEnterpriseName.Size = New System.Drawing.Size(360, 21)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(424, 448)
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.Images.SetKeyName(0, "")
        Me.ImageListBasic.Images.SetKeyName(1, "")
        Me.ImageListBasic.Images.SetKeyName(2, "")
        Me.ImageListBasic.Images.SetKeyName(3, "")
        Me.ImageListBasic.Images.SetKeyName(4, "")
        Me.ImageListBasic.Images.SetKeyName(5, "")
        Me.ImageListBasic.Images.SetKeyName(6, "")
        Me.ImageListBasic.Images.SetKeyName(7, "")
        Me.ImageListBasic.Images.SetKeyName(8, "")
        Me.ImageListBasic.Images.SetKeyName(9, "")
        Me.ImageListBasic.Images.SetKeyName(10, "")
        Me.ImageListBasic.Images.SetKeyName(11, "")
        Me.ImageListBasic.Images.SetKeyName(12, "")
        Me.ImageListBasic.Images.SetKeyName(13, "")
        Me.ImageListBasic.Images.SetKeyName(14, "")
        Me.ImageListBasic.Images.SetKeyName(15, "")
        Me.ImageListBasic.Images.SetKeyName(16, "")
        Me.ImageListBasic.Images.SetKeyName(17, "")
        Me.ImageListBasic.Images.SetKeyName(18, "")
        Me.ImageListBasic.Images.SetKeyName(19, "")
        Me.ImageListBasic.Images.SetKeyName(20, "")
        Me.ImageListBasic.Images.SetKeyName(21, "")
        Me.ImageListBasic.Images.SetKeyName(22, "")
        Me.ImageListBasic.Images.SetKeyName(23, "")
        Me.ImageListBasic.Images.SetKeyName(24, "")
        Me.ImageListBasic.Images.SetKeyName(25, "")
        Me.ImageListBasic.Images.SetKeyName(26, "")
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txtLoanofficertelphone)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.txtLoanofficer)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.dtpVouchReturnEndDate)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.dtpVouchReturnStartDate)
        Me.GroupBox4.Controls.Add(Me.Label120)
        Me.GroupBox4.Controls.Add(Me.dtpVouchReturnSignDate)
        Me.GroupBox4.Controls.Add(Me.txtVouchReturnPerson)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 368)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(624, 72)
        Me.GroupBox4.TabIndex = 9
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "登记放款回执"
        '
        'txtLoanofficertelphone
        '
        Me.txtLoanofficertelphone.Location = New System.Drawing.Point(306, 48)
        Me.txtLoanofficertelphone.Name = "txtLoanofficertelphone"
        Me.txtLoanofficertelphone.Size = New System.Drawing.Size(120, 21)
        Me.txtLoanofficertelphone.TabIndex = 22
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(247, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "联系电话"
        '
        'txtLoanofficer
        '
        Me.txtLoanofficer.Location = New System.Drawing.Point(112, 45)
        Me.txtLoanofficer.Name = "txtLoanofficer"
        Me.txtLoanofficer.Size = New System.Drawing.Size(113, 21)
        Me.txtLoanofficer.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(24, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 12)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "信贷员"
        '
        'dtpVouchReturnEndDate
        '
        Me.dtpVouchReturnEndDate.Location = New System.Drawing.Point(307, 17)
        Me.dtpVouchReturnEndDate.Name = "dtpVouchReturnEndDate"
        Me.dtpVouchReturnEndDate.Size = New System.Drawing.Size(119, 21)
        Me.dtpVouchReturnEndDate.TabIndex = 18
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(247, 22)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 16)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "贷款期止"
        '
        'dtpVouchReturnStartDate
        '
        Me.dtpVouchReturnStartDate.Location = New System.Drawing.Point(112, 16)
        Me.dtpVouchReturnStartDate.Name = "dtpVouchReturnStartDate"
        Me.dtpVouchReturnStartDate.Size = New System.Drawing.Size(113, 21)
        Me.dtpVouchReturnStartDate.TabIndex = 16
        '
        'Label120
        '
        Me.Label120.Location = New System.Drawing.Point(24, 21)
        Me.Label120.Name = "Label120"
        Me.Label120.Size = New System.Drawing.Size(54, 16)
        Me.Label120.TabIndex = 15
        Me.Label120.Text = "贷款期起"
        '
        'dtpVouchReturnSignDate
        '
        Me.dtpVouchReturnSignDate.Enabled = False
        Me.dtpVouchReturnSignDate.Location = New System.Drawing.Point(592, 48)
        Me.dtpVouchReturnSignDate.Name = "dtpVouchReturnSignDate"
        Me.dtpVouchReturnSignDate.Size = New System.Drawing.Size(8, 21)
        Me.dtpVouchReturnSignDate.TabIndex = 14
        Me.dtpVouchReturnSignDate.Visible = False
        '
        'txtVouchReturnPerson
        '
        Me.txtVouchReturnPerson.BackColor = System.Drawing.Color.Gainsboro
        Me.txtVouchReturnPerson.Location = New System.Drawing.Point(480, 45)
        Me.txtVouchReturnPerson.Name = "txtVouchReturnPerson"
        Me.txtVouchReturnPerson.ReadOnly = True
        Me.txtVouchReturnPerson.Size = New System.Drawing.Size(120, 21)
        Me.txtVouchReturnPerson.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(432, 50)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 16)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "登记人"
        '
        'Label14
        '
        Me.Label14.Enabled = False
        Me.Label14.Location = New System.Drawing.Point(578, 51)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(8, 16)
        Me.Label14.TabIndex = 5
        Me.Label14.Text = "登记日期"
        Me.Label14.Visible = False
        '
        'frmVouchReturn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(642, 479)
        Me.Controls.Add(Me.GroupBox4)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "frmVouchReturn"
        Me.Text = "登记放款回执"
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.Controls.SetChildIndex(Me.txtEnterpriseName, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.btnUploadReport, 0)
        Me.Controls.SetChildIndex(Me.btnConferenceTrial, 0)
        Me.Controls.SetChildIndex(Me.grpLoanNotice, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnViewAffirmContent, 0)
        Me.Controls.SetChildIndex(Me.btnAdd, 0)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgLoanNotice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpLoanNotice.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private ds As DataSet
    Private strUpdateResult As String
    Private bIsVouchReturnFormLoad As Boolean

    Private Sub frmVouchReturn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            'Me.GroupBox3.Enabled = False
            Me.bIsVouchReturnFormLoad = False
            Call Me.SignVouchApplicationLockContral()
            Call Me.GetVouchReturnData()
            Me.cmbVouchTerms.Enabled = False
            Me.bIsVouchReturnFormLoad = True
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub GetVouchReturnData()
        ds = gWs.GetLoanNoticeInfo("{project_code='" & Me.strProjectCode & "' order by create_date desc}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                If Not .Item("start_date") Is System.DBNull.Value Then
                    Me.dtpVouchReturnStartDate.Value = .Item("start_date")
                Else
                    Me.dtpVouchReturnStartDate.Value = gWs.GetSysTime()
                End If
                If Not .Item("end_date") Is System.DBNull.Value Then
                    Me.dtpVouchReturnEndDate.Value = .Item("end_date")
                Else
                    Me.dtpVouchReturnEndDate.Value = gWs.GetSysTime()
                End If
                If Not .Item("register_person") Is System.DBNull.Value Then
                    Me.txtVouchReturnPerson.Text = .Item("register_person")
                Else
                    Me.txtVouchReturnPerson.Text = Me.strUserID
                End If
                If Not .Item("register_date") Is System.DBNull.Value Then
                    Me.dtpVouchReturnSignDate.Value = .Item("register_date")
                Else
                    Me.dtpVouchReturnSignDate.Value = gWs.GetSysTime()
                End If
                If Not .Item("loan_officer") Is System.DBNull.Value Then
                    Me.txtLoanofficer.Text = .Item("loan_officer")                
                End If
                
                If Not .Item("loan_officer_telephone") Is System.DBNull.Value Then
                    Me.txtLoanofficertelphone.Text = .Item("loan_officer_telephone")
                End If


            End With
        End If
    End Sub

    Protected Overrides Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strTemp As String
        If Me.isCommitConfirm = True Then
            'If MessageBox.Show("是否确认提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            If SWDialogBox.MessageBox.Show("?1000", "") = DialogResult.No Then
                Return
            End If
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            strTemp = Me.SaveData()
            If strTemp Is Nothing Then
                Return
            End If
           
            If strTemp <> "1" Then
                'MessageBox.Show("数据保存失败：" + strTemp, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                SWDialogBox.MessageBox.Show("*999", "frmVouchReturn.btnCommit_Click", strTemp, "Me.SaveData")
                Return
            Else
                Me.bIsVouchReturnFormLoad = False : Me.bIsTextChange = False
            End If
            Me.CommitWorkFlow("", Me)
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Protected Overrides Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim strTemp As String
        strTemp = Me.SaveData()

        If strTemp Is Nothing Then
            Return
        End If
        If strTemp <> "1" Then
            'MessageBox.Show("数据保存失败：" + strTemp, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("*999", "frmVouchReturn.btnCommit_Click", strTemp, "Me.SaveData")
            Return
        Else
            'MessageBox.Show("数据保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            SWDialogBox.MessageBox.Show("$SaveSucceed")
            Me.bIsVouchReturnFormLoad = False : Me.bIsTextChange = False
        End If
    End Sub

    Private Function SaveData() As String
        If Me.dtpVouchReturnStartDate.Value.Date.CompareTo(Me.dtpVouchReturnEndDate.Value.Date) >= 0 Then
            'MessageBox.Show("放款起始日期应小于放款截止日期。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            SWDialogBox.MessageBox.Show("$1008", "放款起始日期", "放款截止日期")
            Me.dtpVouchReturnStartDate.Focus()
            Return Nothing
        End If
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            If txtLoanofficer.Text = "" Or txtLoanofficertelphone.Text = "" Then
                '    MsgBox("信贷员项不能为空", MsgBoxStyle.OkOnly, "错误信息")
                '    Return "文本框不能空白！"
                'Else
                'End If
                'If txtLoanofficertelphone.Text = "" Then
                MsgBox("信贷员信息不能为空", MsgBoxStyle.OkOnly, "错误信息")
                Return "文本框不能空白！"
            End If
            ds = gWs.GetLoanNoticeInfo("{project_code='" & Me.strProjectCode & "' order by create_date desc}")
            If Not ds.Tables(0).Rows.Count = 0 Then
                With ds.Tables(0).Rows(0)
                    .Item("register_person") = Me.strUserID
                    .Item("register_date") = Me.dtpVouchReturnSignDate.Value
                    .Item("start_date") = Me.dtpVouchReturnStartDate.Value
                    .Item("end_date") = Me.dtpVouchReturnEndDate.Value
                    .Item("loan_officer") = Me.txtLoanofficer.Text
                    .Item("loan_officer_telephone") = Me.txtLoanofficertelphone.Text


                End With
                Return gWs.UpdateLoanNotice(ds)
            End If
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
            Return ex.Message
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Function

    Private Sub dtpVouchReturnSignDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpVouchReturnSignDate.TextChanged
        If Me.bIsVouchReturnFormLoad Then Me.bIsTextChange = True
    End Sub

    Private Sub dtpVouchReturnStartDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpVouchReturnStartDate.TextChanged
        If bIsVouchReturnFormLoad = True Then
            Dim i As Integer
            i = Convert.ToInt16(Me.cmbVouchTerms.Text.Trim())
            Me.dtpVouchReturnEndDate.Value = Convert.ToDateTime(Me.dtpVouchReturnStartDate.Value.AddMonths(i))
            If Me.bIsVouchReturnFormLoad Then Me.bIsTextChange = True
        End If
    End Sub

    Private Sub dtpVouchReturnEndDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpVouchReturnEndDate.TextChanged
        If Me.bIsVouchReturnFormLoad Then Me.bIsTextChange = True
    End Sub
    '退出按钮
    Protected Overrides Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dlgResult As MsgBoxResult
        Dim strTemp As String

        If Me.bIsTextChange Then
            'dlgResult = MessageBox.Show("是否保存对数据的修改？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            dlgResult = SWDialogBox.MessageBox.Show("?1003")
            If dlgResult = MsgBoxResult.Yes Then
                strTemp = Me.SaveData()
                If strTemp Is Nothing Then
                    Return
                End If
                If strTemp <> "1" Then
                    'MessageBox.Show("数据保存失败：" + strTemp, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    SWDialogBox.MessageBox.Show("*999", "frmVouchReturn.btnExit_Click", strTemp, "Me.SaveData")
                    Return
                Else
                    Me.Close()
                    Me.bIsVouchReturnFormLoad = False : Me.bIsTextChange = False
                End If
            ElseIf dlgResult = MsgBoxResult.No Then
                Me.Close()
                Me.bIsVouchReturnFormLoad = False : Me.bIsTextChange = False
            ElseIf dlgResult = MsgBoxResult.Cancel Then
                Return
            End If
        Else
            Me.Close()
            Me.bIsVouchReturnFormLoad = False : Me.bIsTextChange = False
        End If
    End Sub

    '鼠标选中datagrid中的项，设置下面的控件
    Protected Overrides Sub dgLoanNotice_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim currentRow As Integer = Me.dgLoanNotice.CurrentRowIndex
        Me.dgLoanNotice.Select(currentRow)

        Me.cmbVouchBank.Text = Me.dgLoanNotice.Item(currentRow, 1)
        Me.cmbVouchBranchBank.Text = Me.dgLoanNotice.Item(currentRow, 2)
        Me.cmbVouchAccount.Text = Me.dgLoanNotice.Item(currentRow, 3)
        Me.cmbVouchTerms.Text = Me.dgLoanNotice.Item(currentRow, 4)

        If currentRow = Me.dsLoanNotice.Tables(0).Rows.Count - 1 Then
            Me.GroupBox2.Text = "当前的放款信息"
        Else
            Me.GroupBox2.Text = "已有的放款信息"
        End If
    End Sub

    
    
End Class
