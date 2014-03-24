'作者：罗庆锋；日期2003-04-11
Public Class frmGuarantFee
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
    Friend WithEvents txtGuarantyFee As System.Windows.Forms.TextBox
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtManager As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cboMoneyType As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnReport As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmGuarantFee))
        Me.txtGuarantyFee = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtManager = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboMoneyType = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.gpbxDetail.SuspendLayout()
        Me.gpbxResult.SuspendLayout()
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNew
        '
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageIndex = -1
        Me.btnNew.ImageList = Nothing
        Me.btnNew.Location = New System.Drawing.Point(104, 320)
        Me.btnNew.Size = New System.Drawing.Size(75, 24)
        Me.btnNew.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageIndex = -1
        Me.btnCommit.ImageList = Nothing
        Me.btnCommit.Location = New System.Drawing.Point(424, 320)
        Me.btnCommit.Size = New System.Drawing.Size(75, 24)
        Me.btnCommit.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageIndex = -1
        Me.btnSave.ImageList = Nothing
        Me.btnSave.Location = New System.Drawing.Point(344, 320)
        Me.btnSave.Size = New System.Drawing.Size(75, 24)
        Me.btnSave.Visible = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(200, 11)
        Me.Label5.Visible = True
        '
        'btnModify
        '
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Bitmap)
        Me.btnModify.ImageIndex = -1
        Me.btnModify.ImageList = Nothing
        Me.btnModify.Location = New System.Drawing.Point(184, 320)
        Me.btnModify.Size = New System.Drawing.Size(75, 24)
        Me.btnModify.Visible = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(16, 11)
        Me.Label6.Size = New System.Drawing.Size(72, 14)
        Me.Label6.Text = "项 目 编 码"
        Me.Label6.Visible = True
        '
        'Label3
        '
        Me.Label3.Visible = True
        '
        'gpbxDetail
        '
        Me.gpbxDetail.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label4, Me.cboMoneyType})
        Me.gpbxDetail.Location = New System.Drawing.Point(8, 224)
        Me.gpbxDetail.Visible = True
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(448, 13)
        Me.txtIncome.Size = New System.Drawing.Size(120, 21)
        Me.txtIncome.TabIndex = 2
        Me.txtIncome.Visible = True
        '
        'lblFeeType
        '
        Me.lblFeeType.Location = New System.Drawing.Point(672, 16)
        Me.lblFeeType.Size = New System.Drawing.Size(40, 16)
        Me.lblFeeType.Visible = True
        '
        'txtSummary
        '
        Me.txtSummary.TabIndex = 3
        Me.txtSummary.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(104, 8)
        Me.txtProjectCode.Size = New System.Drawing.Size(88, 21)
        Me.txtProjectCode.Visible = True
        '
        'btnDelete
        '
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageIndex = -1
        Me.btnDelete.ImageList = Nothing
        Me.btnDelete.Location = New System.Drawing.Point(264, 320)
        Me.btnDelete.Size = New System.Drawing.Size(75, 24)
        Me.btnDelete.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'gpbxResult
        '
        Me.gpbxResult.Location = New System.Drawing.Point(8, 56)
        Me.gpbxResult.Size = New System.Drawing.Size(576, 168)
        Me.gpbxResult.Visible = True
        '
        'cmbxType
        '
        Me.cmbxType.DropDownWidth = 40
        Me.cmbxType.ItemHeight = 12
        Me.cmbxType.Location = New System.Drawing.Point(728, 16)
        Me.cmbxType.Size = New System.Drawing.Size(40, 20)
        Me.cmbxType.Visible = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(368, 16)
        Me.Label1.Size = New System.Drawing.Size(79, 14)
        Me.Label1.Visible = True
        '
        'txtCorName
        '
        Me.txtCorName.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)
        Me.txtCorName.Location = New System.Drawing.Point(264, 8)
        Me.txtCorName.Visible = True
        '
        'dtpDate
        '
        Me.dtpDate.Value = New Date(2003, 4, 7, 20, 1, 28, 765)
        Me.dtpDate.Visible = True
        '
        'dgMoney
        '
        Me.dgMoney.AccessibleName = "DataGrid"
        Me.dgMoney.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgMoney.Size = New System.Drawing.Size(570, 148)
        Me.dgMoney.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(504, 320)
        Me.btnExit.Size = New System.Drawing.Size(75, 24)
        Me.btnExit.Visible = True
        '
        'txtGuarantyFee
        '
        Me.txtGuarantyFee.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuarantyFee.Location = New System.Drawing.Point(104, 35)
        Me.txtGuarantyFee.Name = "txtGuarantyFee"
        Me.txtGuarantyFee.ReadOnly = True
        Me.txtGuarantyFee.Size = New System.Drawing.Size(88, 21)
        Me.txtGuarantyFee.TabIndex = 27
        Me.txtGuarantyFee.Text = ""
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "应收担保费(元)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBalance.ForeColor = System.Drawing.Color.Red
        Me.txtBalance.Location = New System.Drawing.Point(264, 35)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(88, 21)
        Me.txtBalance.TabIndex = 29
        Me.txtBalance.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(200, 37)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "差   额"
        '
        'txtManager
        '
        Me.txtManager.BackColor = System.Drawing.Color.Gainsboro
        Me.txtManager.Location = New System.Drawing.Point(432, 35)
        Me.txtManager.Name = "txtManager"
        Me.txtManager.ReadOnly = True
        Me.txtManager.Size = New System.Drawing.Size(72, 21)
        Me.txtManager.TabIndex = 33
        Me.txtManager.Text = ""
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(360, 37)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 17)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "项目经理A角"
        '
        'cboMoneyType
        '
        Me.cboMoneyType.Enabled = False
        Me.cboMoneyType.Location = New System.Drawing.Point(240, 13)
        Me.cboMoneyType.MaxLength = 10
        Me.cboMoneyType.Name = "cboMoneyType"
        Me.cboMoneyType.Size = New System.Drawing.Size(112, 20)
        Me.cboMoneyType.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(184, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 14)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "收费方式"
        '
        'btnReport
        '
        Me.btnReport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnReport.Image = CType(resources.GetObject("btnReport.Image"), System.Drawing.Bitmap)
        Me.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnReport.ImageIndex = 23
        Me.btnReport.ImageList = Me.ImageListBasic
        Me.btnReport.Location = New System.Drawing.Point(24, 320)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(77, 23)
        Me.btnReport.TabIndex = 34
        Me.btnReport.Text = "打 印(&P)"
        Me.btnReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmGuarantFee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(592, 351)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label5, Me.Label6, Me.gpbxDetail, Me.btnExit, Me.btnCommit, Me.btnNew, Me.btnModify, Me.btnDelete, Me.btnSave, Me.txtCorName, Me.txtProjectCode, Me.gpbxResult, Me.btnReport, Me.txtManager, Me.Label10, Me.txtBalance, Me.Label8, Me.txtGuarantyFee, Me.Label7})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmGuarantFee"
        Me.Text = "收取担保费"
        Me.gpbxDetail.ResumeLayout(False)
        Me.gpbxResult.ResumeLayout(False)
        CType(Me.dgMoney, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    '担保费
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
        txtGuarantyFee.Text = RemoveSomeRecord().ToString("n")
        btnDelete.Enabled = (dgMoney.CurrentRowIndex >= 0)
        btnModify.Enabled = btnDelete.Enabled
    End Sub
    '删掉payout不为零的记录
    Protected Overrides Function RemoveSomeRecord() As Double
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
        txtBalance.Text = (CDbl(txtGuarantyFee.Text) - incomeSum).ToString("n")
        LessMoney = CDbl(txtGuarantyFee.Text) - incomeSum
    End Sub

    Protected Overrides Sub SetObjEnabled(ByVal IsEnabled As Boolean)
        MyBase.SetObjEnabled(IsEnabled)
        cboMoneyType.Enabled = IsEnabled
        If IsEnabled Then
            'cboMoneyType.Text = cboMoneyType.Items(0).ToString
            CType(bmaccount.Current, DataRowView)("type") = cboMoneyType.Text
        End If
    End Sub

    Protected Overrides Sub IniBindingForAccount()
        MyBase.IniBindingForAccount()
        cboMoneyType.DataBindings.Clear()
        cboMoneyType.DataBindings.Add(New Binding("Text", dsAccountDetail, "project_account_detail.type")) 'SelectedItem
    End Sub

    Protected Overrides Function OtherOperationSuccess() As Boolean
        '如果是再担保品种，中心收到保费日期为中心再担保责任起始日
        '插入 “再担保起始日”和“终止日” 到TProjectOrganization
        Dim dsTrial As DataSet = gWs.GetConfTrialInfo("{project_code LIKE '" & ProjectCode & "' AND trial_conclusion LIKE '通过' ORDER BY trial_times DESC}", "")
        If dsTrial.Tables("conference_trial").Rows.Count > 0 Then
            If CStr(dsTrial.Tables("conference_trial").Rows(0)("service_type") & "").IndexOf("再担保") >= 0 Then
                Dim dsProjectOrga As DataSet = gWs.GetProjectOrganization("{project_code LIKE '" & ProjectCode & "'}")
                If dsProjectOrga.Tables(0).Rows.Count > 0 AndAlso dsAccountDetail.Tables(0).Rows.Count > 0 Then
                    Dim StartDate As Date = DateTime.Parse(dsAccountDetail.Tables(0).Rows(0)("date"))
                    Dim terms As Object = dsTrial.Tables("conference_trial").Rows(0)("terms")
                    Dim EndDate As Date = StartDate.AddMonths(CInt(IIf(IsDBNull(terms), 0, terms)))
                    dsProjectOrga.Tables(0).Rows(0)("StartDate") = StartDate.Date
                    dsProjectOrga.Tables(0).Rows(0)("EndDate") = EndDate.Date
                End If
                If dsProjectOrga.HasChanges Then
                    Dim result As String = gWs.UpdateProjectOrganization(dsProjectOrga.GetChanges)
                    If result <> "1" Then
                        SWDialogBox.MessageBox.Show("*999", "保存TProjectOrganization表失败", result, "")
                        Return False
                    End If
                End If
            End If
        End If
        Return True
    End Function

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
                .Item("create_date") = SystemDate.Date
                .Item("doc_name") = "担保费收据"
            End With
            dsProDoc.Tables(0).Rows.Add(dr)
        Else
            dsProDoc.Tables(0).Rows(0)("phase") = MyBase.ReturnProjectPhase
            dsProDoc.Tables(0).Rows(0)("doc_name") = "担保费收据"
            dsProDoc.Tables(0).Rows(0)("check_person") = UserName
            dsProDoc.Tables(0).Rows(0)("check_date") = SystemDate.Date
        End If
        Dim result As String = gWs.UpdateProjectDocument(dsProDoc.GetChanges)
        If result <> "1" Then
            SWDialogBox.MessageBox.Show("*999", "确认收取担保费失败", result, "")
        End If
    End Sub

    Private Sub frmGuarantFee_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            Me.Cursor = Cursors.WaitCursor
            txtCorName.Text = CorporationName : txtProjectCode.Text = ProjectCode
            IsGuarantyFee = True
            item_type = "31" : item_code = "002"

            SystemDate = gWs.GetSysTime
            dtpDate.Value = systemdate.Date
            Me.BindPayManner()
            initializeAccountHandle()
            lblFeeType.Visible = False : cmbxType.Visible = False
            ''''取得项目经理
            Dim dsMan As DataSet = New DataSet()
            dsMan = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}")
            txtManager.Text = dsMan.Tables(0).Rows(0)("24")

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
        col2.NullText = ""
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
            ht.Item("&#RegisterDate") = systemdate.Date.ToString("yyyy年M月d日")
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
            ht.Item("&#RD2") = systemdate.Date.ToString("yyyy年M月d日")
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
            ofrm1 = New frmDocumentManageBusiness(ProjectCode, TaskID, CorporationName, "45", "015", UserName, key, value)
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
