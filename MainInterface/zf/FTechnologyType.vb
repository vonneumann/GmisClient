Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FTechnologyType
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
	Friend tsTechnologyType As System.Windows.Forms.DataGridTableStyle

	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Me.tsTechnologyType = New System.Windows.Forms.DataGridTableStyle()
		Me.csNo = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
		Me.SuspendLayout()
		'
		'tsTechnologyType
		'
		Me.tsTechnologyType.DataGrid = Me.grdTable
		Me.tsTechnologyType.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csNo, Me.csName})
		Me.tsTechnologyType.HeaderForeColor = System.Drawing.SystemColors.ControlText
		Me.tsTechnologyType.MappingName = "TTechnologyType"
		'
		'csNo
		'
		Me.csNo.Format = ""
		Me.csNo.FormatInfo = Nothing
		Me.csNo.HeaderText = "编  号"
		Me.csNo.MappingName = "technology_type_code"
        Me.csNo.Width = 75
        Me.csNo.NullText = String.Empty
        Me.csNo.ReadOnly = True
		'
		'csName
		'
		Me.csName.Format = ""
		Me.csName.FormatInfo = Nothing
		Me.csName.HeaderText = "科技类型"
		Me.csName.MappingName = "technology_type"
        Me.csName.Width = 210
        Me.csName.NullText = String.Empty
		'
		'FTechnologyType
		'
		Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
		Me.ClientSize = New System.Drawing.Size(512, 333)
		Me.Name = "FTechnologyType"
		Me.Text = "科技类型设置"
		Me.ResumeLayout(False)

	End Sub

#End Region

	Public Overloads Overrides Sub Refresh()
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim dsResult As DataSet

			dsResult = gWs.GetTechnologyType("%")
			grdTable.SetDataBinding(dsResult, "TTechnologyType")
		Catch ex As System.Exception
			'统一错误处理
			ExceptionHandler.ShowMessageBox(ex)
		Finally
			Me.Cursor = Cursors.Default
		End Try
    End Sub

    Private Function ValidateMaster(ByVal data As DataTable) As Boolean
        If data.Select("technology_type IS NULL OR technology_type=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "科技类型")
            Return False
        End If

        Dim i, j As Int32
        Dim rows() As DataRow = data.Select("", "", DataViewRowState.CurrentRows)

        For i = 0 To rows.Length - 2
            For j = i + 1 To rows.Length - 1
                If rows(i)("technology_type") = rows(j)("technology_type") Then
                    SWDialogBox.MessageBox.Show("$1003", "科技类型")
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

            Dim i, length As Int32
            Dim rows() As DataRow = dsCommit.Tables(0).Select("", "", DataViewRowState.CurrentRows)
            length = rows.Length
            For i = 0 To length - 1
                rows(i)("technology_type_code") = Convert.ToInt32(Math.Pow(2, i))
            Next

            Dim result As String = gWs.UpdateTechnologyType(dsCommit.GetChanges())

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

    Private Sub FTechnologyType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.csName.TextBox.MaxLength = 20
        grdTable.TableStyles.Add(Me.tsTechnologyType)
    End Sub
End Class
