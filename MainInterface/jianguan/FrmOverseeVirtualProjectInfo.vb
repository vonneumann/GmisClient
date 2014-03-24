Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.IO
Imports System.Xml
Imports nsExcel = Microsoft.Office.Interop.Excel

Public Class FrmOverseeVirtualProjectInfo
    Inherits System.Windows.Forms.Form
    Private SqlConn As SqlClient.SqlConnection
    Private OverseeInfoBean As DataSet = New DataSet()
    Dim StartingDate As DateTime
    Dim InfoTableName As String
    Dim xlDocName As String = "d:\lhcis\datacenter\data\跨年项目.xls"
    Dim AppService As SqlService = New SqlService()
  
    Private Sub FrmOverseeVirtualProjectInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        StartingDate = CType(System.DateTime.Now, DateTime).ToShortDateString()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles botton1.Click
        '跨年项目导入EXCEL
        Dim SqlParamList As New ArrayList()
        SqlParamList.Add(New SqlClient.SqlParameter("@StartDate", StartingDate))
        GetOverseeInfoPackets(SqlParamList)
        WriteToXls()
    End Sub
    Private Sub GetVirtualProject(ByVal sqlParamList As ArrayList)
        Dim strSql As String = "OverseeAppendVirtualProject"
        InfoTableName = "OverseeInfoGuaranteeProject"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        Me.OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, sqlParamList)
    End Sub
    Private Sub DelVirtualProject()
        Dim strSql As String = "delete from OverseeInfoVirtualProject"
        Dim SqlType As CommandType = CommandType.Text
        AppService.UpdateEntityBean(strSql, SqlType, Nothing)
    End Sub
    Private Sub GetCreditByBank()
        Dim strSql As String = "OverseeForBankCredit"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        InfoTableName = "YHSX"
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
    End Sub
    Private Sub GetOverseeInfoPackets(ByVal sqlParamList As ArrayList)
        Dim strSql As String
        Dim SqlType As CommandType
        strSql = "OverseeAppendVirtualProject"
        InfoTableName = "OverseeInfoVirtualProject"
        SqlType = CommandType.StoredProcedure
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, sqlParamList)

        strSql = "Select XMBH,BM,XH,JGMC,XKZBH,KHID,KHMC,KHLX,XMMC,YWLX,YWPZ,DKYTSUHY,CYYT,Convert(varchar(10) , KSSJ, 120 ) As KSSJ,Convert(varchar(10) , JSSJ, 120 ) As JSSJ,ZRJE,DBFJE,SXYHMC,YWPZFZ from OverseeInfoVirtualProject"
        InfoTableName = "XMXX"
        SqlType = CommandType.Text
        AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
        SetXH(OverseeInfoBean, InfoTableName)

        InfoTableName = "KHXX"
        strSql = "OverseeForVirtualClient"
        SqlType = CommandType.StoredProcedure
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
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
    Private Sub GetLoanClients()
        Dim strSql As String = "OverseeForClient"
        Dim SqlType As CommandType = CommandType.StoredProcedure
        OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
    End Sub
    Private Sub ReportDate_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ReportDate.ValueChanged
        StartingDate = CType(Me.ReportDate.Text, DateTime).ToShortDateString()
    End Sub
    
    Private Sub LoanProjectsBeingAsReleaseProjects()
        Dim i, j, xh As Integer
        Dim dr As DataRow
        InfoTableName = "ZRJC"
        j = OverseeInfoBean.Tables(InfoTableName).Rows.Count
        For i = 0 To OverseeInfoBean.Tables("XMXX").Rows.Count - 1
            dr = OverseeInfoBean.Tables(InfoTableName).NewRow()
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
            OverseeInfoBean.Tables(InfoTableName).Rows.Add(dr)
        Next
        For Each dr In OverseeInfoBean.Tables(InfoTableName).Rows()
            dr.Item(5) = Convert.ToDateTime(dr.Item(5)).ToString("yyyy-MM-dd")
            dr.Item(8) = Convert.ToDateTime(dr.Item(8)).ToString("yyyy-MM-dd")
        Next
    End Sub
    Private Sub WriteToXls()
        'Dim xlExcel As nsExcel.Application = New nsExcel.Application()
        'Dim xlWorkbook As nsExcel.Workbook
        'Dim xlSheet As nsExcel.Worksheet
        'Dim xlRange As nsExcel.Range
        'xlWorkbook = xlExcel.Workbooks.Open(xlDocName)
        'xlSheet = xlWorkbook.Sheets(1)
        'xlSheet.Name = "项目信息"
        'Dim i, j As Integer
        'i = 0
        'j = 0
        'For Each dr As DataRow In OverseeInfoBean.Tables("XMXX").Rows
        '    For j = 0 To OverseeInfoBean.Tables("XMXX").Columns.Count - 1
        '        If (j >= 13 And j <= 14) Then
        '            Dim a As Date = OverseeInfoBean.Tables("XMXX").Rows(i)(j)
        '            xlSheet.Cells(i + 2, j + 1) = a.Date
        '        Else
        '            xlSheet.Cells(i + 2, j + 1) = OverseeInfoBean.Tables("XMXX").Rows(i)(j).ToString()
        '        End If
        '    Next
        '    i = i + 1
        'Next
        'xlSheet = xlWorkbook.Sheets(2)
        'xlSheet.Name = "客户信息"
        'i = 0
        'j = 0
        'For Each dr As DataRow In OverseeInfoBean.Tables("KHXX").Rows
        '    For j = 0 To OverseeInfoBean.Tables("KHXX").Columns.Count - 1
        '        xlSheet.Cells(i + 2, j + 1) = OverseeInfoBean.Tables("KHXX").Rows(i)(j).ToString()
        '    Next
        '    i = i + 1
        'Next
        'xlWorkbook.Save()
        'OverseeInfoBean = Nothing
        'xlSheet = Nothing
        'xlWorkbook.Close()
        'xlWorkbook = Nothing
        'xlExcel.Quit()
        'xlExcel = Nothing
        'MessageBox.Show("跨年项目信息已导入至Excel！" & vbCrLf & "生成的Excel文件为：d:\lhcis\datacenter\data\跨年项目.xls" & vbCrLf & "Excel数据编辑必须保证项目信息和客户信息非空，项目编码对应关系必须一致！", "操作提示")
        'DelVirtualProject()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '从EXCEL导入跨年项目
        Dim strSql As String
        Dim SqlType As CommandType
        Dim dsTable As DataTable
        OverseeInfoBean = New DataSet()
        strSql = "Select Rtrim(XMBH) as XMBH,Rtrim(BM) as BM,Rtrim(XH) AS XH,RTRIM(JGMC) AS JGMC,Rtrim(XKZBH) AS XKZBH,Rtrim(KHID) AS KHID,Rtrim(KHMC) AS KHMC,Rtrim(KHLX) AS KHLX,Rtrim(XMMC) AS XMMC,Rtrim(YWLX) AS YWLX ,YWPZ,DKYTSUHY,CYYT,Convert(varchar(10) , KSSJ, 120 ) As KSSJ,Convert(varchar(10) , JSSJ, 120 ) As JSSJ,ZRJE,DBFJE,SXYHMC,YWPZFZ from OverseeInfoVirtualProject where KSSJ>JSSJ"
        InfoTableName = "XMXX"
        SqlType = CommandType.Text
        AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)

        strSql = "Select XMBH,BM,XH,JGMC,XKZBH ,KHLX,KHID,KHMC,ZZJGDM,HYLX,DKKH,ZYYW,CYRS,ZCZE,FZZE,JLR,YHJKZE,XM,SFZH From OverseeInfoClient"
        InfoTableName = "KHXX"
        SqlType = CommandType.Text
        AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)

        If ReadXlsByADO() Then
            strSql = "Select XMBH,BM,XH,JGMC,XKZBH,Convert(varchar(10) ,JCRQ,120) As JCRQ,JCJE,FKJE,Convert(varchar(10) ,FKRQ,120) As FKRQ From OverseeInfoReleaseProject Where FKRQ>JCRQ"
            InfoTableName = "ZRJC"
            SqlType = CommandType.Text
            OverseeInfoBean = AppService.GetEntityBean(strSql, SqlType, OverseeInfoBean, InfoTableName, Nothing)
            LoanProjectsBeingAsReleaseProjects()
            GetCreditByBank()
            dsTable = OverseeInfoBean.Tables.Add("XMXXVO")
            dsTable = OverseeInfoBean.Tables.Add("DCHK")
            dsTable = OverseeInfoBean.Tables.Add("ZHSS")
            MessageBox.Show("跨年项目信息导入完成！数据的正确性和完整性由申报人负责。", "操作提示")
        Else
            MessageBox.Show("Excel数据有空值或格式错误，不符合上报接口规范！", "操作提示")
            Me.Close()
        End If
    End Sub
    Private Function ReadXlsByADO() As Boolean
        Dim ReadStatus As Boolean = True
        Dim xlConn As OleDb.OleDbConnection
        Dim xlConnStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Extended Properties=Excel 8.0;Data Source=d:\lhcis\datacenter\data\跨年项目.xls;"
        Try
            xlConn = New OleDb.OleDbConnection
            xlConn.ConnectionString = xlConnStr
            xlConn.Open()
            Dim Sql As String = "Select Rtrim(XMBH) as XMBH,Rtrim(BM) as BM,Rtrim(XH) AS XH,RTRIM(JGMC) AS JGMC,Rtrim(XKZBH) AS XKZBH,Rtrim(KHID) AS KHID,Rtrim(KHMC) AS KHMC,Rtrim(KHLX) AS KHLX,Rtrim(XMMC) AS XMMC,Rtrim(YWLX) AS YWLX ,YWPZ,DKYTSUHY,CYYT,KSSJ,JSSJ,ZRJE,DBFJE,SXYHMC,YWPZFZ FROM [项目信息$] WHERE NOT XMBH IS NULL"
            InfoTableName = "XMXX"
            Dim da As OleDbDataAdapter = New OleDbDataAdapter(Sql, xlConn)
            da.Fill(OverseeInfoBean, InfoTableName)
            For Each VirtualProject As DataRow In OverseeInfoBean.Tables(InfoTableName).Rows()
                VirtualProject.Item(13) = Convert.ToDateTime(VirtualProject.Item(13)).ToString("yyyy-MM-dd")
                VirtualProject.Item(14) = Convert.ToDateTime(VirtualProject.Item(14)).ToString("yyyy-MM-dd")
            Next
            SetXH(OverseeInfoBean, InfoTableName)
            Sql = "Select Rtrim(XMBH) as XMBH,Rtrim(BM) as BM,Rtrim(XH) AS XH,RTRIM(JGMC) AS JGMC,Rtrim(XKZBH) AS XKZBH,Rtrim(KHLX) AS KHLX,Rtrim(KHID) AS KHID,Rtrim(KHMC) AS KHMC,Rtrim(ZZJGDM) AS ZZJGDM,Rtrim(HYLX) AS HYLX,Rtrim(DKKH) AS DKKH ,Rtrim(ZYYW) AS ZYYW,CYRS,ZCZE,FZZE,JLR,YHJKZE,XM,SFZH  FROM [客户信息$] WHERE NOT XMBH IS NULL"
            InfoTableName = "KHXX"
            da = New OleDbDataAdapter(Sql, xlConn)
            da.Fill(OverseeInfoBean, InfoTableName)
            SetXH(OverseeInfoBean, InfoTableName)
        Catch ex As Exception
            ReadStatus = False
        Finally
            xlConn.Close()
        End Try
        Return ReadStatus
    End Function
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
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

        OverseeInfoBean.DataSetName = "XMXX_INFO"
        OverseeInfoBean.Tables("XMXX").Columns(18).ColumnName = "YWPZFZ"
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
        MessageBox.Show("数据包生成完毕！", "操作提示")
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class