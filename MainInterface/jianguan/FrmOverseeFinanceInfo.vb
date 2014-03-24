Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Imports System.Xml
Public Class FrmOverseeFinanceInfo
    Inherits System.Windows.Forms.Form
    'Create by Daniel on 2013-9-22
    Private SqlConn As SqlClient.SqlConnection
    Private OverseeInfoBean As DataSet = New DataSet()
    Dim InfoTableName As String
    Dim AppService As SqlService = New SqlService()
    Private Sub FrmOverseeFinanceInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '监管窗体调用
        GetFinanceInfo()
        InfoTableName = "ZCFZ_INFO"
        ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetBalanceFormat(InfoTableName), Me.Balance)
    End Sub
    Private Sub Finance_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Finance.SelectedIndexChanged
        '标签页切换事件处理
        Dim CurDataGrid As DataGridView
        Dim i As Integer = Finance.SelectedIndex()
        Finance.SelectTab(i)
        Select Case i
            Case 0
                CurDataGrid = Me.Balance
                InfoTableName = "ZCFZ_INFO"
                ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetBalanceFormat(InfoTableName), CurDataGrid)
            Case 1
                CurDataGrid = Me.Income
                InfoTableName = "LR_INFO"
                ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetIncomeFormat(InfoTableName), CurDataGrid)
            Case 2
                CurDataGrid = Me.CashFlow
                InfoTableName = "XJLL_INFO"
                ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetCasherFormat(InfoTableName), CurDataGrid)
            Case 3
                CurDataGrid = Me.CashFlowSchedule
                InfoTableName = "XJLLFB_INFO"
                ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetCasherAttFormat(InfoTableName), CurDataGrid)
            Case 4
                CurDataGrid = Me.AccountBalance
                InfoTableName = "KMYE_INFO"
                ViewOverseeInfo(OverseeInfoBean, InfoTableName, SetAccountNetFormat(InfoTableName), CurDataGrid)
        End Select
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
    Private Function SetBalanceFormat(ByVal TableName As String) As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("KMBH", "科目编码", "KMBH", True))
        GridFormat.Add(SetTextColumnFormat("XMMC", "项目名称", "XMMC", True))
        GridFormat.Add(SetTextColumnFormat("HC", "行次", "HC", True))
        GridFormat.Add(SetTextColumnFormat("QMS", "期末数", "QMS", False))
        GridFormat.Add(SetTextColumnFormat("NCS", "年初数", "NCS", False))
        Return GridFormat
    End Function
    Private Function SetIncomeFormat(ByVal TableName As String) As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("KMBH", "科目编码", "KMBH", True))
        GridFormat.Add(SetTextColumnFormat("XMMC", "项目名称", "XMMC", True))
        GridFormat.Add(SetTextColumnFormat("HC", "行次", "HC", True))
        GridFormat.Add(SetTextColumnFormat("BQS", "本期数", "BQS", False))
        GridFormat.Add(SetTextColumnFormat("BNLJS", "本年累计数", "BNLJS", False))
        Return GridFormat
    End Function
    Private Function SetCasherFormat(ByVal TableName As String) As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("KMBH", "科目编码", "KMBH", True))
        GridFormat.Add(SetTextColumnFormat("XMMC", "项目名称", "XMMC", True))
        GridFormat.Add(SetTextColumnFormat("HC", "行次", "HC", True))
        GridFormat.Add(SetTextColumnFormat("BQJE", "本期金额", "BQJE", False))
        GridFormat.Add(SetTextColumnFormat("SQJE", "上期金额", "SQJE", False))
        Return GridFormat
    End Function
    Private Function SetCasherAttFormat(ByVal TableName As String) As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("KMBH", "科目编码", "KMBH", True))
        GridFormat.Add(SetTextColumnFormat("XMMC", "项目名称", "XMMC", True))
        GridFormat.Add(SetTextColumnFormat("HC", "行次", "HC", True))
        GridFormat.Add(SetTextColumnFormat("BQJE", "本期金额", "BQJE", False))
        GridFormat.Add(SetTextColumnFormat("SQJE", "上期金额", "SQJE", False))
        Return GridFormat
    End Function
    Private Function SetAccountNetFormat(ByVal TableName As String) As ArrayList
        Dim GridFormat As ArrayList = New ArrayList()
        GridFormat.Add(SetTextColumnFormat("KMBH", "科目编码", "KMBH", True))
        GridFormat.Add(SetTextColumnFormat("XMMC", "项目名称", "XMMC", True))
        GridFormat.Add(SetTextColumnFormat("QCYE_FX", "期初余额方向", "QCYE_FX", False))
        GridFormat.Add(SetTextColumnFormat("QCYE_JE", "期初余额金额", "QCYE_JE", False))
        GridFormat.Add(SetTextColumnFormat("BQJFFS", "本期借方发生", "BQJFFS", False))
        GridFormat.Add(SetTextColumnFormat("BQDFFS", "本期贷方发生", "BQDFFS", False))
        GridFormat.Add(SetTextColumnFormat("QMYE", "期末余额", "QMYE", False))
        GridFormat.Add(SetTextColumnFormat("BNJFLJ", "本年借方累计", "BNJFLJ", False))
        GridFormat.Add(SetTextColumnFormat("BNDFLJ", "本年贷方累计", "BNDFLJ", False))
        Return GridFormat
    End Function
    Private Sub GetFinanceInfo()
        InfoTableName = "ZCFZ_INFO"
        Dim strSql As String = "Select LTRIM(RTRIM(KMBH)) AS KMBH,LTRIM(RTRIM(XMMC)) AS XMMC,LTRIM(RTRIM(HC)) AS HC,QMS,NCS from OverseeInfoBlance"
        Dim SqlType As CommandType = CommandType.Text
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
        InfoTableName = "LR_INFO"
        strSql = "Select LTRIM(RTRIM(KMBH)) AS KMBH,LTRIM(RTRIM(XMMC)) AS XMMC,LTRIM(RTRIM(HC)) AS HC,BQS,BNLJS from OverseeInfoProfit"
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)

        InfoTableName = "XJLL_INFO"
        strSql = "Select LTRIM(RTRIM(KMBH)) AS KMBH,LTRIM(RTRIM(XMMC)) AS XMMC,LTRIM(RTRIM(HC)) AS HC,BQJE,SQJE from OverseeInfoCasher"
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)

        InfoTableName = "XJLLFB_INFO"
        strSql = "Select LTRIM(RTRIM(KMBH)) AS KMBH,LTRIM(RTRIM(XMMC)) AS XMMC,LTRIM(RTRIM(HC)) AS HC,BQJE,SQJE from OverseeInfoCasherAtt"
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)

        InfoTableName = "KMYE_INFO"
        strSql = "Select LTRIM(RTRIM(KMBH)) AS KMBH,LTRIM(RTRIM(XMMC)) AS XMMC,LTRIM(RTRIM(QCYE_FX)) AS QCYE_FX,QCYE_JE,BQJFFS,BQDFFS,QMYE,BNJFLJ,BNDFLJ from OverseeInfoAccountNet"
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
    End Sub
    Private Sub SaveOverseeFinanceInfo()
        'Table must has Prime key
        InfoTableName = "ZCFZ_INFO"
        Dim strSql As String = "Select * from OverseeInfoBlance"
        AppService.SaveEntityBean(strSql, OverseeInfoBean, InfoTableName)
        InfoTableName = "LR_INFO"
        strSql = "Select * from OverseeInfoProfit"
        AppService.SaveEntityBean(strSql, OverseeInfoBean, InfoTableName)
        InfoTableName = "XJLL_INFO"
        strSql = "Select * from OverseeInfoCasher"
        AppService.SaveEntityBean(strSql, OverseeInfoBean, InfoTableName)
        InfoTableName = "XJLLFB_INFO"
        strSql = "Select * from OverseeInfoCasherAtt"
        AppService.SaveEntityBean(strSql, OverseeInfoBean, InfoTableName)
        InfoTableName = "KMYE_INFO"
        strSql = "Select * from OverseeInfoAccountNet"
        AppService.SaveEntityBean(strSql, OverseeInfoBean, InfoTableName)
    End Sub
    Private Sub GeneratePacket_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneratePacket.Click
        Dim FileDate As DateTime = System.DateTime.Now.Date
        Dim XmlTable As DataTable
        Dim XmlDataSet As DataSet = New DataSet("NR_INFO")
        Dim strPathName As String = Application.StartupPath + "\" & FileDate.Year.ToString & FileDate.Month.ToString & FileDate.Day.ToString
        Dim strFileName As String = strPathName & "\8800256_caiwu.xml"
        If Not Directory.Exists(strPathName) Then
            Directory.CreateDirectory(strPathName)
        End If
        'Dim MyxmlSettings As XmlWriterSettings = New XmlWriterSettings()
        'MyxmlSettings.Encoding = System.Text.Encoding.UTF8
        'MyxmlSettings.Indent = True
        'MyxmlSettings.NewLineOnAttributes = True
        Dim XmlDoc As XmlTextWriter = New XmlTextWriter(strFileName, System.Text.Encoding.UTF8)
        XmlDoc.Formatting = Formatting.Indented
        XmlDoc.WriteStartDocument()

        XmlDoc.WriteStartElement("CWSJ")
        XmlDoc.WriteAttributeString("xsi:noNamespaceSchemaLocation", "caiwu_date.xsd")
        XmlDoc.WriteAttributeString("xmlns:xsi", "http://www.w3.org/2001/XMLSchema-instance")

        XmlDoc.WriteStartElement("QICI")
        XmlDoc.WriteAttributeString("attributes", Me.ReportPeriod.Text)

        XmlTable = OverseeInfoBean.Tables("LR_INFO").Copy()
        XmlDataSet.Tables.Add(XmlTable)
        XmlDoc.WriteStartElement("LR_INFO")
        XmlDoc.WriteElementString("QC", Me.ReportPeriod.Text)
        XmlDoc.WriteElementString("BM", "lirun")
        XmlDoc.WriteElementString("XH", "01")
        XmlDoc.WriteElementString("KMZS", XmlTable.Rows.Count().ToString())
        XmlTable.TableName = "NR"
        XmlTable.WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)
        XmlDoc.WriteEndElement()  'End Node Element LR
        XmlDataSet.Tables.Remove(XmlTable)

        XmlTable = OverseeInfoBean.Tables("ZCFZ_INFO").Copy()
        XmlDataSet.Tables.Add(XmlTable)
        XmlDoc.WriteStartElement("ZCFZ_INFO")
        XmlDoc.WriteElementString("QC", Me.ReportPeriod.Text)
        XmlDoc.WriteElementString("BM", "zichan")
        XmlDoc.WriteElementString("XH", "01")
        XmlDoc.WriteElementString("KMZS", XmlTable.Rows.Count().ToString())
        XmlTable.TableName = "NR"
        XmlTable.WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)
        XmlDoc.WriteEndElement()  'End Node Element ZCFZ
        XmlDataSet.Tables.Remove(XmlTable)

        XmlTable = OverseeInfoBean.Tables("XJLL_INFO").Copy()
        XmlDataSet.Tables.Add(XmlTable)
        XmlDoc.WriteStartElement("XJLL_INFO")
        XmlDoc.WriteElementString("QC", Me.ReportPeriod.Text)
        XmlDoc.WriteElementString("BM", "xjll")
        XmlDoc.WriteElementString("XH", "01")
        XmlDoc.WriteElementString("KMZS", XmlTable.Rows.Count().ToString())
        XmlTable.TableName = "NR"
        XmlTable.WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)
        XmlDoc.WriteEndElement()  'End Node Element XJLL
        XmlDataSet.Tables.Remove(XmlTable)

        XmlTable = OverseeInfoBean.Tables("XJLLFB_INFO").Copy()
        XmlDataSet.Tables.Add(XmlTable)
        XmlDoc.WriteStartElement("XJLLFB_INFO")
        XmlDoc.WriteElementString("QC", Me.ReportPeriod.Text)
        XmlDoc.WriteElementString("BM", "xjllfsb")
        XmlDoc.WriteElementString("XH", "01")
        XmlDoc.WriteElementString("KMZS", XmlTable.Rows.Count().ToString())
        XmlTable.TableName = "NR"
        XmlTable.WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)
        XmlDoc.WriteEndElement()   'End Node Element XJLLFB
        XmlDataSet.Tables.Remove(XmlTable)

        XmlTable = OverseeInfoBean.Tables("KMYE_INFO").Copy()
        XmlDataSet.Tables.Add(XmlTable)
        XmlDoc.WriteStartElement("KMYE_INFO")
        XmlDoc.WriteElementString("QC", Me.ReportPeriod.Text)
        XmlDoc.WriteElementString("BM", "kmye")
        XmlDoc.WriteElementString("XH", "01")
        XmlDoc.WriteElementString("KMZS", XmlTable.Rows.Count().ToString())
        XmlTable.TableName = "NR"
        XmlTable.WriteXml(XmlDoc, XmlWriteMode.IgnoreSchema)
        XmlDoc.WriteEndElement() 'End Node Element KMYE

        XmlDoc.WriteEndElement() 'End Node Element QICI
        XmlDoc.WriteEndElement() 'End Root Element YWSJ
        XmlDoc.Close()
    End Sub
    Private Sub ExtButtom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtButtom.Click
        SaveOverseeFinanceInfo()
        Me.Close()
    End Sub
End Class