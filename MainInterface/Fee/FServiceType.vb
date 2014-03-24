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
    Friend csStatus As DataGridBoolColumn
    Friend csReviewFeeRate As DataGridTextBoxColumn
    Friend csLowestReviewSum As DataGridTextBoxColumn
    Friend csGuaranteeFeeRate As DataGridTextBoxColumn
    Friend csSecurityRate As DataGridTextBoxColumn

	Friend tsServiceType As System.Windows.Forms.DataGridTableStyle

	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tsServiceType = New System.Windows.Forms.DataGridTableStyle()
        Me.csNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csStatus = New DataGridBoolColumn()
        Me.csReviewFeeRate = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csLowestReviewSum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csGuaranteeFeeRate = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSecurityRate = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(128, 302)
        Me.btnRefresh.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(392, 302)
        Me.btnExit.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Size = New System.Drawing.Size(576, 288)
        Me.grdTable.Visible = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(304, 302)
        Me.btnUpdate.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(216, 302)
        Me.btnDelete.Visible = True
        '
        'tsServiceType
        '
        Me.tsServiceType.DataGrid = Me.grdTable
        Me.tsServiceType.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csNo, Me.csName, Me.csStatus, Me.csReviewFeeRate, Me.csLowestReviewSum, Me.csGuaranteeFeeRate, Me.csSecurityRate})
        Me.tsServiceType.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsServiceType.MappingName = "TServiceType"
        '
        'csNo
        '
        Me.csNo.Format = ""
        Me.csNo.FormatInfo = Nothing
        Me.csNo.HeaderText = "编 号"
        Me.csNo.MappingName = "service_type_code"
        Me.csNo.Width = 50
        Me.csNo.NullText = String.Empty
        AddHandler csNo.TextBox.Enter, AddressOf txtNo_GetFocus
        AddHandler csNo.TextBox.KeyPress, AddressOf txtNo_KeyPress
        '
        'csName
        '
        Me.csName.Format = ""
        Me.csName.FormatInfo = Nothing
        Me.csName.HeaderText = "业务品种"
        Me.csName.MappingName = "service_type"
        Me.csName.NullText = String.Empty
        Me.csName.Width = 130
        '
        'csStatus
        '
        Me.csStatus.MappingName = "status"
        Me.csStatus.HeaderText = "是否采用"
        Me.csStatus.Width = 55
        Me.csStatus.AllowNull = False
        Me.csStatus.TrueValue = True
        Me.csStatus.FalseValue = False
        '
        'csReviewFeeRate
        '
        Me.csReviewFeeRate.Format = ""
        Me.csReviewFeeRate.FormatInfo = Nothing
        Me.csReviewFeeRate.HeaderText = "评审费率(%)"
        Me.csReviewFeeRate.MappingName = "review_fee_rate"
        Me.csReviewFeeRate.NullText = ""
        Me.csReviewFeeRate.Width = 75
        '
        'csLowestReviewSum
        '
        Me.csLowestReviewSum.Format = ""
        Me.csLowestReviewSum.FormatInfo = Nothing
        Me.csLowestReviewSum.HeaderText = "最低评审费(元)"
        Me.csLowestReviewSum.MappingName = "lowest_review_sum"
        Me.csLowestReviewSum.NullText = ""
        Me.csLowestReviewSum.Width = 95
        '
        'csGuaranteeFeeRate
        '
        Me.csGuaranteeFeeRate.Format = ""
        Me.csGuaranteeFeeRate.FormatInfo = Nothing
        Me.csGuaranteeFeeRate.HeaderText = "担保费率(%/年)"
        Me.csGuaranteeFeeRate.MappingName = "guarantee_fee_rate"
        Me.csGuaranteeFeeRate.NullText = ""
        Me.csGuaranteeFeeRate.Width = 95
        '
        'csSecurityRate
        '
        Me.csSecurityRate.Format = ""
        Me.csSecurityRate.FormatInfo = Nothing
        Me.csSecurityRate.HeaderText = "保证金比率(%)"
        Me.csSecurityRate.MappingName = "security_rate"
        Me.csSecurityRate.NullText = ""
        Me.csSecurityRate.Width = 90
        '
        'FServiceType
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(592, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdTable})
        Me.Name = "FServiceType"
        Me.Text = "业务品种设置"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private MaxServiceTypeCode As Integer

	Public Overloads Overrides Sub Refresh()
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim dsResult As DataSet

			dsResult = gWs.GetServiceType("%")
            grdTable.SetDataBinding(dsResult, "TServiceType")
            Dim drs() As DataRow = dsResult.Tables(0).Select("", "service_type_code DESC")
            If drs.Length > 0 Then
                MaxServiceTypeCode = CInt(drs(0)("service_type_code"))
            Else
                MaxServiceTypeCode = 0
            End If
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
            If dsCommit.HasChanges Then
                Dim dr As DataRow
                Dim drs() As DataRow = dsCommit.Tables(0).Select("", "", DataViewRowState.Added)
                For Each dr In drs
                    If IsDBNull(dr("service_type_code")) Then
                        MaxServiceTypeCode += 1
                        dr("service_type_code") = IIf(MaxServiceTypeCode < 10, "0", "") & MaxServiceTypeCode.ToString()
                    End If
                    If IsDBNull(dr("status")) Then
                        dr("status") = True
                    End If
                Next
            End If
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

    Private Sub txtNo_GetFocus(ByVal sender As Object, ByVal e As EventArgs)
        CType(sender, TextBox).Tag = Not (CType(sender, TextBox).Text = String.Empty)
    End Sub

    Private Sub txtNo_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        e.Handled = CBool(CType(sender, TextBox).Tag) OrElse (CType(sender, TextBox).Text.Length = 2)
    End Sub


    Private Sub DG_CurrentCellChanged(ByVal sender As Object, ByVal e As EventArgs) Handles grdTable.CurrentCellChanged
        If grdTable.TableStyles(0).GridColumnStyles(grdTable.CurrentCell.ColumnNumber).GetType Is GetType(DataGridBoolColumn) Then
            If grdTable.Item(grdTable.CurrentCell) Is DBNull.Value Then
                grdTable.Item(grdTable.CurrentCell) = True
            Else
                grdTable.Item(grdTable.CurrentCell) = Not CBool(grdTable.Item(grdTable.CurrentCell))
            End If
        End If
    End Sub



End Class
