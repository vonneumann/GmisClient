
Public Class frmConfirmProjectDelay
    Inherits MainInterface.frmConfirmItem

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
        Me.SuspendLayout()
        '
        'txtOpinion
        '
        Me.txtOpinion.Visible = True
        '
        'Label10
        '
        Me.Label10.Text = "确认项目暂缓结论"
        Me.Label10.Visible = True
        '
        'Label11
        '
        Me.Label11.Text = "确认项目暂缓意见"
        Me.Label11.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Visible = True
        '
        'cmbConclusion
        '
        Me.cmbConclusion.Visible = True
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Visible = True
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
        Me.btnExit.Visible = True
        '
        'frmConfirmProjectDelay
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(546, 391)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnCommit, Me.btnOpenFile, Me.btnSave, Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1})
        Me.Name = "frmConfirmProjectDelay"
        Me.Text = "确认项目暂缓"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmConfirmProjectDelay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Me.strItemType = "52" : Me.strItemCode = "006" '中心主任确认项目暂缓意见
            Call Me.GetIniData(Me.strItemType, Me.strItemCode)
            Me.bIsFormLoad = True
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub btnOpenFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenFile.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Call Me.OpenFile("45", "005")    '打开项目处理意见表
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Sub txtOpinion_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOpinion.TextChanged
        If Me.bIsFormLoad Then Me.bIsTextChanged = True
    End Sub

    Private Sub cmbConclusion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbConclusion.TextChanged
        If Me.bIsFormLoad Then Me.bIsTextChanged = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Call Me.SaveData(Me.strItemType, Me.strItemCode)
    End Sub
End Class
