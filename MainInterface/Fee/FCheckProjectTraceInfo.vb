Public Class FCheckProjectTraceInfo
    Inherits frmCheckRecordTable
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
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gpbxOpinion.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtOpinion
        '
        Me.txtOpinion.MaxLength = 1000
        Me.txtOpinion.Size = New System.Drawing.Size(738, 92)
        Me.txtOpinion.Visible = True
        '
        'txtCorName
        '
        Me.txtCorName.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(435, 512)
        Me.btnCommit.Visible = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Size = New System.Drawing.Size(744, 80)
        Me.GroupBox3.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Size = New System.Drawing.Size(744, 136)
        Me.GroupBox1.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(8, 176)
        Me.GroupBox2.Size = New System.Drawing.Size(744, 120)
        Me.GroupBox2.Visible = True
        '
        'btnLookDocument
        '
        Me.btnLookDocument.Location = New System.Drawing.Point(291, 512)
        Me.btnLookDocument.Visible = True
        '
        'btnDetailInfo
        '
        Me.btnDetailInfo.Location = New System.Drawing.Point(163, 512)
        Me.btnDetailInfo.Visible = True
        '
        'gpbxOpinion
        '
        Me.gpbxOpinion.Location = New System.Drawing.Point(8, 392)
        Me.gpbxOpinion.Size = New System.Drawing.Size(744, 112)
        Me.gpbxOpinion.Text = "复核意见"
        Me.gpbxOpinion.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(520, 512)
        Me.btnExit.Visible = True
        '
        'FCheckProjectTraceInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(762, 543)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.GroupBox2, Me.GroupBox1, Me.btnDetailInfo, Me.btnLookDocument, Me.txtCorName, Me.txtProjectCode, Me.gpbxOpinion, Me.btnExit, Me.btnCommit})
        Me.Name = "FCheckProjectTraceInfo"
        Me.Text = "复核保后检查记录表"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.gpbxOpinion.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private ItemType As String = "55"
    Private ItemCode As String = "002"

    Protected Overrides Function SaveOpinion() As Boolean
        Dim dsOpinion As DataSet = gWs.GetProjectOpinionByProjectNo(MyBase.getProjectCode)
        Dim dr As DataRow = dsOpinion.Tables(0).NewRow
        dr("project_code") = MyBase.getProjectCode
        dr("item_type") = ItemType
        dr("item_code") = ItemCode
        dr("content") = txtOpinion.Text
        dr("create_person") = UserName
        dr("create_date") = gWs.GetSysTime
        dsOpinion.Tables(0).Rows.Add(dr)
        Dim result As String = gWs.UpdateProjectOpinion(dsOpinion.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存复核意见失败", result, "")
            Return False
        End If
        Return True
    End Function

End Class
