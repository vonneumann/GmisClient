Public Class frmVouchApplicationExp
    Inherits MainInterface.frmRequestVouchApplication

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写 dispose 以清理组件列表。
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

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改此过程。
    '不要使用代码编辑器修改它。
    Public WithEvents btnQuery As System.Windows.Forms.Button
    Public WithEvents btnViewAffirmContent As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmVouchApplicationExp))
        Me.btnQuery = New System.Windows.Forms.Button
        Me.btnViewAffirmContent = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(536, 312)
        '
        'btnCommit
        '
        Me.btnCommit.Location = New System.Drawing.Point(376, 353)
        Me.btnCommit.Name = "btnCommit"
        '
        'btnUploadReport
        '
        Me.btnUploadReport.Location = New System.Drawing.Point(256, 353)
        Me.btnUploadReport.Name = "btnUploadReport"
        Me.btnUploadReport.Text = "制作展期申请书"
        '
        'btnConferenceTrial
        '
        Me.btnConferenceTrial.Location = New System.Drawing.Point(136, 353)
        Me.btnConferenceTrial.Name = "btnConferenceTrial"
        '
        'dgDatum
        '
        Me.dgDatum.Name = "dgDatum"
        Me.dgDatum.Size = New System.Drawing.Size(530, 292)
        '
        'Label1
        '
        Me.Label1.Name = "Label1"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Name = "txtProjectCode"
        '
        'txtEnterpriseName
        '
        Me.txtEnterpriseName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEnterpriseName.Name = "txtEnterpriseName"
        Me.txtEnterpriseName.Size = New System.Drawing.Size(304, 21)
        '
        'Label2
        '
        Me.Label2.Name = "Label2"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(464, 353)
        Me.btnExit.Name = "btnExit"
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuery.ImageIndex = 3
        Me.btnQuery.ImageList = Me.ImageListBasic
        Me.btnQuery.Location = New System.Drawing.Point(130, 352)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(118, 24)
        Me.btnQuery.TabIndex = 9
        Me.btnQuery.Text = "查看展期信息(&L)"
        Me.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnViewAffirmContent
        '
        Me.btnViewAffirmContent.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnViewAffirmContent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewAffirmContent.ImageIndex = 26
        Me.btnViewAffirmContent.ImageList = Me.ImageListBasic
        Me.btnViewAffirmContent.Location = New System.Drawing.Point(35, 352)
        Me.btnViewAffirmContent.Name = "btnViewAffirmContent"
        Me.btnViewAffirmContent.Size = New System.Drawing.Size(88, 23)
        Me.btnViewAffirmContent.TabIndex = 15
        Me.btnViewAffirmContent.Text = "查看材料(&V)"
        Me.btnViewAffirmContent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmVouchApplicationExp
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(554, 384)
        Me.Controls.Add(Me.btnViewAffirmContent)
        Me.Controls.Add(Me.btnQuery)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimizeBox = False
        Me.Name = "frmVouchApplicationExp"
        Me.Text = "呈请展期(展期)"
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.btnUploadReport, 0)
        Me.Controls.SetChildIndex(Me.btnConferenceTrial, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtProjectCode, 0)
        Me.Controls.SetChildIndex(Me.txtEnterpriseName, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.btnQuery, 0)
        Me.Controls.SetChildIndex(Me.btnViewAffirmContent, 0)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgDatum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private ds As DataSet
    Private Sub frmVouchApplicationExp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnConferenceTrial.Visible = False
    End Sub

    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim frmQueryProjectInfo As New frmShowProjectInfo(MyBase.getProjectCode, MyBase.getCorporationName)
            frmQueryProjectInfo.TabControl1.SelectedIndex = 9
            frmQueryProjectInfo.ShowDialog()
        Catch ex As Exception
            'MessageBox.Show("查看项目信息时出错！(" & ex.Message & ")", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            SWDialogBox.MessageBox.Show("$Login106")
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

#Region "查看材料"
    '双击材料DataGrid
    Private Sub dgDatum_DoubleClick(ByVal sender As System.Object, ByVal ne As System.EventArgs) Handles dgDatum.DoubleClick
        If Me.dgDatum.DataSource Is Nothing Then
            Return
        End If
        If Me.dgDatum(dgDatum.CurrentRowIndex, 4).ToString().Trim() = "" Then
            Return
        End If
        Dim bIsGuarantee As Boolean = False
        Select Case Me.dgDatum.Item(dgDatum.CurrentRowIndex, 4).ToString().Trim()
            Case "006"               '抵押登记已办妥并收齐相关文本及资料
                Dim f As New frmRegistryAffirm(Me.strProjectCode, True)
                f.AllowTransparency = False
                f.ShowDialog()
                bIsGuarantee = True
            Case "007"               '质押登记已办妥并收齐相关文本及资料
                Dim f As New frmPledgeRegistryAffirm(Me.strProjectCode, True)
                f.AllowTransparency = False
                f.ShowDialog()
                bIsGuarantee = True
            Case "008"               '抵押反担保物保险已办妥并注明中心为第一收益人(保险手续确认)
            Case "009"               '已办理财产处置先行授权并公证项(预典当手续确认)
            Case "011"               '互助会手续办理确认
            Case "013"               '监管手续确认
                Dim f As New frmWardAffirm(Me.strProjectCode, True)
                f.AllowTransparency = False
                f.ShowDialog()
                bIsGuarantee = True
            Case "014"               '法律文本确认
        End Select

        If Not bIsGuarantee Then
            Dim frm As New FViewConfirmItem(Me.strProjectCode, Me.dgDatum.Item(dgDatum.CurrentRowIndex, 4).ToString().Trim())
            frm.AllowTransparency = False
            frm.ShowDialog()
        End If
    End Sub
    '查看材料
    Private Sub btnViewAffirmContent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewAffirmContent.Click
        dgDatum_DoubleClick(Nothing, Nothing)
    End Sub

#End Region

    Private Sub btnUploadReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUploadReport.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            ds = gWs.GetServiceType("{service_type=(SELECT TOP 1 service_type FROM conference_trial WHERE project_code LIKE '" & Me.strProjectCode & "' AND status=1 ORDER BY trial_times DESC )}")
            If Not ds.Tables(0).Rows.Count = 0 Then
                'If ((((((((((ds.Tables(0).Rows(0).Item("service_type_code") = "01" Or ds.Tables(0).Rows(0).Item("service_type_code") = "03") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "04") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "05") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "06") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "07") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "08") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "09") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "10") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "11") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "18") Or _
                '    ds.Tables(0).Rows(0).Item("service_type_code") = "12") Then '担保放款通知书
                '    Call Me.UploadDocument01(Me.strProjectCode, "45", "010")
                'ElseIf ds.Tables(0).Rows(0).Item("service_type_code") = "02" Then   '委托放款通知书
                '    Call Me.UploadDocument02(Me.strProjectCode, "45", "009")
                'End If

                If ds.Tables(0).Rows(0).Item("service_type_code") = "02" Then
                    Call Me.UploadDocument02(Me.strProjectCode, "45", "009") '委托放款通知书
                Else
                    Call Me.UploadDocument01(Me.strProjectCode, "45", "010") '担保放款通知书
                End If
            Else
                SWDialogBox.MessageBox.Show("找不到与评审会数据中对应的业务品种!", "系统提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            SWDialogBox.MessageBox.Show("*999", ex.Source, ex.Message, ex.StackTrace)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
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

        'ds = gWs.FetchProjectCorporation("{project_code='" & ProjectCode & "'}")
        ds = gWs.FetchProjectCorporation(Me.getProjectCode(), "%", "1", Me.getPhase(getProjectCode()))
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(0) = IIf(.Item("corporation_name") Is System.DBNull.Value, "", .Item("corporation_name"))
                strReplaceTo(6) = strReplaceTo(0) : strReplaceTo(7) = strReplaceTo(0)
            End With
        End If
        ds = gWs.GetLoanNoticeInfo("{project_code='" & ProjectCode & "' order by create_date desc}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(1) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), Nothing)
                strReplaceTo(2) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), IIf(.Item("branch_bank") Is System.DBNull.Value, "", .Item("branch_bank")))
                strReplaceTo(8) = strReplaceTo(1) : strReplaceTo(9) = strReplaceTo(1)
                strReplaceTo(10) = strReplaceTo(2) : strReplaceTo(11) = strReplaceTo(2)

                'If System.Text.RegularExpressions.Regex.IsMatch(Me.cmbVouchAccount.Text, "^(-?\d+)(\.\d+)$") Then
                '    strReplaceTo(4) = (CDec(Me.cmbVouchAccount.Text) * 1000)
                'Else
                '    strReplaceTo(4) = ""
                'End If
                strReplaceTo(4) = ""
                'Sum = IIf(.Item("sum") Is System.DBNull.Value, 0, .Item("sum"))
                'strReplaceTo(4) = Money2String.Money2String.GetCnString(Convert.ToString(Sum * 10000)) + "(" + Money2String.Money2String.GetScienceString(Convert.ToString(Sum * 10000)) + ")"
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
        Dim arrReplaceTo As New ArrayList
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

        'ds = gWs.FetchProjectCorporation("{project_code='" & ProjectCode & "'}")
        ds = gWs.FetchProjectCorporation(Me.getProjectCode(), "%", "1", Me.getPhase(getProjectCode()))
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(0) = IIf(.Item("corporation_name") Is System.DBNull.Value, "", .Item("corporation_name"))
                strReplaceTo(6) = strReplaceTo(0)
                strReplaceTo(7) = strReplaceTo(0)
            End With
        End If
        ds = gWs.GetLoanNoticeInfo("{project_code='" & ProjectCode & "' order by create_date desc}")
        If Not ds.Tables(0).Rows.Count = 0 Then
            With ds.Tables(0).Rows(0)
                strReplaceTo(1) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), Nothing)
                strReplaceTo(2) = Me.GetBankName(IIf(.Item("bank") Is System.DBNull.Value, "", .Item("bank")), IIf(.Item("branch_bank") Is System.DBNull.Value, "", .Item("branch_bank")))
                strReplaceTo(8) = strReplaceTo(1) : strReplaceTo(9) = strReplaceTo(1)
                strReplaceTo(10) = strReplaceTo(2) : strReplaceTo(11) = strReplaceTo(2)

                'If System.Text.RegularExpressions.Regex.IsMatch(Me.cmbVouchAccount.Text, "^(-?\d+)(\.\d+)$") Then
                '    strReplaceTo(4) = (CDec(Me.cmbVouchAccount.Text) * 1000)
                'Else
                '    strReplaceTo(4) = ""
                'End If
                strReplaceTo(4) = ""
                'Sum = IIf(.Item("sum") Is System.DBNull.Value, 0, .Item("sum"))
                'strReplaceTo(4) = Money2String.Money2String.GetCnString(Convert.ToString(Sum * 10000)) + "(" + Money2String.Money2String.GetScienceString(Convert.ToString(Sum * 10000)) + ")"
                strReplaceTo(5) = Convert.ToString(IIf(.Item("term") Is System.DBNull.Value, 0, .Item("term"))) + "个月"
                strReplaceTo(12) = strReplaceTo(4)
                strReplaceTo(13) = strReplaceTo(5)
            End With
        End If
        strReplaceTo(3) = "                    "
        Dim arrReplaceTo As New ArrayList
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

    Private Function GetBankName(ByVal BankCode As String, ByVal BranchBankCode As String) As String
        Dim TempDS As DataSet
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

End Class
