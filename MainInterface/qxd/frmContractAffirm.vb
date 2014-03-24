

Public Class frmContractAffirm
    Inherits MainInterface.frmMaterial

    Private strProjectCode As String
    Private strCorporationName As String
    Private strWorkFlowID As String
    Private strTaskID As String
    Private strPerson As String
    Private strPhase As String
    Private strDir As String = "Document\Contract"

    Private strAffirmType As String = "44" '放款检查列表
    Private strAffirmCode As String = "004" '合同确认
    Private strCheckType As String = "53"
    Private strCheckCode As String = "002"

    Private dsMaterial As DataSet
    Private dsSigPro As DataSet
    Private strFinishedFlag As String = ""
    Private isLoad As Boolean = False '供退出时判断,是否是刚load,没做任何其他按钮操作

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
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chbAffirm As System.Windows.Forms.CheckBox
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridBoolColumn3 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnUpload As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAssureContractNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtLoanContractNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmContractAffirm))
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chbAffirm = New System.Windows.Forms.CheckBox()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridBoolColumn3 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtAssureContractNumber = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLoanContractNumber = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(264, -24)
        Me.Label7.Size = New System.Drawing.Size(56, 24)
        Me.Label7.Visible = True
        '
        'dgMaterial
        '
        Me.dgMaterial.AccessibleName = "DataGrid"
        Me.dgMaterial.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgMaterial.Size = New System.Drawing.Size(594, 248)
        Me.dgMaterial.TabIndex = 2
        Me.dgMaterial.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgMaterial.Visible = True
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(16, 4)
        Me.Label11.Visible = True
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(80, 5)
        Me.txtRemark.Visible = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, -24)
        Me.Label5.Size = New System.Drawing.Size(56, 24)
        Me.Label5.Visible = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Size = New System.Drawing.Size(594, 248)
        Me.Panel1.Visible = True
        '
        'cmbType
        '
        Me.cmbType.ItemHeight = 12
        Me.cmbType.Location = New System.Drawing.Point(88, -40)
        Me.cmbType.TabIndex = 0
        Me.cmbType.Text = "合同列表"
        Me.cmbType.Visible = True
        '
        'txtCode
        '
        Me.txtCode.Visible = True
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(408, 4)
        Me.Label10.Visible = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, -40)
        Me.Label3.Size = New System.Drawing.Size(40, 33)
        Me.Label3.Visible = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(264, -104)
        Me.Label6.Size = New System.Drawing.Size(56, 49)
        Me.Label6.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox2.Size = New System.Drawing.Size(600, 272)
        Me.GroupBox2.Visible = True
        '
        'dateCheck
        '
        Me.dateCheck.Location = New System.Drawing.Point(448, 5)
        Me.dateCheck.Value = New Date(2003, 4, 11, 17, 46, 14, 796)
        Me.dateCheck.Visible = True
        '
        'txtName
        '
        Me.txtName.Size = New System.Drawing.Size(216, 21)
        Me.txtName.Visible = True
        '
        'chbFile
        '
        Me.chbFile.Location = New System.Drawing.Point(488, -24)
        Me.chbFile.Visible = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(280, -40)
        Me.Label4.Size = New System.Drawing.Size(64, 33)
        Me.Label4.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(408, -24)
        Me.Label8.Size = New System.Drawing.Size(56, 24)
        Me.Label8.Visible = True
        '
        'cmbContent
        '
        Me.cmbContent.ItemHeight = 12
        Me.cmbContent.Location = New System.Drawing.Point(368, -40)
        Me.cmbContent.TabIndex = 1
        Me.cmbContent.Visible = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.chbAffirm, Me.Label12})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 292)
        Me.GroupBox3.Size = New System.Drawing.Size(0, 64)
        Me.GroupBox3.Visible = True
        '
        'chbCheck
        '
        Me.chbCheck.Location = New System.Drawing.Point(336, -24)
        Me.chbCheck.Visible = True
        '
        'txtMaterial
        '
        Me.txtMaterial.Location = New System.Drawing.Point(80, -24)
        Me.txtMaterial.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(264, 4)
        Me.Label9.Visible = True
        '
        'chbImportant
        '
        Me.chbImportant.Location = New System.Drawing.Point(336, -104)
        Me.chbImportant.Size = New System.Drawing.Size(24, 50)
        Me.chbImportant.Visible = True
        '
        'txtPerson
        '
        Me.txtPerson.Location = New System.Drawing.Point(304, 5)
        Me.txtPerson.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(424, 368)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(16, 72)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 23)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "合同办理完毕"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chbAffirm
        '
        Me.chbAffirm.Location = New System.Drawing.Point(104, 72)
        Me.chbAffirm.Name = "chbAffirm"
        Me.chbAffirm.Size = New System.Drawing.Size(24, 24)
        Me.chbAffirm.TabIndex = 15
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(336, 368)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 3
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnView
        '
        Me.btnView.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnView.Image = CType(resources.GetObject("btnView.Image"), System.Drawing.Bitmap)
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.ImageIndex = 18
        Me.btnView.ImageList = Me.ImageListBasic
        Me.btnView.Location = New System.Drawing.Point(232, 368)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(93, 24)
        Me.btnView.TabIndex = 2
        Me.btnView.Text = "查看合同(&V)"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.DataGrid = Me.dgMaterial
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridBoolColumn1, Me.DataGridBoolColumn2, Me.DataGridBoolColumn3, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TProjectDocument"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "资料名称"
        Me.DataGridTextBoxColumn1.MappingName = "doc_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 400
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.AllowNull = False
        Me.DataGridBoolColumn1.FalseValue = False
        Me.DataGridBoolColumn1.HeaderText = "确认"
        Me.DataGridBoolColumn1.MappingName = "is_check"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.NullValue = CType(resources.GetObject("DataGridBoolColumn1.NullValue"), System.DBNull)
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 50
        '
        'DataGridBoolColumn2
        '
        Me.DataGridBoolColumn2.AllowNull = False
        Me.DataGridBoolColumn2.FalseValue = False
        Me.DataGridBoolColumn2.HeaderText = "审核"
        Me.DataGridBoolColumn2.MappingName = "is_affirm"
        Me.DataGridBoolColumn2.NullText = ""
        Me.DataGridBoolColumn2.NullValue = CType(resources.GetObject("DataGridBoolColumn2.NullValue"), System.DBNull)
        Me.DataGridBoolColumn2.ReadOnly = True
        Me.DataGridBoolColumn2.TrueValue = True
        Me.DataGridBoolColumn2.Width = 50
        '
        'DataGridBoolColumn3
        '
        Me.DataGridBoolColumn3.AllowNull = False
        Me.DataGridBoolColumn3.FalseValue = False
        Me.DataGridBoolColumn3.HeaderText = "有文档"
        Me.DataGridBoolColumn3.MappingName = "is_file"
        Me.DataGridBoolColumn3.NullText = ""
        Me.DataGridBoolColumn3.NullValue = CType(resources.GetObject("DataGridBoolColumn3.NullValue"), System.DBNull)
        Me.DataGridBoolColumn3.ReadOnly = True
        Me.DataGridBoolColumn3.TrueValue = True
        Me.DataGridBoolColumn3.Width = 50
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "备注"
        Me.DataGridTextBoxColumn2.MappingName = "remark"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "确认人"
        Me.DataGridTextBoxColumn3.MappingName = "check_person"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "日期"
        Me.DataGridTextBoxColumn4.MappingName = "check_date"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'btnUpload
        '
        Me.btnUpload.Image = CType(resources.GetObject("btnUpload.Image"), System.Drawing.Bitmap)
        Me.btnUpload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpload.ImageIndex = 16
        Me.btnUpload.ImageList = Me.ImageListBasic
        Me.btnUpload.Location = New System.Drawing.Point(117, 368)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(104, 24)
        Me.btnUpload.TabIndex = 5
        Me.btnUpload.Text = "上载合同原件"
        Me.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtAssureContractNumber, Me.Label13, Me.txtLoanContractNumber, Me.Label14})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 312)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(600, 48)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'txtAssureContractNumber
        '
        Me.txtAssureContractNumber.Location = New System.Drawing.Point(358, 16)
        Me.txtAssureContractNumber.Name = "txtAssureContractNumber"
        Me.txtAssureContractNumber.Size = New System.Drawing.Size(160, 21)
        Me.txtAssureContractNumber.TabIndex = 43
        Me.txtAssureContractNumber.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(279, 20)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(66, 14)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "保证合同号"
        '
        'txtLoanContractNumber
        '
        Me.txtLoanContractNumber.Location = New System.Drawing.Point(80, 16)
        Me.txtLoanContractNumber.Name = "txtLoanContractNumber"
        Me.txtLoanContractNumber.Size = New System.Drawing.Size(152, 21)
        Me.txtLoanContractNumber.TabIndex = 42
        Me.txtLoanContractNumber.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 20)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 14)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "借款合同号"
        '
        'frmContractAffirm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(618, 399)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.Label1, Me.txtCode, Me.txtName, Me.btnExit, Me.GroupBox3, Me.GroupBox2, Me.GroupBox1, Me.btnUpload, Me.btnView, Me.btnCommit})
        Me.Name = "frmContractAffirm"
        Me.Text = "合同办理完毕确认"
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Load()
    Private Sub frmContractAffirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            isLoad = True
            Me.GroupBox3.Visible = False
            Me.strProjectCode = Me.getProjectCode()
            Me.strCorporationName = Me.getCorporationName()
            Me.strWorkFlowID = Me.getWorkFlowID()
            Me.strTaskID = Me.getTaskID()
            Me.strPerson = Me.getUser()
            Me.strPhase = getPhase(strProjectCode)
            Me.txtCode.Text = strProjectCode
            Me.txtName.Text = strCorporationName

            setTextBox(False)
            Me.Label4.Visible = False
            Me.cmbContent.Visible = False
            Me.Label6.Visible = False
            Me.chbImportant.Visible = False
            Me.dsMaterial = setDgDataSource(strProjectCode, False)
            If Not Me.dsMaterial Is Nothing Then
                addStyle(Me.dsMaterial)
            End If
            setButton()

            '2007-8-12 yjf add 添加保存合同号功能
            dsSigPro = gWs.GetProjectSignatureInfo("{project_code LIKE '" & MyBase.getProjectCode & "'}")
            If dsSigPro.Tables(0).Rows.Count <> 0 Then
                txtLoanContractNumber.Text = IIf(IsDBNull(dsSigPro.Tables(0).Rows(0).Item("loanContract_num")), "", dsSigPro.Tables(0).Rows(0).Item("loanContract_num"))
                txtAssureContractNumber.Text = IIf(IsDBNull(dsSigPro.Tables(0).Rows(0).Item("assureContract_num")), "", dsSigPro.Tables(0).Rows(0).Item("assureContract_num"))
            End If


        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '添加dataGrid的style
    Private Sub addStyle(ByVal ds As DataSet)

        Dim tableStyle As DataGridTableStyle = New DataGridTableStyle()
        tableStyle.MappingName = "TProjectDocument"
        tableStyle.AllowSorting = False
        tableStyle.RowHeadersVisible = True

        Dim numCols As Integer = ds.Tables("TProjectDocument").Columns.Count
        Dim dgc As New DataGridColoredBoolColumn()
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf dgc.MyGetColorRowCol)

        Dim column_1 As New DataGridTextBoxColumn()
        column_1.Width = 300
        column_1.ReadOnly = True
        column_1.NullText = ""
        column_1.HeaderText = "资料名称"
        column_1.MappingName = "doc_name"
        tableStyle.GridColumnStyles.Add(column_1)

        Dim aColumnTextColumn As DataGridColoredBoolColumn
        aColumnTextColumn = New DataGridColoredBoolColumn(d, 0)
        aColumnTextColumn.HeaderText = "确认"
        aColumnTextColumn.AllowNull = False
        aColumnTextColumn.MappingName = "is_check"
        tableStyle.GridColumnStyles.Add(aColumnTextColumn)

        Dim bColumnTextColumn As DataGridColoredBoolColumn
        bColumnTextColumn = New DataGridColoredBoolColumn(d, 1)
        bColumnTextColumn.HeaderText = "审核"
        bColumnTextColumn.AllowNull = False
        bColumnTextColumn.Width = 0
        bColumnTextColumn.ReadOnly = True
        bColumnTextColumn.MappingName = "is_affirm"
        tableStyle.GridColumnStyles.Add(bColumnTextColumn)

        Dim column_2 As New DataGridBoolColumn()
        column_2.ReadOnly = True
        column_2.Width = 50
        column_2.NullText = ""
        column_2.AllowNull = False
        column_2.HeaderText = "有文档"
        column_2.MappingName = "is_file"
        tableStyle.GridColumnStyles.Add(column_2)

        Dim column_3 As New DataGridTextBoxColumn()
        column_3.ReadOnly = True
        column_3.Width = 0
        column_3.NullText = ""
        column_3.HeaderText = "说明"
        column_3.MappingName = "remark"
        tableStyle.GridColumnStyles.Add(column_3)

        Dim column_4 As New DataGridTextBoxColumn()
        column_4.ReadOnly = True
        column_4.NullText = ""
        column_4.HeaderText = "确认人"
        column_4.MappingName = "check_person"
        tableStyle.GridColumnStyles.Add(column_4)

        Dim column_5 As New DataGridTextBoxColumn()
        column_5.ReadOnly = True
        column_5.NullText = ""
        column_5.HeaderText = "日期"
        column_5.MappingName = "check_date"
        tableStyle.GridColumnStyles.Add(column_5)

        Me.dgMaterial.TableStyles.Clear()
        Me.dgMaterial.TableStyles.Add(tableStyle)
    End Sub
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        frmExit(sender, e)
    End Sub
    '退出处理
    Private Function frmExit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '根据dataSet判断是否修改了
        Dim changedCount As Integer = 0
        If Not Me.dsMaterial Is Nothing Then
            Try
                changedCount = Me.dsMaterial.GetChanges.Tables(0).Rows.Count
            Catch
            End Try
        End If
        If isLoad Then
            Me.Close()
            Exit Function
        End If
        If changedCount > 0 Then
            Dim strMesg As Integer
            'strMesg = MsgBox("数据已修改，是否保存？", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "提示")
            strMesg = SWDialogBox.MessageBox.Show("?1003")
            If 6 = strMesg Then
                Call saveContractAffirm(gWs)
                Me.Close()
            ElseIf strMesg = 7 Then
                Me.Close()
            Else
                Return True
            End If
        Else
            Me.Close()
        End If
    End Function
    '列表中鼠标按下事件
    Private Sub dgMaterial_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgMaterial.MouseUp
        If Me.dsMaterial Is Nothing Then
            Exit Sub
        End If
        If Me.dsMaterial.Tables("TProjectDocument").Rows.Count > 0 Then
            Me.dgMaterial.Select(Me.dgMaterial.CurrentCell.RowNumber)
            '单击datagrid中的checkbox时改变checked
            Dim rowNum, colNum As Integer
            rowNum = Me.dgMaterial.CurrentCell.RowNumber
            colNum = Me.dgMaterial.CurrentCell.ColumnNumber
            If colNum = 1 Then
                isLoad = False
                Dim he As DataGrid = CType(sender, DataGrid)
                If he.HitTest(e.X, e.Y).Type <> DataGrid.HitTestType.Cell Then Return
                Me.dgMaterial.Item(rowNum, colNum) = Not Me.dgMaterial.Item(rowNum, colNum)
            End If
            setButton()
        End If
    End Sub
    '提交
    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            'If MsgBoxResult.Yes = MsgBox("是否确认提交?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "提示") Then
            If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1000", "提交") Then
                commit()
            End If
        Else
            commit()
        End If
    End Sub
    '提交处理
    Private Sub commit()
        'If isAccreditCommit() Then
        '    'MsgBox("有未确认的合同,不能提交!", MsgBoxStyle.Exclamation, "提示")
        '    SWDialogBox.MessageBox.Show("$1009", "")
        '    Exit Sub
        'End If

        '2007-10-18 yjf add 关键信息必须填写
        If Trim(txtLoanContractNumber.Text) = String.Empty Then
            SWDialogBox.MessageBox.Show("$1001", "借款合同号")
            txtLoanContractNumber.Focus()
            Return
        End If

        '2010-05-11 yjf add 借款合同号填写要求
        If Trim(txtLoanContractNumber.Text).Length < 10 Then
            SWDialogBox.MessageBox.Show("必须正确填写借款合同号", "系统提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
            txtLoanContractNumber.Focus()
            Return
        End If

        '2007-10-18 yjf add 关键信息必须填写
        If Trim(txtAssureContractNumber.Text) = String.Empty Then
            SWDialogBox.MessageBox.Show("$1001", "保证合同号")
            txtAssureContractNumber.Focus()
            Return
        End If

        '2010-05-11 yjf add 保证合同号填写要求
        If Trim(txtAssureContractNumber.Text).Length < 10 Then
            SWDialogBox.MessageBox.Show("必须正确填写保证合同号", "系统提示", "", SWDialogBox.MessageBoxButton.OK, SWDialogBox.MessageBoxIcon.Information)
            txtAssureContractNumber.Focus()
            Return
        End If

        Dim strSaveSucceed As String
        addAffirmRecord(strProjectCode, strAffirmType, strAffirmCode)
        strSaveSucceed = saveContractAffirm(gWs)

        '2007-8-12 yjf add 添加保存合同号功能
        If dsSigPro.Tables(0).Rows.Count = 0 Then
            Dim row As DataRow = dsSigPro.Tables(0).NewRow
            row("project_code") = MyBase.getProjectCode
            row("create_person") = UserName
            row("create_date") = gWs.GetSysTime
            dsSigPro.Tables(0).Rows.Add(row)
        End If

        With dsSigPro.Tables(0).Rows(0)
            .Item("loanContract_num") = IIf(txtLoanContractNumber.Text = "", DBNull.Value, txtLoanContractNumber.Text)
            .Item("assureContract_num") = IIf(txtAssureContractNumber.Text = "", DBNull.Value, txtAssureContractNumber.Text)
        End With

        Dim strResult As String
        strResult = gWs.UpdateProjectSignature(dsSigPro.GetChanges)
        If strResult <> "1" Then
            If strResult.StartsWith("1将截断字符串或二进制数据") Then
                SWDialogBox.MessageBox.Show("合同编号超过了目前数据库所设定的长度！", "提示", "请修改表project_signature中loanContract_num和assureContract_num字段的最大长度！", SWDialogBox.MessageBoxButton.Detail, SWDialogBox.MessageBoxIcon.Information)
                dsSigPro.RejectChanges()
            Else
                SWDialogBox.MessageBox.Show("*999", "保存失败", strResult, "")
            End If
            Return
        Else
            dsSigPro.AcceptChanges()
        End If


        If strSaveSucceed = "1" Then
            Dim strCommit As String
            Try
                strCommit = gWs.finishedTask(strWorkFlowID, strProjectCode, strTaskID, strFinishedFlag, strPerson)
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
            If "1" = strCommit Then
                'MsgBox("提交成功!", MsgBoxStyle.Information, "提示")
                SWDialogBox.MessageBox.Show("$SubmitSucceed")
                raiseCommitSucceed()
                Me.Close()
            Else
                'MsgBox("提交失败!" & strCommit, MsgBoxStyle.Critical, "提示")
                SWDialogBox.MessageBox.Show("*999", "", strCommit, "")
            End If
        Else
            'MsgBox("合同办理完毕确认保存失败!" & strSaveSucceed, MsgBoxStyle.Critical, "提示")
            SWDialogBox.MessageBox.Show("*999", "", strSaveSucceed, "")
        End If
    End Sub
    '
    ''判断基本的确认项是否已确认
    ''如果有一个没有确认,则返回true
    ''
    'Private Function isAccreditCommit()
    '    If Not Me.dsMaterial Is Nothing Then
    '        Dim i As Integer
    '        Dim dr As DataRow
    '        Dim isNotChecked As Boolean = False
    '        Try
    '            i = Me.dsMaterial.Tables("TProjectDocument").Rows.Count
    '            If i > 0 Then
    '                For i = 0 To i - 1
    '                    dr = Me.dsMaterial.Tables("TProjectDocument").Rows(i)
    '                    With dr
    '                        If Not .Item("is_check") Then
    '                            isNotChecked = True
    '                        End If
    '                    End With
    '                Next
    '            End If
    '        Catch
    '        End Try
    '        Return isNotChecked
    '    End If
    'End Function
    '
    '保存合同办理完毕确认的Affirm_person,Affirm_date
    '
    Private Function saveContractAffirm(ByVal gWs As htfServer.Service1)
        Try
            If Not Me.dsMaterial Is Nothing Then
                Dim i As Integer
                Dim dr As DataRow
                Dim strResult As String = "1"
                i = dsMaterial.Tables("TProjectDocument").Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = dsMaterial.Tables("TProjectDocument").Rows(i)
                        With dr
                            If Not .Item("is_check") Is System.DBNull.Value Then
                                If .Item("is_check") = True Then
                                    .Item("check_person") = strPerson
                                    Try
                                        .Item("check_date") = gWs.GetSysTime()
                                    Catch ex As Exception
                                        ExceptionHandler.ShowMessageBox(ex)
                                    End Try
                                Else
                                    .Item("check_person") = System.DBNull.Value
                                    .Item("check_date") = System.DBNull.Value
                                End If
                            Else
                                .Item("check_person") = System.DBNull.Value
                                .Item("check_date") = System.DBNull.Value
                            End If
                        End With
                    Next
                    strResult = gWs.UpdateProjectDocument(dsMaterial)
                End If
                If strResult = "1" Then
                    Me.dsMaterial = setDgDataSource(strProjectCode, False)
                    Return strResult
                Else
                    Return strResult
                End If
            Else
                Return "1"
            End If
        Catch ex As Exception
            Return ""
        Finally
        End Try
    End Function
    '
    '确认时,若记录已经存在,则修改确认记录;否则新增一条记录
    '保存在表project_document中
    '
    Private Function addAffirmRecord(ByVal projectCode As String, ByVal itemType As String, ByVal itemCode As String) As Boolean
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim strResult As String
        Try
            ds = gWs.GetProjectDocumentByCondition("{project_code='" & projectCode & "' and item_type='" & itemType & "' and item_code='" & itemCode & "'}")
        Catch ex As Exception
            MsgBox("获取project_document时出错!" & ex.Message, MsgBoxStyle.Critical, "提示")
        End Try
        If Not ds Is Nothing Then
            i = ds.Tables("TProjectDocument").Rows.Count
            If i = 1 Then
                dr = ds.Tables("TProjectDocument").Rows(0)
                With dr
                    .Item("phase") = strPhase
                    .Item("check_person") = strPerson
                    Try
                        .Item("check_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
            ElseIf i = 0 Then
                dr = ds.Tables("TProjectDocument").NewRow
                With dr
                    .Item("project_code") = strProjectCode
                    .Item("phase") = strPhase
                    .Item("item_type") = itemType
                    .Item("item_code") = itemCode
                    .Item("doc_name") = Me.Text
                    .Item("check_person") = strPerson
                    Try
                        .Item("check_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                    .Item("create_person") = strPerson
                    Try
                        .Item("create_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
                ds.Tables("TProjectDocument").Rows.Add(dr)
            End If
            strResult = gWs.UpdateProjectDocument(ds)
            If strResult = "1" Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
    '查看合同
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Me.Cursor = Cursors.WaitCursor
        Dim docClass As New frmDocumentClass(strCorporationName)
        docClass.setIsDocument(True)
        docClass.openFileList(strProjectCode, "43", "%", strDir) '43表示合同
        Me.Cursor = Cursors.Default
    End Sub
    'KeyPress()
    Private Sub frmContractAffirm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
    End Sub
    'Closing()
    Private Sub frmContractAffirm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If sender.GetType Is GetType(Form) Then
            If frmExit(sender, e) Then
                e.Cancel = True
            End If
        End If
    End Sub
    '
    '根据是否有文件,确定"查看合同"按钮的属性
    '
    Private Sub setButton()
        Dim dt As DataTable
        If Me.dsMaterial Is Nothing Then
            Me.btnView.Enabled = False
            Exit Sub
        End If
        Try
            dt = CType(Me.dgMaterial.DataSource, DataTable)
            If Not dt Is Nothing Then
                If dt.Rows.Count > 0 Then
                    If dt.Rows(Me.dgMaterial.CurrentRowIndex).Item("is_file") Is System.DBNull.Value Then
                        Me.btnView.Enabled = False
                    Else
                        If dt.Rows(Me.dgMaterial.CurrentRowIndex).Item("is_file") Then
                            Me.btnView.Enabled = True
                        Else
                            Me.btnView.Enabled = False
                        End If
                    End If
                Else
                    Me.btnView.Enabled = False
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'qxd add 2004-11-19
    '深圳版本新需求：添加上载合同文本原件的功能（PDF格式）
    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        Try
            Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
            Dim frm As New frmDocumentManageBusiness(Me.getProjectCode(), Me.getTaskID(), Me.getCorporationName(), "00", "000", UserName)
            frm.AllowTransparency = False
            frm.Text = "上载合同文本原件"
            frm.setMakeDocEnable(False)
            frm.ShowDialog()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
End Class
