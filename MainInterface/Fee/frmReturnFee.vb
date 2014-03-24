'作者：罗庆锋；日期2003-04-05
'还款，逾期还款，代偿还款
Public Class frmReturnFee
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
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents btnReloan As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmReturnFee))
        Me.cboMoneyType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtLoanSum = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.btnReloan = New System.Windows.Forms.Button
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbxDetail.SuspendLayout()
        Me.gpbxResult.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.Text = "企 业 名 称 "
        '
        'dgMoney
        '
        Me.dgMoney.AccessibleName = "DataGrid"
        Me.dgMoney.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgMoney.Name = "dgMoney"
        Me.dgMoney.Size = New System.Drawing.Size(620, 180)
        '
        'btnCommit
        '
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Image)
        Me.btnCommit.ImageIndex = -1
        Me.btnCommit.ImageList = Nothing
        Me.btnCommit.Location = New System.Drawing.Point(459, 352)
        Me.btnCommit.Name = "btnCommit"
        '
        'cmbxType
        '
        Me.cmbxType.DropDownWidth = 72
        Me.cmbxType.ItemHeight = 12
        Me.cmbxType.Location = New System.Drawing.Point(648, 16)
        Me.cmbxType.Name = "cmbxType"
        Me.cmbxType.Size = New System.Drawing.Size(72, 20)
        '
        'Label3
        '
        Me.Label3.Name = "Label3"
        Me.Label3.Text = "还款日期"
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageIndex = -1
        Me.btnSave.ImageList = Nothing
        Me.btnSave.Location = New System.Drawing.Point(373, 352)
        Me.btnSave.Name = "btnSave"
        '
        'gpbxDetail
        '
        Me.gpbxDetail.Controls.Add(Me.Label4)
        Me.gpbxDetail.Controls.Add(Me.cboMoneyType)
        Me.gpbxDetail.Name = "gpbxDetail"
        Me.gpbxDetail.Size = New System.Drawing.Size(626, 88)
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
        'btnModify
        '
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.ImageIndex = -1
        Me.btnModify.ImageList = Nothing
        Me.btnModify.Location = New System.Drawing.Point(201, 352)
        Me.btnModify.Name = "btnModify"
        '
        'txtCorName
        '
        Me.txtCorName.Location = New System.Drawing.Point(264, 7)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.Size = New System.Drawing.Size(322, 21)
        '
        'Label2
        '
        Me.Label2.Name = "Label2"
        '
        'txtIncome
        '
        Me.txtIncome.Name = "txtIncome"
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageIndex = -1
        Me.btnDelete.ImageList = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(287, 352)
        Me.btnDelete.Name = "btnDelete"
        '
        'lblFeeType
        '
        Me.lblFeeType.Location = New System.Drawing.Point(592, 16)
        Me.lblFeeType.Name = "lblFeeType"
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageIndex = -1
        Me.btnNew.ImageList = Nothing
        Me.btnNew.Location = New System.Drawing.Point(115, 352)
        Me.btnNew.Name = "btnNew"
        '
        'txtSummary
        '
        Me.txtSummary.Name = "txtSummary"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.Text = "还款金额(元)"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(104, 7)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(64, 21)
        '
        'gpbxResult
        '
        Me.gpbxResult.Location = New System.Drawing.Point(8, 56)
        Me.gpbxResult.Name = "gpbxResult"
        Me.gpbxResult.Size = New System.Drawing.Size(626, 200)
        '
        'Label6
        '
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 17)
        Me.Label6.Text = "项  目  编 码"
        '
        'dtpDate
        '
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Value = New Date(2003, 4, 7, 20, 2, 14, 546)
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(545, 352)
        Me.btnExit.Name = "btnExit"
        '
        'cboMoneyType
        '
        Me.cboMoneyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMoneyType.Enabled = False
        Me.cboMoneyType.Items.AddRange(New Object() {"还款"})
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
        Me.Label4.Size = New System.Drawing.Size(54, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Tag = ""
        Me.Label4.Text = "类    型"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(91, 17)
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
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(184, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 17)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "差    额(元)"
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.SystemColors.Window
        Me.txtBalance.ForeColor = System.Drawing.Color.Red
        Me.txtBalance.Location = New System.Drawing.Point(264, 32)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(80, 21)
        Me.txtBalance.TabIndex = 27
        Me.txtBalance.Text = "0"
        '
        'btnReloan
        '
        Me.btnReloan.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnReloan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReloan.ImageIndex = 7
        Me.btnReloan.ImageList = Me.ImageListBasic
        Me.btnReloan.Location = New System.Drawing.Point(13, 352)
        Me.btnReloan.Name = "btnReloan"
        Me.btnReloan.Size = New System.Drawing.Size(93, 23)
        Me.btnReloan.TabIndex = 30
        Me.btnReloan.Text = "再次放款(&A)"
        Me.btnReloan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmReturnFee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(642, 383)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtLoanSum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnReloan)
        Me.Name = "frmReturnFee"
        Me.Text = "还款登记"
        Me.Controls.SetChildIndex(Me.btnReloan, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.txtLoanSum, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.txtBalance, 0)
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
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbxDetail.ResumeLayout(False)
        Me.gpbxResult.ResumeLayout(False)
        Me.ResumeLayout(False)

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
        txtBalance.Text = LessMoney.ToString("n")
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
        txtBalance.Text = LessMoney.ToString("n")
    End Sub

    Private Sub frmReturnFee_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        txtCorName.Text = CorporationName : txtProjectCode.Text = ProjectCode
        IsReturnFee = True
        item_type = "34" : item_code = "001"

        SystemDate = gWs.GetSysTime
        dtpDate.Value = systemdate.Date
        initializeAccountHandle()
        lblFeeType.Visible = False : cmbxType.Visible = False
        btnNew.Focus()

        '设置再次放款按钮可用性
        'yjf add 2007-7-11 add 
        Dim strSql As String = "select loan_sum ,GuaranteeSum,LoanType from viewprojectinfo where ProjectCode='" & ProjectCode & "'"
        Dim dsProject As DataSet = gWs.GetCommonQueryInfo(strSql)

        'Dim dsProject As DataSet = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & Me.ProjectCode & "'}")
        If dsProject.Tables(0).Rows.Count > 0 Then
            Dim dr As DataRow = dsProject.Tables(0).Rows(0)
            Me.btnReloan.Enabled = (CDbl(dr("loan_sum") + "0") < CDbl(dr("GuaranteeSum") + "0")) And CStr(dr("LoanType") & "") = "多次放款"
        End If
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

    Private Sub btnReloan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReloan.Click
        If SWDialogBox.MessageBox.Show("?1000", "再次放款") = DialogResult.Yes Then
            Dim result As String = gWs.ReLoanApplication(ProjectCode)
            If result = "1" Then
                SWDialogBox.MessageBox.Show("$OperateSucceed")
            End If
        End If
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
        col3.HeaderText = "   还款日期"
        col3.Width = 80
        col3.Format = "yyyy-MM-dd"
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2 
        col2.MappingName = "income"
        col2.HeaderText = "还款金额(元)"
        col2.Alignment = HorizontalAlignment.Right
        col2.NullText = String.Empty
        col2.Width = 100
        col2.Format = "c"
        col2.FormatInfo = CGFormatInfo
        dgts.GridColumnStyles.Add(col2)
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col1.MappingName = "total_sum"
        col1.HeaderText = "累计还款金额(元)"
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
