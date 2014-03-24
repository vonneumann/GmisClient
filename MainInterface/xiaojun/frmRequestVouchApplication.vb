

Public Class frmRequestVouchApplication
    Inherits MainInterface.frmBusinessBaseWin

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
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents btnCommit As System.Windows.Forms.Button
    Public WithEvents dgDatum As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents btnUploadReport As System.Windows.Forms.Button
    Public WithEvents btnConferenceTrial As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmRequestVouchApplication))
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgDatum = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnUploadReport = New System.Windows.Forms.Button()
        Me.btnConferenceTrial = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtEnterpriseName.Location = New System.Drawing.Point(240, 8)
        Me.txtEnterpriseName.Size = New System.Drawing.Size(192, 21)
        Me.txtEnterpriseName.Visible = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(184, 16)
        Me.Label2.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Visible = True
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.SystemColors.HighlightText
        Me.txtProjectCode.Location = New System.Drawing.Point(64, 8)
        Me.txtProjectCode.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Location = New System.Drawing.Point(352, 232)
        Me.btnExit.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Location = New System.Drawing.Point(264, 232)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(80, 24)
        Me.btnCommit.TabIndex = 5
        Me.btnCommit.Text = "提交(&C)"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgDatum})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(424, 192)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'dgDatum
        '
        Me.dgDatum.CaptionVisible = False
        Me.dgDatum.DataMember = ""
        Me.dgDatum.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDatum.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDatum.Location = New System.Drawing.Point(3, 17)
        Me.dgDatum.Name = "dgDatum"
        Me.dgDatum.ReadOnly = True
        Me.dgDatum.Size = New System.Drawing.Size(418, 172)
        Me.dgDatum.TabIndex = 8
        Me.dgDatum.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgDatum
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn2, Me.DataGridBoolColumn1, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TItem"
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "确认材料名称"
        Me.DataGridTextBoxColumn2.MappingName = "item_name"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridBoolColumn1.AllowNull = False
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "材料是否完备"
        Me.DataGridBoolColumn1.MappingName = "IsFinished"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), System.DBNull)
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 120
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "检查人"
        Me.DataGridTextBoxColumn3.MappingName = "check_person"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "检查日期"
        Me.DataGridTextBoxColumn4.MappingName = "check_date"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "确认材料名称"
        Me.DataGridTextBoxColumn1.MappingName = "item_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'btnUploadReport
        '
        Me.btnUploadReport.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnUploadReport.Enabled = False
        Me.btnUploadReport.Location = New System.Drawing.Point(48, 232)
        Me.btnUploadReport.Name = "btnUploadReport"
        Me.btnUploadReport.Size = New System.Drawing.Size(104, 24)
        Me.btnUploadReport.TabIndex = 7
        Me.btnUploadReport.Text = "制作放款申请书"
        Me.btnUploadReport.Visible = False
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnConferenceTrial.Location = New System.Drawing.Point(160, 232)
        Me.btnConferenceTrial.Name = "btnConferenceTrial"
        Me.btnConferenceTrial.Size = New System.Drawing.Size(96, 24)
        Me.btnConferenceTrial.TabIndex = 8
        Me.btnConferenceTrial.Text = "评审会结论(&R)"
        '
        'frmRequestVouchApplication
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(442, 263)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.txtEnterpriseName, Me.txtProjectCode, Me.Label2, Me.Label1, Me.btnConferenceTrial, Me.btnUploadReport, Me.GroupBox1, Me.btnCommit})
        Me.Name = "frmRequestVouchApplication"
        Me.Text = "呈请放款申请书"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ds As New DataSet()
    Protected intReportType As Integer

    Protected Overridable Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub GetRequestVouchApplicationData()
        'Dim tempDS As New DataSet()
        'tempDS = gWs.GetCooperateOrganizationOpinion("{project_code like '" & Me.strProjectCode & "'}")
        'If Not tempDS.Tables(0).Rows.Count = 0 Then
        '    ds = gWs.GetItem("%", "44")
        'Else
        '    ds = gWs.GetItem("{item_code between '001' and '009'}", "44")
        'End If
        ds = gWs.GetItem("%", "44")
        If Not ds.Tables("TItem").Rows.Count = 0 Then
            Me.dgDatum.DataSource = Me.IsDatumFinished(ds).Tables(0).DefaultView
            Call setDgAttribute(Me.dgDatum, Me)
        End If
    End Sub

    Private Function IsDatumFinished(ByVal ds As DataSet) As DataSet
        Dim tempDS As New DataSet()
        Dim j As Integer
        tempDS = gWs.GetProjectDocumentByCondition("{project_code='" & Me.strProjectCode & "' and item_type='44' and check_person is not null}")
        '添加文档是否完整的标志字段。
        ds.Tables("TItem").Columns.Add(("IsFinished"), GetType(Boolean))
        '添加文档的检查人，检查日期字段。
        ds.Tables("TItem").Columns.Add(("check_person"), GetType(String))
        ds.Tables("TItem").Columns.Add(("check_date"), GetType(DateTime))

        For i = 0 To ds.Tables("TItem").Rows.Count - 1
            ds.Tables("TItem").Rows(i).Item("IsFinished") = False
        Next
        For i = 0 To tempDS.Tables(0).Rows.Count - 1
            Dim strItemType, strItemCode As String
            Dim strCheckPerson As String, dtCheckDate As DateTime
            strItemType = tempDS.Tables(0).Rows(i).Item("item_type")
            strItemCode = tempDS.Tables(0).Rows(i).Item("item_code")
            strCheckPerson = tempDS.Tables(0).Rows(i).Item("check_person")
            dtCheckDate = IIf(tempDS.Tables(0).Rows(i).Item("check_date") Is System.DBNull.Value, Now, tempDS.Tables(0).Rows(i).Item("check_date"))
            For j = 0 To ds.Tables("TItem").Rows.Count - 1
                With ds.Tables("TItem").Rows(j)
                    If strItemType = .Item("item_type") And strItemCode = .Item("item_code") Then
                        ds.Tables("TItem").Rows(j).Item("IsFinished") = True
                        ds.Tables("TItem").Rows(j).Item("check_person") = strCheckPerson
                        ds.Tables("TItem").Rows(j).Item("check_date") = dtCheckDate
                    End If
                End With
            Next
        Next
        Return ds
    End Function

    Private Sub frmRequestVouchApplication_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            AddHandler btnExit.Click, AddressOf btnExit_Click
            AddHandler btnCommit.Click, AddressOf btnCommit_Click
            Call Me.GetRequestVouchApplicationData()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Return
        End Try
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Protected Overridable Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'For i = 0 To CType(Me.dgDatum.DataSource, DataView).Count - 1
        '    If Me.dgDatum.Item(i, 1) = False Then
        '        MessageBox.Show("没有完整文档，无法提交。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '        Return
        '    End If
        'Next
        If Me.isCommitConfirm = True Then
            If MessageBox.Show("是否确认提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
                Return
            End If
        End If
        Call Me.CommitWorkFlow("", Me)
    End Sub
    '
    '打印Service_Type_Code='01' 放款通知书。担保放款通知书。
    '
    Private Sub UploadDocument01(ByVal ProjectCode As String, ByVal ItemType As String, ByVal ItemCode As String)
        Dim strReplaceFrom(14) As String, strReplaceTo(14) As String
        Dim Sum As Double
        strReplaceFrom(0) = "&#CorporationName"
        strReplaceFrom(1) = "&#BankName"
        strReplaceFrom(2) = "&#BranchBankName"
        strReplaceFrom(3) = "&#RefundAverage"
        strReplaceFrom(4) = "&#GuaranteeSum"
        strReplaceFrom(5) = "&#VouchTerminate"

        strReplaceFrom(6) = "&#ACorporationName"
        strReplaceFrom(7) = "&#BCorporationName"
        strReplaceFrom(8) = "&#ABankName"
        strReplaceFrom(9) = "&#BBankName"
        strReplaceFrom(10) = "&#ABranchBankName"
        strReplaceFrom(11) = "&#BBranchBankName"
        strReplaceFrom(12) = "&#AGuaranteeSum"
        strReplaceFrom(13) = "&#AVouchTerminate"
        strReplaceFrom(14) = "&#ARefundAverage"

        ds = gWs.FetchProjectCorporation("{project_code='" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(0) = IIf(.Item("corporation_name") Is System.DBNull.Value, "", .Item("corporation_name"))
                strReplaceTo(6) = strReplaceTo(0) : strReplaceTo(7) = strReplaceTo(0)
            End With
        End If
        ds = gWs.GetLoanNoticeInfo("{project_code='" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(1) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), Nothing)
                strReplaceTo(2) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), IIf(.Item("branch_bank") Is System.DBNull.Value, "", .Item("branch_bank")))
                strReplaceTo(8) = strReplaceTo(1) : strReplaceTo(9) = strReplaceTo(1)
                strReplaceTo(10) = strReplaceTo(2) : strReplaceTo(11) = strReplaceTo(2)
                Sum = IIf(.Item("sum") Is System.DBNull.Value, 0, .Item("sum"))
                strReplaceTo(4) = Money2String.Money2String.GetCnString(Convert.ToString(Sum * 10000)) + "(" + Money2String.Money2String.GetScienceString(Convert.ToString(Sum * 10000)) + ")"
                strReplaceTo(5) = Convert.ToString(IIf(.Item("term") Is System.DBNull.Value, 0, .Item("term"))) + "个月"
                strReplaceTo(12) = strReplaceTo(4) : strReplaceTo(13) = strReplaceTo(5)
            End With
        End If
        ds = gWs.GetConfTrialInfo("{project_code='" & ProjectCode & "' and trial_conclusion='通过'}", "null")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                Dim Temp As String
                Temp = IIf(.Item("refund_type") Is System.DBNull.Value, "", .Item("refund_type"))
                Sum = IIf(.Item("refund_sum_average") Is System.DBNull.Value, 0, .Item("refund_sum_average"))
                strReplaceTo(3) = Temp + Money2String.Money2String.GetCnString(Convert.ToString(Sum))
                strReplaceTo(14) = strReplaceTo(3)
            End With
        End If
        Dim arrReplaceTo As New ArrayList()
        For i = 0 To 14
            arrReplaceTo.Add(strReplaceTo(i))
        Next
        Dim frm As New frmDocumentManageBusiness(Me.strProjectCode, Me.strTaskID, Me.strEnterpriseName, ItemType, ItemCode, Me.strUserID, strReplaceFrom, arrReplaceTo)
        frm.AllowTransparency = False
        If Not Me.strTaskID = "LoanApplication" Then
            frm.setIsButtonEnable(True)
        End If
        frm.ShowDialog()
    End Sub
    '
    '打印Service_Type_Code='02' 放款通知书。委托放款通知书。
    '
    Private Sub UploadDocument02(ByVal ProjectCode As String, ByVal ItemType As String, ByVal ItemCode As String)
        Dim strReplaceFrom(14) As String, strReplaceTo(14) As String
        Dim Sum As Double
        strReplaceFrom(0) = "&#CorporationName"
        strReplaceFrom(1) = "&#BankName"
        strReplaceFrom(2) = "&#BranchBankName"
        strReplaceFrom(3) = "&#BankCreditNo"
        strReplaceFrom(4) = "&#GuaranteeSum"
        strReplaceFrom(5) = "&#VouchTerminate"

        strReplaceFrom(6) = "&#ACorporationName"
        strReplaceFrom(7) = "&#BCorporationName"
        strReplaceFrom(8) = "&#ABankName"
        strReplaceFrom(9) = "&#BBankName"
        strReplaceFrom(10) = "&#ABranchBankName"
        strReplaceFrom(11) = "&#BBranchBankName"
        strReplaceFrom(12) = "&#AGuaranteeSum"
        strReplaceFrom(13) = "&#AVouchTerminate"

        ds = gWs.FetchProjectCorporation("{project_code='" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(0) = IIf(.Item("corporation_name") Is System.DBNull.Value, "", .Item("corporation_name"))
                strReplaceTo(6) = strReplaceTo(0)
                strReplaceTo(7) = strReplaceTo(0)
            End With
        End If
        ds = gWs.GetLoanNoticeInfo("{project_code='" & ProjectCode & "'}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(1) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), Nothing)
                strReplaceTo(2) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), IIf(.Item("branch_bank") Is System.DBNull.Value, "", .Item("branch_bank")))
                strReplaceTo(8) = strReplaceTo(1) : strReplaceTo(9) = strReplaceTo(1)
                strReplaceTo(10) = strReplaceTo(2) : strReplaceTo(11) = strReplaceTo(2)
                Sum = IIf(.Item("sum") Is System.DBNull.Value, 0, .Item("sum"))
                strReplaceTo(4) = Money2String.Money2String.GetCnString(Convert.ToString(Sum * 10000)) + "(" + Money2String.Money2String.GetScienceString(Convert.ToString(Sum * 10000)) + ")"
                strReplaceTo(5) = Convert.ToString(IIf(.Item("term") Is System.DBNull.Value, 0, .Item("term"))) + "个月"
                strReplaceTo(12) = strReplaceTo(4)
                strReplaceTo(13) = strReplaceTo(5)
            End With
        End If
        strReplaceTo(3) = "                    "
        Dim arrReplaceTo As New ArrayList()
        For i = 0 To 14
            arrReplaceTo.Add(strReplaceTo(i))
        Next
        Dim frm As New frmDocumentManageBusiness(Me.strProjectCode, Me.strTaskID, Me.strEnterpriseName, ItemType, ItemCode, Me.strUserID, strReplaceFrom, arrReplaceTo)
        frm.AllowTransparency = False
        If Not Me.strTaskID = "LoanApplication" Then
            frm.setIsButtonEnable(True)
        End If
        frm.ShowDialog()
    End Sub

    Private Sub btnUploadReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadReport.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            ds = gWs.GetServiceType("{service_type=(select top 1 service_type from conference_trial where project_code like '" & Me.strProjectCode & "')}")
            If Not ds.Tables(0).Rows.Count = 0 Then
                If ((((((((((ds.Tables(0).Rows(0).Item("service_type_code") = "01" Or ds.Tables(0).Rows(0).Item("service_type_code") = "03") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "04") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "05") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "06") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "07") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "08") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "09") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "10") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "11") Or _
                    ds.Tables(0).Rows(0).Item("service_type_code") = "12") Then        '担保放款通知书
                    Call Me.UploadDocument01(Me.strProjectCode, "45", "010")
                ElseIf ds.Tables(0).Rows(0).Item("service_type_code") = "02" Then   '委托放款通知书
                    Call Me.UploadDocument02(Me.strProjectCode, "45", "009")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    Private Function GetBankName(ByVal BankCode As String, ByVal BranchBankCode As String) As String
        Dim TempDS As New DataSet()
        If BranchBankCode = Nothing Then    '取得银行名称。
            TempDS = gWs.GetBankInfo("{bank_code='" & BankCode & "'}", "null")
            If Not TempDS.Tables(0).Rows(0).Item("bank_name") Is System.DBNull.Value Then
                Return TempDS.Tables(0).Rows(0).Item("bank_name")
            End If
        Else    '取得银行支行名称
            TempDS = gWs.GetBankInfo("null", "{bank_code='" & BankCode & "' and branch_bank_code='" & BranchBankCode & "'}")
            If Not TempDS.Tables(1).Rows(0).Item("branch_bank_name") Is System.DBNull.Value Then
                Return TempDS.Tables(1).Rows(0).Item("branch_bank_name")
            End If
        End If
    End Function

    Private Sub btnConferenceTrial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConferenceTrial.Click
        Dim frm As New frmMeetRecordQuery(Me.strProjectCode, Me.strEnterpriseName)
        frm.AllowTransparency = False
        frm.ShowDialog()
    End Sub
End Class
