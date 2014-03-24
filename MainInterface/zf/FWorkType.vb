Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FWorkType
    Inherits FBaseData

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
        Me.csNo.TextBox.MaxLength = 2
        Me.csName.TextBox.MaxLength = 30
        Me.csSubTypeCode.TextBox.MaxLength = 2
        Me.csSubTypeName.TextBox.MaxLength = 50
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
	Friend tsWorkType As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents grdSubType As System.Windows.Forms.DataGrid
    Friend WithEvents splHorizontal As System.Windows.Forms.Splitter
    Friend WithEvents panTable As System.Windows.Forms.Panel
    Friend WithEvents tsSubType As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csTypeCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csSubTypeCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csSubTypeName As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FWorkType))
        Me.tsWorkType = New System.Windows.Forms.DataGridTableStyle()
        Me.csNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.panTable = New System.Windows.Forms.Panel()
        Me.grdSubType = New System.Windows.Forms.DataGrid()
        Me.tsSubType = New System.Windows.Forms.DataGridTableStyle()
        Me.csTypeCode = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSubTypeCode = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csSubTypeName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.splHorizontal = New System.Windows.Forms.Splitter()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panTable.SuspendLayout()
        CType(Me.grdSubType, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grdTable.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)
        Me.grdTable.Dock = System.Windows.Forms.DockStyle.Top
        Me.grdTable.Location = New System.Drawing.Point(0, 0)
        Me.grdTable.Size = New System.Drawing.Size(496, 168)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsWorkType})
        Me.grdTable.Visible = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'tsWorkType
        '
        Me.tsWorkType.DataGrid = Me.grdTable
        Me.tsWorkType.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csNo, Me.csName})
        Me.tsWorkType.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsWorkType.MappingName = "TWorkType"
        '
        'csNo
        '
        Me.csNo.Format = ""
        Me.csNo.FormatInfo = Nothing
        Me.csNo.HeaderText = "编  号"
        Me.csNo.MappingName = "work_type"
        Me.csNo.NullText = ""
        Me.csNo.ReadOnly = False
        Me.csNo.Width = 60
        '
        'csName
        '
        Me.csName.Format = ""
        Me.csName.FormatInfo = Nothing
        Me.csName.HeaderText = "类型名称"
        Me.csName.MappingName = "name"
        Me.csName.NullText = ""
        Me.csName.Width = 200
        '
        'panTable
        '
        Me.panTable.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.panTable.Controls.AddRange(New System.Windows.Forms.Control() {Me.grdSubType, Me.splHorizontal, Me.grdTable})
        Me.panTable.Location = New System.Drawing.Point(8, 8)
        Me.panTable.Name = "panTable"
        Me.panTable.Size = New System.Drawing.Size(496, 288)
        Me.panTable.TabIndex = 10
        '
        'grdSubType
        '
        Me.grdSubType.CaptionVisible = False
        Me.grdSubType.DataMember = ""
        Me.grdSubType.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdSubType.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdSubType.Location = New System.Drawing.Point(0, 172)
        Me.grdSubType.Name = "grdSubType"
        Me.grdSubType.Size = New System.Drawing.Size(496, 116)
        Me.grdSubType.TabIndex = 7
        Me.grdSubType.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsSubType})
        '
        'tsSubType
        '
        Me.tsSubType.DataGrid = Me.grdSubType
        Me.tsSubType.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csTypeCode, Me.csSubTypeCode, Me.csSubTypeName})
        Me.tsSubType.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsSubType.MappingName = "TWorkSubType"
        '
        'csTypeCode
        '
        Me.csTypeCode.Format = ""
        Me.csTypeCode.FormatInfo = Nothing
        Me.csTypeCode.HeaderText = "类型编号"
        Me.csTypeCode.MappingName = "type_code"
        Me.csTypeCode.NullText = ""
        Me.csTypeCode.ReadOnly = True
        Me.csTypeCode.Width = 0
        '
        'csSubTypeCode
        '
        Me.csSubTypeCode.Format = ""
        Me.csSubTypeCode.FormatInfo = Nothing
        Me.csSubTypeCode.HeaderText = "子类型编号"
        Me.csSubTypeCode.MappingName = "subtype_code"
        Me.csSubTypeCode.NullText = ""
        Me.csSubTypeCode.Width = 80
        '
        'csSubTypeName
        '
        Me.csSubTypeName.Format = ""
        Me.csSubTypeName.FormatInfo = Nothing
        Me.csSubTypeName.HeaderText = "子类型名称"
        Me.csSubTypeName.MappingName = "name"
        Me.csSubTypeName.NullText = ""
        Me.csSubTypeName.Width = 200
        '
        'splHorizontal
        '
        Me.splHorizontal.Dock = System.Windows.Forms.DockStyle.Top
        Me.splHorizontal.Location = New System.Drawing.Point(0, 168)
        Me.splHorizontal.Name = "splHorizontal"
        Me.splHorizontal.Size = New System.Drawing.Size(496, 4)
        Me.splHorizontal.TabIndex = 6
        Me.splHorizontal.TabStop = False
        '
        'FWorkType
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.panTable})
        Me.Name = "FWorkType"
        Me.Text = "日志类型设置"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panTable.ResumeLayout(False)
        CType(Me.grdSubType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overloads Overrides Sub Refresh()
        Try
            Me.Cursor = Cursors.WaitCursor

            grdTable.SetDataBinding(gWs.GetWorkType("%"), "TWorkType")
            grdSubType.SetDataBinding(gWs.GetWorkSubType("%"), "TWorkSubType")

            Dim cm As CurrencyManager = Me.BindingContext(grdTable.DataSource, grdTable.DataMember)
            AddHandler cm.PositionChanged, AddressOf MasterTable_PositionChanged

            AddHandler CType(grdTable.DataSource, DataSet).Tables(grdTable.DataMember).RowChanged, AddressOf MasterTable_RowChanged

            '强制刷新从表数据
            MasterTable_PositionChanged(cm, EventArgs.Empty)
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Function ValidateMaster(ByVal data As DataTable) As Boolean
        If data.Select("work_type IS NULL OR work_type=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "编号")
            Return False
        End If
        If data.Select("name IS NULL OR name=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "类型名称")
            Return False
        End If

        Dim i, j As Int32
        Dim rows() As DataRow = data.Select("", "", DataViewRowState.CurrentRows)

        For i = 0 To rows.Length - 2
            For j = i + 1 To rows.Length - 1
                If rows(i)("work_type") = rows(j)("work_type") Then
                    SWDialogBox.MessageBox.Show("$1003", "编号")
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Private Function ValidateDetail(ByVal data As DataTable) As Boolean
        If data.Select("name IS NULL OR name=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "子类型名称")
            Return False
        End If
        If data.Select("subtype_code IS NULL OR subtype_code=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "子类型编号")
            Return False
        End If

        Dim i, j As Int32
        Dim rows() As DataRow = data.Select("", "", DataViewRowState.CurrentRows)

        For i = 0 To rows.Length - 2
            For j = i + 1 To rows.Length - 1
                If rows(i)("type_code") = rows(j)("type_code") AndAlso _
                        rows(i)("subtype_code") = rows(j)("subtype_code") Then
                    SWDialogBox.MessageBox.Show("$1003", "子类型编号")
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Public Overrides Function Update() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dsMaster As DataSet = CType(grdTable.DataSource, DataSet)
            Dim dsDetail As DataSet = CType(grdSubType.DataSource, DataSet)

            If Not dsMaster Is Nothing Then
                If Not ValidateMaster(dsMaster.Tables(grdTable.DataMember)) Then
                    Return False
                End If
            End If
            If Not dsDetail Is Nothing Then
                If Not ValidateDetail(dsDetail.Tables(grdSubType.DataMember)) Then
                    Return False
                End If
            End If

            Dim result As String = gWs.UpdateWorkType(dsMaster.GetChanges())

            If result = "1" Then
                '接受所有更改
                dsMaster.AcceptChanges()

                result = gWs.UpdateWorkSubType(dsDetail.GetChanges())
                If result = "1" Then
                    dsDetail.AcceptChanges()
                Else
                    '显示服务器的返回错误信息
                    SWDialogBox.MessageBox.Show("*999", Me.Name + ".Update", result, "")
                End If

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

    Private Sub FBank_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState <> FormWindowState.Minimized And splHorizontal.Top > Me.ClientSize.Height - Me.DockPadding.Top - Me.DockPadding.Bottom Then
            splHorizontal.SplitPosition = Me.ClientSize.Height - Me.DockPadding.Top - Me.DockPadding.Bottom - splHorizontal.MinSize
        End If
    End Sub

    Private Sub MasterTable_RowChanged(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        If e.Action = DataRowAction.Add Then
            MasterTable_PositionChanged(Nothing, EventArgs.Empty)
        End If
    End Sub

    Private Sub MasterTable_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If (Not grdTable.DataSource Is Nothing) AndAlso (Not grdSubType.DataSource Is Nothing) Then
            Dim rv As DataRowView = CType(Me.BindingContext(grdTable.DataSource, grdTable.DataMember).Current, DataRowView)

            csNo.ReadOnly = Not rv.IsNew

            Dim detailManager As CurrencyManager = Me.BindingContext(grdSubType.DataSource, grdSubType.DataMember)
            CType(detailManager.List, DataView).RowFilter = "type_code = '" + rv("work_type").ToString() + "'"
            CType(detailManager.List, DataView).Table.Columns("type_code").DefaultValue = rv.Item("work_type")
        End If
    End Sub

    Protected Overloads Overrides Function Confirm() As Boolean
        If grdTable.DataSource Is Nothing OrElse grdSubType.DataSource Is Nothing Then
            Return False
        End If

        If (Not CType(grdTable.DataSource, DataSet).HasChanges()) AndAlso (Not CType(grdSubType.DataSource, DataSet).HasChanges()) Then
            Return False
        End If

        '资料已经被改动过，您要保存吗？
        Dim result As DialogResult = SWDialogBox.MessageBox.Show("?1003")

        If result = DialogResult.Yes Then
            If Not Me.Update() Then
                Return True
            End If
        Else
            If result = DialogResult.Cancel Then
                Return True
            End If
        End If
    End Function
End Class
