'
'确认还款证明书。
'

Public Class frmCheckRefundInfo
    Inherits MainInterface.frmProjectTerminate

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
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents Label16 As System.Windows.Forms.Label
    Public WithEvents Label15 As System.Windows.Forms.Label
    Public WithEvents txtRefundCheckPerson As System.Windows.Forms.TextBox
    Public WithEvents Label20 As System.Windows.Forms.Label
    Public WithEvents cmbRefundCheckOpinion As System.Windows.Forms.ComboBox
    Public WithEvents dtpRefundCheckDate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtRefundCheckPerson = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.cmbRefundCheckOpinion = New System.Windows.Forms.ComboBox()
        Me.dtpRefundCheckDate = New System.Windows.Forms.DateTimePicker()
        Me.TabPage1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPage1
        '
        Me.TabPage1.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3})
        '
        'TabControl1
        '
        Me.TabControl1.ItemSize = New System.Drawing.Size(84, 17)
        Me.TabControl1.Visible = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Visible = True
        '
        'txtNoVouchAccount
        '
        Me.txtNoVouchAccount.BackColor = System.Drawing.SystemColors.Menu
        Me.txtNoVouchAccount.ReadOnly = True
        Me.txtNoVouchAccount.Visible = True
        '
        'btnUploadRefundCertificate
        '
        Me.btnUploadRefundCertificate.Enabled = False
        Me.btnUploadRefundCertificate.Text = "查看还款证明书(&R)"
        Me.btnUploadRefundCertificate.Visible = True
        '
        'btnBuildRefundReport
        '
        Me.btnBuildRefundReport.Text = "查看项目终止报告(&M)"
        Me.btnBuildRefundReport.Visible = True
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
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label16, Me.Label15, Me.txtRefundCheckPerson, Me.Label20, Me.cmbRefundCheckOpinion, Me.dtpRefundCheckDate})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 232)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(488, 56)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "确认还款证明书"
        Me.GroupBox3.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(176, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 14)
        Me.Label16.TabIndex = 50
        Me.Label16.Text = "确认人"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(16, 27)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(29, 14)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "时间"
        Me.Label15.Visible = False
        '
        'txtRefundCheckPerson
        '
        Me.txtRefundCheckPerson.BackColor = System.Drawing.SystemColors.Window
        Me.txtRefundCheckPerson.Location = New System.Drawing.Point(224, 24)
        Me.txtRefundCheckPerson.Name = "txtRefundCheckPerson"
        Me.txtRefundCheckPerson.Size = New System.Drawing.Size(80, 21)
        Me.txtRefundCheckPerson.TabIndex = 6
        Me.txtRefundCheckPerson.Text = ""
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(312, 27)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(54, 14)
        Me.Label20.TabIndex = 56
        Me.Label20.Text = "确认意见"
        Me.Label20.Visible = False
        '
        'cmbRefundCheckOpinion
        '
        Me.cmbRefundCheckOpinion.ForeColor = System.Drawing.Color.Red
        Me.cmbRefundCheckOpinion.Location = New System.Drawing.Point(368, 24)
        Me.cmbRefundCheckOpinion.Name = "cmbRefundCheckOpinion"
        Me.cmbRefundCheckOpinion.Size = New System.Drawing.Size(104, 20)
        Me.cmbRefundCheckOpinion.TabIndex = 57
        Me.cmbRefundCheckOpinion.Visible = False
        '
        'dtpRefundCheckDate
        '
        Me.dtpRefundCheckDate.Enabled = False
        Me.dtpRefundCheckDate.Location = New System.Drawing.Point(56, 24)
        Me.dtpRefundCheckDate.Name = "dtpRefundCheckDate"
        Me.dtpRefundCheckDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpRefundCheckDate.TabIndex = 5
        Me.dtpRefundCheckDate.Visible = False
        '
        'frmCheckRefundInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(530, 479)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.TabControl1})
        Me.Name = "frmCheckRefundInfo"
        Me.Text = "确认还款证明书"
        Me.TabPage1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Private Sub frmCheckRefundInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Try
    '        'Call Me.FillConclusionCombox()
    '        GetRefundCheckInfo()
    '        Me.TabPage2.Text = "确认项目终止报告" : Me.TabControl1.SelectedTab = Me.TabPage2
    '        btnBuildRefundReport.Enabled = True : btnBuildRefundReport.Visible = True
    '        btnUploadRefundCertificate.Enabled = True
    '    Catch ex As Exception
    '        'Modified by Michael
    '        'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
    '        Return
    '    End Try
    'End Sub

    'Private Sub GetRefundCheckInfo()
    '    Dim TempDS As DataSet
    '    TempDS = gWs.GetRefundCertificateInfo("{project_code='" & Me.strProjectCode & "'}")
    '    If Not TempDS.Tables(0).Rows.Count = 0 Then
    '        With TempDS.Tables(0).Rows(0)
    '            If Not .Item("affirm_person") Is System.DBNull.Value Then
    '                Me.txtRefundCheckPerson.Text = .Item("affirm_person")
    '            Else
    '                Me.txtRefundCheckPerson.Text = Me.strUserID 'Me.GetStaffName(Me.strUserID)
    '            End If
    '            If Not .Item("affirm_date") Is System.DBNull.Value Then
    '                Me.dtpRefundCheckDate.Value = .Item("affirm_date")
    '            Else
    '                Me.dtpRefundCheckDate.Value = gWs.GetSysTime()
    '            End If
    '        End With
    '    End If
    '    TempDS = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.strProjectCode & "' and item_type='56' and item_code='003'}")
    '    If Not TempDS.Tables(0).Rows.Count = 0 Then
    '        If Not TempDS.Tables(0).Rows(0).Item("conclusion") Is System.DBNull.Value Then
    '            Me.cmbRefundCheckOpinion.Text = TempDS.Tables(0).Rows(0).Item("conclusion")
    '        End If
    '    End If
    '    Call Me.GetRefundCheckOpinion()
    'End Sub

    'Private Sub GetRefundCheckOpinion()
    '    Dim tempDS As DataSet
    '    tempDS = Me.GetFinishedFlag(Me.strWorkFlowID, Me.strProjectCode, Me.strTaskID)
    '    If Not tempDS Is Nothing Then
    '        If Not tempDS.Tables(0).Rows.Count = 0 Then
    '            For i = 0 To tempDS.Tables(0).Rows.Count - 1
    '                Me.cmbRefundCheckOpinion.Items.Add(tempDS.Tables(0).Rows(i).Item("transfer_condition"))
    '            Next
    '        End If
    '    End If
    'End Sub

    'Protected Overrides Function RefundSaveData() As Boolean
    '    Try
    '        Dim tempDS As DataSet
    '        tempDS = gWs.GetRefundCertificateInfo("{project_code='" & Me.strProjectCode & "'}")
    '        If tempDS.Tables(0).Rows.Count = 0 Then
    '            'MessageBox.Show("现在没有生成相关的还款证明书，无法进行审核操作", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            SWDialogBox.MessageBox.Show("$1005", "相关的还款证明书")
    '            Me.Cursor = System.Windows.Forms.Cursors.Default
    '            Return False
    '        Else
    '            With tempDS.Tables(0).Rows(0)
    '                .Item("affirm_person") = Me.txtRefundCheckPerson.Text
    '                .Item("affirm_date") = Me.dtpRefundCheckDate.Value
    '            End With
    '        End If
    '        Dim strResult As String
    '        strResult = gWs.UpdateRefundCertificate(tempDS)
    '        If strResult <> "1" Then
    '            SWDialogBox.MessageBox.Show("*999", "还款信息更新失败", strResult, "")
    '            Return False
    '        Else
    '            tempDS.Dispose()
    '        End If
    '        tempDS = gWs.GetProjectOpinionByProjectNo("{project_code='" & Me.strProjectCode & "'and item_type='56' and item_code='003'}")
    '        If Not tempDS.Tables(0).Rows.Count = 0 Then '如果在Project_Opinion表中有数据则应该更新操作。
    '            With tempDS.Tables(0).Rows(0)
    '                .Item("project_code") = Me.strProjectCode
    '                .Item("item_type") = "56"
    '                .Item("item_code") = "003"
    '                .Item("conclusion") = Me.cmbRefundCheckOpinion.Text
    '            End With
    '        Else    '如果在Project_Opinion表中没有数据则应该新增操作。
    '            Dim dr As DataRow = tempDS.Tables(0).NewRow()
    '            With dr
    '                .Item("project_code") = Me.strProjectCode
    '                .Item("item_type") = "56"
    '                .Item("item_code") = "003"
    '                .Item("conclusion") = Me.cmbRefundCheckOpinion.Text
    '            End With
    '            tempDS.Tables(0).Rows.Add(dr)
    '        End If
    '        strResult = gWs.UpdateProjectOpinion(tempDS)
    '        If strResult <> "1" Then
    '            SWDialogBox.MessageBox.Show("*999", "更新还款证明审核意见失败", strResult, "")
    '            Return False
    '        Else
    '            tempDS.Dispose()
    '            Return True
    '        End If
    '    Catch ex As Exception
    '        SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
    '        Return False
    '    Finally
    '        Me.Cursor = Cursors.Default
    '    End Try
    'End Function

    'Protected Overrides Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    If Me.isCommitConfirm = True Then
    '        'Modified by Michal
    '        If SWDialogBox.MessageBox.Show("?1000", "确认提交") = DialogResult.No Then
    '            Return
    '        End If
    '    End If
    '    Try
    '        If Me.bIsTextChange Then
    '            If Me.intRefundChange = 1 Then
    '                Call Me.RefundSaveData()
    '                If Me.strResult <> "1" Then
    '                    Return
    '                End If
    '            End If
    '            If Me.intTerminateChange = 1 Then
    '                Call Me.TerminateSaveData()
    '                If Me.strResult <> "1" Then
    '                    Return
    '                End If
    '            End If
    '            Me.bIsFormLoad = False : Me.bIsTextChange = False
    '        End If
    '        Call Me.CommitWorkFlow("", Me)
    '    Catch ex As Exception
    '        'Modified by Micahel
    '        'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '        SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
    '        Return
    '    End Try
    'End Sub



    ''Protected Overrides Sub btnBuildRefundReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    ''    Dim frm As New frmDocumentManageBusiness(Me.strProjectCode, Me.strTaskID, Me.strEnterpriseName, "45", "004", Me.strUserID)
    ''    frm.AllowTransparency = False
    ''    frm.setIsButtonEnable(True)
    ''    frm.ShowDialog()
    ''End Sub
End Class
