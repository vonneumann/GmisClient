'登记清偿信息

Public Class FRegisterDischargeInfo
    Inherits frmChargeFeeBase

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
    Friend WithEvents txtAccountType As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cboPayMode As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtAccountType = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboPayMode = New System.Windows.Forms.ComboBox()
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbxResult.SuspendLayout()
        Me.gpbxDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Visible = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.Text = "缴费日期"
        Me.Label3.Visible = True
        '
        'txtCorName
        '
        Me.txtCorName.Visible = True
        '
        'Label6
        '
        Me.Label6.Visible = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 77)
        Me.Label2.Size = New System.Drawing.Size(48, 14)
        Me.Label2.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Visible = True
        '
        'dtpDate
        '
        Me.dtpDate.Value = New Date(2003, 12, 15, 10, 30, 59, 531)
        Me.dtpDate.Visible = True
        '
        'cmbxType
        '
        Me.cmbxType.DropDownWidth = 152
        Me.cmbxType.ItemHeight = 12
        Me.cmbxType.Location = New System.Drawing.Point(248, 13)
        Me.cmbxType.Size = New System.Drawing.Size(152, 20)
        Me.cmbxType.Visible = True
        '
        'dgMoney
        '
        Me.dgMoney.AccessibleName = "DataGrid"
        Me.dgMoney.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgMoney.Size = New System.Drawing.Size(570, 140)
        Me.dgMoney.Visible = True
        '
        'gpbxResult
        '
        Me.gpbxResult.Location = New System.Drawing.Point(8, 56)
        Me.gpbxResult.Size = New System.Drawing.Size(576, 160)
        Me.gpbxResult.Visible = True
        '
        'txtSummary
        '
        Me.txtSummary.Location = New System.Drawing.Point(64, 64)
        Me.txtSummary.TabIndex = 5
        Me.txtSummary.Visible = True
        '
        'lblFeeType
        '
        Me.lblFeeType.AutoSize = True
        Me.lblFeeType.Size = New System.Drawing.Size(60, 14)
        Me.lblFeeType.Text = "科     目"
        Me.lblFeeType.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(416, 336)
        Me.btnCommit.TabIndex = 10
        Me.btnCommit.Visible = True
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(248, 38)
        Me.txtIncome.Size = New System.Drawing.Size(152, 21)
        Me.txtIncome.TabIndex = 4
        Me.txtIncome.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(328, 336)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Visible = True
        '
        'gpbxDetail
        '
        Me.gpbxDetail.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboPayMode, Me.Label7})
        Me.gpbxDetail.Location = New System.Drawing.Point(8, 216)
        Me.gpbxDetail.Size = New System.Drawing.Size(576, 112)
        Me.gpbxDetail.Visible = True
        '
        'btnModify
        '
        Me.btnModify.Location = New System.Drawing.Point(152, 336)
        Me.btnModify.TabIndex = 7
        Me.btnModify.Visible = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(184, 43)
        Me.Label1.Size = New System.Drawing.Size(60, 14)
        Me.Label1.Text = "金 额(元)"
        Me.Label1.Visible = True
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(64, 336)
        Me.btnNew.TabIndex = 6
        Me.btnNew.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(240, 336)
        Me.btnDelete.TabIndex = 8
        Me.btnDelete.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(504, 336)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Visible = True
        '
        'txtAccountType
        '
        Me.txtAccountType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtAccountType.Location = New System.Drawing.Point(72, 32)
        Me.txtAccountType.Name = "txtAccountType"
        Me.txtAccountType.ReadOnly = True
        Me.txtAccountType.Size = New System.Drawing.Size(96, 21)
        Me.txtAccountType.TabIndex = 36
        Me.txtAccountType.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "科    目"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 14)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "付款方式"
        '
        'cboPayMode
        '
        Me.cboPayMode.Enabled = False
        Me.cboPayMode.Items.AddRange(New Object() {"银行转帐", "现金收讫", "银行收讫", "银行托收", "支票收讫"})
        Me.cboPayMode.Location = New System.Drawing.Point(64, 39)
        Me.cboPayMode.MaxLength = 10
        Me.cboPayMode.Name = "cboPayMode"
        Me.cboPayMode.Size = New System.Drawing.Size(112, 20)
        Me.cboPayMode.TabIndex = 3
        '
        'FRegisterDischargeInfo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(596, 367)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtAccountType, Me.Label4, Me.btnCommit, Me.btnNew, Me.btnModify, Me.btnDelete, Me.btnSave, Me.gpbxDetail, Me.txtCorName, Me.txtProjectCode, Me.Label5, Me.Label6, Me.gpbxResult, Me.btnExit})
        Me.Name = "FRegisterDischargeInfo"
        Me.Text = "登记追偿信息"
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbxResult.ResumeLayout(False)
        Me.gpbxDetail.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    '初始化帐目处理
    Private Sub initializeAccountHandle()
        dsAccountDetail = New DataSet()
        GetDataSource()
        bmAccount = BindingContext(dsAccountDetail, "project_account_detail")
        dgMoney.DataMember = "project_account_detail"
        dgMoney.DataSource = dsAccountDetail
        dgMoney.TableStyles.Add(addTableStyle)
        cmbxType.DataSource = dsItem.Tables("TItem")
        cmbxType.DisplayMember = "item_name"
        cmbxType.ValueMember = "item_code"
        'If dgMoney.CurrentRowIndex >= 0 Then
        '    cmbxType.SelectedValue = CStr(dgMoney.Item(dgMoney.CurrentRowIndex, 4)).Trim
        'End If
        txtAccountType.DataBindings.Add("Text", cmbxType.DataSource, "item_name")
    End Sub
    Protected Overrides Sub SetObjEnabled(ByVal IsEnabled As Boolean)
        MyBase.SetObjEnabled(IsEnabled)
        cboPayMode.Enabled = IsEnabled
        If IsEnabled Then
            CType(MyBase.bmAccount.Current, DataRowView)("type") = cboPayMode.Items(0).ToString
            'cboPayMode.Text = cboPayMode.Items(0).ToString
        End If
    End Sub

    'Protected Overrides Sub IniBindingForAccount()
    '    MyBase.IniBindingForAccount()
    '    cboMoneyType.DataBindings.Clear()
    '    cboMoneyType.DataBindings.Add(New Binding("Text", dsAccountDetail, "project_account_detail.type")) 'SelectedItem
    'End Sub
    Private Sub FRegisterDischargeInfo_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            txtCorName.Text = CorporationName : txtProjectCode.Text = ProjectCode
            MyBase.item_type = "35" : MyBase.IsRegisterDischargeInfo = True

            SystemDate = gWs.GetSysTime
            initializeAccountHandle()
            btnNew.Focus()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    Protected Overrides Sub IniBindingForAccount()
        Dim moneybind As Binding = New Binding("Text", dsAccountDetail, "project_account_detail.payout")
        txtIncome.DataBindings.Add(moneybind)
        AddHandler moneybind.Format, AddressOf money_format
        dtpDate.DataBindings.Add(New Binding("Value", dsAccountDetail, "project_account_detail.date"))
        txtSummary.DataBindings.Add(New Binding("Text", dsAccountDetail, "project_account_detail.remark")) '备注
        cmbxType.DataBindings.Add(New Binding("SelectedValue", dsAccountDetail, "project_account_detail.item_code"))    '科目
        cboPayMode.DataBindings.Clear() '付费方式
        cboPayMode.DataBindings.Add(New Binding("Text", dsAccountDetail, "project_account_detail.type")) 'SelectedItem
        HasBinded = True
    End Sub
    Protected Overrides Function addTableStyle() As DataGridTableStyle
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "project_account_detail"
        dgts.AllowSorting = False
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 0
        col7.MappingName = "serial_num"
        col7.Width = 0
        dgts.GridColumnStyles.Add(col7)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1
        col3.MappingName = "date"
        col3.HeaderText = "缴费日期 "
        col3.Width = 80
        col3.Format = "yyyy-MM-dd"
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col8.MappingName = "type"
        col8.HeaderText = "付款方式"
        col8.NullText = String.Empty
        col8.Width = 80
        dgts.GridColumnStyles.Add(col8)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  3
        col4.MappingName = "payout"
        col4.HeaderText = " 金   额(元)"
        col4.Alignment = HorizontalAlignment.Right
        col4.Width = 100
        col4.NullText = String.Empty
        col4.Format = "n"
        dgts.GridColumnStyles.Add(col4)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col5.MappingName = "remark"
        col5.HeaderText = " 摘  要"
        col5.Alignment = HorizontalAlignment.Left
        col5.Width = 360
        col5.NullText = String.Empty
        dgts.GridColumnStyles.Add(col5)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col6.MappingName = "item_code"
        col6.Width = 0
        dgts.GridColumnStyles.Add(col6)
        Return dgts
    End Function
End Class
