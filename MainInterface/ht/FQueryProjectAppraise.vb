
'项目评价一览表
Public Class FQueryProjectAppraise
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
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents btnViewDetail As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Public WithEvents txtCorpName As System.Windows.Forms.TextBox
    Public WithEvents cboServiceType As System.Windows.Forms.ComboBox
    Public WithEvents txtProjectNo As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FQueryProjectAppraise))
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.cboServiceType = New System.Windows.Forms.ComboBox()
        Me.txtProjectNo = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.btnViewDetail = New System.Windows.Forms.Button()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.grpCondition.SuspendLayout()
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'chkVisible
        '
        Me.chkVisible.Location = New System.Drawing.Point(8, 72)
        Me.chkVisible.Visible = True
        '
        'btnExport
        '
        Me.btnExport.Image = CType(resources.GetObject("btnExport.Image"), System.Drawing.Bitmap)
        Me.btnExport.ImageIndex = -1
        Me.btnExport.ImageList = Nothing
        Me.btnExport.Location = New System.Drawing.Point(536, 72)
        Me.btnExport.Size = New System.Drawing.Size(77, 23)
        Me.btnExport.Visible = True
        '
        'grpCondition
        '
        Me.grpCondition.Controls.AddRange(New System.Windows.Forms.Control() {Me.txtCorpName, Me.cboServiceType, Me.txtProjectNo, Me.lbl4, Me.lbl2, Me.lbl1})
        Me.grpCondition.Size = New System.Drawing.Size(696, 56)
        Me.grpCondition.Visible = True
        '
        'btnExit
        '
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageIndex = -1
        Me.btnExit.ImageList = Nothing
        Me.btnExit.Location = New System.Drawing.Point(624, 72)
        Me.btnExit.Size = New System.Drawing.Size(77, 23)
        Me.btnExit.Visible = True
        '
        'ImageListQuery
        '
        Me.ImageListQuery.ImageStream = CType(resources.GetObject("ImageListQuery.ImageStream"), System.Windows.Forms.ImageListStreamer)
        '
        'grdTable
        '
        Me.grdTable.AccessibleName = "DataGrid"
        Me.grdTable.AccessibleRole = System.Windows.Forms.AccessibleRole.Table
        Me.grdTable.Location = New System.Drawing.Point(8, 104)
        Me.grdTable.Size = New System.Drawing.Size(696, 384)
        Me.grdTable.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        Me.grdTable.Visible = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = CType(resources.GetObject("btnRefresh.Image"), System.Drawing.Bitmap)
        Me.btnRefresh.ImageIndex = -1
        Me.btnRefresh.ImageList = Nothing
        Me.btnRefresh.Location = New System.Drawing.Point(360, 72)
        Me.btnRefresh.Size = New System.Drawing.Size(77, 23)
        Me.btnRefresh.Visible = True
        '
        'btnClear
        '
        Me.btnClear.Image = CType(resources.GetObject("btnClear.Image"), System.Drawing.Bitmap)
        Me.btnClear.ImageIndex = -1
        Me.btnClear.ImageList = Nothing
        Me.btnClear.Location = New System.Drawing.Point(192, 72)
        Me.btnClear.Size = New System.Drawing.Size(77, 23)
        Me.btnClear.Visible = True
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(280, 22)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(160, 21)
        Me.txtCorpName.TabIndex = 15
        Me.txtCorpName.Text = ""
        '
        'cboServiceType
        '
        Me.cboServiceType.Location = New System.Drawing.Point(520, 22)
        Me.cboServiceType.Name = "cboServiceType"
        Me.cboServiceType.Size = New System.Drawing.Size(152, 20)
        Me.cboServiceType.TabIndex = 14
        '
        'txtProjectNo
        '
        Me.txtProjectNo.Location = New System.Drawing.Point(80, 22)
        Me.txtProjectNo.Name = "txtProjectNo"
        Me.txtProjectNo.Size = New System.Drawing.Size(120, 21)
        Me.txtProjectNo.TabIndex = 10
        Me.txtProjectNo.Text = ""
        '
        'lbl4
        '
        Me.lbl4.Location = New System.Drawing.Point(456, 24)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(54, 16)
        Me.lbl4.TabIndex = 13
        Me.lbl4.Text = "业务品种"
        Me.lbl4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl2
        '
        Me.lbl2.Location = New System.Drawing.Point(216, 24)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(56, 16)
        Me.lbl2.TabIndex = 12
        Me.lbl2.Text = "企业名称"
        Me.lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl1
        '
        Me.lbl1.Location = New System.Drawing.Point(16, 24)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(54, 16)
        Me.lbl1.TabIndex = 11
        Me.lbl1.Text = "项目编码"
        Me.lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnViewDetail
        '
        Me.btnViewDetail.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnViewDetail.Image = CType(resources.GetObject("btnViewDetail.Image"), System.Drawing.Bitmap)
        Me.btnViewDetail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnViewDetail.ImageIndex = 4
        Me.btnViewDetail.ImageList = Me.ImageListQuery
        Me.btnViewDetail.Location = New System.Drawing.Point(448, 72)
        Me.btnViewDetail.Name = "btnViewDetail"
        Me.btnViewDetail.Size = New System.Drawing.Size(77, 23)
        Me.btnViewDetail.TabIndex = 108
        Me.btnViewDetail.Text = "明 细(&L)"
        Me.btnViewDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.grdTable
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "项目编码"
        Me.DataGridTextBoxColumn1.MappingName = "project_code"
        Me.DataGridTextBoxColumn1.NullText = ""
        Me.DataGridTextBoxColumn1.Width = 68
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "企业名称"
        Me.DataGridTextBoxColumn2.MappingName = "EnterpriseName"
        Me.DataGridTextBoxColumn2.NullText = ""
        Me.DataGridTextBoxColumn2.Width = 140
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "业务品种"
        Me.DataGridTextBoxColumn3.MappingName = "ServiceType"
        Me.DataGridTextBoxColumn3.NullText = ""
        Me.DataGridTextBoxColumn3.Width = 140
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "风险等级"
        Me.DataGridTextBoxColumn4.MappingName = "class"
        Me.DataGridTextBoxColumn4.NullText = ""
        Me.DataGridTextBoxColumn4.Width = 60
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "评价"
        Me.DataGridTextBoxColumn5.MappingName = "class_explanation"
        Me.DataGridTextBoxColumn5.NullText = ""
        Me.DataGridTextBoxColumn5.Width = 160
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "创建人"
        Me.DataGridTextBoxColumn6.MappingName = "create_person"
        Me.DataGridTextBoxColumn6.NullText = ""
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = "yy-MM-dd"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "创建时间"
        Me.DataGridTextBoxColumn7.MappingName = "create_date"
        Me.DataGridTextBoxColumn7.NullText = ""
        Me.DataGridTextBoxColumn7.Width = 72
        '
        'FQueryProjectAppraise
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(712, 493)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExport, Me.btnClear, Me.grdTable, Me.btnPrint, Me.btnExit, Me.btnRefresh, Me.chkVisible, Me.grpCondition, Me.btnViewDetail})
        Me.Name = "FQueryProjectAppraise"
        Me.Text = "项目评价一览表"
        Me.grpCondition.ResumeLayout(False)
        CType(Me.grdTable, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub FQueryProjectAppraise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt As DataTable
        dt = gWs.GetServiceType("%").Tables(0)
        Dim dr As DataRow = dt.NewRow
        dr("service_type") = ""
        dt.Rows.Add(dr)
        cboServiceType.DataSource = dt
        cboServiceType.DisplayMember = "service_type"
        cboServiceType.ValueMember = "service_type"
        cboServiceType.SelectedIndex = dt.Rows.Count - 1

        Me.ReportFile = "项目评价一览表"
        Me.ReportTitle = "项目评价一览表"
    End Sub

    Protected Overloads Sub GetCondition(ByRef projectNo As String, ByRef corporationName As String, ByRef serviceType As String)
        projectNo = txtProjectNo.Text.Trim()
        corporationName = txtCorpName.Text.Trim()
        serviceType = cboServiceType.Text.Trim()
    End Sub

    Protected Overloads Overrides Sub Refresh(ByVal condition As String)
        Dim project_code, EnterpriseName, serviceType As String

        GetCondition(project_code, EnterpriseName, serviceType)

        Dim dsResult As DataSet = gWs.GetProjectAppraisement(project_code, EnterpriseName, serviceType, UserName)

        Dim drRow As DataRow = dsResult.Tables(0).NewRow
        With drRow
            .Item("Enterprisename") = "单数：" & dsResult.Tables(0).Rows.Count.ToString
        End With
        dsResult.Tables(0).Rows.Add(drRow)

        MyBase.DataSource = dsResult.Tables(0)
        grdTable.DataSource = dsResult.Tables(0)
    End Sub

    Private Sub TextEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCorpName.Enter, cboServiceType.Enter, txtProjectNo.Enter
        If (Not sender Is Nothing) AndAlso sender.GetType() Is GetType(TextBox) Then
            CType(sender, TextBox).SelectAll()
        End If
    End Sub
    '查看明细
    Private Sub btnViewDetail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnViewDetail.Click
        If Me.grdTable.DataSource Is Nothing Then
            Return
        End If
        Dim project_code, EnterPrisement As String
        If Not IsDBNull(Me.grdTable.Item(Me.grdTable.CurrentRowIndex, 0)) Then
            project_code = Me.grdTable.Item(Me.grdTable.CurrentRowIndex, 0)
            EnterPrisement = Me.grdTable.Item(Me.grdTable.CurrentRowIndex, 1)
            Try
                Me.Cursor = Cursors.WaitCursor
                Dim frm As New frmProjectAppraisement(project_code, EnterPrisement)
                frm.AllowTransparency = False
                frm.ShowDialog()
            Catch ex As Exception
                ExceptionHandler.ShowMessageBox(ex)
            Finally
                Me.Cursor = Cursors.Default
            End Try
        End If
    End Sub

End Class
