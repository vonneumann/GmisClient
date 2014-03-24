Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FAlarm
    Inherits FMasterDetailDataForm

#Region " Windows 窗体设计器生成的代码 "

	Public Sub New()
		MyBase.New()

		'该调用是 Windows 窗体设计器所必需的。
		InitializeComponent()
        Me.csMasterTypeNo.TextBox.MaxLength = 1
        Me.csMasterTypeName.TextBox.MaxLength = 50
        Me.csDetailCodeNo.TextBox.MaxLength = 1
        Me.csDetailCodeName.TextBox.MaxLength = 50
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
    Friend WithEvents tsMaster As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents tsDetail As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csMasterTypeNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csMasterTypeName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csDeatilTypeNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csDetailCodeNo As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csDetailCodeName As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FAlarm))
        Me.tsMaster = New System.Windows.Forms.DataGridTableStyle()
        Me.csMasterTypeNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csMasterTypeName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.tsDetail = New System.Windows.Forms.DataGridTableStyle()
        Me.csDeatilTypeNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csDetailCodeNo = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csDetailCodeName = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.grdMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdMaster
        '
        Me.grdMaster.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsMaster})
        '
        'tsMaster
        '
        Me.tsMaster.DataGrid = Me.grdMaster
        Me.tsMaster.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csMasterTypeNo, Me.csMasterTypeName})
        Me.tsMaster.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsMaster.MappingName = "TAlarmType"
        '
        'csMasterTypeNo
        '
        Me.csMasterTypeNo.Format = ""
        Me.csMasterTypeNo.FormatInfo = Nothing
        Me.csMasterTypeNo.HeaderText = "预警等级"
        Me.csMasterTypeNo.MappingName = "alarm_type"
        Me.csMasterTypeNo.NullText = ""
        Me.csMasterTypeNo.Width = 60
        '
        'csMasterTypeName
        '
        Me.csMasterTypeName.Format = ""
        Me.csMasterTypeName.FormatInfo = Nothing
        Me.csMasterTypeName.HeaderText = "名  称"
        Me.csMasterTypeName.MappingName = "alarm_type_name"
        Me.csMasterTypeName.NullText = ""
        Me.csMasterTypeName.Width = 200
        '
        'grdDetail
        '
        Me.grdDetail.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsDetail})
        '
        'tsDetail
        '
        Me.tsDetail.DataGrid = Me.grdDetail
        Me.tsDetail.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csDeatilTypeNo, Me.csDetailCodeNo, Me.csDetailCodeName})
        Me.tsDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsDetail.MappingName = "TAlarmCode"
        '
        'csDeatilTypeNo
        '
        Me.csDeatilTypeNo.Format = ""
        Me.csDeatilTypeNo.FormatInfo = Nothing
        Me.csDeatilTypeNo.HeaderText = "预警等级"
        Me.csDeatilTypeNo.MappingName = "alarm_type"
        Me.csDeatilTypeNo.NullText = ""
        Me.csDeatilTypeNo.ReadOnly = True
        Me.csDeatilTypeNo.Width = 60
        '
        'csDetailCodeNo
        '
        Me.csDetailCodeNo.Format = ""
        Me.csDetailCodeNo.FormatInfo = Nothing
        Me.csDetailCodeNo.HeaderText = "预警编号"
        Me.csDetailCodeNo.MappingName = "alarm_code"
        Me.csDetailCodeNo.NullText = ""
        Me.csDetailCodeNo.Width = 60
        '
        'csDetailCodeName
        '
        Me.csDetailCodeName.Format = ""
        Me.csDetailCodeName.FormatInfo = Nothing
        Me.csDetailCodeName.HeaderText = "预警名称"
        Me.csDetailCodeName.MappingName = "alarm_name"
        Me.csDetailCodeName.NullText = ""
        Me.csDetailCodeName.Width = 200
        '
        'FAlarm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.grdDetail, Me.splHorizontal, Me.grdMaster})
        Me.DockPadding.Bottom = 40
        Me.DockPadding.Left = 8
        Me.DockPadding.Right = 8
        Me.DockPadding.Top = 8
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FAlarm"
        Me.Text = "预警等级设置"
        CType(Me.grdMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides Function RefreshData() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            grdMaster.SetDataBinding(gWs.GetAlarmType("%"), "TAlarmType")
            grdDetail.SetDataBinding(gWs.GetAlarmCode("%"), "TAlarmCode")

            If Not grdMaster.DataSource Is Nothing Then
                Dim masterManager As CurrencyManager = CType(Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember), CurrencyManager)
                AddHandler masterManager.PositionChanged, AddressOf MasterTable_PositionChanged
            End If

            AddHandler CType(grdMaster.DataSource, DataSet).Tables(grdMaster.DataMember).RowDeleted, AddressOf MasterTable_RowDeleted
            AddHandler CType(grdMaster.DataSource, DataSet).Tables(grdMaster.DataMember).RowChanged, AddressOf MasterTable_RowChanged

            MyBase.RefreshData()

            '强制刷新从表数据
            MasterTable_PositionChanged(Nothing, EventArgs.Empty)
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Protected Overrides Function ValidateMaster(ByVal data As DataTable) As Boolean
        If data.Select("alarm_type_name IS NULL OR alarm_type_name=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "预警等级")
            Return False
        End If
        If data.Select("alarm_type IS NULL OR alarm_type=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "预警编号")
            Return False
        End If

        Dim i, j As Int32
        Dim rows() As DataRow = data.Select("", "", DataViewRowState.CurrentRows)

        For i = 0 To rows.Length - 2
            For j = i + 1 To rows.Length - 1
                If rows(i)("alarm_type") = rows(j)("alarm_type") Then
                    SWDialogBox.MessageBox.Show("$1003", "预警编号")
                    Return False
                End If

                If rows(i)("alarm_type_name") = rows(j)("alarm_type_name") Then
                    SWDialogBox.MessageBox.Show("$1003", "预警等级")
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Protected Overrides Function ValidateDetail(ByVal data As DataTable) As Boolean
        If data.Select("alarm_name IS NULL OR alarm_name=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "预警等级")
            Return False
        End If
        If data.Select("alarm_code IS NULL OR alarm_code=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "编号")
            Return False
        End If

        Dim i, j As Int32
        Dim rows() As DataRow = data.Select("", "", DataViewRowState.CurrentRows)

        For i = 0 To rows.Length - 2
            For j = i + 1 To rows.Length - 1
                If rows(i)("alarm_type") = rows(j)("alarm_type") AndAlso _
                        rows(i)("alarm_code") = rows(j)("alarm_code") Then
                    SWDialogBox.MessageBox.Show("$1003", "编号")
                    Return False
                End If

                If rows(i)("alarm_type") = rows(j)("alarm_type") AndAlso _
                        rows(i)("alarm_name") = rows(j)("alarm_name") Then
                    SWDialogBox.MessageBox.Show("$1003", "预警等级")
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Public Overrides Function UpdateData() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            If Not MyBase.UpdateData() Then
                Return False
            End If

            Dim dsMaster As DataSet = CType(grdMaster.DataSource, DataSet)
            Dim dsDetail As DataSet = CType(grdDetail.DataSource, DataSet)

            Dim result As String = "1"

            If (Not dsMaster Is Nothing) AndAlso dsMaster.HasChanges() Then
                result = gWs.UpdateAlarmType(dsMaster.GetChanges())
            End If
            If (Not dsDetail Is Nothing) AndAlso dsDetail.HasChanges() Then
                result = gWs.UpdateAlarmCode(dsDetail.GetChanges())
            End If

            If result = "1" Then
                '接受所有更改
                dsMaster.AcceptChanges()
                dsDetail.AcceptChanges()

                '调用基类的刷新函数以重新刷新当前操作状态
                MyBase.RefreshData()

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

    Private Sub FAlarm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.RefreshData()
    End Sub

    Private Sub MasterTable_RowDeleted(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        MasterTable_PositionChanged(Nothing, e.Empty)
    End Sub

    Private Sub MasterTable_RowChanged(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        If e.Action = DataRowAction.Add Then
            MasterTable_PositionChanged(Nothing, EventArgs.Empty)
        End If
    End Sub

    Private Sub MasterTable_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If grdMaster.DataSource Is Nothing OrElse grdDetail.DataSource Is Nothing Then
            Return
        End If

        Dim masterManager As CurrencyManager = Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember)
        Dim detailManager As CurrencyManager = Me.BindingContext(grdDetail.DataSource, grdDetail.DataMember)

        If masterManager.Count > 0 Then
            Dim rv As DataRowView = CType(masterManager.Current, DataRowView)

            CType(detailManager.List, DataView).RowFilter = "alarm_type = '" + rv("alarm_type").ToString() + "'"
            CType(detailManager.List, DataView).Table.Columns("alarm_type").DefaultValue = rv("alarm_type")
        Else
            CType(detailManager.List, DataView).RowFilter = "alarm_type = NULL"
            CType(detailManager.List, DataView).Table.Columns("alarm_type").DefaultValue = DBNull.Value
        End If
    End Sub

    Protected Overrides Function DeleteMasterConfirm() As DialogResult
        Dim cm As CurrencyManager = Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember)
        If cm.Count <= 0 Then
            Return DialogResult.None
        End If

        Return SWDialogBox.MessageBox.Show("?1004", "［" + CType(cm.Current, DataRowView)("alarm_type_name") + "］")
    End Function

    Protected Overrides Function DeleteDetailConfirm() As DialogResult
        Dim cm As CurrencyManager = Me.BindingContext(grdDetail.DataSource, grdDetail.DataMember)
        If cm.Count <= 0 Then
            Return DialogResult.None
        End If

        Return SWDialogBox.MessageBox.Show("?1004", "［" + CType(cm.Current, DataRowView)("alarm_name") + "］")
    End Function
End Class
