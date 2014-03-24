Public Class ReportToExcel
    Public Shared Sub ToExcel(ByVal dg As DataGrid, ByVal title As Object, ByVal fileName As Object, Optional ByVal array As ArrayList = Nothing)
        ToExcel(dg, IIf(title Is Nothing, "", title), IIf(fileName Is Nothing, "", fileName), array)
    End Sub
    Public Shared Sub ToExcel(ByVal dg As DataGrid, ByVal title As String, ByVal fileName As String, Optional ByVal array As ArrayList = Nothing)

        If dg.DataSource Is Nothing Then
            Exit Sub
        End If

        Dim dgts As DataGridTableStyle
        Dim dt As DataTable

        Dim sfd As SaveFileDialog = New SaveFileDialog()
        sfd.FileName = fileName
        sfd.Filter = "Excel文件|*.xls"
        Dim FilePath As String = String.Empty
        If sfd.ShowDialog = DialogResult.OK Then
            FilePath = sfd.FileName '.Replace(".xls)", String.Empty)
        Else
            Return
        End If

        Dim oExcel As Excel.ApplicationClass

        Try
            If System.IO.File.Exists(FilePath) Then
                System.IO.File.Delete(FilePath)
            End If

            dgts = dg.TableStyles(0)

            If dg.DataSource.GetType Is GetType(DataTable) Then
                dt = dg.DataSource
            Else
                dt = CType(dg.DataSource, DataSet).Tables(dg.DataMember)
            End If

            oExcel = New Excel.ApplicationClass()
            oExcel.Application.Workbooks.Add()

            oExcel.Application.Workbooks(1).SaveAs(FilePath)

            Dim workBook As Excel.WorkbookClass = oExcel.ActiveWorkbook
            Dim workSheet As Excel.Worksheet = workBook.Sheets(1)
            Dim rang As Excel.Range = workSheet.Cells

            Dim i, row, col As Integer
            Dim column As DataGridColumnStyle

            Dim rowCount As Int16 = dt.Rows.Count
            Dim colCount As Integer = 0
            Dim columnDataType As System.Type

            row = 3 '从excel第三行开始进行数据库表内容的填充

            'start--------------------------生成图表--------------------------------------start
            '生成图表中用到的变量
            Dim isCreateChart As Boolean = False '是否创建图表,如果图表类型、x轴、且至少指定了一列"系列",即chartLen>=3
            Dim chartLen As Integer
            Dim chartType As Excel.XlChartType
            Dim chartLoop As Integer

            Dim arrayLen As Integer '通过传入参数的Array的长度,即生成图表的个数
            Dim arrayLoop As Integer

            Dim chartTypeArray As New ArrayList() '图表类型

            '获取图表类型
            If Not array Is Nothing Then
                arrayLen = array.Count
                If arrayLen > 0 Then
                    For arrayLoop = 0 To arrayLen - 1
                        chartLen = CType(array.Item(arrayLoop), ArrayList).Count
                        If chartLen > 2 Then
                            chartType = getChartType(CType(array.Item(arrayLoop), ArrayList).Item(0))
                            chartTypeArray.Add(chartType)
                            isCreateChart = True
                        End If
                    Next
                End If
            End If

            '判断图表的X轴和系列
            Dim arrayList As New ArrayList()

            If isCreateChart Then
                For arrayLoop = 0 To arrayLen - 1
                    Dim colTemp As Integer = 0
                    Dim arrayTemp As New ArrayList()

                    chartLen = CType(array.Item(arrayLoop), ArrayList).Count
                    For Each column In dgts.GridColumnStyles
                        If Not dt.Columns(column.MappingName.Trim) Is Nothing Then
                            colTemp += 1
                            For chartLoop = 1 To chartLen - 1
                                If column.HeaderText.Trim = CType(CType(array.Item(arrayLoop), ArrayList).Item(chartLoop), String).Trim Then
                                    arrayTemp.Add(colTemp)
                                End If
                            Next
                        End If
                    Next
                    arrayList.Add(arrayTemp)
                Next
            End If
            'end--------------------------生成图表--------------------------------------end

            For Each column In dgts.GridColumnStyles
                If Not dt.Columns(column.MappingName.Trim) Is Nothing Then
                    col = colCount
                    colCount += 1
                    'col = dgts.GridColumnStyles.IndexOf(column)

                    rang.Item(row, col + 1) = column.HeaderText
                    rang.Cells(row, col + 1).BorderAround(Excel.XlLineStyle.xlContinuous)
                    rang.Rows(row).Font.Bold = True

                    columnDataType = dt.Columns(column.MappingName.Trim).DataType

                    '设置内容的显示格式
                    If columnDataType Is GetType(DateTime) Then
                        rang.Range(rang.Cells(4, col + 1), rang.Cells(4 + rowCount, col + 1)).NumberFormat = "yyyy-MM-dd"
                    ElseIf columnDataType Is GetType(Decimal) Or columnDataType Is GetType(Double) Then
                        rang.Range(rang.Cells(4, col + 1), rang.Cells(4 + rowCount, col + 1)).NumberFormat = "#,##0.00"
                        'arrayList.Add(col + 1)
                        'ElseIf columnDataType Is GetType(Integer) Or columnDataType Is GetType(Int16) Or columnDataType Is GetType(Int32) Or columnDataType Is GetType(Int64) Then
                        'arrayList.Add(col + 1)
                    Else
                        rang.Range(rang.Cells(4, col + 1), rang.Cells(4 + rowCount, col + 1)).NumberFormat = "@"
                    End If

                    '把DataGrid中的Boolean值“True,Flase”,替换为“是否”
                    For i = 0 To rowCount - 1
                        If columnDataType Is GetType(Boolean) Then
                            If IsDBNull(dt.Rows(i)(column.MappingName)) Then
                                rang.Item(row + i + 1, col + 1) = ""
                            Else
                                rang.Item(row + i + 1, col + 1) = IIf(dt.Rows(i)(column.MappingName), "是", "否")
                            End If
                        Else
                            rang.Item(row + i + 1, col + 1) = dt.Rows(i)(column.MappingName).ToString 'dg.Item(row - 3, col).ToString '
                        End If

                        '设置单元格的边框为实线框
                        rang.Cells(row + i + 1, col + 1).BorderAround(Excel.XlLineStyle.xlContinuous)
                    Next
                End If
            Next

            '设置标题的“背景”格式
            rang.Range(rang.Cells(row, 1), rang.Cells(row, colCount)).AutoFormat(Excel.XlRangeAutoFormat.xlRangeAutoFormatColor2)
            '设置标题居中显示
            rang.Range(rang.Cells(row, 1), rang.Cells(row, colCount)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            '设置字体大小
            rang.Range(rang.Cells(row, 1), rang.Cells(row + rowCount, colCount)).Font.Size = 10

            '显示打印日期
            rang.Range(rang.Cells(2, 1), rang.Cells(2, 3)).Merge(True) '合并单元格
            rang.Item(2, 1) = "打印日期：" & Now.Date.ToString("yyyy年MM月dd日")
            rang.Range(rang.Cells(2, 4), rang.Cells(2, 5)).Merge(True)
            rang.Item(2, 4) = "记录数：" & rowCount
            rang.Range(rang.Cells(2, 1), rang.Cells(2, 4)).Font.Bold = True '设置字体为粗体

            Dim countRange As Excel.Range
            countRange = rang.Range(rang.Cells(1, 1), rang.Cells(1, colCount))
            countRange.Merge(True)
            rang.Item(1, 1) = title
            rang.Cells(1, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            rang.Rows(1).font.bold = True
            rang.Rows(1).font.size = 18
            workSheet.Columns.AutoFit()

            'start--------------------------生成图表--------------------------------------start
            '生成图表并插入到Excel中
            Dim p As Integer
            Dim sheetName As String

            If arrayLen > 0 Then
                For p = 0 To arrayLen - 1
                    If p > 1 Then
                        workBook.Sheets.Add()
                    End If
                    sheetName = "Sheet" & p + 2
                    importToPicture(workBook, rowCount, arrayList.Item(p), chartTypeArray.Item(p), sheetName)
                Next

                Dim sheetCount As Integer
                workSheet.Name = "源数据"
                sheetCount = workBook.Sheets.Count
                If arrayLen < 2 Then
                    sheetCount = 2
                End If
                For sheetCount = 2 To sheetCount
                    workBook.Sheets(sheetCount).name = "图表" & sheetCount - 1
                    workBook.Sheets(sheetCount).chartObjects(1).top = 10
                    workBook.Sheets(sheetCount).chartObjects(1).left = 10
                    workBook.Sheets(sheetCount).ChartObjects(1).width = 620
                    workBook.Sheets(sheetCount).ChartObjects(1).height = 400
                    'workBook.ActiveChart.Export(Application.StartupPath & "\chart" & sheetCount - 1 & ".jpg")
                Next
            End If
            'end--------------------------生成图表--------------------------------------end

            oExcel.Application.Visible = True

        Catch ex As Exception
            If Not oExcel Is Nothing Then
                oExcel.Application.Workbooks.Close()
                '退出Excel,且不提示是否保存
                CType(oExcel.Application, Excel.ApplicationClass).Quit()
                oExcel = Nothing
            End If
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            oExcel = Nothing
            'GC.Collect()
        End Try
    End Sub
    '导出图表
    Public Shared Sub importToPicture(ByVal workBook As Excel.WorkbookClass, ByVal rowCount As Integer, ByVal arrayList As ArrayList, ByVal chartType As Excel.XlChartType, ByVal sheetName As String)
        Dim strRange As String
        Dim len As Integer
        '代表Excel中的列,总共256列
        Dim strLetter() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", _
                                     "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ", _
                                     "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ", _
                                     "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ", _
                                     "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DJ", "DK", "DL", "DM", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "DV", "DW", "DX", "DY", "DZ", _
                                     "EA", "EB", "EC", "ED", "EE", "EF", "EG", "EH", "EI", "EJ", "EK", "EL", "EM", "EN", "EO", "EP", "EQ", "ER", "ES", "ET", "EU", "EV", "EW", "EX", "EY", "EZ", _
                                     "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FH", "FI", "FJ", "FK", "FL", "FM", "FN", "FO", "FP", "FFQ", "R", "FS", "FT", "FU", "FV", "FW", "FX", "FY", "FZ", _
                                     "GA", "GB", "GC", "GD", "GE", "GF", "GG", "GH", "GI", "GJ", "GK", "GL", "GM", "GN", "GO", "GP", "GQ", "GR", "GS", "GT", "GU", "GV", "GW", "GX", "GY", "GZ", _
                                     "HA", "HB", "HC", "HD", "HE", "HF", "HG", "HH", "HI", "HJ", "HK", "HL", "HM", "HN", "HO", "HP", "HQ", "HR", "HS", "HT", "HU", "HV", "HW", "HX", "HY", "HZ", _
                                     "IA", "IB", "IC", "ID", "IE", "IF", "IG", "IH", "II", "IJ", "IK", "IL", "IM", "IN", "IO", "IP", "IQ", "IR", "IS", "IT", "IU", "IV" _
                                     }
        Dim count As Integer = arrayList.Count
        Dim n, m, LetterLen As Integer
        Dim workSheet As Excel.Worksheet

        workSheet = workBook.Sheets(1)
        LetterLen = strLetter.Length
        '生成格式字符串,"A3:A7,E3:E7,G3:G7,I3:I7"
        If count > 0 Then
            For n = 0 To count - 1
                m = arrayList.Item(n) - 1
                If m < LetterLen Then
                    strRange = strRange & strLetter(m) & "3:" & strLetter(m) & rowCount + 3 & ","
                End If
            Next
            len = strRange.Length
            strRange = strRange.Remove(len - 1, 1)
        End If

        workBook.Charts.Add()
        workBook.ActiveChart.ChartArea.Font.Size = 8
        workBook.ActiveChart.ChartArea.Font.Bold = False

        'workBook.ActiveChart.ChartArea.Interior.Color = Color.Blue


        workBook.ActiveChart.ChartType = chartType 'Excel.XlChartType.xlColumnClustered
        'workBook.ActiveChart.SetSourceData(Source:=workSheet.Range("A3:A7,E3:E7,G3:G7,I3:I7"))
        workBook.ActiveChart.SetSourceData(Source:=workSheet.Range(strRange), PlotBy:=Excel.XlRowCol.xlColumns)
        'workBook.ActiveChart.SizeWithWindow = True
        workBook.ActiveChart.Location(Where:=Excel.XlChartLocation.xlLocationAsObject, Name:=sheetName)

    End Sub
    '获得图表的类型
    Private Shared Function getChartType(ByVal flag As String)
        Dim chartType As Excel.XlChartType
        Select Case flag
            Case "0" '柱状图
                chartType = Excel.XlChartType.xlColumnClustered
            Case "1" '折线图
                chartType = Excel.XlChartType.xlLine
            Case "2" '饼图
                chartType = Excel.XlChartType.xlPie
            Case "3" '三维柱形图
                chartType = Excel.XlChartType.xl3DColumn
            Case "4" '三维折线图
                chartType = Excel.XlChartType.xl3DLine
            Case "5" '三维饼图
                chartType = Excel.XlChartType.xl3DPie
            Case Else '柱状图
                chartType = Excel.XlChartType.xlColumnClustered
        End Select
        Return chartType
    End Function
End Class

