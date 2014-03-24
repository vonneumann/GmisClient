Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FServiceType
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
	Friend tsServiceType As System.Windows.Forms.DataGridTableStyle

	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.tsServiceType = New System.Windows.Forms.DataGridTableStyle()
		Me.csNo = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.SuspendLayout()
		'
		'tsServiceType
		'
		Me.tsServiceType.DataGrid = Me.grdTable
		Me.tsServiceType.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csNo, Me.csName})
		Me.tsServiceType.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.tsServiceType.MappingName = "TServiceType"
		'
		'csNo
		'
		Me.csNo.Format = ""
		Me.csNo.FormatInfo = Nothing
		Me.csNo.HeaderText = "编  号"
		Me.csNo.MappingName = "service_type_code"
		Me.csNo.Width = 75
		'
		'csName
		'
		Me.csName.Format = ""
		Me.csName.FormatInfo = Nothing
		Me.csName.HeaderText = "业务品种"
		Me.csName.MappingName = "service_type"
		Me.csName.Width = 210
		'
		'FServiceType
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.ClientSize = New System.Drawing.Size(512, 333)
		Me.Name = "FServiceType"
		Me.Text = "业务品种设置"
		Me.ResumeLayout(False)

	End Sub

#End Region

	Public Overloads Overrides Sub Refresh()
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim dsResult As DataSet

			dsResult = gWs.GetServiceType("%")
			grdTable.SetDataBinding(dsResult, "TServiceType")
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
			Dim result As String = gWs.UpdateServiceType(dsCommit.GetChanges())

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

	Private Sub FServiceType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		grdTable.TableStyles.Add(Me.tsServiceType)
	End Sub
End Class
