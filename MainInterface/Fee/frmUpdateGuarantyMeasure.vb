Public Class frmUpdateGuarantyMeasure
    Inherits System.Windows.Forms.Form
    Private ProjectCode As String
    Private dsMeasure As DataSet
    Private DataChanged As Boolean = False
#Region " Windows 窗体设计器生成的代码 "

    Public Sub New()
        MyBase.New()

        '该调用是 Windows 窗体设计器所必需的。
        InitializeComponent()

        '在 InitializeComponent() 调用之后添加任何初始化

    End Sub
    Public Sub New(ByVal _ProjectCode As String)
        MyBase.New()
        InitializeComponent()
        ProjectCode = _ProjectCode
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
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtEachReturn As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtGuaSum As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTerm As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRefundType As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtLoanForm As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtServiceType As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cbxFinalDesicion As System.Windows.Forms.CheckBox
    Friend WithEvents txtConclusion As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgMeasure As System.Windows.Forms.DataGrid
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmUpdateGuarantyMeasure))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgMeasure = New System.Windows.Forms.DataGrid()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtEachReturn = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtGuaSum = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtTerm = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRefundType = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtLoanForm = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtServiceType = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbxFinalDesicion = New System.Windows.Forms.CheckBox()
        Me.txtConclusion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgMeasure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.Location = New System.Drawing.Point(320, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnSave
        '
        Me.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Bitmap)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(232, 376)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(77, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "保 存(&S)"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgMeasure})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 136)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(616, 232)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'dgMeasure
        '
        Me.dgMeasure.CaptionVisible = False
        Me.dgMeasure.DataMember = ""
        Me.dgMeasure.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgMeasure.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgMeasure.Location = New System.Drawing.Point(3, 17)
        Me.dgMeasure.Name = "dgMeasure"
        Me.dgMeasure.Size = New System.Drawing.Size(610, 212)
        Me.dgMeasure.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox3.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtRemark, Me.Label13, Me.txtEachReturn, Me.Label10, Me.txtGuaSum, Me.Label8, Me.txtTerm, Me.Label9, Me.txtRefundType, Me.Label15, Me.txtLoanForm, Me.Label14, Me.txtServiceType, Me.Label7, Me.Label6, Me.cbxFinalDesicion, Me.txtConclusion, Me.Label5})
        Me.GroupBox3.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(616, 136)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'txtRemark
        '
        Me.txtRemark.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtRemark.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRemark.Location = New System.Drawing.Point(96, 90)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.ReadOnly = True
        Me.txtRemark.Size = New System.Drawing.Size(512, 38)
        Me.txtRemark.TabIndex = 68
        Me.txtRemark.Text = ""
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 14)
        Me.Label13.TabIndex = 67
        Me.Label13.Text = "备       注"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEachReturn
        '
        Me.txtEachReturn.BackColor = System.Drawing.Color.Gainsboro
        Me.txtEachReturn.Location = New System.Drawing.Point(96, 64)
        Me.txtEachReturn.Name = "txtEachReturn"
        Me.txtEachReturn.ReadOnly = True
        Me.txtEachReturn.Size = New System.Drawing.Size(80, 21)
        Me.txtEachReturn.TabIndex = 59
        Me.txtEachReturn.Text = ""
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(8, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 14)
        Me.Label10.TabIndex = 58
        Me.Label10.Text = "每次还款额(元)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtGuaSum
        '
        Me.txtGuaSum.BackColor = System.Drawing.Color.Gainsboro
        Me.txtGuaSum.Location = New System.Drawing.Point(96, 39)
        Me.txtGuaSum.Name = "txtGuaSum"
        Me.txtGuaSum.ReadOnly = True
        Me.txtGuaSum.Size = New System.Drawing.Size(80, 21)
        Me.txtGuaSum.TabIndex = 57
        Me.txtGuaSum.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 41)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 14)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "担保金额(万元)"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTerm
        '
        Me.txtTerm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtTerm.Location = New System.Drawing.Point(264, 64)
        Me.txtTerm.Name = "txtTerm"
        Me.txtTerm.ReadOnly = True
        Me.txtTerm.Size = New System.Drawing.Size(32, 21)
        Me.txtTerm.TabIndex = 55
        Me.txtTerm.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(184, 64)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 14)
        Me.Label9.TabIndex = 54
        Me.Label9.Text = "担保期限(月)"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRefundType
        '
        Me.txtRefundType.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtRefundType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtRefundType.Location = New System.Drawing.Point(456, 39)
        Me.txtRefundType.Name = "txtRefundType"
        Me.txtRefundType.ReadOnly = True
        Me.txtRefundType.Size = New System.Drawing.Size(152, 21)
        Me.txtRefundType.TabIndex = 53
        Me.txtRefundType.Text = ""
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(392, 42)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(54, 14)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "还款方式"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLoanForm
        '
        Me.txtLoanForm.BackColor = System.Drawing.Color.Gainsboro
        Me.txtLoanForm.Location = New System.Drawing.Point(264, 39)
        Me.txtLoanForm.Name = "txtLoanForm"
        Me.txtLoanForm.ReadOnly = True
        Me.txtLoanForm.Size = New System.Drawing.Size(104, 21)
        Me.txtLoanForm.TabIndex = 51
        Me.txtLoanForm.Text = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(184, 41)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 14)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "放 款 方 式"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtServiceType
        '
        Me.txtServiceType.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtServiceType.BackColor = System.Drawing.Color.Gainsboro
        Me.txtServiceType.Location = New System.Drawing.Point(456, 14)
        Me.txtServiceType.Name = "txtServiceType"
        Me.txtServiceType.ReadOnly = True
        Me.txtServiceType.Size = New System.Drawing.Size(152, 21)
        Me.txtServiceType.TabIndex = 43
        Me.txtServiceType.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(392, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 14)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "业务品种"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(184, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 14)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "为最终决定"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbxFinalDesicion
        '
        Me.cbxFinalDesicion.Enabled = False
        Me.cbxFinalDesicion.Location = New System.Drawing.Point(264, 16)
        Me.cbxFinalDesicion.Name = "cbxFinalDesicion"
        Me.cbxFinalDesicion.Size = New System.Drawing.Size(24, 16)
        Me.cbxFinalDesicion.TabIndex = 40
        '
        'txtConclusion
        '
        Me.txtConclusion.BackColor = System.Drawing.Color.Gainsboro
        Me.txtConclusion.Location = New System.Drawing.Point(96, 14)
        Me.txtConclusion.Name = "txtConclusion"
        Me.txtConclusion.ReadOnly = True
        Me.txtConclusion.Size = New System.Drawing.Size(80, 21)
        Me.txtConclusion.TabIndex = 39
        Me.txtConclusion.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 14)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "评审会议意见"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmUpdateGuarantyMeasure
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(632, 405)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.GroupBox3, Me.GroupBox2, Me.btnSave, Me.btnExit})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmUpdateGuarantyMeasure"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "调整反担保措施"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgMeasure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub GetConclusion()
        Dim dsContrial As DataSet = New DataSet()
        dsContrial = gWs.GetConfTrialInfo("{project_code LIKE '" & ProjectCode & "' ORDER BY trial_times}", "null")
        SetBinding(dsContrial)
    End Sub

    '获得该项目的反担保物措施
    Private Sub GetMeasure()
        Dim dsItemType As DataSet = gWs.GetItemType("%")
        dsMeasure = gWs.GetProjectGuaranteeForm("{project_code LIKE '" & ProjectCode & "' AND is_used=1}")
        dsMeasure.Tables("TProjectGuaranteeForm").Columns.Add("ItemName", GetType(String))
        Dim dr As DataRow
        For Each dr In dsMeasure.Tables("TProjectGuaranteeForm").Rows
            If IsDBNull(dr("guaranty")) Then
                dr("ItemName") = DBNull.Value
            Else
                dr("ItemName") = dsItemType.Tables("TItemType").Select("item_type='" & dr("guaranty") & "'")(0)("type_name")
            End If
        Next
        dsMeasure.Tables("TProjectGuaranteeForm").DefaultView.AllowNew = False
        dsMeasure.Tables("TProjectGuaranteeForm").DefaultView.AllowDelete = False
        dgMeasure.DataSource = dsMeasure.Tables("TProjectGuaranteeForm").DefaultView
        AddTableStyleForOppGua()
    End Sub
    Private Sub AddTableStyleForOppGua()
        dgMeasure.TableStyles.Clear()
        Dim dgts As DataGridTableStyle = New DataGridTableStyle()
        dgts.MappingName = "TProjectGuaranteeForm"
        dgts.AllowSorting = False
        Dim d As delegateGetColorRowColBool = New delegateGetColorRowColBool(AddressOf MyGetColorRowCol)
        Dim col1 As DataGridColoredBoolColumn = New DataGridColoredBoolColumn(d, 0) ' DataGridBoolColumn = New DataGridBoolColumn()
        col1.MappingName = "is_used"
        col1.AllowNull = False
        col1.ReadOnly = True
        col1.HeaderText = "是否采用"
        col1.Width = 60
        Dim col2 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col2.ReadOnly = True
        col2.MappingName = "guarantee_form"
        col2.HeaderText = "反担保方式"
        col2.Width = 100
        Dim col3 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col3.MappingName = "ItemName"
        col3.ReadOnly = True
        col3.HeaderText = "反担保物"
        col3.Width = 100
        col3.NullText = ""
        Dim col4 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col4.MappingName = "num"
        col4.ReadOnly = True
        col4.HeaderText = "数量"
        col4.Width = 50
        col4.Alignment = HorizontalAlignment.Center
        Dim col5 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col5.MappingName = "guarantee_sum"
        col5.ReadOnly = False
        col5.HeaderText = "担保金额 " & ControlChars.Tab
        col5.Width = 100 : col5.TextBox.MaxLength = 14
        col5.Format = "c" : col5.NullText = ""
        AddHandler col5.TextBox.Enter, AddressOf Money.Money_Enter
        AddHandler col5.TextBox.KeyPress, AddressOf Money_Keypress
        AddHandler col5.TextBox.Leave, AddressOf Money.Money_Leave
        col5.FormatInfo = CGFormatInfo
        col5.Alignment = HorizontalAlignment.Right
        Dim col6 As DataGridTextBoxColumn = New DataGridTextBoxColumn()
        col6.MappingName = "description"
        col6.ReadOnly = False
        col6.HeaderText = "描述"
        col6.Width = 400
        col6.NullText = ""
        col6.TextBox.MaxLength = 100
        AddHandler col6.TextBox.KeyPress, AddressOf SomethingChanged
        dgts.GridColumnStyles.AddRange(New DataGridColumnStyle() {col1, col2, col3, col4, col5, col6})
        dgMeasure.TableStyles.Add(dgts)
    End Sub
    Private Sub SomethingChanged(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        DataChanged = True
    End Sub
    Private Sub Money_Keypress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        DataChanged = True
        Money.Money_KeyPress(sender, e)
    End Sub

    '设置列的颜色
    Public Function MyGetColorRowCol(ByVal row As Integer, ByVal col As Integer) As Color
        ' just conditionally set colors based on row, col values...
        If col = 0 Then
            Return Color.LightYellow
        ElseIf col = 1 Then
            Return Color.LightBlue
        End If
        Return Color.White
    End Function

    Private Sub frm_load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            GetConclusion()
            GetMeasure()
        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
            'MessageBox.Show("发生错误" & vbCr & ex.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Private Sub SetBinding(ByVal dsContrial As DataSet)
        txtGuaSum.DataBindings.Add(New Binding("Text", dsContrial, "conference_trial.guarantee_sum"))
        If dsContrial.Tables(0).Rows.Count > 0 AndAlso Not IsDBNull(dsContrial.Tables("conference_trial").Rows(0)("is_final_conclusion")) Then
            cbxFinalDesicion.DataBindings.Add(New Binding("Checked", dsContrial, "conference_trial.is_final_conclusion"))
        End If
        txtLoanForm.DataBindings.Add(New Binding("Text", dsContrial, "conference_trial.loan_provide_form"))
        txtRefundType.DataBindings.Add(New Binding("Text", dsContrial, "conference_trial.refund_type"))
        txtServiceType.DataBindings.Add(New Binding("Text", dsContrial, "conference_trial.service_type"))
        txtEachReturn.DataBindings.Add(New Binding("Text", dsContrial, "conference_trial.refund_sum_average"))
        txtTerm.DataBindings.Add(New Binding("Text", dsContrial, "conference_trial.terms"))
        txtConclusion.DataBindings.Add(New Binding("Text", dsContrial, "conference_trial.trial_conclusion"))
        txtRemark.DataBindings.Add(New Binding("Text", dsContrial, "conference_trial.Remark"))
    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnExit.Click
        ConfirmClose(sender, e)
    End Sub
    Protected Function ConfirmClose(ByVal sender As Object, ByVal e As EventArgs) As Boolean
        If DataChanged Then
            Dim QueryResult As DialogResult = SWDialogBox.MessageBox.Show("?1003") 'MessageBox.Show("数据已修改，是否保存？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
            If QueryResult = DialogResult.Yes Then
                btnSave_Click(Nothing, Nothing)
            ElseIf QueryResult = DialogResult.Cancel Then
                Return False
            End If
        End If
        RemoveHandler MyBase.Closing, AddressOf frm_Closing
        Close()
        Return True
    End Function

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        If Not DataChanged Then Return
        Dim result As String = gWs.UpdateProjectGuaranteeForm(dsMeasure.GetChanges)
        DataChanged = False
        If result = "1" Then
            If sender Is Nothing Then Return
            SWDialogBox.MessageBox.Show("$SaveSucceed")
            'MessageBox.Show("保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information)
            dsMeasure.AcceptChanges()
        Else
            SWDialogBox.MessageBox.Show("*999", "保存失败", result, "")
            'MessageBox.Show("保存失败" & vbCr & result, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub frm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = Not ConfirmClose(sender, e)
    End Sub
End Class
