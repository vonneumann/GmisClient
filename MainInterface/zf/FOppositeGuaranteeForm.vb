Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FOppositeGuaranteeForm
	Inherits FBaseData

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
        Me.csName.TextBox.MaxLength = 15
        Me.csNo.TextBox.MaxLength = 2
        Me.csFlag.TextBox.MaxLength = 1
        AddHandler csItem.ColumnComboBox.SelectedIndexChanged, AddressOf Item_SelectedIndexChanged
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
    Friend csFlag As System.Windows.Forms.DataGridTextBoxColumn
    Friend csItem As DataGridComboBoxColumn
    Friend tsOppositeGuaranteeForm As System.Windows.Forms.DataGridTableStyle

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tsOppositeGuaranteeForm = New System.Windows.Forms.DataGridTableStyle()
        Me.csNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csFlag = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csItem = New DataGridComboBoxColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Visible = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'tsOppositeGuaranteeForm
        '
        Me.tsOppositeGuaranteeForm.DataGrid = Me.grdTable
        Me.tsOppositeGuaranteeForm.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csNo, Me.csName, Me.csFlag, Me.csItem})
        Me.tsOppositeGuaranteeForm.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsOppositeGuaranteeForm.MappingName = "TOppositeGuaranteeForm"
        '
        'csNo
        '
        Me.csNo.Format = ""
        Me.csNo.FormatInfo = Nothing
        Me.csNo.HeaderText = "编  号"
        Me.csNo.MappingName = "form_code"
        Me.csNo.Width = 75
        '
        'csName
        '
        Me.csName.Format = ""
        Me.csName.FormatInfo = Nothing
        Me.csName.HeaderText = "反担保方式"
        Me.csName.MappingName = "name"
        Me.csName.Width = 210
        '
        'csFlag
        '
        Me.csFlag.Format = ""
        Me.csFlag.FormatInfo = Nothing
        Me.csFlag.HeaderText = "标  志"
        Me.csFlag.MappingName = "flag"
        Me.csFlag.Width = 60
        '
        'csItem
        '
        Me.csItem.HeaderText = "确认类型"
        Me.csItem.MappingName = "item_code"
        Me.csItem.Width = 300
        '
        'FOppositeGuaranteeForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdTable})
        Me.Name = "FOppositeGuaranteeForm"
        Me.Text = "反担保方式设置"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

	Public Overloads Overrides Sub Refresh()
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim dsResult As DataSet

			dsResult = gWs.GetOppositeGuaranteeForm("%")
			grdTable.SetDataBinding(dsResult, "TOppositeGuaranteeForm")
		Catch ex As System.Exception
			'统一错误处理
			ExceptionHandler.ShowMessageBox(ex)
		Finally
			Me.Cursor = Cursors.Default
		End Try
	End Sub

    Private Function ValidateMaster(ByVal data As DataTable) As Boolean
        If data.Select("name IS NULL OR name=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "反担保方式")
            Return False
        End If
        If data.Select("form_code IS NULL OR form_code=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "编号")
            Return False
        End If

        Dim i, j As Int32
        Dim rows() As DataRow = data.Select("", "", DataViewRowState.CurrentRows)

        For i = 0 To rows.Length - 2
            For j = i + 1 To rows.Length - 1
                If rows(i)("name") = rows(j)("name") Then
                    SWDialogBox.MessageBox.Show("$1003", "反担保方式")
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

            Dim result As String = gWs.UpdateOppositeGuaranteeForm(dsCommit.GetChanges())

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

    Private Sub FOppositeGuaranteeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsResult As DataSet = gWs.GetItem("%", "44")

        csItem.ColumnComboBox.DataSource = dsResult.Tables("TItem").DefaultView
        csItem.ColumnComboBox.DisplayMember = "item_name"
        csItem.ColumnComboBox.ValueMember = "item_code"

        grdTable.TableStyles.Add(Me.tsOppositeGuaranteeForm)
    End Sub

    Private Sub Item_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim bm As BindingManagerBase = Me.BindingContext(grdTable.DataSource, grdTable.DataMember)

        If bm.Position < 0 Then
            Return
        End If

        CType(bm.Current, DataRowView).Row.Item("item_type") = "44"
    End Sub
End Class
