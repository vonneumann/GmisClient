'工作流定义基类，为子类提供
'共用的删除、保存、刷新、关闭保存功能
Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmBaseWfDefine
    Inherits System.Windows.Forms.Form

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
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Public WithEvents btnUpdate As System.Windows.Forms.Button
    Public WithEvents grdTable As System.Windows.Forms.DataGrid
    Public WithEvents btnRefresh As System.Windows.Forms.Button
    Protected WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmBaseWfDefine))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.grdTable = New System.Windows.Forms.DataGrid()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 3
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(348, 302)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 1
        Me.btnDelete.ImageList = Me.ImageList1
        Me.btnDelete.Location = New System.Drawing.Point(172, 302)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 7
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRefresh.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btnRefresh.ImageIndex = 0
        Me.btnRefresh.ImageList = Me.ImageList1
        Me.btnRefresh.Location = New System.Drawing.Point(84, 302)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(77, 23)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "刷 新(&R)"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.ImageIndex = 2
        Me.btnUpdate.ImageList = Me.ImageList1
        Me.btnUpdate.Location = New System.Drawing.Point(260, 302)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(77, 23)
        Me.btnUpdate.TabIndex = 8
        Me.btnUpdate.Text = "保 存(&S)"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdTable
        '
        Me.grdTable.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grdTable.CaptionVisible = False
        Me.grdTable.DataMember = ""
        Me.grdTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTable.Location = New System.Drawing.Point(8, 6)
        Me.grdTable.Name = "grdTable"
        Me.grdTable.Size = New System.Drawing.Size(496, 288)
        Me.grdTable.TabIndex = 5
        '
        'frmBaseWfDefine
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdTable})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "frmBaseWfDefine"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    '供刷新列表用，基类不作任何处理，子类可重写该方法提供子类的刷新实现
    Public Overridable Overloads Sub Refresh()
        Return
    End Sub

    '供保存提交用，基类不作任何处理，子类可重写该方法提供子类的保存提交实现
    Public Overridable Shadows Function Update() As Boolean
        Return True
    End Function

    '基类的退出按钮事件
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    '基类的删除按钮事件，可供子类重写以实现子类的删除实现
    Friend Overridable Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If Not grdTable.DataSource Is Nothing Then
                If Me.BindingContext(grdTable.DataSource, grdTable.DataMember).Position >= 0 Then
                    '获取列表中的当前行
                    Dim rv As DataRowView = CType(Me.BindingContext(grdTable.DataSource, grdTable.DataMember).Current, DataRowView)
                    '删除当前行
                    rv.Delete()
                End If
            End If
        Catch ex As System.Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '基类的刷新按钮事件，调Refresh方法
    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Me.Refresh()
        Catch ex As System.Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    '基类的保存按钮事件，调用Update方法
    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Me.Update()
        Catch ex As System.Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmBaseWfDefine_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Refresh()
        End If
    End Sub

    Private Sub frmBaseWfDefine_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Refresh()
    End Sub

    '基类的窗口关闭事件
    Private Sub frmBaseWfDefine_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If grdTable.DataSource Is Nothing Then
            Return
        Else

            '判断数据集是否被改动过，如果没有则返回
            If CType(grdTable.DataSource, DataSet).GetChanges() Is Nothing Then
                Return
            End If
        End If

        '否则，提示数据已改动，是否保存
        Dim result As DialogResult = MessageBox.Show("资料已经被改动过，您要保存吗？", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

        '调用Update方法提交数据集
        If result = DialogResult.Yes Then
            If Not Me.Update() Then
                e.Cancel = True
            End If
        Else
            If result = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub grdTable_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles grdTable.MouseUp

    End Sub
End Class
