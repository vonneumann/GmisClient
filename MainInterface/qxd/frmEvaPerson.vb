

Public Class frmEvaPerson
    Inherits MainInterface.frmBasic

    Private strProjectCode As String
    Private strCorporationName As String
    Private strWorkFlowID As String
    Private strTaskID As String
    Private strPerson As String

    Private dsOpp As DataSet
    Private dsTask As DataSet

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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgOppGuarantee As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbEvaluate As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents btnArrange As System.Windows.Forms.Button
    Friend WithEvents txtManagerB As System.Windows.Forms.TextBox
    Friend WithEvents txtManagerA As System.Windows.Forms.TextBox
    Friend WithEvents txtApplySum As System.Windows.Forms.TextBox
    Friend WithEvents txtApplyBank As System.Windows.Forms.TextBox
    Friend WithEvents txtBusinessForm As System.Windows.Forms.TextBox
    Friend WithEvents txtApplyDate As System.Windows.Forms.TextBox
    Friend WithEvents txtStatus As System.Windows.Forms.TextBox
    Friend WithEvents txtPhase As System.Windows.Forms.TextBox
    Friend WithEvents txtGuaranteeTerm As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgTask As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnBatchArrange As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmEvaPerson))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtManagerB = New System.Windows.Forms.TextBox()
        Me.txtManagerA = New System.Windows.Forms.TextBox()
        Me.txtGuaranteeTerm = New System.Windows.Forms.TextBox()
        Me.txtApplySum = New System.Windows.Forms.TextBox()
        Me.txtApplyBank = New System.Windows.Forms.TextBox()
        Me.txtApplyDate = New System.Windows.Forms.TextBox()
        Me.txtStatus = New System.Windows.Forms.TextBox()
        Me.txtPhase = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBusinessForm = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgOppGuarantee = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.cmbEvaluate = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.btnArrange = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgTask = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnBatchArrange = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgTask, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(623, 496)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 8
        Me.btnExit.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtManagerB, Me.txtManagerA, Me.txtGuaranteeTerm, Me.txtApplySum, Me.txtApplyBank, Me.txtApplyDate, Me.txtStatus, Me.txtPhase, Me.Label11, Me.Label10, Me.Label9, Me.Label8, Me.Label7, Me.Label5, Me.Label4, Me.Label3, Me.Label6, Me.txtBusinessForm})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(694, 136)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "项目信息"
        '
        'txtManagerB
        '
        Me.txtManagerB.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtManagerB.Location = New System.Drawing.Point(584, 103)
        Me.txtManagerB.Name = "txtManagerB"
        Me.txtManagerB.ReadOnly = True
        Me.txtManagerB.TabIndex = 8
        Me.txtManagerB.Text = ""
        '
        'txtManagerA
        '
        Me.txtManagerA.Location = New System.Drawing.Point(360, 103)
        Me.txtManagerA.Name = "txtManagerA"
        Me.txtManagerA.ReadOnly = True
        Me.txtManagerA.TabIndex = 7
        Me.txtManagerA.Text = ""
        '
        'txtGuaranteeTerm
        '
        Me.txtGuaranteeTerm.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtGuaranteeTerm.Location = New System.Drawing.Point(472, 47)
        Me.txtGuaranteeTerm.Name = "txtGuaranteeTerm"
        Me.txtGuaranteeTerm.ReadOnly = True
        Me.txtGuaranteeTerm.Size = New System.Drawing.Size(211, 21)
        Me.txtGuaranteeTerm.TabIndex = 3
        Me.txtGuaranteeTerm.Text = ""
        '
        'txtApplySum
        '
        Me.txtApplySum.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtApplySum.Location = New System.Drawing.Point(472, 76)
        Me.txtApplySum.Name = "txtApplySum"
        Me.txtApplySum.ReadOnly = True
        Me.txtApplySum.Size = New System.Drawing.Size(211, 21)
        Me.txtApplySum.TabIndex = 5
        Me.txtApplySum.Text = ""
        Me.txtApplySum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtApplyBank
        '
        Me.txtApplyBank.Location = New System.Drawing.Point(104, 77)
        Me.txtApplyBank.Name = "txtApplyBank"
        Me.txtApplyBank.ReadOnly = True
        Me.txtApplyBank.Size = New System.Drawing.Size(192, 21)
        Me.txtApplyBank.TabIndex = 4
        Me.txtApplyBank.Text = ""
        '
        'txtApplyDate
        '
        Me.txtApplyDate.Location = New System.Drawing.Point(104, 103)
        Me.txtApplyDate.Name = "txtApplyDate"
        Me.txtApplyDate.ReadOnly = True
        Me.txtApplyDate.TabIndex = 6
        Me.txtApplyDate.Text = ""
        '
        'txtStatus
        '
        Me.txtStatus.Location = New System.Drawing.Point(104, 48)
        Me.txtStatus.Name = "txtStatus"
        Me.txtStatus.ReadOnly = True
        Me.txtStatus.Size = New System.Drawing.Size(192, 21)
        Me.txtStatus.TabIndex = 1
        Me.txtStatus.Text = ""
        '
        'txtPhase
        '
        Me.txtPhase.Location = New System.Drawing.Point(104, 18)
        Me.txtPhase.Name = "txtPhase"
        Me.txtPhase.ReadOnly = True
        Me.txtPhase.Size = New System.Drawing.Size(192, 21)
        Me.txtPhase.TabIndex = 0
        Me.txtPhase.Text = ""
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(504, 102)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 8
        Me.Label11.Text = "项目经理B角"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(272, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 23)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "项目经理A角"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(352, 46)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 23)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "申请担保期限(月)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(352, 75)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 23)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "申请担保金额(万元)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(24, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 23)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "申请贷款银行"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "申请日期"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "项目状态"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "项目阶段"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(352, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 23)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "申请业务品种"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBusinessForm
        '
        Me.txtBusinessForm.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtBusinessForm.Location = New System.Drawing.Point(472, 18)
        Me.txtBusinessForm.Name = "txtBusinessForm"
        Me.txtBusinessForm.ReadOnly = True
        Me.txtBusinessForm.Size = New System.Drawing.Size(211, 21)
        Me.txtBusinessForm.TabIndex = 2
        Me.txtBusinessForm.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgOppGuarantee})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(694, 304)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "反担保物列表"
        '
        'dgOppGuarantee
        '
        Me.dgOppGuarantee.CaptionVisible = False
        Me.dgOppGuarantee.DataMember = ""
        Me.dgOppGuarantee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOppGuarantee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgOppGuarantee.Location = New System.Drawing.Point(3, 17)
        Me.dgOppGuarantee.Name = "dgOppGuarantee"
        Me.dgOppGuarantee.ReadOnly = True
        Me.dgOppGuarantee.Size = New System.Drawing.Size(688, 284)
        Me.dgOppGuarantee.TabIndex = 0
        Me.dgOppGuarantee.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.DataGrid = Me.dgOppGuarantee
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "opposite_guarantee"
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "SerialNum"
        Me.DataGridTextBoxColumn6.MappingName = "serial_num"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 0
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "ItemType"
        Me.DataGridTextBoxColumn5.MappingName = "guaranty_type"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "反担保物"
        Me.DataGridTextBoxColumn1.MappingName = "type_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 130
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "担保措施"
        Me.DataGridTextBoxColumn2.MappingName = "opposite_guarantee_form"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "评估师"
        Me.DataGridTextBoxColumn3.MappingName = "evaluate_person"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "预约评估时间"
        Me.DataGridTextBoxColumn7.MappingName = "evaluate_date"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "说明"
        Me.DataGridTextBoxColumn4.MappingName = "remark"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 330
        '
        'cmbEvaluate
        '
        Me.cmbEvaluate.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.cmbEvaluate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEvaluate.Location = New System.Drawing.Point(80, 496)
        Me.cmbEvaluate.Name = "cmbEvaluate"
        Me.cmbEvaluate.Size = New System.Drawing.Size(104, 20)
        Me.cmbEvaluate.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)
        Me.Label12.Location = New System.Drawing.Point(8, 496)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 23)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "资产评估师"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(536, 496)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 7
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuery.ImageIndex = 3
        Me.btnQuery.ImageList = Me.ImageListBasic
        Me.btnQuery.Location = New System.Drawing.Point(216, 496)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(120, 24)
        Me.btnQuery.TabIndex = 5
        Me.btnQuery.Text = "查询当前任务(&Q)"
        Me.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnArrange
        '
        Me.btnArrange.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnArrange.Image = CType(resources.GetObject("btnArrange.Image"), System.Drawing.Bitmap)
        Me.btnArrange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnArrange.ImageIndex = 7
        Me.btnArrange.ImageList = Me.ImageListBasic
        Me.btnArrange.Location = New System.Drawing.Point(449, 496)
        Me.btnArrange.Name = "btnArrange"
        Me.btnArrange.Size = New System.Drawing.Size(77, 24)
        Me.btnArrange.TabIndex = 6
        Me.btnArrange.Text = "分 配(&A)"
        Me.btnArrange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgTask})
        Me.GroupBox4.Location = New System.Drawing.Point(8, 168)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(696, 8)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Visible = False
        '
        'dgTask
        '
        Me.dgTask.DataMember = ""
        Me.dgTask.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgTask.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgTask.Location = New System.Drawing.Point(3, 17)
        Me.dgTask.Name = "dgTask"
        Me.dgTask.ReadOnly = True
        Me.dgTask.Size = New System.Drawing.Size(690, 0)
        Me.dgTask.TabIndex = 0
        Me.dgTask.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.AllowSorting = False
        Me.DataGridTableStyle2.DataGrid = Me.dgTask
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "Table"
        Me.DataGridTableStyle2.ReadOnly = True
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn8.MappingName = "project_code"
        Me.DataGridTextBoxColumn8.NullText = ""
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "项目名称"
        Me.DataGridTextBoxColumn9.MappingName = "project_name"
        Me.DataGridTextBoxColumn9.NullText = ""
        Me.DataGridTextBoxColumn9.Width = 250
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "分配时间"
        Me.DataGridTextBoxColumn10.MappingName = "start_time"
        Me.DataGridTextBoxColumn10.NullText = ""
        Me.DataGridTextBoxColumn10.Width = 75
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "任务人"
        Me.DataGridTextBoxColumn11.MappingName = "attend_person"
        Me.DataGridTextBoxColumn11.NullText = ""
        Me.DataGridTextBoxColumn11.Width = 75
        '
        'btnBatchArrange
        '
        Me.btnBatchArrange.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnBatchArrange.Image = CType(resources.GetObject("btnBatchArrange.Image"), System.Drawing.Bitmap)
        Me.btnBatchArrange.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnBatchArrange.ImageIndex = 7
        Me.btnBatchArrange.ImageList = Me.ImageListBasic
        Me.btnBatchArrange.Location = New System.Drawing.Point(346, 496)
        Me.btnBatchArrange.Name = "btnBatchArrange"
        Me.btnBatchArrange.Size = New System.Drawing.Size(93, 24)
        Me.btnBatchArrange.TabIndex = 9
        Me.btnBatchArrange.Text = "批量分配(&B)"
        Me.btnBatchArrange.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtName
        '
        Me.txtName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtName.Location = New System.Drawing.Point(352, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(352, 21)
        Me.txtName.TabIndex = 13
        Me.txtName.Text = ""
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 8)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(192, 21)
        Me.txtCode.TabIndex = 11
        Me.txtCode.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(296, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "项目编目"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEvaPerson
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 527)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtName, Me.txtCode, Me.Label2, Me.Label1, Me.btnExit, Me.btnBatchArrange, Me.GroupBox4, Me.btnArrange, Me.btnQuery, Me.btnCommit, Me.Label12, Me.cmbEvaluate, Me.GroupBox3, Me.GroupBox2})
        Me.Name = "frmEvaPerson"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "分配资产评估师"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgTask, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private EvaluationPersonRole As String = "34"

    Private Sub frmEvaPerson_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Me.strProjectCode = Me.getProjectCode()
            Me.strCorporationName = Me.getCorporationName()
            Me.strWorkFlowID = Me.getWorkFlowID()
            Me.strTaskID = Me.getTaskID()
            Me.strPerson = Me.getUser

            Me.txtCode.Text = Me.strProjectCode
            Me.txtName.Text = Me.strCorporationName

            getProjectInfo()
            setEvaPerson(EvaluationPersonRole)
            getOppGuarantee()
            setButton()
            '暂时屏蔽,由于速度比较慢!2003-9-8
            'GetFirstCheckerTaskList("")
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub

    '
    '设置资产评估师
    'role_id=34:资产评估师
    '
    Private Sub setEvaPerson(ByVal roleID As String)
        Dim tbl As DataTable = MdlGlobal.GetPerson(strProjectCode, roleID)
        Try
            Me.cmbEvaluate.DataSource = tbl
            Me.cmbEvaluate.DisplayMember = "staff_name"
            Me.cmbEvaluate.ValueMember = "staff_name"
            'Dim strDefaultPerson As String
            'ds = gWs.GetDefaultPerson(strProjectCode, EvaluationPersonRole)
            'If ds.Tables(0).Rows.Count > 0 Then
            '    strDefaultPerson = ds.Tables(0).Rows(0).Item("Person").ToString
            '    Me.cmbEvaluate.SelectedValue = strDefaultPerson
            'End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '设置项目信息，通过视图：viewProjectInfo获取信息
    '
    Private Sub getProjectInfo()
        If gWs Is Nothing Then
            Exit Sub
        End If
        Dim ds As DataSet
        Dim dr As DataRow
        Dim dt As DataTable
        Dim i As Integer
        Dim strSql As String
        strSql = "{projectcode='" & strProjectCode & "'}"
        ds = gWs.GetProjectInfoEx(strSql)

        i = ds.Tables(0).Rows.Count
        Try
            If i > 0 Then
                dr = ds.Tables(0).Rows(0)
                With dr
                    Me.txtPhase.Text = IIf(.Item("phase") Is System.DBNull.Value, "", .Item("phase"))
                    Me.txtStatus.Text = IIf(.Item("status") Is System.DBNull.Value, "", .Item("status"))
                    Me.txtApplyDate.Text = IIf(.Item("applydate") Is System.DBNull.Value, "", CType(.Item("applydate"), Date).ToString("yyyy年MM月dd日"))
                    Me.txtBusinessForm.Text = IIf(.Item("applyservicetype") Is System.DBNull.Value, "", .Item("applyservicetype"))
                    Me.txtApplyBank.Text = IIf(.Item("applybank") Is System.DBNull.Value, "", .Item("applybank"))
                    Me.txtApplySum.Text = IIf(.Item("applysum") Is System.DBNull.Value, "", .Item("applysum"))
                    Me.txtGuaranteeTerm.Text = IIf(.Item("applyterm") Is System.DBNull.Value, "", .Item("applyterm"))
                End With
            End If
        Catch ex As Exception
        End Try
        ' role_id=24 :项目经理A
        strSql = "SELECT DISTINCT attend_person FROM project_task_attendee  WHERE project_code='" & strProjectCode & "' and (NOT (attend_person = '')) and role_id='24'"
        dt = gWs.GetCommonQueryInfo(strSql).Tables(0)
        i = dt.Rows.Count
        If i > 0 Then
            dr = dt.Rows(0)
            With dr
                Me.txtManagerA.Text = IIf(.Item("attend_person") Is System.DBNull.Value, "", .Item("attend_person"))
            End With
        Else
            Me.txtManagerA.Text = ""
        End If
        ' role_id=25 :项目经理B
        strSql = "SELECT DISTINCT attend_person FROM project_task_attendee  WHERE Project_code='" & strProjectCode & "' and (NOT (attend_person = '')) and role_id='25'"
        dt = gWs.GetCommonQueryInfo(strSql).Tables(0)
        i = dt.Rows.Count
        If i > 0 Then
            dr = dt.Rows(0)
            With dr
                Me.txtManagerB.Text = IIf(.Item("attend_person") Is System.DBNull.Value, "", .Item("attend_person"))
            End With
        Else
            Me.txtManagerB.Text = ""
        End If
    End Sub

    '获得反担保物信息
    Private Sub getOppGuarantee()
        Dim dr As DataRow
        Dim i As Integer
        dsOpp = getOppGuaranteeRecord(strProjectCode)
        If Not dsOpp Is Nothing Then
            Me.dgOppGuarantee.DataSource = dsOpp.Tables("opposite_guarantee")
        End If
    End Sub
    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    '表中鼠标按下的事件
    Private Sub dgOppGuarantee_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles dgOppGuarantee.MouseUp
        If Me.dsOpp Is Nothing Then
            Exit Sub
        End If
        If Me.dsOpp.Tables("opposite_guarantee").Rows.Count > 0 Then
            Me.dgOppGuarantee.Select(Me.dgOppGuarantee.CurrentCell.RowNumber)
            setButton()
        End If
    End Sub
    '根据item_type表中的标记判断是否需要分配评估师
    'additional_remark为“1”，则需要分配评估师；否则不需要分配评估师
    Private Sub setButton()
        Dim strItemType As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        If CType(Me.dgOppGuarantee.DataSource, DataTable).Rows.Count < 1 Then
            Me.btnArrange.Enabled = False
            Exit Sub
        End If
        strItemType = Me.dgOppGuarantee.Item(Me.dgOppGuarantee.CurrentCell.RowNumber, 1)
        ds = gWs.GetItemType(strItemType)
        i = ds.Tables(0).Rows.Count
        If i > 0 Then
            Me.btnBatchArrange.Enabled = True
            dr = ds.Tables(0).Rows(0)
            With dr
                If Not .Item("additional_remark") Is System.DBNull.Value Then
                    If .Item("additional_remark") = "1" Then
                        Me.btnArrange.Enabled = True
                        Me.cmbEvaluate.Enabled = True
                    Else
                        Me.btnArrange.Enabled = False
                        Me.cmbEvaluate.Enabled = False
                    End If
                Else
                    Me.btnArrange.Enabled = False
                    Me.cmbEvaluate.Enabled = False
                End If
            End With
        Else
            Me.btnArrange.Enabled = False
            Me.btnBatchArrange.Enabled = False
            Me.cmbEvaluate.Enabled = False
        End If
    End Sub
    '查询资产评估师当前的工作任务列表
    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            Dim query As New FQueryEvaluaterTask(EvaluationPersonRole)
            query.AllowTransparency = False
            query.ShowDialog()
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
    End Sub
    '分配评估师
    Private Sub btnArrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArrange.Click
        setEvaluatePerson()
    End Sub

    '分配评估师即更改字段evaluate_person的值
    Private Sub setEvaluatePerson()
        If Me.cmbEvaluate.Text = "" Then
            'MsgBox("请选择资产评估师！", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1001", "资产评估师")
            Me.cmbEvaluate.Focus()
            Exit Sub
        End If
        Dim currentIndex As Integer
        Dim strSerialNum As String
        Try
            currentIndex = Me.dgOppGuarantee.CurrentCell.RowNumber
            strSerialNum = Me.dgOppGuarantee.Item(currentIndex, 0)
            Dim ds As DataSet
            Dim strSql As String
            Dim strResult As String
            strSql = "{project_code='" & strProjectCode & "' and serial_num='" & strSerialNum & "'}"
            ds = gWs.GetGuarantyInfo(strSql, "null")
            ds.Tables("opposite_guarantee").Rows(0).Item("evaluate_person") = Workflow.GetRealTaskAttendee(EvaluationPersonRole, Me.cmbEvaluate.Text) 'Me.cmbEvaluate.Text
            strResult = gWs.UpdateGuaranty(ds.GetChanges())
            If strResult = "1" Then
                'Me.dgOppGuarantee.Item(currentIndex, 4) = Me.cmbEvaluate.Text
                getOppGuarantee()
            Else
                'MsgBox("分配评估师失败！& strResult")
                SWDialogBox.MessageBox.Show("*999", "", strResult, "")
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '提交事件
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
    '提交
    Private Sub commit()
        If ifArrangeEnd() = "1" Then
            'MsgBox("还有未分配评估师的反担保物,不允许提交！", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1004", "分配评估师的反担保物")
            Exit Sub
        End If
        Dim strCommit As String
        Try
            strCommit = gWs.finishedTask(strWorkFlowID, strProjectCode, strTaskID, "", strPerson)
            If "1" = strCommit Then
                'MsgBox("提交成功!", MsgBoxStyle.Information, "提示")
                SWDialogBox.MessageBox.Show("$SubmitSucceed")
                raiseCommitSucceed()
                Me.Close()
            Else
                'MsgBox("提交失败!" & strCommit, MsgBoxStyle.Critical, "提示")
                SWDialogBox.MessageBox.Show("*999", "", strCommit, "")
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '判断是否完成评估师分配
    Private Function ifArrangeEnd() As String
        Dim strItemType As String
        Dim drOpp As DataRow
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i As Integer
        Dim j As Integer
        If Me.dsOpp Is Nothing Then
            Return "0"
        End If
        i = Me.dsOpp.Tables("opposite_guarantee").Rows.Count
        If i > 0 Then
            For i = 0 To i - 1
                drOpp = Me.dsOpp.Tables("opposite_guarantee").Rows(i)
                strItemType = drOpp.Item("guaranty_type")
                ds = gWs.GetItemType(strItemType)
                j = ds.Tables(0).Rows.Count
                If j > 0 Then
                    dr = ds.Tables(0).Rows(0)
                    With dr
                        If Not .Item("additional_remark") Is System.DBNull.Value Then
                            If .Item("additional_remark") = "1" Then
                                If drOpp.Item("evaluate_person") Is System.DBNull.Value Then
                                    Return "1"
                                Else
                                    If drOpp.Item("evaluate_person") = "" Then
                                        Return "1"
                                    End If
                                End If
                            End If
                        End If
                    End With
                End If
            Next
        End If
    End Function
    '获得任务列表
    Private Sub GetFirstCheckerTaskList(ByVal Param As String)
        Dim TempDS As New DataSet()
        Dim ds As DataSet
        Dim i As Integer
        ds = gWs.GetCapitialEvaluatedListInfo()
        ds.Tables(0).Columns.Add("project_name", GetType(String))
        For i = 0 To ds.Tables(0).Rows.Count - 1
            Dim proj_code, corp_name As String
            proj_code = ds.Tables(0).Rows(i).Item("project_code")
            TempDS = gWs.GetProjectInfoEx("{projectcode like '" & proj_code & "'}")
            If Not TempDS.Tables(0).Rows.Count = 0 Then
                corp_name = TempDS.Tables(0).Rows(0).Item("enterprisename")
            Else
                corp_name = ""
            End If
            ds.Tables(0).Rows(i).Item("project_name") = corp_name
        Next
        dsTask = ds
        If Not ds Is Nothing Then
            Me.dgTask.DataSource = ds.Tables(0)
            Me.dgTask.CaptionText = "统计工作共计 " + ds.Tables(0).Rows.Count.ToString() + " 件"
        End If
    End Sub
    'TextChanged
    Private Sub cmbEvaluate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEvaluate.TextChanged
        Dim strSql As String
        Dim ds As New DataSet()
        strSql = "attend_person='" & Me.cmbEvaluate.Text & "'"
        If Not dsTask Is Nothing Then
            ds.Merge(dsTask.Tables(0).Select(strSql))
            If Not ds Is Nothing Then
                Me.dgTask.DataSource = ds.Tables(0)
                Me.dgTask.CaptionText = "统计工作共计 " + ds.Tables(0).Rows.Count.ToString() + " 件"
            End If
        End If
    End Sub
    '
    ' 根据project_code获得反担保物记录
    '
    Private Function getOppGuaranteeRecord(ByVal strProjectCode As String) As DataSet
        Dim ds, dsTemp As DataSet
        Dim dsItem, dsItemType As DataSet
        Dim dr As DataRow
        Dim strItemType As String
        Dim strSqlOpp, strSqlDetail As String

        strSqlOpp = "{project_code ='" & strProjectCode & "'" & getQuerySql() & "}" ' and (guaranty_type='21'or guaranty_type='22' or guaranty_type='23')}"
        strSqlDetail = "null" ' "{project_code ='" & strProjectCode & "'}"
        Try
            ds = gWs.GetGuarantyInfo(strSqlOpp, strSqlDetail)

            ds.Tables("opposite_guarantee").Columns.Add("type_name", GetType(String))
            ds.Tables("opposite_guarantee").Columns.Add("affirm_release", GetType(Boolean))
            ds.Tables("opposite_guarantee_detail").Columns.Add("item_name", GetType(String))

            Dim j As Integer
            j = ds.Tables("opposite_guarantee").Rows.Count

            For j = 0 To j - 1
                '判断是否解除了,没有则置affirm_release为false
                dr = ds.Tables("opposite_guarantee").Rows(j)
                With dr
                    If Not .Item("release_person") Is System.DBNull.Value Then
                        .Item("affirm_release") = True
                        If .Item("release_person") = "" Then
                            .Item("affirm_release") = False
                        End If
                    Else
                        .Item("affirm_release") = False
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
                End With
            Next
            Return ds
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '
    '获得ItemType表的DataSet
    '
    Private Function getItemTypeDataSet(ByVal strItemType As String) As DataSet
        Dim ds As DataSet
        Try
            ds = gWs.GetItemType("{item_type='" & strItemType & "'}")
            Return ds
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '批量分配资产评估师
    Private Sub btnBatchArrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBatchArrange.Click
        setBatchEva()
    End Sub
    '批量分配
    Private Sub setBatchEva()
        Dim ds As DataSet
        Dim strSql As String
        Dim strResult As String
        Dim i, j As Integer

        ds = Me.dsOpp
        i = ds.Tables("opposite_guarantee").Rows.Count

        If i > 0 Then
            For i = 0 To i - 1
                ds.Tables("opposite_guarantee").Rows(i).Item("evaluate_person") = Workflow.GetRealTaskAttendee(EvaluationPersonRole, Me.cmbEvaluate.Text) 'Me.cmbEvaluate.Text
            Next
        End If
        strResult = gWs.UpdateGuaranty(ds.GetChanges())
        If strResult = "1" Then
            getOppGuarantee()
        Else
            'MsgBox("分配评估师失败！& strResult")
            SWDialogBox.MessageBox.Show("*999", "", strResult, "")
        End If
    End Sub
    '获得需要分配评估师的反担保物的类型
    Private Function getOppType() As ArrayList
        Dim dr As DataRow
        Dim ds As DataSet
        Dim i As Integer
        Dim strSql As String
        Dim arrayList As New ArrayList()

        strSql = "{item_type_belong ='02'}"
        Try
            ds = gWs.GetItemType(strSql)
            i = ds.Tables(0).Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    dr = ds.Tables(0).Rows(i)
                    With dr
                        If Not .Item("additional_remark") Is System.DBNull.Value Then
                            If .Item("additional_remark") = "1" Then
                                arrayList.Add(.Item("item_type"))
                            End If
                        End If
                    End With
                Next
            End If
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try
        Return arrayList
    End Function
    '设置查询反担保的选择条件
    Private Function getQuerySql() As String
        Dim i, len As Integer
        Dim strSql As String
        Dim arrayList As New ArrayList()

        arrayList = getOppType()
        len = arrayList.Count
        If len > 0 Then
            If len = 1 Then
                strSql = "guaranty_type='" & arrayList.Item(i) & "'"
            Else
                For i = 0 To len - 1
                    If i = len - 1 Then
                        strSql = strSql & "guaranty_type='" & arrayList.Item(i) & "'"
                    Else
                        strSql = strSql & "guaranty_type='" & arrayList.Item(i) & "' OR "
                    End If
                Next
            End If
            Return " and (" & strSql & ")"
        Else
            Return ""
        End If
    End Function

End Class
