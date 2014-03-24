'作者：罗庆锋；日期2003-04-05
Public Class frmProjectReturnPlan
    Inherits frmBasic


    Private strStatus As String = String.Empty
    Private TaskID As String
    Private ProjectCode As String
    Private WorkFlowID As String
    Private CorporationName As String
    Private dsAccountDetail As DataSet
    Private item_type As String
    Private item_code As String
    Private LoanSum As Double
    Private bmPlan As BindingManagerBase
    Private SystemDate As DateTime
    Private OriginalMoney As String
    Private RefundType As String   '还款方式的编码值
    Private EndDate As Date
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()
    End Sub

    '窗体重写处置以清理组件列表。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If Not dsAccountDetail Is Nothing Then
            dsAccountDetail.Dispose()
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
    Public WithEvents txtCorName As System.Windows.Forms.TextBox
    Public WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgShow As System.Windows.Forms.DataGrid
    Friend WithEvents gpbxPlan As System.Windows.Forms.GroupBox
    Friend WithEvents txtAbstract As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRefundType As System.Windows.Forms.TextBox
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtLoanSum As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents btnCreatePlan As System.Windows.Forms.Button
    Friend WithEvents btnCommit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnNew As System.Windows.Forms.Button
    Friend WithEvents txtEachReturn As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpFirstDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents gpbxDG As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMonth As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtShowMoney As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtEndDate As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmProjectReturnPlan))
        Me.txtCorName = New System.Windows.Forms.TextBox()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gpbxDG = New System.Windows.Forms.GroupBox()
        Me.dgShow = New System.Windows.Forms.DataGrid()
        Me.btnCommit = New System.Windows.Forms.Button()
        Me.gpbxPlan = New System.Windows.Forms.GroupBox()
        Me.txtEachReturn = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dtpFirstDate = New System.Windows.Forms.DateTimePicker()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAbstract = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtMonth = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRefundType = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLoanSum = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.btnCreatePlan = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEndDate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtShowMoney = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gpbxDG.SuspendLayout()
        CType(Me.dgShow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbxPlan.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.btnExit.Location = New System.Drawing.Point(495, 424)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Visible = True
        '
        'txtCorName
        '
        Me.txtCorName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtCorName.Location = New System.Drawing.Point(249, 6)
        Me.txtCorName.Name = "txtCorName"
        Me.txtCorName.ReadOnly = True
        Me.txtCorName.Size = New System.Drawing.Size(240, 21)
        Me.txtCorName.TabIndex = 35
        Me.txtCorName.Text = ""
        '
        'txtProjectCode
        '
        Me.txtProjectCode.BackColor = System.Drawing.Color.Gainsboro
        Me.txtProjectCode.Location = New System.Drawing.Point(81, 6)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.ReadOnly = True
        Me.txtProjectCode.Size = New System.Drawing.Size(96, 21)
        Me.txtProjectCode.TabIndex = 34
        Me.txtProjectCode.Text = ""
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(185, 8)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 33
        Me.Label8.Text = "企业名称"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(17, 8)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 32
        Me.Label9.Text = "项目编码"
        '
        'gpbxDG
        '
        Me.gpbxDG.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.gpbxDG.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgShow})
        Me.gpbxDG.Location = New System.Drawing.Point(8, 32)
        Me.gpbxDG.Name = "gpbxDG"
        Me.gpbxDG.Size = New System.Drawing.Size(576, 248)
        Me.gpbxDG.TabIndex = 29
        Me.gpbxDG.TabStop = False
        '
        'dgShow
        '
        Me.dgShow.CaptionVisible = False
        Me.dgShow.DataMember = ""
        Me.dgShow.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgShow.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgShow.Location = New System.Drawing.Point(3, 17)
        Me.dgShow.Name = "dgShow"
        Me.dgShow.ReadOnly = True
        Me.dgShow.Size = New System.Drawing.Size(570, 228)
        Me.dgShow.TabIndex = 0
        '
        'btnCommit
        '
        Me.btnCommit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCommit.Image = CType(resources.GetObject("btnCommit.Image"), System.Drawing.Bitmap)
        Me.btnCommit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCommit.ImageIndex = 11
        Me.btnCommit.ImageList = Me.ImageListBasic
        Me.btnCommit.Location = New System.Drawing.Point(411, 424)
        Me.btnCommit.Name = "btnCommit"
        Me.btnCommit.Size = New System.Drawing.Size(77, 23)
        Me.btnCommit.TabIndex = 8
        Me.btnCommit.Text = "提 交(&C)"
        Me.btnCommit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gpbxPlan
        '
        Me.gpbxPlan.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.gpbxPlan.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtEachReturn, Me.Label12, Me.dtpFirstDate, Me.Label14, Me.txtAbstract, Me.Label1, Me.txtBalance, Me.Label13})
        Me.gpbxPlan.Location = New System.Drawing.Point(8, 344)
        Me.gpbxPlan.Name = "gpbxPlan"
        Me.gpbxPlan.Size = New System.Drawing.Size(576, 72)
        Me.gpbxPlan.TabIndex = 36
        Me.gpbxPlan.TabStop = False
        '
        'txtEachReturn
        '
        Me.txtEachReturn.BackColor = System.Drawing.SystemColors.Window
        Me.txtEachReturn.Enabled = False
        Me.txtEachReturn.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txtEachReturn.Location = New System.Drawing.Point(288, 16)
        Me.txtEachReturn.MaxLength = 8
        Me.txtEachReturn.Name = "txtEachReturn"
        Me.txtEachReturn.Size = New System.Drawing.Size(104, 21)
        Me.txtEachReturn.TabIndex = 2
        Me.txtEachReturn.Text = ""
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(192, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 14)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "每次还款额(元) "
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFirstDate
        '
        Me.dtpFirstDate.Enabled = False
        Me.dtpFirstDate.Location = New System.Drawing.Point(72, 16)
        Me.dtpFirstDate.Name = "dtpFirstDate"
        Me.dtpFirstDate.Size = New System.Drawing.Size(112, 21)
        Me.dtpFirstDate.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(8, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 14)
        Me.Label14.TabIndex = 14
        Me.Label14.Text = "日    期"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAbstract
        '
        Me.txtAbstract.BackColor = System.Drawing.SystemColors.Window
        Me.txtAbstract.Enabled = False
        Me.txtAbstract.Location = New System.Drawing.Point(72, 40)
        Me.txtAbstract.MaxLength = 30
        Me.txtAbstract.Multiline = True
        Me.txtAbstract.Name = "txtAbstract"
        Me.txtAbstract.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAbstract.Size = New System.Drawing.Size(496, 24)
        Me.txtAbstract.TabIndex = 3
        Me.txtAbstract.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "摘    要"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBalance
        '
        Me.txtBalance.BackColor = System.Drawing.Color.Gainsboro
        Me.txtBalance.Location = New System.Drawing.Point(440, 16)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(128, 21)
        Me.txtBalance.TabIndex = 7
        Me.txtBalance.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(400, 18)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 14)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "差额"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMonth
        '
        Me.txtMonth.BackColor = System.Drawing.Color.Gainsboro
        Me.txtMonth.Location = New System.Drawing.Point(104, 37)
        Me.txtMonth.Name = "txtMonth"
        Me.txtMonth.ReadOnly = True
        Me.txtMonth.Size = New System.Drawing.Size(64, 21)
        Me.txtMonth.TabIndex = 18
        Me.txtMonth.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 14)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "担保期限 (月)"
        '
        'txtRefundType
        '
        Me.txtRefundType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRefundType.Location = New System.Drawing.Point(272, 13)
        Me.txtRefundType.Name = "txtRefundType"
        Me.txtRefundType.ReadOnly = True
        Me.txtRefundType.Size = New System.Drawing.Size(120, 21)
        Me.txtRefundType.TabIndex = 10
        Me.txtRefundType.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(176, 16)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(91, 14)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "还  款  方  式"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLoanSum
        '
        Me.txtLoanSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanSum.Location = New System.Drawing.Point(104, 13)
        Me.txtLoanSum.Name = "txtLoanSum"
        Me.txtLoanSum.ReadOnly = True
        Me.txtLoanSum.Size = New System.Drawing.Size(64, 21)
        Me.txtLoanSum.TabIndex = 1
        Me.txtLoanSum.Text = ""
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(8, 16)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 14)
        Me.Label16.TabIndex = 0
        Me.Label16.Text = "贷款金额(万元)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Enabled = False
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.ImageIndex = 10
        Me.btnSave.ImageList = Me.ImageListBasic
        Me.btnSave.Location = New System.Drawing.Point(327, 424)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnDelete
        '
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnDelete.Image = CType(resources.GetObject("btnDelete.Image"), System.Drawing.Bitmap)
        Me.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDelete.ImageIndex = 12
        Me.btnDelete.ImageList = Me.ImageListBasic
        Me.btnDelete.Location = New System.Drawing.Point(243, 424)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(77, 23)
        Me.btnDelete.TabIndex = 6
        Me.btnDelete.Text = "删 除(&D)"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnNew
        '
        Me.btnNew.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Bitmap)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.ImageIndex = 13
        Me.btnNew.ImageList = Me.ImageListBasic
        Me.btnNew.Location = New System.Drawing.Point(159, 424)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(77, 23)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "新 增(&N)"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCreatePlan
        '
        Me.btnCreatePlan.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnCreatePlan.Image = CType(resources.GetObject("btnCreatePlan.Image"), System.Drawing.Bitmap)
        Me.btnCreatePlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCreatePlan.ImageIndex = 7
        Me.btnCreatePlan.ImageList = Me.ImageListBasic
        Me.btnCreatePlan.Location = New System.Drawing.Point(32, 424)
        Me.btnCreatePlan.Name = "btnCreatePlan"
        Me.btnCreatePlan.Size = New System.Drawing.Size(120, 23)
        Me.btnCreatePlan.TabIndex = 4
        Me.btnCreatePlan.Text = "生成还款计划(&P)"
        Me.btnCreatePlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtEndDate, Me.Label4, Me.txtShowMoney, Me.Label3, Me.Label16, Me.Label15, Me.txtLoanSum, Me.txtRefundType, Me.Label2, Me.txtMonth})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(576, 64)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        '
        'txtEndDate
        '
        Me.txtEndDate.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEndDate.Location = New System.Drawing.Point(464, 13)
        Me.txtEndDate.Name = "txtEndDate"
        Me.txtEndDate.ReadOnly = True
        Me.txtEndDate.Size = New System.Drawing.Size(104, 21)
        Me.txtEndDate.TabIndex = 22
        Me.txtEndDate.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(400, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 14)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "还款截止日"
        '
        'txtShowMoney
        '
        Me.txtShowMoney.BackColor = System.Drawing.Color.Gainsboro
        Me.txtShowMoney.Location = New System.Drawing.Point(272, 37)
        Me.txtShowMoney.Name = "txtShowMoney"
        Me.txtShowMoney.ReadOnly = True
        Me.txtShowMoney.Size = New System.Drawing.Size(120, 21)
        Me.txtShowMoney.TabIndex = 20
        Me.txtShowMoney.Text = ""
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(176, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "每次还款额(元)"
        '
        'frmProjectReturnPlan
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(594, 455)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox1, Me.btnSave, Me.btnDelete, Me.btnNew, Me.btnCreatePlan, Me.gpbxPlan, Me.btnExit, Me.txtCorName, Me.txtProjectCode, Me.Label8, Me.Label9, Me.gpbxDG, Me.btnCommit})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProjectReturnPlan"
        Me.Text = "建立项目还款计划"
        Me.gpbxDG.ResumeLayout(False)
        CType(Me.dgShow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbxPlan.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    '返回数据源 
    Private Sub GetDataSourceForRefundPlan()
        Dim dsConferenceTrial As DataSet = New DataSet()
        dsConferenceTrial = gWs.GetConfTrialInfo("{project_code LIKE '" & ProjectCode & "' AND trial_conclusion='通过' ORDER BY trial_times DESC}", "null")
        '绑定贷款金额,还款方式,担保期限,每次还款额
        txtLoanSum.DataBindings.Add(New Binding("Text", dsConferenceTrial, "conference_trial.guarantee_sum"))
        txtRefundType.DataBindings.Add(New Binding("Text", dsConferenceTrial, "conference_trial.refund_type"))
        RefundType = gWs.GetRefundType("{refund_type='" & txtRefundType.Text & "'}").Tables(0).Rows(0)("refund_type_code").ToString()
        txtShowMoney.DataBindings.Add(New Binding("Text", dsConferenceTrial, "conference_trial.refund_sum_average"))
        If txtShowMoney.Text <> String.Empty Then
            OriginalMoney = txtShowMoney.Text
        End If
        txtMonth.DataBindings.Add(New Binding("Text", dsConferenceTrial, "conference_trial.terms"))
        If txtLoanSum.Text = String.Empty Or txtRefundType.Text = String.Empty Then
            SWDialogBox.MessageBox.Show("$X036")  '该项目贷款金额为零或还款方式不存在
            Dim obj As Control
            For Each obj In Controls
                obj.Enabled = False
            Next
            btnExit.Enabled = True
            Return
        End If
        If RefundType = "04" Or RefundType = "05" Then '如果还款方式是等额每周，每日还款，则默认值为等额每月还款的金额
            OriginalMoney = Convert.ToInt64(CDbl(txtLoanSum.Text) * 10000 / CInt(txtMonth.Text)).ToString("n")
        End If

        txtEachReturn.Text = OriginalMoney

        Dim payout As Double = 0.0
        dsAccountDetail = New DataSet()
        dsAccountDetail = gWs.GetProjectAccountDetailInfo("{project_code='" & ProjectCode & "' and item_type='" & item_type & "' and  item_code='" & item_code & "'}")
        With dsAccountDetail.Tables("project_account_detail")
            btnDelete.Enabled = (.Rows.Count > 0)  '设置删除按钮是否可用
            Dim i As Integer
            For i = 0 To .Rows.Count - 1
                If Not IsDBNull(.Rows(i)("payout")) Then
                    payout += CDbl(.Rows(i).Item("payout"))
                End If
            Next
        End With

        LoanSum = CDbl(txtLoanSum.Text) * 10000
        txtBalance.Text = (LoanSum - payout).ToString("n")
        btnNew.Enabled = Not (LoanSum = payout)
        EqualZero(txtBalance.Text)
        btnCreatePlan.Visible = RefundType.Trim <> "06"
        If IsDBNull(gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}").Tables(0).Rows(0)("EndTime")) = False Then
            EndDate = gWs.GetProjectInfoEx("{ProjectCode LIKE '" & ProjectCode & "'}").Tables(0).Rows(0)("EndTime")
            txtEndDate.Text = String.Format("{0:yyyy年M月d日}", EndDate)
        End If
    End Sub

    Private Sub frmProjectReturnPlan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProjectCode = MyBase.getProjectCode
        TaskID = MyBase.getTaskID
        CorporationName = MyBase.getCorporationName
        WorkFlowID = MyBase.getWorkFlowID
        txtProjectCode.Text = ProjectCode : txtCorName.Text = CorporationName
        Try
            Me.Cursor = Cursors.WaitCursor

            SystemDate = gWs.GetSysTime
            dtpFirstDate.Value = SystemDate.Date
            item_type = "34" : item_code = "002"
            GetDataSourceForRefundPlan()

            If gpbxDG.Enabled = False Then
                Return
            End If

            bmPlan = BindingContext(dsAccountDetail, "project_account_detail")
            dgShow.DataMember = "project_account_detail"
            dgShow.DataSource = dsAccountDetail
            addTableStyleForPlan()
            AddHandler btnNew.Click, AddressOf NewPlan
            AddHandler btnCreatePlan.Click, AddressOf CreatePlan_Click
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
    '样式表
    Private Sub addTableStyleForPlan()
        dgShow.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "project_account_detail"
        dgts.AllowSorting = False
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 0
        col2.MappingName = "serial_num"
        col2.HeaderText = "序号"
        col2.Width = 0
        col2.Alignment = HorizontalAlignment.Center
        dgts.GridColumnStyles.Add(col2)
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index 1
        col3.MappingName = "date"
        col3.HeaderText = "日  期 "
        col3.Width = 80
        col3.Format = "yyyy-MM-dd"
        dgts.GridColumnStyles.Add(col3)
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  2
        col4.MappingName = "payout"
        col4.HeaderText = "应收金额(元) "
        col4.Alignment = HorizontalAlignment.Right
        col4.Width = 100
        col4.NullText = String.Empty
        col4.Format = "n"
        dgts.GridColumnStyles.Add(col4)
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()  'index  3
        col5.MappingName = "remark"
        col5.HeaderText = "摘要"
        col5.Alignment = HorizontalAlignment.Left
        col5.Width = 350
        col5.NullText = String.Empty
        dgts.GridColumnStyles.Add(col5)
        dgShow.TableStyles.Add(dgts)
    End Sub
    'Form_Load

    Private Sub SetObjsEnabled(ByVal IsEnabled As Boolean)
        txtEachReturn.Enabled = IsEnabled
        dtpFirstDate.Enabled = IsEnabled
        txtAbstract.Enabled = IsEnabled
        dgShow.Enabled = Not IsEnabled
        btnSave.Enabled = IsEnabled
    End Sub
    Private HasBinded As Boolean = False
    Private Sub IniBinding()
        dtpFirstDate.DataBindings.Add(New Binding("Value", dsAccountDetail, "project_account_detail.date"))
        Dim money1 As Binding = New Binding("Text", dsAccountDetail, "project_account_detail.payout")
        txtEachReturn.DataBindings.Add(money1)
        AddHandler money1.Format, AddressOf money_format
        txtAbstract.DataBindings.Add(New Binding("Text", dsAccountDetail, "project_account_detail.remark"))
        HasBinded = True
    End Sub
    Private Sub QuitBinding()
        dtpFirstDate.DataBindings.Clear()
        txtAbstract.DataBindings.Clear()
        txtEachReturn.DataBindings.Clear()
        HasBinded = False
    End Sub
    Private Sub CreatePlan_Click(ByVal sender As Object, ByVal e As EventArgs)
        If HasBinded Then
            QuitBinding()
        End If
        strStatus = "multiple" : btnDelete.Enabled = False
        btnNew.Enabled = False : btnCreatePlan.Text = "取 消(&P)"
        RemoveHandler btnCreatePlan.Click, AddressOf CreatePlan_Click
        AddHandler btnCreatePlan.Click, AddressOf CancelPlan
        SetObjsEnabled(True)
        txtAbstract.Text = "收取还款"
    End Sub
    Private Sub CancelPlan(ByVal sender As Object, ByVal e As EventArgs)
        If sender Is Nothing Then Return
        If Not sender.GetType Is GetType(Button) Then Return
        Select Case strStatus
            Case "multiple"
                btnNew.Enabled = True : btnCreatePlan.Text = "生成还款计划(&P)"
                RemoveHandler btnCreatePlan.Click, AddressOf CancelPlan
                AddHandler btnCreatePlan.Click, AddressOf CreatePlan_Click
            Case "single"
                If HasBinded Then
                    QuitBinding()
                End If
                If dsAccountDetail.HasChanges Then
                    dsAccountDetail.RejectChanges()
                End If
                btnCreatePlan.Enabled = True : btnNew.Text = "新 增(&N)"
                RemoveHandler btnNew.Click, AddressOf CancelPlan
                AddHandler btnNew.Click, AddressOf NewPlan
        End Select
        SetObjsEnabled(False)
        btnNew.Enabled = Not (CDbl(txtBalance.Text) = 0.0)
        btnDelete.Enabled = (dgShow.CurrentRowIndex >= 0)
        strStatus = String.Empty
        txtEachReturn.Text = OriginalMoney

        If CType(sender, Button) Is btnSave Then
            If dgShow.VisibleRowCount <= bmPlan.Count Then
                addTableStyleForPlan()
            End If
        End If

    End Sub
    'OriginalMoney
    Private Sub NewPlan(ByVal sender As Object, ByVal e As EventArgs)
        dtpFirstDate.Value = SystemDate.Date
        Dim dr As DataRow = dsAccountDetail.Tables("project_account_detail").NewRow
        With dr
            .Item("project_code") = ProjectCode
            .Item("date") = dtpFirstDate.Value.Date
            .Item("item_type") = item_type
            .Item("item_code") = item_code
            .Item("remark") = "收取还款"
            .Item("create_person") = UserName
            .Item("create_date") = SystemDate.Date
        End With
        dsAccountDetail.Tables("project_account_detail").Rows.Add(dr)
        bmPlan.Position = bmPlan.Count - 1
        If Not HasBinded Then
            IniBinding()
        End If
        SetObjsEnabled(True)
        strStatus = "single" : btnCreatePlan.Enabled = False
        btnDelete.Enabled = False
        btnNew.Text = "取 消(&N)"
        RemoveHandler btnNew.Click, AddressOf NewPlan
        AddHandler btnNew.Click, AddressOf CancelPlan
        dtpFirstDate.Focus()
    End Sub
    Private Sub DelPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If SWDialogBox.MessageBox.Show("?1004", "") = DialogResult.Yes Then
            If bmPlan.Count = 1 And HasBinded Then
                QuitBinding()
            End If
            Dim index As Integer = dgShow.CurrentRowIndex
            With dgShow
                '余额赠加
                txtBalance.Text = CStr(CDbl(txtBalance.Text) + CDbl(CType(bmPlan.Current, DataRowView).Item("payout")))
                EqualZero(txtBalance.Text)
                '删掉记录
                CType(bmPlan.Current, DataRowView).Delete()
                Dim strResult As String = gWs.UpdateProjectAccountDetail(dsAccountDetail.GetChanges(DataRowState.Deleted))
                If (strResult = "1") Then
                    dsAccountDetail.AcceptChanges()
                    SWDialogBox.MessageBox.Show("$DeleteSucceed")
                Else
                    SWDialogBox.MessageBox.Show("*999", "删除失败", strResult, "")
                End If

                If .CurrentRowIndex > -1 Then
                    dtpFirstDate.Value = CDate(.Item(.CurrentRowIndex, 1))
                Else
                    dtpFirstDate.Value = SystemDate.Date
                End If
            End With
            btnDelete.Enabled = (dgShow.CurrentRowIndex >= 0)
            btnNew.Enabled = Not (CDbl(txtBalance.Text) = 0.0)
        End If
    End Sub
    Private IsWrong As Boolean = False
    Private Sub SavePlan_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        IsWrong = True
        If TodayHasPlan() Then
            SWDialogBox.MessageBox.Show("$X037") '您选择的还款日期已存在已还款计划中
            dtpFirstDate.Focus()
            Return
        End If
        If txtEachReturn.Text = String.Empty OrElse CDbl(txtEachReturn.Text) = 0 Then
            SWDialogBox.MessageBox.Show("$1003", "还款金额")
            txtEachReturn.Focus()
            Return
        ElseIf CDbl(txtEachReturn.Text) > LoanSum Then
            SWDialogBox.MessageBox.Show("$1008", "还款金额", "贷款金额")
            txtEachReturn.Focus()
            Return
        End If
        If strStatus = "multiple" Then  '生成还款计划         
            Dim times As Integer = 0
            Dim balance As Double = 0
            If (RefundType <> "01") Then
                Dim monthCode() As String = {"03", "04", "05"}
                If monthCode.IndexOf(monthCode, RefundType) >= 0 Then '按等月计算
                    times = CInt(txtMonth.Text)
                ElseIf RefundType = "02" Then '等额每季还款   非按等月计算                    
                    times = IIf(CInt(txtMonth.Text) Mod 3 <> 0, CInt(txtMonth.Text) \ 3 + 1, CInt(txtMonth.Text) \ 3)
                End If
                balance = LoanSum - (times - 1) * CDbl(txtEachReturn.Text) '未能整除剩下的余额                           
                While balance < 0
                    times -= 1
                    balance = LoanSum - (times - 1) * CDbl(txtEachReturn.Text)  '未能整除剩下的余额                           
                End While
            End If

            Dim rowCount As Integer = dsAccountDetail.Tables("project_account_detail").Rows.Count
            If rowCount > 0 Then
                '您将删除原有还款计划,并产生新的还款计划" & Chr(13) & "（起始日期：" & dtpFirstDate.Value.Date & " ："strMessage += "笔数：" & realCount & "）？"
                If (SWDialogBox.MessageBox.Show("?X004", dtpFirstDate.Value.Date, times) = DialogResult.No) Then
                    CancelPlan(sender, e) : IsWrong = False
                    Return
                Else
                    Dim i As Integer
                    For i = rowCount - 1 To 0 Step -1
                        dsAccountDetail.Tables("project_account_detail").Rows(i).Delete()
                    Next
                End If
            End If
            '到期一次还款 等额每季还款  等额每月还款 等额每周还款 等额每日还款
            Select Case RefundType.Trim 'txtRefundType.Text
                Case "01" '"到期一次还款"
                    CreateSingleRecord(LoanSum, dtpFirstDate.Value.Date)
                Case "02" '"等额每季还款"
                    If Not CreateStepRecord("month", 3, times, CDbl(txtEachReturn.Text)) Then
                        'CreateSingleRecord(balance, dtpFirstDate.Value.AddMonths(times * 3).Date)  '插入余额,以下类似
                    End If
                Case "03" '"等额每月还款"
                    If Not CreateStepRecord("month", 1, times, CDbl(txtEachReturn.Text)) Then
                        'CreateSingleRecord(balance, dtpFirstDate.Value.AddMonths(times).Date)
                    End If
                Case "04" '"等额每周还款"
                    If Not CreateStepRecord("month", 1, times, CDbl(txtEachReturn.Text)) Then  '"day",7
                        'CreateSingleRecord(balance, dtpFirstDate.Value.AddDays(times * 7).Date)
                    End If
                Case "05" '"等额每日还款"
                    If Not CreateStepRecord("month", 1, times, CDbl(txtEachReturn.Text)) Then       '"day",1
                        'CreateSingleRecord(balance, dtpFirstDate.Value.AddDays(times).Date)
                    End If
                Case Else
                    SWDialogBox.MessageBox.Show("$X027") '该项目不符合生成还款计划的要求
                    If dsAccountDetail.HasChanges Then
                        dsAccountDetail.RejectChanges()
                    End If
                    CancelPlan(sender, e)
                    Return
            End Select
            txtBalance.Text = "0" : EqualZero(txtBalance.Text)
            Dim strResult As String = gWs.UpdateProjectAccountDetail(dsAccountDetail.GetChanges)
            If (strResult = "1") Then
                IsWrong = False
                If sender Is Nothing Then Return
                SWDialogBox.MessageBox.Show("$SaveSucceed")
                dsAccountDetail = gWs.GetProjectAccountDetailInfo("{project_code='" & ProjectCode & "' AND item_type='" & item_type & "' AND item_code='" & item_code & "' ORDER BY date}")
                bmPlan = BindingContext(dsAccountDetail, "project_account_detail")
                dgShow.DataMember = "project_account_detail"
                dgShow.DataSource = dsAccountDetail
            Else
                SWDialogBox.MessageBox.Show("*999", "保存失败", strresult, "")
                IsWrong = True
                Return
            End If
            CancelPlan(sender, e)
        ElseIf strStatus = "single" Then
            bmPlan.Position = bmPlan.Count - 1
            Dim strResult As String = gWs.UpdateProjectAccountDetail(dsAccountDetail.GetChanges)
            If (strResult = "1") Then
                IsWrong = False
                If sender Is Nothing Then Return

                SWDialogBox.MessageBox.Show("$SaveSucceed")
                dsAccountDetail = gWs.GetProjectAccountDetailInfo("{project_code='" & ProjectCode & "' AND item_type='" & item_type & "' AND item_code='" & item_code & "' ORDER BY date}")
                QuitBinding()
                bmPlan = BindingContext(dsAccountDetail, "project_account_detail")
                IniBinding()
                dgShow.DataMember = "project_account_detail"
                dgShow.DataSource = dsAccountDetail
                bmPlan.Position = bmPlan.Count - 1
                txtBalance.Text = (LoanSum - CalculateBalance()).ToString("n") ' CStr(CDbl(txtBalance.Text) - CDbl(txtEachReturn.Text))
                EqualZero(txtBalance.Text)
            Else
                SWDialogBox.MessageBox.Show("*999", "保存失败", strresult, "")
                IsWrong = True
                Return
            End If
            CancelPlan(sender, e)
        End If
    End Sub

    Private Function CalculateBalance() As Double
        Dim dr As DataRow
        Dim result As Double = 0
        For Each dr In dsAccountDetail.Tables(0).Rows
            result += CDbl(IIf(IsDBNull(dr("payout")), 0, dr("payout")))
        Next
        Return result
    End Function

    '根据还款方式产生多条记录
    Private Function CreateStepRecord(ByVal type As String, ByVal DateStep As Integer, ByVal totalTimes As Integer, ByVal money As Double) As Boolean
        'Add record to real DataSet
        Dim isOverdue As Boolean = False
        Dim EachDate As Date
        Dim i As Integer
        For i = 0 To totalTimes - 1
            Dim realDr As DataRow = dsAccountDetail.Tables("project_account_detail").NewRow
            With realDr
                .Item("project_code") = ProjectCode
                If (type = "month") Then
                    EachDate = dtpFirstDate.Value.AddMonths(i * DateStep).Date
                    isOverdue = EachDate.Date >= EndDate.Date   '判断有没有超过放款截止日
                    .Item("date") = IIf(isOverdue, EndDate.Date, EachDate.Date)
                ElseIf (type = "day") Then
                    .Item("date") = dtpFirstDate.Value.AddDays(i * DateStep).Date
                    EachDate = dtpFirstDate.Value.AddDays(i * DateStep).Date
                    isOverdue = EachDate.Date >= EndDate.Date
                    .Item("date") = IIf(isOverdue, EndDate.Date, EachDate.Date)
                End If
                .Item("item_type") = item_type
                .Item("item_code") = item_code
                .Item("payout") = IIf(isOverdue Or i = totalTimes - 1, Me.LoanSum - i * money, money)
                .Item("remark") = txtAbstract.Text
                .Item("create_person") = UserName
                .Item("create_date") = SystemDate.Date
            End With
            dsAccountDetail.Tables("project_account_detail").Rows.Add(realDr)
            If isOverdue Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub CreateSingleRecord(ByVal money As Double, ByVal InputDate As Date)
        If CStr(money).Substring(0, 1) = "0" Then  '金额首位为零，则不用增加
            Return
        End If
        'Add record to real DataSet
        Dim isOverdue As Boolean = InputDate.Date >= EndDate.Date
        Dim realDr As DataRow = dsAccountDetail.Tables("project_account_detail").NewRow
        With realDr
            .Item("project_code") = ProjectCode
            .Item("date") = IIf(isOverdue, EndDate.Date, InputDate.Date)
            .Item("item_type") = item_type
            .Item("item_code") = item_code
            .Item("payout") = money
            .Item("remark") = txtAbstract.Text
        End With
        dsAccountDetail.Tables("project_account_detail").Rows.Add(realDr)
    End Sub
    '判断今天是否已经有还款计划，如有，则不能加
    Private Function TodayHasPlan() As Boolean
        Dim i As Integer
        For i = 0 To bmPlan.Count - 1
            If dtpFirstDate.Value.ToString("yyyy-MM-dd") = dgShow.Item(i, 1).ToString() Then
                Return True
            End If
        Next
        Return False
    End Function
    '以下三个方法为输入金额服务，确保正确
    Private Sub txt_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEachReturn.Enter
        Money.Money_Enter(sender, e)
    End Sub
    Private Sub txt_Keypress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEachReturn.KeyPress
        Money.Money_KeyPress(sender, e)
    End Sub

    Private Sub txt_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEachReturn.Leave
        Money.Money_Leave(sender, e)
    End Sub

    '根据差额是否为零，设置btnSubmit是否可用
    Private Sub EqualZero(ByVal money As String)
        'btnCommit.Enabled = (CDbl(money) = 0.0)
    End Sub

    Private Sub dg_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgShow.MouseUp
        With dgShow
            If .CurrentRowIndex < 0 Then Return
            .Select(.CurrentRowIndex)
            If Not HasBinded Then
                IniBinding()
            End If
        End With
    End Sub

    Private Sub btnCommit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCommit.Click
        If isCommitConfirm Then
            Dim answer As DialogResult = SWDialogBox.MessageBox.Show("?1000", "提交") 'MessageBox.Show("请确定提交？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If Not (answer = DialogResult.Yes) Then
                Return
            End If
        End If
        If strStatus <> String.Empty Then
            SavePlan_Click(Nothing, Nothing)
            If IsWrong Then Return
        End If

        Dim strSuccess As String = gWs.finishedTask(WorkFlowID, ProjectCode, TaskID, "", UserName)
        If strSuccess = "1" Then
            SWDialogBox.MessageBox.Show("$SubmitSucceed")
            MyBase.raiseCommitSucceed()
            RemoveHandler MyBase.Closing, AddressOf frmProjectReturnPlan_Closing
            Close()
        Else
            SWDialogBox.MessageBox.Show("*999", "提交失败", strSuccess, "")
        End If
    End Sub
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        ConfirmClose(sender, e)
    End Sub
    Private Function ConfirmClose(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        If (strStatus <> String.Empty) Then '
            Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003") 'MessageBox.Show("数据已修改，是否保存？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If QueryResult = DialogResult.Yes Then
                SavePlan_Click(Nothing, Nothing)
                If IsWrong Then Return False
            ElseIf QueryResult = DialogResult.Cancel Then
                Return False
            End If
        End If
        RemoveHandler MyBase.Closing, AddressOf frmProjectReturnPlan_Closing
        Close()
        Return True
    End Function
    Private Sub frmProjectReturnPlan_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, e)
    End Sub

    Private Sub frmProjectReturnPlan_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        MyBase.setEnterKeyPress(sender, e)
    End Sub
End Class
