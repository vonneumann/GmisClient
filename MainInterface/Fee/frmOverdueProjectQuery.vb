Public Class frmOverdueProjectQuery
    Inherits Form

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
    Friend WithEvents dgList As System.Windows.Forms.DataGrid
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents chkDate As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnExcel As System.Windows.Forms.Button
    Friend WithEvents chkCondition As System.Windows.Forms.CheckBox
    Friend WithEvents grpCondition As System.Windows.Forms.GroupBox
    Friend WithEvents gpbDG As System.Windows.Forms.GroupBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents dtpEndDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStartDate As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmOverdueProjectQuery))
        Me.gpbDG = New System.Windows.Forms.GroupBox()
        Me.dgList = New System.Windows.Forms.DataGrid()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpCondition = New System.Windows.Forms.GroupBox()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpEndDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpStartDate = New System.Windows.Forms.DateTimePicker()
        Me.chkDate = New System.Windows.Forms.CheckBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.chkCondition = New System.Windows.Forms.CheckBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.gpbDG.SuspendLayout()
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbDG
        '
        Me.gpbDG.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.gpbDG.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgList})
        Me.gpbDG.Location = New System.Drawing.Point(8, 112)
        Me.gpbDG.Name = "gpbDG"
        Me.gpbDG.Size = New System.Drawing.Size(776, 272)
        Me.gpbDG.TabIndex = 2
        Me.gpbDG.TabStop = False
        '
        'dgList
        '
        Me.dgList.CaptionVisible = False
        Me.dgList.DataMember = ""
        Me.dgList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgList.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgList.Location = New System.Drawing.Point(3, 17)
        Me.dgList.Name = "dgList"
        Me.dgList.ReadOnly = True
        Me.dgList.Size = New System.Drawing.Size(770, 252)
        Me.dgList.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Location = New System.Drawing.Point(680, 88)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "退出(&X)"
        '
        'grpCondition
        '
        Me.grpCondition.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cboServiceType, Me.Label3, Me.txtProjectCode, Me.Label2, Me.dtpEndDate, Me.Label1, Me.dtpStartDate, Me.chkDate})
        Me.grpCondition.Location = New System.Drawing.Point(8, 8)
        Me.grpCondition.Name = "grpCondition"
        Me.grpCondition.Size = New System.Drawing.Size(776, 72)
        Me.grpCondition.TabIndex = 4
        Me.grpCondition.TabStop = False
        '
        'cboServiceType
        '
        Me.cboServiceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboServiceType.Location = New System.Drawing.Point(280, 13)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(208, 20)
        Me.cboServiceType.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 14)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "业务品种"
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(88, 13)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.TabIndex = 9
        Me.txtProjectCode.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 14)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "项目编码"
        '
        'dtpEndDate
        '
        Me.dtpEndDate.Location = New System.Drawing.Point(280, 40)
        Me.dtpEndDate.Name = "dtpEndDate"
        Me.dtpEndDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpEndDate.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(248, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(17, 14)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "到"
        '
        'dtpStartDate
        '
        Me.dtpStartDate.Location = New System.Drawing.Point(88, 40)
        Me.dtpStartDate.Name = "dtpStartDate"
        Me.dtpStartDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpStartDate.TabIndex = 5
        '
        'chkDate
        '
        Me.chkDate.Location = New System.Drawing.Point(8, 40)
        Me.chkDate.Name = "chkDate"
        Me.chkDate.Size = New System.Drawing.Size(88, 20)
        Me.chkDate.TabIndex = 4
        Me.chkDate.Text = "贷款截止日"
        '
        'btnSearch
        '
        Me.btnSearch.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnSearch.Location = New System.Drawing.Point(488, 88)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.TabIndex = 12
        Me.btnSearch.Text = "查询(&S)"
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExcel.Location = New System.Drawing.Point(568, 88)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(104, 23)
        Me.btnExcel.TabIndex = 13
        Me.btnExcel.Text = "导出Excel(&E)"
        '
        'chkCondition
        '
        Me.chkCondition.Checked = True
        Me.chkCondition.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCondition.Location = New System.Drawing.Point(16, 88)
        Me.chkCondition.Name = "chkCondition"
        Me.chkCondition.Size = New System.Drawing.Size(168, 24)
        Me.chkCondition.TabIndex = 14
        Me.chkCondition.Text = "是否显示查询条件设置"
        '
        'btnClear
        '
        Me.btnClear.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnClear.Location = New System.Drawing.Point(408, 88)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "清空(&C)"
        '
        'frmOverdueProjectQuery
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(792, 391)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClear, Me.chkCondition, Me.grpCondition, Me.gpbDG, Me.btnExcel, Me.btnSearch, Me.btnExit})
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmOverdueProjectQuery"
        Me.Text = "逾期项目一览表"
        Me.gpbDG.ResumeLayout(False)
        CType(Me.dgList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmOverdueProjectQuery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsST As DataSet = gWs.GetServiceType("%")
        cboServiceType.DataSource = dsST.Tables(0)
        cboServiceType.DisplayMember = "service_type"
        cboServiceType.ValueMember = "service_type"
        AddTableStyle()
        AddHandler chkCondition.CheckedChanged, AddressOf chkCondition_CheckedChanged
    End Sub
    Private Sub AddTableStyle()
        dgList.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "Table"
        dgts.AllowSorting = False
        Dim col1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()      'index 1
        col1.MappingName = "ProjectCode"
        col1.HeaderText = "项目编码"
        col1.Width = 65
        col1.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col1)
        Dim col11 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 2
        col11.MappingName = "EnterpriseName"
        col11.HeaderText = "企业名称"
        col11.Width = 90
        col11.NullText = String.Empty
        col11.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col11)
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 4  为删除dsConferenceTrial而设计
        col6.MappingName = "ServiceType"
        col6.HeaderText = "业务品种"
        col6.Width = 80
        col6.NullText = String.Empty
        col6.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col6)
        Dim col8 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col8.MappingName = "loan_sum"
        col8.HeaderText = "贷款金额(万元)"
        col8.Alignment = HorizontalAlignment.Left
        col8.Width = 95
        col8.Format = "c"
        col8.FormatInfo = CGFormatInfo
        col8.NullText = String.Empty
        dgts.GridColumnStyles.Add(col8)
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 3 
        col2.MappingName = "StartTime"
        col2.HeaderText = "贷款日期"
        col2.Alignment = HorizontalAlignment.Center
        col2.NullText = String.Empty
        col2.Width = 70
        col2.Format = "yyyy-MM-dd"
        dgts.GridColumnStyles.Add(col2)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 5
        col3.MappingName = "ENDTIME"
        col3.HeaderText = "截止日期"
        col3.Width = 70
        col3.Format = "yyyy-MM-dd"
        col3.NullText = String.Empty
        col3.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col3)
        Dim col12 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 6
        col12.MappingName = "RefundType"
        col12.HeaderText = "还款方式"
        col12.Width = 80
        col12.NullText = String.Empty
        col12.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col12)
        Dim co6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 6
        co6.MappingName = "Money32001"
        co6.HeaderText = "贷款期止撤保金额(元)"
        co6.Width = 105
        co6.Format = "c"
        co6.FormatInfo = CGFormatInfo
        co6.NullText = String.Empty
        co6.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(co6)
        Dim co5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 6
        co5.MappingName = "AfterEndTime"
        co5.HeaderText = "逾期追回金额(元)"
        co5.Width = 90
        co5.Format = "c"
        co5.FormatInfo = CGFormatInfo
        co5.NullText = String.Empty
        co5.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(co5)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col4.MappingName = "Money32002"
        col4.HeaderText = "逾期金额(元)"
        col4.Alignment = HorizontalAlignment.Left
        col4.Width = 65
        col4.NullText = String.Empty
        col4.Format = "c"
        col4.FormatInfo = CGFormatInfo
        dgts.GridColumnStyles.Add(col4)
        Dim col7 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 6
        col7.MappingName = "refund_sum" 'refund_sum
        col7.HeaderText = "撤保总额(元)"
        col7.Width = 65
        col7.Format = "c"
        col7.FormatInfo = CGFormatInfo
        col7.NullText = String.Empty
        col7.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(col7)
        Dim co1 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 6
        co1.MappingName = "Money32004"
        co1.HeaderText = "逾期保费(元)"
        co1.Width = 65
        co1.Format = "c"
        co1.FormatInfo = CGFormatInfo
        co1.NullText = String.Empty
        co1.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(co1)
        Dim co2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 6
        co2.MappingName = "balance"
        co2.HeaderText = "项目余额(元)"
        co2.Width = 65
        co2.Format = "c"
        co2.FormatInfo = CGFormatInfo
        co2.NullText = String.Empty
        co2.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(co2)
        Dim co3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 6
        co3.MappingName = "BankName"
        co3.HeaderText = "贷款银行"
        co3.Width = 90
        co3.NullText = String.Empty
        co3.Alignment = HorizontalAlignment.Left
        dgts.GridColumnStyles.Add(co3)
        Dim col9 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col9.MappingName = "ManagerA"
        col9.HeaderText = "项目经理A角"
        col9.Alignment = HorizontalAlignment.Left
        col9.Width = 55
        col9.NullText = String.Empty
        dgts.GridColumnStyles.Add(col9)
        Dim col10 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 7
        col10.MappingName = "ManagerLaw"
        col10.HeaderText = "法务经理"
        col10.Alignment = HorizontalAlignment.Left
        col10.Width = 55
        col10.NullText = String.Empty
        dgts.GridColumnStyles.Add(col10)
        dgList.TableStyles.Add(dgts)
    End Sub

    Protected Sub SetLayout()
        Dim height As Integer = IIf(chkCondition.Checked, grpCondition.Height, -grpCondition.Height)

        grpCondition.Visible = chkCondition.Checked

        btnExit.Top += height
        btnSearch.Top += height
        btnExcel.Top += height
        btnClear.Top += height
        chkCondition.Top += height
        gpbDG.Top += height
        gpbDG.Height = Me.ClientSize.Height - gpbDG.Top - 8
    End Sub

    Private Sub Clear()
        Dim control As Control

        For Each control In grpCondition.Controls
            If control.GetType() Is GetType(TextBox) Then
                control.Text = ""
            End If
            If control.GetType() Is GetType(ComboBox) Then
                CType(control, ComboBox).SelectedIndex = -1
                CType(control, ComboBox).SelectedItem = Nothing
            End If
            If control.GetType() Is GetType(CheckBox) Then
                CType(control, CheckBox).Checked = False
            End If
        Next

    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub chkCondition_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        Me.SetLayout()
        Me.Clear()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        Me.Clear()
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Dim sfd As SaveFileDialog = New SaveFileDialog()
        sfd.FileName = "逾期项目一览表"
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
            Me.Cursor = Cursors.WaitCursor
            oExcel = New Excel.ApplicationClass()
            oExcel.Application.Workbooks.Add()

            oExcel.Application.Workbooks(1).SaveAs(FilePath)
            Dim workBook As Excel.WorkbookClass = oExcel.ActiveWorkbook
            Dim workSheet As Excel.Worksheet = workBook.Sheets(1)
            Dim rang As Excel.Range = workSheet.Cells
            Dim i, row, col As Integer
            Dim column As DataGridTextBoxColumn
            Dim dt As DataTable = CType(dgList.DataSource, DataSet).Tables(0)
            Dim count As Integer = dt.Rows.Count
            For Each column In dgList.TableStyles(0).GridColumnStyles
                row = 4
                col = dgList.TableStyles(0).GridColumnStyles.IndexOf(column)
                rang.Item(row, col + 1) = column.HeaderText
                For i = 0 To count - 1
                    rang.Item(row + i + 1, col + 1) = dt.Rows(i)(column.MappingName)
                Next
            Next
            workSheet.Columns.AutoFit()
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
            Me.Cursor = Cursors.Default
            oExcel = Nothing
            'GC.Collect()
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim StartTime, EndTime As Object
        StartTime = IIf(chkDate.Checked, dtpStartDate.Value.Date, "1990-1-1")
        EndTime = IIf(chkDate.Checked, dtpEndDate.Value.Date, "9999-1-1")
        If chkDate.Checked AndAlso DateTime.Parse(StartTime).Date > DateTime.Parse(EndTime).Date Then
            SWDialogBox.MessageBox.Show("$1008", "起始日期", "截止日期")
            dtpEndDate.Value = dtpStartDate.Value.Date
            Return
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim dsList As DataSet = gWs.GetOverdueProjectList(txtProjectCode.Text.Trim, cboServiceType.Text.Trim, StartTime, EndTime)
            dgList.DataMember = "Table"
            dgList.DataSource = dsList
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class
