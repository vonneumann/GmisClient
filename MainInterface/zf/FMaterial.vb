Public Class FMaterial
    Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
        Me.csItemType.TextBox.MaxLength = 2
        Me.csItemCode.TextBox.MaxLength = 3
        Me.csItemName.TextBox.MaxLength = 100
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
    Friend WithEvents tsDefault As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents lblServiceType As System.Windows.Forms.Label
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents btnDuplicate As System.Windows.Forms.Button
    Friend WithEvents grdTable As System.Windows.Forms.DataGrid
    Friend WithEvents csServiceType As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csItemCode As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csItemName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csRemark As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents csItemType As DataGridComboBoxColumn
    Friend WithEvents csIsImportant As System.Windows.Forms.DataGridBoolColumn
    Protected WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FMaterial))
        Me.grdTable = New System.Windows.Forms.DataGrid()
        Me.tsDefault = New System.Windows.Forms.DataGridTableStyle()
        Me.csServiceType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csItemType = New MainInterface.DataGridComboBoxColumn()
        Me.csItemCode = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csItemName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIsImportant = New System.Windows.Forms.DataGridBoolColumn()
        Me.csRemark = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.lblServiceType = New System.Windows.Forms.Label()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.btnDuplicate = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdTable
        '
        Me.grdTable.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grdTable.CaptionVisible = False
        Me.grdTable.DataMember = ""
        Me.grdTable.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTable.Location = New System.Drawing.Point(8, 32)
        Me.grdTable.Name = "grdTable"
        Me.grdTable.Size = New System.Drawing.Size(496, 264)
        Me.grdTable.TabIndex = 0
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsDefault})
        '
        'tsDefault
        '
        Me.tsDefault.DataGrid = Me.grdTable
        Me.tsDefault.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csServiceType, Me.csItemType, Me.csItemCode, Me.csItemName, Me.csIsImportant, Me.csRemark})
        Me.tsDefault.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsDefault.MappingName = "TMaterial"
        '
        'csServiceType
        '
        Me.csServiceType.Format = ""
        Me.csServiceType.FormatInfo = Nothing
        Me.csServiceType.HeaderText = "业务品种"
        Me.csServiceType.MappingName = "service_type"
        Me.csServiceType.NullText = ""
        Me.csServiceType.ReadOnly = True
        Me.csServiceType.Width = 120
        '
        'csItemType
        '
        Me.csItemType.Format = ""
        Me.csItemType.FormatInfo = Nothing
        Me.csItemType.HeaderText = "材料类型"
        Me.csItemType.MappingName = "item_type"
        Me.csItemType.NullText = ""
        Me.csItemType.Width = 120
        '
        'csItemCode
        '
        Me.csItemCode.Format = ""
        Me.csItemCode.FormatInfo = Nothing
        Me.csItemCode.HeaderText = "材料编号"
        Me.csItemCode.MappingName = "item_code"
        Me.csItemCode.NullText = ""
        Me.csItemCode.Width = 80
        Me.csItemCode.TextBox.MaxLength = 3
        '
        'csItemName
        '
        Me.csItemName.Format = ""
        Me.csItemName.FormatInfo = Nothing
        Me.csItemName.HeaderText = "材料名称"
        Me.csItemName.MappingName = "item_name"
        Me.csItemName.NullText = ""
        Me.csItemName.Width = 300
        Me.csItemName.TextBox.MaxLength = 100
        '
        'csIsImportant
        '
        Me.csIsImportant.FalseValue = False
        Me.csIsImportant.HeaderText = "是否关键"
        Me.csIsImportant.MappingName = "is_important"
        Me.csIsImportant.NullText = ""
        Me.csIsImportant.NullValue = CType(resources.GetObject("csIsImportant.NullValue"), System.DBNull)
        Me.csIsImportant.TrueValue = True
        Me.csIsImportant.Width = 60
        '
        'csRemark
        '
        Me.csRemark.Format = ""
        Me.csRemark.FormatInfo = Nothing
        Me.csRemark.HeaderText = "备  注"
        Me.csRemark.MappingName = "remark"
        Me.csRemark.NullText = ""
        Me.csRemark.Width = 120
        Me.csRemark.TextBox.MaxLength = 100
        '
        'lblServiceType
        '
        Me.lblServiceType.Location = New System.Drawing.Point(8, 12)
        Me.lblServiceType.Name = "lblServiceType"
        Me.lblServiceType.Size = New System.Drawing.Size(56, 16)
        Me.lblServiceType.TabIndex = 1
        Me.lblServiceType.Text = "业务品种"
        '
        'cboServiceType
        '
        Me.cboServiceType.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.cboServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServiceType.Location = New System.Drawing.Point(64, 8)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(328, 20)
        Me.cboServiceType.TabIndex = 2
        '
        'btnDuplicate
        '
        Me.btnDuplicate.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnDuplicate.Image = CType(resources.GetObject("btnDuplicate.Image"), System.Drawing.Bitmap)
        Me.btnDuplicate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDuplicate.ImageIndex = 4
        Me.btnDuplicate.ImageList = Me.ImageList1
        Me.btnDuplicate.Location = New System.Drawing.Point(404, 5)
        Me.btnDuplicate.Name = "btnDuplicate"
        Me.btnDuplicate.Size = New System.Drawing.Size(100, 23)
        Me.btnDuplicate.TabIndex = 3
        Me.btnDuplicate.Text = "复制(&C)..."
        Me.btnDuplicate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.ImageIndex = 0
        Me.btnRefresh.ImageList = Me.ImageList1
        Me.btnRefresh.Location = New System.Drawing.Point(84, 304)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(77, 23)
        Me.btnRefresh.TabIndex = 4
        Me.btnRefresh.Text = "刷 新(&R)"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 2
        Me.btnDelete.ImageList = Me.ImageList1
        Me.btnDelete.Location = New System.Drawing.Point(172, 304)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.ImageIndex = 1
        Me.btnUpdate.ImageList = Me.ImageList1
        Me.btnUpdate.Location = New System.Drawing.Point(260, 304)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(77, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "保 存(&S)"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 3
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(348, 304)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FMaterial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnUpdate, Me.btnDelete, Me.btnRefresh, Me.btnDuplicate, Me.cboServiceType, Me.lblServiceType, Me.grdTable})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FMaterial"
        Me.Text = "文档材料设置"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Function ValidateData(ByVal data As DataTable) As Boolean
        If data.Select("item_name IS NULL OR item_name=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "材料类型")
            Return False
        End If
        If data.Select("item_code IS NULL OR item_code=''", "", DataViewRowState.CurrentRows).Length > 0 Then
            SWDialogBox.MessageBox.Show("$1001", "材料编号")
            Return False
        End If

        Dim i, j As Int32
        Dim rows() As DataRow = data.Select("", "", DataViewRowState.CurrentRows)

        For i = 0 To rows.Length - 2
            For j = i + 1 To rows.Length - 1
                If rows(i)("item_type") = rows(j)("item_type") AndAlso rows(i)("item_code") = rows(j)("item_code") Then
                    SWDialogBox.MessageBox.Show("$1003", "材料编号")
                    Return False
                End If
            Next
        Next
        Return True
    End Function

    Public Overloads Sub Refresh(ByVal serviceType As String)
        If serviceType Is Nothing Then
            Dim dsServiceType As DataSet = gWs.GetServiceType("%")
            cboServiceType.DisplayMember = "service_type"
            cboServiceType.ValueMember = "service_type"
            cboServiceType.DataSource = dsServiceType.Tables(0)
            serviceType = cboServiceType.SelectedValue
        Else
            cboServiceType.SelectedValue = serviceType
        End If

        Dim dataSet As DataSet = gWs.GetMaterial("%", "%", serviceType)
        dataSet.Tables("TMaterial").Columns("service_type").DefaultValue = serviceType
        grdTable.SetDataBinding(dataSet, "TMaterial")

        AddHandler dataSet.Tables("TMaterial").RowChanging, AddressOf TMaterial_RowChanging
    End Sub

    Public Shadows Function Update() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            Dim dataSet As DataSet = grdTable.DataSource

            If dataSet Is Nothing OrElse (Not dataSet.HasChanges()) Then
                Return True
            End If

            If Not ValidateData(dataSet.Tables(0)) Then
                Return False
            End If

            Dim result As String

            result = gWs.UpdateMaterial(dataSet.GetChanges())

            If result = "1" Then
                '接受所有更改
                dataSet.AcceptChanges()

                '重新刷新数据
                Me.Refresh(cboServiceType.SelectedValue)

                Return True
            Else
                '显示服务器的返回错误信息
                SWDialogBox.MessageBox.Show("*999", Me.Name + ".Update", result, "")
            End If
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try

        Return False
    End Function

    Private Sub FMaterial_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If grdTable.DataSource Is Nothing Then
            Return
        Else
            If CType(grdTable.DataSource, DataSet).GetChanges() Is Nothing Then
                Return
            End If
        End If

        '资料已经被改动过，您要保存吗？
        Dim result As DialogResult = SWDialogBox.MessageBox.Show("?1003")

        If result = DialogResult.Yes Then
            If Not Me.Update() Then
                e.Cancel = True
            End If
        Else
            If result = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub FMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'qxd modify 2005-4-1 只取出需要的类型，防止添加43（合同列表）等，引起发生错误！
        'csItemType.ColumnComboBox.DataSource = gWs.GetItemType("{item_type_belong = '04'}").Tables(0).DefaultView
        csItemType.ColumnComboBox.DataSource = gWs.GetItemType("{item_type in ('41','42')}").Tables(0).DefaultView
        csItemType.ColumnComboBox.DisplayMember = "type_name"
        csItemType.ColumnComboBox.ValueMember = "item_type"

        Me.Refresh(Nothing)
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cboServiceType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboServiceType.SelectedIndexChanged
        Me.Refresh(cboServiceType.SelectedValue)
    End Sub

    Private Sub btnDuplicate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuplicate.Click
        Dim dialogForm As FServiceTypeDialog = New FServiceTypeDialog()
        dialogForm.SourceServiceType = Me.cboServiceType.Text

        If dialogForm.ShowDialog(Me) <> DialogResult.OK Then
            Return
        End If

        Dim result As String = gWs.DuplicateMaterial(cboServiceType.SelectedValue, dialogForm.ServiceType)

        If result = "1" Then
            SWDialogBox.MessageBox.Show("$OperateSucceed")
        Else
            '显示服务器的返回错误信息
            SWDialogBox.MessageBox.Show("*999", Me.Name + ".Update", result, "")
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Me.Refresh(cboServiceType.SelectedValue)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim bm As BindingManagerBase = Me.BindingContext(grdTable.DataSource, grdTable.DataMember)
        If bm.Position < 0 Then
            Return
        End If

        Dim rv As DataRowView = bm.Current
        rv.Row.Delete()
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If Me.Update() Then
            SWDialogBox.MessageBox.Show("$SaveSucceed")
        End If
    End Sub

    Private Sub TMaterial_RowChanging(ByVal sender As Object, ByVal e As System.Data.DataRowChangeEventArgs)
        '    If e.Action = DataRowAction.Add Then
        '        Dim itemType As String
        '        Dim itemCode As String

        '        If e.Row.HasVersion(DataRowVersion.Proposed) Then
        '            itemType = e.Row("item_type").ToString()
        '            itemCode = e.Row("item_code").ToString()
        '        End If

        '        Dim rows As DataRow() = _itemDST.Tables("TItem").Select("item_type = '" + itemType + "' AND item_code = '" + itemCode + "'")
        '        If (rows.Length <= 0) Then
        '            Dim row As DataRow = _itemDST.Tables("TItem").NewRow()
        '            row("item_type") = itemType
        '            row("item_code") = itemCode
        '            row("item_name") = e.Row("item_name")
        '            row("additional_remark") = e.Row("additional_remark")
        '            _itemDST.Tables("TItem").Rows.Add(row)
        '        End If
        '    End If

        '    If e.Action = DataRowAction.Change AndAlso e.Row.HasVersion(DataRowVersion.Proposed) Then
        '        Dim newCode As String = e.Row.Item("item_code", DataRowVersion.Proposed).ToString()
        '        Dim oldCode As String = e.Row.Item("item_code").ToString()

        '        Dim rows As DataRow() = _itemDST.Tables("TItem").Select("item_type = '" + e.Row("item_type").ToString() + "' AND item_code = '" + oldCode + "'")
        '        If (rows.Length > 0) Then
        '            rows(0)("item_code") = newCode
        '        End If
        '    End If
    End Sub
End Class
