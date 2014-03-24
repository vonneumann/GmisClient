Public Class frmQueryDefectRecord
    Inherits System.Windows.Forms.Form

    Protected dsConsult As DataSet

    'Protected dsCorpA As DataSet
    Protected dsConsultA As DataSet

    Private corpIndex As Integer = 0    ' 企业信息的位置
    Private consultIndex As Integer = 0 ' 咨询信息的位置

    'qxd add 2003-6-23
    Private strCorporationCode As String
    Private strSerialNum As String = "1"
    Private isNoCommited As Boolean = False
    Private strProjectCode As String

    Public Event refreshTask()

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Public WithEvents btnQuery As System.Windows.Forms.Button
    Public WithEvents Label2 As System.Windows.Forms.Label
    Public WithEvents Label1 As System.Windows.Forms.Label
    Public WithEvents txtCorpCode As System.Windows.Forms.TextBox
    Public WithEvents txtCorpName As System.Windows.Forms.TextBox
    Public WithEvents dgQueryResult As System.Windows.Forms.DataGrid
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmQueryDefectRecord))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtCorpCode = New System.Windows.Forms.TextBox()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgQueryResult = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox1.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnQuery, Me.txtCorpCode, Me.txtCorpName, Me.Label2, Me.Label1})
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(614, 48)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnQuery
        '
        Me.btnQuery.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnQuery.Image = CType(resources.GetObject("btnQuery.Image"), System.Drawing.Bitmap)
        Me.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnQuery.ImageIndex = 2
        Me.btnQuery.ImageList = Me.ImageList1
        Me.btnQuery.Location = New System.Drawing.Point(520, 14)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.Size = New System.Drawing.Size(77, 24)
        Me.btnQuery.TabIndex = 9
        Me.btnQuery.Text = "查 询(&Q)"
        Me.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'txtCorpCode
        '
        Me.txtCorpCode.Location = New System.Drawing.Point(64, 17)
        Me.txtCorpCode.MaxLength = 5
        Me.txtCorpCode.Name = "txtCorpCode"
        Me.txtCorpCode.Size = New System.Drawing.Size(112, 21)
        Me.txtCorpCode.TabIndex = 8
        Me.txtCorpCode.Text = ""
        Me.txtCorpCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCorpName
        '
        Me.txtCorpName.Anchor = ((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.txtCorpName.Location = New System.Drawing.Point(280, 17)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(216, 21)
        Me.txtCorpName.TabIndex = 7
        Me.txtCorpName.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "企业编码"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(224, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "企业名称"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.GroupBox2.Controls.AddRange(New System.Windows.Forms.Control() {Me.dgQueryResult})
        Me.GroupBox2.Location = New System.Drawing.Point(8, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(614, 368)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "失信记录"
        '
        'dgQueryResult
        '
        Me.dgQueryResult.CaptionVisible = False
        Me.dgQueryResult.DataMember = ""
        Me.dgQueryResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgQueryResult.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.dgQueryResult.Location = New System.Drawing.Point(3, 17)
        Me.dgQueryResult.Name = "dgQueryResult"
        Me.dgQueryResult.Size = New System.Drawing.Size(608, 348)
        Me.dgQueryResult.TabIndex = 0
        Me.dgQueryResult.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgQueryResult
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "Table"
        Me.DataGridTableStyle1.ReadOnly = True
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "企业编码"
        Me.DataGridTextBoxColumn1.MappingName = "corporation_code"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "企业名称"
        Me.DataGridTextBoxColumn2.MappingName = "corporation_name"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "失信日期"
        Me.DataGridTextBoxColumn3.MappingName = "DiscreditableDate"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "来源"
        Me.DataGridTextBoxColumn4.MappingName = "source"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "登记人员"
        Me.DataGridTextBoxColumn5.MappingName = "create_person"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "登记时间"
        Me.DataGridTextBoxColumn6.MappingName = "create_date"
        Me.DataGridTextBoxColumn6.Width = 75
        '
        'btnExit
        '
        Me.btnExit.Anchor = (System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Image = CType(resources.GetObject("btnExit.Image"), System.Drawing.Bitmap)
        Me.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExit.ImageIndex = 1
        Me.btnExit.ImageList = Me.ImageList1
        Me.btnExit.Location = New System.Drawing.Point(544, 432)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(77, 24)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "退 出(&X)"
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "失信描述"
        Me.DataGridTextBoxColumn7.MappingName = "description"
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'frmQueryDefectRecord
        '
        Me.AcceptButton = Me.btnQuery
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(632, 461)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnExit, Me.GroupBox2, Me.GroupBox1})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmQueryDefectRecord"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "企业失信记录查询"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgQueryResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    '
    '企业数据集
    '
    Protected dsCorp As DataSet
    Protected queryString As String

    Private Overloads Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        queryAccept()
    End Sub
    '查询受理
    Private Sub queryAccept()
        Dim strWhere As String = "corporation_code is not null order by corporation_code desc"
        Dim nameNULL As Boolean = (Me.txtCorpName.Text = "")
        Dim codeNULL As Boolean = (Me.txtCorpCode.Text = "")

        dsCorp = Nothing
        dgQueryResult.DataSource = Nothing

        Try
            If (codeNULL) Then
                If Me.txtCorpName.Text = "" Then
                    Dim strSql As String
                    strSql = "select * from corporation_defect_record where corporation_code is not null order by corporation_code desc" ' "{corporation_type='1'}"
                    dsCorp = gWs.GetCommonQueryInfo(strSql)
                    'dgQueryResult.DataMember = "corporation"
                    'dgQueryResult.DataSource = dsCorp
                Else
                    strWhere = "select * from corporation_defect_record where corporation_name like '%" + Me.txtCorpName.Text + "%' order by corporation_code desc"
                End If
            Else
                strWhere = "select * from corporation_defect_record where corporation_code='" + Me.txtCorpCode.Text & "' order by corporation_code desc"
            End If

            If dsCorp Is Nothing Then dsCorp = gWs.GetCommonQueryInfo(strWhere)
            ''只添加一次,以显示科技类型
            'dsCorp.Tables("corporation").Columns.Add("technology_name", GetType(String))
            'dsCorp.Tables("corporation").Columns.Add("high_risk", GetType(String))
            'dsCorp.Tables("corporation").Columns.Add("continue_support", GetType(String))
            ''获取科技类型
            'Dim i As Integer
            'Dim dr As DataRow
            'i = dsCorp.Tables("corporation").Rows.Count
            'If i > 0 Then
            '    For i = 0 To i - 1
            '        dr = dsCorp.Tables("corporation").Rows(i)
            '        With dr
            '            If .Item("technology_type") Is System.DBNull.Value Then
            '                .Item("technology_name") = ""
            '            Else
            '                .Item("technology_name") = getTechnologyType(.Item("technology_type"))
            '            End If
            '            If Not .Item("is_high_risk") Is System.DBNull.Value Then
            '                If .Item("is_high_risk") Then
            '                    .Item("high_risk") = "是"
            '                Else
            '                    .Item("high_risk") = "否"
            '                End If
            '            Else
            '                .Item("high_risk") = ""
            '            End If
            '            If Not .Item("is_continue_support") Is System.DBNull.Value Then
            '                If .Item("is_continue_support") Then
            '                    .Item("continue_support") = "是"
            '                Else
            '                    .Item("continue_support") = "否"
            '                End If
            '            Else
            '                .Item("continue_support") = ""
            '            End If
            '        End With
            '    Next
            'End If

            If Not dsCorp Is Nothing Then
                If dsCorp.Tables(0).Rows.Count <> 0 Then
                    Me.dgQueryResult.DataSource = dsCorp.Tables(0)
                    setDgAttribute(Me.dgQueryResult, Me)
                End If
            End If
        Catch ex As Exception
            'MsgBox(ex.Message, MsgBoxStyle.Exclamation, "受理申请")
            ExceptionHandler.ShowMessageBox(ex)
        End Try
    End Sub

    '退出
    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
    '企业编码
    Private Sub txtCorpCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCorpCode.KeyPress
        e.Handled = Not (Char.IsDigit(e.KeyChar) Or Char.IsControl(e.KeyChar))
    End Sub
   
End Class
