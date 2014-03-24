Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FBaseData
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
    Public WithEvents grdTable As System.Windows.Forms.DataGrid
    Public WithEvents btnExit As System.Windows.Forms.Button
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Public WithEvents btnUpdate As System.Windows.Forms.Button
    Public WithEvents btnRefresh As System.Windows.Forms.Button
    Protected WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FBaseData))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.grdTable = New System.Windows.Forms.DataGrid()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
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
        Me.btnExit.Location = New System.Drawing.Point(348, 304)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 2
        Me.btnDelete.ImageList = Me.ImageList1
        Me.btnDelete.Location = New System.Drawing.Point(172, 304)
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
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.ImageIndex = 0
        Me.btnRefresh.ImageList = Me.ImageList1
        Me.btnRefresh.Location = New System.Drawing.Point(84, 304)
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
        Me.btnUpdate.ImageIndex = 1
        Me.btnUpdate.ImageList = Me.ImageList1
        Me.btnUpdate.Location = New System.Drawing.Point(260, 304)
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
        Me.grdTable.Size = New System.Drawing.Size(496, 290)
        Me.grdTable.TabIndex = 5
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'FBaseData
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdTable})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "FBaseData"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

	Public Overridable Overloads Sub Refresh()
		Return
	End Sub

	Public Overridable Shadows Function Update() As Boolean
		Return True
	End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Public Overridable Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            If Not grdTable.DataSource Is Nothing Then
                If Me.BindingContext(grdTable.DataSource, grdTable.DataMember).Position >= 0 Then
                    Dim rv As DataRowView = CType(Me.BindingContext(grdTable.DataSource, grdTable.DataMember).Current, DataRowView)

                    rv.Delete()
                End If
            End If
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            Me.Refresh()
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            If Me.Update() Then
                SWDialogBox.MessageBox.Show("$SaveSucceed")
            End If
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub FBaseData_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.F5 Then
            Me.Refresh()
        End If
    End Sub

    Private Sub FBaseData_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Refresh()
    End Sub

    Protected Overridable Function Confirm() As Boolean
        If grdTable.DataSource Is Nothing Then
            Return False
        End If

        If Not CType(grdTable.DataSource, DataSet).HasChanges() Then
            Return False
        End If

        '资料已经被改动过，您要保存吗？
        Dim result As DialogResult = SWDialogBox.MessageBox.Show("?1003")

        If result = DialogResult.Yes Then
            If Not Me.Update() Then
                Return True
            End If
        Else
            If result = DialogResult.Cancel Then
                Return True
            End If
        End If

        Return False
    End Function

    Private Sub FBaseData_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Me.Confirm()
    End Sub
End Class
