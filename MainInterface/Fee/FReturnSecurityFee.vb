Public Class FReturnSecurityFee
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtShouldReturn As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.txtShouldReturn = New System.Windows.Forms.TextBox()
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbxResult.SuspendLayout()
        Me.gpbxDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(192, 10)
        Me.Label5.Size = New System.Drawing.Size(72, 14)
        Me.Label5.Text = "企 业 名 称"
        Me.Label5.Visible = True
        '
        'Label3
        '
        Me.Label3.Text = "退还日期"
        Me.Label3.Visible = True
        '
        'dtpDate
        '
        Me.dtpDate.Value = New Date(2003, 12, 8, 9, 38, 9, 171)
        Me.dtpDate.Visible = True
        '
        'dgMoney
        '
        Me.dgMoney.AccessibleName = "DataGrid"
        Me.dgMoney.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgMoney.Size = New System.Drawing.Size(570, 180)
        Me.dgMoney.Visible = True
        '
        'Label6
        '
        Me.Label6.Size = New System.Drawing.Size(72, 14)
        Me.Label6.Text = "项 目 编 码"
        Me.Label6.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'cmbxType
        '
        Me.cmbxType.DropDownWidth = 56
        Me.cmbxType.ItemHeight = 12
        Me.cmbxType.Location = New System.Drawing.Point(512, 13)
        Me.cmbxType.Size = New System.Drawing.Size(56, 20)
        Me.cmbxType.Visible = True
        '
        'gpbxResult
        '
        Me.gpbxResult.Location = New System.Drawing.Point(8, 56)
        Me.gpbxResult.Size = New System.Drawing.Size(576, 200)
        Me.gpbxResult.Visible = True
        '
        'txtSummary
        '
        Me.txtSummary.Visible = True
        '
        'lblFeeType
        '
        Me.lblFeeType.Location = New System.Drawing.Point(456, 16)
        Me.lblFeeType.Visible = True
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(280, 13)
        Me.txtIncome.Visible = True
        '
        'gpbxDetail
        '
        Me.gpbxDetail.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Visible = True
        '
        'txtCorName
        '
        Me.txtCorName.Location = New System.Drawing.Point(272, 8)
        Me.txtCorName.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(192, 16)
        Me.Label1.Text = "退还金额(元)"
        Me.Label1.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(96, 8)
        Me.txtProjectCode.Size = New System.Drawing.Size(88, 21)
        Me.txtProjectCode.Visible = True
        '
        'btnNew
        '
        Me.btnNew.Visible = True
        '
        'btnModify
        '
        Me.btnModify.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Visible = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(192, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 14)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "差      额"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 14)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "退还金额(元)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBalance.ForeColor = System.Drawing.Color.Red
        Me.txtBalance.Location = New System.Drawing.Point(272, 32)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(88, 21)
        Me.txtBalance.TabIndex = 37
        Me.txtBalance.Text = ""
        '
        'txtShouldReturn
        '
        Me.txtShouldReturn.BackColor = System.Drawing.Color.Gainsboro
        Me.txtShouldReturn.Enabled = False
        Me.txtShouldReturn.Location = New System.Drawing.Point(96, 32)
        Me.txtShouldReturn.Name = "txtShouldReturn"
        Me.txtShouldReturn.Size = New System.Drawing.Size(88, 21)
        Me.txtShouldReturn.TabIndex = 35
        Me.txtShouldReturn.Text = ""
        '
        'FReturnSecurityFee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 383)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label8, Me.Label7, Me.txtBalance, Me.txtShouldReturn, Me.btnExit, Me.btnCommit, Me.btnNew, Me.btnModify, Me.btnDelete, Me.btnSave, Me.gpbxDetail, Me.txtCorName, Me.txtProjectCode, Me.Label5, Me.Label6, Me.gpbxResult})
        Me.Name = "FReturnSecurityFee"
        Me.Text = "退还保证金"
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
        'IniBindingForAccount()
        bmAccount = BindingContext(dsAccountDetail, "project_account_detail")
        dgMoney.DataMember = "project_account_detail"
        dgMoney.DataSource = dsAccountDetail
        dgMoney.TableStyles.Add(addTableStyle)
        cmbxType.DataSource = dsItem.Tables("TItem")
        cmbxType.DisplayMember = "item_name"
        cmbxType.ValueMember = "item_code"
        txtShouldReturn.Text = RemoveSomeRecord().ToString("n")
        btnDelete.Enabled = (dgMoney.CurrentRowIndex >= 0)
        btnModify.Enabled = btnDelete.Enabled
    End Sub
    '改变金额输入框的绑定属性为payout
    Protected Overrides Sub IniBindingForAccount()
        Dim moneybind As Binding = New Binding("Text", dsAccountDetail, "project_account_detail.payout")
        txtIncome.DataBindings.Add(moneybind)
        AddHandler moneybind.Format, AddressOf money_format
        dtpDate.DataBindings.Add(New Binding("Value", dsAccountDetail, "project_account_detail.date"))
        txtSummary.DataBindings.Add(New Binding("Text", dsAccountDetail, "project_account_detail.remark"))
        cmbxType.DataBindings.Add(New Binding("SelectedValue", dsAccountDetail, "project_account_detail.item_code"))
        HasBinded = True
    End Sub

    '删掉income不为零的记录
    Protected Overrides Function RemoveSomeRecord() As Double
        Dim payoutSum As Double = 0
        Dim incomeSum As Double = 0
        Dim dr As DataRow

        For Each dr In dsAccountDetail.Tables("project_account_detail").Rows
            If Not IsDBNull(dr("payout")) Then  '
                payoutSum += CDbl(dr("payout"))
            End If
            If Not IsDBNull(dr("income")) Then  '
                incomeSum += CDbl(dr("income"))
                dr.Delete()
            End If
        Next
        If dsAccountDetail.HasChanges Then
            dsAccountDetail.AcceptChanges()
        End If

        LessMoney = incomeSum - payoutSum
        txtBalance.Text = LessMoney.ToString("n")
        Return incomeSum
    End Function

    Protected Overrides Sub DeleteRefresh(ByVal sender As Object, ByVal e As EventArgs)
        MyBase.DeleteRefresh(sender, e)
        Dim payoutSum As Double = 0
        Dim dr As DataRow
        For Each dr In dsAccountDetail.Tables("project_account_detail").Rows
            If Not IsDBNull(dr("payout")) Then  '
                payoutSum += CDbl(dr("payout"))
            End If
        Next
        LessMoney = CDbl(txtShouldReturn.Text) - payoutSum
        txtBalance.Text = LessMoney.ToString("n")
    End Sub

    Private Sub FReturnGuaranteeFee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            txtCorName.Text = CorporationName : txtProjectCode.Text = ProjectCode
            IsReturnSecurityFee = True
            item_type = "34" : item_code = "009"

            SystemDate = gWs.GetSysTime
            dtpDate.Value = systemdate.Date
            initializeAccountHandle()

            lblFeeType.Visible = False : cmbxType.Visible = False
            ''''取得项目经理
            'Dim dsMan As DataSet = New DataSet()
            'dsMan = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
            'txtManager.Text = dsMan.Tables(0).Rows(0)("24")

            btnNew.Focus()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
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
        col3.HeaderText = "   退还日期 "
        col3.Width = 80
        col3.Format = "yyyy-MM-dd"
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  3
        col4.MappingName = "payout"
        col4.HeaderText = "退还金额(元) "
        col4.Alignment = HorizontalAlignment.Right
        col4.Width = 100
        col4.NullText = "0"
        col4.Format = "n"
        dgts.GridColumnStyles.Add(col4)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col5.MappingName = "remark"
        col5.HeaderText = "  摘要"
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
