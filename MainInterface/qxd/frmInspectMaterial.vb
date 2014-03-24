

Public Class frmInspectMaterial
    Inherits MainInterface.frmMaterial

    Private strProjectCode As String
    Private strCorporationName As String
    Private strWorkFlowID As String
    Private strTaskID As String
    Private strPerson As String
    Private strPhase As String

    Private strItemType As String = "42"  ' 表示二次材料
    Private strItemCode As String = "999" ' 表示其他资料
    Private strAffirmType As String = "44" '确认放款检查列表
    Private strAffirmCode As String = "001" '材料确认
    '
    Private dsMaterial As DataSet
    Private bmMaterial As BindingManagerBase
    Private isLoad As Boolean = False '供退出时判断,是否是刚load,没做任何其他按钮操作
    Private currentIndex As Integer '选中当前行

    Private isNewBtn As Boolean = False '保存时,判断是否是新增

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
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chbAffirm As System.Windows.Forms.CheckBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridBoolColumn3 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmInspectMaterial))
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chbAffirm = New System.Windows.Forms.CheckBox()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridBoolColumn3 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnModify = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(184, 128)
        Me.Label10.Visible = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(3, 45)
        Me.Panel1.Size = New System.Drawing.Size(770, 272)
        Me.Panel1.Visible = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.chbAffirm, Me.Label12})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 360)
        Me.GroupBox3.Size = New System.Drawing.Size(776, 112)
        Me.GroupBox3.Visible = True
        '
        'cmbContent
        '
        Me.cmbContent.ItemHeight = 12
        Me.cmbContent.Location = New System.Drawing.Point(528, 16)
        Me.cmbContent.TabIndex = 1
        Me.cmbContent.Visible = True
        '
        'chbCheck
        '
        Me.chbCheck.Location = New System.Drawing.Point(752, 16)
        Me.chbCheck.TabIndex = 2
        Me.chbCheck.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'Label5
        '
        Me.Label5.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label5.Visible = True
        '
        'txtMaterial
        '
        Me.txtMaterial.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtMaterial.MaxLength = 100
        Me.txtMaterial.Size = New System.Drawing.Size(344, 21)
        Me.txtMaterial.TabIndex = 0
        Me.txtMaterial.Visible = True
        '
        'Label11
        '
        Me.Label11.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label11.Visible = True
        '
        'chbImportant
        '
        Me.chbImportant.Location = New System.Drawing.Point(584, 16)
        Me.chbImportant.TabIndex = 1
        Me.chbImportant.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox2.Size = New System.Drawing.Size(776, 320)
        Me.GroupBox2.Visible = True
        '
        'txtName
        '
        Me.txtName.Size = New System.Drawing.Size(392, 21)
        Me.txtName.Visible = True
        '
        'txtPerson
        '
        Me.txtPerson.Location = New System.Drawing.Point(80, 128)
        Me.txtPerson.Size = New System.Drawing.Size(104, 21)
        Me.txtPerson.Visible = True
        '
        'chbFile
        '
        Me.chbFile.Location = New System.Drawing.Point(656, -48)
        Me.chbFile.Size = New System.Drawing.Size(24, 40)
        Me.chbFile.Visible = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(584, -48)
        Me.Label8.Size = New System.Drawing.Size(56, 39)
        Me.Label8.Visible = True
        '
        'dateCheck
        '
        Me.dateCheck.Location = New System.Drawing.Point(224, 128)
        Me.dateCheck.Value = New Date(2003, 4, 10, 10, 17, 37, 62)
        Me.dateCheck.Visible = True
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(72, 8)
        Me.txtCode.Visible = True
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Visible = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(472, 15)
        Me.Label4.Visible = True
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(696, 16)
        Me.Label7.Visible = True
        '
        'Label3
        '
        Me.Label3.Visible = True
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(528, 16)
        Me.Label6.Visible = True
        '
        'cmbType
        '
        Me.cmbType.Enabled = True
        Me.cmbType.ItemHeight = 12
        Me.cmbType.TabIndex = 0
        Me.cmbType.Visible = True
        '
        'txtRemark
        '
        Me.txtRemark.MaxLength = 50
        Me.txtRemark.Multiline = True
        Me.txtRemark.Size = New System.Drawing.Size(704, 56)
        Me.txtRemark.TabIndex = 3
        Me.txtRemark.Visible = True
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(24, 128)
        Me.Label9.Visible = True
        '
        'dgMaterial
        '
        Me.dgMaterial.AccessibleName = "DataGrid"
        Me.dgMaterial.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgMaterial.Size = New System.Drawing.Size(770, 272)
        Me.dgMaterial.TabIndex = 2
        Me.dgMaterial.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1, Me.DataGridTableStyle1, Me.DataGridTableStyle1, Me.DataGridTableStyle1})
        Me.dgMaterial.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(535, 480)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Visible = True
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(447, 480)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 24)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 13
        Me.btnNew.ImageList = Me.ImageListBasic
        Me.btnNew.Location = New System.Drawing.Point(183, 480)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 24)
        Me.btnNew.TabIndex = 4
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCopy
        '
        Me.btnCopy.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCopy.Location = New System.Drawing.Point(56, 480)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(112, 24)
        Me.btnCopy.TabIndex = 3
        Me.btnCopy.Text = "复制材料清单(&P)"
        Me.btnCopy.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(584, 56)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 23)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "材料完整"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chbAffirm
        '
        Me.chbAffirm.Location = New System.Drawing.Point(656, 56)
        Me.chbAffirm.Name = "chbAffirm"
        Me.chbAffirm.Size = New System.Drawing.Size(24, 24)
        Me.chbAffirm.TabIndex = 15
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
        Me.DataGridTextBoxColumn1.Width = 420
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
        Me.DataGridBoolColumn2.HeaderText = "关键"
        Me.DataGridBoolColumn2.MappingName = "is_important"
        Me.DataGridBoolColumn2.NullText = ""
        Me.DataGridBoolColumn2.NullValue = CType(resources.GetObject("DataGridBoolColumn2.NullValue"), System.DBNull)
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
        Me.DataGridBoolColumn3.TrueValue = True
        Me.DataGridBoolColumn3.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "备注"
        Me.DataGridTextBoxColumn2.MappingName = "remark"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.ReadOnly = True
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "确认人"
        Me.DataGridTextBoxColumn3.MappingName = "check_person"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 50
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "确认日期"
        Me.DataGridTextBoxColumn4.MappingName = "check_date"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'btnModify
        '
        Me.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModify.Image = CType(resources.GetObject("btnModify.Image"), System.Drawing.Bitmap)
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.ImageIndex = 14
        Me.btnModify.ImageList = Me.ImageListBasic
        Me.btnModify.Location = New System.Drawing.Point(359, 480)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(77, 24)
        Me.btnModify.TabIndex = 6
        Me.btnModify.Text = "修 改(&M)"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(271, 480)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 24)
        Me.btnDelete.TabIndex = 5
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmInspectMaterial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(794, 511)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.txtName, Me.Label1, Me.txtCode, Me.GroupBox3, Me.GroupBox2, Me.btnExit, Me.btnDelete, Me.btnModify, Me.btnCopy, Me.btnNew, Me.btnSave})
        Me.Name = "frmInspectMaterial"
        Me.Text = "查验材料"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Load()
    Private Sub frmInspectMaterial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isLoad = True
        Me.strProjectCode = Me.getProjectCode()
        Me.strCorporationName = Me.getCorporationName()
        Me.strWorkFlowID = Me.getWorkFlowID()
        Me.strTaskID = Me.getTaskID()
        Me.strPerson = Me.getUser()
        Me.strPhase = getPhase(strProjectCode)
        Me.txtCode.Text = strProjectCode
        Me.txtName.Text = strCorporationName
        '复制材料清单,已经存在就不复制;否则复制;复制失败则提示
        copyTemplate(strProjectCode, strItemType)
        '添加Type
        addCmbType(strItemType)
        setTextBox(False)
        Me.DataGridTableStyle1.AllowSorting = False
        If Not dsMaterial Is Nothing Then
            '根据是否有一个确认人是否为空，如果都为空，则默认打勾；否则不默认全部打勾
            'If Not setCheckByPerson(dsMaterial, "is_check") Then
            '    Me.setCheckIsTrue(dsMaterial, "is_check")
            'End If
            addStyle(Me.dsMaterial)
        End If
        setButton()
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
        column_1.Width = 400
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
        bColumnTextColumn = New DataGridColoredBoolColumn(d, 2)
        bColumnTextColumn.HeaderText = "关键"
        bColumnTextColumn.AllowNull = False
        bColumnTextColumn.ReadOnly = True
        bColumnTextColumn.MappingName = "is_important"
        tableStyle.GridColumnStyles.Add(bColumnTextColumn)

        Dim column_2 As New DataGridBoolColumn()
        column_2.ReadOnly = True
        column_2.Width = 0
        column_2.NullText = ""
        column_2.AllowNull = False
        column_2.HeaderText = "有文档"
        column_2.MappingName = "is_file"
        tableStyle.GridColumnStyles.Add(column_2)

        Dim column_3 As New DataGridTextBoxColumn()
        column_3.ReadOnly = True
        column_3.Width = 150
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
    '
    ' 显示内容
    '
    Private Sub cmbContent_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbContent.SelectedValueChanged
        selectCombox()
    End Sub
    '
    '类型改变
    '
    Private Sub cmbType_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbType.SelectedValueChanged
        If Me.cmbType.Text.Trim = "企业材料" Then
            strItemType = "41"
        Else
            strItemType = "42"
        End If
        '保存确认项
        'saveAffirm()
        selectCombox()
    End Sub
    '设置所有按钮
    Private Sub setAllButton(ByVal isEnabled As Boolean)
        Me.btnNew.Enabled = isEnabled
        Me.btnDelete.Enabled = isEnabled
        Me.btnModify.Enabled = isEnabled
        Me.btnSave.Enabled = isEnabled
    End Sub
    '
    '选择ComBox做的事件
    '
    Private Sub selectCombox()
        Me.Cursor = Cursors.WaitCursor
        Me.dsMaterial = setDgDataSource(strProjectCode, False)
        If Not dsMaterial Is Nothing Then
            setAllButton(True)
            setButton()
            Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
        Else
            Try
                setAllButton(False)
            Catch
            End Try
        End If
        'If Not btnNew Is Nothing Then
        '    If cmbType.Text = "反担保材料" Then
        '        If cmbContent.Text = "全部资料" Then
        '            Me.btnNew.Enabled = True
        '        Else
        '            Me.btnNew.Enabled = False
        '        End If

        '        Me.btnDelete.Enabled = True
        '        Me.btnModify.Enabled = True
        '        Me.btnSave.Enabled = True
        '        Me.btnCopy.Enabled = True
        '        Me.DataGridBoolColumn1.ReadOnly = False
        '        Me.DataGridBoolColumn2.ReadOnly = False
        '        setButton()
        '    Else
        '        btnNew.Text = "新 增(&N)"
        '        Me.btnNew.Enabled = False
        '        Me.btnDelete.Enabled = False
        '        Me.btnModify.Enabled = False
        '        Me.btnSave.Enabled = False
        '        Me.btnCopy.Enabled = False
        '        Me.DataGridBoolColumn1.ReadOnly = True
        '        Me.DataGridBoolColumn2.ReadOnly = True
        '    End If
        'End If
        Me.Cursor = Cursors.Default
    End Sub
    '
    '退出
    '
    Private Overloads Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        frmExit(sender, e)
    End Sub
    '推出处理
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
                Call btnSave_Click(sender, e)
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
    '设置TextBox的Enabled属性
    Private Sub setTextBoxEnable(ByVal isEnabled As Boolean)
        Me.txtMaterial.Enabled = isEnabled
        Me.txtRemark.Enabled = isEnabled
        Me.chbCheck.Enabled = isEnabled
    End Sub
    '
    '新增
    '
    Private Sub btnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNew.Click
        isLoad = False
        If btnNew.Text = "新 增(&N)" Then
            isNewBtn = True
            setTextBoxEnable(True)
            Me.txtMaterial.Focus()
            delBinding()
            addBinding()
            addOtherMaterial()
            btnNew.Text = "取 消(&C)"
            Me.dgMaterial.Enabled = False
            Me.btnCopy.Enabled = False
            Me.btnDelete.Enabled = False
            Me.btnModify.Enabled = False
            Me.chbAffirm.Enabled = False
        ElseIf btnNew.Text = "取 消(&C)" Then
            isNewBtn = False
            setTextBoxEnable(False)
            delBinding()
            btnNew.Text = "新 增(&N)"
            Me.dgMaterial.Enabled = True
            Me.btnCopy.Enabled = True
            Me.btnDelete.Enabled = True
            Me.btnModify.Enabled = True
            Me.chbAffirm.Enabled = True
            Try
                Me.dsMaterial = setDgDataSource(strProjectCode, False)
            Catch ex As Exception
            Finally
            End Try
            If Not dsMaterial Is Nothing Then
                Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
                Me.dsMaterial.AcceptChanges()
            End If
            setButton()
        End If
    End Sub
    '
    '新增一条记录
    '
    Private Sub addOtherMaterial()
        Dim dr As DataRow
        If Not Me.dsMaterial Is Nothing Then
            dr = Me.dsMaterial.Tables("TProjectDocument").NewRow
            With dr
                .Item("project_code") = strProjectCode
                .Item("phase") = strPhase
                .Item("item_type") = strItemType
                .Item("item_code") = strItemCode
                .Item("is_important") = False
                .Item("is_check") = Me.chbCheck.Checked
                .Item("is_file") = False
                .Item("create_person") = strPerson
                Try
                    .Item("create_date") = gWs.GetSysTime()
                Catch ex As Exception
                    ExceptionHandler.ShowMessageBox(ex)
                End Try
            End With
            Me.dsMaterial.Tables("TProjectDocument").Rows.Add(dr)
            If Not dsMaterial Is Nothing Then
                Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
            End If
            Me.dgMaterial.CurrentRowIndex = Me.bmMaterial.Count - 1
        End If
    End Sub
    '
    '删除新增的记录
    '
    Private Sub delOtherMaterial()
        Dim i As Integer
        If Not Me.dsMaterial Is Nothing Then
            i = Me.dsMaterial.Tables("TProjectDocument").Rows.Count
            If i > 0 Then
                'If 1 = MsgBox("确认取消新增的记录吗?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "提示") Then
                If 1 = SWDialogBox.MessageBox.Show("?1000", "取消新增的记录") Then
                    Me.dsMaterial.Tables("TProjectDocument").Rows(i - 1).Delete()
                    If Not dsMaterial Is Nothing Then
                        Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
                    End If
                    Me.dgMaterial.CurrentRowIndex = Me.bmMaterial.Count - 1
                End If
            End If
        End If
    End Sub
    '
    '添加绑定
    '
    Private Sub addBinding()
        If Not dsMaterial Is Nothing Then
            Me.txtMaterial.DataBindings.Add("Text", dsMaterial.Tables("TProjectDocument"), "doc_name")
            Me.txtRemark.DataBindings.Add("Text", dsMaterial.Tables("TProjectDocument"), "remark")
            Me.chbCheck.DataBindings.Add("Checked", dsMaterial.Tables("TProjectDocument"), "is_check")
        End If
    End Sub
    '
    '删除绑定
    '
    Private Sub delBinding()
        Me.txtMaterial.DataBindings.Clear()
        Me.txtRemark.DataBindings.Clear()
        Me.chbCheck.DataBindings.Clear()
    End Sub
    '
    '保存
    '
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        isLoad = False
        Try
            If Not dsMaterial Is Nothing Then
                Dim dr As DataRow
                Dim i As Integer
                Dim strResult As String
                Me.dgMaterial.CurrentRowIndex = currentIndex
                i = Me.dsMaterial.Tables("TProjectDocument").Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = Me.dsMaterial.Tables("TProjectDocument").Rows(i)
                        With dr
                            .Item("phase") = strPhase
                            .Item("create_person") = strPerson
                            Try
                                .Item("create_date") = gWs.GetSysTime()
                            Catch ex As Exception
                                ExceptionHandler.ShowMessageBox(ex)
                            End Try
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
                End If
                setTextBoxEnable(False)
                delBinding()
                ''''如果文件名为空,则不保存!!! 
                If isNewBtn Then
                    Try
                        If Not Me.dsMaterial.GetChanges Is Nothing Then
                            Dim j As Integer
                            j = Me.dsMaterial.Tables("TProjectDocument").Rows.Count
                            If j > 1 Then
                                If Not Me.dsMaterial.GetChanges.Tables("TProjectDocument").Rows(j - 1).Item("doc_name") Is System.DBNull.Value Then
                                    If Me.dsMaterial.GetChanges.Tables("TProjectDocument").Rows(j - 1).Item("doc_name") = "" Then
                                        Me.dsMaterial.RejectChanges()
                                    End If
                                Else
                                    Me.dsMaterial.RejectChanges()
                                End If
                            End If
                        End If
                    Catch ex As Exception
                        'MsgBox(ex.Message)
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End If
                strResult = gWs.UpdateProjectDocument(Me.dsMaterial)
                If strResult = "1" Then
                    btnNew.Text = "新 增(&N)"
                    Me.btnModify.Text = "修 改(&M)"
                    Me.dgMaterial.Enabled = True
                    Me.btnCopy.Enabled = True
                    Me.btnNew.Enabled = True
                    Me.btnDelete.Enabled = True
                    Me.btnModify.Enabled = True
                    Me.chbAffirm.Enabled = True
                    Try
                        Me.dsMaterial = setDgDataSource(strProjectCode, False)
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    Finally
                    End Try
                    If Not dsMaterial Is Nothing Then
                        Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
                        If Not isNewBtn Then
                            Me.dsMaterial.AcceptChanges()
                        End If
                    End If
                    'MsgBox("保存成功!", MsgBoxStyle.Information, "提示")
                    SWDialogBox.MessageBox.Show("$SaveSucceed")
                    isNewBtn = False
                Else
                    'MsgBox("保存失败!" & strResult, MsgBoxStyle.Critical, "提示")
                    SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            setButton()
        End Try
    End Sub
    '在切换类型时，保存确认项
    Private Sub saveAffirm()
        If Not dsMaterial Is Nothing Then
            Dim dr As DataRow
            Dim i As Integer
            Dim strResult As String
            i = Me.dsMaterial.Tables("TProjectDocument").Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    dr = Me.dsMaterial.Tables("TProjectDocument").Rows(i)
                    With dr
                        If Not .Item("is_check") Is System.DBNull.Value Then
                            '三种状态:true,false,DBNull
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
                gWs.UpdateProjectDocument(Me.dsMaterial)
            End If
        End If
    End Sub
    '
    '从item中复制模板到project_document
    '
    Private Sub btnCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopy.Click
        isLoad = False
        copyTemplate(strProjectCode, strItemType)
    End Sub
    '
    '复制模板
    '
    Private Sub copyTemplate(ByVal projectCode, ByVal itemType)

        Dim dsItem, dsDocument, dsDocTemp As DataSet
        Dim i As Integer
        Dim strSql, str, strTemp As String
        strSql = "{project_code='" & projectCode & "' and (item_type='" & itemType & "' or item_type='41') and phase='" & strPhase & "'}"
        Try
            dsDocument = gWs.GetProjectDocumentByCondition(strSql)

            strTemp = "{project_code='" & projectCode & "' and (item_type='" & itemType & "' or item_type='41')}"
            'dsDocTemp = gWs.GetProjectDocumentByCondition("null")
            dsDocTemp = gWs.GetProjectDocumentByCondition(strTemp)

            'modify by wzh 根据所申请的业务品种获取相应的项目材料 2006-09-04
            'str = "{(item_type='" & itemType & "'or item_type='41') and not item_code='999'}"
            'dsItem = gWs.GetItemEx(str)
            dsItem = gWs.GetMaterial("{service_type='" & GetServiceType(projectCode) & "' and not item_code='999'}")
            i = dsDocument.Tables("TProjectDocument").Rows.Count
            If i > 0 Then
                'If MsgBoxResult.Yes = MsgBox("模板文档已经存在,是否清空重新复制?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "提示") Then
                'If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("", "") Then
                '**********************************************
                ''''qxd closed 2003-9-29
                'delDataset(gWs, dsDocument)
                'copyDataset(gWs, dsItem, dsDocTemp, strProjectCode)
                ''''qxd end 
                '**********************************************
                'End If
            Else
                copyDataset(gWs, dsItem, dsDocTemp, strProjectCode)
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '删除DataSet中的记录
    '
    Private Sub delDataset(ByVal gWs As htfServer.Service1, ByVal ds As DataSet)
        Dim i As Integer
        i = ds.Tables(0).Rows.Count
        If i > 0 Then
            For i = 0 To i - 1
                ds.Tables(0).Rows(i).Delete()
            Next
            gWs.UpdateProjectDocument(ds.GetChanges())
        End If
    End Sub
    '
    '复制记录
    '
    Private Function copyDataset(ByVal gWs As htfServer.Service1, ByVal dsItem As DataSet, ByVal dsDocTemp As DataSet, ByVal projectCode As String) As DataSet
        Dim i As Integer
        Dim strResult, strSql As String
        Dim drItem, drDocTemp As DataRow
        Dim strItemTypeTemp, strItemCodeTemp As String '2003-12-24 add
        Dim drTemp() As DataRow

        i = dsItem.Tables(0).Rows.Count
        If i > 0 Then
            For i = 0 To i - 1
                drItem = dsItem.Tables(0).Rows(i)
                ' qxd add 2003-12-24
                strItemTypeTemp = drItem.Item("item_type")
                strItemCodeTemp = drItem.Item("item_code")
                strSql = "item_type='" & strItemTypeTemp & "' and item_code='" & strItemCodeTemp & "'"
                'qxd end 
                drTemp = dsDocTemp.Tables("TProjectDocument").Select(strSql)
                If drTemp.Length > 0 Then
                    drDocTemp = drTemp(0)
                    With drItem
                        'drDocTemp.Item("project_code") = projectCode
                        drDocTemp.Item("phase") = strPhase
                        'drDocTemp.Item("item_type") = .Item("item_type")
                        'drDocTemp.Item("item_code") = .Item("item_code")
                        'drDocTemp.Item("doc_name") = .Item("item_name")
                        If Not .Item("additional_remark") Is System.DBNull.Value Then
                            If .Item("additional_remark") = "2" Then
                                drDocTemp.Item("is_important") = True
                            End If
                        End If
                        'drDocTemp.Item("create_person") = strPerson
                        'Try
                        '    drDocTemp.Item("create_date") = gWs.GetSysTime()
                        'Catch ex As Exception
                        '    ExceptionHandler.ShowMessageBox(ex)
                        'End Try
                    End With
                Else
                    drDocTemp = dsDocTemp.Tables("TProjectDocument").NewRow

                    With drItem
                        drDocTemp.Item("project_code") = projectCode
                        drDocTemp.Item("phase") = strPhase
                        drDocTemp.Item("item_type") = .Item("item_type")
                        drDocTemp.Item("item_code") = .Item("item_code")
                        drDocTemp.Item("doc_name") = .Item("item_name")
                        If Not .Item("additional_remark") Is System.DBNull.Value Then
                            If .Item("additional_remark") = "2" Then
                                drDocTemp.Item("is_important") = True
                            End If
                        End If
                        drDocTemp.Item("create_person") = strPerson
                        Try
                            drDocTemp.Item("create_date") = gWs.GetSysTime()
                        Catch ex As Exception
                            ExceptionHandler.ShowMessageBox(ex)
                        End Try
                    End With
                    dsDocTemp.Tables("TProjectDocument").Rows.Add(drDocTemp)
                End If
            Next
            strResult = gWs.UpdateProjectDocument(dsDocTemp.GetChanges)
            If strResult = "1" Then
                Me.dsMaterial = setDgDataSource(strProjectCode, False)
                If Not dsMaterial Is Nothing Then
                    Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
                    addStyle(Me.dsMaterial)
                End If
                'MsgBox("复制模板成功!", MsgBoxStyle.Information, "提示")
                Return dsDocTemp
            Else
                'MsgBox("复制模板失败!", MsgBoxStyle.Critical, "提示")
                SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                Return Nothing
            End If
        Else
            'MsgBox("没有模板,复制未完成!", MsgBoxStyle.Exclamation, "提示")
            'SWDialogBox.MessageBox.Show("$2002", "模板")
            'Return Nothing
            'modify by wzh 20060904
            Me.dsMaterial = setDgDataSource(strProjectCode, False)
            If Not dsMaterial Is Nothing Then
                Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
                addStyle(Me.dsMaterial)
            End If
            'MsgBox("复制模板成功!", MsgBoxStyle.Information, "提示")
            Return dsDocTemp
        End If
    End Function
    '
    '确认材料
    '
    Private Sub chbAffirm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbAffirm.CheckedChanged
        If chbAffirm.Checked Then
            Dim isAffirm As Boolean
            isAffirm = addAffirmRecord(strProjectCode, strAffirmType, strAffirmCode)
            If isAffirm Then
                'MsgBox("材料完整确认成功!", MsgBoxStyle.Information, "提示")
                SWDialogBox.MessageBox.Show("$OperateSucceed")
            Else
                'MsgBox("材料完整确认失败!", MsgBoxStyle.Critical, "提示")
                SWDialogBox.MessageBox.Show("*999", "", "", "")
            End If
        End If
    End Sub
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
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not ds Is Nothing Then
            i = ds.Tables("TProjectDocument").Rows.Count
            If i = 1 Then
                dr = ds.Tables("TProjectDocument").Rows(0)
                With dr
                    .Item("phase") = strPhase
                    .Item("affirm_person") = strPerson
                    Try
                        .Item("affirm_date") = gWs.GetSysTime()
                    Catch ex As Exception
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                End With
            ElseIf i = 0 Then
                dr = ds.Tables("TProjectDocument").NewRow
                With dr
                    .Item("project_code") = strProjectCode
                    .Item("phase") = strPhase
                    .Item("item_type") = strAffirmType
                    .Item("item_code") = strAffirmCode
                    .Item("affirm_person") = strPerson
                    Try
                        .Item("affirm_date") = gWs.GetSysTime()
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
            strResult = gWs.UpdateProjectDocument(ds.GetChanges())
            If strResult = "1" Then
                Return True
            Else
                Return False
            End If
        End If
    End Function
    'KeyPress()
    Private Sub frmInspectMaterial_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
    End Sub
    'Closing()
    Private Sub frmInspectMaterial_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If sender.GetType Is GetType(Form) Then
            If frmExit(sender, e) Then
                e.Cancel = True
            End If
        End If
    End Sub
    '点击datagrid，设置text内容
    Private Sub setTextContent()
        Static lastRow As Integer = -1
        Me.dgMaterial.Select(Me.dgMaterial.CurrentCell.RowNumber)
        If Me.dgMaterial.CurrentRowIndex <> lastRow Then
            currentIndex = Me.dgMaterial.CurrentRowIndex
            Try
                If Not Me.dsMaterial.Tables("TProjectDocument").Rows(Me.dgMaterial.CurrentCell.RowNumber).Item("is_check") Is System.DBNull.Value Then
                    If Not Me.dsMaterial.Tables("TProjectDocument").Rows(Me.dgMaterial.CurrentCell.RowNumber).Item("is_check") Then
                        isLoad = False
                    End If
                End If
            Catch
            Finally
                Dim index As Integer
                Try
                    index = Me.dgMaterial.CurrentRowIndex
                    Me.setMaterialInfo(dsMaterial, index)
                Catch ex As Exception
                End Try
            End Try
            setButton()
        End If
        lastRow = Me.dgMaterial.CurrentRowIndex
    End Sub
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
            setTextContent()
        End If
    End Sub
    '修改
    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        isLoad = False
        If Me.btnModify.Text = "修 改(&M)" Then
            Dim i As Integer
            i = Me.dgMaterial.CurrentRowIndex
            currentIndex = i
            If i >= 0 Then
                Me.dgMaterial.Select(i)
                setTextBoxEnable(True)
                Me.delBinding()
                Me.addBinding()
                If Not Me.dsMaterial Is Nothing Then
                    Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
                End If
                Me.dgMaterial.CurrentRowIndex = i
            End If
            Me.dgMaterial.Enabled = False
            Me.btnNew.Enabled = False
            Me.btnDelete.Enabled = False
            Me.btnCopy.Enabled = False
            Me.chbAffirm.Enabled = False
            Me.btnModify.Text = "取 消(&C)"
        Else
            Me.dgMaterial.Enabled = True
            Me.btnNew.Enabled = True
            Me.btnCopy.Enabled = True
            Me.btnDelete.Enabled = True
            Me.chbAffirm.Enabled = True
            Me.btnModify.Text = "修 改(&M)"
            setTextBoxEnable(False)
            Me.delBinding()
            Try
                Me.dsMaterial = setDgDataSource(strProjectCode, False)
            Catch ex As Exception
            Finally
            End Try
            If Not dsMaterial Is Nothing Then
                Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
                Me.dsMaterial.AcceptChanges()
            End If
            setButton()
        End If
    End Sub
    '删除
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        isLoad = False
        If Not Me.dsMaterial Is Nothing Then
            Dim currentIndex As Integer
            Dim strResult As String
            Try
                currentIndex = Me.dgMaterial.CurrentRowIndex
                'If MsgBoxResult.OK = MsgBox("确定删除选中的记录吗?", MsgBoxStyle.OKCancel + MsgBoxStyle.Question, "提示") Then
                If MsgBoxResult.Yes = SWDialogBox.MessageBox.Show("?1004", "") Then
                    Me.dsMaterial.Tables("TProjectDocument").Rows(currentIndex).Delete()
                    strResult = gWs.UpdateProjectDocument(Me.dsMaterial)
                    Me.dsMaterial = setDgDataSource(strProjectCode, False)
                    If Not Me.dsMaterial Is Nothing Then
                        Me.bmMaterial = Me.BindingContext(Me.dsMaterial, "TProjectDocument")
                        Me.dsMaterial.AcceptChanges()
                    End If
                    If strResult = "1" Then
                    Else
                        'MsgBox("删除失败！" & strResult, MsgBoxStyle.Exclamation, "提示")
                        SWDialogBox.MessageBox.Show("*999", "", strResult, "")
                    End If
                End If
            Catch ex As Exception
                'MsgBox(ex.Message)
                ExceptionHandler.ShowMessageBox(ex)
            End Try
        End If
        setButton()
    End Sub
    '根据是否关键,设置delete,modify按钮的可用性.
    Private Sub setButton()
        Dim dt As DataTable
        Try
            If Not Me.dgMaterial.DataSource Is Nothing Then
                dt = CType(Me.dgMaterial.DataSource, DataTable)
                If Not dt Is Nothing Then
                    If dt.Rows.Count > 0 Then
                        If Not dt.Rows(Me.dgMaterial.CurrentCell.RowNumber).Item("is_important") Is System.DBNull.Value Then
                            If Not dt.Rows(Me.dgMaterial.CurrentCell.RowNumber).Item("is_important") Then
                                Me.btnDelete.Enabled = True
                            Else
                                Me.btnDelete.Enabled = False
                            End If
                        Else
                            Me.btnDelete.Enabled = True
                        End If
                    Else
                        Me.btnDelete.Enabled = False
                        Me.btnModify.Enabled = False
                        Me.btnSave.Enabled = False
                    End If
                Else
                    Me.btnDelete.Enabled = False
                    Me.btnModify.Enabled = False
                    Me.btnSave.Enabled = False
                End If
            Else
                If Not Me.btnDelete Is Nothing Then
                    Me.btnDelete.Enabled = False
                End If
                If Not Me.btnModify Is Nothing Then
                    Me.btnModify.Enabled = False
                End If
                If Not Me.btnSave Is Nothing Then
                    Me.btnSave.Enabled = False
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

End Class
