Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FIndustryType
	Inherits FBaseData

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
        Me.csName.TextBox.MaxLength = 20
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
    Friend csSystemID As DataGridComboBoxColumn
    Friend tsIndustryType As System.Windows.Forms.DataGridTableStyle

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FIndustryType))
        Me.tsIndustryType = New System.Windows.Forms.DataGridTableStyle()
        Me.csNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSystemID = New MainInterface.DataGridComboBoxColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnUpdate
        '
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsIndustryType})
        Me.grdTable.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'tsIndustryType
        '
        Me.tsIndustryType.DataGrid = Me.grdTable
        Me.tsIndustryType.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csNo, Me.csName, Me.csSystemID})
        Me.tsIndustryType.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsIndustryType.MappingName = "TIndustryType"
        '
        'csNo
        '
        Me.csNo.Format = ""
        Me.csNo.FormatInfo = Nothing
        Me.csNo.HeaderText = "编  号"
        Me.csNo.MappingName = "industry_type_code"
        Me.csNo.NullText = ""
        Me.csNo.Width = 75
        '
        'csName
        '
        Me.csName.Format = ""
        Me.csName.FormatInfo = Nothing
        Me.csName.HeaderText = "行业类型"
        Me.csName.MappingName = "industry_type"
        Me.csName.NullText = ""
        Me.csName.Width = 210
        '
        'csSystemID
        '
        Me.csSystemID.Format = ""
        Me.csSystemID.FormatInfo = Nothing
        Me.csSystemID.HeaderText = "体系编号"
        Me.csSystemID.MappingName = "credit_appraise_system"
        Me.csSystemID.NullText = ""
        '
        'FIndustryType
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdTable})
        Me.Name = "FIndustryType"
        Me.Text = "行业类型设置"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

	Public Overloads Overrides Sub Refresh()
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim dsResult As DataSet

			dsResult = gWs.GetIndustryType("%")
			grdTable.SetDataBinding(dsResult, "TIndustryType")
		Catch ex As System.Exception
			'统一错误处理
			ExceptionHandler.ShowMessageBox(ex)
		Finally
			Me.Cursor = Cursors.Default
		End Try
    End Sub

    Private Function ValidateMaster(ByVal data As DataTable) As Boolean
        If data.Select("industry_type_code IS NULL OR industry_type_code=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "编号")
            Return False
        End If
        If data.Select("credit_appraise_system IS NULL", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "体系编号")
            Return False
        End If
        If data.Select("industry_type IS NULL OR industry_type=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "行业类型")
            Return False
        End If
        Dim i, j, count As Int32
        Dim rows() As DataRow = data.Select("", "", DataViewRowState.CurrentRows)
        count = rows.Length
        For i = 0 To count - 1
            For j = i + 1 To count - 1
                If rows(i)("industry_type") = rows(j)("industry_type") Then
                    SWDialogBox.MessageBox.Show("$1003", "行业类型")
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
            Dim result As String = gWs.UpdateIndustryType(dsCommit.GetChanges())

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

    Private Sub FIndustryType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsCreditSystem As DataSet = gWs.FetchCreditAppraiseSystem("%")

        csSystemID.ColumnComboBox.DataSource = dsCreditSystem.Tables("TCreditAppraiseSystem").DefaultView
        csSystemID.ColumnComboBox.DisplayMember = "system_id"
        csSystemID.ColumnComboBox.ValueMember = "system_id"

        'grdTable.TableStyles.Add(Me.tsIndustryType)1
    End Sub
End Class
