

Public Class frmDevolveOnProject
    Inherits MainInterface.frmMaterial

    Private strProjectCode As String
    Private strCorporationName As String
    Private strWorkFlowID As String
    Private strTaskID As String
    Private strPerson As String
    Private strPhase As String

    Private dsMaterial As DataSet
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
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn1 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridBoolColumn2 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridBoolColumn3 As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtReviewDate As System.Windows.Forms.TextBox
    Friend WithEvents txtApplyDate As System.Windows.Forms.TextBox
    Friend WithEvents txtConsultDate As System.Windows.Forms.TextBox
    Friend WithEvents txtAssignType As System.Windows.Forms.TextBox
    Friend WithEvents txtGuaranteeSum As System.Windows.Forms.TextBox
    Friend WithEvents txtServiceType As System.Windows.Forms.TextBox
    Friend WithEvents txtApplyPerson As System.Windows.Forms.TextBox
    Friend WithEvents txtConsultPerson As System.Windows.Forms.TextBox
    Friend WithEvents txtGetFeeDate As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtTerms As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmDevolveOnProject))
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridBoolColumn1 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridBoolColumn2 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridBoolColumn3 = New System.Windows.Forms.DataGridBoolColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtTerms = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtGetFeeDate = New System.Windows.Forms.TextBox()
        Me.txtReviewDate = New System.Windows.Forms.TextBox()
        Me.txtApplyDate = New System.Windows.Forms.TextBox()
        Me.txtConsultDate = New System.Windows.Forms.TextBox()
        Me.txtAssignType = New System.Windows.Forms.TextBox()
        Me.txtGuaranteeSum = New System.Windows.Forms.TextBox()
        Me.txtServiceType = New System.Windows.Forms.TextBox()
        Me.txtApplyPerson = New System.Windows.Forms.TextBox()
        Me.txtConsultPerson = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(16, 348)
        Me.GroupBox3.Size = New System.Drawing.Size(8, 76)
        Me.GroupBox3.Visible = True
        '
        'cmbContent
        '
        Me.cmbContent.ItemHeight = 12
        Me.cmbContent.Location = New System.Drawing.Point(368, -32)
        Me.cmbContent.TabIndex = 1
        Me.cmbContent.Text = "已确认资料"
        Me.cmbContent.Visible = True
        '
        'chbCheck
        '
        Me.chbCheck.Visible = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(8, 184)
        Me.GroupBox2.Size = New System.Drawing.Size(696, 280)
        Me.GroupBox2.Visible = True
        '
        'chbImportant
        '
        Me.chbImportant.Visible = True
        '
        'txtCode
        '
        Me.txtCode.Visible = True
        '
        'txtPerson
        '
        Me.txtPerson.Visible = True
        '
        'Label5
        '
        Me.Label5.Visible = True
        '
        'Label7
        '
        Me.Label7.Visible = True
        '
        'chbFile
        '
        Me.chbFile.Visible = True
        '
        'dateCheck
        '
        Me.dateCheck.Value = New Date(2003, 4, 10, 11, 5, 18, 171)
        Me.dateCheck.Visible = True
        '
        'Label10
        '
        Me.Label10.Visible = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(280, -32)
        Me.Label4.Size = New System.Drawing.Size(64, 31)
        Me.Label4.Visible = True
        '
        'Label9
        '
        Me.Label9.Visible = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, -32)
        Me.Label3.Size = New System.Drawing.Size(40, 31)
        Me.Label3.Visible = True
        '
        'Label8
        '
        Me.Label8.Visible = True
        '
        'Label2
        '
        Me.Label2.Visible = True
        '
        'Label11
        '
        Me.Label11.Visible = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(3, 16)
        Me.Panel1.Size = New System.Drawing.Size(690, 256)
        Me.Panel1.Visible = True
        '
        'txtRemark
        '
        Me.txtRemark.Visible = True
        '
        'dgMaterial
        '
        Me.dgMaterial.AccessibleName = "DataGrid"
        Me.dgMaterial.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.dgMaterial.Size = New System.Drawing.Size(690, 256)
        Me.dgMaterial.TabIndex = 2
        Me.dgMaterial.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.dgMaterial.Visible = True
        '
        'txtName
        '
        Me.txtName.Size = New System.Drawing.Size(312, 21)
        Me.txtName.Visible = True
        '
        'txtMaterial
        '
        Me.txtMaterial.Visible = True
        '
        'cmbType
        '
        Me.cmbType.ItemHeight = 12
        Me.cmbType.Location = New System.Drawing.Point(88, -32)
        Me.cmbType.TabIndex = 0
        Me.cmbType.Visible = True
        '
        'Label1
        '
        Me.Label1.Visible = True
        '
        'Label6
        '
        Me.Label6.Visible = True
        '
        'ImageListBasic
        '
        Me.ImageListBasic.ImageStream = CType(resources.GetObject("ImageListBasic.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.Location = New System.Drawing.Point(361, 472)
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.Visible = True
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(273, 472)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 24)
        Me.btnCommit.TabIndex = 2
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.AllowSorting = False
        Me.DataGridTableStyle1.DataGrid = Me.dgMaterial
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridBoolColumn1, Me.DataGridBoolColumn2, Me.DataGridBoolColumn3, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TProjectDocument"
        Me.DataGridTableStyle1.RowHeadersVisible = False
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
        Me.DataGridBoolColumn1.ReadOnly = True
        Me.DataGridBoolColumn1.TrueValue = True
        Me.DataGridBoolColumn1.Width = 50
        '
        'DataGridBoolColumn2
        '
        Me.DataGridBoolColumn2.AllowNull = False
        Me.DataGridBoolColumn2.FalseValue = False
        Me.DataGridBoolColumn2.HeaderText = "交接"
        Me.DataGridBoolColumn2.MappingName = "is_affirm"
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
        Me.DataGridBoolColumn3.ReadOnly = True
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
        Me.DataGridTextBoxColumn4.HeaderText = "日期"
        Me.DataGridTextBoxColumn4.MappingName = "check_date"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox4.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtTerms, Me.Label21, Me.txtGetFeeDate, Me.txtReviewDate, Me.txtApplyDate, Me.txtConsultDate, Me.txtAssignType, Me.txtGuaranteeSum, Me.txtServiceType, Me.txtApplyPerson, Me.txtConsultPerson, Me.Label20, Me.Label19, Me.Label18, Me.Label17, Me.Label16, Me.Label15, Me.Label14, Me.Label13, Me.Label12})
        Me.GroupBox4.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(696, 136)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'txtTerms
        '
        Me.txtTerms.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtTerms.Location = New System.Drawing.Point(576, 51)
        Me.txtTerms.Name = "txtTerms"
        Me.txtTerms.ReadOnly = True
        Me.txtTerms.Size = New System.Drawing.Size(112, 21)
        Me.txtTerms.TabIndex = 19
        Me.txtTerms.Text = ""
        '
        'Label21
        '
        Me.Label21.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label21.Location = New System.Drawing.Point(456, 48)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(120, 23)
        Me.Label21.TabIndex = 18
        Me.Label21.Text = "申请担保期限(月)"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGetFeeDate
        '
        Me.txtGetFeeDate.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtGetFeeDate.Location = New System.Drawing.Point(336, 103)
        Me.txtGetFeeDate.Name = "txtGetFeeDate"
        Me.txtGetFeeDate.ReadOnly = True
        Me.txtGetFeeDate.Size = New System.Drawing.Size(112, 21)
        Me.txtGetFeeDate.TabIndex = 17
        Me.txtGetFeeDate.Text = ""
        '
        'txtReviewDate
        '
        Me.txtReviewDate.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtReviewDate.Location = New System.Drawing.Point(336, 51)
        Me.txtReviewDate.Name = "txtReviewDate"
        Me.txtReviewDate.ReadOnly = True
        Me.txtReviewDate.Size = New System.Drawing.Size(112, 21)
        Me.txtReviewDate.TabIndex = 16
        Me.txtReviewDate.Text = ""
        '
        'txtApplyDate
        '
        Me.txtApplyDate.Location = New System.Drawing.Point(64, 104)
        Me.txtApplyDate.Name = "txtApplyDate"
        Me.txtApplyDate.ReadOnly = True
        Me.txtApplyDate.Size = New System.Drawing.Size(152, 21)
        Me.txtApplyDate.TabIndex = 15
        Me.txtApplyDate.Text = ""
        '
        'txtConsultDate
        '
        Me.txtConsultDate.Location = New System.Drawing.Point(64, 25)
        Me.txtConsultDate.Name = "txtConsultDate"
        Me.txtConsultDate.ReadOnly = True
        Me.txtConsultDate.Size = New System.Drawing.Size(152, 21)
        Me.txtConsultDate.TabIndex = 14
        Me.txtConsultDate.Text = ""
        '
        'txtAssignType
        '
        Me.txtAssignType.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtAssignType.Location = New System.Drawing.Point(336, 77)
        Me.txtAssignType.Name = "txtAssignType"
        Me.txtAssignType.ReadOnly = True
        Me.txtAssignType.Size = New System.Drawing.Size(112, 21)
        Me.txtAssignType.TabIndex = 13
        Me.txtAssignType.Text = ""
        '
        'txtGuaranteeSum
        '
        Me.txtGuaranteeSum.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtGuaranteeSum.Location = New System.Drawing.Point(576, 24)
        Me.txtGuaranteeSum.Name = "txtGuaranteeSum"
        Me.txtGuaranteeSum.ReadOnly = True
        Me.txtGuaranteeSum.Size = New System.Drawing.Size(112, 21)
        Me.txtGuaranteeSum.TabIndex = 12
        Me.txtGuaranteeSum.Text = ""
        Me.txtGuaranteeSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtServiceType
        '
        Me.txtServiceType.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtServiceType.Location = New System.Drawing.Point(336, 25)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(112, 21)
        Me.txtServiceType.TabIndex = 11
        Me.txtServiceType.Text = ""
        '
        'txtApplyPerson
        '
        Me.txtApplyPerson.Location = New System.Drawing.Point(64, 77)
        Me.txtApplyPerson.Name = "txtApplyPerson"
        Me.txtApplyPerson.ReadOnly = True
        Me.txtApplyPerson.Size = New System.Drawing.Size(152, 21)
        Me.txtApplyPerson.TabIndex = 10
        Me.txtApplyPerson.Text = ""
        '
        'txtConsultPerson
        '
        Me.txtConsultPerson.Location = New System.Drawing.Point(64, 51)
        Me.txtConsultPerson.Name = "txtConsultPerson"
        Me.txtConsultPerson.ReadOnly = True
        Me.txtConsultPerson.Size = New System.Drawing.Size(152, 21)
        Me.txtConsultPerson.TabIndex = 9
        Me.txtConsultPerson.Text = ""
        '
        'Label20
        '
        Me.Label20.Location = New System.Drawing.Point(240, 102)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 23)
        Me.Label20.TabIndex = 8
        Me.Label20.Text = "预收评审费时间"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(240, 48)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(80, 23)
        Me.Label19.TabIndex = 7
        Me.Label19.Text = "初审审核日期"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Location = New System.Drawing.Point(240, 76)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 23)
        Me.Label18.TabIndex = 6
        Me.Label18.Text = "初审分配类型"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.Label17.Location = New System.Drawing.Point(456, 24)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(120, 23)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "申请担保金额(万元)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(240, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 23)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "申请业务品种"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(8, 72)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 23)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "受理人员"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(8, 104)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 23)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "受理日期"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(8, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 23)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "咨询人员"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(8, 24)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 23)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "咨询时间"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmDevolveOnProject
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 503)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.txtName, Me.Label1, Me.txtCode, Me.btnExit, Me.GroupBox3, Me.GroupBox2, Me.GroupBox4, Me.btnCommit})
        Me.Name = "frmDevolveOnProject"
        Me.Text = "交接登记"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    'Load()
    Private Sub frmDevolveOnProject_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        Me.dsMaterial = setDgDataSource(strProjectCode, False)
        If Not dsMaterial Is Nothing Then
            Me.setCheckIsTrue(dsMaterial, "is_affirm")
            addStyle(Me.dsMaterial)
        End If
        setDevolveProjectInfo()
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
        aColumnTextColumn.Width = 0
        aColumnTextColumn.MappingName = "is_check"
        tableStyle.GridColumnStyles.Add(aColumnTextColumn)

        Dim bColumnTextColumn As DataGridColoredBoolColumn
        bColumnTextColumn = New DataGridColoredBoolColumn(d, 0)
        bColumnTextColumn.HeaderText = "交接"
        bColumnTextColumn.AllowNull = False
        bColumnTextColumn.MappingName = "is_affirm"
        tableStyle.GridColumnStyles.Add(bColumnTextColumn)

        Dim column_2 As New DataGridTextBoxColumn()
        column_2.ReadOnly = True
        column_2.Width = 0
        column_2.NullText = ""
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
        column_4.HeaderText = "责任人"
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
    '退出
    '
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
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
                Call saveDevolveAffirm(gWs)
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
    '点击datagrid，设置text内容
    Private Sub setTextContent()
        Static lastRow As Integer = -1
        Me.dgMaterial.Select(Me.dgMaterial.CurrentCell.RowNumber)
        If Me.dgMaterial.CurrentRowIndex <> lastRow Then
            Try
                If Not Me.dsMaterial.Tables("TProjectDocument").Rows(Me.dgMaterial.CurrentCell.RowNumber).Item("is_affirm") Is System.DBNull.Value Then
                    If Not Me.dsMaterial.Tables("TProjectDocument").Rows(Me.dgMaterial.CurrentCell.RowNumber).Item("is_affirm") Then
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
            If colNum = 2 Then
                isLoad = False
                Dim he As DataGrid = CType(sender, DataGrid)
                If he.HitTest(e.X, e.Y).Type <> DataGrid.HitTestType.Cell Then Return
                Me.dgMaterial.Item(rowNum, colNum) = Not Me.dgMaterial.Item(rowNum, colNum)
            End If
            setTextContent()
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
        If isAccreditCommit() Then
            'MsgBox("有未确认交接材料,不能提交!", MsgBoxStyle.Exclamation, "提示")
            SWDialogBox.MessageBox.Show("$1009", "")
            Exit Sub
        End If
        Dim isSaveSucceed As Boolean = False
        isSaveSucceed = saveDevolveAffirm(gWs)
        If isSaveSucceed Then
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
            'MsgBox("交接登记保存失败!", MsgBoxStyle.Critical, "提示")
            SWDialogBox.MessageBox.Show("*999", "", "", "")
        End If
    End Sub
    '
    '保存交接登记的Affirm_person,Affirm_date
    '
    Private Function saveDevolveAffirm(ByVal gWs As htfServer.Service1)
        Try
            If Not Me.dsMaterial Is Nothing Then
                Dim i As Integer
                Dim dr As DataRow
                Dim strResult As String
                i = dsMaterial.Tables("TProjectDocument").Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = dsMaterial.Tables("TProjectDocument").Rows(i)
                        With dr
                            If Not .Item("is_affirm") Is System.DBNull.Value Then
                                If .Item("is_affirm") = True Then
                                    .Item("affirm_person") = strPerson
                                    Try
                                        .Item("affirm_date") = gWs.GetSysTime()
                                    Catch ex As Exception
                                        ExceptionHandler.ShowMessageBox(ex)
                                    End Try
                                Else
                                        .Item("affirm_person") = System.DBNull.Value
                                        .Item("affirm_date") = System.DBNull.Value
                                End If
                            Else
                                .Item("affirm_person") = System.DBNull.Value
                                .Item("affirm_date") = System.DBNull.Value
                            End If
                        End With
                    Next
                    strResult = gWs.UpdateProjectDocument(dsMaterial)
                End If
                If strResult = "1" Then
                    Me.dsMaterial = setDgDataSource(strProjectCode, False)
                    Return True
                Else
                    Return False
                End If
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        Finally
        End Try
    End Function
    'KeyPress()
    Private Sub frmDevolveOnProject_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        Me.setEnterKeyPress(sender, e)
    End Sub
    'Closing()
    Private Sub frmDevolveOnProject_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If sender.GetType Is GetType(Form) Then
            If frmExit(sender, e) Then
                e.Cancel = True
            End If
        End If
    End Sub
    '设置交接登记的显示信息
    Private Sub setDevolveProjectInfo()
        Dim ds As DataSet
        Dim dr As DataRow
        Dim strSql As String
        Dim i As Integer
        If gWs Is Nothing Then
            Exit Sub
        End If
        Try
            strSql = "SELECT TOP 1 * FROM DevelveProjectInfo WHERE project_code LIKE '" & strProjectCode & "' ORDER BY consult_date DESC"
            ds = gWs.GetCommonQueryInfo(strSql)
            i = ds.Tables(0).Rows.Count
            If i > 0 Then
                dr = ds.Tables(0).Rows(0)
                With dr
                    Me.txtConsultDate.Text = IIf(.Item("consult_date") Is System.DBNull.Value, "", CType(.Item("consult_date"), Date).ToLongDateString)
                    Me.txtConsultPerson.Text = IIf(.Item("consult_person") Is System.DBNull.Value, "", .Item("consult_person"))
                    Me.txtApplyDate.Text = IIf(.Item("accept_date") Is System.DBNull.Value, "", CType(.Item("accept_date"), Date).ToLongDateString)
                    Me.txtApplyPerson.Text = IIf(.Item("accept_person") Is System.DBNull.Value, "", .Item("accept_person"))
                    Me.txtServiceType.Text = IIf(.Item("apply_service_type") Is System.DBNull.Value, "", .Item("apply_service_type"))
                    Me.txtGuaranteeSum.Text = IIf(.Item("guarantee_sum") Is System.DBNull.Value, "", .Item("guarantee_sum"))
                    Me.txtTerms.Text = IIf(.Item("terms") Is System.DBNull.Value, "", .Item("terms"))
                    Me.txtAssignType.Text = IIf(.Item("first_assign_type") Is System.DBNull.Value, "", .Item("first_assign_type"))
                    Me.txtReviewDate.Text = IIf(.Item("first_trial_date") Is System.DBNull.Value, "", CType(.Item("first_trial_date"), Date).ToLongDateString)
                    Me.txtGetFeeDate.Text = IIf(.Item("get_fee_date") Is System.DBNull.Value, "", CType(.Item("get_fee_date"), Date).ToLongDateString)
                End With
            End If
        Catch ex As Exception
        End Try
    End Sub
    '
    '判断基本的交接项是否已确认
    '如果有一个没有确认"交接",则返回true
    '
    Private Function isAccreditCommit()
        If Not Me.dsMaterial Is Nothing Then
            Dim i As Integer
            Dim dr As DataRow
            Dim isNotChecked As Boolean = False
            Try
                i = Me.dsMaterial.Tables("TProjectDocument").Rows.Count
                If i > 0 Then
                    For i = 0 To i - 1
                        dr = Me.dsMaterial.Tables("TProjectDocument").Rows(i)
                        With dr
                            If Not .Item("is_affirm") Is System.DBNull.Value Then
                                If Not .Item("is_affirm") Then
                                    isNotChecked = True
                                End If
                            End If
                        End With
                    Next
                End If
            Catch
            End Try
            Return isNotChecked
        End If
    End Function
End Class
