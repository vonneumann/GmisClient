
'放款申请
Public Class frmConfirmVouchApplication
    Inherits MainInterface.frmVouchApplication

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmConfirmVouchApplication))
        Me.grpLoanNotice.SuspendLayout()
        CType(Me.dgLoanNotice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Visible = True
        '
        'Label8
        '
        Me.Label8.Visible = True
        '
        'Label6
        '
        Me.Label6.Visible = True
        '
        'lblAssureContract_num
        '
        Me.lblAssureContract_num.Visible = True
        '
        'txtAssureContract_num
        '
        Me.txtAssureContract_num.Visible = True
        '
        'lblLoanContract_num
        '
        Me.lblLoanContract_num.Visible = True
        '
        'txtLoanContract_num
        '
        Me.txtLoanContract_num.Visible = True
        '
        'btnViewAffirmContent
        '
        Me.btnViewAffirmContent.Image = Nothing
        Me.btnViewAffirmContent.ImageIndex = 3
        Me.btnViewAffirmContent.ImageList = Me.ImageListBasic
        Me.btnViewAffirmContent.Location = New System.Drawing.Point(76, 464)
        Me.btnViewAffirmContent.Size = New System.Drawing.Size(96, 23)
        Me.btnViewAffirmContent.Visible = True
        '
        'grpLoanNotice
        '
        Me.grpLoanNotice.Visible = True
        '
        'Label5
        '
        Me.Label5.Visible = True
        '
        'dgLoanNotice
        '
        Me.dgLoanNotice.AccessibleName = "DataGrid"
        Me.dgLoanNotice.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgLoanNotice.Visible = True
        '
        'Label7
        '
        Me.Label7.Visible = True
        '
        'cmbVouchTerms
        '
        Me.cmbVouchTerms.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbVouchTerms.ReadOnly = True
        Me.cmbVouchTerms.Visible = True
        '
        'cmbVouchAccount
        '
        Me.cmbVouchAccount.BackColor = System.Drawing.Color.Gainsboro
        Me.cmbVouchAccount.ReadOnly = True
        Me.cmbVouchAccount.Visible = True
        '
        'cmbRefundType
        '
        Me.cmbRefundType.ItemHeight = 12
        Me.cmbRefundType.Visible = True
        '
        'cmbVouchBranchBank
        '
        Me.cmbVouchBranchBank.Enabled = False
        Me.cmbVouchBranchBank.ItemHeight = 12
        Me.cmbVouchBranchBank.Visible = True
        '
        'cmbVouchBank
        '
        Me.cmbVouchBank.Enabled = False
        Me.cmbVouchBank.ItemHeight = 12
        Me.cmbVouchBank.Visible = True
        '
        'btnAdd
        '
        Me.btnAdd.Image = Nothing
        Me.btnAdd.ImageIndex = 26
        Me.btnAdd.ImageList = Nothing
        Me.btnAdd.Location = New System.Drawing.Point(16, 464)
        Me.btnAdd.Size = New System.Drawing.Size(32, 24)
        Me.btnAdd.Visible = False
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageIndex = -1
        Me.btnSave.ImageList = Nothing
        Me.btnSave.Location = New System.Drawing.Point(32, 464)
        Me.btnSave.Size = New System.Drawing.Size(0, 0)
        Me.btnSave.TabStop = False
        Me.btnSave.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)
        Me.GroupBox2.Visible = True
        '
        'dgDatum
        '
        Me.dgDatum.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.Location = New System.Drawing.Point(428, 464)
        Me.btnCommit.TabIndex = 2
        Me.btnCommit.Visible = True
        '
        'btnUploadReport
        '
        Me.btnUploadReport.Image = CType(resources.GetObject("btnUploadReport.Image"), System.Drawing.Bitmap)
        Me.btnUploadReport.Location = New System.Drawing.Point(180, 464)
        Me.btnUploadReport.TabIndex = 0
        Me.btnUploadReport.Text = "查看放款申请(&M)"
        Me.btnUploadReport.Visible = True
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Image = CType(resources.GetObject("btnConferenceTrial.Image"), System.Drawing.Bitmap)
        Me.btnConferenceTrial.Location = New System.Drawing.Point(308, 464)
        Me.btnConferenceTrial.TabIndex = 1
        Me.btnConferenceTrial.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(513, 464)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'frmConfirmVouchApplication
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(666, 495)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnAdd, Me.btnViewAffirmContent, Me.btnSave, Me.grpLoanNotice, Me.btnConferenceTrial, Me.btnUploadReport, Me.btnCommit, Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.GroupBox1, Me.GroupBox2})
        Me.Name = "frmConfirmVouchApplication"
        Me.Text = "放款申请"
        Me.grpLoanNotice.ResumeLayout(False)
        CType(Me.dgLoanNotice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ds As DataSet
    Private BankCode, BranchBankCode As String

    Private Sub frmConfirmVouchApplication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Me.cmbVouchAccount.Enabled = False : Me.cmbVouchTerms.Enabled = False
            Me.cmbVouchBank.Enabled = False : Me.cmbVouchBranchBank.Enabled = False
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Function GetBankName(ByVal BankCode As String, ByVal BranchBankCode As String) As String
        Dim TempDS As DataSet
        If BranchBankCode = Nothing Then    '取得银行名称。
            TempDS = gWs.GetBankInfo("{bank_code='" & BankCode & "'}", "null")
            If Not TempDS.Tables(0).Rows(0).Item("bank_name") Is System.DBNull.Value Then
                Return TempDS.Tables(0).Rows(0).Item("bank_name")
            End If
        Else    '取得银行支行名称
            TempDS = gWs.GetBankInfo("null", "{bank_code='" & BankCode & "' and branch_bank_code='" & BranchBankCode & "'}")
            If Not TempDS.Tables(1).Rows(0).Item("branch_bank_name") Is System.DBNull.Value Then
                Return TempDS.Tables(1).Rows(0).Item("branch_bank_name")
            End If
        End If
    End Function
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

    Protected Overrides Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'If MessageBox.Show("是否确认提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
        If SWDialogBox.MessageBox.Show("?1000", "提交") = DialogResult.No Then
            Return
        End If
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Me.CommitWorkFlow("", Me)
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Protected Overrides Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

End Class
