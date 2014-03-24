

Public Class FChargeFee
    Inherits MainInterface.frmBasic

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsAccount Is Nothing Then
            dsAccount.Dispose()
        End If
        If Not dsItem Is Nothing Then
            dsItem.Dispose()
        End If
        If Not dsWorkLog Is Nothing Then
            dsWorkLog.Dispose()
        End If
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
    Public WithEvents btnNew As System.Windows.Forms.Button
    Public WithEvents btnModify As System.Windows.Forms.Button
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Public WithEvents btnSave As System.Windows.Forms.Button
    Public WithEvents gpbxDetail As System.Windows.Forms.GroupBox
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtIncome As System.Windows.Forms.TextBox
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents lblFeeType As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtSummary As System.Windows.Forms.TextBox
    Protected WithEvents txtCorName As System.Windows.Forms.TextBox
    Protected WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents gpbxResult As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboPayMode As System.Windows.Forms.ComboBox
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Public WithEvents cboType As System.Windows.Forms.ComboBox
    Public WithEvents grdFee As System.Windows.Forms.DataGrid
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtShouldPay As System.Windows.Forms.TextBox
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnReport As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FChargeFee))
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.gpbxDetail = New System.Windows.Forms.GroupBox()
        Me.cboPayMode = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblFeeType = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSummary = New System.Windows.Forms.TextBox()
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gpbxResult = New System.Windows.Forms.GroupBox()
        Me.grdFee = New System.Windows.Forms.DataGrid()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtShouldPay = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.gpbxDetail.SuspendLayout()
        Me.gpbxResult.SuspendLayout()
        CType(Me.grdFee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(478, 320)
        Me.btnExit.Visible = True
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 13
        Me.btnNew.ImageList = Me.ImageListBasic
        Me.btnNew.Location = New System.Drawing.Point(130, 320)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 23)
        Me.btnNew.TabIndex = 24
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnModify
        '
        Me.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModify.Enabled = False
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Bitmap)
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.ImageIndex = 14
        Me.btnModify.ImageList = Me.ImageListBasic
        Me.btnModify.Location = New System.Drawing.Point(217, 320)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(77, 23)
        Me.btnModify.TabIndex = 25
        Me.btnModify.Text = "修 改(&M)"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Enabled = False
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(304, 320)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Enabled = False
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(391, 320)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 27
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpbxDetail
        '
        Me.gpbxDetail.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.gpbxDetail.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboPayMode, Me.Label4, Me.Label1, Me.txtIncome, Me.dtpDate, Me.cboType, Me.Label2, Me.lblFeeType, Me.Label3, Me.txtSummary})
        Me.gpbxDetail.Location = New System.Drawing.Point(10, 200)
        Me.gpbxDetail.Name = "gpbxDetail"
        Me.gpbxDetail.Size = New System.Drawing.Size(576, 112)
        Me.gpbxDetail.TabIndex = 34
        Me.gpbxDetail.TabStop = False
        '
        'cboPayMode
        '
        'Me.cboPayMode.Enabled = False
        Me.cboPayMode.Location = New System.Drawing.Point(64, 39)
        Me.cboPayMode.Name = "cboPayMode"
        Me.cboPayMode.Size = New System.Drawing.Size(112, 20)
        Me.cboPayMode.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "收取方式"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(192, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 14)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "收取金额 (元)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtIncome
        '
        Me.txtIncome.BackColor = System.Drawing.SystemColors.Window
        Me.txtIncome.Enabled = False
        Me.txtIncome.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtIncome.Location = New System.Drawing.Point(280, 39)
        Me.txtIncome.MaxLength = 14
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(112, 21)
        Me.txtIncome.TabIndex = 3
        Me.txtIncome.Text = ""
        '
        'dtpDate
        '
        Me.dtpDate.Enabled = False
        Me.dtpDate.Location = New System.Drawing.Point(280, 13)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpDate.TabIndex = 1
        Me.dtpDate.Value = New Date(2004, 3, 11, 9, 41, 59, 46)
        '
        'cboType
        '
        Me.cboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboType.Location = New System.Drawing.Point(64, 13)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(112, 20)
        Me.cboType.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "摘   要"
        '
        'lblFeeType
        '
        Me.lblFeeType.AutoSize = True
        Me.lblFeeType.Location = New System.Drawing.Point(8, 16)
        Me.lblFeeType.Name = "lblFeeType"
        Me.lblFeeType.Size = New System.Drawing.Size(54, 14)
        Me.lblFeeType.TabIndex = 2
        Me.lblFeeType.Text = "费用类型"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 14)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "收 取 日  期"
        '
        'txtSummary
        '
        Me.txtSummary.BackColor = System.Drawing.SystemColors.Window
        Me.txtSummary.Location = New System.Drawing.Point(64, 64)
        Me.txtSummary.MaxLength = 30
        Me.txtSummary.Multiline = True
        Me.txtSummary.Name = "txtSummary"
        Me.txtSummary.ReadOnly = True
        Me.txtSummary.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSummary.Size = New System.Drawing.Size(504, 40)
        Me.txtSummary.TabIndex = 4
        Me.txtSummary.Text = ""
        '
        'txtCorName
        '
        Me.txtCorName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(296, 8)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(288, 21)
        Me.txtCorName.TabIndex = 33
        Me.txtCorName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(104, 8)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 32
        Me.txtProjectCode.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(232, 11)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "企业名称"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(18, 11)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 14)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "项 目 编 码"
        '
        'gpbxResult
        '
        Me.gpbxResult.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.gpbxResult.Controls.AddRange(New System.Windows.Forms.Control() {Me.grdFee})
        Me.gpbxResult.ForeColor = System.Drawing.Color.Red
        Me.gpbxResult.Location = New System.Drawing.Point(10, 56)
        Me.gpbxResult.Name = "gpbxResult"
        Me.gpbxResult.Size = New System.Drawing.Size(576, 144)
        Me.gpbxResult.TabIndex = 29
        Me.gpbxResult.TabStop = False
        '
        'grdFee
        '
        Me.grdFee.CaptionVisible = False
        Me.grdFee.DataMember = ""
        Me.grdFee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grdFee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdFee.Location = New System.Drawing.Point(3, 17)
        Me.grdFee.Name = "grdFee"
        Me.grdFee.ReadOnly = True
        Me.grdFee.RowHeadersVisible = False
        Me.grdFee.RowHeaderWidth = 0
        Me.grdFee.Size = New System.Drawing.Size(570, 124)
        Me.grdFee.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 14)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "应收金额(元)"
        '
        'txtShouldPay
        '
        Me.txtShouldPay.BackColor = System.Drawing.Color.Gainsboro
        Me.txtShouldPay.Location = New System.Drawing.Point(104, 32)
        Me.txtShouldPay.Name = "txtShouldPay"
        Me.txtShouldPay.ReadOnly = True
        Me.txtShouldPay.Size = New System.Drawing.Size(96, 21)
        Me.txtShouldPay.TabIndex = 36
        Me.txtShouldPay.Text = ""
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBalance.ForeColor = System.Drawing.Color.Red
        Me.txtBalance.Location = New System.Drawing.Point(296, 32)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.TabIndex = 38
        Me.txtBalance.Text = ""
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(296, 32)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.TabIndex = 38
        Me.TextBox2.Text = "TextBox1"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(232, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 14)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "差额(元)"
        '
        'btnReport
        '
        Me.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Bitmap)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.ImageIndex = 23
        Me.btnReport.ImageList = Me.ImageListBasic
        Me.btnReport.Location = New System.Drawing.Point(43, 320)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(77, 23)
        Me.btnReport.TabIndex = 39
        Me.btnReport.Text = "打印(&P)"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FChargeFee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(596, 351)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label7, Me.Label5, Me.Label6, Me.btnExit, Me.Label9, Me.btnReport, Me.txtBalance, Me.txtShouldPay, Me.btnNew, Me.btnModify, Me.btnDelete, Me.btnSave, Me.gpbxDetail, Me.txtCorName, Me.txtProjectCode, Me.gpbxResult, Me.TextBox2})
        Me.Name = "FChargeFee"
        Me.Text = "收取费用"
        Me.gpbxDetail.ResumeLayout(False)
        Me.gpbxResult.ResumeLayout(False)
        CType(Me.grdFee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public MaxChargeFee As Double = 100000000
    Private WorkFlowID, CorporationName, ProjectCode, TaskID As String
    Private dsAccount, dsItem, dsWorkLog As DataSet
    Private cmAccount As CurrencyManager
    Private ItemType() As String = {"31", "31", "34"}
    Private ItemCode() As String = {"001", "002", "009"} '这里必须保证item_code小的在前
    Private balance() As Double = {0, 0, 0} '差额
    Private payout() As Double = {0, 0, 0} '应收金额
    Private taskStatus() As String = {"None", "None", "None"} '收费任务是否启动的“状态”
    Private taskDataRow() As DataRow = {Nothing, Nothing, Nothing} '收费任务DataRow
    Private hasInsertProjectDocument() As Boolean = {False, False, False} '是否已经插入收据
    Private hasCommit() As Boolean = {False, False, False} '是否提交任务
    Private Status As OperationType = Money.OperationType.Empty '当前操作状态
    Private SystemDate As Date
    Private phase As String
    Public Event TaskCommit()

    Private Function ReturnProjectPhase() As String
        If phase Is Nothing Then
            phase = MyBase.getPhase(ProjectCode)
        End If
        Return phase
    End Function

    Private Function GetIndex(ByVal item_type As String, ByVal item_code As String) As Int16
        Dim i As Int16
        For i = 0 To ItemType.Length - 1
            If item_type = ItemType(i) And item_code = ItemCode(i) Then
                Return i
            End If
        Next
        Return -1
    End Function

    Private Function GetItemTypeCodeText() As String
        Dim i As Int16
        Dim result As String
        For i = 0 To ItemType.Length - 1
            result += IIf(result = String.Empty, "", ",") & ItemType(i) & ItemCode(i)
        Next
        Return result
    End Function

    '删除payout不为空的纪录
    Private Sub RemoveSomeRecord()
        Dim i, count, inx As Int32
        count = dsAccount.Tables(0).Rows.Count
        For i = count - 1 To 0 Step -1
            If Not IsDBNull(dsAccount.Tables(0).Rows(i)("payout")) Then
                inx = GetIndex(dsAccount.Tables(0).Rows(i)("item_type"), dsAccount.Tables(0).Rows(i)("item_code"))
                payout(inx) += CDbl(dsAccount.Tables(0).Rows(i)("payout"))
                dsAccount.Tables(0).Rows.RemoveAt(i)
            End If
        Next
    End Sub

    '计算费用的余额
    Private Sub CalculateBalance()
        Dim i As Int16
        For i = 0 To ItemType.Length - 1
            balance(i) = payout(i)
        Next
        Dim dr As DataRow
        Dim inx As Int32
        For Each dr In dsAccount.Tables(0).Rows
            inx = GetIndex(dr("item_type"), dr("item_code"))
            balance(inx) -= CDbl(IIf(IsDBNull(dr("income")), 0, dr("income")))
        Next

    End Sub

    Private Sub RefreshBalance()
        txtShouldPay.Text = payout(cboType.SelectedIndex)
        txtBalance.Text = balance(cboType.SelectedIndex)
    End Sub

    Private Function GetSqlCondition() As String
        Return "{project_code = '" & ProjectCode & "' AND CHARINDEX(item_type + item_code,'" & GetItemTypeCodeText() & "') > 0}"
    End Function

    Private Sub GetDataSource()
        dsItem = New DataSet()
        dsItem.Merge(gWs.GetItem("{CHARINDEX(item_type + item_code,'" & GetItemTypeCodeText() & "') > 0}", Nothing).Tables(0).Select("", "item_code"))
        '绑定费用类别
        cboType.DataSource = dsItem.Tables("TItem")
        cboType.DisplayMember = "item_name"
        cboType.ValueMember = "item_code"

        dsAccount = gWs.GetProjectAccountDetailInfo(GetSqlCondition)
        cmAccount = Me.BindingContext(dsAccount, "project_account_detail")
        RemoveSomeRecord()
        CalculateBalance()
        CType(cmAccount.List, DataView).RowFilter = "income IS NULL"
        grdFee.SetDataBinding(dsAccount, "project_account_detail")
        grdFee.TableStyles.Clear()
        grdFee.TableStyles.Add(AddTableStyle)
        'cboType.DataBindings.Add("SelectedValue", dsAccount, "project_account_detail.item_code")
        'cboPayMode.DataBindings.Add("Text", dsAccount, "project_account_detail.type") '收费方式
        Me.BindPayManner()
        AddHandler dsAccount.Tables(0).RowChanged, AddressOf Cm_PositionChanged
    End Sub

    'Design By zhoufucai    2006-4-24
    '装载收费方式
    Private Sub BindPayManner()
        Dim i As Integer
        Dim dsPayManner As DataSet = gWs.GetLoanChargeManner("%")
        If dsPayManner.Tables(0).Rows.Count > 0 Then
            For i = 0 To dsPayManner.Tables(0).Rows.Count - 1
                With dsPayManner.Tables(0).Rows(i)
                    Me.cboPayMode.Items.Add(.Item("loan_charge_manner"))
                End With
            Next
        End If
    End Sub

    Private Sub Cm_PositionChanged(ByVal sender As Object, ByVal e As DataRowChangeEventArgs)
        If grdFee.CurrentRowIndex < 0 Then
            Dim obj As Control
            For Each obj In gpbxDetail.Controls
                If obj.GetType Is GetType(TextBox) Then
                    CType(obj, TextBox).Text = String.Empty
                End If
            Next
            'ElseIf e.Action = DataRowAction.Nothing Then
            '    txtIncome.Text = CType(cmAccount.Current, DataRowView)("income") & ""
            '    txtSummary.Text = CType(cmAccount.Current, DataRowView)("remark") & ""
        End If
    End Sub

    Private Function AddTableStyle() As DataGridTableStyle
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "project_account_detail"
        'dgts.AllowSorting = False
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1
        col3.MappingName = "date"
        col3.HeaderText = "收取日期 "
        col3.Width = 80
        col3.Format = "yyyy-MM-dd"
        col3.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col3)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2 
        col2.MappingName = "income"
        col2.HeaderText = "收取金额(元)"
        col2.Alignment = HorizontalAlignment.Right
        col2.NullText = ""
        col2.Width = 100
        col2.Format = "n"
        dgts.GridColumnStyles.Add(col2)
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2 
        col1.MappingName = "type"
        col1.HeaderText = "收取方式"
        col1.NullText = ""
        col1.Width = 100
        dgts.GridColumnStyles.Add(col1)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col5.MappingName = "remark"
        col5.HeaderText = " 摘 要 "
        col5.Width = 360
        col5.NullText = String.Empty
        dgts.GridColumnStyles.Add(col5)
        Return dgts
    End Function

    Private Sub FChargeFee_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            ProjectCode = MyBase.getProjectCode
            TaskID = MyBase.getTaskID
            CorporationName = MyBase.getCorporationName
            WorkFlowID = MyBase.getWorkFlowID
            txtProjectCode.Text = ProjectCode : txtCorName.Text = CorporationName

            SystemDate = gWs.GetSysTime
            dtpDate.Value = SystemDate
            GetDataSource()
            cboType.SelectedValue = DBNull.Value
            AddHandler cboType.SelectedValueChanged, AddressOf FeeTypeChanged
            AddHandler txtIncome.Enter, AddressOf Money_Enter
            AddHandler txtIncome.KeyPress, AddressOf Money_KeyPress
            AddHandler txtIncome.Leave, AddressOf Money_Leave
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub FeeTypeChanged(ByVal sender As Object, ByVal e As EventArgs)
        If cboType.SelectedItem Is Nothing Then
            Return
        End If
        Dim drv As DataRowView = CType(cboType.SelectedItem, DataRowView)
        CType(cmAccount.List, DataView).RowFilter = "item_type='" & drv("item_type").ToString & "' AND item_code='" & drv("item_code").ToString & "'"
        If Status = Money.OperationType.Empty Then
            btnDelete.Enabled = CType(cmAccount.List, DataView).Count > 0 '设置“修改”，“删除”按钮的 Enabled 属性
            btnModify.Enabled = btnDelete.Enabled
            RefreshBalance()
        End If
    End Sub

    Private Sub SetControlsEnabled(ByVal Enabled As Boolean)
        dtpDate.Enabled = Enabled
        'cboPayMode.Enabled = Enabled
        cboType.Enabled = Not Enabled
        txtSummary.ReadOnly = Not Enabled
        btnSave.Enabled = Enabled
        txtIncome.Enabled = Enabled
        grdFee.Enabled = Not Enabled
    End Sub

    Private Sub CancelOperation()
        If dsAccount.HasChanges Then
            dsAccount.RejectChanges()
        End If
        If btnNew.Enabled Then
            btnNew.Text = "新 增(&N)"
        ElseIf btnModify.Enabled Then
            btnModify.Text = "修 改(&M)"
        End If
        Status = Money.OperationType.Empty
        SetControlsEnabled(False)
        btnNew.Enabled = True
        btnDelete.Enabled = CType(cmAccount.List, DataView).Count > 0 '设置“修改”，“删除”按钮的 Enabled 属性
        btnModify.Enabled = btnDelete.Enabled
        '计算差额并显示
        RefreshBalance()
    End Sub

    Private Sub NewHandler(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click
        If Status <> Money.OperationType.Empty Then
            CancelOperation()
            Return
        End If
        If cboType.SelectedItem Is Nothing Then
            SWDialogBox.MessageBox.Show("$1003", "费用类型")
            cboType.Focus()
            Return
        End If
        Dim dr As DataRow = dsAccount.Tables(0).NewRow
        dr("project_code") = ProjectCode
        dr("item_type") = ItemType(cboType.SelectedIndex)
        dr("item_code") = cboType.SelectedValue
        ' dr("type") = cboPayMode.Items(0).ToString
        dr("type") = cboPayMode.Text
        dsAccount.Tables(0).Rows.Add(dr)

        Status = Money.OperationType.NewItem
        btnNew.Text = "取 消(&N)"
        SetControlsEnabled(True)
        btnModify.Enabled = False
        btnDelete.Enabled = False
        txtIncome.Text = balance(cboType.SelectedIndex).ToString("n")
        dtpDate.Value = SystemDate
    End Sub

    Private Sub ModifyHandler(ByVal sender As Object, ByVal e As EventArgs) Handles btnModify.Click
        If Status <> Money.OperationType.Empty Then
            CancelOperation()
            Return
        End If
        Status = Money.OperationType.ModifyItem
        btnModify.Text = "取 消(&M)"
        SetControlsEnabled(True)
        btnNew.Enabled = False
        btnDelete.Enabled = False
    End Sub

    Private Sub DeleteHandler(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If SWDialogBox.MessageBox.Show("?1004", "") = DialogResult.Yes Then
            CType(cmAccount.Current, DataRowView).Delete()
            Dim strResult As String = gWs.UpdateProjectAccountDetail(dsAccount.GetChanges)
            If (strResult = "1") Then
                dsAccount.AcceptChanges()
                SWDialogBox.MessageBox.Show("$DeleteSucceed")
            Else
                SWDialogBox.MessageBox.Show("*999", "删除失败", strResult, "")
            End If
            btnDelete.Enabled = (grdFee.CurrentRowIndex >= 0)
            btnModify.Enabled = btnDelete.Enabled
            '计算差额并显示
            CalculateBalance()
            RefreshBalance()
        End If
    End Sub

    Private Sub RefreshDataSet(ByVal needRefresh As Boolean)
        If Not needRefresh Then
            Return
        End If
        Dim dsTempAccount As DataSet
        Try
            dsTempAccount = gWs.GetProjectAccountDetailInfo(GetSqlCondition)
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        dsTempAccount.Tables(0).DefaultView.Sort = "serial_num DESC"
        dsAccount.Tables(0).Select("serial_num IS NULL")(0)("serial_num") = dsTempAccount.Tables(0).DefaultView(0)("serial_num")
        If dsAccount.HasChanges Then
            dsAccount.AcceptChanges()
        End If
        dsTempAccount.Dispose()
    End Sub

    Private Sub SaveHandler(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If Not IsInfoEffective() Then
            Return
        End If
        If Status = Money.OperationType.NewItem Then
            Dim dr As DataRow = dsAccount.Tables(0).Rows(dsAccount.Tables(0).Rows.Count - 1)
            dr("income") = txtIncome.Text
            dr("date") = dtpDate.Value.Date
            dr("create_person") = UserName
            dr("phase") = ReturnProjectPhase()
            dr("create_date") = SystemDate
            dr("remark") = txtSummary.Text
        ElseIf Status = Money.OperationType.ModifyItem Then
            'cmAccount.Position = grdFee.CurrentRowIndex
            Dim dr As DataRow = CType(cmAccount.Current, DataRowView).Row
            dr("income") = txtIncome.Text
            dr("type") = cboPayMode.Text
            dr("date") = dtpDate.Value.Date
            dr("remark") = txtSummary.Text
        End If
        cmAccount.EndCurrentEdit()
        Dim result As String = gWs.UpdateProjectAccountDetail(dsAccount.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存失败", result, "")
        Else
            Dim hasAdded As Boolean = (Status = Money.OperationType.NewItem)
            Status = Money.OperationType.Empty
            '计算差额
            CalculateBalance()
            If cboType.SelectedValue = "001" Then '评审费
                If Not hasInsertProjectDocument(cboType.SelectedIndex) Then '尚未插入收据
                    InsertToProjectDocument("ReviewFee")
                End If
                If Not hasCommit(cboType.SelectedIndex) Then '任务并没提交 或者 任务并没启动
                    Commit("ReviewFee")
                End If
            ElseIf cboType.SelectedValue = "002" Then '担保费
                If Not hasInsertProjectDocument(cboType.SelectedIndex) Then '尚未插入收据
                    InsertToProjectDocument("GuaranteeFee")
                End If
                If Not hasCommit(cboType.SelectedIndex) Then '任务并没提交或者任务并没启动
                    Commit("GuaranteeFee")
                End If
            ElseIf cboType.SelectedValue = "009" Then '保证金
                If Not hasInsertProjectDocument(cboType.SelectedIndex) Then '尚未插入收据
                    InsertToProjectDocument("DepositFee")
                End If
                If Not hasCommit(cboType.SelectedIndex) Then '任务并没提交或者任务并没启动
                    Commit("DepositFee")
                End If
            End If

            If taskStatus(cboType.SelectedIndex) = "NotStarted" Then
                InsertToWorkLog()  '插入工作日志失败                        
            End If

            If sender Is Nothing Then
                Return
            End If
            RefreshDataSet(hasAdded) '如有新增，重新获取serial_num
            SWDialogBox.MessageBox.Show("$SaveSucceed")

            If dsAccount.HasChanges Then
                dsAccount.AcceptChanges()
            End If
        End If
        CancelOperation()
    End Sub

    Private Function IsInfoEffective() As Boolean
        If txtIncome.Text = String.Empty Then
            SWDialogBox.MessageBox.Show("$1003", "金额")
            txtIncome.Focus()
            Return False
        End If
        Return True
    End Function

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub FChargeFee_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Status <> Money.OperationType.Empty Then
            Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003")
            If QueryResult = DialogResult.Yes Then
                SaveHandler(Nothing, Nothing)
                If Status <> Money.OperationType.Empty Then
                    e.Cancel = True
                End If
            ElseIf QueryResult = DialogResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Commit(ByVal feeType As String)
        If cboType.SelectedIndex < 0 Then  '如果并没选择费用
            Return
        End If

        If balance(cboType.SelectedIndex) > 0 Then '如果并没收齐费用
            Return
        End If

        If taskStatus(cboType.SelectedIndex) = "None" Then
            If feeType = "ReviewFee" Then
                taskStatus(cboType.SelectedIndex) = ReviewFeeTaskStart()
            ElseIf feeType = "GuaranteeFee" Then
                taskStatus(cboType.SelectedIndex) = GuaranteeFeeTaskStart()
            ElseIf feeType = "DepositFee" Then
                taskStatus(cboType.SelectedIndex) = DepositFeeTaskStart()
            End If
        End If

        If taskStatus(cboType.SelectedIndex) = "NotStarted" Then  '并没启动任务
            hasCommit(cboType.SelectedIndex) = True
            Return
        End If


        Dim drTask As DataRow = taskDataRow(cboType.SelectedIndex)
        Dim result As String = gWs.finishedTask(drTask("workflow_id"), ProjectCode, drTask("task_id"), "", UserName)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "提交失败", result, "")
            hasCommit(cboType.SelectedIndex) = False
            Return
        End If
        hasCommit(cboType.SelectedIndex) = True
        RaiseEvent TaskCommit()
    End Sub

    Private Function ReviewFeeTaskStart() As String
        Dim condition As String = "{project_code LIKE '" & ProjectCode & "' AND LTRIM(RTRIM(task_id)) IN ('CashlossReview','ReviewFeeCharge') AND task_status='P'}"
        Dim dsTask As DataSet = gWs.GetWfProjectTaskAttendeeInfo(condition)
        If dsTask.Tables(0).Rows.Count > 0 Then
            taskDataRow(cboType.SelectedIndex) = dsTask.Tables(0).Rows(0)
            Return "Started"
        End If
        Return "NotStarted"
    End Function

    Private Function GuaranteeFeeTaskStart() As String
        Dim condition As String = "{project_code LIKE '" & ProjectCode & "' AND LTRIM(RTRIM(task_id)) = 'GuaranteeCharge' AND task_status='P'}"
        Dim dsTask As DataSet = gWs.GetWfProjectTaskAttendeeInfo(condition)
        If dsTask.Tables(0).Rows.Count > 0 Then
            taskDataRow(cboType.SelectedIndex) = dsTask.Tables(0).Rows(0)
            Return "Started"
        End If
        Return "NotStarted"
    End Function

    Private Function DepositFeeTaskStart() As String
        Dim condition As String = "{project_code LIKE '" & ProjectCode & "' AND LTRIM(RTRIM(task_id)) = 'DepositFeeCharge' AND task_status='P'}"
        Dim dsTask As DataSet = gWs.GetWfProjectTaskAttendeeInfo(condition)
        If dsTask.Tables(0).Rows.Count > 0 Then
            taskDataRow(cboType.SelectedIndex) = dsTask.Tables(0).Rows(0)
            Return "Started"
        End If
        Return "NotStarted"
    End Function

    Private Function InsertToWorkLog() As Boolean
        If cboType.SelectedIndex < 0 Then
            Return True
        End If
        If dsWorkLog Is Nothing Then
            dsWorkLog = gWs.GetWorkLogInfo("null")
        End If
        Dim dr As DataRow = dsWorkLog.Tables(0).NewRow
        dr("project_code") = ProjectCode
        dr("task_name") = "收取" & CType(cboType.SelectedItem, DataRowView)("item_name").ToString
        dr("attend_person") = UserName
        dr("start_time") = SystemDate
        dr("finish_time") = SystemDate
        dr("task_status") = "F"
        dr("auto") = 1
        dr("create_date") = SystemDate
        dsWorkLog.Tables(0).Rows.Add(dr)
        Dim result As String = gWs.UpdateWorkLog(dsWorkLog.GetChanges(DataRowState.Added))
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "保存日志失败", result, "")
            Return False
        End If
        dsWorkLog.AcceptChanges()
        Return True
    End Function

    Private Sub InsertToProjectDocument(ByVal typeName As String)
        Dim AffirmItemtype As String
        Dim AffirmItemCode As String
        If typeName = "ReviewFee" Then
            AffirmItemtype = "44"
            AffirmItemCode = "002"
        ElseIf typeName = "GuaranteeFee" Then
            AffirmItemtype = "44"
            AffirmItemCode = "003"
        ElseIf typeName = "DepositFee" Then
            AffirmItemtype = "44"
            AffirmItemCode = "012"
        End If

        Dim dsProDoc As DataSet = gWs.GetProjectDocumentByCondition("{project_code='" & ProjectCode _
                                    & "' AND item_type='" & AffirmItemtype & "' AND item_code='" & AffirmItemCode & "'}")
        If dsProDoc.Tables(0).Rows.Count = 0 Then
            Dim dr As DataRow = dsProDoc.Tables(0).NewRow
            With dr
                .Item("project_code") = ProjectCode
                .Item("phase") = MyBase.getPhase(ProjectCode)
                .Item("item_type") = AffirmItemtype
                .Item("item_code") = AffirmItemCode
                .Item("check_person") = UserName
                .Item("check_date") = SystemDate.Date
                .Item("create_person") = UserName
                .Item("create_date") = SystemDate
                .Item("doc_name") = CType(cboType.SelectedItem, DataRowView)("item_name").ToString & "收据"
            End With
            dsProDoc.Tables(0).Rows.Add(dr)
        End If
        If dsProDoc.HasChanges Then
            Dim result As String = gWs.UpdateProjectDocument(dsProDoc.GetChanges)
            If result <> "1" Then
                SWDialogBox.MessageBox.Show("*999", "插入收据失败", result, "")
                hasInsertProjectDocument(cboType.SelectedIndex) = False
                Return
            End If
        End If
        hasInsertProjectDocument(cboType.SelectedIndex) = True
    End Sub

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        If Status <> Money.OperationType.Empty Then
            SaveHandler(sender, e)
        End If
        If cboType.SelectedIndex < 0 Or grdFee.CurrentRowIndex < 0 Then
            Return
        End If
        If cboType.SelectedValue = "001" Then '评审费
            PrintReviewFee()
        ElseIf cboType.SelectedValue = "002" Then '担保费
            PrintGuaranteeFee()
        ElseIf cboType.SelectedValue = "009" Then '保证金
            PrintSecurityFee()
        End If
    End Sub

    Private Sub PrintReviewFee()
        Dim dsProject As DataSet = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
        If dsProject.Tables(0).Rows.Count = 0 Then Return
        Dim key() As String
        Dim value As ArrayList = New ArrayList()
        Dim drAccount As DataRow = CType(cmAccount.Current, DataRowView).Row
        Try
            Dim dr As DataRow = dsProject.Tables(0).Rows(0)
            Dim ht As Hashtable = New Hashtable()
            ht.Item("&#CorName") = dr("EnterpriseName") & String.Empty
            If IsDBNull(dr("take_time")) Then
                ht.Item("&#AcceptDate") = ""
            Else
                ht.Item("&#AcceptDate") = DateTime.Parse(dr("take_time")).ToString("yyyy年M月d日")
            End If
            ht.Item("&#ApplySum") = dr("ApplySum") & String.Empty & "万元"
            ht.Item("&#ReviewFee") = CDbl(drAccount("income")).ToString & "元"
            ht.Item("&#UserName") = UserName
            ht.Item("&#RegisterDate") = SystemDate.Date.ToString("yyyy年M月d日")
            ht.Item("&#ChargeDate") = DateTime.Parse(drAccount("date")).ToString("yyyy年M月d日") '缴费日期
            ht.Item("&#Remark") = drAccount("type") & ""
            ht.Item("&#ServiceType") = dr("ApplyServiceType") & String.Empty

            ht.Item("&#Addition") = String.Empty

            ht.Item("&#CN2") = dr("EnterpriseName") & String.Empty
            If IsDBNull(dr("take_time")) Then
                ht.Item("&#AD2") = ""
            Else
                ht.Item("&#AD2") = DateTime.Parse(dr("take_time")).ToString("yyyy年M月d日")
            End If
            ht.Item("&#AS2") = dr("ApplySum") & String.Empty & "万元"
            ht.Item("&#RF2") = CDbl(drAccount("income")).ToString & "元"
            ht.Item("&#CD2") = DateTime.Parse(drAccount("date")).ToString("yyyy年M月d日") '缴费日期
            ht.Item("&#Rk2") = drAccount("type") & ""

            ht.Item("&#UN2") = UserName
            ht.Item("&#RD2") = SystemDate.Date.ToString("yyyy年M月d日")
            ht.Item("&#ST2") = dr("ApplyServiceType") & String.Empty
            Dim k As Integer = 0
            ReDim key(ht.Count - 1)
            Dim ItemList As IDictionaryEnumerator = ht.GetEnumerator
            While ItemList.MoveNext
                key(k) = ItemList.Key
                value.Add(ItemList.Value)
                k += 1
            End While
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", "生成标记出错", ex.Source, ex.Message)
        End Try
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ofrm1 As frmDocumentManageBusiness
            ofrm1 = New frmDocumentManageBusiness(ProjectCode, String.Empty, CorporationName, "45", "014", UserName, key, value)
            ofrm1.AllowTransparency = False
            ofrm1.Show()
            ofrm1.btnMakeDoc_Click(Nothing, Nothing)
            ofrm1.Dispose()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", "打开窗口调用方法出错", ex.Source, ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub PrintGuaranteeFee()
        Dim dsProject As DataSet = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
        If dsProject.Tables(0).Rows.Count = 0 Then Return
        Dim key() As String
        Dim value As ArrayList = New ArrayList()
        Dim drAccount As DataRow = CType(cmAccount.Current, DataRowView).Row
        Try
            Dim dr As DataRow = dsProject.Tables(0).Rows(0)
            Dim ht As Hashtable = New Hashtable()
            ht.Item("&#CorName") = dr("EnterpriseName") & String.Empty
            If IsDBNull(dr("sign_date")) Then
                ht.Item("&#SigDate") = ""
            Else
                ht.Item("&#SigDate") = DateTime.Parse(dr("sign_date")).ToString("yyyy年M月d日")
            End If
            If IsDBNull(dr("GuaranteeSum")) Then
                ht.Item("&#GuarantSum") = dr("ApplySum") & String.Empty & "万元"
            Else
                ht.Item("&#GuarantSum") = dr("GuaranteeSum") & String.Empty & "万元"
            End If
            ht.Item("&#GuarantFee") = CDbl(drAccount("income")).ToString & "元"
            ht.Item("&#ChargeDate") = DateTime.Parse(drAccount("date")).ToString("yyyy年M月d日") '缴费日期
            ht.Item("&#UserName") = UserName
            ht.Item("&#RegisterDate") = SystemDate.Date.ToString("yyyy年M月d日")
            ht.Item("&#Remark") = drAccount("type") & ""
            If IsDBNull(dr("ServiceType")) Then
                ht.Item("&#ServiceType") = dr("ApplyServiceType") & String.Empty
            Else
                ht.Item("&#ServiceType") = dr("ServiceType") & String.Empty
            End If

            ht.Item("&#CN2") = dr("EnterpriseName") & String.Empty
            If IsDBNull(dr("sign_date")) Then
                ht.Item("&#SD2") = ""
            Else
                ht.Item("&#SD2") = DateTime.Parse(dr("sign_date")).ToString("yyyy年M月d日")
            End If
            If IsDBNull(dr("GuaranteeSum")) Then
                ht.Item("&#GS2") = dr("ApplySum") & String.Empty & "万元"
            Else
                ht.Item("&#GS2") = dr("GuaranteeSum") & String.Empty & "万元"
            End If
            ht.Item("&#GF2") = CDbl(drAccount("income")).ToString & "元"
            ht.Item("&#Rk2") = drAccount("type") & ""
            ht.Item("&#CD2") = DateTime.Parse(drAccount("date")).ToString("yyyy年M月d日") '缴费日期
            ht.Item("&#UN2") = UserName
            ht.Item("&#RD2") = SystemDate.Date.ToString("yyyy年M月d日")
            If IsDBNull(dr("ServiceType")) Then
                ht.Item("&#ST2") = dr("ApplyServiceType") & String.Empty
            Else
                ht.Item("&#ST2") = dr("ServiceType") & String.Empty
            End If

            Dim k As Integer = 0
            ReDim key(ht.Count - 1)
            Dim ItemList As IDictionaryEnumerator = ht.GetEnumerator
            While ItemList.MoveNext
                key(k) = ItemList.Key
                value.Add(ItemList.Value)
                k += 1
            End While
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", "生成标记出错", ex.Source, ex.Message)
        End Try
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ofrm1 As frmDocumentManageBusiness
            ofrm1 = New frmDocumentManageBusiness(ProjectCode, String.Empty, CorporationName, "45", "015", UserName, key, value)
            ofrm1.AllowTransparency = False
            ofrm1.Show()
            ofrm1.btnMakeDoc_Click(Nothing, Nothing)
            ofrm1.Dispose()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", "打开窗口调用方法出错", ex.Source, ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub PrintSecurityFee()
        Dim drAccount As DataRow = CType(cmAccount.Current, DataRowView).Row

        Dim dsProject As DataSet = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
        If dsProject.Tables(0).Rows.Count = 0 Then Return
        Dim key() As String
        Dim value As ArrayList = New ArrayList()

        Try
            Dim dr As DataRow = dsProject.Tables(0).Rows(0)
            Dim ht As Hashtable = New Hashtable()
            ht.Item("&#CorName") = dr("EnterpriseName") & String.Empty
            If IsDBNull(dr("sign_date")) Then
                ht.Item("&#SigDate") = ""
            Else
                ht.Item("&#SigDate") = DateTime.Parse(dr("sign_date")).ToString("yyyy年M月d日")
            End If
            If IsDBNull(dr("GuaranteeSum")) Then
                ht.Item("&#GuarantSum") = dr("ApplySum") & String.Empty & "万元"
            Else
                ht.Item("&#GuarantSum") = dr("GuaranteeSum") & String.Empty & "万元"
            End If
            ht.Item("&#SecurityFee") = CDbl(drAccount("income")).ToString & "元"
            ht.Item("&#ChargeDate") = DateTime.Parse(drAccount("date")).ToString("yyyy年M月d日") '缴费日期
            ht.Item("&#UserName") = UserName
            ht.Item("&#RegisterDate") = SystemDate.Date.ToString("yyyy年M月d日")
            ht.Item("&#Remark") = drAccount("type") & ""
            If IsDBNull(dr("ServiceType")) Then
                ht.Item("&#ServiceType") = dr("ApplyServiceType") & String.Empty
            Else
                ht.Item("&#ServiceType") = dr("ServiceType") & String.Empty
            End If

            ht.Item("&#CN2") = dr("EnterpriseName") & String.Empty
            If IsDBNull(dr("sign_date")) Then
                ht.Item("&#SD2") = ""
            Else
                ht.Item("&#SD2") = DateTime.Parse(dr("sign_date")).ToString("yyyy年M月d日")
            End If
            If IsDBNull(dr("GuaranteeSum")) Then
                ht.Item("&#GS2") = dr("ApplySum") & String.Empty & "万元"
            Else
                ht.Item("&#GS2") = dr("GuaranteeSum") & String.Empty & "万元"
            End If
            ht.Item("&#SF2") = CDbl(drAccount("income")).ToString & "元"
            ht.Item("&#Rk2") = drAccount("type") & ""
            ht.Item("&#CD2") = DateTime.Parse(drAccount("date")).ToString("yyyy年M月d日") '缴费日期

            ht.Item("&#UN2") = UserName
            ht.Item("&#RD2") = SystemDate.Date.ToString("yyyy年M月d日")
            If IsDBNull(dr("ServiceType")) Then
                ht.Item("&#ST2") = dr("ApplyServiceType") & String.Empty
            Else
                ht.Item("&#ST2") = dr("ServiceType") & String.Empty
            End If

            Dim k As Integer = 0
            ReDim key(ht.Count - 1)
            Dim ItemList As IDictionaryEnumerator = ht.GetEnumerator
            While ItemList.MoveNext
                key(k) = ItemList.Key
                value.Add(ItemList.Value)
                k += 1
            End While
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", "生成标记出错", ex.Source, ex.Message)
        Finally
            If Not dsProject Is Nothing Then
                dsProject.Dispose()
            End If
        End Try
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim ofrm1 As frmDocumentManageBusiness
            ofrm1 = New frmDocumentManageBusiness(ProjectCode, String.Empty, CorporationName, "45", "017", UserName, key, value)
            ofrm1.AllowTransparency = False
            ofrm1.Show()
            ofrm1.btnMakeDoc_Click(Nothing, Nothing)
            ofrm1.Close()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", "打开窗口调用方法出错", ex.Source, ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class
