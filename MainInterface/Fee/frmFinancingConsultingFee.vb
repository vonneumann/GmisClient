'作者：罗庆锋；日期2003-04-11
Public Class frmFinancingConsultingFee
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
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtReviewFee As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstTrial As System.Windows.Forms.TextBox
    Friend WithEvents txtManager As System.Windows.Forms.TextBox
    Friend WithEvents lblManager As System.Windows.Forms.Label
    Friend WithEvents lblFirstMan As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboMoneyType As System.Windows.Forms.ComboBox
    Friend WithEvents btnReport As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtServiceType As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinancingConsultingFee))
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtReviewFee = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtBalance = New System.Windows.Forms.TextBox
        Me.lblFirstMan = New System.Windows.Forms.Label
        Me.txtFirstTrial = New System.Windows.Forms.TextBox
        Me.lblManager = New System.Windows.Forms.Label
        Me.txtManager = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cboMoneyType = New System.Windows.Forms.ComboBox
        Me.btnReport = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtServiceType = New System.Windows.Forms.TextBox
        Me.gpbxResult.SuspendLayout()
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbxDetail.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbxResult
        '
        Me.gpbxResult.Location = New System.Drawing.Point(8, 80)
        Me.gpbxResult.Size = New System.Drawing.Size(576, 160)
        '
        'txtSummary
        '
        Me.txtSummary.TabIndex = 3
        '
        'dgMoney
        '
        Me.dgMoney.AccessibleName = "DataGrid"
        Me.dgMoney.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgMoney.Size = New System.Drawing.Size(570, 140)
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageIndex = -1
        Me.btnNew.ImageList = Nothing
        Me.btnNew.Location = New System.Drawing.Point(104, 338)
        Me.btnNew.Size = New System.Drawing.Size(75, 24)
        '
        'btnModify
        '
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Image)
        Me.btnModify.ImageIndex = -1
        Me.btnModify.ImageList = Nothing
        Me.btnModify.Location = New System.Drawing.Point(184, 338)
        Me.btnModify.Size = New System.Drawing.Size(75, 24)
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Image)
        Me.btnDelete.ImageIndex = -1
        Me.btnDelete.ImageList = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(264, 338)
        Me.btnDelete.Size = New System.Drawing.Size(75, 24)
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageIndex = -1
        Me.btnSave.ImageList = Nothing
        Me.btnSave.Location = New System.Drawing.Point(344, 338)
        Me.btnSave.Size = New System.Drawing.Size(75, 24)
        '
        'txtCorName
        '
        Me.txtCorName.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtCorName.Location = New System.Drawing.Point(280, 8)
        Me.txtCorName.Size = New System.Drawing.Size(304, 21)
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(112, 8)
        Me.txtProjectCode.Size = New System.Drawing.Size(80, 21)
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(376, 16)
        '
        'lblFeeType
        '
        Me.lblFeeType.Location = New System.Drawing.Point(592, 16)
        Me.lblFeeType.Size = New System.Drawing.Size(32, 16)
        '
        'btnCommit
        '
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Image)
        Me.btnCommit.ImageIndex = -1
        Me.btnCommit.ImageList = Nothing
        Me.btnCommit.Location = New System.Drawing.Point(424, 338)
        Me.btnCommit.Size = New System.Drawing.Size(75, 24)
        '
        'dtpDate
        '
        Me.dtpDate.Location = New System.Drawing.Point(64, 16)
        Me.dtpDate.Value = New Date(2003, 4, 7, 20, 2, 52, 811)
        '
        'cmbxType
        '
        Me.cmbxType.DropDownWidth = 32
        Me.cmbxType.ItemHeight = 12
        Me.cmbxType.Location = New System.Drawing.Point(648, 16)
        Me.cmbxType.Size = New System.Drawing.Size(32, 20)
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(464, 14)
        Me.txtIncome.Size = New System.Drawing.Size(104, 21)
        Me.txtIncome.TabIndex = 2
        '
        'gpbxDetail
        '
        Me.gpbxDetail.Controls.Add(Me.Label4)
        Me.gpbxDetail.Controls.Add(Me.cboMoneyType)
        Me.gpbxDetail.Location = New System.Drawing.Point(8, 240)
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
        Me.Label5.Location = New System.Drawing.Point(200, 8)
        Me.Label5.Size = New System.Drawing.Size(71, 12)
        Me.Label5.Text = "企 业 名 称"
        '
        'Label6
        '
        Me.Label6.Size = New System.Drawing.Size(83, 12)
        Me.Label6.Text = "项  目  编 码"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(504, 338)
        Me.btnExit.Size = New System.Drawing.Size(75, 24)
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 12)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "应收顾问费(元)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtReviewFee
        '
        Me.txtReviewFee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtReviewFee.Location = New System.Drawing.Point(112, 58)
        Me.txtReviewFee.Name = "txtReviewFee"
        Me.txtReviewFee.ReadOnly = True
        Me.txtReviewFee.Size = New System.Drawing.Size(80, 21)
        Me.txtReviewFee.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(200, 59)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 12)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "差      额"
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBalance.ForeColor = System.Drawing.Color.Red
        Me.txtBalance.Location = New System.Drawing.Point(280, 58)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(80, 21)
        Me.txtBalance.TabIndex = 27
        '
        'lblFirstMan
        '
        Me.lblFirstMan.AutoSize = True
        Me.lblFirstMan.Location = New System.Drawing.Point(366, 35)
        Me.lblFirstMan.Name = "lblFirstMan"
        Me.lblFirstMan.Size = New System.Drawing.Size(83, 12)
        Me.lblFirstMan.TabIndex = 28
        Me.lblFirstMan.Text = "初  审  人 员"
        Me.lblFirstMan.Visible = False
        '
        'txtFirstTrial
        '
        Me.txtFirstTrial.BackColor = System.Drawing.Color.Gainsboro
        Me.txtFirstTrial.Location = New System.Drawing.Point(462, 32)
        Me.txtFirstTrial.Name = "txtFirstTrial"
        Me.txtFirstTrial.ReadOnly = True
        Me.txtFirstTrial.Size = New System.Drawing.Size(80, 21)
        Me.txtFirstTrial.TabIndex = 29
        Me.txtFirstTrial.Visible = False
        '
        'lblManager
        '
        Me.lblManager.AutoSize = True
        Me.lblManager.Location = New System.Drawing.Point(16, 35)
        Me.lblManager.Name = "lblManager"
        Me.lblManager.Size = New System.Drawing.Size(71, 12)
        Me.lblManager.TabIndex = 30
        Me.lblManager.Text = "项目经理A角"
        '
        'txtManager
        '
        Me.txtManager.BackColor = System.Drawing.Color.Gainsboro
        Me.txtManager.Location = New System.Drawing.Point(112, 32)
        Me.txtManager.Name = "txtManager"
        Me.txtManager.ReadOnly = True
        Me.txtManager.Size = New System.Drawing.Size(80, 21)
        Me.txtManager.TabIndex = 31
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "收费方式"
        '
        'cboMoneyType
        '
        Me.cboMoneyType.Enabled = False
        Me.cboMoneyType.Location = New System.Drawing.Point(248, 14)
        Me.cboMoneyType.MaxLength = 10
        Me.cboMoneyType.Name = "cboMoneyType"
        Me.cboMoneyType.Size = New System.Drawing.Size(121, 20)
        Me.cboMoneyType.TabIndex = 10
        '
        'btnReport
        '
        Me.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.ImageIndex = 23
        Me.btnReport.ImageList = Me.ImageListBasic
        Me.btnReport.Location = New System.Drawing.Point(24, 338)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(77, 23)
        Me.btnReport.TabIndex = 32
        Me.btnReport.Text = "打 印(&P)"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(368, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(53, 12)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "业务品种"
        '
        'txtServiceType
        '
        Me.txtServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtServiceType.Location = New System.Drawing.Point(424, 58)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(160, 21)
        Me.txtServiceType.TabIndex = 34
        '
        'frmFinancingConsultingFee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(592, 367)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtServiceType)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.txtBalance)
        Me.Controls.Add(Me.txtReviewFee)
        Me.Controls.Add(Me.txtFirstTrial)
        Me.Controls.Add(Me.lblFirstMan)
        Me.Controls.Add(Me.txtManager)
        Me.Controls.Add(Me.lblManager)
        Me.Name = "frmFinancingConsultingFee"
        Me.Text = "收取评审费"
        Me.Controls.SetChildIndex(Me.lblManager, 0)
        Me.Controls.SetChildIndex(Me.txtManager, 0)
        Me.Controls.SetChildIndex(Me.lblFirstMan, 0)
        Me.Controls.SetChildIndex(Me.txtFirstTrial, 0)
        Me.Controls.SetChildIndex(Me.txtReviewFee, 0)
        Me.Controls.SetChildIndex(Me.txtBalance, 0)
        Me.Controls.SetChildIndex(Me.btnReport, 0)
        Me.Controls.SetChildIndex(Me.txtServiceType, 0)
        Me.Controls.SetChildIndex(Me.Label7, 0)
        Me.Controls.SetChildIndex(Me.Label8, 0)
        Me.Controls.SetChildIndex(Me.Label9, 0)
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

    '评审费
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

        txtReviewFee.Text = RemoveSomeRecord().ToString("n")
        btnDelete.Enabled = (dgMoney.CurrentRowIndex >= 0)
        btnModify.Enabled = btnDelete.Enabled
    End Sub
    '删掉payout不为零的记录
    Protected Overrides Function RemoveSomeRecord() As Double
        Me.Tag = IIf(dsAccountDetail.Tables("project_account_detail").Select("phase='评审' AND payout IS NOT NULL").Length > 0, String.Empty, "(预收)")
        Dim payoutSum As Double = 0
        Dim incomeSum As Double = 0
        Dim dr As DataRow
        With dsAccountDetail.Tables("project_account_detail")
            For Each dr In .Rows
                If Not IsDBNull(dr("income")) Then  '
                    incomeSum += CDbl(dr("income"))
                End If
                If Not IsDBNull(dr("payout")) Then  '
                    payoutSum += CDbl(dr("payout"))
                    dr.Delete()
                End If
            Next
            If dsAccountDetail.HasChanges Then
                .AcceptChanges()
            End If
        End With
        txtBalance.Text = (payoutSum - incomeSum).ToString("n")
        LessMoney = payoutSum - incomeSum
        Return payoutSum
    End Function

    Protected Overrides Sub DeleteRefresh(ByVal sender As Object, ByVal e As EventArgs)
        MyBase.DeleteRefresh(sender, e)
        Dim incomeSum As Double = 0
        Dim dr As DataRow
        With dsAccountDetail.Tables("project_account_detail")
            For Each dr In .Rows
                If Not IsDBNull(dr("income")) Then  '
                    incomeSum += CDbl(dr("income"))
                End If
            Next
        End With
        txtBalance.Text = (CDbl(txtReviewFee.Text) - incomeSum).ToString("n")
        LessMoney = CDbl(txtReviewFee.Text) - incomeSum
    End Sub

    Protected Overrides Sub SetObjEnabled(ByVal IsEnabled As Boolean)
        MyBase.SetObjEnabled(IsEnabled)
        cboMoneyType.Enabled = IsEnabled
        If IsEnabled Then
            'cboMoneyType.Text = cboMoneyType.Items(0).ToString
            'cboMoneyType.SelectedIndex = 0
            CType(bmAccount.Current, DataRowView)("type") = cboMoneyType.Text
        End If
    End Sub

    Protected Overrides Sub IniBindingForAccount()
        MyBase.IniBindingForAccount()
        cboMoneyType.DataBindings.Clear()
        cboMoneyType.DataBindings.Add(New Binding("Text", dsAccountDetail, "project_account_detail.type")) 'SelectedItem
    End Sub

    Protected Overrides Sub Affirm(ByVal ItemType As String, ByVal ItemCode As String)
        Dim dsProDoc As DataSet = gWs.GetProjectDocumentByCondition("{project_code='" & ProjectCode & "' and  item_type='" & ItemType & "' and item_code='" & ItemCode & "'}")
        Dim i As Integer = dsProDoc.Tables(0).Rows.Count
        If i = 0 Then
            Dim dr As DataRow = dsProDoc.Tables(0).NewRow
            With dr
                .Item("project_code") = ProjectCode
                .Item("phase") = MyBase.ReturnProjectPhase
                .Item("item_type") = ItemType
                .Item("item_code") = ItemCode
                .Item("check_person") = UserName
                .Item("check_date") = SystemDate.Date
                .Item("create_person") = UserName
                .Item("create_date") = SystemDate
                .Item("doc_name") = "顾问费收据"
            End With
            dsProDoc.Tables(0).Rows.Add(dr)
        Else
            dsProDoc.Tables(0).Rows(0)("phase") = MyBase.ReturnProjectPhase
            dsProDoc.Tables(0).Rows(0)("doc_name") = "顾问费收据"
            dsProDoc.Tables(0).Rows(0)("check_person") = UserName
            dsProDoc.Tables(0).Rows(0)("check_date") = SystemDate.Date
        End If
        Dim result As String = gWs.UpdateProjectDocument(dsProDoc.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "确认收取顾问费失败", result, "")
        End If
    End Sub

    Private Sub frmReviewFee_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        txtCorName.Text = CorporationName : txtProjectCode.Text = ProjectCode

        '2013-12-02 yjf edit 修改为融资顾问费
        IsFinancingConsultingFee = True
        item_type = "31" : item_code = "004"

        Try
            Me.Cursor = Cursors.WaitCursor

            SystemDate = gWs.GetSysTime
            dtpDate.Value = SystemDate.Date
            Me.BindPayManner()
            initializeAccountHandle()
            lblFeeType.Visible = False : cmbxType.Visible = False
            ''''取得项目经理或初审人员
            Dim dsMan As DataSet = New DataSet()
            dsMan = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
            txtManager.Text = dsMan.Tables(0).Rows(0)("24")
            If txtManager.Text <> String.Empty Then
                lblManager.Location = lblFirstMan.Location : txtManager.Location = txtFirstTrial.Location
                lblFirstMan.Visible = False : txtFirstTrial.Visible = False
            Else
                lblManager.Visible = False : txtManager.Visible = False
                'txtFirstTrial.Text = dsMan.Tables(0).Rows(0)("13")
            End If
            txtServiceType.DataBindings.Add("Text", dsMan, dsMan.Tables(0).TableName & ".ApplyServiceType")
            If txtServiceType.Text = String.Empty Then
                txtServiceType.DataBindings.Clear()
                txtServiceType.DataBindings.Add("Text", dsMan, dsMan.Tables(0).TableName & ".ServiceType")
            End If
            btnNew.Focus()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    'Design By zhoufucai    2006-4-24
    '装载收费方式
    Private Sub BindPayManner()
        Dim i As Integer
        Dim dsPayManner As DataSet = gWs.GetLoanChargeManner("%")
        If dsPayManner.Tables(0).Rows.Count > 0 Then
            For i = 0 To dsPayManner.Tables(0).Rows.Count - 1
                With dsPayManner.Tables(0).Rows(i)
                    Me.cboMoneyType.Items.Add(.Item("loan_charge_manner"))
                End With
            Next
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
        col3.HeaderText = "   缴费日期"
        col3.Width = 80
        col3.Format = "yyyy-MM-dd"
        col3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col3)
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  4
        col8.MappingName = "type"
        col8.HeaderText = "收取方式"
        col8.NullText = String.Empty
        col8.Width = 80
        dgts.GridColumnStyles.Add(col8)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2 
        col2.MappingName = "income"
        col2.HeaderText = "收取金额(元)"
        col2.Alignment = HorizontalAlignment.Right
        col2.NullText = String.Empty
        col2.Width = 100
        col2.Format = "c"
        col2.FormatInfo = CGFormatInfo
        dgts.GridColumnStyles.Add(col2)
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

    Private Sub btnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReport.Click
        If MyBase.strStatus <> String.Empty Then
            MyBase.SaveEvent(sender, e)
        End If
        If Me.dgMoney.CurrentRowIndex < 0 Then Return
        Dim drAccount As DataRow = CType(bmAccount.Current, DataRowView).Row

        Dim dsProject As DataSet = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
        If dsProject.Tables(0).Rows.Count = 0 Then Return
        Dim key() As String
        Dim value As ArrayList = New ArrayList()

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

            ht.Item("&#Addition") = Me.Tag

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
            ofrm1 = New frmDocumentManageBusiness(ProjectCode, TaskID, CorporationName, "45", "014", UserName, key, value)
            ofrm1.AllowTransparency = False
            ofrm1.Show()
            ofrm1.btnMakeDoc_Click(sender, e)
            ofrm1.Close()
        Catch ex As Exception
            SWDialogBox.MessageBox.Show("*999", "打开窗口调用方法出错", ex.Source, ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class
