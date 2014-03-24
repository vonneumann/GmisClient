Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FTerminateType
	Inherits FBaseData

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
        Me.csName.TextBox.MaxLength = 10
        Me.csNo.TextBox.MaxLength = 2
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
	Friend tsTerminateType As System.Windows.Forms.DataGridTableStyle

	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.tsTerminateType = New System.Windows.Forms.DataGridTableStyle()
		Me.csNo = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.SuspendLayout()
		'
		'tsTerminateType
		'
		Me.tsTerminateType.DataGrid = Me.grdTable
		Me.tsTerminateType.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csNo, Me.csName})
		Me.tsTerminateType.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.tsTerminateType.MappingName = "TTerminateType"
		'
		'csNo
		'
		Me.csNo.Format = ""
		Me.csNo.FormatInfo = Nothing
		Me.csNo.HeaderText = "编  号"
		Me.csNo.MappingName = "terminate_type_code"
		Me.csNo.Width = 75
		'
		'csName
		'
		Me.csName.Format = ""
		Me.csName.FormatInfo = Nothing
		Me.csName.HeaderText = "终止类型"
		Me.csName.MappingName = "terminate_type"
		Me.csName.Width = 210
		'
		'FTerminateType
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.ClientSize = New System.Drawing.Size(512, 333)
		Me.Name = "FTerminateType"
		Me.Text = "终止类型设置"
		Me.ResumeLayout(False)

	End Sub

#End Region

	Public Overloads Overrides Sub Refresh()
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim dsResult As DataSet

			dsResult = gWs.GetTerminateType("%")
			grdTable.SetDataBinding(dsResult, "TTerminateType")
		Catch ex As System.Exception
			'统一错误处理
			ExceptionHandler.ShowMessageBox(ex)
		Finally
			Me.Cursor = Cursors.Default
		End Try
    End Sub

    Private Function ValidateMaster(ByVal data As DataTable) As Boolean
        If data.Select("terminate_type IS NULL OR terminate_type=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "终止类型")
            Return False
        End If
        If data.Select("terminate_type_code IS NULL OR terminate_type_code=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "编号")
            Return False
        End If

        Dim i, j As Int32
        Dim rows() As DataRow = data.Select("", "", DataViewRowState.CurrentRows)

        For i = 0 To rows.Length - 2
            For j = i + 1 To rows.Length - 1
                If rows(i)("terminate_type") = rows(j)("terminate_type") Then
                    SWDialogBox.MessageBox.Show("$1003", "终止类型")
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

            If dsCommit Is Nothing OrElse (Not dsCommit.HasChanges()) Then
                Return False
            End If

            If Not ValidateMaster(dsCommit.Tables(0)) Then
                Return False
            End If

            Dim result As String = gWs.UpdateTerminateType(dsCommit.GetChanges())

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

    Private Sub FTerminateType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grdTable.TableStyles.Add(Me.tsTerminateType)
    End Sub
End Class
