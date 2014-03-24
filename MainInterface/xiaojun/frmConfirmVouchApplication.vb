

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
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(232, 336)
        Me.btnPrint.Visible = True
        '
        'Label9
        '
        Me.Label9.Visible = True
        '
        'cmbVouchBank
        '
        Me.cmbVouchBank.Enabled = False
        Me.cmbVouchBank.ItemHeight = 12
        Me.cmbVouchBank.Visible = True
        '
        'Label8
        '
        Me.Label8.Visible = True
        '
        'cmbVouchBranchBank
        '
        Me.cmbVouchBranchBank.Enabled = False
        Me.cmbVouchBranchBank.ItemHeight = 12
        Me.cmbVouchBranchBank.Visible = True
        '
        'Label5
        '
        Me.Label5.Visible = True
        '
        'cmbVouchTerms
        '
        Me.cmbVouchTerms.Size = New System.Drawing.Size(88, 21)
        Me.cmbVouchTerms.Visible = True
        '
        'Label6
        '
        Me.Label6.Visible = True
        '
        'cmbVouchAccount
        '
        Me.cmbVouchAccount.Enabled = False
        Me.cmbVouchAccount.Visible = True
        '
        'Label100
        '
        Me.Label100.Visible = True
        '
        'Label7
        '
        Me.Label7.Visible = True
        '
        'cmbRefundType
        '
        Me.cmbRefundType.ItemHeight = 12
        Me.cmbRefundType.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(312, 336)
        Me.btnCommit.Visible = True
        '
        'dgDatum
        '
        Me.dgDatum.Visible = True
        '
        'btnUploadReport
        '
        Me.btnUploadReport.Location = New System.Drawing.Point(8, 336)
        Me.btnUploadReport.Text = "查看放款申请(&M)"
        Me.btnUploadReport.Visible = True
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Location = New System.Drawing.Point(128, 336)
        Me.btnConferenceTrial.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(400, 336)
        Me.btnExit.Visible = True
        '
        'frmConfirmVouchApplication
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(490, 375)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnConferenceTrial, Me.btnUploadReport, Me.btnCommit, Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.GroupBox1, Me.btnPrint, Me.GroupBox2})
        Me.Name = "frmConfirmVouchApplication"
        Me.Text = "放款申请"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private ds As New DataSet()
    Private BankCode, BranchBankCode As String

    Private Sub frmConfirmVouchApplication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds = gWs.GetLoanNoticeInfo("{project_code like '" & Me.strProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Me.BankCode = IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank"))
                Me.BranchBankCode = IIf(.Item("branch_bank") Is System.DBNull.Value, "", .Item("branch_bank"))
                Me.cmbVouchAccount.Text = IIf(.Item("sum") Is System.DBNull.Value, 0, .Item("sum"))
                Me.cmbVouchTerms.Text = IIf(.Item("term") Is System.DBNull.Value, 0, .Item("term"))
                Me.cmbVouchBank.Text = Me.GetBankName(BankCode, Nothing)
                Me.cmbVouchBranchBank.Text = Me.GetBankName(BankCode, BranchBankCode)
            End With
        End If
        Me.cmbVouchAccount.Enabled = False : Me.cmbVouchTerms.Enabled = False
        Me.cmbVouchBank.Enabled = False : Me.cmbVouchBranchBank.Enabled = False
    End Sub

    Private Function GetBankName(ByVal BankCode As String, ByVal BranchBankCode As String) As String
        Dim TempDS As New DataSet()
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

End Class
