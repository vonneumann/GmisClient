

Public Class frmOppGuaranteeAffirm
    Inherits MainInterface.frmOppGuarantee

    Private strProjectCode As String = "P001"
    Private strCorporationName As String
    Private strWorkFlowID As String
    Private strTaskID As String
    Private strPerson As String
    Private strPhase As String

    Private strDir As String = "\Document\Image\" '图片保存的目录
    Private dsOppGuaranteeView As DataSet '显示
    Private dsDetailView As DataSet '显示
    Private strStatus As String = "抵押质押" '反担保物状态

    Private bIsModify As Boolean = False
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn

    Private dsProjectCorporation As DataSet '项目企业表,获取"企业联系人"和"联系电话";对应的字段:corp_contact_person,corp_contact_phone

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
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnView As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnModify As System.Windows.Forms.Button
    Friend WithEvents corp_contact_phone As System.Windows.Forms.TextBox
    Friend WithEvents corp_contact_person As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOppGuaranteeAffirm))
        Me.btnCommit = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnView = New System.Windows.Forms.Button
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnModify = New System.Windows.Forms.Button
        Me.corp_contact_phone = New System.Windows.Forms.TextBox
        Me.corp_contact_person = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Size = New System.Drawing.Size(416, 264)
        Me.GroupBox2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Location = New System.Drawing.Point(432, 40)
        Me.GroupBox3.Size = New System.Drawing.Size(312, 264)
        Me.GroupBox3.TabIndex = 2
        '
        'cmbType
        '
        Me.cmbType.DropDownWidth = 152
        Me.cmbType.ItemHeight = 12
        Me.cmbType.Size = New System.Drawing.Size(152, 20)
        Me.cmbType.TabIndex = 0
        '
        'txtOriginal
        '
        Me.txtOriginal.TabIndex = 5
        '
        'txtEvaluate
        '
        Me.txtEvaluate.Location = New System.Drawing.Point(252, 80)
        Me.txtEvaluate.TabIndex = 6
        '
        'cmbMeasure
        '
        Me.cmbMeasure.DropDownWidth = 104
        Me.cmbMeasure.ItemHeight = 12
        Me.cmbMeasure.Location = New System.Drawing.Point(312, 25)
        Me.cmbMeasure.Size = New System.Drawing.Size(104, 20)
        Me.cmbMeasure.TabIndex = 1
        '
        'dateEvaluate
        '
        Me.dateEvaluate.Location = New System.Drawing.Point(512, 53)
        Me.dateEvaluate.Size = New System.Drawing.Size(216, 21)
        Me.dateEvaluate.TabIndex = 4
        Me.dateEvaluate.Value = New Date(2003, 4, 3, 8, 56, 24, 984)
        '
        'txtRemark
        '
        Me.txtRemark.Size = New System.Drawing.Size(344, 21)
        Me.txtRemark.TabIndex = 3
        '
        'txtGuarantee
        '
        Me.txtGuarantee.Location = New System.Drawing.Point(621, 83)
        Me.txtGuarantee.Size = New System.Drawing.Size(107, 21)
        Me.txtGuarantee.TabIndex = 7
        '
        'dgOppGuarantee
        '
        Me.dgOppGuarantee.AccessibleName = "DataGrid"
        Me.dgOppGuarantee.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgOppGuarantee.Size = New System.Drawing.Size(410, 244)
        Me.dgOppGuarantee.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'dgDetail
        '
        Me.dgDetail.AccessibleName = "DataGrid"
        Me.dgDetail.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgDetail.ReadOnly = True
        Me.dgDetail.Size = New System.Drawing.Size(306, 244)
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 344)
        Me.GroupBox4.Size = New System.Drawing.Size(736, 112)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.Controls.SetChildIndex(Me.Label7, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txtGuarantee, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label5, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label13, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label8, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txtEvaluate, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txtEvaluateNet, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label3, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label4, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.cmbType, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txtOriginal, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label6, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.cmbMeasure, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label9, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label10, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.dateEvaluate, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txtRemark, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.Label11, 0)
        Me.GroupBox4.Controls.SetChildIndex(Me.txtContract, 0)
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(171, 84)
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(232, 24)
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(550, 86)
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(448, 52)
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(448, 24)
        '
        'txtContract
        '
        Me.txtContract.Location = New System.Drawing.Point(512, 25)
        Me.txtContract.Size = New System.Drawing.Size(216, 21)
        Me.txtContract.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(325, 8)
        Me.txtName.Size = New System.Drawing.Size(417, 21)
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.Location = New System.Drawing.Point(519, 464)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 7
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListBasic.Images.SetKeyName(0, "")
        Me.ImageListBasic.Images.SetKeyName(1, "")
        Me.ImageListBasic.Images.SetKeyName(2, "")
        Me.ImageListBasic.Images.SetKeyName(3, "")
        Me.ImageListBasic.Images.SetKeyName(4, "")
        Me.ImageListBasic.Images.SetKeyName(5, "")
        Me.ImageListBasic.Images.SetKeyName(6, "")
        Me.ImageListBasic.Images.SetKeyName(7, "")
        Me.ImageListBasic.Images.SetKeyName(8, "")
        Me.ImageListBasic.Images.SetKeyName(9, "")
        Me.ImageListBasic.Images.SetKeyName(10, "")
        Me.ImageListBasic.Images.SetKeyName(11, "")
        Me.ImageListBasic.Images.SetKeyName(12, "")
        Me.ImageListBasic.Images.SetKeyName(13, "")
        Me.ImageListBasic.Images.SetKeyName(14, "")
        Me.ImageListBasic.Images.SetKeyName(15, "")
        Me.ImageListBasic.Images.SetKeyName(16, "")
        Me.ImageListBasic.Images.SetKeyName(17, "")
        Me.ImageListBasic.Images.SetKeyName(18, "")
        Me.ImageListBasic.Images.SetKeyName(19, "")
        Me.ImageListBasic.Images.SetKeyName(20, "")
        Me.ImageListBasic.Images.SetKeyName(21, "")
        Me.ImageListBasic.Images.SetKeyName(22, "")
        Me.ImageListBasic.Images.SetKeyName(23, "")
        Me.ImageListBasic.Images.SetKeyName(24, "")
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(433, 464)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 6
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(347, 464)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 24)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnView
        '
        Me.btnView.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnView.ImageIndex = 17
        Me.btnView.ImageList = Me.ImageListBasic
        Me.btnView.Location = New System.Drawing.Point(159, 464)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(93, 24)
        Me.btnView.TabIndex = 4
        Me.btnView.Text = "浏览图片(&V)"
        Me.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AllowSorting = False
        Me.DataGridTableStyle2.DataGrid = Me.dgOppGuarantee
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn6, Me.DataGridBoolColumn1, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "opposite_guarantee"
        Me.DataGridTableStyle2.RowHeadersVisible = False
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "类型"
        Me.DataGridTextBoxColumn3.MappingName = "type_name"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.ReadOnly = True
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "原值"
        Me.DataGridTextBoxColumn4.MappingName = "original_value"
        Me.DataGridTextBoxColumn4.NullText = "0.00"
        Me.DataGridTextBoxColumn4.ReadOnly = True
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "评估总值"
        Me.DataGridTextBoxColumn5.MappingName = "evaluate_value"
        Me.DataGridTextBoxColumn5.NullText = "0.00"
        Me.DataGridTextBoxColumn5.ReadOnly = True
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "担保额"
        Me.DataGridTextBoxColumn6.MappingName = "guarantee_value"
        Me.DataGridTextBoxColumn6.NullText = "0.00"
        Me.DataGridTextBoxColumn6.ReadOnly = True
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridBoolColumn1
        '
        Me.DataGridBoolColumn1.AllowNull = False
        Me.DataGridBoolColumn1.HeaderText = "解除"
        Me.DataGridBoolColumn1.MappingName = "affirm_release"
        Me.DataGridBoolColumn1.NullText = ""
        Me.DataGridBoolColumn1.Width = 40
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "备注"
        Me.DataGridTextBoxColumn7.MappingName = "remark"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.ReadOnly = True
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(422, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 23)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "元"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(423, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 23)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "元"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnModify
        '
        Me.btnModify.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnModify.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModify.ImageIndex = 14
        Me.btnModify.ImageList = Me.ImageListBasic
        Me.btnModify.Location = New System.Drawing.Point(261, 464)
        Me.btnModify.Name = "btnModify"
        Me.btnModify.Size = New System.Drawing.Size(77, 24)
        Me.btnModify.TabIndex = 9
        Me.btnModify.Text = "修 改(&M)"
        Me.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'corp_contact_phone
        '
        Me.corp_contact_phone.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.corp_contact_phone.Location = New System.Drawing.Point(296, 317)
        Me.corp_contact_phone.Name = "corp_contact_phone"
        Me.corp_contact_phone.ReadOnly = True
        Me.corp_contact_phone.Size = New System.Drawing.Size(128, 21)
        Me.corp_contact_phone.TabIndex = 22
        '
        'corp_contact_person
        '
        Me.corp_contact_person.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.corp_contact_person.Location = New System.Drawing.Point(80, 317)
        Me.corp_contact_person.Name = "corp_contact_person"
        Me.corp_contact_person.ReadOnly = True
        Me.corp_contact_person.Size = New System.Drawing.Size(128, 21)
        Me.corp_contact_person.TabIndex = 21
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(224, 320)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 12)
        Me.Label12.TabIndex = 20
        Me.Label12.Text = "联系电话"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 320)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 12)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "企业联系人"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "评估净值(元)"
        Me.DataGridTextBoxColumn10.MappingName = "evaluate_net_value"
        Me.DataGridTextBoxColumn10.NullText = "0.00"
        Me.DataGridTextBoxColumn10.ReadOnly = True
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'frmOppGuaranteeAffirm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(754, 495)
        Me.Controls.Add(Me.corp_contact_phone)
        Me.Controls.Add(Me.corp_contact_person)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnModify)
        Me.Controls.Add(Me.btnView)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCommit)
        Me.Name = "frmOppGuaranteeAffirm"
        Me.Text = "确认解除反担保物"
        Me.Controls.SetChildIndex(Me.btnCommit, 0)
        Me.Controls.SetChildIndex(Me.btnSave, 0)
        Me.Controls.SetChildIndex(Me.btnView, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.txtName, 0)
        Me.Controls.SetChildIndex(Me.btnModify, 0)
        Me.Controls.SetChildIndex(Me.Label14, 0)
        Me.Controls.SetChildIndex(Me.Label12, 0)
        Me.Controls.SetChildIndex(Me.corp_contact_person, 0)
        Me.Controls.SetChildIndex(Me.corp_contact_phone, 0)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    'Load()
    Private Sub frmOppGuaranteeAffirm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.strProjectCode = Me.getProjectCode()
        Me.strCorporationName = Me.getCorporationName()
        Me.strWorkFlowID = Me.getWorkFlowID()
        Me.strTaskID = Me.getTaskID()
        Me.strPerson = Me.getUser
        Me.strPhase = Me.getPhase(Me.strProjectCode)
        'Me.strPhase = "代偿"

        Try
            Me.dateEvaluate.Value = gWs.GetSysTime()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        Me.txtCode.Text = Me.strProjectCode
        Me.txtName.Text = Me.strCorporationName

        getProjectCorporation(Me.strProjectCode, "评审")

        'dsOppGuaranteeView = Me.getOppGuaranteeRecords(strProjectCode, "3")
        dsOppGuaranteeView = Me.getOppGuaranteeRecords(strProjectCode, "0")
        If Not dsOppGuaranteeView Is Nothing Then
            Me.dgOppGuarantee.DataSource = dsOppGuaranteeView.Tables("opposite_guarantee")
            addStyle_1(Me.dsOppGuaranteeView)
            Me.dsOppGuaranteeView.AcceptChanges()
            Me.setDgAttribute(Me.dgOppGuarantee)
        End If
        setTextBox(False)
        If Not dsOppGuaranteeView Is Nothing Then
            Me.dsOppGuaranteeView.AcceptChanges()
        End If
        If Not dsDetailView Is Nothing Then
            Me.dsDetailView.AcceptChanges()
        End If
        getDetail()
        setButton()
    End Sub
    '添加datagrid的style
    Private Sub addStyle_1(ByVal ds As DataSet)
        Dim tableStyle As DataGridTableStyle = New DataGridTableStyle()
        tableStyle.MappingName = "opposite_guarantee"
        tableStyle.AllowSorting = False
        tableStyle.RowHeadersVisible = True

        Dim numCols As Integer = ds.Tables("opposite_guarantee").Columns.Count
        Dim dgc As New DataGridColoredBoolColumn()
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf dgc.MyGetColorRowCol)

        Dim column_1 As New DataGridTextBoxColumn()
        column_1.Width = 70
        column_1.ReadOnly = True
        column_1.NullText = ""
        column_1.HeaderText = "类型"
        column_1.MappingName = "type_name"
        tableStyle.GridColumnStyles.Add(column_1)

        If Me.strPhase = "代偿" Then
            Dim b1ColumnTextColumn As DataGridColoredBoolColumn
            b1ColumnTextColumn = New DataGridColoredBoolColumn(d, 0)
            b1ColumnTextColumn.HeaderText = "典当"
            b1ColumnTextColumn.AllowNull = False
            b1ColumnTextColumn.MappingName = "hock_release"
            tableStyle.GridColumnStyles.Add(b1ColumnTextColumn)

            Dim b2ColumnTextColumn As DataGridColoredBoolColumn
            b2ColumnTextColumn = New DataGridColoredBoolColumn(d, 0)
            b2ColumnTextColumn.HeaderText = "变卖"
            b2ColumnTextColumn.AllowNull = False
            b2ColumnTextColumn.MappingName = "sell_release"
            tableStyle.GridColumnStyles.Add(b2ColumnTextColumn)
        Else
            Dim bColumnTextColumn As DataGridColoredBoolColumn
            bColumnTextColumn = New DataGridColoredBoolColumn(d, 0)
            bColumnTextColumn.HeaderText = "解除"
            bColumnTextColumn.AllowNull = False
            bColumnTextColumn.MappingName = "affirm_release"
            tableStyle.GridColumnStyles.Add(bColumnTextColumn)
        End If

        Dim column_2 As New DataGridTextBoxColumn()
        column_2.ReadOnly = True
        column_2.Width = 75
        column_2.NullText = "0"
        column_2.HeaderText = "原值(元)"
        column_2.MappingName = "original_value"
        tableStyle.GridColumnStyles.Add(column_2)

        Dim column_3 As New DataGridTextBoxColumn()
        column_3.ReadOnly = True
        column_3.Width = 75
        column_3.NullText = "0"
        column_3.HeaderText = "评估总值(元)"
        column_3.MappingName = "evaluate_value"
        tableStyle.GridColumnStyles.Add(column_3)

        Dim column_10 As New DataGridTextBoxColumn()
        column_10.ReadOnly = True
        column_10.Width = 75
        column_10.NullText = "0"
        column_10.HeaderText = "评估净值(元)"
        column_10.MappingName = "evaluate_net_value"
        tableStyle.GridColumnStyles.Add(column_10)

        Dim column_4 As New DataGridTextBoxColumn()
        column_4.ReadOnly = True
        column_4.NullText = "0"
        column_4.HeaderText = "担保额(元)"
        column_4.MappingName = "guarantee_value"
        tableStyle.GridColumnStyles.Add(column_4)

        Dim column_5 As New DataGridTextBoxColumn()
        column_5.ReadOnly = True
        column_5.NullText = ""
        column_5.HeaderText = "备注"
        column_5.MappingName = "remark"
        tableStyle.GridColumnStyles.Add(column_5)

        Me.dgOppGuarantee.TableStyles.Clear()
        Me.dgOppGuarantee.TableStyles.Add(tableStyle)
    End Sub
    '
    '获得反担保物的详细信息
    '
    Private Sub getDetail()
        Dim index As Integer
        Dim strCode, strSerial, strType, strState As String
        index = Me.dgOppGuarantee.CurrentRowIndex
        If index < 0 Then
            Exit Sub
        End If
        Try
            strCode = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("project_code")
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        If Not dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("serial_num") Is System.DBNull.Value Then
            strSerial = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("serial_num")
            If Not dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("guaranty_type") Is System.DBNull.Value Then
                strType = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("guaranty_type")
            End If
            If Not dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("status") Is System.DBNull.Value Then
                strState = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(index).Item("status")
            End If
            dsDetailView = getOppGuaranteeDetail(strCode, strSerial, strType)
            Me.dgDetail.DataSource = dsDetailView.Tables("opposite_guarantee_detail")
        Else
            dsDetailView.Tables("opposite_guarantee_detail").Clear()
        End If
    End Sub
    '根据是否有文件设置"浏览图片"按钮的Enable属性
    Private Sub setButton()
        Dim dt As DataTable
        Try
            dt = CType(Me.dgOppGuarantee.DataSource, DataTable)
            Me.btnView.Enabled = False
            If dt.Rows.Count > 0 Then
                ' qxd modify 2004-8-17
                If IsAllowViewPicture() Then
                    Me.btnView.Enabled = True
                Else
                    Me.btnView.Enabled = False
                End If
                'If Not dt.Rows(Me.dgOppGuarantee.CurrentRowIndex).Item("file_relation_num") Is System.DBNull.Value Then
                '    Me.btnView.Enabled = True
                'End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '设置反担保物信息
    '
    Private Sub getOppGuaranteeInfo()
        Dim index As Integer
        Dim dt As DataTable
        index = Me.dgOppGuarantee.CurrentRowIndex
        dt = CType(Me.dgOppGuarantee.DataSource, DataTable)
        If index < 0 Then
            Exit Sub
        End If
        Try
            With dt.Rows(index)
                If Not .Item("original_value") Is System.DBNull.Value Then
                    Me.txtOriginal.Text = .Item("original_value")
                Else
                    Me.txtOriginal.Text = ""
                End If
                If Not .Item("evaluate_value") Is System.DBNull.Value Then
                    Me.txtEvaluate.Text = .Item("evaluate_value")
                Else
                    Me.txtEvaluate.Text = ""
                End If
                If Not .Item("evaluate_net_value") Is System.DBNull.Value Then
                    Me.txtEvaluateNet.Text = .Item("evaluate_net_value")
                Else
                    Me.txtEvaluateNet.Text = ""
                End If
                If Not .Item("guarantee_value") Is System.DBNull.Value Then
                    Me.txtGuarantee.Text = .Item("guarantee_value")
                Else
                    Me.txtGuarantee.Text = ""
                End If
                If Not .Item("evaluate_date") Is System.DBNull.Value Then
                    Me.dateEvaluate.Value = .Item("evaluate_date")
                Else
                    Me.dateEvaluate.Value = gWs.GetSysTime()
                End If
                If Not .Item("contract_no") Is System.DBNull.Value Then
                    Me.txtContract.Text = .Item("contract_no")
                Else
                    Me.txtContract.Text = ""
                End If
                If Not .Item("remark") Is System.DBNull.Value Then
                    Me.txtRemark.Text = .Item("remark")
                Else
                    Me.txtRemark.Text = ""
                End If
                If Not .Item("guaranty_type") Is System.DBNull.Value Then
                    Me.cmbType.Text = getGuaranteeType(.Item("guaranty_type"))
                End If
                If Not .Item("opposite_guarantee_form") Is System.DBNull.Value Then
                    Me.cmbMeasure.Text = getGuaranteeForm(.Item("opposite_guarantee_form"))
                End If
            End With
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '浏览图片
    Private Sub btnView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView.Click
        Dim ds As DataSet
        Dim strCode As String
        Dim strRelationNum As String
        Dim strItemType As String
        Dim index As Integer
        index = Me.dgOppGuarantee.CurrentRowIndex
        If index < 0 Then
            Exit Sub
        End If
        ds = dsOppGuaranteeView
        If Not ds.Tables("opposite_guarantee").Rows(index).Item("project_code") Is System.DBNull.Value Then
            strCode = ds.Tables("opposite_guarantee").Rows(index).Item("project_code")
        End If
        If Not ds.Tables("opposite_guarantee").Rows(index).Item("guaranty_type") Is System.DBNull.Value Then
            strItemType = ds.Tables("opposite_guarantee").Rows(index).Item("guaranty_type")
        End If
        'qxd modify 2004-8-17
        'If Not ds.Tables("opposite_guarantee").Rows(index).Item("file_relation_num") Is System.DBNull.Value Then
        '    strRelationNum = ds.Tables("opposite_guarantee").Rows(index).Item("file_relation_num")
        '    Me.Cursor = Cursors.WaitCursor
        '    Dim docClass As New frmDocumentClass("")
        '    'docClass.openFileList(strProjectCode, strItemType, "", strDir)
        '    docClass.openFileList(strProjectCode, "2%", "", strDir)
        '    Me.Cursor = Cursors.Default
        'Else
        '    'MsgBox("没有相关的图片!", MsgBoxStyle.Exclamation, "提示")
        '    SWDialogBox.MessageBox.Show("$1005", "图片")
        'End If
        Me.Cursor = Cursors.WaitCursor
        Dim docClass As New frmDocumentClass("")
        'docClass.openFileList(strProjectCode, strItemType, "", strDir)
        docClass.openFileList(strProjectCode, "2%", "", strDir)
        Me.Cursor = Cursors.Default
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
        '    'MsgBox("有未确认解除的反担保物,不能提交!", MsgBoxStyle.Exclamation, "提示")
        '    SWDialogBox.MessageBox.Show("$1004", "未确认解除的反担保物")
        '    Exit Sub
        'End If
        save(False)
        Dim strCommit As String
        Try
            strCommit = gWs.finishedTask(strWorkFlowID, strProjectCode, strTaskID, "", strPerson)
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
    End Sub
    '保存
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        save(True)
    End Sub
    '保存处理
    Private Sub save(ByVal isPopMesgBox As Boolean)
        If Not dsOppGuaranteeView Is Nothing Then
            Dim dr As DataRow
            Dim i As Integer
            Dim strResult As String

            If Me.txtRemark.Enabled Then
                Me.dsOppGuaranteeView.Tables("opposite_guarantee").Rows(Me.dgOppGuarantee.CurrentRowIndex).Item("remark") = Me.txtRemark.Text
            End If

            i = dsOppGuaranteeView.Tables("opposite_guarantee").Rows.Count

            For i = 0 To i - 1

                If Not Me.dsOppGuaranteeView.HasChanges Then Exit For

                dr = dsOppGuaranteeView.Tables("opposite_guarantee").Rows(i)
                With dr
                    If Me.strPhase = "代偿" Then
                        If .Item("hock_release") = True Then '典当
                            .Item("release_person") = strPerson
                            Try
                                .Item("release_date") = gWs.GetSysTime()
                            Catch ex As Exception
                                ExceptionHandler.ShowMessageBox(ex)
                            End Try
                            .Item("status") = "典当"

                        ElseIf .Item("sell_release") = True Then '变卖
                            .Item("release_person") = strPerson
                            Try
                                .Item("release_date") = gWs.GetSysTime()
                            Catch ex As Exception
                                ExceptionHandler.ShowMessageBox(ex)
                            End Try
                            .Item("status") = "变卖"
                        Else
                            .Item("release_person") = System.DBNull.Value
                            .Item("release_date") = System.DBNull.Value
                            .Item("status") = strStatus
                        End If
                    Else '解除
                        If Not .Item("affirm_release") Is System.DBNull.Value Then
                            If .Item("affirm_release") = True Then
                                .Item("release_person") = strPerson
                                Try
                                    .Item("release_date") = gWs.GetSysTime()
                                Catch ex As Exception
                                    ExceptionHandler.ShowMessageBox(ex)
                                End Try
                                .Item("status") = "解除"
                            Else
                                .Item("release_person") = System.DBNull.Value
                                .Item("release_date") = System.DBNull.Value
                                .Item("status") = strStatus
                            End If
                        Else
                            .Item("release_person") = System.DBNull.Value
                            .Item("release_date") = System.DBNull.Value
                        End If
                    End If
                End With
            Next
            strResult = gWs.UpdateGuaranty(dsOppGuaranteeView)
            If strResult = "1" Then
                If isPopMesgBox Then
                    'MsgBox("保存成功!", MsgBoxStyle.Information, "提示")
                    SWDialogBox.MessageBox.Show("$SaveSucceed")
                End If
                dsOppGuaranteeView = Me.getOppGuaranteeRecords(strProjectCode, "3")
                Try
                    Me.dgOppGuarantee.DataSource = dsOppGuaranteeView.Tables("opposite_guarantee")
                    Me.dsOppGuaranteeView.AcceptChanges()
                    Me.setDgAttribute(Me.dgOppGuarantee)
                    'Me.dgOppGuarantee.CurrentRowIndex = 0
                Catch ex As Exception
                Finally
                End Try

                Me.btnModify.Text = "修 改(&M)"
                Me.txtRemark.Enabled = False
            Else
                'MsgBox("保存失败!", MsgBoxStyle.Critical, "提示")
                SWDialogBox.MessageBox.Show("*999", "", strResult, "")
            End If
        End If
        getDetail()
    End Sub
    '设置TextBox的Enabled属性
    Private Sub setTextBox(ByVal isEnabled As Boolean)
        Me.txtOriginal.Enabled = isEnabled
        Me.txtGuarantee.Enabled = isEnabled
        Me.txtEvaluate.Enabled = isEnabled
        Me.txtEvaluateNet.Enabled = isEnabled
        Me.txtContract.Enabled = isEnabled
        Me.cmbType.Enabled = isEnabled
        Me.dateEvaluate.Enabled = isEnabled
        Me.txtRemark.Enabled = isEnabled
        Me.cmbMeasure.Enabled = isEnabled
    End Sub
    '
    '退出
    '
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        frmExit(sender, e)
    End Sub
    '推出处理
    Private Function frmExit(ByVal sender As System.Object, ByVal e As System.EventArgs)
        '根据dataSet判断是否修改了
        Dim changedCount As Integer = 0
        If Not Me.dsOppGuaranteeView Is Nothing Then
            Try
                changedCount = Me.dsOppGuaranteeView.GetChanges.Tables(0).Rows.Count
            Catch
            End Try
        End If
        If changedCount > 0 Then
            Dim strMesg As Integer
            'strMesg = MsgBox("数据已修改，是否保存？", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNoCancel, "提示")
            strMesg = SWDialogBox.MessageBox.Show("?1003")
            If 6 = strMesg Then
                save(True)
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
    'KeyPress()
    Private Sub frmOppGuaranteeAffirm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
    End Sub
    'Closing()
    Private Sub frmOppGuaranteeAffirm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If sender.GetType Is GetType(Form) Then
            If frmExit(sender, e) Then
                e.Cancel = True
            End If
        End If
    End Sub
    '列表中鼠标按下事件
    Private Sub dgOppGuarantee_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgOppGuarantee.MouseUp
        If Me.dsOppGuaranteeView Is Nothing Then
            Exit Sub
        End If
        If Me.dsOppGuaranteeView.Tables("opposite_guarantee").Rows.Count > 0 Then
            Me.dgOppGuarantee.Select(Me.dgOppGuarantee.CurrentCell.RowNumber)
            '单击datagrid中的checkbox时改变checked
            Dim rowNum, colNum As Integer
            rowNum = Me.dgOppGuarantee.CurrentCell.RowNumber
            colNum = Me.dgOppGuarantee.CurrentCell.ColumnNumber
            setButton()
            getDetail()
            getOppGuaranteeInfo()

            Dim he As DataGrid = CType(sender, DataGrid)
            If he.HitTest(e.X, e.Y).Type <> DataGrid.HitTestType.Cell Then Return
            If Me.strPhase = "代偿" Then
                Select Case colNum
                    Case 1
                        If Me.dgOppGuarantee.Item(rowNum, 2) = True Then '如果变卖没有选中
                            Me.dgOppGuarantee.Item(rowNum, 2) = False
                        End If
                        Me.dgOppGuarantee.Item(rowNum, colNum) = Not Me.dgOppGuarantee.Item(rowNum, colNum)
                    Case 2
                        If Me.dgOppGuarantee.Item(rowNum, 1) = True Then '如果典当没有选中
                            Me.dgOppGuarantee.Item(rowNum, 1) = False
                        End If
                        Me.dgOppGuarantee.Item(rowNum, colNum) = Not Me.dgOppGuarantee.Item(rowNum, colNum)
                    Case Else
                        Exit Select
                End Select
            Else
                If colNum = 1 Then
                    Me.dgOppGuarantee.Item(rowNum, colNum) = Not Me.dgOppGuarantee.Item(rowNum, colNum)
                End If
            End If
            Me.dgOppGuarantee.Select(Me.dgOppGuarantee.CurrentCell.RowNumber)
        End If
    End Sub
    '
    '判断基本的确认解除项是否已确认
    '如果有一个没有确认,则返回true
    '
    Private Function isAccreditCommit()
        Dim dt As DataTable
        If Not Me.dgOppGuarantee.DataSource Is Nothing Then
            Dim i As Integer
            Dim dr As DataRow
            Dim isNotChecked As Boolean = False
            Try
                dt = CType(Me.dgOppGuarantee.DataSource, DataTable)
                i = dt.Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = dt.Rows(i)
                        With dr
                            If Not .Item("affirm_release") Then
                                isNotChecked = True
                            End If
                        End With
                    Next
                End If
            Catch
            End Try
            Return isNotChecked
        End If
    End Function

    Private Function getOppGuaranteeRecords(ByVal strProjectCode As String, ByVal flag As String) As DataSet
        Dim dOriginal As Double = 0.0
        Dim dEvaluate As Double = 0.0
        Dim dGuarantee As Double = 0.0
        Dim totalOriginal As Double = 0.0
        Dim totalEvaluate As Double = 0.0
        Dim totalGuarantee As Double = 0.0
        Dim ds, dsTemp As DataSet
        Dim dsItem, dsItemType As DataSet
        Dim dr As DataRow
        Dim strItemType As String
        Dim strSql, strSQLDetail As String
        Select Case flag
            Case "0"
                strSql = "{project_code ='" & strProjectCode & "'}"
            Case "1"
                strSql = "{project_code ='" & strProjectCode & "' and status like  '申请'}"
            Case "2"
                strSql = "{project_code ='" & strProjectCode & "' and (status like  '评审通过' or  status like '抵押质押')}"
            Case "3"
                strSql = "{project_code ='" & strProjectCode & "' and (status like  '抵押质押' or  status like '解除' or status like '典当' or status like '变卖')}"
        End Select
        strSQLDetail = ("{project_code ='" & strProjectCode & "'}")
        Try
            ds = gWs.GetGuarantyInfo(strSql, strSQLDetail)

            ds.Tables("opposite_guarantee").Columns.Add("type_name", GetType(String))
            If Me.strPhase = "代偿" Then
                ds.Tables("opposite_guarantee").Columns.Add("hock_release", GetType(Boolean))
                ds.Tables("opposite_guarantee").Columns.Add("sell_release", GetType(Boolean))
            Else
                ds.Tables("opposite_guarantee").Columns.Add("affirm_release", GetType(Boolean))
            End If
            ds.Tables("opposite_guarantee_detail").Columns.Add("item_name", GetType(String))

            Dim j As Integer
            j = ds.Tables("opposite_guarantee").Rows.Count

            For j = 0 To j - 1
                '判断是否解除了,没有则置affirm_release为false
                dr = ds.Tables("opposite_guarantee").Rows(j)
                With dr
                    If Me.strPhase = "代偿" Then
                        If Not .Item("release_person") Is System.DBNull.Value Then
                            If Not .Item("release_person") = "" Then
                                If .Item("status") = "典当" Then
                                    .Item("hock_release") = True
                                    .Item("sell_release") = False
                                Else
                                    .Item("sell_release") = True
                                    .Item("hock_release") = False
                                End If
                            Else
                                .Item("hock_release") = False
                                .Item("sell_release") = False
                            End If
                        Else
                            .Item("hock_release") = False
                            .Item("sell_release") = False
                        End If
                    Else
                        If Not .Item("release_person") Is System.DBNull.Value Then
                            .Item("affirm_release") = True
                            If .Item("release_person") = "" Then
                                .Item("affirm_release") = False
                            End If
                        Else
                            .Item("affirm_release") = False
                        End If
                    End If

                    Try
                        If Not .Item("guaranty_type") Is System.DBNull.Value Then
                            strItemType = .Item("guaranty_type")
                            dsItemType = getItemTypeDataSet(strItemType)
                            'oppGuarantee显示的类型名映射为ItemType中的typeName
                            .Item("type_name") = dsItemType.Tables("TItemType").Select("item_type='" & strItemType & "'")(0).Item("type_name")
                        End If
                    Catch ex As Exception
                        'MsgBox("获取反担保物类型出错!" & ex.Message, MsgBoxStyle.Critical, "提示")
                        ExceptionHandler.ShowMessageBox(ex)
                    End Try
                    '金额统计，qxd add 2003-5-10
                    If Not .Item("original_value") Is System.DBNull.Value Then
                        totalOriginal = .Item("original_value")
                        dOriginal = totalOriginal + dOriginal
                    End If
                    If Not .Item("evaluate_value") Is System.DBNull.Value Then
                        totalEvaluate = .Item("evaluate_value")
                        dEvaluate = totalEvaluate + dEvaluate
                    End If
                    If Not .Item("guarantee_value") Is System.DBNull.Value Then
                        totalGuarantee = .Item("guarantee_value")
                        dGuarantee = totalGuarantee + dGuarantee
                    End If
                End With
            Next
            Return ds
        Catch ex As Exception
        End Try
    End Function

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        If btnModify.Text = "修 改(&M)" Then
            btnModify.Text = "取 消(&C)"
            Me.txtRemark.Enabled = True
            Me.txtRemark.Focus()
        Else
            btnModify.Text = "修 改(&M)"
            Me.txtRemark.Enabled = False
        End If
    End Sub


    '获得项目企业表信息,并设置“企业联系人”和“联系电话”的初始值
    Private Sub getProjectCorporation(ByVal projectCode As String, ByVal phase As String)
        Try
            Dim strSql As String

            strSql = "{project_code='" & projectCode & "' and phase='" & phase & "' and corporation_code='" & projectCode.Substring(0, 5) & "'}"
            'dsProjectCorporation = gWs.FetchProjectCorporation(strSql)
            dsProjectCorporation = gWs.FetchProjectCorporation(Me.getProjectCode(), "%", "1", Me.getPhase(getProjectCode()))
            If Not dsProjectCorporation Is Nothing Then
                If dsProjectCorporation.Tables(0).Rows.Count > 0 Then
                    If Not dsProjectCorporation.Tables(0).Rows(0).Item("corp_contact_person") Is System.DBNull.Value Then
                        Me.corp_contact_person.Text = dsProjectCorporation.Tables(0).Rows(0).Item("corp_contact_person")
                    End If
                    If Not dsProjectCorporation.Tables(0).Rows(0).Item("corp_contact_phone") Is System.DBNull.Value Then
                        Me.corp_contact_phone.Text = dsProjectCorporation.Tables(0).Rows(0).Item("corp_contact_phone")
                    End If
                End If
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '
    '如果项目其中的一个反担保物有图片，则查看按钮可用。
    'qxd add 2004－8－17 
    '目的：为了省去查看时，需要选择具体一个反担保物有图片时才允许查看图片的麻烦！
    Private Function IsAllowViewPicture()
        Dim dt As DataTable
        Dim dr As DataRow
        Dim i, count As Integer
        Dim flag As Boolean = False
        Try
            dt = CType(Me.dgOppGuarantee.DataSource, DataTable)

            If Not dt Is Nothing Then
                count = dt.Rows.Count
                If count > 0 Then
                    For i = 0 To count - 1
                        If Not dt.Rows(i).Item("file_relation_num") Is System.DBNull.Value Then
                            flag = True
                            Exit For
                        End If
                    Next
                End If
            End If
            Return flag
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
End Class

