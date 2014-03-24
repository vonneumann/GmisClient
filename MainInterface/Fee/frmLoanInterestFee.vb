Public Class frmLoanInterestFee
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
    Friend WithEvents cboMoneyType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtLoanSum As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLoanInterestFee))
        Me.cboMoneyType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtLoanSum = New System.Windows.Forms.TextBox
        Me.gpbxResult.SuspendLayout()
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbxDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbxResult
        '
        Me.gpbxResult.Location = New System.Drawing.Point(8, 56)
        Me.gpbxResult.Size = New System.Drawing.Size(577, 200)
        '
        'dgMoney
        '
        Me.dgMoney.AccessibleName = "DataGrid"
        Me.dgMoney.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgMoney.Size = New System.Drawing.Size(571, 180)
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageIndex = -1
        Me.btnNew.ImageList = Nothing
        Me.btnNew.Location = New System.Drawing.Point(36, 352)
        '
        'btnModify
        '
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.ImageIndex = -1
        Me.btnModify.ImageList = Nothing
        Me.btnModify.Location = New System.Drawing.Point(122, 352)
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageIndex = -1
        Me.btnDelete.ImageList = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(208, 352)
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageIndex = -1
        Me.btnSave.ImageList = Nothing
        Me.btnSave.Location = New System.Drawing.Point(294, 352)
        '
        'txtCorName
        '
        Me.txtCorName.Location = New System.Drawing.Point(264, 7)
        Me.txtCorName.Size = New System.Drawing.Size(273, 21)
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(104, 7)
        Me.txtProjectCode.Size = New System.Drawing.Size(64, 21)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Size = New System.Drawing.Size(77, 12)
        '
        'lblFeeType
        '
        Me.lblFeeType.Location = New System.Drawing.Point(592, 16)
        '
        'btnCommit
        '
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Image)
        Me.btnCommit.ImageIndex = -1
        Me.btnCommit.ImageList = Nothing
        Me.btnCommit.Location = New System.Drawing.Point(380, 352)
        '
        'dtpDate
        '
        Me.dtpDate.Value = New Date(2003, 4, 7, 20, 2, 14, 546)
        '
        'cmbxType
        '
        Me.cmbxType.DropDownWidth = 72
        Me.cmbxType.ItemHeight = 12
        Me.cmbxType.Location = New System.Drawing.Point(648, 16)
        Me.cmbxType.Size = New System.Drawing.Size(72, 20)
        '
        'gpbxDetail
        '
        Me.gpbxDetail.Controls.Add(Me.Label4)
        Me.gpbxDetail.Controls.Add(Me.cboMoneyType)
        Me.gpbxDetail.Size = New System.Drawing.Size(577, 88)
        Me.gpbxDetail.Controls.SetChildIndex(Me.cboMoneyType, 0)
        Me.gpbxDetail.Controls.SetChildIndex(Me.Label4, 0)
        Me.gpbxDetail.Controls.SetChildIndex(Me.txtSummary, 0)
        Me.gpbxDetail.Controls.SetChildIndex(Me.Label3, 0)
        Me.gpbxDetail.Controls.SetChildIndex(Me.lblFeeType, 0)
        Me.gpbxDetail.Controls.SetChildIndex(Me.Label2, 0)
        Me.gpbxDetail.Controls.SetChildIndex(Me.cmbxType, 0)
        Me.gpbxDetail.Controls.SetChildIndex(Me.dtpDate, 0)
        Me.gpbxDetail.Controls.SetChildIndex(Me.txtIncome, 0)
        Me.gpbxDetail.Controls.SetChildIndex(Me.Label1, 0)
        '
        'Label5
        '
        Me.Label5.Size = New System.Drawing.Size(77, 12)
        Me.Label5.Text = "企 业 名 称 "
        '
        'Label6
        '
        Me.Label6.Size = New System.Drawing.Size(83, 12)
        Me.Label6.Text = "项  目  编 码"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(466, 352)
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
        'cboMoneyType
        '
        Me.cboMoneyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneyType.Enabled = False
        Me.cboMoneyType.Items.AddRange(New Object() {"委贷利息"})
        Me.cboMoneyType.Location = New System.Drawing.Point(248, 13)
        Me.cboMoneyType.MaxLength = 10
        Me.cboMoneyType.Name = "cboMoneyType"
        Me.cboMoneyType.Size = New System.Drawing.Size(96, 20)
        Me.cboMoneyType.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 11
        Me.Label4.Tag = ""
        Me.Label4.Text = "类    型"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 12)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "放款金额(万元)"
        '
        'txtLoanSum
        '
        Me.txtLoanSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanSum.Location = New System.Drawing.Point(104, 32)
        Me.txtLoanSum.Name = "txtLoanSum"
        Me.txtLoanSum.ReadOnly = True
        Me.txtLoanSum.Size = New System.Drawing.Size(64, 21)
        Me.txtLoanSum.TabIndex = 25
        Me.txtLoanSum.Text = "0"
        '
        'frmLoanInterestFee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(593, 383)
        Me.Controls.Add(Me.txtLoanSum)
        Me.Controls.Add(Me.Label7)
        Me.Name = "frmLoanInterestFee"
        Me.Text = "收取委贷利息"
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txtLoanSum, 0)
        Me.Controls.SetChildIndex(Me.gpbxResult, 0)
        Me.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.Controls.SetChildIndex(Me.txtCorName, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnDelete, 0)
        Me.Controls.SetChildIndex(Me.btnModify, 0)
        Me.Controls.SetChildIndex(Me.btnNew, 0)
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.gpbxDetail, 0)
        Me.Controls.SetChildIndex(Me.Label6, 0)
        Me.Controls.SetChildIndex(Me.Label5, 0)
        Me.gpbxResult.ResumeLayout(False)
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbxDetail.ResumeLayout(False)
        Me.gpbxDetail.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Private dsProInfo As DataSet
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
        Dim dsProject As DataSet = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
        If dsProject.Tables(0).Rows.Count > 0 Then
            txtLoanSum.Text = dsProject.Tables(0).Rows(0)("loan_sum") & ""
        Else
            txtLoanSum.Text = "0"
        End If
        dsProject.Dispose()
        RemoveSomeRecord()
    End Sub

    Protected Overrides Function RemoveSomeRecord() As Double
        Dim returnSum As Double = 0
        Dim dr As DataRow
        With dsAccountDetail.Tables("project_account_detail")
            For Each dr In .Rows
                If Not IsDBNull(dr("income")) Then  '
                    returnSum += CDbl(dr("income"))
                End If
            Next
        End With
        LessMoney = CDbl(txtLoanSum.Text) * 10000 - returnSum
        'txtBalance.Text = LessMoney.ToString("n")
        Return LessMoney
    End Function

    Protected Overrides Sub DeleteRefresh(ByVal sender As Object, ByVal e As EventArgs)
        MyBase.DeleteRefresh(sender, e)
        Dim returnSum As Double = 0
        Dim dr As DataRow
        With dsAccountDetail.Tables("project_account_detail")
            For Each dr In .Rows
                If Not IsDBNull(dr("income")) Then  '
                    returnSum += CDbl(dr("income"))
                End If
            Next
        End With
        LessMoney = CDbl(txtLoanSum.Text) * 10000 - returnSum
        'txtBalance.Text = LessMoney.ToString("n")
    End Sub

    Private Sub frmReturnFee_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        txtCorName.Text = CorporationName : txtProjectCode.Text = ProjectCode
        IsLoanInterestFee = True
        item_type = "34" : item_code = "010"

        SystemDate = gWs.GetSysTime
        dtpDate.Value = SystemDate.Date
        initializeAccountHandle()
        lblFeeType.Visible = False : cmbxType.Visible = False
        btnNew.Focus()

        ''设置再次放款按钮可用性
        ''yjf add 2007-7-11 add 
        'Dim strSql As String = "select loan_sum ,GuaranteeSum,LoanType from viewprojectinfo where ProjectCode='" & ProjectCode & "'"
        'Dim dsProject As DataSet = gWs.GetCommonQueryInfo(strSql)

        'Dim dsProject As DataSet = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & Me.ProjectCode & "'}")
        'If dsProject.Tables(0).Rows.Count > 0 Then
        '    Dim dr As DataRow = dsProject.Tables(0).Rows(0)
        '    Me.btnReloan.Enabled = (CDbl(dr("loan_sum") + "0") < CDbl(dr("GuaranteeSum") + "0")) And CStr(dr("LoanType") & "") = "多次放款"
        'End If
    End Sub

    Protected Overrides Sub SetObjEnabled(ByVal IsEnabled As Boolean)
        MyBase.SetObjEnabled(IsEnabled)
        cboMoneyType.Enabled = IsEnabled
        If IsEnabled Then
            cboMoneyType.SelectedIndex = 0
        End If
    End Sub

    Protected Overrides Sub IniBindingForAccount()
        MyBase.IniBindingForAccount()
        cboMoneyType.DataBindings.Clear()
        cboMoneyType.DataBindings.Add(New Binding("SelectedItem", dsAccountDetail, "project_account_detail.type"))
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
        col3.HeaderText = "收取日期"
        col3.Width = 80
        col3.Format = "yyyy-MM-dd"
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2 
        col2.MappingName = "income"
        col2.HeaderText = "收取金额(元)"
        col2.Alignment = HorizontalAlignment.Right
        col2.NullText = String.Empty
        col2.Width = 100
        col2.Format = "c"
        col2.FormatInfo = CGFormatInfo
        dgts.GridColumnStyles.Add(col2)
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "total_sum"
        col1.HeaderText = "累计委贷利息(元)"
        col1.Alignment = HorizontalAlignment.Right
        col1.NullText = ""
        col1.Width = 110
        col1.Format = "c" : col1.FormatInfo = CGFormatInfo
        dgts.GridColumnStyles.Add(col1)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col6.MappingName = "item_code"
        col6.Width = 0
        dgts.GridColumnStyles.Add(col6)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col5.MappingName = "remark"
        col5.HeaderText = "  摘要"
        col5.Alignment = HorizontalAlignment.Left
        col5.Width = 360
        col5.NullText = String.Empty
        dgts.GridColumnStyles.Add(col5)
        Return dgts
    End Function
End Class
