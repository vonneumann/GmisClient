Public Class FCreditAppraiseQuality
    Inherits FMasterDetailDataForm

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化
        csIndexOrderID.TextBox.MaxLength = 2
        csIndexIndexID.TextBox.MaxLength = 3
        csIndexIndexName.TextBox.MaxLength = 50
        csIndexFullMark.TextBox.MaxLength = 6
        csIndexRemark.TextBox.MaxLength = 50
        Me.csStandardSerialID.TextBox.MaxLength = 3
        Me.csStandardScore.TextBox.MaxLength = 6
        Me.csStandardCondition.TextBox.MaxLength = 20
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
	Friend WithEvents lblSystemID As System.Windows.Forms.Label
	Friend WithEvents cboSystemID As System.Windows.Forms.ComboBox
	Friend WithEvents lblUsed As System.Windows.Forms.Label
	Friend WithEvents lblDate As System.Windows.Forms.Label
	Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents tsTCreditQualityIndex As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents tsTCreditQualityStandard As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents csIndexSystemID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csIndexIndexType As DataGridComboBoxColumn
    Friend WithEvents csIndexOrderID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csIndexIndexID As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csIndexIndexName As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csIndexFullMark As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents csIndexFlag As System.Windows.Forms.DataGridBoolColumn
	Friend WithEvents csIndexRemark As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csStandardSystemID As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csStandardIndexType As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csStandardIndexID As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csStandardSerialID As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csStandardScore As System.Windows.Forms.DataGridTextBoxColumn
	Friend WithEvents csStandardCondition As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FCreditAppraiseQuality))
        Me.lblSystemID = New System.Windows.Forms.Label()
        Me.cboSystemID = New System.Windows.Forms.ComboBox()
        Me.lblUsed = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.tsTCreditQualityIndex = New System.Windows.Forms.DataGridTableStyle()
        Me.csIndexSystemID = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIndexIndexType = New DataGridComboBoxColumn()
        Me.csIndexOrderID = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIndexIndexID = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIndexIndexName = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIndexFullMark = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csIndexFlag = New System.Windows.Forms.DataGridBoolColumn()
        Me.csIndexRemark = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.tsTCreditQualityStandard = New System.Windows.Forms.DataGridTableStyle()
        Me.csStandardSystemID = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csStandardIndexType = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csStandardIndexID = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csStandardSerialID = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csStandardScore = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.csStandardCondition = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(100, 384)
        Me.btnRefresh.Visible = True
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(188, 384)
        Me.btnInsert.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(276, 384)
        Me.btnDelete.Visible = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(364, 384)
        Me.btnUpdate.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(452, 384)
        Me.btnExit.Visible = True
        '
        'lblSystemID
        '
        Me.lblSystemID.AutoSize = True
        Me.lblSystemID.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSystemID.Location = New System.Drawing.Point(8, 14)
        Me.lblSystemID.Name = "lblSystemID"
        Me.lblSystemID.Size = New System.Drawing.Size(72, 14)
        Me.lblSystemID.TabIndex = 0
        Me.lblSystemID.Text = "体系编号(&N)"
        '
        'cboSystemID
        '
        Me.cboSystemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSystemID.Location = New System.Drawing.Point(88, 8)
        Me.cboSystemID.Name = "cboSystemID"
        Me.cboSystemID.Size = New System.Drawing.Size(80, 20)
        Me.cboSystemID.TabIndex = 1
        '
        'lblUsed
        '
        Me.lblUsed.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.lblUsed.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.lblUsed.Location = New System.Drawing.Point(496, 8)
        Me.lblUsed.Name = "lblUsed"
        Me.lblUsed.Size = New System.Drawing.Size(20, 20)
        Me.lblUsed.TabIndex = 3
        Me.lblUsed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblUsed.Visible = False
        '
        'lblDate
        '
        Me.lblDate.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.lblDate.Location = New System.Drawing.Point(528, 16)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(96, 14)
        Me.lblDate.TabIndex = 4
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtRemark.BackColor = System.Drawing.Color.FromArgb(CType(224, Byte), CType(224, Byte), CType(224, Byte))
        Me.txtRemark.Location = New System.Drawing.Point(176, 8)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ReadOnly = True
        Me.txtRemark.Size = New System.Drawing.Size(280, 21)
        Me.txtRemark.TabIndex = 2
        Me.txtRemark.TabStop = False
        Me.txtRemark.Text = ""
        '
        'grdMaster
        '
        Me.grdMaster.TableStyles.Add(Me.tsTCreditQualityIndex)
        '
        'tsTCreditQualityIndex
        '
        Me.tsTCreditQualityIndex.DataGrid = Me.grdMaster
        Me.tsTCreditQualityIndex.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csIndexSystemID, Me.csIndexIndexType, Me.csIndexOrderID, Me.csIndexIndexID, Me.csIndexIndexName, Me.csIndexFullMark, Me.csIndexFlag, Me.csIndexRemark})
        Me.tsTCreditQualityIndex.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsTCreditQualityIndex.MappingName = "TCreditQualityIndex"
        '
        'csIndexSystemID
        '
        Me.csIndexSystemID.Format = ""
        Me.csIndexSystemID.FormatInfo = Nothing
        Me.csIndexSystemID.HeaderText = "体系编号"
        Me.csIndexSystemID.MappingName = "system_id"
        Me.csIndexSystemID.ReadOnly = True
        Me.csIndexSystemID.Width = 60
        '
        'csIndexIndexType
        '
        Me.csIndexIndexType.Format = ""
        Me.csIndexIndexType.FormatInfo = Nothing
        Me.csIndexIndexType.HeaderText = "指标类型"
        Me.csIndexIndexType.MappingName = "index_type"
        Me.csIndexIndexType.Width = 150
        '
        'csIndexOrderID
        '
        Me.csIndexOrderID.Format = ""
        Me.csIndexOrderID.FormatInfo = Nothing
        Me.csIndexOrderID.HeaderText = "序号"
        Me.csIndexOrderID.MappingName = "order_id"
        Me.csIndexOrderID.Width = 60
        '
        'csIndexIndexID
        '
        Me.csIndexIndexID.Format = ""
        Me.csIndexIndexID.FormatInfo = Nothing
        Me.csIndexIndexID.HeaderText = "指标编号"
        Me.csIndexIndexID.MappingName = "index_id"
        Me.csIndexIndexID.Width = 60
        '
        'csIndexIndexName
        '
        Me.csIndexIndexName.Format = ""
        Me.csIndexIndexName.FormatInfo = Nothing
        Me.csIndexIndexName.HeaderText = "指标名称"
        Me.csIndexIndexName.MappingName = "index_name"
        Me.csIndexIndexName.Width = 210
        '
        'csIndexFullMark
        '
        Me.csIndexFullMark.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csIndexFullMark.Format = ""
        Me.csIndexFullMark.FormatInfo = Nothing
        Me.csIndexFullMark.HeaderText = "满  分"
        Me.csIndexFullMark.MappingName = "full_mark"
        Me.csIndexFullMark.Width = 60
        '
        'csIndexFlag
        '
        Me.csIndexFlag.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.csIndexFlag.FalseValue = False
        Me.csIndexFlag.HeaderText = "特殊指标"
        Me.csIndexFlag.MappingName = "flag"
        Me.csIndexFlag.NullValue = CType(resources.GetObject("csIndexFlag.NullValue"), System.DBNull)
        Me.csIndexFlag.TrueValue = True
        Me.csIndexFlag.Width = 60
        '
        'csIndexRemark
        '
        Me.csIndexRemark.Format = ""
        Me.csIndexRemark.FormatInfo = Nothing
        Me.csIndexRemark.HeaderText = "备    注"
        Me.csIndexRemark.MappingName = "remark"
        Me.csIndexRemark.Width = 150
        '
        'grdDetail
        '
        Me.grdDetail.TableStyles.Add(tsTCreditQualityStandard)
        '
        'tsTCreditQualityStandard
        '
        Me.tsTCreditQualityStandard.DataGrid = Me.grdDetail
        Me.tsTCreditQualityStandard.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.csStandardSystemID, Me.csStandardIndexType, Me.csStandardIndexID, Me.csStandardSerialID, Me.csStandardScore, Me.csStandardCondition})
        Me.tsTCreditQualityStandard.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsTCreditQualityStandard.MappingName = "TCreditQualityStandard"
        '
        'csStandardSystemID
        '
        Me.csStandardSystemID.Format = ""
        Me.csStandardSystemID.FormatInfo = Nothing
        Me.csStandardSystemID.HeaderText = "系统编号"
        Me.csStandardSystemID.MappingName = "system_id"
        Me.csStandardSystemID.ReadOnly = True
        Me.csStandardSystemID.Width = 60
        '
        'csStandardIndexType
        '
        Me.csStandardIndexType.Format = ""
        Me.csStandardIndexType.FormatInfo = Nothing
        Me.csStandardIndexType.HeaderText = "指标类型"
        Me.csStandardIndexType.MappingName = "index_type"
        Me.csStandardIndexType.ReadOnly = True
        Me.csStandardIndexType.Width = 60
        '
        'csStandardIndexID
        '
        Me.csStandardIndexID.Format = ""
        Me.csStandardIndexID.FormatInfo = Nothing
        Me.csStandardIndexID.HeaderText = "指标编号"
        Me.csStandardIndexID.MappingName = "index_id"
        Me.csStandardIndexID.ReadOnly = True
        Me.csStandardIndexID.Width = 60
        '
        'csStandardSerialID
        '
        Me.csStandardSerialID.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.csStandardSerialID.Format = ""
        Me.csStandardSerialID.FormatInfo = Nothing
        Me.csStandardSerialID.HeaderText = "序  号"
        Me.csStandardSerialID.MappingName = "serial_num"
        Me.csStandardSerialID.Width = 60
        '
        'csStandardScore
        '
        Me.csStandardScore.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.csStandardScore.Format = ""
        Me.csStandardScore.FormatInfo = Nothing
        Me.csStandardScore.HeaderText = "得  分"
        Me.csStandardScore.MappingName = "score"
        Me.csStandardScore.Width = 60
        '
        'csStandardCondition
        '
        Me.csStandardCondition.Format = ""
        Me.csStandardCondition.FormatInfo = Nothing
        Me.csStandardCondition.HeaderText = "条    件"
        Me.csStandardCondition.MappingName = "condition"
        Me.csStandardCondition.Width = 300
        '
        'FCreditAppraiseQuality
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(632, 413)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnInsert, Me.btnExit, Me.btnDelete, Me.btnRefresh, Me.btnUpdate, Me.txtRemark, Me.lblDate, Me.lblUsed, Me.lblSystemID, Me.cboSystemID})
        Me.DockPadding.Bottom = 40
        Me.DockPadding.Left = 8
        Me.DockPadding.Right = 8
        Me.DockPadding.Top = 40
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FCreditAppraiseQuality"
        Me.Text = "定性分析指标设置"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Overloads Overrides Function RefreshData() As Boolean
        Return Me.RefreshData(Int32.Parse(cboSystemID.Text))
    End Function

    Public Overloads Function RefreshData(ByVal SystemID As Integer) As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            grdMaster.SetDataBinding(gWs.FetchCreditQualityIndex(SystemID, "%", "%"), "TCreditQualityIndex")
            grdDetail.SetDataBinding(gWs.FetchCreditQualityStandard("{system_id=" + SystemID.ToString() + "}"), "TCreditQualityStandard")

            Dim masterManager As CurrencyManager = Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember)
            CType(masterManager.List, DataView).AllowNew = True
            AddHandler masterManager.PositionChanged, AddressOf MasterTable_PositionChanged

            AddHandler CType(grdMaster.DataSource, DataSet).Tables(grdMaster.DataMember).RowDeleted, AddressOf MasterTable_RowDeleted

            CType(grdMaster.DataSource, DataSet).Tables(grdMaster.DataMember).Columns("system_id").DefaultValue = SystemID
            CType(grdDetail.DataSource, DataSet).Tables(grdDetail.DataMember).Columns("system_id").DefaultValue = SystemID

            MyBase.RefreshData()

            '强制刷新从表数据
            MasterTable_PositionChanged(masterManager, EventArgs.Empty)
        Catch ex As System.Exception
            '统一错误处理
            ExceptionHandler.ShowMessageBox(ex)
            Return False
        Finally
            Me.Cursor = Cursors.Default
        End Try

        Return True
    End Function

    Public Overrides Function UpdateData() As Boolean
        Try
            Me.Cursor = Cursors.WaitCursor

            If Not MyBase.UpdateData() Then
                Return False
            End If

            Dim dsMaster As DataSet = grdMaster.DataSource
            Dim dsDetail As DataSet = grdDetail.DataSource

            Dim result As String = "1"

            If (Not dsMaster Is Nothing) AndAlso dsMaster.HasChanges() Then
                result = gWs.UpdateCreditQualityIndex(dsMaster.GetChanges())
            End If
            If (Not dsDetail Is Nothing) AndAlso dsDetail.HasChanges() Then
                result = gWs.UpdateCreditQualityStandard(dsDetail.GetChanges())
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

    Private Sub FCreditAppraiseQuality_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsResult As DataSet = gWs.FetchCreditAppraiseSystem("%")
        cboSystemID.DataSource = dsResult.Tables(0).DefaultView
        cboSystemID.DisplayMember = "system_id"
        cboSystemID.ValueMember = "system_id"

        dsResult = gWs.FetchCreditIndexType(2)
        csIndexIndexType.ColumnComboBox.DataSource = dsResult.Tables("TCreditIndexType").DefaultView
        csIndexIndexType.ColumnComboBox.DisplayMember = "type_name"
        csIndexIndexType.ColumnComboBox.ValueMember = "index_type"

        Me.RefreshData()
    End Sub

    Private Sub cboSystemID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSystemID.SelectedIndexChanged
        Dim systemID As Integer

        lblDate.Text = ""
        lblUsed.Text = ""
        txtRemark.Text = ""

        Try
            systemID = Int32.Parse(cboSystemID.Text)
        Catch
            Return
        End Try

        Dim dsResult As DataSet = gWs.FetchCreditAppraiseSystem(systemID.ToString())

        If dsResult.Tables(0).Rows.Count > 0 Then
            lblDate.Text = String.Format("{0:D}", dsResult.Tables(0).Rows(0)("used_from"))
            txtRemark.Text = dsResult.Tables(0).Rows(0)("remark")

            If (Not dsResult.Tables(0).Rows(0).IsNull("used_flag")) AndAlso CType(dsResult.Tables(0).Rows(0)("used_flag"), Boolean) Then
                lblUsed.Text = "a"
            Else
                lblUsed.Text = "r"
            End If
        End If

        Me.RefreshData()
    End Sub

    Private Sub MasterTable_RowDeleted(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        MasterTable_PositionChanged(sender, EventArgs.Empty)
    End Sub

    Private Sub MasterTable_PositionChanged(ByVal sender As Object, ByVal e As EventArgs)
        If grdMaster.DataSource Is Nothing OrElse grdDetail.DataSource Is Nothing Then
            Return
        End If

        Dim dv As DataView = CType(Me.BindingContext(grdDetail.DataSource, grdDetail.DataMember), CurrencyManager).List
        Dim masterManager As CurrencyManager = Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember)
        If masterManager.Position < 0 Then
            dv.RowFilter = "system_id = NULL"
        Else
            Dim rv As DataRowView = CType(masterManager.Current, DataRowView)
            dv.RowFilter = "system_id = " + rv("system_id").ToString() + " AND index_type = '" + rv("index_type").ToString() + "' AND index_id='" + rv("index_id").ToString() + "'"
            dv.Table.Columns("system_id").DefaultValue = rv.Item("system_id")
            dv.Table.Columns("index_type").DefaultValue = rv.Item("index_type")
            dv.Table.Columns("index_id").DefaultValue = rv.Item("index_id")
        End If
    End Sub

    Protected Overrides Function DeleteMasterConfirm() As DialogResult
        Dim cm As CurrencyManager = Me.BindingContext(grdMaster.DataSource, grdMaster.DataMember)
        If cm.Count <= 0 Then
            Return DialogResult.None
        End If

        Return SWDialogBox.MessageBox.Show("?1004", "［" + CType(cm.Current, DataRowView)("index_name") + "］")
    End Function

    Protected Overrides Function DeleteDetailConfirm() As DialogResult
        Dim cm As CurrencyManager = Me.BindingContext(grdDetail.DataSource, grdDetail.DataMember)
        If cm.Count <= 0 Then
            Return DialogResult.None
        End If

        Return SWDialogBox.MessageBox.Show("?1004", "［" + CType(cm.Current, DataRowView)("condition") + "］")
    End Function
End Class