Public Class frmConfirmVouchApplicationExp
    Inherits MainInterface.frmVouchApplicationExp

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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmConfirmVouchApplicationExp))
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuery
        '
        Me.btnQuery.Location = New System.Drawing.Point(248, 352)
        Me.btnQuery.Name = "btnQuery"
        '
        'dgDatum
        '
        Me.dgDatum.Name = "dgDatum"
        '
        'btnCommit
        '
        Me.btnCommit.Name = "btnCommit"
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Name = "btnConferenceTrial"
        '
        'btnUploadReport
        '
        Me.btnUploadReport.Location = New System.Drawing.Point(128, 353)
        Me.btnUploadReport.Name = "btnUploadReport"
        '
        'GroupBox1
        '
        Me.GroupBox1.Name = "GroupBox1"
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Name = "txtEnterpriseName"
        '
        'Label1
        '
        Me.Label1.Name = "Label1"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Name = "txtProjectCode"
        '
        'Label2
        '
        Me.Label2.Name = "Label2"
        '
        'btnExit
        '
        Me.btnExit.Name = "btnExit"
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'frmConfirmVouchApplicationExp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(554, 384)
        Me.Name = "frmConfirmVouchApplicationExp"
        Me.Text = "展期申请(展期)"
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
