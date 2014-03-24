Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FGuaranteeLetterType
    Inherits FBaseData

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
        Me.csTypeNo.TextBox.MaxLength = 25
        Me.csName.TextBox.MaxLength = 50
        Me.csRemark.TextBox.MaxLength = 255
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
    Friend WithEvents tsGuaranteeLetterType As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csTypeNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csRemark As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.tsGuaranteeLetterType = New System.Windows.Forms.DataGridTableStyle()
        Me.csTypeNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csRemark = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsGuaranteeLetterType})
        Me.grdTable.Visible = True
        '
        'tsGuaranteeLetterType
        '
        Me.tsGuaranteeLetterType.DataGrid = Me.grdTable
        Me.tsGuaranteeLetterType.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csTypeNo, Me.csName, Me.csRemark})
        Me.tsGuaranteeLetterType.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsGuaranteeLetterType.MappingName = "TGuaranteeLetterType"
        '
        'csTypeNo
        '
        Me.csTypeNo.Format = ""
        Me.csTypeNo.FormatInfo = Nothing
        Me.csTypeNo.HeaderText = "编  号"
        Me.csTypeNo.MappingName = "type_code"
        Me.csTypeNo.Width = 60
        Me.csTypeNo.NullText = String.Empty
        '
        'csName
        '
        Me.csName.Format = ""
        Me.csName.FormatInfo = Nothing
        Me.csName.HeaderText = "类型名称"
        Me.csName.MappingName = "name"
        Me.csName.Width = 150
        Me.csName.NullText = String.Empty
        '
        'csRemark
        '
        Me.csRemark.Format = ""
        Me.csRemark.FormatInfo = Nothing
        Me.csRemark.HeaderText = "备  注"
        Me.csRemark.MappingName = "remark"
        Me.csRemark.Width = 150
        Me.csRemark.NullText = String.Empty
        '
        'FGuaranteeLetterType
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.grdTable})
        Me.Name = "FGuaranteeLetterType"
        Me.Text = "保函种类"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overloads Overrides Sub Refresh()
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dsResult As DataSet

            dsResult = gWs.GetGuaranteeLetterType("%")
            grdTable.SetDataBinding(dsResult, "TGuaranteeLetterType")
        Catch ex As System.Exception
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
        If data.Select("name IS NULL OR name=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "类型名称")
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

            If dsCommit Is Nothing OrElse (Not dsCommit.HasChanges()) Then
                Return False
            End If

            If Not ValidateMaster(dsCommit.Tables(0)) Then
                Return False
            End If

            Dim result As String = gWs.UpdateGuaranteeLetterType(dsCommit.GetChanges())

            If result = "1" Then
                '接受所有更改
                dsCommit.AcceptChanges()

                Return True
            Else
                MessageBox.Show("系统返回信息：" + result, "数据引擎", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As System.Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

        Return False
    End Function
End Class
