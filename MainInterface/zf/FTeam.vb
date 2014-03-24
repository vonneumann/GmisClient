Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FTeam
    Inherits FBaseData

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
	Friend csNo As System.Windows.Forms.DataGridTextBoxColumn
	Friend csName As System.Windows.Forms.DataGridTextBoxColumn
	Friend csBranch As DataGridComboBoxColumn
	Friend tsTeam As System.Windows.Forms.DataGridTableStyle

	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.tsTeam = New System.Windows.Forms.DataGridTableStyle()
		Me.csNo = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csBranch = New DataGridComboBoxColumn()
		Me.SuspendLayout()
		'
		'tsTeam
		'
		Me.tsTeam.DataGrid = Me.grdTable
		Me.tsTeam.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csNo, Me.csName, Me.csBranch})
		Me.tsTeam.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.tsTeam.MappingName = "TTeam"
		'
		'csNo
		'
		Me.csNo.Format = ""
		Me.csNo.FormatInfo = Nothing
		Me.csNo.HeaderText = "编  号"
		Me.csNo.MappingName = "team_code"
		Me.csNo.Width = 75
		'
		'csName
		'
		Me.csName.Format = ""
		Me.csName.FormatInfo = Nothing
		Me.csName.HeaderText = "项目组名称"
		Me.csName.MappingName = "team_name"
		Me.csName.Width = 210
		'
		'csBranch
		'
		Me.csBranch.HeaderText = "所属部门"
		Me.csBranch.MappingName = "branch_name"
		Me.csBranch.Width = 100

		'
		'FTeam
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.ClientSize = New System.Drawing.Size(512, 333)
		Me.Name = "FTeam"
		Me.Text = "项目组设置"
		Me.ResumeLayout(False)

	End Sub

#End Region

	Public Overloads Overrides Sub Refresh()
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim dsResult As DataSet

			dsResult = gWs.GetTeam("%")
			grdTable.SetDataBinding(dsResult, "TTeam")
		Catch ex As System.Exception
			'统一错误处理
			ExceptionHandler.ShowMessageBox(ex)
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

	Public Overrides Function Update() As Boolean
		Try
			Me.Cursor = Cursors.WaitCursor

            Dim dsCommit As DataSet = CType(grdTable.DataSource, DataSet)

            If dsCommit Is Nothing OrElse (Not dsCommit.HasChanges()) Then
                Return False
            End If

            Dim result As String = gWs.UpdateTeam(dsCommit.GetChanges())

            If result = "1" Then
                '接受所有更改
                dsCommit.AcceptChanges()

                Return True
            Else
                '显示服务器的返回错误信息
                SWDialogBox.MessageBox.Show("*999", Me.Name + ".Update", result, "")
            End If
        Catch ex As System.Exception
			'统一错误处理
			ExceptionHandler.ShowMessageBox(ex)
		Finally
			Me.Cursor = Cursors.Default
		End Try

		Return False
	End Function

	Private Sub FTeam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Dim dsResult As DataSet = gWs.GetBranch("{is_island = 1}")

		csBranch.ColumnComboBox.DataSource = dsResult.Tables("TBranch").DefaultView
		csBranch.ColumnComboBox.DisplayMember = "branch_name"
		csBranch.ColumnComboBox.ValueMember = "branch_name"

		grdTable.TableStyles.Add(Me.tsTeam)
	End Sub
End Class
