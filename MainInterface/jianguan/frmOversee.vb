Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml
Public Class frmOversee
    Inherits System.Windows.Forms.Form
    'Create by Daniel on 2013-8-22
    Private SqlConn As SqlClient.SqlConnection
    Private OverseeInfoBean As DataSet = New DataSet()
    Dim StartingDate, ClosingDate As DateTime
    'Dim SqlParamList As ArrayList
    Dim OptTableName As String
    Dim InfoTableName As String = "OverseeInfoGuaranteeProject"   'GuaranteeProjects
    Dim AppService As SqlService = New SqlService()
    Dim NeedRefreshReleasePro As Boolean
    Dim NeedRefreshCompensatePro As Boolean
    Dim NeedRefreshSubrogationPro As Boolean
    Dim NeedRefreshBankCredit As Boolean
    Dim NothingToDo As Boolean
    Private Sub frmOversee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '监管窗体调用
        StartingDate = CType(System.DateTime.Now, DateTime).ToShortDateString()
        ClosingDate = StartingDate
        OptTableName = "StatusDictionary"
        InfoTableName = "OverseeInfoGuaranteeProject"
        Dim strSql As String = "Select ReportStatus from OverseeInfoStatusDictionary"
        Dim SqlType As CommandType = CommandType.Text
        Me.OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, OptTableName, Nothing)

        GetHisLoanProject()
        ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetLoanProjectsFormat(OptTableName), Me.LoanProjectList)
        NeedRefreshReleasePro = True
        NeedRefreshCompensatePro = True
        NeedRefreshSubrogationPro = True
        NeedRefreshBankCredit = True
        GetOverseeInfo.Enabled = False
        SaveToXml.Enabled = False
        NothingToDo = True
    End Sub
    Private Sub StartDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles StartDate.LostFocus
        '上报起始日期事件处理
        GetOverseeInfo.Enabled = True
    End Sub
    Private Sub StartDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartDate.ValueChanged
        '上报起始日期变化事件处理
        NeedRefreshReleasePro = True
        NeedRefreshCompensatePro = True
        NeedRefreshSubrogationPro = True
    End Sub
    Private Sub EndDate_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles EndDate.LostFocus
        '上报截止日期事件处理
        GetOverseeInfo.Enabled = True
    End Sub
    Private Sub EndDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EndDate.ValueChanged
        '上报截止日期变化事件处理
        NeedRefreshReleasePro = True
        NeedRefreshCompensatePro = True
        NeedRefreshSubrogationPro = True
    End Sub
    Private Sub GetOverseeInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GetOverseeInfo.Click
        '获取上报信息按钮事件
        Dim SqlParamList As ArrayList
        OverseeTab.SelectTab(0)
        StartingDate = CType(Me.StartDate.Text, DateTime).ToShortDateString()
        ClosingDate = CType(Me.EndDate.Text, DateTime).ToShortDateString()
        SqlParamList = New ArrayList()
        SqlParamList.Add(New SqlClient.SqlParameter("@StartDate", StartingDate))
        SqlParamList.Add(New SqlClient.SqlParameter("@EndDate", ClosingDate))
        Dim ReportedProjects As Integer = CheckReportPeriod(SqlParamList)

        If ReportedProjects < 1 Then
            InfoTableName = "OverseeInfoGuaranteeProject"
            GetAllGuaranteeProject(SqlParamList)
            ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetLoanProjectsFormat(OptTableName), Me.LoanProjectList)

            GetLoanClients()
            ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetLoanClientsFormat(), Me.ClientList)
            GetOverseeInfo.Enabled = False
            SaveToXml.Enabled = True
        Else
            MessageBox.Show("所选上报区间已上报！不能重复上报！", "操作提示")
            GetOverseeInfo.Enabled = False
        End If
        SqlParamList = Nothing
    End Sub
    Private Sub OverseeTab_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles OverseeTab.SelectedIndexChanged
        '标签页切换事件处理
        Dim CurDataGrid As DataGridView = LoanProjectList
        Dim strFilter As String
        Dim i As Integer = OverseeTab.SelectedIndex()
        OverseeTab.SelectTab(i)  'if get TabName:OverseeTab.SelectedTab.Name
        Select Case i
            Case 0
                CurDataGrid = CandidateProjectList
                InfoTableName = "OverseeInfoGuaranteeProject"
                strFilter = "ReportStatus='上报'and CtrlStatus<>'已报'" '重复上报的不合理处理
                SplitOverseeInfo(CurDataGrid, SetLoanProjectsFormat(OptTableName), InfoTableName, strFilter)
                GetOverseeInfo.Enabled = False
            Case 1
                CurDataGrid = AbortProjectList
                InfoTableName = "OverseeInfoGuaranteeProject"
                strFilter = "ReportStatus='退保' and CtrlStatus='已报'" '上报未报的退保项目意味着上报作假
                SplitOverseeInfo(CurDataGrid, SetLoanProjectsFormat(OptTableName), InfoTableName, strFilter)
                GetOverseeInfo.Enabled = False
            Case 2
                CurDataGrid = ClientList
                InfoTableName = "KHXX"  'LoanClients
                strFilter = "1=1"
                Dim UnReportedProjects As ArrayList = New ArrayList()
                If Not OverseeInfoBean.Tables(InfoTableName) Is Nothing Then
                    If OverseeInfoBean.Tables(InfoTableName).Rows.Count > 0 Then
                        InfoTableName = "OverseeInfoGuaranteeProject"
                        For Each UnReportedProject As DataRow In OverseeInfoBean.Tables(InfoTableName).Select("ReportStatus<>'上报'")
                            UnReportedProjects.Add(UnReportedProject("XMBH"))
                        Next
                        InfoTableName = "KHXX"
                        OverseeInfoBean.Tables(InfoTableName).RejectChanges()   '撤销删除标记
                        For Each GuaranteeProject As DataRow In OverseeInfoBean.Tables(InfoTableName).Rows()
                            If UnReportedProjects.Contains(GuaranteeProject("XMBH")) Then
                                GuaranteeProject.Delete()
                            End If
                        Next
                        SplitOverseeInfo(CurDataGrid, SetLoanClientsFormat(), InfoTableName, strFilter)
                    End If
                End If
                GetOverseeInfo.Enabled = False
            Case 3
                CurDataGrid = ReleaseProjectList
                InfoTableName = "ZRJC"    'ReleaseProjects
                If NeedRefreshReleasePro Then GetReleaseProjects()
                ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetReleaseProjectsFormat(), CurDataGrid)
            Case 4
                CurDataGrid = CompensateProjectList
                InfoTableName = "DCHK"  'CompensateProjects
                If NeedRefreshCompensatePro Then GetCompensateProjects()
                ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetCompensateProjectsFormat(OptTableName), CurDataGrid)
            Case 5
                CurDataGrid = SubrogationProjectList
                InfoTableName = "ZHSS"   'SubrogationProjects
                If NeedRefreshSubrogationPro Then GetSubrogationProjects()
                ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetSubrogationProjectsFormat(OptTableName), CurDataGrid)
            Case 6
                CurDataGrid = CreditByBank
                InfoTableName = "YHSX"    'BankCredit
                If NeedRefreshBankCredit Then GetCreditByBank()
                ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetCreditByBankFormat(), CurDataGrid)
        End Select
    End Sub
    Private Sub LoanProjectList_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles LoanProjectList.CurrentCellChanged
        '项目上报状态变化事件处理
        InfoTableName = "OverseeInfoGuaranteeProject"
        Dim strFilter As String = "ReportStatus='上报'and CtrlStatus<>'已报'"
        SplitOverseeInfo(CandidateProjectList, SetLoanProjectsFormat(OptTableName), InfoTableName, strFilter)
    End Sub
    Private Sub ExitOversee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitOversee.Click
        If NothingToDo = False Then
            UpdateOverseeLoanProject()
            UpdateOverseeCreditByBank()
        End If
        Me.Close()
    End Sub

    Private Sub GetHisLoanProject()
        InfoTableName = "OverseeInfoGuaranteeProject"
        Dim strSql As String = "Select XMBH,BM,XH,JGMC,XKZBH,KHID,KHMC,KHLX,XMMC,YWLX,YWPZ,DKYTSUHY,CYYT,KSSJ,JSSJ,ZRJE,DBFJE,SXYHMC,YWPZFZ,ReportStatus,ReportStatus as CtrlStatus from OverseeInfoGuaranteeProject"
        Dim SqlType As CommandType = CommandType.Text
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
    End Sub
    Private Function CheckReportPeriod(ByVal SqlParamList As ArrayList) As Integer
        Dim ds As DataSet = New DataSet()
        InfoTableName = "ReportStatus"
        Dim strSql As String = "SELECT COUNT(*) AS ReportedProjects FROM OverseeInfoGuaranteeProject WHERE (KSSJ >=CONVERT(varchar(10) ,'" & StartingDate & "',120) ) AND (KSSJ < CONVERT(varchar(10) ,'" & ClosingDate & "',120))"
        Dim SqlType As CommandType = CommandType.Text
        ds = AppService.GetEntityBean(strSql, SqlType, ds, InfoTableName, Nothing)
        Return ds.Tables(InfoTableName).Rows(0).Item(0)
    End Function

    Private Sub GetAllGuaranteeProject(ByVal SqlParamList As ArrayList)
        Dim strSql As String = "OverseeAppendGuaranteeProject"
        InfoTableName = "OverseeInfoGuaranteeProject"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        AppService.UpdateEntityBean(strSql, SqlType, SqlParamList) 'Save to DBMS
        OverseeInfoBean.Tables(InfoTableName).Clear()
        GetHisLoanProject()
    End Sub
    Private Sub GetLoanClients()
        InfoTableName = "KHXX"
        'Delete the fetched Clients
        If Not OverseeInfoBean.Tables(InfoTableName) Is Nothing Then
            OverseeInfoBean.Tables(InfoTableName).Clear()
        End If

        Dim strSql As String = "OverseeForClient"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
    End Sub
    Private Sub GetReleaseProjects()
        'Delete the fetched ReleaseProjects
        Dim SqlParamList As New ArrayList()
        SqlParamList.Add(New SqlClient.SqlParameter("@StartDate", StartingDate))
        SqlParamList.Add(New SqlClient.SqlParameter("@EndDate", ClosingDate))

        If Not OverseeInfoBean.Tables(InfoTableName) Is Nothing Then
            OverseeInfoBean.Tables(InfoTableName).Clear()
        End If

        Dim strSql As String = "OverseeForReleaseProject"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, SqlParamList)
        NeedRefreshReleasePro = False
    End Sub
    Private Sub GetCompensateProjects()
        'Delete the fetched CompensateProjects
        Dim SqlParamList As New ArrayList()
        SqlParamList.Add(New SqlClient.SqlParameter("@StartDate", StartingDate))
        SqlParamList.Add(New SqlClient.SqlParameter("@EndDate", ClosingDate))

        If Not OverseeInfoBean.Tables(InfoTableName) Is Nothing Then
            OverseeInfoBean.Tables(InfoTableName).Clear()
        End If

        Dim strSql As String = "OverseeForCompensateProject"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, SqlParamList)
        NeedRefreshCompensatePro = False
    End Sub
    Private Sub GetCreditByBank()
        Dim strSql As String = "OverseeForBankCredit"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
        NeedRefreshBankCredit = False
    End Sub
    Private Sub GetSubrogationProjects()
        Dim SqlParamList As New ArrayList()
        SqlParamList.Add(New SqlClient.SqlParameter("@StartDate", StartingDate))
        SqlParamList.Add(New SqlClient.SqlParameter("@EndDate", ClosingDate))

        If Not OverseeInfoBean.Tables(InfoTableName) Is Nothing Then
            OverseeInfoBean.Tables(InfoTableName).Clear()
        End If

        Dim strSql As String = "OverseeForSubrogationProject"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, SqlParamList)
        NeedRefreshSubrogationPro = False
    End Sub
    Private Function SetTextColumnFormat(ByVal DPN As String, ByVal HeadTxt As String, ByVal ColName As String, ByVal RW As Boolean) As DataGridViewTextBoxColumn
        Dim ColumnFormat As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        With ColumnFormat
            .DataPropertyName = DPN
            .HeaderText = HeadTxt
            .Name = ColName
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .ReadOnly = RW
        End With
        Return ColumnFormat
    End Function
    Private Function SetComBoxColumnFormat(ByVal OptTableName As String, ByVal DPN As String, ByVal HeadTxt As String, ByVal ColName As String, ByVal RW As Boolean) As DataGridViewComboBoxColumn
        Dim ColumnFormat As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn()
        With ColumnFormat
            .DataPropertyName = DPN
            .DataSource = OverseeInfoBean.Tables(OptTableName)
            .HeaderText = HeadTxt
            .DisplayMember = ColName
            .AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            .ReadOnly = RW
        End With
        Return ColumnFormat
    End Function
    Private Sub ViewOverseeInfo(ByVal EntityBean As DataSet, ByVal TableName As String, ByVal ViewerFormat As ArrayList, ByVal InfoViewer As DataGridView)
        'Display information of table in EntityBean on InfoViewer according to ViewerFormat
        InfoViewer.AutoGenerateColumns = False
        InfoViewer.DataSource = EntityBean
        InfoViewer.Columns.Clear()
        For Each ColumnDispFormat As DataGridViewColumn In ViewerFormat
            InfoViewer.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {ColumnDispFormat})
        Next
        InfoViewer.DataMember = TableName
    End Sub
    Private Sub SplitOverseeInfo(ByVal opDataGrid As DataGridView, ByVal GridFormat As ArrayList, ByVal infoTableName As String, ByVal strFilter As String)
        OverseeInfoBean.Tables(infoTableName).DefaultView.RowFilter = strFilter
        With opDataGrid
            .AutoGenerateColumns = False
            .DataSource = OverseeInfoBean.Tables(infoTableName).DefaultView
            If OverseeInfoBean.Tables(infoTableName).Rows.Count() > 0 Then
                .Columns.Clear()
                For Each ColumnDispFormat As DataGridViewColumn In GridFormat
                    .Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {ColumnDispFormat})
                Next
            End If
            '.DataMember = TableName
        End With
    End Sub
    Private Sub GetOverseeInfoPackets()
        Dim strSql As String = "Select XMBH,BM,XH,JGMC,XKZBH,KHID,KHMC,KHLX,XMMC,YWLX,YWPZ,DKYTSUHY,CYYT,KSSJ,JSSJ,ZRJE,DBFJE,SXYHMC,YWPZFZ,ReportStatus from OverseeInfoGuaranteeProject"
        InfoTableName = "OverseeInfoGuaranteeProject"
        AppService.SaveEntityBean(strSql, OverseeInfoBean, InfoTableName)

        strSql = "Select XMBH,BM,XH,JGMC,XKZBH,KHID,KHMC,KHLX,XMMC,YWLX,YWPZ,DKYTSUHY,CYYT,Convert(varchar(10) , KSSJ, 120 ) As KSSJ,Convert(varchar(10) , JSSJ, 120 ) As JSSJ ,ZRJE,DBFJE,SXYHMC,YWPZFZ from OverseeInfoGuaranteeProject where ReportStatus='上报'"
        InfoTableName = "XMXX"
        Dim SqlType As CommandType = CommandType.Text
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
        SetXH(OverseeInfoBean, InfoTableName)

        strSql = "Select XMBH,BM,'VO' As VO,JGMC,XKZBH from OverseeInfoGuaranteeProject where ReportStatus='退保'"
        InfoTableName = "XMXXVO"
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
        'SetXH(OverseeInfoBean, InfoTableName)

        InfoTableName = "KHXX"
        OverseeInfoBean.Tables(InfoTableName).AcceptChanges()
        SetXH(OverseeInfoBean, InfoTableName)
    End Sub
    Private Sub SetXH(ByVal EntityBean As DataSet, ByVal TableName As String)
        Dim i As Integer = 0
        For Each dr As DataRow In EntityBean.Tables(TableName).Rows()
            i = i + 1
            If i <= 9 Then
                dr.Item("XH") = "0" + i.ToString
            Else
                dr.Item("XH") = i.ToString
            End If
        Next
    End Sub
    Private Sub LoanProjectsBeingAsReleaseProjects()
        Dim i, j, xh As Integer
        Dim dr As DataRow
        j = OverseeInfoBean.Tables("ZRJC").Rows.Count
        For i = 0 To OverseeInfoBean.Tables("XMXX").Rows.Count - 1
            dr = OverseeInfoBean.Tables("ZRJC").NewRow()
            dr.Item("XMBH") = OverseeInfoBean.Tables("XMXX").Rows(i).Item("XMBH")
            dr.Item("BM") = "zerenjiechu"
            xh = j + i + 1
            If xh <= 9 Then
                dr.Item("XH") = "0" + xh.ToString
            Else
                dr.Item("XH") = xh.ToString
            End If
            dr.Item("JGMC") = OverseeInfoBean.Tables("XMXX").Rows(i).Item("JGMC")
            dr.Item("XKZBH") = OverseeInfoBean.Tables("XMXX").Rows(i).Item("XKZBH")
            dr.Item("JCRQ") = OverseeInfoBean.Tables("XMXX").Rows(i).Item("JSSJ")
            dr.Item("JCJE") = 0
            dr.Item("FKJE") = OverseeInfoBean.Tables("XMXX").Rows(i).Item("ZRJE")
            dr.Item("FKRQ") = OverseeInfoBean.Tables("XMXX").Rows(i).Item("KSSJ")
            OverseeInfoBean.Tables("ZRJC").Rows.Add(dr)
        Next
    End Sub
    Private Sub UpdateOverseeLoanProject()
        Dim strSql As String = "OverSeeUpdateLoanProjectInfo"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        AppService.UpdateEntityBean(strSql, SqlType, Nothing)
    End Sub
    Private Sub UpdateOverseeCreditByBank()
        '更新银行授信协议
        Dim i As Integer
        Dim SqlParamValueList As ArrayList = New ArrayList()
        Dim SqlCmd As SqlCommand = SetParamsFormatOfUpdateBank()

        For i = 0 To OverseeInfoBean.Tables("YHSX").Rows.Count() - 1
            SqlParamValueList.Clear()
            SqlParamValueList.Add(OverseeInfoBean.Tables("YHSX").Rows(i).Item(0))
            SqlParamValueList.Add(OverseeInfoBean.Tables("YHSX").Rows(i).Item(2))
            SqlParamValueList.Add(OverseeInfoBean.Tables("YHSX").Rows(i).Item(3))
            SqlParamValueList.Add(OverseeInfoBean.Tables("YHSX").Rows(i).Item(4))
            SqlParamValueList.Add(OverseeInfoBean.Tables("YHSX").Rows(i).Item(5))
            SqlParamValueList.Add(OverseeInfoBean.Tables("YHSX").Rows(i).Item(6))
            AppService.UpdateRecordsBySP(SqlCmd, SqlParamValueList)
        Next
        AppService.CloseDBConnect()
        'OverseeInfoBean.AcceptChanges()
    End Sub
    Private Function SetParamsFormatOfUpdateBank() As SqlCommand
        '设置更新银行授信协议SQL语句的参数
        Dim strSql As String = "UpdateCreditByBank"
        Dim strSqlType As CommandType = CommandType.StoredProcedure
        Dim SqlParameterList As ArrayList = New ArrayList()
        SqlParameterList.Add(New SqlParameter("@sBankName", SqlDbType.NVarChar, 50, "Bank_Name"))
        SqlParameterList.Add(New SqlParameter("@sCreditLine", SqlDbType.Int, 4, "CreditLine"))
        SqlParameterList.Add(New SqlParameter("@sCreditStartDate", SqlDbType.DateTime, 8, "CreditStartDate"))
        SqlParameterList.Add(New SqlParameter("@sCreditEndDate", SqlDbType.DateTime, 8, "CreditEndDate"))
        SqlParameterList.Add(New SqlParameter("@sBail", SqlDbType.Decimal, 9, "Bail"))
        SqlParameterList.Add(New SqlParameter("@sPoolingOfRisks", SqlDbType.Float, 8, "PoolingOfRisks"))
        Return AppService.BuildSqlCommentParam(strSql, strSqlType, SqlParameterList)
    End Function

    Private Function SetLoanProjectsFormat(ByVal OptTableName As String) As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("XMBH", "项目编码", "XMBM", True))
        GridFormat.Add(SetTextColumnFormat("KHMC", "企业名称", "KHMC", True))
        GridFormat.Add(SetTextColumnFormat("YWPZFZ", "业务品种", "YWPZFZ", True))
        GridFormat.Add(SetTextColumnFormat("KSSJ", "放款日期", "KSSJ", False))
        GridFormat.Add(SetTextColumnFormat("JSSJ", "还款日期", "JSSJ", True))
        GridFormat.Add(SetTextColumnFormat("ZRJE", "担保金额", "ZRJE", True))
        GridFormat.Add(SetTextColumnFormat("DBFJE", "担保费金额", "DBFJE", True))
        GridFormat.Add(SetTextColumnFormat("SXYHMC", "放款银行", "SXYHMC", True))
        GridFormat.Add(SetComBoxColumnFormat(OptTableName, "ReportStatus", "上报状态", "ReportStatus", False))
        Return GridFormat
    End Function
    Private Function SetLoanClientsFormat() As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("XMBH", "项目编码", "XMBM", True))
        GridFormat.Add(SetTextColumnFormat("KHLX", "客户类型", "KHLX", True))
        GridFormat.Add(SetTextColumnFormat("KHID", "客户编码", "KHID", True))
        GridFormat.Add(SetTextColumnFormat("KHMC", "企业名称", "KHMC", True))
        GridFormat.Add(SetTextColumnFormat("ZZJGDM", "组织机构代码", "ZZJGDM", True))
        GridFormat.Add(SetTextColumnFormat("HYLX", "行业类型", "HYLX", True))
        GridFormat.Add(SetTextColumnFormat("DKKH", "贷款卡号", "DKKH", True))
        GridFormat.Add(SetTextColumnFormat("ZYYW", "主营业务", "ZYYW", True))
        GridFormat.Add(SetTextColumnFormat("CYRS", "从业人数", "CYRS", True))
        GridFormat.Add(SetTextColumnFormat("ZCZE", "资产总额", "ZCZE", True))
        GridFormat.Add(SetTextColumnFormat("FZZE", "负债总额", "FZZE", True))
        GridFormat.Add(SetTextColumnFormat("JLR", "净利润", "JLR", True))
        GridFormat.Add(SetTextColumnFormat("YHJKZE", "银行借款总额", "YHJKZE", True))
        GridFormat.Add(SetTextColumnFormat("XM", "姓名", "XM", True))
        GridFormat.Add(SetTextColumnFormat("SFZH", "身份证号", "SFZH", False))
        Return GridFormat
    End Function
    Private Function SetReleaseProjectsFormat() As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("XMBH", "项目编码", "XMBM", True))
        GridFormat.Add(SetTextColumnFormat("JGMC", "机构名称", "JGMC", True))
        GridFormat.Add(SetTextColumnFormat("XKZBH", "机构许可证编号", "XKZBH", False))
        GridFormat.Add(SetTextColumnFormat("JCRQ", "解除日期", "JCRQ", False))
        GridFormat.Add(SetTextColumnFormat("JCJE", "解除金额", "JCJE", False))
        GridFormat.Add(SetTextColumnFormat("FKJE", "放款金额", "FKJE", False))
        GridFormat.Add(SetTextColumnFormat("FKRQ", "放款日期", "FKRQ", False))
        Return GridFormat
    End Function
    Private Function SetCompensateProjectsFormat(ByVal OptTableName As String) As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("XMBH", "项目编码", "XMBM", True))
        GridFormat.Add(SetTextColumnFormat("JGMC", "机构名称", "JGMC", True))
        GridFormat.Add(SetTextColumnFormat("XKZBH", "机构许可证编号", "XKZBH", False))
        GridFormat.Add(SetTextColumnFormat("DCJE", "代偿金额", "DCJE", False))
        GridFormat.Add(SetTextColumnFormat("YZHDCJE", "已追回代偿金额", "YZHDCJE", False))
        GridFormat.Add(SetTextColumnFormat("WZHDCJE", "未追回代偿金额", "WZHDCJE", False))
        GridFormat.Add(SetTextColumnFormat("HKDZRQ", "还款到账日期", "HKDZRQ", False))
        GridFormat.Add(SetTextColumnFormat("HKJE", "还款金额", "HKJE", False))
        GridFormat.Add(SetTextColumnFormat("HKFS", "还款方式", "HKFS", False))
        GridFormat.Add(SetTextColumnFormat("HXRQ", "核销日期", "HXRQ", False))
        GridFormat.Add(SetComBoxColumnFormat(OptTableName, "ReportStatus", "上报状态", "ReportStatus", False))
        Return GridFormat
    End Function
    Private Function SetSubrogationProjectsFormat(ByVal OptTableName As String) As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("XMBH", "项目编码", "XMBM", True))
        GridFormat.Add(SetTextColumnFormat("JGMC", "机构名称", "JGMC", True))
        GridFormat.Add(SetTextColumnFormat("XKZBH", "机构许可证编号", "XKZBH", False))
        GridFormat.Add(SetTextColumnFormat("DZRQ", "到账日期", "DZRQ", False))
        GridFormat.Add(SetTextColumnFormat("WHSSJE", "挽回损失金额", "WHSSJE", False))
        GridFormat.Add(SetTextColumnFormat("WHSSFS", "挽回损失方式", "WHSSFS", False))
        GridFormat.Add(SetComBoxColumnFormat(OptTableName, "ReportStatus", "上报状态", "ReportStatus", False))
        Return GridFormat
    End Function
    Private Function SetCreditByBankFormat() As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("JRJGMC", "金融机构名称", "JRJGMC", True))
        GridFormat.Add(SetTextColumnFormat("SXED", "授信额度", "SXED", False))
        GridFormat.Add(SetTextColumnFormat("SXKSRQ", "授信开始日期", "SXKSRQ", False))
        GridFormat.Add(SetTextColumnFormat("SXJSRQ", "授信结束日期", "SXJSRQ", False))
        GridFormat.Add(SetTextColumnFormat("BZJ", "保证金", "BZJ", False))
        GridFormat.Add(SetTextColumnFormat("FXFD", "风险分担", "FXFD", False))
        GridFormat.Add(SetTextColumnFormat("JGMC", "机构名称", "JGMC", False))
        GridFormat.Add(SetTextColumnFormat("JGXKZBH", "机构许可证编号", "JGXKZBH", False))
        Return GridFormat
    End Function
    Private Sub SaveToXml_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveToXml.Click
        Dim FileDate As DateTime = System.DateTime.Now.Date
        Dim strPathName As String = "d:\lhcis\datacenter\data\" & FileDate.Year.ToString & FileDate.Month.ToString & FileDate.Day.ToString
        Dim strFileName As String = strPathName & "\8800256_buttJoint.xml"
        Dim OverseeFilePath As Directory
        If Not OverseeFilePath.Exists(strPathName) Then
            OverseeFilePath.CreateDirectory(strPathName)
        End If
        Dim XmlDoc As XmlTextWriter = New XmlTextWriter(strFileName, System.Text.Encoding.UTF8)
        XmlDoc.Formatting = Formatting.Indented
        XmlDoc.WriteStartDocument()

        XmlDoc.WriteStartElement("YWSJ")
        XmlDoc.WriteAttributeString("xsi:noNamespaceSchemaLocation", "yewu_date.xsd")
        XmlDoc.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance")
        Try
            GetOverseeInfoPackets()
            LoanProjectsBeingAsReleaseProjects()

            OverseeInfoBean.DataSetName = "XMXX_INFO"
            OverseeInfoBean.Tables("XMXX").WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)

            OverseeInfoBean.DataSetName = "XMXXVO_INFO"
            OverseeInfoBean.Tables("XMXXVO").WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)

            OverseeInfoBean.DataSetName = "KHXX_INFO"
            OverseeInfoBean.Tables("KHXX").WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)

            OverseeInfoBean.DataSetName = "ZRJC_INFO"
            OverseeInfoBean.Tables("ZRJC").WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)

            OverseeInfoBean.DataSetName = "DCHK_INFO"
            OverseeInfoBean.Tables("DCHK").WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)

            OverseeInfoBean.DataSetName = "ZHSS_INFO"
            OverseeInfoBean.Tables("ZHSS").WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)

            OverseeInfoBean.DataSetName = "YHSX_INFO"
            OverseeInfoBean.Tables("YHSX").WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)

            XmlDoc.WriteEndElement() 'End Root Element YWSJ
            XmlDoc.Close()
            SaveToXml.Enabled = False
            NothingToDo = False
        Catch ex As Exception
            MessageBox.Show("监管数据种类未选全，无法生成上报数据包，应用中止！", "操作提示")
            Me.Close()
        End Try
    End Sub
End Class