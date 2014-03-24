

Public Class frmRefundDebtTrailRecord
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRefundDebtTrailRecord))
        Me.gbxContainer.SuspendLayout()
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxContainer
        '
        Me.gbxContainer.Visible = True
        '
        'dtpWorkDate
        '
        Me.dtpWorkDate.Value = New Date(2004, 9, 14, 18, 53, 54, 953)
        Me.dtpWorkDate.Visible = True
        '
        'cboStartTime
        '
        Me.cboStartTime.ItemHeight = 12
        Me.cboStartTime.Visible = True
        '
        'Label7
        '
        Me.Label7.Visible = True
        '
        'btnSave
        '
        'Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageIndex = -1
        Me.btnSave.ImageList = Nothing
        Me.btnSave.Location = New System.Drawing.Point(535, 544)
        Me.btnSave.Visible = True
        '
        'Label5
        '
        Me.Label5.Visible = True
        '
        'Label8
        '
        Me.Label8.Visible = True
        '
        'Label6
        '
        Me.Label6.Visible = True
        '
        'Label9
        '
        Me.Label999.Visible = True
        '
        'Label4
        '
        Me.Label4.Visible = True
        '
        'Label3
        '
        Me.Label3.Visible = True
        '
        'grdLog
        '
        Me.grdLog.AccessibleName = "DataGrid"
        Me.grdLog.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdLog.Visible = True
        '
        'btnNew
        '
        'Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageIndex = -1
        Me.btnNew.ImageList = Nothing
        Me.btnNew.Location = New System.Drawing.Point(187, 544)
        Me.btnNew.Visible = True
        '
        'btnModify
        '
        'Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Bitmap)
        Me.btnModify.ImageIndex = -1
        Me.btnModify.ImageList = Nothing
        Me.btnModify.Location = New System.Drawing.Point(274, 544)
        Me.btnModify.Visible = True
        '
        'txtContent
        '
        Me.txtContent.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(908, 716)
        Me.btnCommit.Visible = True
        '
        'cboTask
        '
        Me.cboTask.DropDownWidth = 600
        Me.cboTask.ItemHeight = 12
        Me.cboTask.Visible = True
        '
        'btnDelete
        '
        'Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageIndex = -1
        Me.btnDelete.ImageList = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(361, 544)
        Me.btnDelete.Visible = True
        '
        'cboJob
        '
        Me.cboJob.ItemHeight = 12
        Me.cboJob.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'cboPost
        '
        Me.cboPost.ItemHeight = 12
        Me.cboPost.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'txtCorName
        '
        Me.txtCorName.Visible = True
        '
        'btnCancel
        '
        'Me.btnCancel.Image = CType(resources.GetObject("btnCancel.Image"), System.Drawing.Bitmap)
        Me.btnCancel.ImageIndex = -1
        Me.btnCancel.ImageList = Nothing
        Me.btnCancel.Location = New System.Drawing.Point(448, 544)
        Me.btnCancel.Visible = True
        '
        'cboEndTime
        '
        Me.cboEndTime.DropDownWidth = 600
        Me.cboEndTime.ItemHeight = 12
        Me.cboEndTime.Visible = True
        '
        'btnExit
        '
        'Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(622, 544)
        Me.btnExit.Size = New System.Drawing.Size(80, 23)
        Me.btnExit.Visible = True
        '
        'frmRefundDebtTrailRecord
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(874, 575)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label999, Me.txtCorName, Me.Label8, Me.txtProjectCode, Me.btnCancel, Me.btnModify, Me.btnNew, Me.btnSave, Me.btnDelete, Me.gbxContainer, Me.grdLog, Me.btnExit, Me.btnCommit})
        Me.Name = "frmRefundDebtTrailRecord"
        Me.Text = "登记代偿追踪活动"
        Me.gbxContainer.ResumeLayout(False)
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

End Class
