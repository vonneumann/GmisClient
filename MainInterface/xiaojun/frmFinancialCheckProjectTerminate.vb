Public Class frmFinancialCheckProjectTerminate
    Inherits MainInterface.frmProjectTerminate

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmFinancialCheckProjectTerminate))
        '
        'Label8
        '
        Me.Label8.Name = "Label8"
        '
        'dtpRefundDate
        '
        Me.dtpRefundDate.Name = "dtpRefundDate"
        '
        'cboSignSubBank
        '
        Me.cboSignSubBank.Name = "cboSignSubBank"
        Me.cboSignSubBank.Size = New System.Drawing.Size(144, 20)
        '
        'btnCommit
        '
        Me.btnCommit.Name = "btnCommit"
        '
        'cboSignBank
        '
        Me.cboSignBank.Name = "cboSignBank"
        Me.cboSignBank.Size = New System.Drawing.Size(144, 20)
        '
        'pg2
        '
        Me.pg2.Name = "pg2"
        '
        'txtAppraisement
        '
        Me.txtAppraisement.Enabled = False
        Me.txtAppraisement.Name = "txtAppraisement"
        '
        'txtDetail_reason
        '
        Me.txtDetail_reason.Enabled = False
        Me.txtDetail_reason.Name = "txtDetail_reason"
        '
        'chkIs_high_risk
        '
        Me.chkIs_high_risk.Enabled = False
        Me.chkIs_high_risk.Name = "chkIs_high_risk"
        '
        'chkIs_continue_support
        '
        Me.chkIs_continue_support.Enabled = False
        Me.chkIs_continue_support.Name = "chkIs_continue_support"
        '
        'cboRefundSubBank
        '
        Me.cboRefundSubBank.Name = "cboRefundSubBank"
        Me.cboRefundSubBank.Size = New System.Drawing.Size(144, 20)
        '
        'dtpTerminate_date
        '
        Me.dtpTerminate_date.Enabled = False
        Me.dtpTerminate_date.Name = "dtpTerminate_date"
        '
        'cboRefundBank
        '
        Me.cboRefundBank.Name = "cboRefundBank"
        Me.cboRefundBank.Size = New System.Drawing.Size(144, 20)
        '
        'btnDocRefund
        '
        Me.btnDocRefund.Name = "btnDocRefund"
        Me.btnDocRefund.Visible = False
        '
        'cboTerminate_type
        '
        Me.cboTerminate_type.Enabled = False
        Me.cboTerminate_type.Name = "cboTerminate_type"
        Me.cboTerminate_type.Size = New System.Drawing.Size(160, 20)
        '
        'btnDocTerminate
        '
        Me.btnDocTerminate.Name = "btnDocTerminate"
        Me.btnDocTerminate.Visible = False
        '
        'txtGuaranteesum
        '
        Me.txtGuaranteesum.Name = "txtGuaranteesum"
        '
        'Label12
        '
        Me.Label12.Name = "Label12"
        '
        'Label3
        '
        Me.Label3.Name = "Label3"
        '
        'pg1
        '
        Me.pg1.Name = "pg1"
        '
        'Label9
        '
        Me.Label9.Name = "Label9"
        '
        'tab
        '
        Me.tab.Name = "tab"
        '
        'lblCorporationName
        '
        Me.lblCorporationName.Name = "lblCorporationName"
        '
        'txtSum
        '
        Me.txtSum.Enabled = False
        Me.txtSum.Name = "txtSum"
        '
        'GroupBox1
        '
        Me.GroupBox1.Name = "GroupBox1"
        '
        'lblProjectCode
        '
        Me.lblProjectCode.Name = "lblProjectCode"
        '
        'Label6
        '
        Me.Label6.Name = "Label6"
        '
        'GroupBox2
        '
        Me.GroupBox2.Name = "GroupBox2"
        '
        'Label4
        '
        Me.Label4.Name = "Label4"
        '
        'Label10
        '
        Me.Label10.Name = "Label10"
        '
        'Label1
        '
        Me.Label1.Name = "Label1"
        '
        'Label11
        '
        Me.Label11.Name = "Label11"
        '
        'Label2
        '
        Me.Label2.Name = "Label2"
        '
        'txtLoanContract_num
        '
        Me.txtLoanContract_num.Enabled = False
        Me.txtLoanContract_num.Name = "txtLoanContract_num"
        '
        'GroupBox3
        '
        Me.GroupBox3.Name = "GroupBox3"
        '
        'txtTerm
        '
        Me.txtTerm.Name = "txtTerm"
        '
        'Label7
        '
        Me.Label7.Name = "Label7"
        '
        'lblLoanContract_num
        '
        Me.lblLoanContract_num.Name = "lblLoanContract_num"
        '
        'btnSave
        '
        Me.btnSave.Name = "btnSave"
        '
        'txtAssureContract_num
        '
        Me.txtAssureContract_num.Enabled = False
        Me.txtAssureContract_num.Name = "txtAssureContract_num"
        '
        'lblAssureContract_num
        '
        Me.lblAssureContract_num.Name = "lblAssureContract_num"
        '
        'Label5
        '
        Me.Label5.Name = "Label5"
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Name = "txtCorporationName"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Name = "txtProjectCode"
        '
        'btnExit
        '
        Me.btnExit.Name = "btnExit"
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'frmFinancialCheckProjectTerminate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(546, 455)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "frmFinancialCheckProjectTerminate"
        Me.Text = "确认委贷还款日期"

    End Sub

#End Region

End Class
