'作者 罗庆锋 日期20030407
Public Class frmAfterVouchRecord
    Inherits frmWorkLog

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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmAfterVouchRecord))
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCorName
        '
        Me.txtCorName.Visible = True
        '
        'Label999
        '
        Me.Label999.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(908, 732)
        '
        'Label888
        '
        Me.Label888.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(622, 544)
        Me.btnExit.Visible = True
        '
        'grdLog
        '
        Me.grdLog.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Visible = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(448, 544)
        Me.btnCancel.Visible = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(187, 544)
        Me.btnNew.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(361, 544)
        Me.btnDelete.Visible = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(274, 544)
        Me.btnModify.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'frmAfterVouchRecord
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(874, 575)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label888, Me.Label999, Me.txtCorName, Me.txtProjectCode, Me.btnCancel, Me.btnModify, Me.btnNew, Me.btnSave, Me.btnDelete, Me.grdLog, Me.btnCommit, Me.btnExit})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAfterVouchRecord"
        Me.Text = "保后跟踪记录"
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
  
End Class
