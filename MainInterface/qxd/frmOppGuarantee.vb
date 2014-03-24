Public Class frmOppGuarantee
    Inherits frmBasic
    '
    'Author quexd
    'Date Created  2003-3-25
    'Modificate Date
    '

    Private strItemTypeBelong As String = "02" '表示反担保物
    Private count As Integer = 0

    Private strPhase As String = Me.getPhase(Me.getProjectCode())
    'Private strPhase As String = "代偿"

    Private totalOriginal, totalEvaluate, totalGuarantee As String
    Private dOriginal, dEvaluate, dGuarantee As Double
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents txtEvaluateNet As System.Windows.Forms.TextBox

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
    Public WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Public WithEvents cmbType As System.Windows.Forms.ComboBox
    Public WithEvents txtOriginal As System.Windows.Forms.TextBox
    Public WithEvents txtEvaluate As System.Windows.Forms.TextBox
    Public WithEvents cmbMeasure As System.Windows.Forms.ComboBox
    Public WithEvents dateEvaluate As System.Windows.Forms.DateTimePicker
    Public WithEvents txtRemark As System.Windows.Forms.TextBox
    Public WithEvents txtGuarantee As System.Windows.Forms.TextBox
    Public WithEvents dgOppGuarantee As System.Windows.Forms.DataGrid
    Public WithEvents dgDetail As System.Windows.Forms.DataGrid
    Public WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label5 As System.Windows.Forms.Label
    Public WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents Label7 As System.Windows.Forms.Label
    Public WithEvents Label9 As System.Windows.Forms.Label
    Public WithEvents Label10 As System.Windows.Forms.Label
    Public WithEvents Label11 As System.Windows.Forms.Label
    Public WithEvents txtContract As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn33 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn34 As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOppGuarantee))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgOppGuarantee = New System.Windows.Forms.DataGrid
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgDetail = New System.Windows.Forms.DataGrid
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn33 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.DataGridTextBoxColumn34 = New System.Windows.Forms.DataGridTextBoxColumn
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtEvaluateNet = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtContract = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtGuarantee = New System.Windows.Forms.TextBox
        Me.txtRemark = New System.Windows.Forms.TextBox
        Me.dateEvaluate = New System.Windows.Forms.DateTimePicker
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbMeasure = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtEvaluate = New System.Windows.Forms.TextBox
        Me.txtOriginal = New System.Windows.Forms.TextBox
        Me.cmbType = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Image)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(317, 408)
        Me.btnExit.Size = New System.Drawing.Size(80, 24)
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
        Me.ImageListBasic.Images.SetKeyName(25, "")
        Me.ImageListBasic.Images.SetKeyName(26, "")
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.dgOppGuarantee)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 240)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "反担保物记录"
        '
        'dgOppGuarantee
        '
        Me.dgOppGuarantee.CaptionVisible = False
        Me.dgOppGuarantee.DataMember = ""
        Me.dgOppGuarantee.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgOppGuarantee.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgOppGuarantee.Location = New System.Drawing.Point(3, 17)
        Me.dgOppGuarantee.Name = "dgOppGuarantee"
        Me.dgOppGuarantee.RowHeaderWidth = 10
        Me.dgOppGuarantee.Size = New System.Drawing.Size(370, 220)
        Me.dgOppGuarantee.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.dgDetail)
        Me.GroupBox3.Location = New System.Drawing.Point(384, 40)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(320, 240)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "详细信息"
        '
        'dgDetail
        '
        Me.dgDetail.CaptionVisible = False
        Me.dgDetail.DataMember = ""
        Me.dgDetail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgDetail.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgDetail.Location = New System.Drawing.Point(3, 17)
        Me.dgDetail.Name = "dgDetail"
        Me.dgDetail.RowHeaderWidth = 10
        Me.dgDetail.Size = New System.Drawing.Size(314, 220)
        Me.dgDetail.TabIndex = 0
        Me.dgDetail.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgDetail
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn33, Me.DataGridTextBoxColumn34})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "opposite_guarantee_detail"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "类目"
        Me.DataGridTextBoxColumn1.MappingName = "item_name"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.ReadOnly = True
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "描述"
        Me.DataGridTextBoxColumn2.MappingName = "item_value"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 110
        '
        'DataGridTextBoxColumn33
        '
        Me.DataGridTextBoxColumn33.Format = ""
        Me.DataGridTextBoxColumn33.FormatInfo = Nothing
        Me.DataGridTextBoxColumn33.MappingName = "item_type"
        Me.DataGridTextBoxColumn33.Width = 0
        '
        'DataGridTextBoxColumn34
        '
        Me.DataGridTextBoxColumn34.Format = ""
        Me.DataGridTextBoxColumn34.FormatInfo = Nothing
        Me.DataGridTextBoxColumn34.MappingName = "item_code"
        Me.DataGridTextBoxColumn34.Width = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.txtEvaluateNet)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtContract)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.txtGuarantee)
        Me.GroupBox4.Controls.Add(Me.txtRemark)
        Me.GroupBox4.Controls.Add(Me.dateEvaluate)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.cmbMeasure)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.txtEvaluate)
        Me.GroupBox4.Controls.Add(Me.txtOriginal)
        Me.GroupBox4.Controls.Add(Me.cmbType)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Location = New System.Drawing.Point(8, 288)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(696, 112)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "反担保物信息"
        '
        'txtEvaluateNet
        '
        Me.txtEvaluateNet.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtEvaluateNet.Location = New System.Drawing.Point(433, 80)
        Me.txtEvaluateNet.Name = "txtEvaluateNet"
        Me.txtEvaluateNet.Size = New System.Drawing.Size(90, 21)
        Me.txtEvaluateNet.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(350, 85)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 12)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "评估净值(元)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtContract
        '
        Me.txtContract.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtContract.Location = New System.Drawing.Point(496, 25)
        Me.txtContract.Name = "txtContract"
        Me.txtContract.Size = New System.Drawing.Size(192, 21)
        Me.txtContract.TabIndex = 17
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(432, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(56, 23)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "合同编码"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGuarantee
        '
        Me.txtGuarantee.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtGuarantee.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtGuarantee.Location = New System.Drawing.Point(598, 80)
        Me.txtGuarantee.Name = "txtGuarantee"
        Me.txtGuarantee.Size = New System.Drawing.Size(90, 21)
        Me.txtGuarantee.TabIndex = 14
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(72, 53)
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(312, 21)
        Me.txtRemark.TabIndex = 13
        '
        'dateEvaluate
        '
        Me.dateEvaluate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dateEvaluate.Location = New System.Drawing.Point(496, 53)
        Me.dateEvaluate.Name = "dateEvaluate"
        Me.dateEvaluate.Size = New System.Drawing.Size(192, 21)
        Me.dateEvaluate.TabIndex = 12
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 23)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "备    注"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(432, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 23)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "评估日期"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(527, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 12)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "担保额(元)"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbMeasure
        '
        Me.cmbMeasure.Location = New System.Drawing.Point(284, 25)
        Me.cmbMeasure.Name = "cmbMeasure"
        Me.cmbMeasure.Size = New System.Drawing.Size(100, 20)
        Me.cmbMeasure.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(216, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "反担保方式"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEvaluate
        '
        Me.txtEvaluate.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtEvaluate.Location = New System.Drawing.Point(254, 80)
        Me.txtEvaluate.Name = "txtEvaluate"
        Me.txtEvaluate.Size = New System.Drawing.Size(90, 21)
        Me.txtEvaluate.TabIndex = 5
        '
        'txtOriginal
        '
        Me.txtOriginal.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtOriginal.Location = New System.Drawing.Point(75, 79)
        Me.txtOriginal.Name = "txtOriginal"
        Me.txtOriginal.Size = New System.Drawing.Size(90, 21)
        Me.txtOriginal.TabIndex = 4
        '
        'cmbType
        '
        Me.cmbType.Location = New System.Drawing.Point(72, 25)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(120, 20)
        Me.cmbType.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(171, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 12)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "评估总值(元)"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 12)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "原值(元)"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "类    型"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 3000
        Me.ToolTip1.InitialDelay = 300
        Me.ToolTip1.ReshowDelay = 100
        '
        'txtName
        '
        Me.txtName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtName.Location = New System.Drawing.Point(320, 8)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(384, 21)
        Me.txtName.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(264, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "企业名称"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCode
        '
        Me.txtCode.Location = New System.Drawing.Point(64, 8)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.ReadOnly = True
        Me.txtCode.Size = New System.Drawing.Size(128, 21)
        Me.txtCode.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "项目编码"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmOppGuarantee
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(714, 435)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmOppGuarantee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "反担保物"
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.btnExit, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        Me.Controls.SetChildIndex(Me.txtCode, 0)
        Me.Controls.SetChildIndex(Me.Label2, 0)
        Me.Controls.SetChildIndex(Me.txtName, 0)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgOppGuarantee, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    '
    '获得反担保类型
    '
    Public Sub getOppGuaranteeType()
        Dim ds As DataSet
        Dim i As Integer
        Try
            ds = gWs.GetItemType("{item_type_belong='" & strItemTypeBelong & "'}")
            i = ds.Tables("TItemType").Rows.Count
            If i > 0 Then
                For i = 0 To i - 1
                    Me.cmbType.Items.Add(ds.Tables("TItemType").Rows(i).Item("type_name"))
                    Me.cmbType.SelectedIndex = 0
                Next
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '获得反担保措施
    '
    Public Sub getOppGuaranteeMeasure()
        Dim ds As DataSet
        Dim i As Integer
        Try
            ds = gWs.GetOppositeGuaranteeForm("{flag is null}")
            i = ds.Tables(0).Rows.Count
            If ds.Tables(0).Rows.Count > 0 Then
                For i = 0 To i - 1
                    Me.cmbMeasure.Items.Add(ds.Tables(0).Rows(i).Item("name"))
                Next
                Me.cmbMeasure.SelectedIndex = 0
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try

        'Try
        '    Me.cmbMeasure.Items.Add("抵押")
        '    Me.cmbMeasure.Items.Add("质押")
        '    If Me.cmbMeasure.Items.Count > 0 Then
        '        Me.cmbMeasure.SelectedIndex = 0
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message, MsgBoxStyle.Exclamation, ex.Source)
        'End Try
    End Sub
    '
    ' 根据project_code获得反担保物记录
    '
    Public Function getOppGuaranteeRecord(ByVal strProjectCode As String) As DataSet
        Return getOppGuaranteeRecord(strProjectCode, "0")
    End Function
    Public Function getOppGuaranteeRecord(ByVal strProjectCode As String, ByVal flag As String) As DataSet
        dOriginal = 0.0
        dEvaluate = 0.0
        dGuarantee = 0.0
        totalOriginal = 0.0
        totalEvaluate = 0.0
        totalGuarantee = 0.0
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
    '获得原值
    Protected Function getOriginalTotal()
        Return dOriginal
    End Function
    '获得评估值
    Protected Function getEvaluateTotal()
        Return dEvaluate
    End Function
    '获得担保额
    Protected Function getGuaranteeTotal()
        Return dGuarantee
    End Function
    '
    '获得Item表的DataSet
    '
    Public Function getItemDataSet(ByVal strItemType As String) As DataSet
        Dim ds As DataSet
        Try
            ds = gWs.GetItem("{item_type='" & strItemType & "'}", Nothing)
            Return ds
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '
    '获得ItemType表的DataSet
    '
    Public Function getItemTypeDataSet(ByVal strItemType As String) As DataSet
        Dim ds As DataSet
        Try
            ds = gWs.GetItemType("{item_type='" & strItemType & "'}")
            Return ds
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '
    '根据project_code 和 serial_num、guaranty_type从opposite_guarantee_detail，获得详细信息
    '
    Public Function getOppGuaranteeDetail(ByVal strProjectCode As String, ByVal strSerialNum As String, ByVal strItemType As String) As DataSet

        Dim ds As DataSet
        Dim dsItem, dsItemType As DataSet
        Dim strType, strItemCode As String
        Dim len As Integer

        Try
            ds = gWs.GetGuarantyInfo("null", "{project_code ='" & strProjectCode & "' and serial_num='" & strSerialNum & "' and item_type='" & strItemType & "'}")
            ds.Tables("opposite_guarantee_detail").Columns.Add("type_name", GetType(String))
            ds.Tables("opposite_guarantee_detail").Columns.Add("item_name", GetType(String))

            dsItem = getItemDataSet(strItemType)
            dsItemType = getItemTypeDataSet(strItemType)
            Dim j As Integer
            len = ds.Tables("opposite_guarantee_detail").Rows.Count
            count = len
            Try
                If len > 0 Then
                    For j = 0 To len - 1
                        Dim str_item_code, str_item_type As String
                        str_item_code = ds.Tables("opposite_guarantee_detail").Rows(j).Item("item_code")
                        str_item_type = ds.Tables("opposite_guarantee_detail").Rows(j).Item("item_type")

                        If dsItem.Tables("TItem").Select("item_code='" & str_item_code & "' and item_type='" & str_item_type & "'").Length > 0 Then
                            ds.Tables("opposite_guarantee_detail").Rows(j).Item("item_name") = dsItem.Tables("TItem").Select("item_code='" & str_item_code & "' and item_type='" & str_item_type & "'")(0).Item("item_name")
                        Else
                            ds.Tables("opposite_guarantee_detail").Rows(j).Item("item_name") = "未知"
                        End If
                        If dsItemType.Tables("TItemType").Select("item_type='" & str_item_type & "'").Length > 0 Then
                            ds.Tables("opposite_guarantee_detail").Rows(j).Item("type_name") = dsItemType.Tables("TItemType").Select("item_type='" & str_item_type & "'")(0).Item("type_name")
                        Else
                            ds.Tables("opposite_guarantee_detail").Rows(j).Item("type_name") = "未知"
                        End If
                    Next
                End If
            Catch ex As Exception
                'MsgBox("获取反担保物类型出错!", MsgBoxStyle.Critical, "提示")
                ExceptionHandler.ShowMessageBox(ex)
            End Try

            Return ds
        Catch ex As Exception
        End Try
    End Function
    '
    '设置dg不能自动增加行
    '
    Public Sub setDgAttribute(ByVal dGrid As DataGrid)
        Dim cm As CurrencyManager
        Try
            cm = CType(Me.BindingContext(dGrid.DataSource, dGrid.DataMember), CurrencyManager)
            Dim dv As DataView = New DataView()
            dv = CType(cm.List, DataView)
            dv.AllowNew = False  '不允许自增
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub
    '
    '根据guaranty_type，获得相应的item_name
    '
    Public Function getGuaranteeType(ByVal strGuarantyType) As String
        Dim ds As DataSet
        Try
            ds = gWs.GetItemType(strGuarantyType)
            If ds.Tables("TItemType").Rows.Count > 0 Then
                Return ds.Tables("TItemType").Rows(0).Item("type_name")
            Else
                Return strGuarantyType
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '
    '根据item_name获得相应的item_type
    '
    Public Function getGuaranteeCode(ByVal strType) As String
        Dim ds As DataSet
        Try
            ds = gWs.GetItemType("{type_name='" & strType & "'}")
            If ds.Tables("TItemType").Rows.Count > 0 Then
                Return ds.Tables("TItemType").Rows(0).Item("item_type")
            Else
                Return strType
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '
    '根据opposite_guarantee_form中的form_code，获得相应的name
    '
    Public Function getGuaranteeForm(ByVal strFormCode As String) As String
        Dim ds As DataSet
        Try
            ds = gWs.GetOppositeGuaranteeForm("{form_code='" & strFormCode & "'}")
            If ds.Tables(0).Rows.Count > 0 Then
                Return ds.Tables(0).Rows(0).Item("name")
            Else
                Return strFormCode
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Function
    '
    '根据opposite_guarantee_form中的name，获得相应的code
    '
    Public Function getGuaranteeFormCode(ByVal strFormName As String) As String
        Dim ds As DataSet
        Try
            ds = gWs.GetOppositeGuaranteeForm("{name='" & strFormName & "'}")
            If ds.Tables(0).Rows.Count > 0 Then
                'Return ds.Tables(0).Rows(0).Item("form_code")
                Return strFormName
            Else
                Return strFormName
            End If
        Catch ex As Exception
            'MsgBox(ex.Message)
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Function
    'KeyPress事件
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOriginal.KeyPress, txtEvaluate.KeyPress, txtGuarantee.KeyPress, txtEvaluateNet.KeyPress
        Try
            Money_KeyPress(sender, e)
        Catch ex As Exception
        End Try
    End Sub
    '离开TextBox触发的事件
    Private Sub txt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOriginal.Leave, txtEvaluate.Leave, txtGuarantee.Leave, txtEvaluateNet.Leave
        Try
            Money_Leave(sender, e)
        Catch ex As Exception
        End Try

        'txtOriginal.DataBindings.Clear()
        'Dim currentIndex As Integer
        'currentIndex = Me.dgOppGuarantee.CurrentRowIndex
        'If Me.dgOppGuarantee.Item(Me.dgOppGuarantee.CurrentRowIndex, 8) = "21" Then
        '    setEstate(CType(Me.dgDetail.DataSource, DataTable), CType(Me.dgOppGuarantee.DataSource, DataTable), currentIndex)
        'ElseIf Me.dgOppGuarantee.Item(Me.dgOppGuarantee.CurrentRowIndex, 8) = "23" Then
        '    setMachineryEquipment(CType(Me.dgDetail.DataSource, DataTable), CType(Me.dgOppGuarantee.DataSource, DataTable), currentIndex)
        'End If
        'Me.txtOriginal.DataBindings.Add("Text", Me.dgOppGuarantee.DataSource, "original_value")

    End Sub
    '获得记录数
    Public Function getCount() As Integer
        Return count
    End Function
    '进入TextBox触发的事件
    Private Sub txt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtOriginal.Enter, txtEvaluate.Enter, txtGuarantee.Enter, txtEvaluateNet.Enter
        Try
            Money_Enter(sender, e)
        Catch ex As Exception
        End Try
    End Sub
    '根据反担保物类型,设置是否可以输入评估值\
    Public Sub setEvaTextEnabled(ByVal dsOpp As DataSet)
        Dim strItemType As String
        Dim ds As DataSet
        Dim dr As DataRow
        Dim i, currentIdx As Integer
        Try
            currentIdx = Me.dgOppGuarantee.CurrentRowIndex
            strItemType = dsOpp.Tables("opposite_guarantee").Rows(currentIdx).Item("guaranty_type")
            ds = gWs.GetItemType(strItemType)
            i = ds.Tables(0).Rows.Count
            If i > 0 Then
                dr = ds.Tables(0).Rows(0)
                With dr
                    If Not .Item("additional_remark") Is System.DBNull.Value Then
                        If .Item("additional_remark") = "1" Then
                            Me.txtEvaluate.Enabled = True
                            Me.txtEvaluateNet.Enabled = True
                            Me.txtGuarantee.ReadOnly = False
                        Else
                            Me.txtEvaluate.Enabled = False
                            Me.txtEvaluateNet.Enabled = False
                            Me.txtGuarantee.ReadOnly = False
                        End If
                    Else
                        Me.txtEvaluate.Enabled = False
                        Me.txtEvaluateNet.Enabled = False
                        Me.txtGuarantee.ReadOnly = False
                    End If
                End With
            Else
                Me.txtEvaluate.Enabled = False
                Me.txtEvaluateNet.Enabled = False
                Me.txtGuarantee.ReadOnly = False
            End If
        Catch ex As Exception
        Finally
        End Try
    End Sub

    '获得原值
    Private Function getOriginalValue(ByVal dt As DataTable, ByVal index As Integer) As String
        If Not dt Is Nothing Then
            Dim strSql As String
            If dt.Rows(index).Item("original_value") Is System.DBNull.Value Then
                Return "0.0"
            Else
                Return dt.Rows(index).Item("original_value")
            End If
        End If
    End Function
    '设置评估值,担保额
    Private Sub setOppValue(ByVal dt As DataTable, ByVal index As Integer, ByVal itemName As String, ByVal value As String)
        If Not dt Is Nothing Then
            If value = "" Then
                value = "0.0"
            End If
            dt.Rows(index).Item(itemName) = value
        End If
    End Sub
    '获得科目的值
    Private Function getItemValue(ByVal dt As DataTable, ByVal itemType As String, ByVal itemCode As String)
        If Not dt Is Nothing Then
            Dim strSql As String
            strSql = "item_type='" & itemType & "' and item_code='" & itemCode & "'"
            Return IIf(dt.Select(strSql)(0).Item("item_value") Is DBNull.Value, "", dt.Select(strSql)(0).Item("item_value"))
        End If
    End Function
    '设置科目的值
    Private Sub setItemValue(ByVal dt As DataTable, ByVal itemType As String, ByVal itemCode As String, ByVal value As String)
        If Not dt Is Nothing Then
            Dim strSql As String
            strSql = "item_type='" & itemType & "' and item_code='" & itemCode & "'"
            dt.Select(strSql)(0).Item("item_value") = value
        End If
    End Sub
    '房地产
    Public Sub setEstate(ByVal dt As DataTable, ByVal dtOpp As DataTable, ByVal index As Integer)
        Dim strSquareMeter, strDiscountRate, strArea, strOriginal As String
        Dim dSquareMeter, dDiscountRate, dArea, dOriginal As Double

        strSquareMeter = getItemValue(dt, "21", "011")
        strDiscountRate = getItemValue(dt, "21", "007")
        strArea = getItemValue(dt, "21", "004")
        strOriginal = getOriginalValue(dtOpp, index)
        '每平米价=每平米评估价
        '原值/面积(004)=每平米原值(010)
        '面积*每平米价(011)=评估值
        '评估值*打折系数=担保额
        '每平米价*打折系数(007)=担保每平米价(012)
        '评估值＝面积×每平米评估价
        '担保额＝评估值×打折系数
        Try
            If strSquareMeter = "" Then
                dSquareMeter = 0.0
            Else
                dSquareMeter = CType(strSquareMeter, Double)
            End If
            If strDiscountRate = "" Then
                dDiscountRate = 0.0
            Else
                dDiscountRate = CType(strDiscountRate, Double)
            End If
            If strArea = "" Then
                dArea = 0.0
            Else
                dArea = CType(strArea, Double)
            End If
            If strOriginal = "" Then
                dOriginal = 0.0
            Else
                dOriginal = CType(strOriginal, Double)
            End If
        Catch
            Exit Sub
        Finally
        End Try
        'Dim d As Double = 53453.53245324
        'd.ToString("c", CGFormatInfo)
        setItemValue(dt, "21", "010", Format(dOriginal / dArea, ".##"))
        setOppValue(dtOpp, index, "evaluate_value", Format(dArea * dSquareMeter, ".##"))
        Me.txtEvaluate.Text = Format(dArea * dSquareMeter, ".##")
       
        setOppValue(dtOpp, index, "guarantee_value", Format(dArea * dSquareMeter * dDiscountRate / 100.0, ".##"))
        Me.txtGuarantee.Text = Format(dArea * dSquareMeter * dDiscountRate / 100.0, ".##")
        setItemValue(dt, "21", "012", Format(dSquareMeter * dDiscountRate / 100.0, ".##"))
    End Sub
    '机械设备
    Public Sub setMachineryEquipment(ByVal dt As DataTable, ByVal dtOpp As DataTable, ByVal index As Integer)
        Dim strDiscountRate, strDepreciate, strOriginal As String
        Dim dDiscountRate, dDepreciate, dOriginal As Double

        strDiscountRate = getItemValue(dt, "23", "008")
        strDepreciate = getItemValue(dt, "23", "007")
        strOriginal = getOriginalValue(dtOpp, index)
        '评估值＝原值×折旧率
        '担保额评估值×打折系数
        Try
            If strDiscountRate = "" Then
                dDiscountRate = 0.0
            Else
                dDiscountRate = CType(strDiscountRate, Double)
            End If
            If strDepreciate = "" Then
                dDepreciate = 0.0
            Else
                dDepreciate = CType(strDepreciate, Double)
            End If
            If strOriginal = "" Then
                dOriginal = 0.0
            Else
                dOriginal = CType(strOriginal, Double)
            End If
        Catch
            Exit Sub
        Finally
        End Try

        setOppValue(dtOpp, index, "evaluate_value", Format(dOriginal * dDepreciate / 100.0, ".##"))
        Me.txtEvaluate.Text = Format(dOriginal * dDepreciate / 100.0, ".##")
        'add   yansm   
        Me.txtEvaluate.Text = Format(dOriginal * dDepreciate * 0.9 / 100.0, ".##")
        setOppValue(dtOpp, index, "guarantee_value", Format(dOriginal * dDepreciate / 100.0 * dDiscountRate / 100.0, ".##"))
        Me.txtGuarantee.Text = Format(dOriginal * dDepreciate / 100.0 * dDiscountRate / 100.0, ".##")

    End Sub
    '汽车
    Public Sub setAutocar(ByVal dt As DataTable, ByVal dtOpp As DataTable, ByVal index As Integer)
        Dim strDiscountRate, strDepreciate, strOriginal As String
        Dim dDiscountRate, dDepreciate, dOriginal As Double

        strDiscountRate = getItemValue(dt, "22", "006")
        strDepreciate = getItemValue(dt, "22", "005")
        strOriginal = getOriginalValue(dtOpp, index)
        '评估值＝原值×折旧率（成新率）
        '担保额评估值×打折系数
        Try
            If strDiscountRate = "" Then
                dDiscountRate = 0.0
            Else
                dDiscountRate = CType(strDiscountRate, Double)
            End If
            If strDepreciate = "" Then
                dDepreciate = 0.0
            Else
                dDepreciate = CType(strDepreciate, Double)
            End If
            If strOriginal = "" Then
                dOriginal = 0.0
            Else
                dOriginal = CType(strOriginal, Double)
            End If
        Catch
            Exit Sub
        Finally
        End Try
        setOppValue(dtOpp, index, "evaluate_value", Format(dOriginal * dDepreciate / 100.0, ".##"))
        Me.txtEvaluate.Text = Format(dOriginal * dDepreciate / 100.0, ".##")
      
        setOppValue(dtOpp, index, "guarantee_value", Format(dOriginal * dDepreciate / 100.0 * dDiscountRate / 100.0, ".##"))
        Me.txtGuarantee.Text = Format(dOriginal * dDepreciate / 100.0 * dDiscountRate / 100.0, ".##")
    End Sub
    '添加datagrid的style
    Public Sub addStyle(ByVal ds As DataSet)
        Dim tableStyle As DataGridTableStyle = New DataGridTableStyle()
        tableStyle.MappingName = "opposite_guarantee_detail"
        tableStyle.AllowSorting = False
        tableStyle.RowHeadersVisible = True

        Dim numCols As Integer = ds.Tables("opposite_guarantee_detail").Columns.Count
        Dim dgc As New DataGridColoredTextBoxColumn()
        Dim d As delegateGetColorRowCol = New delegateGetColorRowCol(AddressOf dgc.MyGetColorRowCol)

        Dim column_1 As New DataGridTextBoxColumn()
        column_1.Width = 120
        column_1.ReadOnly = True
        column_1.NullText = ""
        column_1.HeaderText = "类目"
        column_1.MappingName = "item_name"
        tableStyle.GridColumnStyles.Add(column_1)

        Dim bColumnTextColumn As DataGridColoredTextBoxColumn
        bColumnTextColumn = New DataGridColoredTextBoxColumn(d)
        bColumnTextColumn.HeaderText = "描述"
        bColumnTextColumn.Width = 140
        bColumnTextColumn.NullText = ""
        bColumnTextColumn.ReadOnly = True
        bColumnTextColumn.MappingName = "item_value"
        tableStyle.GridColumnStyles.Add(bColumnTextColumn)

        Me.dgDetail.TableStyles.Clear()
        Me.dgDetail.TableStyles.Add(tableStyle)
    End Sub

End Class
