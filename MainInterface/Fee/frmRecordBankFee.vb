Public Class frmRecordBankFee
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
    Friend WithEvents txtHaveCharged As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecordBankFee))
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.txtHaveCharged = New System.Windows.Forms.TextBox
        Me.gpbxResult.SuspendLayout()
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbxDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbxResult
        '
        Me.gpbxResult.Location = New System.Drawing.Point(8, 56)
        Me.gpbxResult.Size = New System.Drawing.Size(576, 200)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Size = New System.Drawing.Size(47, 12)
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.Text = "登记日期"
        '
        'dgMoney
        '
        Me.dgMoney.AccessibleName = "DataGrid"
        Me.dgMoney.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgMoney.Size = New System.Drawing.Size(570, 180)
        '
        'txtCorName
        '
        Me.txtCorName.Location = New System.Drawing.Point(272, 8)
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(96, 8)
        Me.txtProjectCode.Size = New System.Drawing.Size(80, 21)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(192, 16)
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        Me.Label1.Text = "登记金额(元)"
        '
        'lblFeeType
        '
        Me.lblFeeType.Location = New System.Drawing.Point(456, 16)
        '
        'dtpDate
        '
        Me.dtpDate.Value = New Date(2004, 2, 27, 18, 52, 21, 828)
        '
        'cmbxType
        '
        Me.cmbxType.DropDownWidth = 56
        Me.cmbxType.ItemHeight = 12
        Me.cmbxType.Location = New System.Drawing.Point(512, 13)
        Me.cmbxType.Size = New System.Drawing.Size(56, 20)
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(280, 13)
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(192, 10)
        Me.Label5.Size = New System.Drawing.Size(71, 12)
        Me.Label5.Text = "企 业 名 称"
        '
        'Label6
        '
        Me.Label6.Size = New System.Drawing.Size(71, 12)
        Me.Label6.Text = "项 目 编 码"
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.Images.SetKeyName(0, "")
        Me.ImageListBasic.Images.SetKeyName(1, "")
        Me.ImageListBasic.Images.SetKeyName(2, "")
        Me.ImageListBasic.Images.SetKeyName(3, "")
        Me.ImageListBasic.Images.SetKeyName(4, "")
        Me.ImageListBasic.Images.SetKeyName(5, "")
        Me.ImageListBasic.Images.SetKeyName(6, "")
        Me.ImageListBasic.Images.SetKeyName(7, "")
        Me.ImageListBasic.Images.SetKeyName(8, "")
        Me.ImageListBasic.Images.SetKeyName(9, "")
        Me.ImageListBasic.Images.SetKeyName(10, "")
        Me.ImageListBasic.Images.SetKeyName(11, "")
        Me.ImageListBasic.Images.SetKeyName(12, "")
        Me.ImageListBasic.Images.SetKeyName(13, "")
        Me.ImageListBasic.Images.SetKeyName(14, "")
        Me.ImageListBasic.Images.SetKeyName(15, "")
        Me.ImageListBasic.Images.SetKeyName(16, "")
        Me.ImageListBasic.Images.SetKeyName(17, "")
        Me.ImageListBasic.Images.SetKeyName(18, "")
        Me.ImageListBasic.Images.SetKeyName(19, "")
        Me.ImageListBasic.Images.SetKeyName(20, "")
        Me.ImageListBasic.Images.SetKeyName(21, "")
        Me.ImageListBasic.Images.SetKeyName(22, "")
        Me.ImageListBasic.Images.SetKeyName(23, "")
        Me.ImageListBasic.Images.SetKeyName(24, "")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(192, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 12)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "差       额"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 12)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "已收保费(元)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label7.Visible = False
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBalance.ForeColor = System.Drawing.Color.Red
        Me.txtBalance.Location = New System.Drawing.Point(272, 32)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(88, 21)
        Me.txtBalance.TabIndex = 41
        Me.txtBalance.Visible = False
        '
        'txtHaveCharged
        '
        Me.txtHaveCharged.BackColor = System.Drawing.Color.Gainsboro
        Me.txtHaveCharged.Location = New System.Drawing.Point(96, 32)
        Me.txtHaveCharged.Name = "txtHaveCharged"
        Me.txtHaveCharged.ReadOnly = True
        Me.txtHaveCharged.Size = New System.Drawing.Size(80, 21)
        Me.txtHaveCharged.TabIndex = 39
        Me.txtHaveCharged.Visible = False
        '
        'frmRecordBankFee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 383)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtHaveCharged)
        Me.Name = "frmRecordBankFee"
        Me.Text = "登记银行费用"
        Me.Controls.SetChildIndex(Me.gpbxResult, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.Controls.SetChildIndex(Me.txtCorName, 0)
        Me.Controls.SetChildIndex(Me.gpbxDetail, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.btnModify, 0)
        Me.Controls.SetChildIndex(Me.btnNew, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.txtHaveCharged, 0)
        Me.Controls.SetChildIndex(Me.txtBalance, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.gpbxResult.ResumeLayout(False)
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbxDetail.ResumeLayout(False)
        Me.gpbxDetail.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
        cmbxType.DataSource = dsItem.Tables("TItem")    '绑定科目类型表
        cmbxType.DisplayMember = "item_name"
        cmbxType.ValueMember = "item_code"
        txtHaveCharged.Text = RemoveSomeRecord().ToString("n")  '显示已收保费
        btnDelete.Enabled = (dgMoney.CurrentRowIndex >= 0)
        btnModify.Enabled = btnDelete.Enabled

        dgMoney.TableStyles.Add(addTableStyle)
    End Sub
    '改变金额输入框的绑定属性为income,提交事件的处理方法，目的是“显示的是正数，保存的是负数”
    Protected Overrides Sub IniBindingForAccount()
        Dim moneybind As Binding = New Binding("Text", dsAccountDetail, "project_account_detail.income")
        txtIncome.DataBindings.Add(moneybind)
        AddHandler moneybind.Format, AddressOf NegativeToPositive
        AddHandler moneybind.Parse, AddressOf PositiveToNegative
        moneybind = Nothing
        dtpDate.DataBindings.Add(New Binding("Value", dsAccountDetail, "project_account_detail.date"))
        txtSummary.DataBindings.Add(New Binding("Text", dsAccountDetail, "project_account_detail.remark"))
        cmbxType.DataBindings.Add(New Binding("SelectedValue", dsAccountDetail, "project_account_detail.item_code"))
        HasBinded = True
    End Sub
    '正数变负数
    Private Sub PositiveToNegative(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If Not IsDBNull(e.Value) Then
            e.Value = CDbl(e.Value) * (-1)
        End If
    End Sub
    '负数变正数
    Private Sub NegativeToPositive(ByVal sender As Object, ByVal e As ConvertEventArgs)
        If Not IsDBNull(e.Value) Then
            e.Value = CDbl(e.Value) * (-1)
        End If
    End Sub
    Protected Overrides Sub AdditionalOperation()
        '删除自增的一列
        'Dim dr As DataRow
        'For Each dr In dsAccountDetail.Tables("project_account_detail").Rows
        '    dr("income") = CDbl(dr("ShowIncome")) * (-1)
        'Next
        'dsAccountDetail.Tables("project_account_detail").Columns.Remove(dsAccountDetail.Tables("project_account_detail").Columns("ShowIncome"))
    End Sub
    '删掉income不为零的记录
    Protected Overrides Function RemoveSomeRecord() As Double
        dsAccountDetail.Tables("project_account_detail").Columns.Add("ShowIncome", GetType(Double), "income * (-1)") '增加一列，显示的"income"   , 
        Dim returnSum As Double = 0
        Dim incomeSum As Double = 0
        Dim dr As DataRow
        Dim i, count As Int32
        count = dsAccountDetail.Tables("project_account_detail").Rows.Count
        For i = count - 1 To 0 Step -1
            dr = dsAccountDetail.Tables("project_account_detail").Rows(i)
            If Not IsDBNull(dr("payout")) Then
                dr.Delete()
            ElseIf Not IsDBNull(dr("income")) Then
                If CDbl(dr("income")) <= 0 Then
                    returnSum += CDbl(dr("income")) * (-1)
                Else
                    incomeSum += CDbl(dr("income")) '如“income”大于0，则为收取的担保费，要删除掉
                    dr.Delete()
                End If
            End If
        Next

        If dsAccountDetail.HasChanges Then
            dsAccountDetail.AcceptChanges()
        End If

        'For Each dr In dsAccountDetail.Tables("project_account_detail").Rows
        '    dr("ShowIncome") = CDbl(dr("income")) * (-1)
        'Next

        LessMoney = incomeSum - returnSum
        txtBalance.Text = LessMoney.ToString("n")
        Return incomeSum
    End Function

    Protected Overrides Sub SetObjEnabled(ByVal IsEnabled As Boolean)
        MyBase.SetObjEnabled(IsEnabled)
        If IsEnabled Then
            txtIncome.Text = LessMoney.ToString("n")
        End If
    End Sub

    Protected Overrides Sub DeleteRefresh(ByVal sender As Object, ByVal e As EventArgs)
        MyBase.DeleteRefresh(sender, e)
        Dim returnSum As Double = 0
        Dim dr As DataRow
        For Each dr In dsAccountDetail.Tables("project_account_detail").Rows
            If Not IsDBNull(dr("income")) Then  '
                returnSum += CDbl(dr("income")) * (-1) '这里的income为负数
            End If
        Next
        LessMoney = CDbl(txtHaveCharged.Text) - returnSum
        txtBalance.Text = LessMoney.ToString("n")
    End Sub

    Private Sub FReturnGuaranteeFee_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            txtCorName.Text = CorporationName : txtProjectCode.Text = ProjectCode
            MyBase.IsBankFee = True
            item_type = "31" : item_code = "005"

            SystemDate = gWs.GetSysTime
            dtpDate.Value = systemdate.Date
            initializeAccountHandle()
            lblFeeType.Visible = False : cmbxType.Visible = False
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
        col3.HeaderText = "登记日期 "
        col3.Width = 80
        col3.Format = "yyyy-MM-dd"
        col3.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col3)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  3
        col4.MappingName = "ShowIncome"
        col4.HeaderText = "登记金额(元) "
        col4.Alignment = HorizontalAlignment.Right
        col4.Width = 100
        col4.NullText = "0"
        col4.Format = "n"
        dgts.GridColumnStyles.Add(col4)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col5.MappingName = "remark"
        col5.HeaderText = "摘  要 "
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
