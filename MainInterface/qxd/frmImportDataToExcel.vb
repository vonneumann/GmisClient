'Imports Excel.WorkbookClass
'Imports Excel.ApplicationClass


Public Class frmImportDataToExcel
    Inherits MainInterface.frmBasic

    Private strProjectCode As String
    Private strCorporationName As String
    Private strCorporationCode As String
    Private strItemType As String = "45" '表示文档类型
    Private strPerson As String
    Private strDir As String = "\Document\Excel\"
    Private strPhase As String

#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub
    'new()
    'by quexd 2003-4-28
    Public Sub New(ByVal projectCode As String, ByVal corporationName As String)
        Me.New()
        Me.strProjectCode = projectCode
        Me.strCorporationName = corporationName
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
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents cmbTable As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmImportDataToExcel))
        Me.btnImport = New System.Windows.Forms.Button()
        Me.cmbTable = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(267, 128)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Visible = True
        '
        'btnImport
        '
        Me.btnImport.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnImport.Image = CType(resources.GetObject("btnImport.Image"), System.Drawing.Bitmap)
        Me.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImport.ImageIndex = 16
        Me.btnImport.ImageList = Me.ImageListBasic
        Me.btnImport.Location = New System.Drawing.Point(171, 128)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(77, 24)
        Me.btnImport.TabIndex = 1
        Me.btnImport.Text = "导 入(&I)"
        Me.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTable
        '
        Me.cmbTable.Items.AddRange(New Object() {"所有表", "股权结构", "经营情况", "开户行及主要结算行情况", "贷款记录", "对外担保记录", "诉讼记录", "纳税记录", "承兑汇票", "反担保物", "财务分析", "现金流量分析", "资产负债表", "损益表", "现金流量", "现金流量表"})
        Me.cmbTable.Location = New System.Drawing.Point(280, 40)
        Me.cmbTable.Name = "cmbTable"
        Me.cmbTable.Size = New System.Drawing.Size(224, 20)
        Me.cmbTable.TabIndex = 15
        Me.cmbTable.Text = "所有表"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(208, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "待生成的表"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbType
        '
        Me.cmbType.Location = New System.Drawing.Point(64, 40)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(121, 20)
        Me.cmbType.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "阶    段"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(280, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(224, 21)
        Me.txtName.TabIndex = 11
        Me.txtName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(208, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 8)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(120, 21)
        Me.txtCode.TabIndex = 9
        Me.txtCode.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmImportDataToExcel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(514, 159)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbTable, Me.Label4, Me.cmbType, Me.Label3, Me.txtName, Me.Label2, Me.txtCode, Me.Label1, Me.btnExit, Me.btnImport})
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmImportDataToExcel"
        Me.Text = "从数据库导入数据到Excel"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmImportDataToExcel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtCode.Text = Me.strProjectCode
        Me.txtName.Text = Me.strCorporationName
        Me.txtCode_Leave(sender, e)
        getPhaseType()
        'getFilesType(strItemType)
    End Sub
    '获得阶段类型
    Private Sub getPhaseType()
        If Not gWs Is Nothing Then
            Me.cmbType.DataSource = gWs.GetPhase("%").Tables(0)
            Me.cmbTable.ValueMember = "phase_name"
            Me.cmbType.DisplayMember = "phase_name"
        End If
    End Sub
    '
    '得到文件类型，通过Itemtype
    '
    Private Sub getFilesType(ByVal strItemType As String)
        Dim ds As DataSet
        Dim i As Integer
        If Not gWs Is Nothing Then
            Try
                ds = gWs.GetItem("{item_type='" & strItemType & "'}", Nothing)
                i = ds.Tables("TItem").Rows.Count
                cmbType.Items.Clear()
                If i > 0 Then
                    For i = 0 To i - 1
                        With ds.Tables("TItem").Rows(i)
                            cmbType.Items.Add(.Item("item_name"))
                        End With
                    Next
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
            Try
                cmbType.SelectedIndex = 0
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
    End Sub
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    '导入
    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click
        strProjectCode = Me.txtCode.Text
        Dim strFileName As String
        Dim table As String
        strFileName = Me.txtName.Text & "—" & Me.txtCode.Text & "—" & Me.cmbTable.Text
        strPhase = Me.cmbType.Text
        table = Me.cmbTable.Text
        importExcel(strProjectCode, getLegalFileName(strFileName), strPhase, table, "")
    End Sub
    '
    '导出数据到Excel
    '
    Public Sub importExcel(ByVal projectCode As String, ByVal strFileName As String, ByVal phase As String, ByVal table As String, ByVal strOppCorporatinCode As String)
        If Not gWs Is Nothing Then
            Dim ds As DataSet
            Dim i As Integer
            strProjectCode = projectCode
            strPhase = phase
            Dim itemType, itemCode As String '文档中的表格数据的类型
            itemType = "47"
            itemCode = "001"
            If strFileName = "" Then
                'MsgBox("请选中待制作文档!", MsgBoxStyle.Exclamation, "提示")
                SWDialogBox.MessageBox.Show("$1001", "文档类型")
                Me.cmbTable.Focus()
                Exit Sub
            End If

            If Not System.IO.Directory.Exists(Application.StartupPath & strDir) Then
                System.IO.Directory.CreateDirectory(Application.StartupPath & strDir)
            Else
                delAllFiles(Application.StartupPath & strDir)
            End If
            Dim excel1 As Excel.ApplicationClass
            Try
                ds = gWs.GetFileTemplateByCondition("{item_type='" & itemType & "' and item_code ='" & itemCode & "' and is_current_ver='1'}")
                i = ds.Tables("TFileTemplate").Rows.Count
                If i > 0 Then
                    With ds.Tables("TFileTemplate").Rows(0)
                        If Not .Item("template") Is System.DBNull.Value Then
                            Me.Cursor = Cursors.WaitCursor
                            Dim data As Byte() = .Item("template")
                            Dim myfilestream As System.IO.FileStream
                            myfilestream = New System.IO.FileStream(Application.StartupPath & strDir & strFileName & ".xls", IO.FileMode.Create, IO.FileAccess.ReadWrite, IO.FileShare.ReadWrite)
                            myfilestream.Write(data, 0, data.Length)
                            myfilestream.Close()
                            '打开Excel文档
                            excel1 = New Excel.ApplicationClass()
                            'excel1.Application.Workbooks.Open(Application.StartupPath & strDir & strFileName & ".xls")
                            excel1.Application.Workbooks.Add(Application.StartupPath & strDir & strFileName & ".xls")
                            importTable(excel1, projectCode, table, strOppCorporatinCode)
                            excel1.Application.Visible = True
                            Me.Cursor = Cursors.Default
                        Else
                            'MsgBox("《" & strFileName & "》的Excel模板文件不存在!", MsgBoxStyle.Exclamation, "提示")
                            SWDialogBox.MessageBox.Show("$2002", strFileName)
                        End If
                    End With
                Else
                    'MsgBox("《" & strFileName & "》的Excel模板文件不存在!", MsgBoxStyle.Exclamation, "提示")
                    SWDialogBox.MessageBox.Show("$2002", strFileName)
                End If
            Catch ex As Exception
                '关闭打开的文件
                If Not excel1 Is Nothing Then
                    excel1.Application.Workbooks.Close()
                    '退出Excel,且不提示是否保存
                    CType(excel1.Application, Excel.ApplicationClass).Quit()
                End If
                Me.Cursor = Cursors.Default
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            Finally
                excel1 = Nothing
                GC.Collect()
            End Try
        End If
    End Sub
    '
    '获得某个表的range
    '
    Private Function getRange(ByVal workBook As Excel.WorkbookClass, ByVal table As String)
        Dim workSheet As Excel.Worksheet
        Dim rang As Excel.Range
        Dim j As Integer
        For j = 1 To workBook.Worksheets.Count
            workSheet = workBook.Worksheets(j)
            If workSheet.Name.Trim() = table Then
                rang = workSheet.Cells()
                workSheet.Select()
                Return rang
            End If
        Next
    End Function
    '
    '导入数据
    '
    Private Sub importTable(ByVal excel1 As Excel.ApplicationClass, ByVal projectCode As String, ByVal table As String, ByVal strCorporationCode As String)
        Dim workBook As Excel.WorkbookClass
        Dim workSheet As Excel.Worksheet
        Dim sheet As Excel.Sheets
        Dim rang As Excel.Range

        '所有表
        '股权结构
        '经营情况
        '开户行及主要结算行情况
        '贷款记录
        '对外担保记录
        '诉讼记录
        '纳税记录
        '承兑汇票
        '反担保物    qxd 2003-5-7 add       
        '财务分析
        '现金流量分析
        '资产负债表
        '损益表
        '现金流量
        '现金流量表
        Try
            workBook = excel1.ActiveWorkbook
            Select Case table
                Case "股权结构"
                    rang = getRange(workBook, table)
                    importCorporation_stock_structure(rang, strPhase)
                Case "经营情况"
                    rang = getRange(workBook, table)
                    importCorporation_business(rang, strPhase)
                Case "开户行及主要结算行情况"
                    rang = getRange(workBook, table)
                    importCorporation_bank_saving(rang, strPhase)
                Case "贷款记录"
                    rang = getRange(workBook, table)
                    importCorporation_loan(rang, strPhase)
                Case "对外担保记录"
                    rang = getRange(workBook, table)
                    importCorporation_external_guarantee(rang, strPhase)
                Case "诉讼记录"
                    rang = getRange(workBook, table)
                    importCorporation_lawsuit_record(rang, strPhase)
                Case "纳税记录"
                    rang = getRange(workBook, table)
                    importCorporation_ratepaying_record(rang, strPhase)
                Case "承兑汇票"
                    rang = getRange(workBook, table)
                    importCorporation_postal_order(rang, strPhase)
                Case "反担保物" 'qxd 2003-5-7 add 
                    rang = getRange(workBook, table)
                    importOppGuarantee(rang, strPhase)
                Case "财务分析"
                    rang = getRange(workBook, table)
                    importFinanceAnalyse(rang, strPhase, strCorporationCode)
                Case "现金流量分析"
                    rang = getRange(workBook, table)
                    importCashAnalyse(rang, strPhase, strCorporationCode)
                Case "资产负债表"
                    rang = getRange(workBook, table)
                    importBalanceSheet(rang, strPhase, strCorporationCode)
                Case "损益表"
                    rang = getRange(workBook, table)
                    importIncomeStatement(rang, strPhase, strCorporationCode)
                Case "现金流量"
                    rang = getRange(workBook, table)
                    importCashFlow(rang, strPhase)
                Case "现金流量表"
                    rang = getRange(workBook, table)
                    importCashFlowTable(rang, strPhase)
                Case "所有表"

                    '如果有多个保证企业的情况,先改变模板
                    Dim dsOpp As DataSet
                    Dim strSql As String
                    Dim strCorpCode
                    Dim i As Int16
                    dsOpp = gWs.FetchProjectCorporation(strProjectCode, "%", "2", "评审")
                    i = dsOpp.Tables(0).Rows.Count
                    If i > 1 Then
                        '该名
                        strCorpCode = dsOpp.Tables(0).Rows(0).Item("corporation_code").ToString()
                        workBook.Sheets(workBook.Sheets.Count - 2).name = "保证企业财务分析(" & strCorpCode & ")"
                        workBook.Sheets(workBook.Sheets.Count - 1).name = "保证企业资产负债表(" & strCorpCode & ")"
                        workBook.Sheets(workBook.Sheets.Count - 0).name = "保证企业损益表(" & strCorpCode & ")"
                        For i = 1 To i - 1 '增加后该名
                            strCorpCode = dsOpp.Tables(0).Rows(i).Item("corporation_code").ToString()
                            workBook.Sheets(workBook.Sheets.Count - 2).Copy(After:=workBook.Sheets(workBook.Sheets.Count))
                            workBook.Sheets(workBook.Sheets.Count).name = "保证企业财务分析(" & strCorpCode & ")"
                            workBook.Sheets(workBook.Sheets.Count - 2).Copy(After:=workBook.Sheets(workBook.Sheets.Count))
                            workBook.Sheets(workBook.Sheets.Count).name = "保证企业资产负债表(" & strCorpCode & ")"
                            workBook.Sheets(workBook.Sheets.Count - 2).Copy(After:=workBook.Sheets(workBook.Sheets.Count))
                            workBook.Sheets(workBook.Sheets.Count).name = "保证企业损益表(" & strCorpCode & ")"
                        Next
                    End If

                    rang = getRange(workBook, "反担保物")
                    importOppGuarantee(rang, strPhase)

                    rang = getRange(workBook, "基本财务数据")
                    importBaseBalanceSheet(rang, strPhase, strProjectCode.Substring(0, 5))
                    rang = getRange(workBook, "财务分析")
                    importFinanceAnalyse(rang, strPhase, strProjectCode.Substring(0, 5))
                    'rang = getRange(workBook, "现金流量分析")
                    'importCashAnalyse(rang, strPhase, strProjectCode.Substring(0, 5))
                    rang = getRange(workBook, "资产负债表")
                    'importBalanceSheet(rang, strPhase, strCorporationCode)
                    importBalanceSheet(rang, strPhase, strProjectCode.Substring(0, 5))
                    rang = getRange(workBook, "损益表")
                    'importIncomeStatement(rang, strPhase, strCorporationCode)
                    importIncomeStatement(rang, strPhase, strProjectCode.Substring(0, 5))
                    rang = getRange(workBook, "现金流量")
                    importCashFlow(rang, strPhase)
                    'rang = getRange(workBook, "现金流量表")
                    'importCashFlowTable(rang, strPhase)

                    '保证企业财务分析
                    i = dsOpp.Tables(0).Rows.Count
                    If i = 1 Then
                        strCorpCode = dsOpp.Tables(0).Rows(0).Item("corporation_code").ToString()
                        importFinanceAnalyse(getRange(workBook, "保证企业财务分析"), strPhase, strCorpCode)
                        importBalanceSheet(getRange(workBook, "保证企业资产负债表"), strPhase, strCorpCode)
                        importIncomeStatement(getRange(workBook, "保证企业损益表"), strPhase, strCorpCode)
                    ElseIf i > 1 Then
                        '如果有多个保证企业的情况,此时对增加的担保企业赋值
                        For i = 0 To i - 1
                            strCorpCode = dsOpp.Tables(0).Rows(i).Item("corporation_code").ToString()
                            importFinanceAnalyse(getRange(workBook, "保证企业财务分析(" & strCorpCode & ")"), strPhase, strCorpCode)
                            importBalanceSheet(getRange(workBook, "保证企业资产负债表(" & strCorpCode & ")"), strPhase, strCorpCode)
                            importIncomeStatement(getRange(workBook, "保证企业损益表(" & strCorpCode & ")"), strPhase, strCorpCode)
                        Next
                    End If

                    rang = getRange(workBook, "资信评分")
                    importCreditScoreSheet(rang, strPhase, strProjectCode.Substring(0, 5))

            End Select
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Sub
    '股权结构,1
    Private Sub importCorporation_stock_structure(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Try
            ds = gWs.FetchCorporationStockStructure(strProjectCode, "%", phase, -1)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        rang.Item(4 + i, 1) = .Item("stockholder_name")
                        rang.Item(4 + i, 2) = .Item("invest_form")
                        rang.Item(4 + i, 3) = .Item("invest_sum")
                        If Not .Item("proportion") Is System.DBNull.Value Then
                            Dim dProportion As Double
                            dProportion = CType(.Item("proportion"), Double) / 100.0
                            rang.Item(4 + i, 4) = dProportion
                        End If
                    End With
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '经营情况,2
    Private Sub importCorporation_business(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Try
            ds = gWs.FetchCorporationBusiness(strProjectCode, "%", phase, "%")
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        Dim strMonth As String
                        If Not .Item("month") Is System.DBNull.Value Then
                            strMonth = .Item("month")
                            If strMonth.Length > 3 Then
                                rang.Item(4 + i, 1) = strMonth.Substring(0, 4) & "年1月"
                                rang.Item(4 + i, 2) = strMonth.Substring(0, 4) & "年" & strMonth.Substring(4, strMonth.Length - 4) & "月"
                            End If
                        End If
                        rang.Item(4 + i, 3) = .Item("sales_income_plan")
                        rang.Item(4 + i, 4) = .Item("profit_plan")
                        rang.Item(4 + i, 5) = .Item("sales_income")
                        rang.Item(4 + i, 6) = .Item("profit")
                    End With
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '开户行及主要结算行情况,3
    Private Sub importCorporation_bank_saving(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Try
            ds = gWs.FetchCorporationBankSaving(strProjectCode, "%", phase, -1)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        rang.Item(4 + i, 1) = .Item("bank")
                        rang.Item(4 + i, 2) = .Item("accout")
                        rang.Item(4 + i, 3) = .Item("average_balance")
                        rang.Item(4 + i, 4) = .Item("bank_appraisement")
                    End With
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '贷款记录,4
    Private Sub importCorporation_loan(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Dim loanSum As Double = 0.0
        Try
            ds = gWs.FetchCorporationLoan(strProjectCode, "%", phase, -1)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        rang.Item(4 + i, 1) = .Item("loan_bank")
                        rang.Item(4 + i, 2) = .Item("currency")
                        rang.Item(4 + i, 3) = .Item("loan_sum")
                        If Not .Item("loan_sum") Is System.DBNull.Value Then
                            loanSum = loanSum + CType(.Item("loan_sum"), Double)
                        End If
                        rang.Item(4 + i, 4) = .Item("loan_type")
                        rang.Item(4 + i, 5) = .Item("loan_form")
                        rang.Item(4 + i, 6) = .Item("guaranty")
                        rang.Item(4 + i, 7) = .Item("term")
                        If Not .Item("loan_end_date") Is System.DBNull.Value Then
                            rang.Item(4 + i, 8) = CType(.Item("loan_end_date"), Date).ToString("yyyy年MM月dd日")
                        End If
                        If Not .Item("refund_date") Is System.DBNull.Value Then
                            rang.Item(4 + i, 9) = CType(.Item("refund_date"), Date).ToString("yyyy年MM月dd日")
                        End If
                    End With
                Next
                rang.Item(4 + count + 1, 1) = "合计"
                rang.Item(4 + count + 1, 3) = loanSum.ToString
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '对外担保记录,5
    Private Sub importCorporation_external_guarantee(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Try
            ds = gWs.FetchCorporationExternalGuarantee(strProjectCode, "%", phase, -1)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        rang.Item(4 + i, 1) = .Item("warrantee")
                        rang.Item(4 + i, 2) = .Item("loan_bank")
                        rang.Item(4 + i, 3) = .Item("currency")
                        rang.Item(4 + i, 4) = .Item("loan_sum")
                        If Not .Item("end_date") Is System.DBNull.Value Then
                            rang.Item(4 + i, 5) = CType(.Item("end_date"), Date).ToString("yyyy年MM月dd日")
                        End If
                        rang.Item(4 + i, 6) = .Item("remark")
                    End With
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '诉讼记录,6
    Private Sub importCorporation_lawsuit_record(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Try
            ds = gWs.FetchCorporationLawsuitRecord(strProjectCode, "%", phase, -1)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        rang.Item(4 + i, 1) = .Item("accuser")
                        rang.Item(4 + i, 2) = .Item("respondent")
                        rang.Item(4 + i, 3) = .Item("sum")
                        rang.Item(4 + i, 4) = .Item("reason")
                    End With
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '纳税记录,7
    Private Sub importCorporation_ratepaying_record(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Try
            ds = gWs.FetchCorporationRatepayingRecord(strProjectCode, "%", phase, -1)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        Dim strMonth As String
                        If Not .Item("month") Is System.DBNull.Value Then
                            strMonth = .Item("month")
                            If strMonth.Length > 3 Then
                                rang.Item(4 + i, 1) = strMonth.Substring(0, 4) & "年" & strMonth.Substring(4, strMonth.Length - 4) & "月"
                            End If
                        End If
                        rang.Item(4 + i, 2) = .Item("sum")
                    End With
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '承兑汇票,8
    Private Sub importCorporation_postal_order(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim count As Integer
        Dim maxSum As Double = 0.0
        Dim sum As Double = 0.0
        Try
            ds = gWs.FetchCorporationPostalOrder(strProjectCode, "%", phase, -1)
            If Not ds Is Nothing Then
                count = ds.Tables(0).Rows.Count
                For i = 0 To count - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        rang.Item(4 + i, 1) = .Item("bank")
                        rang.Item(4 + i, 2) = .Item("max_sum")
                        If Not .Item("max_sum") Is System.DBNull.Value Then
                            maxSum = maxSum + CType(.Item("max_sum"), Double)
                        End If
                        rang.Item(4 + i, 3) = .Item("sum")
                        If Not .Item("sum") Is System.DBNull.Value Then
                            sum = sum + CType(.Item("sum"), Double)
                        End If
                        rang.Item(4 + i, 4) = .Item("guaranty")
                    End With
                Next
                rang.Item(4 + count + 1, 1) = "合计"
                rang.Item(4 + count + 1, 2) = maxSum
                rang.Item(4 + count + 1, 3) = sum
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '资信评分
    Private Sub importCreditScoreSheet(ByVal rang As Excel.Range, ByVal phase As String, ByVal strCorpCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear, strBBLastYear, strLastYearSameTerm As String
        Dim dYear, lastYear, beforeLastYear, bbLastYear As Double
        Dim strItem As String() = {"总资产", "净资产", _
                                   "销售额", "利润总额" _
                                  }
        Dim strItemType As String() = {"01", "01", "02", "02"}
        'qxd modify 2003-11-3  制作评审报告时生成的表中，外收净额有错误:外收净额＝营业外收入(b12)-营业外支出(b13)
        'Dim strItemCode As String() = {"b01", "sum1(b02+b03)", "sum2(b06+b07+b08)", "sum3(b11-b12)", "b10", "b15", "b18"}
        Dim strItemCode As String() = {"a34", "sum1(a65-a29)", "b01", "b14"}
        Try
            'qxd modify 2004-12-6
            '''''Dim strApplyDate As String
            '''''strApplyDate = getApplyDate(strProjectCode)
            '''''strMonth = CType(strApplyDate, Date).Year '今年
            '''''dYear = CType(strMonth, Double)
            '''''lastYear = dYear - 1 '去年
            '''''strLastYear = lastYear.ToString
            '''''beforeLastYear = dYear - 2 '前年
            '''''strBeforeLastYear = beforeLastYear.ToString
            '''''bbLastYear = dYear - 3 '上前年
            '''''strBBLastYear = bbLastYear.ToString
            ''''''strCorporationCode = strProjectCode.Substring(0, 5)

            '最新财务数据是从表project_finance_analyse中取得,这个表中最多有三个不同年月的数据,
            '三个年月按年月的先后分为今年,去年,前年

            strSql = "select * from project_credit_appraise where project_code='" & strProjectCode & "' and corporation_code='" & strCorpCode & "' and phase='" & phase & "' and substring([month],5,2)='12' and substring([month_last],5,2)='12' and substring([month_last],1,4)=substring([month],1,4)-1 order by month"
            Dim dt As DataTable = gWs.GetCommonQueryInfo(strSql).Tables(0)

            If dt.Rows.Count <= 0 Then
                Exit Sub
            Else

                'strLastYear = Year(gWs.GetSysTime) - 1 & "12"

                'If strLastYear <> strMonth Then
                'MyMsgBox("没有" & strLastYear.Substring(0, 4) & "年的资信评分数据!", "请重新作一次" & strLastYear & "年的资信评分,如果还是出现错误,请于系统管理员联系!")
                'Exit Sub
                'End If
                Dim i As Integer

                For i = 0 To dt.Rows.Count - 1

                    Try
                        strMonth = dt.Rows(i).Item("month")

                        'edit by 9sky 20050705   修改代码顺序

                        rang.Item(3 + i, 1) = strMonth.Substring(0, 4) & "年"

                        rang.Item(3 + i, 2) = dt.Rows(i).Item("quantity_score")
                        rang.Item(3 + i, 3) = dt.Rows(i).Item("quality_score")
                        rang.Item(3 + i, 4) = dt.Rows(i).Item("total_score")


                        'If dt.Rows.Count >= 2 Then
                        '    strMonth = dt.Rows(1).Item("month")
                        '    strBeforeLastYear = Year(gWs.GetSysTime) - 2 & "12"
                        '    'If strBeforeLastYear <> strMonth Then
                        '    '    MyMsgBox("没有" & strBeforeLastYear.Substring(0, 4) & "年的资信评分数据!", "请重新作一次" & strBeforeLastYear & "年的资信评分,如果还是出现错误,请于系统管理员联系!")
                        '    '    Exit Sub
                        '    'End If

                        '    rang.Item(3, 1) = strMonth.Substring(0, 4) & "年"

                        '    rang.Item(3, 2) = dt.Rows(1).Item("quantity_score")
                        '    rang.Item(3, 3) = dt.Rows(1).Item("quality_score")
                        '    rang.Item(3, 4) = dt.Rows(1).Item("total_score")

                        'End If

                    Catch
                    End Try
                Next
            End If


        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '基本财务数据
    Private Sub importBaseBalanceSheet(ByVal rang As Excel.Range, ByVal phase As String, ByVal strCorpCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear, strBBLastYear, strLastYearSameTerm As String
        Dim dYear, lastYear, beforeLastYear, bbLastYear As Double
        Dim strItem As String() = {"总资产", "净资产", _
                                   "销售额", "利润总额" _
                                  }
        Dim strItemType As String() = {"01", "01", "02", "02"}
        'qxd modify 2003-11-3  制作评审报告时生成的表中，外收净额有错误:外收净额＝营业外收入(b12)-营业外支出(b13)
        'Dim strItemCode As String() = {"b01", "sum1(b02+b03)", "sum2(b06+b07+b08)", "sum3(b11-b12)", "b10", "b15", "b18"}
        Dim strItemCode As String() = {"a34", "sum1(a34-a57-a32)", "b01", "b14"}
        Try
            'qxd modify 2004-12-6
            '''''Dim strApplyDate As String
            '''''strApplyDate = getApplyDate(strProjectCode)
            '''''strMonth = CType(strApplyDate, Date).Year '今年
            '''''dYear = CType(strMonth, Double)
            '''''lastYear = dYear - 1 '去年
            '''''strLastYear = lastYear.ToString
            '''''beforeLastYear = dYear - 2 '前年
            '''''strBeforeLastYear = beforeLastYear.ToString
            '''''bbLastYear = dYear - 3 '上前年
            '''''strBBLastYear = bbLastYear.ToString
            ''''''strCorporationCode = strProjectCode.Substring(0, 5)

            '最新财务数据是从表project_finance_analyse中取得,这个表中最多有三个不同年月的数据,
            '三个年月按年月的先后分为今年,去年,前年

            strSql = "select distinct month from project_finance_analyse where project_code='" & strProjectCode & "' and corporation_code='" & strCorpCode & "' and phase='" & phase & "' order by month desc"
            Dim dt As DataTable = gWs.GetCommonQueryInfo(strSql).Tables(0)

            If dt.Rows.Count > 3 Then
                MyMsgBox("财务分析数据多余三个不同的年月,系统无法导出!", "请重新作一次财务分析,如果还是出现错误,请于系统管理员联系!")
                'SWDialogBox.MessageBox.Show("财务分析数据多余三个不同的年月,系统无法导出!", "错误提示", "请重新作一次财务分析,如果还是出现错误,请于系统管理员联系!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
                Exit Sub
            ElseIf dt.Rows.Count <= 0 Then
                Exit Sub
            Else
                strMonth = dt.Rows(0).Item("month")
                Try
                    'edit by 9sky 20050705   修改代码顺序
                    strLastYear = (strMonth.Substring(0, 4) - 1).ToString & "12"
                    rang.Item(2, 3) = strLastYear.Substring(0, 4) & "年"

                    strBeforeLastYear = (strMonth.Substring(0, 4) - 2).ToString & "12"
                    rang.Item(2, 2) = strBeforeLastYear.Substring(0, 4) & "年"

                    rang.Item(2, 4) = strMonth.Substring(0, 4) & "年" & strMonth.Substring(4, 2) & "月"

                    strLastYearSameTerm = (strMonth.Substring(0, 4) - 1).ToString & strMonth.Substring(4, 2)
                    rang.Item(2, 5) = strLastYearSameTerm.Substring(0, 4) & "年同期"

                Catch
                End Try
            End If

            strSql = "{project_code='" & strProjectCode & "' and phase='" & phase & "' and corporation_code='" & strCorpCode & _
                     "' and (month like '" & strMonth & "%' or month like '" & strLastYear & _
                     "%' or month like '" & strBeforeLastYear & "%' or month like '" & strLastYearSameTerm & "%') order by month desc}"

            ds = gWs.FetchCorporationAccount(strSql) '3
            If Not ds Is Nothing Then
                j = strItem.Length
                Dim strValue As String
                Dim drTemp As DataRow
                'rang.Item(2, 1) = Me.strCorporationName
                'rang.Item(5, 2) = strBeforeLastYear.Substring(0, 4) & "年"
                'rang.Item(5, 3) = strLastYear.Substring(0, 4) & "年"

                'edit by 9sky 20050705 增加判断
                '前年
                If Not strBeforeLastYear Is Nothing Then setBaseBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, j, strBeforeLastYear, 2)
                '去年
                If Not strLastYear Is Nothing Then setBaseBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, j, strLastYear, 3)
                '今年
                If Not strMonth Is Nothing Then setBaseBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, j, strMonth, 4)
                '去年同期
                If Not strLastYearSameTerm Is Nothing Then setBaseBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, j, strLastYearSameTerm, 5)


                'For j = 0 To j - 1
                '    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strMonth & "%' "
                '    If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                '        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("month") Is System.DBNull.Value Then
                '            Dim mon As String
                '            Dim len As Integer
                '            mon = ds.Tables(0).Select(strSql, "month desc")(0).Item("month")
                '            'len = strMonth.Length
                '            'mon = mon.Substring(len, mon.Length - len)
                '            rang.Item(5, 4) = mon.Substring(0, 4) & "年" & mon.Substring(4, 2) & "月"
                '            Exit For
                '        End If
                '    End If
                'Next
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '设置基本财务数据
    Private Sub setBaseBalanceSheetRangByYear(ByVal strItemCode As String(), ByVal strItemType As String(), _
        ByVal ds As DataSet, ByVal rang As Excel.Range, ByVal j As Integer, ByVal strBeforeLastYear As String, _
        ByVal colExcel As Integer)
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2 As String
        Dim dValue_1, dValue_2, dValue As Double
        For j = 0 To j - 1
            If strItemCode(j).StartsWith("sum1") Then
                strSql = "item_type='" & strItemType(j) & "' and item_code='a34' and month like '" & strBeforeLastYear & "%'"
                If ds.Tables(0).Select(strSql).Length > 0 Then
                    strValue = getItemValue(strItemType, "a34", strBeforeLastYear, ds, j) - getItemValue(strItemType, "a57", strBeforeLastYear, ds, j) - getItemValue(strItemType, "a32", strBeforeLastYear, ds, j)
                Else
                    strValue = ""
                End If

                If strValue = "" Then
                    rang.Item(3 + j, colExcel) = strValue
                Else
                    rang.Item(3 + j, colExcel) = changedStringToTenThousand(strValue)
                End If

            Else
                strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strBeforeLastYear & "%'"
                If ds.Tables(0).Select(strSql).Length > 0 Then
                    If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                        strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                    Else
                        strValue = "0"
                    End If
                Else
                    strValue = ""
                End If

                If strValue = "" Then
                    rang.Item(3 + j, colExcel) = strValue
                Else
                    rang.Item(3 + j, colExcel) = changedStringToTenThousand(strValue)
                End If

            End If
            'qxd modify 2003-11-3
            'rang.Item(6 + j, colExcel) = strValue
        Next
    End Sub

    '财务分析,9
    Private Sub importFinanceAnalyse(ByVal rang As Excel.Range, ByVal phase As String, ByVal strCorporationCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear As String '今年,去年,前年
        'Dim dYear, lastYear, beforeLastYear As Double
        Dim strItem As String() = {"总资产", "营运资金", "净资产", "资产负债率 ", _
                                    "流动比率 ", "速动比率 ", "长期资产适宜率", "齿轮比率", _
                                    "或有负债比率", "贷款按期偿还率", "年营业收入", "销售利润率", _
                                    "应收帐款周转率", "存货周转率", "净资产回报率", "利息保障倍数", _
                                    "净资产增长率", "销售收入增长率", "利润增长率", "利润增长额" _
                                    }
        Dim strIndexType As String() = {"11", "11", "11", "11", "11", "11", "11", "11", "11", "11", _
                                        "12", "12", "12", "12", "12", "12", _
                                        "13", "13", "13", "13"}
        Dim strIndexID As String() = {"001", "002", "003", "004", "005", "006", "007", "008", "009", "010", _
                                        "001", "002", "003", "004", "005", "006", _
                                        "001", "002", "003", "004"}
        Try
            Dim strSQLIndex, strSQLSystem As String
            Dim strLastestMonth, strSqlMonth As String

            '最新财务数据是从表project_finance_analyse中取得,这个表中最多有三个不同年月的数据,
            '三个年月按年月的先后分为今年,去年,前年

            strSql = "select distinct month from project_finance_analyse where project_code='" & strProjectCode & "' and corporation_code='" & strCorporationCode & "' and phase='" & strPhase & "' order by month desc"

            Dim dt As DataTable = gWs.GetCommonQueryInfo(strSql).Tables(0)

            If dt.Rows.Count > 3 Then
                MyMsgBox("财务分析数据多余三个不同的年月,系统无法导出!", "请重新作一次财务分析,如果还是出现错误,请于系统管理员联系!")
                'SWDialogBox.MessageBox.Show("财务分析数据多余三个不同的年月,系统无法导出!", "错误提示", "请重新作一次财务分析,如果还是出现错误,请于系统管理员联系!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
                Exit Sub
            ElseIf dt.Rows.Count <= 0 Then
                Exit Sub
            Else
                strMonth = dt.Rows(0).Item("month")
                rang.Item(3, 7) = strMonth.Substring(0, 4)
                Try
                    strLastYear = (strMonth.Substring(0, 4) - 1).ToString & "12"
                    strBeforeLastYear = (strMonth.Substring(0, 4) - 2).ToString & "12"
                    rang.Item(2, 4) = strBeforeLastYear.Substring(0, 4) & "年"
                    rang.Item(2, 5) = strLastYear.Substring(0, 4) & "年"
                    rang.Item(2, 7) = strMonth.Substring(0, 4) & "年" & strMonth.Substring(4, 2) & "月"
                Catch
                End Try
            End If


            strSql = "{project_code='" & strProjectCode & "' and phase='" & phase & "' and corporation_code ='" & strCorporationCode & "'}"

            ds = gWs.FetchProjectFinanceAnalyse(strSql)

            '获取财务数据 end

            Dim dsIndex As DataSet

            '对excel的对应位置赋值 start
            dsIndex = gWs.FetchCreditQuantityIndex("{System_id='1'}")
            If ds Is Nothing Then Exit Sub
            Dim strValue As String
            Dim drTemp As DataRow
            'rang.Item(3, 4) = strBeforeLastYear.Substring(0, 4)
            'rang.Item(3, 5) = strLastYear.Substring(0, 4)
            'rang.Item(3, 7) = strMonth.Substring(0, 4)

            '前年
            j = strItem.Length
            For j = 0 To j - 1
                strSql = "index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "' and month like '" & strBeforeLastYear & "' "
                If ds.Tables(0).Select(strSql).Length > 0 Then
                    If Not ds.Tables(0).Select(strSql)(0).Item("index_value") Is System.DBNull.Value Then
                        'strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                        strValue = changedStringToTenThousand(ds.Tables(0).Select(strSql)(0).Item("index_value"))
                        strSQLIndex = " index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "'"
                        If Not dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") Is System.DBNull.Value Then
                            If dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") = "%" Then
                                strValue = (CType(ds.Tables(0).Select(strSql)(0).Item("index_value"), Double) / 100.0).ToString
                            ElseIf dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") = "原值" Then
                                strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                            End If
                        End If
                    Else
                        strValue = "/"
                    End If
                    rang.Item(3 + j, 4) = strValue
                End If
            Next
            '去年
            j = strItem.Length
            For j = 0 To j - 1
                strSql = "index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "' and month like '" & strLastYear & "' "
                If ds.Tables(0).Select(strSql).Length > 0 Then
                    If Not ds.Tables(0).Select(strSql)(0).Item("index_value") Is System.DBNull.Value Then
                        'strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                        strValue = changedStringToTenThousand(ds.Tables(0).Select(strSql)(0).Item("index_value"))
                        strSQLIndex = "index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "'"
                        If Not dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") Is System.DBNull.Value Then
                            If dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") = "%" Then
                                strValue = (CType(ds.Tables(0).Select(strSql)(0).Item("index_value"), Double) / 100.0).ToString
                            ElseIf dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") = "原值" Then
                                strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                            End If
                        End If
                    Else
                        strValue = "/"
                    End If
                    rang.Item(3 + j, 5) = strValue
                End If
            Next
            '今年
            j = strItem.Length
            If Not strMonth = "" Then '否则今年的为空
                For j = 0 To j - 1
                    strSql = "index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "' and month like '" & strMonth & "%' "
                    If ds.Tables(0).Select(strSql).Length > 0 Then
                        If Not ds.Tables(0).Select(strSql)(0).Item("index_value") Is System.DBNull.Value Then
                            'strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                            strValue = changedStringToTenThousand(ds.Tables(0).Select(strSql)(0).Item("index_value"))
                            strSQLIndex = "index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "'"
                            If Not dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") Is System.DBNull.Value Then
                                If dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") = "%" Then
                                    strValue = (CType(ds.Tables(0).Select(strSql)(0).Item("index_value"), Double) / 100.0).ToString
                                ElseIf dsIndex.Tables(0).Select(strSQLIndex)(0).Item("unit") = "原值" Then
                                    strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                                End If
                            End If
                        Else
                            strValue = "/"
                        End If
                        rang.Item(3 + j, 7) = strValue
                    End If
                Next
            End If
            '对excel对应位置赋值 end


        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '现金流量分析,10
    Private Sub importCashAnalyse(ByVal rang As Excel.Range, ByVal phase As String, ByVal strCorporationCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear As String
        Dim dYear, lastYear, beforeLastYear As Double
        Dim strItem As String() = {"经营产生的现金流入量/流动负债", "经营产生的现金流入量/负债总额", _
                                    "经营产生的现金流入量/主营业务收入", "经营产生的现金流量净额/流动负债", _
                                    "经营产生的现金流量净额/负债总额", "经营产生的现金流量净额/主营业务收入" _
                                    }
        Dim strIndexType As String() = {"14", "14", "14", "14", "14", "14"}
        Dim strIndexID As String() = {"001", "002", "003", "004", "005", "006"}
        Try
            strSql = "select distinct month from project_finance_analyse where project_code='" & strProjectCode & "' and corporation_code='" & strCorporationCode & "' and phase='" & strPhase & "' order by month desc"

            Dim dt As DataTable = gWs.GetCommonQueryInfo(strSql).Tables(0)
            If dt.Rows.Count > 3 Then
                MyMsgBox("财务分析数据多余三个不同的年月,系统无法导出!", "请重新作一次财务分析,如果还是出现错误,请于系统管理员联系!")
                Exit Sub
            ElseIf dt.Rows.Count <= 0 Then
                Exit Sub
            Else
                strMonth = dt.Rows(0).Item("month")
                Try
                    strLastYear = dt.Rows(1).Item("month")
                    rang.Item(2, 4) = strLastYear.Substring(0, 4) & "年"
                    strBeforeLastYear = dt.Rows(2).Item("month")
                    rang.Item(2, 3) = strBeforeLastYear.Substring(0, 4) & "年"

                Catch
                End Try
            End If

            strSql = "{project_code='" & strProjectCode & "' and phase='" & phase & _
                     "' and (month like '" & strMonth & "' or month like '" & strLastYear & "' or month like '" & strBeforeLastYear & "') }"

            ds = gWs.FetchProjectFinanceAnalyse(strSql)
            If Not ds Is Nothing Then
                j = strItem.Length
                Dim strValue As String
                Dim drTemp As DataRow
                'rang.Item(3, 3) = strBeforeLastYear.Substring(0, 4) & "年"
                'rang.Item(3, 4) = strLastYear.Substring(0, 4) & "年"
                'rang.Item(3, 7) = strMonth & "年1月"
                '前年
                For j = 0 To j - 1
                    strSql = "index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "' and month like '" & strBeforeLastYear & "' "
                    If ds.Tables(0).Select(strSql).Length > 0 Then
                        If Not ds.Tables(0).Select(strSql)(0).Item("index_value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                            rang.Item(3 + j, 3) = strValue
                        End If
                    End If
                Next
                '去年
                For j = 0 To j - 1
                    strSql = "index_type='" & strIndexType(j) & "' and index_id='" & strIndexID(j) & "' and month like '" & strLastYear & "' "
                    If ds.Tables(0).Select(strSql).Length > 0 Then
                        If Not ds.Tables(0).Select(strSql)(0).Item("index_value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql)(0).Item("index_value")
                            rang.Item(3 + j, 4) = strValue
                        End If
                    End If
                Next
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '合计所需的金额
    Private Function sumItem(ByVal strItemType As String, ByVal strItemCode As String, ByVal strBeforeLastYear As String, ByVal ds As DataSet) As Double

        If strItemCode Is Nothing Or strItemType Is Nothing Then
            Return 0
        End If
        Dim strICode As String() = strItemCode.Split("+"c)
        Dim i As Int16 = strICode.Length
        Dim dSum As Double
        If i > 0 Then
            For i = 0 To i - 1
                dSum += getItemCodeValue(strItemType, strICode(i), strBeforeLastYear, ds)
            Next
        End If
        Return dSum

    End Function

    Private Function getItemCodeValue(ByVal strItemType As String, ByVal strItemCode As String, ByVal strYear As String, ByVal ds As DataSet) As Double
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2 As String
        Dim dValue_1, dValue_2, dValue As Double
        Try
            strSql = "item_type='" & strItemType & "' and item_code='" & strItemCode & "' and month like '" & strYear & "%' "
            If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                    strValue_1 = ds.Tables(0).Select(strSql)(0).Item("value")
                    dValue_1 = IIf(strValue_1 = "", 0, CType(strValue_1, Double))
                End If
            End If
        Catch
        End Try
        Return dValue_1
    End Function
    '资产负债表,11
    Private Sub importBalanceSheet(ByVal rang As Excel.Range, ByVal phase As String, ByVal strCorpCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear, strBBLastYear, strLastYearSameTerm As String
        Dim dYear, lastYear, beforeLastYear, bbLastYear As Double
        'Dim strItem As String() = {"贷币资金", "应收", "其中：应收账款", _
        '                            "存货", "待摊", "长期投资", _
        '                            "固定资产", "总资产", "短期投资", _
        '                            "无形资产及其他资产", "借款", "应付", _
        '                            "其中：应收账款", "应交税金", "实收资本", _
        '                            "资本公积", "留存收益", "负债及权益", _
        '                             "预付帐款", "预收帐款" _
        '                            }

        'Dim strItem As String() = {"贷币资金", "短期投资", "应收帐款", _
        '                           "预付帐款", "其他应收", "存货", _
        '                           "待摊", "长期投资", "固定资产", _
        '                           "无形资产及其他资产", "总资产", "借款", _
        '                           "应付帐款", "预收帐款", "应交税金", _
        '                           "其他应付", "", "实收资本", _
        '                            "资本公积", "留存收益", "", _
        '                            "负债及权益" _
        '                           }
        Dim strItem As String() = {"贷币资金", "短期投资", "应收票据", _
                                    "应收帐款", _
                                    "预付帐款", "其他应收", "存货", _
                                    "待摊", "长期投资", "固定资产", _
                                    "无形资产及其他资产", "总资产", "借款", _
                                    "应付票据", _
                                    "应付帐款", "预收帐款", "应交税金", _
                                    "其他应付", "", "实收资本", _
                                    "资本公积", "留存收益", "", _
                                    "负债及权益" _
                                           }

        'Dim strItemCode As String() = {"a01", "sum(a03+a04+a05+a07+a09+a12+a13)", "a06", _
        '                                "a10", "sum(a11+a30)", "a17", _
        '                                "a28", "a34", "a02", _
        '                                "sum(a29+a31)", "sum(a35+a50)", "sum(a36+a39+a40+a41+a43+a44+a46+a47+a48+a51+a52+a53+a54+a56+a45)", _
        '                                "a06", "a42", "a58", _
        '                                "a59", "sum(a60+a62)", "a66", _
        '                                "a08", "a38" _
        '                                }
        'Dim strItemCode As String() = {"a01", "a02", "a06", _
        '                                "a08", "sum(a03+a04+a05+a07+a09+a12+a13)", "a10", _
        '                                "sum(a11+a30)", "a17", "a28", _
        '                                "sum(a29+a31)", "a34", "sum(a35+a50)", _
        '                                "a37", "a38", "a42", _
        '                                "sum(a36+a39+a40+a41+a43+a44+a46+a47+a48+a51+a52+a53+a54+a56+a45)", "", "a58", _
        '                                "a59", "sum(a60+a62)", "", _
        '                                "a66" _
        '                                }
        Dim strItemCode As String() = {"a01", "a02", "a03", _
                                        "a06", _
                                        "a08", "sum(a04+a05+a07+a09+a12+a13)", "a10", _
                                        "sum(a11+a30)", "a17", "a28", _
                                        "sum(a29+a31)", "a34", "sum(a35+a50)", _
                                        "a36", _
                                        "a37", "a38", "a42", _
                                        "sum(a39+a40+a41+a43+a44+a46+a47+a48+a51+a52+a53+a54+a56+a45)", "", "a58", _
                                        "a59", "sum(a60+a62)", "", _
                                        "a66" _
                                        }

        Dim strItemType As String() = {"01", "01", "01", _
                                        "01", "01", "01", _
                                        "01", "01", "01", _
                                        "01", "01", "01", _
                                        "01", "01", "01", _
                                        "01", "01", "01", _
                                        "01", "01", "01", _
                                        "01", "01", "01" _
                                        }

        Try
            'qxd modify 2004-12-6
            ''''Dim strApplyDate As String
            ''''strApplyDate = getApplyDate(strProjectCode)
            ''''strMonth = CType(strApplyDate, Date).Year '今年(申请年)
            ''''dYear = CType(strMonth, Double)
            ''''lastYear = dYear - 1 '去年
            ''''strLastYear = lastYear.ToString
            ''''beforeLastYear = dYear - 2 '前年
            ''''strBeforeLastYear = beforeLastYear.ToString

            '最新财务数据是从表project_finance_analyse中取得,这个表中最多有三个不同年月的数据,
            '三个年月按年月的先后分为今年,去年,前年

            strSql = "select distinct month from project_finance_analyse where project_code='" & strProjectCode & "' and corporation_code='" & strCorpCode & "' and phase='" & phase & "' order by month desc"
            Dim dt As DataTable = gWs.GetCommonQueryInfo(strSql).Tables(0)

            If dt.Rows.Count > 3 Then
                MyMsgBox("财务分析数据多余三个不同的年月,系统无法导出!", "请重新作一次财务分析,如果还是出现错误,请于系统管理员联系!")
                'SWDialogBox.MessageBox.Show("财务分析数据多余三个不同的年月,系统无法导出!", "错误提示", "请重新作一次财务分析,如果还是出现错误,请于系统管理员联系!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
                Exit Sub
            ElseIf dt.Rows.Count <= 0 Then
                Exit Sub
            Else
                strMonth = dt.Rows(0).Item("month")
                Try
                    'edity by 9sky 20050705 修改了代码顺序
                    'strLastYear = dt.Rows(1).Item("month")
                    strLastYear = (strMonth.Substring(0, 4) - 1).ToString & "12"
                    strLastYearSameTerm = (strMonth.Substring(0, 4) - 1).ToString & strMonth.Substring(4, 2)
                    rang.Item(4, 3) = strLastYear.Substring(0, 4) & "年末"
                    rang.Item(4, 8) = strLastYear.Substring(0, 4) & "年末"
                    rang.Item(4, 5) = strLastYearSameTerm.Substring(0, 4) & "年同期"
                    rang.Item(4, 10) = strLastYearSameTerm.Substring(0, 4) & "年同期"
                    'strBeforeLastYear = dt.Rows(2).Item("month")
                    strBeforeLastYear = (strMonth.Substring(0, 4) - 2).ToString & "12"
                    rang.Item(4, 2) = strBeforeLastYear.Substring(0, 4) & "年末"
                    rang.Item(4, 7) = strBeforeLastYear.Substring(0, 4) & "年末"
                    rang.Item(4, 4) = strMonth.Substring(0, 4) & "年" & strMonth.Substring(4, 2) & "月"
                    rang.Item(4, 9) = strMonth.Substring(0, 4) & "年" & strMonth.Substring(4, 2) & "月"
                Catch
                End Try
            End If


            'strCorporationCode = strProjectCode.Substring(0, 5)
            strSql = "{project_code='" & strProjectCode & "' and phase='" & phase & "' and corporation_code='" & strCorpCode & _
                     "' and (month like '" & strMonth & "%' or month like '" & strLastYear & _
                     "%' or month like '" & strBeforeLastYear & "%' or month like '" & strLastYearSameTerm & "%') order by month desc}"

            ds = gWs.FetchCorporationAccount(strSql) '所有的这几年财务数据'4
            If Not ds Is Nothing Then
                j = strItem.Length
                Dim strValue As String
                Dim drTemp As DataRow


                '设置一些基本信息
                'rang.Item(2, 1) = Me.strCorporationName
                'rang.Item(5, 2) = strBeforeLastYear.Substring(0, 4) & "年末"
                'rang.Item(5, 3) = strLastYear.Substring(0, 4) & "年末"
                'rang.Item(5, 6) = strBeforeLastYear.Substring(0, 4) & "年末"
                'rang.Item(5, 7) = strLastYear.Substring(0, 4) & "年末"
                'edit by 9sky 20050705 增加了判断条件
                '前年(左半部分)
                If Not strBeforeLastYear Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, 12, strBeforeLastYear, 2) '数字分别为：行数；列数
                '去年(左半部分)
                If Not strLastYear Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, 12, strLastYear, 3)
                '今年(左半部分
                If Not strMonth Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, 12, strMonth, 4)
                '去年同期(左半部分)
                If Not strLastYearSameTerm Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, 12, strLastYearSameTerm, 5)
                '前年(右半部分)
                If Not strBeforeLastYear Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, j - 12, strBeforeLastYear, 7, False)
                '去年(右半部分)
                If Not strLastYear Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, j - 12, strLastYear, 8, False)
                '今年(右半部分)
                If Not strMonth Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, j - 12, strMonth, 9, False)
                '去年同期(右半部分)
                If Not strLastYearSameTerm Is Nothing Then setBalanceSheetRangByYear(strItemCode, strItemType, ds, rang, 12, strLastYearSameTerm, 10, False)

                'For j = 0 To j - 1
                '    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strMonth & "%' "
                '    If ds.Tables(0).Select(strSql).Length > 0 Then
                '        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("month") Is System.DBNull.Value Then
                '            Dim mon As String
                '            Dim len As Integer
                '            mon = ds.Tables(0).Select(strSql, "month desc")(0).Item("month")
                '            'len = strMonth.Length
                '            'mon = mon.Substring(len, mon.Length - len)
                '            'rang.Item(5, 4) = strMonth & "年" & mon & "月末"
                '            'rang.Item(5, 8) = strMonth & "年" & mon & "月末"
                '            rang.Item(4, 5) = mon.Substring(0, 4) & "年" & mon.Substring(4, 2) & "月"
                '            rang.Item(4, 10) = mon.Substring(0, 4) & "年" & mon.Substring(4, 2) & "月"
                '            Exit For
                '        End If
                '    End If
                'Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '设置资产负债表
    Private Sub setBalanceSheetRangByYear(ByVal strItemCode As String(), ByVal strItemType As String(), _
        ByVal ds As DataSet, ByVal rang As Excel.Range, ByVal j As Integer, ByVal strBeforeLastYear As String, _
        ByVal colExcel As Integer, Optional ByVal isLeft As Boolean = True)
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2 As String
        Dim dValue_1, dValue_2, dValue As Double
        Dim dValueTemp(9) As Double
        Dim iStart As Int16
        Dim iEnd As Int16
        Dim rownum As Int16

        If isLeft = False Then
            iStart = j
            iEnd = j + j
        Else
            iStart = 0
            iEnd = j
        End If

        strSql = "month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then

            For j = iStart To iEnd - 1

                If strItemCode(j).StartsWith("sum") Then
                    Dim dSum As Double
                    dSum = Me.sumItem(strItemType(j), strItemCode(j).Substring(4, strItemCode(j).Length - 5), strBeforeLastYear, ds)
                    strValue = dSum.ToString()
                Else
                    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strBeforeLastYear & "%' "
                    If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                        Else
                            strValue = "0"
                        End If
                    Else
                        strValue = ""
                    End If
                End If
                'qxd modify 2003-11-3
                'rang.Item(6 + j, colExcel) = strValue

                If isLeft = False Then
                    rownum = j - iStart
                Else
                    rownum = j
                End If

                If strValue = "" Then
                    rang.Item(5 + rownum, colExcel) = strValue
                Else
                    rang.Item(5 + rownum, colExcel) = changedStringToTenThousand(strValue)
                End If

            Next
        Else
            For j = iStart To iEnd - 1

                If isLeft = False Then
                    rownum = j - iStart
                Else
                    rownum = j
                End If
                rang.Item(5 + rownum, colExcel) = ""
            Next

        End If
    End Sub
    '求和
    Private Function getSumValue(ByVal strItemType As String(), ByVal itemCode_A As String, ByVal itemCode_B As String, ByVal strBeforeLastYear As String, ByVal ds As DataSet, ByVal j As Integer, ByVal isAdd As Boolean)
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2 As String
        Dim dValue_1, dValue_2, dValue As Double
        strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_A & "' and month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql).Length > 0 Then
            If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                strValue_1 = ds.Tables(0).Select(strSql)(0).Item("value")
                dValue_1 = IIf(strValue_1 = "", 0, CType(strValue_1, Double))
            End If
        Else
            Return ""
        End If
        strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_B & "' and month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql).Length > 0 Then
            If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                strValue_2 = ds.Tables(0).Select(strSql)(0).Item("value")
                dValue_2 = IIf(strValue_2 = "", 0, CType(strValue_2, Double))
            End If
        Else
            Return ""
        End If
        If isAdd Then
            dValue = dValue_1 + dValue_2
        Else
            dValue = dValue_1 - dValue_2
        End If
        strValue = dValue.ToString
        Return strValue
    End Function
    '获得每项的值
    Private Function getItemValue(ByVal strItemType As String(), ByVal itemCode_A As String, ByVal strBeforeLastYear As String, ByVal ds As DataSet, ByVal j As Integer)
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2 As String
        Dim dValue_1, dValue_2, dValue As Double
        Try
            strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_A & "' and month like '" & strBeforeLastYear & "%' "
            If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                    strValue_1 = ds.Tables(0).Select(strSql)(0).Item("value")
                    dValue_1 = IIf(strValue_1 = "", 0, CType(strValue_1, Double))
                End If
            End If
        Catch
        End Try
        Return dValue_1
    End Function
    '损益表,12
    Private Sub importIncomeStatement(ByVal rang As Excel.Range, ByVal phase As String, ByVal strCorpCode As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear, strBBLastYear, strLastYearSameTerm As String
        Dim dYear, lastYear, beforeLastYear, bbLastYear As Double
        Dim strItem As String() = {"收入", "成本税金", _
                                     "期间费用", "其他业务利润", _
                                     "外收净额", "投资收益", _
                                     "所得税", "净利润", _
                                     "毛利率", "净利率" _
                                    }
        Dim strItemType As String() = {"02", "02", "02", "02", "02", "02", "02", "02", "02", "02"}
        'qxd modify 2003-11-3  制作评审报告时生成的表中，外收净额有错误:外收净额＝营业外收入(b12)-营业外支出(b13)
        'Dim strItemCode As String() = {"b01", "sum1(b02+b03)", "sum2(b06+b07+b08)", "sum3(b11-b12)", "b10", "b15", "b18"}
        Dim strItemCode As String() = {"b01", "sum1(b02+b03)", "sum2(b06+b07+b08)", "b05", "sum3(b12-b13)", "b10", "b15", "b18", "div1(b04/b01)", "div2(b18/b01)"}
        Try
            'qxd modify 2004-12-6
            '''''Dim strApplyDate As String
            '''''strApplyDate = getApplyDate(strProjectCode)
            '''''strMonth = CType(strApplyDate, Date).Year '今年
            '''''dYear = CType(strMonth, Double)
            '''''lastYear = dYear - 1 '去年
            '''''strLastYear = lastYear.ToString
            '''''beforeLastYear = dYear - 2 '前年
            '''''strBeforeLastYear = beforeLastYear.ToString
            '''''bbLastYear = dYear - 3 '上前年
            '''''strBBLastYear = bbLastYear.ToString
            ''''''strCorporationCode = strProjectCode.Substring(0, 5)

            '最新财务数据是从表project_finance_analyse中取得,这个表中最多有三个不同年月的数据,
            '三个年月按年月的先后分为今年,去年,前年

            strSql = "select distinct month from project_finance_analyse where project_code='" & strProjectCode & "' and corporation_code='" & strCorpCode & "' and phase='" & phase & "' order by month desc"
            Dim dt As DataTable = gWs.GetCommonQueryInfo(strSql).Tables(0)

            If dt.Rows.Count > 3 Then
                MyMsgBox("财务分析数据多余三个不同的年月,系统无法导出!", "请重新作一次财务分析,如果还是出现错误,请于系统管理员联系!")
                'SWDialogBox.MessageBox.Show("财务分析数据多余三个不同的年月,系统无法导出!", "错误提示", "请重新作一次财务分析,如果还是出现错误,请于系统管理员联系!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information)
                Exit Sub
            ElseIf dt.Rows.Count <= 0 Then
                Exit Sub
            Else
                strMonth = dt.Rows(0).Item("month")
                Try
                    'edit by 9sky 20050705   修改代码顺序
                    strLastYear = (strMonth.Substring(0, 4) - 1).ToString & "12"
                    rang.Item(4, 3) = strLastYear.Substring(0, 4) & "年"

                    strBeforeLastYear = (strMonth.Substring(0, 4) - 2).ToString & "12"
                    rang.Item(4, 2) = strBeforeLastYear.Substring(0, 4) & "年"

                    rang.Item(4, 4) = strMonth.Substring(0, 4) & "年" & strMonth.Substring(4, 2) & "月"

                    strLastYearSameTerm = (strMonth.Substring(0, 4) - 1).ToString & strMonth.Substring(4, 2)
                    rang.Item(4, 5) = strLastYearSameTerm.Substring(0, 4) & "年同期"

                Catch
                End Try
            End If

            strSql = "{project_code='" & strProjectCode & "' and phase='" & phase & "' and corporation_code='" & strCorpCode & _
                     "' and (month like '" & strMonth & "%' or month like '" & strLastYear & _
                     "%' or month like '" & strBeforeLastYear & "%' or month like '" & strLastYearSameTerm & "%') order by month desc}"

            ds = gWs.FetchCorporationAccount(strSql) '3
            If Not ds Is Nothing Then
                j = strItem.Length
                Dim strValue As String
                Dim drTemp As DataRow
                'rang.Item(2, 1) = Me.strCorporationName
                'rang.Item(5, 2) = strBeforeLastYear.Substring(0, 4) & "年"
                'rang.Item(5, 3) = strLastYear.Substring(0, 4) & "年"

                'edit by 9sky 20050705 增加判断
                '前年
                If Not strBeforeLastYear Is Nothing Then setIncomeStatementRangByYear(strItemCode, strItemType, ds, rang, j, strBeforeLastYear, 2)
                '去年
                If Not strLastYear Is Nothing Then setIncomeStatementRangByYear(strItemCode, strItemType, ds, rang, j, strLastYear, 3)
                '今年
                If Not strMonth Is Nothing Then setIncomeStatementRangByYear(strItemCode, strItemType, ds, rang, j, strMonth, 4)
                '去年同期
                If Not strLastYearSameTerm Is Nothing Then setIncomeStatementRangByYear(strItemCode, strItemType, ds, rang, j, strLastYearSameTerm, 5)


                'For j = 0 To j - 1
                '    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strMonth & "%' "
                '    If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                '        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("month") Is System.DBNull.Value Then
                '            Dim mon As String
                '            Dim len As Integer
                '            mon = ds.Tables(0).Select(strSql, "month desc")(0).Item("month")
                '            'len = strMonth.Length
                '            'mon = mon.Substring(len, mon.Length - len)
                '            rang.Item(5, 4) = mon.Substring(0, 4) & "年" & mon.Substring(4, 2) & "月"
                '            Exit For
                '        End If
                '    End If
                'Next
            End If

        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '设置损益表
    Private Sub setIncomeStatementRangByYear(ByVal strItemCode As String(), ByVal strItemType As String(), _
        ByVal ds As DataSet, ByVal rang As Excel.Range, ByVal j As Integer, ByVal strBeforeLastYear As String, _
        ByVal colExcel As Integer)
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2 As String
        Dim dValue_1, dValue_2, dValue As Double
        For j = 0 To j - 1
            If strItemCode(j).StartsWith("sum1") Then
                strValue = getSumValue(strItemType, "b02", "b03", strBeforeLastYear, ds, j, True)
                If strValue = "" Then
                    rang.Item(5 + j, colExcel) = strValue
                Else
                    rang.Item(5 + j, colExcel) = changedStringToTenThousand(strValue)
                End If
            ElseIf strItemCode(j).StartsWith("sum2") Then
                strValue = getSumValueEx(strItemType, "b06", "b07", "b08", strBeforeLastYear, ds, j)
                If strValue = "" Then
                    rang.Item(5 + j, colExcel) = strValue
                Else
                    rang.Item(5 + j, colExcel) = changedStringToTenThousand(strValue)
                End If
            ElseIf strItemCode(j).StartsWith("sum3") Then
                'qxd modify 2003-11-3
                'strValue = getSumValue(strItemType, "b11", "b12", strBeforeLastYear, ds, j, False)
                strValue = getSumValue(strItemType, "b12", "b13", strBeforeLastYear, ds, j, False)
                If strValue = "" Then
                    rang.Item(5 + j, colExcel) = strValue
                Else
                    rang.Item(5 + j, colExcel) = changedStringToTenThousand(strValue)
                End If
            ElseIf strItemCode(j).StartsWith("div1") Then
                strValue = getDivValue(strItemType, "b04", "b01", strBeforeLastYear, ds, j)
                rang.Item(5 + j, colExcel) = strValue
            ElseIf strItemCode(j).StartsWith("div2") Then
                strValue = getDivValue(strItemType, "b18", "b01", strBeforeLastYear, ds, j)
                rang.Item(5 + j, colExcel) = strValue
            Else
                strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strBeforeLastYear & "%'"
                If ds.Tables(0).Select(strSql).Length > 0 Then
                    If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                        strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                    Else
                        strValue = "0"
                    End If
                Else
                    strValue = ""
                End If

                If strValue = "" Then
                    rang.Item(5 + j, colExcel) = strValue
                Else
                    rang.Item(5 + j, colExcel) = changedStringToTenThousand(strValue)
                End If
            End If
            'qxd modify 2003-11-3
            'rang.Item(6 + j, colExcel) = strValue
        Next
    End Sub
    '求比率
    Private Function getDivValue(ByVal strItemType As String(), ByVal itemCode_A As String, ByVal itemCode_B As String, ByVal strBeforeLastYear As String, ByVal ds As DataSet, ByVal j As Integer)
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2 As String
        Dim dValue_1, dValue_2, dValue As Double
        strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_A & "' and month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql).Length > 0 Then
            If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                strValue_1 = ds.Tables(0).Select(strSql)(0).Item("value")
                dValue_1 = IIf(strValue_1 = "", 0, CType(strValue_1, Double))
            End If
        Else
            Return ""
        End If
        strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_B & "' and month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql).Length > 0 Then
            If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                strValue_2 = ds.Tables(0).Select(strSql)(0).Item("value")
                dValue_2 = IIf(strValue_2 = "", 0, CType(strValue_2, Double))
            End If
        Else
            Return ""
        End If
        dValue = dValue_1 / dValue_2
        If dValue_2 = 0 Then
            strValue = ""
        Else
            strValue = Math.Round(dValue, 2) * 100 & "%"
        End If

        Return strValue
    End Function
    '求和
    Private Function getSumValueEx(ByVal strItemType As String(), ByVal itemCode_A As String, ByVal itemCode_B As String, ByVal itemCode_C As String, ByVal strBeforeLastYear As String, ByVal ds As DataSet, ByVal j As Integer)
        Dim strSql As String
        Dim strValue As String
        Dim strValue_1, strValue_2, strValue_3 As String
        Dim dValue_1, dValue_2, dValue_3, dValue As Double
        strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_A & "' and month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql).Length > 0 Then
            If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                strValue_1 = ds.Tables(0).Select(strSql)(0).Item("value")
                dValue_1 = IIf(strValue_1 = "", 0, CType(strValue_1, Double))
            End If
        Else
            Return ""
        End If
        strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_B & "' and month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql).Length > 0 Then
            If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                strValue_2 = ds.Tables(0).Select(strSql)(0).Item("value")
                dValue_2 = IIf(strValue_2 = "", 0, CType(strValue_2, Double))
            End If
        Else
            Return ""
        End If
        strSql = "item_type='" & strItemType(j) & "' and item_code='" & itemCode_C & "' and month like '" & strBeforeLastYear & "%' "
        If ds.Tables(0).Select(strSql).Length > 0 Then
            If Not ds.Tables(0).Select(strSql)(0).Item("value") Is System.DBNull.Value Then
                strValue_3 = ds.Tables(0).Select(strSql)(0).Item("value")
                dValue_3 = IIf(strValue_3 = "", 0, CType(strValue_3, Double))
            End If
        Else
            Return ""
        End If
        dValue = dValue_1 + dValue_2 + dValue_3
        strValue = dValue.ToString
        Return strValue
    End Function
    '现金流量,13
    Private Sub importCashFlow(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear As String
        Dim dYear, lastYear, beforeLastYear As Double
        Dim strItem As String() = {"经营活动产生的现金流量流入量", "经营活动产生的现金流量流出量", _
                                    "经营活动产生的现金流量净额", "投资活动产生的现金流量流入量", _
                                    "投资活动产生的现金流量流出量", "投资活动产生的现金流量净额", _
                                    "融资活动产生的现金流量流入量", "融资活动产生的现金流量流出量", _
                                    "融资活动产生的现金流量净额" _
                                    }
        Dim strItemType As String() = {"03", "03", "03", "03", "03", "03", "03", "03", "03"}
        Dim strItemCode As String() = {"c04", "c09", _
                                        "c10", "c15", _
                                        "c19", "c20", _
                                        "c25", "c32", _
                                        "c33" _
                                        }
        Try
            Dim strApplyDate As String
            strApplyDate = GetApplyDate(strProjectCode)
            strMonth = CType(strApplyDate, Date).Year '今年
            dYear = CType(strMonth, Double)
            lastYear = dYear - 1 '去年
            strLastYear = lastYear.ToString
            beforeLastYear = dYear - 2 '前年
            strBeforeLastYear = beforeLastYear.ToString
            strCorporationCode = strProjectCode.Substring(0, 5)
            strSql = "{project_code='" & strProjectCode & "' and phase='" & phase & "' and corporation_code='" & strCorporationCode & _
                                "' and (month like '" & strMonth & "%' or month like '" & strLastYear & _
                                "%' or month like '" & strBeforeLastYear & "%') order by month desc}"

            ds = gWs.FetchCorporationAccount(strSql) '2使用这个方法
            If Not ds Is Nothing Then
                j = strItem.Length
                Dim strValue As String
                Dim drTemp As DataRow
                rang.Item(3, 2) = strBeforeLastYear & "年"
                rang.Item(3, 5) = strLastYear & "年"
                'rang.Item(5, 6) = strMonth & "年1月"
                '前年
                For j = 0 To j - 1
                    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strBeforeLastYear & "%' "
                    If ds.Tables(0).Select(strSql).Length > 0 Then
                        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                            If j < 3 Then
                                'qxd modify 2003-11-3
                                'rang.Item(5, 2 + j) = strValue
                                rang.Item(5, 2 + j) = changedStringToTenThousand(strValue)
                            ElseIf j < 6 Then
                                'qxd modify 2003-11-3
                                'rang.Item(6, 2 + j - 3) = strValue
                                rang.Item(6, 2 + j - 3) = changedStringToTenThousand(strValue)
                            ElseIf j < 9 Then
                                'qxd modify 2003-11-3
                                'rang.Item(7, 2 + j - 6) = strValue
                                rang.Item(7, 2 + j - 6) = changedStringToTenThousand(strValue)
                            End If
                        End If
                    End If
                Next
                '去年
                For j = 0 To j - 1
                    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strLastYear & "%' "
                    If ds.Tables(0).Select(strSql).Length > 0 Then
                        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                            If j < 3 Then
                                'qxd modify 2003-11-3
                                'rang.Item(5, 5 + j) = strValue
                                rang.Item(5, 5 + j) = changedStringToTenThousand(strValue)
                            ElseIf j < 6 Then
                                'qxd modify 2003-11-3
                                'rang.Item(6, 5 + j - 3) = strValue
                                rang.Item(6, 5 + j - 3) = changedStringToTenThousand(strValue)
                            ElseIf j < 9 Then
                                'qxd modify 2003-11-3
                                'rang.Item(7, 5 + j - 6) = strValue
                                rang.Item(7, 5 + j - 6) = changedStringToTenThousand(strValue)
                            End If
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub
    '现金流量表,14
    Private Sub importCashFlowTable(ByVal rang As Excel.Range, ByVal phase As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim count As Integer
        Dim strSql As String
        Dim strMonth, strLastYear, strBeforeLastYear, strBBLastYear As String
        Dim dYear, lastYear, beforeLastYear, bbLastYear As Double
        Dim strItem As String() = {"经营活动产生的现金流入量", " 经营活动产生的现金流量净额"}
        Dim strItemType As String() = {"03", "03"}
        Dim strItemCode As String() = {"c01", "c10"}
        Try
            Dim strApplyDate As String
            strApplyDate = GetApplyDate(strProjectCode)
            strMonth = CType(strApplyDate, Date).Year '今年
            dYear = CType(strMonth, Double)
            lastYear = dYear - 1 '去年
            strLastYear = lastYear.ToString
            beforeLastYear = dYear - 2 '前年
            strBeforeLastYear = beforeLastYear.ToString
            bbLastYear = dYear - 3 '上前年
            strBBLastYear = bbLastYear.ToString
            strCorporationCode = strProjectCode.Substring(0, 5)
            strSql = "{project_code='" & strProjectCode & "' and phase='" & phase & "' and corporation_code='" & strCorporationCode & _
                     "' and (month like '" & strMonth & "%' or month like '" & strLastYear & _
                     "%' or month like '" & strBeforeLastYear & "%' or month like '" & strBBLastYear & "%') order by month desc}"

            ds = gWs.FetchCorporationAccount(strSql) '1
            If Not ds Is Nothing Then
                j = strItem.Length
                Dim strValue As String
                Dim drTemp As DataRow
                'rang.Item(2, 1) = Me.strCorporationName
                'rang.Item(2, 3) = CType(strApplyDate, Date).ToString("yyyy年MM月dd日")
                rang.Item(5, 3) = strBBLastYear & "年"
                rang.Item(5, 4) = strBeforeLastYear & "年"
                rang.Item(5, 5) = strLastYear & "年"
                'rang.Item(5, 6) = strMonth & "年1月"
                '上前年
                For j = 0 To j - 1
                    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strBBLastYear & "%' "
                    If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                            'qxd modify 2003-11-3
                            'rang.Item(6 + j, 3) = strValue
                            rang.Item(6 + j, 3) = changedStringToTenThousand(strValue)
                        End If
                    End If
                Next
                '前年
                For j = 0 To j - 1
                    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strBeforeLastYear & "%' "
                    If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                            'qxd modify 2003-11-3
                            'rang.Item(6 + j, 4) = strValue
                            rang.Item(6 + j, 4) = changedStringToTenThousand(strValue)
                        End If
                    End If
                Next
                '去年
                For j = 0 To j - 1
                    strSql = "item_type='" & strItemType(j) & "' and item_code='" & strItemCode(j) & "' and month like '" & strLastYear & "%' "
                    If ds.Tables(0).Select(strSql, "month desc").Length > 0 Then
                        If Not ds.Tables(0).Select(strSql, "month desc")(0).Item("value") Is System.DBNull.Value Then
                            strValue = ds.Tables(0).Select(strSql, "month desc")(0).Item("value")
                            'qxd modify 2003-11-3
                            'rang.Item(6 + j, 5) = strValue
                            rang.Item(6 + j, 5) = changedStringToTenThousand(strValue)
                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '反担保物
    '
    Public Sub importOppGuarantee(ByVal rang As Excel.Range, ByVal phase As String)
        ''''''''''''''''''''''''''''''房地产,汽车,机器设备,股票,股权,存单  
        Dim strOppName As String() = {"房地产", "汽车", "机器设备", "股票", "股权", "存单", "土地"}
        Dim strOppType As String() = {"21", "22", "23", "24", "25", "26", "2M"}
        Dim dsOpp, dsDetail As DataSet
        Dim drOpp, drDetail As DataRow
        Dim strSql As String
        Dim i, len As Integer
        Dim strSerial, strItemType, strOriginal, strEvaluate, strGuarantee As ArrayList
        Dim flag As New ArrayList
        strSerial = New ArrayList
        strItemType = New ArrayList
        strOriginal = New ArrayList
        strEvaluate = New ArrayList
        strGuarantee = New ArrayList
        If gWs Is Nothing Then
            Exit Sub
        End If
        Try
            strSql = "{project_code='" & strProjectCode & "' order by guaranty_type }"
            dsOpp = gWs.GetGuarantyInfo(strSql, "null")
            i = dsOpp.Tables("opposite_guarantee").Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    drOpp = dsOpp.Tables("opposite_guarantee").Rows(i)
                    With drOpp
                        If Not .Item("serial_num") Is System.DBNull.Value Then
                            strSerial.Add(.Item("serial_num"))
                            flag.Add("false")
                            If Not .Item("guaranty_type") Is System.DBNull.Value Then
                                strItemType.Add(.Item("guaranty_type"))
                            Else
                                strItemType.Add("")
                            End If
                            If Not .Item("original_value") Is System.DBNull.Value Then
                                strOriginal.Add(.Item("original_value"))
                            Else
                                strOriginal.Add("0.0")
                            End If
                            If Not .Item("evaluate_value") Is System.DBNull.Value Then
                                strEvaluate.Add(.Item("evaluate_value"))
                            Else
                                strEvaluate.Add("0.0")
                            End If
                            If Not .Item("guarantee_value") Is System.DBNull.Value Then
                                strGuarantee.Add(.Item("guarantee_value"))
                            Else
                                strGuarantee.Add("0.0")
                            End If
                        End If
                    End With
                Next

                rang.Range(rang.Cells(2, 1), rang.Cells(2, 13)).Merge()

                len = strSerial.Count
                If len > 0 Then
                    Dim count As Integer = 0
                    Dim maxLen_21, maxLen_22, maxLen_23, maxLen_24, maxLen_25, maxLen_26, maxLen_2m As Integer
                    Dim dOriginal_21, dEvaluate_21, dGuarantee_21 As Double
                    Dim dOriginal_22, dEvaluate_22, dGuarantee_22 As Double
                    Dim dOriginal_23, dEvaluate_23, dGuarantee_23 As Double
                    Dim dOriginal_24, dEvaluate_24, dGuarantee_24 As Double
                    Dim dOriginal_25, dEvaluate_25, dGuarantee_25 As Double
                    Dim dOriginal_26, dEvaluate_26, dGuarantee_26 As Double
                    Dim dOriginal_2m, dEvaluate_2m, dGuarantee_2m As Double
                    Dim b_21, b_22, b_23, b_24, b_25, b_26, b_2m As Boolean
                    Dim count_21, count_22, count_23, count_24, count_25, count_26, count_2m As Integer
                    Dim a, b, c, d, e, f, g As Integer
                    For len = 0 To len - 1
                        Select Case strItemType(len)
                            Case "21"
                                If b_21 Then
                                    flag(len) = "true"
                                    If count_21 = 1 Then
                                        count_21 = count_21 + 2
                                    Else
                                        count_21 = count_21 + 1
                                    End If
                                    a = count_21 + 3
                                Else
                                    count_21 = count_21 + 1
                                    a = count_21 + 4
                                End If
                                rang.Item(3, 1) = "房地产"
                                maxLen_21 = setOpp(rang, count_21 + 3, strSerial(len), strItemType(len), strOriginal(len), strEvaluate(len), strGuarantee(len), flag(len))
                                dOriginal_21 = strOriginal(len) + dOriginal_21
                                dEvaluate_21 = strEvaluate(len) + dEvaluate_21
                                dGuarantee_21 = strGuarantee(len) + dGuarantee_21
                                b_21 = True
                            Case "22"
                                If a = 0 Then
                                    a = 3
                                End If
                                If b_22 Then
                                    flag(len) = "true"
                                    If count_22 = 1 Then
                                        count_22 = count_22 + 2
                                    Else
                                        count_22 = count_22 + 1
                                    End If
                                    b = count_22 + a + 3
                                Else
                                    count_22 = count_22 + 1
                                    b = count_22 + a + 4
                                End If
                                rang.Item(a + 3, 1) = "汽车"
                                maxLen_22 = setOpp(rang, count_22 + a + 3, strSerial(len), strItemType(len), strOriginal(len), strEvaluate(len), strGuarantee(len), flag(len))
                                dOriginal_22 = Double.Parse(strOriginal(len)) + dOriginal_22
                                dEvaluate_22 = Double.Parse(strEvaluate(len)) + dEvaluate_22
                                dGuarantee_22 = Double.Parse(strGuarantee(len)) + dGuarantee_22
                                b_22 = True
                            Case "23"
                                If b = 0 Then
                                    b = a
                                End If
                                If b_23 Then
                                    flag(len) = "true"
                                    If count_23 = 1 Then
                                        count_23 = count_23 + 2
                                    Else
                                        count_23 = count_23 + 1
                                    End If
                                    c = count_23 + b + 3
                                Else
                                    count_23 = count_23 + 1
                                    c = count_23 + b + 4
                                End If
                                rang.Item(b + 3, 1) = "机器设备"
                                maxLen_23 = setOpp(rang, count_23 + b + 3, strSerial(len), strItemType(len), strOriginal(len), strEvaluate(len), strGuarantee(len), flag(len))
                                dOriginal_23 = CType(strOriginal(len), Double) + dOriginal_23
                                dEvaluate_23 = CType(strEvaluate(len), Double) + dEvaluate_23
                                dGuarantee_23 = CType(strGuarantee(len), Double) + dGuarantee_23
                                b_23 = True
                            Case "24"
                                If c = 0 Then
                                    If b = 0 Then
                                        c = a
                                    Else
                                        c = b
                                    End If
                                End If
                                If b_24 Then
                                    flag(len) = "true"
                                    If count_24 = 1 Then
                                        count_24 = count_24 + 2
                                    Else
                                        count_24 = count_24 + 1
                                    End If
                                    d = count_24 + c + 3
                                Else
                                    count_24 = count_24 + 1
                                    d = count_24 + c + 4
                                End If
                                rang.Item(c + 3, 1) = "股票"
                                maxLen_24 = setOpp(rang, count_24 + c + 3, strSerial(len), strItemType(len), strOriginal(len), strEvaluate(len), strGuarantee(len), flag(len))
                                dOriginal_24 = Double.Parse(strOriginal(len)) + dOriginal_24
                                dEvaluate_24 = Double.Parse(strEvaluate(len)) + dEvaluate_24
                                dGuarantee_24 = Double.Parse(strGuarantee(len)) + dGuarantee_24
                                b_24 = True
                            Case "25"
                                If d = 0 Then
                                    If c = 0 Then
                                        If b = 0 Then
                                            d = a
                                        Else
                                            d = b
                                        End If
                                    Else
                                        d = c
                                    End If
                                End If
                                If b_25 Then
                                    flag(len) = "true"
                                    If count_25 = 1 Then
                                        count_25 = count_25 + 2
                                    Else
                                        count_25 = count_25 + 1
                                    End If
                                    e = count_25 + d + 3
                                Else
                                    count_25 = count_25 + 1
                                    e = count_25 + d + 4
                                End If
                                rang.Item(d + 3, 1) = "股权"
                                maxLen_25 = setOpp(rang, count_25 + d + 3, strSerial(len), strItemType(len), strOriginal(len), strEvaluate(len), strGuarantee(len), flag(len))
                                dOriginal_25 = CType(strOriginal(len), Double) + dOriginal_25
                                dEvaluate_25 = CType(strEvaluate(len), Double) + dEvaluate_25
                                dGuarantee_25 = CType(strGuarantee(len), Double) + dGuarantee_25
                                b_25 = True
                            Case "26"
                                If e = 0 Then
                                    If d = 0 Then
                                        If c = 0 Then
                                            If b = 0 Then
                                                e = a
                                            Else
                                                e = b
                                            End If
                                        Else
                                            e = c
                                        End If
                                    Else 'qxd add 2003-11-4
                                        e = d
                                    End If
                                End If
                                If b_26 Then
                                    flag(len) = "true"
                                    If count_26 = 1 Then
                                        count_26 = count_26 + 2
                                    Else
                                        count_26 = count_26 + 1
                                    End If
                                    f = count_26 + e + 3
                                Else
                                    count_26 = count_26 + 1
                                    f = count_26 + e + 4
                                End If
                                rang.Item(e + 3, 1) = "存单"
                                maxLen_26 = setOpp(rang, count_26 + e + 3, strSerial(len), strItemType(len), strOriginal(len), strEvaluate(len), strGuarantee(len), flag(len))
                                dOriginal_26 = CType(strOriginal(len), Double) + dOriginal_26
                                dEvaluate_26 = CType(strEvaluate(len), Double) + dEvaluate_26
                                dGuarantee_26 = CType(strGuarantee(len), Double) + dGuarantee_26
                                b_26 = True
                            Case "2M"
                                If f = 0 Then
                                    If e = 0 Then
                                        If d = 0 Then
                                            If c = 0 Then
                                                If b = 0 Then
                                                    f = a
                                                Else
                                                    f = b
                                                End If
                                            Else
                                                f = c
                                            End If
                                        Else 'qxd add 2003-11-4
                                            f = d
                                        End If
                                    Else
                                        f = e
                                    End If
                                End If
                                If b_2m Then
                                    flag(len) = "true"
                                    If count_2m = 1 Then
                                        count_2m = count_2m + 2
                                    Else
                                        count_2m = count_2m + 1
                                    End If
                                    g = count_2m + f + 3
                                Else
                                    count_2m = count_2m + 1
                                    g = count_2m + f + 4
                                End If
                                rang.Item(f + 3, 1) = "土地"
                                maxLen_2m = setOpp(rang, count_2m + f + 3, strSerial(len), strItemType(len), strOriginal(len), strEvaluate(len), strGuarantee(len), flag(len))
                                dOriginal_2m = strOriginal(len) + dOriginal_2m
                                dEvaluate_2m = strEvaluate(len) + dEvaluate_2m
                                dGuarantee_2m = strGuarantee(len) + dGuarantee_2m
                                b_2m = True
                        End Select
                    Next
                    If b_21 Then
                        setOppTotal(rang, a + 1, maxLen_21, dOriginal_21, dEvaluate_21, dGuarantee_21)
                    End If
                    If b_22 Then
                        setOppTotal(rang, b + 1, maxLen_22, dOriginal_22, dEvaluate_22, dGuarantee_22)
                    End If
                    If b_23 Then
                        setOppTotal(rang, c + 1, maxLen_23, dOriginal_23, dEvaluate_23, dGuarantee_23)
                    End If
                    If b_24 Then
                        setOppTotal(rang, d + 1, maxLen_24, dOriginal_24, dEvaluate_24, dGuarantee_24)
                    End If
                    If b_25 Then
                        setOppTotal(rang, e + 1, maxLen_25, dOriginal_25, dEvaluate_25, dGuarantee_25)
                    End If
                    If b_26 Then
                        setOppTotal(rang, f + 1, maxLen_26, dOriginal_26, dEvaluate_26, dGuarantee_26)
                    End If
                    If b_2m Then
                        setOppTotal(rang, g + 1, maxLen_2m, dOriginal_2m, dEvaluate_2m, dGuarantee_2m)
                    End If
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '导入原值，评估值，担保额
    Private Function setOpp(ByVal rang As Excel.Range, ByVal count As Integer, ByVal strSerial As String, _
                ByVal strItemType As String, ByVal strOriginal As String, ByVal strEvaluate As String, _
                ByVal strGuarantee As String, ByVal flag As String)
        Dim ds As DataSet
        Dim dr As DataRow
        Dim j As Integer
        Dim maxLen As Integer
        ds = New frmOppGuarantee().getOppGuaranteeDetail(strProjectCode, strSerial, strItemType)
        j = ds.Tables("opposite_guarantee_detail").Rows.Count
        maxLen = j

        If flag = "false" Then
            rang.Range(rang.Item(count - 1, 1), rang.Item(count - 1, maxLen + 3)).Merge()
            Dim rg As Excel.Range = rang.Range(rang.Item(count, 1), rang.Item(count, maxLen + 3))
            rg.Interior.ColorIndex = 34 '蓝色
            rg.Font.ColorIndex = 32 '浅青绿色
            rg.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter

            rang.Item(count, maxLen + 1) = "原值"
            rang.Item(count, maxLen + 2) = "评估总值"

            rang.Item(count, maxLen + 3) = "担保额"

            For j = 0 To j - 1

                dr = ds.Tables("opposite_guarantee_detail").Rows(j)
                Dim itemName As String = dr.Item("item_name").ToString()
                Dim itemValue As String = dr.Item("item_value").ToString()
                rang.Item(count, j + 1) = itemName

                'Try
                '    If InStr(itemName, "(%)", CompareMethod.Text) > 0 Then
                '        rang.Item(count + 1, j + 1).NumberFormat = "0.00%"
                '        rang.Item(count + 1, j + 1) = CType(itemValue, Double)
                '    ElseIf InStr(itemName, "米)", CompareMethod.Text) > 0 Then
                '        rang.Item(count + 1, j + 1).NumberFormat = "#,##0.00"
                '        rang.Item(count + 1, j + 1) = itemValue
                '    ElseIf InStr(itemName, "(YYYY/MM/DD)", CompareMethod.Text) > 0 Then
                '        Dim strYear As String = Year(itemValue)
                '        Dim strMonth As String = Month(itemValue)
                '        rang.Item(count + 1, j + 1) = strYear + strMonth
                '    Else
                '        rang.Item(count + 1, j + 1) = itemValue
                '    End If
                'Catch
                '    rang.Item(count + 1, j + 1) = itemValue
                'End Try
                rang.Item(count + 1, j + 1) = itemvalue
            Next

            rang.Item(count + 1, maxLen + 1).NumberFormat = "#,##0.00"
            rang.Item(count + 1, maxLen + 2).NumberFormat = "#,##0.00"
            rang.Item(count + 1, maxLen + 3).NumberFormat = "#,##0.00"
            rang.Item(count + 1, maxLen + 1) = strOriginal
            rang.Item(count + 1, maxLen + 2) = strEvaluate
            rang.Item(count + 1, maxLen + 3) = strGuarantee
        Else
            For j = 0 To j - 1

                dr = ds.Tables("opposite_guarantee_detail").Rows(j)

                Dim itemName As String = dr.Item("item_name").ToString()
                Dim itemValue As String = dr.Item("item_value").ToString()
                'Try
                '    If InStr(itemName, "(%)", CompareMethod.Text) > 0 Then
                '        rang.Item(count, j + 1).NumberFormat = "0.00%"
                '        rang.Item(count, j + 1) = CType(itemValue, Double)
                '    ElseIf InStr(itemName, "米)", CompareMethod.Text) > 0 Then
                '        rang.Item(count, j + 1).NumberFormat = "#,##0.00"
                '        rang.Item(count, j + 1) = itemValue
                '    ElseIf InStr(itemName, "(YYYY/MM/DD)", CompareMethod.Text) > 0 Then
                '        Dim strYear As String = Year(itemValue)
                '        Dim strMonth As String = Month(itemValue)
                '        rang.Item(count, j + 1) = strYear + strMonth
                '    Else
                '        rang.Item(count, j + 1) = itemValue
                '    End If
                'Catch
                '    rang.Item(count, j + 1) = itemValue
                'End Try
                rang.Item(count, j + 1) = itemvalue

            Next

            rang.Item(count, maxLen + 1).NumberFormat = "#,##0.00"
            rang.Item(count, maxLen + 2).NumberFormat = "#,##0.00"
            rang.Item(count, maxLen + 3).NumberFormat = "#,##0.00"
            rang.Item(count, maxLen + 1) = strOriginal
            rang.Item(count, maxLen + 2) = strEvaluate
            rang.Item(count, maxLen + 3) = strGuarantee
        End If

        Return maxLen
    End Function
    '
    '反担保物中计算合计值
    '
    Private Sub setOppTotal(ByVal rang As Excel.Range, ByVal count As Integer, ByVal maxLen As Integer, _
            ByVal dOriginal As Double, ByVal dEvaluate As Double, ByVal dGuarantee As Double)
        rang.Item(count, 1) = "合计"
        rang.Item(count, maxLen + 1).NumberFormat = "#,##0.00"
        rang.Item(count, maxLen + 2).NumberFormat = "#,##0.00"
        rang.Item(count, maxLen + 3).NumberFormat = "#,##0.00"
        rang.Item(count, maxLen + 1) = dOriginal
        rang.Item(count, maxLen + 2) = dEvaluate
        rang.Item(count, maxLen + 3) = dGuarantee
    End Sub
    '
    '输入项目编码并离开输入框时，更新企业名称
    '
    Private Sub txtCode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim strCode As String
        strCode = Me.txtCode.Text.Trim()
        If Not gWs Is Nothing Then
            If strCode.Length = 9 Then
                Dim dsProject As DataSet
                Dim dsCorporation As DataSet
                Dim drProject As DataRow
                Dim drCorporation As DataRow
                Dim strSql As String
                Dim strCorpCode, strCorpName As String
                Dim i As Integer
                strSql = "{project_code='" & strCode & "'}"
                dsProject = gWs.GetProjectInfo(strSql)
                i = dsProject.Tables("project").Rows.Count
                If i > 0 Then
                    Me.btnImport.Enabled = True
                    drProject = dsProject.Tables("project").Rows(0)
                    With drProject
                        If Not .Item("corporation_code") Is System.DBNull.Value Then
                            strCorpCode = .Item("corporation_code")
                            strSql = "{corporation_code='" & strCorpCode & "'}"
                            dsCorporation = gWs.GetcorporationInfo(strSql, "null")
                            i = dsCorporation.Tables("corporation").Rows.Count
                            If i > 0 Then
                                drCorporation = dsCorporation.Tables("corporation").Rows(0)
                                If Not drCorporation.Item("corporation_name") Is System.DBNull.Value Then
                                    strCorpName = drCorporation.Item("corporation_name")
                                    Me.txtName.Text = strCorpName
                                Else
                                    Me.txtName.Text = ""
                                End If
                            End If
                        End If
                    End With
                Else
                    Me.btnImport.Enabled = False
                    Me.txtName.Text = ""
                End If
            Else
                Me.btnImport.Enabled = False
                Me.txtName.Text = ""
            End If
        End If
    End Sub
    'KeyPress事件
    Private Sub frmImportDataToExcel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
    End Sub

    'qxd add 2003-11-3
    '转换string数值为1/10000的string值
    '返回值类型：string
    Private Function changedStringToTenThousand(ByVal strValue As String)
        Try
            If strValue Is Nothing Then
                Return "0.00"
            Else
                Dim d As Double
                Dim str As String

                If IsNumeric(strValue) Then
                    d = CType(strValue, Double) / 10000.0
                    d = Math.Round(d, 0)
                    str = d.ToString
                    Return str
                Else
                    Return strValue
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function

    Private Sub btnExit_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click

    End Sub
End Class
