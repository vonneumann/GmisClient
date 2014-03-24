Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FBranch
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
	Friend tsBranch As System.Windows.Forms.DataGridTableStyle
	Friend csBranchNo As System.Windows.Forms.DataGridTextBoxColumn
	Friend csBranchName As System.Windows.Forms.DataGridTextBoxColumn
	Friend csAddress As System.Windows.Forms.DataGridTextBoxColumn
	Friend csSuperior As DataGridComboBoxColumn
	Friend csIsLand As System.Windows.Forms.DataGridBoolColumn
	Friend csCreatePerson As System.Windows.Forms.DataGridTextBoxColumn
	Friend csCreateDate As System.Windows.Forms.DataGridTextBoxColumn

	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.tsBranch = New System.Windows.Forms.DataGridTableStyle()
		Me.csBranchNo = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csBranchName = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csAddress = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csSuperior = New DataGridComboBoxColumn()
		Me.csIsLand = New System.Windows.Forms.DataGridBoolColumn()
		Me.csCreatePerson = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csCreateDate = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.SuspendLayout()
		'
		'tsBranch
		'
		Me.tsBranch.DataGrid = Me.grdTable
		Me.tsBranch.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csBranchNo, Me.csBranchName, Me.csAddress, Me.csSuperior, Me.csIsLand, Me.csCreatePerson, Me.csCreateDate})
		Me.tsBranch.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.tsBranch.MappingName = "TBranch"
		'
		'csBranchNo
		'
		Me.csBranchNo.Format = ""
		Me.csBranchNo.FormatInfo = Nothing
		Me.csBranchNo.HeaderText = "编  号"
		Me.csBranchNo.MappingName = "branch_id"
		Me.csBranchNo.Width = 75
		'
		'csBranchName
		'
		Me.csBranchName.Format = ""
		Me.csBranchName.FormatInfo = Nothing
		Me.csBranchName.HeaderText = "部门名称"
		Me.csBranchName.MappingName = "branch_name"
		Me.csBranchName.Width = 120
		'
		'csAddress
		'
		Me.csAddress.Format = ""
		Me.csAddress.FormatInfo = Nothing
		Me.csAddress.HeaderText = "地    址"
		Me.csAddress.MappingName = "address"
		Me.csAddress.Width = 150
		'
		'csSuperior
		'
		Me.csSuperior.Format = ""
		Me.csSuperior.FormatInfo = Nothing
		Me.csSuperior.HeaderText = "上级部门"
		Me.csSuperior.MappingName = "superior_branch"
		Me.csSuperior.Width = 80
		'
		'csIsLand
		'
		Me.csIsLand.HeaderText = "独立机构"
		Me.csIsLand.MappingName = "is_island"
		Me.csIsLand.Width = 60
		'
		'csCreatePerson
		'
		Me.csCreatePerson.Format = ""
		Me.csCreatePerson.FormatInfo = Nothing
		Me.csCreatePerson.HeaderText = "创建人"
		Me.csCreatePerson.MappingName = "create_person"
		Me.csCreatePerson.ReadOnly = True
		Me.csCreatePerson.Width = 80
		'
		'csCreateDate
		'
		Me.csCreateDate.Format = "D"
		Me.csCreateDate.FormatInfo = Nothing
		Me.csCreateDate.HeaderText = "创建日期"
		Me.csCreateDate.MappingName = "create_date"
		Me.csCreateDate.ReadOnly = True
		Me.csCreateDate.Width = 100
		'
		'FBranch
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.ClientSize = New System.Drawing.Size(512, 333)
		Me.Name = "FBranch"
		Me.Text = "部门设置"
		Me.ResumeLayout(False)

	End Sub

#End Region

	Public Overloads Overrides Sub Refresh()
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim dsResult As DataSet

			dsResult = gWs.GetBranch("%")

			AddHandler dsResult.Tables("TBranch").RowChanged, AddressOf Table_Changed

			grdTable.SetDataBinding(dsResult, "TBranch")
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

            If Not dsCommit.HasChanges() Then
                Return False
            End If

            Dim result As String = gWs.UpdateBranch(dsCommit.GetChanges())

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

	Private Sub FBranch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Dim dsResult As DataSet = gWs.GetBranch("%")

		csSuperior.ColumnComboBox.DataSource = dsResult.Tables("TBranch").DefaultView
		csSuperior.ColumnComboBox.DisplayMember = "branch_name"
		csSuperior.ColumnComboBox.ValueMember = "branch_name"

		grdTable.TableStyles.Add(Me.tsBranch)
	End Sub

	Private Sub Table_Changed(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
		If e.Action = DataRowAction.Add Then
			Dim rv As DataRowView = CType(Me.BindingContext(grdTable.DataSource, grdTable.DataMember).Current, DataRowView)

			rv("create_person") = UserName
			rv("create_date") = DateTime.Today
		End If
	End Sub
End Class
