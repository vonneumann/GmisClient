Public Class FSignatureQuery
    Inherits System.Windows.Forms.Form
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not htSelected Is Nothing Then
            htSelected = Nothing
        End If
        If Not dsSignature Is Nothing Then
            dsSignature.Dispose()
        End If
        If Not dsSigProject Is Nothing Then
            dsSigProject.Dispose()
        End If
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgQuery As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSure As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents nudYear As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents lbxSigDates As System.Windows.Forms.ListBox
    Friend WithEvents cboMonth As System.Windows.Forms.ComboBox
    Friend WithEvents dgtsSignature As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents col1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents col8 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FSignatureQuery))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgQuery = New System.Windows.Forms.DataGrid()
        Me.dgtsSignature = New System.Windows.Forms.DataGridTableStyle()
        Me.col1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.col8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSure = New System.Windows.Forms.Button()
        Me.cboMonth = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.nudYear = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lbxSigDates = New System.Windows.Forms.ListBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgQuery, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgQuery})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(672, 264)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'dgQuery
        '
        Me.dgQuery.CaptionVisible = False
        Me.dgQuery.DataMember = ""
        Me.dgQuery.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgQuery.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgQuery.Location = New System.Drawing.Point(3, 17)
        Me.dgQuery.Name = "dgQuery"
        Me.dgQuery.ReadOnly = True
        Me.dgQuery.Size = New System.Drawing.Size(666, 244)
        Me.dgQuery.TabIndex = 0
        Me.dgQuery.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.dgtsSignature})
        '
        'dgtsSignature
        '
        Me.dgtsSignature.AllowSorting = False
        Me.dgtsSignature.DataGrid = Me.dgQuery
        Me.dgtsSignature.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.col1, Me.col2, Me.col3, Me.col4, Me.col5, Me.col6, Me.col7, Me.col8})
        Me.dgtsSignature.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgtsSignature.MappingName = "Table"
        '
        'col1
        '
        Me.col1.Format = ""
        Me.col1.FormatInfo = Nothing
        Me.col1.HeaderText = "项目编码"
        Me.col1.MappingName = "ProjectCode"
        Me.col1.NullText = ""
        Me.col1.Width = 80
        '
        'col2
        '
        Me.col2.Format = ""
        Me.col2.FormatInfo = Nothing
        Me.col2.HeaderText = "企业名称"
        Me.col2.MappingName = "EnterpriseName"
        Me.col2.NullText = ""
        Me.col2.Width = 130
        '
        'col3
        '
        Me.col3.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.col3.Format = "n"
        Me.col3.FormatInfo = Nothing
        Me.col3.HeaderText = "担保金额(万元)"
        Me.col3.MappingName = "GuaranteeSum"
        Me.col3.NullText = ""
        Me.col3.Width = 90
        '
        'col4
        '
        Me.col4.Format = ""
        Me.col4.FormatInfo = Nothing
        Me.col4.HeaderText = "业务品种"
        Me.col4.MappingName = "ServiceType"
        Me.col4.NullText = ""
        Me.col4.Width = 110
        '
        'col5
        '
        Me.col5.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.col5.Format = "n"
        Me.col5.FormatInfo = Nothing
        Me.col5.HeaderText = "签约金额(万元)"
        Me.col5.MappingName = "sign_sum"
        Me.col5.NullText = ""
        Me.col5.Width = 90
        '
        'col6
        '
        Me.col6.Format = ""
        Me.col6.FormatInfo = Nothing
        Me.col6.HeaderText = "经理A角"
        Me.col6.MappingName = "manager_A"
        Me.col6.NullText = ""
        Me.col6.Width = 80
        '
        'col7
        '
        Me.col7.Format = ""
        Me.col7.FormatInfo = Nothing
        Me.col7.HeaderText = "经理B角"
        Me.col7.MappingName = "manager_B"
        Me.col7.NullText = ""
        Me.col7.Width = 80
        '
        'col8
        '
        Me.col8.Format = ""
        Me.col8.FormatInfo = Nothing
        Me.col8.HeaderText = "法务经理"
        Me.col8.MappingName = "law_manager"
        Me.col8.NullText = ""
        Me.col8.Width = 80
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnSure, Me.cboMonth, Me.Label2, Me.nudYear, Me.Label1, Me.GroupBox4})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 272)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(672, 160)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        '
        'btnSure
        '
        Me.btnSure.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSure.Location = New System.Drawing.Point(160, 11)
        Me.btnSure.Name = "btnSure"
        Me.btnSure.Size = New System.Drawing.Size(64, 23)
        Me.btnSure.TabIndex = 8
        Me.btnSure.Tag = "NotChanged"
        Me.btnSure.Text = "确定(&S)"
        '
        'cboMonth
        '
        Me.cboMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonth.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cboMonth.Location = New System.Drawing.Point(96, 12)
        Me.cboMonth.Name = "cboMonth"
        Me.cboMonth.Size = New System.Drawing.Size(40, 20)
        Me.cboMonth.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(136, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 12)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "月"
        '
        'nudYear
        '
        Me.nudYear.Location = New System.Drawing.Point(16, 12)
        Me.nudYear.Maximum = New Decimal(New Integer() {2100, 0, 0, 0})
        Me.nudYear.Minimum = New Decimal(New Integer() {1900, 0, 0, 0})
        Me.nudYear.Name = "nudYear"
        Me.nudYear.ReadOnly = True
        Me.nudYear.Size = New System.Drawing.Size(56, 21)
        Me.nudYear.TabIndex = 5
        Me.nudYear.Value = New Decimal(New Integer() {2003, 0, 0, 0})
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(72, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "年"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.lbxSigDates})
        Me.GroupBox4.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(656, 112)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "计划签约日期"
        '
        'lbxSigDates
        '
        Me.lbxSigDates.ColumnWidth = 75
        Me.lbxSigDates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbxSigDates.ItemHeight = 12
        Me.lbxSigDates.Location = New System.Drawing.Point(3, 17)
        Me.lbxSigDates.MultiColumn = True
        Me.lbxSigDates.Name = "lbxSigDates"
        Me.lbxSigDates.Size = New System.Drawing.Size(650, 88)
        Me.lbxSigDates.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(304, 440)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 31
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'FSignatureQuery
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(688, 469)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.GroupBox2, Me.GroupBox1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FSignatureQuery"
        Me.Text = "签约安排查询"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgQuery, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.nudYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private dsSignature As DataSet
    Private cmSignature As CurrencyManager
    Private dsSigProject As DataSet
    Private SystemDate As DateTime

    Private cmSigProject As CurrencyManager
    Private htSelected As Hashtable
    Private Sub DateChanged(ByVal sender As Object, ByVal e As EventArgs)
        If lbxSigDates.SelectedItem Is Nothing OrElse btnSure.Tag.ToString = "Changed" Then
            Return
        End If
        If System.Object.Equals(lbxSigDates.Tag, lbxSigDates.SelectedValue) Then
            Return
        End If
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not htSelected.ContainsKey(lbxSigDates.SelectedValue) Then
                htSelected.Add(lbxSigDates.SelectedValue, lbxSigDates.SelectedValue)
                Dim dsTemp As DataSet = gWs.GetNeedSignatureProjectInfo("{project_signature.signature_plan_code=" & lbxSigDates.SelectedValue.ToString & "}")
                '由于返回时并没有列 signature_plan_code,故在此每条记录赋值
                dsTemp.Tables(0).Columns.Add("SigCode", GetType(String))
                Dim dr As DataRow
                For Each dr In dsTemp.Tables(0).Rows
                    dr("SigCode") = lbxSigDates.SelectedValue.ToString
                Next
                If dsSigProject Is Nothing Then
                    dsSigProject = New DataSet()
                    dsSigProject = dsTemp.Copy
                    dgQuery.SetDataBinding(dsSigProject, "Table")
                    cmSigProject = Me.BindingContext(dsSigProject, "Table")
                    lbxSigDates.Tag = lbxSigDates.SelectedValue
                    Return
                Else
                    dsSigProject.Merge(dsTemp.Tables(0).Select("", "", DataViewRowState.CurrentRows))
                End If
                dsTemp.Dispose()
            End If
            CType(cmSigProject.List, DataView).RowFilter = "SigCode=" & lbxSigDates.SelectedValue.ToString
            'dsSigProject.Merge(gWs.GetNeedSignatureProjectInfo("{project_signature.signature_plan_code=" & lbxSigDates.SelectedValue.ToString & "}").Tables(0))
            lbxSigDates.Tag = lbxSigDates.SelectedValue
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
  

    Private Sub GetSignatureDates(ByVal year As Int32, ByVal month As Int32)
        Dim MinDate As DateTime = New DateTime(year, month, 1)
        Dim MaxDate As DateTime = New DateTime(IIf(month = 12, year + 1, year), IIf(month = 12, 1, month + 1), 1)
        If dsSignature Is Nothing Then
            dsSignature = New DataSet()
        Else
            Dim i, count As Integer
            count = dsSignature.Tables(0).Rows.Count
            For i = count - 1 To 0 Step -1
                dsSignature.Tables(0).Rows.RemoveAt(i)
            Next
        End If
        dsSignature.Merge(gWs.GetSignaturePlanInfo("{signature_plan_date>='" & MinDate & "' AND signature_plan_date<'" & MaxDate & "' ORDER BY signature_plan_date}").Tables(0))

        If dsSignature.Tables.Count = 0 Then '没有表
            Return
        End If

        If cmSignature Is Nothing Then
            dsSignature.Tables(0).Columns.Add("DateNoTimeString", GetType(String))
            cmSignature = Me.BindingContext(dsSignature, dsSignature.Tables(0).TableName)
        End If
        Dim j, cot As Int32
        cot = dsSignature.Tables(0).Rows.Count
        For j = cot - 1 To 0 Step -1
            dsSignature.Tables(0).Rows(j)("DateNoTimeString") = String.Format("{0,10:yyyy-MM-dd}", dsSignature.Tables(0).Rows(j)("signature_plan_date"))
        Next
        If lbxSigDates.DataSource Is Nothing Then
            lbxSigDates.DataSource = dsSignature.Tables(0)
            lbxSigDates.DisplayMember = "DateNoTimeString" '"signature_plan_date"
            lbxSigDates.ValueMember = "signature_plan_code"
            AddHandler lbxSigDates.SelectedValueChanged, AddressOf DateChanged
        End If
        cmSignature.Refresh()
    End Sub

    Private Sub btnSure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSure.Click
        If btnSure.Tag.ToString = "NotChanged" Then
            Return
        End If
        GetSignatureDates(CInt(nudYear.Value), cboMonth.SelectedIndex + 1)
        btnSure.Tag = "NotChanged"
    End Sub
    Private Sub nudYear_ValueChanged(ByVal sender As Object, ByVal e As EventArgs)
        btnSure.Tag = "Changed"
    End Sub
    Private Sub cboMonth_IndexChanged(ByVal sender As Object, ByVal e As EventArgs)
        btnSure.Tag = "Changed"
    End Sub

    Private Sub FSignatureQuery_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        htSelected = New Hashtable()
        SystemDate = gWs.GetSysTime
        nudYear.Value = SystemDate.Year
        cboMonth.SelectedIndex = SystemDate.Month - 1
        GetSignatureDates(Convert.ToInt32(nudYear.Value), cboMonth.SelectedIndex + 1)
        AddHandler cboMonth.SelectedIndexChanged, AddressOf cboMonth_IndexChanged
        AddHandler nudYear.ValueChanged, AddressOf nudYear_ValueChanged
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
