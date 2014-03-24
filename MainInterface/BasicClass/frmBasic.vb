Public Class frmBasic
    Inherits System.Windows.Forms.Form
    Implements IApplyTool

    '
    'Author quexd
    'Date Created  2003-4-5
    'Modificate Date
    '
    Private strProjectCode As String '项目编码
    Private strCorporatioName As String '企业名称
    Private strWorkFlowID As String '工作流ID 
    Private strTaskID As String '任务ID
    Private strUser As String '用户名
    Private strRoleID As String '角色id

    Public isCommitConfirm As Boolean = True

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
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents ImageListBasic As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBasic))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ImageListBasic = New System.Windows.Forms.ImageList(Me.components)
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 4
        Me.btnExit.ImageList = Me.ImageListBasic
        Me.btnExit.Location = New System.Drawing.Point(480, 400)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageListBasic.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.TransparentColor = System.Drawing.Color.Transparent
        '
        'frmBasic
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 435)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmBasic"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "请修改标题"
        Me.TransparencyKey = System.Drawing.Color.White
        Me.ResumeLayout(False)

    End Sub

#End Region

    '
    '实现接口
    '
    Private Event CommitSucceed() Implements IApplyTool.CommitSucceed
    '激活事件
    Public Sub raiseCommitSucceed()
        RaiseEvent CommitSucceed()
    End Sub
    Public Sub OpenApplyTool(ByVal strProjectCode As String, ByVal strCorpName As String, ByVal strWorkFlowId As String, ByVal strTaskId As String, ByVal frmOwner As Form, ByVal User As String) Implements IApplyTool.OpenApplyTool
        Try
            Me.strProjectCode = strProjectCode
            Me.strCorporatioName = strCorpName
            Me.strWorkFlowID = strWorkFlowId
            Me.strTaskID = strTaskId
            Me.strUser = User

            Me.AllowTransparency = False
            Me.Owner = frmOwner
            Me.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    Public Sub OpenApplyTool(ByVal strProjectCode As String, ByVal strCorpName As String, ByVal strWorkFlowID As String, ByVal strTaskID As String, ByVal frmOwner As Form, ByVal User As String, ByVal taskName As String, ByVal roleID As String) Implements IApplyTool.OpenApplyTool
        Try
            Me.strProjectCode = strProjectCode
            Me.strCorporatioName = strCorpName
            Me.strWorkFlowID = strWorkFlowID
            Me.strTaskID = strTaskID
            Me.strUser = User
            Me.strRoleID = roleID

            Me.AllowTransparency = False
            Me.Owner = frmOwner
            Me.StartPosition = FormStartPosition.CenterScreen 'qxd add 2004-3-8
            If Not taskName.Trim = "" Then
                Me.Text = taskName
            End If
            Me.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '获得项目编码project_code
    '
    Public Function getProjectCode() As String
        Return Me.strProjectCode
    End Function
    '
    '获得企业名称
    '
    Public Function getCorporationName() As String
        Return Me.strCorporatioName
    End Function
    '
    '获得工作流ID
    '
    Public Function getWorkFlowID() As String
        Return Me.strWorkFlowID
    End Function
    '
    '获得任务ID
    '
    Public Function getTaskID() As String
        Return Me.strTaskID
    End Function
    '
    '获得用户名
    '
    Public Function getUser() As String
        Return Me.strUser
    End Function

    '获得用户名
    '
    Public Function getRoleID() As String
        Return Me.strRoleID
    End Function
    '
    '获取项目阶段phase
    '
    Public Function getPhase(ByVal strCode As String) As String

        Dim ds As DataSet
        Dim i As Integer
        Try
            ds = gWs.GetProjectInfo("{project_code='" & strCode & "'}")
            i = ds.Tables("project").Rows.Count
            If i > 0 Then
                If Not ds.Tables("project").Rows(0).Item("phase") Is System.DBNull.Value Then
                    Return ds.Tables("project").Rows(0).Item("phase")
                Else
                    Return ""
                End If
            Else
                Return ""
            End If
        Catch ex As Exception
            'MsgBox("获取项目阶段出错!", MsgBoxStyle.Critical, "提示")
            SWDialogBox.MessageBox.Show("$Login106")
        End Try
    End Function
    '
    '设置回车键事件为TAB键
    '
    Public Sub setEnterKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(13) Then
            CType(sender, Form).SelectNextControl(Me.ActiveControl, True, False, True, True)
        End If
    End Sub

End Class
