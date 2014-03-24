Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FCorporatioRelationType
	Inherits FBaseData

#Region " Windows 窗体设计器生成的代码 "

	Public Sub New()
		MyBase.New()

		'该调用是 Windows 窗体设计器所必需的。
		InitializeComponent()
        Me.csNo.TextBox.MaxLength = 1
        Me.csName.TextBox.MaxLength = 20
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
	Friend tsCorporatioRelationType As System.Windows.Forms.DataGridTableStyle
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.tsCorporatioRelationType = New System.Windows.Forms.DataGridTableStyle()
		Me.csNo = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.SuspendLayout()
		'
		'tsCorporatioRelationType
		'
		Me.tsCorporatioRelationType.DataGrid = Me.grdTable
		Me.tsCorporatioRelationType.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csNo, Me.csName})
		Me.tsCorporatioRelationType.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.tsCorporatioRelationType.MappingName = "TCorporatioRelationType"
		'
		'csNo
		'
		Me.csNo.Format = ""
		Me.csNo.FormatInfo = Nothing
		Me.csNo.HeaderText = "编  号"
		Me.csNo.MappingName = "type_code"
        Me.csNo.Width = 60
        Me.csNo.NullText = String.Empty
		'
		'csName
		'
		Me.csName.Format = ""
		Me.csName.FormatInfo = Nothing
		Me.csName.HeaderText = "企业关系"
		Me.csName.MappingName = "corporation_relation_type"
        Me.csName.Width = 210
        Me.csName.NullText = String.Empty
		'
		'FCorporatioRelationType
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.ClientSize = New System.Drawing.Size(512, 333)
		Me.Name = "FCorporatioRelationType"
		Me.Text = "企业关系类型"
		Me.ResumeLayout(False)

	End Sub

#End Region

	Public Overloads Overrides Sub Refresh()
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim dsResult As DataSet

			dsResult = gWs.GetCorporatioRelationType("%")
			grdTable.SetDataBinding(dsResult, "TCorporatioRelationType")
		Catch ex As System.Exception
			'统一错误处理
			ExceptionHandler.ShowMessageBox(ex)
		Finally
			Me.Cursor = Cursors.Default
		End Try
    End Sub

    Private Function ValidateMaster(ByVal data As DataTable) As Boolean
        If data.Select("type_code IS NULL OR type_code=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "编号")
            Return False
        End If
        If data.Select("corporation_relation_type IS NULL OR corporation_relation_type=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "企业关系")
            Return False
        End If
        Dim i, j, count As Int32
        Dim rows() As DataRow = data.Select("", "", DataViewRowState.CurrentRows)
        count = rows.Length
        For i = 0 To count - 1
            For j = i + 1 To count - 1
                If rows(i)("type_code") = rows(j)("type_code") Then
                    SWDialogBox.MessageBox.Show("$1003", "编号")
                    Return False
                End If
            Next
        Next
        Return True
    End Function


    Public Overrides Function Update() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dsCommit As DataSet = CType(grdTable.DataSource, DataSet)
            If (Not dsCommit.HasChanges()) OrElse (Not ValidateMaster(dsCommit.Tables(0))) Then
                Return False
            End If

            Dim result As String = gWs.UpdateCorporatioRelationType(dsCommit.GetChanges())

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

    Private Sub FDistrict_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grdTable.TableStyles.Add(Me.tsCorporatioRelationType)
    End Sub
End Class
