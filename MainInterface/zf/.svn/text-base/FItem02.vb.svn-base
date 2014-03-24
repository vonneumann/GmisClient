Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class FItem02
	Inherits System.Windows.Forms.Form

#Region " Windows 窗体设计器生成的代码 "

	Public Sub New()
		MyBase.New()

		'该调用是 Windows 窗体设计器所必需的。
		InitializeComponent()
        Me.csItemName01.TextBox.MaxLength = 100
        Me.csItemName02.TextBox.MaxLength = 100
        Me.csItemName03.TextBox.MaxLength = 100
        Me.csTypeRemark01.TextBox.MaxLength = 2
        Me.csTypeRemark02.TextBox.MaxLength = 2
        Me.csTypeRemark03.TextBox.MaxLength = 2
        Me.csAdditional01.TextBox.MaxLength = 10
        Me.csAdditional02.TextBox.MaxLength = 10
        Me.csAdditional03.TextBox.MaxLength = 10
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
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnUpdate As System.Windows.Forms.Button
    Friend WithEvents tabTable As System.Windows.Forms.TabControl
    Friend WithEvents tabItem01 As System.Windows.Forms.TabPage
    Friend WithEvents tabItem02 As System.Windows.Forms.TabPage
    Friend WithEvents tabItem03 As System.Windows.Forms.TabPage
    Friend WithEvents grdTable01 As System.Windows.Forms.DataGrid
    Friend WithEvents grdTable02 As System.Windows.Forms.DataGrid
    Friend WithEvents grdTable03 As System.Windows.Forms.DataGrid
    Friend WithEvents tsItem01 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csItemNo01 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csItemName01 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csAdditional01 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csTypeRemark01 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents tsItem02 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csItemNo02 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csItemName02 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csAdditional02 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csTypeRemark02 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents tsItem03 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csItemNo03 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csItemName03 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csAdditional03 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csTypeRemark03 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csItemType01 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csItemType02 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csItemType03 As System.Windows.Forms.DataGridTextBoxColumn
    Protected WithEvents ImageList1 As System.Windows.Forms.ImageList
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FItem02))
        Me.tabTable = New System.Windows.Forms.TabControl()
        Me.tabItem01 = New System.Windows.Forms.TabPage()
        Me.grdTable01 = New System.Windows.Forms.DataGrid()
        Me.tsItem01 = New System.Windows.Forms.DataGridTableStyle()
        Me.csItemType01 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csItemNo01 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csItemName01 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csAdditional01 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTypeRemark01 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.tabItem02 = New System.Windows.Forms.TabPage()
        Me.grdTable02 = New System.Windows.Forms.DataGrid()
        Me.tsItem02 = New System.Windows.Forms.DataGridTableStyle()
        Me.csItemType02 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csItemNo02 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csItemName02 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csAdditional02 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTypeRemark02 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.tabItem03 = New System.Windows.Forms.TabPage()
        Me.grdTable03 = New System.Windows.Forms.DataGrid()
        Me.tsItem03 = New System.Windows.Forms.DataGridTableStyle()
        Me.csItemType03 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csItemNo03 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csItemName03 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csAdditional03 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csTypeRemark03 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.tabTable.SuspendLayout()
        Me.tabItem01.SuspendLayout()
        CType(Me.grdTable01, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabItem02.SuspendLayout()
        CType(Me.grdTable02, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabItem03.SuspendLayout()
        CType(Me.grdTable03, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabTable
        '
        Me.tabTable.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.tabTable.Controls.AddRange(New System.Windows.Forms.Control() {Me.tabItem01, Me.tabItem02, Me.tabItem03})
        Me.tabTable.Location = New System.Drawing.Point(8, 8)
        Me.tabTable.Name = "tabTable"
        Me.tabTable.SelectedIndex = 0
        Me.tabTable.Size = New System.Drawing.Size(496, 288)
        Me.tabTable.TabIndex = 0
        '
        'tabItem01
        '
        Me.tabItem01.Controls.AddRange(New System.Windows.Forms.Control() {Me.grdTable01})
        Me.tabItem01.Location = New System.Drawing.Point(4, 21)
        Me.tabItem01.Name = "tabItem01"
        Me.tabItem01.Size = New System.Drawing.Size(488, 263)
        Me.tabItem01.TabIndex = 0
        Me.tabItem01.Text = "资产负债表"
        '
        'grdTable01
        '
        Me.grdTable01.CaptionVisible = False
        Me.grdTable01.DataMember = ""
        Me.grdTable01.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTable01.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTable01.Name = "grdTable01"
        Me.grdTable01.Size = New System.Drawing.Size(488, 263)
        Me.grdTable01.TabIndex = 0
        Me.grdTable01.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsItem01})
        '
        'tsItem01
        '
        Me.tsItem01.DataGrid = Me.grdTable01
        Me.tsItem01.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csItemType01, Me.csItemNo01, Me.csItemName01, Me.csAdditional01, Me.csTypeRemark01})
        Me.tsItem01.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsItem01.MappingName = "TItem"
        '
        'csItemType01
        '
        Me.csItemType01.Format = ""
        Me.csItemType01.FormatInfo = Nothing
        Me.csItemType01.HeaderText = "类型"
        Me.csItemType01.MappingName = "item_type"
        Me.csItemType01.NullText = ""
        Me.csItemType01.ReadOnly = True
        Me.csItemType01.Width = 0
        '
        'csItemNo01
        '
        Me.csItemNo01.Format = ""
        Me.csItemNo01.FormatInfo = Nothing
        Me.csItemNo01.HeaderText = "编号"
        Me.csItemNo01.MappingName = "item_code"
        Me.csItemNo01.NullText = ""
        Me.csItemNo01.ReadOnly = True
        Me.csItemNo01.Width = 60
        '
        'csItemName01
        '
        Me.csItemName01.Format = ""
        Me.csItemName01.FormatInfo = Nothing
        Me.csItemName01.HeaderText = "名称"
        Me.csItemName01.MappingName = "item_name"
        Me.csItemName01.NullText = ""
        Me.csItemName01.Width = 350
        '
        'csAdditional01
        '
        Me.csAdditional01.Format = ""
        Me.csAdditional01.FormatInfo = Nothing
        Me.csAdditional01.HeaderText = "序号"
        Me.csAdditional01.MappingName = "additional_remark"
        Me.csAdditional01.NullText = ""
        Me.csAdditional01.Width = 60
        '
        'csTypeRemark01
        '
        Me.csTypeRemark01.Format = ""
        Me.csTypeRemark01.FormatInfo = Nothing
        Me.csTypeRemark01.HeaderText = "类型说明"
        Me.csTypeRemark01.MappingName = "item_type_remark"
        Me.csTypeRemark01.NullText = ""
        Me.csTypeRemark01.ReadOnly = True
        Me.csTypeRemark01.Width = 80
        '
        'tabItem02
        '
        Me.tabItem02.Controls.AddRange(New System.Windows.Forms.Control() {Me.grdTable02})
        Me.tabItem02.Location = New System.Drawing.Point(4, 21)
        Me.tabItem02.Name = "tabItem02"
        Me.tabItem02.Size = New System.Drawing.Size(488, 263)
        Me.tabItem02.TabIndex = 1
        Me.tabItem02.Text = "损益表"
        '
        'grdTable02
        '
        Me.grdTable02.CaptionVisible = False
        Me.grdTable02.DataMember = ""
        Me.grdTable02.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTable02.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTable02.Name = "grdTable02"
        Me.grdTable02.Size = New System.Drawing.Size(488, 263)
        Me.grdTable02.TabIndex = 1
        Me.grdTable02.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsItem02})
        '
        'tsItem02
        '
        Me.tsItem02.DataGrid = Me.grdTable02
        Me.tsItem02.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csItemType02, Me.csItemNo02, Me.csItemName02, Me.csAdditional02, Me.csTypeRemark02})
        Me.tsItem02.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsItem02.MappingName = "TItem"
        '
        'csItemType02
        '
        Me.csItemType02.Format = ""
        Me.csItemType02.FormatInfo = Nothing
        Me.csItemType02.HeaderText = "类型"
        Me.csItemType02.MappingName = "item_type"
        Me.csItemType02.NullText = ""
        Me.csItemType02.ReadOnly = True
        Me.csItemType02.Width = 0
        '
        'csItemNo02
        '
        Me.csItemNo02.Format = ""
        Me.csItemNo02.FormatInfo = Nothing
        Me.csItemNo02.HeaderText = "编号"
        Me.csItemNo02.MappingName = "item_code"
        Me.csItemNo02.NullText = ""
        Me.csItemNo02.ReadOnly = True
        Me.csItemNo02.Width = 60
        '
        'csItemName02
        '
        Me.csItemName02.Format = ""
        Me.csItemName02.FormatInfo = Nothing
        Me.csItemName02.HeaderText = "名称"
        Me.csItemName02.MappingName = "item_name"
        Me.csItemName02.NullText = ""
        Me.csItemName02.Width = 350
        '
        'csAdditional02
        '
        Me.csAdditional02.Format = ""
        Me.csAdditional02.FormatInfo = Nothing
        Me.csAdditional02.HeaderText = "序号"
        Me.csAdditional02.MappingName = "additional_remark"
        Me.csAdditional02.NullText = ""
        Me.csAdditional02.Width = 60
        '
        'csTypeRemark02
        '
        Me.csTypeRemark02.Format = ""
        Me.csTypeRemark02.FormatInfo = Nothing
        Me.csTypeRemark02.HeaderText = "类型说明"
        Me.csTypeRemark02.MappingName = "item_type_remark"
        Me.csTypeRemark02.NullText = ""
        Me.csTypeRemark02.ReadOnly = True
        Me.csTypeRemark02.Width = 80
        '
        'tabItem03
        '
        Me.tabItem03.Controls.AddRange(New System.Windows.Forms.Control() {Me.grdTable03})
        Me.tabItem03.Location = New System.Drawing.Point(4, 21)
        Me.tabItem03.Name = "tabItem03"
        Me.tabItem03.Size = New System.Drawing.Size(488, 263)
        Me.tabItem03.TabIndex = 2
        Me.tabItem03.Text = "现金流量表"
        '
        'grdTable03
        '
        Me.grdTable03.CaptionVisible = False
        Me.grdTable03.DataMember = ""
        Me.grdTable03.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdTable03.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdTable03.Name = "grdTable03"
        Me.grdTable03.Size = New System.Drawing.Size(488, 263)
        Me.grdTable03.TabIndex = 1
        Me.grdTable03.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsItem03})
        '
        'tsItem03
        '
        Me.tsItem03.DataGrid = Me.grdTable03
        Me.tsItem03.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csItemType03, Me.csItemNo03, Me.csItemName03, Me.csAdditional03, Me.csTypeRemark03})
        Me.tsItem03.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsItem03.MappingName = "TItem"
        '
        'csItemType03
        '
        Me.csItemType03.Format = ""
        Me.csItemType03.FormatInfo = Nothing
        Me.csItemType03.HeaderText = "类型"
        Me.csItemType03.MappingName = "item_type"
        Me.csItemType03.NullText = ""
        Me.csItemType03.ReadOnly = True
        Me.csItemType03.Width = 0
        '
        'csItemNo03
        '
        Me.csItemNo03.Format = ""
        Me.csItemNo03.FormatInfo = Nothing
        Me.csItemNo03.HeaderText = "编号"
        Me.csItemNo03.MappingName = "item_code"
        Me.csItemNo03.NullText = ""
        Me.csItemNo03.ReadOnly = True
        Me.csItemNo03.Width = 60
        '
        'csItemName03
        '
        Me.csItemName03.Format = ""
        Me.csItemName03.FormatInfo = Nothing
        Me.csItemName03.HeaderText = "名称"
        Me.csItemName03.MappingName = "item_name"
        Me.csItemName03.NullText = ""
        Me.csItemName03.Width = 350
        '
        'csAdditional03
        '
        Me.csAdditional03.Format = ""
        Me.csAdditional03.FormatInfo = Nothing
        Me.csAdditional03.HeaderText = "序号"
        Me.csAdditional03.MappingName = "additional_remark"
        Me.csAdditional03.NullText = ""
        Me.csAdditional03.Width = 60
        '
        'csTypeRemark03
        '
        Me.csTypeRemark03.Format = ""
        Me.csTypeRemark03.FormatInfo = Nothing
        Me.csTypeRemark03.HeaderText = "类型说明"
        Me.csTypeRemark03.MappingName = "item_type_remark"
        Me.csTypeRemark03.NullText = ""
        Me.csTypeRemark03.ReadOnly = True
        Me.csTypeRemark03.Width = 80
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 3
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(348, 304)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 17
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.CausesValidation = False
        Me.btnDelete.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 2
        Me.btnDelete.ImageList = Me.ImageList1
        Me.btnDelete.Location = New System.Drawing.Point(172, 304)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnRefresh.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.ImageIndex = 0
        Me.btnRefresh.ImageList = Me.ImageList1
        Me.btnRefresh.Location = New System.Drawing.Point(84, 304)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(77, 23)
        Me.btnRefresh.TabIndex = 14
        Me.btnRefresh.Text = "刷 新(&R)"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnUpdate
        '
        Me.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnUpdate.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Bitmap)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.ImageIndex = 1
        Me.btnUpdate.ImageList = Me.ImageList1
        Me.btnUpdate.Location = New System.Drawing.Point(260, 304)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(77, 23)
        Me.btnUpdate.TabIndex = 16
        Me.btnUpdate.Text = "保 存(&S)"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FItem02
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(512, 333)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.tabTable})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FItem02"
        Me.Text = "财务科目设置"
        Me.tabTable.ResumeLayout(False)
        Me.tabItem01.ResumeLayout(False)
        CType(Me.grdTable01, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabItem02.ResumeLayout(False)
        CType(Me.grdTable02, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabItem03.ResumeLayout(False)
        CType(Me.grdTable03, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

	Public Overloads Overrides Sub Refresh()
		Me.Refresh(-1)
	End Sub

	Public Overloads Sub Refresh(ByVal itemType As Int32)
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim activeGrid As DataGrid

			If itemType < 0 Or itemType > 2 Then
				itemType = tabTable.SelectedIndex
			End If

            Dim cm As CurrencyManager

            Select Case itemType
                Case 0
                    activeGrid = grdTable01
                    activeGrid.SetDataBinding(gWs.GetItemEx("{item_type = '01'}"), "TItem")
                    CType(grdTable01.DataSource, DataSet).Tables(grdTable01.DataMember).Columns("item_type").DefaultValue = "01"
                    CType(grdTable01.DataSource, DataSet).Tables(grdTable01.DataMember).Columns("item_type_remark").DefaultValue = "01"

                    cm = Me.BindingContext(grdTable01.DataSource, grdTable01.DataMember)
                    CType(cm.List, DataView).AllowNew = False
                Case 1
                    activeGrid = grdTable02
                    activeGrid.SetDataBinding(gWs.GetItemEx("{item_type = '02'}"), "TItem")
                    CType(grdTable02.DataSource, DataSet).Tables(grdTable02.DataMember).Columns("item_type").DefaultValue = "02"
                    CType(grdTable02.DataSource, DataSet).Tables(grdTable02.DataMember).Columns("item_type_remark").DefaultValue = "01"

                    cm = Me.BindingContext(grdTable02.DataSource, grdTable02.DataMember)
                    CType(cm.List, DataView).AllowNew = False
                Case 2
                    activeGrid = grdTable03
                    activeGrid.SetDataBinding(gWs.GetItemEx("{item_type = '03'}"), "TItem")
                    CType(grdTable03.DataSource, DataSet).Tables(grdTable03.DataMember).Columns("item_type").DefaultValue = "03"
                    CType(grdTable03.DataSource, DataSet).Tables(grdTable03.DataMember).Columns("item_type_remark").DefaultValue = "01"

                    cm = Me.BindingContext(grdTable03.DataSource, grdTable03.DataMember)
                    CType(cm.List, DataView).AllowNew = False
            End Select
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
	End Sub

	Public Shadows Function Update(Optional ByVal itemType As Int32 = -1) As Boolean
		Try
			Me.Cursor = Cursors.WaitCursor

			Dim result As String
			Dim activeGrid As DataGrid

			If itemType < 0 Or itemType > 2 Then
				itemType = tabTable.SelectedIndex
			End If

			Select Case itemType
				Case 0
					activeGrid = grdTable01
				Case 1
					activeGrid = grdTable02
				Case 2
					activeGrid = grdTable03
			End Select

			result = gWs.UpdateItem(CType(activeGrid.DataSource, DataSet).GetChanges())

			If result = "1" Then
				CType(activeGrid.DataSource, DataSet).AcceptChanges()
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

	Private Sub FItem_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
		Dim result As DialogResult

		If (Not grdTable01.DataSource Is Nothing) AndAlso CType(grdTable01.DataSource, DataSet).HasChanges Then
			result = MessageBox.Show("［资产负债表］资料已经被改动过，您要保存吗？", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

			If result = DialogResult.Yes Then
				If Not Me.Update(0) Then
					e.Cancel = True
					tabTable.SelectedTab = tabItem01
				End If
			Else
				If result = DialogResult.Cancel Then
					e.Cancel = True
				End If
			End If
		End If

		If (Not grdTable02.DataSource Is Nothing) AndAlso CType(grdTable02.DataSource, DataSet).HasChanges Then
			result = MessageBox.Show("［损益表］资料已经被改动过，您要保存吗？", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

			If result = DialogResult.Yes Then
				If Not Me.Update(1) Then
					e.Cancel = True
					tabTable.SelectedTab = tabItem02
				End If
			Else
				If result = DialogResult.Cancel Then
					e.Cancel = True
				End If
			End If
		End If

		If (Not grdTable03.DataSource Is Nothing) AndAlso CType(grdTable03.DataSource, DataSet).HasChanges Then
			result = MessageBox.Show("［现金流量表］资料已经被改动过，您要保存吗？", "系统提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

			If result = DialogResult.Yes Then
				If Not Me.Update(2) Then
					e.Cancel = True
					tabTable.SelectedTab = tabItem03
				End If
			Else
				If result = DialogResult.Cancel Then
					e.Cancel = True
				End If
			End If
		End If
	End Sub

	Private Sub FItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		Me.Refresh(tabTable.SelectedIndex)
	End Sub

	Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
		Me.Close()
	End Sub

	Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
		Dim activeGrid As DataGrid

		Select Case tabTable.SelectedIndex
			Case 0
				activeGrid = grdTable01
			Case 1
				activeGrid = grdTable02
			Case 2
				activeGrid = grdTable03
		End Select

		Try
			If Not activeGrid.DataSource Is Nothing Then
				If Me.BindingContext(activeGrid.DataSource, activeGrid.DataMember).Position >= 0 Then
					Dim rv As DataRowView = CType(Me.BindingContext(activeGrid.DataSource, activeGrid.DataMember).Current, DataRowView)

					rv.Delete()
				End If
			End If
		Catch ex As System.Exception
			'统一错误处理
			ExceptionHandler.ShowMessageBox(ex)
		End Try
	End Sub

	Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
		Me.Refresh(tabTable.SelectedIndex)
	End Sub

	Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click
        If Me.Update(tabTable.SelectedIndex) Then
            SWDialogBox.MessageBox.Show("$SaveSucceed")
        End If
	End Sub

	Private Sub tabTable_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabTable.SelectedIndexChanged
		Dim activeGrid As DataGrid

		Select Case tabTable.SelectedIndex
			Case 0
				activeGrid = grdTable01
			Case 1
				activeGrid = grdTable02
			Case 2
				activeGrid = grdTable03
		End Select

		If activeGrid.DataSource Is Nothing Then
			Me.Refresh(tabTable.SelectedIndex)
		End If
	End Sub
End Class