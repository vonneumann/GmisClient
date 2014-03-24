

Public Class FRegisterDischargeRecord
    Inherits frmWorkLog
    Private fileType As String = "43" '法律文本
    Private fileCode As String = "301"
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
    Friend WithEvents btnDocument As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FRegisterDischargeRecord))
        Me.btnDocument = New System.Windows.Forms.Button()
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCorName
        '
        Me.txtCorName.Visible = True
        '
        'Label888
        '
        Me.Label888.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(908, 716)
        '
        'Label999
        '
        Me.Label999.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'btnCancel
        '
        Me.btnCancel.Visible = True
        '
        'grdLog
        '
        Me.grdLog.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Visible = True
        '
        'btnNew
        '
        Me.btnNew.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnModify
        '
        Me.btnModify.Visible = True
        '
        'btnDocument
        '
        Me.btnDocument.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDocument.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnDocument.Image = CType(resources.GetObject("btnDocument.Image"), System.Drawing.Bitmap)
        Me.btnDocument.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDocument.ImageIndex = 5
        Me.btnDocument.ImageList = Me.ImageList1
        Me.btnDocument.Location = New System.Drawing.Point(59, 543)
        Me.btnDocument.Name = "btnDocument"
        Me.btnDocument.Size = New System.Drawing.Size(96, 24)
        Me.btnDocument.TabIndex = 13
        Me.btnDocument.Text = "制作文档(&T)"
        Me.btnDocument.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FRegisterDischargeRecord
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(874, 575)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnCancel, Me.btnModify, Me.btnNew, Me.btnSave, Me.btnDelete, Me.Label888, Me.Label999, Me.txtCorName, Me.txtProjectCode, Me.grdLog, Me.btnCommit, Me.btnDocument})
        Me.Name = "FRegisterDischargeRecord"
        Me.Text = "登记追偿活动"
        CType(Me.grdLog, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub MakeDocument(ByVal sender As Object, ByVal e As EventArgs) Handles btnDocument.Click
        Try
            Dim ofrmDocumentManageBusiness As frmDocumentManageBusiness
            ofrmDocumentManageBusiness = New frmDocumentManageBusiness(ProjectCode, TaskID, CorporationName, fileType, fileCode, UserName)
            ofrmDocumentManageBusiness.AllowTransparency = False
            ofrmDocumentManageBusiness.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
End Class
