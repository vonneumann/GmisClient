Imports System
Imports System.Data
Imports System.Data.SqlClient


Public Class FQueryConsultation
    Inherits FQueryBase
    Private struser As String

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
    Friend WithEvents chbDate As System.Windows.Forms.CheckBox
    Friend WithEvents cboDistrictName As System.Windows.Forms.ComboBox
    Friend WithEvents lblToDate As System.Windows.Forms.Label
    Friend WithEvents dtpToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtConsultName As System.Windows.Forms.TextBox
    Friend WithEvents lblConsultName As System.Windows.Forms.Label
    Friend WithEvents lblDistrictName As System.Windows.Forms.Label
    Friend WithEvents txtRecommendName As System.Windows.Forms.TextBox
    Friend WithEvents lblRecommendName As System.Windows.Forms.Label
    Friend WithEvents txtCorporationName As System.Windows.Forms.TextBox
    Friend WithEvents lblCorporationName As System.Windows.Forms.Label
    Friend WithEvents txtCorporationNo As System.Windows.Forms.TextBox
    Friend WithEvents lblCorporationNo As System.Windows.Forms.Label
    Friend WithEvents tsConsultation As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents apply_guarantee_sum As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents corporation_code As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents corporation_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents district_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents industry_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents proprietorship_type As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents is_first_loan As System.Windows.Forms.DataGridBoolColumn
    Friend WithEvents recommend_person As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents consult_person As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents consult_date As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents branch_name As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents recommend_type As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryConsultation))
        Me.chbDate = New System.Windows.Forms.CheckBox()
        Me.cboDistrictName = New System.Windows.Forms.ComboBox()
        Me.lblToDate = New System.Windows.Forms.Label()
        Me.dtpToDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpFromDate = New System.Windows.Forms.DateTimePicker()
        Me.txtConsultName = New System.Windows.Forms.TextBox()
        Me.lblConsultName = New System.Windows.Forms.Label()
        Me.lblDistrictName = New System.Windows.Forms.Label()
        Me.txtRecommendName = New System.Windows.Forms.TextBox()
        Me.lblRecommendName = New System.Windows.Forms.Label()
        Me.txtCorporationName = New System.Windows.Forms.TextBox()
        Me.lblCorporationName = New System.Windows.Forms.Label()
        Me.txtCorporationNo = New System.Windows.Forms.TextBox()
        Me.lblCorporationNo = New System.Windows.Forms.Label()
        Me.tsConsultation = New System.Windows.Forms.DataGridTableStyle()
        Me.corporation_code = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.corporation_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.apply_guarantee_sum = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.district_name = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.industry_type = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.proprietorship_type = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.is_first_loan = New System.Windows.Forms.DataGridBoolColumn()
        Me.recommend_type = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.recommend_person = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.consult_person = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.consult_date = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.branch_name = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpCondition.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(616, 112)
        Me.btnExit.Visible = True
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.CaptionFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold)
        Me.grdTable.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTable.HeaderFont = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grdTable.Size = New System.Drawing.Size(704, 352)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.tsConsultation})
        Me.grdTable.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageIndex = -1
        Me.btnRefresh.ImageList = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(440, 112)
        Me.btnRefresh.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Bitmap)
        Me.btnExport.ImageIndex = -1
        Me.btnExport.ImageList = Nothing
        Me.btnExport.Location = New System.Drawing.Point(528, 112)
        Me.btnExport.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Bitmap)
        Me.btnClear.ImageIndex = -1
        Me.btnClear.ImageList = Nothing
        Me.btnClear.Visible = True
        '
        'ImageListQuery
        '
        Me.ImageListQuery.ImageStream = CType(resources.GetObject("ImageListQuery.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'btnPrint
        '
        Me.btnPrint.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Location = New System.Drawing.Point(504, 112)
        '
        'chkVisible
        '
        Me.chkVisible.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.chbDate, Me.cboDistrictName, Me.lblToDate, Me.dtpToDate, Me.dtpFromDate, Me.txtConsultName, Me.lblConsultName, Me.lblDistrictName, Me.txtRecommendName, Me.lblRecommendName, Me.txtCorporationName, Me.lblCorporationName, Me.txtCorporationNo, Me.lblCorporationNo})
        Me.grpCondition.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCondition.Visible = True
        '
        'chbDate
        '
        Me.chbDate.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbDate.Location = New System.Drawing.Point(24, 63)
        Me.chbDate.Name = "chbDate"
        Me.chbDate.Size = New System.Drawing.Size(80, 24)
        Me.chbDate.TabIndex = 51
        Me.chbDate.Text = "咨询日期"
        '
        'cboDistrictName
        '
        Me.cboDistrictName.Location = New System.Drawing.Point(504, 16)
        Me.cboDistrictName.Name = "cboDistrictName"
        Me.cboDistrictName.Size = New System.Drawing.Size(120, 20)
        Me.cboDistrictName.TabIndex = 44
        '
        'lblToDate
        '
        Me.lblToDate.AutoSize = True
        Me.lblToDate.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblToDate.Location = New System.Drawing.Point(280, 68)
        Me.lblToDate.Name = "lblToDate"
        Me.lblToDate.Size = New System.Drawing.Size(17, 14)
        Me.lblToDate.TabIndex = 49
        Me.lblToDate.Text = "到"
        '
        'dtpToDate
        '
        Me.dtpToDate.Location = New System.Drawing.Point(304, 64)
        Me.dtpToDate.Name = "dtpToDate"
        Me.dtpToDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpToDate.TabIndex = 50
        '
        'dtpFromDate
        '
        Me.dtpFromDate.CalendarFont = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFromDate.Location = New System.Drawing.Point(104, 64)
        Me.dtpFromDate.Name = "dtpFromDate"
        Me.dtpFromDate.Size = New System.Drawing.Size(120, 21)
        Me.dtpFromDate.TabIndex = 48
        '
        'txtConsultName
        '
        Me.txtConsultName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConsultName.Location = New System.Drawing.Point(304, 40)
        Me.txtConsultName.Name = "txtConsultName"
        Me.txtConsultName.Size = New System.Drawing.Size(120, 21)
        Me.txtConsultName.TabIndex = 46
        Me.txtConsultName.Text = ""
        '
        'lblConsultName
        '
        Me.lblConsultName.AutoSize = True
        Me.lblConsultName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsultName.Location = New System.Drawing.Point(248, 43)
        Me.lblConsultName.Name = "lblConsultName"
        Me.lblConsultName.Size = New System.Drawing.Size(54, 14)
        Me.lblConsultName.TabIndex = 45
        Me.lblConsultName.Text = "咨询人员"
        '
        'lblDistrictName
        '
        Me.lblDistrictName.AutoSize = True
        Me.lblDistrictName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistrictName.Location = New System.Drawing.Point(448, 20)
        Me.lblDistrictName.Name = "lblDistrictName"
        Me.lblDistrictName.Size = New System.Drawing.Size(54, 14)
        Me.lblDistrictName.TabIndex = 43
        Me.lblDistrictName.Text = "所属地区"
        '
        'txtRecommendName
        '
        Me.txtRecommendName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRecommendName.Location = New System.Drawing.Point(104, 40)
        Me.txtRecommendName.Name = "txtRecommendName"
        Me.txtRecommendName.Size = New System.Drawing.Size(120, 21)
        Me.txtRecommendName.TabIndex = 42
        Me.txtRecommendName.Text = ""
        '
        'lblRecommendName
        '
        Me.lblRecommendName.AutoSize = True
        Me.lblRecommendName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRecommendName.Location = New System.Drawing.Point(48, 43)
        Me.lblRecommendName.Name = "lblRecommendName"
        Me.lblRecommendName.Size = New System.Drawing.Size(54, 14)
        Me.lblRecommendName.TabIndex = 41
        Me.lblRecommendName.Text = "推荐人名"
        '
        'txtCorporationName
        '
        Me.txtCorporationName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorporationName.Location = New System.Drawing.Point(304, 16)
        Me.txtCorporationName.Name = "txtCorporationName"
        Me.txtCorporationName.Size = New System.Drawing.Size(120, 21)
        Me.txtCorporationName.TabIndex = 40
        Me.txtCorporationName.Text = ""
        '
        'lblCorporationName
        '
        Me.lblCorporationName.AutoSize = True
        Me.lblCorporationName.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorporationName.Location = New System.Drawing.Point(248, 19)
        Me.lblCorporationName.Name = "lblCorporationName"
        Me.lblCorporationName.Size = New System.Drawing.Size(54, 14)
        Me.lblCorporationName.TabIndex = 39
        Me.lblCorporationName.Text = "企业名称"
        '
        'txtCorporationNo
        '
        Me.txtCorporationNo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorporationNo.Location = New System.Drawing.Point(104, 16)
        Me.txtCorporationNo.Name = "txtCorporationNo"
        Me.txtCorporationNo.Size = New System.Drawing.Size(120, 21)
        Me.txtCorporationNo.TabIndex = 38
        Me.txtCorporationNo.Text = ""
        '
        'lblCorporationNo
        '
        Me.lblCorporationNo.AutoSize = True
        Me.lblCorporationNo.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorporationNo.Location = New System.Drawing.Point(48, 19)
        Me.lblCorporationNo.Name = "lblCorporationNo"
        Me.lblCorporationNo.Size = New System.Drawing.Size(54, 14)
        Me.lblCorporationNo.TabIndex = 37
        Me.lblCorporationNo.Text = "企业编号"
        '
        'tsConsultation
        '
        Me.tsConsultation.DataGrid = Me.grdTable
        Me.tsConsultation.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.corporation_code, Me.corporation_name, Me.apply_guarantee_sum, Me.district_name, Me.industry_type, Me.proprietorship_type, Me.is_first_loan, Me.recommend_type, Me.recommend_person, Me.consult_person, Me.consult_date, Me.branch_name})
        Me.tsConsultation.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.tsConsultation.MappingName = "Table"
        '
        'corporation_code
        '
        Me.corporation_code.Format = ""
        Me.corporation_code.FormatInfo = Nothing
        Me.corporation_code.HeaderText = "企业编号"
        Me.corporation_code.MappingName = "corporation_code"
        Me.corporation_code.NullText = ""
        Me.corporation_code.Width = 80
        '
        'corporation_name
        '
        Me.corporation_name.Format = ""
        Me.corporation_name.FormatInfo = Nothing
        Me.corporation_name.HeaderText = "企业名称"
        Me.corporation_name.MappingName = "corporation_name"
        Me.corporation_name.NullText = ""
        Me.corporation_name.Width = 200
        '
        'apply_guarantee_sum
        '
        Me.apply_guarantee_sum.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.apply_guarantee_sum.Format = ""
        Me.apply_guarantee_sum.FormatInfo = Nothing
        Me.apply_guarantee_sum.HeaderText = "咨询金额(万元)"
        Me.apply_guarantee_sum.MappingName = "apply_guarantee_sum"
        Me.apply_guarantee_sum.NullText = ""
        Me.apply_guarantee_sum.Width = 120
        '
        'district_name
        '
        Me.district_name.Format = ""
        Me.district_name.FormatInfo = Nothing
        Me.district_name.HeaderText = "所属地区"
        Me.district_name.MappingName = "district_name"
        Me.district_name.NullText = ""
        Me.district_name.Width = 90
        '
        'industry_type
        '
        Me.industry_type.Format = ""
        Me.industry_type.FormatInfo = Nothing
        Me.industry_type.HeaderText = "所属行业"
        Me.industry_type.MappingName = "industry_type"
        Me.industry_type.NullText = ""
        Me.industry_type.Width = 75
        '
        'proprietorship_type
        '
        Me.proprietorship_type.Format = ""
        Me.proprietorship_type.FormatInfo = Nothing
        Me.proprietorship_type.HeaderText = "所有制类型"
        Me.proprietorship_type.MappingName = "proprietorship_type"
        Me.proprietorship_type.NullText = ""
        Me.proprietorship_type.Width = 170
        '
        'is_first_loan
        '
        Me.is_first_loan.FalseValue = False
        Me.is_first_loan.HeaderText = "首次贷款"
        Me.is_first_loan.MappingName = "is_first_loan"
        Me.is_first_loan.NullText = ""
        Me.is_first_loan.NullValue = Nothing
        Me.is_first_loan.TrueValue = True
        Me.is_first_loan.Width = 60
        '
        'recommend_type
        '
        Me.recommend_type.Format = ""
        Me.recommend_type.FormatInfo = Nothing
        Me.recommend_type.HeaderText = "推荐类型"
        Me.recommend_type.MappingName = "recommend_type"
        Me.recommend_type.NullText = ""
        Me.recommend_type.Width = 75
        '
        'recommend_person
        '
        Me.recommend_person.Format = ""
        Me.recommend_person.FormatInfo = Nothing
        Me.recommend_person.HeaderText = "推荐人"
        Me.recommend_person.MappingName = "recommend_person"
        Me.recommend_person.NullText = ""
        Me.recommend_person.Width = 75
        '
        'consult_person
        '
        Me.consult_person.Format = ""
        Me.consult_person.FormatInfo = Nothing
        Me.consult_person.HeaderText = "咨询人"
        Me.consult_person.MappingName = "consult_person"
        Me.consult_person.NullText = ""
        Me.consult_person.Width = 75
        '
        'consult_date
        '
        Me.consult_date.Format = "yyyy-MM-dd"
        Me.consult_date.FormatInfo = Nothing
        Me.consult_date.HeaderText = "咨询日期"
        Me.consult_date.MappingName = "consult_date"
        Me.consult_date.NullText = ""
        Me.consult_date.Width = 80
        '
        'branch_name
        '
        Me.branch_name.Format = ""
        Me.branch_name.FormatInfo = Nothing
        Me.branch_name.HeaderText = "受理部门"
        Me.branch_name.MappingName = "branch_name"
        Me.branch_name.NullText = ""
        Me.branch_name.Width = 75
        '
        'FQueryConsultation
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 501)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition})
        Me.Font = New System.Drawing.Font("宋体", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(600, 400)
        Me.Name = "FQueryConsultation"
        Me.Text = "咨询企业一览表"
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpCondition.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region


    Private Sub FConsultation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpFromDate.Value = DateTime.Today
        dtpToDate.Value = DateTime.Today

        cboDistrictName.DataSource = gWs.GetDistrict("%").Tables(0)
        cboDistrictName.DisplayMember = "district_name"
        cboDistrictName.ValueMember = "district_name"
        cboDistrictName.SelectedIndex = -1

        Me.dtpFromDate.Enabled = False
        Me.dtpToDate.Enabled = False

    End Sub

    Private Sub TextEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If (Not sender Is Nothing) AndAlso sender.GetType() Is GetType(TextBox) Then
            CType(sender, TextBox).SelectAll()
        End If
    End Sub

    Protected Overrides Sub Export()
        Dim export As New ReportToExcel()
        export.ToExcel(Me.grdTable, "咨询企业一览表", "咨询企业一览表")
    End Sub

    Private Sub chbDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbDate.CheckedChanged
        Me.dtpFromDate.Enabled = Me.chbDate.Checked
        Me.dtpToDate.Enabled = Me.chbDate.Checked
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim strCorpCode, strCorpName, strDistrictName, strRecommendPerson, strConsultPerson As String
        Dim dtDateFrom, dtDateTo As Object
        Dim i As Integer
        Dim iTotalSum As Decimal


        'add wuxiaoliang query condition
        strCorpCode = txtCorporationNo.Text.Trim
        strCorpName = txtCorporationName.Text.Trim
        strDistrictName = cboDistrictName.Text.Trim
        strRecommendPerson = txtRecommendName.Text.Trim
        strConsultPerson = txtConsultName.Text.Trim
        dtDateFrom = IIf(chbDate.Checked, dtpFromDate.Value.Date, Nothing)
        dtDateTo = IIf(chbDate.Checked, dtpToDate.Value.Date, Nothing)

        'Me.struser = UserName
        'Dim TeamName As String = getStaffTeamName(struser)
        Try
            Me.Cursor = Cursors.WaitCursor
            'If TeamName = "总部" Then

            Dim rsResult As DataSet = gWs.Usp_ListConsultation(strCorpCode, strCorpName, strDistrictName, strRecommendPerson, strConsultPerson, dtDateFrom, dtDateTo, UserName)

            For i = 0 To rsResult.Tables(0).Rows.Count - 1
                If Not rsResult.Tables(0).Rows(i).Item("apply_guarantee_sum") Is System.DBNull.Value Then
                    iTotalSum = iTotalSum + CDec(rsResult.Tables(0).Rows(i).Item("apply_guarantee_sum"))
                End If
            Next

            Dim drRow As DataRow = rsResult.Tables(0).NewRow
            With drRow
                .Item("corporation_name") = "合计："
                .Item("apply_guarantee_sum") = iTotalSum
            End With
            rsResult.Tables(0).Rows.Add(drRow)

            drRow = rsResult.Tables(0).NewRow
            With drRow
                .Item("corporation_name") = "单数：" & i
            End With
            rsResult.Tables(0).Rows.Add(drRow)

            Me.grdTable.DataSource = rsResult.Tables(0)
            Me.Text = "咨询企业一览表" '+ rsResult.Tables(0).Rows.Count.ToString + ")"
            'Else
            'Dim dsProject As DataSet
            'dsProject = gWs.GetProjectInfo(strCorpCode)
            'Dim rsResult1 As DataSet = gWs.Usp_ListConsultation(strCorpCode, strCorpName, strDistrictName, strRecommendPerson, strConsultPerson, dtDateFrom, dtDateTo, UserName)
            ''rsResult1.Tables(0).DefaultView.RowFilter = "TeamName <>'" & dsProject.Tables("project").Rows(0).Item("applicantTeam_name") & "'"
            'For i = 0 To rsResult1.Tables(0).Rows.Count - 1
            '    If Not rsResult1.Tables(0).Rows(i).Item("apply_guarantee_sum") Is System.DBNull.Value Then
            '        iTotalSum = iTotalSum + CDec(rsResult1.Tables(0).Rows(i).Item("apply_guarantee_sum"))
            '    End If
            'Next

            'Dim drRow As DataRow = rsResult1.Tables(0).NewRow
            'With drRow
            '    .Item("corporation_name") = "合计："
            '    .Item("apply_guarantee_sum") = iTotalSum
            'End With
            'rsResult1.Tables(0).Rows.Add(drRow)

            'drRow = rsResult1.Tables(0).NewRow
            'With drRow
            '    .Item("corporation_name") = "单数：" & i
            'End With
            'rsResult1.Tables(0).Rows.Add(drRow)

            'Me.grdTable.DataSource = rsResult1.Tables(0)
            'Me.Text = "咨询企业一览表" '+ rsResult.Tables(0).Rows.Count.ToString + ")"
            'End If

        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class
