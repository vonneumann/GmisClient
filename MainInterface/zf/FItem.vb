Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FItem
    Inherits FMasterDetailDataForm

#Region " Windows 窗体设计器生成的代码 "

	Public Sub New()
		MyBase.New()

		'该调用是 Windows 窗体设计器所必需的。
		InitializeComponent()
        Me.csItemType.TextBox.MaxLength = 2
        Me.csTypeName.TextBox.MaxLength = 20
        Me.csItemCode.TextBox.MaxLength = 3
        Me.csItemName.TextBox.MaxLength = 100
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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csItemType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csTypeName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csItemCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csItemName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csItemType2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csAdditional As DataGridComboBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FItem))
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.csItemType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTypeName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csAdditional = New MainInterface.DataGridComboBoxColumn()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.csItemType2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csItemCode = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csItemName = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.grdMaster, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdMaster
        '
        Me.grdMaster.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdMaster
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csItemType, Me.csTypeName, Me.csAdditional})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TItemType"
        '
        'csItemType
        '
        Me.csItemType.Format = ""
        Me.csItemType.FormatInfo = Nothing
        Me.csItemType.HeaderText = "类型编号"
        Me.csItemType.MappingName = "item_type"
        Me.csItemType.NullText = ""
        Me.csItemType.Width = 60
        '
        'csTypeName
        '
        Me.csTypeName.Format = ""
        Me.csTypeName.FormatInfo = Nothing
        Me.csTypeName.HeaderText = "类型名称"
        Me.csTypeName.MappingName = "type_name"
        Me.csTypeName.NullText = ""
        Me.csTypeName.Width = 150
        '
        'csAdditional
        '
        Me.csAdditional.Format = ""
        Me.csAdditional.FormatInfo = Nothing
        Me.csAdditional.HeaderText = "是否评估"
        Me.csAdditional.MappingName = "additional_remark"
        Me.csAdditional.NullText = ""
        Me.csAdditional.Width = 80
        '
        'grdDetail
        '
        Me.grdDetail.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.grdDetail
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csItemType2, Me.csItemCode, Me.csItemName})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "TItem"
        '
        'csItemType2
        '
        Me.csItemType2.Format = ""
        Me.csItemType2.FormatInfo = Nothing
        Me.csItemType2.HeaderText = "类型编号"
        Me.csItemType2.MappingName = "item_type"
        Me.csItemType2.NullText = ""
        Me.csItemType2.ReadOnly = True
        Me.csItemType2.Width = 60
        '
        'csItemCode
        '
        Me.csItemCode.Format = ""
        Me.csItemCode.FormatInfo = Nothing
        Me.csItemCode.HeaderText = "科目编号"
        Me.csItemCode.MappingName = "item_code"
        Me.csItemCode.NullText = ""
        Me.csItemCode.ReadOnly = True
        Me.csItemCode.Width = 60
        '
        'csItemName
        '
        Me.csItemName.Format = ""
        Me.csItemName.FormatInfo = Nothing
        Me.csItemName.HeaderText = "科目名称"
        Me.csItemName.MappingName = "item_name"
        Me.csItemName.NullText = ""
        Me.csItemName.Width = 150
        '
        'FItem
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.DockPadding.Bottom = 40
        Me.DockPadding.Left = 8
        Me.DockPadding.Right = 8
        Me.DockPadding.Top = 8
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FItem"
        Me.Text = "反担保物品种设置"
        CType(Me.grdMaster, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overrides Function RefreshData() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            grdMaster.SetDataBinding(gWs.GetItemType("{item_type_belong = '02'}"), "TItemType")
            grdDetail.SetDataBinding(gWs.GetItem("%", "%"), "TItem")

            Dim masterTable As DataTable = CType(grdMaster.DataSource, DataSet).Tables(grdMaster.DataMember)
            masterTable.Columns("item_type_belong").DefaultValue = "02"
            AddHandler masterTable.RowDeleted, AddressOf MasterTable_RowDeleted
            AddHandler masterTable.RowChanged, AddressOf MasterTable_RowChanged

            Dim masterManager As CurrencyManager = Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember)
            Dim detailManager As CurrencyManager = Me.BindingContext(grdDetail.DataSource, grdDetail.DataMember)

            AddHandler masterManager.PositionChanged, AddressOf MasterTable_PositionChanged
            AddHandler detailManager.PositionChanged, AddressOf DetailTable_PositionChanged

            MyBase.RefreshData()

            '强制刷新从表数据
            MasterTable_PositionChanged(masterManager, EventArgs.Empty)
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Function

    Protected Overrides Function ValidateMaster(ByVal data As DataTable) As Boolean
        If data.Select("item_type IS NULL OR item_type=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "类型编号")
            Return False
        End If
        If data.Select("type_name IS NULL OR type_name=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "类型名称")
            Return False
        End If

        Dim i, j As Int32
        Dim rows() As DataRow = data.Select("", "", DataViewRowState.CurrentRows)

        For i = 0 To rows.Length - 2
            For j = i + 1 To rows.Length - 1
                If rows(i)("item_type") = rows(j)("item_type") Then
                    SWDialogBox.MessageBox.Show("$1003", "类型编号")
                    Return False
                End If
            Next
        Next

        Return True
    End Function

    Protected Overrides Function ValidateDetail(ByVal data As DataTable) As Boolean
        If data.Select("item_name IS NULL OR item_name=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "科目名称")
            Return False
        End If
        If data.Select("item_code IS NULL OR item_code=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "科目编号")
            Return False
        End If

        Dim i, j As Int32
        Dim rows() As DataRow = data.Select("", "", DataViewRowState.CurrentRows)

        For i = 0 To rows.Length - 2
            For j = i + 1 To rows.Length - 1
                If rows(i)("item_type") = rows(j)("item_type") AndAlso _
                        rows(i)("item_code") = rows(j)("item_code") Then
                    SWDialogBox.MessageBox.Show("$1003", "科目编号")
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
                result = gWs.UpdateItemType(dsMaster.GetChanges())
            End If
            If (Not dsDetail Is Nothing) AndAlso dsDetail.HasChanges() Then
                result = gWs.UpdateItem(dsDetail.GetChanges())
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

    Private Sub FItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dtAddition As DataTable = New DataTable("TAddition")

        dtAddition.Columns.Add("DisplayField", GetType(String))
        dtAddition.Columns.Add("ValueField", GetType(String))
        dtAddition.Rows.Add(New Object() {"是", "1"})
        dtAddition.Rows.Add(New Object() {"否", "0"})

        csAdditional.ColumnComboBox.DataSource = dtAddition.DefaultView
        csAdditional.ColumnComboBox.DisplayMember = "DisplayField"
        csAdditional.ColumnComboBox.ValueMember = "ValueField"

        Me.RefreshData()
    End Sub

    Private Sub MasterTable_RowDeleted(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        MasterTable_PositionChanged(sender, EventArgs.Empty)
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

            csItemType.ReadOnly = Not rv.IsNew

            CType(detailManager.List, DataView).RowFilter = "item_type = '" + rv("item_type").ToString() + "'"
            CType(detailManager.List, DataView).Table.Columns("item_type").DefaultValue = rv.Item("item_type")
        Else
            CType(detailManager.List, DataView).RowFilter = "item_type = NULL"
            CType(detailManager.List, DataView).Table.Columns("item_type").DefaultValue = DBNull.Value
        End If
    End Sub

    Private Sub DetailTable_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        Dim detailManager As CurrencyManager = Me.BindingContext(grdDetail.DataSource, grdDetail.DataMember)

        If detailManager.Position >= 0 Then
            csItemCode.ReadOnly = Not CType(detailManager.Current, DataRowView).IsNew
        End If
    End Sub

    Protected Overrides Function DeleteMasterConfirm() As DialogResult
        Dim cm As CurrencyManager = Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember)
        If cm.Count <= 0 Then
            Return DialogResult.None
        End If

        Return SWDialogBox.MessageBox.Show("?1004", "［" + CType(cm.Current, DataRowView)("type_name") + "］")
    End Function

    Protected Overrides Function DeleteDetailConfirm() As DialogResult
        Dim cm As CurrencyManager = Me.BindingContext(grdDetail.DataSource, grdDetail.DataMember)
        If cm.Count <= 0 Then
            Return DialogResult.None
        End If

        Return SWDialogBox.MessageBox.Show("?1004", "［" + CType(cm.Current, DataRowView)("item_name") + "］")
    End Function
End Class
