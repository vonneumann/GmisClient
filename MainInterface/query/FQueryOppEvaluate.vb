Public Class FQueryOppEvaluate
    Inherits FQueryBase


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
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtProjectCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbManager As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEvaluater As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents chkAffirm As System.Windows.Forms.CheckBox
    Friend WithEvents dtpBookingFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents dtpAffirmFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpAffirmTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkBooking As System.Windows.Forms.CheckBox
    Friend WithEvents dtpBookingTo As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtProjectCode = New System.Windows.Forms.TextBox()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbManager = New System.Windows.Forms.ComboBox()
        Me.cmbEvaluater = New System.Windows.Forms.ComboBox()
        Me.chkBooking = New System.Windows.Forms.CheckBox()
        Me.chkAffirm = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dtpBookingFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpBookingTo = New System.Windows.Forms.DateTimePicker()
        Me.dtpAffirmFrom = New System.Windows.Forms.DateTimePicker()
        Me.dtpAffirmTo = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.cmbStatus, Me.Label7, Me.dtpAffirmTo, Me.dtpAffirmFrom, Me.dtpBookingTo, Me.dtpBookingFrom, Me.Label6, Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.chkAffirm, Me.chkBooking, Me.cmbEvaluater, Me.cmbManager, Me.txtCorpName, Me.txtProjectCode})
        Me.grpCondition.Size = New System.Drawing.Size(696, 112)
        Me.grpCondition.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(192, 128)
        Me.btnClear.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(536, 128)
        Me.btnExport.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(624, 128)
        Me.btnExit.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 160)
        Me.grdTable.Size = New System.Drawing.Size(696, 328)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.grdTable.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(448, 128)
        Me.btnRefresh.Visible = True
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 128)
        Me.chkVisible.Visible = True
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn1.MappingName = "project_code"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "项目名称"
        Me.DataGridTextBoxColumn2.MappingName = "corporation_name"
        Me.DataGridTextBoxColumn2.Width = 120
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "项目经理"
        Me.DataGridTextBoxColumn3.MappingName = "manager_a"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "资产评估师"
        Me.DataGridTextBoxColumn5.MappingName = "evaluate_person"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "评估状态"
        Me.DataGridTextBoxColumn7.MappingName = "evaluate_status"
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "预约评估时间"
        Me.DataGridTextBoxColumn4.MappingName = "booking_evaluate_date"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = "yyyy-MM-dd"
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "确认评估时间"
        Me.DataGridTextBoxColumn6.MappingName = "affirm_evaluate_date"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "企业联系人"
        Me.DataGridTextBoxColumn8.MappingName = "corp_contact_person"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "联系电话"
        Me.DataGridTextBoxColumn9.MappingName = "corp_contact_phone"
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'txtProjectCode
        '
        Me.txtProjectCode.Location = New System.Drawing.Point(80, 21)
        Me.txtProjectCode.Name = "txtProjectCode"
        Me.txtProjectCode.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectCode.TabIndex = 0
        Me.txtProjectCode.Text = ""
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(360, 21)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(112, 21)
        Me.txtCorpName.TabIndex = 1
        Me.txtCorpName.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "项目编码"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(488, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "到"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 14)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "资产评估师"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 14)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "项目经理A"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(272, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 14)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "企业名称"
        '
        'cmbManager
        '
        Me.cmbManager.Location = New System.Drawing.Point(80, 51)
        Me.cmbManager.Name = "cmbManager"
        Me.cmbManager.Size = New System.Drawing.Size(120, 20)
        Me.cmbManager.TabIndex = 7
        '
        'cmbEvaluater
        '
        Me.cmbEvaluater.Location = New System.Drawing.Point(80, 80)
        Me.cmbEvaluater.Name = "cmbEvaluater"
        Me.cmbEvaluater.Size = New System.Drawing.Size(120, 20)
        Me.cmbEvaluater.TabIndex = 8
        '
        'chkBooking
        '
        Me.chkBooking.Location = New System.Drawing.Point(252, 49)
        Me.chkBooking.Name = "chkBooking"
        Me.chkBooking.Size = New System.Drawing.Size(112, 24)
        Me.chkBooking.TabIndex = 9
        Me.chkBooking.Text = "预约评估时间从"
        '
        'chkAffirm
        '
        Me.chkAffirm.Location = New System.Drawing.Point(252, 78)
        Me.chkAffirm.Name = "chkAffirm"
        Me.chkAffirm.Size = New System.Drawing.Size(112, 24)
        Me.chkAffirm.TabIndex = 10
        Me.chkAffirm.Text = "确认评估时间从"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(488, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 14)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "到"
        '
        'dtpBookingFrom
        '
        Me.dtpBookingFrom.Enabled = False
        Me.dtpBookingFrom.Location = New System.Drawing.Point(360, 51)
        Me.dtpBookingFrom.Name = "dtpBookingFrom"
        Me.dtpBookingFrom.Size = New System.Drawing.Size(112, 21)
        Me.dtpBookingFrom.TabIndex = 12
        '
        'dtpBookingTo
        '
        Me.dtpBookingTo.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.dtpBookingTo.Enabled = False
        Me.dtpBookingTo.Location = New System.Drawing.Point(512, 51)
        Me.dtpBookingTo.Name = "dtpBookingTo"
        Me.dtpBookingTo.Size = New System.Drawing.Size(112, 21)
        Me.dtpBookingTo.TabIndex = 13
        '
        'dtpAffirmFrom
        '
        Me.dtpAffirmFrom.Enabled = False
        Me.dtpAffirmFrom.Location = New System.Drawing.Point(360, 80)
        Me.dtpAffirmFrom.Name = "dtpAffirmFrom"
        Me.dtpAffirmFrom.Size = New System.Drawing.Size(112, 21)
        Me.dtpAffirmFrom.TabIndex = 14
        '
        'dtpAffirmTo
        '
        Me.dtpAffirmTo.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.dtpAffirmTo.Enabled = False
        Me.dtpAffirmTo.Location = New System.Drawing.Point(512, 80)
        Me.dtpAffirmTo.Name = "dtpAffirmTo"
        Me.dtpAffirmTo.Size = New System.Drawing.Size(112, 21)
        Me.dtpAffirmTo.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(480, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 14)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "状态"
        '
        'cmbStatus
        '
        Me.cmbStatus.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.cmbStatus.Items.AddRange(New Object() {"已评估", "未评估", "不需评估"})
        Me.cmbStatus.Location = New System.Drawing.Point(512, 21)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(112, 20)
        Me.cmbStatus.TabIndex = 17
        '
        'FQueryOppEvaluate
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Name = "FQueryOppEvaluate"
        Me.Text = "资产评估一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Protected Overloads Overrides Sub Refresh(ByVal condition As String)

        Dim strProjectCode, strCorpName, strManager, strEvaluater, strStatus As String
        Dim dBookingFrom, dBookingTo, dAffirmFrom, dAffirmTo As Object

        strProjectCode = Me.txtProjectCode.Text.Trim()
        strcorpname = Me.txtCorpName.Text.Trim()
        strManager = Me.cmbManager.Text
        strEvaluater = Me.cmbEvaluater.Text
        strStatus = Me.cmbStatus.Text

        If Me.chkBooking.Checked Then
            dBookingFrom = Me.dtpBookingFrom.Value.Date
            dBookingTo = Me.dtpBookingTo.Value.Date
        Else
            dBookingFrom = Nothing
            dBookingTo = Nothing
        End If
        If Me.chkAffirm.Checked Then
            dAffirmFrom = Me.dtpAffirmFrom.Value.Date
            dAffirmTo = Me.dtpAffirmTo.Value.Date
        Else
            dAffirmFrom = Nothing
            dAffirmTo = Nothing
        End If

        Dim dsResult As DataSet
        Try
            dsResult = gWs.PQueryOppEvaluate(strProjectCode, strCorpName, strManager, strEvaluater, strStatus, dBookingFrom, dBookingTo, dAffirmFrom, dAffirmTo, UserName)

            Dim iCount As Int32
            iCount = dsResult.Tables(0).Rows.Count

            If Not dsResult Is Nothing Then
                Dim drNew As DataRow
                drNew = dsResult.Tables(0).NewRow
                With drNew
                    drNew.Item("corporation_name") = "合计:"
                End With
                dsResult.Tables(0).Rows.Add(drNew)
                drNew = dsResult.Tables(0).NewRow
                With drNew
                    drNew.Item("corporation_name") = "单数:" + icount.ToString()
                End With
                dsResult.Tables(0).Rows.Add(drNew)

                If Not dsResult Is Nothing Then
                    Me.grdTable.DataSource = dsResult.Tables(0)
                End If
            End If

        Catch ex As Exception
            ExceptionHandler.ShowMessageBox(ex)
        End Try

    End Sub


    Private Sub FQueryOppEvaluate_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dsManager As DataSet
        dsManager = gWs.GetStaff("%")
        Me.cmbManager.DataSource = dsManager.Tables(0)
        Me.cmbManager.DisplayMember = "staff_name"
        Me.cmbManager.ValueMember = "staff_name"

        Dim dsEvaluater As DataSet
        dsEvaluater = gWs.GetStaffByRoleID(34)
        Me.cmbEvaluater.DataSource = dsEvaluater.Tables(0)
        Me.cmbEvaluater.DisplayMember = "staff_name"
        Me.cmbEvaluater.ValueMember = "staff_name"

        Me.chkAffirm.Checked = False
        Me.chkBooking.Checked = False
    End Sub

    Private Sub chkAffirm_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAffirm.CheckedChanged
        Me.dtpAffirmFrom.Enabled = chkAffirm.Checked
        Me.dtpAffirmTo.Enabled = chkAffirm.Checked
    End Sub
    Private Sub chkBooking_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkBooking.CheckedChanged
        Me.dtpBookingFrom.Enabled = chkBooking.Checked
        Me.dtpBookingTo.Enabled = chkBooking.Checked
    End Sub

    Protected Overrides Sub Export()
        ReportToExcel.ToExcel(Me.grdTable, "", "资产评估一览表")
    End Sub
End Class
