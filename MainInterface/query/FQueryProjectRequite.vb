Public Class FQueryProjectRequite
    Inherits FQueryBase
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboRefundType As System.Windows.Forms.ComboBox
    Friend WithEvents cboMA As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboNormal As System.Windows.Forms.ComboBox
    Friend WithEvents cboPartion As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents txtProjectName As System.Windows.Forms.TextBox
    Friend WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Friend WithEvents btnDetail As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryProjectRequite))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboRefundType = New System.Windows.Forms.ComboBox()
        Me.cboMA = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboNormal = New System.Windows.Forms.ComboBox()
        Me.cboPartion = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbServiceType = New System.Windows.Forms.ComboBox()
        Me.txtProjectName = New System.Windows.Forms.TextBox()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.btnDetail = New System.Windows.Forms.Button()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Bitmap)
        Me.btnClear.Location = New System.Drawing.Point(192, 120)
        Me.btnClear.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Bitmap)
        Me.btnExport.Location = New System.Drawing.Point(536, 120)
        Me.btnExport.Visible = True
        '
        'ImageListQuery
        '
        Me.ImageListQuery.ImageStream = CType(resources.GetObject("ImageListQuery.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.Location = New System.Drawing.Point(448, 120)
        Me.btnRefresh.Visible = True
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(512, 120)
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(624, 120)
        Me.btnExit.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 120)
        Me.chkVisible.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCorporationName, Me.txtProjectName, Me.cmbServiceType, Me.Label8, Me.Label7, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.cboPartion, Me.cboNormal, Me.cboMA, Me.cboRefundType, Me.dtpDate})
        Me.grpCondition.Size = New System.Drawing.Size(696, 104)
        Me.grpCondition.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 152)
        Me.grdTable.Size = New System.Drawing.Size(696, 336)
        Me.grdTable.Visible = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "项目经理A角"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "截 止 日 期"
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(96, 72)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpDate.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(256, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "还款方式"
        '
        'cboRefundType
        '
        Me.cboRefundType.Location = New System.Drawing.Point(320, 72)
        Me.cboRefundType.Name = "cboRefundType"
        Me.cboRefundType.Size = New System.Drawing.Size(120, 20)
        Me.cboRefundType.TabIndex = 7
        '
        'cboMA
        '
        Me.cboMA.Location = New System.Drawing.Point(96, 44)
        Me.cboMA.MaxLength = 20
        Me.cboMA.Name = "cboMA"
        Me.cboMA.Size = New System.Drawing.Size(112, 20)
        Me.cboMA.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(256, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "还款情况"
        '
        'cboNormal
        '
        Me.cboNormal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboNormal.Items.AddRange(New Object() {"<未选定>", "正常", "非正常"})
        Me.cboNormal.Location = New System.Drawing.Point(320, 44)
        Me.cboNormal.Name = "cboNormal"
        Me.cboNormal.Size = New System.Drawing.Size(121, 20)
        Me.cboNormal.TabIndex = 10
        '
        'cboPartion
        '
        Me.cboPartion.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.cboPartion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPartion.Items.AddRange(New Object() {"<未选定>", "部分还款", "全部还完"})
        Me.cboPartion.Location = New System.Drawing.Point(528, 40)
        Me.cboPartion.Name = "cboPartion"
        Me.cboPartion.Size = New System.Drawing.Size(121, 20)
        Me.cboPartion.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(464, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "还款进度"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(464, 19)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 14)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "业务品种"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(264, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 14)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "企业名称"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(24, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 14)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "项目编码"
        '
        'cmbServiceType
        '
        Me.cmbServiceType.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.cmbServiceType.Items.AddRange(New Object() {"<未选定>", "部分还款", "全部还完"})
        Me.cmbServiceType.Location = New System.Drawing.Point(528, 16)
        Me.cmbServiceType.Name = "cmbServiceType"
        Me.cmbServiceType.Size = New System.Drawing.Size(121, 20)
        Me.cmbServiceType.TabIndex = 18
        '
        'txtProjectName
        '
        Me.txtProjectName.Location = New System.Drawing.Point(96, 17)
        Me.txtProjectName.Name = "txtProjectName"
        Me.txtProjectName.Size = New System.Drawing.Size(112, 21)
        Me.txtProjectName.TabIndex = 19
        Me.txtProjectName.Text = ""
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Location = New System.Drawing.Point(320, 16)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.Size = New System.Drawing.Size(120, 21)
        Me.txtCorporationName.TabIndex = 20
        Me.txtCorporationName.Text = ""
        '
        'btnDetail
        '
        Me.btnDetail.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnDetail.Image = CType(resources.GetObject("btnDetail.Image"), System.Drawing.Bitmap)
        Me.btnDetail.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.btnDetail.Location = New System.Drawing.Point(352, 120)
        Me.btnDetail.Name = "btnDetail"
        Me.btnDetail.Size = New System.Drawing.Size(80, 24)
        Me.btnDetail.TabIndex = 108
        Me.btnDetail.Text = "详 细(&D)"
        Me.btnDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FQueryProjectRequite
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition, Me.btnDetail})
        Me.Name = "FQueryProjectRequite"
        Me.Text = "项目还款情况查询"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsSource As DataSet
    Private dgts As DataGridTableStyle
    Public Event ClearLoad()

    Protected Overloads Sub GetCondition(ByRef ProjectCode As String, ByRef CorporationName As String, ByRef ServiceType As String, ByRef Partion As String, ByRef Normal As String, _
         ByRef MA As String, ByRef theDate As Object, ByRef RefundType As String)
        ProjectCode = Me.txtProjectName.Text.Trim
        CorporationName = Me.txtCorporationName.Text.Trim
        ServiceType = Me.cmbServiceType.Text.Trim
        MA = cboMA.Text.Trim
        theDate = dtpDate.Value.Date
        RefundType = cboRefundType.Text.Trim
        Partion = cboPartion.SelectedIndex.ToString.Trim
        Normal = cboNormal.SelectedIndex.ToString.Trim

    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal Condition As String)
        Dim theDate As Object
        Dim i As Integer
        Dim iLoanSum, iIncomeSum, iPayoutSums, iGuaranteedSum As Decimal

        Dim Normal, Partion As String
        Dim MA, RefundType As String

        Dim strProjectCode, strCorporationName, strServiceType As String
        GetCondition(strProjectCode, strCorporationName, strServiceType, Partion, Normal, MA, theDate, RefundType)

        Dim dtResult As DataTable
        dsSource = gWs.PQueryProjectRequite(strProjectCode, strCorporationName, strServiceType, MA, RefundType, Normal, Partion, theDate, UserName)
        dtResult = dsSource.Tables(0)

        For i = 0 To dtResult.Rows.Count - 1
            iLoanSum += CDec(IIf(IsDBNull(dtResult.Rows(i).Item("loan_sum")), 0, dtResult.Rows(i).Item("loan_sum")))
            iIncomeSum += CDec(IIf(IsDBNull(dtResult.Rows(i).Item("Income")), 0, dtResult.Rows(i).Item("Income")))
            iPayoutSums += CDec(IIf(IsDBNull(dtResult.Rows(i).Item("Payout")), 0, dtResult.Rows(i).Item("Payout")))
            iGuaranteedSum += CDec(IIf(IsDBNull(dtResult.Rows(i).Item("guaranteed")), 0, dtResult.Rows(i).Item("guaranteed")))
        Next
        Dim drRow As DataRow = dtResult.NewRow
        With drRow
            .Item("EnterpriseName") = "合计："
            .Item("loan_sum") = iLoanSum
            .Item("Income") = iIncomeSum
            .Item("Payout") = iPayoutSums
            .Item("guaranteed") = iGuaranteedSum
        End With
        dtResult.Rows.Add(drRow)

        drRow = dtResult.NewRow
        With drRow
            .Item("EnterpriseName") = "单数：" & i
        End With
        dtResult.Rows.Add(drRow)

        'ds.Tables(0).TableName = "TQueryRequiteProject"
        'grdTable.DataMember = "TQueryRequiteProject"
        grdTable.TableStyles.Clear()
        grdTable.SetDataBinding(dsSource, "Table")
        AddTableStyle()
        MyBase.DataSource = dtResult
    End Sub

    Private Sub Form_Loaded(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            '业务品种
            Dim dsServiceType As DataSet
            dsServiceType = gWs.GetServiceType("%")
            Me.cmbServiceType.DataSource = dsServiceType.Tables(0)
            Me.cmbServiceType.DisplayMember = "service_type"
            Me.cmbServiceType.ValueMember = "service_type"

            '''''''''''''项目经理A'''''''''''
            Dim strSql As String = "{not team_name is null}"
            Dim dsMA As DataSet = gWs.GetStaff(strSql)
            cboMA.DataSource = dsMA.Tables(0)
            cboMA.DisplayMember = "staff_name"
            cboMA.ValueMember = "staff_name"

            ''''''''''''''还款方式'''''''''''''
            Dim dsFT As DataSet = gWs.GetRefundType("%")
            cboRefundType.DataSource = dsFT.Tables(0)
            cboRefundType.DisplayMember = "refund_type"
            cboRefundType.ValueMember = "refund_type"
            AddTableStyle()

        Catch
        End Try
    End Sub

    Private Sub AddTableStyle()
        grdTable.TableStyles.Clear()
        If dgts Is Nothing Then
            dgts = New DataGridTableStyle()
            dgts.MappingName = "Table"
            Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col1.MappingName = "ProjectCode"
            col1.HeaderText = "项目编号"
            col1.Width = 75
            col1.NullText = ""
            Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col2.MappingName = "EnterpriseName"
            col2.HeaderText = "企业名称"
            col2.Width = 150
            col2.NullText = ""
            Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col3.MappingName = "ServiceType"
            col3.HeaderText = "业务品种"
            col3.Width = 110
            col3.NullText = ""
            Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col4.MappingName = "Bank"
            col4.HeaderText = "贷款银行"
            col4.Width = 110
            col4.NullText = ""
            Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col5.MappingName = "manager_A"
            col5.HeaderText = "项目经理A角"
            col5.Width = 75
            col5.NullText = ""
            Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col6.MappingName = "manager_B"
            col6.HeaderText = "项目经理B角"
            col6.Width = 75
            col6.NullText = ""
            Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col7.MappingName = "loan_sum"
            col7.Alignment = HorizontalAlignment.Right
            col7.HeaderText = "承保金额(万元)"
            col7.Width = 100
            col7.NullText = ""
            Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col8.MappingName = "RefundType"
            col8.HeaderText = "还款方式"
            col8.Width = 100
            col8.NullText = ""
            Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col9.MappingName = "StartTime"
            col9.HeaderText = "放款期起"
            col9.Format = "yyyy-MM-dd"
            col9.Width = 75
            col9.NullText = ""
            Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col10.MappingName = "EndTime"
            col10.Format = "yyyy-MM-dd"
            col10.HeaderText = "放款期止"
            col10.NullText = ""
            col10.Width = 75

            Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col11.MappingName = "Payout"
            col11.Alignment = HorizontalAlignment.Right
            col11.HeaderText = "应还金额(万元)"
            col11.Width = 100 : col11.NullText = ""
            col11.Format = "F"

            Dim col12 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col12.MappingName = "Income"
            col12.Alignment = HorizontalAlignment.Right
            col12.HeaderText = "已还金额(万元)"
            col12.NullText = ""
            col12.Width = 110
            col12.Format = "F"

            Dim col13 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col13.MappingName = "guaranteed"
            col13.Alignment = HorizontalAlignment.Right
            col13.HeaderText = "在保余额(万元)"
            col13.NullText = ""
            col13.Width = 100
            col13.Format = "F"

            Dim col15 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
            col15.MappingName = "branch_name"
            col15.HeaderText = "责任部门"
            col15.NullText = ""
            col15.Width = 75

            Dim col16 As DataGridTextBoxColumn = New DataGridTextBoxColumn() 'status             2005-1-4 by 9sky
            col16.Format = ""
            col16.FormatInfo = Nothing
            col16.HeaderText = "项目状态"
            col16.MappingName = "status"
            col16.NullText = ""
            col16.Width = 75
            dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col4, col5, col6, col7, col8, col9, col10, col11, col12, col13, col15, col16})
        End If
        grdTable.TableStyles.Add(dgts)
    End Sub
   
    Private Sub btnDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetail.Click
        Try
            Me.Cursor = Cursors.WaitCursor

            If grdTable.DataSource Is Nothing Then
                Return
            End If

            Dim cm As CurrencyManager = Me.BindingContext(grdTable.DataSource, grdTable.DataMember)
            If cm.Count <= 0 Then
                Return
            End If

            Dim row As DataRow = CType(cm.Current, DataRowView).Row

            Dim resultForm As FQueryProjectRequite.FResultDialog = New FQueryProjectRequite.FResultDialog()
            resultForm.Open(Me, row("ProjectCode").ToString(), Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, UserName)
            resultForm.Dispose()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Class FResultDialog
        Inherits Form

        Private grdTable As DataGrid
        Private tsDefault As DataGridTableStyle
        Private csProjectNo As DataGridTextBoxColumn
        Private csCorporationName As DataGridTextBoxColumn
        Private csServiceType As DataGridTextBoxColumn
        Private csBankName As DataGridTextBoxColumn
        Private csReturnAmount As DataGridTextBoxColumn
        Private csReturnDate As DataGridTextBoxColumn

        Public Sub New()
            tsDefault = New DataGridTableStyle()
            csProjectNo = New DataGridTextBoxColumn()
            csCorporationName = New DataGridTextBoxColumn()
            csServiceType = New DataGridTextBoxColumn()
            csBankName = New DataGridTextBoxColumn()
            csReturnAmount = New DataGridTextBoxColumn()
            csReturnDate = New DataGridTextBoxColumn()

            csProjectNo.MappingName = "project_code"
            csProjectNo.HeaderText = "项目编号"
            csProjectNo.Width = 80

            csCorporationName.MappingName = "enterprise_name"
            csCorporationName.HeaderText = "企业名称"
            csCorporationName.Width = 200

            csServiceType.MappingName = "service_type"
            csServiceType.HeaderText = "业务品种"
            csServiceType.Width = 150

            csBankName.MappingName = "bank"
            csBankName.HeaderText = "贷款银行"
            csBankName.Width = 120

            csReturnAmount.MappingName = "DateSum"
            csReturnAmount.HeaderText = "还款金额(万元)"
            csReturnAmount.Width = 110
            csReturnAmount.Alignment = HorizontalAlignment.Right

            csReturnDate.MappingName = "ReturnDate"
            csReturnDate.HeaderText = "还款日期"
            csReturnDate.Width = 100
            csReturnDate.Format = "D"

            tsDefault.MappingName = "Table"
            tsDefault.GridColumnStyles.AddRange(New DataGridColumnStyle() {csProjectNo, csCorporationName, csServiceType, csBankName, csReturnAmount, csReturnDate})

            grdTable = New DataGrid()
            grdTable.Dock = DockStyle.Fill
            grdTable.ReadOnly = True
            grdTable.CaptionVisible = False
            grdTable.TableStyles.Clear()
            grdTable.TableStyles.Add(tsDefault)

            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Size = New Size(560, 400)
            Me.DockPadding.All = 8
            Me.Text = "还款项目明细"
            Me.Controls.Add(grdTable)
        End Sub

        Public Sub Open(ByVal owner As IWin32Window, ByVal projectNo As String, ByVal corporationName As String, ByVal serviceType As String, ByVal beginDate As Object, ByVal endDate As Object, ByVal managerA As String, ByVal bank As String, ByVal refundType As String, ByVal UserName As String)
            Dim dsResult As DataSet = gWs.FQueryRequiteProject(projectNo, corporationName, serviceType, beginDate, endDate, managerA, bank, refundType, UserName)
            grdTable.SetDataBinding(dsResult, "Table")

            Me.Icon = CType(owner, Form).Icon
            Me.ShowDialog(owner)
        End Sub
    End Class
End Class