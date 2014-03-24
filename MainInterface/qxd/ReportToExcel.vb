'
'此类用于生成excel表
'但生成图表时，其纵轴（系列）只能是integer,decimal,single,double类型的
'

Public Class ReportToExcel

    '导出到Excel
    Public Shared Sub ToExcel(ByVal dg As DataGrid, ByVal filePath As Object, ByVal fileName As Object, Optional ByVal array As ArrayList = Nothing)
        ToExcel(dg, IIf(filePath Is Nothing, "", filePath), IIf(fileName Is Nothing, "", fileName), array)
    End Sub

    Public Shared Sub ToExcel(ByVal dg As DataGrid, ByVal filePath As String, ByVal fileName As String, Optional ByVal array As ArrayList = Nothing)

        If dg.DataSource Is Nothing Then
            Exit Sub
        End If

        Dim dgts As DataGridTableStyle
        Dim dt As DataTable

        Dim sfd As SaveFileDialog = New SaveFileDialog()
        filePath = String.Empty
        sfd.InitialDirectory = filePath
        sfd.FileName = fileName
        sfd.Filter = "Excel文件|*.xls"
        If sfd.ShowDialog = DialogResult.OK Then
            filePath = sfd.FileName '.Replace(".xls)", String.Empty)
        Else
            Return
        End If

        Dim oExcel As Excel.ApplicationClass

        Try
            If System.IO.File.Exists(filePath) Then
                System.IO.File.Delete(filePath)
            End If

            dgts = dg.TableStyles(0)

            If dg.DataSource.GetType Is GetType(DataTable) Then
                dt = dg.DataSource
            Else
                dt = CType(dg.DataSource, DataSet).Tables(dg.DataMember)
            End If

            oExcel = New Excel.ApplicationClass()
            oExcel.Application.Workbooks.Add()

            oExcel.Application.Workbooks(1).SaveAs(filePath)

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
                '剔除列名对应的MappingName不存在于datasource 和列宽为0的列.
                If Not dt.Columns(column.MappingName.Trim) Is Nothing And (Not column.Width = 0) Then
                    col = colCount 'colcount=0表示从零开始
                    colCount += 1
                    'col = dgts.GridColumnStyles.IndexOf(column)

                    rang.Item(row, col + 1) = column.HeaderText 'row=3
                    rang.Cells(row, col + 1).BorderAround(Excel.XlLineStyle.xlContinuous)
                    rang.Rows(row).Font.Bold = True

                    columnDataType = dt.Columns(column.MappingName.Trim).DataType

                    Dim str1 As String = column.MappingName.ToString()
                    Dim str2 As String = columnDataType.ToString()

                    '设置内容的显示格式
                    If columnDataType Is GetType(DateTime) Then
                        rang.Range(rang.Cells(4, col + 1), rang.Cells(4 + rowCount, col + 1)).NumberFormat = "yyyy-MM-dd" 'rowCount为总记录数
                    ElseIf columnDataType Is GetType(Decimal) Or columnDataType Is GetType(Double) Or columnDataType Is GetType(Single) Then
                        rang.Range(rang.Cells(4, col + 1), rang.Cells(4 + rowCount, col + 1)).NumberFormat = "#,##0.00"
                    ElseIf columnDataType Is GetType(Int16) Or columnDataType Is GetType(Int32) Or columnDataType Is GetType(Int64) Then
                        rang.Range(rang.Cells(4, col + 1), rang.Cells(4 + rowCount, col + 1)).NumberFormat = "#,##0"
                    Else
                        rang.Range(rang.Cells(4, col + 1), rang.Cells(4 + rowCount, col + 1)).NumberFormat = "@"
                    End If

                    '把DataGrid中的Boolean值“True,Flase”,替换为“是否”
                    For i = 0 To rowCount - 1
                        'Select Case columnDataType.GetType().ToString
                        '    case gettype(boolean).ToString,


                        'End Select
                        If columnDataType Is GetType(Boolean) Then
                            If IsDBNull(dt.Rows(i)(column.MappingName)) Then
                                rang.Item(row + i + 1, col + 1) = ""
                            Else
                                rang.Item(row + i + 1, col + 1) = IIf(dt.Rows(i)(column.MappingName), "是", "否")
                            End If
                        ElseIf columnDataType Is GetType(Int16) Or columnDataType Is GetType(Int32) Or columnDataType Is GetType(Int64) Or columnDataType Is GetType(Single) Or columnDataType Is GetType(Double) Or columnDataType Is GetType(Decimal) Then
                            If IsDBNull(dt.Rows(i)(column.MappingName)) Or dt.Rows(i)(column.MappingName).ToString = "" Then
                                rang.Item(row + i + 1, col + 1) = "0"
                            Else
                                rang.Item(row + i + 1, col + 1) = dt.Rows(i)(column.MappingName).ToString 'dg.Item(row - 3, col).ToString '
                            End If
                            'rang.Item(row + 1 + i, col + 1) = IIf(IsDBNull(dt.Rows(i)(column.MappingName)) Or dt.Rows(i)(column.MappingName).ToString = "", "0", dt.Rows(i)(column.MappingName).ToString)
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
            rang.Range(rang.Cells(2, 1), rang.Cells(2, 5)).Merge(True) '合并单元格
            rang.Item(2, 1) = "打印日期：" & Now.Date.ToString("yyyy年MM月dd日")
            'rang.Range(rang.Cells(2, 4), rang.Cells(2, 5)).Merge(True)
            'rang.Item(2, 4) = "记录数：" & rowCount
            rang.Range(rang.Cells(2, 1), rang.Cells(2, 4)).Font.Bold = True '设置字体为粗体

            Dim countRange As Excel.Range
            countRange = rang.Range(rang.Cells(1, 1), rang.Cells(1, colCount))
            countRange.Merge(True)
            rang.Item(1, 1) = fileName
            rang.Cells(1, 1).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            rang.Rows(1).font.bold = True
            rang.Rows(1).font.size = 18
            workSheet.Columns.AutoFit()

            rang.Cells(4, 1).Select()
            oExcel.ActiveWindow.FreezePanes = True

            'start--------------------------生成图表--------------------------------------start
            '生成图表并插入到Excel中
            Dim p As Integer
            Dim sheetName As String
            ' oExcel.Visible = True
            oExcel.DisplayAlerts = False
            workBook.Sheets("sheet2").delete()
            workBook.Sheets("sheet3").delete()
            oExcel.DisplayAlerts = True

            If arrayLen > 0 Then '需要生成图标时执行
                For p = 0 To arrayLen - 1
                    workBook.Sheets.Add()
                    sheetName = "Sheet" & p + 4 '生成的sheet从sheet4开始的
                    rang = workBook.Sheets(sheetName).cells
                    rang.Range(rang.Cells(1, 1), rang.Cells(1, 7)).Merge(True) '合并单元格
                    rang.Item(1, 1) = "打印日期：" & Now.Date.ToString("yyyy年MM月dd日")
                    rang.Range(rang.Cells(1, 1), rang.Cells(1, 7)).Font.Bold = True '设置字体为粗体
                    rang.Range(rang.Cells(2, 1), rang.Cells(2, 7)).Merge(True)
                    rang.Item(2, 1) = ""
                    rang.Font.Bold = True
                    importToPicture(workBook, rowCount, arrayList.Item(p), chartTypeArray.Item(p), sheetName)
                Next

                '生成的图表为逆序的，使之成为顺序sheets
                For i = oExcel.Sheets.Count - 1 To 1 Step -1
                    oExcel.Sheets(i).move(, oExcel.Sheets(oExcel.Sheets.Count))
                Next

                Dim sheetCount As Integer
                sheetCount = workBook.Sheets.Count
                If arrayLen < 2 Then
                    sheetCount = 2
                End If
                For sheetCount = 2 To sheetCount
                    workSheet = workBook.Sheets(sheetCount)
                    workSheet.Name = "图表" & sheetCount - 1
                    For i = 1 To workSheet.ChartObjects.count '有的sheet有几个chart对象
                        With workSheet.ChartObjects(i)
                            .top = 685 * (i - 1) + 30 '一页的高度为685
                            .left = 0
                            .width = 385
                            .height = 290
                            .chart.Legend.Position = Excel.XlLegendPosition.xlLegendPositionTop
                        End With
                        'workBook.ActiveChart.Export(Application.StartupPath & "\chart" & sheetCount - 1 & ".jpg")
                    Next i
                Next sheetCount

            End If
            'end--------------------------生成图表--------------------------------------end
            workBook.Sheets(1).name = "源数据"
            oExcel.Sheets(1).activate()
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
        Dim count As Integer = arrayList.Count '生成图表中的系列数为count－1
        Dim n, m, LetterLen As Integer

        LetterLen = strLetter.Length
        '生成格式字符串,"A3:A7,E3:E7,G3:G7,I3:I7"
        If count > 0 Then
            For n = 0 To count - 1
                m = arrayList.Item(n) - 1
                If m < LetterLen Then
                    strRange = strRange & strLetter(m) & "3:" & strLetter(m) & rowCount + 2 & "," '合计行不要
                End If
            Next
            len = strRange.Length
            strRange = strRange.Remove(len - 1, 1)
        End If

        If chartType = Excel.XlChartType.xlPie Then '一页可以生成几副饼图
            Dim strRangeItem() As String = strRange.Split(","c)
            If strRangeItem.Length >= 2 Then
                Dim i As Int16
                For i = 1 To strRangeItem.Length - 1
                    Dim strPieRange As String = strRangeItem(0) + "," + strRangeItem(i)
                    workBook.Charts.Add()
                    With workBook.ActiveChart
                        .ChartType = Excel.XlChartType.xlPie
                        .SetSourceData(source:=workBook.Sheets("sheet1").range(strPieRange), plotby:=Excel.XlRowCol.xlColumns)
                        .ApplyDataLabels(Type:=Excel.XlDataLabelsType.xlDataLabelsShowPercent)
                        '.Legend.Position = Excel.XlLegendPosition.xlLegendPositionBottom
                        .Location(where:=Excel.XlChartLocation.xlLocationAsObject, Name:=sheetName)
                        '.Axes(Excel.XlAxisType.xlValue).hastile = True
                        '.Axes(Excel.XlAxisType.xlValue).axistitle.caption = "adsfasdf"
                        '.PlotArea.Height = 300
                        '.PlotArea.Width = 300
                    End With
                    'workBook.Sheets("sheet1").chartObjects(i).top = 300 * (i - 1)
                Next
            End If
        Else
            workBook.Charts.Add()
            'If chartType = Excel.XlChartType.xlPie Then
            With workBook.ActiveChart
                .ChartArea.Font.Size = 8
                .ChartArea.Font.Bold = False

                'workBook.ActiveChart.ChartArea.Interior.Color = Color.Blue

                .ChartType = chartType 'Excel.XlChartType.xlColumnClustered
                'workBook.ActiveChart.SetSourceData(Source:=workSheet.Range("A3:A7,E3:E7,G3:G7,I3:I7"))
                .SetSourceData(Source:=workBook.Sheets("sheet1").Range(strRange), PlotBy:=Excel.XlRowCol.xlColumns)
                If .ChartType = Excel.XlChartType.xlPie Then
                    .ApplyDataLabels(Type:=Excel.XlDataLabelsType.xlDataLabelsShowPercent)
                End If
                .Location(Where:=Excel.XlChartLocation.xlLocationAsObject, Name:=sheetName) '？定位的时候，name所在的sheet必须在第一个位置

            End With
        End If


    End Sub
    '获得图表的类型
    Private Shared Function getChartType(ByVal flag As String) ',  optional ByRef  chartName As String
        Dim chartType As Excel.XlChartType
        Select Case flag
            Case "0" '柱状图
                chartType = Excel.XlChartType.xlColumnClustered
                'chartName = "柱状图"
            Case "1" '折线图
                chartType = Excel.XlChartType.xlLine
                'chartName = "折线图"
            Case "2" '饼图
                chartType = Excel.XlChartType.xlPie
                'chartName = "饼图"
            Case "3" '三维柱形图
                chartType = Excel.XlChartType.xl3DColumn
                'chartName = "三维柱形图"
            Case "4" '三维折线图
                chartType = Excel.XlChartType.xl3DLine
                'chartName = "三维折线图"
            Case "5" '三维饼图
                chartType = Excel.XlChartType.xl3DPie
                'chartName = "三维饼图"
            Case Else '柱状图
                chartType = Excel.XlChartType.xlColumnClustered
                'chartName = "柱状图"
        End Select
        Return chartType
    End Function
End Class

